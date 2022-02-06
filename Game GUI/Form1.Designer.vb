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
        Me.picturePopEye = New System.Windows.Forms.PictureBox()
        Me.pictureEnemy = New System.Windows.Forms.PictureBox()
        Me.btnAttack = New System.Windows.Forms.Button()
        Me.progressBarPopEye = New System.Windows.Forms.ProgressBar()
        Me.progressBarEnemy = New System.Windows.Forms.ProgressBar()
        Me.btnSpawn = New System.Windows.Forms.Button()
        CType(Me.picturePopEye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureEnemy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picturePopEye
        '
        Me.picturePopEye.Image = Global.Game_GUI.My.Resources.Resources.PopEye
        Me.picturePopEye.Location = New System.Drawing.Point(37, 41)
        Me.picturePopEye.Name = "picturePopEye"
        Me.picturePopEye.Size = New System.Drawing.Size(177, 276)
        Me.picturePopEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picturePopEye.TabIndex = 0
        Me.picturePopEye.TabStop = False
        '
        'pictureEnemy
        '
        Me.pictureEnemy.Location = New System.Drawing.Point(582, 41)
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
        Me.btnAttack.Size = New System.Drawing.Size(177, 23)
        Me.btnAttack.TabIndex = 2
        Me.btnAttack.Text = "Attack"
        Me.btnAttack.UseVisualStyleBackColor = True
        '
        'progressBarPopEye
        '
        Me.progressBarPopEye.Location = New System.Drawing.Point(37, 323)
        Me.progressBarPopEye.Name = "progressBarPopEye"
        Me.progressBarPopEye.Size = New System.Drawing.Size(177, 30)
        Me.progressBarPopEye.TabIndex = 3
        '
        'progressBarEnemy
        '
        Me.progressBarEnemy.Location = New System.Drawing.Point(582, 323)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 371)
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

    End Sub

    Friend WithEvents picturePopEye As PictureBox
    Friend WithEvents pictureEnemy As PictureBox
    Friend WithEvents btnAttack As Button
    Friend WithEvents progressBarPopEye As ProgressBar
    Friend WithEvents progressBarEnemy As ProgressBar
    Friend WithEvents btnSpawn As Button
End Class
