Public Class EventLogForm
    Private Sub EventLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listEvents.Items.Add("Event logger has successfully loaded")
        listEvents.Items.Add("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~")
    End Sub

    Public Sub AddEvent(ByVal strEvent As String)
        listEvents.Items.Add(strEvent)
    End Sub
End Class