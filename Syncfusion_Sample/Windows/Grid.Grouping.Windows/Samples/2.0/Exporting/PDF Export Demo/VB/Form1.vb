#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Graphics
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports System.Xml
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.GridHelperClasses
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System.IO

Namespace PdfConverter
	Partial Public Class Form1
		Inherits MetroForm
		Public ReadOnly Shared connString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")
		Public Sub New()
			InitializeComponent()
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
		End Sub

		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

		Private Function FindImageFile(ByVal bitmapName As String) As String
			Dim bitmappath As String = ""
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					bitmappath = bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n
			Return bitmappath
		End Function

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim commandstring As String = "select * from Products"
			Dim da As New SqlCeDataAdapter(commandstring, connString)


			Dim ds As New DataSet()

			da.Fill(ds, "Customers")



			gridGroupingControl2.DataSource = ds.Tables(0)

			Me.gridGroupingControl2.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridGroupingControl2.GridOfficeScrollBars = OfficeScrollBars.Metro
			Me.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedSingle

			AddHandler gridGroupingControl2.TableControl.PrepareViewStyleInfo, AddressOf TableControl_PrepareViewStyleInfo
            'For i As Integer = 1 To 70
            '	domainUpDown1.Items.Add(i)
            '	domainUpDown2.Items.Add(i)
            '	domainUpDown3.Items.Add(i)
            '	domainUpDown4.Items.Add(i)
            'Next i
            'domainUpDown1.SelectedIndex = 0
            'domainUpDown2.SelectedIndex = 0
            'domainUpDown3.SelectedIndex = 0
            'domainUpDown4.SelectedIndex = 0

			checkBoxAdv1.CheckState = CheckState.Checked
			checkBoxAdv2.CheckState = CheckState.Checked

			gridGroupingControl2.TopLevelGroupOptions.ShowCaption = False
			gridGroupingControl2.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = False
			gridGroupingControl2.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			AddHandler gridGroupingControl2.TableControl.PrepareViewStyleInfo, AddressOf TableControl_PrepareViewStyleInfo
		End Sub
		Private Shared Function FindFile(ByVal fileName As String) As String
			' Check both in parent folder and Parent\Data folders.
			Dim dataFileName As String = "Common\Data\" & fileName
			For n As Integer = 0 To 11
				If System.IO.File.Exists(fileName) Then
					Return New FileInfo(fileName).FullName
				End If
				If System.IO.File.Exists(dataFileName) Then
					Return New FileInfo(dataFileName).FullName
				End If
				fileName = "..\" & fileName
				dataFileName = "..\" & dataFileName
			Next n

			Return fileName
		End Function

		Private Sub pdfConvertor_DrawPDFFooter(ByVal sender As Object, ByVal e As PDFHeaderFooterEventArgs)

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

		Private Sub pdfConvertor_DrawPDFHeader(ByVal sender As Object, ByVal e As PDFHeaderFooterEventArgs)
			Dim header As PdfPageTemplateElement = e.HeaderFooterTemplate

			Dim font As PdfFont = New PdfStandardFont(PdfFontFamily.Helvetica, 24)
			Dim doubleHeight As Single = font.Height * 2
			Dim activeColor As Color = Color.FromArgb(44, 71, 120)
			Dim imageSize As New SizeF(110f, 35f)
			'Locating the logo on the right corner of the Drawing Surface
			Dim imageLocation As New PointF(e.HeaderFooterTemplate.Width - imageSize.Width - 20, 5)

			Dim img As PdfImage = New PdfBitmap(FindImageFile("common\Images\Grid\PDF_logo\logo.png"))

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
			header.Graphics.DrawString("Syncfusion Essential Grid", font, brush, New RectangleF(0, 0, header.Width, header.Height), format)
			brush = New PdfSolidBrush(Color.Gray)
			font = New PdfStandardFont(PdfFontFamily.Helvetica, 6, PdfFontStyle.Bold)

			format = New PdfStringFormat()
			format.Alignment = PdfTextAlignment.Left
			format.LineAlignment = PdfVerticalAlignment.Bottom

			'Draw some lines in the header
			pen = New PdfPen(Color.DarkBlue, 0.7f)
			header.Graphics.DrawLine(pen, 0, 0, header.Width, 0)
			pen = New PdfPen(Color.DarkBlue, 2f)
			header.Graphics.DrawLine(pen, 0, 03, header.Width + 3, 03)
			pen = New PdfPen(Color.DarkBlue, 2f)
			header.Graphics.DrawLine(pen, 0, header.Height - 3, header.Width, header.Height - 3)
			header.Graphics.DrawLine(pen, 0, header.Height, header.Width, header.Height)
		End Sub


		Private Sub toolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			If ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Dim pdfConvertor As New GridPDFConverter()

				If checkBoxAdv1.CheckState = CheckState.Checked Then
					pdfConvertor.ShowHeader = True

				End If
				If checkBoxAdv2.CheckState = CheckState.Checked Then
					pdfConvertor.ShowFooter = True
				End If

                pdfConvertor.Margins.Left = domainUpDown1.Value
                pdfConvertor.Margins.Right = domainUpDown2.Value
                pdfConvertor.Margins.Top = domainUpDown3.Value
                pdfConvertor.Margins.Bottom = domainUpDown4.Value

				AddHandler pdfConvertor.DrawPDFHeader, AddressOf pdfConvertor_DrawPDFHeader

				AddHandler pdfConvertor.DrawPDFFooter, AddressOf pdfConvertor_DrawPDFFooter

                'pdfConvertor.Margins.All = 25
				pdfConvertor.ExportToPdf("Sample.pdf", Me.gridGroupingControl2.TableControl)
				'Launching the PDF file using the default Application.[Acrobat Reader]
				System.Diagnostics.Process.Start("Sample.pdf")
			End If
		End Sub



		Private Sub TableControl_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs)
			e.Style.BackColor = Color.Azure
		End Sub


		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
				Dim pdfConvertor As New GridPDFConverter()

				If checkBoxAdv1.CheckState = CheckState.Checked Then
					pdfConvertor.ShowHeader = True

				End If
				If checkBoxAdv2.CheckState = CheckState.Checked Then
					pdfConvertor.ShowFooter = True
				End If

            pdfConvertor.Margins.Left = domainUpDown1.Value
            pdfConvertor.Margins.Right = domainUpDown2.Value
            pdfConvertor.Margins.Top = domainUpDown3.Value
            pdfConvertor.Margins.Bottom = domainUpDown4.Value

				AddHandler pdfConvertor.DrawPDFHeader, AddressOf pdfConvertor_DrawPDFHeader

				AddHandler pdfConvertor.DrawPDFFooter, AddressOf pdfConvertor_DrawPDFFooter

            'pdfConvertor.Margins.All = 25
				pdfConvertor.ExportToPdf("Sample.pdf", Me.gridGroupingControl2.TableControl)
				'Launching the PDF file using the default Application.[Acrobat Reader]
				System.Diagnostics.Process.Start("Sample.pdf")

		End Sub

	End Class
End Namespace
