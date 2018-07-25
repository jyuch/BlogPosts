Imports System.Text.RegularExpressions

Public Class HanFilter

    Private Sub New()
        ' Nothing to do.
    End Sub

    Public Shared Function HasHan(word As String) As Boolean
        Return Regex.IsMatch(word, ".*[\p{IsCJKUnifiedIdeographs}]+.*")
    End Function

End Class
