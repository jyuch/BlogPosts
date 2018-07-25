Public Class Normal

    Public Shared Sub FizzBuzz([end] As Integer)
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

End Class

Public Class Linq

    Public Shared Sub FizzBuzz([end] As Integer)
        Enumerable.Range(1, [end]).
            Select(AddressOf Map).
            ToList().
            ForEach(AddressOf Console.WriteLine)
    End Sub

    Private Shared Function Map(value As Integer) As String
        If value Mod 15 = 0 Then
            Return "fizzbuzz"
        ElseIf value Mod 5 = 0 Then
            Return "buzz"
        ElseIf value Mod 3 = 0 Then
            Return "fizz"
        Else
            Return value.ToString
        End If
    End Function

End Class

Public Class Recursion

    Public Shared Sub FizzBuzz([end] As Integer)
        Internal(1, [end])
    End Sub

    Private Shared Sub Internal(current As Integer, [end] As Integer)
        Console.WriteLine(Map(current))
        If current < [end] Then
            Internal(current + 1, [end])
        End If
    End Sub

    Private Shared Function Map(value As Integer) As String
        If value Mod 15 = 0 Then
            Return "fizzbuzz"
        ElseIf value Mod 5 = 0 Then
            Return "buzz"
        ElseIf value Mod 3 = 0 Then
            Return "fizz"
        Else
            Return value.ToString
        End If
    End Function

End Class

Public Class Gotou

    Public Shared Sub FizzBuzz([end] As Integer)
        Dim current = 0
Start:
        current = current + 1
        If current > [end] Then GoTo Fin

        If current Mod 15 = 0 Then
            Console.WriteLine("fizzbuzz")
            GoTo Start
        End If

        If current Mod 5 = 0 Then
            Console.WriteLine("buzz")
            GoTo Start
        End If

        If current Mod 3 = 0 Then
            Console.WriteLine("fizz")
            GoTo Start
        End If

        Console.WriteLine(current)
        GoTo Start
Fin:
    End Sub

End Class
