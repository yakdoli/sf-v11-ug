Imports Microsoft.VisualBasic
Imports System
Namespace Class_Diagram
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.panel1 = New System.Windows.Forms.Panel
            Me.toolStrip1 = New System.Windows.Forms.ToolStrip
            Me.newToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.openToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.saveToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.saveAsToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.exportToolStripButton = New System.Windows.Forms.ToolStripDropDownButton
            Me.pNGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.jPEGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.gIFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.sVGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
            Me.undoToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.redoToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
            Me.cutToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.copyToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.pasteToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.deleteToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
            Me.connectorToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton
            Me.lineConnectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.directedLineConnectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.orthogonalConnectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.polylineConnectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.bezierConnectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.splineConnectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
            Me.zoomInToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.zoomOutToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.resetToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
            Me.gridToolStripButton = New System.Windows.Forms.ToolStripDropDownButton
            Me.showGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.snapToGridToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.leftImageList = New System.Windows.Forms.ImageList(Me.components)
            Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
            Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
            Me.panel2 = New System.Windows.Forms.Panel
            Me.paletteGroupBar1 = New Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(Me.components)
            Me.panel3 = New System.Windows.Forms.Panel
            Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
            Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
            Me.panel1.SuspendLayout()
            Me.toolStrip1.SuspendLayout()
            Me.panel2.SuspendLayout()
            CType(Me.paletteGroupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel3.SuspendLayout()
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.panel1.Controls.Add(Me.toolStrip1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1397, 78)
            Me.panel1.TabIndex = 0
            '
            'toolStrip1
            '
            Me.toolStrip1.AutoSize = False
            Me.toolStrip1.BackColor = System.Drawing.Color.Transparent
            Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripButton, Me.openToolStripButton, Me.saveToolStripButton, Me.saveAsToolStripButton, Me.exportToolStripButton, Me.toolStripSeparator1, Me.undoToolStripButton, Me.redoToolStripButton, Me.toolStripSeparator4, Me.cutToolStripButton, Me.copyToolStripButton, Me.pasteToolStripButton, Me.deleteToolStripButton, Me.toolStripSeparator6, Me.connectorToolStripDropDownButton, Me.toolStripSeparator2, Me.zoomInToolStripButton, Me.zoomOutToolStripButton, Me.resetToolStripButton, Me.toolStripSeparator5, Me.gridToolStripButton})
            Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.toolStrip1.Name = "toolStrip1"
            Me.toolStrip1.Size = New System.Drawing.Size(1397, 78)
            Me.toolStrip1.TabIndex = 0
            Me.toolStrip1.Text = "toolStrip1"
            '
            'newToolStripButton
            '
            Me.newToolStripButton.AutoSize = False
            Me.newToolStripButton.BackColor = System.Drawing.Color.Transparent
            Me.newToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.newToolStripButton.Image = CType(resources.GetObject("newToolStripButton.Image"), System.Drawing.Image)
            Me.newToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.newToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.newToolStripButton.Name = "newToolStripButton"
            Me.newToolStripButton.Size = New System.Drawing.Size(60, 60)
            Me.newToolStripButton.Text = "New"
            Me.newToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.newToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'openToolStripButton
            '
            Me.openToolStripButton.AutoSize = False
            Me.openToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.openToolStripButton.Image = CType(resources.GetObject("openToolStripButton.Image"), System.Drawing.Image)
            Me.openToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.openToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.openToolStripButton.Name = "openToolStripButton"
            Me.openToolStripButton.Size = New System.Drawing.Size(60, 60)
            Me.openToolStripButton.Text = "Open"
            Me.openToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.openToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'saveToolStripButton
            '
            Me.saveToolStripButton.AutoSize = False
            Me.saveToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.saveToolStripButton.Image = CType(resources.GetObject("saveToolStripButton.Image"), System.Drawing.Image)
            Me.saveToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.saveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.saveToolStripButton.Name = "saveToolStripButton"
            Me.saveToolStripButton.Size = New System.Drawing.Size(60, 60)
            Me.saveToolStripButton.Text = "Save"
            Me.saveToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.saveToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'saveAsToolStripButton
            '
            Me.saveAsToolStripButton.AutoSize = False
            Me.saveAsToolStripButton.Image = CType(resources.GetObject("saveAsToolStripButton.Image"), System.Drawing.Image)
            Me.saveAsToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.saveAsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.saveAsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.saveAsToolStripButton.Name = "saveAsToolStripButton"
            Me.saveAsToolStripButton.Size = New System.Drawing.Size(60, 60)
            Me.saveAsToolStripButton.Text = "Save As"
            Me.saveAsToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.saveAsToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'exportToolStripButton
            '
            Me.exportToolStripButton.AutoSize = False
            Me.exportToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.exportToolStripButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pNGToolStripMenuItem, Me.jPEGToolStripMenuItem, Me.gIFToolStripMenuItem, Me.sVGToolStripMenuItem})
            Me.exportToolStripButton.Image = CType(resources.GetObject("exportToolStripButton.Image"), System.Drawing.Image)
            Me.exportToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.exportToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.exportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.exportToolStripButton.Name = "exportToolStripButton"
            Me.exportToolStripButton.ShowDropDownArrow = False
            Me.exportToolStripButton.Size = New System.Drawing.Size(60, 60)
            Me.exportToolStripButton.Text = "Export"
            Me.exportToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.exportToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'pNGToolStripMenuItem
            '
            Me.pNGToolStripMenuItem.Name = "pNGToolStripMenuItem"
            Me.pNGToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
            Me.pNGToolStripMenuItem.Text = "PNG"
            '
            'jPEGToolStripMenuItem
            '
            Me.jPEGToolStripMenuItem.Name = "jPEGToolStripMenuItem"
            Me.jPEGToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
            Me.jPEGToolStripMenuItem.Text = "JPEG"
            '
            'gIFToolStripMenuItem
            '
            Me.gIFToolStripMenuItem.Name = "gIFToolStripMenuItem"
            Me.gIFToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
            Me.gIFToolStripMenuItem.Text = "GIF"
            '
            'sVGToolStripMenuItem
            '
            Me.sVGToolStripMenuItem.Name = "sVGToolStripMenuItem"
            Me.sVGToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
            Me.sVGToolStripMenuItem.Text = "SVG"
            '
            'toolStripSeparator1
            '
            Me.toolStripSeparator1.AutoSize = False
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 50)
            '
            'undoToolStripButton
            '
            Me.undoToolStripButton.AutoSize = False
            Me.undoToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.undoToolStripButton.Image = CType(resources.GetObject("undoToolStripButton.Image"), System.Drawing.Image)
            Me.undoToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.undoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.undoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.undoToolStripButton.Name = "undoToolStripButton"
            Me.undoToolStripButton.Size = New System.Drawing.Size(60, 60)
            Me.undoToolStripButton.Text = "Undo"
            Me.undoToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.undoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'redoToolStripButton
            '
            Me.redoToolStripButton.AutoSize = False
            Me.redoToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.redoToolStripButton.Image = CType(resources.GetObject("redoToolStripButton.Image"), System.Drawing.Image)
            Me.redoToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.redoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.redoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.redoToolStripButton.Name = "redoToolStripButton"
            Me.redoToolStripButton.Size = New System.Drawing.Size(60, 60)
            Me.redoToolStripButton.Text = "Redo"
            Me.redoToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.redoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'toolStripSeparator4
            '
            Me.toolStripSeparator4.AutoSize = False
            Me.toolStripSeparator4.Name = "toolStripSeparator4"
            Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 50)
            '
            'cutToolStripButton
            '
            Me.cutToolStripButton.AutoSize = False
            Me.cutToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.cutToolStripButton.Image = CType(resources.GetObject("cutToolStripButton.Image"), System.Drawing.Image)
            Me.cutToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.cutToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.cutToolStripButton.Name = "cutToolStripButton"
            Me.cutToolStripButton.Size = New System.Drawing.Size(60, 60)
            Me.cutToolStripButton.Text = "Cut"
            Me.cutToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.cutToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'copyToolStripButton
            '
            Me.copyToolStripButton.AutoSize = False
            Me.copyToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.copyToolStripButton.Image = CType(resources.GetObject("copyToolStripButton.Image"), System.Drawing.Image)
            Me.copyToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.copyToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.copyToolStripButton.Name = "copyToolStripButton"
            Me.copyToolStripButton.Size = New System.Drawing.Size(60, 60)
            Me.copyToolStripButton.Text = "Copy"
            Me.copyToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.copyToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'pasteToolStripButton
            '
            Me.pasteToolStripButton.AutoSize = False
            Me.pasteToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.pasteToolStripButton.Image = CType(resources.GetObject("pasteToolStripButton.Image"), System.Drawing.Image)
            Me.pasteToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.pasteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.pasteToolStripButton.Name = "pasteToolStripButton"
            Me.pasteToolStripButton.Size = New System.Drawing.Size(60, 60)
            Me.pasteToolStripButton.Text = "Paste"
            Me.pasteToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.pasteToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'deleteToolStripButton
            '
            Me.deleteToolStripButton.AutoSize = False
            Me.deleteToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.deleteToolStripButton.Image = CType(resources.GetObject("deleteToolStripButton.Image"), System.Drawing.Image)
            Me.deleteToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.deleteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.deleteToolStripButton.Name = "deleteToolStripButton"
            Me.deleteToolStripButton.Size = New System.Drawing.Size(60, 60)
            Me.deleteToolStripButton.Text = "Delete"
            Me.deleteToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.deleteToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'toolStripSeparator6
            '
            Me.toolStripSeparator6.AutoSize = False
            Me.toolStripSeparator6.Name = "toolStripSeparator6"
            Me.toolStripSeparator6.Size = New System.Drawing.Size(6, 50)
            '
            'connectorToolStripDropDownButton
            '
            Me.connectorToolStripDropDownButton.AutoSize = False
            Me.connectorToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lineConnectorToolStripMenuItem, Me.directedLineConnectorToolStripMenuItem, Me.orthogonalConnectorToolStripMenuItem, Me.polylineConnectorToolStripMenuItem, Me.bezierConnectorToolStripMenuItem, Me.splineConnectorToolStripMenuItem})
            Me.connectorToolStripDropDownButton.Image = CType(resources.GetObject("connectorToolStripDropDownButton.Image"), System.Drawing.Image)
            Me.connectorToolStripDropDownButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.connectorToolStripDropDownButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.connectorToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.connectorToolStripDropDownButton.Name = "connectorToolStripDropDownButton"
            Me.connectorToolStripDropDownButton.ShowDropDownArrow = False
            Me.connectorToolStripDropDownButton.Size = New System.Drawing.Size(80, 60)
            Me.connectorToolStripDropDownButton.Text = "Connectors"
            Me.connectorToolStripDropDownButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.connectorToolStripDropDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'lineConnectorToolStripMenuItem
            '
            Me.lineConnectorToolStripMenuItem.BackColor = System.Drawing.Color.White
            Me.lineConnectorToolStripMenuItem.Name = "lineConnectorToolStripMenuItem"
            Me.lineConnectorToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
            Me.lineConnectorToolStripMenuItem.Text = "Line Connector"
            '
            'directedLineConnectorToolStripMenuItem
            '
            Me.directedLineConnectorToolStripMenuItem.BackColor = System.Drawing.Color.White
            Me.directedLineConnectorToolStripMenuItem.Name = "directedLineConnectorToolStripMenuItem"
            Me.directedLineConnectorToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
            Me.directedLineConnectorToolStripMenuItem.Text = "DirectedLine Connector"
            '
            'orthogonalConnectorToolStripMenuItem
            '
            Me.orthogonalConnectorToolStripMenuItem.BackColor = System.Drawing.Color.White
            Me.orthogonalConnectorToolStripMenuItem.Name = "orthogonalConnectorToolStripMenuItem"
            Me.orthogonalConnectorToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
            Me.orthogonalConnectorToolStripMenuItem.Text = "Orthogonal Connector"
            '
            'polylineConnectorToolStripMenuItem
            '
            Me.polylineConnectorToolStripMenuItem.BackColor = System.Drawing.Color.White
            Me.polylineConnectorToolStripMenuItem.Name = "polylineConnectorToolStripMenuItem"
            Me.polylineConnectorToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
            Me.polylineConnectorToolStripMenuItem.Text = "Polyline Connector"
            '
            'bezierConnectorToolStripMenuItem
            '
            Me.bezierConnectorToolStripMenuItem.BackColor = System.Drawing.Color.White
            Me.bezierConnectorToolStripMenuItem.Name = "bezierConnectorToolStripMenuItem"
            Me.bezierConnectorToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
            Me.bezierConnectorToolStripMenuItem.Text = "Bezier Connector"
            '
            'splineConnectorToolStripMenuItem
            '
            Me.splineConnectorToolStripMenuItem.BackColor = System.Drawing.Color.White
            Me.splineConnectorToolStripMenuItem.Name = "splineConnectorToolStripMenuItem"
            Me.splineConnectorToolStripMenuItem.Size = New System.Drawing.Size(234, 24)
            Me.splineConnectorToolStripMenuItem.Text = "Spline Connector"
            '
            'toolStripSeparator2
            '
            Me.toolStripSeparator2.AutoSize = False
            Me.toolStripSeparator2.Name = "toolStripSeparator2"
            Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 50)
            '
            'zoomInToolStripButton
            '
            Me.zoomInToolStripButton.AutoSize = False
            Me.zoomInToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.zoomInToolStripButton.Image = CType(resources.GetObject("zoomInToolStripButton.Image"), System.Drawing.Image)
            Me.zoomInToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.zoomInToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.zoomInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.zoomInToolStripButton.Name = "zoomInToolStripButton"
            Me.zoomInToolStripButton.Size = New System.Drawing.Size(60, 60)
            Me.zoomInToolStripButton.Text = "ZoomIn"
            Me.zoomInToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.zoomInToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'zoomOutToolStripButton
            '
            Me.zoomOutToolStripButton.AutoSize = False
            Me.zoomOutToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.zoomOutToolStripButton.Image = CType(resources.GetObject("zoomOutToolStripButton.Image"), System.Drawing.Image)
            Me.zoomOutToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.zoomOutToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.zoomOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.zoomOutToolStripButton.Name = "zoomOutToolStripButton"
            Me.zoomOutToolStripButton.Size = New System.Drawing.Size(70, 60)
            Me.zoomOutToolStripButton.Text = "ZoomOut"
            Me.zoomOutToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.zoomOutToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'resetToolStripButton
            '
            Me.resetToolStripButton.AutoSize = False
            Me.resetToolStripButton.Image = CType(resources.GetObject("resetToolStripButton.Image"), System.Drawing.Image)
            Me.resetToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.resetToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.resetToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.resetToolStripButton.Name = "resetToolStripButton"
            Me.resetToolStripButton.Size = New System.Drawing.Size(60, 60)
            Me.resetToolStripButton.Text = "Reset"
            Me.resetToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.resetToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'toolStripSeparator5
            '
            Me.toolStripSeparator5.AutoSize = False
            Me.toolStripSeparator5.Name = "toolStripSeparator5"
            Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 50)
            '
            'gridToolStripButton
            '
            Me.gridToolStripButton.AutoSize = False
            Me.gridToolStripButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.showGridToolStripMenuItem, Me.snapToGridToolStripMenuItem1})
            Me.gridToolStripButton.Image = CType(resources.GetObject("gridToolStripButton.Image"), System.Drawing.Image)
            Me.gridToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.gridToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.gridToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.gridToolStripButton.Name = "gridToolStripButton"
            Me.gridToolStripButton.ShowDropDownArrow = False
            Me.gridToolStripButton.Size = New System.Drawing.Size(60, 60)
            Me.gridToolStripButton.Text = "Grid"
            Me.gridToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.gridToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'showGridToolStripMenuItem
            '
            Me.showGridToolStripMenuItem.CheckOnClick = True
            Me.showGridToolStripMenuItem.Name = "showGridToolStripMenuItem"
            Me.showGridToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
            Me.showGridToolStripMenuItem.Text = "Grid"
            '
            'snapToGridToolStripMenuItem1
            '
            Me.snapToGridToolStripMenuItem1.Checked = True
            Me.snapToGridToolStripMenuItem1.CheckOnClick = True
            Me.snapToGridToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.snapToGridToolStripMenuItem1.Name = "snapToGridToolStripMenuItem1"
            Me.snapToGridToolStripMenuItem1.Size = New System.Drawing.Size(156, 24)
            Me.snapToGridToolStripMenuItem1.Text = "SnapToGrid"
            '
            'leftImageList
            '
            Me.leftImageList.ImageStream = CType(resources.GetObject("leftImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.leftImageList.TransparentColor = System.Drawing.Color.Transparent
            Me.leftImageList.Images.SetKeyName(0, "Fields.PNG")
            Me.leftImageList.Images.SetKeyName(1, "property.PNG")
            Me.leftImageList.Images.SetKeyName(2, "methods.PNG")
            Me.leftImageList.Images.SetKeyName(3, "events.PNG")
            '
            'openFileDialog1
            '
            Me.openFileDialog1.FileName = "openFileDialog1"
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.paletteGroupBar1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel2.Location = New System.Drawing.Point(0, 78)
            Me.panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(267, 675)
            Me.panel2.TabIndex = 1
            '
            'paletteGroupBar1
            '
            Me.paletteGroupBar1.AllowDrop = True
            Me.paletteGroupBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.paletteGroupBar1.BorderColor = System.Drawing.Color.White
            Me.paletteGroupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.paletteGroupBar1.Diagram = Nothing
            Me.paletteGroupBar1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.paletteGroupBar1.EditMode = False
            Me.paletteGroupBar1.ExpandButtonToolTip = Nothing
            Me.paletteGroupBar1.FlatLook = True
            Me.paletteGroupBar1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.paletteGroupBar1.ForeColor = System.Drawing.Color.White
            Me.paletteGroupBar1.GroupBarDropDownToolTip = Nothing
            Me.paletteGroupBar1.GroupBarItemHeight = 32
            Me.paletteGroupBar1.IndexOnVisibleItems = True
            Me.paletteGroupBar1.Location = New System.Drawing.Point(0, 0)
            Me.paletteGroupBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.paletteGroupBar1.MinimizeButtonToolTip = Nothing
            Me.paletteGroupBar1.Name = "paletteGroupBar1"
            Me.paletteGroupBar1.NavigationPaneTooltip = Nothing
            Me.paletteGroupBar1.PopupClientSize = New System.Drawing.Size(0, 0)
            Me.paletteGroupBar1.Size = New System.Drawing.Size(267, 675)
            Me.paletteGroupBar1.TabIndex = 1
            Me.paletteGroupBar1.Text = "paletteGroupBar1"
            Me.paletteGroupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
            Me.paletteGroupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro
            '
            'panel3
            '
            Me.panel3.Controls.Add(Me.diagram1)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel3.Location = New System.Drawing.Point(267, 78)
            Me.panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(1130, 675)
            Me.panel3.TabIndex = 2
            '
            'diagram1
            '
            Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10.0!, 10.0!)
            Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagram1.HScroll = True
            Me.diagram1.LayoutManager = Nothing
            Me.diagram1.Location = New System.Drawing.Point(0, 0)
            Me.diagram1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.diagram1.MetroScrollBars = True
            Me.diagram1.Model = Me.model1
            Me.diagram1.Name = "diagram1"
            Me.diagram1.ScrollVirtualBounds = CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF)
            Me.diagram1.Size = New System.Drawing.Size(1130, 675)
            Me.diagram1.SmartSizeBox = False
            Me.diagram1.TabIndex = 0
            Me.diagram1.Text = "diagram1"
            '
            '
            '
            Me.diagram1.View.BackgroundColor = System.Drawing.Color.White
            Me.diagram1.View.ClientRectangle = New System.Drawing.Rectangle(0, 0, 0, 0)
            Me.diagram1.View.Controller = Me.diagram1.Controller
            Me.diagram1.View.Grid.MinPixelSpacing = 4.0!
            Me.diagram1.View.Grid.Visible = False
            Me.diagram1.View.ScrollVirtualBounds = CType(resources.GetObject("resource.ScrollVirtualBounds"), System.Drawing.RectangleF)
            Me.diagram1.View.ZoomType = Syncfusion.Windows.Forms.Diagram.ZoomType.Center
            Me.diagram1.VScroll = True
            '
            'model1
            '
            Me.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
            Me.model1.DocumentScale.DisplayName = "No Scale"
            Me.model1.DocumentScale.Height = 1.0!
            Me.model1.DocumentScale.Width = 1.0!
            Me.model1.DocumentSize.Height = 1169.0!
            Me.model1.DocumentSize.Width = 827.0!
            Me.model1.LineStyle.DashPattern = Nothing
            Me.model1.LineStyle.LineColor = System.Drawing.Color.Black
            Me.model1.LineStyle.LineWidth = 0.0!
            Me.model1.LogicalSize = New System.Drawing.SizeF(827.0!, 1169.0!)
            Me.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1397, 753)
            Me.Controls.Add(Me.panel3)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Class Diagram"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.panel1.ResumeLayout(False)
            Me.toolStrip1.ResumeLayout(False)
            Me.toolStrip1.PerformLayout()
            Me.panel2.ResumeLayout(False)
            CType(Me.paletteGroupBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel3.ResumeLayout(False)
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private panel1 As System.Windows.Forms.Panel
		Private leftImageList As System.Windows.Forms.ImageList
		Private toolStrip1 As System.Windows.Forms.ToolStrip
		Private WithEvents saveToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents undoToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents redoToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents cutToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents copyToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents pasteToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents deleteToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents zoomInToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents zoomOutToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents newToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents openToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents saveAsToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents resetToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
		Private gridToolStripButton As System.Windows.Forms.ToolStripDropDownButton
		Private WithEvents showGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents snapToGridToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
		Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
		Private exportToolStripButton As System.Windows.Forms.ToolStripDropDownButton
		Private WithEvents pNGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents jPEGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents gIFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents sVGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private connectorToolStripDropDownButton As System.Windows.Forms.ToolStripDropDownButton
		Private WithEvents lineConnectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents directedLineConnectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents orthogonalConnectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents polylineConnectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents bezierConnectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents splineConnectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
		Private panel2 As System.Windows.Forms.Panel
		Private paletteGroupBar1 As Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar
		Private panel3 As System.Windows.Forms.Panel
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Syncfusion.Windows.Forms.Diagram.Model
	End Class
End Namespace

