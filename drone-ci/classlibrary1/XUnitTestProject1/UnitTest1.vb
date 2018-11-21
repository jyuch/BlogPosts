Imports System
Imports Xunit
Imports ClassLibrary1

Public Class Class1Test

    <Fact>
    Sub Add_return_valid_value()
        Dim x = 10 : Dim y = 20
        Dim expected = x + y

        Dim c = New Class1()

        Assert.Equal(expected, c.Add(x, y))
    End Sub

End Class
