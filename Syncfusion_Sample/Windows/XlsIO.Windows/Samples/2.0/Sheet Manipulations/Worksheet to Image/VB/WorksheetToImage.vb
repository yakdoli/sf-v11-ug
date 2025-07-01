Imports Syncfusion.XlsIO
Imports System.Drawing.Imaging
Imports System.Diagnostics

Public Class EssentailXlsIOSamples
    Dim fileName As String

#Region "Constants"
    Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\{0}"
#End Region

#Region "Image Convert Method"
    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        ' New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
        ' The instantiation process consists of two steps.

        ' Step 1 : Instantiate the spreadsheet creation engine.
        Dim excelEngine As ExcelEngine = New ExcelEngine()

        ' Step 2 : Instantiate the excel application object.
        Dim application As IApplication = excelEngine.Excel
        application.DefaultVersion = ExcelVersion.Excel2007

        Dim inputPath As String = GetFullTemplatePath("WorkSheetToImage.xlsx")

        ' An existing workbook is opened.
        Dim workbook As IWorkbook = application.Workbooks.Open(inputPath)

        ' The first worksheet object in the worksheets collection is accessed.
        Dim worksheet As IWorksheet = workbook.Worksheets("Pivot Table")

        worksheet.UsedRangeIncludesFormatting = False
        Dim lastRow As Integer = worksheet.UsedRange.LastRow + 1
        Dim lastColumn As Integer = worksheet.UsedRange.LastColumn + 1

        ' Save the image.
        If (Me.rdbBitmap.Checked) Then
            ' Convert the worksheet to image
            Dim img As Image = worksheet.ConvertToImage(1, 1, lastRow, lastColumn, ImageType.Bitmap, Nothing)

            fileName = "BitmapImg.png"
            img.Save(fileName, ImageFormat.Png)
        Else
            ' Convert the worksheet to image
            Dim img As Image = worksheet.ConvertToImage(1, 1, lastRow, lastColumn, ImageType.Metafile, Nothing)

            fileName = "MetafileImg.emf"
            img.Save(fileName, ImageFormat.Emf)
        End If


        'Close the workbook.
        workbook.Close()
        excelEngine.Dispose()

        'Message box confirmation to view the created spreadsheet.
        If MessageBox.Show("Do you want to view the image?", "Conversion Successful !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            ' Launch the image
            Process.Start(fileName)
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub
#End Region

#Region "HelperMethod"
    ''' <summary>
    ''' Return the file path of the Input file
    ''' </summary>
    Private Function GetFullTemplatePath(ByVal inputFile As String) As String
        Return String.Format(DEFAULTPATH, inputFile)
    End Function
#End Region

#Region "View the Input Template"
    Private Sub viewInputTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewInputTemplate.Click
        'Get the path of the Input File
        Dim inputPath As String = GetFullTemplatePath("WorkSheetToImage.xlsx")
        'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
        System.Diagnostics.Process.Start(inputPath)
    End Sub
#End Region
End Class
