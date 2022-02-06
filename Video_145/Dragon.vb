Public Class Dragon
    Inherits Enemy

    Public ReadOnly dragonAttacks() As String = {"Blow Fire", "Claw", "Tail Smash"}

    Public Sub dragonAttack(ByRef userHealth As Integer)
        Dim gen As New Random
        Dim attackNum As Integer = gen.Next(0, 2)
        Select Case attackNum
            Case 0
                userHealth -= 15
            Case 1
                userHealth -= 8
            Case 2
                userHealth -= 10
        End Select
    End Sub
End Class
