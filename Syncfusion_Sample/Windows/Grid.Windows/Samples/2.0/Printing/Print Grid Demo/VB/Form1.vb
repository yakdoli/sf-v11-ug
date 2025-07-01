Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.GridHelperClasses
Imports System.IO

Namespace PrintGrid_2008
    Partial Class Form1 : Inherits Syncfusion.Windows.Forms.MetroForm
        Public Sub New()
            InitializeComponent()

             Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
			
            AddHandler Me.button1.Click, AddressOf button1_Click_1

            InitializeGrid()
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

        Private Sub InitializeGrid()
            'Load Data  
            Dim xmlName As String = GetFile("Orders.xml")

            Dim orderDataSet As DataSet = New DataSet()

            If Me.ReadXml(orderDataSet, xmlName) Then
                Dim orderTable As DataTable = orderDataSet.Tables(0)
                Me.gridControl1.RowCount = 100
                Me.gridControl1.ColCount = orderTable.Columns.Count

                Me.gridControl1.PopulateValues(GridRangeInfo.Cells(1, 1, Me.gridControl1.RowCount, Me.gridControl1.ColCount), orderDataSet.Tables(0))
                Me.gridControl1.PopulateHeaders(GridRangeInfo.Cells(0, 1, 0, Me.gridControl1.ColCount), orderTable)
            End If

            For col As Integer = 4 To 6
                Me.gridControl1.ColStyles(col).CellType = "MonthCalendar"
                Me.gridControl1.ColStyles(col).ShowButtons = GridShowButtons.Hide
                Me.gridControl1.ColStyles(col).CellValueType = GetType(DateTime)
                Me.gridControl1.ColStyles(col).Format = "MM/dd/yyyy"
            Next col

            'Set grid appearance
            Me.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Table())
            Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridControl1.ThemesEnabled = True
            Me.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid

        End Sub

        Private Function ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String) As Boolean
            ' Check both in parent folder and Parent\Data folders.
            Dim xmlDataFileName As String = "Common\Data\Grid" & xmlFileName
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

        Private Function GetFile(ByVal fileName As String) As String
            Dim dataFileName As String = "Common\Data\Grid\" & fileName
            For n As Integer = 0 To 11
                If System.IO.File.Exists(dataFileName) Then
                    Return New FileInfo(dataFileName).FullName
                End If
                dataFileName = "..\" & dataFileName
            Next n
            Return dataFileName
        End Function

        Private Sub pd_DrawGridPrintHeader(ByVal sender As Object, ByVal e As Syncfusion.GridHelperClasses.GridPrintHeaderFooterTemplateArgs)
            ' Get the rectangle area to draw
            Dim header As Rectangle = e.DrawRectangle

            'IMAGE
            'scale the image
            Dim imageSize As SizeF = New SizeF(header.Width / 3, header.Height * 0.8F)
            'Locating the logo on the right corner of the Drawing Surface
            Dim imageLocation As PointF = New PointF(e.DrawRectangle.Width - imageSize.Width - 20, header.Y + 5)
            Dim img As Bitmap = New Bitmap(GetIconFile("Common\Images\Grid\PDF_logo\logo.png"))
            'Draw the image in the Header.
            e.Graphics.DrawImage(img, New RectangleF(imageLocation, imageSize))

            'TITLE
            Dim activeColor As Color = Color.FromArgb(44, 71, 120)
            Dim brush As SolidBrush = New SolidBrush(activeColor)
            Dim font As Font = New Font("Segoe UI", 20, FontStyle.Bold)
            'Set formattings for the text
            Dim format As StringFormat = New StringFormat()
            format.Alignment = StringAlignment.Near
            format.LineAlignment = StringAlignment.Near
            'Draw the title
            e.Graphics.DrawString("Customers Order Report", font, brush, New RectangleF(header.Location.X + 20, header.Location.Y + 20, e.DrawRectangle.Width, e.DrawRectangle.Height), format)

            '''BORDER LINES - Draw some lines in the header
            Dim pen As Pen = New Pen(Color.DarkBlue, 0.8F)
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
            Dim format As StringFormat = New StringFormat()
            format.LineAlignment = StringAlignment.Center
            format.Alignment = StringAlignment.Center
            Dim font As Font = New Font("Segoe UI", 8)
            Dim brush As SolidBrush = New SolidBrush(Color.Red)
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

        Private Sub button1_Click_1(ByVal sender As Object, ByVal e As EventArgs)
            Try

                Me.gridControl1.Model.Properties.PrintFrame = False

                Dim pd As Syncfusion.GridHelperClasses.GridPrintDocumentAdv = New Syncfusion.GridHelperClasses.GridPrintDocumentAdv(Me.gridControl1)
                pd.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)

                If Me.ShowHeaderFooter.Checked Then
                    pd.HeaderHeight = 70
                    pd.FooterHeight = 50
                Else
                    pd.HeaderHeight = 0
                    pd.HeaderHeight = 0
                End If

                pd.ScaleColumnsToFitPage = Me.ScaleColumnsToFit.Checked

                AddHandler pd.DrawGridPrintHeader, AddressOf pd_DrawGridPrintHeader
                AddHandler pd.DrawGridPrintFooter, AddressOf pd_DrawGridPrintFooter

                Dim previewDialog As PrintPreviewDialog = New PrintPreviewDialog()
                previewDialog.Document = pd
                previewDialog.Show()
            Catch ex As Exception
                MessageBox.Show("Error while print preview" & ex.ToString())
            End Try
        End Sub

        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace
