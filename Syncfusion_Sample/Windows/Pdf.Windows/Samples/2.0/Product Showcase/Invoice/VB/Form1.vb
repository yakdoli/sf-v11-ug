#Region "Copyright Syncfusion Inc. 2001 - 2007"
'
'  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Re-distribution in any form is strictly
'  prohibited. Any infringement will be prosecuted under applicable laws. 
'
#End Region


Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlServerCe

Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Graphics
Imports Syncfusion.Pdf.Grid

Namespace EssentialPDFSamples
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1 : Inherits System.Windows.Forms.Form
#Region "Private methods"
        Private WithEvents button1 As System.Windows.Forms.Button
        Private label1 As System.Windows.Forms.Label
        Private lstCustomerId As ListBox
        Private label2 As Label
        Private groupBox1 As GroupBox
        Private dataPath As String = Nothing
        Private connString As String = Nothing
        Private orderDS As DataSet = Nothing
        Private dataSet As DataSet = Nothing
        Private y, shipName, address, shipCity, shipCountry, shippedDate As String
        Private x As Double, total As Double = 0, ftotal As Double = 0, freight As Double
        Private k As Integer = 0
        Private DEF_DB_COMMAND2 As String = "select OrderID from SyncOrders Order By OrderID"
        Private WithEvents PictureBox3 As System.Windows.Forms.PictureBox

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing
#End Region

#Region "Constructor"
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            '
            ' TODO: Add any constructor code after InitializeComponent call
            ''
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.button1 = New System.Windows.Forms.Button
            Me.label1 = New System.Windows.Forms.Label
            Me.lstCustomerId = New System.Windows.Forms.ListBox
            Me.label2 = New System.Windows.Forms.Label
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.PictureBox3 = New System.Windows.Forms.PictureBox
            Me.groupBox1.SuspendLayout()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'button1
            '
            Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button1.BackColor = System.Drawing.Color.Transparent
            Me.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button1.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Image)
            Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.button1.Location = New System.Drawing.Point(240, 77)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(115, 23)
            Me.button1.TabIndex = 0
            Me.button1.Text = "Generate Invoice"
            Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button1.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.BackColor = System.Drawing.Color.White
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.label1.Location = New System.Drawing.Point(-2, 90)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(375, 67)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Click the button to view an PDF document generated by Essential PDF. Please note " & _
                "that Adobe Reader or its equivalent is required to view the resultant document."
            '
            'lstCustomerId
            '
            Me.lstCustomerId.FormattingEnabled = True
            Me.lstCustomerId.Location = New System.Drawing.Point(9, 37)
            Me.lstCustomerId.Name = "lstCustomerId"
            Me.lstCustomerId.Size = New System.Drawing.Size(221, 95)
            Me.lstCustomerId.TabIndex = 25
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(6, 16)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(148, 13)
            Me.label2.TabIndex = 26
            Me.label2.Text = "Select an ID from the list"
            '
            'groupBox1
            '
            Me.groupBox1.BackColor = System.Drawing.Color.White
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.lstCustomerId)
            Me.groupBox1.Controls.Add(Me.button1)
            Me.groupBox1.Location = New System.Drawing.Point(2, 160)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(367, 138)
            Me.groupBox1.TabIndex = 27
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Invoice"
            '
            'PictureBox3
            '
            Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Top
            Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
            Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
            Me.PictureBox3.Name = "PictureBox3"
            Me.PictureBox3.Size = New System.Drawing.Size(373, 89)
            Me.PictureBox3.TabIndex = 71
            Me.PictureBox3.TabStop = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(373, 315)
            Me.Controls.Add(Me.PictureBox3)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Invoice "
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New Form1())
        End Sub
#End Region

#Region "Events"
        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            Try
                ' Generate Invoice for the selected ID.
                GeneratePDF(CInt(lstCustomerId.SelectedItem))

                'Message box confirmation to view the created PDF document.
                If MessageBox.Show("Do you want to view the PDF file?", "PDF File Created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    'Launching the PDF file using the default Application.[Acrobat Reader]
                    System.Diagnostics.Process.Start("Sample.pdf")
                    Me.Close()
                Else
                    ' Exit
                    Me.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            End Try
        End Sub

        ''' <summary>
        ''' Updates the list box with the order id.
        ''' </summary>
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            'Create dataset with the "Customers" table from Northwind database
            Dim dataSet As DataSet = GetNorthwindDataSet(DEF_DB_COMMAND2)

            'Create datatable
            Dim dt As DataTable = dataSet.Tables(0)

            ' Add Customer ID to the list box.
            For Each row As DataRow In dt.Rows
                lstCustomerId.Items.Add(row("OrderID"))
            Next row
            lstCustomerId.SelectedIndex = 0
        End Sub
#End Region

#Region "Helpher Methods"
        ''' <summary>
        ''' Creates PDF document.
        ''' </summary>
        Private Sub GeneratePDF(ByVal id As Integer)
            'Create a new instance of PdfDocument class.
            Dim document As New PdfDocument()
            document.PageSettings.Orientation = PdfPageOrientation.Landscape
            document.PageSettings.Margins.All = 50
            Dim page As PdfPage = document.Pages.Add()
            Dim g As PdfGraphics = page.Graphics
            Dim element As New PdfTextElement("Northwind Traders" & Constants.vbLf & "67, rue des Cinquante Otages," & Constants.vbLf & "Elgin," & Constants.vbLf & "Unites States.")
            element.Font = New PdfStandardFont(PdfFontFamily.TimesRoman, 12)
            element.Brush = New PdfSolidBrush(New PdfColor(89, 89, 93))
            Dim result As PdfLayoutResult = element.Draw(page, New RectangleF(0, 0, page.Graphics.ClientSize.Width \ 2, 200))

            Dim img As PdfImage = PdfImage.FromFile(GetFullTemplatePath("logo.jpg", True))
            page.Graphics.DrawImage(img, New RectangleF(g.ClientSize.Width - 200, result.Bounds.Y, 190, 45))
            Dim subHeadingFont As PdfFont = New PdfStandardFont(PdfFontFamily.TimesRoman, 14)
            g.DrawRectangle(New PdfSolidBrush(New PdfColor(126, 151, 173)), New RectangleF(0, result.Bounds.Bottom + 40, g.ClientSize.Width, 30))
            element = New PdfTextElement("INVOICE " & id.ToString(), subHeadingFont)
            element.Brush = PdfBrushes.White
            result = element.Draw(page, New PointF(10, result.Bounds.Bottom + 48))
            Dim currentDate As String = "DATE " & DateTime.Now.ToString("MM/dd/yyyy")
            Dim textSize As SizeF = subHeadingFont.MeasureString(currentDate)
            g.DrawString(currentDate, subHeadingFont, element.Brush, New PointF(g.ClientSize.Width - textSize.Width - 10, result.Bounds.Y))

            element = New PdfTextElement("BILL TO ", New PdfStandardFont(PdfFontFamily.TimesRoman, 10))
            element.Brush = New PdfSolidBrush(New PdfColor(126, 155, 203))
            result = element.Draw(page, New PointF(10, result.Bounds.Bottom + 25))

            g.DrawLine(New PdfPen(New PdfColor(126, 151, 173), 0.7F), New PointF(0, result.Bounds.Bottom + 3), New PointF(g.ClientSize.Width, result.Bounds.Bottom + 3))

            'Get the product table details
            Dim shipTable As DataTable = GetShipDetails(id)
            'Get the order details
            GetProductTable(shipTable)

            element = New PdfTextElement(shipName, New PdfStandardFont(PdfFontFamily.TimesRoman, 10))
            element.Brush = New PdfSolidBrush(New PdfColor(89, 89, 93))
            result = element.Draw(page, New RectangleF(10, result.Bounds.Bottom + 5, g.ClientSize.Width \ 2, 100))

            element = New PdfTextElement(String.Format("{0}, {1}, {2}", address, shipCity, shipCountry), New PdfStandardFont(PdfFontFamily.TimesRoman, 10))
            element.Brush = New PdfSolidBrush(New PdfColor(89, 89, 93))
            result = element.Draw(page, New RectangleF(10, result.Bounds.Bottom + 3, g.ClientSize.Width \ 2, 100))

            Dim grid As New PdfGrid()
            grid.DataSource = GetProductDetails(id)
            Dim cellStyle As New PdfGridCellStyle()
            cellStyle.Borders.All = PdfPens.White
            Dim header As PdfGridRow = grid.Headers(0)

            Dim headerStyle As New PdfGridCellStyle()
            headerStyle.Borders.All = New PdfPen(New PdfColor(126, 151, 173))
            headerStyle.BackgroundBrush = New PdfSolidBrush(New PdfColor(126, 151, 173))
            headerStyle.TextBrush = PdfBrushes.White
            headerStyle.Font = New PdfStandardFont(PdfFontFamily.TimesRoman, 14.0F, PdfFontStyle.Regular)

            For i As Integer = 0 To header.Cells.Count - 1
                If i = 0 Then
                    header.Cells(i).StringFormat = New PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle)
                Else
                    header.Cells(i).StringFormat = New PdfStringFormat(PdfTextAlignment.Right, PdfVerticalAlignment.Middle)
                End If
            Next i

            header.ApplyStyle(headerStyle)
            cellStyle.Borders.Bottom = New PdfPen(New PdfColor(217, 217, 217), 0.7F)
            cellStyle.Font = New PdfStandardFont(PdfFontFamily.TimesRoman, 12.0F)
            cellStyle.TextBrush = New PdfSolidBrush(New PdfColor(131, 130, 136))
            For Each row As PdfGridRow In grid.Rows
                row.ApplyStyle(cellStyle)
                For i As Integer = 0 To row.Cells.Count - 1
                    Dim cell As PdfGridCell = row.Cells(i)
                    If i = 0 Then
                        cell.StringFormat = New PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle)
                    Else
                        cell.StringFormat = New PdfStringFormat(PdfTextAlignment.Right, PdfVerticalAlignment.Middle)
                    End If

                    If i > 1 Then
                        Dim val As Single = Single.MinValue
                        Single.TryParse(cell.Value.ToString(), val)
                        cell.Value = val.ToString("C")
                    End If
                Next i
            Next row

            Dim layoutFormat As New PdfGridLayoutFormat()
            layoutFormat.Layout = PdfLayoutType.Paginate

            Dim gridResult As PdfGridLayoutResult = grid.Draw(page, New RectangleF(New PointF(0, result.Bounds.Bottom + 40), New SizeF(g.ClientSize.Width, g.ClientSize.Height - 100)), layoutFormat)
            Dim pos As Single = 0.0F
            For i As Integer = 0 To grid.Columns.Count - 2
                pos += grid.Columns(i).Width
            Next i

            Dim font As PdfFont = New PdfStandardFont(PdfFontFamily.TimesRoman, 14.0F)

            gridResult.Page.Graphics.DrawString("Total Due", font, New PdfSolidBrush(New PdfColor(126, 151, 173)), New RectangleF(New PointF(pos, gridResult.Bounds.Bottom + 20), New SizeF(grid.Columns(3).Width - pos, 20)), New PdfStringFormat(PdfTextAlignment.Right))
            gridResult.Page.Graphics.DrawString("Thank you for your business!", New PdfStandardFont(PdfFontFamily.TimesRoman, 12), New PdfSolidBrush(New PdfColor(89, 89, 93)), New PointF(pos - 55, gridResult.Bounds.Bottom + 60))
            pos += grid.Columns(4).Width
            gridResult.Page.Graphics.DrawString(total.ToString("C"), font, New PdfSolidBrush(New PdfColor(131, 130, 136)), New RectangleF(New PointF(pos, gridResult.Bounds.Bottom + 20), New SizeF(grid.Columns(4).Width - pos, 20)), New PdfStringFormat(PdfTextAlignment.Right))

            'Save and close the document.
            document.Save("Sample.pdf")
            document.Close(True)
        End Sub

        ''' <summary>
        ''' Returns order details.
        ''' </summary>
        Private Sub GetProductTable(ByVal dataTable As DataTable)
            Dim dr As DataRow
            Dim rows As Integer = dataTable.Rows.Count
            For i As Integer = 0 To rows - 1
                dr = dataTable.Rows(i)
                shipName = dr("ShipName").ToString()
                freight = System.Convert.ToDouble(dr("Freight").ToString())
                address = dr("ShipAddress").ToString()
                shippedDate = dr("ShippedDate").ToString()
                shipCity = dr("ShipCity").ToString()
                shipCountry = dr("ShipCountry").ToString()
            Next i
        End Sub

        ''' <summary>
        ''' Returns the product details for the selected order id.
        ''' </summary>
        Private Function GetProductDetails(ByVal id As Integer) As DataTable
            DEF_DB_COMMAND2 = "select ProductID,Quantity,UnitPrice,Discount from SyncOrderDetails where OrderID=" & id

            'Create dataset with the "Customers" table from Northwind database
            Dim dataSet As DataSet = GetNorthwindDataSet(DEF_DB_COMMAND2)

            'Create datatable
            Dim prodDT As DataTable = dataSet.Tables(0)

            'Add new column
            prodDT.Columns.Add(New DataColumn("Price", GetType(String)))

            DEF_DB_COMMAND2 = "select Quantity,UnitPrice from SyncOrderDetails where OrderID=" & id

            'Create dataset with the "Customers" table from Northwind database
            Dim dataSet1 As DataSet = GetNorthwindDataSet(DEF_DB_COMMAND2)

            'Create datatable
            Dim dt As DataTable = dataSet1.Tables(0)

            Dim dr As DataRow
            Dim rows As Integer = dt.Rows.Count

            For i As Integer = 0 To rows - 1
                dr = dt.Rows(i)
                x = System.Convert.ToDouble(dr("Quantity").ToString()) * System.Convert.ToDouble(dr("UnitPrice").ToString())
                dr = prodDT.Rows(k)
                y = x.ToString()
                dr("Price") = y.ToString()
                k = k + 1

                total = total + x
            Next

            Return prodDT
        End Function

        ''' <summary>
        ''' Returns data from Orders Table.
        ''' </summary>
        Private Function GetShipDetails(ByVal TestOrderId As Integer) As DataTable
            DEF_DB_COMMAND2 = String.Format("SELECT ShipName,ShipAddress,Freight,ShipCity,ShipCountry,ShippedDate from Orders where OrderID={0}", TestOrderId)

            'Create dataset with the "Customers" table from Northwind database
            Dim dataSet As DataSet = GetNorthwindDataSet(DEF_DB_COMMAND2)

            'Create datatable
            Dim dt As DataTable = dataSet.Tables(0)

            Return dt
        End Function

        ''' <summary>
        ''' Returns the dataset requested in connection string.
        ''' </summary>
        Private Function GetNorthwindDataSet(ByVal selectCommand As String) As DataSet
            Dim dataSet As DataSet = New DataSet()
            Try
                AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", True)
                Dim SqlMobileConnString1 As String = "Data Source = " & (GetFullTemplatePath("NorthwindIO.sdf", False))
                Dim conn As New SqlCeConnection(SqlMobileConnString1)
                conn.Open()
                Dim Adapter As SqlCeDataAdapter = New SqlCeDataAdapter(DEF_DB_COMMAND2, conn)
                Adapter.Fill(dataSet)
            Catch
                MessageBox.Show("Cannot load DataSet!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End Try

            Return dataSet
        End Function

        ''' <summary>
        ''' Gets the full path of the PDF template or image.
        ''' </summary>
        ''' <param name="fileName">Name of the file</param>
        ''' <param name="image">True if image</param>
        ''' <returns>Path of the file</returns>
        Private Function GetFullTemplatePath(ByVal fileName As String, ByVal image As Boolean) As String
            Dim fullPath As String = "..\..\..\..\..\..\..\..\..\Common\"
            Dim folder As String
            If image Then
                folder = "Images\PDF"
            Else
                folder = "Data"
            End If

            Return String.Format("{0}{1}\{2}", fullPath, folder, fileName)
        End Function
#End Region
    End Class
End Namespace
