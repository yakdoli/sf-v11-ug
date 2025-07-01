Imports Microsoft.VisualBasic
Imports System
Namespace ZoomAndPan
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
            Me.zoomInToolStrip = New System.Windows.Forms.ToolStripButton
            Me.zoomOutToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.panToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.resetToolStripButton = New System.Windows.Forms.ToolStripButton
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
            Me.panel1.Controls.Add(Me.toolStrip1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(706, 63)
            Me.panel1.TabIndex = 0
            '
            'toolStrip1
            '
            Me.toolStrip1.AutoSize = False
            Me.toolStrip1.BackColor = System.Drawing.Color.Transparent
            Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.zoomInToolStrip, Me.zoomOutToolStripButton, Me.panToolStripButton, Me.resetToolStripButton})
            Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.toolStrip1.Name = "toolStrip1"
            Me.toolStrip1.Size = New System.Drawing.Size(706, 63)
            Me.toolStrip1.TabIndex = 0
            Me.toolStrip1.Text = "toolStrip1"
            '
            'zoomInToolStrip
            '
            Me.zoomInToolStrip.AutoSize = False
            Me.zoomInToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.zoomInToolStrip.Image = CType(resources.GetObject("zoomInToolStrip.Image"), System.Drawing.Image)
            Me.zoomInToolStrip.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.zoomInToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.zoomInToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.zoomInToolStrip.Name = "zoomInToolStrip"
            Me.zoomInToolStrip.Size = New System.Drawing.Size(70, 60)
            Me.zoomInToolStrip.Text = "ZoomIn"
            Me.zoomInToolStrip.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.zoomInToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'zoomOutToolStripButton
            '
            Me.zoomOutToolStripButton.AutoSize = False
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
            'panToolStripButton
            '
            Me.panToolStripButton.AutoSize = False
            Me.panToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.panToolStripButton.Image = CType(resources.GetObject("panToolStripButton.Image"), System.Drawing.Image)
            Me.panToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.panToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.panToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.panToolStripButton.Name = "panToolStripButton"
            Me.panToolStripButton.Size = New System.Drawing.Size(70, 60)
            Me.panToolStripButton.Text = "Pan"
            Me.panToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.panToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'resetToolStripButton
            '
            Me.resetToolStripButton.AutoSize = False
            Me.resetToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.resetToolStripButton.Image = CType(resources.GetObject("resetToolStripButton.Image"), System.Drawing.Image)
            Me.resetToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.resetToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.resetToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.resetToolStripButton.Name = "resetToolStripButton"
            Me.resetToolStripButton.Size = New System.Drawing.Size(70, 60)
            Me.resetToolStripButton.Text = "Reset"
            Me.resetToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.resetToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.diagram1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel2.Location = New System.Drawing.Point(0, 63)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(706, 599)
            Me.panel2.TabIndex = 1
            '
            'diagram1
            '
            Me.diagram1.BackColor = System.Drawing.Color.White
            Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10.0!, 10.0!)
            Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagram1.HScroll = True
            Me.diagram1.LayoutManager = Nothing
            Me.diagram1.Location = New System.Drawing.Point(0, 0)
            Me.diagram1.MetroScrollBars = True
            Me.diagram1.Model = Me.model1
            Me.diagram1.Name = "diagram1"
            Me.diagram1.ScrollVirtualBounds = CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF)
            Me.diagram1.Size = New System.Drawing.Size(706, 599)
            Me.diagram1.SmartSizeBox = False
            Me.diagram1.TabIndex = 1
            Me.diagram1.Text = "diagram1"
            '
            '
            '
            Me.diagram1.View.BackgroundColor = System.Drawing.Color.LightGray
            Me.diagram1.View.ClientRectangle = New System.Drawing.Rectangle(0, 0, 0, 0)
            Me.diagram1.View.Controller = Me.diagram1.Controller
            Me.diagram1.View.Grid.MinPixelSpacing = 4.0!
            Me.diagram1.View.Grid.Visible = False
            Me.diagram1.View.ScrollVirtualBounds = CType(resources.GetObject("resource.ScrollVirtualBounds"), System.Drawing.RectangleF)
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
            Me.model1.LineStyle.LineColor = System.Drawing.Color.LightGray
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
            Me.ClientSize = New System.Drawing.Size(706, 662)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ZoomAndPan Demo"
            Me.panel1.ResumeLayout(False)
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
		Private WithEvents zoomInToolStrip As System.Windows.Forms.ToolStripButton
		Private WithEvents zoomOutToolStripButton As System.Windows.Forms.ToolStripButton
		Private ImageList As System.Windows.Forms.ImageList
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Syncfusion.Windows.Forms.Diagram.Model
		Private WithEvents resetToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents panToolStripButton As System.Windows.Forms.ToolStripButton
	End Class
End Namespace

