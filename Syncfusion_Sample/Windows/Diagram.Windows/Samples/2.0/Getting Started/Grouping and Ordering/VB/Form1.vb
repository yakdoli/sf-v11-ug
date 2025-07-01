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

Namespace Grouping
	Partial Public Class Form1
		Inherits DemoForm
		#Region "Class members"
		''' <summary>
		''' Indicate in context menu needed to show.
		''' </summary>
		Private m_bShowMenu As Boolean = True
		#End Region

		#Region "Form Initialize"
		Public Sub New()
			InitializeComponent()
			diagram1.DefaultContextMenuEnabled = False
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			diagram1.Model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
			Dim rect As New Syncfusion.Windows.Forms.Diagram.Rectangle(100, 50, 100, 75)
			rect.FillStyle.Color = Color.FromArgb(242,242,242)
			rect.FillStyle.ForeColor = Color.White
			rect.FillStyle.Type = FillStyleType.LinearGradient
			rect.LineStyle.LineWidth = 1
			AddLabel(rect)

			Dim roundRect As New Syncfusion.Windows.Forms.Diagram.RoundRect(220, 0, 100, 75, MeasureUnits.Pixel)
			roundRect.FillStyle.Color = Color.FromArgb(242, 242, 242)
			roundRect.FillStyle.ForeColor = Color.White
			roundRect.FillStyle.Type = FillStyleType.LinearGradient
			roundRect.LineStyle.LineWidth = 1
			AddLabel(roundRect)

			Dim ellipse1 As New Ellipse(100, 200, 100, 80)
			ellipse1.Name = "Start/Stop"
			ellipse1.FillStyle.Color = Color.FromArgb(242, 242, 242)
			ellipse1.FillStyle.ForeColor = Color.White
			ellipse1.FillStyle.Type = FillStyleType.LinearGradient
			ellipse1.LineStyle.LineWidth = 1
			AddLabel(ellipse1)
			diagram1.Model.AppendChild(ellipse1)

			Dim poly As New Polygon(New PointF() { New PointF(15, 0), New PointF(0, 45), New PointF(15, 90), New PointF(60, 90), New PointF(75, 45), New PointF(60, 0) })
			poly = New Polygon(New PointF() { New PointF(45, 0), New PointF(0, 45), New PointF(45, 90), New PointF(90, 45) })
			poly.Name = "Decision"
			poly.PinPoint = New PointF(350, 230)
			poly.FillStyle.Color = Color.FromArgb(242,242,242)
			poly.FillStyle.ForeColor = Color.White
			poly.FillStyle.Type = FillStyleType.LinearGradient
			poly.LineStyle.LineWidth = 1
			AddLabel(poly)
			diagram1.Model.AppendChild(poly)

			Dim rect1 As New Syncfusion.Windows.Forms.Diagram.Rectangle(100, 350, 100, 75)
			rect1.Name = "Process"
			rect1.FillStyle.Color = Color.FromArgb(242, 242, 242)
			rect1.FillStyle.ForeColor = Color.White
			rect1.FillStyle.Type = FillStyleType.LinearGradient
			rect1.LineStyle.LineWidth = 1
			AddLabel(rect1)
			diagram1.Model.AppendChild(rect1)

			Dim group As New Group()
			group.AppendChild(rect)
			group.AppendChild(roundRect)
			diagram1.Model.AppendChild(group)
			Dim label As New Syncfusion.Windows.Forms.Diagram.Label()
			label.Container = group
			label.Text = "Group1"
			label.FontStyle.Family = "Segoe UI"
			label.FontStyle.Size = 9
			group.Labels.Add(label)

			diagram1.View.SelectionList.Clear()
			AddHandler diagram1.MouseDown, AddressOf diagram1_MouseDown
			AddHandler diagram1.MouseUp, AddressOf diagram1_MouseUp

			' Wire up OnIdle processing
			AddHandler Application.Idle, AddressOf Application_Idle
		End Sub
		#End Region

		#Region "Event Handlers"

		Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
			If Me.diagram1.Controller IsNot Nothing Then
				Dim count As Integer = Me.diagram1.Controller.SelectionList.Count
				groupToolStripMenuItem.Enabled = (count > 1)
				unGroupToolStripMenuItem.Enabled = True
				bringToFrontToolStripMenuItem.Enabled = (count > 0)
				bringForwardToolStripMenuItem.Enabled = (count > 0)
				sendBackwardToolStripMenuItem.Enabled = (count > 0)
				sendToBackToolStripMenuItem.Enabled = (count > 0)
			End If
		End Sub

		Private Sub diagram1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
			If e.Button = MouseButtons.Right AndAlso m_bShowMenu Then
				If Me.diagram1.Controller.SelectionList.Count > 0 Then
					Me.ShowNodeContextMenu(e)
				End If
			End If

			m_bShowMenu = True
		End Sub

		Private Sub diagram1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			If Me.diagram1.Controller.ActiveTool IsNot Nothing Then
				m_bShowMenu = Not Me.diagram1.Controller.ActiveTool.InAction
			End If
		End Sub

		Private Sub groupToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles groupToolStripMenuItem.Click
			diagram1.Controller.Group()
		End Sub

		Private Sub unGroupToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles unGroupToolStripMenuItem.Click
			diagram1.Controller.UnGroup()
		End Sub

		Private Sub bringToFrontToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bringToFrontToolStripMenuItem.Click
			diagram1.Controller.BringToFront()
		End Sub

		Private Sub bringForwardToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bringForwardToolStripMenuItem.Click
			diagram1.Controller.BringForward()
		End Sub

		Private Sub sendBackwardToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sendBackwardToolStripMenuItem.Click
			diagram1.Controller.SendBackward()
		End Sub

		Private Sub sendToBackToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sendToBackToolStripMenuItem.Click
			diagram1.Controller.SendToBack()
		End Sub
		#End Region

		#Region "Helper Methods"
		''' <summary>
		''' The Node ContextMenu contains menu items that perform operations on the particular node over 
		''' which the mouse right click took place.
		''' </summary>
		''' <param name="e"></param>
		Private Sub ShowNodeContextMenu(ByVal e As MouseEventArgs)
			Me.contextMenuStrip1.Show(Me.diagram1, New Point(e.X, e.Y))
			Me.diagram1.Refresh()
		End Sub

		''' <summary>
		''' Adds the label to the given Node.
		''' </summary>
		''' <param name="pathNode">Node</param>
		Private Shared Sub AddLabel(ByVal pathNode As Syncfusion.Windows.Forms.Diagram.PathNode)
			Dim label As New Syncfusion.Windows.Forms.Diagram.Label(pathNode, pathNode.Name)
			label.FontColorStyle.Color = Color.Black
			label.FontStyle.Family = "Segoe UI"
			pathNode.Labels.Add(label)
		End Sub

		#End Region

	End Class
End Namespace