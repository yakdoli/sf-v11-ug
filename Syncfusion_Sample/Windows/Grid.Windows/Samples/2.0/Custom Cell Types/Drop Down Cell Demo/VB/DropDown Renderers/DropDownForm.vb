Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace DropDownCellDemo
	''' <summary>
	''' Summary description for DropDownForm.
	''' </summary>
	Public Class DropDownForm
		Inherits System.Windows.Forms.Form
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents okButton As System.Windows.Forms.Button
'INSTANT VB NOTE: The variable cancelButton was renamed since Visual Basic does not allow class members with the same name:
		Private WithEvents cancelButton_Renamed As System.Windows.Forms.Button
		Private WithEvents checkedListBox1 As System.Windows.Forms.CheckedListBox
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			' This is the form class that is used in the drop down cell.
			' Besides the CheckedListBox and buttons, it these members added:
			'
			' 1) public method SetValuesFromString that accepts a string and
			'    sets the string to set the CheckedListValues appropriately.
			' 2) public method GetValuesToString that returns the CheckedList
			'    values as a comma separated string.
			' 3) Cancel and OK button event handlers that set the DialogResult 
			'    and closes the form.
			' 4) A KeyDown event handler that cancels the action if the user
			'    presses escape while the form is displayed.
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.cancelButton_Renamed = New System.Windows.Forms.Button()
			Me.okButton = New System.Windows.Forms.Button()
			Me.checkedListBox1 = New System.Windows.Forms.CheckedListBox()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(233))))), (CInt(Fix((CByte(184))))))
			Me.panel1.Controls.Add(Me.cancelButton_Renamed)
			Me.panel1.Controls.Add(Me.okButton)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panel1.Location = New System.Drawing.Point(0, 112)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(152, 40)
			Me.panel1.TabIndex = 0
			' 
			' cancelButton
			' 
			Me.cancelButton_Renamed.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.cancelButton_Renamed.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.cancelButton_Renamed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cancelButton_Renamed.Location = New System.Drawing.Point(8, 9)
			Me.cancelButton_Renamed.Name = "cancelButton"
			Me.cancelButton_Renamed.Size = New System.Drawing.Size(64, 23)
			Me.cancelButton_Renamed.TabIndex = 1
			Me.cancelButton_Renamed.Text = "Cancel"
'			Me.cancelButton.Click += New System.EventHandler(Me.cancelButton_Click)
'			Me.cancelButton.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.HandleKeyDown)
			' 
			' okButton
			' 
			Me.okButton.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.okButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.okButton.Location = New System.Drawing.Point(81, 9)
			Me.okButton.Name = "okButton"
			Me.okButton.Size = New System.Drawing.Size(64, 23)
			Me.okButton.TabIndex = 0
			Me.okButton.Text = "OK"
'			Me.okButton.Click += New System.EventHandler(Me.okButton_Click)
'			Me.okButton.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.HandleKeyDown)
			' 
			' checkedListBox1
			' 
			Me.checkedListBox1.BackColor = System.Drawing.SystemColors.Window
			Me.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.checkedListBox1.Items.AddRange(New Object() { "choice1", "choice2", "choice3", "choice4", "choice5", "choice6"})
			Me.checkedListBox1.Location = New System.Drawing.Point(0, 0)
			Me.checkedListBox1.Name = "checkedListBox1"
			Me.checkedListBox1.Size = New System.Drawing.Size(152, 109)
			Me.checkedListBox1.TabIndex = 1
'			Me.checkedListBox1.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.HandleKeyDown)
			' 
			' DropDownForm
			' 
			Me.AcceptButton = Me.okButton
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(152, 152)
			Me.ControlBox = False
			Me.Controls.Add(Me.checkedListBox1)
			Me.Controls.Add(Me.panel1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
			Me.Name = "DropDownForm"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
'			Me.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.HandleKeyDown)
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private delimeter As Char = ","c

		Public Sub SetValuesFromString(ByVal val As String)
			Dim temp As String = delimeter & val & delimeter 'make everything start and ends with delimiter

			For i As Integer = 0 To Me.checkedListBox1.Items.Count - 1
				Dim s As String = Me.checkedListBox1.Items(i).ToString()
				Me.checkedListBox1.SetItemChecked(i, temp.IndexOf(delimeter & s & delimeter) > -1)
			Next i
		End Sub

		Public Function GetValuesToString() As String
			Dim val As String = "" 'make everything stars and ends with delimiter
			Dim i As Integer = 0
			For Each s As Object In Me.checkedListBox1.Items
				If Me.checkedListBox1.GetItemChecked(i) Then
					If val.Length > 0 Then
						val &= delimeter
					End If
					val &= s.ToString()
				End If
				i += 1
			Next s
			Return val
		End Function

		Private Sub cancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cancelButton_Renamed.Click
			Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.Close()

		End Sub

		Private Sub okButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles okButton.Click
			Me.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.Close()

		End Sub

		Private Sub HandleKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cancelButton_Renamed.KeyDown, okButton.KeyDown, checkedListBox1.KeyDown, MyBase.KeyDown
			If e.KeyCode = Keys.Escape OrElse e.KeyCode = Keys.F4 Then
				Me.cancelButton_Renamed.PerformClick()
			End If
		End Sub
	End Class
End Namespace
