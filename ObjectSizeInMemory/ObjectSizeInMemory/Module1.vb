Module Module1

    Private Const ArraySize As Integer = 30000

    Sub Main()
        Dim hoges(ArraySize - 1) As Hoge

        for i = 0 To ArraySize - 1
            hoges(i) = CreateRandomHoge()
        Next

        Dim a = hoges(0)
        ' ここでの hoges のサイズが知りたい。
        Console.ReadLine()

        Console.WriteLine($"{hoges(CInt(ArraySize / 2)).id}, {hoges(cint(ArraySize/2)).Name}")
        Console.WriteLine(a)
    End Sub

    Function CreateRandomHoge() As Hoge
        Static rand As Random = New Random()
        Return New Hoge() With {.Id = rand.Next(), .Name = RandomString()}
    End Function

    Function RandomString() As String
        Static rand As Random = New Random()

        Dim a = ""
        For i = 1 To 100
            a += rand.Next(10).ToString()
        Next
        Return a
    End Function

End Module

Class Hoge
    Public Id As Integer
    ' 100文字のランダムな文字列
    Public Name As String
End Class
