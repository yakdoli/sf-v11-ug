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
Imports System.Collections.Generic

Namespace EssentialXlsIOSamples
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class TemplateMarker : Inherits System.Windows.Forms.Form

#Region "Constants"
        Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\{0}"
#End Region

#Region "Fields"
        Private WithEvents btnCreate As System.Windows.Forms.Button
        Private northwindDt As DataTable
        Private numbersDt As DataTable
        Private fileName As String
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents rdbDataTable As System.Windows.Forms.RadioButton
        Private WithEvents rdbObjects As System.Windows.Forms.RadioButton
        Dim _customers As IList(Of Customer) = New List(Of Customer)()
        Friend WithEvents viewInputTemplate As System.Windows.Forms.Button


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
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MinimizeBox = False
            Me.MaximizeBox = False
            Me.StartPosition = FormStartPosition.CenterScreen
            '
            ' TODO: Add any constructor code after InitializeComponent call
            ''
        End Sub
#End Region

#Region "Template Marker"
        Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreate.Click
            'New instance of XlsIO is created.(Equivalent to launching MS Excel with no workbooks open).
            'The instantiation process consists of two steps.

            'Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()

            'Get the path of the input file
            Dim inputPath As String = GetFullTemplatePath("TemplateMarker.xlsx")
            'Open an existing spreadsheet which will be used as a template for generating the new spreadsheet.
            'After opening, the workbook object represents the complete in-memory object model of the template spreadsheet.
            Dim workbook As IWorkbook = excelEngine.Excel.Workbooks.Open(inputPath, ExcelOpenType.Automatic)

            'The first worksheet object in the worksheets collection is accessed.
            Dim worksheet1 As IWorksheet = workbook.Worksheets(0)

            'Create Template Marker Processor
            Dim marker As ITemplateMarkersProcessor = workbook.CreateTemplateMarkersProcessor()

            Dim conditionanFormats As IConditionalFormats = marker.CreateConditionalFormats(worksheet1("C5"))

            'Apply markers using Formula

            Dim condition As IConditionalFormat = conditionanFormats.AddCondition()

            'Set Data bar and icon set for the same cell
            'Set the format type
            condition.FormatType = ExcelCFType.DataBar
            Dim dataBar As IDataBar = condition.DataBar

            'Set the constraint
            dataBar.MinPoint.Type = ConditionValueType.LowestValue
            dataBar.MinPoint.Value = "0"
            dataBar.MaxPoint.Type = ConditionValueType.HighestValue
            dataBar.MaxPoint.Value = "0"

            'Set color for Bar
            dataBar.BarColor = Color.FromArgb(156, 208, 243)

            'Hide the value in data bar
            dataBar.ShowValue = False


            condition = conditionanFormats.AddCondition()
            condition.FormatType = ExcelCFType.IconSet
            Dim iconSet As IIconSet = condition.IconSet
            iconSet.IconSet = ExcelIconSetType.FourRating
            iconSet.IconCriteria(0).Type = ConditionValueType.LowestValue
            iconSet.IconCriteria(0).Value = "0"
            iconSet.IconCriteria(1).Type = ConditionValueType.HighestValue
            iconSet.IconCriteria(1).Value = "0"
            iconSet.ShowIconOnly = True

            conditionanFormats = marker.CreateConditionalFormats(worksheet1("D5"))


            condition = conditionanFormats.AddCondition()

            condition.FormatType = ExcelCFType.ColorScale
            Dim colorScale As IColorScale = condition.ColorScale

            'Sets 3 - color scale.
            colorScale.SetConditionCount(3)

            colorScale.Criteria(0).FormatColorRGB = Color.FromArgb(230, 197, 218)
            colorScale.Criteria(0).Type = ConditionValueType.LowestValue
            colorScale.Criteria(0).Value = "0"

            colorScale.Criteria(1).FormatColorRGB = Color.FromArgb(244, 210, 178)
            colorScale.Criteria(1).Type = ConditionValueType.Percentile
            colorScale.Criteria(1).Value = "50"

            colorScale.Criteria(2).FormatColorRGB = Color.FromArgb(245, 247, 171)
            colorScale.Criteria(2).Type = ConditionValueType.HighestValue
            colorScale.Criteria(2).Value = "0"

            conditionanFormats = marker.CreateConditionalFormats(worksheet1("E5"))

            condition = conditionanFormats.AddCondition()
            condition.FormatType = ExcelCFType.IconSet
            iconSet = condition.IconSet
            iconSet.IconSet = ExcelIconSetType.ThreeSymbols
            iconSet.IconCriteria(0).Type = ConditionValueType.LowestValue
            iconSet.IconCriteria(0).Value = "0"
            iconSet.IconCriteria(1).Type = ConditionValueType.HighestValue
            iconSet.IconCriteria(1).Value = "0"
            iconSet.ShowIconOnly = False


            'Northwind customers table			

            If rdbDataTable.Checked Then
                marker.AddVariable("Customers", northwindDt)
            Else
                'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
                'The instantiation process consists of two steps.
                If Me._customers.Count = 0 Then
                    Me._customers = GetCustomerAsObjects()
                End If
                marker.AddVariable("Customers", _customers)
            End If

            'Create markers
            worksheet1.Range("B9").Text = "%Names;horizontal"
            worksheet1.Range("B10").Text = "%Descriptions;horizontal"

            'Insert Array Horizontally
            Dim names As String() = New String() {"Essential DocIO", "Essential XlsIO", "Essential Pdf"}
            Dim descriptions As String() = New String() {"This is an efficient library for creating MSWord documents", "This is an efficient library for creating MSExcel documents", "This is an efficient library for creating Adobe PDF documents"}
            marker.AddVariable("Names", names)
            marker.AddVariable("Descriptions", descriptions)

            'Stretch Formula. This shows the data getting replaced in the marker specified in another worksheet.
            marker.AddVariable("NumbersTable", numbersDt)

            'Process the markers in the template.
            marker.ApplyMarkers()

            workbook.Version = ExcelVersion.Excel2007
            'Saving the workbook to disk. This spreadsheet is the result of opening and modifying
            'an existing spreadsheet and then saving the result to a new workbook.
            fileName = "TemplateMarker.xlsx"
            workbook.SaveAs(fileName)

            'Close the workbook.
            workbook.Close()

            'Message box confirmation to view the created spreadsheet.
            If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                'Launching the Excel file using the default Application.(MS Excel Or Free ExcelViewer)
                System.Diagnostics.Process.Start(fileName)
                'Exit
                Me.Close()
            Else
                ' Exit
                Me.Close()
            End If

        End Sub
#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'Load Data
            Dim customersDataSet As DataSet = New DataSet()
            'Get the path of the input Xml file
            Dim inputXmlPath As String = GetFullTemplatePath("Customers.xml")
            customersDataSet.ReadXml(inputXmlPath, XmlReadMode.ReadSchema)
            northwindDt = customersDataSet.Tables(0)
            numbersDt = GetTable()
        End Sub
#End Region

#Region "HelperMethods"
        ''' <summary>
        ''' Return the file path of the Input file
        ''' </summary>
        Private Function GetFullTemplatePath(ByVal inputFile As String) As String
            Return String.Format(DEFAULTPATH, inputFile)
        End Function


        ''' <summary>
        ''' Create the datatable with numbers and returns the same
        '''</summary>
        Private Function GetTable() As DataTable
            Dim r As Random = New Random()
            Dim dt As DataTable = New DataTable("NumbersTable")

            Dim nCols As Integer = 4
            Dim nRows As Integer = 10

            Dim i As Integer = 0
            'ORIGINAL LINE: for(int i = 0  i < nCols  i += 1)
            'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
            Do While i < nCols
                dt.Columns.Add(New DataColumn("Column" & i.ToString()))
                i += 1
            Loop

            i = 0
            'ORIGINAL LINE: for(int i = 0  i < nRows  i += 1)
            'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
            Do While i < nRows
                Dim dr As DataRow = dt.NewRow()
                Dim j As Integer = 0
                'ORIGINAL LINE: for(int j = 0  j < nCols  j += 1)
                'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
                Do While j < nCols
                    dr(j) = r.Next(0, 10)
                    j += 1
                Loop
                dt.Rows.Add(dr)
                i += 1
            Loop
            Return dt
        End Function

        '''<summary>
        '''Gets the Collection of objects from the XML data.
        '''</summary>
        Private Function GetCustomerAsObjects() As IList(Of Customer)
            Dim customersDataSet As New DataSet()
            'Get the path of the input file
            Dim inputXmlPath As String = GetFullTemplatePath("Customers.xml")
            customersDataSet.ReadXml(inputXmlPath, XmlReadMode.ReadSchema)
            northwindDt = customersDataSet.Tables(0)
            Dim tmpCustomers As IList(Of Customer) = New List(Of Customer)()
            Dim customer As New Customer()
            numbersDt = GetTable()
            'numbersDt = GetTable();
            Dim columns As DataColumnCollection = northwindDt.Columns
            Dim rows As DataRowCollection = northwindDt.Rows
            For Each row As DataRow In rows
                customer = New Customer()
                customer.SalesPerson = row(0).ToString()
                customer.SalesJanJune = row(1).ToString()
                customer.SalesJulyDec = row(2).ToString()
                customer.Change = Convert.ToInt32(row(3))
                tmpCustomers.Add(customer)
            Next

            Return tmpCustomers
        End Function
#End Region

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TemplateMarker))
            Me.btnCreate = New System.Windows.Forms.Button
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.label2 = New System.Windows.Forms.Label
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.rdbDataTable = New System.Windows.Forms.RadioButton
            Me.rdbObjects = New System.Windows.Forms.RadioButton
            Me.viewInputTemplate = New System.Windows.Forms.Button
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnCreate
            '
            Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCreate.BackColor = System.Drawing.Color.Transparent
            Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
            Me.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCreate.Location = New System.Drawing.Point(77, 215)
            Me.btnCreate.Name = "btnCreate"
            Me.btnCreate.Size = New System.Drawing.Size(84, 26)
            Me.btnCreate.TabIndex = 0
            Me.btnCreate.Text = "Create"
            Me.btnCreate.UseVisualStyleBackColor = False
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(373, 96)
            Me.pictureBox1.TabIndex = 63
            Me.pictureBox1.TabStop = False
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(0, 109)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(372, 48)
            Me.label2.TabIndex = 64
            Me.label2.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" & _
                "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" & _
                "nt."
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.rdbDataTable)
            Me.groupBox1.Controls.Add(Me.rdbObjects)
            Me.groupBox1.Location = New System.Drawing.Point(73, 160)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(214, 43)
            Me.groupBox1.TabIndex = 68
            Me.groupBox1.TabStop = False
            '
            'rdbDataTable
            '
            Me.rdbDataTable.AutoSize = True
            Me.rdbDataTable.Checked = True
            Me.rdbDataTable.Location = New System.Drawing.Point(9, 15)
            Me.rdbDataTable.Name = "rdbDataTable"
            Me.rdbDataTable.Size = New System.Drawing.Size(75, 17)
            Me.rdbDataTable.TabIndex = 65
            Me.rdbDataTable.TabStop = True
            Me.rdbDataTable.Text = "DataTable"
            Me.rdbDataTable.UseVisualStyleBackColor = True
            '
            'rdbObjects
            '
            Me.rdbObjects.AutoSize = True
            Me.rdbObjects.Location = New System.Drawing.Point(100, 14)
            Me.rdbObjects.Name = "rdbObjects"
            Me.rdbObjects.Size = New System.Drawing.Size(106, 17)
            Me.rdbObjects.TabIndex = 64
            Me.rdbObjects.TabStop = True
            Me.rdbObjects.Text = "Business Objects"
            Me.rdbObjects.UseVisualStyleBackColor = True
            '
            'viewInputTemplate
            '
            Me.viewInputTemplate.Location = New System.Drawing.Point(179, 215)
            Me.viewInputTemplate.Name = "viewInputTemplate"
            Me.viewInputTemplate.Size = New System.Drawing.Size(100, 26)
            Me.viewInputTemplate.TabIndex = 69
            Me.viewInputTemplate.Text = "Input Template"
            Me.viewInputTemplate.UseVisualStyleBackColor = True
            '
            'TemplateMarker
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(373, 253)
            Me.Controls.Add(Me.viewInputTemplate)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.btnCreate)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MinimizeBox = False
            Me.Name = "TemplateMarker"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Template Marker"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
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
            Application.EnableVisualStyles()
            Application.Run(New TemplateMarker())
        End Sub
#End Region

#Region "View the Input Template"
        Private Sub viewInputTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewInputTemplate.Click
            'Get the path of the Input File
            Dim inputPath As String = GetFullTemplatePath("TemplateMarker.xlsx")
            'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start(inputPath)
        End Sub
#End Region
    End Class
End Namespace
