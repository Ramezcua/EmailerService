Imports NLog
Imports Emailer.Helpers
Imports System.Collections.Generic
Imports Emailer.EmailTask

Public Class EmailerManager
    Private Shared Logger As Logger = LogManager.GetCurrentClassLogger()

    Public Shared Sub Run()
        ' Get all email tasks
        Dim EmailTasks As New List(Of IEmailTask)
        EmailTasks.Add(New VolunterHoursReminderTask())

        ' Do work
        For Each Task In EmailTasks
            Task.GenerateEmails()
            Task.SendEmails()
            Task.PostSendUpdate()
        Next
    End Sub

End Class