Imports Microsoft.VisualBasic
Imports System
Namespace ChartPoints_2005
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
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.cmbSymbolStyle = New System.Windows.Forms.ComboBox
            Me.panel1 = New System.Windows.Forms.Panel
            Me.label5 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label30 = New System.Windows.Forms.Label
            Me.radioButton2 = New System.Windows.Forms.RadioButton
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.label2 = New System.Windows.Forms.Label
            Me.panel2 = New System.Windows.Forms.Panel
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.label3 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.imageListAdv1 = New Syncfusion.Windows.Forms.Tools.ImageListAdv(Me.components)
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.panel1.SuspendLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.Legend.ForeColor = System.Drawing.Color.Navy
            Me.chartControl1.Legend.ItemsSize = New System.Drawing.Size(16, 16)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(58, 75)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.Legend.TextAlignment = System.Drawing.StringAlignment.Near
            Me.chartControl1.Location = New System.Drawing.Point(9, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.PrimaryXAxis.DrawGrid = True
            Me.chartControl1.PrimaryXAxis.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.PrimaryXAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 8, 1)
            Me.chartControl1.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.PrimaryYAxis.DrawGrid = True
            Me.chartControl1.PrimaryYAxis.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.PrimaryYAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 150, 10)
            Me.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.Size = New System.Drawing.Size(494, 370)
            Me.chartControl1.TabIndex = 1
            Me.chartControl1.Text = "Chart Symbols"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Chart Symbols"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'cmbSymbolStyle
            '
            Me.cmbSymbolStyle.Cursor = System.Windows.Forms.Cursors.Hand
            Me.cmbSymbolStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbSymbolStyle.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cmbSymbolStyle.ForeColor = System.Drawing.Color.MidnightBlue
            Me.cmbSymbolStyle.Location = New System.Drawing.Point(314, 58)
            Me.cmbSymbolStyle.Name = "cmbSymbolStyle"
            Me.cmbSymbolStyle.Size = New System.Drawing.Size(112, 21)
            Me.cmbSymbolStyle.TabIndex = 13
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Controls.Add(Me.label6)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.label30)
            Me.panel1.Controls.Add(Me.radioButton2)
            Me.panel1.Controls.Add(Me.radioButton1)
            Me.panel1.Controls.Add(Me.numericUpDown1)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.panel2)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.cmbSymbolStyle)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 394)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(515, 101)
            Me.panel1.TabIndex = 15
            '
            'label5
            '
            Me.label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label5.Location = New System.Drawing.Point(10, 43)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(200, 1)
            Me.label5.TabIndex = 128
            '
            'label6
            '
            Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label6.Image = CType(resources.GetObject("label6.Image"), System.Drawing.Image)
            Me.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label6.Location = New System.Drawing.Point(3, 0)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(94, 19)
            Me.label6.TabIndex = 124
            Me.label6.Text = "Set Symbol"
            Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label4
            '
            Me.label4.Image = CType(resources.GetObject("label4.Image"), System.Drawing.Image)
            Me.label4.Location = New System.Drawing.Point(186, 23)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(20, 20)
            Me.label4.TabIndex = 118
            Me.toolTip1.SetToolTip(Me.label4, "Sets symbol to individual points. In this case point 5")
            '
            'label30
            '
            Me.label30.Image = CType(resources.GetObject("label30.Image"), System.Drawing.Image)
            Me.label30.Location = New System.Drawing.Point(67, 22)
            Me.label30.Name = "label30"
            Me.label30.Size = New System.Drawing.Size(20, 20)
            Me.label30.TabIndex = 117
            Me.toolTip1.SetToolTip(Me.label30, "Sets symbols to all the points in the series")
            '
            'radioButton2
            '
            Me.radioButton2.AutoSize = True
            Me.radioButton2.Location = New System.Drawing.Point(9, 22)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(54, 17)
            Me.radioButton2.TabIndex = 103
            Me.radioButton2.Text = "Series"
            Me.radioButton2.UseVisualStyleBackColor = True
            '
            'radioButton1
            '
            Me.radioButton1.AutoSize = True
            Me.radioButton1.Location = New System.Drawing.Point(106, 23)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(81, 17)
            Me.radioButton1.TabIndex = 102
            Me.radioButton1.Text = "Series Point"
            Me.radioButton1.UseVisualStyleBackColor = True
            '
            'numericUpDown1
            '
            Me.numericUpDown1.Location = New System.Drawing.Point(90, 64)
            Me.numericUpDown1.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
            Me.numericUpDown1.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.Size = New System.Drawing.Size(42, 20)
            Me.numericUpDown1.TabIndex = 100
            Me.numericUpDown1.Value = New Decimal(New Integer() {10, 0, 0, 0})
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.BackColor = System.Drawing.Color.Transparent
            Me.label2.ForeColor = System.Drawing.Color.Black
            Me.label2.Location = New System.Drawing.Point(167, 66)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(31, 13)
            Me.label2.TabIndex = 90
            Me.label2.Text = "Color"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'panel2
            '
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.Add(Me.textBox1)
            Me.panel2.Controls.Add(Me.colorPickerButton1)
            Me.panel2.Location = New System.Drawing.Point(203, 63)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(41, 19)
            Me.panel2.TabIndex = 89
            '
            'textBox1
            '
            Me.textBox1.BackColor = System.Drawing.Color.White
            Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox1.Location = New System.Drawing.Point(0, 0)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.ReadOnly = True
            Me.textBox1.Size = New System.Drawing.Size(22, 20)
            Me.textBox1.TabIndex = 11
            '
            'colorPickerButton1
            '
            Me.colorPickerButton1.BackColor = System.Drawing.Color.White
            Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton1.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton1.Image = CType(resources.GetObject("colorPickerButton1.Image"), System.Drawing.Image)
            Me.colorPickerButton1.Location = New System.Drawing.Point(22, 0)
            Me.colorPickerButton1.Name = "colorPickerButton1"
            Me.colorPickerButton1.SelectedAsBackcolor = True
            Me.colorPickerButton1.SelectedColor = System.Drawing.Color.White
            Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton1.Size = New System.Drawing.Size(17, 17)
            Me.colorPickerButton1.TabIndex = 14
            Me.colorPickerButton1.Text = "..."
            Me.colorPickerButton1.UseVisualStyleBackColor = False
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.BackColor = System.Drawing.Color.Transparent
            Me.label3.ForeColor = System.Drawing.Color.Black
            Me.label3.Location = New System.Drawing.Point(277, 63)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(31, 13)
            Me.label3.TabIndex = 0
            Me.label3.Text = "Type"
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.Color.Transparent
            Me.label1.ForeColor = System.Drawing.Color.Black
            Me.label1.Location = New System.Drawing.Point(57, 66)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(27, 13)
            Me.label1.TabIndex = 101
            Me.label1.Text = "Size"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'imageListAdv1
            '
            Me.imageListAdv1.Images.AddRange(New System.Drawing.Image() {CType(resources.GetObject("imageListAdv1.Images"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images1"), System.Drawing.Image)})
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(515, 495)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Symbols"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private WithEvents cmbSymbolStyle As System.Windows.Forms.ComboBox
		Private panel1 As System.Windows.Forms.Panel
		Private label3 As System.Windows.Forms.Label
		Private imageListAdv1 As Syncfusion.Windows.Forms.Tools.ImageListAdv
		Private label2 As System.Windows.Forms.Label
		Private panel2 As System.Windows.Forms.Panel
		Private textBox1 As System.Windows.Forms.TextBox
		Private WithEvents colorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
		Private label1 As System.Windows.Forms.Label
		Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
		Private radioButton2 As System.Windows.Forms.RadioButton
		Private radioButton1 As System.Windows.Forms.RadioButton
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private toolTip1 As System.Windows.Forms.ToolTip
		Private label30 As System.Windows.Forms.Label
    End Class
End Namespace

