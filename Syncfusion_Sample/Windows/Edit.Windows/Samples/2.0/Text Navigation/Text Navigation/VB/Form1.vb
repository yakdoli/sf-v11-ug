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

Namespace TextNavigationDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
		Private colorDialog1 As System.Windows.Forms.ColorDialog
		Private toolTip1 As ToolTip
		Private menuStrip1 As MenuStrip
		Private fileToolStripMenuItem As ToolStripMenuItem
		Private WithEvents newToolStripMenuItem As ToolStripMenuItem
		Private WithEvents openToolStripMenuItem As ToolStripMenuItem
		Private toolStripSeparator1 As ToolStripSeparator
		Private WithEvents saveToolStripMenuItem As ToolStripMenuItem
		Private WithEvents saveAsToolStripMenuItem As ToolStripMenuItem
		Private toolStripSeparator2 As ToolStripSeparator
		Private WithEvents exitToolStripMenuItem As ToolStripMenuItem
		Private WithEvents toolStrip1 As ToolStrip
		Private toolStripButton4 As ToolStripButton
		Private toolStripButton1 As ToolStripButton
		Private toolStripButton3 As ToolStripButton
		Private toolStripButton2 As ToolStripButton
		Private toolStripSeparator5 As ToolStripSeparator
		Private toolStripButton5 As ToolStripButton
		Private toolStripButton6 As ToolStripButton
		Private toolStripSeparator6 As ToolStripSeparator
		Private toolStripButton7 As ToolStripButton
		Private toolStripButton8 As ToolStripButton
		Private toolStripSeparator7 As ToolStripSeparator
		Private toolStripButton9 As ToolStripButton
		Private toolStripButton10 As ToolStripButton
		Private toolStripSeparator8 As ToolStripSeparator
		Private toolStripButton11 As ToolStripButton
		Private toolStripButton12 As ToolStripButton
		Private toolStripSeparator3 As ToolStripSeparator
		Private highlightItem As ToolStripButton
		Private toolStripSplitButton1 As ToolStripButton
		Private components As IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

            Me.editControl1.LoadFile("..\..\Form1.vb")
			Me.editControl1.HighlightCurrentLine = True
			Me.editControl1.CurrentLineHighlightColor = Color.Orange
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
			Me.components = New System.ComponentModel.Container()
			Dim config4 As Syncfusion.Windows.Forms.Edit.Implementation.Config.Config = New Syncfusion.Windows.Forms.Edit.Implementation.Config.Config()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
			Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
			Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
			Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
			Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.saveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.saveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
			Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripButton7 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton8 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton6 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripButton9 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton10 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripButton12 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton11 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
			Me.highlightItem = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSplitButton1 = New System.Windows.Forms.ToolStripButton()
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.menuStrip1.SuspendLayout()
			Me.toolStrip1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' editControl1
			' 
			Me.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart
			Me.editControl1.BackColor = System.Drawing.SystemColors.Window
			Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.editControl1.Configurator = config4
			Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.editControl1.LineNumbersFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.editControl1.Location = New System.Drawing.Point(0, 49)
			Me.editControl1.Name = "editControl1"
			Me.editControl1.ShowHorizontalSplitters = False
			Me.editControl1.ShowIndicatorMargin = False
			Me.editControl1.ShowVerticalSplitters = False
			Me.editControl1.Size = New System.Drawing.Size(671, 396)
			Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
			Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
			Me.editControl1.TabIndex = 3
			Me.editControl1.Text = "editControl1"
			Me.editControl1.TransferFocusOnTab = True
			Me.editControl1.VisualColumn = 1
			Me.editControl1.WordWrap = True
			' 
			' menuStrip1
			' 
			Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.fileToolStripMenuItem})
			Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
			Me.menuStrip1.Name = "menuStrip1"
			Me.menuStrip1.Size = New System.Drawing.Size(671, 24)
			Me.menuStrip1.TabIndex = 7
			Me.menuStrip1.Text = "menuStrip1"
			' 
			' fileToolStripMenuItem
			' 
			Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.newToolStripMenuItem, Me.openToolStripMenuItem, Me.toolStripSeparator1, Me.saveToolStripMenuItem, Me.saveAsToolStripMenuItem, Me.toolStripSeparator2, Me.exitToolStripMenuItem})
			Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
			Me.fileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
			Me.fileToolStripMenuItem.Text = "File"
			' 
			' newToolStripMenuItem
			' 
			Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
			Me.newToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
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
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New System.Drawing.Size(133, 6)
			' 
			' saveToolStripMenuItem
			' 
			Me.saveToolStripMenuItem.Name = "saveToolStripMenuItem"
			Me.saveToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
			Me.saveToolStripMenuItem.Text = "Save"
'			Me.saveToolStripMenuItem.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' saveAsToolStripMenuItem
			' 
			Me.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem"
			Me.saveAsToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
			Me.saveAsToolStripMenuItem.Text = "Save As..."
'			Me.saveAsToolStripMenuItem.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New System.Drawing.Size(133, 6)
			' 
			' exitToolStripMenuItem
			' 
			Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
			Me.exitToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
			Me.exitToolStripMenuItem.Text = "Exit"
'			Me.exitToolStripMenuItem.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' toolStrip1
			' 
			Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton4, Me.toolStripButton1, Me.toolStripButton3, Me.toolStripButton2, Me.toolStripSeparator5, Me.toolStripButton7, Me.toolStripButton8, Me.toolStripSeparator6, Me.toolStripButton5, Me.toolStripButton6, Me.toolStripSeparator7, Me.toolStripButton9, Me.toolStripButton10, Me.toolStripSeparator8, Me.toolStripButton12, Me.toolStripButton11, Me.toolStripSeparator3, Me.highlightItem, Me.toolStripSplitButton1})
			Me.toolStrip1.Location = New System.Drawing.Point(0, 24)
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.Size = New System.Drawing.Size(671, 25)
			Me.toolStrip1.TabIndex = 8
			Me.toolStrip1.Text = "toolStrip1"
'			Me.toolStrip1.ItemClicked += New System.Windows.Forms.ToolStripItemClickedEventHandler(Me.toolStrip1_ItemClicked);
			' 
			' toolStripButton4
			' 
			Me.toolStripButton4.Image = (CType(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image))
			Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton4.Name = "toolStripButton4"
			Me.toolStripButton4.Size = New System.Drawing.Size(69, 22)
			Me.toolStripButton4.Tag = "Move Up"
			Me.toolStripButton4.Text = "Move Up"
			' 
			' toolStripButton1
			' 
			Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton1.Image = (CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image))
			Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton1.Name = "toolStripButton1"
			Me.toolStripButton1.Size = New System.Drawing.Size(23, 22)
			Me.toolStripButton1.Tag = "Move Down"
			Me.toolStripButton1.Text = "Move Down"
			' 
			' toolStripButton3
			' 
			Me.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton3.Image = (CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image))
			Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton3.Name = "toolStripButton3"
			Me.toolStripButton3.Size = New System.Drawing.Size(23, 22)
			Me.toolStripButton3.Tag = "Move Left"
			Me.toolStripButton3.Text = "Move Left"
			' 
			' toolStripButton2
			' 
			Me.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton2.Image = (CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image))
			Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton2.Name = "toolStripButton2"
			Me.toolStripButton2.Size = New System.Drawing.Size(23, 22)
			Me.toolStripButton2.Tag = "Move Right"
			Me.toolStripButton2.Text = "Move Right"
			' 
			' toolStripSeparator5
			' 
			Me.toolStripSeparator5.Name = "toolStripSeparator5"
			Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 25)
			' 
			' toolStripButton7
			' 
			Me.toolStripButton7.Image = (CType(resources.GetObject("toolStripButton7.Image"), System.Drawing.Image))
			Me.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton7.Name = "toolStripButton7"
			Me.toolStripButton7.Size = New System.Drawing.Size(67, 22)
			Me.toolStripButton7.Tag = "Page Up"
			Me.toolStripButton7.Text = "Page Up"
			' 
			' toolStripButton8
			' 
			Me.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton8.Image = (CType(resources.GetObject("toolStripButton8.Image"), System.Drawing.Image))
			Me.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton8.Name = "toolStripButton8"
			Me.toolStripButton8.Size = New System.Drawing.Size(23, 22)
			Me.toolStripButton8.Tag = "Page Down"
			Me.toolStripButton8.Text = "Page Down"
			' 
			' toolStripSeparator6
			' 
			Me.toolStripSeparator6.Name = "toolStripSeparator6"
			Me.toolStripSeparator6.Size = New System.Drawing.Size(6, 25)
			' 
			' toolStripButton5
			' 
			Me.toolStripButton5.Image = (CType(resources.GetObject("toolStripButton5.Image"), System.Drawing.Image))
			Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton5.Name = "toolStripButton5"
			Me.toolStripButton5.Size = New System.Drawing.Size(73, 22)
			Me.toolStripButton5.Tag = "Line Start"
			Me.toolStripButton5.Text = "Line Start"
			' 
			' toolStripButton6
			' 
			Me.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton6.Image = (CType(resources.GetObject("toolStripButton6.Image"), System.Drawing.Image))
			Me.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton6.Name = "toolStripButton6"
			Me.toolStripButton6.Size = New System.Drawing.Size(23, 22)
			Me.toolStripButton6.Tag = "Line End"
			Me.toolStripButton6.Text = "Line End"
			' 
			' toolStripSeparator7
			' 
			Me.toolStripSeparator7.Name = "toolStripSeparator7"
			Me.toolStripSeparator7.Size = New System.Drawing.Size(6, 25)
			' 
			' toolStripButton9
			' 
			Me.toolStripButton9.Image = (CType(resources.GetObject("toolStripButton9.Image"), System.Drawing.Image))
			Me.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton9.Name = "toolStripButton9"
			Me.toolStripButton9.Size = New System.Drawing.Size(96, 22)
			Me.toolStripButton9.Tag = "Left One word"
			Me.toolStripButton9.Text = "Left One word"
			' 
			' toolStripButton10
			' 
			Me.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton10.Image = (CType(resources.GetObject("toolStripButton10.Image"), System.Drawing.Image))
			Me.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton10.Name = "toolStripButton10"
			Me.toolStripButton10.Size = New System.Drawing.Size(23, 22)
			Me.toolStripButton10.Tag = "Right One word"
			Me.toolStripButton10.Text = "Right One word"
			' 
			' toolStripSeparator8
			' 
			Me.toolStripSeparator8.Name = "toolStripSeparator8"
			Me.toolStripSeparator8.Size = New System.Drawing.Size(6, 25)
			' 
			' toolStripButton12
			' 
			Me.toolStripButton12.Image = (CType(resources.GetObject("toolStripButton12.Image"), System.Drawing.Image))
			Me.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton12.Name = "toolStripButton12"
			Me.toolStripButton12.Size = New System.Drawing.Size(93, 22)
			Me.toolStripButton12.Tag = "Move to Start"
			Me.toolStripButton12.Text = "Move to Start"
			' 
			' toolStripButton11
			' 
			Me.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton11.Image = (CType(resources.GetObject("toolStripButton11.Image"), System.Drawing.Image))
			Me.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton11.Name = "toolStripButton11"
			Me.toolStripButton11.Size = New System.Drawing.Size(23, 22)
			Me.toolStripButton11.Tag = "Move to End"
			Me.toolStripButton11.Text = "Move to End"
			' 
			' toolStripSeparator3
			' 
			Me.toolStripSeparator3.Name = "toolStripSeparator3"
			Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
			' 
			' highlightItem
			' 
			Me.highlightItem.Checked = True
			Me.highlightItem.CheckState = System.Windows.Forms.CheckState.Checked
			Me.highlightItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.highlightItem.Image = (CType(resources.GetObject("highlightItem.Image"), System.Drawing.Image))
			Me.highlightItem.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.highlightItem.Name = "highlightItem"
			Me.highlightItem.Size = New System.Drawing.Size(23, 22)
			Me.highlightItem.Tag = "Highlight current line"
			Me.highlightItem.Text = "Highlight current line"
			' 
			' toolStripSplitButton1
			' 
			Me.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripSplitButton1.Image = (CType(resources.GetObject("toolStripSplitButton1.Image"), System.Drawing.Image))
			Me.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripSplitButton1.Name = "toolStripSplitButton1"
			Me.toolStripSplitButton1.Size = New System.Drawing.Size(23, 22)
			Me.toolStripSplitButton1.Tag = "Change HighlightColor"
			Me.toolStripSplitButton1.Text = "Change HighlightColor"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(671, 445)
			Me.Controls.Add(Me.editControl1)
			Me.Controls.Add(Me.toolStrip1)
			Me.Controls.Add(Me.menuStrip1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Text Navigation"
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.menuStrip1.ResumeLayout(False)
			Me.menuStrip1.PerformLayout()
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
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


		Private Sub MainMenuClick(ByVal sender As Object, ByVal e As EventArgs) Handles newToolStripMenuItem.Click, openToolStripMenuItem.Click, saveToolStripMenuItem.Click, saveAsToolStripMenuItem.Click, exitToolStripMenuItem.Click
			Dim mi As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

			Select Case mi.Text
				Case "New"
					Me.editControl1.NewFile()
				Case "Open..."
					Me.editControl1.LoadFile()
				Case "Save"
					Me.editControl1.Save()
				Case "Save As..."
					Me.editControl1.SaveAs()
				Case "Exit"
					Close()
			End Select
		End Sub

		Private Sub toolStrip1_ItemClicked(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs) Handles toolStrip1.ItemClicked
          
            If TypeOf e.ClickedItem Is ToolStripButton Then

                Dim mi As ToolStripButton = CType(e.ClickedItem, ToolStripButton)

                Select Case mi.Text
                    Case "Move Up"
                        Me.editControl1.MoveUp()
                    Case "Move Down"
                        Me.editControl1.MoveDown()
                    Case "Move Left"
                        Me.editControl1.MoveLeft()
                    Case "Move Right"
                        Me.editControl1.MoveRight()
                    Case "Move to Start"
                        Me.editControl1.MoveToBeginning()
                    Case "Move to End"
                        Me.editControl1.MoveToEnd()
                    Case "Page Up"
                        Me.editControl1.MovePageUp()
                    Case "Page Down"
                        Me.editControl1.MovePageDown()
                    Case "Left One word"
                        Me.editControl1.MoveLeftWord()
                    Case "Right One word"
                        Me.editControl1.MoveRightWord()
                    Case "Line Start"
                        Me.editControl1.MoveToLineStart()
                    Case "Line End"
                        Me.editControl1.MoveToLineEnd()
                    Case "Highlight current line"
                        mi.Checked = Not mi.Checked
                        Me.editControl1.HighlightCurrentLine = mi.Checked
                    Case "Change HighlightColor"
                        If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                            Me.editControl1.CurrentLineHighlightColor = Me.colorDialog1.Color
                        End If
                End Select
            End If
		End Sub

	End Class
End Namespace
