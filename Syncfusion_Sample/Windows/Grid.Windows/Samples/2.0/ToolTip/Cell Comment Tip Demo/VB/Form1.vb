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
Imports Syncfusion.Windows.Forms


Public Class Form1
    Inherits MetroForm
    Private commentMouseController1 As ExcelTipDLL.CommentMouseController
    Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
    Private label1 As System.Windows.Forms.Label
    Private panel1 As System.Windows.Forms.Panel
    Private components As System.ComponentModel.Container = Nothing

    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridControl1.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
        Me.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid
    End Sub 'New

    '
    ' TODO: Add any constructor code after InitializeComponent call
    '

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
        Dim GridCellInfo1 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
        Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
        Me.label1 = New System.Windows.Forms.Label
        Me.panel1 = New System.Windows.Forms.Panel
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridControl1
        '
        Me.gridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridControl1.DefaultColWidth = 100
        Me.gridControl1.DefaultRowHeight = 20
        Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        GridCellInfo1.Col = -1
        GridCellInfo1.Row = -1
        GridCellInfo1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        GridCellInfo1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        GridCellInfo1.StyleInfo.Font.Facename = "Segoe UI"
        GridCellInfo1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
        GridCellInfo1.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gridControl1.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() {GridCellInfo1})
        Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridControl1.Location = New System.Drawing.Point(49, 80)
        Me.gridControl1.MetroScrollBars = True
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.RowCount = 30
        Me.gridControl1.Size = New System.Drawing.Size(601, 234)
        Me.gridControl1.SmartSizeBox = False
        Me.gridControl1.TabIndex = 0
        Me.gridControl1.Text = "gridControl1"
        Me.gridControl1.ThemesEnabled = True
        '
        'label1
        '
        Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(49, 55)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(591, 16)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Right-Click Cell or Left-Click existing comment corner to Add, Remove or Edit com" & _
            "ment "
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel1
        '
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(688, 350)
        Me.panel1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.White
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(688, 350)
        Me.Controls.Add(Me.label1)
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
        Me.Text = "Cell Comment Tip Demo"
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region

    <STAThread()> _
    Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
Application.EnableVisualStyles
#End If
        Application.Run(New Form1())
    End Sub 'Main


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'create the Comment mousecontroller.
        Me.commentMouseController1 = New ExcelTipDLL.CommentMouseController(gridControl1)
        'allow context menu to edit/add comments
        Me.commentMouseController1.ContextMenuEnabled = True
        'register the controller
        gridControl1.MouseControllerDispatcher.Add(commentMouseController1)


        'set the comment using custom style property, ExcelTipText
        Dim style As New ExcelTipDLL.GridExcelTipStyleProperties(gridControl1(2, 2))
        style.ExcelTipText = "Comment for cell 2,2."

        style = New ExcelTipDLL.GridExcelTipStyleProperties(gridControl1(4, 3))
        style.ExcelTipText = "Comment for cell 4,3."

        style = New ExcelTipDLL.GridExcelTipStyleProperties(gridControl1(4, 4))
        style.ExcelTipText = "Comment for cell 4,4" + Environment.NewLine + "holds multiple lines." + Environment.NewLine + "Here is the third one." + Environment.NewLine + "Here is the fourth one." + Environment.NewLine + "Here is the fifth one." + Environment.NewLine + "Here is the six one." + Environment.NewLine + "Here is the seventh one."

        Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
        Me.Icon = ico
        Me.gridControl1.DefaultRowHeight = 18
        Me.gridControl1.DefaultColWidth = 70
        Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.Silver
        Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
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
End Class 'Form1

