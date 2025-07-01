#Region "Copyright Syncfusion Inc. 2001 - 2010"
'
'  Copyright Syncfusion Inc. 2001 - 2010. All rights reserved.
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
	Public Class XlsIOCalcWorkbook
		Inherits CalcWorkbook
		'/ <summary>
		'/ The ExcelRW IWorkbook used by this class.
		'/ </summary>
		Public excelRWWB As IWorkbook

		'/ <summary>
		'/ Constructor
		'/ </summary>
		'/ <param name="calcSheets">Array of ExcelRWCalcSheet objects used in this workbook.</param>
		'/ <param name="namedRanges">A hashtable containing named ranges.</param>
		Public Sub New(ByVal calcSheets() As XlsIOCalcSheet, ByVal namedRanges As Hashtable)
			MyBase.New(calcSheets, namedRanges)

		End Sub

		'/ <summary>
		'/ Creates a ExceRWCalcWorkbook object from an XLS file.
		'/ </summary>
		'/ <param name="fileName">Complete pathname of the XLS file.</param>
		'/ <returns></returns>
		Public Shared Function CreateFromXLS(ByVal fileName As String) As XlsIOCalcWorkbook
			Dim wb As IWorkbook
			Try
				wb = ExcelUtils.Open(fileName)
				ExcelUtils.ThrowNotSavedOnDestroy = False
			Catch
				Throw New FileLoadException("XlsIO cannot load the file.", fileName)
			End Try

			Dim sheets(wb.Worksheets.Count - 1) As XlsIOCalcSheet
			Dim nameList As String = "!"

			For i As Integer = 0 To wb.Worksheets.Count - 1
				sheets(i) = New XlsIOCalcSheet(wb.Worksheets(i))
				sheets(i).Name = wb.Worksheets(i).Name
				nameList &= sheets(i).Name & "!"

			Next i

			Dim ranges As New Hashtable()
			For Each name As IName In wb.Names
				If name.Scope.Length > 0 AndAlso nameList.IndexOf("!" & name.Scope & "!") > -1 Then
					ranges.Add((name.Scope & "!" & name.Name).ToUpper(), name.Value.Replace("'", ""))
				Else
					ranges.Add(name.Name.ToUpper(), name.Value.Replace("'", ""))
				End If

				'{
				'    if (!ranges.ContainsKey(name.Name.ToUpper()))
				'    ranges.Add(name.Name.ToUpper(), name.Value.Replace("'", ""));
				'}
			Next name

			Dim cwb As New XlsIOCalcWorkbook(sheets, ranges)
			cwb.excelRWWB = wb
			Return cwb
		End Function

		'/ <summary>
		'/ Performs all calculations in the workbook.
		'/ </summary>
		Public Overrides Sub CalculateAll()
			For Each sheet As CalcSheet In Me.CalcSheetList
				sheet.CalculationsSuspended = False
			Next sheet


			For Each sheet As XlsIOCalcSheet In Me.CalcSheetList
				sheet.Engine.UpdateCalcID()
				For row As Integer = 1 To sheet.RowCount
					For col As Integer = 1 To sheet.ColCount
						Dim o As Object = sheet(row, col)
						If o IsNot Nothing Then
							Dim s2 As String = o.ToString()
							If s2.Length > 0 AndAlso s2.Chars(0) = "="c Then
								sheet(row, col) = s2
							End If
						End If
					Next col

				Next row

			Next sheet
		End Sub
	End Class

	'/ <summary>
	'/ Specially derived CalcSheet for use with ExcelRW.
	'/ </summary>
	Public Class XlsIOCalcSheet
		Inherits CalcSheet
		Private excelSheet As IWorksheet

		'/ <summary>
		'/ Constructor
		'/ </summary>
		Public Sub New()
			excelSheet = Nothing
		End Sub

		'/ <summary>
		'/ Constuctor
		'/ </summary>
		'/ <param name="sheet">Underlying ExcelRw IWorksheet object.</param>
		Public Sub New(ByVal sheet As IWorksheet)
			excelSheet = sheet
		End Sub

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
		End Sub

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
			If o IsNot Nothing Then
				Return o.ToString() '.Replace("'", ""); keep the tic defect#541
			End If
			Return o
		End Function

		'/ <summary>
		'/ Set the value at a specified row and column.
		'/ </summary>
		'/ <param name="value">The value to be set.</param>
		'/ <param name="rowPos">The row index (one-based).</param>
		'/ <param name="colPos">The column index (one-based).</param>
		Public Overrides Sub SetValueRowCol(ByVal value As Object, ByVal row As Integer, ByVal col As Integer)

			excelSheet(row, col).Value = value.ToString()
		End Sub
	End Class

End Namespace