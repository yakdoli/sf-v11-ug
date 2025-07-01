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

Namespace CombinationCharts
    Public Class Form1
        Inherits Office2007Form

#Region "Private Members"

        Private panel1 As System.Windows.Forms.Panel

        Private line As ChartStripLine = New ChartStripLine()

        Private secaxis As ChartAxis = New ChartAxis()

        Private currentRegion As ChartRegion = Nothing

        Private WithEvents checkBox_3D As System.Windows.Forms.CheckBox
        Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

#End Region

#Region "Constructor, Main And Dispose"
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.checkBox_3D = New System.Windows.Forms.CheckBox
            Me.panel1 = New System.Windows.Forms.Panel
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'checkBox_3D
            '
            Me.checkBox_3D.Dock = System.Windows.Forms.DockStyle.Right
            Me.checkBox_3D.Location = New System.Drawing.Point(569, 0)
            Me.checkBox_3D.Name = "checkBox_3D"
            Me.checkBox_3D.Size = New System.Drawing.Size(77, 28)
            Me.checkBox_3D.TabIndex = 2
            Me.checkBox_3D.Text = "3D View"
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.checkBox_3D)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 363)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(646, 28)
            Me.panel1.TabIndex = 2
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartArea.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(206, Byte), Integer))
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(5, 5, 5, 5)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer)))
            Me.chartControl1.ElementsSpacing = 0
            Me.chartControl1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.ForeColor = System.Drawing.SystemColors.ControlText
            '
            '
            '
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.Legend.ItemsSize = New System.Drawing.Size(15, 15)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(39, 65)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.Legend.ShowBorder = True
            Me.chartControl1.Location = New System.Drawing.Point(14, 13)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Pastel
            Me.chartControl1.PrimaryXAxis.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.SystemColors.ControlText
            Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.Transparent
            Me.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.DarkGray
            Me.chartControl1.PrimaryYAxis.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.SystemColors.ControlText
            Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.Transparent
            Me.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.DarkGray
            Me.chartControl1.Series3D = True
            Me.chartControl1.Size = New System.Drawing.Size(620, 341)
            Me.chartControl1.TabIndex = 3
            Me.chartControl1.Text = "Combination Chart "
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Combination Chart "
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ToolBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.chartControl1.ToolBar.ButtonBackColor = System.Drawing.SystemColors.ControlLight
            Me.chartControl1.ToolBar.ButtonForeColor = System.Drawing.SystemColors.ActiveBorder
            Me.chartControl1.ToolBar.ButtonSize = New System.Drawing.Size(26, 26)
            Me.chartControl1.ZoomOutIncrement = 1.5
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(646, 391)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Combination Chart"
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.chartControl1.Series.Clear()
            InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region "Helper Methods"

#Region "InitializeChartData"
        Protected Sub InitializeChartData()
            Me.secaxis.Labels.Clear()

            For i As Integer = 0 To 2
                Dim Combination As ChartSeries = New ChartSeries("Gold")
                If i = 0 Then
                    Combination.Text = "Bronze"
                    Combination.Points.Add(1, 36)
                    Combination.Points.Add(2, 28)
                    Combination.Points.Add(3, 28)
                    Combination.Points.Add(4, 15)
                    Combination.Points.Add(5, 15)
                    Combination.Points.Add(6, 17)
                    Combination.Type = ChartSeriesType.Spline
                ElseIf i = 1 Then
                    Combination.Text = "Silver"
                    Combination.Points.Add(1, 38)
                    Combination.Points.Add(2, 21)
                    Combination.Points.Add(3, 21)
                    Combination.Points.Add(4, 13)
                    Combination.Points.Add(5, 10)
                    Combination.Points.Add(6, 15)
                    Combination.Type = ChartSeriesType.Line
                Else
                    Combination.Points.Add(1, 36)
                    Combination.Points.Add(2, 51)
                    Combination.Points.Add(3, 23)
                    Combination.Points.Add(4, 19)
                    Combination.Points.Add(5, 16)
                    Combination.Points.Add(6, 14)
                    Combination.Type = ChartSeriesType.Column

                End If
                Me.chartControl1.Series.Add(Combination)
            Next i
            Me.chartControl1.PrimaryYAxis.Range = New MinMaxInfo(0, 60, 10)
            Me.chartControl1.Rotation = 60
            Me.chartControl1.Series3D = False
            Me.checkBox_3D.Checked = False
        End Sub

#End Region

#End Region

#Region "Events"

        Private Sub checkBox_3D_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox_3D.CheckedChanged
            Me.chartControl1.Series3D = Me.checkBox_3D.Checked
            If checkBox_3D.Checked Then
                Me.chartControl1.Series(2).Style.Border.Color = Color.FromArgb(253, 171, 0)
            Else
                Me.chartControl1.Series(0).Style.Border.Color = Color.Transparent
            End If
        End Sub
        Private Sub chartControl1_ChartFormatAxisLabel(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventArgs) Handles chartControl1.ChartFormatAxisLabel
            If e.AxisOrientation = ChartOrientation.Horizontal Then
                If e.Value = 1 Then
                    e.Label = "USA"
                ElseIf e.Value = 2 Then
                    e.Label = "China"
                ElseIf e.Value = 3 Then
                    e.Label = "Russia"
                ElseIf e.Value = 4 Then
                    e.Label = "Great Britian"
                ElseIf e.Value = 5 Then
                    e.Label = "Germany"
                ElseIf e.Value = 6 Then
                    e.Label = "Australia"
                Else
                    e.Label = ""
                End If
                e.Handled = True
            End If
        End Sub

        Private Sub chartControl1_Legend_FilterItems(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartLegendFilterItemsEventArgs) Handles chartControl1.Legend.FilterItems
            Dim items As ChartLegendItemsCollection = New ChartLegendItemsCollection()
            For i As Integer = e.Items.Count - 1 To 0 Step -1
                items.Add(e.Items(i))
            Next i
            e.Items = items
        End Sub
#End Region
    End Class
End Namespace