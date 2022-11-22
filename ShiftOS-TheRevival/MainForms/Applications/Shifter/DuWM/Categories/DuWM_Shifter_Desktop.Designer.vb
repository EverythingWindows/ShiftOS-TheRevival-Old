<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DuWM_Shifter_Desktop
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.cmb_DesktopColor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Font = New System.Drawing.Font("Segoe UI", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_Title.Location = New System.Drawing.Point(11, 10)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(142, 45)
        Me.lbl_Title.TabIndex = 0
        Me.lbl_Title.Text = "Desktop"
        '
        'cmb_DesktopColor
        '
        Me.cmb_DesktopColor.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmb_DesktopColor.FormattingEnabled = True
        Me.cmb_DesktopColor.Items.AddRange(New Object() {"Black", "Dark Gray", "Light Gray", "Red", "Dark Red", "Green", "Light Green", "Blue", "Dark Blue", "Yellow", "Dark Yellow", "Purple", "Light Purple", "Aqua", "Light Aqua", "White"})
        Me.cmb_DesktopColor.Location = New System.Drawing.Point(156, 91)
        Me.cmb_DesktopColor.Name = "cmb_DesktopColor"
        Me.cmb_DesktopColor.Size = New System.Drawing.Size(121, 29)
        Me.cmb_DesktopColor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Background Color"
        '
        'DuWM_Shifter_Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_DesktopColor)
        Me.Controls.Add(Me.lbl_Title)
        Me.Name = "DuWM_Shifter_Desktop"
        Me.Size = New System.Drawing.Size(640, 480)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Title As Label
    Friend WithEvents cmb_DesktopColor As ComboBox
    Friend WithEvents Label1 As Label
End Class
