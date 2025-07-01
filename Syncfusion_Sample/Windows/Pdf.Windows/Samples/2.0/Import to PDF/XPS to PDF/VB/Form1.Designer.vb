Imports Microsoft.VisualBasic
Imports System
Namespace XPStoPDF_2005
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
            Me.pictureBox3 = New System.Windows.Forms.PictureBox
            Me.label1 = New System.Windows.Forms.Label
            Me.btnXPS2PDF = New System.Windows.Forms.Button
            Me.browseBtn = New System.Windows.Forms.Button
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.label9 = New System.Windows.Forms.Label
            Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.label24 = New System.Windows.Forms.Label
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pictureBox3
            '
            Me.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
            Me.pictureBox3.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox3.Name = "pictureBox3"
            Me.pictureBox3.Size = New System.Drawing.Size(374, 89)
            Me.pictureBox3.TabIndex = 78
            Me.pictureBox3.TabStop = False
            '
            'label1
            '
            Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.label1.Location = New System.Drawing.Point(-1, 96)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(375, 49)
            Me.label1.TabIndex = 101
            Me.label1.Text = resources.GetString("label1.Text")
            '
            'btnXPS2PDF
            '
            Me.btnXPS2PDF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnXPS2PDF.BackColor = System.Drawing.Color.Transparent
            Me.btnXPS2PDF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.btnXPS2PDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnXPS2PDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnXPS2PDF.Image = CType(resources.GetObject("btnXPS2PDF.Image"), System.Drawing.Image)
            Me.btnXPS2PDF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnXPS2PDF.Location = New System.Drawing.Point(270, 204)
            Me.btnXPS2PDF.Name = "btnXPS2PDF"
            Me.btnXPS2PDF.Size = New System.Drawing.Size(92, 23)
            Me.btnXPS2PDF.TabIndex = 0
            Me.btnXPS2PDF.Text = "XPS to PDF"
            Me.btnXPS2PDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnXPS2PDF.UseVisualStyleBackColor = False
            '
            'browseBtn
            '
            Me.browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.browseBtn.Location = New System.Drawing.Point(341, 171)
            Me.browseBtn.Name = "browseBtn"
            Me.browseBtn.Size = New System.Drawing.Size(21, 21)
            Me.browseBtn.TabIndex = 1
            Me.browseBtn.Text = ". . ."
            Me.browseBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.browseBtn.UseVisualStyleBackColor = True
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(12, 172)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(323, 20)
            Me.textBox1.TabIndex = 2
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label9.Location = New System.Drawing.Point(0, 154)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(100, 13)
            Me.label9.TabIndex = 102
            Me.label9.Text = "XPS Document"
            '
            'openFileDialog1
            '
            Me.openFileDialog1.FileName = "openFileDialog1"
            '
            'label24
            '
            Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
            Me.label24.Location = New System.Drawing.Point(96, 150)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 103
            Me.toolTip1.SetToolTip(Me.label24, "Browse for a XPS document to convert it to PDF")
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(374, 238)
            Me.Controls.Add(Me.label24)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.btnXPS2PDF)
            Me.Controls.Add(Me.browseBtn)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.pictureBox3)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "XPS to PDF"
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private pictureBox3 As System.Windows.Forms.PictureBox
        Private label1 As System.Windows.Forms.Label
        Private WithEvents btnXPS2PDF As System.Windows.Forms.Button
        Private WithEvents browseBtn As System.Windows.Forms.Button
		Private textBox1 As System.Windows.Forms.TextBox
		Private label9 As System.Windows.Forms.Label
		Private WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
		Private toolTip1 As System.Windows.Forms.ToolTip
		Private label24 As System.Windows.Forms.Label
	End Class
End Namespace

