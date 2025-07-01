Imports Microsoft.VisualBasic
Imports System
Namespace HighlightingSeries
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
            Dim ChartToolBarSaveItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem
            Dim ChartToolBarCopyItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem
            Dim ChartToolBarPrintItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem
            Dim ChartToolBarPrintPreviewItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem
            Dim ChartToolBarSplitter1 As Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter = New Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter
            Dim ChartToolBarPaletteItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem
            Dim ChartToolBarStyleItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem
            Dim ChartToolBarTypeItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem
            Dim ChartToolBarSeries3DItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem
            Dim ChartToolBarShowLegendItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.ColumnDrawMode = New System.Windows.Forms.ComboBox
            Me.label2 = New System.Windows.Forms.Label
            Me.cmbChartType = New System.Windows.Forms.ComboBox
            Me.label1 = New System.Windows.Forms.Label
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.Hidden_Specific = New System.Windows.Forms.RadioButton
            Me.Hidden_Auto = New System.Windows.Forms.RadioButton
            Me.label4 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.label5 = New System.Windows.Forms.Label
            Me.panel1 = New System.Windows.Forms.Panel
            Me.colorPickerButton2 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.label22 = New System.Windows.Forms.Label
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.label21 = New System.Windows.Forms.Label
            Me.radioButton2 = New System.Windows.Forms.RadioButton
            Me.panel2 = New System.Windows.Forms.Panel
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White)
            Me.chartControl1.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.chartControl1.Font = New System.Drawing.Font("Verdana", 8.0!)
            '
            '
            '
            Me.chartControl1.Legend.Location = New System.Drawing.Point(58, 75)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.Location = New System.Drawing.Point(11, 13)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryYAxis.ForceZero = True
            Me.chartControl1.SeriesHighlightIndex = -1
            Me.chartControl1.Size = New System.Drawing.Size(438, 319)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "Essential Chart"
            '
            '
            '
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarSaveItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarCopyItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarPrintItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarPrintPreviewItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarSplitter1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarPaletteItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarStyleItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarTypeItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarSeries3DItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarShowLegendItem1)
            '
            'ColumnDrawMode
            '
            Me.ColumnDrawMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ColumnDrawMode.FormattingEnabled = True
            Me.ColumnDrawMode.Items.AddRange(New Object() {"PlaneMode", "InDepthMode", "ClusteredMode"})
            Me.ColumnDrawMode.Location = New System.Drawing.Point(553, 228)
            Me.ColumnDrawMode.Name = "ColumnDrawMode"
            Me.ColumnDrawMode.Size = New System.Drawing.Size(109, 21)
            Me.ColumnDrawMode.TabIndex = 8
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(457, 233)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(96, 13)
            Me.label2.TabIndex = 7
            Me.label2.Text = "Column Drawmode"
            '
            'cmbChartType
            '
            Me.cmbChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbChartType.FormattingEnabled = True
            Me.cmbChartType.Items.AddRange(New Object() {"SplineArea", "Column"})
            Me.cmbChartType.Location = New System.Drawing.Point(552, 193)
            Me.cmbChartType.Name = "cmbChartType"
            Me.cmbChartType.Size = New System.Drawing.Size(110, 21)
            Me.cmbChartType.TabIndex = 6
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(458, 196)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(59, 13)
            Me.label1.TabIndex = 5
            Me.label1.Text = "Chart Type"
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.Location = New System.Drawing.Point(460, 302)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(66, 17)
            Me.checkBox1.TabIndex = 9
            Me.checkBox1.Text = "3D View"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'colorPickerButton1
            '
            Me.colorPickerButton1.BackColor = System.Drawing.Color.Transparent
            Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton1.Location = New System.Drawing.Point(152, 42)
            Me.colorPickerButton1.Name = "colorPickerButton1"
            Me.colorPickerButton1.SelectedAsBackcolor = True
            Me.colorPickerButton1.SelectedColor = System.Drawing.Color.Transparent
            Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton1.Size = New System.Drawing.Size(20, 20)
            Me.colorPickerButton1.TabIndex = 18
            Me.colorPickerButton1.Text = "..."
            Me.colorPickerButton1.UseVisualStyleBackColor = False
            '
            'Hidden_Specific
            '
            Me.Hidden_Specific.AutoSize = True
            Me.Hidden_Specific.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Hidden_Specific.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.Hidden_Specific.Location = New System.Drawing.Point(93, 43)
            Me.Hidden_Specific.Name = "Hidden_Specific"
            Me.Hidden_Specific.Size = New System.Drawing.Size(69, 18)
            Me.Hidden_Specific.TabIndex = 17
            Me.Hidden_Specific.Text = "Specific"
            '
            'Hidden_Auto
            '
            Me.Hidden_Auto.AutoSize = True
            Me.Hidden_Auto.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Hidden_Auto.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.Hidden_Auto.Location = New System.Drawing.Point(8, 41)
            Me.Hidden_Auto.Name = "Hidden_Auto"
            Me.Hidden_Auto.Size = New System.Drawing.Size(78, 18)
            Me.Hidden_Auto.TabIndex = 16
            Me.Hidden_Auto.Text = "Automatic"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.BackColor = System.Drawing.Color.Transparent
            Me.label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label4.Location = New System.Drawing.Point(3, 9)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(122, 14)
            Me.label4.TabIndex = 19
            Me.label4.Text = "Dimmed Interior Color"
            '
            'label3
            '
            Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label3.Location = New System.Drawing.Point(8, 29)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(172, 1)
            Me.label3.TabIndex = 20
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.Location = New System.Drawing.Point(456, 17)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(99, 17)
            Me.checkBox2.TabIndex = 21
            Me.checkBox2.Text = "Series Highlight"
            Me.checkBox2.UseVisualStyleBackColor = True
            '
            'numericUpDown1
            '
            Me.numericUpDown1.Increment = New Decimal(New Integer() {20, 0, 0, 0})
            Me.numericUpDown1.Location = New System.Drawing.Point(553, 263)
            Me.numericUpDown1.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.Size = New System.Drawing.Size(109, 20)
            Me.numericUpDown1.TabIndex = 22
            Me.numericUpDown1.Value = New Decimal(New Integer() {255, 0, 0, 0})
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(457, 265)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(64, 13)
            Me.label5.TabIndex = 23
            Me.label5.Text = "Aphla Value"
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.colorPickerButton2)
            Me.panel1.Controls.Add(Me.label22)
            Me.panel1.Controls.Add(Me.radioButton1)
            Me.panel1.Controls.Add(Me.label21)
            Me.panel1.Controls.Add(Me.radioButton2)
            Me.panel1.Location = New System.Drawing.Point(455, 42)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(200, 68)
            Me.panel1.TabIndex = 24
            '
            'colorPickerButton2
            '
            Me.colorPickerButton2.BackColor = System.Drawing.Color.Transparent
            Me.colorPickerButton2.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton2.Location = New System.Drawing.Point(151, 43)
            Me.colorPickerButton2.Name = "colorPickerButton2"
            Me.colorPickerButton2.SelectedAsBackcolor = True
            Me.colorPickerButton2.SelectedColor = System.Drawing.Color.Transparent
            Me.colorPickerButton2.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton2.Size = New System.Drawing.Size(20, 20)
            Me.colorPickerButton2.TabIndex = 18
            Me.colorPickerButton2.Text = "..."
            Me.colorPickerButton2.UseVisualStyleBackColor = False
            '
            'label22
            '
            Me.label22.AutoSize = True
            Me.label22.BackColor = System.Drawing.Color.Transparent
            Me.label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label22.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label22.Location = New System.Drawing.Point(2, 10)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(132, 14)
            Me.label22.TabIndex = 19
            Me.label22.Text = "Highlight Interior Color"
            '
            'radioButton1
            '
            Me.radioButton1.AutoSize = True
            Me.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton1.Location = New System.Drawing.Point(6, 43)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(78, 18)
            Me.radioButton1.TabIndex = 16
            Me.radioButton1.Text = "Automatic"
            '
            'label21
            '
            Me.label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label21.Location = New System.Drawing.Point(4, 34)
            Me.label21.Name = "label21"
            Me.label21.Size = New System.Drawing.Size(172, 1)
            Me.label21.TabIndex = 20
            '
            'radioButton2
            '
            Me.radioButton2.AutoSize = True
            Me.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton2.Location = New System.Drawing.Point(91, 43)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(69, 18)
            Me.radioButton2.TabIndex = 17
            Me.radioButton2.Text = "Specific"
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.colorPickerButton1)
            Me.panel2.Controls.Add(Me.label4)
            Me.panel2.Controls.Add(Me.Hidden_Specific)
            Me.panel2.Controls.Add(Me.Hidden_Auto)
            Me.panel2.Controls.Add(Me.label3)
            Me.panel2.Location = New System.Drawing.Point(455, 116)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(200, 69)
            Me.panel2.TabIndex = 25
            '
            'Form1
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(678, 349)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.numericUpDown1)
            Me.Controls.Add(Me.checkBox2)
            Me.Controls.Add(Me.checkBox1)
            Me.Controls.Add(Me.ColumnDrawMode)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.cmbChartType)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Series Highlight"
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region
		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private WithEvents ColumnDrawMode As System.Windows.Forms.ComboBox
		Private label2 As System.Windows.Forms.Label
		Private WithEvents cmbChartType As System.Windows.Forms.ComboBox
		Private label1 As System.Windows.Forms.Label
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private colorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
		Private WithEvents Hidden_Specific As System.Windows.Forms.RadioButton
		Private WithEvents Hidden_Auto As System.Windows.Forms.RadioButton
		Private label4 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
		Private numericUpDown1 As System.Windows.Forms.NumericUpDown
		Private label5 As System.Windows.Forms.Label
		Private panel1 As System.Windows.Forms.Panel
		Private colorPickerButton2 As Syncfusion.Windows.Forms.ColorPickerButton
		Private label22 As System.Windows.Forms.Label
		Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
		Private label21 As System.Windows.Forms.Label
		Private radioButton2 As System.Windows.Forms.RadioButton
		Private panel2 As System.Windows.Forms.Panel
	End Class
End Namespace

