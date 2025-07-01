Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.XlsIO

Namespace EssentialXlsIOSamples
    Partial Class Form1 : Inherits System.Windows.Forms.Form

#Region "Constructor"
        Public Sub New()
            InitializeComponent()
            Me.rdbExcel2013.Checked = True
        End Sub
#End Region

#Region "Events"
        Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
            Dim excelEngine As ExcelEngine = New ExcelEngine()
            Dim application As IApplication = excelEngine.Excel

          

            Dim fileName As String
            Dim myWorkbook As IWorkbook = Nothing
            Dim sheet As IWorksheet = Nothing

            If Me.rdbExcel97.Checked Then
                myWorkbook = application.Workbooks.Create(3)
                sheet = myWorkbook.Worksheets(0)
                myWorkbook.Version = ExcelVersion.Excel97to2003
                fileName = "Sample.xls"
            ElseIf Me.rdbExcel2007.Checked Then
                myWorkbook = excelEngine.Excel.Workbooks.Open("..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\CFTemplate.xlsx")
                sheet = myWorkbook.Worksheets(0)
                myWorkbook.Version = ExcelVersion.Excel2007
                fileName = "Sample.xlsx"
            ElseIf Me.rdbExcel2010.Checked Then
                myWorkbook = excelEngine.Excel.Workbooks.Open("..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\CFTemplate.xlsx")
                sheet = myWorkbook.Worksheets(0)
                myWorkbook.Version = ExcelVersion.Excel2010
                fileName = "Sample.xlsx"
            ElseIf Me.rdbExcel2013.Checked Then
                myWorkbook = excelEngine.Excel.Workbooks.Open("..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\CFTemplate.xlsx")
                sheet = myWorkbook.Worksheets(0)
                myWorkbook.Version = ExcelVersion.Excel2013
                fileName = "Sample.xlsx"
            End If

            If Not Me.rdbExcel97.Checked Then

                ' "Databar"
                'Add condition for the range
                Dim formats As IConditionalFormats = sheet.Range("C7:C46").ConditionalFormats
                Dim format As IConditionalFormat = formats.AddCondition()

                'Set Data bar and icon set for the same cell
                'Set the format type
                format.FormatType = ExcelCFType.DataBar
                Dim dataBar As IDataBar = format.DataBar

                'Set the constraint
                dataBar.MinPoint.Type = ConditionValueType.LowestValue
                dataBar.MinPoint.Value = "0"
                dataBar.MaxPoint.Type = ConditionValueType.HighestValue
                dataBar.MaxPoint.Value = "0"

                'Set color for Bar
                dataBar.BarColor = Color.FromArgb(156, 208, 243)

                'Hide the value in data bar
                dataBar.ShowValue = False

                ' "Iconset"
                'Add another condition in the same range
                format = formats.AddCondition()

                'Set Icon format type
                format.FormatType = ExcelCFType.IconSet
                Dim iconSet As IIconSet = format.IconSet
                iconSet.IconSet = ExcelIconSetType.FourRating
                iconSet.IconCriteria(0).Type = ConditionValueType.LowestValue
                iconSet.IconCriteria(0).Value = "0"
                iconSet.IconCriteria(1).Type = ConditionValueType.HighestValue
                iconSet.IconCriteria(1).Value = "0"
                iconSet.ShowIconOnly = True

                'Sets Icon sets for another range
                formats = sheet.Range("E7:E46").ConditionalFormats
                format = formats.AddCondition()
                format.FormatType = ExcelCFType.IconSet
                iconSet = format.IconSet
                iconSet.IconSet = ExcelIconSetType.ThreeSymbols
                iconSet.IconCriteria(0).Type = ConditionValueType.LowestValue
                iconSet.IconCriteria(0).Value = "0"
                iconSet.IconCriteria(1).Type = ConditionValueType.HighestValue
                iconSet.IconCriteria(1).Value = "0"
                iconSet.ShowIconOnly = True

                'Add condition for the range
                Dim conditionalFormats1 As IConditionalFormats = sheet.Range("E7:E46").ConditionalFormats
                Dim conditionalFormat1 As IConditionalFormat = conditionalFormats1.AddCondition()

                'Set Data bar and icon set for the same cell
                'Set the conditionalFormat type
                conditionalFormat1.FormatType = ExcelCFType.DataBar
                Dim dataBar1 As IDataBar = conditionalFormat1.DataBar

                'Set the constraint
                dataBar1.BarColor = Color.YellowGreen
                dataBar1.NegativeFillColor = Color.Pink
                dataBar1.NegativeBorderColor = Color.WhiteSmoke
                dataBar1.BarAxisColor = Color.Yellow
                dataBar1.BorderColor = Color.WhiteSmoke
                dataBar1.DataBarDirection = DataBarDirection.context
                dataBar1.DataBarAxisPosition = DataBarAxisPosition.middle
                dataBar1.HasGradientFill = True

                'Hide the value in data bar
                dataBar1.ShowValue = False



                ' "Color Scale"
                formats = sheet.Range("D7:D46").ConditionalFormats
                format = formats.AddCondition()
                format.FormatType = ExcelCFType.ColorScale
                Dim colorScale As IColorScale = format.ColorScale

                'Sets 3 - color scale.
                colorScale.SetConditionCount(3)

                colorScale.Criteria(0).FormatColorRGB = Color.FromArgb(230, 197, 218)
                colorScale.Criteria(0).Type = ConditionValueType.LowestValue
                colorScale.Criteria(0).Value = "0"

                colorScale.Criteria(1).FormatColorRGB = Color.FromArgb(244, 210, 178)
                colorScale.Criteria(1).Type = ConditionValueType.Percentile
                colorScale.Criteria(1).Value = "50"

                colorScale.Criteria(2).FormatColorRGB = Color.FromArgb(245, 247, 171)
                colorScale.Criteria(2).Type = ConditionValueType.HighestValue
                colorScale.Criteria(2).Value = "0"
            Else
                sheet.IsGridLinesVisible = False
                sheet.Range("D2").Text = "Conditional Formatting"
                sheet.Range("D2:E2").Merge()
                sheet.Range("D2").CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter
                sheet.Range("D2").CellStyle.Font.Bold = True
                sheet.Range("D2").CellStyle.Font.Size = 14


                'Applying conditional formatting to "E5" for format type as CellValue( Between)
                Dim condition As IConditionalFormats = sheet.Range("E5").ConditionalFormats
                sheet.Range("E5").CellStyle.Borders.LineStyle = ExcelLineStyle.Medium
                sheet.Range("E5").CellStyle.Borders(ExcelBordersIndex.DiagonalDown).ShowDiagonalLine = False
                sheet.Range("E5").CellStyle.Borders(ExcelBordersIndex.DiagonalUp).ShowDiagonalLine = False

                'Adding formats to IConditionalFormats collection
                Dim condition1 As IConditionalFormat = condition.AddCondition()
                sheet.Range("D5").Text = "Enter a Number between 10 to 20"
                condition1.FirstFormula = "10"
                condition1.SecondFormula = "20"
                'Setting format properties.
                condition1.Operator = ExcelComparisonOperator.Between
                condition1.FormatType = ExcelCFType.CellValue
                condition1.BackColorRGB = Color.FromArgb(238, 122, 3)
                condition1.IsBold = True
                condition1.IsItalic = True

                'Applying conditional formatting to "E8" for format type as CellValue( Equal)
                Dim condition2 As IConditionalFormats = sheet.Range("E8").ConditionalFormats
                sheet.Range("E8").CellStyle.Borders.LineStyle = ExcelLineStyle.Medium
                sheet.Range("E8").CellStyle.Borders(ExcelBordersIndex.DiagonalDown).ShowDiagonalLine = False
                sheet.Range("E8").CellStyle.Borders(ExcelBordersIndex.DiagonalUp).ShowDiagonalLine = False

                'Adding formats to IConditionalFormats collection
                Dim condition3 As IConditionalFormat = condition2.AddCondition()
                sheet.Range("D8").Text = "Enter the Number as 1000"

                'Setting format properties.
                condition3.FormatType = ExcelCFType.CellValue
                condition3.Operator = ExcelComparisonOperator.Equal
                condition3.FirstFormula = "1000"
                condition3.FontColorRGB = Color.FromArgb(&HDE, &H64, &H13)

                'Applying conditional formatting to "E11" for format type as CellValue( Not between)
                Dim condition4 As IConditionalFormats = sheet.Range("E11").ConditionalFormats
                sheet.Range("E11").CellStyle.Borders.LineStyle = ExcelLineStyle.Medium
                sheet.Range("E11").CellStyle.Borders(ExcelBordersIndex.DiagonalDown).ShowDiagonalLine = False
                sheet.Range("E11").CellStyle.Borders(ExcelBordersIndex.DiagonalUp).ShowDiagonalLine = False

                'Adding formats to IConditionalFormats collection
                Dim condition5 As IConditionalFormat = condition4.AddCondition()
                sheet.Range("D11").Text = "Enter a Number not between 100 to 200"
                'Setting format properties
                condition5.FormatType = ExcelCFType.CellValue
                condition5.Operator = ExcelComparisonOperator.NotBetween
                condition5.FirstFormula = "100"
                condition5.SecondFormula = "200"
                condition5.FillPattern = ExcelPattern.DarkVertical

                'Applying conditional formatting to "E14" for format type as CellValue( LessOrEqual)
                Dim condition6 As IConditionalFormats = sheet.Range("E14").ConditionalFormats
                sheet.Range("E14").CellStyle.Borders.LineStyle = ExcelLineStyle.Medium
                sheet.Range("E14").CellStyle.Borders(ExcelBordersIndex.DiagonalDown).ShowDiagonalLine = False
                sheet.Range("E14").CellStyle.Borders(ExcelBordersIndex.DiagonalUp).ShowDiagonalLine = False

                'Adding formats to IConditionalFormats collection
                Dim condition7 As IConditionalFormat = condition6.AddCondition()
                sheet.Range("D14").Text = "Enter a Number which is less than or equal to 1000"
                'Setting format properties.
                condition7.FormatType = ExcelCFType.CellValue
                condition7.Operator = ExcelComparisonOperator.LessOrEqual
                condition7.FirstFormula = "1000"
                condition7.BackColorRGB = Color.FromArgb(204, 212, 230)

                'Applying conditional formatting to "E17" for format type as CellValue( NotEqual)
                Dim condition8 As IConditionalFormats = sheet.Range("E17").ConditionalFormats
                sheet.Range("E17").CellStyle.Borders.LineStyle = ExcelLineStyle.Medium
                sheet.Range("E17").CellStyle.Borders(ExcelBordersIndex.DiagonalDown).ShowDiagonalLine = False
                sheet.Range("E17").CellStyle.Borders(ExcelBordersIndex.DiagonalUp).ShowDiagonalLine = False

                'Adding formats to IConditionalFormats collection
                Dim condition9 As IConditionalFormat = condition8.AddCondition()
                sheet.Range("D17").Text = "Enter a Number which is not equal to 1000"
                'Setting format properties.
                condition9.FormatType = ExcelCFType.CellValue
                condition9.Operator = ExcelComparisonOperator.NotEqual
                condition9.FirstFormula = "1000"
                condition9.BackColorRGB = Color.ForestGreen


                sheet.UsedRange.AutofitColumns()
                sheet.UsedRange.AutofitRows()
            End If

            myWorkbook.SaveAs(fileName)

            'Close the workbook.
            myWorkbook.Close()

            'No exception will be thrown if there are unsaved workbooks.
            excelEngine.ThrowNotSavedOnDestroy = False
            excelEngine.Dispose()


            'Message box confirmation to view the created spreadsheet.
            If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Try
                    'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start(fileName)
                    'Exit
                    Me.Close()
                Catch ex As Win32Exception
                    MessageBox.Show("Excel 2007 is not installed in this system")
                End Try
            Else
                ' Exit
                Me.Close()
            End If
        End Sub
#End Region

        Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        End Sub
    End Class
End Namespace