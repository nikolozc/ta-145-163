<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventLogForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.listEvents = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'listEvents
        '
        Me.listEvents.BackColor = System.Drawing.Color.Black
        Me.listEvents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listEvents.ForeColor = System.Drawing.Color.Lime
        Me.listEvents.FormattingEnabled = True
        Me.listEvents.ItemHeight = 15
        Me.listEvents.Location = New System.Drawing.Point(0, 0)
        Me.listEvents.Name = "listEvents"
        Me.listEvents.Size = New System.Drawing.Size(800, 397)
        Me.listEvents.TabIndex = 0
        '
        'EventLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 397)
        Me.Controls.Add(Me.listEvents)
        Me.Name = "EventLog"
        Me.Text = "EventLog"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listEvents As ListBox
End Class
