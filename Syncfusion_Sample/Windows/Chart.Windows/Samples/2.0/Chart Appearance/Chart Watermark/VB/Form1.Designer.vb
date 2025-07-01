Imports Microsoft.VisualBasic
Imports System
Namespace ChartWaterMarker
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
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
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.chartTitle1 = New Syncfusion.Windows.Forms.Chart.ChartTitle
            Me.imageListAdv1 = New Syncfusion.Windows.Forms.Tools.ImageListAdv(Me.components)
            Me.label7 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.radioButton2 = New System.Windows.Forms.RadioButton
            Me.label3 = New System.Windows.Forms.Label
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.label4 = New System.Windows.Forms.Label
            Me.comboBox3 = New System.Windows.Forms.ComboBox
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.chartControl1.SuspendLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(187, Byte), Integer))
            Me.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(187, Byte), Integer))
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer)))
            Me.chartControl1.ChartArea.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(177, Byte), Integer))
            Me.chartControl1.ChartArea.Watermark.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.ChartArea.Watermark.TextColor = System.Drawing.SystemColors.ControlText
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            '
            '
            Me.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center
            Me.chartControl1.Legend.Border.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Red
            Me.chartControl1.Legend.ColumnsCount = 3
            Me.chartControl1.Legend.FloatingAutoSize = False
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.Legend.Location = New System.Drawing.Point(253, 61)
            Me.chartControl1.Legend.OnlyColumnsForFloating = False
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.Legend.Size = New System.Drawing.Size(83, 28)
            Me.chartControl1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside
            Me.chartControl1.Location = New System.Drawing.Point(12, 9)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.PrimaryXAxis.DateTimeFormat = ""
            Me.chartControl1.PrimaryXAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            Me.chartControl1.PrimaryXAxis.GridLineType.Width = 0.0!
            Me.chartControl1.PrimaryXAxis.HidePartialLabels = True
            Me.chartControl1.PrimaryXAxis.Origin = 34704
            Me.chartControl1.PrimaryXAxis.OriginDate = New Date(1995, 1, 5, 0, 0, 0, 0)
            Me.chartControl1.PrimaryXAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(1994, 2008, 2)
            Me.chartControl1.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.PrimaryXAxis.Title = "Year"
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.PrimaryYAxis.ForceZero = True
            Me.chartControl1.PrimaryYAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 100, 10)
            Me.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.PrimaryYAxis.Title = "Sales Percentage"
            Me.chartControl1.ShadowColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.PatternStyle.None, System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(217, Byte), Integer)))
            Me.chartControl1.ShadowWidth = 2
            Me.chartControl1.Size = New System.Drawing.Size(584, 354)
            Me.chartControl1.TabIndex = 18
            '
            '
            '
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartTitle1)
            '
            'chartTitle1
            '
            Me.chartTitle1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartTitle1.Name = "chartTitle1"
            Me.chartTitle1.Text = "Car Sales"
            '
            'imageListAdv1
            '
            Me.imageListAdv1.Images.AddRange(New System.Drawing.Image() {CType(resources.GetObject("imageListAdv1.Images"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images1"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images2"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images3"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images4"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images5"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images6"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images7"), System.Drawing.Image)})
            '
            'label7
            '
            Me.label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.label7.Location = New System.Drawing.Point(606, 89)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(190, 1)
            Me.label7.TabIndex = 21
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.BackColor = System.Drawing.Color.Transparent
            Me.label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label6.Location = New System.Drawing.Point(601, 69)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(67, 14)
            Me.label6.TabIndex = 20
            Me.label6.Text = "WaterMark"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.Color.Transparent
            Me.label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Location = New System.Drawing.Point(601, 110)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(105, 14)
            Me.label1.TabIndex = 22
            Me.label1.Text = "Horizontal Alignment"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.BackColor = System.Drawing.Color.Transparent
            Me.label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Location = New System.Drawing.Point(601, 135)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(94, 14)
            Me.label2.TabIndex = 23
            Me.label2.Text = "Vertical Alignment"
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Items.AddRange(New Object() {"Near", "Center", "Far"})
            Me.comboBox1.Location = New System.Drawing.Point(713, 108)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(73, 21)
            Me.comboBox1.TabIndex = 24
            '
            'comboBox2
            '
            Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox2.FormattingEnabled = True
            Me.comboBox2.Items.AddRange(New Object() {"Near", "Center", "Far"})
            Me.comboBox2.Location = New System.Drawing.Point(713, 135)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(73, 21)
            Me.comboBox2.TabIndex = 25
            '
            'radioButton1
            '
            Me.radioButton1.AutoSize = True
            Me.radioButton1.Checked = True
            Me.radioButton1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.radioButton1.Location = New System.Drawing.Point(604, 189)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(110, 17)
            Me.radioButton1.TabIndex = 27
            Me.radioButton1.TabStop = True
            Me.radioButton1.Text = "Image WaterMark"
            Me.radioButton1.UseVisualStyleBackColor = True
            '
            'radioButton2
            '
            Me.radioButton2.AutoSize = True
            Me.radioButton2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.radioButton2.Location = New System.Drawing.Point(604, 166)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(102, 17)
            Me.radioButton2.TabIndex = 28
            Me.radioButton2.Text = "Text WaterMark"
            Me.radioButton2.UseVisualStyleBackColor = True
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Enabled = False
            Me.label3.Location = New System.Drawing.Point(602, 221)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(43, 13)
            Me.label3.TabIndex = 29
            Me.label3.Text = "Opacity"
            '
            'numericUpDown1
            '
            Me.numericUpDown1.Enabled = False
            Me.numericUpDown1.Location = New System.Drawing.Point(656, 221)
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.Size = New System.Drawing.Size(48, 20)
            Me.numericUpDown1.TabIndex = 30
            Me.numericUpDown1.Value = New Decimal(New Integer() {60, 0, 0, 0})
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(602, 278)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(40, 13)
            Me.label4.TabIndex = 31
            Me.label4.Text = "ZOrder"
            '
            'comboBox3
            '
            Me.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox3.FormattingEnabled = True
            Me.comboBox3.Items.AddRange(New Object() {"Over", "Behind"})
            Me.comboBox3.Location = New System.Drawing.Point(656, 274)
            Me.comboBox3.Name = "comboBox3"
            Me.comboBox3.Size = New System.Drawing.Size(73, 21)
            Me.comboBox3.TabIndex = 32
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(605, 251)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(76, 17)
            Me.checkBox1.TabIndex = 33
            Me.checkBox1.Text = "Enable 3D"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(799, 366)
            Me.Controls.Add(Me.checkBox1)
            Me.Controls.Add(Me.comboBox3)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.numericUpDown1)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.radioButton2)
            Me.Controls.Add(Me.radioButton1)
            Me.Controls.Add(Me.comboBox2)
            Me.Controls.Add(Me.comboBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Watermark"
            Me.chartControl1.ResumeLayout(False)
            Me.chartControl1.PerformLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private imageListAdv1 As Syncfusion.Windows.Forms.Tools.ImageListAdv
		Private chartTitle1 As Syncfusion.Windows.Forms.Chart.ChartTitle
		Private label7 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
		Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
		Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton2 As System.Windows.Forms.RadioButton
		Private label3 As System.Windows.Forms.Label
		Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
		Private label4 As System.Windows.Forms.Label
		Private WithEvents comboBox3 As System.Windows.Forms.ComboBox
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox

	End Class
End Namespace

