Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace OutlookDemo
	''' <summary>
	''' Summary description for SortDialog.
	''' </summary>
	Public Class SortDialog : Inherits System.Windows.Forms.Form
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private comboBox1 As System.Windows.Forms.ComboBox
		Private comboBox2 As System.Windows.Forms.ComboBox
		Private comboBox3 As System.Windows.Forms.ComboBox
		Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
		Private radioButton2 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton3 As System.Windows.Forms.RadioButton
		Private radioButton4 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton5 As System.Windows.Forms.RadioButton
		Private radioButton6 As System.Windows.Forms.RadioButton
		Private WithEvents button1 As System.Windows.Forms.Button
		Private button2 As System.Windows.Forms.Button
		Private sortByCols_Renamed As String()
		Private sortDir As ListSortDirection()
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New(ByVal vCols As String())
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			sortByCols_Renamed = New String(2) {}
			sortDir = New ListSortDirection(2) {}
			Dim i As Integer=0
'ORIGINAL LINE: for(int i=0;i<vCols.Length;i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i<vCols.Length
				Me.comboBox1.Items.Add(vCols(i))
				Me.comboBox2.Items.Add(vCols(i))
				Me.comboBox3.Items.Add(vCols(i))
				i += 1
			Loop
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub
		Public ReadOnly Property SortByCols() As String()
			Get
				Return sortByCols_Renamed
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
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.radioButton2 = New System.Windows.Forms.RadioButton()
			Me.radioButton1 = New System.Windows.Forms.RadioButton()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.comboBox2 = New System.Windows.Forms.ComboBox()
			Me.radioButton4 = New System.Windows.Forms.RadioButton()
			Me.radioButton3 = New System.Windows.Forms.RadioButton()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.comboBox3 = New System.Windows.Forms.ComboBox()
			Me.radioButton6 = New System.Windows.Forms.RadioButton()
			Me.radioButton5 = New System.Windows.Forms.RadioButton()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.groupBox1.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			Me.groupBox3.SuspendLayout()
			Me.SuspendLayout()
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.radioButton2)
			Me.groupBox1.Controls.Add(Me.radioButton1)
			Me.groupBox1.Controls.Add(Me.comboBox1)
			Me.groupBox1.Location = New System.Drawing.Point(8, 8)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(296, 64)
			Me.groupBox1.TabIndex = 0
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Sort items by"
			' 
			' radioButton2
			' 
			Me.radioButton2.Location = New System.Drawing.Point(168, 40)
			Me.radioButton2.Name = "radioButton2"
			Me.radioButton2.Size = New System.Drawing.Size(104, 16)
			Me.radioButton2.TabIndex = 5
			Me.radioButton2.Text = "Descending"
			' 
			' radioButton1
			' 
			Me.radioButton1.Checked = True
			Me.radioButton1.Location = New System.Drawing.Point(168, 16)
			Me.radioButton1.Name = "radioButton1"
			Me.radioButton1.Size = New System.Drawing.Size(104, 16)
			Me.radioButton1.TabIndex = 4
			Me.radioButton1.TabStop = True
			Me.radioButton1.Text = "Ascending"
'			Me.radioButton1.CheckedChanged += New System.EventHandler(Me.radioButton1_CheckedChanged);
			' 
			' comboBox1
			' 
			Me.comboBox1.Items.AddRange(New Object() { "(none)"})
			Me.comboBox1.Location = New System.Drawing.Point(8, 16)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(152, 21)
			Me.comboBox1.TabIndex = 3
			Me.comboBox1.Text = "(none)"
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.comboBox2)
			Me.groupBox2.Controls.Add(Me.radioButton4)
			Me.groupBox2.Controls.Add(Me.radioButton3)
			Me.groupBox2.Location = New System.Drawing.Point(8, 80)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.groupBox2.Size = New System.Drawing.Size(296, 64)
			Me.groupBox2.TabIndex = 1
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Then by"
			' 
			' comboBox2
			' 
			Me.comboBox2.Items.AddRange(New Object() { "(none)"})
			Me.comboBox2.Location = New System.Drawing.Point(8, 16)
			Me.comboBox2.Name = "comboBox2"
			Me.comboBox2.Size = New System.Drawing.Size(152, 21)
			Me.comboBox2.TabIndex = 4
			Me.comboBox2.Text = "(none)"
			' 
			' radioButton4
			' 
			Me.radioButton4.Location = New System.Drawing.Point(168, 40)
			Me.radioButton4.Name = "radioButton4"
			Me.radioButton4.Size = New System.Drawing.Size(104, 16)
			Me.radioButton4.TabIndex = 7
			Me.radioButton4.Text = "Descending"
			' 
			' radioButton3
			' 
			Me.radioButton3.Checked = True
			Me.radioButton3.Location = New System.Drawing.Point(168, 16)
			Me.radioButton3.Name = "radioButton3"
			Me.radioButton3.Size = New System.Drawing.Size(104, 16)
			Me.radioButton3.TabIndex = 6
			Me.radioButton3.TabStop = True
			Me.radioButton3.Text = "Ascending"
'			Me.radioButton3.CheckedChanged += New System.EventHandler(Me.radioButton3_CheckedChanged);
			' 
			' groupBox3
			' 
			Me.groupBox3.Controls.Add(Me.comboBox3)
			Me.groupBox3.Controls.Add(Me.radioButton6)
			Me.groupBox3.Controls.Add(Me.radioButton5)
			Me.groupBox3.Location = New System.Drawing.Point(8, 152)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(296, 64)
			Me.groupBox3.TabIndex = 2
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "Then by"
			' 
			' comboBox3
			' 
			Me.comboBox3.Items.AddRange(New Object() { "(none)"})
			Me.comboBox3.Location = New System.Drawing.Point(8, 16)
			Me.comboBox3.Name = "comboBox3"
			Me.comboBox3.Size = New System.Drawing.Size(152, 21)
			Me.comboBox3.TabIndex = 5
			Me.comboBox3.Text = "(none)"
			' 
			' radioButton6
			' 
			Me.radioButton6.Location = New System.Drawing.Point(168, 40)
			Me.radioButton6.Name = "radioButton6"
			Me.radioButton6.Size = New System.Drawing.Size(104, 16)
			Me.radioButton6.TabIndex = 9
			Me.radioButton6.Text = "Descending"
			' 
			' radioButton5
			' 
			Me.radioButton5.Checked = True
			Me.radioButton5.Location = New System.Drawing.Point(168, 16)
			Me.radioButton5.Name = "radioButton5"
			Me.radioButton5.Size = New System.Drawing.Size(104, 16)
			Me.radioButton5.TabIndex = 8
			Me.radioButton5.TabStop = True
			Me.radioButton5.Text = "Ascending"
'			Me.radioButton5.CheckedChanged += New System.EventHandler(Me.radioButton5_CheckedChanged);
			' 
			' button1
			' 
			Me.button1.BackColor = System.Drawing.SystemColors.Control
			Me.button1.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button1.Location = New System.Drawing.Point(312, 16)
			Me.button1.Name = "button1"
			Me.button1.TabIndex = 3
			Me.button1.Text = "OK"
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' button2
			' 
			Me.button2.BackColor = System.Drawing.SystemColors.Control
			Me.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button2.Location = New System.Drawing.Point(312, 48)
			Me.button2.Name = "button2"
			Me.button2.TabIndex = 4
			Me.button2.Text = "Cancel"
			' 
			' SortDialog
			' 
			Me.AcceptButton = Me.button1
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CByte(209)), (CByte(209)), (CByte(223)))
			Me.CancelButton = Me.button2
			Me.ClientSize = New System.Drawing.Size(392, 222)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.groupBox3)
			Me.Controls.Add(Me.groupBox2)
			Me.Controls.Add(Me.groupBox1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "SortDialog"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Sort"
'			Me.Load += New System.EventHandler(Me.SortDialog_Load);
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox3.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub SortDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			sortByCols_Renamed(0)=Me.comboBox1.SelectedItem.ToString()
			sortByCols_Renamed(1)=Me.comboBox2.SelectedItem.ToString()
			sortByCols_Renamed(2)=Me.comboBox3.SelectedItem.ToString()
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
