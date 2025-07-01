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
Imports System.Xml
Imports System.Collections


Namespace DatabaseBinding
	Partial Public Class Form1
		Inherits DemoForm

		#Region "Form Initialization"
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			diagram1.BeginUpdate()

			Dim table As New DataTable()
			table.Columns.Add("ID", GetType(String))
			table.Columns.Add("Title", GetType(String))
			table.Columns.Add("ParentID", GetType(String))
			table.Columns.Add("Designation", GetType(String))
			''
			'' Here we add five DataRows.
			''
			table.Rows.Add("1", "John Smith", String.Empty, "CEO")
			table.Rows.Add("2", "Joe Robert", "1", "Manager SLS")
			table.Rows.Add("3", "Jack Kent", "1", "Manager Mkt")
			table.Rows.Add("4", "Ravi Kumar", "2", "Engineer")
			table.Rows.Add("5", "Sue Raymond", "2", "Engineer")
			table.Rows.Add("6", "Lisa simpson", "4", "Junior Engineer")
			table.Rows.Add("7", "Bob Woley", "5", "Junior Engineer")
			table.Rows.Add("8", "Ron Jones", "3", "CSR")
			table.Rows.Add("9", "Dave Mason", "3", "CSR")
			table.Rows.Add("10", "John Williams", "3", "CSR")
			dataGridView1.DataSource = table

			PopulateFields(table)
			diagram1.Model.LineStyle.LineColor = Color.Transparent

			Dim orgchartLayout As New HierarchicLayoutManager(diagram1.Model, 0, 40, 20)
			orgchartLayout.HorizontalSpacing = 40
			orgchartLayout.VerticalSpacing = 70
			orgchartLayout.LeftMargin = 20
			orgchartLayout.TopMargin = 60
			diagram1.LayoutManager = orgchartLayout
			diagram1.LayoutManager.UpdateLayout(Nothing)
			DiagramAppearance()

			diagram1.EndUpdate()
		End Sub
		#End Region

		#Region "Private methods"
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
			Me.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.Model.BoundaryConstraintsEnabled = False
			Me.diagram1.View.BackgroundColor = Color.White
			Me.diagram1.View.SelectionList.Clear()
		End Sub
		#End Region

		#Region "Initialization of Diagram"

		''' <summary>
		''' Generates the diagram from the data source.
		''' </summary>
		''' <param name="dt">Data Source to be passed</param>
		Private Sub PopulateFields(ByVal dt As DataTable)
			For i As Integer = 0 To dt.Rows.Count - 1

				Dim rect As Syncfusion.Windows.Forms.Diagram.RoundRect = GetRoundRect()
				rect.Name = "Node" & dt.Rows(i)("ID").ToString()
				Dim labelText As String = dt.Rows(i)("Title").ToString() & Constants.vbCrLf & dt.Rows(i)("Designation").ToString()
				' create a new label for roundrect
				Dim label As Syncfusion.Windows.Forms.Diagram.Label = AddLabel(rect, labelText)
				rect.Labels.Add(label)
				diagram1.Model.AppendChild(rect)
				If Not String.IsNullOrEmpty(dt.Rows(i)("ParentID").ToString()) Then
					Dim parentNode As Syncfusion.Windows.Forms.Diagram.RoundRect = TryCast(diagram1.Model.Nodes.FindNodeByName("Node" & dt.Rows(i)("ParentID").ToString()), Syncfusion.Windows.Forms.Diagram.RoundRect)
					Dim ss As String = parentNode.Name
					ConnectNodes(parentNode, rect)
				End If

			Next i
		End Sub

		''' <summary>
		''' New function for adding label to the Rectangle
		''' </summary>
		''' <param name="rect">Container of the Label</param>
		''' <param name="labelText">Text of the Label</param>
		''' <returns></returns>
		Private Shared Function AddLabel(ByVal rect As Syncfusion.Windows.Forms.Diagram.RoundRect, ByVal labelText As String) As Syncfusion.Windows.Forms.Diagram.Label
			Dim label As New Syncfusion.Windows.Forms.Diagram.Label(rect, labelText)
			label.FontStyle.Family = "Verdana"
			label.FontStyle.Size = 8
			label.FontColorStyle.Color = Color.White
			label.HorizontalAlignment = StringAlignment.Center
			label.VerticalAlignment = StringAlignment.Center
			Return label
		End Function

		''' <summary>
		''' create a new RoundRect
		''' </summary>
		''' <returns></returns>
		Private Shared Function GetRoundRect() As Syncfusion.Windows.Forms.Diagram.RoundRect
			Dim rect As New Syncfusion.Windows.Forms.Diagram.RoundRect(0, 0, 110, 50, MeasureUnits.Pixel)
			rect.FillStyle.Color = Color.FromArgb(152, 152, 186)
			rect.FillStyle.ForeColor = Color.FromArgb(102, 102, 153)
			rect.LineStyle.LineColor = Color.SlateBlue
			rect.FillStyle.Type = FillStyleType.LinearGradient
			Return rect
		End Function

		''' <summary>
		''' Create a new function for connect the nodes.
		''' </summary>
		''' <param name="parentNode">ParentNode</param>
		''' <param name="childNode">ChildNode</param>
		Private Sub ConnectNodes(ByVal parentNode As Node, ByVal childNode As Node)
			If parentNode IsNot Nothing AndAlso childNode IsNot Nothing Then
				'Create a new instance for OrgLineConnector.
				Dim orgCon As New OrgLineConnector(New PointF(0, 0), New PointF(0, 1))
				orgCon.LineStyle.LineColor = Color.SlateBlue
				orgCon.VerticalDistance = parentNode.BoundingRectangle.Height-25
				' Set the value for decorator shape.
				Dim decor As Decorator = orgCon.HeadDecorator
				decor.DecoratorShape = DecoratorShape.Filled45Arrow
				decor.Size = New SizeF(10, 10)
				decor.FillStyle.Color = Color.SlateBlue
				decor.LineStyle.LineColor = Color.SlateBlue
				' add connector to Diagram control.

				parentNode.CentralPort.TryConnect(orgCon.TailEndPoint)
				childNode.CentralPort.TryConnect(orgCon.HeadEndPoint)
				Me.diagram1.Model.AppendChild(orgCon)
				Me.diagram1.Model.SendToBack(orgCon)

			End If
		End Sub
		#End Region

	End Class

End Namespace
