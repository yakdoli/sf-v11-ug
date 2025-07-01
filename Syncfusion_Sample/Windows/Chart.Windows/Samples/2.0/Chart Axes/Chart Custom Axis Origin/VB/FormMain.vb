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

    Public Class FormMain : Inherits Office2007Form
#Region "Private Members"
        Private components As System.ComponentModel.IContainer
        Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private panel1 As System.Windows.Forms.Panel
        Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
        Private label1 As System.Windows.Forms.Label
        Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox4 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox5 As System.Windows.Forms.CheckBox
        Private WithEvents Label5 As System.Windows.Forms.Label
        Private WithEvents Label3 As System.Windows.Forms.Label
        Private WithEvents Label4 As System.Windows.Forms.Label
        Private WithEvents Label2 As System.Windows.Forms.Label
        Private WithEvents label9 As System.Windows.Forms.Label
        Private WithEvents label11 As System.Windows.Forms.Label
        Private WithEvents UpDown_Origin As System.Windows.Forms.NumericUpDown
        Private WithEvents label10 As System.Windows.Forms.Label
        Private WithEvents CB_DateInterval As System.Windows.Forms.ComboBox
        Private WithEvents label8 As System.Windows.Forms.Label
        Private WithEvents CB_Origin As System.Windows.Forms.ComboBox
        Private WithEvents label7 As System.Windows.Forms.Label
        Private WithEvents CB_axis As System.Windows.Forms.ComboBox
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
#End Region

#Region "Constructor, Main and Dispose"
        Public Sub New()
            '
            ' Required for Windows Form Designer support.
            '
            InitializeComponent()


        End Sub
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New FormMain())
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
        ''' Required method for Designer support; do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel1 = New System.Windows.Forms.Panel
            Me.UpDown_Origin = New System.Windows.Forms.NumericUpDown
            Me.label10 = New System.Windows.Forms.Label
            Me.CB_DateInterval = New System.Windows.Forms.ComboBox
            Me.label8 = New System.Windows.Forms.Label
            Me.CB_Origin = New System.Windows.Forms.ComboBox
            Me.label7 = New System.Windows.Forms.Label
            Me.CB_axis = New System.Windows.Forms.ComboBox
            Me.label11 = New System.Windows.Forms.Label
            Me.checkBox4 = New System.Windows.Forms.CheckBox
            Me.Label5 = New System.Windows.Forms.Label
            Me.checkBox5 = New System.Windows.Forms.CheckBox
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.Label3 = New System.Windows.Forms.Label
            Me.checkBox3 = New System.Windows.Forms.CheckBox
            Me.Label4 = New System.Windows.Forms.Label
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.label1 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label9 = New System.Windows.Forms.Label
            Me.panel1.SuspendLayout()
            CType(Me.UpDown_Origin, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer)))
            Me.chartControl1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(354, 70)
            Me.chartControl1.Location = New System.Drawing.Point(14, 13)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.Size = New System.Drawing.Size(485, 412)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "Chart Custom Axis Origin"
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Chart Custom Axis Origin"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ZoomOutIncrement = 1.5
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.UpDown_Origin)
            Me.panel1.Controls.Add(Me.label10)
            Me.panel1.Controls.Add(Me.CB_DateInterval)
            Me.panel1.Controls.Add(Me.label8)
            Me.panel1.Controls.Add(Me.CB_Origin)
            Me.panel1.Controls.Add(Me.label7)
            Me.panel1.Controls.Add(Me.CB_axis)
            Me.panel1.Controls.Add(Me.label11)
            Me.panel1.Controls.Add(Me.checkBox4)
            Me.panel1.Controls.Add(Me.Label5)
            Me.panel1.Controls.Add(Me.checkBox5)
            Me.panel1.Controls.Add(Me.checkBox2)
            Me.panel1.Controls.Add(Me.Label3)
            Me.panel1.Controls.Add(Me.checkBox3)
            Me.panel1.Controls.Add(Me.Label4)
            Me.panel1.Controls.Add(Me.checkBox1)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.Label2)
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Controls.Add(Me.label9)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(512, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(152, 436)
            Me.panel1.TabIndex = 1
            '
            'UpDown_Origin
            '
            Me.UpDown_Origin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UpDown_Origin.BackColor = System.Drawing.Color.White
            Me.UpDown_Origin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.UpDown_Origin.Location = New System.Drawing.Point(81, 236)
            Me.UpDown_Origin.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
            Me.UpDown_Origin.Name = "UpDown_Origin"
            Me.UpDown_Origin.ReadOnly = True
            Me.UpDown_Origin.Size = New System.Drawing.Size(48, 20)
            Me.UpDown_Origin.TabIndex = 30
            '
            'label10
            '
            Me.label10.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label10.Location = New System.Drawing.Point(14, 131)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(104, 16)
            Me.label10.TabIndex = 29
            Me.label10.Text = "Origin Customization"
            '
            'CB_DateInterval
            '
            Me.CB_DateInterval.Cursor = System.Windows.Forms.Cursors.Hand
            Me.CB_DateInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CB_DateInterval.ForeColor = System.Drawing.Color.MidnightBlue
            Me.CB_DateInterval.Items.AddRange(New Object() {"Auto", "Days", "Hours", "Milliseconds", "Minutes", "Months", "Seconds", "Weeks", "Years"})
            Me.CB_DateInterval.Location = New System.Drawing.Point(14, 209)
            Me.CB_DateInterval.Name = "CB_DateInterval"
            Me.CB_DateInterval.Size = New System.Drawing.Size(121, 21)
            Me.CB_DateInterval.TabIndex = 28
            '
            'label8
            '
            Me.label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label8.AutoSize = True
            Me.label8.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label8.Location = New System.Drawing.Point(14, 238)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(34, 13)
            Me.label8.TabIndex = 27
            Me.label8.Text = "Value"
            '
            'CB_Origin
            '
            Me.CB_Origin.Cursor = System.Windows.Forms.Cursors.Hand
            Me.CB_Origin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CB_Origin.ForeColor = System.Drawing.Color.MidnightBlue
            Me.CB_Origin.Location = New System.Drawing.Point(17, 209)
            Me.CB_Origin.Name = "CB_Origin"
            Me.CB_Origin.Size = New System.Drawing.Size(121, 21)
            Me.CB_Origin.TabIndex = 24
            '
            'label7
            '
            Me.label7.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label7.Location = New System.Drawing.Point(14, 190)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(104, 16)
            Me.label7.TabIndex = 25
            Me.label7.Text = "Range Padding Type:"
            '
            'CB_axis
            '
            Me.CB_axis.Cursor = System.Windows.Forms.Cursors.Hand
            Me.CB_axis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CB_axis.ForeColor = System.Drawing.Color.MidnightBlue
            Me.CB_axis.Items.AddRange(New Object() {"DateTimeOffset", "Offset", "DateTimeInterval", "RangePaddingType"})
            Me.CB_axis.Location = New System.Drawing.Point(14, 155)
            Me.CB_axis.Name = "CB_axis"
            Me.CB_axis.Size = New System.Drawing.Size(121, 21)
            Me.CB_axis.TabIndex = 26
            '
            'label11
            '
            Me.label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label11.Location = New System.Drawing.Point(14, 41)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(130, 1)
            Me.label11.TabIndex = 9
            '
            'checkBox4
            '
            Me.checkBox4.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox4.Location = New System.Drawing.Point(14, 403)
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(104, 24)
            Me.checkBox4.TabIndex = 1
            Me.checkBox4.Text = "Opposed Y-Axis"
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.Label5.Location = New System.Drawing.Point(14, 363)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(130, 1)
            Me.Label5.TabIndex = 8
            '
            'checkBox5
            '
            Me.checkBox5.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox5.Location = New System.Drawing.Point(14, 373)
            Me.checkBox5.Name = "checkBox5"
            Me.checkBox5.Size = New System.Drawing.Size(104, 24)
            Me.checkBox5.TabIndex = 0
            Me.checkBox5.Text = "Opposed X-Axis"
            '
            'checkBox2
            '
            Me.checkBox2.Checked = True
            Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox2.Location = New System.Drawing.Point(14, 286)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(104, 24)
            Me.checkBox2.TabIndex = 4
            Me.checkBox2.Text = "Invert X Axis"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.Label3.Location = New System.Drawing.Point(14, 345)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(88, 14)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Opposed Axes"
            '
            'checkBox3
            '
            Me.checkBox3.Checked = True
            Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox3.Location = New System.Drawing.Point(14, 318)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(104, 24)
            Me.checkBox3.TabIndex = 3
            Me.checkBox3.Text = "Invert Y Axis"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.Label4.Location = New System.Drawing.Point(14, 278)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(130, 1)
            Me.Label4.TabIndex = 7
            '
            'checkBox1
            '
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox1.Location = New System.Drawing.Point(14, 47)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(112, 24)
            Me.checkBox1.TabIndex = 2
            Me.checkBox1.Text = "Show Custom Axis"
            '
            'label1
            '
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label1.Location = New System.Drawing.Point(14, 79)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(104, 16)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Select Average Load"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.Label2.Location = New System.Drawing.Point(14, 264)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(70, 14)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "Invert Axes"
            '
            'comboBox1
            '
            Me.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox1.Location = New System.Drawing.Point(14, 98)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(121, 21)
            Me.comboBox1.TabIndex = 0
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.BackColor = System.Drawing.Color.Transparent
            Me.label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label9.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label9.Location = New System.Drawing.Point(14, 24)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(87, 14)
            Me.label9.TabIndex = 2
            Me.label9.Text = "Custom Origin"
            '
            'FormMain
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(664, 436)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormMain"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Custom Axis Origin"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.UpDown_Origin, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"

        Private Sub FormMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            CB_axis.SelectedIndex = 0
            InitializeChartData()
            FillControlPanel()
            Me.chartControl1.PrimaryXAxis.Inversed = True
            Me.chartControl1.PrimaryYAxis.Inversed = True

            Me.CB_DateInterval.SelectedIndex = 0
            CB_Origin.Items.Add("Calculate")
            CB_Origin.Items.Add("None")
            CB_Origin.SelectedIndex = 0
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region "InitializeChartData"
        ''' <summary>
        ''' Initializes the ChartControl's data and sets the Chart type.
        ''' </summary>
        Protected Sub InitializeChartData()
            Dim start As DateTime = New DateTime(2007, 8, 1)
            Me.chartControl1.Indexed = True
            Dim series1 As ChartSeries = New ChartSeries(" Server 1", ChartSeriesType.Column)
            series1.Text = series1.Name
            series1.Points.Add(start.AddDays(7), 68)
            series1.Points.Add(start.AddDays(8), 65)
            series1.Points.Add(start.AddDays(9), 72)
            series1.Points.Add(start.AddDays(10), 71)
            series1.Points.Add(start.AddDays(11), 73)
            series1.Points.Add(start.AddDays(12), 70)
            series1.Points.Add(start.AddDays(13), 68)
            series1.Points.Add(start.AddDays(14), 72)
            series1.Text = "Server 1"
            Me.chartControl1.LegendPosition = ChartDock.Top
            Me.chartControl1.Series.Add(series1)

            Dim series2 As ChartSeries = New ChartSeries(" Server 2", ChartSeriesType.Column)
            series2.Text = series2.Name
            series2.Points.Add(start.AddDays(7), 65)
            series2.Points.Add(start.AddDays(8), 68)
            series2.Points.Add(start.AddDays(9), 71)
            series2.Points.Add(start.AddDays(10), 72)
            series2.Points.Add(start.AddDays(11), 72)
            series2.Points.Add(start.AddDays(12), 68)
            series2.Points.Add(start.AddDays(13), 70)
            series2.Points.Add(start.AddDays(14), 73)
            series2.Style.Border.DashStyle = DashStyle.Solid
            series2.Style.Font.Bold = True
            Me.chartControl1.Series.Add(series2)

            Me.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate
            Me.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime
            Me.chartControl1.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(start.AddDays(-1), start.AddDays(13), 3, ChartDateTimeIntervalType.Days)
            Me.chartControl1.PrimaryXAxis.DateTimeFormat = "MM/dd,ddd"
        End Sub
#End Region

#Region "Helper Methods"
        Private Sub FillControlPanel()
            Dim i As Integer = 0

            Do While i < Me.chartControl1.Series(0).Points.Count
                Me.comboBox1.Items.Add(Me.chartControl1.Series(0).Points(i).YValues(0))
                i += 1
            Loop
            Me.comboBox1.SelectedIndex = 0
        End Sub



        Protected Sub SetOrigin()
            If Me.checkBox1.Checked Then
                Me.chartControl1.PrimaryYAxis.CustomOrigin = True
                Me.chartControl1.PrimaryYAxis.Origin = CDbl(Me.comboBox1.SelectedItem)
            Else
                Me.chartControl1.PrimaryYAxis.CustomOrigin = False
                Me.chartControl1.PrimaryYAxis.Origin = 0
            End If
            Me.chartControl1.Redraw(True)
        End Sub
        Private Sub SetClear()
            Me.label8.Visible = False
            Me.label7.Visible = False

            Me.UpDown_Origin.Visible = False
            Me.UpDown_Origin.Text = "0"


            Me.CB_Origin.Visible = False
            Me.CB_DateInterval.Visible = False

            Me.label8.Location = New Point(19, 238)
            Me.UpDown_Origin.Location = New Point(59, 235)

            Me.chartControl1.PrimaryXAxis.Offset = 0
        End Sub
#End Region

#Region "Events"
        Private Sub combobox_changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
            SetOrigin()
        End Sub

        Private Sub checkbox_changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            SetOrigin()

            Me.comboBox1.Enabled = Me.checkBox1.Checked
        End Sub

        Private Sub Invert_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged, checkBox3.CheckedChanged
            If Me.checkBox2.Checked AndAlso Me.checkBox3.Checked Then
                Me.chartControl1.PrimaryXAxis.Inversed = True
                Me.chartControl1.PrimaryYAxis.Inversed = True
            ElseIf Me.checkBox2.Checked Then
                Me.chartControl1.PrimaryXAxis.Inversed = True
                Me.chartControl1.PrimaryYAxis.Inversed = False
            ElseIf Me.checkBox3.Checked Then
                Me.chartControl1.PrimaryXAxis.Inversed = False
                Me.chartControl1.PrimaryYAxis.Inversed = True
            Else
                Me.chartControl1.PrimaryXAxis.Inversed = False
                Me.chartControl1.PrimaryYAxis.Inversed = False
            End If
        End Sub

        Private Sub checkBox5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox5.CheckedChanged
            SetOpposedPosition()
        End Sub

        Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox4.CheckedChanged
            SetOpposedPosition()
        End Sub
        Private Sub SetOpposedPosition()
            Me.chartControl1.PrimaryXAxis.OpposedPosition = checkBox5.Checked
            Me.chartControl1.PrimaryYAxis.OpposedPosition = checkBox4.Checked
        End Sub




        Private Sub CB_axis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_axis.SelectedIndexChanged
            SetClear()
            If CB_axis.SelectedItem.ToString() = "DateTimeOffset" Then
                Me.label8.Visible = True
                Me.UpDown_Origin.Visible = True

                Me.label8.Location = New Point(12, 188)
                Me.UpDown_Origin.Location = New Point(46, 186)
            End If
            If CB_axis.SelectedItem.ToString() = "Offset" Then
                Me.label8.Visible = True
                Me.UpDown_Origin.Visible = True

                Me.label8.Location = New Point(12, 188)
                Me.UpDown_Origin.Location = New Point(46, 186)
            End If
            If CB_axis.SelectedItem.ToString() = "DateTimeInterval" Then
                Me.label7.Visible = True
                Me.label7.Text = "DateTimeInterval"
                Me.label8.Visible = True
                Me.UpDown_Origin.Visible = True
                Me.CB_DateInterval.Visible = True
            End If
            If CB_axis.SelectedItem.ToString() = "RangePaddingType" Then
                Me.CB_Origin.Visible = True
                Me.label7.Visible = True
                Me.label7.Text = "RangePaddingType"
            End If
        End Sub

        Private Sub CB_DateInterval_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_DateInterval.SelectedIndexChanged
            Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
            Me.chartControl1.PrimaryXAxis.DateTimeInterval.OffsetType = CType(System.Enum.Parse(GetType(ChartDateTimeIntervalType), CB_DateInterval.SelectedItem.ToString(), True), ChartDateTimeIntervalType)
            Me.chartControl1.PrimaryXAxis.DateTimeInterval.Offset = Double.Parse(UpDown_Origin.Value.ToString())
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub CB_Origin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Origin.SelectedIndexChanged
            Me.chartControl1.PrimaryXAxis.CustomOrigin = True
            If CB_Origin.SelectedItem.ToString() = "Calculate" Then
                Me.chartControl1.PrimaryXAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate
            ElseIf CB_Origin.SelectedItem.ToString() = "None" Then
                Me.chartControl1.PrimaryXAxis.RangePaddingType = ChartAxisRangePaddingType.None
            End If
        End Sub

        Private Sub UpDown_Origin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpDown_Origin.ValueChanged
            If CB_axis.SelectedItem.ToString() = "DateTimeOffset" Then
                Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Auto
                Me.chartControl1.PrimaryXAxis.DateTimeOffset = New TimeSpan(Int32.Parse(UpDown_Origin.Value.ToString()), 0, 0, 0, 0)
            ElseIf CB_axis.SelectedItem.ToString() = "Offset" Then
                Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
                Me.chartControl1.PrimaryXAxis.CustomOrigin = True
                Me.chartControl1.PrimaryXAxis.Offset = Int32.Parse(UpDown_Origin.Value.ToString())
            ElseIf CB_axis.SelectedItem.ToString() = "DateTimeInterval" Then
                Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
                Me.chartControl1.PrimaryXAxis.CustomOrigin = True
                Me.chartControl1.PrimaryXAxis.Offset = Int32.Parse(UpDown_Origin.Value.ToString())
            Else
                Me.chartControl1.PrimaryXAxis.DateTimeInterval.Offset = Double.Parse(UpDown_Origin.Text.ToString())
            End If
            Me.chartControl1.Redraw(True)
        End Sub
#End Region
    End Class
End Namespace
