Public Class PopEye

    Public Const Name As String = "Popeye"
    Public ReadOnly Attacks() As String = {"Punch", "Kick", "Anchor Throw"}
    Public hasSpinach As Boolean = False
    Public Shared StartHealth As Integer = 250
    Public attackNum As Integer
    Public ReadOnly AttackDamage() As Integer = {5, 10, 15}
    Private intHealth As Integer = StartHealth

    Public Sub Attack(ByRef enemyHealth As Integer)
        Dim gen As New Random
        attackNum = gen.Next(3)
        Select Case attackNum
            Case 0
                If hasSpinach Then
                    enemyHealth -= (AttackDamage(attackNum) * 2)
                Else
                    enemyHealth -= AttackDamage(attackNum)
                End If
            Case 1
                If hasSpinach Then
                    enemyHealth -= (AttackDamage(attackNum) * 2)
                Else
                    enemyHealth -= AttackDamage(attackNum)
                End If
            Case 2
                If hasSpinach Then
                    enemyHealth -= (AttackDamage(attackNum) * 2)
                Else
                    enemyHealth -= AttackDamage(attackNum)
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
