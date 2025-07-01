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
Imports System.Xml.Serialization
Imports System.Runtime.Serialization

Imports Syncfusion.Drawing
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports System.Data.SqlClient

Imports System.Data.SqlServerCe
Imports System.IO

Namespace EmployeeView
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Syncfusion.Windows.Forms.MetroForm
		Private dataSet11 As EmployeeView.DataSet1
		Private currentDataSet As DataSet = Nothing
		Private components As IContainer

'INSTANT VB NOTE: The variable tableRecordFieldStyles was renamed since Visual Basic does not allow class members with the same name:
		Private tableRecordFieldStyles_Renamed As New TableRecordFieldStylesCollection()

		<DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)> _
		Public Property TableRecordFieldStyles() As TableRecordFieldStylesCollection
			Get
				Return tableRecordFieldStyles_Renamed
			End Get
			Set(ByVal value As TableRecordFieldStylesCollection)
				tableRecordFieldStyles_Renamed = value
			End Set
		End Property


'INSTANT VB NOTE: The variable tableRecordFieldStylesSerializer was renamed since Visual Basic does not allow class members with the same name:
		Private Shared tableRecordFieldStylesSerializer_Renamed As XmlSerializer
		Private gridGroupingControl1 As GridGroupingControl
		Private panel1 As Panel
		Private WithEvents buttonAdv5 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonAdv4 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonAdv3 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv

		Private Shared ReadOnly Property TableRecordFieldStylesSerializer() As XmlSerializer
			Get
				If tableRecordFieldStylesSerializer_Renamed Is Nothing Then
					tableRecordFieldStylesSerializer_Renamed = New XmlSerializer(GetType(TableRecordFieldStylesCollection))
				End If
				Return tableRecordFieldStylesSerializer_Renamed
			End Get
		End Property

		Public ReadOnly Shared connString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
			Me.Icon = ico




			' look for 
			currentDataSet = Me.dataSet11.Clone()
			Dim commandstring As String = "select * from Employees"

			Dim da As New SqlCeDataAdapter(commandstring, connString)
			Try
				da.Fill(currentDataSet, "Employees")
			Catch ex As SqlException
				ShowErrorMessage(ex)
			End Try

			Me.gridGroupingControl1.DataSource = currentDataSet.Tables(0)
			Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
			Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Segoe UI"
			Me.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue
			Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
		End Sub
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

		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function


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
            Me.panel1 = New System.Windows.Forms.Panel
            Me.buttonAdv5 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv4 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv3 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
            CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
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
            Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridGroupingControl1.Location = New System.Drawing.Point(21, 8)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.Size = New System.Drawing.Size(528, 381)
            Me.gridGroupingControl1.TabIndex = 1
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
            'panel1
            '
            Me.panel1.Controls.Add(Me.buttonAdv5)
            Me.panel1.Controls.Add(Me.buttonAdv4)
            Me.panel1.Controls.Add(Me.buttonAdv3)
            Me.panel1.Controls.Add(Me.buttonAdv2)
            Me.panel1.Controls.Add(Me.buttonAdv1)
            Me.panel1.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panel1.Location = New System.Drawing.Point(550, 5)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(187, 382)
            Me.panel1.TabIndex = 2
            '
            'buttonAdv5
            '
            Me.buttonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.buttonAdv5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.buttonAdv5.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.buttonAdv5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonAdv5.ForeColor = System.Drawing.Color.White
            Me.buttonAdv5.Location = New System.Drawing.Point(26, 260)
            Me.buttonAdv5.Name = "buttonAdv5"
            Me.buttonAdv5.Size = New System.Drawing.Size(151, 40)
            Me.buttonAdv5.TabIndex = 4
            Me.buttonAdv5.Text = "Edit custom styles"
            Me.buttonAdv5.UseVisualStyle = True
            Me.buttonAdv5.UseVisualStyleBackColor = True
            '
            'buttonAdv4
            '
            Me.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.buttonAdv4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.buttonAdv4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.buttonAdv4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonAdv4.ForeColor = System.Drawing.Color.White
            Me.buttonAdv4.Location = New System.Drawing.Point(26, 210)
            Me.buttonAdv4.Name = "buttonAdv4"
            Me.buttonAdv4.Size = New System.Drawing.Size(151, 40)
            Me.buttonAdv4.TabIndex = 3
            Me.buttonAdv4.Text = "Restore all from xml"
            Me.buttonAdv4.UseVisualStyle = True
            Me.buttonAdv4.UseVisualStyleBackColor = True
            '
            'buttonAdv3
            '
            Me.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.buttonAdv3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.buttonAdv3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.buttonAdv3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonAdv3.ForeColor = System.Drawing.Color.White
            Me.buttonAdv3.Location = New System.Drawing.Point(26, 160)
            Me.buttonAdv3.Name = "buttonAdv3"
            Me.buttonAdv3.Size = New System.Drawing.Size(151, 40)
            Me.buttonAdv3.TabIndex = 2
            Me.buttonAdv3.Text = "Clear all"
            Me.buttonAdv3.UseVisualStyle = True
            Me.buttonAdv3.UseVisualStyleBackColor = True
            '
            'buttonAdv2
            '
            Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.buttonAdv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.buttonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.buttonAdv2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonAdv2.ForeColor = System.Drawing.Color.White
            Me.buttonAdv2.Location = New System.Drawing.Point(26, 110)
            Me.buttonAdv2.Name = "buttonAdv2"
            Me.buttonAdv2.Size = New System.Drawing.Size(151, 40)
            Me.buttonAdv2.TabIndex = 1
            Me.buttonAdv2.Text = "Save all to xml"
            Me.buttonAdv2.UseVisualStyle = True
            Me.buttonAdv2.UseVisualStyleBackColor = True
            '
            'buttonAdv1
            '
            Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.buttonAdv1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonAdv1.ForeColor = System.Drawing.Color.White
            Me.buttonAdv1.Location = New System.Drawing.Point(26, 60)
            Me.buttonAdv1.Name = "buttonAdv1"
            Me.buttonAdv1.Size = New System.Drawing.Size(151, 40)
            Me.buttonAdv1.TabIndex = 0
            Me.buttonAdv1.Text = "Initialize with custom styles"
            Me.buttonAdv1.UseVisualStyle = True
            Me.buttonAdv1.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(738, 400)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.gridGroupingControl1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(800, 500)
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Employee View Demo"
            CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
			Application.EnableVisualStyles()
#End If
			Application.Run(New Form1())
		End Sub

		Private Sub gridGroupingControl1_QueryCellStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventArgs)
			Select Case e.TableCellIdentity.TableCellType
				Case GridTableCellType.RecordPreviewCell
					Dim groupingControl As GridGroupingControl = CType(sender, GridGroupingControl)
					Dim table As GridTable = groupingControl.Table
					Dim record As GridRecord = CType(e.TableCellIdentity.DisplayElement.ParentRecord, GridRecord)
					e.Style.CellValue = record.GetValue("Notes").ToString()
					Exit Select

				Case GridTableCellType.AlternateRecordFieldCell, GridTableCellType.AddNewRecordFieldCell, GridTableCellType.RecordFieldCell
					Dim table As GridTable = e.TableCellIdentity.Table
					Dim tableName As String = table.TableDescriptor.Name
					Dim record As GridRecord = CType(e.TableCellIdentity.DisplayElement.ParentRecord, GridRecord)
					Dim recordkey As Object = record.PrimaryKeys(0)
					Dim fieldName As String = e.TableCellIdentity.Column.MappingName

					Dim style As GridStyleInfo = GetCellStyle(tableName, recordkey, fieldName)
					If style IsNot Nothing Then
						e.Style.ModifyStyle(style, Syncfusion.Styles.StyleModifyType.Override)
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

		Public Function GetCellStyle(ByVal tableName As String, ByVal primaryKey As Object, ByVal fieldName As String) As GridStyleInfo
			Dim recordFieldStyles As RecordFieldStylesCollection = TableRecordFieldStyles.GetRecordFieldStylesByTableName(tableName)
			If recordFieldStyles IsNot Nothing Then
				Dim fieldStyles As FieldStyleCollection = recordFieldStyles.GetFieldStylesByRecordKey(primaryKey)
				If fieldStyles IsNot Nothing Then
					Return fieldStyles.GetStyleByFieldName(fieldName)
				End If
			End If
			Return Nothing
		End Function

		Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Dim abtForm As New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
			abtForm.ShowDialog()
		End Sub

		Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv1.Click
			Me.gridGroupingControl1.Appearance.AnyCell.ImageSizeMode = GridImageSizeMode.CenterImage
			Me.gridGroupingControl1.IntelliMousePanning = True

			Dim employeeTable As GridTable = Me.gridGroupingControl1.Table
			Dim employeeTableDescriptor As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor

			Dim employee As RecordFieldStylesCollection = TableRecordFieldStyles.GetObject(Me.gridGroupingControl1.TableDescriptor.Name)

			employee.GetObject(2).GetObject("LastName").BackColor = ColorConvert.ColorFromString("#84A1C3")
			employee.GetObject(2).GetObject("LastName").Font.Bold = True
			employee.GetObject(1).GetObject("City").BackColor = ColorConvert.ColorFromString("#FF9933")

			employee.GetObject(1).GetObject("City").Font.Italic = True
			employee.GetObject(1).GetObject("Address").Interior = New BrushInfo(PatternStyle.OutlinedDiamond, ColorConvert.ColorFromString("#84A1C3"), ColorConvert.ColorFromString("#2a437e"))
			employee.GetObject(1).GetObject("Address").TextColor = Color.White
			employee.GetObject(1).GetObject("Address").Font.Bold = True
			employee.GetObject(1).GetObject("Address").Font.Size += 2

			' see also gridGroupingControl1_QueryCellStyleInfo handler, 
			'	case GridTableCellType.AlternateRecordFieldCell:
			'	case GridTableCellType.AddNewRecordFieldCell:
			'	case GridTableCellType.RecordFieldCell:
		End Sub

		Private Sub buttonAdv2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv2.Click
			Try
				Dim xw As New XmlTextWriter("TableRecordFieldStylesCollection.xml", System.Text.Encoding.UTF8)
				xw.Formatting = Formatting.Indented
				TableRecordFieldStylesSerializer.Serialize(xw, TableRecordFieldStyles)
				xw.Close()
			Catch ex As Exception
				MessageBox.Show(ex.Message)
			End Try


			Try
				Dim xw As New XmlTextWriter("DataSet.xml", System.Text.Encoding.UTF8)
				xw.Formatting = Formatting.Indented
				Dim dt As DataTable = TryCast(Me.gridGroupingControl1.DataSource, DataTable)
				dt.DataSet.WriteXml(xw, XmlWriteMode.WriteSchema)
				xw.Close()
			Catch ex As Exception
				MessageBox.Show(ex.Message)
			End Try

			Try
				Dim xw As New XmlTextWriter("LookAndFeel.xml", System.Text.Encoding.UTF8)
				xw.Formatting = Formatting.Indented
				Me.gridGroupingControl1.WriteXmlLookAndFeel(xw)
				xw.Close()
			Catch ex As Exception
				MessageBox.Show(ex.Message)
			End Try

			Try
				Dim xw As New XmlTextWriter("EngineSchema.xml", System.Text.Encoding.UTF8)
				xw.Formatting = Formatting.Indented
				Me.gridGroupingControl1.WriteXmlSchema(xw)
				xw.Close()
			Catch ex As Exception
				MessageBox.Show(ex.Message)
			End Try

			MessageBox.Show("Saved to " & System.IO.Directory.GetCurrentDirectory())
		End Sub

		Private Sub buttonAdv3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv3.Click
			TableRecordFieldStyles.Clear()
			Me.currentDataSet.Clear()
			Me.gridGroupingControl1.Refresh()
		End Sub

		Private Sub buttonAdv4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv4.Click
			If Not System.IO.File.Exists("TableRecordFieldStylesCollection.xml") Then
				MessageBox.Show("Xml file does not exist. Please save to xml before trying to restore.")
				Return
			End If

			Try
				Dim xr As New XmlTextReader("TableRecordFieldStylesCollection.xml")
				TableRecordFieldStyles = CType(TableRecordFieldStylesSerializer.Deserialize(xr), TableRecordFieldStylesCollection)
				xr.Close()
			Catch ex As Exception
				MessageBox.Show(ex.Message)
				Return
			End Try


			Try
				Dim xr As New XmlTextReader("DataSet.xml")
				currentDataSet = New DataSet()
				currentDataSet.ReadXml(xr, XmlReadMode.ReadSchema)
				Me.gridGroupingControl1.DataSource = currentDataSet.Tables(0)
				xr.Close()
			Catch ex As Exception
				MessageBox.Show(ex.Message)
				Return
			End Try

			Try
				Dim xr As New XmlTextReader("EngineSchema.xml")
				Me.gridGroupingControl1.ApplyXmlSchema(xr)
				xr.Close()
			Catch ex As Exception
				MessageBox.Show(ex.Message)
				Return
			End Try

			Try
				Dim xr As New XmlTextReader("LookAndFeel.xml")
				Me.gridGroupingControl1.ApplyXmlLookAndFeel(xr)
				xr.Close()
			Catch ex As Exception
				MessageBox.Show(ex.Message)
				Return
			End Try

			Me.gridGroupingControl1.Refresh()

			MessageBox.Show("Loaded from " & System.IO.Directory.GetCurrentDirectory())
		End Sub

		Private Sub buttonAdv5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv5.Click
			Dim ce As New System.ComponentModel.Design.CollectionEditor(Me.tableRecordFieldStyles_Renamed.GetType())
			Dim esc As New Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer(Nothing)
			Dim pd As PropertyDescriptor = TypeDescriptor.GetProperties(Me)("TableRecordFieldStyles")
			Dim tdc As New Syncfusion.ComponentModel.TypeDescriptorContext(Me, pd)
			tdc.ServiceProvider = esc

			ce.EditValue(tdc, esc, tableRecordFieldStyles_Renamed)

			Me.gridGroupingControl1.Refresh()
		End Sub
	End Class
End Namespace
