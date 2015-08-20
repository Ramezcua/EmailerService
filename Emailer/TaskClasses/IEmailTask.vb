Imports System.Collections.Generic

Namespace EmailTask
    Public Interface IEmailTask
        Property Emails As IEnumerable(Of EmailJob)
        Function GenerateEmails() As Boolean
        Function SendEmails() As Boolean
        Function PostSendUpdate() As Boolean
    End Interface
End Namespace
