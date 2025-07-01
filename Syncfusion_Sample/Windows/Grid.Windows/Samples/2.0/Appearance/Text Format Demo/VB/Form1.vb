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

Imports Syncfusion.Diagnostics
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms

'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits MetroForm
    Private WithEvents gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
    Private panel1 As System.Windows.Forms.Panel
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing


    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        Dim model As GridModel = gridControl1.Model
        model.Options.FloatCellsMode = GridFloatCellsMode.OnDemandCalculation

        Dim boldFont As New GridFontInfo()
        boldFont.Bold = True
        boldFont.Size = 10
        boldFont.Underline = True

        Dim rowIndex As Integer = 2
        Dim colIndex As Integer = 1

        gridControl1.Rows.DefaultSize += 2
        Dim boldfontRowHeight As Integer = gridControl1.Rows.DefaultSize + 6

        model.Options.ControllerOptions = GridControllerOptions.All
        model.Options.DataObjectConsumerOptions = GridDataObjectConsumerOptions.All

        Dim standard As GridStyleInfo = model.BaseStylesMap("Standard").StyleInfo
        Dim header As GridStyleInfo = model.BaseStylesMap("Header").StyleInfo
        Dim rowHeader As GridStyleInfo = model.BaseStylesMap("Row Header").StyleInfo
        Dim colHeader As GridStyleInfo = model.BaseStylesMap("Column Header").StyleInfo

        header.Interior = New BrushInfo(SystemColors.Control)
        rowHeader.Interior = New BrushInfo(SystemColors.Control)

        standard.Font.Facename = "Segoe UI"
        standard.VerticalAlignment = GridVerticalAlignment.Middle

        model.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2))
        model(rowIndex, 1).Text = "Number Formats"
        model(rowIndex, 1).Font = boldFont
        model.RowHeights(rowIndex) = boldfontRowHeight
        rowIndex += 1

        colIndex = 1
        rowIndex += 1
        Dim format As String
        For Each format In New String() {"0.00", "C", "0.00;(0.00)", "###0.##%", "#0.#E+00", "10:##,##0.#"}

            model(rowIndex - 1, colIndex).Text = format
            model(rowIndex, colIndex).Format = format
            model(rowIndex, colIndex).CellValue = Math.PI
            model(rowIndex, colIndex).CellValueType = GetType(Double)
            colIndex += 1
        Next format

        rowIndex += 1
        rowIndex += 1

        colIndex = 1

        model.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2))
        model(rowIndex, 1).Text = "DateTime Formats"
        model(rowIndex, 1).Font = boldFont
        model.RowHeights(rowIndex) = boldfontRowHeight
        rowIndex += 1

        colIndex = 1
        rowIndex += 1
        Dim format1 As String
        For Each format1 In New String() {"d", "D", "f", "dddd, dd MMMM yyyy", "t", "s"}

            model(rowIndex - 1, colIndex).Text = format1
            model(rowIndex, colIndex).Format = format1
            model(rowIndex, colIndex).CellValue = DateTime.Now
            model(rowIndex, colIndex).CellValueType = GetType(DateTime)
            colIndex += 1
        Next format1

        rowIndex += 1
        rowIndex += 1

        model.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2))
        model(rowIndex, 1).Text = "Validation"
        model(rowIndex, 1).Font = boldFont
        model.RowHeights(rowIndex) = boldfontRowHeight
        rowIndex += 1

        model(rowIndex, 1).Text = "Positive numbers"
        model.RowStyles(rowIndex).ValidateValue.NumberRequired = True
        model.RowStyles(rowIndex).ValidateValue.Minimum = 0
        model.RowStyles(rowIndex).ValidateValue.Maximum = Single.NaN
        model.RowStyles(rowIndex).ValidateValue.ErrorMessage = "Please enter a number greater than 0!"
        rowIndex += 1

        model(rowIndex, 1).Text = "Validation (1-100 valid range)"
        model.RowStyles(rowIndex).ValidateValue = New GridCellValidateValueInfo(True, 1, 100, "Please enter a number between 1 and 100!")
        rowIndex += 1
        rowIndex += 1

        model(rowIndex, 1).Text = "Validation (allow strings to be entered into cells with CellValueType = typeof(double)"
        rowIndex += 1
        model.RowStyles(rowIndex).CellValueType = GetType(Double)
        model.RowStyles(rowIndex).CellValue = 1
        model.RowStyles(rowIndex).Format = "C"
        model.RowStyles(rowIndex).StrictValueType = False
        rowIndex += 1
        rowIndex += 1

        model(rowIndex, 1).Text = "Validation (do not allow strings to be entered)"
        rowIndex += 1
        model.RowStyles(rowIndex).CellValueType = GetType(Double)
        model.RowStyles(rowIndex).CellValue = 1
        model.RowStyles(rowIndex).Format = "C"
        model.RowStyles(rowIndex).StrictValueType = True
        rowIndex += 1
        rowIndex += 1

        model(rowIndex, 1).Text = "Validation (change CellValueType when strings is entered)"
        rowIndex += 1
        model.RowStyles(rowIndex).CellValueType = GetType(Double)
        model.RowStyles(rowIndex).CellValue = 1
        model.RowStyles(rowIndex).Format = "C"
        model.RowStyles(rowIndex).Tag = "Custom"
        rowIndex += 1
        rowIndex += 1

        model.RowHeights.ResizeToFit(GridRangeInfo.Rows(2, rowIndex))

        Dim ico As New System.Drawing.Icon(GetIconFile("Icon\sfgrid.ico"))
        Me.Icon = ico
        Me.gridControl1.DefaultRowHeight = 18
        Me.gridControl1.DefaultColWidth = 70

        Me.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid

        Me.gridControl1.TableStyle.TextColor = Color.MidnightBlue
        Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.5F)
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


    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
#Region "Windows Form Designer generated code"

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
        Me.panel1 = New System.Windows.Forms.Panel
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridControl1
        '
        Me.gridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.gridControl1.ColCount = 8
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
        Me.gridControl1.Location = New System.Drawing.Point(12, 12)
        Me.gridControl1.MetroScrollBars = True
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gridControl1.Properties.MarkColHeader = False
        Me.gridControl1.Properties.MarkRowHeader = False
        Me.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gridControl1.RowCount = 30
        Me.gridControl1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
        Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode
        Me.gridControl1.Size = New System.Drawing.Size(731, 297)
        Me.gridControl1.SmartSizeBox = False
        Me.gridControl1.TabIndex = 3
        Me.gridControl1.ThemesEnabled = True
        Me.gridControl1.VerticalThumbTrack = True
		Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        'panel1
        '
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(755, 317)
        Me.panel1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.White
		Me.BorderThickness = 2
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(755, 317)
        Me.Controls.Add(Me.gridControl1)
        Me.Controls.Add(Me.panel1)
        Me.DropShadow = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Format Demo"
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region

    '
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




    Private Sub gridControl1_QueryCellFormattedText(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridCellTextEventArgs) Handles gridControl1.QueryCellFormattedText

    End Sub 'gridControl1_QueryCellFormattedText

    Private Sub gridControl1_QueryCellText(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridCellTextEventArgs) Handles gridControl1.QueryCellText

    End Sub 'gridControl1_QueryCellText


    Private Sub gridControl1_SaveCellText(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridCellTextEventArgs) Handles gridControl1.SaveCellText
        TraceUtil.TraceCurrentMethodInfo(e)
        ParseText(e)
    End Sub 'gridControl1_SaveCellText


    Private Sub gridControl1_SaveCellFormattedText(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridCellTextEventArgs) Handles gridControl1.SaveCellFormattedText
        TraceUtil.TraceCurrentMethodInfo(e)
        ParseText(e)
    End Sub 'gridControl1_SaveCellFormattedText


    Sub ParseText(ByVal e As GridCellTextEventArgs)
        ' By default, the grid will display a warning message box informing the user
        ' the entered value is not valid and the user will have to change the value.
        '
        ' In this event handler we change the grid defaults behavior such that
        ' when the user enters a value that does not fit the cells CellValueType,
        ' the input text is accepted and no warning message is shown.
        If e.Handled OrElse e.Style.Tag Is Nothing OrElse Not e.Style.Tag.Equals("Custom") Then
            Return
        End If
        Dim ci As System.Globalization.CultureInfo = e.Style.CultureInfo
        Dim nfi As System.Globalization.NumberFormatInfo = Nothing
        If (Not (ci Is Nothing)) Then nfi = ci.NumberFormat
        Try
            e.Style.CellValue = GridCellValueConvert.Parse(e.Text, e.Style.CellValueType, nfi, e.Style.Format)
        Catch ex As Exception
            If TypeOf ex Is FormatException OrElse TypeOf ex.InnerException Is FormatException Then
                e.Style.CellValue = e.Text
                ' possibly could also change CellValueType here 
                e.Style.CellValueType = GetType(String)
                Console.WriteLine("Changed e.Style.CellValueType = typeof(string) for " + e.Style.Identity.ToString())
                ' - or -
                ' you could also further analyze the input text and assign a type
                ' that fits the input text, e.g.
                ' e.Style.CellValueType = typeof(datetime);
                ' - or - 
                ' e.Style.CellValueType = typeof(decimal);
                ' etc.
            Else
                Throw
            End If
        End Try
        e.Handled = True
    End Sub 'ParseText

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gridControl1.Model.BaseStylesMap("Header").StyleInfo.Font.Bold = True
        gridControl1.Model.ColWidths(3) = 150
        gridControl1.Model.ColWidths(4) = 150
    End Sub
End Class 'Form1