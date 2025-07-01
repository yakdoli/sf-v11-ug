Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports System.IO
Imports System.Collections

Namespace TooltipDemo_2005
	Partial Public Class Form1
		Inherits Form
		Private ds As DataSet
		Private comments As ArrayList
		Private commentMouseController1 As ExcelTip.CommentMouseController
		Public Sub New()
            InitializeComponent()
            Try
                Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid1.ico"))
                Me.Icon = ico
            Catch ex As Exception
            End Try
            Me.gridDataBoundGrid1.DefaultRowHeight = 18
			Me.gridDataBoundGrid1.DefaultColWidth = 70

			ds = New DataSet()
            ReadXml(ds, "\common\Data\GDBDdata.XML")
			Me.gridDataBoundGrid1.DataSource = ds.Tables("customers")
			Me.gridDataBoundGrid1.Model.ColWidths.ResizeToFit(GridRangeInfo.Row(0), GridResizeToFitOptions.NoShrinkSize)
			Me.gridDataBoundGrid1.Model.EnableLegacyStyle = False
			Me.gridDataBoundGrid1.ColorStyles = Syncfusion.Windows.Forms.ColorStyles.Office2010Blue
			Me.StartPosition = FormStartPosition.CenterScreen

			'create the Comment mousecontroller.
			Me.commentMouseController1 = New ExcelTip.CommentMouseController(Me.gridDataBoundGrid1)
			'allow context menu to edit/add comments
			Me.commentMouseController1.ContextMenuEnabled = True
			'register the controller
			Me.gridDataBoundGrid1.MouseControllerDispatcher.Add(commentMouseController1)

			'set the comment using custom style property, ExcelTipText
			Dim style As New ExcelTip.GridExcelTipStyleProperties(Me.gridDataBoundGrid1(2, 2))
			style.ExcelTipText = "Comment for cell 2,2."

			' Maintain an Arraylist to store the comments
			comments = New ArrayList()
			For i As Integer = 0 To Me.gridDataBoundGrid1.Model.RowCount
				Me.comments.Add(Nothing)
			Next i
            comments(1) = style.ExcelTipText ' Sample comment
			' Events
			AddHandler gridDataBoundGrid1.Model.SaveCellInfo, AddressOf Model_SaveCellInfo
			AddHandler gridDataBoundGrid1.Model.QueryCellInfo, AddressOf Model_QueryCellInfo
		End Sub

		Private Sub Model_QueryCellInfo(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
			If e.RowIndex > 0 AndAlso e.ColIndex = 2 Then
				Dim style As New ExcelTip.GridExcelTipStyleProperties(e.Style)
				style.ExcelTipText = CStr(Me.comments(e.RowIndex - 1))
				e.Handled = True
			End If
		End Sub

		Private Sub Model_SaveCellInfo(ByVal sender As Object, ByVal e As GridSaveCellInfoEventArgs)
			If e.RowIndex > 0 AndAlso e.ColIndex = 2 Then
				Dim style As New ExcelTip.GridExcelTipStyleProperties(e.Style)
				Me.comments(e.RowIndex - 1) = style.ExcelTipText
				e.Handled = True
			End If
		End Sub

		Private Sub ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String)
			For n As Integer = 0 To 9
				If System.IO.File.Exists(xmlFileName) Then
					ds.ReadXml(xmlFileName)
					Exit For
				End If
				xmlFileName = "..\" & xmlFileName
			Next n
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
	End Class
End Namespace