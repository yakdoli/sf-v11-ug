Imports Microsoft.VisualBasic
Imports System
Namespace EssentialBlocks
	Public Partial Class AboutForm
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.label1 = New System.Windows.Forms.Label
            Me.linkLabel1 = New System.Windows.Forms.LinkLabel
            Me.closeBtn = New Syncfusion.Windows.Forms.ButtonAdv
            Me.label2 = New System.Windows.Forms.Label
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(303, 62)
            Me.pictureBox1.TabIndex = 0
            Me.pictureBox1.TabStop = False
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(45, 101)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(218, 14)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Made with Syncfusion Essential Studio v5.2"
            '
            'linkLabel1
            '
            Me.linkLabel1.AutoSize = True
            Me.linkLabel1.Location = New System.Drawing.Point(83, 120)
            Me.linkLabel1.Name = "linkLabel1"
            Me.linkLabel1.Size = New System.Drawing.Size(138, 13)
            Me.linkLabel1.TabIndex = 2
            Me.linkLabel1.TabStop = True
            Me.linkLabel1.Text = "http://www.syncfusion.com"
            '
            'closeBtn
            '
            Me.closeBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.closeBtn.KeepFocusRectangle = False
            Me.closeBtn.Location = New System.Drawing.Point(115, 140)
            Me.closeBtn.Name = "closeBtn"
            Me.closeBtn.Size = New System.Drawing.Size(75, 23)
            Me.closeBtn.TabIndex = 3
            Me.closeBtn.Text = "Close"
            Me.closeBtn.UseVisualStyle = True
            Me.closeBtn.UseVisualStyleBackColor = True
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(51, Byte), Integer))
            Me.label2.Location = New System.Drawing.Point(85, 73)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(136, 19)
            Me.label2.TabIndex = 4
            Me.label2.Text = "Essential Blocks"
            '
            'AboutForm
            '
            Me.AcceptButton = Me.closeBtn
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(303, 169)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.closeBtn)
            Me.Controls.Add(Me.linkLabel1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.pictureBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(315, 200)
            Me.MinimizeBox = False
            Me.MinimumSize = New System.Drawing.Size(315, 200)
            Me.Name = "AboutForm"
            Me.ShowIcon = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "About Essential Blocks"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private label1 As System.Windows.Forms.Label
		Private linkLabel1 As System.Windows.Forms.LinkLabel
		Private WithEvents closeBtn As Syncfusion.Windows.Forms.ButtonAdv
		Private label2 As System.Windows.Forms.Label
	End Class
End Namespace