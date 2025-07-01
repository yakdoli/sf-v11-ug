Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms

Namespace EssentialBlocks
	Public Partial Class AboutForm
		Inherits Office2007Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles closeBtn.Click
			Me.Close()
		End Sub
	End Class
End Namespace