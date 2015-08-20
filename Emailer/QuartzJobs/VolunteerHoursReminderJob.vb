Imports Quartz
Imports NLog
Imports Emailer.EmailTask

Namespace QuartzJobs
    Public Class VolunteerHoursReminderJob
        Implements IJob
        Private Shared Logger As Logger = LogManager.GetCurrentClassLogger()

        Public Sub Execute(context As IJobExecutionContext) Implements IJob.Execute
            Logger.Info("Starting Volunteer Hours Reminder Job")
            Dim VRTask As IEmailTask
            Try
                VRTask = New VolunterHoursReminderTask()
                Logger.Info("Generating Emails")
                VRTask.GenerateEmails()
                Logger.Info("Sending Emails")
                VRTask.SendEmails()
                Logger.Info("Updating statuses")
                VRTask.PostSendUpdate()
                Logger.Info("Ending Volunteer Hours Reminder Job")
            Catch ex As Exception
                Logger.Warn(ex)
            End Try
        End Sub
    End Class
End Namespace
