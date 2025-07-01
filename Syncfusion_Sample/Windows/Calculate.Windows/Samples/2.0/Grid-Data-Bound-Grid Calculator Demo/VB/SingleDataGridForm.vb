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
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Calculate

Namespace GridDataBoundGridCalculator

Public Class SingleGridDataBoundGridForm
    Inherits System.Windows.Forms.Form
    Private gridDataBoundGrid1 As GridDataBoundGridCalculator.CalcGridDataBoundGrid
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private label1 As System.Windows.Forms.Label
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label

    Private components As System.ComponentModel.Container = Nothing


    Public Sub New()
        '
        ' Required for Windows Form Designer support.
        '
            InitializeComponent()
            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Icon", "sfgrid.ico"))
            Me.Icon = ico

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
        ''' <summary>
        ''' Required method for Designer support; do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim GridStyleInfo2 As Syncfusion.Windows.Forms.Grid.GridStyleInfo = New Syncfusion.Windows.Forms.Grid.GridStyleInfo
            Me.gridDataBoundGrid1 = New GridDataBoundGridCalculator.CalcGridDataBoundGrid
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.button1 = New System.Windows.Forms.Button
            Me.label1 = New System.Windows.Forms.Label
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.label2 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridDataBoundGrid1
            '
            Me.gridDataBoundGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell
            Me.gridDataBoundGrid1.AllowDragSelectedCols = True
            Me.gridDataBoundGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridDataBoundGrid1.DataMember = ""
            Me.gridDataBoundGrid1.Font = New System.Drawing.Font("Verdana", 8.5!)
            Me.gridDataBoundGrid1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.gridDataBoundGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
            Me.gridDataBoundGrid1.Location = New System.Drawing.Point(24, 126)
            Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
            Me.gridDataBoundGrid1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridDataBoundGrid1.Properties.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
            Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
            Me.gridDataBoundGrid1.Size = New System.Drawing.Size(376, 144)
            Me.gridDataBoundGrid1.SmartSizeBox = False
            Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.None
            Me.gridDataBoundGrid1.TabIndex = 0
            GridStyleInfo2.Font.Bold = False
            GridStyleInfo2.Font.Facename = "Verdana"
            GridStyleInfo2.Font.Italic = False
            GridStyleInfo2.Font.Size = 8.5!
            GridStyleInfo2.Font.Strikeout = False
            GridStyleInfo2.Font.Underline = False
            Me.gridDataBoundGrid1.TableStyle = GridStyleInfo2
            Me.gridDataBoundGrid1.ThemesEnabled = True
            '
            'textBox1
            '
            Me.textBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.textBox1.Location = New System.Drawing.Point(408, 152)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(208, 20)
            Me.textBox1.TabIndex = 1
            '
            'button1
            '
            Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button1.Location = New System.Drawing.Point(480, 184)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 23)
            Me.button1.TabIndex = 2
            Me.button1.Text = "Compute"
            '
            'label1
            '
            Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label1.Location = New System.Drawing.Point(409, 224)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(207, 40)
            Me.label1.TabIndex = 3
            '
            'checkBox1
            '
            Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox1.Location = New System.Drawing.Point(19, 65)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(344, 16)
            Me.checkBox1.TabIndex = 5
            Me.checkBox1.Text = "Show any formulas in the GridDataBoundGrid."
            '
            'label2
            '
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(17, 38)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(472, 16)
            Me.label2.TabIndex = 6
            Me.label2.Text = "Try entering formulas such as = A4 + B4 into a cell in this GridDataBoundGrid."
            '
            'label3
            '
            Me.label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(408, 105)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(288, 39)
            Me.label3.TabIndex = 7
            Me.label3.Text = "Enter a formula based on GridDataBoundGrid cells like    = A1 + B2 + Cos(B1).    " & _
                "                              Then press Compute. "
            '
            'SingleGridDataBoundGridForm
            '
            Me.AcceptButton = Me.button1
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(696, 310)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.checkBox1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.gridDataBoundGrid1)
            Me.Name = "SingleGridDataBoundGridForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Grid-Data-Bound-Grid Calculator Demo"
            CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region

#Region "Adding a formula to the formula library - step 1"


        'Adding formulas to the CalcEngine Library.
        'Step 1: Code it with this signature:
        '			public string MyLibraryFormula(string args)
        '   return the computed value as a string...
        '   use the engines public members as needed in your code.
        '   This sample computes the minimum of arbitary range:
        '     egs:		=MyMin(A1:C3)
        '				=Mymin(a1,c2,a4,b2)
        Public Function ComputeMyMin(ByVal args As String) As String
            Dim min As Double = Double.MaxValue
            Dim d As Double
            Dim s1 As String

            Dim r As String
            For Each r In args.Split(New Char() {","c})
                If r.IndexOf(":"c) > -1 Then  'cell range
                    Dim s As String
                    For Each s In engine.GetCellsFromArgs(r)
                        's is a cell line a21 or c3...
                        Try
                            s1 = engine.GetValueFromArg(s)
                        Catch ex As Exception
                            Return ex.Message
                        End Try
                        If s1 <> "" Then
                            If Double.TryParse(s1, System.Globalization.NumberStyles.Number, Nothing, d) Then
                                min = Math.Min(min, d)
                            End If
                        End If
                    Next s
                Else
                    Try
                        s1 = engine.GetValueFromArg(r)
                    Catch ex As Exception
                        Return ex.Message
                    End Try
                    If s1 <> "" Then
                        If Double.TryParse(s1, System.Globalization.NumberStyles.Number, Nothing, d) Then
                            min = Math.Min(min, d)
                        End If
                    End If
                End If
            Next r
            If min <> Double.MaxValue Then
                Return min.ToString()
            End If
            Return ""
        End Function 'ComputeMyMin


#End Region

        Private engine As Syncfusion.Calculate.CalcEngine
        Private dt As DataTable


        Private Sub SinglegridDataBoundGridForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load


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


            Me.gridDataBoundGrid1.DataSource = Me.dt
            Me.gridDataBoundGrid1.AllowResizeToFit = False
            Me.gridDataBoundGrid1.DefaultColWidth = 60

            'Call this to reset static members in case other form is loaded first:
            Syncfusion.Calculate.CalcEngine.ResetSheetFamilyID()
            'Create a CalcEngine object, tie it to the gridDataBoundGrid that implements ICalcData:
            engine = New Syncfusion.Calculate.CalcEngine(Me.gridDataBoundGrid1)
            'Set the CalcEngine to track dependencies required for auto updating:
            engine.UseDependencies = True

            'Call RecalculateRange so any formulas in the data can be initially computed.
            'Code for all cells....
            'engine.RecalculateRange(RangeInfo.Cells(1, 1, dt.Rows.Count, dt.Columns.Count), this.gridDataBoundGrid1); 
            'We only have formulas in column two, so just recalc that range:
            engine.RecalculateRange(RangeInfo.Cells(1, 2, dt.Rows.Count, 2), Me.gridDataBoundGrid1)

            'Adding formulas to the CalcEngine Library.
            'Step 2: Call the AddFunction member of the engine.
            'Add formula name Min to the Library:
            engine.AddFunction("MyMin", AddressOf ComputeMyMin)
        End Sub 'SinglegridDataBoundGridForm_Load




        Private Sub textBox1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles textBox1.Enter
            'Clear the display of last calculation value as the text box gets focus:
            Me.label1.Text = ""
        End Sub 'textBox1_Enter


        'Compute the value of a formula entered into textBox1:
        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            '-code to parse and compute a formula
            '-turn off dependency tracking as this formula comes from the
            'text box and is not entered into the grid.
            Me.engine.UseDependencies = False
            Me.label1.Text = Me.engine.ParseAndComputeFormula(Me.textBox1.Text)
            Me.engine.UseDependencies = True
        End Sub 'button1_Click



        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            Dim dt As DataTable = Me.gridDataBoundGrid1.DataSource '

            Me.gridDataBoundGrid1.BeginUpdate()

            If Me.checkBox1.Checked Then
                engine.IgnoreValueChanged = True
                Dim row As Integer = 0

                While row < dt.Rows.Count
                    Dim col As Integer = 0

                    While col < dt.Columns.Count
                        'All calls into CalcEngine are one-based:
                        Dim s As String = Me.engine.GetFormulaRowCol(Me.gridDataBoundGrid1, row + 1, col + 1)
                        If s.Length > 0 Then
                            'No calculation as ValueChanged is not raised:
                            Me.gridDataBoundGrid1(row + 1, col + 1).Text = s
                        End If
                        col += 1
                    End While
                    row += 1
                End While
                engine.IgnoreValueChanged = False
            Else
                engine.IgnoreValueChanged = True
                Dim row As Integer = 0

                While row < dt.Rows.Count
                    Dim col As Integer = 0

                    While col < dt.Columns.Count
                        'All calls into CalcEngine are one-based:
                        Dim s As String = Me.engine.GetFormulaRowCol(Me.gridDataBoundGrid1, row + 1, col + 1)
                        If s.Length > 0 Then
                            'Get the value:
                            s = Me.engine.GetValueFromParentObject(row + 1, col + 1)
                            Me.gridDataBoundGrid1(row + 1, col + 1).Text = s
                        End If
                        col += 1
                    End While
                    row += 1
                End While

                Me.gridDataBoundGrid1.Binder.EndEdit()


                engine.IgnoreValueChanged = False
            End If
            Me.gridDataBoundGrid1.TableStyle.TextColor = IIf(Me.checkBox1.Checked, Color.Gray, SystemColors.WindowText)
            Me.gridDataBoundGrid1.Locked = Me.checkBox1.Checked

            Me.gridDataBoundGrid1.EndUpdate()
            Me.gridDataBoundGrid1.Refresh()
        End Sub 'checkBox1_CheckedChanged 
End Class 'SingleGridDataBoundGridForm
End Namespace 'GridDataBoundGridCalculator