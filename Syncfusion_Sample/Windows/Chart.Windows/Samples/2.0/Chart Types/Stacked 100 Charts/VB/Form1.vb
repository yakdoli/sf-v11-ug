Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing

Namespace Stacked100Charts
    Public Class Form1
        Inherits Office2007Form

#Region "Private Members"
        Private label1 As System.Windows.Forms.Label
        Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
        Private panel1 As System.Windows.Forms.Panel
        Private WithEvents chartControl1 As ChartControl
        Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

#End Region

#Region "Constructor, Main and Dispose"
        Public Sub New()

            InitializeComponent()

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
            Me.label1 = New System.Windows.Forms.Label
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.panel1 = New System.Windows.Forms.Panel
            Me.CheckBox1 = New System.Windows.Forms.CheckBox
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.CheckBox2 = New System.Windows.Forms.CheckBox
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'label1
            '
            Me.label1.Dock = System.Windows.Forms.DockStyle.Right
            Me.label1.Location = New System.Drawing.Point(248, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(69, 22)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Chart Type"
            '
            'comboBox1
            '
            Me.comboBox1.Dock = System.Windows.Forms.DockStyle.Right
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox1.Items.AddRange(New Object() {"StackingArea100", "StackingBar100", "StackingColumn100"})
            Me.comboBox1.Location = New System.Drawing.Point(317, 0)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(121, 21)
            Me.comboBox1.TabIndex = 2
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.CheckBox2)
            Me.panel1.Controls.Add(Me.CheckBox1)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 378)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(438, 22)
            Me.panel1.TabIndex = 3
            '
            'CheckBox1
            '
            Me.CheckBox1.AutoSize = True
            Me.CheckBox1.Location = New System.Drawing.Point(18, 0)
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Size = New System.Drawing.Size(76, 17)
            Me.CheckBox1.TabIndex = 3
            Me.CheckBox1.Text = "Enable 3D"
            Me.CheckBox1.UseVisualStyleBackColor = True
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(219, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(1, 10, 17, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(218, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(135, Byte), Integer)))
            Me.chartControl1.Font = New System.Drawing.Font("Arial", 13.0!)
            '
            '
            '
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.ForeColor = System.Drawing.Color.Black
            Me.chartControl1.Legend.Location = New System.Drawing.Point(272, 70)
            Me.chartControl1.Location = New System.Drawing.Point(18, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.GridLineType.Width = 0.0!
            Me.chartControl1.PrimaryXAxis.LineType.Width = 0.0!
            Me.chartControl1.Size = New System.Drawing.Size(400, 359)
            Me.chartControl1.TabIndex = 4
            Me.chartControl1.Text = "Essential Chart-Stacked 100% Chart"
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Essential Chart-Stacked 100% Chart"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'CheckBox2
            '
            Me.CheckBox2.AutoSize = True
            Me.CheckBox2.Location = New System.Drawing.Point(101, 0)
            Me.CheckBox2.Name = "CheckBox2"
            Me.CheckBox2.Size = New System.Drawing.Size(91, 17)
            Me.CheckBox2.TabIndex = 4
            Me.CheckBox2.Text = "Enable Group"
            Me.CheckBox2.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(438, 400)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Stacked 100 Charts"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub

#End Region

#Region "Helper Methods"

#Region "InitializeChartData"

        Protected Sub InitializeChartData()
            Dim series1 As ChartSeries = New ChartSeries("Series1", ChartSeriesType.StackingArea100)
            series1.Points.Add(1, 20)
            series1.Points.Add(2, 30)
            series1.Points.Add(3, 10)
            series1.Points.Add(4, 15)
            series1.Points.Add(5, 25)
            Me.chartControl1.Series.Add(series1)

            Dim series2 As ChartSeries = New ChartSeries("Series2", ChartSeriesType.StackingArea100)
            series2.Points.Add(1, 20)
            series2.Points.Add(2, 10)
            series2.Points.Add(3, 50)
            series2.Points.Add(4, 15)
            series2.Points.Add(5, 5)
            Me.chartControl1.Series.Add(series2)

            Dim series3 As ChartSeries = New ChartSeries("Series3", ChartSeriesType.StackingArea100)
            series3.Points.Add(1, 20)
            series3.Points.Add(2, 40)
            series3.Points.Add(3, 10)
            series3.Points.Add(4, 5)
            series3.Points.Add(5, 20)
            Me.chartControl1.Series.Add(series3)

            Dim series4 As New ChartSeries("Series4", ChartSeriesType.StackingArea100)
            series4.Points.Add(1, 30)
            series4.Points.Add(2, 20)
            series4.Points.Add(3, 15)
            series4.Points.Add(4, 23)
            series4.Points.Add(5, 5)
            Me.chartControl1.Series.Add(series4)
            Me.comboBox1.SelectedIndex = 0
            Me.CheckBox2.Enabled = False
        End Sub

#End Region

#End Region

#Region "Events"
        Private stackedBar As Boolean = False
        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
            Me.chartControl1.Series(0).Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBox1.SelectedItem.ToString(), True), ChartSeriesType)
            Me.chartControl1.Series(1).Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBox1.SelectedItem.ToString(), True), ChartSeriesType)
            Me.chartControl1.Series(2).Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBox1.SelectedItem.ToString(), True), ChartSeriesType)
            Me.chartControl1.Series(3).Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBox1.SelectedItem.ToString(), True), ChartSeriesType)
            Select Case Me.comboBox1.SelectedIndex
                Case 0
                    Me.chartControl1.Titles(0).Text = "100% Stacked Area Chart"
                    Me.CheckBox2.Enabled = False
                    stackedBar = False
                Case 1
                    Me.chartControl1.Titles(0).Text = "100% Stacked Bar Chart"
                    Me.CheckBox2.Enabled = True
                    stackedBar = True
                Case 2
                    Me.chartControl1.Titles(0).Text = "100% Stacked Column Chart"
                    Me.CheckBox2.Enabled = True
                    stackedBar = False
            End Select
        End Sub

        Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
            Me.chartControl1.Series3D = CheckBox1.Checked
        End Sub
        Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
            If CheckBox2.Checked Then
                Me.chartControl1.Series(0).StackingGroup = "First"
                Me.chartControl1.Series(1).StackingGroup = "First"

                Me.chartControl1.Series(2).StackingGroup = "Second"
                Me.chartControl1.Series(3).StackingGroup = "Second"

            Else
                Me.chartControl1.Series(0).StackingGroup = ""
                Me.chartControl1.Series(1).StackingGroup = ""

                Me.chartControl1.Series(2).StackingGroup = ""
                Me.chartControl1.Series(3).StackingGroup = ""

            End If
            Me.chartControl1.Redraw(True)
        End Sub

#Region "Axis Labels"
        Private Sub chartControl1_ChartFormatAxisLabel(ByVal sender As Object, ByVal e As ChartFormatAxisLabelEventArgs) Handles chartControl1.ChartFormatAxisLabel
            If stackedBar = True Then
                If e.AxisOrientation = ChartOrientation.Horizontal Then
                    'Applying Formatted Axis label values.
                    e.Label = String.Format("{0}%", e.Value)
                End If
            Else
                If e.AxisOrientation = ChartOrientation.Vertical Then
                    'Applying Formatted Axis label values.
                    e.Label = String.Format("{0}%", e.Value)
                End If
            End If
            e.Handled = True
        End Sub
#End Region
#End Region

       
    End Class
End Namespace
