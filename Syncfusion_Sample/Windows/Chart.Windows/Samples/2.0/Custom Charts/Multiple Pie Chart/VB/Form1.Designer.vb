Imports Microsoft.VisualBasic
Imports System
Namespace MultiplePieChart_2005
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim chartToolBarSaveItem1 As New Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem()
			Dim chartToolBarCopyItem1 As New Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem()
			Dim chartToolBarPrintItem1 As New Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem()
			Dim chartToolBarPrintPreviewItem1 As New Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem()
			Dim chartToolBarSplitter1 As New Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter()
			Dim chartToolBarPaletteItem1 As New Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem()
			Dim chartToolBarStyleItem1 As New Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem()
			Dim chartToolBarTypeItem1 As New Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem()
			Dim chartToolBarSeries3DItem1 As New Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem()
			Dim chartToolBarShowLegendItem1 As New Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.nUpDownPieHeight = New System.Windows.Forms.NumericUpDown()
			Me.lblPieHeight = New System.Windows.Forms.Label()
			Me.ckBxEnable3D = New System.Windows.Forms.CheckBox()
			Me.ckBxDisplayText = New System.Windows.Forms.CheckBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.cbBxPieType = New System.Windows.Forms.ComboBox()
			Me.panel1.SuspendLayout()
			CType(Me.nUpDownPieHeight, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			' 
			' 
			' 
			Me.chartControl1.Legend.Location = New System.Drawing.Point(366, 75)
			Me.chartControl1.Location = New System.Drawing.Point(8, 11)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.PrimaryYAxis.ForceZero = True
			Me.chartControl1.Size = New System.Drawing.Size(475, 357)
			Me.chartControl1.TabIndex = 0
			Me.chartControl1.Text = "chartControl1"
			' 
			' 
			' 
			Me.chartControl1.Title.Name = "Default"
			Me.chartControl1.Titles.Add(Me.chartControl1.Title)
			Me.chartControl1.ToolBar.Items.Add(chartToolBarSaveItem1)
			Me.chartControl1.ToolBar.Items.Add(chartToolBarCopyItem1)
			Me.chartControl1.ToolBar.Items.Add(chartToolBarPrintItem1)
			Me.chartControl1.ToolBar.Items.Add(chartToolBarPrintPreviewItem1)
			Me.chartControl1.ToolBar.Items.Add(chartToolBarSplitter1)
			Me.chartControl1.ToolBar.Items.Add(chartToolBarPaletteItem1)
			Me.chartControl1.ToolBar.Items.Add(chartToolBarStyleItem1)
			Me.chartControl1.ToolBar.Items.Add(chartToolBarTypeItem1)
			Me.chartControl1.ToolBar.Items.Add(chartToolBarSeries3DItem1)
			Me.chartControl1.ToolBar.Items.Add(chartToolBarShowLegendItem1)
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Controls.Add(Me.cbBxPieType)
			Me.panel1.Controls.Add(Me.ckBxDisplayText)
			Me.panel1.Controls.Add(Me.nUpDownPieHeight)
			Me.panel1.Controls.Add(Me.lblPieHeight)
			Me.panel1.Controls.Add(Me.ckBxEnable3D)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
			Me.panel1.Location = New System.Drawing.Point(489, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(152, 378)
			Me.panel1.TabIndex = 1
			' 
			' nUpDownPieHeight
			' 
			Me.nUpDownPieHeight.ForeColor = System.Drawing.Color.MidnightBlue
			Me.nUpDownPieHeight.Location = New System.Drawing.Point(65, 150)
			Me.nUpDownPieHeight.Maximum = New Decimal(New Integer() { 15, 0, 0, 0})
			Me.nUpDownPieHeight.Minimum = New Decimal(New Integer() { 7, 0, 0, 0})
			Me.nUpDownPieHeight.Name = "nUpDownPieHeight"
			Me.nUpDownPieHeight.Size = New System.Drawing.Size(53, 20)
			Me.nUpDownPieHeight.TabIndex = 9
			Me.nUpDownPieHeight.Value = New Decimal(New Integer() { 7, 0, 0, 0})
'			Me.nUpDownPieHeight.ValueChanged += New System.EventHandler(Me.nUpDownPieHeight_ValueChanged)
			' 
			' lblPieHeight
			' 
			Me.lblPieHeight.AutoSize = True
			Me.lblPieHeight.ForeColor = System.Drawing.Color.MidnightBlue
			Me.lblPieHeight.Location = New System.Drawing.Point(5, 152)
			Me.lblPieHeight.Name = "lblPieHeight"
			Me.lblPieHeight.Size = New System.Drawing.Size(56, 13)
			Me.lblPieHeight.TabIndex = 8
			Me.lblPieHeight.Text = "Pie Height"
			' 
			' ckBxEnable3D
			' 
			Me.ckBxEnable3D.AutoSize = True
			Me.ckBxEnable3D.ForeColor = System.Drawing.Color.MidnightBlue
			Me.ckBxEnable3D.Location = New System.Drawing.Point(9, 231)
			Me.ckBxEnable3D.Name = "ckBxEnable3D"
			Me.ckBxEnable3D.Size = New System.Drawing.Size(76, 17)
			Me.ckBxEnable3D.TabIndex = 2
			Me.ckBxEnable3D.Text = "Enable 3D"
			Me.ckBxEnable3D.UseVisualStyleBackColor = True
'			Me.ckBxEnable3D.CheckedChanged += New System.EventHandler(Me.ckBxEnable3D_CheckedChanged)
			' 
			' ckBxDisplayText
			' 
			Me.ckBxDisplayText.AutoSize = True
			Me.ckBxDisplayText.Checked = True
			Me.ckBxDisplayText.CheckState = System.Windows.Forms.CheckState.Checked
			Me.ckBxDisplayText.ForeColor = System.Drawing.Color.MidnightBlue
			Me.ckBxDisplayText.Location = New System.Drawing.Point(9, 197)
			Me.ckBxDisplayText.Name = "ckBxDisplayText"
			Me.ckBxDisplayText.Size = New System.Drawing.Size(84, 17)
			Me.ckBxDisplayText.TabIndex = 10
			Me.ckBxDisplayText.Text = "Display Text"
			Me.ckBxDisplayText.UseVisualStyleBackColor = True
'			Me.ckBxDisplayText.CheckedChanged += New System.EventHandler(Me.ckBxDisplayText_CheckedChanged)
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label2.Location = New System.Drawing.Point(6, 121)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(46, 13)
			Me.label2.TabIndex = 12
			Me.label2.Text = "PieType"
			' 
			' cbBxPieType
			' 
			Me.cbBxPieType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cbBxPieType.ForeColor = System.Drawing.Color.MidnightBlue
			Me.cbBxPieType.FormattingEnabled = True
			Me.cbBxPieType.Location = New System.Drawing.Point(65, 119)
			Me.cbBxPieType.Name = "cbBxPieType"
			Me.cbBxPieType.Size = New System.Drawing.Size(77, 21)
			Me.cbBxPieType.TabIndex = 11
'			Me.cbBxPieType.SelectedIndexChanged += New System.EventHandler(Me.cbBxPieType_SelectedIndexChanged)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.White
			Me.ClientSize = New System.Drawing.Size(641, 378)
			Me.Controls.Add(Me.chartControl1)
			Me.Controls.Add(Me.panel1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Multiple Pie Chart"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.nUpDownPieHeight, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents ckBxEnable3D As System.Windows.Forms.CheckBox
		Private lblPieHeight As System.Windows.Forms.Label
		Private WithEvents nUpDownPieHeight As System.Windows.Forms.NumericUpDown
		Private WithEvents ckBxDisplayText As System.Windows.Forms.CheckBox
		Private label2 As System.Windows.Forms.Label
		Private WithEvents cbBxPieType As System.Windows.Forms.ComboBox
	End Class
End Namespace

