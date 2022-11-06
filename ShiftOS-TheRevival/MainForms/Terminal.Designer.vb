<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Terminal
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.StoryOnlyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.InfoBar = New System.Windows.Forms.TextBox()
        Me.InfoBarTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(800, 432)
        Me.TextBox1.TabIndex = 0
        '
        'StoryOnlyTimer
        '
        '
        'InfoBar
        '
        Me.InfoBar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InfoBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.InfoBar.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.InfoBar.ForeColor = System.Drawing.Color.Black
        Me.InfoBar.Location = New System.Drawing.Point(0, 432)
        Me.InfoBar.Name = "InfoBar"
        Me.InfoBar.ReadOnly = True
        Me.InfoBar.Size = New System.Drawing.Size(800, 18)
        Me.InfoBar.TabIndex = 0
        Me.InfoBar.Text = "Infobar"
        Me.InfoBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.InfoBar.Visible = False
        '
        'InfoBarTimer
        '
        '
        'Terminal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.InfoBar)
        Me.Name = "Terminal"
        Me.Text = "Terminal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents StoryOnlyTimer As Timer
    Friend WithEvents InfoBar As TextBox
    Friend WithEvents InfoBarTimer As Timer
End Class
