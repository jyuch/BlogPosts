Imports TestDriver

Module Module1

    Public Const DataSize = 100000000

    Sub Main()
        Dim data = InitData()

        Runner.Run(Sub() SingleReduction(data), NameOf(SingleReduction))
        Runner.Run(Sub() GoodParallel.AddParallel(data), NameOf(GoodParallel))
        Runner.Run(Sub() data.AsParallel().Sum(), "PLINQ")
    End Sub

    Function SingleReduction(data As Long()) As Long
        Dim sum = 0L

        For i = 0 To DataSize - 1
            sum += data(i)
        Next

        Return sum
    End Function

    Function InitData() As Long()
        Dim a(DataSize - 1) As Long
        Dim r = New Random(1)

        For i = 0 To DataSize - 1
            a(i) = r.Next(10)
        Next

        Return a
    End Function

End Module
