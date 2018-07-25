Imports System.Reflection
Imports MyUtil

' アセンブリカルチャ
<Assembly: AssemblyCulture("")>
' アセンブリバージョン
<Assembly: AssemblyVersion("1.0.0.0")>

Namespace MyUtilWrapperB
    Public Class UtilWrapper
        Private _internalUtil As Util

        Public Sub New()
            _internalUtil = New Util()
        End Sub

        Public Function GetInternalUtilVersion As String
            Return _internalUtil.Version
        End Function
    End Class
End Namespace
