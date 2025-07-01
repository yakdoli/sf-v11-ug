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
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Text

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Diagnostics
Imports Syncfusion.Styles

Namespace GridSample
	Public Class Form1
		Inherits MetroForm
		Friend WithEvents gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Friend WithEvents printPreviewButton As Syncfusion.Windows.Forms.ButtonAdv
		Friend propertyGrid1 As System.Windows.Forms.PropertyGrid
		Friend WithEvents splitterControl1 As Syncfusion.Windows.Forms.SplitterControl
		Friend output As System.Windows.Forms.ListBox
		Friend dataSet11 As DataSet1
		Private WithEvents checkBoxMouseMessage As System.Windows.Forms.CheckBox
		Private components As IContainer
		Private WithEvents checkBoxEnableTracing As System.Windows.Forms.CheckBox
		Private contextMenu1 As System.Windows.Forms.ContextMenu
		Private WithEvents menuItem1 As System.Windows.Forms.MenuItem
		Private WithEvents panel1 As System.Windows.Forms.Panel
		Private panel2 As System.Windows.Forms.Panel
		Private WithEvents splitter1 As System.Windows.Forms.Splitter
		Private groupBox1 As GroupBox
		Private tracer As CurrentCellEventTracer

		Public Sub New()
			dataSet11 = New DataSet1()

			InitializeComponent()

			Me.ActiveControl = Me.splitterControl1

			splitterControl1.ThemesEnabled = True

			gridControl1.Initialize()
			gridControl1.ThemesEnabled = True
			gridControl1.ControllerOptions = gridControl1.ControllerOptions And Not(GridControllerOptions.OleDataSource Or GridControllerOptions.OleDropTarget)
			gridControl1.CurrentCell.MoveTo(1, 1)
			gridControl1.BaseStylesMap("Header").StyleInfo.Enabled = False
			gridControl1.VScrollPixel = True
			gridControl1.HScrollPixel = True


			tracer = New CurrentCellEventTracer(Me.splitterControl1, Me.output)
			checkBoxMouseMessage.Checked = tracer.DisplayMouseMessages
			checkBoxEnableTracing.Checked = tracer.Enabled

			Dim heading1 As GridStyleInfo = gridControl1.BaseStylesMap("Heading 1").StyleInfo
			heading1.TextColor = Color.Blue
			heading1.Font.Size = 14
			heading1.Font.Bold = True

			Dim heading2 As GridStyleInfo = gridControl1.BaseStylesMap("Heading 2").StyleInfo
			heading2.TextColor = Color.Blue
			heading2.Font.Size = 14
			heading2.Font.Bold = True

			Me.output.ContextMenu = Me.contextMenu1

			Me.propertyGrid1.CausesValidation = False
			Me.splitter1.CausesValidation = False
			Me.panel1.CausesValidation = False
			Me.panel2.CausesValidation = False

			' read the data from a local XML file
			ReadXml(Me.dataSet11, "Data\GDBDdata.XML")
		End Sub

		'hunt the folder tree for the data\*.xml file..
		Private Sub ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String)
			If ds Is Nothing Then
				Return
			End If

			For n As Integer = 0 To 9
				If System.IO.File.Exists(xmlFileName) Then
					ds.ReadXml(xmlFileName)
					Exit For
				End If
				xmlFileName = "..\" & xmlFileName
			Next n
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
			Me.components = New System.ComponentModel.Container()
			Dim gridBaseStyle9 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle10 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle11 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle12 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridCellInfo3 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.printPreviewButton = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
			Me.splitterControl1 = New Syncfusion.Windows.Forms.SplitterControl()
			Me.output = New System.Windows.Forms.ListBox()
			Me.checkBoxMouseMessage = New System.Windows.Forms.CheckBox()
			Me.checkBoxEnableTracing = New System.Windows.Forms.CheckBox()
			Me.contextMenu1 = New System.Windows.Forms.ContextMenu()
			Me.menuItem1 = New System.Windows.Forms.MenuItem()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.splitter1 = New System.Windows.Forms.Splitter()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitterControl1.SuspendLayout()
			Me.panel1.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			gridBaseStyle9.Name = "Row Header"
			gridBaseStyle9.StyleInfo.BaseStyle = "Header"
			gridBaseStyle9.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
			gridBaseStyle9.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb((CInt(Fix((CByte(203))))), (CInt(Fix((CByte(199))))), (CInt(Fix((CByte(184)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(216)))))))
			gridBaseStyle10.Name = "Column Header"
			gridBaseStyle10.StyleInfo.BaseStyle = "Header"
			gridBaseStyle10.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridBaseStyle11.Name = "Standard"
			gridBaseStyle11.StyleInfo.Font.Facename = "Tahoma"
			gridBaseStyle11.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
			gridBaseStyle12.Name = "Header"
			gridBaseStyle12.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle12.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle12.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle12.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle12.StyleInfo.CellType = "Header"
			gridBaseStyle12.StyleInfo.Font.Bold = True
			gridBaseStyle12.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(203))))), (CInt(Fix((CByte(199))))), (CInt(Fix((CByte(184)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(216)))))))
			gridBaseStyle12.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
			Me.gridControl1.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() { gridBaseStyle9, gridBaseStyle10, gridBaseStyle11, gridBaseStyle12})
			Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gridControl1.ColCount = 12
			Me.gridControl1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() { New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)})
			Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
			Me.gridControl1.DefaultRowHeight = 20
			Me.gridControl1.FillSplitterPane = True
			Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.5F)
			Me.gridControl1.ForeColor = System.Drawing.Color.MidnightBlue
			gridCellInfo3.Col = -1
			gridCellInfo3.Row = -1
			gridCellInfo3.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridCellInfo3.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridCellInfo3.StyleInfo.Font.Bold = False
			gridCellInfo3.StyleInfo.Font.Facename = "Segoe UI"
			gridCellInfo3.StyleInfo.Font.Italic = False
			gridCellInfo3.StyleInfo.Font.Size = 8.5F
			gridCellInfo3.StyleInfo.Font.Strikeout = False
			gridCellInfo3.StyleInfo.Font.Underline = False
			gridCellInfo3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridCellInfo3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridCellInfo3.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			Me.gridControl1.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() { gridCellInfo3})
			Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridControl1.HorizontalThumbTrack = True
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MetroScrollBars = True
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Properties.BackgroundColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(255))))))
			Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(215))))), (CInt(Fix((CByte(229))))))
			Me.gridControl1.Properties.MarkColHeader = False
			Me.gridControl1.Properties.MarkRowHeader = False
			Me.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.gridControl1.RowCount = 120
			Me.gridControl1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() { New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
			Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode
			Me.gridControl1.Size = New System.Drawing.Size(609, 322)
			Me.gridControl1.SmartSizeBox = False
			Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.VerticalThumbTrack = True
'			Me.gridControl1.SelectionChanged += New Syncfusion.Windows.Forms.Grid.GridSelectionChangedEventHandler(Me.grid_SelectionChanged)
'			Me.gridControl1.CurrentCellMoved += New Syncfusion.Windows.Forms.Grid.GridCurrentCellMovedEventHandler(Me.grid_CurrentCellMoved)
			' 
			' printPreviewButton
			' 
			Me.printPreviewButton.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.printPreviewButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.printPreviewButton.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.printPreviewButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.printPreviewButton.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.printPreviewButton.ForeColor = System.Drawing.Color.White
			Me.printPreviewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.printPreviewButton.Location = New System.Drawing.Point(699, 139)
			Me.printPreviewButton.Name = "printPreviewButton"
			Me.printPreviewButton.Size = New System.Drawing.Size(165, 34)
			Me.printPreviewButton.TabIndex = 1
			Me.printPreviewButton.Text = "Print Preview"
			Me.printPreviewButton.UseVisualStyle = True
			Me.printPreviewButton.UseVisualStyleBackColor = True
'			Me.printPreviewButton.Click += New System.EventHandler(Me.printPreviewButton_Click)
			' 
			' propertyGrid1
			' 
			Me.propertyGrid1.BackColor = System.Drawing.Color.White
			Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.White
			Me.propertyGrid1.CommandsLinkColor = System.Drawing.Color.White
			Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
			Me.propertyGrid1.Location = New System.Drawing.Point(659, 0)
			Me.propertyGrid1.Name = "propertyGrid1"
			Me.propertyGrid1.Size = New System.Drawing.Size(263, 317)
			Me.propertyGrid1.TabIndex = 2
			' 
			' splitterControl1
			' 
			Me.splitterControl1.BackColor = System.Drawing.Color.White
			Me.splitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.splitterControl1.Controls.Add(Me.gridControl1)
			Me.splitterControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.splitterControl1.Location = New System.Drawing.Point(12, 0)
			Me.splitterControl1.Name = "splitterControl1"
			Me.splitterControl1.Size = New System.Drawing.Size(626, 339)
			Me.splitterControl1.SplitBars = (CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars))
			Me.splitterControl1.TabIndex = 6
			Me.splitterControl1.ThemesEnabled = True
'			Me.splitterControl1.PaneClosing += New Syncfusion.Windows.Forms.SplitterPaneEventHandler(Me.splitterControl1_PaneClosing)
'			Me.splitterControl1.PaneCreated += New Syncfusion.Windows.Forms.SplitterPaneEventHandler(Me.splitterControl1_PaneCreated)
			' 
			' output
			' 
			Me.output.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.output.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(21))))), (CInt(Fix((CByte(84))))))
			Me.output.ItemHeight = 15
			Me.output.Location = New System.Drawing.Point(12, 6)
			Me.output.Name = "output"
			Me.output.ScrollAlwaysVisible = True
			Me.output.Size = New System.Drawing.Size(612, 182)
			Me.output.TabIndex = 4
			' 
			' checkBoxMouseMessage
			' 
			Me.checkBoxMouseMessage.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkBoxMouseMessage.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.checkBoxMouseMessage.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBoxMouseMessage.Location = New System.Drawing.Point(31, 62)
			Me.checkBoxMouseMessage.Name = "checkBoxMouseMessage"
			Me.checkBoxMouseMessage.Size = New System.Drawing.Size(165, 33)
			Me.checkBoxMouseMessage.TabIndex = 7
			Me.checkBoxMouseMessage.Text = "Trace Mouse and Control Messages"
'			Me.checkBoxMouseMessage.CheckedChanged += New System.EventHandler(Me.checkBoxMouseMessage_CheckedChanged)
			' 
			' checkBoxEnableTracing
			' 
			Me.checkBoxEnableTracing.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkBoxEnableTracing.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.checkBoxEnableTracing.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBoxEnableTracing.Location = New System.Drawing.Point(31, 36)
			Me.checkBoxEnableTracing.Name = "checkBoxEnableTracing"
			Me.checkBoxEnableTracing.Size = New System.Drawing.Size(183, 20)
			Me.checkBoxEnableTracing.TabIndex = 7
			Me.checkBoxEnableTracing.Text = "Enable Tracing"
'			Me.checkBoxEnableTracing.CheckedChanged += New System.EventHandler(Me.checkBoxEnableTracing_CheckedChanged)
			' 
			' contextMenu1
			' 
			Me.contextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem1})
			' 
			' menuItem1
			' 
			Me.menuItem1.Index = 0
			Me.menuItem1.Text = "&Clear Window"
'			Me.menuItem1.Click += New System.EventHandler(Me.menuItem1_Click)
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.White
			Me.panel1.Controls.Add(Me.splitterControl1)
			Me.panel1.Controls.Add(Me.propertyGrid1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(926, 342)
			Me.panel1.TabIndex = 8
'			Me.panel1.Paint += New System.Windows.Forms.PaintEventHandler(Me.panel1_Paint)
			' 
			' panel2
			' 
			Me.panel2.BackColor = System.Drawing.Color.White
			Me.panel2.Controls.Add(Me.groupBox1)
			Me.panel2.Controls.Add(Me.printPreviewButton)
			Me.panel2.Controls.Add(Me.output)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panel2.Location = New System.Drawing.Point(0, 363)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(926, 210)
			Me.panel2.TabIndex = 9
			' 
			' splitter1
			' 
			Me.splitter1.Dock = System.Windows.Forms.DockStyle.Top
			Me.splitter1.Location = New System.Drawing.Point(0, 342)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(926, 15)
			Me.splitter1.TabIndex = 10
			Me.splitter1.TabStop = False
'			Me.splitter1.SplitterMoved += New System.Windows.Forms.SplitterEventHandler(Me.splitter1_SplitterMoved_1)
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.checkBoxEnableTracing)
			Me.groupBox1.Controls.Add(Me.checkBoxMouseMessage)
			Me.groupBox1.Location = New System.Drawing.Point(668, 6)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(232, 115)
			Me.groupBox1.TabIndex = 8
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Event trace Options"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
			Me.BackColor = System.Drawing.Color.White
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(926, 573)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.panel2)
			Me.DropShadow = True
			Me.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Web Browser Cell Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitterControl1.ResumeLayout(False)
			Me.panel1.ResumeLayout(False)
			Me.panel2.ResumeLayout(False)
			Me.groupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
#End Region

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
			Me.Icon = ico
			Me.gridControl1.DefaultRowHeight = 18
			Me.gridControl1.DefaultColWidth = 70
			Me.WindowState = FormWindowState.Maximized
			Me.splitterControl1.HSplitPos = 80
			Me.splitter1.SplitPosition = Me.Height - Me.panel2.Height \ 2
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


		Private Sub printPreviewButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles printPreviewButton.Click
			If gridControl1 IsNot Nothing Then
				Try
					Dim grid As GridControl = TryCast(Me.splitterControl1.ActivePane, GridControl)
					If grid IsNot Nothing Then
						Dim pd As New GridPrintDocument(gridControl1, True) 'Assumes the default printer

						Dim dlg As New PrintPreviewDialog()
						dlg.Document = pd
						dlg.ShowDialog()
					End If
				Catch ex As Exception
					MessageBox.Show("An error occurred attempting to preview the file to print - " & ex.Message)
				End Try
			End If

		End Sub

		Private Sub checkBoxMouseMessage_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBoxMouseMessage.CheckedChanged
			tracer.DisplayMouseMessages = checkBoxMouseMessage.Checked
		End Sub

		Private Sub checkBoxEnableTracing_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBoxEnableTracing.CheckedChanged
			tracer.Enabled = Me.checkBoxEnableTracing.Checked
		End Sub

		Private Sub menuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem1.Click
			Me.output.Items.Clear()
		End Sub

		Private Sub splitterControl1_PaneClosing(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.SplitterPaneEventArgs) Handles splitterControl1.PaneClosing
			Dim grid As GridControl = CType(e.Control, GridControl)
			RemoveHandler grid.CurrentCellMoved, AddressOf grid_CurrentCellMoved
			RemoveHandler grid.SelectionChanged, AddressOf grid_SelectionChanged
		End Sub

		Private Sub splitterControl1_PaneCreated(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.SplitterPaneEventArgs) Handles splitterControl1.PaneCreated
			Dim grid As GridControl = CType(e.Control, GridControl)
			AddHandler grid.CurrentCellMoved, AddressOf grid_CurrentCellMoved
			AddHandler grid.SelectionChanged, AddressOf grid_SelectionChanged
		End Sub

		Private Sub grid_CurrentCellMoved(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridCurrentCellMovedEventArgs) Handles gridControl1.CurrentCellMoved
			grid = CType(sender, GridControlBase)
			DelayRefreshPropertyGrid(GridRangeInfo.Cell(grid.CurrentCell.RowIndex, grid.CurrentCell.ColIndex), 50)
		End Sub

		Private Sub grid_SelectionChanged(ByVal sender As Object, ByVal e As GridSelectionChangedEventArgs) Handles gridControl1.SelectionChanged
			DelayRefreshPropertyGrid(e.Range, 200)
		End Sub

		Private range As GridRangeInfo = GridRangeInfo.Empty
		Private style As GridStyleInfo = Nothing
		Private grid As GridControlBase = Nothing
		Private refreshPropertyGridNextIdle As Boolean = False
		Private refreshTimer As Timer = Nothing

		Private Sub DelayRefreshPropertyGrid(ByVal range As GridRangeInfo, ByVal interval As Integer)
			If refreshTimer IsNot Nothing Then
				refreshPropertyGridNextIdle = False
				refreshTimer.Stop()
			Else
				refreshTimer = New Timer()
				refreshTimer.Interval = interval
				AddHandler refreshTimer.Tick, AddressOf DelayedRefreshPropertyGrid
			End If
			refreshTimer.Start()
			refreshPropertyGridNextIdle = True
			Me.range = range
		End Sub

		Private Sub DelayedRefreshPropertyGrid(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfo()
			Dim t As Timer = TryCast(sender, Timer)
			t.Dispose()
			Me.refreshTimer = Nothing

			If refreshPropertyGridNextIdle Then
				RefreshPropertyGrid()
			End If
		End Sub

		Public Sub RefreshPropertyGrid()
				refreshPropertyGridNextIdle = False
				If style IsNot Nothing Then
					RemoveHandler style.Changed, AddressOf GridStyleInfoChanged
				End If

				grid = CType(splitterControl1.ActivePane, GridControlBase)
				style = grid.Model.GetCombinedStyle(range)
				If style IsNot Nothing Then
					propertyGrid1.SelectedObject = style
					AddHandler style.Changed, AddressOf GridStyleInfoChanged
				Else
					range = GridRangeInfo.Empty
				End If
		End Sub

		Public Sub ShowPropertyGridItem(ByVal category As String, ByVal label As String)
			RefreshPropertyGrid()
			Dim gi As GridItem = propertyGrid1.SelectedGridItem
			Do While gi IsNot Nothing AndAlso gi.GridItemType <> GridItemType.Root
				gi = gi.Parent
			Loop

			If gi IsNot Nothing Then
				' Categories
				Dim categories As GridItemCollection = gi.GridItems
				Dim sliderCategory As GridItem = categories(category)
				If sliderCategory IsNot Nothing Then
					Dim items As GridItemCollection = sliderCategory.GridItems
					Dim item As GridItem
					If label = "" Then
						item = items(Math.Min(10, items.Count-1))
					Else
						item = items(label)
					End If
					item.Select()
					If item.Expandable Then
						propertyGrid1.ExpandAllGridItems()
						items = item.GridItems
						items(Math.Min(10, items.Count-1)).Select()
					End If
				End If
			End If
			RefreshPropertyGrid()
		End Sub

		Private Sub GridStyleInfoChanged(ByVal sender As Object, ByVal e As StyleChangedEventArgs)
			If (Not refreshPropertyGridNextIdle) AndAlso (Not range.IsEmpty) AndAlso grid IsNot Nothing AndAlso style IsNot Nothing Then
				grid.Model.ChangeCells(range, style, StyleModifyType.Changes)
			End If
		End Sub

		Private Sub splitter1_SplitterMoved(ByVal sender As Object, ByVal e As System.Windows.Forms.SplitterEventArgs)

		End Sub

		Private Sub panel1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles panel1.Paint

		End Sub

		Private Sub splitter1_SplitterMoved_1(ByVal sender As Object, ByVal e As SplitterEventArgs) Handles splitter1.SplitterMoved

		End Sub

	End Class


End Namespace
