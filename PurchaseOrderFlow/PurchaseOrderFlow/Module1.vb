Imports Stateless

Module Module1

    Sub Main()
        Dim 筆記用具購買申請 = New 購買申請("ボールペン", 100D)

        筆記用具購買申請.承認()
        ' 申請者に通知
        ' ボールペンの申請が承認されました

        筆記用具購買申請.発注()
        ' 業者にボールペンの注文をファックス

        筆記用具購買申請.検収()
        ' 買掛金元帳にボールペン（100円）を追加


        Dim コンピュータ購買申請 = New 購買申請("HPE Integrity Superdome X", 100000000D)

        コンピュータ購買申請.否認("エクセルを使うのにこのスペックは必要？")
        ' 申請者に通知
        ' HPE Integrity Superdome Xの申請が以下の理由により否認されました
        ' エクセルを使うのにこのスペックは必要？

        Try
            コンピュータ購買申請.発注()
        Catch ex As InvalidOperationException
            Console.WriteLine("否認された購買申請を発注することが何を意味するのか、貴様分かっているのだろうな？")
        End Try

    End Sub

End Module

Class 購買申請

    Enum 状態
        承認待ち
        承認済み
        否認
        発注済み
        検収済み
    End Enum

    Enum 条件
        承認
        否認
        発注
        検収
    End Enum

    Private _品目 As String
    Private _価格 As Decimal

    Private _状態 = 状態.承認待ち
    Private _状態機械 As StateMachine(Of 状態, 条件)
    Private _否認行為 As StateMachine(Of 状態, 条件).TriggerWithParameters(Of String)

    Public Sub New(品目 As String, 価格 As Decimal)
        _品目 = 品目
        _価格 = 価格

        _状態機械 = New StateMachine(Of 状態, 条件)(Function() _状態, Sub(状態) _状態 = 状態)
        _否認行為 = _状態機械.SetTriggerParameters(Of String)(条件.否認)

        _状態機械.Configure(状態.承認待ち).
            Permit(条件.承認, 状態.承認済み).
            Permit(条件.否認, 状態.否認)

        _状態機械.Configure(状態.承認済み).
            OnEntry(CType(Sub() 承認時(), Action)).
            Permit(条件.発注, 状態.発注済み)

        _状態機械.Configure(状態.否認).
            OnEntryFrom(_否認行為, Sub(理由) 否認時(理由))

        _状態機械.Configure(状態.発注済み).
            OnEntry(CType(Sub() 発注時(), Action)).
            Permit(条件.検収, 状態.検収済み)

        _状態機械.Configure(状態.検収済み).
            OnEntry(CType(Sub() 検収時(), Action))
    End Sub

    Public Sub 承認()
        _状態機械.Fire(条件.承認)
    End Sub

    Private Sub 承認時()
        Console.WriteLine("申請者に通知")
        Console.WriteLine($"{_品目}の申請が承認されました")
        Console.WriteLine()
    End Sub

    Public Sub 否認(理由 As String)
        _状態機械.Fire(_否認行為, 理由)
    End Sub

    Private Sub 否認時(理由 As String)
        Console.WriteLine("申請者に通知")
        Console.WriteLine($"{_品目}の申請が以下の理由により否認されました")
        Console.WriteLine(理由)
        Console.WriteLine()
    End Sub

    Public Sub 発注()
        _状態機械.Fire(条件.発注)
    End Sub

    Private Sub 発注時()
        Console.WriteLine($"業者に{_品目}の注文をファックス")
        Console.WriteLine()
    End Sub

    Public Sub 検収()
        _状態機械.Fire(条件.検収)
    End Sub

    Private Sub 検収時()
        Console.WriteLine($"買掛金元帳に{_品目}（{_価格}円）を追加")
        Console.WriteLine()
    End Sub

End Class
