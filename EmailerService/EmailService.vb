Imports NLog
Imports Emailer.EmailerManager

Public Class EmailService

    Private Shared Logger As Logger = LogManager.GetCurrentClassLogger()
    Private Emailer As Emailer.EmailerManager

    Protected Overrides Sub OnStart(ByVal args() As String)
        Me.Emailer = New Emailer.EmailerManager()
        Emailer.RunManager()
    End Sub

    Protected Overrides Sub OnStop()
        Emailer.StopManager()
    End Sub


End Class
