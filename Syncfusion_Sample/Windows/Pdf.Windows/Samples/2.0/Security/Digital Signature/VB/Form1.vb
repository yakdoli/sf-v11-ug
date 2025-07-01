#Region "Copyright Syncfusion Inc. 2001 - 2008"
'
'  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
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
Imports Syncfusion.Pdf.Security
Imports Syncfusion.Pdf.Graphics
Imports Syncfusion.Pdf.Parsing

Namespace EssentialPDFSamples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		#Region "Private Members"
		Private doc As PdfLoadedDocument
		Private signature As PdfSignature
		Private bmp As PdfBitmap
		Private g As PdfGraphics
		Private WithEvents button1 As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
        Private rdbStandardSign As RadioButton
		Private rdbAuthorSign As RadioButton
        Private label2 As Label
		Private label3 As Label
		Private label4 As Label
		Private WithEvents button2 As Button
		Private label5 As Label
		Private inputBox As TextBox
		Private WithEvents button3 As Button
		Private certTextBox As TextBox
		Private label10 As Label
		Private passwordBox As TextBox
		Private label6 As Label
		Private label7 As Label
		Private label13 As Label
		Private Locationtext As TextBox
		Private label12 As Label
		Private Contacttext As TextBox
		Private label11 As Label
		Private Reasontext As TextBox
		Private label8 As Label
		Private WithEvents button4 As Button
		Private label9 As Label
		Private label14 As Label
		Private DebugBox As TextBox
		Private label15 As Label
        Private toolTip1 As ToolTip
        Private WithEvents PictureBox3 As System.Windows.Forms.PictureBox
		Private components As IContainer
		#End Region

		#Region "Constructor and Main"
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
            Me.toolTip1.SetToolTip(label15, "For the PDF.pfx certificate in " & Constants.vbLf & " the Application folder 'syncfusion' is " & Constants.vbLf & " the password.")
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.button1 = New System.Windows.Forms.Button
            Me.label1 = New System.Windows.Forms.Label
            Me.rdbStandardSign = New System.Windows.Forms.RadioButton
            Me.rdbAuthorSign = New System.Windows.Forms.RadioButton
            Me.label2 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.button2 = New System.Windows.Forms.Button
            Me.label5 = New System.Windows.Forms.Label
            Me.inputBox = New System.Windows.Forms.TextBox
            Me.button3 = New System.Windows.Forms.Button
            Me.certTextBox = New System.Windows.Forms.TextBox
            Me.label10 = New System.Windows.Forms.Label
            Me.passwordBox = New System.Windows.Forms.TextBox
            Me.label6 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.label13 = New System.Windows.Forms.Label
            Me.Locationtext = New System.Windows.Forms.TextBox
            Me.label12 = New System.Windows.Forms.Label
            Me.Contacttext = New System.Windows.Forms.TextBox
            Me.label11 = New System.Windows.Forms.Label
            Me.Reasontext = New System.Windows.Forms.TextBox
            Me.label8 = New System.Windows.Forms.Label
            Me.button4 = New System.Windows.Forms.Button
            Me.label9 = New System.Windows.Forms.Label
            Me.label14 = New System.Windows.Forms.Label
            Me.DebugBox = New System.Windows.Forms.TextBox
            Me.label15 = New System.Windows.Forms.Label
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.PictureBox3 = New System.Windows.Forms.PictureBox
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.button1.Location = New System.Drawing.Point(423, 185)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 26)
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
            Me.label1.Location = New System.Drawing.Point(0, 95)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(525, 67)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Click the button to view an PDF document generated by Essential PDF. Please note " & _
                "that Adobe Reader or its equivalent is required to view the resultant document."
            '
            'rdbStandardSign
            '
            Me.rdbStandardSign.AutoSize = True
            Me.rdbStandardSign.Checked = True
            Me.rdbStandardSign.Location = New System.Drawing.Point(99, 185)
            Me.rdbStandardSign.Name = "rdbStandardSign"
            Me.rdbStandardSign.Size = New System.Drawing.Size(71, 17)
            Me.rdbStandardSign.TabIndex = 25
            Me.rdbStandardSign.TabStop = True
            Me.rdbStandardSign.Text = "Standard "
            Me.rdbStandardSign.UseVisualStyleBackColor = True
            '
            'rdbAuthorSign
            '
            Me.rdbAuthorSign.AutoSize = True
            Me.rdbAuthorSign.Location = New System.Drawing.Point(176, 185)
            Me.rdbAuthorSign.Name = "rdbAuthorSign"
            Me.rdbAuthorSign.Size = New System.Drawing.Size(56, 17)
            Me.rdbAuthorSign.TabIndex = 26
            Me.rdbAuthorSign.TabStop = True
            Me.rdbAuthorSign.Text = "Author"
            Me.rdbAuthorSign.UseVisualStyleBackColor = True
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Image = CType(resources.GetObject("label2.Image"), System.Drawing.Image)
            Me.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label2.Location = New System.Drawing.Point(5, 214)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(181, 24)
            Me.label2.TabIndex = 73
            Me.label2.Text = "Sign Existing Pdf Document"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label3
            '
            Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label3.Image = CType(resources.GetObject("label3.Image"), System.Drawing.Image)
            Me.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label3.Location = New System.Drawing.Point(5, 152)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(160, 24)
            Me.label3.TabIndex = 74
            Me.label3.Text = "Sign New Pdf Document"
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(5, 185)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(79, 13)
            Me.label4.TabIndex = 75
            Me.label4.Text = "Signature Type"
            '
            'button2
            '
            Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button2.Location = New System.Drawing.Point(267, 237)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(20, 20)
            Me.button2.TabIndex = 76
            Me.button2.Text = "..."
            Me.button2.UseVisualStyleBackColor = True
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(5, 244)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(41, 13)
            Me.label5.TabIndex = 77
            Me.label5.Text = "Source"
            '
            'inputBox
            '
            Me.inputBox.Location = New System.Drawing.Point(52, 241)
            Me.inputBox.Name = "inputBox"
            Me.inputBox.Size = New System.Drawing.Size(201, 20)
            Me.inputBox.TabIndex = 78
            '
            'button3
            '
            Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button3.Location = New System.Drawing.Point(229, 290)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(20, 20)
            Me.button3.TabIndex = 80
            Me.button3.Text = "..."
            Me.button3.UseVisualStyleBackColor = True
            '
            'certTextBox
            '
            Me.certTextBox.Location = New System.Drawing.Point(61, 290)
            Me.certTextBox.Name = "certTextBox"
            Me.certTextBox.Size = New System.Drawing.Size(162, 20)
            Me.certTextBox.TabIndex = 79
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Location = New System.Drawing.Point(6, 316)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(53, 13)
            Me.label10.TabIndex = 81
            Me.label10.Text = "Password"
            '
            'passwordBox
            '
            Me.passwordBox.Location = New System.Drawing.Point(61, 316)
            Me.passwordBox.Name = "passwordBox"
            Me.passwordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.passwordBox.Size = New System.Drawing.Size(162, 20)
            Me.passwordBox.TabIndex = 83
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(6, 290)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(54, 13)
            Me.label6.TabIndex = 82
            Me.label6.Text = "Certificate"
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label7.Location = New System.Drawing.Point(6, 268)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(66, 13)
            Me.label7.TabIndex = 84
            Me.label7.Text = "Certificate"
            Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label13
            '
            Me.label13.AutoSize = True
            Me.label13.Location = New System.Drawing.Point(264, 342)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(48, 13)
            Me.label13.TabIndex = 90
            Me.label13.Text = "Location"
            '
            'Locationtext
            '
            Me.Locationtext.Location = New System.Drawing.Point(313, 342)
            Me.Locationtext.Name = "Locationtext"
            Me.Locationtext.Size = New System.Drawing.Size(202, 20)
            Me.Locationtext.TabIndex = 89
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.Location = New System.Drawing.Point(264, 316)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(44, 13)
            Me.label12.TabIndex = 88
            Me.label12.Text = "Contact"
            '
            'Contacttext
            '
            Me.Contacttext.Location = New System.Drawing.Point(313, 316)
            Me.Contacttext.Name = "Contacttext"
            Me.Contacttext.Size = New System.Drawing.Size(202, 20)
            Me.Contacttext.TabIndex = 87
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Location = New System.Drawing.Point(264, 290)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(44, 13)
            Me.label11.TabIndex = 86
            Me.label11.Text = "Reason"
            '
            'Reasontext
            '
            Me.Reasontext.Location = New System.Drawing.Point(313, 290)
            Me.Reasontext.Name = "Reasontext"
            Me.Reasontext.Size = New System.Drawing.Size(202, 20)
            Me.Reasontext.TabIndex = 85
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label8.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label8.Location = New System.Drawing.Point(264, 271)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(62, 13)
            Me.label8.TabIndex = 91
            Me.label8.Text = "Signature"
            Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'button4
            '
            Me.button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button4.BackColor = System.Drawing.Color.Transparent
            Me.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button4.Image = CType(resources.GetObject("button4.Image"), System.Drawing.Image)
            Me.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.button4.Location = New System.Drawing.Point(423, 373)
            Me.button4.Name = "button4"
            Me.button4.Size = New System.Drawing.Size(77, 27)
            Me.button4.TabIndex = 93
            Me.button4.Text = "PDF"
            Me.button4.UseVisualStyleBackColor = False
            '
            'label9
            '
            Me.label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(164, Byte), Integer))
            Me.label9.Location = New System.Drawing.Point(170, 165)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(345, 1)
            Me.label9.TabIndex = 94
            '
            'label14
            '
            Me.label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(164, Byte), Integer))
            Me.label14.Location = New System.Drawing.Point(191, 227)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(325, 1)
            Me.label14.TabIndex = 95
            '
            'DebugBox
            '
            Me.DebugBox.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.DebugBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DebugBox.Location = New System.Drawing.Point(0, 422)
            Me.DebugBox.Multiline = True
            Me.DebugBox.Name = "DebugBox"
            Me.DebugBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.DebugBox.Size = New System.Drawing.Size(523, 88)
            Me.DebugBox.TabIndex = 96
            '
            'label15
            '
            Me.label15.Image = CType(resources.GetObject("label15.Image"), System.Drawing.Image)
            Me.label15.Location = New System.Drawing.Point(229, 319)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(20, 20)
            Me.label15.TabIndex = 97
            '
            'PictureBox3
            '
            Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Top
            Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
            Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
            Me.PictureBox3.Name = "PictureBox3"
            Me.PictureBox3.Size = New System.Drawing.Size(523, 90)
            Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox3.TabIndex = 98
            Me.PictureBox3.TabStop = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(523, 510)
            Me.Controls.Add(Me.PictureBox3)
            Me.Controls.Add(Me.label15)
            Me.Controls.Add(Me.DebugBox)
            Me.Controls.Add(Me.label14)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.button4)
            Me.Controls.Add(Me.label8)
            Me.Controls.Add(Me.label13)
            Me.Controls.Add(Me.Locationtext)
            Me.Controls.Add(Me.label12)
            Me.Controls.Add(Me.Contacttext)
            Me.Controls.Add(Me.label11)
            Me.Controls.Add(Me.Reasontext)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.button3)
            Me.Controls.Add(Me.certTextBox)
            Me.Controls.Add(Me.label10)
            Me.Controls.Add(Me.passwordBox)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.inputBox)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.rdbAuthorSign)
            Me.Controls.Add(Me.rdbStandardSign)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Digital Signature"
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub

		#End Region

		#Region "Events"
		''' <summary>
		''' Creates new PDF document and signs it
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			DebugBox.Clear()
			Dim doc As PdfDocument = New PdfDocument()
			Dim page As PdfPage = doc.Pages.Add()
			Dim brush As PdfSolidBrush = New PdfSolidBrush(Color.Black)
			Dim pen As PdfPen = New PdfPen(brush, 0.2f)
			Dim font As PdfFont = New PdfStandardFont(PdfFontFamily.Courier, 12, PdfFontStyle.Regular)

			debug("PdfDocument created ...")

			Try
				Dim pdfCert As PdfCertificate = New PdfCertificate("..\..\..\..\..\..\..\..\..\Common\Data\PDF\PDF.pfx", "syncfusion")
				signature = New PdfSignature(page, pdfCert, "Signature")
				bmp = New PdfBitmap("..\..\..\..\..\..\..\..\..\Common\Images\PDF\syncfusion_logo.gif")

				signature.Bounds = New RectangleF(New PointF(5, 5), bmp.PhysicalDimension)
				signature.ContactInfo = "johndoe@owned.us"
				signature.LocationInfo = "Honolulu, Hawaii"
				signature.Reason = "I am author of this document."

				If rdbAuthorSign.Checked Then
					signature.Certificated = True
				Else
					signature.Certificated = False
				End If
				g = signature.Appearence.Normal.Graphics

			Catch e1 As System.ArgumentNullException
				g = signature.Appearence.Normal.Graphics

				MessageBox.Show("Warning Certificate not found ""Cannot sign This Document""", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				'Draw the Text at specified location.
				g.DrawString("Warning this document is not signed", font, brush, New PointF(0, 20))
				g.DrawString("Create a self signed Digital ID to sign this document", font, brush, New PointF(20, 40))
				g.DrawLine(pen, New PointF(0, 100), New PointF(page.GetClientSize().Width, 200))
				g.DrawLine(pen, New PointF(0, 200), New PointF(page.GetClientSize().Width, 100))

			End Try
			Dim validto As String = "Valid To: " & signature.Certificate.ValidTo.ToString()
			Dim validfrom As String = "Valid From: " & signature.Certificate.ValidFrom.ToString()

			g.DrawImage(bmp, 0, 0)

			doc.Pages(0).Graphics.DrawString(validfrom, font, pen, brush, 0, 90)
			doc.Pages(0).Graphics.DrawString(validto, font, pen, brush, 0, 110)

			doc.Pages(0).Graphics.DrawString(" Protected Document. Digitally signed Document.", font, pen, brush, 0, 130)
			doc.Pages(0).Graphics.DrawString("* To validate Signature click on the signature on this page " & Constants.vbLf & " * To check Document Status " & Constants.vbLf & " click document status icon on the bottom left of the acrobat reader.", font, pen, brush, 0, 150)

			debug("PdfDocument signed ...")

			' Save the PDF file.
			doc.Save("Sample.pdf")
			debug("PdfDocument saved ...")

			doc.Close()

			'Message box confirmation to view the created PDF document.
			If MessageBox.Show("Do you want to view the PDF file?", "PDF File Created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
				'Launching the PDF file using the default Application.[Acrobat Reader]
				System.Diagnostics.Process.Start("Sample.pdf")
				Me.Close()
			Else
				' Exit
				Me.Close()
			End If
		End Sub

		''' <summary>
		''' Browse source Pdf to sign
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			Dim openFile As System.Windows.Forms.OpenFileDialog
			openFile = New System.Windows.Forms.OpenFileDialog()

			openFile.Filter = "PDF files *.pdf|*.pdf"
			openFile.Title = "Select a file"
			If openFile.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
				Return
			End If

            inputBox.Text = openFile.SafeFileName
            inputBox.Tag = openFile.FileName

            doc = New PdfLoadedDocument(inputBox.Tag.ToString())
		End Sub

		''' <summary>
		''' Browse for certificate
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			Dim openFile As System.Windows.Forms.OpenFileDialog
			openFile = New System.Windows.Forms.OpenFileDialog()
			openFile.InitialDirectory = Application.StartupPath & "\..\..\..\..\..\Data"
			openFile.Filter = "Certificate files *.pfx|*.pfx"
			openFile.Title = "Select a file"
			If openFile.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
				Return
			End If

            certTextBox.Text = openFile.SafeFileName
            certTextBox.Tag = openFile.FileName
		End Sub

		Private Sub debug(ByVal txt As String)
			DebugBox.AppendText(txt & System.Environment.NewLine)
		End Sub

		''' <summary>
		''' Signs the existing document
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button4.Click
If Me.inputBox.Text = String.Empty OrElse Me.certTextBox.Text = String.Empty OrElse (Not Me.inputBox.Text.EndsWith(".pdf")) OrElse (Not Me.certTextBox.Text.EndsWith(".pfx")) Then
				MessageBox.Show("Please select a PDF document to sign, along with certificate and the password !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Else
			
			DebugBox.Clear()
			Dim bmp As PdfBitmap = New PdfBitmap(Application.StartupPath & "\..\..\..\..\..\..\..\..\..\Common\Images\PDF\PDFDemo.jpg")
			
			debug("Started ...")

			debug("Checking certificate ...")

			Dim page As PdfPageBase = doc.Pages(0)
			Dim pdfCert As PdfCertificate
			Try
                    pdfCert = New PdfCertificate(certTextBox.Tag.ToString(), passwordBox.Text)
			Catch ex As Exception
				debug("Error : please make sure you entered a valid certificate file and password")
				debug("Exception : " & ex.ToString())
				Return
			End Try
			debug("Creating new MetaData ... ")
			Dim signature As PdfSignature = New PdfSignature(doc, page, pdfCert, "Signature")

			signature.Bounds = New RectangleF(New PointF(5, 5), bmp.PhysicalDimension)
			signature.ContactInfo = Contacttext.Text
			signature.LocationInfo = Locationtext.Text
			signature.Reason = Reasontext.Text
			Dim validto As String = "Valid To: " & signature.Certificate.ValidTo.ToString()
			Dim validfrom As String = "Valid From: " & signature.Certificate.ValidFrom.ToString()

			doc.Save("SignedPdfSample.pdf")

			debug("Signing document ... ")

			debug("Done")

			doc.Close()


			'Message box confirmation to view the created PDF document.
			If MessageBox.Show("Do you want to view the PDF file?", "PDF File Created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
				'Launching the PDF file using the default Application.[Acrobat Reader]
				System.Diagnostics.Process.Start("SignedPdfSample.pdf")
				Me.Close()
			Else
				' Exit
				Me.Close()
			End If
End If
		End Sub
		#End Region
	End Class
End Namespace
