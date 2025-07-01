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
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.ComponentModel
Imports Microsoft.VisualBasic
Imports Syncfusion.Windows.Forms

Public Class Form1
    Inherits MetroForm
    Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
    Private statsLabel As System.Windows.Forms.Label
    Private WithEvents gridCellIndexerButton As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents populateValuesbutton As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents virtualButton As Syncfusion.Windows.Forms.ButtonAdv
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents rowNumeric As System.Windows.Forms.NumericUpDown
    Private WithEvents applyButton As Syncfusion.Windows.Forms.ButtonAdv
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private panel1 As System.Windows.Forms.Panel

    Private intArray(,) As Integer
    Private numArrayRows As Integer
    Private numArrayCols As Integer
    Private WithEvents colNumeric As System.Windows.Forms.NumericUpDown
    Private isInVirtualMode As Boolean
    Private components As System.ComponentModel.IContainer
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>


    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        'Set up a possible progress bar dialog for any populations that take a long time.
        'We need to create a handler for the status dialog to set some properties and give
        'it to the GridControl.Model OperationFeeadbackListener.
        Dim handler As New Syncfusion.Windows.Forms.DelayedStatusDialog()

        Me.gridControl1.Model.OperationFeedbackListener = handler

        'start displaying progress bar after 2000 msecs if operation is less than 60% complete
        'show wait cursor after 2000 msecs if operation is less than 80 % complete
        handler.Delay = 2000 'default is 500
        handler.ShowDialogPercentRule = 60 'default is 25
        handler.ShowWaitCursorPercentRule = 80 'default value is 75
        'set up the integer array that serves as external data
        Me.SetUpArray()

        isInVirtualMode = False

        Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("Icon\sfgrid.ico"))
        Me.Icon = ico

        Me.gridControl1.DefaultRowHeight = 18
        Me.gridControl1.DefaultColWidth = 70
        Me.DropShadow = True
        Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridControl1.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
        Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
        Me.gridControl1.BackColor = Color.White

        Dim style As GridStyleInfo
        style = Me.gridControl1.BaseStylesMap("Header").StyleInfo
        style.TextColor = Color.MidnightBlue
        style.Font.Facename = "Segoe UI"
        style = Me.gridControl1.BaseStylesMap("Standard").StyleInfo
        style.TextColor = Color.MidnightBlue
        style.Font.Facename = "Segoe UI"
    End Sub 'New

		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

	
    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
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
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
        Me.statsLabel = New System.Windows.Forms.Label
        Me.gridCellIndexerButton = New Syncfusion.Windows.Forms.ButtonAdv
        Me.populateValuesbutton = New Syncfusion.Windows.Forms.ButtonAdv
        Me.virtualButton = New Syncfusion.Windows.Forms.ButtonAdv
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.applyButton = New Syncfusion.Windows.Forms.ButtonAdv
        Me.colNumeric = New System.Windows.Forms.NumericUpDown
        Me.rowNumeric = New System.Windows.Forms.NumericUpDown
        Me.panel1 = New System.Windows.Forms.Panel
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.colNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rowNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridControl1
        '
        Me.gridControl1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell
        Me.gridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridControl1.BackColor = System.Drawing.Color.White
        Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridControl1.DefaultColWidth = 70
        Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
        Me.gridControl1.DefaultRowHeight = 18
        Me.gridControl1.ForeColor = System.Drawing.Color.White
        Me.gridControl1.Location = New System.Drawing.Point(24, 0)
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.RowCount = 1000
        Me.gridControl1.Size = New System.Drawing.Size(508, 374)
        Me.gridControl1.SmartSizeBox = False
        Me.gridControl1.TabIndex = 0
        Me.gridControl1.Text = "grid"
        Me.gridControl1.ThemesEnabled = True
        '
        'statsLabel
        '
        Me.statsLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.statsLabel.BackColor = System.Drawing.Color.White
        Me.statsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.statsLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.statsLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statsLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.statsLabel.Location = New System.Drawing.Point(551, 293)
        Me.statsLabel.Name = "statsLabel"
        Me.statsLabel.Size = New System.Drawing.Size(144, 81)
        Me.statsLabel.TabIndex = 1
        Me.statsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gridCellIndexerButton
        '
        Me.gridCellIndexerButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridCellIndexerButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.gridCellIndexerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gridCellIndexerButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridCellIndexerButton.ForeColor = System.Drawing.Color.White
        Me.gridCellIndexerButton.Location = New System.Drawing.Point(562, 154)
        Me.gridCellIndexerButton.Name = "gridCellIndexerButton"
        Me.gridCellIndexerButton.Size = New System.Drawing.Size(120, 23)
        Me.gridCellIndexerButton.TabIndex = 2
        Me.gridCellIndexerButton.Text = "Grid Cell Indexer"
        Me.gridCellIndexerButton.UseVisualStyle = True
        '
        'populateValuesbutton
        '
        Me.populateValuesbutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.populateValuesbutton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.populateValuesbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.populateValuesbutton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.populateValuesbutton.ForeColor = System.Drawing.Color.White
        Me.populateValuesbutton.Location = New System.Drawing.Point(562, 201)
        Me.populateValuesbutton.Name = "populateValuesbutton"
        Me.populateValuesbutton.Size = New System.Drawing.Size(120, 23)
        Me.populateValuesbutton.TabIndex = 3
        Me.populateValuesbutton.Text = "PopulateValues "
        Me.populateValuesbutton.UseVisualStyle = True
        '
        'virtualButton
        '
        Me.virtualButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.virtualButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.virtualButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.virtualButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.virtualButton.ForeColor = System.Drawing.Color.White
        Me.virtualButton.Location = New System.Drawing.Point(562, 245)
        Me.virtualButton.Name = "virtualButton"
        Me.virtualButton.Size = New System.Drawing.Size(120, 23)
        Me.virtualButton.TabIndex = 4
        Me.virtualButton.Text = "Virtual Grid"
        Me.virtualButton.UseVisualStyle = True
        '
        'groupBox1
        '
        Me.groupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.applyButton)
        Me.groupBox1.Controls.Add(Me.colNumeric)
        Me.groupBox1.Controls.Add(Me.rowNumeric)
        Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.groupBox1.Location = New System.Drawing.Point(551, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(144, 114)
        Me.groupBox1.TabIndex = 5
        Me.groupBox1.TabStop = False
        '
        'label2
        '
        Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label2.Location = New System.Drawing.Point(8, 42)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(48, 20)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Columns"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label1
        '
        Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label1.Location = New System.Drawing.Point(8, 20)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(32, 20)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Rows"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'applyButton
        '
        Me.applyButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.applyButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.applyButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.applyButton.ForeColor = System.Drawing.Color.White
        Me.applyButton.Location = New System.Drawing.Point(8, 72)
        Me.applyButton.Name = "applyButton"
        Me.applyButton.Size = New System.Drawing.Size(128, 24)
        Me.applyButton.TabIndex = 2
        Me.applyButton.Text = "Change Data"
        Me.applyButton.UseVisualStyle = True
        '
        'colNumeric
        '
        Me.colNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.colNumeric.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.colNumeric.Location = New System.Drawing.Point(80, 40)
        Me.colNumeric.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.colNumeric.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.colNumeric.Name = "colNumeric"
        Me.colNumeric.Size = New System.Drawing.Size(56, 20)
        Me.colNumeric.TabIndex = 1
        Me.colNumeric.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'rowNumeric
        '
        Me.rowNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rowNumeric.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.rowNumeric.Location = New System.Drawing.Point(80, 16)
        Me.rowNumeric.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.rowNumeric.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.rowNumeric.Name = "rowNumeric"
        Me.rowNumeric.Size = New System.Drawing.Size(56, 20)
        Me.rowNumeric.TabIndex = 0
        Me.rowNumeric.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.White
        Me.panel1.Controls.Add(Me.gridControl1)
        Me.panel1.Controls.Add(Me.groupBox1)
        Me.panel1.Controls.Add(Me.gridCellIndexerButton)
        Me.panel1.Controls.Add(Me.statsLabel)
        Me.panel1.Controls.Add(Me.virtualButton)
        Me.panel1.Controls.Add(Me.populateValuesbutton)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(720, 390)
        Me.panel1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(720, 390)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Grid Population Demo"
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        CType(Me.colNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rowNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region

    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Public Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
        Application.EnableVisualStyles()
#End If
        Application.Run(New Form1())
    End Sub 'Main


    Private Sub applyButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles applyButton.Click
        Me.gridCellIndexerButton.Enabled = True
        Me.populateValuesbutton.Enabled = True
        Me.virtualButton.Enabled = True

        SetUpArray()
        Me.gridControl1.ResetVolatileData()
        Me.gridControl1.Refresh()
    End Sub 'applyButton_Click


    Private Sub gridCellIndexerButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridCellIndexerButton.Click
        If isInVirtualMode Then
            SetVirtualMode(False)
        End If

        'allow a cancel for long operations
        Dim op As New OperationFeedback(Me.gridControl1.Model)
        op.AllowNestedFeedback = False
        op.AllowNestedProgress = False
        op.Description = "Population Progress"
        op.AllowCancel = True

        Dim total As Integer = Me.numArrayRows * Me.numArrayCols
        Dim progress As Integer = 0

        Me.Cursor = Cursors.WaitCursor
        Dim ticks As Integer = Environment.TickCount
        Me.gridControl1.BeginUpdate()
        Me.gridControl1.RowCount = Me.numArrayRows
        Me.gridControl1.ColCount = Me.numArrayCols

        Dim i As Integer

        While i < Me.numArrayRows
            Dim j As Integer = 0

            While j < Me.numArrayCols
                Me.gridControl1(i + 1, j + 1).CellValue = Me.intArray(i, j)
                j += 1
            End While

            progress += Me.numArrayCols
            op.PercentComplete = CType(((progress * 100) _
                        / total), Integer)
            If op.ShouldCancel Then
                Exit While
            End If
            i += 1
        End While

        'Close out the operation progress dialog
        op.Close()

        Me.gridControl1.EndUpdate()
        Me.gridControl1.Refresh()

        Me.statsLabel.Text = String.Format(vbLf + "Grid Cell Indexer" + vbCr + vbLf + vbCr + vbLf + "{0} ticks", Environment.TickCount - ticks)

        Me.Cursor = Cursors.Arrow
    End Sub 'gridCellIndexerButton_Click


    Private Sub populateValuesbutton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles populateValuesbutton.Click
        If isInVirtualMode Then
            SetVirtualMode(False)
        End If
        'OperationFeedback not needed here as it is 
        'embedded in the PopulateValues method
        Me.Cursor = Cursors.WaitCursor
        Dim ticks As Integer = Environment.TickCount
        Me.gridControl1.BeginUpdate()
        Me.gridControl1.RowCount = Me.numArrayRows
        Me.gridControl1.ColCount = Me.numArrayCols

        gridControl1.Model.PopulateValues(GridRangeInfo.Cells(1, 1, Me.numArrayRows, Me.numArrayCols), Me.intArray)
        Me.gridControl1.EndUpdate()
        Refresh()
        Me.statsLabel.Text = String.Format(vbLf + "PopulateValues" + vbCr + vbLf + vbCr + vbLf + "{0} ticks", Environment.TickCount - ticks)

        Me.Cursor = Cursors.Arrow
    End Sub 'populateValuesbutton_Click


    Private Sub virtualButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles virtualButton.Click
        If Not isInVirtualMode Then
            SetVirtualMode(True)
        End If
        Dim ticks As Integer = Environment.TickCount

        Me.gridControl1.Refresh()
        Me.statsLabel.Text = String.Format(vbLf + "VirtualMode" + vbCr + vbLf + vbCr + vbLf + "{0} ticks", Environment.TickCount - ticks)
    End Sub 'virtualButton_Click


    ' setup the array that holds the data that we want to move to the grid
    Private Sub SetUpArray()

        Me.Cursor = Cursors.WaitCursor
        Me.numArrayCols = CType(Me.colNumeric.Value, Integer)
        Me.numArrayRows = CType(Me.rowNumeric.Value, Integer)
        Dim r As Random
        r = New Random()
        Me.intArray = New Integer(Me.numArrayRows - 1, Me.numArrayCols - 1) {}
        Dim i As Integer
        i = 0

        Do While (i < Me.numArrayRows)
            Dim j As Integer
            j = 0

            Do While (j < Me.numArrayCols)
                Me.intArray(i, j) = r.Next(10000)
                j = (j + 1)

            Loop
            i = (i + 1)

        Loop
        Me.Cursor = Cursors.Arrow

    End Sub


    Private Sub Numeric_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles colNumeric.ValueChanged, rowNumeric.ValueChanged
        Me.gridCellIndexerButton.Enabled = False
        Me.populateValuesbutton.Enabled = False
        Me.virtualButton.Enabled = False
    End Sub 'Numeric_ValueChanged
    Private Sub SetVirtualMode(ByVal [on] As Boolean)

        Me.gridControl1.ResetVolatileData()
        isInVirtualMode = [on]
        Try
            If [on] Then
                AddHandler Me.gridControl1.QueryCellInfo, AddressOf QueryCellInfoHandler
                AddHandler Me.gridControl1.QueryColCount, AddressOf GridQueryColCount
                AddHandler Me.gridControl1.QueryRowCount, AddressOf GridQueryRowCount
            Else
                RemoveHandler Me.gridControl1.QueryCellInfo, AddressOf QueryCellInfoHandler
                RemoveHandler Me.gridControl1.QueryColCount, AddressOf GridQueryColCount
                RemoveHandler Me.gridControl1.QueryRowCount, AddressOf GridQueryRowCount
            End If
        Catch ex As System.Exception
        End Try

    End Sub
    Private Sub QueryCellInfoHandler(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
        If e.ColIndex > 0 AndAlso e.RowIndex > 0 Then
            e.Style.CellValue = Me.intArray(e.RowIndex - 1, e.ColIndex - 1)
            e.Handled = True
        End If
    End Sub 'QueryCellInfoHandler


    Private Sub GridQueryColCount(ByVal sender As Object, ByVal e As GridRowColCountEventArgs)
        e.Count = Me.numArrayCols
        e.Handled = True
    End Sub 'GridQueryColCount


    Private Sub GridQueryRowCount(ByVal sender As Object, ByVal e As GridRowColCountEventArgs)
        e.Count = Me.numArrayRows
        e.Handled = True
    End Sub 'GridQueryRowCount

End Class
