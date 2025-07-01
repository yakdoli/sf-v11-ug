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


Namespace DirectedTreeLayout
	Partial Public Class Form1
		Inherits DemoForm

		#Region "Form Initialize"
		Public Sub New()
			InitializeComponent()

			diagram1.BeginUpdate()
			comboLytDirection.SelectedIndex = 0
			DiagramAppearance()
			PopulateNodes()
			Me.diagram1.View.SelectionList.Clear()


			Dim dtlm As New DirectedTreeLayoutManager(Me.diagram1.Model, 0, 50, 60)
			dtlm.TopMargin = 50
			dtlm.LeftMargin = 20
			Me.diagram1.LayoutManager = dtlm
			Me.diagram1.LayoutManager.UpdateLayout(Nothing)

			txtHSpacing.Text = dtlm.HorizontalSpacing.ToString()
			txtVSpacing.Text = dtlm.VerticalSpacing.ToString()
			txtLMarigin.Text = dtlm.LeftMargin.ToString()
			txtTMarigin.Text = dtlm.TopMargin.ToString()
			chkAutoLayout.Checked = dtlm.AutoLayout

			diagram1.EndUpdate()
		End Sub
		#End Region


		#Region "Private Methods"
		''' <summary>
		''' Change's the appearance of Diagram
		''' </summary>
		Private Sub DiagramAppearance()
			Me.diagram1.Model.LineStyle.LineColor = Color.LightGray
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.Model.BoundaryConstraintsEnabled = False
			Me.diagram1.View.BackgroundColor = Color.White
			Me.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.View.SelectionList.Clear()
		End Sub
		#End Region

		#Region "Initialize Diagram"

		''' <summary>
		''' Initialize the nodes in daigram
		''' </summary>
		Private Sub PopulateNodes()
			'first level of nodes
			Dim rectNode1 As New Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 100, 60)
			rectNode1.FillStyle.Color = Color.FromArgb(242,242,242)
			rectNode1.FillStyle.Type = FillStyleType.LinearGradient
			rectNode1.FillStyle.ForeColor = Color.White
			rectNode1.FillStyle.GradientAngle = 90
			rectNode1.FillStyle.GradientCenter = 1
			Me.diagram1.Model.AppendChild(rectNode1)
			GenerateInnerLevelNodes(rectNode1, 5, Color.LightGreen, Color.Brown, 0)
		End Sub

		''' <summary>
		''' Generates the inner level nodes
		''' </summary>
		''' <param name="parentNode">Parent Node</param>
		''' <param name="maxSubNodes">Maximum sub nodes</param>
		''' <param name="LevelColor">Node's Fill color</param>
		''' <param name="connectionColor">Node's fore color</param>
		''' <param name="n">nodes level count</param>
		Private Sub GenerateInnerLevelNodes(ByVal parentNode As Node, ByVal maxSubNodes As Integer, ByVal LevelColor As Color, ByVal connectionColor As Color, ByVal n As Integer)
			If n = 4 Then
				Return
			End If
			For i As Integer = 0 To maxSubNodes - 1
				Dim e As New Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 90, 50)
				e.FillStyle.Color = Color.FromArgb(242, 242, 242)
				e.FillStyle.Type = FillStyleType.LinearGradient
				e.FillStyle.ForeColor = Color.White
				e.FillStyle.GradientAngle = 90
				e.FillStyle.GradientCenter = 1
				Me.diagram1.Model.AppendChild(e)
				ConnectNodes(parentNode, e, connectionColor)
				GenerateInnerLevelNodes(e, i, Color.Plum, Color.Purple, n)
				n += 1
			Next i
		End Sub
		''' <summary>
		''' Connects the given nodes
		''' </summary>
		''' <param name="parentNode">Parent Node</param>
		''' <param name="childNode">Child node</param>
		''' <param name="connectionColor">Connector Color</param>
		Private Sub ConnectNodes(ByVal parentNode As Node, ByVal childNode As Node, ByVal connectionColor As Color)
			If parentNode IsNot Nothing AndAlso childNode IsNot Nothing Then
				Dim lConnector As New LineConnector(PointF.Empty, New PointF(0, 1))
				lConnector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow
				lConnector.HeadDecorator.FillStyle.Color = Color.White
				parentNode.CentralPort.TryConnect(lConnector.TailEndPoint)
				childNode.CentralPort.TryConnect(lConnector.HeadEndPoint)
				Me.diagram1.Model.AppendChild(lConnector)
				Me.diagram1.Model.SendToBack(lConnector)
			End If
		End Sub
		#End Region

		#Region "Event Handlers"


		Private Sub dialog_BeginLayout(ByVal layout As DirectedTreeLayoutManager)
			Me.diagram1.LayoutManager = layout
			Layouting()
		End Sub

		Private Sub apply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles apply.Click
			Dim rotationAngle As Single = 0
			If txtHSpacing.Text <> String.Empty Then
				CType(Me.diagram1.LayoutManager, DirectedTreeLayoutManager).HorizontalSpacing = Single.Parse(txtHSpacing.Text)
			End If
			If txtVSpacing.Text <> String.Empty Then
				CType(Me.diagram1.LayoutManager, DirectedTreeLayoutManager).VerticalSpacing = Single.Parse(txtVSpacing.Text)
			End If
			If txtLMarigin.Text <> String.Empty Then
				CType(Me.diagram1.LayoutManager, DirectedTreeLayoutManager).LeftMargin = Single.Parse(txtLMarigin.Text)
			End If
			If txtTMarigin.Text <> String.Empty Then
				CType(Me.diagram1.LayoutManager, DirectedTreeLayoutManager).TopMargin = Single.Parse(txtTMarigin.Text)
			End If

			Select Case comboLytDirection.SelectedItem.ToString()
				Case "TopToBottom"
					rotationAngle = 0
				Case "TopLeft"
					rotationAngle = 45
				Case "TopRight"
					rotationAngle = -45
				Case "LeftToRight"
					rotationAngle = 90
				Case "RightToLeft"
					rotationAngle = -90
				Case "BottomToTop"
					rotationAngle = 180
				Case "BottomLeft"
					rotationAngle = 135
				Case "BottomRight"
					rotationAngle = -135
			End Select
			CType(Me.diagram1.LayoutManager, DirectedTreeLayoutManager).RotationAngle = rotationAngle
			CType(Me.diagram1.LayoutManager, DirectedTreeLayoutManager).AutoLayout = chkAutoLayout.Checked
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
