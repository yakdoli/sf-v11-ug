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

Namespace Grouping_GGC
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		Private oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
		Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
        Private dataset11 As Dataset1
		Private panel1 As Panel
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private propertyGrid1 As PropertyGrid
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
            Me.dataset11 = New Dataset1()
			ReadXml(Me.dataset11,"Grouping.xml")
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

            Me.dataset11.DataSetName = "Dataset1"
            Me.dataset11.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            Me.gridGroupingControl1.DataSource = Me.dataset11.Employees
			Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro
			Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana"
			Me.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue
			Me.BackColor = Color.White
			Me.DropShadow = True
			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
			Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1

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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))            '  
			Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
			Me.oleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection()
			Me.oleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
			Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
            'CType(Me.dataset11, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataset11
			' 
			
			' 
			' oleDbDataAdapter1
			' 
			Me.oleDbDataAdapter1.DeleteCommand = Me.oleDbDeleteCommand1
			Me.oleDbDataAdapter1.InsertCommand = Me.oleDbInsertCommand1
			Me.oleDbDataAdapter1.SelectCommand = Me.oleDbSelectCommand1
			Me.oleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Employees", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("Title", "Title"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Country", "Country")})})
			Me.oleDbDataAdapter1.UpdateCommand = Me.oleDbUpdateCommand1
			' 
			' oleDbDeleteCommand1
			' 
			Me.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText")
			Me.oleDbDeleteCommand1.Connection = Me.oleDbConnection1
			Me.oleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "FirstName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "LastName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Title", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Title1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Title", System.Data.DataRowVersion.Original, Nothing)})
			' 
			' oleDbConnection1
			' 
			Me.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString")
			' 
			' oleDbInsertCommand1
			' 
			Me.oleDbInsertCommand1.CommandText = "INSERT INTO Employees(LastName, FirstName, Title, Address, City, Country) VALUES " & "(?, ?, ?, ?, ?, ?)"
			Me.oleDbInsertCommand1.Connection = Me.oleDbConnection1
			Me.oleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 20, "LastName"), New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"), New System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 30, "Title"), New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"), New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"), New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country")})
			' 
			' oleDbSelectCommand1
			' 
			Me.oleDbSelectCommand1.CommandText = "SELECT EmployeeID, LastName, FirstName, Title, Address, City, Country FROM Employ" & "ees"
			Me.oleDbSelectCommand1.Connection = Me.oleDbConnection1
			' 
			' oleDbUpdateCommand1
			' 
			Me.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText")
			Me.oleDbUpdateCommand1.Connection = Me.oleDbConnection1
			Me.oleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 20, "LastName"), New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"), New System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 30, "Title"), New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"), New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"), New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"), New System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "FirstName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "LastName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Title", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Title1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Title", System.Data.DataRowVersion.Original, Nothing)})
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.gridGroupingControl1)
			Me.panel1.Location = New System.Drawing.Point(26, 12)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(497, 303)
			Me.panel1.TabIndex = 0
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
			Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = False

			Me.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridGroupingControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.ShowGroupDropArea = True
			Me.gridGroupingControl1.Size = New System.Drawing.Size(497, 303)
			Me.gridGroupingControl1.TabIndex = 2
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.AddRange(New Syncfusion.Grouping.SortColumnDescriptor() { New Syncfusion.Grouping.SortColumnDescriptor("Title", System.ComponentModel.ListSortDirection.Ascending), New Syncfusion.Grouping.SortColumnDescriptor("Country", System.ComponentModel.ListSortDirection.Ascending)})
			Me.gridGroupingControl1.Text = "gridGroupingControl1"
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			' 
			' propertyGrid1
			' 
			Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
			Me.propertyGrid1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
			Me.propertyGrid1.LineColor = System.Drawing.Color.White
			Me.propertyGrid1.Location = New System.Drawing.Point(558, 12)
			Me.propertyGrid1.Name = "propertyGrid1"
			Me.propertyGrid1.Size = New System.Drawing.Size(222, 303)
			Me.propertyGrid1.TabIndex = 1
			Me.propertyGrid1.BackColor = Color.White

			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(806, 341)
			Me.Controls.Add(Me.propertyGrid1)
			Me.Controls.Add(Me.panel1)
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Multi Column Grouping Demo"

            'CType(Me.dataset11, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

	End Class
End Namespace
