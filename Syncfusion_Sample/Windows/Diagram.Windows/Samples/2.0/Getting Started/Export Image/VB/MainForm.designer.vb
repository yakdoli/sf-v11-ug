#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D
Imports System.IO

Imports Syncfusion.Windows.Forms.Diagram
Imports Syncfusion.Windows.Forms.Diagram.Controls

Imports Syncfusion.SVG.IO
Imports Syncfusion.Windows.Forms
Imports System.Reflection

Namespace ExportImage
	Friend partial Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.paletteGroupView1 = New Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupView(Me.components)
            Me.pdfdocument_menu = New System.Windows.Forms.MenuItem
            Me.menuItemFileExit = New System.Windows.Forms.MenuItem
            Me.contextMenu2 = New System.Windows.Forms.ContextMenu
            Me.menuExportImg = New System.Windows.Forms.MenuItem
            Me.menuExportSvg = New System.Windows.Forms.MenuItem
            Me.menuExportEmf = New System.Windows.Forms.MenuItem
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.menuExportPdf = New System.Windows.Forms.MenuItem
            Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
            Me.menuItem3 = New System.Windows.Forms.MenuItem
            Me.menuItem1 = New System.Windows.Forms.MenuItem
            Me.ToolBarButton_PropertyEditor = New System.Windows.Forms.ToolBarButton
            Me.toolBarButton1 = New System.Windows.Forms.ToolBarButton
            Me.ToolBarButton_Palette = New System.Windows.Forms.ToolBarButton
            Me.Model = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
            Me.menuItem2 = New System.Windows.Forms.MenuItem
            Me.toolBarButton2 = New System.Windows.Forms.ToolBarButton
            Me.menuItem4 = New System.Windows.Forms.MenuItem
            Me.menuItem5 = New System.Windows.Forms.MenuItem
            Me.menuItem6 = New System.Windows.Forms.MenuItem
            Me.toolBarButton3 = New System.Windows.Forms.ToolBarButton
            Me.toolBarButton4 = New System.Windows.Forms.ToolBarButton
            Me.toolBarButton5 = New System.Windows.Forms.ToolBarButton
            Me.toolBarButton6 = New System.Windows.Forms.ToolBarButton
            Me.toolBarButton7 = New System.Windows.Forms.ToolBarButton
            Me.toolBarButton8 = New System.Windows.Forms.ToolBarButton
            Me.menuStrip1 = New System.Windows.Forms.MenuStrip
            Me.ExportAsImageToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.ExportAsSvgToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.ExportAsEmfToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
            Me.panel1 = New DemoCommon.Diagram.TitlePanel
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Model, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.menuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'paletteGroupView1
            '
            Me.paletteGroupView1.ButtonView = True
            Me.paletteGroupView1.Diagram = Nothing
            Me.paletteGroupView1.Location = New System.Drawing.Point(2, 24)
            Me.paletteGroupView1.Name = "paletteGroupView1"
            Me.paletteGroupView1.SelectedItem = 0
            Me.paletteGroupView1.Size = New System.Drawing.Size(140, 451)
            Me.paletteGroupView1.TabIndex = 0
            Me.paletteGroupView1.Text = "paletteGroupView1"
            '
            'pdfdocument_menu
            '
            Me.pdfdocument_menu.Index = -1
            Me.pdfdocument_menu.Text = "Export As PDF Document..."
            '
            'menuItemFileExit
            '
            Me.menuItemFileExit.Index = -1
            Me.menuItemFileExit.Text = "&Exit"
            '
            'contextMenu2
            '
            Me.contextMenu2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuExportImg, Me.menuExportSvg, Me.menuExportEmf})
            '
            'menuExportImg
            '
            Me.menuExportImg.Index = 0
            Me.menuExportImg.Text = "Export As Image..."
            '
            'menuExportSvg
            '
            Me.menuExportSvg.Index = 1
            Me.menuExportSvg.Text = "Export As Svg..."
            '
            'menuExportEmf
            '
            Me.menuExportEmf.Index = 2
            Me.menuExportEmf.Text = "Export As Emf..."
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Fuchsia
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
            Me.imageList1.Images.SetKeyName(2, "")
            Me.imageList1.Images.SetKeyName(3, "")
            Me.imageList1.Images.SetKeyName(4, "")
            Me.imageList1.Images.SetKeyName(5, "")
            Me.imageList1.Images.SetKeyName(6, "")
            Me.imageList1.Images.SetKeyName(7, "")
            Me.imageList1.Images.SetKeyName(8, "palette_groupbar.png")
            Me.imageList1.Images.SetKeyName(9, "property_editor.png")
            Me.imageList1.Images.SetKeyName(10, "export.png")
            '
            'menuExportPdf
            '
            Me.menuExportPdf.Index = -1
            Me.menuExportPdf.Text = "Export As Pdf..."
            '
            'diagram1
            '
            Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10.0!, 10.0!)
            Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagram1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2007
            Me.diagram1.LayoutManager = Nothing
            Me.diagram1.Location = New System.Drawing.Point(0, 105)
            Me.diagram1.Model = Nothing
            Me.diagram1.Name = "diagram1"
            Me.diagram1.Office2007ScrollBars = True
            Me.diagram1.ScrollVirtualBounds = CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF)
            Me.diagram1.Size = New System.Drawing.Size(702, 643)
            Me.diagram1.SmartSizeBox = False
            Me.diagram1.TabIndex = 10
            Me.diagram1.Text = "diagram1"
            '
            '
            '
            Me.diagram1.View.ClientRectangle = New System.Drawing.Rectangle(0, 0, 0, 0)
            Me.diagram1.View.Controller = Me.diagram1.Controller
            Me.diagram1.View.Grid.Color = System.Drawing.Color.White
            Me.diagram1.View.Grid.MinPixelSpacing = 4.0!
            Me.diagram1.View.ScrollVirtualBounds = CType(resources.GetObject("resource.ScrollVirtualBounds"), System.Drawing.RectangleF)
            '
            'menuItem3
            '
            Me.menuItem3.Index = -1
            Me.menuItem3.Text = "-"
            '
            'menuItem1
            '
            Me.menuItem1.Index = -1
            Me.menuItem1.Text = "-"
            '
            'ToolBarButton_PropertyEditor
            '
            Me.ToolBarButton_PropertyEditor.Name = "ToolBarButton_PropertyEditor"
            '
            'toolBarButton1
            '
            Me.toolBarButton1.Name = "toolBarButton1"
            '
            'ToolBarButton_Palette
            '
            Me.ToolBarButton_Palette.Name = "ToolBarButton_Palette"
            '
            'Model
            '
            Me.Model.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
            Me.Model.DocumentScale.DisplayName = "No Scale"
            Me.Model.DocumentScale.Height = 1.0!
            Me.Model.DocumentScale.Width = 1.0!
            Me.Model.DocumentSize.Height = 1169.0!
            Me.Model.DocumentSize.Width = 827.0!
            Me.Model.LineStyle.DashPattern = Nothing
            Me.Model.LineStyle.LineColor = System.Drawing.Color.Black
            Me.Model.LogicalSize = New System.Drawing.SizeF(827.0!, 1169.0!)
            Me.Model.ShadowStyle.Color = System.Drawing.Color.DimGray
            Me.Model.ShadowStyle.ColorAlphaFactor = 255
            Me.Model.ShadowStyle.ForeColor = System.Drawing.Color.DimGray
            Me.Model.ShadowStyle.ForeColorAlphaFactor = 255
            '
            'menuItem2
            '
            Me.menuItem2.Index = -1
            Me.menuItem2.Text = "&Exit"
            '
            'toolBarButton2
            '
            Me.toolBarButton2.Name = "toolBarButton2"
            '
            'menuItem4
            '
            Me.menuItem4.Index = -1
            Me.menuItem4.Text = "Export As PDF Document..."
            '
            'menuItem5
            '
            Me.menuItem5.Index = -1
            Me.menuItem5.Text = "&File"
            '
            'menuItem6
            '
            Me.menuItem6.Index = -1
            Me.menuItem6.Text = "Export As Image..."
            '
            'toolBarButton3
            '
            Me.toolBarButton3.Name = "toolBarButton3"
            '
            'toolBarButton4
            '
            Me.toolBarButton4.Name = "toolBarButton4"
            '
            'toolBarButton5
            '
            Me.toolBarButton5.Name = "toolBarButton5"
            '
            'toolBarButton6
            '
            Me.toolBarButton6.Name = "toolBarButton6"
            '
            'toolBarButton7
            '
            Me.toolBarButton7.Name = "toolBarButton7"
            '
            'toolBarButton8
            '
            Me.toolBarButton8.Name = "toolBarButton8"
            '
            'menuStrip1
            '
            Me.menuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.menuStrip1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportAsImageToolStripMenuItem1, Me.ExportAsSvgToolStripMenuItem1, Me.ExportAsEmfToolStripMenuItem1})
            Me.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
            Me.menuStrip1.Location = New System.Drawing.Point(0, 81)
            Me.menuStrip1.Name = "menuStrip1"
            Me.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
            Me.menuStrip1.Size = New System.Drawing.Size(702, 24)
            Me.menuStrip1.TabIndex = 8
            Me.menuStrip1.Text = "menuStrip1"
            '
            'ExportAsImageToolStripMenuItem1
            '
            Me.ExportAsImageToolStripMenuItem1.Name = "ExportAsImageToolStripMenuItem1"
            Me.ExportAsImageToolStripMenuItem1.Size = New System.Drawing.Size(121, 20)
            Me.ExportAsImageToolStripMenuItem1.Text = "Export as Image"
            '
            'ExportAsSvgToolStripMenuItem1
            '
            Me.ExportAsSvgToolStripMenuItem1.Name = "ExportAsSvgToolStripMenuItem1"
            Me.ExportAsSvgToolStripMenuItem1.Size = New System.Drawing.Size(107, 20)
            Me.ExportAsSvgToolStripMenuItem1.Text = "Export as Svg"
            '
            'ExportAsEmfToolStripMenuItem1
            '
            Me.ExportAsEmfToolStripMenuItem1.Name = "ExportAsEmfToolStripMenuItem1"
            Me.ExportAsEmfToolStripMenuItem1.Size = New System.Drawing.Size(107, 20)
            Me.ExportAsEmfToolStripMenuItem1.Text = "Export as Emf"
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.panel1.ControlBox = False
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Form = Me
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(702, 81)
            Me.panel1.TabIndex = 157
            Me.panel1.TitleText = "Export"
            '
            'MainForm
            '
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(702, 748)
            Me.Controls.Add(Me.diagram1)
            Me.Controls.Add(Me.menuStrip1)
            Me.Controls.Add(Me.panel1)
            Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Export Image"
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Model, System.ComponentModel.ISupportInitialize).EndInit()
            Me.menuStrip1.ResumeLayout(False)
            Me.menuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
		#End Region

		Private menuItemFileExit As System.Windows.Forms.MenuItem
		Private pdfdocument_menu As System.Windows.Forms.MenuItem
		Private paletteGroupView1 As Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupView
		Private imageList1 As ImageList
        Private menuItem1 As MenuItem
		Friend ToolBarButton_PropertyEditor As ToolBarButton
		Private toolBarButton1 As ToolBarButton
		Friend ToolBarButton_Palette As ToolBarButton
		Private Model As Model
		Private menuItem2 As MenuItem
		Private toolBarButton2 As ToolBarButton
		Private menuItem4 As MenuItem
		Private menuItem5 As MenuItem
		Private menuItem6 As MenuItem
		Private toolBarButton3 As ToolBarButton
		Private toolBarButton4 As ToolBarButton
		Private toolBarButton5 As ToolBarButton
		Private toolBarButton6 As ToolBarButton
		Private toolBarButton7 As ToolBarButton
		Private toolBarButton8 As ToolBarButton
		Private WithEvents diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private contextMenu2 As ContextMenu
        Private WithEvents menuExportImg As MenuItem
        Private WithEvents menuExportSvg As MenuItem
        Private WithEvents menuExportPdf As MenuItem
        Private WithEvents menuExportEmf As MenuItem
        Private menuStrip1 As MenuStrip
        Private menuItem3 As System.Windows.Forms.MenuItem
        Friend WithEvents ExportAsImageToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ExportAsSvgToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ExportAsEmfToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents panel1 As DemoCommon.Diagram.TitlePanel
	End Class
End Namespace