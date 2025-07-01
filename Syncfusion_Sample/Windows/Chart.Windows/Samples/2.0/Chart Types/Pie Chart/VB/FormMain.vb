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
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Chart

Namespace Syncfusion.Windows.Forms.Chart.Samples
    Public Class FormMain
        Inherits Office2007Form
#Region "Private Members"
        Private panel1 As System.Windows.Forms.Panel
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
        Private label1 As System.Windows.Forms.Label
        Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
        Friend WithEvents NumericUpDown2 As NumericUpDown
        Friend Label3 As Label
        Friend WithEvents NumericUpDown1 As NumericUpDown
        Friend Label2 As Label
        Private components As System.ComponentModel.Container = Nothing
        Private color1 As Color() = New Color() {Color.FromArgb(136, 197, 242), Color.FromArgb(139, 202, 245), Color.FromArgb(115, 161, 194)}
        Private color2 As Color() = New Color() {Color.FromArgb(187, 158, 212), Color.FromArgb(194, 165, 223), Color.FromArgb(165, 139, 186)}
        Private color3 As Color() = New Color() {Color.FromArgb(189, 224, 94), Color.FromArgb(191, 227, 93), Color.FromArgb(160, 188, 77)}
        Private color4 As Color() = New Color() {Color.FromArgb(241, 153, 103), Color.FromArgb(242, 154, 104), Color.FromArgb(206, 133, 90)}
        Private color5 As Color() = New Color() {Color.FromArgb(139, 86, 49), Color.FromArgb(244, 188, 147), Color.FromArgb(139, 86, 49)}
        Private color6 As Color() = New Color() {Color.FromArgb(169, 171, 149), Color.FromArgb(181, 183, 161), Color.FromArgb(154, 156, 135)}
        Private color7 As Color() = New Color() {Color.FromArgb(204, 96, 134), Color.FromArgb(249, 174, 200), Color.FromArgb(204, 96, 134)}

        Private WithEvents chartControl1 As ChartControl
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Private WithEvents checkBox4 As CheckBox


#End Region

#Region "Main, Constructor and Dispose"
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New FormMain())
        End Sub

        Public Sub New()
            InitializeComponent()

        End Sub

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
            Me.panel1 = New System.Windows.Forms.Panel
            Me.Button1 = New System.Windows.Forms.Button
            Me.checkBox4 = New System.Windows.Forms.CheckBox
            Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
            Me.Label3 = New System.Windows.Forms.Label
            Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.Label2 = New System.Windows.Forms.Label
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label1 = New System.Windows.Forms.Label
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.checkBox3 = New System.Windows.Forms.CheckBox
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel1.SuspendLayout()
            CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.panel1.Controls.Add(Me.Button1)
            Me.panel1.Controls.Add(Me.checkBox4)
            Me.panel1.Controls.Add(Me.NumericUpDown2)
            Me.panel1.Controls.Add(Me.Label3)
            Me.panel1.Controls.Add(Me.NumericUpDown1)
            Me.panel1.Controls.Add(Me.Label2)
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.checkBox2)
            Me.panel1.Controls.Add(Me.checkBox1)
            Me.panel1.Controls.Add(Me.checkBox3)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(505, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(143, 404)
            Me.panel1.TabIndex = 3
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(12, 346)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(118, 37)
            Me.Button1.TabIndex = 16
            Me.Button1.Text = "Rotate Pie by 5 degrees"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'checkBox4
            '
            Me.checkBox4.AutoSize = True
            Me.checkBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.checkBox4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.checkBox4.Location = New System.Drawing.Point(14, 12)
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(68, 18)
            Me.checkBox4.TabIndex = 15
            Me.checkBox4.Text = "3D View"
            Me.checkBox4.UseVisualStyleBackColor = True
            '
            'NumericUpDown2
            '
            Me.NumericUpDown2.DecimalPlaces = 1
            Me.NumericUpDown2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.NumericUpDown2.Location = New System.Drawing.Point(9, 303)
            Me.NumericUpDown2.Maximum = New Decimal(New Integer() {5, 0, 0, 65536})
            Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.NumericUpDown2.Name = "NumericUpDown2"
            Me.NumericUpDown2.Size = New System.Drawing.Size(123, 20)
            Me.NumericUpDown2.TabIndex = 14
            Me.NumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 65536})
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(9, 284)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(91, 13)
            Me.Label3.TabIndex = 13
            Me.Label3.Text = "Height Coefficient"
            '
            'NumericUpDown1
            '
            Me.NumericUpDown1.DecimalPlaces = 1
            Me.NumericUpDown1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.NumericUpDown1.Location = New System.Drawing.Point(9, 245)
            Me.NumericUpDown1.Maximum = New Decimal(New Integer() {9, 0, 0, 65536})
            Me.NumericUpDown1.Name = "NumericUpDown1"
            Me.NumericUpDown1.Size = New System.Drawing.Size(123, 20)
            Me.NumericUpDown1.TabIndex = 12
            Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 65536})
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(9, 229)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(106, 13)
            Me.Label2.TabIndex = 11
            Me.Label2.Text = "Doughnut coefficient"
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox1.Location = New System.Drawing.Point(9, 189)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(123, 21)
            Me.comboBox1.TabIndex = 6
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(9, 165)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(123, 23)
            Me.label1.TabIndex = 5
            Me.label1.Text = "Pie Type"
            '
            'checkBox2
            '
            Me.checkBox2.Checked = True
            Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox2.Location = New System.Drawing.Point(14, 39)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(104, 24)
            Me.checkBox2.TabIndex = 1
            Me.checkBox2.Text = "Show Ticks"
            '
            'checkBox1
            '
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox1.Location = New System.Drawing.Point(14, 105)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(104, 40)
            Me.checkBox1.TabIndex = 0
            Me.checkBox1.Text = "Optimize positions for small values"
            '
            'checkBox3
            '
            Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox3.Location = New System.Drawing.Point(14, 72)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(104, 24)
            Me.checkBox3.TabIndex = 4
            Me.checkBox3.Text = "Explode All"
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(193, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(226, Byte), Integer)))
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ElementsSpacing = 0
            Me.chartControl1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            '
            '
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent
            Me.chartControl1.Legend.Location = New System.Drawing.Point(393, 45)
            Me.chartControl1.Location = New System.Drawing.Point(11, 10)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Pastel
            Me.chartControl1.Size = New System.Drawing.Size(482, 383)
            Me.chartControl1.TabIndex = 4
            Me.chartControl1.Text = "Essential Chart"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Essential Chart"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'FormMain
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(648, 404)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormMain"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Pie Charts"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"
        Private Sub FormMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitializeChartData()
            FillcontrolPanel()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)

        End Sub
#End Region

#Region "Helper Methods"
#Region "InitializeChartData"
        ''' <summary>
        ''' Initializes the ChartControl's data and sets the Chart type
        ''' </summary>
        Protected Sub InitializeChartData()
            Dim random As Random = New Random()

            Dim series1 As ChartSeries = New ChartSeries("Market")
            series1.Points.Add(0, 20)
            series1.Points.Add(1, 28)
            series1.Points.Add(2, 23)
            series1.Points.Add(3, 10)
            series1.Points.Add(4, 12)
            series1.Points.Add(5, 3)
            series1.Points.Add(6, 2)
            series1.OptimizePiePointPositions = Me.checkBox1.Checked
            series1.Type = ChartSeriesType.Pie
            Me.chartControl1.Series.Add(series1)

            For i As Integer = 0 To series1.Points.Count - 1
                series1.Styles(i).Border.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
            Next i

            series1.Styles(0).Text = String.Format("Production {0}%", series1.Points(0).YValues(0))
            series1.Styles(1).Text = String.Format("Labor {0}%", series1.Points(1).YValues(0))
            series1.Styles(2).Text = String.Format("Facilities {0}%", series1.Points(2).YValues(0))
            series1.Styles(3).Text = String.Format("Taxes {0}%", series1.Points(3).YValues(0))
            series1.Styles(4).Text = String.Format("Insurance{0}%", series1.Points(4).YValues(0))
            series1.Styles(5).Text = String.Format("Licenses {0}%", series1.Points(5).YValues(0))
            series1.Styles(6).Text = String.Format("Legal {0}%", series1.Points(6).YValues(0))
            series1.Style.DisplayText = True
            series1.Style.Font.Size = 8.0F
            series1.ConfigItems.PieItem.AngleOffset = 60
            Me.chartControl1.Series(0).ShowTicks = Me.checkBox2.Checked
            series1.ConfigItems.PieItem.LabelStyle = ChartAccumulationLabelStyle.OutsideInColumn
            series1.ConfigItems.PieItem.AngleOffset = 50
        End Sub
#End Region
        Private Sub FillcontrolPanel()
            For Each connect As String In System.Enum.GetNames(GetType(Syncfusion.Windows.Forms.Chart.ChartPieType))
                Me.comboBox1.Items.Add(connect)
            Next connect
            Me.comboBox1.SelectedIndex = 0
        End Sub
#End Region

#Region "Events"
        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            Me.chartControl1.Series(0).OptimizePiePointPositions = Me.checkBox1.Checked
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
            If Me.checkBox2.Checked Then
                Me.chartControl1.Series(0).ShowTicks = True
            Else
                Me.chartControl1.Series(0).ShowTicks = False
            End If
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
            If Me.checkBox3.Checked Then
                Me.chartControl1.Series(0).ExplodedAll = True
                Me.chartControl1.Series(0).ExplosionOffset = 8.0F
            Else
                Me.chartControl1.Series(0).ExplodedAll = False
                Me.chartControl1.Series(0).ExplosionOffset = 20.0F
            End If
        End Sub

        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
            Me.chartControl1.Series(0).ConfigItems.PieItem.PieType = CType(System.Enum.Parse(GetType(ChartPieType), Me.comboBox1.SelectedItem.ToString(), True), ChartPieType)
        End Sub

        Private Sub NumericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles NumericUpDown1.ValueChanged
            Me.chartControl1.Series(0).ConfigItems.PieItem.DoughnutCoeficient = CSng(NumericUpDown1.Value)
        End Sub

        Private Sub NumericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles NumericUpDown2.ValueChanged
            Me.chartControl1.Series(0).ConfigItems.PieItem.HeightCoeficient = CSng(NumericUpDown2.Value)

        End Sub

        Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox4.CheckedChanged
            Me.chartControl1.Series3D = Me.checkBox4.Checked
        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
            Me.chartControl1.Series(0).ConfigItems.PieItem.AngleOffset += 5
        End Sub

        Private Sub chartControl1_Legend_FilterItems(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartLegendFilterItemsEventArgs) Handles chartControl1.Legend.FilterItems
            Dim series As ChartSeries = Me.chartControl1.Series(0)
            For i As Integer = 0 To series.Points.Count - 1
                e.Items(i).Text = series.Points(i).YValues(0).ToString() & "%"
            Next i
        End Sub
#End Region
    End Class
End Namespace
