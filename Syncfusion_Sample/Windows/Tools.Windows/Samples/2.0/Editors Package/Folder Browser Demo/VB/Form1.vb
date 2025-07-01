Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO

Imports Syncfusion.Windows.Forms

Namespace FolderBrowserDemo
	Public Class frmFolderBrowser : Inherits System.Windows.Forms.Form
		Private WithEvents folderBrowser1 As Syncfusion.Windows.Forms.FolderBrowser
		Private groupBox1 As System.Windows.Forms.Panel
		Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private label1 As System.Windows.Forms.Label
		Private statusBar1 As System.Windows.Forms.StatusBar
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private WithEvents cbShowShares As System.Windows.Forms.CheckBox
		Private WithEvents cbBrowseForEverything As System.Windows.Forms.CheckBox
		Private WithEvents cbBrowseForPrinter As System.Windows.Forms.CheckBox
		Private WithEvents cbBrowseForComputer As System.Windows.Forms.CheckBox
		Private WithEvents cbAllowUrls As System.Windows.Forms.CheckBox
		Private WithEvents cbNewDialogStyle As System.Windows.Forms.CheckBox
		Private WithEvents cbValidate As System.Windows.Forms.CheckBox
		Private WithEvents cbShowTextBox As System.Windows.Forms.CheckBox
		Private WithEvents cbRestrictToSubfolders As System.Windows.Forms.CheckBox
		Private WithEvents cbRestrictToDomain As System.Windows.Forms.CheckBox
		Private WithEvents cbRestrictToFilesystem As System.Windows.Forms.CheckBox
		Private textBox1 As System.Windows.Forms.TextBox
		Private label2 As System.Windows.Forms.Label
		Private groupBox3 As System.Windows.Forms.Panel
		Private WithEvents buttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub


		#Region "Windows Form Designer generated code"

		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFolderBrowser))
			Me.folderBrowser1 = New Syncfusion.Windows.Forms.FolderBrowser(Me.components)
			Me.groupBox1 = New System.Windows.Forms.Panel()
			Me.label1 = New System.Windows.Forms.Label()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.statusBar1 = New System.Windows.Forms.StatusBar()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.cbRestrictToFilesystem = New System.Windows.Forms.CheckBox()
			Me.cbRestrictToDomain = New System.Windows.Forms.CheckBox()
			Me.cbRestrictToSubfolders = New System.Windows.Forms.CheckBox()
			Me.cbShowTextBox = New System.Windows.Forms.CheckBox()
			Me.cbValidate = New System.Windows.Forms.CheckBox()
			Me.cbNewDialogStyle = New System.Windows.Forms.CheckBox()
			Me.cbAllowUrls = New System.Windows.Forms.CheckBox()
			Me.cbBrowseForComputer = New System.Windows.Forms.CheckBox()
			Me.cbBrowseForPrinter = New System.Windows.Forms.CheckBox()
			Me.cbBrowseForEverything = New System.Windows.Forms.CheckBox()
			Me.cbShowShares = New System.Windows.Forms.CheckBox()
			Me.groupBox3 = New System.Windows.Forms.Panel()
			Me.label3 = New System.Windows.Forms.Label()
			Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.label4 = New System.Windows.Forms.Label()
			Me.groupBox1.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			Me.groupBox3.SuspendLayout()
			Me.SuspendLayout()
			' 
			' folderBrowser1
			' 
			Me.folderBrowser1.StartLocation = Syncfusion.Windows.Forms.FolderBrowserFolder.Desktop
			Me.folderBrowser1.Style = Syncfusion.Windows.Forms.FolderBrowserStyles.RestrictToFilesystem
'			Me.folderBrowser1.FolderBrowserCallback += New Syncfusion.Windows.Forms.FolderBrowserCallbackEventHandler(Me.folderBrowser1_FolderBrowserCallback);
			' 
			' groupBox1
			' 
			Me.groupBox1.BackColor = System.Drawing.Color.FromArgb((CByte(255)), (CByte(240)), (CByte(225)))
			Me.groupBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.groupBox1.Controls.AddRange(New System.Windows.Forms.Control() { Me.label4, Me.label1, Me.checkBox1, Me.comboBox1, Me.textBox1, Me.label2})
			Me.groupBox1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox1.ForeColor = System.Drawing.Color.Brown
			Me.groupBox1.Location = New System.Drawing.Point(8, 16)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(368, 136)
			Me.groupBox1.TabIndex = 0
			Me.groupBox1.Text = "Set Start Location"
			' 
			' label1
			' 
			Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.ForeColor = System.Drawing.Color.Black
			Me.label1.Location = New System.Drawing.Point(15, 40)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(96, 16)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Start Location:"
			' 
			' checkBox1
			' 
			Me.checkBox1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox1.ForeColor = System.Drawing.Color.Black
			Me.checkBox1.Location = New System.Drawing.Point(16, 72)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(136, 16)
			Me.checkBox1.TabIndex = 1
			Me.checkBox1.Text = "Custom Start Location"
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged);
			' 
			' comboBox1
			' 
			Me.comboBox1.BackColor = System.Drawing.SystemColors.Window
			Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.comboBox1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBox1.ForeColor = System.Drawing.Color.Black
			Me.comboBox1.Location = New System.Drawing.Point(117, 40)
			Me.comboBox1.MaxDropDownItems = 10
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(160, 21)
			Me.comboBox1.TabIndex = 0
'			Me.comboBox1.SelectionChangeCommitted += New System.EventHandler(Me.comboBox1_SelectionChangeCommitted);
			' 
			' textBox1
			' 
			Me.textBox1.BackColor = System.Drawing.SystemColors.Window
			Me.textBox1.Location = New System.Drawing.Point(103, 102)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(232, 21)
			Me.textBox1.TabIndex = 4
			Me.textBox1.Text = ""
			Me.textBox1.Visible = False
			' 
			' label2
			' 
			Me.label2.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.ForeColor = System.Drawing.Color.Black
			Me.label2.Location = New System.Drawing.Point(15, 106)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(96, 16)
			Me.label2.TabIndex = 5
			Me.label2.Text = "Custom Location:"
			Me.label2.Visible = False
			' 
			' statusBar1
			' 
			Me.statusBar1.Location = New System.Drawing.Point(0, 359)
			Me.statusBar1.Name = "statusBar1"
			Me.statusBar1.Size = New System.Drawing.Size(642, 24)
			Me.statusBar1.TabIndex = 2
			Me.statusBar1.Text = "Folder Browser Demo"
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.AddRange(New System.Windows.Forms.Control() { Me.cbRestrictToFilesystem, Me.cbRestrictToDomain, Me.cbRestrictToSubfolders, Me.cbShowTextBox, Me.cbValidate, Me.cbNewDialogStyle, Me.cbAllowUrls, Me.cbBrowseForComputer, Me.cbBrowseForPrinter, Me.cbBrowseForEverything, Me.cbShowShares})
			Me.groupBox2.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox2.ForeColor = System.Drawing.Color.Brown
			Me.groupBox2.Location = New System.Drawing.Point(8, 160)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(624, 187)
			Me.groupBox2.TabIndex = 3
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Folder Browser Styles"
			' 
			' cbRestrictToFilesystem
			' 
			Me.cbRestrictToFilesystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.cbRestrictToFilesystem.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cbRestrictToFilesystem.ForeColor = System.Drawing.Color.Black
			Me.cbRestrictToFilesystem.Location = New System.Drawing.Point(240, 64)
			Me.cbRestrictToFilesystem.Name = "cbRestrictToFilesystem"
			Me.cbRestrictToFilesystem.Size = New System.Drawing.Size(144, 16)
			Me.cbRestrictToFilesystem.TabIndex = 10
			Me.cbRestrictToFilesystem.Text = "Restrict To File System"
'			Me.cbRestrictToFilesystem.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged);
			' 
			' cbRestrictToDomain
			' 
			Me.cbRestrictToDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.cbRestrictToDomain.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cbRestrictToDomain.ForeColor = System.Drawing.Color.Black
			Me.cbRestrictToDomain.Location = New System.Drawing.Point(16, 150)
			Me.cbRestrictToDomain.Name = "cbRestrictToDomain"
			Me.cbRestrictToDomain.Size = New System.Drawing.Size(120, 16)
			Me.cbRestrictToDomain.TabIndex = 9
			Me.cbRestrictToDomain.Text = "Restrict To Domain"
'			Me.cbRestrictToDomain.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged);
			' 
			' cbRestrictToSubfolders
			' 
			Me.cbRestrictToSubfolders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.cbRestrictToSubfolders.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cbRestrictToSubfolders.ForeColor = System.Drawing.Color.Black
			Me.cbRestrictToSubfolders.Location = New System.Drawing.Point(16, 108)
			Me.cbRestrictToSubfolders.Name = "cbRestrictToSubfolders"
			Me.cbRestrictToSubfolders.Size = New System.Drawing.Size(128, 16)
			Me.cbRestrictToSubfolders.TabIndex = 8
			Me.cbRestrictToSubfolders.Text = "Restrict To Subfolders"
'			Me.cbRestrictToSubfolders.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged);
			' 
			' cbShowTextBox
			' 
			Me.cbShowTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.cbShowTextBox.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cbShowTextBox.ForeColor = System.Drawing.Color.Black
			Me.cbShowTextBox.Location = New System.Drawing.Point(240, 108)
			Me.cbShowTextBox.Name = "cbShowTextBox"
			Me.cbShowTextBox.Size = New System.Drawing.Size(96, 16)
			Me.cbShowTextBox.TabIndex = 7
			Me.cbShowTextBox.Text = "Show TextBox"
'			Me.cbShowTextBox.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged);
			' 
			' cbValidate
			' 
			Me.cbValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.cbValidate.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cbValidate.ForeColor = System.Drawing.Color.Black
			Me.cbValidate.Location = New System.Drawing.Point(480, 104)
			Me.cbValidate.Name = "cbValidate"
			Me.cbValidate.Size = New System.Drawing.Size(80, 24)
			Me.cbValidate.TabIndex = 6
			Me.cbValidate.Text = "Validate"
'			Me.cbValidate.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged);
			' 
			' cbNewDialogStyle
			' 
			Me.cbNewDialogStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.cbNewDialogStyle.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cbNewDialogStyle.ForeColor = System.Drawing.Color.Black
			Me.cbNewDialogStyle.Location = New System.Drawing.Point(240, 146)
			Me.cbNewDialogStyle.Name = "cbNewDialogStyle"
			Me.cbNewDialogStyle.Size = New System.Drawing.Size(112, 24)
			Me.cbNewDialogStyle.TabIndex = 5
			Me.cbNewDialogStyle.Text = "New Dialog Style"
'			Me.cbNewDialogStyle.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged);
			' 
			' cbAllowUrls
			' 
			Me.cbAllowUrls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.cbAllowUrls.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cbAllowUrls.ForeColor = System.Drawing.Color.Black
			Me.cbAllowUrls.Location = New System.Drawing.Point(480, 64)
			Me.cbAllowUrls.Name = "cbAllowUrls"
			Me.cbAllowUrls.Size = New System.Drawing.Size(112, 16)
			Me.cbAllowUrls.TabIndex = 4
			Me.cbAllowUrls.Text = "Allow Urls"
'			Me.cbAllowUrls.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged);
			' 
			' cbBrowseForComputer
			' 
			Me.cbBrowseForComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.cbBrowseForComputer.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cbBrowseForComputer.ForeColor = System.Drawing.Color.Black
			Me.cbBrowseForComputer.Location = New System.Drawing.Point(16, 64)
			Me.cbBrowseForComputer.Name = "cbBrowseForComputer"
			Me.cbBrowseForComputer.Size = New System.Drawing.Size(136, 16)
			Me.cbBrowseForComputer.TabIndex = 3
			Me.cbBrowseForComputer.Text = "Browse For Computer"
'			Me.cbBrowseForComputer.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged);
			' 
			' cbBrowseForPrinter
			' 
			Me.cbBrowseForPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.cbBrowseForPrinter.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cbBrowseForPrinter.ForeColor = System.Drawing.Color.Black
			Me.cbBrowseForPrinter.Location = New System.Drawing.Point(480, 24)
			Me.cbBrowseForPrinter.Name = "cbBrowseForPrinter"
			Me.cbBrowseForPrinter.Size = New System.Drawing.Size(120, 16)
			Me.cbBrowseForPrinter.TabIndex = 2
			Me.cbBrowseForPrinter.Text = "Browse For Printer"
'			Me.cbBrowseForPrinter.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged);
			' 
			' cbBrowseForEverything
			' 
			Me.cbBrowseForEverything.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.cbBrowseForEverything.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cbBrowseForEverything.ForeColor = System.Drawing.Color.Black
			Me.cbBrowseForEverything.Location = New System.Drawing.Point(240, 24)
			Me.cbBrowseForEverything.Name = "cbBrowseForEverything"
			Me.cbBrowseForEverything.Size = New System.Drawing.Size(144, 16)
			Me.cbBrowseForEverything.TabIndex = 1
			Me.cbBrowseForEverything.Text = "Browse For Everything"
'			Me.cbBrowseForEverything.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged);
			' 
			' cbShowShares
			' 
			Me.cbShowShares.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.cbShowShares.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cbShowShares.ForeColor = System.Drawing.Color.Black
			Me.cbShowShares.Location = New System.Drawing.Point(16, 24)
			Me.cbShowShares.Name = "cbShowShares"
			Me.cbShowShares.Size = New System.Drawing.Size(128, 16)
			Me.cbShowShares.TabIndex = 0
			Me.cbShowShares.Text = "Show Admin Shares"
'			Me.cbShowShares.CheckedChanged += New System.EventHandler(Me.checkBox_CheckedChanged);
			' 
			' groupBox3
			' 
			Me.groupBox3.BackColor = System.Drawing.Color.FromArgb((CByte(255)), (CByte(240)), (CByte(225)))
			Me.groupBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.groupBox3.Controls.AddRange(New System.Windows.Forms.Control() { Me.label3, Me.buttonAdv1})
			Me.groupBox3.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox3.ForeColor = System.Drawing.Color.Brown
			Me.groupBox3.Location = New System.Drawing.Point(400, 16)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(232, 136)
			Me.groupBox3.TabIndex = 6
			Me.groupBox3.Text = "Folder Browser"
			' 
			' label3
			' 
			Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.ForeColor = System.Drawing.Color.Black
			Me.label3.Location = New System.Drawing.Point(23, 18)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(184, 40)
			Me.label3.TabIndex = 1
			Me.label3.Text = "The Folder Browser is intended to provide a convinient browsing to files and fold" & "ers"
			' 
			' buttonAdv1
			' 
			Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonAdv1.ComboEditBackColor = System.Drawing.Color.Empty
			Me.buttonAdv1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonAdv1.ForeColor = System.Drawing.Color.Black
			Me.buttonAdv1.IsMouseDown = False
			Me.buttonAdv1.Location = New System.Drawing.Point(56, 96)
			Me.buttonAdv1.Name = "buttonAdv1"
			Me.buttonAdv1.Size = New System.Drawing.Size(128, 21)
			Me.buttonAdv1.TabIndex = 0
			Me.buttonAdv1.Text = "Show FolderBrowser"
			Me.buttonAdv1.UseVisualStyle = True
'			Me.buttonAdv1.Click += New System.EventHandler(Me.cmdShowBrowser_Click);
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(8, 7)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(110, 14)
			Me.label4.TabIndex = 6
			Me.label4.Text = "Set Start Location:"
			' 
			' frmFolderBrowser
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
			Me.BackColor = System.Drawing.Color.FromArgb((CByte(223)), (CByte(227)), (CByte(239)))
			Me.ClientSize = New System.Drawing.Size(642, 383)
			Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.groupBox3, Me.groupBox2, Me.statusBar1, Me.groupBox1})
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "frmFolderBrowser"
			Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Folder Browser Demo"
'			Me.Load += New System.EventHandler(Me.frmFolderBrowser_Load);
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox3.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		<STAThread> _
		Shared Sub Main()
			Application.Run(New frmFolderBrowser())
		End Sub

		Private Sub frmFolderBrowser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			' To Populate the ComboxBox1 with the Folder Path.
			Me.comboBox1.Items.AddRange(New String() { "Desktop Directory", "My Computer", "My Documents", "Desktop", "Internet", "Programs", "Control Panel", "Printers", "Personal","Favorites","Startup", "Recent", "Send To", "Recycle Bin", "Start Menu", "My Music", "My Video", "Network Neighborhood", "NetHood", "Fonts", "Templates", "My Pictures", "Common Documents", "Common Admin Tools", "Net And DialUp Connections", "Common Music", "Common Pictures", "Common Video", "Resources", "CD Burn Area", "Computers Near Me"})

			Me.folderBrowser1.StartLocation = Syncfusion.Windows.Forms.FolderBrowserFolder.Desktop
			Me.folderBrowser1.Description = "This is the Demo of Syncfusion FolderBrowser Control."
			Me.comboBox1.SelectedIndex = 3
		End Sub

		Private Sub cmdShowBrowser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonAdv1.Click
			If textBox1.Visible = True OrElse textBox1.Text.Trim().Length>0 Then
				'If this check is omitted FolderBrowser will display its own Error Message.
				If (Not Directory.Exists(textBox1.Text.Trim())) Then
					MessageBox.Show("Kindly Check the Path.")
					Return
				End If
				Me.folderBrowser1.CustomStartLocation = textBox1.Text
				Me.folderBrowser1.StartLocation = FolderBrowserFolder.CustomStartLocation
			End If

			' To reset the StartLocation after using CustomStartLocation.
			If checkBox1.Checked = False Then
				comboBox1_SelectionChangeCommitted(sender,e)
			End If

			If folderBrowser1.ShowDialog()= DialogResult.OK Then
				Me.statusBar1.Text = folderBrowser1.DirectoryPath
			End If
		End Sub

#Region "Set Folder Browser StartLocation"
        Private Sub comboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectionChangeCommitted
            Select Case comboBox1.Items(comboBox1.SelectedIndex).ToString()
                Case "Recycle Bin"
                    folderBrowser1.StartLocation = FolderBrowserFolder.BitBucket
                Case "CD Burn Area"
                    folderBrowser1.StartLocation = FolderBrowserFolder.CDBurnArea
                Case "Common Admin Tools"
                    folderBrowser1.StartLocation = FolderBrowserFolder.CommonAdminTools
                Case "Common Documents"
                    folderBrowser1.StartLocation = FolderBrowserFolder.CommonDocuments
                Case "Common Music"
                    folderBrowser1.StartLocation = FolderBrowserFolder.CommonMusic
                Case "Common Pictures"
                    folderBrowser1.StartLocation = FolderBrowserFolder.CommonPictures
                Case "Common Video"
                    folderBrowser1.StartLocation = FolderBrowserFolder.CommonVideo
                Case "Computers Near Me"
                    folderBrowser1.StartLocation = FolderBrowserFolder.ComputersNearMe
                Case "Control Panel"
                    folderBrowser1.StartLocation = FolderBrowserFolder.Controls
                Case "Desktop"
                    folderBrowser1.StartLocation = FolderBrowserFolder.Desktop
                Case "Desktop Directory"
                    folderBrowser1.StartLocation = FolderBrowserFolder.DesktopDirectory
                Case "Favorites"
                    folderBrowser1.StartLocation = FolderBrowserFolder.Favorites
                Case "Fonts"
                    folderBrowser1.StartLocation = FolderBrowserFolder.Fonts
                Case "Internet"
                    folderBrowser1.StartLocation = FolderBrowserFolder.Internet
                Case "My Computer"
                    folderBrowser1.StartLocation = FolderBrowserFolder.MyComputer
                Case "My Documents"
                    folderBrowser1.StartLocation = FolderBrowserFolder.MyDocuments
                Case "My Music"
                    folderBrowser1.StartLocation = FolderBrowserFolder.MyMusic
                Case "My Pictures"
                    folderBrowser1.StartLocation = FolderBrowserFolder.MyPictures
                Case "My Video"
                    folderBrowser1.StartLocation = FolderBrowserFolder.MyVideo
                Case "Net And DialUp Connections"
                    folderBrowser1.StartLocation = FolderBrowserFolder.NetAndDialUpConnections
                Case "Net Hood"
                    folderBrowser1.StartLocation = FolderBrowserFolder.NetHood
                Case "Network Neighborhood"
                    folderBrowser1.StartLocation = FolderBrowserFolder.NetworkNeighborhood
                Case "Personal"
                    folderBrowser1.StartLocation = FolderBrowserFolder.Personal
                Case "Printers"
                    folderBrowser1.StartLocation = FolderBrowserFolder.Printers
                Case "Programs"
                    folderBrowser1.StartLocation = FolderBrowserFolder.Programs
                Case "Recent"
                    folderBrowser1.StartLocation = FolderBrowserFolder.Recent
                Case "Resources"
                    folderBrowser1.StartLocation = FolderBrowserFolder.Resources
                Case "Send To"
                    folderBrowser1.StartLocation = FolderBrowserFolder.SendTo
                Case "Start Menu"
                    folderBrowser1.StartLocation = FolderBrowserFolder.StartMenu
                Case "Startup"
                    folderBrowser1.StartLocation = FolderBrowserFolder.Startup
                Case "Templates"
                    folderBrowser1.StartLocation = FolderBrowserFolder.Templates
            End Select
        End Sub
#End Region

        ' Event handler for the FolderBrowser.FolderBrowserCallback validation event.
        ' This handler is functionally equivalent of the Win32 BrowseCallbackProc callback function.
        Private Sub folderBrowser1_FolderBrowserCallback(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.FolderBrowserCallbackEventArgs) Handles folderBrowser1.FolderBrowserCallback
            Me.statusBar1.Text = String.Format("Event: {0}, Path: {1}", e.FolderBrowserMessage, e.Path)
            If e.FolderBrowserMessage = FolderBrowserMessage.ValidateFailed Then
                e.Dismiss = e.Path <> "NONE"
            End If
        End Sub

        Private Sub checkBox_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbRestrictToFilesystem.CheckedChanged, cbRestrictToDomain.CheckedChanged, cbRestrictToSubfolders.CheckedChanged, cbShowTextBox.CheckedChanged, cbValidate.CheckedChanged, cbNewDialogStyle.CheckedChanged, cbAllowUrls.CheckedChanged, cbBrowseForComputer.CheckedChanged, cbBrowseForPrinter.CheckedChanged, cbBrowseForEverything.CheckedChanged, cbShowShares.CheckedChanged
            Me.SetFolderBrowserStyles(CType(IIf(TypeOf sender Is CheckBox, sender, Nothing), CheckBox))
        End Sub

#Region "Apply FolderBrowserStyles"
        Private Sub SetFolderBrowserStyles(ByVal cbselected As CheckBox)
            Select Case cbselected.Text
                Case "Restrict To File System"
                    If cbselected.Checked = True Then
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style Or FolderBrowserStyles.RestrictToFilesystem
                    Else
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style And Not FolderBrowserStyles.RestrictToFilesystem
                    End If
                Case "Restrict To Domain"
                    If cbselected.Checked = True Then
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style Or FolderBrowserStyles.RestrictToDomain
                    Else
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style And Not FolderBrowserStyles.RestrictToDomain
                    End If
                Case "Restrict To Subfolders"
                    If cbselected.Checked = True Then
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style Or FolderBrowserStyles.RestrictToSubfolders
                    Else
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style And Not FolderBrowserStyles.RestrictToSubfolders
                    End If
                Case "Show TextBox"
                    If cbselected.Checked = True Then
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style Or FolderBrowserStyles.ShowTextBox
                    Else
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style And Not FolderBrowserStyles.ShowTextBox
                    End If
                Case "Validate"
                    If cbselected.Checked = True Then
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style Or FolderBrowserStyles.Validate
                    Else
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style And Not FolderBrowserStyles.Validate
                    End If
                Case "New Dialog Style"
                    If cbselected.Checked = True Then
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style Or FolderBrowserStyles.NewDialogStyle
                    Else
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style And Not FolderBrowserStyles.AllowUrls
                        Me.cbAllowUrls.Checked = False
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style And Not FolderBrowserStyles.ShowAdministrativeShares
                        Me.cbShowShares.Checked = False
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style And Not FolderBrowserStyles.NewDialogStyle

                    End If
                Case "Allow Urls"
                    If cbselected.Checked = True Then
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style Or FolderBrowserStyles.AllowUrls Or FolderBrowserStyles.NewDialogStyle
                        Me.cbNewDialogStyle.Checked = True
                    Else
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style And Not FolderBrowserStyles.AllowUrls
                    End If
                Case "Browse For Computer"
                    If cbselected.Checked = True Then
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style Or FolderBrowserStyles.BrowseForComputer
                    Else
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style And Not FolderBrowserStyles.BrowseForComputer
                    End If
                Case "Browse For Printer"
                    If cbselected.Checked = True Then
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style Or FolderBrowserStyles.BrowseForPrinter
                    Else
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style And Not FolderBrowserStyles.BrowseForPrinter
                    End If
                Case "Browse For Everything"
                    If cbselected.Checked = True Then
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style Or FolderBrowserStyles.BrowseForEverything
                    Else
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style And Not FolderBrowserStyles.BrowseForEverything
                    End If
                Case "Show Shares"
                    If cbselected.Checked = True Then
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style Or FolderBrowserStyles.ShowAdministrativeShares Or FolderBrowserStyles.NewDialogStyle
                        Me.cbNewDialogStyle.Checked = True
                    Else
                        Me.folderBrowser1.Style = Me.folderBrowser1.Style And Not FolderBrowserStyles.ShowAdministrativeShares
                    End If
            End Select
        End Sub
#End Region

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            textBox1.Text = String.Empty
            textBox1.Visible = checkBox1.Checked
            label2.Visible = checkBox1.Checked

            comboBox1.Enabled = Not checkBox1.Checked
            textBox1.Focus()
        End Sub
    End Class
End Namespace
