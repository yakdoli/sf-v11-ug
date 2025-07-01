Imports Microsoft.VisualBasic
Imports System
Namespace Network_Diagram
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
			Me.apply = New System.Windows.Forms.Button()
			Me.chkRemoveLyr = New System.Windows.Forms.CheckBox()
			Me.txtLayerName = New System.Windows.Forms.TextBox()
			Me.chkVisibleLyr = New System.Windows.Forms.CheckBox()
			Me.toolStrip2 = New System.Windows.Forms.ToolStrip()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.comboLayers = New System.Windows.Forms.ComboBox()
			Me.createLyr = New System.Windows.Forms.Button()
			Me.chkEnableLyr = New System.Windows.Forms.CheckBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.chkEnableNewlayer = New System.Windows.Forms.CheckBox()
			Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
			Me.newToolStripButton = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
			Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
			Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
			Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
			Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.paletteGroupBar1 = New Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(Me.components)
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
			Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
			Me.panel1.SuspendLayout()
			Me.toolStrip2.SuspendLayout()
			Me.toolStrip1.SuspendLayout()
			Me.panel2.SuspendLayout()
			CType(Me.paletteGroupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel3.SuspendLayout()
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(237))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(240))))))
			Me.panel1.Controls.Add(Me.apply)
			Me.panel1.Controls.Add(Me.chkRemoveLyr)
			Me.panel1.Controls.Add(Me.txtLayerName)
			Me.panel1.Controls.Add(Me.chkVisibleLyr)
			Me.panel1.Controls.Add(Me.toolStrip2)
			Me.panel1.Controls.Add(Me.comboLayers)
			Me.panel1.Controls.Add(Me.createLyr)
			Me.panel1.Controls.Add(Me.chkEnableLyr)
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Controls.Add(Me.chkEnableNewlayer)
			Me.panel1.Controls.Add(Me.toolStrip1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(1207, 70)
			Me.panel1.TabIndex = 0
			' 
			' apply
			' 
			Me.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.apply.Font = New System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.apply.Location = New System.Drawing.Point(586, 11)
			Me.apply.Name = "apply"
			Me.apply.Size = New System.Drawing.Size(83, 52)
			Me.apply.TabIndex = 12
			Me.apply.Text = "Apply"
			Me.apply.UseVisualStyleBackColor = True
'			Me.apply.Click += New System.EventHandler(Me.apply_Click)
			' 
			' chkRemoveLyr
			' 
			Me.chkRemoveLyr.AutoSize = True
			Me.chkRemoveLyr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.chkRemoveLyr.Font = New System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.chkRemoveLyr.Location = New System.Drawing.Point(492, 44)
			Me.chkRemoveLyr.Name = "chkRemoveLyr"
			Me.chkRemoveLyr.Size = New System.Drawing.Size(69, 19)
			Me.chkRemoveLyr.TabIndex = 14
			Me.chkRemoveLyr.Text = "Remove"
			Me.chkRemoveLyr.UseVisualStyleBackColor = True
			' 
			' txtLayerName
			' 
			Me.txtLayerName.Location = New System.Drawing.Point(158, 11)
			Me.txtLayerName.Name = "txtLayerName"
			Me.txtLayerName.Size = New System.Drawing.Size(168, 20)
			Me.txtLayerName.TabIndex = 9
			' 
			' chkVisibleLyr
			' 
			Me.chkVisibleLyr.AutoSize = True
			Me.chkVisibleLyr.Checked = True
			Me.chkVisibleLyr.CheckState = System.Windows.Forms.CheckState.Checked
			Me.chkVisibleLyr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.chkVisibleLyr.Font = New System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.chkVisibleLyr.Location = New System.Drawing.Point(422, 44)
			Me.chkVisibleLyr.Name = "chkVisibleLyr"
			Me.chkVisibleLyr.Size = New System.Drawing.Size(60, 19)
			Me.chkVisibleLyr.TabIndex = 13
			Me.chkVisibleLyr.Text = "Visible"
			Me.chkVisibleLyr.UseVisualStyleBackColor = True
			' 
			' toolStrip2
			' 
			Me.toolStrip2.AutoSize = False
			Me.toolStrip2.BackColor = System.Drawing.Color.Transparent
			Me.toolStrip2.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripSeparator1})
			Me.toolStrip2.Location = New System.Drawing.Point(329, 3)
			Me.toolStrip2.Name = "toolStrip2"
			Me.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
			Me.toolStrip2.Size = New System.Drawing.Size(7, 67)
			Me.toolStrip2.TabIndex = 13
			Me.toolStrip2.Text = "toolStrip2"
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 67)
			' 
			' comboLayers
			' 
			Me.comboLayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.comboLayers.FormattingEnabled = True
			Me.comboLayers.Items.AddRange(New Object() { "Ethernet Layer", "ControlNet Layer", "DeviceNet Layer"})
			Me.comboLayers.Location = New System.Drawing.Point(416, 12)
			Me.comboLayers.Name = "comboLayers"
			Me.comboLayers.Size = New System.Drawing.Size(145, 21)
			Me.comboLayers.TabIndex = 13
'			Me.comboLayers.SelectedIndexChanged += New System.EventHandler(Me.comboLayers_SelectedIndexChanged)
			' 
			' createLyr
			' 
			Me.createLyr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.createLyr.Font = New System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.createLyr.Location = New System.Drawing.Point(235, 40)
			Me.createLyr.Name = "createLyr"
			Me.createLyr.Size = New System.Drawing.Size(91, 23)
			Me.createLyr.TabIndex = 2
			Me.createLyr.TabStop = False
			Me.createLyr.Text = "Add"
			Me.createLyr.UseVisualStyleBackColor = True
'			Me.createLyr.Click += New System.EventHandler(Me.createLyr_Click)
			' 
			' chkEnableLyr
			' 
			Me.chkEnableLyr.AutoSize = True
			Me.chkEnableLyr.Checked = True
			Me.chkEnableLyr.CheckState = System.Windows.Forms.CheckState.Checked
			Me.chkEnableLyr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.chkEnableLyr.Font = New System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.chkEnableLyr.Location = New System.Drawing.Point(343, 44)
			Me.chkEnableLyr.Name = "chkEnableLyr"
			Me.chkEnableLyr.Size = New System.Drawing.Size(62, 19)
			Me.chkEnableLyr.TabIndex = 12
			Me.chkEnableLyr.Text = "Enable"
			Me.chkEnableLyr.UseVisualStyleBackColor = True
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Location = New System.Drawing.Point(340, 14)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(44, 15)
			Me.label2.TabIndex = 12
			Me.label2.Text = "Layers"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(70, 11)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(74, 15)
			Me.label1.TabIndex = 8
			Me.label1.Text = "Layer Name"
			' 
			' chkEnableNewlayer
			' 
			Me.chkEnableNewlayer.AutoSize = True
			Me.chkEnableNewlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.chkEnableNewlayer.Font = New System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.chkEnableNewlayer.Location = New System.Drawing.Point(158, 44)
			Me.chkEnableNewlayer.Name = "chkEnableNewlayer"
			Me.chkEnableNewlayer.Size = New System.Drawing.Size(62, 19)
			Me.chkEnableNewlayer.TabIndex = 10
			Me.chkEnableNewlayer.Text = "Enable"
			Me.chkEnableNewlayer.UseVisualStyleBackColor = True
			' 
			' toolStrip1
			' 
			Me.toolStrip1.AutoSize = False
			Me.toolStrip1.BackColor = System.Drawing.Color.Transparent
			Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.newToolStripButton, Me.toolStripSeparator3})
			Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.Size = New System.Drawing.Size(69, 70)
			Me.toolStrip1.TabIndex = 0
			Me.toolStrip1.Text = "toolStrip1"
			' 
			' newToolStripButton
			' 
			Me.newToolStripButton.AutoSize = False
			Me.newToolStripButton.BackColor = System.Drawing.Color.Transparent
			Me.newToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
			Me.newToolStripButton.Image = (CType(resources.GetObject("newToolStripButton.Image"), System.Drawing.Image))
			Me.newToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
			Me.newToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.newToolStripButton.Name = "newToolStripButton"
			Me.newToolStripButton.Size = New System.Drawing.Size(60, 50)
			Me.newToolStripButton.Text = "New"
			Me.newToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.newToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
'			Me.newToolStripButton.Click += New System.EventHandler(Me.newToolStripButton_Click)
			' 
			' toolStripSeparator3
			' 
			Me.toolStripSeparator3.Name = "toolStripSeparator3"
			Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 70)
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
			' panel2
			' 
			Me.panel2.Controls.Add(Me.paletteGroupBar1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Left
			Me.panel2.Location = New System.Drawing.Point(0, 70)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(214, 608)
			Me.panel2.TabIndex = 1
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
			Me.paletteGroupBar1.Size = New System.Drawing.Size(214, 608)
			Me.paletteGroupBar1.TabIndex = 1
			Me.paletteGroupBar1.Text = "paletteGroupBar1"
			Me.paletteGroupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
			Me.paletteGroupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro
			' 
			' panel3
			' 
			Me.panel3.Controls.Add(Me.diagram1)
			Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel3.Location = New System.Drawing.Point(214, 70)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(993, 608)
			Me.panel3.TabIndex = 2
			' 
			' diagram1
			' 
			Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10F, 10F)
			Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.diagram1.LayoutManager = Nothing
			Me.diagram1.Location = New System.Drawing.Point(0, 0)
			Me.diagram1.MetroScrollBars = True
			Me.diagram1.Model = Me.model1
			Me.diagram1.Name = "diagram1"
			Me.diagram1.ScrollVirtualBounds = (CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF))
			Me.diagram1.Size = New System.Drawing.Size(993, 608)
			Me.diagram1.SmartSizeBox = False
			Me.diagram1.TabIndex = 0
			Me.diagram1.Text = "diagram1"
			' 
			' 
			' 
			Me.diagram1.View.BackgroundColor = System.Drawing.Color.White
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
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1207, 678)
			Me.Controls.Add(Me.panel3)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.panel1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Network Diagram"
			Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.toolStrip2.ResumeLayout(False)
			Me.toolStrip2.PerformLayout()
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
		Private WithEvents createLyr As System.Windows.Forms.Button
		Private toolStrip1 As System.Windows.Forms.ToolStrip
		Private WithEvents newToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
		Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
		Private ImageList As System.Windows.Forms.ImageList
		Private colorDialog1 As System.Windows.Forms.ColorDialog
		Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
		Private chkEnableNewlayer As System.Windows.Forms.CheckBox
		Private txtLayerName As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private WithEvents comboLayers As System.Windows.Forms.ComboBox
		Private label2 As System.Windows.Forms.Label
		Private chkVisibleLyr As System.Windows.Forms.CheckBox
		Private chkEnableLyr As System.Windows.Forms.CheckBox
		Private WithEvents apply As System.Windows.Forms.Button
		Private chkRemoveLyr As System.Windows.Forms.CheckBox
		Private toolStrip2 As System.Windows.Forms.ToolStrip
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private panel2 As System.Windows.Forms.Panel
		Private panel3 As System.Windows.Forms.Panel
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Syncfusion.Windows.Forms.Diagram.Model
		Private paletteGroupBar1 As Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar
	End Class
End Namespace

