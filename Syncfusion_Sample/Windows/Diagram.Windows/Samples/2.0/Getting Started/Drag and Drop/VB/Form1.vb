Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2012"
'
'  Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports Label = System.Windows.Forms.Label
Imports Syncfusion.Windows.Forms
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports DemoCommon.Diagram
Imports Syncfusion.Windows.Forms.Tools

Namespace DragDrop
	Partial Public Class Form1
		Inherits DemoForm
		#Region "Membres"
		Private managers As NodeCollection
		Private employees As NodeCollection
		#End Region

		#Region "Class initialize/finalize methods"
		Public Sub New()

			InitializeComponent()
			managers = New NodeCollection()
			employees = New NodeCollection()

			Me.diagram1.Model = Me.model1

			Dim mgr As New DirectedTreeLayoutManager(Me.diagram1.Model, 0, 30, 50)
			mgr.LeftMargin = 100
			mgr.TopMargin = 50
			Me.diagram1.LayoutManager = mgr
			AddHandler diagram1.Model.EventSink.DocumentEndUpdate, AddressOf EventSink_DocumentEndUpdate
			Me.diagram1.Model.DocumentSize = New PageSize(800, 800)
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality

		  ' Load Palette
		  Me.paletteGroupBar1.LoadPalette("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\DragDrop.edp")

		End Sub

		Private Sub EventSink_DocumentEndUpdate(ByVal sender As Object, ByVal e As EventArgs)
			If TypeOf Me.diagram1.Controller.ActiveTool Is MoveTool AndAlso Me.diagram1.Controller.NodesHit.Count <> 0 AndAlso TypeOf Me.diagram1.Controller.NodesHit.First Is Group Then
				If (TypeOf Me.diagram1.Controller.NodesHit.First Is Group) Then
					Me.nodeMoved = CType((Me.diagram1.Controller.NodesHit.First), Group)
				Else
					Me.nodeMoved = CType((Nothing), Group)
				End If

				If Me.nodeMoved.Name.StartsWith("M") AndAlso Me.nodeMoved.CentralPort IsNot Nothing AndAlso Me.nodeMoved.EdgesEntering.Count <> 0 Then
					For Each mNode As Group In Me.managers
						If Me.nodeMoved.ContainsPoint(mNode.PinPoint) Then
							For Each endpt As EndPoint In Me.nodeMoved.CentralPort.Connections
								If TypeOf endpt Is HeadEndPoint Then
									If (TypeOf endpt.Container Is LineConnector) Then
										line = CType((endpt.Container), LineConnector)
									Else
										line = CType((Nothing), LineConnector)
									End If
								End If
							Next endpt
							If Not(Me.nodeMoved Is mNode AndAlso line Is Nothing) Then
								Me.diagram1.Model.RemoveChild(line)
								Me.ConnectNodes(mNode, Me.nodeMoved)
								Me.diagram1.Invalidate()
							End If
						End If
					Next mNode
				End If
			End If
			'this.diagram1.Model.UpdateCompositeBounds( );
		End Sub

		#End Region

		#Region "MAIN"
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		#End Region

		#Region "Helper methods"

		''' <summary>
		''' Method to connect the parent and sub nodes.
		''' </summary>
		''' <param name="parentNode">From Node</param>
		''' <param name="subNode">To Node</param>
		Private Sub ConnectNodes(ByVal parentNode As Node, ByVal subNode As Node)
			If parentNode.CentralPort Is Nothing OrElse subNode.CentralPort Is Nothing Then
				Return
			End If

			If parentNode.Equals(subNode) Then
				Return
			End If

			' Create directed link
			Dim line As New LineConnector(PointF.Empty, New PointF(0F, 1F))
			line.LineStyle.LineColor = Color.DarkGray
			line.HeadDecorator.DecoratorShape = DecoratorShape.FilledFancyArrow
			line.HeadDecorator.Size = New SizeF(12F, 9F)
			line.HeadDecorator.FillStyle.Color = Color.MidnightBlue
			line.HeadDecorator.LineStyle.LineColor = Color.Transparent
			Me.diagram1.Model.AppendChild(line)
			Me.diagram1.Model.SendBackward(line)

			parentNode.CentralPort.TryConnect(line.TailEndPoint)
			subNode.CentralPort.TryConnect(line.HeadEndPoint)
		End Sub

		''' <summary>
		''' Update the DiagramLayout for better appearance
		''' </summary>
		Public Sub UpdateDiagramLayout()
			Me.diagram1.LayoutManager.Nodes.Clear()
			Me.diagram1.LayoutManager.Nodes.AddRange(Me.diagram1.Model.Nodes)

			Me.diagram1.LayoutManager.UpdateLayout(True)
			Me.diagram1.UpdateView()
		End Sub


		''' <summary>
		''' Initial addition of nodes while loading is handled here
		''' </summary>
		Public Sub AddManagers()
			' Insert the nodes 
			InsertNodeFromPallete(0, New PointF(50, 50))
			InsertNodeFromPallete(1, New PointF(25, 150))
			InsertNodeFromPallete(1, New PointF(100, 150))

			'Connect the nodes 
			ConnectNodes(Me.managers(0), Me.employees(0))
			ConnectNodes(Me.managers(0), Me.employees(1))


		End Sub

		''' <summary>
		''' Inserts the Node in the diagram from the palette at given location
		''' </summary>
		''' <param name="nNodeIndex">index of the node</param>
		''' <param name="ptLocation">Location of the node</param>
		''' <returns></returns>
		Private Function InsertNodeFromPallete(ByVal nNodeIndex As Integer, ByVal ptLocation As PointF) As Node
			Dim node As Node = Nothing
			Dim nodes As NodeCollection = paletteGroupBar1.CurrentSymbolPalette.Nodes

			If nNodeIndex >= 0 AndAlso nNodeIndex < nodes.Count Then
				node = CType(nodes(nNodeIndex).Clone(), Node)
				InsertNode(node, ptLocation)
			End If

			Return node
		End Function

		' <summary>
		''' Inserts the Node in the diagram at given location
		''' </summary>
		''' <param name="nNodeIndex">index of the node</param>
		''' <param name="ptLocation">Location of the node</param>
		''' <returns></returns>
		Private Function InsertNode(ByVal node As Node, ByVal ptLocation As PointF) As Node

			m_list = New ArrayList()
			' Perform Matrix transformation

			Dim units As MeasureUnits = MeasureUnits.Pixel
			Dim szPinOffset As SizeF = (CType(node, IUnitIndependent)).GetPinPointOffset(units)
			ptLocation.X += szPinOffset.Width
			ptLocation.Y += szPinOffset.Height
			CType(node, IUnitIndependent).SetPinPoint(ptLocation, units)

			'Append the nodes to the drawing area          
			Me.diagram1.Model.AppendChild(node)

			If node.Name.StartsWith("M") Then
				Me.managers.Add(node)
				'Adds tag information for nodes 
				managerCount = managerCount + 1
				Dim managerCode As Integer = managerCount + 100
				m_list.AddRange(New String() { managerCode.ToString(), projectName(managerCount) })
				node.Tag = m_list
			Else
				Me.employees.Add(node)
				'Adds tag information for nodes 
				employeeCount = employeeCount + 1
				Dim employeeCode As Integer = employeeCount + 1000
				m_list.AddRange(New String() { employeeCode.ToString(), employeeName(employeeCount), designation(employeeCount) })
				node.Tag = m_list

			End If
			Return node
		End Function

		 #End Region

		#Region "Class Event handlers"
		Private m_list As ArrayList
		Private employeeName() As String = { "Ria", "Alew", "Lisa", "Vincy", "Marissa", "Seema", "Hanna", "Maria", "Ana", "Christina", "Francy"}
		Private designation() As String = { "Software Engineer ", "Junior SE - Level 1", "Junior SE - Level 2","Junior SE - Level 3", "Junior SE - Level 4","Junior SE - Level 4", "HR", "HR Assistant", "Graphics Designer", "Network Admin", "System Admin"}
		Private projectName() As String = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K"}
		Private managerCount As Integer = 0
		Private employeeCount As Integer = 0
		Private Sub diagram1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles diagram1.DragDrop
			m_list = New ArrayList()


			' Check if the dropped node is a valid node
			If e.Data.GetDataPresent(GetType(DragDropData)) Then
				Dim draggedNode As Group = TryCast(Me.diagram1.Controller.SelectionList(0), Group)


				If draggedNode.Name.StartsWith("M") Then
					managerCount = managerCount + 1
					Me.managers.Add(draggedNode)
					'Adds tag information for nodes upto 10 counts
					If managerCount < 10 Then
						Dim managerCode As Integer = managerCount + 100
						m_list.AddRange(New String() { managerCode.ToString(), projectName(managerCount) })
						draggedNode.Tag = m_list
						Dim m_alist As ArrayList = TryCast(draggedNode.Tag, ArrayList)
						Me.label2.Text = "Manager Code: " & m_alist(0).ToString() & Constants.vbLf + Constants.vbLf & "Leads Project " & m_alist(1).ToString()
					End If
				Else

					Me.employees.Add(draggedNode)
					employeeCount = employeeCount + 1
					'Adds tag information for nodes upto 10 counts
					If employeeCount < 10 Then
						Dim employeeCode As Integer = employeeCount + 1000
						m_list.AddRange(New String() { employeeCode.ToString(), employeeName(employeeCount), designation(employeeCount) })
						draggedNode.Tag = m_list
						Dim e_alist As ArrayList = TryCast(draggedNode.Tag, ArrayList)
						Me.label2.Text = "Employee Code: " & e_alist(0).ToString() & Constants.vbLf + Constants.vbLf & "Employee Name: " & e_alist(1).ToString() & Constants.vbLf + Constants.vbLf & "Designation: " & e_alist(2).ToString()
					End If
				End If



				For Each node As Group In Me.managers
					' If the droppednode contains the pinpoint as that of manager node, connect both the nodes
					If draggedNode.ContainsPoint(node.PinPoint) Then
						Me.ConnectNodes(node, draggedNode)
					End If
				Next node




			End If
			' Update the layout for better appearance of nodes.
			Me.UpdateDiagramLayout()
		End Sub



		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			diagram1.BeginUpdate()
			AddManagers()
			UpdateDiagramLayout()
			DiagramAppearance()
			GroupBarAppearance()
			diagram1.EndUpdate()
			diagram1.Controller.InPlaceEditing = False
		End Sub

		Private Sub GroupBarAppearance()
			Me.paletteGroupBar1.BorderColor = System.Drawing.ColorTranslator.FromHtml("#119EDA")
			For Each item As GroupBarItem In paletteGroupBar1.GroupBarItems
				'palette view settings
				If TypeOf item.Client Is PaletteGroupView Then
					Dim view As PaletteGroupView = TryCast(item.Client, PaletteGroupView)
					view.Font = New Font("Segoe UI", 9, System.Drawing.FontStyle.Regular)
					view.ForeColor = Color.Black
					view.BackColor = Color.White
					view.TextWrap = True
					view.BorderStyle = BorderStyle.FixedSingle
				End If
			Next item
		End Sub
		Private Sub DiagramAppearance()
			Me.diagram1.View.Grid.GridStyle = GridStyle.Line
			Me.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			Me.diagram1.View.Grid.Color = Color.LightGray
			Me.diagram1.View.Grid.VerticalSpacing = 15
			Me.diagram1.View.Grid.HorizontalSpacing = 15
			Me.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f
			Me.diagram1.View.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleOutlineColor = Color.SkyBlue
			diagram1.View.BackgroundColor = Color.White
			diagram1.Model.DocumentSize = New PageSize(500, 500)
			Me.diagram1.View.SelectionList.Clear()

		End Sub

		'Shows Node tag inforamtion when a node is selected
		Private Sub diagram1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles diagram1.MouseDown
				' Retrives node under the mouse action.
				Dim node As Node = CType(Me.diagram1.Controller.GetNodeUnderMouse(New Point(e.X, e.Y)), Node)
				If node IsNot Nothing AndAlso node.Tag IsNot Nothing Then
					If node.Name.StartsWith("M") Then
						Dim m_alist As ArrayList = TryCast(node.Tag, ArrayList)
						Me.label2.Text = "Manager Code: " & m_alist(0).ToString() & Constants.vbLf + Constants.vbLf & "Leads Project " & m_alist(1).ToString()

					Else
						Dim e_alist As ArrayList = TryCast(node.Tag, ArrayList)
						Me.label2.Text = "Employee Code: " & e_alist(0).ToString() & Constants.vbLf + Constants.vbLf & "Employee Name: " & e_alist(1).ToString() & Constants.vbLf + Constants.vbLf & "Designation: " & e_alist(2).ToString()
					End If
				End If
		End Sub
		#End Region
	End Class
End Namespace

