Imports Microsoft.VisualBasic
Imports System
Namespace ClockDemo_2008
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
            Dim MetroColorTabel1 As Syncfusion.Windows.Forms.MetroColorTabel = New Syncfusion.Windows.Forms.MetroColorTabel
            Dim ClockRenderer1 As Syncfusion.Windows.Forms.Tools.ClockRenderer = New Syncfusion.Windows.Forms.Tools.ClockRenderer
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.panel2 = New System.Windows.Forms.Panel
            Me.checkBoxAdv6 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.label4 = New System.Windows.Forms.Label
            Me.checkBoxAdv3 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.panel4 = New System.Windows.Forms.Panel
            Me.colorUIControl1 = New Syncfusion.Windows.Forms.ColorUIControl
            Me.radioButtonAdv6 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.checkBoxAdv4 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.radioButtonAdv5 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.label2 = New System.Windows.Forms.Label
            Me.checkBoxAdv2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.radioButtonAdv4 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.checkBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.radioButtonAdv3 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.radioButtonAdv2 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.radioButtonAdv1 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.panel3 = New System.Windows.Forms.Panel
            Me.checkBoxAdv5 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.label5 = New System.Windows.Forms.Label
            Me.pictureBox10 = New System.Windows.Forms.PictureBox
            Me.pictureBox9 = New System.Windows.Forms.PictureBox
            Me.pictureBox8 = New System.Windows.Forms.PictureBox
            Me.pictureBox7 = New System.Windows.Forms.PictureBox
            Me.pictureBox6 = New System.Windows.Forms.PictureBox
            Me.pictureBox5 = New System.Windows.Forms.PictureBox
            Me.pictureBox4 = New System.Windows.Forms.PictureBox
            Me.pictureBox3 = New System.Windows.Forms.PictureBox
            Me.pictureBox2 = New System.Windows.Forms.PictureBox
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.panel5 = New System.Windows.Forms.Panel
            Me.panel6 = New System.Windows.Forms.Panel
            Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.label1 = New System.Windows.Forms.Label
            Me.radioButtonAdv7 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.radioButtonAdv8 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.radioButtonAdv9 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.radioButtonAdv10 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.panel1 = New System.Windows.Forms.Panel
            Me.label7 = New System.Windows.Forms.Label
            Me.clock1 = New Syncfusion.Windows.Forms.Tools.Clock
            Me.panel2.SuspendLayout()
            CType(Me.checkBoxAdv6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel4.SuspendLayout()
            CType(Me.radioButtonAdv6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel3.SuspendLayout()
            CType(Me.checkBoxAdv5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel5.SuspendLayout()
            Me.panel6.SuspendLayout()
            CType(Me.radioButtonAdv7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv10, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel2
            '
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.Add(Me.checkBoxAdv6)
            Me.panel2.Controls.Add(Me.label4)
            Me.panel2.Controls.Add(Me.checkBoxAdv3)
            Me.panel2.Controls.Add(Me.panel4)
            Me.panel2.Controls.Add(Me.radioButtonAdv6)
            Me.panel2.Controls.Add(Me.checkBoxAdv4)
            Me.panel2.Controls.Add(Me.radioButtonAdv5)
            Me.panel2.Controls.Add(Me.label2)
            Me.panel2.Controls.Add(Me.checkBoxAdv2)
            Me.panel2.Controls.Add(Me.radioButtonAdv4)
            Me.panel2.Controls.Add(Me.checkBoxAdv1)
            Me.panel2.Controls.Add(Me.radioButtonAdv3)
            Me.panel2.Controls.Add(Me.radioButtonAdv2)
            Me.panel2.Controls.Add(Me.radioButtonAdv1)
            Me.panel2.Location = New System.Drawing.Point(284, 13)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(472, 231)
            Me.panel2.TabIndex = 1
            '
            'checkBoxAdv6
            '
            Me.checkBoxAdv6.DrawFocusRectangle = False
            Me.checkBoxAdv6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxAdv6.Location = New System.Drawing.Point(9, 39)
            Me.checkBoxAdv6.MetroColor = System.Drawing.Color.Black
            Me.checkBoxAdv6.Name = "checkBoxAdv6"
            Me.checkBoxAdv6.Size = New System.Drawing.Size(122, 22)
            Me.checkBoxAdv6.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv6.TabIndex = 18
            Me.checkBoxAdv6.Text = "Transparent Clock"
            Me.checkBoxAdv6.ThemesEnabled = False
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(147, 8)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(264, 15)
            Me.label4.TabIndex = 10
            Me.label4.Text = "Color setting (Choose colors form the pallette)"
            '
            'checkBoxAdv3
            '
            Me.checkBoxAdv3.Checked = True
            Me.checkBoxAdv3.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv3.DrawFocusRectangle = False
            Me.checkBoxAdv3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxAdv3.Location = New System.Drawing.Point(9, 97)
            Me.checkBoxAdv3.MetroColor = System.Drawing.Color.Black
            Me.checkBoxAdv3.Name = "checkBoxAdv3"
            Me.checkBoxAdv3.Size = New System.Drawing.Size(115, 22)
            Me.checkBoxAdv3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv3.TabIndex = 16
            Me.checkBoxAdv3.Text = "Seconds hand"
            Me.checkBoxAdv3.ThemesEnabled = False
            '
            'panel4
            '
            Me.panel4.Controls.Add(Me.colorUIControl1)
            Me.panel4.Location = New System.Drawing.Point(283, 39)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(195, 163)
            Me.panel4.TabIndex = 6
            '
            'colorUIControl1
            '
            Me.colorUIControl1.Flag = False
            Me.colorUIControl1.Location = New System.Drawing.Point(0, -24)
            Me.colorUIControl1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
            Me.colorUIControl1.MetroForeColor = System.Drawing.Color.White
            Me.colorUIControl1.Name = "colorUIControl1"
            MetroColorTabel1.ArrowChecked = System.Drawing.Color.Black
            MetroColorTabel1.ArrowInActive = System.Drawing.Color.White
            MetroColorTabel1.ArrowNormal = System.Drawing.Color.Gray
            MetroColorTabel1.ArrowPushed = System.Drawing.Color.Black
            MetroColorTabel1.ScrollerBackground = System.Drawing.Color.White
            MetroColorTabel1.ThumbChecked = System.Drawing.Color.Black
            MetroColorTabel1.ThumbInActive = System.Drawing.Color.White
            MetroColorTabel1.ThumbNormal = System.Drawing.Color.Gray
            MetroColorTabel1.ThumbPushed = System.Drawing.Color.Black
            Me.colorUIControl1.ScrollMetroColorTable = MetroColorTabel1
            Me.colorUIControl1.Size = New System.Drawing.Size(180, 220)
            Me.colorUIControl1.TabIndex = 0
            Me.colorUIControl1.Text = "colorUIControl1"
            '
            'radioButtonAdv6
            '
            Me.radioButtonAdv6.DrawFocusRectangle = False
            Me.radioButtonAdv6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButtonAdv6.Location = New System.Drawing.Point(150, 63)
            Me.radioButtonAdv6.MetroColor = System.Drawing.Color.Black
            Me.radioButtonAdv6.Name = "radioButtonAdv6"
            Me.radioButtonAdv6.Size = New System.Drawing.Size(136, 28)
            Me.radioButtonAdv6.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radioButtonAdv6.TabIndex = 5
            Me.radioButtonAdv6.TabStop = False
            Me.radioButtonAdv6.Text = "Gradient End Color"
            Me.radioButtonAdv6.ThemesEnabled = False
            '
            'checkBoxAdv4
            '
            Me.checkBoxAdv4.DrawFocusRectangle = False
            Me.checkBoxAdv4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxAdv4.Location = New System.Drawing.Point(9, 126)
            Me.checkBoxAdv4.MetroColor = System.Drawing.Color.Black
            Me.checkBoxAdv4.Name = "checkBoxAdv4"
            Me.checkBoxAdv4.Size = New System.Drawing.Size(122, 22)
            Me.checkBoxAdv4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv4.TabIndex = 17
            Me.checkBoxAdv4.Text = "Customized Hands"
            Me.checkBoxAdv4.ThemesEnabled = False
            '
            'radioButtonAdv5
            '
            Me.radioButtonAdv5.Checked = True
            Me.radioButtonAdv5.DrawFocusRectangle = False
            Me.radioButtonAdv5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButtonAdv5.Location = New System.Drawing.Point(150, 38)
            Me.radioButtonAdv5.MetroColor = System.Drawing.Color.Black
            Me.radioButtonAdv5.Name = "radioButtonAdv5"
            Me.radioButtonAdv5.Size = New System.Drawing.Size(136, 23)
            Me.radioButtonAdv5.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radioButtonAdv5.TabIndex = 4
            Me.radioButtonAdv5.Text = "Gradient Start Color"
            Me.radioButtonAdv5.ThemesEnabled = False
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(9, 8)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(38, 15)
            Me.label2.TabIndex = 13
            Me.label2.Text = "Show"
            '
            'checkBoxAdv2
            '
            Me.checkBoxAdv2.DrawFocusRectangle = False
            Me.checkBoxAdv2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxAdv2.Location = New System.Drawing.Point(9, 154)
            Me.checkBoxAdv2.MetroColor = System.Drawing.Color.Black
            Me.checkBoxAdv2.Name = "checkBoxAdv2"
            Me.checkBoxAdv2.Size = New System.Drawing.Size(98, 22)
            Me.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv2.TabIndex = 15
            Me.checkBoxAdv2.Text = "AM/PM"
            Me.checkBoxAdv2.ThemesEnabled = False
            '
            'radioButtonAdv4
            '
            Me.radioButtonAdv4.DrawFocusRectangle = False
            Me.radioButtonAdv4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButtonAdv4.Location = New System.Drawing.Point(150, 184)
            Me.radioButtonAdv4.MetroColor = System.Drawing.Color.Black
            Me.radioButtonAdv4.Name = "radioButtonAdv4"
            Me.radioButtonAdv4.Size = New System.Drawing.Size(136, 23)
            Me.radioButtonAdv4.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radioButtonAdv4.TabIndex = 3
            Me.radioButtonAdv4.TabStop = False
            Me.radioButtonAdv4.Text = "Second Hand Color"
            Me.radioButtonAdv4.ThemesEnabled = False
            '
            'checkBoxAdv1
            '
            Me.checkBoxAdv1.Checked = True
            Me.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv1.DrawFocusRectangle = False
            Me.checkBoxAdv1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxAdv1.Location = New System.Drawing.Point(9, 69)
            Me.checkBoxAdv1.MetroColor = System.Drawing.Color.Black
            Me.checkBoxAdv1.Name = "checkBoxAdv1"
            Me.checkBoxAdv1.Size = New System.Drawing.Size(114, 22)
            Me.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv1.TabIndex = 14
            Me.checkBoxAdv1.Text = "Minutes line"
            Me.checkBoxAdv1.ThemesEnabled = False
            '
            'radioButtonAdv3
            '
            Me.radioButtonAdv3.DrawFocusRectangle = False
            Me.radioButtonAdv3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButtonAdv3.Location = New System.Drawing.Point(150, 154)
            Me.radioButtonAdv3.MetroColor = System.Drawing.Color.Black
            Me.radioButtonAdv3.Name = "radioButtonAdv3"
            Me.radioButtonAdv3.Size = New System.Drawing.Size(142, 23)
            Me.radioButtonAdv3.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radioButtonAdv3.TabIndex = 2
            Me.radioButtonAdv3.TabStop = False
            Me.radioButtonAdv3.Text = "Minute Hand Color"
            Me.radioButtonAdv3.ThemesEnabled = False
            '
            'radioButtonAdv2
            '
            Me.radioButtonAdv2.DrawFocusRectangle = False
            Me.radioButtonAdv2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButtonAdv2.Location = New System.Drawing.Point(150, 124)
            Me.radioButtonAdv2.MetroColor = System.Drawing.Color.Black
            Me.radioButtonAdv2.Name = "radioButtonAdv2"
            Me.radioButtonAdv2.Size = New System.Drawing.Size(117, 23)
            Me.radioButtonAdv2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radioButtonAdv2.TabIndex = 1
            Me.radioButtonAdv2.TabStop = False
            Me.radioButtonAdv2.Text = "Hour Hand Color"
            Me.radioButtonAdv2.ThemesEnabled = False
            '
            'radioButtonAdv1
            '
            Me.radioButtonAdv1.DrawFocusRectangle = False
            Me.radioButtonAdv1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButtonAdv1.Location = New System.Drawing.Point(150, 94)
            Me.radioButtonAdv1.MetroColor = System.Drawing.Color.Black
            Me.radioButtonAdv1.Name = "radioButtonAdv1"
            Me.radioButtonAdv1.Size = New System.Drawing.Size(124, 28)
            Me.radioButtonAdv1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radioButtonAdv1.TabIndex = 0
            Me.radioButtonAdv1.TabStop = False
            Me.radioButtonAdv1.Text = "Minute Ring Color"
            Me.radioButtonAdv1.ThemesEnabled = False
            '
            'panel3
            '
            Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel3.Controls.Add(Me.checkBoxAdv5)
            Me.panel3.Controls.Add(Me.label5)
            Me.panel3.Controls.Add(Me.pictureBox10)
            Me.panel3.Controls.Add(Me.pictureBox9)
            Me.panel3.Controls.Add(Me.pictureBox8)
            Me.panel3.Controls.Add(Me.pictureBox7)
            Me.panel3.Controls.Add(Me.pictureBox6)
            Me.panel3.Controls.Add(Me.pictureBox5)
            Me.panel3.Controls.Add(Me.pictureBox4)
            Me.panel3.Controls.Add(Me.pictureBox3)
            Me.panel3.Controls.Add(Me.pictureBox2)
            Me.panel3.Controls.Add(Me.pictureBox1)
            Me.panel3.Location = New System.Drawing.Point(284, 260)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(472, 225)
            Me.panel3.TabIndex = 2
            '
            'checkBoxAdv5
            '
            Me.checkBoxAdv5.DrawFocusRectangle = False
            Me.checkBoxAdv5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxAdv5.Location = New System.Drawing.Point(355, 7)
            Me.checkBoxAdv5.MetroColor = System.Drawing.Color.Black
            Me.checkBoxAdv5.Name = "checkBoxAdv5"
            Me.checkBoxAdv5.Size = New System.Drawing.Size(111, 22)
            Me.checkBoxAdv5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxAdv5.TabIndex = 17
            Me.checkBoxAdv5.Text = "Use Clock Model"
            Me.checkBoxAdv5.ThemesEnabled = False
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.Location = New System.Drawing.Point(3, 7)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(189, 15)
            Me.label5.TabIndex = 10
            Me.label5.Text = "Customize clock model previews"
            '
            'pictureBox10
            '
            Me.pictureBox10.Location = New System.Drawing.Point(106, 44)
            Me.pictureBox10.Name = "pictureBox10"
            Me.pictureBox10.Size = New System.Drawing.Size(78, 75)
            Me.pictureBox10.TabIndex = 9
            Me.pictureBox10.TabStop = False
            '
            'pictureBox9
            '
            Me.pictureBox9.Location = New System.Drawing.Point(287, 133)
            Me.pictureBox9.Name = "pictureBox9"
            Me.pictureBox9.Size = New System.Drawing.Size(78, 75)
            Me.pictureBox9.TabIndex = 8
            Me.pictureBox9.TabStop = False
            '
            'pictureBox8
            '
            Me.pictureBox8.Location = New System.Drawing.Point(195, 133)
            Me.pictureBox8.Name = "pictureBox8"
            Me.pictureBox8.Size = New System.Drawing.Size(78, 75)
            Me.pictureBox8.TabIndex = 7
            Me.pictureBox8.TabStop = False
            '
            'pictureBox7
            '
            Me.pictureBox7.Location = New System.Drawing.Point(106, 133)
            Me.pictureBox7.Name = "pictureBox7"
            Me.pictureBox7.Size = New System.Drawing.Size(78, 75)
            Me.pictureBox7.TabIndex = 6
            Me.pictureBox7.TabStop = False
            '
            'pictureBox6
            '
            Me.pictureBox6.Location = New System.Drawing.Point(14, 133)
            Me.pictureBox6.Name = "pictureBox6"
            Me.pictureBox6.Size = New System.Drawing.Size(78, 75)
            Me.pictureBox6.TabIndex = 5
            Me.pictureBox6.TabStop = False
            '
            'pictureBox5
            '
            Me.pictureBox5.Location = New System.Drawing.Point(376, 43)
            Me.pictureBox5.Name = "pictureBox5"
            Me.pictureBox5.Size = New System.Drawing.Size(78, 75)
            Me.pictureBox5.TabIndex = 4
            Me.pictureBox5.TabStop = False
            '
            'pictureBox4
            '
            Me.pictureBox4.Location = New System.Drawing.Point(287, 43)
            Me.pictureBox4.Name = "pictureBox4"
            Me.pictureBox4.Size = New System.Drawing.Size(78, 75)
            Me.pictureBox4.TabIndex = 3
            Me.pictureBox4.TabStop = False
            '
            'pictureBox3
            '
            Me.pictureBox3.Location = New System.Drawing.Point(195, 43)
            Me.pictureBox3.Name = "pictureBox3"
            Me.pictureBox3.Size = New System.Drawing.Size(78, 75)
            Me.pictureBox3.TabIndex = 2
            Me.pictureBox3.TabStop = False
            '
            'pictureBox2
            '
            Me.pictureBox2.Location = New System.Drawing.Point(12, 43)
            Me.pictureBox2.Name = "pictureBox2"
            Me.pictureBox2.Size = New System.Drawing.Size(78, 75)
            Me.pictureBox2.TabIndex = 1
            Me.pictureBox2.TabStop = False
            '
            'pictureBox1
            '
            Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.pictureBox1.Location = New System.Drawing.Point(377, 131)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(77, 77)
            Me.pictureBox1.TabIndex = 0
            Me.pictureBox1.TabStop = False
            '
            'panel5
            '
            Me.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel5.Controls.Add(Me.panel6)
            Me.panel5.Controls.Add(Me.label1)
            Me.panel5.Controls.Add(Me.radioButtonAdv7)
            Me.panel5.Controls.Add(Me.radioButtonAdv8)
            Me.panel5.Controls.Add(Me.radioButtonAdv9)
            Me.panel5.Controls.Add(Me.radioButtonAdv10)
            Me.panel5.Location = New System.Drawing.Point(15, 260)
            Me.panel5.Name = "panel5"
            Me.panel5.Size = New System.Drawing.Size(252, 225)
            Me.panel5.TabIndex = 3
            '
            'panel6
            '
            Me.panel6.Controls.Add(Me.buttonAdv1)
            Me.panel6.Location = New System.Drawing.Point(3, 132)
            Me.panel6.Name = "panel6"
            Me.panel6.Size = New System.Drawing.Size(236, 80)
            Me.panel6.TabIndex = 12
            '
            'buttonAdv1
            '
            Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.buttonAdv1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonAdv1.Location = New System.Drawing.Point(3, 3)
            Me.buttonAdv1.Name = "buttonAdv1"
            Me.buttonAdv1.Size = New System.Drawing.Size(241, 74)
            Me.buttonAdv1.TabIndex = 0
            Me.buttonAdv1.Text = "Click me to show  splash remainder in 1 second"
            Me.buttonAdv1.UseVisualStyle = True
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(18, 7)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(61, 15)
            Me.label1.TabIndex = 8
            Me.label1.Text = "Thickness"
            '
            'radioButtonAdv7
            '
            Me.radioButtonAdv7.DrawFocusRectangle = False
            Me.radioButtonAdv7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButtonAdv7.Location = New System.Drawing.Point(139, 61)
            Me.radioButtonAdv7.MetroColor = System.Drawing.Color.Black
            Me.radioButtonAdv7.Name = "radioButtonAdv7"
            Me.radioButtonAdv7.Size = New System.Drawing.Size(100, 23)
            Me.radioButtonAdv7.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radioButtonAdv7.TabIndex = 7
            Me.radioButtonAdv7.TabStop = False
            Me.radioButtonAdv7.Text = "Second hand"
            Me.radioButtonAdv7.ThemesEnabled = False
            '
            'radioButtonAdv8
            '
            Me.radioButtonAdv8.DrawFocusRectangle = False
            Me.radioButtonAdv8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButtonAdv8.Location = New System.Drawing.Point(21, 61)
            Me.radioButtonAdv8.MetroColor = System.Drawing.Color.Black
            Me.radioButtonAdv8.Name = "radioButtonAdv8"
            Me.radioButtonAdv8.Size = New System.Drawing.Size(112, 23)
            Me.radioButtonAdv8.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radioButtonAdv8.TabIndex = 6
            Me.radioButtonAdv8.TabStop = False
            Me.radioButtonAdv8.Text = "Minute hand"
            Me.radioButtonAdv8.ThemesEnabled = False
            '
            'radioButtonAdv9
            '
            Me.radioButtonAdv9.DrawFocusRectangle = False
            Me.radioButtonAdv9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButtonAdv9.Location = New System.Drawing.Point(139, 32)
            Me.radioButtonAdv9.MetroColor = System.Drawing.Color.Black
            Me.radioButtonAdv9.Name = "radioButtonAdv9"
            Me.radioButtonAdv9.Size = New System.Drawing.Size(117, 23)
            Me.radioButtonAdv9.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radioButtonAdv9.TabIndex = 5
            Me.radioButtonAdv9.TabStop = False
            Me.radioButtonAdv9.Text = "Hour hand"
            Me.radioButtonAdv9.ThemesEnabled = False
            '
            'radioButtonAdv10
            '
            Me.radioButtonAdv10.Checked = True
            Me.radioButtonAdv10.DrawFocusRectangle = False
            Me.radioButtonAdv10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButtonAdv10.Location = New System.Drawing.Point(21, 32)
            Me.radioButtonAdv10.MetroColor = System.Drawing.Color.Black
            Me.radioButtonAdv10.Name = "radioButtonAdv10"
            Me.radioButtonAdv10.Size = New System.Drawing.Size(112, 23)
            Me.radioButtonAdv10.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radioButtonAdv10.TabIndex = 4
            Me.radioButtonAdv10.Text = "Minute line"
            Me.radioButtonAdv10.ThemesEnabled = False
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.Transparent
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.label7)
            Me.panel1.Controls.Add(Me.clock1)
            Me.panel1.Location = New System.Drawing.Point(15, 13)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(252, 231)
            Me.panel1.TabIndex = 0
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(102, 208)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(0, 13)
            Me.label7.TabIndex = 1
            '
            'clock1
            '
            Me.clock1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(119, Byte), Integer))
            Me.clock1.EnableRemainder = True
            Me.clock1.Location = New System.Drawing.Point(18, 7)
            Me.clock1.MinuteColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(119, Byte), Integer))
            Me.clock1.Name = "clock1"
            Me.clock1.Remainder = New Date(2012, 10, 10, 4, 26, 57, 680)
            Me.clock1.Renderer = ClockRenderer1
            Me.clock1.Size = New System.Drawing.Size(215, 215)
            Me.clock1.TabIndex = 0
            Me.clock1.Text = "clock1"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(772, 501)
            Me.Controls.Add(Me.panel5)
            Me.Controls.Add(Me.panel3)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.Text = "Clock control demo"
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            CType(Me.checkBoxAdv6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel4.ResumeLayout(False)
            CType(Me.radioButtonAdv6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            CType(Me.checkBoxAdv5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel5.ResumeLayout(False)
            Me.panel5.PerformLayout()
            Me.panel6.ResumeLayout(False)
            CType(Me.radioButtonAdv7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv10, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents panel2 As System.Windows.Forms.Panel
		Private WithEvents panel3 As System.Windows.Forms.Panel
		Private radioButtonAdv6 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private radioButtonAdv5 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private radioButtonAdv4 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private radioButtonAdv3 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private radioButtonAdv2 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private radioButtonAdv1 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private panel4 As System.Windows.Forms.Panel
		Private WithEvents colorUIControl1 As Syncfusion.Windows.Forms.ColorUIControl
		Private WithEvents pictureBox10 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox9 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox8 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox7 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox6 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox5 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox4 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox3 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
		Private panel5 As System.Windows.Forms.Panel
		Private WithEvents radioButtonAdv7 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents radioButtonAdv8 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents radioButtonAdv9 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents radioButtonAdv10 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private label1 As System.Windows.Forms.Label
		Private clock1 As Syncfusion.Windows.Forms.Tools.Clock
		Private panel6 As System.Windows.Forms.Panel
		Private label4 As System.Windows.Forms.Label
		Private WithEvents label5 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private WithEvents checkBoxAdv3 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBoxAdv2 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBoxAdv1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private label2 As System.Windows.Forms.Label
		Private WithEvents buttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents checkBoxAdv4 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBoxAdv5 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBoxAdv6 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv

	End Class
End Namespace

