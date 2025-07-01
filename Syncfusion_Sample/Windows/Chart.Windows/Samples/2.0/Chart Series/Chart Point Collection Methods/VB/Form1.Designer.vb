Imports Microsoft.VisualBasic
Imports System
Namespace ChartPointCollectionMethods_2005
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.panel2 = New System.Windows.Forms.Panel
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.panel1 = New System.Windows.Forms.Panel
            Me.rdBtnFindMinValue = New System.Windows.Forms.RadioButton
            Me.rdBtnFindMaxValue = New System.Windows.Forms.RadioButton
            Me.rdBtnFindValue = New System.Windows.Forms.RadioButton
            Me.label6 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.label25 = New System.Windows.Forms.Label
            Me.label10 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.label4 = New System.Windows.Forms.Label
            Me.cbBxFindValue = New System.Windows.Forms.ComboBox
            Me.cbBxFindMaxValue = New System.Windows.Forms.ComboBox
            Me.txBxResult = New System.Windows.Forms.TextBox
            Me.cbBxFindMinValue = New System.Windows.Forms.ComboBox
            Me.txBxIndex = New System.Windows.Forms.TextBox
            Me.btnResult = New System.Windows.Forms.Button
            Me.txBxString = New System.Windows.Forms.TextBox
            Me.label2 = New System.Windows.Forms.Label
            Me.txBxValue = New System.Windows.Forms.TextBox
            Me.label3 = New System.Windows.Forms.Label
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel2.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel2
            '
            Me.panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel2.BackColor = System.Drawing.Color.White
            Me.panel2.Controls.Add(Me.groupBox1)
            Me.panel2.Controls.Add(Me.label6)
            Me.panel2.Controls.Add(Me.label5)
            Me.panel2.Controls.Add(Me.label25)
            Me.panel2.Controls.Add(Me.label10)
            Me.panel2.Controls.Add(Me.label1)
            Me.panel2.Controls.Add(Me.textBox1)
            Me.panel2.Controls.Add(Me.label4)
            Me.panel2.Controls.Add(Me.cbBxFindValue)
            Me.panel2.Controls.Add(Me.cbBxFindMaxValue)
            Me.panel2.Controls.Add(Me.txBxResult)
            Me.panel2.Controls.Add(Me.cbBxFindMinValue)
            Me.panel2.Controls.Add(Me.txBxIndex)
            Me.panel2.Controls.Add(Me.btnResult)
            Me.panel2.Controls.Add(Me.txBxString)
            Me.panel2.Controls.Add(Me.label2)
            Me.panel2.Controls.Add(Me.txBxValue)
            Me.panel2.Controls.Add(Me.label3)
            Me.panel2.Location = New System.Drawing.Point(502, -2)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(318, 394)
            Me.panel2.TabIndex = 17
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.panel1)
            Me.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.groupBox1.Location = New System.Drawing.Point(13, 36)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(197, 116)
            Me.groupBox1.TabIndex = 63
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Point collection methods"
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.rdBtnFindMinValue)
            Me.panel1.Controls.Add(Me.rdBtnFindMaxValue)
            Me.panel1.Controls.Add(Me.rdBtnFindValue)
            Me.panel1.Location = New System.Drawing.Point(11, 15)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(175, 88)
            Me.panel1.TabIndex = 1
            '
            'rdBtnFindMinValue
            '
            Me.rdBtnFindMinValue.AutoSize = True
            Me.rdBtnFindMinValue.ForeColor = System.Drawing.Color.MidnightBlue
            Me.rdBtnFindMinValue.Location = New System.Drawing.Point(14, 60)
            Me.rdBtnFindMinValue.Name = "rdBtnFindMinValue"
            Me.rdBtnFindMinValue.Size = New System.Drawing.Size(89, 17)
            Me.rdBtnFindMinValue.TabIndex = 2
            Me.rdBtnFindMinValue.TabStop = True
            Me.rdBtnFindMinValue.Text = "FindMinValue"
            Me.rdBtnFindMinValue.UseVisualStyleBackColor = True
            '
            'rdBtnFindMaxValue
            '
            Me.rdBtnFindMaxValue.AutoSize = True
            Me.rdBtnFindMaxValue.ForeColor = System.Drawing.Color.MidnightBlue
            Me.rdBtnFindMaxValue.Location = New System.Drawing.Point(14, 37)
            Me.rdBtnFindMaxValue.Name = "rdBtnFindMaxValue"
            Me.rdBtnFindMaxValue.Size = New System.Drawing.Size(92, 17)
            Me.rdBtnFindMaxValue.TabIndex = 1
            Me.rdBtnFindMaxValue.TabStop = True
            Me.rdBtnFindMaxValue.Text = "FindMaxValue"
            Me.rdBtnFindMaxValue.UseVisualStyleBackColor = True
            '
            'rdBtnFindValue
            '
            Me.rdBtnFindValue.AutoSize = True
            Me.rdBtnFindValue.ForeColor = System.Drawing.Color.MidnightBlue
            Me.rdBtnFindValue.Location = New System.Drawing.Point(14, 14)
            Me.rdBtnFindValue.Name = "rdBtnFindValue"
            Me.rdBtnFindValue.Size = New System.Drawing.Size(72, 17)
            Me.rdBtnFindValue.TabIndex = 0
            Me.rdBtnFindValue.TabStop = True
            Me.rdBtnFindValue.Text = "FindValue"
            Me.rdBtnFindValue.UseVisualStyleBackColor = True
            '
            'label6
            '
            Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label6.Location = New System.Drawing.Point(175, 173)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(100, 1)
            Me.label6.TabIndex = 62
            '
            'label5
            '
            Me.label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label5.Image = CType(resources.GetObject("label5.Image"), System.Drawing.Image)
            Me.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label5.Location = New System.Drawing.Point(7, 160)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(162, 24)
            Me.label5.TabIndex = 61
            Me.label5.Text = "Select the method type"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label25
            '
            Me.label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label25.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label25.Image = CType(resources.GetObject("label25.Image"), System.Drawing.Image)
            Me.label25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label25.Location = New System.Drawing.Point(7, 3)
            Me.label25.Name = "label25"
            Me.label25.Size = New System.Drawing.Size(176, 24)
            Me.label25.TabIndex = 60
            Me.label25.Text = "Find Min and Max methods"
            Me.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label10
            '
            Me.label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label10.Location = New System.Drawing.Point(188, 17)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(100, 1)
            Me.label10.TabIndex = 59
            '
            'label1
            '
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Location = New System.Drawing.Point(7, 236)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(192, 21)
            Me.label1.TabIndex = 6
            Me.label1.Text = "Enter Value(600,400,300,550,500,200)"
            '
            'textBox1
            '
            Me.textBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.textBox1.Location = New System.Drawing.Point(146, 328)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(53, 20)
            Me.textBox1.TabIndex = 15
            '
            'label4
            '
            Me.label4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label4.Location = New System.Drawing.Point(7, 331)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(100, 15)
            Me.label4.TabIndex = 14
            Me.label4.Text = "End Index"
            '
            'cbBxFindValue
            '
            Me.cbBxFindValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbBxFindValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cbBxFindValue.ForeColor = System.Drawing.Color.MidnightBlue
            Me.cbBxFindValue.FormattingEnabled = True
            Me.cbBxFindValue.Items.AddRange(New Object() {"FindValue(Double)", "FindValue(Double, String)", "FindValue(Double, String, Index)", "FindValue(Double, String, Index, Index)"})
            Me.cbBxFindValue.Location = New System.Drawing.Point(10, 195)
            Me.cbBxFindValue.Name = "cbBxFindValue"
            Me.cbBxFindValue.Size = New System.Drawing.Size(200, 21)
            Me.cbBxFindValue.TabIndex = 2
            '
            'cbBxFindMaxValue
            '
            Me.cbBxFindMaxValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbBxFindMaxValue.ForeColor = System.Drawing.Color.MidnightBlue
            Me.cbBxFindMaxValue.FormattingEnabled = True
            Me.cbBxFindMaxValue.Items.AddRange(New Object() {"FindMaxValue()", "FindMaxValue(String)", "FindMaxValue(String, Index)", "FindMaxValue(String, Index, Index)"})
            Me.cbBxFindMaxValue.Location = New System.Drawing.Point(10, 196)
            Me.cbBxFindMaxValue.Name = "cbBxFindMaxValue"
            Me.cbBxFindMaxValue.Size = New System.Drawing.Size(200, 21)
            Me.cbBxFindMaxValue.TabIndex = 3
            '
            'txBxResult
            '
            Me.txBxResult.ForeColor = System.Drawing.Color.MidnightBlue
            Me.txBxResult.Location = New System.Drawing.Point(10, 365)
            Me.txBxResult.Name = "txBxResult"
            Me.txBxResult.ReadOnly = True
            Me.txBxResult.Size = New System.Drawing.Size(220, 20)
            Me.txBxResult.TabIndex = 12
            '
            'cbBxFindMinValue
            '
            Me.cbBxFindMinValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbBxFindMinValue.ForeColor = System.Drawing.Color.MidnightBlue
            Me.cbBxFindMinValue.FormattingEnabled = True
            Me.cbBxFindMinValue.Items.AddRange(New Object() {"FindMinValue()", "FindMinValue(String)", "FindMinValue(String, Index)", "FindMinValue(String, Index, Index)"})
            Me.cbBxFindMinValue.Location = New System.Drawing.Point(10, 196)
            Me.cbBxFindMinValue.Name = "cbBxFindMinValue"
            Me.cbBxFindMinValue.Size = New System.Drawing.Size(200, 21)
            Me.cbBxFindMinValue.TabIndex = 4
            '
            'txBxIndex
            '
            Me.txBxIndex.ForeColor = System.Drawing.Color.MidnightBlue
            Me.txBxIndex.Location = New System.Drawing.Point(146, 296)
            Me.txBxIndex.Name = "txBxIndex"
            Me.txBxIndex.Size = New System.Drawing.Size(53, 20)
            Me.txBxIndex.TabIndex = 11
            '
            'btnResult
            '
            Me.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnResult.ForeColor = System.Drawing.Color.MidnightBlue
            Me.btnResult.Location = New System.Drawing.Point(236, 362)
            Me.btnResult.Name = "btnResult"
            Me.btnResult.Size = New System.Drawing.Size(75, 23)
            Me.btnResult.TabIndex = 5
            Me.btnResult.Text = "Result"
            Me.btnResult.UseVisualStyleBackColor = True
            '
            'txBxString
            '
            Me.txBxString.ForeColor = System.Drawing.Color.MidnightBlue
            Me.txBxString.Location = New System.Drawing.Point(146, 263)
            Me.txBxString.Name = "txBxString"
            Me.txBxString.Size = New System.Drawing.Size(53, 20)
            Me.txBxString.TabIndex = 10
            '
            'label2
            '
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Location = New System.Drawing.Point(7, 265)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(133, 19)
            Me.label2.TabIndex = 7
            Me.label2.Text = "Enter String (like X,Y,Y1..)"
            '
            'txBxValue
            '
            Me.txBxValue.ForeColor = System.Drawing.Color.MidnightBlue
            Me.txBxValue.Location = New System.Drawing.Point(205, 234)
            Me.txBxValue.Name = "txBxValue"
            Me.txBxValue.Size = New System.Drawing.Size(100, 20)
            Me.txBxValue.TabIndex = 9
            '
            'label3
            '
            Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label3.Location = New System.Drawing.Point(7, 298)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(100, 14)
            Me.label3.TabIndex = 8
            Me.label3.Text = "Start Index"
            '
            'chartControl1
            '
            Me.chartControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer)))
            '
            '
            '
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)))
            Me.chartControl1.Legend.Location = New System.Drawing.Point(375, 31)
            Me.chartControl1.Location = New System.Drawing.Point(7, 14)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.Size = New System.Drawing.Size(484, 364)
            Me.chartControl1.TabIndex = 1
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = ""
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(815, 391)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Point Collection Methods"
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.groupBox1.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private panel2 As System.Windows.Forms.Panel
		Private label25 As System.Windows.Forms.Label
		Private label10 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private textBox1 As System.Windows.Forms.TextBox
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents rdBtnFindMinValue As System.Windows.Forms.RadioButton
		Private WithEvents rdBtnFindMaxValue As System.Windows.Forms.RadioButton
		Private WithEvents rdBtnFindValue As System.Windows.Forms.RadioButton
		Private label4 As System.Windows.Forms.Label
		Private WithEvents cbBxFindValue As System.Windows.Forms.ComboBox
		Private WithEvents cbBxFindMaxValue As System.Windows.Forms.ComboBox
		Private txBxResult As System.Windows.Forms.TextBox
		Private WithEvents cbBxFindMinValue As System.Windows.Forms.ComboBox
		Private txBxIndex As System.Windows.Forms.TextBox
		Private WithEvents btnResult As System.Windows.Forms.Button
		Private txBxString As System.Windows.Forms.TextBox
		Private label2 As System.Windows.Forms.Label
		Private txBxValue As System.Windows.Forms.TextBox
		Private label3 As System.Windows.Forms.Label
        Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private groupBox1 As System.Windows.Forms.GroupBox
	End Class
End Namespace

