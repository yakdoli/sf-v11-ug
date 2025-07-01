Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2011"
'
'  Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Re-distribution in any form is strictly
'  prohibited. Any infringement will be prosecuted under applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Graphics
Imports Syncfusion.Windows.Forms.PdfViewer

Namespace EssentialPDFSamples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		#Region "Private Members"
		Private WithEvents button1 As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private groupBox1 As GroupBox
		Private WithEvents rangeBtn As RadioButton
		Private allpageBtn As RadioButton
		Private label2 As Label
		Private label3 As Label
		Private toPage As NumericUpDown
		Private fromPage As NumericUpDown
		Private viewer As New PdfViewerControl()

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
			viewer.Load(GetFullTemplatePath("EmpDetails.pdf"))
			fromPage.Maximum = viewer.PageCount
			toPage.Maximum = viewer.PageCount
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.button1 = New System.Windows.Forms.Button()
			Me.label1 = New System.Windows.Forms.Label()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.toPage = New System.Windows.Forms.NumericUpDown()
			Me.fromPage = New System.Windows.Forms.NumericUpDown()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.rangeBtn = New System.Windows.Forms.RadioButton()
			Me.allpageBtn = New System.Windows.Forms.RadioButton()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			CType(Me.toPage, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.fromPage, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button1.BackColor = System.Drawing.Color.Transparent
			Me.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(128))))))
			Me.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(192))))))
			Me.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))))
			Me.button1.Image = (CType(resources.GetObject("button1.Image"), System.Drawing.Image))
			Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
			Me.button1.Location = New System.Drawing.Point(288, 262)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75, 24)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Export"
			Me.button1.UseVisualStyleBackColor = False
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' label1
			' 
			Me.label1.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(0))))), (CInt(Fix((CByte(64))))))
			Me.label1.Location = New System.Drawing.Point(3, 115)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(373, 62)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Essential Pdf Viewer supports exporting of PDF pages as raster image. Click the b" & "utton to Export all or selected pages in PNG format."
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
			Me.pictureBox1.Image = (CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image))
			Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(375, 89)
			Me.pictureBox1.TabIndex = 24
			Me.pictureBox1.TabStop = False
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.toPage)
			Me.groupBox1.Controls.Add(Me.fromPage)
			Me.groupBox1.Controls.Add(Me.label3)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.rangeBtn)
			Me.groupBox1.Controls.Add(Me.allpageBtn)
			Me.groupBox1.Location = New System.Drawing.Point(47, 171)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(224, 115)
			Me.groupBox1.TabIndex = 25
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Page Range"
			' 
			' toPage
			' 
			Me.toPage.Enabled = False
			Me.toPage.Location = New System.Drawing.Point(146, 90)
			Me.toPage.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.toPage.Name = "toPage"
			Me.toPage.Size = New System.Drawing.Size(72, 20)
			Me.toPage.TabIndex = 32
			Me.toPage.Value = New Decimal(New Integer() { 1, 0, 0, 0})
			' 
			' fromPage
			' 
			Me.fromPage.Enabled = False
			Me.fromPage.Location = New System.Drawing.Point(51, 89)
			Me.fromPage.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.fromPage.Name = "fromPage"
			Me.fromPage.Size = New System.Drawing.Size(63, 20)
			Me.fromPage.TabIndex = 31
			Me.fromPage.Value = New Decimal(New Integer() { 1, 0, 0, 0})
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(120, 92)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(20, 13)
			Me.label3.TabIndex = 30
			Me.label3.Text = "To"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(15, 91)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(30, 13)
			Me.label2.TabIndex = 28
			Me.label2.Text = "From"
			' 
			' rangeBtn
			' 
			Me.rangeBtn.AutoSize = True
			Me.rangeBtn.Location = New System.Drawing.Point(18, 60)
			Me.rangeBtn.Name = "rangeBtn"
			Me.rangeBtn.Size = New System.Drawing.Size(58, 17)
			Me.rangeBtn.TabIndex = 27
			Me.rangeBtn.TabStop = True
			Me.rangeBtn.Text = "Pages:"
			Me.rangeBtn.UseVisualStyleBackColor = True
'			Me.rangeBtn.CheckedChanged += New System.EventHandler(Me.rangeBtn_CheckedChanged)
			' 
			' allpageBtn
			' 
			Me.allpageBtn.AutoSize = True
			Me.allpageBtn.Checked = True
			Me.allpageBtn.Location = New System.Drawing.Point(18, 28)
			Me.allpageBtn.Name = "allpageBtn"
			Me.allpageBtn.Size = New System.Drawing.Size(69, 17)
			Me.allpageBtn.TabIndex = 26
			Me.allpageBtn.TabStop = True
			Me.allpageBtn.Text = "All Pages"
			Me.allpageBtn.UseVisualStyleBackColor = True
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.White
			Me.ClientSize = New System.Drawing.Size(375, 298)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.pictureBox1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Export As Image"
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			CType(Me.toPage, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.fromPage, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		Private Sub rangeBtn_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rangeBtn.CheckedChanged
			If rangeBtn.Checked Then
				fromPage.Enabled = True
				toPage.Enabled = True
			Else
				fromPage.Enabled = False
				toPage.Enabled = False
			End If
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
		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			Dim images() As Bitmap

			If allpageBtn.Checked Then
				images = Me.viewer.ExportAsImage(0, viewer.PageCount - 1)
			Else
				images = Me.viewer.ExportAsImage(CInt(Fix(fromPage.Value)) - 1, CInt(Fix(toPage.Value)) - 1)
			End If

			Dim output As String = "..\..\Output\Image"

			System.IO.Directory.CreateDirectory("..\..\Output\")

			For Each image As Bitmap In images
				image.Save(output & Guid.NewGuid().ToString() & ".png", ImageFormat.Png)
			Next image

			If images.Length > 0 Then
				'Message box confirmation to view the created PDF document.
				If MessageBox.Show("Do you want to view the exported image files?", "Image Exported", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
					System.Diagnostics.Process.Start("..\..\Output\")

					Me.Close()
				Else
					' Exit
					Me.Close()
				End If
			End If
		End Sub

		#End Region

		#Region "Helper Methods"
		''' <summary>
		''' Gets the full path of the PDF template or image.
		''' </summary>
		''' <param name="fileName">Name of the file</param>
		''' <param name="image">True if image</param>
		''' <returns>Path of the file</returns>
		Private Function GetFullTemplatePath(ByVal fileName As String) As String
			Dim fullPath As String = "..\..\..\..\..\..\..\..\..\Common\Data\PDF\"

			Return String.Format("{0}{1}", fullPath, fileName)
		End Function
		#End Region

	End Class
End Namespace