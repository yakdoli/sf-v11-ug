Imports Microsoft.VisualBasic
Imports System
Namespace AxesLabelPosition_2008
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.label6 = New System.Windows.Forms.Label()
			Me.label40 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.button1 = New System.Windows.Forms.Button()
			CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			Me.chartControl1.ChartArea.CursorLocation = New System.Drawing.Point(0, 0)
			Me.chartControl1.ChartArea.CursorReDraw = False
			Me.chartControl1.ForeColor = System.Drawing.Color.Black
			Me.chartControl1.IsWindowLess = False
			' 
			' 
			' 
			Me.chartControl1.Legend.Location = New System.Drawing.Point(490, 75)
			Me.chartControl1.Localize = Nothing
			Me.chartControl1.Location = New System.Drawing.Point(5, 2)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.PrimaryXAxis.Crossing = Double.NaN
			Me.chartControl1.PrimaryXAxis.Margin = True
			Me.chartControl1.PrimaryYAxis.Crossing = Double.NaN
			Me.chartControl1.PrimaryYAxis.Margin = True
			Me.chartControl1.Size = New System.Drawing.Size(599, 418)
			Me.chartControl1.TabIndex = 9
			Me.chartControl1.Text = "chartControl1"
			' 
			' 
			' 
			Me.chartControl1.Title.Name = "Default"
			Me.chartControl1.Titles.Add(Me.chartControl1.Title)
'			Me.chartControl1.ChartFormatAxisLabel += New Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(Me.chartControl1_ChartFormatAxisLabel)
			' 
			' checkBox1
			' 
			Me.checkBox1.AutoSize = True
			Me.checkBox1.Checked = True
			Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox1.Location = New System.Drawing.Point(12, 426)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(196, 17)
			Me.checkBox1.TabIndex = 11
			Me.checkBox1.Text = "ChartFormatAxisLabel Customization"
			Me.checkBox1.UseVisualStyleBackColor = True
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged)
			' 
			' label6
			' 
			Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label6.Image = (CType(resources.GetObject("label6.Image"), System.Drawing.Image))
			Me.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label6.Location = New System.Drawing.Point(2, 455)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(646, 48)
			Me.label6.TabIndex = 12
			Me.label6.Text = "               Sample Description"
			Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' label40
			' 
			Me.label40.BackColor = System.Drawing.Color.Transparent
			Me.label40.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label40.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
			Me.label40.Location = New System.Drawing.Point(2, 503)
			Me.label40.Name = "label40"
			Me.label40.Size = New System.Drawing.Size(788, 42)
			Me.label40.TabIndex = 13
			Me.label40.Text = resources.GetString("label40.Text")
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(610, 173)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(180, 13)
			Me.label2.TabIndex = 23
			Me.label2.Text = "Set Export Value for Selected Nation"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(607, 120)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(71, 13)
			Me.label1.TabIndex = 22
			Me.label1.Text = "Select Nation"
			' 
			' numericUpDown1
			' 
			Me.numericUpDown1.Location = New System.Drawing.Point(613, 189)
			Me.numericUpDown1.Maximum = New Decimal(New Integer() { 140, 0, 0, 0})
			Me.numericUpDown1.Minimum = New Decimal(New Integer() { 140, 0, 0, -2147483648})
			Me.numericUpDown1.Name = "numericUpDown1"
			Me.numericUpDown1.Size = New System.Drawing.Size(85, 20)
			Me.numericUpDown1.TabIndex = 21
			' 
			' comboBox1
			' 
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Items.AddRange(New Object() { "Canada", "France", "Italy", "Japan", "Britain", "United States"})
			Me.comboBox1.Location = New System.Drawing.Point(610, 136)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(121, 21)
			Me.comboBox1.TabIndex = 20
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(649, 231)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75, 23)
			Me.button1.TabIndex = 19
			Me.button1.Text = "Refresh"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' Form1
			' 
			Me.BackColor = System.Drawing.Color.White
			Me.ClientSize = New System.Drawing.Size(787, 537)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.numericUpDown1)
			Me.Controls.Add(Me.comboBox1)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.label40)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.checkBox1)
			Me.Controls.Add(Me.chartControl1)
			Me.ForeColor = System.Drawing.Color.Maroon
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Axes Label Position"
'			Me.Load += New System.EventHandler(Me.Form1_Load_1)
			CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private label6 As System.Windows.Forms.Label
		Private label40 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private numericUpDown1 As System.Windows.Forms.NumericUpDown
		Private comboBox1 As System.Windows.Forms.ComboBox
		Private WithEvents button1 As System.Windows.Forms.Button

	End Class
End Namespace

