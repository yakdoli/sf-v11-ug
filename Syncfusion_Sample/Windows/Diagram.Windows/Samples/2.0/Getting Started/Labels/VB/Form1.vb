Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram
Imports DemoCommon.Diagram

Namespace Labels
	Partial Public Class Form1
		Inherits DemoForm
		#Region "Form Initialize"
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim rect As New Syncfusion.Windows.Forms.Diagram.Rectangle(100, 100, 100, 70)
			rect.FillStyle.Color = Color.Maroon
			rect.FillStyle.ForeColor = Color.Red
			rect.FillStyle.Type = FillStyleType.LinearGradient
			rect.LineStyle.LineWidth = 0
			Dim lbl As New Syncfusion.Windows.Forms.Diagram.Label(rect, "Top Left")
			lbl.FontColorStyle.Color = Color.White
			lbl.Position = Position.TopLeft
			lbl.UpdatePosition = True
			rect.Labels.Add(lbl)
			diagram1.Model.AppendChild(rect)

			Dim rect1 As New Syncfusion.Windows.Forms.Diagram.Rectangle(350, 250, 100, 70)
			rect1.FillStyle.Color = Color.Maroon
			rect1.FillStyle.ForeColor = Color.Red
			rect1.FillStyle.Type = FillStyleType.LinearGradient
			rect1.LineStyle.LineWidth = 0
			Dim lbl1 As New Syncfusion.Windows.Forms.Diagram.Label(rect1, "MiddleRight")
			lbl1.FontColorStyle.Color = Color.White
			lbl1.Position = Position.MiddleRight
			lbl1.UpdatePosition = True
			rect1.Labels.Add(lbl1)
			diagram1.Model.AppendChild(rect1)

			Dim ocon As New OrthogonalConnector(New PointF(100, 100), New PointF(200, 100), False)
			ocon.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow
			ocon.HeadDecorator.FillStyle.Color = Color.Black
			rect.CentralPort.Connect(ocon.TailEndPoint)
			rect1.CentralPort.Connect(ocon.HeadEndPoint)
			diagram1.Model.AppendChild(ocon)
			Dim conLbl As New Syncfusion.Windows.Forms.Diagram.Label(ocon, "BottomCenter")
			conLbl.UpdatePosition = True
			conLbl.Position = Position.BottomCenter
			conLbl.OffsetX = 100
			conLbl.OffsetY = ocon.BoundingRectangle.Height
			conLbl.BackgroundStyle.ColorAlphaFactor = 255
			ocon.Labels.Add(conLbl)


			Dim ocon1 As New OrthogonalConnector(PointF.Empty, New PointF(0, 1), True)
			ocon1.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow
			ocon1.HeadDecorator.FillStyle.Color = Color.Black
			rect.CentralPort.Connect(ocon1.TailEndPoint)
			rect1.CentralPort.Connect(ocon1.HeadEndPoint)
			diagram1.Model.AppendChild(ocon1)
			Dim conLbl1 As New Syncfusion.Windows.Forms.Diagram.Label(ocon1, "Top Center")
			conLbl1.UpdatePosition = True
			conLbl1.Position = Position.TopCenter
			conLbl1.OffsetX = 80
			conLbl1.OffsetY = 0
			conLbl1.BackgroundStyle.ColorAlphaFactor = 255
			ocon1.Labels.Add(conLbl1)

			propertyGrid1.SelectedObject = (CType(diagram1.View.SelectionList(0), PathNode)).Labels(0)
			diagram1.View.SelectionList.Clear()
			AddHandler diagram1.EventSink.NodeSelected, AddressOf EventSink_NodeSelected

		End Sub
		#End Region

		#Region "Event handlers"
        Private Sub EventSink_NodeSelected(ByVal evtArgs As NodeSelectedEventArgs)
            If TypeOf evtArgs.Node Is PathNode AndAlso (CType(evtArgs.Node, PathNode)).Labels.Count > 0 Then
                propertyGrid1.SelectedObject = (CType(evtArgs.Node, PathNode)).Labels(0)
            End If
        End Sub
		#End Region
	End Class
End Namespace