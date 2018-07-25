Imports CommandLine.Parser

Module Program

    Sub Main()
        Dim param1 = ParamModule.Parse({"--level", "2", "--dry-run", "c.txt"})
        ParamModule.Show(param1)

        Console.WriteLine()

        Dim param2 = ParamModule.Parse({"--level", "2", "--output-name", "hoge.exe", "a.txt", "b.txt"})
        ParamModule.Show(param2)
    End Sub

End Module
