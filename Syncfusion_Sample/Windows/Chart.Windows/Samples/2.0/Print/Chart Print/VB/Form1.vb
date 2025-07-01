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
Imports System.Drawing.Printing

Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing

Namespace ChartPrintingSample
    Public Class Form1
        Inherits Syncfusion.Windows.Forms.Office2007Form
#Region "Private Members"
        Private printPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
        Private printDialog1 As System.Windows.Forms.PrintDialog
        Private printPreviewDocument As PrintDocument
        Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private WithEvents buttonPrint As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents buttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
        Private label1 As Label
        Private label6 As Label
        Private panel1 As Panel
        Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
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
            Me.printPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
            Me.printDialog1 = New System.Windows.Forms.PrintDialog
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.buttonPrint = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.label1 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.panel1 = New System.Windows.Forms.Panel
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label2 = New System.Windows.Forms.Label
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'printPreviewDialog1
            '
            Me.printPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
            Me.printPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
            Me.printPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
            Me.printPreviewDialog1.Enabled = True
            Me.printPreviewDialog1.Icon = CType(resources.GetObject("printPreviewDialog1.Icon"), System.Drawing.Icon)
            Me.printPreviewDialog1.Name = "printPreviewDialog1"
            Me.printPreviewDialog1.Visible = False
            '
            'chartControl1
            '
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Embed
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer)))
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(70, 256)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
            Me.chartControl1.Location = New System.Drawing.Point(12, 9)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.ShowToolbar = True
            Me.chartControl1.Size = New System.Drawing.Size(461, 345)
            Me.chartControl1.TabIndex = 3
            Me.chartControl1.Text = "Essential Chart"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Essential Chart"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ToolBar.Visible = True
            Me.chartControl1.ZoomOutIncrement = 0.20000000298023224
            '
            'buttonPrint
            '
            Me.buttonPrint.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonPrint.Image = CType(resources.GetObject("buttonPrint.Image"), System.Drawing.Image)
            Me.buttonPrint.KeepFocusRectangle = False
            Me.buttonPrint.Location = New System.Drawing.Point(423, 360)
            Me.buttonPrint.Name = "buttonPrint"
            Me.buttonPrint.Size = New System.Drawing.Size(50, 50)
            Me.buttonPrint.TabIndex = 14
            Me.buttonPrint.UseVisualStyle = True
            '
            'buttonAdv1
            '
            Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv1.Image = CType(resources.GetObject("buttonAdv1.Image"), System.Drawing.Image)
            Me.buttonAdv1.KeepFocusRectangle = False
            Me.buttonAdv1.Location = New System.Drawing.Point(367, 360)
            Me.buttonAdv1.Name = "buttonAdv1"
            Me.buttonAdv1.Size = New System.Drawing.Size(50, 50)
            Me.buttonAdv1.TabIndex = 15
            Me.buttonAdv1.UseVisualStyle = True
            '
            'label1
            '
            Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label1.Location = New System.Drawing.Point(0, 24)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(485, 33)
            Me.label1.TabIndex = 16
            '
            'label6
            '
            Me.label6.Dock = System.Windows.Forms.DockStyle.Top
            Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label6.Image = CType(resources.GetObject("label6.Image"), System.Drawing.Image)
            Me.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label6.Location = New System.Drawing.Point(0, 0)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(485, 24)
            Me.label6.TabIndex = 17
            Me.label6.Text = "        Properties"
            Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'panel1
            '
            Me.panel1.AutoScroll = True
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.label6)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 416)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(485, 57)
            Me.panel1.TabIndex = 18
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Items.AddRange(New Object() {"CheckPrinter", "Color", "GrayScale"})
            Me.comboBox1.Location = New System.Drawing.Point(119, 389)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(121, 21)
            Me.comboBox1.TabIndex = 24
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Location = New System.Drawing.Point(9, 392)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(104, 13)
            Me.label2.TabIndex = 23
            Me.label2.Text = "ChartPrintColorMode"
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.checkBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.checkBox1.Location = New System.Drawing.Point(10, 363)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(83, 17)
            Me.checkBox1.TabIndex = 22
            Me.checkBox1.Text = "Print Toolbar"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(485, 473)
            Me.Controls.Add(Me.comboBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.checkBox1)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.buttonPrint)
            Me.Controls.Add(Me.buttonAdv1)
            Me.Controls.Add(Me.chartControl1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Print"
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
            Me.Size = New Size(497, 450)
            Me.panel1.Visible = False
            Me.comboBox1.SelectedIndex = 1
            Me.chartControl1.ToolBar.AutoSize = False
            Me.chartControl1.ToolBar.Size = New Size(250, 30)

        End Sub
#End Region

#Region "InitializeChartData"
        Protected Sub InitializeChartData()
            Dim series3 As ChartSeries = New ChartSeries()
            series3.Name = "Server 3"
            series3.Points.Add(1, 540)
            series3.Points.Add(2, 340)
            series3.Points.Add(3, 240)
            series3.Points.Add(4, 200)

            series3.Type = ChartSeriesType.Spline
            series3.Text = series3.Name
            series3.Style.Border.Width = 2
            series3.Style.Symbol.Shape = ChartSymbolShape.Circle
            series3.Style.Symbol.Color = Color.White
            series3.Style.Symbol.Border.Width = 2
            series3.Style.Symbol.Border.Color = Color.FromArgb(175, 36, 119, 51)
            Me.chartControl1.Series.Add(series3)

            Dim series As ChartSeries = New ChartSeries()
            series.Name = "Server 1"
            series.Points.Add(1, 340)
            series.Points.Add(2, 240)
            series.Points.Add(3, 440)
            series.Points.Add(4, 500)

            series.Type = ChartSeriesType.Column
            series.Text = series.Name

            Dim series2 As ChartSeries = New ChartSeries()
            series2.Name = "Server 2"
            series2.Points.Add(1, 240)
            series2.Points.Add(2, 140)
            series2.Points.Add(3, 340)
            series2.Points.Add(4, 300)

            series2.Type = ChartSeriesType.Column
            series2.Text = series2.Name

            Me.chartControl1.Series.Add(series)

            Me.chartControl1.Series.Add(series2)

            Me.chartControl1.Text = "Daily Server Network Load Comparison"
            Me.chartControl1.PrimaryYAxis.Title = "Server Load (MBytes)"
            Me.chartControl1.PrimaryXAxis.Format = "Day 0"
            Me.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows
            Me.chartControl1.Indexed = True
        End Sub
#End Region

#Region "Events"
        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonPrint.Click
            printDialog1.Document = Me.chartControl1.PrintDocument
            If printDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Me.chartControl1.PrintColorMode = ChartPrintColorMode.Color
                Me.chartControl1.PrintDocument.Print()
            End If
            Me.Size = New Size(497, 450)
            Me.panel1.Visible = False
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonAdv1.Click
            Try
                printPreviewDocument = Me.chartControl1.PrintDocument
                Me.printPreviewDialog1.Document = printPreviewDocument
                Me.printPreviewDialog1.FormBorderStyle = FormBorderStyle.Fixed3D
                Me.printPreviewDialog1.ShowDialog()
            Catch exp As Exception
                Me.Size = New Size(497, 509)
                Me.panel1.Visible = True
                Me.label1.Text = exp.Message.ToString()
            End Try
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            Me.chartControl1.PrintDocument.PrintToolBar = Me.checkBox1.Checked
        End Sub

        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
            Me.chartControl1.PrintColorMode = CType(System.Enum.Parse(GetType(ChartPrintColorMode), Me.comboBox1.SelectedItem.ToString(), True), ChartPrintColorMode)
        End Sub
#End Region

    End Class
End Namespace