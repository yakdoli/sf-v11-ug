Imports Microsoft.VisualBasic
Imports System
Namespace ExpanderDemo
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
			Me.panel1 = New DemoCommon.Diagram.TitlePanel()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.expanderPanel2 = New DemoCommon.Diagram.Expander()
			Me.bShape = New System.Windows.Forms.Label()
			Me.comboDirection = New System.Windows.Forms.ComboBox()
			Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
			Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
			Me.panel2.SuspendLayout()
			Me.expanderPanel2.SuspendLayout()
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.panel1.ControlBox = False
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Form = Me
			Me.panel1.Location = New System.Drawing.Point(2, 2)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(1179, 70)
			Me.panel1.TabIndex = 0
			Me.panel1.TitleText = "Expander Demo"
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.expanderPanel2)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
			Me.panel2.Location = New System.Drawing.Point(902, 72)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(279, 639)
			Me.panel2.TabIndex = 2
			' 
			' expanderPanel2
			' 
			Me.expanderPanel2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(251))))), (CInt(Fix((CByte(251))))), (CInt(Fix((CByte(251))))))
			Me.expanderPanel2.Caption = "Expander"
			Me.expanderPanel2.Controls.Add(Me.bShape)
			Me.expanderPanel2.Controls.Add(Me.comboDirection)
			Me.expanderPanel2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.expanderPanel2.Location = New System.Drawing.Point(0, 0)
			Me.expanderPanel2.Name = "expanderPanel2"
			Me.expanderPanel2.Padding = New System.Windows.Forms.Padding(10)
			Me.expanderPanel2.Size = New System.Drawing.Size(279, 639)
			Me.expanderPanel2.TabIndex = 1
			' 
			' bShape
			' 
			Me.bShape.AutoSize = True
			Me.bShape.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.bShape.Location = New System.Drawing.Point(13, 55)
			Me.bShape.Name = "bShape"
			Me.bShape.Size = New System.Drawing.Size(91, 15)
			Me.bShape.TabIndex = 3
			Me.bShape.Text = "LayoutDirection"
			' 
			' comboDirection
			' 
			Me.comboDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.comboDirection.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboDirection.FormattingEnabled = True
			Me.comboDirection.Items.AddRange(New Object() { "TopToBottom", "BottomToTop", "LeftToRight", "RightToLeft"})
			Me.comboDirection.Location = New System.Drawing.Point(151, 52)
			Me.comboDirection.Name = "comboDirection"
			Me.comboDirection.Size = New System.Drawing.Size(104, 21)
			Me.comboDirection.TabIndex = 2
			' 
			' diagram1
			' 
			Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10F, 10F)
			Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.diagram1.HScroll = True
			Me.diagram1.LayoutManager = Nothing
			Me.diagram1.Location = New System.Drawing.Point(2, 72)
			Me.diagram1.MetroScrollBars = True
			Me.diagram1.Model = Me.model1
			Me.diagram1.Name = "diagram1"
			Me.diagram1.ScrollVirtualBounds = (CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF))
			Me.diagram1.Size = New System.Drawing.Size(900, 639)
			Me.diagram1.SmartSizeBox = False
			Me.diagram1.TabIndex = 2
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
			Me.model1.DocumentSize.Width = 1000F
			Me.model1.LineStyle.DashPattern = Nothing
			Me.model1.LineStyle.LineColor = System.Drawing.Color.LightGray
			Me.model1.LogicalSize = New System.Drawing.SizeF(1000F, 1169F)
			Me.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))))
			Me.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))), (CInt(Fix((CByte(105))))))
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1183, 713)
			Me.Controls.Add(Me.diagram1)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.panel1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Expander"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.panel2.ResumeLayout(False)
			Me.expanderPanel2.ResumeLayout(False)
			Me.expanderPanel2.PerformLayout()
			CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panel1 As DemoCommon.Diagram.TitlePanel
		Private panel2 As System.Windows.Forms.Panel
		Private expanderPanel2 As DemoCommon.Diagram.Expander
		Private comboDirection As System.Windows.Forms.ComboBox
		Private bShape As System.Windows.Forms.Label
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Syncfusion.Windows.Forms.Diagram.Model

	End Class
End Namespace

