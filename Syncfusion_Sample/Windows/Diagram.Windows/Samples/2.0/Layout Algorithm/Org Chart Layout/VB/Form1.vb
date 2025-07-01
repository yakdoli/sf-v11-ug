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
Imports System.Collections
Imports System.Xml
Imports DemoCommon.Diagram

Namespace OrgChartLayout
	Partial Public Class Form1
		Inherits DemoForm
		#Region "Members"
		Protected dtLayoutMgr As OrgChartLayoutManager
		#End Region

		#Region "Form Initialize"
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			diagram1.BeginUpdate()
			Me.diagram1.Controller.InPlaceEditing = False
			Me.dtLayoutMgr = New OrgChartLayoutManager(Me.diagram1.Model, RotateDirection.TopToBottom, 40, 50, LayoutType.Waterfall, 1)
			dtLayoutMgr.LeftMargin = 10
			dtLayoutMgr.TopMargin = 10
			dtLayoutMgr.VerticalSpacing = 50
			diagram1.LayoutManager = dtLayoutMgr
			DiagramAppearance()
			InitializeDiagramFromXMLData()
			Me.diagram1.View.SelectionList.Clear()

			txtHSpacing.Text = dtLayoutMgr.HorizontalSpacing.ToString()
			txtVSpacing.Text = dtLayoutMgr.VerticalSpacing.ToString()
			txtLMarigin.Text = dtLayoutMgr.LeftMargin.ToString()
			txtTMarigin.Text = dtLayoutMgr.TopMargin.ToString()
			chkAutoLayout.Checked = dtLayoutMgr.AutoLayout

			comboLytType.SelectedIndex = 0
			comboBShape.SelectedIndex = 1
			comboExpSymbol.SelectedIndex = 0

			diagram1.EndUpdate()
			AddHandler comboBShape.SelectedIndexChanged, AddressOf comboBShape_SelectedIndexChanged
			AddHandler comboExpSymbol.SelectedIndexChanged, AddressOf comboExpSymbol_SelectedIndexChanged
			AddHandler apply.Click, AddressOf apply_Click
			AddHandler diagram1.MouseMove, AddressOf diagram1_MouseMove
			AddHandler diagram1.EventSink.NodeMouseEnter, AddressOf EventSink_NodeMouseEnter
		End Sub
		#End Region

		#Region "Private Methods"
		''' <summary>
		''' Change's the appearance of Diagram
		''' </summary>
		Private Sub DiagramAppearance()
			'this.diagram1.MetroScrollBars = true;            
			Me.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.View.BackgroundColor = Color.White
			Me.diagram1.Model.SizeToContent = True

		End Sub
		#End Region

		#Region "Initialize Diagram"

		''' <summary>
		''' Initialize the diagram from XML file.
		''' </summary>
		Protected Sub InitializeDiagramFromXMLData()
			Dim datasrcpath As String = "..//..//OrgLayout.xml"

			' Read data from the XML data file and populate a Hashtable using the employee ID as the key
			Dim lstEmployees As Hashtable = Me.ReadEmployeeDataFromXMLFile(datasrcpath)

			' Create a manager-employee nested list with top-level employees forming the root nodes
			Dim sortedlist As ArrayList = Me.GetSortedEmployeesList(lstEmployees)

			For Each emply As Employee_CS In sortedlist
				Me.IterUpdateSubEmployeeCount(emply)
			Next emply

			' Create diagram symbol nodes for each employee and initialize the diagram
			Me.CreateOrgDiagramFromList(sortedlist)
			lstEmployees.Clear()
			sortedlist.Clear()
		End Sub

		''' <summary>
		''' Read the data from the XML file
		''' </summary>
		''' <param name="datasrc">Path of the XML File</param>
		''' <returns>returns the employee table</returns>
		Protected Function ReadEmployeeDataFromXMLFile(ByVal datasrc As String) As Hashtable
			Dim lstEmployee As New Hashtable()

			' Use the XML DOM to read data from the employees XML data file
			Dim xmldoc As New XmlDocument()
			xmldoc.Load(datasrc)
			If xmldoc.DocumentElement.HasChildNodes Then
				Dim employeelist As XmlNodeList = xmldoc.DocumentElement.ChildNodes
				For i As Integer = 0 To employeelist.Count - 1
					' Create an Employee instance to represent each employee
					Dim emply As New Employee_CS()

					Dim employeenode As XmlNode = employeelist(i)
					Dim employeedatalist As XmlNodeList = employeenode.ChildNodes
					Dim employeedata As IEnumerator = employeedatalist.GetEnumerator()
					employeedata.Reset()
					Do While employeedata.MoveNext()
						Dim dataelement As XmlNode = TryCast(employeedata.Current, XmlNode)
						Select Case dataelement.Name
							Case "Name"
								emply.EmployeeName = "Name :" & dataelement.InnerText
							Case "EmployeeID"
								emply.EmployeeID = dataelement.InnerText
								emply.EmployeeName &= System.Environment.NewLine & "Emp ID :" & dataelement.InnerText
							Case "Designation"
								emply.Designation = dataelement.InnerText
								emply.EmployeeName &= System.Environment.NewLine & "Des :" & dataelement.InnerText
							Case "DOJ"
								emply.DOJ = dataelement.InnerText
								emply.EmployeeName &= System.Environment.NewLine & "DOJ :" & dataelement.InnerText
							Case "ImageNo"
								emply.ImageName = dataelement.InnerText
							Case "ManagerID"
								emply.ManagerID = dataelement.InnerText
						End Select
					Loop
					lstEmployee.Add(emply.EmployeeID,emply)
				Next i
			End If

			Return lstEmployee
		End Function

		''' <summary>
		'''  Rearrange the employees collection as a manager-subemployee nested tree
		''' </summary>
		''' <param name="htemployees">Employee table</param>
		''' <returns>returns the sorted list</returns>
		Protected Function GetSortedEmployeesList(ByVal htemployees As Hashtable) As ArrayList
			Dim employees As ICollection = htemployees.Values
			Dim sortedlist As New ArrayList()
			For Each emply As Employee_CS In employees
				If emply.ManagerID = String.Empty Then
					' Employees without a ManagerID are top-level nodes in the org tree
					sortedlist.Add(emply)
				Else
					' Find the employee instance associated with the managerID and add this object as 
					' a subemployee of the manager node.
					Dim manager As Employee_CS = CType(htemployees(emply.ManagerID), Employee_CS)
					If manager IsNot Nothing Then
						manager.SubEmployees.Add(emply)
					End If
				End If
			Next emply

			Return sortedlist
		End Function

		''' <summary>
		''' generates the sub employees count
		''' </summary>
		''' <param name="empl">Employee business object</param>
		Protected Sub IterUpdateSubEmployeeCount(ByVal empl As Employee_CS)
			empl.RecSubEmployeeCount = empl.SubEmployees.Count
			For Each subempl As Employee_CS In empl.SubEmployees
				Me.IterUpdateSubEmployeeCount(subempl)
				empl.RecSubEmployeeCount += subempl.RecSubEmployeeCount
			Next subempl
		End Sub

		''' <summary>
		''' Create diagram symbol nodes for each employee in the organization and add these symbols to the diagram
		''' Create links between manager and sub-employees to depict the org structure
		''' </summary>
		''' <param name="alemployees"> Employees list</param>
		Protected Sub CreateOrgDiagramFromList(ByVal alemployees As ArrayList)
			' Temporarily suspend the Diagram Model redrawing
			Me.diagram1.Model.BeginUpdate()

			For Each emply As Employee_CS In alemployees
				Dim fileName As String = "..//..//Images//" & emply.ImageName & ".png"
				Dim emplysymbol As New EmpSymbol(fileName)
				emplysymbol.LineStyle.LineColor = Color.LightSkyBlue
				emplysymbol.EmployeeName = emply.EmployeeName
				Me.diagram1.Model.AppendChild(emplysymbol)
				Me.IterCreateEmployeeSymbol(emply, emplysymbol)
			Next emply

			' ReEnable the Model redraw
			Me.diagram1.Model.EndUpdate()

			' Instruct the LayoutManager to calculate and layout the diagram nodes
			LayoutNodes()
		End Sub


		''' <summary>
		'''  Iterative sub-employee symbol node creation
		''' </summary>
		''' <param name="emply">Employess business object</param>
		''' <param name="emplysymbol">Employee Node</param>
		Protected Sub IterCreateEmployeeSymbol(ByVal emply As Employee_CS, ByVal emplysymbol As EmpSymbol)
			For Each subemply As Employee_CS In emply.SubEmployees
				Dim fileName As String = "..//..//Images//" & subemply.ImageName & ".png"
				' Create a EmployeeSymbol for each of the sub-employees of the particular employee //Waterfall, Horizontal
				Dim subemplysymbol As New EmpSymbol(fileName)
				subemplysymbol.LineStyle.LineColor = Color.LightSkyBlue
				subemplysymbol.EmployeeName = emply.EmployeeName
				Me.diagram1.Model.AppendChild(subemplysymbol)

				emplysymbol.EnableCentralPort = True
				subemplysymbol.EnableCentralPort = True
				ConnectNodes(emplysymbol, subemplysymbol)

				Me.IterCreateEmployeeSymbol(subemply, subemplysymbol)
			Next subemply

		End Sub

		''' <summary>
		''' Connects the nodes
		''' </summary>
		''' <param name="emplysymbol">Parent Node</param>
		''' <param name="subemplysymbol">Child node</param>
		Private Sub ConnectNodes(ByVal emplysymbol As Node, ByVal subemplysymbol As Node)
			Dim ortholink As New OrgLineConnector(PointF.Empty, New PointF(0, 1))
			ortholink.LineStyle.LineWidth = 1f
			ortholink.LineStyle.LineColor = Color.Black
			ortholink.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow
			ortholink.HeadDecorator.FillStyle.Color = Color.Black
			Me.diagram1.Model.AppendChild(ortholink)

			If emplysymbol.CentralPort IsNot Nothing AndAlso subemplysymbol.CentralPort IsNot Nothing Then
				emplysymbol.CentralPort.TryConnect(ortholink.TailEndPoint)
				subemplysymbol.CentralPort.TryConnect(ortholink.HeadEndPoint)
			End If

			Me.diagram1.Controller.SendToBack()
		End Sub

		#End Region

		#Region "Event Handlers"

		Private Sub dialog_BeginLayout(ByVal layout As OrgChartLayoutManager)
			Me.diagram1.LayoutManager = layout
			LayoutNodes()
		End Sub

		Private Sub apply_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.diagram1.BeginUpdate()
			dtLayoutMgr = New OrgChartLayoutManager(Me.diagram1.Model, RotateDirection.TopToBottom, 20, 50, CType(System.Enum.Parse(GetType(LayoutType), Me.comboLytType.SelectedItem.ToString(), True), LayoutType), 1, True)
			If txtHSpacing.Text <> String.Empty Then
				dtLayoutMgr.LeftMargin = Single.Parse(txtLMarigin.Text)
			End If
			If txtVSpacing.Text <> String.Empty Then
				dtLayoutMgr.TopMargin = Single.Parse(txtTMarigin.Text)
			End If
			If txtLMarigin.Text <> String.Empty Then
				dtLayoutMgr.HorizontalSpacing = Single.Parse(txtHSpacing.Text)
			End If
			If txtTMarigin.Text <> String.Empty Then
				dtLayoutMgr.VerticalSpacing = Single.Parse(txtVSpacing.Text)
			End If

			dtLayoutMgr.AutoLayout = chkAutoLayout.Checked

			Me.diagram1.LayoutManager = Me.dtLayoutMgr
			Me.dtLayoutMgr.UpdateLayout(Nothing)
			Me.diagram1.EndUpdate()
			Me.diagram1.UpdateView()
		End Sub

		Private Sub comboExpSymbol_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.diagram1.BeginUpdate()
			For Each node As Node In diagram1.Model.Nodes
				If TypeOf node Is EmpSymbol Then
					If comboExpSymbol.SelectedIndex = 1 Then
						CType(node, EmpSymbol).SymbolShapeType = EmpSymbol.SymbolShape.PlusMinus
					ElseIf comboExpSymbol.SelectedIndex = 0 Then
						CType(node, EmpSymbol).SymbolShapeType = EmpSymbol.SymbolShape.RightDownTriangle
					End If
				End If
			Next node
			Me.diagram1.Refresh()
			Me.diagram1.EndUpdate()
		End Sub

		Private Sub comboBShape_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.diagram1.BeginUpdate()
			For Each node As Node In diagram1.Model.Nodes
				If TypeOf node Is EmpSymbol Then
					If comboBShape.SelectedIndex = 1 Then
						CType(node, EmpSymbol).BackgroundShapeType = EmpSymbol.BackgroundShape.ellipse
					ElseIf comboBShape.SelectedIndex = 0 Then
						CType(node, EmpSymbol).BackgroundShapeType = EmpSymbol.BackgroundShape.Rectangle
					End If
				End If
			Next node
			Me.diagram1.Refresh()
			Me.diagram1.EndUpdate()
		End Sub

		Private Sub EventSink_NodeMouseEnter(ByVal evtArgs As Syncfusion.Windows.Forms.Diagram.NodeMouseEventArgs)
			diagram1.Controller.ActiveTool.ActionCursor = Cursors.Arrow
		End Sub

		Private Sub diagram1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim node As EmpSymbol = TryCast(diagram1.Controller.GetNodeAtPoint(diagram1.Controller.ConvertToModelCoordinates(e.Location)), EmpSymbol)
			If node IsNot Nothing Then
				node.MouseMove(diagram1.Controller.ConvertToModelCoordinates(e.Location))
			End If
		End Sub
		#End Region

		#Region "Helper Methods"

		Private Sub LayoutNodes()
			' Temporarily suspend the layoutmanager
			Me.diagram1.LayoutManager.AutoLayout = False

			Me.diagram1.LayoutManager.Nodes.Clear()
			Me.diagram1.LayoutManager.Nodes.AddRange(Me.diagram1.Model.Nodes)
			Me.diagram1.LayoutManager.UpdateLayout(Nothing)
		End Sub
		#End Region
	End Class
End Namespace