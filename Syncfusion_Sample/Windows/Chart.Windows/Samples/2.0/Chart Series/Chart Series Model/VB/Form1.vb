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

Namespace ChartSeriesModel
    Public Class Form1
        Inherits Office2007Form
#Region "Private Members"

        Private panel1 As System.Windows.Forms.Panel
        Private label1 As System.Windows.Forms.Label
        Private WithEvents radioButtonSeries As RadioButton
        Private WithEvents radioButtonIndexed As RadioButton
        Private panel2 As Panel
        Private chartControl1 As ChartControl
        Private WithEvents checkBox6 As CheckBox
        Private WithEvents checkBox5 As CheckBox
        Private WithEvents checkBox4 As CheckBox
        Private WithEvents checkBox3 As CheckBox
        Private WithEvents checkBox2 As CheckBox
        Private WithEvents checkBox1 As CheckBox
        Private label2 As Label
        Private label3 As Label
        Private components As System.ComponentModel.Container = Nothing
#End Region

#Region "Constructor, Main And Dispose"
        Public Sub New()

            InitializeComponent()
            Application.EnableVisualStyles()
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
            Me.panel1 = New System.Windows.Forms.Panel
            Me.label3 = New System.Windows.Forms.Label
            Me.checkBox6 = New System.Windows.Forms.CheckBox
            Me.checkBox5 = New System.Windows.Forms.CheckBox
            Me.checkBox4 = New System.Windows.Forms.CheckBox
            Me.checkBox3 = New System.Windows.Forms.CheckBox
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.label2 = New System.Windows.Forms.Label
            Me.radioButtonIndexed = New System.Windows.Forms.RadioButton
            Me.radioButtonSeries = New System.Windows.Forms.RadioButton
            Me.label1 = New System.Windows.Forms.Label
            Me.panel2 = New System.Windows.Forms.Panel
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.checkBox6)
            Me.panel1.Controls.Add(Me.checkBox5)
            Me.panel1.Controls.Add(Me.checkBox4)
            Me.panel1.Controls.Add(Me.checkBox3)
            Me.panel1.Controls.Add(Me.checkBox2)
            Me.panel1.Controls.Add(Me.checkBox1)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.radioButtonIndexed)
            Me.panel1.Controls.Add(Me.radioButtonSeries)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 388)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(496, 139)
            Me.panel1.TabIndex = 1
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label3.Location = New System.Drawing.Point(17, 3)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(402, 13)
            Me.label3.TabIndex = 11
            Me.label3.Text = "Series Style Dialog will be displayed while double click the Series points in the" & _
                " Chart."
            '
            'checkBox6
            '
            Me.checkBox6.AutoSize = True
            Me.checkBox6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.checkBox6.Location = New System.Drawing.Point(146, 102)
            Me.checkBox6.Name = "checkBox6"
            Me.checkBox6.Size = New System.Drawing.Size(95, 17)
            Me.checkBox6.TabIndex = 10
            Me.checkBox6.Text = "Show Text tab"
            Me.checkBox6.UseVisualStyleBackColor = True
            '
            'checkBox5
            '
            Me.checkBox5.AutoSize = True
            Me.checkBox5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.checkBox5.Location = New System.Drawing.Point(20, 102)
            Me.checkBox5.Name = "checkBox5"
            Me.checkBox5.Size = New System.Drawing.Size(108, 17)
            Me.checkBox5.TabIndex = 9
            Me.checkBox5.Text = "Show Symbol tab"
            Me.checkBox5.UseVisualStyleBackColor = True
            '
            'checkBox4
            '
            Me.checkBox4.AutoSize = True
            Me.checkBox4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.checkBox4.Location = New System.Drawing.Point(146, 79)
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(113, 17)
            Me.checkBox4.TabIndex = 8
            Me.checkBox4.Text = "Show Shadow tab"
            Me.checkBox4.UseVisualStyleBackColor = True
            '
            'checkBox3
            '
            Me.checkBox3.AutoSize = True
            Me.checkBox3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.checkBox3.Location = New System.Drawing.Point(20, 79)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(106, 17)
            Me.checkBox3.TabIndex = 7
            Me.checkBox3.Text = "Show Interior tab"
            Me.checkBox3.UseVisualStyleBackColor = True
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.checkBox2.Location = New System.Drawing.Point(146, 56)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(144, 17)
            Me.checkBox2.TabIndex = 6
            Me.checkBox2.Text = "Show FancyToolTips tab"
            Me.checkBox2.UseVisualStyleBackColor = True
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.checkBox1.Location = New System.Drawing.Point(20, 56)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(105, 17)
            Me.checkBox1.TabIndex = 5
            Me.checkBox1.Text = "Show Border tab"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Location = New System.Drawing.Point(17, 29)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(114, 13)
            Me.label2.TabIndex = 4
            Me.label2.Text = "StyleDialogOptions"
            '
            'radioButtonIndexed
            '
            Me.radioButtonIndexed.AutoSize = True
            Me.radioButtonIndexed.ForeColor = System.Drawing.Color.MidnightBlue
            Me.radioButtonIndexed.Location = New System.Drawing.Point(356, 45)
            Me.radioButtonIndexed.Name = "radioButtonIndexed"
            Me.radioButtonIndexed.Size = New System.Drawing.Size(121, 17)
            Me.radioButtonIndexed.TabIndex = 3
            Me.radioButtonIndexed.TabStop = True
            Me.radioButtonIndexed.Text = "IndexedSeriesModel"
            Me.radioButtonIndexed.UseVisualStyleBackColor = False
            '
            'radioButtonSeries
            '
            Me.radioButtonSeries.AutoSize = True
            Me.radioButtonSeries.ForeColor = System.Drawing.Color.MidnightBlue
            Me.radioButtonSeries.Location = New System.Drawing.Point(356, 29)
            Me.radioButtonSeries.Name = "radioButtonSeries"
            Me.radioButtonSeries.Size = New System.Drawing.Size(83, 17)
            Me.radioButtonSeries.TabIndex = 2
            Me.radioButtonSeries.TabStop = True
            Me.radioButtonSeries.Text = "SeriesModel"
            Me.radioButtonSeries.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Location = New System.Drawing.Point(273, 29)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(71, 13)
            Me.label1.TabIndex = 0
            Me.label1.Text = "ChartModel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.chartControl1)
            Me.panel2.Controls.Add(Me.panel1)
            Me.panel2.Location = New System.Drawing.Point(9, 8)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(496, 527)
            Me.panel2.TabIndex = 3
            '
            'chartControl1
            '
            Me.chartControl1.AllowUserEditStyles = True
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
            Me.chartControl1.ChartArea.Watermark.TextColor = System.Drawing.SystemColors.ControlText
            '
            '
            '
            Me.chartControl1.Legend.Location = New System.Drawing.Point(355, 87)
            Me.chartControl1.Location = New System.Drawing.Point(7, 10)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.Color.Black
            Me.chartControl1.PrimaryXAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
            Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.White
            Me.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.White
            Me.chartControl1.PrimaryXAxis.Title = "Version"
            Me.chartControl1.PrimaryXAxis.TitleColor = System.Drawing.Color.Black
            Me.chartControl1.PrimaryYAxis.ForceZero = True
            Me.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.Color.Black
            Me.chartControl1.PrimaryYAxis.GridLineType.BackColor = System.Drawing.Color.White
            Me.chartControl1.PrimaryYAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
            Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.White
            Me.chartControl1.PrimaryYAxis.LineType.BackColor = System.Drawing.Color.White
            Me.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.White
            Me.chartControl1.PrimaryYAxis.Title = "Documents Generated"
            Me.chartControl1.PrimaryYAxis.TitleColor = System.Drawing.Color.Black
            Me.chartControl1.Size = New System.Drawing.Size(481, 365)
            Me.chartControl1.TabIndex = 2
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.ForeColor = System.Drawing.Color.Black
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(508, 539)
            Me.Controls.Add(Me.panel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Series Model "
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.radioButtonIndexed.Checked = True
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
            InitializeChartData()
        End Sub
#End Region

#Region "Helper Methods"

#Region "InitializeChartData"
        Protected Sub InitializeChartData()
            Me.chartControl1.Series.Clear()
            Dim series As ChartSeries = New ChartSeries()
            series.Name = "Machine 1"
            series.Text = series.Name
            series.Type = ChartSeriesType.Line
            Me.chartControl1.PrimaryXAxis.ValueType = ChartValueType.Custom

            'IndexedSeriesModel
            If Me.radioButtonIndexed.Checked Then
                'Indexed models do not have an associated X-axis value for their points.
                'The X-axis value is commonly just the position of the data within the series.
                series.SeriesIndexedModelImpl = New CustomIndexedSeriesModel()
                Me.chartControl1.Indexed = True
                Me.chartControl1.Titles(0).Text = "Custom Indexed Series Model"
                Me.chartControl1.PrimaryXAxis.LabelsImpl = New IndexedSeriesLabelModel()
                Me.chartControl1.PrimaryXAxis.Title = "Version"
                'SeriesModel
            ElseIf Me.radioButtonSeries.Checked Then
                series.SeriesModel = New CustomSeriesModel()
                Me.chartControl1.Indexed = False
                Me.chartControl1.Titles(0).Text = "Custom Series Model"
                Me.chartControl1.PrimaryXAxis.LabelsImpl = New SeriesLabelModel(New String() {"Mar", "Apr", "May", "Jun", "Jul"})
                Me.chartControl1.PrimaryXAxis.Title = "Month"
            End If
            series.Style.Symbol.Size = New Size(25, 25)
            series.Style.Symbol.Shape = ChartSymbolShape.Diamond
            series.Style.Symbol.Color = Color.White
            series.Style.DisplayText = True
            series.Style.Border.Width = 3
            Me.chartControl1.Series.Add(series)
        End Sub
#End Region

#End Region

#Region "Event"

        Private Sub SeriesModel_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonIndexed.CheckedChanged, radioButtonSeries.CheckedChanged
            InitializeChartData()
        End Sub
        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            Me.chartControl1.StyleDialogOptions.ShowBorderTab = Me.checkBox1.Checked
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            Me.chartControl1.StyleDialogOptions.ShowFancyToolTipsTab = Me.checkBox2.Checked
        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckedChanged
            Me.chartControl1.StyleDialogOptions.ShowInteriorTab = Me.checkBox3.Checked
        End Sub

        Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox4.CheckedChanged
            Me.chartControl1.StyleDialogOptions.ShowShadowTab = Me.checkBox4.Checked
        End Sub

        Private Sub checkBox5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox5.CheckedChanged
            Me.chartControl1.StyleDialogOptions.ShowSymbolTab = Me.checkBox5.Checked
        End Sub

        Private Sub checkBox6_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox6.CheckedChanged
            Me.chartControl1.StyleDialogOptions.ShowTextTab = Me.checkBox6.Checked
        End Sub
#End Region
    End Class
End Namespace
