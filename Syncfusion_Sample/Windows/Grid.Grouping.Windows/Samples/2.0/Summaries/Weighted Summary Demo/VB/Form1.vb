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
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Grouping

'INSTANT VB NOTE: VB does not allow aliasing interfaces:
'using ISummary = Syncfusion.Collections.BinaryTree.ITreeTableSummary
Imports Syncfusion.Windows.Forms

Namespace WeightedSummary
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private propertyGrid1 As PropertyGrid
		Private panel1 As Panel
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

'			#Region "Settings"
			Me.gridGroupingControl1.Engine.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails=False
			Me.gridGroupingControl1.Engine.ChildGroupOptions.ShowAddNewRecordBeforeDetails=False
			Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.Appearance.AnySummaryCell.BackColor = Color.FromArgb(255, 231, 162)
'			#End Region
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
            Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.label2 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
            Me.panel1 = New System.Windows.Forms.Panel
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
            Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridGroupingControl1.Location = New System.Drawing.Point(12, 9)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.Size = New System.Drawing.Size(443, 448)
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
            Me.gridGroupingControl1.VersionInfo = "4.400.0.50"
            '
            'groupBox1
            '
            Me.groupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            Me.groupBox1.ForeColor = System.Drawing.Color.DimGray
            Me.groupBox1.Location = New System.Drawing.Point(12, 472)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(680, 82)
            Me.groupBox1.TabIndex = 2
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Summary Details"
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(48, 56)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(498, 24)
            Me.label2.TabIndex = 1
            Me.label2.Text = "Summary Column 'Col4' :"
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(48, 24)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(498, 23)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Summary Column 'Col2' :"
            '
            'propertyGrid1
            '
            Me.propertyGrid1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.propertyGrid1.BackColor = System.Drawing.Color.White
            Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.White
            Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
            Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
            Me.propertyGrid1.LineColor = System.Drawing.Color.White
            Me.propertyGrid1.Location = New System.Drawing.Point(469, 9)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
            Me.propertyGrid1.Size = New System.Drawing.Size(223, 448)
            Me.propertyGrid1.TabIndex = 15
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.DimGray
            Me.panel1.ForeColor = System.Drawing.Color.DimGray
            Me.panel1.Location = New System.Drawing.Point(461, 20)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1, 425)
            Me.panel1.TabIndex = 16
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(704, 566)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.propertyGrid1)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.gridGroupingControl1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.Text = "Weighted Summary Demo"
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
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
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

			Me.gridGroupingControl1.DataSource = GetTable()

			Me.label1.Text &= "	Weighted sum of Col2 using weights from Col3"
			Me.label2.Text &= "	Weighted sum of Col4 using weights from Col5"

			'needed to setup the CustomSummary type
			AddHandler gridGroupingControl1.TableDescriptor.QueryCustomSummary, AddressOf gridGroupingControl1_QueryCustomSummary

			'use a code naming convention to pass the column holding the weights into the SummaryDescriptor

			'weighted sum of Col2 using weights from Col3
			Dim wgtSumCol2 As GridSummaryColumnDescriptor = GetWeightedSummaryColumnDescriptor("Col2", "Col3")

			'weighted sum of Col4 using weights from Col5
			Dim wgtSumCol4 As GridSummaryColumnDescriptor = GetWeightedSummaryColumnDescriptor("Col4", "Col5")

			'add the summary columns to a summary row
			Me.gridGroupingControl1.TableDescriptor.SummaryRows.Add(New GridSummaryRowDescriptor("Row0", "Weighted Summary", New GridSummaryColumnDescriptor() { wgtSumCol2, wgtSumCol4 }))
			Me.gridGroupingControl1.TableDescriptor.Columns("Col0").Width=150

			'group a column
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("Col1")
			Me.gridGroupingControl1.Table.ExpandAllGroups()
		End Sub

		'custom summary
		Private Sub gridGroupingControl1_QueryCustomSummary(ByVal sender As Object, ByVal e As GridQueryCustomSummaryEventArgs)
			If e.SummaryDescriptor.SummaryType = SummaryType.Custom Then
				e.SummaryDescriptor.CreateSummaryMethod = New CreateSummaryDelegate(AddressOf WeightedSummary.CreateSummaryMethod)
			End If
			e.Handled = True
		End Sub

		Private Function GetWeightedSummaryColumnDescriptor(ByVal sourceCol As String, ByVal weightCol As String) As GridSummaryColumnDescriptor
			Dim wgtSumCol As New GridSummaryColumnDescriptor()
			wgtSumCol.Name = String.Format("{0}_{1}", sourceCol, weightCol) 'special name following the convention above
			wgtSumCol.DataMember = sourceCol 'the column this summary is applied to
			wgtSumCol.DisplayColumn = sourceCol 'where thissummary is displayed
			wgtSumCol.Format = "{WeightedAverage:#.##}" 'what is displayed in the summary
			wgtSumCol.SummaryType = SummaryType.Custom 'marks this as a CustomSummary
			wgtSumCol.Appearance.AnySummaryCell.HorizontalAlignment = GridHorizontalAlignment.Right
			wgtSumCol.MaxLength = 6

			Return wgtSumCol
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

		#Region "DataTable"
		Private Function GetTable() As DataTable
			Dim dt As New DataTable("MyTable")

			Dim nCols As Integer = 6
			Dim nRows As Integer = 50

			For i As Integer = 0 To nCols - 1
				dt.Columns.Add(New DataColumn(String.Format("Col{0}", i), GetType(Integer)))
			Next i

			Dim r As New Random()
			For i As Integer = 0 To nRows - 1
				Dim dr As DataRow = dt.NewRow()
				For j As Integer = 0 To nCols - 1
					dr(j) = r.Next(10)
				Next j
				dt.Rows.Add(dr)
			Next i
			Return dt
		End Function
		#End Region

	End Class
End Namespace
