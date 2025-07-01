#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
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

Namespace SuperToolTipDemo_2005
	Public Partial Class Form1
		Inherits Office2007Form
		Public Sub New()
			InitializeComponent()
			Me.ColorPickerUIAdv2.MoreColorsButton.Visible = False
            Me.ColorPickerUIAdv2.StateButton.Visible = False
            Me.ComboBox1.SelectedIndex = 0
		End Sub

		#Region "SuperToolTip Gradient Colors"
      

        Private Sub buttonAdv4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv4.Click
            Me.ColorPickerUIAdv2.UpdateControl()
            Me.ColorPickerUIAdv2.Invalidate(True)
            Me.popupControlContainer1.Height = Me.ColorPickerUIAdv2.Height
            ' +padding;
            Me.popupControlContainer1.Refresh()
            Me.popupControlContainer1.Update()
            Me.popupControlContainer1.Invalidate(True)
            Me.Refresh()
            Me.popupControlContainer1.ShowPopup(Point.Empty)
        End Sub
#End Region

		#Region "SuperToolTip through Code"
		' To add a toolTip through code
        Private toolTipInfothroughCode As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
        Private Sub textBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textBox1.TextChanged, textBox3.TextChanged, textBox2.TextChanged
            toolTipInfothroughCode.BackColor = Color.Bisque
            toolTipInfothroughCode.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            
                toolTipInfothroughCode.Header.Text = Me.textBox1.Text
           
                toolTipInfothroughCode.Body.Text = Me.textBox2.Text
           
                toolTipInfothroughCode.Footer.Text = Me.textBox3.Text
          
            toolTipInfothroughCode.Header.TextAlign = ContentAlignment.MiddleCenter
        End Sub
        Private Sub gradientLabel6_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles gradientLabel6.MouseHover
            Me.superToolTip1.SetToolTip(Me.gradientLabel6, toolTipInfothroughCode)
        End Sub
	   #End Region

		#Region "Custom region"
		' To show the tooltip in a custom location use 'PopupToolTip' event.
		' NOTE: You cannot handle this event for tooltips created through code.
        Private Sub superToolTip1_PopupToolTip1(ByVal component As System.ComponentModel.Component, ByRef rc As System.Drawing.Rectangle) Handles superToolTip1.PopupToolTip
            If component Is Label4 Then
                rc.X = rc.X - 260
                rc.Y = rc.Y - 220
            End If

        End Sub
#End Region

        Private Sub aboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aboutToolStripMenuItem.Click
            Dim abtForm As DemoCommon.AboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
            abtForm.ShowDialog()
        End Sub

        Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
            If Me.CheckBox1.Checked Then
				Me.RightToLeft = Windows.Forms.RightToLeft.Yes
                Me.superToolTip1.RightToLeft = Windows.Forms.RightToLeft.Yes
            Else
				Me.RightToLeft = Windows.Forms.RightToLeft.No
                Me.superToolTip1.RightToLeft = Windows.Forms.RightToLeft.No
            End If


        End Sub

        Private Sub ColorPickerUIAdv2_Picked(ByVal sender As System.Object, ByVal args As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs) Handles ColorPickerUIAdv2.Picked
            Dim toolTipInfo29 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
            ' assign the color
            toolTipInfo29.BackColor = args.Color

            toolTipInfo29.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            toolTipInfo29.Header.Text = "SuperToolTip with " & Constants.vbCrLf & "Gradient Look And Feel"
            toolTipInfo29.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            toolTipInfo29.Header.TextMargin = New System.Windows.Forms.Padding(5)
            toolTipInfo29.Body.Text = "Select a color to experience the" & Constants.vbCrLf & "Gradient look and feel of SuperTooltip."
            toolTipInfo29.Body.TextMargin = New System.Windows.Forms.Padding(5)
            toolTipInfo29.Footer.Text = "Appealing look and feel with various " & Constants.vbCrLf & "gradient colors."
            toolTipInfo29.Footer.TextMargin = New System.Windows.Forms.Padding(5)

            ' To assign the created tooltip to a control.
            Me.superToolTip1.SetToolTip(Me.buttonAdv4, toolTipInfo29)
            Me.popupControlContainer1.HidePopup(PopupCloseType.Done)
        End Sub

        Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
            Select Case TryCast(Me.ComboBox1.SelectedItem, String)
                Case "Normal"
                    Me.superToolTip1.Style = SuperToolTip.SuperToolTipStyle.Normal
                Case "Balloon"
                    Me.superToolTip1.Style = SuperToolTip.SuperToolTipStyle.Balloon
            End Select
        End Sub
    End Class
End Namespace