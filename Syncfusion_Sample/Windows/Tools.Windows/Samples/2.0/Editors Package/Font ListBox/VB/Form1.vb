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

Namespace FontListBoxDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private WithEvents fontListBox1 As Syncfusion.Windows.Forms.Tools.FontListBox
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private label2 As System.Windows.Forms.Label
		Private imageList1 As System.Windows.Forms.ImageList
		Private label1 As System.Windows.Forms.Label
		Private components As System.ComponentModel.IContainer

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
			Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
			Me.fontListBox1 = New Syncfusion.Windows.Forms.Tools.FontListBox()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.label1 = New System.Windows.Forms.Label()
			Me.groupBox1.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' fontListBox1
			' 
			Me.fontListBox1.Location = New System.Drawing.Point(8, 32)
			Me.fontListBox1.Name = "fontListBox1"
			Me.fontListBox1.Size = New System.Drawing.Size(248, 199)
			Me.fontListBox1.TabIndex = 0
'			Me.fontListBox1.SelectedIndexChanged += New System.EventHandler(Me.fontListBox1_SelectedIndexChanged);
			' 
			' groupBox1
			' 
			Me.groupBox1.BackColor = System.Drawing.Color.FromArgb((CByte(192)), (CByte(200)), (CByte(219)))
			Me.groupBox1.Controls.AddRange(New System.Windows.Forms.Control() { Me.fontListBox1})
			Me.groupBox1.ForeColor = System.Drawing.Color.Black
			Me.groupBox1.Location = New System.Drawing.Point(8, 112)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(272, 248)
			Me.groupBox1.TabIndex = 2
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "FontListBox displays all fonts installed on system"
			' 
			' groupBox2
			' 
			Me.groupBox2.BackColor = System.Drawing.Color.FromArgb((CByte(192)), (CByte(200)), (CByte(219)))
			Me.groupBox2.Controls.AddRange(New System.Windows.Forms.Control() { Me.label2})
			Me.groupBox2.ForeColor = System.Drawing.Color.Black
			Me.groupBox2.Location = New System.Drawing.Point(288, 112)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(264, 248)
			Me.groupBox2.TabIndex = 10
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Font of label Changes"
			' 
			' label2
			' 
			Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Image = (CType(resources.GetObject("label2.Image"), System.Drawing.Bitmap))
			Me.label2.ImageIndex = 0
			Me.label2.ImageList = Me.imageList1
			Me.label2.Location = New System.Drawing.Point(32, 80)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(200, 64)
			Me.label2.TabIndex = 0
			Me.label2.Text = "Traffic Signal"
			Me.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' imageList1
			' 
			Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
			Me.imageList1.ImageSize = New System.Drawing.Size(32, 32)
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			' 
			' label1
			' 
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Image = (CType(resources.GetObject("label1.Image"), System.Drawing.Bitmap))
			Me.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight
			Me.label1.ImageIndex = 1
			Me.label1.ImageList = Me.imageList1
			Me.label1.Location = New System.Drawing.Point(56, 24)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(464, 48)
			Me.label1.TabIndex = 11
			Me.label1.Text = "FontListBox is a list box derived control that gets automatically populated with " & "the fonts installed on the user's system."
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CByte(192)), (CByte(200)), (CByte(219)))
			Me.ClientSize = New System.Drawing.Size(560, 374)
			Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.label1, Me.groupBox1, Me.groupBox2})
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Font ListBox"
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox2.ResumeLayout(False)
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
		#Region "SelectedIndexChanged"
		Private Sub fontListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fontListBox1.SelectedIndexChanged
			Me.label2.Font = New Font(Me.fontListBox1.SelectedItem.ToString (),11,FontStyle.Regular)

		End Sub
		#End Region
	End Class
End Namespace
