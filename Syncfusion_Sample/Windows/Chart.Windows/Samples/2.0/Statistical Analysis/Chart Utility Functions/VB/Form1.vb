Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Windows.Forms.Chart.Statistics
Imports Syncfusion.Drawing

Namespace ChartUtilityFunctions1
    Public Class Form1
        Inherits Syncfusion.Windows.Forms.Office2007Form
#Region "Private Members"
        Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
        Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
        Private WithEvents comboBox3 As System.Windows.Forms.ComboBox
        Private WithEvents comboBox4 As System.Windows.Forms.ComboBox
        Private label1 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private label4 As System.Windows.Forms.Label
        Private label5 As System.Windows.Forms.Label
        Private textBox1 As System.Windows.Forms.TextBox
        Private checkBox1 As System.Windows.Forms.CheckBox
        Private checkBox2 As System.Windows.Forms.CheckBox
        Private panel1 As System.Windows.Forms.Panel
        Private doubleX As Double
        Private y As Double
        Private coef As Double
        Private beta As Double
        Private n As Double
        Private m As Double
        Private series As ChartSeries
        Private label6 As Label
        Private label7 As Label
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing
#End Region

#Region "Form's Constructor, Main And Dispose"

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
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.comboBox3 = New System.Windows.Forms.ComboBox
            Me.comboBox4 = New System.Windows.Forms.ComboBox
            Me.label1 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.panel1 = New System.Windows.Forms.Panel
            Me.label6 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)))
            Me.chartControl1.ForeColor = System.Drawing.Color.Black
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(70, 222)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
            Me.chartControl1.Location = New System.Drawing.Point(14, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.Size = New System.Drawing.Size(433, 337)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "Essential Chart-Utility Function"
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Essential Chart-Utility Function"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox1.Location = New System.Drawing.Point(134, 88)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(100, 21)
            Me.comboBox1.TabIndex = 1
            '
            'comboBox2
            '
            Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox2.Items.AddRange(New Object() {"0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "0.99"})
            Me.comboBox2.Location = New System.Drawing.Point(134, 120)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(100, 21)
            Me.comboBox2.TabIndex = 2
            '
            'comboBox3
            '
            Me.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox3.Items.AddRange(New Object() {"2", "3", "4", "5", "8", "10", "15", "20", "30"})
            Me.comboBox3.Location = New System.Drawing.Point(153, 154)
            Me.comboBox3.Name = "comboBox3"
            Me.comboBox3.Size = New System.Drawing.Size(81, 21)
            Me.comboBox3.TabIndex = 3
            '
            'comboBox4
            '
            Me.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox4.Items.AddRange(New Object() {"2", "3", "4", "5", "8", "10", "15", "20", "30"})
            Me.comboBox4.Location = New System.Drawing.Point(153, 184)
            Me.comboBox4.Name = "comboBox4"
            Me.comboBox4.Size = New System.Drawing.Size(81, 21)
            Me.comboBox4.TabIndex = 4
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(19, 124)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(55, 13)
            Me.label1.TabIndex = 5
            Me.label1.Text = "Probability"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(19, 156)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(103, 13)
            Me.label2.TabIndex = 6
            Me.label2.Text = "Degrees of Freedom"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(134, 158)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(15, 13)
            Me.label3.TabIndex = 7
            Me.label3.Text = "N"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(134, 187)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(16, 13)
            Me.label4.TabIndex = 8
            Me.label4.Text = "M"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(19, 279)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(39, 13)
            Me.label5.TabIndex = 9
            Me.label5.Text = "Values"
            '
            'textBox1
            '
            Me.textBox1.BackColor = System.Drawing.Color.DarkGray
            Me.textBox1.Location = New System.Drawing.Point(137, 276)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.ReadOnly = True
            Me.textBox1.Size = New System.Drawing.Size(100, 20)
            Me.textBox1.TabIndex = 10
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(19, 215)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(116, 17)
            Me.checkBox1.TabIndex = 11
            Me.checkBox1.Text = "Inverse Distribution"
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.Location = New System.Drawing.Point(19, 248)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(66, 17)
            Me.checkBox2.TabIndex = 12
            Me.checkBox2.Text = "One Tail"
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.label6)
            Me.panel1.Controls.Add(Me.label7)
            Me.panel1.Controls.Add(Me.comboBox4)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.checkBox2)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Controls.Add(Me.comboBox2)
            Me.panel1.Controls.Add(Me.textBox1)
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.comboBox3)
            Me.panel1.Controls.Add(Me.checkBox1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(450, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(246, 361)
            Me.panel1.TabIndex = 13
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(19, 91)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(64, 13)
            Me.label6.TabIndex = 14
            Me.label6.Text = "Distributions"
            '
            'label7
            '
            Me.label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label7.Image = CType(resources.GetObject("label7.Image"), System.Drawing.Image)
            Me.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label7.Location = New System.Drawing.Point(3, 46)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(123, 24)
            Me.label7.TabIndex = 13
            Me.label7.Text = "Utitlity Functions"
            Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(696, 361)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Utility Functions"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.comboBox1.Items.Add("Normal Distribution")
            Me.comboBox1.Items.Add("T Cumulative Distribution")
            Me.comboBox1.Items.Add("F Cumulative Distribution")
            Me.comboBox1.SelectedIndex = 0
            Me.comboBox2.SelectedIndex = 0
            Me.comboBox3.SelectedIndex = 0
            Me.comboBox4.SelectedIndex = 0
        End Sub
#End Region

#Region "Helper Methods"

#Region "NormalDistribution"

        ''' <summary>
        ''' Updates Normal Distribution chart based on the changed values.
        ''' </summary>
        Protected Sub FillNDistribution()
            Dim values As Double = 0.0
            If (Not Me.checkBox1.Checked) Then
                values = UtilityFunctions.NormalDistribution(Convert.ToDouble(Me.comboBox2.SelectedItem))
            Else
                values = UtilityFunctions.InverseNormalDistribution(Convert.ToDouble(Me.comboBox2.SelectedItem))
            End If
            Me.textBox1.Text = values.ToString("G5")
        End Sub
        Protected Sub InitializeNormalDistributionChart()
            Me.chartControl1.Series.Clear()

            'Initializes the Normal distribution series.
            series = New ChartSeries()
            series.Name = "Normal Distribution"
            series.Type = ChartSeriesType.SplineArea
            series.Text = series.Name
            coef = 1.0 / Math.Sqrt(2 * Math.PI)

            For x As Integer = -50 To 50
                doubleX = x / 10.0
                y = coef * Math.Exp(doubleX * doubleX / -2)

                'Add the data points to the series.
                series.Points.Add(doubleX - 0.05, y)
            Next x

            series.Style.Border.Color = Color.Transparent
            'Add the series to the chart series collection.
            Me.chartControl1.Series.Add(series)
        End Sub
#End Region

#Region "TDistribution"

        ''' <summary>
        ''' Updates the T Distribution chart based on the changed values.
        ''' </summary>
        Protected Sub FillTDistribution()
            Dim values As Double = 0.0
            If (Not Me.checkBox1.Checked) Then
                values = UtilityFunctions.TCumulativeDistribution(Double.Parse(Me.comboBox2.SelectedItem.ToString()), Double.Parse(Me.comboBox3.SelectedItem.ToString()), Me.checkBox2.Checked)
            Else
                values = UtilityFunctions.InverseTCumulativeDistribution(Double.Parse(Me.comboBox2.SelectedItem.ToString()), Double.Parse(Me.comboBox3.SelectedItem.ToString()), Me.checkBox2.Checked)
            End If
            Me.textBox1.Text = values.ToString("G5")
        End Sub

        Protected Sub InitializeTDistributionChart()
            Me.chartControl1.Series.Clear()

            'Initializes the T distribution series.
            series = New ChartSeries()
            series.Name = "T Distribution"
            series.Type = ChartSeriesType.SplineArea
            series.Text = series.Name

            'Set the degree of freedom.
            n = Double.Parse(Me.comboBox3.SelectedItem.ToString())

            'Calculates the Beta function.
            beta = UtilityFunctions.Beta(0.5, n / 2.0)

            ' Calculate coefficient of T Distribution.
            coef = Math.Pow(n, -0.5) / beta

            ' Calculate Data Points
            For x As Integer = -120 To 120
                doubleX = x / 10.0
                y = coef / Math.Pow(1.0 + doubleX * doubleX / n, (n + 1.0) / 2.0)

                'Add data points to the series.
                series.Points.Add(doubleX, y)
            Next x
            series.Style.Border.Color = Color.Transparent

            'Add the series to the chart series collection.
            Me.chartControl1.Series.Add(series)
        End Sub
#End Region
#Region "FDistribution"
        ''' <summary>
        ''' Updates the F Distribution chart based on the changed values.
        ''' </summary>
        Protected Sub FillFDistribution()
            Dim values As Double = 0.0

            If Me.comboBox2.Text <> "" AndAlso Me.comboBox3.Text <> "" AndAlso Me.comboBox4.Text <> "" Then
                If (Not Me.checkBox1.Checked) Then
                    values = UtilityFunctions.FCumulativeDistribution(Double.Parse(Me.comboBox2.SelectedItem.ToString()), Double.Parse(Me.comboBox3.SelectedItem.ToString()), Double.Parse(Me.comboBox4.SelectedItem.ToString()))
                Else
                    values = UtilityFunctions.InverseFCumulativeDistribution(Double.Parse(Me.comboBox2.SelectedItem.ToString()), Double.Parse(Me.comboBox3.SelectedItem.ToString()), Double.Parse(Me.comboBox4.SelectedItem.ToString()))
                End If
            End If
            Me.textBox1.Text = values.ToString("G5")
        End Sub
        ''' <summary>
        ''' Initializes F distribution chart.
        ''' </summary>
        Protected Sub InitializeFDistributionChart()
            Me.chartControl1.Series.Clear()

            'Initializes the F distribution series.
            series = New ChartSeries()

            series.Name = "F Distribution"
            series.Type = ChartSeriesType.SplineArea
            series.Text = series.Name

            ' Set degrees of freedom
            n = Double.Parse(comboBox3.SelectedItem.ToString())
            m = Double.Parse(comboBox4.SelectedItem.ToString())

            ' Calculate the Beta function
            beta = UtilityFunctions.Beta(n / 2.0, m / 2.0)

            ' Find coefficient
            coef = Math.Pow(n / m, n / 2.0) / beta

            ' Go through all data points and calculate values
            For x As Double = 0.01 To 15 Step 0.1
                doubleX = x
                y = coef * (Math.Pow(doubleX, n / 2.0 - 1.0) / Math.Pow(1.0 + n * doubleX / m, (n + m) / 2.0))

                ' Add data points to the series.
                series.Points.Add(doubleX, y)
            Next x
            series.Style.Border.Color = Color.Transparent
            'Add the series to the chart series collection.
            Me.chartControl1.Series.Add(series)
        End Sub
#End Region

#Region "DisplayChart"
        ''' <summary>
        ''' Displays the distribution chart based on the selected value.
        ''' </summary>
        Protected Sub DisplayChart()
            Select Case Me.comboBox1.SelectedItem.ToString()
                Case "Normal Distribution"
                    InitializeNormalDistributionChart()
                    Me.comboBox3.Enabled = False
                    Me.comboBox4.Enabled = False
                    Me.checkBox2.Enabled = True
                    FillNDistribution()
                Case "T Cumulative Distribution"
                    InitializeTDistributionChart()
                    Me.comboBox3.Enabled = True
                    Me.comboBox4.Enabled = False
                    Me.checkBox2.Enabled = True
                    FillTDistribution()
                Case "F Cumulative Distribution"
                    InitializeFDistributionChart()
                    Me.comboBox3.Enabled = True
                    Me.comboBox4.Enabled = True
                    Me.checkBox2.Enabled = False
                    FillFDistribution()
                Case Else
                    InitializeNormalDistributionChart()
            End Select
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region
#End Region

#Region "Events"
        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
            DisplayChart()
        End Sub

        Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox2.SelectedIndexChanged
            DisplayChart()
        End Sub

        Private Sub comboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox3.SelectedIndexChanged
            If Me.comboBox1.SelectedItem.ToString() = "T Cumulative Distribution" Then
                DisplayChart()
                FillTDistribution()
            ElseIf Me.comboBox1.SelectedItem.ToString() = "F Cumulative Distribution" Then
                If comboBox4.Text <> "" Then
                    InitializeFDistributionChart()
                End If
                FillFDistribution()
            End If

        End Sub
        Private Sub comboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox4.SelectedIndexChanged
            If Me.comboBox1.SelectedItem.ToString() = "T Cumulative Distribution" Then
                DisplayChart()
                FillTDistribution()
            ElseIf Me.comboBox1.SelectedItem.ToString() = "F Cumulative Distribution" Then
                If comboBox3.Text <> "" Then
                    InitializeFDistributionChart()
                End If
                FillFDistribution()
            End If

        End Sub
#End Region
    End Class
End Namespace
