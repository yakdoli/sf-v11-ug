Imports Microsoft.VisualBasic
Imports System
Namespace DiagramEvents
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
			Me.clear = New System.Windows.Forms.Button()
			Me.panel2 = New DemoCommon.Diagram.Expander()
			Me.listBox1 = New System.Windows.Forms.ListBox()
			Me.paletteGroupBar1 = New Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar(Me.components)
			Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
			Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
			Me.panel2.SuspendLayout()
			CType(Me.paletteGroupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' clear
			' 
			Me.clear.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.clear.FlatAppearance.BorderSize = 0
			Me.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.clear.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.clear.ForeColor = System.Drawing.Color.White
			Me.clear.Location = New System.Drawing.Point(115, 258)
			Me.clear.Name = "clear"
			Me.clear.Size = New System.Drawing.Size(57, 28)
			Me.clear.TabIndex = 57
			Me.clear.Text = "Clear"
			Me.clear.UseVisualStyleBackColor = False
'			Me.clear.Click += New System.EventHandler(Me.clear_Click)
			' 
			' panel2
			' 
			Me.panel2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(251))))), (CInt(Fix((CByte(251))))), (CInt(Fix((CByte(251))))))
			Me.panel2.Caption = "Properties"
			Me.panel2.Controls.Add(Me.clear)
			Me.panel2.Controls.Add(Me.listBox1)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
			Me.panel2.Location = New System.Drawing.Point(649, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Padding = New System.Windows.Forms.Padding(10)
			Me.panel2.Size = New System.Drawing.Size(255, 555)
			Me.panel2.TabIndex = 1
			' 
			' listBox1
			' 
			Me.listBox1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.listBox1.FormattingEnabled = True
			Me.listBox1.ItemHeight = 15
			Me.listBox1.Location = New System.Drawing.Point(13, 38)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(242, 214)
			Me.listBox1.TabIndex = 0
			' 
			' paletteGroupBar1
			' 
			Me.paletteGroupBar1.AllowDrop = True
			Me.paletteGroupBar1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235))))))
			Me.paletteGroupBar1.BorderColor = System.Drawing.Color.White
			Me.paletteGroupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.paletteGroupBar1.Diagram = Nothing
			Me.paletteGroupBar1.Dock = System.Windows.Forms.DockStyle.Left
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
			Me.paletteGroupBar1.Size = New System.Drawing.Size(207, 555)
			Me.paletteGroupBar1.TabIndex = 1
			Me.paletteGroupBar1.Text = "paletteGroupBar1"
			Me.paletteGroupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
			Me.paletteGroupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro
			' 
			' diagram1
			' 
			Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10F, 10F)
			Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.diagram1.LayoutManager = Nothing
			Me.diagram1.Location = New System.Drawing.Point(207, 0)
			Me.diagram1.MetroScrollBars = True
			Me.diagram1.Model = Me.model1
			Me.diagram1.Name = "diagram1"
			Me.diagram1.ScrollVirtualBounds = (CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF))
			Me.diagram1.Size = New System.Drawing.Size(442, 555)
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
			Me.ClientSize = New System.Drawing.Size(904, 555)
			Me.Controls.Add(Me.diagram1)
			Me.Controls.Add(Me.paletteGroupBar1)
			Me.Controls.Add(Me.panel2)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Diagram Events"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
'			Me.Activated += New System.EventHandler(Me.MainForm_Activated)
			Me.panel2.ResumeLayout(False)
			CType(Me.paletteGroupBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents clear As System.Windows.Forms.Button
		Private panel2 As DemoCommon.Diagram.Expander
		Private listBox1 As System.Windows.Forms.ListBox
		Private paletteGroupBar1 As Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Syncfusion.Windows.Forms.Diagram.Model

	End Class

End Namespace

