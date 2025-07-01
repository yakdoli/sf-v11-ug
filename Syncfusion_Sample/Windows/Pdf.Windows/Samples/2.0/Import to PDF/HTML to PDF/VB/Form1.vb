#Region "Copyright Syncfusion Inc. 2001 - 2007"
'
'  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Re-distribution in any form is strictly
'  prohibited. Any infringement will be prosecuted under applicable laws. 
'
#End Region


Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Pdf
Imports Syncfusion.HtmlConverter
Imports Syncfusion.Pdf.Graphics
Imports Syncfusion.Pdf.HtmlToPdf
Imports Syncfusion.GeckoHtmlRenderer

Namespace EssentialPDFSamples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		#Region "Private Members"
		Private WithEvents button1 As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
		Private dlgOpen As OpenFileDialog
		Private chkFooter As CheckBox
		Private chkHeader As CheckBox
		Private nudMargin As NumericUpDown
		Private label3 As Label
		Private groupBox4 As GroupBox
		Private rdoLandscape As RadioButton
		Private rdoPortrait As RadioButton
		Private label4 As Label
		Private comboBox1 As ComboBox
		Private groupBox5 As GroupBox
		Private rdoWidth As RadioButton
		Private rdoHeight As RadioButton
		Private label5 As Label
		Private label6 As Label
		Private groupBox2 As GroupBox
		Private WithEvents rdbBitmap As RadioButton
		Private WithEvents rdbMetafile As RadioButton
		Private txtUrl As TextBox
		Private WithEvents button2 As Button
		Private label2 As Label
		Private label7 As Label
		Private label8 As Label
		Private label9 As Label
		Private label10 As Label
		Private groupBox1 As GroupBox
		Private chkJavaScript As CheckBox
		Private groupBox3 As GroupBox
		Private WithEvents chkPDFA1 As CheckBox
		Private chk_TextBreak As CheckBox
		Private rBtnPageBreak As RadioButton
		Private rBtnImageBreak As RadioButton
		Private chkHyperlink As CheckBox
		Private pictureBox3 As PictureBox
		Private groupBox6 As GroupBox
		Private WithEvents geckoRadioBtn As RadioButton
		Private WithEvents mshtmlRadioBtn As RadioButton
		Private WithEvents chkTag As CheckBox

		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		#End Region

		#Region "Constructor"
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Me.comboBox1.SelectedIndex = 0
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
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
            Me.button1 = New System.Windows.Forms.Button
            Me.label1 = New System.Windows.Forms.Label
            Me.dlgOpen = New System.Windows.Forms.OpenFileDialog
            Me.groupBox4 = New System.Windows.Forms.GroupBox
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label4 = New System.Windows.Forms.Label
            Me.rdoLandscape = New System.Windows.Forms.RadioButton
            Me.rdoPortrait = New System.Windows.Forms.RadioButton
            Me.nudMargin = New System.Windows.Forms.NumericUpDown
            Me.label3 = New System.Windows.Forms.Label
            Me.chkFooter = New System.Windows.Forms.CheckBox
            Me.chkHeader = New System.Windows.Forms.CheckBox
            Me.groupBox5 = New System.Windows.Forms.GroupBox
            Me.rdoWidth = New System.Windows.Forms.RadioButton
            Me.rdoHeight = New System.Windows.Forms.RadioButton
            Me.label5 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.rdbBitmap = New System.Windows.Forms.RadioButton
            Me.rdbMetafile = New System.Windows.Forms.RadioButton
            Me.txtUrl = New System.Windows.Forms.TextBox
            Me.button2 = New System.Windows.Forms.Button
            Me.label2 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.label8 = New System.Windows.Forms.Label
            Me.label9 = New System.Windows.Forms.Label
            Me.label10 = New System.Windows.Forms.Label
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.chkTag = New System.Windows.Forms.CheckBox
            Me.chkHyperlink = New System.Windows.Forms.CheckBox
            Me.rBtnPageBreak = New System.Windows.Forms.RadioButton
            Me.rBtnImageBreak = New System.Windows.Forms.RadioButton
            Me.chk_TextBreak = New System.Windows.Forms.CheckBox
            Me.chkJavaScript = New System.Windows.Forms.CheckBox
            Me.groupBox3 = New System.Windows.Forms.GroupBox
            Me.chkPDFA1 = New System.Windows.Forms.CheckBox
            Me.pictureBox3 = New System.Windows.Forms.PictureBox
            Me.groupBox6 = New System.Windows.Forms.GroupBox
            Me.geckoRadioBtn = New System.Windows.Forms.RadioButton
            Me.mshtmlRadioBtn = New System.Windows.Forms.RadioButton
            Me.groupBox4.SuspendLayout()
            CType(Me.nudMargin, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox5.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.groupBox3.SuspendLayout()
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox6.SuspendLayout()
            Me.SuspendLayout()
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
            Me.button1.Location = New System.Drawing.Point(285, 551)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 23)
            Me.button1.TabIndex = 0
            Me.button1.Text = "PDF"
            Me.button1.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.label1.Location = New System.Drawing.Point(2, 508)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(356, 43)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Click the button to view an PDF document generated by Essential PDF.  Please note" & _
                " that Adobe Reader or its equivalent is required to view the resultant document." & _
                ""
            '
            'groupBox4
            '
            Me.groupBox4.Controls.Add(Me.comboBox1)
            Me.groupBox4.Controls.Add(Me.label4)
            Me.groupBox4.Controls.Add(Me.rdoLandscape)
            Me.groupBox4.Controls.Add(Me.rdoPortrait)
            Me.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox4.Location = New System.Drawing.Point(21, 458)
            Me.groupBox4.Name = "groupBox4"
            Me.groupBox4.Size = New System.Drawing.Size(337, 43)
            Me.groupBox4.TabIndex = 4
            Me.groupBox4.TabStop = False
            Me.groupBox4.Text = "Orientation"
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Items.AddRange(New Object() {"RotateAngle0", "RotateAngle180", "RotateAngle270", "RotateAngle90"})
            Me.comboBox1.Location = New System.Drawing.Point(223, 18)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(108, 21)
            Me.comboBox1.TabIndex = 3
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label4.Location = New System.Drawing.Point(173, 23)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(47, 13)
            Me.label4.TabIndex = 2
            Me.label4.Text = "Rotation"
            '
            'rdoLandscape
            '
            Me.rdoLandscape.AutoSize = True
            Me.rdoLandscape.Location = New System.Drawing.Point(89, 21)
            Me.rdoLandscape.Name = "rdoLandscape"
            Me.rdoLandscape.Size = New System.Drawing.Size(78, 17)
            Me.rdoLandscape.TabIndex = 1
            Me.rdoLandscape.TabStop = True
            Me.rdoLandscape.Text = "Landscape"
            Me.rdoLandscape.UseVisualStyleBackColor = True
            '
            'rdoPortrait
            '
            Me.rdoPortrait.AutoSize = True
            Me.rdoPortrait.Checked = True
            Me.rdoPortrait.Location = New System.Drawing.Point(16, 21)
            Me.rdoPortrait.Name = "rdoPortrait"
            Me.rdoPortrait.Size = New System.Drawing.Size(58, 17)
            Me.rdoPortrait.TabIndex = 0
            Me.rdoPortrait.TabStop = True
            Me.rdoPortrait.Text = "Portrait"
            Me.rdoPortrait.UseVisualStyleBackColor = True
            '
            'nudMargin
            '
            Me.nudMargin.Location = New System.Drawing.Point(92, 427)
            Me.nudMargin.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
            Me.nudMargin.Name = "nudMargin"
            Me.nudMargin.Size = New System.Drawing.Size(63, 20)
            Me.nudMargin.TabIndex = 3
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label3.Location = New System.Drawing.Point(22, 429)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(72, 13)
            Me.label3.TabIndex = 2
            Me.label3.Text = "Page Margins"
            '
            'chkFooter
            '
            Me.chkFooter.AutoSize = True
            Me.chkFooter.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkFooter.Location = New System.Drawing.Point(260, 429)
            Me.chkFooter.Name = "chkFooter"
            Me.chkFooter.Size = New System.Drawing.Size(92, 18)
            Me.chkFooter.TabIndex = 1
            Me.chkFooter.Text = "Show Footer"
            Me.chkFooter.UseVisualStyleBackColor = True
            '
            'chkHeader
            '
            Me.chkHeader.AutoSize = True
            Me.chkHeader.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkHeader.Location = New System.Drawing.Point(165, 429)
            Me.chkHeader.Name = "chkHeader"
            Me.chkHeader.Size = New System.Drawing.Size(97, 18)
            Me.chkHeader.TabIndex = 17
            Me.chkHeader.Text = "Show Header"
            Me.chkHeader.UseVisualStyleBackColor = True
            '
            'groupBox5
            '
            Me.groupBox5.Controls.Add(Me.rdoWidth)
            Me.groupBox5.Controls.Add(Me.rdoHeight)
            Me.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox5.Location = New System.Drawing.Point(21, 374)
            Me.groupBox5.Name = "groupBox5"
            Me.groupBox5.Size = New System.Drawing.Size(337, 39)
            Me.groupBox5.TabIndex = 5
            Me.groupBox5.TabStop = False
            Me.groupBox5.Text = "Aspect Ratio"
            '
            'rdoWidth
            '
            Me.rdoWidth.AutoSize = True
            Me.rdoWidth.Checked = True
            Me.rdoWidth.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rdoWidth.Location = New System.Drawing.Point(16, 15)
            Me.rdoWidth.Name = "rdoWidth"
            Me.rdoWidth.Size = New System.Drawing.Size(87, 18)
            Me.rdoWidth.TabIndex = 6
            Me.rdoWidth.TabStop = True
            Me.rdoWidth.Text = "Keep Width"
            Me.rdoWidth.UseVisualStyleBackColor = True
            '
            'rdoHeight
            '
            Me.rdoHeight.AutoSize = True
            Me.rdoHeight.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rdoHeight.Location = New System.Drawing.Point(178, 15)
            Me.rdoHeight.Name = "rdoHeight"
            Me.rdoHeight.Size = New System.Drawing.Size(90, 18)
            Me.rdoHeight.TabIndex = 7
            Me.rdoHeight.Text = "Keep Height"
            Me.rdoHeight.UseVisualStyleBackColor = True
            '
            'label5
            '
            Me.label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label5.Image = CType(resources.GetObject("label5.Image"), System.Drawing.Image)
            Me.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label5.Location = New System.Drawing.Point(2, 90)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(406, 19)
            Me.label5.TabIndex = 27
            Me.label5.Text = "       URL of the html page that needs to be converted to PDF:"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label6
            '
            Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label6.Location = New System.Drawing.Point(26, 110)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(365, 1)
            Me.label6.TabIndex = 28
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.rdbBitmap)
            Me.groupBox2.Controls.Add(Me.rdbMetafile)
            Me.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox2.Location = New System.Drawing.Point(21, 230)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(165, 39)
            Me.groupBox2.TabIndex = 5
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Convert to:"
            '
            'rdbBitmap
            '
            Me.rdbBitmap.AutoSize = True
            Me.rdbBitmap.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rdbBitmap.Location = New System.Drawing.Point(95, 17)
            Me.rdbBitmap.Name = "rdbBitmap"
            Me.rdbBitmap.Size = New System.Drawing.Size(63, 18)
            Me.rdbBitmap.TabIndex = 4
            Me.rdbBitmap.TabStop = True
            Me.rdbBitmap.Text = "Bitmap"
            Me.rdbBitmap.UseVisualStyleBackColor = True
            '
            'rdbMetafile
            '
            Me.rdbMetafile.AutoSize = True
            Me.rdbMetafile.Checked = True
            Me.rdbMetafile.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rdbMetafile.Location = New System.Drawing.Point(16, 17)
            Me.rdbMetafile.Name = "rdbMetafile"
            Me.rdbMetafile.Size = New System.Drawing.Size(68, 18)
            Me.rdbMetafile.TabIndex = 3
            Me.rdbMetafile.TabStop = True
            Me.rdbMetafile.Text = "Metafile"
            Me.rdbMetafile.UseVisualStyleBackColor = True
            '
            'txtUrl
            '
            Me.txtUrl.Location = New System.Drawing.Point(51, 121)
            Me.txtUrl.Name = "txtUrl"
            Me.txtUrl.Size = New System.Drawing.Size(273, 20)
            Me.txtUrl.TabIndex = 1
            Me.txtUrl.Text = "http://www.google.com"
            '
            'button2
            '
            Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button2.Location = New System.Drawing.Point(327, 119)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(31, 23)
            Me.button2.TabIndex = 1
            Me.button2.Text = "..."
            Me.button2.UseVisualStyleBackColor = True
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label2.Location = New System.Drawing.Point(24, 125)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(29, 13)
            Me.label2.TabIndex = 2
            Me.label2.Text = "URL"
            '
            'label7
            '
            Me.label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label7.Image = CType(resources.GetObject("label7.Image"), System.Drawing.Image)
            Me.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label7.Location = New System.Drawing.Point(2, 348)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(111, 19)
            Me.label7.TabIndex = 29
            Me.label7.Text = "      Page Settings"
            Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label8
            '
            Me.label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label8.Location = New System.Drawing.Point(23, 371)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(365, 1)
            Me.label8.TabIndex = 30
            '
            'label9
            '
            Me.label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label9.Location = New System.Drawing.Point(23, 175)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(365, 1)
            Me.label9.TabIndex = 73
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label10.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label10.Image = CType(resources.GetObject("label10.Image"), System.Drawing.Image)
            Me.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label10.Location = New System.Drawing.Point(2, 154)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(127, 14)
            Me.label10.TabIndex = 72
            Me.label10.Text = "      Converter Options"
            Me.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.chkTag)
            Me.groupBox1.Controls.Add(Me.chkHyperlink)
            Me.groupBox1.Controls.Add(Me.rBtnPageBreak)
            Me.groupBox1.Controls.Add(Me.rBtnImageBreak)
            Me.groupBox1.Controls.Add(Me.chk_TextBreak)
            Me.groupBox1.Controls.Add(Me.chkJavaScript)
            Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox1.Location = New System.Drawing.Point(21, 279)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(337, 61)
            Me.groupBox1.TabIndex = 74
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Options (MSHTML specific)"
            '
            'chkTag
            '
            Me.chkTag.AutoSize = True
            Me.chkTag.Location = New System.Drawing.Point(244, 38)
            Me.chkTag.Name = "chkTag"
            Me.chkTag.Size = New System.Drawing.Size(87, 17)
            Me.chkTag.TabIndex = 78
            Me.chkTag.Text = "Tagged PDF"
            Me.chkTag.UseVisualStyleBackColor = True
            '
            'chkHyperlink
            '
            Me.chkHyperlink.AutoSize = True
            Me.chkHyperlink.Checked = True
            Me.chkHyperlink.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkHyperlink.Location = New System.Drawing.Point(214, 17)
            Me.chkHyperlink.Name = "chkHyperlink"
            Me.chkHyperlink.Size = New System.Drawing.Size(111, 17)
            Me.chkHyperlink.TabIndex = 77
            Me.chkHyperlink.Text = "Enable Hyperlinks"
            Me.chkHyperlink.UseVisualStyleBackColor = True
            '
            'rBtnPageBreak
            '
            Me.rBtnPageBreak.AutoSize = True
            Me.rBtnPageBreak.Location = New System.Drawing.Point(119, 38)
            Me.rBtnPageBreak.Name = "rBtnPageBreak"
            Me.rBtnPageBreak.Size = New System.Drawing.Size(120, 17)
            Me.rBtnPageBreak.TabIndex = 6
            Me.rBtnPageBreak.TabStop = True
            Me.rBtnPageBreak.Text = "Activate PageBreak"
            Me.rBtnPageBreak.UseVisualStyleBackColor = True
            '
            'rBtnImageBreak
            '
            Me.rBtnImageBreak.AutoSize = True
            Me.rBtnImageBreak.Checked = True
            Me.rBtnImageBreak.Location = New System.Drawing.Point(12, 38)
            Me.rBtnImageBreak.Name = "rBtnImageBreak"
            Me.rBtnImageBreak.Size = New System.Drawing.Size(82, 17)
            Me.rBtnImageBreak.TabIndex = 5
            Me.rBtnImageBreak.TabStop = True
            Me.rBtnImageBreak.Text = "Split Images"
            Me.rBtnImageBreak.UseVisualStyleBackColor = True
            '
            'chk_TextBreak
            '
            Me.chk_TextBreak.AutoSize = True
            Me.chk_TextBreak.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chk_TextBreak.Location = New System.Drawing.Point(121, 16)
            Me.chk_TextBreak.Name = "chk_TextBreak"
            Me.chk_TextBreak.Size = New System.Drawing.Size(101, 18)
            Me.chk_TextBreak.TabIndex = 4
            Me.chk_TextBreak.Text = "Split TextLines"
            Me.chk_TextBreak.UseVisualStyleBackColor = True
            '
            'chkJavaScript
            '
            Me.chkJavaScript.AutoSize = True
            Me.chkJavaScript.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkJavaScript.Location = New System.Drawing.Point(12, 16)
            Me.chkJavaScript.Name = "chkJavaScript"
            Me.chkJavaScript.Size = New System.Drawing.Size(118, 18)
            Me.chkJavaScript.TabIndex = 1
            Me.chkJavaScript.Text = "Enable JavaScript"
            Me.chkJavaScript.UseVisualStyleBackColor = True
            '
            'groupBox3
            '
            Me.groupBox3.Controls.Add(Me.chkPDFA1)
            Me.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox3.Location = New System.Drawing.Point(197, 230)
            Me.groupBox3.Name = "groupBox3"
            Me.groupBox3.Size = New System.Drawing.Size(161, 39)
            Me.groupBox3.TabIndex = 76
            Me.groupBox3.TabStop = False
            Me.groupBox3.Text = "Document Standard:"
            '
            'chkPDFA1
            '
            Me.chkPDFA1.AutoSize = True
            Me.chkPDFA1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkPDFA1.Location = New System.Drawing.Point(17, 17)
            Me.chkPDFA1.Name = "chkPDFA1"
            Me.chkPDFA1.Size = New System.Drawing.Size(84, 18)
            Me.chkPDFA1.TabIndex = 2
            Me.chkPDFA1.Text = " PDF/A1-B"
            Me.chkPDFA1.UseVisualStyleBackColor = True
            '
            'pictureBox3
            '
            Me.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
            Me.pictureBox3.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox3.Name = "pictureBox3"
            Me.pictureBox3.Size = New System.Drawing.Size(372, 89)
            Me.pictureBox3.TabIndex = 77
            Me.pictureBox3.TabStop = False
            '
            'groupBox6
            '
            Me.groupBox6.Controls.Add(Me.geckoRadioBtn)
            Me.groupBox6.Controls.Add(Me.mshtmlRadioBtn)
            Me.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox6.Location = New System.Drawing.Point(21, 182)
            Me.groupBox6.Name = "groupBox6"
            Me.groupBox6.Size = New System.Drawing.Size(337, 39)
            Me.groupBox6.TabIndex = 78
            Me.groupBox6.TabStop = False
            Me.groupBox6.Text = "Rendering Engine:"
            '
            'geckoRadioBtn
            '
            Me.geckoRadioBtn.AutoSize = True
            Me.geckoRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.geckoRadioBtn.Location = New System.Drawing.Point(178, 17)
            Me.geckoRadioBtn.Name = "geckoRadioBtn"
            Me.geckoRadioBtn.Size = New System.Drawing.Size(103, 18)
            Me.geckoRadioBtn.TabIndex = 4
            Me.geckoRadioBtn.TabStop = True
            Me.geckoRadioBtn.Text = "Gecko (Firefox)"
            Me.geckoRadioBtn.UseVisualStyleBackColor = True
            '
            'mshtmlRadioBtn
            '
            Me.mshtmlRadioBtn.AutoSize = True
            Me.mshtmlRadioBtn.Checked = True
            Me.mshtmlRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.mshtmlRadioBtn.Location = New System.Drawing.Point(16, 17)
            Me.mshtmlRadioBtn.Name = "mshtmlRadioBtn"
            Me.mshtmlRadioBtn.Size = New System.Drawing.Size(163, 18)
            Me.mshtmlRadioBtn.TabIndex = 3
            Me.mshtmlRadioBtn.TabStop = True
            Me.mshtmlRadioBtn.Text = "MSHTML (Internet Explorer)"
            Me.mshtmlRadioBtn.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(372, 585)
            Me.Controls.Add(Me.txtUrl)
            Me.Controls.Add(Me.groupBox6)
            Me.Controls.Add(Me.pictureBox3)
            Me.Controls.Add(Me.groupBox3)
            Me.Controls.Add(Me.chkFooter)
            Me.Controls.Add(Me.chkHeader)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.label10)
            Me.Controls.Add(Me.groupBox4)
            Me.Controls.Add(Me.groupBox5)
            Me.Controls.Add(Me.nudMargin)
            Me.Controls.Add(Me.label8)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "HTML to PDF"
            Me.groupBox4.ResumeLayout(False)
            Me.groupBox4.PerformLayout()
            CType(Me.nudMargin, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox5.ResumeLayout(False)
            Me.groupBox5.PerformLayout()
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.groupBox3.ResumeLayout(False)
            Me.groupBox3.PerformLayout()
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox6.ResumeLayout(False)
            Me.groupBox6.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub
		#End Region

		#Region "Events"
		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			If Me.rBtnPageBreak.Checked AndAlso rdbBitmap.Checked Then
				MessageBox.Show("PageBreak option work only with Metafile ImageType. Page-break will not be recognized if we try convert it to Bitmap." & Constants.vbLf + Constants.vbLf & "Please select Metafile ImageType.")
				Return
			End If

			Dim document As PdfDocument

			' Create a new instance of PdfDocument class.
			If chkPDFA1.Checked Then
				' Set conformance.
				document = New PdfDocument(PdfConformanceLevel.Pdf_A1B)
			Else
				document = New PdfDocument()
			End If

			'Set page margins.
			document.PageSettings.SetMargins(CSng(Me.nudMargin.Value))

			'Set page orientation.
			If rdoPortrait.Checked Then
				document.PageSettings.Orientation = PdfPageOrientation.Portrait
			Else
				document.PageSettings.Orientation = PdfPageOrientation.Landscape
			End If

			'Set rotation.
			document.PageSettings.Rotate = CType(System.Enum.Parse(GetType(PdfPageRotateAngle), Me.comboBox1.SelectedItem.ToString()), PdfPageRotateAngle)

			Dim page As PdfPage = Nothing
			Dim pageSize As SizeF = SizeF.Empty
			Dim convertor As New PdfUnitConvertor()
			Dim width As Single = -1
			Dim height As Single = -1
			Dim dimension As AspectRatio = AspectRatio.None

			If Not chkTag.Checked Then
				page = document.Pages.Add()

				pageSize = page.GetClientSize()

				'Calculates the height and width of the pdf image.
				If rdoHeight.Checked Then
					dimension = AspectRatio.KeepHeight
					height = convertor.ConvertToPixels(page.GetClientSize().Height, PdfGraphicsUnit.Point)
				ElseIf rdoWidth.Checked Then
					dimension = AspectRatio.KeepWidth
					width = convertor.ConvertToPixels(page.GetClientSize().Width, PdfGraphicsUnit.Point)
				End If
			Else
				width = convertor.ConvertToPixels(document.PageSettings.Width, PdfGraphicsUnit.Point)
				height = convertor.ConvertToPixels(document.PageSettings.Height, PdfGraphicsUnit.Point)
			End If

			'Adding Header
			If chkHeader.Checked Then
				Me.AddHeader(document, "Syncfusion Essential PDF", " ")
			End If

			'Adding Footer
			If chkFooter.Checked Then
				Me.AddFooter(document, "@Copyright 2011")
			End If

			' Layout format for Metafile.
			Dim metafileFormat As New PdfMetafileLayoutFormat()
			metafileFormat.Break = PdfLayoutBreakType.FitPage
			metafileFormat.Layout = PdfLayoutType.Paginate
			metafileFormat.SplitTextLines = Me.chk_TextBreak.Checked
			metafileFormat.SplitImages = Me.rBtnImageBreak.Checked

			' Layout format for Bitmap.
			Dim bitmapFormat As New PdfLayoutFormat()
			bitmapFormat.Break = PdfLayoutBreakType.FitPage
			bitmapFormat.Layout = PdfLayoutType.Paginate

			If mshtmlRadioBtn.Checked Then
				' Create a new instance of HtmlConverter class.
				Using html As New HtmlConverter()
					' Turn on JavaScript execution.
					html.EnableJavaScript = Me.chkJavaScript.Checked

					' Enable auto detect page break.
					html.AutoDetectPageBreak = Me.rBtnPageBreak.Checked

					' Enable hyperlinks in the document.
					html.EnableHyperlinks = Me.chkHyperlink.Checked

					' Convert to metafile.
					If rdbMetafile.Checked AndAlso (Not chkTag.Checked) Then
						Using result As HtmlToPdfResult = html.Convert(txtUrl.Text, ImageType.Metafile, CInt(Fix(width)), CInt(Fix(height)), dimension)
							If result.RenderedImage Is Nothing Then
								Return
							End If

							' Draw metafile in PdfPage.
							result.Render(page, metafileFormat)
						End Using
					' Convert to Bitmap.
					ElseIf rdbBitmap.Checked Then
						Using img As Image = html.ConvertToImage(txtUrl.Text, ImageType.Bitmap, CInt(Fix(width)), CInt(Fix(height)), dimension)
							If img Is Nothing Then
								Return
							End If

							Dim image As PdfImage = New PdfBitmap(img)

							' Draw bitmap in PdfPage.
							If img.Size.Width > pageSize.Width Then
								image.Draw(page, New RectangleF(0, 0, img.Width, -1), bitmapFormat)
							Else
								image.Draw(page, New RectangleF(0, 0, pageSize.Width, -1), bitmapFormat)
							End If
						End Using
					ElseIf chkTag.Checked Then
						' Convert to Tagged PDF.
						html.ConvertToTaggedPDF(document, txtUrl.Text)
					End If
				End Using
			ElseIf geckoRadioBtn.Checked Then
				Using renderer As New GeckoHtmlRendererControl()
					Using converter As New HtmlConverter(renderer)
                        Using result As HtmlToPdfResult = converter.Convert(txtUrl.Text, ImageType.Metafile, CInt(Fix(width)), CInt(Fix(height)), dimension)
                            result.Render(document)
                        End Using
                    End Using
                End Using
            End If

            ' Save and close the document.
            document.Save("Sample.pdf")
            document.Close(True)

            'Message box confirmation to view the created PDF document.
            If MessageBox.Show("Do you want to view the PDF file?", "PDF File Created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                'Launching the PDF file using the default Application.[Acrobat Reader]
                System.Diagnostics.Process.Start("Sample.pdf")
                Me.Close()
            Else
                ' Exit
                Me.Close()
            End If
		End Sub

		''' <summary>
		''' Gets the HTML file path.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			If dlgOpen.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				txtUrl.Text = dlgOpen.FileName
			End If
		End Sub

		''' <summary>
		''' Handles Bitmap and Pagebreak options.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub rdbBitmap_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdbBitmap.CheckedChanged
			Me.rBtnPageBreak.Enabled = Not Me.rdbBitmap.Checked
			Me.rBtnPageBreak.Checked = False
		End Sub

		''' <summary>
		''' Resets the converter options for metafile and bitmap formats.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub rdbMetafile_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdbMetafile.CheckedChanged
			If rdbMetafile.Checked Then
				Me.chk_TextBreak.Enabled = True
				Me.rBtnImageBreak.Enabled = True
				Me.rBtnPageBreak.Enabled = True
				Me.chkHyperlink.Enabled = True
				Me.chkPDFA1.Enabled = True
				Me.chkHyperlink.Checked = True
				Me.rBtnImageBreak.Checked = True
				Me.groupBox3.Enabled = True
				Me.chkTag.Enabled = True
			Else
				Me.chk_TextBreak.Enabled = False
				Me.rBtnImageBreak.Enabled = False
				Me.chk_TextBreak.Checked = False
				Me.rBtnImageBreak.Checked = False
				Me.rBtnPageBreak.Enabled = False
				Me.rBtnPageBreak.Checked = False
				Me.chkHyperlink.Enabled = False
				Me.chkHyperlink.Checked = False
				Me.chkPDFA1.Enabled = False
				Me.chkPDFA1.Checked = False
				Me.groupBox3.Enabled = False
                Me.chkTag.Enabled = False
                Me.chkTag.Checked = False
			End If
		End Sub

		''' <summary>
		''' Handles JavaScript option for PDF documents with conformance.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub chkPDFA1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkPDFA1.CheckedChanged
			If chkPDFA1.Checked Then
				chkJavaScript.Visible = False
			Else
				chkJavaScript.Visible = True
			End If
		End Sub

		Private Sub engine_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles geckoRadioBtn.CheckedChanged, mshtmlRadioBtn.CheckedChanged
			Dim args As New EventArgs()
			If mshtmlRadioBtn.Checked Then
				Me.rdbBitmap.Enabled = True
				Me.groupBox3.Enabled = True
				Me.groupBox1.Enabled = True

				If rdbMetafile.Checked Then
					rdbMetafile_CheckedChanged(Me, args)
				ElseIf rdbBitmap.Checked Then
					rdbBitmap_CheckedChanged(Me, args)
				End If
			ElseIf geckoRadioBtn.Checked Then
				Me.rdbBitmap.Enabled = False
				Me.groupBox3.Enabled = False
				Me.groupBox1.Enabled = False
			End If
        End Sub

        Private Sub chkTag_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkTag.CheckedChanged
            If chkTag.Checked Then
                chkHyperlink.Enabled = False
            Else
                chkHyperlink.Enabled = True
            End If
        End Sub
		#End Region

		#Region "Helper Methods"
		''' <summary>
		''' Draws header to the document.
		''' </summary>
		Private Sub AddHeader(ByVal doc As PdfDocument, ByVal title As String, ByVal description As String)
			Dim rect As New RectangleF(0, 0, doc.PageSettings.Width, 50)
			'Create a new instance of PdfPageTemplateElement class.
			Dim header As New PdfPageTemplateElement(rect)
			Dim g As PdfGraphics = header.Graphics

			'Draw the image in the Header.
			Dim imageSize As New SizeF(110f, 35f)
			'Locating the logo on the right corner.
			Dim imageLocation As New PointF(doc.PageSettings.Width - imageSize.Width - 20, 5)
			Dim img As PdfImage = New PdfBitmap(GetFullTemplatePath("logo.png", True))
			g.DrawImage(img, imageLocation, imageSize)

			'Draw title.
			Dim font As PdfFont = New PdfTrueTypeFont(New Font("Helvetica", 16, FontStyle.Bold), True)
			Dim brush As New PdfSolidBrush(Color.FromArgb(44, 71, 120))
			Dim format As New PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle)
			g.DrawString(title, font, brush, New RectangleF(PointF.Empty, header.Size), format)

			'Draw description
			brush = New PdfSolidBrush(Color.Gray)
			font = New PdfTrueTypeFont(New Font("Helvetica", 6, FontStyle.Bold), True)
			format = New PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Bottom)
			g.DrawString(description, font, brush, New RectangleF(0, 0, header.Width, header.Height - 8), format)

			'Draw some lines in the header
			Dim pen As New PdfPen(Color.DarkBlue, 0.7f)
			g.DrawLine(pen, 0, 0, header.Width, 0)
			pen = New PdfPen(Color.DarkBlue, 2f)
			g.DrawLine(pen, 0, 03, header.Width + 3, 03)
			pen = New PdfPen(Color.DarkBlue, 2f)
			g.DrawLine(pen, 0, header.Height - 3, header.Width, header.Height - 3)
			g.DrawLine(pen, 0, header.Height, header.Width, header.Height)

			'Add header template at the top.
			doc.Template.Top = header
		End Sub

		''' <summary>
		''' Draws footer to the document.
		''' </summary>
		Private Sub AddFooter(ByVal doc As PdfDocument, ByVal footerText As String)
			Dim rect As New RectangleF(0, 0, doc.PageSettings.Width, 50)
			'Create a new instance of PdfPageTemplateElement class.
			Dim footer As New PdfPageTemplateElement(rect)
			Dim g As PdfGraphics = footer.Graphics

			' Draw footer text.
			Dim brush As New PdfSolidBrush(Color.Gray)
			Dim font As PdfFont = New PdfTrueTypeFont(New Font("Helvetica", 6, FontStyle.Bold), True)
			Dim format As New PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle)
			g.DrawString(footerText, font, brush, New RectangleF(0, 18, footer.Width, footer.Height), format)

			'Create page number field
			Dim pageNumber As New PdfPageNumberField(font, brush)

			'Create page count field
			Dim count As New PdfPageCountField(font, brush)

			Dim compositeField As New PdfCompositeField(font, brush, "Page {0} of {1}", pageNumber, count)
			compositeField.Bounds = footer.Bounds
			compositeField.Draw(g, New PointF(470, 40))

			'Add the footer template at the bottom
			doc.Template.Bottom = footer
		End Sub

		''' <summary>
		''' Gets the full path of the PDF template or image.
		''' </summary>
		''' <param name="fileName">Name of the file</param>
		''' <param name="image">True if image</param>
		''' <returns>Path of the file</returns>
		Private Function GetFullTemplatePath(ByVal fileName As String, ByVal image As Boolean) As String
			Dim fullPath As String = "..\..\..\..\..\..\..\..\..\Common\"
			Dim folder As String
			If image Then
				folder = "Images"
			Else
				folder = "Data"
			End If

			Return String.Format("{0}{1}\PDF\{2}", fullPath, folder, fileName)
		End Function
		#End Region

	End Class
End Namespace