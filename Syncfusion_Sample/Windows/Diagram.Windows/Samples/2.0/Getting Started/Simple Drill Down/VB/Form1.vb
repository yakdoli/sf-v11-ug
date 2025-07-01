Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing.Drawing2D
Imports Syncfusion.Windows.Forms

Namespace SimpleDrillDown
	Partial Public Class Form1
		Inherits DemoCommon.Diagram.DemoForm
		#Region "Form Initialize"
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Add a textnode to the home page (Model1)
			Me.diagram1.Model = Me.model1
			DiagramAppearance()
			Dim txtnode As Syncfusion.Windows.Forms.Diagram.TextNode = New TextNode(" Coevals Diagram ")
			txtnode.FontStyle.Family = "Arial"
			txtnode.FontStyle.Size = 18
			txtnode.FontStyle.Bold = True
			txtnode.FontColorStyle.Color = Color.MidnightBlue
			txtnode.LineStyle.LineColor = Color.Transparent
			txtnode.SizeToText(New Size(1000, 1000))
			InsertNode(txtnode, New PointF(200, 20))

			Dim txtnode1 As Syncfusion.Windows.Forms.Diagram.TextNode = New TextNode("Expand and Collapse concept is featured with this DrillDown.")
			txtnode1.FontStyle.Size = 9
			txtnode1.FontStyle.Bold = True
			txtnode1.FontColorStyle.Color = Color.MidnightBlue
			txtnode1.LineStyle.LineColor = Color.Transparent
			txtnode1.FontStyle.Family = "Arial"
			txtnode1.FontStyle.Size = 8
			txtnode1.VerticalAlignment = StringAlignment.Center
			txtnode1.WrapText = True
			txtnode1.SizeToText(New Size(100, 100))
			txtnode1.PinPoint = New PointF(540, 95)
			InsertNode(txtnode1, New PointF(540, 95))

			' Add a button that gets triggered to present Model2 
			Me.diagram1.Model.AppendChild(New GrandMotherSymbolClass(Me.diagram1, Me.model1, Me.model2))
			Me.diagram1.Controller.InPlaceEditing = False
			Me.diagram1.View.SelectionList.Clear()

			AddHandler diagram1.EventSink.NodeMouseEnter, AddressOf EventSink_NodeMouseEnter
			AddHandler diagram1.EventSink.NodeMouseLeave, AddressOf EventSink_NodeMouseLeave
		End Sub
		#End Region

		#Region "Event Handlers"

		Private Sub EventSink_NodeMouseLeave(ByVal evtArgs As NodeMouseEventArgs)
			diagram1.Controller.ActiveTool.ActionCursor = Cursors.Arrow
		End Sub

		Private Sub EventSink_NodeMouseEnter(ByVal evtArgs As NodeMouseEventArgs)
			diagram1.Controller.ActiveTool.ActionCursor = Cursors.Hand
		End Sub

		#End Region

		#Region "Private Methods"
		''' <summary>
		''' Inserts the node into the diagram at given location
		''' </summary>
		''' <param name="node">Node</param>
		''' <param name="ptLocation">Node's Location</param>
		''' <returns></returns>
		Private Function InsertNode(ByVal node As Node, ByVal ptLocation As PointF) As Node
			Dim units As MeasureUnits = MeasureUnits.Pixel

			Dim szPinOffset As SizeF = (CType(node, IUnitIndependent)).GetPinPointOffset(units)
			ptLocation.X += szPinOffset.Width
			ptLocation.Y += szPinOffset.Height
			CType(node, IUnitIndependent).SetPinPoint(ptLocation, units)

			Me.diagram1.Model.AppendChild(node)
			Return node
		End Function

		''' <summary>
		''' Changes the appearance of the diagram
		''' </summary>
		Private Sub DiagramAppearance()
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
		#End Region

	End Class
End Namespace