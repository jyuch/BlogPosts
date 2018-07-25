Public Class GoodParallel

    Private Shared Function ParallelAdder(data As Long(), startIndex As Integer, endIndex As Integer) As Long
        Dim sum = 0L
        For i = startIndex To endIndex
            sum += data(i)
        Next
        
        Return sum
    End Function

    Public Shared Function AddParallel(data As Long()) As Long
        Dim s = data.Length \ 2

        Dim t1 = New Task(Of Long)(Function() ParallelAdder(data, 0, s))
        Dim t2 = New Task(Of Long)(Function() ParallelAdder(data, s + 1, data.Length - 1))

        t1.Start()
        t2.Start()

        Return t1.Result + t2.Result
    End Function

End Class