'#define TESTSPEED
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
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms

Imports Syncfusion.Diagnostics
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping

Imports Syncfusion.Grouping.ManualSummaries
Imports Syncfusion.Windows.Forms

Namespace ManualTotalSummaries
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		Private gridGroupingControl1 As SampleGridGroupingControl
		Private northwindDataSet1 As ManualTotalSummaries.DataSet1
		Private sqlSelectCommand2 As System.Data.SqlClient.SqlCommand
		Private sqlInsertCommand2 As System.Data.SqlClient.SqlCommand
		Private sqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
		Private sqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
		Private sqlDataAdapterOrders As System.Data.SqlClient.SqlDataAdapter
		Private sqlConnection2 As System.Data.SqlClient.SqlConnection
		Private panel1 As Panel
		Private panel2 As Panel
		Private propertyGrid1 As PropertyGrid
		Private startTimerButton As ButtonAdv

		Private components As System.ComponentModel.Container = Nothing

		Shared Sub New()
			GridEngineFactory.Factory = New ManualTotalSummaryEngineFactory()
		End Sub

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			' ----------- Plug in Optimization here -----------------
			' Use this code after the InitializeComponent call in your Form ctor
			' to plugin new optimized ListChanged event handler code

			Me.gridGroupingControl1.UpdateDisplayFrequency = 0 ' 0 if manual updates only from timer_tick

			Me.gridGroupingControl1.UseDefaultsForFasterDrawing = True
			Me.gridGroupingControl1.CounterLogic = EngineCounters.YAmount
			Me.gridGroupingControl1.AllowedOptimizations = EngineOptimizations.DisableCounters Or EngineOptimizations.RecordsAsDisplayElements
			Me.gridGroupingControl1.CacheRecordValues = False

			' Use InvalidateAll if many records change sort position during a short time 
			' Will also help to increase UpdateDisplayFrequency then!
			'this.gridGroupingControl1.InsertRemoveBehavior = GridListChangedInsertRemoveBehavior.InvalidateAll;
			'this.gridGroupingControl1.SortPositionChangedBehavior = GridListChangedInsertRemoveBehavior.InvalidateAll;

			' Use ScrollWithImmediateUpdate if ScrollWindow should be called to minimize painting when sort position of
			' limited number of records is changed (see also timer_tick method, the count setting)
			Me.gridGroupingControl1.InsertRemoveBehavior = GridListChangedInsertRemoveBehavior.ScrollWithImmediateUpdate
			Me.gridGroupingControl1.SortPositionChangedBehavior = GridListChangedInsertRemoveBehavior.ScrollWithImmediateUpdate

			'this.gridGroupingControl1.UseDefaultsForFasterDrawing = false;
			'this.gridGroupingControl1.InvalidateAllWhenListChanged = false;

			' Instruct grouping control not to access datasource through
			' CurrencyManager API and instead access list diretly. When set to
			' false you wil howver loose support for built-in CurrencyManager 
			' synchronization.
			Me.gridGroupingControl1.BindToCurrencyManager = False

'            if (typeof(object).Assembly.ImageRuntimeVersion.IndexOf("v1") == -1)
			If GetType(Object).Assembly.CodeBase.IndexOf("v1") = -1 Then
				' .NET 2.0 gets a bit slow when subscribing to ListChanged event on the 
				' DataTable.DefaultView. The following setting allows the engine to wrap 
				' datatable with a Syncfusion.Collections.DataTableList to work around 
				' this bottleneck. It avoids a DefaultView being created for the DataTable.
				' However, the moment you use a DefaultView yourself for the same DataTable, then
				' this optimization will have not much effect any more. So only use this
				' optimization if also no DefaultView is created for the DataTable outside the
				' grid.
				'
				' .NET 1.0 and 1.1 are just fine with using DataTable.DefaultView
				'
				Me.gridGroupingControl1.AllowSwapDataViewWithDataTableList = True
				Me.DropShadow = True
                Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro

			End If
			' ----------- End of Optimization code -----------------

			Try
				Dim ico As Icon = New Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try


			'//////////////////////////////////////////////////////////
			' DataSource
			'//////////////////////////////////////////////////////////

			InitializeDataSet()

			Me.gridGroupingControl1.DataSource = Me.northwindDataSet1.Orders

			'//////////////////////////////////////////////////////////

			Me.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.One

			Dim ordersDescriptor As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor
			Me.gridGroupingControl1.TableDescriptor.PrimaryKeyColumns.Clear()

			'//////////////////////////////////////////////////////////
			' Add Unbound field 'ShipVia_CompanyName'
			'//////////////////////////////////////////////////////////

			ordersDescriptor.UnboundFields.Add("ShipVia_CompanyName")

			' Inform the engine about depency on ShipVia of this field.
			ordersDescriptor.UnboundFields("ShipVia_CompanyName").ReferencedFields = "ShipVia"
			' When ReferencedFields is set and the engine detects changes to the ShipVia field
			' it will then automatically also mark the ShipVia_CompanyName field as changed. This
			' subsequently can affect sort order, group attachment etc.

			' Callback for calculation of ShipVia_CompanyName field.
			AddHandler ordersDescriptor.QueryValue, AddressOf ordersDescriptor_QueryValue

			' Hide the field.
			ordersDescriptor.VisibleColumns.Remove("ShipVia_CompanyName")

			' But use it for grouping.
			ordersDescriptor.GroupedColumns.Add("ShipVia_CompanyName")

			'//////////////////////////////////////////////////////////
			' Visible Columns
			'//////////////////////////////////////////////////////////

			' Rearrange visible columns so that "Freight" remains in view.
			ordersDescriptor.VisibleColumns.LoadDefault()
			ordersDescriptor.VisibleColumns.Remove("Freight")
			ordersDescriptor.VisibleColumns.Insert(3, New GridVisibleColumnDescriptor("Freight"))

			' Change format of freight
			ordersDescriptor.Columns("Freight").Appearance.AnyRecordFieldCell.Format = "F2"
			ordersDescriptor.Columns("Freight").MaxLength = 15

			ordersDescriptor.Columns("CustomerID").MaxLength = 22

			'//////////////////////////////////////////////////////////
			' Blinking - highlight cells when value increased or 
			' decreased for a short time
			'//////////////////////////////////////////////////////////

			Me.gridGroupingControl1.BlinkTime = 0 ' optional blinking here (in milliseconde)
			ordersDescriptor.Columns("Freight").AllowBlink = True
			ordersDescriptor.Columns("EmployeeID").AllowBlink = True

			'//////////////////////////////////////////////////////////
			' Customized caption row
			'//////////////////////////////////////////////////////////

			' Here you define the summary row that should be used for displaying summaries in caption bar.
			ordersDescriptor.ChildGroupOptions.ShowCaptionSummaryCells = True
			ordersDescriptor.ChildGroupOptions.ShowSummaries = True
			ordersDescriptor.ChildGroupOptions.CaptionSummaryRow = "Caption"

			' Let's you hide/show the second row in child groups.
			ordersDescriptor.ChildGroupOptions.ShowSummaries = True

			ordersDescriptor.TopLevelGroupOptions.ShowCaptionSummaryCells = False
			ordersDescriptor.ChildGroupOptions.ShowAddNewRecordBeforeDetails = False

			' Minor customization: Have Caption bar cover some cells.
			AddHandler gridGroupingControl1.TableModel.QueryCoveredRange, AddressOf TableModel_QueryCoveredRange
			captionCoverCols = 2

			' Make the caption look like a regular cell
			ordersDescriptor.Appearance.GroupCaptionCell.BackColor = Me.gridGroupingControl1.Appearance.RecordFieldCell.BackColor
			ordersDescriptor.Appearance.GroupCaptionCell.Borders.Top = New GridBorder(GridBorderStyle.Standard)
			ordersDescriptor.Appearance.GroupCaptionCell.CellType = "Static"
			ordersDescriptor.TableOptions.CaptionRowHeight = Me.gridGroupingControl1.TableOptions.RecordRowHeight

			'///////////////////////////////////////////////////////////////////////
			' ManualTotalSummary example code
			'///////////////////////////////////////////////////////////////////////

			' Totals with delta support for ListChanged events - replacement for built-in summaries of grouping engine.
			AddHandler gridGroupingControl1.QueryCellStyleInfo, AddressOf gridGroupingControl1_QueryCellStyleInfo

			Dim tb As ManualTotalSummaryTable = CType(Me.gridGroupingControl1.Table, ManualTotalSummaryTable)
			tb.TotalSummaries.Add("Freight")
			tb.TotalSummaries.Add("EmployeeID")
			tb.TableDirty = True ' needed after changing TotalSummaries...


			' Checking the results of initial total calculations for "Freight"

			Dim cc As Integer = tb.Records.Count ' force initializion
			Dim freightTotalIndex As Integer = tb.TableDescriptor.Fields.IndexOf("Freight")
			Dim tsa As IManualTotalSummaryArraySource = TryCast(Me.gridGroupingControl1.Table.TopLevelGroup, IManualTotalSummaryArraySource)
			Dim tm As ManualTotalSummary = tsa.GetManualTotalSummaryArray()(freightTotalIndex)
			Console.WriteLine("FreightTotal = " & tm.Total.ToString())

			For Each g As Group In Me.gridGroupingControl1.Table.TopLevelGroup.Groups
				tsa = TryCast(g, IManualTotalSummaryArraySource)
				tm = tsa.GetManualTotalSummaryArray()(freightTotalIndex)
				Console.WriteLine(g.ToString() & " FreightTotal = " & tm.Total.ToString())
			Next g
			Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
			Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana"
			gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue
			Me.BackColor = Color.White
			' Be notified about changes to SortedColumns collection.
			AddHandler gridGroupingControl1.PropertyChanged, AddressOf gridGroupingControl1_PropertyChanged
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


		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			' Add a button in caption area - clicking this button will start the timer.

			startTimerButton.Text = "Start Timer"
			startTimerButton.Visible = True
			Me.Controls.Add(startTimerButton)
			AddHandler startTimerButton.Click, AddressOf startTimerButton_Click
			startTimerButton.BringToFront()

			Dim t As New ToolTip()
			t.SetToolTip(startTimerButton, "Click this button to start continous updates. " & Constants.vbLf & "Tip: You can also sort by EmployeeID or Freight to check out sort position updates of records.")
			Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
			Me.BackColor = Color.White
			' Show schema in property grid.
			'new GridGroupingControlSchemaBrowser(this.gridGroupingControl1).Show();
			Me.DropShadow = True
			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
			Me.propertyGrid1.BackColor = Color.White
			Me.gridGroupingControl1.Table.ExpandAllRecords()
			Me.panel1.Controls.Add(Me.gridGroupingControl1)
		End Sub

		Private Sub startTimerButton_Click(ByVal sender As Object, ByVal e As EventArgs)
#If TESTSPEED Then
			Dim timer As Integer = Environment.TickCount
			Dim testCount As Integer = 100
			'using (MeasureTime.Measure("Form1.startTimerButton_Click"))
				Dim n As Integer = 0
'ORIGINAL LINE: for (int n = 0; n < testCount; n += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
				Do While n < testCount
					timer_tick(Me, Nothing)
					Application.DoEvents()
					Me.gridGroupingControl1.UpdateThrottled()
					n += 1
				Loop

			Dim s As String = MeasureTime.DumpTimes()
			s &= Environment.NewLine
			Dim tc As Integer = (Environment.TickCount - timer)

			s &= "Average Ticks per timer_tick call: " & (tc / testCount).ToString()
			s &= Environment.NewLine

			Me.gridGroupingControl1.Update()
			MessageBox.Show(s)
#Else
			' Start timer that updates datasource 
			timer = New System.Windows.Forms.Timer()
			timer.Interval = 100 ' push in updates every 100 ms. Update 1000 records each time.
			AddHandler timer.Tick, AddressOf timer_tick
			timer.Start()
#End If
		End Sub

		Private rnd As Random = New Random(0)
		Private j As Integer
		Private sortedByFreight As Boolean = False
		Private sortedByEmployeeID As Boolean = False
		Private timer As System.Windows.Forms.Timer

		Private Sub timer_tick(ByVal sender As Object, ByVal e As EventArgs)
			Dim td As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor
			Dim tb As ManualTotalSummaryTable = (CType(Me.gridGroupingControl1.Table, ManualTotalSummaryTable))
			Dim i As Integer = 0
			Using MeasureTime.Measure("Form1.timer_tick")
				Dim count As Integer = 1000

				If Me.gridGroupingControl1.SortPositionChangedBehavior = GridListChangedInsertRemoveBehavior.ScrollWithImmediateUpdate Then
				If sortedByFreight OrElse gridGroupingControl1.TestDeleteRecords OrElse gridGroupingControl1.TestInsertRecords OrElse gridGroupingControl1.TestChangeGroup Then
						count = 200 ' when sort position is changed this is much more demanding, let's do less records then.
				End If

				If sortedByEmployeeID Then
						count = 50 ' each update will cause records being shifted around so let's do even less records. You could also check out InvalidateAll option instead above...
				End If
				End If

				i = 0
'ORIGINAL LINE: for (i = 0; i < count; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
				Do While i < count
					Dim dr As ManualTotalSummaries.DataSet1.OrdersRow

					' Insert Records
					If gridGroupingControl1.TestInsertRecords Then
						If i Mod 10 = 0 Then
							dr = northwindDataSet1.Orders.NewOrdersRow()
'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
                            'ORIGINAL LINE: dr.CustomerID = i.ToString() + (j += 1).ToString();
                            j += 1
                            dr.CustomerID = i.ToString() & (j).ToString()
                            dr.EmployeeID = i
                            Dim b As Decimal = i
                            dr.Freight = b / 10
							dr.ShipVia = 0
							dr.Table.Rows.Add(dr)
							Continue Do
						End If
					End If

					If northwindDataSet1.Orders.Rows.Count = 0 Then
						Me.gridGroupingControl1.Update()
						Return
					End If

					Dim newIndex As Integer = rnd.Next(northwindDataSet1.Orders.Rows.Count)
					dr = northwindDataSet1.Orders(newIndex)


					' Delete records

					If gridGroupingControl1.TestDeleteRecords Then
						If i Mod 12 = 0 Then
							dr.Delete()
							Continue Do
						End If
					End If

					' Change records

					' Freight
					Dim freight As Decimal = CDec(dr.Freight) + Math.Round(CDec(rnd.Next(-100, 100)) / 10000, 2)
					Dim employeeID As Integer = CInt(rnd.NextDouble() * 1000)

					

					dr.BeginEdit()

					Dim oldFreight As Decimal = dr.Freight
					dr.Freight = freight
					dr.EmployeeID = employeeID

					If gridGroupingControl1.TestChangeGroup Then
						' Change Group Category
						If i = 10 Then
							tb.AddChangedField(New ChangedFieldInfo(td, "ShipVia", dr.ShipVia, 0))
							dr.ShipVia = 0
						End If
					End If

					' fires ListChanged event
					dr.EndEdit()
					i += 1
				Loop

				' Optionally manually flush changes
				If Me.gridGroupingControl1.UpdateDisplayFrequency = 0 Then
					Me.gridGroupingControl1.Update()
				End If
			End Using

		End Sub

		#Region "Initialize DataSet"

		Private xmlName As String = "Orders.xml"
		Private msdeAvailable As Boolean = False

		Private Sub InitializeDataSet()
			If msdeAvailable Then
				' Initialize the data set

				Me.northwindDataSet1.BeginInit()

				' Order is important here - first fill tables that are referenced with 
				' foreign keys, then tables that have references to others.

				Me.sqlDataAdapterOrders.Fill(Me.northwindDataSet1)

				Me.northwindDataSet1.EndInit()

				Me.northwindDataSet1.WriteXml(xmlName)
			Else
				' Read from a xml file instead. 
				If (Not ReadXml(Me.northwindDataSet1, xmlName)) Then
					' If no xml found, try again with MSDE
					msdeAvailable = True
					InitializeDataSet()
				End If
			End If


		End Sub

		Private Function ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String) As Boolean
			' Check both in parent folder and Parent\Data folders.
			Dim xmlDataFileName As String = "Common\Data\" & xmlFileName
			For n As Integer = 0 To 9
				If System.IO.File.Exists(xmlFileName) Then
					ds.ReadXml(xmlFileName)
					Return True
				End If
				If System.IO.File.Exists(xmlDataFileName) Then
					ds.ReadXml(xmlDataFileName)
					Return True
				End If
				xmlFileName = "..\" & xmlFileName
				xmlDataFileName = "..\" & xmlDataFileName
			Next n

			Return False
		End Function

		#End Region

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

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.northwindDataSet1 = New ManualTotalSummaries.DataSet1()
			Me.gridGroupingControl1 = New SampleGridGroupingControl()
			Me.sqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
			Me.sqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
			Me.sqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
			Me.sqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
			Me.sqlDataAdapterOrders = New System.Data.SqlClient.SqlDataAdapter()
			Me.sqlConnection2 = New System.Data.SqlClient.SqlConnection()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
			Me.startTimerButton = New Syncfusion.Windows.Forms.ButtonAdv()
			CType(Me.northwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' northwindDataSet1
			' 
			Me.northwindDataSet1.DataSetName = "DataSet1"
			Me.northwindDataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridGroupingControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.ShowGroupDropArea = True
			Me.gridGroupingControl1.Size = New System.Drawing.Size(558, 516)
			Me.gridGroupingControl1.TabIndex = 0
			' 
			' sqlSelectCommand2
			' 
			Me.sqlSelectCommand2.CommandText = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, Shi" & "pVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, Ship" & "Country FROM Orders"
			Me.sqlSelectCommand2.Connection = Me.sqlConnection2
			' 
			' sqlInsertCommand2
			' 
			Me.sqlInsertCommand2.CommandText = "INSERT INTO Orders(CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry) VALUES (@CustomerID, @EmployeeID, @OrderDate, @RequiredDate, @ShippedDate, @ShipVia, @Freight, @ShipName, @ShipAddress, @ShipCity, @ShipRegion, @ShipPostalCode, @ShipCountry); SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry FROM Orders WHERE (OrderID = @@IDENTITY)"
			Me.sqlInsertCommand2.Connection = Me.sqlConnection2
			Me.sqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"))
			Me.sqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"))
			Me.sqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"))
			Me.sqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"))
			Me.sqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"))
			Me.sqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"))
			Me.sqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"))
			Me.sqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"))
			Me.sqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"))
			Me.sqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"))
			Me.sqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"))
			Me.sqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"))
			Me.sqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry"))
			' 
			' sqlUpdateCommand2
			' 
			Me.sqlUpdateCommand2.CommandText = "UPDATE Orders SET CustomerID = @CustomerID, EmployeeID = @EmployeeID, OrderDate =" & " @OrderDate, RequiredDate = @RequiredDate, ShippedDate = @ShippedDate, ShipVia =" & " @ShipVia, Freight = @Freight, ShipName = @ShipName, ShipAddress = @ShipAddress," & " ShipCity = @ShipCity, ShipRegion = @ShipRegion, ShipPostalCode = @ShipPostalCod" & "e, ShipCountry = @ShipCountry WHERE (OrderID = @Original_OrderID) AND (CustomerI" & "D = @Original_CustomerID OR @Original_CustomerID IS NULL AND CustomerID IS NULL)" & " AND (EmployeeID = @Original_EmployeeID OR @Original_EmployeeID IS NULL AND Empl" & "oyeeID IS NULL) AND (Freight = @Original_Freight OR @Original_Freight IS NULL AN" & "D Freight IS NULL) AND (OrderDate = @Original_OrderDate OR @Original_OrderDate I" & "S NULL AND OrderDate IS NULL) AND (RequiredDate = @Original_RequiredDate OR @Ori" & "ginal_RequiredDate IS NULL AND RequiredDate IS NULL) AND (ShipAddress = @Origina" & "l_ShipAddress OR @Original_ShipAddress IS NULL AND ShipAddress IS NULL) AND (Shi" & "pCity = @Original_ShipCity OR @Original_ShipCity IS NULL AND ShipCity IS NULL) A" & "ND (ShipCountry = @Original_ShipCountry OR @Original_ShipCountry IS NULL AND Shi" & "pCountry IS NULL) AND (ShipName = @Original_ShipName OR @Original_ShipName IS NU" & "LL AND ShipName IS NULL) AND (ShipPostalCode = @Original_ShipPostalCode OR @Orig" & "inal_ShipPostalCode IS NULL AND ShipPostalCode IS NULL) AND (ShipRegion = @Origi" & "nal_ShipRegion OR @Original_ShipRegion IS NULL AND ShipRegion IS NULL) AND (Ship" & "Via = @Original_ShipVia OR @Original_ShipVia IS NULL AND ShipVia IS NULL) AND (S" & "hippedDate = @Original_ShippedDate OR @Original_ShippedDate IS NULL AND ShippedD" & "ate IS NULL); SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, S" & "hippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipP" & "ostalCode, ShipCountry FROM Orders WHERE (OrderID = @OrderID)"
			Me.sqlUpdateCommand2.Connection = Me.sqlConnection2
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry"))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderID", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EmployeeID", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Freight", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderDate", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "RequiredDate", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipAddress", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCity", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCountry", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipName", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipRegion", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipVia", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShippedDate", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID"))
			' 
			' sqlDeleteCommand2
			' 
			Me.sqlDeleteCommand2.CommandText = "DELETE FROM Orders WHERE (OrderID = @Original_OrderID) AND (CustomerID = @Original_CustomerID OR @Original_CustomerID IS NULL AND CustomerID IS NULL) AND (EmployeeID = @Original_EmployeeID OR @Original_EmployeeID IS NULL AND EmployeeID IS NULL) AND (Freight = @Original_Freight OR @Original_Freight IS NULL AND Freight IS NULL) AND (OrderDate = @Original_OrderDate OR @Original_OrderDate IS NULL AND OrderDate IS NULL) AND (RequiredDate = @Original_RequiredDate OR @Original_RequiredDate IS NULL AND RequiredDate IS NULL) AND (ShipAddress = @Original_ShipAddress OR @Original_ShipAddress IS NULL AND ShipAddress IS NULL) AND (ShipCity = @Original_ShipCity OR @Original_ShipCity IS NULL AND ShipCity IS NULL) AND (ShipCountry = @Original_ShipCountry OR @Original_ShipCountry IS NULL AND ShipCountry IS NULL) AND (ShipName = @Original_ShipName OR @Original_ShipName IS NULL AND ShipName IS NULL) AND (ShipPostalCode = @Original_ShipPostalCode OR @Original_ShipPostalCode IS NULL AND ShipPostalCode IS NULL) AND (ShipRegion = @Original_ShipRegion OR @Original_ShipRegion IS NULL AND ShipRegion IS NULL) AND (ShipVia = @Original_ShipVia OR @Original_ShipVia IS NULL AND ShipVia IS NULL) AND (ShippedDate = @Original_ShippedDate OR @Original_ShippedDate IS NULL AND ShippedDate IS NULL)"
			Me.sqlDeleteCommand2.Connection = Me.sqlConnection2
			Me.sqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderID", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EmployeeID", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Freight", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderDate", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "RequiredDate", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipAddress", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCity", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCountry", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipName", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipRegion", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipVia", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShippedDate", System.Data.DataRowVersion.Original, Nothing))
			' 
			' sqlDataAdapterOrders
			' 
			Me.sqlDataAdapterOrders.DeleteCommand = Me.sqlDeleteCommand2
			Me.sqlDataAdapterOrders.InsertCommand = Me.sqlInsertCommand2
			Me.sqlDataAdapterOrders.SelectCommand = Me.sqlSelectCommand2
			Me.sqlDataAdapterOrders.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Orders", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"), New System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"), New System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"), New System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"), New System.Data.Common.DataColumnMapping("Freight", "Freight"), New System.Data.Common.DataColumnMapping("ShipName", "ShipName"), New System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"), New System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"), New System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"), New System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"), New System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry")})})
			Me.sqlDataAdapterOrders.UpdateCommand = Me.sqlUpdateCommand2
			' 
			' sqlConnection2
			' 
			Me.sqlConnection2.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_samples;persist security info=True;user id=sa;packet size=4096;Pooling=true"
			Me.panel1.Location = New System.Drawing.Point(24, 22)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(558, 516)
			Me.panel1.TabIndex = 0
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.propertyGrid1)
			Me.panel2.Location = New System.Drawing.Point(610, 65)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(251, 470)
			Me.panel2.TabIndex = 3
			' 
			' propertyGrid1
			' 
			Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
			Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyGrid1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
			Me.propertyGrid1.LineColor = System.Drawing.Color.White
			Me.propertyGrid1.Location = New System.Drawing.Point(0, 0)
			Me.propertyGrid1.Name = "propertyGrid1"
			Me.propertyGrid1.Size = New System.Drawing.Size(251, 470)
			Me.propertyGrid1.TabIndex = 0
			' 
			' startTimerButton
			' 
			Me.startTimerButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.startTimerButton.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.startTimerButton.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.startTimerButton.ForeColor = System.Drawing.Color.White
			Me.startTimerButton.Location = New System.Drawing.Point(610, 22)
			Me.startTimerButton.Name = "startTimerButton"
			Me.startTimerButton.Size = New System.Drawing.Size(96, 28)
			Me.startTimerButton.TabIndex = 1
			Me.startTimerButton.Text = "buttonAdv1"
			Me.startTimerButton.UseVisualStyle = True
			Me.startTimerButton.UseVisualStyleBackColor = False
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.White
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(887, 570)
			Me.Controls.Add(Me.startTimerButton)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.panel1)
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.White
            Me.MinimizeBox = False
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
			Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Manual Total Summary Demo"
			CType(Me.northwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel2.ResumeLayout(False)
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

		#Region "Unbound Fields and Covered Ranges"

		Private Sub ordersDescriptor_QueryValue(ByVal sender As Object, ByVal e As FieldValueEventArgs)
			' This methods maps from the underlying value to a related value

			Dim obj As Object = e.Record.GetValue("ShipVia")
			If Not obj Is Nothing AndAlso Not(TypeOf obj Is DBNull) Then
				Dim shipVia As Integer = CInt(obj)
				Select Case shipVia
					Case 0
						e.Value = "Zero"
					Case 1
						e.Value = "One"
					Case 2
						e.Value = "Two"
					Case 3
						e.Value = "Three"
				End Select
			End If
		End Sub

		Private captionCoverCols As Integer

		Private Sub TableModel_QueryCoveredRange(ByVal sender As Object, ByVal e As GridQueryCoveredRangeEventArgs)
			'using (MeasureTime.Measure("TableModel_QueryCoveredRange"))
				Dim thisTable As GridTable = Me.gridGroupingControl1.Table
				If e.RowIndex < thisTable.DisplayElements.Count Then
					Dim el As Element = thisTable.DisplayElements(e.RowIndex)

					Select Case el.Kind
						Case DisplayElementKind.Caption
								' Cover some cells of the caption bar (specified with captionCover)
								Dim gs As IGridGroupOptionsSource = TryCast(el.ParentGroup, IGridGroupOptionsSource)
								If Not gs Is Nothing AndAlso gs.GroupOptions.ShowCaptionSummaryCells Then
									Dim startCol As Integer = el.GroupLevel + 1
									If (Not gs.GroupOptions.ShowCaptionPlusMinus) Then
										startCol -= 1
									End If
									If e.ColIndex >= startCol AndAlso e.ColIndex < startCol + Me.captionCoverCols Then
										e.Range = GridRangeInfo.Cells(e.RowIndex, startCol, e.RowIndex, startCol + Me.captionCoverCols -1)
										e.Handled = True
									End If
								End If
								Exit Select

					End Select
				End If
		End Sub

		#End Region


		''' <summary>
		''' Manually fill summary cells with values from ManualTotalSummaries.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub gridGroupingControl1_QueryCellStyleInfo(ByVal sender As Object, ByVal e As GridTableCellStyleInfoEventArgs)
			Dim el As Element = e.TableCellIdentity.DisplayElement
			Dim table As ManualTotalSummaryTable = TryCast(el.ParentTable, ManualTotalSummaryTable)

			If table Is Nothing Then
				Return
			End If

			'using (MeasureTime.Measure("gridGroupingControl1_QueryCellStyleInfo"))
				If Element.IsCaption(el) Then
					If e.Style.TableCellIdentity.ColIndex > 3 Then
						

						' you can get the column as follows:
						Dim column As GridColumnDescriptor = Me.gridGroupingControl1.TableModel.GetHeaderColumnDescriptorAt(e.TableCellIdentity.ColIndex)

						If Not column Is Nothing AndAlso table.TotalSummaries.IndexOf(column.MappingName) <> -1 Then
							Dim index As Integer = column.TableDescriptor.Fields.IndexOf(column.FieldDescriptor)
							Dim tsa As IManualTotalSummaryArraySource
							If TypeOf el Is Group Then
								tsa = TryCast((el), IManualTotalSummaryArraySource)
							Else
								tsa = TryCast((el.ParentGroup), IManualTotalSummaryArraySource)
							End If
							Dim tm As ManualTotalSummary = tsa.GetManualTotalSummaryArray()(index)
							e.Style.CellValue = tm.Total
							e.Style.CellValueType = GetType(Double)
							e.Style.Format = "0.00"
						End If
						' Using that column you could try and identify the summary that should be displayed in this cell.
					End If
				Else If TypeOf el Is GridSummaryRow Then
					' you can get the column as follows:
					Dim column As GridColumnDescriptor = Me.gridGroupingControl1.TableModel.GetHeaderColumnDescriptorAt(e.TableCellIdentity.ColIndex)
					If Not column Is Nothing AndAlso table.TotalSummaries.IndexOf(column.MappingName) <> -1 Then
						Dim index As Integer = column.TableDescriptor.Fields.IndexOf(column.FieldDescriptor)
						Dim tsa As IManualTotalSummaryArraySource
						If TypeOf el Is Group Then
							tsa = TryCast((el), IManualTotalSummaryArraySource)
						Else
							tsa = TryCast((el.ParentGroup), IManualTotalSummaryArraySource)
						End If
						Dim tm As ManualTotalSummary = tsa.GetManualTotalSummaryArray()(index)
						e.Style.CellValue = tm.Total
						e.Style.CellValueType = GetType(Double)
						e.Style.Format = "0.00"
					End If
					' Using that column you could try and identify the summary that should be displayed in this cell.
				End If
		End Sub

		Private Sub gridGroupingControl1_PropertyChanged(ByVal sender As Object, ByVal e As DescriptorPropertyChangedEventArgs)
			Dim gcc As GridGroupingControl = CType(sender, GridGroupingControl)
			If e.PropertyName = "TableDescriptor" Then
				Dim tableDescriptor As TableDescriptor = gcc.TableDescriptor
				e = CType(e.Inner, DescriptorPropertyChangedEventArgs)

				If e.PropertyName = "Relations" Then
					e = e.GetNestedChildTableDescriptorEvent(tableDescriptor)
				End If

				Select Case e.PropertyName
					Case "SortedColumns"
							sortedByFreight = tableDescriptor.SortedColumns.Contains("Freight")
							sortedByEmployeeID = tableDescriptor.SortedColumns.Contains("EmployeeID")
							Exit Select
				End Select
			End If
		End Sub


	End Class

	Public Class SampleGridGroupingControl : Inherits GridGroupingControl
		Public Sub New()
		End Sub

		Private testDeleteRecords_Renamed As Boolean = False
		Private testInsertRecords_Renamed As Boolean = False
		Private testChangeGroup_Renamed As Boolean = False

		<Category("Tests")> _
		Public Property TestDeleteRecords() As Boolean
			Get
				Return testDeleteRecords_Renamed
			End Get
			Set
				testDeleteRecords_Renamed = Value
			End Set
		End Property

		<Category("Tests")> _
		Public Property TestInsertRecords() As Boolean
			Get
				Return testInsertRecords_Renamed
			End Get
			Set
				testInsertRecords_Renamed = Value
			End Set
		End Property

		<Category("Tests")> _
		Public Property TestChangeGroup() As Boolean
			Get
				Return testChangeGroup_Renamed
			End Get
			Set
				testChangeGroup_Renamed = Value
			End Set
		End Property
	End Class
End Namespace