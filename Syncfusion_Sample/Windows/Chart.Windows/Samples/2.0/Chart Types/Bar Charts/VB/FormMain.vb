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
    Public Class FormMain
        Inherits Office2007Form
#Region "Private members"
        Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private label1 As System.Windows.Forms.Label
        Private WithEvents comboBoxChartType As System.Windows.Forms.ComboBox
        Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
        Private panel2 As System.Windows.Forms.Panel
        Private radioButton1 As System.Windows.Forms.RadioButton
        Private WithEvents colorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
        Private radioButton2 As System.Windows.Forms.RadioButton
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private label10 As Label
        Private label12 As Label
        Private components As System.ComponentModel.Container = Nothing
#End Region

#Region "Form Constructor, Main and Dispose"
        Public Sub New()
            '
            ' Required for Windows Form Designer support
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
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.label1 = New System.Windows.Forms.Label
            Me.comboBoxChartType = New System.Windows.Forms.ComboBox
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.panel2 = New System.Windows.Forms.Panel
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.radioButton2 = New System.Windows.Forms.RadioButton
            Me.label10 = New System.Windows.Forms.Label
            Me.label12 = New System.Windows.Forms.Label
            Me.panel2.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(166, Byte), Integer)))
            Me.chartControl1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            '
            '
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.Legend.ForeColor = System.Drawing.SystemColors.ControlText
            Me.chartControl1.Legend.ItemsSize = New System.Drawing.Size(15, 15)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(293, 75)
            Me.chartControl1.Legend.Spacing = 3
            Me.chartControl1.Location = New System.Drawing.Point(21, 17)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.PrimaryXAxis.LabelRotateAngle = 45
            Me.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.PrimaryYAxis.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.PrimaryYAxis.LabelRotate = True
            Me.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.Size = New System.Drawing.Size(406, 349)
            Me.chartControl1.TabIndex = 2
            Me.chartControl1.Text = "Essential Chart"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Essential Chart"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ZoomOutIncrement = 1.5
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(16, 29)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(64, 16)
            Me.label1.TabIndex = 2
            Me.label1.Text = "ChartType"
            '
            'comboBoxChartType
            '
            Me.comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxChartType.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBoxChartType.Location = New System.Drawing.Point(74, 27)
            Me.comboBoxChartType.Name = "comboBoxChartType"
            Me.comboBoxChartType.Size = New System.Drawing.Size(96, 21)
            Me.comboBoxChartType.TabIndex = 1
            '
            'checkBox2
            '
            Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox2.Location = New System.Drawing.Point(19, 55)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(96, 24)
            Me.checkBox2.TabIndex = 1
            Me.checkBox2.Text = "Show Labels"
            '
            'checkBox1
            '
            Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox1.Location = New System.Drawing.Point(19, 85)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(72, 24)
            Me.checkBox1.TabIndex = 0
            Me.checkBox1.Text = "3D View"
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.White
            Me.panel2.Controls.Add(Me.groupBox1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel2.Location = New System.Drawing.Point(445, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(190, 394)
            Me.panel2.TabIndex = 4
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.colorPickerButton1)
            Me.groupBox1.Controls.Add(Me.radioButton1)
            Me.groupBox1.Controls.Add(Me.checkBox1)
            Me.groupBox1.Controls.Add(Me.radioButton2)
            Me.groupBox1.Controls.Add(Me.comboBoxChartType)
            Me.groupBox1.Controls.Add(Me.label10)
            Me.groupBox1.Controls.Add(Me.checkBox2)
            Me.groupBox1.Controls.Add(Me.label12)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Location = New System.Drawing.Point(8, 55)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(175, 288)
            Me.groupBox1.TabIndex = 5
            Me.groupBox1.TabStop = False
            '
            'colorPickerButton1
            '
            Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.colorPickerButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton1.Location = New System.Drawing.Point(25, 228)
            Me.colorPickerButton1.Name = "colorPickerButton1"
            Me.colorPickerButton1.SelectedAsBackcolor = True
            Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton1.Size = New System.Drawing.Size(80, 24)
            Me.colorPickerButton1.TabIndex = 0
            Me.colorPickerButton1.Text = "ColorPalette"
            '
            'radioButton1
            '
            Me.radioButton1.Checked = True
            Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton1.Location = New System.Drawing.Point(24, 162)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(80, 25)
            Me.radioButton1.TabIndex = 1
            Me.radioButton1.TabStop = True
            Me.radioButton1.Text = "Server1"
            Me.radioButton1.TextAlign = System.Drawing.ContentAlignment.TopLeft
            '
            'radioButton2
            '
            Me.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton2.Location = New System.Drawing.Point(24, 193)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(64, 23)
            Me.radioButton2.TabIndex = 2
            Me.radioButton2.Text = "Server2"
            Me.radioButton2.TextAlign = System.Drawing.ContentAlignment.TopLeft
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.BackColor = System.Drawing.Color.Transparent
            Me.label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label10.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label10.Location = New System.Drawing.Point(17, 124)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(81, 14)
            Me.label10.TabIndex = 3
            Me.label10.Text = "Interior Color"
            '
            'label12
            '
            Me.label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label12.Location = New System.Drawing.Point(21, 145)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(140, 1)
            Me.label12.TabIndex = 4
            '
            'FormMain
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(635, 394)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormMain"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Bar Charts"
            Me.panel2.ResumeLayout(False)
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Helper Methods"

#Region "InitializeChartData"
        ''' <summary>
        ''' Initializes the ChartControl's data and sets the Chart type
        ''' </summary>
        Protected Sub InitializeChartData()
            Dim series As ChartSeries = New ChartSeries("Server 1", ChartSeriesType.Bar)
            series.Points.Add(16, 225)
            series.Points.Add(4, 325)
            series.Points.Add(8, 275)
            series.Points.Add(12, 320)

            Dim series1 As ChartSeries = New ChartSeries("Server 2", ChartSeriesType.Bar)
            series1.Points.Add(16, 325)
            series1.Points.Add(4, 310)
            series1.Points.Add(8, 315)
            series1.Points.Add(12, 280)

            Me.chartControl1.Series.Add(series)
            Me.chartControl1.Series.Add(series1)
        End Sub
#End Region

#End Region

#Region "Events"

#Region "Form Load"
        Private Sub FormMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.comboBoxChartType.Items.Add(ChartSeriesType.Bar)
            Me.comboBoxChartType.Items.Add(ChartSeriesType.StackingBar)
            Me.comboBoxChartType.SelectedIndex = 0

            InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            Me.chartControl1.Series3D = Me.checkBox1.Checked
            If (checkBox1.Checked) Then
                Me.chartControl1.Series(0).Style.Border.Color = Color.FromArgb(191, 192, 98)
                Me.chartControl1.Series(1).Style.Border.Color = Color.FromArgb(250, 206, 35)
            Else
                Me.chartControl1.Series(0).Style.Border.Color = Color.Transparent
                Me.chartControl1.Series(1).Style.Border.Color = Color.Transparent
            End If
        End Sub

        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxChartType.SelectedIndexChanged

            For i As Integer = 0 To Me.chartControl1.Series.Count - 1
                Me.chartControl1.Series(i).Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBoxChartType.SelectedItem.ToString(), True), ChartSeriesType)
            Next i

            If Me.comboBoxChartType.SelectedItem.ToString() = "Bar" Then
                Me.chartControl1.PrimaryXAxis.Range = New MinMaxInfo(0, 400, 100)
            Else
                Me.chartControl1.PrimaryXAxis.Range = New MinMaxInfo(0, 700, 100)
            End If
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
            Me.chartControl1.Series(0).Style.DisplayText = Me.checkBox2.Checked
            Me.chartControl1.Series(1).Style.DisplayText = Me.checkBox2.Checked
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub colorPickerButton1_ColorSelected_1(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorPickerButton1.ColorSelected
            If Me.radioButton1.Checked Then
                Me.chartControl1.Series(0).Style.Interior = New BrushInfo(200, New BrushInfo(GradientStyle.ForwardDiagonal, Me.colorPickerButton1.SelectedColor, Me.colorPickerButton1.SelectedColor))
            Else
                Me.chartControl1.Series(1).Style.Interior = New BrushInfo(200, New BrushInfo(GradientStyle.ForwardDiagonal, Me.colorPickerButton1.SelectedColor, Me.colorPickerButton1.SelectedColor))
            End If
            Me.chartControl1.Redraw(True)
        End Sub
#End Region
    End Class
End Namespace