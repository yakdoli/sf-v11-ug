#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Grouping

Namespace Grouping_GGC
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		Private array As New ArrayList()
		Private oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
		Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
		Private dataset11 As Grouping_GGC.Dataset1
		Private panel1 As Panel
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private label1 As Label
		Private WithEvents checkBox4 As CheckBoxAdv
		Private groupBox1 As GroupBox
		Private colorPickerButton1 As ColorPickerButton
		Private WithEvents checkBox3 As CheckBoxAdv
		Private WithEvents checkBox2 As CheckBoxAdv
		Private WithEvents checkBox1 As CheckBoxAdv
		Private toolTip1 As ToolTip
		Private WithEvents checkBoxAdv As CheckBoxAdv
		Private label2 As Label
		Private WithEvents radioButtonAdv1 As RadioButtonAdv
		Private components As IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			'this.oleDbDataAdapter1.Fill(this.dataset11);   
			ReadXml(Me.dataset11,"Grouping_GGCdata.xml")
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana"
			Me.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue
			Me.BackColor = Color.White
			Me.DropShadow = True
			Me.gridGroupingControl1.TableModel.EnableLegacyStyle = False
			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
			Me.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro
			Me.gridGroupingControl1.Table.ExpandAllRecords()
			Me.gridGroupingControl1.HierarchicalGroupDropArea = True
			Me.gridGroupingControl1.GridGroupDropArea.AllowRemove = True
			Me.gridGroupingControl1.GridGroupDropArea.DynamicResizing = True
			AddHandler gridGroupingControl1.TableDescriptor.GroupedColumns.Changed, AddressOf GroupedColumns_Changed
			AddHandler colorPickerButton1.ColorSelected, AddressOf colorPickerButton1_ColorSelected

		End Sub

		Private Sub GroupedColumns_Changed(ByVal sender As Object, ByVal e As Syncfusion.Collections.ListPropertyChangedEventArgs)
			If e.Item IsNot Nothing Then
				Dim item As SortColumnDescriptor = CType(e.Item, SortColumnDescriptor)
				If Not array.Contains(item.Name) Then
					array.Add(item.Name)
				End If
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


		Private Sub ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String)
			For n As Integer = 0 To 9
				If System.IO.File.Exists(xmlFileName) Then
					ds.ReadXml(xmlFileName)
					Exit For
				End If
				xmlFileName = "..\" & xmlFileName
			Next n
		End Sub
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.dataset11 = New Grouping_GGC.Dataset1()
			Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
			Me.oleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection()
			Me.oleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
			Me.label1 = New System.Windows.Forms.Label()
			Me.checkBox4 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.radioButtonAdv1 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
			Me.label2 = New System.Windows.Forms.Label()
			Me.checkBoxAdv = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.checkBox3 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.checkBox2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.checkBox1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
			CType(Me.dataset11, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			CType(Me.radioButtonAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxAdv, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataset11
			' 
			Me.dataset11.DataSetName = "Dataset1"
			Me.dataset11.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' oleDbDataAdapter1
			' 
			Me.oleDbDataAdapter1.DeleteCommand = Me.oleDbDeleteCommand1
			Me.oleDbDataAdapter1.InsertCommand = Me.oleDbInsertCommand1
			Me.oleDbDataAdapter1.SelectCommand = Me.oleDbSelectCommand1
			Me.oleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Employees", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("Title", "Title"), New System.Data.Common.DataColumnMapping("BirthDate", "BirthDate"), New System.Data.Common.DataColumnMapping("HireDate", "HireDate"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Region", "Region"), New System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("HomePhone", "HomePhone")})})
			Me.oleDbDataAdapter1.UpdateCommand = Me.oleDbUpdateCommand1
			' 
			' oleDbDeleteCommand1
			' 
			Me.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText")
			Me.oleDbDeleteCommand1.Connection = Me.oleDbConnection1
			Me.oleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BirthDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "BirthDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BirthDate1", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "BirthDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "FirstName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HireDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "HireDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HireDate1", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "HireDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HomePhone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "HomePhone", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HomePhone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "HomePhone", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "LastName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_PostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Region", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Region", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Title", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Title1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Title", System.Data.DataRowVersion.Original, Nothing)})
			' 
			' oleDbConnection1
			' 
			Me.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString")
			' 
			' oleDbInsertCommand1
			' 
			Me.oleDbInsertCommand1.CommandText = resources.GetString("oleDbInsertCommand1.CommandText")
			Me.oleDbInsertCommand1.Connection = Me.oleDbConnection1
			Me.oleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 20, "LastName"), New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"), New System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 30, "Title"), New System.Data.OleDb.OleDbParameter("BirthDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, "BirthDate"), New System.Data.OleDb.OleDbParameter("HireDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, "HireDate"), New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"), New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"), New System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"), New System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"), New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"), New System.Data.OleDb.OleDbParameter("HomePhone", System.Data.OleDb.OleDbType.VarWChar, 24, "HomePhone")})
			' 
			' oleDbSelectCommand1
			' 
			Me.oleDbSelectCommand1.CommandText = "SELECT EmployeeID, LastName, FirstName, Title, BirthDate, HireDate, Address, City" & ", Region, PostalCode, Country, HomePhone FROM Employees"
			Me.oleDbSelectCommand1.Connection = Me.oleDbConnection1
			' 
			' oleDbUpdateCommand1
			' 
			Me.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText")
			Me.oleDbUpdateCommand1.Connection = Me.oleDbConnection1
			Me.oleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 20, "LastName"), New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"), New System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 30, "Title"), New System.Data.OleDb.OleDbParameter("BirthDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, "BirthDate"), New System.Data.OleDb.OleDbParameter("HireDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, "HireDate"), New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"), New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"), New System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"), New System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"), New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"), New System.Data.OleDb.OleDbParameter("HomePhone", System.Data.OleDb.OleDbType.VarWChar, 24, "HomePhone"), New System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BirthDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "BirthDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_BirthDate1", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "BirthDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "FirstName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HireDate", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "HireDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HireDate1", System.Data.OleDb.OleDbType.DBTimeStamp, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "HireDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HomePhone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "HomePhone", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HomePhone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "HomePhone", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "LastName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_PostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Region", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Region", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Title", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Title1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Title", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Select_EmployeeID", System.Data.OleDb.OleDbType.Integer, 4, "EmployeeID")})
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.gridGroupingControl1)
			Me.panel1.Location = New System.Drawing.Point(12, 24)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(702, 431)
			Me.panel1.TabIndex = 0
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
			Me.gridGroupingControl1.DataSource = Me.dataset11.Employees
			Me.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridGroupingControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.ShowGroupDropArea = True
			Me.gridGroupingControl1.Size = New System.Drawing.Size(702, 431)
			Me.gridGroupingControl1.TabIndex = 1
			Me.gridGroupingControl1.TableDescriptor.AllowNew = False
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235)))))))
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208)))))))
			Me.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
			Me.gridGroupingControl1.TableDescriptor.PrimaryKeyColumns.AddRange(New Syncfusion.Grouping.SortColumnDescriptor() { New Syncfusion.Grouping.SortColumnDescriptor("EmployeeID", System.ComponentModel.ListSortDirection.Ascending)})
			Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
			Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 25
			Me.gridGroupingControl1.Text = "gridGroupingControl1"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(731, 37)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(239, 13)
			Me.label1.TabIndex = 11
			Me.label1.Text = "Please check tooltip for corresponding codes"
			' 
			' checkBox4
			' 
			Me.checkBox4.Checked = True
			Me.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox4.DrawFocusRectangle = False
			Me.checkBox4.Location = New System.Drawing.Point(28, 28)
			Me.checkBox4.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBox4.Name = "checkBox4"
			Me.checkBox4.Size = New System.Drawing.Size(174, 35)
			Me.checkBox4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBox4.TabIndex = 12
			Me.checkBox4.Text = "Hierarchical GroupDrop Area"
			Me.checkBox4.ThemesEnabled = False
			Me.toolTip1.SetToolTip(Me.checkBox4, "this.gridGroupingControl1.HierarchicalGroupDropArea")
'			Me.checkBox4.CheckStateChanged += New System.EventHandler(Me.checkBox4_CheckStateChanged)
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.radioButtonAdv1)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.checkBoxAdv)
			Me.groupBox1.Controls.Add(Me.colorPickerButton1)
			Me.groupBox1.Controls.Add(Me.checkBox4)
			Me.groupBox1.Controls.Add(Me.checkBox3)
			Me.groupBox1.Controls.Add(Me.checkBox2)
			Me.groupBox1.Controls.Add(Me.checkBox1)
			Me.groupBox1.Location = New System.Drawing.Point(734, 67)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(269, 388)
			Me.groupBox1.TabIndex = 10
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Options"
			' 
			' radioButtonAdv1
			' 
			Me.radioButtonAdv1.DrawFocusRectangle = False
			Me.radioButtonAdv1.Location = New System.Drawing.Point(28, 166)
			Me.radioButtonAdv1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.radioButtonAdv1.Name = "radioButtonAdv1"
			Me.radioButtonAdv1.Size = New System.Drawing.Size(146, 30)
			Me.radioButtonAdv1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
			Me.radioButtonAdv1.TabIndex = 15
			Me.radioButtonAdv1.Text = "Show image in Headers"
			Me.radioButtonAdv1.ThemesEnabled = False
			Me.toolTip1.SetToolTip(Me.radioButtonAdv1, "this.gridGroupingControl1.TableDescriptor.Columns[Name]HeaderImage")
'			Me.radioButtonAdv1.CheckChanged += New System.EventHandler(Me.radioButtonAdv1_CheckChanged)
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(17, 244)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(204, 87)
			Me.label2.TabIndex = 14
			Me.label2.Text = "Once Merge Cell option is selected,  the Grid's layout will remains merged furthe" & "r and " & Constants.vbCrLf & Constants.vbCrLf & "Merged state will be sustained even with Sorting and Grouping."
			' 
			' checkBoxAdv
			' 
			Me.checkBoxAdv.DrawFocusRectangle = False
			Me.checkBoxAdv.Location = New System.Drawing.Point(28, 339)
			Me.checkBoxAdv.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBoxAdv.Name = "checkBoxAdv"
			Me.checkBoxAdv.Size = New System.Drawing.Size(135, 29)
			Me.checkBoxAdv.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBoxAdv.TabIndex = 13
			Me.checkBoxAdv.Text = "Merge Cells"
			Me.checkBoxAdv.ThemesEnabled = False
			Me.toolTip1.SetToolTip(Me.checkBoxAdv, "this.gridGroupingControl1.TableModel.Options.MergeCellsMode")
'			Me.checkBoxAdv.CheckStateChanged += New System.EventHandler(Me.checkBoxAdv_CheckStateChanged)
			' 
			' colorPickerButton1
			' 
			Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
			Me.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand
			Me.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.colorPickerButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
			Me.colorPickerButton1.Location = New System.Drawing.Point(28, 205)
			Me.colorPickerButton1.Name = "colorPickerButton1"
			Me.colorPickerButton1.SelectedAsBackcolor = True
			Me.colorPickerButton1.Size = New System.Drawing.Size(135, 23)
			Me.colorPickerButton1.TabIndex = 6
			Me.colorPickerButton1.Text = "TreeLine Color"
			Me.toolTip1.SetToolTip(Me.colorPickerButton1, "this.gridGroupingControl1.GridGroupDropArea.TreeLineColor")
			Me.colorPickerButton1.UseVisualStyleBackColor = False
			' 
			' checkBox3
			' 
			Me.checkBox3.Checked = True
			Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox3.DrawFocusRectangle = False
			Me.checkBox3.Location = New System.Drawing.Point(28, 133)
			Me.checkBox3.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBox3.Name = "checkBox3"
			Me.checkBox3.Size = New System.Drawing.Size(136, 30)
			Me.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBox3.TabIndex = 6
			Me.checkBox3.Text = "Dynamic Resizing"
			Me.checkBox3.ThemesEnabled = False
			Me.toolTip1.SetToolTip(Me.checkBox3, "this.gridGroupingControl1.GridGroupDropArea.DynamicResizing")
'			Me.checkBox3.CheckStateChanged += New System.EventHandler(Me.checkBox3_CheckStateChanged)
			' 
			' checkBox2
			' 
			Me.checkBox2.DrawFocusRectangle = False
			Me.checkBox2.Location = New System.Drawing.Point(28, 98)
			Me.checkBox2.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBox2.Name = "checkBox2"
			Me.checkBox2.Size = New System.Drawing.Size(172, 36)
			Me.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBox2.TabIndex = 5
			Me.checkBox2.Text = "TreeLinePlacement at Top"
			Me.checkBox2.ThemesEnabled = False
			Me.toolTip1.SetToolTip(Me.checkBox2, "this.gridGroupingControl1.GridGroupDropArea.TreeLinePlacement")
'			Me.checkBox2.CheckStateChanged += New System.EventHandler(Me.checkBox2_CheckStateChanged)
			' 
			' checkBox1
			' 
			Me.checkBox1.Checked = True
			Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox1.DrawFocusRectangle = False
			Me.checkBox1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox1.Location = New System.Drawing.Point(28, 66)
			Me.checkBox1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(122, 33)
			Me.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBox1.TabIndex = 4
			Me.checkBox1.Text = "Remove Group"
			Me.checkBox1.ThemesEnabled = False
			Me.toolTip1.SetToolTip(Me.checkBox1, "this.gridGroupingControl1.GridGroupDropArea.AllowRemove")
'			Me.checkBox1.CheckStateChanged += New System.EventHandler(Me.checkBox1_CheckStateChanged)
			' 
			' toolTip1
			' 
			Me.toolTip1.IsBalloon = True
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(1027, 467)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.panel1)
			Me.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Grouping Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.dataset11, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			CType(Me.radioButtonAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxAdv, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		#Region "Event Handlers related with Hierarchical GroupDrop Area"

		Private Sub colorPickerButton1_ColorSelected(ByVal sender As Object, ByVal e As EventArgs)
			Me.gridGroupingControl1.GridGroupDropArea.TreeLineColor = Me.colorPickerButton1.SelectedColor
			Me.gridGroupingControl1.Refresh()
		End Sub

		Private Sub checkBox1_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckStateChanged
			Me.gridGroupingControl1.GridGroupDropArea.AllowRemove = Not Me.gridGroupingControl1.GridGroupDropArea.AllowRemove
			Me.gridGroupingControl1.Refresh()
		End Sub

		Private Sub checkBox2_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckStateChanged
			If Me.gridGroupingControl1.GridGroupDropArea.TreeLinePlacement = TreeLinePlacement.Bottom Then
				Me.gridGroupingControl1.GridGroupDropArea.TreeLinePlacement = TreeLinePlacement.Top
			Else
				Me.gridGroupingControl1.GridGroupDropArea.TreeLinePlacement = TreeLinePlacement.Bottom
			End If
			Me.gridGroupingControl1.Refresh()
		End Sub

		Private Sub checkBox3_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckStateChanged
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear()
			Me.gridGroupingControl1.GridGroupDropArea.DynamicResizing = Not Me.gridGroupingControl1.GridGroupDropArea.DynamicResizing
			Me.gridGroupingControl1.SuspendLayout()
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear()
			For i As Integer = 0 To array.Count - 1
				Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add(array(i).ToString())
			Next i
			Me.gridGroupingControl1.ResumeLayout()
			Me.gridGroupingControl1.Refresh()
		End Sub

		Private Sub checkBox4_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox4.CheckStateChanged
			Me.gridGroupingControl1.BeginUpdate()
			Me.gridGroupingControl1.HierarchicalGroupDropArea = Not Me.gridGroupingControl1.HierarchicalGroupDropArea
			Me.gridGroupingControl1.EndUpdate(True)
			CheckBoxSettings()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			CheckBoxSettings()
		End Sub

		Private Sub CheckBoxSettings()
			If Not Me.checkBox4.Checked Then
				Me.checkBox2.Enabled = False
				Me.checkBox2.Font = New Font("Segoe UI", 8.25F, FontStyle.Strikeout)
				Me.checkBox3.Enabled = False
				Me.checkBox3.Font = New Font("Segoe UI", 8.25F, FontStyle.Strikeout)
				Me.colorPickerButton1.Enabled = False
				Me.colorPickerButton1.Font = New Font("Segoe UI", 8.25F, FontStyle.Strikeout)
			Else
				Me.checkBox2.Enabled = True
				Me.checkBox2.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular)
				Me.checkBox3.Enabled = True
				Me.checkBox3.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular)
				Me.colorPickerButton1.Enabled = True
				Me.colorPickerButton1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular)
			End If
		End Sub
		#End Region

		#Region "Event Handler for Merge Cells Layout"

		Private Sub checkBoxAdv_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv.CheckStateChanged
			If Me.checkBoxAdv.Checked Then
				Me.gridGroupingControl1.BeginUpdate()
				Me.gridGroupingControl1.TableDescriptor.Columns("Title").Appearance.AnyRecordFieldCell.MergeCell = GridMergeCellDirection.Both
				Me.gridGroupingControl1.TableModel.Options.MergeCellsMode = GridMergeCellsMode.OnDemandCalculation Or GridMergeCellsMode.MergeRowsInColumn Or GridMergeCellsMode.MergeColumnsInRow
				Me.gridGroupingControl1.TableModel.Options.MergeCellsLayout = GridMergeCellsLayout.Grid
				Me.gridGroupingControl1.TableModel.MergeCells.EvaluateMergeCells(Me.gridGroupingControl1.TableControl.GridCellsRange)
				Me.gridGroupingControl1.EndUpdate(True)
				Me.gridGroupingControl1.Refresh()
			Else
				Me.gridGroupingControl1.BeginUpdate()
				Me.gridGroupingControl1.TableDescriptor.Columns("Title").Appearance.AnyRecordFieldCell.MergeCell = GridMergeCellDirection.None
				Me.gridGroupingControl1.TableModel.Options.MergeCellsMode = GridMergeCellsMode.None
				Me.gridGroupingControl1.TableModel.Options.MergeCellsLayout = GridMergeCellsLayout.Grid
				Me.gridGroupingControl1.TableModel.MergeCells.EvaluateMergeCells(Me.gridGroupingControl1.TableControl.GridCellsRange)
				Me.gridGroupingControl1.EndUpdate(True)
				Me.gridGroupingControl1.Refresh()
			End If
		End Sub

		#End Region

		#Region "Event Handler for image in headers"

		Private Sub radioButtonAdv1_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv1.CheckChanged
			Me.gridGroupingControl1.BeginUpdate()
			Me.gridGroupingControl1.TableDescriptor.Columns("EmployeeID").HeaderImage = Image.FromFile(GetIconFile("common\Images\Grid\HeaderImages\ID.PNG"))
			Me.gridGroupingControl1.TableDescriptor.Columns("BirthDate").HeaderImage = Image.FromFile(GetIconFile("common\Images\Grid\HeaderImages\Date.PNG"))
			Me.gridGroupingControl1.TableDescriptor.Columns("HireDate").HeaderImage = Image.FromFile(GetIconFile("common\Images\Grid\HeaderImages\Date.PNG"))
			Me.gridGroupingControl1.TableDescriptor.Columns("LastName").HeaderImage = Image.FromFile(GetIconFile("common\Images\Grid\HeaderImages\Customer.PNG"))
			Me.gridGroupingControl1.TableDescriptor.Columns("LastName").HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Right
			Me.gridGroupingControl1.TableDescriptor.Columns("Title").HeaderImage = Image.FromFile(GetIconFile("common\Images\Grid\HeaderImages\Contact.PNG"))
			Me.gridGroupingControl1.TableDescriptor.Columns("FirstName").HeaderImage = Image.FromFile(GetIconFile("common\Images\Grid\HeaderImages\Customer.PNG"))
			Me.gridGroupingControl1.TableDescriptor.Columns("FirstName").HeaderImageAlignment = Syncfusion.Windows.Forms.Grid.Grouping.HeaderImageAlignment.Right
			Me.gridGroupingControl1.TableDescriptor.Columns("Address").HeaderImage = Image.FromFile(GetIconFile("common\Images\Grid\HeaderImages\Address.PNG"))
			Me.gridGroupingControl1.EndUpdate(True)
			Me.gridGroupingControl1.Refresh()
			Me.gridGroupingControl1.Invalidate()
			Me.gridGroupingControl1.TableControl.RefreshRange(GridRangeInfo.Table())
		End Sub
		#End Region

	End Class
End Namespace
