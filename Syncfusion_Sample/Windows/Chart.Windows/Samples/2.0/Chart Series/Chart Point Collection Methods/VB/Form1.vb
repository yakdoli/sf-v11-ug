Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Drawing

Namespace ChartPointCollectionMethods_2005
	Public Partial Class Form1
		Inherits Office2007Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
		End Sub

		#Region "Helper Methods"

		#Region "InitializeChartData"

		''' <summary>
		''' In this method chart data has been Initialized.
		''' </summary>
		Public Sub InitializeChartData()
			Dim SyncSeries1 As ChartSeries = New ChartSeries()
			SyncSeries1.Name = "ser1"
			Me.chartControl1.Series.Clear()

			SyncSeries1.Points.Add(1, 600, 300, 500, 200)
			SyncSeries1.Points.Add(2, 400, 500, 600, 100)
			SyncSeries1.Points.Add(3, 300, 200, 900, 600)
			SyncSeries1.Points.Add(4, 500, 350)
			SyncSeries1.Points.Add(5, 550, 210, 100)
			SyncSeries1.Points.Add(6, 200, 450, 900)
			SyncSeries1.Points.Add(7, 400, 350, 800)
			Me.chartControl1.Series.Add(SyncSeries1)
			Me.chartControl1.Series(0).Type = ChartSeriesType.Column
			Me.rdBtnFindValue.Checked = True

		End Sub
#End Region

		#Region "Calulate"

		Public Sub Calculate()
			cbBxFindMaxValue.SelectedIndex = 0
			cbBxFindMinValue.SelectedIndex = 0
			cbBxFindValue.SelectedIndex = 3


			If rdBtnFindMinValue.Checked Then
				cbBxFindMaxValue.Visible = False
				cbBxFindMinValue.Visible = True
				cbBxFindValue.Visible = False
				Select Case cbBxFindMinValue.SelectedIndex

					Case 0
						txBxValue.Visible = False
						txBxString.Visible = False
						txBxIndex.Visible = False
						label1.Visible = False
						label2.Visible = False
						label3.Visible = False
						label4.Visible = False
						textBox1.Visible = False

					Case 1
						txBxValue.Visible = False
						txBxString.Visible = True
						txBxIndex.Visible = False
						label1.Visible = False
						label2.Visible = True
						label3.Visible = False
						label4.Visible = False
						textBox1.Visible = False

					Case Else
						txBxValue.Visible = False
						txBxString.Visible = True
						txBxIndex.Visible = True
						label1.Visible = False
						label2.Visible = True
						label3.Visible = True
				End Select

			ElseIf rdBtnFindMaxValue.Checked Then
				cbBxFindMaxValue.Visible = True
				cbBxFindMinValue.Visible = False
				cbBxFindValue.Visible = False
				Select Case cbBxFindMaxValue.SelectedIndex

					Case 0
						txBxValue.Visible = False
						txBxString.Visible = False
						txBxIndex.Visible = False
						label1.Visible = False
						label2.Visible = False
						label3.Visible = False

					Case 1
						txBxValue.Visible = False
						txBxString.Visible = True
						txBxIndex.Visible = False
						label1.Visible = False
						label2.Visible = True
						label3.Visible = False

					Case Else
						txBxValue.Visible = False
						txBxString.Visible = True
						txBxIndex.Visible = True
						label1.Visible = False
						label2.Visible = True
						label3.Visible = True
				End Select
			Else
				cbBxFindMaxValue.Visible = False
				cbBxFindMinValue.Visible = False
				cbBxFindValue.Visible = True
				Select Case cbBxFindValue.SelectedIndex

					Case 0
						txBxValue.Visible = True
						txBxString.Visible = False
						txBxIndex.Visible = False
						label1.Visible = True
						label2.Visible = False
						label3.Visible = False

					Case 1
						txBxValue.Visible = True
						txBxString.Visible = True
						txBxIndex.Visible = False
						label1.Visible = True
						label2.Visible = True
						label3.Visible = False

					Case Else
						txBxValue.Visible = True
						txBxString.Visible = True
						txBxIndex.Visible = True
						label1.Visible = True
						label2.Visible = True
						label3.Visible = True
				End Select
			End If
		End Sub
		#End Region

		#End Region

		#Region "Events"

		Private Sub rdBtnFindValue_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdBtnFindValue.CheckedChanged
			Me.Calculate()
		End Sub

		Private Sub rdBtnFindMaxValue_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdBtnFindMaxValue.CheckedChanged
			Me.Calculate()
		End Sub

		Private Sub rdBtnFindMinValue_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdBtnFindMinValue.CheckedChanged
			Me.Calculate()
		End Sub

		Private Sub cbBxFindValue_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbBxFindValue.SelectedIndexChanged
			Select Case cbBxFindValue.SelectedIndex

				Case 0
					txBxValue.Visible = True
					txBxString.Visible = False
					txBxIndex.Visible = False
					label1.Visible = True
					label2.Visible = False
					label3.Visible = False
					label4.Visible = False
					textBox1.Visible = False

				Case 1
					txBxValue.Visible = True
					txBxString.Visible = True
					txBxIndex.Visible = False
					label1.Visible = True
					label2.Visible = True
					label3.Visible = False
					label4.Visible = False
					textBox1.Visible = False
				Case 2
					txBxValue.Visible = True
					txBxString.Visible = True
					txBxIndex.Visible = True
					label1.Visible = True
					label2.Visible = True
					label3.Visible = True
					label4.Visible = False
					textBox1.Visible = False

				Case Else
					txBxValue.Visible = True
					txBxString.Visible = True
					txBxIndex.Visible = True
					label1.Visible = True
					label2.Visible = True
					label3.Visible = True
					label4.Visible = True
					textBox1.Visible = True
			End Select
		End Sub

		Private Sub cbBxFindMaxValue_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbBxFindMaxValue.SelectedIndexChanged
			Select Case cbBxFindMaxValue.SelectedIndex

				Case 0
					txBxValue.Visible = False
					txBxString.Visible = False
					txBxIndex.Visible = False
					label1.Visible = False
					label2.Visible = False
					label3.Visible = False
					label4.Visible = False
					textBox1.Visible = False


				Case 1
					txBxValue.Visible = False
					txBxString.Visible = True
					txBxIndex.Visible = False
					label1.Visible = False
					label2.Visible = True
					label3.Visible = False
					label4.Visible = False
					textBox1.Visible = False
				Case 2
					txBxValue.Visible = False
					txBxString.Visible = True
					txBxIndex.Visible = True
					label1.Visible = False
					label2.Visible = True
					label3.Visible = True
					label4.Visible = False
					textBox1.Visible = False

				Case Else
					txBxValue.Visible = False
					txBxString.Visible = True
					txBxIndex.Visible = True
					label1.Visible = False
					label2.Visible = True
					label3.Visible = True
					label4.Visible = True
					textBox1.Visible = True

			End Select
		End Sub

		Private Sub cbBxFindMinValue_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbBxFindMinValue.SelectedIndexChanged


			Select Case cbBxFindMinValue.SelectedIndex

				Case 0
					txBxValue.Visible = False
					txBxString.Visible = False
					txBxIndex.Visible = False
					label1.Visible = False
					label2.Visible = False
					label3.Visible = False
					label4.Visible = False
					textBox1.Visible = False


				Case 1
					txBxValue.Visible = False
					txBxString.Visible = True
					txBxIndex.Visible = False
					label1.Visible = False
					label2.Visible = True
					label3.Visible = False
					label4.Visible = False
					textBox1.Visible = False
				Case 2
					txBxValue.Visible = False
					txBxString.Visible = True
					txBxIndex.Visible = True
					label1.Visible = False
					label2.Visible = True
					label3.Visible = True
					label4.Visible = False
					textBox1.Visible = False

				Case Else
					txBxValue.Visible = False
					txBxString.Visible = True
					txBxIndex.Visible = True
					label1.Visible = False
					label2.Visible = True
					label3.Visible = True
					label4.Visible = True
					textBox1.Visible = True
			End Select
		End Sub

		Private Sub btnResult_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnResult.Click
			Dim resultstr As String = ""
			Dim dbl As Double = 0 ' Int64.Parse(txBxValue.Text);
			Dim str As String = "" ' txBxString.Text;
			Dim [end] As String = ""
			Dim staIndx As Integer = 0 ' Int32.Parse(txBxIndex.Text);
			Dim endIndx As Integer = 0
            Try
                If rdBtnFindMinValue.Checked Then

                    Select Case cbBxFindMinValue.SelectedIndex

                        Case 0
                            Dim dp1 As ChartPoint = Me.chartControl1.Series(0).Summary.FindMinValue()
                            resultstr = dp1.ToString()

                        Case 1
                            str = txBxString.Text
                            Dim dp2 As ChartPoint = Me.chartControl1.Series(0).Summary.FindMinValue(str)
                            resultstr = dp2.ToString()
                        Case 2
                            str = txBxString.Text
                            staIndx = Int32.Parse(txBxIndex.Text)
                            Dim dp3 As ChartPoint = Me.chartControl1.Series(0).Summary.FindMinValue(str, staIndx)
                            resultstr = dp3.ToString()
                        Case Else
                            str = txBxString.Text
                            [end] = textBox1.Text
                            staIndx = Int32.Parse(txBxIndex.Text)
                            endIndx = Int32.Parse(textBox1.Text)
                            Dim dp4 As ChartPoint = Me.chartControl1.Series(0).Summary.FindMinValue(str, staIndx, endIndx)
                            resultstr = dp4.ToString()
                    End Select

                ElseIf rdBtnFindMaxValue.Checked Then
                    Select Case cbBxFindMaxValue.SelectedIndex

                        Case 0
                            Dim dp1 As ChartPoint = Me.chartControl1.Series(0).Summary.FindMaxValue()
                            resultstr = dp1.ToString()

                        Case 1
                            str = txBxString.Text
                            Dim dp2 As ChartPoint = Me.chartControl1.Series(0).Summary.FindMaxValue(str)
                            resultstr = dp2.ToString()
                        Case 2
                            str = txBxString.Text
                            staIndx = Int32.Parse(txBxIndex.Text)
                            Dim dp3 As ChartPoint = Me.chartControl1.Series(0).Summary.FindMaxValue(str, staIndx)
                            resultstr = dp3.ToString()

                        Case Else
                            str = txBxString.Text
                            [end] = textBox1.Text
                            staIndx = Int32.Parse(txBxIndex.Text)
                            endIndx = Int32.Parse(textBox1.Text)
                            Dim dp4 As ChartPoint = Me.chartControl1.Series(0).Summary.FindMaxValue(str, staIndx, endIndx)
                            resultstr = dp4.ToString()
                    End Select
                Else
                    Select Case cbBxFindValue.SelectedIndex

                        Case 0
                            dbl = Int64.Parse(txBxValue.Text)
                            Dim dp1 As ChartPoint = Me.chartControl1.Series(0).Summary.FindValue(dbl)
                            resultstr = dp1.ToString()

                        Case 1
                            dbl = Int64.Parse(txBxValue.Text)
                            str = txBxString.Text
                            Dim dp2 As ChartPoint = Me.chartControl1.Series(0).Summary.FindValue(dbl, str)
                            resultstr = dp2.ToString()

                        Case 2
                            dbl = Int64.Parse(txBxValue.Text)
                            str = txBxString.Text
                            staIndx = Int32.Parse(txBxIndex.Text)
                            Dim dp3 As ChartPoint = Me.chartControl1.Series(0).Summary.FindValue(dbl, str, staIndx)
                            resultstr = dp3.ToString()
                        Case Else
                            dbl = Int64.Parse(txBxValue.Text)
                            str = txBxString.Text
                            [end] = textBox1.Text
                            staIndx = Int32.Parse(txBxIndex.Text)
                            endIndx = Int32.Parse(textBox1.Text)
                            Dim dp4 As ChartPoint = Me.chartControl1.Series(0).Summary.FindValue(dbl, str, staIndx, endIndx)
                            resultstr = dp4.ToString()
                    End Select

                End If


                txBxResult.Text = "Chart Point = " & resultstr
            Catch
                txBxResult.Text = "Invalid values entered to find chart point!!"
            End Try

        End Sub

		Private Sub chartControl1_ChartFormatAxisLabel(ByVal sender As Object, ByVal e As ChartFormatAxisLabelEventArgs) Handles chartControl1.ChartFormatAxisLabel
			If e.AxisOrientation = ChartOrientation.Horizontal Then
				If e.Value = 1 Then
					e.Label = "Science Fiction"
				ElseIf e.Value = 2 Then
					e.Label = "Mystery"
				ElseIf e.Value = 3 Then
					e.Label = "Geology"
				ElseIf e.Value = 4 Then
					e.Label = "History"
				ElseIf e.Value = 5 Then
					e.Label = "Travel"
				ElseIf e.Value = 6 Then
					e.Label = "Gardening"
				ElseIf e.Value = 7 Then
					e.Label = "Computers"
				Else
					e.Label = ""
				End If

				e.Handled = True
			End If
		End Sub
		#End Region
	End Class
End Namespace