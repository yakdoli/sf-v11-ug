#Region "Copyright Syncfusion Inc. 2001 - 2005"
'
'  Copyright Syncfusion Inc. 2001 - 2005. All rights reserved.
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
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports System.Drawing.Drawing2D

Namespace Syncfusion.Windows.Forms.Chart.Samples
    Public Class Form1 : Inherits Office2007Form

#Region " Private Members "

        Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private label1 As System.Windows.Forms.Label
        Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
        Private label2 As System.Windows.Forms.Label
        Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
        Private label3 As System.Windows.Forms.Label
        Private WithEvents comboBox3 As System.Windows.Forms.ComboBox
        Private panel1 As System.Windows.Forms.Panel
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Private color1 As Color() = New Color() {Color.FromArgb(150, 141, 100, 170), Color.FromArgb(150, 200, 170, 222), Color.FromArgb(150, 141, 100, 170)}
        Private color2 As Color() = New Color() {Color.FromArgb(180, 223, 111, 39), Color.FromArgb(180, 251, 169, 113), Color.FromArgb(180, 223, 111, 39)}
        Private color3 As Color() = New Color() {Color.FromArgb(150, 0, 128, 192), Color.FromArgb(150, 98, 203, 255), Color.FromArgb(150, 0, 128, 192)}
        Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
        Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
        Private color4 As Color() = New Color() {Color.FromArgb(150, 196, 0, 0), Color.FromArgb(150, 255, 145, 145), Color.FromArgb(150, 196, 0, 0)}


#End Region

#Region " Constructor, Main And Dispose "
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            '
            ' TODO: Add any constructor code after InitializeComponent call
            ''
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
            Me.label1 = New System.Windows.Forms.Label
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label2 = New System.Windows.Forms.Label
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.label3 = New System.Windows.Forms.Label
            Me.comboBox3 = New System.Windows.Forms.ComboBox
            Me.panel1 = New System.Windows.Forms.Panel
            Me.CheckBox2 = New System.Windows.Forms.CheckBox
            Me.CheckBox1 = New System.Windows.Forms.CheckBox
            Me.checkBox3 = New System.Windows.Forms.CheckBox
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(1, 1, 1, 1)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(200, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(167, Byte), Integer)))
            Me.chartControl1.ElementsSpacing = 0
            Me.chartControl1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            '
            '
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.Legend.ItemsSize = New System.Drawing.Size(15, 15)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(32, 36)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.Legend.Spacing = 3
            Me.chartControl1.Location = New System.Drawing.Point(9, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.PrimaryYAxis.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.Size = New System.Drawing.Size(424, 350)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "chartControl1"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(16, 32)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(59, 13)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Chart Type"
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox1.Items.AddRange(New Object() {"Polar", "Radar"})
            Me.comboBox1.Location = New System.Drawing.Point(16, 56)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(121, 21)
            Me.comboBox1.TabIndex = 2
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label2.Location = New System.Drawing.Point(16, 184)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(112, 13)
            Me.label2.TabIndex = 9
            Me.label2.Text = "Radar Chart Axis Style"
            '
            'comboBox2
            '
            Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox2.Location = New System.Drawing.Point(16, 208)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(121, 21)
            Me.comboBox2.TabIndex = 8
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label3.Location = New System.Drawing.Point(16, 104)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(87, 13)
            Me.label3.TabIndex = 7
            Me.label3.Text = "Chart Draw Type"
            '
            'comboBox3
            '
            Me.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox3.Location = New System.Drawing.Point(16, 128)
            Me.comboBox3.Name = "comboBox3"
            Me.comboBox3.Size = New System.Drawing.Size(121, 21)
            Me.comboBox3.TabIndex = 6
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.panel1.Controls.Add(Me.checkBox3)
            Me.panel1.Controls.Add(Me.CheckBox2)
            Me.panel1.Controls.Add(Me.CheckBox1)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.comboBox3)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.comboBox2)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(442, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(152, 374)
            Me.panel1.TabIndex = 10
            '
            'CheckBox2
            '
            Me.CheckBox2.AutoSize = True
            Me.CheckBox2.Location = New System.Drawing.Point(16, 298)
            Me.CheckBox2.Name = "CheckBox2"
            Me.CheckBox2.Size = New System.Drawing.Size(99, 17)
            Me.CheckBox2.TabIndex = 11
            Me.CheckBox2.Text = "Y-Axis Inversed"
            Me.CheckBox2.UseVisualStyleBackColor = True
            '
            'CheckBox1
            '
            Me.CheckBox1.AutoSize = True
            Me.CheckBox1.Location = New System.Drawing.Point(16, 261)
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Size = New System.Drawing.Size(99, 17)
            Me.CheckBox1.TabIndex = 10
            Me.CheckBox1.Text = "X-Axis Inversed"
            Me.CheckBox1.UseVisualStyleBackColor = True
            '
            'checkBox3
            '
            Me.checkBox3.AutoSize = True
            Me.checkBox3.Location = New System.Drawing.Point(16, 328)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(108, 17)
            Me.checkBox3.TabIndex = 13
            Me.checkBox3.Text = "Enable Line Style"
            Me.checkBox3.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(594, 374)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.chartControl1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Polar and Radar Charts"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region " Form Load "
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            FillControlPanel()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
            Me.comboBox2.Enabled = False
            InitializeChartData()
            Me.comboBox3.SelectedIndex = 0
            Me.comboBox1.SelectedIndex = 0
            Me.comboBox2.SelectedIndex = 0
        End Sub
#End Region

#Region "Helper Methor"

#Region " InitializeChartData for Polar Chart "
        ''' <summary>
        ''' Initializes the ChartControl's data and sets the Chart type
        ''' </summary>
        Protected Sub InitializeChartData()
            Dim series1 As ChartSeries = New ChartSeries(" System 1", ChartSeriesType.Polar)
            series1.Text = series1.Name
            For i As Integer = 0 To 710
                Dim x As Double = Math.Abs(Math.Sin(3 * i))
                series1.Points.Add(i, x)
            Next i
            Me.chartControl1.Series.Add(series1)

            Dim series2 As ChartSeries = New ChartSeries(" System 1", ChartSeriesType.Polar)
            series2.Text = series2.Name
            For i As Integer = 0 To 354
                Dim x As Double = Math.Abs(Math.Sin(3 * i))
                series2.Points.Add(i, x)
            Next i
            Me.chartControl1.Series.Add(series2)
            Me.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
            Me.chartControl1.PrimaryYAxis.Range = New MinMaxInfo(0, 1.5, 0.5)
            Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
            Me.chartControl1.PrimaryXAxis.Range = New MinMaxInfo(0, 360, 45)

            Me.chartControl1.Text = "ABS(Sin(3f))"
            Me.chartControl1.Series(0).Style.Border.Color = Color.FromArgb(253, 171, 0)
            Me.chartControl1.Series(1).Style.Border.Color = Color.FromArgb(199, 23, 33)
            RemoveHandler chartControl1.ChartFormatAxisLabel, AddressOf OnChartControl1_ChartFormatAxisLabel
            Me.chartControl1.PrimaryXAxis.Inversed = Me.CheckBox1.Checked
            Me.chartControl1.PrimaryYAxis.Inversed = Me.CheckBox2.Checked
        End Sub
#End Region

#Region "InitializeChartData for Radar Chart"
        Private labels As String() = New String() {"Sales", "Administration", "Information " & Constants.vbLf & "Technology", "Customer" & Constants.vbLf & " Support", "Development", "Marketing"}
        Protected Sub InitializeChartData1()
            Dim series1 As ChartSeries = New ChartSeries(" Allocated Budget", ChartSeriesType.Radar)
            series1.Text = series1.Name
            series1.Points.Add(0, 40)
            series1.Points.Add(1, 20)
            series1.Points.Add(2, 33)
            series1.Points.Add(3, 25)
            series1.Points.Add(4, 60)
            series1.Points.Add(5, 20)
            series1.Style.Interior = New BrushInfo(GradientStyle.Horizontal, color3)
            series1.Style.Border.Color = Color.FromArgb(0, 128, 192)

            Dim series2 As ChartSeries = New ChartSeries("Actual Spending", ChartSeriesType.Radar)
            series2.Text = series2.Name
            series2.Points.Add(0, 50)
            series2.Points.Add(1, 22)
            series2.Points.Add(2, 25)
            series2.Points.Add(3, 20)
            series2.Points.Add(4, 20)
            series2.Points.Add(5, 45)
            series2.Style.Interior = New BrushInfo(GradientStyle.Horizontal, color4)
            series2.Style.Border.Color = Color.FromArgb(209, 0, 0)
            Me.chartControl1.Series.Add(series1)
            Me.chartControl1.Series.Add(series2)

            Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
            Me.chartControl1.PrimaryXAxis.Range = New MinMaxInfo(0, 6, 1)
            Me.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
            Me.chartControl1.PrimaryYAxis.Range = New MinMaxInfo(0, 60, 10)
            Me.chartControl1.Text = "Organization Budget"
            AddHandler chartControl1.ChartFormatAxisLabel, AddressOf OnChartControl1_ChartFormatAxisLabel
            Me.chartControl1.PrimaryXAxis.Inversed = Me.CheckBox1.Checked
            Me.chartControl1.PrimaryYAxis.Inversed = Me.CheckBox2.Checked
        End Sub

        Private Sub OnChartControl1_ChartFormatAxisLabel(ByVal sender As Object, ByVal e As ChartFormatAxisLabelEventArgs)
            If e.AxisOrientation = ChartOrientation.Vertical Then
                'Applying Formatted Y Axis label values.
                e.Label = String.Format("${0}", e.Value)
            Else
                Dim index As Integer = CInt(Fix(e.Value))

                If index >= 0 AndAlso index < labels.Length Then
                    'Applying custom label text for X Axis
                    e.Label = labels(index)
                Else
                    e.Label = ""
                End If
            End If

            e.Handled = True
        End Sub
#End Region

#Region " FillControlPanel "
        Protected Sub FillControlPanel()
            For Each radardrawtype As String In System.Enum.GetNames(GetType(Syncfusion.Windows.Forms.Chart.ChartRadarDrawType))
                'if(radardrawtype != "Symbol")
                Me.comboBox3.Items.Add(radardrawtype)
            Next radardrawtype

            For Each radaraxisstyle As String In System.Enum.GetNames(GetType(Syncfusion.Windows.Forms.Chart.ChartRadarAxisStyle))
                Me.comboBox2.Items.Add(radaraxisstyle)
            Next radaraxisstyle

        End Sub

#End Region

#End Region

#Region " Events "
        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
            If comboBox1.SelectedItem.ToString() = "Radar" Then
                Me.chartControl1.Series.Clear()
                InitializeChartData1()
                Me.comboBox2.Enabled = True
                SelectDrawMode()
            Else
                Me.chartControl1.Series.Clear()
                InitializeChartData()
                Me.comboBox2.Enabled = False
                SelectDrawMode()
            End If
        End Sub
        Private Sub SelectDrawMode()
            If comboBox3.SelectedIndex = 2 Then

                Me.chartControl1.Series(0).Style.Symbol.Size = New Size(5, 5)
                Me.chartControl1.Series(1).Style.Symbol.Size = New Size(5, 5)

            End If


            Me.chartControl1.Series(0).ConfigItems.RadarItem.Type = CType(System.Enum.Parse(GetType(ChartRadarDrawType), Me.comboBox3.SelectedItem.ToString(), True), ChartRadarDrawType)
            Me.chartControl1.Series(1).ConfigItems.RadarItem.Type = CType(System.Enum.Parse(GetType(ChartRadarDrawType), Me.comboBox3.SelectedItem.ToString(), True), ChartRadarDrawType)

        End Sub

        Private Sub comboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox3.SelectedIndexChanged

            If comboBox3.SelectedIndex = 2 Then

                Me.chartControl1.Series(0).Style.Symbol.Size = New Size(5, 5)
                Me.chartControl1.Series(1).Style.Symbol.Size = New Size(5, 5)

            End If

            Me.chartControl1.Series(0).ConfigItems.RadarItem.Type = CType(System.Enum.Parse(GetType(ChartRadarDrawType), Me.comboBox3.SelectedItem.ToString(), True), ChartRadarDrawType)
            Me.chartControl1.Series(1).ConfigItems.RadarItem.Type = CType(System.Enum.Parse(GetType(ChartRadarDrawType), Me.comboBox3.SelectedItem.ToString(), True), ChartRadarDrawType)
        End Sub

        Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox2.SelectedIndexChanged
            Me.chartControl1.RadarStyle = CType(System.Enum.Parse(GetType(ChartRadarAxisStyle), Me.comboBox2.SelectedItem.ToString(), True), ChartRadarAxisStyle)
            Me.chartControl1.Redraw(True)
        End Sub

#End Region

        Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
            Me.chartControl1.PrimaryXAxis.Inversed = Me.CheckBox1.Checked
        End Sub

        Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
            Me.chartControl1.PrimaryYAxis.Inversed = Me.CheckBox2.Checked
        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
            If checkBox3.Checked Then
                Dim mypens(2) As Pen
                mypens(0) = New Pen(Color.DarkOrange, 2.0F)
                mypens(1) = New Pen(Color.DarkGoldenrod, 2.0F)
                mypens(2) = New Pen(Color.Maroon, 2.0F)

                mypens(0).DashStyle = DashStyle.DashDot
                mypens(1).DashStyle = DashStyle.Dash

                Me.chartControl1.PrimaryXAxis.Pens = mypens
                Me.chartControl1.PrimaryYAxis.Pens = mypens

                Me.chartControl1.PrimaryXAxis.LineType.Pen.Color = Color.SkyBlue
                Me.chartControl1.PrimaryXAxis.LineType.Pen.Width = 2.0F
                Me.chartControl1.PrimaryXAxis.LineType.Pen.DashStyle = DashStyle.DashDotDot

                Me.chartControl1.PrimaryYAxis.LineType.Pen.Color = Color.Coral
                Me.chartControl1.PrimaryYAxis.LineType.Pen.Width = 2.0F
                Me.chartControl1.PrimaryYAxis.LineType.Pen.DashStyle = DashStyle.Solid
                Me.chartControl1.Redraw(True)
            Else
                Me.chartControl1.PrimaryXAxis.Pens = Nothing
                Me.chartControl1.PrimaryYAxis.Pens = Nothing

                Me.chartControl1.PrimaryXAxis.LineType.Pen.Color = Color.DarkGray
                Me.chartControl1.PrimaryXAxis.LineType.Pen.Width = 1.0F
                Me.chartControl1.PrimaryXAxis.LineType.Pen.DashStyle = DashStyle.Solid
                Me.chartControl1.PrimaryYAxis.LineType.Pen.Color = Color.DarkGray
                Me.chartControl1.PrimaryYAxis.LineType.Pen.Width = 1.0F
                Me.chartControl1.PrimaryYAxis.LineType.Pen.DashStyle = DashStyle.Solid
            End If
        End Sub
    End Class
End Namespace
