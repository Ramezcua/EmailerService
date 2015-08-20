Imports System.Collections.Generic
Imports Emailer.Helpers

Namespace EmailTask
    Public Class VolunterHoursReminderTask
        Implements IEmailTask
        Public Property Emails As IEnumerable(Of EmailJob) Implements IEmailTask.Emails
        Private Property _DAO As IDAOHelper
        Private Property _Emailer As IMailerHelper

        Function GenerateEmails() As Boolean Implements IEmailTask.GenerateEmails
            ' Go through the database and find events where the end date is after today
            ' but less than a week from today.  Generate emails for them
            Emails = _DAO.GetVolunteerHoursReminderEmails()
            Return False
        End Function

        Function SendEmails() As Boolean Implements IEmailTask.SendEmails
            For Each Email In Me.Emails
                Email.SendEmail()
            Next
            Return False
        End Function

        Function PostSendUpdate() As Boolean Implements IEmailTask.PostSendUpdate
            Return False
        End Function

        Sub New()
            Me._Emailer = New MailHelper
            Me._DAO = New DAOHelper(Me._Emailer)
        End Sub
    End Class
End Namespace
