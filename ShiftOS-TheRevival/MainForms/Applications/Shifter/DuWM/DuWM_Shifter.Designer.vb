<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DuWM_Shifter
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
        Me.pnl_LeftPane = New System.Windows.Forms.Panel()
        Me.lst_Features = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl_Options = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnl_Content = New System.Windows.Forms.Panel()
        Me.pnl_LeftPane.SuspendLayout()
        Me.pnl_Options.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_LeftPane
        '
        Me.pnl_LeftPane.Controls.Add(Me.lst_Features)
        Me.pnl_LeftPane.Controls.Add(Me.Label1)
        Me.pnl_LeftPane.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_LeftPane.Location = New System.Drawing.Point(0, 0)
        Me.pnl_LeftPane.Name = "pnl_LeftPane"
        Me.pnl_LeftPane.Size = New System.Drawing.Size(200, 450)
        Me.pnl_LeftPane.TabIndex = 0
        '
        'lst_Features
        '
        Me.lst_Features.BackColor = System.Drawing.Color.Silver
        Me.lst_Features.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lst_Features.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lst_Features.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lst_Features.FormattingEnabled = True
        Me.lst_Features.ItemHeight = 21
        Me.lst_Features.Items.AddRange(New Object() {"Desktop", "About"})
        Me.lst_Features.Location = New System.Drawing.Point(0, 51)
        Me.lst_Features.Name = "lst_Features"
        Me.lst_Features.Size = New System.Drawing.Size(200, 399)
        Me.lst_Features.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Shifter"
        '
        'pnl_Options
        '
        Me.pnl_Options.BackColor = System.Drawing.Color.Black
        Me.pnl_Options.Controls.Add(Me.Button3)
        Me.pnl_Options.Controls.Add(Me.btn_Close)
        Me.pnl_Options.Controls.Add(Me.Button1)
        Me.pnl_Options.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_Options.Location = New System.Drawing.Point(200, 405)
        Me.pnl_Options.Name = "pnl_Options"
        Me.pnl_Options.Size = New System.Drawing.Size(600, 45)
        Me.pnl_Options.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(351, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "OK"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btn_Close
        '
        Me.btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.ForeColor = System.Drawing.Color.White
        Me.btn_Close.Location = New System.Drawing.Point(432, 10)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 23)
        Me.btn_Close.TabIndex = 1
        Me.btn_Close.Text = "Cancel"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(513, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Apply"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pnl_Content
        '
        Me.pnl_Content.AllowDrop = True
        Me.pnl_Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_Content.Location = New System.Drawing.Point(200, 0)
        Me.pnl_Content.Name = "pnl_Content"
        Me.pnl_Content.Size = New System.Drawing.Size(600, 405)
        Me.pnl_Content.TabIndex = 2
        '
        'DuWM_Shifter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnl_Content)
        Me.Controls.Add(Me.pnl_Options)
        Me.Controls.Add(Me.pnl_LeftPane)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DuWM_Shifter"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shifter"
        Me.TopMost = True
        Me.pnl_LeftPane.ResumeLayout(False)
        Me.pnl_LeftPane.PerformLayout()
        Me.pnl_Options.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_LeftPane As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lst_Features As ListBox
    Friend WithEvents pnl_Options As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_Close As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pnl_Content As Panel
End Class
