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
    Public Class InteractiveFeatures : Inherits System.Windows.Forms.Form

#Region "Fields"
        Private WithEvents btnCreate As System.Windows.Forms.Button
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbExcel2010 As System.Windows.Forms.RadioButton
        Friend WithEvents rdbExcel2007 As System.Windows.Forms.RadioButton
        Friend WithEvents rdbExcel97 As System.Windows.Forms.RadioButton
        Private fileName As String
        Friend WithEvents rdbExcel2013 As System.Windows.Forms.RadioButton
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

#Region "Interactive Features"
        Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreate.Click
            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()
            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel
            'Set the Default version as Excel 97to2003
            If Me.rdbExcel97.Checked Then
                application.DefaultVersion = ExcelVersion.Excel97to2003
                fileName = "InteractiveFeatures.xls"
                'Set the Default version as Excel 2007
            ElseIf Me.rdbExcel2007.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2007
                fileName = "InteractiveFeatures.xlsx"
                'Set the Default version as Excel 2010
            ElseIf Me.rdbExcel2010.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2010
                fileName = "InteractiveFeatures.xlsx"
                'Set the Default version as Excel 2013
            ElseIf Me.rdbExcel2013.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2013
                fileName = "InteractiveFeatures.xlsx"
            End If
            'A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            'The new workbook will have 3 worksheets
            Dim workbook As IWorkbook = application.Workbooks.Create(3)
            'The first worksheet object in the worksheets collection is accessed.
            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            worksheet.IsGridLinesVisible = False

            worksheet.Range("B2").Text = "Interactive features"
            worksheet.Range("B2").CellStyle.Font.Bold = True
            worksheet.Range("B2").CellStyle.Font.Size = 14

            worksheet.Range("A4").Text = "Some Useful links"
            worksheet.Range("A4").CellStyle.Font.Bold = True
            worksheet.Range("A4").CellStyle.Font.Size = 12

            worksheet.Range("A20").Text = "Comments"
            worksheet.Range("A20").CellStyle.Font.Bold = True
            worksheet.Range("A20").CellStyle.Font.Size = 12

            worksheet.Range("B5").Text = "Feature page"
            worksheet.Range("B7").Text = "Support Email Id"
            worksheet.Range("B9").Text = "Samples"
            worksheet.Range("B11").Text = "Precompiled assemblies"
            worksheet.Range("B13").Text = "Read the comment about XlsIO"
            worksheet.Range("B15").Text = "Read the Comment about Interactive features"
            worksheet.Range("B17").Text = "Home website"
            worksheet.Range("B21").Text = "XlsIO"
            worksheet.Range("B23").Text = "Interactive features"


            'Creating Hyperlink for a Website
            Dim hyperlink As IHyperLink = worksheet.HyperLinks.Add(worksheet.Range("C5"))
            hyperlink.Type = ExcelHyperLinkType.Url
            hyperlink.Address = "http://www.syncfusion.com/products/xlsio/windows/default.aspx"
            hyperlink.ScreenTip = "To know more About XlsIO go through this link"

            'Creating Hyperlink for e-mail
            Dim hyperlink1 As IHyperLink = worksheet.HyperLinks.Add(worksheet.Range("C7"))
            hyperlink1.Type = ExcelHyperLinkType.Url
            hyperlink1.Address = "mailto:support@syncfusion.com"
            hyperlink1.ScreenTip = "Send Mail to this id for your queries"

            'Creating Hyperlink for Opening Files using type as  File
            Dim hyperlink2 As IHyperLink = worksheet.HyperLinks.Add(worksheet.Range("C9"))
            hyperlink2.Type = ExcelHyperLinkType.File

            hyperlink2.Address = "..\..\"
            hyperlink2.ScreenTip = "File path"
            hyperlink2.TextToDisplay = "Hyperlink for files using File as type"

            'Creating Hyperlink for Opening Files using type as Unc
            Dim hyperlink3 As IHyperLink = worksheet.HyperLinks.Add(worksheet.Range("C11"))
            hyperlink3.Type = ExcelHyperLinkType.Unc
            hyperlink3.Address = "C:\Program Files\Syncfusion\Essential Studio"
            hyperlink3.ScreenTip = "Click here for files"
            hyperlink3.TextToDisplay = "Hyperlink for files using Unc as type"

            'Creating Hyperlink to another cell using type as Workbook
            Dim hyperlink4 As IHyperLink = worksheet.HyperLinks.Add(worksheet.Range("C13"))
            hyperlink4.Type = ExcelHyperLinkType.Workbook
            hyperlink4.Address = "Sheet1!B21"
            hyperlink4.ScreenTip = "Click here"
            hyperlink4.TextToDisplay = "Click here to move to the cell with Comments about XlsIO"

            Dim hyperlink5 As IHyperLink = worksheet.HyperLinks.Add(worksheet.Range("C15"))
            hyperlink5.Type = ExcelHyperLinkType.Workbook
            hyperlink5.Address = "Sheet1!B23"
            hyperlink5.ScreenTip = "Click here"
            hyperlink5.TextToDisplay = "Click here to move to the cell with Comments about this sample"

            'Disabling Hyperlink using type as None
            Dim hyperlink6 As IHyperLink = worksheet.HyperLinks.Add(worksheet.Range("C17"))
            hyperlink6.Type = ExcelHyperLinkType.None
            hyperlink6.ScreenTip = "Use this Address"
            hyperlink6.TextToDisplay = "Website:www.syncfusion.com"



            'Insert Comments
            'Adding comments to a cell.
            worksheet.Range("B21").AddComment().Text = "XlsIO is a Backoffice product with high performance!"

            'Add RichText Comments
            Dim range As IRange = worksheet.Range("B23")
            range.AddComment().RichText.Text = "Great Sample!"
            Dim rtf As IRichTextString = range.Comment.RichText

            'Formatting first 4 characters
            Dim greyFont As IFont = workbook.CreateFont()
            greyFont.Bold = True
            greyFont.Italic = True
            greyFont.RGBColor = Color.FromArgb(333365)
            rtf.SetFont(0, 3, greyFont)

            'Formatting last 4 characters
            Dim greenFont As IFont = workbook.CreateFont()
            greenFont.Bold = True
            greenFont.Italic = True
            greenFont.RGBColor = Color.Green
            rtf.SetFont(4, 7, greenFont)

            'Set column width
            worksheet.Columns(0).ColumnWidth = 30

            worksheet.UsedRange.AutofitRows()
            worksheet.UsedRange.AutofitColumns()
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

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InteractiveFeatures))
            Me.btnCreate = New System.Windows.Forms.Button
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.label2 = New System.Windows.Forms.Label
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.rdbExcel2010 = New System.Windows.Forms.RadioButton
            Me.rdbExcel2007 = New System.Windows.Forms.RadioButton
            Me.rdbExcel97 = New System.Windows.Forms.RadioButton
            Me.rdbExcel2013 = New System.Windows.Forms.RadioButton
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnCreate
            '
            Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCreate.BackColor = System.Drawing.Color.Transparent
            Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
            Me.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCreate.Location = New System.Drawing.Point(343, 166)
            Me.btnCreate.Name = "btnCreate"
            Me.btnCreate.Size = New System.Drawing.Size(85, 26)
            Me.btnCreate.TabIndex = 0
            Me.btnCreate.Text = "Create"
            Me.btnCreate.UseVisualStyleBackColor = False
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(66, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(372, 96)
            Me.pictureBox1.TabIndex = 63
            Me.pictureBox1.TabStop = False
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(0, 108)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(372, 48)
            Me.label2.TabIndex = 64
            Me.label2.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" & _
                "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" & _
                "nt."
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rdbExcel2013)
            Me.GroupBox1.Controls.Add(Me.rdbExcel2010)
            Me.GroupBox1.Controls.Add(Me.rdbExcel2007)
            Me.GroupBox1.Controls.Add(Me.rdbExcel97)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(12, 158)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(325, 37)
            Me.GroupBox1.TabIndex = 65
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Save As"
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
            Me.rdbExcel2013.Location = New System.Drawing.Point(241, 13)
            Me.rdbExcel2013.Name = "rdbExcel2013"
            Me.rdbExcel2013.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel2013.TabIndex = 3
            Me.rdbExcel2013.Text = "Excel 2013"
            Me.rdbExcel2013.UseVisualStyleBackColor = True
            '
            'PictureBox2
            '
            Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
            Me.PictureBox2.Location = New System.Drawing.Point(-8, -11)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(104, 96)
            Me.PictureBox2.TabIndex = 66
            Me.PictureBox2.TabStop = False
            '
            'InteractiveFeatures
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(436, 208)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.btnCreate)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "InteractiveFeatures"
            Me.Text = "Interactive Features"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
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
            Application.Run(New InteractiveFeatures())
        End Sub
#End Region
    End Class
End Namespace
