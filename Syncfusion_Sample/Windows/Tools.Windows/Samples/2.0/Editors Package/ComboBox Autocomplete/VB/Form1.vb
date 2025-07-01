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
Imports System.Data
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms

Namespace ComboBoxAutoCompleteDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private itemsList As ArrayList = New ArrayList()
		Private alphaList As ArrayList = New ArrayList()
		Private components As System.ComponentModel.IContainer
		Private label1 As System.Windows.Forms.Label
		Private imageList1 As System.Windows.Forms.ImageList
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private comboBoxAutoComplete1 As Syncfusion.Windows.Forms.Tools.ComboBoxAutoComplete

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
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
			Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
			Me.comboBoxAutoComplete1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAutoComplete()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			CType(Me.comboBoxAutoComplete1.AutoCompleteControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' comboBoxAutoComplete1
			' 
			' 
			' comboBoxAutoComplete1.AutoCompleteControl
			' 
			Me.comboBoxAutoComplete1.AutoCompleteControl.AccessibleDescription = Nothing
			Me.comboBoxAutoComplete1.AutoCompleteControl.AccessibleName = Nothing
			Me.comboBoxAutoComplete1.AutoCompleteControl.AccessibleRole = System.Windows.Forms.AccessibleRole.None
			Me.comboBoxAutoComplete1.AutoCompleteControl.AdjustHeightToItemCount = True
			Me.comboBoxAutoComplete1.AutoCompleteControl.AutoAddItem = False
			Me.comboBoxAutoComplete1.AutoCompleteControl.AutoSerialize = True
			Me.comboBoxAutoComplete1.AutoCompleteControl.CategoryName = ""
			Me.comboBoxAutoComplete1.AutoCompleteControl.ChangeDataManagerPosition = True
			Me.comboBoxAutoComplete1.AutoCompleteControl.OverrideCombo = True
			Me.comboBoxAutoComplete1.AutoCompleteControl.ParentForm = Me.groupBox1
			Me.comboBoxAutoComplete1.AutoCompleteControl.PreferredHeight = 200
			Me.comboBoxAutoComplete1.AutoCompleteControl.SelectedIndex = -1
			Me.comboBoxAutoComplete1.AutoCompleteControl.SelectedValue = ""
			Me.comboBoxAutoComplete1.AutoCompleteControl.ShowCloseButton = True
			Me.comboBoxAutoComplete1.AutoCompleteControl.ShowGripper = True
			Me.comboBoxAutoComplete1.DropDownWidth = 352
			Me.comboBoxAutoComplete1.ForeColor = System.Drawing.SystemColors.HotTrack
			Me.comboBoxAutoComplete1.ItemHeight = 13
			Me.comboBoxAutoComplete1.Location = New System.Drawing.Point(64, 136)
			Me.comboBoxAutoComplete1.Name = "comboBoxAutoComplete1"
			Me.comboBoxAutoComplete1.ParentForm = Me.groupBox1
			Me.comboBoxAutoComplete1.Size = New System.Drawing.Size(240, 21)
			Me.comboBoxAutoComplete1.TabIndex = 4
			Me.comboBoxAutoComplete1.UpdateComboSelectionProperties = True

			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.AddRange(New System.Windows.Forms.Control() { Me.label1, Me.comboBoxAutoComplete1})
			Me.groupBox1.Location = New System.Drawing.Point(88, 48)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(376, 216)
			Me.groupBox1.TabIndex = 6
			Me.groupBox1.TabStop = False
			' 
			' label1
			' 
			Me.label1.Image = (CType(resources.GetObject("label1.Image"), System.Drawing.Bitmap))
			Me.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight
			Me.label1.ImageIndex = 0
			Me.label1.ImageList = Me.imageList1
			Me.label1.Location = New System.Drawing.Point(64, 32)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(256, 80)
			Me.label1.TabIndex = 5
			Me.label1.Text = "The ComboBoxAutoComplete control combines a combo box control with an AutoComplet" & "e control to provide autocompletion for that instance of the combo box."
			' 
			' imageList1
			' 
			Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
			Me.imageList1.ImageSize = New System.Drawing.Size(32, 32)
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CByte(192)), (CByte(200)), (CByte(219)))
			Me.ClientSize = New System.Drawing.Size(552, 374)
			Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.groupBox1})
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "ComboBox AutoComplete"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.comboBoxAutoComplete1.AutoCompleteControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

			Me.alphaList.AddRange(New String(){"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" })

			Dim s As String
			For Each s In Me.alphaList
				Dim i As Integer
				For i = 0 To 14
					Me.itemsList.Add(s & i.ToString())
				Next i
			Next s

			Me.comboBoxAutoComplete1.AutoCompleteControl.DataSource = Me.itemsList
			Me.comboBoxAutoComplete1.DropDownWidth = Me.comboBoxAutoComplete1.Width
		End Sub



	End Class
End Namespace
