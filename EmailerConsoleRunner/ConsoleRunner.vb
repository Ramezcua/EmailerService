Imports NLog
Imports Emailer.EmailerManager

Module ConsoleRunner

    Sub Main()
        Dim Emailer As Emailer.EmailerManager = New Emailer.EmailerManager()
        Emailer.RunManager()

        Threading.Thread.Sleep(TimeSpan.FromMinutes(9))

        Emailer.StopManager()
        Console.ReadKey()
    End Sub

End Module
