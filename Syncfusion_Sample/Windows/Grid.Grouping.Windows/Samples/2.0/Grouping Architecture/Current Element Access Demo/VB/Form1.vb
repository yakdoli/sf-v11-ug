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
Imports System.Diagnostics

Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid

Namespace AccessCurrentElement_2003
	Public Class Form1
		Inherits Syncfusion.Windows.Forms.MetroForm
		Private sqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
		Private sqlSelectCommand1 As System.Data.SqlClient.SqlCommand
		Private sqlInsertCommand1 As System.Data.SqlClient.SqlCommand
		Private sqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
		Private sqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
		Private sqlConnection1 As System.Data.SqlClient.SqlConnection
		Private sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
		Private sqlSelectCommand2 As System.Data.SqlClient.SqlCommand
		Private sqlInsertCommand2 As System.Data.SqlClient.SqlCommand
		Private sqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
		Private sqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
		Private dataset11 As AccessCurrent.Dataset1
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private splitContainerAdv1 As Syncfusion.Windows.Forms.Tools.SplitContainerAdv
		Private panel1 As Panel
		Private label4 As Label
		Private lblElement As Label
		Private label3 As Label
		Private lblCell As Label
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			InitializeComponent()
			Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
			Me.Icon = ico
			Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
			AddHandler gridGroupingControl1.TableControlCurrentCellActivated, AddressOf gridGroupingControl1_TableControlCurrentCellActivated
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

			Dim t As New Timer()
			AddHandler t.Tick, AddressOf t_Tick
			t.Interval = 100
			t.Start()
		End Sub

		Private Sub t_Tick(ByVal sender As Object, ByVal e As EventArgs)
			' Give feedback about current element
			Dim pt As Point = Me.gridGroupingControl1.TableControl.PointToClient(Control.MousePosition)

			If Me.gridGroupingControl1.TableControl.ClientRectangle.Contains(pt) Then
				Dim el As Element = Me.gridGroupingControl1.TableControl.PointToNestedDisplayElement(pt)
				If el IsNot Nothing Then
					Dim r As Record = el.GetRecord()
					If r IsNot Nothing Then
						Me.lblElement.Text = r.ToString()
					Else
						Me.lblElement.Text = el.ToString()
					End If
				End If
			End If
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.sqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
			Me.sqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
			Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
			Me.sqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
			Me.sqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
			Me.sqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
			Me.sqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
			Me.sqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
			Me.sqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
			Me.sqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
			Me.sqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
			Me.dataset11 = New AccessCurrent.Dataset1()
			Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
			Me.splitContainerAdv1 = New Syncfusion.Windows.Forms.Tools.SplitContainerAdv()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.label4 = New System.Windows.Forms.Label()
			Me.lblElement = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.lblCell = New System.Windows.Forms.Label()
			CType(Me.dataset11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitContainerAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerAdv1.Panel1.SuspendLayout()
			Me.splitContainerAdv1.Panel2.SuspendLayout()
			Me.splitContainerAdv1.SuspendLayout()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' sqlDataAdapter1
			' 
			Me.sqlDataAdapter1.DeleteCommand = Me.sqlDeleteCommand1
			Me.sqlDataAdapter1.InsertCommand = Me.sqlInsertCommand1
			Me.sqlDataAdapter1.SelectCommand = Me.sqlSelectCommand1
			Me.sqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Categories", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("Picture", "Picture")})})
			Me.sqlDataAdapter1.UpdateCommand = Me.sqlUpdateCommand1
			' 
			' sqlDeleteCommand1
			' 
			Me.sqlDeleteCommand1.CommandText = "DELETE FROM Categories WHERE (CategoryID = @Original_CategoryID) AND (CategoryNam" & "e = @Original_CategoryName)"
			Me.sqlDeleteCommand1.Connection = Me.sqlConnection1
			Me.sqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() { New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CategoryName", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryName", System.Data.DataRowVersion.Original, Nothing)})
			' 
			' sqlConnection1
			' 
			Me.sqlConnection1.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_sampl" & "es;persist security info=True;user id=sa;packet size=4096;Pooling=true"
			Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
			' 
			' sqlInsertCommand1
			' 
			Me.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText")
			Me.sqlInsertCommand1.Connection = Me.sqlConnection1
			Me.sqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() { New System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15, "CategoryName"), New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 1073741823, "Description"), New System.Data.SqlClient.SqlParameter("@Picture", System.Data.SqlDbType.VarBinary, 2147483647, "Picture")})
			' 
			' sqlSelectCommand1
			' 
			Me.sqlSelectCommand1.CommandText = "SELECT CategoryID, CategoryName, Description, Picture FROM Categories"
			Me.sqlSelectCommand1.Connection = Me.sqlConnection1
			' 
			' sqlUpdateCommand1
			' 
			Me.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText")
			Me.sqlUpdateCommand1.Connection = Me.sqlConnection1
			Me.sqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() { New System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15, "CategoryName"), New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 1073741823, "Description"), New System.Data.SqlClient.SqlParameter("@Picture", System.Data.SqlDbType.VarBinary, 2147483647, "Picture"), New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CategoryName", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID")})
			' 
			' sqlDataAdapter2
			' 
			Me.sqlDataAdapter2.DeleteCommand = Me.sqlDeleteCommand2
			Me.sqlDataAdapter2.InsertCommand = Me.sqlInsertCommand2
			Me.sqlDataAdapter2.SelectCommand = Me.sqlSelectCommand2
			Me.sqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Products", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"), New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"), New System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"), New System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"), New System.Data.Common.DataColumnMapping("Discontinued", "Discontinued")})})
			Me.sqlDataAdapter2.UpdateCommand = Me.sqlUpdateCommand2
			' 
			' sqlDeleteCommand2
			' 
			Me.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText")
			Me.sqlDeleteCommand2.Connection = Me.sqlConnection1
			Me.sqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() { New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ProductID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Discontinued", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ProductName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ReorderLevel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "SupplierID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitPrice", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitsInStock", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, Nothing)})
			' 
			' sqlInsertCommand2
			' 
			Me.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText")
			Me.sqlInsertCommand2.Connection = Me.sqlConnection1
			Me.sqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() { New System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"), New System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"), New System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"), New System.Data.SqlClient.SqlParameter("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, "QuantityPerUnit"), New System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"), New System.Data.SqlClient.SqlParameter("@UnitsInStock", System.Data.SqlDbType.SmallInt, 2, "UnitsInStock"), New System.Data.SqlClient.SqlParameter("@UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, "UnitsOnOrder"), New System.Data.SqlClient.SqlParameter("@ReorderLevel", System.Data.SqlDbType.SmallInt, 2, "ReorderLevel"), New System.Data.SqlClient.SqlParameter("@Discontinued", System.Data.SqlDbType.Bit, 1, "Discontinued")})
			' 
			' sqlSelectCommand2
			' 
			Me.sqlSelectCommand2.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice" & ", UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products"
			Me.sqlSelectCommand2.Connection = Me.sqlConnection1
			' 
			' sqlUpdateCommand2
			' 
			Me.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText")
			Me.sqlUpdateCommand2.Connection = Me.sqlConnection1
			Me.sqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() { New System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"), New System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"), New System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"), New System.Data.SqlClient.SqlParameter("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, "QuantityPerUnit"), New System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"), New System.Data.SqlClient.SqlParameter("@UnitsInStock", System.Data.SqlDbType.SmallInt, 2, "UnitsInStock"), New System.Data.SqlClient.SqlParameter("@UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, "UnitsOnOrder"), New System.Data.SqlClient.SqlParameter("@ReorderLevel", System.Data.SqlDbType.SmallInt, 2, "ReorderLevel"), New System.Data.SqlClient.SqlParameter("@Discontinued", System.Data.SqlDbType.Bit, 1, "Discontinued"), New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ProductID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Discontinued", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ProductName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ReorderLevel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "SupplierID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitPrice", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitsInStock", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID")})
			' 
			' dataset11
			' 
			Me.dataset11.DataSetName = "Dataset1"
			Me.dataset11.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
			Me.gridGroupingControl1.DataSource = Me.dataset11.Categories
			Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gridGroupingControl1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.gridGroupingControl1.Location = New System.Drawing.Point(12, 9)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.Size = New System.Drawing.Size(742, 298)
			Me.gridGroupingControl1.TabIndex = 0
			Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(215))))), (CInt(Fix((CByte(229)))))))
			Me.gridGroupingControl1.Text = "gridGroupingControl1"
            Me.gridGroupingControl1.VersionInfo = "4.201.0.37"
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro

			Me.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedSingle

			' 
			' splitContainerAdv1
			' 
			Me.splitContainerAdv1.BackColor = System.Drawing.Color.White
			Me.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerAdv1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerAdv1.Name = "splitContainerAdv1"
			Me.splitContainerAdv1.Orientation = System.Windows.Forms.Orientation.Vertical
			' 
			' splitContainerAdv1.Panel1
			' 
			Me.splitContainerAdv1.Panel1.BackColor = System.Drawing.Color.White
			Me.splitContainerAdv1.Panel1.Controls.Add(Me.gridGroupingControl1)
			' 
			' splitContainerAdv1.Panel2
			' 
			Me.splitContainerAdv1.Panel2.BackColor = System.Drawing.Color.White
			Me.splitContainerAdv1.Panel2.Controls.Add(Me.panel1)
			Me.splitContainerAdv1.Panel2.ForeColor = System.Drawing.Color.DimGray
			Me.splitContainerAdv1.Size = New System.Drawing.Size(766, 502)
			Me.splitContainerAdv1.SplitterDistance = 310
			Me.splitContainerAdv1.SplitterWidth = 5
			Me.splitContainerAdv1.TabIndex = 6
			Me.splitContainerAdv1.Text = "splitContainerAdv1"
			' 
			' panel1
			' 
			Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel1.Controls.Add(Me.label4)
			Me.panel1.Controls.Add(Me.lblElement)
			Me.panel1.Controls.Add(Me.label3)
			Me.panel1.Controls.Add(Me.lblCell)
			Me.panel1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.panel1.Location = New System.Drawing.Point(12, 7)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(742, 165)
			Me.panel1.TabIndex = 0
			' 
			' label4
			' 
			Me.label4.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label4.Location = New System.Drawing.Point(14, 93)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(112, 23)
			Me.label4.TabIndex = 10
			Me.label4.Text = "Current Cell :"
			' 
			' lblElement
			' 
			Me.lblElement.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.lblElement.Location = New System.Drawing.Point(148, 14)
			Me.lblElement.Name = "lblElement"
			Me.lblElement.Size = New System.Drawing.Size(532, 68)
			Me.lblElement.TabIndex = 8
			' 
			' label3
			' 
			Me.label3.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.Location = New System.Drawing.Point(14, 14)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(128, 23)
			Me.label3.TabIndex = 9
			Me.label3.Text = "Current Element :"
			' 
			' lblCell
			' 
			Me.lblCell.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.lblCell.Location = New System.Drawing.Point(148, 85)
			Me.lblCell.Name = "lblCell"
			Me.lblCell.Size = New System.Drawing.Size(532, 72)
			Me.lblCell.TabIndex = 7
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(766, 502)
			Me.Controls.Add(Me.splitContainerAdv1)
			Me.DropShadow = True
			Me.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Access Current Element-Cell Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.dataset11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerAdv1.Panel1.ResumeLayout(False)
			Me.splitContainerAdv1.Panel2.ResumeLayout(False)
			CType(Me.splitContainerAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerAdv1.ResumeLayout(False)
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

			ReadXml(Me.dataset11,"CatProd.xml")
			Me.gridGroupingControl1.Table.ExpandAllRecords()
		End Sub

		Private Sub ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String)
			For n As Integer = 0 To 9
				If System.IO.File.Exists(xmlFileName) Then
					ds.ReadXml(xmlFileName)
					Exit For
				End If
				xmlFileName = "..\" & xmlFileName
			Next n
		End Sub

		Private Function GetNestedCurrentElement() As Element
			' Retrieve the current element
			Dim el As Element = Me.gridGroupingControl1.Table.CurrentElement
			' Check whether it is in child table or in parent table
			Do While TypeOf el Is NestedTable
				' Displaying the Current Record/Element from child table
				Dim nt As GridNestedTable = CType(el, GridNestedTable)
				el = nt.ChildTable.ParentTable.CurrentElement
			Loop
			Return el
		End Function

		Private Sub gridGroupingControl1_TableControlCurrentCellActivated(ByVal sender As Object, ByVal e As GridTableControlEventArgs)
			' Retrieve the current element
			Dim el As Element = GetNestedCurrentElement()

			If el IsNot Nothing Then
				Dim r As Record = el.GetRecord()

				' current field.

				If r IsNot Nothing Then
					Dim table As GridTable = CType(r.ParentDetails.ParentChildTable.ParentTable, GridTable)

					Dim fd As FieldDescriptor = table.CurrentRecordManager.CurrentField
					If fd IsNot Nothing Then
						Me.lblCell.Text = r.GetValue(fd.Name).ToString()

						' TableCellStyle
						Dim style As GridTableCellStyleInfo = table.GetTableCellStyle(r, fd)
						Me.lblCell.Text &= " (" & style.ToString().Replace(ControlChars.Lf, ";"c) & ")"

						Dim identity As GridTableCellStyleInfoIdentity = style.TableCellIdentity

						' you can check identity for more information about cell.
					End If
				End If
				' Record
				Me.lblElement.Text = el.ToString()
			End If
		End Sub

	End Class
End Namespace
