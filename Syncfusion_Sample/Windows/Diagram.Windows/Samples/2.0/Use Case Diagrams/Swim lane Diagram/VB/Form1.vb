Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports Syncfusion.Windows.Forms.Diagram
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Drawing.Imaging
Imports Syncfusion.SVG.IO
Imports Syncfusion.Windows.Forms

Namespace SwimLaneDiagram
    Partial Public Class Form1
        Inherits Form
#Region "Members"
        Private needSave As Boolean = False
        Public fileName As String
#End Region

#Region "Form Initialize"

        Public Sub New()
            InitializeComponent()
            Me.diagram1.BeginUpdate()
            Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
            Me.diagram1.Model.BoundaryConstraintsEnabled = False
            fileName = "..\..\..\..\..\..\..\..\..\Common\Data\Diagram\SwimLaneDiagram.edd"
            Me.diagram1.LoadBinary("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\SwimLaneDiagram.edd")
            Me.paletteGroupBar1.LoadPalette("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\SwimLane Symbols.edp")
            Me.paletteGroupBar1.LoadPalette("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Flowchart Symbols.edp")
            Me.diagram1.View.BackgroundColor = Color.White
            Me.diagram1.Model.LineStyle.LineWidth = 0
            GroupBarAppearance()
            Me.diagram1.EndUpdate()
            ' Wire up OnIdle processing
            AddHandler Application.Idle, AddressOf Application_Idle
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
        ''' Change's the appearance of Diagram
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
            Me.diagram1.Model.MinimumSize = New SizeF(diagram1.View.ClientRectangle.Size.Width, Me.diagram1.Model.LogicalSize.Height)
            Me.diagram1.Model.DocumentSize = New PageSize(Me.diagram1.View.ClientRectangle.Size.Width, Me.diagram1.Model.LogicalSize.Height)
            Me.diagram1.Model.BoundaryConstraintsEnabled = False
            Me.diagram1.Model.SizeToContent = True

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

        End Sub


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

        Private Sub zoomInToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles zoomInToolStripMenuItem.Click
            diagram1.View.ZoomIn()
        End Sub

        Private Sub zoomOutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles zoomOutToolStripMenuItem.Click
            diagram1.View.ZoomOut()
        End Sub

        Private Sub resetToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles resetToolStripMenuItem.Click
            diagram1.View.ZoomToActual()
        End Sub


        Private Sub pageSettingsToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pageSettingsToolStripButton.Click
            If Me.diagram1 IsNot Nothing AndAlso Me.diagram1.Model IsNot Nothing Then
                Dim dlgPrintSetup As New Syncfusion.Windows.Forms.Diagram.PageSetupDialog(diagram1.View)
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

                If printDlg.ShowDialog(Me) = DialogResult.OK Then
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
            saveFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*"
            saveFileDialog1.Title = "Save File As:"

            If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                SaveDiagramAs(saveFileDialog1.FileName, saveFileDialog1.FilterIndex)
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

        Private Sub gIFToolStripMenuItem_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles gIFToolStripMenuItem.Click
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

        Private Sub rulerToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rulerToolStripButton.Click
            Me.diagram1.ShowRulers = Not diagram1.ShowRulers
            rulerToolStripButton.Checked = Not rulerToolStripButton.Checked
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

        Private Sub splineCToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles splineCToolStripMenuItem.Click
            SetActiveTool("SplineTool")
        End Sub

        Private Sub panToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles panToolStripButton.Click
            SetActiveTool("PanTool")
        End Sub

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