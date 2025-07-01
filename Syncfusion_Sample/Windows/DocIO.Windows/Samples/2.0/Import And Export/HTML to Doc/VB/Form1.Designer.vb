#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Namespace HTMLToDoc_2005
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
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.button2 = New System.Windows.Forms.Button()
            Me.label5 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.label24 = New System.Windows.Forms.Label()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.panel4 = New System.Windows.Forms.Panel()
            Me.outpuTextBox = New System.Windows.Forms.TextBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.button3 = New System.Windows.Forms.Button()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.word2013RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2010RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2003RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2007RadioBtn = New System.Windows.Forms.RadioButton()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            Me.panel4.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(374, 88)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox1.TabIndex = 61
            Me.pictureBox1.TabStop = False
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label1.Location = New System.Drawing.Point(34, 332)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(48, 22)
            Me.label1.TabIndex = 68
            Me.label1.Text = "Output"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
            Me.button1.Location = New System.Drawing.Point(285, 569)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(77, 25)
            Me.button1.TabIndex = 67
            Me.button1.Text = "Generate"
            Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button1.UseVisualStyleBackColor = False
            '
            'button2
            '
            Me.button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button2.BackColor = System.Drawing.Color.Transparent
            Me.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.button2.Location = New System.Drawing.Point(7, 2)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(112, 21)
            Me.button2.TabIndex = 68
            Me.button2.Text = "Copy Html From File"
            Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.toolTip1.SetToolTip(Me.button2, "Select the HTML file to be converted or " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "enter the HTML text in the textbox ")
            Me.button2.UseVisualStyleBackColor = False
            '
            'label5
            '
            Me.label5.Image = CType(resources.GetObject("label5.Image"), System.Drawing.Image)
            Me.label5.Location = New System.Drawing.Point(221, 48)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(20, 18)
            Me.label5.TabIndex = 104
            Me.toolTip1.SetToolTip(Me.label5, "Saves the document in Word 2013 format")
            '
            'label3
            '
            Me.label3.Image = CType(resources.GetObject("label3.Image"), System.Drawing.Image)
            Me.label3.Location = New System.Drawing.Point(106, 48)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(20, 18)
            Me.label3.TabIndex = 102
            Me.toolTip1.SetToolTip(Me.label3, "Saves the document in Word 2010 format")
            '
            'Label2
            '
            Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
            Me.Label2.Location = New System.Drawing.Point(221, 20)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(20, 18)
            Me.Label2.TabIndex = 101
            Me.toolTip1.SetToolTip(Me.Label2, "Saves the document in Word 2007 format")
            '
            'label24
            '
            Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
            Me.label24.Location = New System.Drawing.Point(106, 22)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 100
            Me.toolTip1.SetToolTip(Me.label24, "Saves the document in Word 97-2003 format" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'textBox1
            '
            Me.textBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.textBox1.Location = New System.Drawing.Point(0, 113)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.textBox1.Size = New System.Drawing.Size(374, 211)
            Me.textBox1.TabIndex = 70
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.button2)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel2.Location = New System.Drawing.Point(0, 88)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(374, 25)
            Me.panel2.TabIndex = 71
            '
            'openFileDialog1
            '
            Me.openFileDialog1.FileName = "openFileDialog1"
            '
            'panel4
            '
            Me.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel4.Controls.Add(Me.outpuTextBox)
            Me.panel4.Location = New System.Drawing.Point(8, 344)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(362, 154)
            Me.panel4.TabIndex = 73
            '
            'outpuTextBox
            '
            Me.outpuTextBox.Location = New System.Drawing.Point(7, 16)
            Me.outpuTextBox.Multiline = True
            Me.outpuTextBox.Name = "outpuTextBox"
            Me.outpuTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.outpuTextBox.Size = New System.Drawing.Size(341, 125)
            Me.outpuTextBox.TabIndex = 76
            '
            'label4
            '
            Me.label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(178, Byte), Integer))
            Me.label4.Location = New System.Drawing.Point(82, 344)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(287, 1)
            Me.label4.TabIndex = 74
            Me.label4.Text = "label4"
            '
            'button3
            '
            Me.button3.Location = New System.Drawing.Point(4, 335)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(20, 20)
            Me.button3.TabIndex = 75
            Me.button3.Text = "+"
            Me.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.button3.UseVisualStyleBackColor = True
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.label5)
            Me.groupBox1.Controls.Add(Me.word2013RadioBtn)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.Label2)
            Me.groupBox1.Controls.Add(Me.label24)
            Me.groupBox1.Controls.Add(Me.word2010RadioBtn)
            Me.groupBox1.Controls.Add(Me.word2003RadioBtn)
            Me.groupBox1.Controls.Add(Me.word2007RadioBtn)
            Me.groupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(8, 518)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(251, 76)
            Me.groupBox1.TabIndex = 101
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
            Me.word2010RadioBtn.Location = New System.Drawing.Point(8, 46)
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
            Me.ClientSize = New System.Drawing.Size(374, 607)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.button3)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.panel4)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.pictureBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "HTML to Doc"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            Me.panel4.ResumeLayout(False)
            Me.panel4.PerformLayout()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private pictureBox1 As System.Windows.Forms.PictureBox
        Private label1 As System.Windows.Forms.Label
        Private WithEvents button1 As System.Windows.Forms.Button
		Private toolTip1 As System.Windows.Forms.ToolTip
		Private textBox1 As System.Windows.Forms.TextBox
		Private panel2 As System.Windows.Forms.Panel
		Private WithEvents button2 As System.Windows.Forms.Button
		Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
		Private panel4 As System.Windows.Forms.Panel
		Private label4 As System.Windows.Forms.Label
		Private WithEvents button3 As System.Windows.Forms.Button
        Private outpuTextBox As System.Windows.Forms.TextBox
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents word2013RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents Label2 As System.Windows.Forms.Label
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents word2010RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2003RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2007RadioBtn As System.Windows.Forms.RadioButton
    End Class
End Namespace

