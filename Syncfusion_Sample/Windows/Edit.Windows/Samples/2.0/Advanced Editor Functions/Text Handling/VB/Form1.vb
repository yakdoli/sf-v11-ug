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

Namespace TextHandlingDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
		Private components As IContainer

		Private inputDialog As Form2
		Private inputString As String = String.Empty
		Private menuStrip1 As MenuStrip
		Private fileToolStripMenuItem As ToolStripMenuItem
		Private WithEvents newToolStripMenuItem As ToolStripMenuItem
        Private WithEvents openToolStripMenuItem As ToolStripMenuItem
		Private toolStripSeparator1 As ToolStripSeparator
        Private WithEvents saveToolStripMenuItem As ToolStripMenuItem
        Private WithEvents toolStripMenuItem2 As ToolStripMenuItem
		Private toolStripSeparator2 As ToolStripSeparator
        Private WithEvents exitToolStripMenuItem As ToolStripMenuItem
		Private WithEvents setTextToolStripMenuItem As ToolStripMenuItem
		Private WithEvents appendTextToolStripMenuItem As ToolStripMenuItem
		Private WithEvents insertTextToolStripMenuItem As ToolStripMenuItem
		Private WithEvents deleteAllToolStripMenuItem As ToolStripMenuItem
		Private WithEvents deleteSelectionToolStripMenuItem As ToolStripMenuItem
		Private accepted As Boolean = False

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			inputDialog = New Form2()
			AddHandler inputDialog.AcceptButton.Click, AddressOf AcceptButton_Clicked
			AddHandler inputDialog.CancelButton.Click, AddressOf CancelButton_Clicked
		End Sub

		Private Sub AcceptButton_Clicked(ByVal sender As Object, ByVal args As EventArgs)
			Me.inputString = Me.inputDialog.InputString
			Me.accepted = True
			Me.inputDialog.Close()
		End Sub

		Private Sub CancelButton_Clicked(ByVal sender As Object, ByVal args As EventArgs)
			Me.accepted = False
			Me.inputDialog.Close()
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
			Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.saveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.setTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.appendTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.insertTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.deleteAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.deleteSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
			Me.editControl1.ShowIndicatorMargin = False
			Me.editControl1.ShowLineNumbers = False
			Me.editControl1.ShowOutliningCollapsers = False
			Me.editControl1.Size = New System.Drawing.Size(542, 421)
			Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
			Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
			Me.editControl1.TabIndex = 0
			Me.editControl1.Text = ""
			Me.editControl1.TransferFocusOnTab = True
			Me.editControl1.VisualColumn = 1
			Me.editControl1.WordWrap = True
			' 
			' menuStrip1
			' 
			Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.fileToolStripMenuItem, Me.setTextToolStripMenuItem, Me.appendTextToolStripMenuItem, Me.insertTextToolStripMenuItem, Me.deleteAllToolStripMenuItem, Me.deleteSelectionToolStripMenuItem})
			Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
			Me.menuStrip1.Name = "menuStrip1"
			Me.menuStrip1.Size = New System.Drawing.Size(542, 24)
			Me.menuStrip1.TabIndex = 1
			Me.menuStrip1.Text = "menuStrip1"
			' 
			' fileToolStripMenuItem
			' 
			Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.newToolStripMenuItem, Me.openToolStripMenuItem, Me.toolStripSeparator1, Me.saveToolStripMenuItem, Me.toolStripMenuItem2, Me.toolStripSeparator2, Me.exitToolStripMenuItem})
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
			' openToolStripMenuItem
			' 
			Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
			Me.openToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.openToolStripMenuItem.Text = "Open..."
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
			' 
			' toolStripMenuItem2
			' 
			Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
			Me.toolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
			Me.toolStripMenuItem2.Text = "Save As..."
			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New System.Drawing.Size(149, 6)
			' 
			' exitToolStripMenuItem
			' 
			Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
			Me.exitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.exitToolStripMenuItem.Text = "Exit"
			' 
			' setTextToolStripMenuItem
			' 
			Me.setTextToolStripMenuItem.Name = "setTextToolStripMenuItem"
			Me.setTextToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
			Me.setTextToolStripMenuItem.Text = "SetText"
'			Me.setTextToolStripMenuItem.Click += New System.EventHandler(Me.menuItem9_Click);
			' 
			' appendTextToolStripMenuItem
			' 
			Me.appendTextToolStripMenuItem.Name = "appendTextToolStripMenuItem"
			Me.appendTextToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
			Me.appendTextToolStripMenuItem.Text = "AppendText"
'			Me.appendTextToolStripMenuItem.Click += New System.EventHandler(Me.menuItem10_Click);
			' 
			' insertTextToolStripMenuItem
			' 
			Me.insertTextToolStripMenuItem.Name = "insertTextToolStripMenuItem"
			Me.insertTextToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
			Me.insertTextToolStripMenuItem.Text = "InsertText"
'			Me.insertTextToolStripMenuItem.Click += New System.EventHandler(Me.menuItem11_Click);
			' 
			' deleteAllToolStripMenuItem
			' 
			Me.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem"
			Me.deleteAllToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
			Me.deleteAllToolStripMenuItem.Text = "DeleteAll"
'			Me.deleteAllToolStripMenuItem.Click += New System.EventHandler(Me.menuItem12_Click);
			' 
			' deleteSelectionToolStripMenuItem
			' 
			Me.deleteSelectionToolStripMenuItem.Name = "deleteSelectionToolStripMenuItem"
			Me.deleteSelectionToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
			Me.deleteSelectionToolStripMenuItem.Text = "DeleteSelection"
'			Me.deleteSelectionToolStripMenuItem.Click += New System.EventHandler(Me.menuItem13_Click);
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
			Me.Text = "Text Handling"
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

        Private Sub MainMenuClick(ByVal sender As Object, ByVal e As EventArgs) Handles newToolStripMenuItem.Click, exitToolStripMenuItem.Click, openToolStripMenuItem.Click, saveToolStripMenuItem.Click, toolStripMenuItem2.Click
            Dim mi As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
            Select Case mi.Text
                Case "New"
                    editControl1.NewFile()
                Case "Open..."
                    editControl1.LoadFile()
                Case "Save"
                    editControl1.Save()
                Case "Save As..."
                    editControl1.SaveAs()
                Case "Exit"
                    Close()
            End Select
        End Sub

		Private Sub menuItem9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles setTextToolStripMenuItem.Click
			Me.inputDialog.ShowDialog()

			If Me.accepted Then
				Me.editControl1.Text = Me.inputString
			End If
		End Sub

		Private Sub menuItem10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles appendTextToolStripMenuItem.Click
			Me.inputDialog.ShowDialog()

			If Me.accepted Then
				Me.editControl1.AppendText(Me.inputString)
			End If
		End Sub

		Private Sub menuItem11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles insertTextToolStripMenuItem.Click
			Me.inputDialog.ShowDialog()

			If Me.accepted Then
				Me.editControl1.InsertText(Me.editControl1.CurrentLine, Me.editControl1.CurrentColumn, Me.inputString)
			End If
		End Sub

		Private Sub menuItem12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles deleteAllToolStripMenuItem.Click
			Me.editControl1.DeleteAll()
		End Sub

		Private Sub menuItem13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles deleteSelectionToolStripMenuItem.Click
			If Not editControl1.Selection Is Nothing Then
				Me.editControl1.DeleteText(Me.editControl1.Selection.Top, Me.editControl1.Selection.Bottom)
			Else
				MessageBox.Show("Please select the text to be deleted")
			End If
		End Sub


	End Class
End Namespace
