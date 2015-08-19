Imports NLog
Imports Emailer.EmailerManager

Module ConsoleRunner

    Sub Main()
        Console.WriteLine("Running Email Managing")
        Emailer.EmailerManager.Run()
        Console.WriteLine("Finished Running Email Mananaging")
        Console.ReadKey()
    End Sub

End Module
