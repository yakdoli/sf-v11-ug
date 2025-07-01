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
Imports Syncfusion.Windows.Forms.Tools

Namespace MessageBoxAdv_2005
	Public Partial Class MainForm
		Inherits Office2007Form
		#Region "Constructor"
		Public Sub New()
			InitializeComponent()
			Me.comboBoxAdv2.SelectedIndex = 0

			Me.comboBoxAdv1.SelectedIndex = 0



		End Sub
		#End Region

		#Region "Events"


		#Region "Color Schemes"
		Private Sub radioButtonAdv1_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv1.CheckChanged
			MessageBoxAdv.Office2007Theme = Office2007Theme.Blue
		End Sub
		Private Sub radioButtonAdv2_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv2.CheckChanged
			MessageBoxAdv.Office2007Theme = Office2007Theme.Silver
		End Sub
		Private Sub radioButtonAdv3_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv3.CheckChanged
			MessageBoxAdv.Office2007Theme = Office2007Theme.Black
		End Sub
		Private Sub radioButtonAdv4_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv4.CheckChanged
			MessageBoxAdv.Office2007Theme = Office2007Theme.Managed
			Office2007Colors.ApplyManagedColors(Me, messageBoxColor)
			Me.ColorScheme = Office2007Theme.Blue
		End Sub
		#End Region


		#Region "Custom Color Schemes"

		Private messageBoxColor As Color

		Private Sub colorPickerUIAdv1_Picked(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs) Handles colorPickerUIAdv1.Picked
			messageBoxColor = args.Color
			If Me.radioButtonAdv4.Checked Then
				MessageBoxAdv.Office2007Theme = Office2007Theme.Managed
				Office2007Colors.ApplyManagedColors(Me, messageBoxColor)
			End If

			Me.ColorScheme = Office2007Theme.Blue
			Me.gradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() { Color.WhiteSmoke, messageBoxColor,messageBoxColor, Color.WhiteSmoke})
			' Ensures that the PopupControlContainer is closed after the selection of a color.
			Dim cc As ColorPickerUIAdv = TryCast(sender, ColorPickerUIAdv)
			Dim pcc As Syncfusion.Windows.Forms.PopupControlContainer = TryCast(cc.Parent, Syncfusion.Windows.Forms.PopupControlContainer)
			pcc.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done)
			Me.popupControlContainer1.Size = Me.colorPickerUIAdv1.Size
		End Sub



		Private Sub buttonAdv2_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles buttonAdv2.MouseUp
			Me.popupControlContainer1.ShowPopup(Point.Empty)
		End Sub
		#End Region

		#Region "Show MessageBoxAdv"
		Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv1.Click
			If Me.comboBoxAdv1.Enabled Then
				MessageBoxAdv.Show("MessageBoxAdv with Default Icon", "MessageBoxAdv " & MessageBoxAdv.Office2007Theme.ToString() & "Color Scheme", MessageBoxButtons.OK, CType(System.Enum.Parse(GetType(MessageBoxIcon), Me.comboBoxAdv1.SelectedItem.ToString(), True), MessageBoxIcon))
			Else
				Select Case Me.comboBoxAdv2.SelectedIndex
					Case 0
						MessageBoxAdv.Show("Please view Online UG for futher reference", "MessageBoxAdv " & MessageBoxAdv.Office2007Theme.ToString() & "Color Scheme", MessageBoxButtons.OK, Me.imageListAdv1.Images(0), New Size(24, 24))
					Case 1
						MessageBoxAdv.Show("Document Error. File format not supported", "MessageBoxAdv " & MessageBoxAdv.Office2007Theme.ToString() & "Color Scheme", MessageBoxButtons.OK, Me.imageListAdv1.Images(1), New Size(24, 24))
					Case 2
						MessageBoxAdv.Show("Warning. This operation is not supported", "MessageBoxAdv " & MessageBoxAdv.Office2007Theme.ToString() & "Color Scheme", MessageBoxButtons.OK, Me.imageListAdv1.Images(2), New Size(24, 24))

					Case 3
						MessageBoxAdv.Show("MessageBoxAdv supports Custom Colors and custom images", "MessageBoxAdv " & MessageBoxAdv.Office2007Theme.ToString() & "Color Scheme", MessageBoxButtons.OK)
				End Select
			End If
		End Sub
		#End Region


		Private Sub radioButtonAdv5_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv5.CheckChanged
			Me.comboBoxAdv1.Enabled = radioButtonAdv5.Checked
			Me.comboBoxAdv2.Enabled = Not radioButtonAdv5.Checked
		End Sub
		#End Region
	End Class
End Namespace