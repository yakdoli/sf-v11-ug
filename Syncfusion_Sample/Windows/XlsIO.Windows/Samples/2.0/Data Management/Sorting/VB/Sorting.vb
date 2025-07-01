Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Syncfusion.XlsIO
Imports System.ComponentModel

Namespace EssentailXlsIOSample
    Public Class Sorting
        Inherits Form

#Region "Constants"
        Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\{0}"
#End Region

#Region "Fields"
        Private columnNames() As String = {"ID", "Name", "DOJ", "Salary"}
        Private excelEngine As ExcelEngine
        Private pictureBox1 As PictureBox
        Private pictureBox3 As PictureBox
        Private WithEvents chkAddThirdLevel As CheckBox
        Private grpThirdLevel As GroupBox
        Private label4 As Label
        Private WithEvents btnViewTemplate As Button
        Private cmbFirst As ComboBox
        Private cmbThird As ComboBox
        Private cmbSecond As ComboBox
        Private groupBox4 As GroupBox
        Private WithEvents btnSortColor As Button
        Private groupBox5 As GroupBox
        Private rdbOnBottom As RadioButton
        Private rdbOnTop As RadioButton
        Private WithEvents cmbSortOn As ComboBox
        Private label1 As Label
        Private orderBy As OrderBy
        Private sortOn As SortOn

        Private groupBox1 As System.Windows.Forms.GroupBox
        Private groupBox2 As System.Windows.Forms.GroupBox
        Private label3 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private WithEvents chkAddSecondLevel As System.Windows.Forms.CheckBox
        Private grpSecondLevel As System.Windows.Forms.GroupBox
        Private WithEvents btnSortValues As System.Windows.Forms.Button
        Private groupBox3 As System.Windows.Forms.GroupBox
        Private rdbDescending As System.Windows.Forms.RadioButton
        Private rdbAscending As System.Windows.Forms.RadioButton

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing
#End Region

#Region "Initialize"
        Public Sub New()
            InitializeComponent()
            excelEngine = New ExcelEngine()
            orderBy = orderBy.Ascending
            rdbAscending.Checked = True
            cmbFirst.Items.AddRange(columnNames)
            cmbSecond.Items.AddRange(columnNames)
            cmbThird.Items.AddRange(columnNames)
            cmbSortOn.SelectedIndex = 0
            sortOn = sortOn.CellColor
            cmbFirst.SelectedIndex = 0

        End Sub
#End Region

#Region "Sorting"

#Region "Value Based Sort"
        Private Sub btnSortValues_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSortValues.Click
            If (rdbAscending.Checked) Then
                orderBy = orderBy.Ascending
            Else
                orderBy = orderBy.Descending
            End If
            SortValues("ValueSort.xlsx")
            OpenOutput("ValueSort.xlsx")
        End Sub
#End Region

#Region "Color Based Sort"
        Private Sub btnSortColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSortColor.Click
            If (rdbOnTop.Checked) Then
                orderBy = orderBy.OnTop
            Else
                orderBy = orderBy.OnBottom
            End If

            SortColor("ColorSort.xlsx")
            OpenOutput("ColorSort.xlsx")
        End Sub
#End Region

#Region "View the Input Template"
        Private Sub btnViewTemplate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnViewTemplate.Click
            'Get the path of the Input File
            Dim inputPath As String = GetFullTemplatePath("SortingData.xlsx")
            'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start(inputPath)
        End Sub
#End Region

#Region "Set the Second Level Visibilty (Based on Value Type)"
        Private Sub chkAddSecondLevel_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAddSecondLevel.CheckedChanged
            grpSecondLevel.Visible = chkAddSecondLevel.Checked
            chkAddThirdLevel.Visible = chkAddSecondLevel.Checked

        End Sub
#End Region

#Region "Set the Third Level Visiblity (Based on Value Type)"
        Private Sub chkAddThirdLevel_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAddThirdLevel.CheckedChanged
            grpThirdLevel.Visible = chkAddThirdLevel.Checked
        End Sub
#End Region

#Region "Setting the Sort type (Based on Color Type)"
        Private Sub cmbSortOn_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbSortOn.SelectedIndexChanged
            If (cmbSortOn.SelectedIndex = 0) Then
                sortOn = sortOn.CellColor
            Else
                sortOn = sortOn.FontColor
            End If

        End Sub
#End Region

#Region "Dispose the Excel Engine"
        Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            excelEngine.Dispose()
        End Sub
#End Region

#End Region

#Region "Helper Methods"

#Region "Get the Path of the Input File"
        ''' <summary>
        ''' Return the file path of the Input file
        ''' </summary>
        Private Function GetFullTemplatePath(ByVal inputFile As String) As String
            Return String.Format(DEFAULTPATH, inputFile)
        End Function
#End Region

#Region "Method for Sorting using Color"
        Private Sub SortColor(ByVal outFileName As String)
            'Get the Path of the Input File
            Dim inputPath As String = GetFullTemplatePath("SortingData.xlsx")

            'Workbook Initialize
            Dim workbook As IWorkbook = excelEngine.Excel.Workbooks.Open(inputPath, ExcelOpenType.Automatic)
            Dim worksheet As IWorksheet = workbook.Worksheets(1)

            'Sorting based on color

            Dim range As IRange = worksheet("A2:C50")
            'Create Data sorter
            Dim sorter As IDataSort = workbook.CreateDataSorter()
            sorter.SortRange = range
            'Specify the sort field attributes
            Dim field As ISortField = sorter.SortFields.Add(2, sortOn, orderBy)
            field.Color = Color.Red
            field = sorter.SortFields.Add(2, sortOn, orderBy)
            field.Color = Color.Blue
            'sort the data based on the sort field attributes.
            sorter.Sort()

            'Remove Worksheet
            workbook.Worksheets.Remove(0)
            'Save the Workbook
            workbook.SaveAs(outFileName)
            'Close the Workbook
            workbook.Close()

        End Sub
#End Region

#Region "Method for Sorting using Values"
        Private Sub SortValues(ByVal outFileName As String)
            'Get the Path of the Input File
            Dim inputPath As String = GetFullTemplatePath("SortingData.xlsx")

            'Workbook Initialize
            Dim workbook As IWorkbook = excelEngine.Excel.Workbooks.Open(inputPath, ExcelOpenType.Automatic)
            Dim worksheet As IWorksheet = workbook.Worksheets(0)
            Dim range As IRange = worksheet("A2:D51")

            'Create the data sorter.
            Dim sorter As IDataSort = workbook.CreateDataSorter()
            'Specify the range to sort.
            sorter.SortRange = range

            'Specify the sort field attributes (column index and sort order)
            Dim field As ISortField = sorter.SortFields.Add(CInt(Fix(cmbFirst.SelectedIndex)), sortOn.Values, orderBy)


            If chkAddSecondLevel.Checked Then
                field = sorter.SortFields.Add(CInt(Fix(cmbSecond.SelectedIndex)), sortOn.Values, orderBy)
            End If

            If chkAddThirdLevel.Checked Then
                field = sorter.SortFields.Add(CInt(Fix(cmbThird.SelectedIndex)), sortOn.Values, orderBy)
            End If

            'sort the data based on the sort field attributes.
            sorter.Sort()
            workbook.Worksheets.Remove(1)
            workbook.SaveAs(outFileName)
            workbook.Close()

        End Sub
#End Region

#Region "Open the Output File"
        Private Sub OpenOutput(ByVal fileName As String)
            ' Message box confirmation to view the created document.
            If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                Try
                    'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start(fileName)

                    'Exit
                    Me.Close()
                Catch ex As Win32Exception
                    MessageBox.Show("Excel 2007 is not installed in this system")
                    Console.WriteLine(ex.ToString())
                End Try
            Else
                Me.Close()
            End If
        End Sub
#End Region

#End Region

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sorting))
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.groupBox4 = New System.Windows.Forms.GroupBox
            Me.cmbSortOn = New System.Windows.Forms.ComboBox
            Me.label1 = New System.Windows.Forms.Label
            Me.btnSortColor = New System.Windows.Forms.Button
            Me.groupBox5 = New System.Windows.Forms.GroupBox
            Me.rdbOnBottom = New System.Windows.Forms.RadioButton
            Me.rdbOnTop = New System.Windows.Forms.RadioButton
            Me.btnViewTemplate = New System.Windows.Forms.Button
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.cmbFirst = New System.Windows.Forms.ComboBox
            Me.groupBox3 = New System.Windows.Forms.GroupBox
            Me.rdbDescending = New System.Windows.Forms.RadioButton
            Me.rdbAscending = New System.Windows.Forms.RadioButton
            Me.chkAddThirdLevel = New System.Windows.Forms.CheckBox
            Me.btnSortValues = New System.Windows.Forms.Button
            Me.grpThirdLevel = New System.Windows.Forms.GroupBox
            Me.cmbThird = New System.Windows.Forms.ComboBox
            Me.label4 = New System.Windows.Forms.Label
            Me.chkAddSecondLevel = New System.Windows.Forms.CheckBox
            Me.grpSecondLevel = New System.Windows.Forms.GroupBox
            Me.cmbSecond = New System.Windows.Forms.ComboBox
            Me.label3 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.pictureBox3 = New System.Windows.Forms.PictureBox
            Me.groupBox1.SuspendLayout()
            Me.groupBox4.SuspendLayout()
            Me.groupBox5.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.groupBox3.SuspendLayout()
            Me.grpThirdLevel.SuspendLayout()
            Me.grpSecondLevel.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.groupBox4)
            Me.groupBox1.Controls.Add(Me.btnViewTemplate)
            Me.groupBox1.Controls.Add(Me.groupBox2)
            Me.groupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(0, 100)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(424, 369)
            Me.groupBox1.TabIndex = 0
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Sorting"
            '
            'groupBox4
            '
            Me.groupBox4.Controls.Add(Me.cmbSortOn)
            Me.groupBox4.Controls.Add(Me.label1)
            Me.groupBox4.Controls.Add(Me.btnSortColor)
            Me.groupBox4.Controls.Add(Me.groupBox5)
            Me.groupBox4.Location = New System.Drawing.Point(9, 245)
            Me.groupBox4.Name = "groupBox4"
            Me.groupBox4.Size = New System.Drawing.Size(406, 91)
            Me.groupBox4.TabIndex = 5
            Me.groupBox4.TabStop = False
            Me.groupBox4.Text = "Sort Based on Colors"
            '
            'cmbSortOn
            '
            Me.cmbSortOn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbSortOn.FormattingEnabled = True
            Me.cmbSortOn.Items.AddRange(New Object() {"CellColor", "FontColor"})
            Me.cmbSortOn.Location = New System.Drawing.Point(276, 25)
            Me.cmbSortOn.Name = "cmbSortOn"
            Me.cmbSortOn.Size = New System.Drawing.Size(121, 21)
            Me.cmbSortOn.TabIndex = 4
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(208, 28)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(49, 13)
            Me.label1.TabIndex = 3
            Me.label1.Text = "Sort On"
            '
            'btnSortColor
            '
            Me.btnSortColor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSortColor.Location = New System.Drawing.Point(315, 63)
            Me.btnSortColor.Name = "btnSortColor"
            Me.btnSortColor.Size = New System.Drawing.Size(82, 23)
            Me.btnSortColor.TabIndex = 2
            Me.btnSortColor.Text = "Sort Colors"
            Me.btnSortColor.UseVisualStyleBackColor = True
            '
            'groupBox5
            '
            Me.groupBox5.Controls.Add(Me.rdbOnBottom)
            Me.groupBox5.Controls.Add(Me.rdbOnTop)
            Me.groupBox5.Location = New System.Drawing.Point(9, 20)
            Me.groupBox5.Name = "groupBox5"
            Me.groupBox5.Size = New System.Drawing.Size(132, 66)
            Me.groupBox5.TabIndex = 0
            Me.groupBox5.TabStop = False
            Me.groupBox5.Text = "Order By"
            '
            'rdbOnBottom
            '
            Me.rdbOnBottom.AutoSize = True
            Me.rdbOnBottom.Location = New System.Drawing.Point(6, 43)
            Me.rdbOnBottom.Name = "rdbOnBottom"
            Me.rdbOnBottom.Size = New System.Drawing.Size(82, 17)
            Me.rdbOnBottom.TabIndex = 1
            Me.rdbOnBottom.TabStop = True
            Me.rdbOnBottom.Text = "OnBottom"
            Me.rdbOnBottom.UseVisualStyleBackColor = True
            '
            'rdbOnTop
            '
            Me.rdbOnTop.AutoSize = True
            Me.rdbOnTop.Checked = True
            Me.rdbOnTop.Location = New System.Drawing.Point(6, 20)
            Me.rdbOnTop.Name = "rdbOnTop"
            Me.rdbOnTop.Size = New System.Drawing.Size(61, 17)
            Me.rdbOnTop.TabIndex = 0
            Me.rdbOnTop.TabStop = True
            Me.rdbOnTop.Text = "OnTop"
            Me.rdbOnTop.UseVisualStyleBackColor = True
            '
            'btnViewTemplate
            '
            Me.btnViewTemplate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnViewTemplate.Location = New System.Drawing.Point(305, 342)
            Me.btnViewTemplate.Name = "btnViewTemplate"
            Me.btnViewTemplate.Size = New System.Drawing.Size(100, 25)
            Me.btnViewTemplate.TabIndex = 4
            Me.btnViewTemplate.Text = "Input Template"
            Me.btnViewTemplate.UseVisualStyleBackColor = True
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.cmbFirst)
            Me.groupBox2.Controls.Add(Me.groupBox3)
            Me.groupBox2.Controls.Add(Me.chkAddThirdLevel)
            Me.groupBox2.Controls.Add(Me.btnSortValues)
            Me.groupBox2.Controls.Add(Me.grpThirdLevel)
            Me.groupBox2.Controls.Add(Me.chkAddSecondLevel)
            Me.groupBox2.Controls.Add(Me.grpSecondLevel)
            Me.groupBox2.Controls.Add(Me.label2)
            Me.groupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox2.Location = New System.Drawing.Point(6, 20)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(409, 219)
            Me.groupBox2.TabIndex = 0
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Sort Based on Values"
            '
            'cmbFirst
            '
            Me.cmbFirst.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbFirst.FormattingEnabled = True
            Me.cmbFirst.Location = New System.Drawing.Point(255, 20)
            Me.cmbFirst.Name = "cmbFirst"
            Me.cmbFirst.Size = New System.Drawing.Size(65, 21)
            Me.cmbFirst.TabIndex = 10
            '
            'groupBox3
            '
            Me.groupBox3.Controls.Add(Me.rdbDescending)
            Me.groupBox3.Controls.Add(Me.rdbAscending)
            Me.groupBox3.Location = New System.Drawing.Point(6, 146)
            Me.groupBox3.Name = "groupBox3"
            Me.groupBox3.Size = New System.Drawing.Size(154, 64)
            Me.groupBox3.TabIndex = 3
            Me.groupBox3.TabStop = False
            Me.groupBox3.Text = "OrderBy"
            '
            'rdbDescending
            '
            Me.rdbDescending.AutoSize = True
            Me.rdbDescending.Location = New System.Drawing.Point(6, 36)
            Me.rdbDescending.Name = "rdbDescending"
            Me.rdbDescending.Size = New System.Drawing.Size(90, 17)
            Me.rdbDescending.TabIndex = 1
            Me.rdbDescending.TabStop = True
            Me.rdbDescending.Text = "Descending"
            Me.rdbDescending.UseVisualStyleBackColor = True
            '
            'rdbAscending
            '
            Me.rdbAscending.AutoSize = True
            Me.rdbAscending.Location = New System.Drawing.Point(6, 13)
            Me.rdbAscending.Name = "rdbAscending"
            Me.rdbAscending.Size = New System.Drawing.Size(83, 17)
            Me.rdbAscending.TabIndex = 0
            Me.rdbAscending.TabStop = True
            Me.rdbAscending.Text = "Ascending"
            Me.rdbAscending.UseVisualStyleBackColor = True
            '
            'chkAddThirdLevel
            '
            Me.chkAddThirdLevel.AutoSize = True
            Me.chkAddThirdLevel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkAddThirdLevel.Location = New System.Drawing.Point(333, 61)
            Me.chkAddThirdLevel.Name = "chkAddThirdLevel"
            Me.chkAddThirdLevel.Size = New System.Drawing.Size(73, 17)
            Me.chkAddThirdLevel.TabIndex = 9
            Me.chkAddThirdLevel.Text = "Add Level"
            Me.chkAddThirdLevel.UseVisualStyleBackColor = True
            Me.chkAddThirdLevel.Visible = False
            '
            'btnSortValues
            '
            Me.btnSortValues.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSortValues.Location = New System.Drawing.Point(318, 179)
            Me.btnSortValues.Name = "btnSortValues"
            Me.btnSortValues.Size = New System.Drawing.Size(85, 23)
            Me.btnSortValues.TabIndex = 2
            Me.btnSortValues.Text = "Sort Values"
            Me.btnSortValues.UseVisualStyleBackColor = True
            '
            'grpThirdLevel
            '
            Me.grpThirdLevel.Controls.Add(Me.cmbThird)
            Me.grpThirdLevel.Controls.Add(Me.label4)
            Me.grpThirdLevel.Location = New System.Drawing.Point(6, 92)
            Me.grpThirdLevel.Name = "grpThirdLevel"
            Me.grpThirdLevel.Size = New System.Drawing.Size(322, 48)
            Me.grpThirdLevel.TabIndex = 8
            Me.grpThirdLevel.TabStop = False
            Me.grpThirdLevel.Text = "Level"
            Me.grpThirdLevel.Visible = False
            '
            'cmbThird
            '
            Me.cmbThird.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbThird.FormattingEnabled = True
            Me.cmbThird.Location = New System.Drawing.Point(249, 17)
            Me.cmbThird.Name = "cmbThird"
            Me.cmbThird.Size = New System.Drawing.Size(65, 21)
            Me.cmbThird.TabIndex = 1
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(3, 20)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(224, 13)
            Me.label4.TabIndex = 0
            Me.label4.Text = "Choose the thrird column index to sort"
            '
            'chkAddSecondLevel
            '
            Me.chkAddSecondLevel.AutoSize = True
            Me.chkAddSecondLevel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkAddSecondLevel.Location = New System.Drawing.Point(333, 24)
            Me.chkAddSecondLevel.Name = "chkAddSecondLevel"
            Me.chkAddSecondLevel.Size = New System.Drawing.Size(70, 17)
            Me.chkAddSecondLevel.TabIndex = 7
            Me.chkAddSecondLevel.Text = "AddLevel"
            Me.chkAddSecondLevel.UseVisualStyleBackColor = True
            '
            'grpSecondLevel
            '
            Me.grpSecondLevel.Controls.Add(Me.cmbSecond)
            Me.grpSecondLevel.Controls.Add(Me.label3)
            Me.grpSecondLevel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grpSecondLevel.Location = New System.Drawing.Point(6, 47)
            Me.grpSecondLevel.Name = "grpSecondLevel"
            Me.grpSecondLevel.Size = New System.Drawing.Size(322, 45)
            Me.grpSecondLevel.TabIndex = 6
            Me.grpSecondLevel.TabStop = False
            Me.grpSecondLevel.Text = "Level"
            Me.grpSecondLevel.Visible = False
            '
            'cmbSecond
            '
            Me.cmbSecond.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbSecond.FormattingEnabled = True
            Me.cmbSecond.Location = New System.Drawing.Point(249, 14)
            Me.cmbSecond.Name = "cmbSecond"
            Me.cmbSecond.Size = New System.Drawing.Size(65, 21)
            Me.cmbSecond.TabIndex = 5
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(3, 17)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(236, 13)
            Me.label3.TabIndex = 4
            Me.label3.Text = "Choose the Second column index to sort."
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(6, 23)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(219, 13)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Choose the First column Index to sort"
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(68, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(365, 96)
            Me.pictureBox1.TabIndex = 72
            Me.pictureBox1.TabStop = False
            '
            'pictureBox3
            '
            Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
            Me.pictureBox3.Location = New System.Drawing.Point(0, -11)
            Me.pictureBox3.Name = "pictureBox3"
            Me.pictureBox3.Size = New System.Drawing.Size(413, 96)
            Me.pictureBox3.TabIndex = 74
            Me.pictureBox3.TabStop = False
            '
            'Sorting
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(430, 470)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.pictureBox3)
            Me.Controls.Add(Me.groupBox1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Sorting"
            Me.Text = "Sorting"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox4.ResumeLayout(False)
            Me.groupBox4.PerformLayout()
            Me.groupBox5.ResumeLayout(False)
            Me.groupBox5.PerformLayout()
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            Me.groupBox3.ResumeLayout(False)
            Me.groupBox3.PerformLayout()
            Me.grpThirdLevel.ResumeLayout(False)
            Me.grpThirdLevel.PerformLayout()
            Me.grpSecondLevel.ResumeLayout(False)
            Me.grpSecondLevel.PerformLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

#Region "Dispose"
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Sorting())
        End Sub
#End Region

    End Class
End Namespace
