Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Windows.Forms.Chart.Statistics
Imports Syncfusion.Drawing

Namespace ChartStatisticalFormulas
	Public Class Form1
		Inherits Syncfusion.Windows.Forms.Office2007Form
		#Region "Private Members"
		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private series1 As ChartSeries
		Private series2 As ChartSeries
		Private series3 As ChartSeries

		Private sqrtVarianceOfFirstSeries As Double 'Standard deviation of the first series.
		Private sqrtVarianceOfSecondSeries As Double 'Standard deviation of the second series.
		Private sqrtVarianceOfThirdSeries As Double 'Standard deviation of the third series.
		Private meanOfFirstSeries As Double 'Mean of the first series.
		Private meanOfSecondSeries As Double 'Mean of the second series.
		Private meanOfThirdSeries As Double 'Mean of the third series.
		Private richTextBox1 As System.Windows.Forms.RichTextBox
		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
		Private WithEvents numericUpDown2 As System.Windows.Forms.NumericUpDown
		Private WithEvents numericUpDown3 As System.Windows.Forms.NumericUpDown
		Private WithEvents numericUpDown4 As System.Windows.Forms.NumericUpDown
		Private WithEvents numericUpDown5 As System.Windows.Forms.NumericUpDown
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
		Private WithEvents button2 As System.Windows.Forms.Button
		Private label6 As System.Windows.Forms.Label
		Private WithEvents numericUpDown6 As System.Windows.Forms.NumericUpDown
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private label31 As Label
		Private toolTip1 As ToolTip
		Private label7 As Label
		Private label8 As Label
		Private components As IContainer
		#End Region

		#Region "Form's Constructor, Main And Dispose"
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
			Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
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
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label31 = New System.Windows.Forms.Label
            Me.numericUpDown6 = New System.Windows.Forms.NumericUpDown
            Me.label6 = New System.Windows.Forms.Label
            Me.button1 = New System.Windows.Forms.Button
            Me.numericUpDown5 = New System.Windows.Forms.NumericUpDown
            Me.numericUpDown4 = New System.Windows.Forms.NumericUpDown
            Me.numericUpDown3 = New System.Windows.Forms.NumericUpDown
            Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.label5 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.button2 = New System.Windows.Forms.Button
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.label7 = New System.Windows.Forms.Label
            Me.label8 = New System.Windows.Forms.Label
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            CType(Me.numericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer)))
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Sunken
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            '
            '
            '
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(60, 226)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
            Me.chartControl1.Location = New System.Drawing.Point(62, 7)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.Size = New System.Drawing.Size(536, 305)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "chartControl1"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'richTextBox1
            '
            Me.richTextBox1.BackColor = System.Drawing.Color.White
            Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.richTextBox1.Location = New System.Drawing.Point(328, 355)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.ReadOnly = True
            Me.richTextBox1.Size = New System.Drawing.Size(348, 294)
            Me.richTextBox1.TabIndex = 1
            Me.richTextBox1.Text = ""
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BackColor = System.Drawing.Color.White
            Me.gradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer)))
            Me.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
            Me.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.gradientPanel1.Controls.Add(Me.label31)
            Me.gradientPanel1.Controls.Add(Me.numericUpDown6)
            Me.gradientPanel1.Controls.Add(Me.label6)
            Me.gradientPanel1.Controls.Add(Me.button1)
            Me.gradientPanel1.Controls.Add(Me.numericUpDown5)
            Me.gradientPanel1.Controls.Add(Me.numericUpDown4)
            Me.gradientPanel1.Controls.Add(Me.numericUpDown3)
            Me.gradientPanel1.Controls.Add(Me.numericUpDown2)
            Me.gradientPanel1.Controls.Add(Me.numericUpDown1)
            Me.gradientPanel1.Controls.Add(Me.label5)
            Me.gradientPanel1.Controls.Add(Me.label4)
            Me.gradientPanel1.Controls.Add(Me.label3)
            Me.gradientPanel1.Controls.Add(Me.label2)
            Me.gradientPanel1.Controls.Add(Me.label1)
            Me.gradientPanel1.Location = New System.Drawing.Point(8, 380)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(314, 277)
            Me.gradientPanel1.TabIndex = 2
            '
            'label31
            '
            Me.label31.BackColor = System.Drawing.Color.Transparent
            Me.label31.Image = CType(resources.GetObject("label31.Image"), System.Drawing.Image)
            Me.label31.Location = New System.Drawing.Point(162, 249)
            Me.label31.Name = "label31"
            Me.label31.Size = New System.Drawing.Size(20, 20)
            Me.label31.TabIndex = 41
            Me.toolTip1.SetToolTip(Me.label31, "Tests if the samples means difference is equal to Hyphotetized mean difference.")
            '
            'numericUpDown6
            '
            Me.numericUpDown6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.numericUpDown6.BackColor = System.Drawing.Color.White
            Me.numericUpDown6.Location = New System.Drawing.Point(163, 148)
            Me.numericUpDown6.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown6.Name = "numericUpDown6"
            Me.numericUpDown6.ReadOnly = True
            Me.numericUpDown6.Size = New System.Drawing.Size(56, 20)
            Me.numericUpDown6.TabIndex = 12
            Me.numericUpDown6.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'label6
            '
            Me.label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label6.AutoSize = True
            Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.label6.Location = New System.Drawing.Point(6, 148)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(99, 13)
            Me.label6.TabIndex = 11
            Me.label6.Text = "Sample 3 Deviation"
            '
            'button1
            '
            Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.button1.Location = New System.Drawing.Point(54, 240)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(102, 30)
            Me.button1.TabIndex = 10
            Me.button1.Text = "Perform T Test"
            '
            'numericUpDown5
            '
            Me.numericUpDown5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.numericUpDown5.BackColor = System.Drawing.Color.White
            Me.numericUpDown5.Location = New System.Drawing.Point(163, 121)
            Me.numericUpDown5.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown5.Name = "numericUpDown5"
            Me.numericUpDown5.ReadOnly = True
            Me.numericUpDown5.Size = New System.Drawing.Size(56, 20)
            Me.numericUpDown5.TabIndex = 9
            Me.numericUpDown5.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'numericUpDown4
            '
            Me.numericUpDown4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.numericUpDown4.BackColor = System.Drawing.Color.White
            Me.numericUpDown4.Location = New System.Drawing.Point(163, 94)
            Me.numericUpDown4.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown4.Name = "numericUpDown4"
            Me.numericUpDown4.ReadOnly = True
            Me.numericUpDown4.Size = New System.Drawing.Size(56, 20)
            Me.numericUpDown4.TabIndex = 8
            Me.numericUpDown4.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'numericUpDown3
            '
            Me.numericUpDown3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.numericUpDown3.BackColor = System.Drawing.Color.White
            Me.numericUpDown3.Location = New System.Drawing.Point(163, 67)
            Me.numericUpDown3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown3.Name = "numericUpDown3"
            Me.numericUpDown3.ReadOnly = True
            Me.numericUpDown3.Size = New System.Drawing.Size(56, 20)
            Me.numericUpDown3.TabIndex = 7
            Me.numericUpDown3.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'numericUpDown2
            '
            Me.numericUpDown2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.numericUpDown2.BackColor = System.Drawing.Color.White
            Me.numericUpDown2.Location = New System.Drawing.Point(163, 40)
            Me.numericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown2.Name = "numericUpDown2"
            Me.numericUpDown2.ReadOnly = True
            Me.numericUpDown2.Size = New System.Drawing.Size(56, 20)
            Me.numericUpDown2.TabIndex = 6
            Me.numericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'numericUpDown1
            '
            Me.numericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.numericUpDown1.BackColor = System.Drawing.Color.White
            Me.numericUpDown1.Location = New System.Drawing.Point(163, 13)
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.ReadOnly = True
            Me.numericUpDown1.Size = New System.Drawing.Size(56, 20)
            Me.numericUpDown1.TabIndex = 5
            '
            'label5
            '
            Me.label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label5.AutoSize = True
            Me.label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.label5.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label5.Location = New System.Drawing.Point(6, 121)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(150, 13)
            Me.label5.TabIndex = 4
            Me.label5.Text = "Hyphotetized mean Difference"
            '
            'label4
            '
            Me.label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label4.AutoSize = True
            Me.label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.label4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label4.Location = New System.Drawing.Point(6, 94)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(99, 13)
            Me.label4.TabIndex = 3
            Me.label4.Text = "Sample 2 Deviation"
            '
            'label3
            '
            Me.label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label3.AutoSize = True
            Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.label3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label3.Location = New System.Drawing.Point(6, 67)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(81, 13)
            Me.label3.TabIndex = 2
            Me.label3.Text = "Sample 2 Mean"
            '
            'label2
            '
            Me.label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label2.AutoSize = True
            Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label2.Location = New System.Drawing.Point(6, 40)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(99, 13)
            Me.label2.TabIndex = 1
            Me.label2.Text = "Sample 1 Deviation"
            '
            'label1
            '
            Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label1.Location = New System.Drawing.Point(6, 13)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(81, 13)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Sample 1 Mean"
            '
            'button2
            '
            Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.button2.Location = New System.Drawing.Point(54, 189)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(102, 30)
            Me.button2.TabIndex = 11
            Me.button2.Text = "Exchange Samples"
            Me.button2.UseVisualStyleBackColor = False
            '
            'comboBox1
            '
            Me.comboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox1.Location = New System.Drawing.Point(15, 355)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(168, 21)
            Me.comboBox1.TabIndex = 3
            '
            'checkBox1
            '
            Me.checkBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.checkBox1.AutoSize = True
            Me.checkBox1.BackColor = System.Drawing.Color.Transparent
            Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox1.Location = New System.Drawing.Point(449, 287)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(72, 18)
            Me.checkBox1.TabIndex = 4
            Me.checkBox1.Text = "3D View"
            Me.checkBox1.UseVisualStyleBackColor = False
            '
            'label7
            '
            Me.label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label7.Image = CType(resources.GetObject("label7.Image"), System.Drawing.Image)
            Me.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label7.Location = New System.Drawing.Point(4, 322)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(119, 24)
            Me.label7.TabIndex = 5
            Me.label7.Text = "Statistical Tests"
            Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label8
            '
            Me.label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label8.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label8.Image = CType(resources.GetObject("label8.Image"), System.Drawing.Image)
            Me.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label8.Location = New System.Drawing.Point(325, 322)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(91, 24)
            Me.label8.TabIndex = 6
            Me.label8.Text = "Test Result"
            Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(688, 663)
            Me.Controls.Add(Me.label8)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.gradientPanel1)
            Me.Controls.Add(Me.checkBox1)
            Me.Controls.Add(Me.comboBox1)
            Me.Controls.Add(Me.richTextBox1)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Essential Chart - Chart Statistical Formulas"
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            Me.gradientPanel1.PerformLayout()
            CType(Me.numericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
		#End Region

		#Region "Form1 Load"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Me.chartControl1.PrimaryXAxis.Title="Sample X values"
			Me.chartControl1.PrimaryYAxis.Title="Frequency of occurrence"

			sqrtVarianceOfFirstSeries = 10
			sqrtVarianceOfSecondSeries = 5
			meanOfFirstSeries = 15
			meanOfSecondSeries = 1
			sqrtVarianceOfThirdSeries = 7
			meanOfThirdSeries = 4

			FillControl()
			UpdateChart()
		End Sub
		#End Region

		#Region "Helper Methods"
		#Region "FillControl"
		''' <summary>
		''' Fills the combobox.
		''' </summary>
		Protected Sub FillControl()
			Me.comboBox1.Items.Add("Statistical Functions")
			Me.comboBox1.Items.Add("Perform Anova Test")
			Me.comboBox1.Items.Add("Perform F Test")
			Me.comboBox1.Items.Add("Perform T Test")
			Me.comboBox1.Items.Add("Perform Z Test")
			Me.comboBox1.SelectedIndex = 0
		End Sub
#End Region

		#Region "UpdateChart"
		''' <summary>
		''' Designs the side panel and updates the chartcontrol.
		''' </summary>
		Protected Sub UpdateChart()
			Me.SuspendLayout()

			If (Not Me.Contains(Me.gradientPanel1)) Then
				Me.Controls.Add(Me.gradientPanel1)
			End If
			If (Not Me.gradientPanel1.Contains(Me.label5)) Then
				Me.gradientPanel1.Controls.Add(Me.label5)
				Me.gradientPanel1.Controls.Add(Me.numericUpDown5)
				Me.gradientPanel1.Controls.Remove(Me.button2)
				Me.gradientPanel1.Controls.Remove(Me.label6)
				Me.gradientPanel1.Controls.Remove(Me.numericUpDown6)
			End If
			Me.richTextBox1.Clear()
			Select Case Me.comboBox1.SelectedIndex
				Case 0
					InitializeChartBasicStatisticalFunctions()
				Case 1
					InitializeAnovaChartData()
                    Dim color3 As Color() = New Color() {System.Drawing.Color.FromArgb(255, 153, 53), System.Drawing.Color.FromArgb(253, 205, 154), System.Drawing.Color.FromArgb(255, 153, 53)}
                    Me.chartControl1.Series(2).Style.Interior = New BrushInfo(System.Drawing.Color.FromArgb(200, 199, 23, 33))
                    Me.chartControl1.Series(2).Style.Border.Color = System.Drawing.Color.Gray

				Case 2
					InitializeFTestChartData()
				Case 3
					InitializeTTestChartData()
				Case 4
					InitializeZTestChartData()
				Case Else
					InitializeChartBasicStatisticalFunctions()
			End Select

            Me.ResumeLayout()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
		End Sub
#End Region

		#Region "InitializeChartData"
		''' <summary>
		''' Initializes chart data.
		''' </summary>
		''' <param name="numPoints"></param>
		''' <param name="hintervals"></param>
		Protected Sub InitializeChartData(ByVal numPoints As Integer, ByVal hintervals As Integer)
			'Clears the series collection of the chartcontrol.
			chartControl1.Series.Clear()

			'Initializes a new series with chart type as Histogram.
			series1 = New ChartSeries()
			series1.Name = "Sample 1"
			series1.Type = ChartSeriesType.Histogram
			series1.Text = series1.Name

			For j As Integer = 0 To numPoints - 1
				'making normally distributed sample with meanOfFirstSeries as Mean, and sqrtVarianceOfFirstSeries as Standard deviation
				Dim p As Double = 1.0/(numPoints*numPoints) + (CDbl(j))/(numPoints)
				Dim x As Double = meanOfFirstSeries + sqrtVarianceOfFirstSeries * UtilityFunctions.InverseNormalDistribution(p)

				'Adds the data point.
				series1.Points.Add(x, 0)
			Next j

			'Turns on the histogram normal distribution curve.
			series1.ConfigItems.HistogramItem.ShowNormalDistribution = True

			'Specifies the number of histogram intervals to be drawn.
			 series1.ConfigItems.HistogramItem.NumberOfIntervals = hintervals

			'Adds the series to the series collection of the chartcontrol.
			Me.chartControl1.Series.Add(series1)

			'Initializes a new series with chart type as Histogram.
			series2 = New ChartSeries()
			series2.Name = "Sample 2"
			series2.Type = ChartSeriesType.Histogram
			series2.Text = series2.Name

			For j As Integer = 0 To numPoints - 1
				'making normally distributed sample
				Dim p As Double = 1.0/(numPoints*numPoints) + (CDbl(j))/(numPoints)
				Dim x As Double = meanOfSecondSeries + sqrtVarianceOfSecondSeries * UtilityFunctions.InverseNormalDistribution(p)

				'Adds the data point.
				series2.Points.Add(x, 0)
			Next j

			'Turns on the histogram normal distribution curve.
			series2.ConfigItems.HistogramItem.ShowNormalDistribution = True

			'Specifies the number of histogram intervals to be drawn.
			series2.ConfigItems.HistogramItem.NumberOfIntervals = hintervals

			'Adds the series to the series collection of the chartcontrol.
			Me.chartControl1.Series.Add(series2)

			If Me.comboBox1.SelectedIndex = 1 Then
				'Initializes a new series with chart type as Histogram.
				series3 = New ChartSeries()
				series3.Name = "sample 3"
				series3.Type = ChartSeriesType.Histogram
				series3.Text = series3.Name

				For j As Integer = 0 To numPoints - 1
					'making normally distributed sample
					Dim p As Double = 1.0/(numPoints*numPoints) + (CDbl(j))/(numPoints)
					Dim x As Double = meanOfThirdSeries + sqrtVarianceOfThirdSeries * UtilityFunctions.InverseNormalDistribution(p)

					'Adds the data point.
					series3.Points.Add(x, 0)
				Next j

				'Turns on the histogram normal distribution curve.
				series3.ConfigItems.HistogramItem.ShowNormalDistribution = True

				'Specifies the number of histogram intervals to be drawn.
				series3.ConfigItems.HistogramItem.NumberOfIntervals = hintervals

				'Adds the series to the series collection of the chartcontrol.
				Me.chartControl1.Series.Add(series3)
			End If
		End Sub
		#End Region

		#Region "InitializeAnovaChartData"
		''' <summary>
		''' Performes Anova Test on Chart Data.
		''' </summary>
		Protected Sub InitializeAnovaChartData()
			If (Not Me.gradientPanel1.Contains(Me.label6)) Then
				Me.gradientPanel1.Controls.Add(Me.label6)
				Me.gradientPanel1.Controls.Add(Me.numericUpDown6)
				Me.gradientPanel1.Controls.Remove(Me.button2)
			End If

			InitializeChartData(10,50)

			Me.chartControl1.Text = "ANOVA Test Sample"
			Me.label5.Text = "Sample 3 Mean"
			Me.button1.Text = "Perform Anova Test"
			Me.toolTip1.SetToolTip(Me.label31, "Tests if the samples means are equal (The number of samples can be bigger than 2)")
		End Sub
#End Region

		#Region "InitializeFTestChartData"
		''' <summary>
		''' Performes F Test of chart data.
		''' </summary>
		Protected Sub InitializeFTestChartData()
			If (Not Me.gradientPanel1.Contains(Me.button2)) Then
				Me.gradientPanel1.Controls.Add(Me.button2)
				Me.gradientPanel1.Controls.Remove(Me.label5)
				Me.gradientPanel1.Controls.Remove(Me.numericUpDown5)
				Me.gradientPanel1.Controls.Remove(Me.label6)
				Me.gradientPanel1.Controls.Remove(Me.numericUpDown6)
			End If

			InitializeChartData(30,40)
			Me.numericUpDown5.Visible = False
			Me.chartControl1.Text="F Test Sample"
			Me.button1.Text = "Perform F Test"
			Me.toolTip1.SetToolTip(Me.label31, "Tests if the samples variances are equal")
		End Sub
		#End Region

		#Region "InitializeTTestChartData"
		''' <summary>
		''' Performes T Test on Chart data.
		''' </summary>
		Protected Sub InitializeTTestChartData()
			InitializeChartData(30,40)
			Me.numericUpDown5.Visible = True
			Me.chartControl1.Text="T Test Sample"
			Me.label5.Text = "Hyphotetized mean Difference"
			Me.button1.Text = "Perform T Test"
			Me.toolTip1.SetToolTip(Me.label31, "Tests if the samples means difference is equal to Hyphotetized mean difference")
		End Sub
		#End Region

		#Region "InitializeZTestChartData"
		''' <summary>
		''' Performes Z Test on Chart Data.
		''' </summary>
		Protected Sub InitializeZTestChartData()
			InitializeChartData(30,40)
			Me.numericUpDown5.Visible = True
			Me.chartControl1.Text="Z Test Sample"
			Me.label5.Text = "Hyphotetized mean Difference"
			Me.button1.Text = "Perform Z Test"
			Me.toolTip1.SetToolTip(Me.label31, "Tests if the samples means difference is equal to Hyphotetized mean difference")
		End Sub
		#End Region

		#Region "InitializeChartBasicStatisticalFunctions"
		''' <summary>
		''' Performes basic statistical calculations on Chart data.
		''' </summary>
		Protected Sub InitializeChartBasicStatisticalFunctions()
			If Me.Contains(Me.gradientPanel1) Then
				Me.Controls.Remove(Me.gradientPanel1)
			End If

			Me.chartControl1.Series.Clear()

			'Initializes a Column chart.
			series1 = New ChartSeries()
			series1.Name = "Sample 1"
			series1.Type = ChartSeriesType.Column
			series1.Text = series1.Name

			'Adds the datapoints to the series.
			series1.Points.Add(1,345)
			series1.Points.Add(2,256)
			series1.Points.Add(3,491)
			series1.Points.Add(4,382)
			series1.Points.Add(5,437)
			series1.Points.Add(6,321)
			series1.Points.Add(7,412)
			series1.Points.Add(8,451)
			series1.Points.Add(9,490)
			series1.Points.Add(10,366)

			'Adds the series to the series collection of the chartcontrol.
			Me.chartControl1.Series.Add(series1)

			'Initializes a Column chart.
			series2 = New ChartSeries()
			series2.Name = "Sample 2"
			series2.Type = ChartSeriesType.Column
			series2.Text = series2.Name

			'Adds the datapoints to the series.
			series2.Points.Add(1,245)
			series2.Points.Add(2,156)
			series2.Points.Add(3,391)
			series2.Points.Add(4,282)
			series2.Points.Add(5,337)
			series2.Points.Add(6,221)
			series2.Points.Add(7,312)
			series2.Points.Add(8,351)
			series2.Points.Add(9,390)
			series2.Points.Add(10,266)

			'Adds the series to the series collection of the chartcontrol.
			Me.chartControl1.Series.Add(series2)

			Me.chartControl1.PrimaryXAxis.Title = "X Values"
			Me.chartControl1.PrimaryYAxis.Title = "Y Values"
			Me.chartControl1.Text = "Basic Statistical Functions"
			CalculateValues(series1)
		End Sub
		#End Region

		#Region "CalculateValues"
		'Calculates and displays the statistical values.
		Protected Sub CalculateValues(ByVal series As ChartSeries)
			Dim val As String = ""

			val &= "Mean = " & BasicStatisticalFormulas.Mean(series).ToString() & Constants.vbCrLf
			val &= "Median = " & BasicStatisticalFormulas.Median(series).ToString() & Constants.vbCrLf
            val &= "Standard Deviation = " & BasicStatisticalFormulas.StandardDeviation(series, True).ToString() & Constants.vbCrLf
			val &= "Variance = " & BasicStatisticalFormulas.Variance(series, True).ToString() & Constants.vbCrLf
			val &= "Variance Based Estimator = " & BasicStatisticalFormulas.VarianceBiasedEstimator(series).ToString() & Constants.vbCrLf
			val &= "Variance UnBased Estimator = " & BasicStatisticalFormulas.VarianceUnbiasedEstimator(series).ToString() & Constants.vbCrLf
			val &= "Correlation Co-efficient = " & BasicStatisticalFormulas.Correlation(Me.chartControl1.Series(0), Me.chartControl1.Series(1)).ToString() & Constants.vbCrLf
			val &= "Covariance = " & BasicStatisticalFormulas.Covariance(Me.chartControl1.Series(0), Me.chartControl1.Series(1)).ToString() & Constants.vbCrLf

			Me.richTextBox1.Text = val
		End Sub
		#End Region
		#End Region

		#Region "Events"
		Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
			meanOfFirstSeries = CDbl(numericUpDown1.Value)
			UpdateChart()
		End Sub

		Private Sub numericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown2.ValueChanged
			meanOfSecondSeries = CDbl(numericUpDown2.Value)
			UpdateChart()
		End Sub

		Private Sub numericUpDown3_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown3.ValueChanged
			sqrtVarianceOfFirstSeries = CDbl(numericUpDown3.Value)
			UpdateChart()
		End Sub

		Private Sub numericUpDown4_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown4.ValueChanged
			sqrtVarianceOfSecondSeries = CDbl(numericUpDown4.Value)
			UpdateChart()
		End Sub

		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
			UpdateChart()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			richTextBox1.Text = ""
			Dim confidenceLevel As Double = 0.05
			Dim s As String =""

			If Me.comboBox1.SelectedIndex = 4 Then
				'Thus, lets perform the ZTest to test whether the difference is really guessed correctly.
				Dim ztr As ZTestResult = BasicStatisticalFormulas.ZTest(CDbl(numericUpDown5.Value), sqrtVarianceOfFirstSeries*sqrtVarianceOfFirstSeries, sqrtVarianceOfSecondSeries*sqrtVarianceOfSecondSeries, 0.05, series1, series2)

				s &= "ZValue = " & ztr.ZValue.ToString() & Constants.vbLf
				s &= "ZCriticalValueOneTail = " & ztr.ZCriticalValueOneTail.ToString() & Constants.vbLf
				s &= "ZCriticalValueTwoTail = " & ztr.ZCriticalValueTwoTail.ToString() & Constants.vbLf
				s &= "ProbabilityZOneTail = " & ztr.ProbabilityZOneTail.ToString() & Constants.vbLf
				s &= "ProbabilityZTwoTail = " & ztr.ProbabilityZTwoTail.ToString() & Constants.vbLf
				s &= "FirstSeriesMean = " & ztr.FirstSeriesMean.ToString() & Constants.vbLf
				s &= "FirstSeriesVariance = " & ztr.FirstSeriesVariance.ToString() & Constants.vbLf
				s &= "SecondSeriesMean = " & ztr.SecondSeriesMean.ToString() & Constants.vbLf
				s &= "SecondSeriesVariance = " & ztr.SecondSeriesVariance.ToString() & Constants.vbLf
				s &= Constants.vbLf

				If Math.Abs(ztr.ZValue) < ztr.ZCriticalValueTwoTail Then
					s &= "Z Test fails to prove that hyphotetized mean is wrong." & Constants.vbLf
					s &= Constants.vbLf
					s &= "Because ZValue is closer to zero than ZCriticalValueTwoTail, we can't deduce that hypothetized mean difference is wrong. "
					s &= " Thus, there is probability that they are close to each other."
					s &= " This don't automatically proves that our sample means are equal, but rather indicates that we don't have enough data to prove that means are different or close enough. "
				Else
					s &= "Z Test succeeds to prove that hyphotetized mean is wrong with probability " & ((1.0 - 0.05).ToString()) & "." & Constants.vbLf
					s &= Constants.vbLf
					s &= "Because ZValue is farther from zero than ZCriticalValueTwoTail, we can deduce that hypothetized mean difference is wrong. "
				End If
			ElseIf Me.comboBox1.SelectedIndex = 3 Then
				'Thus, lets perform the TTest to test whether the difference is really guessed correctly.
				Dim ttr As TTestResult = BasicStatisticalFormulas.TTestUnEqualVariances(CDbl(numericUpDown5.Value), 0.05, series1, series2)

				s &= "TValue = " & ttr.TValue.ToString() & Constants.vbLf
				s &= "TCriticalValueOneTail = " & ttr.TCriticalValueOneTail.ToString() & Constants.vbLf
				s &= "TCriticalValueTwoTail = " & ttr.TCriticalValueTwoTail.ToString() & Constants.vbLf
				s &= "ProbabilityTOneTail = " & ttr.ProbabilityTOneTail.ToString() & Constants.vbLf
				s &= "ProbabilityTTwoTail = " & ttr.ProbabilityTTwoTail.ToString() & Constants.vbLf
				s &= "FirstSeriesMean = " & ttr.FirstSeriesMean.ToString() & Constants.vbLf
				s &= "FirstSeriesVariance = " & ttr.FirstSeriesVariance.ToString() & Constants.vbLf
				s &= "SecondSeriesMean = " & ttr.SecondSeriesMean.ToString() & Constants.vbLf
				s &= "SecondSeriesVariance = " & ttr.SecondSeriesVariance.ToString() & Constants.vbLf
				s &= Constants.vbLf

				If Math.Abs(ttr.TValue) < ttr.TCriticalValueTwoTail Then
					s &= "T Test fails to prove that hyphotetized mean is wrong." & Constants.vbLf
					s &= Constants.vbLf
					s &= "Because TValue is closer to zero than TCriticalValueTwoTail, we can't deduce that hypothetized mean difference is wrong. "
					s &= " Thus, there is probability that they are close to each other."
					s &= " This don't automatically proves that our sample means are equal, but rather indicates that we don't have enough data to prove that means are different or close enough. "
				Else
					s &= "T Test succeeds to prove that hyphotetized mean is wrong with probability " & ((1.0 - 0.05).ToString()) & "." & Constants.vbLf
					s &= Constants.vbLf
					s &= "Because TValue is farther from zero than TCriticalValueTwoTail, we can deduce that hypothetized mean difference is wrong. "
				End If

			ElseIf Me.comboBox1.SelectedIndex = 2 Then
				'Thus, lets perform the FTest to test whether the difference is really guessed correctly.
				Dim ttr As FTestResult = BasicStatisticalFormulas.FTest(confidenceLevel, series1, series2)

				s &= "FValue = " & ttr.FValue.ToString() & Constants.vbLf
				s &= "FCriticalValueOneTail = " & ttr.FCriticalValueOneTail.ToString() & Constants.vbLf
				s &= "ProbabilityFOneTail = " & ttr.ProbabilityFOneTail.ToString() & Constants.vbLf
				s &= "FirstSeriesMean = " & ttr.FirstSeriesMean.ToString() & Constants.vbLf
				s &= "FirstSeriesVariance = " & ttr.FirstSeriesVariance.ToString() & Constants.vbLf
				s &= "SecondSeriesMean = " & ttr.SecondSeriesMean.ToString() & Constants.vbLf
				s &= "SecondSeriesVariance = " & ttr.SecondSeriesVariance.ToString() & Constants.vbLf
				s &= Constants.vbLf

				If ttr.FValue <= 1.0 Then
					If Math.Abs(ttr.FValue - 1.0) < Math.Abs(ttr.FCriticalValueOneTail - 1.0) Then
						s &= "F Test fails to prove that first variance is smaller than second." & Constants.vbLf
						s &= Constants.vbLf
						s &= "Because FValue is closer to unity than FCriticalValueOneTail, we can't be sure enough that first sample variance is smaller than second. "
					Else
						s &= "F Test succeeds to prove (with probability " & (1.0-confidenceLevel).ToString() & ") that first sample variance is smaller than second." & Constants.vbLf
						s &= Constants.vbLf
						s &= "Because FValue is farther from unity than FCriticalValueOneTail, we can deduce that first sample variance is smaller than second." & Constants.vbLf
					End If
				Else
					s &= "FValue is bigger than 1.0. So it is possible that first sample variance is bigger than second. " & Constants.vbLf
					s &= "Exchange the sample order and test if the second sample variance is smaller than first sample variance." & Constants.vbLf
					s &= Constants.vbLf
				End If

			ElseIf Me.comboBox1.SelectedIndex = 1 Then
				'Thus, lets perform the Anova Test to test whether the difference is really guessed correctly.
				Dim ar As AnovaResult = BasicStatisticalFormulas.Anova(confidenceLevel, New ChartSeries(){ series1, series2, series3})

				s &= "FRatio = " & ar.FRatio.ToString() & Constants.vbLf
				s &= "FCriticalValue = " & ar.FCriticalValue.ToString() & Constants.vbLf
				s &= "DegreeOfFreedomBetweenGroups = " & ar.DegreeOfFreedomBetweenGroups.ToString() & Constants.vbLf
				s &= "DegreeOfFreedomWithinGroups = " & ar.DegreeOfFreedomWithinGroups.ToString() & Constants.vbLf
				s &= "DegreeOfFreedomTotal = " & ar.DegreeOfFreedomTotal.ToString() & Constants.vbLf
				s &= "MeanSquareVarianceBetweenGroups = " & ar.MeanSquareVarianceBetweenGroups.ToString() & Constants.vbLf
				s &= "MeanSquareVarianceWithinGroups = " & ar.MeanSquareVarianceWithinGroups.ToString() & Constants.vbLf
				s &= "SumOfSquaresBetweenGroups = " & ar.SumOfSquaresBetweenGroups.ToString() & Constants.vbLf
				s &= "SumOfSquaresWithinGroups = " & ar.SumOfSquaresWithinGroups.ToString() & Constants.vbLf
				s &= "SumOfSquaresTotal = " & ar.SumOfSquaresTotal.ToString() & Constants.vbLf
				s &= Constants.vbLf

				If ar.FRatio < ar.FCriticalValue Then
					s &= "Anova test fails to prove that there is inequality between sample means." & Constants.vbLf
					s &= Constants.vbLf
					s &= "Because FRatio is smaller than FCriticalValue, we can't be sure enough that means are unequal. "
				Else
					s &= "Anova succeeds to prove (with probability " & (1.0-confidenceLevel).ToString() & ") that first there is inequality between sample means." & Constants.vbLf
					s &= Constants.vbLf
					s &= "Because FRatio is bigger than FCriticalValue, we can deduce that there is at least one inequality between means." & Constants.vbLf
				End If
			End If
			richTextBox1.Text = s
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click

			Dim tvar As Double = sqrtVarianceOfSecondSeries
			Dim tmean As Double = meanOfSecondSeries

			sqrtVarianceOfSecondSeries = sqrtVarianceOfFirstSeries
			meanOfSecondSeries = meanOfFirstSeries

			sqrtVarianceOfFirstSeries = tvar
			meanOfFirstSeries = tmean

			InitializeFTestChartData()
			RefreshNumerciUpDowns()
		End Sub

		''' <summary>
		''' Refreshes numeric up down controls for F Test on chart data.
		''' </summary>
		Private Sub RefreshNumerciUpDowns()
			numericUpDown1.Value = CInt(Fix(meanOfFirstSeries))
			numericUpDown2.Value = CInt(Fix(meanOfSecondSeries))
			numericUpDown3.Value = CInt(Fix(sqrtVarianceOfFirstSeries))
			numericUpDown4.Value = CInt(Fix(sqrtVarianceOfSecondSeries))
		End Sub

		Private Sub numericUpDown6_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown6.ValueChanged
			meanOfThirdSeries = CDbl(numericUpDown6.Value)
			UpdateChart()
		End Sub

		Private Sub numericUpDown5_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown5.ValueChanged
			sqrtVarianceOfThirdSeries = CDbl(numericUpDown5.Value)
			UpdateChart()
		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
			Me.chartControl1.Series3D = Me.checkBox1.Checked
		End Sub
		#End Region
	End Class
End Namespace