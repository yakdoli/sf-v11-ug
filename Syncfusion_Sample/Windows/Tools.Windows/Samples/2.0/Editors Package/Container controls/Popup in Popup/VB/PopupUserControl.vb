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
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Namespace PopupControls
	''' <summary>
	''' Summary description for PopupUserControl.
	''' </summary>
  Public Class PopupUserControl : Inherits System.Windows.Forms.UserControl
	Private textBox1 As System.Windows.Forms.TextBox
	Private WithEvents button1 As System.Windows.Forms.Button
	Private components As System.ComponentModel.IContainer=Nothing

		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitForm call

		End Sub

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"
		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.button1 = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(16, 16)
			Me.textBox1.Multiline = True
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(160, 128)
			Me.textBox1.TabIndex = 0
			Me.textBox1.Text = "<<<  Enter Text >>>"
			' 
			' button1
			' 
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button1.Location = New System.Drawing.Point(24, 184)
			Me.button1.Name = "button1"
			Me.button1.TabIndex = 1
			Me.button1.Text = "OK"
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' PopupUserControl
			' 
			Me.BackColor = System.Drawing.Color.FromArgb((CByte(192)), (CByte(200)), (CByte(219)))
			Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.button1, Me.textBox1})
			Me.Name = "PopupUserControl"
			Me.Size = New System.Drawing.Size(224, 216)
			Me.ResumeLayout(False)

		End Sub
		#End Region

	  Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
		' Find my parent PopupControlContainer:
		If TypeOf Me.FindForm() Is PopupHost Then
			Dim pcc As PopupControlContainer = Nothing
			' Find the PopupControlContainer
			Dim c As Control
			For Each c In Me.FindForm().Controls
				If TypeOf c Is PopupControlContainer Then
					pcc = CType(IIf(TypeOf c Is PopupControlContainer, c, Nothing), PopupControlContainer)
					Exit For
				End If
			Next c
			' Need to do this only if the PopupControlContainer is currently showing
			If Not pcc Is Nothing AndAlso pcc.IsShowing() Then
				pcc.HidePopup(PopupCloseType.Done)
			End If
		End If
	  End Sub
  End Class
End Namespace
