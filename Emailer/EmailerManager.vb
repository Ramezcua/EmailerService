Imports NLog

Public Class EmailerManager
    Private Shared Logger As Logger = LogManager.GetCurrentClassLogger()

    Public Shared Sub Run()
        Logger.Debug("I'm doing work")
    End Sub

End Class