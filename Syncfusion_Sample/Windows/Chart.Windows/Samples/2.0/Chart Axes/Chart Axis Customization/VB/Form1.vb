Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports System.Drawing.Drawing2D
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing

Namespace ChartAxisCustomization_2005
	Public Partial Class Form1
		Inherits Office2007Form
#Region "Constructor"
        Public Sub New()
            InitializeComponent()
            InitializeChartData()
            InitializeControlSettings()
            FillControlPanel()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

		#Region "Helper Methods"

		#Region "InitializeControlSettings()"
		''' <summary>
		''' Initial setting of chart control.
		''' </summary>
		Private Sub InitializeControlSettings()
			Me.chartControl1.Font = New System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            For Each fontstyle As String In System.Enum.GetNames(GetType(System.Drawing.FontStyle))
                Me.comboBox_FontStyle.Items.Add(fontstyle)
            Next fontstyle

            Me.comboBox_FontStyle.SelectedIndex = 0
            Me.comboBox_Fontfamily.SelectedIndex = 20

		End Sub
		#End Region

		#Region "InitializeChartData()"
		''' <summary>
		''' Initializes the ChartControl's data and sets the Chart type.
		''' </summary>
		Protected Sub InitializeChartData()
			Dim series1 As ChartSeries = New ChartSeries(" Machine 1")
			series1.Type = ChartSeriesType.Column
			series1.Text = series1.Name

			series1.Points.Add(1,256)
			series1.Points.Add(2,351)
			series1.Points.Add(3,210)

			series1.Style.Font.Bold = True

			Dim series2 As ChartSeries = New ChartSeries(" Machine 2")
			series2.Type = ChartSeriesType.Column
			series2.Text = series2.Name

			series2.Points.Add(1,345)
			series2.Points.Add(2,275)
			series2.Points.Add(3,320)

			series2.Style.Font.Bold = True

			Dim series3 As ChartSeries = New ChartSeries(" Machine 3")
			series3.Type = ChartSeriesType.Column
			series3.Text = series3.Name

			series3.Points.Add(1,290)
			series3.Points.Add(2,260)
			series3.Points.Add(3,300)

			series3.Style.Font.Bold = True
			Me.chartControl1.Series.Add(series1)
			Me.chartControl1.Series.Add(series2)
			Me.chartControl1.Series.Add(series3)

			Me.chartControl1.PrimaryXAxis.TickSize = New Size(1, 1)
			Me.chartControl1.PrimaryYAxis.TickSize = New Size(1, 1)

			Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
			Me.chartControl1.PrimaryXAxis.Range = New MinMaxInfo(0, 4, 1)

			Me.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
			Me.chartControl1.PrimaryYAxis.Range = New MinMaxInfo(0, 400, 100)

		End Sub
		#End Region

		#Region "FillControlPanel"
		Private Sub FillControlPanel()
            Me.comboBox5.SelectedIndex = 1
			Me.comboBox6.SelectedIndex = 0
			Me.comboBox1.SelectedIndex = 0
			Me.comboBox2.SelectedIndex = 0
			Me.comboBox3.SelectedIndex = 0
            'Me.comboBox4.SelectedIndex = 1
			Me.comboBox7.SelectedIndex = 0
		End Sub
		#End Region

		Private Sub SetAxisPosition()
			Me.chartControl1.PrimaryXAxis.Inversed = Me.checkBox2.Checked
			Me.chartControl1.PrimaryYAxis.OpposedPosition = Me.checkBox4.Checked
			Me.chartControl1.PrimaryYAxis.Inversed = Me.checkBox3.Checked
            Me.chartControl1.PrimaryXAxis.OpposedPosition = Me.checkBox5.Checked
            If checkBox8.Checked Then
                Me.chartControl1.PrimaryXAxis.AxisLabelPlacement = ChartPlacement.Inside
            Else
                Me.chartControl1.PrimaryXAxis.AxisLabelPlacement = ChartPlacement.Outside
            End If
            If checkBox7.Checked Then
                Me.chartControl1.PrimaryYAxis.AxisLabelPlacement = ChartPlacement.Inside
            Else
                Me.chartControl1.PrimaryYAxis.AxisLabelPlacement = ChartPlacement.Outside
            End If
		End Sub

		Private Sub SetLineDashStyle()
			If Me.checkBoxXAxis.Checked Then
				Me.chartControl1.PrimaryXAxis.LineType.DashStyle = CType(System.Enum.Parse(GetType(DashStyle), Me.comboBox1.SelectedItem.ToString(), True), DashStyle)
			End If
			If Me.checkBoxYAxis.Checked Then
				Me.chartControl1.PrimaryYAxis.LineType.DashStyle = CType(System.Enum.Parse(GetType(DashStyle), Me.comboBox1.SelectedItem.ToString(), True), DashStyle)
			End If
			Me.chartControl1.Refresh()
		End Sub

		Private Sub SetGridLineDashStyle()
			If Me.checkBoxXAxis.Checked Then
				Me.chartControl1.PrimaryXAxis.GridLineType.DashStyle = CType(System.Enum.Parse(GetType(DashStyle), Me.comboBox6.SelectedItem.ToString(), True), DashStyle)
			End If
		   If Me.checkBoxYAxis.Checked Then
				Me.chartControl1.PrimaryYAxis.GridLineType.DashStyle = CType(System.Enum.Parse(GetType(DashStyle), Me.comboBox6.SelectedItem.ToString(), True), DashStyle)
		   End If
			Me.chartControl1.Refresh()
		End Sub

		Private Sub SetMinorGridLineDashStyle()
			If Me.checkBoxXAxis.Checked AndAlso checkBox1.Checked Then
				Me.chartControl1.PrimaryXAxis.MinorGridLineType.DashStyle = CType(System.Enum.Parse(GetType(DashStyle), Me.comboBox4.SelectedItem.ToString(), True), DashStyle)
			End If
			If Me.checkBoxYAxis.Checked AndAlso checkBox6.Checked Then
				Me.chartControl1.PrimaryYAxis.MinorGridLineType.DashStyle = CType(System.Enum.Parse(GetType(DashStyle), Me.comboBox4.SelectedItem.ToString(), True), DashStyle)
			End If
			Me.chartControl1.Refresh()
		End Sub

		Private Sub SetLineWidthSize()
			If Me.checkBoxXAxis.Checked Then
				Me.chartControl1.PrimaryXAxis.LineType.Width = Convert.ToSingle(Me.comboBox2.SelectedItem.ToString())
			End If
			If Me.checkBoxYAxis.Checked Then
				Me.chartControl1.PrimaryYAxis.LineType.Width = Convert.ToSingle(Me.comboBox2.SelectedItem.ToString())
			End If
			Me.chartControl1.Refresh()
		End Sub

		Private Sub SetGridLineWidthSize()
		 If Me.checkBoxXAxis.Checked Then
				Me.chartControl1.PrimaryXAxis.GridLineType.Width = Convert.ToSingle(Me.comboBox5.SelectedItem.ToString())
		 End If
			If Me.checkBoxYAxis.Checked Then
				Me.chartControl1.PrimaryYAxis.GridLineType.Width = Convert.ToSingle(Me.comboBox5.SelectedItem.ToString())
			End If
			Me.chartControl1.Refresh()
		End Sub

		Private Sub SetMinorGridLineWidthSize()
			If Me.checkBoxXAxis.Checked AndAlso checkBox1.Checked Then
				Me.chartControl1.PrimaryXAxis.MinorGridLineType.Width = Convert.ToSingle(Me.comboBox7.SelectedItem.ToString())
			End If
			If Me.checkBoxYAxis.Checked AndAlso checkBox6.Checked Then
				Me.chartControl1.PrimaryYAxis.MinorGridLineType.Width = Convert.ToSingle(Me.comboBox7.SelectedItem.ToString())
			End If
			Me.chartControl1.Refresh()
		End Sub

		Private Sub SetLineTickSize()
			 If Me.checkBoxXAxis.Checked Then
				  Me.chartControl1.PrimaryXAxis.TickSize = New Size(Int32.Parse(Me.comboBox2.SelectedItem.ToString()), Int32.Parse(Me.comboBox3.SelectedItem.ToString()))
			 End If
			If Me.checkBoxYAxis.Checked Then
				  Me.chartControl1.PrimaryYAxis.TickSize = New Size(Int32.Parse(Me.comboBox2.SelectedItem.ToString()), Int32.Parse(Me.comboBox3.SelectedItem.ToString()))
			End If
			Me.chartControl1.Refresh()
		End Sub

		Private Sub SetLineForeColor()
			Me.textBox3.BackColor = colorPickerButton3.SelectedColor
			If Me.checkBoxXAxis.Checked Then
				Me.chartControl1.PrimaryXAxis.LineType.ForeColor = colorPickerButton3.SelectedColor
			End If
			If Me.checkBoxYAxis.Checked Then
				Me.chartControl1.PrimaryYAxis.LineType.ForeColor = colorPickerButton3.SelectedColor
			End If

			Me.chartControl1.Refresh()
		End Sub

		Private Sub SetGridForeColor()
			 Me.textBox2.BackColor = colorPickerButton2.SelectedColor
			If Me.checkBoxXAxis.Checked Then
				Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = colorPickerButton2.SelectedColor
			End If
			If Me.checkBoxYAxis.Checked Then
				Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = colorPickerButton2.SelectedColor
			End If

			Me.chartControl1.Refresh()
		End Sub

		Private Sub SetMinorGridForeColor()
			Me.textBox1.BackColor = colorPickerButton1.SelectedColor
			If Me.checkBoxXAxis.Checked AndAlso checkBox1.Checked Then
				Me.chartControl1.PrimaryXAxis.MinorGridLineType.ForeColor = colorPickerButton1.SelectedColor
			End If
			If Me.checkBoxYAxis.Checked AndAlso checkBox6.Checked Then
				Me.chartControl1.PrimaryYAxis.MinorGridLineType.ForeColor = colorPickerButton1.SelectedColor
			End If

			Me.chartControl1.Refresh()
		End Sub

		#End Region

		#Region "Events"

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            SetAxisPosition()
        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckedChanged
            SetAxisPosition()
        End Sub

        Private Sub checkBox5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox5.CheckedChanged
            SetAxisPosition()
        End Sub

        Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox4.CheckedChanged
            SetAxisPosition()
        End Sub

        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
            SetLineDashStyle()
        End Sub

        Private Sub comboBox6_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox6.SelectedIndexChanged
            SetGridLineDashStyle()
        End Sub

        Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox2.SelectedIndexChanged
            SetLineWidthSize()
        End Sub

        Private Sub comboBox5_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox5.SelectedIndexChanged
            SetGridLineWidthSize()
        End Sub

        Private Sub comboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox3.SelectedIndexChanged
            SetLineTickSize()
        End Sub

        Private Sub colorPickerButton3_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton3.ColorSelected
            SetLineForeColor()
            Me.Refresh()
        End Sub

        Private Sub colorPickerButton2_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton2.ColorSelected
            SetGridForeColor()
            Me.Refresh()
        End Sub

        Private Sub checkBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxXAxis.CheckedChanged, checkBoxYAxis.CheckedChanged
            SetAxisPosition()
            SetLineDashStyle()
            SetGridLineDashStyle()
            SetLineWidthSize()
            SetGridLineWidthSize()
            SetLineTickSize()
            SetLineForeColor()
            SetGridForeColor()

        End Sub

        Private Sub comboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox4.SelectedIndexChanged
            SetMinorGridLineDashStyle()
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            Me.chartControl1.PrimaryXAxis.DrawMinorGrid = Me.checkBox1.Checked

        End Sub

        Private Sub checkBox6_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox6.CheckedChanged
            Me.chartControl1.PrimaryYAxis.DrawMinorGrid = Me.checkBox6.Checked
        End Sub

        Private Sub comboBox7_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox7.SelectedIndexChanged
            SetMinorGridLineWidthSize()
        End Sub

        Private Sub colorPickerButton1_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton1.ColorSelected
            SetMinorGridForeColor()
            Me.Refresh()
        End Sub

#Region " SetFont"
        Protected Sub SetFont()
            If Me.comboBox_Fontfamily.SelectedIndex > 0 Then
                Dim fs As FontStyle = CType(System.Enum.Parse(GetType(FontStyle), Me.comboBox_FontStyle.SelectedItem.ToString(), True), FontStyle)
                If Me.checkBoxXAxis.Checked Then
                    Me.chartControl1.PrimaryXAxis.TitleFont = New Font(Me.comboBox_Fontfamily.SelectedItem.ToString(), CSng(Me.numericUpDown_FontSize.Value), fs)
                End If
                If Me.checkBoxYAxis.Checked Then
                    Me.chartControl1.PrimaryYAxis.TitleFont = New Font(Me.comboBox_Fontfamily.SelectedItem.ToString(), CSng(Me.numericUpDown_FontSize.Value), fs)
                End If
                Me.chartControl1.Refresh()
                Me.Refresh()
            End If
        End Sub
#End Region

#End Region
        
        Private Sub Form1_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
            Me.checkBoxXAxis.Checked = True
            Me.checkBoxYAxis.Checked = True

            comboBox4.SelectedIndex = 1
        End Sub

        Private Sub comboBox_Fontfamily_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBox_Fontfamily.SelectedIndexChanged
            SetFont()
            Me.chartControl1.Refresh()
        End Sub

        Private Sub comboBox_FontStyle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBox_FontStyle.SelectedIndexChanged
            SetFont()
            Me.chartControl1.Refresh()
        End Sub

        Private Sub numericUpDown_FontSize_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numericUpDown_FontSize.ValueChanged
            SetFont()
            Me.chartControl1.Refresh()
        End Sub

        Private Sub colorPicker_TextColor_ColorSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorPicker_TextColor.ColorSelected
            Me.textBox_TextColor.BackColor = colorPicker_TextColor.SelectedColor
            If Me.checkBoxXAxis.Checked Then
                Me.chartControl1.PrimaryXAxis.TitleColor = colorPicker_TextColor.SelectedColor
            End If
            If Me.checkBoxYAxis.Checked Then
                Me.chartControl1.PrimaryYAxis.TitleColor = colorPicker_TextColor.SelectedColor
            End If
            Me.chartControl1.Refresh()
        End Sub


        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        End Sub

        Private Sub checkBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBox8.CheckedChanged
            SetAxisPosition()
        End Sub

        Private Sub checkBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBox7.CheckedChanged
            SetAxisPosition()
        End Sub
    End Class
End Namespace