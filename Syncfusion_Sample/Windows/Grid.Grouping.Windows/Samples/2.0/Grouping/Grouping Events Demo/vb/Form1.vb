#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Text
Imports System.Drawing
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System.IO
Imports Syncfusion.Windows.Forms
Imports Syncfusion.GridHelperClasses

Namespace GroupingEvents
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
        Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
        Private components As System.ComponentModel.IContainer
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private panel1 As System.Windows.Forms.Panel
        Private label1 As System.Windows.Forms.Label
        Private contextMenu1 As System.Windows.Forms.ContextMenu
        Private WithEvents menuItem1 As System.Windows.Forms.MenuItem
        Private WithEvents dataset11 As GroupingEvents.Dataset1
        Private label2 As System.Windows.Forms.Label
		Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
		Private listView1 As System.Windows.Forms.ListView
		Private columnHeader1 As System.Windows.Forms.ColumnHeader
		Private columnHeader2 As System.Windows.Forms.ColumnHeader
		Private eventTracer As EngineEventTracer
		Public ReadOnly Shared connString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
            Me.dataset11 = New GroupingEvents.Dataset1()
			Dim commandstring1 As String = "select * from Employees"
			Dim commandstring2 As String = "select * from Orders"

			Dim da1 As New SqlCeDataAdapter(commandstring1, connString)
			Dim da2 As New SqlCeDataAdapter(commandstring2, connString)
			Try
				da1.Fill(dataset11, "Employees")
				da2.Fill(dataset11, "Orders")
			Catch ex As SqlException
				ShowErrorMessage(ex)
			End Try
            Me.dataset11.DataSetName = "Dataset1"
            Me.dataset11.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			Dim eng As GridEngine=Me.gridGroupingControl1.Engine
			eventTracer = New EngineEventTracer(eng,Me.listView1)
			Me.gridGroupingControl1.GroupDropPanel.Height+=10
			AddHandler listView1.MouseDown, AddressOf listView1_MouseDown
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
            End Try
            Me.gridGroupingControl1.DataSource = Me.dataset11
			Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana"
			Me.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue
			Me.gridGroupingControl1.TableOptions.GridLineBorder = New GridBorder(GridBorderStyle.Solid, System.Drawing.Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
			Me.BackColor = Color.White
			Me.DropShadow = True
            Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
            Dim fc As New FieldChooser(Me.gridGroupingControl1)
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
            Dim gridRelationDescriptor1 As New Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor()
            Dim gridStackedHeaderRowDescriptor1 As New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderRowDescriptor()
            Dim gridStackedHeaderDescriptor1 As New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor()
            Dim gridStackedHeaderDescriptor2 As New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor()
            Dim gridStackedHeaderDescriptor3 As New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor()
            Dim gridStackedHeaderDescriptor4 As New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor()
            Dim gridStackedHeaderDescriptor5 As New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor()
            Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            '  Me.dataset11 = New Dataset1
            Me.contextMenu1 = New System.Windows.Forms.ContextMenu
            Me.menuItem1 = New System.Windows.Forms.MenuItem
            Me.panel1 = New System.Windows.Forms.Panel
            Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.label1 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.listView1 = New System.Windows.Forms.ListView
            Me.columnHeader1 = New System.Windows.Forms.ColumnHeader
            Me.columnHeader2 = New System.Windows.Forms.ColumnHeader
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            'CType(Me.dataset11, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
            Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.gridGroupingControl1.DataMember = "Employees"

            Me.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gridGroupingControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.gridGroupingControl1.ShowGroupDropArea = True
            Me.gridGroupingControl1.Size = New System.Drawing.Size(743, 294)
            Me.gridGroupingControl1.TabIndex = 0
            gridRelationDescriptor1.ChildTableDescriptor.StackedHeaderRows.Add(New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderRowDescriptor("Row 1", New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor("Header 1", New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("CustomerID"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("OrderDate"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("OrderID"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipAddress"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipName"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShippedDate")})}))
            gridRelationDescriptor1.MappingName = "EmployeesOrders"
            Me.gridGroupingControl1.TableDescriptor.Relations.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor() {gridRelationDescriptor1})
            gridStackedHeaderRowDescriptor1.Appearance.StackedHeaderCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            gridStackedHeaderDescriptor1.Appearance.StackedHeaderCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(0)))))))
            gridStackedHeaderDescriptor1.Name = "Header 1"
            gridStackedHeaderDescriptor1.VisibleColumns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("EmployeeID"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("FirstName"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("LastName")})
            gridStackedHeaderDescriptor2.Appearance.StackedHeaderCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(192))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192)))))))
            gridStackedHeaderDescriptor2.Name = "Header 2"
            gridStackedHeaderDescriptor2.VisibleColumns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("Title"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("Address")})
            gridStackedHeaderDescriptor3.Appearance.StackedHeaderCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Blue)
            gridStackedHeaderDescriptor3.Name = "Header 3"
            gridStackedHeaderDescriptor3.VisibleColumns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("City"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("Country"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("TitleOfCourtesy"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("BirthDate"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("HireDate")})
            gridStackedHeaderDescriptor4.Appearance.StackedHeaderCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128)))))))
            gridStackedHeaderDescriptor4.Name = "Header 4"
            gridStackedHeaderDescriptor4.VisibleColumns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("Region"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("PostalCode"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("HomePhone")})
            gridStackedHeaderDescriptor5.Appearance.StackedHeaderCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(255)))))))
            gridStackedHeaderDescriptor5.Name = "Header 5"
            gridStackedHeaderDescriptor5.VisibleColumns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("Extension"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("Photo"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("SmallPhoto"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("Notes"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ReportsTo")})
            gridStackedHeaderRowDescriptor1.Headers.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor() {gridStackedHeaderDescriptor1, gridStackedHeaderDescriptor2, gridStackedHeaderDescriptor3, gridStackedHeaderDescriptor4, gridStackedHeaderDescriptor5})
            gridStackedHeaderRowDescriptor1.Name = "Row 1"
            Me.gridGroupingControl1.TableDescriptor.StackedHeaderRows.Add(gridStackedHeaderRowDescriptor1)
            Me.gridGroupingControl1.TableDescriptor.VisibleColumns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("EmployeeID"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("FirstName"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("LastName"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Title"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Address"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("City"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Country"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("TitleOfCourtesy"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("BirthDate"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("HireDate"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Region"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("PostalCode"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("HomePhone"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Extension"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Photo"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("SmallPhoto"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Notes"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ReportsTo")})
            Me.gridGroupingControl1.Text = "gridGroupingControl1"
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.gridGroupingControl1.VersionInfo = "4.301.0.0"
            '
            'dataset11
            '
            
            '
            'contextMenu1
            '
            Me.contextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1})
            '
            'menuItem1
            '
            Me.menuItem1.Enabled = False
            Me.menuItem1.Index = 0
            Me.menuItem1.Text = "Clear Window"
            '
            'panel1
            '
            Me.panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel1.Controls.Add(Me.gridGroupingControl1)
            Me.panel1.Location = New System.Drawing.Point(28, 23)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(743, 294)
            Me.panel1.TabIndex = 6
            '
            'button1
            '
            Me.button1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.ForeColor = System.Drawing.Color.White
            Me.button1.Location = New System.Drawing.Point(641, 330)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(128, 24)
            Me.button1.TabIndex = 10
            Me.button1.Text = "Trace Events"
            Me.button1.UseVisualStyle = True
            Me.button1.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.DimGray
            Me.label1.Location = New System.Drawing.Point(25, 341)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(43, 16)
            Me.label1.TabIndex = 7
            Me.label1.Text = "Event Tracer"
            '
            'label2
            '
            Me.label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.DimGray
            Me.label2.Location = New System.Drawing.Point(111, 341)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(225, 16)
            Me.label2.TabIndex = 8
            Me.label2.Text = "(Right click to clear the output window)"
            '
            'listView1
            '
            Me.listView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2})
            Me.listView1.ContextMenu = Me.contextMenu1
            Me.listView1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.listView1.ForeColor = System.Drawing.Color.DimGray
            Me.listView1.Location = New System.Drawing.Point(25, 364)
            Me.listView1.Name = "listView1"
            Me.listView1.Size = New System.Drawing.Size(744, 201)
            Me.listView1.TabIndex = 9
            Me.listView1.UseCompatibleStateImageBehavior = False
            Me.listView1.View = System.Windows.Forms.View.Details
            '
            'columnHeader1
            '
            Me.columnHeader1.Text = "Event"
            Me.columnHeader1.Width = 186
            '
            'columnHeader2
            '
            Me.columnHeader2.Text = "Details"
            Me.columnHeader2.Width = 759
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(795, 595)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.listView1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.panel1)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Grouping Events Demo"
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
            'CType(Me.dataset11, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
		#End Region

		
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub menuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem1.Click
			Me.listView1.Items.Clear()
		End Sub

		Private Sub button1_Click_1(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			If Me.button1.Text="Trace Events" Then
				Me.eventTracer.HookEvents()
				Me.button1.Text="Disable Tracing"
			Else
				Me.eventTracer.UnhookEvents()
				Me.button1.Text="Trace Events"
			End If
		End Sub

		Private Sub listView1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			If e.Button=MouseButtons.Right Then
				If Me.listView1.Items.Count=0 Then
					Me.menuItem1.Enabled=False
				Else
					Me.menuItem1.Enabled=True
				End If
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub
	End Class
End Namespace
