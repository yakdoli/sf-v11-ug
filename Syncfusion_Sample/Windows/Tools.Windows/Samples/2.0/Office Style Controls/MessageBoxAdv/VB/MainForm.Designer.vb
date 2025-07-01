#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Namespace MessageBoxAdv_2005
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.radioButtonAdv1 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.radioButtonAdv2 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.radioButtonAdv3 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.label19 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.label20 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.label3 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.popupControlContainer1 = New Syncfusion.Windows.Forms.PopupControlContainer(Me.components)
            Me.colorPickerUIAdv1 = New Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv
            Me.imageListAdv1 = New Syncfusion.Windows.Forms.Tools.ImageListAdv(Me.components)
            Me.radioButtonAdv4 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.comboBoxAdv2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.gradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel
            Me.label5 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.panel1 = New System.Windows.Forms.Panel
            Me.label7 = New System.Windows.Forms.Label
            Me.label8 = New System.Windows.Forms.Label
            Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.radioButtonAdv5 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.radioButtonAdv6 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.panel2 = New System.Windows.Forms.Panel
            CType(Me.radioButtonAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupControlContainer1.SuspendLayout()
            CType(Me.radioButtonAdv4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'radioButtonAdv1
            '
            Me.radioButtonAdv1.AutoHeight = True
            Me.radioButtonAdv1.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv1.Checked = True
            Me.radioButtonAdv1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.radioButtonAdv1.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv1.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv1.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv1.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv1.Location = New System.Drawing.Point(48, 150)
            Me.radioButtonAdv1.Name = "radioButtonAdv1"
            Me.radioButtonAdv1.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv1.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv1.Size = New System.Drawing.Size(102, 17)
            Me.radioButtonAdv1.TabIndex = 0
            Me.radioButtonAdv1.Text = "Blue"
            Me.radioButtonAdv1.ThemesEnabled = True
            '
            'radioButtonAdv2
            '
            Me.radioButtonAdv2.AutoHeight = True
            Me.radioButtonAdv2.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.radioButtonAdv2.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv2.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv2.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv2.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv2.Location = New System.Drawing.Point(48, 181)
            Me.radioButtonAdv2.Name = "radioButtonAdv2"
            Me.radioButtonAdv2.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv2.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv2.Size = New System.Drawing.Size(102, 17)
            Me.radioButtonAdv2.TabIndex = 1
            Me.radioButtonAdv2.Text = "Silver"
            Me.radioButtonAdv2.ThemesEnabled = True
            '
            'radioButtonAdv3
            '
            Me.radioButtonAdv3.AutoHeight = True
            Me.radioButtonAdv3.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.radioButtonAdv3.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv3.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv3.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv3.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv3.Location = New System.Drawing.Point(48, 212)
            Me.radioButtonAdv3.Name = "radioButtonAdv3"
            Me.radioButtonAdv3.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv3.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv3.Size = New System.Drawing.Size(102, 17)
            Me.radioButtonAdv3.TabIndex = 2
            Me.radioButtonAdv3.Text = "Black "
            Me.radioButtonAdv3.ThemesEnabled = True
            '
            'label19
            '
            Me.label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label19.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label19.Image = CType(resources.GetObject("label19.Image"), System.Drawing.Image)
            Me.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label19.Location = New System.Drawing.Point(21, 110)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(108, 23)
            Me.label19.TabIndex = 24
            Me.label19.Text = "Color Schemes"
            Me.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Image = CType(resources.GetObject("label1.Image"), System.Drawing.Image)
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label1.Location = New System.Drawing.Point(424, 110)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(53, 23)
            Me.label1.TabIndex = 25
            Me.label1.Text = "Icon"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label20
            '
            Me.label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label20.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label20.Location = New System.Drawing.Point(21, 136)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(150, 1)
            Me.label20.TabIndex = 26
            '
            'label2
            '
            Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Location = New System.Drawing.Point(424, 136)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(150, 1)
            Me.label2.TabIndex = 27
            '
            'buttonAdv1
            '
            Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv1.Location = New System.Drawing.Point(217, 25)
            Me.buttonAdv1.Name = "buttonAdv1"
            Me.buttonAdv1.Size = New System.Drawing.Size(120, 47)
            Me.buttonAdv1.TabIndex = 29
            Me.buttonAdv1.Text = "Click here to view MessageBoxAdv"
            Me.buttonAdv1.UseVisualStyle = True
            '
            'label3
            '
            Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label3.Location = New System.Drawing.Point(214, 136)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(150, 1)
            Me.label3.TabIndex = 31
            '
            'label4
            '
            Me.label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label4.Image = CType(resources.GetObject("label4.Image"), System.Drawing.Image)
            Me.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label4.Location = New System.Drawing.Point(214, 110)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(108, 23)
            Me.label4.TabIndex = 30
            Me.label4.Text = "Custom Colors"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'buttonAdv2
            '
            Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv2.Dock = System.Windows.Forms.DockStyle.Right
            Me.buttonAdv2.Image = CType(resources.GetObject("buttonAdv2.Image"), System.Drawing.Image)
            Me.buttonAdv2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.buttonAdv2.Location = New System.Drawing.Point(81, 0)
            Me.buttonAdv2.Name = "buttonAdv2"
            Me.buttonAdv2.Size = New System.Drawing.Size(26, 24)
            Me.buttonAdv2.TabIndex = 33
            Me.buttonAdv2.UseVisualStyle = True
            '
            'popupControlContainer1
            '
            Me.popupControlContainer1.BackColor = System.Drawing.Color.Transparent
            Me.popupControlContainer1.Controls.Add(Me.colorPickerUIAdv1)
            Me.popupControlContainer1.Location = New System.Drawing.Point(229, 284)
            Me.popupControlContainer1.Name = "popupControlContainer1"
            Me.popupControlContainer1.ParentControl = Me.buttonAdv2
            Me.popupControlContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.popupControlContainer1.Size = New System.Drawing.Size(173, 195)
            Me.popupControlContainer1.TabIndex = 123
            Me.popupControlContainer1.Visible = False
            '
            'colorPickerUIAdv1.RecentGroup
            '
            Me.colorPickerUIAdv1.RecentGroup.Name = "Recent Colors"
            Me.colorPickerUIAdv1.RecentGroup.Visible = False
            '
            'colorPickerUIAdv1.StandardGroup
            '
            Me.colorPickerUIAdv1.StandardGroup.Name = "Standard Colors"
            '
            'colorPickerUIAdv1.ThemeGroup
            '
            Me.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = True
            Me.colorPickerUIAdv1.ThemeGroup.Name = "Theme Colors"
            '
            'colorPickerUIAdv1
            '
            Me.colorPickerUIAdv1.ColorItemSize = New System.Drawing.Size(13, 13)
            Me.colorPickerUIAdv1.Dock = System.Windows.Forms.DockStyle.Top
            Me.colorPickerUIAdv1.Location = New System.Drawing.Point(0, 0)
            Me.colorPickerUIAdv1.MinimumSize = New System.Drawing.Size(136, 195)
            Me.colorPickerUIAdv1.Name = "colorPickerUIAdv1"
            Me.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.Empty
            Me.colorPickerUIAdv1.Size = New System.Drawing.Size(173, 195)
            Me.colorPickerUIAdv1.TabIndex = 0
            Me.colorPickerUIAdv1.Text = "colorPickerUIAdv1"
            '
            'imageListAdv1
            '
            Me.imageListAdv1.Images.AddRange(New System.Drawing.Image() {CType(resources.GetObject("imageListAdv1.Images"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images1"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images2"), System.Drawing.Image)})
            '
            'radioButtonAdv4
            '
            Me.radioButtonAdv4.AutoHeight = True
            Me.radioButtonAdv4.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.radioButtonAdv4.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv4.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv4.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv4.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv4.Location = New System.Drawing.Point(48, 243)
            Me.radioButtonAdv4.Name = "radioButtonAdv4"
            Me.radioButtonAdv4.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv4.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv4.Size = New System.Drawing.Size(102, 17)
            Me.radioButtonAdv4.TabIndex = 124
            Me.radioButtonAdv4.Text = "Managed"
            Me.radioButtonAdv4.ThemesEnabled = True
            '
            'comboBoxAdv2
            '
            Me.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxAdv2.Enabled = False
            Me.comboBoxAdv2.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.System
            Me.comboBoxAdv2.IgnoreThemeBackground = True
            Me.comboBoxAdv2.Items.AddRange(New Object() {"Help", "Document Error", "Warning", "None"})
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "Help"))
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "Document Error"))
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "Warning"))
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "None"))
            Me.comboBoxAdv2.Location = New System.Drawing.Point(436, 253)
            Me.comboBoxAdv2.Name = "comboBoxAdv2"
            Me.comboBoxAdv2.Size = New System.Drawing.Size(121, 21)
            Me.comboBoxAdv2.TabIndex = 125
            Me.comboBoxAdv2.Text = "Help"
            '
            'gradientLabel1
            '
            Me.gradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White)
            Me.gradientLabel1.BorderSides = CType(((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) _
                        Or System.Windows.Forms.Border3DSide.Right) _
                        Or System.Windows.Forms.Border3DSide.Bottom) _
                        Or System.Windows.Forms.Border3DSide.Middle), System.Windows.Forms.Border3DSide)
            Me.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gradientLabel1.Location = New System.Drawing.Point(0, 0)
            Me.gradientLabel1.Name = "gradientLabel1"
            Me.gradientLabel1.Size = New System.Drawing.Size(81, 24)
            Me.gradientLabel1.TabIndex = 126
            Me.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(214, 162)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(64, 13)
            Me.label5.TabIndex = 127
            Me.label5.Text = "Select Color"
            '
            'label6
            '
            Me.label6.Image = CType(resources.GetObject("label6.Image"), System.Drawing.Image)
            Me.label6.Location = New System.Drawing.Point(330, 184)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(19, 23)
            Me.label6.TabIndex = 128
            Me.toolTip1.SetToolTip(Me.label6, "Custom Color is applicable only when the Color Scheme is set as Managed")
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.gradientLabel1)
            Me.panel1.Controls.Add(Me.buttonAdv2)
            Me.panel1.Location = New System.Drawing.Point(217, 181)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(107, 24)
            Me.panel1.TabIndex = 129
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(433, 234)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(107, 13)
            Me.label7.TabIndex = 130
            Me.label7.Text = "Select Custom Image"
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Location = New System.Drawing.Point(433, 181)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(98, 13)
            Me.label8.TabIndex = 132
            Me.label8.Text = "Select Default Icon"
            '
            'comboBoxAdv1
            '
            Me.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxAdv1.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.System
            Me.comboBoxAdv1.IgnoreThemeBackground = True
            Me.comboBoxAdv1.Items.AddRange(New Object() {"Stop", "Question", "Exclamation", "Asterisk"})
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Stop"))
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Question"))
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Exclamation"))
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Asterisk"))
            Me.comboBoxAdv1.Location = New System.Drawing.Point(436, 200)
            Me.comboBoxAdv1.Name = "comboBoxAdv1"
            Me.comboBoxAdv1.Size = New System.Drawing.Size(121, 21)
            Me.comboBoxAdv1.TabIndex = 131
            Me.comboBoxAdv1.Text = "Stop"
            '
            'radioButtonAdv5
            '
            Me.radioButtonAdv5.AutoHeight = True
            Me.radioButtonAdv5.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv5.Checked = True
            Me.radioButtonAdv5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.radioButtonAdv5.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv5.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv5.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv5.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv5.Location = New System.Drawing.Point(3, 3)
            Me.radioButtonAdv5.Name = "radioButtonAdv5"
            Me.radioButtonAdv5.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv5.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv5.Size = New System.Drawing.Size(59, 17)
            Me.radioButtonAdv5.TabIndex = 133
            Me.radioButtonAdv5.Text = "Default"
            Me.radioButtonAdv5.ThemesEnabled = True
            '
            'radioButtonAdv6
            '
            Me.radioButtonAdv6.AutoHeight = True
            Me.radioButtonAdv6.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.radioButtonAdv6.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv6.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv6.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv6.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv6.Location = New System.Drawing.Point(77, 3)
            Me.radioButtonAdv6.Name = "radioButtonAdv6"
            Me.radioButtonAdv6.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv6.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv6.Size = New System.Drawing.Size(63, 17)
            Me.radioButtonAdv6.TabIndex = 134
            Me.radioButtonAdv6.Text = "Custom"
            Me.radioButtonAdv6.ThemesEnabled = True
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.radioButtonAdv5)
            Me.panel2.Controls.Add(Me.radioButtonAdv6)
            Me.panel2.Location = New System.Drawing.Point(427, 147)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(147, 28)
            Me.panel2.TabIndex = 135
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(586, 280)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.label8)
            Me.Controls.Add(Me.comboBoxAdv1)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.comboBoxAdv2)
            Me.Controls.Add(Me.radioButtonAdv4)
            Me.Controls.Add(Me.popupControlContainer1)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.buttonAdv1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label20)
            Me.Controls.Add(Me.label19)
            Me.Controls.Add(Me.radioButtonAdv1)
            Me.Controls.Add(Me.radioButtonAdv3)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.radioButtonAdv2)
            Me.ForeColor = System.Drawing.Color.Navy
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.HelpButton = True
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Location = New System.Drawing.Point(250, 450)
            Me.MaximizeBox = False
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "MessageBoxAdv"
            CType(Me.radioButtonAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupControlContainer1.ResumeLayout(False)
            CType(Me.radioButtonAdv4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private WithEvents radioButtonAdv1 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents radioButtonAdv2 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents radioButtonAdv3 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private label19 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private label20 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private WithEvents buttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private WithEvents buttonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
		Private popupControlContainer1 As Syncfusion.Windows.Forms.PopupControlContainer
		Private WithEvents colorPickerUIAdv1 As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv
		Private imageListAdv1 As Syncfusion.Windows.Forms.Tools.ImageListAdv
		Private WithEvents radioButtonAdv4 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private comboBoxAdv2 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private gradientLabel1 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private toolTip1 As System.Windows.Forms.ToolTip
		Private panel1 As System.Windows.Forms.Panel
		Private label7 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private comboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private WithEvents radioButtonAdv5 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private radioButtonAdv6 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private panel2 As System.Windows.Forms.Panel
	End Class
End Namespace