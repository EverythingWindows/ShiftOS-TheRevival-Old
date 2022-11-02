<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IntroStory
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
        Me.OpacityPlay = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'OpacityPlay
        '
        '
        'IntroStory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Name = "IntroStory"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "IntroStory"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpacityPlay As Timer
End Class
