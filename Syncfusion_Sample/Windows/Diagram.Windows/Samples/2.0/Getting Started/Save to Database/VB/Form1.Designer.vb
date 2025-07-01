Imports Microsoft.VisualBasic
Imports System
Namespace SaveDiagramAsBinary
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.toolStrip2 = New System.Windows.Forms.ToolStrip()
			Me.openToolStripButton = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.connectorToolStripButton = New System.Windows.Forms.ToolStripDropDownButton()
			Me.lineConnectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.directedLineConnectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.orthogonalConnectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.polylineConnectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.bezierConnectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.splineConnectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.comboOpen = New System.Windows.Forms.ComboBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
			Me.newToolStripButton = New System.Windows.Forms.ToolStripButton()
			Me.saveToolStripButton = New System.Windows.Forms.ToolStripButton()
			Me.deleteToolStripButton = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.panel4 = New System.Windows.Forms.Panel()
			Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
			Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.paletteGroupBar1 = New Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(Me.components)
			Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
			Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
			Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
			Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
			Me.panel1.SuspendLayout()
			Me.toolStrip2.SuspendLayout()
			Me.toolStrip1.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.panel4.SuspendLayout()
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel3.SuspendLayout()
			CType(Me.paletteGroupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(237))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(240))))))
			Me.panel1.Controls.Add(Me.toolStrip2)
			Me.panel1.Controls.Add(Me.comboOpen)
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Controls.Add(Me.toolStrip1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(824, 60)
			Me.panel1.TabIndex = 0
			' 
			' toolStrip2
			' 
			Me.toolStrip2.AutoSize = False
			Me.toolStrip2.BackColor = System.Drawing.Color.Transparent
			Me.toolStrip2.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.openToolStripButton, Me.toolStripSeparator1, Me.connectorToolStripButton})
			Me.toolStrip2.Location = New System.Drawing.Point(447, 0)
			Me.toolStrip2.Name = "toolStrip2"
			Me.toolStrip2.Size = New System.Drawing.Size(377, 60)
			Me.toolStrip2.TabIndex = 14
			Me.toolStrip2.Text = "toolStrip2"
			' 
			' openToolStripButton
			' 
			Me.openToolStripButton.AutoSize = False
			Me.openToolStripButton.BackColor = System.Drawing.Color.Transparent
			Me.openToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
			Me.openToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.openToolStripButton.Image = (CType(resources.GetObject("openToolStripButton.Image"), System.Drawing.Image))
			Me.openToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
			Me.openToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.openToolStripButton.Name = "openToolStripButton"
			Me.openToolStripButton.Size = New System.Drawing.Size(70, 60)
			Me.openToolStripButton.Text = "Open"
			Me.openToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.openToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			Me.openToolStripButton.ToolTipText = "Open from Database"
'			Me.openToolStripButton.Click += New System.EventHandler(Me.openToolStripButton_Click)
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 60)
			' 
			' connectorToolStripButton
			' 
			Me.connectorToolStripButton.AutoSize = False
			Me.connectorToolStripButton.BackColor = System.Drawing.Color.Transparent
			Me.connectorToolStripButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.lineConnectorToolStripMenuItem, Me.directedLineConnectorToolStripMenuItem, Me.orthogonalConnectorToolStripMenuItem, Me.polylineConnectorToolStripMenuItem, Me.bezierConnectorToolStripMenuItem, Me.splineConnectorToolStripMenuItem})
			Me.connectorToolStripButton.Image = (CType(resources.GetObject("connectorToolStripButton.Image"), System.Drawing.Image))
			Me.connectorToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
			Me.connectorToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.connectorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.connectorToolStripButton.Name = "connectorToolStripButton"
			Me.connectorToolStripButton.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
			Me.connectorToolStripButton.ShowDropDownArrow = False
			Me.connectorToolStripButton.Size = New System.Drawing.Size(70, 60)
			Me.connectorToolStripButton.Text = "Connectors"
			Me.connectorToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.connectorToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			' 
			' lineConnectorToolStripMenuItem
			' 
			Me.lineConnectorToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
			Me.lineConnectorToolStripMenuItem.Name = "lineConnectorToolStripMenuItem"
			Me.lineConnectorToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
			Me.lineConnectorToolStripMenuItem.Text = "Line Connector"
'			Me.lineConnectorToolStripMenuItem.Click += New System.EventHandler(Me.lineConnectorToolStripMenuItem_Click)
			' 
			' directedLineConnectorToolStripMenuItem
			' 
			Me.directedLineConnectorToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
			Me.directedLineConnectorToolStripMenuItem.Name = "directedLineConnectorToolStripMenuItem"
			Me.directedLineConnectorToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
			Me.directedLineConnectorToolStripMenuItem.Text = "DirectedLine Connector"
'			Me.directedLineConnectorToolStripMenuItem.Click += New System.EventHandler(Me.directedLineConnectorToolStripMenuItem_Click)
			' 
			' orthogonalConnectorToolStripMenuItem
			' 
			Me.orthogonalConnectorToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
			Me.orthogonalConnectorToolStripMenuItem.Name = "orthogonalConnectorToolStripMenuItem"
			Me.orthogonalConnectorToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
			Me.orthogonalConnectorToolStripMenuItem.Text = "Orthogonal Connector"
'			Me.orthogonalConnectorToolStripMenuItem.Click += New System.EventHandler(Me.orthogonalConnectorToolStripMenuItem_Click)
			' 
			' polylineConnectorToolStripMenuItem
			' 
			Me.polylineConnectorToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
			Me.polylineConnectorToolStripMenuItem.Name = "polylineConnectorToolStripMenuItem"
			Me.polylineConnectorToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
			Me.polylineConnectorToolStripMenuItem.Text = "Polyline Connector"
'			Me.polylineConnectorToolStripMenuItem.Click += New System.EventHandler(Me.polylineConnectorToolStripMenuItem_Click)
			' 
			' bezierConnectorToolStripMenuItem
			' 
			Me.bezierConnectorToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
			Me.bezierConnectorToolStripMenuItem.Name = "bezierConnectorToolStripMenuItem"
			Me.bezierConnectorToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
			Me.bezierConnectorToolStripMenuItem.Text = "Bezier Connector"
'			Me.bezierConnectorToolStripMenuItem.Click += New System.EventHandler(Me.bezierConnectorToolStripMenuItem_Click)
			' 
			' splineConnectorToolStripMenuItem
			' 
			Me.splineConnectorToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
			Me.splineConnectorToolStripMenuItem.Name = "splineConnectorToolStripMenuItem"
			Me.splineConnectorToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
			Me.splineConnectorToolStripMenuItem.Text = "Spline Connector"
'			Me.splineConnectorToolStripMenuItem.Click += New System.EventHandler(Me.splineConnectorToolStripMenuItem_Click)
			' 
			' comboOpen
			' 
			Me.comboOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.comboOpen.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboOpen.FormattingEnabled = True
			Me.comboOpen.Items.AddRange(New Object() { "Rectangle Layer", "Ellipse Layer", "RoundRect Layer"})
			Me.comboOpen.Location = New System.Drawing.Point(299, 12)
			Me.comboOpen.Name = "comboOpen"
			Me.comboOpen.Size = New System.Drawing.Size(145, 23)
			Me.comboOpen.TabIndex = 13
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Location = New System.Drawing.Point(225, 15)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(68, 15)
			Me.label2.TabIndex = 12
			Me.label2.Text = "Choose File"
			' 
			' toolStrip1
			' 
			Me.toolStrip1.AutoSize = False
			Me.toolStrip1.BackColor = System.Drawing.Color.Transparent
			Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.newToolStripButton, Me.saveToolStripButton, Me.deleteToolStripButton, Me.toolStripSeparator3})
			Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.Size = New System.Drawing.Size(544, 60)
			Me.toolStrip1.TabIndex = 0
			Me.toolStrip1.Text = "toolStrip1"
			' 
			' newToolStripButton
			' 
			Me.newToolStripButton.AutoSize = False
			Me.newToolStripButton.BackColor = System.Drawing.Color.Transparent
			Me.newToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
			Me.newToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.newToolStripButton.Image = (CType(resources.GetObject("newToolStripButton.Image"), System.Drawing.Image))
			Me.newToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
			Me.newToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.newToolStripButton.Name = "newToolStripButton"
			Me.newToolStripButton.Size = New System.Drawing.Size(70, 60)
			Me.newToolStripButton.Text = "New"
			Me.newToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.newToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
'			Me.newToolStripButton.Click += New System.EventHandler(Me.newToolStripButton_Click)
			' 
			' saveToolStripButton
			' 
			Me.saveToolStripButton.AutoSize = False
			Me.saveToolStripButton.BackColor = System.Drawing.Color.Transparent
			Me.saveToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
			Me.saveToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.saveToolStripButton.Image = (CType(resources.GetObject("saveToolStripButton.Image"), System.Drawing.Image))
			Me.saveToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
			Me.saveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.saveToolStripButton.Name = "saveToolStripButton"
			Me.saveToolStripButton.Size = New System.Drawing.Size(70, 60)
			Me.saveToolStripButton.Text = "Save"
			Me.saveToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.saveToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			Me.saveToolStripButton.ToolTipText = "Save to Database"
'			Me.saveToolStripButton.Click += New System.EventHandler(Me.saveToolStripButton_Click)
			' 
			' deleteToolStripButton
			' 
			Me.deleteToolStripButton.AutoSize = False
			Me.deleteToolStripButton.BackColor = System.Drawing.Color.Transparent
			Me.deleteToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
			Me.deleteToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.deleteToolStripButton.Image = (CType(resources.GetObject("deleteToolStripButton.Image"), System.Drawing.Image))
			Me.deleteToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
			Me.deleteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.deleteToolStripButton.Name = "deleteToolStripButton"
			Me.deleteToolStripButton.Size = New System.Drawing.Size(70, 60)
			Me.deleteToolStripButton.Text = "Delete"
			Me.deleteToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.deleteToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			Me.deleteToolStripButton.ToolTipText = "Delete from Database"
'			Me.deleteToolStripButton.Click += New System.EventHandler(Me.deleteToolStripButton_Click)
			' 
			' toolStripSeparator3
			' 
			Me.toolStripSeparator3.Name = "toolStripSeparator3"
			Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 60)
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.panel4)
			Me.panel2.Controls.Add(Me.panel3)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel2.Location = New System.Drawing.Point(0, 60)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(824, 598)
			Me.panel2.TabIndex = 1
			' 
			' panel4
			' 
			Me.panel4.Controls.Add(Me.diagram1)
			Me.panel4.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel4.Location = New System.Drawing.Point(218, 0)
			Me.panel4.Name = "panel4"
			Me.panel4.Size = New System.Drawing.Size(606, 598)
			Me.panel4.TabIndex = 0
			' 
			' diagram1
			' 
			Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10F, 10F)
			Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.diagram1.LayoutManager = Nothing
			Me.diagram1.Location = New System.Drawing.Point(0, 0)
			Me.diagram1.Model = Me.model1
			Me.diagram1.Name = "diagram1"
			Me.diagram1.ScrollVirtualBounds = (CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF))
			Me.diagram1.Size = New System.Drawing.Size(606, 598)
			Me.diagram1.SmartSizeBox = False
			Me.diagram1.TabIndex = 0
			Me.diagram1.Text = "diagram1"
			' 
			' 
			' 
			Me.diagram1.View.ClientRectangle = New System.Drawing.Rectangle(0, 0, 0, 0)
			Me.diagram1.View.Controller = Me.diagram1.Controller
			Me.diagram1.View.Grid.MinPixelSpacing = 4F
			Me.diagram1.View.Grid.Visible = False
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
			Me.model1.LineStyle.LineWidth = 0F
			Me.model1.LogicalSize = New System.Drawing.SizeF(827F, 1169F)
			Me.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))))
			Me.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))))
			' 
			' panel3
			' 
			Me.panel3.Controls.Add(Me.paletteGroupBar1)
			Me.panel3.Dock = System.Windows.Forms.DockStyle.Left
			Me.panel3.Location = New System.Drawing.Point(0, 0)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(218, 598)
			Me.panel3.TabIndex = 0
			' 
			' paletteGroupBar1
			' 
			Me.paletteGroupBar1.AllowDrop = True
			Me.paletteGroupBar1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235))))))
			Me.paletteGroupBar1.BorderColor = System.Drawing.Color.White
			Me.paletteGroupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.paletteGroupBar1.Diagram = Nothing
			Me.paletteGroupBar1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.paletteGroupBar1.EditMode = False
			Me.paletteGroupBar1.ExpandButtonToolTip = Nothing
			Me.paletteGroupBar1.FlatLook = True
			Me.paletteGroupBar1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.paletteGroupBar1.ForeColor = System.Drawing.Color.White
			Me.paletteGroupBar1.GroupBarDropDownToolTip = Nothing
			Me.paletteGroupBar1.GroupBarItemHeight = 32
			Me.paletteGroupBar1.IndexOnVisibleItems = True
			Me.paletteGroupBar1.Location = New System.Drawing.Point(0, 0)
			Me.paletteGroupBar1.MinimizeButtonToolTip = Nothing
			Me.paletteGroupBar1.Name = "paletteGroupBar1"
			Me.paletteGroupBar1.NavigationPaneTooltip = Nothing
			Me.paletteGroupBar1.PopupClientSize = New System.Drawing.Size(0, 0)
			Me.paletteGroupBar1.Size = New System.Drawing.Size(218, 598)
			Me.paletteGroupBar1.TabIndex = 1
			Me.paletteGroupBar1.Text = "paletteGroupBar1"
			Me.paletteGroupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
			Me.paletteGroupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro
			' 
			' openFileDialog1
			' 
			Me.openFileDialog1.FileName = "openFileDialog1"
			' 
			' ImageList
			' 
			Me.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
			Me.ImageList.ImageSize = New System.Drawing.Size(16, 16)
			Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(824, 658)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.panel1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Save Diagram to DataBase"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.toolStrip2.ResumeLayout(False)
			Me.toolStrip2.PerformLayout()
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.panel2.ResumeLayout(False)
			Me.panel4.ResumeLayout(False)
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel3.ResumeLayout(False)
			CType(Me.paletteGroupBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panel1 As System.Windows.Forms.Panel
		Private panel2 As System.Windows.Forms.Panel
		Private toolStrip1 As System.Windows.Forms.ToolStrip
		Private WithEvents deleteToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
		Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
		Private ImageList As System.Windows.Forms.ImageList
		Private colorDialog1 As System.Windows.Forms.ColorDialog
		Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
		Private comboOpen As System.Windows.Forms.ComboBox
		Private label2 As System.Windows.Forms.Label
		Private panel4 As System.Windows.Forms.Panel
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Syncfusion.Windows.Forms.Diagram.Model
		Private panel3 As System.Windows.Forms.Panel
		Private paletteGroupBar1 As Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar
		Private WithEvents newToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents saveToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStrip2 As System.Windows.Forms.ToolStrip
		Private WithEvents openToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private connectorToolStripButton As System.Windows.Forms.ToolStripDropDownButton
		Private WithEvents lineConnectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents directedLineConnectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents orthogonalConnectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents polylineConnectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents bezierConnectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents splineConnectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	End Class
End Namespace

