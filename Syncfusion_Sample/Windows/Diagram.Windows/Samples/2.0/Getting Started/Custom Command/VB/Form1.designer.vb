Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram
Imports Syncfusion.Windows.Forms
Imports System.Drawing.Drawing2D
Imports System.Drawing

Namespace CustomCommand
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
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
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
			Me.toolStripButton1 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.undoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.redoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.startAtomicActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.endAtomicActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.paletteGroupBar1 = New Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(Me.components)
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
			Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
			Me.panel1.SuspendLayout()
			Me.toolStrip1.SuspendLayout()
			Me.panel2.SuspendLayout()
			CType(Me.paletteGroupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel3.SuspendLayout()
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "palette_groupbar.png")
			Me.imageList1.Images.SetKeyName(3, "property_editor.png")
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.toolStrip1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(842, 30)
			Me.panel1.TabIndex = 0
			' 
			' toolStrip1
			' 
			Me.toolStrip1.BackColor = System.Drawing.Color.Transparent
			Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton1})
			Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.Size = New System.Drawing.Size(842, 30)
			Me.toolStrip1.TabIndex = 0
			Me.toolStrip1.Text = "toolStrip1"
			' 
			' toolStripButton1
			' 
			Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.undoToolStripMenuItem, Me.redoToolStripMenuItem, Me.startAtomicActionToolStripMenuItem, Me.endAtomicActionToolStripMenuItem})
			Me.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
			Me.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton1.Name = "toolStripButton1"
			Me.toolStripButton1.ShowDropDownArrow = False
			Me.toolStripButton1.Size = New System.Drawing.Size(49, 27)
			Me.toolStripButton1.Text = "History"
			Me.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			' 
			' undoToolStripMenuItem
			' 
			Me.undoToolStripMenuItem.Image = (CType(resources.GetObject("undoToolStripMenuItem.Image"), System.Drawing.Image))
			Me.undoToolStripMenuItem.Name = "undoToolStripMenuItem"
			Me.undoToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
			Me.undoToolStripMenuItem.Text = "Undo"
'			Me.undoToolStripMenuItem.Click += New System.EventHandler(Me.undoToolStripMenuItem_Click)
			' 
			' redoToolStripMenuItem
			' 
			Me.redoToolStripMenuItem.Image = (CType(resources.GetObject("redoToolStripMenuItem.Image"), System.Drawing.Image))
			Me.redoToolStripMenuItem.Name = "redoToolStripMenuItem"
			Me.redoToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
			Me.redoToolStripMenuItem.Text = "Redo"
'			Me.redoToolStripMenuItem.Click += New System.EventHandler(Me.redoToolStripMenuItem_Click)
			' 
			' startAtomicActionToolStripMenuItem
			' 
			Me.startAtomicActionToolStripMenuItem.Image = (CType(resources.GetObject("startAtomicActionToolStripMenuItem.Image"), System.Drawing.Image))
			Me.startAtomicActionToolStripMenuItem.Name = "startAtomicActionToolStripMenuItem"
			Me.startAtomicActionToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
			Me.startAtomicActionToolStripMenuItem.Text = "Start Atomic Action"
'			Me.startAtomicActionToolStripMenuItem.Click += New System.EventHandler(Me.startAtomicActionToolStripMenuItem_Click)
			' 
			' endAtomicActionToolStripMenuItem
			' 
			Me.endAtomicActionToolStripMenuItem.Image = (CType(resources.GetObject("endAtomicActionToolStripMenuItem.Image"), System.Drawing.Image))
			Me.endAtomicActionToolStripMenuItem.Name = "endAtomicActionToolStripMenuItem"
			Me.endAtomicActionToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
			Me.endAtomicActionToolStripMenuItem.Text = "End Atomic Action"
'			Me.endAtomicActionToolStripMenuItem.Click += New System.EventHandler(Me.endAtomicActionToolStripMenuItem_Click)
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.paletteGroupBar1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Left
			Me.panel2.Location = New System.Drawing.Point(0, 30)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(210, 437)
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
			Me.paletteGroupBar1.Size = New System.Drawing.Size(210, 437)
			Me.paletteGroupBar1.TabIndex = 1
			Me.paletteGroupBar1.Text = "paletteGroupBar1"
			Me.paletteGroupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
			Me.paletteGroupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro
			' 
			' panel3
			' 
			Me.panel3.Controls.Add(Me.diagram1)
			Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel3.Location = New System.Drawing.Point(210, 30)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(632, 437)
			Me.panel3.TabIndex = 2
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
			Me.diagram1.Size = New System.Drawing.Size(632, 437)
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
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.SystemColors.Control
			Me.ClientSize = New System.Drawing.Size(842, 467)
			Me.Controls.Add(Me.panel3)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.panel1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Custom Command"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
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

		Private imageList1 As ImageList
		Private panel1 As Panel
		Private toolStrip1 As ToolStrip
		Private panel2 As Panel
		Private panel3 As Panel
		Private paletteGroupBar1 As Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Model
		Private toolStripButton1 As ToolStripDropDownButton
		Private WithEvents undoToolStripMenuItem As ToolStripMenuItem
		Private WithEvents redoToolStripMenuItem As ToolStripMenuItem
		Private WithEvents startAtomicActionToolStripMenuItem As ToolStripMenuItem
		Private WithEvents endAtomicActionToolStripMenuItem As ToolStripMenuItem

	End Class
End Namespace