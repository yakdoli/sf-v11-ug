#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping

Namespace OutlookDemo
	''' <summary>
	''' Summary description for CurrentView.
	''' </summary>
	Public Class CurrentView
		Inherits System.Windows.Forms.Form
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents button3 As System.Windows.Forms.Button
		Private WithEvents button4 As System.Windows.Forms.Button
		Private WithEvents button5 As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private button7 As System.Windows.Forms.Button
		Private button8 As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private groupingGrid As GridGroupingControl
		Private cform As ContactsPaneForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New(ByVal frm As ContactsPaneForm)
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			cform=frm
			groupingGrid=frm.Grid
			SetFieldsLabel()
			SetGroupByLabel()
			SetSortLabel()
			SetFilterLabel()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
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
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			Me.button4 = New System.Windows.Forms.Button()
			Me.button5 = New System.Windows.Forms.Button()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.button7 = New System.Windows.Forms.Button()
			Me.button8 = New System.Windows.Forms.Button()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.BackColor = System.Drawing.SystemColors.Control
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button1.Location = New System.Drawing.Point(8, 16)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(128, 23)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Fields..."
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' button2
			' 
			Me.button2.BackColor = System.Drawing.SystemColors.Control
			Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button2.Location = New System.Drawing.Point(8, 48)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(128, 23)
			Me.button2.TabIndex = 1
			Me.button2.Text = "Group By..."
'			Me.button2.Click += New System.EventHandler(Me.button2_Click)
			' 
			' button3
			' 
			Me.button3.BackColor = System.Drawing.SystemColors.Control
			Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button3.Location = New System.Drawing.Point(8, 80)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(128, 23)
			Me.button3.TabIndex = 2
			Me.button3.Text = "Sort..."
'			Me.button3.Click += New System.EventHandler(Me.button3_Click)
			' 
			' button4
			' 
			Me.button4.BackColor = System.Drawing.SystemColors.Control
			Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button4.Location = New System.Drawing.Point(8, 112)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(128, 23)
			Me.button4.TabIndex = 3
			Me.button4.Text = "Filter..."
'			Me.button4.Click += New System.EventHandler(Me.button4_Click)
			' 
			' button5
			' 
			Me.button5.BackColor = System.Drawing.SystemColors.Control
			Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button5.Location = New System.Drawing.Point(8, 144)
			Me.button5.Name = "button5"
			Me.button5.Size = New System.Drawing.Size(128, 23)
			Me.button5.TabIndex = 4
			Me.button5.Text = "Format Columns..."
'			Me.button5.Click += New System.EventHandler(Me.button5_Click)
			' 
			' groupBox1
			' 
			Me.groupBox1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.groupBox1.Controls.Add(Me.label5)
			Me.groupBox1.Controls.Add(Me.label4)
			Me.groupBox1.Controls.Add(Me.label3)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Controls.Add(Me.button1)
			Me.groupBox1.Controls.Add(Me.button2)
			Me.groupBox1.Controls.Add(Me.button3)
			Me.groupBox1.Controls.Add(Me.button4)
			Me.groupBox1.Controls.Add(Me.button5)
			Me.groupBox1.Location = New System.Drawing.Point(8, 8)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(384, 176)
			Me.groupBox1.TabIndex = 6
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Description"
			' 
			' label5
			' 
			Me.label5.Location = New System.Drawing.Point(144, 152)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(224, 16)
			Me.label5.TabIndex = 9
			Me.label5.Text = "Conditional Font and Color Formatting"
			' 
			' label4
			' 
			Me.label4.Location = New System.Drawing.Point(144, 112)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(232, 24)
			Me.label4.TabIndex = 8
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(144, 80)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(232, 24)
			Me.label3.TabIndex = 7
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(144, 48)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(232, 24)
			Me.label2.TabIndex = 6
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(144, 16)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(232, 24)
			Me.label1.TabIndex = 5
			' 
			' button7
			' 
			Me.button7.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button7.BackColor = System.Drawing.SystemColors.Control
			Me.button7.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button7.Location = New System.Drawing.Point(232, 192)
			Me.button7.Name = "button7"
			Me.button7.TabIndex = 7
			Me.button7.Text = "OK"
			' 
			' button8
			' 
			Me.button8.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button8.BackColor = System.Drawing.SystemColors.Control
			Me.button8.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.button8.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button8.Location = New System.Drawing.Point(312, 192)
			Me.button8.Name = "button8"
			Me.button8.TabIndex = 8
			Me.button8.Text = "Cancel"
			' 
			' CurrentView
			' 
			Me.AcceptButton = Me.button7
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CByte(209)), (CByte(209)), (CByte(223)))
			Me.CancelButton = Me.button8
			Me.ClientSize = New System.Drawing.Size(402, 224)
			Me.Controls.Add(Me.button8)
			Me.Controls.Add(Me.button7)
			Me.Controls.Add(Me.groupBox1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "CurrentView"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "CurrentView"
			Me.groupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub SetFieldsLabel()
			Dim visibleCols As New System.Text.StringBuilder()
			For i As Integer = 0 To Me.groupingGrid.TableDescriptor.VisibleColumns.Count - 1
				Dim col As GridVisibleColumnDescriptor = Me.groupingGrid.TableDescriptor.VisibleColumns(i)
				If col IsNot Nothing Then
					If visibleCols.Length > 0 Then
						visibleCols.Append(", ")
					End If
					visibleCols.Append(col.Name)
				End If
			Next i
			Me.label1.Text = visibleCols.ToString()
		End Sub

		Private Sub SetGroupByLabel()
			Dim grps As New System.Text.StringBuilder()
			For Each scol As SortColumnDescriptor In groupingGrid.TableDescriptor.GroupedColumns
				If scol IsNot Nothing Then
					If grps.Length>0 Then
						grps.Append(", ")
					End If
					grps.Append(scol.Name & "(" & scol.SortDirection & ")")
				End If
			Next scol
			If grps.Length=0 Then
				Me.label2.Text="None"
			Else
				Me.label2.Text=grps.ToString()
			End If
		End Sub

		Private Sub SetSortLabel()
			Dim sortCols As New System.Text.StringBuilder()
			For Each scol As SortColumnDescriptor In groupingGrid.TableDescriptor.SortedColumns
				If scol IsNot Nothing Then
					If sortCols.Length>0 Then
						sortCols.Append(", ")
					End If
					sortCols.Append(scol.Name & "(" & scol.SortDirection & ")")
				End If
			Next scol
			If sortCols.Length=0 Then
				Me.label3.Text="None"
			Else
				Me.label3.Text=sortCols.ToString()
			End If
		End Sub
		Private Sub SetFilterLabel()
			Dim filters As New System.Text.StringBuilder()
			For Each filter As RecordFilterDescriptor In groupingGrid.TableDescriptor.RecordFilters
				If filter IsNot Nothing Then
					If filters.Length>0 Then
						filters.Append(", ")
					End If
					For Each cond As FilterCondition In filter.Conditions
					filters.Append(cond.FilterDescriptor.FieldDescriptor.Name & " " & cond.CompareOperator.ToString() & " " & cond.CompareValue.ToString())
					Next cond
				End If
			Next filter
			If filters.Length=0 Then
				Me.label4.Text="Off"
			Else
				Me.label4.Text=filters.ToString()
			End If
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			cform.barItem4.PerformClick()
			SetFieldsLabel()
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
			cform.barItem3.PerformClick()
			SetGroupByLabel()
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
			cform.barItem6.PerformClick()
			SetSortLabel()
		End Sub

		Private Sub button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button4.Click
			cform.barItem7.PerformClick()
			SetFilterLabel()
		End Sub

		Private Sub button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button5.Click
			Dim dlg As New FormatColumnsDialog(Me.groupingGrid)
			dlg.ShowDialog()
		End Sub
	End Class
End Namespace
