Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO

Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Graphics

Namespace PDF_Compression
	Partial Public Class Form1
		Inherits Form
		#Region "Fields"
        Private point As PointF
        Private page As PdfPage
        Private sizef As SizeF
        Private format As PdfLayoutFormat
        Private quality As Integer
		#End Region

		#Region "Constructor"
		Public Sub New()
			InitializeComponent()
			Me.textBox1.Text = String.Empty
			Me.comboBox1.SelectedIndex = 2
			Me.comboBox2.SelectedIndex = 2
		End Sub
		#End Region

		#Region "Events"
		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            quality = GetTargetQuality(Me.comboBox2.SelectedItem.ToString())

            ' Create a new instance of PdfDocument class.
            Dim document As New PdfDocument()
            document.Compression = CType(System.Enum.Parse(GetType(PdfCompressionLevel), Me.comboBox1.SelectedItem.ToString(), True), PdfCompressionLevel)

            '			#Region "Text and Image content"

            ' Add a new page to the document.
            page = document.Pages.Add()

            ' Get page size
            sizef = page.GetClientSize()

            format = New PdfLayoutFormat()
            format.Layout = PdfLayoutType.Paginate

            Dim image As PdfBitmap = TryCast(PdfImage.FromFile(GetFullTemplatePath("Enterprise.png", True)), PdfBitmap)

            ' Draw image.
            Dim result As PdfLayoutResult = DrawImage(image)

            ' Recalculate position for the next element.
            ReCalculateElements(result)

            ' Read text content
            Dim reader As New StreamReader(GetFullTemplatePath("Text1.txt", False))
            Dim text As String = reader.ReadToEnd()

            ' Draw text
            result = DrawText(text)

            ' Recalculate position and continue updating PDF.
            ReCalculateElements(result)

            result = DrawText("Essential Studio User Interface Edition")

            ReCalculateElements(result)

            image = TryCast(PdfImage.FromFile(GetFullTemplatePath("ui.bmp", True)), PdfBitmap)
            result = DrawImage(image)

            ReCalculateElements(result)

            text = "Essential Studio User Interface Edition includes everything you need to build industry standard user interfaces. This studio lets you quickly and easily " & "build enterprise class desktop and Web applications with docking managers, Microsoft Office style controls, menus, business charts, Visio like diagramming, the fastest .NET " & "grid control on the market, and much more. You can design Web applications using over 60 AJAX enabled controls or frameworks with complete documentation and samples " & "and easily add advanced jQuery UI features to your Web applications. This suite includes high performance Grid, Docking and Menu frameworks, data binding controls, " & "Scheduler, Data Visualization Chart, Gauge, Diagram, and more for any .NET platform: Silverlight, ASP.NET MVC, ASP.NET, WPF, and Windows Forms. "
            result = DrawText(text)

            ReCalculateElements(result)

            result = DrawText("Essential Studio Reporting Edition")

            ReCalculateElements(result)

            image = TryCast(PdfImage.FromFile(GetFullTemplatePath("report.bmp", True)), PdfBitmap)
            result = DrawImage(image)

            ReCalculateElements(result)

            text = "Provide business users with the reports they need, in the formats they prefer. Essential Studio Reporting Edition provides .NET components to read " & "and write Excel, Word, and PDF documents and enables your applications to be over 100x faster than office automation. Create advanced reports or " & "integrate document-based reporting into your Windows and Web applications easily. Available for Silverlight, ASP.NET MVC, ASP.NET, WPF, and Windows Forms. "

            result = DrawText(text)

            ReCalculateElements(result)

            result = DrawText("Essential Studio Business Intelligence Edition")

            ReCalculateElements(result)

            image = TryCast(PdfImage.FromFile(GetFullTemplatePath("bi.bmp", True)), PdfBitmap)
            result = DrawImage(image)

            ReCalculateElements(result)

            text = "Integrate BI analysis into your Windows and Web applications with ease. With Essential Studio Business Intelligence Edition, you can easily build WPF, " & "Silver-light, and ASP.NET business intelligence applications. Creating executive dash­boards for the most demanding users is painless with Syncfusion " & "BI Client, Chart, Gauge, Grid and PivotGrid. Works with both OLAP data and relational data. "

            result = DrawText(text)

            ReCalculateElements(result)

            reader = New StreamReader(GetFullTemplatePath("Text2.txt", False))
            text = reader.ReadToEnd()
            result = DrawText(text)

            ReCalculateElements(result)

            image = TryCast(PdfImage.FromFile(GetFullTemplatePath("laptop.png", True)), PdfBitmap)
            result = DrawImage(image)

            ReCalculateElements(result)

            reader = New StreamReader(GetFullTemplatePath("Text3.txt", False))
            text = reader.ReadToEnd()
            result = DrawText(text)

            ReCalculateElements(result)

            image = TryCast(PdfImage.FromFile(GetFullTemplatePath("final.png", True)), PdfBitmap)
            result = DrawImage(image)

            '			#End Region

            ' Save and close the document.
            document.Save("Sample.pdf")
            document.Close(True)

            reader = New StreamReader("Sample.pdf")

            ' Update the text box.
            Me.textBox1.Text &= "Generated Filesize: " & reader.BaseStream.Length.ToString() & " bytes" & Environment.NewLine
            Me.textBox1.Text &= "Done!"

            reader.Close()
            reader.Dispose()

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
		#End Region

#Region "Helpher methods"
        ''' <summary>
        ''' Draw text using PdfTextElement class.
        ''' </summary>
        Private Function DrawText(ByVal text As String) As PdfLayoutResult
            ' Initialize PdfTextElement.
            Dim element As New PdfTextElement(text)

            ' Set Font.
            element.Font = New PdfStandardFont(PdfFontFamily.Helvetica, 10.0F)

            ' Set String format
            element.StringFormat = New PdfStringFormat(PdfTextAlignment.Justify)

            ' Draw and return PdfTextLayoutResult.
            Return element.Draw(page, point, sizef.Width, format)
        End Function

        ''' <summary>
        ''' Draw image using PdfBitmap class.
        ''' </summary>
        Private Function DrawImage(ByVal image As PdfBitmap) As PdfLayoutResult
            ' Set quality.
            image.Quality = quality

            ' Draw and return PdfLayoutResult.
            Return image.Draw(page, point, format)
        End Function

        ''' <summary>
        ''' Parse the image compression level to get the quality.
        ''' </summary>
        Private Function GetTargetQuality(ByVal p As String) As Integer
            Dim quality As Integer = 100

            Select Case p
                Case "Minimum"
                    quality = 20

                Case "Low"
                    quality = 40

                Case "Medium"
                    quality = 60

                Case "High"
                    quality = 80

                Case Else
                    quality = 100
            End Select

            Return quality
        End Function

        ''' <summary>
        ''' Position for the next element.
        ''' </summary>
        Private Sub ReCalculateElements(ByVal result As PdfLayoutResult)
            If result IsNot Nothing Then
                page = result.Page
                point = New PointF(result.Bounds.X, result.Bounds.Y + result.Bounds.Height + 20)
                If point.Y > sizef.Height - page.Section.PageSettings.Margins.Bottom Then
                    point = PointF.Empty
                    page = page.Section.Pages.Add()
                End If
            End If
        End Sub

        ''' <summary>
        ''' Gets the full path of the PDF template or image.
        ''' </summary>
        ''' <param name="fileName">Name of the file</param>
        ''' <param name="image">True if image</param>
        ''' <returns>Path of the file</returns>
        Private Function GetFullTemplatePath(ByVal fileName As String, ByVal image As Boolean) As String
            Dim fullPath As String = "..\..\..\..\..\..\..\..\..\Common\"
            Dim folder As String
            If image Then
                folder = "Images"
            Else
                folder = "Data"
            End If

            Return String.Format("{0}{1}\PDF\{2}", fullPath, folder, fileName)
        End Function
#End Region
	End Class
End Namespace