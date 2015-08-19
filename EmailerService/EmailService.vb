Imports NLog
Imports Emailer.EmailerManager

Public Class EmailService

    Private WithEvents mTimer As System.Timers.Timer
    Private Const SleepTime = 100000  ' How long the service will sleep before activating
    Private Shared Logger As Logger = LogManager.GetCurrentClassLogger()

    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Setup and start timer
        mTimer = New System.Timers.Timer(SleepTime)
        mTimer.Enabled = True
    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.
        ' Stop the timer to free it
        mTimer.Enabled = False
    End Sub

    Private Sub MTimerElapsed(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs) Handles mTimer.Elapsed
        Emailer.EmailerManager.Run()
        'Do work
        'Logger.Debug("Hello world! The time is " & Date.Now.ToString("MM\/dd\/yyyy HH:mm"))
    End Sub
End Class
