#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Namespace TableOfContents_2005
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.button1 = New System.Windows.Forms.Button()
            Me.label3 = New System.Windows.Forms.Label()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.checkBox2 = New System.Windows.Forms.CheckBox()
            Me.checkBox3 = New System.Windows.Forms.CheckBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.label20 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
            Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown()
            Me.label7 = New System.Windows.Forms.Label()
            Me.label8 = New System.Windows.Forms.Label()
            Me.label9 = New System.Windows.Forms.Label()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.radioButton1 = New System.Windows.Forms.RadioButton()
            Me.radioButton2 = New System.Windows.Forms.RadioButton()
            Me.label32 = New System.Windows.Forms.Label()
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.label12 = New System.Windows.Forms.Label()
            Me.label13 = New System.Windows.Forms.Label()
            Me.label14 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.label24 = New System.Windows.Forms.Label()
            Me.label10 = New System.Windows.Forms.Label()
            Me.checkBox4 = New System.Windows.Forms.CheckBox()
            Me.label11 = New System.Windows.Forms.Label()
            Me.checkBox5 = New System.Windows.Forms.CheckBox()
            Me.CheckBox6 = New System.Windows.Forms.CheckBox()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.word2013RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2010RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2003RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2007RadioBtn = New System.Windows.Forms.RadioButton()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(374, 95)
            Me.pictureBox1.TabIndex = 29
            Me.pictureBox1.TabStop = False
            '
            'label1
            '
            Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.label1.Location = New System.Drawing.Point(5, 402)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(373, 55)
            Me.label1.TabIndex = 30
            Me.label1.Text = "Click the button to view the Word document generated by Essential DocIO. Please n" & _
        "ote that MS Word Viewer or MS Word is required to view the resultant document."
            '
            'button1
            '
            Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button1.BackColor = System.Drawing.Color.Transparent
            Me.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button1.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Image)
            Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.button1.Location = New System.Drawing.Point(279, 507)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(83, 23)
            Me.button1.TabIndex = 31
            Me.button1.Text = "Generate"
            Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button1.UseVisualStyleBackColor = False
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(12, 142)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(32, 13)
            Me.label3.TabIndex = 33
            Me.label3.Text = "Title"
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(128, 139)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(219, 20)
            Me.textBox1.TabIndex = 34
            Me.textBox1.Text = "Table of Contents"
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox1.Location = New System.Drawing.Point(12, 286)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(133, 18)
            Me.checkBox1.TabIndex = 39
            Me.checkBox1.Tag = "scrolls"
            Me.checkBox1.Text = "Include Page Numbers"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.Checked = True
            Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox2.Location = New System.Drawing.Point(12, 313)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(149, 18)
            Me.checkBox2.TabIndex = 40
            Me.checkBox2.Tag = "scrolls"
            Me.checkBox2.Text = "Right Align Page Numbers"
            Me.checkBox2.UseVisualStyleBackColor = True
            '
            'checkBox3
            '
            Me.checkBox3.AutoSize = True
            Me.checkBox3.Checked = True
            Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox3.Location = New System.Drawing.Point(174, 286)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(96, 18)
            Me.checkBox3.TabIndex = 41
            Me.checkBox3.Tag = "scrolls"
            Me.checkBox3.Text = "Use HyperLink"
            Me.checkBox3.UseVisualStyleBackColor = True
            '
            'label5
            '
            Me.label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label5.Image = CType(resources.GetObject("label5.Image"), System.Drawing.Image)
            Me.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label5.Location = New System.Drawing.Point(12, 245)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(66, 24)
            Me.label5.TabIndex = 43
            Me.label5.Text = "Entries"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label20
            '
            Me.label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label20.Location = New System.Drawing.Point(12, 271)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(340, 1)
            Me.label20.TabIndex = 42
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Image = CType(resources.GetObject("label2.Image"), System.Drawing.Image)
            Me.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label2.Location = New System.Drawing.Point(12, 100)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(99, 24)
            Me.label2.TabIndex = 45
            Me.label2.Text = "Index/Table"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label4
            '
            Me.label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label4.Location = New System.Drawing.Point(12, 126)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(340, 1)
            Me.label4.TabIndex = 44
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(125, 217)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(62, 13)
            Me.label6.TabIndex = 46
            Me.label6.Text = "LowerLevel"
            '
            'numericUpDown1
            '
            Me.numericUpDown1.Location = New System.Drawing.Point(193, 217)
            Me.numericUpDown1.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
            Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.Size = New System.Drawing.Size(32, 20)
            Me.numericUpDown1.TabIndex = 47
            Me.numericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'numericUpDown2
            '
            Me.numericUpDown2.Location = New System.Drawing.Point(314, 217)
            Me.numericUpDown2.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
            Me.numericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown2.Name = "numericUpDown2"
            Me.numericUpDown2.Size = New System.Drawing.Size(33, 20)
            Me.numericUpDown2.TabIndex = 49
            Me.numericUpDown2.Value = New Decimal(New Integer() {2, 0, 0, 0})
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(246, 217)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(62, 13)
            Me.label7.TabIndex = 48
            Me.label7.Text = "UpperLevel"
            '
            'label8
            '
            Me.label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label8.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label8.Image = CType(resources.GetObject("label8.Image"), System.Drawing.Image)
            Me.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label8.Location = New System.Drawing.Point(12, 371)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(124, 24)
            Me.label8.TabIndex = 51
            Me.label8.Text = "Create Word Doc"
            Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label9
            '
            Me.label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label9.Location = New System.Drawing.Point(12, 397)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(340, 1)
            Me.label9.TabIndex = 50
            '
            'imageList1
            '
            Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
            Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            '
            'radioButton1
            '
            Me.radioButton1.AutoSize = True
            Me.radioButton1.BackColor = System.Drawing.Color.Transparent
            Me.radioButton1.Checked = True
            Me.radioButton1.Location = New System.Drawing.Point(128, 179)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(59, 17)
            Me.radioButton1.TabIndex = 52
            Me.radioButton1.TabStop = True
            Me.radioButton1.Text = "Default"
            Me.radioButton1.UseVisualStyleBackColor = False
            '
            'radioButton2
            '
            Me.radioButton2.AutoSize = True
            Me.radioButton2.Location = New System.Drawing.Point(249, 179)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(60, 17)
            Me.radioButton2.TabIndex = 53
            Me.radioButton2.Text = "Custom"
            Me.radioButton2.UseVisualStyleBackColor = True
            '
            'label32
            '
            Me.label32.Image = CType(resources.GetObject("label32.Image"), System.Drawing.Image)
            Me.label32.Location = New System.Drawing.Point(327, 342)
            Me.label32.Name = "label32"
            Me.label32.Size = New System.Drawing.Size(20, 20)
            Me.label32.TabIndex = 56
            Me.toolTip1.SetToolTip(Me.label32, "Used to Update Table of Contents")
            '
            'label12
            '
            Me.label12.Image = CType(resources.GetObject("label12.Image"), System.Drawing.Image)
            Me.label12.Location = New System.Drawing.Point(190, 179)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(20, 20)
            Me.label12.TabIndex = 60
            Me.toolTip1.SetToolTip(Me.label12, "Use default Heading Styles")
            '
            'label13
            '
            Me.label13.Image = CType(resources.GetObject("label13.Image"), System.Drawing.Image)
            Me.label13.Location = New System.Drawing.Point(311, 179)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(20, 20)
            Me.label13.TabIndex = 61
            Me.toolTip1.SetToolTip(Me.label13, "Use Custom Heading Styles")
            '
            'label14
            '
            Me.label14.Image = CType(resources.GetObject("label14.Image"), System.Drawing.Image)
            Me.label14.Location = New System.Drawing.Point(141, 342)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(20, 20)
            Me.label14.TabIndex = 63
            Me.toolTip1.SetToolTip(Me.label14, "Used to set levels for a word or paragraph through Table Entry Fields")
            '
            'Label15
            '
            Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
            Me.Label15.Location = New System.Drawing.Point(221, 48)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(20, 18)
            Me.Label15.TabIndex = 104
            Me.toolTip1.SetToolTip(Me.Label15, "Saves the document in Word 2013 format")
            '
            'Label16
            '
            Me.Label16.Image = CType(resources.GetObject("Label16.Image"), System.Drawing.Image)
            Me.Label16.Location = New System.Drawing.Point(106, 48)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(20, 18)
            Me.Label16.TabIndex = 102
            Me.toolTip1.SetToolTip(Me.Label16, "Saves the document in Word 2010 format")
            '
            'Label17
            '
            Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
            Me.Label17.Location = New System.Drawing.Point(221, 20)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(20, 18)
            Me.Label17.TabIndex = 101
            Me.toolTip1.SetToolTip(Me.Label17, "Saves the document in Word 2007 format")
            '
            'label24
            '
            Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
            Me.label24.Location = New System.Drawing.Point(107, 20)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 100
            Me.toolTip1.SetToolTip(Me.label24, "Saves the document in Word 97-2003 format" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label10.Location = New System.Drawing.Point(12, 179)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(42, 13)
            Me.label10.TabIndex = 57
            Me.label10.Text = "Styles"
            '
            'checkBox4
            '
            Me.checkBox4.AutoSize = True
            Me.checkBox4.Checked = True
            Me.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox4.Location = New System.Drawing.Point(174, 313)
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(116, 18)
            Me.checkBox4.TabIndex = 58
            Me.checkBox4.Tag = "scrolls"
            Me.checkBox4.Text = "Use Outline Levels"
            Me.checkBox4.UseVisualStyleBackColor = True
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label11.Location = New System.Drawing.Point(12, 217)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(95, 13)
            Me.label11.TabIndex = 59
            Me.label11.Text = "Heading Levels "
            '
            'checkBox5
            '
            Me.checkBox5.AutoSize = True
            Me.checkBox5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox5.Location = New System.Drawing.Point(12, 341)
            Me.checkBox5.Name = "checkBox5"
            Me.checkBox5.Size = New System.Drawing.Size(126, 18)
            Me.checkBox5.TabIndex = 62
            Me.checkBox5.Tag = "scrolls"
            Me.checkBox5.Text = "Use TableEntryFields"
            Me.checkBox5.UseVisualStyleBackColor = True
            '
            'CheckBox6
            '
            Me.CheckBox6.AutoSize = True
            Me.CheckBox6.Location = New System.Drawing.Point(173, 341)
            Me.CheckBox6.Name = "CheckBox6"
            Me.CheckBox6.Size = New System.Drawing.Size(148, 17)
            Me.CheckBox6.TabIndex = 101
            Me.CheckBox6.Text = "Update Table of Contents"
            Me.CheckBox6.UseVisualStyleBackColor = True
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.Label15)
            Me.groupBox1.Controls.Add(Me.word2013RadioBtn)
            Me.groupBox1.Controls.Add(Me.Label16)
            Me.groupBox1.Controls.Add(Me.Label17)
            Me.groupBox1.Controls.Add(Me.label24)
            Me.groupBox1.Controls.Add(Me.word2010RadioBtn)
            Me.groupBox1.Controls.Add(Me.word2003RadioBtn)
            Me.groupBox1.Controls.Add(Me.word2007RadioBtn)
            Me.groupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(8, 460)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(251, 70)
            Me.groupBox1.TabIndex = 102
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Save As"
            '
            'word2013RadioBtn
            '
            Me.word2013RadioBtn.AutoSize = True
            Me.word2013RadioBtn.Checked = True
            Me.word2013RadioBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.word2013RadioBtn.Location = New System.Drawing.Point(139, 46)
            Me.word2013RadioBtn.Name = "word2013RadioBtn"
            Me.word2013RadioBtn.Size = New System.Drawing.Size(86, 17)
            Me.word2013RadioBtn.TabIndex = 103
            Me.word2013RadioBtn.TabStop = True
            Me.word2013RadioBtn.Text = "Word 2013"
            Me.word2013RadioBtn.UseVisualStyleBackColor = True
            '
            'word2010RadioBtn
            '
            Me.word2010RadioBtn.AutoSize = True
            Me.word2010RadioBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.word2010RadioBtn.Location = New System.Drawing.Point(6, 46)
            Me.word2010RadioBtn.Name = "word2010RadioBtn"
            Me.word2010RadioBtn.Size = New System.Drawing.Size(86, 17)
            Me.word2010RadioBtn.TabIndex = 46
            Me.word2010RadioBtn.Text = "Word 2010"
            Me.word2010RadioBtn.UseVisualStyleBackColor = True
            '
            'word2003RadioBtn
            '
            Me.word2003RadioBtn.AutoSize = True
            Me.word2003RadioBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.word2003RadioBtn.Location = New System.Drawing.Point(6, 20)
            Me.word2003RadioBtn.Name = "word2003RadioBtn"
            Me.word2003RadioBtn.Size = New System.Drawing.Size(105, 17)
            Me.word2003RadioBtn.TabIndex = 44
            Me.word2003RadioBtn.Text = "Word 97-2003"
            Me.word2003RadioBtn.UseVisualStyleBackColor = True
            '
            'word2007RadioBtn
            '
            Me.word2007RadioBtn.AutoSize = True
            Me.word2007RadioBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.word2007RadioBtn.Location = New System.Drawing.Point(139, 20)
            Me.word2007RadioBtn.Name = "word2007RadioBtn"
            Me.word2007RadioBtn.Size = New System.Drawing.Size(86, 17)
            Me.word2007RadioBtn.TabIndex = 45
            Me.word2007RadioBtn.Text = "Word 2007"
            Me.word2007RadioBtn.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(374, 550)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.CheckBox6)
            Me.Controls.Add(Me.label14)
            Me.Controls.Add(Me.checkBox5)
            Me.Controls.Add(Me.label13)
            Me.Controls.Add(Me.label12)
            Me.Controls.Add(Me.label11)
            Me.Controls.Add(Me.checkBox4)
            Me.Controls.Add(Me.radioButton2)
            Me.Controls.Add(Me.radioButton1)
            Me.Controls.Add(Me.label10)
            Me.Controls.Add(Me.label32)
            Me.Controls.Add(Me.label8)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.numericUpDown2)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.numericUpDown1)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.label20)
            Me.Controls.Add(Me.checkBox3)
            Me.Controls.Add(Me.checkBox2)
            Me.Controls.Add(Me.checkBox1)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.pictureBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Table of Contents"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private label1 As System.Windows.Forms.Label
		Private WithEvents button1 As System.Windows.Forms.Button
		Private label3 As System.Windows.Forms.Label
		Private textBox1 As System.Windows.Forms.TextBox
		Private checkBox1 As System.Windows.Forms.CheckBox
		Private checkBox2 As System.Windows.Forms.CheckBox
		Private checkBox3 As System.Windows.Forms.CheckBox
		Private label5 As System.Windows.Forms.Label
		Private label20 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private numericUpDown1 As System.Windows.Forms.NumericUpDown
		Private numericUpDown2 As System.Windows.Forms.NumericUpDown
		Private label7 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private imageList1 As System.Windows.Forms.ImageList
		Private radioButton1 As System.Windows.Forms.RadioButton
		Private radioButton2 As System.Windows.Forms.RadioButton
        Private label32 As System.Windows.Forms.Label
		Private toolTip1 As System.Windows.Forms.ToolTip
		Private label10 As System.Windows.Forms.Label
		Private checkBox4 As System.Windows.Forms.CheckBox
		Private label11 As System.Windows.Forms.Label
		Private label12 As System.Windows.Forms.Label
		Private label13 As System.Windows.Forms.Label
		Private checkBox5 As System.Windows.Forms.CheckBox
        Private label14 As System.Windows.Forms.Label
        Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents Label15 As System.Windows.Forms.Label
        Private WithEvents word2013RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents Label16 As System.Windows.Forms.Label
        Private WithEvents Label17 As System.Windows.Forms.Label
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents word2010RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2003RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2007RadioBtn As System.Windows.Forms.RadioButton
    End Class
End Namespace

