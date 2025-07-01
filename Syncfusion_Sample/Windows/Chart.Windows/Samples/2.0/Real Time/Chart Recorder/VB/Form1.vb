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
        Private prodDs1 As DataSet
        Private WithEvents timer1 As System.Windows.Forms.Timer
        Private components As System.ComponentModel.IContainer

        Private dataPointsCount As Integer
        Private numPointsPerTimer As Integer = 10
        Private yMax As Integer = 1000
        Private yMin As Integer = 0
        Private label3 As System.Windows.Forms.Label
        Private checkBox1 As System.Windows.Forms.CheckBox
        Private label2 As System.Windows.Forms.Label
        Private label1 As System.Windows.Forms.Label
        Private textBox2 As System.Windows.Forms.TextBox
        Private textBox1 As System.Windows.Forms.TextBox
        Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private panel1 As System.Windows.Forms.Panel
        Private WithEvents checkBox2 As CheckBox
        Private WithEvents checkBox3 As CheckBox
        Private WithEvents comboBox1 As ComboBox
        Private label6 As Label
        Private label7 As Label
        Private label4 As Label
        Private label5 As Label
        Private model As TopArrayModel = New TopArrayModel()
#End Region

#Region "Form Constructor, Main And Dispose"
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Me.checkBox1.Checked = True



            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
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
                If components IsNot Nothing Then
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
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.label3 = New System.Windows.Forms.Label
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.label2 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.textBox2 = New System.Windows.Forms.TextBox
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel1 = New System.Windows.Forms.Panel
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label6 = New System.Windows.Forms.Label
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.label7 = New System.Windows.Forms.Label
            Me.checkBox3 = New System.Windows.Forms.CheckBox
            Me.label4 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'timer1
            '
            Me.timer1.Interval = 200
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label3.Location = New System.Drawing.Point(271, 68)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(131, 13)
            Me.label3.TabIndex = 5
            Me.label3.Text = "Window Width in seconds"
            '
            'checkBox1
            '
            Me.checkBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.checkBox1.AutoSize = True
            Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox1.Location = New System.Drawing.Point(271, 90)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(72, 18)
            Me.checkBox1.TabIndex = 1
            Me.checkBox1.Text = "Scrolling"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label2.Location = New System.Drawing.Point(28, 90)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(88, 13)
            Me.label2.TabIndex = 7
            Me.label2.Tag = ""
            Me.label2.Text = "Minimum Y Value"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label1.Location = New System.Drawing.Point(28, 68)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(91, 13)
            Me.label1.TabIndex = 6
            Me.label1.Tag = ""
            Me.label1.Text = "Maximum Y Value"
            '
            'textBox2
            '
            Me.textBox2.Location = New System.Drawing.Point(121, 87)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(48, 20)
            Me.textBox2.TabIndex = 5
            Me.textBox2.Text = "0"
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(121, 65)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(48, 20)
            Me.textBox1.TabIndex = 4
            Me.textBox1.Text = "1000"
            '
            'chartControl1
            '
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 5, 20, 10)
            '
            '
            '
            Me.chartControl1.Legend.Location = New System.Drawing.Point(446, 70)
            Me.chartControl1.Location = New System.Drawing.Point(12, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryYAxis.ForceZero = True
            Me.chartControl1.Size = New System.Drawing.Size(565, 290)
            Me.chartControl1.TabIndex = 4
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
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Controls.Add(Me.label6)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.checkBox1)
            Me.panel1.Controls.Add(Me.checkBox2)
            Me.panel1.Controls.Add(Me.label7)
            Me.panel1.Controls.Add(Me.checkBox3)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Controls.Add(Me.textBox2)
            Me.panel1.Controls.Add(Me.textBox1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 308)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(589, 119)
            Me.panel1.TabIndex = 7
            '
            'comboBox1
            '
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Items.AddRange(New Object() {"5", "10", "20", "30", "60"})
            Me.comboBox1.Location = New System.Drawing.Point(398, 68)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(48, 21)
            Me.comboBox1.TabIndex = 7
            '
            'label6
            '
            Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label6.Location = New System.Drawing.Point(268, 29)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(175, 1)
            Me.label6.TabIndex = 131
            '
            'checkBox2
            '
            Me.checkBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.checkBox2.AutoSize = True
            Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox2.Location = New System.Drawing.Point(271, 41)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(93, 18)
            Me.checkBox2.TabIndex = 6
            Me.checkBox2.Text = "Show Labels"
            '
            'label7
            '
            Me.label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label7.Image = CType(resources.GetObject("label7.Image"), System.Drawing.Image)
            Me.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label7.Location = New System.Drawing.Point(268, 9)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(110, 19)
            Me.label7.TabIndex = 130
            Me.label7.Text = "Horizontal Axis"
            Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'checkBox3
            '
            Me.checkBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.checkBox3.AutoSize = True
            Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox3.Location = New System.Drawing.Point(28, 41)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(93, 18)
            Me.checkBox3.TabIndex = 8
            Me.checkBox3.Text = "Show Labels"
            '
            'label4
            '
            Me.label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label4.Location = New System.Drawing.Point(28, 29)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(175, 1)
            Me.label4.TabIndex = 129
            '
            'label5
            '
            Me.label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label5.Image = CType(resources.GetObject("label5.Image"), System.Drawing.Image)
            Me.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label5.Location = New System.Drawing.Point(28, 9)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(94, 19)
            Me.label5.TabIndex = 128
            Me.label5.Text = "Vertical Axis"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(589, 427)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Recorder"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitializeChart()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region "Helper Methods"
#Region "InitializeChart"
        Protected Sub InitializeChart()
            ' Set Indexed to false as we will be using non indexed data
            Me.chartControl1.Indexed = False
            Dim series As ChartSeries = New ChartSeries()
            series.Text = "Products"
            series.SeriesModel = model
            series.Type = ChartSeriesType.SplineArea
            series.Style.DisplayShadow = False
            Me.chartControl1.Series.Add(series)
            Me.timer1.Start()
            Me.chartControl1.PrimaryXAxis.ValueType = ChartValueType.Double
            Me.chartControl1.PrimaryYAxis.ValueType = ChartValueType.Double
            Me.comboBox1.SelectedIndex = 1
        End Sub
#End Region
#End Region

#Region "Events"

        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer1.Tick
            Try
                Dim rand As Random = New Random()

                For i As Integer = 0 To numPointsPerTimer - 1
                    Me.model.AddXY(dataPointsCount, New Double() {rand.Next(yMin, yMax)})
                    dataPointsCount += 1
                Next i

                Me.chartControl1.PrimaryXAxis.Range.Min = 0
                Me.chartControl1.PrimaryXAxis.Range.Max = dataPointsCount
                If dataPointsCount > 100 Then
                    Me.chartControl1.PrimaryXAxis.Range.Interval = 5.0
                ElseIf dataPointsCount > 1000 Then
                    Me.chartControl1.PrimaryXAxis.Range.Interval = 7.0
                Else
                    Me.chartControl1.PrimaryXAxis.Range.Interval = 3.0
                End If


                Dim visibleRange As Integer = Convert.ToInt32(Me.comboBox1.SelectedItem) * Me.numPointsPerTimer
                If Me.checkBox1.Checked AndAlso dataPointsCount > visibleRange Then
                    Me.chartControl1.PrimaryXAxis.Range.Max = dataPointsCount
                    Me.chartControl1.PrimaryXAxis.Range.Min = dataPointsCount - visibleRange
                Else
                    model.TopCount = 0
                End If

                ' Y Axis
                Dim yVisibleMax As Integer = Int32.Parse(Me.textBox1.Text)
                Dim yVisibleMin As Integer = Int32.Parse(Me.textBox2.Text)

                If yVisibleMax <= yMax AndAlso yVisibleMin >= yMin Then
                    Dim yVisibleRange As Double = yVisibleMax - yVisibleMin
                    Dim yRange As Double = yMax - yMin
                    Me.chartControl1.ZoomFactorY = yVisibleRange / yRange
                    Me.chartControl1.ZoomPositionY = 1 - yVisibleMin / yRange
                End If

            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
        End Sub



        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            If Me.checkBox2.Checked Then

                Me.chartControl1.PrimaryXAxis.ValueType = ChartValueType.Double

            Else

                Me.chartControl1.PrimaryXAxis.ValueType = ChartValueType.Custom
            End If


        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckedChanged
            If Me.checkBox3.Checked Then
                Me.chartControl1.PrimaryYAxis.ValueType = ChartValueType.Double
            Else
                Me.chartControl1.PrimaryYAxis.ValueType = ChartValueType.Custom
            End If
        End Sub


        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
            Me.Refresh()
        End Sub

#End Region
    End Class
End Namespace