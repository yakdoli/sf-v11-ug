Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports Syncfusion.Text
Imports System.IO

Namespace ClipboardFunctionsDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		#Region "Designer declarations"
		Private mainMenu1 As System.Windows.Forms.MainMenu
		Private menuItem1 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
		Private menuItem4 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
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
		Private menuItem17 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem19 As System.Windows.Forms.MenuItem
		Private WithEvents SpellCheck As MenuItem
		Private WithEvents about As MenuItem
		Private richTextBox1 As RichTextBox
		Private spellChecker1 As Syncfusion.Text.SpellChecker
		Private components As IContainer
		#End Region

		#Region "constructor"
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
		End Sub
		#End Region

		#Region "Destructor"
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub
		#End Region

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
			Me.menuItem11 = New System.Windows.Forms.MenuItem()
			Me.menuItem12 = New System.Windows.Forms.MenuItem()
			Me.menuItem13 = New System.Windows.Forms.MenuItem()
			Me.menuItem14 = New System.Windows.Forms.MenuItem()
			Me.menuItem15 = New System.Windows.Forms.MenuItem()
			Me.menuItem17 = New System.Windows.Forms.MenuItem()
			Me.menuItem19 = New System.Windows.Forms.MenuItem()
			Me.menuItem1 = New System.Windows.Forms.MenuItem()
			Me.menuItem2 = New System.Windows.Forms.MenuItem()
			Me.menuItem3 = New System.Windows.Forms.MenuItem()
			Me.menuItem4 = New System.Windows.Forms.MenuItem()
			Me.menuItem5 = New System.Windows.Forms.MenuItem()
			Me.menuItem6 = New System.Windows.Forms.MenuItem()
			Me.menuItem7 = New System.Windows.Forms.MenuItem()
			Me.menuItem8 = New System.Windows.Forms.MenuItem()
			Me.menuItem9 = New System.Windows.Forms.MenuItem()
			Me.menuItem10 = New System.Windows.Forms.MenuItem()
			Me.SpellCheck = New System.Windows.Forms.MenuItem()
			Me.about = New System.Windows.Forms.MenuItem()
			Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
			Me.spellChecker1 = New Syncfusion.Text.SpellChecker(Me.components)
			Me.SuspendLayout()
			' 
			' mainMenu1
			' 
			Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem11, Me.menuItem1, Me.SpellCheck, Me.about})
			' 
			' menuItem11
			' 
			Me.menuItem11.Index = 0
			Me.menuItem11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem12, Me.menuItem13, Me.menuItem14, Me.menuItem15, Me.menuItem17, Me.menuItem19})
			Me.menuItem11.Text = "File"
			' 
			' menuItem12
			' 
			Me.menuItem12.Index = 0
			Me.menuItem12.Text = "New"
			' 
			' menuItem13
			' 
			Me.menuItem13.Index = 1
			Me.menuItem13.Text = "Open"
			' 
			' menuItem14
			' 
			Me.menuItem14.Index = 2
			Me.menuItem14.Text = "-"
			' 
			' menuItem15
			' 
			Me.menuItem15.Index = 3
			Me.menuItem15.Text = "Save"
			' 
			' menuItem17
			' 
			Me.menuItem17.Index = 4
			Me.menuItem17.Text = "-"
			' 
			' menuItem19
			' 
			Me.menuItem19.Index = 5
			Me.menuItem19.Text = "Exit"
			' 
			' menuItem1
			' 
			Me.menuItem1.Index = 1
			Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem8, Me.menuItem9, Me.menuItem10})
			Me.menuItem1.Text = "&Edit"
			' 
			' menuItem2
			' 
			Me.menuItem2.Index = 0
			Me.menuItem2.Text = "&Undo"
			' 
			' menuItem3
			' 
			Me.menuItem3.Index = 1
			Me.menuItem3.Text = "&Redo"
			' 
			' menuItem4
			' 
			Me.menuItem4.Index = 2
			Me.menuItem4.Text = "-"
			' 
			' menuItem5
			' 
			Me.menuItem5.Index = 3
			Me.menuItem5.Text = "Cu&t"
			' 
			' menuItem6
			' 
			Me.menuItem6.Index = 4
			Me.menuItem6.Text = "&Copy"
			' 
			' menuItem7
			' 
			Me.menuItem7.Index = 5
			Me.menuItem7.Text = "&Paste"
			' 
			' menuItem8
			' 
			Me.menuItem8.Index = 6
			Me.menuItem8.Text = "-"
			' 
			' menuItem9
			' 
			Me.menuItem9.Index = 7
			Me.menuItem9.Text = "Select &All"
			' 
			' menuItem10
			' 
			Me.menuItem10.Index = 8
			Me.menuItem10.Text = "Ca&ncel Selection"
			' 
			' SpellCheck
			' 
			Me.SpellCheck.Index = 2
			Me.SpellCheck.Text = "Spell Check"
			' 
			' about
			' 
			Me.about.Index = 3
			Me.about.Text = "About"
			' 
			' richTextBox1
			' 
			Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richTextBox1.HideSelection = False
			Me.richTextBox1.Location = New System.Drawing.Point(0, 0)
			Me.richTextBox1.Name = "richTextBox1"
			Me.richTextBox1.Size = New System.Drawing.Size(878, 495)
			Me.richTextBox1.TabIndex = 0
			Me.richTextBox1.Text = ""
			' 
			' spellChecker1
			' 
			Me.spellChecker1.DictionaryPath = "Syncfusion_en_us.dic"
			Me.spellChecker1.ExcludeEmailAddress = True
			Me.spellChecker1.ExcludeFileNames = True
			Me.spellChecker1.ExcludeHtmlTags = True
			Me.spellChecker1.ExcludeInternetAddresses = True
			Me.spellChecker1.ExcludeRepeatedWords = True
			Me.spellChecker1.ExcludeSpecialSymbols = True
			Me.spellChecker1.ExcludeWordsInUpperCase = True
			Me.spellChecker1.ExcludeWordsWithNumbers = True
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(878, 495)
			Me.Controls.Add(Me.richTextBox1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Menu = Me.mainMenu1
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Spell Checker Demo"
			Me.ResumeLayout(False)

		End Sub
		#End Region

		#Region "Main"
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub
		#End Region

		#Region "Event Handlers"
		Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem12.Click, menuItem13.Click, menuItem15.Click, menuItem19.Click
			Dim mi As MenuItem = TryCast(sender, MenuItem)

			Select Case mi.Text
				Case "New"
					Me.richTextBox1.Clear()
				Case "Open"
						Dim dlgOpen As New OpenFileDialog()
						dlgOpen.Filter = "Rich Text Format(*.rtf)|(*.rtf)|Text Files(*.txt)|(*.txt)"
						If dlgOpen.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
							Me.richTextBox1.LoadFile(dlgOpen.FileName)
						End If
				Case "Save"
					Dim dlgBrowser As New FolderBrowserDialog()
					If dlgBrowser.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
						Me.richTextBox1.SaveFile(dlgBrowser.SelectedPath + Path.DirectorySeparatorChar & "SpellChecler.rft",RichTextBoxStreamType.RichText)
					End If
				Case "Exit"
					Me.Close()
			End Select
		End Sub

		Private Sub EditMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click, menuItem3.Click, menuItem5.Click, menuItem6.Click, menuItem7.Click, menuItem9.Click, menuItem10.Click
			Dim mi As MenuItem = TryCast(sender, MenuItem)

			Select Case mi.Text
				Case "&Undo"
					Me.richTextBox1.Undo()
				Case "&Redo"
					Me.richTextBox1.Redo()
				Case "Cu&t"
					Me.richTextBox1.Cut()
				Case "&Copy"
					Me.richTextBox1.Copy()
				Case "&Paste"
					Me.richTextBox1.Paste()
				Case "Select &All"
					Me.richTextBox1.SelectAll()
				Case "Ca&ncel Selection"
					Me.richTextBox1.Select(0, 0)
			End Select
		End Sub

		Private Sub SpellCheck_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SpellCheck.Click
			Me.spellChecker1.SpellCheck(New SpellEditorWrapper(Me.richTextBox1))
		End Sub
		Private Sub about_Click(ByVal sender As Object, ByVal e As EventArgs) Handles about.Click
            Dim help As New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
            help.ShowDialog()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.richTextBox1.LoadFile("..\..\..\images\document.rtf", RichTextBoxStreamType.RichText)
		End Sub

		#End Region
	End Class
End Namespace
