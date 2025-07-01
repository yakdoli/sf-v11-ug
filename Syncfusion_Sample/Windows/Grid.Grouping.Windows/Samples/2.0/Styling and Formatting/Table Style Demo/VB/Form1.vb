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
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System.IO
Imports Syncfusion.Windows.Forms

Namespace StylesAtTableLevel_2003
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private dataset11 As StylesAtTableLevel_2003.Dataset1
		Private components As System.ComponentModel.Container = Nothing
		Private panel1 As Panel
		Private propertyGrid1 As PropertyGrid
		Public ReadOnly Shared connString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")
        Public Sub New()
            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
            InitializeComponent()
            Dim commandstring1 As String = "select * from Customers"
            Dim commandstring2 As String = "select * from Orders"

            Dim da1 As New SqlCeDataAdapter(commandstring1, connString)
            Dim da2 As New SqlCeDataAdapter(commandstring2, connString)
            Try
                da1.Fill(dataset11, "Customers")
                da2.Fill(dataset11, "Orders")
            Catch ex As SqlException
                ShowErrorMessage(ex)
            End Try
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
            Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            Me.dataset11 = New StylesAtTableLevel_2003.Dataset1
            Me.panel1 = New System.Windows.Forms.Panel
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataset11, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.gridGroupingControl1.Appearance.ColumnHeaderCell.CellTipText = "ColumnHeader"
            Me.gridGroupingControl1.Appearance.ColumnHeaderCell.Font.Bold = False
            Me.gridGroupingControl1.Appearance.ColumnHeaderCell.Font.Facename = "Tahoma"
            Me.gridGroupingControl1.Appearance.ColumnHeaderCell.Font.Italic = False
            Me.gridGroupingControl1.Appearance.ColumnHeaderCell.Font.Size = 8.25!
            Me.gridGroupingControl1.Appearance.ColumnHeaderCell.Font.Strikeout = False
            Me.gridGroupingControl1.Appearance.ColumnHeaderCell.Font.Underline = False
            Me.gridGroupingControl1.Appearance.ColumnHeaderCell.Font.Unit = System.Drawing.GraphicsUnit.Point
            Me.gridGroupingControl1.Appearance.ColumnHeaderCell.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(232, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(151, Byte), Integer)))
            Me.gridGroupingControl1.Appearance.ColumnHeaderCell.TextColor = System.Drawing.Color.White
            Me.gridGroupingControl1.Appearance.ColumnHeaderCell.Themed = False
            Me.gridGroupingControl1.Appearance.GroupCaptionCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(153, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.Medium)
            Me.gridGroupingControl1.Appearance.GroupCaptionCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(224, Byte), Integer)))
            Me.gridGroupingControl1.Appearance.GroupCaptionCell.Themed = False
            Me.gridGroupingControl1.Appearance.NestedTableCell.CellAppearance = Syncfusion.Windows.Forms.Grid.GridCellAppearance.Raised
            Me.gridGroupingControl1.Appearance.NestedTableCell.CellTipText = "OrderDetails"
            Me.gridGroupingControl1.Appearance.NestedTableCell.Font.Bold = True
            Me.gridGroupingControl1.Appearance.NestedTableCell.Font.Facename = "Arial"
            Me.gridGroupingControl1.Appearance.NestedTableCell.Font.Italic = False
            Me.gridGroupingControl1.Appearance.NestedTableCell.Font.Size = 8.25!
            Me.gridGroupingControl1.Appearance.NestedTableCell.Font.Strikeout = False
            Me.gridGroupingControl1.Appearance.NestedTableCell.Font.Underline = False
            Me.gridGroupingControl1.Appearance.NestedTableCell.Font.Unit = System.Drawing.GraphicsUnit.Point
            Me.gridGroupingControl1.Appearance.NestedTableCell.Format = ""
            Me.gridGroupingControl1.Appearance.NestedTableCell.ImageFromByteArray = True
            Me.gridGroupingControl1.Appearance.NestedTableCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(231, Byte), Integer)))
            Me.gridGroupingControl1.Appearance.NestedTableCell.TextColor = System.Drawing.Color.Brown
            Me.gridGroupingControl1.Appearance.NestedTableCell.Themed = True
            Me.gridGroupingControl1.Appearance.NestedTableRowHeaderCell.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(231, Byte), Integer)))
            Me.gridGroupingControl1.Appearance.NestedTableRowHeaderCell.Themed = False
            Me.gridGroupingControl1.Appearance.RecordFieldCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Lavender)
            Me.gridGroupingControl1.Appearance.RecordPlusMinusCell.Font.Bold = True
            Me.gridGroupingControl1.Appearance.RecordPlusMinusCell.Font.Facename = "Tahoma"
            Me.gridGroupingControl1.Appearance.RecordPlusMinusCell.Font.Italic = False
            Me.gridGroupingControl1.Appearance.RecordPlusMinusCell.Font.Size = 8.25!
            Me.gridGroupingControl1.Appearance.RecordPlusMinusCell.Font.Strikeout = False
            Me.gridGroupingControl1.Appearance.RecordPlusMinusCell.Font.Underline = False
            Me.gridGroupingControl1.Appearance.RecordPlusMinusCell.Font.Unit = System.Drawing.GraphicsUnit.Point
            Me.gridGroupingControl1.Appearance.RecordPlusMinusCell.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.Window, System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(222, Byte), Integer)))
            Me.gridGroupingControl1.Appearance.RecordPlusMinusCell.Themed = True
            Me.gridGroupingControl1.Appearance.RowHeaderCell.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.SystemColors.Window, System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(231, Byte), Integer)))
            Me.gridGroupingControl1.Appearance.RowHeaderCell.Themed = False
            Me.gridGroupingControl1.Appearance.TopLeftHeaderCell.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.Window, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(221, Byte), Integer)))
            Me.gridGroupingControl1.Appearance.TopLeftHeaderCell.Themed = False
            Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
            Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.gridGroupingControl1.DataMember = "Customers"
            Me.gridGroupingControl1.DataSource = Me.dataset11
            Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridGroupingControl1.Location = New System.Drawing.Point(12, 12)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.gridGroupingControl1.Size = New System.Drawing.Size(532, 345)
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
            Me.gridGroupingControl1.TableDescriptor.SortedColumns.AddRange(New Syncfusion.Grouping.SortColumnDescriptor() {New Syncfusion.Grouping.SortColumnDescriptor("CompanyName", System.ComponentModel.ListSortDirection.Descending)})
            Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
            Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
            Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(220, Byte), Integer)))
            Me.gridGroupingControl1.Text = "gridGroupingControl1"
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.gridGroupingControl1.VersionInfo = "4.301.0.0"
            '
            'dataset11
            '
            Me.dataset11.DataSetName = "Dataset1"
            Me.dataset11.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.DimGray
            Me.panel1.ForeColor = System.Drawing.Color.DimGray
            Me.panel1.Location = New System.Drawing.Point(548, 22)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1, 324)
            Me.panel1.TabIndex = 22
            '
            'propertyGrid1
            '
            Me.propertyGrid1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.propertyGrid1.BackColor = System.Drawing.Color.White
            Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.White
            Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
            Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
            Me.propertyGrid1.LineColor = System.Drawing.Color.White
            Me.propertyGrid1.Location = New System.Drawing.Point(555, 12)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
            Me.propertyGrid1.Size = New System.Drawing.Size(203, 345)
            Me.propertyGrid1.TabIndex = 21
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(768, 371)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.propertyGrid1)
            Me.Controls.Add(Me.gridGroupingControl1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Table Style Demo"
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataset11, System.ComponentModel.ISupportInitialize).EndInit()
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

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Dim gtd As GridTableDescriptor=Me.gridGroupingControl1.GetTableDescriptor("Orders")
			gtd.Appearance.AnyRecordFieldCell.BackColor=Color.FromArgb(223,247,252)
			gtd.Appearance.AlternateRecordFieldCell.BackColor=Color.FromArgb(255,229,201)
			gtd.Appearance.ColumnHeaderCell.Interior = New BrushInfo(GradientStyle.Vertical, Color.FromArgb(203, 201, 202), Color.FromArgb(253, 247, 215))
			gtd.Appearance.ColumnHeaderCell.TextColor = Color.Black
			gtd.Appearance.GroupCaptionCell.Interior = New BrushInfo(Color.FromArgb(255, 238, 220))
			gtd.Appearance.GroupCaptionCell.Borders.Bottom = New GridBorder(GridBorderStyle.Solid, Color.FromArgb(242, 158, 32), GridBorderWeight.Medium)
		End Sub

	End Class
End Namespace
