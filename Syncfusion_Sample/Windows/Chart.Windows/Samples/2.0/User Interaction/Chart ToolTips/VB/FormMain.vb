Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing

Namespace ChartAreaCustomization
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
    Public Class Form1 : Inherits Syncfusion.Windows.Forms.Office2007Form
        Private series1, series2 As ChartSeries
        Private panel1 As System.Windows.Forms.Panel
        Private WithEvents checkBox_chartArea As System.Windows.Forms.CheckBox

        Private label1 As System.Windows.Forms.Label
        Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private WithEvents ChartAreaTooltip As System.Windows.Forms.CheckBox
        Private WithEvents CBox_TooltipFormat As System.Windows.Forms.ComboBox
        Private WithEvents ShowTooltip As System.Windows.Forms.CheckBox
        Private WithEvents label9 As System.Windows.Forms.Label
        Private WithEvents Label2 As System.Windows.Forms.Label
        Private WithEvents Label3 As System.Windows.Forms.Label
        Private WithEvents label11 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents AutoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Friend WithEvents AutoLabel9 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Friend WithEvents AutoLabel10 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Friend WithEvents AutoLabel11 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private WithEvents comboBox3 As System.Windows.Forms.ComboBox
        Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
        Private WithEvents comboBox1 As System.Windows.Forms.ComboBox

         
        Private WithEvents autoLabel8 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private WithEvents autoLabel7 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private WithEvents autoLabel6 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private WithEvents autoLabel5 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private WithEvents FontColorPicker As Syncfusion.Windows.Forms.ColorPickerButton
        Private WithEvents autoLabel4 As Syncfusion.Windows.Forms.Tools.AutoLabel

        Private WithEvents BorderColorPicker As Syncfusion.Windows.Forms.ColorPickerButton
        Private WithEvents autoLabel3 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private WithEvents autoLabel2 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Friend WithEvents AutoLabel14 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Friend WithEvents AutoLabel13 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Friend WithEvents AutoLabel12 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Friend WithEvents comboBox6 As System.Windows.Forms.ComboBox
        Friend WithEvents comboBox5 As System.Windows.Forms.ComboBox
        Friend WithEvents comboBox4 As System.Windows.Forms.ComboBox
        Friend WithEvents FontColor As Syncfusion.Windows.Forms.ColorPickerButton
        Friend WithEvents BorderColor As Syncfusion.Windows.Forms.ColorPickerButton
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Ser2ChkBox As System.Windows.Forms.CheckBox
        Friend WithEvents Ser1ChkBox As System.Windows.Forms.CheckBox
        Friend WithEvents comSpacing As System.Windows.Forms.ComboBox
        Friend WithEvents comWidth As System.Windows.Forms.ComboBox

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            InitializeControlSettings()
             
             
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub

        Private Sub InitializeControlSettings()
            Me.chartControl1.Font = New System.Drawing.Font("Arial", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))

            ' Specify a ChartPalette:
            Dim color1 As Color() = New Color() {Color.FromArgb(204, 96, 134), Color.FromArgb(92, 134, 167), Color.FromArgb(185, 186, 66, 30)}
            Me.chartControl1.Palette = ChartColorPalette.Custom
            Me.chartControl1.Model.ColorModel.CustomColors = color1

            Me.chartControl1.Palette = ChartColorPalette.Custom
            Me.chartControl1.LegendPosition = ChartDock.Top

            Me.chartControl1.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Color.White)
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Color.White)

            Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.DarkGray
            Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = Color.DarkGray

            Me.chartControl1.PrimaryXAxis.LineType.ForeColor = Color.DarkGray
            Me.chartControl1.PrimaryYAxis.LineType.ForeColor = Color.DarkGray
            Me.chartControl1.Legend.BackColor = Color.White
            Me.chartControl1.Legend.Border.ForeColor = Color.DarkGray

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

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.panel1 = New System.Windows.Forms.Panel
            Me.TabControl1 = New System.Windows.Forms.TabControl
            Me.TabPage1 = New System.Windows.Forms.TabPage
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.CBox_TooltipFormat = New System.Windows.Forms.ComboBox
            Me.label1 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.label9 = New System.Windows.Forms.Label
            Me.ChartAreaTooltip = New System.Windows.Forms.CheckBox
            Me.label11 = New System.Windows.Forms.Label
            Me.ShowTooltip = New System.Windows.Forms.CheckBox
            Me.Label2 = New System.Windows.Forms.Label
            Me.checkBox_chartArea = New System.Windows.Forms.CheckBox
            Me.TabPage2 = New System.Windows.Forms.TabPage
            Me.GroupBox2 = New System.Windows.Forms.GroupBox
            Me.comSpacing = New System.Windows.Forms.ComboBox
            Me.comWidth = New System.Windows.Forms.ComboBox
            Me.Ser2ChkBox = New System.Windows.Forms.CheckBox
            Me.Ser1ChkBox = New System.Windows.Forms.CheckBox
            Me.comboBox6 = New System.Windows.Forms.ComboBox
            Me.AutoLabel12 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.comboBox5 = New System.Windows.Forms.ComboBox
            Me.comboBox4 = New System.Windows.Forms.ComboBox
            Me.AutoLabel14 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.AutoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.BorderColor = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.AutoLabel13 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.FontColor = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.AutoLabel9 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.AutoLabel11 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.AutoLabel10 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.comboBox3 = New System.Windows.Forms.ComboBox
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.autoLabel8 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.autoLabel7 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.autoLabel6 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.autoLabel5 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.FontColorPicker = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.autoLabel4 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.BorderColorPicker = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.autoLabel3 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.autoLabel2 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.panel1.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.panel1.Controls.Add(Me.TabControl1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(495, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(226, 418)
            Me.panel1.TabIndex = 1
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 0)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(226, 418)
            Me.TabControl1.TabIndex = 0
            '
            'TabPage1
            '
            Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabPage1.Controls.Add(Me.GroupBox1)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(218, 392)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "SeriesTooltips"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
            Me.GroupBox1.Controls.Add(Me.CBox_TooltipFormat)
            Me.GroupBox1.Controls.Add(Me.label1)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.label9)
            Me.GroupBox1.Controls.Add(Me.ChartAreaTooltip)
            Me.GroupBox1.Controls.Add(Me.label11)
            Me.GroupBox1.Controls.Add(Me.ShowTooltip)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.checkBox_chartArea)
            Me.GroupBox1.Location = New System.Drawing.Point(6, 5)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(206, 379)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            '
            'CBox_TooltipFormat
            '
            Me.CBox_TooltipFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CBox_TooltipFormat.ForeColor = System.Drawing.Color.MidnightBlue
            Me.CBox_TooltipFormat.Items.AddRange(New Object() {" Series Name", " SeriesStyle.ToolTip", " SeriesStyle[i].ToolTip", " Series.Points[ index ].X", " Series.Points[ index ].YValues[i]"})
            Me.CBox_TooltipFormat.Location = New System.Drawing.Point(31, 232)
            Me.CBox_TooltipFormat.Name = "CBox_TooltipFormat"
            Me.CBox_TooltipFormat.Size = New System.Drawing.Size(144, 21)
            Me.CBox_TooltipFormat.TabIndex = 3
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Location = New System.Drawing.Point(28, 202)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(143, 13)
            Me.label1.TabIndex = 4
            Me.label1.Text = "Select ToolTip Format Style:-"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.Label3.Location = New System.Drawing.Point(27, 117)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(155, 1)
            Me.Label3.TabIndex = 7
            Me.Label3.Text = "Chartarea Customization"
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.BackColor = System.Drawing.Color.Transparent
            Me.label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label9.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label9.Location = New System.Drawing.Point(21, 20)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(146, 14)
            Me.label9.TabIndex = 2
            Me.label9.Text = "ChartArea Customization"
            '
            'ChartAreaTooltip
            '
            Me.ChartAreaTooltip.ForeColor = System.Drawing.Color.MidnightBlue
            Me.ChartAreaTooltip.Location = New System.Drawing.Point(31, 171)
            Me.ChartAreaTooltip.Name = "ChartAreaTooltip"
            Me.ChartAreaTooltip.Size = New System.Drawing.Size(120, 16)
            Me.ChartAreaTooltip.TabIndex = 2
            Me.ChartAreaTooltip.Text = "ChartAreaToolTip"
            '
            'label11
            '
            Me.label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.label11.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label11.Location = New System.Drawing.Point(27, 40)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(155, 1)
            Me.label11.TabIndex = 6
            Me.label11.Text = "Chartarea Customization"
            '
            'ShowTooltip
            '
            Me.ShowTooltip.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.ShowTooltip.Checked = True
            Me.ShowTooltip.CheckState = System.Windows.Forms.CheckState.Checked
            Me.ShowTooltip.ForeColor = System.Drawing.Color.MidnightBlue
            Me.ShowTooltip.Location = New System.Drawing.Point(31, 140)
            Me.ShowTooltip.Name = "ShowTooltip"
            Me.ShowTooltip.Size = New System.Drawing.Size(112, 16)
            Me.ShowTooltip.TabIndex = 1
            Me.ShowTooltip.Text = "ShowToolTip"
            Me.ShowTooltip.UseVisualStyleBackColor = False
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.Label2.Location = New System.Drawing.Point(28, 98)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(48, 14)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "ToolTip"
            '
            'checkBox_chartArea
            '
            Me.checkBox_chartArea.AutoSize = True
            Me.checkBox_chartArea.ForeColor = System.Drawing.Color.MidnightBlue
            Me.checkBox_chartArea.Location = New System.Drawing.Point(43, 62)
            Me.checkBox_chartArea.Name = "checkBox_chartArea"
            Me.checkBox_chartArea.Size = New System.Drawing.Size(107, 17)
            Me.checkBox_chartArea.TabIndex = 0
            Me.checkBox_chartArea.Text = "DisplayChartArea"
            '
            'TabPage2
            '
            Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.TabPage2.Controls.Add(Me.GroupBox2)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(218, 392)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "FancyTooltips"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'GroupBox2
            '
            Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
            Me.GroupBox2.Controls.Add(Me.comSpacing)
            Me.GroupBox2.Controls.Add(Me.comWidth)
            Me.GroupBox2.Controls.Add(Me.Ser2ChkBox)
            Me.GroupBox2.Controls.Add(Me.Ser1ChkBox)
            Me.GroupBox2.Controls.Add(Me.comboBox6)
            Me.GroupBox2.Controls.Add(Me.AutoLabel12)
            Me.GroupBox2.Controls.Add(Me.comboBox5)
            Me.GroupBox2.Controls.Add(Me.comboBox4)
            Me.GroupBox2.Controls.Add(Me.AutoLabel14)
            Me.GroupBox2.Controls.Add(Me.AutoLabel1)
            Me.GroupBox2.Controls.Add(Me.BorderColor)
            Me.GroupBox2.Controls.Add(Me.AutoLabel13)
            Me.GroupBox2.Controls.Add(Me.FontColor)
            Me.GroupBox2.Controls.Add(Me.AutoLabel9)
            Me.GroupBox2.Controls.Add(Me.AutoLabel11)
            Me.GroupBox2.Controls.Add(Me.AutoLabel10)
            Me.GroupBox2.Location = New System.Drawing.Point(6, 3)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(205, 381)
            Me.GroupBox2.TabIndex = 8
            Me.GroupBox2.TabStop = False
            '
            'comSpacing
            '
            Me.comSpacing.FormattingEnabled = True
            Me.comSpacing.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
            Me.comSpacing.Location = New System.Drawing.Point(89, 158)
            Me.comSpacing.Name = "comSpacing"
            Me.comSpacing.Size = New System.Drawing.Size(110, 21)
            Me.comSpacing.TabIndex = 22
            '
            'comWidth
            '
            Me.comWidth.FormattingEnabled = True
            Me.comWidth.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
            Me.comWidth.Location = New System.Drawing.Point(89, 90)
            Me.comWidth.Name = "comWidth"
            Me.comWidth.Size = New System.Drawing.Size(110, 21)
            Me.comWidth.TabIndex = 21
            '
            'Ser2ChkBox
            '
            Me.Ser2ChkBox.AutoSize = True
            Me.Ser2ChkBox.Location = New System.Drawing.Point(126, 19)
            Me.Ser2ChkBox.Name = "Ser2ChkBox"
            Me.Ser2ChkBox.Size = New System.Drawing.Size(61, 17)
            Me.Ser2ChkBox.TabIndex = 20
            Me.Ser2ChkBox.Text = "Series2"
            Me.Ser2ChkBox.UseVisualStyleBackColor = True
            '
            'Ser1ChkBox
            '
            Me.Ser1ChkBox.AutoSize = True
            Me.Ser1ChkBox.Location = New System.Drawing.Point(28, 19)
            Me.Ser1ChkBox.Name = "Ser1ChkBox"
            Me.Ser1ChkBox.Size = New System.Drawing.Size(61, 17)
            Me.Ser1ChkBox.TabIndex = 19
            Me.Ser1ChkBox.Text = "Series1"
            Me.Ser1ChkBox.UseVisualStyleBackColor = True
            '
            'comboBox6
            '
            Me.comboBox6.FormattingEnabled = True
            Me.comboBox6.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
            Me.comboBox6.Location = New System.Drawing.Point(88, 273)
            Me.comboBox6.Name = "comboBox6"
            Me.comboBox6.Size = New System.Drawing.Size(110, 21)
            Me.comboBox6.TabIndex = 18
            '
            'AutoLabel12
            '
            Me.AutoLabel12.DX = 0
            Me.AutoLabel12.DY = 0
            Me.AutoLabel12.ForeColor = System.Drawing.Color.MidnightBlue
            Me.AutoLabel12.Location = New System.Drawing.Point(7, 273)
            Me.AutoLabel12.Name = "AutoLabel12"
            Me.AutoLabel12.Size = New System.Drawing.Size(51, 13)
            Me.AutoLabel12.TabIndex = 2
            Me.AutoLabel12.Text = "ToTarget"
            '
            'comboBox5
            '
            Me.comboBox5.FormattingEnabled = True
            Me.comboBox5.Location = New System.Drawing.Point(89, 231)
            Me.comboBox5.Name = "comboBox5"
            Me.comboBox5.Size = New System.Drawing.Size(110, 21)
            Me.comboBox5.TabIndex = 17
            '
            'comboBox4
            '
            Me.comboBox4.FormattingEnabled = True
            Me.comboBox4.Location = New System.Drawing.Point(89, 196)
            Me.comboBox4.Name = "comboBox4"
            Me.comboBox4.Size = New System.Drawing.Size(110, 21)
            Me.comboBox4.TabIndex = 16
            '
            'AutoLabel14
            '
            Me.AutoLabel14.DX = 0
            Me.AutoLabel14.DY = 0
            Me.AutoLabel14.ForeColor = System.Drawing.Color.MidnightBlue
            Me.AutoLabel14.Location = New System.Drawing.Point(6, 231)
            Me.AutoLabel14.Name = "AutoLabel14"
            Me.AutoLabel14.Size = New System.Drawing.Size(41, 13)
            Me.AutoLabel14.TabIndex = 11
            Me.AutoLabel14.Text = "Symbol"
            '
            'AutoLabel1
            '
            Me.AutoLabel1.DX = 0
            Me.AutoLabel1.DY = 0
            Me.AutoLabel1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.AutoLabel1.Location = New System.Drawing.Point(6, 62)
            Me.AutoLabel1.Name = "AutoLabel1"
            Me.AutoLabel1.Size = New System.Drawing.Size(62, 13)
            Me.AutoLabel1.TabIndex = 3
            Me.AutoLabel1.Text = "BorderColor"
            '
            'BorderColor
            '
            Me.BorderColor.ColorUISize = New System.Drawing.Size(208, 230)
            Me.BorderColor.Location = New System.Drawing.Point(89, 53)
            Me.BorderColor.Name = "BorderColor"
            Me.BorderColor.SelectedAsBackcolor = True
            Me.BorderColor.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.BorderColor.Size = New System.Drawing.Size(75, 23)
            Me.BorderColor.TabIndex = 12
            Me.BorderColor.Text = "Color"
            Me.BorderColor.UseVisualStyleBackColor = True
            '
            'AutoLabel13
            '
            Me.AutoLabel13.DX = 0
            Me.AutoLabel13.DY = 0
            Me.AutoLabel13.ForeColor = System.Drawing.Color.MidnightBlue
            Me.AutoLabel13.Location = New System.Drawing.Point(6, 196)
            Me.AutoLabel13.Name = "AutoLabel13"
            Me.AutoLabel13.Size = New System.Drawing.Size(30, 13)
            Me.AutoLabel13.TabIndex = 10
            Me.AutoLabel13.Text = "Style"
            '
            'FontColor
            '
            Me.FontColor.ColorUISize = New System.Drawing.Size(208, 230)
            Me.FontColor.Location = New System.Drawing.Point(89, 121)
            Me.FontColor.Name = "FontColor"
            Me.FontColor.SelectedAsBackcolor = True
            Me.FontColor.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.FontColor.Size = New System.Drawing.Size(75, 23)
            Me.FontColor.TabIndex = 13
            Me.FontColor.Text = "Color"
            Me.FontColor.UseVisualStyleBackColor = True
            '
            'AutoLabel9
            '
            Me.AutoLabel9.DX = 0
            Me.AutoLabel9.DY = 0
            Me.AutoLabel9.ForeColor = System.Drawing.Color.MidnightBlue
            Me.AutoLabel9.Location = New System.Drawing.Point(6, 90)
            Me.AutoLabel9.Name = "AutoLabel9"
            Me.AutoLabel9.Size = New System.Drawing.Size(66, 13)
            Me.AutoLabel9.TabIndex = 4
            Me.AutoLabel9.Text = "BorderWidth"
            '
            'AutoLabel11
            '
            Me.AutoLabel11.DX = 0
            Me.AutoLabel11.DY = 0
            Me.AutoLabel11.ForeColor = System.Drawing.Color.MidnightBlue
            Me.AutoLabel11.Location = New System.Drawing.Point(6, 158)
            Me.AutoLabel11.Name = "AutoLabel11"
            Me.AutoLabel11.Size = New System.Drawing.Size(46, 13)
            Me.AutoLabel11.TabIndex = 6
            Me.AutoLabel11.Text = "Spacing"
            '
            'AutoLabel10
            '
            Me.AutoLabel10.DX = 0
            Me.AutoLabel10.DY = 0
            Me.AutoLabel10.ForeColor = System.Drawing.Color.MidnightBlue
            Me.AutoLabel10.Location = New System.Drawing.Point(6, 121)
            Me.AutoLabel10.Name = "AutoLabel10"
            Me.AutoLabel10.Size = New System.Drawing.Size(52, 13)
            Me.AutoLabel10.TabIndex = 5
            Me.AutoLabel10.Text = "FontColor"
            '
            'chartControl1
            '
            '
            '
            '
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer)))
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            '
            '
            '
            Me.chartControl1.Legend.BackColor = System.Drawing.SystemColors.Control
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.IsWindowLess = False
            Me.chartControl1.Legend.Location = New System.Drawing.Point(396, 218)
            Me.chartControl1.Legend.TabIndex = 3
            Me.chartControl1.Legends.Add(Me.chartControl1.Legend)
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.ScrollBar = Nothing
            Me.chartControl1.PrimaryYAxis.ScrollBar = Nothing
            Me.chartControl1.Size = New System.Drawing.Size(495, 418)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "EssentialChart"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Size = New System.Drawing.Size(176, 37)
            Me.chartControl1.Title.TabIndex = 2
            Me.chartControl1.Title.Text = "EssentialChart"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'comboBox3
            '
            Me.comboBox3.FormattingEnabled = True
            Me.comboBox3.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
            Me.comboBox3.Location = New System.Drawing.Point(92, 312)
            Me.comboBox3.Name = "comboBox3"
            Me.comboBox3.Size = New System.Drawing.Size(115, 21)
            Me.comboBox3.TabIndex = 18
            '
            'comboBox2
            '
            Me.comboBox2.FormattingEnabled = True
            Me.comboBox2.Location = New System.Drawing.Point(92, 271)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(115, 21)
            Me.comboBox2.TabIndex = 17
            '
            'comboBox1
            '
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Location = New System.Drawing.Point(92, 231)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(115, 21)
            Me.comboBox1.TabIndex = 16
            '
            'autoLabel8
            '
            Me.autoLabel8.DX = 0
            Me.autoLabel8.DY = 0
            Me.autoLabel8.Location = New System.Drawing.Point(15, 320)
            Me.autoLabel8.Name = "autoLabel8"
            Me.autoLabel8.Size = New System.Drawing.Size(54, 13)
            Me.autoLabel8.TabIndex = 10
            Me.autoLabel8.Text = "To Target"
            '
            'autoLabel7
            '
            Me.autoLabel7.DX = 0
            Me.autoLabel7.DY = 0
            Me.autoLabel7.Location = New System.Drawing.Point(15, 279)
            Me.autoLabel7.Name = "autoLabel7"
            Me.autoLabel7.Size = New System.Drawing.Size(41, 13)
            Me.autoLabel7.TabIndex = 9
            Me.autoLabel7.Text = "Symbol"
            '
            'autoLabel6
            '
            Me.autoLabel6.DX = 0
            Me.autoLabel6.DY = 0
            Me.autoLabel6.Location = New System.Drawing.Point(15, 239)
            Me.autoLabel6.Name = "autoLabel6"
            Me.autoLabel6.Size = New System.Drawing.Size(30, 13)
            Me.autoLabel6.TabIndex = 8
            Me.autoLabel6.Text = "Style"
            '
            'autoLabel5
            '
            Me.autoLabel5.AutoSize = False
            Me.autoLabel5.DX = 0
            Me.autoLabel5.DY = 0
            Me.autoLabel5.Location = New System.Drawing.Point(15, 191)
            Me.autoLabel5.Name = "autoLabel5"
            Me.autoLabel5.Size = New System.Drawing.Size(52, 21)
            Me.autoLabel5.TabIndex = 7
            Me.autoLabel5.Text = "Spacing"
            '
            'FontColorPicker
            '
            Me.FontColorPicker.ColorUISize = New System.Drawing.Size(208, 230)
            Me.FontColorPicker.Location = New System.Drawing.Point(92, 152)
            Me.FontColorPicker.Name = "FontColorPicker"
            Me.FontColorPicker.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.FontColorPicker.Size = New System.Drawing.Size(75, 23)
            Me.FontColorPicker.TabIndex = 6
            Me.FontColorPicker.Text = "Color  "
            Me.FontColorPicker.UseVisualStyleBackColor = True
            '
            'autoLabel4
            '
            Me.autoLabel4.DX = 0
            Me.autoLabel4.DY = 0
            Me.autoLabel4.Location = New System.Drawing.Point(15, 162)
            Me.autoLabel4.Name = "autoLabel4"
            Me.autoLabel4.Size = New System.Drawing.Size(52, 13)
            Me.autoLabel4.TabIndex = 5
            Me.autoLabel4.Text = "FontColor"
            '
            'BorderColorPicker
            '
            Me.BorderColorPicker.ColorUISize = New System.Drawing.Size(208, 230)
            Me.BorderColorPicker.Location = New System.Drawing.Point(92, 72)
            Me.BorderColorPicker.Name = "BorderColorPicker"
            Me.BorderColorPicker.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.BorderColorPicker.Size = New System.Drawing.Size(75, 23)
            Me.BorderColorPicker.TabIndex = 3
            Me.BorderColorPicker.Text = "Color  "
            Me.BorderColorPicker.UseVisualStyleBackColor = True
            '
            'autoLabel3
            '
            Me.autoLabel3.DX = 0
            Me.autoLabel3.DY = 0
            Me.autoLabel3.Location = New System.Drawing.Point(11, 120)
            Me.autoLabel3.Name = "autoLabel3"
            Me.autoLabel3.Size = New System.Drawing.Size(66, 13)
            Me.autoLabel3.TabIndex = 2
            Me.autoLabel3.Text = "BorderWidth"
            '
            'autoLabel2
            '
            Me.autoLabel2.DX = 0
            Me.autoLabel2.DY = 0
            Me.autoLabel2.Location = New System.Drawing.Point(15, 82)
            Me.autoLabel2.Name = "autoLabel2"
            Me.autoLabel2.Size = New System.Drawing.Size(62, 13)
            Me.autoLabel2.TabIndex = 1
            Me.autoLabel2.Text = "BorderColor"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(721, 418)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Essential Chart-Chart Tooltip "
            Me.panel1.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New Form1())

        End Sub

        Private Sub checkBox_chartArea_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox_chartArea.CheckedChanged
            If Me.checkBox_chartArea.Checked Then
                Me.chartControl1.Text = ""
                Me.chartControl1.Legend.Visible = False
                Me.chartControl1.ElementsSpacing = 0
            Else

                Me.chartControl1.Text = "Performance Plot"
                Me.chartControl1.Legend.Visible = True
                Me.chartControl1.ElementsSpacing = 10
            End If
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitializeChartData()
            Me.chartControl1.Indexed = True
            Me.chartControl1.ChartArea.PrimaryXAxis.HidePartialLabels = True
Me.chartControl1.LegendsPlacement = ChartPlacement.Outside
        Me.chartControl1.LegendAlignment = ChartAlignment.Center
        End Sub

        Protected Sub InitializeChartData()
            series1 = New ChartSeries(" Server 1", ChartSeriesType.Column)
            series1.Text = series1.Name

            series1.Points.Add(0, 256)
            series1.Points.Add(1, 491)
            series1.Points.Add(2, 382)
            series1.Points.Add(3, 437)
            series1.Points.Add(4, 321)

            series1.Style.Font.Bold = True

            series2 = New ChartSeries(" Server 2", ChartSeriesType.Column)
            series2.Text = series2.Name

            series2.Points.Add(0, 437)
            series2.Points.Add(1, 451)
            series2.Points.Add(2, 490)
            series2.Points.Add(3, 366)
            series2.Points.Add(4, 422)

            series2.Style.Font.Bold = True

            AddHandler series1.PrepareStyle, AddressOf ChartControlSeries_PrepareStyle
            AddHandler series2.PrepareStyle, AddressOf ChartControlSeries_PrepareStyle



            Me.chartControl1.Series.Add(series1)
            Me.chartControl1.Series.Add(series2)

            Me.chartControl1.ShowToolTips = Me.ShowTooltip.Checked

            Me.CBox_TooltipFormat.SelectedIndex = 2
            Me.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows
            Me.chartControl1.PrimaryXAxis.Format = "Day 0"
            series1.FancyToolTip.Border.Width = 2

            Me.comWidth.SelectedIndex = 0
            series2.FancyToolTip.Border.Width = 2
            series1.FancyToolTip.Spacing = 5.0F
            series2.FancyToolTip.Spacing = 5.0F


            series1.FancyToolTip.ToTarget = 5.0F
            series2.FancyToolTip.ToTarget = 5.0F



            series1.FancyToolTip.CheckLocation = False
            For Each style As String In System.Enum.GetNames(GetType(Syncfusion.Windows.Forms.Chart.MarkerStyle))
                Me.comboBox4.Items.Add(style)
            Next style

            For Each symbol As String In System.Enum.GetNames(GetType(Syncfusion.Windows.Forms.Chart.ChartSymbolShape))
                Me.comboBox5.Items.Add(symbol)
            Next symbol

        End Sub
        Protected Sub ChartControlSeries_PrepareStyle(ByVal sender As Object, ByVal args As ChartPrepareStyleInfoEventArgs)
            ' Style formatting using a callback. You can apply the same settings directly on the series style on the
            ' point styles.
            Dim series As ChartSeries = CType(IIf(TypeOf sender Is ChartSeries, sender, Nothing), ChartSeries)
            If Not series Is Nothing Then
                args.Style.Text = String.Format("Value is {0}", series.Points(args.Index).YValues(0))
                args.Style.ToolTip = "You are hovering over Day " & series.Points(args.Index).X.ToString()
                args.Handled = True
            End If
        End Sub

        Private Sub ShowTooltip_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ShowTooltip.CheckedChanged
            If Me.ShowTooltip.Checked Then
                Me.chartControl1.ShowToolTips = True
            Else
                Me.chartControl1.ShowToolTips = False
            End If
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub ChartAreaTooltip_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChartAreaTooltip.CheckedChanged
            If Me.ChartAreaTooltip.Checked Then
                Me.chartControl1.ChartAreaToolTip = "Daily Network Load"
            Else
                Me.chartControl1.ChartAreaToolTip = ""
            End If
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub TooltipFormat_Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBox_TooltipFormat.SelectedIndexChanged

            Dim s As ChartSeries
            For Each s In Me.chartControl1.Series
                Dim len As Integer = s.Points.Count
                s.Style.ToolTip = "Server Load"
                Dim i As Integer = 0
                'ORIGINAL LINE: for(int i = 0 ; i < len; i += 1)
                'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
                Do While i < len
                    Dim x As Integer = Me.CBox_TooltipFormat.SelectedIndex
                    s.PointsToolTipFormat = "{" & x.ToString() & "}"

                    '
                    'ToolTips Format Style
                    '
                    '					"{0}" - series Name
                    '
                    '			        "{1}" - SeriesStyle.ToolTip;
                    '
                    '			        "{2}" - SeriesStyle[i].ToolTip; - this is what we want.
                    '
                    '			        "{3}" - series.Points[ index ].X;
                    '
                    '			        "{4+i}" - series.Points[ index ].YValues[i];

                    i += 1
                Loop
            Next s
        End Sub

        Private Sub BorderColor_ColorSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorderColor.ColorSelected
            If Ser1ChkBox.Checked Then
                series1.FancyToolTip.Border.ForeColor = Me.BorderColor.SelectedColor
            End If
            If Ser2ChkBox.Checked Then
                series2.FancyToolTip.Border.ForeColor = Me.BorderColor.SelectedColor
            End If
        End Sub

        Private Sub FontColor_ColorSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontColor.ColorSelected
            If Ser1ChkBox.Checked Then
                series1.FancyToolTip.ForeColor = Me.FontColor.SelectedColor
            End If
            If Ser2ChkBox.Checked Then
                series2.FancyToolTip.ForeColor = Me.FontColor.SelectedColor
            End If
        End Sub

        Private Sub comboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBox4.SelectedIndexChanged
            If Ser1ChkBox.Checked Then
                series1.FancyToolTip.Style = CType(System.Enum.Parse(GetType(Syncfusion.Windows.Forms.Chart.MarkerStyle), Me.comboBox4.SelectedItem.ToString(), True), Syncfusion.Windows.Forms.Chart.MarkerStyle)
            End If
            If Ser2ChkBox.Checked Then
                series2.FancyToolTip.Style = CType(System.Enum.Parse(GetType(Syncfusion.Windows.Forms.Chart.MarkerStyle), Me.comboBox4.SelectedItem.ToString(), True), Syncfusion.Windows.Forms.Chart.MarkerStyle)
            End If

        End Sub

        Private Sub comboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBox5.SelectedIndexChanged
            If Ser1ChkBox.Checked Then
                series1.FancyToolTip.Symbol = CType(System.Enum.Parse(GetType(Syncfusion.Windows.Forms.Chart.ChartSymbolShape), Me.comboBox5.SelectedItem.ToString(), True), Syncfusion.Windows.Forms.Chart.ChartSymbolShape)
            End If
            If Ser2ChkBox.Checked Then
                series2.FancyToolTip.Symbol = CType(System.Enum.Parse(GetType(Syncfusion.Windows.Forms.Chart.ChartSymbolShape), Me.comboBox5.SelectedItem.ToString(), True), Syncfusion.Windows.Forms.Chart.ChartSymbolShape)
            End If
        End Sub

        Private Sub comboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBox6.SelectedIndexChanged
            If Ser1ChkBox.Checked Then
                series1.FancyToolTip.ToTarget = CSng(Convert.ToDouble(Me.comboBox6.SelectedIndex.ToString()))
            End If
            If Ser2ChkBox.Checked Then
                series2.FancyToolTip.ToTarget = CSng(Convert.ToDouble(Me.comboBox6.SelectedIndex.ToString()))
            End If
        End Sub

        Private Sub chartControl1_ChartRegionMouseHover(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs) Handles chartControl1.ChartRegionMouseHover
            If e.Region.SeriesIndex = 1 AndAlso Me.Ser2ChkBox.Checked = False Then
                series1.FancyToolTip.Visible = False
                Me.chartControl1.Redraw(True)
            End If
            If e.Region.SeriesIndex = 0 AndAlso Me.Ser1ChkBox.Checked = False Then
                series2.FancyToolTip.Visible = False
                Me.chartControl1.Redraw(True)

            End If
            If e.Region.SeriesIndex = 0 AndAlso Me.Ser1ChkBox.Checked Then
                series1.FancyToolTip.Visible = True
                series2.FancyToolTip.Visible = False
                Me.chartControl1.Redraw(True)

            End If
            If e.Region.SeriesIndex = 1 AndAlso Me.Ser2ChkBox.Checked Then
                series1.FancyToolTip.Visible = False
                series2.FancyToolTip.Visible = True
                Me.chartControl1.Redraw(True)
            End If
            If e.Region.SeriesIndex = -1 Then
                series1.FancyToolTip.Visible = False
                series2.FancyToolTip.Visible = False
                Me.chartControl1.Redraw(True)
            End If

        End Sub

        Private Sub Ser1ChkBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ser1ChkBox.CheckedChanged
            Me.comboBox4.Text = ""
            Me.comboBox5.Text = ""
            Me.comboBox6.Text = ""

            Me.chartControl1.ShowToolTips = False
            Me.ShowTooltip.Checked = False

            Me.comWidth.SelectedIndex = Convert.ToInt32(series1.FancyToolTip.Border.Width)
            Me.comSpacing.SelectedIndex = Convert.ToInt32(series1.FancyToolTip.Spacing)
            Me.comboBox4.SelectedText = series1.FancyToolTip.Style.ToString()
            Me.comboBox5.SelectedText = series1.FancyToolTip.Symbol.ToString()
            Me.comboBox6.SelectedText = series1.FancyToolTip.ToTarget.ToString()

            If Ser1ChkBox.Checked = True Then
                series1.FancyToolTip.Visible = True
            Else
                series1.FancyToolTip.Visible = False
                If Ser2ChkBox.Checked = True Then
                    Me.comboBox4.Text = ""
                    Me.comboBox5.Text = ""
                    Me.comboBox6.Text = ""
                    Me.comWidth.SelectedIndex = Convert.ToInt32(series2.FancyToolTip.Border.Width)
                    Me.comSpacing.SelectedIndex = Convert.ToInt32(series2.FancyToolTip.Spacing)
                    Me.comboBox4.SelectedText = series2.FancyToolTip.Style.ToString()
                    Me.comboBox5.SelectedText = series2.FancyToolTip.Symbol.ToString()
                    Me.comboBox6.SelectedText = series2.FancyToolTip.ToTarget.ToString()

                Else
                    Me.comboBox4.Text = ""
                    Me.comboBox5.Text = ""
                    Me.comboBox6.Text = ""
                    Me.comWidth.SelectedIndex = 0
                    Me.comSpacing.SelectedIndex = 0

                End If
            End If
        End Sub

        Private Sub Ser2ChkBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ser2ChkBox.CheckedChanged
            Me.comboBox4.Text = ""
            Me.comboBox5.Text = ""
            Me.comboBox6.Text = ""

            Me.chartControl1.ShowToolTips = False
            Me.ShowTooltip.Checked = False

            Me.comWidth.SelectedIndex = Convert.ToInt32(series2.FancyToolTip.Border.Width)
            Me.comSpacing.SelectedIndex = Convert.ToInt32(series2.FancyToolTip.Spacing)
            Me.comboBox4.SelectedText = series2.FancyToolTip.Style.ToString()
            Me.comboBox5.SelectedText = series2.FancyToolTip.Symbol.ToString()
            Me.comboBox6.SelectedText = series2.FancyToolTip.ToTarget.ToString()

            If Ser2ChkBox.Checked = True Then
                series2.FancyToolTip.Visible = True

            Else
                series2.FancyToolTip.Visible = False
                If Ser1ChkBox.Checked = True Then
                    Me.comboBox4.Text = ""
                    Me.comboBox5.Text = ""
                    Me.comboBox6.Text = ""
                    Me.comWidth.SelectedIndex = Convert.ToInt32(series1.FancyToolTip.Border.Width)
                    Me.comSpacing.SelectedIndex = Convert.ToInt32(series1.FancyToolTip.Spacing)
                    Me.comboBox1.SelectedText = series1.FancyToolTip.Style.ToString()
                    Me.comboBox2.SelectedText = series1.FancyToolTip.Symbol.ToString()
                    Me.comboBox3.SelectedText = series1.FancyToolTip.ToTarget.ToString()

                Else
                    Me.comboBox4.Text = ""
                    Me.comboBox5.Text = ""
                    Me.comboBox6.Text = ""
                    Me.comWidth.SelectedIndex = 0
                    Me.comSpacing.SelectedIndex = 0

                End If
            End If
        End Sub

        Private Sub comWidth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comWidth.SelectedIndexChanged
            Dim width As Integer = Convert.ToInt32(Me.comWidth.SelectedIndex)
            If Ser1ChkBox.Checked Then
                series1.FancyToolTip.Border.Width = width
            End If
            If Ser2ChkBox.Checked Then
                series2.FancyToolTip.Border.Width = width
            End If
        End Sub

        Private Sub comSpacing_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comSpacing.SelectedIndexChanged
            If Ser1ChkBox.Checked Then
                series1.FancyToolTip.Spacing = CSng(Convert.ToDouble(Me.comSpacing.SelectedIndex.ToString()))
            End If
            If Ser2ChkBox.Checked Then
                series2.FancyToolTip.Spacing = CSng(Convert.ToDouble(Me.comSpacing.SelectedIndex.ToString()))
            End If
        End Sub
    End Class
End Namespace
