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
Imports System.Diagnostics
Imports System.Runtime.InteropServices

Imports Syncfusion.Windows.Forms.Edit
Imports Syncfusion.Windows.Forms.Edit.Utils
Imports Syncfusion.Windows.Forms.Edit.Dialogs
Imports Syncfusion.Windows.Forms.Edit.Implementation.Config
Imports Syncfusion.Windows.Forms.Edit.Interfaces
Imports Syncfusion.Windows.Forms.Edit.Implementation.IO
Imports Syncfusion.Windows.Forms.Edit.Implementation.Formatting
Imports Syncfusion.Windows.Forms.Edit.Implementation.Parser
Imports Syncfusion.IO
Imports Syncfusion.Drawing

Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports Syncfusion.Windows.Forms.Edit.Implementation
Imports Syncfusion.Windows.Forms.Edit.Enums

Namespace EditFeaturesDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private edtProperties As System.Windows.Forms.PropertyGrid
		Private components As IContainer
		Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
		Private MainStrip As MenuStrip
		Private fileToolStripMenuItem As ToolStripMenuItem
		Private WithEvents newToolStripMenuItem As ToolStripMenuItem
		Private WithEvents optnToolStripMenuItem As ToolStripMenuItem
		Private toolStripSeparator1 As ToolStripSeparator
		Private WithEvents saveToolStripMenuItem As ToolStripMenuItem
		Private WithEvents saveAsToolStripMenuItem As ToolStripMenuItem
		Private toolStripSeparator2 As ToolStripSeparator
		Private WithEvents closeToolStripMenuItem As ToolStripMenuItem
		Private WithEvents exitToolStripMenuItem As ToolStripMenuItem
		Private WithEvents featuresStrip1 As ToolStrip
		Private toolStripButton1 As ToolStripButton
		Private indentationBtn As ToolStripButton
		Private toolStripButton3 As ToolStripButton
		Private toolStripButton4 As ToolStripButton
		Private toolStripButton5 As ToolStripButton
		Private scrollbarBtn As ToolStripButton
		Private toolStripButton7 As ToolStripButton
		Private WithEvents propertyGridItem As ToolStripMenuItem
		Private WithEvents featuresStrip2 As ToolStrip
		Private splittersBtn As ToolStripButton
		Private statusBarBtn As ToolStripButton
		Private toolStripButton10 As ToolStripButton
		Private toolStripButton11 As ToolStripButton
		Private toolStripButton12 As ToolStripButton
		Private wordwrapbtnItem As ToolStripButton
		Private toolStripSeparator3 As ToolStripSeparator
		Private toolStripButton14 As ToolStripButton
		Private toolStripButton15 As ToolStripButton
		Private toolStripSeparator5 As ToolStripSeparator
		Private toolStripSeparator4 As ToolStripSeparator
		Private filePath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\Test Files\CSharpSource.cs"

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			Me.editControl1.UserMarginBackgroundColor = New BrushInfo(GradientStyle.ForwardDiagonal, Color.Beige, Color.Orange)
			Me.editControl1.ShowUserMargin = False
			'this.usermarginItem.Checked = false;

			Me.edtProperties.Visible = False
			'this.propertiesgridItem.Checked = false;

			Me.editControl1.ShowWhitespaces = False
			'this.whitespacesItem.Checked = false;

			Me.editControl1.ShowUserMargin = False
			'this.usermarginItem.Checked = false;

			Me.editControl1.StatusBarSettings.Visible = True
			'this.statusbarItem.Checked = true;

			Me.editControl1.ShowHorizontalScroller = True
			Me.editControl1.ShowVerticalScroller = True
			Me.scrollbarBtn.Checked = True

			Me.editControl1.ShowHorizontalSplitters = True
			Me.editControl1.ShowVerticalSplitters = True
			Me.splittersBtn.Checked = True

			Me.editControl1.ShowLineNumbers = True
			'this.linenumberItem.Checked = true;

			Me.editControl1.ShowIndicatorMargin = True
			Me.editControl1.MarkerAreaWidth = 20
			'this.indicatorItem.Checked = true;

			Me.editControl1.ShowOutliningCollapsers = True
			'this.outliningItem.Checked = true;

			Me.editControl1.ShowIndentationGuidelines = True
			Me.indentationBtn.Checked = True

			Me.editControl1.ShowSelectionMargin = False
			Me.editControl1.SelectionMarginWidth = 25
			Me.editControl1.SelectionMarginBackgroundColor = Color.IndianRed
			Me.editControl1.SelectionMarginForegroundColor = Color.DarkGray
			'this.selectionmarginItem.Checked = false;

			Me.editControl1.StatusBarSettings.Visible = True
			Me.editControl1.StatusBarSettings.TextPanel.Visible = True
			Me.editControl1.StatusBarSettings.StatusPanel.Visible = True
			Me.editControl1.StatusBarSettings.EncodingPanel.Visible = True
			Me.editControl1.StatusBarSettings.CoordsPanel.Visible = True
			Me.editControl1.StatusBarSettings.InsertPanel.Visible = True
			Me.editControl1.StatusBarSettings.TextPanel.Panel.Text = filePath
			Me.editControl1.StatusBarSettings.StatusPanel.Panel.Text = "Edit Features"
			Me.editControl1.StatusBarSettings.EncodingPanel.Panel.Text = "Parsing Mode : " & Me.editControl1.ParsingMode.ToString()
			Me.editControl1.StatusBarSettings.CoordsPanel.Panel.Text = Control.MousePosition.ToString()
			If Me.editControl1.InsertMode = True Then
				Me.editControl1.StatusBarSettings.InsertPanel.Panel.Text = "Insert Key : " & ("ON")
			Else
				Me.editControl1.StatusBarSettings.InsertPanel.Panel.Text = "Insert Key : " & ("OFF")
			End If
			Me.statusBarBtn.Checked = True

			Me.editControl1.LoadFile(filePath)

			Me.Size = New Size(664,500)
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
			Dim config2 As Syncfusion.Windows.Forms.Edit.Implementation.Config.Config = New Syncfusion.Windows.Forms.Edit.Implementation.Config.Config()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.edtProperties = New System.Windows.Forms.PropertyGrid()
			Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
			Me.MainStrip = New System.Windows.Forms.MenuStrip()
			Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.optnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.saveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.saveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.closeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.featuresStrip1 = New System.Windows.Forms.ToolStrip()
			Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
			Me.indentationBtn = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton()
			Me.scrollbarBtn = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton7 = New System.Windows.Forms.ToolStripButton()
			Me.propertyGridItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.featuresStrip2 = New System.Windows.Forms.ToolStrip()
			Me.splittersBtn = New System.Windows.Forms.ToolStripButton()
			Me.statusBarBtn = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton10 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton11 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton12 = New System.Windows.Forms.ToolStripButton()
			Me.wordwrapbtnItem = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripButton14 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton15 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.MainStrip.SuspendLayout()
			Me.featuresStrip1.SuspendLayout()
			Me.featuresStrip2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' edtProperties
			' 
			Me.edtProperties.CommandsBackColor = System.Drawing.SystemColors.Window
			Me.edtProperties.Dock = System.Windows.Forms.DockStyle.Right
			Me.edtProperties.LineColor = System.Drawing.SystemColors.ScrollBar
			Me.edtProperties.Location = New System.Drawing.Point(584, 74)
			Me.edtProperties.Name = "edtProperties"
			Me.edtProperties.SelectedObject = Me.editControl1
			Me.edtProperties.Size = New System.Drawing.Size(232, 392)
			Me.edtProperties.TabIndex = 25
			Me.edtProperties.Visible = False
			' 
			' editControl1
			' 
			Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.editControl1.Configurator = config2
			Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.editControl1.LineNumbersFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.editControl1.Location = New System.Drawing.Point(0, 74)
			Me.editControl1.Name = "editControl1"
			Me.editControl1.SharedFileMode = True
			Me.editControl1.Size = New System.Drawing.Size(584, 392)
			Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
			Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
			Me.editControl1.TabIndex = 27
			Me.editControl1.Text = ""
			Me.editControl1.VisualColumn = 1
			' 
			' MainStrip
			' 
			Me.MainStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.fileToolStripMenuItem, Me.propertyGridItem})
			Me.MainStrip.Location = New System.Drawing.Point(0, 0)
			Me.MainStrip.Name = "MainStrip"
			Me.MainStrip.Size = New System.Drawing.Size(816, 24)
			Me.MainStrip.TabIndex = 28
			Me.MainStrip.Text = "menuStrip1"
			' 
			' fileToolStripMenuItem
			' 
			Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.newToolStripMenuItem, Me.optnToolStripMenuItem, Me.toolStripSeparator1, Me.saveToolStripMenuItem, Me.saveAsToolStripMenuItem, Me.toolStripSeparator2, Me.closeToolStripMenuItem, Me.exitToolStripMenuItem})
			Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
			Me.fileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
			Me.fileToolStripMenuItem.Text = "File"
			' 
			' newToolStripMenuItem
			' 
			Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
			Me.newToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.newToolStripMenuItem.Text = "New"
'			Me.newToolStripMenuItem.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' optnToolStripMenuItem
			' 
			Me.optnToolStripMenuItem.Name = "optnToolStripMenuItem"
			Me.optnToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.optnToolStripMenuItem.Text = "Open..."
'			Me.optnToolStripMenuItem.Click += New System.EventHandler(Me.MainMenuClick);
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
			' featuresStrip1
			' 
			Me.featuresStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton1, Me.indentationBtn, Me.toolStripButton3, Me.toolStripSeparator5, Me.toolStripButton4, Me.toolStripButton5, Me.scrollbarBtn, Me.toolStripButton7})
			Me.featuresStrip1.Location = New System.Drawing.Point(0, 24)
			Me.featuresStrip1.Name = "featuresStrip1"
			Me.featuresStrip1.Size = New System.Drawing.Size(816, 25)
			Me.featuresStrip1.TabIndex = 29
			Me.featuresStrip1.Text = "ToolStrip"
'			Me.featuresStrip1.ItemClicked += New System.Windows.Forms.ToolStripItemClickedEventHandler(Me.toolStrip1_ItemClicked);
			' 
			' toolStripButton1
			' 
			Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton1.Image = (CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image))
			Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton1.Name = "toolStripButton1"
			Me.toolStripButton1.Size = New System.Drawing.Size(57, 22)
			Me.toolStripButton1.Text = "Bookmark"
			' 
			' indentationBtn
			' 
			Me.indentationBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.indentationBtn.Image = (CType(resources.GetObject("indentationBtn.Image"), System.Drawing.Image))
			Me.indentationBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.indentationBtn.Name = "indentationBtn"
			Me.indentationBtn.Size = New System.Drawing.Size(118, 22)
			Me.indentationBtn.Text = "Indentation Guidelines"
			' 
			' toolStripButton3
			' 
			Me.toolStripButton3.Checked = True
			Me.toolStripButton3.CheckState = System.Windows.Forms.CheckState.Checked
			Me.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton3.Image = (CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image))
			Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton3.Name = "toolStripButton3"
			Me.toolStripButton3.Size = New System.Drawing.Size(89, 22)
			Me.toolStripButton3.Text = "Indicator Margin"
			' 
			' toolStripButton4
			' 
			Me.toolStripButton4.Checked = True
			Me.toolStripButton4.CheckState = System.Windows.Forms.CheckState.Checked
			Me.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton4.Image = (CType(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image))
			Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton4.Name = "toolStripButton4"
			Me.toolStripButton4.Size = New System.Drawing.Size(45, 22)
			Me.toolStripButton4.Text = "Line no"
			' 
			' toolStripButton5
			' 
			Me.toolStripButton5.Checked = True
			Me.toolStripButton5.CheckState = System.Windows.Forms.CheckState.Checked
			Me.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton5.Image = (CType(resources.GetObject("toolStripButton5.Image"), System.Drawing.Image))
			Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton5.Name = "toolStripButton5"
			Me.toolStripButton5.Size = New System.Drawing.Size(105, 22)
			Me.toolStripButton5.Text = "Outlining Collapsers"
			' 
			' scrollbarBtn
			' 
			Me.scrollbarBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.scrollbarBtn.Image = (CType(resources.GetObject("scrollbarBtn.Image"), System.Drawing.Image))
			Me.scrollbarBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.scrollbarBtn.Name = "scrollbarBtn"
			Me.scrollbarBtn.Size = New System.Drawing.Size(57, 22)
			Me.scrollbarBtn.Text = "Scrollbars"
			' 
			' toolStripButton7
			' 
			Me.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton7.Image = (CType(resources.GetObject("toolStripButton7.Image"), System.Drawing.Image))
			Me.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton7.Name = "toolStripButton7"
			Me.toolStripButton7.Size = New System.Drawing.Size(89, 22)
			Me.toolStripButton7.Text = "Selection Margin"
			' 
			' propertyGridItem
			' 
			Me.propertyGridItem.CheckOnClick = True
			Me.propertyGridItem.Name = "propertyGridItem"
			Me.propertyGridItem.Size = New System.Drawing.Size(83, 20)
			Me.propertyGridItem.Text = "Property Grid"
'			Me.propertyGridItem.Click += New System.EventHandler(Me.propertyGridToolStripMenuItem_Click);
			' 
			' featuresStrip2
			' 
			Me.featuresStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.splittersBtn, Me.statusBarBtn, Me.toolStripButton10, Me.toolStripButton11, Me.toolStripSeparator4, Me.toolStripButton12, Me.wordwrapbtnItem, Me.toolStripSeparator3, Me.toolStripButton14, Me.toolStripButton15})
			Me.featuresStrip2.Location = New System.Drawing.Point(0, 49)
			Me.featuresStrip2.Name = "featuresStrip2"
			Me.featuresStrip2.Size = New System.Drawing.Size(816, 25)
			Me.featuresStrip2.TabIndex = 30
			Me.featuresStrip2.Text = "toolStrip2"
'			Me.featuresStrip2.ItemClicked += New System.Windows.Forms.ToolStripItemClickedEventHandler(Me.toolStrip2_ItemClicked);
			' 
			' splittersBtn
			' 
			Me.splittersBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.splittersBtn.Image = (CType(resources.GetObject("splittersBtn.Image"), System.Drawing.Image))
			Me.splittersBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.splittersBtn.Name = "splittersBtn"
			Me.splittersBtn.Size = New System.Drawing.Size(50, 22)
			Me.splittersBtn.Text = "Splitters"
			' 
			' statusBarBtn
			' 
			Me.statusBarBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.statusBarBtn.Image = (CType(resources.GetObject("statusBarBtn.Image"), System.Drawing.Image))
			Me.statusBarBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.statusBarBtn.Name = "statusBarBtn"
			Me.statusBarBtn.Size = New System.Drawing.Size(58, 22)
			Me.statusBarBtn.Text = "StatusBar"
			' 
			' toolStripButton10
			' 
			Me.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton10.Image = (CType(resources.GetObject("toolStripButton10.Image"), System.Drawing.Image))
			Me.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton10.Name = "toolStripButton10"
			Me.toolStripButton10.Size = New System.Drawing.Size(68, 22)
			Me.toolStripButton10.Text = "User Margin"
			' 
			' toolStripButton11
			' 
			Me.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton11.Image = (CType(resources.GetObject("toolStripButton11.Image"), System.Drawing.Image))
			Me.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton11.Name = "toolStripButton11"
			Me.toolStripButton11.Size = New System.Drawing.Size(76, 22)
			Me.toolStripButton11.Text = "White Spaces"
			' 
			' toolStripButton12
			' 
			Me.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton12.Image = (CType(resources.GetObject("toolStripButton12.Image"), System.Drawing.Image))
			Me.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton12.Name = "toolStripButton12"
			Me.toolStripButton12.Size = New System.Drawing.Size(102, 22)
			Me.toolStripButton12.Text = "Wordwrap Markers"
			' 
			' wordwrapbtnItem
			' 
			Me.wordwrapbtnItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.wordwrapbtnItem.Image = (CType(resources.GetObject("wordwrapbtnItem.Image"), System.Drawing.Image))
			Me.wordwrapbtnItem.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.wordwrapbtnItem.Name = "wordwrapbtnItem"
			Me.wordwrapbtnItem.Size = New System.Drawing.Size(64, 22)
			Me.wordwrapbtnItem.Text = "Word wrap"
			' 
			' toolStripSeparator3
			' 
			Me.toolStripSeparator3.Name = "toolStripSeparator3"
			Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
			' 
			' toolStripButton14
			' 
			Me.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton14.Image = (CType(resources.GetObject("toolStripButton14.Image"), System.Drawing.Image))
			Me.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton14.Name = "toolStripButton14"
			Me.toolStripButton14.Size = New System.Drawing.Size(65, 22)
			Me.toolStripButton14.Text = "Collapse All"
			' 
			' toolStripButton15
			' 
			Me.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton15.Image = (CType(resources.GetObject("toolStripButton15.Image"), System.Drawing.Image))
			Me.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton15.Name = "toolStripButton15"
			Me.toolStripButton15.Size = New System.Drawing.Size(61, 22)
			Me.toolStripButton15.Text = "Expand All"
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
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(816, 466)
			Me.Controls.Add(Me.editControl1)
			Me.Controls.Add(Me.edtProperties)
			Me.Controls.Add(Me.featuresStrip2)
			Me.Controls.Add(Me.featuresStrip1)
			Me.Controls.Add(Me.MainStrip)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MainMenuStrip = Me.MainStrip
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Edit Features Demo"
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.MainStrip.ResumeLayout(False)
			Me.MainStrip.PerformLayout()
			Me.featuresStrip1.ResumeLayout(False)
			Me.featuresStrip1.PerformLayout()
			Me.featuresStrip2.ResumeLayout(False)
			Me.featuresStrip2.PerformLayout()
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

		Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles newToolStripMenuItem.Click, optnToolStripMenuItem.Click, saveToolStripMenuItem.Click, saveAsToolStripMenuItem.Click, closeToolStripMenuItem.Click, exitToolStripMenuItem.Click
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

		Private Sub propertyGridToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles propertyGridItem.Click
			Me.edtProperties.Visible = propertyGridItem.Checked
			If edtProperties.Visible Then
				Me.Size = New Size(825, 520)
			Else
				Me.Size = New Size(664, 500)
			End If
		End Sub

		Private Sub toolStrip1_ItemClicked(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs) Handles featuresStrip1.ItemClicked
			Dim mi As ToolStripButton = CType(e.ClickedItem, ToolStripButton)

			Select Case mi.Text
				Case "Bookmark"
					Me.editControl1.BookmarkAdd(Me.editControl1.CurrentLine)
				Case "Indentation Guidelines"
					Me.editControl1.ShowIndentationGuidelines = Not Me.editControl1.ShowIndentationGuidelines
					mi.Checked = Me.editControl1.ShowIndentationGuidelines
				Case "Indicator Margin"
					Me.editControl1.ShowIndicatorMargin = Not Me.editControl1.ShowIndicatorMargin
					mi.Checked = Me.editControl1.ShowIndicatorMargin
				Case "Line no"
					Me.editControl1.ShowLineNumbers = Not Me.editControl1.ShowLineNumbers
					mi.Checked = Me.editControl1.ShowLineNumbers
				Case "Outlining Collapsers"
					Me.editControl1.ShowOutliningCollapsers = Not Me.editControl1.ShowOutliningCollapsers
					mi.Checked = Me.editControl1.ShowOutliningCollapsers
				Case "Scrollbars"
					Me.editControl1.ShowHorizontalScroller = Not Me.editControl1.ShowHorizontalScroller
					Me.editControl1.ShowVerticalScroller = Not Me.editControl1.ShowVerticalScroller
					mi.Checked = Not mi.Checked
				Case "Selection Margin"
					Me.editControl1.ShowSelectionMargin = Not Me.editControl1.ShowSelectionMargin
					mi.Checked = Me.editControl1.ShowSelectionMargin
			End Select
		End Sub

		Private Sub toolStrip2_ItemClicked(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs) Handles featuresStrip2.ItemClicked
		
		If TypeOf e.ClickedItem Is ToolStripButton Then
			Dim mi As ToolStripButton = CType(e.ClickedItem, ToolStripButton)

			Select Case mi.Text
				Case "Splitters"
					Me.editControl1.ShowHorizontalSplitters = Not Me.editControl1.ShowHorizontalSplitters
					Me.editControl1.ShowVerticalSplitters = Not Me.editControl1.ShowVerticalSplitters
					mi.Checked = Not mi.Checked
				Case "StatusBar"
					Me.editControl1.StatusBarSettings.Visible = Not Me.editControl1.StatusBarSettings.Visible
					mi.Checked = Me.editControl1.StatusBarSettings.Visible
				Case "User Margin"
					Me.editControl1.ShowUserMargin = Not Me.editControl1.ShowUserMargin
					mi.Checked = Me.editControl1.ShowUserMargin
				Case "White Spaces"
					Me.editControl1.ShowWhitespaces = Not Me.editControl1.ShowWhitespaces
					mi.Checked = Me.editControl1.ShowWhitespaces
				Case "Wordwrap Markers"
					If Me.editControl1.MarkWrappedLines = False Then
						Me.editControl1.WordWrap = True
						Me.wordwrapbtnItem.Checked = True
					End If
					Me.editControl1.MarkWrappedLines = Not Me.editControl1.MarkWrappedLines
					mi.Checked = Me.editControl1.MarkWrappedLines
				Case "Word wrap"
					Me.editControl1.WordWrap = Not Me.editControl1.WordWrap
					mi.Checked = Me.editControl1.WordWrap
				Case "Collapse All"
					Me.editControl1.CollapseAll()
				Case "Expand All"
					Me.editControl1.ExpandAll()
			End Select
		End If
		End Sub

	End Class
End Namespace
