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
        Public Shared ReadOnly Datasource As String = "Data Source=" + Path.GetFullPath("../../Data/Northwind.mdb")
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbExcel2010 As System.Windows.Forms.RadioButton
        Friend WithEvents rdbExcel2007 As System.Windows.Forms.RadioButton
        Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
        Friend WithEvents rdbExcel2013 As System.Windows.Forms.RadioButton
        Friend WithEvents refresh As System.Windows.Forms.CheckBox


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

            Dim connection As New OleDbConnection()
            connection.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Password="""";User ID=Admin;" + Datasource
            Dim query As New OleDbCommand("select country from Customers", connection)
            Dim adapter As New OleDbDataAdapter(query)
            Dim Country As New DataSet()
            adapter.Fill(Country)
            ' Add Customer ID to the list box.
            For Each row As DataRow In Country.Tables(0).Rows
                If Not listBoxCustomer.Items.Contains(row("country")) Then
                    listBoxCustomer.Items.Add(row("country"))
                End If
            Next
            connection.Close()
            connection.Dispose()
            query.Dispose()
            adapter.Dispose()
            Country.Dispose()


        End Sub
#End Region

#Region "Create Spreadsheet for Selected Customer ID"

        Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreate.Click
            Try
                ' Generate Invoice for the selected ID.
                GenerateXls((listBoxCustomer.SelectedItems))

                'Message box confirmation to view the created xls document.
                If MessageBox.Show("Do you want to view the Xlsx file?", "Xlsx File Created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
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

        Public Sub GenerateXls(selctedcountry As ListBox.SelectedObjectCollection)
            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As New ExcelEngine()
            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel
            'Create the workbook with default sheet
            Dim workbook As IWorkbook = application.Workbooks.Create()
            'Get the 1st sheet from the workbook
            Dim sheet As IWorksheet = workbook.Worksheets(0)
            'connection string for DataSource
            Dim Connectionstring As String = "OLEDB;Provider=Microsoft.JET.OLEDB.4.0;Password="""";User ID=Admin;" + Datasource
            'query for the datasource
            Dim query As String
            Dim countries As String = String.Empty
            If selctedcountry.Count > 0 Then
                countries = "'" + selctedcountry(0).ToString() + "'"
                For i As Integer = 0 To selctedcountry.Count - 1
                    countries = countries + "," + "'" + selctedcountry(i) + "'"
                Next
                query = "select * from Customers where country in(" + countries + ");"
            Else
                query = "select * from Customers"
            End If
            'Add the connection to workbook
            Dim Connection As IConnection = workbook.Connections.Add("Connection1", "Sample connection with MsAccess", Connectionstring, query, ExcelCommandType.Sql)
            'Add the QueryTable to sheet object
            sheet.ListObjects.AddEx(ExcelListObjectSourceType.SrcQuery, Connection, sheet.Range("A1"))

            'Refresh the Connection for include the data
            If refresh.Checked Then
                sheet.ListObjects(0).Refresh()
                sheet.UsedRange.AutofitColumns()
            End If



            'Set the Workbook version as excel 2007
            If Me.rdbExcel2007.Checked Then
                workbook.Version = ExcelVersion.Excel2007
                fileName = "ExternalConnection.xlsx"
                'Set the Workbook version as Excel 2010
            ElseIf Me.rdbExcel2010.Checked Then
                workbook.Version = ExcelVersion.Excel2010
                fileName = "ExternalConnection.xlsx"
                'Set the Workbook version as Excel 2010
            ElseIf Me.rdbExcel2013.Checked Then
                workbook.Version = ExcelVersion.Excel2013
                fileName = "ExternalConnection.xlsx"
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


#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoice))
            Me.listBoxCustomer = New System.Windows.Forms.ListBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.refresh = New System.Windows.Forms.CheckBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.rdbExcel2013 = New System.Windows.Forms.RadioButton()
            Me.rdbExcel2010 = New System.Windows.Forms.RadioButton()
            Me.rdbExcel2007 = New System.Windows.Forms.RadioButton()
            Me.btnCreate = New System.Windows.Forms.Button()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.pictureBox2 = New System.Windows.Forms.PictureBox()
            Me.groupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'listBoxCustomer
            '
            Me.listBoxCustomer.Location = New System.Drawing.Point(9, 38)
            Me.listBoxCustomer.Name = "listBoxCustomer"
            Me.listBoxCustomer.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
            Me.listBoxCustomer.Size = New System.Drawing.Size(126, 95)
            Me.listBoxCustomer.TabIndex = 2
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(32, 16)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(273, 19)
            Me.label2.TabIndex = 3
            Me.label2.Text = "Select countries from the list box (optional)"
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.refresh)
            Me.groupBox1.Controls.Add(Me.GroupBox2)
            Me.groupBox1.Controls.Add(Me.btnCreate)
            Me.groupBox1.Controls.Add(Me.listBoxCustomer)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Location = New System.Drawing.Point(3, 157)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(413, 142)
            Me.groupBox1.TabIndex = 5
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "External Connection"
            '
            'refresh
            '
            Me.refresh.AutoSize = True
            Me.refresh.Location = New System.Drawing.Point(157, 99)
            Me.refresh.Name = "refresh"
            Me.refresh.Size = New System.Drawing.Size(63, 17)
            Me.refresh.TabIndex = 5
            Me.refresh.Text = "Refresh"
            Me.refresh.UseVisualStyleBackColor = True
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.rdbExcel2013)
            Me.GroupBox2.Controls.Add(Me.rdbExcel2010)
            Me.GroupBox2.Controls.Add(Me.rdbExcel2007)
            Me.GroupBox2.Location = New System.Drawing.Point(157, 38)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(250, 37)
            Me.GroupBox2.TabIndex = 4
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Save As"
            '
            'rdbExcel2013
            '
            Me.rdbExcel2013.AutoSize = True
            Me.rdbExcel2013.Location = New System.Drawing.Point(164, 14)
            Me.rdbExcel2013.Name = "rdbExcel2013"
            Me.rdbExcel2013.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel2013.TabIndex = 3
            Me.rdbExcel2013.Text = "Excel 2013"
            Me.rdbExcel2013.UseVisualStyleBackColor = True
            '
            'rdbExcel2010
            '
            Me.rdbExcel2010.AutoSize = True
            Me.rdbExcel2010.Location = New System.Drawing.Point(90, 14)
            Me.rdbExcel2010.Name = "rdbExcel2010"
            Me.rdbExcel2010.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel2010.TabIndex = 2
            Me.rdbExcel2010.Text = "Excel 2010"
            Me.rdbExcel2010.UseVisualStyleBackColor = True
            '
            'rdbExcel2007
            '
            Me.rdbExcel2007.AutoSize = True
            Me.rdbExcel2007.Location = New System.Drawing.Point(6, 13)
            Me.rdbExcel2007.Name = "rdbExcel2007"
            Me.rdbExcel2007.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel2007.TabIndex = 1
            Me.rdbExcel2007.Text = "Excel 2007"
            Me.rdbExcel2007.UseVisualStyleBackColor = True
            '
            'btnCreate
            '
            Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnCreate.Location = New System.Drawing.Point(319, 95)
            Me.btnCreate.Name = "btnCreate"
            Me.btnCreate.Size = New System.Drawing.Size(88, 23)
            Me.btnCreate.TabIndex = 0
            Me.btnCreate.Text = "Create"
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(27, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(375, 96)
            Me.pictureBox1.TabIndex = 64
            Me.pictureBox1.TabStop = False
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label1.Location = New System.Drawing.Point(0, 106)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(402, 48)
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
            'Invoice
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(424, 302)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.pictureBox2)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Invoice"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "External Connection"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
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


