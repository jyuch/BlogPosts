Imports System.IO
Imports System.Text
Imports TestDriver

Module Module1

    Sub Main()
        dim d = ReadDataFromCsv()

        Runner.Run(Sub() UseList(d), NameOf(UseList), 10,20)
        Runner.Run(Sub() UseSet(d), NameOf(UseSet), 10, 20)
        Console.WriteLine()
        Runner.Run(Sub() UseLinq(d), NameOf(UseLinq), 10, 20)
    End Sub

    Sub UseList(data As IEnumerable(Of Name))
        Dim cache = new List(Of Name)

        for each it in data
            If Not cache.Contains(it)
                cache.Add(it)
            End If
        Next

        'Console.WriteLine(cache.Count)
    End Sub

    Sub UseSet(data As IEnumerable(Of Name))
        Dim cache = new HashSet(Of Name)

        For Each it In data
            cache.Add(it)
        Next

        'Console.WriteLine(cache.Count)
    End Sub

    sub UseLinq(data As IEnumerable(of Name))
        Dim c = data.Distinct().Count()

        'Console.WriteLine(c)
    End sub

    Function ReadDataFromCsv() As IEnumerable(Of Name)
        Return File.ReadAllLines("./dummy.csv", Encoding.GetEncoding(932)).
            Select(Function(it) it.Split(","c)).
            Select(Function(it) New Name(it(1), it(0))).
            ToList()
    End Function

End Module
