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
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Calculate


 
Public Class SingleDataGridForm
   Inherits System.Windows.Forms.Form
   
   Private WithEvents textBox1 As System.Windows.Forms.TextBox
   Private WithEvents button1 As System.Windows.Forms.Button
   Private label1 As System.Windows.Forms.Label
   Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
   Private label2 As System.Windows.Forms.Label
   Private label3 As System.Windows.Forms.Label
    Private dataGrid1 As DataGrid
   Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    
   Private components As System.ComponentModel.Container = Nothing
   
   
   Public Sub New()
      '
      ' Required for Windows Form Designer support.
      '
        InitializeComponent()
        Try
            Dim ico As Icon = New Icon(StartUpForm.FindFile("Icon", "sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try
        Me.dataGrid1.FlatMode = True
   End Sub 'New
   
   
    
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support; do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.button1 = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.label2 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.dataGrid1 = New DataGrid
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBox1.Location = New System.Drawing.Point(440, 120)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(208, 20)
        Me.textBox1.TabIndex = 1
        '
        'button1
        '
        Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.Location = New System.Drawing.Point(504, 160)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 2
        Me.button1.Text = "Compute"
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.Location = New System.Drawing.Point(448, 200)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(200, 120)
        Me.label1.TabIndex = 3
        '
        'checkBox1
        '
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.checkBox1.Location = New System.Drawing.Point(24, 32)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(344, 24)
        Me.checkBox1.TabIndex = 5
        Me.checkBox1.Text = "Show any formulas in the DataGrid."
        '
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(24, 8)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(368, 24)
        Me.label2.TabIndex = 6
        Me.label2.Text = "Try entering formulas such as = A4 + B4 into a cell in this DataGrid."
        '
        'label3
        '
        Me.label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(440, 56)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(208, 56)
        Me.label3.TabIndex = 7
        Me.label3.Text = "Enter a formula based on DataGrid cells like = A1 + B2 + Cos(B1).             The" & _
            "n press Compute. "
        '
        'dataGrid1
        '
        Me.dataGrid1.AllowSorting = False
        Me.dataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGrid1.DataMember = ""
        Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataGrid1.Location = New System.Drawing.Point(24, 72)
        Me.dataGrid1.Name = "dataGrid1"
        Me.dataGrid1.Size = New System.Drawing.Size(368, 320)
        Me.dataGrid1.TabIndex = 8
        '
        'checkBox2
        '
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.checkBox2.Location = New System.Drawing.Point(448, 16)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(192, 24)
        Me.checkBox2.TabIndex = 9
        Me.checkBox2.Text = "SuspendCalculations"
        '
        'SingleDataGridForm
        '
        Me.AcceptButton = Me.button1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(696, 414)
        Me.Controls.Add(Me.checkBox2)
        Me.Controls.Add(Me.dataGrid1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.checkBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox1)
        Me.Name = "SingleDataGridForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Grid Calculator Demo"
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub 'InitializeComponent 
#End Region


#Region "Adding a formula to the formula library - step 1"


    'Adding formula to the CalcEngine Library:
    'Step 1: Code it with this signature:
    '			public string MyLibraryFormula(string args)
    '   return the computed value as a string...
    '   use the Engines public members as needed in your code.
    '   This sample computes the minimum of are arbitary range
    '     egs:		=Mymin(A1:C3)
    '				=mymin(a1,c2,a4,b2)
    Public Function ComputeMymin(ByVal args As String) As String
        'Assumes this.engine is the CalcEngine object:
        Dim min As Double = Double.MaxValue
        Dim d As Double
        Dim s1 As String

        Dim r As String
        For Each r In args.Split(New Char() {CalcEngine.ParseArgumentSeparator})
            If r.IndexOf(":"c) > -1 Then  'cell range
                Dim s As String
                For Each s In engine.GetCellsFromArgs(r)
                    's is a cell line a21 or c3...
                    Try
                        s1 = engine.GetValueFromArg(s)
                        If s1 <> "" AndAlso Double.TryParse(s1, System.Globalization.NumberStyles.Number, Nothing, d) Then
                            min = Math.Min(min, d)
                        End If
                    Catch ex As Exception
                        Return ex.Message
                    End Try
                Next s
            Else
                Try
                    s1 = engine.GetValueFromArg(r)
                    If s1 <> "" AndAlso Double.TryParse(s1, System.Globalization.NumberStyles.Number, Nothing, d) Then
                        min = Math.Min(min, d)
                    End If
                Catch ex As Exception
                    Return ex.Message
                End Try
            End If
        Next r
        If min <> Double.MaxValue Then
            Return min.ToString()
        End If
        Return ""
    End Function 'ComputeMymin


#End Region

    Private engine As Syncfusion.Calculate.CalcEngine
    Private dt As DataTable


    Private Sub SingleDataGridForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Me.dt = New DataTable("MyTable")

        Dim nCols As Integer = 5
        Dim nRows As Integer = 7

        Dim i As Integer
        For i = 0 To nCols - 1
            Me.dt.Columns.Add(New DataColumn(String.Format("{0}", ChrW(65 + i))))
        Next i
        Dim r As New Random()

        i = 0

        While i < nRows

            Dim dr As DataRow = Me.dt.NewRow()

            Dim j As Integer
            For j = 0 To nCols - 1
                If j = 0 Then
                    dr(j) = (i + 1).ToString()
                ElseIf j = 1 Then
                    If i = 0 Then
                        dr(j) = 1
                    Else
                        dr(j) = String.Format("=B{0} + {0}", i)
                    End If
                Else
                    dr(j) = r.Next(100).ToString()
                End If
            Next j
            Me.dt.Rows.Add(dr)
            i += 1
        End While
       

        'DataGrid1 is an instance of CalcDataGrid.
        'Set the DataSource to a DataTable:
        Me.dataGrid1.DataSource = Me.dt


        'Call this to reset static members in case other form is loaded first:
        Syncfusion.Calculate.CalcEngine.ResetSheetFamilyID()
        'Create a CalcEngine object, tie it to the DataGrid that implements ICalcData:
        engine = New Syncfusion.Calculate.CalcEngine(Me.dataGrid1)

        'Register multiple ICalcData objects for cross sheet references:
        Dim sheetfamilyID As Integer = Syncfusion.Calculate.CalcEngine.CreateSheetFamilyID()
        engine.RegisterGridAsSheet("SingleGrid", Me.dataGrid1, sheetfamilyID)

        'Set the CalcEngine to track dependencies required for auto updating:
        engine.UseDependencies = True

        'engine.IgnoreValueChanged = True;
        'Call RecalculateRange so any formulas in the data can be initially computed:
        engine.RecalculateRange(RangeInfo.Cells(1, 1, dt.Rows.Count, dt.Columns.Count), Me.dataGrid1)

        'engine.IgnoreValueChanged = False; 
         
        'Adding formula to the CalcEngine Library:
        'Step 2: Call the AddFunction member of the Engine.


        'Add formula name Min to the Library:
        engine.AddFunction("Mymin", AddressOf ComputeMymin)
    End Sub 'SingleDataGridForm_Load


     

    Private Sub textBox1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles textBox1.Enter
        'Clear the display of last calculation value as the text box gets focus:
        Me.label1.Text = ""
    End Sub 'textBox1_Enter


    'Compute the value of a formula entered into textBox1.
    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        '-code to parse and compute a formula
        '-turn off dependency tracking as this formula comes from the
        'text box and is not entered into the grid.
        Me.engine.UseDependencies = False
        Try
            Me.label1.Text = Me.engine.ParseAndComputeFormula(Me.textBox1.Text)
        Catch ex As Exception
            Me.label1.Text = ex.Message
        End Try
        Me.engine.UseDependencies = True
    End Sub 'button1_Click



    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Dim dt As DataTable = Me.dataGrid1.DataSource '
         
        Dim cm As CurrencyManager = Me.dataGrid1.BindingContext(Me.dataGrid1.DataSource, Me.dataGrid1.DataMember) '
            Dim save As Integer = cm.Position

        If Me.checkBox1.Checked Then
            engine.IgnoreValueChanged = True
            Dim row As Integer = 0

            While row < dt.Rows.Count
                Dim col As Integer = 0

                While col < dt.Columns.Count
                    Dim s As String = Me.engine.GetFormulaRowCol(Me.dataGrid1, row + 1, col + 1) 'one-based call
                    If s.Length > 0 Then
                        'no calculation as ValueChanged is not raised.
                        Me.dataGrid1(row, col) = s
                    End If
                    col += 1
                End While
                row += 1
            End While
            cm.Position = save
            engine.IgnoreValueChanged = False
        Else
            Dim row As Integer = 0

            While row < dt.Rows.Count
                Dim col As Integer = 0

                While col < dt.Columns.Count
                    Dim s As String = Me.engine.GetFormulaRowCol(Me.dataGrid1, row + 1, col + 1) 'one-based call
                    If s.Length > 0 Then
                        'Setting the value forces the calculation.
                        'The ValueChanged event will be raised.
                        Me.dataGrid1(row, col) = s
                    End If
                    col += 1
                End While
                row += 1
            End While
            cm.Position = save
        End If


        Me.dataGrid1.ReadOnly = Me.checkBox1.Checked
        If Me.dataGrid1.ReadOnly Then
            Me.checkBox1.Text = "Showing Formulas (Read-only DataGrid)"
        Else
            Me.checkBox1.Text = "Show any formulas in the DataGrid."
        End If
    End Sub 'checkBox1_CheckedChanged

    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        Me.engine.CalculatingSuspended = Me.checkBox2.Checked
    End Sub 'checkBox2_CheckedChanged
End Class 'SingleDataGridForm