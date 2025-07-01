Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Namespace FolderBrowser

	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class TreeGridForm
		Inherits Syncfusion.Windows.Forms.MetroForm
		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private imageList1 As System.Windows.Forms.ImageList
		Private components As System.ComponentModel.IContainer

		Public Shared NoChildBMP As Integer
		Public Shared OpenedBMP As Integer
		Public Shared ClosedBMP As Integer
		Private label1 As System.Windows.Forms.Label
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents comboBox1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private WithEvents checkBox1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv


		'sample data members...
		Public Shared externalData As CollapsibleDataSource

		Public Sub New()
			NoChildBMP = 2
			OpenedBMP = 0
			ClosedBMP = 1

			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			gridControl1.ControllerOptions = GridControllerOptions.All And ((Not GridControllerOptions.OleDataSource))

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
            Me.components = New System.ComponentModel.Container
            Dim GridBaseStyle1 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle2 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle3 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle4 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridCellInfo1 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
            Dim GridCellInfo2 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
            Dim GridCellInfo3 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
            Dim GridCellInfo4 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
            Dim GridCellInfo5 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
            Dim GridCellInfo6 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
            Dim GridCellInfo7 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TreeGridForm))
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.label1 = New System.Windows.Forms.Label
            Me.panel1 = New System.Windows.Forms.Panel
            Me.checkBox1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.comboBox1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.AllowSelection = CType(((((((Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Row Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Table) _
                        Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Cell) _
                        Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Multiple) _
                        Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Shift) _
                        Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Keyboard) _
                        Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.AlphaBlend), Syncfusion.Windows.Forms.Grid.GridSelectionFlags)
            Me.gridControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.gridControl1.BackColor = System.Drawing.Color.White
            GridBaseStyle1.Name = "Row Header"
            GridBaseStyle1.StyleInfo.BaseStyle = "Header"
            GridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
            GridBaseStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle2.Name = "Column Header"
            GridBaseStyle2.StyleInfo.BaseStyle = "Header"
            GridBaseStyle2.StyleInfo.Font.Facename = "Verdana"
            GridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            GridBaseStyle3.Name = "Standard"
            GridBaseStyle3.StyleInfo.Font.Facename = "Verdana"
            GridBaseStyle3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            GridBaseStyle3.StyleInfo.TextColor = System.Drawing.Color.MidnightBlue
            GridBaseStyle4.Name = "Header"
            GridBaseStyle4.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle4.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle4.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle4.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle4.StyleInfo.CellType = "Header"
            GridBaseStyle4.StyleInfo.Font.Bold = True
            GridBaseStyle4.StyleInfo.Font.Facename = "Verdana"
            GridBaseStyle4.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle4.StyleInfo.TextColor = System.Drawing.Color.MidnightBlue
            GridBaseStyle4.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            Me.gridControl1.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle1, GridBaseStyle2, GridBaseStyle3, GridBaseStyle4})
            Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.gridControl1.ColCount = 5
            Me.gridControl1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35), New Syncfusion.Windows.Forms.Grid.GridColWidth(4, 89)})
            Me.gridControl1.Font = New System.Drawing.Font("Verdana", 8.25!)
            Me.gridControl1.ForeColor = System.Drawing.Color.MidnightBlue
            GridCellInfo1.Col = -1
            GridCellInfo1.Row = -1
            GridCellInfo1.StyleInfo.Font.Bold = False
            GridCellInfo1.StyleInfo.Font.Facename = "Verdana"
            GridCellInfo1.StyleInfo.Font.Italic = False
            GridCellInfo1.StyleInfo.Font.Size = 8.25!
            GridCellInfo1.StyleInfo.Font.Strikeout = False
            GridCellInfo1.StyleInfo.Font.Underline = False
            GridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridCellInfo2.Col = -1
            GridCellInfo2.Row = -1
            GridCellInfo2.StyleInfo.Font.Bold = False
            GridCellInfo2.StyleInfo.Font.Facename = "Verdana"
            GridCellInfo2.StyleInfo.Font.Italic = False
            GridCellInfo2.StyleInfo.Font.Size = 8.25!
            GridCellInfo2.StyleInfo.Font.Strikeout = False
            GridCellInfo2.StyleInfo.Font.Underline = False
            GridCellInfo2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridCellInfo3.Col = 1
            GridCellInfo3.Row = 0
            GridCellInfo3.StyleInfo.Text = "Name"
            GridCellInfo4.Col = 2
            GridCellInfo4.Row = 0
            GridCellInfo4.StyleInfo.Text = "Size"
            GridCellInfo5.Col = 3
            GridCellInfo5.Row = 0
            GridCellInfo5.StyleInfo.Text = "Path"
            GridCellInfo6.Col = 4
            GridCellInfo6.Row = 0
            GridCellInfo6.StyleInfo.Text = "Modified Time"
            GridCellInfo6.StyleInfo.Themed = True
            GridCellInfo7.Col = 5
            GridCellInfo7.Row = 0
            GridCellInfo7.StyleInfo.Text = "Type"
            Me.gridControl1.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() {GridCellInfo1, GridCellInfo2, GridCellInfo3, GridCellInfo4, GridCellInfo5, GridCellInfo6, GridCellInfo7})
            Me.gridControl1.HorizontalThumbTrack = True
            Me.gridControl1.Location = New System.Drawing.Point(-1, 50)
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.gridControl1.Properties.MarkColHeader = False
            Me.gridControl1.Properties.MarkRowHeader = False
            Me.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.gridControl1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
            Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode
            Me.gridControl1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways
            Me.gridControl1.Size = New System.Drawing.Size(653, 407)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ThemesEnabled = True
            Me.gridControl1.VerticalThumbTrack = True
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
            Me.imageList1.Images.SetKeyName(2, "")
            Me.imageList1.Images.SetKeyName(3, "")
            Me.imageList1.Images.SetKeyName(4, "")
            Me.imageList1.Images.SetKeyName(5, "")
            '
            'label1
            '
            Me.label1.BackColor = System.Drawing.Color.White
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(19, Byte), Integer))
            Me.label1.Location = New System.Drawing.Point(3, 13)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(136, 16)
            Me.label1.TabIndex = 4
            Me.label1.Text = "Logical Drives"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.checkBox1)
            Me.panel1.Controls.Add(Me.gridControl1)
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Location = New System.Drawing.Point(12, 12)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(656, 462)
            Me.panel1.TabIndex = 7
            '
            'checkBox1
            '
            Me.checkBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.checkBox1.DrawFocusRectangle = False
            Me.checkBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox1.ForeColor = System.Drawing.Color.Navy
            Me.checkBox1.Location = New System.Drawing.Point(407, 12)
            Me.checkBox1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(216, Byte), Integer))
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(104, 24)
            Me.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox1.TabIndex = 1
            Me.checkBox1.Text = "Hide Details"
            Me.checkBox1.ThemesEnabled = False
            '
            'comboBox1
            '
            Me.comboBox1.BackColor = System.Drawing.Color.White
            Me.comboBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboBox1.Location = New System.Drawing.Point(162, 13)
            Me.comboBox1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(184, 23)
            Me.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
            Me.comboBox1.TabIndex = 0
            Me.comboBox1.Text = "[select drive]"
            '
            'TreeGridForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(681, 489)
            Me.Controls.Add(Me.panel1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "TreeGridForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Grid Folder Browser Demo"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
			Application.Run(New TreeGridForm())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Dim drives() As String = System.IO.Directory.GetLogicalDrives()
			For Each drv As String In drives
				Me.comboBox1.Items.Add(drv)
			Next drv
			Me.comboBox1.SelectedIndex = 0

			'add a custom cell control
			gridControl1.CellModels.Add("TreeCell", New TreeCellModel(gridControl1.Model))

			'make the imagelist available thru the tablestyle
			gridControl1.TableStyle.ImageList = Me.imageList1

			'create a sample data for a virtual grid
			externalData = New CollapsibleDataSource(Me.comboBox1.SelectedItem.ToString())
			externalData.InitData() 'initializes an external datasource
			externalData.CollapseData() ' c

			'hook up the events needed for virtual grid
			gridControl1.ResetVolatileData()
			AddHandler gridControl1.QueryCellInfo, AddressOf GridQueryCellInfo
			AddHandler gridControl1.QueryRowCount, AddressOf GridQueryRowCount
			AddHandler gridControl1.QueryColCount, AddressOf GridQueryColCount
			'gridControl1.QueryColWidth += new GridRowColSizeEventHandler(GridQueryColWidth);

			'handle saving data back to the data source...
			AddHandler gridControl1.SaveCellInfo, AddressOf GridSaveCellInfo
			Me.gridControl1.DefaultRowHeight = 18
			Me.gridControl1.DefaultColWidth = 100
			Me.gridControl1.DefaultGridBorderStyle = GridBorderStyle.None
			Me.gridControl1.Properties.RowHeaders = False
			AddHandler gridControl1.CellDoubleClick, AddressOf gridControl1_CellDoubleClick
			Me.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Table())
			Me.gridControl1.TableStyle.Trimming = StringTrimming.EllipsisCharacter
			Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridControl1.ListBoxSelectionMode = SelectionMode.One
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
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

		Private Sub GridSaveCellInfo(ByVal sender As Object, ByVal e As GridSaveCellInfoEventArgs)
			Try
				'move the changes back to the external data object
				If e.ColIndex = 1 AndAlso e.RowIndex > 0 Then
					externalData(e.RowIndex - 1).ExpandState = CInt(Fix(e.Style.ImageIndex))
					externalData(e.RowIndex - 1).IndentLevel = CInt(Fix(e.Style.Tag))
				End If

				If e.ColIndex > 0 AndAlso e.RowIndex > 0 Then
					externalData(e.RowIndex - 1).Items(e.ColIndex - 1) = CStr(e.Style.CellValue)

				End If
			Catch
			End Try

			'refresh this row so change is displayed
			If Not externalData.Locked Then
				externalData.CollapseData()
				Me.gridControl1.Refresh()
			End If
			e.Handled = True
		End Sub

		Private Sub GridQueryColWidth(ByVal sender As Object, ByVal e As GridRowColSizeEventArgs)
			If e.Index = 1 OrElse e.Index = 3 Then
				e.Size = 500
			ElseIf e.Index > 0 Then
				e.Size = 100
			Else
				e.Size = 0 'hide the header
			End If

			e.Handled = True
		End Sub
		Private Sub GridQueryRowCount(ByVal sender As Object, ByVal e As GridRowColCountEventArgs)
			If externalData IsNot Nothing Then
				e.Count = externalData.RowCount
			End If
			e.Handled = True
		End Sub

		Private Sub GridQueryColCount(ByVal sender As Object, ByVal e As GridRowColCountEventArgs)
			If externalData IsNot Nothing Then
				e.Count = externalData.ColCount
			End If
			e.Handled = True
		End Sub

		Private Sub GridQueryCellInfo(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
			If e.RowIndex > 0 AndAlso e.ColIndex > 0 Then
				If externalData IsNot Nothing Then
					e.Style.CellValue = externalData(e.RowIndex - 1).Items(e.ColIndex - 1)
					If e.ColIndex = 1 Then
						e.Style.CellType = "TreeCell"
						e.Style.Tag = externalData(e.RowIndex - 1).IndentLevel
						e.Style.ImageIndex = CInt(Fix(externalData(e.RowIndex - 1).ExpandState))
					End If
				End If
				e.Handled = True

				If e.ColIndex = 2 Then
					Dim value As Double = Double.Parse(e.Style.Text)
					If value < 1024 Then
						e.Style.CellValue = value & " B"
					ElseIf value < 1048575 Then
						value = Math.Floor(value/1024)
						e.Style.CellValue = value & " KB"
					ElseIf value < 1073741824 Then
						value = Math.Floor(value/1048575)
						e.Style.CellValue = value & " MB"
					ElseIf value > 1073741824 Then
						value = Math.Floor(value/1073741824)
						e.Style.CellValue = value & " GB"
					End If
				End If
			End If

		End Sub

		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
			externalData = New CollapsibleDataSource(Me.comboBox1.SelectedItem.ToString())
			If externalData.IsEmpty Then
				externalData = Nothing
			Else
				externalData.InitData()
				externalData.CollapseData()
			End If
			If TreeCellRenderer.nodeList IsNot Nothing Then
				TreeCellRenderer.nodeList.Clear()
			End If
			gridControl1.ResetVolatileData()
			gridControl1.Refresh()
		End Sub

		Private Sub gridControl1_CellDoubleClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
			If e.RowIndex > 0 AndAlso e.ColIndex = 1 Then
				If Me.gridControl1(e.RowIndex, e.ColIndex).ImageIndex = CInt(Fix(TreeNodeState.Opened)) Then
					Me.gridControl1(e.RowIndex, e.ColIndex).ImageIndex = CInt(Fix(TreeNodeState.Closed))
				ElseIf Me.gridControl1(e.RowIndex, e.ColIndex).ImageIndex = CInt(Fix(TreeNodeState.Closed)) Then
					Me.gridControl1(e.RowIndex, e.ColIndex).ImageIndex = CInt(Fix(TreeNodeState.Opened))
					If Not TreeCellRenderer.nodeList.Contains(Me.gridControl1(e.RowIndex, 3).Text) Then
						Dim indent As Integer = externalData(e.RowIndex-1).IndentLevel
						externalData.InsertData(e.RowIndex, Me.gridControl1(e.RowIndex,3).Text, indent)
						TreeCellRenderer.nodeList.Add(Me.gridControl1(e.RowIndex,3).Text,"Added")
					End If
					Me.gridControl1.Refresh()
					Me.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Table())
				End If
			End If
        End Sub
		
        Private Sub checkBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox1.CheckedChanged
            If checkBox1.Checked Then
                Me.gridControl1.Cols.Hidden(2) = True
                Me.gridControl1.Cols.Hidden(3) = True
                Me.gridControl1.Cols.Hidden(4) = True
                Me.gridControl1.Cols.Hidden(5) = True
            Else
                Me.gridControl1.Cols.Hidden(2) = False
                Me.gridControl1.Cols.Hidden(3) = False
                Me.gridControl1.Cols.Hidden(4) = False
                Me.gridControl1.Cols.Hidden(5) = False
            End If
        End Sub
    End Class
End Namespace
