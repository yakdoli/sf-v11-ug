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
Imports System.Windows.Forms
Imports System.Data
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.Reflection
Imports System.Globalization

Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms

Namespace ComboTest

	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private panel1 As System.Windows.Forms.Panel
		Private splitter1 As System.Windows.Forms.Splitter
		Private comboBox2 As System.Windows.Forms.ComboBox

		Private groupBox1 As System.Windows.Forms.GroupBox
		Private textLog As System.Windows.Forms.TextBox
		Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
		Private dataSet11 As ComboTest.DataSet1
		Private dataSet21 As ComboTest.DataSet2
		Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
		Private oleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
		Private oleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
		Private oleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
		Private oleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
		Private oleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private dataGrid1 As System.Windows.Forms.DataGrid
		Private WithEvents ComboBoxAdvBound As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private WithEvents chkNumbersOnly As System.Windows.Forms.CheckBox
		Private WithEvents chkCaseSens As System.Windows.Forms.CheckBox
		Private WithEvents chkAutoComp As System.Windows.Forms.CheckBox
		Private WithEvents chkSorted As System.Windows.Forms.CheckBox
		Private ComboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private label3 As System.Windows.Forms.Label
		Private comboBoxAdv2 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private label4 As System.Windows.Forms.Label
		Private label5 As Label
		Private WithEvents comboBoxAdv3 As ComboBoxAdv
		Private label6 As Label
		Private label7 As Label
		Private label8 As Label
		Private label9 As Label
		Private label10 As Label
		Private label11 As Label
		Private label12 As Label
		Private WithEvents btnSetBanner As Button
		Private txtBanner As TextBox
		Private rdoFocus As RadioButton
		Private rdoEdit As RadioButton
		Private WithEvents bannerColorEdit As ButtonEdit
		Private textBoxExt1 As TextBoxExt
		Private buttonEditChildButton1 As ButtonEditChildButton
		Private bannerTextProvider1 As BannerTextProvider
		Private colorDialog1 As ColorDialog
		Private label13 As Label
		Private toolTip1 As ToolTip
		Private components As IContainer

		Public Sub New()
			InitializeComponent()
            Dim mdbFile As String = Application.StartupPath & " \..\..\..\..\..\..\..\..\..\Common\Data\ComboBoxAdvDataBinding.mdb"

            ' Database connection string
            Me.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & mdbFile
           	End Sub

		Public Shared Function FindFile(ByVal xmlFileName As String) As String
			' Check both in parent folder and Parent\Data folders.
			Dim xmlDataFileName As String = "Data\" & xmlFileName
			For n As Integer = 0 To 9
				If System.IO.File.Exists(xmlFileName) Then
					Return xmlFileName
				End If
				If System.IO.File.Exists(xmlDataFileName) Then
					Return xmlDataFileName
				End If
				xmlFileName = "..\" & xmlFileName
				xmlDataFileName = "..\" & xmlDataFileName
			Next n

			Return xmlFileName
		End Function


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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim BannerTextInfo1 As Syncfusion.Windows.Forms.BannerTextInfo = New Syncfusion.Windows.Forms.BannerTextInfo
            Me.panel1 = New System.Windows.Forms.Panel
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.splitter1 = New System.Windows.Forms.Splitter
            Me.dataSet11 = New ComboTest.DataSet1
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.textLog = New System.Windows.Forms.TextBox
            Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection
            Me.dataSet21 = New ComboTest.DataSet2
            Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
            Me.oleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
            Me.oleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
            Me.oleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
            Me.oleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
            Me.oleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter
            Me.groupBox3 = New System.Windows.Forms.GroupBox
            Me.ComboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.chkSorted = New System.Windows.Forms.CheckBox
            Me.chkAutoComp = New System.Windows.Forms.CheckBox
            Me.chkCaseSens = New System.Windows.Forms.CheckBox
            Me.chkNumbersOnly = New System.Windows.Forms.CheckBox
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.label2 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.ComboBoxAdvBound = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.dataGrid1 = New System.Windows.Forms.DataGrid
            Me.label3 = New System.Windows.Forms.Label
            Me.comboBoxAdv2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.label4 = New System.Windows.Forms.Label
            Me.comboBoxAdv3 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.label5 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.label8 = New System.Windows.Forms.Label
            Me.label9 = New System.Windows.Forms.Label
            Me.label10 = New System.Windows.Forms.Label
            Me.label11 = New System.Windows.Forms.Label
            Me.label12 = New System.Windows.Forms.Label
            Me.btnSetBanner = New System.Windows.Forms.Button
            Me.txtBanner = New System.Windows.Forms.TextBox
            Me.rdoFocus = New System.Windows.Forms.RadioButton
            Me.rdoEdit = New System.Windows.Forms.RadioButton
            Me.bannerColorEdit = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton1 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.textBoxExt1 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.bannerTextProvider1 = New Syncfusion.Windows.Forms.BannerTextProvider(Me.components)
            Me.colorDialog1 = New System.Windows.Forms.ColorDialog
            Me.label13 = New System.Windows.Forms.Label
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.panel1.SuspendLayout()
            CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            CType(Me.dataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox3.SuspendLayout()
            CType(Me.ComboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox2.SuspendLayout()
            CType(Me.ComboBoxAdvBound, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bannerColorEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.bannerColorEdit.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.comboBox2)
            Me.panel1.Controls.Add(Me.splitter1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(456, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(176, 517)
            Me.panel1.TabIndex = 6
            '
            'comboBox2
            '
            Me.comboBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.comboBox2.Location = New System.Drawing.Point(3, 0)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(173, 21)
            Me.comboBox2.TabIndex = 1
            '
            'splitter1
            '
            Me.splitter1.Location = New System.Drawing.Point(0, 0)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(3, 517)
            Me.splitter1.TabIndex = 0
            Me.splitter1.TabStop = False
            '
            'dataSet11
            '
            Me.dataSet11.DataSetName = "DataSet1"
            Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'groupBox1
            '
            Me.groupBox1.BackColor = System.Drawing.Color.Transparent
            Me.groupBox1.Controls.Add(Me.textLog)
            Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.groupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(0, 453)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(585, 144)
            Me.groupBox1.TabIndex = 8
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Events:"
            '
            'textLog
            '
            Me.textLog.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textLog.Location = New System.Drawing.Point(3, 17)
            Me.textLog.Multiline = True
            Me.textLog.Name = "textLog"
            Me.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.textLog.Size = New System.Drawing.Size(579, 124)
            Me.textLog.TabIndex = 0
            '
            'oleDbConnection1
            '
            Me.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString")
            '
            'dataSet21
            '
            Me.dataSet21.DataSetName = "DataSet2"
            Me.dataSet21.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'oleDbSelectCommand1
            '
            Me.oleDbSelectCommand1.CommandText = "SELECT CustomerName, ID, Sex FROM Customers"
            Me.oleDbSelectCommand1.Connection = Me.oleDbConnection1
            '
            'oleDbInsertCommand1
            '
            Me.oleDbInsertCommand1.CommandText = "INSERT INTO Customers(CustomerName, Sex) VALUES (?, ?)"
            Me.oleDbInsertCommand1.Connection = Me.oleDbConnection1
            Me.oleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerName"), New System.Data.OleDb.OleDbParameter("Sex", System.Data.OleDb.OleDbType.VarWChar, 50, "Sex")})
            '
            'oleDbUpdateCommand1
            '
            Me.oleDbUpdateCommand1.CommandText = "UPDATE Customers SET CustomerName = ?, Sex = ? WHERE (ID = ?) AND (CustomerName =" & _
                " ? OR ? IS NULL AND CustomerName IS NULL) AND (Sex = ? OR ? IS NULL AND Sex IS N" & _
                "ULL)"
            Me.oleDbUpdateCommand1.Connection = Me.oleDbConnection1
            Me.oleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerName"), New System.Data.OleDb.OleDbParameter("Sex", System.Data.OleDb.OleDbType.VarWChar, 50, "Sex"), New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustomerName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sex", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sex", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sex1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sex", System.Data.DataRowVersion.Original, Nothing)})
            '
            'oleDbDeleteCommand1
            '
            Me.oleDbDeleteCommand1.CommandText = "DELETE FROM Customers WHERE (ID = ?) AND (CustomerName = ? OR ? IS NULL AND Custo" & _
                "merName IS NULL) AND (Sex = ? OR ? IS NULL AND Sex IS NULL)"
            Me.oleDbDeleteCommand1.Connection = Me.oleDbConnection1
            Me.oleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustomerName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sex", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sex", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sex1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sex", System.Data.DataRowVersion.Original, Nothing)})
            '
            'oleDbDataAdapter1
            '
            Me.oleDbDataAdapter1.DeleteCommand = Me.oleDbDeleteCommand1
            Me.oleDbDataAdapter1.InsertCommand = Me.oleDbInsertCommand1
            Me.oleDbDataAdapter1.SelectCommand = Me.oleDbSelectCommand1
            Me.oleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Customers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CustomerName", "CustomerName"), New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Sex", "Sex")})})
            Me.oleDbDataAdapter1.UpdateCommand = Me.oleDbUpdateCommand1
            '
            'oleDbSelectCommand2
            '
            Me.oleDbSelectCommand2.CommandText = "SELECT Description, ID FROM Sex_Description"
            Me.oleDbSelectCommand2.Connection = Me.oleDbConnection1
            '
            'oleDbInsertCommand2
            '
            Me.oleDbInsertCommand2.CommandText = "INSERT INTO Sex_Description(Description) VALUES (?)"
            Me.oleDbInsertCommand2.Connection = Me.oleDbConnection1
            Me.oleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 50, "Description")})
            '
            'oleDbUpdateCommand2
            '
            Me.oleDbUpdateCommand2.CommandText = "UPDATE Sex_Description SET Description = ? WHERE (ID = ?) AND (Description = ? OR" & _
                " ? IS NULL AND Description IS NULL)"
            Me.oleDbUpdateCommand2.Connection = Me.oleDbConnection1
            Me.oleDbUpdateCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 50, "Description"), New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing)})
            '
            'oleDbDeleteCommand2
            '
            Me.oleDbDeleteCommand2.CommandText = "DELETE FROM Sex_Description WHERE (ID = ?) AND (Description = ? OR ? IS NULL AND " & _
                "Description IS NULL)"
            Me.oleDbDeleteCommand2.Connection = Me.oleDbConnection1
            Me.oleDbDeleteCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing)})
            '
            'oleDbDataAdapter2
            '
            Me.oleDbDataAdapter2.DeleteCommand = Me.oleDbDeleteCommand2
            Me.oleDbDataAdapter2.InsertCommand = Me.oleDbInsertCommand2
            Me.oleDbDataAdapter2.SelectCommand = Me.oleDbSelectCommand2
            Me.oleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Sex_Description", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Description", "Description")})})
            Me.oleDbDataAdapter2.UpdateCommand = Me.oleDbUpdateCommand2
            '
            'groupBox3
            '
            Me.groupBox3.Controls.Add(Me.ComboBoxAdv1)
            Me.groupBox3.Controls.Add(Me.chkSorted)
            Me.groupBox3.Controls.Add(Me.chkAutoComp)
            Me.groupBox3.Controls.Add(Me.chkCaseSens)
            Me.groupBox3.Controls.Add(Me.chkNumbersOnly)
            Me.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox3.Location = New System.Drawing.Point(344, 61)
            Me.groupBox3.Name = "groupBox3"
            Me.groupBox3.Size = New System.Drawing.Size(233, 157)
            Me.groupBox3.TabIndex = 10
            Me.groupBox3.TabStop = False
            Me.groupBox3.Text = "ComboBoxAdv:"
            '
            'ComboBoxAdv1
            '
            Me.ComboBoxAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            BannerTextInfo1.Text = "[Select]"
            BannerTextInfo1.Visible = True
            Me.bannerTextProvider1.SetBannerText(Me.ComboBoxAdv1, BannerTextInfo1)
            Me.ComboBoxAdv1.IgnoreThemeBackground = True
            Me.ComboBoxAdv1.Location = New System.Drawing.Point(32, 25)
            Me.ComboBoxAdv1.Name = "ComboBoxAdv1"
            Me.ComboBoxAdv1.Size = New System.Drawing.Size(176, 21)
            Me.ComboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.ComboBoxAdv1.TabIndex = 5
            '
            'chkSorted
            '
            Me.chkSorted.Location = New System.Drawing.Point(32, 129)
            Me.chkSorted.Name = "chkSorted"
            Me.chkSorted.Size = New System.Drawing.Size(120, 16)
            Me.chkSorted.TabIndex = 4
            Me.chkSorted.Text = "Sorted"
            '
            'chkAutoComp
            '
            Me.chkAutoComp.Checked = True
            Me.chkAutoComp.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkAutoComp.Location = New System.Drawing.Point(32, 81)
            Me.chkAutoComp.Name = "chkAutoComp"
            Me.chkAutoComp.Size = New System.Drawing.Size(104, 16)
            Me.chkAutoComp.TabIndex = 3
            Me.chkAutoComp.Text = "Auto Complete"
            '
            'chkCaseSens
            '
            Me.chkCaseSens.Location = New System.Drawing.Point(32, 105)
            Me.chkCaseSens.Name = "chkCaseSens"
            Me.chkCaseSens.Size = New System.Drawing.Size(184, 16)
            Me.chkCaseSens.TabIndex = 2
            Me.chkCaseSens.Text = "Case Sensitive Auto Complete"
            '
            'chkNumbersOnly
            '
            Me.chkNumbersOnly.Location = New System.Drawing.Point(32, 57)
            Me.chkNumbersOnly.Name = "chkNumbersOnly"
            Me.chkNumbersOnly.Size = New System.Drawing.Size(96, 16)
            Me.chkNumbersOnly.TabIndex = 1
            Me.chkNumbersOnly.Text = "Numbers Only"
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.label2)
            Me.groupBox2.Controls.Add(Me.label1)
            Me.groupBox2.Controls.Add(Me.ComboBoxAdvBound)
            Me.groupBox2.Controls.Add(Me.dataGrid1)
            Me.groupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox2.Location = New System.Drawing.Point(8, 61)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(317, 304)
            Me.groupBox2.TabIndex = 9
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "DataBound ComboBoxAdv"
            '
            'label2
            '
            Me.label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.Brown
            Me.label2.Location = New System.Drawing.Point(8, 25)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(296, 48)
            Me.label2.TabIndex = 3
            Me.label2.Text = "Databinding for this combo initialized in code. Change the Sex in the current row" & _
                " in the grid below and see the values change here and vice-versa."
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(8, 114)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(96, 16)
            Me.label1.TabIndex = 2
            Me.label1.Text = "Databound Grid:"
            '
            'ComboBoxAdvBound
            '
            Me.ComboBoxAdvBound.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ComboBoxAdvBound.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ComboBoxAdvBound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBoxAdvBound.IgnoreThemeBackground = True
            Me.ComboBoxAdvBound.Location = New System.Drawing.Point(8, 80)
            Me.ComboBoxAdvBound.Name = "ComboBoxAdvBound"
            Me.ComboBoxAdvBound.Size = New System.Drawing.Size(296, 21)
            Me.ComboBoxAdvBound.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.ComboBoxAdvBound.TabIndex = 0
            '
            'dataGrid1
            '
            Me.dataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender
            Me.dataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dataGrid1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ControlDark
            Me.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.ControlDarkDark
            Me.dataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue
            Me.dataGrid1.DataMember = ""
            Me.dataGrid1.DataSource = Me.dataSet11.Customers
            Me.dataGrid1.FlatMode = True
            Me.dataGrid1.Font = New System.Drawing.Font("Tahoma", 8.0!)
            Me.dataGrid1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.dataGrid1.GridLineColor = System.Drawing.Color.Gainsboro
            Me.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
            Me.dataGrid1.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.dataGrid1.HeaderForeColor = System.Drawing.Color.Black
            Me.dataGrid1.LinkColor = System.Drawing.Color.Teal
            Me.dataGrid1.Location = New System.Drawing.Point(8, 137)
            Me.dataGrid1.Name = "dataGrid1"
            Me.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro
            Me.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
            Me.dataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue
            Me.dataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke
            Me.dataGrid1.Size = New System.Drawing.Size(301, 151)
            Me.dataGrid1.TabIndex = 1
            '
            'label3
            '
            Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(37, 4)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(511, 48)
            Me.label3.TabIndex = 12
            Me.label3.Text = resources.GetString("label3.Text")
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'comboBoxAdv2
            '
            Me.comboBoxAdv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.comboBoxAdv2.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched
            Me.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxAdv2.IgnoreThemeBackground = True
            Me.comboBoxAdv2.Items.AddRange(New Object() {"Default", "OfficeXP", "VS2005", "Office2003", "Office2007"})
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "Default"))
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "OfficeXP"))
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "VS2005"))
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "Office2003"))
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "Office2007"))
            Me.comboBoxAdv2.Location = New System.Drawing.Point(87, 415)
            Me.comboBoxAdv2.Name = "comboBoxAdv2"
            Me.comboBoxAdv2.Size = New System.Drawing.Size(147, 21)
            Me.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.comboBoxAdv2.TabIndex = 6
            Me.comboBoxAdv2.Text = "Default"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(35, 418)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(39, 13)
            Me.label4.TabIndex = 13
            Me.label4.Text = "Style:"
            '
            'comboBoxAdv3
            '
            Me.comboBoxAdv3.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.comboBoxAdv3.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched
            Me.comboBoxAdv3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxAdv3.IgnoreThemeBackground = True
            Me.comboBoxAdv3.Items.AddRange(New Object() {"Blue", "Silver", "Black", "Managed"})
            Me.comboBoxAdv3.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv3, "Blue"))
            Me.comboBoxAdv3.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv3, "Silver"))
            Me.comboBoxAdv3.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv3, "Black"))
            Me.comboBoxAdv3.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv3, "Managed"))
            Me.comboBoxAdv3.Location = New System.Drawing.Point(408, 415)
            Me.comboBoxAdv3.Name = "comboBoxAdv3"
            Me.comboBoxAdv3.Size = New System.Drawing.Size(120, 21)
            Me.comboBoxAdv3.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.comboBoxAdv3.TabIndex = 16
            Me.comboBoxAdv3.Text = "Blue"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.Location = New System.Drawing.Point(247, 418)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(158, 13)
            Me.label5.TabIndex = 15
            Me.label5.Text = "Office2007 - Color Scheme:"
            '
            'label6
            '
            Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label6.Image = CType(resources.GetObject("label6.Image"), System.Drawing.Image)
            Me.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label6.Location = New System.Drawing.Point(11, 382)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(117, 23)
            Me.label6.TabIndex = 17
            Me.label6.Text = "      Visual Style"
            Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label7
            '
            Me.label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label7.Location = New System.Drawing.Point(122, 398)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(435, 1)
            Me.label7.TabIndex = 18
            '
            'label8
            '
            Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label8.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label8.Image = CType(resources.GetObject("label8.Image"), System.Drawing.Image)
            Me.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label8.Location = New System.Drawing.Point(341, 235)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(164, 21)
            Me.label8.TabIndex = 19
            Me.label8.Text = "      BannerText Settings"
            '
            'label9
            '
            Me.label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label9.Location = New System.Drawing.Point(360, 256)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(200, 1)
            Me.label9.TabIndex = 20
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label10.Location = New System.Drawing.Point(358, 272)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(28, 14)
            Me.label10.TabIndex = 6
            Me.label10.Text = "Text"
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label11.Location = New System.Drawing.Point(358, 310)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(33, 14)
            Me.label11.TabIndex = 7
            Me.label11.Text = "Mode"
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label12.Location = New System.Drawing.Point(358, 335)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(32, 14)
            Me.label12.TabIndex = 8
            Me.label12.Text = "Color"
            '
            'btnSetBanner
            '
            Me.btnSetBanner.Enabled = False
            Me.btnSetBanner.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnSetBanner.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSetBanner.Location = New System.Drawing.Point(397, 367)
            Me.btnSetBanner.Name = "btnSetBanner"
            Me.btnSetBanner.Size = New System.Drawing.Size(125, 23)
            Me.btnSetBanner.TabIndex = 21
            Me.btnSetBanner.Text = "Set Banner Text"
            Me.btnSetBanner.UseVisualStyleBackColor = True
            '
            'txtBanner
            '
            Me.txtBanner.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBanner.Location = New System.Drawing.Point(409, 272)
            Me.txtBanner.Name = "txtBanner"
            Me.txtBanner.Size = New System.Drawing.Size(154, 20)
            Me.txtBanner.TabIndex = 22
            '
            'rdoFocus
            '
            Me.rdoFocus.AutoSize = True
            Me.rdoFocus.Location = New System.Drawing.Point(485, 308)
            Me.rdoFocus.Name = "rdoFocus"
            Me.rdoFocus.Size = New System.Drawing.Size(81, 17)
            Me.rdoFocus.TabIndex = 23
            Me.rdoFocus.Text = "FocusMode"
            Me.rdoFocus.UseVisualStyleBackColor = True
            '
            'rdoEdit
            '
            Me.rdoEdit.AutoSize = True
            Me.rdoEdit.Checked = True
            Me.rdoEdit.Location = New System.Drawing.Point(409, 308)
            Me.rdoEdit.Name = "rdoEdit"
            Me.rdoEdit.Size = New System.Drawing.Size(70, 17)
            Me.rdoEdit.TabIndex = 24
            Me.rdoEdit.TabStop = True
            Me.rdoEdit.Text = "EditMode"
            Me.rdoEdit.UseVisualStyleBackColor = True
            '
            'bannerColorEdit
            '
            Me.bannerColorEdit.BackColor = System.Drawing.Color.Silver
            Me.bannerColorEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.bannerColorEdit.Buttons.Add(Me.buttonEditChildButton1)
            Me.bannerColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.bannerColorEdit.Controls.Add(Me.buttonEditChildButton1)
            Me.bannerColorEdit.Controls.Add(Me.textBoxExt1)
            Me.bannerColorEdit.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.bannerColorEdit.Location = New System.Drawing.Point(409, 335)
            Me.bannerColorEdit.Name = "bannerColorEdit"
            Me.bannerColorEdit.Size = New System.Drawing.Size(151, 21)
            Me.bannerColorEdit.TabIndex = 25
            Me.bannerColorEdit.TextBox = Me.textBoxExt1
            '
            'buttonEditChildButton1
            '
            Me.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.buttonEditChildButton1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonEditChildButton1.Image = Nothing
            Me.buttonEditChildButton1.Name = "buttonEditChildButton1"
            Me.buttonEditChildButton1.PreferredWidth = 20
            Me.buttonEditChildButton1.TabIndex = 1
            Me.buttonEditChildButton1.Text = "..."
            '
            'textBoxExt1
            '
            Me.textBoxExt1.BackColor = System.Drawing.Color.Silver
            Me.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBoxExt1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBoxExt1.Location = New System.Drawing.Point(3, 4)
            Me.textBoxExt1.Name = "textBoxExt1"
            Me.textBoxExt1.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt1.Size = New System.Drawing.Size(125, 13)
            Me.textBoxExt1.TabIndex = 0
            '
            'label13
            '
            Me.label13.BackColor = System.Drawing.Color.Transparent
            Me.label13.Image = CType(resources.GetObject("label13.Image"), System.Drawing.Image)
            Me.label13.Location = New System.Drawing.Point(497, 231)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(19, 25)
            Me.label13.TabIndex = 2
            Me.toolTip1.SetToolTip(Me.label13, "BannerTextProvider is a component " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "used to provide cue banner help text" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Com" & _
                    "boBoxAdv control.")
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(585, 597)
            Me.Controls.Add(Me.label13)
            Me.Controls.Add(Me.bannerColorEdit)
            Me.Controls.Add(Me.rdoEdit)
            Me.Controls.Add(Me.rdoFocus)
            Me.Controls.Add(Me.txtBanner)
            Me.Controls.Add(Me.btnSetBanner)
            Me.Controls.Add(Me.label10)
            Me.Controls.Add(Me.label11)
            Me.Controls.Add(Me.label12)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.label8)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.comboBoxAdv3)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.comboBoxAdv2)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.groupBox3)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ComboBoxAdv"
            Me.panel1.ResumeLayout(False)
            CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.dataSet21, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox3.ResumeLayout(False)
            CType(Me.ComboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox2.ResumeLayout(False)
            CType(Me.ComboBoxAdvBound, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxAdv3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bannerColorEdit, System.ComponentModel.ISupportInitialize).EndInit()
            Me.bannerColorEdit.ResumeLayout(False)
            Me.bannerColorEdit.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
		#End Region

		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			'To Fille the ComboBoxAdv1 with Month name items.
			For i As Integer = 1 To 12
				ComboBoxAdv1.Items.Add(CultureInfo.CurrentUICulture.DateTimeFormat.GetMonthName(i))
			Next i


			'To Fill the ComboBoxAdvBound with items from DataSource.
            Me.oleDbDataAdapter1.Fill(Me.dataSet11)
            Me.oleDbDataAdapter2.Fill(Me.dataSet21)

			ComboBoxAdvBound.DataSource = Me.dataSet21.Sex_Description
			ComboBoxAdvBound.DisplayMember = "Description"
			ComboBoxAdvBound.ValueMember = "ID"

			ComboBoxAdvBound.DataBindings.Add("SelectedValue", Me.dataSet11.Customers, "Sex")
			Me.comboBoxAdv2.SelectedIndex = 4
			AddHandler comboBoxAdv2.SelectedIndexChanged, AddressOf OnThemeChanged
			AddHandler Application.Idle, AddressOf Application_Idle
		End Sub



		#Region "ComboBoxAdv Events"
		Private Sub boundCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxAdvBound.SelectedIndexChanged
			Dim c As ComboBoxBaseDataBound = TryCast(sender, ComboBoxBaseDataBound)
			Me.textLog.Text += c.Name & "'s SelectedIndexChanged to:" & c.SelectedIndex & Constants.vbCrLf
		End Sub

		Private Sub combo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxAdvBound.SelectionChangeCommitted
			Dim c As ComboBoxBaseDataBound = TryCast(sender, ComboBoxBaseDataBound)
			Me.textLog.Text += c.Name & "'s SelectionChangeCommitted. New index is:" & c.SelectedIndex & Constants.vbCrLf
		End Sub

		Private Sub combo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxAdvBound.Validated
			Dim c As ComboBoxBaseDataBound = TryCast(sender, ComboBoxBaseDataBound)
			If Not c.SelectedItem Is Nothing Then
				Me.textLog.Text += c.Name & "has validated the new entry. New entry is:" & c.SelectedItem.ToString() & Constants.vbCrLf
			Else
				Me.textLog.Text += c.Name & "has validated the new entry. New entry is:" & c.Text & Constants.vbCrLf
			End If
		End Sub

		Private Sub combo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboBoxAdvBound.Validating
			Dim c As ComboBoxBaseDataBound = TryCast(sender, ComboBoxBaseDataBound)
			If Not c.SelectedItem Is Nothing Then
				Me.textLog.Text += c.Name & "is validating the new entry:" & c.SelectedItem.ToString() & Constants.vbCrLf
			Else
				Me.textLog.Text += c.Name & "is validating the new entry:" & c.Text & Constants.vbCrLf
			End If
		End Sub
		#End Region

		Private Sub chkNumbersOnly_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNumbersOnly.CheckedChanged
			ComboBoxAdv1.NumberOnly = chkNumbersOnly.Checked
		End Sub

		Private Sub chkCaseSens_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCaseSens.CheckedChanged
			ComboBoxAdv1.CaseSensitiveAutocomplete = chkCaseSens.Checked
		End Sub

		Private Sub chkAutoComp_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAutoComp.CheckedChanged
			ComboBoxAdv1.AutoComplete = chkAutoComp.Checked
		End Sub

		Private Sub chkSorted_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSorted.CheckedChanged
			ComboBoxAdv1.Sorted = chkSorted.Checked
		End Sub

		#Region "ThemeStyles"

		Private Sub OnThemeChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.comboBoxAdv2.SelectedItem.ToString()<>"" Then
				Select Case Me.comboBoxAdv2.SelectedItem.ToString()
					Case "Default"
						Me.ComboBoxAdv1.Style = VisualStyle.Default
						Me.comboBoxAdv2.Style = VisualStyle.Default
						Me.ComboBoxAdvBound.Style = VisualStyle.Default
						Me.comboBoxAdv3.Enabled = False
					Case "OfficeXP"
						Me.ComboBoxAdv1.Style = VisualStyle.OfficeXP
						Me.comboBoxAdv2.Style = VisualStyle.OfficeXP
						Me.ComboBoxAdvBound.Style = VisualStyle.OfficeXP
						Me.comboBoxAdv3.Enabled = False
					Case "Office2003"
						Me.ComboBoxAdv1.Style = VisualStyle.Office2003
						Me.comboBoxAdv2.Style = VisualStyle.Office2003
						Me.ComboBoxAdvBound.Style = VisualStyle.Office2003
						Me.comboBoxAdv3.Enabled = False
					Case "VS2005"
						Me.ComboBoxAdv1.Style = VisualStyle.VS2005
						Me.comboBoxAdv2.Style = VisualStyle.VS2005
						Me.ComboBoxAdvBound.Style = VisualStyle.VS2005
						Me.comboBoxAdv3.Enabled = False
					Case "Office2007"
						Me.ComboBoxAdv1.Style = VisualStyle.Office2007
						Me.comboBoxAdv2.Style = VisualStyle.Office2007
						Me.ComboBoxAdvBound.Style = VisualStyle.Office2007
						Me.comboBoxAdv3.Enabled = True
				End Select
			End If
		End Sub

		#End Region

		#Region "Office2007 Color Scheme"

		Private Sub comboBoxAdv3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxAdv3.SelectedIndexChanged
			Select Case Me.comboBoxAdv3.SelectedItem.ToString()
				Case "Blue"
						Me.ComboBoxAdv1.Office2007ColorTheme = Office2007Theme.Blue
						Me.comboBoxAdv2.Office2007ColorTheme = Office2007Theme.Blue
						Me.comboBoxAdv3.Office2007ColorTheme = Office2007Theme.Blue
						Me.ComboBoxAdvBound.Office2007ColorTheme = Office2007Theme.Blue
						Exit Select
				Case "Silver"
						Me.ComboBoxAdv1.Office2007ColorTheme = Office2007Theme.Silver
						Me.comboBoxAdv2.Office2007ColorTheme = Office2007Theme.Silver
						Me.comboBoxAdv3.Office2007ColorTheme = Office2007Theme.Silver
						Me.ComboBoxAdvBound.Office2007ColorTheme = Office2007Theme.Silver
						Exit Select
				Case "Black"
						Me.ComboBoxAdv1.Office2007ColorTheme = Office2007Theme.Black
						Me.comboBoxAdv2.Office2007ColorTheme = Office2007Theme.Black
						Me.comboBoxAdv3.Office2007ColorTheme = Office2007Theme.Black
						Me.ComboBoxAdvBound.Office2007ColorTheme = Office2007Theme.Black
                    Exit Select
                Case "Managed"
                    Me.ComboBoxAdv1.Office2007ColorTheme = Office2007Theme.Managed
                    Me.comboBoxAdv2.Office2007ColorTheme = Office2007Theme.Managed
                    Me.comboBoxAdv3.Office2007ColorTheme = Office2007Theme.Managed
                    Me.ComboBoxAdvBound.Office2007ColorTheme = Office2007Theme.Managed

                    Office2007Colors.ApplyManagedColors(Me, Color.GreenYellow)
                    Exit Select
            End Select
		End Sub
		#End Region

		#Region "BannerText Settings"
		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSetBanner.Click
			Dim mode As BannerTextMode

			If rdoFocus.Checked Then
				mode = BannerTextMode.FocusMode
			Else
				mode = BannerTextMode.EditMode
			End If

			Dim bInfo As BannerTextInfo = Me.bannerTextProvider1.GetBannerText(Me.ComboBoxAdv1)
			bInfo.Text = Me.txtBanner.Text
			bInfo.Color = Me.bannerColorEdit.TextBox.BackColor
			bInfo.Mode = mode

			Dim bInfo2 As BannerTextInfo = Me.bannerTextProvider1.GetBannerText(Me.ComboBoxAdvBound)
			bInfo2.Text = Me.txtBanner.Text
			bInfo2.Color = Me.bannerColorEdit.TextBox.BackColor
			bInfo2.Mode = mode
	
			Me.ComboBoxAdv1.Refresh()
			Me.ComboBoxAdvBound.Refresh()
		End Sub

		Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
			If txtBanner.Text = "" Then
				Me.btnSetBanner.Enabled = False
			Else
				Me.btnSetBanner.Enabled = True
			End If
		End Sub

		Private Sub bannerColorEdit_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles bannerColorEdit.ButtonClicked
            If colorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.bannerColorEdit.TextBox.BackColor = colorDialog1.Color
            End If
		End Sub
#End Region

	End Class
End Namespace
