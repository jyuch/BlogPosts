Imports System.Reflection
Imports System.Text
Imports PluginMarker

Public Class Proxy
    Inherits MarshalByRefObject

    Private targets As IEnumerable(Of Type)

    Public Sub LoadDLL(dllAbsolutePath As String)
        Dim asm As Assembly = Assembly.LoadFile(dllAbsolutePath)
        targets = asm.GetTypes().
            Where(Function(it) it.GetCustomAttribute(GetType(PluginAttribute)) IsNot Nothing)
    End Sub

    Public Function Execute(arg As String) As String
        Dim sb As StringBuilder = New StringBuilder()
        For Each it As Type In targets
            Dim i As IExecutablePlugin =
                CType(Activator.CreateInstance(it), IExecutablePlugin)
            sb.Append(i.Execute(arg)).AppendLine()
        Next
        Return sb.ToString()
    End Function

End Class
