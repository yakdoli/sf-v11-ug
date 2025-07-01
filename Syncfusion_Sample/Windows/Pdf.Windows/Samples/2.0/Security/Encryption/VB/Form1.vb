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
Imports Syncfusion.Pdf.Graphics
Imports Syncfusion.Pdf.Security
Imports Syncfusion.Pdf.Interactive


Namespace EssentialPDFSamples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private WithEvents button1 As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents label2 As System.Windows.Forms.Label
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents rdButton256Bit As System.Windows.Forms.RadioButton
        Friend WithEvents rdButton128Bit As System.Windows.Forms.RadioButton
        Friend WithEvents rdButton40Bit As System.Windows.Forms.RadioButton
        Friend WithEvents rdButtonAES As System.Windows.Forms.RadioButton
        Friend WithEvents rdButtonRC4 As System.Windows.Forms.RadioButton
        Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            '
            ' TODO: Add any constructor code after InitializeComponent call
            ''
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
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
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.label3 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.GroupBox2 = New System.Windows.Forms.GroupBox
            Me.rdButton256Bit = New System.Windows.Forms.RadioButton
            Me.rdButton128Bit = New System.Windows.Forms.RadioButton
            Me.rdButton40Bit = New System.Windows.Forms.RadioButton
            Me.GroupBox3 = New System.Windows.Forms.GroupBox
            Me.rdButtonAES = New System.Windows.Forms.RadioButton
            Me.rdButtonRC4 = New System.Windows.Forms.RadioButton
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            Me.groupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.button1.Location = New System.Drawing.Point(287, 265)
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
            Me.label1.Location = New System.Drawing.Point(0, 92)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(376, 67)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Click the button to view an PDF document generated by Essential PDF. Please note " & _
                "that Adobe Reader or its equivalent is required to view the resultant document."
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Location = New System.Drawing.Point(12, 228)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(215, 60)
            Me.groupBox1.TabIndex = 28
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Encryption Password"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(12, 38)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(148, 13)
            Me.label3.TabIndex = 26
            Me.label3.Text = "UserPassword: password"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(11, 17)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(168, 13)
            Me.label2.TabIndex = 25
            Me.label2.Text = "Owner password: syncfusion"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.rdButton256Bit)
            Me.GroupBox2.Controls.Add(Me.rdButton128Bit)
            Me.GroupBox2.Controls.Add(Me.rdButton40Bit)
            Me.GroupBox2.Location = New System.Drawing.Point(12, 145)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(215, 64)
            Me.GroupBox2.TabIndex = 71
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "GroupBox2"
            '
            'rdButton256Bit
            '
            Me.rdButton256Bit.AutoSize = True
            Me.rdButton256Bit.Location = New System.Drawing.Point(134, 28)
            Me.rdButton256Bit.Name = "rdButton256Bit"
            Me.rdButton256Bit.Size = New System.Drawing.Size(58, 17)
            Me.rdButton256Bit.TabIndex = 2
            Me.rdButton256Bit.TabStop = True
            Me.rdButton256Bit.Text = "256 Bit"
            Me.rdButton256Bit.UseVisualStyleBackColor = True
            '
            'rdButton128Bit
            '
            Me.rdButton128Bit.AutoSize = True
            Me.rdButton128Bit.Checked = True
            Me.rdButton128Bit.Location = New System.Drawing.Point(70, 28)
            Me.rdButton128Bit.Name = "rdButton128Bit"
            Me.rdButton128Bit.Size = New System.Drawing.Size(58, 17)
            Me.rdButton128Bit.TabIndex = 1
            Me.rdButton128Bit.TabStop = True
            Me.rdButton128Bit.Text = "128 Bit"
            Me.rdButton128Bit.UseVisualStyleBackColor = True
            '
            'rdButton40Bit
            '
            Me.rdButton40Bit.AutoSize = True
            Me.rdButton40Bit.Location = New System.Drawing.Point(14, 28)
            Me.rdButton40Bit.Name = "rdButton40Bit"
            Me.rdButton40Bit.Size = New System.Drawing.Size(52, 17)
            Me.rdButton40Bit.TabIndex = 0
            Me.rdButton40Bit.TabStop = True
            Me.rdButton40Bit.Text = "40 Bit"
            Me.rdButton40Bit.UseVisualStyleBackColor = True
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.rdButtonAES)
            Me.GroupBox3.Controls.Add(Me.rdButtonRC4)
            Me.GroupBox3.Location = New System.Drawing.Point(237, 145)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(125, 64)
            Me.GroupBox3.TabIndex = 72
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "GroupBox3"
            '
            'rdButtonAES
            '
            Me.rdButtonAES.AutoSize = True
            Me.rdButtonAES.Checked = True
            Me.rdButtonAES.Location = New System.Drawing.Point(69, 28)
            Me.rdButtonAES.Name = "rdButtonAES"
            Me.rdButtonAES.Size = New System.Drawing.Size(46, 17)
            Me.rdButtonAES.TabIndex = 1
            Me.rdButtonAES.TabStop = True
            Me.rdButtonAES.Text = "AES"
            Me.rdButtonAES.UseVisualStyleBackColor = True
            '
            'rdButtonRC4
            '
            Me.rdButtonRC4.AutoSize = True
            Me.rdButtonRC4.Location = New System.Drawing.Point(16, 28)
            Me.rdButtonRC4.Name = "rdButtonRC4"
            Me.rdButtonRC4.Size = New System.Drawing.Size(46, 17)
            Me.rdButtonRC4.TabIndex = 0
            Me.rdButtonRC4.TabStop = True
            Me.rdButtonRC4.Text = "RC4"
            Me.rdButtonRC4.UseVisualStyleBackColor = True
            '
            'PictureBox2
            '
            Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
            Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(374, 89)
            Me.PictureBox2.TabIndex = 73
            Me.PictureBox2.TabStop = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(374, 320)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Encryption"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New Form1())
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            Dim document As PdfDocument = New PdfDocument()
            Dim page As PdfPage = document.Pages.Add()
            Dim graphics As PdfGraphics = page.Graphics

            Dim font As PdfStandardFont = New PdfStandardFont(PdfFontFamily.TimesRoman, 20.0F, PdfFontStyle.Bold)
            Dim brush As PdfBrush = PdfBrushes.Black
            Dim form As PdfForm = document.Form

            'Document security
            Dim security As PdfSecurity = document.Security

            'Specify key size and encryption algorithm
            If rdButton40Bit.Checked Then
                'use 40 bits key in RC4 mode
                security.KeySize = PdfEncryptionKeySize.Key40Bit
            ElseIf rdButton128Bit.Checked AndAlso rdButtonRC4.Checked Then
                'use 128 bits key in RC4 mode
                security.KeySize = PdfEncryptionKeySize.Key128Bit
                security.Algorithm = PdfEncryptionAlgorithm.RC4
            ElseIf rdButton128Bit.Checked AndAlso rdButtonAES.Checked Then
                'use 128 bits key in AES mode
                security.KeySize = PdfEncryptionKeySize.Key128Bit
                security.Algorithm = PdfEncryptionAlgorithm.AES
            ElseIf rdButton256Bit.Checked Then
                'use 256 bits key in AES mode
                security.KeySize = PdfEncryptionKeySize.Key256Bit
                security.Algorithm = PdfEncryptionAlgorithm.AES
            End If

            security.OwnerPassword = "syncfusion"
            security.Permissions = PdfPermissionsFlags.Print Or PdfPermissionsFlags.FullQualityPrint
            security.UserPassword = "password"

            Dim text As String = "Security options:" & vbLf & vbLf & String.Format("KeySize: {0}" & vbLf & vbLf & "Encryption Algorithm: {4}" & vbLf & vbLf & "Owner Password: {1}" & vbLf & vbLf & "Permissions: {2}" & vbLf & vbLf & "UserPassword: {3}", security.KeySize, security.OwnerPassword, security.Permissions, security.UserPassword, security.Algorithm)

            graphics.DrawString("Document is Encrypted with following settings", font, brush, PointF.Empty)
            font = New PdfStandardFont(PdfFontFamily.TimesRoman, 16.0F, PdfFontStyle.Bold)
            graphics.DrawString(text, font, brush, New PointF(0, 40))

            document.Save("Sample.pdf")

            'Message box confirmation to view the created PDF document.
            If MessageBox.Show("Do you want to view the PDF file?", "PDF File Created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                'Launching the PDF file using the default Application.[Acrobat Reader]
                System.Diagnostics.Process.Start("Sample.pdf")
                Me.Close()
            Else
                ' Exit
                Me.Close()
            End If
        End Sub

        Private Sub rdButton40Bit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdButton40Bit.CheckedChanged
            If rdButton40Bit.Checked Then
                rdButtonRC4.Enabled = True
                rdButtonRC4.Checked = True
                rdButtonAES.Enabled = False
            End If
        End Sub

        Private Sub rdButton128Bit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdButton128Bit.CheckedChanged
            rdButtonRC4.Enabled = True
            rdButtonAES.Enabled = True
        End Sub

        Private Sub rdButton256Bit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdButton256Bit.CheckedChanged
            rdButtonAES.Enabled = True
            rdButtonAES.Checked = True
            rdButtonRC4.Enabled = False
        End Sub
    End Class
End Namespace
