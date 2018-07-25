Friend Class SuperUsefulClass(Of T)

    Private Class Cell
        Public v As T
        Public n As Cell
    End Class

    Private _n As Cell
    Private _count As Integer

    Friend ReadOnly Property Count() As Integer
        Get
            Return _count
        End Get
    End Property

    Friend Sub Push(value As T)
        Dim a = New Cell
        a.v = value
        a.n = _n
        _n = a
        _count += 1
    End Sub

    Friend Function Pop() As T
        If _n Is Nothing Then Throw New InvalidOperationException()

        _count -= 1
        Dim a = _n
        _n = a.n
        Return a.v
    End Function

End Class