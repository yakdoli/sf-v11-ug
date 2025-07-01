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
	''' Summary description for FilterDialog.
	''' </summary>
	Public Class FilterDialog : Inherits System.Windows.Forms.Form
		Private listBox1 As System.Windows.Forms.ListBox
		Private label1 As System.Windows.Forms.Label
		Private WithEvents btnRemove As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private comboBox1 As System.Windows.Forms.ComboBox
		Private comboBox2 As System.Windows.Forms.ComboBox
		Private txtValue As System.Windows.Forms.TextBox
		Private lblFields As System.Windows.Forms.Label
		Private lblCond As System.Windows.Forms.Label
		Private lblValue As System.Windows.Forms.Label
		Private WithEvents btnAdd As System.Windows.Forms.Button
		Private WithEvents button1 As System.Windows.Forms.Button
		Private button2 As System.Windows.Forms.Button
		Private groupingGrid As GridGroupingControl
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New(ByVal grid As GridGroupingControl)
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			groupingGrid=grid
			Dim i As Integer = 0
'ORIGINAL LINE: for (int i = 0; i < Me.groupingGrid.TableDescriptor.VisibleColumns.Count; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i < Me.groupingGrid.TableDescriptor.VisibleColumns.Count
				Dim col As GridVisibleColumnDescriptor = Me.groupingGrid.TableDescriptor.VisibleColumns(i)
				If Not col Is Nothing Then
					Me.comboBox1.Items.Add(col.Name)
				End If
				i += 1
			Loop
			If Me.groupingGrid.TableDescriptor.RecordFilters.Count>0 Then
				For Each filter As RecordFilterDescriptor In groupingGrid.TableDescriptor.RecordFilters
					If Not filter Is Nothing Then
						For Each cond As FilterCondition In filter.Conditions
							listBox1.Items.Add(cond.FilterDescriptor.FieldDescriptor.Name & " " & cond.CompareOperator.ToString() & " " & cond.CompareValue.ToString())
						Next cond
					End If
				Next filter
			End If
			AddHandler comboBox1.SelectedIndexChanged, AddressOf comboBox1_SelectedIndexChanged
			AddHandler listBox1.SelectedIndexChanged, AddressOf listBox1_SelectedIndexChanged
			AddHandler txtValue.TextChanged, AddressOf txtValue_TextChanged

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
			Me.listBox1 = New System.Windows.Forms.ListBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.btnRemove = New System.Windows.Forms.Button()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.btnAdd = New System.Windows.Forms.Button()
			Me.lblValue = New System.Windows.Forms.Label()
			Me.lblCond = New System.Windows.Forms.Label()
			Me.lblFields = New System.Windows.Forms.Label()
			Me.txtValue = New System.Windows.Forms.TextBox()
			Me.comboBox2 = New System.Windows.Forms.ComboBox()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' listBox1
			' 
			Me.listBox1.Location = New System.Drawing.Point(0, 24)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(456, 82)
			Me.listBox1.TabIndex = 0
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(0, 8)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(192, 16)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Find items that match these criteria:"
			' 
			' btnRemove
			' 
			Me.btnRemove.BackColor = System.Drawing.SystemColors.Control
			Me.btnRemove.Enabled = False
			Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.btnRemove.Location = New System.Drawing.Point(376, 112)
			Me.btnRemove.Name = "btnRemove"
			Me.btnRemove.TabIndex = 2
			Me.btnRemove.Text = "Remove"
'			Me.btnRemove.Click += New System.EventHandler(Me.btnRemove_Click);
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.btnAdd)
			Me.groupBox1.Controls.Add(Me.lblValue)
			Me.groupBox1.Controls.Add(Me.lblCond)
			Me.groupBox1.Controls.Add(Me.lblFields)
			Me.groupBox1.Controls.Add(Me.txtValue)
			Me.groupBox1.Controls.Add(Me.comboBox2)
			Me.groupBox1.Controls.Add(Me.comboBox1)
			Me.groupBox1.Location = New System.Drawing.Point(8, 136)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(448, 96)
			Me.groupBox1.TabIndex = 3
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Define criteria:"
			' 
			' btnAdd
			' 
			Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
			Me.btnAdd.Enabled = False
			Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.btnAdd.Location = New System.Drawing.Point(360, 64)
			Me.btnAdd.Name = "btnAdd"
			Me.btnAdd.TabIndex = 6
			Me.btnAdd.Text = "Add to List"
'			Me.btnAdd.Click += New System.EventHandler(Me.btnAdd_Click);
			' 
			' lblValue
			' 
			Me.lblValue.Enabled = False
			Me.lblValue.Location = New System.Drawing.Point(304, 16)
			Me.lblValue.Name = "lblValue"
			Me.lblValue.TabIndex = 5
			Me.lblValue.Text = "Value"
			' 
			' lblCond
			' 
			Me.lblCond.Enabled = False
			Me.lblCond.Location = New System.Drawing.Point(176, 16)
			Me.lblCond.Name = "lblCond"
			Me.lblCond.Size = New System.Drawing.Size(100, 16)
			Me.lblCond.TabIndex = 4
			Me.lblCond.Text = "Condition"
			' 
			' lblFields
			' 
			Me.lblFields.Location = New System.Drawing.Point(8, 16)
			Me.lblFields.Name = "lblFields"
			Me.lblFields.Size = New System.Drawing.Size(100, 16)
			Me.lblFields.TabIndex = 3
			Me.lblFields.Text = "Fields"
			' 
			' txtValue
			' 
			Me.txtValue.Enabled = False
			Me.txtValue.Location = New System.Drawing.Point(304, 40)
			Me.txtValue.Name = "txtValue"
			Me.txtValue.Size = New System.Drawing.Size(136, 20)
			Me.txtValue.TabIndex = 2
			Me.txtValue.Text = ""
			' 
			' comboBox2
			' 
			Me.comboBox2.Enabled = False
			Me.comboBox2.Items.AddRange(New Object() { "Equals", "Greater Than", "Greater ThanOrEqualTo", "Less Than", "Less ThanOrEqualTo", "Like", "NotEquals"})
			Me.comboBox2.Location = New System.Drawing.Point(176, 40)
			Me.comboBox2.Name = "comboBox2"
			Me.comboBox2.Size = New System.Drawing.Size(121, 21)
			Me.comboBox2.TabIndex = 1
			Me.comboBox2.Text = "(Condition)"
			' 
			' comboBox1
			' 
			Me.comboBox1.Location = New System.Drawing.Point(8, 40)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(152, 21)
			Me.comboBox1.TabIndex = 0
			Me.comboBox1.Text = "(Select Fields)"
			' 
			' button1
			' 
			Me.button1.BackColor = System.Drawing.SystemColors.Control
			Me.button1.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button1.Location = New System.Drawing.Point(296, 240)
			Me.button1.Name = "button1"
			Me.button1.TabIndex = 4
			Me.button1.Text = "OK"
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' button2
			' 
			Me.button2.BackColor = System.Drawing.SystemColors.Control
			Me.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button2.Location = New System.Drawing.Point(376, 240)
			Me.button2.Name = "button2"
			Me.button2.TabIndex = 5
			Me.button2.Text = "Cancel"
			' 
			' FilterDialog
			' 
			Me.AcceptButton = Me.button1
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CByte(209)), (CByte(209)), (CByte(223)))
			Me.CancelButton = Me.button2
			Me.ClientSize = New System.Drawing.Size(464, 272)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.btnRemove)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.listBox1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "FilterDialog"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Filter"
			Me.groupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Not Me.comboBox1.SelectedItem Is Nothing Then
				Me.comboBox2.Enabled=True
				Me.txtValue.Enabled=True
				Me.lblCond.Enabled=True
				Me.lblValue.Enabled=True
			Else
				Me.comboBox2.Enabled=False
				Me.txtValue.Enabled=False
				Me.lblCond.Enabled=False
				Me.lblValue.Enabled=False
			End If
		End Sub

		Private Sub txtValue_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			If txtValue.TextLength>0 Then
				Me.btnAdd.Enabled=True
			Else
				Me.btnAdd.Enabled=False
			End If
		End Sub

		Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
			If Not Me.comboBox1.SelectedItem Is Nothing AndAlso Not Me.comboBox2.SelectedItem Is Nothing AndAlso Me.txtValue.TextLength<>0 Then
				Me.listBox1.Items.Add(Me.comboBox1.SelectedItem.ToString()+Constants.vbTab+Me.comboBox2.SelectedItem.ToString()+Constants.vbTab+Me.txtValue.Text)
				Me.comboBox1.Text="(Select Fields)"
				Me.comboBox2.Text="(Condition)"
				Me.txtValue.Text=""
				Me.comboBox2.Enabled=False
				Me.lblCond.Enabled=False
				Me.lblValue.Enabled=False
				Me.txtValue.Enabled=False
			End If
		End Sub

		Private Sub listBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Not Me.listBox1.SelectedItem Is Nothing Then
				Me.btnRemove.Enabled=True
			Else
				Me.btnRemove.Enabled=False
			End If
		End Sub

		Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemove.Click
			If (Me.listBox1.Items.Count>0) AndAlso (Not Me.listBox1.SelectedItem Is Nothing) Then
				Me.listBox1.Items.Remove(Me.listBox1.SelectedItem)
			End If
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			Dim criteria As System.Text.StringBuilder = New System.Text.StringBuilder()
			Me.groupingGrid.TableDescriptor.RecordFilters.Clear()
			If Me.listBox1.Items.Count>0 Then
				Dim str As String() = New String(2) {}
				str=Me.listBox1.Items(0).ToString().Split(ControlChars.Tab)
				Console.WriteLine(str(0) & " " & str(1) & " " & str(2))
				groupingGrid.TableDescriptor.RecordFilters.Add(str(0),CompareOp(str(1)),str(2))
			End If
		End Sub

		Private Function CompareOp(ByVal s As String) As FilterCompareOperator
			If s.CompareTo("Equals")=0 Then
				Return FilterCompareOperator.Equals
			Else If s.CompareTo("Greater Than")=0 Then
				Return FilterCompareOperator.GreaterThan
			Else If s.CompareTo("Greater ThanOrEqualTo")=0 Then
				Return FilterCompareOperator.GreaterThanOrEqualTo
			Else If s.CompareTo("Less Than")=0 Then
				Return FilterCompareOperator.LessThan
			Else If s.CompareTo("Less ThanOrEqualTo")=0 Then
				Return FilterCompareOperator.LessThanOrEqualTo
			Else If s.CompareTo("Like")=0 Then
				Return FilterCompareOperator.Like
			Else
				Return FilterCompareOperator.NotEquals
			End If
		End Function
	End Class
End Namespace
