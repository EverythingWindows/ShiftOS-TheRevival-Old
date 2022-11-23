<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DuWM_Shifter_About
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.lbl_ShiftOSVersion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Font = New System.Drawing.Font("Segoe UI", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_Title.Location = New System.Drawing.Point(11, 10)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(111, 45)
        Me.lbl_Title.TabIndex = 0
        Me.lbl_Title.Text = "About"
        '
        'lbl_ShiftOSVersion
        '
        Me.lbl_ShiftOSVersion.AutoSize = True
        Me.lbl_ShiftOSVersion.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_ShiftOSVersion.ForeColor = System.Drawing.Color.Black
        Me.lbl_ShiftOSVersion.Location = New System.Drawing.Point(15, 97)
        Me.lbl_ShiftOSVersion.Name = "lbl_ShiftOSVersion"
        Me.lbl_ShiftOSVersion.Size = New System.Drawing.Size(123, 21)
        Me.lbl_ShiftOSVersion.TabIndex = 2
        Me.lbl_ShiftOSVersion.Text = "ShiftOS Version "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Shifter for Dual Window Manager"
        '
        'DuWM_Shifter_About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_ShiftOSVersion)
        Me.Controls.Add(Me.lbl_Title)
        Me.Name = "DuWM_Shifter_About"
        Me.Size = New System.Drawing.Size(640, 480)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Title As Label
    Friend WithEvents lbl_ShiftOSVersion As Label
    Friend WithEvents Label1 As Label
End Class
