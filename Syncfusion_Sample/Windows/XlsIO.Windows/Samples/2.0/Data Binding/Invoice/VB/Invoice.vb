#Region "Copyright Syncfusion Inc. 2001 - 2007"
'
'  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
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
Imports Syncfusion.XlsIO
Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlServerCe


Namespace EssentialXlsIOSamples
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Invoice : Inherits System.Windows.Forms.Form

#Region "Constants"
        Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\{0}"
#End Region

#Region "Fields"
        Private label2 As System.Windows.Forms.Label
        Private orderDS As DataSet = Nothing
        Private shipName, address, shipCity, shipCountry As String
        Private freight As Double
        Private shippedDate As String
        Private fileName As String
        Private dataPath As String = "..\..\..\..\..\..\..\..\..\Common\Data\"
        Private listBoxCustomer As System.Windows.Forms.ListBox
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents btnCreate As System.Windows.Forms.Button
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents label1 As System.Windows.Forms.Label
        Public connString As String = "Data Source=" + dataPath + "NorthwindIO.sdf"
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbExcel2010 As System.Windows.Forms.RadioButton
        Friend WithEvents rdbExcel2007 As System.Windows.Forms.RadioButton
        Friend WithEvents rdbExcel97 As System.Windows.Forms.RadioButton
        Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
        Friend WithEvents rdbExcel2013 As System.Windows.Forms.RadioButton


        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing
#End Region

#Region "Initialize"
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            Me.rdbExcel2013.Checked = True
            '
            ' TODO: Add any constructor code after InitializeComponent call
            ''
        End Sub
#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Dim dataAdapter As New SqlCeDataAdapter("Select OrderID from Orders Order By OrderID", connString)
            Dim orderDS As New DataSet()
            dataAdapter.Fill(orderDS)
            ' Add Customer ID to the list box.
            For Each row As DataRow In orderDS.Tables(0).Rows
                listBoxCustomer.Items.Add(row("OrderID"))
            Next

        End Sub
#End Region

#Region "Create Spreadsheet for Selected Customer ID"

        Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreate.Click
            Try
                ' Generate Invoice for the selected ID.
                GenerateXls(CInt(listBoxCustomer.SelectedItem))

                'Message box confirmation to view the created xls document.
                If MessageBox.Show("Do you want to view the Xls file?", "Xls File Created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    'Launching the PDF file using the default Application.[Acrobat Reader]
                    System.Diagnostics.Process.Start(fileName)
                    Me.Close()
                Else
                    ' Exit
                    Me.Close()
                End If
            Catch Ex As Exception
                ' Shows the Message box with Exception message, if an exception is thrown.
                MessageBox.Show("Please Select the Employee From ListBox", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End Sub

        Public Sub GenerateXls(ByVal id As Integer)

            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()

            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel
            Dim workbook As IWorkbook
            Dim inputPath As String
            If Me.rdbExcel97.Checked Then
                'Get the path of the Input File
                inputPath = GetFullTemplatePath("Invoice.xls")
                workbook = application.Workbooks.Open(inputPath)
            Else
                inputPath = GetFullTemplatePath("Invoice.xlsx")
                workbook = application.Workbooks.Open(inputPath, ExcelOpenType.Automatic)
            End If

            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            worksheet.Range("A5").Text = "One Portals Way"
            worksheet.Range("A6").Text = "Twin Points WA 98156"
            worksheet.Range("A7").Text = "Phone: 1-206-555-1417 "
            worksheet.Range("A8").Text = "Fax: 1-206-555-5938"

            worksheet.Range("D5").Text = "INVOICE NO:"
            worksheet.Range("D6").Text = "DATE:"
            worksheet.Range("D7").Text = "CUSTOMER ID  :"
            worksheet.Range("E6").Formula = "TODAY()"

            worksheet.Range("E5").Number = id

            'Set values for Ship To.
            GetShipDetails(id)
            worksheet.Range("E7").Text = shipName
            worksheet.Range("E10").Text = shipName
            worksheet.Range("E11").Text = address
            worksheet.Range("E12").Text = shipCity
            worksheet.Range("E13").Text = shipCountry

            'Set values for Bill To.
            worksheet.Range("B10").Text = shipName
            worksheet.Range("B11").Text = address
            worksheet.Range("B12").Text = shipCity
            worksheet.Range("B13").Text = shipCountry


            'Calculates sub total
            worksheet.Range("E27").Formula = "SUM(E20:E26)"

            'Set the number format
            worksheet.Range("E20:E29").NumberFormat = "$#,##0.00"
            worksheet.Range("E28").Value = freight.ToString()

            'Calculates final total
            worksheet.Range("E29").Formula = "E27+E28"

            'Import the data tables.
            worksheet.ImportDataTable(GetOrder(id), False, 17, 1)
            worksheet.ImportDataTable(GetProductDetails(id), False, 20, 1)

            'Calculates price from discount and unit price.
            For i As Integer = 20 To 26
                If worksheet.Range("A" & i.ToString()).Value = "" Then
                    Exit For
                Else
                    worksheet.Range("E" & i.ToString()).Formula = "(B" & i.ToString() & "*C" & i.ToString() & ")- (D" & i.ToString() & "/100)"
                End If
            Next i

            'Set the Workbook version as Excel 97to2003
            If Me.rdbExcel97.Checked Then
                workbook.Version = ExcelVersion.Excel97to2003
                fileName = "InvoiceOutput.xls"
                'Set the Workbook version as Excel 2007
            ElseIf Me.rdbExcel2007.Checked Then
                workbook.Version = ExcelVersion.Excel2007
                fileName = "InvoiceOutput.xlsx"
                'Set the Workbook version as Excel 2010
            ElseIf Me.rdbExcel2010.Checked Then
                workbook.Version = ExcelVersion.Excel2010
                fileName = "InvoiceOutput.xlsx"
            ElseIf Me.rdbExcel2013.Checked Then
                workbook.Version = ExcelVersion.Excel2013
                fileName = "InvoiceOutput.xlsx"
            End If
            'Save the workbook to disk.
            workbook.SaveAs(fileName)

            'Close the workbook.
            workbook.Close()

            'No exception will be thrown if there are unsaved workbooks.
            excelEngine.ThrowNotSavedOnDestroy = False
            excelEngine.Dispose()

        End Sub

#End Region

#Region "Helper Methods"
        ''' <summary>
        ''' Return the Product details for given customer id.
        ''' </summary>
        Private Function GetProductDetails(ByVal id As Integer) As DataTable
            Dim dataAdapter As New SqlCeDataAdapter("Select ProductID,Quantity,UnitPrice,Discount from SyncOrderDetails where OrderID=" & id, connString)
            Dim dataSet As New DataSet()
            dataAdapter.Fill(dataSet)

            Dim prodDataTable As New DataTable()
            prodDataTable = dataSet.Tables(0)
            Return prodDataTable

        End Function

        ''' <summary>
        ''' Ship Details for given customer id.
        ''' </summary>
        Private Sub GetShipDetails(ByVal id As Integer)
            Dim dataAdapter As New SqlCeDataAdapter("Select ShipName,ShipAddress,Freight,ShippedDate,ShipCity,ShipCountry from Orders where OrderID=" & id, connString)
            Dim dataSet As New DataSet()
            dataAdapter.Fill(dataSet)

            Dim dataTable As New DataTable()
            dataTable = dataSet.Tables(0)
            Dim dataRow As DataRow
            Dim rows As Integer = dataTable.Rows.Count
            For i As Integer = 0 To rows - 1
                dataRow = dataTable.Rows(i)
                shipName = dataRow("ShipName").ToString()
                freight = System.Convert.ToDouble(dataRow("Freight").ToString())
                address = dataRow("ShipAddress").ToString()
                shippedDate = dataRow("ShippedDate").ToString()
                shipCity = dataRow("ShipCity").ToString()
                shipCountry = dataRow("ShipCountry").ToString()
            Next

        End Sub

        ''' <summary>
        ''' return order details for given customer id.
        ''' </summary>
        Private Function GetOrder(ByVal id As Integer) As DataTable
            Dim dataTable As New DataTable()
            Dim dataAdapter As New SqlCeDataAdapter("Select Salesperson,ShipName,ShipCountry,CustomerID,OrderDate,RequiredDate from SyncOrders where OrderID=" & id, connString)
            Dim dataSet As New DataSet()
            dataAdapter.Fill(dataSet)
            dataTable = dataSet.Tables(0)

            Return dataTable

        End Function

        ''' <summary>
        ''' Return the file path of the Input file
        ''' </summary>
        Private Function GetFullTemplatePath(ByVal inputFile As String) As String
            Return String.Format(DEFAULTPATH, inputFile)
        End Function
#End Region

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoice))
            Me.listBoxCustomer = New System.Windows.Forms.ListBox
            Me.label2 = New System.Windows.Forms.Label
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.GroupBox2 = New System.Windows.Forms.GroupBox
            Me.rdbExcel2010 = New System.Windows.Forms.RadioButton
            Me.rdbExcel2007 = New System.Windows.Forms.RadioButton
            Me.rdbExcel97 = New System.Windows.Forms.RadioButton
            Me.btnCreate = New System.Windows.Forms.Button
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.label1 = New System.Windows.Forms.Label
            Me.pictureBox2 = New System.Windows.Forms.PictureBox
            Me.rdbExcel2013 = New System.Windows.Forms.RadioButton
            Me.groupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'listBoxCustomer
            '
            Me.listBoxCustomer.Location = New System.Drawing.Point(344, 41)
            Me.listBoxCustomer.Name = "listBoxCustomer"
            Me.listBoxCustomer.Size = New System.Drawing.Size(126, 95)
            Me.listBoxCustomer.TabIndex = 2
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(32, 32)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(200, 40)
            Me.label2.TabIndex = 3
            Me.label2.Text = "Select Customer ID from the list box"
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.GroupBox2)
            Me.groupBox1.Controls.Add(Me.btnCreate)
            Me.groupBox1.Controls.Add(Me.listBoxCustomer)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Location = New System.Drawing.Point(3, 157)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(474, 163)
            Me.groupBox1.TabIndex = 5
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Invoice"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.rdbExcel2013)
            Me.GroupBox2.Controls.Add(Me.rdbExcel2010)
            Me.GroupBox2.Controls.Add(Me.rdbExcel2007)
            Me.GroupBox2.Controls.Add(Me.rdbExcel97)
            Me.GroupBox2.Location = New System.Drawing.Point(6, 75)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(332, 37)
            Me.GroupBox2.TabIndex = 4
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Save As"
            '
            'rdbExcel2010
            '
            Me.rdbExcel2010.AutoSize = True
            Me.rdbExcel2010.Location = New System.Drawing.Point(164, 13)
            Me.rdbExcel2010.Name = "rdbExcel2010"
            Me.rdbExcel2010.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel2010.TabIndex = 2
            Me.rdbExcel2010.Text = "Excel 2010"
            Me.rdbExcel2010.UseVisualStyleBackColor = True
            '
            'rdbExcel2007
            '
            Me.rdbExcel2007.AutoSize = True
            Me.rdbExcel2007.Location = New System.Drawing.Point(85, 13)
            Me.rdbExcel2007.Name = "rdbExcel2007"
            Me.rdbExcel2007.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel2007.TabIndex = 1
            Me.rdbExcel2007.Text = "Excel 2007"
            Me.rdbExcel2007.UseVisualStyleBackColor = True
            '
            'rdbExcel97
            '
            Me.rdbExcel97.AutoSize = True
            Me.rdbExcel97.Checked = True
            Me.rdbExcel97.Location = New System.Drawing.Point(6, 13)
            Me.rdbExcel97.Name = "rdbExcel97"
            Me.rdbExcel97.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel97.TabIndex = 0
            Me.rdbExcel97.TabStop = True
            Me.rdbExcel97.Text = "Excel 2003"
            Me.rdbExcel97.UseVisualStyleBackColor = True
            '
            'btnCreate
            '
            Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnCreate.Location = New System.Drawing.Point(77, 123)
            Me.btnCreate.Name = "btnCreate"
            Me.btnCreate.Size = New System.Drawing.Size(88, 23)
            Me.btnCreate.TabIndex = 0
            Me.btnCreate.Text = "Create Invoice"
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(115, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(374, 96)
            Me.pictureBox1.TabIndex = 64
            Me.pictureBox1.TabStop = False
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label1.Location = New System.Drawing.Point(0, 106)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(426, 48)
            Me.label1.TabIndex = 72
            Me.label1.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" & _
                "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" & _
                "nt."
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pictureBox2
            '
            Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
            Me.pictureBox2.Location = New System.Drawing.Point(2, -15)
            Me.pictureBox2.Name = "pictureBox2"
            Me.pictureBox2.Size = New System.Drawing.Size(127, 96)
            Me.pictureBox2.TabIndex = 73
            Me.pictureBox2.TabStop = False
            '
            'rdbExcel2013
            '
            Me.rdbExcel2013.AutoSize = True
            Me.rdbExcel2013.Location = New System.Drawing.Point(248, 13)
            Me.rdbExcel2013.Name = "rdbExcel2013"
            Me.rdbExcel2013.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel2013.TabIndex = 3
            Me.rdbExcel2013.Text = "Excel 2013"
            Me.rdbExcel2013.UseVisualStyleBackColor = True
            '
            'Invoice
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(487, 326)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.pictureBox2)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Invoice"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Invoice"
            Me.groupBox1.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Dispose"
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

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Invoice())
        End Sub
#End Region


    End Class
End Namespace


