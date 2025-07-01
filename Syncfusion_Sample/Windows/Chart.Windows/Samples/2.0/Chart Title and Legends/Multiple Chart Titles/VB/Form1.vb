#Region "Copyright Syncfusion Inc. 2001 - 2007"
'
'  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
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
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart


Namespace ChartTitle
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits Office2007Form
		#Region "Private Members"
		Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private WithEvents txtChartTitle As TextBox
		Private WithEvents cmbAlignment As ComboBox
		Private WithEvents cmbChartTitle As ComboBox
		Private WithEvents comboBox_TitlesDocking As ComboBox
		Private WithEvents button_Addtitle As Button
		Private title As Syncfusion.Windows.Forms.Chart.ChartTitle

		Private WithEvents chkVisible As CheckBox
		Private WithEvents btnDeleteTitle As Button
		Private toolTip1 As ToolTip
		Private label13 As Label
		Private label2 As Label
		Private label1 As Label
		Private label4 As Label
		Private chartTitle1 As Syncfusion.Windows.Forms.Chart.ChartTitle
		Private chartTitle2 As Syncfusion.Windows.Forms.Chart.ChartTitle
		Private designerPanel1 As DesignerPanel
		Private imageListAdv1 As Syncfusion.Windows.Forms.Tools.ImageListAdv
		Private bannerTextProvider1 As BannerTextProvider
		Private components As IContainer
		#End Region

		#Region "Form Constructor, Main and Dispose"
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
            Me.components = New System.ComponentModel.Container
            Dim ChartToolBarSaveItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem
            Dim ChartToolBarCopyItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem
            Dim ChartToolBarPrintItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem
            Dim ChartToolBarPrintPreviewItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem
            Dim ChartToolBarSplitter1 As Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter = New Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter
            Dim ChartToolBarPaletteItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem
            Dim ChartToolBarStyleItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem
            Dim ChartToolBarTypeItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem
            Dim ChartToolBarSeries3DItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem
            Dim ChartToolBarShowLegendItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim BannerTextInfo1 As Syncfusion.Windows.Forms.BannerTextInfo = New Syncfusion.Windows.Forms.BannerTextInfo
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.chartTitle1 = New Syncfusion.Windows.Forms.Chart.ChartTitle
            Me.chartTitle2 = New Syncfusion.Windows.Forms.Chart.ChartTitle
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.button_Addtitle = New System.Windows.Forms.Button
            Me.btnDeleteTitle = New System.Windows.Forms.Button
            Me.imageListAdv1 = New Syncfusion.Windows.Forms.Tools.ImageListAdv(Me.components)
            Me.bannerTextProvider1 = New Syncfusion.Windows.Forms.BannerTextProvider(Me.components)
            Me.txtChartTitle = New System.Windows.Forms.TextBox
            Me.designerPanel1 = New MultipleChartTitle.DesignerPanel
            Me.chkVisible = New System.Windows.Forms.CheckBox
            Me.cmbChartTitle = New System.Windows.Forms.ComboBox
            Me.cmbAlignment = New System.Windows.Forms.ComboBox
            Me.comboBox_TitlesDocking = New System.Windows.Forms.ComboBox
            Me.label13 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.chartControl1.SuspendLayout()
            CType(Me.designerPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.designerPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(159, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(174, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(189, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(194, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(149, Byte), Integer))})
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Embed
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(1, 5, 3, 1)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White)
            Me.chartControl1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            '
            '
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)))
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.Legend.ForeColor = System.Drawing.Color.White
            Me.chartControl1.Legend.Location = New System.Drawing.Point(72, 243)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
            Me.chartControl1.Legend.RepresentationType = Syncfusion.Windows.Forms.Chart.ChartLegendRepresentationType.None
            Me.chartControl1.Legend.ShowBorder = True
            Me.chartControl1.Location = New System.Drawing.Point(12, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.PrimaryXAxis.DrawGrid = False
            Me.chartControl1.PrimaryXAxis.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.Color.MidnightBlue
            Me.chartControl1.PrimaryXAxis.LabelIntersectAction = Syncfusion.Windows.Forms.Chart.ChartLabelIntersectAction.Wrap
            Me.chartControl1.PrimaryXAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 3, 1)
            Me.chartControl1.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.PrimaryXAxis.SmallTickSize = New System.Drawing.Size(1, 2)
            Me.chartControl1.PrimaryXAxis.SmallTicksPerInterval = 12
            Me.chartControl1.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.chartControl1.PrimaryXAxis.TickSize = New System.Drawing.Size(1, 3)
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.PrimaryYAxis.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.Color.MidnightBlue
            Me.chartControl1.PrimaryYAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(6000, 16000, 2000)
            Me.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.chartControl1.Size = New System.Drawing.Size(526, 358)
            Me.chartControl1.TabIndex = 1
            Me.chartControl1.Text = "Imports from Mexico, Japan"
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.Title.ForeColor = System.Drawing.Color.MidnightBlue
            Me.chartControl1.Title.Margin = 1
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Imports from Mexico, Japan"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.Titles.Add(Me.chartTitle1)
            Me.chartControl1.Titles.Add(Me.chartTitle2)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarSaveItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarCopyItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarPrintItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarPrintPreviewItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarSplitter1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarPaletteItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarStyleItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarTypeItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarSeries3DItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarShowLegendItem1)
            '
            'chartTitle1
            '
            Me.chartTitle1.Border.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(148, Byte), Integer))
            Me.chartTitle1.Border.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
            Me.chartTitle1.Border.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(148, Byte), Integer))
            Me.chartTitle1.Border.PenType = System.Drawing.Drawing2D.PenType.PathGradient
            Me.chartTitle1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartTitle1.ForeColor = System.Drawing.Color.Maroon
            Me.chartTitle1.Margin = 1
            Me.chartTitle1.Name = "chartTitle1"
            Me.chartTitle1.ShowBorder = True
            Me.chartTitle1.Text = "U.S. Imports, Reported in Millions of Dollars"
            '
            'chartTitle2
            '
            Me.chartTitle2.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Near
            Me.chartTitle2.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartTitle2.ForeColor = System.Drawing.Color.SaddleBrown
            Me.chartTitle2.Margin = 1
            Me.chartTitle2.Name = "chartTitle2"
            Me.chartTitle2.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
            Me.chartTitle2.Text = "Source: U.S. Bureau of the Census, " & Global.Microsoft.VisualBasic.ChrW(10) & "             U.S. Bureau of Economic Analysis" & _
                ""
            '
            'button_Addtitle
            '
            Me.button_Addtitle.Enabled = False
            Me.button_Addtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button_Addtitle.ForeColor = System.Drawing.Color.MidnightBlue
            Me.button_Addtitle.Location = New System.Drawing.Point(304, 64)
            Me.button_Addtitle.Name = "button_Addtitle"
            Me.button_Addtitle.Size = New System.Drawing.Size(20, 20)
            Me.button_Addtitle.TabIndex = 51
            Me.button_Addtitle.Text = "+"
            Me.toolTip1.SetToolTip(Me.button_Addtitle, "Add Title")
            Me.button_Addtitle.UseVisualStyleBackColor = True
            '
            'btnDeleteTitle
            '
            Me.btnDeleteTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnDeleteTitle.ForeColor = System.Drawing.Color.MidnightBlue
            Me.btnDeleteTitle.Location = New System.Drawing.Point(304, 89)
            Me.btnDeleteTitle.Name = "btnDeleteTitle"
            Me.btnDeleteTitle.Size = New System.Drawing.Size(20, 20)
            Me.btnDeleteTitle.TabIndex = 72
            Me.btnDeleteTitle.Text = "-"
            Me.toolTip1.SetToolTip(Me.btnDeleteTitle, "Remove Title")
            Me.btnDeleteTitle.UseVisualStyleBackColor = True
            '
            'imageListAdv1
            '
            Me.imageListAdv1.Images.AddRange(New System.Drawing.Image() {CType(resources.GetObject("imageListAdv1.Images"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images1"), System.Drawing.Image)})
            '
            'txtChartTitle
            '
            BannerTextInfo1.Text = "Enter the text and press + button"
            BannerTextInfo1.Visible = True
            Me.bannerTextProvider1.SetBannerText(Me.txtChartTitle, BannerTextInfo1)
            Me.txtChartTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtChartTitle.ForeColor = System.Drawing.Color.MidnightBlue
            Me.txtChartTitle.Location = New System.Drawing.Point(70, 64)
            Me.txtChartTitle.Name = "txtChartTitle"
            Me.txtChartTitle.Size = New System.Drawing.Size(228, 20)
            Me.txtChartTitle.TabIndex = 50
            '
            'designerPanel1
            '
            Me.designerPanel1.BackColor = System.Drawing.Color.White
            Me.designerPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(243, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))})
            Me.designerPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.designerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.designerPanel1.Controls.Add(Me.chkVisible)
            Me.designerPanel1.Controls.Add(Me.txtChartTitle)
            Me.designerPanel1.Controls.Add(Me.cmbChartTitle)
            Me.designerPanel1.Controls.Add(Me.cmbAlignment)
            Me.designerPanel1.Controls.Add(Me.comboBox_TitlesDocking)
            Me.designerPanel1.Controls.Add(Me.label13)
            Me.designerPanel1.Controls.Add(Me.button_Addtitle)
            Me.designerPanel1.Controls.Add(Me.btnDeleteTitle)
            Me.designerPanel1.Controls.Add(Me.label2)
            Me.designerPanel1.Controls.Add(Me.label1)
            Me.designerPanel1.Controls.Add(Me.label4)
            Me.designerPanel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.designerPanel1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.designerPanel1.HeaderImage = CType(resources.GetObject("designerPanel1.HeaderImage"), System.Drawing.Image)
            Me.designerPanel1.HeaderText = "       Title"
            Me.designerPanel1.Location = New System.Drawing.Point(8, 389)
            Me.designerPanel1.Name = "designerPanel1"
            Me.designerPanel1.Size = New System.Drawing.Size(535, 117)
            Me.designerPanel1.TabIndex = 145
            '
            'chkVisible
            '
            Me.chkVisible.AutoSize = True
            Me.chkVisible.Checked = True
            Me.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkVisible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkVisible.ForeColor = System.Drawing.Color.MidnightBlue
            Me.chkVisible.Location = New System.Drawing.Point(8, 35)
            Me.chkVisible.Name = "chkVisible"
            Me.chkVisible.Size = New System.Drawing.Size(76, 17)
            Me.chkVisible.TabIndex = 59
            Me.chkVisible.Text = "Show Title"
            Me.chkVisible.UseVisualStyleBackColor = True
            '
            'cmbChartTitle
            '
            Me.cmbChartTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbChartTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbChartTitle.ForeColor = System.Drawing.Color.MidnightBlue
            Me.cmbChartTitle.FormattingEnabled = True
            Me.cmbChartTitle.Location = New System.Drawing.Point(70, 89)
            Me.cmbChartTitle.Name = "cmbChartTitle"
            Me.cmbChartTitle.Size = New System.Drawing.Size(228, 21)
            Me.cmbChartTitle.TabIndex = 53
            '
            'cmbAlignment
            '
            Me.cmbAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbAlignment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbAlignment.ForeColor = System.Drawing.Color.MidnightBlue
            Me.cmbAlignment.FormattingEnabled = True
            Me.cmbAlignment.Items.AddRange(New Object() {"Center", "Far", "Near"})
            Me.cmbAlignment.Location = New System.Drawing.Point(419, 64)
            Me.cmbAlignment.Name = "cmbAlignment"
            Me.cmbAlignment.Size = New System.Drawing.Size(105, 21)
            Me.cmbAlignment.TabIndex = 56
            '
            'comboBox_TitlesDocking
            '
            Me.comboBox_TitlesDocking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox_TitlesDocking.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboBox_TitlesDocking.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox_TitlesDocking.FormattingEnabled = True
            Me.comboBox_TitlesDocking.Items.AddRange(New Object() {"Left", "Right", "Top", "Bottom", "Floating"})
            Me.comboBox_TitlesDocking.Location = New System.Drawing.Point(419, 89)
            Me.comboBox_TitlesDocking.Name = "comboBox_TitlesDocking"
            Me.comboBox_TitlesDocking.Size = New System.Drawing.Size(105, 21)
            Me.comboBox_TitlesDocking.TabIndex = 52
            '
            'label13
            '
            Me.label13.AutoSize = True
            Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label13.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label13.Location = New System.Drawing.Point(8, 64)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(49, 13)
            Me.label13.TabIndex = 126
            Me.label13.Text = "Add Title"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Location = New System.Drawing.Point(8, 89)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(60, 13)
            Me.label2.TabIndex = 127
            Me.label2.Text = "Select Title"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Location = New System.Drawing.Point(357, 64)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(53, 13)
            Me.label1.TabIndex = 128
            Me.label1.Text = "Alignment"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label4.Location = New System.Drawing.Point(357, 89)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(44, 13)
            Me.label4.TabIndex = 129
            Me.label4.Text = "Position"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(550, 514)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.designerPanel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Multiple Chart Titles"
            Me.chartControl1.ResumeLayout(False)
            Me.chartControl1.PerformLayout()
            CType(Me.designerPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.designerPanel1.ResumeLayout(False)
            Me.designerPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		#Region "Form Load"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitializeChartData()
            InitializeControlSettings()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
			ResetControls()

		End Sub
		#End Region

		#Region "Helper Methods"

		#Region "InitializeChartData"
		Protected Sub InitializeChartData()
			Dim series As ChartSeries = New ChartSeries()
			series.Name = "Series 0"
			series.Type = ChartSeriesType.Line
			series.Text = "Mexico"

			series.Points.Add(0, 8500)
			series.Points.Add(0.1, 9000)
			series.Points.Add(0.2, 9500)
			series.Points.Add(0.3, 8800)
			series.Points.Add(0.4, 9000)
			series.Points.Add(0.5, 9500)
			series.Points.Add(0.6, 9200)
			series.Points.Add(0.7, 9500)
			series.Points.Add(0.8, 9900)
			series.Points.Add(0.9, 10000)
			series.Points.Add(0.10, 10000)
			series.Points.Add(0.11, 9400)

			series.Points.Add(1, 10000)
			series.Points.Add(1.1, 9500)
			series.Points.Add(1.2, 9900)
			series.Points.Add(1.3, 10000)
			series.Points.Add(1.4, 10100)
			series.Points.Add(1.5, 11000)
			series.Points.Add(1.6, 11100)
			series.Points.Add(1.7, 10000)
			series.Points.Add(1.8, 12500)
			series.Points.Add(1.9, 13000)
			series.Points.Add(1.10, 11000)
			series.Points.Add(1.11, 10000)

			series.Points.Add(2, 10400)
			series.Points.Add(2.1, 10100)
			series.Points.Add(2.2, 12000)
			series.Points.Add(2.3, 10250)
			series.Points.Add(2.4, 11200)
			series.Points.Add(2.5, 11300)
			series.Points.Add(2.6, 11800)
			series.Points.Add(2.7, 10500)
			series.Points.Add(2.8, 10000)
			series.Points.Add(2.9, 10200)
			series.Points.Add(2.10, 11600)
            series.Points.Add(2.11, 11800)
            series.Style.Font.Bold = True
            Me.chartControl1.Series.Add(series)

			Dim series1 As ChartSeries = New ChartSeries()
			series1.Name = "Series 1"
			series1.Type = ChartSeriesType.Line
			series1.Text = "Japan"

			series1.Points.Add(0, 10500)
			series1.Points.Add(0.1, 11000)
			series1.Points.Add(0.2, 11500)
			series1.Points.Add(0.3, 10800)
			series1.Points.Add(0.4, 11000)
			series1.Points.Add(0.5, 11500)
			series1.Points.Add(0.6, 11200)
			series1.Points.Add(0.7, 11500)
			series1.Points.Add(0.8, 11900)
			series1.Points.Add(0.9, 12000)
			series1.Points.Add(0.10, 12000)
			series1.Points.Add(0.11, 11400)

			series1.Points.Add(1, 12300)
			series1.Points.Add(1.1, 12500)
			series1.Points.Add(1.2, 11000)
			series1.Points.Add(1.3, 12800)
			series1.Points.Add(1.4, 13000)
			series1.Points.Add(1.5, 13300)
			series1.Points.Add(1.6, 13500)
			series1.Points.Add(1.7, 13600)
			series1.Points.Add(1.8, 14500)
			series1.Points.Add(1.9, 13000)
			series1.Points.Add(1.10, 12200)
			series1.Points.Add(1.11, 12000)

			series1.Points.Add(2, 12400)
			series1.Points.Add(2.1, 12100)
			series1.Points.Add(2.2, 14000)
			series1.Points.Add(2.3, 12250)
			series1.Points.Add(2.4, 13200)
			series1.Points.Add(2.5, 14300)
			series.Points.Add(2.6, 13000)
			series1.Points.Add(2.7, 12500)
			series1.Points.Add(2.8, 12000)
			series1.Points.Add(2.9, 12200)
			series1.Points.Add(2.10, 13600)
			series1.Points.Add(2.11, 13000)
			series1.Style.Font.Bold = True
			Me.chartControl1.Series.Add(series1)


		End Sub
		#End Region

		#Region "InitializeControlSettings"
        Private Sub InitializeControlSettings()

            For Each cli As ChartLegendItem In Me.chartControl1.Legends(0).Items
                cli.RepresentationSize = New Size(16, 16)
                cli.TextColor = Color.White
                cli.Font = New Font("Verdana", 7.0F, FontStyle.Bold)
            Next cli

            For Each cTitle As Syncfusion.Windows.Forms.Chart.ChartTitle In Me.chartControl1.Titles
                Me.cmbChartTitle.Items.Add(cTitle.Text)
            Next cTitle
            Me.cmbChartTitle.SelectedIndex = 0
        End Sub
		#End Region


		#Region "ResetControls"
		Private Sub ResetControls()
			Me.chkVisible.Checked = Me.chartControl1.Titles(Me.cmbChartTitle.SelectedIndex).Visible
			Me.cmbAlignment.SelectedItem = (Me.chartControl1.Titles(Me.cmbChartTitle.SelectedIndex).Alignment.ToString())
			Me.comboBox_TitlesDocking.SelectedItem = Me.chartControl1.Titles(Me.cmbChartTitle.SelectedIndex).Position.ToString()
		End Sub
		#End Region
		#End Region

		#Region "Events"

		#Region "Titles"


		Private Sub button_Addtitle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button_Addtitle.Click
			If Not Me.comboBox_TitlesDocking.SelectedItem Is Nothing Then
				' Add the title to the Chart control's Titles collection.                
				title = New Syncfusion.Windows.Forms.Chart.ChartTitle()
				title.Text = Me.txtChartTitle.Text
				Me.cmbChartTitle.Items.Add(Me.txtChartTitle.Text)
				title.Position = CType(System.Enum.Parse(GetType(ChartDock), Me.comboBox_TitlesDocking.SelectedItem.ToString()), ChartDock)


				Me.chartControl1.Titles.Add(title)
				Me.cmbChartTitle.SelectedItem = Me.txtChartTitle.Text
				Me.chartControl1.Redraw(True)
				Me.txtChartTitle.Text = ""
				Me.button_Addtitle.Enabled = False

			Else
				MessageBox.Show("Provide full valid data...")
			End If
		End Sub

		Private Sub comboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbChartTitle.SelectedIndexChanged
			' Perform customization to the selected Title
			If Not Me.cmbAlignment.SelectedItem Is Nothing Then
				ResetControls()
			End If
		End Sub

        Private Sub chkVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkVisible.CheckedChanged

            If Not (Me.cmbChartTitle.SelectedIndex < 0) Then
                Me.chartControl1.Titles(Me.cmbChartTitle.SelectedIndex).Visible = Me.chkVisible.Checked
            End If

        End Sub




        Private Sub cmbAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbAlignment.SelectedIndexChanged
            If (Not Me.cmbChartTitle.SelectedIndex < 0) Then
                Me.chartControl1.Titles(Me.cmbChartTitle.SelectedIndex).Alignment = CType(System.Enum.Parse(GetType(ChartAlignment), Me.cmbAlignment.SelectedItem.ToString()), ChartAlignment)
            End If

        End Sub
        Private Sub comboBox_TitlesDocking_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox_TitlesDocking.SelectedIndexChanged
            If Not (Me.cmbChartTitle.SelectedIndex < 0) Then
                Me.chartControl1.Titles(Me.cmbChartTitle.SelectedIndex).Position = CType(System.Enum.Parse(GetType(ChartDock), Me.comboBox_TitlesDocking.SelectedItem.ToString()), ChartDock)
            End If
            If Me.comboBox_TitlesDocking.SelectedIndex = 4 Then
                Me.cmbAlignment.Enabled = False
            Else
                Me.cmbAlignment.Enabled = True
            End If
        End Sub




		Private Sub txtChartTitle_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtChartTitle.TextChanged
			If Me.txtChartTitle.Text <> "" Then
				Me.button_Addtitle.Enabled = True
			Else
				Me.button_Addtitle.Enabled = False
			End If
		End Sub

		Private Sub btnDeleteTitle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeleteTitle.Click
			If Not Me.cmbChartTitle.SelectedItem Is Nothing Then
				title = New Syncfusion.Windows.Forms.Chart.ChartTitle()
				title.Text = Me.cmbChartTitle.SelectedItem.ToString()
				Me.chartControl1.Titles.RemoveAt(Me.cmbChartTitle.SelectedIndex)
				Me.cmbChartTitle.Items.Remove(Me.cmbChartTitle.SelectedItem.ToString())

				If Me.chartControl1.Titles.Count.ToString() <> "0" Then
					Me.cmbChartTitle.SelectedIndex = 0
				End If

				Me.chartControl1.Refresh()
			End If

		End Sub

		#End Region

		Private Sub chartControl1_ChartFormatAxisLabel(ByVal sender As Object, ByVal e As ChartFormatAxisLabelEventArgs) Handles chartControl1.ChartFormatAxisLabel
			If e.AxisOrientation = ChartOrientation.Horizontal Then
			   Select Case CInt(e.Value)
					Case 0
						e.Label = "0"
					Case 1
						e.Label = "1999"
					Case 2
						e.Label = "2000"
					Case 3
						e.Label = "2001"

			   End Select
			End If
		  e.Handled = True
		End Sub
	  #End Region
	End Class
End Namespace
