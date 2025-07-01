#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Namespace Hyperlinks
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.createBtn = New System.Windows.Forms.Button()
            Me.label2 = New System.Windows.Forms.Label()
            Me.detailsListBox = New System.Windows.Forms.ListBox()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.webRadioButton = New System.Windows.Forms.RadioButton()
            Me.mailRadioButton = New System.Windows.Forms.RadioButton()
            Me.fileRadioButton = New System.Windows.Forms.RadioButton()
            Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.bkRadioButton = New System.Windows.Forms.RadioButton()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.browseButton = New System.Windows.Forms.Button()
            Me.textBox2 = New System.Windows.Forms.TextBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.groupBox2 = New System.Windows.Forms.GroupBox()
            Me.label7 = New System.Windows.Forms.Label()
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.label24 = New System.Windows.Forms.Label()
            Me.templateBtn = New System.Windows.Forms.Button()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.word2013RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2010RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2003RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2007RadioBtn = New System.Windows.Forms.RadioButton()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.SuspendLayout()
            '
            'createBtn
            '
            Me.createBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.createBtn.BackColor = System.Drawing.Color.Transparent
            Me.createBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.createBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.createBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.createBtn.Image = CType(resources.GetObject("createBtn.Image"), System.Drawing.Image)
            Me.createBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.createBtn.Location = New System.Drawing.Point(269, 426)
            Me.createBtn.Name = "createBtn"
            Me.createBtn.Size = New System.Drawing.Size(100, 28)
            Me.createBtn.TabIndex = 78
            Me.createBtn.Text = "Generate"
            Me.createBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.createBtn.UseVisualStyleBackColor = False
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(0, 97)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(370, 58)
            Me.label2.TabIndex = 79
            Me.label2.Text = resources.GetString("label2.Text")
            '
            'detailsListBox
            '
            Me.detailsListBox.FormattingEnabled = True
            Me.detailsListBox.Location = New System.Drawing.Point(4, 54)
            Me.detailsListBox.Name = "detailsListBox"
            Me.detailsListBox.ScrollAlwaysVisible = True
            Me.detailsListBox.Size = New System.Drawing.Size(348, 56)
            Me.detailsListBox.TabIndex = 83
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(374, 90)
            Me.pictureBox1.TabIndex = 61
            Me.pictureBox1.TabStop = False
            '
            'webRadioButton
            '
            Me.webRadioButton.AutoSize = True
            Me.webRadioButton.Location = New System.Drawing.Point(4, 24)
            Me.webRadioButton.Name = "webRadioButton"
            Me.webRadioButton.Size = New System.Drawing.Size(48, 17)
            Me.webRadioButton.TabIndex = 86
            Me.webRadioButton.Text = "Web"
            Me.webRadioButton.UseVisualStyleBackColor = True
            '
            'mailRadioButton
            '
            Me.mailRadioButton.AutoSize = True
            Me.mailRadioButton.Location = New System.Drawing.Point(106, 24)
            Me.mailRadioButton.Name = "mailRadioButton"
            Me.mailRadioButton.Size = New System.Drawing.Size(50, 17)
            Me.mailRadioButton.TabIndex = 87
            Me.mailRadioButton.Text = "Email"
            Me.mailRadioButton.UseVisualStyleBackColor = True
            '
            'fileRadioButton
            '
            Me.fileRadioButton.AutoSize = True
            Me.fileRadioButton.Location = New System.Drawing.Point(194, 24)
            Me.fileRadioButton.Name = "fileRadioButton"
            Me.fileRadioButton.Size = New System.Drawing.Size(41, 17)
            Me.fileRadioButton.TabIndex = 88
            Me.fileRadioButton.Text = "File"
            Me.fileRadioButton.UseVisualStyleBackColor = True
            '
            'openFileDialog1
            '
            Me.openFileDialog1.FileName = "openFileDialog1"
            '
            'bkRadioButton
            '
            Me.bkRadioButton.AutoSize = True
            Me.bkRadioButton.Location = New System.Drawing.Point(279, 24)
            Me.bkRadioButton.Name = "bkRadioButton"
            Me.bkRadioButton.Size = New System.Drawing.Size(73, 17)
            Me.bkRadioButton.TabIndex = 94
            Me.bkRadioButton.TabStop = True
            Me.bkRadioButton.Text = "Bookmark"
            Me.bkRadioButton.UseVisualStyleBackColor = True
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.browseButton)
            Me.groupBox1.Controls.Add(Me.textBox2)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.textBox1)
            Me.groupBox1.Location = New System.Drawing.Point(6, 280)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(361, 81)
            Me.groupBox1.TabIndex = 102
            Me.groupBox1.TabStop = False
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Image = CType(resources.GetObject("label1.Image"), System.Drawing.Image)
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label1.Location = New System.Drawing.Point(7, -3)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(108, 20)
            Me.label1.TabIndex = 98
            Me.label1.Text = "Edit Hyperlink"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(9, 22)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(35, 13)
            Me.label4.TabIndex = 85
            Me.label4.Text = "label4"
            '
            'browseButton
            '
            Me.browseButton.Enabled = False
            Me.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.browseButton.Location = New System.Drawing.Point(333, 55)
            Me.browseButton.Name = "browseButton"
            Me.browseButton.Size = New System.Drawing.Size(19, 20)
            Me.browseButton.TabIndex = 89
            Me.browseButton.Text = "..."
            Me.browseButton.UseVisualStyleBackColor = True
            '
            'textBox2
            '
            Me.textBox2.Location = New System.Drawing.Point(119, 55)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(188, 20)
            Me.textBox2.TabIndex = 91
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(9, 55)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(35, 13)
            Me.label3.TabIndex = 90
            Me.label3.Text = "label3"
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(119, 19)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(188, 20)
            Me.textBox1.TabIndex = 84
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.label7)
            Me.groupBox2.Controls.Add(Me.detailsListBox)
            Me.groupBox2.Controls.Add(Me.bkRadioButton)
            Me.groupBox2.Controls.Add(Me.webRadioButton)
            Me.groupBox2.Controls.Add(Me.mailRadioButton)
            Me.groupBox2.Controls.Add(Me.fileRadioButton)
            Me.groupBox2.Location = New System.Drawing.Point(6, 158)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(363, 119)
            Me.groupBox2.TabIndex = 103
            Me.groupBox2.TabStop = False
            '
            'label7
            '
            Me.label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label7.Image = CType(resources.GetObject("label7.Image"), System.Drawing.Image)
            Me.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label7.Location = New System.Drawing.Point(7, -3)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(121, 20)
            Me.label7.TabIndex = 98
            Me.label7.Text = "Select Hyperlink"
            Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label6
            '
            Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
            Me.Label6.Location = New System.Drawing.Point(221, 48)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(20, 18)
            Me.Label6.TabIndex = 106
            Me.toolTip1.SetToolTip(Me.Label6, "Saves the document in Word 2013 format")
            '
            'Label5
            '
            Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
            Me.Label5.Location = New System.Drawing.Point(106, 48)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(20, 18)
            Me.Label5.TabIndex = 104
            Me.toolTip1.SetToolTip(Me.Label5, "Saves the document in Word 2010 format")
            '
            'Label8
            '
            Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
            Me.Label8.Location = New System.Drawing.Point(221, 20)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(20, 18)
            Me.Label8.TabIndex = 101
            Me.toolTip1.SetToolTip(Me.Label8, "Saves the document in Word 2007 format")
            '
            'label24
            '
            Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
            Me.label24.Location = New System.Drawing.Point(107, 20)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 100
            Me.toolTip1.SetToolTip(Me.label24, "Saves the document in Word 97-2003 format")
            '
            'templateBtn
            '
            Me.templateBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.templateBtn.BackColor = System.Drawing.Color.Transparent
            Me.templateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.templateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.templateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.templateBtn.Image = CType(resources.GetObject("templateBtn.Image"), System.Drawing.Image)
            Me.templateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.templateBtn.Location = New System.Drawing.Point(269, 391)
            Me.templateBtn.Name = "templateBtn"
            Me.templateBtn.Size = New System.Drawing.Size(100, 28)
            Me.templateBtn.TabIndex = 104
            Me.templateBtn.Text = "View Template"
            Me.templateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.templateBtn.UseVisualStyleBackColor = False
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.Label6)
            Me.GroupBox3.Controls.Add(Me.word2013RadioBtn)
            Me.GroupBox3.Controls.Add(Me.Label5)
            Me.GroupBox3.Controls.Add(Me.word2010RadioBtn)
            Me.GroupBox3.Controls.Add(Me.Label8)
            Me.GroupBox3.Controls.Add(Me.label24)
            Me.GroupBox3.Controls.Add(Me.word2003RadioBtn)
            Me.GroupBox3.Controls.Add(Me.word2007RadioBtn)
            Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(6, 382)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(251, 72)
            Me.GroupBox3.TabIndex = 105
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Save As"
            '
            'word2013RadioBtn
            '
            Me.word2013RadioBtn.AutoSize = True
            Me.word2013RadioBtn.Checked = True
            Me.word2013RadioBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.word2013RadioBtn.Location = New System.Drawing.Point(139, 46)
            Me.word2013RadioBtn.Name = "word2013RadioBtn"
            Me.word2013RadioBtn.Size = New System.Drawing.Size(86, 17)
            Me.word2013RadioBtn.TabIndex = 105
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
            Me.word2010RadioBtn.TabIndex = 103
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
            Me.ClientSize = New System.Drawing.Size(374, 472)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.templateBtn)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.createBtn)
            Me.Controls.Add(Me.pictureBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Hyperlink"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents createBtn As System.Windows.Forms.Button
        Private label2 As System.Windows.Forms.Label
        Private detailsListBox As System.Windows.Forms.ListBox
        Private pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents webRadioButton As System.Windows.Forms.RadioButton
        Private WithEvents mailRadioButton As System.Windows.Forms.RadioButton
        Private WithEvents fileRadioButton As System.Windows.Forms.RadioButton
        Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
        Private WithEvents bkRadioButton As System.Windows.Forms.RadioButton
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private label1 As System.Windows.Forms.Label
        Private label4 As System.Windows.Forms.Label
        Private WithEvents browseButton As System.Windows.Forms.Button
        Private textBox2 As System.Windows.Forms.TextBox
        Private label3 As System.Windows.Forms.Label
        Private textBox1 As System.Windows.Forms.TextBox
        Private groupBox2 As System.Windows.Forms.GroupBox
        Private label7 As System.Windows.Forms.Label
        Private toolTip1 As System.Windows.Forms.ToolTip
        Private WithEvents templateBtn As System.Windows.Forms.Button
        Private WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Private WithEvents Label6 As System.Windows.Forms.Label
        Private WithEvents word2013RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents Label5 As System.Windows.Forms.Label
        Private WithEvents word2010RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents Label8 As System.Windows.Forms.Label
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents word2003RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2007RadioBtn As System.Windows.Forms.RadioButton
    End Class
End Namespace

