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
Imports Syncfusion.Pdf.Graphics
Imports Syncfusion.Pdf.Parsing

Namespace EssentialPDFSamples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		#Region "Private Members"
		Private WithEvents button1 As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
        Private txtUrl As TextBox
		Private dlgOpen As OpenFileDialog
		Private label5 As Label
		Private label2 As Label
		Private label7 As Label
		Private label3 As Label
		Private label4 As Label
		Private txtWidth As TextBox
		Private chkTwoSide As CheckBox
		Private txtHeight As TextBox
		Private WithEvents btnLoad As Button
		Private label6 As Label
        Private toolTip1 As ToolTip
        Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
		Private components As IContainer
		#End Region

		#Region "Constructor and Load"
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

            Application.EnableVisualStyles()
            txtUrl.Text = "Essential_Studio.pdf"
            txtUrl.Tag = "..\..\..\..\..\..\..\..\..\Common\Data\PDF\Essential_Studio.pdf"
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
            Me.txtUrl = New System.Windows.Forms.TextBox
            Me.dlgOpen = New System.Windows.Forms.OpenFileDialog
            Me.label2 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.txtWidth = New System.Windows.Forms.TextBox
            Me.chkTwoSide = New System.Windows.Forms.CheckBox
            Me.txtHeight = New System.Windows.Forms.TextBox
            Me.btnLoad = New System.Windows.Forms.Button
            Me.label6 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
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
            Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.button1.Location = New System.Drawing.Point(286, 293)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 24)
            Me.button1.TabIndex = 0
            Me.button1.Text = "Create PDF"
            Me.button1.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.label1.Location = New System.Drawing.Point(0, 245)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(373, 69)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Click the button to view an PDF document generated by Essential PDF. Please note " & _
                "that Adobe Reader or its equivalent is required to view the resultant document."
            '
            'txtUrl
            '
            Me.txtUrl.Location = New System.Drawing.Point(76, 122)
            Me.txtUrl.Name = "txtUrl"
            Me.txtUrl.Size = New System.Drawing.Size(232, 20)
            Me.txtUrl.TabIndex = 71
            Me.txtUrl.Text = "..\..\..\..\..\..\..\..\..\Common\Data\PDF\Essential_Studio.pdf"
            '
            'dlgOpen
            '
            Me.dlgOpen.DefaultExt = "pdf"
            Me.dlgOpen.Filter = "PDF format(*.pdf)|*.pdf"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label2.Location = New System.Drawing.Point(21, 125)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(29, 13)
            Me.label2.TabIndex = 75
            Me.label2.Text = "URL"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label3.Location = New System.Drawing.Point(21, 179)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(63, 13)
            Me.label3.TabIndex = 78
            Me.label3.Text = "Page Width"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label4.Location = New System.Drawing.Point(200, 179)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(66, 13)
            Me.label4.TabIndex = 79
            Me.label4.Text = "Page Height"
            '
            'txtWidth
            '
            Me.txtWidth.Location = New System.Drawing.Point(90, 176)
            Me.txtWidth.Name = "txtWidth"
            Me.txtWidth.Size = New System.Drawing.Size(59, 20)
            Me.txtWidth.TabIndex = 80
            Me.txtWidth.Text = "595"
            '
            'chkTwoSide
            '
            Me.chkTwoSide.AutoSize = True
            Me.chkTwoSide.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkTwoSide.Location = New System.Drawing.Point(21, 213)
            Me.chkTwoSide.Name = "chkTwoSide"
            Me.chkTwoSide.Size = New System.Drawing.Size(90, 18)
            Me.chkTwoSide.TabIndex = 82
            Me.chkTwoSide.Text = "Double Side"
            Me.chkTwoSide.UseVisualStyleBackColor = True
            '
            'txtHeight
            '
            Me.txtHeight.Location = New System.Drawing.Point(273, 176)
            Me.txtHeight.Name = "txtHeight"
            Me.txtHeight.Size = New System.Drawing.Size(58, 20)
            Me.txtHeight.TabIndex = 81
            Me.txtHeight.Text = "550"
            '
            'btnLoad
            '
            Me.btnLoad.Location = New System.Drawing.Point(309, 120)
            Me.btnLoad.Name = "btnLoad"
            Me.btnLoad.Size = New System.Drawing.Size(24, 23)
            Me.btnLoad.TabIndex = 83
            Me.btnLoad.Text = "..."
            Me.btnLoad.UseVisualStyleBackColor = True
            '
            'label6
            '
            Me.label6.Location = New System.Drawing.Point(96, 214)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(19, 19)
            Me.label6.TabIndex = 84
            Me.toolTip1.SetToolTip(Me.label6, "The pages will be double sided")
            '
            'label7
            '
            Me.label7.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label7.Location = New System.Drawing.Point(5, 145)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(123, 19)
            Me.label7.TabIndex = 76
            Me.label7.Text = "Page Settings"
            Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label5
            '
            Me.label5.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label5.Location = New System.Drawing.Point(5, 93)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(146, 19)
            Me.label5.TabIndex = 73
            Me.label5.Text = "Source Document"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'PictureBox2
            '
            Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
            Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(373, 89)
            Me.PictureBox2.TabIndex = 85
            Me.PictureBox2.TabStop = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(373, 328)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.btnLoad)
            Me.Controls.Add(Me.chkTwoSide)
            Me.Controls.Add(Me.txtHeight)
            Me.Controls.Add(Me.txtWidth)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.txtUrl)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Booklet"
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
		''' Creates PDF document
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			If txtUrl.Text = "" Then
				MessageBox.Show("Please select a PDF document")
				txtUrl.Focus()
			ElseIf txtWidth.Text = "" Then
				MessageBox.Show("Please enter the page width value")
				txtWidth.Focus()
			ElseIf txtHeight.Text = "" Then
				MessageBox.Show("Please enter the page height value")
				txtHeight.Focus()
			Else
				'Load a PDF document
                Dim ldoc As PdfLoadedDocument = New PdfLoadedDocument(txtUrl.Tag.ToString())

				'Create booklet with two sides               
				Dim doc As PdfDocument = PdfBookletCreator.CreateBooklet(ldoc, New SizeF(Single.Parse(txtWidth.Text), Single.Parse(txtHeight.Text)), chkTwoSide.Checked)

				'Save the document
				doc.Save("Sample.pdf")
				'Close the loaded document
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
			End If
		End Sub

		''' <summary>
		''' Gets the source document
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
			If dlgOpen.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				'assigns the url of the file to the text box
                txtUrl.Text = dlgOpen.SafeFileName
                txtUrl.Tag = dlgOpen.FileName
			End If
		End Sub
		#End Region
	End Class
End Namespace
