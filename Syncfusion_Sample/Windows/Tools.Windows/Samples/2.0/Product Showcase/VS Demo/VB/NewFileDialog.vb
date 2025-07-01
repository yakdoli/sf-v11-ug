Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace VSDemo
	''' <summary>
	''' Summary description for NewFileDialog.
	''' </summary>
	Public Class NewFileDialog : Inherits System.Windows.Forms.Form

		Private mainForm As VSDemoMainForm

		Private WithEvents listView1 As System.Windows.Forms.ListView
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private textBox1 As System.Windows.Forms.TextBox
        Private Shadows WithEvents okButton As System.Windows.Forms.Button
        Private Shadows WithEvents cancelButton As System.Windows.Forms.Button
		Private dockingImageList As System.Windows.Forms.ImageList
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub New(ByVal mainForm As VSDemoMainForm)
			InitializeComponent()
			Me.mainForm = mainForm
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
			Me.components = New System.ComponentModel.Container()
			Dim listViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() { ".cs"}, 63, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))))
			Dim listViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() { ".vb"}, 4, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))))
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewFileDialog))
			Me.listView1 = New System.Windows.Forms.ListView()
			Me.dockingImageList = New System.Windows.Forms.ImageList(Me.components)
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.okButton = New System.Windows.Forms.Button()
			Me.cancelButton = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' listView1
			' 
			Me.listView1.Items.AddRange(New System.Windows.Forms.ListViewItem() { listViewItem1, listViewItem2})
			Me.listView1.LargeImageList = Me.dockingImageList
			Me.listView1.Location = New System.Drawing.Point(8, 48)
			Me.listView1.Name = "listView1"
			Me.listView1.Size = New System.Drawing.Size(480, 160)
			Me.listView1.SmallImageList = Me.dockingImageList
			Me.listView1.TabIndex = 0
			Me.listView1.UseCompatibleStateImageBehavior = False
'			Me.listView1.SelectedIndexChanged += New System.EventHandler(Me.listView1_SelectedIndexChanged);
			' 
			' dockingImageList
			' 
			Me.dockingImageList.ImageStream = (CType(resources.GetObject("dockingImageList.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.dockingImageList.TransparentColor = System.Drawing.Color.Transparent
			Me.dockingImageList.Images.SetKeyName(0, "")
			Me.dockingImageList.Images.SetKeyName(1, "")
			Me.dockingImageList.Images.SetKeyName(2, "")
			Me.dockingImageList.Images.SetKeyName(3, "")
			Me.dockingImageList.Images.SetKeyName(4, "")
			Me.dockingImageList.Images.SetKeyName(5, "")
			Me.dockingImageList.Images.SetKeyName(6, "")
			Me.dockingImageList.Images.SetKeyName(7, "")
			Me.dockingImageList.Images.SetKeyName(8, "")
			Me.dockingImageList.Images.SetKeyName(9, "")
			Me.dockingImageList.Images.SetKeyName(10, "")
			Me.dockingImageList.Images.SetKeyName(11, "")
			Me.dockingImageList.Images.SetKeyName(12, "")
			Me.dockingImageList.Images.SetKeyName(13, "")
			Me.dockingImageList.Images.SetKeyName(14, "")
			Me.dockingImageList.Images.SetKeyName(15, "")
			Me.dockingImageList.Images.SetKeyName(16, "")
			Me.dockingImageList.Images.SetKeyName(17, "")
			Me.dockingImageList.Images.SetKeyName(18, "")
			Me.dockingImageList.Images.SetKeyName(19, "")
			Me.dockingImageList.Images.SetKeyName(20, "")
			Me.dockingImageList.Images.SetKeyName(21, "")
			Me.dockingImageList.Images.SetKeyName(22, "")
			Me.dockingImageList.Images.SetKeyName(23, "")
			Me.dockingImageList.Images.SetKeyName(24, "")
			Me.dockingImageList.Images.SetKeyName(25, "")
			Me.dockingImageList.Images.SetKeyName(26, "")
			Me.dockingImageList.Images.SetKeyName(27, "")
			Me.dockingImageList.Images.SetKeyName(28, "")
			Me.dockingImageList.Images.SetKeyName(29, "")
			Me.dockingImageList.Images.SetKeyName(30, "")
			Me.dockingImageList.Images.SetKeyName(31, "")
			Me.dockingImageList.Images.SetKeyName(32, "")
			Me.dockingImageList.Images.SetKeyName(33, "")
			Me.dockingImageList.Images.SetKeyName(34, "")
			Me.dockingImageList.Images.SetKeyName(35, "")
			Me.dockingImageList.Images.SetKeyName(36, "")
			Me.dockingImageList.Images.SetKeyName(37, "")
			Me.dockingImageList.Images.SetKeyName(38, "")
			Me.dockingImageList.Images.SetKeyName(39, "")
			Me.dockingImageList.Images.SetKeyName(40, "")
			Me.dockingImageList.Images.SetKeyName(41, "")
			Me.dockingImageList.Images.SetKeyName(42, "")
			Me.dockingImageList.Images.SetKeyName(43, "")
			Me.dockingImageList.Images.SetKeyName(44, "")
			Me.dockingImageList.Images.SetKeyName(45, "")
			Me.dockingImageList.Images.SetKeyName(46, "")
			Me.dockingImageList.Images.SetKeyName(47, "")
			Me.dockingImageList.Images.SetKeyName(48, "")
			Me.dockingImageList.Images.SetKeyName(49, "")
			Me.dockingImageList.Images.SetKeyName(50, "")
			Me.dockingImageList.Images.SetKeyName(51, "")
			Me.dockingImageList.Images.SetKeyName(52, "")
			Me.dockingImageList.Images.SetKeyName(53, "")
			Me.dockingImageList.Images.SetKeyName(54, "")
			Me.dockingImageList.Images.SetKeyName(55, "")
			Me.dockingImageList.Images.SetKeyName(56, "")
			Me.dockingImageList.Images.SetKeyName(57, "")
			Me.dockingImageList.Images.SetKeyName(58, "")
			Me.dockingImageList.Images.SetKeyName(59, "")
			Me.dockingImageList.Images.SetKeyName(60, "")
			Me.dockingImageList.Images.SetKeyName(61, "")
			Me.dockingImageList.Images.SetKeyName(62, "")
			Me.dockingImageList.Images.SetKeyName(63, "")
			Me.dockingImageList.Images.SetKeyName(64, "")
			Me.dockingImageList.Images.SetKeyName(65, "")
			Me.dockingImageList.Images.SetKeyName(66, "")
			Me.dockingImageList.Images.SetKeyName(67, "")
			Me.dockingImageList.Images.SetKeyName(68, "")
			Me.dockingImageList.Images.SetKeyName(69, "")
			Me.dockingImageList.Images.SetKeyName(70, "")
			Me.dockingImageList.Images.SetKeyName(71, "")
			Me.dockingImageList.Images.SetKeyName(72, "")
			Me.dockingImageList.Images.SetKeyName(73, "")
			Me.dockingImageList.Images.SetKeyName(74, "")
			Me.dockingImageList.Images.SetKeyName(75, "")
			Me.dockingImageList.Images.SetKeyName(76, "")
			Me.dockingImageList.Images.SetKeyName(77, "")
			Me.dockingImageList.Images.SetKeyName(78, "")
			Me.dockingImageList.Images.SetKeyName(79, "")
			Me.dockingImageList.Images.SetKeyName(80, "")
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(8, 16)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(100, 23)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Templates"
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(8, 224)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(64, 23)
			Me.label2.TabIndex = 2
			Me.label2.Text = "FileName"
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(8, 248)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(472, 23)
			Me.textBox1.TabIndex = 3
			' 
			' okButton
			' 
			Me.okButton.BackColor = System.Drawing.SystemColors.Control
			Me.okButton.Location = New System.Drawing.Point(312, 280)
			Me.okButton.Name = "okButton"
			Me.okButton.Size = New System.Drawing.Size(75, 23)
			Me.okButton.TabIndex = 4
			Me.okButton.Text = "Ok"
			Me.okButton.UseVisualStyleBackColor = False
'			Me.okButton.Click += New System.EventHandler(Me.okButton_Click);
			' 
			' cancelButton
			' 
			Me.cancelButton.Location = New System.Drawing.Point(408, 280)
			Me.cancelButton.Name = "cancelButton"
			Me.cancelButton.Size = New System.Drawing.Size(75, 23)
			Me.cancelButton.TabIndex = 5
			Me.cancelButton.Text = "Cancel"
'			Me.cancelButton.Click += New System.EventHandler(Me.cancelButton_Click);
			' 
			' NewFileDialog
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
			Me.ClientSize = New System.Drawing.Size(496, 334)
			Me.Controls.Add(Me.cancelButton)
			Me.Controls.Add(Me.okButton)
			Me.Controls.Add(Me.textBox1)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.listView1)
			Me.Font = New System.Drawing.Font("Calibri", 9.75F)
			Me.Name = "NewFileDialog"
			Me.Text = "NewFileDialog"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

        Private Sub listView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles listView1.SelectedIndexChanged
            If Me.listView1.SelectedItems.Count > 0 Then
                If Me.listView1.SelectedItems(0).Text <> "" Then
                    If Me.listView1.SelectedItems(0).Text = ".cs" Then
                        Me.textBox1.Text = "Class1.cs"
                        Me.textBox1.Focus()
                    ElseIf Me.listView1.SelectedItems(0).Text = ".vb" Then
                        Me.textBox1.Text = "Class1.vb"
                        Me.textBox1.Focus()
                    End If
                End If
            End If
        End Sub

		Private Sub okButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles okButton.Click
			If textBox1.Text<>"" Then
				If textBox1.Text.EndsWith(".cs") OrElse textBox1.Text.EndsWith(".vb") Then
					If (Not System.IO.File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\" & textBox1.Text)) Then
						createNewFile()
					Else
						Dim dr As DialogResult = MessageBox.Show("File already exists,Overwrite it??","",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)
                        If dr = Windows.Forms.DialogResult.OK Then
                            createNewFile()
                        End If
					End If
				Else
					MessageBox.Show("Enter proper extension for File")
				End If
			End If
		End Sub

		Private Sub createNewFile()
			Try
				Dim activeMDIChild As Form = Me.mainForm.CheckFormInChildWindow(Me.textBox1.Text)
				If Not activeMDIChild Is Nothing Then
					activeMDIChild.Close()
				End If
				System.IO.File.Create(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\" & textBox1.Text)
				mainForm.openFileInCodeEditor(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\" & textBox1.Text)
				Me.Close()
			Catch e As Exception
				MessageBox.Show(e.Message)
			End Try
		End Sub

		Private Sub cancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cancelButton.Click
			Me.Close()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.listView1.View = View.LargeIcon
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.listView1.View = View.SmallIcon
		End Sub
	End Class
End Namespace
