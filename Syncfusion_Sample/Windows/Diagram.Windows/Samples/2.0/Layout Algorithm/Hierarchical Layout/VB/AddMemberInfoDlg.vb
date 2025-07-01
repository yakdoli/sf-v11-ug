Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2012"
'
'  Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
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
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram

	''' <summary>
	''' Summary description for OrgMemberInfoDlg.
	''' </summary>
	Public Class AddMemberInfoDlg
		Inherits Office2007Form
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private WithEvents btnCancel As System.Windows.Forms.Button
		Private WithEvents btnOk As System.Windows.Forms.Button
		Private tbMemberName As System.Windows.Forms.TextBox
		Private tbTitle As System.Windows.Forms.TextBox
		Private label3 As System.Windows.Forms.Label
		Private comboBox1 As ComboBox
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New(ByVal nodes As NodeCollection)
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			For Each node As Node In nodes
				If Not(TypeOf node Is ConnectorBase) Then
					comboBox1.Items.Add(node.Name)
				End If
			Next node

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

		Public ReadOnly Property MemberName() As String
			Get
				Return Me.tbMemberName.Text
			End Get
		End Property

		Public ReadOnly Property Title() As String
			Get
				Return Me.tbTitle.Text
			End Get
		End Property

		Public ReadOnly Property ParentName() As String
			Get
				Return Me.comboBox1.SelectedItem.ToString()
			End Get
		End Property

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(AddMemberInfoDlg))
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.btnCancel = New System.Windows.Forms.Button()
			Me.btnOk = New System.Windows.Forms.Button()
			Me.tbMemberName = New System.Windows.Forms.TextBox()
			Me.tbTitle = New System.Windows.Forms.TextBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(3, 16)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(43, 16)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Name:"
			Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(3, 48)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(32, 16)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Role:"
			Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' btnCancel
			' 
			Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.btnCancel.Location = New System.Drawing.Point(112, 109)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New System.Drawing.Size(64, 24)
			Me.btnCancel.TabIndex = 5
			Me.btnCancel.Text = "Cancel"
'			Me.btnCancel.Click += New System.EventHandler(Me.btnCancel_Click)
			' 
			' btnOk
			' 
			Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.btnOk.Location = New System.Drawing.Point(40, 109)
			Me.btnOk.Name = "btnOk"
			Me.btnOk.Size = New System.Drawing.Size(46, 24)
			Me.btnOk.TabIndex = 4
			Me.btnOk.Text = "OK"
'			Me.btnOk.Click += New System.EventHandler(Me.btnOk_Click)
			' 
			' tbMemberName
			' 
			Me.tbMemberName.Location = New System.Drawing.Point(100, 15)
			Me.tbMemberName.Name = "tbMemberName"
			Me.tbMemberName.Size = New System.Drawing.Size(112, 20)
			Me.tbMemberName.TabIndex = 1
			' 
			' tbTitle
			' 
			Me.tbTitle.Location = New System.Drawing.Point(100, 46)
			Me.tbTitle.Name = "tbTitle"
			Me.tbTitle.Size = New System.Drawing.Size(112, 20)
			Me.tbTitle.TabIndex = 3
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(3, 76)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(83, 16)
			Me.label3.TabIndex = 6
			Me.label3.Text = "Parent Name:"
			Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' comboBox1
			' 
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Location = New System.Drawing.Point(100, 75)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(112, 21)
			Me.comboBox1.TabIndex = 7
			' 
			' AddMemberInfoDlg
			' 
			Me.AcceptButton = Me.btnOk
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.White
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New System.Drawing.Size(217, 136)
			Me.Controls.Add(Me.comboBox1)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.tbTitle)
			Me.Controls.Add(Me.tbMemberName)
			Me.Controls.Add(Me.btnOk)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "AddMemberInfoDlg"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Member Information"
'			Me.Load += New System.EventHandler(Me.OrgMemberInfoDlg_Load)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
			Me.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.Close()
		End Sub

		Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
			Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.Close()
		End Sub

		Private Sub OrgMemberInfoDlg_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Me.tbMemberName.Focus()
		End Sub
	End Class
