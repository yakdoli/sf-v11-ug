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
Imports System.IO

Namespace BreakPointDemo
	''' <summary>
	''' Summary description for Form2.
	''' </summary>
	Public Class CustomizeForm : Inherits System.Windows.Forms.Form
		Private WithEvents listView1 As System.Windows.Forms.ListView
		Private imageList1 As System.Windows.Forms.ImageList
		Private components As System.ComponentModel.IContainer
		Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton2 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton3 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton4 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton5 As System.Windows.Forms.RadioButton
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents radioButton6 As System.Windows.Forms.RadioButton
		Private label1 As System.Windows.Forms.Label
		Private imagePath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\Glyphs\breakpoint"
        Shared i As Integer = 0
		Private activeRB As RadioButton
		Private image_Renamed As Image
Private WithEvents radioButton7 As RadioButton
		Private activeLVI As ListViewItem

		Public Event Accepted As EventHandler

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			PopulateImageList()

			AssociateImages()

			ColorRadioButtons ()

			Me.activeRB = Me.radioButton4
			Me.activeRB.Checked = True

			activeLVI = Me.listView1.Items(2)
			image_Renamed = Me.imageList1.Images(activeLVI.ImageIndex)

			Me.label1.Text = "Select the desired backcolor and indicator image for the breakpoint"
		End Sub



		Private Sub PopulateImageList()
Dim i As Integer = 0
            For i = 1 To 8
                Dim bmp As Bitmap = New Bitmap(imagePath & i.ToString() & ".png")
                Me.imageList1.Images.Add(bmp)
            Next i
        End Sub

		Private Sub AssociateImages()
			Me.listView1.SmallImageList = Me.imageList1
			Dim index As Integer=0
			For Each lvi As ListViewItem In Me.listView1.Items
				lvi.ImageIndex = index
				index += 1
			Next lvi
		End Sub

		Private Sub ColorRadioButtons()
			For Each ctrl As Control In Me.groupBox1.Controls
				Dim rb As RadioButton = CType(ctrl, RadioButton)

				Select Case rb.Text
					Case "Light Olive"
						rb.BackColor = ColorTranslator.FromHtml("#85BF75")
					Case "Dark Orange"
						rb.BackColor = ColorTranslator.FromHtml("#DE6413")
					Case "Dull Aqua"
						rb.BackColor = ColorTranslator.FromHtml("#B4E7F2")
					Case "Bright Orange"
						rb.BackColor = ColorTranslator.FromHtml("#FFBF34")
					Case "Light Blue"
						rb.BackColor = ColorTranslator.FromHtml("#DAE5F5")
					Case "Violet"
						rb.BackColor = ColorTranslator.FromHtml("#333365")
Case "Maroon"
						rb.BackColor = Color.FromArgb(148, 56, 66)
				End Select
			Next ctrl
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
            Me.components = New System.ComponentModel.Container
            Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Image1"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
            Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Image2"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
            Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Image3"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
            Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Image4"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
            Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Image5"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
            Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Image6"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
            Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Image7")
            Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Image8")
            Me.listView1 = New System.Windows.Forms.ListView
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.radioButton2 = New System.Windows.Forms.RadioButton
            Me.radioButton3 = New System.Windows.Forms.RadioButton
            Me.radioButton4 = New System.Windows.Forms.RadioButton
            Me.radioButton5 = New System.Windows.Forms.RadioButton
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.radioButton7 = New System.Windows.Forms.RadioButton
            Me.radioButton6 = New System.Windows.Forms.RadioButton
            Me.button1 = New System.Windows.Forms.Button
            Me.button2 = New System.Windows.Forms.Button
            Me.label1 = New System.Windows.Forms.Label
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'listView1
            '
            Me.listView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8})
            Me.listView1.LargeImageList = Me.imageList1
            Me.listView1.Location = New System.Drawing.Point(24, 56)
            Me.listView1.MultiSelect = False
            Me.listView1.Name = "listView1"
            Me.listView1.Size = New System.Drawing.Size(208, 168)
            Me.listView1.SmallImageList = Me.imageList1
            Me.listView1.TabIndex = 0
            Me.listView1.UseCompatibleStateImageBehavior = False
            '
            'imageList1
            '
            Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
            Me.imageList1.ImageSize = New System.Drawing.Size(19, 19)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            '
            'radioButton1
            '
            Me.radioButton1.Location = New System.Drawing.Point(24, 24)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(104, 24)
            Me.radioButton1.TabIndex = 1
            Me.radioButton1.Text = "Light Olive"
            '
            'radioButton2
            '
            Me.radioButton2.Location = New System.Drawing.Point(24, 48)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(104, 24)
            Me.radioButton2.TabIndex = 2
            Me.radioButton2.Text = "Dark Orange"
            '
            'radioButton3
            '
            Me.radioButton3.Location = New System.Drawing.Point(24, 72)
            Me.radioButton3.Name = "radioButton3"
            Me.radioButton3.Size = New System.Drawing.Size(104, 24)
            Me.radioButton3.TabIndex = 3
            Me.radioButton3.Text = "Dull Aqua"
            '
            'radioButton4
            '
            Me.radioButton4.Location = New System.Drawing.Point(24, 96)
            Me.radioButton4.Name = "radioButton4"
            Me.radioButton4.Size = New System.Drawing.Size(104, 24)
            Me.radioButton4.TabIndex = 4
            Me.radioButton4.Text = "Bright Orange"
            '
            'radioButton5
            '
            Me.radioButton5.Location = New System.Drawing.Point(24, 120)
            Me.radioButton5.Name = "radioButton5"
            Me.radioButton5.Size = New System.Drawing.Size(104, 24)
            Me.radioButton5.TabIndex = 5
            Me.radioButton5.Text = "Light Blue"
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.radioButton7)
            Me.groupBox1.Controls.Add(Me.radioButton6)
            Me.groupBox1.Controls.Add(Me.radioButton2)
            Me.groupBox1.Controls.Add(Me.radioButton5)
            Me.groupBox1.Controls.Add(Me.radioButton3)
            Me.groupBox1.Controls.Add(Me.radioButton4)
            Me.groupBox1.Controls.Add(Me.radioButton1)
            Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox1.Location = New System.Drawing.Point(248, 56)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(144, 206)
            Me.groupBox1.TabIndex = 6
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Colors"
            '
            'radioButton7
            '
            Me.radioButton7.Location = New System.Drawing.Point(24, 167)
            Me.radioButton7.Name = "radioButton7"
            Me.radioButton7.Size = New System.Drawing.Size(104, 24)
            Me.radioButton7.TabIndex = 7
            Me.radioButton7.Text = "Maroon"
            '
            'radioButton6
            '
            Me.radioButton6.ForeColor = System.Drawing.Color.White
            Me.radioButton6.Location = New System.Drawing.Point(24, 144)
            Me.radioButton6.Name = "radioButton6"
            Me.radioButton6.Size = New System.Drawing.Size(104, 24)
            Me.radioButton6.TabIndex = 6
            Me.radioButton6.Text = "Violet"
            '
            'button1
            '
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button1.Location = New System.Drawing.Point(40, 235)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 23)
            Me.button1.TabIndex = 7
            Me.button1.Text = "OK"
            '
            'button2
            '
            Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button2.Location = New System.Drawing.Point(136, 235)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(75, 23)
            Me.button2.TabIndex = 8
            Me.button2.Text = "Cancel"
            '
            'label1
            '
            Me.label1.BackColor = System.Drawing.Color.DarkGray
            Me.label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.White
            Me.label1.Location = New System.Drawing.Point(24, 8)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(360, 32)
            Me.label1.TabIndex = 9
            Me.label1.Text = "label1"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'CustomizeForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(410, 264)
            Me.ControlBox = False
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.listView1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.MaximizeBox = False
            Me.Name = "CustomizeForm"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "BreakPoint Customization Editor"
            Me.groupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
		#End Region

		' Close customize form on Cancel button click
		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
			Me.Close()
		End Sub

		' Raise Accepted event on OK button click
		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			If Not Me.AcceptedEvent Is Nothing Then
				RaiseEvent Accepted(Me,EventArgs.Empty)
			End If

			Me.Close()
		End Sub

		Private Sub radioButtonCheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton1.CheckedChanged, radioButton2.CheckedChanged, radioButton3.CheckedChanged, radioButton4.CheckedChanged, radioButton5.CheckedChanged, radioButton6.CheckedChanged, radioButton7.CheckedChanged
			activeRB = CType(IIf(TypeOf sender Is RadioButton, sender, Nothing), RadioButton)
		End Sub

		Private Sub listView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles listView1.SelectedIndexChanged
			For Each lvi As ListViewItem In Me.listView1.Items
				If lvi.Selected = True Then
                    activeLVI = lvi
                    i = lvi.ImageIndex
					Exit For
				End If
			Next lvi
		End Sub

		' Returns the selected color
		Public ReadOnly Overloads Property BackColor() As Color
			Get
				Return activeRB.BackColor
			End Get
		End Property

		' Returns the selected image
		Public ReadOnly Property Image() As Image
			Get
                image_Renamed = Me.imageList1.Images(i)
				Return image_Renamed
			End Get
		End Property
	End Class
End Namespace
