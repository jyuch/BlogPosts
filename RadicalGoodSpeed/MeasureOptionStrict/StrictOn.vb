Option Strict On

Public Module StrictOn

    Public Sub [On]()
        Result += Add(Date.Now.Second, Date.Now.Second)
    End Sub

    Private Function Add(x As Integer, y As Integer) As Integer
        Return x + y
    End Function

End Module