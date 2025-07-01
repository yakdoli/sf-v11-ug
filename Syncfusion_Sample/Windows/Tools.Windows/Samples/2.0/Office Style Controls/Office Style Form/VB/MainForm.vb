#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms

Namespace Office2007Form_2005
	Public Partial Class MainForm
		Inherits Office2007Form
		#Region "Constructor"
		Public Sub New()
			InitializeComponent()
			Me.checkBoxAdv3.Checked = True

			For Each str As String In System.Enum.GetNames(GetType(FontStyle))
				Me.comboBox3.Items.Add(str)
			Next str

			Me.comboBox3.SelectedIndex = 1
            Me.comboBox1.SelectedIndex = 0
            Me.ColorPickerButton1.SelectedColor = Color.Green
            Me.CaptionForeColor = Me.ColorPickerButton1.SelectedColor
            Me.ColorPickerButton1.SelectedAsText = True
		End Sub
		#End Region

		#Region "Themes"
		Private Sub radioButtonAdv1_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv1.CheckChanged
			Me.ColorScheme = Office2007Theme.Blue
			Me.BackColor = Color.FromArgb(241, 244, 254)

		End Sub

		Private Sub radioButtonAdv2_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv2.CheckChanged
			Me.ColorScheme = Office2007Theme.Silver
			Me.BackColor = Color.FromArgb(202, 207, 217)
		End Sub

		Private Sub radioButtonAdv3_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv3.CheckChanged
			Me.ColorScheme = Office2007Theme.Black
			Me.BackColor = Color.FromArgb(113, 113, 113)
		End Sub
		#End Region

		#Region "Help Button"
		Private Sub checkBoxAdv1_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv1.CheckStateChanged
			If Me.checkBoxAdv1.Checked Then
				Me.MaximizeBox = False
				Me.MinimizeBox = False
			Else
				Me.MaximizeBox = False
				Me.MinimizeBox = True
			End If

		End Sub
		#End Region 

		#Region "RightToLeft"

		Private Sub checkBoxAdv2_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv2.CheckStateChanged
			If Me.checkBoxAdv2.Checked Then
				Me.RightToLeft = RightToLeft.Yes
			Else
				Me.RightToLeft = RightToLeft.No
			End If
		End Sub
		#End Region

		#Region "Show Icon"
		Private Sub checkBoxAdv3_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv3.CheckStateChanged
			If Me.checkBoxAdv3.Checked Then
				Me.ShowIcon = True
			Else
				Me.ShowIcon = False
			End If
		End Sub
		#End Region

		#Region "Caption settings"
		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
			Select Case comboBox1.SelectedIndex
				Case 0
					Me.CaptionAlign = HorizontalAlignment.Left
				Case 1
					Me.CaptionAlign = HorizontalAlignment.Center
				Case 2
					Me.CaptionAlign = HorizontalAlignment.Right
			End Select
		End Sub

		Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox2.SelectedIndexChanged
			SetCaptionFont()
		End Sub

        Protected Sub SetCaptionFont()
            If Not (comboBox3.SelectedItem Is Nothing) Then
                Dim fs As FontStyle = CType(System.Enum.Parse(GetType(FontStyle), Me.comboBox3.SelectedItem.ToString(), True), FontStyle)
                Me.CaptionFont = New Font(Me.comboBox2.SelectedItem.ToString(), CInt(Fix(Me.numericUpDown1.Value)), fs)
            End If
        End Sub

		Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown1.ValueChanged
			SetCaptionFont()
		End Sub

		Private Sub comboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox3.SelectedIndexChanged
			SetCaptionFont()
        End Sub

        Private Sub ColorPickerButton1_ColorSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorPickerButton1.ColorSelected
            Me.CaptionForeColor = Me.ColorPickerButton1.SelectedColor
        End Sub
#End Region
        
    End Class
End Namespace