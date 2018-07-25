Imports System.Reflection

' アセンブリバージョン
<Assembly: AssemblyVersion("1.2.0.0")>

Namespace MyUtil
    Public Class Util
        Public ReadOnly Property Version As String
            Get
                Return "1.2"
            End Get
        End Property
    End Class
End Namespace
