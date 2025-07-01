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


'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits Syncfusion.Windows.Forms.MetroForm
    Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
    Private _extData As ExternalData
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing


    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
    End Sub 'New

    '
    ' TODO: Add any constructor code after InitializeComponent call
    '

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


    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim GridBaseStyle1 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
        Dim GridBaseStyle2 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
        Dim GridBaseStyle3 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
        Dim GridBaseStyle4 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
        Dim GridCellInfo1 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
        Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridControl1
        '
        Me.gridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridControl1.BackColor = System.Drawing.Color.White
        GridBaseStyle1.Name = "Row Header"
        GridBaseStyle1.StyleInfo.BaseStyle = "Header"
        GridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
        GridBaseStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
        GridBaseStyle2.Name = "Column Header"
        GridBaseStyle2.StyleInfo.BaseStyle = "Header"
        GridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
        GridBaseStyle3.Name = "Standard"
        GridBaseStyle3.StyleInfo.Font.Facename = "Segoe UI"
        GridBaseStyle3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
        GridBaseStyle4.Name = "Header"
        GridBaseStyle4.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle4.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle4.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle4.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle4.StyleInfo.CellType = "Header"
        GridBaseStyle4.StyleInfo.Font.Bold = True
        GridBaseStyle4.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
        GridBaseStyle4.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
        Me.gridControl1.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle1, GridBaseStyle2, GridBaseStyle3, GridBaseStyle4})
        Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridControl1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)})
        Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
        Me.gridControl1.DefaultRowHeight = 20
        Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.gridControl1.ForeColor = System.Drawing.Color.MidnightBlue
        GridCellInfo1.Col = -1
        GridCellInfo1.Row = -1
        GridCellInfo1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        GridCellInfo1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        GridCellInfo1.StyleInfo.Font.Bold = False
        GridCellInfo1.StyleInfo.Font.Facename = "Segoe UI"
        GridCellInfo1.StyleInfo.Font.Italic = False
        GridCellInfo1.StyleInfo.Font.Size = 8.5!
        GridCellInfo1.StyleInfo.Font.Strikeout = False
        GridCellInfo1.StyleInfo.Font.Underline = False
        GridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
        GridCellInfo1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
        GridCellInfo1.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gridControl1.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() {GridCellInfo1})
        Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridControl1.HorizontalThumbTrack = True
        Me.gridControl1.Location = New System.Drawing.Point(23, 12)
        Me.gridControl1.MetroScrollBars = True
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gridControl1.Properties.MarkColHeader = False
        Me.gridControl1.Properties.MarkRowHeader = False
        Me.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gridControl1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
        Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode
        Me.gridControl1.Size = New System.Drawing.Size(695, 372)
        Me.gridControl1.SmartSizeBox = False
        Me.gridControl1.TabIndex = 0
        Me.gridControl1.ThemesEnabled = True
        Me.gridControl1.VerticalThumbTrack = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(741, 407)
        Me.Controls.Add(Me.gridControl1)
        Me.DropShadow = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Getting Started "
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent

    '
    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Public Shared Sub Main()
        Application.Run(New Form1())
    End Sub 'Main


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'create a new external data source with 100 rows & 20 columns
        Me._extData = New ExternalData(100, 20)

        Dim ico As New System.Drawing.Icon(GetIconFile("Icon\sfgrid.ico"))
        Me.Icon = ico

        gridControl1.Model.BaseStylesMap("Header").StyleInfo.Font.Bold = True
        Me.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid

        'prepare the grid for virtual data
        gridControl1.ResetVolatileData()

        'hook up the events needed for virtual grid
        'While only the QueryCellInfo is absolutely required,
        'it would be unusual not to handle at least one of the row or column count events
        AddHandler gridControl1.QueryCellInfo, AddressOf GridQueryCellInfo
        AddHandler gridControl1.QueryRowCount, AddressOf GridQueryRowCount
        AddHandler gridControl1.QueryColCount, AddressOf GridQueryColCount

        'if you want to edit your data in the grid, you need to 
        'handle saving data back to the data source...
        AddHandler gridControl1.SaveCellInfo, AddressOf GridSaveCellInfo

        '
        'other events that you can use to provide virtual data
        'these events are optional depending upon the functionality you want
        AddHandler gridControl1.QueryRowHeight, AddressOf GridQueryRowHeight
        AddHandler gridControl1.QueryColWidth, AddressOf GridQueryColWidth
        AddHandler gridControl1.QueryCoveredRange, AddressOf GridQueryCoveredRange
    End Sub 'Form1_Load
	
		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function
	
    '
    'save the changes back to the datasource
    Sub GridSaveCellInfo(ByVal sender As Object, ByVal e As GridSaveCellInfoEventArgs)
        Try
            'move the changes back to the external data object
            If e.ColIndex > 0 AndAlso e.RowIndex > 0 Then
                'either of the next two lines will work without setting CellValueType
                '	this._extData[e.RowIndex - 1, e.ColIndex - 1] = (int) GridCellValueConvert.ChangeType( e.Style.CellValue, typeof(int), null) ;
                Me._extData(e.RowIndex - 1, e.ColIndex - 1) = Integer.Parse(e.Style.CellValue.ToString())
            End If
            ' can be used if CellValueType is set in GridQueryCellInfo
            '	this._extData[e.RowIndex - 1, e.ColIndex - 1] = (int)e.Style.CellValue;
        Catch
        End Try
        'refresh this row so change is displayed
        'this.gridControl1.Refresh();
        e.Handled = True
    End Sub 'GridSaveCellInfo

    '
    'provide the row count from the datasource
    Sub GridQueryRowCount(ByVal sender As Object, ByVal e As GridRowColCountEventArgs)
        e.Count = Me._extData.RowCount
        e.Handled = True
    End Sub 'GridQueryRowCount



    'provide the column count from the datasource
    Sub GridQueryColCount(ByVal sender As Object, ByVal e As GridRowColCountEventArgs)
        e.Count = Me._extData.ColCount
        e.Handled = True
    End Sub 'GridQueryColCount



    'provide the data from the datasource
    Sub GridQueryCellInfo(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
        If e.RowIndex > 0 AndAlso e.ColIndex > 0 Then
            e.Style.CellValue = Me._extData(e.RowIndex - 1, e.ColIndex - 1)

            'setting the CellValueType property allows you to cast the CellValue
            'as opposed to converting it...
            '		e.Style.CellValueType = typeof(int);//commented
            If Me._extData(e.RowIndex - 1, e.ColIndex - 1) Mod 3 = 0 Then
                e.Style.BackColor = Color.FromArgb(&HFF, &HBF, &H34)
            End If
            e.Handled = True
        End If
    End Sub 'GridQueryCellInfo


    'provide the row heights on demand - optional...
    Sub GridQueryRowHeight(ByVal sender As Object, ByVal e As GridRowColSizeEventArgs)
        If e.Index Mod 2 = 0 Then
            e.Size = 20
            e.Handled = True
        End If
    End Sub 'GridQueryRowHeight



    'provide the col widths on demand - optional...
    Sub GridQueryColWidth(ByVal sender As Object, ByVal e As GridRowColSizeEventArgs)
        If e.Index Mod 3 = 0 Then
            e.Size = 40
            e.Handled = True
        End If
    End Sub 'GridQueryColWidth



    'provide covered range on demand - optional...
    Sub GridQueryCoveredRange(ByVal sender As Object, ByVal e As GridQueryCoveredRangeEventArgs)
        'cover odd rows, columns 1 through 3
        If e.RowIndex Mod 2 = 1 AndAlso e.ColIndex >= 1 AndAlso e.ColIndex <= 3 Then
            e.Range = GridRangeInfo.Cells(e.RowIndex, 1, e.RowIndex, 3)
            e.Handled = True
        End If

        'cover column 6 with odd-even row pairs
        If e.RowIndex > 0 AndAlso e.ColIndex = 6 Then
            Dim row As Integer = (e.RowIndex - 1) / 2 * 2 + 1
            Dim col As Integer = e.ColIndex
            e.Range = GridRangeInfo.Cells(row, col, row + 1, col)
            e.Handled = True
        End If
    End Sub 'GridQueryCoveredRange
End Class 'Form1 
