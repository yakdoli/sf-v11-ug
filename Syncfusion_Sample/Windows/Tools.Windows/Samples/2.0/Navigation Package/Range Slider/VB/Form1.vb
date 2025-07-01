#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
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
Imports System.Diagnostics


Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports System.Data.OleDb
Imports Syncfusion.Windows.Forms.Grid

Namespace TaskBar
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Office2007Form
		#Region "Private Members"
        Private tabControlAdv2 As TabControlAdv
        Private tabPageAdv4 As TabPageAdv
        Private tabPageAdv5 As TabPageAdv
        Private numericUpDown1 As NumericUpDown
        Private label2 As Label
        Private numericUpDown3 As NumericUpDown
        Private label7 As Label
        Private checkBox1 As CheckBox
        Private label1 As Label
        Private numericUpDown4 As NumericUpDown
        Private label3 As Label
        Private numericUpDown5 As NumericUpDown
        Private groupBox1 As GroupBox
        Private label5 As Label
        Private label4 As Label
        Private rangeSlider1 As RangeSlider
        Private panel1 As Panel
        Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
        Private path As String = "../../../Data/sample.mdb"
        Private groupBox2 As GroupBox
        Private label6 As Label
        Private label8 As Label
        Private HighLighterColor As ButtonEdit
        Private buttonEditChildButton1 As ButtonEditChildButton
        Private label9 As Label
        Private buttonEdit3 As ButtonEdit
        Private buttonEditChildButton4 As ButtonEditChildButton
        Private label12 As Label
        Private buttonEdit2 As ButtonEdit
        Private buttonEditChildButton3 As ButtonEditChildButton
        Private label11 As Label
        Private buttonEdit1 As ButtonEdit
        Private buttonEditChildButton2 As ButtonEditChildButton
        Private label10 As Label
        Private buttonEdit4 As ButtonEdit
        Private buttonEditChildButton5 As ButtonEditChildButton
        Private label13 As Label
        Private colorDialog1 As ColorDialog
		Private components As System.ComponentModel.IContainer
#End Region

		#Region "Form's constructor, Main and Dispose"
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
		<STAThread> _
		Shared Sub Main()
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim gridBaseStyle1 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim gridBaseStyle2 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim gridBaseStyle3 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
            Dim gridBaseStyle4 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()

            Me.label5 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
            Me.rangeSlider1 = New Syncfusion.Windows.Forms.Tools.RangeSlider()
            Me.tabControlAdv2 = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
            Me.tabPageAdv4 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.numericUpDown4 = New System.Windows.Forms.NumericUpDown()
            Me.label7 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.numericUpDown3 = New System.Windows.Forms.NumericUpDown()
            Me.numericUpDown5 = New System.Windows.Forms.NumericUpDown()
            Me.groupBox2 = New System.Windows.Forms.GroupBox()
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
            Me.label2 = New System.Windows.Forms.Label()
            Me.tabPageAdv5 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
            Me.buttonEdit4 = New Syncfusion.Windows.Forms.Tools.ButtonEdit()
            Me.buttonEditChildButton5 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
            Me.label13 = New System.Windows.Forms.Label()
            Me.buttonEdit3 = New Syncfusion.Windows.Forms.Tools.ButtonEdit()
            Me.buttonEditChildButton4 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
            Me.label12 = New System.Windows.Forms.Label()
            Me.buttonEdit2 = New Syncfusion.Windows.Forms.Tools.ButtonEdit()
            Me.buttonEditChildButton3 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
            Me.label11 = New System.Windows.Forms.Label()
            Me.buttonEdit1 = New Syncfusion.Windows.Forms.Tools.ButtonEdit()
            Me.buttonEditChildButton2 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
            Me.label10 = New System.Windows.Forms.Label()
            Me.HighLighterColor = New Syncfusion.Windows.Forms.Tools.ButtonEdit()
            Me.buttonEditChildButton1 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
            Me.label9 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.label8 = New System.Windows.Forms.Label()
            Me.panel1.SuspendLayout()
            DirectCast((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast((Me.tabControlAdv2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControlAdv2.SuspendLayout()
            Me.tabPageAdv4.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            DirectCast((Me.numericUpDown4), System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast((Me.numericUpDown3), System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast((Me.numericUpDown5), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox2.SuspendLayout()
            DirectCast((Me.numericUpDown1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPageAdv5.SuspendLayout()
            DirectCast((Me.buttonEdit4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit4.SuspendLayout()
            DirectCast((Me.buttonEdit3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit3.SuspendLayout()
            DirectCast((Me.buttonEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit2.SuspendLayout()
            DirectCast((Me.buttonEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit1.SuspendLayout()
            DirectCast((Me.HighLighterColor), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.HighLighterColor.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' label5
            ' 
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(403, 49)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(25, 13)
            Me.label5.TabIndex = 14
            Me.label5.Text = "200"
            ' 
            ' label4
            ' 
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(152, 49)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(13, 13)
            Me.label4.TabIndex = 13
            Me.label4.Text = "0"
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.gridControl1)
            Me.panel1.Location = New System.Drawing.Point(1, 91)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(437, 216)
            Me.panel1.TabIndex = 15
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None
            gridBaseStyle1.Name = "Row Header"
            gridBaseStyle1.StyleInfo.BaseStyle = "Header"
            gridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
            gridBaseStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CInt(CByte((203))), CInt(CByte((199))), CInt(CByte((184)))), System.Drawing.Color.FromArgb(CInt(CByte((238))), CInt(CByte((234))), CInt(CByte((216)))))
            gridBaseStyle2.Name = "Column Header"
            gridBaseStyle2.StyleInfo.BaseStyle = "Header"
            gridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            gridBaseStyle3.Name = "Standard"
            gridBaseStyle3.StyleInfo.Font.Facename = "Tahoma"
            gridBaseStyle3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            gridBaseStyle4.Name = "Header"
            gridBaseStyle4.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            gridBaseStyle4.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            gridBaseStyle4.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            gridBaseStyle4.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            gridBaseStyle4.StyleInfo.CellType = "Header"
            gridBaseStyle4.StyleInfo.Font.Bold = True
            gridBaseStyle4.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CInt(CByte((203))), CInt(CByte((199))), CInt(CByte((184)))), System.Drawing.Color.FromArgb(CInt(CByte((238))), CInt(CByte((234))), CInt(CByte((216)))))
            gridBaseStyle4.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            Me.gridControl1.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {gridBaseStyle1, gridBaseStyle2, gridBaseStyle3, gridBaseStyle4})
            Me.gridControl1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)})
            Me.gridControl1.DefaultColWidth = 66
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.ResizeColsBehavior = DirectCast(((((Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.ResizeAll Or Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.ResizeSingle) Or Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.OutlineHeaders) Or Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.OutlineBounds)), Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior)
            Me.gridControl1.ResizeRowsBehavior = DirectCast(((((Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.ResizeAll Or Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.ResizeSingle) Or Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.OutlineHeaders) Or Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.OutlineBounds)), Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior)
            Me.gridControl1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
            Me.gridControl1.ScrollFrozen = False
            Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridControl1.Size = New System.Drawing.Size(437, 216)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.TabIndex = 1
            Me.gridControl1.Text = "gridControl1"
            Me.gridControl1.UseRightToLeftCompatibleTextBox = True
            Me.gridControl1.VerticalThumbTrack = True
            ' 
            ' rangeSlider1
            ' 
            Me.rangeSlider1.ChannelHeight = 6
            Me.rangeSlider1.Location = New System.Drawing.Point(133, 24)
            Me.rangeSlider1.Maximum = 200
            Me.rangeSlider1.Name = "rangeSlider1"
            Me.rangeSlider1.Size = New System.Drawing.Size(308, 22)
            Me.rangeSlider1.SliderMax = 200
            Me.rangeSlider1.SliderSize = New System.Drawing.Size(15, 18)
            Me.rangeSlider1.TabIndex = 12
            Me.rangeSlider1.Text = "rangeSlider1"
            Me.rangeSlider1.TickFrequency = 10
            ' 
            ' tabControlAdv2
            ' 
            Me.tabControlAdv2.ActiveTabColor = System.Drawing.Color.FromArgb(CInt(CByte((227))), CInt(CByte((237))), CInt(CByte((248))))
            Me.tabControlAdv2.ActiveTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
            Me.tabControlAdv2.BackColor = System.Drawing.Color.FromArgb(CInt(CByte((228))), CInt(CByte((237))), CInt(CByte((248))))
            Me.tabControlAdv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tabControlAdv2.Controls.Add(Me.tabPageAdv4)
            Me.tabControlAdv2.Controls.Add(Me.tabPageAdv5)
            Me.tabControlAdv2.Dock = System.Windows.Forms.DockStyle.Right
            Me.tabControlAdv2.FixedSingleBorderColor = System.Drawing.Color.FromArgb(CInt(CByte((141))), CInt(CByte((178))), CInt(CByte((227))))
            Me.tabControlAdv2.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte((161)))
            Me.tabControlAdv2.Location = New System.Drawing.Point(444, 0)
            Me.tabControlAdv2.Name = "tabControlAdv2"
            Me.tabControlAdv2.Size = New System.Drawing.Size(244, 307)
            Me.tabControlAdv2.TabGap = 10
            Me.tabControlAdv2.TabIndex = 3
            Me.tabControlAdv2.TabPanelBackColor = System.Drawing.Color.FromArgb(CInt(CByte((182))), CInt(CByte((214))), CInt(CByte((246))))
            Me.tabControlAdv2.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)
            Me.tabControlAdv2.ThemesEnabled = True
            ' 
            ' tabPageAdv4
            ' 
            Me.tabPageAdv4.BackColor = System.Drawing.Color.FromArgb(CInt(CByte((227))), CInt(CByte((237))), CInt(CByte((248))))
            Me.tabPageAdv4.Controls.Add(Me.groupBox1)
            Me.tabPageAdv4.Controls.Add(Me.groupBox2)

            Me.tabPageAdv4.Location = New System.Drawing.Point(3, 24)
            Me.tabPageAdv4.Name = "tabPageAdv4"
            Me.tabPageAdv4.Size = New System.Drawing.Size(238, 280)
            Me.tabPageAdv4.TabIndex = 1
            Me.tabPageAdv4.Text = "Settings"
            Me.tabPageAdv4.ThemesEnabled = False
            ' 
            ' groupBox1
            ' 
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Controls.Add(Me.numericUpDown4)
            Me.groupBox1.Controls.Add(Me.label7)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.numericUpDown3)
            Me.groupBox1.Controls.Add(Me.numericUpDown5)
            Me.groupBox1.Location = New System.Drawing.Point(9, 12)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(226, 132)
            Me.groupBox1.TabIndex = 21
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Slider Size"
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(24, 19)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(64, 13)
            Me.label1.TabIndex = 13
            Me.label1.Text = "Slider Width"
            ' 
            ' numericUpDown4
            ' 
            Me.numericUpDown4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numericUpDown4.Location = New System.Drawing.Point(15, 38)
            Me.numericUpDown4.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
            Me.numericUpDown4.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.numericUpDown4.Name = "numericUpDown4"
            Me.numericUpDown4.Size = New System.Drawing.Size(95, 21)
            Me.numericUpDown4.TabIndex = 14
            Me.numericUpDown4.Value = New Decimal(New Integer() {10, 0, 0, 0})
            AddHandler Me.numericUpDown4.ValueChanged, AddressOf Me.numericUpDown4_ValueChanged
            ' 
            ' label7
            ' 
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(24, 79)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(80, 13)
            Me.label7.TabIndex = 15
            Me.label7.Text = "Channel Height"
            ' 
            ' label3
            ' 
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(128, 19)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(67, 13)
            Me.label3.TabIndex = 15
            Me.label3.Text = "Slider Height"
            ' 
            ' numericUpDown3
            ' 
            Me.numericUpDown3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numericUpDown3.Location = New System.Drawing.Point(15, 98)
            Me.numericUpDown3.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.numericUpDown3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown3.Name = "numericUpDown3"
            Me.numericUpDown3.Size = New System.Drawing.Size(95, 21)
            Me.numericUpDown3.TabIndex = 16
            Me.numericUpDown3.Value = New Decimal(New Integer() {6, 0, 0, 0})
            AddHandler Me.numericUpDown3.ValueChanged, AddressOf Me.numericUpDown3_ValueChanged
            ' 
            ' numericUpDown5
            ' 
            Me.numericUpDown5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numericUpDown5.Location = New System.Drawing.Point(119, 38)
            Me.numericUpDown5.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
            Me.numericUpDown5.Minimum = New Decimal(New Integer() {15, 0, 0, 0})
            Me.numericUpDown5.Name = "numericUpDown5"
            Me.numericUpDown5.Size = New System.Drawing.Size(95, 21)
            Me.numericUpDown5.TabIndex = 16
            Me.numericUpDown5.Value = New Decimal(New Integer() {15, 0, 0, 0})
            AddHandler Me.numericUpDown5.ValueChanged, AddressOf Me.numericUpDown5_ValueChanged
            ' 
            ' groupBox2
            ' 
            Me.groupBox2.Controls.Add(Me.checkBox1)
            Me.groupBox2.Controls.Add(Me.numericUpDown1)
            Me.groupBox2.Controls.Add(Me.label2)
            Me.groupBox2.Location = New System.Drawing.Point(24, 160)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(211, 82)
            Me.groupBox2.TabIndex = 17
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Slider Ticks"
            ' 
            ' checkBox1
            ' 
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.Location = New System.Drawing.Point(127, 50)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(78, 17)
            Me.checkBox1.TabIndex = 12
            Me.checkBox1.Text = "Show Ticks"
            Me.checkBox1.UseVisualStyleBackColor = True
            AddHandler Me.checkBox1.CheckStateChanged, AddressOf Me.checkBox1_CheckStateChanged
            ' 
            ' numericUpDown1
            ' 
            Me.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numericUpDown1.Location = New System.Drawing.Point(6, 46)
            Me.numericUpDown1.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
            Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.Size = New System.Drawing.Size(95, 21)
            Me.numericUpDown1.TabIndex = 4
            Me.numericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
            AddHandler Me.numericUpDown1.ValueChanged, AddressOf Me.numericUpDown1_ValueChanged
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(6, 27)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(79, 13)
            Me.label2.TabIndex = 3
            Me.label2.Text = "Tick Frequency"
            ' 
            ' tabPageAdv5
            ' 
            Me.tabPageAdv5.BackColor = System.Drawing.Color.FromArgb(CInt(CByte((227))), CInt(CByte((237))), CInt(CByte((248))))
            Me.tabPageAdv5.Controls.Add(Me.buttonEdit4)
            Me.tabPageAdv5.Controls.Add(Me.label13)
            Me.tabPageAdv5.Controls.Add(Me.buttonEdit3)
            Me.tabPageAdv5.Controls.Add(Me.label12)
            Me.tabPageAdv5.Controls.Add(Me.buttonEdit2)
            Me.tabPageAdv5.Controls.Add(Me.label11)
            Me.tabPageAdv5.Controls.Add(Me.buttonEdit1)
            Me.tabPageAdv5.Controls.Add(Me.label10)
            Me.tabPageAdv5.Controls.Add(Me.HighLighterColor)
            Me.tabPageAdv5.Controls.Add(Me.label9)

            Me.tabPageAdv5.Location = New System.Drawing.Point(3, 24)
            Me.tabPageAdv5.Name = "tabPageAdv5"
            Me.tabPageAdv5.Size = New System.Drawing.Size(238, 280)
            Me.tabPageAdv5.TabIndex = 2
            Me.tabPageAdv5.Text = "Color"
            Me.tabPageAdv5.ThemesEnabled = False
            ' 
            ' buttonEdit4
            ' 
            Me.buttonEdit4.Buttons.Add(Me.buttonEditChildButton5)
            Me.buttonEdit4.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonEdit4.Controls.Add(Me.buttonEditChildButton5)
            Me.buttonEdit4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.buttonEdit4.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte((0)))
            Me.buttonEdit4.Location = New System.Drawing.Point(127, 66)
            Me.buttonEdit4.Name = "buttonEdit4"
            Me.buttonEdit4.ShowTextBox = False
            Me.buttonEdit4.Size = New System.Drawing.Size(102, 26)
            Me.buttonEdit4.TabIndex = 49
            ' 
            ' buttonEditChildButton5
            ' 
            Me.buttonEditChildButton5.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton5.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton5.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.buttonEditChildButton5.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte((0)))
            Me.buttonEditChildButton5.Image = Nothing
            Me.buttonEditChildButton5.Name = "buttonEditChildButton5"
            Me.buttonEditChildButton5.PreferredWidth = 20
            Me.buttonEditChildButton5.TabIndex = 1
            Me.buttonEditChildButton5.Text = "..."
            Me.buttonEditChildButton5.UseVisualStyleBackColor = True
            AddHandler Me.buttonEditChildButton5.Click, AddressOf Me.buttonEdit4_Click
            ' 
            ' label13
            ' 
            Me.label13.AutoSize = True
            Me.label13.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte((0)))
            Me.label13.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label13.Location = New System.Drawing.Point(17, 76)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(67, 14)
            Me.label13.TabIndex = 48
            Me.label13.Text = "Thumb Color"
            ' 
            ' buttonEdit3
            ' 
            Me.buttonEdit3.Buttons.Add(Me.buttonEditChildButton4)
            Me.buttonEdit3.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonEdit3.Controls.Add(Me.buttonEditChildButton4)
            Me.buttonEdit3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.buttonEdit3.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte((0)))
            Me.buttonEdit3.Location = New System.Drawing.Point(129, 166)
            Me.buttonEdit3.Name = "buttonEdit3"
            Me.buttonEdit3.ShowTextBox = False
            Me.buttonEdit3.Size = New System.Drawing.Size(102, 26)
            Me.buttonEdit3.TabIndex = 47
            AddHandler Me.buttonEdit3.Click, AddressOf Me.buttonEdit3_Click
            ' 
            ' buttonEditChildButton4
            ' 
            Me.buttonEditChildButton4.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton4.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.buttonEditChildButton4.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte((0)))
            Me.buttonEditChildButton4.Image = Nothing
            Me.buttonEditChildButton4.Name = "buttonEditChildButton4"
            Me.buttonEditChildButton4.PreferredWidth = 20
            Me.buttonEditChildButton4.TabIndex = 1
            Me.buttonEditChildButton4.Text = "..."
            Me.buttonEditChildButton4.UseVisualStyleBackColor = True
            AddHandler Me.buttonEditChildButton4.Click, AddressOf Me.buttonEdit3_Click
            ' 
            ' label12
            ' 
            Me.label12.AutoSize = True
            Me.label12.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte((0)))
            Me.label12.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label12.Location = New System.Drawing.Point(17, 178)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(74, 14)
            Me.label12.TabIndex = 46
            Me.label12.Text = "Channel Color"
            ' 
            ' buttonEdit2
            ' 
            Me.buttonEdit2.Buttons.Add(Me.buttonEditChildButton3)
            Me.buttonEdit2.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonEdit2.Controls.Add(Me.buttonEditChildButton3)
            Me.buttonEdit2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.buttonEdit2.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte((0)))
            Me.buttonEdit2.Location = New System.Drawing.Point(129, 134)
            Me.buttonEdit2.Name = "buttonEdit2"
            Me.buttonEdit2.ShowTextBox = False
            Me.buttonEdit2.Size = New System.Drawing.Size(102, 26)
            Me.buttonEdit2.TabIndex = 45
            AddHandler Me.buttonEdit2.Click, AddressOf Me.buttonEdit2_Click
            ' 
            ' buttonEditChildButton3
            ' 
            Me.buttonEditChildButton3.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton3.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.buttonEditChildButton3.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte((0)))
            Me.buttonEditChildButton3.Image = Nothing
            Me.buttonEditChildButton3.Name = "buttonEditChildButton3"
            Me.buttonEditChildButton3.PreferredWidth = 20
            Me.buttonEditChildButton3.TabIndex = 1
            Me.buttonEditChildButton3.Text = "..."
            Me.buttonEditChildButton3.UseVisualStyleBackColor = True
            AddHandler Me.buttonEditChildButton3.Click, AddressOf Me.buttonEdit2_Click
            ' 
            ' label11
            ' 
            Me.label11.AutoSize = True
            Me.label11.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte((0)))
            Me.label11.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label11.Location = New System.Drawing.Point(3, 146)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(122, 14)
            Me.label11.TabIndex = 44
            Me.label11.Text = "Highlighted Thumb Color"
            ' 
            ' buttonEdit1
            ' 
            Me.buttonEdit1.Buttons.Add(Me.buttonEditChildButton2)
            Me.buttonEdit1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonEdit1.Controls.Add(Me.buttonEditChildButton2)
            Me.buttonEdit1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.buttonEdit1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte((0)))
            Me.buttonEdit1.Location = New System.Drawing.Point(128, 99)
            Me.buttonEdit1.Name = "buttonEdit1"
            Me.buttonEdit1.ShowTextBox = False
            Me.buttonEdit1.Size = New System.Drawing.Size(102, 26)
            Me.buttonEdit1.TabIndex = 43
            ' 
            ' buttonEditChildButton2
            ' 
            Me.buttonEditChildButton2.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton2.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.buttonEditChildButton2.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte((0)))
            Me.buttonEditChildButton2.Image = Nothing
            Me.buttonEditChildButton2.Name = "buttonEditChildButton2"
            Me.buttonEditChildButton2.PreferredWidth = 20
            Me.buttonEditChildButton2.TabIndex = 1
            Me.buttonEditChildButton2.Text = "..."
            Me.buttonEditChildButton2.UseVisualStyleBackColor = True
            AddHandler Me.buttonEditChildButton2.Click, AddressOf Me.buttonEdit1_Click
            ' 
            ' label10
            ' 
            Me.label10.AutoSize = True
            Me.label10.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte((0)))
            Me.label10.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label10.Location = New System.Drawing.Point(3, 109)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(106, 14)
            Me.label10.TabIndex = 42
            Me.label10.Text = "Pushed Thumb Color"
            ' 
            ' HighLighterColor
            ' 
            Me.HighLighterColor.Buttons.Add(Me.buttonEditChildButton1)
            Me.HighLighterColor.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.HighLighterColor.Controls.Add(Me.buttonEditChildButton1)
            Me.HighLighterColor.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.HighLighterColor.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte((0)))
            Me.HighLighterColor.Location = New System.Drawing.Point(127, 34)
            Me.HighLighterColor.Name = "HighLighterColor"
            Me.HighLighterColor.ShowTextBox = False
            Me.HighLighterColor.Size = New System.Drawing.Size(102, 26)
            Me.HighLighterColor.TabIndex = 41
            ' 
            ' buttonEditChildButton1
            ' 
            Me.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.buttonEditChildButton1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte((0)))
            Me.buttonEditChildButton1.Image = Nothing
            Me.buttonEditChildButton1.Name = "buttonEditChildButton1"
            Me.buttonEditChildButton1.PreferredWidth = 20
            Me.buttonEditChildButton1.TabIndex = 1
            Me.buttonEditChildButton1.Text = "..."
            Me.buttonEditChildButton1.UseVisualStyleBackColor = True
            AddHandler Me.buttonEditChildButton1.Click, AddressOf Me.HighLighterColor_Click
            ' 
            ' label9
            ' 
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte((0)))
            Me.label9.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label9.Location = New System.Drawing.Point(17, 44)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(66, 14)
            Me.label9.TabIndex = 40
            Me.label9.Text = "Range Color"
            ' 
            ' label6
            ' 
            Me.label6.AutoSize = True
            Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte((0)))
            Me.label6.Location = New System.Drawing.Point(-2, 33)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(148, 13)
            Me.label6.TabIndex = 16
            Me.label6.Text = "Select Stock Close Price"
            ' 
            ' label8
            ' 
            Me.label8.AutoSize = True
            Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte((0)))
            Me.label8.Location = New System.Drawing.Point(178, 74)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(82, 13)
            Me.label8.TabIndex = 17
            Me.label8.Text = "Stock Report"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Custom TaskBar"
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CInt(CByte((182))), CInt(CByte((214))), CInt(CByte((246))))
            Me.ClientSize = New System.Drawing.Size(688, 307)
            Me.Controls.Add(Me.label8)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.rangeSlider1)
            Me.Controls.Add(Me.tabControlAdv2)
            Me.Icon = DirectCast((resources.GetObject("$this.Icon")), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Range Slider"
            AddHandler Me.Load, AddressOf Me.Form1_Load
            Me.panel1.ResumeLayout(False)
            DirectCast((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast((Me.tabControlAdv2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControlAdv2.ResumeLayout(False)
            Me.tabPageAdv4.ResumeLayout(False)
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            DirectCast((Me.numericUpDown4), System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast((Me.numericUpDown3), System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast((Me.numericUpDown5), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            DirectCast((Me.numericUpDown1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPageAdv5.ResumeLayout(False)
            Me.tabPageAdv5.PerformLayout()
            DirectCast((Me.buttonEdit4), System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit4.ResumeLayout(False)
            Me.buttonEdit4.PerformLayout()
            DirectCast((Me.buttonEdit3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit3.ResumeLayout(False)
            Me.buttonEdit3.PerformLayout()
            DirectCast((Me.buttonEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit2.ResumeLayout(False)
            Me.buttonEdit2.PerformLayout()
            DirectCast((Me.buttonEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit1.ResumeLayout(False)
            Me.buttonEdit1.PerformLayout()
            DirectCast((Me.HighLighterColor), System.ComponentModel.ISupportInitialize).EndInit()
            Me.HighLighterColor.ResumeLayout(False)
            Me.HighLighterColor.PerformLayout()
            Me.ResumeLayout(False)
			
		End Sub
		#End Region

		#Region "Events"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim conString As String = ("Provider=Microsoft.JET.OLEDB.4.0;" & "data source=") + path

            ' Create an open the connection
            Dim conn As New OleDbConnection(conString)
            conn.Open()

            ' Create the adapter and fill the DataSet
            Dim command As New OleDbCommand("select * from StockData where ClosePrice between @FromPrice and @ToPrice order by symbol", conn)

            command.Parameters.Add("@FromPrice", OleDbType.[Integer]).Value = rangeSlider1.SliderMin
            command.Parameters.Add("@ToPrice", OleDbType.[Integer]).Value = rangeSlider1.SliderMax

            Dim ds As New DataSet()
            Dim adapter As New OleDbDataAdapter(command)
            adapter.Fill(ds)

            ' Close the connection
            conn.Close()

            Dim table As DataTable = ds.Tables(0)

            gridControl1.RowCount = table.Rows.Count
            gridControl1.ColCount = table.Columns.Count

            gridControl1.PopulateValues(GridRangeInfo.Cells(1, 1, table.Rows.Count, table.Columns.Count), table)
            gridControl1.PopulateHeaders(GridRangeInfo.Cells(0, 1, table.Rows.Count, table.Columns.Count), table)

            AddHandler rangeSlider1.ValueChanged, AddressOf rangeSlider1_ValueChanged
        End Sub

        Private Sub rangeSlider1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            label4.Text = rangeSlider1.SliderMin.ToString()
            label5.Text = rangeSlider1.SliderMax.ToString()
            Dim conString As String = ("Provider=Microsoft.JET.OLEDB.4.0;" & "data source=") + path

            ' Create an open the connection
            Dim conn As New OleDbConnection(conString)
            conn.Open()

            ' Create the adapter and fill the DataSet
            Dim command As New OleDbCommand("select * from StockData where ClosePrice between @FromPrice and @ToPrice", conn)

            command.Parameters.Add("@FromPrice", OleDbType.[Integer]).Value = rangeSlider1.SliderMin
            command.Parameters.Add("@ToPrice", OleDbType.[Integer]).Value = rangeSlider1.SliderMax

            Dim ds As New DataSet()
            Dim adapter As New OleDbDataAdapter(command)
            adapter.Fill(ds)

            Dim table As DataTable = ds.Tables(0)
            gridControl1.Clear(True)
            gridControl1.RowCount = table.Rows.Count
            gridControl1.ColCount = table.Columns.Count

            gridControl1.PopulateValues(GridRangeInfo.Cells(1, 1, table.Rows.Count, table.Columns.Count), table)

            gridControl1.PopulateHeaders(GridRangeInfo.Cells(0, 1, table.Rows.Count, table.Columns.Count), table)
        End Sub

        Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            rangeSlider1.TickFrequency = CInt(numericUpDown1.Value)
        End Sub

        Private Sub checkBox1_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            rangeSlider1.ShowTicks = checkBox1.Checked
        End Sub

        Private Sub numericUpDown4_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            rangeSlider1.SliderSize = New Size(CInt(numericUpDown4.Value), rangeSlider1.SliderSize.Height)
        End Sub

        Private Sub numericUpDown3_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            rangeSlider1.ChannelHeight = CInt(numericUpDown3.Value)
        End Sub

        Private Sub numericUpDown5_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            rangeSlider1.SliderSize = New Size(rangeSlider1.SliderSize.Width, CInt(numericUpDown5.Value))
        End Sub

        Private Sub HighLighterColor_Click(ByVal sender As Object, ByVal e As EventArgs)
            colorDialog1.ShowDialog()
            Me.HighLighterColor.BackColor = colorDialog1.Color
            rangeSlider1.RangeColor = Me.HighLighterColor.BackColor
        End Sub

        Private Sub buttonEdit4_Click(ByVal sender As Object, ByVal e As EventArgs)
            colorDialog1.ShowDialog()
            Me.buttonEdit4.BackColor = colorDialog1.Color
            rangeSlider1.ThumbColor = Me.buttonEdit4.BackColor
        End Sub

        Private Sub buttonEdit1_Click(ByVal sender As Object, ByVal e As EventArgs)
            colorDialog1.ShowDialog()
            Me.buttonEdit1.BackColor = colorDialog1.Color
            rangeSlider1.PushedThumbColor = Me.buttonEdit1.BackColor
        End Sub

        Private Sub buttonEdit2_Click(ByVal sender As Object, ByVal e As EventArgs)
            colorDialog1.ShowDialog()
            Me.buttonEdit2.BackColor = colorDialog1.Color
            rangeSlider1.HighlightedThumbColor = Me.buttonEdit2.BackColor
        End Sub

        Private Sub buttonEdit3_Click(ByVal sender As Object, ByVal e As EventArgs)
            colorDialog1.ShowDialog()
            Me.buttonEdit3.BackColor = colorDialog1.Color
            rangeSlider1.ChannelColor = Me.buttonEdit3.BackColor
        End Sub
		#End Region

	End Class
End Namespace
