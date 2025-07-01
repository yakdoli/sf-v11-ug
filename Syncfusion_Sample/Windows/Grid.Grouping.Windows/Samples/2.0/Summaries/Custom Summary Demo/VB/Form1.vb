Imports Microsoft.VisualBasic
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

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO

Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms

	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private sqlSelectCommand1 As System.Data.SqlClient.SqlCommand
		Private sqlInsertCommand1 As System.Data.SqlClient.SqlCommand
		Private sqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
		Private sqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
		Private sqlConnection1 As System.Data.SqlClient.SqlConnection
		Private sqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
        Private dataSet11 As DataSet1
		Friend propertyGrid As PropertyGrid
		Private panel1 As Panel
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Private Sub ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String)
			For n As Integer = 0 To 9
				If File.Exists(xmlFileName) Then
					ds.ReadXml(xmlFileName)
					Exit For
				End If
				xmlFileName = "..\" & xmlFileName
			Next n
		End Sub

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
			ReadXml(Me.dataSet11,"OrderDetails.xml")



			' Setup a integrated summary
			Dim sd0 As New GridSummaryColumnDescriptor()
			'sd0.Name = "QuantityAvg";
			sd0.DataMember = "Quantity"
			sd0.DisplayColumn = "Quantity"
			sd0.Format = "{Average:#.00}"
			sd0.SummaryType = SummaryType.DoubleAggregate
			Me.gridGroupingControl1.TableDescriptor.SummaryRows.Add(New GridSummaryRowDescriptor("Row 0", "Average", sd0))

			' Setup custom summaries
			AddHandler gridGroupingControl1.QueryCustomSummary, AddressOf gridGroupingControl1_QueryCustomSummary

			Dim sd1 As New GridSummaryColumnDescriptor()
			sd1.Name = "QuantityTotal"
			sd1.DataMember = "Quantity"
			sd1.DisplayColumn = "Quantity"
			sd1.Format = "{Total}"
			sd1.SummaryType = SummaryType.Custom
			Me.gridGroupingControl1.TableDescriptor.SummaryRows.Add(New GridSummaryRowDescriptor("Row 1", "Total", sd1))

			Dim sd2 As New GridSummaryColumnDescriptor()
			sd2.Name = "QuantityDistinctCount"
			sd2.DataMember = "Quantity"
			sd2.DisplayColumn = "Quantity"
			sd2.Format = "{Count}"
			sd2.SummaryType = SummaryType.Custom
			Me.gridGroupingControl1.TableDescriptor.SummaryRows.Add(New GridSummaryRowDescriptor("Row 2", "DistinctCount", sd2))


			Dim sd3 As New GridSummaryColumnDescriptor()
			sd3.Name = "QuantityMedian"
			sd3.DataMember = "Quantity"
			sd3.DisplayColumn = "Quantity"
			sd3.Format = "{Median}"
			sd3.SummaryType = SummaryType.Custom
			Me.gridGroupingControl1.TableDescriptor.SummaryRows.Add(New GridSummaryRowDescriptor("Row 3", "Statistic Median", sd3))


			' Setup running totals by displaying the value of a custom counter in an unbound field
			Dim unboundField As New FieldDescriptor("QuantityCount", "", False, "")
			unboundField.ReadOnly = False
			Me.gridGroupingControl1.TableDescriptor.UnboundFields.Add(unboundField)

			AddHandler gridGroupingControl1.TableDescriptor.QueryValue, AddressOf unboundField_QueryValue ' Routine that queries for the value
			AddHandler gridGroupingControl1.TableDescriptor.SaveValue, AddressOf unboundField_SaveValue

			Dim unboundField2 As New FieldDescriptor("QuantityCount2", "", False, "")
			Me.gridGroupingControl1.TableDescriptor.UnboundFields.Add(unboundField2)



			Me.gridGroupingControl1.TableDescriptor.Columns.IsModified = True

			Dim gridColumnDescriptor1 As New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
			Dim gridColumnDescriptor2 As New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
			gridColumnDescriptor1.MappingName = "OrderID"
			Me.gridGroupingControl1.TableDescriptor.Columns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor() { gridColumnDescriptor1, New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ProductID"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("UnitPrice"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("Quantity") })


			Dim columnDescriptor As New GridColumnDescriptor(unboundField)
			columnDescriptor.Appearance.AnyRecordFieldCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CByte(255)), (CByte(245)), (CByte(227))))
			Me.gridGroupingControl1.TableDescriptor.Columns.Add(columnDescriptor)

			Dim columnDescriptor2 As New GridColumnDescriptor(unboundField2)
			columnDescriptor2.Appearance.AnyRecordFieldCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CByte(255)), (CByte(245)), (CByte(227))))
			Me.gridGroupingControl1.TableDescriptor.Columns.Add(columnDescriptor2)

			' Setup custom counter
			AddHandler gridGroupingControl1.Table.QueryCustomCount, AddressOf Table_QueryCustomCount
			AddHandler gridGroupingControl1.CurrentRecordContextChange, AddressOf gridGroupingControl1_CurrentRecordContextChange
			AddHandler gridGroupingControl1.Table.QueryVisibleCustomCount, AddressOf Table_QueryVisibleCustomCount

			' Assign data source
			Me.gridGroupingControl1.DataMember = Nothing
			Me.gridGroupingControl1.DataSource = Me.dataSet11.Order_Details

			quantityFieldDescriptor = Me.gridGroupingControl1.TableDescriptor.Fields("Quantity")

			' Add a filter so that we can check out difference between VisibleCustomCount (only records that meet criteria are counted) 
			' and CustomCount (all records are counted)
			Me.gridGroupingControl1.TableDescriptor.RecordFilters.Add("[UnitPrice] > 20")

			Me.gridGroupingControl1.FilterRuntimeProperties = True

			AddHandler gridGroupingControl1.TableControlCellClick, AddressOf gridGroupingControl1_TableControlCellClick
			Me.gridGroupingControl1.TableDescriptor.Columns("QuantityCount").AllowGroupByColumn = False
			Me.gridGroupingControl1.TableDescriptor.Columns("QuantityCount2").AllowGroupByColumn = False

			Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			AddHandler gridGroupingControl1.TableModel.QueryColWidth, AddressOf TableModel_QueryColWidth

		End Sub

		Private Sub TableModel_QueryColWidth(ByVal sender As Object, ByVal e As GridRowColSizeEventArgs)
			If e.Index > 0 Then
				If e.Index > Me.gridGroupingControl1.TableModel.ColCount - 4 Then
					e.Size = 90
					Return
				End If
				e.Size = 65
			End If
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

		Private Sub gridGroupingControl1_TableControlCellClick(ByVal sender As Object, ByVal e As GridTableControlCellClickEventArgs)
			Dim style As GridTableCellStyleInfo = TryCast(e.TableControl.Model(e.Inner.RowIndex, e.Inner.ColIndex), GridTableCellStyleInfo)
			If style IsNot Nothing AndAlso TypeOf style.TableCellIdentity.DisplayElement Is GridColumnHeaderRow AndAlso style.TableCellIdentity.Column IsNot Nothing AndAlso style.TableCellIdentity.Column.Name.IndexOf("Count") <> -1 Then
				MessageBox.Show("Can't sort by this column. Its contents are dependant on the order of records and will change if you sort by another column.")
				e.Inner.Cancel = True
			End If
		End Sub

		Private quantityFieldDescriptor As FieldDescriptor


		''' <summary>
		''' Custom Sumaries - associate with CreateSummaryMethod
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub gridGroupingControl1_QueryCustomSummary(ByVal sender As Object, ByVal e As GridQueryCustomSummaryEventArgs)
			Select Case e.SummaryColumn.Name
				Case "QuantityTotal"
					e.SummaryDescriptor.CreateSummaryMethod = New CreateSummaryDelegate(AddressOf TotalSummary.CreateSummaryMethod)
					Exit Select

				Case "QuantityDistinctCount"
					e.SummaryDescriptor.CreateSummaryMethod = New CreateSummaryDelegate(AddressOf DistinctInt32CountSummary.CreateSummaryMethod)
					Exit Select

				Case "QuantityMedian"
					e.SummaryDescriptor.CreateSummaryMethod = New CreateSummaryDelegate(AddressOf StatisticsSummary.CreateSummaryMethod)
					Exit Select

			End Select
		End Sub


		''' <summary>
		''' Query value for unbound field
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub unboundField_QueryValue(ByVal sender As Object, ByVal e As FieldValueEventArgs)
			If TypeOf e.Record Is AddNewRecord Then
				Return
			End If

			If e.Field.Name = "QuantityCount" Then
				e.Value = e.Record.GetCustomPosition()
			Else
				e.Value = e.Record.GetVisibleCustomPosition()
			End If
		End Sub

		''' <summary>
		''' Could write back value here if needed when unbound field is changed by user.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub unboundField_SaveValue(ByVal sender As Object, ByVal e As FieldValueEventArgs)
			Console.WriteLine(e.Value)
		End Sub



		''' <summary>
		''' Fill in custom counter. This event is called for every record in the table. The CustomCounter
		''' will increase no matter if a record meet filter criteria or not.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub Table_QueryCustomCount(ByVal sender As Object, ByVal e As CustomCountEventArgs)
			If TypeOf e.Record Is AddNewRecord Then
				Return
			End If

			Dim obj As Object = e.Record.GetValue(quantityFieldDescriptor)
			Dim quantity As Double = Convert.ToDouble(obj)
			e.CustomCount = quantity
		End Sub

		''' <summary>
		''' Fill in visible custom counter. This event is called for every visible record in the table. The CustomCounter
		''' will increase only for records that meet filter criteria.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub Table_QueryVisibleCustomCount(ByVal sender As Object, ByVal e As CustomCountEventArgs)
			'if (e.Record is AddNewRecord)
			'    return;

			'object obj = e.Record.GetValue(quantityFieldDescriptor);
			'double quantity = Convert.ToDouble(obj);
			'e.CustomCount = quantity;
		End Sub

		''' <summary>
		''' We need to make counters dirty when the record has changed since the custom counters need
		''' to be recalculated for subsequent records. Also, the grid needs to be redrawn.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub gridGroupingControl1_CurrentRecordContextChange(ByVal sender As Object, ByVal e As CurrentRecordContextChangeEventArgs)
			If e.Action = CurrentRecordAction.EndEditComplete Then
				e.Record.InvalidateCounterBottomUp()
				Me.gridGroupingControl1.Refresh()
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
        Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
        Me.sqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.sqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.dataSet11 = New CustomSummary.DataSet1
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid
        Me.panel1 = New System.Windows.Forms.Panel
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridGroupingControl1
        '
        Me.gridGroupingControl1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
        Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridGroupingControl1.Location = New System.Drawing.Point(12, 32)
        Me.gridGroupingControl1.Name = "gridGroupingControl1"
        Me.gridGroupingControl1.ShowGroupDropArea = True
        Me.gridGroupingControl1.Size = New System.Drawing.Size(478, 426)
        Me.gridGroupingControl1.TabIndex = 0
        Me.gridGroupingControl1.TableDescriptor.AllowNew = False
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.BaseStyle = ""
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)))
        Me.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
        Me.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
        Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
        Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
        Me.gridGroupingControl1.Text = "gridGroupingControl1"
        '
        'sqlSelectCommand1
        '
        Me.sqlSelectCommand1.CommandText = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details]"
        Me.sqlSelectCommand1.Connection = Me.sqlConnection1
        '
        'sqlConnection1
        '
        Me.sqlConnection1.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_sampl" & _
            "es;persist security info=True;user id=sa;packet size=4096;Pooling=true"
        Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'sqlInsertCommand1
        '
        Me.sqlInsertCommand1.Connection = Me.sqlConnection1
        Me.sqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID"), New System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID"), New System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"), New System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.SmallInt, 2, "Quantity"), New System.Data.SqlClient.SqlParameter("@Discount", System.Data.SqlDbType.Real, 4, "Discount")})
        '
        'sqlUpdateCommand1
        '
        Me.sqlUpdateCommand1.Connection = Me.sqlConnection1
        Me.sqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID"), New System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID"), New System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"), New System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.SmallInt, 2, "Quantity"), New System.Data.SqlClient.SqlParameter("@Discount", System.Data.SqlDbType.Real, 4, "Discount"), New System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Discount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnitPrice", System.Data.DataRowVersion.Original, Nothing)})
        '
        'sqlDeleteCommand1
        '
        Me.sqlDeleteCommand1.Connection = Me.sqlConnection1
        Me.sqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Discount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnitPrice", System.Data.DataRowVersion.Original, Nothing)})
        '
        'sqlDataAdapter1
        '
        Me.sqlDataAdapter1.DeleteCommand = Me.sqlDeleteCommand1
        Me.sqlDataAdapter1.InsertCommand = Me.sqlInsertCommand1
        Me.sqlDataAdapter1.SelectCommand = Me.sqlSelectCommand1
        Me.sqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Order Details", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("Discount", "Discount")})})
        Me.sqlDataAdapter1.UpdateCommand = Me.sqlUpdateCommand1
        '
        'dataSet11
        '
        Me.dataSet11.DataSetName = "DataSet1"
        Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'propertyGrid
        '
        Me.propertyGrid.BackColor = System.Drawing.Color.White
        Me.propertyGrid.CommandsBackColor = System.Drawing.Color.White
        Me.propertyGrid.CommandsDisabledLinkColor = System.Drawing.Color.White
        Me.propertyGrid.HelpBackColor = System.Drawing.Color.White
        Me.propertyGrid.LineColor = System.Drawing.Color.White
        Me.propertyGrid.Location = New System.Drawing.Point(503, 32)
        Me.propertyGrid.Margin = New System.Windows.Forms.Padding(10)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.SelectedObject = Me.gridGroupingControl1
        Me.propertyGrid.Size = New System.Drawing.Size(263, 426)
        Me.propertyGrid.TabIndex = 12
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.DimGray
        Me.panel1.Location = New System.Drawing.Point(496, 42)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1, 410)
        Me.panel1.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(779, 477)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.propertyGrid)
        Me.Controls.Add(Me.gridGroupingControl1)
        Me.DropShadow = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custom Summary Demo"
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
			Application.EnableVisualStyles()
#End If
			Application.Run(New Form1())
		End Sub

	End Class

