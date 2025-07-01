Imports Microsoft.VisualBasic
Imports System
Namespace OrgChartLayout
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
            Me.panel1 = New DemoCommon.Diagram.TitlePanel
            Me.panel2 = New System.Windows.Forms.Panel
            Me.expanderPanel2 = New DemoCommon.Diagram.Expander
            Me.bShape = New System.Windows.Forms.Label
            Me.expSymShapeLbl = New System.Windows.Forms.Label
            Me.comboBShape = New System.Windows.Forms.ComboBox
            Me.comboExpSymbol = New System.Windows.Forms.ComboBox
            Me.expanderPanel1 = New DemoCommon.Diagram.Expander
            Me.label1 = New System.Windows.Forms.Label
            Me.vSpacing = New System.Windows.Forms.Label
            Me.hSpacing = New System.Windows.Forms.Label
            Me.apply = New System.Windows.Forms.Button
            Me.txtHSpacing = New System.Windows.Forms.TextBox
            Me.chkAutoLayout = New System.Windows.Forms.CheckBox
            Me.txtVSpacing = New System.Windows.Forms.TextBox
            Me.txtTMarigin = New System.Windows.Forms.TextBox
            Me.lMarigin = New System.Windows.Forms.Label
            Me.tMarigin = New System.Windows.Forms.Label
            Me.txtLMarigin = New System.Windows.Forms.TextBox
            Me.lytTypLbl = New System.Windows.Forms.Label
            Me.comboLytType = New System.Windows.Forms.ComboBox
            Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
            Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
            Me.panel2.SuspendLayout()
            Me.expanderPanel2.SuspendLayout()
            Me.expanderPanel1.SuspendLayout()
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.panel1.ControlBox = False
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Form = Me
            Me.panel1.Location = New System.Drawing.Point(3, 2)
            Me.panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1810, 86)
            Me.panel1.TabIndex = 0
            Me.panel1.TitleText = "Org Chart Layout"
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.expanderPanel2)
            Me.panel2.Controls.Add(Me.expanderPanel1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel2.Location = New System.Drawing.Point(1441, 88)
            Me.panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(372, 788)
            Me.panel2.TabIndex = 2
            '
            'expanderPanel2
            '
            Me.expanderPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.expanderPanel2.Caption = "Expander"
            Me.expanderPanel2.Controls.Add(Me.bShape)
            Me.expanderPanel2.Controls.Add(Me.expSymShapeLbl)
            Me.expanderPanel2.Controls.Add(Me.comboBShape)
            Me.expanderPanel2.Controls.Add(Me.comboExpSymbol)
            Me.expanderPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.expanderPanel2.Location = New System.Drawing.Point(0, 423)
            Me.expanderPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.expanderPanel2.Name = "expanderPanel2"
            Me.expanderPanel2.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
            Me.expanderPanel2.Size = New System.Drawing.Size(372, 365)
            Me.expanderPanel2.TabIndex = 1
            '
            'bShape
            '
            Me.bShape.AutoSize = True
            Me.bShape.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.bShape.Location = New System.Drawing.Point(17, 68)
            Me.bShape.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.bShape.Name = "bShape"
            Me.bShape.Size = New System.Drawing.Size(133, 20)
            Me.bShape.TabIndex = 3
            Me.bShape.Text = "Background Shape"
            '
            'expSymShapeLbl
            '
            Me.expSymShapeLbl.AutoSize = True
            Me.expSymShapeLbl.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.expSymShapeLbl.Location = New System.Drawing.Point(17, 112)
            Me.expSymShapeLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.expSymShapeLbl.Name = "expSymShapeLbl"
            Me.expSymShapeLbl.Size = New System.Drawing.Size(104, 20)
            Me.expSymShapeLbl.TabIndex = 5
            Me.expSymShapeLbl.Text = "Symbol Shape"
            '
            'comboBShape
            '
            Me.comboBShape.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBShape.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboBShape.FormattingEnabled = True
            Me.comboBShape.Items.AddRange(New Object() {"Rectangle", "Ellipse"})
            Me.comboBShape.Location = New System.Drawing.Point(201, 64)
            Me.comboBShape.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBShape.Name = "comboBShape"
            Me.comboBShape.Size = New System.Drawing.Size(137, 28)
            Me.comboBShape.TabIndex = 2
            '
            'comboExpSymbol
            '
            Me.comboExpSymbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboExpSymbol.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboExpSymbol.FormattingEnabled = True
            Me.comboExpSymbol.Items.AddRange(New Object() {"Triangle", "PlusMinus"})
            Me.comboExpSymbol.Location = New System.Drawing.Point(201, 108)
            Me.comboExpSymbol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboExpSymbol.Name = "comboExpSymbol"
            Me.comboExpSymbol.Size = New System.Drawing.Size(137, 28)
            Me.comboExpSymbol.TabIndex = 4
            '
            'expanderPanel1
            '
            Me.expanderPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.expanderPanel1.Caption = "Properties"
            Me.expanderPanel1.Controls.Add(Me.label1)
            Me.expanderPanel1.Controls.Add(Me.vSpacing)
            Me.expanderPanel1.Controls.Add(Me.hSpacing)
            Me.expanderPanel1.Controls.Add(Me.apply)
            Me.expanderPanel1.Controls.Add(Me.txtHSpacing)
            Me.expanderPanel1.Controls.Add(Me.chkAutoLayout)
            Me.expanderPanel1.Controls.Add(Me.txtVSpacing)
            Me.expanderPanel1.Controls.Add(Me.txtTMarigin)
            Me.expanderPanel1.Controls.Add(Me.lMarigin)
            Me.expanderPanel1.Controls.Add(Me.tMarigin)
            Me.expanderPanel1.Controls.Add(Me.txtLMarigin)
            Me.expanderPanel1.Controls.Add(Me.lytTypLbl)
            Me.expanderPanel1.Controls.Add(Me.comboLytType)
            Me.expanderPanel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.expanderPanel1.Location = New System.Drawing.Point(0, 0)
            Me.expanderPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.expanderPanel1.Name = "expanderPanel1"
            Me.expanderPanel1.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
            Me.expanderPanel1.Size = New System.Drawing.Size(372, 423)
            Me.expanderPanel1.TabIndex = 0
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(17, 311)
            Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(89, 20)
            Me.label1.TabIndex = 45
            Me.label1.Text = "Auto Layout"
            '
            'vSpacing
            '
            Me.vSpacing.AutoSize = True
            Me.vSpacing.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.vSpacing.Location = New System.Drawing.Point(17, 164)
            Me.vSpacing.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.vSpacing.Name = "vSpacing"
            Me.vSpacing.Size = New System.Drawing.Size(116, 20)
            Me.vSpacing.TabIndex = 37
            Me.vSpacing.Text = "Vertical Spacing"
            '
            'hSpacing
            '
            Me.hSpacing.AutoSize = True
            Me.hSpacing.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.hSpacing.Location = New System.Drawing.Point(17, 114)
            Me.hSpacing.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.hSpacing.Name = "hSpacing"
            Me.hSpacing.Size = New System.Drawing.Size(136, 20)
            Me.hSpacing.TabIndex = 36
            Me.hSpacing.Text = "Horizontal Spacing"
            '
            'apply
            '
            Me.apply.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.apply.FlatAppearance.BorderSize = 0
            Me.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.apply.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.apply.ForeColor = System.Drawing.Color.White
            Me.apply.Location = New System.Drawing.Point(145, 361)
            Me.apply.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.apply.Name = "apply"
            Me.apply.Size = New System.Drawing.Size(107, 37)
            Me.apply.TabIndex = 46
            Me.apply.Text = "Apply"
            Me.apply.UseVisualStyleBackColor = False
            '
            'txtHSpacing
            '
            Me.txtHSpacing.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtHSpacing.Location = New System.Drawing.Point(192, 112)
            Me.txtHSpacing.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtHSpacing.Name = "txtHSpacing"
            Me.txtHSpacing.Size = New System.Drawing.Size(145, 27)
            Me.txtHSpacing.TabIndex = 38
            '
            'chkAutoLayout
            '
            Me.chkAutoLayout.AutoSize = True
            Me.chkAutoLayout.FlatAppearance.BorderSize = 0
            Me.chkAutoLayout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkAutoLayout.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkAutoLayout.Location = New System.Drawing.Point(192, 314)
            Me.chkAutoLayout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.chkAutoLayout.Name = "chkAutoLayout"
            Me.chkAutoLayout.Size = New System.Drawing.Size(12, 11)
            Me.chkAutoLayout.TabIndex = 44
            Me.chkAutoLayout.UseVisualStyleBackColor = True
            '
            'txtVSpacing
            '
            Me.txtVSpacing.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtVSpacing.Location = New System.Drawing.Point(192, 161)
            Me.txtVSpacing.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtVSpacing.Name = "txtVSpacing"
            Me.txtVSpacing.Size = New System.Drawing.Size(145, 27)
            Me.txtVSpacing.TabIndex = 39
            '
            'txtTMarigin
            '
            Me.txtTMarigin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTMarigin.Location = New System.Drawing.Point(192, 260)
            Me.txtTMarigin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtTMarigin.Name = "txtTMarigin"
            Me.txtTMarigin.Size = New System.Drawing.Size(145, 27)
            Me.txtTMarigin.TabIndex = 43
            '
            'lMarigin
            '
            Me.lMarigin.AutoSize = True
            Me.lMarigin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lMarigin.Location = New System.Drawing.Point(17, 213)
            Me.lMarigin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lMarigin.Name = "lMarigin"
            Me.lMarigin.Size = New System.Drawing.Size(89, 20)
            Me.lMarigin.TabIndex = 40
            Me.lMarigin.Text = "Left Marigin"
            '
            'tMarigin
            '
            Me.tMarigin.AutoSize = True
            Me.tMarigin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tMarigin.Location = New System.Drawing.Point(17, 262)
            Me.tMarigin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.tMarigin.Name = "tMarigin"
            Me.tMarigin.Size = New System.Drawing.Size(90, 20)
            Me.tMarigin.TabIndex = 41
            Me.tMarigin.Text = "Top Marigin"
            '
            'txtLMarigin
            '
            Me.txtLMarigin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtLMarigin.Location = New System.Drawing.Point(192, 210)
            Me.txtLMarigin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtLMarigin.Name = "txtLMarigin"
            Me.txtLMarigin.Size = New System.Drawing.Size(145, 27)
            Me.txtLMarigin.TabIndex = 42
            '
            'lytTypLbl
            '
            Me.lytTypLbl.AutoSize = True
            Me.lytTypLbl.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lytTypLbl.Location = New System.Drawing.Point(17, 65)
            Me.lytTypLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lytTypLbl.Name = "lytTypLbl"
            Me.lytTypLbl.Size = New System.Drawing.Size(89, 20)
            Me.lytTypLbl.TabIndex = 35
            Me.lytTypLbl.Text = "Layout Type"
            '
            'comboLytType
            '
            Me.comboLytType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboLytType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboLytType.FormattingEnabled = True
            Me.comboLytType.Items.AddRange(New Object() {"WaterFall", "Horizontal"})
            Me.comboLytType.Location = New System.Drawing.Point(192, 63)
            Me.comboLytType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboLytType.Name = "comboLytType"
            Me.comboLytType.Size = New System.Drawing.Size(145, 28)
            Me.comboLytType.TabIndex = 34
            '
            'diagram1
            '
            Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10.0!, 10.0!)
            Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagram1.HScroll = True
            Me.diagram1.LayoutManager = Nothing
            Me.diagram1.Location = New System.Drawing.Point(3, 88)
            Me.diagram1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.diagram1.MetroScrollBars = True
            Me.diagram1.Model = Me.model1
            Me.diagram1.Name = "diagram1"
            Me.diagram1.ScrollVirtualBounds = CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF)
            Me.diagram1.Size = New System.Drawing.Size(1438, 788)
            Me.diagram1.SmartSizeBox = False
            Me.diagram1.TabIndex = 2
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
            Me.diagram1.VScroll = True
            '
            'model1
            '
            Me.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
            Me.model1.DocumentScale.DisplayName = "No Scale"
            Me.model1.DocumentScale.Height = 1.0!
            Me.model1.DocumentScale.Width = 1.0!
            Me.model1.DocumentSize.Height = 1169.0!
            Me.model1.DocumentSize.Width = 1227.0!
            Me.model1.LineStyle.DashPattern = Nothing
            Me.model1.LineStyle.LineColor = System.Drawing.Color.Black
            Me.model1.LineStyle.LineWidth = 0.0!
            Me.model1.LogicalSize = New System.Drawing.SizeF(1227.0!, 1169.0!)
            Me.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1816, 878)
            Me.Controls.Add(Me.diagram1)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "Form1"
            Me.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "OrgChartLayout"
            Me.panel2.ResumeLayout(False)
            Me.expanderPanel2.ResumeLayout(False)
            Me.expanderPanel2.PerformLayout()
            Me.expanderPanel1.ResumeLayout(False)
            Me.expanderPanel1.PerformLayout()
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private panel1 As DemoCommon.Diagram.TitlePanel
		Private panel2 As System.Windows.Forms.Panel
		Private expanderPanel2 As DemoCommon.Diagram.Expander
		Private expSymShapeLbl As System.Windows.Forms.Label
		Private comboBShape As System.Windows.Forms.ComboBox
		Private bShape As System.Windows.Forms.Label
		Private comboExpSymbol As System.Windows.Forms.ComboBox
		Private expanderPanel1 As DemoCommon.Diagram.Expander
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Syncfusion.Windows.Forms.Diagram.Model
		Private label1 As System.Windows.Forms.Label
		Private vSpacing As System.Windows.Forms.Label
		Private hSpacing As System.Windows.Forms.Label
		Private apply As System.Windows.Forms.Button
		Private txtHSpacing As System.Windows.Forms.TextBox
		Private chkAutoLayout As System.Windows.Forms.CheckBox
		Private txtVSpacing As System.Windows.Forms.TextBox
		Private txtTMarigin As System.Windows.Forms.TextBox
		Private lMarigin As System.Windows.Forms.Label
		Private tMarigin As System.Windows.Forms.Label
		Private txtLMarigin As System.Windows.Forms.TextBox
		Private lytTypLbl As System.Windows.Forms.Label
		Private comboLytType As System.Windows.Forms.ComboBox

	End Class
End Namespace

