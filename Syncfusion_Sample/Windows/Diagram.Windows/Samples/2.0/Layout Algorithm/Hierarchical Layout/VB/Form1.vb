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
Imports System.Collections

Namespace HierarchicalLayout
	Partial Public Class Form1
		Inherits DemoForm
		#Region "Members"
		Private hierarchicalLayout As HierarchicLayoutManager
		#End Region

		#Region "Form Initialize"
		Public Sub New()
			InitializeComponent()

			diagram1.BeginUpdate()
			Me.diagram1.Model.BoundaryConstraintsEnabled = False
			comboLytDirection.SelectedIndex = 0
			PopulateFields(SetDataSource())
			DiagramAppearance()

			hierarchicalLayout = New HierarchicLayoutManager(Me.diagram1.Model, 0, 70, 40)
			hierarchicalLayout.LeftMargin = 50
			hierarchicalLayout.TopMargin = 50
			Me.diagram1.LayoutManager = hierarchicalLayout
			Me.diagram1.LayoutManager.UpdateLayout(Nothing)

			txtHSpacing.Text = hierarchicalLayout.HorizontalSpacing.ToString()
			txtVSpacing.Text = hierarchicalLayout.VerticalSpacing.ToString()
			txtLMarigin.Text = hierarchicalLayout.LeftMargin.ToString()
			txtTMarigin.Text = hierarchicalLayout.TopMargin.ToString()
			chkAutoLayout.Checked = hierarchicalLayout.AutoLayout

			diagram1.EndUpdate()
		End Sub

		#End Region

		#Region "Private Methods"
		''' <summary>
		''' Change's the appearance of Diagram
		''' </summary>
		Private Sub DiagramAppearance()
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.View.BackgroundColor = Color.White
			Me.diagram1.Model.BoundaryConstraintsEnabled = False
			Me.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.View.SelectionList.Clear()
		End Sub
		#End Region

		#Region "InitializeDiagram"
		''' <summary>
		''' Generate the Data source for diagram
		''' </summary>
		''' <returns></returns>
		Private Function SetDataSource() As DataTable
			Dim table As New DataTable()
			table.Columns.Add("ID", GetType(String))
			table.Columns.Add("Name", GetType(String))
			table.Columns.Add("Designation", GetType(String))
			table.Columns.Add("ParentName", GetType(String))
			'
			' Here we add five DataRows.
			'
			table.Rows.Add("1", "John Smith", "CEO", String.Empty)
			table.Rows.Add("2", "Joe Robert", "Manager-SLS", "John Smith")
			table.Rows.Add("3", "Jack Kent", "Manager-Mkt", "John Smith")
			table.Rows.Add("4", "Ravi kumar", "Manager-DEV", "John Smith")
			table.Rows.Add("5", "Sue Raymond", "CSR", "Joe Robert")
			table.Rows.Add("6", "Lisa Simpson", "CSR", "Joe Robert")
			table.Rows.Add("7", "Bob Woley", "PM", "Jack Kent")
			table.Rows.Add("8", "Ron Jones", "Engineer", "Ravi kumar")
			table.Rows.Add("9", "Dave Mason", "Engineer", "Ravi kumar")

			Return table
		End Function
		''' <summary>
		''' Initialize the nodes in daigram
		''' </summary>
		Private Sub PopulateFields(ByVal dt As DataTable)
			For i As Integer = 0 To dt.Rows.Count - 1
				Dim rect As New Syncfusion.Windows.Forms.Diagram.RoundRect(0, 0, 120, 60, MeasureUnits.Pixel)
				rect.FillStyle.Color = Color.FromArgb(255, 86, 4)
				rect.FillStyle.ForeColor = Color.FromArgb(255, 165, 74)
				rect.LineStyle.LineColor = Color.White
				rect.FillStyle.Type = FillStyleType.LinearGradient
				'rect.EnableShading = true;
				rect.Name = dt.Rows(i)("Name").ToString()
				Dim label As New Syncfusion.Windows.Forms.Diagram.Label(rect, dt.Rows(i)("Name").ToString())
				label.FontStyle.Family = "Segoe UI"
				label.FontStyle.Size = 9
				label.FontColorStyle.Color = Color.White
				rect.Labels.Add(label)
				Dim label1 As New Syncfusion.Windows.Forms.Diagram.Label(rect, dt.Rows(i)("Designation").ToString())
				label1.FontStyle.Family = "Segoe UI"
				label1.FontStyle.Size = 9
				label1.FontColorStyle.Color = Color.White
				label1.OffsetX = rect.BoundingRectangle.Width \ 2-label1.Size.Width \2
				label1.OffsetY = rect.BoundingRectangle.Height \ 2 + 5
				rect.Labels.Add(label1)
				diagram1.Model.AppendChild(rect)
				If Not String.IsNullOrEmpty(dt.Rows(i)("ParentName").ToString()) Then
					Dim parentNode As Syncfusion.Windows.Forms.Diagram.RoundRect = TryCast(diagram1.Model.Nodes.FindNodeByName(dt.Rows(i)("ParentName").ToString()), Syncfusion.Windows.Forms.Diagram.RoundRect)
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
				Dim conn As New OrgLineConnector(PointF.Empty, New PointF(0, 1))
				conn.VerticalDistance = 35
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



		Private Sub dialog_BeginLayout(ByVal layout As DirectedTreeLayoutManager)
			Me.diagram1.LayoutManager = layout
			Layouting()
		End Sub

		Private Sub apply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles apply.Click
			Dim rotationAngle As Single = 0
			If txtHSpacing.Text <> String.Empty Then
				CType(Me.diagram1.LayoutManager, HierarchicLayoutManager).HorizontalSpacing = Single.Parse(txtHSpacing.Text)
			End If
			If txtVSpacing.Text <> String.Empty Then
				CType(Me.diagram1.LayoutManager, HierarchicLayoutManager).VerticalSpacing = Single.Parse(txtVSpacing.Text)
			End If
			If txtLMarigin.Text <> String.Empty Then
				CType(Me.diagram1.LayoutManager, HierarchicLayoutManager).LeftMargin = Single.Parse(txtLMarigin.Text)
			End If
			If txtTMarigin.Text <> String.Empty Then
				CType(Me.diagram1.LayoutManager, HierarchicLayoutManager).TopMargin = Single.Parse(txtTMarigin.Text)
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
			CType(Me.diagram1.LayoutManager, HierarchicLayoutManager).RotationAngle = rotationAngle
			CType(Me.diagram1.LayoutManager, HierarchicLayoutManager).AutoLayout = chkAutoLayout.Checked
			Layouting()
		End Sub

		Private Sub addMember_Click(ByVal sender As Object, ByVal e As EventArgs) Handles addMember.Click
			Dim infoDlg As New AddMemberInfoDlg(diagram1.Model.Nodes)
			If infoDlg.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
				Dim memSym As Node = CreateMember(infoDlg.MemberName, infoDlg.Title)
				Dim parentNode As Node = diagram1.Model.Nodes.FindNodeByName(infoDlg.ParentName.ToString())
				Me.diagram1.Model.AppendChild(memSym)
				If parentNode IsNot Nothing AndAlso memSym IsNot Nothing Then
					ConnectNodes(parentNode, memSym)
				End If
				Dim hlyt As New HierarchicLayoutManager(Me.diagram1.Model, (CType(Me.diagram1.LayoutManager, HierarchicLayoutManager)).RotationAngle, Single.Parse(txtVSpacing.Text), Single.Parse(txtHSpacing.Text))
				hlyt.LeftMargin = Single.Parse(txtLMarigin.Text)
				hlyt.TopMargin = Single.Parse(txtTMarigin.Text)
				Me.diagram1.LayoutManager = hlyt
				Layouting()
				diagram1.View.SelectionList.Clear()
			End If
		End Sub

		#End Region

		#Region "Helper Methods"

		''' <summary>
		''' Create the new member with specified name and title.
		''' </summary>
		''' <param name="strMemberName">The member name.</param>
		''' <param name="strTitle">The title.</param>
		Private Function CreateMember(ByVal strMemberName As String, ByVal strTitle As String) As Node
			Dim szSize As New SizeF(140, 60)
			Dim rnRect As New Syncfusion.Windows.Forms.Diagram.RoundRect(0, 0, 120, 60, MeasureUnits.Pixel)
			rnRect.FillStyle.Color = Color.FromArgb(255, 86, 4)
			rnRect.FillStyle.ForeColor = Color.FromArgb(255, 165, 74)
			rnRect.LineStyle.LineColor = Color.White
			rnRect.FillStyle.Type = FillStyleType.LinearGradient
			Dim label As New Syncfusion.Windows.Forms.Diagram.Label(rnRect, strMemberName)
			label.FontStyle.Family = "Segoe UI"
			label.FontStyle.Size = 9
			label.FontColorStyle.Color = Color.White
			rnRect.Labels.Add(label)
			Dim label1 As New Syncfusion.Windows.Forms.Diagram.Label(rnRect, strTitle)
			label1.FontStyle.Family = "Segoe UI"
			label1.FontStyle.Size = 9
			label1.FontColorStyle.Color = Color.White
			label1.OffsetX = rnRect.BoundingRectangle.Width \ 2 - label1.Size.Width \ 2
			label1.OffsetY = rnRect.BoundingRectangle.Height \ 2 + 5
			rnRect.Labels.Add(label1)
			Return rnRect
		End Function

		Private Sub Layouting()
			Me.diagram1.LayoutManager.UpdateLayout(Nothing)
			Me.diagram1.UpdateView()
		End Sub
		#End Region
	End Class

End Namespace