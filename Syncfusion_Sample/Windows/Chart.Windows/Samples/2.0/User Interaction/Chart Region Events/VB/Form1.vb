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
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing

Namespace Syncfusion.Windows.Forms.Chart.Samples
	Public Class Form1
		Inherits Syncfusion.Windows.Forms.Office2007Form
		#Region "Private Members"
		Private textBox1 As TextBox
		Private WithEvents btnClearLog As Button
		Private chkRegionClick As CheckBox
		Private chkMouseDown As CheckBox
		Private chkMouseUp As CheckBox
		Private chkMouseHover As CheckBox
		Private chkMouseLeave As CheckBox
		Private chkMouseEnter As CheckBox
		Private chkMouseMove As CheckBox
		Private WithEvents chartControl1 As ChartControl
		Private label1 As Label
		Private label12 As Label
		Private chartControl2 As ChartControl
		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private gradientPanel4 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private panel1 As Panel
        Private color1 As Color() = New Color() {Color.FromArgb(132, 101, 173), Color.FromArgb(46, 238, 255), Color.FromArgb(132, 101, 173)}
        Friend WithEvents chkRegionDoubleClick As System.Windows.Forms.CheckBox
        Private components As IContainer
#End Region

#Region "Form's Constructor, Main And Dispose"
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
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
            Me.chartControl2 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.label1 = New System.Windows.Forms.Label
            Me.label12 = New System.Windows.Forms.Label
            Me.btnClearLog = New System.Windows.Forms.Button
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.chkRegionClick = New System.Windows.Forms.CheckBox
            Me.chkMouseDown = New System.Windows.Forms.CheckBox
            Me.chkMouseUp = New System.Windows.Forms.CheckBox
            Me.chkMouseEnter = New System.Windows.Forms.CheckBox
            Me.chkMouseMove = New System.Windows.Forms.CheckBox
            Me.chkMouseLeave = New System.Windows.Forms.CheckBox
            Me.chkMouseHover = New System.Windows.Forms.CheckBox
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.chkRegionDoubleClick = New System.Windows.Forms.CheckBox
            Me.panel1 = New System.Windows.Forms.Panel
            Me.gradientPanel4 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel2.SuspendLayout()
            Me.panel1.SuspendLayout()
            CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel4.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl2
            '
            Me.chartControl2.AcceptFocus = False
            Me.chartControl2.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl2.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl2.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(5, 1, 1, 5)
            Me.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl2.Indexed = True
            '
            '
            '
            Me.chartControl2.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl2.Legend.Location = New System.Drawing.Point(267, 31)
            Me.chartControl2.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating
            Me.chartControl2.Legend.Visible = False
            Me.chartControl2.Location = New System.Drawing.Point(0, 0)
            Me.chartControl2.MinZoomFactorX = 0.00001
            Me.chartControl2.MinZoomFactorY = 0.00001
            Me.chartControl2.Name = "chartControl2"
            Me.chartControl2.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl2.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl2.Series3D = True
            Me.chartControl2.Size = New System.Drawing.Size(128, 128)
            Me.chartControl2.TabIndex = 111
            '
            '
            '
            Me.chartControl2.Title.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl2.Title.Margin = 1
            Me.chartControl2.Title.Name = "Def_title"
            Me.chartControl2.Title.Text = ""
            Me.chartControl2.Titles.Add(Me.chartControl2.Title)
            Me.chartControl2.ToolBar.Location = New System.Drawing.Point(0, 0)
            Me.chartControl2.ToolBar.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating
            Me.chartControl2.ZoomOutIncrement = 1.5
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Image = CType(resources.GetObject("label1.Image"), System.Drawing.Image)
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label1.Location = New System.Drawing.Point(4, 112)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(84, 18)
            Me.label1.TabIndex = 110
            Me.label1.Text = "Event Log"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label12
            '
            Me.label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label12.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label12.Image = CType(resources.GetObject("label12.Image"), System.Drawing.Image)
            Me.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label12.Location = New System.Drawing.Point(3, 3)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(177, 18)
            Me.label12.TabIndex = 109
            Me.label12.Text = "Turn On/Off event handlers"
            Me.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnClearLog
            '
            Me.btnClearLog.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnClearLog.ForeColor = System.Drawing.Color.MidnightBlue
            Me.btnClearLog.Location = New System.Drawing.Point(453, 317)
            Me.btnClearLog.Name = "btnClearLog"
            Me.btnClearLog.Size = New System.Drawing.Size(74, 24)
            Me.btnClearLog.TabIndex = 7
            Me.btnClearLog.Text = "Clear Log"
            '
            'textBox1
            '
            Me.textBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.textBox1.Location = New System.Drawing.Point(7, 137)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(520, 176)
            Me.textBox1.TabIndex = 2
            '
            'chkRegionClick
            '
            Me.chkRegionClick.AutoSize = True
            Me.chkRegionClick.Checked = True
            Me.chkRegionClick.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkRegionClick.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkRegionClick.Location = New System.Drawing.Point(7, 4)
            Me.chkRegionClick.Name = "chkRegionClick"
            Me.chkRegionClick.Size = New System.Drawing.Size(117, 18)
            Me.chkRegionClick.TabIndex = 6
            Me.chkRegionClick.Text = "ChartRegion Click"
            '
            'chkMouseDown
            '
            Me.chkMouseDown.AutoSize = True
            Me.chkMouseDown.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkMouseDown.Location = New System.Drawing.Point(7, 28)
            Me.chkMouseDown.Name = "chkMouseDown"
            Me.chkMouseDown.Size = New System.Drawing.Size(154, 18)
            Me.chkMouseDown.TabIndex = 0
            Me.chkMouseDown.Text = "ChartRegion MouseDown"
            '
            'chkMouseUp
            '
            Me.chkMouseUp.AutoSize = True
            Me.chkMouseUp.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkMouseUp.Location = New System.Drawing.Point(168, 80)
            Me.chkMouseUp.Name = "chkMouseUp"
            Me.chkMouseUp.Size = New System.Drawing.Size(140, 18)
            Me.chkMouseUp.TabIndex = 5
            Me.chkMouseUp.Text = "ChartRegion MouseUp"
            '
            'chkMouseEnter
            '
            Me.chkMouseEnter.AutoSize = True
            Me.chkMouseEnter.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkMouseEnter.Location = New System.Drawing.Point(7, 54)
            Me.chkMouseEnter.Name = "chkMouseEnter"
            Me.chkMouseEnter.Size = New System.Drawing.Size(151, 18)
            Me.chkMouseEnter.TabIndex = 1
            Me.chkMouseEnter.Text = "ChartRegion MouseEnter"
            '
            'chkMouseMove
            '
            Me.chkMouseMove.AutoSize = True
            Me.chkMouseMove.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkMouseMove.Location = New System.Drawing.Point(168, 54)
            Me.chkMouseMove.Name = "chkMouseMove"
            Me.chkMouseMove.Size = New System.Drawing.Size(153, 18)
            Me.chkMouseMove.TabIndex = 4
            Me.chkMouseMove.Text = "ChartRegion MouseMove"
            '
            'chkMouseLeave
            '
            Me.chkMouseLeave.AutoSize = True
            Me.chkMouseLeave.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkMouseLeave.Location = New System.Drawing.Point(168, 28)
            Me.chkMouseLeave.Name = "chkMouseLeave"
            Me.chkMouseLeave.Size = New System.Drawing.Size(156, 18)
            Me.chkMouseLeave.TabIndex = 3
            Me.chkMouseLeave.Text = "ChartRegion MouseLeave"
            '
            'chkMouseHover
            '
            Me.chkMouseHover.AutoSize = True
            Me.chkMouseHover.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkMouseHover.Location = New System.Drawing.Point(7, 80)
            Me.chkMouseHover.Name = "chkMouseHover"
            Me.chkMouseHover.Size = New System.Drawing.Size(155, 18)
            Me.chkMouseHover.TabIndex = 2
            Me.chkMouseHover.Text = "ChartRegion MouseHover"
            '
            'chartControl1
            '
            Me.chartControl1.AcceptFocus = False
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(239, Byte), Integer)))
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Indexed = True
            '
            '
            '
            Me.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(277, 146)
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.MinZoomFactorX = 0.00001
            Me.chartControl1.MinZoomFactorY = 0.00001
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.Size = New System.Drawing.Size(398, 299)
            Me.chartControl1.TabIndex = 8
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "chartControl1"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ToolBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(165, Byte), Integer))
            Me.chartControl1.ToolBar.ButtonBackColor = System.Drawing.SystemColors.ControlLight
            Me.chartControl1.ToolBar.ButtonForeColor = System.Drawing.SystemColors.ActiveBorder
            Me.chartControl1.ToolBar.ButtonSize = New System.Drawing.Size(26, 26)
            Me.chartControl1.ToolBar.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.ToolBar.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating
            Me.chartControl1.ZoomOutIncrement = 1.5
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BackColor = System.Drawing.Color.White
            Me.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel1.Controls.Add(Me.label12)
            Me.gradientPanel1.Location = New System.Drawing.Point(574, 62)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(182, 243)
            Me.gradientPanel1.TabIndex = 113
            '
            'gradientPanel2
            '
            Me.gradientPanel2.BackColor = System.Drawing.Color.White
            Me.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel2.Controls.Add(Me.chkRegionDoubleClick)
            Me.gradientPanel2.Controls.Add(Me.panel1)
            Me.gradientPanel2.Controls.Add(Me.chkRegionClick)
            Me.gradientPanel2.Controls.Add(Me.chkMouseLeave)
            Me.gradientPanel2.Controls.Add(Me.label1)
            Me.gradientPanel2.Controls.Add(Me.chkMouseMove)
            Me.gradientPanel2.Controls.Add(Me.chkMouseHover)
            Me.gradientPanel2.Controls.Add(Me.chkMouseUp)
            Me.gradientPanel2.Controls.Add(Me.textBox1)
            Me.gradientPanel2.Controls.Add(Me.btnClearLog)
            Me.gradientPanel2.Controls.Add(Me.chkMouseDown)
            Me.gradientPanel2.Controls.Add(Me.chkMouseEnter)
            Me.gradientPanel2.Location = New System.Drawing.Point(6, 316)
            Me.gradientPanel2.Name = "gradientPanel2"
            Me.gradientPanel2.Size = New System.Drawing.Size(533, 346)
            Me.gradientPanel2.TabIndex = 114
            '
            'chkRegionDoubleClick
            '
            Me.chkRegionDoubleClick.AutoSize = True
            Me.chkRegionDoubleClick.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chkRegionDoubleClick.Location = New System.Drawing.Point(168, 5)
            Me.chkRegionDoubleClick.Name = "chkRegionDoubleClick"
            Me.chkRegionDoubleClick.Size = New System.Drawing.Size(154, 18)
            Me.chkRegionDoubleClick.TabIndex = 114
            Me.chkRegionDoubleClick.Text = "ChartRegion Double Click"
            Me.chkRegionDoubleClick.UseVisualStyleBackColor = True
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.chartControl2)
            Me.panel1.Location = New System.Drawing.Point(400, 3)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(128, 128)
            Me.panel1.TabIndex = 113
            '
            'gradientPanel4
            '
            Me.gradientPanel4.BackColor = System.Drawing.Color.White
            Me.gradientPanel4.BorderColor = System.Drawing.Color.White
            Me.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel4.Controls.Add(Me.chartControl1)
            Me.gradientPanel4.Location = New System.Drawing.Point(71, 6)
            Me.gradientPanel4.Name = "gradientPanel4"
            Me.gradientPanel4.Size = New System.Drawing.Size(400, 301)
            Me.gradientPanel4.TabIndex = 116
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(545, 666)
            Me.Controls.Add(Me.gradientPanel4)
            Me.Controls.Add(Me.gradientPanel1)
            Me.Controls.Add(Me.gradientPanel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Region Events"
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel2.ResumeLayout(False)
            Me.gradientPanel2.PerformLayout()
            Me.panel1.ResumeLayout(False)
            CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel4.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
            ChartAppearance.ApplyChartStyles1(Me.chartControl2)
        End Sub
#End Region

#Region "Helper Methods"

#Region "InitializeChartData"
        Private Sub InitializeChartData()

            Dim c1series1 As ChartSeries = New ChartSeries()
            c1series1.Name = "Sales"
            c1series1.Type = ChartSeriesType.Column
            c1series1.Text = c1series1.Name
            c1series1.Points.Add(1, 256)
            c1series1.Points.Add(2, 491)
            c1series1.Points.Add(3, 382)
            c1series1.Points.Add(4, 437)
            Me.chartControl1.Series.Add(c1series1)

            Dim c2series1 As ChartSeries = New ChartSeries()
            c2series1.Name = "Sales"
            c2series1.Type = ChartSeriesType.Column
            c2series1.Text = c2series1.Name
            c2series1.Points.Add(1, 2)
            c2series1.Points.Add(2, 5)
            c2series1.Points.Add(3, 3)
            c2series1.Points.Add(4, 4)
            Me.chartControl2.Series.Add(c2series1)
        End Sub
#End Region

#Region "OutputText"
        Private Sub OutputText(ByVal output As String)
            Me.textBox1.Text += output & Constants.vbCrLf
            Me.textBox1.SelectionStart = Me.textBox1.Text.Length - 1
            Me.textBox1.SelectionLength = 0
            Me.textBox1.ScrollToCaret()
        End Sub
#End Region

#Region "ShowChartRegion"
        Protected Sub ShowChartRegion(ByVal regionName As String)
            Me.panel1.Visible = True
            If regionName = "ChartArea region" Then
                Me.chartControl2.Titles(0).Text = "Chart Area"
                Me.chartControl2.Series(0).Visible = False
                Me.chartControl2.ChartArea.RequireAxes = True
                Me.chartControl2.PrimaryXAxis.ValueType = ChartValueType.Custom
                Me.chartControl2.PrimaryYAxis.ValueType = ChartValueType.Custom
                Me.chartControl2.BackInterior = New Syncfusion.Drawing.BrushInfo(Color.White)
                Me.chartControl2.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Color.White)
                Me.chartControl2.ChartInterior = New Syncfusion.Drawing.BrushInfo(Color.White)

            ElseIf regionName = "Axes region" Then
                Me.chartControl2.Titles(0).Text = "Chart Axes"
                Me.chartControl2.Series(0).Visible = False
                Me.chartControl2.ChartArea.RequireAxes = True
                Me.chartControl2.PrimaryXAxis.ValueType = ChartValueType.Double
                Me.chartControl2.PrimaryYAxis.ValueType = ChartValueType.Double
                Me.chartControl2.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
                Me.chartControl2.PrimaryYAxis.Range = New MinMaxInfo(0, 6, 2)
                Me.chartControl2.BackInterior = New Syncfusion.Drawing.BrushInfo(Color.White)
                Me.chartControl2.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Color.White)
                Me.chartControl2.ChartInterior = New Syncfusion.Drawing.BrushInfo(Color.White)

            ElseIf regionName = "ChartSeries" Then
                Me.chartControl2.Titles(0).Text = "Chart Series"
                Me.chartControl2.Series(0).Visible = True
                Me.chartControl2.ChartArea.RequireAxes = False
                Me.chartControl2.BackInterior = New Syncfusion.Drawing.BrushInfo(Color.White)
                Me.chartControl2.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Color.White)
                Me.chartControl2.ChartInterior = New Syncfusion.Drawing.BrushInfo(Color.White)
            Else
                Me.chartControl2.Titles(0).Text = "Chart Control"
                Me.chartControl2.Series(0).Visible = False
                Me.chartControl2.ChartArea.RequireAxes = False
                Me.chartControl2.BackInterior = New Syncfusion.Drawing.BrushInfo(Color.White)
                Me.chartControl2.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Color.White)
                Me.chartControl2.ChartInterior = New Syncfusion.Drawing.BrushInfo(Color.White)
            End If
        End Sub
#End Region

#End Region

#Region "Events"
#Region "ChartRegionMouseDown"
        Private Sub chartControl1_ChartRegionMouseDown(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs) Handles chartControl1.ChartRegionMouseDown
            If Me.chkMouseDown.Checked Then
                If e.Region.SeriesIndex = 0 Then
                    OutputText(String.Format("MouseDown over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point))
                    ShowChartRegion("ChartSeries")
                Else
                    OutputText(String.Format("MouseDown over {0}", e.Region.Description.ToString()))
                    ShowChartRegion(e.Region.Description.ToString())
                End If
            End If
        End Sub
#End Region

#Region "ChartRegionMouseEnter"
        Private Sub chartControl1_ChartRegionMouseEnter(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs) Handles chartControl1.ChartRegionMouseEnter
            If Me.chkMouseEnter.Checked Then
                If e.Region.SeriesIndex = 0 Then
                    OutputText(String.Format("MouseEnter over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point))
                    ShowChartRegion("ChartSeries")
                Else
                    OutputText(String.Format("MouseEnter over  {0}", e.Region.Description.ToString()))
                    ShowChartRegion(e.Region.Description.ToString())
                End If
            End If
        End Sub
#End Region

#Region "ChartRegionMouseHover"
        Private Sub chartControl1_ChartRegionMouseHover(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs) Handles chartControl1.ChartRegionMouseHover
            If Me.chkMouseHover.Checked Then
                If e.Region.SeriesIndex = 0 Then
                    OutputText(String.Format("MouseHover over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point))
                    ShowChartRegion("ChartSeries")
                Else
                    OutputText(String.Format("MouseHover over {0}", e.Region.Description.ToString()))
                    ShowChartRegion(e.Region.Description.ToString())
                End If
            End If
        End Sub
#End Region

#Region "ChartRegionMouseLeave"
        Private Sub chartControl1_ChartRegionMouseLeave(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs) Handles chartControl1.ChartRegionMouseLeave
            If Me.chkMouseLeave.Checked Then
                If e.Region.SeriesIndex = 0 Then
                    OutputText(String.Format("MouseLeave over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point))
                    ShowChartRegion("ChartSeries")
                Else
                    OutputText(String.Format("MouseLeave over {0}", e.Region.Description.ToString()))
                    ShowChartRegion(e.Region.Description.ToString())
                End If
            End If
        End Sub
#End Region

#Region "ChartRegionMouseMove"
        Private Sub chartControl1_ChartRegionMouseMove(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs) Handles chartControl1.ChartRegionMouseMove
            If Me.chkMouseMove.Checked Then
                If e.Region.SeriesIndex = 0 Then
                    OutputText(String.Format("MouseMove over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point))
                    ShowChartRegion("ChartSeries")
                Else
                    OutputText(String.Format("MouseMove over {0}", e.Region.Description.ToString()))
                    ShowChartRegion(e.Region.Description.ToString())
                End If
            End If
        End Sub
#End Region

#Region "ChartRegionMouseUp"
        Private Sub chartControl1_ChartRegionMouseUp(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs) Handles chartControl1.ChartRegionMouseUp
            If Me.chkMouseUp.Checked Then
                If e.Region.SeriesIndex = 0 Then
                    OutputText(String.Format("MouseUp over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point))
                    ShowChartRegion("ChartSeries")
                Else
                    OutputText(String.Format("MouseUp over {0}", e.Region.Description.ToString()))
                    ShowChartRegion(e.Region.Description.ToString())
                End If
            End If
        End Sub
#End Region

#Region "ChartRegionClick"
        Private Sub chartControl1_ChartRegionClick(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs) Handles chartControl1.ChartRegionClick
            If Me.chkRegionClick.Checked Then
                If e.Region.SeriesIndex = 0 Then
                    OutputText(String.Format("Click over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point))
                    ShowChartRegion("ChartSeries")
                Else
                    OutputText(String.Format("Click over {0}", e.Region.Description.ToString()))
                    ShowChartRegion(e.Region.Description.ToString())
                End If



            End If
        End Sub
#End Region

#Region "ChartRegionDoubleClick"
        Private Sub chartControl1_ChartRegionDoubleClick(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs) Handles chartControl1.ChartRegionDoubleClick
            If Me.chkRegionDoubleClick.Checked Then
                If e.Region.SeriesIndex = 0 Then
                    OutputText(String.Format("Double Click over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point))
                    ShowChartRegion("ChartSeries")
                Else
                    OutputText(String.Format("Double Click over {0}", e.Region.Description.ToString()))
                    ShowChartRegion(e.Region.Description.ToString())
                End If
            End If
        End Sub
#End Region

#Region "Clear Log"
        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClearLog.Click
            Me.textBox1.Clear()

        End Sub
#End Region

#End Region
        
    End Class
End Namespace