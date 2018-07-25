Imports System.Text

Public NotInheritable Class Parser

    Public Shared Function [Char](chars As String) As Func(Of String, Integer, ParseResult)
        Return Function(text As String, position As Integer) As ParseResult
                   Dim c = Substring(text, position, 1)

                   If c <> "" AndAlso chars.Contains(c) Then
                       Return New ParseResult(True, c, Nothing, position + 1)
                   Else
                       Return New ParseResult(False, Nothing, Nothing, position)
                   End If
               End Function
    End Function

    Public Shared Function Token(word As String) As Func(Of String, Integer, ParseResult)
        Return Function(text As String, position As Integer) As ParseResult
                   If Substring(text, position, word.Length) = word Then
                       Return New ParseResult(True, word, Nothing, position + word.Length)
                   Else
                       Return New ParseResult(False, Nothing, Nothing, position)
                   End If
               End Function
    End Function

    Public Shared Function [Or](ParamArray parsers As Func(Of String, Integer, ParseResult)()) As Func(Of String, Integer, ParseResult)
        Return Function(text As String, position As Integer) As ParseResult
                   For Each it In parsers
                       Dim r = it(text, position)
                       If r.Success Then
                           Return r
                       End If
                   Next

                   Return New ParseResult(False, Nothing, Nothing, position)
               End Function
    End Function

    Public Shared Function Seq(ParamArray parsers As Func(Of String, Integer, ParseResult)()) As Func(Of String, Integer, ParseResult)
        Return Function(text As String, position As Integer) As ParseResult
                   Dim result = New List(Of ParseResult)()
                   Dim p = position

                   For Each it In parsers
                       Dim r = it(text, p)

                       If r.Success Then
                           result.Add(r)
                           p = r.NextPosition
                       Else
                           Return New ParseResult(False, Nothing, Nothing, position)
                       End If
                   Next

                   Return New ParseResult(True, Nothing, result, p)
               End Function
    End Function

    Public Shared Function Many(parser As Func(Of String, Integer, ParseResult)) As Func(Of String, Integer, ParseResult)
        Return Function(text As String, position As Integer) As ParseResult
                   Dim result = New List(Of ParseResult)()
                   Dim p = position

                   While True
                       Dim r = parser(text, p)

                       If r.Success Then
                           result.Add(r)
                           p = r.NextPosition
                       Else
                           Exit While
                       End If
                   End While

                   Return New ParseResult(True, Nothing, result, p)
               End Function
    End Function

    Public Shared Function [Option](parser As Func(Of String, Integer, ParseResult)) As Func(Of String, Integer, ParseResult)
        Return Function(text As String, position As Integer) As ParseResult
                   Dim r = parser(text, position)

                   If r.Success Then
                       Return r
                   Else
                       Return New ParseResult(True, Nothing, Nothing, position)
                   End If
               End Function
    End Function

    Public Shared Function Lazy(f As Func(Of Func(Of String, Integer, ParseResult))) As Func(Of String, Integer, ParseResult)
        Return Function(text As String, position As Integer) As ParseResult
                   Return f()(text, position)
               End Function
    End Function

    Public Shared Function Accumlate(parser As Func(Of String, Integer, ParseResult)) As Func(Of String, Integer, ParseResult)
        Return Function(text As String, position As Integer) As ParseResult
                   Dim r = parser(text, position)

                   If r.Success Then
                       Return Accumlate(r)
                   Else
                       Return New ParseResult(False, Nothing, Nothing, position)
                   End If
               End Function
    End Function

    Private Shared Function Accumlate(result As ParseResult) As ParseResult
        If Not ReferenceEquals(result.Result, Nothing) Then
            Return result
        Else
            Dim sb = New StringBuilder()
            For Each it In result.InnerResult
                sb.Append(Accumlate(it).Result)
            Next
            Return New ParseResult(True, sb.ToString(), Nothing, result.NextPosition)
        End If
    End Function

    Private Shared Function Substring(text As String, position As Integer, length As Integer) As String
        If text.Length > position + length Then
            Return text.Substring(position, length)
        ElseIf text.Length > position Then
            Return text.Substring(position)
        Else
            Return ""
        End If
    End Function

    Private Sub New()
        ' I want a static class instead of a module in VB.
    End Sub

End Class
