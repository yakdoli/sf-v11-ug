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
Imports Syncfusion.Windows.Forms.Edit.Dialogs
Imports Syncfusion.Windows.Forms.Edit.Implementation.Config
Imports Syncfusion.Windows.Forms.Edit.Interfaces
Imports Syncfusion.Windows.Forms.Edit.Implementation.IO
Imports Syncfusion.Windows.Forms.Edit.Implementation.Formatting
Imports Syncfusion.Windows.Forms.Edit.Implementation.Parser
Imports Syncfusion.IO

Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports Syncfusion.Windows.Forms.Edit.Implementation
Imports Syncfusion.Windows.Forms.Edit.Enums


Namespace FindReplaceDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private mainMenu1 As System.Windows.Forms.MainMenu
		Private menuItem1 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem4 As System.Windows.Forms.MenuItem
		Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
		Private menuItem5 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem7 As System.Windows.Forms.MenuItem
		Private menuItem8 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem9 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem10 As System.Windows.Forms.MenuItem
		Private menuItem11 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem12 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem13 As System.Windows.Forms.MenuItem
		Private menuItem14 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem15 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem16 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem17 As System.Windows.Forms.MenuItem
		Private menuItem18 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem19 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem20 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem21 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem22 As System.Windows.Forms.MenuItem
		Private menuItem23 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem24 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem25 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem26 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem27 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem28 As System.Windows.Forms.MenuItem
		Private i As Integer

		Private filePath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\Test Files\CSharpSource.cs"

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			Me.editControl1.ShowLineNumbers = True
			Me.editControl1.ShowIndicatorMargin = True
			Me.editControl1.ShowOutliningCollapsers = True

			Me.editControl1.LoadFile(filePath)

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
			Me.mainMenu1 = New System.Windows.Forms.MainMenu()
			Me.menuItem5 = New System.Windows.Forms.MenuItem()
			Me.menuItem6 = New System.Windows.Forms.MenuItem()
			Me.menuItem7 = New System.Windows.Forms.MenuItem()
			Me.menuItem8 = New System.Windows.Forms.MenuItem()
			Me.menuItem9 = New System.Windows.Forms.MenuItem()
			Me.menuItem10 = New System.Windows.Forms.MenuItem()
			Me.menuItem11 = New System.Windows.Forms.MenuItem()
			Me.menuItem12 = New System.Windows.Forms.MenuItem()
			Me.menuItem13 = New System.Windows.Forms.MenuItem()
			Me.menuItem1 = New System.Windows.Forms.MenuItem()
			Me.menuItem2 = New System.Windows.Forms.MenuItem()
			Me.menuItem3 = New System.Windows.Forms.MenuItem()
			Me.menuItem4 = New System.Windows.Forms.MenuItem()
			Me.menuItem14 = New System.Windows.Forms.MenuItem()
			Me.menuItem17 = New System.Windows.Forms.MenuItem()
			Me.menuItem25 = New System.Windows.Forms.MenuItem()
			Me.menuItem15 = New System.Windows.Forms.MenuItem()
			Me.menuItem16 = New System.Windows.Forms.MenuItem()
			Me.menuItem18 = New System.Windows.Forms.MenuItem()
			Me.menuItem19 = New System.Windows.Forms.MenuItem()
			Me.menuItem20 = New System.Windows.Forms.MenuItem()
			Me.menuItem21 = New System.Windows.Forms.MenuItem()
			Me.menuItem22 = New System.Windows.Forms.MenuItem()
			Me.menuItem23 = New System.Windows.Forms.MenuItem()
			Me.menuItem24 = New System.Windows.Forms.MenuItem()
			Me.menuItem26 = New System.Windows.Forms.MenuItem()
			Me.menuItem27 = New System.Windows.Forms.MenuItem()
			Me.menuItem28 = New System.Windows.Forms.MenuItem()
			Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' mainMenu1
			' 
			Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem5, Me.menuItem1, Me.menuItem14, Me.menuItem18, Me.menuItem23})
			' 
			' menuItem5
			' 
			Me.menuItem5.Index = 0
			Me.menuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem6, Me.menuItem7, Me.menuItem8, Me.menuItem9, Me.menuItem10, Me.menuItem11, Me.menuItem12, Me.menuItem13})
			Me.menuItem5.Text = "File"
			' 
			' menuItem6
			' 
			Me.menuItem6.Index = 0
			Me.menuItem6.Text = "New"
'			Me.menuItem6.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem7
			' 
			Me.menuItem7.Index = 1
			Me.menuItem7.Text = "Open"
'			Me.menuItem7.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem8
			' 
			Me.menuItem8.Index = 2
			Me.menuItem8.Text = "-"
			' 
			' menuItem9
			' 
			Me.menuItem9.Index = 3
			Me.menuItem9.Text = "Save"
'			Me.menuItem9.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem10
			' 
			Me.menuItem10.Index = 4
			Me.menuItem10.Text = "SaveAs"
'			Me.menuItem10.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem11
			' 
			Me.menuItem11.Index = 5
			Me.menuItem11.Text = "-"
			' 
			' menuItem12
			' 
			Me.menuItem12.Index = 6
			Me.menuItem12.Text = "Close"
'			Me.menuItem12.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem13
			' 
			Me.menuItem13.Index = 7
			Me.menuItem13.Text = "Exit"
'			Me.menuItem13.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem1
			' 
			Me.menuItem1.Index = 1
			Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem2, Me.menuItem3, Me.menuItem4})
			Me.menuItem1.Text = "Launch Menu"
			' 
			' menuItem2
			' 
			Me.menuItem2.Index = 0
			Me.menuItem2.Text = "Find Dialog"
'			Me.menuItem2.Click += New System.EventHandler(Me.menuItem2_Click);
			' 
			' menuItem3
			' 
			Me.menuItem3.Index = 1
			Me.menuItem3.Text = "Replace Dialog"
'			Me.menuItem3.Click += New System.EventHandler(Me.menuItem3_Click);
			' 
			' menuItem4
			' 
			Me.menuItem4.Index = 2
			Me.menuItem4.Text = "GoTo Dialog"
'			Me.menuItem4.Click += New System.EventHandler(Me.menuItem4_Click);
			' 
			' menuItem14
			' 
			Me.menuItem14.Index = 2
			Me.menuItem14.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem17, Me.menuItem25, Me.menuItem15, Me.menuItem16})
			Me.menuItem14.Text = "Find History"
			' 
			' menuItem17
			' 
			Me.menuItem17.Index = 0
			Me.menuItem17.Text = "Add To History"
'			Me.menuItem17.Click += New System.EventHandler(Me.FindHistoryMenu_Click);
			' 
			' menuItem25
			' 
			Me.menuItem25.Index = 1
			Me.menuItem25.Text = "Remove From History"
'			Me.menuItem25.Click += New System.EventHandler(Me.FindHistoryMenu_Click);
			' 
			' menuItem15
			' 
			Me.menuItem15.Index = 2
			Me.menuItem15.Text = "Sort History"
'			Me.menuItem15.Click += New System.EventHandler(Me.FindHistoryMenu_Click);
			' 
			' menuItem16
			' 
			Me.menuItem16.Index = 3
			Me.menuItem16.Text = "Clear History"
'			Me.menuItem16.Click += New System.EventHandler(Me.FindHistoryMenu_Click);
			' 
			' menuItem18
			' 
			Me.menuItem18.Index = 3
			Me.menuItem18.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem19, Me.menuItem20, Me.menuItem21, Me.menuItem22})
			Me.menuItem18.Text = "Replace History"
			' 
			' menuItem19
			' 
			Me.menuItem19.Index = 0
			Me.menuItem19.Text = "Add To History"
'			Me.menuItem19.Click += New System.EventHandler(Me.ReplaceHistory_Click);
			' 
			' menuItem20
			' 
			Me.menuItem20.Index = 1
			Me.menuItem20.Text = "Remove From History"
'			Me.menuItem20.Click += New System.EventHandler(Me.ReplaceHistory_Click);
			' 
			' menuItem21
			' 
			Me.menuItem21.Index = 2
			Me.menuItem21.Text = "Sort History"
'			Me.menuItem21.Click += New System.EventHandler(Me.ReplaceHistory_Click);
			' 
			' menuItem22
			' 
			Me.menuItem22.Index = 3
			Me.menuItem22.Text = "Clear History"
'			Me.menuItem22.Click += New System.EventHandler(Me.ReplaceHistory_Click);
			' 
			' menuItem23
			' 
			Me.menuItem23.Index = 4
			Me.menuItem23.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem24, Me.menuItem26, Me.menuItem27, Me.menuItem28})
			Me.menuItem23.Text = "Replace Search History"
			' 
			' menuItem24
			' 
			Me.menuItem24.Index = 0
			Me.menuItem24.Text = "Add To History"
'			Me.menuItem24.Click += New System.EventHandler(Me.ReplaceSearchHistory_Click);
			' 
			' menuItem26
			' 
			Me.menuItem26.Index = 1
			Me.menuItem26.Text = "Remove From History"
'			Me.menuItem26.Click += New System.EventHandler(Me.ReplaceSearchHistory_Click);
			' 
			' menuItem27
			' 
			Me.menuItem27.Index = 2
			Me.menuItem27.Text = "Sort History"
'			Me.menuItem27.Click += New System.EventHandler(Me.ReplaceSearchHistory_Click);
			' 
			' menuItem28
			' 
			Me.menuItem28.Index = 3
			Me.menuItem28.Text = "Clear History"
'			Me.menuItem28.Click += New System.EventHandler(Me.ReplaceSearchHistory_Click);
			' 
			' editControl1
			' 
			Me.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart
			Me.editControl1.BackColor = System.Drawing.SystemColors.Window
			Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.editControl1.DropAllFiles = False
			Me.editControl1.FileExtensions = New String() { ".cs", ".htm", ".html", ".java", ".js", ".pas", ".sql", ".vb", ".vbs", ".xml"}
			Me.editControl1.Name = "editControl1"
			Me.editControl1.ShowIndicatorMargin = False
			Me.editControl1.ShowLineNumbers = False
			Me.editControl1.ShowOutliningCollapsers = False
			Me.editControl1.Size = New System.Drawing.Size(542, 445)
			Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
			Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
			Me.editControl1.TabIndex = 0
			Me.editControl1.Text = ""
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(542, 445)
			Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.editControl1})
			Me.Menu = Me.mainMenu1
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Name = "Form1"
			Me.Text = "Find and Replace"
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

		Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click
			Me.FindDialogOpen()
		End Sub

		Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem3.Click
			Me.ReplaceDialogOpen()
		End Sub

		Private Sub menuItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem4.Click
			Me.GoToDialogOpen()
		End Sub

		Private Sub codeEdit1_RegisteringKeyCommands(ByVal sender As Object, ByVal e As System.EventArgs)
			AddHandler editControl1.Commands.Add("FindDialog.Open").ProcessCommand, AddressOf FindDialogOpen
			AddHandler editControl1.Commands.Add("ReplaceDialog.Open").ProcessCommand, AddressOf ReplaceDialogOpen
			AddHandler editControl1.Commands.Add("GoToDialog.Open").ProcessCommand, AddressOf GoToDialogOpen
		End Sub

		Private Sub FindDialogOpen()
			Me.editControl1.ShowFindDialog()
		End Sub

		Private Sub ReplaceDialogOpen()
			Me.editControl1.ShowReplaceDialog()
		End Sub

		Private Sub GoToDialogOpen()
			Me.editControl1.ShowGoToDialog()
		End Sub

		Private Sub codeEdit1_RegisteringDefaultKeyBindings(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.editControl1.KeyBinder.BindToCommand (Keys.Control Or Keys.F, "FindDialog.Open")
			Me.editControl1.KeyBinder.BindToCommand (Keys.Control Or Keys.R, "ReplaceDialog.Open")
			Me.editControl1.KeyBinder.BindToCommand (Keys.Control Or Keys.G, "GoToDialog.Open")
		End Sub

		Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem6.Click, menuItem7.Click, menuItem9.Click, menuItem10.Click, menuItem12.Click, menuItem13.Click
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


		Private Sub FindHistoryMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem17.Click, menuItem25.Click, menuItem15.Click, menuItem16.Click
			Dim mi As MenuItem = CType(IIf(TypeOf sender Is MenuItem, sender, Nothing), MenuItem)
            Dim o As Object
            Select Case mi.Text
                Case "Add To History"
                    Dim ATH As AddToHistoryDlg = New AddToHistoryDlg()
                    If DialogResult.OK = ATH.ShowDialog() Then
                        Me.editControl1.FindHistory.Insert(0, CObj(ATH.addedItem))
                    End If
                Case "Remove From History"
                    i = 1
                    Dim r As RemoveHistoryItem = New RemoveHistoryItem(Me.SearchItemList)
                    If DialogResult.OK = r.ShowDialog() Then
                        If Not r.RemoveListItems Is Nothing Then
                            For Each o In r.RemoveListItems
                                Me.editControl1.FindHistory.Remove(o)
                            Next o
                        End If
                    End If
                Case "Sort History"
                    Me.editControl1.FindHistory.Sort()
                Case "Clear History"
                    Me.editControl1.FindHistory.Clear()
            End Select


		End Sub

		Private Sub ReplaceHistory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem19.Click, menuItem20.Click, menuItem21.Click, menuItem22.Click
			Dim mi As MenuItem = CType(IIf(TypeOf sender Is MenuItem, sender, Nothing), MenuItem)
            Dim o As Object
            Select Case mi.Text
                Case "Add To History"
                    Dim ATH As AddToHistoryDlg = New AddToHistoryDlg()
                    If DialogResult.OK = ATH.ShowDialog() Then
                        Me.editControl1.ReplaceHistory.Insert(0, CObj(ATH.addedItem))
                    End If
                Case "Remove From History"
                    i = 2
                    Dim r As RemoveHistoryItem = New RemoveHistoryItem(Me.SearchItemList)
                    If DialogResult.OK = r.ShowDialog() Then
                        If Not r.RemoveListItems Is Nothing Then
                            For Each o In r.RemoveListItems
                                Me.editControl1.ReplaceHistory.Remove(o)
                            Next o
                        End If
                    End If
                Case "Sort History"
                    Me.editControl1.ReplaceHistory.Sort()
                Case "Clear History"
                    Me.editControl1.ReplaceHistory.Clear()
            End Select

		End Sub

		Private Sub ReplaceSearchHistory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem24.Click, menuItem26.Click, menuItem27.Click, menuItem28.Click
            Dim o As Object
            Dim mi As MenuItem = CType(IIf(TypeOf sender Is MenuItem, sender, Nothing), MenuItem)
			Select Case mi.Text
				Case "Add To History"
					Dim ATH As AddToHistoryDlg = New AddToHistoryDlg()
					If DialogResult.OK= ATH.ShowDialog() Then
						Me.editControl1.ReplaceSearchHistory.Insert(0,CObj(ATH.addedItem))
					End If
				Case "Remove From History"
					i=3
					Dim r As RemoveHistoryItem = New RemoveHistoryItem(Me.SearchItemList)
					If DialogResult.OK= r.ShowDialog() Then
						If Not r.RemoveListItems Is Nothing Then
                            For Each o In r.RemoveListItems
                                Me.editControl1.ReplaceSearchHistory.Remove(o)
                            Next o
                        End If
					End If
				Case "Sort History"
					Me.editControl1.ReplaceSearchHistory.Sort()
				Case "Clear History"
					Me.editControl1.ReplaceSearchHistory.Clear()


			End Select

		End Sub

		'Properties
		Public ReadOnly Property SearchItemList() As System.Collections.ArrayList

			Get
				If i=1 Then
				Return Me.editControl1.FindHistory
				Else If i=2 Then
				Return Me.editControl1.ReplaceHistory
				Else If i=3 Then
				Return Me.editControl1.ReplaceSearchHistory
				Else
					Return Nothing
				End If
			End Get
		End Property
	End Class


End Namespace
