Public Class Form1

    Private currentEnemy As Video_145.Enemy
    Private Hero As New PopEye
    Private intSpinach As Integer = 3

    Private Sub btnSpawn_Click(sender As Object, e As EventArgs) Handles btnSpawn.Click
        generateEnemy()

    End Sub

    Private Sub generateEnemy()
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
        UpdateEnemeyHealth()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generateEnemy()
        UpdatePopeyeHealth()
    End Sub

    Private Sub btnAttack_Click(sender As Object, e As EventArgs) Handles btnAttack.Click
        If radioSpinach.Checked And intSpinach > 0 Then
            Hero.hasSpinach = True
            intSpinach -= 1
            lblSpinach.Text = "Spinach Left: " & intSpinach.ToString()
            If intSpinach = 0 Then
                radioSpinach.Checked = False
                radioSpinach.Enabled = False
            End If
        End If
        Hero.Attack(currentEnemy.Health)
        Hero.hasSpinach = False
        Try
            UpdateEnemeyHealth()
            timerDelay.Start()
        Catch
            progressBarEnemy.Value = 0
            MessageBox.Show("Popeye has won!")
            generateEnemy()
        End Try
    End Sub

    Private Sub timerDelay_Tick(sender As Object, e As EventArgs) Handles timerDelay.Tick
        EnemyAttack()
    End Sub

    Private Sub EnemyAttack()
        currentEnemy.Attack(Hero.Health)
        timerDelay.Stop()
        Try
            UpdatePopeyeHealth()
        Catch ex As Exception
            progressBarPopEye.Value = 0
            MessageBox.Show("Popeye has lost!")
            Hero.Health = 100
            UpdatePopeyeHealth()
        End Try
    End Sub

    Private Sub UpdateEnemeyHealth()
        progressBarEnemy.Value = currentEnemy.Health
        lblEnemyHealth.Text = "Health: " & currentEnemy.Health
    End Sub

    Private Sub UpdatePopeyeHealth()
        progressBarPopEye.Value = Hero.Health
        lblPopeyeHealth.Text = "Health: " & Hero.Health
    End Sub
End Class
