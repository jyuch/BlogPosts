Imports PluginMarker
Imports System.Reflection

<Plugin>
Public Class Plugin1
    Implements IExecutablePlugin

    Public Function Execute(arg As String) As String Implements IExecutablePlugin.Execute
        Console.WriteLine($"PluginClass={NameOf(Plugin1)}")
        Console.WriteLine($"arg={arg}")
        Console.WriteLine($"Domain={AppDomain.CurrentDomain.FriendlyName}")
        Console.WriteLine($"Assembly={Assembly.GetCallingAssembly.FullName}")
        Console.WriteLine()
        Return New String(arg.Reverse.ToArray)
    End Function
End Class

<Plugin>
Public Class Plugin2
    Implements IExecutablePlugin

    Public Function Execute(arg As String) As String Implements IExecutablePlugin.Execute
        Console.WriteLine($"PluginClass={NameOf(Plugin2)}")
        Console.WriteLine($"arg={arg}")
        Console.WriteLine($"Domain={AppDomain.CurrentDomain.FriendlyName}")
        Console.WriteLine($"Assembly={Assembly.GetCallingAssembly.FullName}")
        Console.WriteLine()
        Return arg + arg
    End Function
End Class

Public Class Plugin3
    Implements IExecutablePlugin

    Public Function Execute(arg As String) As String Implements IExecutablePlugin.Execute
        Console.WriteLine($"PluginClass={NameOf(Plugin1)}")
        Console.WriteLine($"arg={arg}")
        Console.WriteLine($"Domain={AppDomain.CurrentDomain.FriendlyName}")
        Console.WriteLine($"Assembly={Assembly.GetCallingAssembly.FullName}")
        Return New String(arg.Reverse.ToArray) + New String(arg.Reverse.ToArray)
    End Function
End Class