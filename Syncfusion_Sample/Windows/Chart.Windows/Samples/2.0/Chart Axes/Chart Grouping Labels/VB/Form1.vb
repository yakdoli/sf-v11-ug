Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing

Namespace GridLabelsChartSample_2002
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
    Public Class Form1 : Inherits Syncfusion.Windows.Forms.Office2007Form
        Private WithEvents panel1 As System.Windows.Forms.Panel
        Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private WithEvents label14 As System.Windows.Forms.Label
        Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
        Private WithEvents label15 As System.Windows.Forms.Label
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            InitializeComponent()
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
      

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.label15 = New System.Windows.Forms.Label
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.label14 = New System.Windows.Forms.Label
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel1 = New System.Windows.Forms.Panel
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'label15
            '
            Me.label15.AutoSize = True
            Me.label15.BackColor = System.Drawing.Color.Transparent
            Me.label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label15.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label15.Location = New System.Drawing.Point(490, 6)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(77, 14)
            Me.label15.TabIndex = 28
            Me.label15.Text = "Axes Format"
            '
            'checkBox2
            '
            Me.checkBox2.Checked = True
            Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox2.ForeColor = System.Drawing.Color.Black
            Me.checkBox2.Location = New System.Drawing.Point(493, 31)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(152, 19)
            Me.checkBox2.TabIndex = 22
            Me.checkBox2.Text = "Using ChartFormatAxisLabel"
            '
            'label14
            '
            Me.label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.label14.Location = New System.Drawing.Point(493, 22)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(155, 1)
            Me.label14.TabIndex = 29
            '
            'chartControl1
            '
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(483, 75)
            Me.chartControl1.Location = New System.Drawing.Point(17, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.Size = New System.Drawing.Size(614, 429)
            Me.chartControl1.TabIndex = 6
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "chartControl1"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ZoomOutIncrement = 1.5
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.label14)
            Me.panel1.Controls.Add(Me.label15)
            Me.panel1.Controls.Add(Me.checkBox2)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 453)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(651, 51)
            Me.panel1.TabIndex = 5
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(651, 504)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Grouping Labels"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New Form1())
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            InitializeChartData()
            InitializeChartAppearance()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)

        End Sub

        Protected Sub InitializeChartData()
            Dim series1 As ChartSeries = New ChartSeries("Food Products", ChartSeriesType.Scatter)
            Dim series2 As ChartSeries = New ChartSeries("Crude Material", ChartSeriesType.Scatter)
            Dim series3 As ChartSeries = New ChartSeries("Mineral Fuels", ChartSeriesType.Scatter)

            series1.Text = series1.Name
            series2.Text = series2.Name
            series3.Text = series3.Name

            series1.Points.Add(1.1, 110)
            series1.Points.Add(2, 250)
            series1.Points.Add(3, 280)
            series1.Points.Add(4, 390)
            series1.Points.Add(5, 530)
            series1.Points.Add(6, 600)


            series2.Points.Add(1, 100)
            series2.Points.Add(2.2, 210)
            series2.Points.Add(3.1, 320)
            series2.Points.Add(3.9, 430)
            series2.Points.Add(5, 510)
            series2.Points.Add(6.2, 590)

            series3.Points.Add(1, 90)
            series3.Points.Add(2.9, 190)
            series3.Points.Add(3, 300)
            series3.Points.Add(4.3, 400)
            series3.Points.Add(5, 450)
            series3.Points.Add(5.6, 610)

            Me.chartControl1.Series.Add(series1)
            Me.chartControl1.Series.Add(series2)
            Me.chartControl1.Series.Add(series3)
        End Sub

        Protected Sub InitializeChartAppearance()
            Me.chartControl1.Series(0).Style.Symbol.Color = Color.FromArgb(0, 128, 192)
            Me.chartControl1.Series(1).Style.Symbol.Color = Color.FromArgb(196, 0, 0)
            Me.chartControl1.Series(2).Style.Symbol.Color = Color.FromArgb(44, 128, 2)


            Me.chartControl1.Series(1).Style.Symbol.Shape = ChartSymbolShape.InvertedTriangle
            Me.chartControl1.Series(2).Style.Symbol.Shape = ChartSymbolShape.Diamond

            Me.chartControl1.Legend.RepresentationType = ChartLegendRepresentationType.InvertedTriangle

            Me.chartControl1.Text = "Speed-Torque Variation"
            Me.chartControl1.PrimaryXAxis.Title = "Speed (rpm)"
            Me.chartControl1.PrimaryYAxis.Title = "Torque(Nm)"
            ' Review
            ' adding grouping labels
            Dim cagl As ChartAxisGroupingLabel = New ChartAxisGroupingLabel(New DoubleRange(0.5, 2.5), "GroupingLabel1")
            cagl.BorderStyle = ChartAxisGroupingLabelBorderStyle.Rectangle
            cagl.RotateAngle = 90
            cagl.MaxTextWidth = 80
            Me.chartControl1.PrimaryXAxis.GroupingLabels.Add(cagl)

            cagl = New ChartAxisGroupingLabel(New DoubleRange(100, 400), "GroupingLabel3")
            cagl.BorderStyle = ChartAxisGroupingLabelBorderStyle.Rectangle
            cagl.RotateAngle = 90
            cagl.Row = 0
            Me.chartControl1.PrimaryYAxis.GroupingLabels.Add(cagl)

            cagl = New ChartAxisGroupingLabel(New DoubleRange(0.5, 6.5), "All X Axis Range", Color.Red, New Pen(Color.Red, 1.0F), New Font("Arial", 10.0F))
            cagl.BorderStyle = ChartAxisGroupingLabelBorderStyle.Brace
            cagl.Row = 1
            Me.chartControl1.PrimaryXAxis.GroupingLabels.Add(cagl)
        End Sub


        Private Sub checkBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
            Me.chartControl1.PrimaryXAxis.Labels.Clear()
            Me.chartControl1.PrimaryYAxis.Labels.Clear()
            If (Not Me.checkBox2.Checked) Then
                CustomLabel()
            End If
        End Sub

        Private Sub CustomLabel()
            ' adding custom labels
            Me.chartControl1.PrimaryXAxis.Labels.Add(New ChartAxisLabel("Label1", Color.Black, New Font("Monospace", 10), 1, "", ChartValueType.Custom))
            Me.chartControl1.PrimaryXAxis.Labels.Add(New ChartAxisLabel("Label2", Color.Black, New Font("Monospace", 10), 2, "", ChartValueType.Custom))
            Me.chartControl1.PrimaryXAxis.Labels.Add(New ChartAxisLabel("Label3", Color.Black, New Font("Monospace", 10), 3, "", ChartValueType.Custom))
            Me.chartControl1.PrimaryXAxis.Labels.Add(New ChartAxisLabel("Label4", Color.Black, New Font("Monospace", 10), 4, "", ChartValueType.Custom))
            Me.chartControl1.PrimaryXAxis.Labels.Add(New ChartAxisLabel("Label5", Color.Black, New Font("Monospace", 10), 5, "", ChartValueType.Custom))
            Me.chartControl1.PrimaryXAxis.Labels.Add(New ChartAxisLabel("Label6", Color.Black, New Font("Monospace", 10), 6, "", ChartValueType.Custom))

            Me.chartControl1.PrimaryYAxis.Labels.Add(New ChartAxisLabel("Label1", Color.Black, New Font("Monospace", 10), 100, "", ChartValueType.Custom))
            Me.chartControl1.PrimaryYAxis.Labels.Add(New ChartAxisLabel("Label2", Color.Black, New Font("Monospace", 10), 200, "", ChartValueType.Custom))
            Me.chartControl1.PrimaryYAxis.Labels.Add(New ChartAxisLabel("Label3", Color.Black, New Font("Monospace", 10), 300, "", ChartValueType.Custom))
            Me.chartControl1.PrimaryYAxis.Labels.Add(New ChartAxisLabel("Label4", Color.Black, New Font("Monospace", 10), 400, "", ChartValueType.Custom))
            Me.chartControl1.PrimaryYAxis.Labels.Add(New ChartAxisLabel("Label5", Color.Black, New Font("Monospace", 10), 500, "", ChartValueType.Custom))
            Me.chartControl1.PrimaryYAxis.Labels.Add(New ChartAxisLabel("Label6", Color.Black, New Font("Monospace", 10), 600, "", ChartValueType.Custom))

            Me.chartControl1.PrimaryXAxis.LabelRotate = False

            Me.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Wrap
            Me.chartControl1.PrimaryXAxis.OpposedPosition = False
            Me.chartControl1.PrimaryXAxis.OpposedPosition = False
            Me.chartControl1.PrimaryYAxis.OpposedPosition = False
        End Sub

        Private Sub chartControl1_ChartFormatAxisLabel(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventArgs) Handles chartControl1.ChartFormatAxisLabel
            'Review
            If Me.checkBox2.Checked Then
                e.Label = e.Value.ToString(".00")
                e.Handled = True
            End If
        End Sub
    End Class
End Namespace
