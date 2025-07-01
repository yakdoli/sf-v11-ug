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

Namespace ZoomAndPan
	Partial Public Class Form1
		Inherits Form
		#Region "Members        "
		Public fileName As String

		#End Region

		#Region "Form Initialize"
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			diagram1.BeginUpdate()
			Me.diagram1.LoadBinary("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\ProcessFlowChart.edd")
			DiagramAppearance()
			diagram1.EndUpdate()

			' Wire up OnIdle processing
			AddHandler Application.Idle, AddressOf Application_Idle
		End Sub
		#End Region

		#Region "Private Methods"

		''' <summary>
		''' Change's the appearance of the Diagram 
		''' </summary>
		Private Sub DiagramAppearance()
			Me.diagram1.Model.LineStyle.LineColor = Color.LightGray
			Me.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.Model.DocumentSize = New PageSize(Me.diagram1.View.ClientRectangle.Size.Width, diagram1.View.ClientRectangle.Size.Height)
			Me.diagram1.Model.BoundaryConstraintsEnabled = False
			Me.diagram1.Model.MinimumSize = diagram1.View.ClientRectangle.Size
			Me.diagram1.Model.SizeToContent = True
			Me.diagram1.View.BackgroundColor = Color.White
			Me.diagram1.View.SelectionList.Clear()
		End Sub

		#End Region

		#Region "Event Handlers"


		Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
			If Me.diagram1 IsNot Nothing AndAlso Me.diagram1.Model IsNot Nothing Then
				Me.zoomInToolStrip.Enabled = True
				Me.zoomOutToolStripButton.Enabled = True

			Else
				Me.zoomInToolStrip.Enabled = False
				Me.zoomOutToolStripButton.Enabled = False

			End If
		End Sub

		Private Sub zoomInToolStrip_Click(ByVal sender As Object, ByVal e As EventArgs) Handles zoomInToolStrip.Click
			diagram1.View.ZoomIn()
		End Sub

		Private Sub zoomOutToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles zoomOutToolStripButton.Click
			diagram1.View.ZoomOut()
		End Sub

		Private Sub resetToolStripButton_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles resetToolStripButton.Click
			diagram1.View.ZoomToActual()
			diagram1.View.Origin = New PointF(0, 0)
			diagram1.Controller.ActivateTool("SelectTool")
		End Sub

		Private Sub panToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles panToolStripButton.Click
			diagram1.Controller.ActivateTool("PanTool")
		End Sub

		Private Sub helpToolStripButton_Click_1(ByVal sender As Object, ByVal e As EventArgs)
			Dim targetURL As String = "http://help.syncfusion.com/"
			System.Diagnostics.Process.Start(targetURL)
		End Sub

		#End Region

	End Class
End Namespace
