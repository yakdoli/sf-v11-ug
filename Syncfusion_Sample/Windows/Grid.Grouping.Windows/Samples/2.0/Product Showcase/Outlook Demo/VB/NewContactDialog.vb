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
	''' Summary description for NewContactDialog.
	''' </summary>
	Public Class NewContactDialog
		Inherits System.Windows.Forms.Form
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private textBox1 As System.Windows.Forms.TextBox
		Private textBox2 As System.Windows.Forms.TextBox
		Private textBox3 As System.Windows.Forms.TextBox
		Private textBox4 As System.Windows.Forms.TextBox
		Private textBox5 As System.Windows.Forms.TextBox
		Private textBox6 As System.Windows.Forms.TextBox
		Private button1 As System.Windows.Forms.Button
		Private button2 As System.Windows.Forms.Button
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Public ReadOnly Property ContactID() As String
			Get
				Return textBox1.Text
			End Get
		End Property
		Public ReadOnly Property CompName() As String
			Get
				Return textBox2.Text
			End Get
		End Property
		Public ReadOnly Property ContactTitle() As String
			Get
				Return textBox3.Text
			End Get
		End Property
		Public ReadOnly Property Address() As String
			Get
				Return textBox4.Text
			End Get
		End Property
		Public ReadOnly Property City() As String
			Get
				Return textBox5.Text
			End Get

		End Property
		Public ReadOnly Property Phone() As String
			Get
				Return textBox6.Text
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
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.textBox2 = New System.Windows.Forms.TextBox()
			Me.textBox3 = New System.Windows.Forms.TextBox()
			Me.textBox4 = New System.Windows.Forms.TextBox()
			Me.textBox5 = New System.Windows.Forms.TextBox()
			Me.textBox6 = New System.Windows.Forms.TextBox()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(0, 8)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(96, 24)
			Me.label1.TabIndex = 0
			Me.label1.Text = "ContactID"
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(0, 32)
			Me.label2.Name = "label2"
			Me.label2.TabIndex = 1
			Me.label2.Text = "CompanyName"
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(248, 8)
			Me.label3.Name = "label3"
			Me.label3.TabIndex = 2
			Me.label3.Text = "ContactTitle"
			' 
			' label4
			' 
			Me.label4.Location = New System.Drawing.Point(0, 56)
			Me.label4.Name = "label4"
			Me.label4.TabIndex = 3
			Me.label4.Text = "Address"
			' 
			' label5
			' 
			Me.label5.Location = New System.Drawing.Point(0, 80)
			Me.label5.Name = "label5"
			Me.label5.TabIndex = 4
			Me.label5.Text = "City"
			' 
			' label6
			' 
			Me.label6.Location = New System.Drawing.Point(0, 112)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(72, 23)
			Me.label6.TabIndex = 5
			Me.label6.Text = "Phone"
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(104, 8)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(136, 20)
			Me.textBox1.TabIndex = 6
			Me.textBox1.Text = ""
			' 
			' textBox2
			' 
			Me.textBox2.Location = New System.Drawing.Point(104, 32)
			Me.textBox2.Name = "textBox2"
			Me.textBox2.Size = New System.Drawing.Size(368, 20)
			Me.textBox2.TabIndex = 7
			Me.textBox2.Text = ""
			' 
			' textBox3
			' 
			Me.textBox3.Location = New System.Drawing.Point(352, 8)
			Me.textBox3.Name = "textBox3"
			Me.textBox3.Size = New System.Drawing.Size(120, 20)
			Me.textBox3.TabIndex = 8
			Me.textBox3.Text = ""
			' 
			' textBox4
			' 
			Me.textBox4.Location = New System.Drawing.Point(104, 56)
			Me.textBox4.Name = "textBox4"
			Me.textBox4.Size = New System.Drawing.Size(368, 20)
			Me.textBox4.TabIndex = 9
			Me.textBox4.Text = ""
			' 
			' textBox5
			' 
			Me.textBox5.Location = New System.Drawing.Point(104, 80)
			Me.textBox5.Name = "textBox5"
			Me.textBox5.Size = New System.Drawing.Size(208, 20)
			Me.textBox5.TabIndex = 10
			Me.textBox5.Text = ""
			' 
			' textBox6
			' 
			Me.textBox6.Location = New System.Drawing.Point(104, 112)
			Me.textBox6.Name = "textBox6"
			Me.textBox6.Size = New System.Drawing.Size(208, 20)
			Me.textBox6.TabIndex = 11
			Me.textBox6.Text = ""
			' 
			' button1
			' 
			Me.button1.BackColor = System.Drawing.SystemColors.Control
			Me.button1.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button1.Location = New System.Drawing.Point(320, 112)
			Me.button1.Name = "button1"
			Me.button1.TabIndex = 12
			Me.button1.Text = "OK"
			' 
			' button2
			' 
			Me.button2.BackColor = System.Drawing.SystemColors.Control
			Me.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button2.Location = New System.Drawing.Point(400, 112)
			Me.button2.Name = "button2"
			Me.button2.TabIndex = 13
			Me.button2.Text = "Cancel"
			' 
			' NewContactDialog
			' 
			Me.AcceptButton = Me.button1
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CByte(209)), (CByte(209)), (CByte(223)))
			Me.CancelButton = Me.button2
			Me.ClientSize = New System.Drawing.Size(480, 142)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.textBox6)
			Me.Controls.Add(Me.textBox5)
			Me.Controls.Add(Me.textBox4)
			Me.Controls.Add(Me.textBox3)
			Me.Controls.Add(Me.textBox2)
			Me.Controls.Add(Me.textBox1)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "NewContactDialog"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Add Contact"
			Me.ResumeLayout(False)

		End Sub
		#End Region

	End Class
End Namespace
