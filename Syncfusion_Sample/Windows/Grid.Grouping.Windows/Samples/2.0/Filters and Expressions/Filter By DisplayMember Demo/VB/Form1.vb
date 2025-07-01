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
Imports Syncfusion.GridHelperClasses
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms

Namespace ForumFilterBarDisplayMember
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private propertyGrid1 As PropertyGrid
		Private panel1 As Panel
        Dim filter As New GridDynamicFilter()
        Dim filter1 As New GridExcelFilter()
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
            Me.panel1 = New System.Windows.Forms.Panel
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
            Me.gridGroupingControl1.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.gridGroupingControl1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridGroupingControl1.Location = New System.Drawing.Point(12, 14)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.Size = New System.Drawing.Size(432, 362)
            Me.gridGroupingControl1.TabIndex = 1
            Me.gridGroupingControl1.TableDescriptor.AllowNew = False
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)))
            Me.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
            Me.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
            Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
            Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
            Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer)))
            Me.gridGroupingControl1.Text = "gridGroupingControl1"
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.gridGroupingControl1.VersionInfo = "7.103.0.21"
            '
            'propertyGrid1
            '
            Me.propertyGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
            Me.propertyGrid1.CommandsForeColor = System.Drawing.Color.White
            Me.propertyGrid1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
            Me.propertyGrid1.LineColor = System.Drawing.Color.White
            Me.propertyGrid1.Location = New System.Drawing.Point(484, 12)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.Size = New System.Drawing.Size(237, 362)
            Me.propertyGrid1.TabIndex = 2
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.DimGray
            Me.panel1.Location = New System.Drawing.Point(462, 23)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1, 351)
            Me.panel1.TabIndex = 3
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
            Me.ClientSize = New System.Drawing.Size(733, 392)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.propertyGrid1)
            Me.Controls.Add(Me.gridGroupingControl1)
            Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
            Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Filter By DisplayMember Demo"
            '			Me.Load += New System.EventHandler(Me.Form1_Load)
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
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

		Private comboTable As DataTable
		Private gridTable As DataTable
		Private gGCFilter As GroupingGridFilterBarExt

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

            comboTable = Me.GetTheComboTable()
            gridTable = Me.GetTheGridTable()
            Me.gridGroupingControl1.DataSource = Me.GetTheGridTable()
            gridGroupingControl1.TopLevelGroupOptions.ShowFilterBar = True
            gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
            For i As Integer = 0 To Me.gridGroupingControl1.TableDescriptor.Columns.Count - 1
                gridGroupingControl1.TableDescriptor.Columns(i).AllowFilter = True
            Next i

            Dim ggcStyle As GridTableCellStyleInfo = gridGroupingControl1.TableDescriptor.Columns("Customers").Appearance.AnyRecordFieldCell
            ggcStyle.CellType = "ComboBox"
            ggcStyle.DataSource = Me.comboTable
            ggcStyle.ValueMember = "CustomerID"
            ggcStyle.DisplayMember = "CustomerName"
            Me.gGCFilter = New GroupingGridFilterBarExt()

            gridGroupingControl1.TableModel.ColWidths.ResizeToFit(GridRangeInfo.Rows(1, 10))
            gridGroupingControl1.TableModel.ColWidths(2) = 150
            AddHandler gridGroupingControl1.QueryCellStyleInfo, AddressOf gridGroupingControl1_QueryCellStyleInfo
            Me.DropShadow = True
            Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
            Me.BackColor = Color.White
            Me.MinimizeBox = False
            Me.MaximizeBox = False
            Me.propertyGrid1.BackColor = Color.White
            Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1

            For i As Integer = 0 To gridGroupingControl1.TableDescriptor.Columns.Count - 1
                gridGroupingControl1.TableDescriptor.Columns(i).AllowFilter = True
            Next i

            filter.AllowIndividualColumnWiring = True
            filter.WireGrid(gridGroupingControl1)

            filter1.AllowIndividualColumnWiring = True
            filter1.WireGrid(gridGroupingControl1)

            'Apply Dynamic Filter to the 0th column
            Me.gridGroupingControl1.TableDescriptor.Columns(0).Appearance.FilterBarCell.CellType = "DynamicFilterCell"

            'Apply Excel-Like Filter to the 2nd column
            Me.gridGroupingControl1.TableDescriptor.Columns(2).Appearance.ColumnHeaderCell.CellType = "GridExcelFilterCell"

            gGCFilter.AllowIndividualColumnWiring = True

            'Apply FilterByDisplayMember to the 1st column
            Me.gridGroupingControl1.TableDescriptor.Columns(1).Appearance.FilterBarCell.CellType = "FilterByDisplayMemberCell"
            gGCFilter.WireGrid(Me.gridGroupingControl1)
        End Sub

        Private Sub gridGroupingControl1_QueryCellStyleInfo(ByVal sender As Object, ByVal e As GridTableCellStyleInfoEventArgs)
            If e.TableCellIdentity.TableCellType <> GridTableCellType.ColumnHeaderCell Then
                If e.TableCellIdentity.ColIndex = 2 Then
                    e.Style.BackColor = Color.Orange
                End If

                If e.TableCellIdentity.ColIndex = 4 Then
                    e.Style.Format = "0.00"
                End If

                If e.TableCellIdentity.ColIndex = 4 OrElse e.TableCellIdentity.ColIndex = 3 Then
                    e.Style.HorizontalAlignment = GridHorizontalAlignment.Center
                Else
                    e.Style.HorizontalAlignment = GridHorizontalAlignment.Left
                End If
            End If

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
#Region "Datatables"
        Private numberOfItems As Integer = 5

        Private Function GetTheComboTable() As DataTable
            Dim dt As New DataTable("Customers")

            dt.Columns.Add(New DataColumn("CustomerID", GetType(Integer)))
            dt.Columns.Add(New DataColumn("CustomerName"))

            dt.Rows.Add(New Object() {5, "William Wordsworth"})
            dt.Rows.Add(New Object() {3, "Mark Twain"})
            dt.Rows.Add(New Object() {2, "James Dickey"})
            dt.Rows.Add(New Object() {4, "Emiley Dickinson"})
            dt.Rows.Add(New Object() {1, "William Bronk"})

            Return dt
        End Function

        Private Function GetTheGridTable() As DataTable
            Dim dt As New DataTable("Orders")

            Dim nCols As Integer = 4
            Dim nRows As Integer = 10
            dt.Columns.Add("OrderID", GetType(Integer))
            dt.Columns.Add(New DataColumn("Customers", GetType(Integer)))
            dt.Columns.Add("Quantity", GetType(Integer))
            dt.Columns.Add("Price ($)", GetType(Double))

            Dim r As New Random()
            For i As Integer = 0 To nRows - 1
                Dim dr As DataRow = dt.NewRow()
                For j As Integer = 0 To nCols - 1
                    If j = 0 Then
                        dr(j) = r.Next(1000, 5000)
                    ElseIf j = 1 Then
                        dr(j) = r.Next(1, numberOfItems)
                    ElseIf j = 3 Then
                        dr(j) = r.Next(10, 50)
                    Else
                        dr(j) = CDbl(r.Next(50, 100))
                    End If
                Next j
                dt.Rows.Add(dr)
            Next i
            Return dt
        End Function
#End Region
    End Class
End Namespace