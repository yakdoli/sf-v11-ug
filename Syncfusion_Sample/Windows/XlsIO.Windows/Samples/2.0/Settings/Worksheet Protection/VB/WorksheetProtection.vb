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
    Public Class WorksheetProtection : Inherits System.Windows.Forms.Form

#Region "Fields"
        Private WithEvents btnWorksheetLock As System.Windows.Forms.Button
        Private WithEvents btnWorksheetUnlock As System.Windows.Forms.Button
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents label2 As System.Windows.Forms.Label

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

#Region "Protect the Worksheet"
        Private Sub btnWorksheetLock_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnWorksheetLock.Click
            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()
            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel

            ' Opening the Existing Worksheet from a Workbook
            Dim workbook As IWorkbook = application.Workbooks.Create(1)
            'The first worksheet object in the worksheets collection is accessed.
            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            worksheet.Range("C5").Text = "Worksheet protected with password 'syncfusion'"
            worksheet.Range("C6").Text = "You can't edit any cells other than A1 and A2"
            worksheet.Range("C5").CellStyle.Font.Bold = True
            worksheet.Range("C5").CellStyle.Font.Size = 12

            worksheet.Range("C6").CellStyle.Font.Bold = True
            worksheet.Range("C6").CellStyle.Font.Size = 12

            worksheet.Range("C8").Text = "Click 'Tools->Protection' to view the Protection settings."
            worksheet.Range("C8").CellStyle.Font.Bold = True
            worksheet.Range("C8").CellStyle.Font.Size = 12

            worksheet.Range("A1:A2").Text = "You can edit this cell"
            worksheet.Range("A1:A2").CellStyle.Font.Bold = True

            'Protecting Worksheet using Password
            worksheet.Protect("syncfusion")

            'Unlocking the cells which are needed to be edited
            worksheet.Range("A1").CellStyle.Locked = False
            worksheet.Range("A2").CellStyle.Locked = False


            'Saving the workbook to disk.
            workbook.SaveAs("ProtectedWorksheet.xls")

            btnWorksheetLock.Enabled = False
            btnWorksheetUnlock.Enabled = True

            'Close the workbook.
            workbook.Close()

            'No exception will be thrown if there are unsaved workbooks.
            excelEngine.ThrowNotSavedOnDestroy = False
            excelEngine.Dispose()

            'Message box confirmation to view the created spreadsheet.
            If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("ProtectedWorksheet.xls")
            End If

        End Sub
#End Region

#Region "Unprotect Worksheet"
        Private Sub btnWorksheetUnlock_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnWorksheetUnlock.Click
            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()
            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel

            ' Opening a Existing(Protected) Worksheet from a Workbook
            Dim workbook As IWorkbook = application.Workbooks.Open("ProtectedWorksheet.xls")
            'The first worksheet object in the worksheets collection is accessed.
            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            'Unprotecting( unlocking) Worksheet using the Password
            worksheet.Unprotect("syncfusion")

            worksheet.Range("C5").Text = "Worksheet is Unprotected with password 'syncfusion' and changes are done"
            worksheet.Range("C6").Text = "You can edit any cell"
            worksheet.Range("A1:A2").Text = " "

            worksheet.Range("C5").CellStyle.Font.Bold = True
            worksheet.Range("C5").CellStyle.Font.Size = 12

            worksheet.Range("C8").Text = "Click 'Tools->Protection' to view the Protection settings."
            worksheet.Range("C8").CellStyle.Font.Bold = True
            worksheet.Range("C8").CellStyle.Font.Size = 12

            'Saving the workbook to disk.
            workbook.SaveAs("UnlockedWorksheet.xls")

            'Close the workbook.
            workbook.Close()

            'No exception will be thrown if there are unsaved workbooks.
            excelEngine.ThrowNotSavedOnDestroy = False
            excelEngine.Dispose()

            'Message box confirmation to view the created spreadsheet.
            If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("UnlockedWorksheet.xls")
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WorksheetProtection))
            Me.btnWorksheetLock = New System.Windows.Forms.Button
            Me.btnWorksheetUnlock = New System.Windows.Forms.Button
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.label2 = New System.Windows.Forms.Label
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'button1
            '
            Me.btnWorksheetLock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnWorksheetLock.BackColor = System.Drawing.Color.Transparent
            Me.btnWorksheetLock.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Image)
            Me.btnWorksheetLock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnWorksheetLock.Location = New System.Drawing.Point(26, 188)
            Me.btnWorksheetLock.Name = "button1"
            Me.btnWorksheetLock.Size = New System.Drawing.Size(144, 26)
            Me.btnWorksheetLock.TabIndex = 0
            Me.btnWorksheetLock.Text = "Worksheet Locking"
            Me.btnWorksheetLock.UseVisualStyleBackColor = False
            '
            'button2
            '
            Me.btnWorksheetUnlock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnWorksheetUnlock.BackColor = System.Drawing.Color.Transparent
            Me.btnWorksheetUnlock.Enabled = False
            Me.btnWorksheetUnlock.Image = CType(resources.GetObject("button2.Image"), System.Drawing.Image)
            Me.btnWorksheetUnlock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnWorksheetUnlock.Location = New System.Drawing.Point(176, 188)
            Me.btnWorksheetUnlock.Name = "button2"
            Me.btnWorksheetUnlock.Size = New System.Drawing.Size(152, 26)
            Me.btnWorksheetUnlock.TabIndex = 2
            Me.btnWorksheetUnlock.Text = "Worksheet Unlocking"
            Me.btnWorksheetUnlock.UseVisualStyleBackColor = False
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
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
            Me.label2.Size = New System.Drawing.Size(372, 48)
            Me.label2.TabIndex = 64
            Me.label2.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" & _
                "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" & _
                "nt."
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(372, 226)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.btnWorksheetUnlock)
            Me.Controls.Add(Me.btnWorksheetLock)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Worksheet Protection"
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
            Application.Run(New WorksheetProtection())
        End Sub
#End Region

    End Class
End Namespace
