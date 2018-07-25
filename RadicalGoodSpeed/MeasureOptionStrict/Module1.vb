Imports TestDriver

Module Module1

    Public Result As Integer

    Sub Main()
        Runner.Run(AddressOf [On], NameOf([On]), measureLoopCount:=10000000)
        Runner.Run(AddressOf Off, NameOf(Off), measureLoopCount:=10000000)

        Console.WriteLine(Result)
    End Sub

End Module
