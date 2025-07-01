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
			viewer.Load(GetFullTemplatePath("Barcode.pdf"))
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
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.button1.Location = New System.Drawing.Point(288, 186)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75, 24)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Print"
			Me.button1.UseVisualStyleBackColor = False
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' label1
			' 
			Me.label1.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(0))))), (CInt(Fix((CByte(64))))))
			Me.label1.Location = New System.Drawing.Point(2, 111)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(373, 62)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Essential Pdf Viewer enables print support. The pages can be printed using PrintD" & "ialog or silent print. Click the button to start print."
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
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.White
			Me.ClientSize = New System.Drawing.Size(375, 227)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.pictureBox1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Silent Printing"
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

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
			' Initialize print dialog.
			Dim dialog As New PrintDialog()
			dialog.AllowPrintToFile = True
			dialog.AllowSomePages = True
			dialog.AllowCurrentPage = True

			dialog.Document = viewer.PrintDocument
            dialog.Document.Print()
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