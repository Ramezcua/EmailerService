Imports Quartz
Imports NLog

Namespace QuartzJobs
    Public Class HelloJob
        Implements IJob

        Private Shared Logger As Logger = LogManager.GetCurrentClassLogger()

        Public Sub Execute(context As IJobExecutionContext) Implements IJob.Execute
            Logger.Debug("Greetings from HelloJob!")
        End Sub

    End Class
End Namespace
