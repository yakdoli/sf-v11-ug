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


Namespace LineChart2002
    Public Class Form1 : Inherits Office2007Form

#Region " Private Members "

        Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private panel1 As System.Windows.Forms.Panel
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private WithEvents comboBoxChartType As System.Windows.Forms.ComboBox
        Private label2 As System.Windows.Forms.Label
        Private label1 As System.Windows.Forms.Label
        Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
        Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
        Private label3 As System.Windows.Forms.Label
        Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
        Private WithEvents radioButton2 As System.Windows.Forms.RadioButton

        Private count As Integer = 0
        Private WithEvents label21 As System.Windows.Forms.Label
        Private WithEvents label22 As System.Windows.Forms.Label
        Private WithEvents CheckBox2 As System.Windows.Forms.CheckBox
        Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents imageList1 As System.Windows.Forms.ImageList
        Private WithEvents RadioButton3 As System.Windows.Forms.RadioButton
        Private components As System.ComponentModel.IContainer

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
#End Region

#Region " Constructor, Main And Dispose "
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide

            '
            ' DONE - TODO: Add any constructor code after InitializeComponent call
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
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel1 = New System.Windows.Forms.Panel
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.CheckBox2 = New System.Windows.Forms.CheckBox
            Me.label4 = New System.Windows.Forms.Label
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.radioButton2 = New System.Windows.Forms.RadioButton
            Me.label21 = New System.Windows.Forms.Label
            Me.label22 = New System.Windows.Forms.Label
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.comboBoxChartType = New System.Windows.Forms.ComboBox
            Me.label2 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.label3 = New System.Windows.Forms.Label
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.RadioButton3 = New System.Windows.Forms.RadioButton
            Me.panel1.SuspendLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(5, 15, 15, 5)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(229, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(250, Byte), Integer)))
            Me.chartControl1.ElementsSpacing = 1
            Me.chartControl1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            '
            '
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.Legend.ItemsSize = New System.Drawing.Size(15, 15)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(36, 53)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.Legend.Spacing = 3
            Me.chartControl1.Location = New System.Drawing.Point(12, 10)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.Silver
            Me.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.DarkGray
            Me.chartControl1.PrimaryYAxis.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.Silver
            Me.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.DarkGray
            Me.chartControl1.Rotation = 90.0!
            Me.chartControl1.Size = New System.Drawing.Size(479, 398)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "EssentialChart"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "EssentialChart"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.panel1.Controls.Add(Me.RadioButton3)
            Me.panel1.Controls.Add(Me.comboBox2)
            Me.panel1.Controls.Add(Me.CheckBox2)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.radioButton1)
            Me.panel1.Controls.Add(Me.radioButton2)
            Me.panel1.Controls.Add(Me.label21)
            Me.panel1.Controls.Add(Me.label22)
            Me.panel1.Controls.Add(Me.checkBox1)
            Me.panel1.Controls.Add(Me.comboBoxChartType)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Controls.Add(Me.numericUpDown1)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(507, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(171, 420)
            Me.panel1.TabIndex = 3
            '
            'comboBox2
            '
            Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox2.Location = New System.Drawing.Point(16, 192)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(104, 21)
            Me.comboBox2.TabIndex = 13
            '
            'CheckBox2
            '
            Me.CheckBox2.Location = New System.Drawing.Point(16, 332)
            Me.CheckBox2.Name = "CheckBox2"
            Me.CheckBox2.Size = New System.Drawing.Size(90, 32)
            Me.CheckBox2.TabIndex = 10
            Me.CheckBox2.Text = "Enable 3D"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(13, 166)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(145, 13)
            Me.label4.TabIndex = 12
            Me.label4.Text = "Legend Representation Type"
            '
            'radioButton1
            '
            Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton1.Location = New System.Drawing.Point(13, 98)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(96, 16)
            Me.radioButton1.TabIndex = 0
            Me.radioButton1.Text = "Italy"
            '
            'radioButton2
            '
            Me.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton2.Location = New System.Drawing.Point(13, 122)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(96, 16)
            Me.radioButton2.TabIndex = 1
            Me.radioButton2.Text = "Spain"
            '
            'label21
            '
            Me.label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label21.Location = New System.Drawing.Point(10, 81)
            Me.label21.Name = "label21"
            Me.label21.Size = New System.Drawing.Size(125, 1)
            Me.label21.TabIndex = 9
            '
            'label22
            '
            Me.label22.AutoSize = True
            Me.label22.BackColor = System.Drawing.Color.Transparent
            Me.label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label22.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label22.Location = New System.Drawing.Point(8, 65)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(76, 14)
            Me.label22.TabIndex = 8
            Me.label22.Text = "Chart Series"
            '
            'checkBox1
            '
            Me.checkBox1.Location = New System.Drawing.Point(16, 370)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(144, 32)
            Me.checkBox1.TabIndex = 7
            Me.checkBox1.Text = "Points in different Color"
            '
            'comboBoxChartType
            '
            Me.comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxChartType.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBoxChartType.Location = New System.Drawing.Point(13, 33)
            Me.comboBoxChartType.Name = "comboBoxChartType"
            Me.comboBoxChartType.Size = New System.Drawing.Size(104, 21)
            Me.comboBoxChartType.TabIndex = 6
            '
            'label2
            '
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label2.Location = New System.Drawing.Point(16, 287)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(88, 16)
            Me.label2.TabIndex = 5
            Me.label2.Text = "Width"
            '
            'label1
            '
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label1.Location = New System.Drawing.Point(16, 230)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(100, 16)
            Me.label1.TabIndex = 4
            Me.label1.Text = "DashStyle"
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox1.Location = New System.Drawing.Point(16, 254)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(104, 21)
            Me.comboBox1.TabIndex = 3
            '
            'numericUpDown1
            '
            Me.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.numericUpDown1.Location = New System.Drawing.Point(16, 306)
            Me.numericUpDown1.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
            Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.ReadOnly = True
            Me.numericUpDown1.Size = New System.Drawing.Size(104, 20)
            Me.numericUpDown1.TabIndex = 2
            Me.numericUpDown1.Value = New Decimal(New Integer() {3, 0, 0, 0})
            '
            'label3
            '
            Me.label3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label3.Location = New System.Drawing.Point(13, 10)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(100, 16)
            Me.label3.TabIndex = 5
            Me.label3.Text = "ChartType"
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "server_from_client.png")
            '
            'RadioButton3
            '
            Me.RadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.RadioButton3.Location = New System.Drawing.Point(13, 144)
            Me.RadioButton3.Name = "RadioButton3"
            Me.RadioButton3.Size = New System.Drawing.Size(96, 16)
            Me.RadioButton3.TabIndex = 14
            Me.RadioButton3.Text = "France"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(678, 420)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.chartControl1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Line Charts"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region " Form Load "
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.comboBoxChartType.Items.Add(ChartSeriesType.Line)
            Me.comboBoxChartType.Items.Add(ChartSeriesType.Spline)
            Me.comboBoxChartType.Items.Add(ChartSeriesType.StepLine)
            Me.comboBoxChartType.Items.Add(ChartSeriesType.RotatedSpline)
            Me.comboBoxChartType.SelectedIndex = 1
            InitializeChartData()
            FillControlPanel()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region " Helper Methods "

#Region " InitializeChartData "
        Protected Sub InitializeChartData()
            Dim series1 As ChartSeries = New ChartSeries("Italy")
            series1.Text = series1.Name
            series1.Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBoxChartType.SelectedItem.ToString(), True), ChartSeriesType)

            Dim points1 As Double() = {2, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2}
            Dim i As Integer = 0
            Dim j As Integer = 1985
            Do While j < 2003 AndAlso i < 16
                series1.Points.Add(j, points1(i))
                j += 1
                i += 1
            Loop
            Me.chartControl1.Series.Add(series1)

            Dim series2 As ChartSeries = New ChartSeries("Spain")
            series2.Text = series2.Name
            series2.Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBoxChartType.SelectedItem.ToString(), True), ChartSeriesType)

            i = 0
            Dim points2 As Double() = {8, 5, 4, 4, 3, 3, 3, 3, 4, 5, 4, 3, 2, 3, 2, 1}

            Dim k As Integer = 1985
            Do While k < 2003 AndAlso i < 16
                series2.Points.Add(k, points2(i))
                k += 1
                i += 1
            Loop
            Me.chartControl1.Series.Add(series2)


            Dim series3 As ChartSeries = New ChartSeries("France")
            series3.Text = series3.Name
            series3.Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBoxChartType.SelectedItem.ToString(), True), ChartSeriesType)

            i = 0
            Dim points3 As Double() = {11, 15, 14, 10, 11, 6, 4, 6, 2, 2, 2, 2, 3, 4, 4, 4}

            Dim l As Integer = 1985
            Do While l < 2003 AndAlso i < 16
                series3.Points.Add(l, points3(i))
                l += 1
                i += 1
            Loop

            Me.chartControl1.Series.Add(series3)
            series2.Style.Images = New ChartImageCollection(Me.imageList1.Images)
            series2.Style.ImageIndex = 0
            series1.Style.Images = New ChartImageCollection(Me.imageList1.Images)
            series1.Style.ImageIndex = 0
            series3.Style.Images = New ChartImageCollection(Me.imageList1.Images)
            series3.Style.ImageIndex = 0
        End Sub

#End Region

#Region " FillControlPanel "
        Protected Sub FillControlPanel()
            Dim linetype As String
            For Each linetype In System.Enum.GetNames(GetType(System.Drawing.Drawing2D.DashStyle))
                Me.comboBox1.Items.Add(linetype)
            Next linetype
            Me.comboBox1.SelectedIndex = 0
            For Each representationtype As String In System.Enum.GetNames(GetType(Syncfusion.Windows.Forms.Chart.ChartLegendRepresentationType))
                Me.comboBox2.Items.Add(representationtype)
            Next representationtype
            Me.comboBox2.SelectedIndex = 5
        End Sub

#End Region

#End Region

#Region " Events "
        Private Sub series_PrepareStyle(ByVal sender As Object, ByVal args As ChartPrepareStyleInfoEventArgs)
            Dim series As ChartSeries = TryCast(sender, ChartSeries)
            If Not series Is Nothing Then
                If Me.chartControl1.Series(0).Type.ToString() = "Line" Then
                    If args.Index = 0 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Red)
                    ElseIf args.Index = 1 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Green)
                    ElseIf args.Index = 2 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Blue)
                    ElseIf args.Index = 3 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Yellow)
                    ElseIf args.Index = 4 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Violet)
                    ElseIf args.Index = 5 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.BlanchedAlmond)
                    ElseIf args.Index = 6 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Brown)
                    ElseIf args.Index = 7 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Aqua)
                    ElseIf args.Index = 8 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Red)
                    ElseIf args.Index = 9 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Green)
                    ElseIf args.Index = 10 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Blue)
                    ElseIf args.Index = 11 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Yellow)
                    ElseIf args.Index = 12 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Violet)
                    ElseIf args.Index = 13 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.BlanchedAlmond)
                    ElseIf args.Index = 14 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Brown)
                    ElseIf args.Index = 15 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Aqua)
                    ElseIf args.Index = 16 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Red)
                    ElseIf args.Index = 17 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Green)
                    ElseIf args.Index = 18 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Blue)
                    ElseIf args.Index = 19 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Yellow)
                    ElseIf args.Index = 20 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Violet)
                    ElseIf args.Index = 21 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.BlanchedAlmond)
                    ElseIf args.Index = 22 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Brown)
                    ElseIf args.Index = 23 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Aqua)
                    ElseIf args.Index = 24 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Red)
                    ElseIf args.Index = 25 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Green)
                    ElseIf args.Index = 26 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Blue)
                    ElseIf args.Index = 27 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Yellow)
                    ElseIf args.Index = 28 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Violet)
                    ElseIf args.Index = 29 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.BlanchedAlmond)
                    ElseIf args.Index = 30 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Brown)
                    ElseIf args.Index = 31 Then
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.Red)
                    End If

                End If
            End If
        End Sub

        Private Sub comboBoxChartType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxChartType.SelectedIndexChanged
            Dim i As Integer = 0
            Do While i < Me.chartControl1.Series.Count
                Me.chartControl1.Series(i).Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBoxChartType.SelectedItem.ToString(), True), ChartSeriesType)
                Me.chartControl1.Series(i).Style.Border.Width = CSng(Me.numericUpDown1.Value)
                i += 1
            Loop

            If (Me.comboBoxChartType.Text = "Line") Then
                Me.checkBox1.Visible = True
                Me.chartControl1.Redraw(True)
            End If
            If (Me.comboBoxChartType.Text = "Spline") Then
                Me.checkBox1.Visible = False
                Me.chartControl1.Redraw(True)
            End If

            If Me.comboBoxChartType.Text = "RotatedSpline" Then
                Me.checkBox1.Visible = False
                Me.chartControl1.Series(0).Type = ChartSeriesType.RotatedSpline
                Me.chartControl1.Series(1).Type = ChartSeriesType.RotatedSpline
                count = count + 1
                Me.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
                Me.chartControl1.PrimaryYAxis.Range = New MinMaxInfo(1985, 2000, 2)
                Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
                Me.chartControl1.PrimaryXAxis.Range = New MinMaxInfo(0, 16, 2)
                Me.chartControl1.PrimaryXAxis.Title = "Rank"
                Me.chartControl1.PrimaryYAxis.Title = "Year"

            Else
                Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
                Me.chartControl1.PrimaryXAxis.Range = New MinMaxInfo(1985, 2000, 1)
                Me.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
                Me.chartControl1.PrimaryYAxis.Range = New MinMaxInfo(0, 16, 2)
                Me.chartControl1.PrimaryXAxis.Title = "Year"
                Me.chartControl1.PrimaryYAxis.Title = "Rank"

            End If

            If (count = 1 OrElse count > 1) AndAlso Not (Me.comboBoxChartType.Text = "RotatedSpline") Then

                If Me.radioButton1.Checked Then
                    Me.chartControl1.Series(0).Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBoxChartType.SelectedItem.ToString(), True), ChartSeriesType)
                End If
                If Me.radioButton2.Checked Then
                    Me.chartControl1.Series(1).Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBoxChartType.SelectedItem.ToString(), True), ChartSeriesType)
                End If

                If Me.checkBox1.Checked Then
                    AddHandler chartControl1.Series(0).PrepareStyle, AddressOf series_PrepareStyle
                    AddHandler chartControl1.Series(1).PrepareStyle, AddressOf series_PrepareStyle
                End If
            End If

            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub radiobutton1_SeriesType_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton1.CheckedChanged

            Me.chartControl1.Series(0).Style.Border.Width = CSng(Me.numericUpDown1.Value)
            Me.chartControl1.Series(0).Style.Border.DashStyle = CType(System.Enum.Parse(GetType(DashStyle), Me.comboBox1.SelectedItem.ToString(), True), DashStyle)
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub radiobutton2_SeriesType_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton2.CheckedChanged
            Me.chartControl1.Series(1).Style.Border.Width = CSng(Me.numericUpDown1.Value)
            Me.chartControl1.Series(1).Style.Border.DashStyle = CType(System.Enum.Parse(GetType(DashStyle), Me.comboBox1.SelectedItem.ToString(), True), DashStyle)
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
            If Me.radioButton1.Checked Then
                Me.chartControl1.Series(0).Style.Border.DashStyle = CType(System.Enum.Parse(GetType(DashStyle), Me.comboBox1.SelectedItem.ToString(), True), DashStyle)
            ElseIf Me.radioButton2.Checked Then
                Me.chartControl1.Series(1).Style.Border.DashStyle = CType(System.Enum.Parse(GetType(DashStyle), Me.comboBox1.SelectedItem.ToString(), True), DashStyle)
            ElseIf Me.RadioButton3.Checked Then
                Me.chartControl1.Series(2).Style.Border.DashStyle = CType(System.Enum.Parse(GetType(DashStyle), Me.comboBox1.SelectedItem.ToString(), True), DashStyle)
            End If
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
            If Me.radioButton1.Checked Then
                Me.chartControl1.Series(0).Style.Border.Width = CSng(Me.numericUpDown1.Value)
            ElseIf Me.radioButton2.Checked Then
                Me.chartControl1.Series(1).Style.Border.Width = CSng(Me.numericUpDown1.Value)
            ElseIf Me.RadioButton3.Checked Then
                Me.chartControl1.Series(2).Style.Border.Width = CSng(Me.numericUpDown1.Value)
            End If
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            If Me.checkBox1.Checked Then
                Me.chartControl1.Series(0).EnableStyles = True
                Me.chartControl1.Series(1).EnableStyles = True
                Me.chartControl1.Series(2).EnableStyles = True
                AddHandler chartControl1.Series(2).PrepareStyle, AddressOf series_PrepareStyle
                AddHandler chartControl1.Series(0).PrepareStyle, AddressOf series_PrepareStyle
                AddHandler chartControl1.Series(1).PrepareStyle, AddressOf series_PrepareStyle
            Else
                Me.chartControl1.Series(0).EnableStyles = False
                Me.chartControl1.Series(1).EnableStyles = False
            End If

            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
            Me.chartControl1.Series3D = CheckBox2.Checked
        End Sub

        Private Sub comboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBox2.SelectedIndexChanged
            Me.chartControl1.Legend.RepresentationType = CType(System.Enum.Parse(GetType(ChartLegendRepresentationType), Me.comboBox2.SelectedItem.ToString(), True), ChartLegendRepresentationType)
        End Sub

        Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
            Me.chartControl1.Series(2).Style.Border.Width = CSng(Me.numericUpDown1.Value)
            Me.chartControl1.Series(2).Style.Border.DashStyle = CType(System.Enum.Parse(GetType(DashStyle), Me.comboBox1.SelectedItem.ToString(), True), DashStyle)
            Me.chartControl1.Redraw(True)
        End Sub
#End Region
    End Class
End Namespace
