Imports Microsoft.Z3

Module Program

    Sub Main()
        Dim opt = New Dictionary(Of String, String)
        opt("proof") = "true"

        Using c = New Context(opt)
            Dim solver = c.MkSolver()

            Dim cells(8)() As IntExpr

            ' x_1_1 から x_9_9のシンボルを生成
            For i = 0 To 8
                Dim r(8) As IntExpr
                cells(i) = r

                For j = 0 To 8
                    cells(i)(j) = CType(c.MkConst(c.MkSymbol($"x_{i + 1}_{j + 1}"), c.IntSort), IntExpr)
                Next
            Next

            ' (assert (and (<= 1, x_?_?) (>= x_?_? 9)))
            For i = 0 To 8
                For j = 0 To 8
                    solver.Assert(
                        c.MkAnd(
                            c.MkLe(c.MkInt(1), cells(i)(j)),
                            c.MkLe(cells(i)(j), c.MkInt(9))))
                Next
            Next

            ' (assert (distinct x_?_1 ... x_?_9))
            For i = 0 To 8
                solver.Assert(c.MkDistinct(cells(i)))
            Next

            ' (assert (distinct x_1_? ... x_9_?))
            For j = 0 To 8
                Dim col(8) As IntExpr

                For i = 0 To 8
                    col(i) = cells(i)(j)
                Next

                solver.Assert(c.MkDistinct(col))
            Next

            ' (assert (distinct 3x3のあのマス))
            For i0 = 0 To 2
                For j0 = 0 To 2
                    Dim square(8) As IntExpr

                    For i = 0 To 2
                        For j = 0 To 2
                            square(3 * i + j) = cells(3 * i0 + i)(3 * j0 + j)
                        Next
                    Next
                    solver.Assert(c.MkDistinct(square))
                Next
            Next

            Dim inst =
            {
                {0, 0, 5, 3, 0, 0, 0, 0, 0},
                {8, 0, 0, 0, 0, 0, 0, 2, 0},
                {0, 7, 0, 0, 1, 0, 5, 0, 0},
                {4, 0, 0, 0, 0, 5, 3, 0, 0},
                {0, 1, 0, 0, 7, 0, 0, 0, 6},
                {0, 0, 3, 2, 0, 0, 0, 8, 0},
                {0, 6, 0, 5, 0, 0, 0, 0, 9},
                {0, 0, 4, 0, 0, 0, 0, 3, 0},
                {0, 0, 0, 0, 0, 9, 7, 0, 0}
            }

            For i = 0 To 8
                For j = 0 To 8
                    If inst(i, j) <> 0 Then
                        solver.Assert(c.MkEq(c.MkInt(inst(i, j)), cells(i)(j)))
                    End If
                Next
            Next

            If solver.Check() = Status.SATISFIABLE Then
                Dim m = solver.Model

                For Each i In cells
                    For Each j In i
                        Console.Write($"{m.Evaluate(j)} ")
                    Next
                    Console.WriteLine()
                Next
            Else
                Console.WriteLine("Failed to solve sudoku")
            End If

        End Using
    End Sub

End Module
