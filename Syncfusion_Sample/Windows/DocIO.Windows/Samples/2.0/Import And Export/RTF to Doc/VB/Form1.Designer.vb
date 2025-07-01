#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Namespace RTFToDoc
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
            Me.label2 = New System.Windows.Forms.Label()
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.label4 = New System.Windows.Forms.Label()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.toolTip2 = New System.Windows.Forms.ToolTip(Me.components)
            Me.label1 = New System.Windows.Forms.Label()
            Me.button3 = New System.Windows.Forms.Button()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.label9 = New System.Windows.Forms.Label()
            Me.btnRTFToDoc = New System.Windows.Forms.Button()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(0, 100)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(374, 44)
            Me.label2.TabIndex = 72
            Me.label2.Text = "Click the button to view the Word document converted from RTF using Essential Doc" & _
                "IO. Please note that MS Word Viewer or MS Word is required to view the resultant" & _
                " document."
            '
            'label4
            '
            Me.label4.Image = CType(resources.GetObject("label4.Image"), System.Drawing.Image)
            Me.label4.Location = New System.Drawing.Point(106, 157)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(20, 18)
            Me.label4.TabIndex = 100
            Me.toolTip2.SetToolTip(Me.label4, "Browse for a word document to convert it to RTF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(374, 88)
            Me.pictureBox1.TabIndex = 69
            Me.pictureBox1.TabStop = False
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(116, 159)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(20, 18)
            Me.label1.TabIndex = 98
            Me.toolTip2.SetToolTip(Me.label1, "Browse for a word document to convert it to Pdf")
            '
            'button3
            '
            Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button3.Location = New System.Drawing.Point(347, 177)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(21, 21)
            Me.button3.TabIndex = 97
            Me.button3.Text = ". . ."
            Me.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.button3.UseVisualStyleBackColor = True
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(3, 178)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(333, 20)
            Me.textBox1.TabIndex = 96
            '
            'openFileDialog1
            '
            Me.openFileDialog1.FileName = "openFileDialog1"
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label9.Location = New System.Drawing.Point(0, 159)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(100, 13)
            Me.label9.TabIndex = 95
            Me.label9.Text = "RTF Document"
            '
            'btnRTFToDoc
            '
            Me.btnRTFToDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnRTFToDoc.BackColor = System.Drawing.Color.Transparent
            Me.btnRTFToDoc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.btnRTFToDoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnRTFToDoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnRTFToDoc.Image = CType(resources.GetObject("btnRTFToDoc.Image"), System.Drawing.Image)
            Me.btnRTFToDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnRTFToDoc.Location = New System.Drawing.Point(288, 233)
            Me.btnRTFToDoc.Name = "btnRTFToDoc"
            Me.btnRTFToDoc.Size = New System.Drawing.Size(80, 25)
            Me.btnRTFToDoc.TabIndex = 100
            Me.btnRTFToDoc.Text = "Generate"
            Me.btnRTFToDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnRTFToDoc.UseVisualStyleBackColor = False
            '
            'Form1
            '
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(374, 286)
            Me.Controls.Add(Me.btnRTFToDoc)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.button3)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "RTF to Doc"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private label2 As Label
        Private toolTip1 As ToolTip
        Private pictureBox1 As PictureBox
		Private toolTip2 As ToolTip
		Private label1 As Label
		Private WithEvents button3 As Button
		Private textBox1 As TextBox
		Private openFileDialog1 As OpenFileDialog
		Private label9 As Label
		Private label4 As Label
        Private WithEvents btnRTFToDoc As Button
    End Class
End Namespace

