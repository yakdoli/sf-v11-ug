Imports Microsoft.VisualBasic
Imports System
Namespace DirectedTreeLayout
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
            Me.panel3 = New DemoCommon.Diagram.TitlePanel
            Me.panel1 = New DemoCommon.Diagram.Expander
            Me.comboLytDirection = New System.Windows.Forms.ComboBox
            Me.label2 = New System.Windows.Forms.Label
            Me.apply = New System.Windows.Forms.Button
            Me.label1 = New System.Windows.Forms.Label
            Me.lytProp = New System.Windows.Forms.Label
            Me.chkAutoLayout = New System.Windows.Forms.CheckBox
            Me.txtTMarigin = New System.Windows.Forms.TextBox
            Me.txtLMarigin = New System.Windows.Forms.TextBox
            Me.tMarigin = New System.Windows.Forms.Label
            Me.lMarigin = New System.Windows.Forms.Label
            Me.txtVSpacing = New System.Windows.Forms.TextBox
            Me.txtHSpacing = New System.Windows.Forms.TextBox
            Me.vSpacing = New System.Windows.Forms.Label
            Me.hSpacing = New System.Windows.Forms.Label
            Me.panel2 = New System.Windows.Forms.Panel
            Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
            Me.model2 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
            Me.panel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.model2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel3
            '
            Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.panel3.ControlBox = False
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel3.Form = Me
            Me.panel3.Location = New System.Drawing.Point(3, 2)
            Me.panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(1793, 86)
            Me.panel3.TabIndex = 7
            Me.panel3.TitleText = "Directed Tree Layout"
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.panel1.Caption = "Properties"
            Me.panel1.Controls.Add(Me.comboLytDirection)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.apply)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.lytProp)
            Me.panel1.Controls.Add(Me.chkAutoLayout)
            Me.panel1.Controls.Add(Me.txtTMarigin)
            Me.panel1.Controls.Add(Me.txtLMarigin)
            Me.panel1.Controls.Add(Me.tMarigin)
            Me.panel1.Controls.Add(Me.lMarigin)
            Me.panel1.Controls.Add(Me.txtVSpacing)
            Me.panel1.Controls.Add(Me.txtHSpacing)
            Me.panel1.Controls.Add(Me.vSpacing)
            Me.panel1.Controls.Add(Me.hSpacing)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(1419, 88)
            Me.panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel1.Name = "panel1"
            Me.panel1.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
            Me.panel1.Size = New System.Drawing.Size(377, 789)
            Me.panel1.TabIndex = 8
            '
            'comboLytDirection
            '
            Me.comboLytDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboLytDirection.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboLytDirection.FormattingEnabled = True
            Me.comboLytDirection.Items.AddRange(New Object() {"TopToBottom", "TopRight", "TopLeft", "RightToLeft", "LeftToRight", "BottomToTop", "BottomLeft", "BottomRight"})
            Me.comboLytDirection.Location = New System.Drawing.Point(237, 303)
            Me.comboLytDirection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboLytDirection.Name = "comboLytDirection"
            Me.comboLytDirection.Size = New System.Drawing.Size(132, 28)
            Me.comboLytDirection.TabIndex = 35
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(17, 305)
            Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(135, 20)
            Me.label2.TabIndex = 34
            Me.label2.Text = "Direction Selection"
            '
            'apply
            '
            Me.apply.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.apply.FlatAppearance.BorderSize = 0
            Me.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.apply.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.apply.ForeColor = System.Drawing.Color.White
            Me.apply.Location = New System.Drawing.Point(140, 354)
            Me.apply.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.apply.Name = "apply"
            Me.apply.Size = New System.Drawing.Size(107, 37)
            Me.apply.TabIndex = 33
            Me.apply.Text = "Apply"
            Me.apply.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(17, 254)
            Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(89, 20)
            Me.label1.TabIndex = 31
            Me.label1.Text = "Auto Layout"
            '
            'lytProp
            '
            Me.lytProp.AutoEllipsis = True
            Me.lytProp.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.lytProp.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lytProp.Location = New System.Drawing.Point(67, 11)
            Me.lytProp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lytProp.Name = "lytProp"
            Me.lytProp.Size = New System.Drawing.Size(199, 25)
            Me.lytProp.TabIndex = 29
            Me.lytProp.Text = "Properties"
            '
            'chkAutoLayout
            '
            Me.chkAutoLayout.FlatAppearance.BorderSize = 0
            Me.chkAutoLayout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkAutoLayout.Font = New System.Drawing.Font("Arial", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkAutoLayout.Location = New System.Drawing.Point(237, 236)
            Me.chkAutoLayout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.chkAutoLayout.Name = "chkAutoLayout"
            Me.chkAutoLayout.Size = New System.Drawing.Size(21, 41)
            Me.chkAutoLayout.TabIndex = 28
            Me.chkAutoLayout.UseVisualStyleBackColor = True
            '
            'txtTMarigin
            '
            Me.txtTMarigin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTMarigin.Location = New System.Drawing.Point(237, 198)
            Me.txtTMarigin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtTMarigin.Name = "txtTMarigin"
            Me.txtTMarigin.Size = New System.Drawing.Size(132, 27)
            Me.txtTMarigin.TabIndex = 27
            '
            'txtLMarigin
            '
            Me.txtLMarigin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtLMarigin.Location = New System.Drawing.Point(237, 150)
            Me.txtLMarigin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtLMarigin.Name = "txtLMarigin"
            Me.txtLMarigin.Size = New System.Drawing.Size(132, 27)
            Me.txtLMarigin.TabIndex = 26
            '
            'tMarigin
            '
            Me.tMarigin.AutoSize = True
            Me.tMarigin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tMarigin.Location = New System.Drawing.Point(17, 201)
            Me.tMarigin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.tMarigin.Name = "tMarigin"
            Me.tMarigin.Size = New System.Drawing.Size(90, 20)
            Me.tMarigin.TabIndex = 25
            Me.tMarigin.Text = "Top Marigin"
            '
            'lMarigin
            '
            Me.lMarigin.AutoSize = True
            Me.lMarigin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lMarigin.Location = New System.Drawing.Point(17, 150)
            Me.lMarigin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lMarigin.Name = "lMarigin"
            Me.lMarigin.Size = New System.Drawing.Size(89, 20)
            Me.lMarigin.TabIndex = 24
            Me.lMarigin.Text = "Left Marigin"
            '
            'txtVSpacing
            '
            Me.txtVSpacing.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtVSpacing.Location = New System.Drawing.Point(237, 110)
            Me.txtVSpacing.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtVSpacing.Name = "txtVSpacing"
            Me.txtVSpacing.Size = New System.Drawing.Size(132, 27)
            Me.txtVSpacing.TabIndex = 23
            '
            'txtHSpacing
            '
            Me.txtHSpacing.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtHSpacing.Location = New System.Drawing.Point(237, 69)
            Me.txtHSpacing.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtHSpacing.Name = "txtHSpacing"
            Me.txtHSpacing.Size = New System.Drawing.Size(132, 27)
            Me.txtHSpacing.TabIndex = 22
            '
            'vSpacing
            '
            Me.vSpacing.AutoSize = True
            Me.vSpacing.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.vSpacing.Location = New System.Drawing.Point(17, 112)
            Me.vSpacing.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.vSpacing.Name = "vSpacing"
            Me.vSpacing.Size = New System.Drawing.Size(116, 20)
            Me.vSpacing.TabIndex = 21
            Me.vSpacing.Text = "Vertical Spacing"
            '
            'hSpacing
            '
            Me.hSpacing.AutoSize = True
            Me.hSpacing.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.hSpacing.Location = New System.Drawing.Point(17, 71)
            Me.hSpacing.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.hSpacing.Name = "hSpacing"
            Me.hSpacing.Size = New System.Drawing.Size(136, 20)
            Me.hSpacing.TabIndex = 20
            Me.hSpacing.Text = "Horizontal Spacing"
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.diagram1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel2.Location = New System.Drawing.Point(3, 88)
            Me.panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(1416, 789)
            Me.panel2.TabIndex = 9
            '
            'diagram1
            '
            Me.diagram1.Controller.PasteOffset = New System.Drawing.SizeF(10.0!, 10.0!)
            Me.diagram1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.diagram1.HScroll = True
            Me.diagram1.LayoutManager = Nothing
            Me.diagram1.Location = New System.Drawing.Point(0, 0)
            Me.diagram1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.diagram1.MetroScrollBars = True
            Me.diagram1.Model = Me.model2
            Me.diagram1.Name = "diagram1"
            Me.diagram1.ScrollVirtualBounds = CType(resources.GetObject("diagram1.ScrollVirtualBounds"), System.Drawing.RectangleF)
            Me.diagram1.Size = New System.Drawing.Size(1416, 789)
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
            Me.diagram1.VScroll = True
            '
            'model2
            '
            Me.model2.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
            Me.model2.DocumentScale.DisplayName = "No Scale"
            Me.model2.DocumentScale.Height = 1.0!
            Me.model2.DocumentScale.Width = 1.0!
            Me.model2.DocumentSize.Height = 1169.0!
            Me.model2.DocumentSize.Width = 1227.0!
            Me.model2.LineStyle.DashPattern = Nothing
            Me.model2.LineStyle.LineColor = System.Drawing.Color.Black
            Me.model2.LineStyle.LineWidth = 0.0!
            Me.model2.LogicalSize = New System.Drawing.SizeF(1227.0!, 1169.0!)
            Me.model2.ShadowStyle.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.model2.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1799, 879)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.panel3)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "Form1"
            Me.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Directed Tree Layout"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.panel2.ResumeLayout(False)
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.model2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private panel3 As DemoCommon.Diagram.TitlePanel
		Private panel1 As DemoCommon.Diagram.Expander
		Private label1 As System.Windows.Forms.Label
		Private lytProp As System.Windows.Forms.Label
		Private chkAutoLayout As System.Windows.Forms.CheckBox
		Private txtTMarigin As System.Windows.Forms.TextBox
		Private txtLMarigin As System.Windows.Forms.TextBox
		Private tMarigin As System.Windows.Forms.Label
		Private lMarigin As System.Windows.Forms.Label
		Private txtVSpacing As System.Windows.Forms.TextBox
		Private txtHSpacing As System.Windows.Forms.TextBox
		Private vSpacing As System.Windows.Forms.Label
		Private hSpacing As System.Windows.Forms.Label
		Private panel2 As System.Windows.Forms.Panel
		Private WithEvents apply As System.Windows.Forms.Button
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model2 As Syncfusion.Windows.Forms.Diagram.Model
		Private comboLytDirection As System.Windows.Forms.ComboBox
		Private label2 As System.Windows.Forms.Label
	End Class

End Namespace

