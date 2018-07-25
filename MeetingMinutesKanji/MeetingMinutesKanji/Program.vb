Module Program

    Sub Main(args As String())
        If args.Length <> 1 Then
            Console.WriteLine("AppName <path of directory that contains the Excel file>")
            Environment.Exit(0)
        End If

        Dim contents = ExcelContentExtractor.ExtractContent(args(0))
        Dim words = SentenceSplitter.Split(contents)

        Dim result = words.
            Where(AddressOf HanFilter.HasHan).
            GroupBy(Function(it) it, Function(it) 1).
            Select(Function(it) New With {.Count = it.Sum(), .Word = it.Key}).
            OrderByDescending(Function(it) it.Count)

        For Each it In result
            Console.WriteLine("「{0}」: {1}", it.Word, it.Count)
        Next
    End Sub

End Module
