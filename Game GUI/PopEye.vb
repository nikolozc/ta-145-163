Public Class PopEye

    Public Const Name As String = "Popeye"
    Public ReadOnly Attacks() As String = {"Punch", "Kick", "Anchor Throw"}
    Public hasSpinach As Boolean = False
    Private intHealth As Integer = 100

    Public Sub Attack(ByRef enemyHealth As Integer)
        Dim gen As New Random
        Dim attackNum As Integer = gen.Next(3)
        Select Case attackNum
            Case 0
                If hasSpinach Then
                    enemyHealth -= (5 * 2)
                Else
                    enemyHealth -= 5
                End If
            Case 1
                If hasSpinach Then
                    enemyHealth -= (10 * 2)
                Else
                    enemyHealth -= 10
                End If
            Case 2
                If hasSpinach Then
                    enemyHealth -= (15 * 2)
                Else
                    enemyHealth -= 15
                End If
        End Select
    End Sub

    Public Property Health() As Integer
        Get
            Return intHealth
        End Get
        Set(value As Integer)
            intHealth = value
        End Set
    End Property
End Class
