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
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System.IO
Imports Syncfusion.Windows.Forms

Namespace StylesAtGroupLevel_2003
	Public Class Form1
		Inherits MetroForm
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private dataset11 As StylesAtGroupLevel_2003.Dataset1
		Private components As System.ComponentModel.Container = Nothing
		Public ReadOnly Shared connString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")
		Public Sub New()
			InitializeComponent()
			Dim commandstring1 As String = "select * from Categories"
			Dim commandstring2 As String = "select * from Products"

			Dim da1 As New SqlCeDataAdapter(commandstring1, connString)
			Dim da2 As New SqlCeDataAdapter(commandstring2, connString)
			Try
				da1.Fill(dataset11, "Categories")
				da2.Fill(dataset11, "Products")
			Catch ex As SqlException
				ShowErrorMessage(ex)
			End Try

			Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
			Me.Icon = ico

			AddHandler gridGroupingControl1.GridGroupDropArea.PrepareViewStyleInfo, AddressOf GridGroupDropArea_PrepareViewStyleInfo
			Me.gridGroupingControl1.GroupDropPanel.BackColor = Color.FromArgb(255, 203, 146)
			Me.gridGroupingControl1.Splitter.BackColor = Color.FromArgb(255, 203, 146)
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

		Private Sub GridGroupDropArea_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs)
			e.Style.BackColor = Color.FromArgb(255, 203, 146)
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
            Me.dataset11 = New StylesAtGroupLevel_2003.Dataset1
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataset11, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridGroupingControl1.Appearance.AnyGroupCell.Themed = False
            Me.gridGroupingControl1.Appearance.GroupCaptionCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(200, Byte), Integer)))
            Me.gridGroupingControl1.Appearance.GroupCaptionCell.CellTipText = "GroupCaptionCell"
            Me.gridGroupingControl1.Appearance.GroupCaptionCell.Font.Bold = False
            Me.gridGroupingControl1.Appearance.GroupCaptionCell.Font.Facename = "Verdana"
            Me.gridGroupingControl1.Appearance.GroupCaptionCell.Font.Italic = False
            Me.gridGroupingControl1.Appearance.GroupCaptionCell.Font.Size = 8.25!
            Me.gridGroupingControl1.Appearance.GroupCaptionCell.Font.Strikeout = False
            Me.gridGroupingControl1.Appearance.GroupCaptionCell.Font.Underline = False
            Me.gridGroupingControl1.Appearance.GroupCaptionCell.Font.Unit = System.Drawing.GraphicsUnit.Point
            Me.gridGroupingControl1.Appearance.GroupCaptionCell.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(208, Byte), Integer)), System.Drawing.Color.White)
            Me.gridGroupingControl1.Appearance.GroupCaptionCell.TextColor = System.Drawing.Color.Black
            Me.gridGroupingControl1.Appearance.GroupCaptionCell.Themed = False
            Me.gridGroupingControl1.Appearance.GroupCaptionPlusMinusCell.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.SystemColors.Window, System.Drawing.Color.Pink)
            Me.gridGroupingControl1.Appearance.GroupCaptionPlusMinusCell.Themed = True
            Me.gridGroupingControl1.Appearance.GroupCaptionRowHeaderCell.CellTipText = "GroupCaptionRowHeader"
            Me.gridGroupingControl1.Appearance.GroupCaptionRowHeaderCell.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, System.Drawing.SystemColors.Window, System.Drawing.Color.DarkOrange)
            Me.gridGroupingControl1.Appearance.GroupCaptionRowHeaderCell.Themed = False
            Me.gridGroupingControl1.Appearance.GroupHeaderRowHeaderCell.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Window, System.Drawing.Color.LightPink)
            Me.gridGroupingControl1.Appearance.GroupHeaderRowHeaderCell.Themed = False
            Me.gridGroupingControl1.Appearance.GroupHeaderSectionCell.Enabled = False
            Me.gridGroupingControl1.Appearance.GroupHeaderSectionCell.Font.Bold = True
            Me.gridGroupingControl1.Appearance.GroupHeaderSectionCell.Font.Facename = "Tahoma"
            Me.gridGroupingControl1.Appearance.GroupHeaderSectionCell.Font.Italic = False
            Me.gridGroupingControl1.Appearance.GroupHeaderSectionCell.Font.Size = 8.25!
            Me.gridGroupingControl1.Appearance.GroupHeaderSectionCell.Font.Strikeout = False
            Me.gridGroupingControl1.Appearance.GroupHeaderSectionCell.Font.Underline = False
            Me.gridGroupingControl1.Appearance.GroupHeaderSectionCell.Font.Unit = System.Drawing.GraphicsUnit.Point
            Me.gridGroupingControl1.Appearance.GroupHeaderSectionCell.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(190, Byte), Integer)))
            Me.gridGroupingControl1.Appearance.GroupHeaderSectionCell.MergeCell = Syncfusion.Windows.Forms.Grid.GridMergeCellDirection.None
            Me.gridGroupingControl1.Appearance.GroupHeaderSectionCell.Themed = False
            Me.gridGroupingControl1.Appearance.GroupIndentLCell.AutoSize = True
            Me.gridGroupingControl1.Appearance.GroupIndentLCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Moccasin)
            Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
            Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.gridGroupingControl1.DataMember = "Categories"
            Me.gridGroupingControl1.DataSource = Me.dataset11
            Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridGroupingControl1.Location = New System.Drawing.Point(16, 16)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.gridGroupingControl1.NestedTableGroupOptions.ShowGroupHeader = False
            Me.gridGroupingControl1.ShowGroupDropArea = True
            Me.gridGroupingControl1.Size = New System.Drawing.Size(632, 328)
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
            Me.gridGroupingControl1.TableDescriptor.ChildGroupOptions.ShowCaptionSummaryCells = False
            Me.gridGroupingControl1.TableDescriptor.ChildGroupOptions.ShowColumnHeaders = True
            Me.gridGroupingControl1.TableDescriptor.ChildGroupOptions.ShowGroupFooter = False
            Me.gridGroupingControl1.TableDescriptor.ChildGroupOptions.ShowGroupHeader = True
            Me.gridGroupingControl1.TableDescriptor.ChildGroupOptions.ShowGroupPreview = False
            Me.gridGroupingControl1.TableDescriptor.ChildGroupOptions.ShowGroupSummaryWhenCollapsed = False
            Me.gridGroupingControl1.TableDescriptor.GroupedColumns.AddRange(New Syncfusion.Grouping.SortColumnDescriptor() {New Syncfusion.Grouping.SortColumnDescriptor("CategoryName", System.ComponentModel.ListSortDirection.Ascending), New Syncfusion.Grouping.SortColumnDescriptor("CategoryID", System.ComponentModel.ListSortDirection.Ascending)})
            Me.gridGroupingControl1.TableDescriptor.SortedColumns.AddRange(New Syncfusion.Grouping.SortColumnDescriptor() {New Syncfusion.Grouping.SortColumnDescriptor("CategoryID", System.ComponentModel.ListSortDirection.Ascending)})
            Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
            Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
            Me.gridGroupingControl1.TableDescriptor.TopLevelGroupOptions.ShowCaptionPlusMinus = False
            Me.gridGroupingControl1.TableDescriptor.TopLevelGroupOptions.ShowGroupHeader = False
            Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer)))
            Me.gridGroupingControl1.Text = "gridGroupingControl1"
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = True
            Me.gridGroupingControl1.VersionInfo = "4.301.0.0"
            '
            'dataset11
            '
            Me.dataset11.DataSetName = "Dataset1"
            Me.dataset11.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(664, 358)
            Me.Controls.Add(Me.gridGroupingControl1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Group Style Demo"
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataset11, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub
	End Class
End Namespace
