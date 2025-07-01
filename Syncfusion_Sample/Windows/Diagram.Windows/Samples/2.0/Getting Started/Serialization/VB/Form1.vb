Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Drawing.Printing
Imports System.Drawing.Imaging
Imports Syncfusion.SVG.IO
Imports Syncfusion.Windows.Forms
Imports System.Collections
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Xml

Namespace Serialization
	Partial Public Class Form1
		Inherits Form
		#Region "Members"
'INSTANT VB NOTE: The variable fileName was renamed since Visual Basic does not allow class members with the same name:
		Private fileName_Renamed As String = Nothing
		Private promptOnSave As Boolean = True
		#End Region

		#Region "Form Initialize"
		Public Sub New()
			InitializeComponent()
			Me.diagram1.Model = Me.model1
			Me.FileName = "Diagram1"
			' Load Palette
			Me.paletteGroupBar1.LoadPalette("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Flowchart Symbols.edp")
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			diagram1.BeginUpdate()
			DiagramAppearance()
			GroupBarAppearance()
			diagram1.EndUpdate()
		End Sub
		#End Region

		#Region "Private Methods"

		''' <summary>
		''' Change's the appearance of the Diagram 
		''' </summary>
		Private Sub DiagramAppearance()
			Me.diagram1.Model.LineStyle.LineColor = Color.LightGray
			Me.diagram1.View.Grid.GridStyle = GridStyle.Line
			Me.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			Me.diagram1.View.Grid.Color = Color.LightGray
			Me.diagram1.View.Grid.VerticalSpacing = 15
			Me.diagram1.View.Grid.HorizontalSpacing = 15
			Me.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f
			Me.diagram1.View.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.View.SelectionList.Clear()
		End Sub

		''' <summary>
		''' Change's the appearance of the GroupBarAppearance 
		''' </summary>
		Private Sub GroupBarAppearance()
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
		#End Region

		#Region "Properties"

		Private Property FileName() As String
			Get
				Return Me.fileName_Renamed
			End Get
			Set(ByVal value As String)
				Me.fileName_Renamed = value
				Dim docName As String = Path.GetFileNameWithoutExtension(Me.fileName_Renamed)

			End Set
		End Property
		#End Region

		#Region "Event Handlers"
		Private Sub newToolStripButton_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles newToolStripButton.Click
			Me.diagram1.Model.Clear()
		End Sub

		Private Sub openToolStripButton_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles openToolStripButton.Click
            openFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml"
            If Me.openFileDialog1.ShowDialog(Me) = DialogResult.OK Then
                Me.FileName = Me.openFileDialog1.FileName
                Select Case saveFileDialog1.FilterIndex
                    Case 1
                        diagram1.LoadBinary(Me.FileName)
                    Case 2
                        diagram1.LoadSoap(Me.FileName)
                End Select
                Me.promptOnSave = False
                Me.diagram1.Refresh()
            End If
		End Sub

		Private Sub saveToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveToolStripButton.Click
            If Me.promptOnSave Then
                Me.saveFileDialog1.FileName = Me.FileName
                saveFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml"
                If Me.saveFileDialog1.ShowDialog(Me) = DialogResult.OK Then
                    Me.FileName = Me.saveFileDialog1.FileName
                    Select Case saveFileDialog1.FilterIndex
                        Case 1
                            diagram1.SaveBinary(Me.FileName)
                        Case 2
                            diagram1.SaveSoap(Me.FileName)
                    End Select
                End If
                Me.promptOnSave = False
            Else
                Dim fi As New FileInfo(Me.FileName)
                If fi.Extension = ".edp" Then
                    Me.diagram1.SaveBinary(Me.FileName)
                ElseIf fi.Extension = ".xml" Then
                    Me.diagram1.SaveSoap(Me.FileName)
                End If

            End If
		End Sub


		Private Sub saveAsToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveAsToolStripButton.Click
            Me.saveFileDialog1.FileName = Me.FileName
            saveFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml"
            If Me.saveFileDialog1.ShowDialog(Me) = DialogResult.OK Then
                Me.FileName = Me.saveFileDialog1.FileName
                Select Case saveFileDialog1.FilterIndex
                    Case 1
                        diagram1.SaveBinary(Me.FileName)
                    Case 2
                        diagram1.SaveSoap(Me.FileName)
                End Select
            End If
		End Sub

		#End Region


	End Class
End Namespace
