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

Namespace Syncfusion.Windows.Forms.HTMLUI.Samples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private panel1 As System.Windows.Forms.Panel
		Private mainMenu1 As System.Windows.Forms.MainMenu
		Private menuItem1 As System.Windows.Forms.MenuItem
		Private menuItem4 As System.Windows.Forms.MenuItem
		Private menuItem6 As System.Windows.Forms.MenuItem
		Private openFileDlg As System.Windows.Forms.OpenFileDialog
		Private WithEvents Open As System.Windows.Forms.MenuItem
		Private WithEvents MenuExit As System.Windows.Forms.MenuItem
		Private WithEvents MenuEdit As System.Windows.Forms.MenuItem
		Private WithEvents HTMLSource As System.Windows.Forms.MenuItem
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
		Private WithEvents htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
		Private cxtMenu As System.Windows.Forms.ContextMenu
		Private WithEvents cxtEdit As System.Windows.Forms.MenuItem

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
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
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
            Me.cxtMenu = New System.Windows.Forms.ContextMenu()
            Me.cxtEdit = New System.Windows.Forms.MenuItem()
            Me.mainMenu1 = New System.Windows.Forms.MainMenu()
            Me.menuItem1 = New System.Windows.Forms.MenuItem()
            Me.Open = New System.Windows.Forms.MenuItem()
            Me.MenuExit = New System.Windows.Forms.MenuItem()
            Me.menuItem6 = New System.Windows.Forms.MenuItem()
            Me.MenuEdit = New System.Windows.Forms.MenuItem()
            Me.menuItem4 = New System.Windows.Forms.MenuItem()
            Me.HTMLSource = New System.Windows.Forms.MenuItem()
            Me.openFileDlg = New System.Windows.Forms.OpenFileDialog()
            Me.panel1.SuspendLayout()
            CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.htmluiControl1})
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(520, 366)
            Me.panel1.TabIndex = 0
            '
            'htmluiControl1
            '
            Me.htmluiControl1.AutoScroll = True
            Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(493, 351)
            Me.htmluiControl1.BackColor = System.Drawing.Color.White
            Me.htmluiControl1.ContextMenu = Me.cxtMenu
            Me.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.htmluiControl1.EnableMultithreading = False
            Me.htmluiControl1.IsOriginalTextCached = True
            Me.htmluiControl1.Name = "htmluiControl1"
            Me.htmluiControl1.Size = New System.Drawing.Size(520, 366)
            Me.htmluiControl1.StartupDocument = ""
            Me.htmluiControl1.StartupFolder = ""
            Me.htmluiControl1.TabIndex = 0
            Me.htmluiControl1.Text = "htmluiControl1"
            '
            'cxtMenu
            '
            Me.cxtMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cxtEdit})
            '
            'cxtEdit
            '
            Me.cxtEdit.Index = 0
            Me.cxtEdit.Text = "Edit HTML"
            '
            'mainMenu1
            '
            Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem6, Me.menuItem4})
            '
            'menuItem1
            '
            Me.menuItem1.Index = 0
            Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Open, Me.MenuExit})
            Me.menuItem1.Text = "File"
            '
            'Open
            '
            Me.Open.Index = 0
            Me.Open.Text = "Open"
            '
            'MenuExit
            '
            Me.MenuExit.Index = 1
            Me.MenuExit.Text = "Exit"
            '
            'menuItem6
            '
            Me.menuItem6.Index = 1
            Me.menuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuEdit})
            Me.menuItem6.Text = "Edit"
            '
            'MenuEdit
            '
            Me.MenuEdit.Index = 0
            Me.MenuEdit.Text = "Edit HTML"
            '
            'menuItem4
            '
            Me.menuItem4.Index = 2
            Me.menuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.HTMLSource})
            Me.menuItem4.Text = "View"
            '
            'HTMLSource
            '
            Me.HTMLSource.Index = 0
            Me.HTMLSource.Text = "HTML Source"
            '
            'openFileDlg
            '
            Me.openFileDlg.Filter = "html files|*.html|htm files|*.htm"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.SystemColors.ControlLightLight
            Me.ClientSize = New System.Drawing.Size(520, 366)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Menu = Me.mainMenu1
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "HTMLUI Editor"
            Me.panel1.ResumeLayout(False)
            CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		#Region "ClassEvents"
		Private Sub Open_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Open.Click
			Me.openFileDlg.InitialDirectory = GetFilesLocation()

			If openFileDlg.ShowDialog() = DialogResult.OK Then
				Dim fileName As String = Me.openFileDlg.FileName.ToString()
				Me.htmluiControl1.LoadHTML(fileName)
			End If
		End Sub

		Private Sub MenuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuExit.Click
			Me.Close()
		End Sub

		Private Sub MenuEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuEdit.Click
			OpenEditForm()
		End Sub

		Private Sub HTMLSource_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HTMLSource.Click
			MessageBox.Show(Me.htmluiControl1.Text.ToString())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Me.LoadFromFile("products.htm")
		End Sub

		Private Sub cxtEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cxtEdit.Click
			OpenEditForm()
		End Sub

		Private Sub htmluiControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles htmluiControl1.KeyDown
			If e.Alt = True AndAlso e.KeyCode = Keys.E Then
				OpenEditForm()
			End If
		End Sub
		#End Region

		#Region "ClassMethods"
		''' <summary>
		''' Loads the main HTMLUI control with the specified file
		''' </summary>
		''' <param name="fileName">Name of the file to be loaded.</param>
		Private Sub LoadFromFile(ByVal fileName As String)
			Dim filePath As String = GetFilesLocation() & fileName
			Me.htmluiControl1.LoadHTML(filePath)
		End Sub

		''' <summary>
		''' Gets the project location
		''' </summary>
		''' <returns>string</returns>
		Private Shared Function GetFilesLocation() As String
			Dim path As String
			path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
			Dim slashPos As Integer = path.LastIndexOf("\",path.Length)
			slashPos = path.LastIndexOf("\",slashPos-1)
			slashPos = path.LastIndexOf("\",slashPos-1)
			If slashPos > 0 Then
				path = path.Substring(0,slashPos)
			End If
			path = path.Replace("file:\", "")
			path = path & "\files\"
			Return path
		End Function

		''' <summary>
		''' Opens the editor dialog to edit the html.
		''' </summary>
		Private Sub OpenEditForm()
			Dim edit As editForm = New editForm(Me.htmluiControl1.Text)
			If edit.ShowDialog() = DialogResult.OK Then
				Me.htmluiControl1.LoadFromString(edit.newHtml.ToString())
			End If
		End Sub
		#End Region
	End Class
End Namespace
