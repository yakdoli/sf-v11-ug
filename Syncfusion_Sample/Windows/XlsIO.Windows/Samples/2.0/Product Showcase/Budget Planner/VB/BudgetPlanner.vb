Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.XlsIO

Namespace StylesAndFormatting_2005
    Partial Public Class BudgetPlanner : Inherits Form

#Region "Constants"
        Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\{0}"
#End Region

#Region "Initialize"
        Public Sub New()
            InitializeComponent()
        End Sub
#End Region

#Region "Create Spreadsheet"
        ''' <summary>
        ''' Creates Spreadsheet with Styles and Formatting
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()
            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel

            'Get the Path of the Input file
            Dim inputPath As String = GetFullTemplatePath("BudgetPlanner.xls")
            'A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            'The new workbook will have 12 worksheets
            Dim workbook As IWorkbook = application.Workbooks.Open(inputPath)


            Dim worksheet As IWorksheet = workbook.Worksheets(1)
            worksheet.FirstVisibleRow = 3

            Dim font As IFont = workbook.CreateFont()
            font.Bold = True

            '"TextBox"
            Dim textbox As ITextBoxShape = worksheet.TextBoxes.AddTextBox(5, 2, 40, 140)
            textbox.Text = "Quick Budget"
            textbox.RichText.SetFont(0, 11, font)
            textbox.VAlignment = ExcelCommentVAlign.Center
            textbox.HAlignment = ExcelCommentHAlign.Center
            textbox.Fill.FillType = ExcelFillType.Gradient
            textbox.Fill.GradientColorType = ExcelGradientColor.TwoColor
            textbox.Fill.TwoColorGradient(ExcelGradientStyle.Vertical, ExcelGradientVariants.ShadingVariants_2)
            textbox.Fill.BackColor = Color.FromArgb(204, 204, 255)

            textbox = worksheet.TextBoxes.AddTextBox(7, 2, 25, 140)
            textbox.Text = "Income"
            textbox.RichText.SetFont(0, 5, font)
            textbox.VAlignment = ExcelCommentVAlign.Center
            textbox.HAlignment = ExcelCommentHAlign.Center
            textbox.Fill.FillType = ExcelFillType.Gradient
            textbox.Fill.GradientColorType = ExcelGradientColor.TwoColor
            textbox.Fill.TwoColorGradient(ExcelGradientStyle.Vertical, ExcelGradientVariants.ShadingVariants_2)
            textbox.Fill.BackColor = Color.FromArgb(0, 0, 128)

            textbox = worksheet.TextBoxes.AddTextBox(16, 2, 25, 140)
            textbox.Text = "Spending"
            textbox.RichText.SetFont(0, 7, font)
            textbox.VAlignment = ExcelCommentVAlign.Center
            textbox.HAlignment = ExcelCommentHAlign.Center
            textbox.Fill.FillType = ExcelFillType.Gradient
            textbox.Fill.GradientColorType = ExcelGradientColor.TwoColor
            textbox.Fill.TwoColorGradient(ExcelGradientStyle.Vertical, ExcelGradientVariants.ShadingVariants_2)
            textbox.Fill.BackColor = Color.FromArgb(0, 0, 128)



            '"Write Text and Numbers"
            worksheet.Range("O6").Text = "Weekly"
            worksheet.Range("E7").Text = "Frequency"
            worksheet.Range("F7").Text = "Amount"
            worksheet.Range("G7").Text = "Monthly"
            worksheet.Range("H7").Text = "Yearly"

            worksheet.Range("B8").Text = "Total Income"
            worksheet.Range("C9").Text = "Salary/Wages"
            worksheet.Range("C10").Text = "Salary/Wages(Spouse)"
            worksheet.Range("C11").Text = "Other"
            worksheet.Range("C12").Text = "Other"
            worksheet.Range("C13").Text = "Other"
            worksheet.Range("B17").Text = "Transportation"

            worksheet.Range("F25").Number = 3000
            worksheet.Range("F9").Number = 55000
            worksheet.Range("F10").Number = 35000


            worksheet.Range("C18").Text = "Auto Loan/Lease"
            worksheet.Range("C19").Text = "Insurance"
            worksheet.Range("C20").Text = "Gas "
            worksheet.Range("C21").Text = "Maintenance "
            worksheet.Range("C22").Text = "Registration/Inspection"
            worksheet.Range("C23").Text = "Bill's train pass"
            worksheet.Range("C24").Text = "Jane's bus pass"
            worksheet.Range("C25").Text = "Other"

            worksheet.Range("E16").Text = "Total"

            worksheet.Range("N6").Text = "Chart"

            worksheet.Range("B27").Text = "Home"

            worksheet.Range("F28").Number = 20000
            worksheet.Range("F29").Number = 5000
            worksheet.Range("F33").Number = 5000

            worksheet.Range("C28").Text = "EMI"
            worksheet.Range("C29").Text = "Rent"
            worksheet.Range("C30").Text = "Maintanence"
            worksheet.Range("C31").Text = "Insurance"
            worksheet.Range("C32").Text = "Furniture"
            worksheet.Range("C33").Text = "Household Supplies"
            worksheet.Range("C34").Text = "Groceries"
            worksheet.Range("C35").Text = "Real Estate Tax"
            worksheet.Range("C36").Text = "Other"

            worksheet.Range("B39").Text = "Utilities"

            worksheet.Range("F41").Number = 1000
            worksheet.Range("F42").Number = 250
            worksheet.Range("F43").Number = 150
            worksheet.Range("F45").Number = 175

            worksheet.Range("C40").Text = "Phone - Home"
            worksheet.Range("C41").Text = "Phone - Cell"
            worksheet.Range("C42").Text = "Cable"
            worksheet.Range("C43").Text = "Gas"
            worksheet.Range("C44").Text = "Water"
            worksheet.Range("C45").Text = "Electricity"
            worksheet.Range("C46").Text = "Internet"
            worksheet.Range("C47").Text = "Other"

            worksheet.Range("B50").Text = "Health"

            worksheet.Range("F53").Number = 500


            worksheet.Range("C51").Text = "Dental"
            worksheet.Range("C52").Text = "Medical"
            worksheet.Range("C53").Text = "Medication"
            worksheet.Range("C54").Text = "Vision/contacts"
            worksheet.Range("C55").Text = "Life Insurance"
            worksheet.Range("C56").Text = "Electricity"
            worksheet.Range("C57").Text = "Other"


            '"Cell styles"

            Dim tableStyle As IStyle = workbook.Styles.Add("TableStyle")

            tableStyle.BeginUpdate()
            tableStyle.Color = Color.White
            tableStyle.Borders(ExcelBordersIndex.EdgeBottom).ColorRGB = Color.FromArgb(150, 150, 150)
            tableStyle.Borders(ExcelBordersIndex.EdgeBottom).LineStyle = ExcelLineStyle.Thin
            tableStyle.Borders(ExcelBordersIndex.EdgeLeft).ColorRGB = Color.FromArgb(150, 150, 150)
            tableStyle.Borders(ExcelBordersIndex.EdgeLeft).LineStyle = ExcelLineStyle.Thin
            tableStyle.Borders(ExcelBordersIndex.EdgeRight).ColorRGB = Color.FromArgb(150, 150, 150)
            tableStyle.Borders(ExcelBordersIndex.EdgeRight).LineStyle = ExcelLineStyle.Thin
            tableStyle.Borders(ExcelBordersIndex.EdgeTop).ColorRGB = Color.FromArgb(150, 150, 150)
            tableStyle.Borders(ExcelBordersIndex.EdgeTop).LineStyle = ExcelLineStyle.Thin
            tableStyle.EndUpdate()

            worksheet.Range("E7:H7").CellStyle.Font.Bold = True
            worksheet.Range("B17").CellStyle.Font.Bold = True
            worksheet.Range("B27").CellStyle.Font.Bold = True
            worksheet.Range("B39").CellStyle.Font.Bold = True
            worksheet.Range("B50").CellStyle.Font.Bold = True

            worksheet.Range("E7:H7").CellStyle.Font.Underline = ExcelUnderline.Single


            worksheet.Range("B7:H14").CellStyle.Color = Color.FromArgb(223, 223, 223)
            worksheet.Range("C9:C13").CellStyle = tableStyle
            worksheet.Range("E9:F13").CellStyle = tableStyle


            worksheet.Range("B16:H26").CellStyle.Color = Color.FromArgb(223, 223, 223)
            worksheet.Range("B17:C17").CellStyle.Color = Color.White

            worksheet.Range("C18:C25").CellStyle = tableStyle
            worksheet.Range("O6").CellStyle = tableStyle
            worksheet.Range("E18:F25").CellStyle = tableStyle

            worksheet.Range("B27:H38").CellStyle.Color = Color.FromArgb(223, 223, 223)
            worksheet.Range("C28:C36").CellStyle = tableStyle
            worksheet.Range("B27:C27").CellStyle.Color = Color.White
            worksheet.Range("E28:F36").CellStyle = tableStyle

            worksheet.Range("B39:H49").CellStyle.Color = Color.FromArgb(223, 223, 223)
            worksheet.Range("C40:C47").CellStyle = tableStyle
            worksheet.Range("B39:C39").CellStyle.Color = Color.White
            worksheet.Range("E40:F47").CellStyle = tableStyle

            worksheet.Range("B50:H58").CellStyle.Color = Color.FromArgb(223, 223, 223)
            worksheet.Range("C51:C57").CellStyle = tableStyle
            worksheet.Range("B50:C50").CellStyle.Color = Color.White
            worksheet.Range("E51:F57").CellStyle = tableStyle




            '"Data Validation"
            Dim validation As IDataValidation = worksheet.Range("E9:E13").DataValidation
            worksheet.Range("E9:E13").Text = "Monthly"
            validation.ListOfValues = New String() {"Daily", "Weekly", "Monthly", "Semi-Annually", "Quarterly", "Yearly"}

            Dim validation1 As IDataValidation = worksheet.Range("E18:E25").DataValidation
            worksheet.Range("E18:E25").Text = "Monthly"
            validation1.ListOfValues = New String() {"Daily", "Weekly", "Monthly", "Semi-Annually", "Quarterly", "Yearly"}

            Dim validation2 As IDataValidation = worksheet.Range("O6").DataValidation
            validation2.ListOfValues = New String() {"Weekly", "Monthly", "Yearly"}

            Dim validation3 As IDataValidation = worksheet.Range("E28:E37").DataValidation
            worksheet.Range("E28:E36").Text = "Monthly"
            validation3.ListOfValues = New String() {"Daily", "Weekly", "Monthly", "Semi-Annually", "Quarterly", "Yearly"}


            Dim validation4 As IDataValidation = worksheet.Range("E40:E47").DataValidation
            worksheet.Range("E40:E47").Text = "Monthly"
            validation4.ListOfValues = New String() {"Daily", "Weekly", "Monthly", "Semi-Annually", "Quarterly", "Yearly"}

            Dim validation5 As IDataValidation = worksheet.Range("E51:E57").DataValidation
            worksheet.Range("E51:E57").Text = "Monthly"
            validation5.ListOfValues = New String() {"Daily", "Weekly", "Monthly", "Semi-Annually", "Quarterly", "Yearly"}



            '"Formulas"
            worksheet.Range("G8").Formula = "SUM(G9:G13)"
            worksheet.Range("H8").Formula = "SUM(H9:H13)"

            worksheet.Range("G17").Formula = "SUM(G18:G25)"
            worksheet.Range("H17").Formula = "SUM(H18:H25)"
            worksheet.Range("G16").Formula = "G17+G27+G39+G50+G59+G71"
            worksheet.Range("h16").Formula = "H17+H27+H39+H50+H59+H71"

            For i As Integer = 9 To 13
                worksheet.Range("G" & i).Formula = "F" & i & "*A" & i
                worksheet.Range("H" & i).Formula = "G" & i & "*12"
            Next i

            For i As Integer = 18 To 25
                worksheet.Range("G" & i).Formula = "F" & i & "*A" & i
                worksheet.Range("H" & i).Formula = "G" & i & "*12"
            Next i

            worksheet.Range("G27").Formula = "SUM(G28:G36)"
            worksheet.Range("H27").Formula = "SUM(H28:H37)"
            For i As Integer = 28 To 36
                worksheet.Range("G" & i).Formula = "F" & i & "*A" & i
                worksheet.Range("H" & i).Formula = "G" & i & "*12"
            Next i

            worksheet.Range("G39").Formula = "SUM(G40:G47)"
            worksheet.Range("H39").Formula = "SUM(H40:H47)"
            For i As Integer = 40 To 47
                worksheet.Range("G" & i).Formula = "F" & i & "*A" & i
                worksheet.Range("H" & i).Formula = "G" & i & "*12"
            Next i

            worksheet.Range("G50").Formula = "SUM(G51:G57)"
            worksheet.Range("H50").Formula = "SUM(H51:H57)"
            For i As Integer = 51 To 57
                worksheet.Range("G" & i).Formula = "F" & i & "*A" & i
                worksheet.Range("H" & i).Formula = "G" & i & "*12"
            Next i



            '"SummaryChart"
            'Clustered Column Chart
            Dim chart As IChartShape = worksheet.Charts.Add()

            'Set Chart Type
            chart.ChartType = ExcelChartType.Bar_Clustered

            'Set DataRange. 

            chart.Series.Add("Expense")
            chart.Series(0).Values = workbook.Worksheets("Sheet1").Range("N10")
            chart.Series(0).DataPoints(0).DataLabels.IsValue = True
            chart.Series(0).DataPoints(0).DataLabels.Size = 7.0F


            chart.Series.Add("Income")
            chart.Series(1).Values = workbook.Worksheets("Sheet1").Range("N9")
            chart.Series(1).DataPoints(0).DataLabels.IsValue = True
            chart.Series(1).DataPoints(0).DataLabels.Size = 7.0F

            chart.Series.Add("Balance")
            chart.Series(2).Values = workbook.Worksheets("Sheet1").Range("N8")
            chart.Series(2).DataPoints(0).DataLabels.IsValue = True
            chart.Series(2).DataPoints(0).DataLabels.Size = 7.0F

            chart.PrimaryValueAxis.NumberFormat = "$#,##0"
            chart.PrimaryCategoryAxis.Visible = False

            chart.ChartTitle = ""

            'Format Chart Area
            Dim chartArea As IChartFrameFormat = chart.ChartArea

            'Style
            chartArea.Border.LinePattern = ExcelChartLinePattern.Solid
            chartArea.Border.LineColor = Color.Gray
            chartArea.Border.LineWeight = ExcelChartLineWeight.Medium


            'Plot Area
            Dim chartPlotArea As IChartFrameFormat = chart.PlotArea
            chartPlotArea.Border.LinePattern = ExcelChartLinePattern.Solid
            chart.PlotArea.Border.LineColor = Color.Gray

            chart.Legend.Position = ExcelLegendPosition.Bottom

            'Embedded chart position.
            chart.TopRow = 7
            chart.BottomRow = 22
            chart.LeftColumn = 9
            chart.RightColumn = 16

            chart.ChartTitle = "Budget Summary"
            chart.ChartTitleArea.Bold = True

            '"SpendingChart"

            chart = worksheet.Charts.Add()
            chart.ChartTitle = "Spending Summary"
            chart.ChartTitleArea.Bold = True

            'Set Chart Type
            chart.ChartType = ExcelChartType.Pie_3D

            'Set DataRange. 
            chart.DataRange = workbook.Worksheets("Sheet1").Range("J9:K12")
            chart.IsSeriesInRows = False
            chart.Series(0).Values = workbook.Worksheets("Sheet1").Range("K9:K12")
            chart.Series(0).CategoryLabels = workbook.Worksheets("Sheet1").Range("J9:J12")
            chart.Series(0).Name = "Spending summary"

            chart.Series(0).DataPoints(0).DataLabels.IsValue = True
            chart.Series(0).DataPoints(0).DataLabels.Size = 7.0F

            chart.Series(0).DataPoints(1).DataLabels.IsValue = True
            chart.Series(0).DataPoints(1).DataLabels.Size = 7.0F

            chart.Series(0).DataPoints(2).DataLabels.IsValue = True
            chart.Series(0).DataPoints(2).DataLabels.Size = 7.0F

            chart.Series(0).DataPoints(3).DataLabels.IsValue = True
            chart.Series(0).DataPoints(3).DataLabels.Size = 7.0F


            chart.PrimaryValueAxis.Font.Size = 6.5F
            chart.PrimaryCategoryAxis.Font.Color = ExcelKnownColors.Grey_40_percent

            chart.PrimaryValueAxis.NumberFormat = "$#,##0"

            'Format Chart Area
            chartArea = chart.ChartArea

            'Style
            chartArea.Border.LinePattern = ExcelChartLinePattern.Solid
            chartArea.Border.LineColor = Color.Gray
            chartArea.Border.LineWeight = ExcelChartLineWeight.Medium


            'Plot Area
            chartPlotArea = chart.PlotArea
            chartPlotArea.Border.LinePattern = ExcelChartLinePattern.Solid
            chart.PlotArea.Border.LineColor = Color.Gray
            chartPlotArea.Fill.ForeColor = Color.FromArgb(223, 223, 223)

            chart.Legend.Position = ExcelLegendPosition.Bottom


            'Embedded chart position.
            chart.TopRow = 25
            chart.BottomRow = 42
            chart.LeftColumn = 9
            chart.RightColumn = 16


            '"Sheet View"
            workbook.Worksheets("Sheet1").Visibility = WorksheetVisibility.Hidden
            workbook.Worksheets(0).Activate()
            workbook.TabSheets(0).TabColor = ExcelKnownColors.Blue
            workbook.TabSheets(1).TabColor = ExcelKnownColors.Blue
            workbook.Worksheets(1).IsRowColumnHeadersVisible = False
            worksheet.InsertColumn(9)

            'Saving the workbook to disk.
            workbook.SaveAs("BudgetPlannerOutput.xls")

            'Close the workbook.
            workbook.Close()
            excelEngine.Dispose()

            'Message box confirmation to view the created spreadsheet.
            If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

                'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("BudgetPlannerOutput.xls")
                'Exit
                Me.Close()

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

#Region "View the Input file"
        Private Sub viewInputTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewInputTemplate.Click
            'Get the path of the Input File
            Dim inputPath As String = GetFullTemplatePath("BudgetPlanner.xls")
            'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start(inputPath)
        End Sub
#End Region
    End Class
End Namespace