Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Windows.Forms

Namespace BubbleAndScatterChart
    Public Class Form1
        Inherits Office2007Form
#Region "Private Members"
        Private panel1 As System.Windows.Forms.Panel
        Private label1 As System.Windows.Forms.Label
        Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
        Private label2 As System.Windows.Forms.Label
        Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
        Private label3 As System.Windows.Forms.Label
        Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
        Private label4 As System.Windows.Forms.Label
        Private WithEvents comboBox3 As System.Windows.Forms.ComboBox
        Private label9 As Label
        Private label5 As Label
        Private chartControl1 As ChartControl
        Private imageListAdv1 As Syncfusion.Windows.Forms.Tools.ImageListAdv
        Private groupBox1 As GroupBox
        Private groupBox2 As GroupBox
        Private components As System.ComponentModel.IContainer
        Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox



#End Region

#Region "Dispose"
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.panel1 = New System.Windows.Forms.Panel
            Me.CheckBox1 = New System.Windows.Forms.CheckBox
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.label3 = New System.Windows.Forms.Label
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.label2 = New System.Windows.Forms.Label
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.label4 = New System.Windows.Forms.Label
            Me.comboBox3 = New System.Windows.Forms.ComboBox
            Me.label5 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.label9 = New System.Windows.Forms.Label
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.imageListAdv1 = New Syncfusion.Windows.Forms.Tools.ImageListAdv(Me.components)
            Me.panel1.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.CheckBox1)
            Me.panel1.Controls.Add(Me.groupBox2)
            Me.panel1.Controls.Add(Me.groupBox1)
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.label9)
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(406, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(182, 409)
            Me.panel1.TabIndex = 1
            '
            'CheckBox1
            '
            Me.CheckBox1.AutoSize = True
            Me.CheckBox1.Location = New System.Drawing.Point(19, 13)
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Size = New System.Drawing.Size(76, 17)
            Me.CheckBox1.TabIndex = 7
            Me.CheckBox1.Text = "Enable 3D"
            Me.CheckBox1.UseVisualStyleBackColor = True
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.numericUpDown1)
            Me.groupBox2.Controls.Add(Me.label3)
            Me.groupBox2.Controls.Add(Me.comboBox2)
            Me.groupBox2.Controls.Add(Me.label2)
            Me.groupBox2.Location = New System.Drawing.Point(24, 250)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(140, 149)
            Me.groupBox2.TabIndex = 6
            Me.groupBox2.TabStop = False
            '
            'numericUpDown1
            '
            Me.numericUpDown1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.numericUpDown1.Location = New System.Drawing.Point(9, 115)
            Me.numericUpDown1.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.Enabled = False
            Me.numericUpDown1.Size = New System.Drawing.Size(88, 20)
            Me.numericUpDown1.TabIndex = 5
            Me.numericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'label3
            '
            Me.label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label3.Location = New System.Drawing.Point(6, 96)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(100, 16)
            Me.label3.TabIndex = 4
            Me.label3.Text = "Spline Tension"
            '
            'comboBox2
            '
            Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox2.Location = New System.Drawing.Point(9, 43)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(88, 21)
            Me.comboBox2.TabIndex = 3
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Location = New System.Drawing.Point(6, 20)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(128, 16)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Scatter Connected Type"
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.comboBox3)
            Me.groupBox1.Location = New System.Drawing.Point(20, 154)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(144, 90)
            Me.groupBox1.TabIndex = 5
            Me.groupBox1.TabStop = False
            '
            'label4
            '
            Me.label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label4.Location = New System.Drawing.Point(11, 16)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(100, 15)
            Me.label4.TabIndex = 6
            Me.label4.Text = "Bubble Type"
            '
            'comboBox3
            '
            Me.comboBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox3.Location = New System.Drawing.Point(14, 43)
            Me.comboBox3.Name = "comboBox3"
            Me.comboBox3.Size = New System.Drawing.Size(121, 21)
            Me.comboBox3.TabIndex = 7
            '
            'label5
            '
            Me.label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label5.Location = New System.Drawing.Point(17, 80)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(160, 1)
            Me.label5.TabIndex = 4
            '
            'label1
            '
            Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.Black
            Me.label1.Location = New System.Drawing.Point(15, 97)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(64, 13)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Chart Type"
            '
            'label9
            '
            Me.label9.BackColor = System.Drawing.Color.Transparent
            Me.label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label9.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label9.Image = CType(resources.GetObject("label9.Image"), System.Drawing.Image)
            Me.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label9.Location = New System.Drawing.Point(14, 60)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(163, 17)
            Me.label9.TabIndex = 2
            Me.label9.Text = "Bubble and Scatter Chart"
            Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'comboBox1
            '
            Me.comboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox1.Items.AddRange(New Object() {"Bubble", "Scatter"})
            Me.comboBox1.Location = New System.Drawing.Point(19, 119)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(88, 21)
            Me.comboBox1.TabIndex = 1
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(193, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(6, 6, 15, 6)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.Transparent, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer)))
            Me.chartControl1.ElementsSpacing = 0
            Me.chartControl1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            '
            '
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent
            Me.chartControl1.Legend.Location = New System.Drawing.Point(277, 216)
            Me.chartControl1.Legend.Visible = False
            Me.chartControl1.Location = New System.Drawing.Point(13, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Pastel
            Me.chartControl1.Size = New System.Drawing.Size(396, 373)
            Me.chartControl1.TabIndex = 2
            Me.chartControl1.Text = "Essential Chart"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Essential Chart"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'imageListAdv1
            '
            Me.imageListAdv1.Images.AddRange(New System.Drawing.Image() {CType(resources.GetObject("imageListAdv1.Images"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images1"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images2"), System.Drawing.Image)})
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(588, 409)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Bubble and Scatter Charts"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.groupBox2.ResumeLayout(False)
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Main & Constructor"
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New Form1())
        End Sub
        Public Sub New()
            InitializeComponent()
        End Sub
#End Region

#Region "FormLoad"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            FillControlPanel()
            IntializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)

            Me.comboBox1.SelectedIndex = 0
            Me.comboBox2.Enabled = False
            Me.numericUpDown1.Enabled = False
        End Sub
#End Region

#Region "FillControlPanel"
        Protected Sub FillControlPanel()
            For Each connect As String In System.Enum.GetNames(GetType(Syncfusion.Windows.Forms.Chart.ScatterConnectType))
                Me.comboBox2.Items.Add(connect)
            Next connect
            Me.comboBox2.SelectedIndex = 0

            For Each type As String In System.Enum.GetNames(GetType(Syncfusion.Windows.Forms.Chart.ChartBubbleType))
                Me.comboBox3.Items.Add(type)
            Next type
            Me.comboBox3.SelectedIndex = 0
        End Sub
#End Region

#Region "IntializeChartData"
        Private Sub IntializeChartData()
            Dim series1 As ChartSeries = New ChartSeries("Technology AAA", ChartSeriesType.Bubble)
            series1.Text = series1.Name
            series1.Points.Add(500, 356, 3)
            series1.Points.Add(1000, 491, 4)
            series1.Points.Add(1500, 382, 3)
            series1.Points.Add(2000, 437, 3)
            series1.Points.Add(2500, 351, 4)
            series1.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)

            Dim series2 As ChartSeries = New ChartSeries("Technology BBB", ChartSeriesType.Bubble)
            series2.Text = series2.Name
            series2.Points.Add(500, 175, 4)
            series2.Points.Add(1000, 291, 3)
            series2.Points.Add(1500, 182, 2)
            series2.Points.Add(2000, 237, 4)
            series2.Points.Add(2500, 151, 4)
            series2.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            Me.chartControl1.Legend.Visible = False

            Dim series3 As ChartSeries = New ChartSeries("Technology BBB", ChartSeriesType.Bubble)
            series3.Text = series3.Name
            series3.Points.Add(500, 250, 5)
            series3.Points.Add(1000, 391, 2)
            series3.Points.Add(1500, 282, 4)
            series3.Points.Add(2000, 387, 2)
            series3.Points.Add(2500, 251, 4)
            series3.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)

            Me.chartControl1.Series.Add(series1)
            Me.chartControl1.Series.Add(series3)
            Me.chartControl1.Series.Add(series2)

        End Sub
#End Region

#Region "Chart Type"
        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
            If comboBox1.SelectedItem.ToString() = "Bubble" Then
                For i As Integer = 0 To 2
                    Me.chartControl1.Series(i).Type = ChartSeriesType.Bubble
                Next i

                Me.chartControl1.PrimaryYAxis.Range.Min = 100
                Me.chartControl1.Redraw(True)

                Me.comboBox3.Enabled = True
                Me.comboBox2.Enabled = False
                Me.groupBox2.Visible = False
                Me.groupBox1.Visible = True
            ElseIf (comboBox1.SelectedItem.ToString() = "Scatter") Then
                For i As Integer = 0 To 2
                    Me.chartControl1.Series(i).Type = ChartSeriesType.Scatter
                Next i
                Me.chartControl1.Series(0).Style.Symbol.Color = Color.FromArgb(185, 247, 179, 78)
                Me.chartControl1.Series(1).Style.Symbol.Color = Color.FromArgb(185, 73, 141, 238)
                Me.chartControl1.Series(2).Style.Symbol.Color = Color.FromArgb(180, 150, 0, 50)

                Me.chartControl1.Redraw(True)
                Me.comboBox3.Enabled = False
                Me.comboBox2.Enabled = True
                Me.groupBox1.Visible = False
                Me.groupBox2.Location = New Point(20, 154)
                Me.groupBox2.Visible = True

            End If

        End Sub

#End Region

#Region "Helper Methods"
        Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox2.SelectedIndexChanged
            If Me.comboBox2.SelectedItem.ToString() = "Spline" Then
                Me.numericUpDown1.Enabled = True
            Else
                Me.numericUpDown1.Enabled = False
            End If

            If (Me.comboBox2.SelectedItem.ToString() = "Line") Then
                For i As Integer = 0 To 2
                    Me.chartControl1.Series(i).ScatterConnectType = ScatterConnectType.Line
                Next i
                Me.numericUpDown1.Value = 1
            ElseIf (Me.comboBox2.SelectedItem.ToString() = "Spline") Then
                For i As Integer = 0 To 2
                    Me.chartControl1.Series(i).ScatterConnectType = ScatterConnectType.Spline
                    Me.chartControl1.Series(i).ScatterSplineTension = Convert.ToDouble(numericUpDown1.Value)
                Next i


            Else
                Try
                    For i As Integer = 0 To 2
                        Me.chartControl1.Series(i).ScatterConnectType = ScatterConnectType.None
                    Next i
                Catch ex As Exception
                End Try
            End If

        End Sub

        Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
            If (Me.numericUpDown1.Enabled) Then
                If (comboBox1.SelectedItem.ToString() = "Scatter") AndAlso (Me.comboBox2.SelectedItem.ToString() = "Spline") Then
                    For i As Integer = 0 To 2
                        Me.chartControl1.Series(i).ScatterSplineTension = Convert.ToDouble(numericUpDown1.Value)
                    Next i

                End If
            End If
        End Sub

        Private Sub comboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox3.SelectedIndexChanged
            If Me.comboBox3.SelectedItem.ToString() = "Image" Then

                Me.chartControl1.Series(0).ConfigItems.BubbleItem.BubbleType = CType(System.Enum.Parse(GetType(ChartBubbleType), Me.comboBox3.SelectedItem.ToString(), True), ChartBubbleType)
                Me.chartControl1.Series(0).Style.ImageIndex = 0
                Me.chartControl1.Series(1).ConfigItems.BubbleItem.BubbleType = CType(System.Enum.Parse(GetType(ChartBubbleType), Me.comboBox3.SelectedItem.ToString(), True), ChartBubbleType)
                Me.chartControl1.Series(1).Style.ImageIndex = 1
                Me.chartControl1.Series(2).ConfigItems.BubbleItem.BubbleType = CType(System.Enum.Parse(GetType(ChartBubbleType), Me.comboBox3.SelectedItem.ToString(), True), ChartBubbleType)
                Me.chartControl1.Series(2).Style.ImageIndex = 2

            Else
                Try
                    Me.chartControl1.Series(0).ConfigItems.BubbleItem.BubbleType = CType(System.Enum.Parse(GetType(ChartBubbleType), Me.comboBox3.SelectedItem.ToString(), True), ChartBubbleType)
                    Me.chartControl1.Series(1).ConfigItems.BubbleItem.BubbleType = CType(System.Enum.Parse(GetType(ChartBubbleType), Me.comboBox3.SelectedItem.ToString(), True), ChartBubbleType)
                    Me.chartControl1.Series(2).ConfigItems.BubbleItem.BubbleType = CType(System.Enum.Parse(GetType(ChartBubbleType), Me.comboBox3.SelectedItem.ToString(), True), ChartBubbleType)

                Catch ex As Exception

                End Try
            End If
        End Sub
        Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
            Me.chartControl1.Series3D = CheckBox1.Checked
        End Sub
#End Region
    End Class
End Namespace
