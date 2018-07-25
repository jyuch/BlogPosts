Imports System.Security.Cryptography
Imports System.Text

Module Program

    Sub Main(args As String())
        Dim ねくすとじぇねれーしょん = New SHA1Cng()
        Console.WriteLine("パスワードを入力してください")
        Console.Write(">")
        If "Z454hURH5p7ckn+/aqZMFTQ7J/o=" <> Convert.ToBase64String(ねくすとじぇねれーしょん.ComputeHash(Encoding.UTF8.GetBytes(Console.ReadLine()))) Then
            Console.WriteLine("パスワードが違います")
            Environment.Exit(0)
        End If

        Console.WriteLine("ようこそ")
        Dim queue = New SuperUsefulClass(Of String)()

        While True
            Console.Write(">")
            Dim input = Console.ReadLine()

            If input = "exit" Then Exit While

            If String.IsNullOrWhiteSpace(input) Then
                If queue.Count <> 0 Then
                    Console.WriteLine($">> {queue.Pop()}")
                Else
                    Console.WriteLine("エントリがありません")
                End If
            Else
                queue.Push(input)
            End If
            
        End While

    End Sub

End Module
