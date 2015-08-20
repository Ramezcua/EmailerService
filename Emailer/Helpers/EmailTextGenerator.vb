Namespace Helpers
    Public Class EmailTextGenerator
        Public Shared Function VolunteerHoursEmailSubject(EventTitle As String) As String
            Return String.Format("Volunteer hours need to be converted for {0}", EventTitle)
        End Function

        Public Shared Function VolunteerHoursEmailBody() As String
            Dim Body As String = "" &
                "Now that your event is over, you should process your volunteer's " &
                "hours so that your volunteers can be credited.  To do this:" &
                "<br />" &
                "<ol>" &
                "<li>Log into e-Portal and go to Manage events.</li>" &
                "<li>Click on your event and then click on manage registrants.</li>" &
                "<li>Click on Volunteer Hours.</li>" &
                "<li>Make sure each volunteer has the appropriate numbers.</li>" &
                "<li>Click on the Convert Hours button.</li>" &
                "<li>You're done!</li>" &
                "</ol>"
            Return String.Format(Body)
        End Function

    End Class
End Namespace
