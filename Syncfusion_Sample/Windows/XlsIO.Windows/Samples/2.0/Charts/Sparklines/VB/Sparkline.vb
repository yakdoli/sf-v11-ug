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

Imports System.Drawing.Imaging
Imports System.Collections
Imports System.ComponentModel
Imports Syncfusion.XlsIO

Namespace EssentialXlsIOSamples
	''' <summary>
    ''' Summary description for Form Sparkline.
	''' </summary>
    Public Class Sparklines
        Inherits Form

#Region "Constants"
        Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\{0}"
#End Region

#Region "Fields"
        Private WithEvents btnCreate As Button
        Private pictureBox1 As PictureBox
        Private pictureBox4 As PictureBox
        Private label2 As Label


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
            '
        End Sub
#End Region

#Region "Create Sparkline"
        Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreate.Click
            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As New ExcelEngine()

            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel

            'Set the default version as Excel 2010;
            application.DefaultVersion = ExcelVersion.Excel2010

            Dim inputPath As String = GetTemplatePath("Sparkline.xlsx")

            'A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            'The new workbook will have 1 worksheet.
            Dim workbook As IWorkbook = application.Workbooks.Open(inputPath)

            'The first worksheet object in the worksheets collection is accessed.
            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            '			#Region "WholeSale Report"

            'A new Sparkline group is added to the sheet sparklinegroups
            Dim sparklineGroup As ISparklineGroup = worksheet.SparklineGroups.Add()

            'Set the Sparkline group type as line
            sparklineGroup.SparklineType = SparklineType.Line

            'Set to display the empty cell as line
            sparklineGroup.DisplayEmptyCellsAs = SparklineEmptyCells.Line

            'Sparkline group style properties
            sparklineGroup.ShowFirstPoint = True
            sparklineGroup.FirstPointColor = Color.Green
            sparklineGroup.ShowLastPoint = True
            sparklineGroup.LastPointColor = Color.DarkOrange
            sparklineGroup.ShowHighPoint = True
            sparklineGroup.HighPointColor = Color.DarkBlue
            sparklineGroup.ShowLowPoint = True
            sparklineGroup.LowPointColor = Color.DarkViolet
            sparklineGroup.ShowMarkers = True
            sparklineGroup.MarkersColor = Color.Black
            sparklineGroup.ShowNegativePoint = True
            sparklineGroup.NegativePointColor = Color.Red

            'set the line weight
            sparklineGroup.LineWeight = 0.3

            'The sparklines are added to the sparklinegroup.
            Dim sparklines As ISparklines = sparklineGroup.Add()

            'Set the Sparkline Datarange .
            Dim dataRange As IRange = worksheet.Range("D6:G17")
            'Set the Sparkline Reference range.
            Dim referenceRange As IRange = worksheet.Range("H6:H17")

            'Create a sparkline with the datarange and reference range.
            sparklines.Add(dataRange, referenceRange)



            '			#End Region

            '			#Region "Retail Trade"

            'A new Sparkline group is added to the sheet sparklinegroups
            sparklineGroup = worksheet.SparklineGroups.Add()

            'Set the Sparkline group type as column
            sparklineGroup.SparklineType = SparklineType.Column

            'Set to display the empty cell as zero
            sparklineGroup.DisplayEmptyCellsAs = SparklineEmptyCells.Zero

            'Sparkline group style properties
            sparklineGroup.ShowHighPoint = True
            sparklineGroup.HighPointColor = Color.Green
            sparklineGroup.ShowLowPoint = True
            sparklineGroup.LowPointColor = Color.Red
            sparklineGroup.ShowNegativePoint = True
            sparklineGroup.NegativePointColor = Color.Black

            'The sparklines are added to the sparklinegroup.
            sparklines = sparklineGroup.Add()

            'Set the Sparkline Datarange .
            dataRange = worksheet.Range("D21:G32")
            'Set the Sparkline Reference range.
            referenceRange = worksheet.Range("H21:H32")

            'Create a sparkline with the datarange and reference range.
            sparklines.Add(dataRange, referenceRange)

            '			#End Region

            '			#Region "Manufacturing Trade"

            'A new Sparkline group is added to the sheet sparklinegroups
            sparklineGroup = worksheet.SparklineGroups.Add()

            'Set the Sparkline group type as win/loss
            sparklineGroup.SparklineType = SparklineType.ColumnStacked100

            sparklineGroup.DisplayEmptyCellsAs = SparklineEmptyCells.Zero

            sparklineGroup.DisplayAxis = True
            sparklineGroup.AxisColor = Color.Black
            sparklineGroup.ShowFirstPoint = True
            sparklineGroup.FirstPointColor = Color.Green
            sparklineGroup.ShowLastPoint = True
            sparklineGroup.LastPointColor = Color.Orange
            sparklineGroup.ShowNegativePoint = True
            sparklineGroup.NegativePointColor = Color.Red

            sparklines = sparklineGroup.Add()

            dataRange = worksheet.Range("D36:G46")
            referenceRange = worksheet.Range("H36:H46")

            sparklines.Add(dataRange, referenceRange)

            '			#End Region

            'Saving the workbook to disk.
            workbook.SaveAs("SparklinesOutput.xlsx")

            'Close the workbook.
            workbook.Close()

            'No exception will be thrown if there are unsaved workbooks.
            excelEngine.ThrowNotSavedOnDestroy = False
            excelEngine.Dispose()

            'Message box confirmation to view the created spreadsheet.
            If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                Process.Start("SparklinesOutput.xlsx")
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
        Private Function GetTemplatePath(ByVal inputFile As String) As String
            Return String.Format(DEFAULTPATH, inputFile)
        End Function
#End Region

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sparklines))
            Me.btnCreate = New System.Windows.Forms.Button()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.pictureBox4 = New System.Windows.Forms.PictureBox()
            Me.label2 = New System.Windows.Forms.Label()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnCreate
            '
            Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCreate.BackColor = System.Drawing.Color.Transparent
            Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
            Me.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCreate.Location = New System.Drawing.Point(275, 165)
            Me.btnCreate.Name = "btnCreate"
            Me.btnCreate.Size = New System.Drawing.Size(85, 26)
            Me.btnCreate.TabIndex = 0
            Me.btnCreate.Text = "Create"
            Me.btnCreate.UseVisualStyleBackColor = False
            '
            'pictureBox1
            '
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(100, 50)
            Me.pictureBox1.TabIndex = 1
            Me.pictureBox1.TabStop = False
            '
            'pictureBox4
            '
            Me.pictureBox4.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox4.Image = CType(resources.GetObject("pictureBox4.Image"), System.Drawing.Image)
            Me.pictureBox4.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox4.Name = "pictureBox4"
            Me.pictureBox4.Size = New System.Drawing.Size(372, 96)
            Me.pictureBox4.TabIndex = 70
            Me.pictureBox4.TabStop = False
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(0, 109)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(372, 48)
            Me.label2.TabIndex = 71
            Me.label2.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" & _
                "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" & _
                "nt."
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Sparklines
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(372, 208)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox4)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.btnCreate)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Sparklines"
            Me.Text = "Sparklines"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Dispose"

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
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
            Application.Run(New Sparklines())
        End Sub
#End Region

    End Class
End Namespace
