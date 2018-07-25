Imports System.Reflection
Imports WrapperA = MyUtilWrapperA.UtilWrapper
Imports WrapperB = MyUtilWrapperB.UtilWrapper

' アセンブリカルチャ
<Assembly: AssemblyCulture("")>
' アセンブリバージョン
<Assembly: AssemblyVersion("1.0.0.0")>

Namespace MyApp
    Public Class Program
        Public Shared Sub Main(args As String())
            Dim a = New WrapperA()
            Dim b = New WrapperB()

            Console.WriteLine($"WrapperA: {a.GetInternalUtilVersion}")
            Console.WriteLine($"WrapperB: {b.GetInternalUtilVersion}")
        End Sub
    End Class
End Namespace
