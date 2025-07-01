Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Namespace SkinManagerDemo_2008
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

		End Sub

		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
			Changed()
		End Sub
		Private ctrl As Control = Nothing
		Private Clicked As Boolean = False
		Public Sub Changed()

			If comboBox1.Text = "Form" Then
				ctrl = Me
				apply()
			ElseIf comboBox1.Text = "DockingManager" Then
				ctrl = Me.groupBar1
				If comboBox2.Text = "Office 2007 Blue" Then
					Me.dockingManager1.VisualStyle = VisualStyle.Office2007
					Me.dockingManager1.Office2007Theme = Office2007Theme.Blue
				End If
				If comboBox2.Text = "Office 2007 Black" Then
					Me.dockingManager1.VisualStyle = VisualStyle.Office2007
					Me.dockingManager1.Office2007Theme = Office2007Theme.Black
				End If
				If comboBox2.Text = "Office 2007 Silver" Then
					Me.dockingManager1.VisualStyle = VisualStyle.Office2007
					Me.dockingManager1.Office2007Theme = Office2007Theme.Silver
				End If
				If comboBox2.Text = "Managed" Then
					Me.dockingManager1.VisualStyle = VisualStyle.Office2007
					Me.dockingManager1.Office2007Theme = Office2007Theme.Managed
				End If
				apply()
			ElseIf comboBox1.Text = "Calculator" Then
				ctrl = Me.calculatorControl1
				apply()
			ElseIf comboBox1.Text = "Button" Then
				 apply()
			ElseIf comboBox1.Text = "GroupBar" Then
				ctrl = Me.groupBar1
				apply()
			End If





		End Sub

		Public Sub apply()
			 If comboBox2.Text = "Office 2007 Blue" Then
				SkinManager.SetVisualStyle(ctrl, VisualTheme.Office2007Blue)
				Clicked = False
				 If ctrl Is Me Then
				Me.BackColor = Color.LightBlue
				 End If
			 End If
			If comboBox2.Text = "Office 2007 Black" Then
				SkinManager.SetVisualStyle(ctrl, VisualTheme.Office2007Black)
				Clicked = False
				If ctrl Is Me Then
				Me.BackColor = Color.Gray
				End If
			End If
			If comboBox2.Text = "Office 2007 Silver" Then
				SkinManager.SetVisualStyle(ctrl, VisualTheme.Office2007Silver)
				Clicked = False
				If ctrl Is Me Then
				Me.BackColor = Color.LightGray
				End If
			End If
			If comboBox2.Text = "Managed" Then
				SkinManager.SetVisualStyle(ctrl, VisualTheme.Managed)
				Clicked = True
				comboBox1.Items.Add("Form")
			End If
		End Sub
		Private Sub comboBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.TextChanged
			SkinManager.SetVisualStyle(Me, VisualTheme.Office2007Blue)
			Changed()
		End Sub

		Private Sub comboBox2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox2.TextChanged
			SkinManager.SetVisualStyle(Me, VisualTheme.Office2007Blue)
			If Me.comboBox2.Text <> "Managed" Then
				Me.autoLabel1.Visible = False
			Else
				Me.autoLabel1.Visible = True
			End If
			Changed()
		End Sub

		Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As EventArgs)
			SkinManager.SetVisualStyle(Me, VisualTheme.Office2007Blue)

		End Sub

		Private Sub colorPickerUIAdv1_Picked(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs) Handles colorPickerUIAdv1.Picked
			If Clicked Then
				Office12ColorTable.ApplyManagedColors(Me, Me.colorPickerUIAdv1.SelectedColor)
			   ' this.BackColor = this.colorPickerUIAdv1.SelectedColor;
			End If
		End Sub

		Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox2.SelectedIndexChanged

		End Sub

		Private Sub autoLabel1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles autoLabel1.Click

		End Sub
	End Class
End Namespace
