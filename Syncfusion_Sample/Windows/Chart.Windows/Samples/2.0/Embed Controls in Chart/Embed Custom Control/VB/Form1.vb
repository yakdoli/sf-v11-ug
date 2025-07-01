#Region "Copyright Syncfusion Inc. 2001 - 2008"
'
'  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
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
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Namespace Syncfusion.Windows.Forms.Chart.Samples
    Public Class Form1
        Inherits Syncfusion.Windows.Forms.Office2007Form
#Region "Private Members"
        Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private chartDockControl1 As ChartDockControl
        Private count As Integer = 0
        Private dt As DataTable
        Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
        Private WithEvents radioButton2 As System.Windows.Forms.RadioButton
        Private dataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
        Private label10 As Label
        Private color As Color() = New Color() {System.Drawing.Color.FromArgb(253, 225, 21), System.Drawing.Color.FromArgb(243, 177, 13), System.Drawing.Color.FromArgb(253, 225, 21)}
        Private color2 As Color() = New Color() {System.Drawing.Color.FromArgb(237, 148, 8), System.Drawing.Color.FromArgb(231, 119, 3), System.Drawing.Color.FromArgb(237, 148, 8)}
        Private color3 As Color() = New Color() {System.Drawing.Color.FromArgb(252, 0, 0), System.Drawing.Color.FromArgb(130, 0, 0), System.Drawing.Color.FromArgb(252, 0, 0)}
        Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
        Private WithEvents dataGridView1 As DataGridView
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing
#End Region

#Region "Form's Constructor, Main and Dispose"
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Application.EnableVisualStyles()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()

            Application.Run(New Form1())
        End Sub
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
#End Region

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.dataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
            Me.label10 = New System.Windows.Forms.Label
            Me.radioButton2 = New System.Windows.Forms.RadioButton
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.dataGridView1 = New System.Windows.Forms.DataGridView
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer)))
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(76, 292)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
            Me.chartControl1.Location = New System.Drawing.Point(16, 11)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.Title = "Month"
            Me.chartControl1.PrimaryYAxis.Title = "Sales in Millions"
            Me.chartControl1.Size = New System.Drawing.Size(499, 387)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "Fruit Production Statistics"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Fruit Production Statistics"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'dataGridTableStyle1
            '
            Me.dataGridTableStyle1.DataGrid = Nothing
            Me.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
            '
            'label10
            '
            Me.label10.BackColor = System.Drawing.Color.Transparent
            Me.label10.Dock = System.Windows.Forms.DockStyle.Right
            Me.label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label10.ForeColor = System.Drawing.Color.Black
            Me.label10.Location = New System.Drawing.Point(313, 0)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(96, 23)
            Me.label10.TabIndex = 2
            Me.label10.Text = "Table Position"
            Me.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'radioButton2
            '
            Me.radioButton2.AutoSize = True
            Me.radioButton2.Checked = True
            Me.radioButton2.Dock = System.Windows.Forms.DockStyle.Right
            Me.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton2.Location = New System.Drawing.Point(459, 0)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(64, 23)
            Me.radioButton2.TabIndex = 2
            Me.radioButton2.TabStop = True
            Me.radioButton2.Text = "Bottom"
            '
            'radioButton1
            '
            Me.radioButton1.AutoSize = True
            Me.radioButton1.Dock = System.Windows.Forms.DockStyle.Right
            Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton1.Location = New System.Drawing.Point(409, 0)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(50, 23)
            Me.radioButton1.TabIndex = 3
            Me.radioButton1.Text = "Top"
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BackColor = System.Drawing.Color.White
            Me.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched
            Me.gradientPanel1.BorderColor = System.Drawing.Color.Black
            Me.gradientPanel1.Controls.Add(Me.label10)
            Me.gradientPanel1.Controls.Add(Me.radioButton1)
            Me.gradientPanel1.Controls.Add(Me.radioButton2)
            Me.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.gradientPanel1.Location = New System.Drawing.Point(0, 409)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(527, 27)
            Me.gradientPanel1.TabIndex = 4
            '
            'dataGridView1
            '
            Me.dataGridView1.AllowUserToAddRows = False
            Me.dataGridView1.AllowUserToDeleteRows = False
            Me.dataGridView1.AllowUserToResizeColumns = False
            Me.dataGridView1.AllowUserToResizeRows = False
            Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dataGridView1.Location = New System.Drawing.Point(0, 0)
            Me.dataGridView1.Name = "dataGridView1"
            Me.dataGridView1.Size = New System.Drawing.Size(345, 164)
            Me.dataGridView1.TabIndex = 1
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(527, 436)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.gradientPanel1)
            Me.Controls.Add(Me.dataGridView1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart-Hosting Custom Controls"
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            Me.gradientPanel1.PerformLayout()
            CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Me.chartDockControl1 = New ChartDockControl(Me.dataGridView1)
            Me.chartDockControl1.Alignment = ChartAlignment.Center
            Me.chartDockControl1.Orientation = ChartOrientation.Horizontal
            Me.chartDockControl1.Position = ChartDock.Bottom
            Me.chartControl1.Controls.Add(chartDockControl1)
            Me.chartControl1.DockingManager.Add(Me.chartDockControl1)
            Me.dataGridView1.Size = New Size(Me.chartControl1.Width - 93, Me.chartControl1.Height - 295)
            InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
            PopulateDataGrid()


        End Sub
#End Region

#Region "Helper Methods"
#Region "InitializeChartData"
        ''' <summary>
        ''' Initializes the ChartControl's data and sets the Chart type
        ''' </summary>
        Protected Sub InitializeChartData()

            Dim series1 As ChartSeries = New ChartSeries()
            series1.Type = ChartSeriesType.StackingColumn
            series1.Name = "Banana"
            series1.Text = "Banana"

            series1.Points.Add(1, 35)
            series1.Points.Add(2, 30)
            series1.Points.Add(3, 25)
            series1.Points.Add(4, 20)
            series1.Points.Add(5, 15)
            series1.Points.Add(6, 10)
            series1.Points.Add(7, 5)
            series1.Points.Add(8, 15)
            series1.Points.Add(9, 20)
            series1.Points.Add(10, 25)
            series1.Points.Add(11, 30)
            series1.Points.Add(12, 35)
            Me.chartControl1.Series.Add(series1)
            '/////

            Dim series2 As ChartSeries = New ChartSeries()
            series2.Type = ChartSeriesType.StackingColumn
            series2.Name = "Apple"
            series2.Text = "Apple"

            series2.Points.Add(1, 25)
            series2.Points.Add(2, 20)
            series2.Points.Add(3, 18)
            series2.Points.Add(4, 17)
            series2.Points.Add(5, 15)
            series2.Points.Add(6, 10)
            series2.Points.Add(7, 5)
            series2.Points.Add(8, 7)
            series2.Points.Add(9, 10)
            series2.Points.Add(10, 15)
            series2.Points.Add(11, 20)
            series2.Points.Add(12, 25)
            Me.chartControl1.Series.Add(series2)


            Dim series3 As ChartSeries = New ChartSeries()
            series3.Type = ChartSeriesType.StackingColumn
            series3.Name = "Orange"
            series3.Text = "Orange"
            series3.Points.Add(1, 40)
            series3.Points.Add(2, 35)
            series3.Points.Add(3, 30)
            series3.Points.Add(4, 25)
            series3.Points.Add(5, 20)
            series3.Points.Add(6, 15)
            series3.Points.Add(7, 10)
            series3.Points.Add(8, 15)
            series3.Points.Add(9, 20)
            series3.Points.Add(10, 25)
            series3.Points.Add(11, 30)
            series3.Points.Add(12, 35)
            Me.chartControl1.Series.Add(series3)
        End Sub
#End Region

#Region "Populate Data Grid"
        ''' <summary>
        ''' Populate the DataGrid with series values as data
        ''' </summary>
        Private strMonth As String() = New String() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
        Protected Sub PopulateDataGrid()
            dt = New DataTable("SeriesValue")
            Dim ser As DataColumn = dt.Columns.Add("Fruits", GetType(String))
            For j As Integer = 0 To Me.chartControl1.Series(0).Points.Count - 1
                Dim dc As DataColumn = dt.Columns.Add(strMonth(j).ToString(), GetType(Double))
            Next j
            For i As Integer = 0 To Me.chartControl1.Series.Count - 1
                Dim series As ChartSeries = Me.chartControl1.Series(i)
                If Not dt Is Nothing Then
                    Dim dr As DataRow = dt.NewRow()
                    dt.Rows.Add(dr)
                    count = Math.Max(0, dt.Rows.Count - 1)
                    If count = 0 Then
                        dt.Rows(count)("Fruits") = "Banana"
                    End If
                    If count = 1 Then
                        dt.Rows(count)("Fruits") = "Apple"
                    End If
                    If count = 2 Then
                        dt.Rows(count)("Fruits") = "Orange"
                    End If
                    For j As Integer = 0 To series.Points.Count - 1
                        dt.Rows(count)(strMonth(j)) = series.Points(j).YValues(0)
                    Next j

                End If

            Next i
            Me.dataGridView1.DataMember = "SeriesValue"

            Me.dataGridView1.DataSource = dt
            For Each column As DataGridViewColumn In Me.dataGridView1.Columns
                column.Width = 28
            Next column
            Me.dataGridView1.Columns(0).Width = 66
            Me.dataGridView1.RowHeadersVisible = False
            Me.dataGridView1.Columns(0).ReadOnly = True
            Me.dataGridView1.Font = New System.Drawing.Font("Arial", 7.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(227, 237, 255)
            Me.dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(147, 206, 242)
            Me.dataGridView1.Columns(0).DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 159, 222)
            Me.dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        End Sub
#End Region


#Region "UpdateChartSeries()"

        ''' <summary>
        ''' This updates the chart with the changed values
        ''' </summary>
        Protected Sub UpdateChartSeries()
            Try
                Dim seriesCount As Integer = Me.dataGridView1.SelectedCells(0).RowIndex
                Dim ColCount As Integer = Me.dataGridView1.SelectedCells(0).ColumnIndex
                Dim pointValue As Double = Convert.ToDouble(Me.dataGridView1.SelectedCells(0).Value)
                Me.chartControl1.Series(seriesCount).Points(ColCount - 1).YValues(0) = pointValue
                Me.chartControl1.Refresh()
            Catch
            End Try
        End Sub
#End Region

#End Region

#Region "Events"

        Private Sub radioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton2.CheckedChanged, radioButton1.CheckedChanged
            If Not Me.chartDockControl1 Is Nothing Then
                If Me.radioButton1.Checked Then
                    Me.chartDockControl1.Position = ChartDock.Top
                Else
                    Me.chartDockControl1.Position = ChartDock.Bottom
                End If
            End If
        End Sub

        Private Sub Form1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
            Me.dataGridView1.Width = Me.chartControl1.Width - 50
        End Sub

        Private Sub dataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dataGridView1.CellEndEdit
            UpdateChartSeries()
        End Sub
#End Region

    End Class
End Namespace
