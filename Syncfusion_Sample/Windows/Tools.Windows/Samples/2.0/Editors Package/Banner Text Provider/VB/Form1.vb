Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms

Namespace BannerTextDemo_2005
	Public partial Class Form1 : Inherits Office2007Form
		Public Sub New()
			InitializeComponent()
			AddHandler Application.Idle, AddressOf Application_Idle
		End Sub

		Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
			ApplySelectedFont(Me.comboBoxBarItem1.TextBoxValue.ToString(), Me.comboBoxBarItem2.TextBoxValue.ToString())
		End Sub

		Private Sub ApplySelectedFont(ByVal fontname As String, ByVal fontsize As String)
			Dim size As Single = 8f
			If fontsize = "Small" Then
				size = 8f
			Else If fontsize = "Medium" Then
                size = 12.0F
			Else If fontsize = "Large" Then
                size = 16.0F
			End If

			Dim myFont As Font = New Font(fontname, size, FontStyle.Regular)
            For Each c As Control In groupBox1.Controls
                If TypeOf c Is Label Then
                    Continue For
                End If
                c.Font = New Font(fontname, size, FontStyle.Regular)
            Next c
            For Each c As Control In groupBox2.Controls
                If TypeOf c Is Label Then
                    Continue For
                End If
                c.Font = New Font(fontname, size, FontStyle.Regular)
            Next c
		End Sub
	End Class
End Namespace