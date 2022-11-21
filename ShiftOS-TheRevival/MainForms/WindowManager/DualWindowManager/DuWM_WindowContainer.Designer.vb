<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DuWM_WindowContainer
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
        Me.DuWM_ContainerPanel = New System.Windows.Forms.Panel()
        Me.DuWM_WMCheck = New System.Windows.Forms.Timer(Me.components)
        Me.DuWM_ChildSize = New System.Windows.Forms.Timer(Me.components)
        Me.DuWM_LayoutCheck = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'DuWM_ContainerPanel
        '
        Me.DuWM_ContainerPanel.BackColor = System.Drawing.Color.Transparent
        Me.DuWM_ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DuWM_ContainerPanel.Location = New System.Drawing.Point(0, 0)
        Me.DuWM_ContainerPanel.Name = "DuWM_ContainerPanel"
        Me.DuWM_ContainerPanel.Size = New System.Drawing.Size(800, 450)
        Me.DuWM_ContainerPanel.TabIndex = 0
        '
        'DuWM_WMCheck
        '
        '
        'DuWM_ChildSize
        '
        '
        'DuWM_LayoutCheck
        '
        '
        'DuWM_WindowContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DuWM_ContainerPanel)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DuWM_WindowContainer"
        Me.Text = "DuWM_WindowContainer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DuWM_ContainerPanel As Panel
    Friend WithEvents DuWM_WMCheck As Timer
    Friend WithEvents DuWM_ChildSize As Timer
    Friend WithEvents DuWM_LayoutCheck As Timer
End Class
