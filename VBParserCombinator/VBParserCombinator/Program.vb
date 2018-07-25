Module Program

    Sub Main()
        Dim r = Expression("1+2+(3+(5-6))", 0)
        Console.WriteLine(r)

        Display(r, 0)
        Console.WriteLine($"result: {Calc(r.InnerResult)}")
    End Sub

    Sub Display(result As ParseResult, level As Integer)
        If Not ReferenceEquals(result.Result, Nothing) Then
            Console.WriteLine($"{New String(" "c, level)} {result.Result}")
        Else
            For Each it In result.InnerResult
                Display(it, level + 1)
            Next
        End If
    End Sub

    Function Calc(results As IEnumerable(Of ParseResult)) As Integer
        Dim r = New Queue(Of ParseResult)(results)
        Dim sum = 0

        Dim first = r.Dequeue()
        If Not ReferenceEquals(first.Result, Nothing) Then
            sum += Integer.Parse(first.Result)
        Else
            sum += Calc(first.InnerResult)
        End If

        While r.Count <> 0
            Dim op = r.Dequeue().Result
            Dim operand = r.Dequeue()
            Dim operandNum As Integer

            If Not ReferenceEquals(operand.Result, Nothing) Then
                operandNum = Integer.Parse(operand.Result)
            Else
                operandNum = Calc(operand.InnerResult)
            End If

            If op = "+" Then
                sum += operandNum
            Else
                sum -= operandNum
            End If
        End While

        Return sum
    End Function

    Property Number As Func(Of String, Integer, ParseResult) =
        Parser.Accumlate(Parser.Seq(Parser.Char("123456789"), Parser.Many(Parser.Char("0123456789"))))

    Property [Operator] As Func(Of String, Integer, ParseResult) = Parser.Char("+-")

    Property Parenthesis As Func(Of String, Integer, ParseResult) = Parser.Lazy(
        Function() As Func(Of String, Integer, ParseResult)
            Return Function(text As String, position As Integer) As ParseResult
                       Dim p = Parser.Seq(Parser.Token("("), Expression, Parser.Token(")"))
                       Dim r = p(text, position)

                       If r.Success Then
                           Return r.InnerResult.Skip(1).First()
                       Else
                           Return New ParseResult(False, Nothing, Nothing, position)
                       End If
                   End Function
        End Function)

    Property Atom As Func(Of String, Integer, ParseResult) =
        Parser.Or(Number, Parenthesis)

    Property Expression As Func(Of String, Integer, ParseResult) =
        Function(text As String, position As Integer) As ParseResult
            Dim p = Parser.Seq(Atom, Parser.Many(Parser.Seq([Operator], Atom)))
            Dim r = p(text, position)

            If Not r.Success Then
                Return New ParseResult(False, Nothing, Nothing, position)
            End If

            Dim ir = r.InnerResult.ToList()

            If ir.Count = 1 Then
                Return ir(0)
            Else
                Dim rs = New List(Of ParseResult)()

                rs.Add(ir(0))
                For Each i In ir(1).InnerResult
                    For Each it In i.InnerResult
                        rs.Add(it)
                    Next
                Next

                Return New ParseResult(True, Nothing, rs, r.NextPosition)
            End If
        End Function

End Module
