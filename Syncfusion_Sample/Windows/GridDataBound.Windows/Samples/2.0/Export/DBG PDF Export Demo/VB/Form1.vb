Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2008"
'
'  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.GridHelperClasses
Imports Syncfusion.Pdf.Graphics
Imports Syncfusion.Pdf
Imports System.IO

Namespace DBGPdfCoverter_2005
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Partial Public Class Form1
        Inherits Form
        Private ds As DataSet
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Try
                Dim ico As New Icon(GetIconFile("Common\Images\Grid\Icon\sfgrid1.ico"))
				Me.Icon = ico
			Catch
			End Try
		End Sub

		''' <summary>
		''' Get the path of the icon file.
		''' </summary>
		''' <param name="bitmapName">IconFile name.</param>
		''' <returns>Icon file location.</returns>
		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

		' <summary>
		' Loads the 'northwindDataSet.Customers' table into the form1.
		' </summary>        
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ds = New DataSet()
            ReadXml(ds, "Common\Data\GDBDdata.XML")
            Me.gridDataBoundGrid1.DataSource = ds.Tables("Customers")
		End Sub

		''' <summary>
		''' Export the grid contents to Pdf file.
		''' </summary>
		Private Sub btn_Export(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click

			Dim converter As New GridPDFConverter()
			converter.ShowFooter = True
			converter.ShowHeader = True
			AddHandler converter.DrawPDFFooter, AddressOf converter_DrawPDFFooter
			AddHandler converter.DrawPDFHeader, AddressOf converter_DrawPDFHeader
			converter.ExportToPdf("sample.Pdf", gridDataBoundGrid1)
			System.Diagnostics.Process.Start("sample.pdf")
		End Sub

		''' <summary>
		''' Header Event to create an header that will display on each page.
		''' </summary>
		Private Sub converter_DrawPDFHeader(ByVal sender As Object, ByVal e As PDFHeaderFooterEventArgs)
			Dim header As PdfPageTemplateElement = e.HeaderFooterTemplate

			Dim font As PdfFont = New PdfStandardFont(PdfFontFamily.Helvetica, 24)
			Dim doubleHeight As Single = font.Height * 2
			Dim activeColor As Color = Color.FromArgb(44, 71, 120)
			Dim imageSize As New SizeF(110f, 35f)
			'Locating the logo on the right corner of the Drawing Surface
			Dim imageLocation As New PointF(e.HeaderFooterTemplate.Width - imageSize.Width - 20, 5)

			Dim img As PdfImage = New PdfBitmap("../../Icon/logo.png")
			'Draw the image in the Header.
			header.Graphics.DrawImage(img, imageLocation, imageSize)

			Dim brush As New PdfSolidBrush(activeColor)

			Dim pen As New PdfPen(Color.DarkBlue, 3f)
			font = New PdfStandardFont(PdfFontFamily.Helvetica, 16, PdfFontStyle.Bold)

			'Set formattings for the text
			Dim format As New PdfStringFormat()
			format.Alignment = PdfTextAlignment.Center
			format.LineAlignment = PdfVerticalAlignment.Middle

			'Draw title
			header.Graphics.DrawString("PDF Export Demo", font, brush, New RectangleF(0, 0, header.Width, header.Height), format)
			brush = New PdfSolidBrush(Color.Gray)
			font = New PdfStandardFont(PdfFontFamily.Helvetica, 6, PdfFontStyle.Bold)

			format = New PdfStringFormat()
			format.Alignment = PdfTextAlignment.Left
			format.LineAlignment = PdfVerticalAlignment.Bottom

			'Draw description
			header.Graphics.DrawString("Syncfusion Inc.", font, brush, New RectangleF(0, 0, header.Width, header.Height - 8), format)

			'Draw some lines in the header
			pen = New PdfPen(Color.DarkBlue, 0.7f)
			header.Graphics.DrawLine(pen, 0, 0, header.Width, 0)
			pen = New PdfPen(Color.DarkBlue, 2f)
			header.Graphics.DrawLine(pen, 0, 03, header.Width + 3, 03)
			pen = New PdfPen(Color.DarkBlue, 2f)
			header.Graphics.DrawLine(pen, 0, header.Height - 3, header.Width, header.Height - 3)
			header.Graphics.DrawLine(pen, 0, header.Height, header.Width, header.Height)
		End Sub

		''' <summary>
		''' Get the path of image file.
		''' </summary>
		''' <param name="bitmapName">ImageFile name.</param>
		''' <returns>ImageFile location.</returns>
		Sub ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String)
            Dim n As Integer
            For n = 0 To 10
                If System.IO.File.Exists(xmlFileName) Then
                    ds.ReadXml(xmlFileName)
                    Exit For
                End If
                xmlFileName = "..\" + xmlFileName
            Next n
        End Sub 'ReadXml

		''' <summary>
		''' Footer Event to create a footer that will display on each page.
		''' </summary>
		Private Sub converter_DrawPDFFooter(ByVal sender As Object, ByVal e As PDFHeaderFooterEventArgs)
			Dim footer As PdfPageTemplateElement = e.HeaderFooterTemplate

			Dim font As PdfFont = New PdfStandardFont(PdfFontFamily.Helvetica, 8)

			Dim brush As New PdfSolidBrush(Color.Gray)

			Dim pen As New PdfPen(Color.DarkBlue, 3f)
			font = New PdfStandardFont(PdfFontFamily.Helvetica, 6, PdfFontStyle.Bold)
			Dim format As New PdfStringFormat()
			format.Alignment = PdfTextAlignment.Center
			format.LineAlignment = PdfVerticalAlignment.Middle
			footer.Graphics.DrawString("@Copyright 2008", font, brush, New RectangleF(0, footer.Height - 40, footer.Width, footer.Height), format)

			format = New PdfStringFormat()
			format.Alignment = PdfTextAlignment.Right
			format.LineAlignment = PdfVerticalAlignment.Bottom

			'Create page number field
			Dim pageNumber As New PdfPageNumberField(font, brush)

			'Create page count field
			Dim count As New PdfPageCountField(font, brush)

			Dim compositeField As New PdfCompositeField(font, brush, "Page {0} of {1}", pageNumber, count)
			compositeField.Bounds = footer.Bounds
			compositeField.Draw(footer.Graphics, New PointF(470, footer.Height - 10))
		End Sub
	End Class
End Namespace