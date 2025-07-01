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
Imports System.Collections
Imports System.Xml
Imports DemoCommon.Diagram

Namespace ExpanderDemo
	Partial Public Class Form1
		Inherits DemoForm
		#Region "Members"
		Protected dtLayoutMgr As OrgChartLayoutManager
		#End Region

		#Region "Form initialize"
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			diagram1.BeginUpdate()
			diagram1.View.Grid.Visible = False
			diagram1.View.BackgroundColor = Color.White

			comboDirection.SelectedIndex = 0
			AddHandler diagram1.MouseMove, AddressOf diagram1_MouseMove
			AddHandler diagram1.EventSink.NodeMouseEnter, AddressOf EventSink_NodeMouseEnter
			diagram1.Model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
			diagram1.Model.BoundaryConstraintsEnabled = False
			For i As Integer = 0 To 11
				Dim expander As New ExpanderNode(New RectangleF(0, 0, 90, 60))
				expander.Name = i.ToString()
				diagram1.Model.AppendChild(expander)
			Next i

			Connect(diagram1.Model.Nodes("0"), diagram1.Model.Nodes("1"))
			Connect(diagram1.Model.Nodes("0"), diagram1.Model.Nodes("2"))
			Connect(diagram1.Model.Nodes("2"), diagram1.Model.Nodes("3"))
			Connect(diagram1.Model.Nodes("2"), diagram1.Model.Nodes("4"))
			Connect(diagram1.Model.Nodes("2"), diagram1.Model.Nodes("5"))
			Connect(diagram1.Model.Nodes("5"), diagram1.Model.Nodes("6"))
			Connect(diagram1.Model.Nodes("5"), diagram1.Model.Nodes("7"))
			Connect(diagram1.Model.Nodes("1"), diagram1.Model.Nodes("8"))
			Connect(diagram1.Model.Nodes("1"), diagram1.Model.Nodes("9"))
			Connect(diagram1.Model.Nodes("1"), diagram1.Model.Nodes("10"))
			Connect(diagram1.Model.Nodes("1"), diagram1.Model.Nodes("11"))

			LayoutNodes()

			diagram1.EndUpdate()
			AddHandler comboDirection.SelectedIndexChanged, AddressOf comboDirection_SelectedIndexChanged
		End Sub
		#End Region

		#Region "Private methods"
		''' <summary>
		''' Change's the appearance of Diagram
		''' </summary>
		Private Sub DiagramAppearance()
			Me.diagram1.MetroScrollBars = True
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.View.Grid.GridStyle = GridStyle.Line
			Me.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			Me.diagram1.View.Grid.Color = Color.LightGray
			Me.diagram1.View.Grid.VerticalSpacing = 15
			Me.diagram1.View.Grid.HorizontalSpacing = 15
			Me.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f
            Me.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue
            Me.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.BoundaryConstraintsEnabled = False
			diagram1.View.BackgroundColor = Color.White
			Me.diagram1.View.SelectionList.Clear()

		End Sub
		#End Region

		#Region "Initialize Diagram"

		''' <summary>
		''' Apply layout to the Diagram
		''' </summary>
		Private Sub LayoutNodes()
			diagram1.View.SelectionList.Clear()
			Dim layout As New OrgChartLayoutManager(diagram1.Model, RotateDirection.TopToBottom, 30, 80)
			layout.LeftMargin = 10
			layout.TopMargin = 50
			diagram1.LayoutManager = layout
            layout.AutoLayout = True
			'diagram1.LayoutManager.AutoLayout = true;
			diagram1.LayoutManager.UpdateLayout(Nothing)
		End Sub

		''' <summary>
		''' Connects the two nodes with connector
		''' </summary>
		''' <param name="parent">From Node</param>
		''' <param name="child">To Node</param>
		Private Sub Connect(ByVal parent As Node, ByVal child As Node)
			Dim link As New OrgLineConnector(PointF.Empty, New PointF(1, 1))
			link.LineStyle.LineWidth = 2
			link.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow
			link.HeadDecorator.FillStyle.Color = Color.Gray
			link.HeadDecorator.LineStyle.LineColor = Color.LightGray
			link.HeadDecorator.Size = New SizeF(8, 8)
			link.LineStyle.LineColor = Color.LightGray
			parent.CentralPort.Connect(link.TailEndPoint)
			child.CentralPort.Connect(link.HeadEndPoint)
			link.EditStyle.AllowSelect = False
			diagram1.Model.AppendChild(link)
		End Sub

		#End Region

		#Region "Event Handlers      "

		Private Sub comboDirection_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim mgr As OrgChartLayoutManager = TryCast(diagram1.LayoutManager, OrgChartLayoutManager)
			If mgr IsNot Nothing Then
				If comboDirection.SelectedIndex = 0 Then
					mgr.RotateDirection = RotateDirection.TopToBottom
				End If
				If comboDirection.SelectedIndex = 1 Then
					mgr.RotateDirection = RotateDirection.BottomToTop
				End If
				If comboDirection.SelectedIndex = 2 Then
					mgr.RotateDirection = RotateDirection.LeftToRight
				End If
				If comboDirection.SelectedIndex = 3 Then
					mgr.RotateDirection = RotateDirection.RightToLeft
				End If
				mgr.UpdateLayout(Nothing)
			End If
		End Sub

		Private Sub EventSink_NodeMouseEnter(ByVal evtArgs As Syncfusion.Windows.Forms.Diagram.NodeMouseEventArgs)
			diagram1.Controller.ActiveTool.ActionCursor = Cursors.Arrow
		End Sub

		Private Sub diagram1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim node As ExpanderNode = TryCast(diagram1.Controller.GetNodeAtPoint(diagram1.Controller.ConvertToModelCoordinates(e.Location)), ExpanderNode)
			If node IsNot Nothing Then
				node.MouseMove(diagram1.Controller.ConvertToModelCoordinates(e.Location))
			End If
		End Sub


		#End Region

	End Class
End Namespace