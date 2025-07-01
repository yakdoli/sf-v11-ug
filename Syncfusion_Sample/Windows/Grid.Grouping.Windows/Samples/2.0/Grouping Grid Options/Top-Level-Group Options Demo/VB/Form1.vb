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

Namespace TopLevelGroupOptions
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		#Region "Private Members"
		Private panel1 As System.Windows.Forms.Panel
		Private panel2 As System.Windows.Forms.Panel
		Private panel3 As System.Windows.Forms.Panel
		Private WithEvents gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private panel4 As System.Windows.Forms.Panel
		Private label1 As System.Windows.Forms.Label
        Private WithEvents showCaption As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents showGroupFooter As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents showGroupHeader As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents beforeDetails As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents afterDetails As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private label2 As System.Windows.Forms.Label
		Private oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
		Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
		Private dataSet12 As TopLevelGroupOptions.DataSet1
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private lblPropety As System.Windows.Forms.Label
		Private lblChgProp As System.Windows.Forms.Label
		Private components As IContainer
		Private tipDesc As ToolTip
		Private Const connection As String = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""{0}"";Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False"
#End Region

		Public Sub New()
'			#Region "Grid Settings"
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
			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
			' 
			' oleDbConnection1
			' 
			Dim mdbFileName As String = FindDatabase("Common\Data\ACC.mdb")
			Me.oleDbConnection1.ConnectionString = String.Format(Form1.connection, mdbFileName)
			Me.oleDbDataAdapter1.Fill(Me.dataSet12)
			' To reduce the displayed records in the TopLevelTable
			Me.gridGroupingControl1.TableDescriptor.RecordFilters.Add("[wins] > 30")
			Me.SetStyle(ControlStyles.UserPaint, True)
'			#End Region
		End Sub

		#Region "Icon and Data Files"
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

		#Region "Form Settings"
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.panel1 = New System.Windows.Forms.Panel
            Me.label2 = New System.Windows.Forms.Label
            Me.afterDetails = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.beforeDetails = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.showGroupHeader = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.showGroupFooter = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.showCaption = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.label1 = New System.Windows.Forms.Label
            Me.panel2 = New System.Windows.Forms.Panel
            Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            Me.dataSet12 = New TopLevelGroupOptions.DataSet1
            Me.panel3 = New System.Windows.Forms.Panel
            Me.lblChgProp = New System.Windows.Forms.Label
            Me.lblPropety = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.panel4 = New System.Windows.Forms.Panel
            Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
            Me.oleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection
            Me.oleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
            Me.tipDesc = New System.Windows.Forms.ToolTip(Me.components)
            Me.panel1.SuspendLayout()
            CType(Me.afterDetails, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.beforeDetails, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.showGroupHeader, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.showGroupFooter, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.showCaption, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel3.SuspendLayout()
            Me.panel4.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.afterDetails)
            Me.panel1.Controls.Add(Me.beforeDetails)
            Me.panel1.Controls.Add(Me.showGroupHeader)
            Me.panel1.Controls.Add(Me.showGroupFooter)
            Me.panel1.Controls.Add(Me.showCaption)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.ForeColor = System.Drawing.Color.DimGray
            Me.panel1.Location = New System.Drawing.Point(516, 3)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(192, 368)
            Me.panel1.TabIndex = 0
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(16, 184)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(160, 23)
            Me.label2.TabIndex = 15
            Me.label2.Text = "AddNewRecordField"
            '
            'afterDetails
            '
            Me.afterDetails.DrawFocusRectangle = False
            Me.afterDetails.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.afterDetails.Location = New System.Drawing.Point(24, 248)
            Me.afterDetails.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.afterDetails.Name = "afterDetails"
            Me.afterDetails.Size = New System.Drawing.Size(136, 16)
            Me.afterDetails.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.afterDetails.TabIndex = 14
            Me.afterDetails.Text = "After Details"
            Me.afterDetails.ThemesEnabled = False
            '
            'beforeDetails
            '
            Me.beforeDetails.DrawFocusRectangle = False
            Me.beforeDetails.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.beforeDetails.Location = New System.Drawing.Point(24, 216)
            Me.beforeDetails.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.beforeDetails.Name = "beforeDetails"
            Me.beforeDetails.Size = New System.Drawing.Size(136, 16)
            Me.beforeDetails.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.beforeDetails.TabIndex = 13
            Me.beforeDetails.Text = "Before Details"
            Me.beforeDetails.ThemesEnabled = False
            '
            'showGroupHeader
            '
            Me.showGroupHeader.DrawFocusRectangle = False
            Me.showGroupHeader.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.showGroupHeader.Location = New System.Drawing.Point(24, 136)
            Me.showGroupHeader.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.showGroupHeader.Name = "showGroupHeader"
            Me.showGroupHeader.Size = New System.Drawing.Size(136, 18)
            Me.showGroupHeader.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.showGroupHeader.TabIndex = 12
            Me.showGroupHeader.Text = "ShowGroupHeader"
            Me.showGroupHeader.ThemesEnabled = False
            '
            'showGroupFooter
            '
            Me.showGroupFooter.DrawFocusRectangle = False
            Me.showGroupFooter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.showGroupFooter.Location = New System.Drawing.Point(24, 104)
            Me.showGroupFooter.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.showGroupFooter.Name = "showGroupFooter"
            Me.showGroupFooter.Size = New System.Drawing.Size(136, 18)
            Me.showGroupFooter.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.showGroupFooter.TabIndex = 11
            Me.showGroupFooter.Text = "ShowGroupFooter"
            Me.showGroupFooter.ThemesEnabled = False
            '
            'showCaption
            '
            Me.showCaption.DrawFocusRectangle = False
            Me.showCaption.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.showCaption.Location = New System.Drawing.Point(24, 72)
            Me.showCaption.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.showCaption.Name = "showCaption"
            Me.showCaption.Size = New System.Drawing.Size(136, 26)
            Me.showCaption.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.showCaption.TabIndex = 10
            Me.showCaption.Text = "ShowCaption"
            Me.showCaption.ThemesEnabled = False
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(16, 32)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(160, 23)
            Me.label1.TabIndex = 9
            Me.label1.Text = "TopLevelGroupOptions"
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.gridGroupingControl1)
            Me.panel2.Controls.Add(Me.panel1)
            Me.panel2.Location = New System.Drawing.Point(7, 6)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(713, 375)
            Me.panel2.TabIndex = 2
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
            Me.gridGroupingControl1.DataSource = Me.dataSet12.Statistics
            Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gridGroupingControl1.Location = New System.Drawing.Point(3, 3)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.ShowGroupDropArea = True
            Me.gridGroupingControl1.Size = New System.Drawing.Size(507, 368)
            Me.gridGroupingControl1.TabIndex = 0
            Me.gridGroupingControl1.TableDescriptor.Columns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ID"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("losses"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("School"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("Sport"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ties"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("wins"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("year")})
            Me.gridGroupingControl1.TableDescriptor.PrimaryKeyColumns.AddRange(New Syncfusion.Grouping.SortColumnDescriptor() {New Syncfusion.Grouping.SortColumnDescriptor("ID", System.ComponentModel.ListSortDirection.Ascending)})
            Me.gridGroupingControl1.TableDescriptor.VisibleColumns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ID"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("losses"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("School"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Sport"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ties"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("wins"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("year")})
            Me.gridGroupingControl1.Text = "gridGroupingControl1"
            Me.gridGroupingControl1.VersionInfo = "4.201.0.37"
            '
            'dataSet12
            '
            Me.dataSet12.DataSetName = "DataSet1"
            Me.dataSet12.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'panel3
            '
            Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel3.Controls.Add(Me.lblChgProp)
            Me.panel3.Controls.Add(Me.lblPropety)
            Me.panel3.Controls.Add(Me.label4)
            Me.panel3.Controls.Add(Me.label3)
            Me.panel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panel3.ForeColor = System.Drawing.Color.DimGray
            Me.panel3.Location = New System.Drawing.Point(10, 383)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(706, 142)
            Me.panel3.TabIndex = 4
            '
            'lblChgProp
            '
            Me.lblChgProp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblChgProp.Location = New System.Drawing.Point(246, 89)
            Me.lblChgProp.Name = "lblChgProp"
            Me.lblChgProp.Size = New System.Drawing.Size(434, 32)
            Me.lblChgProp.TabIndex = 3
            '
            'lblPropety
            '
            Me.lblPropety.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPropety.Location = New System.Drawing.Point(246, 30)
            Me.lblPropety.Name = "lblPropety"
            Me.lblPropety.Size = New System.Drawing.Size(436, 40)
            Me.lblPropety.TabIndex = 2
            '
            'label4
            '
            Me.label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(24, 89)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(224, 40)
            Me.label4.TabIndex = 1
            Me.label4.Text = "Property Changed :"
            '
            'label3
            '
            Me.label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(24, 30)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(216, 40)
            Me.label3.TabIndex = 0
            Me.label3.Text = "Changed TopLevelGroupOptions Property :"
            '
            'panel4
            '
            Me.panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel4.BackColor = System.Drawing.Color.White
            Me.panel4.Controls.Add(Me.panel2)
            Me.panel4.Controls.Add(Me.panel3)
            Me.panel4.Location = New System.Drawing.Point(0, 12)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(721, 533)
            Me.panel4.TabIndex = 6
            '
            'oleDbDataAdapter1
            '
            Me.oleDbDataAdapter1.DeleteCommand = Me.oleDbDeleteCommand1
            Me.oleDbDataAdapter1.InsertCommand = Me.oleDbInsertCommand1
            Me.oleDbDataAdapter1.SelectCommand = Me.oleDbSelectCommand1
            Me.oleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Statistics", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("losses", "losses"), New System.Data.Common.DataColumnMapping("School", "School"), New System.Data.Common.DataColumnMapping("Sport", "Sport"), New System.Data.Common.DataColumnMapping("ties", "ties"), New System.Data.Common.DataColumnMapping("wins", "wins"), New System.Data.Common.DataColumnMapping("year", "year")})})
            Me.oleDbDataAdapter1.UpdateCommand = Me.oleDbUpdateCommand1
            '
            'oleDbDeleteCommand1
            '
            Me.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText")
            Me.oleDbDeleteCommand1.Connection = Me.oleDbConnection1
            Me.oleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_School", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "School", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_School1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "School", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sport", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sport", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sport1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sport", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_losses", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "losses", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_losses1", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "losses", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ties", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ties", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ties1", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ties", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_wins", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "wins", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_wins1", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "wins", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_year", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "year", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_year1", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "year", System.Data.DataRowVersion.Original, Nothing)})
            '
            'oleDbConnection1
            '
            Me.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString")
            '
            'oleDbInsertCommand1
            '
            Me.oleDbInsertCommand1.CommandText = "INSERT INTO Statistics(losses, School, Sport, ties, wins, year) VALUES (?, ?, ?, " & _
                "?, ?, ?)"
            Me.oleDbInsertCommand1.Connection = Me.oleDbConnection1
            Me.oleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("losses", System.Data.OleDb.OleDbType.[Integer], 0, "losses"), New System.Data.OleDb.OleDbParameter("School", System.Data.OleDb.OleDbType.VarWChar, 255, "School"), New System.Data.OleDb.OleDbParameter("Sport", System.Data.OleDb.OleDbType.VarWChar, 255, "Sport"), New System.Data.OleDb.OleDbParameter("ties", System.Data.OleDb.OleDbType.[Integer], 0, "ties"), New System.Data.OleDb.OleDbParameter("wins", System.Data.OleDb.OleDbType.[Integer], 0, "wins"), New System.Data.OleDb.OleDbParameter("year", System.Data.OleDb.OleDbType.[Integer], 0, "year")})
            '
            'oleDbSelectCommand1
            '
            Me.oleDbSelectCommand1.CommandText = "SELECT ID, losses, School, Sport, ties, wins, year FROM Statistics"
            Me.oleDbSelectCommand1.Connection = Me.oleDbConnection1
            '
            'oleDbUpdateCommand1
            '
            Me.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText")
            Me.oleDbUpdateCommand1.Connection = Me.oleDbConnection1
            Me.oleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("losses", System.Data.OleDb.OleDbType.[Integer], 0, "losses"), New System.Data.OleDb.OleDbParameter("School", System.Data.OleDb.OleDbType.VarWChar, 255, "School"), New System.Data.OleDb.OleDbParameter("Sport", System.Data.OleDb.OleDbType.VarWChar, 255, "Sport"), New System.Data.OleDb.OleDbParameter("ties", System.Data.OleDb.OleDbType.[Integer], 0, "ties"), New System.Data.OleDb.OleDbParameter("wins", System.Data.OleDb.OleDbType.[Integer], 0, "wins"), New System.Data.OleDb.OleDbParameter("year", System.Data.OleDb.OleDbType.[Integer], 0, "year"), New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_School", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "School", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_School1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "School", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sport", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sport", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sport1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sport", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_losses", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "losses", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_losses1", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "losses", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ties", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ties", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ties1", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ties", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_wins", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "wins", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_wins1", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "wins", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_year", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "year", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_year1", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "year", System.Data.DataRowVersion.Original, Nothing)})
            '
            'tipDesc
            '
            Me.tipDesc.BackColor = System.Drawing.Color.White
            Me.tipDesc.ForeColor = System.Drawing.Color.Black
            Me.tipDesc.IsBalloon = True
            Me.tipDesc.ShowAlways = True
            Me.tipDesc.UseFading = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BackColor = System.Drawing.Color.White
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(725, 549)
            Me.Controls.Add(Me.panel4)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(750, 607)
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Top-Level-Group Options Demo"
            Me.panel1.ResumeLayout(False)
            CType(Me.afterDetails, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.beforeDetails, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.showGroupHeader, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.showGroupFooter, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.showCaption, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataSet12, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel3.ResumeLayout(False)
            Me.panel4.ResumeLayout(False)
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
		#End Region

		#Region "Event Handlers"
        Private Sub showCaption_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showCaption.CheckStateChanged
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = Not Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption
            Me.lblPropety.Text = ""
            Me.lblPropety.Text = "gridGroupingControl1.TopLevelGroupOptions.ShowCaption = " & gridGroupingControl1.TopLevelGroupOptions.ShowCaption
        End Sub

        Private Sub showGroupFooter_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showGroupFooter.CheckStateChanged
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowGroupFooter = Not Me.gridGroupingControl1.TopLevelGroupOptions.ShowGroupFooter
            Me.gridGroupingControl1.TableOptions.GroupFooterSectionHeight = 28
            Me.lblPropety.Text = ""
            Me.lblPropety.Text = "gridGroupingControl1.TopLevelGroupOptions.ShowGroupFooter = " & gridGroupingControl1.TopLevelGroupOptions.ShowGroupFooter
        End Sub

        Private Sub showGroupHeader_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showGroupHeader.CheckStateChanged
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowGroupHeader = Not Me.gridGroupingControl1.TopLevelGroupOptions.ShowGroupHeader
            Me.gridGroupingControl1.TableOptions.GroupHeaderSectionHeight = 28
            Me.lblPropety.Text = ""
            Me.lblPropety.Text = "gridGroupingControl1.TopLevelGroupOptions.ShowGroupHeader = " & gridGroupingControl1.TopLevelGroupOptions.ShowGroupHeader
        End Sub

        Private Sub beforeDetails_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beforeDetails.CheckStateChanged
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = Not Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails
            Me.lblChgProp.Text = ""
            Me.lblChgProp.Text = "gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = " & gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails
        End Sub

        Private Sub afterDetails_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles afterDetails.CheckStateChanged
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = Not Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails
            Me.lblChgProp.Text = ""
            Me.lblChgProp.Text = "gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = " & gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails
        End Sub

		Private Sub gridGroupingControl1_QueryCellStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventArgs) Handles gridGroupingControl1.QueryCellStyleInfo
			If e.TableCellIdentity.TableCellType = GridTableCellType.GroupFooterSectionCell OrElse e.TableCellIdentity.TableCellType = GridTableCellType.GroupHeaderSectionCell Then
				e.Style.BackColor = Color.LightSeaGreen
				e.Style.Enabled = False
				If e.TableCellIdentity.TableCellType = GridTableCellType.GroupFooterSectionCell Then
					e.Style.Text = "The details in the footer can be placed by enabling ShowGroupFooter and handling QueryCellStyleInfo"
				End If
				If e.TableCellIdentity.TableCellType = GridTableCellType.GroupHeaderSectionCell Then
					e.Style.Text = "The details in the header can be placed by enabling ShowGroupHeader and handling QueryCellStyleInfo"
				End If
			End If
		End Sub
		#End Region
    End Class
End Namespace
