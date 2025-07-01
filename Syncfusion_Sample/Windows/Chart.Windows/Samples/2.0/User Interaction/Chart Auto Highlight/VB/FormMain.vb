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
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing

Namespace Syncfusion.Windows.Forms.Chart.Samples
    ''' <summary>
    ''' The ChartControl sample form.
    ''' </summary>
    Public Class FormMain
        Inherits Office2007Form
#Region "Private Members"
        Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private panel1 As System.Windows.Forms.Panel
        Private WithEvents checkBoxAutoHighlight As System.Windows.Forms.CheckBox
        Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
        Private WithEvents radioButton2 As System.Windows.Forms.RadioButton
        Private WithEvents colorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
        Private series1 As ChartSeries
        Private label21 As Label
        Private label22 As Label
        Private panel2 As Panel
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing
#End Region

#Region "Form's  Constructor, Main And Dispose"
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
        End Sub
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New FormMain())
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel1 = New System.Windows.Forms.Panel
            Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.radioButton2 = New System.Windows.Forms.RadioButton
            Me.label21 = New System.Windows.Forms.Label
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.label22 = New System.Windows.Forms.Label
            Me.checkBoxAutoHighlight = New System.Windows.Forms.CheckBox
            Me.panel2 = New System.Windows.Forms.Panel
            Me.panel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer)))
            Me.chartControl1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.chartControl1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(58, 305)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
            Me.chartControl1.Location = New System.Drawing.Point(6, 5)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.Size = New System.Drawing.Size(457, 382)
            Me.chartControl1.TabIndex = 2
            Me.chartControl1.Text = "Essential Chart"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Essential Chart"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ZoomOutIncrement = 1.5
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.colorPickerButton1)
            Me.panel1.Controls.Add(Me.radioButton2)
            Me.panel1.Controls.Add(Me.label21)
            Me.panel1.Controls.Add(Me.radioButton1)
            Me.panel1.Controls.Add(Me.label22)
            Me.panel1.Controls.Add(Me.checkBoxAutoHighlight)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 394)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(481, 56)
            Me.panel1.TabIndex = 3
            '
            'colorPickerButton1
            '
            Me.colorPickerButton1.BackColor = System.Drawing.Color.Transparent
            Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton1.Location = New System.Drawing.Point(427, 25)
            Me.colorPickerButton1.Name = "colorPickerButton1"
            Me.colorPickerButton1.SelectedAsBackcolor = True
            Me.colorPickerButton1.SelectedColor = System.Drawing.Color.Transparent
            Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton1.Size = New System.Drawing.Size(20, 20)
            Me.colorPickerButton1.TabIndex = 2
            Me.colorPickerButton1.Text = "..."
            Me.colorPickerButton1.UseVisualStyleBackColor = False
            '
            'radioButton2
            '
            Me.radioButton2.AutoSize = True
            Me.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton2.Location = New System.Drawing.Point(368, 26)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(69, 18)
            Me.radioButton2.TabIndex = 1
            Me.radioButton2.Text = "Specific"
            '
            'label21
            '
            Me.label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label21.Location = New System.Drawing.Point(279, 21)
            Me.label21.Name = "label21"
            Me.label21.Size = New System.Drawing.Size(162, 1)
            Me.label21.TabIndex = 5
            '
            'radioButton1
            '
            Me.radioButton1.AutoSize = True
            Me.radioButton1.Checked = True
            Me.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton1.Location = New System.Drawing.Point(278, 26)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(78, 18)
            Me.radioButton1.TabIndex = 0
            Me.radioButton1.TabStop = True
            Me.radioButton1.Text = "Automatic"
            '
            'label22
            '
            Me.label22.AutoSize = True
            Me.label22.BackColor = System.Drawing.Color.Transparent
            Me.label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label22.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label22.Location = New System.Drawing.Point(275, 4)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(88, 14)
            Me.label22.TabIndex = 4
            Me.label22.Text = "Highlight Color"
            '
            'checkBoxAutoHighlight
            '
            Me.checkBoxAutoHighlight.AutoSize = True
            Me.checkBoxAutoHighlight.Checked = True
            Me.checkBoxAutoHighlight.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAutoHighlight.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBoxAutoHighlight.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBoxAutoHighlight.Location = New System.Drawing.Point(5, 17)
            Me.checkBoxAutoHighlight.Name = "checkBoxAutoHighlight"
            Me.checkBoxAutoHighlight.Size = New System.Drawing.Size(98, 18)
            Me.checkBoxAutoHighlight.TabIndex = 0
            Me.checkBoxAutoHighlight.Text = "Auto Highlight"
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.White
            Me.panel2.Controls.Add(Me.chartControl1)
            Me.panel2.Location = New System.Drawing.Point(6, 6)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(472, 393)
            Me.panel2.TabIndex = 4
            '
            'FormMain
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(481, 450)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormMain"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Auto Highlight "
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"
        Private Sub FormMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region "InitializeChartData"
        ''' <summary>
        ''' Initializes the ChartControl's data and sets the Chart type
        ''' </summary>
        Protected Sub InitializeChartData()
            Dim random As Random = New Random()

            series1 = New ChartSeries("Market")
            series1.Name = "Market"
            series1.Text = series1.Name
            series1.Points.Add(0, 16)
            series1.Points.Add(1, 10)
            series1.Points.Add(2, 13)
            series1.Points.Add(3, 17)
            series1.Points.Add(4, 11)
            series1.Points.Add(5, 18)
            series1.Points.Add(6, 10)
            series1.Points.Add(7, 15)



            series1.Type = ChartSeriesType.Pie

            Me.chartControl1.AutoHighlight = Me.checkBoxAutoHighlight.Checked
            Me.chartControl1.Series.Add(series1)
            series1.Style.DisplayText = True
            series1.Style.TextColor = Color.Black

            Me.chartControl1.SmoothingMode = SmoothingMode.AntiAlias
            series1.Styles(0).Text = String.Format("Production {0}%", series1.Points(0).YValues(0))
            series1.Styles(1).Text = String.Format("Labor {0}%", series1.Points(1).YValues(0))
            series1.Styles(2).Text = String.Format("Facilities {0}%", series1.Points(2).YValues(0))
            series1.Styles(3).Text = String.Format("Taxes {0}%", series1.Points(3).YValues(0))
            series1.Styles(4).Text = String.Format("Insurance{0}%", series1.Points(4).YValues(0))
            series1.Styles(5).Text = String.Format("Licenses {0}%", series1.Points(5).YValues(0))
            series1.Styles(6).Text = String.Format("Legal {0}%", series1.Points(6).YValues(0))
            series1.Styles(7).Text = String.Format("Health {0}%", series1.Points(7).YValues(0))
            Me.chartControl1.ShowLegend = False
            Me.colorPickerButton1.SelectedColor = Color.Gold
        End Sub
#End Region

#Region "Events"
        Private Sub checkBoxAutoHighlight_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBoxAutoHighlight.CheckedChanged
            If Me.checkBoxAutoHighlight.Checked Then
                Me.chartControl1.AutoHighlight = True
                Me.chartControl1.Cursor = System.Windows.Forms.Cursors.Hand
            Else
                Me.chartControl1.AutoHighlight = False
                Me.chartControl1.Cursor = System.Windows.Forms.Cursors.Default
            End If
        End Sub

        Private Sub Color_Selected(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorPickerButton1.ColorSelected
            Dim interior As BrushInfo = Me.chartControl1.Series(0).Style.HighlightInterior
            If interior Is Nothing Then
                interior = New BrushInfo()
            End If
            If Me.radioButton2.Checked Then
                Dim foreColor As Color = interior.ForeColor
                Me.chartControl1.Series(0).Style.HighlightInterior = New BrushInfo(GradientStyle.None, foreColor, Me.colorPickerButton1.SelectedColor)
                Me.chartControl1.Refresh()
            End If
        End Sub

        Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton1.CheckedChanged
            If Me.radioButton1.Checked Then
                Me.chartControl1.Series(0).Style.HighlightInterior = Nothing
            End If
        End Sub

        Private Sub radioButton2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton2.CheckedChanged
            Dim interior As BrushInfo = Me.chartControl1.Series(0).Style.HighlightInterior
            If interior Is Nothing Then
                interior = New BrushInfo()
            End If
            Dim foreColor As Color = interior.ForeColor
            ' Specifying a "Gold" highlight color.
            Me.chartControl1.Series(0).Style.HighlightInterior = New BrushInfo(GradientStyle.None, foreColor, Me.colorPickerButton1.SelectedColor)
        End Sub
#End Region
    End Class
End Namespace