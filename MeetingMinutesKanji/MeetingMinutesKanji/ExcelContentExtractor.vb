Imports OfficeOpenXml
Imports System.IO

Public Class ExcelContentExtractor

    Private Sub New()
        ' Nothing to do.
    End Sub

    Public Shared Function ExtractContent(targetDirectory As String) As IEnumerable(Of String)
        Dim contents = New List(Of String)

        For Each it In Directory.GetFiles(targetDirectory, "*.xlsx")
            Using exc = New ExcelPackage(New FileInfo(it))
                For Each sheet In exc.Workbook.Worksheets
                    For Each cell In sheet.Cells()
                        Dim text = TryCast(cell.Value, String)

                        If Not text Is Nothing Then
                            contents.Add(text)
                        End If
                    Next
                Next
            End Using
        Next

        Return contents
    End Function

End Class
