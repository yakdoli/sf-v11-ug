Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Drawing
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Diagnostics
Imports Syncfusion.Styles
Namespace GridControl
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1 : Inherits MetroForm
        Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
        Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents ButtonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents ButtonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents ButtonAdv3 As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents ButtonAdv4 As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents ButtonAdv5 As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents ButtonAdv6 As Syncfusion.Windows.Forms.ButtonAdv
        Private components As System.ComponentModel.IContainer
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>

        Public Sub New()

            InitializeComponent()
            Try
                Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
                Me.Icon = ico
            Catch ex As Exception
            End Try
            Me.gridControl1.ThemesEnabled = True
            Me.gridControl1.GridVisualStyles = GridVisualStyles.Metro
            Me.gridControl1.DefaultGridBorderStyle = GridBorderStyle.None
            Dim style As GridStyleInfo = gridControl1.BaseStylesMap("Header").StyleInfo
            style.TextColor = Color.MidnightBlue
            style.Font.Facename = "Verdana"
        End Sub

        Private Function GetIconFile(ByVal bitmapName As String) As String
            For n As Integer = 0 To 9
                If System.IO.File.Exists(bitmapName) Then
                    Return bitmapName
                End If

                bitmapName = "..\" & bitmapName
            Next n

            Return bitmapName
        End Function


        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim GridBaseStyle1 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle2 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle3 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle4 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridRangeStyle1 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle2 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle3 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle4 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.ButtonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.ButtonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.ButtonAdv3 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.ButtonAdv4 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.ButtonAdv5 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.ButtonAdv6 = New Syncfusion.Windows.Forms.ButtonAdv
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
            GridBaseStyle1.Name = "Row Header"
            GridBaseStyle1.StyleInfo.BaseStyle = "Header"
            GridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
            GridBaseStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle2.Name = "Column Header"
            GridBaseStyle2.StyleInfo.BaseStyle = "Header"
            GridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            GridBaseStyle3.Name = "Standard"
            GridBaseStyle3.StyleInfo.Font.Facename = "Tahoma"
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
            Me.gridControl1.ColCount = 12
            Me.gridControl1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)})
            Me.gridControl1.CoveredRanges.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeInfo() {Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(6, 2, 8, 8)})
            Me.gridControl1.DefaultColWidth = 100
            Me.gridControl1.DefaultRowHeight = 20
            Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            Me.gridControl1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridControl1.Location = New System.Drawing.Point(16, 16)
            Me.gridControl1.MetroScrollBars = True
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.gridControl1.Properties.MarkColHeader = False
            Me.gridControl1.Properties.MarkRowHeader = False
            GridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle1.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle1.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(6, 2)
            GridRangeStyle2.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
            GridRangeStyle2.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
            GridRangeStyle2.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
            GridRangeStyle2.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
            GridRangeStyle2.StyleInfo.Font.Bold = True
            GridRangeStyle2.StyleInfo.Font.Facename = "Tahoma"
            GridRangeStyle2.StyleInfo.Font.Italic = False
            GridRangeStyle2.StyleInfo.Font.Size = 15.75!
            GridRangeStyle2.StyleInfo.Font.Strikeout = False
            GridRangeStyle2.StyleInfo.Font.Underline = False
            GridRangeStyle2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            GridRangeStyle2.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(109, Byte), Integer)))
            GridRangeStyle2.StyleInfo.Text = "Syncfusion - Essential Grid"
            GridRangeStyle2.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(125, Byte), Integer))
            GridRangeStyle2.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            GridRangeStyle3.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(6, 3, 8, 8)
            GridRangeStyle3.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
            GridRangeStyle3.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
            GridRangeStyle3.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
            GridRangeStyle3.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
            GridRangeStyle3.StyleInfo.Font.Bold = True
            GridRangeStyle3.StyleInfo.Font.Facename = "Tahoma"
            GridRangeStyle3.StyleInfo.Font.Italic = False
            GridRangeStyle3.StyleInfo.Font.Size = 15.75!
            GridRangeStyle3.StyleInfo.Font.Strikeout = False
            GridRangeStyle3.StyleInfo.Font.Underline = False
            GridRangeStyle3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            GridRangeStyle3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(109, Byte), Integer)))
            GridRangeStyle3.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(125, Byte), Integer))
            GridRangeStyle3.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            GridRangeStyle4.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(7, 2, 8, 8)
            GridRangeStyle4.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
            GridRangeStyle4.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
            GridRangeStyle4.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
            GridRangeStyle4.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Orange, Syncfusion.Windows.Forms.Grid.GridBorderWeight.Thick)
            GridRangeStyle4.StyleInfo.Font.Bold = True
            GridRangeStyle4.StyleInfo.Font.Facename = "Tahoma"
            GridRangeStyle4.StyleInfo.Font.Italic = False
            GridRangeStyle4.StyleInfo.Font.Size = 15.75!
            GridRangeStyle4.StyleInfo.Font.Strikeout = False
            GridRangeStyle4.StyleInfo.Font.Underline = False
            GridRangeStyle4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            GridRangeStyle4.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(109, Byte), Integer)))
            GridRangeStyle4.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(125, Byte), Integer))
            GridRangeStyle4.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            Me.gridControl1.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() {GridRangeStyle1, GridRangeStyle2, GridRangeStyle3, GridRangeStyle4})
            Me.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.gridControl1.RowCount = 40
            Me.gridControl1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
            Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridControl1.Size = New System.Drawing.Size(884, 309)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.BorderStyle=BorderStyle.FixedSingle
            '
            'button1
            '
            Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.ForeColor = System.Drawing.Color.White
            Me.button1.Location = New System.Drawing.Point(16, 331)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(99, 27)
            Me.button1.TabIndex = 12
            Me.button1.Text = "Soap Serialize"
            Me.button1.UseVisualStyle = True
            '
            'ButtonAdv1
            '
            Me.ButtonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.ButtonAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ButtonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.ButtonAdv1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonAdv1.ForeColor = System.Drawing.Color.White
            Me.ButtonAdv1.Location = New System.Drawing.Point(121, 331)
            Me.ButtonAdv1.Name = "ButtonAdv1"
            Me.ButtonAdv1.Size = New System.Drawing.Size(102, 27)
            Me.ButtonAdv1.TabIndex = 13
            Me.ButtonAdv1.Text = "Soap Deserialize"
            Me.ButtonAdv1.UseVisualStyle = True
            '
            'ButtonAdv2
            '
            Me.ButtonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.ButtonAdv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ButtonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.ButtonAdv2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonAdv2.ForeColor = System.Drawing.Color.White
            Me.ButtonAdv2.Location = New System.Drawing.Point(229, 331)
            Me.ButtonAdv2.Name = "ButtonAdv2"
            Me.ButtonAdv2.Size = New System.Drawing.Size(98, 27)
            Me.ButtonAdv2.TabIndex = 14
            Me.ButtonAdv2.Text = "Binary Serialize"
            Me.ButtonAdv2.UseVisualStyle = True
            '
            'ButtonAdv3
            '
            Me.ButtonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.ButtonAdv3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ButtonAdv3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.ButtonAdv3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonAdv3.ForeColor = System.Drawing.Color.White
            Me.ButtonAdv3.Location = New System.Drawing.Point(333, 331)
            Me.ButtonAdv3.Name = "ButtonAdv3"
            Me.ButtonAdv3.Size = New System.Drawing.Size(117, 27)
            Me.ButtonAdv3.TabIndex = 15
            Me.ButtonAdv3.Text = "Binary Deserialize"
            Me.ButtonAdv3.UseVisualStyle = True
            '
            'ButtonAdv4
            '
            Me.ButtonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.ButtonAdv4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ButtonAdv4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.ButtonAdv4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonAdv4.ForeColor = System.Drawing.Color.White
            Me.ButtonAdv4.Location = New System.Drawing.Point(456, 331)
            Me.ButtonAdv4.Name = "ButtonAdv4"
            Me.ButtonAdv4.Size = New System.Drawing.Size(113, 27)
            Me.ButtonAdv4.TabIndex = 16
            Me.ButtonAdv4.Text = "Save XML Schema"
            Me.ButtonAdv4.UseVisualStyle = True
            '
            'ButtonAdv5
            '
            Me.ButtonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.ButtonAdv5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ButtonAdv5.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.ButtonAdv5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonAdv5.ForeColor = System.Drawing.Color.White
            Me.ButtonAdv5.Location = New System.Drawing.Point(575, 331)
            Me.ButtonAdv5.Name = "ButtonAdv5"
            Me.ButtonAdv5.Size = New System.Drawing.Size(118, 27)
            Me.ButtonAdv5.TabIndex = 17
            Me.ButtonAdv5.Text = "Load XML Schema"
            Me.ButtonAdv5.UseVisualStyle = True
            '
            'ButtonAdv6
            '
            Me.ButtonAdv6.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.ButtonAdv6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ButtonAdv6.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.ButtonAdv6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonAdv6.ForeColor = System.Drawing.Color.White
            Me.ButtonAdv6.Location = New System.Drawing.Point(699, 331)
            Me.ButtonAdv6.Name = "ButtonAdv6"
            Me.ButtonAdv6.Size = New System.Drawing.Size(136, 27)
            Me.ButtonAdv6.TabIndex = 18
            Me.ButtonAdv6.Text = "Reset Grid"
            Me.ButtonAdv6.UseVisualStyle = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(924, 366)
            Me.Controls.Add(Me.ButtonAdv6)
            Me.Controls.Add(Me.ButtonAdv5)
            Me.Controls.Add(Me.ButtonAdv4)
            Me.Controls.Add(Me.ButtonAdv3)
            Me.Controls.Add(Me.ButtonAdv2)
            Me.Controls.Add(Me.ButtonAdv1)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.gridControl1)
            Me.DropShadow = True
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Serialization Demo"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region


        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1)
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            

        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            
        End Sub

        Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs)
                    End Sub

        Private Sub button4_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            
        End Sub

        Private Sub button5_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            
        End Sub

        Private Sub button6_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            
        End Sub

        Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
             End Sub

        Private Sub button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
            'Serialization using Soap Formatter
            Dim dlg As FileDialog = New SaveFileDialog
            dlg.Filter = "Soap files (*.soap)|*.soap|All files (*.*)|*.*"
            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    Me.Cursor = Cursors.WaitCursor
                    'Save the grid model object to a stream in SOAP format
                    Me.gridControl1.Model.SaveSoap(dlg.FileName)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                Finally
                    Me.Cursor = Cursors.Default
                End Try
            End If
        End Sub

        Private Sub ButtonAdv1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdv1.Click
            'Deserialization using Soap Formatter
            Dim dlg As FileDialog = New OpenFileDialog
            dlg.Filter = "Soap files (*.soap)|*.soap|All files (*.*)|*.*"
            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    Me.Cursor = Cursors.WaitCursor
                    'Recreates a grid model object from a strem with data in SOAP format
                    Me.gridControl1.Model = GridModel.LoadSoap(dlg.FileName)
                    Me.gridControl1.Refresh()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                Finally
                    Me.Cursor = Cursors.Default
                End Try
            End If
        End Sub

        Private Sub ButtonAdv2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdv2.Click
            'Serialization using Binary Formatter
            Dim dlg As FileDialog = New SaveFileDialog
            dlg.Filter = "Binary files (*.egt)|*.egt|All files (*.*)|*.*"
            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    Me.Cursor = Cursors.WaitCursor
                    'Save the grid model object to a stream in Binary format
                    Me.gridControl1.Model.SaveBinary(dlg.FileName)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                Finally
                    Me.Cursor = Cursors.Default
                End Try
            End If

        End Sub

        Private Sub ButtonAdv3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdv3.Click
            'Deserialization using Binary Formatter
            Dim dlg As FileDialog = New OpenFileDialog
            dlg.Filter = "Binary files (*.egt)|*.egt|All files (*.*)|*.*"
            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    Me.Cursor = Cursors.WaitCursor
                    'Recreates a grid model object from a strem with data in Binary format
                    Me.gridControl1.Model = GridModel.LoadBinary(dlg.FileName)
                    Me.gridControl1.Refresh()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                Finally
                    Me.Cursor = Cursors.Default
                End Try
            End If
        End Sub

        Private Sub ButtonAdv4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdv4.Click
            'Xml Serialization
            Dim dlg As FileDialog = New SaveFileDialog
            dlg.Filter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*"
            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim s As Stream = Nothing

                Try
                    Me.Cursor = Cursors.WaitCursor
                    Me.gridControl1.SaveXml(dlg.FileName)
                Catch ex As Exception
                    s.Close()
                    MessageBox.Show(ex.ToString())
                Finally
                    Me.Cursor = Cursors.Default
                End Try
            End If
        End Sub

        Private Sub ButtonAdv5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdv5.Click
            'Xml Deserialization
            Dim dlg As FileDialog = New OpenFileDialog
            dlg.Filter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*"
            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim s As Stream = Nothing
                Try
                    Me.Cursor = Cursors.WaitCursor
                    Me.gridControl1.InitializeFromXml(dlg.FileName)
                    Me.gridControl1.Refresh()
                Catch ex As Exception
                    s.Close()
                    MessageBox.Show(ex.ToString())
                Finally
                    Me.Cursor = Cursors.Default
                End Try
            End If
        End Sub

        Private Sub ButtonAdv6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Me.gridControl1.ResetRangeStyles()
            Me.gridControl1.GridVisualStyles = GridVisualStyles.SystemTheme

        End Sub
    End Class
End Namespace
