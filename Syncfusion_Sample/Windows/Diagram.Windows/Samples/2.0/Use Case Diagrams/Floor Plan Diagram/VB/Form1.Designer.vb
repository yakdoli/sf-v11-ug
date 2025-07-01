Imports Microsoft.VisualBasic
Imports System
Namespace FloorPlan_Diagram
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
            Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
            Me.panToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.zoomInToolStripButton = New System.Windows.Forms.ToolStripDropDownButton
            Me.zoomInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.zoomOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.resetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
            Me.gridToolStripButton = New System.Windows.Forms.ToolStripDropDownButton
            Me.showGridToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.snapToGridToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton11 = New System.Windows.Forms.ToolStripSeparator
            Me.pageSettingsToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.previewToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.printToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
            Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
            Me.colorDialog1 = New System.Windows.Forms.ColorDialog
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
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(977, 60)
            Me.panel1.TabIndex = 0
            '
            'toolStrip1
            '
            Me.toolStrip1.BackColor = System.Drawing.Color.Transparent
            Me.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripButton, Me.openToolStripButton, Me.saveToolStripButton, Me.saveAsToolStripButton, Me.exportToolStripButton, Me.toolStripSeparator1, Me.undoToolStripButton, Me.redoToolStripButton, Me.toolStripSeparator4, Me.cutToolStripButton, Me.copyToolStripButton, Me.pasteToolStripButton, Me.deleteToolStripButton, Me.toolStripSeparator2, Me.panToolStripButton, Me.zoomInToolStripButton, Me.toolStripSeparator5, Me.gridToolStripButton, Me.toolStripButton3, Me.toolStripButton11, Me.pageSettingsToolStripButton, Me.previewToolStripButton, Me.printToolStripButton})
            Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.toolStrip1.Name = "toolStrip1"
            Me.toolStrip1.Size = New System.Drawing.Size(977, 63)
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
            Me.newToolStripButton.Size = New System.Drawing.Size(65, 60)
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
            Me.openToolStripButton.Size = New System.Drawing.Size(70, 60)
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
            Me.saveToolStripButton.Size = New System.Drawing.Size(70, 60)
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
            Me.saveAsToolStripButton.Size = New System.Drawing.Size(70, 60)
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
            Me.exportToolStripButton.Size = New System.Drawing.Size(70, 60)
            Me.exportToolStripButton.Text = "Export"
            Me.exportToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.exportToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'pNGToolStripMenuItem
            '
            Me.pNGToolStripMenuItem.Name = "pNGToolStripMenuItem"
            Me.pNGToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
            Me.pNGToolStripMenuItem.Text = "PNG"
            '
            'jPEGToolStripMenuItem
            '
            Me.jPEGToolStripMenuItem.Name = "jPEGToolStripMenuItem"
            Me.jPEGToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
            Me.jPEGToolStripMenuItem.Text = "JPEG"
            '
            'gIFToolStripMenuItem
            '
            Me.gIFToolStripMenuItem.Name = "gIFToolStripMenuItem"
            Me.gIFToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
            Me.gIFToolStripMenuItem.Text = "GIF"
            '
            'sVGToolStripMenuItem
            '
            Me.sVGToolStripMenuItem.Name = "sVGToolStripMenuItem"
            Me.sVGToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
            Me.sVGToolStripMenuItem.Text = "SVG"
            '
            'toolStripSeparator1
            '
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 63)
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
            Me.undoToolStripButton.Size = New System.Drawing.Size(70, 60)
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
            Me.redoToolStripButton.Size = New System.Drawing.Size(70, 60)
            Me.redoToolStripButton.Text = "Redo"
            Me.redoToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.redoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'toolStripSeparator4
            '
            Me.toolStripSeparator4.Name = "toolStripSeparator4"
            Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 63)
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
            Me.cutToolStripButton.Size = New System.Drawing.Size(70, 60)
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
            Me.copyToolStripButton.Size = New System.Drawing.Size(70, 60)
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
            Me.pasteToolStripButton.Size = New System.Drawing.Size(70, 60)
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
            Me.deleteToolStripButton.Size = New System.Drawing.Size(70, 60)
            Me.deleteToolStripButton.Text = "Delete"
            Me.deleteToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.deleteToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'toolStripSeparator2
            '
            Me.toolStripSeparator2.Name = "toolStripSeparator2"
            Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 63)
            '
            'panToolStripButton
            '
            Me.panToolStripButton.AutoSize = False
            Me.panToolStripButton.Image = CType(resources.GetObject("panToolStripButton.Image"), System.Drawing.Image)
            Me.panToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.panToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.panToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.panToolStripButton.Name = "panToolStripButton"
            Me.panToolStripButton.Size = New System.Drawing.Size(65, 60)
            Me.panToolStripButton.Text = "Pan Tool"
            Me.panToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.panToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'zoomInToolStripButton
            '
            Me.zoomInToolStripButton.AutoSize = False
            Me.zoomInToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.zoomInToolStripButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.zoomInToolStripMenuItem, Me.zoomOutToolStripMenuItem, Me.resetToolStripMenuItem})
            Me.zoomInToolStripButton.Image = CType(resources.GetObject("zoomInToolStripButton.Image"), System.Drawing.Image)
            Me.zoomInToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.zoomInToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.zoomInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.zoomInToolStripButton.Name = "zoomInToolStripButton"
            Me.zoomInToolStripButton.ShowDropDownArrow = False
            Me.zoomInToolStripButton.Size = New System.Drawing.Size(70, 60)
            Me.zoomInToolStripButton.Text = "Zoom"
            Me.zoomInToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.zoomInToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'zoomInToolStripMenuItem
            '
            Me.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem"
            Me.zoomInToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
            Me.zoomInToolStripMenuItem.Text = "ZoomIn"
            '
            'zoomOutToolStripMenuItem
            '
            Me.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem"
            Me.zoomOutToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
            Me.zoomOutToolStripMenuItem.Text = "ZoomOut"
            '
            'resetToolStripMenuItem
            '
            Me.resetToolStripMenuItem.Name = "resetToolStripMenuItem"
            Me.resetToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
            Me.resetToolStripMenuItem.Text = "Reset"
            '
            'toolStripSeparator5
            '
            Me.toolStripSeparator5.Name = "toolStripSeparator5"
            Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 63)
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
            Me.showGridToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
            Me.showGridToolStripMenuItem.Text = "Grid"
            '
            'snapToGridToolStripMenuItem1
            '
            Me.snapToGridToolStripMenuItem1.Checked = True
            Me.snapToGridToolStripMenuItem1.CheckOnClick = True
            Me.snapToGridToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.snapToGridToolStripMenuItem1.Name = "snapToGridToolStripMenuItem1"
            Me.snapToGridToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
            Me.snapToGridToolStripMenuItem1.Text = "SnapToGrid"
            '
            'toolStripButton3
            '
            Me.toolStripButton3.AutoSize = False
            Me.toolStripButton3.Image = CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image)
            Me.toolStripButton3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton3.Name = "toolStripButton3"
            Me.toolStripButton3.Size = New System.Drawing.Size(70, 60)
            Me.toolStripButton3.Text = "Ruler"
            Me.toolStripButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'toolStripButton11
            '
            Me.toolStripButton11.Name = "toolStripButton11"
            Me.toolStripButton11.Size = New System.Drawing.Size(6, 63)
            '
            'pageSettingsToolStripButton
            '
            Me.pageSettingsToolStripButton.AutoSize = False
            Me.pageSettingsToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.pageSettingsToolStripButton.Image = CType(resources.GetObject("pageSettingsToolStripButton.Image"), System.Drawing.Image)
            Me.pageSettingsToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.pageSettingsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.pageSettingsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.pageSettingsToolStripButton.Name = "pageSettingsToolStripButton"
            Me.pageSettingsToolStripButton.Size = New System.Drawing.Size(65, 50)
            Me.pageSettingsToolStripButton.Text = "Settings"
            Me.pageSettingsToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.pageSettingsToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'previewToolStripButton
            '
            Me.previewToolStripButton.AutoSize = False
            Me.previewToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.previewToolStripButton.Image = CType(resources.GetObject("previewToolStripButton.Image"), System.Drawing.Image)
            Me.previewToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.previewToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.previewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.previewToolStripButton.Name = "previewToolStripButton"
            Me.previewToolStripButton.Size = New System.Drawing.Size(65, 50)
            Me.previewToolStripButton.Text = "Preview"
            Me.previewToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.previewToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'printToolStripButton
            '
            Me.printToolStripButton.AutoSize = False
            Me.printToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.printToolStripButton.Image = CType(resources.GetObject("printToolStripButton.Image"), System.Drawing.Image)
            Me.printToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.printToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.printToolStripButton.Name = "printToolStripButton"
            Me.printToolStripButton.Size = New System.Drawing.Size(65, 50)
            Me.printToolStripButton.Text = "Print"
            Me.printToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.printToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'openFileDialog1
            '
            Me.openFileDialog1.FileName = "openFileDialog1"
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.paletteGroupBar1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel2.Location = New System.Drawing.Point(0, 60)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(220, 549)
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
            Me.paletteGroupBar1.MinimizeButtonToolTip = Nothing
            Me.paletteGroupBar1.Name = "paletteGroupBar1"
            Me.paletteGroupBar1.NavigationPaneTooltip = Nothing
            Me.paletteGroupBar1.PopupClientSize = New System.Drawing.Size(0, 0)
            Me.paletteGroupBar1.Size = New System.Drawing.Size(220, 549)
            Me.paletteGroupBar1.TabIndex = 1
            Me.paletteGroupBar1.Text = "paletteGroupBar1"
            Me.paletteGroupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
            Me.paletteGroupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro
            '
            'panel3
            '
            Me.panel3.Controls.Add(Me.diagram1)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel3.Location = New System.Drawing.Point(220, 60)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(757, 549)
            Me.panel3.TabIndex = 0
            '
            'diagram1
            '
            Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10.0!, 10.0!)
            Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagram1.LayoutManager = Nothing
            Me.diagram1.Location = New System.Drawing.Point(0, 0)
            Me.diagram1.MetroScrollBars = True
            Me.diagram1.Model = Me.model1
            Me.diagram1.Name = "diagram1"
            Me.diagram1.ScrollVirtualBounds = CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF)
            Me.diagram1.Size = New System.Drawing.Size(757, 549)
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
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(977, 609)
            Me.Controls.Add(Me.panel3)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FloorPlan Diagram"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
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
		Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
		Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
		Private colorDialog1 As System.Windows.Forms.ColorDialog
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
		Private WithEvents openToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents saveAsToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
		Private gridToolStripButton As System.Windows.Forms.ToolStripDropDownButton
		Private WithEvents showGridToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents snapToGridToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private exportToolStripButton As System.Windows.Forms.ToolStripDropDownButton
		Private WithEvents pNGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents jPEGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents gIFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents sVGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private zoomInToolStripButton As System.Windows.Forms.ToolStripDropDownButton
		Private WithEvents zoomInToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents zoomOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents resetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents toolStripButton3 As System.Windows.Forms.ToolStripButton
		Private panel2 As System.Windows.Forms.Panel
		Private paletteGroupBar1 As Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar
		Private panel3 As System.Windows.Forms.Panel
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
        Private model1 As Syncfusion.Windows.Forms.Diagram.Model
        Private WithEvents newToolStripButton As System.Windows.Forms.ToolStripButton
        Private WithEvents panToolStripButton As System.Windows.Forms.ToolStripButton
        Private WithEvents toolStripButton11 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents pageSettingsToolStripButton As System.Windows.Forms.ToolStripButton
        Private WithEvents previewToolStripButton As System.Windows.Forms.ToolStripButton
        Private WithEvents printToolStripButton As System.Windows.Forms.ToolStripButton
	End Class
End Namespace

