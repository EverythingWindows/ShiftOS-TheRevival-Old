<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShiftOSMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Aboot = New System.Windows.Forms.Button()
        Me.lbl_BuildString = New System.Windows.Forms.Label()
        Me.btn_StoryMode = New System.Windows.Forms.Button()
        Me.btn_FreeRoam = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Thumbnail = New System.Windows.Forms.PictureBox()
        Me.BannerChange = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Thumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ShiftOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Shift it your way"
        '
        'btn_Aboot
        '
        Me.btn_Aboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Aboot.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btn_Aboot.ForeColor = System.Drawing.Color.White
        Me.btn_Aboot.Location = New System.Drawing.Point(22, 166)
        Me.btn_Aboot.Name = "btn_Aboot"
        Me.btn_Aboot.Size = New System.Drawing.Size(224, 23)
        Me.btn_Aboot.TabIndex = 3
        Me.btn_Aboot.Text = "About"
        Me.btn_Aboot.UseVisualStyleBackColor = True
        '
        'lbl_BuildString
        '
        Me.lbl_BuildString.AutoSize = True
        Me.lbl_BuildString.ForeColor = System.Drawing.Color.White
        Me.lbl_BuildString.Location = New System.Drawing.Point(13, 416)
        Me.lbl_BuildString.Name = "lbl_BuildString"
        Me.lbl_BuildString.Size = New System.Drawing.Size(39, 13)
        Me.lbl_BuildString.TabIndex = 3
        Me.lbl_BuildString.Text = "Label3"
        '
        'btn_StoryMode
        '
        Me.btn_StoryMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_StoryMode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btn_StoryMode.ForeColor = System.Drawing.Color.White
        Me.btn_StoryMode.Location = New System.Drawing.Point(22, 108)
        Me.btn_StoryMode.Name = "btn_StoryMode"
        Me.btn_StoryMode.Size = New System.Drawing.Size(224, 23)
        Me.btn_StoryMode.TabIndex = 1
        Me.btn_StoryMode.Text = "Story Mode"
        Me.btn_StoryMode.UseVisualStyleBackColor = True
        '
        'btn_FreeRoam
        '
        Me.btn_FreeRoam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_FreeRoam.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btn_FreeRoam.ForeColor = System.Drawing.Color.White
        Me.btn_FreeRoam.Location = New System.Drawing.Point(22, 137)
        Me.btn_FreeRoam.Name = "btn_FreeRoam"
        Me.btn_FreeRoam.Size = New System.Drawing.Size(224, 23)
        Me.btn_FreeRoam.TabIndex = 2
        Me.btn_FreeRoam.Text = "Free Roam Mode"
        Me.btn_FreeRoam.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btn_Exit.ForeColor = System.Drawing.Color.White
        Me.btn_Exit.Location = New System.Drawing.Point(22, 195)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(224, 23)
        Me.btn_Exit.TabIndex = 4
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'Thumbnail
        '
        Me.Thumbnail.BackColor = System.Drawing.Color.Silver
        Me.Thumbnail.BackgroundImage = Global.ShiftOS_TheRevival.My.Resources.Resources.MenuBanner1
        Me.Thumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Thumbnail.Dock = System.Windows.Forms.DockStyle.Right
        Me.Thumbnail.Location = New System.Drawing.Point(264, 0)
        Me.Thumbnail.Name = "Thumbnail"
        Me.Thumbnail.Size = New System.Drawing.Size(360, 441)
        Me.Thumbnail.TabIndex = 5
        Me.Thumbnail.TabStop = False
        '
        'BannerChange
        '
        '
        'ShiftOSMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.Thumbnail)
        Me.Controls.Add(Me.lbl_BuildString)
        Me.Controls.Add(Me.btn_FreeRoam)
        Me.Controls.Add(Me.btn_StoryMode)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Aboot)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ShiftOSMenu"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        CType(Me.Thumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Aboot As Button
    Friend WithEvents lbl_BuildString As Label
    Friend WithEvents btn_StoryMode As Button
    Friend WithEvents btn_FreeRoam As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Thumbnail As PictureBox
    Friend WithEvents BannerChange As Timer
End Class
