Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2008"
'
'  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
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
Imports ComboboxCells

Namespace GridSample
	Public Class Form1
		Inherits MetroForm
		Friend WithEvents gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Friend propertyGrid1 As System.Windows.Forms.PropertyGrid
		Friend WithEvents splitterControl1 As Syncfusion.Windows.Forms.SplitterControl
		Friend dataSet11 As DataSet1
		Private WithEvents CheckBoxMouseEnable As System.Windows.Forms.CheckBox
		Private components As IContainer
		Private WithEvents CheckBoxCurrentCellEnable As System.Windows.Forms.CheckBox
		Private contextMenu1 As System.Windows.Forms.ContextMenu
		Private WithEvents menuItem1 As System.Windows.Forms.MenuItem
		Private panel1 As System.Windows.Forms.Panel
		Private panel2 As System.Windows.Forms.Panel
		Private splitter1 As System.Windows.Forms.Splitter
		Friend WithEvents button1 As ButtonAdv
		Private WithEvents eventTracer As EventTracer
		Private WithEvents CheckBoxGridEnable As CheckBox
		Private groupBox1 As GroupBox
		Private tracer As CurrentCellEventTracer

		Public Sub New()
			dataSet11 = New DataSet1()
			eventTracer = New EventTracer()
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


			tracer = New CurrentCellEventTracer(Me.splitterControl1, Me.eventTracer)
			CheckBoxMouseEnable.Checked = tracer.DisplayMouseMessages
			CheckBoxCurrentCellEnable.Checked = tracer.Enabled

			Dim heading1 As GridStyleInfo = gridControl1.BaseStylesMap("Heading 1").StyleInfo
			heading1.TextColor = Color.Blue 'Color.FromArgb( 0xde, 0x64, 0x13 );
			heading1.Font.Facename = "Segoe UI"
			heading1.Font.Size = 12
			heading1.Font.Bold = False

			Dim heading2 As GridStyleInfo = gridControl1.BaseStylesMap("Heading 2").StyleInfo
			heading2.TextColor = Color.Orange
			heading2.Font.Size = 12
			heading2.Font.Bold = True

			Me.eventTracer.ContextMenu = Me.contextMenu1

			Me.propertyGrid1.CausesValidation = False
			Me.splitter1.CausesValidation = False
			Me.panel1.CausesValidation = False
			Me.panel2.CausesValidation = False



			' read the data from a local XML file
			ReadXml(Me.dataSet11, "Common\Data\GDBDdata.XML")

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
			Dim gridBaseStyle1 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle2 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle3 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle4 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridCellInfo1 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
			Me.splitterControl1 = New Syncfusion.Windows.Forms.SplitterControl()
			Me.CheckBoxMouseEnable = New System.Windows.Forms.CheckBox()
			Me.CheckBoxCurrentCellEnable = New System.Windows.Forms.CheckBox()
			Me.contextMenu1 = New System.Windows.Forms.ContextMenu()
			Me.menuItem1 = New System.Windows.Forms.MenuItem()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.CheckBoxGridEnable = New System.Windows.Forms.CheckBox()
			Me.splitter1 = New System.Windows.Forms.Splitter()
			Me.eventTracer = New ComboboxCells.EventTracer()
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
			gridBaseStyle1.Name = "Row Header"
			gridBaseStyle1.StyleInfo.BaseStyle = "Header"
			gridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
			gridBaseStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb((CInt(Fix((CByte(203))))), (CInt(Fix((CByte(199))))), (CInt(Fix((CByte(184)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(216)))))))
			gridBaseStyle2.Name = "Column Header"
			gridBaseStyle2.StyleInfo.BaseStyle = "Header"
			gridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridBaseStyle3.Name = "Standard"
			gridBaseStyle3.StyleInfo.Font.Facename = "Segoe UI"
			gridBaseStyle3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
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
			Me.gridControl1.ColCount = 12
			Me.gridControl1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() { New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)})
			Me.gridControl1.DefaultColWidth = 110
			Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
			Me.gridControl1.DefaultRowHeight = 20
			Me.gridControl1.FillSplitterPane = True
			Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.5F)
			Me.gridControl1.ForeColor = System.Drawing.Color.MidnightBlue
			gridCellInfo1.Col = -1
			gridCellInfo1.Row = -1
			gridCellInfo1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridCellInfo1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridCellInfo1.StyleInfo.Font.Bold = False
			gridCellInfo1.StyleInfo.Font.Facename = "Segoe UI"
			gridCellInfo1.StyleInfo.Font.Italic = False
			gridCellInfo1.StyleInfo.Font.Size = 8.5F
			gridCellInfo1.StyleInfo.Font.Strikeout = False
			gridCellInfo1.StyleInfo.Font.Underline = False
			gridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridCellInfo1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridCellInfo1.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			Me.gridControl1.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() { gridCellInfo1})
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
			Me.gridControl1.Size = New System.Drawing.Size(681, 255)
			Me.gridControl1.SmartSizeBox = False
			Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.VerticalThumbTrack = True
'			Me.gridControl1.SelectionChanged += New Syncfusion.Windows.Forms.Grid.GridSelectionChangedEventHandler(Me.grid_SelectionChanged)
'			Me.gridControl1.CurrentCellMoved += New Syncfusion.Windows.Forms.Grid.GridCurrentCellMovedEventHandler(Me.grid_CurrentCellMoved)
			' 
			' propertyGrid1
			' 
			Me.propertyGrid1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.propertyGrid1.BackColor = System.Drawing.Color.White
			Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
			Me.propertyGrid1.LineColor = System.Drawing.Color.White
			Me.propertyGrid1.Location = New System.Drawing.Point(748, 12)
			Me.propertyGrid1.Name = "propertyGrid1"
			Me.propertyGrid1.Size = New System.Drawing.Size(250, 272)
			Me.propertyGrid1.TabIndex = 2
			' 
			' splitterControl1
			' 
			Me.splitterControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.splitterControl1.BackColor = System.Drawing.Color.White
			Me.splitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.splitterControl1.Controls.Add(Me.gridControl1)
			Me.splitterControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.splitterControl1.Location = New System.Drawing.Point(26, 12)
			Me.splitterControl1.Name = "splitterControl1"
			Me.splitterControl1.Size = New System.Drawing.Size(698, 272)
			Me.splitterControl1.SplitBars = (CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars))
			Me.splitterControl1.TabIndex = 6
			Me.splitterControl1.ThemesEnabled = True
'			Me.splitterControl1.PaneClosing += New Syncfusion.Windows.Forms.SplitterPaneEventHandler(Me.splitterControl1_PaneClosing)
'			Me.splitterControl1.PaneCreated += New Syncfusion.Windows.Forms.SplitterPaneEventHandler(Me.splitterControl1_PaneCreated)
'			Me.splitterControl1.Click += New System.EventHandler(Me.splitterControl1_Click)
			' 
			' CheckBoxMouseEnable
			' 
			Me.CheckBoxMouseEnable.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.CheckBoxMouseEnable.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.CheckBoxMouseEnable.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.CheckBoxMouseEnable.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))))
			Me.CheckBoxMouseEnable.Location = New System.Drawing.Point(43, 58)
			Me.CheckBoxMouseEnable.Name = "CheckBoxMouseEnable"
			Me.CheckBoxMouseEnable.Size = New System.Drawing.Size(182, 26)
			Me.CheckBoxMouseEnable.TabIndex = 7
			Me.CheckBoxMouseEnable.Text = "Enable Mouse Events."
'			Me.CheckBoxMouseEnable.CheckedChanged += New System.EventHandler(Me.checkBoxMouseMessage_CheckedChanged)
			' 
			' CheckBoxCurrentCellEnable
			' 
			Me.CheckBoxCurrentCellEnable.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.CheckBoxCurrentCellEnable.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.CheckBoxCurrentCellEnable.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.CheckBoxCurrentCellEnable.ForeColor = System.Drawing.Color.Black
			Me.CheckBoxCurrentCellEnable.Location = New System.Drawing.Point(43, 31)
			Me.CheckBoxCurrentCellEnable.Name = "CheckBoxCurrentCellEnable"
			Me.CheckBoxCurrentCellEnable.Size = New System.Drawing.Size(182, 21)
			Me.CheckBoxCurrentCellEnable.TabIndex = 7
			Me.CheckBoxCurrentCellEnable.Text = "Enable CurrentCell Events."
'			Me.CheckBoxCurrentCellEnable.CheckedChanged += New System.EventHandler(Me.checkBoxEnableTracing_CheckedChanged)
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
			Me.panel1.Controls.Add(Me.splitterControl1)
			Me.panel1.Controls.Add(Me.propertyGrid1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(1020, 290)
			Me.panel1.TabIndex = 8
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.groupBox1)
			Me.panel2.Controls.Add(Me.eventTracer)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel2.Location = New System.Drawing.Point(0, 290)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(1020, 206)
			Me.panel2.TabIndex = 9
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.button1)
			Me.groupBox1.Controls.Add(Me.CheckBoxGridEnable)
			Me.groupBox1.Controls.Add(Me.CheckBoxCurrentCellEnable)
			Me.groupBox1.Controls.Add(Me.CheckBoxMouseEnable)
			Me.groupBox1.Location = New System.Drawing.Point(748, 13)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(250, 177)
			Me.groupBox1.TabIndex = 11
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Event Trace Options"
			' 
			' button1
			' 
			Me.button1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.button1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.button1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button1.ForeColor = System.Drawing.Color.White
			Me.button1.Location = New System.Drawing.Point(43, 135)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(182, 28)
			Me.button1.TabIndex = 8
			Me.button1.Text = "Clear Tracer"
			Me.button1.UseVisualStyle = True
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' CheckBoxGridEnable
			' 
			Me.CheckBoxGridEnable.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.CheckBoxGridEnable.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.CheckBoxGridEnable.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.CheckBoxGridEnable.ForeColor = System.Drawing.Color.Black
			Me.CheckBoxGridEnable.Location = New System.Drawing.Point(43, 90)
			Me.CheckBoxGridEnable.Name = "CheckBoxGridEnable"
			Me.CheckBoxGridEnable.Size = New System.Drawing.Size(182, 21)
			Me.CheckBoxGridEnable.TabIndex = 9
			Me.CheckBoxGridEnable.Text = "Enable Grid Events."
'			Me.CheckBoxGridEnable.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged)
			' 
			' splitter1
			' 
			Me.splitter1.Dock = System.Windows.Forms.DockStyle.Top
			Me.splitter1.Location = New System.Drawing.Point(0, 290)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(1020, 10)
			Me.splitter1.TabIndex = 10
			Me.splitter1.TabStop = False
			' 
			' eventTracer
			' 
			Me.eventTracer.BackColor = System.Drawing.Color.White
			Me.eventTracer.Enabled = False
			Me.eventTracer.Location = New System.Drawing.Point(26, 18)
			Me.eventTracer.Name = "eventTracer"
			Me.eventTracer.Size = New System.Drawing.Size(698, 183)
			Me.eventTracer.TabIndex = 9
'			Me.eventTracer.Load += New System.EventHandler(Me.eventTracer_Load)
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
			Me.BackColor = System.Drawing.Color.White
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(1020, 496)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.panel1)
			Me.DropShadow = True
			Me.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Grid Control Event Logger Demo"
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
            Dim ico As New System.Drawing.Icon(GetIconFile("Icon\sfgrid.ico"))
			Me.Icon = ico
			Me.gridControl1.DefaultRowHeight = 18
			Me.gridControl1.DefaultColWidth = 70

			Me.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid
			Me.gridControl1.ColWidths(1) = 150
			Me.gridControl1.ColWidths(2) = 150

			eventTracer.output.ControllerOptions = GridControllerOptions.All And ((Not GridControllerOptions.OleDataSource))

			eventTracer.output.ResetVolatileData()
			eventTracer.output.ColWidths(1) = 200
			eventTracer.output.ColWidths(2) = 1000
			eventTracer.output.GridVisualStyles = GridVisualStyles.Metro
			eventTracer.output.DefaultGridBorderStyle = GridBorderStyle.None
			eventTracer.output.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
			Dim style As GridStyleInfo = eventTracer.output.BaseStylesMap("Header").StyleInfo
			style.TextColor = Color.MidnightBlue
			style.Font.Facename = "Verdana"

			eventTracer.output.RowHeights(0) = 0
			eventTracer.output.ColWidths(0) = 0
			eventTracer.output.RowCount = 0
			eventTracer.output.ColCount = 2
			eventTracer.output.ListBoxSelectionMode = SelectionMode.One
			AddHandler eventTracer.output.QueryCellInfo, AddressOf output_QueryCellInfo
			AddHandler gridControl1.QueryRowHeight, AddressOf gridControl1_QueryRowHeight
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


		Private Sub gridControl1_QueryRowHeight(ByVal sender As Object, ByVal e As GridRowColSizeEventArgs)
			If e.Index > 0 Then
				e.Size = 25
				e.Handled = True
			End If
		End Sub

		Private Sub output_QueryCellInfo(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
			e.Style.CellType = "Static"
		End Sub

		Private Sub checkBoxMouseMessage_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBoxMouseEnable.CheckedChanged
			'tracer.DisplayMouseMessages = checkBoxMouseMessage.Checked;
			If CheckBoxMouseEnable.Checked Then
				eventTracer.mouseCheck = "Mouse"
			Else
				eventTracer.mouseCheck = ""
			End If
		End Sub

		Private Sub checkBoxEnableTracing_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBoxCurrentCellEnable.CheckedChanged
			'eventTracer.Enabled = this.enableCurrentCell.Checked;
			If CheckBoxCurrentCellEnable.Checked Then
				eventTracer.cellCheck = "Cell"
			Else
				eventTracer.cellCheck = ""
			End If
		End Sub

		Private Sub menuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem1.Click
			Me.eventTracer.output.Clear(True)
			Me.eventTracer.output.RowCount = 0
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

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			eventTracer.clear()
		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBoxGridEnable.CheckedChanged
			If CheckBoxGridEnable.Checked Then
				eventTracer.gridCheck = "Grid"
			Else
				eventTracer.gridCheck = ""
			End If
		End Sub

		Private Sub eventTracer_Load(ByVal sender As Object, ByVal e As EventArgs) Handles eventTracer.Load

		End Sub

		Private Sub splitterControl1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles splitterControl1.Click

		End Sub
	End Class
End Namespace
