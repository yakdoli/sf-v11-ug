Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.XlsIO
Imports Syncfusion.GridExcelConverter
Imports Syncfusion.Windows.Forms
Namespace ExcelGrid_CopyPaste
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
    Public Class Form1 : Inherits MetroForm
        Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
        Private WithEvents btnClear As Syncfusion.Windows.Forms.ButtonAdv
        Private components As System.ComponentModel.IContainer
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
			
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
			
            Dim style1 As GridStyleInfo = New GridStyleInfo()
            style1.BackColor = Color.FromArgb(&H85, &HBF, &H75)
            style1.Font.Underline = True
            style1.Font.Bold = True

            Dim style2 As GridStyleInfo = New GridStyleInfo()
            style2.BackColor = Color.FromArgb(&HDE, &H64, &H13)
            style2.TextColor = SystemColors.Info

            Dim style3 As GridStyleInfo = New GridStyleInfo()
            style3.BackColor = Color.FromArgb(&HB4, &HE7, &HF2)
            style3.TextColor = Color.MidnightBlue
            style3.Borders.All = New GridBorder(GridBorderStyle.Solid, Color.DarkRed, GridBorderWeight.Medium)

            Dim style4 As GridStyleInfo = New GridStyleInfo()
            style4.BackColor = Color.FromArgb(&HFF, &HBF, &H34)
            style4.Font.Bold = True

            Dim style5 As GridStyleInfo = New GridStyleInfo()
            style5.BackColor = Color.FromArgb(&H82, &H2E, &H1B)
            style5.TextColor = Color.White

            Dim style6 As GridStyleInfo = New GridStyleInfo()
            style6.BackColor = Color.FromArgb(&H3A, &H86, &H7E)
            style6.TextColor = Color.White
            style6.Borders.All = New GridBorder(GridBorderStyle.Solid, Color.Red, GridBorderWeight.Medium)


            Dim styles As GridStyleInfo() = New GridStyleInfo() {style1, style2, style3, style4, style5, style6}
            Me.gridControl1.ColCount = 100
            Me.gridControl1.RowCount = 1000

            Dim rnd As Random = New Random()

            Dim c As Integer = 1
            'ORIGINAL LINE: for (int c = 1; c <= Me.gridControl1.ColCount; c += 1)
            'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
            Do While c <= Me.gridControl1.ColCount
                Dim r As Integer = 1
                'ORIGINAL LINE: for (int r = 1; r <= Me.gridControl1.RowCount; r += 1)
                'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
                Do While r <= Me.gridControl1.RowCount
                    Dim v As Integer = rnd.Next(100)
                    If v > 80 Then
                        Dim style As GridStyleInfo = New GridStyleInfo()
                        style.Font.Size = 10.0F
                        style = styles(v Mod styles.Length)
                        style.CellValue = v
                        Me.gridControl1(r, c).ModifyStyle(style, Syncfusion.Styles.StyleModifyType.Override)
                    End If
                    r += 1
                Loop
                c += 1
            Loop
            
			Me.gridControl1.GridVisualStyles = GridVisualStyles.Metro
            Me.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid
            Me.gridControl1.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
            Dim styl As GridStyleInfo = gridControl1.BaseStylesMap("Header").StyleInfo
            styl.TextColor = Color.MidnightBlue
            styl.Font.Facename = "Segoe UI"
            Me.StartPosition = FormStartPosition.CenterScreen
            AddHandler gridControl1.ClipboardCopy, AddressOf gridControl1_ClipboardCopy

            AddHandler gridControl1.ClipboardCanPaste, AddressOf gridControl1_ClipboardCanPaste
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


        Private Sub gridControl1_ClipboardCanPaste(ByVal sender As Object, ByVal e As GridCutPasteEventArgs)
            Dim dataObject As IDataObject = Clipboard.GetDataObject()
            If Not dataObject Is Nothing Then
                If dataObject.GetDataPresent("Biff", True) Then

                    Dim xlEngine As ExcelEngine = New ExcelEngine()
                    Dim app As IApplication = xlEngine.Excel
                    Dim workBook As IWorkbooks = app.Workbooks
                    workBook.PasteWorkbook()
                    Dim book As IWorkbook = workBook(0)
                    Dim worksheet As IWorksheet = book.Worksheets(0)

                    Dim ur As IRange = worksheet.UsedRange

                    Dim ranges As IRange() = ur.Cells 'worksheet.UsedCells;
                    Dim str As System.Text.StringBuilder = New System.Text.StringBuilder()



                    Dim lastCol As Integer = ranges(0).Column, lastRow As Integer = ranges(0).Row
                    Dim rc As Integer = ur.LastRow - ur.Row + 1
                    Dim cc As Integer = ur.LastColumn - ur.Column + 1

                    Dim converter As GridExcelConverterControl = New GridExcelConverterControl()
                    Dim model As GridModel = New GridModel()

                    model.ColCount = cc
                    model.RowCount = rc
                    ur.MoveTo(worksheet.Range(1, 1, rc, cc))
                    ranges = worksheet.Range(1, 1, rc, cc).Cells
                    Dim cell As IRange
                    For Each cell In ranges
                        converter.ConvertExcelRangeToGrid(cell, model)
                    Next cell

                    Dim data As GridData = New GridData()
                    data.InsertRows(1, rc)
                    data.InsertCols(1, cc)
                    Dim i As Integer
                    For i = 1 To model.Data.RowCount
                        Dim j As Integer = 1
                        'ORIGINAL LINE: for (int j = 1; j <= model.ColCount; j += 1)
                        'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
                        Do While j <= model.ColCount
                            data(i - 1, j - 1) = CType(IIf(TypeOf model.Data(i, j).Clone() Is GridStyleInfoStore, model.Data(i, j).Clone(), Nothing), GridStyleInfoStore)

                            j += 1
                        Loop
                    Next i

                    'Clipboard.Clear();
                    Dim newDataObject As DataObject = New DataObject(data)
                    Clipboard.SetDataObject(newDataObject, True)
                    xlEngine.ThrowNotSavedOnDestroy = False
                    xlEngine.Dispose()

                End If
            End If

        End Sub

        Private Sub gridControl1_ClipboardCopy(ByVal sender As Object, ByVal e As GridCutPasteEventArgs)
            e.Handled = True
            Me.CopyStylesAsBiffToClipBoard(e.RangeList)
        End Sub

        Private Sub CopyStylesAsBiffToClipBoard(ByVal rangelist As GridRangeInfoList)
            Dim gecc As GridExcelConverterControl = New GridExcelConverterControl()
            Dim engine As ExcelEngine = CreateEngine()
            Dim book As IWorkbook = engine.Excel.Workbooks.Create(1)
            Dim sheet As IWorksheet = book.Worksheets(0)
            Dim range As GridRangeInfo
            For Each range In rangelist
                range.ExpandRange(1, 1, Me.gridControl1.RowCount, Me.gridControl1.ColCount)

                Dim iRow As Integer = range.Top
                'ORIGINAL LINE: for (int iRow = range.Top; iRow <= range.Bottom; iRow += 1)
                'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
                Do While iRow <= range.Bottom
                    Dim iColumn As Integer = range.Left
                    'ORIGINAL LINE: for (int iColumn = range.Left; iColumn <= range.Right; iColumn += 1)
                    'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
                    Do While iColumn <= range.Right
                        Dim gridCell As GridStyleInfo = Me.gridControl1(iRow, iColumn)
                        If gridCell.IsEmpty Then
                            GoTo Continue1
                        End If
                        gecc.GridCellToExcel(Me.gridControl1.Model, iRow, iColumn, sheet.Range(iRow, iColumn))
Continue1:              iColumn += 1

                    Loop
                    iRow += 1
                Loop
            Next range

            book.CopyToClipboard()
            book.Close()
            engine.Dispose()
        End Sub

        Protected Function CreateEngine() As ExcelEngine
            Dim engine As ExcelEngine = New ExcelEngine()
            engine.ThrowNotSavedOnDestroy = False
            Return engine
        End Function
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
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
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.btnClear = New Syncfusion.Windows.Forms.ButtonAdv
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
            Me.gridControl1.ExcelLikeCurrentCell = True
            Me.gridControl1.ExcelLikeSelectionFrame = True
            Me.gridControl1.Location = New System.Drawing.Point(14, 0)
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.Silver
            Me.gridControl1.Properties.MarkColHeader = False
            Me.gridControl1.Properties.MarkRowHeader = False
            Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridControl1.Size = New System.Drawing.Size(595, 279)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.Text = "gridControl1"
            Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.BorderStyle=BorderStyle.FixedSingle
            '
            'btnClear
            '
            Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClear.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnClear.ForeColor = System.Drawing.Color.White
            Me.btnClear.Location = New System.Drawing.Point(625, 92)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(107, 27)
            Me.btnClear.TabIndex = 1
            Me.btnClear.Text = "Clear Grid"
            Me.btnClear.UseVisualStyle = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(744, 294)
            Me.Controls.Add(Me.btnClear)
            Me.Controls.Add(Me.gridControl1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Copy Paste Demo"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
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

        Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
            Me.gridControl1.ClearCells(GridRangeInfo.Table(), True)
            Me.gridControl1.ResetColWidthEntries()
            Me.gridControl1.ResetRowHeightEntries()
        End Sub
    End Class
End Namespace
