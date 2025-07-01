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

Namespace MetroStyleControls_2008
	Partial Public Class Form1
		Inherits MetroForm

		Private trackBar As New TrackBarEx()
		Public Sub New()
			InitializeComponent()

			trackBar.Location = New Point(180, 210)
			Me.trackBar.Size = New Size(150, 100)
			trackBar.Style = TrackBarEx.Theme.Metro
			Me.Controls.Add(trackBar)
			AddHandler trackBar.ValueChanged, AddressOf trackBar_ValueChanged
			trackBar.Value = 1
			Me.radioButtonAdv8.Checked = True
            Me.FormBorderStyle = FormBorderStyle.Sizable

            Me.radioButtonAdv1.MetroColor = Color.Black
            Me.radioButtonAdv2.MetroColor = Color.Black
            Me.radioButtonAdv3.MetroColor = Color.Black
            Me.radioButtonAdv4.MetroColor = Color.Black
            Me.radioButtonAdv5.MetroColor = Color.Black
            Me.radioButtonAdv6.MetroColor = Color.Black
            Me.radioButtonAdv7.MetroColor = Color.Black
            Me.radioButtonAdv8.MetroColor = Color.Black

            Me.checkBoxAdv1.MetroColor = Color.Black


		End Sub

		Private Sub trackBar_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.BorderThickness = trackBar.Value
		End Sub

		Private Sub label31_Click(ByVal sender As Object, ByVal e As EventArgs) Handles label31.Click, label32.Click, label33.Click, label34.Click, label35.Click, label16.Click, label17.Click, label18.Click, label19.Click, label20.Click, label21.Click, label22.Click, label23.Click, label24.Click, label25.Click, label11.Click, label12.Click, label13.Click, label14.Click, label15.Click, label10.Click, label9.Click, label8.Click, label7.Click, label6.Click
			If Me.radioButtonAdv1.Checked Then
			Me.MetroColor = (TryCast(sender, Label)).BackColor
			End If
			If Me.radioButtonAdv2.Checked Then
				Me.CaptionBarColor = (TryCast(sender, Label)).BackColor
			End If
			If Me.radioButtonAdv3.Checked Then
				Me.BorderColor = (TryCast(sender, Label)).BackColor
			End If
			If Me.radioButtonAdv4.Checked Then
				Me.CaptionButtonColor = (TryCast(sender, Label)).BackColor
			End If
			If Me.radioButtonAdv5.Checked Then
				Me.CaptionForeColor = (TryCast(sender, Label)).BackColor
			End If

		End Sub

		Private Sub label31_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles label31.MouseMove, label32.MouseMove, label33.MouseMove, label34.MouseMove, label35.MouseMove, label16.MouseMove, label17.MouseMove, label18.MouseMove, label19.MouseMove, label20.MouseMove, label21.MouseMove, label22.MouseMove, label23.MouseMove, label24.MouseMove, label25.MouseMove, label11.MouseMove, label12.MouseMove, label13.MouseMove, label14.MouseMove, label15.MouseMove, label10.MouseMove, label9.MouseMove, label8.MouseMove, label7.MouseMove, label6.MouseMove
			Me.Cursor = Cursors.Hand
		End Sub

		Private Sub label31_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles label31.MouseEnter, label32.MouseEnter, label33.MouseEnter, label34.MouseEnter, label35.MouseEnter, label16.MouseEnter, label17.MouseEnter, label18.MouseEnter, label19.MouseEnter, label20.MouseEnter, label21.MouseEnter, label22.MouseEnter, label23.MouseEnter, label24.MouseEnter, label25.MouseEnter, label11.MouseEnter, label12.MouseEnter, label13.MouseEnter, label14.MouseEnter, label15.MouseEnter, label10.MouseEnter, label9.MouseEnter, label8.MouseEnter, label7.MouseEnter, label6.MouseEnter
            'TryCast(sender, Label).Left -= 1
            'TryCast(sender, Label).Top -= 1
            'TryCast(sender, Label).Width += 4
            'TryCast(sender, Label).Height += 4
		End Sub

		Private Sub panel1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panel1.MouseMove
			Me.Cursor = Cursors.Default
		End Sub

		Private Sub radioButtonAdv6_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv6.CheckChanged, radioButtonAdv7.CheckChanged, radioButtonAdv8.CheckChanged

				If Me.radioButtonAdv6.Checked Then
				Me.CaptionAlign = HorizontalAlignment.Left
				End If
				If Me.radioButtonAdv7.Checked Then
					Me.CaptionAlign = HorizontalAlignment.Center
				End If
				If Me.radioButtonAdv8.Checked Then
					Me.CaptionAlign = HorizontalAlignment.Right
				End If

		End Sub

		Private Sub showForm()
			Me.FormBorderStyle = FormBorderStyle.FixedSingle
			Dim form As New MetroForm()

			form.DropShadow = Me.checkBoxAdv1.Checked
			If Me.checkBoxAdv1.Checked Then
				form.Text = "MetroForm with shadow"
			Else
				form.Text = "MetroForm without shadow"
			End If
			form.Show()
			Dim point As New Point(Me.Left + Me.panel3.Left + 15, Me.Top + panel3.Top + 55)
			form.Location = point
			form.FormBorderStyle = FormBorderStyle.FixedToolWindow
			Dim size As New Size(Me.panel3.Width - 20, Me.panel3.Height - 40)

			form.Size = size

		End Sub
		Private Sub panel3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles panel3.Click
			showForm()

		End Sub

		Private Sub label28_Click(ByVal sender As Object, ByVal e As EventArgs) Handles label28.Click
			showForm()
		End Sub

		Private Sub radioButtonAdv1_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv1.CheckChanged, radioButtonAdv2.CheckChanged, radioButtonAdv3.CheckChanged, radioButtonAdv4.CheckChanged, radioButtonAdv5.CheckChanged

		End Sub

		Private Sub label31_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles label31.MouseLeave, label32.MouseLeave, label33.MouseLeave, label34.MouseLeave, label35.MouseLeave, label16.MouseLeave, label17.MouseLeave, label18.MouseLeave, label19.MouseLeave, label20.MouseLeave, label21.MouseLeave, label22.MouseLeave, label23.MouseLeave, label24.MouseLeave, label25.MouseLeave, label11.MouseLeave, label12.MouseLeave, label13.MouseLeave, label14.MouseLeave, label15.MouseLeave, label10.MouseLeave, label9.MouseLeave, label8.MouseLeave, label7.MouseLeave, label6.MouseLeave
            'TryCast(sender, Label).Left += 1
            'TryCast(sender, Label).Top += 1
            'TryCast(sender, Label).Width -= 4
            'TryCast(sender, Label).Height -= 4
		End Sub

		Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown


		End Sub

		Private Sub Form1_Move(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Move

		End Sub

		Private Sub Form1_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
            'Me.FormBorderStyle = FormBorderStyle.Sizable
		End Sub



	End Class
End Namespace
