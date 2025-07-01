Imports Microsoft.VisualBasic
Imports System
Namespace EssentialBlocks
	Public Partial Class HowToPlayForm
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HowToPlayForm))
            Me.label2 = New System.Windows.Forms.Label
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.label1 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.label8 = New System.Windows.Forms.Label
            Me.label9 = New System.Windows.Forms.Label
            Me.label10 = New System.Windows.Forms.Label
            Me.label11 = New System.Windows.Forms.Label
            Me.label12 = New System.Windows.Forms.Label
            Me.label13 = New System.Windows.Forms.Label
            Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.panel1 = New System.Windows.Forms.Panel
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(51, Byte), Integer))
            Me.label2.Location = New System.Drawing.Point(83, 74)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(136, 19)
            Me.label2.TabIndex = 6
            Me.label2.Text = "Essential Blocks"
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.InitialImage = Nothing
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(325, 62)
            Me.pictureBox1.TabIndex = 5
            Me.pictureBox1.TabStop = False
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.Color.Transparent
            Me.label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.White
            Me.label1.Location = New System.Drawing.Point(3, 6)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(87, 16)
            Me.label1.TabIndex = 7
            Me.label1.Text = "How To Play"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(4, 38)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(265, 13)
            Me.label3.TabIndex = 8
            Me.label3.Text = "Score points by completing lines with the falling blocks."
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.BackColor = System.Drawing.Color.Transparent
            Me.label4.Location = New System.Drawing.Point(4, 67)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(293, 13)
            Me.label4.TabIndex = 9
            Me.label4.Text = "Completing more than one line at once is worth bonus points."
            '
            'label5
            '
            Me.label5.BackColor = System.Drawing.Color.Transparent
            Me.label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.Color.White
            Me.label5.Location = New System.Drawing.Point(4, 126)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(65, 16)
            Me.label5.TabIndex = 10
            Me.label5.Text = "Controls"
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(92, 158)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(128, 13)
            Me.label6.TabIndex = 11
            Me.label6.Text = "Move the falling piece left"
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(92, 221)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(205, 13)
            Me.label7.TabIndex = 12
            Me.label7.Text = "Rotate the falling piece counter-clockwise"
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.BackColor = System.Drawing.Color.Transparent
            Me.label8.Location = New System.Drawing.Point(92, 249)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(130, 13)
            Me.label8.TabIndex = 13
            Me.label8.Text = "Drop the piece one space"
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.BackColor = System.Drawing.Color.Transparent
            Me.label9.Location = New System.Drawing.Point(92, 191)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(134, 13)
            Me.label9.TabIndex = 14
            Me.label9.Text = "Move the falling piece right"
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label10.Location = New System.Drawing.Point(4, 157)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(61, 15)
            Me.label10.TabIndex = 15
            Me.label10.Text = "Left Arrow"
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.BackColor = System.Drawing.Color.Transparent
            Me.label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label11.Location = New System.Drawing.Point(4, 219)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(57, 15)
            Me.label11.TabIndex = 16
            Me.label11.Text = "Up Arrow"
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.BackColor = System.Drawing.Color.Transparent
            Me.label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label12.Location = New System.Drawing.Point(5, 248)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(72, 15)
            Me.label12.TabIndex = 17
            Me.label12.Text = "Down Arrow"
            '
            'label13
            '
            Me.label13.AutoSize = True
            Me.label13.BackColor = System.Drawing.Color.Transparent
            Me.label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label13.Location = New System.Drawing.Point(4, 188)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(70, 15)
            Me.label13.TabIndex = 18
            Me.label13.Text = "Right Arrow"
            '
            'button1
            '
            Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.button1.KeepFocusRectangle = False
            Me.button1.Location = New System.Drawing.Point(116, 387)
            Me.button1.Name = "button1"
            Me.button1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver
            Me.button1.Size = New System.Drawing.Size(75, 23)
            Me.button1.TabIndex = 19
            Me.button1.Text = "Close"
            Me.button1.UseVisualStyle = True
            Me.button1.UseVisualStyleBackColor = True
            '
            'panel1
            '
            Me.panel1.BackgroundImage = CType(resources.GetObject("panel1.BackgroundImage"), System.Drawing.Image)
            Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.label13)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.label12)
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Controls.Add(Me.label11)
            Me.panel1.Controls.Add(Me.label6)
            Me.panel1.Controls.Add(Me.label10)
            Me.panel1.Controls.Add(Me.label7)
            Me.panel1.Controls.Add(Me.label9)
            Me.panel1.Controls.Add(Me.label8)
            Me.panel1.Location = New System.Drawing.Point(8, 104)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(305, 272)
            Me.panel1.TabIndex = 20
            '
            'HowToPlayForm
            '
            Me.AcceptButton = Me.button1
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(325, 421)
            Me.ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "HowToPlayForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Essential Blocks Help"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private label2 As System.Windows.Forms.Label
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private label1 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private label10 As System.Windows.Forms.Label
		Private label11 As System.Windows.Forms.Label
		Private label12 As System.Windows.Forms.Label
		Private label13 As System.Windows.Forms.Label
		Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
		Private panel1 As System.Windows.Forms.Panel
	End Class
End Namespace