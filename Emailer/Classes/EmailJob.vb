Imports System.Collections.Generic
Imports Emailer.Helpers

Public Class EmailJob
    Public Property ToAddresses As IEnumerable(Of String)
    Public Property Subject As String
    Public Property Body As String
    Public Property IsTriedSending As Boolean = False
    Public Property IsFailedToSend As Boolean = False
    Private Property _Mailer As MailHelper

    Sub New(Mailer As MailHelper)
        Me._Mailer = Mailer
    End Sub

    Sub New(ToAddresses As IEnumerable(Of String), Subject As String, Body As String, Mailer As IMailerHelper)
        MyClass.New(Mailer)
        Me.ToAddresses = ToAddresses
        Me.Subject = Subject
        Me.Body = Body
    End Sub

    Sub New(ToAddress As String, Subject As String, Body As String, Mailer As IMailerHelper)
        MyClass.New(Mailer)
        Me.ToAddresses = New List(Of String) From {ToAddress}
        Me.Subject = Subject
        Me.Body = Body
    End Sub

    Public Function SendEmail() As Boolean
        Dim SendAttempt As Boolean = False
        For Each ToAddress In Me.ToAddresses
            SendAttempt = Me._Mailer.SendEmail(ToAddress, Me.Subject, Me.Body)
            If SendAttempt = False Then
                Me.IsFailedToSend = True
                Exit For
            End If
            Me.IsTriedSending = True
        Next
        Return Me.IsFailedToSend
    End Function


End Class
