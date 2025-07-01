Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Tools

Namespace PyramidAndFunnelChart
    Public Class Form1
        Inherits Office2007Form
#Region "Private Members"
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private label3 As System.Windows.Forms.Label
        Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
        Private label2 As System.Windows.Forms.Label
        Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
        Private label1 As System.Windows.Forms.Label
        Private panel1 As System.Windows.Forms.Panel
        Private WithEvents comboBox3 As System.Windows.Forms.ComboBox
        Private label4 As System.Windows.Forms.Label
        Private WithEvents comboBox4 As System.Windows.Forms.ComboBox
        Private label5 As System.Windows.Forms.Label
        Private WithEvents comboBox5 As System.Windows.Forms.ComboBox
        Private label6 As System.Windows.Forms.Label
        Private label7 As System.Windows.Forms.Label
        Private chartControl1 As ChartControl
        Private components As IContainer

        Private color1 As Color() = New Color() {Color.FromArgb(223, 111, 39), Color.FromArgb(251, 169, 113), Color.FromArgb(223, 111, 39)}
        Private color5 As Color() = New Color() {Color.FromArgb(208, 171, 110), Color.FromArgb(249, 208, 154), Color.FromArgb(208, 171, 110)}
        Private color2 As Color() = New Color() {Color.FromArgb(90, 70, 114), Color.FromArgb(136, 109, 169), Color.FromArgb(90, 70, 114)}
        Private color3 As Color() = New Color() {Color.FromArgb(110, 132, 63), Color.FromArgb(161, 192, 97), Color.FromArgb(110, 132, 63)}
        Private color4 As Color() = New Color() {Color.FromArgb(129, 53, 50), Color.FromArgb(197, 88, 85), Color.FromArgb(129, 53, 50)}
        Private color6 As Color() = New Color() {Color.FromArgb(57, 95, 140), Color.FromArgb(102, 139, 191), Color.FromArgb(57, 95, 140)}
#End Region

#Region "Constructor, Main & Dispose"
        Public Sub New()
            InitializeComponent()
            Me.chartControl1.ChartArea.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 10, 10)
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 10, 10)
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
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New Form1())
        End Sub
#End Region

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.label3 = New System.Windows.Forms.Label
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.label2 = New System.Windows.Forms.Label
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label1 = New System.Windows.Forms.Label
            Me.panel1 = New System.Windows.Forms.Panel
            Me.label7 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.comboBox5 = New System.Windows.Forms.ComboBox
            Me.label5 = New System.Windows.Forms.Label
            Me.comboBox4 = New System.Windows.Forms.ComboBox
            Me.label4 = New System.Windows.Forms.Label
            Me.comboBox3 = New System.Windows.Forms.ComboBox
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'checkBox1
            '
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox1.Location = New System.Drawing.Point(8, 271)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.checkBox1.Size = New System.Drawing.Size(101, 20)
            Me.checkBox1.TabIndex = 13
            Me.checkBox1.Text = "3D View     "
            Me.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'label3
            '
            Me.label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(8, 199)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(85, 20)
            Me.label3.TabIndex = 11
            Me.label3.Text = "Point Gap"
            '
            'comboBox2
            '
            Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox2.Location = New System.Drawing.Point(97, 159)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(107, 21)
            Me.comboBox2.TabIndex = 10
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(8, 162)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(89, 20)
            Me.label2.TabIndex = 9
            Me.label2.Text = "Label Placement"
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox1.Location = New System.Drawing.Point(97, 122)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(107, 21)
            Me.comboBox1.TabIndex = 8
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(8, 125)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(85, 20)
            Me.label1.TabIndex = 7
            Me.label1.Text = "Label Style"
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.panel1.Controls.Add(Me.comboBox2)
            Me.panel1.Controls.Add(Me.label7)
            Me.panel1.Controls.Add(Me.label6)
            Me.panel1.Controls.Add(Me.comboBox5)
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Controls.Add(Me.comboBox4)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.comboBox3)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.checkBox1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(440, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(216, 374)
            Me.panel1.TabIndex = 14
            '
            'label7
            '
            Me.label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label7.Location = New System.Drawing.Point(12, 69)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(187, 1)
            Me.label7.TabIndex = 20
            Me.label7.Text = "                                                                       "
            '
            'label6
            '
            Me.label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label6.Image = CType(resources.GetObject("label6.Image"), System.Drawing.Image)
            Me.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label6.Location = New System.Drawing.Point(13, 48)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(137, 18)
            Me.label6.TabIndex = 19
            Me.label6.Text = "Accumulation Chart "
            Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'comboBox5
            '
            Me.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox5.Items.AddRange(New Object() {"Pyramid", "Funnel"})
            Me.comboBox5.Location = New System.Drawing.Point(97, 85)
            Me.comboBox5.Name = "comboBox5"
            Me.comboBox5.Size = New System.Drawing.Size(107, 21)
            Me.comboBox5.TabIndex = 18
            '
            'label5
            '
            Me.label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.Location = New System.Drawing.Point(8, 88)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(85, 20)
            Me.label5.TabIndex = 17
            Me.label5.Text = "Chart Type"
            '
            'comboBox4
            '
            Me.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox4.Items.AddRange(New Object() {"Circle", "Square"})
            Me.comboBox4.Location = New System.Drawing.Point(97, 233)
            Me.comboBox4.Name = "comboBox4"
            Me.comboBox4.Size = New System.Drawing.Size(107, 21)
            Me.comboBox4.TabIndex = 16
            '
            'label4
            '
            Me.label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(8, 236)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(85, 20)
            Me.label4.TabIndex = 15
            Me.label4.Text = "FigureBase"
            '
            'comboBox3
            '
            Me.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox3.Items.AddRange(New Object() {"0.0", "0.1", "0.2"})
            Me.comboBox3.Location = New System.Drawing.Point(97, 196)
            Me.comboBox3.Name = "comboBox3"
            Me.comboBox3.Size = New System.Drawing.Size(107, 21)
            Me.comboBox3.TabIndex = 14
            '
            'chartControl1
            '
            Me.chartControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer)))
            '
            '
            '
            Me.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center
            Me.chartControl1.Legend.Cursor = System.Windows.Forms.Cursors.Default
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(158, 66)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.LegendPosition = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside
            Me.chartControl1.Location = New System.Drawing.Point(12, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.OriginDate = New Date(1899, 12, 30, 0, 0, 0, 0)
            Me.chartControl1.PrimaryYAxis.OriginDate = New Date(1899, 12, 30, 0, 0, 0, 0)
            Me.chartControl1.Size = New System.Drawing.Size(411, 350)
            Me.chartControl1.TabIndex = 15
            Me.chartControl1.Text = "Project Cost Breakdown"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Project Cost Breakdown"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(656, 374)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Pyramid and Funnel Charts"
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "FormLoad"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            For Each labelstyle As String In System.Enum.GetNames(GetType(ChartAccumulationLabelStyle))
                Me.comboBox1.Items.Add(labelstyle)
            Next labelstyle
            Me.comboBox1.SelectedIndex = 1
            Me.comboBox3.SelectedIndex = 0
            Me.comboBox5.SelectedIndex = 0
            Me.comboBox2.SelectedIndex = 1
            Me.comboBox4.SelectedIndex = 0
            ChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
            Me.checkBox1.Checked = False
        End Sub
#End Region

#Region "Helper Methods"
#Region "ChartData"
        Private Sub ChartData()
            Dim series1 As ChartSeries = New ChartSeries("Pyramid chart", ChartSeriesType.Pyramid)
            series1.Points.Add(0, 25)
            series1.Points.Add(1, 25)
            series1.Points.Add(2, 25)
            series1.Points.Add(3, 25)
            series1.Points.Add(4, 25)
            Me.chartControl1.Series.Add(series1)

            Me.chartControl1.Series(0).ConfigItems.PyramidItem.PyramidMode = ChartPyramidMode.Linear
            Me.chartControl1.Series(0).ConfigItems.PyramidItem.FigureBase = ChartFigureBase.Circle

            series1.Styles(0).Text = "  Oats" & Constants.vbLf & "4.15%"
            series1.Styles(1).Text = "Barley" & Constants.vbLf & "12.89%"
            series1.Styles(2).Text = "Maize" & Constants.vbLf & "21.62%"
            series1.Styles(3).Text = " Rice" & Constants.vbLf & "23.75%"
            series1.Styles(4).Text = "Wheat" & Constants.vbLf & "37.5%"

            series1.Style.DisplayText = True
            series1.Style.TextColor = Color.Black

            Me.chartControl1.Series(0).ConfigItems.PyramidItem.LabelStyle = ChartAccumulationLabelStyle.Inside
            Me.chartControl1.Series(0).ConfigItems.PyramidItem.LabelPlacement = ChartAccumulationLabelPlacement.Center


        End Sub
#End Region

#End Region

#Region "Events"

        Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox2.SelectedIndexChanged
            If comboBox5.SelectedIndex = 0 Then
                Me.chartControl1.Series(0).ConfigItems.PyramidItem.LabelPlacement = CType(System.Enum.Parse(GetType(ChartAccumulationLabelPlacement), Me.comboBox2.SelectedItem.ToString(), True), ChartAccumulationLabelPlacement)
            Else
                Me.chartControl1.Series(0).ConfigItems.FunnelItem.LabelPlacement = CType(System.Enum.Parse(GetType(ChartAccumulationLabelPlacement), Me.comboBox2.SelectedItem.ToString(), True), ChartAccumulationLabelPlacement)
            End If
        End Sub

        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
            If comboBox5.SelectedIndex = 0 Then
                Me.chartControl1.Series(0).ConfigItems.PyramidItem.LabelStyle = CType(System.Enum.Parse(GetType(ChartAccumulationLabelStyle), Me.comboBox1.SelectedItem.ToString(), True), ChartAccumulationLabelStyle)
            Else
                Me.chartControl1.Series(0).ConfigItems.FunnelItem.LabelStyle = CType(System.Enum.Parse(GetType(ChartAccumulationLabelStyle), Me.comboBox1.SelectedItem.ToString(), True), ChartAccumulationLabelStyle)
            End If
            If comboBox1.SelectedIndex = 3 OrElse comboBox1.SelectedIndex = 2 Then
                Me.comboBox2.Enabled = True
                Me.comboBox2.Items.Clear()
                comboBox2.Items.Add("Right")
                comboBox2.Items.Add("Left")
                Me.comboBox2.SelectedIndex = 1
            End If
            If comboBox1.SelectedIndex = 1 Then
                Me.comboBox2.Enabled = True
                Me.comboBox2.Items.Clear()
                comboBox2.Items.Add("Top")
                comboBox2.Items.Add("Bottom")
                comboBox2.Items.Add("Center")
                Me.comboBox2.SelectedIndex = 2
            End If
            If comboBox1.SelectedIndex = 0 Then
                Me.comboBox2.Enabled = False
            End If
        End Sub

        Private Sub comboBox3_SelectedIndexChanged_1(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox3.SelectedIndexChanged
            If comboBox5.SelectedIndex = 0 Then
                Me.chartControl1.Series(0).ConfigItems.PyramidItem.GapRatio = Convert.ToSingle(comboBox3.SelectedItem.ToString())
            Else
                Me.chartControl1.Series(0).ConfigItems.FunnelItem.GapRatio = Convert.ToSingle(comboBox3.SelectedItem.ToString())
            End If
        End Sub

        Private Sub comboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox4.SelectedIndexChanged
            Me.chartControl1.Series(0).Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBox5.SelectedItem.ToString(), True), ChartSeriesType)
            If comboBox5.SelectedIndex = 0 Then
                Me.chartControl1.Series(0).ConfigItems.PyramidItem.FigureBase = CType(System.Enum.Parse(GetType(ChartFigureBase), Me.comboBox4.SelectedItem.ToString(), True), ChartFigureBase)
            Else
                Me.chartControl1.Series(0).ConfigItems.FunnelItem.FigureBase = CType(System.Enum.Parse(GetType(ChartFigureBase), Me.comboBox4.SelectedItem.ToString(), True), ChartFigureBase)
            End If
        End Sub

        Private Sub comboBox5_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox5.SelectedIndexChanged
            Me.chartControl1.Series(0).Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBox5.SelectedItem.ToString(), True), ChartSeriesType)
            If comboBox5.SelectedIndex = 0 Then
                Me.chartControl1.Series(0).ConfigItems.PyramidItem.LabelStyle = CType(System.Enum.Parse(GetType(ChartAccumulationLabelStyle), Me.comboBox1.SelectedItem.ToString(), True), ChartAccumulationLabelStyle)
            Else
                Me.chartControl1.Series(0).ConfigItems.FunnelItem.LabelStyle = CType(System.Enum.Parse(GetType(ChartAccumulationLabelStyle), Me.comboBox1.SelectedItem.ToString(), True), ChartAccumulationLabelStyle)
            End If
            Me.comboBox2_SelectedIndexChanged(comboBox2, EventArgs.Empty)
            ChangePointGap()
        End Sub
        Private Sub ChangePointGap()
            If comboBox5.SelectedIndex = 0 Then
                Me.chartControl1.Series(0).ConfigItems.PyramidItem.GapRatio = Convert.ToSingle(comboBox3.SelectedItem.ToString())
            Else
                Me.chartControl1.Series(0).ConfigItems.FunnelItem.GapRatio = Convert.ToSingle(comboBox3.SelectedItem.ToString())
            End If
        End Sub
        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            Me.chartControl1.Series3D = Me.checkBox1.Checked
            Me.label4.Enabled = Me.checkBox1.Checked
            Me.comboBox4.Enabled = Me.checkBox1.Checked
        End Sub

#End Region
    End Class
End Namespace