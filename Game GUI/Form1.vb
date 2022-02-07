Imports Video_145

Public Class Form1

    Private currentEnemy As Enemy
    Private Hero As New PopEye
    Private intSpinach As Integer = 3
    Private newLog As New EventLogForm
    Private logShown As Boolean = True

    Private Sub btnSpawn_Click(sender As Object, e As EventArgs) Handles btnSpawn.Click
        generateEnemy()

    End Sub

    Private Sub generateEnemy()
        Dim generator As New Random
        Dim enemyType As Integer = generator.Next(1, 4)
        Select Case enemyType
            Case 1
                currentEnemy = New Zombie
                progressBarEnemy.Value = Enemy.StartHealth
                pictureEnemy.Image = My.Resources.cartoonZombie
            Case 2
                currentEnemy = New Villain
                progressBarEnemy.Value = Enemy.StartHealth
                pictureEnemy.Image = My.Resources.cartoonVillain
            Case 3
                currentEnemy = New Dragon
                progressBarEnemy.Value = Enemy.StartHealth
                pictureEnemy.Image = My.Resources.cartoonDragon
        End Select
        UpdateEnemeyHealth()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newLog.Show()
        newLog.Location = New Point(Me.Location.X, Me.Location.Y + 471)
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
        newLog.AddEvent(CreateEvent(PopEye.Name))
        Hero.hasSpinach = False
        Try
            UpdateEnemeyHealth()
            timerDelay.Start()
        Catch
            progressBarEnemy.Value = 0
            MessageBox.Show("Popeye has won!")
            newLog.AddEvent("~~~~~~~~~~~~~~~~")
            newLog.AddEvent("Popeye has won!")
            newLog.AddEvent("~~~~~~~~~~~~~~~~")
            generateEnemy()
        End Try
    End Sub

    Private Sub timerDelay_Tick(sender As Object, e As EventArgs) Handles timerDelay.Tick
        EnemyAttack()
    End Sub

    Private Sub EnemyAttack()
        currentEnemy.Attack(Hero.Health)
        newLog.AddEvent(CreateEvent(currentEnemy.strName))
        timerDelay.Stop()
        Try
            UpdatePopeyeHealth()
        Catch ex As Exception
            progressBarPopEye.Value = 0
            MessageBox.Show("Popeye has lost!")
            newLog.AddEvent("~~~~~~~~~~~~~~~~")
            newLog.AddEvent("Popeye has lost!")
            newLog.AddEvent("~~~~~~~~~~~~~~~~")
            Hero.Health = PopEye.StartHealth
            UpdatePopeyeHealth()
        End Try
    End Sub

    Private Sub UpdateEnemeyHealth()
        progressBarEnemy.Value = currentEnemy.Health
        lblEnemyHealth.Text = "Health: " & currentEnemy.Health
    End Sub

    Private Sub UpdatePopeyeHealth()
        If Hero.Health = 0 Then
            Throw New Exception
        End If
        progressBarPopEye.Value = Hero.Health
        lblPopeyeHealth.Text = "Health: " & Hero.Health
    End Sub

    Private Function CreateEvent(ByVal strName As String) As String
        If strName = PopEye.Name Then
            Dim damage As Integer = Hero.AttackDamage(Hero.attackNum)
            If Hero.hasSpinach Then
                damage *= 2
            End If
            Return strName + " Has used" + "[" + Hero.Attacks(Hero.attackNum) + "] For [" + damage.ToString + "] damage"
        Else
            Return strName + " Has used" + "[" + currentEnemy.Attacks(currentEnemy.attackNum) + "] For [" + currentEnemy.AttackDamage(currentEnemy.attackNum).ToString + "] damage"
        End If
    End Function

    Private Sub Form1_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        newLog.Location = New Point(Me.Location.X, Me.Location.Y + 471)
    End Sub

    Private Sub btnHideAndShow_Click(sender As Object, e As EventArgs) Handles btnHideAndShow.Click
        If logShown Then
            newLog.Hide()
            btnHideAndShow.Text = "Show Log"
            logShown = Not logShown
        Else
            newLog.Show()
            btnHideAndShow.Text = "Hide Log"
            logShown = Not logShown
        End If
    End Sub
End Class
