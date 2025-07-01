Imports Microsoft.VisualBasic
Imports System
Namespace RangeAreaChart_Sample
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
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
            Dim ChartSeries1 As Syncfusion.Windows.Forms.Chart.ChartSeries = New Syncfusion.Windows.Forms.Chart.ChartSeries
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
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.CheckBox1 = New System.Windows.Forms.CheckBox
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Embed
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            Me.chartControl1.ElementsSpacing = 0
            Me.chartControl1.ForeColor = System.Drawing.SystemColors.ControlText
            '
            '
            '
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.Legend.Location = New System.Drawing.Point(44, 52)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.Legend.RowsCount = 3
            Me.chartControl1.Legend.ShowBorder = True
            Me.chartControl1.Legend.ShowSymbol = True
            Me.chartControl1.Location = New System.Drawing.Point(7, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Pastel
            Me.chartControl1.PrimaryXAxis.BreakInfo.SpacingColor = System.Drawing.Color.Transparent
            Me.chartControl1.PrimaryXAxis.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.SystemColors.ControlText
            Me.chartControl1.PrimaryXAxis.GridLineType.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.chartControl1.PrimaryXAxis.LineType.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.chartControl1.PrimaryYAxis.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.PrimaryYAxis.ForceZero = True
            Me.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.SystemColors.ControlText
            Me.chartControl1.PrimaryYAxis.GridLineType.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.chartControl1.PrimaryYAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
            Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.chartControl1.PrimaryYAxis.LineType.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(226, Byte), Integer))
            ChartSeries1.Name = "Default"
            ChartSeries1.Points.Add(0, CType(32, Double), CType(123, Double), CType(75, Double), CType(90, Double))
            ChartSeries1.Points.Add(1, CType(27, Double), CType(55, Double), CType(37, Double), CType(48, Double))
            ChartSeries1.Points.Add(2, CType(21, Double), CType(30, Double), CType(27, Double), CType(21, Double))
            ChartSeries1.Points.Add(3, CType(34, Double), CType(308, Double), CType(303, Double), CType(190, Double))
            ChartSeries1.Points.Add(4, CType(2, Double), CType(256, Double), CType(144, Double), CType(130, Double))
            ChartSeries1.Style.Font.Facename = "Microsoft Sans Serif"
            ChartSeries1.Text = "Default"
            Me.chartControl1.Series.Add(ChartSeries1)
            Me.chartControl1.Size = New System.Drawing.Size(546, 382)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "Weather Graph "
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.Title.ForeColor = System.Drawing.SystemColors.ControlText
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ToolBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.chartControl1.ToolBar.ButtonBackColor = System.Drawing.SystemColors.ControlLight
            Me.chartControl1.ToolBar.ButtonForeColor = System.Drawing.SystemColors.ActiveBorder
            Me.chartControl1.ToolBar.ButtonSize = New System.Drawing.Size(26, 26)
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
            'CheckBox1
            '
            Me.CheckBox1.AutoSize = True
            Me.CheckBox1.Location = New System.Drawing.Point(482, 402)
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Size = New System.Drawing.Size(76, 17)
            Me.CheckBox1.TabIndex = 1
            Me.CheckBox1.Text = "Enable 3D"
            Me.CheckBox1.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(563, 429)
            Me.Controls.Add(Me.CheckBox1)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Range Area Chart"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
	End Class
End Namespace

