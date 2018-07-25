Option Strict Off

Public Module StrictOff

    Public Sub Off()
        Result += Add(Date.Now.Second, Date.Now.Second)
    End Sub

    Private Function Add(x, y)
        Return x + y
    End Function

End Module