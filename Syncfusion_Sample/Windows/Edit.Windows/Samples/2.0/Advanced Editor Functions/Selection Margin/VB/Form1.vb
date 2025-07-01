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

Namespace SelectionMarginDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
		Private menuStrip1 As MenuStrip
		Private fileToolStripMenuItem As ToolStripMenuItem
		Private WithEvents nwToolStripMenuItem As ToolStripMenuItem
		Private WithEvents openToolStripMenuItem As ToolStripMenuItem
		Private toolStripSeparator1 As ToolStripSeparator
		Private WithEvents saveToolStripMenuItem As ToolStripMenuItem
		Private WithEvents saveAsToolStripMenuItem As ToolStripMenuItem
		Private toolStripSeparator2 As ToolStripSeparator
		Private WithEvents closeToolStripMenuItem As ToolStripMenuItem
		Private WithEvents exitToolStripMenuItem As ToolStripMenuItem
		Private selectionMarginToolStripMenuItem As ToolStripMenuItem
		Private WithEvents backgroundColorToolStripMenuItem As ToolStripMenuItem
		Private WithEvents foregroundColorItem As ToolStripMenuItem
		Private marginWidthToolStripMenuItem As ToolStripMenuItem
		Private changedLineMarkingToolStripMenuItem As ToolStripMenuItem
		Private WithEvents enableItItem As ToolStripMenuItem
		Private WithEvents changedLineColorItem As ToolStripMenuItem
		Private WithEvents savedLinesColorItem As ToolStripMenuItem
		Private colorDialog As ColorDialog
		Private WithEvents ChangeMarginCombo As ToolStripComboBox
		Private components As IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			Me.editControl1.SelectionMarginBackgroundColor = Color.LightBlue
			Me.editControl1.SelectionMarginForegroundColor = Color.Gray
            Me.editControl1.LoadFile("..\\..\\Test Files\\Form1.vb")
			Me.editControl1.MarkChangedLines = True
			Me.ChangeMarginCombo.SelectedIndex = 0
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
			Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
			Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.nwToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.saveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.saveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.closeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.selectionMarginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.backgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.foregroundColorItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.marginWidthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.ChangeMarginCombo = New System.Windows.Forms.ToolStripComboBox()
			Me.changedLineMarkingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.enableItItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.changedLineColorItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.savedLinesColorItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.colorDialog = New System.Windows.Forms.ColorDialog()
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.menuStrip1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' editControl1
			' 
			Me.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart
			Me.editControl1.BackColor = System.Drawing.SystemColors.Window
			Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.editControl1.Configurator = config1
			Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.editControl1.LineNumbersFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.editControl1.Location = New System.Drawing.Point(0, 24)
			Me.editControl1.Name = "editControl1"
			Me.editControl1.ShowHorizontalSplitters = False
			Me.editControl1.ShowIndicatorMargin = False
			Me.editControl1.ShowVerticalSplitters = False
			Me.editControl1.Size = New System.Drawing.Size(542, 421)
			Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
			Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
			Me.editControl1.TabIndex = 0
			Me.editControl1.Text = "editControl1"
			Me.editControl1.TransferFocusOnTab = True
			Me.editControl1.VisualColumn = 1
			Me.editControl1.WordWrap = True
			' 
			' menuStrip1
			' 
			Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.fileToolStripMenuItem, Me.selectionMarginToolStripMenuItem, Me.changedLineMarkingToolStripMenuItem})
			Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
			Me.menuStrip1.Name = "menuStrip1"
			Me.menuStrip1.Size = New System.Drawing.Size(542, 24)
			Me.menuStrip1.TabIndex = 1
			Me.menuStrip1.Text = "menuStrip1"
			' 
			' fileToolStripMenuItem
			' 
			Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.nwToolStripMenuItem, Me.openToolStripMenuItem, Me.toolStripSeparator1, Me.saveToolStripMenuItem, Me.saveAsToolStripMenuItem, Me.toolStripSeparator2, Me.closeToolStripMenuItem, Me.exitToolStripMenuItem})
			Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
			Me.fileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
			Me.fileToolStripMenuItem.Text = "File"
			' 
			' nwToolStripMenuItem
			' 
			Me.nwToolStripMenuItem.Name = "nwToolStripMenuItem"
			Me.nwToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.nwToolStripMenuItem.Text = "New"
'			Me.nwToolStripMenuItem.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' openToolStripMenuItem
			' 
			Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
			Me.openToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.openToolStripMenuItem.Text = "Open..."
'			Me.openToolStripMenuItem.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New System.Drawing.Size(149, 6)
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
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New System.Drawing.Size(149, 6)
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
			' selectionMarginToolStripMenuItem
			' 
			Me.selectionMarginToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.backgroundColorToolStripMenuItem, Me.foregroundColorItem, Me.marginWidthToolStripMenuItem})
			Me.selectionMarginToolStripMenuItem.Name = "selectionMarginToolStripMenuItem"
			Me.selectionMarginToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
			Me.selectionMarginToolStripMenuItem.Text = "Selection Margin"
			' 
			' backgroundColorToolStripMenuItem
			' 
			Me.backgroundColorToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
			Me.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem"
			Me.backgroundColorToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
			Me.backgroundColorToolStripMenuItem.Text = "Background Color..."
'			Me.backgroundColorToolStripMenuItem.Click += New System.EventHandler(Me.SetBackgroundColor);
			' 
			' foregroundColorItem
			' 
			Me.foregroundColorItem.Name = "foregroundColorItem"
			Me.foregroundColorItem.Size = New System.Drawing.Size(181, 22)
			Me.foregroundColorItem.Text = "Foreground Color..."
'			Me.foregroundColorItem.Click += New System.EventHandler(Me.SetForegroundColor);
			' 
			' marginWidthToolStripMenuItem
			' 
			Me.marginWidthToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.ChangeMarginCombo})
			Me.marginWidthToolStripMenuItem.Name = "marginWidthToolStripMenuItem"
			Me.marginWidthToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
			Me.marginWidthToolStripMenuItem.Text = "Margin Width"
			' 
			' ChangeMarginCombo
			' 
			Me.ChangeMarginCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ChangeMarginCombo.Items.AddRange(New Object() { "Default", "25", "50", "75", "100", "125"})
			Me.ChangeMarginCombo.Name = "ChangeMarginCombo"
			Me.ChangeMarginCombo.Size = New System.Drawing.Size(121, 21)
'			Me.ChangeMarginCombo.SelectedIndexChanged += New System.EventHandler(Me.MarginWidthChanged);
			' 
			' changedLineMarkingToolStripMenuItem
			' 
			Me.changedLineMarkingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.enableItItem, Me.changedLineColorItem, Me.savedLinesColorItem})
			Me.changedLineMarkingToolStripMenuItem.Name = "changedLineMarkingToolStripMenuItem"
			Me.changedLineMarkingToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
			Me.changedLineMarkingToolStripMenuItem.Text = "Changed Line Marking"
			' 
			' enableItItem
			' 
			Me.enableItItem.Checked = True
			Me.enableItItem.CheckOnClick = True
			Me.enableItItem.CheckState = System.Windows.Forms.CheckState.Checked
			Me.enableItItem.Name = "enableItItem"
			Me.enableItItem.Size = New System.Drawing.Size(190, 22)
			Me.enableItItem.Text = "Enable it!"
'			Me.enableItItem.Click += New System.EventHandler(Me.ChangedLineMarkingMenu_Click);
			' 
			' changedLineColorItem
			' 
			Me.changedLineColorItem.ForeColor = System.Drawing.SystemColors.ControlText
			Me.changedLineColorItem.Name = "changedLineColorItem"
			Me.changedLineColorItem.Size = New System.Drawing.Size(190, 22)
			Me.changedLineColorItem.Text = "Changed lines color..."
'			Me.changedLineColorItem.Click += New System.EventHandler(Me.ChangedLinesColor);
			' 
			' savedLinesColorItem
			' 
			Me.savedLinesColorItem.Name = "savedLinesColorItem"
			Me.savedLinesColorItem.Size = New System.Drawing.Size(190, 22)
			Me.savedLinesColorItem.Text = "Saved lines color..."
'			Me.savedLinesColorItem.Click += New System.EventHandler(Me.SavedLinesColor);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(542, 445)
			Me.Controls.Add(Me.editControl1)
			Me.Controls.Add(Me.menuStrip1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MainMenuStrip = Me.menuStrip1
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Selection Margin"
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.menuStrip1.ResumeLayout(False)
			Me.menuStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub

		Private Sub ChangedLineMarkingMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles enableItItem.Click
			Me.editControl1.MarkChangedLines = enableItItem.Checked
		End Sub

		Private Sub SetBackgroundColor(ByVal sender As Object, ByVal e As EventArgs) Handles backgroundColorToolStripMenuItem.Click
			If colorDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				editControl1.SelectionMarginBackgroundColor = colorDialog.Color
backgroundColorToolStripMenuItem.ForeColor = colorDialog.Color
			End If
		End Sub

		Private Sub SetForegroundColor(ByVal sender As Object, ByVal e As EventArgs) Handles foregroundColorItem.Click
			If colorDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				editControl1.SelectionMarginForegroundColor = colorDialog.Color
				foregroundColorItem.ForeColor = colorDialog.Color
			End If
		End Sub

		Private Sub MarginWidthChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ChangeMarginCombo.SelectedIndexChanged
			Select Case TryCast(ChangeMarginCombo.SelectedItem, String)
				Case "Default"
					Me.editControl1.SelectionMarginWidth = 5
				Case "25"
					Me.editControl1.SelectionMarginWidth = 25
				Case "50"
					Me.editControl1.SelectionMarginWidth = 50
				Case "75"
					Me.editControl1.SelectionMarginWidth = 75
				Case "100"
					Me.editControl1.SelectionMarginWidth = 100
				Case "125"
					Me.editControl1.SelectionMarginWidth = 125
			End Select
		End Sub

		Private Sub ChangedLinesColor(ByVal sender As Object, ByVal e As EventArgs) Handles changedLineColorItem.Click
			If colorDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				editControl1.ChangedLinesMarkingLineColor = colorDialog.Color
				changedLineColorItem.ForeColor = colorDialog.Color
			End If
		End Sub

		Private Sub SavedLinesColor(ByVal sender As Object, ByVal e As EventArgs) Handles savedLinesColorItem.Click
			If colorDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				editControl1.SavedLinesMarkingLineColor = colorDialog.Color
				savedLinesColorItem.ForeColor = colorDialog.Color
			End If
		End Sub

		Private Sub MainMenuClick(ByVal sender As Object, ByVal e As EventArgs) Handles nwToolStripMenuItem.Click, openToolStripMenuItem.Click, saveToolStripMenuItem.Click, saveAsToolStripMenuItem.Click, closeToolStripMenuItem.Click, exitToolStripMenuItem.Click
			Dim item As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
			Select Case item.Text
				Case "New"
					editControl1.NewFile()
				Case "Open..."
					editControl1.LoadFile()
				Case "Save"
					editControl1.Save()
				Case "Save As..."
					editControl1.SaveAs()
				Case "Close"
					editControl1.Close()
				Case "Exit"
					Close()
			End Select
		End Sub
	End Class
End Namespace
