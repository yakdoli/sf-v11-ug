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
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Chart
Imports System.Reflection
Imports System.IO

Namespace ToolBarSample
	Public Class Form1
		Inherits Syncfusion.Windows.Forms.Office2007Form
		#Region "Private Members"
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private label11 As Label
		Private label9 As Label
		Private label3 As Label
		Private WithEvents comboBox3 As ComboBox
		Private WithEvents checkBox3 As CheckBox
		Private label8 As Label
		Private WithEvents numericUpDown1 As NumericUpDown
		Private label6 As Label
		Private WithEvents numericUpDown2 As NumericUpDown
		Private label7 As Label
		Private label10 As Label
		Private label12 As Label
		Private chartControl1 As ChartControl
		Private WithEvents checkBox2 As CheckBox
		Private panel9 As Panel
		Private textBox_TextColor As TextBox
		Private WithEvents colorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
		Private label1 As Label
		Private panel1 As Panel
		Private textBox1 As TextBox
		Private WithEvents colorPickerButton2 As Syncfusion.Windows.Forms.ColorPickerButton
		Private label4 As Label
		Private label5 As Label
		Private panel2 As Panel
		Private textBox2 As TextBox
		Private WithEvents colorPickerButton3 As Syncfusion.Windows.Forms.ColorPickerButton
		Private WithEvents button1 As Button
		Private WithEvents numericUpDown3 As NumericUpDown
        Private color As Color() = New Color() {System.Drawing.Color.FromArgb(120, 75, 176), System.Drawing.Color.FromArgb(171, 107, 251), System.Drawing.Color.FromArgb(120, 75, 176)}
        Private WithEvents checkBox4 As CheckBox
        Private WithEvents ComboBox1 As System.Windows.Forms.ComboBox
        Private WithEvents Label2 As System.Windows.Forms.Label
        Private color2 As Color() = New Color() {System.Drawing.Color.FromArgb(80, 157, 89), System.Drawing.Color.FromArgb(114, 224, 127), System.Drawing.Color.FromArgb(80, 157, 89)}

#End Region

#Region "Form's Constructor, Main And dispose"
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
            'Dim ChartToolBarSaveItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem
            'Dim ChartToolBarCopyItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem
            'Dim ChartToolBarPrintItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem
            'Dim ChartToolBarPrintPreviewItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem
            'Dim ChartToolBarSplitter1 As Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter = New Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter
            'Dim ChartToolBarPaletteItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem
            'Dim ChartToolBarStyleItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem
            'Dim ChartToolBarTypeItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem
            'Dim ChartToolBarSeries3DItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem
            'Dim ChartToolBarShowLegendItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem
            Dim ChartToolBarSplitter2 As Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter = New Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter
            Dim ChartToolBarCommandItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem
            Dim ChartToolBarCommandItem2 As Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem
            Dim ChartToolBarCommandItem3 As Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem
            Dim ChartToolBarCommandItem4 As Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem
            Dim ChartToolBarCommandItem5 As Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem
            Dim ChartToolBarCommandItem6 As Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem
            Me.label12 = New System.Windows.Forms.Label
            Me.numericUpDown3 = New System.Windows.Forms.NumericUpDown
            Me.checkBox3 = New System.Windows.Forms.CheckBox
            Me.label9 = New System.Windows.Forms.Label
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.label11 = New System.Windows.Forms.Label
            Me.comboBox3 = New System.Windows.Forms.ComboBox
            Me.label3 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.label10 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown
            Me.label8 = New System.Windows.Forms.Label
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.panel9 = New System.Windows.Forms.Panel
            Me.textBox_TextColor = New System.Windows.Forms.TextBox
            Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.label1 = New System.Windows.Forms.Label
            Me.panel1 = New System.Windows.Forms.Panel
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.colorPickerButton2 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.label4 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.panel2 = New System.Windows.Forms.Panel
            Me.textBox2 = New System.Windows.Forms.TextBox
            Me.colorPickerButton3 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.button1 = New System.Windows.Forms.Button
            Me.checkBox4 = New System.Windows.Forms.CheckBox
            Me.ComboBox1 = New System.Windows.Forms.ComboBox
            Me.Label2 = New System.Windows.Forms.Label
            CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel9.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label12.ForeColor = System.Drawing.Color.Black
            Me.label12.Location = New System.Drawing.Point(288, 604)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(69, 13)
            Me.label12.TabIndex = 22
            Me.label12.Text = "Border Width"
            '
            'numericUpDown3
            '
            Me.numericUpDown3.Location = New System.Drawing.Point(382, 604)
            Me.numericUpDown3.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
            Me.numericUpDown3.Name = "numericUpDown3"
            Me.numericUpDown3.ReadOnly = True
            Me.numericUpDown3.Size = New System.Drawing.Size(47, 20)
            Me.numericUpDown3.TabIndex = 21
            Me.numericUpDown3.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'checkBox3
            '
            Me.checkBox3.AutoSize = True
            Me.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox3.Location = New System.Drawing.Point(44, 547)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(92, 18)
            Me.checkBox3.TabIndex = 18
            Me.checkBox3.Text = "Show Dialog"
            '
            'label9
            '
            Me.label9.BackColor = System.Drawing.Color.Transparent
            Me.label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label9.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label9.Image = CType(resources.GetObject("label9.Image"), System.Drawing.Image)
            Me.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label9.Location = New System.Drawing.Point(44, 440)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(135, 22)
            Me.label9.TabIndex = 4
            Me.label9.Text = "Toolbar Settings"
            Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox1.Location = New System.Drawing.Point(44, 523)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(93, 18)
            Me.checkBox1.TabIndex = 2
            Me.checkBox1.Text = "Show Border"
            '
            'label11
            '
            Me.label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label11.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label11.Location = New System.Drawing.Point(44, 462)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(175, 1)
            Me.label11.TabIndex = 5
            '
            'comboBox3
            '
            Me.comboBox3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox3.Items.AddRange(New Object() {"Left", "Right", "Top", "Bottom", "Floating"})
            Me.comboBox3.Location = New System.Drawing.Point(98, 599)
            Me.comboBox3.Name = "comboBox3"
            Me.comboBox3.Size = New System.Drawing.Size(83, 21)
            Me.comboBox3.TabIndex = 8
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label3.Location = New System.Drawing.Point(44, 601)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(44, 13)
            Me.label3.TabIndex = 9
            Me.label3.Text = "Position"
            '
            'label7
            '
            Me.label7.BackColor = System.Drawing.Color.Transparent
            Me.label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label7.Image = CType(resources.GetObject("label7.Image"), System.Drawing.Image)
            Me.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label7.Location = New System.Drawing.Point(288, 440)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(162, 22)
            Me.label7.TabIndex = 23
            Me.label7.Text = "Appearance Settings"
            Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label10
            '
            Me.label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label10.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label10.Location = New System.Drawing.Point(288, 463)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(175, 1)
            Me.label10.TabIndex = 24
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label6.ForeColor = System.Drawing.Color.Black
            Me.label6.Location = New System.Drawing.Point(288, 501)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(46, 13)
            Me.label6.TabIndex = 22
            Me.label6.Text = "Spacing"
            '
            'numericUpDown2
            '
            Me.numericUpDown2.Location = New System.Drawing.Point(382, 501)
            Me.numericUpDown2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.numericUpDown2.Name = "numericUpDown2"
            Me.numericUpDown2.ReadOnly = True
            Me.numericUpDown2.Size = New System.Drawing.Size(47, 20)
            Me.numericUpDown2.TabIndex = 21
            Me.numericUpDown2.Value = New Decimal(New Integer() {2, 0, 0, 0})
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label8.ForeColor = System.Drawing.Color.Black
            Me.label8.Location = New System.Drawing.Point(288, 476)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(42, 13)
            Me.label8.TabIndex = 20
            Me.label8.Text = "Header"
            '
            'numericUpDown1
            '
            Me.numericUpDown1.Location = New System.Drawing.Point(382, 476)
            Me.numericUpDown1.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.ReadOnly = True
            Me.numericUpDown1.Size = New System.Drawing.Size(47, 20)
            Me.numericUpDown1.TabIndex = 19
            Me.numericUpDown1.Value = New Decimal(New Integer() {7, 0, 0, 0})
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White)
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Etched
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.WhiteSmoke, System.Drawing.Color.Silver)
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(62, 82)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.Location = New System.Drawing.Point(22, 5)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.PrimaryYAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 500, 100)
            Me.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            '
            '
            '
            Me.chartControl1.PrintDocument.ColorMode = Syncfusion.Windows.Forms.Chart.ChartPrintColorMode.GrayScale
            Me.chartControl1.ShowToolbar = True
            Me.chartControl1.ShowToolTips = True
            Me.chartControl1.Size = New System.Drawing.Size(452, 432)
            Me.chartControl1.TabIndex = 0
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = ""
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ToolBar.BackColor = System.Drawing.Color.DarkGray
            Me.chartControl1.ToolBar.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.chartControl1.ToolBar.ButtonForeColor = System.Drawing.Color.Gray
            Me.chartControl1.ToolBar.ButtonSize = New System.Drawing.Size(28, 28)
            Me.chartControl1.ToolBar.Header = 7
            Me.chartControl1.ToolBar.IconPadding = 5
            ChartToolBarCommandItem1.Command = Syncfusion.Windows.Forms.Chart.ChartCommands.ZoomIn
            ChartToolBarCommandItem1.Parameter = Nothing
            ChartToolBarCommandItem1.ToolTip = "Zoom In"
            ChartToolBarCommandItem2.Command = Syncfusion.Windows.Forms.Chart.ChartCommands.ZoomOut
            ChartToolBarCommandItem2.Parameter = Nothing
            ChartToolBarCommandItem2.ToolTip = "Zoom Out"
            ChartToolBarCommandItem3.Command = Syncfusion.Windows.Forms.Chart.ChartCommands.ResetZooming
            ChartToolBarCommandItem3.Parameter = Nothing
            ChartToolBarCommandItem3.ToolTip = "Reset Zooming"
            ChartToolBarCommandItem4.Command = Syncfusion.Windows.Forms.Chart.ChartCommands.ToggleXZooming
            ChartToolBarCommandItem4.Parameter = Nothing
            ChartToolBarCommandItem4.ToolTip = "Enable X Zooming"
            ChartToolBarCommandItem5.Command = Syncfusion.Windows.Forms.Chart.ChartCommands.ToggleYZooming
            ChartToolBarCommandItem5.Parameter = Nothing
            ChartToolBarCommandItem5.ToolTip = "Enable Y Zooming"
            ChartToolBarCommandItem6.Command = Syncfusion.Windows.Forms.Chart.ChartCommands.TogglePanning
            ChartToolBarCommandItem6.Parameter = Nothing
            ChartToolBarCommandItem6.ToolTip = "Panning"
            'Me.chartControl1.ToolBar.Items.Add(ChartToolBarSaveItem1)
            'Me.chartControl1.ToolBar.Items.Add(ChartToolBarCopyItem1)
            'Me.chartControl1.ToolBar.Items.Add(ChartToolBarPrintItem1)
            'Me.chartControl1.ToolBar.Items.Add(ChartToolBarPrintPreviewItem1)
            'Me.chartControl1.ToolBar.Items.Add(ChartToolBarSplitter1)
            'Me.chartControl1.ToolBar.Items.Add(ChartToolBarPaletteItem1)
            'Me.chartControl1.ToolBar.Items.Add(ChartToolBarStyleItem1)
            'Me.chartControl1.ToolBar.Items.Add(ChartToolBarTypeItem1)
            'Me.chartControl1.ToolBar.Items.Add(ChartToolBarSeries3DItem1)
            'Me.chartControl1.ToolBar.Items.Add(ChartToolBarShowLegendItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarSplitter2)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarCommandItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarCommandItem2)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarCommandItem3)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarCommandItem4)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarCommandItem5)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarCommandItem6)
            Me.chartControl1.ToolBar.Padding = 5
            Me.chartControl1.ToolBar.ShowGrip = False
            Me.chartControl1.ToolBar.Spacing = 2
            Me.chartControl1.ToolBar.Visible = True
            Me.chartControl1.ZoomOutIncrement = 1.5
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox2.Location = New System.Drawing.Point(44, 499)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(81, 18)
            Me.checkBox2.TabIndex = 25
            Me.checkBox2.Text = "Show Grip"
            '
            'panel9
            '
            Me.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel9.Controls.Add(Me.textBox_TextColor)
            Me.panel9.Controls.Add(Me.colorPickerButton1)
            Me.panel9.Location = New System.Drawing.Point(382, 526)
            Me.panel9.Name = "panel9"
            Me.panel9.Size = New System.Drawing.Size(45, 21)
            Me.panel9.TabIndex = 77
            '
            'textBox_TextColor
            '
            Me.textBox_TextColor.BackColor = System.Drawing.Color.DarkGray
            Me.textBox_TextColor.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox_TextColor.Location = New System.Drawing.Point(0, 0)
            Me.textBox_TextColor.Name = "textBox_TextColor"
            Me.textBox_TextColor.ReadOnly = True
            Me.textBox_TextColor.Size = New System.Drawing.Size(26, 20)
            Me.textBox_TextColor.TabIndex = 11
            '
            'colorPickerButton1
            '
            Me.colorPickerButton1.BackColor = System.Drawing.Color.DarkGray
            Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton1.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton1.Image = CType(resources.GetObject("colorPickerButton1.Image"), System.Drawing.Image)
            Me.colorPickerButton1.Location = New System.Drawing.Point(26, 0)
            Me.colorPickerButton1.Name = "colorPickerButton1"
            Me.colorPickerButton1.SelectedAsBackcolor = True
            Me.colorPickerButton1.SelectedColor = System.Drawing.Color.DarkGray
            Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton1.Size = New System.Drawing.Size(17, 19)
            Me.colorPickerButton1.TabIndex = 14
            Me.colorPickerButton1.Text = "..."
            Me.colorPickerButton1.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label1.Location = New System.Drawing.Point(288, 526)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(56, 13)
            Me.label1.TabIndex = 78
            Me.label1.Text = "BackColor"
            '
            'panel1
            '
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.textBox1)
            Me.panel1.Controls.Add(Me.colorPickerButton2)
            Me.panel1.Location = New System.Drawing.Point(382, 552)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(45, 21)
            Me.panel1.TabIndex = 79
            '
            'textBox1
            '
            Me.textBox1.BackColor = System.Drawing.Color.Gray
            Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox1.Location = New System.Drawing.Point(0, 0)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.ReadOnly = True
            Me.textBox1.Size = New System.Drawing.Size(26, 20)
            Me.textBox1.TabIndex = 11
            '
            'colorPickerButton2
            '
            Me.colorPickerButton2.BackColor = System.Drawing.Color.Gray
            Me.colorPickerButton2.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton2.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton2.Image = CType(resources.GetObject("colorPickerButton2.Image"), System.Drawing.Image)
            Me.colorPickerButton2.Location = New System.Drawing.Point(26, 0)
            Me.colorPickerButton2.Name = "colorPickerButton2"
            Me.colorPickerButton2.SelectedAsBackcolor = True
            Me.colorPickerButton2.SelectedColor = System.Drawing.Color.Gray
            Me.colorPickerButton2.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton2.Size = New System.Drawing.Size(17, 19)
            Me.colorPickerButton2.TabIndex = 14
            Me.colorPickerButton2.Text = "..."
            Me.colorPickerButton2.UseVisualStyleBackColor = False
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label4.Location = New System.Drawing.Point(288, 552)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(86, 13)
            Me.label4.TabIndex = 80
            Me.label4.Text = "Button ForeColor"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label5.Location = New System.Drawing.Point(288, 578)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(90, 13)
            Me.label5.TabIndex = 82
            Me.label5.Text = "Button BackColor"
            '
            'panel2
            '
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.Add(Me.textBox2)
            Me.panel2.Controls.Add(Me.colorPickerButton3)
            Me.panel2.Location = New System.Drawing.Point(382, 578)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(45, 21)
            Me.panel2.TabIndex = 81
            '
            'textBox2
            '
            Me.textBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.textBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox2.Location = New System.Drawing.Point(0, 0)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.ReadOnly = True
            Me.textBox2.Size = New System.Drawing.Size(26, 20)
            Me.textBox2.TabIndex = 11
            '
            'colorPickerButton3
            '
            Me.colorPickerButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.colorPickerButton3.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton3.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton3.Image = CType(resources.GetObject("colorPickerButton3.Image"), System.Drawing.Image)
            Me.colorPickerButton3.Location = New System.Drawing.Point(26, 0)
            Me.colorPickerButton3.Name = "colorPickerButton3"
            Me.colorPickerButton3.SelectedAsBackcolor = True
            Me.colorPickerButton3.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.colorPickerButton3.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton3.Size = New System.Drawing.Size(17, 19)
            Me.colorPickerButton3.TabIndex = 14
            Me.colorPickerButton3.Text = "..."
            Me.colorPickerButton3.UseVisualStyleBackColor = False
            '
            'button1
            '
            Me.button1.Location = New System.Drawing.Point(41, 623)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(96, 23)
            Me.button1.TabIndex = 83
            Me.button1.Text = "Add New Item"
            Me.button1.UseVisualStyleBackColor = True
            '
            'checkBox4
            '
            Me.checkBox4.AutoSize = True
            Me.checkBox4.Checked = True
            Me.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox4.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox4.Location = New System.Drawing.Point(44, 475)
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(99, 18)
            Me.checkBox4.TabIndex = 84
            Me.checkBox4.Text = "Show ToolBar"
            '
            'ComboBox1
            '
            Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.ComboBox1.Items.AddRange(New Object() {"All", "Dockable", "Movable", "None"})
            Me.ComboBox1.Location = New System.Drawing.Point(98, 572)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(83, 21)
            Me.ComboBox1.TabIndex = 85
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.Label2.Location = New System.Drawing.Point(44, 574)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(49, 13)
            Me.Label2.TabIndex = 86
            Me.Label2.Text = "Behavior"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(497, 654)
            Me.Controls.Add(Me.ComboBox1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.checkBox4)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.panel9)
            Me.Controls.Add(Me.checkBox2)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.label10)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.checkBox1)
            Me.Controls.Add(Me.label12)
            Me.Controls.Add(Me.label11)
            Me.Controls.Add(Me.numericUpDown2)
            Me.Controls.Add(Me.comboBox3)
            Me.Controls.Add(Me.checkBox3)
            Me.Controls.Add(Me.label8)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.numericUpDown1)
            Me.Controls.Add(Me.numericUpDown3)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart ToolBar "
            CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel9.ResumeLayout(False)
            Me.panel9.PerformLayout()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region

#Region "Form Load"
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitializeChartData()
            Me.comboBox3.SelectedIndex = 2
            Me.ComboBox1.SelectedIndex = 0
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region "Helper Methods"
#Region "InitializeChartData"
        ''' <summary>
        ''' Initializes the chartControl1's data and sets the Chart type
        ''' </summary>
        Protected Sub InitializeChartData()
            Dim series1 As ChartSeries = New ChartSeries()
            series1.Name = "saab"
            series1.Type = ChartSeriesType.Column
            series1.Text = series1.Name

            series1.Points.Add(2001, 256)
            series1.Points.Add(2002, 491)
            series1.Points.Add(2003, 382)
            series1.Points.Add(2004, 437)
            series1.Points.Add(2005, 321)

            Dim series2 As ChartSeries = New ChartSeries()
            series2.Name = "Volvo"
            series2.Type = ChartSeriesType.Column
            series2.Text = series2.Name

            series2.Points.Add(2001, 437)
            series2.Points.Add(2002, 451)
            series2.Points.Add(2003, 490)
            series2.Points.Add(2004, 366)
            series2.Points.Add(2005, 422)

            Me.chartControl1.Series.Add(series1)
            Me.chartControl1.Series.Add(series2)

            Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.Transparent
            Me.chartControl1.Text = "Sales Volume Comparison"
            Me.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows
          
        End Sub
#End Region

#End Region

#Region "Events"
        Private Sub checkbox1_changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            Me.chartControl1.ToolBar.ShowBorder = Me.checkBox1.Checked
        End Sub
        Private Sub comboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox3.SelectedIndexChanged
            Me.chartControl1.ToolBar.Position = CType(System.Enum.Parse(GetType(ChartDock), Me.comboBox3.SelectedItem.ToString(), True), ChartDock)
        End Sub

        Private Sub colorPickerButton3_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton3.ColorSelected
            Me.chartControl1.ToolBar.ButtonBackColor = Me.colorPickerButton3.SelectedColor
            Me.textBox2.BackColor = Me.colorPickerButton3.SelectedColor
        End Sub

        Private Sub colorPickerButton2_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton2.ColorSelected
            Me.chartControl1.ToolBar.ButtonForeColor = Me.colorPickerButton2.SelectedColor
            Me.textBox1.BackColor = Me.colorPickerButton2.SelectedColor
        End Sub

        Private Sub colorPickerButton1_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton1.ColorSelected
            Me.chartControl1.ToolBar.BackColor = Me.colorPickerButton1.SelectedColor
            Me.textBox_TextColor.BackColor = Me.colorPickerButton1.SelectedColor
        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckedChanged
            Me.chartControl1.ToolBar.ShowDialog = Me.checkBox3.Checked

        End Sub

        Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown1.ValueChanged
            Me.chartControl1.ToolBar.Header = CInt(Fix(Me.numericUpDown1.Value))
        End Sub

        Private Sub numericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown2.ValueChanged
            Me.chartControl1.ToolBar.Spacing = CInt(Fix(Me.numericUpDown2.Value))
        End Sub

        Private Sub numericUpDown3_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown3.ValueChanged
            Me.chartControl1.ToolBar.Border.Width = CSng(Me.numericUpDown3.Value)
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            Me.chartControl1.ToolBar.ShowGrip = Me.checkBox2.Checked
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            Dim rotateItem As ChartToolBarItem = New ChartToolBarItem()
            rotateItem.Name = "Rotation"
            rotateItem.Image = Image.FromFile("..\..\Rotation.png")
            Me.chartControl1.ToolBar.Items.Add(rotateItem)
            AddHandler chartControl1.ToolBar.ItemClick, AddressOf ToolBar_ItemClick
            Me.chartControl1.Size = New Size(475, 435)
            Me.button1.Enabled = False
        End Sub

        Private Sub ToolBar_ItemClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim tt As ChartToolBarItem = TryCast(sender, ChartToolBarItem)
            If tt.Name = "Rotation" Then
                Me.chartControl1.Series3D = True
                If CSng(Me.chartControl1.Rotation) = 90 Then
                    Me.chartControl1.Rotation = 30
                Else
                    Me.chartControl1.Rotation = Me.chartControl1.Rotation + 5
                End If
            End If
        End Sub

        Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox4.CheckedChanged
            Me.chartControl1.ShowToolbar = Me.checkBox4.Checked
        End Sub
#End Region

        Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
            Me.chartControl1.ToolBar.Behavior = CType(System.Enum.Parse(GetType(ChartDockingFlags), Me.ComboBox1.SelectedItem.ToString(), True), ChartDockingFlags)
        End Sub
    End Class
End Namespace
