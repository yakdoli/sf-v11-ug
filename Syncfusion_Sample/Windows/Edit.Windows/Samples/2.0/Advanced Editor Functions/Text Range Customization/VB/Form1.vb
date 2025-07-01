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
Imports Syncfusion.Windows.Forms.Edit.Enums
Imports Syncfusion.Windows.Forms.Edit.Dialogs
Imports Syncfusion.Windows.Forms.Edit.Implementation
Imports Syncfusion.Windows.Forms.Edit.Interfaces
Imports Syncfusion.Windows.Forms.Edit.Utils

Namespace TextRangeCustomizationDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form

		Private mainMenu1 As System.Windows.Forms.MainMenu
		Private menuItem1 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
		Private menuItem4 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
		Private menuItem7 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem8 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem9 As System.Windows.Forms.MenuItem
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
		Private WithEvents menuItem10 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem11 As System.Windows.Forms.MenuItem
		Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
		Private BasePath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\Form1.cs"

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			Me.editControl1.Configurator.Open("..\..\config.xml")
			Me.editControl1.ApplyConfiguration("LISP")

			Me.editControl1.LoadFile("..\..\Test.lsp")

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
			Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
			Me.mainMenu1 = New System.Windows.Forms.MainMenu()
			Me.menuItem1 = New System.Windows.Forms.MenuItem()
			Me.menuItem2 = New System.Windows.Forms.MenuItem()
			Me.menuItem3 = New System.Windows.Forms.MenuItem()
			Me.menuItem4 = New System.Windows.Forms.MenuItem()
			Me.menuItem5 = New System.Windows.Forms.MenuItem()
			Me.menuItem6 = New System.Windows.Forms.MenuItem()
			Me.menuItem7 = New System.Windows.Forms.MenuItem()
			Me.menuItem9 = New System.Windows.Forms.MenuItem()
			Me.menuItem8 = New System.Windows.Forms.MenuItem()
			Me.menuItem10 = New System.Windows.Forms.MenuItem()
			Me.menuItem11 = New System.Windows.Forms.MenuItem()
			Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' mainMenu1
			' 
			Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem1, Me.menuItem10, Me.menuItem11})
			' 
			' menuItem1
			' 
			Me.menuItem1.Index = 0
			Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem9, Me.menuItem8})
			Me.menuItem1.Text = "File"
			' 
			' menuItem2
			' 
			Me.menuItem2.Index = 0
			Me.menuItem2.Text = "New"
'			Me.menuItem2.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem3
			' 
			Me.menuItem3.Index = 1
			Me.menuItem3.Text = "Open"
'			Me.menuItem3.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem4
			' 
			Me.menuItem4.Index = 2
			Me.menuItem4.Text = "-"
			' 
			' menuItem5
			' 
			Me.menuItem5.Index = 3
			Me.menuItem5.Text = "Save"
'			Me.menuItem5.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem6
			' 
			Me.menuItem6.Index = 4
			Me.menuItem6.Text = "SaveAs"
'			Me.menuItem6.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem7
			' 
			Me.menuItem7.Index = 5
			Me.menuItem7.Text = "-"
			' 
			' menuItem9
			' 
			Me.menuItem9.Index = 6
			Me.menuItem9.Text = "Close"
'			Me.menuItem9.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem8
			' 
			Me.menuItem8.Index = 7
			Me.menuItem8.Text = "Exit"
'			Me.menuItem8.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem10
			' 
			Me.menuItem10.Index = 1
			Me.menuItem10.Text = "MarkReadOnly"
'			Me.menuItem10.Click += New System.EventHandler(Me.menuItem10_Click);
			' 
			' menuItem11
			' 
			Me.menuItem11.Index = 2
			Me.menuItem11.Text = "RemoveReadOnly"
'			Me.menuItem11.Click += New System.EventHandler(Me.menuItem11_Click);
			' 
			' editControl1
			' 
			Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.editControl1.Name = "editControl1"
			Me.editControl1.Size = New System.Drawing.Size(542, 466)
			Me.editControl1.StatusBarSettings.EncodingPanel.MinWidth = 0
			Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
			Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
			Me.editControl1.TabIndex = 0
			Me.editControl1.Text = "editControl1"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(542, 466)
			Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.editControl1})
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Menu = Me.mainMenu1
			Me.Name = "Form1"
			Me.Text = "Text Range Customization"
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

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

		Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click, menuItem3.Click, menuItem5.Click, menuItem6.Click, menuItem9.Click, menuItem8.Click
			Dim mi As MenuItem = CType(IIf(TypeOf sender Is MenuItem, sender, Nothing), MenuItem)

			Select Case mi.Text
				Case "New" 
					Me.editControl1.NewFile()
				Case "Open" 
					Me.editControl1.LoadFile()
				Case "Save" 
					Me.editControl1.Save()
				Case "SaveAs" 
					Me.editControl1.SaveAs()
				Case "Close" 
					Me.editControl1.Close()
				Case "Exit" 
					Me.Close()
			End Select
		End Sub

		Private Sub editControl1_OutliningTooltipBeforePopup(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Edit.OutliningTooltipBeforePopupEventArgs)
			If e.CollapsedText = "Hidden Region" Then
				e.ShowMode = OutliningTooltipShowMode.Off
			End If
		End Sub

        Private Sub menuItem10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem10.Click
            If Not Me.editControl1.Selection Is Nothing Then
                Me.editControl1.MarkAsReadOnly(Me.editControl1.Selection.Start, Me.editControl1.Selection.End, Color.Orange, Color.Crimson)
                Me.editControl1.ResetSelection()
            Else
                MsgBox("Please select some text")
            End If
        End Sub

        Private Sub menuItem11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem11.Click
            If Not Me.editControl1.Selection Is Nothing Then
                Me.editControl1.RemoveReadOnly(Me.editControl1.Selection.Start, Me.editControl1.Selection.End)
                Me.editControl1.ResetSelection()
            Else
                MsgBox("Please select some text from readonly region")
            End If
        End Sub


	End Class
End Namespace
