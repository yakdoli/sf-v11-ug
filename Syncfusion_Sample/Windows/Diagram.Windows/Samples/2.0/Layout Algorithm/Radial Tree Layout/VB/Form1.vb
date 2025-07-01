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

Namespace RadialTreeLayout
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

			Dim rdlLyt As New RadialTreeLayoutManager(Me.diagram1.Model, 0, 10, 10)
			rdlLyt.LeftMargin = 40
			rdlLyt.TopMargin = 20
			Me.diagram1.LayoutManager = rdlLyt
			Me.diagram1.LayoutManager.UpdateLayout(Nothing)
			diagram1.EndUpdate()

			txtHSpacing.Text = rdlLyt.HorizontalSpacing.ToString()
			txtVSpacing.Text = rdlLyt.VerticalSpacing.ToString()
			txtLMarigin.Text = rdlLyt.LeftMargin.ToString()
			txtTMarigin.Text = rdlLyt.TopMargin.ToString()
			chkAutoLayout.Checked = rdlLyt.AutoLayout
		End Sub
		#End Region

		#Region "Private Methods"
		''' <summary>
		''' Change's the appearance of Diagram
		''' </summary>
		Private Sub DiagramAppearance()
			Me.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.View.BackgroundColor = Color.White
			Me.diagram1.Model.BoundaryConstraintsEnabled = False

		End Sub
		#End Region

		#Region "Initialize Diagram"

		''' <summary>
		''' Initialize the nodes in daigram
		''' </summary>
		Private Sub PopulateNodes()
			'First level node
			Dim e1 As New Ellipse(0, 0, 90, 90)
			e1.FillStyle.Color = Color.FromArgb(160, 80, 80)
			e1.FillStyle.ForeColor = Color.FromArgb(255, 45, 45)
			e1.FillStyle.Type = FillStyleType.LinearGradient
			e1.LineStyle.LineWidth = 0
			e1.EnableShading = False
			Me.diagram1.Model.AppendChild(e1)

			GenerateInnerLevelNodes(e1, 5, Color.FromArgb(255,128,64), Color.FromArgb(255, 201, 74), 0)
		End Sub

		''' <summary>
		''' Generates the Inner level nodes
		''' </summary>
		''' <param name="parentNode">Parent Node</param>
		''' <param name="maxSubNodes">Maximum sub nodes</param>
		''' <param name="LevelColor">Fill color for nodes</param>
		''' <param name="foreColor">ForeColor for nodes</param>
		''' <param name="n"></param>
		Private Sub GenerateInnerLevelNodes(ByVal parentNode As Node, ByVal maxSubNodes As Integer, ByVal LevelColor As Color, ByVal foreColor As Color, ByVal n As Integer)
			For i As Integer = 0 To maxSubNodes - 1
				Dim ellipse1 As Ellipse = GetEllipse(LevelColor, foreColor)
				Me.diagram1.Model.AppendChild(ellipse1)
				ConnectNodes(parentNode, ellipse1, Color.Black)

				For j As Integer = 0 To 4
					Dim ellipse2 As Ellipse = GetEllipse(LevelColor, foreColor)
					Me.diagram1.Model.AppendChild(ellipse2)
					ConnectNodes(ellipse1, ellipse2, Color.Black)
				Next j
			Next i
		End Sub

		''' <summary>
		''' New function for create a ellipse
		''' </summary>
		''' <returns></returns>
		Private Shared Function GetEllipse(ByVal fillColor As Color, ByVal foreColor As Color) As Ellipse
			Dim ellipse1 As New Ellipse(0, 0, 45, 45)
			ellipse1.FillStyle.Color = fillColor
			ellipse1.FillStyle.ForeColor = foreColor
			ellipse1.LineStyle.LineColor = Color.Transparent
			ellipse1.FillStyle.Type = FillStyleType.LinearGradient
			' ellipse1.EnableShading = true;
			ellipse1.FillStyle.Type = FillStyleType.LinearGradient
			Return ellipse1
		End Function

		''' <summary>
		''' Connects the given nodes
		''' </summary>
		''' <param name="parentNode">Parent Node</param>
		''' <param name="childNode">Child node</param>
		''' <param name="connectionColor">Connector Color</param>
		Private Sub ConnectNodes(ByVal parentNode As Node, ByVal childNode As Node, ByVal connectionColor As Color)
			If parentNode IsNot Nothing AndAlso childNode IsNot Nothing Then
				Dim lConnector As New LineConnector(PointF.Empty, New PointF(0, 1))
				'lConnector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;               
				lConnector.HeadDecorator.FillStyle.Color = Color.White
				lConnector.HeadDecorator.LineStyle.LineColor = connectionColor
				lConnector.LineStyle.LineColor = connectionColor


				parentNode.CentralPort.TryConnect(lConnector.TailEndPoint)
				childNode.CentralPort.TryConnect(lConnector.HeadEndPoint)
				Me.diagram1.Model.AppendChild(lConnector)
				Me.diagram1.Model.SendToBack(lConnector)
			End If
		End Sub
		#End Region

		#Region "Event Handlers"

		Private Sub dialog_BeginLayout(ByVal layout As TableLayoutManager)
			Me.diagram1.LayoutManager = layout
			Layouting()
		End Sub

		Private Sub apply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles apply.Click
			Dim rotationAngle As Single = 0
			If txtHSpacing.Text <> String.Empty Then
				CType(Me.diagram1.LayoutManager, RadialTreeLayoutManager).HorizontalSpacing = Single.Parse(txtHSpacing.Text)
			End If
			If txtVSpacing.Text <> String.Empty Then
				CType(Me.diagram1.LayoutManager, RadialTreeLayoutManager).VerticalSpacing = Single.Parse(txtVSpacing.Text)
			End If
			If txtLMarigin.Text <> String.Empty Then
				CType(Me.diagram1.LayoutManager, RadialTreeLayoutManager).LeftMargin = Single.Parse(txtLMarigin.Text)
			End If
			If txtTMarigin.Text <> String.Empty Then
				CType(Me.diagram1.LayoutManager, RadialTreeLayoutManager).TopMargin = Single.Parse(txtTMarigin.Text)
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
			CType(Me.diagram1.LayoutManager, RadialTreeLayoutManager).RotationAngle = rotationAngle
			CType(Me.diagram1.LayoutManager, RadialTreeLayoutManager).AutoLayout = chkAutoLayout.Checked
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