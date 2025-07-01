Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports Syncfusion.Windows.Forms.Diagram
Imports Syncfusion.Windows.Forms
Imports System.Windows.Forms
Imports DiagramDBiManager.DataBinding

Namespace DiagramORM.Sample
    Partial Public Class Form1
        Inherits Form
#Region "Self Relation declaration"

        Private dEngineSelfRelation As DiagramDataBindingManagerEngine
        Private employeeList As BindingList(Of EmployeeClass)
        Private empCount As Integer = 0

#End Region

        Private dEngineParentChild As DiagramDataBindingManagerEngine
        Private familyList1 As BindingList(Of ParentChildClass)
        Private familyList2 As BindingList(Of ParentChildClass)

        Public Sub New()
            InitializeComponent()

            '			#Region "Self Relation Init"

            dEngineSelfRelation = New DiagramDataBindingManagerEngine(Me.diagram1)
            dEngineSelfRelation.ListenToRelationChanges = True
            'List of data objects
            employeeList = New BindingList(Of EmployeeClass)()
            employeeList.Add(New EmployeeClass(empCount, -1, "Mark"))
            empCount += 1
            employeeList.Add(New EmployeeClass(empCount, 0, "Spencer"))
            empCount += 1
            employeeList.Add(New EmployeeClass(empCount, 0, "Carlos"))
            empCount += 1
            employeeList.Add(New EmployeeClass(empCount, 1, "Elliot"))
            empCount += 1
            employeeList.Add(New EmployeeClass(empCount, 1, "Benson"))
            empCount += 1
            employeeList.Add(New EmployeeClass(empCount, 2, "Margaret"))
            empCount += 1
            employeeList.Add(New EmployeeClass(empCount, 1, "Rodriguez"))
            empCount += 1
            employeeList.Add(New EmployeeClass(empCount, 2, "Samuel"))
            empCount += 1
            employeeList.Add(New EmployeeClass(empCount, 4, "Micheal"))
            empCount += 1
            employeeList.Add(New EmployeeClass(empCount, 7, "Whitaker"))
            empCount += 1

            Me.comboBox1.DataSource = employeeList
            Me.comboBox1.DisplayMember = "EmployeeName"
            Me.comboBox1.ValueMember = "Id"


            Dim ltManager As New OrgChartLayoutManager(Me.diagram1.Model, RotateDirection.TopToBottom, 40, 50)
            ltManager.LeftMargin = 60
            ltManager.TopMargin = 50
            Me.diagram1.LayoutManager = ltManager
            AddHandler dEngineSelfRelation.NodeAdded, AddressOf dEngineSelfRelation_NodeAdded

            'Adding the list collection to SourceListSet
            dEngineSelfRelation.SourceListSet.Add(New SourceListSetEntry("EmployeeList", employeeList))
            dEngineSelfRelation._ProvideNodeConnectorInfo = AddressOf dEngineSelfRelation_ProvideNodeConnectorInfo
            Dim ss As NodeConnectEventHandler = New NodeConnectEventHandler(AddressOf dEngineSelfRelation_ProvideNodeConnectorInfo)
            'Adding a self relation
            dEngineSelfRelation.Relations.Add(New NodeRelationDescriptor("Manager_Employee", "EmployeeList", "Id", "EmployeeList", "ManagerId", RelationType.SelfRelation))
            Me.diagram2.LayoutManager = New OrgChartLayoutManager(Me.diagram2.Model, RotateDirection.TopToBottom, 40, 40)
            dEngineParentChild = New DiagramDataBindingManagerEngine(Me.diagram2)
            AddHandler dEngineParentChild.NodeAdded, AddressOf dEngineParentChild_NodeAdded
            dEngineParentChild._ProvideNodeConnectorInfo = AddressOf dEngineParentChild_ProvideNodeConnectorInfo
            InitFamilies()

            'Adding self-relation to MatthewFamily
            dEngineParentChild.Relations.Add(New NodeRelationDescriptor("Matthew_Family", "MatthewFamily", "Id", "MatthewFamily", "ParentId", RelationType.SelfRelation))

            'Adding self-relation to JohnsonFamily
            dEngineParentChild.Relations.Add(New NodeRelationDescriptor("Johnson_Family", "JohnsonFamily", "Id", "JohnsonFamily", "ParentId", RelationType.SelfRelation))

            'Adding parentchild / masterdetail relation between both the families
            dEngineParentChild.Relations.Add(New NodeRelationDescriptor("Matthew_Johnson", "JohnsonFamily", "Id", "MatthewFamily", "Id", RelationType.ParentChild))

            Me.diagram1.View.Grid.GridStyle = GridStyle.Line
            Me.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            Me.diagram1.View.Grid.Color = Color.LightGray
            Me.diagram1.View.Grid.VerticalSpacing = 15
            Me.diagram1.View.Grid.HorizontalSpacing = 15
            Me.diagram1.Model.BackgroundStyle.GradientCenter = 0.5F
            Me.diagram1.Model.BackgroundStyle.ForeColor = Color.Pink
            Me.diagram1.Model.BackgroundStyle.Color = Color.White
            Me.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue
            Me.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue
            Me.diagram1.View.BackgroundColor = Color.White
            Me.diagram1.Model.DocumentSize = New PageSize(800, 600)
            Me.diagram1.View.Grid.Visible = False
            Me.diagram2.Model.DocumentSize = New PageSize(900, 600)

            Me.diagram2.View.Grid.GridStyle = GridStyle.Line
            Me.diagram2.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            Me.diagram2.View.Grid.Color = Color.LightGray
            Me.diagram2.View.Grid.VerticalSpacing = 15
            Me.diagram2.View.Grid.HorizontalSpacing = 15


            Me.diagram2.View.HandleRenderer.HandleColor = Color.AliceBlue
            Me.diagram2.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue
            Me.diagram1.View.SelectionList.Clear()
            Me.diagram2.View.SelectionList.Clear()
            Me.diagram2.View.Grid.Visible = False
            Me.diagram1.View.BackgroundColor = Color.White

            Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
            Me.diagram2.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
        End Sub

#Region "SelfRelation Events and Methods"

        Private Function dEngineSelfRelation_ProvideNodeConnectorInfo(ByVal args As NodeConnectEventArgs) As ConnectorBase
            Dim connector As OrgLineConnector = Nothing
            If args.ParentNode IsNot Nothing AndAlso args.ChildNode IsNot Nothing Then
                connector = New OrgLineConnector(PointF.Empty, New PointF(0, 1))
                connector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow
                connector.HeadDecorator.LineStyle.LineColor = Color.Gray
                connector.HeadDecorator.FillStyle.Color = Color.LightGray
                connector.LineStyle.LineColor = Color.Gray
                connector.LineStyle.LineWidth = 1
                connector.HeadDecorator.Size = New SizeF(8, 8)
                'Connect the nodes
                args.ParentNode.CentralPort.TryConnect(connector.TailEndPoint)
                args.ChildNode.CentralPort.TryConnect(connector.HeadEndPoint)
            End If
            Return connector
        End Function

        Private Sub dEngineSelfRelation_NodeAdded(ByVal sender As Object, ByVal args As NodeAddedEventArgs)
            If TypeOf args.NodeObject Is Rectangle Then
                Dim rect As Rectangle = TryCast(args.NodeObject, Syncfusion.Windows.Forms.Diagram.Rectangle)
                rect.FillStyle.Color = Color.FromArgb(242, 242, 242)
                rect.FillStyle.ForeColor = Color.White
                rect.LineStyle.LineColor = Color.Black
                rect.FillStyle.Type = FillStyleType.LinearGradient
                rect.FillStyle.GradientAngle = 90
                rect.FillStyle.GradientCenter = 1
                rect.EnableShading = False
                rect.LineStyle.DashCap = System.Drawing.Drawing2D.DashCap.Round
                rect.Labels(0).FontStyle.Bold = True
                rect.Labels(0).FontStyle.Family = "Segoe UI"
                rect.Labels(0).FontColorStyle.Color = Color.Black
            End If
        End Sub

        ''' <summary>
        ''' Adding new Employee items
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub employee_Add(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            If Me.textBox1.Text <> "" Then
                employeeList.Add(New EmployeeClass(empCount, Convert.ToInt32(Me.comboBox1.SelectedValue), Me.textBox1.Text))
                empCount += 1

                Dim ltManager As New OrgChartLayoutManager(Me.diagram1.Model, RotateDirection.TopToBottom, 40, 40)
                Me.diagram1.LayoutManager = ltManager
                ltManager.UpdateLayout(Me)
            End If
        End Sub



        Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemove.Click
            'Removing an item from the list should explicitly call the RemoveNode to remove its node instance from the SourceListSetCollection and refreshing the Diagram control appropriately. It will also remove the node relation that is associated with the node instance.
            If Me.comboBox1.SelectedValue IsNot Nothing Then
                Dim empObj As Object = GetEmployeeItemFromList(Convert.ToInt32(Me.comboBox1.SelectedValue))
                If empObj IsNot Nothing Then
                    Me.dEngineSelfRelation.SourceListSet.RemoveNode(Me.dEngineSelfRelation.SourceListSet(0), empObj)
                    Me.dEngineSelfRelation.Diagram.Refresh()
                    Me.employeeList.Remove(CType(empObj, EmployeeClass))
                End If
            End If
            Dim ltManager As New OrgChartLayoutManager(Me.diagram1.Model, RotateDirection.TopToBottom, 40, 40)
            Me.diagram1.LayoutManager = ltManager
            ltManager.UpdateLayout(Me)
        End Sub

        Private Function GetEmployeeItemFromList(ByVal id As Integer) As Object
            For Each empItem As EmployeeClass In Me.employeeList
                If empItem.Id = id Then
                    Return TryCast(empItem, Object)
                End If
            Next empItem
            Return Nothing
        End Function
#End Region


#Region "ParentChild Events and Methods"

        Private Function dEngineParentChild_ProvideNodeConnectorInfo(ByVal args As NodeConnectEventArgs) As ConnectorBase
            Dim connector As ConnectorBase = Nothing
            If args.NodeRelation.RelationName = "Matthew_Family" Then
                If args.ParentNode IsNot Nothing AndAlso args.ChildNode IsNot Nothing Then
                    connector = New OrgLineConnector(PointF.Empty, New PointF(0, 1))
                    connector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow
                    connector.HeadDecorator.FillStyle.Color = Color.LightGray
                    connector.LineStyle.LineColor = Color.Gray
                    connector.LineStyle.LineWidth = 1
                    'Connect the nodes
                    args.ParentNode.CentralPort.TryConnect(connector.TailEndPoint)
                    args.ChildNode.CentralPort.TryConnect(connector.HeadEndPoint)
                End If
            ElseIf args.NodeRelation.RelationName = "Johnson_Family" Then
                If args.ParentNode IsNot Nothing AndAlso args.ChildNode IsNot Nothing Then
                    connector = New OrgLineConnector(PointF.Empty, New PointF(0, 1))
                    connector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow
                    connector.HeadDecorator.FillStyle.Color = Color.Black
                    connector.HeadDecorator.LineStyle.LineColor = Color.Black
                    connector.LineStyle.LineColor = Color.Black
                    connector.LineStyle.LineWidth = 1

                    'Connect the nodes
                    args.ParentNode.CentralPort.TryConnect(connector.TailEndPoint)
                    args.ChildNode.CentralPort.TryConnect(connector.HeadEndPoint)
                End If
            ElseIf args.NodeRelation.RelationName = "Matthew_Johnson" Then
                If args.ParentNode IsNot Nothing AndAlso args.ChildNode IsNot Nothing Then
                    connector = New OrgLineConnector(PointF.Empty, New PointF(0, 1))
                    connector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow
                    connector.HeadDecorator.FillStyle.Color = Color.LightGreen
                    connector.HeadDecorator.LineStyle.LineColor = Color.LightGreen
                    connector.LineStyle.LineColor = Color.LightGreen
                    connector.LineStyle.LineWidth = 1

                    'Connect the nodes
                    args.ParentNode.CentralPort.TryConnect(connector.TailEndPoint)
                    args.ChildNode.CentralPort.TryConnect(connector.HeadEndPoint)
                End If
            End If
            Return connector
        End Function

        Private Sub dEngineParentChild_NodeAdded(ByVal sender As Object, ByVal args As NodeAddedEventArgs)
            If args.SourceName = "MatthewFamily" Then
                Dim rectNode As Rectangle = TryCast(args.NodeObject, Syncfusion.Windows.Forms.Diagram.Rectangle)
                rectNode.Labels(0).FontStyle.Family = "Segoe UI"
                rectNode.Labels(0).FontStyle.Bold = True
                rectNode.FillStyle.Color = Color.White
                rectNode.FillStyle.Color = Color.LightSlateGray
                rectNode.FillStyle.Type = Syncfusion.Windows.Forms.Diagram.FillStyleType.LinearGradient
                rectNode.EnableShading = False

                rectNode.ShadowStyle.Visible = True
                rectNode.ShadowStyle.OffsetX = 0
                rectNode.ShadowStyle.OffsetY = 6

            ElseIf args.SourceName = "JohnsonFamily" Then
                Dim rectNode As Rectangle = TryCast(args.NodeObject, Syncfusion.Windows.Forms.Diagram.Rectangle)
                rectNode.Labels(0).FontStyle.Family = "Segoe UI"
                rectNode.Labels(0).FontStyle.Bold = True
                rectNode.Labels(0).FontStyle.Italic = True
                rectNode.FillStyle.Color = Color.Bisque
                rectNode.EnableShading = False
                rectNode.FillStyle.ForeColor = Color.White
                rectNode.FillStyle.Type = Syncfusion.Windows.Forms.Diagram.FillStyleType.LinearGradient
                rectNode.FillStyle.GradientCenter = 0.5F
                rectNode.ShadowStyle.Visible = True
                rectNode.ShadowStyle.OffsetX = 0
                rectNode.ShadowStyle.OffsetY = 6
            End If
        End Sub

        Private Sub InitFamilies()
            familyList1 = New BindingList(Of ParentChildClass)()
            familyList1.Add(New ParentChildClass(0, -1, "Matthew"))
            familyList1.Add(New ParentChildClass(1, 0, "Carl"))
            familyList1.Add(New ParentChildClass(2, 0, "Martha"))
            familyList1.Add(New ParentChildClass(3, 1, "Stephanie"))
            familyList1.Add(New ParentChildClass(4, 2, "Eddie"))
            familyList1.Add(New ParentChildClass(5, 2, "Richard"))
            dEngineParentChild.SourceListSet.Add(New SourceListSetEntry("MatthewFamily", familyList1))

            familyList2 = New BindingList(Of ParentChildClass)()
            familyList2.Add(New ParentChildClass(0, -1, "Johnson"))
            familyList2.Add(New ParentChildClass(1, 0, "Micheal"))
            familyList2.Add(New ParentChildClass(2, 0, "Julie"))
            familyList2.Add(New ParentChildClass(3, 0, "Robert"))
            familyList2.Add(New ParentChildClass(4, 1, "Bruce"))
            dEngineParentChild.SourceListSet.Add(New SourceListSetEntry("JohnsonFamily", familyList2))
        End Sub

#End Region

    End Class
End Namespace