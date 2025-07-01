Namespace ExceltoPDF
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
            Me.label24 = New System.Windows.Forms.Label
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.button3 = New System.Windows.Forms.Button
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.label9 = New System.Windows.Forms.Label
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.excelToPdfConvertbtn = New System.Windows.Forms.Button
            Me.label1 = New System.Windows.Forms.Label
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.onePageRadioBtn = New System.Windows.Forms.RadioButton
            Me.allColumnRadioBtn = New System.Windows.Forms.RadioButton
            Me.allRowsRadioBtn = New System.Windows.Forms.RadioButton
            Me.noScaleRadioBtn = New System.Windows.Forms.RadioButton
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'openFileDialog1
            '
            Me.openFileDialog1.FileName = "openFileDialog1"
            '
            'label24
            '
            Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
            Me.label24.Location = New System.Drawing.Point(120, 235)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 94
            Me.toolTip1.SetToolTip(Me.label24, "Browse for a word document to convert it to Pdf")
            '
            'button3
            '
            Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button3.Location = New System.Drawing.Point(347, 255)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(21, 21)
            Me.button3.TabIndex = 92
            Me.button3.Text = ". . ."
            Me.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.button3.UseVisualStyleBackColor = True
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(6, 256)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(333, 20)
            Me.textBox1.TabIndex = 91
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label9.Location = New System.Drawing.Point(3, 240)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(111, 13)
            Me.label9.TabIndex = 90
            Me.label9.Text = "Excel Document"
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(371, 92)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox1.TabIndex = 89
            Me.pictureBox1.TabStop = False
            '
            'excelToPdfConvertbtn
            '
            Me.excelToPdfConvertbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.excelToPdfConvertbtn.BackColor = System.Drawing.Color.Transparent
            Me.excelToPdfConvertbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.excelToPdfConvertbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.excelToPdfConvertbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.excelToPdfConvertbtn.Image = CType(resources.GetObject("excelToPdfConvertbtn.Image"), System.Drawing.Image)
            Me.excelToPdfConvertbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.excelToPdfConvertbtn.Location = New System.Drawing.Point(246, 282)
            Me.excelToPdfConvertbtn.Name = "excelToPdfConvertbtn"
            Me.excelToPdfConvertbtn.Size = New System.Drawing.Size(96, 23)
            Me.excelToPdfConvertbtn.TabIndex = 96
            Me.excelToPdfConvertbtn.Text = "Excel to PDF"
            Me.excelToPdfConvertbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.excelToPdfConvertbtn.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.label1.Location = New System.Drawing.Point(3, 100)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(365, 61)
            Me.label1.TabIndex = 97
            Me.label1.Text = resources.GetString("label1.Text")
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.onePageRadioBtn)
            Me.groupBox1.Controls.Add(Me.allColumnRadioBtn)
            Me.groupBox1.Controls.Add(Me.allRowsRadioBtn)
            Me.groupBox1.Controls.Add(Me.noScaleRadioBtn)
            Me.groupBox1.Location = New System.Drawing.Point(6, 155)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(363, 81)
            Me.groupBox1.TabIndex = 99
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Pdf Page Setup Options"
            '
            'onePageRadioBtn
            '
            Me.onePageRadioBtn.AutoSize = True
            Me.onePageRadioBtn.Location = New System.Drawing.Point(185, 49)
            Me.onePageRadioBtn.Name = "onePageRadioBtn"
            Me.onePageRadioBtn.Size = New System.Drawing.Size(135, 17)
            Me.onePageRadioBtn.TabIndex = 3
            Me.onePageRadioBtn.Text = "Fit Sheet On One Page"
            Me.onePageRadioBtn.UseVisualStyleBackColor = True
            '
            'allColumnRadioBtn
            '
            Me.allColumnRadioBtn.AutoSize = True
            Me.allColumnRadioBtn.Location = New System.Drawing.Point(23, 49)
            Me.allColumnRadioBtn.Name = "allColumnRadioBtn"
            Me.allColumnRadioBtn.Size = New System.Drawing.Size(161, 17)
            Me.allColumnRadioBtn.TabIndex = 2
            Me.allColumnRadioBtn.Text = "Fit All Columns On One Page"
            Me.allColumnRadioBtn.UseVisualStyleBackColor = True
            '
            'allRowsRadioBtn
            '
            Me.allRowsRadioBtn.AutoSize = True
            Me.allRowsRadioBtn.Location = New System.Drawing.Point(185, 26)
            Me.allRowsRadioBtn.Name = "allRowsRadioBtn"
            Me.allRowsRadioBtn.Size = New System.Drawing.Size(148, 17)
            Me.allRowsRadioBtn.TabIndex = 1
            Me.allRowsRadioBtn.Text = "Fit All Rows On One Page"
            Me.allRowsRadioBtn.UseVisualStyleBackColor = True
            '
            'noScaleRadioBtn
            '
            Me.noScaleRadioBtn.AutoSize = True
            Me.noScaleRadioBtn.Checked = True
            Me.noScaleRadioBtn.Location = New System.Drawing.Point(23, 26)
            Me.noScaleRadioBtn.Name = "noScaleRadioBtn"
            Me.noScaleRadioBtn.Size = New System.Drawing.Size(77, 17)
            Me.noScaleRadioBtn.TabIndex = 0
            Me.noScaleRadioBtn.TabStop = True
            Me.noScaleRadioBtn.Text = "No Scaling"
            Me.noScaleRadioBtn.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(371, 317)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.excelToPdfConvertbtn)
            Me.Controls.Add(Me.label24)
            Me.Controls.Add(Me.button3)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.pictureBox1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Excel to PDF"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private openFileDialog1 As OpenFileDialog
		Private label24 As Label
		Private toolTip1 As ToolTip
		Private WithEvents button3 As Button
		Private textBox1 As TextBox
		Private label9 As Label
		Private pictureBox1 As PictureBox
		Private WithEvents excelToPdfConvertbtn As Button
        Private label1 As Label
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents onePageRadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents allColumnRadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents allRowsRadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents noScaleRadioBtn As System.Windows.Forms.RadioButton

	End Class
End Namespace

