Imports log4net
Imports log4net.Config
Imports log4net.Core

Public Class Logger

    Dim Logger As ILog

    Public Sub New(Optional Thread As String = "Application")
        Logger = LogManager.GetLogger(Thread)
        XmlConfigurator.Configure()
        Logger.DebugFormat("Logger initialized")
    End Sub

    Public Sub Debug(message As String)
        Logger.Debug(message)
    End Sub

    Public Sub Info(message As String)
        Logger.Info(message)
    End Sub

    Public Sub Warn(message As String)
        Logger.Warn(message)
    End Sub

    Public Sub Warn(message As String, ex As Exception)
        Logger.Warn(message, ex)
    End Sub

    Public Sub [Error](message As String)
        Logger.Error(message)
    End Sub

    Public Sub [Error](message As String, ex As Exception)
        Logger.Error(message, ex)
    End Sub

    Public Sub Fatal(message As String)
        Logger.Fatal(message)
    End Sub

    Public Sub Fatal(message As String, ex As Exception)
        Logger.Fatal(message, ex)
    End Sub

End Class
