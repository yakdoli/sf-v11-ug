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
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms

Namespace ChildGroupOptions
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		#Region "Private Members"
		Private panel1 As System.Windows.Forms.Panel
		Private panel3 As System.Windows.Forms.Panel
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private panel4 As System.Windows.Forms.Panel
		Private label1 As System.Windows.Forms.Label
		Private oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
		Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
		Private dataSet11 As ChildGroupOptions.DataSet1
		Private label2 As System.Windows.Forms.Label
		Private WithEvents afterDetails As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents beforeDetails As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents captionText As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents showCaption As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents ShowCaptionPlus As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private lblPropertyDisplay As System.Windows.Forms.Label
		Private lblProperty As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private components As IContainer
		Private panel5 As Panel
		Private tipDesc As ToolTip
		Private Const connection As String = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""{0}"";Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False"
		#End Region

		Public Sub New()
'			#Region "GridSettings"
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
			Me.Icon = ico
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana"
			Me.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue
			' 
			' oleDbConnection1
			' 
			Dim mdbFileName As String = FindDatabase("Common\Data\ACC.mdb")
			Me.oleDbConnection1.ConnectionString = String.Format(Form1.connection, mdbFileName)
			Me.oleDbDataAdapter1.Fill(Me.dataSet11)

			' These columns are programatically grouped to demonstrate the ChildGroupOptions.. 
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("Sport")
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("wins",ListSortDirection.Descending)
			' Expand some nodes..
			Me.gridGroupingControl1.Table.TopLevelGroup.Groups(1).IsExpanded = True
			Me.gridGroupingControl1.Table.TopLevelGroup.Groups(1).Groups(1).IsExpanded = True
			Me.gridGroupingControl1.Table.TopLevelGroup.Groups(1).Groups(3).IsExpanded = True

			oldStyle = Me.gridGroupingControl1.ChildGroupOptions.CaptionText

			Me.SetStyle(ControlStyles.UserPaint, True)
			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
			Me.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro
'			#End Region
		End Sub
		#Region "Icon and Data files"
		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function


		Private Function FindDatabase(ByVal mdbFileName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(mdbFileName) Then
					Return mdbFileName
				End If
				mdbFileName = "..\" & mdbFileName
			Next n
			Return ""
		End Function
		#End Region

		#Region "Form Handlers"
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
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.label2 = New System.Windows.Forms.Label()
			Me.afterDetails = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.beforeDetails = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.captionText = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.showCaption = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.ShowCaptionPlus = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.label1 = New System.Windows.Forms.Label()
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.lblProperty = New System.Windows.Forms.Label()
			Me.lblPropertyDisplay = New System.Windows.Forms.Label()
			Me.panel4 = New System.Windows.Forms.Panel()
			Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
			Me.dataSet11 = New ChildGroupOptions.DataSet1()
			Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
			Me.oleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection()
			Me.oleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.panel5 = New System.Windows.Forms.Panel()
			Me.tipDesc = New System.Windows.Forms.ToolTip(Me.components)
			Me.panel1.SuspendLayout()
			CType(Me.afterDetails, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.beforeDetails, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.captionText, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.showCaption, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ShowCaptionPlus, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel3.SuspendLayout()
			Me.panel4.SuspendLayout()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel5.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Controls.Add(Me.afterDetails)
			Me.panel1.Controls.Add(Me.beforeDetails)
			Me.panel1.Controls.Add(Me.captionText)
			Me.panel1.Controls.Add(Me.showCaption)
			Me.panel1.Controls.Add(Me.ShowCaptionPlus)
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.panel1.ForeColor = System.Drawing.Color.DimGray
			Me.panel1.Location = New System.Drawing.Point(608, 4)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(183, 386)
			Me.panel1.TabIndex = 0
			' 
			' label2
			' 
			Me.label2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Location = New System.Drawing.Point(8, 168)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(176, 23)
			Me.label2.TabIndex = 21
			Me.label2.Text = "Add New Record Field"
			' 
			' afterDetails
			' 
			Me.afterDetails.DrawFocusRectangle = False
			Me.afterDetails.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.afterDetails.Location = New System.Drawing.Point(16, 232)
			Me.afterDetails.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.afterDetails.Name = "afterDetails"
			Me.afterDetails.Size = New System.Drawing.Size(136, 24)
			Me.afterDetails.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.afterDetails.TabIndex = 20
			Me.afterDetails.Text = "After Details"
			Me.afterDetails.ThemesEnabled = False
'			Me.afterDetails.CheckStateChanged += New System.EventHandler(Me.afterDetails_CheckStateChanged)
			' 
			' beforeDetails
			' 
			Me.beforeDetails.Checked = True
			Me.beforeDetails.CheckState = System.Windows.Forms.CheckState.Checked
			Me.beforeDetails.DrawFocusRectangle = False
			Me.beforeDetails.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.beforeDetails.Location = New System.Drawing.Point(16, 200)
			Me.beforeDetails.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.beforeDetails.Name = "beforeDetails"
			Me.beforeDetails.Size = New System.Drawing.Size(136, 24)
			Me.beforeDetails.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.beforeDetails.TabIndex = 19
			Me.beforeDetails.Text = "Before Details"
			Me.beforeDetails.ThemesEnabled = False
'			Me.beforeDetails.CheckStateChanged += New System.EventHandler(Me.beforeDetails_CheckStateChanged)
			' 
			' captionText
			' 
			Me.captionText.DrawFocusRectangle = False
			Me.captionText.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.captionText.Location = New System.Drawing.Point(16, 119)
			Me.captionText.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.captionText.Name = "captionText"
			Me.captionText.Size = New System.Drawing.Size(146, 24)
			Me.captionText.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.captionText.TabIndex = 18
			Me.captionText.Text = "Modify Caption Text"
			Me.captionText.ThemesEnabled = False
'			Me.captionText.CheckStateChanged += New System.EventHandler(Me.captionText_CheckStateChanged)
			' 
			' showCaption
			' 
			Me.showCaption.Checked = True
			Me.showCaption.CheckState = System.Windows.Forms.CheckState.Checked
			Me.showCaption.DrawFocusRectangle = False
			Me.showCaption.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.showCaption.Location = New System.Drawing.Point(16, 87)
			Me.showCaption.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.showCaption.Name = "showCaption"
			Me.showCaption.Size = New System.Drawing.Size(146, 24)
			Me.showCaption.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.showCaption.TabIndex = 17
			Me.showCaption.Text = "Show Caption"
			Me.showCaption.ThemesEnabled = False
'			Me.showCaption.CheckStateChanged += New System.EventHandler(Me.showCaption_CheckStateChanged)
			' 
			' ShowCaptionPlus
			' 
			Me.ShowCaptionPlus.Checked = True
			Me.ShowCaptionPlus.CheckState = System.Windows.Forms.CheckState.Checked
			Me.ShowCaptionPlus.DrawFocusRectangle = False
			Me.ShowCaptionPlus.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.ShowCaptionPlus.Location = New System.Drawing.Point(16, 57)
			Me.ShowCaptionPlus.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ShowCaptionPlus.Name = "ShowCaptionPlus"
			Me.ShowCaptionPlus.Size = New System.Drawing.Size(136, 24)
			Me.ShowCaptionPlus.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.ShowCaptionPlus.TabIndex = 16
			Me.ShowCaptionPlus.Text = "Show Caption +/-"
			Me.ShowCaptionPlus.ThemesEnabled = False
'			Me.ShowCaptionPlus.CheckStateChanged += New System.EventHandler(Me.ShowCaptionPlus_CheckStateChanged)
			' 
			' label1
			' 
			Me.label1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(8, 25)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(160, 23)
			Me.label1.TabIndex = 9
			Me.label1.Text = "Child Group Options"
			' 
			' panel3
			' 
			Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel3.Controls.Add(Me.label4)
			Me.panel3.Controls.Add(Me.label3)
			Me.panel3.Controls.Add(Me.lblProperty)
			Me.panel3.Controls.Add(Me.lblPropertyDisplay)
			Me.panel3.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.panel3.ForeColor = System.Drawing.Color.DimGray
			Me.panel3.Location = New System.Drawing.Point(9, 399)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(785, 118)
			Me.panel3.TabIndex = 4
			' 
			' label4
			' 
			Me.label4.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label4.Location = New System.Drawing.Point(24, 72)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(192, 23)
			Me.label4.TabIndex = 3
			Me.label4.Text = "Changed Property :"
			' 
			' label3
			' 
			Me.label3.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.Location = New System.Drawing.Point(24, 16)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(192, 40)
			Me.label3.TabIndex = 2
			Me.label3.Text = "Changed ChildGroup Options Property :"
			' 
			' lblProperty
			' 
			Me.lblProperty.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.lblProperty.Location = New System.Drawing.Point(218, 72)
			Me.lblProperty.Name = "lblProperty"
			Me.lblProperty.Size = New System.Drawing.Size(566, 40)
			Me.lblProperty.TabIndex = 1
			' 
			' lblPropertyDisplay
			' 
			Me.lblPropertyDisplay.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.lblPropertyDisplay.Location = New System.Drawing.Point(218, 16)
			Me.lblPropertyDisplay.Name = "lblPropertyDisplay"
			Me.lblPropertyDisplay.Size = New System.Drawing.Size(569, 40)
			Me.lblPropertyDisplay.TabIndex = 0
			' 
			' panel4
			' 
			Me.panel4.Controls.Add(Me.gridGroupingControl1)
			Me.panel4.Controls.Add(Me.panel1)
			Me.panel4.Location = New System.Drawing.Point(3, 1)
			Me.panel4.Name = "panel4"
			Me.panel4.Size = New System.Drawing.Size(791, 517)
			Me.panel4.TabIndex = 6
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
			Me.gridGroupingControl1.DataSource = Me.dataSet11.Statistics
			Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gridGroupingControl1.ForeColor = System.Drawing.Color.DimGray
			Me.gridGroupingControl1.Location = New System.Drawing.Point(6, 4)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.ShowGroupDropArea = True
			Me.gridGroupingControl1.Size = New System.Drawing.Size(593, 386)
			Me.gridGroupingControl1.TabIndex = 0
			Me.gridGroupingControl1.TableDescriptor.Columns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor() { New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ID"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("losses"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("School"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("Sport"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ties"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("wins"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("year")})
			Me.gridGroupingControl1.TableDescriptor.PrimaryKeyColumns.AddRange(New Syncfusion.Grouping.SortColumnDescriptor() { New Syncfusion.Grouping.SortColumnDescriptor("ID", System.ComponentModel.ListSortDirection.Ascending)})
			Me.gridGroupingControl1.TableDescriptor.VisibleColumns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor() { New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ID"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("losses"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("School"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Sport"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ties"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("wins"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("year")})
			Me.gridGroupingControl1.Text = "gridGroupingControl1"
			Me.gridGroupingControl1.VersionInfo = "4.201.0.37"
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' oleDbDataAdapter1
			' 
			Me.oleDbDataAdapter1.DeleteCommand = Me.oleDbDeleteCommand1
			Me.oleDbDataAdapter1.InsertCommand = Me.oleDbInsertCommand1
			Me.oleDbDataAdapter1.SelectCommand = Me.oleDbSelectCommand1
			Me.oleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Statistics", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("losses", "losses"), New System.Data.Common.DataColumnMapping("School", "School"), New System.Data.Common.DataColumnMapping("Sport", "Sport"), New System.Data.Common.DataColumnMapping("ties", "ties"), New System.Data.Common.DataColumnMapping("wins", "wins"), New System.Data.Common.DataColumnMapping("year", "year")})})
			Me.oleDbDataAdapter1.UpdateCommand = Me.oleDbUpdateCommand1
			' 
			' oleDbDeleteCommand1
			' 
			Me.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText")
			Me.oleDbDeleteCommand1.Connection = Me.oleDbConnection1
			Me.oleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_School", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "School", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_School1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "School", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sport", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Sport", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sport1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Sport", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_losses", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "losses", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_losses1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "losses", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ties", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ties", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ties1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ties", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_wins", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "wins", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_wins1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "wins", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_year", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "year", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_year1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "year", System.Data.DataRowVersion.Original, Nothing)})
			' 
			' oleDbConnection1
			' 
			Me.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString")
			' 
			' oleDbInsertCommand1
			' 
			Me.oleDbInsertCommand1.CommandText = "INSERT INTO Statistics(losses, School, Sport, ties, wins, year) VALUES (?, ?, ?, " & "?, ?, ?)"
			Me.oleDbInsertCommand1.Connection = Me.oleDbConnection1
			Me.oleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("losses", System.Data.OleDb.OleDbType.Integer, 0, "losses"), New System.Data.OleDb.OleDbParameter("School", System.Data.OleDb.OleDbType.VarWChar, 255, "School"), New System.Data.OleDb.OleDbParameter("Sport", System.Data.OleDb.OleDbType.VarWChar, 255, "Sport"), New System.Data.OleDb.OleDbParameter("ties", System.Data.OleDb.OleDbType.Integer, 0, "ties"), New System.Data.OleDb.OleDbParameter("wins", System.Data.OleDb.OleDbType.Integer, 0, "wins"), New System.Data.OleDb.OleDbParameter("year", System.Data.OleDb.OleDbType.Integer, 0, "year")})
			' 
			' oleDbSelectCommand1
			' 
			Me.oleDbSelectCommand1.CommandText = "SELECT ID, losses, School, Sport, ties, wins, year FROM Statistics"
			Me.oleDbSelectCommand1.Connection = Me.oleDbConnection1
			' 
			' oleDbUpdateCommand1
			' 
			Me.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText")
			Me.oleDbUpdateCommand1.Connection = Me.oleDbConnection1
			Me.oleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("losses", System.Data.OleDb.OleDbType.Integer, 0, "losses"), New System.Data.OleDb.OleDbParameter("School", System.Data.OleDb.OleDbType.VarWChar, 255, "School"), New System.Data.OleDb.OleDbParameter("Sport", System.Data.OleDb.OleDbType.VarWChar, 255, "Sport"), New System.Data.OleDb.OleDbParameter("ties", System.Data.OleDb.OleDbType.Integer, 0, "ties"), New System.Data.OleDb.OleDbParameter("wins", System.Data.OleDb.OleDbType.Integer, 0, "wins"), New System.Data.OleDb.OleDbParameter("year", System.Data.OleDb.OleDbType.Integer, 0, "year"), New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_School", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "School", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_School1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "School", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sport", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Sport", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sport1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Sport", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_losses", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "losses", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_losses1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "losses", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ties", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ties", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ties1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ties", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_wins", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "wins", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_wins1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "wins", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_year", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "year", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_year1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "year", System.Data.DataRowVersion.Original, Nothing)})
			' 
			' panel5
			' 
			Me.panel5.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel5.BackColor = System.Drawing.Color.White
			Me.panel5.Controls.Add(Me.panel3)
			Me.panel5.Controls.Add(Me.panel4)
			Me.panel5.Location = New System.Drawing.Point(-1, 1)
			Me.panel5.Name = "panel5"
			Me.panel5.Size = New System.Drawing.Size(841, 524)
			Me.panel5.TabIndex = 7
			' 
			' tipDesc
			' 
			Me.tipDesc.BackColor = System.Drawing.Color.White
			Me.tipDesc.ForeColor = System.Drawing.Color.Black
			Me.tipDesc.IsBalloon = True
			Me.tipDesc.ShowAlways = True
			Me.tipDesc.UseFading = False
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(251))))), (CInt(Fix((CByte(251))))), (CInt(Fix((CByte(251))))))
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(800, 526)
			Me.Controls.Add(Me.panel5)
			Me.DropShadow = True
			Me.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.MaximumSize = New System.Drawing.Size(820, 606)
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Child-Group Options Demo"
			Me.panel1.ResumeLayout(False)
			CType(Me.afterDetails, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.beforeDetails, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.captionText, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.showCaption, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ShowCaptionPlus, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel3.ResumeLayout(False)
			Me.panel4.ResumeLayout(False)
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel5.ResumeLayout(False)
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
		#End Region

		#Region "Event Handlers"
		Private Sub ShowCaptionPlus_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ShowCaptionPlus.CheckStateChanged
			Me.gridGroupingControl1.ChildGroupOptions.ShowCaptionPlusMinus = Not Me.gridGroupingControl1.ChildGroupOptions.ShowCaptionPlusMinus
			Me.lblPropertyDisplay.Text = ""
			Me.lblPropertyDisplay.Text = "gridGroupingControl1.ChildGroupOptions.ShowCaptionPlusMinus = " & Me.gridGroupingControl1.ChildGroupOptions.ShowCaptionPlusMinus
			Me.gridGroupingControl1.Refresh()
		End Sub

		Private Sub showCaption_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles showCaption.CheckStateChanged
			Me.gridGroupingControl1.ChildGroupOptions.ShowCaption = Not Me.gridGroupingControl1.ChildGroupOptions.ShowCaption
			Me.lblPropertyDisplay.Text = ""
			Me.lblPropertyDisplay.Text = "gridGroupingControl1.ChildGroupOptions.ShowCaption = " & Me.gridGroupingControl1.ChildGroupOptions.ShowCaption
			Me.gridGroupingControl1.Refresh()
		End Sub
		Private oldStyle As String = ""
		Private Sub captionText_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles captionText.CheckStateChanged
			Me.lblPropertyDisplay.Text = ""
			If Me.captionText.Checked Then
				Me.gridGroupingControl1.ChildGroupOptions.CaptionText = "There are {RecordCount} items under {CategoryName} : {Category}"
				Me.lblPropertyDisplay.Text = "gridGroupingControl1.ChildGroupOptions.CaptionText = ""There are {RecordCount} items under {CategoryName} : {Category}"""
			ElseIf Not Me.captionText.Checked Then
				Me.gridGroupingControl1.ChildGroupOptions.CaptionText = oldStyle
				Me.lblPropertyDisplay.Text = "gridGroupingControl1.ChildGroupOptions.CaptionText = """ & oldStyle & """"
			End If
		End Sub

		Private Sub beforeDetails_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles beforeDetails.CheckStateChanged
			Me.lblProperty.Text = ""
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = Not Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails
			Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = Not Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails
			Me.lblProperty.Text = "gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = " & Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails
		End Sub

		Private Sub afterDetails_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles afterDetails.CheckStateChanged
			Me.lblProperty.Text = ""
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = Not Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails
			Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordAfterDetails = Not Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordAfterDetails
			Me.lblProperty.Text = "gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordAfterDetails = " & Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordAfterDetails
		End Sub
		#End Region

	End Class
End Namespace
