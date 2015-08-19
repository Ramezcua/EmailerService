Imports NLog
Imports Emailer.Helpers

Public Class EmailerManager
    Private Shared Logger As Logger = LogManager.GetCurrentClassLogger()

    Public Shared Sub Run()
        Dim mailer As New MailHelper()
        mailer.SendEmail("x@xxx.com", "Test", "Hello World!")
    End Sub

End Class