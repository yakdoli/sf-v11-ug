Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System.IO

''' <summary>
''' Summary description for Form1.
''' </summary>
Public Class Form1
    Inherits Syncfusion.Windows.Forms.MetroForm
    Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private radioButton1 As System.Windows.Forms.RadioButton
    Private radioButton2 As System.Windows.Forms.RadioButton
    Private radioButton3 As System.Windows.Forms.RadioButton
    Private gradientPanel3 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Private dataSet11 As DataSet1
    Private groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents checkBox1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
    Private WithEvents checkBox2 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
    Private WithEvents checkBox3 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
    Private WithEvents checkBox4 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
    Private WithEvents checkBox5 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
    Private WithEvents checkBox7 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
    Private WithEvents checkBox8 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
    Private WithEvents checkBox9 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
    Private WithEvents checkBox10 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
    Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.Container = Nothing
    Private groupBox3 As GroupBox
    Private panel1 As Panel
    Private WithEvents checkBox11 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
    Private WithEvents checkBox12 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
    Private WithEvents checkBox13 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
    Private WithEvents checkBox14 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
    Private WithEvents checkBox6 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv

    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        Dim commandstring As String = "select * from Customers"
        Dim connection As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")
        Dim da As New SqlCeDataAdapter(commandstring, connection)
        Try
            da.Fill(dataSet11, "Customers")
        Catch ex As SqlException
            ShowErrorMessage(ex)
        End Try

        Me.gridControl1.RowCount = Me.dataSet11.Customers.Rows.Count
        Me.gridControl1.ColCount = Me.dataSet11.Customers.Columns.Count

        Me.gridControl1.PopulateValues(GridRangeInfo.Cells(1, 1, gridControl1.RowCount, gridControl1.ColCount), dataSet11.Customers)
        Me.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cols(1, gridControl1.ColCount))
        Me.gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Cols(1, gridControl1.RowCount))

        Me.gridControl1.BackColor = Color.White

        AddHandler gridControl1.QueryCellInfo, AddressOf gridControl1_QueryCellInfo
        Me.gridControl1.AlphaBlendSelectionColor = Color.CornflowerBlue
        Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Try
            Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
    End Sub
#Region "Method"
    Private Function FindFile(ByVal connstring As String) As String
        connstring = "common\data\" & connstring
        For n As Integer = 0 To 9
            If System.IO.File.Exists(connstring) Then
                Return New FileInfo(connstring).FullName
            End If
            connstring = "..\" & connstring
        Next n

        Return connstring
    End Function

    Private Function GetIconFile(ByVal bitmapName As String) As String
        For n As Integer = 0 To 9
            If System.IO.File.Exists(bitmapName) Then
                Return bitmapName
            End If

            bitmapName = "..\" & bitmapName
        Next n

        Return bitmapName
    End Function


    Private Shared Sub ShowErrorMessage(ByVal ex As SqlException)
        If ex.Number = 11001 Then
            MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If ex.Number = 208 Then
            MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If ex.Number = 156 OrElse ex.Number = 102 Then
            MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private inCheckAll As Boolean = False
    Private Sub CheckAll(ByVal b As Boolean)
        inCheckAll = True
        checkBox1.Checked = b
        checkBox3.Checked = b
        checkBox4.Checked = b
        checkBox5.Checked = b
        checkBox6.Checked = b
        checkBox7.Checked = b
        checkBox8.Checked = b
        checkBox9.Checked = b
        checkBox10.Checked = b
        inCheckAll = False
    End Sub

    Private inCheck As Boolean = False
    Private Sub Check(ByVal checkBox As Syncfusion.Windows.Forms.Tools.CheckBoxAdv, ByVal flag As GridSelectionFlags)
        checkListUnchecked()
        If inCheckAll Then
            Return
        End If
        inCheck = True
        If checkBox.Checked Then
            Me.gridControl1.ListBoxSelectionMode = SelectionMode.None
            Me.gridControl1.AllowSelection = Me.gridControl1.AllowSelection Or flag
        Else
            Me.gridControl1.AllowSelection = Me.gridControl1.AllowSelection And Not flag
        End If

        checkBox2.Checked = False
        inCheck = False

    End Sub

#End Region

#Region "Windows Form Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim GridBaseStyle17 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
        Dim GridBaseStyle18 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
        Dim GridBaseStyle19 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
        Dim GridBaseStyle20 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
        Dim GridRangeStyle85 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle86 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle87 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle88 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle89 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle90 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle91 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle92 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle93 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle94 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle95 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle96 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle97 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle98 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle99 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle100 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle101 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle102 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle103 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle104 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Dim GridRangeStyle105 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
        Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioButton3 = New System.Windows.Forms.RadioButton()
        Me.radioButton2 = New System.Windows.Forms.RadioButton()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.gradientPanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
        Me.dataSet11 = New DataSet1()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.checkBox10 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
        Me.checkBox9 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
        Me.checkBox8 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
        Me.checkBox7 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
        Me.checkBox6 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
        Me.checkBox5 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
        Me.checkBox4 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
        Me.checkBox3 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
        Me.checkBox2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
        Me.checkBox1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.checkBox11 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
        Me.checkBox12 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
        Me.checkBox13 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
        Me.checkBox14 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
        Me.panel1 = New System.Windows.Forms.Panel()
        CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gradientPanel2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        CType(Me.checkBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.SuspendLayout()
        CType(Me.checkBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gradientPanel2
        '
        Me.gradientPanel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.Maroon, System.Drawing.Color.IndianRed)
        Me.gradientPanel2.Controls.Add(Me.groupBox1)
        Me.gradientPanel2.Location = New System.Drawing.Point(2, 46)
        Me.gradientPanel2.Name = "gradientPanel2"
        Me.gradientPanel2.Size = New System.Drawing.Size(0, 0)
        Me.gradientPanel2.TabIndex = 1
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.radioButton3)
        Me.groupBox1.Controls.Add(Me.radioButton2)
        Me.groupBox1.Controls.Add(Me.radioButton1)
        Me.groupBox1.ForeColor = System.Drawing.Color.White
        Me.groupBox1.Location = New System.Drawing.Point(8, 8)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(184, 120)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Selection Mode"
        '
        'radioButton3
        '
        Me.radioButton3.ForeColor = System.Drawing.Color.White
        Me.radioButton3.Location = New System.Drawing.Point(8, 88)
        Me.radioButton3.Name = "radioButton3"
        Me.radioButton3.Size = New System.Drawing.Size(104, 24)
        Me.radioButton3.TabIndex = 2
        Me.radioButton3.Text = "MultiExtended"
        '
        'radioButton2
        '
        Me.radioButton2.ForeColor = System.Drawing.Color.White
        Me.radioButton2.Location = New System.Drawing.Point(8, 56)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(104, 24)
        Me.radioButton2.TabIndex = 1
        Me.radioButton2.Text = "MultiSimple"
        '
        'radioButton1
        '
        Me.radioButton1.ForeColor = System.Drawing.Color.White
        Me.radioButton1.Location = New System.Drawing.Point(8, 24)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(104, 24)
        Me.radioButton1.TabIndex = 0
        Me.radioButton1.Text = "One"
        '
        'gradientPanel3
        '
        Me.gradientPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gradientPanel3.Border3DStyle = System.Windows.Forms.Border3DStyle.Adjust
        Me.gradientPanel3.Location = New System.Drawing.Point(9, 32)
        Me.gradientPanel3.Name = "gradientPanel3"
        Me.gradientPanel3.Size = New System.Drawing.Size(506, 0)
        Me.gradientPanel3.TabIndex = 3
        '
        'gridControl1
        '
        Me.gridControl1.AllowSelection = CType(((((((Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Row Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Table) _
            Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Cell) _
            Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Multiple) _
            Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Shift) _
            Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Keyboard) _
            Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.AlphaBlend), Syncfusion.Windows.Forms.Grid.GridSelectionFlags)
        Me.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.gridControl1.BackColor = System.Drawing.Color.White
        GridBaseStyle17.Name = "Header"
        GridBaseStyle17.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle17.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle17.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle17.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
        GridBaseStyle17.StyleInfo.CellType = "Header"
        GridBaseStyle17.StyleInfo.Font.Bold = True
        GridBaseStyle17.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
        GridBaseStyle17.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
        GridBaseStyle18.Name = "Standard"
        GridBaseStyle18.StyleInfo.Font.Facename = "Tahoma"
        GridBaseStyle18.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
        GridBaseStyle19.Name = "Row Header"
        GridBaseStyle19.StyleInfo.BaseStyle = "Header"
        GridBaseStyle19.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
        GridBaseStyle19.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
        GridBaseStyle20.Name = "Column Header"
        GridBaseStyle20.StyleInfo.BaseStyle = "Header"
        GridBaseStyle20.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
        Me.gridControl1.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle17, GridBaseStyle18, GridBaseStyle19, GridBaseStyle20})
        Me.gridControl1.ColCount = 5
        Me.gridControl1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35), New Syncfusion.Windows.Forms.Grid.GridColWidth(1, 126), New Syncfusion.Windows.Forms.Grid.GridColWidth(2, 127), New Syncfusion.Windows.Forms.Grid.GridColWidth(3, 113), New Syncfusion.Windows.Forms.Grid.GridColWidth(4, 109), New Syncfusion.Windows.Forms.Grid.GridColWidth(5, 139)})
        Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
        Me.gridControl1.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.gridControl1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
        Me.gridControl1.Location = New System.Drawing.Point(12, 14)
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.NumberedColHeaders = False
        Me.gridControl1.NumberedRowHeaders = False
        Me.gridControl1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.gridControl1.Properties.MarkColHeader = False
        Me.gridControl1.Properties.MarkRowHeader = False
        GridRangeStyle85.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
        GridRangeStyle85.StyleInfo.Font.Bold = False
        GridRangeStyle85.StyleInfo.Font.Facename = "Verdana"
        GridRangeStyle85.StyleInfo.Font.Italic = False
        GridRangeStyle85.StyleInfo.Font.Size = 8.5!
        GridRangeStyle85.StyleInfo.Font.Strikeout = False
        GridRangeStyle85.StyleInfo.Font.Underline = False
        GridRangeStyle85.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
        GridRangeStyle86.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
        GridRangeStyle86.StyleInfo.Font.Bold = False
        GridRangeStyle86.StyleInfo.Font.Facename = "Verdana"
        GridRangeStyle86.StyleInfo.Font.Italic = False
        GridRangeStyle86.StyleInfo.Font.Size = 8.5!
        GridRangeStyle86.StyleInfo.Font.Strikeout = False
        GridRangeStyle86.StyleInfo.Font.Underline = False
        GridRangeStyle86.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
        GridRangeStyle87.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
        GridRangeStyle87.StyleInfo.Font.Bold = False
        GridRangeStyle87.StyleInfo.Font.Facename = "Verdana"
        GridRangeStyle87.StyleInfo.Font.Italic = False
        GridRangeStyle87.StyleInfo.Font.Size = 8.5!
        GridRangeStyle87.StyleInfo.Font.Strikeout = False
        GridRangeStyle87.StyleInfo.Font.Underline = False
        GridRangeStyle87.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
        GridRangeStyle88.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
        GridRangeStyle88.StyleInfo.Font.Bold = False
        GridRangeStyle88.StyleInfo.Font.Facename = "Verdana"
        GridRangeStyle88.StyleInfo.Font.Italic = False
        GridRangeStyle88.StyleInfo.Font.Size = 8.5!
        GridRangeStyle88.StyleInfo.Font.Strikeout = False
        GridRangeStyle88.StyleInfo.Font.Underline = False
        GridRangeStyle88.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
        GridRangeStyle89.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
        GridRangeStyle89.StyleInfo.Font.Bold = False
        GridRangeStyle89.StyleInfo.Font.Facename = "Verdana"
        GridRangeStyle89.StyleInfo.Font.Italic = False
        GridRangeStyle89.StyleInfo.Font.Size = 8.5!
        GridRangeStyle89.StyleInfo.Font.Strikeout = False
        GridRangeStyle89.StyleInfo.Font.Underline = False
        GridRangeStyle89.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
        GridRangeStyle90.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
        GridRangeStyle90.StyleInfo.Font.Bold = False
        GridRangeStyle90.StyleInfo.Font.Facename = "Verdana"
        GridRangeStyle90.StyleInfo.Font.Italic = False
        GridRangeStyle90.StyleInfo.Font.Size = 8.5!
        GridRangeStyle90.StyleInfo.Font.Strikeout = False
        GridRangeStyle90.StyleInfo.Font.Underline = False
        GridRangeStyle90.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
        GridRangeStyle91.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
        GridRangeStyle91.StyleInfo.Font.Bold = False
        GridRangeStyle91.StyleInfo.Font.Facename = "Verdana"
        GridRangeStyle91.StyleInfo.Font.Italic = False
        GridRangeStyle91.StyleInfo.Font.Size = 8.5!
        GridRangeStyle91.StyleInfo.Font.Strikeout = False
        GridRangeStyle91.StyleInfo.Font.Underline = False
        GridRangeStyle91.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
        GridRangeStyle92.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
        GridRangeStyle92.StyleInfo.Font.Bold = False
        GridRangeStyle92.StyleInfo.Font.Facename = "Verdana"
        GridRangeStyle92.StyleInfo.Font.Italic = False
        GridRangeStyle92.StyleInfo.Font.Size = 8.5!
        GridRangeStyle92.StyleInfo.Font.Strikeout = False
        GridRangeStyle92.StyleInfo.Font.Underline = False
        GridRangeStyle92.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
        GridRangeStyle93.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
        GridRangeStyle93.StyleInfo.Font.Bold = False
        GridRangeStyle93.StyleInfo.Font.Facename = "Verdana"
        GridRangeStyle93.StyleInfo.Font.Italic = False
        GridRangeStyle93.StyleInfo.Font.Size = 8.5!
        GridRangeStyle93.StyleInfo.Font.Strikeout = False
        GridRangeStyle93.StyleInfo.Font.Underline = False
        GridRangeStyle93.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
        GridRangeStyle94.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
        GridRangeStyle94.StyleInfo.Font.Bold = False
        GridRangeStyle94.StyleInfo.Font.Facename = "Verdana"
        GridRangeStyle94.StyleInfo.Font.Italic = False
        GridRangeStyle94.StyleInfo.Font.Size = 8.5!
        GridRangeStyle94.StyleInfo.Font.Strikeout = False
        GridRangeStyle94.StyleInfo.Font.Underline = False
        GridRangeStyle94.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
        GridRangeStyle95.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
        GridRangeStyle95.StyleInfo.Font.Bold = False
        GridRangeStyle95.StyleInfo.Font.Facename = "Verdana"
        GridRangeStyle95.StyleInfo.Font.Italic = False
        GridRangeStyle95.StyleInfo.Font.Size = 8.5!
        GridRangeStyle95.StyleInfo.Font.Strikeout = False
        GridRangeStyle95.StyleInfo.Font.Underline = False
        GridRangeStyle95.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
        GridRangeStyle96.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
        GridRangeStyle96.StyleInfo.Font.Bold = False
        GridRangeStyle96.StyleInfo.Font.Facename = "Verdana"
        GridRangeStyle96.StyleInfo.Font.Italic = False
        GridRangeStyle96.StyleInfo.Font.Size = 8.5!
        GridRangeStyle96.StyleInfo.Font.Strikeout = False
        GridRangeStyle96.StyleInfo.Font.Underline = False
        GridRangeStyle96.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
        GridRangeStyle97.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
        GridRangeStyle97.StyleInfo.Font.Bold = False
        GridRangeStyle97.StyleInfo.Font.Facename = "Verdana"
        GridRangeStyle97.StyleInfo.Font.Italic = False
        GridRangeStyle97.StyleInfo.Font.Size = 8.5!
        GridRangeStyle97.StyleInfo.Font.Strikeout = False
        GridRangeStyle97.StyleInfo.Font.Underline = False
        GridRangeStyle97.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
        GridRangeStyle98.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
        GridRangeStyle98.StyleInfo.Font.Bold = False
        GridRangeStyle98.StyleInfo.Font.Facename = "Verdana"
        GridRangeStyle98.StyleInfo.Font.Italic = False
        GridRangeStyle98.StyleInfo.Font.Size = 8.5!
        GridRangeStyle98.StyleInfo.Font.Strikeout = False
        GridRangeStyle98.StyleInfo.Font.Underline = False
        GridRangeStyle98.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
        GridRangeStyle99.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
        GridRangeStyle99.StyleInfo.Font.Bold = False
        GridRangeStyle99.StyleInfo.Font.Facename = "Verdana"
        GridRangeStyle99.StyleInfo.Font.Italic = False
        GridRangeStyle99.StyleInfo.Font.Size = 8.5!
        GridRangeStyle99.StyleInfo.Font.Strikeout = False
        GridRangeStyle99.StyleInfo.Font.Underline = False
        GridRangeStyle99.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
        GridRangeStyle100.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
        GridRangeStyle100.StyleInfo.Font.Bold = False
        GridRangeStyle100.StyleInfo.Font.Facename = "Verdana"
        GridRangeStyle100.StyleInfo.Font.Italic = False
        GridRangeStyle100.StyleInfo.Font.Size = 8.5!
        GridRangeStyle100.StyleInfo.Font.Strikeout = False
        GridRangeStyle100.StyleInfo.Font.Underline = False
        GridRangeStyle100.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
        GridRangeStyle100.StyleInfo.TextColor = System.Drawing.Color.MidnightBlue
        GridRangeStyle101.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 1)
        GridRangeStyle101.StyleInfo.Text = "Contact Name"
        GridRangeStyle102.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 2)
        GridRangeStyle102.StyleInfo.Text = "CompanyName"
        GridRangeStyle103.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 3)
        GridRangeStyle103.StyleInfo.Text = "Address"
        GridRangeStyle104.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 4)
        GridRangeStyle104.StyleInfo.Text = "City"
        GridRangeStyle105.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 5)
        GridRangeStyle105.StyleInfo.Text = "Country"
        Me.gridControl1.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() {GridRangeStyle85, GridRangeStyle86, GridRangeStyle87, GridRangeStyle88, GridRangeStyle89, GridRangeStyle90, GridRangeStyle91, GridRangeStyle92, GridRangeStyle93, GridRangeStyle94, GridRangeStyle95, GridRangeStyle96, GridRangeStyle97, GridRangeStyle98, GridRangeStyle99, GridRangeStyle100, GridRangeStyle101, GridRangeStyle102, GridRangeStyle103, GridRangeStyle104, GridRangeStyle105})
        Me.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gridControl1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
        Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
        Me.gridControl1.Size = New System.Drawing.Size(506, 267)
        Me.gridControl1.SmartSizeBox = False
        Me.gridControl1.TabIndex = 0
        Me.gridControl1.ThemesEnabled = True
        '
        'dataSet11
        '
        Me.dataSet11.DataSetName = "DataSet1"
        Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'groupBox2
        '
        Me.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.groupBox2.BackColor = System.Drawing.Color.White
        Me.groupBox2.Controls.Add(Me.checkBox10)
        Me.groupBox2.Controls.Add(Me.checkBox9)
        Me.groupBox2.Controls.Add(Me.checkBox8)
        Me.groupBox2.Controls.Add(Me.checkBox7)
        Me.groupBox2.Controls.Add(Me.checkBox6)
        Me.groupBox2.Controls.Add(Me.checkBox5)
        Me.groupBox2.Controls.Add(Me.checkBox4)
        Me.groupBox2.Controls.Add(Me.checkBox3)
        Me.groupBox2.Controls.Add(Me.checkBox2)
        Me.groupBox2.Controls.Add(Me.checkBox1)
        Me.groupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.ForeColor = System.Drawing.Color.Black
        Me.groupBox2.Location = New System.Drawing.Point(542, 7)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(241, 176)
        Me.groupBox2.TabIndex = 0
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Selection Modes"
        '
        'checkBox10
        '
        Me.checkBox10.BackColor = System.Drawing.Color.White
        Me.checkBox10.DrawFocusRectangle = False
        Me.checkBox10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox10.Location = New System.Drawing.Point(146, 145)
        Me.checkBox10.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.checkBox10.Name = "checkBox10"
        Me.checkBox10.Size = New System.Drawing.Size(89, 24)
        Me.checkBox10.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.checkBox10.TabIndex = 9
        Me.checkBox10.Text = "Table"
        Me.checkBox10.ThemesEnabled = False
        '
        'checkBox9
        '
        Me.checkBox9.BackColor = System.Drawing.Color.White
        Me.checkBox9.DrawFocusRectangle = False
        Me.checkBox9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox9.Location = New System.Drawing.Point(10, 143)
        Me.checkBox9.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.checkBox9.Name = "checkBox9"
        Me.checkBox9.Size = New System.Drawing.Size(104, 24)
        Me.checkBox9.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.checkBox9.TabIndex = 8
        Me.checkBox9.Text = "Shift"
        Me.checkBox9.ThemesEnabled = False
        '
        'checkBox8
        '
        Me.checkBox8.BackColor = System.Drawing.Color.White
        Me.checkBox8.DrawFocusRectangle = False
        Me.checkBox8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox8.Location = New System.Drawing.Point(146, 115)
        Me.checkBox8.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.checkBox8.Name = "checkBox8"
        Me.checkBox8.Size = New System.Drawing.Size(89, 24)
        Me.checkBox8.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.checkBox8.TabIndex = 7
        Me.checkBox8.Text = "Row"
        Me.checkBox8.ThemesEnabled = False
        '
        'checkBox7
        '
        Me.checkBox7.BackColor = System.Drawing.Color.White
        Me.checkBox7.DrawFocusRectangle = False
        Me.checkBox7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox7.Location = New System.Drawing.Point(146, 83)
        Me.checkBox7.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.checkBox7.Name = "checkBox7"
        Me.checkBox7.Size = New System.Drawing.Size(89, 24)
        Me.checkBox7.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.checkBox7.TabIndex = 6
        Me.checkBox7.Text = "Multiple"
        Me.checkBox7.ThemesEnabled = False
        '
        'checkBox6
        '
        Me.checkBox6.BackColor = System.Drawing.Color.White
        Me.checkBox6.DrawFocusRectangle = False
        Me.checkBox6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox6.Location = New System.Drawing.Point(10, 113)
        Me.checkBox6.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.checkBox6.Name = "checkBox6"
        Me.checkBox6.Size = New System.Drawing.Size(119, 24)
        Me.checkBox6.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.checkBox6.TabIndex = 5
        Me.checkBox6.Text = "MixRangeType"
        Me.checkBox6.ThemesEnabled = False
        '
        'checkBox5
        '
        Me.checkBox5.BackColor = System.Drawing.Color.White
        Me.checkBox5.DrawFocusRectangle = False
        Me.checkBox5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox5.Location = New System.Drawing.Point(10, 83)
        Me.checkBox5.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.checkBox5.Name = "checkBox5"
        Me.checkBox5.Size = New System.Drawing.Size(105, 24)
        Me.checkBox5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.checkBox5.TabIndex = 4
        Me.checkBox5.Text = "Keyboard"
        Me.checkBox5.ThemesEnabled = False
        '
        'checkBox4
        '
        Me.checkBox4.BackColor = System.Drawing.Color.White
        Me.checkBox4.DrawFocusRectangle = False
        Me.checkBox4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox4.Location = New System.Drawing.Point(146, 53)
        Me.checkBox4.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.checkBox4.Name = "checkBox4"
        Me.checkBox4.Size = New System.Drawing.Size(89, 24)
        Me.checkBox4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.checkBox4.TabIndex = 3
        Me.checkBox4.Text = "Column"
        Me.checkBox4.ThemesEnabled = False
        '
        'checkBox3
        '
        Me.checkBox3.BackColor = System.Drawing.Color.White
        Me.checkBox3.DrawFocusRectangle = False
        Me.checkBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox3.Location = New System.Drawing.Point(146, 21)
        Me.checkBox3.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(89, 24)
        Me.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.checkBox3.TabIndex = 2
        Me.checkBox3.Text = "Cell"
        Me.checkBox3.ThemesEnabled = False
        '
        'checkBox2
        '
        Me.checkBox2.BackColor = System.Drawing.Color.White
        Me.checkBox2.DrawFocusRectangle = False
        Me.checkBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox2.Location = New System.Drawing.Point(10, 53)
        Me.checkBox2.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(104, 24)
        Me.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "Any"
        Me.checkBox2.ThemesEnabled = False
        '
        'checkBox1
        '
        Me.checkBox1.BackColor = System.Drawing.Color.White
        Me.checkBox1.DrawFocusRectangle = False
        Me.checkBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox1.Location = New System.Drawing.Point(10, 21)
        Me.checkBox1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(104, 24)
        Me.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "AlphaBlend"
        Me.checkBox1.ThemesEnabled = False
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.checkBox11)
        Me.groupBox3.Controls.Add(Me.checkBox12)
        Me.groupBox3.Controls.Add(Me.checkBox13)
        Me.groupBox3.Controls.Add(Me.checkBox14)
        Me.groupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox3.ForeColor = System.Drawing.Color.Black
        Me.groupBox3.Location = New System.Drawing.Point(542, 188)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(241, 90)
        Me.groupBox3.TabIndex = 1
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "ListBox Selection Modes"
        '
        'checkBox11
        '
        Me.checkBox11.BackColor = System.Drawing.Color.White
        Me.checkBox11.DrawFocusRectangle = False
        Me.checkBox11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox11.Location = New System.Drawing.Point(10, 23)
        Me.checkBox11.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.checkBox11.Name = "checkBox11"
        Me.checkBox11.Size = New System.Drawing.Size(119, 24)
        Me.checkBox11.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.checkBox11.TabIndex = 9
        Me.checkBox11.Text = "MultiSimple"
        Me.checkBox11.ThemesEnabled = False
        '
        'checkBox12
        '
        Me.checkBox12.BackColor = System.Drawing.Color.White
        Me.checkBox12.DrawFocusRectangle = False
        Me.checkBox12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox12.Location = New System.Drawing.Point(146, 23)
        Me.checkBox12.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.checkBox12.Name = "checkBox12"
        Me.checkBox12.Size = New System.Drawing.Size(75, 24)
        Me.checkBox12.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.checkBox12.TabIndex = 8
        Me.checkBox12.Text = "One"
        Me.checkBox12.ThemesEnabled = False
        '
        'checkBox13
        '
        Me.checkBox13.BackColor = System.Drawing.Color.White
        Me.checkBox13.DrawFocusRectangle = False
        Me.checkBox13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox13.Location = New System.Drawing.Point(10, 53)
        Me.checkBox13.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.checkBox13.Name = "checkBox13"
        Me.checkBox13.Size = New System.Drawing.Size(104, 24)
        Me.checkBox13.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.checkBox13.TabIndex = 7
        Me.checkBox13.Text = "MultiExtended"
        Me.checkBox13.ThemesEnabled = False
        '
        'checkBox14
        '
        Me.checkBox14.BackColor = System.Drawing.Color.White
        Me.checkBox14.DrawFocusRectangle = False
        Me.checkBox14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox14.Location = New System.Drawing.Point(146, 53)
        Me.checkBox14.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.checkBox14.Name = "checkBox14"
        Me.checkBox14.Size = New System.Drawing.Size(75, 24)
        Me.checkBox14.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.checkBox14.TabIndex = 6
        Me.checkBox14.Text = "None"
        Me.checkBox14.ThemesEnabled = False
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Gray
        Me.panel1.Location = New System.Drawing.Point(530, 16)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1, 260)
        Me.panel1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 296)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.gridControl1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.gradientPanel3)
        Me.DropShadow = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
		Me.BorderThickness = 2
        Me.Text = "Selection Mode Demo"
        CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gradientPanel2.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        CType(Me.checkBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        CType(Me.checkBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkBox14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    Shared Sub Main()
        Application.Run(New Form1())
    End Sub

#Region "EventHandler"
    Private Sub checkBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox1.CheckedChanged
        Check(checkBox1, GridSelectionFlags.AlphaBlend)
    End Sub

    Private Sub checkBox11_CheckedChanged(sender As System.Object, e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox11.CheckedChanged
        CheckAll(False)
        checkBox13.Checked = False
        checkBox12.Checked = False
        checkBox14.Checked = False
        Me.gridControl1.ListBoxSelectionMode = SelectionMode.MultiSimple
    End Sub

    Private Sub checkBox12_CheckStateChanged(sender As System.Object, e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox12.CheckedChanged
        CheckAll(False)
        checkBox13.Checked = False
        checkBox11.Checked = False
        checkBox14.Checked = False
        Me.gridControl1.ListBoxSelectionMode = SelectionMode.One
    End Sub

    Private Sub checkBox13_CheckedChanged(sender As System.Object, e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox13.CheckedChanged
        CheckAll(False)
        checkBox11.Checked = False
        checkBox12.Checked = False
        checkBox14.Checked = False
        Me.gridControl1.ListBoxSelectionMode = SelectionMode.MultiExtended
    End Sub

    Private Sub checkBox14_CheckedChanged(sender As System.Object, e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox14.CheckedChanged
        checkSelectionUnchecked()
        checkBox13.Checked = False
        checkBox12.Checked = False
        checkBox11.Checked = False
        Me.gridControl1.ListBoxSelectionMode = SelectionMode.None
    End Sub

    Private Sub gridControl1_QueryCellInfo(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
        If e.RowIndex > 0 AndAlso e.ColIndex > 0 Then
            e.Style.TextColor = Color.MidnightBlue
        End If
        If e.RowIndex = 0 Then
            e.Style.TextColor = Color.MidnightBlue
            e.Style.Font.Facename = "Verdana"
            e.Style.Font.Size = 8.5F
        End If
    End Sub
#End Region
    Private Sub checkSelectionUnchecked()
        checkBox1.Checked = False
        checkBox2.Checked = False
        checkBox3.Checked = False
        checkBox4.Checked = False
        checkBox5.Checked = False
        checkBox6.Checked = False
        checkBox7.Checked = False
        checkBox8.Checked = False
        checkBox9.Checked = False
        checkBox10.Checked = False

    End Sub
    Private Sub checkListUnchecked()
        checkBox11.Checked = False
        checkBox12.Checked = False
        checkBox13.Checked = False
        checkBox14.Checked = False
    End Sub
  
    Private Sub checkBox4_CheckedChanged(sender As System.Object, e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox4.CheckedChanged
        Check(checkBox4, GridSelectionFlags.Column)
    End Sub
    Private Sub checkBox2_CheckedChanged(sender As System.Object, e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox2.CheckedChanged
        If inCheck Then
            Return
        End If

        If checkBox2.Checked Then
            CheckAll(True)
            Me.gridControl1.AllowSelection = GridSelectionFlags.Any ' (GridSelectionFlags)(this.gridControl1.AllowSelection | GridSelectionFlags.Any);
        Else
            CheckAll(False)
            Me.gridControl1.AllowSelection = GridSelectionFlags.None ' (GridSelectionFlags)(this.gridControl1.AllowSelection & ~GridSelectionFlags.Any);
        End If
    End Sub
    Private Sub checkBox3_CheckedChanged(sender As System.Object, e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox3.CheckedChanged
        Check(checkBox3, GridSelectionFlags.Cell)
    End Sub

    Private Sub checkBox5_CheckedChanged(sender As System.Object, e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox5.CheckedChanged
        Check(checkBox5, GridSelectionFlags.Keyboard)
    End Sub

    Private Sub checkBox7_CheckedChanged(sender As System.Object, e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox7.CheckedChanged
        Check(checkBox7, GridSelectionFlags.Multiple)
    End Sub

    Private Sub checkBox6_CheckedChanged(sender As System.Object, e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox6.CheckedChanged
        Check(checkBox6, GridSelectionFlags.MixRangeType)
    End Sub

    Private Sub checkBox8_CheckedChanged(sender As System.Object, e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox8.CheckedChanged
        Check(checkBox8, GridSelectionFlags.Row)
    End Sub

    Private Sub checkBox9_CheckedChanged(sender As System.Object, e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox9.CheckedChanged
        Check(checkBox9, GridSelectionFlags.Shift)
    End Sub

    Private Sub checkBox10_CheckedChanged(sender As System.Object, e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox10.CheckedChanged
        Check(checkBox10, GridSelectionFlags.Table)
    End Sub
End Class

