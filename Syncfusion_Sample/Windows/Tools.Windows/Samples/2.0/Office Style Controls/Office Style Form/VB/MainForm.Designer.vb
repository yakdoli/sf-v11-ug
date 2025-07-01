#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Namespace Office2007Form_2005
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.radioButtonAdv1 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.radioButtonAdv2 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.radioButtonAdv3 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.checkBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.label19 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.label20 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.checkBoxAdv3 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.label3 = New System.Windows.Forms.Label
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label4 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.comboBox3 = New System.Windows.Forms.ComboBox
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.Label7 = New System.Windows.Forms.Label
            Me.ColorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton
            CType(Me.radioButtonAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'radioButtonAdv1
            '
            Me.radioButtonAdv1.AutoHeight = True
            Me.radioButtonAdv1.Checked = True
            Me.radioButtonAdv1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.radioButtonAdv1.Location = New System.Drawing.Point(229, 60)
            Me.radioButtonAdv1.Name = "radioButtonAdv1"
            Me.radioButtonAdv1.Size = New System.Drawing.Size(102, 17)
            Me.radioButtonAdv1.TabIndex = 0
            Me.radioButtonAdv1.Text = "Blue"
            Me.radioButtonAdv1.ThemesEnabled = True
            '
            'radioButtonAdv2
            '
            Me.radioButtonAdv2.AutoHeight = True
            Me.radioButtonAdv2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.radioButtonAdv2.Location = New System.Drawing.Point(229, 91)
            Me.radioButtonAdv2.Name = "radioButtonAdv2"
            Me.radioButtonAdv2.Size = New System.Drawing.Size(102, 17)
            Me.radioButtonAdv2.TabIndex = 1
            Me.radioButtonAdv2.Text = "Silver"
            Me.radioButtonAdv2.ThemesEnabled = True
            '
            'radioButtonAdv3
            '
            Me.radioButtonAdv3.AutoHeight = True
            Me.radioButtonAdv3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.radioButtonAdv3.Location = New System.Drawing.Point(229, 123)
            Me.radioButtonAdv3.Name = "radioButtonAdv3"
            Me.radioButtonAdv3.Size = New System.Drawing.Size(102, 17)
            Me.radioButtonAdv3.TabIndex = 2
            Me.radioButtonAdv3.Text = "Black "
            Me.radioButtonAdv3.ThemesEnabled = True
            '
            'checkBoxAdv1
            '
            Me.checkBoxAdv1.AutoHeight = True
            Me.checkBoxAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.checkBoxAdv1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.checkBoxAdv1.Location = New System.Drawing.Point(42, 58)
            Me.checkBoxAdv1.Name = "checkBoxAdv1"
            Me.checkBoxAdv1.Size = New System.Drawing.Size(125, 17)
            Me.checkBoxAdv1.TabIndex = 3
            Me.checkBoxAdv1.Text = "Show Help Button"
            Me.checkBoxAdv1.ThemesEnabled = True
            '
            'checkBoxAdv2
            '
            Me.checkBoxAdv2.AutoHeight = True
            Me.checkBoxAdv2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.checkBoxAdv2.Location = New System.Drawing.Point(42, 121)
            Me.checkBoxAdv2.Name = "checkBoxAdv2"
            Me.checkBoxAdv2.Size = New System.Drawing.Size(125, 17)
            Me.checkBoxAdv2.TabIndex = 4
            Me.checkBoxAdv2.Text = "Right To Left"
            Me.checkBoxAdv2.ThemesEnabled = True
            '
            'label19
            '
            Me.label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label19.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label19.Image = CType(resources.GetObject("label19.Image"), System.Drawing.Image)
            Me.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label19.Location = New System.Drawing.Point(229, 24)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(132, 19)
            Me.label19.TabIndex = 24
            Me.label19.Text = "Office Style Themes"
            Me.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Image = CType(resources.GetObject("label1.Image"), System.Drawing.Image)
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label1.Location = New System.Drawing.Point(42, 24)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(90, 18)
            Me.label1.TabIndex = 25
            Me.label1.Text = "Properties"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label20
            '
            Me.label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label20.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label20.Location = New System.Drawing.Point(229, 46)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(125, 1)
            Me.label20.TabIndex = 26
            '
            'label2
            '
            Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Location = New System.Drawing.Point(42, 44)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(125, 1)
            Me.label2.TabIndex = 27
            '
            'checkBoxAdv3
            '
            Me.checkBoxAdv3.AutoHeight = True
            Me.checkBoxAdv3.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.checkBoxAdv3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.checkBoxAdv3.Location = New System.Drawing.Point(42, 89)
            Me.checkBoxAdv3.Name = "checkBoxAdv3"
            Me.checkBoxAdv3.Size = New System.Drawing.Size(125, 17)
            Me.checkBoxAdv3.TabIndex = 28
            Me.checkBoxAdv3.Text = "Show Icon"
            Me.checkBoxAdv3.ThemesEnabled = True
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(42, 247)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(92, 13)
            Me.label3.TabIndex = 29
            Me.label3.Text = "Caption Alignment"
            '
            'comboBox1
            '
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Items.AddRange(New Object() {"Left", "Center", "Right"})
            Me.comboBox1.Location = New System.Drawing.Point(146, 247)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(81, 21)
            Me.comboBox1.TabIndex = 30
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(42, 223)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(67, 13)
            Me.label4.TabIndex = 31
            Me.label4.Text = "Caption Font"
            '
            'label5
            '
            Me.label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label5.Location = New System.Drawing.Point(42, 202)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(300, 1)
            Me.label5.TabIndex = 34
            '
            'label6
            '
            Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label6.Image = CType(resources.GetObject("label6.Image"), System.Drawing.Image)
            Me.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label6.Location = New System.Drawing.Point(42, 177)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(121, 18)
            Me.label6.TabIndex = 33
            Me.label6.Text = "Caption Settings"
            Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'comboBox3
            '
            Me.comboBox3.FormattingEnabled = True
            Me.comboBox3.Location = New System.Drawing.Point(275, 220)
            Me.comboBox3.Name = "comboBox3"
            Me.comboBox3.Size = New System.Drawing.Size(56, 21)
            Me.comboBox3.TabIndex = 35
            Me.comboBox3.Text = "Bold"
            '
            'numericUpDown1
            '
            Me.numericUpDown1.Location = New System.Drawing.Point(234, 221)
            Me.numericUpDown1.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
            Me.numericUpDown1.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.Size = New System.Drawing.Size(35, 20)
            Me.numericUpDown1.TabIndex = 36
            Me.numericUpDown1.Value = New Decimal(New Integer() {10, 0, 0, 0})
            '
            'comboBox2
            '
            Me.comboBox2.FormattingEnabled = True
            Me.comboBox2.Items.AddRange(New Object() {"Arial", "Arial Black", "Book Antiqua", "Comic Sans MS", "Courier New", "Garamond", "Georgia", "Lucida Sans Unicode", "Microsoft Sans Serif", "MV Boli", "Script MT Bold", "TimesNewRoman", "Tahoma", "Verdana"})
            Me.comboBox2.Location = New System.Drawing.Point(146, 220)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(81, 21)
            Me.comboBox2.TabIndex = 32
            Me.comboBox2.Text = "Arial"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(42, 278)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(91, 13)
            Me.Label7.TabIndex = 37
            Me.Label7.Text = "Caption ForeColor"
            '
            'ColorPickerButton1
            '
            Me.ColorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
            Me.ColorPickerButton1.Location = New System.Drawing.Point(146, 275)
            Me.ColorPickerButton1.Name = "ColorPickerButton1"
            Me.ColorPickerButton1.Size = New System.Drawing.Size(81, 19)
            Me.ColorPickerButton1.TabIndex = 38
            Me.ColorPickerButton1.Text = "ColorPickerButton1"
            Me.ColorPickerButton1.UseVisualStyleBackColor = True
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.CaptionFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.ClientSize = New System.Drawing.Size(412, 307)
            Me.Controls.Add(Me.ColorPickerButton1)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.numericUpDown1)
            Me.Controls.Add(Me.comboBox3)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.comboBox2)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.comboBox1)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.checkBoxAdv3)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label20)
            Me.Controls.Add(Me.label19)
            Me.Controls.Add(Me.radioButtonAdv1)
            Me.Controls.Add(Me.radioButtonAdv3)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.radioButtonAdv2)
            Me.Controls.Add(Me.checkBoxAdv2)
            Me.Controls.Add(Me.checkBoxAdv1)
            Me.ForeColor = System.Drawing.Color.Navy
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.HelpButton = True
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Location = New System.Drawing.Point(250, 450)
            Me.MaximizeBox = False
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Office Style Form"
            CType(Me.radioButtonAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private WithEvents radioButtonAdv1 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents radioButtonAdv2 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents radioButtonAdv3 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents checkBoxAdv1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBoxAdv2 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private label19 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private label20 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private WithEvents checkBoxAdv3 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private label3 As System.Windows.Forms.Label
		Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private WithEvents comboBox3 As System.Windows.Forms.ComboBox
		Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
        Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents ColorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
	End Class
End Namespace