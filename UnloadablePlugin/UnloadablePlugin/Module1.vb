Imports PluginProxy
Imports System.Reflection
Imports System.IO

Module Module1

    Sub Main()
        Dim pluginDLLPath As String = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly.Location), "Assembly", "Plugin.dll")

        While (File.Exists(pluginDLLPath))
            Dim pluginProxyPath As String = Path.Combine(
                        Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                        "PluginProxy.dll")
            Dim pluginProxyAssm As Assembly = Assembly.LoadFile(pluginProxyPath)
            Dim pluginDomain As AppDomain = AppDomain.CreateDomain("PluginDomain")
            Dim pluginProxy As Proxy = CType(pluginDomain.CreateInstanceAndUnwrap(
                pluginProxyAssm.FullName,
                GetType(Proxy).FullName), Proxy)

            pluginProxy.LoadDLL(pluginDLLPath)
            Dim returnMessage As String = pluginProxy.Execute("あなたはだあれ？")
            Console.WriteLine(">>>")
            Console.WriteLine(returnMessage.Trim)
            Console.WriteLine("<<<")
            Console.WriteLine()
            AppDomain.Unload(pluginDomain)
            Threading.Thread.Sleep(5000)
        End While

    End Sub

End Module
