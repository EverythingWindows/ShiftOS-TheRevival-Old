<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Uni_FileSkimmer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Uni_FileSkimmer))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("test", 0)
        Me.msn_Options = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertyPaneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnl_Ribbon = New System.Windows.Forms.Panel()
        Me.pnl_Properties = New System.Windows.Forms.Panel()
        Me.lbl_filesize = New System.Windows.Forms.Label()
        Me.lbl_filetype = New System.Windows.Forms.Label()
        Me.lbl_filename = New System.Windows.Forms.Label()
        Me.lbl_Properties = New System.Windows.Forms.Label()
        Me.iml_icons = New System.Windows.Forms.ImageList(Me.components)
        Me.pnl_AddressBar = New System.Windows.Forms.Panel()
        Me.btn_Up = New System.Windows.Forms.Button()
        Me.txt_AddressBar = New System.Windows.Forms.TextBox()
        Me.lbl_Address = New System.Windows.Forms.Label()
        Me.lsv_Content = New System.Windows.Forms.ListView()
        Me.pic_Icon = New System.Windows.Forms.PictureBox()
        Me.btn_NewFolder = New System.Windows.Forms.Button()
        Me.msn_Options.SuspendLayout()
        Me.pnl_Ribbon.SuspendLayout()
        Me.pnl_Properties.SuspendLayout()
        Me.pnl_AddressBar.SuspendLayout()
        CType(Me.pic_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msn_Options
        '
        Me.msn_Options.BackColor = System.Drawing.Color.White
        Me.msn_Options.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.msn_Options.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.msn_Options.Location = New System.Drawing.Point(0, 0)
        Me.msn_Options.Name = "msn_Options"
        Me.msn_Options.Size = New System.Drawing.Size(800, 27)
        Me.msn_Options.TabIndex = 0
        Me.msn_Options.Text = "mns_Options"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(41, 23)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PropertyPaneToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(70, 23)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'PropertyPaneToolStripMenuItem
        '
        Me.PropertyPaneToolStripMenuItem.CheckOnClick = True
        Me.PropertyPaneToolStripMenuItem.Name = "PropertyPaneToolStripMenuItem"
        Me.PropertyPaneToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.PropertyPaneToolStripMenuItem.Text = "Property Pane"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(59, 23)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'pnl_Ribbon
        '
        Me.pnl_Ribbon.BackColor = System.Drawing.Color.Silver
        Me.pnl_Ribbon.Controls.Add(Me.btn_NewFolder)
        Me.pnl_Ribbon.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_Ribbon.Location = New System.Drawing.Point(0, 27)
        Me.pnl_Ribbon.Name = "pnl_Ribbon"
        Me.pnl_Ribbon.Size = New System.Drawing.Size(800, 69)
        Me.pnl_Ribbon.TabIndex = 1
        '
        'pnl_Properties
        '
        Me.pnl_Properties.BackColor = System.Drawing.Color.Gray
        Me.pnl_Properties.Controls.Add(Me.pic_Icon)
        Me.pnl_Properties.Controls.Add(Me.lbl_filesize)
        Me.pnl_Properties.Controls.Add(Me.lbl_filetype)
        Me.pnl_Properties.Controls.Add(Me.lbl_filename)
        Me.pnl_Properties.Controls.Add(Me.lbl_Properties)
        Me.pnl_Properties.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_Properties.Location = New System.Drawing.Point(600, 132)
        Me.pnl_Properties.Name = "pnl_Properties"
        Me.pnl_Properties.Size = New System.Drawing.Size(200, 318)
        Me.pnl_Properties.TabIndex = 2
        Me.pnl_Properties.Visible = False
        '
        'lbl_filesize
        '
        Me.lbl_filesize.AutoSize = True
        Me.lbl_filesize.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lbl_filesize.Location = New System.Drawing.Point(8, 155)
        Me.lbl_filesize.Name = "lbl_filesize"
        Me.lbl_filesize.Size = New System.Drawing.Size(26, 13)
        Me.lbl_filesize.TabIndex = 1
        Me.lbl_filesize.Text = "size"
        '
        'lbl_filetype
        '
        Me.lbl_filetype.AutoSize = True
        Me.lbl_filetype.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lbl_filetype.Location = New System.Drawing.Point(9, 139)
        Me.lbl_filetype.Name = "lbl_filetype"
        Me.lbl_filetype.Size = New System.Drawing.Size(45, 13)
        Me.lbl_filetype.TabIndex = 1
        Me.lbl_filetype.Text = "filetype"
        '
        'lbl_filename
        '
        Me.lbl_filename.AutoSize = True
        Me.lbl_filename.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lbl_filename.Location = New System.Drawing.Point(7, 117)
        Me.lbl_filename.Name = "lbl_filename"
        Me.lbl_filename.Size = New System.Drawing.Size(67, 20)
        Me.lbl_filename.TabIndex = 1
        Me.lbl_filename.Text = "filename"
        '
        'lbl_Properties
        '
        Me.lbl_Properties.AutoSize = True
        Me.lbl_Properties.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Properties.Location = New System.Drawing.Point(7, 7)
        Me.lbl_Properties.Name = "lbl_Properties"
        Me.lbl_Properties.Size = New System.Drawing.Size(105, 25)
        Me.lbl_Properties.TabIndex = 0
        Me.lbl_Properties.Text = "Properties"
        '
        'iml_icons
        '
        Me.iml_icons.ImageStream = CType(resources.GetObject("iml_icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iml_icons.TransparentColor = System.Drawing.Color.Transparent
        Me.iml_icons.Images.SetKeyName(0, "ico_folder.bmp")
        Me.iml_icons.Images.SetKeyName(1, "ico_textfile.bmp")
        Me.iml_icons.Images.SetKeyName(2, "ico_unknown.bmp")
        Me.iml_icons.Images.SetKeyName(3, "ico_picture.bmp")
        Me.iml_icons.Images.SetKeyName(4, "ico_up.bmp")
        Me.iml_icons.Images.SetKeyName(5, "ico_url.bmp")
        Me.iml_icons.Images.SetKeyName(6, "ico_video.bmp")
        Me.iml_icons.Images.SetKeyName(7, "ico_sfp.png")
        Me.iml_icons.Images.SetKeyName(8, "ico_exe.png")
        '
        'pnl_AddressBar
        '
        Me.pnl_AddressBar.Controls.Add(Me.btn_Up)
        Me.pnl_AddressBar.Controls.Add(Me.txt_AddressBar)
        Me.pnl_AddressBar.Controls.Add(Me.lbl_Address)
        Me.pnl_AddressBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_AddressBar.Location = New System.Drawing.Point(0, 96)
        Me.pnl_AddressBar.Name = "pnl_AddressBar"
        Me.pnl_AddressBar.Size = New System.Drawing.Size(800, 36)
        Me.pnl_AddressBar.TabIndex = 4
        '
        'btn_Up
        '
        Me.btn_Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Up.Location = New System.Drawing.Point(65, 5)
        Me.btn_Up.Name = "btn_Up"
        Me.btn_Up.Size = New System.Drawing.Size(24, 24)
        Me.btn_Up.TabIndex = 2
        Me.btn_Up.UseVisualStyleBackColor = True
        '
        'txt_AddressBar
        '
        Me.txt_AddressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_AddressBar.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_AddressBar.Location = New System.Drawing.Point(161, 5)
        Me.txt_AddressBar.Name = "txt_AddressBar"
        Me.txt_AddressBar.Size = New System.Drawing.Size(627, 25)
        Me.txt_AddressBar.TabIndex = 1
        '
        'lbl_Address
        '
        Me.lbl_Address.AutoSize = True
        Me.lbl_Address.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl_Address.Location = New System.Drawing.Point(90, 8)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(65, 19)
        Me.lbl_Address.TabIndex = 0
        Me.lbl_Address.Text = "Address :"
        '
        'lsv_Content
        '
        Me.lsv_Content.BackColor = System.Drawing.Color.White
        Me.lsv_Content.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lsv_Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Content.HideSelection = False
        Me.lsv_Content.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.lsv_Content.LargeImageList = Me.iml_icons
        Me.lsv_Content.Location = New System.Drawing.Point(0, 132)
        Me.lsv_Content.MultiSelect = False
        Me.lsv_Content.Name = "lsv_Content"
        Me.lsv_Content.Size = New System.Drawing.Size(600, 318)
        Me.lsv_Content.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lsv_Content.TabIndex = 5
        Me.lsv_Content.UseCompatibleStateImageBehavior = False
        '
        'pic_Icon
        '
        Me.pic_Icon.Location = New System.Drawing.Point(10, 42)
        Me.pic_Icon.Name = "pic_Icon"
        Me.pic_Icon.Size = New System.Drawing.Size(64, 64)
        Me.pic_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Icon.TabIndex = 2
        Me.pic_Icon.TabStop = False
        '
        'btn_NewFolder
        '
        Me.btn_NewFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_NewFolder.Image = Global.ShiftOS_TheRevival.My.Resources.Resources.ico_folder
        Me.btn_NewFolder.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_NewFolder.Location = New System.Drawing.Point(0, 0)
        Me.btn_NewFolder.Name = "btn_NewFolder"
        Me.btn_NewFolder.Size = New System.Drawing.Size(72, 69)
        Me.btn_NewFolder.TabIndex = 0
        Me.btn_NewFolder.Text = "New Folder"
        Me.btn_NewFolder.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_NewFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_NewFolder.UseVisualStyleBackColor = True
        '
        'Uni_FileSkimmer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lsv_Content)
        Me.Controls.Add(Me.pnl_Properties)
        Me.Controls.Add(Me.pnl_AddressBar)
        Me.Controls.Add(Me.pnl_Ribbon)
        Me.Controls.Add(Me.msn_Options)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.msn_Options
        Me.Name = "Uni_FileSkimmer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Uni_FileSkimmer"
        Me.msn_Options.ResumeLayout(False)
        Me.msn_Options.PerformLayout()
        Me.pnl_Ribbon.ResumeLayout(False)
        Me.pnl_Properties.ResumeLayout(False)
        Me.pnl_Properties.PerformLayout()
        Me.pnl_AddressBar.ResumeLayout(False)
        Me.pnl_AddressBar.PerformLayout()
        CType(Me.pic_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msn_Options As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnl_Ribbon As Panel
    Friend WithEvents pnl_Properties As Panel
    Friend WithEvents pnl_AddressBar As Panel
    Friend WithEvents lbl_Address As Label
    Friend WithEvents txt_AddressBar As TextBox
    Friend WithEvents lbl_Properties As Label
    Friend WithEvents lbl_filename As Label
    Friend WithEvents lbl_filetype As Label
    Friend WithEvents lbl_filesize As Label
    Friend WithEvents pic_Icon As PictureBox
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents iml_icons As ImageList
    Friend WithEvents lsv_Content As ListView
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PropertyPaneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_NewFolder As Button
    Friend WithEvents btn_Up As Button
End Class
