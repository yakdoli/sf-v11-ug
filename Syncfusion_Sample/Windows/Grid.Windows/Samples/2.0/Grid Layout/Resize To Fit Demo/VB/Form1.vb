Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms

Namespace ResizeToFit
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Syncfusion.Windows.Forms.MetroForm
		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private groupBox3 As GroupBox
		Private WithEvents radioButtonAdv3 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents radioButtonAdv4 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private groupBox2 As GroupBox
		Private WithEvents radioButtonAdv11 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents radioButtonAdv12 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private groupBox1 As GroupBox
		Private WithEvents radioButtonAdv2 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
        Private WithEvents radioButtonAdv1 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Private WithEvents RadioButtonAdv8 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
        Private WithEvents RadioButtonAdv7 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
        Private WithEvents RadioButtonAdv6 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
        Private WithEvents RadioButtonAdv5 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
        Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Private WithEvents ButtonAdv5 As Syncfusion.Windows.Forms.ButtonAdv
        Friend WithEvents Label3 As System.Windows.Forms.Label
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Me.RadioButtonAdv8.Checked = True
            Try
                Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
                Me.Icon = ico
            Catch
            End Try

        End Sub

#Region "Method"
        Private Function GetIconFile(ByVal bitmapName As String) As String
            For n As Integer = 0 To 9
                If System.IO.File.Exists(bitmapName) Then
                    Return bitmapName
                End If

                bitmapName = "..\" & bitmapName
            Next n

            Return bitmapName
        End Function

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

        Private Function GetTable() As DataTable
            Dim dt As New DataTable("MyTable")

            Dim nCols As Integer = 12
            Dim nRows As Integer = 30
            Dim n As Long = 10000
            For i As Integer = 0 To nCols - 1
                dt.Columns.Add(New DataColumn(String.Format("Col{0}", i)))
            Next i

            For i As Integer = 0 To nRows - 1
                Dim dr As DataRow = dt.NewRow()
                For j As Integer = 0 To nCols - 1
                    n += 10
                    If j = 0 Then
                        dr(j) = n * n * n
                    Else
                        dr(j) = String.Format("row{0} col{1}", i, j)
                    End If
                Next j
                dt.Rows.Add(dr)
            Next i
            Return dt
        End Function
#End Region

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim GridRangeStyle1 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
            Me.groupBox3 = New System.Windows.Forms.GroupBox()
            Me.radioButtonAdv3 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
            Me.radioButtonAdv4 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
            Me.groupBox2 = New System.Windows.Forms.GroupBox()
            Me.radioButtonAdv11 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
            Me.radioButtonAdv12 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.radioButtonAdv2 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
            Me.radioButtonAdv1 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.TextBox3 = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.ButtonAdv5 = New Syncfusion.Windows.Forms.ButtonAdv()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.RadioButtonAdv8 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
            Me.RadioButtonAdv7 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
            Me.RadioButtonAdv6 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
            Me.RadioButtonAdv5 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
            Me.TextBox2 = New System.Windows.Forms.TextBox()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox3.SuspendLayout()
            CType(Me.radioButtonAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox2.SuspendLayout()
            CType(Me.radioButtonAdv11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv12, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            CType(Me.radioButtonAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox4.SuspendLayout()
            CType(Me.RadioButtonAdv8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadioButtonAdv7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadioButtonAdv6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadioButtonAdv5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.gridControl1.ApplyVisualStyles = False
            Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gridControl1.ColCount = 12
            Me.gridControl1.DefaultRowHeight = 20
            Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.5!)
            Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridControl1.Location = New System.Drawing.Point(12, 24)
            Me.gridControl1.MetroScrollBars = True
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
            Me.gridControl1.Properties.MarkColHeader = False
            Me.gridControl1.Properties.MarkRowHeader = False
            GridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle1.StyleInfo.Font.Bold = False
            GridRangeStyle1.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle1.StyleInfo.Font.Italic = False
            GridRangeStyle1.StyleInfo.Font.Size = 8.5!
            GridRangeStyle1.StyleInfo.Font.Strikeout = False
            GridRangeStyle1.StyleInfo.Font.Underline = False
            GridRangeStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            Me.gridControl1.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() {GridRangeStyle1})
            Me.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.gridControl1.RowCount = 30
            Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridControl1.Size = New System.Drawing.Size(586, 445)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ThemesEnabled = True
            '
            'groupBox3
            '
            Me.groupBox3.Controls.Add(Me.radioButtonAdv3)
            Me.groupBox3.Controls.Add(Me.radioButtonAdv4)
            Me.groupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox3.Location = New System.Drawing.Point(624, 155)
            Me.groupBox3.Name = "groupBox3"
            Me.groupBox3.Size = New System.Drawing.Size(246, 71)
            Me.groupBox3.TabIndex = 13
            Me.groupBox3.TabStop = False
            Me.groupBox3.Text = "ReSizeToFitOptimized"
            '
            'radioButtonAdv3
            '
            Me.radioButtonAdv3.DrawFocusRectangle = False
            Me.radioButtonAdv3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButtonAdv3.Location = New System.Drawing.Point(16, 48)
            Me.radioButtonAdv3.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.radioButtonAdv3.Name = "radioButtonAdv3"
            Me.radioButtonAdv3.Size = New System.Drawing.Size(121, 21)
            Me.radioButtonAdv3.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radioButtonAdv3.TabIndex = 3
            Me.radioButtonAdv3.Text = "RowHeight"
            Me.radioButtonAdv3.ThemesEnabled = False
            '
            'radioButtonAdv4
            '
            Me.radioButtonAdv4.DrawFocusRectangle = False
            Me.radioButtonAdv4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButtonAdv4.Location = New System.Drawing.Point(16, 21)
            Me.radioButtonAdv4.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.radioButtonAdv4.Name = "radioButtonAdv4"
            Me.radioButtonAdv4.Size = New System.Drawing.Size(121, 21)
            Me.radioButtonAdv4.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radioButtonAdv4.TabIndex = 2
            Me.radioButtonAdv4.Text = "ColWidths"
            Me.radioButtonAdv4.ThemesEnabled = False
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.radioButtonAdv11)
            Me.groupBox2.Controls.Add(Me.radioButtonAdv12)
            Me.groupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox2.Location = New System.Drawing.Point(624, 79)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(246, 77)
            Me.groupBox2.TabIndex = 12
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "ReSizeToFit"
            '
            'radioButtonAdv11
            '
            Me.radioButtonAdv11.DrawFocusRectangle = False
            Me.radioButtonAdv11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButtonAdv11.Location = New System.Drawing.Point(16, 48)
            Me.radioButtonAdv11.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.radioButtonAdv11.Name = "radioButtonAdv11"
            Me.radioButtonAdv11.Size = New System.Drawing.Size(121, 23)
            Me.radioButtonAdv11.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radioButtonAdv11.TabIndex = 3
            Me.radioButtonAdv11.Text = "RowHeight"
            Me.radioButtonAdv11.ThemesEnabled = False
            '
            'radioButtonAdv12
            '
            Me.radioButtonAdv12.DrawFocusRectangle = False
            Me.radioButtonAdv12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButtonAdv12.Location = New System.Drawing.Point(16, 21)
            Me.radioButtonAdv12.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.radioButtonAdv12.Name = "radioButtonAdv12"
            Me.radioButtonAdv12.Size = New System.Drawing.Size(121, 21)
            Me.radioButtonAdv12.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radioButtonAdv12.TabIndex = 2
            Me.radioButtonAdv12.Text = "ColWidths"
            Me.radioButtonAdv12.ThemesEnabled = False
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.radioButtonAdv2)
            Me.groupBox1.Controls.Add(Me.radioButtonAdv1)
            Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(624, 2)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(246, 71)
            Me.groupBox1.TabIndex = 11
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Options"
            '
            'radioButtonAdv2
            '
            Me.radioButtonAdv2.DrawFocusRectangle = False
            Me.radioButtonAdv2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButtonAdv2.Location = New System.Drawing.Point(16, 43)
            Me.radioButtonAdv2.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.radioButtonAdv2.Name = "radioButtonAdv2"
            Me.radioButtonAdv2.Size = New System.Drawing.Size(121, 21)
            Me.radioButtonAdv2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radioButtonAdv2.TabIndex = 1
            Me.radioButtonAdv2.Text = "Set Column Width"
            Me.radioButtonAdv2.ThemesEnabled = False
            '
            'radioButtonAdv1
            '
            Me.radioButtonAdv1.DrawFocusRectangle = False
            Me.radioButtonAdv1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButtonAdv1.Location = New System.Drawing.Point(16, 21)
            Me.radioButtonAdv1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.radioButtonAdv1.Name = "radioButtonAdv1"
            Me.radioButtonAdv1.Size = New System.Drawing.Size(121, 21)
            Me.radioButtonAdv1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radioButtonAdv1.TabIndex = 0
            Me.radioButtonAdv1.Text = "Set RowHeight"
            Me.radioButtonAdv1.ThemesEnabled = False
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.TextBox3)
            Me.GroupBox4.Controls.Add(Me.Label4)
            Me.GroupBox4.Controls.Add(Me.ButtonAdv5)
            Me.GroupBox4.Controls.Add(Me.Label3)
            Me.GroupBox4.Controls.Add(Me.RadioButtonAdv8)
            Me.GroupBox4.Controls.Add(Me.RadioButtonAdv7)
            Me.GroupBox4.Controls.Add(Me.RadioButtonAdv6)
            Me.GroupBox4.Controls.Add(Me.RadioButtonAdv5)
            Me.GroupBox4.Controls.Add(Me.TextBox2)
            Me.GroupBox4.Controls.Add(Me.TextBox1)
            Me.GroupBox4.Controls.Add(Me.Label2)
            Me.GroupBox4.Controls.Add(Me.Label1)
            Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox4.Location = New System.Drawing.Point(624, 232)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(246, 250)
            Me.GroupBox4.TabIndex = 14
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "AutoFit"
            '
            'TextBox3
            '
            Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TextBox3.Location = New System.Drawing.Point(121, 53)
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.Size = New System.Drawing.Size(32, 20)
            Me.TextBox3.TabIndex = 26
            Me.TextBox3.Text = "#"
            Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(13, 55)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(102, 13)
            Me.Label4.TabIndex = 25
            Me.Label4.Text = "Enter the Character:"
            '
            'ButtonAdv5
            '
            Me.ButtonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.ButtonAdv5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ButtonAdv5.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.ButtonAdv5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonAdv5.ForeColor = System.Drawing.Color.White
            Me.ButtonAdv5.Location = New System.Drawing.Point(55, 217)
            Me.ButtonAdv5.Name = "ButtonAdv5"
            Me.ButtonAdv5.Size = New System.Drawing.Size(118, 27)
            Me.ButtonAdv5.TabIndex = 24
            Me.ButtonAdv5.Text = "Update"
            Me.ButtonAdv5.UseVisualStyle = True
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(9, 85)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(124, 13)
            Me.Label3.TabIndex = 8
            Me.Label3.Text = "Choose Your Option:"
            '
            'RadioButtonAdv8
            '
            Me.RadioButtonAdv8.DrawFocusRectangle = False
            Me.RadioButtonAdv8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.RadioButtonAdv8.Location = New System.Drawing.Point(52, 101)
            Me.RadioButtonAdv8.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.RadioButtonAdv8.Name = "RadioButtonAdv8"
            Me.RadioButtonAdv8.Size = New System.Drawing.Size(121, 21)
            Me.RadioButtonAdv8.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.RadioButtonAdv8.TabIndex = 7
            Me.RadioButtonAdv8.Text = "None"
            Me.RadioButtonAdv8.ThemesEnabled = False
            '
            'RadioButtonAdv7
            '
            Me.RadioButtonAdv7.DrawFocusRectangle = False
            Me.RadioButtonAdv7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.RadioButtonAdv7.Location = New System.Drawing.Point(52, 128)
            Me.RadioButtonAdv7.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.RadioButtonAdv7.Name = "RadioButtonAdv7"
            Me.RadioButtonAdv7.Size = New System.Drawing.Size(121, 21)
            Me.RadioButtonAdv7.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.RadioButtonAdv7.TabIndex = 6
            Me.RadioButtonAdv7.Text = "Alphabet"
            Me.RadioButtonAdv7.ThemesEnabled = False
            '
            'RadioButtonAdv6
            '
            Me.RadioButtonAdv6.DrawFocusRectangle = False
            Me.RadioButtonAdv6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.RadioButtonAdv6.Location = New System.Drawing.Point(52, 155)
            Me.RadioButtonAdv6.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.RadioButtonAdv6.Name = "RadioButtonAdv6"
            Me.RadioButtonAdv6.Size = New System.Drawing.Size(121, 21)
            Me.RadioButtonAdv6.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.RadioButtonAdv6.TabIndex = 5
            Me.RadioButtonAdv6.Text = "Numeric"
            Me.RadioButtonAdv6.ThemesEnabled = False
            '
            'RadioButtonAdv5
            '
            Me.RadioButtonAdv5.DrawFocusRectangle = False
            Me.RadioButtonAdv5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.RadioButtonAdv5.Location = New System.Drawing.Point(52, 182)
            Me.RadioButtonAdv5.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.RadioButtonAdv5.Name = "RadioButtonAdv5"
            Me.RadioButtonAdv5.Size = New System.Drawing.Size(121, 21)
            Me.RadioButtonAdv5.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.RadioButtonAdv5.TabIndex = 4
            Me.RadioButtonAdv5.Text = "Both"
            Me.RadioButtonAdv5.ThemesEnabled = False
            '
            'TextBox2
            '
            Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TextBox2.Location = New System.Drawing.Point(159, 19)
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Size = New System.Drawing.Size(33, 20)
            Me.TextBox2.TabIndex = 3
            Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'TextBox1
            '
            Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TextBox1.Location = New System.Drawing.Point(70, 19)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(29, 20)
            Me.TextBox1.TabIndex = 2
            Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(105, 26)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(51, 13)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "ColIndex:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(13, 26)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(58, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "RowIndex:"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(870, 481)
            Me.Controls.Add(Me.GroupBox4)
            Me.Controls.Add(Me.groupBox3)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.gridControl1)
            Me.DropShadow = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Resize To Fit Demo"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox3.ResumeLayout(False)
            CType(Me.radioButtonAdv3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox2.ResumeLayout(False)
            CType(Me.radioButtonAdv11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv12, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            CType(Me.radioButtonAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            CType(Me.RadioButtonAdv8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadioButtonAdv7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadioButtonAdv6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadioButtonAdv5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub

#Region "EventHandler"
        Private Sub radioButtonAdv1_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv1.CheckChanged
            ' Set the Rowheight of the 1 st row
            Me.gridControl1.RowHeights(1) = 20

            ' Set the Rowheight of the 2 st row
            Me.gridControl1.RowHeights(2) = 50

            ' Set the Rowheight of the 3 st row
            Me.gridControl1.RowHeights(3) = 70
        End Sub

        Private Sub radioButtonAdv2_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv2.CheckChanged
            'Set the ColWidth of the 1 st column
            Me.gridControl1.ColWidths(1) = 20

            'Set the ColWidth of the 1 st column
            Me.gridControl1.ColWidths(2) = 50

            'Set the ColWidth of the 1 st column
            Me.gridControl1.ColWidths(3) = 70
        End Sub

        Private Sub radioButtonAdv12_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv12.CheckChanged
            ' ResizeToFit - Resizes a range of rows or column to optimally fit 
            ' contents of the specified range of cells.
            Me.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cols(1, 5))
        End Sub

        Private Sub radioButtonAdv11_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv11.CheckChanged
            Me.gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Rows(1, 5))
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.gridControl1.PopulateValues(GridRangeInfo.Cells(1, 1, 30, 12), GetTable())
        End Sub

        Private Sub radioButtonAdv4_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv4.CheckChanged
            Me.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cols(1, 5))
        End Sub

        Private Sub radioButtonAdv3_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv3.CheckChanged
            Me.gridControl1.RowHeights.ResizeToFitOptimized(GridRangeInfo.Rows(1, 5))
        End Sub

#End Region

        Private Sub RadioButtonAdv7_CheckChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonAdv7.CheckChanged
            If (TextBox3.Text <> "") AndAlso (TextBox1.Text <> "" AndAlso TextBox2.Text <> "") Then
                Me.gridControl1(Integer.Parse(TextBox1.Text), Integer.Parse(TextBox2.Text)).AutoFitChar = Char.Parse(TextBox3.Text)
            End If

            If TextBox1.Text <> "" AndAlso TextBox2.Text <> "" Then
                Me.gridControl1(Integer.Parse(TextBox1.Text), Integer.Parse(TextBox2.Text)).AutoFit = AutoFitOptions.Alphabet
            Else
                MessageBox.Show("Please Enter the Correct Index Values")
            End If
        End Sub

        Private Sub RadioButtonAdv8_CheckChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonAdv8.CheckChanged
            If TextBox1.Text <> "" AndAlso TextBox2.Text <> "" Then
                Me.gridControl1(Integer.Parse(TextBox1.Text), Integer.Parse(TextBox2.Text)).AutoFit = AutoFitOptions.None
            End If
        End Sub

        Private Sub RadioButtonAdv6_CheckChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonAdv6.CheckChanged
            If (TextBox3.Text <> "") AndAlso (TextBox1.Text <> "" AndAlso TextBox2.Text <> "") Then
                Me.gridControl1(Integer.Parse(TextBox1.Text), Integer.Parse(TextBox2.Text)).AutoFitChar = Char.Parse(TextBox3.Text)
            End If

            If TextBox1.Text <> "" AndAlso TextBox2.Text <> "" Then
                Me.gridControl1(Integer.Parse(TextBox1.Text), Integer.Parse(TextBox2.Text)).AutoFit = AutoFitOptions.Numeric
            Else
                MessageBox.Show("Please Enter the Correct Index Values")
            End If
        End Sub

        Private Sub RadioButtonAdv5_CheckChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonAdv5.CheckChanged
            If (TextBox3.Text <> "") AndAlso (TextBox1.Text <> "" AndAlso TextBox2.Text <> "") Then
                Me.gridControl1(Integer.Parse(TextBox1.Text), Integer.Parse(TextBox2.Text)).AutoFitChar = Char.Parse(TextBox3.Text)
            End If

            If TextBox1.Text <> "" AndAlso TextBox2.Text <> "" Then
                Me.gridControl1(Integer.Parse(TextBox1.Text), Integer.Parse(TextBox2.Text)).AutoFit = AutoFitOptions.Both
            Else
                MessageBox.Show("Please Enter the Correct Index Values")
            End If
        End Sub

        Private Sub ButtonAdv5_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAdv5.Click
            If RadioButtonAdv8.Checked Then
                Me.gridControl1(Integer.Parse(TextBox1.Text), Integer.Parse(TextBox1.Text)).AutoFit = AutoFitOptions.None
            ElseIf RadioButtonAdv7.Checked Then
                If (TextBox3.Text <> "") AndAlso (TextBox1.Text <> "" AndAlso TextBox2.Text <> "") Then
                    Me.gridControl1(Integer.Parse(TextBox1.Text), Integer.Parse(TextBox2.Text)).AutoFitChar = Char.Parse(TextBox3.Text)
                End If

                If TextBox1.Text <> "" AndAlso TextBox2.Text <> "" Then
                    Me.gridControl1(Integer.Parse(TextBox1.Text), Integer.Parse(TextBox2.Text)).AutoFit = AutoFitOptions.Alphabet
                Else
                    MessageBox.Show("Please Enter the Correct Index Values")
                End If
            ElseIf RadioButtonAdv6.Checked Then
                If (TextBox3.Text <> "") AndAlso (TextBox1.Text <> "" AndAlso TextBox2.Text <> "") Then
                    Me.gridControl1(Integer.Parse(TextBox1.Text), Integer.Parse(TextBox2.Text)).AutoFitChar = Char.Parse(TextBox3.Text)
                End If

                If TextBox1.Text <> "" AndAlso TextBox2.Text <> "" Then
                    Me.gridControl1(Integer.Parse(TextBox1.Text), Integer.Parse(TextBox2.Text)).AutoFit = AutoFitOptions.Numeric
                Else
                    MessageBox.Show("Please Enter the Correct Index Values")
                End If
                ElseIf RadioButtonAdv5.Checked Then
                If (TextBox3.Text <> "") AndAlso (TextBox1.Text <> "" AndAlso TextBox2.Text <> "") Then
                    Me.gridControl1(Integer.Parse(TextBox1.Text), Integer.Parse(TextBox2.Text)).AutoFitChar = Char.Parse(TextBox3.Text)
                End If
                If TextBox1.Text <> "" AndAlso TextBox2.Text <> "" Then
                    Me.gridControl1(Integer.Parse(TextBox1.Text), Integer.Parse(TextBox2.Text)).AutoFit = AutoFitOptions.Alphabet
                Else
                    MessageBox.Show("Please Enter the Correct Index Values")
                End If
                End If
        End Sub
    End Class
End Namespace
