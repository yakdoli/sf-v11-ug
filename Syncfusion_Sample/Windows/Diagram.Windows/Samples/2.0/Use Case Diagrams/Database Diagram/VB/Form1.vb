Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Drawing.Printing
Imports System.Drawing.Imaging
Imports Syncfusion.SVG.IO
Imports Syncfusion.Windows.Forms
Imports System.Collections
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Xml

Namespace DatabaseDiagram
    Partial Public Class Form1
        Inherits Form
#Region "Members"

        Private needSave As Boolean = False
        Public fileName As String
        Private mousePt As Point
        Private prevbNode As Node = Nothing
        Private fileDialog As New OpenFileDialog()
        Private datasrcpath As String = "..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Database.xml"
#End Region

#Region "Form initialize"
        Public Sub New()
            InitializeComponent()
            diagram1.BeginUpdate()
            Me.diagram1.Model.BoundaryConstraintsEnabled = False
            Me.diagram1.Model.LineStyle.LineColor = Color.LightGray
            Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
            InitailizeDiagram()
            diagram1.EndUpdate()
            cboDatabaseDiagram.SelectedIndex = 0
            AddHandler diagram1.EventSink.NodeClick, AddressOf EventSink_NodeClick
            ' Wire up OnIdle processing
            AddHandler Application.Idle, AddressOf Application_Idle
        End Sub


#End Region

#Region "Private Methods"

        ''' <summary>
        ''' Change's the appearance of the Diagram 
        ''' </summary>
        Private Sub DiagramAppearance()

            Me.diagram1.HorizontalRuler.BackgroundColor = Color.White
            Me.diagram1.VerticalRuler.BackgroundColor = Color.White
            Me.diagram1.View.Grid.GridStyle = GridStyle.Line
            Me.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            Me.diagram1.View.Grid.Color = Color.LightGray
            Me.diagram1.View.Grid.VerticalSpacing = 15
            Me.diagram1.View.Grid.HorizontalSpacing = 15
            Me.diagram1.Model.BackgroundStyle.GradientCenter = 0.5F
            Me.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue
            Me.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue
            Me.diagram1.Model.DocumentSize = New PageSize(Me.diagram1.View.ClientRectangle.Size.Width, diagram1.View.ClientRectangle.Size.Height)
            Me.diagram1.Model.BoundaryConstraintsEnabled = False
            Me.diagram1.Model.MinimumSize = diagram1.View.ClientRectangle.Size
            Me.diagram1.Model.SizeToContent = True
            Me.diagram1.View.SelectionList.Clear()
        End Sub
#End Region

#Region "Initailize Diagram "
        ''' <summary>
        ''' Initializes the diagram
        ''' </summary>
        Private Sub InitailizeDiagram()
            InitializeDiagramFromXMLData(datasrcpath)
            diagram1.View.SelectionList.Clear()
        End Sub

        ''' <summary>
        ''' Make connection establishment between nodes
        ''' </summary>
        Private Sub ConnectNodes()
            If cboDatabaseDiagram.SelectedIndex = 0 Then
                diagram1.Model.Nodes("Employee").PinPoint = New PointF(450, 150)
                diagram1.Model.Nodes("Publishers").PinPoint = New PointF(100, 150)
                diagram1.Model.Nodes("Titles").PinPoint = New PointF(100, 480)
                diagram1.Model.Nodes("PubInfo").PinPoint = New PointF(300, 350)
                diagram1.Model.Nodes("Sales").PinPoint = New PointF(750, 480)
                diagram1.Model.Nodes("Stores").PinPoint = New PointF(750, 310)
                diagram1.Model.Nodes("Discounts").PinPoint = New PointF(750, 100)

                ConnectNodes(diagram1.Model.Nodes("Employee"), diagram1.Model.Nodes("Publishers"), "OneToMany")
                ConnectNodes(diagram1.Model.Nodes("Publishers"), diagram1.Model.Nodes("Titles"), "OneToMany")
                ConnectNodes(diagram1.Model.Nodes("Publishers"), diagram1.Model.Nodes("PubInfo"), "OneToOne")
                ConnectNodes(diagram1.Model.Nodes("Titles"), diagram1.Model.Nodes("Sales"), "OneToMany")
                ConnectNodes(diagram1.Model.Nodes("Stores"), diagram1.Model.Nodes("Sales"), "OneToMany")
                ConnectNodes(diagram1.Model.Nodes("Stores"), diagram1.Model.Nodes("Discounts"), "OneToMany")
            ElseIf cboDatabaseDiagram.SelectedIndex = 1 Then
                diagram1.Model.Nodes("Course").PinPoint = New PointF(200, 200)
                diagram1.Model.Nodes("Department").PinPoint = New PointF(200, 500)
                diagram1.Model.Nodes("CourseInstructor").PinPoint = New PointF(500, 100)
                diagram1.Model.Nodes("Person").PinPoint = New PointF(500, 300)
                diagram1.Model.Nodes("Enrollment").PinPoint = New PointF(500, 550)
                ConnectNodes(diagram1.Model.Nodes("Course"), diagram1.Model.Nodes("Department"), "OneToMany")
                ConnectNodes(diagram1.Model.Nodes("Course"), diagram1.Model.Nodes("CourseInstructor"), "OneToMany")
                ConnectNodes(diagram1.Model.Nodes("Course"), diagram1.Model.Nodes("Enrollment"), "OneToMany")
                ConnectNodes(diagram1.Model.Nodes("CourseInstructor"), diagram1.Model.Nodes("Person"), "OneToMany")
                ConnectNodes(diagram1.Model.Nodes("Person"), diagram1.Model.Nodes("Enrollment"), "OneToMany")
            ElseIf cboDatabaseDiagram.SelectedIndex = 2 Then
                diagram1.Model.Nodes("Payments").PinPoint = New PointF(200, 150)
                diagram1.Model.Nodes("Employees").PinPoint = New PointF(600, 150)
                diagram1.Model.Nodes("LoanTypes").PinPoint = New PointF(175, 450)
                diagram1.Model.Nodes("LoanAllocations").PinPoint = New PointF(400, 450)
                diagram1.Model.Nodes("Customers").PinPoint = New PointF(610, 450)
                ConnectNodes(diagram1.Model.Nodes("Payments"), diagram1.Model.Nodes("Employees"), "OneToMany")
                ConnectNodes(diagram1.Model.Nodes("LoanAllocations"), diagram1.Model.Nodes("LoanTypes"), "OneToMany")
                ConnectNodes(diagram1.Model.Nodes("LoanAllocations"), diagram1.Model.Nodes("Customers"), "OneToMany")
                ConnectNodes(diagram1.Model.Nodes("Payments"), diagram1.Model.Nodes("LoanAllocations"), "OneToMany")
                ConnectNodes(diagram1.Model.Nodes("LoanAllocations"), diagram1.Model.Nodes("Employees"), "OneToMany")
            End If

        End Sub

        ''' <summary>
        ''' Initialize the Diagram from XML file
        ''' </summary>
        Protected Sub InitializeDiagramFromXMLData(ByVal path As String)
            diagram1.Model.Clear()
            diagram1.Model.BeginUpdate()
            Dim rrect As New RoundRect(900, 30, 250, 70, MeasureUnits.Pixel)
            rrect.FillStyle.Color = Color.Transparent
            rrect.EditStyle.AllowSelect = False
            rrect.LineStyle.LineColor = Color.Gray
            Dim lbl As New Syncfusion.Windows.Forms.Diagram.Label(rrect, "Relationships")
            lbl.Position = Position.TopLeft
            lbl.FontStyle.Family = "Segoe UI"
            lbl.FontStyle.Size = 9
            rrect.Labels.Add(lbl)
            Dim lblOneToOne As New Syncfusion.Windows.Forms.Diagram.Label(rrect, ": OneToOne")
            lblOneToOne.FontStyle.Family = "Segoe UI"
            lblOneToOne.FontStyle.Size = 9
            lblOneToOne.OffsetX = 120
            lblOneToOne.OffsetY = 10
            rrect.Labels.Add(lblOneToOne)
            Dim lblOneToMany As New Syncfusion.Windows.Forms.Diagram.Label(rrect, ": OneToMany")
            lblOneToMany.FontStyle.Family = "Segoe UI"
            lblOneToMany.FontStyle.Size = 9
            lblOneToMany.OffsetX = 120
            lblOneToMany.OffsetY = 40
            rrect.Labels.Add(lblOneToMany)
            diagram1.Model.AppendChild(rrect)
            Dim oneToOne As New LineConnector(New PointF(910, 50), New PointF(1010, 50))
            oneToOne.EditStyle.AllowSelect = False
            oneToOne.TailDecorator.DecoratorShape = DecoratorShape.FilledDiamond
            oneToOne.HeadDecorator.DecoratorShape = DecoratorShape.FilledDiamond
            diagram1.Model.AppendChild(oneToOne)

            Dim oneToMany As New LineConnector(New PointF(910, 80), New PointF(1010, 80))
            oneToMany.EditStyle.AllowSelect = False
            oneToMany.TailDecorator.DecoratorShape = DecoratorShape.Diamond
            oneToMany.HeadDecorator.DecoratorShape = DecoratorShape.FilledDiamond
            diagram1.Model.AppendChild(oneToMany)


            ' Read data from the XML data file and populate a Hashtable using the employee ID as the key
            Dim lstEmployees As Hashtable = Me.ReadEmployeeDataFromXMLFile(path)

            ' Create a manager-employee nested list with top-level employees forming the root nodes
            Dim sortedlist As ArrayList = Me.GetSortedEmployeesList(lstEmployees)

            For Each emply As Employee In sortedlist
                Me.IterUpdateSubEmployeeCount(emply)
            Next emply

            ' Create diagram symbol nodes for each employee and initialize the diagram
            Me.CreateOrgDiagramFromList(sortedlist)
            lstEmployees.Clear()
            sortedlist.Clear()

            'Make connection between nodes
            ConnectNodes()
            diagram1.Model.EndUpdate()
            diagram1.View.SelectionList.Clear()
        End Sub

        ''' <summary>
        ''' Generates the SubEmployee count
        ''' </summary>
        ''' <param name="empl">Employee</param>
        Protected Sub IterUpdateSubEmployeeCount(ByVal empl As Employee)
            empl.RecSubEmployeeCount = empl.SubEmployees.Count
            For Each subempl As Employee In empl.SubEmployees
                Me.IterUpdateSubEmployeeCount(subempl)
                empl.RecSubEmployeeCount += subempl.RecSubEmployeeCount
            Next subempl
        End Sub

        ''' <summary>
        ''' Read data from the XML file
        ''' </summary>
        ''' <param name="datasrc">XML file</param>
        ''' <returns>returns the table</returns>
        Protected Function ReadEmployeeDataFromXMLFile(ByVal datasrc As String) As Hashtable
            Dim lstEmployee As New Hashtable()

            ' Use the XML DOM to read data from the employees XML data file
            Dim xmldoc As New XmlDocument()
            Try
                xmldoc.Load(datasrc)
                If xmldoc.DocumentElement.HasChildNodes Then
                    Dim employeelist As XmlNodeList = xmldoc.DocumentElement.ChildNodes
                    For i As Integer = 0 To employeelist.Count - 1
                        ' Create an Employee instance to represent each employee
                        Dim emply As New Employee()

                        Dim employeenode As XmlNode = employeelist(i)
                        emply.TableName = employeenode.Name
                        Dim strTableName As String = employeenode.Name
                        Dim strColoumnName As New ArrayList()

                        Dim employeedatalist As XmlNodeList = employeenode.ChildNodes
                        Dim employeedata As IEnumerator = employeedatalist.GetEnumerator()
                        employeedata.Reset()
                        Do While employeedata.MoveNext()
                            Dim dataelement As XmlNode = TryCast(employeedata.Current, XmlNode)
                            strColoumnName.Add(dataelement.Name)

                            Select Case dataelement.Name
                                Case "PrimaryKey"
                                    emply.PrimaryKeyID = dataelement.InnerText
                                Case "ForeignKey"
                                    emply.ForeignKeyID = dataelement.InnerText
                                Case "TableID"
                                    emply.EmployeeID = dataelement.InnerText
                                Case Else
                                    emply.Coloumns.Add(dataelement.Name)
                            End Select
                        Loop
                        lstEmployee.Add(emply.EmployeeID, emply)
                    Next i
                End If
            Catch
                MessageBox.Show("Could not able to load the xml file")
            End Try

            Return lstEmployee
        End Function

        ''' <summary>
        '''  Rearrange the employees collection as a manager-subemployee nested tree
        ''' </summary>
        ''' <param name="htemployees">List of data</param>
        ''' <returns>returns sorted data list</returns>
        Private Function GetSortedEmployeesList(ByVal htemployees As Hashtable) As ArrayList
            Dim employees As ICollection = htemployees.Values
            Dim sortedlist As New ArrayList()
            For Each emply As Employee In employees
                If emply.ForeignKeyID = String.Empty Then
                    ' Employees without a ManagerID are top-level nodes in the org tree
                    sortedlist.Add(emply)
                Else
                    ' Find the employee instance associated with the managerID and add this object as 
                    ' a subemployee of the manager node.
                    Dim manager As Employee = CType(htemployees(emply.ForeignKeyID), Employee)
                    If manager IsNot Nothing Then
                        manager.SubEmployees.Add(emply)
                    End If
                End If
            Next emply

            Return sortedlist
        End Function


        ''' <summary>
        ''' Create diagram symbol nodes for each employee in the organization and add these symbols to the diagram
        ''' Create links between manager and sub-employees to depict the org structure
        ''' </summary>
        ''' <param name="alemployees"></param>
        Private Sub CreateOrgDiagramFromList(ByVal alemployees As ArrayList)
            ' Temporarily suspend the Diagram Model redrawing
            Me.diagram1.Model.BeginUpdate()

            For Each emply As Employee In alemployees
                Dim emplysymbol As Group = InsertSymbolEmployee(emply)
                Me.IterCreateEmployeeSymbol(emply, emplysymbol)
            Next emply

            ' ReEnable the Model redraw
            Me.diagram1.Model.EndUpdate()
        End Sub

        ''' <summary>
        ''' Iterative sub-employee symbol node creation
        ''' </summary>
        ''' <param name="emply">Employees business object</param>
        ''' <param name="emplysymbol">Node</param>
        Private Sub IterCreateEmployeeSymbol(ByVal emply As Employee, ByVal emplysymbol As Group)
            For Each subemply As Employee In emply.SubEmployees
                ' Create a EmployeeSymbol for each of the sub-employees of the particular employee //Waterfall, Horizontal
                Dim subemplysymbol As Group = InsertSymbolEmployee(subemply)
                Me.IterCreateEmployeeSymbol(subemply, subemplysymbol)
            Next subemply
        End Sub

        ''' <summary>
        ''' Insert Node
        ''' </summary>
        ''' <param name="employee">Employee object</param>
        ''' <returns>returns the node</returns>
        Private Function InsertSymbolEmployee(ByVal employee As Employee) As Group
            Dim Symbol As New DataSymbol(employee.Coloumns, employee.TableName, employee.PrimaryKeyID)
            Me.diagram1.Model.AppendChild(Symbol)
            Return Symbol
        End Function


        ''' <summary>
        ''' Connect Nodes with connectors
        ''' </summary>
        ''' <param name="emplysymbol">Parent</param>
        ''' <param name="subemplysymbol">Child</param>
        ''' <param name="relation">relationship</param>
        Private Sub ConnectNodes(ByVal emplysymbol As Node, ByVal subemplysymbol As Node, ByVal relation As String)
            Dim ortholink As New LineConnector(PointF.Empty, New PointF(0, 1))
            ortholink.LineStyle.DashStyle = DashStyle.Solid

            ortholink.LineStyle.LineWidth = 1.0F
            ortholink.LineStyle.LineColor = Color.Black
            If relation = "OneToMany" Then
                ortholink.TailDecorator.DecoratorShape = DecoratorShape.Diamond
            Else
                ortholink.TailDecorator.DecoratorShape = DecoratorShape.FilledDiamond
            End If

            ortholink.HeadDecorator.DecoratorShape = DecoratorShape.FilledDiamond

            Me.diagram1.Model.AppendChild(ortholink)

            If emplysymbol.CentralPort IsNot Nothing AndAlso subemplysymbol.CentralPort IsNot Nothing Then
                emplysymbol.CentralPort.TryConnect(ortholink.TailEndPoint)
                subemplysymbol.CentralPort.TryConnect(ortholink.HeadEndPoint)
            End If

            Me.diagram1.Controller.SendToBack()
        End Sub

#End Region

#Region "Properties"

        Public Property SaveChanges() As Boolean
            Get
                If diagram1.Model.Modified OrElse needSave Then
                    Return True
                Else
                    Return False
                End If
            End Get
            Set(ByVal value As Boolean)
                needSave = value
            End Set
        End Property

        Public ReadOnly Property HasFileName() As Boolean
            Get
                Return (Me.fileName IsNot Nothing AndAlso Me.fileName.Length > 0)
            End Get
        End Property

#End Region

#Region "Event Handlers"
        Private Sub EventSink_NodeClick(ByVal evtArgs As NodeMouseEventArgs)
            If diagram1.Controller.TextEditor.IsEditing Then
                diagram1.Controller.TextEditor.EndEdit(True)
            End If
            Dim nodes As NodeCollection = TryCast(diagram1.Controller.GetAllNodesAtPoint(diagram1.Model, diagram1.Controller.MouseLocation), NodeCollection)

            For Each gnode As Node In nodes
                If TypeOf gnode Is TextNode Then
                    diagram1.Controller.TextEditor.BeginEdit(gnode, False)
                End If
                If gnode.Name = "BaseNode" Then
                    If prevbNode Is Nothing Then
                        prevbNode = gnode
                    End If
                    If prevbNode Is gnode Then
                        CType(gnode, FilledPath).FillStyle.Color = Color.FromArgb(117, 186, 255)
                        '((FilledPath)prevbNode).FillStyle.Color = Color.WhiteSmoke;
                    Else
                        CType(gnode, FilledPath).FillStyle.Color = Color.FromArgb(117, 186, 255)
                        CType(prevbNode, FilledPath).FillStyle.Color = Color.WhiteSmoke
                        prevbNode = gnode
                    End If
                End If
            Next gnode
        End Sub

        Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
            If Me.diagram1 IsNot Nothing AndAlso Me.diagram1.Model IsNot Nothing Then
                Me.saveToolStripButton.Enabled = True
                Me.saveAsToolStripButton.Enabled = True


            Else
                Me.saveToolStripButton.Enabled = False
                Me.saveAsToolStripButton.Enabled = False

            End If
        End Sub


        Private Sub saveToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveToolStripButton.Click
            saveFileDialog1.Filter = "EDD file(*.edd)|*.edd"
            If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                diagram1.SaveBinary(saveFileDialog1.FileName)
            End If
        End Sub

        Private Sub saveAsToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveAsToolStripButton.Click
            Me.saveFileDialog1.FileName = "Diagram"
            saveFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*"
            saveFileDialog1.Title = "Save File As:"

            If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Select Case saveFileDialog1.FilterIndex
                    Case 1
                        diagram1.SaveBinary(saveFileDialog1.FileName)
                    Case 2
                        diagram1.SaveSoap(saveFileDialog1.FileName)
                    Case Else
                        diagram1.SaveBinary(saveFileDialog1.FileName)
                End Select
            End If
        End Sub

        Private Sub pNGToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pNGToolStripMenuItem.Click
            saveFileDialog1.Filter = "W3C Portable Network Graphics(*.png)|*.png"
            saveFileDialog1.Title = "Export Diagram As:"
            If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim imgformat As ImageFormat = ImageFormat.Png
                SaveImage(saveFileDialog1.FileName, imgformat)
            Else
                Return
            End If
        End Sub

        Private Sub jPEGToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles jPEGToolStripMenuItem.Click
            saveFileDialog1.Filter = "Joint Photographic Experts Group(*.jpeg)|*.jpeg"
            saveFileDialog1.Title = "Export Diagram As:"
            If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim imgformat As ImageFormat = ImageFormat.Jpeg
                SaveImage(saveFileDialog1.FileName, imgformat)
            Else
                Return
            End If
        End Sub

        Private Sub gIFToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gIFToolStripMenuItem.Click
            saveFileDialog1.Filter = "Graphics Interchange Format(*.gif)|*.gif"
            saveFileDialog1.Title = "Export Diagram As:"
            If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim imgformat As ImageFormat = ImageFormat.Gif
                SaveImage(saveFileDialog1.FileName, imgformat)

            Else
                Return
            End If
        End Sub

        Private Sub sVGToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sVGToolStripMenuItem.Click
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "Scalable Vector Graphics Format(*.svg)|*.svg"
            saveFileDialog1.Title = "Export Diagram As:"

            If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

                Dim tosvg As New ToSvg()
                ' Get Diagram Nodes Bounding Rectangle.
                Dim rectBounding As RectangleF = Me.diagram1.Model.GetBoundingRect()
                Dim gfx As Graphics = tosvg.GetRealGraphics(New Size(CInt(Fix(rectBounding.Width)), CInt(Fix(rectBounding.Height))))
                Me.diagram1.ExportDiagramToGraphics(gfx)
                tosvg.Save(saveFileDialog1.FileName)

            Else
                Return
            End If
        End Sub

        Private Sub zoomInToolStripMenuItem_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles zoomInToolStripMenuItem.Click
            diagram1.View.ZoomIn()
        End Sub

        Private Sub zoomOutToolStripMenuItem_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles zoomOutToolStripMenuItem.Click
            diagram1.View.ZoomOut()
        End Sub

        Private Sub resetToolStripMenuItem_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles resetToolStripMenuItem.Click
            diagram1.View.ZoomToActual()
        End Sub

#End Region

#Region "Helper Methods"
        ''' Save diagram as Image
        ''' </summary>
        ''' <param name="filename">Filename </param>
        ''' <param name="imageformat">image format</param>
        Private Sub SaveImage(ByVal filename As String, ByVal imageformat As ImageFormat)
            Dim img As Image = Me.diagram1.View.ExportDiagramAsImage(False)
            img.Save(filename, imageformat)
        End Sub

        ''' <summary>
        ''' Save diagram
        ''' </summary>
        ''' <param name="filename">file name</param>
        ''' <param name="index">index</param>
        Private Sub SaveDiagramAs(ByVal filename As String, ByVal index As Integer)
            Select Case index
                Case 1
                    diagram1.SaveBinary(filename)
                Case 2
                    diagram1.SaveSoap(filename)
                Case Else
                    diagram1.SaveBinary(filename)
            End Select
        End Sub

        ''' <summary>
        ''' Open Diagram
        ''' </summary>
        ''' <param name="filename">file name</param>
        ''' <param name="index">index</param>
        Private Sub OpenDiagramAs(ByVal filename As String, ByVal index As Integer)
            Select Case index
                Case 1
                    diagram1.LoadBinary(filename)
                Case 2
                    diagram1.LoadSoap(filename)
                Case Else
                    diagram1.LoadBinary(filename)
            End Select
        End Sub

        ''' <summary>
        ''' Activates the given tool
        ''' </summary>
        ''' <param name="toolName">Tool</param>
        Private Sub SetActiveTool(ByVal toolName As String)
            Me.diagram1.Controller.ActivateTool(toolName)
        End Sub
#End Region

        Private Sub cboDatabaseDiagram_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboDatabaseDiagram.SelectedIndexChanged
            If cboDatabaseDiagram.SelectedIndex = 0 Then
                InitializeDiagramFromXMLData("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Database.xml")
            ElseIf cboDatabaseDiagram.SelectedIndex = 1 Then
                InitializeDiagramFromXMLData("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Database1.xml")
            ElseIf cboDatabaseDiagram.SelectedIndex = 2 Then
                InitializeDiagramFromXMLData("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Database2.xml")
            End If
        End Sub
    End Class
End Namespace