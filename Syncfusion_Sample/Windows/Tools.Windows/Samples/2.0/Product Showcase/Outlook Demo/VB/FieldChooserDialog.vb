Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace OutlookDemo
	''' <summary>
	''' Summary description for FieldChooserDialog.
	''' </summary>
	Public Class FieldChooserDialog : Inherits System.Windows.Forms.Form
		Private listBox1 As System.Windows.Forms.ListBox
		Private listBox2 As System.Windows.Forms.ListBox
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents button3 As System.Windows.Forms.Button
		Private button4 As System.Windows.Forms.Button
		Private WithEvents button5 As System.Windows.Forms.Button
		Private WithEvents button6 As System.Windows.Forms.Button
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private NewSet As String()
		Public Sub New(ByVal hiddenSet As String(), ByVal visibleSet As String())

			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			For i As Integer = 1 To hiddenSet.Length - 1
				If Not hiddenSet(i) Is Nothing Then
					Me.listBox1.Items.Add(hiddenSet(i))
				End If
			Next i

			For i As Integer = 1 To visibleSet.Length - 1
				If Not visibleSet(i) Is Nothing Then
					Me.listBox2.Items.Add(visibleSet(i))
				End If
			Next i
			If Me.listBox1.Items.Count>0 Then
				Me.listBox1.SelectedIndex=0
			End If
'			else
'				this.button1.Enabled=false;
'			this.button2.Enabled=false;
			AddHandler listBox1.SelectedIndexChanged, AddressOf listBox1_SelectedIndexChanged
			AddHandler listBox2.SelectedIndexChanged, AddressOf listBox2_SelectedIndexChanged
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub listBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Not Me.listBox1.SelectedItem Is Nothing Then
				Me.button1.Enabled = True
			Else
				Me.button1.Enabled = False
			End If
		End Sub

		Public ReadOnly Property SelectedFields() As String()
			Get
				Return NewSet
			End Get
		End Property

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
			Me.listBox1 = New System.Windows.Forms.ListBox()
			Me.listBox2 = New System.Windows.Forms.ListBox()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			Me.button4 = New System.Windows.Forms.Button()
			Me.button5 = New System.Windows.Forms.Button()
			Me.button6 = New System.Windows.Forms.Button()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' listBox1
			' 
			Me.listBox1.Location = New System.Drawing.Point(8, 24)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(144, 160)
			Me.listBox1.TabIndex = 0
			' 
			' listBox2
			' 
			Me.listBox2.Location = New System.Drawing.Point(240, 24)
			Me.listBox2.Name = "listBox2"
			Me.listBox2.Size = New System.Drawing.Size(152, 160)
			Me.listBox2.TabIndex = 1
			' 
			' button1
			' 
			Me.button1.BackColor = System.Drawing.SystemColors.Control
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button1.Location = New System.Drawing.Point(160, 32)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75, 23)
			Me.button1.TabIndex = 2
			Me.button1.Text = "Add >>"
'            this.button1.UseVisualStyleBackColor = false;
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' button2
			' 
			Me.button2.BackColor = System.Drawing.SystemColors.Control
			Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button2.Location = New System.Drawing.Point(160, 64)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(75, 23)
			Me.button2.TabIndex = 3
			Me.button2.Text = "<< Remove"
'            this.button2.UseVisualStyleBackColor = false;
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' button3
			' 
			Me.button3.BackColor = System.Drawing.SystemColors.Control
			Me.button3.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button3.Location = New System.Drawing.Point(400, 32)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(64, 23)
			Me.button3.TabIndex = 4
			Me.button3.Text = "OK"
'            this.button3.UseVisualStyleBackColor = false;
'			Me.button3.Click += New System.EventHandler(Me.button3_Click);
			' 
			' button4
			' 
			Me.button4.BackColor = System.Drawing.SystemColors.Control
			Me.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button4.Location = New System.Drawing.Point(400, 64)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(64, 23)
			Me.button4.TabIndex = 5
			Me.button4.Text = "Cancel"
'            this.button4.UseVisualStyleBackColor = false;
			' 
			' button5
			' 
			Me.button5.BackColor = System.Drawing.SystemColors.Control
			Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button5.Location = New System.Drawing.Point(160, 112)
			Me.button5.Name = "button5"
			Me.button5.Size = New System.Drawing.Size(75, 23)
			Me.button5.TabIndex = 6
			Me.button5.Text = "MoveUp"
'            this.button5.UseVisualStyleBackColor = false;
'			Me.button5.Click += New System.EventHandler(Me.button5_Click);
			' 
			' button6
			' 
			Me.button6.BackColor = System.Drawing.SystemColors.Control
			Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button6.Location = New System.Drawing.Point(160, 144)
			Me.button6.Name = "button6"
			Me.button6.Size = New System.Drawing.Size(75, 23)
			Me.button6.TabIndex = 7
			Me.button6.Text = "MoveDown"
'            this.button6.UseVisualStyleBackColor = false;
'			Me.button6.Click += New System.EventHandler(Me.button6_Click);
			' 
			' label1
			' 
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(8, 8)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(100, 16)
			Me.label1.TabIndex = 8
			Me.label1.Text = "Hidden Fields"
			' 
			' label2
			' 
			Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Location = New System.Drawing.Point(240, 8)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(100, 16)
			Me.label2.TabIndex = 9
			Me.label2.Text = "Visible Fields"
			' 
			' FieldChooserDialog
			' 
			Me.AcceptButton = Me.button3
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(209)))), (CInt((CByte(209)))), (CInt((CByte(223)))))
			Me.CancelButton = Me.button4
			Me.ClientSize = New System.Drawing.Size(472, 192)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.button6)
			Me.Controls.Add(Me.button5)
			Me.Controls.Add(Me.button4)
			Me.Controls.Add(Me.button3)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.listBox2)
			Me.Controls.Add(Me.listBox1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "FieldChooserDialog"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Field Chooser"
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			Me.listBox2.Items.Add(Me.listBox1.SelectedItem)
			Me.listBox1.Items.Remove(Me.listBox1.SelectedItem)
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
			Me.listBox1.Items.Add(Me.listBox2.SelectedItem)
			Me.listBox2.Items.Remove(Me.listBox2.SelectedItem)
		End Sub

		Private Sub button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button5.Click
			Dim selindex As Integer = Me.listBox2.SelectedIndex
			If selindex>0 Then
				Dim val As Object = Me.listBox2.Items(selindex - 1)
				Me.listBox2.Items(selindex - 1) = Me.listBox2.SelectedItem
				Me.listBox2.Items(selindex) = val
				Me.listBox2.SelectedIndex = selindex - 1
			End If
		End Sub

		Private Sub button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button6.Click
			Dim selindex As Integer = Me.listBox2.SelectedIndex
			If selindex<Me.listBox2.Items.Count-1 Then
				Dim val As Object = Me.listBox2.Items(selindex + 1)
				Me.listBox2.Items(selindex + 1) = Me.listBox2.SelectedItem
				Me.listBox2.Items(selindex) = val
				Me.listBox2.SelectedIndex = selindex + 1
			End If
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
			Me.NewSet = New String(Me.listBox2.Items.Count - 1) {}
			Dim i As Integer = 0
'ORIGINAL LINE: for (int i = 0; i < Me.listBox2.Items.Count; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i < Me.listBox2.Items.Count
				Me.NewSet(i) = Me.listBox2.Items(i).ToString()
				i += 1
			Loop
		End Sub

		Private Sub listBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Not Me.listBox2.SelectedItem Is Nothing Then
				Me.button2.Enabled = True
				If Me.listBox2.SelectedIndex = 0 Then
					Me.button5.Enabled = False
				Else
					Me.button5.Enabled = True
				End If
				If Me.listBox2.SelectedIndex = listBox2.Items.Count - 1 Then
					Me.button6.Enabled = False
				Else
					Me.button6.Enabled = True
				End If
			Else
				Me.button2.Enabled = False
			End If
		End Sub

	End Class
End Namespace
