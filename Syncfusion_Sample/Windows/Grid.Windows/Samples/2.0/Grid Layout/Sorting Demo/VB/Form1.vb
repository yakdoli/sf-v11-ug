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
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms

Namespace GridControlSort


	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Syncfusion.Windows.Forms.MetroForm
		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
            Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridControl1.GridOfficeScrollBars = OfficeScrollBars.Metro
			Me.gridControl1.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
			Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
			'this.BackColor = Color.FromArgb(223, 227, 239);
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
			gridControl1.ControllerOptions = gridControl1.ControllerOptions And Not(GridControllerOptions.OleDataSource Or GridControllerOptions.OleDropTarget)
			gridControl1.BaseStylesMap("Header").StyleInfo.Enabled = False

		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
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
			Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.AllowDrop = True
			Me.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.Left
			Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gridControl1.HorizontalThumbTrack = True
			Me.gridControl1.Location = New System.Drawing.Point(12, 12)
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RowCount = 100
			Me.gridControl1.Size = New System.Drawing.Size(664, 286)
			Me.gridControl1.SmartSizeBox = False
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.Text = "gridControl1"
			Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.VerticalThumbTrack = True
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(690, 313)
			Me.Controls.Add(Me.gridControl1)
			Me.DropShadow = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
            Me.Text = "Sorting Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Public Shared Sub Main()
#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
			Application.EnableVisualStyles()
#End If
			Application.Run(New Form1())
		End Sub
#Region "EventHandler"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            PopulateTheGrid()

            'turn off column selections - not absolutely needed but does simplify things
            Me.gridControl1.AllowSelection = GridSelectionFlags.Any And Not GridSelectionFlags.Column

            'add a sort header to the CellModels... (in 1.0, only available by default in GridDataBoundGrid)
            Me.gridControl1.CellModels.Add("ColumnHeaderCell", New GridSortColumnHeaderCellModel(Me.gridControl1.Model))

            'catch the click
            AddHandler gridControl1.CellClick, AddressOf HandleAClick
        End Sub

        Private Sub HandleAClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
            If e.MouseEventArgs.Button = MouseButtons.Left AndAlso e.RowIndex = 0 AndAlso e.ColIndex > 0 Then
                SortCol(e.ColIndex)
            End If

        End Sub
#End Region
#Region "Method"
        Private Sub PopulateTheGrid()
            Dim r As New Random()
            Me.gridControl1.CommandStack.Enabled = False
            Me.gridControl1.BeginUpdate()
            For row As Integer = 1 To Me.gridControl1.RowCount
                For col As Integer = 1 To Me.gridControl1.ColCount
                    If col = 2 Then 'datetime col
                        Dim dt As New DateTime(r.Next(50) + 1960, r.Next(11) + 1, r.Next(27) + 1)
                        Me.gridControl1(row, col).CellValue = dt
                    ElseIf col = 4 OrElse col = 5 Then 'formula col and text col
                        If col = 5 Then
                            Me.gridControl1(row, col).CellValue = RandomString(r)
                        End If
                    ElseIf col = 6 Then 'float
                        If (r.Next(2) = 0) Then
                            Me.gridControl1(row, col).CellValue = (1) * (CSng(r.Next(100000))) / 200
                        Else
                            Me.gridControl1(row, col).CellValue = (-1) * (CSng(r.Next(100000))) / 200
                        End If
                    ElseIf col = 3 Then 'int count col
                        Me.gridControl1(row, col).CellValue = row
                    Else 'int
                        If (r.Next(2) = 0) Then
                            Me.gridControl1(row, col).CellValue = (1) * r.Next(1000)
                        Else
                            Me.gridControl1(row, col).CellValue = (-1) * r.Next(1000)
                        End If
                    End If
                Next col
            Next row

            Me.gridControl1.DefaultColWidth = 50
            'this.gridControl1.TableStyle.HorizontalAlignment = GridHorizontalAlignment.Center;

            'column 2 is a date column
            Me.gridControl1.ColStyles(2).CellValueType = GetType(DateTime)
            Me.gridControl1.ColStyles(2).Format = "dd MMM yyyy"
            Me.gridControl1.ColWidths(2) = 100
            Me.gridControl1(0, 2).Text = "Date"

            'column 4 is formula col which used relative notation (row = 0)
            'to enter the formulas as a simgle string as the default value
            'in the column
            Me.gridControl1.ColWidths(4) = 100
            Me.gridControl1(0, 4).Text = "FormulaCell"
            Me.gridControl1.ColStyles(4).CellType = "FormulaCell"
            Me.gridControl1.ColStyles(4).Text = "= A0 + C0" 'row = 0 means use current row

            'col 6 is a text column
            Me.gridControl1.ColWidths(5) = 100
            Me.gridControl1(0, 5).Text = "Text"

            'column 6 is a float column
            Me.gridControl1.ColStyles(6).CellValueType = GetType(Single)
            Me.gridControl1.ColStyles(6).Format = "####.##"
            Me.gridControl1.ColWidths(6) = 100
            Me.gridControl1(0, 6).Text = "floats"

            'force the entire column to be computed, not just the visible cells
            'so if sort is done on formula column, all cells will have been computed.
            Dim engine As GridFormulaEngine = (CType(Me.gridControl1.CellModels("FormulaCell"), GridFormulaCellModel)).Engine
            engine.RecalculateRange(GridRangeInfo.Col(4), True, True)

            Me.gridControl1.ColStyles(1).BackColor = Color.White
            Me.gridControl1.ColStyles(2).BackColor = Color.FromArgb(237, 240, 246)
            Me.gridControl1.ColStyles(3).BackColor = Color.FromArgb(218, 229, 245)
            Me.gridControl1.ColStyles(4).BackColor = Color.FromArgb(218, 229, 245)
            Me.gridControl1.ColStyles(5).BackColor = Color.FromArgb(102, 110, 152)
            Me.gridControl1.ColStyles(5).TextColor = Color.White
            Me.gridControl1.ColStyles(6).BackColor = Color.FromArgb(252, 172, 38)
            Me.gridControl1.ColStyles(7).BackColor = Color.FromArgb(255, 153, 51)
            Me.gridControl1.ColStyles(8).BackColor = Color.FromArgb(238, 122, 3)
            Me.gridControl1.ColStyles(9).BackColor = Color.FromArgb(238, 122, 3)
            Me.gridControl1.ColStyles(10).BackColor = Color.FromArgb(&HDE, &H64, &H13)
            Me.gridControl1.ColStyles(10).TextColor = Color.White
            Try
                Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
                Me.Icon = ico
            Catch
            End Try
            Me.gridControl1.DefaultRowHeight = 18
            Me.gridControl1.DefaultColWidth = 70
            Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.Silver
            Me.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid

            Me.gridControl1.EndUpdate()
            Me.gridControl1.Refresh()
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
        Public Sub SortCol(ByVal col As Integer)
            If Me.gridControl1.CurrentCell.IsEditing Then
                Me.gridControl1.CurrentCell.EndEdit()
            End If

            Dim style As New GridStyleInfo()
            style.Tag = ""

            'turn off the old sort arrow
            For col1 As Integer = 1 To Me.gridControl1.ColCount
                If col1 <> col AndAlso Me.gridControl1(0, col1).CellType Is "ColumnHeaderCell" Then
                    Me.gridControl1(0, col1).CellType = "Header"
                    Exit For
                End If
            Next col1

            'turn on new sort arrow
            Me.gridControl1(0, col).CellType = "ColumnHeaderCell"

            Dim dir As ListSortDirection = ListSortDirection.Ascending
            If Me.gridControl1(0, col).HasTag Then
                If CType(Me.gridControl1(0, col).Tag, ListSortDirection) = ListSortDirection.Ascending Then
                    dir = ListSortDirection.Descending
                End If
            End If

            Me.gridControl1(0, col).Tag = dir
            If col = 4 Then 'formulacell
                'need to use custom comparer to get at the 
                'formula computed value instead of the formul itself.
                Me.gridControl1.Data.SortByColumn(col, dir, New FormulaComparer())
            Else
                Me.gridControl1.Data.SortByColumn(col, dir)
            End If
            Dim engine As GridFormulaEngine = (CType(Me.gridControl1.CellModels("FormulaCell"), GridFormulaCellModel)).Engine
            engine.RecalculateRange(GridRangeInfo.Col(4), True, True)
            Me.gridControl1.Refresh()
        End Sub

        Private Function RandomString(ByVal r As Random) As String
            Dim len As Integer = r.Next(12) + 1
            Dim sb As New System.Text.StringBuilder(len)

            Dim i As Integer

            While i < len
                Dim a As Integer = (r.Next(26) + 65)
                sb.Append(Microsoft.VisualBasic.ChrW(a))
                i += 1
            End While
            Return sb.ToString()

        End Function 'RandomString 

#End Region
	End Class

	#Region "Custom Comparer Class for formula cells"

	'custom comparer to sort on formula value and not the formula.
	Public Class FormulaComparer
		Implements IComparer
		#Region "Implementation of IComparer"
		Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
			Dim c As Integer = 0

			If x Is Nothing AndAlso y Is Nothing Then
				'c = 0;
			ElseIf x Is Nothing Then
				c = -1
			ElseIf y Is Nothing Then
				c = 1
			Else
				'the idea is to get at the FormulaTag object in the GridStyleInfoStore passed in
				'and use the FormulaTag.Text property to compare two cells.
				Dim xStyle As New GridStyleInfo(CType(x, GridStyleInfoStore))
				Dim yStyle As New GridStyleInfo(CType(y, GridStyleInfoStore))
				Dim xs As String
				If (xStyle.FormulaTag IsNot Nothing) Then
					xs = xStyle.FormulaTag.Text
				Else
					xs = ""
				End If
				Dim ys As String
				If (yStyle.FormulaTag IsNot Nothing) Then
					ys = yStyle.FormulaTag.Text
				Else
					ys = ""
				End If
				Dim xd As Double = 0
				Dim yd As Double = 0
				Double.TryParse(xs, System.Globalization.NumberStyles.Any, Nothing, xd)
				Double.TryParse(ys, System.Globalization.NumberStyles.Any, Nothing, yd)
				c = xd.CompareTo(yd)
			End If
			Return c
		End Function
		#End Region
	End Class

	#End Region

End Namespace
