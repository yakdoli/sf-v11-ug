Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping

Namespace OutlookDemo
	''' <summary>
	''' Summary description for ColumnSetViewHeader.
	''' </summary>
	Public Class ColumnSetViewHeader : Inherits System.Windows.Forms.UserControl
		Private WithEvents gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private panel1 As System.Windows.Forms.Panel
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()
			Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.BaseStylesMap("Column Header").StyleInfo.BackColor = SystemColors.Control
			Me.gridControl1.Enabled = False
			Me.gridControl1.HScrollBehavior = GridScrollbarMode.Disabled
			Me.gridControl1(0,2).Text = "Newest On Top"
			Me.gridControl1(0,2).HorizontalAlignment = GridHorizontalAlignment.Left
			Me.gridControl1(0,1).Text = "Arranged By: "
			Me.gridControl1(0,1).HorizontalAlignment = GridHorizontalAlignment.Left
			' TODO: Add any initialization after the InitializeComponent call
            AddHandler Me.gridControl1.QueryColWidth, AddressOf gridControl1_QueryColWidth
            AddHandler Me.gridControl1.CellClick, AddressOf gridControl1_CellClick
		End Sub

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"
		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim gridBaseStyle1 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle2 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle3 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle4 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.panel1 = New System.Windows.Forms.Panel()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			gridBaseStyle1.Name = "Header"
			gridBaseStyle1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle1.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle1.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle1.StyleInfo.CellType = "Header"
			gridBaseStyle1.StyleInfo.Font.Bold = True
			gridBaseStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CByte(203)), (CByte(199)), (CByte(184))), System.Drawing.Color.FromArgb((CByte(238)), (CByte(234)), (CByte(216))))
			gridBaseStyle1.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
			gridBaseStyle2.Name = "Column Header"
			gridBaseStyle2.StyleInfo.BaseStyle = "Header"
			gridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridBaseStyle3.Name = "Row Header"
			gridBaseStyle3.StyleInfo.BaseStyle = "Header"
			gridBaseStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
			gridBaseStyle3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb((CByte(203)), (CByte(199)), (CByte(184))), System.Drawing.Color.FromArgb((CByte(238)), (CByte(234)), (CByte(216))))
			gridBaseStyle4.Name = "Standard"
			gridBaseStyle4.StyleInfo.Font.Facename = "Tahoma"
			gridBaseStyle4.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
			Me.gridControl1.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() { gridBaseStyle1, gridBaseStyle2, gridBaseStyle3, gridBaseStyle4})
			Me.gridControl1.ColCount = 2
			Me.gridControl1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() { New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)})
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.ForeColor = System.Drawing.SystemColors.ControlText
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Properties.BackgroundColorString = "Control"
			Me.gridControl1.Properties.FixedLinesColorString = "ActiveCaption"
			Me.gridControl1.Properties.GridLineColorString = "GrayText"
			Me.gridControl1.Properties.ResizingCellsLinesColorString = "Red"
			Me.gridControl1.Properties.RowHeaders = False
			Me.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.gridControl1.RowCount = 0
			Me.gridControl1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() { New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 25)})
			'this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
			Me.gridControl1.Size = New System.Drawing.Size(344, 24)
			Me.gridControl1.SmartSizeBox = False
			Me.gridControl1.TabIndex = 0
            Me.gridControl1.ThemesEnabled = True

            AddHandler Me.gridControl1.Click, AddressOf Me.gridControl1_Click
            AddHandler Me.gridControl1.CellClick, AddressOf Me.gridControl1_CellClick
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.gridControl1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(344, 24)
			Me.panel1.TabIndex = 1
			' 
			' ColumnSetViewHeader
			' 
			Me.Controls.Add(Me.panel1)
			Me.Name = "ColumnSetViewHeader"
			Me.Size = New System.Drawing.Size(344, 24)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		#Region "GridControl events"

		Private flag As Boolean
		Private Sub gridControl1_CellClick(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridCellClickEventArgs)
			If e.ColIndex = 2 AndAlso flag Then
				Me.gridControl1(0,2).Tag = ListSortDirection.Ascending
				Me.gridControl1(0,2).Text = "Oldest On Top"
			End If
			If e.ColIndex = 2 AndAlso (Not flag) Then
				Me.gridControl1(0,2).Tag = ListSortDirection.Descending
				Me.gridControl1(0,2).Text = "Newest On Top"
			End If
			flag = Not flag
		End Sub
		Private Sub gridControl1_QueryColWidth(ByVal sender As Object, ByVal e As GridRowColSizeEventArgs)
			If e.Index = 1 Then
				e.Size = pane_Renamed.Grid.TableDescriptor.Columns("mails").Width + pane_Renamed.SecondColumnSetSize ' size of 2 column sets
			End If
			If e.Index = 2 Then
				e.Size = pane_Renamed.Grid.Width - Me.gridControl1.ColWidths(1)
			End If
			e.Handled = True
		End Sub
		#End Region

		Private pane_Renamed As GroupingPanel
		Public ReadOnly Property Pane() As GroupingPanel
			Get
				Return pane_Renamed
			End Get
		End Property
		#Region "class support functions"
		Public Sub wire(ByVal f As GroupingPanel)
			If (Not f.NormalView) Then
				pane_Renamed = f
			End If
		End Sub
		#End Region

		Private Sub gridControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridControl1.Click

		End Sub
	End Class
End Namespace
