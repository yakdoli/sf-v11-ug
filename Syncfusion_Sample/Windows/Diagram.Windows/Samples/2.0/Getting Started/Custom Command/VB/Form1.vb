Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram
Imports Syncfusion.Windows.Forms
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Threading
Imports System.Globalization
Imports System.Resources
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Diagram.Controls

Namespace CustomCommand
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			' Sets the culture to French (France)
			Thread.CurrentThread.CurrentCulture = New CultureInfo("ar-EG")
			' Sets the UI culture to French (France)
			Thread.CurrentThread.CurrentUICulture = New CultureInfo("ar-EG")

			InitializeComponent()
			Me.diagram1.HScroll = False
			Me.diagram1.VScroll = False
			Me.diagram1.Model = Me.model1
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' 
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			AddHandler Application.Idle, AddressOf Application_Idle

		End Sub

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			' Sets the culture to French (France)
			Thread.CurrentThread.CurrentCulture = New CultureInfo("ar-EG")
			' Sets the UI culture to French (France)
			Thread.CurrentThread.CurrentUICulture = New CultureInfo("ar-EG")
			Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub

		#Region "Class Events"
		''' <summary>
		''' Loads the Symbol palette into the palettegroupBar
		''' </summary>
		Protected Sub LoadSymbolPalette()
			' Create a SymbolPalette for the PaletteGroupView control
			Me.paletteGroupBar1.LoadPalette("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Flowchart Symbols.edp")


		End Sub

		Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
			' update UI
			Dim strBIText As String = "Undo"

			Dim strDescriptions() As String
			Dim nDescWanted As Integer = 1
			Dim nDescReturned As Integer = Me.diagram1.Model.HistoryManager.GetUndoDescriptions(nDescWanted, strDescriptions)

			If nDescReturned = nDescWanted Then
				strBIText = strBIText & " " & strDescriptions(0)
			End If

			undoToolStripMenuItem.Text = strBIText

			If nDescReturned = 0 Then
				undoToolStripMenuItem.Enabled = False
			Else
				undoToolStripMenuItem.Enabled = True
			End If

			strBIText = "Redo"
			' clear strDecsriptions.
			nDescReturned = Me.diagram1.Model.HistoryManager.GetRedoDescriptions(nDescWanted, strDescriptions)
			If nDescReturned = nDescWanted Then
				strBIText = strBIText & " " & strDescriptions(0)
			End If

			redoToolStripMenuItem.Text = strBIText

            If Not nDescReturned = 0 Then
                redoToolStripMenuItem.Enabled = True
            Else
                redoToolStripMenuItem.Enabled = False
            End If
		End Sub



		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.LoadSymbolPalette()

			Me.paletteGroupBar1.BorderColor = System.Drawing.ColorTranslator.FromHtml("#119EDA")
			For Each item As GroupBarItem In paletteGroupBar1.GroupBarItems
				'palette view settings
				If TypeOf item.Client Is PaletteGroupView Then
					Dim view As PaletteGroupView = TryCast(item.Client, PaletteGroupView)
					view.Font = New Font("Segoe UI", 9, System.Drawing.FontStyle.Regular)
					view.ForeColor = Color.Black
					view.FlowView = True
					view.ShowToolTips = True
					view.ShowFlowViewItemText = True
					view.SelectedItemColor = Color.FromArgb(255, 219, 118)
					view.HighlightItemColor = Color.FromArgb(255, 227, 149)
					view.SelectingItemColor = Color.FromArgb(255, 238, 184)
					view.SelectedHighlightItemColor = Color.FromArgb(255, 218, 115)
					view.FlowViewItemTextLength = 80
					view.BackColor = Color.White
					view.TextWrap = True
					view.FlatLook = True
					view.BorderStyle = BorderStyle.FixedSingle
				End If
			Next item

		End Sub

		Private Sub undoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles undoToolStripMenuItem.Click
			Me.diagram1.Model.HistoryManager.Undo()
		End Sub

		Private Sub redoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles redoToolStripMenuItem.Click
			Me.diagram1.Model.HistoryManager.Redo()
		End Sub

		Private Sub startAtomicActionToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles startAtomicActionToolStripMenuItem.Click
			Me.diagram1.Model.HistoryManager.StartAtomicAction("Custom Action")
		End Sub

		Private Sub endAtomicActionToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles endAtomicActionToolStripMenuItem.Click
			Me.diagram1.Model.HistoryManager.EndAtomicAction()
		End Sub


		#End Region


	End Class
End Namespace
