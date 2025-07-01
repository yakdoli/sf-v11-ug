Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Imports Syncfusion.Windows.Forms.Tools

Namespace ColorUIDemo
	''' <summary>
	''' Summary description for ColorGroup.
	''' </summary>
	Public Class ColorGroup : Inherits System.Windows.Forms.Form
		Private WithEvents buttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
		Private propertyGrid1 As System.Windows.Forms.PropertyGrid
		Private label1 As System.Windows.Forms.Label
		Private WithEvents listBox1 As System.Windows.Forms.ListBox
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents btnAdd As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents btnRemove As Syncfusion.Windows.Forms.ButtonAdv

		Private colorPickerUIAdv As ColorPickerUIAdv
		Private tempCollectionList As ArrayList = New ArrayList()

		Public Sub New(ByVal colorPickerUIAdv As ColorPickerUIAdv)
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Me.colorPickerUIAdv = colorPickerUIAdv
			FillInListBox()
			Me.listBox1.SelectedIndex=0
			Me.propertyGrid1.SelectedObject = Me.colorPickerUIAdv.ThemeGroup
			For Each o As Object In Me.colorPickerUIAdv.CustomGroups
				tempCollectionList.Add(o)
			Next o
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
			Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
			Me.label1 = New System.Windows.Forms.Label()
			Me.listBox1 = New System.Windows.Forms.ListBox()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.btnAdd = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.btnRemove = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' buttonAdv1
			' 
			Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonAdv1.Location = New System.Drawing.Point(248, 344)
			Me.buttonAdv1.Name = "buttonAdv1"
			Me.buttonAdv1.Size = New System.Drawing.Size(75, 23)
			Me.buttonAdv1.TabIndex = 0
            Me.buttonAdv1.Text = "OK"
			Me.buttonAdv1.UseVisualStyle = True
'			Me.buttonAdv1.Click += New System.EventHandler(Me.buttonAdv1_Click);
			' 
			' buttonAdv2
			' 
			Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonAdv2.Location = New System.Drawing.Point(336, 344)
			Me.buttonAdv2.Name = "buttonAdv2"
			Me.buttonAdv2.Size = New System.Drawing.Size(75, 23)
			Me.buttonAdv2.TabIndex = 1
			Me.buttonAdv2.Text = "Cancel"
			Me.buttonAdv2.UseVisualStyle = True
'			Me.buttonAdv2.Click += New System.EventHandler(Me.buttonAdv2_Click);
			' 
			' propertyGrid1
			' 
			Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.FromArgb((CInt((CByte(223)))), (CInt((CByte(235)))), (CInt((CByte(249)))))
			Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
			Me.propertyGrid1.Location = New System.Drawing.Point(16, 24)
			Me.propertyGrid1.Name = "propertyGrid1"
			Me.propertyGrid1.Size = New System.Drawing.Size(168, 280)
			Me.propertyGrid1.TabIndex = 2
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(16, 6)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(76, 13)
			Me.label1.TabIndex = 3
			Me.label1.Text = "Theme Colors:"
			' 
			' listBox1
			' 
			Me.listBox1.Location = New System.Drawing.Point(8, 8)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(160, 225)
			Me.listBox1.TabIndex = 4
'			Me.listBox1.SelectedIndexChanged += New System.EventHandler(Me.listBox1_SelectedIndexChanged);
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(223)))), (CInt((CByte(235)))), (CInt((CByte(249)))))
			Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Controls.Add(Me.propertyGrid1)
			Me.panel1.Location = New System.Drawing.Point(224, 8)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(200, 320)
			Me.panel1.TabIndex = 9
			' 
			' btnAdd
			' 
			Me.btnAdd.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.btnAdd.Location = New System.Drawing.Point(8, 240)
			Me.btnAdd.Name = "btnAdd"
			Me.btnAdd.Size = New System.Drawing.Size(75, 23)
			Me.btnAdd.TabIndex = 10
			Me.btnAdd.Text = "Add"
			Me.btnAdd.UseVisualStyle = True
            ' 
			' btnRemove
			' 
			Me.btnRemove.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.btnRemove.Location = New System.Drawing.Point(88, 240)
			Me.btnRemove.Name = "btnRemove"
			Me.btnRemove.Size = New System.Drawing.Size(75, 23)
			Me.btnRemove.TabIndex = 11
			Me.btnRemove.Text = "Remove"
			Me.btnRemove.UseVisualStyle = True
'			Me.btnRemove.Click += New System.EventHandler(Me.btnRemove_Click);
			' 
			' ColorGroup
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
			Me.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(160)))), (CInt((CByte(193)))), (CInt((CByte(236)))))
			Me.ClientSize = New System.Drawing.Size(432, 374)
			Me.ControlBox = False
			Me.Controls.Add(Me.btnRemove)
			Me.Controls.Add(Me.btnAdd)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.listBox1)
			Me.Controls.Add(Me.buttonAdv1)
			Me.Controls.Add(Me.buttonAdv2)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.MaximizeBox = False
			Me.MinimizeBox = False
            Me.Name = "ColorGroup"
            Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "ColorGroup"
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub FillInListBox()
			Me.listBox1.Items.Clear()
			Me.listBox1.Items.Add(Me.colorPickerUIAdv.ThemeGroup.Name)
			Me.listBox1.Items.Add(Me.colorPickerUIAdv.StandardGroup.Name)
			Me.listBox1.Items.Add(Me.colorPickerUIAdv.RecentGroup.Name)
			For Each group As ColorUIAdvGroup In Me.colorPickerUIAdv.CustomGroups
				listBox1.Items.Add(group.Name)
			Next group
		End Sub

		Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonAdv1.Click
			Me.Close()
		End Sub

		Private Sub listBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles listBox1.SelectedIndexChanged
			If Me.listBox1.SelectedItem.ToString()<>"" AndAlso Not Me.listBox1.SelectedItem Is Nothing Then
				Me.propertyGrid1.SelectedObject = getColorUIAdvGroupObject(Me.listBox1.SelectedItem.ToString())
			End If
		End Sub

		Private Function getColorUIAdvGroupObject(ByVal groupName As String) As ColorUIAdvGroup
			If groupName = "ThemeColors" Then
				Return Me.colorPickerUIAdv.ThemeGroup
			Else If groupName = "StandardColors" Then
				Return Me.colorPickerUIAdv.StandardGroup
			Else If groupName = "RecentColors" Then
				Return Me.colorPickerUIAdv.RecentGroup
			End If
			For Each group As ColorUIAdvGroup In Me.colorPickerUIAdv.CustomGroups
				If group.Name = groupName Then
					Return group
				End If
			Next group
			Return Nothing
		End Function

		Private Sub FillInColorGroup(ByVal list As ArrayList)
			Me.colorPickerUIAdv.CustomGroups.Clear()
			For Each o As Object In list
				Me.colorPickerUIAdv.CustomGroups.Add(CType(o, ColorUIAdvGroup))
			Next o
		End Sub

		Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
			Dim group As ColorUIAdvGroup = New ColorUIAdvGroup(Me.colorPickerUIAdv,Syncfusion.Windows.Forms.Tools.ColorUIAdvGroups.CustomColors,True)
			Me.colorPickerUIAdv.CustomGroups.Add(group)
			FillInListBox()
			Me.listBox1.SelectedIndex = Me.listBox1.Items.Count - 1
		End Sub

		Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemove.Click
			If Not Me.listBox1.SelectedItem Is Nothing Then
'INSTANT VB NOTE: The local variable colorGroup was renamed since Visual Basic will not uniquely identify class members when local variables have the same name:
				Dim colorGroup_Renamed As String = Me.listBox1.SelectedItem.ToString()
				If colorGroup_Renamed <> "ThemeColors" AndAlso colorGroup_Renamed <> "StandardColors" AndAlso colorGroup_Renamed <> "RecentColors" Then
					Dim group As ColorUIAdvGroup = getColorUIAdvGroupObject(colorGroup_Renamed)
					If Not group Is Nothing Then
						Me.colorPickerUIAdv.CustomGroups.Remove(group)
                        FillInListBox()
                        Me.listBox1.SelectedIndex = Me.listBox1.Items.Count - 1
					End If
				Else
					MessageBox.Show("You can remove only custom group colors")
				End If
			Else
				Me.listBox1.SelectedIndex = Me.listBox1.Items.Count - 1
			End If
		End Sub

		Private Sub buttonAdv2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonAdv2.Click
			Dim dr As DialogResult = MessageBox.Show("Do you want to cancel?","Cancel",MessageBoxButtons.YesNo,MessageBoxIcon.Information)
			If dr = DialogResult.Yes Then
				FillInColorGroup(tempCollectionList)
				Me.Close()
			End If
		End Sub

	End Class
End Namespace
