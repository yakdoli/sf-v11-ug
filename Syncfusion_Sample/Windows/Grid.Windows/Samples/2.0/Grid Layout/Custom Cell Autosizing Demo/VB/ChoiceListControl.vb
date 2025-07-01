Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace CustomCellAutoSizing
	''' <summary>
	''' Summary description for ChoiceListControl.
	''' </summary>
	Public Class ChoiceListControl
		Inherits System.Windows.Forms.UserControl
		Private panel1 As System.Windows.Forms.Panel
		Private checkedListBox1 As System.Windows.Forms.CheckedListBox
		Private label1 As System.Windows.Forms.Label
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitializeComponent call

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
			Me.label1 = New System.Windows.Forms.Label()
			Me.checkedListBox1 = New System.Windows.Forms.CheckedListBox()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CByte(223)), (CByte(247)), (CByte(252)))
			Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Controls.Add(Me.checkedListBox1)
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(144, 136)
			Me.panel1.TabIndex = 0
			' 
			' label1
			' 
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(8, 16)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(120, 23)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Hobbies"
			' 
			' checkedListBox1
			' 
			Me.checkedListBox1.Items.AddRange(New Object() { "Music", "Books", "Gardening", "TV"})
			Me.checkedListBox1.Location = New System.Drawing.Point(8, 48)
			Me.checkedListBox1.Name = "checkedListBox1"
			Me.checkedListBox1.Size = New System.Drawing.Size(120, 79)
			Me.checkedListBox1.TabIndex = 0
			' 
			' ChoiceListControl
			' 
			Me.Controls.Add(Me.panel1)
			Me.Name = "ChoiceListControl"
			Me.Size = New System.Drawing.Size(144, 136)
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region
	End Class
End Namespace
