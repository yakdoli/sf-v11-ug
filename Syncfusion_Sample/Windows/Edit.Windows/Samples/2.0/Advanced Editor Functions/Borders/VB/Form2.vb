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

Namespace BordersDemo
	''' <summary>
	''' Summary description for Form2.
	''' </summary>
	Public Class Form2 : Inherits System.Windows.Forms.Form
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private Mainform As Form1
		Private textBox1 As System.Windows.Forms.TextBox
		Private textBox2 As System.Windows.Forms.TextBox
		Private textBox3 As System.Windows.Forms.TextBox
		Private textBox4 As System.Windows.Forms.TextBox
        Private groupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label1 As System.Windows.Forms.Label

		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New(ByVal form1 As Form1)
			'
			' Required for Windows Form Designer support
			'
			Mainform=form1
            InitializeComponent()
            Application.EnableVisualStyles()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
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
            Me.button1 = New System.Windows.Forms.Button
            Me.button2 = New System.Windows.Forms.Button
            Me.label2 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.textBox2 = New System.Windows.Forms.TextBox
            Me.textBox3 = New System.Windows.Forms.TextBox
            Me.textBox4 = New System.Windows.Forms.TextBox
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'button1
            '
            Me.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.button1.Location = New System.Drawing.Point(256, 96)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 23)
            Me.button1.TabIndex = 6
            Me.button1.Text = "Cancel"
            '
            'button2
            '
            Me.button2.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.button2.Location = New System.Drawing.Point(152, 96)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(75, 23)
            Me.button2.TabIndex = 5
            Me.button2.Text = "Accept"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.BackColor = System.Drawing.SystemColors.Control
            Me.label2.Location = New System.Drawing.Point(16, 28)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(113, 13)
            Me.label2.TabIndex = 5
            Me.label2.Text = "Starting Line Number *"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.BackColor = System.Drawing.SystemColors.Control
            Me.label3.Location = New System.Drawing.Point(16, 61)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(110, 13)
            Me.label3.TabIndex = 6
            Me.label3.Text = "Ending Line Number *"
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.BackColor = System.Drawing.SystemColors.Control
            Me.label4.Location = New System.Drawing.Point(234, 31)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(128, 13)
            Me.label4.TabIndex = 8
            Me.label4.Text = "Starting Column Number *"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.BackColor = System.Drawing.SystemColors.Control
            Me.label5.Location = New System.Drawing.Point(237, 62)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(125, 13)
            Me.label5.TabIndex = 11
            Me.label5.Text = "Ending Column Number *"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(136, 25)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(88, 20)
            Me.textBox1.TabIndex = 1
            '
            'textBox2
            '
            Me.textBox2.Location = New System.Drawing.Point(377, 28)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(88, 20)
            Me.textBox2.TabIndex = 2
            '
            'textBox3
            '
            Me.textBox3.Location = New System.Drawing.Point(136, 58)
            Me.textBox3.Name = "textBox3"
            Me.textBox3.Size = New System.Drawing.Size(87, 20)
            Me.textBox3.TabIndex = 3
            '
            'textBox4
            '
            Me.textBox4.Location = New System.Drawing.Point(377, 59)
            Me.textBox4.Name = "textBox4"
            Me.textBox4.Size = New System.Drawing.Size(88, 20)
            Me.textBox4.TabIndex = 4
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.Label1)
            Me.groupBox1.Controls.Add(Me.textBox3)
            Me.groupBox1.Controls.Add(Me.label5)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.textBox1)
            Me.groupBox1.Controls.Add(Me.textBox4)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.textBox2)
            Me.groupBox1.Controls.Add(Me.button2)
            Me.groupBox1.Controls.Add(Me.button1)
            Me.groupBox1.Location = New System.Drawing.Point(5, 1)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(475, 128)
            Me.groupBox1.TabIndex = 17
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Enter Text Range"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(18, 101)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(111, 13)
            Me.Label1.TabIndex = 12
            Me.Label1.Text = "* All fields are required"
            '
            'Form2
            '
            Me.AcceptButton = Me.button2
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.CancelButton = Me.button1
            Me.ClientSize = New System.Drawing.Size(484, 133)
            Me.Controls.Add(Me.groupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "Form2"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Text Range Input Dialog"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			Me.Close()
		End Sub


		Public ReadOnly Property startLine() As Integer
            Get
                If Me.textBox1.Text <> "" Then
                    Return Integer.Parse(Me.textBox1.Text)
                Else
                    Return 1
                End If
            End Get
		End Property

		Public ReadOnly Property endLine() As Integer
            Get
                If Me.textBox3.Text <> "" Then
                    Return Integer.Parse(Me.textBox3.Text)
                Else
                    Return 1
                End If
            End Get
		End Property
		Public ReadOnly Property startColumn() As Integer
            Get
                If Me.textBox2.Text <> "" Then
                    Return Integer.Parse(Me.textBox2.Text)
                Else
                    Return 2
                End If
            End Get
		End Property
		Public ReadOnly Property endColumn() As Integer
            Get
                If Me.textBox4.Text <> "" Then
                    Return Integer.Parse(Me.textBox4.Text)
                Else
                    Return 1
                End If
            End Get
		End Property

		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
			Me.Close()

		End Sub

		Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Me.textBox1.Focus()
		End Sub





	End Class
End Namespace
