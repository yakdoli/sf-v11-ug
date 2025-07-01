#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Diagnostics
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms
Imports Syncfusion.XlsIO

Namespace ExcelExport_DataBoundGrid
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1 : Inherits System.Windows.Forms.Form
        Private gridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
        Private WithEvents Export As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents SelectedExport As Syncfusion.Windows.Forms.ButtonAdv
        Friend WithEvents RangeExport As Syncfusion.Windows.Forms.ButtonAdv

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

            Dim dataSet As dataSet = New dataSet
            dataSet.ReadXml(GetFile("Datasource.xml"))

            gridDataBoundGrid1.DataSource = dataSet.Tables(0)
            
            Me.gridDataBoundGrid1.DefaultRowHeight = 18
            Me.gridDataBoundGrid1.DefaultColWidth = 70
            Me.gridDataBoundGrid1.ThemesEnabled = True
            Me.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue
            Me.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
            Me.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
            Dim style As GridStyleInfo = gridDataBoundGrid1.BaseStylesMap("Header").StyleInfo
            style.TextColor = Color.MidnightBlue
            style.Font.Facename = "Verdana"
            Me.BackColor = Color.FromArgb(223, 227, 239)
            Me.StartPosition = FormStartPosition.CenterScreen

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

        Private Function GetFile(ByVal fileName As String) As String
            Dim dataFileName As String = "Common\Data\Grid\" & fileName
            For n As Integer = 0 To 11
                If System.IO.File.Exists(dataFileName) Then
                    Return New IO.FileInfo(dataFileName).FullName
                End If
                dataFileName = "..\" & dataFileName
            Next n
            Return dataFileName
        End Function
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
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Private Sub InitializeComponent()
            Me.gridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
            Me.Export = New Syncfusion.Windows.Forms.ButtonAdv
            Me.Panel1 = New System.Windows.Forms.Panel
            Me.SelectedExport = New Syncfusion.Windows.Forms.ButtonAdv
            Me.RangeExport = New Syncfusion.Windows.Forms.ButtonAdv
            CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gridDataBoundGrid1
            '
            Me.gridDataBoundGrid1.AllowDragSelectedCols = True
            Me.gridDataBoundGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridDataBoundGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gridDataBoundGrid1.Location = New System.Drawing.Point(32, 32)
            Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
            Me.gridDataBoundGrid1.OptimizeInsertRemoveCells = True
            Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
            Me.gridDataBoundGrid1.Size = New System.Drawing.Size(552, 288)
            Me.gridDataBoundGrid1.SmartSizeBox = False
            Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
            Me.gridDataBoundGrid1.TabIndex = 0
            Me.gridDataBoundGrid1.Text = "gridDataBoundGrid1"
            Me.gridDataBoundGrid1.UseListChangedEvent = True
            '
            'Export
            '
            Me.Export.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Export.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.Export.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.Export.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Export.Location = New System.Drawing.Point(441, 331)
            Me.Export.Name = "Export"
            Me.Export.Size = New System.Drawing.Size(144, 24)
            Me.Export.TabIndex = 0
            Me.Export.Text = "Export"
            Me.Export.UseVisualStyle = True
            '
            'Panel1
            '
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.RangeExport)
            Me.Panel1.Controls.Add(Me.SelectedExport)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(616, 366)
            Me.Panel1.TabIndex = 1
            '
            'SelectedExport
            '
            Me.SelectedExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.SelectedExport.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.SelectedExport.Location = New System.Drawing.Point(282, 330)
            Me.SelectedExport.Name = "SelectedExport"
            Me.SelectedExport.Size = New System.Drawing.Size(139, 24)
            Me.SelectedExport.TabIndex = 2
            Me.SelectedExport.Text = "SelectedExport"
            Me.SelectedExport.UseVisualStyle = True
            '
            'RangeExport
            '
            Me.RangeExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.RangeExport.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.RangeExport.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.RangeExport.Location = New System.Drawing.Point(116, 330)
            Me.RangeExport.Name = "RangeExport"
            Me.RangeExport.Size = New System.Drawing.Size(145, 23)
            Me.RangeExport.TabIndex = 3
            Me.RangeExport.Text = "RangeExport"
            Me.RangeExport.UseVisualStyle = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(616, 366)
            Me.Controls.Add(Me.Export)
            Me.Controls.Add(Me.gridDataBoundGrid1)
            Me.Controls.Add(Me.Panel1)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "DBG XLS Export Demo"
            CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
            Application.EnableVisualStyles()
#End If
            Application.Run(New Form1)
        End Sub

        Private Sub Export_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Export.Click
            Dim gecc As Syncfusion.GridExcelConverter.GridExcelConverterControl = New Syncfusion.GridExcelConverter.GridExcelConverterControl

            Dim saveFileDialog As saveFileDialog = New saveFileDialog
            saveFileDialog.Filter = "Files(*.xls)|*.xls"
            saveFileDialog.DefaultExt = ".xls"

            If saveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                gecc.GridToExcel(Me.gridDataBoundGrid1.Model, saveFileDialog.FileName, Syncfusion.GridExcelConverter.ConverterOptions.RowHeaders)

                If MessageBox.Show("Do you wish to open the xls file now?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim proc As Process = New Process
                    proc.StartInfo.FileName = saveFileDialog.FileName
                    proc.Start()
                End If
            End If
        End Sub

        Private Sub SelectedExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectedExport.Click
            Dim ExcelAdv As New Syncfusion.GridExcelConverter.GridExcelConverterControl()
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Files(*.xls)|*.xls"
            saveFileDialog.DefaultExt = ".xls"

            If Me.gridDataBoundGrid1.Selections.Count > 0 And saveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                ExcelAdv.SelectedExport(Me.gridDataBoundGrid1.Model, saveFileDialog.FileName, Syncfusion.GridExcelConverter.ConverterOptions.ColumnHeaders)
                If File.Exists(saveFileDialog.FileName) Then
                    If MessageBox.Show("Do you wish to open the xls file now?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                        Dim proc As New Process()
                        proc.StartInfo.FileName = saveFileDialog.FileName
                        proc.Start()
                    End If
                End If
            End If
        End Sub

        Private Sub RangeExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RangeExport.Click
            Dim engine As New ExcelEngine()
            Dim app As IApplication = engine.Excel.Application
            Dim book As IWorkbook = app.Workbooks.Create(1)

            Dim gecc As New Syncfusion.GridExcelConverter.GridExcelConverterControl()

            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Files(*.xls)|*.xls"
            saveFileDialog.DefaultExt = ".xls"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim range As GridRangeInfo = GridRangeInfo.Rows(Me.gridDataBoundGrid1.TopRowIndex, Me.gridDataBoundGrid1.TopRowIndex + 5)
                gecc.ExportRange(range, Me.gridDataBoundGrid1.Model, book.Worksheets(0), Syncfusion.GridExcelConverter.ConverterOptions.ColumnHeaders)
                book.SaveAs(saveFileDialog.FileName)
                If MessageBox.Show("Do you wish to open the xls file now?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim proc As New Process()
                    proc.StartInfo.FileName = saveFileDialog.FileName
                    proc.Start()
                End If
            End If
        End Sub
    End Class
End Namespace
