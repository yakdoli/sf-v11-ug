Imports Syncfusion.XlsIO

Public Class Tables

#Region "Creating Table"
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Dim excelEngine As ExcelEngine = New ExcelEngine()
        Dim application As IApplication = excelEngine.Excel

        'Set the default version as Excel 2007
        If rdbExcel2007.Checked Then
            application.DefaultVersion = ExcelVersion.Excel2007
        End If
        'Set the default version as Excel 2010
        If rdbExcel2010.Checked Then
            application.DefaultVersion = ExcelVersion.Excel2010
        End If
        'Set the default version as Excel 2010
        If rdbExcel2013.Checked Then
            application.DefaultVersion = ExcelVersion.Excel2013
        End If

        Dim workbook As IWorkbook = application.Workbooks.Create(1)
        Dim worksheet As IWorksheet = workbook.Worksheets(0)

        '#Region "Table data"
        ' Create data
        worksheet(1, 1).Text = "Products"
        worksheet(1, 2).Text = "Qtr1"
        worksheet(1, 3).Text = "Qtr2"

        worksheet(2, 1).Text = "Alfreds Futterkiste"
        worksheet(2, 2).Number = 744.6
        worksheet(2, 3).Number = 162.56

        worksheet(3, 1).Text = "Antonio Moreno Taqueria"
        worksheet(3, 2).Number = 5079.6
        worksheet(3, 3).Number = 1249.2

        worksheet(4, 1).Text = "Around the Horn"
        worksheet(4, 2).Number = 1267.5
        worksheet(4, 3).Number = 1062.5

        worksheet(5, 1).Text = "Bon app"
        worksheet(5, 2).Number = 1418
        worksheet(5, 3).Number = 756

        worksheet(6, 1).Text = "Eastern Connection"
        worksheet(6, 2).Number = 4728
        worksheet(6, 3).Number = 4547.92

        worksheet(7, 1).Text = "Ernst Handel"
        worksheet(7, 2).Number = 943.89
        worksheet(7, 3).Number = 349.6
        '#End Region

        ' Create style for table number format
        Dim style1 As IStyle = workbook.Styles.Add("CurrencyFormat")
        style1.NumberFormat = "_($* #,##0.00_);_($* (#,##0.00);_($* "" - ""??_);_(@_)"

        ' Apply number format
        worksheet("B2:C8").CellStyleName = "CurrencyFormat"

        ' Create table
        Dim table1 As IListObject = worksheet.ListObjects.Create("Table1", worksheet("A1:C7"))

        ' Apply builtin style
        table1.BuiltInTableStyle = TableBuiltInStyles.TableStyleMedium9

        ' Total row
        table1.ShowTotals = True
        table1.Columns(0).TotalsRowLabel = "Total"
        table1.Columns(1).TotalsCalculation = ExcelTotalsCalculation.Sum
        table1.Columns(2).TotalsCalculation = ExcelTotalsCalculation.Sum

        worksheet.UsedRange.AutofitColumns()
        worksheet.SetColumnWidth(2, 12.43)

        ' Save and close the document
        workbook.SaveAs("Tables.xlsx")
        workbook.Close()
        excelEngine.Dispose()

        'Message box confirmation to view the created spreadsheet.
        If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start("Tables.xlsx")
            Me.Close()
        Else
            ' Exit
            Me.Close()
        End If
    End Sub
#End Region

    Private Sub Tables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdbExcel2013.Checked = True
    End Sub
End Class
