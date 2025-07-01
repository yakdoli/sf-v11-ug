#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

#Region "file using directives"

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Tools.XPMenus
#End Region

Namespace ScrollersFrame_2005
	Public Partial Class Form1
		Inherits Office2007Form
		Public Sub New()
			InitializeComponent()

			treeView3.ExpandAll()

			' Add controls to the scrollers here.
			Me.scrollersFrame2.HorizontalScroller.ControlsBefore.Add(buttonAdv3)
			Me.scrollersFrame2.VerticalScroller.ControlsAfter.Add(buttonAdv1)
			Me.scrollersFrame2.VerticalScroller.ControlsAfter.Add(buttonAdv2)
		End Sub

		#Region "Office 2007 Themes"
		Private Sub barItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem7.Click, barItem8.Click, barItem9.Click
			Dim bitem As BarItem = CType(sender, BarItem)
			UnCheckAll()

			Select Case bitem.Text
				Case "Blue"
					barItem7.Checked = True
					Me.ColorScheme = Office2007Theme.Blue
					Me.scrollersFrame2.OfficeColorScheme = Office2007ColorScheme.Blue
					Me.mainFrameBarManager1.Office2007Theme = Office2007Theme.Blue
					Me.BackColor = Color.FromArgb(246, 249, 254)
					Me.buttonAdv1.Office2007ColorScheme = Office2007Theme.Blue
                    Me.buttonAdv2.Office2007ColorScheme = Office2007Theme.Blue
                    Me.buttonAdv3.Office2007ColorScheme = Office2007Theme.Blue
					Me.gradientPanel1.BorderColor = Color.FromArgb(222, 231, 246)
				Case "Silver"
					barItem8.Checked = True
					Me.ColorScheme = Office2007Theme.Silver
					Me.scrollersFrame2.OfficeColorScheme = Office2007ColorScheme.Silver
					Me.mainFrameBarManager1.Office2007Theme = Office2007Theme.Silver
					Me.BackColor = Color.FromArgb(202, 207, 217)
					Me.buttonAdv1.Office2007ColorScheme = Office2007Theme.Silver
                    Me.buttonAdv2.Office2007ColorScheme = Office2007Theme.Silver
                    Me.buttonAdv3.Office2007ColorScheme = Office2007Theme.Silver
					Me.gradientPanel1.BorderColor = Color.Gray
				Case "Black"
                    barItem9.Checked = True
					Me.ColorScheme = Office2007Theme.Black
					Me.scrollersFrame2.OfficeColorScheme = Office2007ColorScheme.Black
					Me.mainFrameBarManager1.Office2007Theme = Office2007Theme.Black
					Me.BackColor = Color.FromArgb(113, 113, 113)
					Me.buttonAdv1.Office2007ColorScheme = Office2007Theme.Black
                    Me.buttonAdv2.Office2007ColorScheme = Office2007Theme.Black
                    Me.buttonAdv3.Office2007ColorScheme = Office2007Theme.Black
					Me.gradientPanel1.BorderColor = Color.LightGray
			End Select
		End Sub
		#End Region

		Private Sub UnCheckAll()
			Me.barItem7.Checked = False
			Me.barItem8.Checked = False
			Me.barItem9.Checked = False
		End Sub

		Private Sub buttonAdv3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv3.Click
			treeView3.CollapseAll()
		End Sub

	End Class
End Namespace