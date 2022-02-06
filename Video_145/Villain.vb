Public Class Villain
    Inherits Enemy

    Public ReadOnly villainAttacks() As String = {"Shoot", "Stab", "Throw Granade"}

    Public Overrides Sub Attack(ByRef userHealth As Integer)
        Dim gen As New Random
        Dim attackNum As Integer = gen.Next(0, 2)
        Select Case attackNum
            Case 0
                userHealth -= 10
            Case 1
                userHealth -= 8
            Case 2
                userHealth -= 12
        End Select
    End Sub

End Class
