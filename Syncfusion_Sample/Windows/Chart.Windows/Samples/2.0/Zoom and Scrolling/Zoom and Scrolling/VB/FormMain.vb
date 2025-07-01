Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms

Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Data.OleDb

Namespace KeyAndMouseZoomingSample
    Public Class Form1
        Inherits Syncfusion.Windows.Forms.Office2007Form
#Region "Private Members"
        Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private WithEvents ComboScrollDown As System.Windows.Forms.ComboBox
        Private WithEvents ComboScrollRight As System.Windows.Forms.ComboBox
        Private WithEvents ComboScrollUp As System.Windows.Forms.ComboBox
        Private WithEvents ComboScrollLeft As System.Windows.Forms.ComboBox
        Private WithEvents ComboZoomIn As System.Windows.Forms.ComboBox
        Private WithEvents ComboZoomOut As System.Windows.Forms.ComboBox
        Private WithEvents checkBox1 As CheckBox
        Private WithEvents comboBox1 As ComboBox
        Private label9 As Label
        Private label10 As Label
        Private autoLabel4 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private WithEvents comboBox2 As ComboBox
        Private autoLabel8 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private autoLabel7 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private autoLabel6 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private WithEvents comboBox4 As ComboBox
        Private WithEvents comboBox3 As ComboBox
        Private autoLabel9 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private components As IContainer
        Private Zoomforecolor As Color = Color.Red
        Private WithEvents checkBox2 As CheckBox
        Private autoLabel2 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private autoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private WithEvents checkBox3 As CheckBox
        Private label19 As Label
        Private label22 As Label
        Private label14 As Label
        Private label15 As Label
        Private label11 As Label
        Private label3 As Label
        Private label4 As Label
        Private label17 As Label
        Private label18 As Label
        Private label20 As Label
        Private panel9 As Panel
        Private textBox3 As TextBox
        Private WithEvents colorPickerButton As Syncfusion.Windows.Forms.ColorPickerButton
        Private panel1 As Panel
        Private textBox1 As TextBox
        Private WithEvents colorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
        Private panel2 As Panel
        Private textBox2 As TextBox
        Private WithEvents colorPickerButton4 As Syncfusion.Windows.Forms.ColorPickerButton
        Private label1 As Label
        Private label5 As Label
        Private label6 As Label
        Private label7 As Label
        Private imageListAdv1 As Syncfusion.Windows.Forms.Tools.ImageListAdv
        Private label8 As Label
        Private WithEvents comboBox5 As ComboBox
        Private WithEvents comboBox6 As ComboBox
        Private panel3 As Panel
        Private WithEvents comboBox8 As System.Windows.Forms.ComboBox
        Private WithEvents label16 As System.Windows.Forms.Label
        Private WithEvents comboBox7 As System.Windows.Forms.ComboBox
        Private WithEvents label13 As System.Windows.Forms.Label
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents label12 As System.Windows.Forms.Label
        Private WithEvents checkBox4 As System.Windows.Forms.CheckBox
        Private ZoomBackcolor As Color = Color.Black
#End Region

#Region "Form's Constructor, Main and Dispose"
        Public Sub New()
            InitializeComponent()
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.autoLabel2 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.autoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.ComboScrollDown = New System.Windows.Forms.ComboBox
            Me.ComboScrollRight = New System.Windows.Forms.ComboBox
            Me.ComboScrollUp = New System.Windows.Forms.ComboBox
            Me.ComboScrollLeft = New System.Windows.Forms.ComboBox
            Me.ComboZoomIn = New System.Windows.Forms.ComboBox
            Me.ComboZoomOut = New System.Windows.Forms.ComboBox
            Me.checkBox3 = New System.Windows.Forms.CheckBox
            Me.comboBox4 = New System.Windows.Forms.ComboBox
            Me.comboBox3 = New System.Windows.Forms.ComboBox
            Me.autoLabel9 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.autoLabel8 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.autoLabel7 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.autoLabel6 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.autoLabel4 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.label10 = New System.Windows.Forms.Label
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label9 = New System.Windows.Forms.Label
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.label19 = New System.Windows.Forms.Label
            Me.label22 = New System.Windows.Forms.Label
            Me.label14 = New System.Windows.Forms.Label
            Me.label15 = New System.Windows.Forms.Label
            Me.label11 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label17 = New System.Windows.Forms.Label
            Me.label18 = New System.Windows.Forms.Label
            Me.label20 = New System.Windows.Forms.Label
            Me.panel9 = New System.Windows.Forms.Panel
            Me.textBox3 = New System.Windows.Forms.TextBox
            Me.colorPickerButton = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.panel1 = New System.Windows.Forms.Panel
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.panel2 = New System.Windows.Forms.Panel
            Me.textBox2 = New System.Windows.Forms.TextBox
            Me.colorPickerButton4 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.label1 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.imageListAdv1 = New Syncfusion.Windows.Forms.Tools.ImageListAdv(Me.components)
            Me.label8 = New System.Windows.Forms.Label
            Me.comboBox5 = New System.Windows.Forms.ComboBox
            Me.comboBox6 = New System.Windows.Forms.ComboBox
            Me.panel3 = New System.Windows.Forms.Panel
            Me.comboBox8 = New System.Windows.Forms.ComboBox
            Me.label16 = New System.Windows.Forms.Label
            Me.comboBox7 = New System.Windows.Forms.ComboBox
            Me.label13 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.label12 = New System.Windows.Forms.Label
            Me.checkBox4 = New System.Windows.Forms.CheckBox
            Me.panel9.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.White, System.Drawing.Color.White)
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Etched
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent)
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.EnableXZooming = True
            Me.chartControl1.EnableYZooming = True
            Me.chartControl1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            '
            '
            '
            Me.chartControl1.Legend.Location = New System.Drawing.Point(62, 74)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.Location = New System.Drawing.Point(34, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.PrimaryXAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(1850, 2007, 10)
            Me.chartControl1.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.Size = New System.Drawing.Size(546, 345)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "Temperature Anomaly"
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'autoLabel2
            '
            Me.autoLabel2.DX = 0
            Me.autoLabel2.DY = 0
            Me.autoLabel2.ForeColor = System.Drawing.Color.Black
            Me.autoLabel2.Location = New System.Drawing.Point(199, 267)
            Me.autoLabel2.Name = "autoLabel2"
            Me.autoLabel2.Size = New System.Drawing.Size(85, 13)
            Me.autoLabel2.TabIndex = 21
            Me.autoLabel2.Text = "ZoomingFactorY"
            '
            'autoLabel1
            '
            Me.autoLabel1.DX = 0
            Me.autoLabel1.DY = 0
            Me.autoLabel1.ForeColor = System.Drawing.Color.Black
            Me.autoLabel1.Location = New System.Drawing.Point(199, 241)
            Me.autoLabel1.Name = "autoLabel1"
            Me.autoLabel1.Size = New System.Drawing.Size(85, 13)
            Me.autoLabel1.TabIndex = 20
            Me.autoLabel1.Text = "ZoomingFactorX"
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.Checked = True
            Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox2.ForeColor = System.Drawing.Color.Black
            Me.checkBox2.Location = New System.Drawing.Point(399, 41)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(106, 17)
            Me.checkBox2.TabIndex = 17
            Me.checkBox2.Text = "Show Scroll Bars"
            Me.checkBox2.UseVisualStyleBackColor = True
			Me.checkBox2.Visible = False
			Me.checkBox2.Enabled = False
            '
            'ComboScrollDown
            '
            Me.ComboScrollDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboScrollDown.Location = New System.Drawing.Point(498, 175)
            Me.ComboScrollDown.Name = "ComboScrollDown"
            Me.ComboScrollDown.Size = New System.Drawing.Size(85, 21)
            Me.ComboScrollDown.TabIndex = 10
            '
            'ComboScrollRight
            '
            Me.ComboScrollRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboScrollRight.Location = New System.Drawing.Point(498, 99)
            Me.ComboScrollRight.Name = "ComboScrollRight"
            Me.ComboScrollRight.Size = New System.Drawing.Size(85, 21)
            Me.ComboScrollRight.TabIndex = 9
            '
            'ComboScrollUp
            '
            Me.ComboScrollUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboScrollUp.Location = New System.Drawing.Point(498, 150)
            Me.ComboScrollUp.Name = "ComboScrollUp"
            Me.ComboScrollUp.Size = New System.Drawing.Size(85, 21)
            Me.ComboScrollUp.TabIndex = 8
            '
            'ComboScrollLeft
            '
            Me.ComboScrollLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboScrollLeft.Location = New System.Drawing.Point(498, 125)
            Me.ComboScrollLeft.Name = "ComboScrollLeft"
            Me.ComboScrollLeft.Size = New System.Drawing.Size(85, 21)
            Me.ComboScrollLeft.TabIndex = 7
            '
            'ComboZoomIn
            '
            Me.ComboZoomIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboZoomIn.Location = New System.Drawing.Point(93, 241)
            Me.ComboZoomIn.Name = "ComboZoomIn"
            Me.ComboZoomIn.Size = New System.Drawing.Size(65, 21)
            Me.ComboZoomIn.TabIndex = 1
            '
            'ComboZoomOut
            '
            Me.ComboZoomOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboZoomOut.Location = New System.Drawing.Point(93, 267)
            Me.ComboZoomOut.Name = "ComboZoomOut"
            Me.ComboZoomOut.Size = New System.Drawing.Size(65, 21)
            Me.ComboZoomOut.TabIndex = 2
            '
            'checkBox3
            '
            Me.checkBox3.AutoSize = True
            Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.checkBox3.Location = New System.Drawing.Point(18, 40)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(120, 18)
            Me.checkBox3.TabIndex = 20
            Me.checkBox3.Text = "Show ZoomButton"
            Me.checkBox3.UseVisualStyleBackColor = True
            '
            'comboBox4
            '
            Me.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox4.FormattingEnabled = True
            Me.comboBox4.Items.AddRange(New Object() {"0.1", "0.2", "0.3 ", "0.4 ", "0.5 ", "0.6 ", "0.7 ", "0.8 ", "0.9 ", "1.0 "})
            Me.comboBox4.Location = New System.Drawing.Point(284, 99)
            Me.comboBox4.Name = "comboBox4"
            Me.comboBox4.Size = New System.Drawing.Size(54, 21)
            Me.comboBox4.TabIndex = 16
            '
            'comboBox3
            '
            Me.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox3.FormattingEnabled = True
            Me.comboBox3.Location = New System.Drawing.Point(284, 175)
            Me.comboBox3.Name = "comboBox3"
            Me.comboBox3.Size = New System.Drawing.Size(89, 21)
            Me.comboBox3.TabIndex = 13
            '
            'autoLabel9
            '
            Me.autoLabel9.DX = 0
            Me.autoLabel9.DY = 0
            Me.autoLabel9.ForeColor = System.Drawing.Color.Black
            Me.autoLabel9.Location = New System.Drawing.Point(199, 99)
            Me.autoLabel9.Name = "autoLabel9"
            Me.autoLabel9.Size = New System.Drawing.Size(43, 13)
            Me.autoLabel9.TabIndex = 12
            Me.autoLabel9.Text = "Opacity"
            '
            'autoLabel8
            '
            Me.autoLabel8.DX = 0
            Me.autoLabel8.DY = 0
            Me.autoLabel8.ForeColor = System.Drawing.Color.Black
            Me.autoLabel8.Location = New System.Drawing.Point(199, 150)
            Me.autoLabel8.Name = "autoLabel8"
            Me.autoLabel8.Size = New System.Drawing.Size(56, 13)
            Me.autoLabel8.TabIndex = 11
            Me.autoLabel8.Text = "BackColor"
            '
            'autoLabel7
            '
            Me.autoLabel7.DX = 0
            Me.autoLabel7.DY = 0
            Me.autoLabel7.ForeColor = System.Drawing.Color.Black
            Me.autoLabel7.Location = New System.Drawing.Point(199, 125)
            Me.autoLabel7.Name = "autoLabel7"
            Me.autoLabel7.Size = New System.Drawing.Size(52, 13)
            Me.autoLabel7.TabIndex = 10
            Me.autoLabel7.Text = "ForeColor"
            '
            'autoLabel6
            '
            Me.autoLabel6.DX = 0
            Me.autoLabel6.DY = 0
            Me.autoLabel6.ForeColor = System.Drawing.Color.Black
            Me.autoLabel6.Location = New System.Drawing.Point(199, 175)
            Me.autoLabel6.Name = "autoLabel6"
            Me.autoLabel6.Size = New System.Drawing.Size(73, 13)
            Me.autoLabel6.TabIndex = 9
            Me.autoLabel6.Text = "Gradient Style"
            '
            'comboBox2
            '
            Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox2.FormattingEnabled = True
            Me.comboBox2.Location = New System.Drawing.Point(93, 175)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(65, 21)
            Me.comboBox2.TabIndex = 7
            '
            'autoLabel4
            '
            Me.autoLabel4.DX = 0
            Me.autoLabel4.DY = 0
            Me.autoLabel4.ForeColor = System.Drawing.Color.Black
            Me.autoLabel4.Location = New System.Drawing.Point(18, 175)
            Me.autoLabel4.Name = "autoLabel4"
            Me.autoLabel4.Size = New System.Drawing.Size(58, 13)
            Me.autoLabel4.TabIndex = 6
            Me.autoLabel4.Text = "Dash Style"
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.ForeColor = System.Drawing.Color.Black
            Me.label10.Location = New System.Drawing.Point(18, 150)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(31, 13)
            Me.label10.TabIndex = 3
            Me.label10.Text = "Color"
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Items.AddRange(New Object() {"1.0", "2.0", "3.0", "4.0", "5.0", "6.0", "7.0", "8.0", "9.0"})
            Me.comboBox1.Location = New System.Drawing.Point(93, 125)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(65, 21)
            Me.comboBox1.Sorted = True
            Me.comboBox1.TabIndex = 2
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.ForeColor = System.Drawing.Color.Black
            Me.label9.Location = New System.Drawing.Point(18, 125)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(35, 13)
            Me.label9.TabIndex = 1
            Me.label9.Text = "Width"
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.checkBox1.Location = New System.Drawing.Point(18, 99)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(93, 18)
            Me.checkBox1.TabIndex = 0
            Me.checkBox1.Text = "Show Border"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'label19
            '
            Me.label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label19.Location = New System.Drawing.Point(18, 31)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(275, 1)
            Me.label19.TabIndex = 116
            '
            'label22
            '
            Me.label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label22.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label22.Image = CType(resources.GetObject("label22.Image"), System.Drawing.Image)
            Me.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label22.Location = New System.Drawing.Point(18, 11)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(75, 16)
            Me.label22.TabIndex = 115
            Me.label22.Text = "Zooming"
            Me.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label14
            '
            Me.label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label14.Location = New System.Drawing.Point(395, 31)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(185, 1)
            Me.label14.TabIndex = 118
            '
            'label15
            '
            Me.label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label15.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label15.Image = CType(resources.GetObject("label15.Image"), System.Drawing.Image)
            Me.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label15.Location = New System.Drawing.Point(393, 11)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(74, 17)
            Me.label15.TabIndex = 117
            Me.label15.Text = "Scrolling"
            Me.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.ForeColor = System.Drawing.Color.Black
            Me.label11.Location = New System.Drawing.Point(18, 241)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(64, 13)
            Me.label11.TabIndex = 119
            Me.label11.Text = "ZoomIn Key"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.ForeColor = System.Drawing.Color.Black
            Me.label3.Location = New System.Drawing.Point(18, 267)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(72, 13)
            Me.label3.TabIndex = 120
            Me.label3.Text = "ZoomOut Key"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.ForeColor = System.Drawing.Color.Black
            Me.label4.Location = New System.Drawing.Point(396, 99)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(96, 13)
            Me.label4.TabIndex = 121
            Me.label4.Text = "Scrolling Right Key"
            '
            'label17
            '
            Me.label17.AutoSize = True
            Me.label17.ForeColor = System.Drawing.Color.Black
            Me.label17.Location = New System.Drawing.Point(396, 125)
            Me.label17.Name = "label17"
            Me.label17.Size = New System.Drawing.Size(89, 13)
            Me.label17.TabIndex = 122
            Me.label17.Text = "Scrolling Left Key"
            '
            'label18
            '
            Me.label18.AutoSize = True
            Me.label18.ForeColor = System.Drawing.Color.Black
            Me.label18.Location = New System.Drawing.Point(396, 150)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(85, 13)
            Me.label18.TabIndex = 123
            Me.label18.Text = "Scrolling Up Key"
            '
            'label20
            '
            Me.label20.AutoSize = True
            Me.label20.ForeColor = System.Drawing.Color.Black
            Me.label20.Location = New System.Drawing.Point(396, 175)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(99, 13)
            Me.label20.TabIndex = 124
            Me.label20.Text = "Scrolling Down Key"
            '
            'panel9
            '
            Me.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel9.Controls.Add(Me.textBox3)
            Me.panel9.Controls.Add(Me.colorPickerButton)
            Me.panel9.Location = New System.Drawing.Point(90, 150)
            Me.panel9.Name = "panel9"
            Me.panel9.Size = New System.Drawing.Size(41, 21)
            Me.panel9.TabIndex = 127
            '
            'textBox3
            '
            Me.textBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.textBox3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox3.Location = New System.Drawing.Point(0, 0)
            Me.textBox3.Name = "textBox3"
            Me.textBox3.ReadOnly = True
            Me.textBox3.Size = New System.Drawing.Size(22, 20)
            Me.textBox3.TabIndex = 11
            '
            'colorPickerButton
            '
            Me.colorPickerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.colorPickerButton.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton.Image = CType(resources.GetObject("colorPickerButton.Image"), System.Drawing.Image)
            Me.colorPickerButton.Location = New System.Drawing.Point(22, 0)
            Me.colorPickerButton.Name = "colorPickerButton"
            Me.colorPickerButton.SelectedAsBackcolor = True
            Me.colorPickerButton.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.colorPickerButton.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton.Size = New System.Drawing.Size(17, 19)
            Me.colorPickerButton.TabIndex = 14
            Me.colorPickerButton.Text = "..."
            Me.colorPickerButton.UseVisualStyleBackColor = False
            '
            'panel1
            '
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.textBox1)
            Me.panel1.Controls.Add(Me.colorPickerButton1)
            Me.panel1.Location = New System.Drawing.Point(284, 125)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(41, 21)
            Me.panel1.TabIndex = 128
            '
            'textBox1
            '
            Me.textBox1.BackColor = System.Drawing.Color.Red
            Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox1.Location = New System.Drawing.Point(0, 0)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.ReadOnly = True
            Me.textBox1.Size = New System.Drawing.Size(22, 20)
            Me.textBox1.TabIndex = 11
            '
            'colorPickerButton1
            '
            Me.colorPickerButton1.BackColor = System.Drawing.Color.Red
            Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton1.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton1.Image = CType(resources.GetObject("colorPickerButton1.Image"), System.Drawing.Image)
            Me.colorPickerButton1.Location = New System.Drawing.Point(22, 0)
            Me.colorPickerButton1.Name = "colorPickerButton1"
            Me.colorPickerButton1.SelectedAsBackcolor = True
            Me.colorPickerButton1.SelectedColor = System.Drawing.Color.Red
            Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton1.Size = New System.Drawing.Size(17, 19)
            Me.colorPickerButton1.TabIndex = 14
            Me.colorPickerButton1.Text = "..."
            Me.colorPickerButton1.UseVisualStyleBackColor = False
            '
            'panel2
            '
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.Add(Me.textBox2)
            Me.panel2.Controls.Add(Me.colorPickerButton4)
            Me.panel2.Location = New System.Drawing.Point(284, 150)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(41, 21)
            Me.panel2.TabIndex = 129
            '
            'textBox2
            '
            Me.textBox2.BackColor = System.Drawing.Color.Yellow
            Me.textBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox2.Location = New System.Drawing.Point(0, 0)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.ReadOnly = True
            Me.textBox2.Size = New System.Drawing.Size(22, 20)
            Me.textBox2.TabIndex = 11
            '
            'colorPickerButton4
            '
            Me.colorPickerButton4.BackColor = System.Drawing.Color.Yellow
            Me.colorPickerButton4.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton4.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton4.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton4.Image = CType(resources.GetObject("colorPickerButton4.Image"), System.Drawing.Image)
            Me.colorPickerButton4.Location = New System.Drawing.Point(22, 0)
            Me.colorPickerButton4.Name = "colorPickerButton4"
            Me.colorPickerButton4.SelectedAsBackcolor = True
            Me.colorPickerButton4.SelectedColor = System.Drawing.Color.Yellow
            Me.colorPickerButton4.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton4.Size = New System.Drawing.Size(17, 19)
            Me.colorPickerButton4.TabIndex = 14
            Me.colorPickerButton4.Text = "..."
            Me.colorPickerButton4.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label1.Location = New System.Drawing.Point(18, 75)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(107, 13)
            Me.label1.TabIndex = 130
            Me.label1.Text = "ZoomArea Border"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label5.Location = New System.Drawing.Point(199, 75)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(113, 13)
            Me.label5.TabIndex = 131
            Me.label5.Text = "ZoomArea Interior"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label6.Location = New System.Drawing.Point(18, 219)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(86, 13)
            Me.label6.TabIndex = 132
            Me.label6.Text = "Zooming Keys"
            Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label7.Location = New System.Drawing.Point(199, 219)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(95, 13)
            Me.label7.TabIndex = 133
            Me.label7.Text = "Zooming Factor"
            Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'imageListAdv1
            '
            Me.imageListAdv1.Images.AddRange(New System.Drawing.Image() {CType(resources.GetObject("imageListAdv1.Images"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images1"), System.Drawing.Image)})
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label8.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label8.Location = New System.Drawing.Point(400, 75)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(85, 13)
            Me.label8.TabIndex = 135
            Me.label8.Text = "Scrolling Keys"
            Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'comboBox5
            '
            Me.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox5.Items.AddRange(New Object() {"0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1"})
            Me.comboBox5.Location = New System.Drawing.Point(284, 241)
            Me.comboBox5.Name = "comboBox5"
            Me.comboBox5.Size = New System.Drawing.Size(55, 21)
            Me.comboBox5.TabIndex = 136
            '
            'comboBox6
            '
            Me.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox6.Items.AddRange(New Object() {"0.1", "0.2", "0.3", "0.4", "0.5", "0.6", "0.7", "0.8", "0.9", "1"})
            Me.comboBox6.Location = New System.Drawing.Point(284, 267)
            Me.comboBox6.Name = "comboBox6"
            Me.comboBox6.Size = New System.Drawing.Size(55, 21)
            Me.comboBox6.TabIndex = 137
            '
            'panel3
            '
            Me.panel3.Controls.Add(Me.comboBox8)
            Me.panel3.Controls.Add(Me.label16)
            Me.panel3.Controls.Add(Me.comboBox7)
            Me.panel3.Controls.Add(Me.label13)
            Me.panel3.Controls.Add(Me.label2)
            Me.panel3.Controls.Add(Me.label12)
            Me.panel3.Controls.Add(Me.checkBox4)
            Me.panel3.Controls.Add(Me.label22)
            Me.panel3.Controls.Add(Me.comboBox6)
            Me.panel3.Controls.Add(Me.label3)
            Me.panel3.Controls.Add(Me.ComboZoomOut)
            Me.panel3.Controls.Add(Me.comboBox5)
            Me.panel3.Controls.Add(Me.ComboZoomIn)
            Me.panel3.Controls.Add(Me.label8)
            Me.panel3.Controls.Add(Me.ComboScrollLeft)
            Me.panel3.Controls.Add(Me.label7)
            Me.panel3.Controls.Add(Me.ComboScrollRight)
            Me.panel3.Controls.Add(Me.label6)
            Me.panel3.Controls.Add(Me.ComboScrollUp)
            Me.panel3.Controls.Add(Me.label5)
            Me.panel3.Controls.Add(Me.checkBox1)
            Me.panel3.Controls.Add(Me.label1)
            Me.panel3.Controls.Add(Me.ComboScrollDown)
            Me.panel3.Controls.Add(Me.panel2)
            Me.panel3.Controls.Add(Me.label9)
            Me.panel3.Controls.Add(Me.panel1)
            Me.panel3.Controls.Add(Me.comboBox1)
            Me.panel3.Controls.Add(Me.panel9)
            Me.panel3.Controls.Add(Me.label10)
            Me.panel3.Controls.Add(Me.checkBox3)
            Me.panel3.Controls.Add(Me.label19)
            Me.panel3.Controls.Add(Me.label20)
            Me.panel3.Controls.Add(Me.label15)
            Me.panel3.Controls.Add(Me.label18)
            Me.panel3.Controls.Add(Me.label14)
            Me.panel3.Controls.Add(Me.comboBox4)
            Me.panel3.Controls.Add(Me.autoLabel4)
            Me.panel3.Controls.Add(Me.checkBox2)
            Me.panel3.Controls.Add(Me.label11)
            Me.panel3.Controls.Add(Me.autoLabel9)
            Me.panel3.Controls.Add(Me.comboBox2)
            Me.panel3.Controls.Add(Me.autoLabel8)
            Me.panel3.Controls.Add(Me.label4)
            Me.panel3.Controls.Add(Me.autoLabel2)
            Me.panel3.Controls.Add(Me.autoLabel6)
            Me.panel3.Controls.Add(Me.comboBox3)
            Me.panel3.Controls.Add(Me.autoLabel1)
            Me.panel3.Controls.Add(Me.label17)
            Me.panel3.Controls.Add(Me.autoLabel7)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel3.Location = New System.Drawing.Point(0, 363)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(603, 302)
            Me.panel3.TabIndex = 138
            '
            'comboBox8
            '
            Me.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox8.FormattingEnabled = True
            Me.comboBox8.Items.AddRange(New Object() {"Panning", "None"})
            Me.comboBox8.Location = New System.Drawing.Point(499, 277)
            Me.comboBox8.Name = "comboBox8"
            Me.comboBox8.Size = New System.Drawing.Size(85, 21)
            Me.comboBox8.TabIndex = 151
            '
            'label16
            '
            Me.label16.AutoSize = True
            Me.label16.Location = New System.Drawing.Point(403, 281)
            Me.label16.Name = "label16"
            Me.label16.Size = New System.Drawing.Size(77, 13)
            Me.label16.TabIndex = 150
            Me.label16.Text = "Y-Zoom Action"
            '
            'comboBox7
            '
            Me.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox7.FormattingEnabled = True
            Me.comboBox7.Items.AddRange(New Object() {"Panning", "None"})
            Me.comboBox7.Location = New System.Drawing.Point(498, 252)
            Me.comboBox7.Name = "comboBox7"
            Me.comboBox7.Size = New System.Drawing.Size(85, 21)
            Me.comboBox7.TabIndex = 149
            '
            'label13
            '
            Me.label13.AutoSize = True
            Me.label13.Location = New System.Drawing.Point(402, 256)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(77, 13)
            Me.label13.TabIndex = 148
            Me.label13.Text = "X-Zoom Action"
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Image = CType(resources.GetObject("label2.Image"), System.Drawing.Image)
            Me.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label2.Location = New System.Drawing.Point(400, 199)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(75, 16)
            Me.label2.TabIndex = 146
            Me.label2.Text = "Panning"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label12
            '
            Me.label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label12.Location = New System.Drawing.Point(400, 219)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(185, 1)
            Me.label12.TabIndex = 147
            '
            'checkBox4
            '
            Me.checkBox4.AutoSize = True
            Me.checkBox4.Location = New System.Drawing.Point(403, 230)
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(101, 17)
            Me.checkBox4.TabIndex = 145
            Me.checkBox4.Text = "Enable Panning"
            Me.checkBox4.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(603, 665)
            Me.Controls.Add(Me.panel3)
            Me.Controls.Add(Me.chartControl1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Zoom and Scrolling"
            Me.panel9.ResumeLayout(False)
            Me.panel9.PerformLayout()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.SetBoxItems()
            InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region "Helper Methods"
#Region "InitializeChartData"
        Private model As ChartDataBindModel
        Private model1 As ChartDataBindModel
        Protected Sub InitializeChartData()

            Dim fileName As String = WinFormsUtils.FindFile("..\..\..\..\..\..\..\Common\Data\", "ChartTemperatureAnomaly.xls")

            'The Oledbconnection.
            Dim excelConn As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & fileName & ";Extended Properties=""Excel 8.0;HDR=Yes;""")
            excelConn.Open()
            'Query for retriving the data from the excel sheet.
            Dim query As String = "Select * From [Sheet1$A1:C159]"
            Dim excelCommand As OleDbCommand = New OleDbCommand(query, excelConn)
            Dim excelReader As OleDbDataReader = excelCommand.ExecuteReader(CommandBehavior.CloseConnection)

            'Load the contents to a dataset.
            Dim excelDataSet As DataSet = ConvertToDataSet(excelReader, "ExcelTable")

            'Initializes new chart series. 
            Dim series1 As ChartSeries = New ChartSeries()
            series1.Name = "Anomaly"
            series1.Text = "Anomaly"
            series1.Type = ChartSeriesType.Spline
            model1 = New ChartDataBindModel(excelDataSet, "ExcelTable")
            model1.XName = "X Value"
            model1.YNames = New String() {"Y Value"}
            series1.SeriesModel = model1
            Me.chartControl1.Series.Add(series1)

            'Initializes new chart series.
            Dim series2 As ChartSeries = New ChartSeries()
            series2.Name = "Smoothed"
            series2.Text = "Smoothed"
            series2.Type = ChartSeriesType.SplineArea
            model = New ChartDataBindModel(excelDataSet, "ExcelTable")
            model.XName = "X Value"
            model.YNames = New String() {"Z Value"}
            series2.SeriesModel = model
            Me.chartControl1.Series.Add(series2)

            'Close the connection.
            excelReader.Close()
            excelConn.Close()
        End Sub
#End Region

#Region "ConvertToDataSet"
        ''' <summary>
        ''' Converts DataReader to DataSet.
        ''' </summary>
        ''' <param name="myReader"></param>
        ''' <param name="tableName"></param>
        ''' <returns></returns>
        Protected Function ConvertToDataSet(ByVal dataReader As OleDbDataReader, ByVal tableName As String) As DataSet
            Dim dataSet As DataSet = New DataSet()
            Do
                ' Create new data table

                Dim schemaTable As DataTable = dataReader.GetSchemaTable()
                Dim dataTable As DataTable = New DataTable(tableName)

                If schemaTable IsNot Nothing Then
                    ' A query returning records was executed

                    For i As Integer = 0 To schemaTable.Rows.Count - 1
                        Dim dataRow As DataRow = schemaTable.Rows(i)
                        ' Create a column name that is unique in the data table
                        Dim columnName As String = CStr(dataRow("ColumnName"))
                        ' Add the column definition to the data table
                        Dim column As DataColumn = New DataColumn(columnName, CType(dataRow("DataType"), Type))
                        dataTable.Columns.Add(column)
                    Next i

                    'Add the data table to the dataset.
                    dataSet.Tables.Add(dataTable)

                    ' Fill the data table.
                    Do While dataReader.Read()
                        Dim dataRow As DataRow = dataTable.NewRow()

                        For i As Integer = 0 To dataReader.FieldCount - 1
                            dataRow(i) = dataReader.GetValue(i)
                        Next i

                        dataTable.Rows.Add(dataRow)
                    Loop
                Else
                    ' No records were returned.

                    Dim column As DataColumn = New DataColumn("RowsAffected")
                    dataTable.Columns.Add(column)
                    dataSet.Tables.Add(dataTable)
                    Dim dataRow As DataRow = dataTable.NewRow()
                    dataRow(0) = dataReader.RecordsAffected
                    dataTable.Rows.Add(dataRow)
                End If
            Loop While dataReader.NextResult()
            Return dataSet
        End Function
#End Region

#Region "SetBoxItems"
        Private Sub SetBoxItems()
            Me.ComboZoomIn.Items.Add("+")
            Me.ComboZoomIn.Items.Add(Keys.A)
            Me.ComboZoomIn.Items.Add(Keys.P)
            Me.ComboZoomOut.Items.Add("-")
            Me.ComboZoomOut.Items.Add(Keys.B)
            Me.ComboZoomOut.Items.Add(Keys.O)
            Me.ComboScrollRight.Items.Add(Keys.Right)
            Me.ComboScrollRight.Items.Add(Keys.NumPad6)
            Me.ComboScrollRight.Items.Add(Keys.R)
            Me.ComboScrollLeft.Items.Add(Keys.Left)
            Me.ComboScrollLeft.Items.Add(Keys.NumPad4)
            Me.ComboScrollLeft.Items.Add(Keys.L)
            Me.ComboScrollUp.Items.Add(Keys.Up)
            Me.ComboScrollUp.Items.Add(Keys.NumPad8)
            Me.ComboScrollUp.Items.Add(Keys.F10)
            Me.ComboScrollDown.Items.Add(Keys.Down)
            Me.ComboScrollDown.Items.Add(Keys.NumPad2)
            Me.ComboScrollDown.Items.Add(Keys.F4)
            Me.chartControl1.ZoomCancel = Keys.Escape

            For Each dashtype As String In System.Enum.GetNames(GetType(System.Drawing.Drawing2D.DashStyle))
                Me.comboBox2.Items.Add(dashtype)
            Next dashtype
            Me.comboBox2.SelectedIndex = 0

            For Each gradient As String In System.Enum.GetNames(GetType(Syncfusion.Drawing.GradientStyle))
                Me.comboBox3.Items.Add(gradient)
            Next gradient

            Me.comboBox3.SelectedIndex = 1
            Me.comboBox4.SelectedIndex = 6
            Me.comboBox1.SelectedIndex = 0
            Me.ComboZoomIn.SelectedIndex = 0
            Me.ComboZoomOut.SelectedIndex = 0
            Me.ComboScrollRight.SelectedIndex = 0
            Me.ComboScrollLeft.SelectedIndex = 0
            Me.ComboScrollUp.SelectedIndex = 0
            Me.ComboScrollDown.SelectedIndex = 0
            Me.comboBox5.SelectedIndex = 9
            Me.comboBox6.SelectedIndex = 9
        End Sub
#End Region
#End Region

#Region "Events"

        Private Sub ComboZoomIn_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboZoomIn.SelectedIndexChanged
            Me.chartControl1.Focus()
            Dim select1 As String = Me.ComboZoomIn.SelectedItem.ToString()
            Select Case select1
                Case "+"
                    Me.chartControl1.ZoomIn = Keys.Oemplus

                Case "A"
                    Me.chartControl1.ZoomIn = Keys.A

                Case "P"
                    Me.chartControl1.ZoomIn = Keys.P

                Case Else
                    Me.chartControl1.ZoomIn = Keys.Oemplus
            End Select
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub ComboZoomOut_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboZoomOut.SelectedIndexChanged
            Me.chartControl1.Focus()
            Dim select1 As String = Me.ComboZoomOut.SelectedItem.ToString()

            Select Case select1
                Case "-"
                    Me.chartControl1.ZoomOut = Keys.OemMinus

                Case "B"
                    Me.chartControl1.ZoomOut = Keys.B

                Case "O"
                    Me.chartControl1.ZoomOut = Keys.O

                Case Else
                    Me.chartControl1.ZoomOut = Keys.OemMinus
            End Select

            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub ComboScrollRight_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboScrollRight.SelectedIndexChanged
            Me.chartControl1.Focus()
            Dim select1 As String = Me.ComboScrollRight.SelectedItem.ToString()

            Select Case select1
                Case "Right"
                    Me.chartControl1.ZoomRight = Keys.Right

                Case "NumPad6"
                    Me.chartControl1.ZoomRight = Keys.NumPad6

                Case "R"
                    Me.chartControl1.ZoomRight = Keys.R

                Case Else
                    Me.chartControl1.ZoomRight = Keys.Right
            End Select
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub ComboScrollLeft_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboScrollLeft.SelectedIndexChanged
            Me.chartControl1.Focus()
            Dim select1 As String = Me.ComboScrollLeft.SelectedItem.ToString()

            Select Case select1
                Case "Left"
                    Me.chartControl1.ZoomLeft = Keys.Left

                Case "NumPad4"
                    Me.chartControl1.ZoomLeft = Keys.NumPad4

                Case "L"
                    Me.chartControl1.ZoomLeft = Keys.L

                Case Else
                    Me.chartControl1.ZoomLeft = Keys.Left
            End Select
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub ComboScrollUp_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboScrollUp.SelectedIndexChanged
            Me.chartControl1.Focus()
            Dim select1 As String = Me.ComboScrollUp.SelectedItem.ToString()

            Select Case select1
                Case "Up"
                    Me.chartControl1.ZoomUp = Keys.Up

                Case "NumPad8"
                    Me.chartControl1.ZoomUp = Keys.NumPad8

                Case "F10"
                    Me.chartControl1.ZoomUp = Keys.F10

                Case Else
                    Me.chartControl1.ZoomUp = Keys.Up
            End Select
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub ComboScrollDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboScrollDown.SelectedIndexChanged
            Me.chartControl1.Focus()
            Dim select1 As String = Me.ComboScrollDown.SelectedItem.ToString()

            Select Case select1
                Case "Down"
                    Me.chartControl1.ZoomDown = Keys.Down

                Case "NumPad2"
                    Me.chartControl1.ZoomDown = Keys.NumPad2

                Case "F4"
                    Me.chartControl1.ZoomDown = Keys.F4

                Case Else
                    Me.chartControl1.ZoomDown = Keys.Down
            End Select
        End Sub

        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
            Me.chartControl1.Zooming.Border.Width = CSng(Convert.ToDouble(comboBox1.SelectedItem))
        End Sub

        Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox2.SelectedIndexChanged
            Me.chartControl1.Zooming.Border.DashStyle = CType(System.Enum.Parse(GetType(System.Drawing.Drawing2D.DashStyle), Me.comboBox2.SelectedItem.ToString(), True), System.Drawing.Drawing2D.DashStyle)
        End Sub
        Private Sub comboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox3.SelectedIndexChanged
            Zoomforecolor = Me.colorPickerButton1.SelectedColor
            ZoomBackcolor = Me.colorPickerButton4.SelectedColor
            Me.chartControl1.Zooming.Interior = New BrushInfo(CType(System.Enum.Parse(GetType(GradientStyle), Me.comboBox3.SelectedItem.ToString(), True), GradientStyle), Zoomforecolor, ZoomBackcolor)
        End Sub

        Private Sub comboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox4.SelectedIndexChanged
            Me.chartControl1.Zooming.Opacity = CSng(Convert.ToDouble(comboBox4.SelectedItem))
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            If checkBox1.Checked = True Then
                Me.chartControl1.Zooming.ShowBorder = True
                Me.comboBox1.Enabled = True
                Me.comboBox2.Enabled = True
                Me.colorPickerButton1.Enabled = True
            ElseIf checkBox1.Checked = False Then
                Me.chartControl1.Zooming.ShowBorder = False
                Me.comboBox1.Enabled = False
                Me.comboBox2.Enabled = False
                Me.colorPickerButton1.Enabled = False
            End If
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            If checkBox2.Checked = False Then
                Me.chartControl1.ShowScrollBars = False
            Else
                Me.chartControl1.ShowScrollBars = True
            End If
        End Sub

        Private Sub comboBox5_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox5.SelectedIndexChanged
            If Me.checkBox2.Checked Then
                Me.chartControl1.ShowScrollBars = True
            Else
                Me.chartControl1.ShowScrollBars = False
            End If
            Me.chartControl1.ZoomFactorX = Convert.ToDouble(Me.comboBox5.SelectedItem)
        End Sub
        Private Sub comboBox6_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox6.SelectedIndexChanged
            If Me.checkBox2.Checked Then
                Me.chartControl1.ShowScrollBars = True
            Else
                Me.chartControl1.ShowScrollBars = False
            End If

            Me.chartControl1.ZoomFactorY = Convert.ToDouble(Me.comboBox6.SelectedItem)
        End Sub

        Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As EventArgs)
            If checkBox2.Checked = False Then
                Me.chartControl1.ShowScrollBars = False
            Else
                Me.chartControl1.ShowScrollBars = True
            End If
        End Sub
#Region "Show/Hide Zoom Button"
        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckedChanged
            If Me.checkBox3.Checked Then
                Me.chartControl1.GetVScrollBar(Me.chartControl1.PrimaryYAxis).ZoomButton.Size = New Size(14, 14)
                Me.chartControl1.GetHScrollBar(Me.chartControl1.PrimaryXAxis).ZoomButton.Size = New Size(14, 14)
                Me.chartControl1.Redraw(True)
            Else
                Me.chartControl1.GetVScrollBar(Me.chartControl1.PrimaryYAxis).ZoomButton.Size = New Size(0, 0)
                Me.chartControl1.GetHScrollBar(Me.chartControl1.PrimaryXAxis).ZoomButton.Size = New Size(0, 0)
                Me.chartControl1.Redraw(True)
            End If

        End Sub
#End Region

        Private Sub colorPickerButton_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton.ColorSelected
            Me.chartControl1.Zooming.Border.ForeColor = Me.colorPickerButton.SelectedColor
            Me.textBox3.BackColor = Me.colorPickerButton.SelectedColor
        End Sub

        Private Sub colorPickerButton1_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton1.ColorSelected
            Zoomforecolor = Me.colorPickerButton1.SelectedColor
            Me.chartControl1.Zooming.Interior = New BrushInfo(CType(System.Enum.Parse(GetType(GradientStyle), Me.comboBox3.SelectedItem.ToString(), True), GradientStyle), Zoomforecolor, ZoomBackcolor)
            Me.textBox1.BackColor = Me.colorPickerButton1.SelectedColor
        End Sub

        Private Sub colorPickerButton4_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton4.ColorSelected
            ZoomBackcolor = Me.colorPickerButton4.SelectedColor
            Me.chartControl1.Zooming.Interior = New BrushInfo(CType(System.Enum.Parse(GetType(GradientStyle), Me.comboBox3.SelectedItem.ToString(), True), GradientStyle), Zoomforecolor, ZoomBackcolor)
            Me.textBox2.BackColor = Me.colorPickerButton4.SelectedColor
        End Sub
        Private Sub checkBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBox4.CheckedChanged
            If checkBox4.Checked Then
                Me.chartControl1.MouseAction = ChartMouseAction.Panning
                Me.comboBox7.Enabled = True
                Me.comboBox8.Enabled = True
            Else
                Me.chartControl1.MouseAction = ChartMouseAction.Zooming
                Me.comboBox7.Enabled = False
                Me.comboBox8.Enabled = True
            End If
        End Sub

        Private Sub comboBox7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBox7.SelectedIndexChanged
            Me.chartControl1.PrimaryXAxis.ZoomActions = CType(System.Enum.Parse(GetType(ChartZoomingAction), Me.comboBox7.SelectedItem.ToString(), True), ChartZoomingAction)

        End Sub

        Private Sub comboBox8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBox8.SelectedIndexChanged
            Me.chartControl1.PrimaryYAxis.ZoomActions = CType(System.Enum.Parse(GetType(ChartZoomingAction), Me.comboBox8.SelectedItem.ToString(), True), ChartZoomingAction)

        End Sub
#End Region
    End Class
End Namespace