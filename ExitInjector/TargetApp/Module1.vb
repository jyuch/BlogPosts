Module Module1

    Sub Main()
        FizzBuzz(100)
    End Sub

    Sub FizzBuzz([end] As Integer)
        For i = 1 To [end]
            If i Mod 15 = 0 Then
                Console.WriteLine("fizzbuzz")
            ElseIf i Mod 5 = 0 Then
                Console.WriteLine("buzz")
            ElseIf i Mod 3 = 0 Then
                Console.WriteLine("fizz")
            Else
                Console.WriteLine(i)
            End If
        Next
    End Sub

End Module
