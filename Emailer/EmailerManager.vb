Imports Emailer.EmailTask
Imports Emailer.Helpers
Imports NLog
Imports Quartz
Imports Quartz.Impl
Imports System
Imports System.Collections.Generic
Imports System.Threading
Imports Emailer.QuartzJobs

Public Class EmailerManager
    Private Shared Logger As Logger = LogManager.GetCurrentClassLogger()
    Private Scheduler As IScheduler

    Public Sub RunManager()

        Try
            Me.Scheduler = StdSchedulerFactory.GetDefaultScheduler()
            Me.Scheduler.Start()

            Dim job As IJobDetail = JobBuilder.Create(Of VolunteerHoursReminderJob)().WithIdentity("VolunteerHours", "Group1").Build()
            Dim trigger As ITrigger = TriggerBuilder.Create().WithIdentity("2MinuteTrigger", "Group1") _
                                      .StartNow() _
                                      .WithSimpleSchedule(Function(x) x.WithIntervalInMinutes(2).RepeatForever()).Build()
            Me.Scheduler.ScheduleJob(job, trigger)

        Catch ex As Exception
            Logger.Fatal(ex)
        End Try
    End Sub

    Public Sub StopManager()
        If Not IsNothing(Me.Scheduler) Then
            Me.Scheduler.Shutdown()
        End If
    End Sub

End Class