Imports Microsoft.VisualBasic
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

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Text
Imports System.Xml
Imports System.Runtime.Serialization

Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System.IO


''' <summary>
''' Summary description for Form1.
''' </summary>
Public Class Form1
    Inherits Syncfusion.Windows.Forms.MetroForm
    Private dataSet11 As DataSet1
    Private WithEvents gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.Container = Nothing
    Private propertyGrid1 As PropertyGrid
    Public Shared ReadOnly connString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")

    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        Dim commandstring As String = "select * from Employees"

        Dim da As New SqlCeDataAdapter(commandstring, connString)
        Try
            da.Fill(dataSet11, "Employees")
        Catch ex As SqlException
            ShowErrorMessage(ex)
        End Try
        Try
            Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch ex As Exception

        End Try
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        Me.gridGroupingControl1.Appearance.AnyCell.ImageSizeMode = GridImageSizeMode.CenterImage
        Me.gridGroupingControl1.IntelliMousePanning = True

        Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridGroupingControl1.TableOptions.GridLineBorder = New GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
        Me.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana"
        Me.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue
        Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        AddHandler gridGroupingControl1.TableControl.ResizingRows, AddressOf TableControl_ResizingRows
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
    Private Shared Function FindFile(ByVal fileName As String) As String
        ' Check both in parent folder and Parent\Data folders.
        Dim dataFileName As String = "Common\Data\" & fileName
        For n As Integer = 0 To 11
            If System.IO.File.Exists(fileName) Then
                Return New FileInfo(fileName).FullName
            End If
            If System.IO.File.Exists(dataFileName) Then
                Return New FileInfo(dataFileName).FullName
            End If
            fileName = "..\" & fileName
            dataFileName = "..\" & dataFileName
        Next n

        Return fileName
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
        Dim GridColumnDescriptor1 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor
        Dim GridColumnDescriptor2 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor
        Dim GridColumnDescriptor3 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor
        Dim GridColumnDescriptor4 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor
        Dim GridColumnDescriptor5 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor
        Dim GridColumnDescriptor6 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor
        Dim GridColumnDescriptor7 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor
        Dim GridColumnDescriptor8 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor
        Dim GridColumnSetDescriptor1 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor
        Dim GridColumnSetDescriptor2 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor
        Dim GridColumnSetDescriptor3 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor
        Dim GridColumnSetDescriptor4 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor
        Dim GridColumnSetDescriptor5 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor
        Dim GridColumnSetDescriptor6 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor
        Dim GridColumnSetDescriptor7 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dataSet11 = New EmployeeView.DataSet1
        Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
        Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataSet11
        '
        Me.dataSet11.DataSetName = "DataSet1"
        Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gridGroupingControl1
        '
        Me.gridGroupingControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridGroupingControl1.Appearance.AlternateRecordFieldCell.BaseStyle = ""
        Me.gridGroupingControl1.Appearance.AlternateRecordFieldCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(219, Byte), Integer)))
        Me.gridGroupingControl1.Appearance.RecordPreviewCell.BaseStyle = ""
        Me.gridGroupingControl1.Appearance.RecordPreviewCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(246, Byte), Integer)))
        Me.gridGroupingControl1.Appearance.RecordPreviewRowHeaderCell.BaseStyle = ""
        Me.gridGroupingControl1.Appearance.RecordPreviewRowHeaderCell.CellType = "Static"
        Me.gridGroupingControl1.Appearance.RecordPreviewRowHeaderCell.Enabled = False
        Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
        Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordAfterDetails = True
        Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.gridGroupingControl1.DataSource = Me.dataSet11.Employees
        Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridGroupingControl1.Location = New System.Drawing.Point(13, 15)
        Me.gridGroupingControl1.Name = "gridGroupingControl1"
        Me.gridGroupingControl1.Size = New System.Drawing.Size(578, 359)
        Me.gridGroupingControl1.TabIndex = 0
        Me.gridGroupingControl1.TableDescriptor.AllowNew = False
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)))
        Me.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
        Me.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
        GridColumnDescriptor1.HeaderText = "ID"
        GridColumnDescriptor1.MappingName = "EmployeeID"
        GridColumnDescriptor1.Width = 60
        GridColumnDescriptor2.MappingName = "FirstName"
        GridColumnDescriptor2.Width = 115
        GridColumnDescriptor3.MappingName = "Address"
        GridColumnDescriptor3.Width = 118
        GridColumnDescriptor4.MappingName = "City"
        GridColumnDescriptor4.Width = 83
        GridColumnDescriptor5.MappingName = "Region"
        GridColumnDescriptor5.Width = 80
        GridColumnDescriptor6.MappingName = "Country"
        GridColumnDescriptor6.Width = 80
        GridColumnDescriptor7.MappingName = "Title"
        GridColumnDescriptor7.Width = 144
        GridColumnDescriptor8.MappingName = "TitleOfCourtesy"
        GridColumnDescriptor8.Width = 133
        Me.gridGroupingControl1.TableDescriptor.Columns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor() {GridColumnDescriptor1, GridColumnDescriptor2, New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("LastName"), GridColumnDescriptor3, GridColumnDescriptor4, New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("PostalCode"), GridColumnDescriptor5, GridColumnDescriptor6, New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("BirthDate"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("Photo"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ReportsTo"), GridColumnDescriptor7, GridColumnDescriptor8})
        GridColumnSetDescriptor1.ColumnSpans.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("EmployeeID", "R0C0:R1C0")})
        GridColumnSetDescriptor1.Name = "ColumnSetId"
        GridColumnSetDescriptor2.ColumnSpans.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Photo", "R0C0:R1C0")})
        GridColumnSetDescriptor2.Name = "ColumnSetPhoto"
        GridColumnSetDescriptor3.ColumnSpans.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("FirstName", "R0C0"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("LastName", "R1C0")})
        GridColumnSetDescriptor3.Name = "ColumnSetName"
        GridColumnSetDescriptor4.ColumnSpans.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Address", "R0C0:R0C1"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("City", "R1C0"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("PostalCode", "R1C1")})
        GridColumnSetDescriptor4.Name = "ColumnSetAddress"
        GridColumnSetDescriptor5.ColumnSpans.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Region", "R0C0"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Country", "R1C0")})
        GridColumnSetDescriptor5.Name = "ColumnSetRegionCountry"
        GridColumnSetDescriptor6.ColumnSpans.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Title", "R0C0"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("TitleOfCourtesy", "R1C0")})
        GridColumnSetDescriptor6.Name = "ColumnSetTitle"
        GridColumnSetDescriptor7.ColumnSpans.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("BirthDate", "R0C0"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("ReportsTo", "R1C0")})
        GridColumnSetDescriptor7.Name = "ColumnSetBirth"
        Me.gridGroupingControl1.TableDescriptor.ColumnSets.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor() {GridColumnSetDescriptor1, GridColumnSetDescriptor2, GridColumnSetDescriptor3, GridColumnSetDescriptor4, GridColumnSetDescriptor5, GridColumnSetDescriptor6, GridColumnSetDescriptor7})
        Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
        Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
        Me.gridGroupingControl1.TableOptions.RecordPreviewRowHeight = 60
        Me.gridGroupingControl1.TableOptions.RecordRowHeight = 30
        Me.gridGroupingControl1.TableOptions.ShowRecordPreviewRow = True
        Me.gridGroupingControl1.Text = "gridGroupingControl1"
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = False
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = True
        '
        'propertyGrid1
        '
        Me.propertyGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid1.BackColor = System.Drawing.Color.White
        Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.White
        Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
        Me.propertyGrid1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
        Me.propertyGrid1.LineColor = System.Drawing.Color.White
        Me.propertyGrid1.Location = New System.Drawing.Point(617, 15)
        Me.propertyGrid1.Name = "propertyGrid1"
        Me.propertyGrid1.Size = New System.Drawing.Size(272, 359)
        Me.propertyGrid1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BorderThickness = 2
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(905, 395)
        Me.Controls.Add(Me.propertyGrid1)
        Me.Controls.Add(Me.gridGroupingControl1)
        Me.DropShadow = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Record Customization Demo"
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private Shared Sub ShowErrorMessage(ByVal ex As SqlException)
        If ex.Number = 11001 Then
            MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If ex.Number = 208 Then
            MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If ex.Number = 156 OrElse ex.Number = 102 Then
            MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
#End Region

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub

    Private Sub gridGroupingControl1_QueryCellStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventArgs) Handles gridGroupingControl1.QueryCellStyleInfo
        Select Case e.TableCellIdentity.TableCellType
            Case GridTableCellType.RecordPreviewCell
                Dim groupingControl As GridGroupingControl = CType(sender, GridGroupingControl)
                Dim table As GridTable = groupingControl.Table
                Dim record As GridRecord = TryCast(e.TableCellIdentity.DisplayElement.ParentRecord, GridRecord)
                If record IsNot Nothing Then
                    e.Style.CellValue = record.GetValue("Notes").ToString()
                Else
                    e.Style.CellValue = "No Notes."
                End If
                Exit Select
        End Select

        Dim sb As New StringBuilder()

        sb.Append(e.TableCellIdentity.Info)

        If e.Style IsNot Nothing Then
            sb.AppendFormat(Constants.vbCrLf & "CellType = {0}", e.Style.CellType)
            sb.AppendFormat(", CellValueType = {0}", e.Style.CellValueType)
            sb.AppendFormat(", nFormat = ""{0}""", e.Style.Format)
            sb.AppendFormat(", CellValue = ""{0}""", e.Style.CellValue)
            sb.AppendFormat(", ImageSizeMode = ""{0}""", e.Style.ImageSizeMode)

        End If

        e.Style.CellTipText = sb.ToString()
    End Sub

    Private Sub TableControl_ResizingRows(ByVal sender As Object, ByVal e As GridResizingRowsEventArgs)
        e.Cancel = True
    End Sub
End Class

