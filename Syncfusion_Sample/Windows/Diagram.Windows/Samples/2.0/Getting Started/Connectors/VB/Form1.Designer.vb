Imports Microsoft.VisualBasic
Imports System
Namespace ConnectorsDemo
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
            Me.lineToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.directLnToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.orthoToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.polyToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.splineToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.bezierToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.panel2 = New System.Windows.Forms.Panel
            Me.propertyEditor1 = New Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor(Me.components)
            Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
            Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
            Me.panel3 = New System.Windows.Forms.Panel
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
            Me.panel1.Size = New System.Drawing.Size(1029, 76)
            Me.panel1.TabIndex = 0
            '
            'toolStrip1
            '
            Me.toolStrip1.BackColor = System.Drawing.Color.Transparent
            Me.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lineToolStripButton, Me.directLnToolStripButton, Me.orthoToolStripButton, Me.polyToolStripButton, Me.splineToolStripButton, Me.bezierToolStripButton})
            Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.toolStrip1.Name = "toolStrip1"
            Me.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
            Me.toolStrip1.Size = New System.Drawing.Size(1029, 63)
            Me.toolStrip1.TabIndex = 0
            Me.toolStrip1.Text = "toolStrip1"
            '
            'lineToolStripButton
            '
            Me.lineToolStripButton.AutoSize = False
            Me.lineToolStripButton.BackColor = System.Drawing.Color.Transparent
            Me.lineToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.lineToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lineToolStripButton.Image = CType(resources.GetObject("lineToolStripButton.Image"), System.Drawing.Image)
            Me.lineToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.lineToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.lineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.lineToolStripButton.Name = "lineToolStripButton"
            Me.lineToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.lineToolStripButton.Size = New System.Drawing.Size(110, 60)
            Me.lineToolStripButton.Text = "LineLinkTool"
            Me.lineToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.lineToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            Me.lineToolStripButton.ToolTipText = "LineLinkTool"
            '
            'directLnToolStripButton
            '
            Me.directLnToolStripButton.AutoSize = False
            Me.directLnToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.directLnToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.directLnToolStripButton.Image = CType(resources.GetObject("directLnToolStripButton.Image"), System.Drawing.Image)
            Me.directLnToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.directLnToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.directLnToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.directLnToolStripButton.Name = "directLnToolStripButton"
            Me.directLnToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.directLnToolStripButton.Size = New System.Drawing.Size(150, 60)
            Me.directLnToolStripButton.Text = "DirectedLineLinkTool"
            Me.directLnToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.directLnToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            Me.directLnToolStripButton.ToolTipText = "DirectedLineLinkTool"
            '
            'orthoToolStripButton
            '
            Me.orthoToolStripButton.AutoSize = False
            Me.orthoToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.orthoToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.orthoToolStripButton.Image = CType(resources.GetObject("orthoToolStripButton.Image"), System.Drawing.Image)
            Me.orthoToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.orthoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.orthoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.orthoToolStripButton.Name = "orthoToolStripButton"
            Me.orthoToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.orthoToolStripButton.Size = New System.Drawing.Size(150, 60)
            Me.orthoToolStripButton.Text = "OrthogonalLinkTool"
            Me.orthoToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.orthoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            Me.orthoToolStripButton.ToolTipText = "OrthogonalLinkTool"
            '
            'polyToolStripButton
            '
            Me.polyToolStripButton.AutoSize = False
            Me.polyToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.polyToolStripButton.Image = CType(resources.GetObject("polyToolStripButton.Image"), System.Drawing.Image)
            Me.polyToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.polyToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.polyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.polyToolStripButton.Name = "polyToolStripButton"
            Me.polyToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.polyToolStripButton.Size = New System.Drawing.Size(120, 60)
            Me.polyToolStripButton.Text = "PolyLineLinkTool"
            Me.polyToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.polyToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            Me.polyToolStripButton.ToolTipText = "PolyLineLinkTool"
            '
            'splineToolStripButton
            '
            Me.splineToolStripButton.AutoSize = False
            Me.splineToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.splineToolStripButton.Image = CType(resources.GetObject("splineToolStripButton.Image"), System.Drawing.Image)
            Me.splineToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.splineToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.splineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.splineToolStripButton.Name = "splineToolStripButton"
            Me.splineToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.splineToolStripButton.Size = New System.Drawing.Size(90, 60)
            Me.splineToolStripButton.Text = "SplineTool"
            Me.splineToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.splineToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'bezierToolStripButton
            '
            Me.bezierToolStripButton.AutoSize = False
            Me.bezierToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bezierToolStripButton.Image = CType(resources.GetObject("bezierToolStripButton.Image"), System.Drawing.Image)
            Me.bezierToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.bezierToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.bezierToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.bezierToolStripButton.Name = "bezierToolStripButton"
            Me.bezierToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
            Me.bezierToolStripButton.Size = New System.Drawing.Size(90, 60)
            Me.bezierToolStripButton.Text = "BezierTool"
            Me.bezierToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.bezierToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.propertyEditor1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel2.Location = New System.Drawing.Point(682, 76)
            Me.panel2.Margin = New System.Windows.Forms.Padding(4)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(347, 691)
            Me.panel2.TabIndex = 1
            '
            'propertyEditor1
            '
            Me.propertyEditor1.Diagram = Me.diagram1
            Me.propertyEditor1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyEditor1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.propertyEditor1.Location = New System.Drawing.Point(0, 0)
            Me.propertyEditor1.Margin = New System.Windows.Forms.Padding(4)
            Me.propertyEditor1.Name = "propertyEditor1"
            Me.propertyEditor1.Size = New System.Drawing.Size(347, 691)
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
            Me.diagram1.Size = New System.Drawing.Size(682, 691)
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
            Me.panel3.Size = New System.Drawing.Size(682, 691)
            Me.panel3.TabIndex = 2
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1029, 767)
            Me.Controls.Add(Me.panel3)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Connectors"
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
		Private WithEvents orthoToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents lineToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents directLnToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents polyToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents splineToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents bezierToolStripButton As System.Windows.Forms.ToolStripButton
		Private panel2 As System.Windows.Forms.Panel
		Private propertyEditor1 As Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor
		Private panel3 As System.Windows.Forms.Panel
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Syncfusion.Windows.Forms.Diagram.Model
	End Class
End Namespace

