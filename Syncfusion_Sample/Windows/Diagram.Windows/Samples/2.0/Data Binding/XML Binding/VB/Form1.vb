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


Namespace XMLBinding
	Partial Public Class Form1
		Inherits DemoForm
		#Region "Members        "

		#End Region

		#Region "Form Initialization"
		Public Sub New()
			InitializeComponent()

			diagram1.BeginUpdate()

			DiagramAppearance()
			InitializeDiagramFromXMLData("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\XML Binding.xml")
			SetLayout()
			comboXml.SelectedIndex = 0
			diagram1.View.SelectionList.Clear()

			diagram1.EndUpdate()
			AddHandler comboXml.SelectedIndexChanged, AddressOf comboXml_SelectedIndexChanged
		End Sub

		#End Region

		#Region "Private Methods"
		''' <summary>
		''' Change's the appearance of Diagram
		''' </summary>
		Private Sub DiagramAppearance()
			Me.diagram1.Model.LineStyle.LineColor = Color.LightGray
			Me.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.Model.BoundaryConstraintsEnabled = False
			Me.diagram1.View.BackgroundColor = Color.White
			Me.diagram1.View.SelectionList.Clear()
		End Sub
		#End Region

		#Region "Initailize Diagram "

		''' <summary>
		''' Apply Layout to the Diagram
		''' </summary>
		Private Sub SetLayout()
			Dim hierarchicalLayout As New HierarchicLayoutManager(diagram1.Model, 0, 100, 20)
			hierarchicalLayout.HorizontalSpacing = 20
			hierarchicalLayout.VerticalSpacing = 100
			hierarchicalLayout.LeftMargin = 10
			hierarchicalLayout.TopMargin = 20
			diagram1.LayoutManager = hierarchicalLayout
			diagram1.LayoutManager.UpdateLayout(Nothing)
		End Sub

		''' <summary>
		''' Initialize diagram from XML file
		''' </summary>
		''' <param name="datasrcpath">Path of the XML file</param>
		Protected Sub InitializeDiagramFromXMLData(ByVal datasrcpath As String)

			'C:\Users\senthilkumarm\AppData\Local\Syncfusion\EssentialStudio\10.2.0.56\Common\Data\Diagram
			' Read data from the XML data file and populate a Hashtable using the employee ID as the key
			Dim lstEmployees As System.Collections.Generic.List(Of XMLBindinglist) = Me.ReadEmployeeDataFromXMLFile(datasrcpath)
			IterCreateEmployeeSymbol(lstEmployees)

		End Sub

		''' <summary>
		''' New function for reading data from xml file
		''' </summary>
		''' <param name="datasrc">XML File</param>
		''' <returns></returns>
		Protected Function ReadEmployeeDataFromXMLFile(ByVal datasrc As String) As System.Collections.Generic.List(Of XMLBindinglist)
			Dim lstEmployee As New System.Collections.Generic.List(Of XMLBindinglist)()

			' Use the XML DOM to read data from the employees XML data file
			Dim xmldoc As New XmlDocument()
			xmldoc.Load(datasrc)
			If xmldoc.DocumentElement.HasChildNodes Then
				Dim employeelist As XmlNodeList = xmldoc.DocumentElement.ChildNodes
				For i As Integer = 0 To employeelist.Count - 1
					' Create an Employee instance to represent each employee
					Dim emply As New XMLBindinglist()

					Dim employeenode As XmlNode = employeelist(i)
					Dim employeedatalist As XmlNodeList = employeenode.ChildNodes
					Dim employeedata As IEnumerator = employeedatalist.GetEnumerator()
					employeedata.Reset()
					Do While employeedata.MoveNext()
						Dim dataelement As XmlNode = TryCast(employeedata.Current, XmlNode)
						Select Case dataelement.Name
							Case "Name"
								emply.EmployeeName = dataelement.InnerText
							Case "EmployeeID"
								emply.EmployeeID = dataelement.InnerText
							Case "Designation"
								emply.Designation = dataelement.InnerText
								emply.EmployeeName &= System.Environment.NewLine & dataelement.InnerText
							Case "ManagerID"
								emply.ManagerID = dataelement.InnerText
						End Select
					Loop
					lstEmployee.Add(emply)
				Next i
			End If

			Return lstEmployee
		End Function

		''' <summary>
		''' Iterative sub-employee symbol node creation
		''' </summary>
		''' <param name="emply">List Employees in the XML file</param>       
		Protected Sub IterCreateEmployeeSymbol(ByVal emply As List(Of XMLBindinglist))
			For Each subemply As XMLBindinglist In emply

				Dim rect As New Syncfusion.Windows.Forms.Diagram.Rectangle(200, 0, 150, 60)
				rect.Name = subemply.EmployeeID
				rect.FillStyle.Color = System.Drawing.Color.FromArgb(240, 242, 240)
				rect.FillStyle.ForeColor = System.Drawing.Color.White
				rect.FillStyle.Type = FillStyleType.LinearGradient
				rect.LineStyle.LineColor = System.Drawing.Color.Black
				Me.diagram1.Model.AppendChild(rect)
				Dim label As New Syncfusion.Windows.Forms.Diagram.Label()
				label.Container = rect
				label.Text = subemply.EmployeeName
				label.Position = Position.Center
				label.FontStyle.Family = "Segoe UI"
				label.FontStyle.Size = 8
				rect.Labels.Add(label)

				If Not String.IsNullOrEmpty(subemply.ManagerID) Then

					'OrthogonalConnector conn = new OrthogonalConnector(PointF.Empty, new PointF(0, 1));
					Dim conn As New OrgLineConnector(System.Drawing.PointF.Empty, New System.Drawing.PointF(0, 1), MeasureUnits.Pixel)
					conn.LineStyle.LineColor = System.Drawing.Color.Black
					Dim decor As Decorator = conn.HeadDecorator
					decor.DecoratorShape = DecoratorShape.Filled45Arrow
					decor.Size = New System.Drawing.SizeF(10, 10)
					decor.FillStyle.Color = System.Drawing.Color.Black
					decor.LineStyle.LineColor = System.Drawing.Color.Black
					conn.VerticalDistance = 50
					Dim rect1 As Syncfusion.Windows.Forms.Diagram.Rectangle = TryCast(diagram1.Model.Nodes.FindNodeByName(subemply.ManagerID), Syncfusion.Windows.Forms.Diagram.Rectangle)

					rect1.CentralPort.TryConnect(conn.TailEndPoint)
					rect.CentralPort.TryConnect(conn.HeadEndPoint)
					Me.diagram1.Model.AppendChild(conn)
					' this.diagram1.Model.BringToFront(rect1);
				End If
				'orgLayoutMgr.Nodes.Clear();
				'orgLayoutMgr.Nodes.AddRange(this.diagram1.Model.Nodes);
				'orgLayoutMgr.UpdateLayout(null);

			Next subemply

		End Sub
		#End Region         

		#Region "Event Handlers"

		Private Sub comboXml_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			If comboXml.SelectedIndex = 1 Then
				Me.diagram1.BeginUpdate()
				diagram1.Model.Nodes.Clear()
				InitializeDiagramFromXMLData("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\XML Binding1.xml")
				SetLayout()
				diagram1.View.SelectionList.Clear()
				diagram1.EndUpdate()
			ElseIf comboXml.SelectedIndex = 0 Then
				Me.diagram1.BeginUpdate()
				diagram1.Model.Nodes.Clear()
				InitializeDiagramFromXMLData("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\XML Binding.xml")
				SetLayout()
				diagram1.View.SelectionList.Clear()
				diagram1.EndUpdate()
			End If
		End Sub

		#End Region


	End Class

End Namespace
