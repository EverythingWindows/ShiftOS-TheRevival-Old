<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnusWM_Menu
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
        Me.mnu_Main = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShifterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopAnusWMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutdownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.mnu_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnu_Main
        '
        Me.mnu_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mnu_Main.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.mnu_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ApplicationsToolStripMenuItem, Me.ShifterToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.mnu_Main.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.mnu_Main.Location = New System.Drawing.Point(0, 25)
        Me.mnu_Main.Name = "mnu_Main"
        Me.mnu_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mnu_Main.Size = New System.Drawing.Size(139, 112)
        Me.mnu_Main.TabIndex = 0
        Me.mnu_Main.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(106, 4)
        '
        'ApplicationsToolStripMenuItem
        '
        Me.ApplicationsToolStripMenuItem.Name = "ApplicationsToolStripMenuItem"
        Me.ApplicationsToolStripMenuItem.Size = New System.Drawing.Size(106, 25)
        Me.ApplicationsToolStripMenuItem.Text = "Applications"
        '
        'ShifterToolStripMenuItem
        '
        Me.ShifterToolStripMenuItem.Name = "ShifterToolStripMenuItem"
        Me.ShifterToolStripMenuItem.Size = New System.Drawing.Size(106, 25)
        Me.ShifterToolStripMenuItem.Text = "Shifter"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(106, 25)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StopAnusWMToolStripMenuItem, Me.RestartToolStripMenuItem, Me.ShutdownToolStripMenuItem})
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(106, 25)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'StopAnusWMToolStripMenuItem
        '
        Me.StopAnusWMToolStripMenuItem.Name = "StopAnusWMToolStripMenuItem"
        Me.StopAnusWMToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.StopAnusWMToolStripMenuItem.Text = "Stop AnusWM"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'ShutdownToolStripMenuItem
        '
        Me.ShutdownToolStripMenuItem.Name = "ShutdownToolStripMenuItem"
        Me.ShutdownToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.ShutdownToolStripMenuItem.Text = "Shutdown"
        '
        'lbl_Title
        '
        Me.lbl_Title.BackColor = System.Drawing.Color.Black
        Me.lbl_Title.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_Title.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lbl_Title.ForeColor = System.Drawing.Color.White
        Me.lbl_Title.Location = New System.Drawing.Point(0, 0)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(139, 25)
        Me.lbl_Title.TabIndex = 1
        Me.lbl_Title.Text = "Toolchest"
        Me.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AnusWM_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(139, 137)
        Me.Controls.Add(Me.mnu_Main)
        Me.Controls.Add(Me.lbl_Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.mnu_Main
        Me.Name = "AnusWM_Menu"
        Me.Text = "AnusWM_Menu"
        Me.mnu_Main.ResumeLayout(False)
        Me.mnu_Main.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnu_Main As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ApplicationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShifterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopAnusWMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShutdownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_Title As Label
End Class
