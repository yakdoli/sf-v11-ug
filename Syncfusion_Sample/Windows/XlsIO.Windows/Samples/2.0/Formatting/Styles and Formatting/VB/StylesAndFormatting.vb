Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.XlsIO

Public Class StylesAndFormatting

#Region "Constants"
    Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\{0}"
#End Region

#Region "Styles And Formatting"
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
        'The instantiation process consists of two steps.

        'Step 1 : Instantiate the spreadsheet creation engine.
        Dim excelEngine As ExcelEngine = New ExcelEngine()
        'Step 2 : Instantiate the excel application object.
        Dim application As IApplication = excelEngine.Excel

        'Set the default version as Excel 2007
        If rdbExcel2007.Checked Then
            application.DefaultVersion = ExcelVersion.Excel2007
        End If
        'Set the default version as Excel 2010
        If rdbExcel2010.Checked Then
            application.DefaultVersion = ExcelVersion.Excel2010
        End If
        'Set the default version as Excel 2013
        If rdbExcel2013.Checked Then
            application.DefaultVersion = ExcelVersion.Excel2013
        End If

        'A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
        'The new workbook will have 12 worksheets
        Dim workbook As IWorkbook = application.Workbooks.Create(12)
        'Get the Path of the Input File
        Dim inputPath As String = GetFullTemplatePath("CalendarTemplate.xlsx")
        Dim tempWorkbook As IWorkbook = application.Workbooks.Open(inputPath)
        workbook.Worksheets.AddCopyAfter(tempWorkbook.Worksheets(0), workbook.Worksheets(11))

        'The first worksheet object in the worksheets collection is accessed.
        Dim worksheet As IWorksheet

        '#Region "Calendar"

        '#Region "Draw Calendar"
        Dim monthArray As String() = New String() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
        Dim dateArray As String() = New String() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}
        Dim colorArray As Color() = New Color() {Color.FromArgb(149, 55, 53), Color.FromArgb(146, 208, 80), Color.FromArgb(0, 32, 96), Color.FromArgb(0, 176, 80), Color.FromArgb(255, 255, 0), Color.FromArgb(128, 128, 128), Color.FromArgb(255, 0, 0), Color.FromArgb(96, 73, 123), Color.FromArgb(169, 161, 117), Color.FromArgb(0, 176, 240), Color.FromArgb(192, 0, 0), Color.FromArgb(63, 49, 81), Color.FromArgb(192, 0, 0)}

        Dim currentMonth As Integer = DateTime.Today.Month - 1

        For monIndex As Integer = 1 To 12
            worksheet = workbook.Worksheets(monIndex - 1)
            worksheet.Name = monthArray(monIndex - 1)

            worksheet.Range("B3:H3").Merge()
            worksheet.Range("B4:H4").Merge()
            worksheet.IsGridLinesVisible = False

            'Write the month as the heading
            worksheet.Range("B3").Text = monthArray(monIndex - 1)

            'Apply styles for the month title
            worksheet.Range("B3:H3").HorizontalAlignment = ExcelHAlign.HAlignCenter
            worksheet.Range("B3:H3").VerticalAlignment = ExcelVAlign.VAlignCenter
            worksheet.Range("B3:H3").BorderAround(ExcelLineStyle.Thin, Color.Brown)
            worksheet.Range("B3:H3").RowHeight = 30

            Dim style As IStyle = worksheet.Range("B3").CellStyle
            style.HorizontalAlignment = ExcelHAlign.HAlignCenter
            style.Interior.FillPattern = ExcelPattern.Gradient
            style.Interior.Gradient.TwoColorGradient(ExcelGradientStyle.Diagonl_Up, ExcelGradientVariants.ShadingVariants_3)
            style.Interior.Gradient.ForeColorIndex = ExcelKnownColors.White
            style.Interior.Gradient.BackColor = colorArray(monIndex - 1)
            Dim font As IFont = style.Font
            font.FontName = "Segoe UI"
            font.Size = 22
            font.Italic = True

            'Write the weekdays
            Dim i As Integer = 2
            Dim j As Integer = 0
            Do While i < 9
                worksheet.SetValue(5, i, dateArray(j))
                worksheet.Range(5, i).HorizontalAlignment = ExcelHAlign.HAlignCenter
                i += 1
                j += 1
            Loop

            'Get the number of days in the month
            Dim days As Integer = DateTime.DaysInMonth(DateTime.Today.Year, monIndex)

            'Write the calendar
            Dim firstDay As DateTime = New DateTime(DateTime.Today.Year, monIndex, 1)
            Dim range As IRange = worksheet.FindFirst(firstDay.Date.DayOfWeek.ToString(), ExcelFindType.Text)

            Dim row As Integer = range.End.Row + 1
            Dim column As Integer = range.End.Column
            Dim date_Value As Integer = 1

            Do While date_Value < days + 1
                Do While column < 9
                    worksheet.Range(row, column).Number = date_Value
                    date_Value += 1
                    If date_Value = days + 1 Then
                        Exit Do
                    End If
                    column += 1
                Loop
                column = 2
                row += 1
            Loop

            ' Format Sunday
            worksheet.Range("B5:B11").BuiltInStyle = BuiltInStyles.WarningText
            worksheet.Range("B5").CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter

            ' Format day title
            worksheet.Range("B5:H5").BuiltInStyle = BuiltInStyles.Heading4
            worksheet.Range("B5:H5").CellStyle.Font.Size = 10

            ' Border around the entire calendar
            worksheet.UsedRange.BorderAround(ExcelLineStyle.Double, Color.Black)
            worksheet.UsedRange.BorderInside(ExcelLineStyle.Hair, Color.Black)

            worksheet.Range("B3").RowHeight = 35
            worksheet.Range("B5:H11").RowHeight = 60
            worksheet.UsedRange.ColumnWidth = 15

            ' Set Legend
            worksheet("K7").BuiltInStyle = BuiltInStyles.Accent2_20
            worksheet("K8").BuiltInStyle = BuiltInStyles.Accent4_20

            worksheet.Range("L7").Text = "Holidays"
            worksheet.Range("L8").Text = "Today"
            worksheet.Range("L7:L8").CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter
        Next monIndex
        '#End Region

        '#Region "Styles for today"
        For Each cSheet As IWorksheet In workbook.Worksheets
            If cSheet.Name = monthArray(currentMonth) Then
                'Apply styles for today
                Dim tRange As IRange = cSheet.FindFirst(DateTime.Today.Day, ExcelFindType.Number)
                tRange.BuiltInStyle = BuiltInStyles.Accent4_20
                tRange.CellStyle.Font.RGBColor = Color.Purple

                tRange.AddComment().Text = "Today"
                tRange.Comment.Width = 100
                tRange.Comment.Height = 40
                cSheet.Activate()
            ElseIf cSheet.Name = "Holidays" Then
                cSheet.Range("B3").BuiltInStyle = BuiltInStyles.Accent2_20
                cSheet.Range("B3").CellStyle.Font.FontName = "Calibri"
                cSheet.Range("B3").CellStyle.Font.Size = 11
                cSheet.Range("B3").CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter
            End If
        Next cSheet

        '#End Region

        '#Region "Update Holidays"

        'Highlight holidays
        For i As Integer = 8 To 18
            Dim sheetIndex As Integer = workbook.Worksheets(12).Range("D" & i.ToString()).DateTime.Month
            Dim holiday As IRange = workbook.Worksheets(sheetIndex - 1).FindFirst(workbook.Worksheets(12).Range("D" & i.ToString()).DateTime.Day, ExcelFindType.Number)
            holiday.AddComment().Text = workbook.Worksheets(12).Range("B" & i.ToString()).Text
            holiday.Comment.Width = 100
            holiday.Comment.Height = 40
            holiday.BuiltInStyle = BuiltInStyles.Accent2_20
            holiday.CellStyle.Font.RGBColor = Color.Red
        Next i

        '#End Region

        '#End Region

        'Saving the workbook to disk.
        workbook.SaveAs("StylesAndFormatting.xlsx")

        'Close the workbook.
        workbook.Close()

        'No exception will be thrown if there are unsaved workbooks.
        excelEngine.ThrowNotSavedOnDestroy = False
        excelEngine.Dispose()

        'Message box confirmation to view the created spreadsheet.
        If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Try
                'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("StylesAndFormatting.xlsx")
                'Exit
                Me.Close()
            Catch ex As Win32Exception
                MessageBox.Show("MS Excel is not installed in this system")
            End Try
        Else
            ' Exit
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

    Private Sub viewInputTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewInputTemplate.Click
        'Get the path of the Input File
        Dim inputPath As String = GetFullTemplatePath("CalendarTemplate.xlsx")
        'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
        System.Diagnostics.Process.Start(inputPath)
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.rdbExcel2013.Checked = True
        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
