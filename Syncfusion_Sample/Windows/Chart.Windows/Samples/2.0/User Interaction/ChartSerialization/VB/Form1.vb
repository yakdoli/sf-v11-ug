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
	Public Class Form1
		Inherits Office2007Form
		#Region "Private Members"
		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl

		Private count As Integer = 0

		#End Region

		Private chartControl2 As ChartControl
		Private WithEvents button1 As Button
		Private WithEvents button2 As Button
		Private components As IContainer

		#Region "Constructor, Main And Dispose"
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl()
			Me.chartControl2 = New Syncfusion.Windows.Forms.Chart.ChartControl()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			Me.chartControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(223))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(254)))))), System.Drawing.Color.White)
			Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
			Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(165))))), (CInt(Fix((CByte(194))))), (CInt(Fix((CByte(229)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(223))))), (CInt(Fix((CByte(236))))), (CInt(Fix((CByte(250)))))))
			Me.chartControl1.ElementsSpacing = 1
			Me.chartControl1.Font = New System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.chartControl1.IsWindowLess = False
			' 
			' 
			' 
			Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
			Me.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent
			Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.chartControl1.Legend.ItemsSize = New System.Drawing.Size(15, 15)
			Me.chartControl1.Legend.Location = New System.Drawing.Point(36, 53)
			Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
			Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
			Me.chartControl1.Legend.ShowSymbol = True
			Me.chartControl1.Legend.Spacing = 3
			Me.chartControl1.Localize = Nothing
			Me.chartControl1.Location = New System.Drawing.Point(12, 45)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.PrimaryXAxis.Crossing = Double.NaN
			Me.chartControl1.PrimaryXAxis.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.Silver
			Me.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.DarkGray
			Me.chartControl1.PrimaryXAxis.Margin = True
			Me.chartControl1.PrimaryYAxis.Crossing = Double.NaN
			Me.chartControl1.PrimaryYAxis.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.Silver
			Me.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.DarkGray
			Me.chartControl1.PrimaryYAxis.Margin = True
			Me.chartControl1.Rotation = 90F
			Me.chartControl1.Size = New System.Drawing.Size(398, 314)
			Me.chartControl1.TabIndex = 0
			Me.chartControl1.Text = "EssentialChart"
			' 
			' 
			' 
			Me.chartControl1.Title.Name = "Def_title"
			Me.chartControl1.Title.Text = "EssentialChart"
			Me.chartControl1.Titles.Add(Me.chartControl1.Title)
			' 
			' chartControl2
			' 
			Me.chartControl2.IsWindowLess = False
			' 
			' 
			' 
			Me.chartControl2.Legend.Location = New System.Drawing.Point(289, 75)
			Me.chartControl2.Localize = Nothing
			Me.chartControl2.Location = New System.Drawing.Point(436, 45)
			Me.chartControl2.Name = "chartControl2"
			Me.chartControl2.PrimaryXAxis.Crossing = Double.NaN
			Me.chartControl2.PrimaryXAxis.Margin = True
			Me.chartControl2.PrimaryYAxis.Crossing = Double.NaN
			Me.chartControl2.PrimaryYAxis.Margin = True
			Me.chartControl2.Size = New System.Drawing.Size(398, 314)
			Me.chartControl2.TabIndex = 4
			Me.chartControl2.Text = "chartControl2"
			' 
			' 
			' 
			Me.chartControl2.Title.Name = "Default"
			Me.chartControl2.Titles.Add(Me.chartControl2.Title)
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(138, 381)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(98, 23)
			Me.button1.TabIndex = 5
			Me.button1.Text = "SaveTemplate"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' button2
			' 
			Me.button2.Enabled = False
			Me.button2.Location = New System.Drawing.Point(563, 381)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(99, 23)
			Me.button2.TabIndex = 6
			Me.button2.Text = "LoadTemplate"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.White
			Me.ClientSize = New System.Drawing.Size(840, 457)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.chartControl2)
			Me.Controls.Add(Me.chartControl1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Line Charts"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.ResumeLayout(False)

		End Sub
		#End Region

		#Region "Form Load"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load



			InitializeChartData()
			ChartAppearance.ApplyChartStyles(Me.chartControl1)
		End Sub

		#End Region

		#Region "Helper Methods"

		#Region "InitializeChartData"
		Protected Sub InitializeChartData()
			Dim series1 As ChartSeries = New ChartSeries("IND")
			series1.Text = series1.Name
			series1.Type = ChartSeriesType.Line
			' 4, 3, 3, 3, 5, 4, 5, 6, 8, 9,10, 9, 12, 11, 5,

			Dim points1() As Double = {2, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1,2 }
			Dim i As Integer = 0
			Dim j As Integer = 1985
			Do While j < 2003 AndAlso i < 16
				series1.Points.Add(j, points1(i))
				j += 1
				i += 1
			Loop
			Me.chartControl1.Series.Add(series1)

			Dim series2 As ChartSeries = New ChartSeries("RSA")
			series2.Text = series2.Name
			series2.Type = ChartSeriesType.Line
			'6,9,10,10,12,8,10,5,6,5,4,3,4,2,3,
			i = 0
			Dim points2() As Double = {8,5,4,4,3,3,3,3,4,5,4,3,2,3,2,1}

			Dim k As Integer = 1985
			Do While k < 2003 AndAlso i < 16
				series2.Points.Add(k, points2(i))
				k += 1
				i += 1
			Loop
			Me.chartControl1.Series.Add(series2)


			Dim series3 As ChartSeries = New ChartSeries("PAK")
			series3.Text = series3.Name
			series3.Type = ChartSeriesType.Line
			' 19,17,18,23,21,18,16,14,9,10,8,6,6,8,10,
			i = 0
			Dim points3() As Double = {11,15,14,10,11,6,4,6,2,2,2,2,3,4,4,4}

			Dim l As Integer = 1985
			Do While l < 2003 AndAlso i < 16
				series3.Points.Add(l, points3(i))
				l += 1
				i += 1
			Loop

			Me.chartControl1.Series.Add(series3)



		End Sub

		#End Region


		#End Region





		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            ChartTemplate.Save(Me.chartControl1, "Chart.xml")
            Me.button2.Enabled = True
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			ChartTemplate.Load(Me.chartControl2, "Chart.xml")
		End Sub

	End Class
End Namespace
