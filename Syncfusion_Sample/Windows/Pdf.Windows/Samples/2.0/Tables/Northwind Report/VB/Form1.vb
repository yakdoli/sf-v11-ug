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
Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Graphics
Imports Syncfusion.Pdf.Tables
Imports System.Data.OleDb
Imports System.Data.SqlServerCe


Namespace EssentialPDFSamples
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1 : Inherits System.Windows.Forms.Form
#Region "Private Members"
        Private WithEvents button1 As System.Windows.Forms.Button
        Private label1 As System.Windows.Forms.Label
        Private Const DEF_DB_COMMAND2 As String = "SELECT CustomerID,CompanyName,ContactName,Address,City,PostalCode,Country,Phone,Fax FROM Customers"
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
            Me.PictureBox3 = New System.Windows.Forms.PictureBox
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
            Me.button1.Location = New System.Drawing.Point(288, 160)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 23)
            Me.button1.TabIndex = 0
            Me.button1.Text = "PDF"
            Me.button1.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.label1.Location = New System.Drawing.Point(0, 93)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(377, 67)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Click the button to view an PDF document generated by Essential PDF. Please note " & _
                "that Adobe Reader or its equivalent is required to view the resultant document."
            '
            'PictureBox3
            '
            Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Top
            Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
            Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
            Me.PictureBox3.Name = "PictureBox3"
            Me.PictureBox3.Size = New System.Drawing.Size(375, 90)
            Me.PictureBox3.TabIndex = 71
            Me.PictureBox3.TabStop = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(375, 204)
            Me.Controls.Add(Me.PictureBox3)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Northwind Report"
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
            'Create a new instance of PdfDocument class.
            Dim document As New PdfDocument()

            'Set font
            Dim font As PdfFont = New PdfStandardFont(PdfFontFamily.Helvetica, 8)

            ' Add a new page to the document.
            Dim page As PdfPage = document.Pages.Add()

            'Adding Header
            Me.AddHeader(document, "Northwind Customers", "")

            'Use DataTable as source
            Dim table As New PdfLightTable()

            'Create dataset with the "Customers" table from Northwind database.
            Dim dataSet As DataSet = GetNorthwindDataSet(DEF_DB_COMMAND2)

            'Set Data source
            table.DataSource = dataSet.Tables(0)

            '			#Region "Cell Styles"

            'Create Pdf pen for drawing broder
            Dim borderPen As New PdfPen(PdfBrushes.DarkBlue)
            borderPen.Width = 0

            'Create cell styles
            Dim altStyle As New PdfCellStyle()
            altStyle.Font = font
            altStyle.BackgroundBrush = New PdfSolidBrush(New PdfColor(192, 201, 219))
            altStyle.BorderPen = borderPen

            Dim defStyle As New PdfCellStyle()
            defStyle.Font = font
            defStyle.BackgroundBrush = PdfBrushes.White
            defStyle.BorderPen = borderPen
            defStyle.StringFormat = New PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle)

            Dim headerStyle As New PdfCellStyle(font, PdfBrushes.White, PdfPens.DarkBlue)
            headerStyle.BackgroundBrush = New PdfSolidBrush(Color.FromArgb(33, 67, 126))
            headerStyle.StringFormat = New PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle)

            '			#End Region

            '			#Region "Format Table"
            'Set table alternate row style
            table.Style.AlternateStyle = altStyle

            'Set default style
            table.Style.DefaultStyle = defStyle

            'Set header row style         
            table.Style.HeaderStyle = headerStyle

            'Show the header row
            table.Style.ShowHeader = True

            'Repeate header in all the pages
            table.Style.RepeatHeader = True

            'Set header data from column caption
            table.Style.HeaderSource = PdfHeaderSource.ColumnCaptions

            table.Style.BorderPen = borderPen
            table.Style.CellPadding = 2
            table.Columns(1).Width = 12

            '			#End Region

            ' Create a new instance of PdfLayoutFormat class.
            Dim format As New PdfLayoutFormat()
            'Set layout properties.
            format.Break = PdfLayoutBreakType.FitElement
            format.Layout = PdfLayoutType.Paginate

            'Draw table
            table.Draw(page, New PointF(0, 10), format)

            'Save to disk
            document.Save("Sample.pdf")
            document.Close(True)

            'Message box confirmation to view the created PDF document.
            If MessageBox.Show("Do you want to view the PDF file?", "PDF File Created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                'Launching the PDF file using the default Application.[Acrobat Reader]
                System.Diagnostics.Process.Start("Sample.pdf")
                Me.Close()
            Else
                ' Exit
                Me.Close()
            End If
        End Sub
#End Region

#Region "Helpher Methods"
        ''' <summary>
        ''' Returns dataset.
        ''' </summary>
        Private Function GetNorthwindDataSet(ByVal selectCommand As String) As DataSet
            Dim dataSet As DataSet = New DataSet()
            Try
                AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", True)
                Dim SqlMobileConnString1 As String = "Data Source = " & GetFullTemplatePath("NorthwindIO.sdf", False)
                Dim conn As SqlCeConnection = New SqlCeConnection(SqlMobileConnString1)
                conn.Open()
                Dim Adapter As SqlCeDataAdapter = New SqlCeDataAdapter(DEF_DB_COMMAND2, conn)
                Adapter.Fill(dataSet)
            Catch
                MessageBox.Show("Cannot load DataSet", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End Try

            Return dataSet
        End Function
        ''' <summary>
        ''' Adds header to the document.
        ''' </summary>
        Private Sub AddHeader(ByVal doc As PdfDocument, ByVal title As String, ByVal description As String)
            Dim rect As New RectangleF(0, 0, doc.Pages(0).GetClientSize().Width, 54)
            Dim header As New PdfPageTemplateElement(rect)
            Dim g As PdfGraphics = header.Graphics

            'Draw the image in the Header.
            Dim imageSize As New SizeF(110.0F, 35.0F)
            'Locating the logo on the right corner.
            Dim imageLocation As New PointF(g.ClientSize.Width - imageSize.Width - 20, 8)
            Dim img As PdfImage = New PdfBitmap(GetFullTemplatePath("logo.jpg", True))
            g.DrawImage(img, imageLocation, imageSize)

            ' Update title.
            Dim brush As New PdfSolidBrush(Color.FromArgb(44, 71, 120))
            Dim font As PdfFont = New PdfStandardFont(PdfFontFamily.Helvetica, 16, PdfFontStyle.Bold)
            Dim format As New PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle)
            g.DrawString(title, font, brush, New RectangleF(0, 0, header.Width, header.Height), format)

            ' Update description.
            brush = New PdfSolidBrush(Color.Gray)
            font = New PdfStandardFont(PdfFontFamily.Helvetica, 6, PdfFontStyle.Bold)
            format = New PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Bottom)
            g.DrawString(description, font, brush, New RectangleF(0, 0, header.Width, header.Height - 8), format)

            ' Draw lines.
            Dim pen As New PdfPen(Color.DarkBlue, 3.0F)
            g.DrawLine(pen, 0, 0, header.Width, 0)
            pen = New PdfPen(Color.DarkBlue, 2.0F)
            g.DrawLine(pen, 0, header.Height - 4, header.Width, header.Height - 4)

            doc.Template.Top = header
        End Sub

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
