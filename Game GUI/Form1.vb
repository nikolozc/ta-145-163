Public Class Form1

    Private currentEnemy As Video_145.Enemy

    Private Sub btnSpawn_Click(sender As Object, e As EventArgs) Handles btnSpawn.Click
        Dim generator As New Random
        Dim enemyType As Integer = generator.Next(1, 4)
        Select Case enemyType
            Case 1
                currentEnemy = New Video_145.Zombie 'In video tutorial Video_145 = Enemies_Library
                progressBarEnemy.Value = currentEnemy.Health
                pictureEnemy.Image = My.Resources.cartoonZombie
            Case 2
                currentEnemy = New Video_145.Villain
                progressBarEnemy.Value = currentEnemy.Health
                pictureEnemy.Image = My.Resources.cartoonVillain
            Case 3
                currentEnemy = New Video_145.Dragon
                progressBarEnemy.Value = currentEnemy.Health
                pictureEnemy.Image = My.Resources.cartoonDragon
        End Select
    End Sub
End Class
