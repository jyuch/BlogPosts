Imports Akka.Actor
Imports Akka.Event
Imports Serilog
Imports Akka.Logger.Serilog

Module Program

    Dim conf As String = "
akka {
    loggers=[""Akka.Logger.Serilog.SerilogLogger, Akka.Logger.Serilog""]

    stdout-loglevel = off
    loglevel = DEBUG
    log-config-on-start = on
    actor {
        debug {
              receive = on 
              autoreceive = on
              lifecycle = on
              event-stream = on
              unhandled = on
        }
    }
}
"

    Sub Main()
        Dim logger = New LoggerConfiguration().
            WriteTo.Console().
            MinimumLevel.Debug().
            CreateLogger()
        Log.Logger = logger

        Dim system = ActorSystem.Create("vb-actor", conf)
        Dim echo = system.ActorOf(Of EchoActor)("echo")
        Dim hello = system.ActorOf(Props.Create(Function() New HelloActor(echo)))

        hello.Tell("hello")
        hello.Tell("hoge")

        Console.ReadLine()
        system.Terminate().Wait()
    End Sub

End Module

Public Class HelloActor
    Inherits ReceiveActor

    Private ReadOnly _logger As ILoggingAdapter = Context.GetLogger(New SerilogLogMessageFormatter())
    Private ReadOnly _dest As IActorRef

    Public Sub New(dest As IActorRef)
        _dest = dest
        Receive(Of String)(AddressOf ReceiveString)
        Receive(Of Greet)(AddressOf ReceiveGreet)
    End Sub

    Public Sub ReceiveString(msg As String)
        _dest.Tell(New Greet(msg))
    End Sub

    Public Sub ReceiveGreet(msg As Greet)
        _logger.Info("Returned {Message}", msg.Message)
    End Sub

End Class

Public Class EchoActor
    Inherits ReceiveActor

    Private ReadOnly _logger As ILoggingAdapter = Context.GetLogger(New SerilogLogMessageFormatter())

    Public Sub New()
        Receive(Of Greet)(AddressOf ReceiveGreet)
    End Sub

    Public Sub ReceiveGreet(msg As Greet)
        _logger.Info("Receive {Message}", msg.Message)
        Sender.Tell(New Greet($"You said {msg.Message}"))
    End Sub

End Class

Public Class Greet
    Public ReadOnly Property Message As String

    Public Sub New(msg As String)
        Message = msg
    End Sub

End Class