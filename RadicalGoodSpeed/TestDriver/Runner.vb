Public Class Runner

    Public Shared Sub Run(target As Action,
                          targetName As String,
                          Optional preLoopCount As Long = 100,
                          Optional measureLoopCount As Long = 1000)

        For i = 1 To preLoopCount
            target()
        Next

        Dim watch = New Stopwatch()
        watch.Start()
        For i = 1 To measureLoopCount
            target()
        Next
        watch.Stop()

        Console.WriteLine("{0,-20} Total:{1}ms Average:{2}ms",
                          targetName, watch.ElapsedMilliseconds, 
                          watch.ElapsedMilliseconds / measureLoopCount)
    End Sub

End Class