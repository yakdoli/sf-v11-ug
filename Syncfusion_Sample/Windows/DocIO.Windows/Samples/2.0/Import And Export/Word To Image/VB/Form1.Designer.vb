#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Namespace Doc_To_Image
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
            Me.bmpRadioBtn = New System.Windows.Forms.RadioButton()
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.label5 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label24 = New System.Windows.Forms.Label()
            Me.emfRadioBtn = New System.Windows.Forms.RadioButton()
            Me.pngRadioBtn = New System.Windows.Forms.RadioButton()
            Me.jpegRadioBtn = New System.Windows.Forms.RadioButton()
            Me.button3 = New System.Windows.Forms.Button()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.label9 = New System.Windows.Forms.Label()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.button1 = New System.Windows.Forms.Button()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.groupBox1.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'bmpRadioBtn
            '
            Me.bmpRadioBtn.AutoSize = True
            Me.bmpRadioBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.bmpRadioBtn.Location = New System.Drawing.Point(193, 22)
            Me.bmpRadioBtn.Name = "bmpRadioBtn"
            Me.bmpRadioBtn.Size = New System.Drawing.Size(49, 17)
            Me.bmpRadioBtn.TabIndex = 103
            Me.bmpRadioBtn.Text = "BMP"
            Me.bmpRadioBtn.UseVisualStyleBackColor = True
            '
            'label5
            '
            Me.label5.Image = CType(resources.GetObject("label5.Image"), System.Drawing.Image)
            Me.label5.Location = New System.Drawing.Point(118, 136)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(20, 18)
            Me.label5.TabIndex = 112
            Me.toolTip1.SetToolTip(Me.label5, "Browse for a word document to convert it to Image")
            '
            'label4
            '
            Me.label4.Image = CType(resources.GetObject("label4.Image"), System.Drawing.Image)
            Me.label4.Location = New System.Drawing.Point(240, 22)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(20, 18)
            Me.label4.TabIndex = 104
            Me.toolTip1.SetToolTip(Me.label4, "Converts the Word document to BMP image")
            '
            'label3
            '
            Me.label3.Image = CType(resources.GetObject("label3.Image"), System.Drawing.Image)
            Me.label3.Location = New System.Drawing.Point(323, 23)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(20, 18)
            Me.label3.TabIndex = 102
            Me.toolTip1.SetToolTip(Me.label3, "Converts the Word document to EMF image")
            '
            'label1
            '
            Me.label1.Image = CType(resources.GetObject("label1.Image"), System.Drawing.Image)
            Me.label1.Location = New System.Drawing.Point(157, 23)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(20, 18)
            Me.label1.TabIndex = 101
            Me.toolTip1.SetToolTip(Me.label1, "Converts the Word document to JPEG image")
            '
            'label24
            '
            Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
            Me.label24.Location = New System.Drawing.Point(66, 21)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 100
            Me.toolTip1.SetToolTip(Me.label24, "Converts the Word document to PNG image.")
            '
            'emfRadioBtn
            '
            Me.emfRadioBtn.AutoSize = True
            Me.emfRadioBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.emfRadioBtn.Location = New System.Drawing.Point(277, 21)
            Me.emfRadioBtn.Name = "emfRadioBtn"
            Me.emfRadioBtn.Size = New System.Drawing.Size(47, 17)
            Me.emfRadioBtn.TabIndex = 46
            Me.emfRadioBtn.Text = "EMF"
            Me.emfRadioBtn.UseVisualStyleBackColor = True
            '
            'pngRadioBtn
            '
            Me.pngRadioBtn.AutoSize = True
            Me.pngRadioBtn.Checked = True
            Me.pngRadioBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.pngRadioBtn.Location = New System.Drawing.Point(13, 22)
            Me.pngRadioBtn.Name = "pngRadioBtn"
            Me.pngRadioBtn.Size = New System.Drawing.Size(47, 17)
            Me.pngRadioBtn.TabIndex = 44
            Me.pngRadioBtn.TabStop = True
            Me.pngRadioBtn.Text = "PNG"
            Me.pngRadioBtn.UseVisualStyleBackColor = True
            '
            'jpegRadioBtn
            '
            Me.jpegRadioBtn.AutoSize = True
            Me.jpegRadioBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.jpegRadioBtn.Location = New System.Drawing.Point(105, 23)
            Me.jpegRadioBtn.Name = "jpegRadioBtn"
            Me.jpegRadioBtn.Size = New System.Drawing.Size(52, 17)
            Me.jpegRadioBtn.TabIndex = 45
            Me.jpegRadioBtn.Text = "JPEG"
            Me.jpegRadioBtn.UseVisualStyleBackColor = True
            '
            'button3
            '
            Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button3.Location = New System.Drawing.Point(349, 154)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(21, 21)
            Me.button3.TabIndex = 111
            Me.button3.Text = ". . ."
            Me.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.button3.UseVisualStyleBackColor = True
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(5, 155)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(333, 20)
            Me.textBox1.TabIndex = 110
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label9.Location = New System.Drawing.Point(2, 136)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(110, 13)
            Me.label9.TabIndex = 109
            Me.label9.Text = "Word Document"
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.bmpRadioBtn)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Controls.Add(Me.label24)
            Me.groupBox1.Controls.Add(Me.emfRadioBtn)
            Me.groupBox1.Controls.Add(Me.pngRadioBtn)
            Me.groupBox1.Controls.Add(Me.jpegRadioBtn)
            Me.groupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(5, 198)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(366, 51)
            Me.groupBox1.TabIndex = 108
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Convert To"
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(7, 103)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(366, 44)
            Me.label2.TabIndex = 107
            Me.label2.Text = "Clicking the button below will result in a Image being converted from word docume" & _
        "nt using Essential DocIO."
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
            Me.button1.Location = New System.Drawing.Point(276, 255)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(95, 25)
            Me.button1.TabIndex = 106
            Me.button1.Text = "WordToImage"
            Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button1.UseVisualStyleBackColor = False
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(375, 97)
            Me.pictureBox1.TabIndex = 105
            Me.pictureBox1.TabStop = False
            '
            'openFileDialog1
            '
            Me.openFileDialog1.FileName = "openFileDialog1"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(375, 291)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.button3)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.pictureBox1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Word to Image"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Private WithEvents bmpRadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents emfRadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents pngRadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents jpegRadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents button3 As System.Windows.Forms.Button
        Private WithEvents textBox1 As System.Windows.Forms.TextBox
        Private WithEvents label9 As System.Windows.Forms.Label
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents button1 As System.Windows.Forms.Button
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog

#End Region

    End Class
End Namespace

