#Region "Copyright Syncfusion Inc. 2001 - 2007"
'
'  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace ColumnGuidesDemo
	''' <summary>
	''' Summary description for Form2.
	''' </summary>
	Public Class ColumnGuidesEditor : Inherits System.Windows.Forms.Form
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private textBox1 As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private textBox2 As System.Windows.Forms.TextBox
		Public Shared columnnumber, color As String()
		Private colorchar As Char()
		Public Shared columnnumbers, colors As String
		Public Shared columncount, colorcount As Integer
		Private index As Integer, arrayindex As Integer=0
		Public Shared invalidinput As Boolean=False
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
            InitializeComponent()

            Me.AcceptButton.DialogResult = Windows.Forms.DialogResult.OK

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
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.label1 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.textBox2 = New System.Windows.Forms.TextBox
            Me.SuspendLayout()
            '
            'button1
            '
            Me.button1.Location = New System.Drawing.Point(181, 180)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 23)
            Me.button1.TabIndex = 2
            Me.button1.Text = "Submit"
            '
            'button2
            '
            Me.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.button2.Location = New System.Drawing.Point(277, 180)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(75, 23)
            Me.button2.TabIndex = 3
            Me.button2.Text = "Cancel"
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(16, 56)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(336, 20)
            Me.textBox1.TabIndex = 0
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.SystemColors.Control
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(15, 28)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(236, 13)
            Me.label1.TabIndex = 3
            Me.label1.Text = "Enter the column numbers separated by commas"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.BackColor = System.Drawing.SystemColors.Control
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(15, 111)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(300, 13)
            Me.label2.TabIndex = 5
            Me.label2.Text = "Enter the column guide colors (eg. Red) separated by commas"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'textBox2
            '
            Me.textBox2.Location = New System.Drawing.Point(16, 137)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(336, 20)
            Me.textBox2.TabIndex = 1
            '
            'ColumnGuidesEditor
            '
            Me.AcceptButton = Me.button1
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.CancelButton = Me.button2
            Me.ClientSize = New System.Drawing.Size(370, 217)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.textBox2)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.button1)
            Me.MaximizeBox = False
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "ColumnGuidesEditor"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Column Guides Editor"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
		#End Region

		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
			Me.Close()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			If Me.textBox1.Text<>"" AndAlso Me.textBox2.Text<>"" Then
				columncount=1
				arrayindex=0
				colorcount=1
				columnnumber = New String(9) {}
				color = New String(9) {}
				colorchar = New Char(14) {}
                Me.textBox1.Text = Me.textBox1.Text.Replace(" ", "")
                Me.textBox2.Text = Me.textBox2.Text.Replace(" ", "")

				columnnumbers=Me.textBox1.Text
				Do While True
					index=columnnumbers.LastIndexOf(",")
					If index<>-1 Then
                        columnnumber(arrayindex) = columnnumbers.Substring(index + 1)
                        columnnumbers = columnnumbers.Substring(0, index)
                        arrayindex += 1
                        columncount += 1
					Else
						columnnumber(arrayindex)=columnnumbers
						Exit Do
					End If
				Loop
                arrayindex = 0
                colors = Me.textBox2.Text.ToLower()

                Do While True
                    index = colors.LastIndexOf(",")
                    If index <> -1 Then
                        color(arrayindex) = colors.Substring(index + 1)
                        colorchar = color(arrayindex).ToCharArray()
                        If (colorchar.Length > 0) Then
                            color(arrayindex) = ((colorchar(0).ToString()).ToUpper())
                            color(arrayindex) = String.Concat(color(arrayindex), colors.Substring(index + 2))
                            arrayindex += 1
                            colors = colors.Substring(0, index)
                            colorcount += 1
                        Else
                            Exit Do
                        End If
                    Else
                        color(arrayindex) = colors
                        colorchar = color(arrayindex).ToCharArray()
                        color(arrayindex) = ((colorchar(0).ToString()).ToUpper())
                        color(arrayindex) = String.Concat(color(arrayindex), colors.Substring(1, colors.Length - 1))
                        Exit Do
                    End If
                Loop
                If columncount = colorcount Then
                    invalidinput = False
                    Me.Close()
                Else
                    MessageBox.Show("Number of Colors should be equal to the number of Columns")
                    invalidinput = True
                End If

            End If
		End Sub



	End Class
End Namespace
