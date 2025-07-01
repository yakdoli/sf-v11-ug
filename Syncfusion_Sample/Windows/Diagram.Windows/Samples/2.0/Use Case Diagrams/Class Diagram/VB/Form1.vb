Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Drawing.Printing
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports Syncfusion.SVG.IO
Imports System.Drawing.Imaging
Imports Syncfusion.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe

Namespace Class_Diagram
	Partial Public Class Form1
		Inherits Form
		#Region "Members"

		Private needSave As Boolean = False
		Public fileName As String
		Private PinPointX As Single = 0, PinPointY As Single = 0
		Private palette As New SymbolPalette()
		#End Region

		#Region "Form Initialize"
		Public Sub New()
			InitializeComponent()
			Me.diagram1.BeginUpdate()
			'Diagram Settings
			Me.diagram1.Model.LineBridgingEnabled = True
			Me.diagram1.Model.LineRoutingEnabled = True
			Me.diagram1.Model.LineRouter.RoutingMode = RoutingMode.Automatic
			Me.diagram1.Model.LineRouter.DistanceToObstacles = 20
			Me.diagram1.DefaultContextMenuEnabled = False
			Me.diagram1.Model.BoundaryConstraintsEnabled = False
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.VScroll = False
			Me.diagram1.HScroll = False
			'Generate Diagram
			CreateClassDiagram()
			'Clear selectionlist
			Me.diagram1.View.SelectionList.Clear()
			ApplyLayout()
			'Route all model connectors
			Me.diagram1.Model.LineRouter.RouteAllModelConnectors()
			GroupBarAppearance()
			Me.diagram1.EndUpdate()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Wire up OnIdle processing
			AddHandler Application.Idle, AddressOf Application_Idle
		End Sub
		#End Region

		#Region "Initialize Diagram"
		''' <summary>
		''' Initializes the diagram
		''' </summary>
		Private Sub CreateClassDiagram()
			Dim classList As List(Of ClassList) = ReadFromDatabase(1)
			GenerateClassDiagram(classList, 1)

			Dim group1 As Node = diagram1.Model.Nodes.FindNodeByName("group1")
			Dim group2 As Node = diagram1.Model.Nodes.FindNodeByName("group2")
			group2.Size = New SizeF(group2.Size.Width + 15, group2.Size.Height)
			group2.PinPoint = New PointF(group2.PinPoint.X + 15, group2.PinPoint.Y)
			Dim group3 As Node = diagram1.Model.Nodes.FindNodeByName("group3")
			Dim group4 As Node = diagram1.Model.Nodes.FindNodeByName("group4")
			Dim group5 As Node = diagram1.Model.Nodes.FindNodeByName("group5")
			Dim group6 As Node = diagram1.Model.Nodes.FindNodeByName("group6")

			'ports 
			Dim gp3 As New ConnectionPoint()
			gp3.Position = Position.MiddleRight
			gp3.Visible = False
			group3.Ports.Add(gp3)
			Dim gp5 As New ConnectionPoint()
			gp5.OffsetX = 0
			gp5.OffsetY = group5.BoundingRectangle.Height - 20
			gp5.Visible = False
			group5.Ports.Add(gp5)

			Dim Connector1 As ConnectorBase = ConnectNodes(group2, group1, DecoratorShape.DoubleArrow, "Errors", 40, -25, True, 1)
			Dim Connector2 As ConnectorBase = ConnectNodes(group3, group2, DecoratorShape.OpenFancyArrow, "Notification", 30, 20, True, 1)
			Dim Connector3 As ConnectorBase = ConnectNodes(group4, group3, DecoratorShape.Filled45Arrow, "", 0, 0, False, 0)
			Dim Connector4 As ConnectorBase = ConnectNodes(group5, group2, DecoratorShape.OpenFancyArrow, "Notification", 50, -25, True, 2)
			Dim Connector5 As ConnectorBase = ConnectNodes(group5.Ports(1), group3.Ports(1), DecoratorShape.OpenFancyArrow, "Data", 90, -15, True, 2)
			Dim Connector6 As ConnectorBase = ConnectNodes(group6, group5, DecoratorShape.Filled45Arrow, "", 0, 0, False, 0)

			Dim palette As New SymbolPalette()
			palette.Name = "Class Nodes"
			palette.AppendChild(group1)
			palette.AppendChild(group2)
			palette.AppendChild(group3)
			palette.AppendChild(group4)
			palette.AppendChild(group5)
			palette.AppendChild(group6)
			palette.AppendChild(Connector1)
			palette.AppendChild(Connector2)
			palette.AppendChild(Connector3)
			palette.AppendChild(Connector4)
			palette.AppendChild(Connector5)
			palette.AppendChild(Connector6)
			paletteGroupBar1.AddPalette(palette)

		End Sub


		Private Sub CreateClassDiagram1()
			Dim classList As List(Of ClassList) = ReadFromDatabase(2)
			GenerateClassDiagram(classList, 2)


			Dim group1 As Node = diagram1.Model.Nodes.FindNodeByName("group1")
			Dim group2 As Node = diagram1.Model.Nodes.FindNodeByName("group2")
			Dim group3 As Node = diagram1.Model.Nodes.FindNodeByName("group3")
			Dim group4 As Node = diagram1.Model.Nodes.FindNodeByName("group4")
			Dim group5 As Node = diagram1.Model.Nodes.FindNodeByName("group5")
			Dim group6 As Node = diagram1.Model.Nodes.FindNodeByName("group6")


			ConnectNodes(group1, group2, DecoratorShape.OpenFancyArrow, "", 0, 0, False, 1)
			ConnectNodes(group2, group4, DecoratorShape.OpenFancyArrow, "", 0, 0, False, 1)
			ConnectNodes(group3, group5, DecoratorShape.OpenFancyArrow, "", 0, 0, False, 0)
			ConnectNodes(group3, group6, DecoratorShape.OpenFancyArrow, "", 0, 0, False, 2)

		End Sub

		''' <summary>
		''' Generate the class diagram through ClassList
		''' </summary>
		''' <param name="classList"></param>
		Private Sub GenerateClassDiagram(ByVal classList As List(Of ClassList), ByVal DiagramType As Integer)
			If classList.Count > 0 Then
				For i As Integer = 0 To classList.Count - 1
					GetPinPoint(i, DiagramType)
					Dim custom As New CustomGroup(classList(i))
					custom.PinPoint = New PointF(PinPointX, PinPointY)
					custom.Name = "group" & (i + 1)
					diagram1.Model.AppendChild(custom)

				Next i
			End If
		End Sub

		''' <summary>
		''' Applies layout to the diagram
		''' </summary>
		Private Sub ApplyLayout()
			Dim smtLayout As New RadialTreeLayoutManager(Me.diagram1.Model, 0, 100, 30)
			smtLayout.TopMargin = 0
			smtLayout.LeftMargin = 40
			Me.diagram1.LayoutManager = smtLayout
			Me.diagram1.LayoutManager.UpdateLayout(Nothing)
		End Sub

		#End Region

		#Region "Private Methods"
		''' <summary>
		''' Change's the appearance of GroupBar
		''' </summary>
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

		''' <summary>
		''' Change's the appearance of Diagram
		''' </summary>
		Private Sub DiagramAppearance()
			Me.diagram1.Model.LineBridgingEnabled = True
			Me.diagram1.Model.LineRoutingEnabled = True
			Me.diagram1.Model.LineRouter.RoutingMode = RoutingMode.Automatic
			Me.diagram1.Model.LineRouter.DistanceToObstacles = 20
			Me.diagram1.DefaultContextMenuEnabled = False
			Me.diagram1.View.Grid.GridStyle = GridStyle.Line
			Me.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			Me.diagram1.View.Grid.Color = Color.LightGray
			Me.diagram1.View.Grid.VerticalSpacing = 15
			Me.diagram1.View.Grid.HorizontalSpacing = 15
			Me.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f
			Me.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.DocumentSize = New PageSize(Me.diagram1.View.ClientRectangle.Size.Width, diagram1.View.ClientRectangle.Size.Height)
			Me.diagram1.Model.MinimumSize = diagram1.View.ClientRectangle.Size
			Me.diagram1.Model.SizeToContent = True
			Me.diagram1.View.SelectionList.Clear()
		End Sub


		''' <summary>
		''' Connect the ParentNode and ChildNode
		''' </summary>
		''' <param name="parentNode">ParentNode</param>
		''' <param name="childNode">ChildNode</param>
		''' <param name="decoratorShape">DecoratorShape of the connector</param>
		''' <param name="labelText">Set the text to the label</param>
		''' <param name="OffsetX">Set the OffsetX to the label</param>
		''' <param name="OffsetY">Set the OffsetY to the label</param>
		''' <param name="DrawImage">Determines whether image should draw with label or not</param>
		''' <param name="classType">Classtype</param>
		Private Function ConnectNodes(ByVal parentNode As Node, ByVal childNode As Node, ByVal decoratorShape As DecoratorShape, ByVal labelText As String, ByVal OffsetX As Single, ByVal OffsetY As Single, ByVal DrawImage As Boolean, ByVal classType As Integer) As ConnectorBase
			If parentNode IsNot Nothing AndAlso childNode IsNot Nothing Then

				Dim lConnector As New OrthogonalConnector(System.Drawing.PointF.Empty, New System.Drawing.PointF(0, 1))
				lConnector.HeadDecorator.DecoratorShape = decoratorShape
				lConnector.LineRoutingEnabled = True
				lConnector.LineStyle.LineColor = Color.Goldenrod
				lConnector.LineStyle.LineWidth = 1
				lConnector.CentralPort.ConnectionsLimit = 10000

				Dim imageLabel As New ImageLabel(lConnector, labelText)
				imageLabel.OffsetX = OffsetX
				imageLabel.OffsetY = OffsetY
				imageLabel.ImageOffsetX = OffsetX - 25
				imageLabel.ImageOffsetY = OffsetY - 5
				imageLabel.DrawImage = DrawImage
				If classType = 1 Then
					imageLabel.TextImage = System.Drawing.Image.FromFile("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Class Diagram images\6.png")
				Else
					imageLabel.TextImage = System.Drawing.Image.FromFile("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Class Diagram images\7.png")
				End If
				lConnector.Labels.Add(imageLabel)
				lConnector.HeadDecorator.Size = New System.Drawing.SizeF(12, 12)
				If decoratorShape = DecoratorShape.Filled45Arrow Then
					lConnector.HeadDecorator.FillStyle.Color = Color.White
				End If
				lConnector.HeadDecorator.LineStyle.LineColor = Color.Goldenrod
				lConnector.LineRoutingEnabled = True
				parentNode.CentralPort.TryConnect(lConnector.TailEndPoint)
				childNode.CentralPort.TryConnect(lConnector.HeadEndPoint)
				Me.diagram1.Model.AppendChild(lConnector)
				Me.diagram1.Model.SendToBack(lConnector)

				Return lConnector
			Else
				Return Nothing
			End If
		End Function

		''' <summary>
		''' Connect the ParentNode's Port and ChildNode's Port
		''' </summary>
		''' <param name="parentNode">ParentNode's Port</param>
		''' <param name="childNode">ChildNode's Port</param>
		''' <param name="decoratorShape">DecoratorShape of the connector</param>
		''' <param name="labelText">Set the text to the label</param>
		''' <param name="OffsetX">Set the OffsetX to the label</param>
		''' <param name="OffsetY">Set the OffsetY to the label</param>
		''' <param name="DrawImage">Determines whether image should draw with label or not</param>
		''' <param name="classType">Classtype</param>
		Private Function ConnectNodes(ByVal parentNode As ConnectionPoint, ByVal childNode As ConnectionPoint, ByVal decoratorShape As DecoratorShape, ByVal labelText As String, ByVal OffsetX As Single, ByVal OffsetY As Single, ByVal DrawImage As Boolean, ByVal classType As Integer) As ConnectorBase
			If parentNode IsNot Nothing AndAlso childNode IsNot Nothing Then

				Dim lConnector As New OrthogonalConnector(System.Drawing.PointF.Empty, New System.Drawing.PointF(0, 1))
				lConnector.LineRoutingEnabled = True
				lConnector.LineRoutingEnabled = True
				lConnector.HeadDecorator.DecoratorShape = decoratorShape
				lConnector.LineStyle.LineColor = Color.Goldenrod
				lConnector.LineStyle.LineWidth = 1
				lConnector.CentralPort.ConnectionsLimit = 10000

				Dim imageLabel As New ImageLabel(lConnector, labelText)
				imageLabel.OffsetX = OffsetX
				imageLabel.OffsetY = OffsetY
				imageLabel.ImageOffsetX = OffsetX - 25
				imageLabel.ImageOffsetY = OffsetY - 5
				imageLabel.DrawImage = DrawImage
				If classType = 1 Then
					imageLabel.TextImage = System.Drawing.Image.FromFile("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Class Diagram images\6.png")
				Else
					imageLabel.TextImage = System.Drawing.Image.FromFile("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Class Diagram images\7.png")
				End If
				lConnector.Labels.Add(imageLabel)
				lConnector.HeadDecorator.Size = New System.Drawing.SizeF(12, 12)
				If decoratorShape = DecoratorShape.Filled45Arrow Then
					lConnector.HeadDecorator.FillStyle.Color = Color.White
				End If
				lConnector.HeadDecorator.LineStyle.LineColor = Color.Goldenrod
				lConnector.LineRoutingEnabled = True
				parentNode.TryConnect(lConnector.TailEndPoint)
				childNode.TryConnect(lConnector.HeadEndPoint)
				Me.diagram1.Model.AppendChild(lConnector)
				Me.diagram1.Model.SendToBack(lConnector)
				Return lConnector
			Else
				Return Nothing
			End If
		End Function
		''' <summary>
		''' Read the values from database and returns ClassList
		''' </summary>
		''' <returns></returns>
		Protected Function ReadFromDatabase(ByVal SelectType As Integer) As System.Collections.Generic.List(Of ClassList)
			Dim lstClass As New System.Collections.Generic.List(Of ClassList)()

			Dim strCon As String = "Data Source=..\..\..\..\..\..\..\..\..\Common\Data\Diagram\ClassDiagram.sdf"
			Dim connection As New System.Data.SqlServerCe.SqlCeConnection(strCon)
			connection.Open()

			Dim adapter As System.Data.SqlServerCe.SqlCeDataAdapter
			Dim comm As SqlCeCommand
			If SelectType = 1 Then
				comm = New SqlCeCommand("Select * from tblClassDiagram", connection)
			Else
				comm = New SqlCeCommand("Select * from tblClassDiagram1 order by ClassId", connection)
			End If
			adapter = New System.Data.SqlServerCe.SqlCeDataAdapter(comm)
			Dim ds As New System.Data.DataSet("Table")

			adapter.Fill(ds)

			If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
				Dim dt As New DataTable()
				dt = ds.Tables(0)
				For i As Integer = 0 To dt.Rows.Count - 1
					Dim classObj As New ClassList()
					classObj.ClassName = dt.Rows(i)("ClassName").ToString()
					classObj.ClassType = dt.Rows(i)("ClassType").ToString()
					classObj.ObjectType = dt.Rows(i)("ObjectType").ToString()

					For j As Integer = i To dt.Rows.Count - 1
						If dt.Rows(i)("ClassName").ToString() = dt.Rows(j)("ClassName").ToString() Then

							If Not String.IsNullOrEmpty(dt.Rows(j)("Properties").ToString()) Then
								Dim propertyList As New PropertyList()
								propertyList.PropertyName = dt.Rows(j)("Properties").ToString()
								propertyList.PropertyType = CType(System.Enum.Parse(GetType(PropertyType), dt.Rows(j)("PropertyType").ToString()), PropertyType)
								classObj.PropertyList.Add(propertyList)
							End If
							If Not String.IsNullOrEmpty(dt.Rows(j)("Methods").ToString()) Then
								Dim methodList As New MethodList()
								methodList.MethodName = dt.Rows(j)("Methods").ToString()
								methodList.MethodType = CType(System.Enum.Parse(GetType(MethodType), dt.Rows(j)("MethodType").ToString()), MethodType)
								classObj.MethodList.Add(methodList)
							End If
						Else
							i = j - 1
							lstClass.Add(classObj)
							Exit For
						End If
						If j = dt.Rows.Count - 1 Then
							i = j
							lstClass.Add(classObj)
							Exit For
						End If
					Next j

				Next i
			End If
			Return lstClass
		End Function

		''' <summary>
		''' Set the pinpoint of group
		''' </summary>
		''' <param name="i"></param>
		Protected Sub GetPinPoint(ByVal i As Integer, ByVal DiagramType As Integer)
			If DiagramType = 1 Then
				Select Case i
					Case 0
						PinPointX = 150
						PinPointY = 150
					Case 1
						PinPointX = 500
						PinPointY = 150
					Case 2
						PinPointX = 500
						PinPointY = 340
					Case 3
						PinPointX = 500
						PinPointY = 510
					Case 4
						PinPointX = 850
						PinPointY = 150
					Case 5
						PinPointX = 850
						PinPointY = 400
				End Select
			Else
				Select Case i
					Case 0
						PinPointX = 150
						PinPointY = 150
					Case 1
						PinPointX = 150
						PinPointY = 450
					Case 2
						PinPointX = 500
						PinPointY = 150
					Case 3
						PinPointX = 500
						PinPointY = 450
					Case 4
						PinPointX = 850
						PinPointY = 150
					Case 5
						PinPointX = 850
						PinPointY = 400
				End Select
			End If
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

		Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
			If Me.diagram1 IsNot Nothing AndAlso Me.diagram1.Model IsNot Nothing Then
				Me.saveToolStripButton.Enabled = True
				Me.saveAsToolStripButton.Enabled = True
				Me.cutToolStripButton.Enabled = diagram1.CanCut
				Me.copyToolStripButton.Enabled = diagram1.CanCopy
				If Me.WindowState <> FormWindowState.Minimized Then
					Me.pasteToolStripButton.Enabled = diagram1.CanPaste
				End If
				Me.undoToolStripButton.Enabled = diagram1.Model.HistoryManager.CanUndo
				Me.redoToolStripButton.Enabled = diagram1.Model.HistoryManager.CanRedo
				Me.deleteToolStripButton.Enabled = (Me.diagram1.View.SelectionList.Count > 0)

			Else
				Me.saveToolStripButton.Enabled = False
				Me.saveAsToolStripButton.Enabled = False
				Me.cutToolStripButton.Enabled = False
				Me.copyToolStripButton.Enabled = False
				If Me.WindowState <> FormWindowState.Minimized Then
					Me.pasteToolStripButton.Enabled = False
				End If
				Me.undoToolStripButton.Enabled = False
				Me.redoToolStripButton.Enabled = False
				Me.deleteToolStripButton.Enabled = False
			End If
		End Sub

		#Region "MenuTools"

		Private Sub newToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles newToolStripButton.Click
			If Me.SaveChanges Then
				Dim res As DialogResult = MessageBoxAdv.Show(Me, "The diagram or its association has been modified. Save changes?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
				If res = System.Windows.Forms.DialogResult.Yes Then
					Me.saveFileDialog1.FileName = "Diagram"
					saveFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*"
					saveFileDialog1.Title = "Save File As:"

					If Me.HasFileName Then
						Me.saveFileDialog1.FileName = Me.fileName
					End If
					If Me.saveFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
						Me.fileName = Me.saveFileDialog1.FileName
						SaveDiagramAs(saveFileDialog1.FileName, saveFileDialog1.FilterIndex)
						diagram1.Model.Clear()
						Dim model As New Model()
						model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
						model.LineStyle.LineColor = Color.LightGray
						diagram1.Model = model
					End If
				ElseIf res = System.Windows.Forms.DialogResult.No Then
					diagram1.Model.Clear()
					Dim model As New Model()
					model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
					model.LineStyle.LineColor = Color.LightGray
					diagram1.Model = model
                End If
            Else
                diagram1.Model.Clear()
                Dim model As New Model()
                model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
                model.LineStyle.LineColor = Color.LightGray
                diagram1.Model = model
                Me.fileName = ""
            End If
		End Sub

		Private Sub openToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles openToolStripButton.Click
			If Me.SaveChanges Then
				Dim res As DialogResult = MessageBoxAdv.Show(Me, "The diagram or its association has been modified. Save changes?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
				If res = System.Windows.Forms.DialogResult.Yes Then
					Me.saveFileDialog1.FileName = "Diagram"
					saveFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*"
					saveFileDialog1.Title = "Save File As:"

					If Me.saveFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
						Me.fileName = Me.saveFileDialog1.FileName
						SaveDiagramAs(saveFileDialog1.FileName, saveFileDialog1.FilterIndex)
					End If

					Me.openFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*"
					Me.openFileDialog1.Title = "Open Diagram"
					Me.openFileDialog1.FileName = ""
					If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
						If File.Exists(openFileDialog1.FileName) Then
							OpenDiagramAs(openFileDialog1.FileName, openFileDialog1.FilterIndex)
						End If
					End If
				ElseIf res = System.Windows.Forms.DialogResult.No Then
					Me.openFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*"
					Me.openFileDialog1.Title = "Open Diagram"
					Me.openFileDialog1.FileName = ""
					If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
						If File.Exists(openFileDialog1.FileName) Then
							OpenDiagramAs(openFileDialog1.FileName, openFileDialog1.FilterIndex)
						End If
					End If
				End If
			Else
				Me.openFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*"
				Me.openFileDialog1.Title = "Open Diagram"
				Me.openFileDialog1.FileName = ""
				If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					If File.Exists(openFileDialog1.FileName) Then
						OpenDiagramAs(openFileDialog1.FileName, openFileDialog1.FilterIndex)
					End If
				End If
            End If
            Me.fileName = openFileDialog1.FileName
		End Sub

        Private Sub saveToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveToolStripButton.Click
            If String.IsNullOrEmpty(fileName) OrElse (Not File.Exists(fileName)) Then
                saveFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml"
                If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                    Select Case saveFileDialog1.FilterIndex
                        Case 1
                            diagram1.SaveBinary(saveFileDialog1.FileName)
                        Case 2
                            diagram1.SaveSoap(saveFileDialog1.FileName)
                    End Select
                    Me.fileName = saveFileDialog1.FileName
                End If
            Else
                Dim fi As New FileInfo(fileName)
                If fi.Extension = ".edd" Then
                    diagram1.SaveBinary(fi.FullName)
                ElseIf fi.Extension = ".xml" Then
                    diagram1.SaveSoap(fi.FullName)
                End If
            End If
        End Sub

		Private Sub undoToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles undoToolStripButton.Click
			Me.diagram1.Model.HistoryManager.Undo()
		End Sub

		Private Sub redoToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles redoToolStripButton.Click
			Me.diagram1.Model.HistoryManager.Redo()
		End Sub

		Private Sub cutToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cutToolStripButton.Click
			diagram1.Controller.Cut()
			Me.pasteToolStripButton.Enabled = True
		End Sub

		Private Sub copyToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles copyToolStripButton.Click
			diagram1.Controller.Copy()
			Me.pasteToolStripButton.Enabled = True
		End Sub

		Private Sub pasteToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pasteToolStripButton.Click
			diagram1.Controller.Paste()
			Me.pasteToolStripButton.Enabled = False
		End Sub

		Private Sub deleteToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles deleteToolStripButton.Click
			diagram1.Model.BeginUpdate()
			diagram1.Controller.Delete()
			diagram1.Model.EndUpdate()

		End Sub

		Private Sub zoomInToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles zoomInToolStripButton.Click
			diagram1.View.ZoomIn()
		End Sub

		Private Sub zoomOutToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles zoomOutToolStripButton.Click
			diagram1.View.ZoomOut()
		End Sub

		Private Sub pageSettingsToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.diagram1 IsNot Nothing AndAlso Me.diagram1.Model IsNot Nothing Then
				Dim dlgPrintSetup As New PrintSetupDialog()

				' Made to make values more user friendly 
				dlgPrintSetup.PageSettings = Me.diagram1.View.PageSettings
				dlgPrintSetup.PrintZoom = Me.diagram1.View.PrintZoom

				If dlgPrintSetup.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					Me.diagram1.View.PageSettings = dlgPrintSetup.PageSettings
					Me.diagram1.View.PrintZoom = dlgPrintSetup.PrintZoom
					Me.diagram1.View.RefreshPageSettings()
				End If
			End If
		End Sub

		Private Sub previewToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.diagram1 IsNot Nothing Then
				Dim printDoc As PrintDocument = Me.diagram1.CreatePrintDocument()
				Dim printPreviewDlg As New PrintPreviewDialog()

				printDoc.PrinterSettings.FromPage = 0
				printDoc.PrinterSettings.ToPage = 0
				printDoc.PrinterSettings.PrintRange = PrintRange.AllPages

				printPreviewDlg.Document = printDoc
				printPreviewDlg.ShowDialog(Me)
			End If
		End Sub

		Private Sub printToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.diagram1 IsNot Nothing Then
				Dim printDoc As PrintDocument = Me.diagram1.CreatePrintDocument()
				Dim printDlg As New PrintDialog()
				printDlg.Document = printDoc

				printDlg.AllowSomePages = True

				If printDlg.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
					printDoc.PrinterSettings = printDlg.PrinterSettings
					printDoc.Print()
				End If
			End If
		End Sub

		Private Sub showGridToolStripMenuItem_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles showGridToolStripMenuItem.Click
			If Me.diagram1.View.Grid.Visible Then
				Me.diagram1.View.Grid.Visible = False
			Else
				Me.diagram1.View.Grid.Visible = True
			End If
		End Sub

		Private Sub snapToGridToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles snapToGridToolStripMenuItem1.Click
			If diagram1.View.Grid.SnapToGrid Then
				diagram1.View.Grid.SnapToGrid = False
			Else
				diagram1.View.Grid.SnapToGrid = True
			End If
		End Sub

		Private Sub helpToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim targetURL As String = "http://help.syncfusion.com/"
			System.Diagnostics.Process.Start(targetURL)
		End Sub

		Private Sub resetToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles resetToolStripButton.Click
			diagram1.View.ZoomToActual()
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

		Private Sub rulerToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Me.diagram1.ShowRulers Then
				Me.diagram1.ShowRulers = False
			Else
				Me.diagram1.ShowRulers = True
			End If
		End Sub

		Private Sub lineConnectorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lineConnectorToolStripMenuItem.Click
			SetActiveTool("LineLinkTool")
		End Sub

		Private Sub directedLineConnectorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles directedLineConnectorToolStripMenuItem.Click
			SetActiveTool("DirectedLineLinkTool")
		End Sub

		Private Sub orthogonalConnectorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles orthogonalConnectorToolStripMenuItem.Click
			SetActiveTool("OrthogonalLinkTool")
		End Sub

		Private Sub polylineConnectorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles polylineConnectorToolStripMenuItem.Click
			SetActiveTool("PolylineLinkTool")
		End Sub

		Private Sub bezierConnectorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bezierConnectorToolStripMenuItem.Click
			SetActiveTool("BezierTool")
		End Sub

		Private Sub splineConnectorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles splineConnectorToolStripMenuItem.Click
			SetActiveTool("SplineTool")
		End Sub

		#End Region

		#End Region    

		#Region "Helper Methods"
		''' <summary>
		''' Save diagram as Image
		''' </summary>
		''' <param name="filename">Filename </param>
		''' <param name="imageformat">image format</param>//Save diagram as Image
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

	End Class
End Namespace