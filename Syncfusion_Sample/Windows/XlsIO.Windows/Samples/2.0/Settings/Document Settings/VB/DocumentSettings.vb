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

Namespace EssentialXlsIOSamples
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class DocumentSettings : Inherits System.Windows.Forms.Form

#Region "Constants"
        Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\{0}"
        Private Const DEFAULTIMAGEPATH As String = "..\..\..\..\..\..\..\..\..\Common\Images\XlsIO\{0}"
#End Region

#Region "Fields"
        Private WithEvents btnCreate As System.Windows.Forms.Button
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents rdbExcel2010 As System.Windows.Forms.RadioButton
        Private WithEvents rdbExcel2007 As System.Windows.Forms.RadioButton
        Private WithEvents rdbExcel97 As System.Windows.Forms.RadioButton
        Private fileName As String
        Private WithEvents rdbExcel2013 As System.Windows.Forms.RadioButton
        Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
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
            Me.rdbExcel2013.Checked = True
            '
            ' TODO: Add any constructor code after InitializeComponent call
            ''
        End Sub
#End Region

#Region "Document Setting"
        Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreate.Click
            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()
            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel
            'Set the default version as Excel 97to2003
            If Me.rdbExcel97.Checked Then
                application.DefaultVersion = ExcelVersion.Excel97to2003
                fileName = "DocumentSettingSample.xls"
                'Set the default version as Excel 2007
            ElseIf Me.rdbExcel2007.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2007
                fileName = "DocumentSettingSample.xlsx"
                'Set the default version as Excel 2010
            ElseIf Me.rdbExcel2010.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2010
                fileName = "DocumentSettingSample.xlsx"
                'Set the default version as Excel 2013
            ElseIf Me.rdbExcel2013.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2013
                fileName = "DocumentSettingSample.xlsx"
            End If
            'A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            'The new workbook will have 3 worksheets
            Dim workbook As IWorkbook = application.Workbooks.Create(3)
            'The first worksheet object in the worksheets collection is accessed.
            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            'Get order details 
            Dim northwindData As DataSet = New DataSet()
            'Get path of the xml file
            Dim xmlFilePath As String = GetFullTemplatePath("Orders.xml")
            northwindData.ReadXml(xmlFilePath, XmlReadMode.Auto)
            worksheet.ImportDataTable(northwindData.Tables("Orders"), True, 6, 1, -1, 9, False)


            'Setting Builtin document Properties     
            workbook.Author = "Essential XlsIO"
            workbook.BuiltInDocumentProperties.ApplicationName = "Essential XlsIO"
            workbook.BuiltInDocumentProperties.Category = "Excel Generator"
            workbook.BuiltInDocumentProperties.Comments = "This document was generated using Essential XlsIO"
            workbook.BuiltInDocumentProperties.Company = "Syncfusion Inc."
            workbook.BuiltInDocumentProperties.Subject = "Native Excel Generator"
            workbook.BuiltInDocumentProperties.Keywords = "Syncfusion"
            workbook.BuiltInDocumentProperties.Manager = "Sync Manager"
            workbook.BuiltInDocumentProperties.Title = "Essential XlsIO"

            'Setting Custom document Properties.
            Dim customProperites As ICustomDocumentProperties = workbook.CustomDocumentProperties
            customProperites("Author").Text = "Test Author"
            customProperites("Comments").Text = "XlsIO support Custom document properties"
            customProperites("Double").Double = 120.2
            customProperites("Choice").Boolean = True
            customProperites("Today").DateTime = DateTime.Today
            customProperites("Integer").Int32 = 1234

            ' Setting the Page number in the Center Header
            worksheet.PageSetup.CenterHeader = "&P"

            ' Setting the Date in the Right Header
            worksheet.PageSetup.LeftHeader = "&D"
            ' Setting the file name in the Center Footer
            worksheet.PageSetup.CenterFooter = "&F"
            ' Setting the Sheet Name in the Left Footer
            worksheet.PageSetup.LeftFooter = "&A"

            'Get the path of image
            Dim imagePath As String = GetFullImagePath("logo.jpg")
            Dim img As Image = Image.FromFile(imagePath)
            '' Right Header Image
            worksheet.PageSetup.RightHeaderImage = img
            worksheet.PageSetup.RightHeader = "&G"

            worksheet.PageSetup.AutoFirstPageNumber = False
            worksheet.PageSetup.FirstPageNumber = 2


            'Setting page Margins
            worksheet.PageSetup.LeftMargin = 2
            worksheet.PageSetup.RightMargin = 2
            worksheet.PageSetup.TopMargin = 2
            worksheet.PageSetup.BottomMargin = 2

            ' Setting the Page Orientation as Portrait or Landscape	
            worksheet.PageSetup.Orientation = ExcelPageOrientation.Landscape

            ' Setting the Paper Type
            worksheet.PageSetup.PaperSize = ExcelPaperSize.PaperA4

            ' Giving Horizontal pagebreaks 
            worksheet.HPageBreaks.Add(worksheet.Range("A105"))
            worksheet.HPageBreaks.Add(worksheet.Range("A200"))

            ' Giving Vertical pagebreaks
            worksheet.VPageBreaks.Add(worksheet.Range("H100"))

            worksheet.Range("D2").Text = "Order Details"
            worksheet.Range("D2:E2").Merge()
            worksheet.Range("D2").CellStyle.Font.Size = 10
            worksheet.Range("D2").CellStyle.Font.Bold = True
            worksheet.Range("D2").CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter

            worksheet.Rows(4).CellStyle.Color = Color.FromArgb(182, 189, 218)
            worksheet.Rows(4).CellStyle.Font.Size = 10
            worksheet.Rows(4).CellStyle.Font.Bold = True

            worksheet.UsedRange.AutofitColumns()
            worksheet.IsGridLinesVisible = False

            worksheet.Range("A4").Text = "Note: Please check File->Properties for document properties and File->PageSetUp for page set up options"
            worksheet.Range("A4").CellStyle.Font.Bold = True

            'Saving the workbook to disk.
            workbook.SaveAs(fileName)

            'Close the workbook.
            workbook.Close()

            'No exception will be thrown if there are unsaved workbooks.
            excelEngine.ThrowNotSavedOnDestroy = False
            excelEngine.Dispose()

            'Message box confirmation to view the created spreadsheet.
            If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start(fileName)
                'Exit
                Me.Close()
            Else
                ' Exit
                Me.Close()
            End If

        End Sub
#End Region

#Region "HelperMethod"
        ''' <summary>
        ''' Return the file path of the Input file
        ''' </summary>
        Private Function GetFullTemplatePath(ByVal inputFile As String) As String
            Return String.Format(DEFAULTPATH, inputFile)
        End Function


        ''' <summary>
        ''' Return the path of the Image file
        ''' </summary>
        Private Function GetFullImagePath(ByVal inputFile As String) As String
            Return String.Format(DEFAULTIMAGEPATH, inputFile)
        End Function
#End Region

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocumentSettings))
            Me.btnCreate = New System.Windows.Forms.Button
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.label2 = New System.Windows.Forms.Label
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.rdbExcel2010 = New System.Windows.Forms.RadioButton
            Me.rdbExcel2007 = New System.Windows.Forms.RadioButton
            Me.rdbExcel97 = New System.Windows.Forms.RadioButton
            Me.rdbExcel2013 = New System.Windows.Forms.RadioButton
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnCreate
            '
            Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
            Me.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCreate.Location = New System.Drawing.Point(350, 166)
            Me.btnCreate.Name = "btnCreate"
            Me.btnCreate.Size = New System.Drawing.Size(85, 26)
            Me.btnCreate.TabIndex = 0
            Me.btnCreate.Text = "Create"
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(66, -3)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(372, 96)
            Me.pictureBox1.TabIndex = 63
            Me.pictureBox1.TabStop = False
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(0, 109)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(438, 48)
            Me.label2.TabIndex = 64
            Me.label2.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" & _
                "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" & _
                "nt."
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.rdbExcel2013)
            Me.groupBox1.Controls.Add(Me.rdbExcel2010)
            Me.groupBox1.Controls.Add(Me.rdbExcel2007)
            Me.groupBox1.Controls.Add(Me.rdbExcel97)
            Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(12, 158)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(332, 37)
            Me.groupBox1.TabIndex = 67
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Save As"
            '
            'rdbExcel2010
            '
            Me.rdbExcel2010.AutoSize = True
            Me.rdbExcel2010.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
            Me.rdbExcel2007.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
            Me.rdbExcel97.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbExcel97.Location = New System.Drawing.Point(6, 13)
            Me.rdbExcel97.Name = "rdbExcel97"
            Me.rdbExcel97.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel97.TabIndex = 0
            Me.rdbExcel97.TabStop = True
            Me.rdbExcel97.Text = "Excel 2003"
            Me.rdbExcel97.UseVisualStyleBackColor = True
            '
            'rdbExcel2013
            '
            Me.rdbExcel2013.AutoSize = True
            Me.rdbExcel2013.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbExcel2013.Location = New System.Drawing.Point(242, 13)
            Me.rdbExcel2013.Name = "rdbExcel2013"
            Me.rdbExcel2013.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel2013.TabIndex = 3
            Me.rdbExcel2013.Text = "Excel 2013"
            Me.rdbExcel2013.UseVisualStyleBackColor = True
            '
            'PictureBox2
            '
            Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
            Me.PictureBox2.Location = New System.Drawing.Point(-7, -14)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(106, 96)
            Me.PictureBox2.TabIndex = 68
            Me.PictureBox2.TabStop = False
            '
            'DocumentSettings
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(438, 208)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.btnCreate)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "DocumentSettings"
            Me.Text = "Document Settings"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
            Application.Run(New DocumentSettings())
        End Sub
#End Region

    End Class

End Namespace
