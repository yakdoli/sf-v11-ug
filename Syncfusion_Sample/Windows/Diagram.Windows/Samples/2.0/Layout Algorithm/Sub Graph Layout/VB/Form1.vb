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

Namespace SubGraphLayout
	Partial Public Class Form1
		Inherits DemoForm

		#Region "Form Initialize"
		Public Sub New()
			InitializeComponent()
			diagram1.BeginUpdate()
			comboLytDirection.SelectedIndex = 0
			DiagramAppearance()
			PopulateFields(SetDataSource())
			Me.diagram1.View.SelectionList.Clear()

			Dim subLayout As New SubgraphTreeLayoutManager(Me.diagram1.Model, 0, 20, 50)
			subLayout.LeftMargin = 100
			subLayout.TopMargin = 50
			subLayout.HorizontalSpacing = 75
			subLayout.VerticalSpacing = 50
			Me.diagram1.LayoutManager = subLayout
			Me.diagram1.LayoutManager.UpdateLayout(Nothing)

			txtHSpacing.Text = subLayout.HorizontalSpacing.ToString()
			txtVSpacing.Text = subLayout.VerticalSpacing.ToString()
			txtLMarigin.Text = subLayout.LeftMargin.ToString()
			txtTMarigin.Text = subLayout.TopMargin.ToString()
			chkAutoLayout.Checked = subLayout.AutoLayout

			diagram1.EndUpdate()
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

		#Region "InitializeDiagram"

		''' <summary>
		''' Generates the Datatable
		''' </summary>
		''' <returns>returns the table</returns>
		Private Function SetDataSource() As DataTable
			Dim table As New DataTable()
			table.Columns.Add("ID", GetType(String))
			table.Columns.Add("Title", GetType(String))
			table.Columns.Add("ParentID", GetType(String))
			'
			' Here we add five DataRows.
			'
			table.Rows.Add("1", "Root", String.Empty)
			table.Rows.Add("2", "Node 1", "1")
			table.Rows.Add("3", "Node 2", "1")
			table.Rows.Add("4", "Node 3", "1")
			table.Rows.Add("8", "Graph 1", "1")
			table.Rows.Add("9", "Node 11", "8")
			table.Rows.Add("10", "Node 12", "8")
			table.Rows.Add("11", "Graph 2", "8")
			table.Rows.Add("12", "Node 21", "11")
			table.Rows.Add("13", "Node 22", "11")

			Return table
		End Function

		''' <summary>
		''' Initialize the nodes in daigram
		''' </summary>
		Private Sub PopulateFields(ByVal dt As DataTable)
			For i As Integer = 0 To dt.Rows.Count - 1
				Dim rect As New Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 80, 50)
				rect.FillStyle.Color = Color.FromArgb(159, 80, 0)
				rect.FillStyle.ForeColor = Color.FromArgb(255, 149, 149)
				rect.FillStyle.Type = FillStyleType.LinearGradient
				rect.LineStyle.LineColor = Color.White
				'rect.EnableShading = true;
				rect.Name = "Node" & dt.Rows(i)("ID").ToString()
				Dim label As New Syncfusion.Windows.Forms.Diagram.Label(rect, dt.Rows(i)("Title").ToString())
				label.FontStyle.Family = "Verdana"
				label.FontStyle.Size = 8
				label.FontColorStyle.Color = Color.White
				rect.Labels.Add(label)
				diagram1.Model.AppendChild(rect)
				If Not String.IsNullOrEmpty(dt.Rows(i)("ParentID").ToString()) Then
					Dim parentNode As Syncfusion.Windows.Forms.Diagram.Rectangle = TryCast(diagram1.Model.Nodes.FindNodeByName("Node" & dt.Rows(i)("ParentID").ToString()), Syncfusion.Windows.Forms.Diagram.Rectangle)
					Dim ss As String = parentNode.Name
					ConnectNodes(parentNode, rect)
				End If

			Next i
		End Sub

		''' <summary>
		''' Connects the given nodes
		''' </summary>
		''' <param name="parentNode">Parent Node</param>
		''' <param name="childNode">Child node</param>
		Private Sub ConnectNodes(ByVal parentNode As Node, ByVal childNode As Node)
			If parentNode IsNot Nothing AndAlso childNode IsNot Nothing Then
				Dim conn As New LineConnector(PointF.Empty, New PointF(0, 1))
				conn.LineStyle.LineColor = Color.Gray
				Dim decor As Decorator = conn.HeadDecorator
				decor.DecoratorShape = DecoratorShape.Filled45Arrow
				decor.FillStyle.Color = Color.White
				decor.LineStyle.LineColor = Color.Gray

				Me.diagram1.Model.AppendChild(conn)

				parentNode.CentralPort.TryConnect(conn.TailEndPoint)
				childNode.CentralPort.TryConnect(conn.HeadEndPoint)

				Me.diagram1.Model.SendToBack(conn)

			End If
		End Sub
		#End Region

		#Region "Event Handlers"


		Private Sub dialog_BeginLayout(ByVal layout As SubgraphTreeLayoutManager)
			Me.diagram1.LayoutManager = layout
			Layouting()
		End Sub

		Private Sub apply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles apply.Click
			Dim rotationAngle As Single = 0
			If txtHSpacing.Text <> String.Empty Then
				CType(Me.diagram1.LayoutManager, SubgraphTreeLayoutManager).HorizontalSpacing = Single.Parse(txtHSpacing.Text)
			End If
			If txtVSpacing.Text <> String.Empty Then
				CType(Me.diagram1.LayoutManager, SubgraphTreeLayoutManager).VerticalSpacing = Single.Parse(txtVSpacing.Text)
			End If
			If txtLMarigin.Text <> String.Empty Then
				CType(Me.diagram1.LayoutManager, SubgraphTreeLayoutManager).LeftMargin = Single.Parse(txtLMarigin.Text)
			End If
			If txtTMarigin.Text <> String.Empty Then
				CType(Me.diagram1.LayoutManager, SubgraphTreeLayoutManager).TopMargin = Single.Parse(txtTMarigin.Text)
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
			CType(Me.diagram1.LayoutManager, SubgraphTreeLayoutManager).RotationAngle = rotationAngle
			CType(Me.diagram1.LayoutManager, SubgraphTreeLayoutManager).AutoLayout = chkAutoLayout.Checked
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