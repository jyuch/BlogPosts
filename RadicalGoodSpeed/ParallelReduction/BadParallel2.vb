Public Class BadParallel2
    Private _sum As Long = 0
    Private _sync As Object = New Object

    Private Sub ParallelAdder(data As Long(), startIndex As Integer, endIndex As Integer)
        For i = startIndex To endIndex
            SyncLock _sync
                _sum += data(i)
            End SyncLock
        Next
    End Sub

    Public Shared Function AddParallel(data As Long()) As Long
        Dim b = New BadParallel2
        Dim s = data.Length \ 2

        Dim t1 = New Task(Sub() b.ParallelAdder(data, 0, s))
        Dim t2 = New Task(Sub() b.ParallelAdder(data, s + 1, data.Length - 1))

        t1.Start()
        t2.Start()

        Task.WaitAll(t1, t2)

        Return b._sum
    End Function
End Class