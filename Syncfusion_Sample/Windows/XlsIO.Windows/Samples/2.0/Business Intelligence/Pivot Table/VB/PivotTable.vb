Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.XlsIO

Public Class PivotTable

#Region "Constants"
    Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\{0}"
#End Region

#Region "Creating Pivot Table"
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
        'The instantiation process consists of two steps.

        'Step 1 : Instantiate the spreadsheet creation engine.
        Dim excelEngine As New ExcelEngine()
        'Step 2 : Instantiate the excel application object.
        Dim application As IApplication = excelEngine.Excel

        'Set the default version as Excel 2007;

        If Me.rdbExcel2007.Checked Then
            application.DefaultVersion = ExcelVersion.Excel2007
        End If

        'Set the default version as Excel 2010;
        If Me.rdbExcel2010.Checked Then
            application.DefaultVersion = ExcelVersion.Excel2010
        End If
        'Set the default version as Excel 2013;
        If Me.rdbExcel2013.Checked Then
            application.DefaultVersion = ExcelVersion.Excel2013
        End If

        'Get the Path of the input file
        Dim inputPath As String = GetFullTemplatePath("PivotCodeDate.xlsx")
        Dim workbook As IWorkbook = application.Workbooks.Open(inputPath)

        ' The first worksheet object in the worksheets collection is accessed.
        Dim worksheet As IWorksheet = workbook.Worksheets(0)
        'Access the sheet to draw pivot table.
        Dim pivotSheet As IWorksheet = workbook.Worksheets(1)
        pivotSheet.Activate()

        'Select the data to add in cache
        Dim cache As IPivotCache = workbook.PivotCaches.Add(worksheet("A1:H50"))

        'Insert the pivot table.
        Dim pivotTable As IPivotTable = pivotSheet.PivotTables.Add("PivotTable1", pivotSheet("A1"), cache)
        pivotTable.Fields(4).Axis = PivotAxisTypes.Page

        pivotTable.Fields(2).Axis = PivotAxisTypes.Row
        pivotTable.Fields(6).Axis = PivotAxisTypes.Row
        pivotTable.Fields(3).Axis = PivotAxisTypes.Column

        Dim field As IPivotField = pivotSheet.PivotTables(0).Fields(5)
        pivotTable.DataFields.Add(field, "Sum of Units", PivotSubtotalTypes.Sum)
#If Not SyncfusionFramework2_0 Then

        If ckbRowFilter.Checked Then
            If rdbRCLabelFilter.Checked Then
                pivotTable.Fields(2).PivotFilters.Add(PivotFilterType.CaptionEqual, Nothing, "East", Nothing)
            ElseIf rdbRCValueFilter.Checked Then
                pivotTable.Fields(2).PivotFilters.Add(PivotFilterType.ValueEqual, field, "1341", Nothing)
            Else
                pivotTable.Fields(2).Items(0).Visible = False
                pivotTable.Fields(2).Items(1).Visible = False
            End If
        End If



        If ckbColumnFilter.Checked Then
            If rdbRCLabelFilter.Checked Then
                pivotTable.Fields(3).PivotFilters.Add(PivotFilterType.CaptionNotEqual, Nothing, "Jones", Nothing)
            ElseIf rdbRCValueFilter.Checked Then
                pivotTable.Fields(3).PivotFilters.Add(PivotFilterType.ValueEqual, field, "398", Nothing)
            Else
                pivotTable.Fields(3).Items(0).Visible = False
                pivotTable.Fields(3).Items(1).Visible = False
            End If
        End If

        If ckbPageFilter.Checked Then
            'Create Pivot Filter object to apply filter to page Fields
            Dim filterValue As IPivotFilter = pivotTable.Fields(4).PivotFilters.Add()
            'Page Field would be filtered with value 'Binder'
            filterValue.Value1 = "Binder"
            'XlsIO layout the Pivot table like MS Excel
            pivotTable.Layout()
        ElseIf ckbMultiplePageFilter.Checked Then
            pivotTable.Fields(4).Items(1).Visible = False
            pivotTable.Fields(4).Items(2).Visible = False
            If Not rdbRCValueFilter.Checked Then
                pivotTable.Layout()
            End If
        End If
#End If
        'Apply built in style.
        pivotTable.BuiltInStyle = PivotBuiltInStyles.PivotStyleMedium2

        'Activate the pivot sheet.
        pivotSheet.Activate()

        'Saving the workbook to disk.
        workbook.SaveAs("CreatedPivotTable.xlsx")

        'Close the workbook.
        workbook.Close()

        'No exception will be thrown if there are unsaved workbooks.
        excelEngine.ThrowNotSavedOnDestroy = False
        excelEngine.Dispose()

        'Message box confirmation to view the created spreadsheet.
        If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Try
                'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("CreatedPivotTable.xlsx")
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

#Region "Customizing Pivot Table"
    Private Sub btnCustomize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomize.Click
        'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
        'The instantiation process consists of two steps.

        'Step 1 : Instantiate the spreadsheet creation engine.
        Dim excelEngine As New ExcelEngine()
        'Step 2 : Instantiate the excel application object.
        Dim application As IApplication = excelEngine.Excel

        'Set the default version as Excel 2007 

        If Me.rdbExcel2007.Checked Then
            application.DefaultVersion = ExcelVersion.Excel2007
        End If

        'Set the default version as Excel 2010 
        If Me.rdbExcel2010.Checked Then
            application.DefaultVersion = ExcelVersion.Excel2010
        End If

        'Set the default version as Excel 2013
        If Me.rdbExcel2013.Checked Then
            application.DefaultVersion = ExcelVersion.Excel2013
        End If

        'Get the Path of the input file
        Dim inputPath As String = GetFullTemplatePath("PivotTable.xlsx")
        Dim workbook As IWorkbook = application.Workbooks.Open(inputPath)

        'Access the sheet to draw pivot table.
        Dim pivotSheet As IWorksheet = workbook.Worksheets(1)
        'Access the collection of Pivot Table in the worksheet.
        Dim pivotTables As IPivotTables = pivotSheet.PivotTables

        'Access the Single pivot table from the collection.
        Dim pivotTable As IPivotTable = pivotTables(0)

        'Access collection of pivot fields from the pivot table.
        Dim fields As IPivotFields = pivotTable.Fields

        'Access a Pivot field from the collection.
        Dim field As IPivotField = fields(2)
        'Add the field to page axis
        field.Axis = PivotAxisTypes.Page

        fields(1).Axis = PivotAxisTypes.None
        fields(0).Axis = PivotAxisTypes.None
        fields(3).Axis = PivotAxisTypes.Row
        fields(4).Axis = PivotAxisTypes.Column
        Dim dataField As IPivotField = fields(5)

        'Accessing the Calculated fields from the pivot table .
        Dim calculatedfields As IPivotCalculatedFields = pivotTable.CalculatedFields

        'Adding Calculatd field to the pivot table.
        'Dim calculatedField As IPivotField = calculatedfields.Add("Percent", "Units/3000*100")
#If Not SyncfusionFramework2_0 Then
        If (ckbRowFilter.Checked) Then
            If rdbRCLabelFilter.Checked Then
                pivotTable.Fields(3).PivotFilters.Add(PivotFilterType.CaptionNotEqual, Nothing, "Parent", Nothing)
            ElseIf rdbRCValueFilter.Checked Then
                pivotTable.Fields(3).PivotFilters.Add(PivotFilterType.ValueGreaterThan, dataField, "100", Nothing)
            Else
                pivotTable.Fields(3).Items(0).Visible = False
            End If
        End If
        If ckbColumnFilter.Checked Then
            If rdbRCLabelFilter.Checked Then
                pivotTable.Fields(4).PivotFilters.Add(PivotFilterType.CaptionNotEqual, Nothing, "Binder", Nothing)
            ElseIf rdbRCValueFilter.Checked Then
                pivotTable.Fields(4).PivotFilters.Add(PivotFilterType.ValueGreaterThan, dataField, "100", Nothing)
            Else
                pivotTable.Fields(4).Items(0).Visible = False

            End If
        End If
       If ckbPageFilter.Checked Then

            'Create Pivot Filter object to apply filter to page Fields
            Dim filterValue As IPivotFilter = pivotTable.Fields(2).PivotFilters.Add()
            'Page Field would be filtered with value 'East'
            filterValue.Value1 = "East"
            'XlsIO layout the Pivot table like MS Excel
            pivotTable.Layout()
        ElseIf ckbMultiplePageFilter.Checked Then
            pivotTable.Fields(2).Items(0).Visible = False
        End If
#End If

        'Saving the workbook to disk.
        workbook.SaveAs("CustomizedPivotTable.xlsx")

        'Close the workbook.
        workbook.Close()

        'No exception will be thrown if there are unsaved workbooks.
        excelEngine.ThrowNotSavedOnDestroy = False
        excelEngine.Dispose()

        'Message box confirmation to view the created spreadsheet.
        If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Try
                'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("CustomizedPivotTable.xlsx")
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


    Private Sub ckbPageFilter_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbPageFilter.CheckedChanged
        If ckbPageFilter.Checked Then
            ckbMultiplePageFilter.Checked = False
        End If
    End Sub

    Private Sub PivotTable_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        rdbRCLabelFilter.Checked = True
        rdbRCLabelFilter.Enabled = False
        rdbRCMultileFilter.Enabled = False
        rdbRCValueFilter.Enabled = False
        rdbExcel2013.Checked = True
    End Sub

    Private Sub ckbMultiplePageFilter_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbMultiplePageFilter.CheckedChanged
        If ckbMultiplePageFilter.Checked Then
            ckbPageFilter.Checked = False
        End If
    End Sub

    Private Sub ckbRowFilter_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbRowFilter.CheckedChanged
        If ckbRowFilter.Checked Then
            rdbRCLabelFilter.Enabled = True
            rdbRCValueFilter.Enabled = True
            rdbRCMultileFilter.Enabled = True
        ElseIf Not (ckbRowFilter.Checked) Then
            If Not (ckbColumnFilter.Checked) Then
                rdbRCLabelFilter.Enabled = False
                rdbRCValueFilter.Enabled = False
                rdbRCMultileFilter.Enabled = False
            End If
        End If
    End Sub

    Private Sub ckbColumnFilter_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ckbColumnFilter.CheckedChanged
        If ckbColumnFilter.Checked Then
            rdbRCLabelFilter.Enabled = True
            rdbRCValueFilter.Enabled = True
            rdbRCMultileFilter.Enabled = True
        ElseIf Not (ckbColumnFilter.Checked) Then
            If Not (ckbRowFilter.Checked) Then
                rdbRCLabelFilter.Enabled = False
                rdbRCValueFilter.Enabled = False
                rdbRCMultileFilter.Enabled = False
            End If
        End If
    End Sub
End Class
