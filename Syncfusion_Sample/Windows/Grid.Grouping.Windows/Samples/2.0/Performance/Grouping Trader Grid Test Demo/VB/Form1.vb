#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.IO
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms

Namespace TraderGridTest

	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
        Private components As System.ComponentModel.IContainer
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Friend timer As Timer
		Private table As DataTable
		Private gridGroupingControl1 As GridGroupingControl
		Private rand As System.Random
		Private m_numUpdatesPerTick As Integer = 10
		Private ds As DataSet

		Private toggleInsertRemove As Integer = 10 ' toggle between inserting and removing after n inserts/n removals.
		Private insertRemoveModulus As Integer = 5 ' frequency of insert / remove : every n timer ticks
		Private initialRowCount As Integer = 100
		Private panel1 As System.Windows.Forms.Panel
		Private label1 As System.Windows.Forms.Label
        Private WithEvents checkBoxFilter As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private textBoxFilter As Syncfusion.Windows.Forms.Tools.TextBoxExt
        Private WithEvents checkBoxGrouping As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents buttonApplyFilter As Syncfusion.Windows.Forms.ButtonAdv
		Private labelTimerInterval As System.Windows.Forms.Label
		Private WithEvents trackBarTimer As System.Windows.Forms.TrackBar
        Private WithEvents checkBoxSorting As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents checkBoxColor As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private label4 As System.Windows.Forms.Label
		Private WithEvents trackBarBlinkFrequency As System.Windows.Forms.TrackBar
		Private labelBlinkTime As System.Windows.Forms.Label
		Private panel2 As Panel
		Private panel3 As Panel
		Private propertyGrid1 As PropertyGrid

        ' Alter this integer to change the type of test
        Private insertRemoveCount As Integer = 2 ' use 1 if you want to check out inserting and removing rows

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            ' Form settings
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

			' Setup the grid
			gridGroupingControl1 = New GridGroupingControl()
			gridGroupingControl1.VerticalThumbTrack = True
			gridGroupingControl1.HorizontalThumbTrack = True
			gridGroupingControl1.TableOptions.VerticalPixelScroll = True
			gridGroupingControl1.Dock = DockStyle.Fill
			Me.panel2.Controls.Add(gridGroupingControl1)

			gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended

			OptimizeGrid()

			gridGroupingControl1.AllowSwapDataViewWithDataTableList = False ' we want to use "InsertAt" logice with.NET 2.0...

			' Setup datatable with random data
			InitializeDataTable()
			gridGroupingControl1.DataSource = table

			' Highlight up and downticks
			gridGroupingControl1.BlinkTime = 700 ' in ms
			For i As Integer = 1 To 20
				gridGroupingControl1.TableDescriptor.Columns(i.ToString()).AllowBlink = True
			Next i

			gridGroupingControl1.Engine.AddBaseStylesForBlinking()


			gridGroupingControl1.BaseStyles(GridEngine.BlinkIncreased).StyleInfo.TextColor = Color.White


			gridGroupingControl1.BaseStyles(GridEngine.BlinkReduced).StyleInfo.TextColor = Color.White

			gridGroupingControl1.Engine.BaseStyles.Add("CustomStyle")

			gridGroupingControl1.BaseStyles("CustomStyle").StyleInfo.TextColor = Color.Black
			gridGroupingControl1.BaseStyles("CustomStyle").StyleInfo.BackColor = Color.White

			AddHandler gridGroupingControl1.TableControlPrepareViewStyleInfo, AddressOf gridGroupingControl1_TableControlPrepareViewStyleInfo

			gridGroupingControl1.TableDescriptor.Columns(0).MaxLength = 8
			gridGroupingControl1.TableDescriptor.Columns(5).MaxLength = 6
			gridGroupingControl1.TableDescriptor.Columns(9).MaxLength = 5
			gridGroupingControl1.TableDescriptor.Columns(14).MaxLength = 6
			gridGroupingControl1.TableDescriptor.Columns("1").MaxLength = 8

			' Sort by column "1"
			gridGroupingControl1.TableDescriptor.SortedColumns.Add("1")

			'Optional: Filter records
			'gridGroupingControl1.TableDescriptor.RecordFilters.Add("[2] > 88");

			Console.WriteLine(gridGroupingControl1.TableDescriptor.Columns("1").MaxLength)

			Me.textBoxFilter.Text = "[2] > 88"
			AddHandler gridGroupingControl1.PropertyChanged, AddressOf gridGroupingControl1_PropertyChanged
			Me.gridGroupingControl1.ShowGroupDropArea = True



			' Timer
			SetupTimer()
			Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
			Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana"
			gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue
			Me.BackColor = Color.White
			Me.propertyGrid1.BackColor=Color.White
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


		Private Sub gridGroupingControl1_TableControlPrepareViewStyleInfo(ByVal sender As Object, ByVal e As GridTableControlPrepareViewStyleInfoEventArgs)
			Dim style As GridTableCellStyleInfo = CType(e.Inner.Style, GridTableCellStyleInfo)
			Dim bs As BlinkState = gridGroupingControl1.GetBlinkState(style.TableCellIdentity)

			If bs <> BlinkState.None Then
				If bs = BlinkState.NewRecord Then
					e.Inner.Style.BaseStyle = "CustomStyle"

				End If
			End If
		End Sub

		Private Sub OptimizeGrid()
			' Optimize memory footprint, drawing and ListChanged performance

			' Use less memory for internal binary tree structures
			gridGroupingControl1.CounterLogic = EngineCounters.YAmount
			gridGroupingControl1.AllowedOptimizations = EngineOptimizations.DisableCounters Or EngineOptimizations.RecordsAsDisplayElements

			' Affected settings by UseDefaultsForFasterDrawing are: InvalidateAllWhenListChanged, 
			' TableOptions.ColumnsMaxLengthStrategy, TableOptions.GridLineBorder, 
			' TableOptions.DrawTextWithGdiInterop, TableOptions.VerticalPixelScroll,
			' Appearance.AnyRecordFieldCell.WrapText and Appearance.AnyRecordFieldCell.Trimming.
			gridGroupingControl1.UseDefaultsForFasterDrawing = True

			' Instruct grouping control not to access datasource through
			' CurrencyManager API and instead access list diretly. When set to
			' false you wil however loose support for built-in CurrencyManager 
			' synchronization, so only do this if you don't need CurrencyManager synchronization.
			gridGroupingControl1.BindToCurrencyManager = False

			' Update display with changes, optionally use ScrollWindow for insert and removing rows.
			'gridGroupingControl1.UpdateDisplayFrequency = 0;  // only manual updates (when you call grid.Update)
			gridGroupingControl1.UpdateDisplayFrequency = 1 ' immediate update after each ListChanged.
			'gridGroupingControl1.UpdateDisplayFrequency = 100;  // update every 100 ms.
			gridGroupingControl1.InsertRemoveBehavior = GridListChangedInsertRemoveBehavior.ScrollWithImmediateUpdate ' Scrollwindow will cause immediate update.
			gridGroupingControl1.SortPositionChangedBehavior = GridListChangedInsertRemoveBehavior.ScrollWithImmediateUpdate ' Scrollwindow will cause immediate update.

			' Don't forget this property. If it is true then InsertRemoveBehavior and SortPositionChangedBehavior
			' properties would have no effect at all. Its default value is false if UseDefaultsForFasterDrawing = true
			' has been set, but setting it explictly makes sure this is false.
			gridGroupingControl1.InvalidateAllWhenListChanged = False
		End Sub

		Private Sub SetupTimer()
			timer = New Timer()
			AddHandler timer.Tick, AddressOf timer_Tick
			timer.Interval = 100
			timer.Start()

			Me.UpdateDialog()

			Me.gridGroupingControl1.Focus()
		End Sub

		Private Sub InitializeDataTable()
			ds = New DataSet()
			table = New DataTable("RandomData")
			table.Columns.Add("Product", GetType(String))
			table.Columns.Add("1", GetType(System.Double))
			table.Columns.Add("2", GetType(System.Double))
			table.Columns.Add("3", GetType(System.Double))
			table.Columns.Add("4", GetType(System.Double))
			table.Columns.Add("5", GetType(System.Double))
			table.Columns.Add("6", GetType(System.Double))
			table.Columns.Add("7", GetType(System.Double))
			table.Columns.Add("8", GetType(System.Double))
			table.Columns.Add("9", GetType(System.Double))
			table.Columns.Add("10", GetType(System.Double))
			table.Columns.Add("11", GetType(System.Double))
			table.Columns.Add("12", GetType(System.Double))
			table.Columns.Add("13", GetType(System.Double))
			table.Columns.Add("14", GetType(System.Double))
			table.Columns.Add("15", GetType(System.Double))
			table.Columns.Add("16", GetType(System.Double))
			table.Columns.Add("17", GetType(System.Double))
			table.Columns.Add("18", GetType(System.Double))
			table.Columns.Add("19", GetType(System.Double))
			table.Columns.Add("20", GetType(System.Double))
			ds.Tables.Add(table)

			rand = New Random(0)

			For i As Integer = 0 To initialRowCount - 1
				Dim [next] As Integer = rand.Next(100)
				table.Rows.Add(New Object(){"P" & i.ToString("00000"), [next]+1,[next]+2, [next]+3,[next]+4,[next]+5,[next]+6, [next]+7,[next]+8,[next]+9,[next]+10, [next]+11,[next]+12,[next]+13,[next]+14, [next]+15,[next]+16,[next]+17, [next]+18,[next]+19,[next]+20})
			Next i

		End Sub

		Private Sub gridGroupingControl1_QueryCellStyleInfo(ByVal sender As Object, ByVal e As GridTableCellStyleInfoEventArgs)
			Dim style As GridTableCellStyleInfo = CType(e.Style, GridTableCellStyleInfo)
			If e.TableCellIdentity.TableCellType = GridTableCellType.RecordFieldCell OrElse e.TableCellIdentity.TableCellType = GridTableCellType.AlternateRecordFieldCell Then


				If e.TableCellIdentity.Column.FieldDescriptor.FieldPropertyType Is GetType(String) Then
					Return
				End If


				' Get the value from column "1" and color all cells in record based
				' on this value.
				Dim r As Record = e.Style.TableCellIdentity.DisplayElement.GetRecord()
				Dim value As Object = r.GetValue("1")
				Dim v As Integer = Convert.ToInt32(value) Mod colors.Length
				e.Style.BackColor = colors(v)

			End If
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
            Me.panel1 = New System.Windows.Forms.Panel
            Me.buttonApplyFilter = New Syncfusion.Windows.Forms.ButtonAdv
            Me.checkBoxGrouping = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.textBoxFilter = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.checkBoxFilter = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.labelTimerInterval = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.trackBarTimer = New System.Windows.Forms.TrackBar
            Me.checkBoxSorting = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxColor = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.label4 = New System.Windows.Forms.Label
            Me.trackBarBlinkFrequency = New System.Windows.Forms.TrackBar
            Me.labelBlinkTime = New System.Windows.Forms.Label
            Me.panel2 = New System.Windows.Forms.Panel
            Me.panel3 = New System.Windows.Forms.Panel
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
            Me.panel1.SuspendLayout()
            CType(Me.checkBoxGrouping, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textBoxFilter, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxFilter, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarTimer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxSorting, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxColor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBarBlinkFrequency, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.buttonApplyFilter)
            Me.panel1.Controls.Add(Me.checkBoxGrouping)
            Me.panel1.Controls.Add(Me.textBoxFilter)
            Me.panel1.Controls.Add(Me.checkBoxFilter)
            Me.panel1.Controls.Add(Me.labelTimerInterval)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.trackBarTimer)
            Me.panel1.Controls.Add(Me.checkBoxSorting)
            Me.panel1.Controls.Add(Me.checkBoxColor)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.trackBarBlinkFrequency)
            Me.panel1.Controls.Add(Me.labelBlinkTime)
            Me.panel1.Location = New System.Drawing.Point(34, 460)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(754, 100)
            Me.panel1.TabIndex = 0
            '
            'buttonApplyFilter
            '
            Me.buttonApplyFilter.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.buttonApplyFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.buttonApplyFilter.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.buttonApplyFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonApplyFilter.ForeColor = System.Drawing.Color.White
            Me.buttonApplyFilter.Location = New System.Drawing.Point(524, 35)
            Me.buttonApplyFilter.Name = "buttonApplyFilter"
            Me.buttonApplyFilter.Size = New System.Drawing.Size(80, 24)
            Me.buttonApplyFilter.TabIndex = 8
            Me.buttonApplyFilter.Text = "Apply"
            Me.buttonApplyFilter.UseVisualStyle = True
            '
            'checkBoxGrouping
            '
            Me.checkBoxGrouping.DrawFocusRectangle = False
            Me.checkBoxGrouping.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxGrouping.Location = New System.Drawing.Point(418, 65)
            Me.checkBoxGrouping.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxGrouping.Name = "checkBoxGrouping"
            Me.checkBoxGrouping.Size = New System.Drawing.Size(114, 24)
            Me.checkBoxGrouping.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxGrouping.TabIndex = 7
            Me.checkBoxGrouping.Text = "Enable Grouping"
            Me.checkBoxGrouping.ThemesEnabled = False
            '
            'textBoxFilter
            '
            Me.textBoxFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.textBoxFilter.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.textBoxFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBoxFilter.ForeColor = System.Drawing.Color.Gray
            Me.textBoxFilter.Location = New System.Drawing.Point(524, 8)
            Me.textBoxFilter.Name = "textBoxFilter"
            Me.textBoxFilter.Size = New System.Drawing.Size(216, 20)
            Me.textBoxFilter.TabIndex = 6
            Me.textBoxFilter.Text = "textBox1"
            '
            'checkBoxFilter
            '
            Me.checkBoxFilter.DrawFocusRectangle = False
            Me.checkBoxFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxFilter.Location = New System.Drawing.Point(418, 8)
            Me.checkBoxFilter.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxFilter.Name = "checkBoxFilter"
            Me.checkBoxFilter.Size = New System.Drawing.Size(100, 24)
            Me.checkBoxFilter.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxFilter.TabIndex = 5
            Me.checkBoxFilter.Text = "Enable Filter"
            Me.checkBoxFilter.ThemesEnabled = False
            '
            'labelTimerInterval
            '
            Me.labelTimerInterval.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelTimerInterval.ForeColor = System.Drawing.Color.DimGray
            Me.labelTimerInterval.Location = New System.Drawing.Point(322, 8)
            Me.labelTimerInterval.Name = "labelTimerInterval"
            Me.labelTimerInterval.Size = New System.Drawing.Size(112, 40)
            Me.labelTimerInterval.TabIndex = 4
            Me.labelTimerInterval.Text = "label2"
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.DimGray
            Me.label1.Location = New System.Drawing.Point(8, 6)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(109, 28)
            Me.label1.TabIndex = 3
            Me.label1.Text = "Timer Frequency"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'trackBarTimer
            '
            Me.trackBarTimer.Location = New System.Drawing.Point(124, 8)
            Me.trackBarTimer.Name = "trackBarTimer"
            Me.trackBarTimer.Size = New System.Drawing.Size(184, 45)
            Me.trackBarTimer.TabIndex = 2
            '
            'checkBoxSorting
            '
            Me.checkBoxSorting.DrawFocusRectangle = False
            Me.checkBoxSorting.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxSorting.Location = New System.Drawing.Point(536, 65)
            Me.checkBoxSorting.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxSorting.Name = "checkBoxSorting"
            Me.checkBoxSorting.Size = New System.Drawing.Size(102, 24)
            Me.checkBoxSorting.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxSorting.TabIndex = 7
            Me.checkBoxSorting.Text = "Enable Sorting"
            Me.checkBoxSorting.ThemesEnabled = False
            '
            'checkBoxColor
            '
            Me.checkBoxColor.DrawFocusRectangle = False
            Me.checkBoxColor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxColor.Location = New System.Drawing.Point(640, 64)
            Me.checkBoxColor.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxColor.Name = "checkBoxColor"
            Me.checkBoxColor.Size = New System.Drawing.Size(109, 24)
            Me.checkBoxColor.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxColor.TabIndex = 7
            Me.checkBoxColor.Text = "Enable Coloring"
            Me.checkBoxColor.ThemesEnabled = False
            '
            'label4
            '
            Me.label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.Color.DimGray
            Me.label4.Location = New System.Drawing.Point(8, 58)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(102, 31)
            Me.label4.TabIndex = 3
            Me.label4.Text = "Blink Frequency"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'trackBarBlinkFrequency
            '
            Me.trackBarBlinkFrequency.Location = New System.Drawing.Point(124, 63)
            Me.trackBarBlinkFrequency.Maximum = 20
            Me.trackBarBlinkFrequency.Name = "trackBarBlinkFrequency"
            Me.trackBarBlinkFrequency.Size = New System.Drawing.Size(184, 45)
            Me.trackBarBlinkFrequency.SmallChange = 2
            Me.trackBarBlinkFrequency.TabIndex = 2
            Me.trackBarBlinkFrequency.TickFrequency = 2
            '
            'labelBlinkTime
            '
            Me.labelBlinkTime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelBlinkTime.ForeColor = System.Drawing.Color.DimGray
            Me.labelBlinkTime.Location = New System.Drawing.Point(321, 62)
            Me.labelBlinkTime.Name = "labelBlinkTime"
            Me.labelBlinkTime.Size = New System.Drawing.Size(112, 40)
            Me.labelBlinkTime.TabIndex = 4
            Me.labelBlinkTime.Text = "Disabled."
            '
            'panel2
            '
            Me.panel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panel2.Location = New System.Drawing.Point(34, 26)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(499, 400)
            Me.panel2.TabIndex = 1
            '
            'panel3
            '
            Me.panel3.Controls.Add(Me.propertyGrid1)
            Me.panel3.Location = New System.Drawing.Point(552, 26)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(243, 402)
            Me.panel3.TabIndex = 0
            '
            'propertyGrid1
            '
            Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyGrid1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
            Me.propertyGrid1.LineColor = System.Drawing.Color.White
            Me.propertyGrid1.Location = New System.Drawing.Point(0, 0)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.Size = New System.Drawing.Size(243, 402)
            Me.propertyGrid1.TabIndex = 0
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(828, 592)
            Me.Controls.Add(Me.panel3)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.DropShadow = True
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Grouping Trader Grid Test Demo"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.checkBoxGrouping, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textBoxFilter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxFilter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarTimer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxSorting, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxColor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBarBlinkFrequency, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel3.ResumeLayout(False)
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

		Private icount As Integer = 0
		Private timerCount As Integer = 0
		Private ti As Integer = 0
		Private shouldInsert As Boolean = False
		Private waitKey As Boolean = False

		Private Sub WaitForKey()
			skipTimer = True
			RemoveHandler timer.Tick, AddressOf timer_Tick
			timer.Enabled = False
			Application.DoEvents()
			If Control.ModifierKeys = Keys.Shift Then
				waitKey = True
			End If

			If waitKey Then
				Do While Control.ModifierKeys = Keys.None
					System.Threading.Thread.Sleep(5)
					Application.DoEvents()
				Loop
			End If
			If Not Visible Then
				Application.Exit()
			End If
			AddHandler timer.Tick, AddressOf timer_Tick
			timer.Enabled = True
			skipTimer = False
		End Sub

		Private skipTimer As Boolean = False

		Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
			If skipTimer Then
				Return
			End If

			timerCount += 1

			Try
				For i As Integer = 0 To m_numUpdatesPerTick - 1
				  '  Application.DoEvents();

					Dim recNum As Integer = rand.Next(table.Rows.Count - 1)
					Dim rowNum As Integer = recNum + 1
					Dim col As Integer = rand.Next(16) + 1
					Dim colNum As Integer = col + 1
					Dim drow As DataRow = table.Rows(recNum)
					If Not(TypeOf drow(col) Is DBNull) Then
						drow(col) = CInt(Fix(Convert.ToDouble(drow(col)) * (rand.Next(50) / 100.0f + 0.8))) ' rand.Next(100);
					End If

				Next i


				' Insert or remove a row
				If insertRemoveCount = 0 Then
					Return
				End If

				If toggleInsertRemove > 0 AndAlso (timerCount Mod insertRemoveModulus) = 0 Then
'INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
'ORIGINAL LINE: icount = ++icount Mod (toggleInsertRemove * 2);
					icount = ++icount Mod (toggleInsertRemove * 2)
					shouldInsert = icount < toggleInsertRemove

					If shouldInsert Then
						For ri As Integer = 0 To insertRemoveCount - 1
							Dim recNum As Integer = 5 ' rand.Next(table.Rows.Count - 1);

							Dim [next] As Integer = rand.Next(100)
							Dim row() As Object = {"H" & ti.ToString("00000"),[next]+1,[next]+2, [next]+3,[next]+4,[next]+5,[next]+6, [next]+7,[next]+8,[next]+9,[next]+10, [next]+11,[next]+12,[next]+13,[next]+14, [next]+15,[next]+16,[next]+17, [next]+18,[next]+19,[next]+20}
							ti += 1
							Dim drow As DataRow = table.NewRow()
							drow.ItemArray = row
							table.Rows.InsertAt(drow, recNum)
							'table.Rows.Add(drow);

						Next ri
					Else
						For ri As Integer = 0 To insertRemoveCount - 1
							Dim recNum As Integer = 5 'rand.Next(m_set.Count - 1);
							Dim rowNum As Integer = recNum + 1

							' Underlying data structure (this could be a datatable or whatever structure
							' you use behind a virtual grid).

							If table.Rows.Count > 10 Then
								table.Rows.RemoveAt(recNum)
							End If
						Next ri
					End If
				End If

			Finally
			End Try
		End Sub

		Private colors() As Color = { Color.FromArgb(&H85, &Hbf, &H75), Color.FromArgb(&Hb4, &He7, &Hf2), Color.FromArgb(&Hff, &Hbf, &H34), Color.FromArgb(&H82, &H2e, &H1b), Color.FromArgb(&H3a, &H86, &H7e) }

		Private Sub trackBarTimer_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBarTimer.Scroll
			If Me.trackBarTimer.Value = 0 Then
				timer.Enabled = False
				Me.labelTimerInterval.Text = String.Format("Timer disabled.")
			Else
				timer.Interval = 1000/(Me.trackBarTimer.Value*trackBarTimer.Value)
				timer.Enabled = True
				Me.labelTimerInterval.Text = String.Format("Every {0} milliseconds.", timer.Interval)
			End If
		End Sub

		#Region "Update dialog controls with changes to grid"
		Private Sub gridGroupingControl1_PropertyChanged(ByVal sender As Object, ByVal e As DescriptorPropertyChangedEventArgs)
			UpdateDialog()
		End Sub

		Private Sub UpdateDialog()
			If isUIChanged Then
				Return
			End If

			Try
				isPropertyChanged = True

				Dim td As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor

				Me.checkBoxFilter.Checked = td.RecordFilters.Count > 0
				If td.RecordFilters.Count > 0 Then
					Me.textBoxFilter.Text = td.RecordFilters(0).Expression
				End If

				Me.checkBoxGrouping.Checked = td.GroupedColumns.Count > 0
				Me.checkBoxSorting.Checked = td.SortedColumns.Count > 0

				Me.trackBarBlinkFrequency.Value = Me.gridGroupingControl1.BlinkTime\100
				If Me.gridGroupingControl1.BlinkTime = 0 Then
					Me.labelBlinkTime.Text = String.Format("Disabled.")
				Else
					Me.labelBlinkTime.Text = String.Format("{0} milliseconds.", gridGroupingControl1.BlinkTime)
				End If

				If timer IsNot Nothing Then
					If timer.Enabled Then
						trackBarTimer.Value = CInt(Fix(Math.Sqrt(1000 \ timer.Interval)))
					Else
						trackBarTimer.Value = 0
					End If

					trackBarTimer.TickFrequency = 1
					Me.labelTimerInterval.Text = String.Format("Every {0} milliseconds.", timer.Interval)
				End If
			Catch ex As Exception
				Trace.WriteLine(ex.ToString())
			Finally
				isPropertyChanged = False
			End Try
		End Sub

		Private isUIChanged As Boolean = False
		Private isPropertyChanged As Boolean = False
		#End Region
		#Region "Filter"
        Private Sub checkBoxFilter_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBoxFilter.CheckStateChanged
            ApplyFilter()
        End Sub

		Private Sub buttonApplyFilter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonApplyFilter.Click
			If Not checkBoxFilter.Checked Then
				checkBoxFilter.Checked = True
			Else
				ApplyFilter()
			End If
		End Sub

		Private Sub ApplyFilter()
			If isPropertyChanged Then
				Return
			End If

			isUIChanged = True

			Dim td As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor
			Try
				If Me.checkBoxFilter.Checked Then
					td.RecordFilters.Clear()
					td.RecordFilters.Add(Me.textBoxFilter.Text)
				Else
					td.RecordFilters.Clear()
				End If
				Me.gridGroupingControl1.Refresh()
			Catch ex As Exception
				Trace.WriteLine(ex.ToString())
			Finally
				isUIChanged = False
			End Try
		End Sub
		#End Region
		#Region "Grouping"
        Private Sub checkBoxGrouping_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBoxGrouping.CheckStateChanged
            If isPropertyChanged Then
                Return
            End If

            isUIChanged = True

            Dim td As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor
            Try
                If Me.checkBoxGrouping.Checked Then
                    td.GroupedColumns.Clear()
                    td.GroupedColumns.Add("1")
                    Me.gridGroupingControl1.Table.ExpandAllGroups()
                Else
                    td.GroupedColumns.Clear()
                End If
                Me.gridGroupingControl1.Refresh()
            Catch ex As Exception
                Trace.WriteLine(ex.ToString())
            Finally
                isUIChanged = False
            End Try
        End Sub
		#End Region
		#Region "BlinkFrequency"
		Private Sub trackBarBlinkFrequency_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBarBlinkFrequency.Scroll
			If isPropertyChanged Then
				Return
			End If

			isUIChanged = True

			Dim td As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor
			Try
				Me.gridGroupingControl1.BlinkTime = Me.trackBarBlinkFrequency.Value*100
				If Me.gridGroupingControl1.BlinkTime = 0 Then
					Me.labelBlinkTime.Text = String.Format("Disabled.")
				Else
					Me.labelBlinkTime.Text = String.Format("{0} milliseconds.", gridGroupingControl1.BlinkTime)
				End If
				Me.gridGroupingControl1.Refresh()
			Catch ex As Exception
				Trace.WriteLine(ex.ToString())
			Finally
				isUIChanged = False
			End Try
		End Sub
		#End Region
		#Region "Sorting"
        Private Sub checkBoxSorting_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBoxSorting.CheckStateChanged
            If isPropertyChanged Then
                Return
            End If

            isUIChanged = True

            Dim td As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor
            Try
                If Me.checkBoxSorting.Checked Then
                    td.SortedColumns.Clear()
                    td.SortedColumns.Add("1")
                    td.SortedColumns.Add("2")
                Else
                    td.SortedColumns.Clear()
                End If
                Me.gridGroupingControl1.Refresh()
            Catch ex As Exception
                Trace.WriteLine(ex.ToString())
            Finally
                isUIChanged = False
            End Try
        End Sub
		#End Region
		#Region "Coloring"
        Private Sub checkBoxColor_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBoxColor.CheckStateChanged
            isUIChanged = True

            Dim td As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor
            Try
                If Me.checkBoxColor.Checked Then
                    ' Callback for dynamically coloring cells
                    AddHandler gridGroupingControl1.QueryCellStyleInfo, AddressOf gridGroupingControl1_QueryCellStyleInfo

                    ' The color of these cells depends on value of cell "1". If engines ListChanged handler
                    ' detects a change to column "1" it should also automatically repaint the dependant columns
                    For i As Integer = 2 To 20
                        gridGroupingControl1.TableDescriptor.Fields(i.ToString()).ReferencedFields = "1"
                    Next i

                Else
                    RemoveHandler gridGroupingControl1.QueryCellStyleInfo, AddressOf gridGroupingControl1_QueryCellStyleInfo
                    gridGroupingControl1.TableDescriptor.Fields.LoadDefault()
                End If
                Me.gridGroupingControl1.Refresh()
            Catch ex As Exception
                Trace.WriteLine(ex.ToString())
            Finally
                isUIChanged = False
            End Try
        End Sub
		#End Region

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			' Timer
			SetupTimer()
			Me.DropShadow = True
            Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
            Me.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro
			Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
		End Sub
    End Class
End Namespace

