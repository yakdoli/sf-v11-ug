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
Imports Syncfusion.Grouping
Imports Syncfusion.GridHelperClasses
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms

Namespace ExcelStyleFilter
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private filter As GridOffice2007Filter
		Private WithEvents showFilter As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents EnableFilteredColIcon As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private groupBox1 As GroupBox
		Private WithEvents filterMouseHover As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
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
			Me.showFilter = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.EnableFilteredColIcon = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.filterMouseHover = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.showFilter, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.EnableFilteredColIcon, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			CType(Me.filterMouseHover, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridGroupingControl1
			' 
			Me.gridGroupingControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
			Me.gridGroupingControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gridGroupingControl1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridGroupingControl1.Location = New System.Drawing.Point(12, 16)
			Me.gridGroupingControl1.Name = "gridGroupingControl1"
			Me.gridGroupingControl1.Size = New System.Drawing.Size(319, 320)
			Me.gridGroupingControl1.TabIndex = 1
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
			Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
			Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
			Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(215))))), (CInt(Fix((CByte(229)))))))
			Me.gridGroupingControl1.Text = "gridGroupingControl1"
			Me.gridGroupingControl1.VersionInfo = "4.201.0.37"
			' 
			' showFilter
			' 
			Me.showFilter.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.showFilter.DrawFocusRectangle = False
			Me.showFilter.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.showFilter.Location = New System.Drawing.Point(6, 30)
			Me.showFilter.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.showFilter.Name = "showFilter"
			Me.showFilter.Size = New System.Drawing.Size(162, 28)
			Me.showFilter.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.showFilter.TabIndex = 2
			Me.showFilter.Text = "Enable Office2007Filter"
			Me.showFilter.ThemesEnabled = False
'			Me.showFilter.CheckStateChanged += New System.EventHandler(Me.showFilter_CheckStateChanged)
			' 
			' EnableFilteredColIcon
			' 
			Me.EnableFilteredColIcon.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.EnableFilteredColIcon.DrawFocusRectangle = False
			Me.EnableFilteredColIcon.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.EnableFilteredColIcon.Location = New System.Drawing.Point(7, 69)
			Me.EnableFilteredColIcon.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.EnableFilteredColIcon.Name = "EnableFilteredColIcon"
			Me.EnableFilteredColIcon.Size = New System.Drawing.Size(184, 19)
			Me.EnableFilteredColIcon.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.EnableFilteredColIcon.TabIndex = 3
			Me.EnableFilteredColIcon.Text = "Enable Filtered Column Icon"
			Me.EnableFilteredColIcon.ThemesEnabled = False
'			Me.EnableFilteredColIcon.CheckStateChanged += New System.EventHandler(Me.EnableFilteredColIcon_CheckStateChanged)
			' 
			' groupBox1
			' 
			Me.groupBox1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.groupBox1.Controls.Add(Me.filterMouseHover)
			Me.groupBox1.Controls.Add(Me.showFilter)
			Me.groupBox1.Controls.Add(Me.EnableFilteredColIcon)
			Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox1.Location = New System.Drawing.Point(358, 16)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(200, 149)
			Me.groupBox1.TabIndex = 4
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Filter Options"
			' 
			' filterMouseHover
			' 
			Me.filterMouseHover.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.filterMouseHover.Checked = True
			Me.filterMouseHover.CheckState = System.Windows.Forms.CheckState.Checked
			Me.filterMouseHover.DrawFocusRectangle = False
			Me.filterMouseHover.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.filterMouseHover.Location = New System.Drawing.Point(7, 100)
			Me.filterMouseHover.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.filterMouseHover.Name = "filterMouseHover"
			Me.filterMouseHover.Size = New System.Drawing.Size(184, 28)
			Me.filterMouseHover.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.filterMouseHover.TabIndex = 4
			Me.filterMouseHover.Text = "Show filter on MouseHover"
			Me.filterMouseHover.ThemesEnabled = False
'			Me.filterMouseHover.CheckStateChanged += New System.EventHandler(Me.filterMouseHover_CheckStateChanged)
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(570, 354)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.gridGroupingControl1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "MS Excel-Style Filter Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.showFilter, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.EnableFilteredColIcon, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			CType(Me.filterMouseHover, System.ComponentModel.ISupportInitialize).EndInit()
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
			filter = New GridOffice2007Filter()
			Dim dt As New DataTable("MyTable")

			Dim nCols As Integer = 5
			Dim nRows As Integer = 20

			For i As Integer = 0 To nCols - 1
				dt.Columns.Add(New DataColumn(String.Format("Col{0}", i), GetType(Integer)))
			Next i
			Dim rand As New Random()

			For i As Integer = 0 To nRows - 1
				Dim dr As DataRow = dt.NewRow()
				For j As Integer = 0 To nCols - 1

					dr(j) = rand.Next(500)
				Next j
				dt.Rows.Add(dr)
			Next i

			Me.gridGroupingControl1.DataSource = dt
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.BackColor = Color.White
			Me.DropShadow = True
			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
			For Each col As GridColumnDescriptor In Me.gridGroupingControl1.TableDescriptor.Columns
				col.AllowFilter = True
			Next col
			Me.showFilter.Checked = True
			Me.EnableFilteredColIcon.Checked = True
			Me.gridGroupingControl1.AllowProportionalColumnSizing = True
		End Sub

		Private Sub showFilter_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles showFilter.CheckStateChanged
			If Me.showFilter.Checked Then
				filter.WireGrid(Me.gridGroupingControl1)
				Me.EnableFilteredColIcon.Enabled = True
				Me.filterMouseHover.Enabled = True
			Else
				filter.UnWireGrid(Me.gridGroupingControl1)
				Me.EnableFilteredColIcon.Enabled = False
				Me.filterMouseHover.Enabled = False
			End If
		End Sub

		Private Sub EnableFilteredColIcon_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles EnableFilteredColIcon.CheckStateChanged
			GridOffice2007Filter.EnableFilteredColumnIcon = Me.EnableFilteredColIcon.Checked
			Me.gridGroupingControl1.Refresh()
		End Sub

		Private Sub filterMouseHover_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles filterMouseHover.CheckStateChanged
			GridOffice2007Filter.ShowOffice2007FilterOnMouseHover = Me.filterMouseHover.Checked
			Me.gridGroupingControl1.Refresh()
		End Sub
	End Class
End Namespace
