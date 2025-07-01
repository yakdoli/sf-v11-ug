Imports Microsoft.VisualBasic
Imports System
Namespace DatabaseDiagram
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
            Me.Label1 = New System.Windows.Forms.Label
            Me.cboDatabaseDiagram = New System.Windows.Forms.ComboBox
            Me.toolStrip1 = New System.Windows.Forms.ToolStrip
            Me.saveToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.saveAsToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.exportToolStripButton = New System.Windows.Forms.ToolStripDropDownButton
            Me.pNGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.jPEGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.gIFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.sVGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
            Me.zoomInToolStripButton = New System.Windows.Forms.ToolStripDropDownButton
            Me.zoomInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.zoomOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.resetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
            Me.panel2 = New System.Windows.Forms.Panel
            Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
            Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
            Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
            Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
            Me.colorDialog1 = New System.Windows.Forms.ColorDialog
            Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
            Me.panel1.SuspendLayout()
            Me.toolStrip1.SuspendLayout()
            Me.panel2.SuspendLayout()
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.panel1.Controls.Add(Me.Label1)
            Me.panel1.Controls.Add(Me.cboDatabaseDiagram)
            Me.panel1.Controls.Add(Me.toolStrip1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1028, 60)
            Me.panel1.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(295, 26)
            Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(101, 15)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Select DataSource"
            '
            'cboDatabaseDiagram
            '
            Me.cboDatabaseDiagram.FormattingEnabled = True
            Me.cboDatabaseDiagram.Location = New System.Drawing.Point(400, 24)
            Me.cboDatabaseDiagram.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.cboDatabaseDiagram.Name = "cboDatabaseDiagram"
            Me.cboDatabaseDiagram.Size = New System.Drawing.Size(152, 21)
            Me.cboDatabaseDiagram.TabIndex = 1
            '
            'toolStrip1
            '
            Me.toolStrip1.AutoSize = False
            Me.toolStrip1.BackColor = System.Drawing.Color.Transparent
            Me.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.saveToolStripButton, Me.saveAsToolStripButton, Me.exportToolStripButton, Me.ToolStripSeparator2, Me.zoomInToolStripButton, Me.toolStripSeparator1})
            Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.toolStrip1.Name = "toolStrip1"
            Me.toolStrip1.Size = New System.Drawing.Size(1028, 60)
            Me.toolStrip1.TabIndex = 0
            Me.toolStrip1.Text = "toolStrip1"
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
            Me.saveToolStripButton.Size = New System.Drawing.Size(70, 50)
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
            Me.saveAsToolStripButton.Size = New System.Drawing.Size(70, 50)
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
            Me.exportToolStripButton.Size = New System.Drawing.Size(70, 50)
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
            'ToolStripSeparator2
            '
            Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
            Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 66)
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
            Me.zoomInToolStripButton.Size = New System.Drawing.Size(70, 50)
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
            'toolStripSeparator1
            '
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 66)
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.diagram1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel2.Location = New System.Drawing.Point(0, 60)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(1028, 549)
            Me.panel2.TabIndex = 1
            '
            'diagram1
            '
            Me.diagram1.BackColor = System.Drawing.Color.White
            Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10.0!, 10.0!)
            Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagram1.LayoutManager = Nothing
            Me.diagram1.Location = New System.Drawing.Point(0, 0)
            Me.diagram1.Model = Me.model1
            Me.diagram1.Name = "diagram1"
            Me.diagram1.ScrollVirtualBounds = CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF)
            Me.diagram1.Size = New System.Drawing.Size(1028, 549)
            Me.diagram1.SmartSizeBox = False
            Me.diagram1.TabIndex = 1
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
            Me.model1.LineStyle.LineColor = System.Drawing.Color.LightGray
            Me.model1.LineStyle.LineWidth = 0.0!
            Me.model1.LogicalSize = New System.Drawing.SizeF(827.0!, 1169.0!)
            Me.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            '
            'openFileDialog1
            '
            Me.openFileDialog1.FileName = "openFileDialog1"
            '
            'ImageList
            '
            Me.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
            Me.ImageList.ImageSize = New System.Drawing.Size(16, 16)
            Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1028, 609)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Database Diagram"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.toolStrip1.ResumeLayout(False)
            Me.toolStrip1.PerformLayout()
            Me.panel2.ResumeLayout(False)
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private panel1 As System.Windows.Forms.Panel
        Private panel2 As System.Windows.Forms.Panel
        Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
        Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
        Private colorDialog1 As System.Windows.Forms.ColorDialog
        Private toolStrip1 As System.Windows.Forms.ToolStrip
        Private WithEvents saveToolStripButton As System.Windows.Forms.ToolStripButton
        Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents saveAsToolStripButton As System.Windows.Forms.ToolStripButton
        Private ImageList As System.Windows.Forms.ImageList
        Private exportToolStripButton As System.Windows.Forms.ToolStripDropDownButton
        Private WithEvents pNGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents jPEGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents gIFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents sVGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
        Private model1 As Syncfusion.Windows.Forms.Diagram.Model
        Private zoomInToolStripButton As System.Windows.Forms.ToolStripDropDownButton
        Private WithEvents zoomInToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents zoomOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents resetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cboDatabaseDiagram As System.Windows.Forms.ComboBox
        Private WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    End Class
End Namespace

