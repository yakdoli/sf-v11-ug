Imports Microsoft.VisualBasic
Imports System
Namespace SubGraphLayout
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
            Me.panel2 = New DemoCommon.Diagram.Expander
            Me.label2 = New System.Windows.Forms.Label
            Me.lMarigin = New System.Windows.Forms.Label
            Me.comboLytDirection = New System.Windows.Forms.ComboBox
            Me.vSpacing = New System.Windows.Forms.Label
            Me.txtVSpacing = New System.Windows.Forms.TextBox
            Me.hSpacing = New System.Windows.Forms.Label
            Me.txtHSpacing = New System.Windows.Forms.TextBox
            Me.tMarigin = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.apply = New System.Windows.Forms.Button
            Me.txtLMarigin = New System.Windows.Forms.TextBox
            Me.chkAutoLayout = New System.Windows.Forms.CheckBox
            Me.txtTMarigin = New System.Windows.Forms.TextBox
            Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
            Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
            Me.model2 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
            Me.panel2.SuspendLayout()
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.model2, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.panel1.Size = New System.Drawing.Size(1543, 86)
            Me.panel1.TabIndex = 0
            Me.panel1.TitleText = "SubGraph Tree Layout"
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.panel2.Caption = "Properties"
            Me.panel2.Controls.Add(Me.label2)
            Me.panel2.Controls.Add(Me.lMarigin)
            Me.panel2.Controls.Add(Me.comboLytDirection)
            Me.panel2.Controls.Add(Me.vSpacing)
            Me.panel2.Controls.Add(Me.txtVSpacing)
            Me.panel2.Controls.Add(Me.hSpacing)
            Me.panel2.Controls.Add(Me.txtHSpacing)
            Me.panel2.Controls.Add(Me.tMarigin)
            Me.panel2.Controls.Add(Me.label1)
            Me.panel2.Controls.Add(Me.apply)
            Me.panel2.Controls.Add(Me.txtLMarigin)
            Me.panel2.Controls.Add(Me.chkAutoLayout)
            Me.panel2.Controls.Add(Me.txtTMarigin)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel2.Location = New System.Drawing.Point(1195, 88)
            Me.panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel2.Name = "panel2"
            Me.panel2.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
            Me.panel2.Size = New System.Drawing.Size(351, 538)
            Me.panel2.TabIndex = 1
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(17, 308)
            Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(135, 20)
            Me.label2.TabIndex = 38
            Me.label2.Text = "Direction Selection"
            '
            'lMarigin
            '
            Me.lMarigin.AutoSize = True
            Me.lMarigin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lMarigin.Location = New System.Drawing.Point(17, 160)
            Me.lMarigin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lMarigin.Name = "lMarigin"
            Me.lMarigin.Size = New System.Drawing.Size(89, 20)
            Me.lMarigin.TabIndex = 23
            Me.lMarigin.Text = "Left Marigin"
            '
            'comboLytDirection
            '
            Me.comboLytDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboLytDirection.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboLytDirection.FormattingEnabled = True
            Me.comboLytDirection.Items.AddRange(New Object() {"TopToBottom", "TopRight", "TopLeft", "RightToLeft", "LeftToRight", "BottomToTop", "BottomLeft", "BottomRight"})
            Me.comboLytDirection.Location = New System.Drawing.Point(200, 305)
            Me.comboLytDirection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboLytDirection.Name = "comboLytDirection"
            Me.comboLytDirection.Size = New System.Drawing.Size(132, 28)
            Me.comboLytDirection.TabIndex = 39
            '
            'vSpacing
            '
            Me.vSpacing.AutoSize = True
            Me.vSpacing.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.vSpacing.Location = New System.Drawing.Point(17, 111)
            Me.vSpacing.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.vSpacing.Name = "vSpacing"
            Me.vSpacing.Size = New System.Drawing.Size(116, 20)
            Me.vSpacing.TabIndex = 20
            Me.vSpacing.Text = "Vertical Spacing"
            '
            'txtVSpacing
            '
            Me.txtVSpacing.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtVSpacing.Location = New System.Drawing.Point(200, 108)
            Me.txtVSpacing.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtVSpacing.Name = "txtVSpacing"
            Me.txtVSpacing.Size = New System.Drawing.Size(132, 27)
            Me.txtVSpacing.TabIndex = 22
            '
            'hSpacing
            '
            Me.hSpacing.AutoSize = True
            Me.hSpacing.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.hSpacing.Location = New System.Drawing.Point(17, 62)
            Me.hSpacing.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.hSpacing.Name = "hSpacing"
            Me.hSpacing.Size = New System.Drawing.Size(136, 20)
            Me.hSpacing.TabIndex = 19
            Me.hSpacing.Text = "Horizontal Spacing"
            '
            'txtHSpacing
            '
            Me.txtHSpacing.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtHSpacing.Location = New System.Drawing.Point(200, 59)
            Me.txtHSpacing.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtHSpacing.Name = "txtHSpacing"
            Me.txtHSpacing.Size = New System.Drawing.Size(132, 27)
            Me.txtHSpacing.TabIndex = 21
            '
            'tMarigin
            '
            Me.tMarigin.AutoSize = True
            Me.tMarigin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tMarigin.Location = New System.Drawing.Point(17, 209)
            Me.tMarigin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.tMarigin.Name = "tMarigin"
            Me.tMarigin.Size = New System.Drawing.Size(90, 20)
            Me.tMarigin.TabIndex = 24
            Me.tMarigin.Text = "Top Marigin"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(17, 258)
            Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(89, 20)
            Me.label1.TabIndex = 30
            Me.label1.Text = "Auto Layout"
            '
            'apply
            '
            Me.apply.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.apply.FlatAppearance.BorderSize = 0
            Me.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.apply.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.apply.ForeColor = System.Drawing.Color.White
            Me.apply.Location = New System.Drawing.Point(121, 357)
            Me.apply.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.apply.Name = "apply"
            Me.apply.Size = New System.Drawing.Size(107, 37)
            Me.apply.TabIndex = 33
            Me.apply.Text = "Apply"
            Me.apply.UseVisualStyleBackColor = False
            '
            'txtLMarigin
            '
            Me.txtLMarigin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtLMarigin.Location = New System.Drawing.Point(200, 158)
            Me.txtLMarigin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtLMarigin.Name = "txtLMarigin"
            Me.txtLMarigin.Size = New System.Drawing.Size(132, 27)
            Me.txtLMarigin.TabIndex = 25
            '
            'chkAutoLayout
            '
            Me.chkAutoLayout.FlatAppearance.BorderSize = 0
            Me.chkAutoLayout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkAutoLayout.Font = New System.Drawing.Font("Arial", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkAutoLayout.Location = New System.Drawing.Point(200, 244)
            Me.chkAutoLayout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.chkAutoLayout.Name = "chkAutoLayout"
            Me.chkAutoLayout.Size = New System.Drawing.Size(19, 36)
            Me.chkAutoLayout.TabIndex = 27
            Me.chkAutoLayout.UseVisualStyleBackColor = True
            '
            'txtTMarigin
            '
            Me.txtTMarigin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTMarigin.Location = New System.Drawing.Point(200, 207)
            Me.txtTMarigin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtTMarigin.Name = "txtTMarigin"
            Me.txtTMarigin.Size = New System.Drawing.Size(132, 27)
            Me.txtTMarigin.TabIndex = 26
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
            Me.diagram1.Size = New System.Drawing.Size(1192, 538)
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
            Me.model1.DocumentSize.Width = 1200.0!
            Me.model1.LineStyle.DashPattern = Nothing
            Me.model1.LineStyle.LineColor = System.Drawing.Color.Black
            Me.model1.LineStyle.LineWidth = 0.0!
            Me.model1.LogicalSize = New System.Drawing.SizeF(1200.0!, 1169.0!)
            Me.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            '
            'model2
            '
            Me.model2.BackgroundStyle.Color = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(119, Byte), Integer))
            Me.model2.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter
            Me.model2.DocumentScale.DisplayName = "No Scale"
            Me.model2.DocumentScale.Height = 1.0!
            Me.model2.DocumentScale.Width = 1.0!
            Me.model2.DocumentSize.Height = 1169.0!
            Me.model2.DocumentSize.Width = 827.0!
            Me.model2.LineStyle.DashPattern = Nothing
            Me.model2.LineStyle.LineColor = System.Drawing.Color.Black
            Me.model2.LogicalSize = New System.Drawing.SizeF(827.0!, 1169.0!)
            Me.model2.ShadowStyle.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.model2.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1549, 628)
            Me.Controls.Add(Me.diagram1)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "Form1"
            Me.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Sub Graph Layout"
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.model2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private panel1 As DemoCommon.Diagram.TitlePanel
		Private panel2 As DemoCommon.Diagram.Expander
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Syncfusion.Windows.Forms.Diagram.Model
		Private txtVSpacing As System.Windows.Forms.TextBox
		Private lMarigin As System.Windows.Forms.Label
		Private txtHSpacing As System.Windows.Forms.TextBox
		Private vSpacing As System.Windows.Forms.Label
		Private hSpacing As System.Windows.Forms.Label
		Private tMarigin As System.Windows.Forms.Label
		Private txtLMarigin As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private txtTMarigin As System.Windows.Forms.TextBox
		Private WithEvents apply As System.Windows.Forms.Button
		Private chkAutoLayout As System.Windows.Forms.CheckBox
		Private model2 As Syncfusion.Windows.Forms.Diagram.Model
		Private label2 As System.Windows.Forms.Label
		Private comboLytDirection As System.Windows.Forms.ComboBox

	End Class
End Namespace

