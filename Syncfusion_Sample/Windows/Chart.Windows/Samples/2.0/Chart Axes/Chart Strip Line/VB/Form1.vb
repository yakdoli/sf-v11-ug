Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms
Imports System.Reflection
Imports System.IO

Namespace Chart_StripLine
    Partial Public Class Form1
        Inherits Office2007Form
#Region "Members"
        Private str As String
        Private position As Integer = 3
        Private highTempStripLine As Boolean = False
        Private stripLineColor As Color() = New Color() {Color.FromArgb(229, 150, 32), Color.FromArgb(252, 247, 235), Color.FromArgb(229, 150, 32)}
        Private labels As String() = New String() {"", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"}
        Private newStripLine As ChartStripLine = New ChartStripLine()
        Dim stripLine1 As ChartStripLine = New ChartStripLine()
#End Region

#Region "Form Constructor"
        Public Sub New()
            InitializeComponent()
            InitializeChartData()
            Me.domainUpDown1.SelectedIndex = 3
            InitializeControlSettings()
            Me.panel2.Visible = False
            Me.Size = New Size(450, 375)
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region "Helper Methods"
#Region "InitializeControlSettings"

        ''' <summary>
        ''' Initialize Control Settings.
        ''' </summary>
        Private Sub InitializeControlSettings()
            For Each text As String In System.Enum.GetNames(GetType(System.Drawing.ContentAlignment))
                Me.comboBox1.Items.Add(text)
            Next text
            Me.comboBox1.SelectedIndex = 4
        End Sub

#End Region

#Region "InitializeChartData"
        ''' <summary>
        ''' Initialize Chart Data
        ''' </summary>
        Protected Sub InitializeChartData()
            Dim weather As ChartSeries = New ChartSeries("Weather", ChartSeriesType.Spline)
            weather.Points.Add(1, 78)
            weather.Points.Add(2, 82)
            weather.Points.Add(3, 84)
            weather.Points.Add(4, 82)
            weather.Points.Add(5, 79)
            weather.Points.Add(6, 81)
            weather.Points.Add(7, 86)
            weather.Style.PointWidth = 0.3F
            weather.Style.Border.Width = 2
            Me.chartControl1.Series.Add(weather)
            Me.chartControl1.Text = "Weather Chart"
            AddHandler weather.PrepareStyle, AddressOf Series1_PrepareStyle
            SetStripLine()
        End Sub

#End Region

#Region "Stripline"
        ''' <summary>
        ''' Creates and draw stripline
        ''' </summary>
        Protected Sub SetStripLine()
            'Creates horizontal stripline
            If highTempStripLine Then
                'Chart Strip Lines
                stripLine1.Enabled = True
                stripLine1.Vertical = False
                stripLine1.Start = 93
                stripLine1.End = 94
                stripLine1.Text = "Historical High: 93'F"
                stripLine1.Font = New System.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(161)))
                stripLine1.Period = 50
                stripLine1.Width = 2.3
                stripLine1.Interior = New BrushInfo(GradientStyle.Vertical, stripLineColor)

                'Adds the stripline to the collection
                Me.chartControl1.PrimaryYAxis.StripLines.Add(stripLine1)
            End If
            If position < 0 Then
                position = 3
            End If
            'Creates vertical stripline
            Dim thermoStripLine As ChartStripLine = New ChartStripLine()
            thermoStripLine.Enabled = True
            thermoStripLine.Vertical = False
            thermoStripLine.Start = position + 1
            thermoStripLine.End = position + 2
            thermoStripLine.Text = " "
            Dim asem As System.Reflection.Assembly = Me.GetType().Assembly
            Dim str As Stream = asem.GetManifestResourceStream("ChartStripLine_2005.thermometer.png")
            Dim img As Image = Image.FromStream(str)
            thermoStripLine.BackImage = img
            thermoStripLine.Font = New System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161)))
            thermoStripLine.Period = 50
            thermoStripLine.Width = 0.4
            thermoStripLine.Interior = New BrushInfo(GradientStyle.Vertical, stripLineColor)
            Me.chartControl1.PrimaryXAxis.StripLines.Add(thermoStripLine)
        End Sub

#End Region

#End Region

#Region "Events"

#Region "ChartFormatAxisLabel"

        ''' <summary>
        ''' Sets the axis label values.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub chartControl1_ChartFormatAxisLabel(ByVal sender As Object, ByVal e As ChartFormatAxisLabelEventArgs) Handles chartControl1.ChartFormatAxisLabel
            If e.AxisOrientation = ChartOrientation.Vertical Then
                If e.Value = 0 Then
                    e.Label = ""
                Else
                    'Applying Formatted Y Axis label values.
                    e.Label = String.Format("{0}'F ", e.Value)
                End If
            Else
                Dim index As Integer = CInt(Fix(e.Value))

                'if (index >= 0 && index < labels.Length)
                '{
                If index < labels.Length Then
                    'Applying custom label text for X Axis
                    e.Label = labels(index)
                Else
                    e.Label = ""
                End If
            End If
            e.Handled = True

        End Sub
#End Region

#Region "Series Prepare Style"

        ''' <summary>
        ''' Sets the display text.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="args"></param>
        Private Sub Series1_PrepareStyle(ByVal sender As Object, ByVal args As ChartPrepareStyleInfoEventArgs)
            Dim series As ChartSeries = TryCast(sender, ChartSeries)
            If series IsNot Nothing Then
                If args.Index = position Then
                    args.Style.DisplayText = True
                End If
            End If
        End Sub
#End Region

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
            Me.chartControl1.PrimaryXAxis.StripLines.Clear()
            Me.chartControl1.PrimaryYAxis.StripLines.Clear()
            SetStripLine()
            newStripLine.Enabled = True

            Select Case str
                Case "Default"
                    newStripLine.StartAtAxisPosition = False
                    newStripLine.Start = Convert.ToDouble(Me.numericUpDown1.Value)
                    newStripLine.End = newStripLine.Start + 1
                    newStripLine.Width = Convert.ToDouble(Me.numericUpDown3.Value)

                Case "DateTime"
                    Me.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime
                    Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
                    newStripLine.StartAtAxisPosition = True
                    newStripLine.WidthDate = New TimeSpan(CInt(Fix(Me.numericUpDown3.Value)), 0, 0, 0, 0)
                    newStripLine.DateOffset = New TimeSpan(CInt(Fix(Me.numericUpDown2.Value)), 0, 0, 0, 0)
                    newStripLine.PeriodDate = New TimeSpan(CInt(Fix(Me.numericUpDown4.Value)), 0, 0, 0, 0)

            End Select
            newStripLine.Text = Me.textBox1.Text
            newStripLine.TextColor = Me.colorPickerButton1.SelectedColor
            newStripLine.Interior = New BrushInfo(GradientStyle.Horizontal, Color.LightGray, Color.White)

            If radioButton1.Checked Then
                newStripLine.Vertical = True
                Me.chartControl1.PrimaryXAxis.StripLines.Add(newStripLine)
                If highTempStripLine Then
                    Me.chartControl1.PrimaryXAxis.StripLines(1).TextAlignment = CType(System.Enum.Parse(GetType(ContentAlignment), Me.comboBox1.SelectedItem.ToString(), True), ContentAlignment)
                Else
                    Me.chartControl1.PrimaryXAxis.StripLines(0).TextAlignment = CType(System.Enum.Parse(GetType(ContentAlignment), Me.comboBox1.SelectedItem.ToString(), True), ContentAlignment)
                End If
            Else
                newStripLine.Vertical = False

                Me.chartControl1.PrimaryYAxis.StripLines.Add(newStripLine)
                Me.chartControl1.PrimaryYAxis.StripLines(0).TextAlignment = CType(System.Enum.Parse(GetType(ContentAlignment), Me.comboBox1.SelectedItem.ToString(), True), ContentAlignment)
            End If
            Me.panel2.Visible = False
            Me.Size = New Size(450, 375)
            Me.buttonAdv2.Enabled = True
        End Sub

        Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton2.CheckedChanged, radioButton1.CheckedChanged
            If radioButton1.Checked Then
                Me.numericUpDown1.Minimum = 0
                Me.numericUpDown1.Maximum = 10
                Me.numericUpDown2.Minimum = 0
                Me.numericUpDown2.Maximum = 10
                Me.numericUpDown4.Minimum = 1
                Me.numericUpDown4.Maximum = 11
                Me.numericUpDown1.Value = 5
                Me.numericUpDown2.Value = 3
                Me.numericUpDown3.Value = 1
                Me.numericUpDown4.Value = 4
            Else
                Me.numericUpDown1.Minimum = 50
                Me.numericUpDown1.Maximum = 100
                Me.numericUpDown2.Minimum = 10
                Me.numericUpDown2.Maximum = 100
                Me.numericUpDown4.Minimum = 15
                Me.numericUpDown4.Maximum = 35

                Me.numericUpDown1.Value = 60
                Me.numericUpDown2.Value = 20
                Me.numericUpDown3.Value = 5
                Me.numericUpDown4.Value = 20
            End If
        End Sub

        Private Sub buttonAdv3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv3.Click
            highTempStripLine = True
            SetStripLine()
        End Sub

        Private Sub domainUpDown1_SelectedItemChanged(ByVal sender As Object, ByVal e As EventArgs) Handles domainUpDown1.SelectedItemChanged
            Dim i As Integer = 0
            position = Me.domainUpDown1.SelectedIndex
            Me.chartControl1.PrimaryXAxis.StripLines.Clear()
            Me.chartControl1.PrimaryYAxis.StripLines.Clear()
            Me.chartControl1.Series.Clear()
            InitializeChartData()
            SetStripLine()
        End Sub

        Private Sub buttonAdv2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv2.Click
            Me.comboBox2.SelectedIndex = 0
            Me.radioButton1.Checked = True
            str = "Default"
            Me.numericUpDown2.Enabled = False
            Me.numericUpDown4.Enabled = False
            Me.numericUpDown1.Enabled = True
            Me.numericUpDown3.Enabled = True

            Me.Size = New Size(450, 556)
            Me.buttonAdv2.Enabled = False
            Me.panel2.Visible = True
        End Sub

        Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox2.SelectedIndexChanged
            If Me.comboBox2.SelectedIndex = 0 Then
                str = "Default"
                Me.numericUpDown2.Enabled = False
                Me.numericUpDown4.Enabled = False
                Me.numericUpDown1.Enabled = True
                Me.numericUpDown3.Enabled = True
            Else
                str = "DateTime"
                Me.numericUpDown1.Enabled = False
                Me.numericUpDown3.Enabled = False
                Me.numericUpDown2.Enabled = True
                Me.numericUpDown4.Enabled = True
            End If
        End Sub

        Private Sub colorPickerButton1_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton1.ColorSelected
            Me.textBox3.BackColor = Me.colorPickerButton1.SelectedColor
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            If checkBox1.Checked Then
                stripLine1.FixedWidth = Convert.ToDouble(numericUpDown5.Value)
            Else
                stripLine1.FixedWidth = 0
                stripLine1.Width = 2.3
            End If
        End Sub

        Private Sub numericUpDown5_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numericUpDown5.ValueChanged
            If checkBox1.Checked Then
                stripLine1.FixedWidth = Convert.ToDouble(numericUpDown5.Value)
            Else
                stripLine1.FixedWidth = 0
                stripLine1.Width = 2.3
            End If
        End Sub
#End Region
    End Class
End Namespace