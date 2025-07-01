#Region "Copyright Syncfusion Inc. 2001 - 2008"
'
'  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
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

Namespace EssentialChartSamples
	Public Class Form1
		Inherits Office2007Form
		#Region "Private Members"

		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private color1 As Color() = New Color() { Color.FromArgb(192, 126, 44), Color.FromArgb(255, 221, 158), Color.FromArgb(192, 126, 44) }
		Private color2 As Color() = New Color() { Color.FromArgb(118, 147, 58), Color.FromArgb(200, 224, 150), Color.FromArgb(118, 147, 58) }
		Private WithEvents comboBox1 As ComboBox
		Private label12 As Label
		Private panel1 As Panel
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
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub


		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
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
            Me.label12 = New System.Windows.Forms.Label
            Me.panel1 = New System.Windows.Forms.Panel
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.PeachPuff
            Me.chartControl1.BorderAppearance.FrameThickness = New Syncfusion.Windows.Forms.Chart.ChartThickness(15.0!, 15.0!, 15.0!, 15.0!)
            Me.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            '
            '
            '
            Me.chartControl1.Legend.Location = New System.Drawing.Point(328, 81)
            Me.chartControl1.Location = New System.Drawing.Point(12, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryYAxis.ForceZero = True
            Me.chartControl1.PrimaryYAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 600, 100)
            Me.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.Size = New System.Drawing.Size(464, 406)
            Me.chartControl1.TabIndex = 1
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Margin = 1
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ZoomOutIncrement = 0.20000000298023224
            '
            'comboBox1
            '
            Me.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.comboBox1.Dock = System.Windows.Forms.DockStyle.Right
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox1.Location = New System.Drawing.Point(367, 0)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(121, 21)
            Me.comboBox1.TabIndex = 93
            '
            'label12
            '
            Me.label12.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label12.Location = New System.Drawing.Point(0, 0)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(367, 23)
            Me.label12.TabIndex = 92
            Me.label12.Text = "SkinStyle"
            Me.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.label12)
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 441)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(488, 23)
            Me.panel1.TabIndex = 94
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(488, 464)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Borders"
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
		#End Region

		#Region "Form_Load"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' Creates series and associate with the Chart control
			InitializeChartData()
			
			For Each str As String In System.Enum.GetNames(GetType(ChartBorderSkinStyle))
				Me.comboBox1.Items.Add(str)
			Next str
            Me.comboBox1.SelectedIndex = 1

            ' Customize the basic appearance and behaviour of Chart Control
            ChartAppearance.ApplyChartStyles(Me.chartControl1)

		End Sub
		#End Region

		#Region "Helper Methods"

		#Region "InitializeChartData"
		''' <summary>
		''' Initializes Chart Data
		''' </summary>
		Private Sub InitializeChartData()
            Me.chartControl1.Series.Clear()

            Dim series2 As ChartSeries = New ChartSeries()

            series2.Name = "Sales"
            series2.Points.Add(1995, 370)
            series2.Points.Add(1996, 420)
            series2.Points.Add(1997, 330)
            series2.Points.Add(1998, 440)
            series2.Points.Add(1999, 230)
            series2.Points.Add(2000, 540)
            series2.Type = ChartSeriesType.Column
            series2.Text = series2.Name
            Me.chartControl1.Series.Add(series2)

            Dim series1 As ChartSeries = New ChartSeries()

            series1.Name = "Profit"
            series1.Points.Add(1995, 300)
            series1.Points.Add(1996, 240)
            series1.Points.Add(1997, 300)
            series1.Points.Add(1998, 240)
            series1.Points.Add(1999, 300)
            series1.Points.Add(2000, 240)
            series1.Type = ChartSeriesType.Column
            series1.Text = series1.Name
            Me.chartControl1.Series.Add(series1)
		End Sub
		#End Region

        '#Region "InitializeControlSettings"
        '''' <summary>
        '''' Initializes Chart Control settings
        '''' </summary>
        'Private Sub InitializeControlSettings()
        '	Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(83))))), (CInt(Fix((CByte(188))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(2))))), (CInt(Fix((CByte(59))))), (CInt(Fix((CByte(95)))))))
        '	Me.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(52, 112, 149)
        '	Me.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.Red
        '	Me.chartControl1.BorderAppearance.FrameThickness = New Syncfusion.Windows.Forms.Chart.ChartThickness(15F, 15F, 15F, 15F)
        '	Me.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(52))))), (CInt(Fix((CByte(112))))), (CInt(Fix((CByte(149))))))
        '          Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss

        '	Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
        '	Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(240))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(240))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(255)))))))
        '	Me.chartControl1.ForeColor = System.Drawing.Color.White
        '	Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(58))))), (CInt(Fix((CByte(124))))), (CInt(Fix((CByte(183))))))
        '	Me.chartControl1.PrimaryXAxis.GridLineType.Width = 2F
        '	Me.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(58))))), (CInt(Fix((CByte(124))))), (CInt(Fix((CByte(183))))))
        '	Me.chartControl1.PrimaryXAxis.LineType.Width = 2F
        '	Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(58))))), (CInt(Fix((CByte(124))))), (CInt(Fix((CByte(183))))))
        '	Me.chartControl1.PrimaryYAxis.GridLineType.Width = 2F
        '	Me.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(58))))), (CInt(Fix((CByte(124))))), (CInt(Fix((CByte(183))))))
        '	Me.chartControl1.PrimaryYAxis.LineType.Width = 2F
        '	Me.chartControl1.Series3D = True
        '	Me.chartControl1.PrimaryXAxis.TickColor = Color.Transparent
        '	Me.chartControl1.PrimaryYAxis.TickColor = Color.Transparent
        '	Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
        '	Me.chartControl1.PrimaryXAxis.Range = New MinMaxInfo(0, 8, 1)

        '	Me.chartControl1.Series(1).Style.Interior = New BrushInfo(GradientStyle.Horizontal, color1)
        '	Me.chartControl1.Series(0).Style.Interior = New BrushInfo(GradientStyle.Horizontal, color2)
        '	Me.chartControl1.Series(0).Style.Border.Color = Color.FromArgb(142, 181, 139)
        '	Me.chartControl1.Series(1).Style.Border.Color = Color.FromArgb(191, 126, 43)
        'End Sub
        '#End Region

		#End Region

		#Region "Border Settings"
		''' <summary>
		''' Changes the border appearance
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
			Me.chartControl1.BorderAppearance.SkinStyle = CType(System.Enum.Parse(GetType(ChartBorderSkinStyle), Me.comboBox1.SelectedItem.ToString(), True), ChartBorderSkinStyle)
			If Me.comboBox1.SelectedIndex = 0 Then
				Me.chartControl1.Titles(0).Text = "Essential Chart"
			Else
				Me.chartControl1.Titles(0).Text = Me.chartControl1.BorderAppearance.SkinStyle.ToString() & " Border "
			End If
		End Sub
		#End Region
	End Class
End Namespace
