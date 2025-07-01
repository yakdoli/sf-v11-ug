Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Xml
Imports System.IO

Imports Syncfusion.Windows.Forms.Edit
Imports Syncfusion.Windows.Forms.Edit.Enums
Imports Syncfusion.Windows.Forms.Edit.Utils.CodeSnippets
Imports Syncfusion.XmlSerializersCreator


Namespace CodeSnippetsDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl


		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Private csharpsnippetsPath As String=Path.GetDirectoryName(Application.ExecutablePath)+"\..\..\Snippets\C#"
		Private vbsnippetsPath As String=Path.GetDirectoryName(Application.ExecutablePath)+"\..\..\Snippets\VB"
		Private configPath As String=Path.GetDirectoryName(Application.ExecutablePath)+"..\..\..\config.xml"

		Private mainMenu1 As System.Windows.Forms.MainMenu
		Private menuItem1 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem4 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
		Private menuItem6 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem7 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem8 As System.Windows.Forms.MenuItem
		Private menuItem18 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem12 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem13 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem14 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem10 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem11 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem15 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem16 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem17 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem20 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem21 As System.Windows.Forms.MenuItem
		Private menuItem9 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem22 As System.Windows.Forms.MenuItem
		Private menuItem23 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem24 As System.Windows.Forms.MenuItem
		Private menuItem25 As System.Windows.Forms.MenuItem
		Private container As CodeSnippetsContainer = New Syncfusion.Windows.Forms.Edit.Utils.CodeSnippets.CodeSnippetsContainer()

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			Me.editControl1.Configurator.Open(configPath)
			Me.editControl1.ApplyConfiguration("C#")
			Me.editControl1.Language.SnippetsContainer.RemoveContainer("Container 1")
			Me.editControl1.Language.SnippetsContainer.RemoveContainer("Container 2")
			Me.editControl1.Language.SnippetsContainer.RemoveSnippet("if")
			Me.editControl1.Language.SnippetsContainer.RemoveSnippet("try")
			Me.editControl1.Text="/* Choose any desired Code Snippet from the Code Snippets Menu. Press Ctrl + ` to see the Code Snippets. Press Enter to insert the selected Code Snippet into the EditControl*/" & Constants.vbLf


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
			Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
			Me.mainMenu1 = New System.Windows.Forms.MainMenu()
			Me.menuItem1 = New System.Windows.Forms.MenuItem()
			Me.menuItem2 = New System.Windows.Forms.MenuItem()
			Me.menuItem3 = New System.Windows.Forms.MenuItem()
			Me.menuItem4 = New System.Windows.Forms.MenuItem()
			Me.menuItem5 = New System.Windows.Forms.MenuItem()
			Me.menuItem6 = New System.Windows.Forms.MenuItem()
			Me.menuItem7 = New System.Windows.Forms.MenuItem()
			Me.menuItem8 = New System.Windows.Forms.MenuItem()
			Me.menuItem9 = New System.Windows.Forms.MenuItem()
			Me.menuItem12 = New System.Windows.Forms.MenuItem()
			Me.menuItem13 = New System.Windows.Forms.MenuItem()
			Me.menuItem14 = New System.Windows.Forms.MenuItem()
			Me.menuItem11 = New System.Windows.Forms.MenuItem()
			Me.menuItem22 = New System.Windows.Forms.MenuItem()
			Me.menuItem10 = New System.Windows.Forms.MenuItem()
			Me.menuItem18 = New System.Windows.Forms.MenuItem()
			Me.menuItem15 = New System.Windows.Forms.MenuItem()
			Me.menuItem16 = New System.Windows.Forms.MenuItem()
			Me.menuItem17 = New System.Windows.Forms.MenuItem()
			Me.menuItem20 = New System.Windows.Forms.MenuItem()
			Me.menuItem21 = New System.Windows.Forms.MenuItem()
			Me.menuItem23 = New System.Windows.Forms.MenuItem()
			Me.menuItem24 = New System.Windows.Forms.MenuItem()
			Me.menuItem25 = New System.Windows.Forms.MenuItem()
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' editControl1
			' 
			Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.editControl1.DropAllFiles = False
			Me.editControl1.FileExtensions = New String() { ".cs", ".htm", ".html", ".java", ".js", ".pas", ".sql", ".vb", ".vbs", ".xml"}
			Me.editControl1.Name = "editControl1"
			Me.editControl1.SaveOnClose = False
			Me.editControl1.Size = New System.Drawing.Size(542, 466)
			Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
			Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
			Me.editControl1.TabIndex = 0
			Me.editControl1.Text = ""
			Me.editControl1.WordWrap = True
			' 
			' mainMenu1
			' 
			Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem1, Me.menuItem9, Me.menuItem18})
			' 
			' menuItem1
			' 
			Me.menuItem1.Index = 0
			Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem8})
			Me.menuItem1.Text = "&File"
			' 
			' menuItem2
			' 
			Me.menuItem2.Index = 0
			Me.menuItem2.Text = "&New"
'			Me.menuItem2.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem3
			' 
			Me.menuItem3.Index = 1
			Me.menuItem3.Text = "&Open"
'			Me.menuItem3.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem4
			' 
			Me.menuItem4.Index = 2
			Me.menuItem4.Text = "&Save"
'			Me.menuItem4.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem5
			' 
			Me.menuItem5.Index = 3
			Me.menuItem5.Text = "Save &As"
'			Me.menuItem5.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem6
			' 
			Me.menuItem6.Index = 4
			Me.menuItem6.Text = "-"
			' 
			' menuItem7
			' 
			Me.menuItem7.Index = 5
			Me.menuItem7.Text = "&Close"
'			Me.menuItem7.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem8
			' 
			Me.menuItem8.Index = 6
			Me.menuItem8.Text = "E&xit"
'			Me.menuItem8.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem9
			' 
			Me.menuItem9.Index = 1
			Me.menuItem9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem12, Me.menuItem13, Me.menuItem14, Me.menuItem11, Me.menuItem22, Me.menuItem23, Me.menuItem10})
			Me.menuItem9.Text = "C# Code Snippets"
			' 
			' menuItem12
			' 
			Me.menuItem12.Index = 0
			Me.menuItem12.Text = "Class"
'			Me.menuItem12.Click += New System.EventHandler(Me.CSharpCodeSnippets_Click);
			' 
			' menuItem13
			' 
			Me.menuItem13.Index = 1
			Me.menuItem13.Text = "Struct"
'			Me.menuItem13.Click += New System.EventHandler(Me.CSharpCodeSnippets_Click);
			' 
			' menuItem14
			' 
			Me.menuItem14.Index = 2
			Me.menuItem14.Text = "Try"
'			Me.menuItem14.Click += New System.EventHandler(Me.CSharpCodeSnippets_Click);
			' 
			' menuItem11
			' 
			Me.menuItem11.Index = 3
			Me.menuItem11.Text = "Enum"
'			Me.menuItem11.Click += New System.EventHandler(Me.CSharpCodeSnippets_Click);
			' 
			' menuItem22
			' 
			Me.menuItem22.Index = 4
			Me.menuItem22.Text = "Switch"
'			Me.menuItem22.Click += New System.EventHandler(Me.CSharpCodeSnippets_Click);
			' 
			' menuItem10
			' 
			Me.menuItem10.Index = 6
			Me.menuItem10.Text = "Loops"
'			Me.menuItem10.Click += New System.EventHandler(Me.CSharpCodeSnippets_Click);
			' 
			' menuItem18
			' 
			Me.menuItem18.Index = 2
			Me.menuItem18.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem15, Me.menuItem16, Me.menuItem17, Me.menuItem20, Me.menuItem24, Me.menuItem25, Me.menuItem21})
			Me.menuItem18.Text = "VB.NET Code Snippets"
			' 
			' menuItem15
			' 
			Me.menuItem15.Index = 0
			Me.menuItem15.Text = "Event"
'			Me.menuItem15.Click += New System.EventHandler(Me.VBCodeSnippets_Click);
			' 
			' menuItem16
			' 
			Me.menuItem16.Index = 1
			Me.menuItem16.Text = "Property"
'			Me.menuItem16.Click += New System.EventHandler(Me.VBCodeSnippets_Click);
			' 
			' menuItem17
			' 
			Me.menuItem17.Index = 2
			Me.menuItem17.Text = "Try"
'			Me.menuItem17.Click += New System.EventHandler(Me.VBCodeSnippets_Click);
			' 
			' menuItem20
			' 
			Me.menuItem20.Index = 3
			Me.menuItem20.Text = "Enum"
'			Me.menuItem20.Click += New System.EventHandler(Me.VBCodeSnippets_Click);
			' 
			' menuItem21
			' 
			Me.menuItem21.Index = 6
			Me.menuItem21.Text = "Loops"
'			Me.menuItem21.Click += New System.EventHandler(Me.VBCodeSnippets_Click);
			' 
			' menuItem23
			' 
			Me.menuItem23.Index = 5
			Me.menuItem23.Text = "-"
			' 
			' menuItem24
			' 
			Me.menuItem24.Index = 4
			Me.menuItem24.Text = "Using"
'			Me.menuItem24.Click += New System.EventHandler(Me.VBCodeSnippets_Click);
			' 
			' menuItem25
			' 
			Me.menuItem25.Index = 5
			Me.menuItem25.Text = "-"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(542, 466)
			Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.editControl1})
			Me.Menu = Me.mainMenu1
			Me.Name = "Form1"
			Me.Text = "CodeSnippetsDemo"
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
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
		Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click, menuItem3.Click, menuItem4.Click, menuItem5.Click, menuItem7.Click, menuItem8.Click
			Dim mi As MenuItem = CType(IIf(TypeOf sender Is MenuItem, sender, Nothing), MenuItem)

			Select Case mi.Text
				Case "&New" 
					Me.editControl1.NewFile()
				Case "&Open" 
					Me.editControl1.LoadFile()
				Case "&Save" 
					Me.editControl1.Save()
				Case "Save &As" 
					Me.editControl1.SaveAs()
				Case "&Close" 
					Me.editControl1.Close()
				Case "E&xit" 
					Me.Close()
			End Select
		End Sub

		Private Sub CSharpCodeSnippets_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem12.Click, menuItem13.Click, menuItem14.Click, menuItem11.Click, menuItem22.Click, menuItem10.Click
			Dim mi As MenuItem = CType(IIf(TypeOf sender Is MenuItem, sender, Nothing), MenuItem)

			Me.editControl1.ApplyConfiguration("C#")

			Select Case mi.Text
				Case "Class" 
					RemoveSnippets()
					CodeSnippetsExtractor.CodeSnippetsExtractor.Extract(csharpsnippetsPath & "\Class", Me.editControl1)
				Case "Struct" 
					RemoveSnippets()
					CodeSnippetsExtractor.CodeSnippetsExtractor.Extract(csharpsnippetsPath+"\Struct",Me.editControl1)
				Case "Try" 
					RemoveSnippets()
					CodeSnippetsExtractor.CodeSnippetsExtractor.Extract(csharpsnippetsPath+"\Try",Me.editControl1)
				Case "Enum"
					RemoveSnippets()
					CodeSnippetsExtractor.CodeSnippetsExtractor.Extract(csharpsnippetsPath+"\Enum",Me.editControl1)
				Case "Loops" 
					RemoveSnippets()
					container=CodeSnippetsExtractor.CodeSnippetsExtractor.Extract(csharpsnippetsPath+"\Loops")
					container.Name="Loops"
					Me.editControl1.Language.SnippetsContainer.AddContainer(container)
				Case "Switch"
					RemoveSnippets()
					CodeSnippetsExtractor.CodeSnippetsExtractor.Extract(csharpsnippetsPath+"\Switch",Me.editControl1)


			End Select
		End Sub
		Private Sub RemoveSnippets()
			Dim snippets As ArrayList=Me.editControl1.Language.SnippetsContainer.SnippetsNames
			For Each str As String In snippets
				Me.editControl1.Language.SnippetsContainer.RemoveSnippet(str)
			Next str
		If (Me.editControl1.Language.SnippetsContainer.ContainersNumber)=1 Then
				  Me.editControl1.Language.SnippetsContainer.RemoveContainer("Loops")
		End If


		End Sub
		Private Sub VBCodeSnippets_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem15.Click, menuItem16.Click, menuItem17.Click, menuItem20.Click, menuItem21.Click, menuItem24.Click
			Dim mi As MenuItem = CType(IIf(TypeOf sender Is MenuItem, sender, Nothing), MenuItem)
			Me.editControl1.ApplyConfiguration("VB.NET")
			Select Case mi.Text
				Case "Event" 
					RemoveSnippets()
					CodeSnippetsExtractor.CodeSnippetsExtractor.Extract(vbsnippetsPath & "\Event", Me.editControl1)
				Case "Property" 
					RemoveSnippets()
					CodeSnippetsExtractor.CodeSnippetsExtractor.Extract(vbsnippetsPath+"\Property",Me.editControl1)
				Case "Try" 
					RemoveSnippets()
					CodeSnippetsExtractor.CodeSnippetsExtractor.Extract(vbsnippetsPath+"\Try",Me.editControl1)
				Case "Enum"
					RemoveSnippets()
					CodeSnippetsExtractor.CodeSnippetsExtractor.Extract(vbsnippetsPath+"\Enum",Me.editControl1)
				Case "Loops" 
					RemoveSnippets()
					container=CodeSnippetsExtractor.CodeSnippetsExtractor.Extract(vbsnippetsPath+"\Loops")
					container.Name="Loops"
					Me.editControl1.Language.SnippetsContainer.AddContainer(container)
				Case "Using"
					RemoveSnippets()
					CodeSnippetsExtractor.CodeSnippetsExtractor.Extract(vbsnippetsPath+"\Using",Me.editControl1)
			End Select

		End Sub



	End Class
End Namespace
