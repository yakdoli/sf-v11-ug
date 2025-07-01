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
Imports Syncfusion.Drawing

Namespace RibbonControlAdv_2005
	Partial Public Class DialogForm
		Inherits Office2007Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub gradientLabel3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gradientLabel3.Click
			Me.Hide()
        End Sub

        Public Sub UpdateFormControlColors(ByVal theme As Office2007Theme)
            Select Case theme
                Case Office2007Theme.Blue
                    Dim gradient As BrushInfo = New BrushInfo(GradientStyle.PathEllipse, Color.FromArgb(208, 226, 247), Color.FromArgb(237, 240, 247))
                    Me.gradientLabel1.BackgroundColor = gradient
                    Me.gradientLabel2.BackgroundColor = gradient
                    Me.gradientLabel3.BackgroundColor = gradient
                    Me.gradientPanel1.BackgroundColor = gradient
                Case Office2007Theme.Black
                    Dim gradient2 As BrushInfo = New BrushInfo(GradientStyle.PathEllipse, Color.FromArgb(181, 188, 198), Color.FromArgb(213, 221, 225))
                    Me.gradientLabel1.BackgroundColor = gradient2
                    Me.gradientLabel2.BackgroundColor = gradient2
                    Me.gradientLabel3.BackgroundColor = gradient2
                    Me.gradientPanel1.BackgroundColor = gradient2
                Case Office2007Theme.Silver
                    Dim gradient3 As BrushInfo = New BrushInfo(GradientStyle.PathEllipse, Color.FromArgb(214, 219, 231), Color.FromArgb(226, 231, 239))
                    Me.gradientLabel1.BackgroundColor = gradient3
                    Me.gradientLabel2.BackgroundColor = gradient3
                    Me.gradientLabel3.BackgroundColor = gradient3
                    Me.gradientPanel1.BackgroundColor = gradient3
            End Select
        End Sub

	End Class
End Namespace