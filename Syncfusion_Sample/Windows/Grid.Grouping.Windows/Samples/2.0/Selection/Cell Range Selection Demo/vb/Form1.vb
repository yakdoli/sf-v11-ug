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
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms

''' <summary>
''' Summary description for Form1.
''' </summary>
Public Class Form1
    Inherits MetroForm
    Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
    Private oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Private oleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Private oleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Private oleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
    Private dataSet11 As DataSet1
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Private WithEvents radioButton1 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
    Private WithEvents radioButton2 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
    Private WithEvents radioButton3 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
    Private WithEvents radioButton4 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
    Private WithEvents radioButton5 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
    Private WithEvents radioButton6 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.Container = Nothing
    Private propertyGrid1 As PropertyGrid
    Private Const connection As String = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""{0}"";Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False"

    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        Dim mdbFileName As String = FindDatabase("Common\Data\ACC.mdb")
        Me.oleDbConnection1.ConnectionString = String.Format(Form1.connection, mdbFileName)
        Me.oleDbDataAdapter1.Fill(Me.dataSet11.Statistics)
        Try
            Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try


        Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
        Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
        Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
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


    Private Function FindDatabase(ByVal mdbFileName As String) As String
        For n As Integer = 0 To 9
            If System.IO.File.Exists(mdbFileName) Then
                Return mdbFileName
            End If
            mdbFileName = "..\" & mdbFileName
        Next n
        Return ""
    End Function
    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
        Me.dataSet11 = New DataSet1()
        Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.oleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.oleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.oleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioButton6 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
        Me.radioButton5 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
        Me.radioButton4 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
        Me.radioButton3 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
        Me.radioButton2 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
        Me.radioButton1 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
        Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
        CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gradientPanel1.SuspendLayout()
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.radioButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radioButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radioButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radioButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' gradientPanel1
        ' 
        Me.gradientPanel1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gradientPanel1.Controls.Add(Me.gridGroupingControl1)
        Me.gradientPanel1.Location = New System.Drawing.Point(12, 12)
        Me.gradientPanel1.Name = "gradientPanel1"
        Me.gradientPanel1.Size = New System.Drawing.Size(481, 413)
        Me.gradientPanel1.TabIndex = 0
        ' 
        ' gridGroupingControl1
        ' 
        Me.gridGroupingControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
        Me.gridGroupingControl1.DataSource = Me.dataSet11.Statistics
        Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridGroupingControl1.Location = New System.Drawing.Point(16, 16)
        Me.gridGroupingControl1.Name = "gridGroupingControl1"
        Me.gridGroupingControl1.Size = New System.Drawing.Size(443, 375)
        Me.gridGroupingControl1.TabIndex = 0
        Me.gridGroupingControl1.TableDescriptor.AllowNew = False
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Bold = False
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Italic = False
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Size = 8.25F
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Strikeout = False
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Underline = False
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Unit = System.Drawing.GraphicsUnit.Point
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(235)))))))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyHeaderCell.Font.Bold = False
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyHeaderCell.Font.Facename = "Arial"
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyHeaderCell.Font.Italic = False
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyHeaderCell.Font.Size = 9.75F
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyHeaderCell.Font.Strikeout = False
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyHeaderCell.Font.Underline = False
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyHeaderCell.Font.Unit = System.Drawing.GraphicsUnit.Point
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Font.Bold = False
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Font.Facename = "Arial"
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Font.Italic = False
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Font.Size = 9.0F
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Font.Strikeout = False
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Font.Underline = False
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Font.Unit = System.Drawing.GraphicsUnit.Point
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208))))), (CInt(Fix((CByte(208)))))))
        Me.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
        Me.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
        Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
        Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
        Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.Silver, Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.Text = "gridGroupingControl1"
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
        Me.gridGroupingControl1.VersionInfo = "4.401.0.50"
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
        Me.oleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Statistics", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("losses", "losses"), New System.Data.Common.DataColumnMapping("School", "School"), New System.Data.Common.DataColumnMapping("Sport", "Sport"), New System.Data.Common.DataColumnMapping("ties", "ties"), New System.Data.Common.DataColumnMapping("wins", "wins"), New System.Data.Common.DataColumnMapping("year", "year")})})
        Me.oleDbDataAdapter1.UpdateCommand = Me.oleDbUpdateCommand1
        ' 
        ' oleDbDeleteCommand1
        ' 
        Me.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText")
        Me.oleDbDeleteCommand1.Connection = Me.oleDbConnection1
        Me.oleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_School", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "School", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_School1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "School", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sport", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Sport", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sport1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Sport", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_losses", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "losses", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_losses1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "losses", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ties", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ties", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ties1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ties", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_wins", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "wins", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_wins1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "wins", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_year", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "year", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_year1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "year", System.Data.DataRowVersion.Original, Nothing)})
        ' 
        ' oleDbConnection1
        ' 
        Me.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString")
        ' 
        ' oleDbInsertCommand1
        ' 
        Me.oleDbInsertCommand1.CommandText = "INSERT INTO Statistics(losses, School, Sport, ties, wins, year) VALUES (?, ?, ?, " & "?, ?, ?)"
        Me.oleDbInsertCommand1.Connection = Me.oleDbConnection1
        Me.oleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("losses", System.Data.OleDb.OleDbType.Integer, 0, "losses"), New System.Data.OleDb.OleDbParameter("School", System.Data.OleDb.OleDbType.VarWChar, 255, "School"), New System.Data.OleDb.OleDbParameter("Sport", System.Data.OleDb.OleDbType.VarWChar, 255, "Sport"), New System.Data.OleDb.OleDbParameter("ties", System.Data.OleDb.OleDbType.Integer, 0, "ties"), New System.Data.OleDb.OleDbParameter("wins", System.Data.OleDb.OleDbType.Integer, 0, "wins"), New System.Data.OleDb.OleDbParameter("year", System.Data.OleDb.OleDbType.Integer, 0, "year")})
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
        Me.oleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("losses", System.Data.OleDb.OleDbType.Integer, 0, "losses"), New System.Data.OleDb.OleDbParameter("School", System.Data.OleDb.OleDbType.VarWChar, 255, "School"), New System.Data.OleDb.OleDbParameter("Sport", System.Data.OleDb.OleDbType.VarWChar, 255, "Sport"), New System.Data.OleDb.OleDbParameter("ties", System.Data.OleDb.OleDbType.Integer, 0, "ties"), New System.Data.OleDb.OleDbParameter("wins", System.Data.OleDb.OleDbType.Integer, 0, "wins"), New System.Data.OleDb.OleDbParameter("year", System.Data.OleDb.OleDbType.Integer, 0, "year"), New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_School", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "School", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_School1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "School", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sport", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Sport", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sport1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Sport", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_losses", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "losses", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_losses1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "losses", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ties", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ties", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ties1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ties", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_wins", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "wins", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_wins1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "wins", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_year", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "year", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_year1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "year", System.Data.DataRowVersion.Original, Nothing)})
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.radioButton6)
        Me.groupBox1.Controls.Add(Me.radioButton5)
        Me.groupBox1.Controls.Add(Me.radioButton4)
        Me.groupBox1.Controls.Add(Me.radioButton3)
        Me.groupBox1.Controls.Add(Me.radioButton2)
        Me.groupBox1.Controls.Add(Me.radioButton1)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.groupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.groupBox1.Location = New System.Drawing.Point(16, 8)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(293, 131)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Selection Mode"
        ' 
        ' radioButton6
        ' 
        Me.radioButton6.DrawFocusRectangle = False
        Me.radioButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.radioButton6.ForeColor = System.Drawing.Color.DimGray
        Me.radioButton6.Location = New System.Drawing.Point(188, 98)
        Me.radioButton6.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.radioButton6.Name = "radioButton6"
        Me.radioButton6.Size = New System.Drawing.Size(106, 24)
        Me.radioButton6.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
        Me.radioButton6.TabIndex = 5
        Me.radioButton6.Text = "None"
        Me.radioButton6.ThemesEnabled = False
        '			Me.radioButton6.CheckChanged += New System.EventHandler(Me.radioButton6_CheckedChanged)
        ' 
        ' radioButton5
        ' 
        Me.radioButton5.DrawFocusRectangle = False
        Me.radioButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.radioButton5.ForeColor = System.Drawing.Color.DimGray
        Me.radioButton5.Location = New System.Drawing.Point(34, 98)
        Me.radioButton5.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.radioButton5.Name = "radioButton5"
        Me.radioButton5.Size = New System.Drawing.Size(128, 24)
        Me.radioButton5.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
        Me.radioButton5.TabIndex = 4
        Me.radioButton5.Text = "Row and Column"
        Me.radioButton5.ThemesEnabled = False
        '			Me.radioButton5.CheckChanged += New System.EventHandler(Me.radioButton5_CheckedChanged)
        ' 
        ' radioButton4
        ' 
        Me.radioButton4.DrawFocusRectangle = False
        Me.radioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.radioButton4.ForeColor = System.Drawing.Color.DimGray
        Me.radioButton4.Location = New System.Drawing.Point(188, 64)
        Me.radioButton4.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.radioButton4.Name = "radioButton4"
        Me.radioButton4.Size = New System.Drawing.Size(106, 24)
        Me.radioButton4.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
        Me.radioButton4.TabIndex = 3
        Me.radioButton4.Text = "Column Only"
        Me.radioButton4.ThemesEnabled = False
        '			Me.radioButton4.CheckChanged += New System.EventHandler(Me.radioButton4_CheckedChanged)
        ' 
        ' radioButton3
        ' 
        Me.radioButton3.DrawFocusRectangle = False
        Me.radioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.radioButton3.ForeColor = System.Drawing.Color.DimGray
        Me.radioButton3.Location = New System.Drawing.Point(188, 32)
        Me.radioButton3.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.radioButton3.Name = "radioButton3"
        Me.radioButton3.Size = New System.Drawing.Size(106, 24)
        Me.radioButton3.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
        Me.radioButton3.TabIndex = 2
        Me.radioButton3.Text = "Row Only"
        Me.radioButton3.ThemesEnabled = False
        '			Me.radioButton3.CheckChanged += New System.EventHandler(Me.radioButton3_CheckedChanged)
        ' 
        ' radioButton2
        ' 
        Me.radioButton2.DrawFocusRectangle = False
        Me.radioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.radioButton2.ForeColor = System.Drawing.Color.DimGray
        Me.radioButton2.Location = New System.Drawing.Point(34, 64)
        Me.radioButton2.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(104, 24)
        Me.radioButton2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
        Me.radioButton2.TabIndex = 1
        Me.radioButton2.Text = "Cell Only"
        Me.radioButton2.ThemesEnabled = False
        '			Me.radioButton2.CheckChanged += New System.EventHandler(Me.radioButton2_CheckedChanged)
        ' 
        ' radioButton1
        ' 
        Me.radioButton1.DrawFocusRectangle = False
        Me.radioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.radioButton1.ForeColor = System.Drawing.Color.DimGray
        Me.radioButton1.Location = New System.Drawing.Point(34, 32)
        Me.radioButton1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(104, 24)
        Me.radioButton1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
        Me.radioButton1.TabIndex = 0
        Me.radioButton1.Text = "Default"
        Me.radioButton1.ThemesEnabled = False
        '			Me.radioButton1.CheckChanged += New System.EventHandler(Me.radioButton1_CheckedChanged)
        ' 
        ' gradientPanel2
        ' 
        Me.gradientPanel2.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gradientPanel2.Controls.Add(Me.groupBox1)
        Me.gradientPanel2.Location = New System.Drawing.Point(517, 12)
        Me.gradientPanel2.Name = "gradientPanel2"
        Me.gradientPanel2.Size = New System.Drawing.Size(323, 159)
        Me.gradientPanel2.TabIndex = 2
        ' 
        ' propertyGrid1
        ' 
        Me.propertyGrid1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.propertyGrid1.BackColor = System.Drawing.Color.White
        Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.White
        Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
        Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
        Me.propertyGrid1.LineColor = System.Drawing.Color.White
        Me.propertyGrid1.Location = New System.Drawing.Point(517, 192)
        Me.propertyGrid1.Name = "propertyGrid1"
        Me.propertyGrid1.Size = New System.Drawing.Size(323, 233)
        Me.propertyGrid1.TabIndex = 15
        ' 
        ' Form1
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.BorderThickness = 2
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.ClientSize = New System.Drawing.Size(852, 437)
        Me.Controls.Add(Me.propertyGrid1)
        Me.Controls.Add(Me.gradientPanel2)
        Me.Controls.Add(Me.gradientPanel1)
        Me.DropShadow = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cell Range Selection Demo"
        '			Me.Load += New System.EventHandler(Me.Form1_Load)
        CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gradientPanel1.ResumeLayout(False)
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        CType(Me.radioButton6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radioButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radioButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radioButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radioButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radioButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gradientPanel2.ResumeLayout(False)
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

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gridGroupingControl1.TableModel.Options.RefreshCurrentCellBehavior = GridRefreshCurrentCellBehavior.RefreshCell
        Me.gridGroupingControl1.TableModel.Options.ShowCurrentCellBorderBehavior = GridShowCurrentCellBorder.GrayWhenLostFocus
        AddHandler gridGroupingControl1.TableControl.PrepareViewStyleInfo, AddressOf TableControl_PrepareViewStyleInfo
        AddHandler gridGroupingControl1.TableControl.CurrentCellStartEditing, AddressOf TableControl_CurrentCellStartEditing
        AddHandler gridGroupingControl1.TableControl.CurrentCellActivating, AddressOf TableControl_CurrentCellActivating

        Me.gridGroupingControl1.TableModel.ColWidths.ResizeToFit(GridRangeInfo.Cells(1, 1, Me.gridGroupingControl1.TableModel.RowCount, Me.gridGroupingControl1.TableModel.ColCount))
    End Sub
    Private Sub TableControl_CurrentCellActivating(ByVal sender As Object, ByVal e As GridCurrentCellActivatingEventArgs)
        Me.gridGroupingControl1.TableControl.Refresh()
    End Sub

    Private Sub TableControl_CurrentCellStartEditing(ByVal sender As Object, ByVal e As CancelEventArgs)
        e.Cancel = True
    End Sub

    Private Sub TableControl_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs)
        Dim cc As GridCurrentCell = gridGroupingControl1.TableControl.CurrentCell
        Dim grid As GridControlBase = Me.gridGroupingControl1.TableControl.CurrentCell.Grid

        If radioButton3.Checked Then
            ' Highlight the current row with SystemColors.Highlight and bold font
            If e.RowIndex > grid.Model.Rows.HeaderCount AndAlso e.ColIndex > grid.Model.Cols.HeaderCount AndAlso cc.HasCurrentCellAt(e.RowIndex) Then
                e.Style.Interior = New BrushInfo(SystemColors.Highlight)
                e.Style.TextColor = SystemColors.HighlightText
                e.Style.Font.Bold = True
            End If
        ElseIf radioButton2.Checked Then
            ' Highlight the current cell with SystemColors.Highlight and bold font
            If e.RowIndex > grid.Model.Rows.HeaderCount AndAlso e.ColIndex > grid.Model.Cols.HeaderCount AndAlso cc.HasCurrentCellAt(e.RowIndex, e.ColIndex) Then
                e.Style.Interior = New BrushInfo(SystemColors.Highlight)
                e.Style.TextColor = SystemColors.HighlightText
                e.Style.Font.Bold = True
            End If
        ElseIf radioButton4.Checked Then
            ' Highlight the current column with SystemColors.Highlight and bold font
            If e.RowIndex > grid.Model.Rows.HeaderCount AndAlso e.ColIndex > grid.Model.Cols.HeaderCount AndAlso cc.ColIndex = e.ColIndex Then
                e.Style.Interior = New BrushInfo(SystemColors.Highlight)
                e.Style.TextColor = SystemColors.HighlightText
                e.Style.Font.Bold = True
            End If
        ElseIf radioButton5.Checked Then
            ' Highlight the current row & col with SystemColors.Highlight and bold font
            If e.RowIndex > grid.Model.Rows.HeaderCount AndAlso e.ColIndex > grid.Model.Cols.HeaderCount AndAlso (cc.RowIndex = e.RowIndex OrElse cc.ColIndex = e.ColIndex) Then
                e.Style.Interior = New BrushInfo(SystemColors.Highlight)
                e.Style.TextColor = SystemColors.HighlightText
                e.Style.Font.Bold = True
            End If
        End If

    End Sub

    Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton1.CheckChanged
        If Me.radioButton1.Checked Then
            Me.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.One
        Else
            Me.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.None
        End If
        For Each t As Table In Me.gridGroupingControl1.Engine.EnumerateTables()
            Me.gridGroupingControl1.GetTable(t.TableDescriptor.Name).SelectedRecords.Clear()
        Next t
    End Sub

    Private Sub radioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton2.CheckChanged
        Me.gridGroupingControl1.TableControl.Refresh()
    End Sub

    Private Sub radioButton3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton3.CheckChanged
        Me.gridGroupingControl1.TableControl.Refresh()
    End Sub

    Private Sub radioButton4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton4.CheckChanged
        Me.gridGroupingControl1.TableControl.Refresh()
    End Sub

    Private Sub radioButton5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton5.CheckChanged
        Me.gridGroupingControl1.TableControl.Refresh()
    End Sub

    Private Sub radioButton6_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton6.CheckChanged
        If Me.radioButton6.Checked Then
            Me.gridGroupingControl1.TableModel.Options.ShowCurrentCellBorderBehavior = GridShowCurrentCellBorder.HideAlways
        Else
            Me.gridGroupingControl1.TableModel.Options.ShowCurrentCellBorderBehavior = GridShowCurrentCellBorder.GrayWhenLostFocus
        End If
    End Sub
End Class
