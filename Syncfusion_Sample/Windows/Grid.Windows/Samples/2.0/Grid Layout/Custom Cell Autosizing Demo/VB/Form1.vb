Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Text
Imports System.IO
Imports System.Reflection

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Diagnostics
Imports Syncfusion.Windows.Forms.Tools

Namespace CustomCellAutoSizing
	Public Class Form1
		Inherits MetroForm
		#Region "Private Members"
		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private WithEvents checkBox1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Public usePreferredClientSize As Boolean = True
		Private panel1 As System.Windows.Forms.Panel
		Private components As System.ComponentModel.IContainer=Nothing
		#End Region

		Public Sub New()
			InitializeComponent()
			Try
                Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
                Me.Icon = ico
			Catch
			End Try

'			#Region "GridSettings"
			Me.gridControl1.GridVisualStyles = GridVisualStyles.Office2007Blue
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.gridControl1.GridVisualStyles = GridVisualStyles.Metro
'			#End Region
		End Sub

		#Region "Form Handlers"
		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
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
			Dim gridBaseStyle1 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle2 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle3 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle4 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridRangeStyle1 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle2 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.checkBox1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.panel1 = New System.Windows.Forms.Panel()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			gridBaseStyle1.Name = "Row Header"
			gridBaseStyle1.StyleInfo.BaseStyle = "Header"
			gridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
			gridBaseStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb((CInt(Fix((CByte(203))))), (CInt(Fix((CByte(199))))), (CInt(Fix((CByte(184)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(216)))))))
			gridBaseStyle2.Name = "Column Header"
			gridBaseStyle2.StyleInfo.BaseStyle = "Header"
			gridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridBaseStyle3.Name = "Standard"
			gridBaseStyle3.StyleInfo.Font.Facename = "Tahoma"
			gridBaseStyle4.Name = "Header"
			gridBaseStyle4.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle4.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle4.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle4.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle4.StyleInfo.CellType = "Header"
			gridBaseStyle4.StyleInfo.Font.Bold = True
			gridBaseStyle4.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(203))))), (CInt(Fix((CByte(199))))), (CInt(Fix((CByte(184)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(216)))))))
			gridBaseStyle4.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
			Me.gridControl1.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() { gridBaseStyle1, gridBaseStyle2, gridBaseStyle3, gridBaseStyle4})
			Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gridControl1.ColCount = 11
			Me.gridControl1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() { New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35), New Syncfusion.Windows.Forms.Grid.GridColWidth(1, 176), New Syncfusion.Windows.Forms.Grid.GridColWidth(2, 66)})
			Me.gridControl1.DefaultRowHeight = 20
			Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.gridControl1.ForeColor = System.Drawing.SystemColors.ControlText
			Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridControl1.Location = New System.Drawing.Point(-2, -2)
			Me.gridControl1.MetroScrollBars = True
			Me.gridControl1.Name = "gridControl1"
			gridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle1.StyleInfo.Font.Bold = False
			gridRangeStyle1.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle1.StyleInfo.Font.Italic = False
			gridRangeStyle1.StyleInfo.Font.Size = 8.25F
			gridRangeStyle1.StyleInfo.Font.Strikeout = False
			gridRangeStyle1.StyleInfo.Font.Underline = False
			gridRangeStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridRangeStyle1.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			gridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle2.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle2.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle2.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle2.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridRangeStyle2.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			Me.gridControl1.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() { gridRangeStyle1, gridRangeStyle2})
			Me.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.gridControl1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() { New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21), New Syncfusion.Windows.Forms.Grid.GridRowHeight(1, 17), New Syncfusion.Windows.Forms.Grid.GridRowHeight(2, 18), New Syncfusion.Windows.Forms.Grid.GridRowHeight(3, 17), New Syncfusion.Windows.Forms.Grid.GridRowHeight(4, 18)})
			Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
			Me.gridControl1.Size = New System.Drawing.Size(590, 416)
			Me.gridControl1.SmartSizeBox = False
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ThemesEnabled = True
			' 
			' checkBox1
			' 
			Me.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
			Me.checkBox1.BackColor = System.Drawing.Color.White
			Me.checkBox1.Checked = True
			Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox1.DrawFocusRectangle = False
			Me.checkBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox1.Location = New System.Drawing.Point(545, 438)
			Me.checkBox1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(90, 24)
			Me.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBox1.TabIndex = 1
			Me.checkBox1.Text = "Resize To Fit"
			Me.checkBox1.ThemesEnabled = False
'			Me.checkBox1.CheckedChanged += New Syncfusion.Windows.Forms.Tools.CheckedChangedEventHandler(Me.checkBox1_CheckedChanged)
			' 
			' panel1
			' 
			Me.panel1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel1.BackColor = System.Drawing.SystemColors.Control
			Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel1.Controls.Add(Me.gridControl1)
			Me.panel1.Location = New System.Drawing.Point(12, 12)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(588, 420)
			Me.panel1.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.White
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(612, 470)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.checkBox1)
			Me.DropShadow = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Custom Cell Auotsizing Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

        <STAThread()> _
  Shared Sub Main()
            Application.Run(New Form1())
        End Sub

		#End Region


		#Region "Event Handlers"

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitializeForm()
		End Sub
		Private colsize, rowsize As Integer
		Private Sub InitializeForm()
			gridControl1.BeginUpdate()
			gridControl1.ThemesEnabled = True
			gridControl1.TableStyle.FloatCell = True
			gridControl1.FloatCellsMode = GridFloatCellsMode.OnDemandCalculation
			gridControl1.AllowSelection = GridSelectionFlags.Any
			'Register Custom Cell Types
			Me.gridControl1.CellModels.Add("Slider", New CustomControlCellModel(Me.gridControl1.Model))
			Me.gridControl1.CellModels.Add("DataEntry", New CustomControlCellModel(gridControl1.Model))
			Me.gridControl1.CellModels.Add("ChoiceList", New CustomControlCellModel(gridControl1.Model))

			Dim control As Control
			Dim style As GridStyleInfo

			'Setup DataEntry Cell
			style = gridControl1(2, 2)
			style.CellType = "DataEntry"
			control = New DataEntryControl()
			MakeUnBuffered(control)
			'Pass the type of CellControl to cell model class through its Tag
			style.Tag = control

			'Setup ChoiceList Cell
			style = gridControl1(3, 3)
			style.CellType = "ChoiceList"
			control = New ChoiceListControl()
			MakeUnBuffered(control)
			'Pass the type of CellControl to cell model class through its Tag
			style.Tag = control

			'Setup Slider Cell
			style = gridControl1(4, 4)
			style.CellType = "Slider"
			'Pass the type of CellControl to cell model class through its Tag
			style.Tag = New TrackBar()

			colsize = gridControl1.ColWidths(2)
			rowsize = gridControl1.RowHeights(2)

			'Call ResizeToFit which in turn calls OnQueryPreferredClientSize method in the cell model class
			'in order to retrieve the Correct size of the controls in grid cells and adjust respective 
			'RowHeights & ColWidths in order to make the cells to fit controls.
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Table())
			gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Table())

			gridControl1.EndUpdate(True)
			'gridControl1.ResizingColumns += new GridResizingColumnsEventHandler(gridControl1_ResizingColumns);
			'gridControl1.ResizingRows += new GridResizingRowsEventHandler(gridControl1_ResizingRows);
			AddHandler Application.Idle, AddressOf Application_Idle
			For i As Integer = 1 To 4
				widths.Add(i, gridControl1.ColWidths(i))
			Next i
		End Sub
		Private widths As New Hashtable()
		Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
			For i As Integer = 1 To 4
				If gridControl1.ColWidths(i) < Integer.Parse(widths(i).ToString()) Then
					gridControl1.ColWidths(i) = Integer.Parse(widths(i).ToString())
				End If
			Next i
		End Sub

		Private Sub gridControl1_ResizingColumns(ByVal sender As Object, ByVal e As GridResizingColumnsEventArgs)
			Dim c As Control = Nothing
			If gridControl1(e.Columns.Left, e.Columns.Left).Tag IsNot Nothing Then
				c = TryCast(gridControl1(e.Columns.Left, e.Columns.Left).Tag, Control)
			ElseIf gridControl1(e.Columns.Right, e.Columns.Right).Tag IsNot Nothing Then
				c = TryCast(gridControl1(e.Columns.Right, e.Columns.Right).Tag, Control)
			End If

			If c IsNot Nothing AndAlso gridControl1.ColWidths(e.Columns.Left) < c.Size.Width + 2 Then
				e.Cancel = True
			End If
		End Sub

		Private Sub gridControl1_ResizingRows(ByVal sender As Object, ByVal e As GridResizingRowsEventArgs)

		End Sub
		Private Sub MakeUnBuffered(ByVal control As Control)

			Dim mInfo As System.Reflection.MethodInfo = GetType(Control).GetMethod("SetStyle", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.InvokeMethod Or System.Reflection.BindingFlags.NonPublic)
			If mInfo IsNot Nothing Then
				mInfo.Invoke(control, New Object() { Syncfusion.Windows.Forms.WhidbeyCompatibleControlStyles.DoubleBuffer, False })
			End If
			For Each cc As Control In control.Controls
				cc.CausesValidation = False
				MakeUnBuffered(cc)
			Next cc
		End Sub
		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As CheckedChangedEventArgs) Handles checkBox1.CheckedChanged
			If Me.checkBox1.Checked Then
				gridControl1.BeginUpdate()
				gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Table())
				gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Table())
				gridControl1.EndUpdate(True)
			Else
				For i As Integer = 2 To 6
					gridControl1.RowHeights(i) = rowsize
					gridControl1.ColWidths(i) = colsize
				Next i
			End If
			Me.gridControl1.Refresh()
		End Sub
		#End Region

	End Class
End Namespace
