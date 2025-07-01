Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing.Printing
Imports System.IO
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports Syncfusion.Windows.Forms.Tools
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Runtime.Serialization.Formatters.Binary

Namespace Syncfusion.Windows.Forms.Diagram.Samples.Printing
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
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
            Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
            Me.panel1 = New DemoCommon.Diagram.TitlePanel
            Me.panelClientPanel = New System.Windows.Forms.Panel
            Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
            Me.menuStrip1 = New System.Windows.Forms.MenuStrip
            Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
            Me.headerFooterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.pageBordersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
            Me.pageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.printPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.printToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
            CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelClientPanel.SuspendLayout()
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.menuStrip1.SuspendLayout()
            Me.SuspendLayout()
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
            Me.model1.LogicalSize = New System.Drawing.SizeF(827.0!, 1169.0!)
            Me.model1.ShadowStyle.Color = System.Drawing.Color.DimGray
            Me.model1.ShadowStyle.ColorAlphaFactor = 255
            Me.model1.ShadowStyle.ForeColor = System.Drawing.Color.DimGray
            Me.model1.ShadowStyle.ForeColorAlphaFactor = 255
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.panel1.ControlBox = False
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Form = Me
            Me.panel1.Location = New System.Drawing.Point(2, 2)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(666, 81)
            Me.panel1.TabIndex = 5
            Me.panel1.TitleText = "Print Demo"
            '
            'panelClientPanel
            '
            Me.panelClientPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.panelClientPanel.Controls.Add(Me.diagram1)
            Me.panelClientPanel.Controls.Add(Me.menuStrip1)
            Me.panelClientPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelClientPanel.Location = New System.Drawing.Point(2, 83)
            Me.panelClientPanel.Name = "panelClientPanel"
            Me.panelClientPanel.Size = New System.Drawing.Size(666, 625)
            Me.panelClientPanel.TabIndex = 4
            '
            'diagram1
            '
            Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10.0!, 10.0!)
            Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagram1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2007
            Me.diagram1.LayoutManager = Nothing
            Me.diagram1.Location = New System.Drawing.Point(0, 24)
            Me.diagram1.Model = Nothing
            Me.diagram1.Name = "diagram1"
            Me.diagram1.Office2007ScrollBars = True
            Me.diagram1.ScrollVirtualBounds = CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF)
            Me.diagram1.Size = New System.Drawing.Size(666, 601)
            Me.diagram1.SmartSizeBox = False
            Me.diagram1.TabIndex = 158
            '
            '
            '
            Me.diagram1.View.ClientRectangle = New System.Drawing.Rectangle(0, 0, 0, 0)
            Me.diagram1.View.Controller = Me.diagram1.Controller
            Me.diagram1.View.Grid.MinPixelSpacing = 4.0!
            Me.diagram1.View.ScrollVirtualBounds = CType(resources.GetObject("resource.ScrollVirtualBounds"), System.Drawing.RectangleF)
            '
            'menuStrip1
            '
            Me.menuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.menuStrip1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem})
            Me.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
            Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.menuStrip1.Name = "menuStrip1"
            Me.menuStrip1.Padding = New System.Windows.Forms.Padding(0)
            Me.menuStrip1.Size = New System.Drawing.Size(666, 24)
            Me.menuStrip1.TabIndex = 8
            Me.menuStrip1.Text = "menuStrip1"
            '
            'fileToolStripMenuItem
            '
            Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator1, Me.headerFooterToolStripMenuItem, Me.pageBordersToolStripMenuItem, Me.toolStripSeparator2, Me.pageSetupToolStripMenuItem, Me.printPreviewToolStripMenuItem, Me.printToolStripMenuItem, Me.toolStripSeparator3})
            Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
            Me.fileToolStripMenuItem.Size = New System.Drawing.Size(43, 24)
            Me.fileToolStripMenuItem.Text = "&File"
            '
            'toolStripSeparator1
            '
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(165, 6)
            '
            'headerFooterToolStripMenuItem
            '
            Me.headerFooterToolStripMenuItem.Name = "headerFooterToolStripMenuItem"
            Me.headerFooterToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
            Me.headerFooterToolStripMenuItem.Tag = "Header Footer"
            Me.headerFooterToolStripMenuItem.Text = "Header Footer"
            '
            'pageBordersToolStripMenuItem
            '
            Me.pageBordersToolStripMenuItem.Name = "pageBordersToolStripMenuItem"
            Me.pageBordersToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
            Me.pageBordersToolStripMenuItem.Tag = "Page Borders"
            Me.pageBordersToolStripMenuItem.Text = "Page Borders"
            '
            'toolStripSeparator2
            '
            Me.toolStripSeparator2.Name = "toolStripSeparator2"
            Me.toolStripSeparator2.Size = New System.Drawing.Size(165, 6)
            '
            'pageSetupToolStripMenuItem
            '
            Me.pageSetupToolStripMenuItem.Image = CType(resources.GetObject("pageSetupToolStripMenuItem.Image"), System.Drawing.Image)
            Me.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem"
            Me.pageSetupToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
            Me.pageSetupToolStripMenuItem.Tag = "Page Setup"
            Me.pageSetupToolStripMenuItem.Text = "Page Setup"
            '
            'printPreviewToolStripMenuItem
            '
            Me.printPreviewToolStripMenuItem.Image = CType(resources.GetObject("printPreviewToolStripMenuItem.Image"), System.Drawing.Image)
            Me.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem"
            Me.printPreviewToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
            Me.printPreviewToolStripMenuItem.Tag = "Print Preview"
            Me.printPreviewToolStripMenuItem.Text = "Print Preview"
            '
            'printToolStripMenuItem
            '
            Me.printToolStripMenuItem.Image = CType(resources.GetObject("printToolStripMenuItem.Image"), System.Drawing.Image)
            Me.printToolStripMenuItem.Name = "printToolStripMenuItem"
            Me.printToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
            Me.printToolStripMenuItem.Tag = "Print"
            Me.printToolStripMenuItem.Text = "Print"
            '
            'toolStripSeparator3
            '
            Me.toolStripSeparator3.Name = "toolStripSeparator3"
            Me.toolStripSeparator3.Size = New System.Drawing.Size(165, 6)
            '
            'MainForm
            '
            Me.ClientSize = New System.Drawing.Size(670, 710)
            Me.Controls.Add(Me.panelClientPanel)
            Me.Controls.Add(Me.panel1)
            Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Print Demo"
            CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelClientPanel.ResumeLayout(False)
            Me.panelClientPanel.PerformLayout()
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.menuStrip1.ResumeLayout(False)
            Me.menuStrip1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
		#End Region

        Private model1 As Model
        Private fileName As String = Nothing
        Private WithEvents panel1 As DemoCommon.Diagram.TitlePanel
        Private WithEvents panelClientPanel As System.Windows.Forms.Panel
        Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
        Private WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents headerFooterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents pageBordersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents pageSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents printPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents printToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram

	End Class
End Namespace