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
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Drawing

'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits Syncfusion.Windows.Forms.MetroForm
    Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing


    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        'turn off D&D support
        gridControl1.ControllerOptions = GridControllerOptions.All And Not GridControllerOptions.OleDataSource

        gridControl1.ResetVolatileData()
        AddHandler gridControl1.QueryCellInfo, AddressOf GridQueryCellInfo
        AddHandler gridControl1.QueryRowCount, AddressOf GridQueryRowCount

        AddHandler gridControl1.QueryRowHeight, AddressOf GridQueryRowHeight
        gridControl1.ColWidths(0) += 10

        gridControl1.VerticalScrollTips = True
        AddHandler gridControl1.ScrollTipFeedback, AddressOf gridControl1_ScrollTipFeedback

        Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
        Me.Icon = ico

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

	
    '
    ' TODO: Add any constructor code after InitializeComponent call
    '

    Private Sub gridControl1_ScrollTipFeedback(ByVal sender As Object, ByVal e As ScrollTipFeedbackEventArgs)
        e.Size = Me.gridControl1.ScrollTip.GetPreferredSize(e.Text)
    End Sub
    Sub GridQueryRowCount(ByVal sender As Object, ByVal e As GridRowColCountEventArgs)
        e.Count = 30000
        e.Handled = True
    End Sub 'GridQueryRowCount


    Sub GridQueryCellInfo(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
        If e.RowIndex > 0 Then
            If e.ColIndex > 0 Then
                If e.ColIndex <> 2 Then
                    e.Style.CellValue = e.RowIndex.ToString() + "/" + e.ColIndex.ToString()
                End If
                If e.RowIndex Mod 2 = 0 Then
                    e.Style.Interior = New BrushInfo(Color.FromArgb(&HED, &HF0, &HF7))
                    e.Style.VerticalAlignment = GridVerticalAlignment.Bottom
                Else
                    e.Style.Interior = New BrushInfo(Color.FromArgb(&H91, &HBB, &HB8))
                End If
                If e.ColIndex = 2 Then
                    If e.RowIndex Mod 2 = 0 Then
                        e.Style.CellType = "PushButton"
                    Else
                        e.Style.CellType = "DropDownGrid"
                    End If
                    e.Style.Description = "Click"
                Else
                    e.Style.CellType = "Static"
                End If
                If e.RowIndex Mod 4 = 0 Then
                    e.Style.Borders.Bottom = New GridBorder(GridBorderStyle.Solid, Color.Orange, GridBorderWeight.Medium)
                End If
            End If
            e.Handled = True
        End If
    End Sub 'GridQueryCellInfo



    Sub GridQueryRowHeight(ByVal sender As Object, ByVal e As GridRowColSizeEventArgs)
        If e.Index Mod 2 = 0 Then
            e.Size = 25
            e.Handled = True
        End If
    End Sub 'GridQueryRowHeight


    Sub GridQueryCoveredRange(ByVal sender As Object, ByVal e As GridQueryCoveredRangeEventArgs)
        If e.RowIndex Mod 2 = 1 AndAlso e.ColIndex >= 1 AndAlso e.ColIndex <= 3 Then
            e.Range = GridRangeInfo.Cells(e.RowIndex, 1, e.ColIndex, 3)
            e.Handled = True
        End If
    End Sub 'GridQueryCoveredRange


    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            RemoveHandler gridControl1.QueryCellInfo, AddressOf GridQueryCellInfo
            RemoveHandler gridControl1.QueryRowCount, AddressOf GridQueryRowCount

            RemoveHandler gridControl1.QueryRowHeight, AddressOf GridQueryRowHeight

            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose


    '
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
        Me.gridControl1.ColCount = 55
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
        Me.gridControl1.Location = New System.Drawing.Point(21, 12)
        Me.gridControl1.MetroScrollBars = True
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gridControl1.Properties.MarkColHeader = False
        Me.gridControl1.Properties.MarkRowHeader = False
        Me.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gridControl1.RowCount = 100
        Me.gridControl1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
        Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode
        Me.gridControl1.Size = New System.Drawing.Size(764, 440)
        Me.gridControl1.SmartSizeBox = False
        Me.gridControl1.TabIndex = 1
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
        Me.ClientSize = New System.Drawing.Size(806, 475)
        Me.Controls.Add(Me.gridControl1)
        Me.DropShadow = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Virtual Grid Demo"
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent

    '
    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Public Shared Sub Main()
        Application.Run(New Form1)
    End Sub 'Main

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gridControl1.Model.BaseStylesMap("Header").StyleInfo.Font.Bold = True
    End Sub

    'Private Sub gridControl1_ClipboardCut(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridCutPasteEventArgs) Handles gridControl1.ClipboardCut
    '    e.ClipboardFlags = GridDragDropFlags.ColHeader
    'End Sub
End Class 'Form1