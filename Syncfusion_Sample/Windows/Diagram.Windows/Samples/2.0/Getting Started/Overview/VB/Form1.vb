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


Namespace Overview
	Partial Public Class Form1
		Inherits DemoForm

		#Region "Form Initialize"
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			diagram1.BeginUpdate()
			Me.overviewControl1.Diagram = Me.diagram1

			PopulateNodes()
			DiagramAppearance()

			Dim dtLayoutManager As New DirectedTreeLayoutManager(Me.diagram1.Model, 0, 40, 20, LayoutType.Horizontal, 1)
			dtLayoutManager.VerticalSpacing = 75
			dtLayoutManager.TopMargin = 30
			dtLayoutManager.LeftMargin = 10
			Me.diagram1.LayoutManager = dtLayoutManager
			Me.diagram1.LayoutManager.UpdateLayout(Nothing)

			diagram1.EndUpdate()
		End Sub
		#End Region

		#Region "Private Methods"
		''' <summary>
		''' Change's the appearance of Diagram
		''' </summary>
		Private Sub DiagramAppearance()
			Me.diagram1.Model.LineStyle.LineColor = Color.LightGray
			Me.diagram1.HorizontalRuler.BackgroundColor = Color.White
			Me.diagram1.VerticalRuler.BackgroundColor = Color.White
			Me.diagram1.View.Grid.GridStyle = GridStyle.Line
			Me.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			Me.diagram1.View.Grid.Color = Color.LightGray
			Me.diagram1.View.Grid.VerticalSpacing = 15
			Me.diagram1.View.Grid.HorizontalSpacing = 15
			Me.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f
			Me.diagram1.View.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.Model.DocumentSize = New PageSize(Me.diagram1.View.ClientRectangle.Size.Width-5, diagram1.View.ClientRectangle.Size.Height-5)
			Me.diagram1.Model.BoundaryConstraintsEnabled = False
			Me.diagram1.Model.MinimumSize = diagram1.View.ClientRectangle.Size
			Me.diagram1.Model.SizeToContent = True
			Me.diagram1.View.SelectionList.Clear()
		End Sub
		#End Region

		#Region "Initialize Diagram"
		''' <summary>
		''' Populate a nodes
		''' </summary>
		Private Sub PopulateNodes()
			'first level of nodes
			Dim parentNode As Syncfusion.Windows.Forms.Diagram.Rectangle = GetRectangle()
			Me.diagram1.Model.AppendChild(parentNode)

			For i As Integer = 1 To 5
				' Create a new instance of rectangle for childnode
				Dim rect As Syncfusion.Windows.Forms.Diagram.Rectangle = GetRectangle()
				Me.diagram1.Model.AppendChild(rect)
				ConnectNodes(parentNode, rect, Color.SteelBlue)
				For j As Integer = 1 To 2
					'Create a new instance of rectangle for childnode1
					Dim rect1 As Syncfusion.Windows.Forms.Diagram.Rectangle = GetRectangle()
					Me.diagram1.Model.AppendChild(rect1)
					ConnectNodes(rect, rect1, Color.SteelBlue)

					For k As Integer = 1 To 3
						'Create a new instance of rectangle for childnode2
						Dim rect2 As Syncfusion.Windows.Forms.Diagram.Rectangle = GetRectangle()
						Me.diagram1.Model.AppendChild(rect2)
						ConnectNodes(rect1, rect2, Color.SteelBlue)

						If k = 2 Then
							For l As Integer = 1 To 2
								'Create a new instance of rectangle for childnode3
								Dim rect3 As Syncfusion.Windows.Forms.Diagram.Rectangle = GetRectangle()
								Me.diagram1.Model.AppendChild(rect3)
								ConnectNodes(rect2, rect3, Color.SteelBlue)
							Next l
						End If
					Next k
				Next j

			Next i
		End Sub

		''' <summary>
		''' New function for create a rectangle
		''' </summary>
		''' <returns></returns>
		Private Function GetRectangle() As Syncfusion.Windows.Forms.Diagram.Rectangle
			Dim rect As New Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 40, 40)
			rect.FillStyle.Color = Color.FromArgb(94, 181, 193)
			rect.FillStyle.ForeColor = Color.FromArgb(63, 152, 165)
			rect.FillStyle.Type = FillStyleType.LinearGradient
			rect.LineStyle.LineColor = Color.SteelBlue
			'rect.EnableShading = true;
			Return rect
		End Function
		''' <summary>
		''' connect the nodes.
		''' </summary>
		''' <param name="parentNode">parentNode</param>
		''' <param name="childNode">childNode</param>
		''' <param name="connectionColor">ConnectionColor between parentNode and childNode</param>
		Private Sub ConnectNodes(ByVal parentNode As Node, ByVal childNode As Node, ByVal connectionColor As Color)
			If parentNode IsNot Nothing AndAlso childNode IsNot Nothing Then
				Dim lConnector As New OrgLineConnector(PointF.Empty, New PointF(0, 1))
				lConnector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow
				lConnector.LineStyle.LineColor = connectionColor
				lConnector.CentralPort.ConnectionsLimit = 10000
				lConnector.HeadDecorator.Size = New SizeF(10, 10)
				lConnector.HeadDecorator.FillStyle.Color = Color.FromArgb(140, 180, 210)
				lConnector.HeadDecorator.LineStyle.LineColor = Color.SteelBlue
				parentNode.CentralPort.TryConnect(lConnector.TailEndPoint)
				childNode.CentralPort.TryConnect(lConnector.HeadEndPoint)
				Me.diagram1.Model.AppendChild(lConnector)
				Me.diagram1.Model.SendToBack(lConnector)
			End If
		End Sub
		#End Region
	End Class

End Namespace
