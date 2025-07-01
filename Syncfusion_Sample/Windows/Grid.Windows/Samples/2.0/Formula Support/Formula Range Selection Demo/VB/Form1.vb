Imports Microsoft.VisualBasic
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
Imports System.Reflection
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.GridHelperClasses


''' <summary>
''' Summary description for Form1.
''' </summary>
Public Class Form1
    Inherits Syncfusion.Windows.Forms.MetroForm
    Private gridAwareTextBox1 As GridAwareTextBox
    Private WithEvents gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.Container = Nothing

    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
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

#Region "Windows Form Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim GridCellInfo1 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
        Me.gridAwareTextBox1 = New Syncfusion.Windows.Forms.Grid.GridAwareTextBox
        Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridAwareTextBox1
        '
        Me.gridAwareTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.gridAwareTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridAwareTextBox1.DisabledBackColor = System.Drawing.SystemColors.Window
        Me.gridAwareTextBox1.EnabledBackColor = System.Drawing.SystemColors.Window
        Me.gridAwareTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridAwareTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.gridAwareTextBox1.Name = "gridAwareTextBox1"
        Me.gridAwareTextBox1.Size = New System.Drawing.Size(495, 20)
        Me.gridAwareTextBox1.TabIndex = 4
        '
        'gridControl1
        '
        Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridControl1.ColCount = 7
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
        Me.gridControl1.Location = New System.Drawing.Point(12, 40)
        Me.gridControl1.MetroScrollBars = True
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.RowCount = 11
        Me.gridControl1.Size = New System.Drawing.Size(494, 250)
        Me.gridControl1.SmartSizeBox = False
        Me.gridControl1.TabIndex = 6
        Me.gridControl1.Text = "gridControl1"
        Me.gridControl1.ThemesEnabled = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(519, 299)
        Me.Controls.Add(Me.gridControl1)
        Me.Controls.Add(Me.gridAwareTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
		Me.BorderThickness = 2
        Me.Text = "Formula Range Selection Demo"
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()> _
   Shared Sub Main()
#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
        Application.EnableVisualStyles()
#End If
        Application.Run(New Form1())
    End Sub

#Region "Event Handler"
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'wire the grid to the textbox
        Me.gridAwareTextBox1.WireGrid(Me.gridControl1)

        'Excel properties if wanted
        Me.gridControl1.ExcelLikeCurrentCell = True
        Me.gridControl1.ExcelLikeSelectionFrame = True
        Me.gridControl1.ShouldSynchronizeCurrentCell = True
        Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        'make enter key move down
        Me.gridControl1.EnterKeyBehavior = GridDirectionType.Down

        'make the whole table handle formulas
        'this.gridControl1.TableStyle.CellType = "FormulaCell";
        'or
        'set column 2 to hold formulas
        Dim style As GridStyleInfo = Me.gridControl1.ColStyles(2)
        style.CellType = "FormulaCell"
        Me.gridControl1.ColWidths(2) = 100

        'set column 3 to hold formulas
        style = Me.gridControl1.ColStyles(3)
        style.CellType = "FormulaCell"
        Me.gridControl1.ColWidths(3) = 100

        'add the mousecontroller that handles formularange selections
        Dim formulaController As New FormulaRangeSelectionController(gridControl1)
        gridControl1.MouseControllerDispatcher.Add(formulaController)

        'if you want the user to have to hold down control before a 
        'drag is started, then uncomment this line
        'formulaController.MouseRequiresControlKey = true;

        'if you want the user to have to hold down control in order
        'to start a drag with the arrow keys, then uncomment this line
        'formulaController.KeyBoardRequiresControlKey = true;

        'turn off ole D&D
        'this.gridControl1.ControllerOptions = GridControllerOptions.All & (~GridControllerOptions.OleDataSource);

        'set cell 1,1 current
        Me.gridControl1.ForceCurrentCellMoveTo = True 'required to get the move to take in FormLoad
        Me.gridControl1.CurrentCell.MoveTo(1, 1)

        'put some random values in column 1
        Dim r As New Random()
        For row As Integer = 1 To Me.gridControl1.RowCount
            Me.gridControl1(row, 1).CellValue = r.Next(1000)
        Next row
        Try
            Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try

        Me.gridControl1.CurrentCell.MoveTo(5, 2)
        Me.gridControl1(5, 2).Text = "=Sum(A1:A5)"
        Me.gridAwareTextBox1.Text = "=Sum(A1:A5)"
        Me.gridControl1.DefaultRowHeight = 18
        Me.gridControl1.DefaultColWidth = 70
        Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridControl1.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
        Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
        style = Me.gridControl1.BaseStylesMap("Header").StyleInfo
        style.TextColor = System.Drawing.Color.MidnightBlue
        style.Font.Facename = "Verdana"
        style = Me.gridControl1.BaseStylesMap("Standard").StyleInfo
        style.TextColor = System.Drawing.Color.MidnightBlue
        style.Font.Facename = "Verdana"
    End Sub
#End Region
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
#End Region
#Region "splitter event handlers - required"
    'When a new splitter pane is created, a new GridControl is created. So, this new control
    'needs to be wired as the original control was.
    Private Sub splitterControl1_PaneCreated(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.SplitterPaneEventArgs)
        Dim grid As GridControlBase = CType(e.Control, GridControlBase)
        Me.gridAwareTextBox1.WireGrid(grid)

        Dim formulaController As New FormulaRangeSelectionController(grid)
        grid.MouseControllerDispatcher.Add(formulaController)
    End Sub

    'When the pane goes away, the dynamically created GridControl goes away as well, so we
    'need to unwire things...
    Private Sub splitterControl1_PaneClosing(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.SplitterPaneEventArgs)
        Dim grid As GridControlBase = CType(e.Control, GridControlBase)
        Me.gridAwareTextBox1.UnwireGrid(grid)
    End Sub

#End Region

End Class

