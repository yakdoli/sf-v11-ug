#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region


Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO

Imports Syncfusion.Windows.Forms.Edit
Imports Syncfusion.Windows.Forms.Edit.Dialogs
Imports Syncfusion.Windows.Forms.Edit.Implementation
Imports Syncfusion.Windows.Forms.Edit.Interfaces
Imports Syncfusion.Windows.Forms.Edit.Enums


Namespace StatusBarDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
		Private components As IContainer
		Private WithEvents toolStrip1 As ToolStrip
		Private toolStripLabel1 As ToolStripLabel
		Private toolStripButton1 As ToolStripButton
		Private toolStripButton2 As ToolStripButton
		Private toolStripButton3 As ToolStripButton
		Private toolStripButton4 As ToolStripButton
		Private toolStripButton5 As ToolStripButton
		Private toolStripButton6 As ToolStripButton
		Private toolStripButton7 As ToolStripButton
		Private toolStripSeparator1 As ToolStripSeparator
		Private toolStripSeparator2 As ToolStripSeparator
		Private toolStripSeparator3 As ToolStripSeparator
		Private toolStripSeparator4 As ToolStripSeparator
		Private toolStripSeparator5 As ToolStripSeparator
		Private menuStrip1 As MenuStrip
		Private fielToolStripMenuItem As ToolStripMenuItem
		Private WithEvents newToolStripMenuItem As ToolStripMenuItem
		Private WithEvents openToolStripMenuItem As ToolStripMenuItem
		Private toolStripSeparator6 As ToolStripSeparator
		Private WithEvents saveToolStripMenuItem As ToolStripMenuItem
		Private WithEvents saveAsToolStripMenuItem As ToolStripMenuItem
		Private toolStripSeparator7 As ToolStripSeparator
		Private WithEvents closeToolStripMenuItem As ToolStripMenuItem
		Private WithEvents exitToolStripMenuItem As ToolStripMenuItem
		Private toolStripSeparator8 As ToolStripSeparator
		Private setTextToolStripMenuItem As ToolStripMenuItem
		Private WithEvents textPanelToolStripMenuItem As ToolStripMenuItem
		Private WithEvents fileNamePanelToolStripMenuItem As ToolStripMenuItem
		Private WithEvents statusPanelToolStripMenuItem As ToolStripMenuItem
		Private WithEvents encodngPanelToolStripMenuItem As ToolStripMenuItem
		Private WithEvents positToolStripMenuItem As ToolStripMenuItem
		Private WithEvents insertPanelToolStripMenuItem As ToolStripMenuItem

        Private filePath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\Form1.vb"

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			Me.editControl1.LoadFile(filePath)

			Me.editControl1.StatusBarSettings.TextPanel.Panel.Text = filePath
			Me.editControl1.StatusBarSettings.StatusPanel.Panel.Text = "Status Bar Demo"
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim config1 As Syncfusion.Windows.Forms.Edit.Implementation.Config.Config = New Syncfusion.Windows.Forms.Edit.Implementation.Config.Config()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
			Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
			Me.toolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
			Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton6 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton7 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
			Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
			Me.fielToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
			Me.saveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.saveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
			Me.closeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
			Me.setTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.textPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.fileNamePanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.statusPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.encodngPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.positToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.insertPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolStrip1.SuspendLayout()
			Me.menuStrip1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' editControl1
			' 
			Me.editControl1.BackColor = System.Drawing.SystemColors.Window
			Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.editControl1.Configurator = config1
			Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.editControl1.LineNumbersFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.editControl1.Location = New System.Drawing.Point(0, 49)
			Me.editControl1.Name = "editControl1"
			Me.editControl1.ShowHorizontalSplitters = False
			Me.editControl1.ShowIndicatorMargin = False
			Me.editControl1.ShowSelectionMargin = False
			Me.editControl1.ShowVerticalSplitters = False
			Me.editControl1.Size = New System.Drawing.Size(542, 396)
			Me.editControl1.StatusBarSettings.CoordsPanel.MinWidth = 10
			Me.editControl1.StatusBarSettings.GripVisibility = Syncfusion.Windows.Forms.Edit.Enums.SizingGripVisibility.Visible
			Me.editControl1.StatusBarSettings.InsertPanel.MinWidth = 10
			Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
			Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
			Me.editControl1.StatusBarSettings.TextPanel.MinWidth = 10
			Me.editControl1.StatusBarSettings.Visible = True
			Me.editControl1.TabIndex = 0
			Me.editControl1.Text = ""
			Me.editControl1.TransferFocusOnTab = True
			Me.editControl1.VisualColumn = 1
			Me.editControl1.WordWrap = True
			' 
			' toolStrip1
			' 
			Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripLabel1, Me.toolStripButton1, Me.toolStripSeparator1, Me.toolStripButton2, Me.toolStripSeparator2, Me.toolStripButton3, Me.toolStripSeparator3, Me.toolStripButton4, Me.toolStripSeparator4, Me.toolStripButton5, Me.toolStripSeparator5, Me.toolStripButton6, Me.toolStripSeparator8, Me.toolStripButton7})
			Me.toolStrip1.Location = New System.Drawing.Point(0, 24)
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.Size = New System.Drawing.Size(542, 25)
			Me.toolStrip1.TabIndex = 1
			Me.toolStrip1.Text = "toolStrip1"
'			Me.toolStrip1.ItemClicked += New System.Windows.Forms.ToolStripItemClickedEventHandler(Me.VisibilityMenuClick);
			' 
			' toolStripLabel1
			' 
			Me.toolStripLabel1.Name = "toolStripLabel1"
			Me.toolStripLabel1.Size = New System.Drawing.Size(95, 22)
			Me.toolStripLabel1.Text = "Status Bar Panels:"
			' 
			' toolStripButton1
			' 
			Me.toolStripButton1.Checked = True
			Me.toolStripButton1.CheckState = System.Windows.Forms.CheckState.Checked
			Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton1.Image = (CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image))
			Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton1.Name = "toolStripButton1"
			Me.toolStripButton1.Size = New System.Drawing.Size(33, 22)
			Me.toolStripButton1.Text = "Text"
			' 
			' toolStripButton2
			' 
			Me.toolStripButton2.Checked = True
			Me.toolStripButton2.CheckState = System.Windows.Forms.CheckState.Checked
			Me.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton2.Image = (CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image))
			Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton2.Name = "toolStripButton2"
			Me.toolStripButton2.Size = New System.Drawing.Size(54, 22)
			Me.toolStripButton2.Text = "FileName"
			' 
			' toolStripButton3
			' 
			Me.toolStripButton3.Checked = True
			Me.toolStripButton3.CheckState = System.Windows.Forms.CheckState.Checked
			Me.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton3.Image = (CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image))
			Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton3.Name = "toolStripButton3"
			Me.toolStripButton3.Size = New System.Drawing.Size(42, 22)
			Me.toolStripButton3.Text = "Status"
			' 
			' toolStripButton4
			' 
			Me.toolStripButton4.Checked = True
			Me.toolStripButton4.CheckState = System.Windows.Forms.CheckState.Checked
			Me.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton4.Image = (CType(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image))
			Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton4.Name = "toolStripButton4"
			Me.toolStripButton4.Size = New System.Drawing.Size(54, 22)
			Me.toolStripButton4.Text = "Encoding"
			' 
			' toolStripButton5
			' 
			Me.toolStripButton5.Checked = True
			Me.toolStripButton5.CheckState = System.Windows.Forms.CheckState.Checked
			Me.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton5.Image = (CType(resources.GetObject("toolStripButton5.Image"), System.Drawing.Image))
			Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton5.Name = "toolStripButton5"
			Me.toolStripButton5.Size = New System.Drawing.Size(48, 22)
			Me.toolStripButton5.Text = "Position"
			' 
			' toolStripButton6
			' 
			Me.toolStripButton6.Checked = True
			Me.toolStripButton6.CheckState = System.Windows.Forms.CheckState.Checked
			Me.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton6.Image = (CType(resources.GetObject("toolStripButton6.Image"), System.Drawing.Image))
			Me.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton6.Name = "toolStripButton6"
			Me.toolStripButton6.Size = New System.Drawing.Size(40, 22)
			Me.toolStripButton6.Text = "Insert"
			' 
			' toolStripButton7
			' 
			Me.toolStripButton7.Checked = True
			Me.toolStripButton7.CheckState = System.Windows.Forms.CheckState.Checked
			Me.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton7.Image = (CType(resources.GetObject("toolStripButton7.Image"), System.Drawing.Image))
			Me.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton7.Name = "toolStripButton7"
			Me.toolStripButton7.Size = New System.Drawing.Size(75, 22)
			Me.toolStripButton7.Text = "Sizing gripper"
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
			' 
			' toolStripSeparator3
			' 
			Me.toolStripSeparator3.Name = "toolStripSeparator3"
			Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
			' 
			' toolStripSeparator4
			' 
			Me.toolStripSeparator4.Name = "toolStripSeparator4"
			Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 25)
			' 
			' toolStripSeparator5
			' 
			Me.toolStripSeparator5.Name = "toolStripSeparator5"
			Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 25)
			' 
			' menuStrip1
			' 
			Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.fielToolStripMenuItem, Me.setTextToolStripMenuItem})
			Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
			Me.menuStrip1.Name = "menuStrip1"
			Me.menuStrip1.Size = New System.Drawing.Size(542, 24)
			Me.menuStrip1.TabIndex = 2
			Me.menuStrip1.Text = "menuStrip1"
			' 
			' fielToolStripMenuItem
			' 
			Me.fielToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.newToolStripMenuItem, Me.openToolStripMenuItem, Me.toolStripSeparator6, Me.saveToolStripMenuItem, Me.saveAsToolStripMenuItem, Me.toolStripSeparator7, Me.closeToolStripMenuItem, Me.exitToolStripMenuItem})
			Me.fielToolStripMenuItem.Name = "fielToolStripMenuItem"
			Me.fielToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
			Me.fielToolStripMenuItem.Text = "File"
			' 
			' newToolStripMenuItem
			' 
			Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
			Me.newToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.newToolStripMenuItem.Text = "New"
'			Me.newToolStripMenuItem.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' openToolStripMenuItem
			' 
			Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
			Me.openToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.openToolStripMenuItem.Text = "Open..."
'			Me.openToolStripMenuItem.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' toolStripSeparator6
			' 
			Me.toolStripSeparator6.Name = "toolStripSeparator6"
			Me.toolStripSeparator6.Size = New System.Drawing.Size(149, 6)
			' 
			' saveToolStripMenuItem
			' 
			Me.saveToolStripMenuItem.Name = "saveToolStripMenuItem"
			Me.saveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.saveToolStripMenuItem.Text = "Save"
'			Me.saveToolStripMenuItem.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' saveAsToolStripMenuItem
			' 
			Me.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem"
			Me.saveAsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.saveAsToolStripMenuItem.Text = "Save As..."
'			Me.saveAsToolStripMenuItem.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' toolStripSeparator7
			' 
			Me.toolStripSeparator7.Name = "toolStripSeparator7"
			Me.toolStripSeparator7.Size = New System.Drawing.Size(149, 6)
			' 
			' closeToolStripMenuItem
			' 
			Me.closeToolStripMenuItem.Name = "closeToolStripMenuItem"
			Me.closeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.closeToolStripMenuItem.Text = "Close"
'			Me.closeToolStripMenuItem.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' exitToolStripMenuItem
			' 
			Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
			Me.exitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.exitToolStripMenuItem.Text = "Exit"
'			Me.exitToolStripMenuItem.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' toolStripSeparator8
			' 
			Me.toolStripSeparator8.Name = "toolStripSeparator8"
			Me.toolStripSeparator8.Size = New System.Drawing.Size(6, 25)
			' 
			' setTextToolStripMenuItem
			' 
			Me.setTextToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.textPanelToolStripMenuItem, Me.fileNamePanelToolStripMenuItem, Me.statusPanelToolStripMenuItem, Me.encodngPanelToolStripMenuItem, Me.positToolStripMenuItem, Me.insertPanelToolStripMenuItem})
			Me.setTextToolStripMenuItem.Name = "setTextToolStripMenuItem"
			Me.setTextToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
			Me.setTextToolStripMenuItem.Text = "Set Text "
			' 
			' textPanelToolStripMenuItem
			' 
			Me.textPanelToolStripMenuItem.Name = "textPanelToolStripMenuItem"
			Me.textPanelToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
			Me.textPanelToolStripMenuItem.Text = "Text Panel"
'			Me.textPanelToolStripMenuItem.Click += New System.EventHandler(Me.SetTextMenuClick);
			' 
			' fileNamePanelToolStripMenuItem
			' 
			Me.fileNamePanelToolStripMenuItem.Name = "fileNamePanelToolStripMenuItem"
			Me.fileNamePanelToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
			Me.fileNamePanelToolStripMenuItem.Text = "FileName Panel"
'			Me.fileNamePanelToolStripMenuItem.Click += New System.EventHandler(Me.SetTextMenuClick);
			' 
			' statusPanelToolStripMenuItem
			' 
			Me.statusPanelToolStripMenuItem.Name = "statusPanelToolStripMenuItem"
			Me.statusPanelToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
			Me.statusPanelToolStripMenuItem.Text = "Status Panel"
'			Me.statusPanelToolStripMenuItem.Click += New System.EventHandler(Me.SetTextMenuClick);
			' 
			' encodngPanelToolStripMenuItem
			' 
			Me.encodngPanelToolStripMenuItem.Name = "encodngPanelToolStripMenuItem"
			Me.encodngPanelToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
			Me.encodngPanelToolStripMenuItem.Text = "Encoding Panel"
'			Me.encodngPanelToolStripMenuItem.Click += New System.EventHandler(Me.SetTextMenuClick);
			' 
			' positToolStripMenuItem
			' 
			Me.positToolStripMenuItem.Name = "positToolStripMenuItem"
			Me.positToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
			Me.positToolStripMenuItem.Text = "Position Panel"
'			Me.positToolStripMenuItem.Click += New System.EventHandler(Me.SetTextMenuClick);
			' 
			' insertPanelToolStripMenuItem
			' 
			Me.insertPanelToolStripMenuItem.Name = "insertPanelToolStripMenuItem"
			Me.insertPanelToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
			Me.insertPanelToolStripMenuItem.Text = "Insert Panel"
'			Me.insertPanelToolStripMenuItem.Click += New System.EventHandler(Me.SetTextMenuClick);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(542, 445)
			Me.Controls.Add(Me.editControl1)
			Me.Controls.Add(Me.toolStrip1)
			Me.Controls.Add(Me.menuStrip1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MainMenuStrip = Me.menuStrip1
			Me.Name = "Form1"
			Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Status Bar Demo"
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.menuStrip1.ResumeLayout(False)
			Me.menuStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New Form1())
        End Sub

		Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles newToolStripMenuItem.Click, openToolStripMenuItem.Click, saveToolStripMenuItem.Click, saveAsToolStripMenuItem.Click, closeToolStripMenuItem.Click, exitToolStripMenuItem.Click
			Dim mi As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)

			Select Case mi.Text
				Case "New" 
					Me.editControl1.NewFile()
				Case "Open..." 
					Me.editControl1.LoadFile()
				Case "Save" 
					Me.editControl1.Save()
				Case "Save As..." 
					Me.editControl1.SaveAs()
				Case "Close" 
					Me.editControl1.Close()
				Case "Exit" 
					Me.Close()
			End Select
		End Sub

		Private Sub SetTextMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles textPanelToolStripMenuItem.Click, fileNamePanelToolStripMenuItem.Click, statusPanelToolStripMenuItem.Click, encodngPanelToolStripMenuItem.Click, positToolStripMenuItem.Click, insertPanelToolStripMenuItem.Click
			Dim dialog As TextInputDialog = New TextInputDialog()
			AddHandler dialog.TextAccepted, AddressOf TextInputDialog_TextAccepted
			dialog.ShowDialog()

			If Me.inputText <> "" Then
				Dim mi As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)

				Select Case mi.Text
					Case "Text Panel" 
						Me.editControl1.StatusBarSettings.TextPanel.Panel.Text = Me.inputText
					Case "FileName Panel" 
						Me.editControl1.StatusBarSettings.FileNamePanel.Panel.Text = Me.inputText
					Case "Status Panel" 
						Me.editControl1.StatusBarSettings.StatusPanel.Panel.Text = Me.inputText
					Case "Encoding Panel" 
						Me.editControl1.StatusBarSettings.EncodingPanel.Panel.Text = Me.inputText
					Case "Position Panel" 
						Me.editControl1.StatusBarSettings.CoordsPanel.Panel.Text = Me.inputText
					Case "Insert Panel" 
						Me.editControl1.StatusBarSettings.InsertPanel.Panel.Text = Me.inputText
				End Select
			End If
		End Sub

		Private inputText As String =""
		Private Sub TextInputDialog_TextAccepted(ByVal sender As Object, ByVal e As EventArgs)
			Dim dialog As TextInputDialog = TryCast(sender, TextInputDialog)
			Me.inputText = dialog.InputText
		End Sub

		Private Sub VisibilityMenuClick(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs) Handles toolStrip1.ItemClicked
			Dim mi As ToolStripItem = CType(e.ClickedItem, ToolStripItem)

			Select Case mi.Text
				Case "Text"
					toolStripButton1.Checked = Not toolStripButton1.Checked
					Me.editControl1.StatusBarSettings.TextPanel.Visible = toolStripButton1.Checked
				Case "FileName"
					toolStripButton2.Checked = Not toolStripButton2.Checked
					Me.editControl1.StatusBarSettings.FileNamePanel.Visible = toolStripButton2.Checked
				Case "Status"
					toolStripButton3.Checked = Not toolStripButton3.Checked
					Me.editControl1.StatusBarSettings.StatusPanel.Visible = toolStripButton3.Checked
				Case "Encoding"
					toolStripButton4.Checked = Not toolStripButton4.Checked
					Me.editControl1.StatusBarSettings.EncodingPanel.Visible = toolStripButton4.Checked
				Case "Position"
					toolStripButton5.Checked = Not toolStripButton5.Checked
					Me.editControl1.StatusBarSettings.CoordsPanel.Visible = toolStripButton5.Checked
				Case "Insert"
					toolStripButton6.Checked = Not toolStripButton6.Checked
					Me.editControl1.StatusBarSettings.InsertPanel.Visible = toolStripButton6.Checked
				Case "Sizing gripper"
					Me.toolStripButton7.Checked = Not Me.toolStripButton7.Checked
					If Me.toolStripButton7.Checked Then
						Me.editControl1.StatusBarSettings.GripVisibility = SizingGripVisibility.Visible
					Else
						Me.editControl1.StatusBarSettings.GripVisibility = SizingGripVisibility.Hidden
					End If
			End Select
		End Sub
	End Class
End Namespace
