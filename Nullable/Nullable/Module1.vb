Imports System.Runtime.CompilerServices

Module Module1

    Sub Main()
        Dim a = New Hoge() With {.Id = 1, .Name = "Hoge", .ParentId = 0}
        Dim b = New Hoge() With {.Id = 1, .Name = "Hoge", .ParentId = Nothing}
        Dim c As Hoge

        Dim d = b.Ns(Function(it) it.Id)

        Console.WriteLine(a.Ns(Function(it) it.Id))
        Console.WriteLine(a.N(Function(it) it.Name))
        Console.WriteLine(a.Ns(Function(it) it.ParentId))
        
        Console.WriteLine(b.Ns(Function(it) it.Id))
        Console.WriteLine(b.N(Function(it) it.Name))
        Console.WriteLine(b.Ns(Function(it) it.ParentId))

        Console.WriteLine(c.Ns(Function(it) it.Id))
        Console.WriteLine(c.N(Function(it) it.Name))
        Console.WriteLine(c.Ns(Function(it) it.ParentId))
    End Sub

End Module

Module NullableExtension

    <Extension>
    Public Function N(Of TModel, TResult As Class)(value As TModel, expr As Func(Of TModel, TResult)) As TResult
        If value Is Nothing Then
            Return Nothing
        Else
            Return expr(value)
        End If
    End Function

    <Extension>
    Public Function Ns(Of TModel, TResult As Structure)(value As TModel, expr As Func(Of TModel, TResult)) As Nullable(Of TResult)
        If value Is Nothing Then
            Return Nothing
        Else
            Return expr(value)
        End If
    End Function

    <Extension>
    Public Function Ns(Of TModel, TResult As Structure)(value As TModel, expr As Func(Of TModel, Nullable(Of TResult))) As Nullable(Of TResult)
        If value Is Nothing Then
            Return Nothing
        Else
            Return expr(value)
        End If
    End Function

End Module

Class Hoge
    Public Property Id As Integer
    Public Property Name As String
    Public Property ParentId As Integer?
End Class