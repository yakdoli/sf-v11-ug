Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing.Drawing2D


Namespace ChartSeriesSample
	
    Public Class Form1
        Inherits Office2007Form
#Region "Private Members"
        Private panel1 As System.Windows.Forms.Panel
        Private label1 As System.Windows.Forms.Label


        Private components As System.ComponentModel.IContainer

        Private cp1 As ChartCustomPoint = New ChartCustomPoint()
        Private cp2 As ChartCustomPoint = New ChartCustomPoint()
        Private cp3 As ChartCustomPoint = New ChartCustomPoint()
        Private cp4 As ChartCustomPoint = New ChartCustomPoint()

        Private i, j As Integer
        Private WithEvents numericUpDown1 As NumericUpDown
        Private WithEvents numericUpDown2 As NumericUpDown
        Private label13 As Label
        Private WithEvents numericUpDown3 As NumericUpDown
        Private label14 As Label
        Private WithEvents numericUpDown4 As NumericUpDown
        Private label16 As Label
        Private WithEvents numericUpDown5 As NumericUpDown
        Private label2 As Label
        Private WithEvents numericUpDown6 As NumericUpDown
        Private label18 As Label
        Private WithEvents numericUpDown7 As NumericUpDown
        Private label4 As Label
        Private WithEvents numericUpDown8 As NumericUpDown
        Private label21 As Label
        Private label29 As Label
        Private label30 As Label
        Private WithEvents numericUpDown9 As NumericUpDown
        Private label20 As Label
        Private WithEvents numericUpDown10 As NumericUpDown
        Private label22 As Label
        Private label6 As Label
        Private label7 As Label
        Private WithEvents checkBox1 As CheckBox
        Private label3 As Label
        Private label9 As Label
        Private label8 As Label
        Private label5 As Label
        Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private codeString As String = String.Empty
#End Region

#Region "Constructor, Main and Dispose"

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
            Me.panel1 = New System.Windows.Forms.Panel
            Me.numericUpDown9 = New System.Windows.Forms.NumericUpDown
            Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown
            Me.label9 = New System.Windows.Forms.Label
            Me.label8 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label20 = New System.Windows.Forms.Label
            Me.label30 = New System.Windows.Forms.Label
            Me.numericUpDown10 = New System.Windows.Forms.NumericUpDown
            Me.label1 = New System.Windows.Forms.Label
            Me.label22 = New System.Windows.Forms.Label
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.label6 = New System.Windows.Forms.Label
            Me.label13 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.label16 = New System.Windows.Forms.Label
            Me.numericUpDown4 = New System.Windows.Forms.NumericUpDown
            Me.label14 = New System.Windows.Forms.Label
            Me.numericUpDown3 = New System.Windows.Forms.NumericUpDown
            Me.label18 = New System.Windows.Forms.Label
            Me.numericUpDown6 = New System.Windows.Forms.NumericUpDown
            Me.label2 = New System.Windows.Forms.Label
            Me.label29 = New System.Windows.Forms.Label
            Me.numericUpDown5 = New System.Windows.Forms.NumericUpDown
            Me.label21 = New System.Windows.Forms.Label
            Me.numericUpDown7 = New System.Windows.Forms.NumericUpDown
            Me.numericUpDown8 = New System.Windows.Forms.NumericUpDown
            Me.label4 = New System.Windows.Forms.Label
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel1.SuspendLayout()
            CType(Me.numericUpDown9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown8, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.panel1.Controls.Add(Me.label7)
            Me.panel1.Controls.Add(Me.label9)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.numericUpDown2)
            Me.panel1.Controls.Add(Me.numericUpDown8)
            Me.panel1.Controls.Add(Me.label8)
            Me.panel1.Controls.Add(Me.numericUpDown7)
            Me.panel1.Controls.Add(Me.label16)
            Me.panel1.Controls.Add(Me.label21)
            Me.panel1.Controls.Add(Me.numericUpDown9)
            Me.panel1.Controls.Add(Me.checkBox1)
            Me.panel1.Controls.Add(Me.label6)
            Me.panel1.Controls.Add(Me.numericUpDown5)
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.label22)
            Me.panel1.Controls.Add(Me.numericUpDown6)
            Me.panel1.Controls.Add(Me.numericUpDown10)
            Me.panel1.Controls.Add(Me.label18)
            Me.panel1.Controls.Add(Me.label20)
            Me.panel1.Controls.Add(Me.label30)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.label13)
            Me.panel1.Controls.Add(Me.numericUpDown1)
            Me.panel1.Controls.Add(Me.numericUpDown3)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.label14)
            Me.panel1.Controls.Add(Me.label29)
            Me.panel1.Controls.Add(Me.numericUpDown4)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 387)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(653, 129)
            Me.panel1.TabIndex = 1
            '
            'numericUpDown9
            '
            Me.numericUpDown9.Location = New System.Drawing.Point(582, 102)
            Me.numericUpDown9.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown9.Name = "numericUpDown9"
            Me.numericUpDown9.Size = New System.Drawing.Size(45, 20)
            Me.numericUpDown9.TabIndex = 118
            '
            'numericUpDown2
            '
            Me.numericUpDown2.Location = New System.Drawing.Point(72, 95)
            Me.numericUpDown2.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown2.Name = "numericUpDown2"
            Me.numericUpDown2.Size = New System.Drawing.Size(45, 20)
            Me.numericUpDown2.TabIndex = 85
            Me.numericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'label9
            '
            Me.label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label9.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label9.Image = CType(resources.GetObject("label9.Image"), System.Drawing.Image)
            Me.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label9.Location = New System.Drawing.Point(386, 55)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(59, 18)
            Me.label9.TabIndex = 122
            Me.label9.Text = "Point4"
            Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label8
            '
            Me.label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label8.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label8.Image = CType(resources.GetObject("label8.Image"), System.Drawing.Image)
            Me.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label8.Location = New System.Drawing.Point(261, 54)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(57, 18)
            Me.label8.TabIndex = 121
            Me.label8.Text = "Point3"
            Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label5
            '
            Me.label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label5.Image = CType(resources.GetObject("label5.Image"), System.Drawing.Image)
            Me.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label5.Location = New System.Drawing.Point(137, 52)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(57, 18)
            Me.label5.TabIndex = 120
            Me.label5.Text = "Point2"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label3
            '
            Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label3.Image = CType(resources.GetObject("label3.Image"), System.Drawing.Image)
            Me.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label3.Location = New System.Drawing.Point(9, 48)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(57, 18)
            Me.label3.TabIndex = 119
            Me.label3.Text = "Point1"
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label20
            '
            Me.label20.AutoSize = True
            Me.label20.Location = New System.Drawing.Point(518, 106)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(62, 13)
            Me.label20.TabIndex = 117
            Me.label20.Text = "SeriesIndex"
            Me.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label30
            '
            Me.label30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label30.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label30.Image = CType(resources.GetObject("label30.Image"), System.Drawing.Image)
            Me.label30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label30.Location = New System.Drawing.Point(3, 12)
            Me.label30.Name = "label30"
            Me.label30.Size = New System.Drawing.Size(108, 18)
            Me.label30.TabIndex = 104
            Me.label30.Text = "Custom Points"
            Me.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numericUpDown10
            '
            Me.numericUpDown10.Location = New System.Drawing.Point(582, 78)
            Me.numericUpDown10.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
            Me.numericUpDown10.Name = "numericUpDown10"
            Me.numericUpDown10.Size = New System.Drawing.Size(45, 20)
            Me.numericUpDown10.TabIndex = 116
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(9, 73)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(57, 13)
            Me.label1.TabIndex = 4
            Me.label1.Text = "PointIndex"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label22
            '
            Me.label22.AutoSize = True
            Me.label22.Location = New System.Drawing.Point(519, 82)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(57, 13)
            Me.label22.TabIndex = 115
            Me.label22.Text = "PointIndex"
            Me.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'numericUpDown1
            '
            Me.numericUpDown1.Location = New System.Drawing.Point(72, 71)
            Me.numericUpDown1.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.Size = New System.Drawing.Size(45, 20)
            Me.numericUpDown1.TabIndex = 83
            Me.numericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'label6
            '
            Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label6.Location = New System.Drawing.Point(519, 38)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(130, 1)
            Me.label6.TabIndex = 114
            '
            'label13
            '
            Me.label13.AutoSize = True
            Me.label13.Location = New System.Drawing.Point(8, 97)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(62, 13)
            Me.label13.TabIndex = 84
            Me.label13.Text = "SeriesIndex"
            Me.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label7
            '
            Me.label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label7.Image = CType(resources.GetObject("label7.Image"), System.Drawing.Image)
            Me.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label7.Location = New System.Drawing.Point(519, 15)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(102, 18)
            Me.label7.TabIndex = 113
            Me.label7.Text = "Empty Points"
            Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(524, 46)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(101, 17)
            Me.checkBox1.TabIndex = 112
            Me.checkBox1.Text = "Hide Data Point"
            '
            'label16
            '
            Me.label16.AutoSize = True
            Me.label16.Location = New System.Drawing.Point(137, 75)
            Me.label16.Name = "label16"
            Me.label16.Size = New System.Drawing.Size(41, 13)
            Me.label16.TabIndex = 88
            Me.label16.Text = "XValue"
            Me.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'numericUpDown4
            '
            Me.numericUpDown4.Location = New System.Drawing.Point(200, 75)
            Me.numericUpDown4.Maximum = New Decimal(New Integer() {2008, 0, 0, 0})
            Me.numericUpDown4.Minimum = New Decimal(New Integer() {1999, 0, 0, 0})
            Me.numericUpDown4.Name = "numericUpDown4"
            Me.numericUpDown4.Size = New System.Drawing.Size(45, 20)
            Me.numericUpDown4.TabIndex = 89
            Me.numericUpDown4.Value = New Decimal(New Integer() {2003, 0, 0, 0})
            '
            'label14
            '
            Me.label14.AutoSize = True
            Me.label14.Location = New System.Drawing.Point(137, 99)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(41, 13)
            Me.label14.TabIndex = 90
            Me.label14.Text = "YValue"
            Me.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'numericUpDown3
            '
            Me.numericUpDown3.Increment = New Decimal(New Integer() {2, 0, 0, 0})
            Me.numericUpDown3.Location = New System.Drawing.Point(200, 99)
            Me.numericUpDown3.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
            Me.numericUpDown3.Name = "numericUpDown3"
            Me.numericUpDown3.Size = New System.Drawing.Size(45, 20)
            Me.numericUpDown3.TabIndex = 91
            Me.numericUpDown3.Value = New Decimal(New Integer() {289, 0, 0, 0})
            '
            'label18
            '
            Me.label18.AutoSize = True
            Me.label18.Location = New System.Drawing.Point(261, 77)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(41, 13)
            Me.label18.TabIndex = 94
            Me.label18.Text = "XValue"
            Me.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'numericUpDown6
            '
            Me.numericUpDown6.Location = New System.Drawing.Point(324, 101)
            Me.numericUpDown6.Maximum = New Decimal(New Integer() {70, 0, 0, 0})
            Me.numericUpDown6.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
            Me.numericUpDown6.Name = "numericUpDown6"
            Me.numericUpDown6.Size = New System.Drawing.Size(45, 20)
            Me.numericUpDown6.TabIndex = 95
            Me.numericUpDown6.Value = New Decimal(New Integer() {47, 0, 0, 0})
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(261, 101)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(41, 13)
            Me.label2.TabIndex = 96
            Me.label2.Text = "YValue"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label29
            '
            Me.label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label29.Location = New System.Drawing.Point(8, 32)
            Me.label29.Name = "label29"
            Me.label29.Size = New System.Drawing.Size(130, 1)
            Me.label29.TabIndex = 105
            '
            'numericUpDown5
            '
            Me.numericUpDown5.Increment = New Decimal(New Integer() {2, 0, 0, 0})
            Me.numericUpDown5.Location = New System.Drawing.Point(324, 77)
            Me.numericUpDown5.Maximum = New Decimal(New Integer() {98, 0, 0, 0})
            Me.numericUpDown5.Minimum = New Decimal(New Integer() {18, 0, 0, 0})
            Me.numericUpDown5.Name = "numericUpDown5"
            Me.numericUpDown5.Size = New System.Drawing.Size(45, 20)
            Me.numericUpDown5.TabIndex = 97
            Me.numericUpDown5.Value = New Decimal(New Integer() {68, 0, 0, 0})
            '
            'label21
            '
            Me.label21.AutoSize = True
            Me.label21.Location = New System.Drawing.Point(386, 80)
            Me.label21.Name = "label21"
            Me.label21.Size = New System.Drawing.Size(41, 13)
            Me.label21.TabIndex = 100
            Me.label21.Text = "XValue"
            Me.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'numericUpDown7
            '
            Me.numericUpDown7.Increment = New Decimal(New Integer() {2, 0, 0, 0})
            Me.numericUpDown7.Location = New System.Drawing.Point(451, 78)
            Me.numericUpDown7.Maximum = New Decimal(New Integer() {392, 0, 0, 0})
            Me.numericUpDown7.Minimum = New Decimal(New Integer() {66, 0, 0, 0})
            Me.numericUpDown7.Name = "numericUpDown7"
            Me.numericUpDown7.Size = New System.Drawing.Size(45, 20)
            Me.numericUpDown7.TabIndex = 103
            Me.numericUpDown7.Value = New Decimal(New Integer() {190, 0, 0, 0})
            '
            'numericUpDown8
            '
            Me.numericUpDown8.Increment = New Decimal(New Integer() {2, 0, 0, 0})
            Me.numericUpDown8.Location = New System.Drawing.Point(451, 104)
            Me.numericUpDown8.Maximum = New Decimal(New Integer() {280, 0, 0, 0})
            Me.numericUpDown8.Minimum = New Decimal(New Integer() {70, 0, 0, 0})
            Me.numericUpDown8.Name = "numericUpDown8"
            Me.numericUpDown8.Size = New System.Drawing.Size(45, 20)
            Me.numericUpDown8.TabIndex = 101
            Me.numericUpDown8.Value = New Decimal(New Integer() {135, 0, 0, 0})
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(386, 104)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(41, 13)
            Me.label4.TabIndex = 102
            Me.label4.Text = "YValue"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'chartControl1
            '
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer)))
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(58, 274)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
            Me.chartControl1.Location = New System.Drawing.Point(22, 18)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.Size = New System.Drawing.Size(605, 351)
            Me.chartControl1.TabIndex = 1
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "chartControl1"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(653, 516)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Custom Points "
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.numericUpDown9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown8, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitializeChartData()
            InitializeControlSettings()
            SetCustomPoints()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region "InitializeChartData"
        Protected Sub InitializeChartData()
            Dim series1 As ChartSeries = New ChartSeries()
            series1.Name = "Beverages"
            series1.Type = ChartSeriesType.Column
            series1.Text = series1.Name
            series1.Points.Add(1999, 256)
            series1.Points.Add(2000, 451)
            series1.Points.Add(2001, 382)
            series1.Points.Add(2002, 437)
            series1.Points.Add(2003, 321)
            series1.Points.Add(2004, 234)
            series1.Points.Add(2005, 425)
            series1.Points.Add(2006, 257)
            series1.Points.Add(2007, 382)
            series1.Points.Add(2008, 296)
            series1.Style.Font.Bold = True

            Dim series2 As ChartSeries = New ChartSeries()
            series2.Name = "Dairy Products"
            series2.Type = ChartSeriesType.Column
            series2.Text = series2.Name
            series2.Points.Add(1999, 358)
            series2.Points.Add(2000, 437)
            series2.Points.Add(2001, 491)
            series2.Points.Add(2002, 480)
            series2.Points.Add(2003, 366)
            series2.Points.Add(2004, 422)
            series2.Points.Add(2005, 361)
            series2.Points.Add(2006, 289)
            series2.Points.Add(2007, 384)
            series2.Points.Add(2008, 461)
            series2.Style.Font.Bold = True
            Me.chartControl1.Series.Add(series1)
            Me.chartControl1.Series.Add(series2)
        End Sub
#End Region

#Region "InitializeControlSettings"
        Private Sub InitializeControlSettings()
            Dim legend1 As ChartLegend = New ChartLegend(chartControl1)
            legend1.Name = "legend1"
            legend1.ColumnsCount = 2
            legend1.RowsCount = 2
            legend1.RepresentationType = ChartLegendRepresentationType.None
            legend1.ShowSymbol = False
            legend1.Position = ChartDock.Bottom
            legend1.Alignment = ChartAlignment.Far

            Dim customItems As ChartLegendItem() = New ChartLegendItem() {}
            Dim clic As ChartLegendItemsCollection = New ChartLegendItemsCollection()
            Dim cli1 As ChartLegendItem = New ChartLegendItem("Point that follows a series point")
            cli1.Type = ChartLegendItemType.Circle
            cli1.RepresentationSize = New Size(8, 8)
            cli1.Interior = New BrushInfo(Color.Red)
            clic.Add(cli1)

            Dim cli2 As ChartLegendItem = New ChartLegendItem("Point that uses chart coordinates")
            cli2.Type = ChartLegendItemType.InvertedTriangle
            cli2.RepresentationSize = New Size(8, 8)
            cli2.Interior = New BrushInfo(Color.Yellow)
            clic.Add(cli2)

            Dim cli3 As ChartLegendItem = New ChartLegendItem("Point that follows a percent type")
            cli3.Type = ChartLegendItemType.Pentagon
            cli3.RepresentationSize = New Size(8, 8)
            cli3.Interior = New BrushInfo(Color.Blue)
            clic.Add(cli3)

            Dim cli4 As ChartLegendItem = New ChartLegendItem("Point that follows a pixel type")
            cli4.Type = ChartLegendItemType.Triangle
            cli4.RepresentationSize = New Size(8, 8)
            cli4.Interior = New BrushInfo(Color.Green)
            clic.Add(cli4)
            legend1.CustomItems = clic.ToArray()
            chartControl1.Legends.Add(legend1)
        End Sub
#End Region

#Region "Custom points"

        Protected Sub SetCustomPoints()
            ' Point that follows a series point:
            cp1.PointIndex = 1
            cp1.SeriesIndex = 1
            cp1.CustomType = ChartCustomPointType.PointFollow
            ' cp1.Text = "(Follows data point)";            
            cp1.Symbol.Shape = ChartSymbolShape.Circle
            cp1.Offset = 20
            cp1.Font.Facename = "Times New Roman"
            cp1.Font.Size = 9.0F
            cp1.Symbol.Color = Color.Red
            cp1.Alignment = ChartTextOrientation.Up
            cp1.Symbol.Marker.LineInfo.Width = 4
            Me.ChartControl1.CustomPoints.Add(cp1)

            ' Point that uses chart coordinates (not tied to a series):
            cp2.CustomType = ChartCustomPointType.ChartCoordinates
            cp2.XValue = 2003
            cp2.YValue = 289
            cp2.Symbol.Shape = ChartSymbolShape.InvertedTriangle
            cp2.Alignment = ChartTextOrientation.Smart
            cp2.Color = Color.Blue
            cp2.Font.Facename = "Times New Roman"
            cp2.Font.Size = 9.0F
            cp2.Symbol.Color = Color.Yellow
            ' cp2.Text = "(Any X,Y value in the plot)";
            Me.ChartControl1.CustomPoints.Add(cp2)

            ' Point that follows a percent type
            cp3.CustomType = ChartCustomPointType.Percent
            cp3.Symbol.Shape = ChartSymbolShape.Pentagon
            cp3.Symbol.Color = Color.Blue
            cp3.XValue = 68
            cp3.YValue = 47
            cp3.Offset = 10
            cp3.Color = Color.Blue
            cp3.Font.Facename = "Times New Roman"
            cp3.Font.Size = 9.0F
            cp3.Alignment = ChartTextOrientation.Up
            cp3.Symbol.Marker.LineInfo.Width = 4
            ' cp3.Text = "(Custom Point by Percentage of ChartArea)";

            Me.ChartControl1.CustomPoints.Add(cp3)

            ' Point that follows a pixel type
            cp4.CustomType = ChartCustomPointType.Pixel
            cp4.Symbol.Shape = ChartSymbolShape.Triangle
            cp4.Symbol.Color = Color.Green
            cp4.XValue = 190
            cp4.YValue = 135
            cp4.Color = Color.Blue
            cp4.Font.Facename = "Times New Roman"
            cp4.Font.Size = 9.0F
            cp4.Alignment = ChartTextOrientation.Up
            cp4.Symbol.Marker.LineInfo.Width = 4
            ' cp4.Text = "(Custom Point by Pixel)";
            cp4.Offset = 10
            Me.chartControl1.CustomPoints.Add(cp4)

            cp1.Symbol.Border.Width = 2
            cp2.Symbol.Border.Width = 2
            cp3.Symbol.Border.Width = 2
            cp4.Symbol.Border.Width = 2

            cp1.Symbol.Border.Color = Color.Yellow
            cp2.Symbol.Border.Color = Color.Black
            cp3.Symbol.Border.Color = Color.Red
            cp4.Symbol.Border.Color = Color.Magenta

            cp1.Symbol.Border.DashStyle = DashStyle.Solid
            cp2.Symbol.Border.DashStyle = DashStyle.Solid
            cp3.Symbol.Border.DashStyle = DashStyle.Solid

        End Sub

#Region "custom Point location"
        Private Sub CustomPoint1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown2.ValueChanged, numericUpDown1.ValueChanged
            cp1.PointIndex = Convert.ToInt32(Me.numericUpDown1.Value)
            cp1.SeriesIndex = Convert.ToInt32(Me.numericUpDown2.Value)
        End Sub

        Private Sub CustomPoint2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown3.ValueChanged, numericUpDown4.ValueChanged
            cp2.XValue = Convert.ToInt32(Me.numericUpDown4.Value)
            cp2.YValue = Convert.ToInt32(Me.numericUpDown3.Value)
        End Sub

        Private Sub CustomPoint3_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown5.ValueChanged, numericUpDown6.ValueChanged
            cp3.XValue = Convert.ToInt32(Me.numericUpDown5.Value)
            cp3.YValue = Convert.ToInt32(Me.numericUpDown6.Value)
        End Sub

        Private Sub CustomPoint4_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown7.ValueChanged, numericUpDown8.ValueChanged
            cp4.XValue = Convert.ToInt32(Me.numericUpDown7.Value)
            cp4.YValue = Convert.ToInt32(Me.numericUpDown8.Value)
        End Sub
#End Region
#End Region

#Region "EmptyPoint"
        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            SetEmptyPoint()
        End Sub


        Private Sub EmptyPoint_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown9.ValueChanged, numericUpDown10.ValueChanged
            SetEmptyPoint()
        End Sub

        Protected Sub SetEmptyPoint()
            Try
                i = Convert.ToInt32(Me.numericUpDown10.Value)
                j = Convert.ToInt32(Me.numericUpDown9.Value)
                Me.ChartControl1.Series(j).Points(i).IsEmpty = Me.checkBox1.Checked
            Catch
                MessageBox.Show("Data Point doesnt exists")
            End Try
            Me.ChartControl1.Refresh()
        End Sub
#End Region
    End Class
End Namespace
