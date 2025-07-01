Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms
Imports System.Drawing.Drawing2D

Namespace SplitButtonDemo

	Partial Public Class Form1
		Inherits Office2007Form
		Public startcolor As Color = Color.LightGreen
		Public endcolor As Color = Color.Green

		Public Sub New()
			InitializeComponent()
			Dim renderer As New CustomRenderer()
			renderer.SplitButton = splitButton2
			splitButton2.Renderer = renderer
			Me.splitButton1.DropDownItems.Add("Item1")
			Me.splitButton1.DropDownItems.Add("Item2")
			Me.splitButton1.DropDownItems.Add("Item3")
			Me.splitButton1.DropDownItems.Add("Item4")
			Me.splitButton1.DropDownItems.Add("Item5")
			Dim img As Image = Image.FromFile("../../logo_16.ico")
			Me.splitButton2.DropDownItems.Add("Item1", img)
			Me.splitButton2.DropDownItems.Add("Item2", img)
			Me.splitButton2.DropDownItems.Add("Item3", img)
			Me.splitButton2.DropDownItems.Add("Item4", img)
			Me.splitButton2.DropDownItems.Add("Item5", img)


		End Sub

		Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton1.CheckedChanged
			If radioButton1.Checked Then
				Me.splitButton1.ButtonMode = Syncfusion.Windows.Forms.Tools.ButtonMode.Toggle
				textBox1.Text = "SplitButton Turns ToogleMode" & Constants.vbCrLf & textBox1.Text
			End If
		End Sub

		Private Sub radioButton2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton2.CheckedChanged
			If radioButton2.Checked Then
				Me.splitButton1.ButtonMode = Syncfusion.Windows.Forms.Tools.ButtonMode.Normal
				textBox1.Text = "SplitButton Turns NormalMode" & Constants.vbCrLf & textBox1.Text
			End If
		End Sub

		Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv1.Click
			If buttonAdv1.Text = "Remove Items" Then
				Me.splitButton1.DropDownItems.Clear()
				textBox1.Text = "DropDownItems Removed" & Constants.vbCrLf & textBox1.Text
				buttonAdv1.Text = "Add Items"
			Else
				Me.splitButton1.DropDownItems.Add("Item1")
				Me.splitButton1.DropDownItems.Add("Item2")
				Me.splitButton1.DropDownItems.Add("Item3")
				Me.splitButton1.DropDownItems.Add("Item4")
				Me.splitButton1.DropDownItems.Add("Item5")
				textBox1.Text = "DropDownItems Added" & Constants.vbCrLf & textBox1.Text
				buttonAdv1.Text = "Remove Items"
			End If


		End Sub

		Private Sub radioButton3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.splitButton1.IsButtonChecked = True
		End Sub

		Private Sub radioButton4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.splitButton1.IsButtonChecked = False
		End Sub

		Private Sub buttonAdv2_Click(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Private Sub buttonAdv3_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.splitButton1.IsButtonChecked = True
			Me.splitButton1.Invalidate()
		End Sub

		Private Sub splitButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles splitButton1.Click
			textBox1.Text = "SplitButton is Clicked" & Constants.vbCrLf & textBox1.Text
		End Sub

		Private Sub splitButton1_Checked(ByVal sender As Object, ByVal e As EventArgs) Handles splitButton1.Checked
			textBox1.Text = "SplitButton is Checked" & Constants.vbCrLf & textBox1.Text
		End Sub

		Private Sub splitButton1_UnChecked(ByVal sender As Object, ByVal e As EventArgs) Handles splitButton1.UnChecked
			textBox1.Text = "SplitButton is Unchecked" & Constants.vbCrLf & textBox1.Text
		End Sub

		Private Sub splitButton1_DropDowItemClicked(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs) Handles splitButton1.DropDowItemClicked
			 textBox1.Text = e.ClickedItem.Text & " is Clicked" & Constants.vbCrLf & textBox1.Text
		End Sub




		Public Class CustomRenderer
			Implements ISplitButtonRenderer
'INSTANT VB NOTE: The variable splitButton was renamed since Visual Basic does not allow class members with the same name:
			Private splitButton_Renamed As SplitButton

			#Region "ISplitButtonRenderer Members"



            Public Sub DrawText(ByVal e As PaintEventArgs, ByVal text As String, ByVal font As Font, ByVal color As Color, ByVal totalwidth As Integer, ByVal totalheight As Integer, ByVal splitwidth As Integer) Implements ISplitButtonRenderer.DrawText


                Dim brush As New SolidBrush(color)
                Dim format As New StringFormat()
                format.Trimming = StringTrimming.EllipsisCharacter
                format.LineAlignment = StringAlignment.Center
                format.Alignment = StringAlignment.Center
                Dim textArea As New Rectangle(7, 1, totalwidth - splitwidth, totalheight)
                e.Graphics.DrawString(text, font, brush, textArea, format)
                Dim imageRect As New Rectangle(4, 11, 15, totalheight - 24)
                Dim img As Image = Image.FromFile("../../logo_16.ico")
                e.Graphics.DrawImage(img, imageRect)
                brush.Dispose()
            End Sub

			Public Sub DrawBorder(ByVal e As PaintEventArgs, ByVal width As Integer, ByVal height As Integer, ByVal splitwidth As Integer, ByVal outerColor As Color, ByVal innerColor As Color, ByVal arrowOuter As Color, ByVal arrowInner As Color, ByVal buttonInner As Color) Implements ISplitButtonRenderer.DrawBorder
				' Can Customize the Border Color of the SplitButton 
				' Outer Color is Changed 
				Dim frm As New Form1()
				Dim color1 As Color = frm.startcolor
				Dim color2 As Color = frm.endcolor
				Dim linearGradientBrush As Brush = New LinearGradientBrush(New Rectangle(0, 0, width, height), color1, color2, 90)
				e.Graphics.FillRectangle(linearGradientBrush, New Rectangle(0, 0, width, height))
				linearGradientBrush.Dispose()
'INSTANT VB NOTE: The variable outercolor was renamed since Visual Basic will not allow local variables with the same name as parameters or other local variables:
				Dim outercolor_Renamed As New Pen(Color.DarkGreen)
'INSTANT VB NOTE: The variable innercolor was renamed since Visual Basic will not allow local variables with the same name as parameters or other local variables:
				Dim innercolor_Renamed As New Pen(Color.LightGreen)
'INSTANT VB NOTE: The variable arrowinner was renamed since Visual Basic will not allow local variables with the same name as parameters or other local variables:
				Dim arrowinner_Renamed As New Pen(Color.LightGreen)
'INSTANT VB NOTE: The variable arrowouter was renamed since Visual Basic will not allow local variables with the same name as parameters or other local variables:
				Dim arrowouter_Renamed As New Pen(arrowOuter)
'INSTANT VB NOTE: The variable buttoninner was renamed since Visual Basic will not allow local variables with the same name as parameters or other local variables:
				Dim buttoninner_Renamed As New Pen(buttonInner)

				e.Graphics.DrawLine(innercolor_Renamed, New Point(1, 1), New Point(width - 2, 1))
				e.Graphics.DrawLine(innercolor_Renamed, New Point(width - 2, 1), New Point(width - 2, height - 2))
				e.Graphics.DrawLine(innercolor_Renamed, New Point(1, height - 2), New Point(width - 2, height - 2))
				e.Graphics.DrawLine(innercolor_Renamed, New Point(1, 1), New Point(1, height - 2))

				e.Graphics.DrawLine(arrowouter_Renamed, New Point(width - splitwidth, 0), New Point(width - splitwidth, height - 1))

				e.Graphics.DrawLine(buttoninner_Renamed, New Point(width - splitwidth - 1, 2), New Point(width - splitwidth - 1, height - 3))

				e.Graphics.DrawRectangle(arrowinner_Renamed, width - splitwidth + 1, 1, splitwidth - 3, height - 3)

				e.Graphics.DrawLine(outercolor_Renamed, New Point(1, 0), New Point(width - 2, 0))
				e.Graphics.DrawLine(outercolor_Renamed, New Point(width - 2, 0), New Point(width - 2, 1))
				e.Graphics.DrawLine(outercolor_Renamed, New Point(width - 1, 1), New Point(width - 1, height - 2))
				e.Graphics.DrawLine(outercolor_Renamed, New Point(width - 2, height - 2), New Point(width - 2, height - 1))
				e.Graphics.DrawLine(outercolor_Renamed, New Point(1, height - 1), New Point(width - 2, height - 1))
				e.Graphics.DrawLine(outercolor_Renamed, New Point(1, height - 1), New Point(1, height - 2))
				e.Graphics.DrawLine(outercolor_Renamed, New Point(0, 1), New Point(0, height - 2))
				e.Graphics.DrawLine(outercolor_Renamed, New Point(1, 0), New Point(1, 1))


				buttoninner_Renamed.Dispose()
				innercolor_Renamed.Dispose()
				arrowinner_Renamed.Dispose()
				arrowinner_Renamed.Dispose()
				outercolor_Renamed.Dispose()

			End Sub

			Public Sub DrawArrow(ByVal left As Integer, ByVal top As Integer, ByVal width As Integer, ByVal height As Integer, ByVal e As PaintEventArgs, ByVal ArrowColor As Color) Implements ISplitButtonRenderer.DrawArrow
				'Customize arrow as image
				Dim arrowImage As Image = Image.FromFile("../../arrow4.png")
				Dim imageRect As New Rectangle(left + 4, top + 14, width - 9, height - 28)
				e.Graphics.DrawImage(arrowImage, imageRect)

			End Sub

			#End Region

			#Region "ISplitButtonRenderer Members"

			Public Property SplitButton() As SplitButton Implements ISplitButtonRenderer.SplitButton
				Get
					Return splitButton_Renamed
				End Get
				Set(ByVal value As SplitButton)
					splitButton_Renamed = value
				End Set
			End Property

			#End Region
		End Class

		Private Sub splitButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles splitButton2.Click

		End Sub

		Private Sub splitButton2_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles splitButton2.MouseUp
			startcolor = Color.LightGreen
			endcolor = Color.Green
		End Sub

		Private Sub splitButton2_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles splitButton2.MouseDown
			startcolor = Color.DarkGoldenrod
			Me.Invalidate()
		End Sub
	End Class
End Namespace
