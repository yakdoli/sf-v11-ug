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

Namespace TableOptions
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		#Region "Private Members"

		Private panel3 As System.Windows.Forms.Panel
		Private CodeDisplay As System.Windows.Forms.ListBox
		Private oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
		Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
		Private dataSet11 As TableOptions.DataSet1
		Private label3 As System.Windows.Forms.Label
		Private components As IContainer
		Private tipDesc As ToolTip
		Private panel5 As Panel
		Private panel4 As Panel
		Private panel1 As Panel
		Private groupBox1 As GroupBox
        Private WithEvents _recordBased As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private groupBox2 As GroupBox
        Private WithEvents radioButton1 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
        Private WithEvents _multiSimple As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
        Private WithEvents _One As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
        Private WithEvents _modelBased As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents button1 As ButtonAdv
		Private label2 As Label
		Private label1 As Label
        Private WithEvents _rowheader As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private panel2 As Panel
		Private gridGroupingControl1 As GridGroupingControl
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
			Me.oleDbDataAdapter1.Fill(Me.dataSet11.Statistics)
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.panel3 = New System.Windows.Forms.Panel
            Me.CodeDisplay = New System.Windows.Forms.ListBox
            Me.label3 = New System.Windows.Forms.Label
            Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
            Me.oleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection
            Me.oleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
            Me.panel5 = New System.Windows.Forms.Panel
            Me.panel4 = New System.Windows.Forms.Panel
            Me.panel1 = New System.Windows.Forms.Panel
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me._recordBased = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.radioButton1 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me._multiSimple = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me._One = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me._modelBased = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.label2 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me._rowheader = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.panel2 = New System.Windows.Forms.Panel
            Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            Me.dataSet11 = New TableOptions.DataSet1
            Me.panel3.SuspendLayout()
            Me.panel5.SuspendLayout()
            Me.panel4.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            CType(Me._recordBased, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox2.SuspendLayout()
            CType(Me.radioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._multiSimple, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._One, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._modelBased, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me._rowheader, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel3
            '
            Me.panel3.Controls.Add(Me.CodeDisplay)
            Me.panel3.Controls.Add(Me.label3)
            Me.panel3.Location = New System.Drawing.Point(5, 420)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(663, 133)
            Me.panel3.TabIndex = 4
            '
            'CodeDisplay
            '
            Me.CodeDisplay.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.CodeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.CodeDisplay.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CodeDisplay.ItemHeight = 15
            Me.CodeDisplay.Location = New System.Drawing.Point(11, 30)
            Me.CodeDisplay.Name = "CodeDisplay"
            Me.CodeDisplay.Size = New System.Drawing.Size(648, 77)
            Me.CodeDisplay.TabIndex = 0
            '
            'label3
            '
            Me.label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.Black
            Me.label3.Location = New System.Drawing.Point(19, 10)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(640, 33)
            Me.label3.TabIndex = 1
            Me.label3.Text = "Model based selection lets you select across cells not record based"
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
            'panel5
            '
            Me.panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel5.BackColor = System.Drawing.Color.White
            Me.panel5.Controls.Add(Me.panel3)
            Me.panel5.Controls.Add(Me.panel4)
            Me.panel5.Location = New System.Drawing.Point(0, 0)
            Me.panel5.Name = "panel5"
            Me.panel5.Size = New System.Drawing.Size(665, 530)
            Me.panel5.TabIndex = 7
            '
            'panel4
            '
            Me.panel4.Controls.Add(Me.panel1)
            Me.panel4.Controls.Add(Me.panel2)
            Me.panel4.Location = New System.Drawing.Point(3, -11)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(793, 587)
            Me.panel4.TabIndex = 6
            '
            'panel1
            '
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.groupBox1)
            Me.panel1.Controls.Add(Me.button1)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me._rowheader)
            Me.panel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panel1.ForeColor = System.Drawing.Color.DimGray
            Me.panel1.Location = New System.Drawing.Point(494, 21)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(166, 396)
            Me.panel1.TabIndex = 0
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me._recordBased)
            Me.groupBox1.Controls.Add(Me.groupBox2)
            Me.groupBox1.Controls.Add(Me._modelBased)
            Me.groupBox1.Location = New System.Drawing.Point(6, 117)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(152, 232)
            Me.groupBox1.TabIndex = 12
            Me.groupBox1.TabStop = False
            '
            '_recordBased
            '
            Me._recordBased.DrawFocusRectangle = False
            Me._recordBased.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._recordBased.Location = New System.Drawing.Point(12, 54)
            Me._recordBased.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me._recordBased.Name = "_recordBased"
            Me._recordBased.Size = New System.Drawing.Size(104, 16)
            Me._recordBased.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me._recordBased.TabIndex = 10
            Me._recordBased.Text = "Record Based"
            Me._recordBased.ThemesEnabled = False
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.radioButton1)
            Me.groupBox2.Controls.Add(Me._multiSimple)
            Me.groupBox2.Controls.Add(Me._One)
            Me.groupBox2.Enabled = False
            Me.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox2.Location = New System.Drawing.Point(12, 88)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(128, 128)
            Me.groupBox2.TabIndex = 11
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "SelectionMode"
            '
            'radioButton1
            '
            Me.radioButton1.DrawFocusRectangle = False
            Me.radioButton1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton1.Location = New System.Drawing.Point(16, 88)
            Me.radioButton1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(105, 24)
            Me.radioButton1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radioButton1.TabIndex = 2
            Me.radioButton1.TabStop = False
            Me.radioButton1.Text = "MultiExtended"
            Me.radioButton1.ThemesEnabled = False
            '
            '_multiSimple
            '
            Me._multiSimple.DrawFocusRectangle = False
            Me._multiSimple.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._multiSimple.Location = New System.Drawing.Point(16, 56)
            Me._multiSimple.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me._multiSimple.Name = "_multiSimple"
            Me._multiSimple.Size = New System.Drawing.Size(100, 24)
            Me._multiSimple.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me._multiSimple.TabIndex = 1
            Me._multiSimple.TabStop = False
            Me._multiSimple.Text = "MultiSimple"
            Me._multiSimple.ThemesEnabled = False
            '
            '_One
            '
            Me._One.Checked = True
            Me._One.DrawFocusRectangle = False
            Me._One.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._One.Location = New System.Drawing.Point(16, 24)
            Me._One.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me._One.Name = "_One"
            Me._One.Size = New System.Drawing.Size(100, 24)
            Me._One.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me._One.TabIndex = 0
            Me._One.Text = "One"
            Me._One.ThemesEnabled = False
            '
            '_modelBased
            '
            Me._modelBased.Checked = True
            Me._modelBased.CheckState = System.Windows.Forms.CheckState.Checked
            Me._modelBased.DrawFocusRectangle = False
            Me._modelBased.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._modelBased.Location = New System.Drawing.Point(12, 19)
            Me._modelBased.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me._modelBased.Name = "_modelBased"
            Me._modelBased.Size = New System.Drawing.Size(104, 16)
            Me._modelBased.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me._modelBased.TabIndex = 9
            Me._modelBased.Text = "Model Based"
            Me._modelBased.ThemesEnabled = False
            '
            'button1
            '
            Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.ForeColor = System.Drawing.Color.White
            Me.button1.Location = New System.Drawing.Point(12, 355)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(136, 26)
            Me.button1.TabIndex = 11
            Me.button1.Text = "ShowTreeLines"
            Me.button1.UseVisualStyle = True
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(11, 91)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(150, 23)
            Me.label2.TabIndex = 10
            Me.label2.Text = "Selection Types"
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(11, 24)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(144, 23)
            Me.label1.TabIndex = 9
            Me.label1.Text = "Table Options"
            '
            '_rowheader
            '
            Me._rowheader.Checked = True
            Me._rowheader.CheckState = System.Windows.Forms.CheckState.Checked
            Me._rowheader.DrawFocusRectangle = False
            Me._rowheader.Location = New System.Drawing.Point(14, 50)
            Me._rowheader.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me._rowheader.Name = "_rowheader"
            Me._rowheader.Size = New System.Drawing.Size(144, 24)
            Me._rowheader.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me._rowheader.TabIndex = 0
            Me._rowheader.Text = "RowHeader"
            Me._rowheader.ThemesEnabled = False
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.gridGroupingControl1)
            Me.panel2.Location = New System.Drawing.Point(3, 19)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(467, 398)
            Me.panel2.TabIndex = 2
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
            Me.gridGroupingControl1.DataSource = Me.dataSet11.Statistics
            Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gridGroupingControl1.Location = New System.Drawing.Point(7, 0)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.ShowGroupDropArea = True
            Me.gridGroupingControl1.Size = New System.Drawing.Size(460, 398)
            Me.gridGroupingControl1.TabIndex = 0
            Me.gridGroupingControl1.TableDescriptor.Columns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ID"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("losses"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("School"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("Sport"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ties"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("wins"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("year")})
            Me.gridGroupingControl1.TableDescriptor.PrimaryKeyColumns.AddRange(New Syncfusion.Grouping.SortColumnDescriptor() {New Syncfusion.Grouping.SortColumnDescriptor("ID", System.ComponentModel.ListSortDirection.Ascending)})
            Me.gridGroupingControl1.TableDescriptor.VisibleColumns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ID"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("losses"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("School"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Sport"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ties"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("wins"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("year")})
            Me.gridGroupingControl1.Text = "gridGroupingControl1"
            Me.gridGroupingControl1.VersionInfo = "4.201.0.37"
            '
            'dataSet11
            '
            Me.dataSet11.DataSetName = "DataSet1"
            Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(677, 542)
            Me.Controls.Add(Me.panel5)
            Me.DropShadow = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(820, 646)
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Table Options Demo"
            Me.panel3.ResumeLayout(False)
            Me.panel5.ResumeLayout(False)
            Me.panel4.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            Me.groupBox1.ResumeLayout(False)
            CType(Me._recordBased, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox2.ResumeLayout(False)
            CType(Me.radioButton1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._multiSimple, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._One, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._modelBased, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me._rowheader, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
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
			Application.Run(New Form1())
		End Sub
		#End Region

		#Region "Event Handlers"
        Private Sub _rowheader_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _rowheader.CheckStateChanged
            Me.gridGroupingControl1.TableOptions.ShowRowHeader = Not Me.gridGroupingControl1.TableOptions.ShowRowHeader
            Me.CodeDisplay.Items.Clear()
            Me.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.ShowRowHeader = " & Me.gridGroupingControl1.TableOptions.ShowRowHeader)
        End Sub

        Private Sub _modelBased_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _modelBased.CheckStateChanged
            Me._recordBased.Checked = Not Me._modelBased.Checked
            ' To Clear any selected records in any tables
            For Each t As Table In Me.gridGroupingControl1.Engine.EnumerateTables()
                Me.gridGroupingControl1.GetTable(t.TableDescriptor.Name).SelectedRecords.Clear()
            Next t
            ' Table Model based selection
            Me.label3.Text = "Model Based Selection lets you select across cells not record based"
            Me.gridGroupingControl1.TableModel.Options.ShowCurrentCellBorderBehavior = GridShowCurrentCellBorder.AlwaysVisible
            Me.gridGroupingControl1.TableModel.Options.AlphaBlendSelectionColor = Color.Red
            Me.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.Any
            Me.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.None
            Me.CodeDisplay.Items.Clear()
            Me.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.Any;")
            Me.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.None;")
            Me.CodeDisplay.Items.Add("this.gridGroupingControl1.TableModel.Options.AlphaBlendSelectionColor = Color.Red;")
        End Sub

        Private Sub _recordBased_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _recordBased.CheckStateChanged
            Me._modelBased.Checked = Not Me._recordBased.Checked
            Me.groupBox2.Enabled = Me._recordBased.Checked
            ' To clear modelbased selections in all TableModel
            For Each t As Table In Me.gridGroupingControl1.Engine.EnumerateTables()
                Me.gridGroupingControl1.GetTableModel(t.TableDescriptor.Name).Selections.Clear()
            Next t
            ' Record Based Selection
            Me.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.None
            If _One.Checked Then
                Me.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.One
            ElseIf _multiSimple.Checked Then
                Me.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiSimple
            ElseIf radioButton1.Checked Then
                Me.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended
            End If
            Me.label3.Text = "Record based selection allows selection in terms of records not cell based"
            Me.gridGroupingControl1.TableOptions.ListBoxSelectionCurrentCellOptions = GridListBoxSelectionCurrentCellOptions.None
            Me.gridGroupingControl1.TableModel.Options.ShowCurrentCellBorderBehavior = GridShowCurrentCellBorder.HideAlways
            Me.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.None
            Me.gridGroupingControl1.TableOptions.SelectionBackColor = Color.LightSteelBlue
            Me.gridGroupingControl1.TableOptions.SelectionTextColor = Color.RoyalBlue
            Me.CodeDisplay.Items.Clear()
        End Sub
        Private Sub _One_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _One.CheckChanged
            Me.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.One
            Me.CodeDisplay.Items.Clear()
            Me.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.None;")
            Me.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.One;")
            Me.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.SelectionBackColor = Color.LightSteelBlue;")
            Me.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.SelectionTextColor = Color.RoyalBlue;")
        End Sub



        Private Sub _multiSimple_CheckedChanged_1(ByVal sender As Object, ByVal e As System.EventArgs) Handles _multiSimple.CheckChanged
            Me.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiSimple
            Me.CodeDisplay.Items.Clear()
            Me.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.None;")
            Me.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiSimple;")
            Me.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.SelectionBackColor = Color.LightSteelBlue;")
            Me.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.SelectionTextColor = Color.RoyalBlue;")

        End Sub

        Private Sub radioButton1_CheckedChanged_1(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton1.CheckChanged
            Me.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended
            Me.CodeDisplay.Items.Clear()
            Me.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.None;")
            Me.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended;")
            Me.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.SelectionBackColor = Color.LightSteelBlue;")
            Me.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.SelectionTextColor = Color.RoyalBlue;")
        End Sub
Private flag As Boolean=False
		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			If Not flag Then
				flag=True
				Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear()
				Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("Sport")
				Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("wins",ListSortDirection.Descending)
				Me.gridGroupingControl1.TableOptions.ShowTreeLines = True
				Me.gridGroupingControl1.TableOptions.TreeLineBorder = New GridBorder(GridBorderStyle.Solid, Color.Red, GridBorderWeight.Thick)
				Me.CodeDisplay.Items.Clear()
				Me.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.ShowTreeLines = true;")
				Me.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.TreeLineBorder = new GridBorder(GridBorderStyle.Solid, Color.Red, GridBorderWeight.Thick);")

				Me.gridGroupingControl1.Table.ExpandAllGroups()
				Me.gridGroupingControl1.Table.TopLevelGroup.Groups(0).IsExpanded = False
				Me.button1.Text="Disable TreeLines"
			Else
				flag=False
				Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear()
				Me.gridGroupingControl1.TableOptions.ShowTreeLines = False
				Me.CodeDisplay.Items.Clear()
				Me.CodeDisplay.Items.Add("this.gridGroupingControl1.TableOptions.ShowTreeLines = false;")
				Me.button1.Text="Show TreeLines"
			End If
		End Sub
		#End Region
    End Class
End Namespace
