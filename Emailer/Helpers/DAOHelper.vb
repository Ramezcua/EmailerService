Imports Emailer.EmailJob
Imports System.Collections.Generic
Imports System.Configuration

Namespace Helpers
    Public Class DAOHelper
        Implements IDAOHelper

        Private _Emailer As IMailerHelper

        Function GetVolunteerHoursReminderEmails() As List(Of EmailJob) Implements IDAOHelper.GetVolunteerHoursReminderEmails
            Dim Emails As New List(Of EmailJob)

            Dim newEmail As New EmailJob(_Emailer)
            newEmail.Subject = EmailTextGenerator.VolunteerHoursEmailSubject("MyEvent")
            newEmail.ToAddresses = New List(Of String) From {ConfigurationManager.AppSettings("TestEmail")}
            newEmail.Body = EmailTextGenerator.VolunteerHoursEmailBody()
            Emails.Add(newEmail)
            Return Emails
        End Function

        Sub New(Emailer As Helpers.IMailerHelper)
            _Emailer = Emailer
        End Sub
    End Class

    Public Interface IDAOHelper
        Function GetVolunteerHoursReminderEmails() As List(Of EmailJob)
    End Interface
End Namespace
