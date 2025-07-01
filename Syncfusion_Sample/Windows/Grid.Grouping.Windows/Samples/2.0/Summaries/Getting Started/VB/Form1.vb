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

Namespace SummaryTutorial
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
		Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
		Private dataSet11 As SummaryTutorial.DataSet1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
		Private propertyGrid1 As PropertyGrid
		Private panel1 As Panel
		Private Const connection As String = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""{0}"";Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False"

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
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
			Dim mdbFileName As String = FindDatabase("Common\Data\ACC.mdb")
			Me.oleDbConnection1.ConnectionString = String.Format(Form1.connection, mdbFileName)
			Me.oleDbDataAdapter1.Fill(Me.dataSet11)
			Me.gridGroupingControl1.TableModel.Properties.RowHeaders=False
			Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.Appearance.AnySummaryCell.BackColor = Color.FromArgb(255, 231, 162)
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
			Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
			Me.dataSet11 = New SummaryTutorial.DataSet1()
			Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
			Me.oleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection()
			Me.oleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
			Me.panel1 = New System.Windows.Forms.Panel()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
			Me.gridGroupingControl1.DataSource = Me.dataSet11.Statistics
			Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridGroupingControl1.Location = New System.Drawing.Point(12, 0)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.ShowGroupDropArea = True
			Me.gridGroupingControl1.Size = New System.Drawing.Size(447, 430)
			Me.gridGroupingControl1.TabIndex = 0
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
			Me.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
			Me.gridGroupingControl1.TableDescriptor.SummaryRows.Add(New Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryRowDescriptor("Row 1", New Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryColumnDescriptor() { New Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryColumnDescriptor("Won", Syncfusion.Grouping.SummaryType.Int32Aggregate, "wins", "{Sum}"), New Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryColumnDescriptor("Lost", Syncfusion.Grouping.SummaryType.Int32Aggregate, "losses", "{Sum}")}))
			Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
			Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
			Me.gridGroupingControl1.Text = "gridGroupingControl1"
			Me.gridGroupingControl1.TopLevelGroupOptions.RepaintCaptionWhenItemsChanged = True
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
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
			Me.oleDbDeleteCommand1.Connection = Me.oleDbConnection1
			Me.oleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_School", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "School", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_School1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "School", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sport", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Sport", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sport1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Sport", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_losses", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "losses", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_losses1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "losses", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ties", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ties", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ties1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ties", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_wins", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "wins", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_wins1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "wins", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_year", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "year", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_year1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "year", System.Data.DataRowVersion.Original, Nothing)})
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
			Me.oleDbUpdateCommand1.Connection = Me.oleDbConnection1
			Me.oleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() { New System.Data.OleDb.OleDbParameter("losses", System.Data.OleDb.OleDbType.Integer, 0, "losses"), New System.Data.OleDb.OleDbParameter("School", System.Data.OleDb.OleDbType.VarWChar, 255, "School"), New System.Data.OleDb.OleDbParameter("Sport", System.Data.OleDb.OleDbType.VarWChar, 255, "Sport"), New System.Data.OleDb.OleDbParameter("ties", System.Data.OleDb.OleDbType.Integer, 0, "ties"), New System.Data.OleDb.OleDbParameter("wins", System.Data.OleDb.OleDbType.Integer, 0, "wins"), New System.Data.OleDb.OleDbParameter("year", System.Data.OleDb.OleDbType.Integer, 0, "year"), New System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_School", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "School", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_School1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "School", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sport", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Sport", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sport1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Sport", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_losses", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "losses", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_losses1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "losses", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ties", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ties", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ties1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ties", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_wins", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "wins", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_wins1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "wins", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_year", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "year", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_year1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "year", System.Data.DataRowVersion.Original, Nothing)})
			' 
			' propertyGrid1
			' 
			Me.propertyGrid1.Anchor = System.Windows.Forms.AnchorStyles.Left
			Me.propertyGrid1.BackColor = System.Drawing.Color.White
			Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.White
			Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
			Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
			Me.propertyGrid1.LineColor = System.Drawing.Color.White
			Me.propertyGrid1.Location = New System.Drawing.Point(472, 0)
			Me.propertyGrid1.Name = "propertyGrid1"
			Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
			Me.propertyGrid1.Size = New System.Drawing.Size(223, 430)
			Me.propertyGrid1.TabIndex = 14
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.DimGray
			Me.panel1.ForeColor = System.Drawing.Color.DimGray
			Me.panel1.Location = New System.Drawing.Point(465, 12)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(1, 405)
			Me.panel1.TabIndex = 15
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(707, 444)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.propertyGrid1)
			Me.Controls.Add(Me.gridGroupingControl1)
			Me.DropShadow = True
			Me.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Summary Tutorial"
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
	End Class
End Namespace
