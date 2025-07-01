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
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms

Namespace GridLinkLabel
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private panel1 As System.Windows.Forms.Panel
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

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

'			#Region "Custom Cells"
			gridControl1.ExcelLikeCurrentCell = True
			gridControl1.ExcelLikeSelectionFrame = True
			gridControl1.ControllerOptions = GridControllerOptions.All
			gridControl1.HScrollBehavior = GridScrollbarMode.Disabled
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(1, 1, 2, gridControl1.ColCount))
			gridControl1(1, 1).Text = "Derived Cell Controls"
			gridControl1(1, 1).Font.Bold = True
			gridControl1(1, 1).Font.Size = 12
			gridControl1(1, 1).TextColor = Color.Black
			gridControl1(1, 1).CellType = GridCellTypeName.Static
			gridControl1(1, 1).VerticalAlignment = GridVerticalAlignment.Middle
			gridControl1(1, 1).HorizontalAlignment = GridHorizontalAlignment.Center
			gridControl1.CellModels.Add("LinkLabelCell", New LinkLabelCellModel(gridControl1.Model))

			Dim rowIndex As Integer = 4
			gridControl1(rowIndex, 4).CellType = "LinkLabelCell"
			gridControl1(rowIndex, 4).Text = "Syncfusion, Inc."
			gridControl1(rowIndex, 4).Font.Bold = True
			gridControl1(rowIndex, 4).Tag = "http://www.syncfusion.com"
			gridControl1(rowIndex, 4).HorizontalAlignment = GridHorizontalAlignment.Center

			rowIndex += 1
			gridControl1(rowIndex, 4).CellType = "LinkLabelCell"
			gridControl1(rowIndex, 4).Text = "Windows Forms FAQ"
			gridControl1(rowIndex, 4).Font.Bold = True
			gridControl1(rowIndex, 4).Tag = "http://www.syncfusion.com/support/forums/grid-windows"
			gridControl1(rowIndex, 4).HorizontalAlignment = GridHorizontalAlignment.Center

			rowIndex += 1
			gridControl1(rowIndex, 4).CellType = "LinkLabelCell"
			gridControl1(rowIndex, 4).Text = "Microsoft Windows Forms"
			gridControl1(rowIndex, 4).Font.Bold = True
			gridControl1(rowIndex, 4).Tag = "http://windowsforms.net/"
			gridControl1(rowIndex, 4).HorizontalAlignment = GridHorizontalAlignment.Center

			rowIndex += 1
			gridControl1(rowIndex, 4).CellType = "LinkLabelCell"
			gridControl1(rowIndex, 4).Text = "MSDN"
			gridControl1(rowIndex, 4).Font.Bold = True
			gridControl1(rowIndex, 4).Tag = "http://msdn.microsoft.com"
			gridControl1(rowIndex, 4).HorizontalAlignment = GridHorizontalAlignment.Center

			rowIndex += 1
			gridControl1(rowIndex, 4).CellType = "LinkLabelCell"
			gridControl1(rowIndex, 4).Text = "Yahoo"
			gridControl1(rowIndex, 4).Font.Bold = True
			gridControl1(rowIndex, 4).Tag = "http://www.yahoo.com"
			gridControl1(rowIndex, 4).HorizontalAlignment = GridHorizontalAlignment.Center

			rowIndex += 1
			gridControl1(rowIndex, 4).CellType = "LinkLabelCell"
			gridControl1(rowIndex, 4).Text = "Google"
			gridControl1(rowIndex, 4).Font.Bold = True
			gridControl1(rowIndex, 4).Tag = "http://www.google.com/"
			gridControl1(rowIndex, 4).HorizontalAlignment = GridHorizontalAlignment.Center

			gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Col(4))
			gridControl1.ColStyles(4).TextColor = Color.Blue

            'this.gridControl1.DefaultRowHeight = 18;
			Me.gridControl1.DefaultColWidth = 70
			'this.gridControl1.Properties.GridLineColor = System.Drawing.Color.Silver;
			Me.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid
'			#End Region

		End Sub

		#Region "FormHandlers"

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
            Dim GridBaseStyle1 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle2 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle3 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle4 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridCellInfo1 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.panel1 = New System.Windows.Forms.Panel
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            GridBaseStyle1.Name = "Row Header"
            GridBaseStyle1.StyleInfo.BaseStyle = "Header"
            GridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
            GridBaseStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle2.Name = "Column Header"
            GridBaseStyle2.StyleInfo.BaseStyle = "Header"
            GridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            GridBaseStyle3.Name = "Standard"
            GridBaseStyle3.StyleInfo.Font.Facename = "Tahoma"
            GridBaseStyle3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
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
            Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gridControl1.ColCount = 7
            Me.gridControl1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)})
            Me.gridControl1.DefaultColWidth = 70
            Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
            Me.gridControl1.DefaultRowHeight = 20
            Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.5!)
            Me.gridControl1.ForeColor = System.Drawing.Color.MidnightBlue
            GridCellInfo1.Col = -1
            GridCellInfo1.Row = -1
            GridCellInfo1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridCellInfo1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridCellInfo1.StyleInfo.Font.Bold = False
            GridCellInfo1.StyleInfo.Font.Facename = "Segoe UI"
            GridCellInfo1.StyleInfo.Font.Italic = False
            GridCellInfo1.StyleInfo.Font.Size = 8.5!
            GridCellInfo1.StyleInfo.Font.Strikeout = False
            GridCellInfo1.StyleInfo.Font.Underline = False
            GridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridCellInfo1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridCellInfo1.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridControl1.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() {GridCellInfo1})
            Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridControl1.Location = New System.Drawing.Point(3, 11)
            Me.gridControl1.MetroScrollBars = True
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
            Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridControl1.Properties.MarkColHeader = False
            Me.gridControl1.Properties.MarkRowHeader = False
            Me.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.gridControl1.RowCount = 20
            Me.gridControl1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
            Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode
            Me.gridControl1.Size = New System.Drawing.Size(607, 406)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.TabIndex = 1
            Me.gridControl1.ThemesEnabled = True
            Me.gridControl1.VerticalThumbTrack = True
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.gridControl1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(615, 424)
            Me.panel1.TabIndex = 2
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(615, 424)
            Me.Controls.Add(Me.panel1)
            Me.DropShadow = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
            Me.Text = "Getting Started"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
        <STAThread()> _
  Public Shared Sub Main()
#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
            Application.EnableVisualStyles()
#End If
            Application.Run(New Form1())
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

		#End Region

		#Region "EventHandlers"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			gridControl1.Model.BaseStylesMap("Header").StyleInfo.Font.Bold = True
		End Sub
		#End Region
	End Class
End Namespace
