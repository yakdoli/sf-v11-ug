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
Imports Syncfusion.Windows.Forms.Tools.XPMenus

Namespace Office2007Controls
	Partial Public Class Form1
        Inherits Office2007Form

        Private WithEvents trackBar As Syncfusion.Windows.Forms.Tools.TrackBarEx

#Region "Form's Constructor"
        Public Sub New()
            InitializeComponent()
            trackBar = Me.trackBarItem1.TrackBarExControl
            Me.comboBox1.SelectedIndex = 0
            Me.comboBox4.SelectedIndex = 0

            Me.statusStripEx1.Items("toolStripProgressBar1").Text = "Progress Bar"
            StatusStripLabel1.Text = StatusStripLabel1.Text & ": " & StatusStripLabel1.StatusString
            AddHandler statusStripEx1.ContextMenuStrip.Opening, AddressOf ContextMenuStrip_Opening
        End Sub
#End Region

		#Region "StatusStripEx"
       

        Private Sub ContextMenuStrip_Opening(ByVal sender As Object, ByVal e As CancelEventArgs)
            statusStripEx1.ContextMenuStrip.Items(0).Text = "Page"
            statusStripEx1.ContextMenuStrip.Items(1).Text = "Words"
        End Sub

#Region "Office2007ColorScheme"
        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
            If Me.comboBox1.SelectedIndex = 0 Then
                Me.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue
            End If
            If Me.comboBox1.SelectedIndex = 1 Then
                Me.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver
            End If
            If Me.comboBox1.SelectedIndex = 2 Then
                Me.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Black
            End If

        End Sub
#End Region

#Region "sizing Grip"
        Private Sub checkBoxAdv2_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv2.CheckStateChanged
            If Me.checkBoxAdv2.Checked Then
                Me.statusStripEx1.SizingGrip = True
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
            Else
                Me.statusStripEx1.SizingGrip = False
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
            End If

        End Sub
#End Region

#Region "RightToLeft"
        Private Sub checkBoxAdv3_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv3.CheckStateChanged
            If Me.checkBoxAdv3.Checked Then
                Me.statusStripEx1.RightToLeft = RightToLeft.Yes
            Else
                Me.statusStripEx1.RightToLeft = RightToLeft.No
            End If
        End Sub
#End Region


#End Region

#Region "TrackBarEx"

#Region "TrackBarColor"
        Private Sub buttonEdit1_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles buttonEdit1.ButtonClicked
            If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Me.buttonEdit1.BackColor = colorDialog1.Color
                Me.trackBarEx1.TrackBarGradientStart = colorDialog1.Color
            End If
        End Sub

        Private Sub buttonEdit3_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles buttonEdit3.ButtonClicked
            If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Me.buttonEdit3.BackColor = colorDialog1.Color
                Me.trackBarEx1.TrackBarGradientEnd = colorDialog1.Color
            End If
        End Sub
#End Region

#Region "ButtonColor"
        Private Sub buttonEdit2_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles buttonEdit2.ButtonClicked
            If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Me.buttonEdit2.BackColor = colorDialog1.Color
                Me.trackBarEx1.ButtonColor = colorDialog1.Color
            End If
        End Sub
#End Region

#Region "ShowButtons"
        Private Sub checkBoxAdv4_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv4.CheckStateChanged
            If Me.checkBoxAdv4.Checked Then
                Me.trackBarEx1.ShowButtons = True

            Else
                Me.trackBarEx1.ShowButtons = False
            End If
        End Sub
#End Region

#Region "ButtonSize"

        Private Sub numericUpDownExt1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDownExt1.ValueChanged
            Me.trackBarEx1.DecreaseButtonSize = New Size(Convert.ToInt16(Me.numericUpDownExt1.Value), Convert.ToInt16(Me.numericUpDownExt1.Value))
        End Sub

        Private Sub numericUpDownExt2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDownExt2.ValueChanged
            Me.trackBarEx1.IncreaseButtonSize = New Size(Convert.ToInt16(Me.numericUpDownExt2.Value), Convert.ToInt16(Me.numericUpDownExt2.Value))
        End Sub
#End Region


#Region "TrackBarEx Right to left"
        Private Sub checkBoxAdv5_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv5.CheckStateChanged
            If Me.checkBoxAdv5.Checked Then
                Me.trackBarEx1.RightToLeft = RightToLeft.Yes
            Else
                Me.trackBarEx1.RightToLeft = RightToLeft.No
            End If
        End Sub
#End Region

#End Region



#Region "ContextMenuStripEx"
#Region "ContextMenuStripEx_RightToLeft"
        Private Sub checkBoxAdv1_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv1.CheckStateChanged
            If Me.checkBoxAdv1.Checked Then
                Me.contextMenuStripEx1.RightToLeft = RightToLeft.Yes
            Else
                Me.contextMenuStripEx1.RightToLeft = RightToLeft.No
            End If
        End Sub
#End Region

#Region "Header"
        Private Sub textBoxExt1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBoxExt1.TextChanged
            Me.contextMenuStripEx1.Text = Me.textBoxExt1.Text
        End Sub
#End Region

#Region "Office2007Color"
        Private Sub comboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox4.SelectedIndexChanged

            If Me.comboBox4.SelectedIndex = 0 Then
                If Me.textBoxExt1.Text = String.Empty Then
                    Me.contextMenuStripEx1.Text = "Blue"
                End If
                Me.contextMenuStripEx1.Renderer = New Office12ToolStripRenderer(New OfficeBlue())
            End If
            If Me.comboBox4.SelectedIndex = 1 Then
                If Me.textBoxExt1.Text = String.Empty Then
                    Me.contextMenuStripEx1.Text = "Black"
                End If
                Me.contextMenuStripEx1.Renderer = New Office12ToolStripRenderer(New OfficeBlack())
            End If
            If Me.comboBox4.SelectedIndex = 2 Then
                If Me.textBoxExt1.Text = String.Empty Then
                    Me.contextMenuStripEx1.Text = "Silver"
                End If
                Me.contextMenuStripEx1.Renderer = New Office12ToolStripRenderer(New Office12ColorTable())
            End If
        End Sub
#End Region

#Region " DropShadow"

        Private Sub checkBoxAdv6_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv6.CheckStateChanged
            Me.contextMenuStripEx1.DropShadowEnabled = Me.checkBoxAdv6.Checked
        End Sub
#End Region





#End Region



        Private Sub trackBar_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBar.Scroll
            Me.statusLabel.Text = trackBar.Value.ToString() + "%"
        End Sub

        Private Sub trackBarEx1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trackBarEx1.Scroll
            Me.TextBox1.Text = trackBarEx1.Value.ToString()
        End Sub
    End Class
End Namespace