Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid


Namespace MultiColumnSortInGridDataBoundGrid
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private gridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
		Private WithEvents button1 As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
            InitializeComponent()
            Try
                Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid1.ico"))
                Me.Icon = ico
            Catch
            End Try
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
			Me.gridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid()
			Me.button1 = New System.Windows.Forms.Button()
			Me.label1 = New System.Windows.Forms.Label()
			CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridDataBoundGrid1
			' 
			Me.gridDataBoundGrid1.AllowDragSelectedCols = True
			Me.gridDataBoundGrid1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridDataBoundGrid1.GridLineColor = System.Drawing.SystemColors.GrayText
			Me.gridDataBoundGrid1.Location = New System.Drawing.Point(0, 64)
			Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
			Me.gridDataBoundGrid1.OptimizeInsertRemoveCells = True
			Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
			Me.gridDataBoundGrid1.Size = New System.Drawing.Size(573, 380)
			Me.gridDataBoundGrid1.SmartSizeBox = False
			Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
			Me.gridDataBoundGrid1.TabIndex = 0
			Me.gridDataBoundGrid1.Text = "gridDataBoundGrid1"
			Me.gridDataBoundGrid1.UseListChangedEvent = True
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(336, 16)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(144, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Sort using API"
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(8, 8)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(304, 40)
			Me.label1.TabIndex = 2
			Me.label1.Text = "To do UI sorting, click a column header. To retain the current sorts and add a ne" & "w one, ctl+click a column header."
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(573, 442)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.gridDataBoundGrid1)
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Multi Column Sort"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub


		Private sortHelper As GridMultiColSortHelper.GridMultiColSortHelper = Nothing
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			
			Dim dt As New DataTable("MyTable")

			Dim nCols As Integer = 12
			Dim nRows As Integer = 20

			Dim r As New Random()
			For i As Integer = 0 To nCols - 1
				dt.Columns.Add(New DataColumn(String.Format("Col{0}", i)))
			Next i

			For i As Integer = 0 To nRows - 1
				Dim dr As DataRow = dt.NewRow()
				For j As Integer = 0 To nCols - 1
					dr(j) = String.Format("val{0}", r.Next(1000) Mod (2*j + 1))
				Next j
				dt.Rows.Add(dr)
			Next i

			Me.gridDataBoundGrid1.DataSource = dt

			gridDataBoundGrid1.SortColumn(gridDataBoundGrid1.Binder.NameToColIndex("Col1"))
			gridDataBoundGrid1.Model.Cols.Hidden(gridDataBoundGrid1.Binder.NameToColIndex("Col1")) = True

			'set some properties...
			Me.gridDataBoundGrid1.SortBehavior = GridSortBehavior.SingleClick
			Me.gridDataBoundGrid1.AllowDragSelectedCols = False
			Me.gridDataBoundGrid1.AllowSelection = Me.gridDataBoundGrid1.AllowSelection And Not GridSelectionFlags.Column

			'create and wire the sorthelper object
			sortHelper = New GridMultiColSortHelper.GridMultiColSortHelper()
			sortHelper.WireGrid(Me.gridDataBoundGrid1, True) 'true indicate the helper will resize to fit column headers
			Me.sortHelper.DefaultSortColumn = "Col1"

			Me.BackColor = Color.LightBlue
			Me.gridDataBoundGrid1.ThemesEnabled = True
			Me.gridDataBoundGrid1.Model.EnableLegacyStyle = False
			Me.gridDataBoundGrid1.ColorStyles = Syncfusion.Windows.Forms.ColorStyles.Office2010Blue
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			Me.sortHelper.SortColumn("Col7", ListSortDirection.Ascending, True, False) 'clear - dont show
			Me.sortHelper.SortColumn("Col6", ListSortDirection.Descending, False, False) 'dont clear - dont show
			Me.sortHelper.SortColumn("Col5", ListSortDirection.Ascending, False, False) 'dont clear - dont show
			Me.sortHelper.SortColumn("Col4", ListSortDirection.Descending, False, True) 'dont clear - show
		End Sub

	End Class
End Namespace
