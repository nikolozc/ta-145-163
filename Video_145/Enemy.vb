Public Class Enemy

    Private intHealth As Integer
    Public ReadOnly Attacks() As String = {"punch", "kick"}

    Sub New()
        intHealth = 100
    End Sub

    Public Sub defaultAttack(ByRef userHealth As Integer)
        Dim gen As New Random
        Dim attackNum As Integer = gen.Next(0, 1)
        Select Case attackNum
            Case 0
                userHealth -= 1
            Case 1
                userHealth -= 2
        End Select

    End Sub

    Public ReadOnly Property Health() As Integer
        Get
            Return intHealth
        End Get
    End Property
End Class
