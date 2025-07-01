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
Imports Syncfusion.Windows.Forms.Tools

Namespace RibbonControlMerging
	Partial Public Class Form1
		Inherits RibbonForm
		#Region "Form Constructor"
		Public Sub New()
			InitializeComponent()

		End Sub
		#End Region

#Region "Loading Child Form"
        Private Sub toolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton1.Click
            Dim frm As Form2 = New Form2()
            frm.MdiParent = Me
            frm.Show()
        End Sub
#End Region

       
    End Class
End Namespace