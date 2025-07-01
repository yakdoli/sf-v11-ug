Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram
Imports System.IO
Imports System.Drawing.Drawing2D
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports Syncfusion.Windows.Forms.Tools
Imports System.Drawing.Printing
Imports System.Diagnostics
Imports System.Drawing.Imaging
Imports Syncfusion.SVG.IO
Imports Syncfusion.Windows.Forms

Namespace FlowDiagram_2005
    Partial Public Class MainForm
        Inherits Form
#Region "Members"
        Private lbl As Syncfusion.Windows.Forms.Diagram.Label
        Private needSave As Boolean = False
        Public fileName As String
#End Region

#Region "Form Initialize"
        Public Sub New()
            InitializeComponent()
            paletteGroupBar1.LoadPalette("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Flowchart Symbols.edp")

            Me.diagram1.BeginUpdate()
            Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
            Me.diagram1.Model.BoundaryConstraintsEnabled = False
            InitailizeDiagram()
            Me.diagram1.View.SelectionList.Clear()
            GroupBarAppearance()
            Me.diagram1.EndUpdate()

            ' Wire up OnIdle processing
            AddHandler Application.Idle, AddressOf Application_Idle
        End Sub
#End Region

#Region "Initailize Diagram with nodes"
        ''' <summary>
        ''' Initialize the diagram
        ''' </summary>
        Protected Sub InitailizeDiagram()
            ' Add a TextNode to highlight the Diagram Name
            Dim txtnode As Syncfusion.Windows.Forms.Diagram.TextNode = New TextNode("Simple Flow Diagram")
            txtnode.FontStyle.Size = 17
            txtnode.FontStyle.Bold = True
            txtnode.FontStyle.Family = "Arial"
            txtnode.FontColorStyle.Color = Color.Black
            txtnode.LineStyle.LineColor = Color.Transparent
            txtnode.SizeToText(Size.Empty)
            InsertNode(txtnode, New PointF(290, 15))

            If Me.paletteGroupBar1.CurrentSymbolPalette Is Nothing Then
                Return
            End If

            ' Insert the Network Symbols.
            ' Insert start  
            Dim start As Node = InsertNodeFromPallete("Start/End", New PointF(295, 37), "Start", New SizeF(120, 45))
            'Insert process1  
            Dim process1 As Node = InsertNodeFromPallete("Process", New PointF(325, 102), "Answer Phone", New SizeF(120, 45))
            ' Insert decision1
            Dim decision1 As Node = InsertNodeFromPallete("Decision", New PointF(325, 175), "How can we help?", New SizeF(120, 60))
            'Insert process2 
            Dim process2 As Node = InsertNodeFromPallete("Process", New PointF(70, 252), "Take name and company", New SizeF(120, 45))
            ' Insert process3
            Dim process3 As Node = InsertNodeFromPallete("Process", New PointF(70, 327), "Transfer to sales", New SizeF(120, 45))
            'Insert end1 
            Dim end1 As Node = InsertNodeFromPallete("Start/End", New PointF(40, 402), "Finish", New SizeF(120, 45))
            'Insert decision2 
            Dim decision2 As Node = InsertNodeFromPallete("Decision", New PointF(325, 255), "What is problem?", New SizeF(120, 60))
            'Insert process4
            Dim process4 As Node = InsertNodeFromPallete("Process", New PointF(325, 330), "Take name and company", New SizeF(120, 45))
            'Insert process5
            Dim process5 As Node = InsertNodeFromPallete("Process", New PointF(325, 390), "Transfer to help", New SizeF(120, 45))
            'Insert end2
            Dim end2 As Node = InsertNodeFromPallete("Start/End", New PointF(295, 465), "Finish", New SizeF(120, 45))

            '	Add TextNodes to display Layer Names
            InsertTextNode("Product info, or help placing order", New PointF(130, 180), New SizeF(135, 35))
            InsertTextNode("Other", New PointF(480, 200), New SizeF(90, 30))
            InsertTextNode("Shipping", New PointF(235, 280), New SizeF(90, 30))
            InsertTextNode("Billing", New PointF(480, 280), New SizeF(90, 30))
            InsertTextNode("Problems with product?", New PointF(272, 316), New SizeF(90, 30))


            ' Create Links between the NetworkSymbols.
            ConnectNodes(start, process1)
            ConnectNodes(process1, decision1)
            ConnectNodes(decision1, process2)
            ConnectNodes(process2, process3)
            ConnectNodes(process3, end1)
            ConnectNodes(decision1, decision2)
            ConnectNodes(decision2, process4)
            ConnectNodes(process4, process5)
            ConnectNodes(process5, end2)

            ConnectNodes(decision1, "right")
            ConnectNodes(decision2, "right")
            ConnectNodes(decision2, "left")
        End Sub

        ''' <summary>
        ''' Insert the node
        ''' </summary>
        ''' <param name="strText">TextNode's text</param>
        ''' <param name="ptPinPoint">Node's Location </param>
        ''' <param name="nodeSize">Node's size</param>
        ''' <returns>returns the node</returns>
        Private Function InsertTextNode(ByVal strText As String, ByVal ptPinPoint As PointF, ByVal nodeSize As SizeF) As TextNode
            Dim txtnode As Syncfusion.Windows.Forms.Diagram.TextNode = New TextNode(strText)

            txtnode.FontStyle.Size = 10
            txtnode.FontStyle.Family = "Arial"
            txtnode.FontColorStyle.Color = Color.Black
            txtnode.LineStyle.LineColor = Color.Transparent
            txtnode.Size = nodeSize

            InsertNode(txtnode, ptPinPoint)
            Return txtnode
        End Function

        ''' <summary>
        ''' Inserts the node
        ''' </summary>
        ''' <param name="node">Node</param>
        ''' <param name="ptPinPoint">Node's Location</param>
        ''' <returns>returns the node</returns>
        Private Function InsertNode(ByVal node As Node, ByVal ptPinPoint As PointF) As Node
            Dim units As MeasureUnits = MeasureUnits.Pixel
            Dim szPinOffset As SizeF = (CType(node, IUnitIndependent)).GetPinPointOffset(units)
            ptPinPoint.X += szPinOffset.Width
            ptPinPoint.Y += szPinOffset.Height
            CType(node, IUnitIndependent).SetPinPoint(ptPinPoint, units)
            node.EnableCentralPort = True
            Me.diagram1.Model.AppendChild(node)
            Return node
        End Function

        ''' <summary>
        ''' Insert the node from palette
        ''' </summary>
        ''' <param name="name">Node name</param>
        ''' <param name="ptPinPoint">Node location</param>
        ''' <param name="label">Label's text</param>
        ''' <param name="nodeSize">Node size</param>
        ''' <returns>returns the node</returns>
        Private Function InsertNodeFromPallete(ByVal name As String, ByVal ptPinPoint As PointF, ByVal label As String, ByVal nodeSize As SizeF) As Node
            Dim node As Node = Nothing
            Dim nodes As NodeCollection = paletteGroupBar1.CurrentSymbolPalette.Nodes

            If name IsNot Nothing Then
                node = CType(nodes(name).Clone(), Node)
                InsertNode(node, ptPinPoint)
            End If

            'Set Node's size
            node.Size = nodeSize
            'Add labels to node
            lbl = New Syncfusion.Windows.Forms.Diagram.Label(node, label)
            lbl.FontStyle.Family = "Arial"
            CType(node, PathNode).Labels.Add(lbl)

            Return node
        End Function

        ''' <summary>
        ''' Connects the node
        ''' </summary>
        ''' <param name="parentNode">parent node</param>
        ''' <param name="subNode">child node</param>
        Private Sub ConnectNodes(ByVal parentNode As Node, ByVal subNode As Node)
            If parentNode.CentralPort Is Nothing OrElse subNode.CentralPort Is Nothing Then
                Return
            End If

            Me.diagram1.Model.BeginUpdate()
            ' Create directed link
            Dim pts() As PointF = {PointF.Empty, New PointF(0, 1)}
            Dim line As New OrthogonalConnector(pts(0), pts(1))
            line.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow
            line.HeadDecorator.FillStyle.Color = Color.Black
            line.LineStyle.LineColor = Color.Black
            Me.diagram1.Model.AppendChild(line)
            'Connect connectors's end points to the node ports. 
            parentNode.CentralPort.TryConnect(line.TailEndPoint)
            subNode.CentralPort.TryConnect(line.HeadEndPoint)
            Me.diagram1.Model.SendToBack(line)
            Me.diagram1.Model.EndUpdate()
        End Sub

        ''' <summary>
        ''' Connect the nodes
        ''' </summary>
        ''' <param name="parentNode">parent node</param>
        ''' <param name="position">node's position</param>
        Private Sub ConnectNodes(ByVal parentNode As Node, ByVal position As String)
            If parentNode.CentralPort Is Nothing Then
                Return
            End If
            Dim pts() As PointF
            Dim line As OrthogonalConnector
            Me.diagram1.Model.BeginUpdate()

            ' Create directed link
            If position = "right" Then
                pts = New PointF() {parentNode.PinPoint, New PointF(parentNode.PinPoint.X + 200, parentNode.PinPoint.Y)}
                line = New OrthogonalConnector(pts(0), pts(1))
            Else
                pts = New PointF() {parentNode.PinPoint, New PointF(parentNode.PinPoint.X - 150, parentNode.PinPoint.Y + 220)}
                line = New OrthogonalConnector(pts(0), pts(1), True)
            End If
            line.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow
            line.HeadDecorator.FillStyle.Color = Color.Black
            line.LineStyle.LineColor = Color.Black

            Me.diagram1.Model.AppendChild(line)

            parentNode.CentralPort.TryConnect(line.TailEndPoint)
            Me.diagram1.Model.SendToBack(line)

            Me.diagram1.Model.EndUpdate()
        End Sub
#End Region

#Region "ChangeApperance of controls"
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
                    view.FlowView = True
                    view.ShowToolTips = True
                    view.ShowFlowViewItemText = True
                    view.SelectedItemColor = Color.FromArgb(255, 219, 118)
                    view.HighlightItemColor = Color.FromArgb(255, 227, 149)
                    view.SelectingItemColor = Color.FromArgb(255, 238, 184)
                    view.SelectedHighlightItemColor = Color.FromArgb(255, 218, 115)
                    view.FlowViewItemTextLength = 80
                    view.BackColor = Color.White
                    view.TextWrap = True
                    view.FlatLook = True
                    view.BorderStyle = BorderStyle.FixedSingle
                End If
            Next item
        End Sub

        ''' <summary>
        ''' Sets the Appearance of Diagram
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
            Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
            Me.diagram1.View.Grid.Visible = False
            Me.diagram1.View.BackgroundColor = Color.White
            Me.diagram1.Model.DocumentSize = New PageSize(500, 500)
            Me.diagram1.View.SelectionList.Clear()
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
            End If
            Me.fileName = ""
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
                If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
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


        Private Sub resetToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            diagram1.View.ZoomToActual()
        End Sub

        Private Sub pageSettingsToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pageSettingsToolStripButton.Click
            If Me.diagram1 IsNot Nothing AndAlso Me.diagram1.Model IsNot Nothing Then
                Dim dlgPrintSetup As New Syncfusion.Windows.Forms.Diagram.PageSetupDialog(Me.diagram1.View)

                ' Made to make values more user friendly 
                dlgPrintSetup.PrintSettings = Me.diagram1.View.PageSettings
                dlgPrintSetup.PrintZoom = Me.diagram1.View.PrintZoom

                If dlgPrintSetup.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Me.diagram1.View.PageSettings = dlgPrintSetup.PrintSettings
                    Me.diagram1.View.PrintZoom = dlgPrintSetup.PrintZoom
                    Me.diagram1.View.RefreshPageSettings()
                End If
            End If
        End Sub

        Private Sub previewToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles previewToolStripButton.Click
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

        Private Sub printToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles printToolStripButton.Click
            If Me.diagram1 IsNot Nothing Then
                Dim printDoc As PrintDocument = Me.diagram1.CreatePrintDocument()
                Dim printDlg As New PrintDialog()
                printDlg.Document = printDoc
                printDlg.UseEXDialog = True
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

        Private Sub saveAsToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveAsToolStripButton.Click
            Me.saveFileDialog1.FileName = "Diagram"
            saveFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml"
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

        Private Sub lineConnectorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lineConnectorToolStripMenuItem.Click
            SetActiveTool(New LineConnectorTool(Me.diagram1.Controller))
        End Sub

        Private Sub orthogonalConnectorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles orthogonalConnectorToolStripMenuItem.Click
            SetActiveTool(New OrthogonalConnectorTool(Me.diagram1.Controller))
        End Sub

        Private Sub polylineConnectorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles polylineConnectorToolStripMenuItem.Click
            Dim polyTool As New PolyLineConnectorTool(Me.diagram1.Controller)
            polyTool.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow
            polyTool.HeadDecorator.Size = New SizeF(6, 6)
            diagram1.Controller.ActivateTool(polyTool)
        End Sub

        Private Sub bezierConnectorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bezierConnectorToolStripMenuItem.Click
            SetActiveTool("BezierTool")
        End Sub

        Private Sub splineConnectorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles splineConnectorToolStripMenuItem.Click
            SetActiveTool("SplineTool")
        End Sub

        Private Sub panToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles panToolStripButton.Click
            SetActiveTool("panTool")
        End Sub


        Private Sub FillStyleToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FillStyleToolStripButton.Click
            If diagram1.View.SelectionList IsNot Nothing AndAlso diagram1.View.SelectionList.Count > 0 Then
                Dim fsd As New FillStyleDialog()
                Dim fs As FillStyle = Nothing
                If System.Windows.Forms.DialogResult.OK = fsd.ShowDialog() Then
                    diagram1.BeginUpdate()

                    For Each node As Node In Me.diagram1.View.SelectionList
                        If TypeOf node Is FilledPath Then
                            fs = CType(TypeDescriptor.GetProperties(node, False)("FillStyle").GetValue(node), FillStyle)
                            If fs IsNot Nothing Then
                                fs.Color = fsd.FillStyle.Color
                                fs.ForeColor = fsd.FillStyle.ForeColor
                                fs.ColorAlphaFactor = fsd.FillStyle.ColorAlphaFactor
                                fs.ForeColorAlphaFactor = fsd.FillStyle.ForeColorAlphaFactor
                                fs.Type = fsd.FillStyle.Type
                                fs.GradientAngle = fsd.FillStyle.GradientAngle
                                fs.GradientCenter = fsd.FillStyle.GradientCenter
                                fs.PathBrushStyle = fsd.FillStyle.PathBrushStyle
                                fs.HatchBrushStyle = fsd.FillStyle.HatchBrushStyle
                                fs.Texture = fsd.FillStyle.Texture
                                fs.TextureWrapMode = fsd.FillStyle.TextureWrapMode
                            End If
                        ElseIf TypeOf node Is ConnectorBase Then
                            CType(node, ConnectorBase).LineStyle.LineColor = fsd.FillStyle.Color
                            CType(node, ConnectorBase).HeadDecorator.FillStyle.Color = fsd.FillStyle.Color
                            CType(node, ConnectorBase).HeadDecorator.LineStyle.LineColor = fsd.FillStyle.Color
                        End If
                    Next node
                    diagram1.EndUpdate()
                End If
            End If
        End Sub

        Private Sub LineStyleToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LineStyleToolStripButton.Click
            If diagram1.View.SelectionList IsNot Nothing AndAlso diagram1.View.SelectionList.Count > 0 Then
                If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Me.diagram1.BeginUpdate()
                    For Each node As Node In diagram1.View.SelectionList
                        node.LineStyle.LineColor = colorDialog1.Color
                    Next node
                    diagram1.EndUpdate()
                End If
            End If
        End Sub

        Private Sub shadowToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles shadowToolStripButton.Click
            If diagram1.View.SelectionList IsNot Nothing AndAlso diagram1.View.SelectionList.Count > 0 Then
                Dim ssd As New ShadowStyleDialog()
                Dim fs As ShadowStyle = Nothing
                If System.Windows.Forms.DialogResult.OK = ssd.ShowDialog() Then
                    diagram1.BeginUpdate()
                    For Each node As Node In Me.diagram1.View.SelectionList
                        If Not (TypeOf node Is ConnectorBase) AndAlso Not (TypeOf node Is TextNode) Then
                            fs = CType(TypeDescriptor.GetProperties(node, False)("ShadowStyle").GetValue(node), ShadowStyle)
                            If fs IsNot Nothing Then
                                fs.Color = ssd.ShadowStyle.Color
                                fs.ForeColor = ssd.ShadowStyle.ForeColor
                                fs.ColorAlphaFactor = ssd.ShadowStyle.ColorAlphaFactor
                                fs.ForeColorAlphaFactor = ssd.ShadowStyle.ForeColorAlphaFactor
                                fs.PathBrushStyle = ssd.ShadowStyle.PathBrushStyle
                                fs.OffsetX = ssd.ShadowStyle.OffsetX
                                fs.OffsetY = ssd.ShadowStyle.OffsetY
                                fs.Visible = ssd.ShadowStyle.Visible
                            End If
                        End If
                    Next node
                    diagram1.EndUpdate()
                End If
            End If

        End Sub

        Private Sub shadingToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles shadingToolStripButton.Click
            If diagram1.View.SelectionList IsNot Nothing AndAlso diagram1.View.SelectionList.Count > 0 Then
                diagram1.BeginUpdate()
                For Each node As Node In diagram1.View.SelectionList
                    If TypeOf node Is FilledPath Then
                        Dim filledPath As FilledPath = CType(node, FilledPath)
                        filledPath.EnableShading = Not filledPath.EnableShading
                    End If
                Next node
                diagram1.EndUpdate()
            End If
        End Sub

        Private Sub zoomOutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles zoomOutToolStripMenuItem.Click
            diagram1.View.ZoomOut()
        End Sub

        Private Sub zoomInToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles zoomInToolStripMenuItem.Click
            diagram1.View.ZoomIn()
        End Sub

        Private Sub resetZoomToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles resetZoomToolStripMenuItem.Click
            diagram1.View.ZoomToActual()
        End Sub

#End Region

#End Region

#Region "Helper Methods"
        'Save diagram as Image
        Private Sub SaveImage(ByVal filename As String, ByVal imageformat As ImageFormat)
            Dim img As Image = Me.diagram1.View.ExportDiagramAsImage(False)
            img.Save(filename, imageformat)
        End Sub

        'Save diagram
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

        'Open Diagram
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

        Private Sub SetActiveTool(ByVal toolName As String)
            Me.diagram1.Controller.ActivateTool(toolName)
        End Sub
        Private Sub SetActiveTool(ByVal tool As LineBaseTool)
            tool.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow
            tool.HeadDecorator.Size = New SizeF(6, 6)
            Me.diagram1.Controller.ActivateTool(tool)
        End Sub
#End Region

    End Class
End Namespace