<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DuWM_Shifter_Console
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
        Me.lbl_DescConsole = New System.Windows.Forms.Label()
        Me.lbl_ConsoleFont = New System.Windows.Forms.Label()
        Me.cmb_ConsoleFont = New System.Windows.Forms.ComboBox()
        Me.lbl_ConsoleFontSize = New System.Windows.Forms.Label()
        Me.cmb_ConsoleFontSize = New System.Windows.Forms.ComboBox()
        Me.lbl_Example = New System.Windows.Forms.Label()
        Me.txt_ConsoleExample = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Font = New System.Drawing.Font("Segoe UI", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_Title.Location = New System.Drawing.Point(11, 10)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(136, 45)
        Me.lbl_Title.TabIndex = 1
        Me.lbl_Title.Text = "Console"
        '
        'lbl_DescConsole
        '
        Me.lbl_DescConsole.AutoSize = True
        Me.lbl_DescConsole.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_DescConsole.ForeColor = System.Drawing.Color.Black
        Me.lbl_DescConsole.Location = New System.Drawing.Point(15, 71)
        Me.lbl_DescConsole.Name = "lbl_DescConsole"
        Me.lbl_DescConsole.Size = New System.Drawing.Size(266, 21)
        Me.lbl_DescConsole.TabIndex = 3
        Me.lbl_DescConsole.Text = "Choose Console font face and its size"
        '
        'lbl_ConsoleFont
        '
        Me.lbl_ConsoleFont.AutoSize = True
        Me.lbl_ConsoleFont.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_ConsoleFont.ForeColor = System.Drawing.Color.Black
        Me.lbl_ConsoleFont.Location = New System.Drawing.Point(15, 106)
        Me.lbl_ConsoleFont.Name = "lbl_ConsoleFont"
        Me.lbl_ConsoleFont.Size = New System.Drawing.Size(135, 21)
        Me.lbl_ConsoleFont.TabIndex = 4
        Me.lbl_ConsoleFont.Text = "Console Font Face"
        '
        'cmb_ConsoleFont
        '
        Me.cmb_ConsoleFont.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_ConsoleFont.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmb_ConsoleFont.FormattingEnabled = True
        Me.cmb_ConsoleFont.Items.AddRange(New Object() {"Consolas", "Courier New", "Lucida Console"})
        Me.cmb_ConsoleFont.Location = New System.Drawing.Point(156, 103)
        Me.cmb_ConsoleFont.Name = "cmb_ConsoleFont"
        Me.cmb_ConsoleFont.Size = New System.Drawing.Size(250, 30)
        Me.cmb_ConsoleFont.TabIndex = 5
        '
        'lbl_ConsoleFontSize
        '
        Me.lbl_ConsoleFontSize.AutoSize = True
        Me.lbl_ConsoleFontSize.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_ConsoleFontSize.ForeColor = System.Drawing.Color.Black
        Me.lbl_ConsoleFontSize.Location = New System.Drawing.Point(15, 147)
        Me.lbl_ConsoleFontSize.Name = "lbl_ConsoleFontSize"
        Me.lbl_ConsoleFontSize.Size = New System.Drawing.Size(133, 21)
        Me.lbl_ConsoleFontSize.TabIndex = 6
        Me.lbl_ConsoleFontSize.Text = "Console Font Size"
        '
        'cmb_ConsoleFontSize
        '
        Me.cmb_ConsoleFontSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_ConsoleFontSize.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmb_ConsoleFontSize.FormattingEnabled = True
        Me.cmb_ConsoleFontSize.Items.AddRange(New Object() {"6", "8", "9", "10", "11", "12", "14", "16"})
        Me.cmb_ConsoleFontSize.Location = New System.Drawing.Point(156, 144)
        Me.cmb_ConsoleFontSize.Name = "cmb_ConsoleFontSize"
        Me.cmb_ConsoleFontSize.Size = New System.Drawing.Size(70, 30)
        Me.cmb_ConsoleFontSize.TabIndex = 5
        '
        'lbl_Example
        '
        Me.lbl_Example.AutoSize = True
        Me.lbl_Example.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_Example.ForeColor = System.Drawing.Color.Black
        Me.lbl_Example.Location = New System.Drawing.Point(15, 189)
        Me.lbl_Example.Name = "lbl_Example"
        Me.lbl_Example.Size = New System.Drawing.Size(75, 21)
        Me.lbl_Example.TabIndex = 6
        Me.lbl_Example.Text = "Example :"
        '
        'txt_ConsoleExample
        '
        Me.txt_ConsoleExample.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ConsoleExample.BackColor = System.Drawing.Color.Black
        Me.txt_ConsoleExample.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ConsoleExample.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.txt_ConsoleExample.ForeColor = System.Drawing.Color.White
        Me.txt_ConsoleExample.Location = New System.Drawing.Point(19, 218)
        Me.txt_ConsoleExample.Multiline = True
        Me.txt_ConsoleExample.Name = "txt_ConsoleExample"
        Me.txt_ConsoleExample.ReadOnly = True
        Me.txt_ConsoleExample.Size = New System.Drawing.Size(600, 243)
        Me.txt_ConsoleExample.TabIndex = 7
        Me.txt_ConsoleExample.Text = "devx@shiftos $> ver" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ShiftOS 11 build 11.0.9"
        '
        'DuWM_Shifter_Console
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txt_ConsoleExample)
        Me.Controls.Add(Me.lbl_Example)
        Me.Controls.Add(Me.lbl_ConsoleFontSize)
        Me.Controls.Add(Me.cmb_ConsoleFontSize)
        Me.Controls.Add(Me.cmb_ConsoleFont)
        Me.Controls.Add(Me.lbl_ConsoleFont)
        Me.Controls.Add(Me.lbl_DescConsole)
        Me.Controls.Add(Me.lbl_Title)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "DuWM_Shifter_Console"
        Me.Size = New System.Drawing.Size(640, 480)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Title As Label
    Friend WithEvents lbl_DescConsole As Label
    Friend WithEvents lbl_ConsoleFont As Label
    Friend WithEvents cmb_ConsoleFont As ComboBox
    Friend WithEvents lbl_ConsoleFontSize As Label
    Friend WithEvents cmb_ConsoleFontSize As ComboBox
    Friend WithEvents lbl_Example As Label
    Friend WithEvents txt_ConsoleExample As TextBox
End Class
