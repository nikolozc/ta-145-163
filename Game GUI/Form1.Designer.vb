<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.picturePopEye = New System.Windows.Forms.PictureBox()
        Me.pictureEnemy = New System.Windows.Forms.PictureBox()
        Me.btnAttack = New System.Windows.Forms.Button()
        Me.progressBarPopEye = New System.Windows.Forms.ProgressBar()
        Me.progressBarEnemy = New System.Windows.Forms.ProgressBar()
        Me.btnSpawn = New System.Windows.Forms.Button()
        Me.radioSpinach = New System.Windows.Forms.RadioButton()
        Me.lblSpinach = New System.Windows.Forms.Label()
        Me.timerDelay = New System.Windows.Forms.Timer(Me.components)
        Me.lblPopeyeHealth = New System.Windows.Forms.Label()
        Me.lblEnemyHealth = New System.Windows.Forms.Label()
        CType(Me.picturePopEye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureEnemy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picturePopEye
        '
        Me.picturePopEye.Image = Global.Game_GUI.My.Resources.Resources.PopEye
        Me.picturePopEye.Location = New System.Drawing.Point(37, 52)
        Me.picturePopEye.Name = "picturePopEye"
        Me.picturePopEye.Size = New System.Drawing.Size(177, 276)
        Me.picturePopEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picturePopEye.TabIndex = 0
        Me.picturePopEye.TabStop = False
        '
        'pictureEnemy
        '
        Me.pictureEnemy.Location = New System.Drawing.Point(582, 52)
        Me.pictureEnemy.Name = "pictureEnemy"
        Me.pictureEnemy.Size = New System.Drawing.Size(177, 276)
        Me.pictureEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureEnemy.TabIndex = 1
        Me.pictureEnemy.TabStop = False
        '
        'btnAttack
        '
        Me.btnAttack.Location = New System.Drawing.Point(37, 12)
        Me.btnAttack.Name = "btnAttack"
        Me.btnAttack.Size = New System.Drawing.Size(82, 23)
        Me.btnAttack.TabIndex = 2
        Me.btnAttack.Text = "Attack"
        Me.btnAttack.UseVisualStyleBackColor = True
        '
        'progressBarPopEye
        '
        Me.progressBarPopEye.Location = New System.Drawing.Point(37, 334)
        Me.progressBarPopEye.Name = "progressBarPopEye"
        Me.progressBarPopEye.Size = New System.Drawing.Size(177, 30)
        Me.progressBarPopEye.TabIndex = 3
        '
        'progressBarEnemy
        '
        Me.progressBarEnemy.Location = New System.Drawing.Point(582, 334)
        Me.progressBarEnemy.Name = "progressBarEnemy"
        Me.progressBarEnemy.Size = New System.Drawing.Size(177, 30)
        Me.progressBarEnemy.TabIndex = 4
        '
        'btnSpawn
        '
        Me.btnSpawn.Location = New System.Drawing.Point(582, 12)
        Me.btnSpawn.Name = "btnSpawn"
        Me.btnSpawn.Size = New System.Drawing.Size(177, 23)
        Me.btnSpawn.TabIndex = 5
        Me.btnSpawn.Text = "Spawn Enemy"
        Me.btnSpawn.UseVisualStyleBackColor = True
        '
        'radioSpinach
        '
        Me.radioSpinach.AutoSize = True
        Me.radioSpinach.Location = New System.Drawing.Point(125, 12)
        Me.radioSpinach.Name = "radioSpinach"
        Me.radioSpinach.Size = New System.Drawing.Size(89, 19)
        Me.radioSpinach.TabIndex = 6
        Me.radioSpinach.TabStop = True
        Me.radioSpinach.Text = "Use Spinach"
        Me.radioSpinach.UseVisualStyleBackColor = True
        '
        'lblSpinach
        '
        Me.lblSpinach.AutoSize = True
        Me.lblSpinach.Location = New System.Drawing.Point(125, 34)
        Me.lblSpinach.Name = "lblSpinach"
        Me.lblSpinach.Size = New System.Drawing.Size(84, 15)
        Me.lblSpinach.TabIndex = 7
        Me.lblSpinach.Text = "Spinach Left: 3"
        '
        'timerDelay
        '
        Me.timerDelay.Interval = 1000
        '
        'lblPopeyeHealth
        '
        Me.lblPopeyeHealth.AutoSize = True
        Me.lblPopeyeHealth.Location = New System.Drawing.Point(37, 373)
        Me.lblPopeyeHealth.Name = "lblPopeyeHealth"
        Me.lblPopeyeHealth.Size = New System.Drawing.Size(45, 15)
        Me.lblPopeyeHealth.TabIndex = 8
        Me.lblPopeyeHealth.Text = "Health:"
        '
        'lblEnemyHealth
        '
        Me.lblEnemyHealth.AutoSize = True
        Me.lblEnemyHealth.Location = New System.Drawing.Point(582, 373)
        Me.lblEnemyHealth.Name = "lblEnemyHealth"
        Me.lblEnemyHealth.Size = New System.Drawing.Size(45, 15)
        Me.lblEnemyHealth.TabIndex = 9
        Me.lblEnemyHealth.Text = "Health:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 397)
        Me.Controls.Add(Me.lblEnemyHealth)
        Me.Controls.Add(Me.lblPopeyeHealth)
        Me.Controls.Add(Me.lblSpinach)
        Me.Controls.Add(Me.radioSpinach)
        Me.Controls.Add(Me.btnSpawn)
        Me.Controls.Add(Me.progressBarEnemy)
        Me.Controls.Add(Me.progressBarPopEye)
        Me.Controls.Add(Me.btnAttack)
        Me.Controls.Add(Me.pictureEnemy)
        Me.Controls.Add(Me.picturePopEye)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picturePopEye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureEnemy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picturePopEye As PictureBox
    Friend WithEvents pictureEnemy As PictureBox
    Friend WithEvents btnAttack As Button
    Friend WithEvents progressBarPopEye As ProgressBar
    Friend WithEvents progressBarEnemy As ProgressBar
    Friend WithEvents btnSpawn As Button
    Friend WithEvents radioSpinach As RadioButton
    Friend WithEvents lblSpinach As Label
    Friend WithEvents timerDelay As Timer
    Friend WithEvents lblPopeyeHealth As Label
    Friend WithEvents lblEnemyHealth As Label
End Class
