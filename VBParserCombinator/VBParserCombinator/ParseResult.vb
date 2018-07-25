Public Class ParseResult

    Public ReadOnly Property Success() As Boolean
    Public ReadOnly Property Result() As String
    Public ReadOnly Property InnerResult() As IEnumerable(Of ParseResult)
    Public ReadOnly Property NextPosition() As Integer

    Public Sub New(success As Boolean, result As String, inner As IEnumerable(Of ParseResult), nextPosition As Integer)
        Me.Success = success
        Me.Result = result
        Me.InnerResult = If(inner, Enumerable.Empty(Of ParseResult)())
        Me.NextPosition = nextPosition
    End Sub

    Public Overrides Function ToString() As String
        Return $"[{Success}, {Result}, [{String.Join(",", InnerResult)}], {NextPosition}]"
    End Function

End Class
