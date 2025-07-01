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
Imports System.Xml
Imports System.IO

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Edit
Imports Syncfusion.Windows.Forms.Edit.Enums
Imports Syncfusion.Windows.Forms.Edit.Interfaces
Imports Syncfusion.Windows.Forms.Edit.Implementation



Namespace IntellisenseFromXMLDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private WithEvents editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
		Private components As System.ComponentModel.IContainer
		Private mainMenu1 As System.Windows.Forms.MainMenu
		Private menuItem1 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
		Private menuItem4 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
		Private menuItem7 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem8 As System.Windows.Forms.MenuItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private WithEvents menuItem9 As System.Windows.Forms.MenuItem
		Private reader As XmlTextReader

		Private intellisensePath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\Intellisense.xml"
		Private ConfigPath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\config.xml"

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Me.editControl1.Configurator.Open(ConfigPath)
			Me.editControl1.ApplyConfiguration("CustomLanguage")

			Dim index As Integer=0
			Dim img As Image
			For Each img In Me.imageList1.Images
				' Populating images using an external ImageList
				Me.editControl1.ContextChoiceController.AddImage("Image"+index.ToString(), img)
				index += 1
			Next img

            Me.editControl1.Text = "/* Type 'this' or 'me' and a DOT to see the context choice list. After you type 'this.', select 'Find' (or any of the items)from the context choice list and type a BRACE '(' to see the context prompt  */"
            Me.editControl1.Text &= vbCrLf & vbCrLf
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
			Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
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
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.menuItem9 = New System.Windows.Forms.MenuItem()
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' editControl1
			' 
			Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.editControl1.ChangedLinesMarkingLineColor = System.Drawing.Color.White
			Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.editControl1.MarkLineWrapping = False
			Me.editControl1.MarkWrappedLines = False
			Me.editControl1.Name = "editControl1"
			Me.editControl1.SaveOnClose = False
			Me.editControl1.ShowHorizontalSplitters = False
			Me.editControl1.ShowIndicatorMargin = False
			Me.editControl1.ShowVerticalSplitters = False
			Me.editControl1.Size = New System.Drawing.Size(542, 445)
			Me.editControl1.StatusBarSettings.EncodingPanel.MinWidth = 0
			Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
			Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
			Me.editControl1.TabIndex = 0
			Me.editControl1.Text = ""
			Me.editControl1.WordWrap = True
'			Me.editControl1.ContextChoiceOpen += New Syncfusion.Windows.Forms.Edit.ContextChoiceEventHandler(Me.editControl1_ContextChoiceOpen);
'			Me.editControl1.ContextPromptBeforeOpen += New System.ComponentModel.CancelEventHandler(Me.editControl1_ContextPromptBeforeOpen);
'			Me.editControl1.ContextChoiceBeforeOpen += New System.ComponentModel.CancelEventHandler(Me.editControl1_ContextChoiceBeforeOpen);
'			Me.editControl1.ContextChoiceClose += New Syncfusion.Windows.Forms.Edit.ContextChoiceCloseEventHandler(Me.editControl1_ContextChoiceClose);
'			Me.editControl1.ContextPromptOpen += New Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventHandler(Me.editControl1_ContextPromptOpen);
'			Me.editControl1.ContextChoiceItemSelected += New Syncfusion.Windows.Forms.Edit.ContextChoiceItemSelectedEventHandler(Me.editControl1_ContextChoiceItemSelected);
			' 
			' mainMenu1
			' 
			Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem1})
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
			Me.menuItem4.Text = "-"
			' 
			' menuItem5
			' 
			Me.menuItem5.Index = 3
			Me.menuItem5.Text = "&Save"
'			Me.menuItem5.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem6
			' 
			Me.menuItem6.Index = 4
			Me.menuItem6.Text = "Save&As"
'			Me.menuItem6.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' menuItem7
			' 
			Me.menuItem7.Index = 5
			Me.menuItem7.Text = "-"
			' 
			' menuItem8
			' 
			Me.menuItem8.Index = 7
			Me.menuItem8.Text = "E&xit"
'			Me.menuItem8.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' imageList1
			' 
			Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
			Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			' 
			' menuItem9
			' 
			Me.menuItem9.Index = 6
			Me.menuItem9.Text = "C&lose"
'			Me.menuItem9.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(542, 445)
			Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.editControl1})
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Menu = Me.mainMenu1
			Me.Name = "Form1"
			Me.Text = "Intellisense From XML"
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

		Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click, menuItem3.Click, menuItem5.Click, menuItem6.Click, menuItem8.Click, menuItem9.Click
			Dim mi As MenuItem = CType(IIf(TypeOf sender Is MenuItem, sender, Nothing), MenuItem)

			Select Case mi.Text
				Case "&New" 
					Me.editControl1.NewFile()
				Case "&Open" 
					Me.editControl1.LoadFile()
				Case "&Save" 
					Me.editControl1.Save()
				Case "Save&As" 
					Me.editControl1.SaveAs()
				Case "C&lose" 
					Me.editControl1.Close()
				Case "E&xit" 
					Me.Close()
			End Select
		End Sub

		#Region "Context Choice Implementation"
		Private Sub editControl1_ContextChoiceBeforeOpen(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles editControl1.ContextChoiceBeforeOpen
			Dim lexemLine As ILexemLine = Me.editControl1.GetLine(Me.editControl1.CurrentLine)

			'Gets the index of the current word in that line
			Dim ind As Integer = GetContextChoiceCharIndex(lexemLine)
            If ind <= 0 Then
                e.Cancel = True
                Return
            End If
			Dim lex As ILexem = CType(IIf(TypeOf lexemLine.LineLexems(ind-1) Is ILexem, lexemLine.LineLexems(ind-1), Nothing), ILexem)

			' If the count is less than '2', do not show the ContextChoice popup
			If lexemLine.LineLexems.Count<2 Then
				e.Cancel = True
			Else
				' Display ContextChoice popup if the lexem used to invoke them is "this" or "me" only
				If (lex.Text = "this") OrElse (lex.Text = "me") Then
					e.Cancel = False
				Else
					e.Cancel = True
				End If
			End If

		End Sub


		Private Function GetContextChoiceCharIndex(ByVal line As ILexemLine) As Integer
			Dim lastPos As Integer = -1

			Dim i As Integer=0
'ORIGINAL LINE: for (int i=0; i<line.LineLexems.Count; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i<line.LineLexems.Count
				Dim lex As ILexem = CType(IIf(TypeOf line.LineLexems(i) Is ILexem, line.LineLexems(i), Nothing), ILexem)

				If lex.Text = "." Then
					lastPos = i
				End If
				i += 1
			Loop

			Return lastPos
		End Function

		Private Sub editControl1_ContextChoiceOpen(ByVal controller As Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController) Handles editControl1.ContextChoiceOpen
		   reader = New XmlTextReader(intellisensePath)
			Do While reader.Read()
				Dim itemname As String="", tooltip As String=""
				Select Case reader.NodeType
					Case(XmlNodeType.Element)

						If reader.Name="Items" Then
							If reader.AttributeCount>0 Then
								Do While reader.MoveToNextAttribute()
									If reader.Name="Name" Then
										itemname=reader.Value
									End If
									If reader.Name="Tooltip" Then
										tooltip=reader.Value
									End If
									If reader.Name="Image" Then
										controller.Items.Add(itemname,tooltip,Me.editControl1.ContextChoiceController.Images(reader.Value))
									End If
								Loop
							End If
						End If


				End Select
			Loop

		End Sub

		Private Sub editControl1_ContextChoiceItemSelected(ByVal sender As Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController, ByVal e As Syncfusion.Windows.Forms.Edit.ContextChoiceItemSelectedEventArgs) Handles editControl1.ContextChoiceItemSelected
			Console.WriteLine("SelectedItem : " & e.SelectedItem.Text)
		End Sub

		Private Sub editControl1_ContextChoiceClose(ByVal controller As Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController, ByVal dialogresult As System.Windows.Forms.DialogResult) Handles editControl1.ContextChoiceClose
			controller.Items.Clear()
			reader.Close()
		End Sub
		#End Region

		#Region "Context Prompt Implementation"
		Private Function GetContextPromptCharIndex(ByVal line As ILexemLine) As Integer
			Dim lastPos As Integer = -1
			Dim i As Integer=0
'ORIGINAL LINE: for (int i=0; i<line.LineLexems.Count; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i<line.LineLexems.Count
				Dim lex As ILexem = CType(IIf(TypeOf line.LineLexems(i) Is ILexem, line.LineLexems(i), Nothing), ILexem)

				If lex.Text = "(" Then
					lastPos = i
				End If
				i += 1
			Loop

			Return lastPos
		End Function

		Private contextPromptLexem As String = ""
		' Method that populates the context prompt list based on the lexem invoking it
		Private Sub PopulateContextPromptItems(ByVal e As ContextPromptUpdateEventArgs)
			Select Case Me.contextPromptLexem
				Case "Chat" 
					e.List.Clear()
					GetFunctionNames(e)

				Case "Database" 
					e.List.Clear()
					GetFunctionNames(e)
				Case "NewFile" 
					e.List.Clear()
					GetFunctionNames(e)
				Case "Find" 
					e.List.Clear()
					GetFunctionNames(e)
				Case "Home" 
					e.List.Clear()
					GetFunctionNames(e)
				Case "PieChart" 
					e.List.Clear()
					GetFunctionNames(e)
				Case "Tools" 
					e.List.Clear()
					GetFunctionNames(e)
			End Select
		End Sub

'TODO: INSTANT VB TODO TASK: function is a keyword in VB.NET. Change the name or use square brackets to override it:
		Private function_Renamed As String=""
		Private Sub GetFunctionNames(ByVal e As ContextPromptUpdateEventArgs)
			reader = New XmlTextReader(intellisensePath)
			function_Renamed=""
			Dim i As Integer=1
			Do While reader.Read()
				function_Renamed=""
				Select Case reader.NodeType
					Case(XmlNodeType.Element)

						If reader.Name="Function" Then
							reader.MoveToFirstAttribute()
							If reader.Value= Me.contextPromptLexem Then
							 Do While reader.MoveToNextAttribute()
                                    If reader.Name = "overloads" & i Then
                                        function_Renamed = reader.Value

                                    Else

                                        If reader.Name = "Description" & i Then

                                            e.AddPrompt(function_Renamed, reader.Value)
                                            i += 1
                                        End If
                                    End If

                                Loop
							End If
						End If


				End Select
			Loop

		End Sub

		Private Sub editControl1_ContextPromptBeforeOpen(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles editControl1.ContextPromptBeforeOpen
			Dim lexemLine As ILexemLine = Me.editControl1.GetLine(Me.editControl1.CurrentLine)

			'Gets the index of the current word in that line
			Dim ind As Integer = GetContextPromptCharIndex(lexemLine)
            If ind <= 0 Then
                e.Cancel = True
                Return
            End If
			Dim lex As ILexem = CType(IIf(TypeOf lexemLine.LineLexems(ind-1) Is ILexem, lexemLine.LineLexems(ind-1), Nothing), ILexem)

			' If the count is less than '2', do not show the ContextPrompt popup
			If lexemLine.LineLexems.Count<2 Then
				e.Cancel = True
			Else
				' Display ContextChoice popup if the lexem used to invoke them is "this" or "me" only
				If (lex.Text = "Chat") OrElse (lex.Text = "Database") OrElse (lex.Text = "NewFile") OrElse (lex.Text = "Find") OrElse (lex.Text = "Home") OrElse (lex.Text = "PieChart") OrElse (lex.Text = "Tools") Then
					Me.contextPromptLexem = lex.Text
					e.Cancel = False
				Else
					e.Cancel = True
				End If

			End If
		End Sub

		Private Sub editControl1_ContextPromptOpen(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventArgs) Handles editControl1.ContextPromptOpen
			If Me.contextPromptLexem <> "" Then
				PopulateContextPromptItems(e)
			End If
		End Sub
		#End Region
	End Class
End Namespace
