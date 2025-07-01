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
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Imports Syncfusion.Windows.Forms.Tools

Namespace OutlookDemo
	''' <summary>
	''' Summary description for OptionsForm.
	''' </summary>
	Public Class OptionsForm : Inherits System.Windows.Forms.Form
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private WithEvents upButton As System.Windows.Forms.Button
		Private WithEvents downButton As System.Windows.Forms.Button
		Private WithEvents resetButton As System.Windows.Forms.Button
		Private WithEvents okButton As System.Windows.Forms.Button
		Private WithEvents cancelButton As System.Windows.Forms.Button
		Private WithEvents checkedListBox1 As System.Windows.Forms.CheckedListBox
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Private mainForm As OutlookDemo.Form1 = Nothing

		Public Sub New(ByVal mainfrm As Form1)
			Me.mainForm = mainfrm
			InitializeComponent()

			' Populate the checkedListBox with the GroupBarItems
			For Each item As GroupBarItem In Me.mainForm.GroupBarControl.GroupBarItems
				If item.Visible = True Then
					Me.checkedListBox1.Items.Add(item.Text, CheckState.Checked)
				Else
					Me.checkedListBox1.Items.Add(item.Text, CheckState.Unchecked)
				End If
			Next item
			Me.checkedListBox1.SelectedIndex = 0
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

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.upButton = New System.Windows.Forms.Button()
			Me.downButton = New System.Windows.Forms.Button()
			Me.resetButton = New System.Windows.Forms.Button()
			Me.okButton = New System.Windows.Forms.Button()
			Me.cancelButton = New System.Windows.Forms.Button()
			Me.checkedListBox1 = New System.Windows.Forms.CheckedListBox()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(8, 8)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(152, 23)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Display buttons in this order"
			' 
			' label2
			' 
			Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.label2.Location = New System.Drawing.Point(160, 16)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(148, 2)
			Me.label2.TabIndex = 1
			' 
			' upButton
			' 
			Me.upButton.Location = New System.Drawing.Point(232, 32)
			Me.upButton.Name = "upButton"
			Me.upButton.TabIndex = 2
			Me.upButton.Text = "Move Up"
'			Me.upButton.Click += New System.EventHandler(Me.upButton_Click);
			' 
			' downButton
			' 
			Me.downButton.Location = New System.Drawing.Point(232, 64)
			Me.downButton.Name = "downButton"
			Me.downButton.TabIndex = 3
			Me.downButton.Text = "Move Down"
'			Me.downButton.Click += New System.EventHandler(Me.downButton_Click);
			' 
			' resetButton
			' 
			Me.resetButton.Location = New System.Drawing.Point(232, 104)
			Me.resetButton.Name = "resetButton"
			Me.resetButton.TabIndex = 4
			Me.resetButton.Text = "Reset"
'			Me.resetButton.Click += New System.EventHandler(Me.resetButton_Click);
			' 
			' okButton
			' 
			Me.okButton.Location = New System.Drawing.Point(144, 144)
			Me.okButton.Name = "okButton"
			Me.okButton.TabIndex = 6
			Me.okButton.Text = "OK"
'			Me.okButton.Click += New System.EventHandler(Me.okButton_Click);
			' 
			' cancelButton
			' 
			Me.cancelButton.Location = New System.Drawing.Point(232, 144)
			Me.cancelButton.Name = "cancelButton"
			Me.cancelButton.TabIndex = 7
			Me.cancelButton.Text = "Cancel"
'			Me.cancelButton.Click += New System.EventHandler(Me.cancelButton_Click);
			' 
			' checkedListBox1
			' 
			Me.checkedListBox1.IntegralHeight = False
			Me.checkedListBox1.Location = New System.Drawing.Point(16, 32)
			Me.checkedListBox1.Name = "checkedListBox1"
			Me.checkedListBox1.Size = New System.Drawing.Size(209, 108)
			Me.checkedListBox1.TabIndex = 8
'			Me.checkedListBox1.SelectedIndexChanged += New System.EventHandler(Me.checkedListBox1_SelectedIndexChanged);
			' 
			' OptionsForm
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(312, 171)
			Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.checkedListBox1, Me.cancelButton, Me.okButton, Me.resetButton, Me.downButton, Me.upButton, Me.label2, Me.label1})
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "OptionsForm"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Navigation Pane Options"
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub okButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles okButton.Click
			' Compare the items order in the checkedListBox with that in the GroupBar's collection and if the two 
			' are not identical then perform a reinsertion of all GroupBarItems using the checkedListBox's order
			Dim breinsertitems As Boolean = False
			Dim itemstore As GroupBarItem() = New GroupBarItem(Me.mainForm.GroupBarControl.GroupBarItems.Count - 1) {}
			Dim index As Integer = 0
			For Each item As GroupBarItem In Me.mainForm.GroupBarControl.GroupBarItems
'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
'ORIGINAL LINE: itemstore[index += 1] = item;
                ' itemstore(index = index + 1) = item
                itemstore(index) = item
                index += 1

			Next item
			Dim i As Integer=0
'ORIGINAL LINE: for(int i=0; i<Me.checkedListBox1.Items.Count; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i<Me.checkedListBox1.Items.Count
				Dim itemtext As String = CType(IIf(TypeOf Me.checkedListBox1.Items(i) Is String, Me.checkedListBox1.Items(i), Nothing), String)
				If itemtext <> itemstore(i).Text Then
					Dim currentitem As GroupBarItem = itemstore(i)
					Dim newitempos As Integer=0
'ORIGINAL LINE: for(int newitempos=0; newitempos<Me.checkedListBox1.Items.Count; newitempos += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
					Do While newitempos<Me.checkedListBox1.Items.Count
						If itemstore(newitempos).Text = itemtext Then
							' Switch the currentitem and newitem positions in the mainform's GroupBarItemStore					
							Dim newitem As GroupBarItem = itemstore(newitempos)
							itemstore(i) = newitem
							itemstore(newitempos) = currentitem
							breinsertitems = True
							Exit Do
						End If
						newitempos += 1
					Loop
				End If
				i += 1
			Loop

			' Synchronize the GroupBarItem positions of the GroupBar control with the new GroupBarItem positions of the itemstore
			If breinsertitems = True Then
				' The number of items in the navigation pane should remain the same even after the insertion. Use the 
				' non-NavPane item count to ensure this.
				Dim nstackcount As Integer = 0
				For Each item As GroupBarItem In Me.mainForm.GroupBarControl.GroupBarItems
					If item.InNavigationPane = False Then
						nstackcount += 1
					End If
				Next item

				i = 0
'ORIGINAL LINE: for(int i=0; i<itemstore.GetLength(0); i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
				Do While i<itemstore.GetLength(0)
					Dim iteminstore As GroupBarItem = itemstore(i)
					Dim controlindex As Integer = Me.mainForm.GroupBarControl.GroupBarItems.IndexOf(iteminstore)
					If controlindex <> -1 Then
						' If the item is present in the GroupBar control but is in a different index than in the itemstore 
						' then remove the item from it's current position and reinsert at the itemstore position.
						Dim itemstorepos As Integer = i
						If itemstorepos >= Me.mainForm.GroupBarControl.GroupBarItems.Count Then
							itemstorepos = Me.mainForm.GroupBarControl.GroupBarItems.Count-1
						End If
						If controlindex <> itemstorepos Then
							Me.mainForm.GroupBarControl.GroupBarItems.Remove(iteminstore)
							Me.mainForm.GroupBarControl.GroupBarItems.Insert(itemstorepos, iteminstore)
						End If
					End If
					i += 1
				Loop

				' The GroupBarItem stack should contain only nstackcount items.
				For Each item As GroupBarItem In Me.mainForm.GroupBarControl.GroupBarItems
					If Me.mainForm.GroupBarControl.GroupBarItems.IndexOf(item) >= nstackcount Then
						item.InNavigationPane = True
					Else
						item.InNavigationPane = False
					End If
				Next item
			End If

			' If the visibility state of an item in the CheckedListBox has changed by checking/unchecking then 
			' apply the new state to the GroupBarItem			
			i = 0
'ORIGINAL LINE: for(int i=0; i<Me.checkedListBox1.Items.Count; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i<Me.checkedListBox1.Items.Count
				Dim itemtext As String = CType(IIf(TypeOf Me.checkedListBox1.Items(i) Is String, Me.checkedListBox1.Items(i), Nothing), String)
				For Each item As GroupBarItem In Me.mainForm.GroupBarControl.GroupBarItems
					If item.Text = itemtext Then
						If Me.checkedListBox1.GetItemChecked(i) = True Then
							If item.Visible = False Then
								item.Visible = True
							End If
						Else
							If item.Visible = True Then
								item.Visible = False
							End If
						End If
						Exit For
					End If
				Next item
				i += 1
			Loop

			Me.Close()
		End Sub

		Private Sub cancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cancelButton.Click
			Me.Close()
		End Sub

		Private Sub upButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles upButton.Click
            If Me.checkedListBox1.SelectedIndex >= 0 Then
                Dim currentposition As Integer = Me.checkedListBox1.SelectedIndex
                Dim currentitem As Object = Me.checkedListBox1.SelectedItem
                Dim state As CheckState = Me.checkedListBox1.GetItemCheckState(currentposition)
                Me.checkedListBox1.Items.Remove(currentitem)
                Me.checkedListBox1.Items.Insert(currentposition - 1, currentitem)
                Me.checkedListBox1.SetItemCheckState(currentposition - 1, state)
                Me.checkedListBox1.SelectedItem = currentitem
            Else
                MessageBox.Show("Select the item to be moved up")
            End If
		End Sub

		Private Sub downButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles downButton.Click
            If Me.checkedListBox1.SelectedIndex >= 0 Then
                Dim currentposition As Integer = Me.checkedListBox1.SelectedIndex
                Dim currentitem As Object = Me.checkedListBox1.SelectedItem
                Dim state As CheckState = Me.checkedListBox1.GetItemCheckState(currentposition)
                Me.checkedListBox1.Items.Remove(currentitem)
                Me.checkedListBox1.Items.Insert(currentposition + 1, currentitem)
                Me.checkedListBox1.SetItemCheckState(currentposition + 1, state)
                Me.checkedListBox1.SelectedItem = currentitem
            Else
                MessageBox.Show("Select the item to be moved down")
            End If
        End Sub

		Private Sub resetButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles resetButton.Click
			Me.checkedListBox1.Items.Clear()
			Dim itemsenumerator As IEnumerator = Me.mainForm.ItemStateStore
			itemsenumerator.Reset()
			Do While itemsenumerator.MoveNext()
				Dim itemstate As GroupBarItemState = CType(IIf(TypeOf itemsenumerator.Current Is GroupBarItemState, itemsenumerator.Current, Nothing), GroupBarItemState)
				Me.checkedListBox1.Items.Add(itemstate.ItemText, itemstate.Visible)
			Loop
		End Sub

		Private Sub checkedListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkedListBox1.SelectedIndexChanged
			If Me.checkedListBox1.SelectedIndex = 0 Then
				Me.upButton.Enabled = False
			Else
				Me.upButton.Enabled = True
			End If

			If Me.checkedListBox1.SelectedIndex = (Me.checkedListBox1.Items.Count-1) Then
				Me.downButton.Enabled = False
			Else
				Me.downButton.Enabled = True
			End If
		End Sub

	End Class
End Namespace
