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

Namespace OutlookDemo
	''' <summary>
	''' Summary description for GroupByDialog.
	''' </summary>
	Public Class GroupByDialog
		Inherits System.Windows.Forms.Form
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private comboBox1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
		Private radioButton2 As System.Windows.Forms.RadioButton
		Private checkBox2 As System.Windows.Forms.CheckBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private comboBox2 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private checkBox3 As System.Windows.Forms.CheckBox
		Private WithEvents radioButton3 As System.Windows.Forms.RadioButton
		Private radioButton4 As System.Windows.Forms.RadioButton
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private comboBox3 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private checkBox4 As System.Windows.Forms.CheckBox
		Private WithEvents radioButton5 As System.Windows.Forms.RadioButton
		Private radioButton6 As System.Windows.Forms.RadioButton
		Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
		Private button2 As Syncfusion.Windows.Forms.ButtonAdv
		Private label1 As System.Windows.Forms.Label
		Private comboBox4 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Private grpCols() As String
		Private sortDir() As ListSortDirection
		Public Sub New(ByVal vCols() As String)
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			For i As Integer = 1 To vCols.Length - 1
				Me.comboBox1.Items.Add(vCols(i))
				Me.comboBox2.Items.Add(vCols(i))
				Me.comboBox3.Items.Add(vCols(i))
			Next i
			Me.comboBox4.SelectedIndex=0
			grpCols = New String(2){}
			sortDir = New ListSortDirection(2){}

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Public ReadOnly Property GroupByCols() As String()
			Get
				Return grpCols
			End Get
		End Property
		Public ReadOnly Property View() As String
			Get
				Return Me.comboBox4.SelectedItem.ToString()
			End Get
		End Property
		Public ReadOnly Property Direction() As ListSortDirection()
			Get
				Return sortDir
			End Get
		End Property
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
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.radioButton2 = New System.Windows.Forms.RadioButton()
			Me.radioButton1 = New System.Windows.Forms.RadioButton()
			Me.comboBox1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.checkBox2 = New System.Windows.Forms.CheckBox()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.radioButton4 = New System.Windows.Forms.RadioButton()
			Me.radioButton3 = New System.Windows.Forms.RadioButton()
			Me.checkBox3 = New System.Windows.Forms.CheckBox()
			Me.comboBox2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.radioButton6 = New System.Windows.Forms.RadioButton()
			Me.radioButton5 = New System.Windows.Forms.RadioButton()
			Me.checkBox4 = New System.Windows.Forms.CheckBox()
			Me.comboBox3 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.button2 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.label1 = New System.Windows.Forms.Label()
			Me.comboBox4 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.groupBox1.SuspendLayout()
			CType(Me.comboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox2.SuspendLayout()
			CType(Me.comboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox3.SuspendLayout()
			CType(Me.comboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.radioButton2)
			Me.groupBox1.Controls.Add(Me.radioButton1)
			Me.groupBox1.Controls.Add(Me.comboBox1)
			Me.groupBox1.Controls.Add(Me.checkBox2)
			Me.groupBox1.Location = New System.Drawing.Point(8, 8)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(312, 64)
			Me.groupBox1.TabIndex = 0
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Group items by"
			' 
			' radioButton2
			' 
			Me.radioButton2.Location = New System.Drawing.Point(216, 40)
			Me.radioButton2.Name = "radioButton2"
			Me.radioButton2.Size = New System.Drawing.Size(88, 16)
			Me.radioButton2.TabIndex = 2
			Me.radioButton2.Text = "Descending"
			' 
			' radioButton1
			' 
			Me.radioButton1.Checked = True
			Me.radioButton1.Location = New System.Drawing.Point(216, 16)
			Me.radioButton1.Name = "radioButton1"
			Me.radioButton1.Size = New System.Drawing.Size(88, 24)
			Me.radioButton1.TabIndex = 1
			Me.radioButton1.TabStop = True
			Me.radioButton1.Text = "Ascending"
'			Me.radioButton1.CheckedChanged += New System.EventHandler(Me.radioButton1_CheckedChanged)
			' 
			' comboBox1
			' 
			Me.comboBox1.IgnoreThemeBackground = True
			Me.comboBox1.Items.AddRange(New Object() { "(none)"})
			Me.comboBox1.Location = New System.Drawing.Point(8, 16)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(200, 21)
			Me.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.comboBox1.SuppressDropDownEvent = False
			Me.comboBox1.TabIndex = 0
			Me.comboBox1.Text = "(none)"
			' 
			' checkBox2
			' 
			Me.checkBox2.Location = New System.Drawing.Point(8, 40)
			Me.checkBox2.Name = "checkBox2"
			Me.checkBox2.Size = New System.Drawing.Size(136, 16)
			Me.checkBox2.TabIndex = 2
			Me.checkBox2.Text = "Show field in view"
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.radioButton4)
			Me.groupBox2.Controls.Add(Me.radioButton3)
			Me.groupBox2.Controls.Add(Me.checkBox3)
			Me.groupBox2.Controls.Add(Me.comboBox2)
			Me.groupBox2.Location = New System.Drawing.Point(16, 80)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(312, 64)
			Me.groupBox2.TabIndex = 2
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Then by"
			' 
			' radioButton4
			' 
			Me.radioButton4.Location = New System.Drawing.Point(216, 40)
			Me.radioButton4.Name = "radioButton4"
			Me.radioButton4.Size = New System.Drawing.Size(88, 16)
			Me.radioButton4.TabIndex = 3
			Me.radioButton4.Text = "Descending"
			' 
			' radioButton3
			' 
			Me.radioButton3.Checked = True
			Me.radioButton3.Location = New System.Drawing.Point(216, 16)
			Me.radioButton3.Name = "radioButton3"
			Me.radioButton3.Size = New System.Drawing.Size(88, 24)
			Me.radioButton3.TabIndex = 2
			Me.radioButton3.TabStop = True
			Me.radioButton3.Text = "Ascending"
'			Me.radioButton3.CheckedChanged += New System.EventHandler(Me.radioButton3_CheckedChanged)
			' 
			' checkBox3
			' 
			Me.checkBox3.Location = New System.Drawing.Point(8, 40)
			Me.checkBox3.Name = "checkBox3"
			Me.checkBox3.Size = New System.Drawing.Size(152, 16)
			Me.checkBox3.TabIndex = 1
			Me.checkBox3.Text = "Show field in view"
			' 
			' comboBox2
			' 
			Me.comboBox2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(251))))))
			Me.comboBox2.IgnoreThemeBackground = True
			Me.comboBox2.Items.AddRange(New Object() { "(none)"})
			Me.comboBox2.Location = New System.Drawing.Point(8, 16)
			Me.comboBox2.Name = "comboBox2"
			Me.comboBox2.Size = New System.Drawing.Size(200, 21)
			Me.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.comboBox2.SuppressDropDownEvent = False
			Me.comboBox2.TabIndex = 0
			Me.comboBox2.Text = "(none)"
			' 
			' groupBox3
			' 
			Me.groupBox3.Controls.Add(Me.radioButton6)
			Me.groupBox3.Controls.Add(Me.radioButton5)
			Me.groupBox3.Controls.Add(Me.checkBox4)
			Me.groupBox3.Controls.Add(Me.comboBox3)
			Me.groupBox3.Location = New System.Drawing.Point(32, 152)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(312, 64)
			Me.groupBox3.TabIndex = 3
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "Then by"
			' 
			' radioButton6
			' 
			Me.radioButton6.Location = New System.Drawing.Point(216, 40)
			Me.radioButton6.Name = "radioButton6"
			Me.radioButton6.Size = New System.Drawing.Size(88, 16)
			Me.radioButton6.TabIndex = 3
			Me.radioButton6.Text = "Descending"
			' 
			' radioButton5
			' 
			Me.radioButton5.Checked = True
			Me.radioButton5.Location = New System.Drawing.Point(216, 16)
			Me.radioButton5.Name = "radioButton5"
			Me.radioButton5.Size = New System.Drawing.Size(88, 24)
			Me.radioButton5.TabIndex = 2
			Me.radioButton5.TabStop = True
			Me.radioButton5.Text = "Ascending"
'			Me.radioButton5.CheckedChanged += New System.EventHandler(Me.radioButton5_CheckedChanged)
			' 
			' checkBox4
			' 
			Me.checkBox4.Location = New System.Drawing.Point(8, 40)
			Me.checkBox4.Name = "checkBox4"
			Me.checkBox4.Size = New System.Drawing.Size(104, 16)
			Me.checkBox4.TabIndex = 1
			Me.checkBox4.Text = "Show field in view"
			' 
			' comboBox3
			' 
			Me.comboBox3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(251))))))
			Me.comboBox3.IgnoreThemeBackground = True
			Me.comboBox3.Items.AddRange(New Object() { "(none)"})
			Me.comboBox3.Location = New System.Drawing.Point(8, 16)
			Me.comboBox3.Name = "comboBox3"
			Me.comboBox3.Size = New System.Drawing.Size(200, 21)
			Me.comboBox3.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.comboBox3.SuppressDropDownEvent = False
			Me.comboBox3.TabIndex = 0
			Me.comboBox3.Text = "(none)"
			' 
			' button1
			' 
			Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.button1.BackColor = System.Drawing.SystemColors.Control
			Me.button1.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.button1.Location = New System.Drawing.Point(344, 8)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75, 23)
			Me.button1.TabIndex = 4
			Me.button1.Text = "OK"
			Me.button1.UseVisualStyle = True
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' button2
			' 
			Me.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.button2.BackColor = System.Drawing.SystemColors.Control
			Me.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.button2.Location = New System.Drawing.Point(344, 40)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(75, 23)
			Me.button2.TabIndex = 5
			Me.button2.Text = "Cancel"
			Me.button2.UseVisualStyle = True
			Me.button2.UseVisualStyleBackColor = False
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(72, 224)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(136, 16)
			Me.label1.TabIndex = 7
			Me.label1.Text = "Expand/collapse defaults:"
			' 
			' comboBox4
			' 
			Me.comboBox4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(251))))))
			Me.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.comboBox4.IgnoreThemeBackground = True
			Me.comboBox4.Items.AddRange(New Object() { "All expanded", "All collapsed"})
			Me.comboBox4.Location = New System.Drawing.Point(208, 224)
			Me.comboBox4.Name = "comboBox4"
			Me.comboBox4.Size = New System.Drawing.Size(208, 21)
			Me.comboBox4.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.comboBox4.SuppressDropDownEvent = False
			Me.comboBox4.TabIndex = 8
			' 
			' GroupByDialog
			' 
			Me.AcceptButton = Me.button1
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(255))))))
			Me.CancelButton = Me.button2
			Me.ClientSize = New System.Drawing.Size(424, 248)
			Me.Controls.Add(Me.comboBox4)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.groupBox3)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "GroupByDialog"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Group By"
			Me.groupBox1.ResumeLayout(False)
			CType(Me.comboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox2.ResumeLayout(False)
			CType(Me.comboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox3.ResumeLayout(False)
			CType(Me.comboBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBox4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			grpCols(0)=Me.comboBox1.SelectedItem.ToString()
			grpCols(1)=Me.comboBox2.SelectedItem.ToString()
			grpCols(2)=Me.comboBox3.SelectedItem.ToString()
		End Sub

		Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton1.CheckedChanged
			If radioButton1.Checked Then
				sortDir(0)=ListSortDirection.Ascending
			Else
				sortDir(0)=ListSortDirection.Descending
			End If
		End Sub

		Private Sub radioButton3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton3.CheckedChanged
			If radioButton3.Checked Then
				sortDir(1)=ListSortDirection.Ascending
			Else
				sortDir(1)=ListSortDirection.Descending
			End If
		End Sub

		Private Sub radioButton5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton5.CheckedChanged
			If radioButton5.Checked Then
				sortDir(2)=ListSortDirection.Ascending
			Else
				sortDir(2)=ListSortDirection.Descending
			End If
		End Sub
	End Class
End Namespace
