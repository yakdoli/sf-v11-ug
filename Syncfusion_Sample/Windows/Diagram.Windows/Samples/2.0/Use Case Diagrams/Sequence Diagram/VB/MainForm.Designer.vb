Imports Microsoft.VisualBasic
Imports System
Namespace Sequence_Diagram_2005
	Partial Public Class MainForm
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
			Me.toolBar = New System.Windows.Forms.ToolStrip()
			Me.btnNew = New System.Windows.Forms.ToolStripButton()
			Me.btnOpen = New System.Windows.Forms.ToolStripButton()
			Me.btnSave = New System.Windows.Forms.ToolStripButton()
			Me.btnSaveAs = New System.Windows.Forms.ToolStripButton()
			Me.dropDownBtnExport = New System.Windows.Forms.ToolStripDropDownButton()
			Me.exportPng = New System.Windows.Forms.ToolStripMenuItem()
			Me.exportJpg = New System.Windows.Forms.ToolStripMenuItem()
			Me.exportPdf = New System.Windows.Forms.ToolStripMenuItem()
			Me.seperator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.btnUndo = New System.Windows.Forms.ToolStripButton()
			Me.btnRedo = New System.Windows.Forms.ToolStripButton()
			Me.btnCut = New System.Windows.Forms.ToolStripButton()
			Me.btnCopy = New System.Windows.Forms.ToolStripButton()
			Me.btnPaste = New System.Windows.Forms.ToolStripButton()
			Me.separator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.btnRuler = New System.Windows.Forms.ToolStripButton()
			Me.btnGrid = New System.Windows.Forms.ToolStripButton()
			Me.btnSnapToGrid = New System.Windows.Forms.ToolStripButton()
			Me.separator3 = New System.Windows.Forms.ToolStripSeparator()
			Me.btnSize = New System.Windows.Forms.ToolStripButton()
			Me.btnAutoSize = New System.Windows.Forms.ToolStripButton()
			Me.btnPageSettings = New System.Windows.Forms.ToolStripButton()
			Me.separator4 = New System.Windows.Forms.ToolStripSeparator()
			Me.btnPreview = New System.Windows.Forms.ToolStripButton()
			Me.btnPrint = New System.Windows.Forms.ToolStripButton()
			Me.paletteGroupBar1 = New Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(Me.components)
			Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
			Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
			Me.printDialog = New System.Windows.Forms.PrintDialog()
			Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
			Me.saveAsFileDialog = New System.Windows.Forms.SaveFileDialog()
			Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
			Me.exportFileDialog = New System.Windows.Forms.SaveFileDialog()
			Me.toolBar.SuspendLayout()
			CType(Me.paletteGroupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' toolBar
			' 
			Me.toolBar.AutoSize = False
			Me.toolBar.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(237))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(240))))))
			Me.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.btnNew, Me.btnOpen, Me.btnSave, Me.btnSaveAs, Me.dropDownBtnExport, Me.seperator1, Me.btnUndo, Me.btnRedo, Me.btnCut, Me.btnCopy, Me.btnPaste, Me.separator2, Me.btnRuler, Me.btnGrid, Me.btnSnapToGrid, Me.separator3, Me.btnSize, Me.btnAutoSize, Me.btnPageSettings, Me.separator4, Me.btnPreview, Me.btnPrint})
			Me.toolBar.Location = New System.Drawing.Point(0, 0)
			Me.toolBar.Name = "toolBar"
			Me.toolBar.Size = New System.Drawing.Size(1034, 77)
			Me.toolBar.TabIndex = 0
			Me.toolBar.Text = "toolStrip1"
			' 
			' btnNew
			' 
			Me.btnNew.Image = (CType(resources.GetObject("btnNew.Image"), System.Drawing.Image))
			Me.btnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnNew.Name = "btnNew"
			Me.btnNew.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.btnNew.Size = New System.Drawing.Size(46, 74)
			Me.btnNew.Text = "New"
			Me.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.btnNew.Click += New System.EventHandler(Me.btnNew_Click)
			' 
			' btnOpen
			' 
			Me.btnOpen.Image = (CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image))
			Me.btnOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnOpen.Name = "btnOpen"
			Me.btnOpen.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.btnOpen.Size = New System.Drawing.Size(50, 74)
			Me.btnOpen.Text = "Open"
			Me.btnOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.btnOpen.Click += New System.EventHandler(Me.btnOpen_Click)
			' 
			' btnSave
			' 
			Me.btnSave.Image = (CType(resources.GetObject("btnSave.Image"), System.Drawing.Image))
			Me.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.btnSave.Size = New System.Drawing.Size(46, 74)
			Me.btnSave.Text = "Save"
			Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.btnSave.Click += New System.EventHandler(Me.btnSave_Click)
			' 
			' btnSaveAs
			' 
			Me.btnSaveAs.Image = (CType(resources.GetObject("btnSaveAs.Image"), System.Drawing.Image))
			Me.btnSaveAs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnSaveAs.Name = "btnSaveAs"
			Me.btnSaveAs.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.btnSaveAs.Size = New System.Drawing.Size(61, 74)
			Me.btnSaveAs.Text = "Save As"
			Me.btnSaveAs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.btnSaveAs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.btnSaveAs.Click += New System.EventHandler(Me.btnSaveAs_Click)
			' 
			' dropDownBtnExport
			' 
			Me.dropDownBtnExport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.exportPng, Me.exportJpg, Me.exportPdf})
			Me.dropDownBtnExport.Image = (CType(resources.GetObject("dropDownBtnExport.Image"), System.Drawing.Image))
			Me.dropDownBtnExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.dropDownBtnExport.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.dropDownBtnExport.Name = "dropDownBtnExport"
			Me.dropDownBtnExport.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.dropDownBtnExport.ShowDropDownArrow = False
			Me.dropDownBtnExport.Size = New System.Drawing.Size(54, 74)
			Me.dropDownBtnExport.Text = "Export"
			Me.dropDownBtnExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.dropDownBtnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' exportPng
			' 
			Me.exportPng.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(237))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(240))))))
			Me.exportPng.Name = "exportPng"
			Me.exportPng.Size = New System.Drawing.Size(99, 22)
			Me.exportPng.Text = "PNG"
'			Me.exportPng.Click += New System.EventHandler(Me.exportPng_Click)
			' 
			' exportJpg
			' 
			Me.exportJpg.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(237))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(240))))))
			Me.exportJpg.Name = "exportJpg"
			Me.exportJpg.Size = New System.Drawing.Size(99, 22)
			Me.exportJpg.Text = "JPEG"
'			Me.exportJpg.Click += New System.EventHandler(Me.exportJpg_Click)
			' 
			' exportPdf
			' 
			Me.exportPdf.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(237))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(240))))))
			Me.exportPdf.Name = "exportPdf"
			Me.exportPdf.Size = New System.Drawing.Size(99, 22)
			Me.exportPdf.Text = "GIF"
'			Me.exportPdf.Click += New System.EventHandler(Me.exportPdf_Click)
			' 
			' seperator1
			' 
			Me.seperator1.AutoSize = False
			Me.seperator1.Name = "seperator1"
			Me.seperator1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.seperator1.Size = New System.Drawing.Size(6, 60)
			' 
			' btnUndo
			' 
			Me.btnUndo.Image = (CType(resources.GetObject("btnUndo.Image"), System.Drawing.Image))
			Me.btnUndo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnUndo.Name = "btnUndo"
			Me.btnUndo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.btnUndo.Size = New System.Drawing.Size(50, 74)
			Me.btnUndo.Text = "Undo"
			Me.btnUndo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.btnUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.btnUndo.Click += New System.EventHandler(Me.btnUndo_Click)
			' 
			' btnRedo
			' 
			Me.btnRedo.Image = (CType(resources.GetObject("btnRedo.Image"), System.Drawing.Image))
			Me.btnRedo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnRedo.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnRedo.Name = "btnRedo"
			Me.btnRedo.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.btnRedo.Size = New System.Drawing.Size(48, 74)
			Me.btnRedo.Text = "Redo"
			Me.btnRedo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.btnRedo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.btnRedo.Click += New System.EventHandler(Me.btnRedo_Click)
			' 
			' btnCut
			' 
			Me.btnCut.Image = (CType(resources.GetObject("btnCut.Image"), System.Drawing.Image))
			Me.btnCut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnCut.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnCut.Name = "btnCut"
			Me.btnCut.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.btnCut.Size = New System.Drawing.Size(46, 74)
			Me.btnCut.Text = "Cut"
			Me.btnCut.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.btnCut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.btnCut.Click += New System.EventHandler(Me.btnCut_Click)
			' 
			' btnCopy
			' 
			Me.btnCopy.Image = (CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image))
			Me.btnCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnCopy.Name = "btnCopy"
			Me.btnCopy.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.btnCopy.Size = New System.Drawing.Size(49, 74)
			Me.btnCopy.Text = "Copy"
			Me.btnCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.btnCopy.Click += New System.EventHandler(Me.btnCopy_Click)
			' 
			' btnPaste
			' 
			Me.btnPaste.Image = (CType(resources.GetObject("btnPaste.Image"), System.Drawing.Image))
			Me.btnPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnPaste.Name = "btnPaste"
			Me.btnPaste.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.btnPaste.Size = New System.Drawing.Size(49, 74)
			Me.btnPaste.Text = "Paste"
			Me.btnPaste.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.btnPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.btnPaste.Click += New System.EventHandler(Me.btnPaste_Click)
			' 
			' separator2
			' 
			Me.separator2.AutoSize = False
			Me.separator2.Name = "separator2"
			Me.separator2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.separator2.Size = New System.Drawing.Size(6, 60)
			' 
			' btnRuler
			' 
			Me.btnRuler.CheckOnClick = True
			Me.btnRuler.Image = (CType(resources.GetObject("btnRuler.Image"), System.Drawing.Image))
			Me.btnRuler.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnRuler.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnRuler.Name = "btnRuler"
			Me.btnRuler.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.btnRuler.Size = New System.Drawing.Size(48, 74)
			Me.btnRuler.Text = "Ruler"
			Me.btnRuler.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.btnRuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.btnRuler.Click += New System.EventHandler(Me.btnRuler_Click)
			' 
			' btnGrid
			' 
			Me.btnGrid.CheckOnClick = True
			Me.btnGrid.Image = (CType(resources.GetObject("btnGrid.Image"), System.Drawing.Image))
			Me.btnGrid.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnGrid.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnGrid.Name = "btnGrid"
			Me.btnGrid.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.btnGrid.Size = New System.Drawing.Size(46, 74)
			Me.btnGrid.Text = "Grid"
			Me.btnGrid.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.btnGrid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.btnGrid.Click += New System.EventHandler(Me.btnGrid_Click)
			' 
			' btnSnapToGrid
			' 
			Me.btnSnapToGrid.CheckOnClick = True
			Me.btnSnapToGrid.Image = (CType(resources.GetObject("btnSnapToGrid.Image"), System.Drawing.Image))
			Me.btnSnapToGrid.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnSnapToGrid.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnSnapToGrid.Name = "btnSnapToGrid"
			Me.btnSnapToGrid.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.btnSnapToGrid.Size = New System.Drawing.Size(89, 74)
			Me.btnSnapToGrid.Text = "Snap To Grid"
			Me.btnSnapToGrid.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.btnSnapToGrid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.btnSnapToGrid.Click += New System.EventHandler(Me.btnSnapToGrid_Click)
			' 
			' separator3
			' 
			Me.separator3.AutoSize = False
			Me.separator3.Name = "separator3"
			Me.separator3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.separator3.Size = New System.Drawing.Size(6, 60)
			' 
			' btnSize
			' 
			Me.btnSize.Image = (CType(resources.GetObject("btnSize.Image"), System.Drawing.Image))
			Me.btnSize.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnSize.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnSize.Name = "btnSize"
			Me.btnSize.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.btnSize.Size = New System.Drawing.Size(46, 74)
			Me.btnSize.Text = "Size"
			Me.btnSize.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.btnSize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.btnSize.Click += New System.EventHandler(Me.btnSize_Click)
			' 
			' btnAutoSize
			' 
			Me.btnAutoSize.Image = (CType(resources.GetObject("btnAutoSize.Image"), System.Drawing.Image))
			Me.btnAutoSize.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnAutoSize.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnAutoSize.Name = "btnAutoSize"
			Me.btnAutoSize.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.btnAutoSize.Size = New System.Drawing.Size(70, 74)
			Me.btnAutoSize.Text = "Auto Size"
			Me.btnAutoSize.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.btnAutoSize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.btnAutoSize.Click += New System.EventHandler(Me.btnAutoSize_Click)
			' 
			' btnPageSettings
			' 
			Me.btnPageSettings.Image = (CType(resources.GetObject("btnPageSettings.Image"), System.Drawing.Image))
			Me.btnPageSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnPageSettings.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnPageSettings.Name = "btnPageSettings"
			Me.btnPageSettings.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.btnPageSettings.Size = New System.Drawing.Size(80, 74)
			Me.btnPageSettings.Text = "Page Setup"
			Me.btnPageSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.btnPageSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.btnPageSettings.Click += New System.EventHandler(Me.btnPageSettings_Click)
			' 
			' separator4
			' 
			Me.separator4.AutoSize = False
			Me.separator4.Name = "separator4"
			Me.separator4.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.separator4.Size = New System.Drawing.Size(6, 60)
			' 
			' btnPreview
			' 
			Me.btnPreview.Image = (CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image))
			Me.btnPreview.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnPreview.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnPreview.Name = "btnPreview"
			Me.btnPreview.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.btnPreview.Size = New System.Drawing.Size(62, 74)
			Me.btnPreview.Text = "Preview"
			Me.btnPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.btnPreview.Click += New System.EventHandler(Me.btnPreview_Click)
			' 
			' btnPrint
			' 
			Me.btnPrint.Image = (CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image))
			Me.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btnPrint.Name = "btnPrint"
			Me.btnPrint.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.btnPrint.Size = New System.Drawing.Size(46, 74)
			Me.btnPrint.Text = "Print"
			Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.btnPrint.Click += New System.EventHandler(Me.btnPrint_Click)
			' 
			' paletteGroupBar1
			' 
			Me.paletteGroupBar1.AllowDrop = True
			Me.paletteGroupBar1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235))))))
			Me.paletteGroupBar1.BorderColor = System.Drawing.Color.White
			Me.paletteGroupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.paletteGroupBar1.Diagram = Nothing
			Me.paletteGroupBar1.Dock = System.Windows.Forms.DockStyle.Left
			Me.paletteGroupBar1.EditMode = False
			Me.paletteGroupBar1.ExpandButtonToolTip = Nothing
			Me.paletteGroupBar1.FlatLook = True
			Me.paletteGroupBar1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.paletteGroupBar1.ForeColor = System.Drawing.Color.White
			Me.paletteGroupBar1.GroupBarDropDownToolTip = Nothing
			Me.paletteGroupBar1.GroupBarItemHeight = 32
			Me.paletteGroupBar1.IndexOnVisibleItems = True
			Me.paletteGroupBar1.Location = New System.Drawing.Point(0, 77)
			Me.paletteGroupBar1.MinimizeButtonToolTip = Nothing
			Me.paletteGroupBar1.Name = "paletteGroupBar1"
			Me.paletteGroupBar1.NavigationPaneTooltip = Nothing
			Me.paletteGroupBar1.PopupClientSize = New System.Drawing.Size(0, 0)
			Me.paletteGroupBar1.Size = New System.Drawing.Size(214, 595)
			Me.paletteGroupBar1.TabIndex = 1
			Me.paletteGroupBar1.Text = "paletteGroupBar1"
			Me.paletteGroupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
			Me.paletteGroupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro
			' 
			' diagram1
			' 
			Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10F, 10F)
			Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.diagram1.LayoutManager = Nothing
			Me.diagram1.Location = New System.Drawing.Point(214, 77)
			Me.diagram1.Model = Me.model1
			Me.diagram1.Name = "diagram1"
			Me.diagram1.ScrollVirtualBounds = (CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF))
			Me.diagram1.Size = New System.Drawing.Size(820, 595)
			Me.diagram1.SmartSizeBox = False
			Me.diagram1.TabIndex = 2
			Me.diagram1.Text = "diagram1"
			' 
			' 
			' 
			Me.diagram1.View.ClientRectangle = New System.Drawing.Rectangle(0, 0, 0, 0)
			Me.diagram1.View.Controller = Me.diagram1.Controller
			Me.diagram1.View.Grid.MinPixelSpacing = 4F
			Me.diagram1.View.ScrollVirtualBounds = (CType(resources.GetObject("resource.ScrollVirtualBounds"), System.Drawing.RectangleF))
			' 
			' model1
			' 
			Me.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
			Me.model1.DocumentScale.DisplayName = "No Scale"
			Me.model1.DocumentScale.Height = 1F
			Me.model1.DocumentScale.Width = 1F
			Me.model1.DocumentSize.Height = 1169F
			Me.model1.DocumentSize.Width = 827F
			Me.model1.LineStyle.DashPattern = Nothing
			Me.model1.LineStyle.LineColor = System.Drawing.Color.Black
			Me.model1.LogicalSize = New System.Drawing.SizeF(827F, 1169F)
			Me.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))))
			Me.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))))
			' 
			' printDialog
			' 
			Me.printDialog.UseEXDialog = True
			' 
			' openFileDialog
			' 
			Me.openFileDialog.FileName = "openFileDialog1"
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1034, 672)
			Me.Controls.Add(Me.diagram1)
			Me.Controls.Add(Me.paletteGroupBar1)
			Me.Controls.Add(Me.toolBar)
			Me.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "MainForm"
			Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Sequence Diagram"
			Me.toolBar.ResumeLayout(False)
			Me.toolBar.PerformLayout()
			CType(Me.paletteGroupBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private toolBar As System.Windows.Forms.ToolStrip
		Private WithEvents btnNew As System.Windows.Forms.ToolStripButton
		Private WithEvents btnOpen As System.Windows.Forms.ToolStripButton
		Private WithEvents btnSave As System.Windows.Forms.ToolStripButton
		Private WithEvents btnSaveAs As System.Windows.Forms.ToolStripButton
		Private paletteGroupBar1 As Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Syncfusion.Windows.Forms.Diagram.Model
		Private dropDownBtnExport As System.Windows.Forms.ToolStripDropDownButton
		Private WithEvents exportPng As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents exportJpg As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents exportPdf As System.Windows.Forms.ToolStripMenuItem
		Private seperator1 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents btnUndo As System.Windows.Forms.ToolStripButton
		Private WithEvents btnRedo As System.Windows.Forms.ToolStripButton
		Private WithEvents btnCut As System.Windows.Forms.ToolStripButton
		Private WithEvents btnCopy As System.Windows.Forms.ToolStripButton
		Private WithEvents btnPaste As System.Windows.Forms.ToolStripButton
		Private separator2 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents btnRuler As System.Windows.Forms.ToolStripButton
		Private WithEvents btnGrid As System.Windows.Forms.ToolStripButton
		Private WithEvents btnSnapToGrid As System.Windows.Forms.ToolStripButton
		Private separator3 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents btnSize As System.Windows.Forms.ToolStripButton
		Private WithEvents btnAutoSize As System.Windows.Forms.ToolStripButton
		Private WithEvents btnPageSettings As System.Windows.Forms.ToolStripButton
		Private separator4 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents btnPreview As System.Windows.Forms.ToolStripButton
		Private WithEvents btnPrint As System.Windows.Forms.ToolStripButton
		Private printDialog As System.Windows.Forms.PrintDialog
		Private saveFileDialog As System.Windows.Forms.SaveFileDialog
		Private saveAsFileDialog As System.Windows.Forms.SaveFileDialog
		Private openFileDialog As System.Windows.Forms.OpenFileDialog
		Private exportFileDialog As System.Windows.Forms.SaveFileDialog
	End Class
End Namespace

