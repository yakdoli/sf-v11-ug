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
    Public Class FindAndExtract : Inherits System.Windows.Forms.Form
#Region "Constants"
        Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\{0}"
#End Region

#Region "Fields"
        Private txtDisplay As System.Windows.Forms.TextBox
        Private lblDisplay As System.Windows.Forms.Label
        Private label1 As System.Windows.Forms.Label
        Private txtValue As System.Windows.Forms.TextBox
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private lstFormat As System.Windows.Forms.ListBox
        Private WithEvents btnExtractData As System.Windows.Forms.Button
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Dim fileName As String = ""
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
            '
            ' TODO: Add any constructor code after InitializeComponent call
            ''
        End Sub
#End Region

#Region "Form Load"
        Private Sub FindAndExtract_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            lstFormat.SelectedIndex = 0
        End Sub
#End Region

#Region "Find and Extract Data"
        Private Sub btnExtractData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtractData.Click
            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()

            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel

            'Get the input file path
            Dim inputPath As String = GetFullTemplatePath("FindAndExtract.xls")

            'Open an existing spreadsheet which will be used as a template for generating the new spreadsheet.
            'After opening, the workbook object represents the complete in-memory object model of the template spreadsheet.
            Dim workbook As IWorkbook = application.Workbooks.Open(inputPath)

            'The first worksheet object in the worksheets collection is accessed.
            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            Dim result As IRange



            If lstFormat.SelectedItem.ToString() = "Number with format 0.00" Then

                result = worksheet.FindFirst(1000000.00075, ExcelFindType.Number)

                'Gets the cell display text
                txtDisplay.Text = result.DisplayText.ToString()

                'Gets the cell value
                txtValue.Text = result.Value2.ToString()

            End If

            If lstFormat.SelectedItem.ToString() = "Number with format $#,##0.00" Then

                result = worksheet.FindFirst(3.2, ExcelFindType.Number)

                'Gets the cell display text
                txtDisplay.Text = result.DisplayText.ToString()

                'Gets the cell value
                txtValue.Text = result.Value2.ToString()

            End If

            If lstFormat.SelectedItem.ToString() = "DateTime with format m/d/yy h:mm" Then

                result = worksheet.FindFirst(DateTime.Parse("12/1/2007  1:23:00 AM"))

                'Gets the cell display text
                txtDisplay.Text = result.DisplayText.ToString()

                'Gets the cell value
                txtValue.Text = result.Value2.ToString()

            End If

            If lstFormat.SelectedItem.ToString() = "Time with format h:mm:ss AM/PM" Then

                result = worksheet.FindFirst(DateTime.Parse("1/1/2007  2:23:00 AM"))

                'Gets the cell display text
                txtDisplay.Text = result.DisplayText.ToString()

                'Gets the cell value
                txtValue.Text = result.DateTime.ToString()

            End If
            If lstFormat.SelectedItem.ToString() = "Date with format d-mmm-yy" Then

                result = worksheet.FindFirst(DateTime.Parse("12/4/2007  1:23:00 AM"))

                'Gets the cell display text
                txtDisplay.Text = result.DisplayText.ToString()

                'Gets the cell value
                txtValue.Text = result.Value2.ToString()

            End If
            If lstFormat.SelectedItem.ToString() = "Date with format Saturday, December 01, 2007" Then

                result = worksheet.FindFirst(DateTime.Parse("8/1/2007  3:23:00 AM"))

                'Gets the cell display text
                txtDisplay.Text = result.DisplayText.ToString()

                'Gets the cell value
                txtValue.Text = result.Value2.ToString()

            End If

            If lstFormat.SelectedItem.ToString() = "Text" Then

                result = worksheet.FindFirst("Simple text", ExcelFindType.Text)

                'Gets the cell display text
                txtDisplay.Text = result.DisplayText.ToString()

                'Gets the cell value
                txtValue.Text = result.Value2.ToString()

            End If
            If lstFormat.SelectedItem.ToString() = "Text With Styles and Patterns" Then

                result = worksheet.FindFirst("Text with Styles and patterns", ExcelFindType.Text)

                'Gets the cell display text
                txtDisplay.Text = result.DisplayText.ToString()

                'Gets the cell value
                txtValue.Text = result.Value2.ToString()

            End If
            If lstFormat.SelectedItem.ToString() = "Number with Text Format" Then

                result = worksheet.FindFirst("$8.200", ExcelFindType.Text)

                'Gets the cell display text
                txtDisplay.Text = result.DisplayText.ToString()

                'Gets the cell value
                txtValue.Text = result.Value2.ToString()

            End If


            excelEngine.Dispose()
        End Sub
#End Region

#Region "HelperMethod"
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindAndExtract))
            Me.txtDisplay = New System.Windows.Forms.TextBox
            Me.lblDisplay = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.txtValue = New System.Windows.Forms.TextBox
            Me.lstFormat = New System.Windows.Forms.ListBox
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.btnExtractData = New System.Windows.Forms.Button
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.groupBox1.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtDisplay
            '
            Me.txtDisplay.Location = New System.Drawing.Point(113, 19)
            Me.txtDisplay.Name = "txtDisplay"
            Me.txtDisplay.Size = New System.Drawing.Size(168, 20)
            Me.txtDisplay.TabIndex = 2
            Me.txtDisplay.Text = " "
            '
            'lblDisplay
            '
            Me.lblDisplay.Location = New System.Drawing.Point(17, 25)
            Me.lblDisplay.Name = "lblDisplay"
            Me.lblDisplay.Size = New System.Drawing.Size(80, 23)
            Me.lblDisplay.TabIndex = 3
            Me.lblDisplay.Text = "Display Text"
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(17, 48)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(88, 23)
            Me.label1.TabIndex = 4
            Me.label1.Text = "Value in the Cell"
            '
            'txtValue
            '
            Me.txtValue.Location = New System.Drawing.Point(113, 45)
            Me.txtValue.Name = "txtValue"
            Me.txtValue.Size = New System.Drawing.Size(168, 20)
            Me.txtValue.TabIndex = 5
            Me.txtValue.Text = " "
            '
            'lstFormat
            '
            Me.lstFormat.Items.AddRange(New Object() {"Number with format 0.00", "Number with format $#,##0.00", "-------------------------------------------", "DateTime with format m/d/yy h:mm", "Time with format h:mm:ss AM/PM", "Date with format d-mmm-yy", "Date with format Saturday, December 01, 2007", "-----------------------------------------------", "Text", "Text With Styles and Patterns", "Number with Text Format"})
            Me.lstFormat.Location = New System.Drawing.Point(19, 119)
            Me.lstFormat.Name = "lstFormat"
            Me.lstFormat.Size = New System.Drawing.Size(200, 173)
            Me.lstFormat.TabIndex = 6
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.btnExtractData)
            Me.groupBox1.Controls.Add(Me.lblDisplay)
            Me.groupBox1.Controls.Add(Me.txtValue)
            Me.groupBox1.Controls.Add(Me.lstFormat)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Controls.Add(Me.txtDisplay)
            Me.groupBox1.Location = New System.Drawing.Point(12, 102)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(348, 312)
            Me.groupBox1.TabIndex = 7
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "FindAndExtract"
            '
            'btnExtractData
            '
            Me.btnExtractData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnExtractData.Image = CType(resources.GetObject("btnExtractData.Image"), System.Drawing.Image)
            Me.btnExtractData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExtractData.Location = New System.Drawing.Point(250, 266)
            Me.btnExtractData.Name = "btnExtractData"
            Me.btnExtractData.Size = New System.Drawing.Size(92, 26)
            Me.btnExtractData.TabIndex = 7
            Me.btnExtractData.Text = "Extract Data"
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(372, 96)
            Me.pictureBox1.TabIndex = 72
            Me.pictureBox1.TabStop = False
            '
            'FindAndExtract
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(372, 436)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.groupBox1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FindAndExtract"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Find and Extract"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
            Application.Run(New FindAndExtract())
        End Sub
#End Region

    End Class
End Namespace
