<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Uni_KnowledgeInput
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
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.cmb_Category = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_InputWord = New System.Windows.Forms.TextBox()
        Me.lst_Guessed = New System.Windows.Forms.ListBox()
        Me.lbl_Guessed = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(274, 45)
        Me.lbl_Title.TabIndex = 0
        Me.lbl_Title.Text = "Knowledge Input"
        '
        'cmb_Category
        '
        Me.cmb_Category.BackColor = System.Drawing.Color.White
        Me.cmb_Category.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.cmb_Category.ForeColor = System.Drawing.Color.Black
        Me.cmb_Category.FormattingEnabled = True
        Me.cmb_Category.Items.AddRange(New Object() {"Animals", "Countries", "Fruits"})
        Me.cmb_Category.Location = New System.Drawing.Point(20, 73)
        Me.cmb_Category.Name = "cmb_Category"
        Me.cmb_Category.Size = New System.Drawing.Size(266, 31)
        Me.cmb_Category.TabIndex = 1
        Me.cmb_Category.Text = "Select Category"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_InputWord)
        Me.Panel1.Controls.Add(Me.lbl_Title)
        Me.Panel1.Controls.Add(Me.cmb_Category)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 125)
        Me.Panel1.TabIndex = 2
        '
        'txt_InputWord
        '
        Me.txt_InputWord.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_InputWord.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.txt_InputWord.Location = New System.Drawing.Point(292, 73)
        Me.txt_InputWord.Name = "txt_InputWord"
        Me.txt_InputWord.Size = New System.Drawing.Size(470, 30)
        Me.txt_InputWord.TabIndex = 2
        '
        'lst_Guessed
        '
        Me.lst_Guessed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lst_Guessed.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.lst_Guessed.FormattingEnabled = True
        Me.lst_Guessed.ItemHeight = 23
        Me.lst_Guessed.Location = New System.Drawing.Point(20, 177)
        Me.lst_Guessed.Name = "lst_Guessed"
        Me.lst_Guessed.Size = New System.Drawing.Size(752, 372)
        Me.lst_Guessed.TabIndex = 3
        '
        'lbl_Guessed
        '
        Me.lbl_Guessed.AutoSize = True
        Me.lbl_Guessed.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.lbl_Guessed.Location = New System.Drawing.Point(16, 140)
        Me.lbl_Guessed.Name = "lbl_Guessed"
        Me.lbl_Guessed.Size = New System.Drawing.Size(132, 23)
        Me.lbl_Guessed.TabIndex = 4
        Me.lbl_Guessed.Text = "Guessed Words :"
        '
        'Uni_KnowledgeInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_Guessed)
        Me.Controls.Add(Me.lst_Guessed)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Uni_KnowledgeInput"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Uni_KnowledgeInput"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Title As Label
    Friend WithEvents cmb_Category As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_InputWord As TextBox
    Friend WithEvents lst_Guessed As ListBox
    Friend WithEvents lbl_Guessed As Label
End Class
