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

Imports System.Drawing.Imaging
Imports System.Collections
Imports System.ComponentModel
Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Graphics
Imports Syncfusion.OCRProcessor
Imports Syncfusion.Pdf.Parsing

Namespace EssentialPDFSamples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Form
		#Region "Private Members"
		Private WithEvents button1 As Button
		Private label1 As Label
		Private pictureBox1 As PictureBox
		Private panelRegion As Panel
		Private groupRegion As GroupBox
		Private lblXCoordinate As Label
		Private lblHeight As Label
		Private lblYCoordinate As Label
		Private lblWidth As Label
		Private txtXCoordinate As NumericUpDown
		Private txtWidth As NumericUpDown
		Private txtYCoordinate As NumericUpDown
		Private txtHeight As NumericUpDown
		Private rbtnFullDocument As RadioButton
		Private WithEvents rbtnRegion As RadioButton

		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
		#End Region

		#Region "Constructor"
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Application.EnableVisualStyles()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
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
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.panelRegion = New System.Windows.Forms.Panel
            Me.groupRegion = New System.Windows.Forms.GroupBox
            Me.txtHeight = New System.Windows.Forms.NumericUpDown
            Me.txtYCoordinate = New System.Windows.Forms.NumericUpDown
            Me.txtWidth = New System.Windows.Forms.NumericUpDown
            Me.txtXCoordinate = New System.Windows.Forms.NumericUpDown
            Me.lblHeight = New System.Windows.Forms.Label
            Me.lblYCoordinate = New System.Windows.Forms.Label
            Me.lblWidth = New System.Windows.Forms.Label
            Me.lblXCoordinate = New System.Windows.Forms.Label
            Me.rbtnFullDocument = New System.Windows.Forms.RadioButton
            Me.rbtnRegion = New System.Windows.Forms.RadioButton
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelRegion.SuspendLayout()
            Me.groupRegion.SuspendLayout()
            CType(Me.txtHeight, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtYCoordinate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtWidth, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtXCoordinate, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'button1
            '
            Me.button1.BackColor = System.Drawing.Color.Transparent
            Me.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button1.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Image)
            Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.button1.Location = New System.Drawing.Point(254, 145)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 24)
            Me.button1.TabIndex = 0
            Me.button1.Text = "PDF"
            Me.button1.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.label1.Location = New System.Drawing.Point(0, 89)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(372, 75)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Click the button below to generate a searchable PDF, OCRed using the Tesseract en" & _
                "gine. Please note that PDF Viewer or its equivalent to view the resultant docume" & _
                "nt."
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(372, 89)
            Me.pictureBox1.TabIndex = 24
            Me.pictureBox1.TabStop = False
            '
            'panelRegion
            '
            Me.panelRegion.Controls.Add(Me.groupRegion)
            Me.panelRegion.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelRegion.Location = New System.Drawing.Point(0, 188)
            Me.panelRegion.Name = "panelRegion"
            Me.panelRegion.Size = New System.Drawing.Size(372, 106)
            Me.panelRegion.TabIndex = 26
            Me.panelRegion.Visible = False
            '
            'groupRegion
            '
            Me.groupRegion.Controls.Add(Me.txtHeight)
            Me.groupRegion.Controls.Add(Me.txtYCoordinate)
            Me.groupRegion.Controls.Add(Me.txtWidth)
            Me.groupRegion.Controls.Add(Me.txtXCoordinate)
            Me.groupRegion.Controls.Add(Me.lblHeight)
            Me.groupRegion.Controls.Add(Me.lblYCoordinate)
            Me.groupRegion.Controls.Add(Me.lblWidth)
            Me.groupRegion.Controls.Add(Me.lblXCoordinate)
            Me.groupRegion.Location = New System.Drawing.Point(22, 12)
            Me.groupRegion.Name = "groupRegion"
            Me.groupRegion.Size = New System.Drawing.Size(307, 82)
            Me.groupRegion.TabIndex = 0
            Me.groupRegion.TabStop = False
            Me.groupRegion.Text = "Region"
            '
            'txtHeight
            '
            Me.txtHeight.Location = New System.Drawing.Point(229, 58)
            Me.txtHeight.Maximum = New Decimal(New Integer() {1684, 0, 0, 0})
            Me.txtHeight.Name = "txtHeight"
            Me.txtHeight.Size = New System.Drawing.Size(40, 20)
            Me.txtHeight.TabIndex = 30
            '
            'txtYCoordinate
            '
            Me.txtYCoordinate.Location = New System.Drawing.Point(229, 21)
            Me.txtYCoordinate.Maximum = New Decimal(New Integer() {1684, 0, 0, 0})
            Me.txtYCoordinate.Name = "txtYCoordinate"
            Me.txtYCoordinate.Size = New System.Drawing.Size(40, 20)
            Me.txtYCoordinate.TabIndex = 29
            '
            'txtWidth
            '
            Me.txtWidth.Location = New System.Drawing.Point(73, 58)
            Me.txtWidth.Maximum = New Decimal(New Integer() {1190, 0, 0, 0})
            Me.txtWidth.Name = "txtWidth"
            Me.txtWidth.Size = New System.Drawing.Size(40, 20)
            Me.txtWidth.TabIndex = 28
            '
            'txtXCoordinate
            '
            Me.txtXCoordinate.Location = New System.Drawing.Point(73, 18)
            Me.txtXCoordinate.Maximum = New Decimal(New Integer() {1190, 0, 0, 0})
            Me.txtXCoordinate.Name = "txtXCoordinate"
            Me.txtXCoordinate.Size = New System.Drawing.Size(42, 20)
            Me.txtXCoordinate.TabIndex = 27
            '
            'lblHeight
            '
            Me.lblHeight.AutoSize = True
            Me.lblHeight.Location = New System.Drawing.Point(182, 58)
            Me.lblHeight.Name = "lblHeight"
            Me.lblHeight.Size = New System.Drawing.Size(44, 13)
            Me.lblHeight.TabIndex = 6
            Me.lblHeight.Text = "Height :"
            '
            'lblYCoordinate
            '
            Me.lblYCoordinate.AutoSize = True
            Me.lblYCoordinate.Location = New System.Drawing.Point(182, 21)
            Me.lblYCoordinate.Name = "lblYCoordinate"
            Me.lblYCoordinate.Size = New System.Drawing.Size(44, 13)
            Me.lblYCoordinate.TabIndex = 4
            Me.lblYCoordinate.Text = "Y         :"
            '
            'lblWidth
            '
            Me.lblWidth.AutoSize = True
            Me.lblWidth.Location = New System.Drawing.Point(32, 57)
            Me.lblWidth.Name = "lblWidth"
            Me.lblWidth.Size = New System.Drawing.Size(41, 13)
            Me.lblWidth.TabIndex = 2
            Me.lblWidth.Text = "Width :"
            '
            'lblXCoordinate
            '
            Me.lblXCoordinate.AutoSize = True
            Me.lblXCoordinate.Location = New System.Drawing.Point(32, 20)
            Me.lblXCoordinate.Name = "lblXCoordinate"
            Me.lblXCoordinate.Size = New System.Drawing.Size(41, 13)
            Me.lblXCoordinate.TabIndex = 0
            Me.lblXCoordinate.Text = "X        :"
            '
            'rbtnFullDocument
            '
            Me.rbtnFullDocument.AutoSize = True
            Me.rbtnFullDocument.Checked = True
            Me.rbtnFullDocument.Location = New System.Drawing.Point(22, 149)
            Me.rbtnFullDocument.Name = "rbtnFullDocument"
            Me.rbtnFullDocument.Size = New System.Drawing.Size(121, 17)
            Me.rbtnFullDocument.TabIndex = 27
            Me.rbtnFullDocument.TabStop = True
            Me.rbtnFullDocument.Text = "Complete Document"
            Me.rbtnFullDocument.UseVisualStyleBackColor = True
            '
            'rbtnRegion
            '
            Me.rbtnRegion.AutoSize = True
            Me.rbtnRegion.Location = New System.Drawing.Point(152, 149)
            Me.rbtnRegion.Name = "rbtnRegion"
            Me.rbtnRegion.Size = New System.Drawing.Size(59, 17)
            Me.rbtnRegion.TabIndex = 28
            Me.rbtnRegion.TabStop = True
            Me.rbtnRegion.Text = "Region"
            Me.rbtnRegion.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(372, 294)
            Me.Controls.Add(Me.rbtnRegion)
            Me.Controls.Add(Me.rbtnFullDocument)
            Me.Controls.Add(Me.panelRegion)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.pictureBox1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "OCR"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelRegion.ResumeLayout(False)
            Me.groupRegion.ResumeLayout(False)
            Me.groupRegion.PerformLayout()
            CType(Me.txtHeight, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtYCoordinate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtWidth, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtXCoordinate, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())

		End Sub
		#End Region

		#Region "Events"
		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			'Initialize the OCR processor
			Using processor As New OCRProcessor(GetFullTemplatePath("OCR\Tesseract binaries"))
				'Load the PDF document 
				Dim lDoc As New PdfLoadedDocument(GetFullTemplatePath("Region.pdf"))
				'Language to process the OCR
				processor.Settings.Language = Languages.English
				If rbtnRegion.Checked Then
					Dim x As Integer = 0
					Dim y As Integer = 0
					Dim width As Integer = 0
					Dim height As Integer = 0
					Integer.TryParse(txtXCoordinate.Text, x)
					Integer.TryParse(txtYCoordinate.Text, y)
					Integer.TryParse(txtWidth.Text, width)
					Integer.TryParse(txtHeight.Text, height)
					Dim rect As New RectangleF(x, y, width, height)
					'Assign the rectangles to the page
					Dim region As New PageRegion()
					Dim pageRegions As New List(Of PageRegion)()
					region.PageIndex = 0
					region.PageRegions = New RectangleF() { rect }
					pageRegions.Add(region)
					processor.Settings.Regions = pageRegions
				End If
				'Process OCR by providing loaded PDF document, Data dictionary and language
				processor.PerformOCR(lDoc, GetFullTemplatePath("OCR/Tessdata/"))
				'Save the OCR processed PDF document in the disk
				lDoc.Save("Sample.pdf")
				lDoc.Close(True)
			End Using
			'Message box confirmation to view the created PDF document.
			If MessageBox.Show("Do you want to view the PDF file?", "PDF File Created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
				'Launching the PDF file using the default Application.[Acrobat Reader]
				Process.Start("Sample.pdf")
				Me.Close()
			Else
				' Exit
				Me.Close()
			End If
		End Sub
		''' <summary>
		''' Gets the full path of the PDF template or image.
		''' </summary>
		''' <param name="fileName">Name of the file</param>
		''' <param name="image">True if image</param>
		''' <returns>Path of the file</returns>
		Private Function GetFullTemplatePath(ByVal fileName As String) As String
			Dim fullPath As String = "..\..\..\..\..\..\..\..\..\Common\"
			Dim folder As String = "Data\PDF"

			Return String.Format("{0}{1}\{2}", fullPath, folder, fileName)
		End Function
		#End Region

		Private Sub rbtnRegion_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbtnRegion.CheckedChanged
			If rbtnRegion.Checked Then
				Me.Height = 328
				panelRegion.Visible = True
			Else
				Me.Height = 218
				panelRegion.Visible = False
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.Height = 218
		End Sub
	End Class
End Namespace