<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EncryptionDecryption
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EncryptionDecryption))
        Me.label13 = New System.Windows.Forms.Label()
        Me.btnDecryptSource = New System.Windows.Forms.Button()
        Me.txtDecryptSource = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.btnDecryption = New System.Windows.Forms.Button()
        Me.txtDeOpen = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.label11 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdbExcel2010Encrypt = New System.Windows.Forms.RadioButton()
        Me.rdbExcel2007Encrypt = New System.Windows.Forms.RadioButton()
        Me.label9 = New System.Windows.Forms.Label()
        Me.btnEncryptSource = New System.Windows.Forms.Button()
        Me.txtEncryptSource = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtEnOpen = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnEncryption = New System.Windows.Forms.Button()
        Me.label12 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdbExcel2010Decrypt = New System.Windows.Forms.RadioButton()
        Me.rdbExcel2007Decrypt = New System.Windows.Forms.RadioButton()
        Me.label4 = New System.Windows.Forms.Label()
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label13
        '
        Me.label13.Location = New System.Drawing.Point(322, 33)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(20, 16)
        Me.label13.TabIndex = 10
        Me.toolTip1.SetToolTip(Me.label13, "Browse a spreadsheet to decrypt and give password")
        '
        'btnDecryptSource
        '
        Me.btnDecryptSource.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDecryptSource.BackColor = System.Drawing.Color.Transparent
        Me.btnDecryptSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecryptSource.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDecryptSource.Location = New System.Drawing.Point(299, 29)
        Me.btnDecryptSource.Name = "btnDecryptSource"
        Me.btnDecryptSource.Size = New System.Drawing.Size(24, 20)
        Me.btnDecryptSource.TabIndex = 6
        Me.btnDecryptSource.Text = "..."
        Me.btnDecryptSource.UseVisualStyleBackColor = False
        '
        'txtDecryptSource
        '
        Me.txtDecryptSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecryptSource.Location = New System.Drawing.Point(110, 29)
        Me.txtDecryptSource.Name = "txtDecryptSource"
        Me.txtDecryptSource.Size = New System.Drawing.Size(185, 20)
        Me.txtDecryptSource.TabIndex = 7
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label8.Location = New System.Drawing.Point(6, 32)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(93, 13)
        Me.label8.TabIndex = 8
        Me.label8.Text = "Source Document"
        '
        'btnDecryption
        '
        Me.btnDecryption.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDecryption.BackColor = System.Drawing.Color.Transparent
        Me.btnDecryption.Enabled = False
        Me.btnDecryption.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecryption.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDecryption.Image = CType(resources.GetObject("btnDecryption.Image"), System.Drawing.Image)
        Me.btnDecryption.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDecryption.Location = New System.Drawing.Point(257, 89)
        Me.btnDecryption.Name = "btnDecryption"
        Me.btnDecryption.Size = New System.Drawing.Size(85, 26)
        Me.btnDecryption.TabIndex = 10
        Me.btnDecryption.Text = "Decrypt"
        Me.btnDecryption.UseVisualStyleBackColor = False
        '
        'txtDeOpen
        '
        Me.txtDeOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeOpen.Location = New System.Drawing.Point(110, 60)
        Me.txtDeOpen.Name = "txtDeOpen"
        Me.txtDeOpen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDeOpen.Size = New System.Drawing.Size(232, 20)
        Me.txtDeOpen.TabIndex = 8
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label10.Location = New System.Drawing.Point(6, 63)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(98, 13)
        Me.label10.TabIndex = 3
        Me.label10.Text = "Password To Open"
        '
        'openFileDialog1
        '
        Me.openFileDialog1.FileName = "openFileDialog1"
        '
        'label11
        '
        Me.label11.BackColor = System.Drawing.Color.MidnightBlue
        Me.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label11.Location = New System.Drawing.Point(29, 13)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(118, 1)
        Me.label11.TabIndex = 2
        Me.label11.Text = "label11"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.groupBox3)
        Me.groupBox1.Controls.Add(Me.label9)
        Me.groupBox1.Controls.Add(Me.btnEncryptSource)
        Me.groupBox1.Controls.Add(Me.txtEncryptSource)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.txtEnOpen)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.btnEncryption)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.groupBox1.Location = New System.Drawing.Point(11, 152)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(348, 120)
        Me.groupBox1.TabIndex = 71
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "     Encrypt Spreadsheet"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.rdbExcel2010Encrypt)
        Me.groupBox3.Controls.Add(Me.rdbExcel2007Encrypt)
        Me.groupBox3.Location = New System.Drawing.Point(12, 80)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(208, 37)
        Me.groupBox3.TabIndex = 74
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Save As"
        '
        'rdbExcel2010Encrypt
        '
        Me.rdbExcel2010Encrypt.AutoSize = True
        Me.rdbExcel2010Encrypt.Location = New System.Drawing.Point(111, 11)
        Me.rdbExcel2010Encrypt.Name = "rdbExcel2010Encrypt"
        Me.rdbExcel2010Encrypt.Size = New System.Drawing.Size(88, 17)
        Me.rdbExcel2010Encrypt.TabIndex = 2
        Me.rdbExcel2010Encrypt.Text = "Excel 2010"
        Me.rdbExcel2010Encrypt.UseVisualStyleBackColor = True
        '
        'rdbExcel2007Encrypt
        '
        Me.rdbExcel2007Encrypt.AutoSize = True
        Me.rdbExcel2007Encrypt.Checked = True
        Me.rdbExcel2007Encrypt.Location = New System.Drawing.Point(17, 11)
        Me.rdbExcel2007Encrypt.Name = "rdbExcel2007Encrypt"
        Me.rdbExcel2007Encrypt.Size = New System.Drawing.Size(88, 17)
        Me.rdbExcel2007Encrypt.TabIndex = 1
        Me.rdbExcel2007Encrypt.TabStop = True
        Me.rdbExcel2007Encrypt.Text = "Excel 2007"
        Me.rdbExcel2007Encrypt.UseVisualStyleBackColor = True
        '
        'label9
        '
        Me.label9.Location = New System.Drawing.Point(322, 32)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(20, 16)
        Me.label9.TabIndex = 9
        Me.toolTip1.SetToolTip(Me.label9, "Browse a spreadsheet to encrypt and give password")
        '
        'btnEncryptSource
        '
        Me.btnEncryptSource.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEncryptSource.BackColor = System.Drawing.Color.Transparent
        Me.btnEncryptSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncryptSource.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEncryptSource.Location = New System.Drawing.Point(299, 29)
        Me.btnEncryptSource.Name = "btnEncryptSource"
        Me.btnEncryptSource.Size = New System.Drawing.Size(24, 20)
        Me.btnEncryptSource.TabIndex = 0
        Me.btnEncryptSource.Text = "..."
        Me.btnEncryptSource.UseVisualStyleBackColor = False
        '
        'txtEncryptSource
        '
        Me.txtEncryptSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEncryptSource.Location = New System.Drawing.Point(110, 29)
        Me.txtEncryptSource.Name = "txtEncryptSource"
        Me.txtEncryptSource.Size = New System.Drawing.Size(185, 20)
        Me.txtEncryptSource.TabIndex = 1
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label7.Location = New System.Drawing.Point(6, 32)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(93, 13)
        Me.label7.TabIndex = 8
        Me.label7.Text = "Source Document"
        '
        'txtEnOpen
        '
        Me.txtEnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnOpen.Location = New System.Drawing.Point(110, 60)
        Me.txtEnOpen.Name = "txtEnOpen"
        Me.txtEnOpen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtEnOpen.Size = New System.Drawing.Size(232, 20)
        Me.txtEnOpen.TabIndex = 2
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label5.Location = New System.Drawing.Point(6, 63)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(98, 13)
        Me.label5.TabIndex = 3
        Me.label5.Text = "Password To Open"
        '
        'label3
        '
        Me.label3.BackColor = System.Drawing.Color.MidnightBlue
        Me.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label3.Location = New System.Drawing.Point(29, 13)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(118, 1)
        Me.label3.TabIndex = 2
        Me.label3.Text = "label3"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(9, 1)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(21, 17)
        Me.label2.TabIndex = 1
        '
        'btnEncryption
        '
        Me.btnEncryption.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEncryption.BackColor = System.Drawing.Color.Transparent
        Me.btnEncryption.Enabled = False
        Me.btnEncryption.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncryption.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEncryption.Image = CType(resources.GetObject("btnEncryption.Image"), System.Drawing.Image)
        Me.btnEncryption.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEncryption.Location = New System.Drawing.Point(257, 91)
        Me.btnEncryption.Name = "btnEncryption"
        Me.btnEncryption.Size = New System.Drawing.Size(85, 26)
        Me.btnEncryption.TabIndex = 5
        Me.btnEncryption.Text = "Encrypt"
        Me.btnEncryption.UseVisualStyleBackColor = False
        '
        'label12
        '
        Me.label12.Location = New System.Drawing.Point(9, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(21, 17)
        Me.label12.TabIndex = 1
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.GroupBox4)
        Me.groupBox2.Controls.Add(Me.label13)
        Me.groupBox2.Controls.Add(Me.btnDecryptSource)
        Me.groupBox2.Controls.Add(Me.txtDecryptSource)
        Me.groupBox2.Controls.Add(Me.label8)
        Me.groupBox2.Controls.Add(Me.btnDecryption)
        Me.groupBox2.Controls.Add(Me.txtDeOpen)
        Me.groupBox2.Controls.Add(Me.label10)
        Me.groupBox2.Controls.Add(Me.label11)
        Me.groupBox2.Controls.Add(Me.label12)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.groupBox2.Location = New System.Drawing.Point(11, 274)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(348, 122)
        Me.groupBox2.TabIndex = 72
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "     Decrypt Spreadsheet"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdbExcel2010Decrypt)
        Me.GroupBox4.Controls.Add(Me.rdbExcel2007Decrypt)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(208, 37)
        Me.GroupBox4.TabIndex = 74
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Save As"
        '
        'rdbExcel2010Decrypt
        '
        Me.rdbExcel2010Decrypt.AutoSize = True
        Me.rdbExcel2010Decrypt.Location = New System.Drawing.Point(111, 11)
        Me.rdbExcel2010Decrypt.Name = "rdbExcel2010Decrypt"
        Me.rdbExcel2010Decrypt.Size = New System.Drawing.Size(88, 17)
        Me.rdbExcel2010Decrypt.TabIndex = 2
        Me.rdbExcel2010Decrypt.Text = "Excel 2010"
        Me.rdbExcel2010Decrypt.UseVisualStyleBackColor = True
        '
        'rdbExcel2007Decrypt
        '
        Me.rdbExcel2007Decrypt.AutoSize = True
        Me.rdbExcel2007Decrypt.Checked = True
        Me.rdbExcel2007Decrypt.Location = New System.Drawing.Point(17, 11)
        Me.rdbExcel2007Decrypt.Name = "rdbExcel2007Decrypt"
        Me.rdbExcel2007Decrypt.Size = New System.Drawing.Size(88, 17)
        Me.rdbExcel2007Decrypt.TabIndex = 1
        Me.rdbExcel2007Decrypt.TabStop = True
        Me.rdbExcel2007Decrypt.Text = "Excel 2007"
        Me.rdbExcel2007Decrypt.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label4.Location = New System.Drawing.Point(0, 101)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(372, 48)
        Me.label4.TabIndex = 74
        Me.label4.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" & _
            "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" & _
            "nt."
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pictureBox1
        '
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(372, 96)
        Me.pictureBox1.TabIndex = 73
        Me.pictureBox1.TabStop = False
        '
        'label1
        '
        Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(0, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(342, 56)
        Me.label1.TabIndex = 70
        Me.label1.Text = resources.GetString("label1.Text")
        '
        'EncryptionDecryption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(372, 406)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EncryptionDecryption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advanced Encrypt and Decrypt"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#Region "Fields"
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents btnDecryptSource As System.Windows.Forms.Button
    Private WithEvents txtDecryptSource As System.Windows.Forms.TextBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents btnDecryption As System.Windows.Forms.Button
    Private WithEvents txtDeOpen As System.Windows.Forms.TextBox
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents btnEncryptSource As System.Windows.Forms.Button
    Private WithEvents txtEncryptSource As System.Windows.Forms.TextBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents txtEnOpen As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents btnEncryption As System.Windows.Forms.Button
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents rdbExcel2010Encrypt As System.Windows.Forms.RadioButton
    Private WithEvents rdbExcel2007Encrypt As System.Windows.Forms.RadioButton
    Private WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents rdbExcel2010Decrypt As System.Windows.Forms.RadioButton
    Private WithEvents rdbExcel2007Decrypt As System.Windows.Forms.RadioButton
#End Region

End Class
