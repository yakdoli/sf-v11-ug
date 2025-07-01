#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Globalization
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Calculate
Imports Syncfusion.XlsIO


Namespace XlsFileUsingExcelRW
    
   
   Public Class Form1
      Inherits System.Windows.Forms.Form
      
      Private components As System.ComponentModel.Container = Nothing
      
      
      Public Sub New()
         '
         ' Required for Windows Form Designer support.
            '
            Application.EnableVisualStyles()
            InitializeComponent()
            Try
                Dim ico As Icon = New Icon(FindFile("Icon", "sfgrid.ico"))
                Me.Icon = ico
            Catch
            End Try
      End Sub 'New
       
      
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub 'Dispose

#Region "FindFile Utility"
        ''' <summary>
        ''' Finds a file of the given name in the current directory or sibling "Data" directory.
        ''' If file is not found, the parent folder is checked until the file is found. This method
        ''' is used by our samples when they load data from a separate "Data" folder.
        ''' </summary>
        ''' <param name="dataDirName">The name of the "Data" folder.</param>
        ''' <param name="fileName">The filename to be searched.</param>
        ''' <returns>The full path of the file that was found; an empty string is returned if file is not found.</returns>

        Public Shared Function FindFile(ByVal dataDirName As String, ByVal fileName As String) As String
            dataDirName = dataDirName.TrimEnd("\"c, "/"c)
            ' Check both in parent folder and Parent\Data folders.
            Dim dataFileName As String = dataDirName & "\" & fileName
            Dim n As Integer
            For n = 0 To 9
                If System.IO.File.Exists(fileName) Then
                    Return fileName
                End If
                If System.IO.File.Exists(dataFileName) Then
                    Return dataFileName
                End If
                fileName = "..\" & fileName
                dataFileName = "..\" & dataFileName
            Next n

            Return ""
        End Function
#End Region


#Region "Windows Form Designer generated code"

        '/ <summary>
        '/ Required method for Designer support; do not modify
        '/ the contents of this method with the code editor.
        '/ </summary>
        Private Sub InitializeComponent()
            Me.label1 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.label8 = New System.Windows.Forms.Label
            Me.numericUpDownAge = New System.Windows.Forms.NumericUpDown
            Me.numericUpDownPoints = New System.Windows.Forms.NumericUpDown
            Me.comboBoxSex = New System.Windows.Forms.ComboBox
            Me.button1 = New System.Windows.Forms.Button
            Me.comboBoxState = New System.Windows.Forms.ComboBox
            Me.comboBoxModel = New System.Windows.Forms.ComboBox
            Me.numericUpDownModelYear = New System.Windows.Forms.NumericUpDown
            Me.checkBoxMultipleCars = New System.Windows.Forms.CheckBox
            Me.textBoxBaseAmount = New System.Windows.Forms.TextBox
            Me.labelPrice = New System.Windows.Forms.Label
            Me.button2 = New System.Windows.Forms.Button
            CType(Me.numericUpDownAge, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDownPoints, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDownModelYear, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(52, 16)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(100, 23)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Age"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label2
            '
            Me.label2.Location = New System.Drawing.Point(52, 48)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(100, 23)
            Me.label2.TabIndex = 1
            Me.label2.Text = "Sex"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label3
            '
            Me.label3.Location = New System.Drawing.Point(52, 80)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(100, 23)
            Me.label3.TabIndex = 2
            Me.label3.Text = "State"
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label4
            '
            Me.label4.Location = New System.Drawing.Point(52, 112)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(100, 23)
            Me.label4.TabIndex = 3
            Me.label4.Text = "Points"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label5
            '
            Me.label5.Location = New System.Drawing.Point(52, 144)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(100, 23)
            Me.label5.TabIndex = 4
            Me.label5.Text = "Model"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label6
            '
            Me.label6.Location = New System.Drawing.Point(52, 176)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(100, 23)
            Me.label6.TabIndex = 5
            Me.label6.Text = "Model Year"
            Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label7
            '
            Me.label7.Location = New System.Drawing.Point(16, 208)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(136, 23)
            Me.label7.TabIndex = 6
            Me.label7.Text = "Discount for multiple cars"
            Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label8
            '
            Me.label8.Location = New System.Drawing.Point(52, 240)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(100, 23)
            Me.label8.TabIndex = 7
            Me.label8.Text = "Base Amount"
            Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numericUpDownAge
            '
            Me.numericUpDownAge.Location = New System.Drawing.Point(168, 16)
            Me.numericUpDownAge.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
            Me.numericUpDownAge.Minimum = New Decimal(New Integer() {15, 0, 0, 0})
            Me.numericUpDownAge.Name = "numericUpDownAge"
            Me.numericUpDownAge.Size = New System.Drawing.Size(48, 20)
            Me.numericUpDownAge.TabIndex = 9
            Me.numericUpDownAge.Value = New Decimal(New Integer() {15, 0, 0, 0})
            '
            'numericUpDownPoints
            '
            Me.numericUpDownPoints.Location = New System.Drawing.Point(168, 112)
            Me.numericUpDownPoints.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
            Me.numericUpDownPoints.Name = "numericUpDownPoints"
            Me.numericUpDownPoints.Size = New System.Drawing.Size(48, 20)
            Me.numericUpDownPoints.TabIndex = 10
            '
            'comboBoxSex
            '
            Me.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxSex.Items.AddRange(New Object() {"Male", "Female"})
            Me.comboBoxSex.Location = New System.Drawing.Point(168, 48)
            Me.comboBoxSex.Name = "comboBoxSex"
            Me.comboBoxSex.Size = New System.Drawing.Size(64, 21)
            Me.comboBoxSex.TabIndex = 11
            '
            'button1
            '
            Me.button1.BackColor = System.Drawing.SystemColors.Control
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button1.Location = New System.Drawing.Point(296, 40)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(184, 23)
            Me.button1.TabIndex = 12
            Me.button1.Text = "Compute Annual Premium"
            Me.button1.UseVisualStyleBackColor = False
            '
            'comboBoxState
            '
            Me.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxState.Items.AddRange(New Object() {"AL", "AK", "AZ", "AK", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KA", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", " WA", "WV", "WI", "WY"})
            Me.comboBoxState.Location = New System.Drawing.Point(168, 80)
            Me.comboBoxState.Name = "comboBoxState"
            Me.comboBoxState.Size = New System.Drawing.Size(64, 21)
            Me.comboBoxState.TabIndex = 13
            '
            'comboBoxModel
            '
            Me.comboBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxModel.Items.AddRange(New Object() {"Ford", "Chevrolet", "Buick", "Toyota", "BMW", "Mercedes", "Honda", "Hundai", "Mitsubishu", "Cadilac", "Lexis"})
            Me.comboBoxModel.Location = New System.Drawing.Point(168, 144)
            Me.comboBoxModel.Name = "comboBoxModel"
            Me.comboBoxModel.Size = New System.Drawing.Size(80, 21)
            Me.comboBoxModel.TabIndex = 14
            '
            'numericUpDownModelYear
            '
            Me.numericUpDownModelYear.Location = New System.Drawing.Point(168, 176)
            Me.numericUpDownModelYear.Maximum = New Decimal(New Integer() {2005, 0, 0, 0})
            Me.numericUpDownModelYear.Minimum = New Decimal(New Integer() {1972, 0, 0, 0})
            Me.numericUpDownModelYear.Name = "numericUpDownModelYear"
            Me.numericUpDownModelYear.Size = New System.Drawing.Size(48, 20)
            Me.numericUpDownModelYear.TabIndex = 15
            Me.numericUpDownModelYear.Value = New Decimal(New Integer() {2004, 0, 0, 0})
            '
            'checkBoxMultipleCars
            '
            Me.checkBoxMultipleCars.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBoxMultipleCars.Location = New System.Drawing.Point(168, 208)
            Me.checkBoxMultipleCars.Name = "checkBoxMultipleCars"
            Me.checkBoxMultipleCars.Size = New System.Drawing.Size(16, 24)
            Me.checkBoxMultipleCars.TabIndex = 16
            '
            'textBoxBaseAmount
            '
            Me.textBoxBaseAmount.Location = New System.Drawing.Point(168, 240)
            Me.textBoxBaseAmount.Name = "textBoxBaseAmount"
            Me.textBoxBaseAmount.Size = New System.Drawing.Size(48, 20)
            Me.textBoxBaseAmount.TabIndex = 17
            Me.textBoxBaseAmount.Text = "600"
            '
            'labelPrice
            '
            Me.labelPrice.Location = New System.Drawing.Point(320, 80)
            Me.labelPrice.Name = "labelPrice"
            Me.labelPrice.Size = New System.Drawing.Size(128, 64)
            Me.labelPrice.TabIndex = 18
            '
            'button2
            '
            Me.button2.BackColor = System.Drawing.SystemColors.Control
            Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button2.Location = New System.Drawing.Point(296, 160)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(184, 23)
            Me.button2.TabIndex = 19
            Me.button2.Text = "Auto Process with Random Inputs"
            Me.button2.UseVisualStyleBackColor = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(246, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(512, 294)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.labelPrice)
            Me.Controls.Add(Me.textBoxBaseAmount)
            Me.Controls.Add(Me.checkBoxMultipleCars)
            Me.Controls.Add(Me.numericUpDownModelYear)
            Me.Controls.Add(Me.comboBoxModel)
            Me.Controls.Add(Me.comboBoxState)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.comboBoxSex)
            Me.Controls.Add(Me.numericUpDownPoints)
            Me.Controls.Add(Me.numericUpDownAge)
            Me.Controls.Add(Me.label8)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label1)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Xls Using CalcEngine Demo"
            CType(Me.numericUpDownAge, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDownPoints, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDownModelYear, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub 'InitializeComponent 
#End Region




        Private label1 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private label4 As System.Windows.Forms.Label
        Private label5 As System.Windows.Forms.Label
        Private label6 As System.Windows.Forms.Label
        Private label7 As System.Windows.Forms.Label
        Private label8 As System.Windows.Forms.Label
        Private numericUpDownAge As System.Windows.Forms.NumericUpDown
        Private WithEvents button1 As System.Windows.Forms.Button
        Private comboBoxSex As System.Windows.Forms.ComboBox
        Private comboBoxState As System.Windows.Forms.ComboBox
        Private comboBoxModel As System.Windows.Forms.ComboBox
        Private numericUpDownModelYear As System.Windows.Forms.NumericUpDown
        Private checkBoxMultipleCars As System.Windows.Forms.CheckBox
        Private textBoxBaseAmount As System.Windows.Forms.TextBox
        Private labelPrice As System.Windows.Forms.Label
        Private numericUpDownPoints As System.Windows.Forms.NumericUpDown
        Private WithEvents button2 As System.Windows.Forms.Button


        Private calcWB As XlsIOCalcWorkbook


        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            calcWB = XlsIOCalcWorkbook.CreateFromXLS("..\..\CarIns.xls")

            Me.calcWB.Engine.LockDependencies = False
            Me.calcWB.CalculateAll()
            Me.calcWB.Engine.LockDependencies = True

            'Set some initial values on the form:
            Me.comboBoxSex.SelectedIndex = 0
            Me.comboBoxState.SelectedIndex = 0
            Me.comboBoxModel.SelectedIndex = 0

            If Environment.CommandLine.EndsWith("automatedtest") Then
                Me.button1.PerformClick()
            End If
        End Sub 'Form1_Load



        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            'Initialize calcsheet with input values from the form.
            SetSheetInputs()

            ' Calculations not suspended so just getting the value triggers the computation,
            ' so these two lines are not needed.....
            'this.calcWB.Engine.UpdateCalcID();
            'this.calcWB.Engine.PullUpdatedValue(this.calcWB.GetSheetID("Outputs"), 1, 1);
            'Get the value from cell 1,1 on the output sheet.
            Dim d As Double
            If Double.TryParse(calcWB("Outputs")(1, 1).ToString(), NumberStyles.Any, Nothing, d) Then
                'Cell 1,1 on the output sheet has the result.
                Me.labelPrice.Text = String.Format("{0:C2}", d)
            Else
                Me.labelPrice.Text = "---"
            End If
        End Sub 'button1_Click

        Private ageRow As Integer = 3
        Private sexRow As Integer = 4
        Private stateRow As Integer = 5
        Private pointsRow As Integer = 6
        Private modelRow As Integer = 7
        Private modelYearRow As Integer = 8
        Private multipleDiscountRow As Integer = 9


        'Set the input values into the CalcSheet:
        Private Sub SetSheetInputs()
            Dim inputSheet As CalcSheet = Me.calcWB("Inputs")
            inputSheet(ageRow, 2) = Me.numericUpDownAge.Value.ToString()
            inputSheet(sexRow, 2) = Me.comboBoxSex.Text.Substring(0, 1)
            inputSheet(stateRow, 2) = Me.comboBoxState.Text
            inputSheet(pointsRow, 2) = Me.numericUpDownPoints.Value.ToString()
            inputSheet(modelRow, 2) = Me.comboBoxModel.Text
            inputSheet(modelYearRow, 2) = Me.numericUpDownModelYear.Value.ToString()
            inputSheet(multipleDiscountRow, 2) = IIf(Me.checkBoxMultipleCars.Checked, "Yes", "No")
            inputSheet(3, 5) = Me.textBoxBaseAmount.Text
        End Sub 'SetSheetInputs


        'Do the calculations multiple times:
        Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
            'Run 1000 interations:
            Dim num As Integer = 1000

            Me.Cursor = Cursors.WaitCursor
            Dim start As DateTime = DateTime.Now
            Dim inputSheet As CalcSheet = Me.calcWB("Inputs")
            Dim r As New Random()

            Me.calcWB.Engine.CalculatingSuspended = True

            Dim i As Integer

            While i < num
                inputSheet(ageRow, 2) = (r.Next(74) + 15).ToString()
                inputSheet(sexRow, 2) = IIf(r.Next(2) = 1, "M", "F")
                inputSheet(stateRow, 2) = Me.comboBoxState.Items(r.Next(50))
                inputSheet(pointsRow, 2) = r.Next(15).ToString()
                inputSheet(modelRow, 2) = r.Next(11).ToString()
                inputSheet(modelYearRow, 2) = (33 + r.Next(1972)).ToString()
                inputSheet(multipleDiscountRow, 2) = IIf(r.Next(2) = 1, "Yes", "No")
                inputSheet(3, 5) = Me.textBoxBaseAmount.Text

                'Calculations are suspended so need to pull the computed value to
                'make sure it has been calculated with the latest changes.
                Me.calcWB.Engine.UpdateCalcID()
                Me.calcWB.Engine.PullUpdatedValue(Me.calcWB.GetSheetID("Outputs"), 1, 1)

                'Get the value from cell 1,1 on the output sheet.
                Dim d As Double
                If Double.TryParse(calcWB("Outputs")(1, 1).ToString(), NumberStyles.Any, Nothing, d) Then
                    Me.labelPrice.Text = String.Format("{0:C2}", d) 'Cell 1,1 on the output sheet has the result.
                Else
                    Me.labelPrice.Text = "---"
                End If
                'Allow the label to update:
                Application.DoEvents()
                i += 1
            End While

            Me.calcWB.Engine.CalculatingSuspended = False
            Me.Cursor = Cursors.Default
            Me.labelPrice.Text = String.Format("{0} updates in {1} seconds", num, CType(DateTime.op_Subtraction(DateTime.Now, start), TimeSpan))
        End Sub 'button2_Click
    End Class 'Form1
End Namespace 'XlsFileUsingExcelRW