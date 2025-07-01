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
Imports Syncfusion.Drawing

Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Windows.Forms

Namespace GettingStartedSample
    Public Class Form1
        Inherits Office2007Form
#Region "Private Members"
        Private panel1 As System.Windows.Forms.Panel
        Private label2 As System.Windows.Forms.Label
        Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private label6 As Label
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing
#End Region

#Region "Form Constructor, Main, Dispose"
        Public Sub New()
            InitializeComponent()

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
            Me.label6 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.panel1.Controls.Add(Me.label6)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 323)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(515, 160)
            Me.panel1.TabIndex = 0
            '
            'label6
            '
            Me.label6.Dock = System.Windows.Forms.DockStyle.Left
            Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label6.Image = CType(resources.GetObject("label6.Image"), System.Drawing.Image)
            Me.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label6.Location = New System.Drawing.Point(0, 0)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(257, 56)
            Me.label6.TabIndex = 5
            Me.label6.Text = "Getting Started with Essential Chart"
            Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label2
            '
            Me.label2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Location = New System.Drawing.Point(0, 56)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(515, 104)
            Me.label2.TabIndex = 1
            Me.label2.Tag = ""
            Me.label2.Text = resources.GetString("label2.Text")
            '
            'chartControl1
            '
            Me.chartControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White)
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Embed
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White)
            '
            '
            '
            Me.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(164, 61)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside
            Me.chartControl1.Location = New System.Drawing.Point(48, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryYAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 500, 100)
            Me.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.Size = New System.Drawing.Size(417, 284)
            Me.chartControl1.TabIndex = 1
            Me.chartControl1.Text = "Essential Chart"
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ZoomOutIncrement = 0.20000000298023224
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(515, 483)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Getting Started"
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form_Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'Creates series and associate with the Chart control
            InitializeChartData()

            'Customize the basic appearance and behaviour of Chart Control
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region "Helper Methods"
#Region "InitializeChartData"

        Private Sub InitializeChartData()
            Dim series As ChartSeries = New ChartSeries()
            series.Name = "Sales"
            series.Points.Add(1999, 3)
            series.Points.Add(2000, 7)
            series.Points.Add(2001, 12)
            series.Points.Add(2002, 18)
            series.Points.Add(2003, 22)
            series.Points.Add(2004, 30)
            series.Points.Add(2005, 40)
            series.Points.Add(2006, 50)
            series.Points.Add(2007, 65)
            series.Points.Add(2008, 75)
            series.Type = ChartSeriesType.Column
            series.Text = series.Name
            Me.chartControl1.Series.Add(series)
            AddHandler chartControl1.Series(0).PrepareStyle, AddressOf Form1_PrepareStyle
        End Sub

        Private Sub Form1_PrepareStyle(ByVal sender As Object, ByVal args As ChartPrepareStyleInfoEventArgs)
            Dim series As ChartSeries = Me.chartControl1.Series(0)
            If Not series Is Nothing Then

                If args.Index = 0 Then
                    args.Style.Interior = New BrushInfo(Color.FromArgb(175, 41, 158, 214))
                ElseIf args.Index = 1 Then
                    args.Style.Interior = New BrushInfo(Color.FromArgb(175, 206, 215, 41))
                ElseIf args.Index = 2 Then
                    args.Style.Interior = New BrushInfo(Color.FromArgb(175, 255, 186, 0))
                ElseIf args.Index = 3 Then
                    args.Style.Interior = New BrushInfo(Color.FromArgb(175, 247, 125, 16))
                ElseIf args.Index = 4 Then
                    args.Style.Interior = New BrushInfo(Color.FromArgb(175, 129, 115, 27))
                ElseIf args.Index = 5 Then
                    args.Style.Interior = New BrushInfo(Color.FromArgb(175, 255, 136, 23))
                ElseIf args.Index = 6 Then
                    args.Style.Interior = New BrushInfo(Color.FromArgb(175, 246, 100, 15))
                ElseIf args.Index = 7 Then
                    args.Style.Interior = New BrushInfo(Color.FromArgb(175, 188, 200, 6))
                ElseIf args.Index = 8 Then
                    args.Style.Interior = New BrushInfo(Color.FromArgb(175, 234, 90, 81))
                ElseIf args.Index = 9 Then
                    args.Style.Interior = New BrushInfo(Color.FromArgb(175, 191, 192, 98))
                End If
            End If
        End Sub
#End Region

#End Region

    End Class
End Namespace
