Imports Microsoft.VisualBasic
Imports System
Namespace TableLayout
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
            Me.comboCellSize = New System.Windows.Forms.ComboBox
            Me.label3 = New System.Windows.Forms.Label
            Me.comboExpandMode = New System.Windows.Forms.ComboBox
            Me.label2 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.lblMaxRowsCount = New System.Windows.Forms.Label
            Me.txtMaxRowsCount = New System.Windows.Forms.TextBox
            Me.lblTableMaxHeight = New System.Windows.Forms.Label
            Me.txtMaxWidth = New System.Windows.Forms.TextBox
            Me.lblMaxColumnCount = New System.Windows.Forms.Label
            Me.lblTableMaxWidth = New System.Windows.Forms.Label
            Me.txtMaxHeight = New System.Windows.Forms.TextBox
            Me.apply = New System.Windows.Forms.Button
            Me.txtTMarigin = New System.Windows.Forms.TextBox
            Me.txtMaxColumnCount = New System.Windows.Forms.TextBox
            Me.chkAutoLayout = New System.Windows.Forms.CheckBox
            Me.txtLMarigin = New System.Windows.Forms.TextBox
            Me.txtVSpacing = New System.Windows.Forms.TextBox
            Me.lMarigin = New System.Windows.Forms.Label
            Me.tMarigin = New System.Windows.Forms.Label
            Me.txtHSpacing = New System.Windows.Forms.TextBox
            Me.vSpacing = New System.Windows.Forms.Label
            Me.hSpacing = New System.Windows.Forms.Label
            Me.diagram1 = New Syncfusion.Windows.Forms.Diagram.Controls.Diagram(Me.components)
            Me.model1 = New Syncfusion.Windows.Forms.Diagram.Model(Me.components)
            Me.panel2.SuspendLayout()
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
            Me.panel1.Size = New System.Drawing.Size(1127, 86)
            Me.panel1.TabIndex = 0
            Me.panel1.TitleText = "Table Layout"
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.panel2.Caption = "Properties"
            Me.panel2.Controls.Add(Me.comboCellSize)
            Me.panel2.Controls.Add(Me.label3)
            Me.panel2.Controls.Add(Me.comboExpandMode)
            Me.panel2.Controls.Add(Me.label2)
            Me.panel2.Controls.Add(Me.label1)
            Me.panel2.Controls.Add(Me.lblMaxRowsCount)
            Me.panel2.Controls.Add(Me.txtMaxRowsCount)
            Me.panel2.Controls.Add(Me.lblTableMaxHeight)
            Me.panel2.Controls.Add(Me.txtMaxWidth)
            Me.panel2.Controls.Add(Me.lblMaxColumnCount)
            Me.panel2.Controls.Add(Me.lblTableMaxWidth)
            Me.panel2.Controls.Add(Me.txtMaxHeight)
            Me.panel2.Controls.Add(Me.apply)
            Me.panel2.Controls.Add(Me.txtTMarigin)
            Me.panel2.Controls.Add(Me.txtMaxColumnCount)
            Me.panel2.Controls.Add(Me.chkAutoLayout)
            Me.panel2.Controls.Add(Me.txtLMarigin)
            Me.panel2.Controls.Add(Me.txtVSpacing)
            Me.panel2.Controls.Add(Me.lMarigin)
            Me.panel2.Controls.Add(Me.tMarigin)
            Me.panel2.Controls.Add(Me.txtHSpacing)
            Me.panel2.Controls.Add(Me.vSpacing)
            Me.panel2.Controls.Add(Me.hSpacing)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel2.Location = New System.Drawing.Point(785, 88)
            Me.panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel2.Name = "panel2"
            Me.panel2.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
            Me.panel2.Size = New System.Drawing.Size(345, 657)
            Me.panel2.TabIndex = 1
            '
            'comboCellSize
            '
            Me.comboCellSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboCellSize.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboCellSize.FormattingEnabled = True
            Me.comboCellSize.Items.AddRange(New Object() {"Equal to Max", "Minimal", "Minimal Table"})
            Me.comboCellSize.Location = New System.Drawing.Point(195, 553)
            Me.comboCellSize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboCellSize.Name = "comboCellSize"
            Me.comboCellSize.Size = New System.Drawing.Size(132, 28)
            Me.comboCellSize.TabIndex = 52
            '
            'label3
            '
            Me.label3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.label3.Location = New System.Drawing.Point(16, 551)
            Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(129, 25)
            Me.label3.TabIndex = 51
            Me.label3.Text = "Cell Size Mode"
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'comboExpandMode
            '
            Me.comboExpandMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboExpandMode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboExpandMode.FormattingEnabled = True
            Me.comboExpandMode.Items.AddRange(New Object() {"Horizontal", "Vertical"})
            Me.comboExpandMode.Location = New System.Drawing.Point(195, 503)
            Me.comboExpandMode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboExpandMode.Name = "comboExpandMode"
            Me.comboExpandMode.Size = New System.Drawing.Size(132, 28)
            Me.comboExpandMode.TabIndex = 50
            '
            'label2
            '
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.label2.Location = New System.Drawing.Point(16, 502)
            Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(129, 25)
            Me.label2.TabIndex = 49
            Me.label2.Text = "Expand Mode"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label1
            '
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.label1.Location = New System.Drawing.Point(16, 453)
            Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(149, 25)
            Me.label1.TabIndex = 48
            Me.label1.Text = "Auto Layout"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblMaxRowsCount
            '
            Me.lblMaxRowsCount.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.lblMaxRowsCount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMaxRowsCount.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.lblMaxRowsCount.Location = New System.Drawing.Point(16, 354)
            Me.lblMaxRowsCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblMaxRowsCount.Name = "lblMaxRowsCount"
            Me.lblMaxRowsCount.Size = New System.Drawing.Size(129, 25)
            Me.lblMaxRowsCount.TabIndex = 44
            Me.lblMaxRowsCount.Text = "Max rows count"
            Me.lblMaxRowsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtMaxRowsCount
            '
            Me.txtMaxRowsCount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMaxRowsCount.Location = New System.Drawing.Point(195, 351)
            Me.txtMaxRowsCount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtMaxRowsCount.Name = "txtMaxRowsCount"
            Me.txtMaxRowsCount.Size = New System.Drawing.Size(132, 27)
            Me.txtMaxRowsCount.TabIndex = 45
            Me.txtMaxRowsCount.Text = "5"
            '
            'lblTableMaxHeight
            '
            Me.lblTableMaxHeight.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.lblTableMaxHeight.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTableMaxHeight.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.lblTableMaxHeight.Location = New System.Drawing.Point(16, 305)
            Me.lblTableMaxHeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblTableMaxHeight.Name = "lblTableMaxHeight"
            Me.lblTableMaxHeight.Size = New System.Drawing.Size(149, 25)
            Me.lblTableMaxHeight.TabIndex = 40
            Me.lblTableMaxHeight.Text = "Max height"
            Me.lblTableMaxHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtMaxWidth
            '
            Me.txtMaxWidth.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMaxWidth.Location = New System.Drawing.Point(195, 254)
            Me.txtMaxWidth.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtMaxWidth.Name = "txtMaxWidth"
            Me.txtMaxWidth.Size = New System.Drawing.Size(132, 27)
            Me.txtMaxWidth.TabIndex = 39
            Me.txtMaxWidth.Text = "600"
            '
            'lblMaxColumnCount
            '
            Me.lblMaxColumnCount.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.lblMaxColumnCount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMaxColumnCount.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.lblMaxColumnCount.Location = New System.Drawing.Point(16, 404)
            Me.lblMaxColumnCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblMaxColumnCount.Name = "lblMaxColumnCount"
            Me.lblMaxColumnCount.Size = New System.Drawing.Size(149, 25)
            Me.lblMaxColumnCount.TabIndex = 42
            Me.lblMaxColumnCount.Text = "Max column count"
            Me.lblMaxColumnCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblTableMaxWidth
            '
            Me.lblTableMaxWidth.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.lblTableMaxWidth.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTableMaxWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.lblTableMaxWidth.Location = New System.Drawing.Point(16, 254)
            Me.lblTableMaxWidth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblTableMaxWidth.Name = "lblTableMaxWidth"
            Me.lblTableMaxWidth.Size = New System.Drawing.Size(97, 25)
            Me.lblTableMaxWidth.TabIndex = 38
            Me.lblTableMaxWidth.Text = "Max width"
            Me.lblTableMaxWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtMaxHeight
            '
            Me.txtMaxHeight.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMaxHeight.Location = New System.Drawing.Point(195, 305)
            Me.txtMaxHeight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtMaxHeight.Name = "txtMaxHeight"
            Me.txtMaxHeight.Size = New System.Drawing.Size(132, 27)
            Me.txtMaxHeight.TabIndex = 41
            Me.txtMaxHeight.Text = "500"
            '
            'apply
            '
            Me.apply.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.apply.FlatAppearance.BorderSize = 0
            Me.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.apply.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.apply.ForeColor = System.Drawing.Color.White
            Me.apply.Location = New System.Drawing.Point(143, 601)
            Me.apply.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.apply.Name = "apply"
            Me.apply.Size = New System.Drawing.Size(107, 37)
            Me.apply.TabIndex = 33
            Me.apply.Text = "Apply"
            Me.apply.UseVisualStyleBackColor = False
            '
            'txtTMarigin
            '
            Me.txtTMarigin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTMarigin.Location = New System.Drawing.Point(195, 207)
            Me.txtTMarigin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtTMarigin.Name = "txtTMarigin"
            Me.txtTMarigin.Size = New System.Drawing.Size(132, 27)
            Me.txtTMarigin.TabIndex = 35
            '
            'txtMaxColumnCount
            '
            Me.txtMaxColumnCount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMaxColumnCount.Location = New System.Drawing.Point(195, 400)
            Me.txtMaxColumnCount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtMaxColumnCount.Name = "txtMaxColumnCount"
            Me.txtMaxColumnCount.Size = New System.Drawing.Size(132, 27)
            Me.txtMaxColumnCount.TabIndex = 43
            Me.txtMaxColumnCount.Text = "4"
            '
            'chkAutoLayout
            '
            Me.chkAutoLayout.AutoSize = True
            Me.chkAutoLayout.FlatAppearance.BorderSize = 0
            Me.chkAutoLayout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chkAutoLayout.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkAutoLayout.Location = New System.Drawing.Point(195, 453)
            Me.chkAutoLayout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.chkAutoLayout.Name = "chkAutoLayout"
            Me.chkAutoLayout.Size = New System.Drawing.Size(12, 11)
            Me.chkAutoLayout.TabIndex = 36
            Me.chkAutoLayout.UseVisualStyleBackColor = True
            '
            'txtLMarigin
            '
            Me.txtLMarigin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtLMarigin.Location = New System.Drawing.Point(195, 158)
            Me.txtLMarigin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtLMarigin.Name = "txtLMarigin"
            Me.txtLMarigin.Size = New System.Drawing.Size(132, 27)
            Me.txtLMarigin.TabIndex = 34
            '
            'txtVSpacing
            '
            Me.txtVSpacing.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtVSpacing.Location = New System.Drawing.Point(195, 108)
            Me.txtVSpacing.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtVSpacing.Name = "txtVSpacing"
            Me.txtVSpacing.Size = New System.Drawing.Size(132, 27)
            Me.txtVSpacing.TabIndex = 31
            '
            'lMarigin
            '
            Me.lMarigin.AutoSize = True
            Me.lMarigin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lMarigin.Location = New System.Drawing.Point(12, 158)
            Me.lMarigin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lMarigin.Name = "lMarigin"
            Me.lMarigin.Size = New System.Drawing.Size(89, 20)
            Me.lMarigin.TabIndex = 32
            Me.lMarigin.Text = "Left Marigin"
            '
            'tMarigin
            '
            Me.tMarigin.AutoSize = True
            Me.tMarigin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tMarigin.Location = New System.Drawing.Point(12, 209)
            Me.tMarigin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.tMarigin.Name = "tMarigin"
            Me.tMarigin.Size = New System.Drawing.Size(90, 20)
            Me.tMarigin.TabIndex = 33
            Me.tMarigin.Text = "Top Marigin"
            '
            'txtHSpacing
            '
            Me.txtHSpacing.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtHSpacing.Location = New System.Drawing.Point(195, 59)
            Me.txtHSpacing.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtHSpacing.Name = "txtHSpacing"
            Me.txtHSpacing.Size = New System.Drawing.Size(132, 27)
            Me.txtHSpacing.TabIndex = 30
            '
            'vSpacing
            '
            Me.vSpacing.AutoSize = True
            Me.vSpacing.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.vSpacing.Location = New System.Drawing.Point(12, 108)
            Me.vSpacing.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.vSpacing.Name = "vSpacing"
            Me.vSpacing.Size = New System.Drawing.Size(116, 20)
            Me.vSpacing.TabIndex = 29
            Me.vSpacing.Text = "Vertical Spacing"
            '
            'hSpacing
            '
            Me.hSpacing.AutoSize = True
            Me.hSpacing.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.hSpacing.Location = New System.Drawing.Point(12, 59)
            Me.hSpacing.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.hSpacing.Name = "hSpacing"
            Me.hSpacing.Size = New System.Drawing.Size(136, 20)
            Me.hSpacing.TabIndex = 28
            Me.hSpacing.Text = "Horizontal Spacing"
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
            Me.diagram1.Size = New System.Drawing.Size(782, 657)
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
            Me.model1.DocumentSize.Width = 1000.0!
            Me.model1.LineStyle.DashPattern = Nothing
            Me.model1.LineStyle.LineColor = System.Drawing.Color.Black
            Me.model1.LineStyle.LineWidth = 0.0!
            Me.model1.LogicalSize = New System.Drawing.SizeF(1000.0!, 1169.0!)
            Me.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1133, 747)
            Me.Controls.Add(Me.diagram1)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "Form1"
            Me.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "TableLayout"
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            CType(Me.diagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.model1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private panel1 As DemoCommon.Diagram.TitlePanel
		Private panel2 As DemoCommon.Diagram.Expander
		Private label1 As System.Windows.Forms.Label
		Private lblMaxRowsCount As System.Windows.Forms.Label
		Private txtMaxRowsCount As System.Windows.Forms.TextBox
		Private txtMaxWidth As System.Windows.Forms.TextBox
		Private lblTableMaxWidth As System.Windows.Forms.Label
		Private lblTableMaxHeight As System.Windows.Forms.Label
		Private txtMaxHeight As System.Windows.Forms.TextBox
		Private txtMaxColumnCount As System.Windows.Forms.TextBox
		Private lblMaxColumnCount As System.Windows.Forms.Label
		Private WithEvents apply As System.Windows.Forms.Button
		Private chkAutoLayout As System.Windows.Forms.CheckBox
		Private txtTMarigin As System.Windows.Forms.TextBox
		Private txtLMarigin As System.Windows.Forms.TextBox
		Private tMarigin As System.Windows.Forms.Label
		Private lMarigin As System.Windows.Forms.Label
		Private txtVSpacing As System.Windows.Forms.TextBox
		Private txtHSpacing As System.Windows.Forms.TextBox
		Private vSpacing As System.Windows.Forms.Label
		Private hSpacing As System.Windows.Forms.Label
		Private diagram1 As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private model1 As Syncfusion.Windows.Forms.Diagram.Model
		Private comboExpandMode As System.Windows.Forms.ComboBox
		Private label2 As System.Windows.Forms.Label
		Private comboCellSize As System.Windows.Forms.ComboBox
		Private label3 As System.Windows.Forms.Label


	End Class
End Namespace

