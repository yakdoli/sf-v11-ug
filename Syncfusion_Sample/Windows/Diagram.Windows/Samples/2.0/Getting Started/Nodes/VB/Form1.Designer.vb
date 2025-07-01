Imports Microsoft.VisualBasic
Imports System
Namespace NodesDemo
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
            Me.rectToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.ellpToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.rrectToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.polyToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.semiStripButton12 = New System.Windows.Forms.ToolStripButton
            Me.carcToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.bmpToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.textToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.rchtxtToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.lineToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.polylneToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.curveToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.closdCurvToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.splineToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.bezierToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.panel2 = New System.Windows.Forms.Panel
            Me.propertyEditor1 = New Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor(Me.components)
            Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
            Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
            Me.panel3 = New System.Windows.Forms.Panel
            Me.pencilToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.panel1.SuspendLayout()
            Me.toolStrip1.SuspendLayout()
            Me.panel2.SuspendLayout()
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.panel1.Controls.Add(Me.toolStrip1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Margin = New System.Windows.Forms.Padding(4)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1500, 76)
            Me.panel1.TabIndex = 0
            '
            'toolStrip1
            '
            Me.toolStrip1.BackColor = System.Drawing.Color.Transparent
            Me.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.rectToolStripButton, Me.ellpToolStripButton, Me.rrectToolStripButton, Me.polyToolStripButton, Me.semiStripButton12, Me.carcToolStripButton, Me.bmpToolStripButton, Me.textToolStripButton, Me.rchtxtToolStripButton, Me.lineToolStripButton, Me.polylneToolStripButton, Me.curveToolStripButton, Me.closdCurvToolStripButton, Me.splineToolStripButton, Me.bezierToolStripButton, Me.pencilToolStripButton})
            Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.toolStrip1.Name = "toolStrip1"
            Me.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
            Me.toolStrip1.Size = New System.Drawing.Size(1500, 63)
            Me.toolStrip1.TabIndex = 0
            Me.toolStrip1.Text = "toolStrip1"
            '
            'rectToolStripButton
            '
            Me.rectToolStripButton.AutoSize = False
            Me.rectToolStripButton.BackColor = System.Drawing.Color.Transparent
            Me.rectToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.rectToolStripButton.Image = CType(resources.GetObject("rectToolStripButton.Image"), System.Drawing.Image)
            Me.rectToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.rectToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.rectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.rectToolStripButton.Name = "rectToolStripButton"
            Me.rectToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.rectToolStripButton.Size = New System.Drawing.Size(84, 60)
            Me.rectToolStripButton.Text = "Rectangle "
            Me.rectToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.rectToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            Me.rectToolStripButton.ToolTipText = "Rectangle Tool"
            '
            'ellpToolStripButton
            '
            Me.ellpToolStripButton.AutoSize = False
            Me.ellpToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.ellpToolStripButton.Image = CType(resources.GetObject("ellpToolStripButton.Image"), System.Drawing.Image)
            Me.ellpToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.ellpToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ellpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ellpToolStripButton.Name = "ellpToolStripButton"
            Me.ellpToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.ellpToolStripButton.Size = New System.Drawing.Size(70, 60)
            Me.ellpToolStripButton.Text = "Ellipse "
            Me.ellpToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.ellpToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            Me.ellpToolStripButton.ToolTipText = "Ellipse Tool"
            '
            'rrectToolStripButton
            '
            Me.rrectToolStripButton.AutoSize = False
            Me.rrectToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.rrectToolStripButton.Image = CType(resources.GetObject("rrectToolStripButton.Image"), System.Drawing.Image)
            Me.rrectToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.rrectToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.rrectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.rrectToolStripButton.Name = "rrectToolStripButton"
            Me.rrectToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.rrectToolStripButton.Size = New System.Drawing.Size(90, 60)
            Me.rrectToolStripButton.Text = "RoundRect"
            Me.rrectToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.rrectToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            Me.rrectToolStripButton.ToolTipText = "RoundRect Tool"
            '
            'polyToolStripButton
            '
            Me.polyToolStripButton.AutoSize = False
            Me.polyToolStripButton.Image = CType(resources.GetObject("polyToolStripButton.Image"), System.Drawing.Image)
            Me.polyToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.polyToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.polyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.polyToolStripButton.Name = "polyToolStripButton"
            Me.polyToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.polyToolStripButton.Size = New System.Drawing.Size(86, 60)
            Me.polyToolStripButton.Text = "Polygon "
            Me.polyToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.polyToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            Me.polyToolStripButton.ToolTipText = "Polygon Tool"
            '
            'semiStripButton12
            '
            Me.semiStripButton12.AutoSize = False
            Me.semiStripButton12.Image = CType(resources.GetObject("semiStripButton12.Image"), System.Drawing.Image)
            Me.semiStripButton12.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.semiStripButton12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.semiStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.semiStripButton12.Name = "semiStripButton12"
            Me.semiStripButton12.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.semiStripButton12.Size = New System.Drawing.Size(80, 60)
            Me.semiStripButton12.Text = "SemiCircle"
            Me.semiStripButton12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.semiStripButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            Me.semiStripButton12.ToolTipText = "SemiCircle Tool"
            '
            'carcToolStripButton
            '
            Me.carcToolStripButton.AutoSize = False
            Me.carcToolStripButton.Image = CType(resources.GetObject("carcToolStripButton.Image"), System.Drawing.Image)
            Me.carcToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.carcToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.carcToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.carcToolStripButton.Name = "carcToolStripButton"
            Me.carcToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.carcToolStripButton.Size = New System.Drawing.Size(80, 60)
            Me.carcToolStripButton.Text = "CircularArc"
            Me.carcToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.carcToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            Me.carcToolStripButton.ToolTipText = "CircularArc Tool"
            '
            'bmpToolStripButton
            '
            Me.bmpToolStripButton.AutoSize = False
            Me.bmpToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.bmpToolStripButton.Image = CType(resources.GetObject("bmpToolStripButton.Image"), System.Drawing.Image)
            Me.bmpToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.bmpToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.bmpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.bmpToolStripButton.Name = "bmpToolStripButton"
            Me.bmpToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.bmpToolStripButton.Size = New System.Drawing.Size(70, 60)
            Me.bmpToolStripButton.Text = "Bitmap"
            Me.bmpToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.bmpToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            Me.bmpToolStripButton.ToolTipText = "Bitmap  Tool"
            '
            'textToolStripButton
            '
            Me.textToolStripButton.AutoSize = False
            Me.textToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.textToolStripButton.Image = CType(resources.GetObject("textToolStripButton.Image"), System.Drawing.Image)
            Me.textToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.textToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.textToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.textToolStripButton.Name = "textToolStripButton"
            Me.textToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.textToolStripButton.Size = New System.Drawing.Size(75, 60)
            Me.textToolStripButton.Text = "TextTool"
            Me.textToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.textToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            Me.textToolStripButton.ToolTipText = "TextNode Tool"
            '
            'rchtxtToolStripButton
            '
            Me.rchtxtToolStripButton.AutoSize = False
            Me.rchtxtToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.rchtxtToolStripButton.Image = CType(resources.GetObject("rchtxtToolStripButton.Image"), System.Drawing.Image)
            Me.rchtxtToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.rchtxtToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.rchtxtToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.rchtxtToolStripButton.Name = "rchtxtToolStripButton"
            Me.rchtxtToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.rchtxtToolStripButton.Size = New System.Drawing.Size(95, 60)
            Me.rchtxtToolStripButton.Text = "RichTextTool"
            Me.rchtxtToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.rchtxtToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            Me.rchtxtToolStripButton.ToolTipText = "RichText Tool"
            '
            'lineToolStripButton
            '
            Me.lineToolStripButton.AutoSize = False
            Me.lineToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.lineToolStripButton.Image = CType(resources.GetObject("lineToolStripButton.Image"), System.Drawing.Image)
            Me.lineToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.lineToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.lineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.lineToolStripButton.Name = "lineToolStripButton"
            Me.lineToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.lineToolStripButton.Size = New System.Drawing.Size(70, 60)
            Me.lineToolStripButton.Text = "Line "
            Me.lineToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.lineToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            Me.lineToolStripButton.ToolTipText = "Line Tool"
            '
            'polylneToolStripButton
            '
            Me.polylneToolStripButton.AutoSize = False
            Me.polylneToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.polylneToolStripButton.Image = CType(resources.GetObject("polylneToolStripButton.Image"), System.Drawing.Image)
            Me.polylneToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.polylneToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.polylneToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.polylneToolStripButton.Name = "polylneToolStripButton"
            Me.polylneToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.polylneToolStripButton.Size = New System.Drawing.Size(84, 60)
            Me.polylneToolStripButton.Text = "PolyLine "
            Me.polylneToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.polylneToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            Me.polylneToolStripButton.ToolTipText = "PolyLine Tool"
            '
            'curveToolStripButton
            '
            Me.curveToolStripButton.AutoSize = False
            Me.curveToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.curveToolStripButton.Image = CType(resources.GetObject("curveToolStripButton.Image"), System.Drawing.Image)
            Me.curveToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.curveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.curveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.curveToolStripButton.Name = "curveToolStripButton"
            Me.curveToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.curveToolStripButton.Size = New System.Drawing.Size(70, 60)
            Me.curveToolStripButton.Text = "Curve "
            Me.curveToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.curveToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            Me.curveToolStripButton.ToolTipText = "Curve Tool"
            '
            'closdCurvToolStripButton
            '
            Me.closdCurvToolStripButton.AutoSize = False
            Me.closdCurvToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.closdCurvToolStripButton.Image = CType(resources.GetObject("closdCurvToolStripButton.Image"), System.Drawing.Image)
            Me.closdCurvToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.closdCurvToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.closdCurvToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.closdCurvToolStripButton.Name = "closdCurvToolStripButton"
            Me.closdCurvToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.closdCurvToolStripButton.Size = New System.Drawing.Size(90, 60)
            Me.closdCurvToolStripButton.Text = "ClosedCurve"
            Me.closdCurvToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.closdCurvToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            Me.closdCurvToolStripButton.ToolTipText = "ClosedCurve tool"
            '
            'splineToolStripButton
            '
            Me.splineToolStripButton.AutoSize = False
            Me.splineToolStripButton.Image = CType(resources.GetObject("splineToolStripButton.Image"), System.Drawing.Image)
            Me.splineToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.splineToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.splineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.splineToolStripButton.Name = "splineToolStripButton"
            Me.splineToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.splineToolStripButton.Size = New System.Drawing.Size(70, 60)
            Me.splineToolStripButton.Text = "Spline "
            Me.splineToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.splineToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            Me.splineToolStripButton.ToolTipText = "Spline Tool"
            '
            'bezierToolStripButton
            '
            Me.bezierToolStripButton.AutoSize = False
            Me.bezierToolStripButton.Image = CType(resources.GetObject("bezierToolStripButton.Image"), System.Drawing.Image)
            Me.bezierToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.bezierToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.bezierToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.bezierToolStripButton.Name = "bezierToolStripButton"
            Me.bezierToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.bezierToolStripButton.Size = New System.Drawing.Size(70, 60)
            Me.bezierToolStripButton.Text = "Bezier "
            Me.bezierToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.bezierToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            Me.bezierToolStripButton.ToolTipText = "Bezier Tool"
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.propertyEditor1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel2.Location = New System.Drawing.Point(1168, 76)
            Me.panel2.Margin = New System.Windows.Forms.Padding(4)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(332, 715)
            Me.panel2.TabIndex = 1
            '
            'propertyEditor1
            '
            Me.propertyEditor1.Diagram = Me.diagram1
            Me.propertyEditor1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyEditor1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.propertyEditor1.Location = New System.Drawing.Point(0, 0)
            Me.propertyEditor1.Margin = New System.Windows.Forms.Padding(4)
            Me.propertyEditor1.Name = "propertyEditor1"
            Me.propertyEditor1.Size = New System.Drawing.Size(332, 715)
            Me.propertyEditor1.TabIndex = 0
            '
            'diagram1
            '
            Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10.0!, 10.0!)
            Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagram1.LayoutManager = Nothing
            Me.diagram1.Location = New System.Drawing.Point(0, 0)
            Me.diagram1.Margin = New System.Windows.Forms.Padding(4)
            Me.diagram1.Model = Me.model1
            Me.diagram1.Name = "diagram1"
            Me.diagram1.ScrollVirtualBounds = CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF)
            Me.diagram1.Size = New System.Drawing.Size(1168, 715)
            Me.diagram1.SmartSizeBox = False
            Me.diagram1.TabIndex = 0
            Me.diagram1.Text = "diagram1"
            '
            '
            '
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
            Me.model1.DocumentSize.Width = 900.0!
            Me.model1.LineStyle.DashPattern = Nothing
            Me.model1.LineStyle.LineColor = System.Drawing.Color.Black
            Me.model1.LineStyle.LineWidth = 0.0!
            Me.model1.LogicalSize = New System.Drawing.SizeF(900.0!, 1169.0!)
            Me.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            '
            'panel3
            '
            Me.panel3.Controls.Add(Me.diagram1)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel3.Location = New System.Drawing.Point(0, 76)
            Me.panel3.Margin = New System.Windows.Forms.Padding(4)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(1168, 715)
            Me.panel3.TabIndex = 2
            '
            'pencilToolStripButton
            '
            Me.pencilToolStripButton.AutoSize = False
            Me.pencilToolStripButton.Image = CType(resources.GetObject("pencilToolStripButton.Image"), System.Drawing.Image)
            Me.pencilToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.pencilToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.pencilToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.pencilToolStripButton.Name = "pencilToolStripButton"
            Me.pencilToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.pencilToolStripButton.Size = New System.Drawing.Size(80, 60)
            Me.pencilToolStripButton.Text = "PencilTool "
            Me.pencilToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.pencilToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            Me.pencilToolStripButton.ToolTipText = "Bezier Tool"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1500, 791)
            Me.Controls.Add(Me.panel3)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Nodes"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.toolStrip1.ResumeLayout(False)
            Me.toolStrip1.PerformLayout()
            Me.panel2.ResumeLayout(False)
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private panel1 As System.Windows.Forms.Panel
		Private toolStrip1 As System.Windows.Forms.ToolStrip
		Private WithEvents rrectToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents textToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents rchtxtToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents lineToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents polylneToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents curveToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents closdCurvToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents rectToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents ellpToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents polyToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents semiStripButton12 As System.Windows.Forms.ToolStripButton
		Private WithEvents bmpToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents carcToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents splineToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents bezierToolStripButton As System.Windows.Forms.ToolStripButton
		Private panel2 As System.Windows.Forms.Panel
		Private propertyEditor1 As Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor
		Private panel3 As System.Windows.Forms.Panel
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
        Private model1 As Syncfusion.Windows.Forms.Diagram.Model
        Private WithEvents pencilToolStripButton As System.Windows.Forms.ToolStripButton
	End Class
End Namespace

