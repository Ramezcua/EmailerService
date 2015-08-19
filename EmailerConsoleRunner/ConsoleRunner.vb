Imports NLog
Imports Emailer.EmailerManager

Module ConsoleRunner

    Sub Main()
        Console.WriteLine("Running Email Managing" & vbCrLf)
        Emailer.EmailerManager.Run()
        Console.WriteLine(vbCrLf & "Finished Running Email Mananaging")
        Console.ReadKey()
    End Sub

End Module
