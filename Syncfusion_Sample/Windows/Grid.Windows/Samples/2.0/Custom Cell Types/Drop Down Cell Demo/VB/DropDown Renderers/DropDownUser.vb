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
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid

Namespace DropDownCellDemo
	''' <summary>
	''' Summary description for DropDownUser.
	''' </summary>
	Public Class DropDownUser
		Inherits System.Windows.Forms.UserControl
		Public Event UserControlSave As EventHandler
		Public Event UserControlCancel As EventHandler

		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents cancelButton As System.Windows.Forms.Button
		Private WithEvents okButton As System.Windows.Forms.Button
		Private WithEvents checkedListBox1 As System.Windows.Forms.CheckedListBox
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Private initDone As Boolean = False

		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()

			' This is the user control  class that is used in the drop down cell.
			' Besides the CheckedListBox and buttons, it these members added:
			'
			' 1) public method SetValuesFromString that accepts a string and
			'    sets the string to set the CheckedListValues appropriately.
			' 2) public method GetValuesToString that returns the CheckedList
			'    values as a comma separated string.
			' 3) Events UserControlSave and UserControlCancel that indicate
			'    how the user chooses to leave the user control.
			' 3) OK.Cancel button event handlers that fires 
			'    UserControlSave/UserControlSave events to indicate 
			'    which button was clicked.
			' 4) A checkedlistbox ItemCheck event handler to flag when a 
			'    change was made.

			initDone = True
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

		#Region "Component Designer generated code"
		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.cancelButton = New System.Windows.Forms.Button()
			Me.okButton = New System.Windows.Forms.Button()
			Me.checkedListBox1 = New System.Windows.Forms.CheckedListBox()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CByte(255)), (CByte(233)), (CByte(184)))
			Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel1.Controls.Add(Me.cancelButton)
			Me.panel1.Controls.Add(Me.okButton)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panel1.Location = New System.Drawing.Point(3, 109)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(154, 48)
			Me.panel1.TabIndex = 2
			' 
			' cancelButton
			' 
			Me.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.cancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cancelButton.Location = New System.Drawing.Point(9, 11)
			Me.cancelButton.Name = "cancelButton"
			Me.cancelButton.Size = New System.Drawing.Size(59, 23)
			Me.cancelButton.TabIndex = 1
			Me.cancelButton.Text = "Cancel"
'			Me.cancelButton.Click += New System.EventHandler(Me.cancelButton_Click)
			' 
			' okButton
			' 
			Me.okButton.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.okButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.okButton.Location = New System.Drawing.Point(80, 11)
			Me.okButton.Name = "okButton"
			Me.okButton.Size = New System.Drawing.Size(64, 23)
			Me.okButton.TabIndex = 0
			Me.okButton.Text = "OK"
'			Me.okButton.Click += New System.EventHandler(Me.okButton_Click)
			' 
			' checkedListBox1
			' 
			Me.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.checkedListBox1.Items.AddRange(New Object() { "choice1", "choice2", "choice3", "choice4", "choice5", "choice6"})
			Me.checkedListBox1.Location = New System.Drawing.Point(3, 3)
			Me.checkedListBox1.Name = "checkedListBox1"
			Me.checkedListBox1.Size = New System.Drawing.Size(154, 152)
			Me.checkedListBox1.TabIndex = 3
'			Me.checkedListBox1.ItemCheck += New System.Windows.Forms.ItemCheckEventHandler(Me.checkedListBox1_ItemCheck)
			' 
			' DropDownUser
			' 
			Me.BackColor = System.Drawing.Color.FromArgb((CByte(102)), (CByte(110)), (CByte(152)))
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.checkedListBox1)
			Me.DockPadding.All = 3
			Me.Name = "DropDownUser"
			Me.Size = New System.Drawing.Size(160, 160)
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Public Sub SetValuesFromString(ByVal val As String)
			Dim temp As String = ","c & val & ","c 'make everything stars and ends with delimiter

			For i As Integer = 0 To Me.checkedListBox1.Items.Count - 1
				Dim s As String = Me.checkedListBox1.Items(i).ToString()
				Me.checkedListBox1.SetItemChecked(i, temp.IndexOf(","c & s & ","c) > -1)
			Next i
			changed = False
		End Sub

		Public Function GetValuesToString() As String
			Dim val As String = "" 'make everything stars and ends with delimiter
			Dim i As Integer = 0
			For Each s As Object In Me.checkedListBox1.Items
				If Me.checkedListBox1.GetItemChecked(i) Then
					If val.Length > 0 Then
						val &= ","c
					End If
					val &= s.ToString()
				End If
				i += 1
			Next s
			Return val
		End Function

		Private Sub cancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cancelButton.Click
			changed = False
			RaiseEvent UserControlCancel(Me, EventArgs.Empty)
		End Sub

		Private Sub okButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles okButton.Click
			Dim saveChanged As Boolean = Me.changed
			Me.changed = False
			If saveChanged AndAlso UserControlSaveEvent IsNot Nothing Then
				RaiseEvent UserControlSave(Me, EventArgs.Empty)
			ElseIf UserControlCancelEvent IsNot Nothing Then
				RaiseEvent UserControlCancel(Me, EventArgs.Empty)
			End If
		End Sub

		'used to indicate changes to the values
		Private changed As Boolean = False
		Private Sub checkedListBox1_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles checkedListBox1.ItemCheck
			If Not Me.initDone Then
				Return
			End If

			changed = True
		End Sub

	End Class
End Namespace
