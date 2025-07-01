#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports Syncfusion.GridHelperClasses
Imports Syncfusion.Windows.Forms

Namespace PrintGroupingGrid
	Partial Public Class Form1
		Inherits MetroForm
		Public Sub New()
'			#Region "Intialization Settings"
			InitializeComponent()

			Try
				Dim ico As New Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
			Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
			InitializeGrid()
'			#End Region
		End Sub

		#Region "Icon and Xml"
		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

		Private Function ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String) As Boolean
			' Check both in parent folder and Parent\Data folders.
			Dim xmlDataFileName As String = "Common\Data\" & xmlFileName
			For n As Integer = 0 To 9
				If System.IO.File.Exists(xmlFileName) Then
					ds.ReadXml(xmlFileName)
					Return True
				End If
				If System.IO.File.Exists(xmlDataFileName) Then
					ds.ReadXml(xmlDataFileName)
					Return True
				End If
				xmlFileName = "..\" & xmlFileName
				xmlDataFileName = "..\" & xmlDataFileName
			Next n

			Return False
		End Function
		#End Region

		#Region "Print Function Handlers"
		Private Sub InitializeGrid()
			'Load Data  
			Dim xmlName As String = "Orders.xml"

			Dim orderDataSet As New DataSet()

			If Me.ReadXml(orderDataSet, xmlName) Then
				Dim orderTable As DataTable = orderDataSet.Tables(0)
				Dim recordCount As Integer = orderTable.Rows.Count

				'Load only 150 records
				For row As Integer = 0 To recordCount - 150 - 1
					orderTable.Rows.RemoveAt(0)
				Next row

				Me.gridGroupingControl1.DataSource = orderTable
			End If

			For col As Integer = 3 To 5
				'DateTime columns
				Me.gridGroupingControl1.TableDescriptor.Columns(col).Appearance.AnyRecordFieldCell.CellValueType = GetType(DateTime)
				Me.gridGroupingControl1.TableDescriptor.Columns(col).Appearance.AnyRecordFieldCell.Format = "mm/dd/yyyy"

				'Remove some columns
				Me.gridGroupingControl1.TableDescriptor.VisibleColumns.RemoveAt(10)
			Next col

			'GGC options
			Me.gridGroupingControl1.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.ThemesEnabled = True
		End Sub

		#Region "Event Handlers"
		Private Sub pd_DrawGridPrintHeader(ByVal sender As Object, ByVal e As Syncfusion.GridHelperClasses.GridPrintHeaderFooterTemplateArgs)
			' Get the rectangle area to draw
			Dim header As Rectangle = e.DrawRectangle

			'IMAGE
			'scale the image
			Dim imageSize As New SizeF(header.Width \ 3, header.Height * 0.8f)
			'Locating the logo on the right corner of the Drawing Surface
			Dim imageLocation As New PointF(e.DrawRectangle.Width - imageSize.Width - 20, header.Y + 5)
			Dim img As New Bitmap("..\..\Data\logo.png")
			'Draw the image in the Header.
			e.Graphics.DrawImage(img, New RectangleF(imageLocation, imageSize))

			'TITLE
			Dim activeColor As Color = Color.FromArgb(44, 71, 120)
			Dim brush As New SolidBrush(activeColor)
			Dim font As New Font("Helvetica", 20, FontStyle.Bold)
			'Set formattings for the text
			Dim format As New StringFormat()
			format.Alignment = StringAlignment.Near
			format.LineAlignment = StringAlignment.Near
			'Draw the title
			e.Graphics.DrawString("Customers Order Report", font, brush, New RectangleF(header.Location.X + 20, header.Location.Y + 20, e.DrawRectangle.Width, e.DrawRectangle.Height), format)

			'''BORDER LINES - Draw some lines in the header
			Dim pen As New Pen(Color.DarkBlue, 0.8f)
			e.Graphics.DrawLine(pen, New Point(header.Left, header.Top + 2), New Point(header.Right, header.Top + 2))
			e.Graphics.DrawLine(pen, New Point(header.Left, header.Top + 5), New Point(header.Right, header.Top + 5))
			e.Graphics.DrawLine(pen, New Point(header.Left, header.Bottom - 8), New Point(header.Right, header.Bottom - 8))
			e.Graphics.DrawLine(pen, New Point(header.Left, header.Bottom - 5), New Point(header.Right, header.Bottom - 5))

			'Dispose drawing resources
			font.Dispose()
			format.Dispose()
			pen.Dispose()
		End Sub

		Private Sub pd_DrawGridPrintFooter(ByVal sender As Object, ByVal e As Syncfusion.GridHelperClasses.GridPrintHeaderFooterTemplateArgs)
			'Get the rectangle area to draw
			Dim footer As Rectangle = e.DrawRectangle

			'Draw copy right
			Dim format As New StringFormat()
			format.LineAlignment = StringAlignment.Center
			format.Alignment = StringAlignment.Center
			Dim font As New Font("Helvetica", 8)
			Dim brush As New SolidBrush(Color.Red)
			e.Graphics.DrawString("@copyright", font, brush, GridUtil.CenterPoint(footer), format)

			'Draw page number
			format.LineAlignment = StringAlignment.Far
			format.Alignment = StringAlignment.Far
			e.Graphics.DrawString(String.Format("page {0} of {1}", e.PageNumber, e.PageCount), font, brush, New Point(footer.Right - 100, footer.Bottom - 20), format)

			'Dispose resources
			format.Dispose()
			font.Dispose()
			brush.Dispose()
		End Sub

		Private Sub PrintPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PrintPreview.Click
			Try
				Me.gridGroupingControl1.TableModel.Properties.PrintFrame = False

				Dim pd As New Syncfusion.GridHelperClasses.GridPrintDocumentAdv(Me.gridGroupingControl1.TableControl)
				pd.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)

				'Set header and footer height
				If Me.ShowHeaderFooter.Checked Then
					pd.HeaderHeight = 70
					pd.FooterHeight = 50
				Else
					pd.HeaderHeight = 0
					pd.HeaderHeight = 0
				End If

				'Whether scale columns to fit
				pd.ScaleColumnsToFitPage = Me.ScaleColumnsToFit.Checked

				'Handle the events to draw the header / footer
				AddHandler pd.DrawGridPrintHeader, AddressOf pd_DrawGridPrintHeader
				AddHandler pd.DrawGridPrintFooter, AddressOf pd_DrawGridPrintFooter

				Dim previewDialog As New PrintPreviewDialog()
				previewDialog.Document = pd
				previewDialog.Show()
			Catch ex As Exception
				MessageBox.Show("Error while print preview" & ex.ToString())
			End Try
		End Sub
		#End Region



		#End Region
	End Class
End Namespace