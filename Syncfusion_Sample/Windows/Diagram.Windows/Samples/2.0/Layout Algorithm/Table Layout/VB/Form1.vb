Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing.Imaging
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports System.Drawing.Drawing2D
Imports Syncfusion.Windows.Forms
Imports System.IO
Imports System.Drawing.Printing
Imports Syncfusion.SVG.IO
Imports DemoCommon.Diagram

Namespace TableLayout
	Partial Public Class Form1
		Inherits DemoForm
		#Region "Members       "

		#End Region

		#Region "Form Initialize"
		Public Sub New()
			InitializeComponent()

			diagram1.BeginUpdate()

			DiagramAppearance()
			PopulateNodes()
			Me.diagram1.View.SelectionList.Clear()

			Dim tlLayout As New TableLayoutManager(Me.diagram1.Model, 5, 5)
			tlLayout.LeftMargin = 50
			tlLayout.TopMargin = 120
			tlLayout.VerticalSpacing = 0
			tlLayout.HorizontalSpacing = 0
			tlLayout.CellSizeMode = CellSizeMode.EqualToMaxNode
			tlLayout.Orientation = Orientation.Horizontal
			tlLayout.MaxSize = New SizeF(1300, 600)
			Me.diagram1.LayoutManager = tlLayout
			Me.diagram1.LayoutManager.UpdateLayout(Nothing)

			txtHSpacing.Text = tlLayout.HorizontalSpacing.ToString()
			txtVSpacing.Text = tlLayout.VerticalSpacing.ToString()
			txtLMarigin.Text = tlLayout.LeftMargin.ToString()
			txtTMarigin.Text = tlLayout.TopMargin.ToString()
			chkAutoLayout.Checked = tlLayout.AutoLayout
			comboCellSize.SelectedIndex = 0
			comboExpandMode.SelectedIndex = 0
			diagram1.EndUpdate()
		End Sub

		#End Region

		''' <summary>
		''' Change's the appearance of Diagram
		''' </summary>
		Private Sub DiagramAppearance()
			Me.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.Model.BoundaryConstraintsEnabled = False
			Me.diagram1.View.BackgroundColor = Color.White

		End Sub

		#Region "Initialize Diagram"

		''' <summary>
		''' Initialize the nodes in daigram
		''' </summary>
		Private Sub PopulateNodes()
			Dim rect As Syncfusion.Windows.Forms.Diagram.Rectangle = GetRectangle()
			diagram1.Model.AppendChild(rect)
			For i As Integer = 0 To 2
				Dim rect1 As Syncfusion.Windows.Forms.Diagram.Rectangle = GetRectangle()
				AddLabel(rect1, "Header Label")
				diagram1.Model.AppendChild(rect1)
			Next i
			Dim rect2 As Syncfusion.Windows.Forms.Diagram.Rectangle = GetRectangle()
			diagram1.Model.AppendChild(rect2)
			Dim nodeNumber As Integer = 1
			For i As Integer = 1 To 20
				If i = 1 Then
					Dim rect1 As Syncfusion.Windows.Forms.Diagram.Rectangle = GetRectangle()
					AddLabel(rect1, "Add")
					diagram1.Model.AppendChild(rect1)
				ElseIf (i - 1) Mod 5 = 0 Then
					Dim rect1 As Syncfusion.Windows.Forms.Diagram.Rectangle = GetRectangle()
					AddLabel(rect1, nodeNumber.ToString())
					diagram1.Model.AppendChild(rect1)
					nodeNumber += 1

				ElseIf i Mod 5 = 0 Then
					Dim rect1 As Syncfusion.Windows.Forms.Diagram.Rectangle = GetRectangle()
					AddLabel(rect1, "Action")
					diagram1.Model.AppendChild(rect1)

				Else
					Dim rect1 As Syncfusion.Windows.Forms.Diagram.Rectangle = GetRectangle()
					AddLabel(rect1, "Component")
					diagram1.Model.AppendChild(rect1)
				End If

			Next i
		End Sub

		''' <summary>
		''' Adds the Label to the given node
		''' </summary>
		''' <param name="rect1">Node</param>
		''' <param name="Text">Label's text</param>
		Private Shared Sub AddLabel(ByVal rect1 As Syncfusion.Windows.Forms.Diagram.Rectangle, ByVal Text As String)
			Dim label As New Syncfusion.Windows.Forms.Diagram.Label(rect1, Text)
			label.FontStyle.Family = "Segoe UI"
			' label.FontStyle.Size = 8;
			label.FontColorStyle.Color = Color.Black
			rect1.Labels.Add(label)
		End Sub

		''' <summary>
		''' Gets the new rectangle node
		''' </summary>
		''' <returns>returns the node</returns>
		Private Function GetRectangle() As Syncfusion.Windows.Forms.Diagram.Rectangle
			Dim rect As New Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 100, 50)
			rect.FillStyle.Color = Color.FromArgb(242,242,242)
			rect.FillStyle.ForeColor = Color.White
			rect.LineStyle.LineColor = Color.Black
			rect.FillStyle.Type = FillStyleType.LinearGradient
			'rect.EnableShading = true;
			Return rect
		End Function
		#End Region


		#Region "Event Handlers"

		Private Sub dialog_BeginLayout(ByVal layout As TableLayoutManager)
			Me.diagram1.LayoutManager = layout
			Layouting()
		End Sub

		Private Sub apply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles apply.Click
			Dim cellSizeMode As CellSizeMode = CellSizeMode.EqualToMaxNode
			' get all parameters
			Dim nMaxColumnCount As Integer = Integer.Parse(txtMaxColumnCount.Text)
			Dim nMaxRowsCount As Integer = Integer.Parse(txtMaxRowsCount.Text)
			Dim orientation As Orientation
			If (comboExpandMode.SelectedIndex = 0) Then
				orientation = Orientation.Horizontal
			Else
				orientation = Orientation.Vertical
			End If
			If comboCellSize.SelectedIndex = 0 Then
				 cellSizeMode = CellSizeMode.EqualToMaxNode
			ElseIf comboCellSize.SelectedIndex = 1 Then
				cellSizeMode = CellSizeMode.Minimal
			ElseIf comboCellSize.SelectedIndex = 2 Then
				cellSizeMode = CellSizeMode.MinimalTable
			End If

			Dim m_layoutManager As TableLayoutManager = TryCast(diagram1.LayoutManager, TableLayoutManager)
			m_layoutManager.MaxColummnCount = nMaxColumnCount
			m_layoutManager.MaxRowsCount = nMaxRowsCount
			m_layoutManager.CellSizeMode = cellSizeMode
			m_layoutManager.HorizontalSpacing = Single.Parse(txtHSpacing.Text)
			m_layoutManager.VerticalSpacing = Single.Parse(txtVSpacing.Text)
			m_layoutManager.LeftMargin = Single.Parse(txtLMarigin.Text)
			m_layoutManager.TopMargin = Single.Parse(txtTMarigin.Text)
			m_layoutManager.MaxSize = New SizeF(Single.Parse(txtMaxWidth.Text), Single.Parse(txtMaxHeight.Text))
			m_layoutManager.Orientation = orientation
			m_layoutManager.AutoLayout = chkAutoLayout.Checked
			Layouting()
		End Sub
		#End Region

		#Region "Helper Methods"

		Private Sub Layouting()
			Me.diagram1.LayoutManager.UpdateLayout(Nothing)
			Me.diagram1.UpdateView()
		End Sub
		#End Region       

	End Class
End Namespace