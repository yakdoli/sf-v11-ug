Imports Microsoft.VisualBasic
Imports System
Namespace Serialization
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
			Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
			Me.newToolStripButton = New System.Windows.Forms.ToolStripButton()
			Me.openToolStripButton = New System.Windows.Forms.ToolStripButton()
			Me.saveToolStripButton = New System.Windows.Forms.ToolStripButton()
			Me.saveAsToolStripButton = New System.Windows.Forms.ToolStripButton()
			Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
			Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
			Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.paletteGroupBar1 = New Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(Me.components)
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.propertyEditor1 = New Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor(Me.components)
			Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
			Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
			Me.panel4 = New System.Windows.Forms.Panel()
			Me.panel1.SuspendLayout()
			Me.toolStrip1.SuspendLayout()
			Me.panel2.SuspendLayout()
			CType(Me.paletteGroupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel3.SuspendLayout()
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel4.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(237))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(240))))))
			Me.panel1.Controls.Add(Me.toolStrip1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(1003, 61)
			Me.panel1.TabIndex = 0
			' 
			' toolStrip1
			' 
			Me.toolStrip1.AutoSize = False
			Me.toolStrip1.BackColor = System.Drawing.Color.Transparent
			Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.newToolStripButton, Me.openToolStripButton, Me.saveToolStripButton, Me.saveAsToolStripButton})
			Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.Size = New System.Drawing.Size(1003, 61)
			Me.toolStrip1.TabIndex = 0
			Me.toolStrip1.Text = "toolStrip1"
			' 
			' newToolStripButton
			' 
			Me.newToolStripButton.AutoSize = False
			Me.newToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
			Me.newToolStripButton.Image = (CType(resources.GetObject("newToolStripButton.Image"), System.Drawing.Image))
			Me.newToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
			Me.newToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.newToolStripButton.Name = "newToolStripButton"
			Me.newToolStripButton.Size = New System.Drawing.Size(70, 60)
			Me.newToolStripButton.Text = "New"
			Me.newToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.newToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
'			Me.newToolStripButton.Click += New System.EventHandler(Me.newToolStripButton_Click_1)
			' 
			' openToolStripButton
			' 
			Me.openToolStripButton.AutoSize = False
			Me.openToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
			Me.openToolStripButton.Image = (CType(resources.GetObject("openToolStripButton.Image"), System.Drawing.Image))
			Me.openToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
			Me.openToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.openToolStripButton.Name = "openToolStripButton"
			Me.openToolStripButton.Size = New System.Drawing.Size(70, 60)
			Me.openToolStripButton.Text = "Open"
			Me.openToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.openToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
'			Me.openToolStripButton.Click += New System.EventHandler(Me.openToolStripButton_Click_1)
			' 
			' saveToolStripButton
			' 
			Me.saveToolStripButton.AutoSize = False
			Me.saveToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
			Me.saveToolStripButton.Image = (CType(resources.GetObject("saveToolStripButton.Image"), System.Drawing.Image))
			Me.saveToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
			Me.saveToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.saveToolStripButton.Name = "saveToolStripButton"
			Me.saveToolStripButton.Size = New System.Drawing.Size(70, 60)
			Me.saveToolStripButton.Text = "Save"
			Me.saveToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.saveToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
'			Me.saveToolStripButton.Click += New System.EventHandler(Me.saveToolStripButton_Click)
			' 
			' saveAsToolStripButton
			' 
			Me.saveAsToolStripButton.AutoSize = False
			Me.saveAsToolStripButton.Image = (CType(resources.GetObject("saveAsToolStripButton.Image"), System.Drawing.Image))
			Me.saveAsToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
			Me.saveAsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.saveAsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.saveAsToolStripButton.Name = "saveAsToolStripButton"
			Me.saveAsToolStripButton.Size = New System.Drawing.Size(70, 60)
			Me.saveAsToolStripButton.Text = "Save As"
			Me.saveAsToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.saveAsToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
'			Me.saveAsToolStripButton.Click += New System.EventHandler(Me.saveAsToolStripButton_Click)
			' 
			' openFileDialog1
			' 
			Me.openFileDialog1.FileName = "openFileDialog1"
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.paletteGroupBar1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Left
			Me.panel2.Location = New System.Drawing.Point(0, 61)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(211, 479)
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
			Me.paletteGroupBar1.Size = New System.Drawing.Size(211, 479)
			Me.paletteGroupBar1.TabIndex = 1
			Me.paletteGroupBar1.Text = "paletteGroupBar1"
			Me.paletteGroupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
			Me.paletteGroupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro
			' 
			' panel3
			' 
			Me.panel3.Controls.Add(Me.propertyEditor1)
			Me.panel3.Dock = System.Windows.Forms.DockStyle.Right
			Me.panel3.Location = New System.Drawing.Point(752, 61)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(251, 479)
			Me.panel3.TabIndex = 2
			' 
			' propertyEditor1
			' 
			Me.propertyEditor1.Diagram = Me.diagram1
			Me.propertyEditor1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyEditor1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.propertyEditor1.Location = New System.Drawing.Point(0, 0)
			Me.propertyEditor1.Name = "propertyEditor1"
			Me.propertyEditor1.Size = New System.Drawing.Size(251, 479)
			Me.propertyEditor1.TabIndex = 0
			' 
			' diagram1
			' 
			Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10F, 10F)
			Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.diagram1.HScroll = True
			Me.diagram1.LayoutManager = Nothing
			Me.diagram1.Location = New System.Drawing.Point(0, 0)
			Me.diagram1.MetroScrollBars = True
			Me.diagram1.Model = Me.model1
			Me.diagram1.Name = "diagram1"
			Me.diagram1.ScrollVirtualBounds = (CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF))
			Me.diagram1.Size = New System.Drawing.Size(541, 479)
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
			Me.diagram1.VScroll = True
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
			' panel4
			' 
			Me.panel4.Controls.Add(Me.diagram1)
			Me.panel4.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel4.Location = New System.Drawing.Point(211, 61)
			Me.panel4.Name = "panel4"
			Me.panel4.Size = New System.Drawing.Size(541, 479)
			Me.panel4.TabIndex = 3
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1003, 540)
			Me.Controls.Add(Me.panel4)
			Me.Controls.Add(Me.panel3)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.panel1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Serialization"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.panel1.ResumeLayout(False)
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.panel2.ResumeLayout(False)
			CType(Me.paletteGroupBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel3.ResumeLayout(False)
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel4.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panel1 As System.Windows.Forms.Panel
		Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
		Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
		Private colorDialog1 As System.Windows.Forms.ColorDialog
		Private toolStrip1 As System.Windows.Forms.ToolStrip
		Private WithEvents saveToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents saveAsToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents newToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents openToolStripButton As System.Windows.Forms.ToolStripButton
		Private panel2 As System.Windows.Forms.Panel
		Private paletteGroupBar1 As Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar
		Private panel3 As System.Windows.Forms.Panel
		Private panel4 As System.Windows.Forms.Panel
		Private propertyEditor1 As Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Syncfusion.Windows.Forms.Diagram.Model
	End Class
End Namespace

