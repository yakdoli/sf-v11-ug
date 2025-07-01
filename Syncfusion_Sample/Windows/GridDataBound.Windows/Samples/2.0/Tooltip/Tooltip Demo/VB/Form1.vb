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

Namespace TooltipDemo_2005
	Partial Public Class Form1
		Inherits Form
		Private ds As DataSet
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

			AddHandler gridDataBoundGrid1.Model.QueryCellInfo, AddressOf Model_QueryCellInfo
			Me.gridDataBoundGrid1.CellToolTip.AutoPopDelay = 2000
		End Sub

		Private Sub Model_QueryCellInfo(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
            If e.ColIndex > 0 AndAlso e.RowIndex > Me.gridDataBoundGrid1.Model.Rows.HeaderCount Then
                e.Style.CellTipText = e.Style.Text
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