Imports NMeCab

Public Class SentenceSplitter

    Private Sub New()
        ' Nothing to do.
    End Sub

    Public Shared Function Split(sentence As IEnumerable(Of String)) As IEnumerable(Of String)
        Dim param = New MeCabParam() With {.DicDir = ".\ipadic"}
        Dim words = New List(Of String)

        Using mecab = MeCabTagger.Create(param)
            For Each it In sentence
                Dim node = mecab.ParseToNode(it)

                While Not node Is Nothing
                    If node.Feature Is Nothing Then
                        node = node.Next
                        Continue While
                    End If

                    words.Add(node.Surface)

                    node = node.Next
                End While
            Next
        End Using

        Return words
    End Function

End Class
