Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace CustomCellAutoSizing
	''' <summary>
	''' Summary description for DataEntryControl.
	''' </summary>
	Public Class DataEntryControl
		Inherits System.Windows.Forms.UserControl
		Private panel1 As System.Windows.Forms.Panel
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private textBox1 As System.Windows.Forms.TextBox
		Private textBox2 As System.Windows.Forms.TextBox
		Private textBox3 As System.Windows.Forms.TextBox
		Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitializeComponent call
			AddHandler textBox1.KeyDown, AddressOf textBox1_KeyDown
		End Sub

		Private Sub textBox1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)

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
			Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.textBox3 = New System.Windows.Forms.TextBox()
			Me.textBox2 = New System.Windows.Forms.TextBox()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(246))))), (CInt(Fix((CByte(246))))), (CInt(Fix((CByte(222))))))
			Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel1.Controls.Add(Me.button1)
			Me.panel1.Controls.Add(Me.textBox3)
			Me.panel1.Controls.Add(Me.textBox2)
			Me.panel1.Controls.Add(Me.textBox1)
			Me.panel1.Controls.Add(Me.label3)
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(192, 136)
			Me.panel1.TabIndex = 0
			' 
			' button1
			' 
			Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button1.Location = New System.Drawing.Point(56, 104)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(80, 24)
			Me.button1.TabIndex = 6
			Me.button1.Text = "Total"
			Me.button1.UseVisualStyle = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' textBox3
			' 
			Me.textBox3.Location = New System.Drawing.Point(80, 72)
			Me.textBox3.Name = "textBox3"
			Me.textBox3.Size = New System.Drawing.Size(100, 20)
			Me.textBox3.TabIndex = 5
			' 
			' textBox2
			' 
			Me.textBox2.Location = New System.Drawing.Point(80, 40)
			Me.textBox2.Name = "textBox2"
			Me.textBox2.Size = New System.Drawing.Size(100, 20)
			Me.textBox2.TabIndex = 4
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(80, 8)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(100, 20)
			Me.textBox1.TabIndex = 3
			' 
			' label3
			' 
			Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.Location = New System.Drawing.Point(16, 72)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(64, 23)
			Me.label3.TabIndex = 2
			Me.label3.Text = "Sum"
			' 
			' label2
			' 
			Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Location = New System.Drawing.Point(16, 40)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(64, 23)
			Me.label2.TabIndex = 1
			Me.label2.Text = "Number2"
			' 
			' label1
			' 
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(16, 8)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(64, 23)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Number1"
			' 
			' DataEntryControl
			' 
			Me.Controls.Add(Me.panel1)
			Me.Name = "DataEntryControl"
			Me.Size = New System.Drawing.Size(192, 136)
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			If textBox1.Text <> "" AndAlso textBox2.Text <> "" Then
				'Calculate sum
				Dim s As Integer
				If Integer.TryParse(textBox1.Text,s) AndAlso Integer.TryParse(textBox2.Text,s) Then
					Dim sum As Integer = Integer.Parse(textBox1.Text) + Integer.Parse(textBox2.Text)
					textBox3.Text = sum.ToString()
				Else
					MessageBox.Show("Enter Numbers")
				End If
			End If
		End Sub
	End Class
End Namespace
