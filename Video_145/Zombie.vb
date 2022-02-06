﻿Public Class Zombie
    Inherits Enemy

    Public ReadOnly zombieAttacks() As String = {"Eat Brains", "Claw", "Throw Up"}

    Public Sub zombieAttack(ByRef userHealth As Integer)
        Dim gen As New Random
        Dim attackNum As Integer = gen.Next(0, 2)
        Select Case attackNum
            Case 0
                userHealth -= 15
            Case 1
                userHealth -= 5
            Case 2
                userHealth -= 2
        End Select
    End Sub
End Class
