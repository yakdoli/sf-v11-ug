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
Imports Syncfusion.Windows.Forms


Namespace ColumnChart2005

    Public Class Form1
        Inherits Office2007Form
#Region "Private Members"
        Private panel1 As System.Windows.Forms.Panel
        Private WithEvents comboBoxChartType As System.Windows.Forms.ComboBox
        Private label1 As System.Windows.Forms.Label
        Private WithEvents udSpacing As System.Windows.Forms.NumericUpDown
        Private WithEvents rbRelativeMode As System.Windows.Forms.RadioButton
        Private WithEvents rbFixedMode As System.Windows.Forms.RadioButton
        Private WithEvents rbDefaultMode As System.Windows.Forms.RadioButton
        Private label4 As Label
        Private label3 As Label
        Private label5 As Label
        Private label2 As Label
        Private groupBox2 As GroupBox
        Private label8 As Label
        Private label7 As Label
        Private WithEvents ColTypeCombo As ComboBox
        Private WithEvents checkBox1 As CheckBox
        Private chartControl1 As ChartControl
        Private components As System.ComponentModel.Container = Nothing
        Private color1 As Color() = New Color() {Color.FromArgb(136, 197, 242), Color.FromArgb(139, 202, 245), Color.FromArgb(115, 161, 194)}
        Private color2 As Color() = New Color() {Color.FromArgb(241, 153, 103), Color.FromArgb(242, 154, 104), Color.FromArgb(206, 133, 90)}
        Private WithEvents CheckBox2 As System.Windows.Forms.CheckBox

        Private label10 As Label


#End Region

#Region "Form's Constructor"
        Public Sub New()
            InitializeComponent()
        End Sub
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New Form1())
        End Sub
#End Region

#Region "Dispose"
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
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.panel1 = New System.Windows.Forms.Panel
            Me.label10 = New System.Windows.Forms.Label
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.ColTypeCombo = New System.Windows.Forms.ComboBox
            Me.label8 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.rbDefaultMode = New System.Windows.Forms.RadioButton
            Me.rbFixedMode = New System.Windows.Forms.RadioButton
            Me.rbRelativeMode = New System.Windows.Forms.RadioButton
            Me.label2 = New System.Windows.Forms.Label
            Me.udSpacing = New System.Windows.Forms.NumericUpDown
            Me.comboBoxChartType = New System.Windows.Forms.ComboBox
            Me.label1 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.CheckBox2 = New System.Windows.Forms.CheckBox()
            Me.panel1.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            CType(Me.udSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.CheckBox2)
            Me.panel1.Controls.Add(Me.label10)
            Me.panel1.Controls.Add(Me.checkBox1)
            Me.panel1.Controls.Add(Me.ColTypeCombo)
            Me.panel1.Controls.Add(Me.label8)
            Me.panel1.Controls.Add(Me.label7)
            Me.panel1.Controls.Add(Me.groupBox2)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.udSpacing)
            Me.panel1.Controls.Add(Me.comboBoxChartType)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(427, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(152, 390)
            Me.panel1.TabIndex = 4
            '
            'label10
            '
            Me.label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label10.Location = New System.Drawing.Point(11, 39)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(130, 1)
            Me.label10.TabIndex = 16
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox1.Location = New System.Drawing.Point(13, 332)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(68, 18)
            Me.checkBox1.TabIndex = 15
            Me.checkBox1.Text = "3D View"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'ColTypeCombo
            '
            Me.ColTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ColTypeCombo.Enabled = False
            Me.ColTypeCombo.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.ColTypeCombo.FormattingEnabled = True
            Me.ColTypeCombo.Location = New System.Drawing.Point(11, 298)
            Me.ColTypeCombo.Name = "ColTypeCombo"
            Me.ColTypeCombo.Size = New System.Drawing.Size(121, 21)
            Me.ColTypeCombo.TabIndex = 14
            '
            'label8
            '
            Me.label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.label8.Location = New System.Drawing.Point(11, 287)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(130, 1)
            Me.label8.TabIndex = 13
            Me.label8.Text = "label8"
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label7.Location = New System.Drawing.Point(11, 273)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(80, 14)
            Me.label7.TabIndex = 12
            Me.label7.Text = "Column Type"
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.rbDefaultMode)
            Me.groupBox2.Controls.Add(Me.rbFixedMode)
            Me.groupBox2.Controls.Add(Me.rbRelativeMode)
            Me.groupBox2.Location = New System.Drawing.Point(11, 108)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(93, 96)
            Me.groupBox2.TabIndex = 11
            Me.groupBox2.TabStop = False
            '
            'rbDefaultMode
            '
            Me.rbDefaultMode.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rbDefaultMode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbDefaultMode.Location = New System.Drawing.Point(6, 19)
            Me.rbDefaultMode.Name = "rbDefaultMode"
            Me.rbDefaultMode.Size = New System.Drawing.Size(72, 16)
            Me.rbDefaultMode.TabIndex = 0
            Me.rbDefaultMode.Text = "Default"
            '
            'rbFixedMode
            '
            Me.rbFixedMode.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rbFixedMode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbFixedMode.Location = New System.Drawing.Point(6, 46)
            Me.rbFixedMode.Name = "rbFixedMode"
            Me.rbFixedMode.Size = New System.Drawing.Size(72, 16)
            Me.rbFixedMode.TabIndex = 1
            Me.rbFixedMode.Text = "Fixed"
            '
            'rbRelativeMode
            '
            Me.rbRelativeMode.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rbRelativeMode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbRelativeMode.Location = New System.Drawing.Point(6, 72)
            Me.rbRelativeMode.Name = "rbRelativeMode"
            Me.rbRelativeMode.Size = New System.Drawing.Size(72, 16)
            Me.rbRelativeMode.TabIndex = 2
            Me.rbRelativeMode.Text = "Relative"
            '
            'label2
            '
            Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label2.Location = New System.Drawing.Point(11, 107)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(130, 1)
            Me.label2.TabIndex = 8
            '
            'udSpacing
            '
            Me.udSpacing.Increment = New Decimal(New Integer() {10, 0, 0, 0})
            Me.udSpacing.Location = New System.Drawing.Point(11, 236)
            Me.udSpacing.Name = "udSpacing"
            Me.udSpacing.ReadOnly = True
            Me.udSpacing.Size = New System.Drawing.Size(88, 20)
            Me.udSpacing.TabIndex = 0
            '
            'comboBoxChartType
            '
            Me.comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxChartType.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBoxChartType.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBoxChartType.Location = New System.Drawing.Point(11, 51)
            Me.comboBoxChartType.Name = "comboBoxChartType"
            Me.comboBoxChartType.Size = New System.Drawing.Size(112, 21)
            Me.comboBoxChartType.TabIndex = 4
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Location = New System.Drawing.Point(11, 21)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(96, 16)
            Me.label1.TabIndex = 3
            Me.label1.Text = "ChartType"
            '
            'label4
            '
            Me.label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label4.Location = New System.Drawing.Point(11, 226)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(130, 1)
            Me.label4.TabIndex = 7
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.BackColor = System.Drawing.Color.Transparent
            Me.label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label3.Location = New System.Drawing.Point(11, 90)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(72, 14)
            Me.label3.TabIndex = 4
            Me.label3.Text = "Width Mode"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.BackColor = System.Drawing.Color.Transparent
            Me.label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label5.Location = New System.Drawing.Point(11, 211)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(50, 14)
            Me.label5.TabIndex = 6
            Me.label5.Text = "Spacing"
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(193, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(6, 6, 15, 6)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ElementsSpacing = 0
            Me.chartControl1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            '
            '
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent
            Me.chartControl1.Legend.Location = New System.Drawing.Point(317, 41)
            Me.chartControl1.Location = New System.Drawing.Point(12, 11)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Pastel
            Me.chartControl1.Size = New System.Drawing.Size(411, 362)
            Me.chartControl1.TabIndex = 5
            Me.chartControl1.Text = "Essential Chart"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Essential Chart"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'CheckBox2
            '
            Me.CheckBox2.AutoSize = True
            Me.CheckBox2.Enabled = False
            Me.CheckBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckBox2.Location = New System.Drawing.Point(13, 360)
            Me.CheckBox2.Name = "CheckBox2"
            Me.CheckBox2.Size = New System.Drawing.Size(66, 18)
            Me.CheckBox2.TabIndex = 17
            Me.CheckBox2.Text = "3D Style"
            Me.CheckBox2.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(579, 390)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Column Charts"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.groupBox2.ResumeLayout(False)
            CType(Me.udSpacing, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.comboBoxChartType.Items.Add(ChartSeriesType.Column)
            Me.comboBoxChartType.Items.Add(ChartSeriesType.ColumnRange)
            Me.comboBoxChartType.Items.Add(ChartSeriesType.StackingColumn)
            Me.comboBoxChartType.SelectedIndex = 0
            Me.udSpacing.Value = CDec(Me.chartControl1.Spacing)
            InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)

            For Each columnType As String In System.Enum.GetNames(GetType(ChartColumnType))
                Me.ColTypeCombo.Items.Add(columnType)

            Next columnType
            Me.rbDefaultMode.Checked = True
            Me.ColTypeCombo.SelectedIndex = 0
            Me.chartControl1.Series(0).ConfigItems.ColumnItem.ColumnType = CType(System.Enum.Parse(GetType(ChartColumnType), Me.ColTypeCombo.SelectedItem.ToString()), ChartColumnType)
            Me.chartControl1.Series(1).ConfigItems.ColumnItem.ColumnType = CType(System.Enum.Parse(GetType(ChartColumnType), Me.ColTypeCombo.SelectedItem.ToString()), ChartColumnType)
            Me.chartControl1.Series(2).ConfigItems.ColumnItem.ColumnType = CType(System.Enum.Parse(GetType(ChartColumnType), Me.ColTypeCombo.SelectedItem.ToString()), ChartColumnType)

        End Sub
#End Region

#Region "Helper Methods"

#Region "InitializeChartData"

        Protected Sub InitializeChartData()

            Dim numPoints As Integer = 4
            Me.chartControl1.Series.Clear()

            Dim series As ChartSeries = New ChartSeries("Team 1")
            For j As Integer = 1 To numPoints - 1
                If rbDefaultMode.Checked Then
                    series.Points.Add(j + 1, New Double() {j * 12 + 12})
                ElseIf rbFixedMode.Checked Then
                    series.Points.Add(j + 1, New Double() {j * 12 + 12, 12})
                ElseIf rbRelativeMode.Checked Then
                    series.Points.Add(j + 1, New Double() {j * 12 + 12, 0.75})
                End If
            Next j
            series.Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBoxChartType.SelectedItem.ToString(), True), ChartSeriesType)
            series.Text = series.Name
            Me.chartControl1.Series.Add(series)

            series = New ChartSeries("Team 2")
            For k As Integer = 1 To numPoints - 1
                If rbDefaultMode.Checked Then
                    series.Points.Add(k + 1, New Double() {k * 14 + 14})
                ElseIf rbFixedMode.Checked Then
                    series.Points.Add(k + 1, New Double() {k * 14 + 14, 14})
                ElseIf rbRelativeMode.Checked Then
                    series.Points.Add(k + 1, New Double() {k * 14 + 14, 0.75})
                End If
            Next k
            series.Text = series.Name
            series.Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBoxChartType.SelectedItem.ToString(), True), ChartSeriesType)
            Me.chartControl1.Series.Add(series)

            series = New ChartSeries("Team 3")
            For k As Integer = 1 To numPoints - 1
                If rbDefaultMode.Checked Then
                    series.Points.Add(k + 1, New Double() {k * 16 + 16})
                ElseIf rbFixedMode.Checked Then
                    series.Points.Add(k + 1, New Double() {k * 16 + 16, 16})
                ElseIf rbRelativeMode.Checked Then
                    series.Points.Add(k + 1, New Double() {k * 16 + 16, 0.75})
                End If
            Next k
            series.Text = series.Name
            series.Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBoxChartType.SelectedItem.ToString(), True), ChartSeriesType)
            Me.chartControl1.Series.Add(series)

            Me.chartControl1.Series(0).Style.Border.Color = Color.Transparent
            Me.chartControl1.Series(1).Style.Border.Color = Color.Transparent
            Me.chartControl1.Series(2).Style.Border.Color = Color.Transparent

        End Sub
#End Region


        Private Sub comboBoxChartType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxChartType.SelectedIndexChanged
            If Me.comboBoxChartType.SelectedIndex = 1 Then
                Me.rbDefaultMode.Enabled = False
                Me.rbRelativeMode.Enabled = False
                Me.rbFixedMode.Checked = True
            Else
                Me.rbDefaultMode.Enabled = True
                Me.rbDefaultMode.Checked = True
            End If
            If Me.comboBoxChartType.SelectedIndex = 2 Then
                Me.rbFixedMode.Enabled = False
                Me.rbDefaultMode.Checked = True
                Me.CheckBox2.Enabled = False
            Else
                If (Me.checkBox1.Checked) Then Me.CheckBox2.Enabled = True
                Me.rbFixedMode.Enabled = True
                Me.rbRelativeMode.Enabled = True
            End If
            For i As Integer = 0 To Me.chartControl1.Series.Count - 1
                Me.chartControl1.Series(i).Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBoxChartType.SelectedItem.ToString(), True), ChartSeriesType)
            Next i
            SetColumnType()
        End Sub
        Private Sub SetColumnType()
            If checkBox1.Checked Then
                Me.chartControl1.Series(0).ConfigItems.ColumnItem.ColumnType = CType(System.Enum.Parse(GetType(ChartColumnType), Me.ColTypeCombo.SelectedItem.ToString()), ChartColumnType)
                Me.chartControl1.Series(1).ConfigItems.ColumnItem.ColumnType = CType(System.Enum.Parse(GetType(ChartColumnType), Me.ColTypeCombo.SelectedItem.ToString()), ChartColumnType)
                Me.chartControl1.Series(2).ConfigItems.ColumnItem.ColumnType = CType(System.Enum.Parse(GetType(ChartColumnType), Me.ColTypeCombo.SelectedItem.ToString()), ChartColumnType)
            End If
        End Sub
        Private Sub radioButtonWidthMode_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbDefaultMode.CheckedChanged, rbFixedMode.CheckedChanged, rbRelativeMode.CheckedChanged
            InitializeChartData()
            Dim rbtn As RadioButton = TryCast(sender, RadioButton)
            If rbtn Is Me.rbDefaultMode Then ' default
                Me.chartControl1.ColumnWidthMode = ChartColumnWidthMode.DefaultWidthMode
            ElseIf rbtn Is Me.rbFixedMode Then ' fixed
                ' YValues[1] set as 12 for each series point in InitializeChartData
                Me.chartControl1.ColumnWidthMode = ChartColumnWidthMode.FixedWidthMode

            ElseIf rbtn Is Me.rbRelativeMode Then ' relative
                ' YValues[1] set as 0.75 for each series point in InitializeChartData
                Me.chartControl1.ColumnWidthMode = ChartColumnWidthMode.RelativeWidthMode

            End If

            If rbtn Is Me.rbFixedMode OrElse rbtn Is Me.rbRelativeMode Then
                Me.udSpacing.Enabled = False
            Else
                Me.udSpacing.Enabled = True
            End If
			SetColumnType()
        End Sub

        Private Sub radioButtonMultipleY_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)

            Me.chartControl1.Series(0).ConfigItems.ColumnItem.ColumnType = CType(System.Enum.Parse(GetType(ChartColumnType), Me.ColTypeCombo.SelectedItem.ToString()), ChartColumnType)
            Me.chartControl1.Series(1).ConfigItems.ColumnItem.ColumnType = CType(System.Enum.Parse(GetType(ChartColumnType), Me.ColTypeCombo.SelectedItem.ToString()), ChartColumnType)
            Me.chartControl1.Series(2).ConfigItems.ColumnItem.ColumnType = CType(System.Enum.Parse(GetType(ChartColumnType), Me.ColTypeCombo.SelectedItem.ToString()), ChartColumnType)
        End Sub

        Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles udSpacing.ValueChanged
            Me.chartControl1.Spacing = CSng(Me.udSpacing.Value)
        End Sub

        Private Sub ColTypeCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ColTypeCombo.SelectedIndexChanged
            Me.chartControl1.Series(0).ConfigItems.ColumnItem.ColumnType = CType(System.Enum.Parse(GetType(ChartColumnType), Me.ColTypeCombo.SelectedItem.ToString()), ChartColumnType)
            Me.chartControl1.Series(1).ConfigItems.ColumnItem.ColumnType = CType(System.Enum.Parse(GetType(ChartColumnType), Me.ColTypeCombo.SelectedItem.ToString()), ChartColumnType)
            Me.chartControl1.Series(2).ConfigItems.ColumnItem.ColumnType = CType(System.Enum.Parse(GetType(ChartColumnType), Me.ColTypeCombo.SelectedItem.ToString()), ChartColumnType)
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            Me.chartControl1.Series3D = Me.checkBox1.Checked
            If (Not Me.checkBox1.Checked) Then
                Me.ColTypeCombo.Enabled = False
                Me.CheckBox2.Enabled = False
            Else
                Me.ColTypeCombo.Enabled = True
                If (Me.comboBoxChartType.SelectedIndex <> 2) Then Me.CheckBox2.Enabled = True
            End If
        End Sub
        Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
            If CheckBox2.Checked Then
                Me.chartControl1.Style3D = True
            Else
                Me.chartControl1.Style3D = False
            End If
        End Sub
#End Region
    End Class
End Namespace
