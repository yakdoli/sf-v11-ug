Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Text
Imports System.Data.SqlClient

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Diagnostics
Imports Syncfusion.Styles

Namespace DataBoundGridEvents
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1 : Inherits System.Windows.Forms.Form
        Private panel1 As System.Windows.Forms.Panel
        Friend splitterControl1 As Syncfusion.Windows.Forms.SplitterControl
        Private panel2 As System.Windows.Forms.Panel
        Private output As System.Windows.Forms.ListBox
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
        Private tracer As GridEventTracer
        Friend gridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
        Private contextMenu1 As System.Windows.Forms.ContextMenu
        Private WithEvents menuItem1 As System.Windows.Forms.MenuItem
        Private oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
        Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
        Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
        Private oleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
        Private oleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
        Private oleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
        Private WithEvents dataSet11 As DataSet1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Try
                Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid1.ico"))
                Me.Icon = ico
            Catch ex As Exception
            End Try
            'this.oleDbDataAdapter1.Fill(this.dataSet11.Employees);
            ReadXml(Me.dataSet11, "data.xml")

            Me.ActiveControl = Me.splitterControl1
            splitterControl1.ThemesEnabled = True

            gridDataBoundGrid1.Initialize()
            gridDataBoundGrid1.ThemesEnabled = True
            gridDataBoundGrid1.ControllerOptions = gridDataBoundGrid1.ControllerOptions And Not (GridControllerOptions.OleDataSource Or GridControllerOptions.OleDropTarget)
            gridDataBoundGrid1.CurrentCell.MoveTo(1, 1)
            gridDataBoundGrid1.BaseStylesMap("Header").StyleInfo.Enabled = False
            gridDataBoundGrid1.VScrollPixel = True
            gridDataBoundGrid1.HScrollPixel = True

            Me.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue
            Me.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
            Me.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
            Dim style As GridStyleInfo = gridDataBoundGrid1.BaseStylesMap("Header").StyleInfo
            style.TextColor = Color.MidnightBlue
            style.Font.Facename = "Verdana"
            Me.BackColor = Color.FromArgb(223, 227, 239)
            Me.StartPosition = FormStartPosition.CenterScreen
            tracer = New GridEventTracer(Me.splitterControl1, Me.output)

            checkBox1.Checked = tracer.DisplayMouseMessages
            checkBox2.Checked = tracer.Enabled

            Me.output.ContextMenu = Me.contextMenu1
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
            Dim n As Integer
            For n = 0 To 9
                If System.IO.File.Exists(xmlFileName) Then
                    ds.ReadXml(xmlFileName)
                    Exit For
                End If
                xmlFileName = "..\" & xmlFileName
            Next n
        End Sub
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Dim GridStyleInfo1 As Syncfusion.Windows.Forms.Grid.GridStyleInfo = New Syncfusion.Windows.Forms.Grid.GridStyleInfo
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.panel1 = New System.Windows.Forms.Panel
            Me.splitterControl1 = New Syncfusion.Windows.Forms.SplitterControl
            Me.gridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
            Me.dataSet11 = New DataSet1
            Me.panel2 = New System.Windows.Forms.Panel
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.output = New System.Windows.Forms.ListBox
            Me.contextMenu1 = New System.Windows.Forms.ContextMenu
            Me.menuItem1 = New System.Windows.Forms.MenuItem
            Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
            Me.oleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection
            Me.oleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
            Me.panel1.SuspendLayout()
            Me.splitterControl1.SuspendLayout()
            CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel1.Controls.Add(Me.splitterControl1)
            Me.panel1.Location = New System.Drawing.Point(8, 8)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(768, 192)
            Me.panel1.TabIndex = 0
            '
            'splitterControl1
            '
            Me.splitterControl1.Controls.Add(Me.gridDataBoundGrid1)
            Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitterControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitterControl1.Name = "splitterControl1"
            Me.splitterControl1.Size = New System.Drawing.Size(768, 192)
            Me.splitterControl1.SplitBars = CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars)
            Me.splitterControl1.TabIndex = 0
            Me.splitterControl1.Text = "splitterControl1"
            Me.splitterControl1.ThemesEnabled = False
            '
            'gridDataBoundGrid1
            '
            Me.gridDataBoundGrid1.AllowDragSelectedCols = True
            Me.gridDataBoundGrid1.DataSource = Me.dataSet11.Employees
            Me.gridDataBoundGrid1.FillSplitterPane = True
            Me.gridDataBoundGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.gridDataBoundGrid1.Location = New System.Drawing.Point(0, 0)
            Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
            Me.gridDataBoundGrid1.OptimizeInsertRemoveCells = True
            Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
            Me.gridDataBoundGrid1.Size = New System.Drawing.Size(747, 171)
            Me.gridDataBoundGrid1.SmartSizeBox = False
            Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
            GridStyleInfo1.Font.Bold = False
            GridStyleInfo1.Font.Facename = "Microsoft Sans Serif"
            GridStyleInfo1.Font.Italic = False
            GridStyleInfo1.Font.Size = 8.25!
            GridStyleInfo1.Font.Strikeout = False
            GridStyleInfo1.Font.Underline = False
            Me.gridDataBoundGrid1.TableStyle = GridStyleInfo1
            Me.gridDataBoundGrid1.Text = "gridDataBoundGrid1"
            Me.gridDataBoundGrid1.UseListChangedEvent = True
            '
            'dataSet11
            '
            Me.dataSet11.DataSetName = "DataSet1"
            Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'panel2
            '
            Me.panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel2.Controls.Add(Me.checkBox2)
            Me.panel2.Controls.Add(Me.checkBox1)
            Me.panel2.Controls.Add(Me.output)
            Me.panel2.Location = New System.Drawing.Point(0, 208)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(776, 336)
            Me.panel2.TabIndex = 1
            '
            'checkBox2
            '
            Me.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.checkBox2.Location = New System.Drawing.Point(632, 8)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(112, 24)
            Me.checkBox2.TabIndex = 2
            Me.checkBox2.Text = " Enable tracing"
            '
            'checkBox1
            '
            Me.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.checkBox1.Location = New System.Drawing.Point(416, 8)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(208, 24)
            Me.checkBox1.TabIndex = 1
            Me.checkBox1.Text = "Trace Mouse and control Message"
            '
            'output
            '
            Me.output.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.output.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.output.Location = New System.Drawing.Point(0, 32)
            Me.output.Name = "output"
            Me.output.Size = New System.Drawing.Size(776, 303)
            Me.output.TabIndex = 0
            '
            'contextMenu1
            '
            Me.contextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1})
            '
            'menuItem1
            '
            Me.menuItem1.Index = 0
            Me.menuItem1.Text = "&Clearwindow"
            '
            'oleDbDataAdapter1
            '
            Me.oleDbDataAdapter1.DeleteCommand = Me.oleDbDeleteCommand1
            Me.oleDbDataAdapter1.InsertCommand = Me.oleDbInsertCommand1
            Me.oleDbDataAdapter1.SelectCommand = Me.oleDbSelectCommand1
            Me.oleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Employees", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("Title", "Title"), New System.Data.Common.DataColumnMapping("Region", "Region")})})
            Me.oleDbDataAdapter1.UpdateCommand = Me.oleDbUpdateCommand1
            '
            'oleDbDeleteCommand1
            '
            Me.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText")
            Me.oleDbDeleteCommand1.Connection = Me.oleDbConnection1
            Me.oleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Region", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Region", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Title", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Title1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Title", System.Data.DataRowVersion.Original, Nothing)})
            '
            'oleDbConnection1
            '
            Me.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString")
            '
            'oleDbInsertCommand1
            '
            Me.oleDbInsertCommand1.CommandText = "INSERT INTO Employees(FirstName, LastName, Address, City, Country, Title, Region)" & _
                " VALUES (?, ?, ?, ?, ?, ?, ?)"
            Me.oleDbInsertCommand1.Connection = Me.oleDbConnection1
            Me.oleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"), New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 20, "LastName"), New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"), New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"), New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"), New System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 30, "Title"), New System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region")})
            '
            'oleDbSelectCommand1
            '
            Me.oleDbSelectCommand1.CommandText = "SELECT EmployeeID, FirstName, LastName, Address, City, Country, Title, Region FRO" & _
                "M Employees"
            Me.oleDbSelectCommand1.Connection = Me.oleDbConnection1
            '
            'oleDbUpdateCommand1
            '
            Me.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText")
            Me.oleDbUpdateCommand1.Connection = Me.oleDbConnection1
            Me.oleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"), New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 20, "LastName"), New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"), New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"), New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"), New System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 30, "Title"), New System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"), New System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Region", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Region", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Title", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Title1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Title", System.Data.DataRowVersion.Original, Nothing)})
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(776, 542)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Data Bound Grid Events Demo"
            Me.panel1.ResumeLayout(False)
            Me.splitterControl1.ResumeLayout(False)
            CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
            tracer.Enabled = Me.checkBox2.Checked
        End Sub
        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            tracer.DisplayMouseMessages = checkBox1.Checked

        End Sub
        Private Sub menuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem1.Click
            Me.output.Items.Clear()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace
