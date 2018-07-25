Imports System.Runtime.CompilerServices
Imports CSharpLibrary

Module Module1


    Sub Main()
        Dim c = New Class1()
        Console.WriteLine(c.add(1, 2))
        '                   ~~~
        ' class 'Class1' に同じ名前のメンバーが多種類存在するため、'add' があいまいです。
    End Sub

    <MethodImplAttribute(MethodImplOptions.ForwardRef)>
    Public Function Square(number As Integer) As Integer
        Return Nothing
    End Function

End Module
