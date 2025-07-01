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

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System.IO
Imports Syncfusion.Windows.Forms

Namespace PrintGroupingGrid
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		#Region "Private Members"
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private dataSet11 As PrintGroupingGrid.DataSet1
		Private components As IContainer
		Private panel1 As Panel
		Private tipDesc As ToolTip
		Private groupBox1 As GroupBox
		Private groupBox2 As GroupBox
		Private WithEvents buttonAdv3 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonAdv4 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
		Public ReadOnly Shared connString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")
#End Region

		Public Sub New()
'			#Region "Grid Intialization Settings"
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Try
				Dim ico As New Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
			Me.InitializeDataSet()

			' Example: If you want to manually add foreign key columns and don't autopopulate them
			Dim manualForeignKey As Boolean = True
			If manualForeignKey Then
				' The following code shows how to avoid columns being automatically added to the parent table for each
				' column in the foreign table. It does instead manually add those columns
				' from the referenced table by setting ShowRelationFields = ShowRelationFields.Hide
				' and calling Columns.Add("ForeignTable.ColumnName")

				' Reset Relations - so that they get recreated from scratch
				Me.gridGroupingControl1.TableDescriptor.Relations.Reset()

				' NOTE: If you open DataSet1.xsd and right click on the 
				' relation between Products and Suppliers and select "Edit Relation" 
				' you will notice in the dialog that is shown that the 
				' DataSet property "Create foreign key constraint only" has been checked.
				' This setting allows the grouping engine to differentiate between
				' foreign key relations and master details relations when autopopulating
				' relations.
				'

				Me.gridGroupingControl1.ShowRelationFields = ShowRelationFields.Hide

				Dim td As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor.Relations(0).ChildTableDescriptor
				Dim n As Integer = td.Columns.Add("Suppliers.CompanyName") '. will be replaced with '_' in column.Name
				Console.WriteLine(td.Columns(n).Name)
				td.Columns(n).ReadOnly = True
				td.VisibleColumns.Clear()
				td.VisibleColumns.AddRange(New GridVisibleColumnDescriptor() { New GridVisibleColumnDescriptor("ProductID"), New GridVisibleColumnDescriptor("ProductName"), New GridVisibleColumnDescriptor("UnitPrice"), New GridVisibleColumnDescriptor("Suppliers_CompanyName") })
			End If

			' Show group area
			Me.gridGroupingControl1.ShowGroupDropArea = True

			' Additionial table descriptors currently habe to be added manually. We
			' plan to provide a TableDescriptor.ShowInGroupDropArea property later
			' to make this easier.
			AddGroupDropAreas(Me.gridGroupingControl1.Table)

			Me.gridGroupingControl1.Table.Records(0).IsExpanded = True
			Me.gridGroupingControl1.Table.Records(2).IsExpanded = True
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordAfterDetails = False
			Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails=False
			Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordAfterDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Segoe UI"
			gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue
			Me.SetStyle(ControlStyles.UserPaint, True)
'			#End Region
		End Sub

		#Region "Dataset and Icon files"
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
		#End Region

		#Region "Helper Methods"
		Private Sub AddGroupDropAreas(ByVal table As GridTable)
			Dim rd As Syncfusion.Grouping.RelationDescriptor = table.TableDescriptor.ParentRelation
			If rd IsNot Nothing AndAlso rd.RelationKind <> Syncfusion.Grouping.RelationKind.RelatedMasterDetails Then
				Return
			End If

			For Each t As GridTable In table.RelatedTables
				Console.WriteLine("AddGroupDropArea " & t.Info)

				gridGroupingControl1.AddGroupDropArea(t)
				'recurse...
				AddGroupDropAreas(t)
			Next t
		End Sub

		Private Sub InitializeDataSet()
			' Initialize the data set

			Me.dataSet11.BeginInit()

			Dim commandstring1 As String = "select * from Categories"
			Dim commandstring2 As String = "select * from Products"

			Dim da1 As New SqlCeDataAdapter(commandstring1, connString)
			Dim da2 As New SqlCeDataAdapter(commandstring2, connString)
			Try
				da1.Fill(dataSet11, "Categories")
				da2.Fill(dataSet11, "Products")
			Catch ex As SqlException
				ShowErrorMessage(ex)
			End Try

			Me.dataSet11.EndInit()
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

		#Region "Form Handlers"
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
            Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            Me.dataSet11 = New PrintGroupingGrid.DataSet1
            Me.panel1 = New System.Windows.Forms.Panel
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.buttonAdv3 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv4 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.tipDesc = New System.Windows.Forms.ToolTip(Me.components)
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
            Me.gridGroupingControl1.DataSource = Me.dataSet11.Categories
            Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridGroupingControl1.Location = New System.Drawing.Point(18, 15)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.ShowGroupDropArea = True
            Me.gridGroupingControl1.Size = New System.Drawing.Size(623, 387)
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
            Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
            Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
            Me.gridGroupingControl1.Text = "gridGroupingControl1"
            '
            'dataSet11
            '
            Me.dataSet11.DataSetName = "DataSet1"
            Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.groupBox2)
            Me.panel1.Controls.Add(Me.groupBox1)
            Me.panel1.Controls.Add(Me.gridGroupingControl1)
            Me.panel1.ForeColor = System.Drawing.Color.DimGray
            Me.panel1.Location = New System.Drawing.Point(-3, -2)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(876, 413)
            Me.panel1.TabIndex = 1
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.buttonAdv3)
            Me.groupBox2.Controls.Add(Me.buttonAdv4)
            Me.groupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox2.Location = New System.Drawing.Point(665, 187)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(196, 148)
            Me.groupBox2.TabIndex = 4
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Print Options"
            '
            'buttonAdv3
            '
            Me.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.buttonAdv3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.buttonAdv3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonAdv3.ForeColor = System.Drawing.Color.White
            Me.buttonAdv3.Location = New System.Drawing.Point(48, 37)
            Me.buttonAdv3.Name = "buttonAdv3"
            Me.buttonAdv3.Size = New System.Drawing.Size(108, 30)
            Me.buttonAdv3.TabIndex = 2
            Me.buttonAdv3.Text = "Print Preview"
            Me.buttonAdv3.UseVisualStyle = True
            '
            'buttonAdv4
            '
            Me.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.buttonAdv4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.buttonAdv4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonAdv4.ForeColor = System.Drawing.Color.White
            Me.buttonAdv4.Location = New System.Drawing.Point(48, 88)
            Me.buttonAdv4.Name = "buttonAdv4"
            Me.buttonAdv4.Size = New System.Drawing.Size(108, 30)
            Me.buttonAdv4.TabIndex = 3
            Me.buttonAdv4.Text = "Print"
            Me.buttonAdv4.UseVisualStyle = True
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.buttonAdv2)
            Me.groupBox1.Controls.Add(Me.buttonAdv1)
            Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(664, 15)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(196, 148)
            Me.groupBox1.TabIndex = 1
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Expand / Collapse"
            '
            'buttonAdv2
            '
            Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.buttonAdv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.buttonAdv2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonAdv2.ForeColor = System.Drawing.Color.White
            Me.buttonAdv2.Location = New System.Drawing.Point(48, 93)
            Me.buttonAdv2.Name = "buttonAdv2"
            Me.buttonAdv2.Size = New System.Drawing.Size(108, 30)
            Me.buttonAdv2.TabIndex = 1
            Me.buttonAdv2.Text = "Collapse All"
            Me.buttonAdv2.UseVisualStyle = True
            '
            'buttonAdv1
            '
            Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.buttonAdv1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonAdv1.ForeColor = System.Drawing.Color.White
            Me.buttonAdv1.Location = New System.Drawing.Point(48, 46)
            Me.buttonAdv1.Name = "buttonAdv1"
            Me.buttonAdv1.Size = New System.Drawing.Size(108, 30)
            Me.buttonAdv1.TabIndex = 0
            Me.buttonAdv1.Text = "Expand All"
            Me.buttonAdv1.UseVisualStyle = True
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
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(870, 411)
            Me.Controls.Add(Me.panel1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(882, 487)
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Hierarchical Nested Grid Demo"
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox1.ResumeLayout(False)
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
		#End Region

		#Region "Button Handlers"

		Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv1.Click
			Me.gridGroupingControl1.Table.ExpandAllRecords()
		End Sub

		Private Sub buttonAdv2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv2.Click
			Me.gridGroupingControl1.Table.CollapseAllRecords()
			Me.gridGroupingControl1.Table.CollapseAllGroups()
		End Sub

		Private Sub buttonAdv3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv3.Click
			' Print the contents of the grouping grid.
			Dim pd As New GridPrintDocument(Me.gridGroupingControl1.TableControl, True)
			Dim ppv As New PrintPreviewDialog()
			ppv.Document = pd
			pd.DefaultPageSettings.Landscape = True
			Try
				Dim ico As New Icon(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Icon", "sfgrid.ico"))
				ppv.FindForm().Icon = ico
			Catch
			End Try
			ppv.ShowDialog()
			' NOTE: There is a known problem when the width of the nested table is larger
			' than the width of the parent table. Some columns that do not fit on the same
			' page as the last column of the parent table will be omitted. We are working
			' on a solution for this.
		End Sub

		Private Sub buttonAdv4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv4.Click
			Dim pd As New GridPrintDocument(Me.gridGroupingControl1.TableControl)
			Dim printDialog As New PrintDialog()
			printDialog.Document = pd
			pd.DefaultPageSettings.Landscape = True
			If printDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				pd.Print()
			End If
		End Sub

#End Region

	End Class
End Namespace