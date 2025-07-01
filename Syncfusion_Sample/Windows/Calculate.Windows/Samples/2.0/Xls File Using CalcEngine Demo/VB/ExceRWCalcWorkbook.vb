#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.IO
Imports System.Collections
Imports System.Runtime.Serialization

Imports Syncfusion.Calculate
Imports Syncfusion.XlsIO


Namespace XlsFileUsingExcelRW
    '/ <summary>
    '/ A CalcWorkbook-derived object that uses ExcelRW to read / compute Excel XLS files.
    '/ </summary>

    Public Class ExceRWCalcWorkbook
        Inherits CalcWorkbook
        '/ <summary>
        '/ The ExcelRW IWorkbook used by this class.
        '/ </summary>
        Public excelRWWB As IWorkbook


        '/ <summary>
        '/ constructor
        '/ </summary>
        '/ <param name="calcSheets">Array of ExcelRWCalcSheet objects used in this workbook.</param>
        '/ <param name="namedRanges">A hashtable containing named ranges</param>
        Public Sub New(ByVal calcSheets() As ExcelRWCalcSheet, ByVal namedRanges As Hashtable)
            MyBase.New(calcSheets, namedRanges)
        End Sub 'New



        '/ <summary>
        '/ Creates a ExceRWCalcWorkbook object from an XLS file.
        '/ </summary>
        '/ <param name="fileName">Complete pathname of the XLS file.</param>
        '/ <returns></returns>
        Public Shared Function CreateFromXLS(ByVal fileName As String) As ExceRWCalcWorkbook
            Dim wb As IWorkbook
            Try
                wb = ExcelUtils.Open(fileName)
                ExcelUtils.ThrowNotSavedOnDestroy = False
            Catch
                Throw New FileLoadException("XlsIO cannot load the file.", fileName)
            End Try

            Dim sheets(wb.Worksheets.Count - 1) As ExcelRWCalcSheet

            Dim i As Integer = 0

            While i < wb.Worksheets.Count
                sheets(i) = New ExcelRWCalcSheet(wb.Worksheets(i))
                sheets(i).Name = wb.Worksheets(i).Name
                i += 1
            End While


            Dim ranges As New Hashtable()
            Dim name As IName
            For Each name In wb.Names
                ranges.Add(name.Name.ToUpper(), name.Value.Replace("'", ""))

            Next name

            Dim cwb As New ExceRWCalcWorkbook(sheets, ranges)
            cwb.excelRWWB = wb
            Return cwb
        End Function 'CreateFromXLS


        '/ <summary>
        '/ Performs all calculations in the workbook.
        '/ </summary>
        Public Overrides Sub CalculateAll()
            Dim sheet As ExcelRWCalcSheet
            For Each sheet In Me.CalcSheetList
                sheet.CalculationsSuspended = False
            Next sheet

            Dim start As DateTime = DateTime.Now
            Dim loopStart As DateTime = DateTime.Now

            For Each sheet In Me.CalcSheetList
                'this.listBox1.Items.Add(string.Format("{0} {1}x{2}", sheet.Name, sheet.RowCount, sheet.ColCount));
                Dim row As Integer = 1
                sheet.Engine.UpdateCalcID()
                While row <= sheet.RowCount
                    Dim col As Integer = 1

                    While col <= sheet.ColCount
                        Dim o As Object = sheet.GetValueRowCol(row, col)
                        If Not (o Is Nothing) Then
                            Dim s2 As String = o.ToString()
                            If s2.Length > 0 AndAlso s2.Chars(0) = "="c Then
                                sheet(row, col) = s2
                            End If
                        End If
                        col += 1
                    End While
                    row += 1
                End While

                'Console.WriteLine(string.Format("{0}  {2}  parsed {1}",  DateTime.Now - start , sheet.Name, DateTime.Now - loopStart));
                loopStart = DateTime.Now
            Next sheet 'this.label5.Text = string.Format("Sheets {0}", loop++);
        End Sub 'CalculateAll 'Application.DoEvents();

        Default Public Shadows Property Item(ByVal name As String) As Object
            Get
                Return CType(MyBase.Item(name), ExcelRWCalcSheet)
            End Get
            Set(ByVal Value As Object)
                MyBase.Item(name) = Value
            End Set
        End Property
    End Class 'ExceRWCalcWorkbook

    '/ <summary>
    '/ Specially derived CalcSheet for use with ExcelRW.
    '/ </summary>

    Public Class ExcelRWCalcSheet
        Inherits CalcSheet

        Private excelSheet As IWorksheet


        '/ <summary>
        '/ Constructor
        '/ </summary>
        Public Sub New()
            excelSheet = Nothing
        End Sub 'New


        '/ <summary>
        '/ Constuctor
        '/ </summary>
        '/ <param name="sheet">Underlying ExcelRw IWorksheet object.</param>
        Public Sub New(ByVal sheet As IWorksheet)
            excelSheet = sheet
        End Sub 'New


        '/ <summary>
        '/ Sets a value into the ExcelRW worksheet.
        '/ </summary>
        '/ <param name="rowPos">The row index of the changed value.</param>
        '/ <param name="colPos">The column index of the changed value.</param>
        '/ <param name="val">The new value.</param>
        '/ <remarks>
        '/ If CalculationsSuspended is not True, a ValueChanged event is raised.
        '/ </remarks>
        Public Overrides Sub SetValue(ByVal rowPos As Integer, ByVal colPos As Integer, ByVal val As String)

            SetValueRowCol(val, rowPos, colPos)
            If CalculationsSuspended Then
                Return
            End If
            Dim e1 As New ValueChangedEventArgs(rowPos, colPos, val)
            MyBase.OnValueChanged(e1)

        End Sub 'SetValue 
        '/ <summary>
        '/ Number of rows in this spreadsheet.
        '/ </summary>

        Public Shadows ReadOnly Property RowCount() As Integer
            Get
                Return Me.excelSheet.UsedRange.Rows.GetLength(0)
            End Get
        End Property
        '/ <summary>
        '/ The number of columns in this spreadsheet.
        '/ </summary>

        Public Shadows ReadOnly Property ColCount() As Integer
            Get
                Return Me.excelSheet.UsedRange.Columns.GetLength(0)
            End Get
        End Property
#Region "ICalcData Members"


        '/ <summary>
        '/ Returns the value at the specified row and column.
        '/ </summary>
        '/ <param name="row">Row index (one-based).</param>
        '/ <param name="col">Column index (one-based).</param>
        '/ <returns>The value at the specified row and column.</returns>
        Public Overrides Function GetValueRowCol(ByVal row As Integer, ByVal col As Integer) As Object
            Dim o As Object = excelSheet(row, col).Formula
            If o Is Nothing Then
                o = excelSheet(row, col).Value
            End If
            If Not (o Is Nothing) Then
                Return o.ToString()'.Replace("'", "")  Keep the tic - request #541 
            End If
            Return o
        End Function 'GetValueRowCol


        'Public Shadows Function GetValueRowCol(ByVal row As Integer, ByVal col As Integer) As Object
        '    Return OnGetValueRowCol(row, col)
        'End Function 'GetValueRowCol

        '/ <summary>
        '/ Set the value at a specified row and column.
        '/ </summary>
        '/ <param name="value">The value to be set.</param>
        '/ <param name="rowPos">The row index (one-based).</param>
        '/ <param name="colPos">The column index (one-based).</param>
        Public Overrides Sub SetValueRowCol(ByVal value As Object, ByVal rowPos As Integer, ByVal colPos As Integer)
            excelSheet(rowPos, colPos).Value = value.ToString()
        End Sub 'SetValueRowCol

        '/ <summary>
        '/ Event raised when a value changes provided CalculationsSuspended = False.
        '/ </summary>

        'Default Public Property Item(ByVal row As Integer, ByVal col As Integer) As Object
        '    Get

        '        Return Me.GetValueRowCol(row, col)
        '    End Get
        '    Set(ByVal Value As Object)
        '        Me.SetValue(row - 1, col - 1, Value.ToString())
        '    End Set
        'End Property


        'Public Event ValueChanged As Syncfusion.Calculate.ValueChangedEventHandler

#End Region


    End Class 'ExcelRWCalcSheet
End Namespace 'XlsFileUsingExcelRW 