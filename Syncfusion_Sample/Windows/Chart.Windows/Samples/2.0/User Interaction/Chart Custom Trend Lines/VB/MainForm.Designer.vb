Imports Microsoft.VisualBasic
Imports System
Namespace ClickPointDemo2
	Public Partial Class MainForm
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
			Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl()
			Me.label1 = New System.Windows.Forms.Label()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.label13 = New System.Windows.Forms.Label()
			Me.label12 = New System.Windows.Forms.Label()
			Me.label11 = New System.Windows.Forms.Label()
			Me.label9 = New System.Windows.Forms.Label()
			Me.colorPickerButton3 = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.label8 = New System.Windows.Forms.Label()
			Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown()
			Me.label6 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.cmbSymbolStyle = New System.Windows.Forms.ComboBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label7 = New System.Windows.Forms.Label()
			Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
			Me.comboBox_LineStyle = New System.Windows.Forms.ComboBox()
			Me.label10 = New System.Windows.Forms.Label()
			Me.colorPickerButton2 = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
			Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.panel1.SuspendLayout()
			CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White)
			Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
			Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent)
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			' 
			' 
			' 
			Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo()
			Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10F)
			Me.chartControl1.Legend.Location = New System.Drawing.Point(377, 75)
			Me.chartControl1.LegendAlignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Near
			Me.chartControl1.LegendPosition = Syncfusion.Windows.Forms.Chart.ChartDock.Right
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.Size = New System.Drawing.Size(497, 281)
			Me.chartControl1.TabIndex = 0
			Me.chartControl1.Text = "Chart Custom Trend Lines"
			' 
			' 
			' 
			Me.chartControl1.Title.Name = "Def_title"
			Me.chartControl1.Title.Text = "Chart Custom Trend Lines"
			Me.chartControl1.Titles.Add(Me.chartControl1.Title)
			' 
			' label1
			' 
			Me.label1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(187))))), (CInt(Fix((CByte(212))))), (CInt(Fix((CByte(246))))))
			Me.label1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(0, 304)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(517, 21)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Click and drag to draw custom trend lines on the chart"
			Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.White
			Me.panel1.Controls.Add(Me.checkBox1)
			Me.panel1.Controls.Add(Me.label13)
			Me.panel1.Controls.Add(Me.label12)
			Me.panel1.Controls.Add(Me.label11)
			Me.panel1.Controls.Add(Me.label9)
			Me.panel1.Controls.Add(Me.colorPickerButton3)
			Me.panel1.Controls.Add(Me.label8)
			Me.panel1.Controls.Add(Me.numericUpDown2)
			Me.panel1.Controls.Add(Me.label6)
			Me.panel1.Controls.Add(Me.label5)
			Me.panel1.Controls.Add(Me.cmbSymbolStyle)
			Me.panel1.Controls.Add(Me.label4)
			Me.panel1.Controls.Add(Me.label3)
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Controls.Add(Me.label7)
			Me.panel1.Controls.Add(Me.numericUpDown1)
			Me.panel1.Controls.Add(Me.comboBox_LineStyle)
			Me.panel1.Controls.Add(Me.label10)
			Me.panel1.Controls.Add(Me.colorPickerButton2)
			Me.panel1.Controls.Add(Me.colorPickerButton1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panel1.Location = New System.Drawing.Point(0, 325)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(517, 147)
			Me.panel1.TabIndex = 4
			' 
			' checkBox1
			' 
			Me.checkBox1.AutoSize = True
			Me.checkBox1.Location = New System.Drawing.Point(294, 123)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(88, 17)
			Me.checkBox1.TabIndex = 131
			Me.checkBox1.Text = "Show Tooltip"
			Me.checkBox1.UseVisualStyleBackColor = True
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged);
			' 
			' label13
			' 
			Me.label13.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(127))))), (CInt(Fix((CByte(157))))), (CInt(Fix((CByte(185))))))
			Me.label13.Location = New System.Drawing.Point(291, 30)
			Me.label13.Name = "label13"
			Me.label13.Size = New System.Drawing.Size(150, 1)
			Me.label13.TabIndex = 130
			' 
			' label12
			' 
			Me.label12.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(127))))), (CInt(Fix((CByte(157))))), (CInt(Fix((CByte(185))))))
			Me.label12.Location = New System.Drawing.Point(55, 28)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(150, 1)
			Me.label12.TabIndex = 129
			' 
			' label11
			' 
			Me.label11.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label11.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label11.Image = (CType(resources.GetObject("label11.Image"), System.Drawing.Image))
			Me.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label11.Location = New System.Drawing.Point(283, 10)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(68, 19)
			Me.label11.TabIndex = 126
			Me.label11.Text = "Symbol"
			Me.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' label9
			' 
			Me.label9.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label9.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label9.Image = (CType(resources.GetObject("label9.Image"), System.Drawing.Image))
			Me.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label9.Location = New System.Drawing.Point(50, 8)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(51, 19)
			Me.label9.TabIndex = 125
			Me.label9.Text = "Line"
			Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' colorPickerButton3
			' 
			Me.colorPickerButton3.BackColor = System.Drawing.Color.Yellow
			Me.colorPickerButton3.ColorUISize = New System.Drawing.Size(208, 230)
			Me.colorPickerButton3.Cursor = System.Windows.Forms.Cursors.Hand
			Me.colorPickerButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.colorPickerButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.colorPickerButton3.ForeColor = System.Drawing.Color.MidnightBlue
			Me.colorPickerButton3.Location = New System.Drawing.Point(344, 42)
			Me.colorPickerButton3.Name = "colorPickerButton3"
			Me.colorPickerButton3.SelectedAsBackcolor = True
			Me.colorPickerButton3.SelectedColor = System.Drawing.Color.Yellow
			Me.colorPickerButton3.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
			Me.colorPickerButton3.Size = New System.Drawing.Size(20, 20)
			Me.colorPickerButton3.TabIndex = 14
			Me.colorPickerButton3.UseVisualStyleBackColor = False
'			Me.colorPickerButton3.ColorSelected += New System.EventHandler(Me.colorPickerButton3_ColorSelected);
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.BackColor = System.Drawing.Color.Transparent
			Me.label8.ForeColor = System.Drawing.Color.Black
			Me.label8.Location = New System.Drawing.Point(291, 43)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(31, 13)
			Me.label8.TabIndex = 114
			Me.label8.Text = "Color"
			Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' numericUpDown2
			' 
			Me.numericUpDown2.Location = New System.Drawing.Point(341, 97)
			Me.numericUpDown2.Maximum = New Decimal(New Integer() { 16, 0, 0, 0})
			Me.numericUpDown2.Minimum = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.numericUpDown2.Name = "numericUpDown2"
			Me.numericUpDown2.Size = New System.Drawing.Size(92, 20)
			Me.numericUpDown2.TabIndex = 111
			Me.numericUpDown2.Value = New Decimal(New Integer() { 9, 0, 0, 0})
'			Me.numericUpDown2.ValueChanged += New System.EventHandler(Me.numericUpDown2_ValueChanged);
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.BackColor = System.Drawing.Color.Transparent
			Me.label6.ForeColor = System.Drawing.Color.Black
			Me.label6.Location = New System.Drawing.Point(291, 99)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(27, 13)
			Me.label6.TabIndex = 112
			Me.label6.Text = "Size"
			Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.BackColor = System.Drawing.Color.Transparent
			Me.label5.ForeColor = System.Drawing.Color.Black
			Me.label5.Location = New System.Drawing.Point(291, 68)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(31, 13)
			Me.label5.TabIndex = 109
			Me.label5.Text = "Type"
			Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' cmbSymbolStyle
			' 
			Me.cmbSymbolStyle.Cursor = System.Windows.Forms.Cursors.Hand
			Me.cmbSymbolStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbSymbolStyle.DropDownWidth = 76
			Me.cmbSymbolStyle.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.cmbSymbolStyle.ForeColor = System.Drawing.Color.MidnightBlue
			Me.cmbSymbolStyle.Location = New System.Drawing.Point(341, 68)
			Me.cmbSymbolStyle.Name = "cmbSymbolStyle"
			Me.cmbSymbolStyle.Size = New System.Drawing.Size(92, 21)
			Me.cmbSymbolStyle.TabIndex = 110
'			Me.cmbSymbolStyle.SelectedIndexChanged += New System.EventHandler(Me.cmbSymbolStyle_SelectedIndexChanged);
			' 
			' label4
			' 
			Me.label4.ForeColor = System.Drawing.Color.Black
			Me.label4.Image = (CType(resources.GetObject("label4.Image"), System.Drawing.Image))
			Me.label4.Location = New System.Drawing.Point(149, 39)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(10, 24)
			Me.label4.TabIndex = 108
			' 
			' label3
			' 
			Me.label3.ForeColor = System.Drawing.Color.Black
			Me.label3.Image = (CType(resources.GetObject("label3.Image"), System.Drawing.Image))
			Me.label3.Location = New System.Drawing.Point(99, 41)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(10, 20)
			Me.label3.TabIndex = 107
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.ForeColor = System.Drawing.Color.Black
			Me.label2.Location = New System.Drawing.Point(51, 41)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(31, 13)
			Me.label2.TabIndex = 106
			Me.label2.Text = "Color"
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.ForeColor = System.Drawing.Color.Black
			Me.label7.Location = New System.Drawing.Point(51, 97)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(35, 13)
			Me.label7.TabIndex = 86
			Me.label7.Text = "Width"
			' 
			' numericUpDown1
			' 
			Me.numericUpDown1.Location = New System.Drawing.Point(99, 97)
			Me.numericUpDown1.Maximum = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.numericUpDown1.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.numericUpDown1.Name = "numericUpDown1"
			Me.numericUpDown1.Size = New System.Drawing.Size(83, 20)
			Me.numericUpDown1.TabIndex = 85
			Me.numericUpDown1.Value = New Decimal(New Integer() { 2, 0, 0, 0})
'			Me.numericUpDown1.ValueChanged += New System.EventHandler(Me.numericUpDown1_ValueChanged);
			' 
			' comboBox_LineStyle
			' 
			Me.comboBox_LineStyle.DropDownWidth = 76
			Me.comboBox_LineStyle.FormattingEnabled = True
			Me.comboBox_LineStyle.Items.AddRange(New Object() { "Solid", "Dash", "Dot", "DashDot", "DashDotDot", "Custom"})
			Me.comboBox_LineStyle.Location = New System.Drawing.Point(99, 69)
			Me.comboBox_LineStyle.Name = "comboBox_LineStyle"
			Me.comboBox_LineStyle.Size = New System.Drawing.Size(83, 21)
			Me.comboBox_LineStyle.TabIndex = 83
'			Me.comboBox_LineStyle.SelectedIndexChanged += New System.EventHandler(Me.comboBox_LineStyle_SelectedIndexChanged);
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.ForeColor = System.Drawing.Color.Black
			Me.label10.Location = New System.Drawing.Point(51, 69)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(30, 13)
			Me.label10.TabIndex = 82
			Me.label10.Text = "Style"
			' 
			' colorPickerButton2
			' 
			Me.colorPickerButton2.BackColor = System.Drawing.Color.Blue
			Me.colorPickerButton2.ColorUISize = New System.Drawing.Size(208, 230)
			Me.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.colorPickerButton2.Location = New System.Drawing.Point(160, 41)
			Me.colorPickerButton2.Name = "colorPickerButton2"
			Me.colorPickerButton2.SelectedAsBackcolor = True
			Me.colorPickerButton2.SelectedColor = System.Drawing.Color.Blue
			Me.colorPickerButton2.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
			Me.colorPickerButton2.Size = New System.Drawing.Size(20, 20)
			Me.colorPickerButton2.TabIndex = 5
			Me.toolTip1.SetToolTip(Me.colorPickerButton2, "Color to draw the trendline when indicating a downward trend")
			Me.colorPickerButton2.UseVisualStyleBackColor = False
'			Me.colorPickerButton2.ColorSelected += New System.EventHandler(Me.colorPickerButton2_ColorSelected);
			' 
			' colorPickerButton1
			' 
			Me.colorPickerButton1.BackColor = System.Drawing.Color.DarkGreen
			Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
			Me.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.colorPickerButton1.Location = New System.Drawing.Point(110, 41)
			Me.colorPickerButton1.Name = "colorPickerButton1"
			Me.colorPickerButton1.SelectedAsBackcolor = True
			Me.colorPickerButton1.SelectedColor = System.Drawing.Color.DarkGreen
			Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
			Me.colorPickerButton1.Size = New System.Drawing.Size(20, 20)
			Me.colorPickerButton1.TabIndex = 4
			Me.toolTip1.SetToolTip(Me.colorPickerButton1, "Color to draw the trendline when indicating a upward trend")
			Me.colorPickerButton1.UseVisualStyleBackColor = False
'			Me.colorPickerButton1.ColorSelected += New System.EventHandler(Me.colorPickerButton1_ColorSelected);
			' 
			' gradientPanel1
			' 
			Me.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
			Me.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(127))))), (CInt(Fix((CByte(157))))), (CInt(Fix((CByte(185))))))
			Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel1.Controls.Add(Me.chartControl1)
			Me.gradientPanel1.Location = New System.Drawing.Point(9, 9)
			Me.gradientPanel1.Name = "gradientPanel1"
			Me.gradientPanel1.Size = New System.Drawing.Size(499, 283)
			Me.gradientPanel1.TabIndex = 5
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.White
			Me.ClientSize = New System.Drawing.Size(517, 472)
			Me.Controls.Add(Me.gradientPanel1)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.panel1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "MainForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Chart Custom Trend Lines"
'			Me.Load += New System.EventHandler(Me.Form2_Load);
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private label1 As System.Windows.Forms.Label
		Private panel1 As System.Windows.Forms.Panel
		Private label4 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Public WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
		Private WithEvents comboBox_LineStyle As System.Windows.Forms.ComboBox
		Private label10 As System.Windows.Forms.Label
		Public WithEvents colorPickerButton2 As Syncfusion.Windows.Forms.ColorPickerButton
		Public WithEvents colorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
		Private label8 As System.Windows.Forms.Label
		Private WithEvents colorPickerButton3 As Syncfusion.Windows.Forms.ColorPickerButton
		Private WithEvents numericUpDown2 As System.Windows.Forms.NumericUpDown
		Private label6 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private WithEvents cmbSymbolStyle As System.Windows.Forms.ComboBox
		Private toolTip1 As System.Windows.Forms.ToolTip
		Private label12 As System.Windows.Forms.Label
		Private label11 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private label13 As System.Windows.Forms.Label
		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
	End Class
End Namespace