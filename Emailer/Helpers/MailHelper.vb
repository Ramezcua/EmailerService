Imports System.Net.Mail
Imports System.Configuration
Imports NLog

Namespace Helpers
    Public Class MailHelper
        Implements IMailerHelper
        Private FromEmailAddress As String = ConfigurationManager.AppSettings("SMTPEmailAddress")
        Private Shared Logger As Logger = LogManager.GetCurrentClassLogger()

        Public Function SendEmail(ToAddress As String, Subject As String, Body As String) As Boolean Implements IMailerHelper.SendEmail
            Dim MyTest As String = ConfigurationManager.AppSettings("myKey")

            Using EmailMessage As New MailMessage(Me.FromEmailAddress, ToAddress)
                EmailMessage.Subject = Subject
                EmailMessage.Body = Body
                EmailMessage.IsBodyHtml = True
                Using SMTP As New SmtpClient()
                    SMTP.ServicePoint.ConnectionLimit = 1
                    SMTP.Send(EmailMessage)
                End Using
            End Using

            Logger.Debug("Sent mail to " & ToAddress)
            Return True
        End Function
    End Class

    Public Interface IMailerHelper
        Function SendEmail(ToAddress As String, Subject As String, Body As String) As Boolean
    End Interface
End Namespace
