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
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing

Namespace Syncfusion.Windows.Forms.Chart.Samples
    Public Class Form1
        Inherits Office2007Form
#Region "Private Members"
        Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private prodDs1 As DataSet
        Private WithEvents timer1 As System.Windows.Forms.Timer
        Private components As System.ComponentModel.IContainer
        Private model As ChartDataBindModel = Nothing
        Private panel1 As System.Windows.Forms.Panel
        Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
        Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
        Private label1 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown

        Private lastTime As DateTime = DateTime.Now
#End Region

#Region "Form Constructor, Main And Dispose"
        Public Sub New()

            InitializeComponent()

        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.panel1 = New System.Windows.Forms.Panel
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.label3 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.panel1.SuspendLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent)
            Me.chartControl1.Depth = 1.0!
            Me.chartControl1.ForeColor = System.Drawing.Color.MidnightBlue
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.Legend.ForeColor = System.Drawing.Color.MidnightBlue
            Me.chartControl1.Legend.Location = New System.Drawing.Point(58, 318)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
            Me.chartControl1.Location = New System.Drawing.Point(9, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.Color.MidnightBlue
            Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.Gray
            Me.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.MidnightBlue
            Me.chartControl1.PrimaryXAxis.TitleColor = System.Drawing.Color.MidnightBlue
            Me.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.Color.MidnightBlue
            Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.MidnightBlue
            Me.chartControl1.PrimaryYAxis.LineType.BackColor = System.Drawing.Color.MidnightBlue
            Me.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.MidnightBlue
            Me.chartControl1.PrimaryYAxis.TitleColor = System.Drawing.Color.MidnightBlue
            Me.chartControl1.Rotation = 0.1!
            Me.chartControl1.Size = New System.Drawing.Size(530, 395)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "Syncfusion Essential Chart"
            Me.chartControl1.Tilt = 0.1!
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.Title.ForeColor = System.Drawing.Color.MidnightBlue
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Syncfusion Essential Chart"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'timer1
            '
            Me.timer1.Interval = 1000
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.numericUpDown1)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.comboBox2)
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 422)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(550, 25)
            Me.panel1.TabIndex = 1
            '
            'numericUpDown1
            '
            Me.numericUpDown1.BackColor = System.Drawing.Color.White
            Me.numericUpDown1.Location = New System.Drawing.Point(410, 2)
            Me.numericUpDown1.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
            Me.numericUpDown1.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.ReadOnly = True
            Me.numericUpDown1.Size = New System.Drawing.Size(79, 20)
            Me.numericUpDown1.TabIndex = 7
            Me.numericUpDown1.Value = New Decimal(New Integer() {2, 0, 0, 0})
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label3.Location = New System.Drawing.Point(30, 4)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(42, 13)
            Me.label3.TabIndex = 6
            Me.label3.Text = "Interval"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label2.Location = New System.Drawing.Point(198, 4)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(53, 13)
            Me.label2.TabIndex = 5
            Me.label2.Text = "Line Style"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label1.Location = New System.Drawing.Point(377, 4)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(35, 13)
            Me.label1.TabIndex = 4
            Me.label1.Text = "Width"
            '
            'comboBox2
            '
            Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox2.Location = New System.Drawing.Point(72, 3)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(79, 21)
            Me.comboBox2.TabIndex = 3
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox1.Location = New System.Drawing.Point(252, 3)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(79, 21)
            Me.comboBox1.TabIndex = 2
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(550, 447)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Real Time"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            CreateDataSet()
            InitializeChartData()
            InitializeControlSettings()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region "Helper Methods"
#Region "InitializeControlSettings"

        Private Sub InitializeControlSettings()
            For Each dashstyle As String In System.Enum.GetNames(GetType(System.Drawing.Drawing2D.DashStyle))
                Me.comboBox1.Items.Add(dashstyle)
            Next dashstyle
            Me.comboBox1.SelectedIndex = 0
            Me.comboBox2.Items.Add(100)
            Me.comboBox2.Items.Add(200)
            Me.comboBox2.Items.Add(400)
            Me.comboBox2.Items.Add(600)
            Me.comboBox2.Items.Add(800)
            Me.comboBox2.Items.Add(1000)
            Me.comboBox2.SelectedIndex = 3
        End Sub
#End Region

#Region "InitializeChartData"
        Protected Sub InitializeChartData()
            Me.chartControl1.Indexed = False
            Dim series As ChartSeries = New ChartSeries()
            series.Name = "Products"
            series.Text = series.Name
            model = New ChartDataBindModel(Me.prodDs1, "Products")
            model.XName = "Date"
            model.YNames = New String() {"Load"}
            series.SeriesModel = model
            series.Type = ChartSeriesType.Spline
            Me.chartControl1.Series.Add(series)

            Me.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime
            Me.chartControl1.PrimaryXAxis.DateTimeFormat = "dd-hh:mm tt"
            Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
            Me.chartControl1.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(lastTime, lastTime.AddDays(1), 4, ChartDateTimeIntervalType.Hours)
        End Sub
#End Region

#Region "CreateDataSet"
        Private Sub CreateDataSet()
            Dim tableName As String = "Products"
            prodDs1 = New DataSet()
            prodDs1.Tables.Add(tableName)

            Dim ExpiresDate As DataColumn = prodDs1.Tables(tableName).Columns.Add("Date", GetType(System.DateTime))
            Dim Quantity As DataColumn = prodDs1.Tables(tableName).Columns.Add("Load", GetType(Double))

            Me.timer1.Start()
        End Sub
#End Region
#End Region

#Region "Events"
        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer1.Tick
            Try
                Dim tableName As String = "Products"
                Dim rand As Random = New Random()
                If Not prodDs1 Is Nothing AndAlso prodDs1.Tables.Count > 0 Then
                    Dim drEmpty As DataRow = prodDs1.Tables(tableName).NewRow()
                    prodDs1.Tables(tableName).Rows.Add(drEmpty)
                    Dim count As Integer = Math.Max(0, prodDs1.Tables(tableName).Rows.Count - 1)

                    prodDs1.Tables(tableName).Rows(count)("Load") = CDbl(rand.Next(0, 60))
                    prodDs1.Tables(tableName).Rows(count)("Date") = lastTime.AddMinutes(30)

                    lastTime = CDate(prodDs1.Tables(tableName).Rows(count)("Date"))

                    If lastTime >= Me.chartControl1.PrimaryXAxis.DateTimeRange.End Then
                        Me.chartControl1.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(Me.chartControl1.PrimaryXAxis.DateTimeRange.Start, Me.chartControl1.PrimaryXAxis.DateTimeRange.End.AddDays(1), 4, ChartDateTimeIntervalType.Hours)
                    End If
                End If


            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
        End Sub



        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
            Me.chartControl1.Series(0).Style.Border.DashStyle = CType(System.Enum.Parse(GetType(DashStyle), Me.comboBox1.SelectedItem.ToString(), True), DashStyle)
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox2.SelectedIndexChanged
            Me.timer1.Interval = CInt(Fix(Me.comboBox2.SelectedItem))
        End Sub

        Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
            Me.chartControl1.Series(0).Style.Border.Width = Single.Parse(Me.numericUpDown1.Value.ToString())
            Me.chartControl1.Refresh()
        End Sub

#End Region
    End Class
End Namespace