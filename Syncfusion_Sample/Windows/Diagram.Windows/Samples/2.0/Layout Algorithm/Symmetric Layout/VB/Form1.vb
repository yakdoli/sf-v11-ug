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

Namespace SymmetricLayout
	Partial Public Class Form1
		Inherits DemoForm
		#Region "Members        "
		Private Const DEF_LAYOUT_DISTANCE As Integer = 50
		#End Region

		#Region "Form Initialize"
		Public Sub New()
			InitializeComponent()

			diagram1.BeginUpdate()
			DiagramAppearance()
			PopulateNodes()
			Me.diagram1.View.SelectionList.Clear()

			Dim smtLayout As SymmetricLayoutManager = SetLayout()
			diagram1.EndUpdate()

			txtSLength.Text = smtLayout.SpringLength.ToString()
			txtSFactor.Text = smtLayout.SpringFactor.ToString()
			txtMaxIter.Text = smtLayout.MaxIteraction.ToString()
			chkAutoLayout.Checked = smtLayout.AutoLayout
		End Sub
		#End Region

		#Region "Private Methods"
		''' <summary>
		''' Apply layout to the diagram
		''' </summary>
		''' <returns>returns the layout manager</returns>
		Private Function SetLayout() As SymmetricLayoutManager
			Dim smtLayout As New SymmetricLayoutManager(Me.diagram1.Model, 50)

			smtLayout.MaxIteraction = 400
			smtLayout.SpringLength = 80
			smtLayout.SpringFactor = 1.4
			AddHandler smtLayout.PreferredLayout, AddressOf smtLayout_PreferredLayout
			Me.diagram1.LayoutManager = smtLayout
			Me.diagram1.LayoutManager.UpdateLayout(Nothing)
			Return smtLayout
		End Function
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

		#Region "Event Handlers"
		Private Sub smtLayout_PreferredLayout(ByVal sender As Object, ByVal evtArgs As PreferredLayoutEventArgs)
			evtArgs.Location = New PointF(105, 30)
		End Sub

		#End Region

		#Region "Initialize Diagram"

		''' <summary>
		''' Initialize the nodes in daigram
		''' </summary>
		Private Sub PopulateNodes()
			Dim parentRect As Syncfusion.Windows.Forms.Diagram.Rectangle = GetRectangle()
			diagram1.Model.AppendChild(parentRect)

			For i As Integer = 0 To 6
				Dim childRect As Syncfusion.Windows.Forms.Diagram.Rectangle = GetRectangle()
				diagram1.Model.AppendChild(childRect)
				ConnectNodes(parentRect, childRect, Color.Black)
				If i = 0 OrElse i= 4 Then
					For j As Integer = 0 To 1
						Dim childRect4 As Syncfusion.Windows.Forms.Diagram.Rectangle = GetRectangle()
						diagram1.Model.AppendChild(childRect4)
						ConnectNodes(childRect, childRect4, Color.Black)
						If j > 0 Then
							For k As Integer = 0 To j + 2 - 1
								Dim childRect5 As Syncfusion.Windows.Forms.Diagram.Rectangle = GetRectangle()
								diagram1.Model.AppendChild(childRect5)
								ConnectNodes(childRect4, childRect5, Color.Black)
							Next k
						End If
					Next j
				End If
			Next i
		End Sub

		''' <summary>
		''' Gets the new rectangle node
		''' </summary>
		''' <returns>returns the node</returns>
		Private Shared Function GetRectangle() As Syncfusion.Windows.Forms.Diagram.Rectangle
			Dim rect As New Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 25, 25)
			rect.FillStyle.Color = Color.FromArgb(240, 242, 240)
			rect.FillStyle.ForeColor = Color.White
			rect.FillStyle.Type = FillStyleType.LinearGradient
			rect.LineStyle.LineColor = Color.Black
			Return rect
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
				lConnector.HeadDecorator.DecoratorShape = DecoratorShape.None
				lConnector.LineStyle.LineColor = connectionColor
				lConnector.HeadDecorator.FillStyle.Color = connectionColor
				lConnector.HeadDecorator.LineStyle.LineColor = connectionColor
				lConnector.HeadDecorator.Size = New SizeF(10, 10)
				lConnector.CentralPort.ConnectionsLimit = 10000
				Dim label As New Syncfusion.Windows.Forms.Diagram.Label(lConnector, diagram1.Model.Nodes.Count.ToString())
				label.Visible = False
				lConnector.Labels.Add(label)
				parentNode.CentralPort.TryConnect(lConnector.TailEndPoint)
				childNode.CentralPort.TryConnect(lConnector.HeadEndPoint)
				Me.diagram1.Model.AppendChild(lConnector)
				Me.diagram1.Model.SendToBack(lConnector)
			End If
		End Sub
		#End Region

		#Region "Event Handlers"

		Private Sub apply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles apply.Click
			If txtSLength.Text <> String.Empty Then
				CType(Me.diagram1.LayoutManager, SymmetricLayoutManager).SpringLength = Single.Parse(txtSLength.Text)
			End If
			If txtSFactor.Text <> String.Empty Then
				If Double.Parse(txtSFactor.Text) < 3.00 Then
					CType(Me.diagram1.LayoutManager, SymmetricLayoutManager).SpringFactor = Double.Parse(txtSFactor.Text)
				Else
					CType(Me.diagram1.LayoutManager, SymmetricLayoutManager).SpringFactor = 3.00
				End If
			End If
			If txtMaxIter.Text <> String.Empty Then
				CType(Me.diagram1.LayoutManager, SymmetricLayoutManager).SpringLength = Single.Parse(txtMaxIter.Text)
			End If

			CType(Me.diagram1.LayoutManager, SymmetricLayoutManager).AutoLayout = chkAutoLayout.Checked
			Layouting()
		End Sub

		Private Sub dialog_BeginLayout(ByVal layout As SymmetricLayoutManager)
			Me.diagram1.LayoutManager = layout
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