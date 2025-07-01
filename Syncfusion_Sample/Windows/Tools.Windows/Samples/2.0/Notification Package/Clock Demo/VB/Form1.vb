Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports System.Drawing.Drawing2D

Namespace ClockDemo_2008
	Partial Public Class Form1
		Inherits MetroForm
		Private trackBarEx As New TrackBarEx()

		Private picker As New ColorPickerUIAdv()

		Public Sub New()
			InitializeComponent()

			Me.clock1.Text = " Remainder "

			trackBarEx.Style = TrackBarEx.Theme.Metro

			trackBarEx.Location = New Point(10, 100)
			trackBarEx.Size = New Size(220, 20)

			Me.panel5.Controls.Add(trackBarEx)

			AddHandler trackBarEx.ValueChanged, AddressOf trackBarEx_ValueChanged


			picker.Size = New Size (Me.colorUIControl1.Size.Width,Me.colorUIControl1.Size.Height +30)
			picker.Location = Me.colorUIControl1.Location
			Me.panel4.Controls.Remove(Me.colorUIControl1)
			picker.MetroColor = Color.Gray
            picker.Style = ColorPickerUIAdv.visualstyle.Metro

			picker.BackColor = Color.Gray
			Me.panel4.Controls.Add(picker)
			AddHandler picker.Picked, AddressOf picker_Picked




		End Sub

		Private Sub picker_Picked(ByVal sender As Object, ByVal args As ColorPickerUIAdv.ColorPickedEventArgs)
			If Me.radioButtonAdv1.Checked Then
                Me.clock1.MinuteColor = picker.SelectedColor
			End If
			If Me.radioButtonAdv2.Checked Then
				Me.clock1.HourHandColor = picker.SelectedColor
			End If
			If Me.radioButtonAdv3.Checked Then
                Me.clock1.MinuteHandColor = picker.SelectedColor
			End If
			If Me.radioButtonAdv4.Checked Then
				Me.clock1.SecondHandColor = picker.SelectedColor
			End If
			If Me.radioButtonAdv5.Checked Then
				Me.clock1.StartGradientBackColor = picker.SelectedColor
			End If
			If Me.radioButtonAdv6.Checked Then
				Me.clock1.EndGradientBackColor = picker.SelectedColor
			End If
		End Sub

		Private Sub trackBarEx_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.radioButtonAdv7.Checked Then
				Me.clock1.SecondHandThickness = trackBarEx.Value
			End If
			If Me.radioButtonAdv8.Checked Then
                Me.clock1.MinuteHandThickness = trackBarEx.Value
			End If
			If Me.radioButtonAdv9.Checked Then
				Me.clock1.HourHandThickness = trackBarEx.Value
			End If
			If Me.radioButtonAdv10.Checked Then
                Me.clock1.MinuteThickness = trackBarEx.Value
			End If
		End Sub


		Private Sub checkBoxAdv1_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Private Sub checkBoxAdv2_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Private Sub radioButtonAdv10_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv10.CheckChanged
            Me.trackBarEx.Value = CInt(Fix(Me.clock1.MinuteThickness))
		End Sub

		Private Sub radioButtonAdv9_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv9.CheckChanged
			Me.trackBarEx.Value = CInt(Fix(Me.clock1.HourHandThickness))
		End Sub

		Private Sub radioButtonAdv8_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv8.CheckChanged
            Me.trackBarEx.Value = CInt(Fix(Me.clock1.MinuteHandThickness))
		End Sub

		Private Sub radioButtonAdv7_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv7.CheckChanged
			Me.trackBarEx.Value = CInt(Fix(Me.clock1.SecondHandThickness))
		End Sub

		Private Sub colorUIControl1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles colorUIControl1.Click

		End Sub

		Private Sub colorUIControl1_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorUIControl1.ColorSelected
			If Me.radioButtonAdv1.Checked Then
                Me.clock1.MinuteColor = Me.colorUIControl1.SelectedColor
			End If
			If Me.radioButtonAdv2.Checked Then
				Me.clock1.HourHandColor = Me.colorUIControl1.SelectedColor
			End If
			If Me.radioButtonAdv3.Checked Then
                Me.clock1.MinuteHandColor = Me.colorUIControl1.SelectedColor
			End If
			If Me.radioButtonAdv4.Checked Then
				Me.clock1.SecondHandColor = Me.colorUIControl1.SelectedColor
			End If
			If Me.radioButtonAdv5.Checked Then
				Me.clock1.StartGradientBackColor = Me.colorUIControl1.SelectedColor
			End If
			If Me.radioButtonAdv6.Checked Then
				Me.clock1.EndGradientBackColor = Me.colorUIControl1.SelectedColor
			End If
		End Sub

		Private Sub pictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox1.Click

			Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock10.png")
		End Sub

		Private Sub pictureBox2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox2.Click
			Me.clock1.ShowBorder = False
            Me.clock1.ShowMinute = False
			Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock1.png")
			Me.checkBoxAdv6.Checked = False
		End Sub

		Private Sub pictureBox3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox3.Click
			Me.clock1.ShowBorder = False
            Me.clock1.ShowMinute = False
			Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock2.png")
			Me.checkBoxAdv6.Checked = False
		End Sub

		Private Sub pictureBox4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox4.Click
			Me.clock1.ShowBorder = False
            Me.clock1.ShowMinute = False
			Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock3.png")
		End Sub

		Private Sub pictureBox5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox5.Click
			Me.clock1.ShowBorder = False
            Me.clock1.ShowMinute = False
			Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock4.png")
		End Sub

		Private Sub pictureBox6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox6.Click
			Me.clock1.ShowBorder = False
            Me.clock1.ShowMinute = False
			Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock5.png")
		End Sub

		Private Sub pictureBox7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox7.Click
			Me.clock1.ShowBorder = False
            Me.clock1.ShowMinute = False
			Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock6.png")
		End Sub

		Private Sub pictureBox8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox8.Click
			Me.clock1.ShowBorder = False
            Me.clock1.ShowMinute = False
			Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock7.png")
		End Sub

		Private Sub panel3_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles panel3.Paint

		End Sub

		Private Sub checkBoxAdv3_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Private Sub pictureBox1_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
			Me.Cursor = Cursors.Hand
		End Sub

		Private Sub pictureBox1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox10.MouseLeave, pictureBox9.MouseLeave, pictureBox8.MouseLeave, pictureBox7.MouseLeave, pictureBox6.MouseLeave, pictureBox5.MouseLeave, pictureBox4.MouseLeave, pictureBox3.MouseLeave, pictureBox2.MouseLeave, pictureBox1.MouseLeave
			Me.Cursor = Cursors.Default
			If Not Me.checkBoxAdv5.Checked Then
				Me.clock1.Image = Nothing
				Me.checkBoxAdv1.Checked = True
				Me.clock1.Image = Nothing
                Me.clock1.MinuteHandThickness = 1
				Me.clock1.HourHandThickness = 2
                Me.clock1.MinuteHandThickness = 2
				Me.clock1.StartGradientBackColor = ColorTranslator.FromHtml("#FFFFFF")
				Me.clock1.EndGradientBackColor = ColorTranslator.FromHtml("#CCD6D9")
                Me.clock1.MinuteColor = Color.Gray
				Me.clock1.HourHandColor = Color.Gray
                Me.clock1.MinuteHandColor = Color.Gray
				Me.clock1.SecondHandColor = Color.Gray
				Me.clock1.ShowBorder = True
                Me.clock1.ShowMinute = True
				Me.checkBoxAdv1.Checked = True


			End If



		End Sub

		Private Sub panel2_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles panel2.Paint

		End Sub

		Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv1.Click
            Me.clock1.EnableRemainder = True
			Dim year As Integer = DateTime.Now.Year
			Dim month As Integer = DateTime.Now.Month
			Dim day As Integer = DateTime.Now.Day
			Dim hour As Integer = DateTime.Now.Hour
			Dim min As Integer = DateTime.Now.Minute
			Dim sec As Integer = DateTime.Now.Second + 1
			Dim msec As Integer = DateTime.Now.Millisecond
            Me.clock1.Remainder = New System.DateTime(year, month, day, hour, min, sec, msec)
		End Sub

		Private Sub checkBoxAdv1_CheckStateChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv1.CheckStateChanged
            Me.clock1.ShowMinute = Me.checkBoxAdv1.Checked
		End Sub

		Private Sub checkBoxAdv2_CheckStateChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv2.CheckStateChanged
			Me.clock1.ShowAMorPM = Me.checkBoxAdv2.Checked
		End Sub

		Private Sub checkBoxAdv3_CheckStateChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv3.CheckStateChanged
			Me.clock1.ShowSecondHand = Me.checkBoxAdv3.Checked
		End Sub

		Private Sub checkBoxAdv4_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv4.CheckStateChanged
			If Me.checkBoxAdv4.Checked Then
				Dim renderer As New CustomRenderer()
				Me.clock1.Renderer = renderer
			Else
				Dim renderer As New ClockRenderer()
				Me.clock1.Renderer = renderer
			End If

		End Sub

		Private Sub pictureBox9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox9.Click
			Me.clock1.ShowBorder = False
            Me.clock1.ShowMinute = False
			Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock8.png")
		End Sub

		Private Sub pictureBox10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox10.Click
			Me.clock1.StartGradientBackColor = Color.White

			Me.clock1.EndGradientBackColor = Color.White

			Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock9.png")
		End Sub

		Private Sub checkBoxAdv5_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv5.CheckStateChanged
			If checkBoxAdv5.Checked Then
				Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock1.png")
                Me.clock1.ShowMinute = False
				Me.clock1.ShowBorder = False
				Me.checkBoxAdv1.Checked = True
				Me.checkBoxAdv6.Checked = False
				Me.panel1.BackgroundImage = Nothing
			Else
				Me.clock1.Image = Nothing
                Me.clock1.MinuteHandThickness = 1
				Me.clock1.HourHandThickness = 2
                Me.clock1.MinuteHandThickness = 2
				Me.clock1.StartGradientBackColor = ColorTranslator.FromHtml("#FFFFFF")
				Me.clock1.EndGradientBackColor = ColorTranslator.FromHtml("#CCD6D9")
                Me.clock1.MinuteColor = Color.Gray
				Me.clock1.HourHandColor = Color.Gray
                Me.clock1.MinuteHandColor = Color.Gray
				Me.clock1.SecondHandColor = Color.Gray
                Me.clock1.ShowMinute = True
				Me.clock1.ShowBorder = True
				Me.checkBoxAdv1.Checked = True
				Me.clock1.IsTransparent = False
			End If
		End Sub

		Private Sub pictureBox2_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox2.MouseEnter
			Me.Cursor = Cursors.Hand
			If Not Me.checkBoxAdv5.Checked Then
				Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock1.png")
			End If
			Me.clock1.ShowBorder = False
            Me.clock1.ShowMinute = False
			Me.checkBoxAdv6.Checked = False
		End Sub

		Private Sub pictureBox10_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox10.MouseEnter
			Me.Cursor = Cursors.Hand
			If Not Me.checkBoxAdv5.Checked Then
				Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock9.png")
			End If
			Me.clock1.ShowBorder = False
            Me.clock1.ShowMinute = False
			Me.checkBoxAdv6.Checked = False
			Me.clock1.StartGradientBackColor = Color.White
			Me.clock1.EndGradientBackColor = Color.White
		End Sub

		Private Sub pictureBox3_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox3.MouseEnter
			Me.Cursor = Cursors.Hand
			If Not Me.checkBoxAdv5.Checked Then
				Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock2.png")
			End If
			Me.clock1.ShowBorder = False
            Me.clock1.ShowMinute = False
			Me.checkBoxAdv6.Checked = False
		End Sub

		Private Sub pictureBox4_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox4.MouseEnter
			Me.Cursor = Cursors.Hand
			If Not Me.checkBoxAdv5.Checked Then
				Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock3.png")
			End If
			Me.clock1.ShowBorder = False
            Me.clock1.ShowMinute = False
			Me.checkBoxAdv6.Checked = False
		End Sub

		Private Sub pictureBox5_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox5.MouseEnter
			Me.Cursor = Cursors.Hand
			If Not Me.checkBoxAdv5.Checked Then
				Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock4.png")
			End If
			Me.clock1.ShowBorder = False
            Me.clock1.ShowMinute = False
			Me.checkBoxAdv6.Checked = False
		End Sub

		Private Sub pictureBox6_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox6.MouseEnter
			Me.Cursor = Cursors.Hand
			If Not Me.checkBoxAdv5.Checked Then
				Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock5.png")
			End If
			Me.clock1.ShowBorder = False
            Me.clock1.ShowMinute = False
			Me.checkBoxAdv6.Checked = False
		End Sub

		Private Sub pictureBox7_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox7.MouseEnter
			Me.Cursor = Cursors.Hand
			If Not Me.checkBoxAdv5.Checked Then
				Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock6.png")
			End If
			Me.clock1.ShowBorder = False
            Me.clock1.ShowMinute = False
			Me.checkBoxAdv6.Checked = False
		End Sub

		Private Sub pictureBox8_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox8.MouseEnter
			Me.Cursor = Cursors.Hand
			If Not Me.checkBoxAdv5.Checked Then
				Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock7.png")
			End If
			Me.clock1.ShowBorder = False
            Me.clock1.ShowMinute = False
			Me.checkBoxAdv6.Checked = False
		End Sub

		Private Sub pictureBox9_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox9.MouseEnter
			Me.Cursor = Cursors.Hand
			If Not Me.checkBoxAdv5.Checked Then
				Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock8.png")
			End If
			Me.clock1.ShowBorder = False
            Me.clock1.ShowMinute = False
			Me.checkBoxAdv6.Checked = False
		End Sub

		Private Sub pictureBox1_MouseEnter_1(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox1.MouseEnter
			Me.Cursor = Cursors.Hand
			If Not Me.checkBoxAdv5.Checked Then
				Me.clock1.Image = Image.FromFile("../../ClockModelImages/Clock10.png")
			End If
			Me.clock1.ShowBorder = False
            Me.clock1.ShowMinute = False
			Me.checkBoxAdv6.Checked = False
		End Sub

		Private Sub label5_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles label5.Leave

		End Sub

		Private Sub checkBoxAdv6_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv6.CheckStateChanged

			Me.clock1.IsTransparent = checkBoxAdv6.Checked

			If checkBoxAdv6.Checked Then
				Me.panel1.BackgroundImage = My.Resources._3
			Else
				Me.panel1.BackgroundImage = Nothing
			End If
		End Sub

		Private Sub buttonAdv1_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv1.MouseEnter
			Me.Cursor = Cursors.Hand
		End Sub

		Private Sub buttonAdv1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv1.MouseLeave
			Me.Cursor = Cursors.Default
		End Sub

        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.pictureBox10.Image = My.Resources.clock_9
            Me.pictureBox9.Image = My.Resources.clock_8
            Me.pictureBox8.Image = My.Resources.clock_7
            Me.pictureBox7.Image = My.Resources.clock_6
            Me.pictureBox6.Image = My.Resources.clock_5
            Me.pictureBox5.Image = My.Resources.clock_4
            Me.pictureBox4.Image = My.Resources.clock_3
            Me.pictureBox3.Image = My.Resources.clock_2
            Me.pictureBox2.Image = My.Resources.clock_1
            Me.pictureBox1.Image = My.Resources.clock_10
        End Sub
    End Class
	Public Class CustomRenderer
		Inherits ClockRenderer


		Public Overrides Sub DrawInterior(ByVal g As Graphics, ByVal thickness As Single, ByVal startPoint As PointF, ByVal endPoint As PointF, ByVal color As Color, ByVal sender As String)
			If sender = "SecondsHand" Then
				g.SmoothingMode = SmoothingMode.AntiAlias
				Dim p As New Pen(color, thickness + thickness)
				p.StartCap = LineCap.SquareAnchor
				p.EndCap = LineCap.ArrowAnchor
				g.DrawLine(p, startPoint, endPoint)
				p.Dispose()
            ElseIf sender = "MinutesHand" Then
                g.SmoothingMode = SmoothingMode.AntiAlias
                Dim p As New Pen(color, thickness + thickness)
                p.StartCap = LineCap.SquareAnchor
                p.EndCap = LineCap.ArrowAnchor
                g.DrawLine(p, startPoint, endPoint)
                p.Dispose()
			ElseIf sender = "HoursHand" Then
				g.SmoothingMode = SmoothingMode.AntiAlias
				Dim p As New Pen(color, thickness + thickness)
				p.StartCap = LineCap.SquareAnchor
				p.EndCap = LineCap.ArrowAnchor
				g.DrawLine(p, startPoint, endPoint)
				p.Dispose()
			Else
				g.SmoothingMode = SmoothingMode.AntiAlias
				Dim p As New Pen(color, 5)
				p.DashStyle = DashStyle.Dot
				g.DrawLine(p, startPoint, endPoint)
				p.Dispose()
			End If

		End Sub

	End Class

End Namespace
