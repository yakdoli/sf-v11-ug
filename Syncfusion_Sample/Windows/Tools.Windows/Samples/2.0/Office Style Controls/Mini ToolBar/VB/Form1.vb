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
Imports System.IO
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Namespace MiniToolBarDemo_2005
	Partial Public Class Form1
		Inherits Office2007Form
		#Region "Form Load And Constructor"
		Private pt As Point
		Public Sub New()
			InitializeComponent()

		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.richTextBox1.Text = ""
			Dim path As String = Application.StartupPath.ToString() & "..\..\..\Introduction.rtf"
			If File.Exists(path) Then
				Me.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText)
			End If

			'Associating MiniToolBar with the Controls
			Me.miniToolBar1.AssociatedControl = Me.textBox1
			Me.miniToolBar2.AssociatedControl = Me.richTextBox1
			Me.miniToolBar3.AssociatedControl = Me.gridControl1
		End Sub
#End Region

		#Region "Helper Methods"

		Private Sub tabControlAdv1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tabControlAdv1.SelectedIndexChanged
			If Me.tabControlAdv1.SelectedIndex = 1 Then
                Me.textBox1.Focus()
			End If
		End Sub
		Private Sub ToolStripButtonClickEvent(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton13.Click, toolStripButton14.Click, toolStripButton15.Click, toolStripButton16.Click, toolStripButton17.Click, toolStripButton18.Click, toolStripButton1.Click, toolStripButton2.Click, toolStripButton3.Click, toolStripButton4.Click, toolStripButton5.Click, toolStripButton6.Click, toolStripButton7.Click, toolStripButton8.Click, toolStripButton9.Click
			Dim tsb As ToolStripButton = TryCast(sender, ToolStripButton)
			Me.EventTrace(tsb.Text & " Clicked.")
		End Sub

		Private Sub EventTrace(ByVal text As String)
			Me.autoLabel1.Text = text

		End Sub

		Private Sub toolStripComboBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripComboBox1.Click
			Me.EventTrace(Me.toolStripComboBox1.Name & " Clicked.")

		End Sub

		#End Region

		#Region "MinToolBar in RichTextBox"
		Private Sub richTextBox1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles richTextBox1.MouseUp
			If Me.richTextBox1.SelectedText <> String.Empty AndAlso e.Button = MouseButtons.Left Then
				' MiniToolbar will be shown above the mouse cursor
				' when text in RTE is selected
				pt = New Point(e.X, e.Y - 70)

				' Use show method to display the miniToolBar.
				Me.miniToolBar2.Show(Me.richTextBox1, pt)
			End If
		End Sub
		#End Region

		#Region "MinToolBar in TextBox"
		Private Sub textBox1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles textBox1.MouseUp
			If Me.textBox1.SelectedText <> String.Empty AndAlso e.Button = MouseButtons.Left Then
				' MiniToolbar will be shown above the mouse cursor
				' when text in TextBox control is selected
				pt = New Point(e.X, e.Y - 70)

				' Use show method to display the miniToolBar.
				Me.miniToolBar1.Show(Me.textBox1, pt)
			End If
		End Sub
		#End Region

		#Region "ColorSchemes"
		Private Sub ColorToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton10.Click, toolStripButton11.Click, toolStripButton12.Click
			Dim toolStripButton As ToolStripButton = TryCast(sender, ToolStripButton)
			If toolStripButton Is Me.toolStripButton10 Then
				Me.gridControl1.GridVisualStyles = GridVisualStyles.Office2007Blue
				Me.gridControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue
			End If
			If toolStripButton Is Me.toolStripButton11 Then
				Me.gridControl1.GridVisualStyles = GridVisualStyles.Office2007Silver
				Me.gridControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver
			End If
			If toolStripButton Is Me.toolStripButton12 Then
				Me.gridControl1.GridVisualStyles = GridVisualStyles.Office2007Black
				Me.gridControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black
			End If
			Me.EventTrace(toolStripButton.Text & " Clicked.")
		End Sub
		#End Region


	End Class
End Namespace