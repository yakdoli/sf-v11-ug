Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DemoCommon.Diagram
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing.Drawing2D

Namespace LineRouting
	Partial Public Class Form1
		Inherits DemoForm
		#Region "Form Initialize"
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.diagram1.LoadBinary("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\New Enhanced Line Routing.edd")
			DiagramAppearance()

			comboLineBridge.SelectedIndex = 0
			chkLineBridge.Checked = diagram1.Model.LineBridgingEnabled
			txtLineBridgeSize.Text = diagram1.Model.LineBridgeSize.ToString()

			comboLineRouting.SelectedIndex = 1
			chkLineRouting.Checked = diagram1.Model.LineRoutingEnabled
			txtDistanceObstcl.Text = diagram1.Model.LineRouter.DistanceToObstacles.ToString()

		End Sub
		#End Region

		#Region "Private Methods"
		''' <summary>
		''' Change's the appearance of Diagram
		''' </summary>
		Private Sub DiagramAppearance()
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
			Me.diagram1.Model.DocumentSize = New PageSize(Me.diagram1.View.ClientRectangle.Size.Width - 5, diagram1.View.ClientRectangle.Size.Height - 5)
			Me.diagram1.Model.BoundaryConstraintsEnabled = False
			Me.diagram1.Model.MinimumSize = diagram1.View.ClientRectangle.Size
			Me.diagram1.Model.SizeToContent = True
			Me.diagram1.View.SelectionList.Clear()
		End Sub

		#End Region

		#Region "Evant handlers"
		Private Sub apply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles apply.Click
			Select Case comboLineBridge.SelectedIndex
				Case 0
					diagram1.Model.BridgeStyle = BridgeStyle.Arc
				Case 1
					diagram1.Model.BridgeStyle = BridgeStyle.Gap
				Case 2
					diagram1.Model.BridgeStyle = BridgeStyle.Square
				Case 3
					diagram1.Model.BridgeStyle = BridgeStyle.Sides2
				Case 4
					diagram1.Model.BridgeStyle = BridgeStyle.Sides3
				Case 5
					diagram1.Model.BridgeStyle = BridgeStyle.Sides4
				Case 6
					diagram1.Model.BridgeStyle = BridgeStyle.Sides5
				Case 7
					diagram1.Model.BridgeStyle = BridgeStyle.Sides6
				Case 8
					diagram1.Model.BridgeStyle = BridgeStyle.Sides7

			End Select
			diagram1.Model.LineBridgingEnabled = chkLineBridge.Checked
			diagram1.Model.LineBridgeSize = Single.Parse(txtLineBridgeSize.Text)

			Select Case comboLineRouting.SelectedIndex
				Case 0
					diagram1.Model.LineRouter.RoutingMode = RoutingMode.Inactive
				Case 1
					diagram1.Model.LineRouter.RoutingMode = RoutingMode.Automatic
				Case 2
					diagram1.Model.LineRouter.RoutingMode = RoutingMode.SemiAutomatic

			End Select
			diagram1.Model.LineRoutingEnabled = chkLineRouting.Checked
			diagram1.Model.LineRouter.DistanceToObstacles = Integer.Parse(txtDistanceObstcl.Text)
		End Sub
		#End Region
	End Class
End Namespace