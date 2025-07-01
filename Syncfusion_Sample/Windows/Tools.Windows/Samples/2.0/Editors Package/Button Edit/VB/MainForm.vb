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
Namespace ButtonEditDemo

	''' <summary>
	''' Summary description for MainForm.
	''' </summary>
	Public Class MainForm : Inherits System.Windows.Forms.Form
		Private errorProvider1 As System.Windows.Forms.ErrorProvider

		Private hashLabelNames As Hashtable

		Private groupBox1 As System.Windows.Forms.GroupBox
		Private groupBox2 As System.Windows.Forms.GroupBox

		Private popupControlContainer1 As Syncfusion.Windows.Forms.PopupControlContainer
		Private WithEvents gradientLabel1 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private groupBox5 As System.Windows.Forms.GroupBox
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private WithEvents textBox2 As System.Windows.Forms.TextBox
		Private tabControl1 As System.Windows.Forms.TabControl
		Private tabPage1 As System.Windows.Forms.TabPage
		Private tabPage2 As System.Windows.Forms.TabPage
		Private imageList1 As System.Windows.Forms.ImageList
		Private groupBox4 As System.Windows.Forms.GroupBox
		Private buttonEdit1 As ButtonEdit
		Private WithEvents buttonEditChildButton1 As ButtonEditChildButton
		Private textBoxExt1 As TextBoxExt
		Private buttonEdit3 As ButtonEdit
		Private WithEvents buttonEditChildButton3 As ButtonEditChildButton
		Private textBoxExt3 As TextBoxExt
		Private buttonEdit2 As ButtonEdit
		Private WithEvents buttonEditChildButton2 As ButtonEditChildButton
		Private textBoxExt2 As TextBoxExt
		Private buttonEdit7 As ButtonEdit
		Private buttonEditChildButton13 As ButtonEditChildButton
		Private buttonEditChildButton14 As ButtonEditChildButton
		Private buttonEditChildButton15 As ButtonEditChildButton
		Private buttonEditChildButton16 As ButtonEditChildButton
		Private textBoxExt7 As TextBoxExt
		Private buttonEdit6 As ButtonEdit
		Private buttonEditChildButton10 As ButtonEditChildButton
		Private buttonEditChildButton11 As ButtonEditChildButton
		Private buttonEditChildButton12 As ButtonEditChildButton
		Private textBoxExt6 As TextBoxExt
		Private buttonEdit5 As ButtonEdit
		Private buttonEditChildButton7 As ButtonEditChildButton
		Private buttonEditChildButton8 As ButtonEditChildButton
		Private buttonEditChildButton9 As ButtonEditChildButton
		Private textBoxExt5 As TextBoxExt
		Private buttonEdit4 As ButtonEdit
		Private buttonEditChildButton4 As ButtonEditChildButton
		Private buttonEditChildButton5 As ButtonEditChildButton
		Private buttonEditChildButton6 As ButtonEditChildButton
		Private textBoxExt4 As TextBoxExt
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
			hashLabelNames = New Hashtable()
			Me.popupControlContainer1.ParentControl = Me.buttonEdit3.TextBox
			Me.popupControlContainer1.PopupParent = Me.buttonEdit3
			AddHandler buttonEdit3.TextBox.HandleDestroyed, AddressOf DropDownParentTextBoxDestroyed
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

		Private Sub DropDownParentTextBoxDestroyed(ByVal sender As Object, ByVal args As EventArgs)
			If Not popupControlContainer1 Is Nothing Then
				Me.popupControlContainer1.ParentControl = Nothing
			End If
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
			Me.errorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.buttonEdit2 = New Syncfusion.Windows.Forms.Tools.ButtonEdit()
			Me.buttonEditChildButton2 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.textBoxExt2 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.buttonEdit1 = New Syncfusion.Windows.Forms.Tools.ButtonEdit()
			Me.buttonEditChildButton1 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.textBoxExt1 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
			Me.popupControlContainer1 = New Syncfusion.Windows.Forms.PopupControlContainer()
			Me.gradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.groupBox5 = New System.Windows.Forms.GroupBox()
			Me.buttonEdit3 = New Syncfusion.Windows.Forms.Tools.ButtonEdit()
			Me.buttonEditChildButton3 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.textBoxExt3 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.textBox2 = New System.Windows.Forms.TextBox()
			Me.tabControl1 = New System.Windows.Forms.TabControl()
			Me.tabPage1 = New System.Windows.Forms.TabPage()
			Me.tabPage2 = New System.Windows.Forms.TabPage()
			Me.groupBox4 = New System.Windows.Forms.GroupBox()
			Me.buttonEdit7 = New Syncfusion.Windows.Forms.Tools.ButtonEdit()
			Me.buttonEditChildButton13 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.buttonEditChildButton14 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.buttonEditChildButton15 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.buttonEditChildButton16 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.textBoxExt7 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
			Me.buttonEdit6 = New Syncfusion.Windows.Forms.Tools.ButtonEdit()
			Me.buttonEditChildButton10 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.buttonEditChildButton11 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.buttonEditChildButton12 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.textBoxExt6 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
			Me.buttonEdit5 = New Syncfusion.Windows.Forms.Tools.ButtonEdit()
			Me.buttonEditChildButton7 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.buttonEditChildButton8 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.buttonEditChildButton9 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.textBoxExt5 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
			Me.buttonEdit4 = New Syncfusion.Windows.Forms.Tools.ButtonEdit()
			Me.buttonEditChildButton4 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.buttonEditChildButton5 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.buttonEditChildButton6 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.textBoxExt4 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
			CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			CType(Me.buttonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.buttonEdit2.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			CType(Me.buttonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.buttonEdit1.SuspendLayout()
			Me.popupControlContainer1.SuspendLayout()
			Me.groupBox5.SuspendLayout()
			CType(Me.buttonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.buttonEdit3.SuspendLayout()
			Me.groupBox3.SuspendLayout()
			Me.tabControl1.SuspendLayout()
			Me.tabPage1.SuspendLayout()
			Me.tabPage2.SuspendLayout()
			Me.groupBox4.SuspendLayout()
			CType(Me.buttonEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.buttonEdit7.SuspendLayout()
			CType(Me.buttonEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.buttonEdit6.SuspendLayout()
			CType(Me.buttonEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.buttonEdit5.SuspendLayout()
			CType(Me.buttonEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.buttonEdit4.SuspendLayout()
			Me.SuspendLayout()
			' 
			' errorProvider1
			' 
			Me.errorProvider1.ContainerControl = Me
			Me.errorProvider1.Icon = (CType(resources.GetObject("errorProvider1.Icon"), System.Drawing.Icon))
			' 
			' groupBox1
			' 
			Me.groupBox1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(215)))), (CInt((CByte(221)))), (CInt((CByte(237)))))
			Me.groupBox1.Controls.Add(Me.buttonEdit2)
			Me.groupBox1.Location = New System.Drawing.Point(16, 136)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(264, 48)
			Me.groupBox1.TabIndex = 8
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "FolderBrowser"
			' 
			' buttonEdit2
			' 
			Me.buttonEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.buttonEdit2.Buttons.Add(Me.buttonEditChildButton2)
			Me.buttonEdit2.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonEdit2.Controls.Add(Me.buttonEditChildButton2)
			Me.buttonEdit2.Controls.Add(Me.textBoxExt2)
			Me.buttonEdit2.Location = New System.Drawing.Point(72, 14)
			Me.buttonEdit2.Name = "buttonEdit2"
			Me.buttonEdit2.Size = New System.Drawing.Size(121, 21)
			Me.buttonEdit2.TabIndex = 0
			Me.buttonEdit2.TextBox = Me.textBoxExt2
			Me.buttonEdit2.UseVisualStyle = True
            AddHandler Me.buttonEdit2.ButtonClicked, AddressOf Me.buttonEdit1_ButtonClicked
			' 
			' buttonEditChildButton2
			' 
			Me.buttonEditChildButton2.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton2.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton2.Image = (CType(resources.GetObject("buttonEditChildButton2.Image"), System.Drawing.Image))
			Me.buttonEditChildButton2.ImageIndex = 7
			Me.buttonEditChildButton2.ImageList = Me.imageList1
			Me.buttonEditChildButton2.Name = "buttonEditChildButton2"
			Me.buttonEditChildButton2.PreferredWidth = 18
			Me.buttonEditChildButton2.TabIndex = 1
			Me.buttonEditChildButton2.Text = "buttonEditChildButton2"
'			Me.buttonEditChildButton2.Click += New System.EventHandler(Me.buttonEditChildButton2_Click);
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			Me.imageList1.Images.SetKeyName(4, "")
			Me.imageList1.Images.SetKeyName(5, "")
			Me.imageList1.Images.SetKeyName(6, "")
			Me.imageList1.Images.SetKeyName(7, "")
			' 
			' textBoxExt2
			' 
			Me.textBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.textBoxExt2.Location = New System.Drawing.Point(2, 4)
			Me.textBoxExt2.Name = "textBoxExt2"
			Me.textBoxExt2.OverflowIndicatorToolTipText = Nothing
			Me.textBoxExt2.Size = New System.Drawing.Size(99, 13)
			Me.textBoxExt2.TabIndex = 0
			' 
			' groupBox2
			' 
			Me.groupBox2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(215)))), (CInt((CByte(221)))), (CInt((CByte(237)))))
			Me.groupBox2.Controls.Add(Me.buttonEdit1)
			Me.groupBox2.Location = New System.Drawing.Point(16, 64)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(264, 48)
			Me.groupBox2.TabIndex = 9
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "FileBrowser"
			' 
			' buttonEdit1
			' 
			Me.buttonEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.buttonEdit1.Buttons.Add(Me.buttonEditChildButton1)
			Me.buttonEdit1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonEdit1.Controls.Add(Me.buttonEditChildButton1)
			Me.buttonEdit1.Controls.Add(Me.textBoxExt1)
			Me.buttonEdit1.Location = New System.Drawing.Point(72, 14)
			Me.buttonEdit1.Name = "buttonEdit1"
			Me.buttonEdit1.Size = New System.Drawing.Size(121, 21)
			Me.buttonEdit1.TabIndex = 0
			Me.buttonEdit1.TextBox = Me.textBoxExt1
			Me.buttonEdit1.UseVisualStyle = True
            AddHandler Me.buttonEdit1.ButtonClicked, AddressOf Me.buttonEdit1_ButtonClicked
			' 
			' buttonEditChildButton1
			' 
			Me.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton1.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse
			Me.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton1.Image = (CType(resources.GetObject("buttonEditChildButton1.Image"), System.Drawing.Image))
			Me.buttonEditChildButton1.Name = "buttonEditChildButton1"
			Me.buttonEditChildButton1.PreferredWidth = 18
			Me.buttonEditChildButton1.TabIndex = 1
'			Me.buttonEditChildButton1.Click += New System.EventHandler(Me.buttonEditChildButton1_Click);
			' 
			' textBoxExt1
			' 
			Me.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.textBoxExt1.Location = New System.Drawing.Point(2, 4)
			Me.textBoxExt1.Name = "textBoxExt1"
			Me.textBoxExt1.OverflowIndicatorToolTipText = Nothing
			Me.textBoxExt1.Size = New System.Drawing.Size(99, 13)
			Me.textBoxExt1.TabIndex = 0
			' 
			' popupControlContainer1
			' 
			Me.popupControlContainer1.Controls.Add(Me.gradientLabel1)
			Me.popupControlContainer1.Location = New System.Drawing.Point(552, 16)
			Me.popupControlContainer1.Name = "popupControlContainer1"
			Me.popupControlContainer1.Size = New System.Drawing.Size(240, 200)
			Me.popupControlContainer1.TabIndex = 12
			' 
			' gradientLabel1
			' 
			Me.gradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt((CByte(237)))), (CInt((CByte(240)))), (CInt((CByte(247))))), System.Drawing.SystemColors.ActiveCaption)
			Me.gradientLabel1.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
			Me.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gradientLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, (CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle)), System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel1.Location = New System.Drawing.Point(0, 0)
			Me.gradientLabel1.Name = "gradientLabel1"
			Me.gradientLabel1.Size = New System.Drawing.Size(240, 200)
			Me.gradientLabel1.TabIndex = 0
			Me.gradientLabel1.Text = "Syncfusion"
			Me.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
'			Me.gradientLabel1.Click += New System.EventHandler(Me.gradientLabel1_Click);
			' 
			' groupBox5
			' 
			Me.groupBox5.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(215)))), (CInt((CByte(221)))), (CInt((CByte(237)))))
			Me.groupBox5.Controls.Add(Me.buttonEdit3)
			Me.groupBox5.Location = New System.Drawing.Point(16, 208)
			Me.groupBox5.Name = "groupBox5"
			Me.groupBox5.Size = New System.Drawing.Size(264, 56)
			Me.groupBox5.TabIndex = 13
			Me.groupBox5.TabStop = False
			Me.groupBox5.Text = "DropDown"
			' 
			' buttonEdit3
			' 
			Me.buttonEdit3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.buttonEdit3.Buttons.Add(Me.buttonEditChildButton3)
			Me.buttonEdit3.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonEdit3.Controls.Add(Me.buttonEditChildButton3)
			Me.buttonEdit3.Controls.Add(Me.textBoxExt3)
			Me.buttonEdit3.Location = New System.Drawing.Point(74, 20)
			Me.buttonEdit3.Name = "buttonEdit3"
			Me.buttonEdit3.Size = New System.Drawing.Size(121, 21)
			Me.buttonEdit3.TabIndex = 0
			Me.buttonEdit3.TextBox = Me.textBoxExt3
			Me.buttonEdit3.UseVisualStyle = True
            AddHandler Me.buttonEdit3.ButtonClicked, AddressOf Me.buttonEdit1_ButtonClicked
			' 
			' buttonEditChildButton3
			' 
			Me.buttonEditChildButton3.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton3.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Down
			Me.buttonEditChildButton3.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton3.Image = (CType(resources.GetObject("buttonEditChildButton3.Image"), System.Drawing.Image))
			Me.buttonEditChildButton3.Name = "buttonEditChildButton3"
			Me.buttonEditChildButton3.PreferredWidth = 18
			Me.buttonEditChildButton3.TabIndex = 1
'			Me.buttonEditChildButton3.Click += New System.EventHandler(Me.buttonEditChildButton3_Click);
			' 
			' textBoxExt3
			' 
			Me.textBoxExt3.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.textBoxExt3.Location = New System.Drawing.Point(2, 4)
			Me.textBoxExt3.Name = "textBoxExt3"
			Me.textBoxExt3.OverflowIndicatorToolTipText = Nothing
			Me.textBoxExt3.Size = New System.Drawing.Size(99, 13)
			Me.textBoxExt3.TabIndex = 0
			' 
			' groupBox3
			' 
			Me.groupBox3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(192)))), (CInt((CByte(200)))), (CInt((CByte(219)))))
			Me.groupBox3.Controls.Add(Me.textBox2)
			Me.groupBox3.Location = New System.Drawing.Point(288, 8)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(256, 336)
			Me.groupBox3.TabIndex = 14
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "EventLog"
			' 
			' textBox2
			' 
			Me.textBox2.Location = New System.Drawing.Point(8, 16)
			Me.textBox2.Multiline = True
			Me.textBox2.Name = "textBox2"
			Me.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
			Me.textBox2.Size = New System.Drawing.Size(240, 312)
			Me.textBox2.TabIndex = 4
'			Me.textBox2.TextChanged += New System.EventHandler(Me.textBox2_TextChanged);
			' 
			' tabControl1
			' 
			Me.tabControl1.AllowDrop = True
			Me.tabControl1.Controls.Add(Me.tabPage1)
			Me.tabControl1.Controls.Add(Me.tabPage2)
			Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tabControl1.Location = New System.Drawing.Point(0, 0)
			Me.tabControl1.Multiline = True
			Me.tabControl1.Name = "tabControl1"
			Me.tabControl1.SelectedIndex = 0
			Me.tabControl1.Size = New System.Drawing.Size(552, 374)
			Me.tabControl1.TabIndex = 15
			' 
			' tabPage1
			' 
			Me.tabPage1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(215)))), (CInt((CByte(221)))), (CInt((CByte(237)))))
			Me.tabPage1.Controls.Add(Me.groupBox2)
			Me.tabPage1.Controls.Add(Me.groupBox3)
			Me.tabPage1.Controls.Add(Me.popupControlContainer1)
			Me.tabPage1.Controls.Add(Me.groupBox5)
			Me.tabPage1.Controls.Add(Me.groupBox1)
			Me.tabPage1.Location = New System.Drawing.Point(4, 22)
			Me.tabPage1.Name = "tabPage1"
			Me.tabPage1.Size = New System.Drawing.Size(544, 348)
			Me.tabPage1.TabIndex = 0
			Me.tabPage1.Text = "DropDown's"
			' 
			' tabPage2
			' 
			Me.tabPage2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(215)))), (CInt((CByte(221)))), (CInt((CByte(237)))))
			Me.tabPage2.Controls.Add(Me.groupBox4)
			Me.tabPage2.Location = New System.Drawing.Point(4, 22)
			Me.tabPage2.Name = "tabPage2"
			Me.tabPage2.Size = New System.Drawing.Size(544, 348)
			Me.tabPage2.TabIndex = 1
			Me.tabPage2.Text = "ButtonTypes"
			' 
			' groupBox4
			' 
			Me.groupBox4.Controls.Add(Me.buttonEdit7)
			Me.groupBox4.Controls.Add(Me.buttonEdit6)
			Me.groupBox4.Controls.Add(Me.buttonEdit5)
			Me.groupBox4.Controls.Add(Me.buttonEdit4)
			Me.groupBox4.Location = New System.Drawing.Point(48, 56)
			Me.groupBox4.Name = "groupBox4"
			Me.groupBox4.Size = New System.Drawing.Size(440, 216)
			Me.groupBox4.TabIndex = 14
			Me.groupBox4.TabStop = False
			Me.groupBox4.Text = "ButtonTypes"
			' 
			' buttonEdit7
			' 
			Me.buttonEdit7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.buttonEdit7.Buttons.Add(Me.buttonEditChildButton13)
			Me.buttonEdit7.Buttons.Add(Me.buttonEditChildButton14)
			Me.buttonEdit7.Buttons.Add(Me.buttonEditChildButton15)
			Me.buttonEdit7.Buttons.Add(Me.buttonEditChildButton16)
			Me.buttonEdit7.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonEdit7.Controls.Add(Me.buttonEditChildButton16)
			Me.buttonEdit7.Controls.Add(Me.buttonEditChildButton15)
			Me.buttonEdit7.Controls.Add(Me.buttonEditChildButton14)
			Me.buttonEdit7.Controls.Add(Me.buttonEditChildButton13)
			Me.buttonEdit7.Controls.Add(Me.textBoxExt7)
			Me.buttonEdit7.Location = New System.Drawing.Point(269, 123)
			Me.buttonEdit7.Name = "buttonEdit7"
			Me.buttonEdit7.ShowTextBox = False
			Me.buttonEdit7.Size = New System.Drawing.Size(121, 21)
			Me.buttonEdit7.TabIndex = 3
			Me.buttonEdit7.TextBox = Me.textBoxExt7
			Me.buttonEdit7.UseVisualStyle = True
			' 
			' buttonEditChildButton13
			' 
			Me.buttonEditChildButton13.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton13.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.LeftEnd
			Me.buttonEditChildButton13.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton13.Image = (CType(resources.GetObject("buttonEditChildButton13.Image"), System.Drawing.Image))
			Me.buttonEditChildButton13.Name = "buttonEditChildButton13"
			Me.buttonEditChildButton13.PreferredWidth = 18
			Me.buttonEditChildButton13.TabIndex = 1
			' 
			' buttonEditChildButton14
			' 
			Me.buttonEditChildButton14.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton14.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.RightEnd
			Me.buttonEditChildButton14.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton14.Image = (CType(resources.GetObject("buttonEditChildButton14.Image"), System.Drawing.Image))
			Me.buttonEditChildButton14.Name = "buttonEditChildButton14"
			Me.buttonEditChildButton14.PreferredWidth = 18
			Me.buttonEditChildButton14.TabIndex = 2
			' 
			' buttonEditChildButton15
			' 
			Me.buttonEditChildButton15.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton15.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Redo
			Me.buttonEditChildButton15.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton15.Image = (CType(resources.GetObject("buttonEditChildButton15.Image"), System.Drawing.Image))
			Me.buttonEditChildButton15.Name = "buttonEditChildButton15"
			Me.buttonEditChildButton15.PreferredWidth = 18
			Me.buttonEditChildButton15.TabIndex = 3
			' 
			' buttonEditChildButton16
			' 
			Me.buttonEditChildButton16.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton16.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Undo
			Me.buttonEditChildButton16.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton16.Image = (CType(resources.GetObject("buttonEditChildButton16.Image"), System.Drawing.Image))
			Me.buttonEditChildButton16.Name = "buttonEditChildButton16"
			Me.buttonEditChildButton16.PreferredWidth = 18
			Me.buttonEditChildButton16.TabIndex = 4
			' 
			' textBoxExt7
			' 
			Me.textBoxExt7.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.textBoxExt7.Location = New System.Drawing.Point(2, 4)
			Me.textBoxExt7.Name = "textBoxExt7"
			Me.textBoxExt7.OverflowIndicatorToolTipText = Nothing
			Me.textBoxExt7.Size = New System.Drawing.Size(45, 13)
			Me.textBoxExt7.TabIndex = 0
			Me.textBoxExt7.Text = "buttonEdit7"
			' 
			' buttonEdit6
			' 
			Me.buttonEdit6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.buttonEdit6.Buttons.Add(Me.buttonEditChildButton10)
			Me.buttonEdit6.Buttons.Add(Me.buttonEditChildButton11)
			Me.buttonEdit6.Buttons.Add(Me.buttonEditChildButton12)
			Me.buttonEdit6.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonEdit6.Controls.Add(Me.buttonEditChildButton12)
			Me.buttonEdit6.Controls.Add(Me.buttonEditChildButton11)
			Me.buttonEdit6.Controls.Add(Me.buttonEditChildButton10)
			Me.buttonEdit6.Controls.Add(Me.textBoxExt6)
			Me.buttonEdit6.Location = New System.Drawing.Point(34, 123)
			Me.buttonEdit6.Name = "buttonEdit6"
			Me.buttonEdit6.ShowTextBox = False
			Me.buttonEdit6.Size = New System.Drawing.Size(121, 21)
			Me.buttonEdit6.TabIndex = 2
			Me.buttonEdit6.TextBox = Me.textBoxExt6
			Me.buttonEdit6.UseVisualStyle = True
			' 
			' buttonEditChildButton10
			' 
			Me.buttonEditChildButton10.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton10.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Left
			Me.buttonEditChildButton10.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton10.Image = (CType(resources.GetObject("buttonEditChildButton10.Image"), System.Drawing.Image))
			Me.buttonEditChildButton10.Name = "buttonEditChildButton10"
			Me.buttonEditChildButton10.PreferredWidth = 18
			Me.buttonEditChildButton10.TabIndex = 1
			' 
			' buttonEditChildButton11
			' 
			Me.buttonEditChildButton11.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton11.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Right
			Me.buttonEditChildButton11.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton11.Image = (CType(resources.GetObject("buttonEditChildButton11.Image"), System.Drawing.Image))
			Me.buttonEditChildButton11.Name = "buttonEditChildButton11"
			Me.buttonEditChildButton11.PreferredWidth = 18
			Me.buttonEditChildButton11.TabIndex = 2
			' 
			' buttonEditChildButton12
			' 
			Me.buttonEditChildButton12.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton12.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Check
			Me.buttonEditChildButton12.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton12.Image = (CType(resources.GetObject("buttonEditChildButton12.Image"), System.Drawing.Image))
			Me.buttonEditChildButton12.Name = "buttonEditChildButton12"
			Me.buttonEditChildButton12.PreferredWidth = 18
			Me.buttonEditChildButton12.TabIndex = 3
			' 
			' textBoxExt6
			' 
			Me.textBoxExt6.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.textBoxExt6.Location = New System.Drawing.Point(2, 4)
			Me.textBoxExt6.Name = "textBoxExt6"
			Me.textBoxExt6.OverflowIndicatorToolTipText = Nothing
			Me.textBoxExt6.Size = New System.Drawing.Size(63, 13)
			Me.textBoxExt6.TabIndex = 0
			Me.textBoxExt6.Text = "buttonEdit6"
			' 
			' buttonEdit5
			' 
			Me.buttonEdit5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.buttonEdit5.Buttons.Add(Me.buttonEditChildButton7)
			Me.buttonEdit5.Buttons.Add(Me.buttonEditChildButton8)
			Me.buttonEdit5.Buttons.Add(Me.buttonEditChildButton9)
			Me.buttonEdit5.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonEdit5.Controls.Add(Me.buttonEditChildButton9)
			Me.buttonEdit5.Controls.Add(Me.buttonEditChildButton8)
			Me.buttonEdit5.Controls.Add(Me.buttonEditChildButton7)
			Me.buttonEdit5.Controls.Add(Me.textBoxExt5)
			Me.buttonEdit5.Location = New System.Drawing.Point(267, 57)
			Me.buttonEdit5.Name = "buttonEdit5"
			Me.buttonEdit5.ShowTextBox = False
			Me.buttonEdit5.Size = New System.Drawing.Size(121, 21)
			Me.buttonEdit5.TabIndex = 1
			Me.buttonEdit5.TextBox = Me.textBoxExt5
			Me.buttonEdit5.UseVisualStyle = True
			' 
			' buttonEditChildButton7
			' 
			Me.buttonEditChildButton7.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton7.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton7.Image = (CType(resources.GetObject("buttonEditChildButton7.Image"), System.Drawing.Image))
			Me.buttonEditChildButton7.ImageIndex = 1
			Me.buttonEditChildButton7.ImageList = Me.imageList1
			Me.buttonEditChildButton7.Name = "buttonEditChildButton7"
			Me.buttonEditChildButton7.PreferredWidth = 18
			Me.buttonEditChildButton7.TabIndex = 1
			Me.buttonEditChildButton7.Text = "buttonEditChildButton7"
			' 
			' buttonEditChildButton8
			' 
			Me.buttonEditChildButton8.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton8.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton8.Image = (CType(resources.GetObject("buttonEditChildButton8.Image"), System.Drawing.Image))
			Me.buttonEditChildButton8.ImageIndex = 2
			Me.buttonEditChildButton8.ImageList = Me.imageList1
			Me.buttonEditChildButton8.Name = "buttonEditChildButton8"
			Me.buttonEditChildButton8.PreferredWidth = 18
			Me.buttonEditChildButton8.TabIndex = 2
			Me.buttonEditChildButton8.Text = "buttonEditChildButton8"
			' 
			' buttonEditChildButton9
			' 
			Me.buttonEditChildButton9.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton9.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton9.Image = (CType(resources.GetObject("buttonEditChildButton9.Image"), System.Drawing.Image))
			Me.buttonEditChildButton9.ImageIndex = 3
			Me.buttonEditChildButton9.ImageList = Me.imageList1
			Me.buttonEditChildButton9.Name = "buttonEditChildButton9"
			Me.buttonEditChildButton9.PreferredWidth = 18
			Me.buttonEditChildButton9.TabIndex = 3
			Me.buttonEditChildButton9.Text = "buttonEditChildButton9"
			' 
			' textBoxExt5
			' 
			Me.textBoxExt5.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.textBoxExt5.Location = New System.Drawing.Point(2, 4)
			Me.textBoxExt5.Name = "textBoxExt5"
			Me.textBoxExt5.OverflowIndicatorToolTipText = Nothing
			Me.textBoxExt5.Size = New System.Drawing.Size(63, 13)
			Me.textBoxExt5.TabIndex = 0
			Me.textBoxExt5.Text = "buttonEdit5"
			' 
			' buttonEdit4
			' 
			Me.buttonEdit4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.buttonEdit4.Buttons.Add(Me.buttonEditChildButton4)
			Me.buttonEdit4.Buttons.Add(Me.buttonEditChildButton5)
			Me.buttonEdit4.Buttons.Add(Me.buttonEditChildButton6)
			Me.buttonEdit4.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonEdit4.Controls.Add(Me.buttonEditChildButton6)
			Me.buttonEdit4.Controls.Add(Me.buttonEditChildButton5)
			Me.buttonEdit4.Controls.Add(Me.buttonEditChildButton4)
			Me.buttonEdit4.Controls.Add(Me.textBoxExt4)
			Me.buttonEdit4.Location = New System.Drawing.Point(34, 57)
			Me.buttonEdit4.Name = "buttonEdit4"
			Me.buttonEdit4.ShowTextBox = False
			Me.buttonEdit4.Size = New System.Drawing.Size(121, 21)
			Me.buttonEdit4.TabIndex = 0
			Me.buttonEdit4.TextBox = Me.textBoxExt4
			Me.buttonEdit4.UseVisualStyle = True
			' 
			' buttonEditChildButton4
			' 
			Me.buttonEditChildButton4.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton4.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Down
			Me.buttonEditChildButton4.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton4.Image = (CType(resources.GetObject("buttonEditChildButton4.Image"), System.Drawing.Image))
			Me.buttonEditChildButton4.Name = "buttonEditChildButton4"
			Me.buttonEditChildButton4.PreferredWidth = 18
			Me.buttonEditChildButton4.TabIndex = 1
			' 
			' buttonEditChildButton5
			' 
			Me.buttonEditChildButton5.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton5.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Up
			Me.buttonEditChildButton5.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton5.Image = (CType(resources.GetObject("buttonEditChildButton5.Image"), System.Drawing.Image))
			Me.buttonEditChildButton5.Name = "buttonEditChildButton5"
			Me.buttonEditChildButton5.PreferredWidth = 18
			Me.buttonEditChildButton5.TabIndex = 2
			' 
			' buttonEditChildButton6
			' 
			Me.buttonEditChildButton6.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton6.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Currency
			Me.buttonEditChildButton6.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton6.Image = (CType(resources.GetObject("buttonEditChildButton6.Image"), System.Drawing.Image))
			Me.buttonEditChildButton6.Name = "buttonEditChildButton6"
			Me.buttonEditChildButton6.PreferredWidth = 18
			Me.buttonEditChildButton6.TabIndex = 3
			' 
			' textBoxExt4
			' 
			Me.textBoxExt4.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.textBoxExt4.Location = New System.Drawing.Point(2, 4)
			Me.textBoxExt4.Name = "textBoxExt4"
			Me.textBoxExt4.OverflowIndicatorToolTipText = Nothing
			Me.textBoxExt4.Size = New System.Drawing.Size(63, 13)
			Me.textBoxExt4.TabIndex = 0
			Me.textBoxExt4.Text = "buttonEdit4"
			' 
			' MainForm
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(215)))), (CInt((CByte(221)))), (CInt((CByte(237)))))
			Me.ClientSize = New System.Drawing.Size(552, 374)
			Me.Controls.Add(Me.tabControl1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "MainForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Button Edit"
'			Me.Load += New System.EventHandler(Me.MainForm_Load);
			CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			CType(Me.buttonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.buttonEdit2.ResumeLayout(False)
			Me.buttonEdit2.PerformLayout()
			Me.groupBox2.ResumeLayout(False)
			CType(Me.buttonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.buttonEdit1.ResumeLayout(False)
			Me.buttonEdit1.PerformLayout()
			Me.popupControlContainer1.ResumeLayout(False)
			Me.groupBox5.ResumeLayout(False)
			CType(Me.buttonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.buttonEdit3.ResumeLayout(False)
			Me.buttonEdit3.PerformLayout()
			Me.groupBox3.ResumeLayout(False)
			Me.groupBox3.PerformLayout()
			Me.tabControl1.ResumeLayout(False)
			Me.tabPage1.ResumeLayout(False)
			Me.tabPage2.ResumeLayout(False)
			Me.groupBox4.ResumeLayout(False)
			CType(Me.buttonEdit7, System.ComponentModel.ISupportInitialize).EndInit()
			Me.buttonEdit7.ResumeLayout(False)
			Me.buttonEdit7.PerformLayout()
			CType(Me.buttonEdit6, System.ComponentModel.ISupportInitialize).EndInit()
			Me.buttonEdit6.ResumeLayout(False)
			Me.buttonEdit6.PerformLayout()
			CType(Me.buttonEdit5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.buttonEdit5.ResumeLayout(False)
			Me.buttonEdit5.PerformLayout()
			CType(Me.buttonEdit4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.buttonEdit4.ResumeLayout(False)
			Me.buttonEdit4.PerformLayout()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Public Shared Sub Main()
			Application.Run(New MainForm())
		End Sub



		Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Application.Exit()
		End Sub
		#Region "File"
        Public Sub buttonEditChildButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonEditChildButton1.Click
            '<samplecodeblock name="ButtonEdit ChildButtonClick">
            'buttonEditChildButton1_Click
            Dim dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Title = "Open file"
            dlg.InitialDirectory = "c:\"
            dlg.Filter = "All files (*.*)|*.*"

            If dlg.ShowDialog() = DialogResult.OK Then
                Me.buttonEdit1.TextBox.Text = dlg.FileName
            End If
            '</samplecodeblock>
        End Sub
		#End Region

		#Region "Folder"
		Private Sub buttonEditChildButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonEditChildButton2.Click
			Dim browse As FolderBrowser = New FolderBrowser()
            AddHandler browse.FolderBrowserCallback, AddressOf buttonEditChildButton2_Browsed
			browse.ShowDialog(Me)
		End Sub
		#End Region

		#Region "buttonEditChildButton2_Browsed"
		Private Sub buttonEditChildButton2_Browsed(ByVal sender As Object, ByVal e As FolderBrowserCallbackEventArgs)
			Me.buttonEdit2.TextBox.Text = e.Path
		End Sub
		#End Region
		#Region "ShowpopUp"

		Private Sub buttonEditChildButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonEditChildButton3.Click
			If Me.popupControlContainer1.IsShowing() = True Then
				Me.popupControlContainer1.HidePopup(PopupCloseType.Done)
			Else
				Me.popupControlContainer1.PopupParent = Me.buttonEdit3
				Me.popupControlContainer1.ShowPopup(Point.Empty)
			End If
		End Sub
		#End Region

		#Region "samplecodeblock"
		Private Sub CodeGen_InitializeComponent()
			'<samplecodeblock name="ButtonEdit InitializeComponent">
			' InitializeComponent sample
			Me.buttonEdit1 = New Syncfusion.Windows.Forms.Tools.ButtonEdit()

			Me.buttonEditChildButton1 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.buttonEdit1.SuspendLayout()
			Me.SuspendLayout()

			Me.buttonEdit1.Buttons.Add(Me.buttonEditChildButton1)
			Me.buttonEdit1.Controls.AddRange(New System.Windows.Forms.Control() { Me.buttonEditChildButton1})
			Me.buttonEdit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.buttonEdit1.Location = New System.Drawing.Point(8, 16)
			Me.buttonEdit1.Name = "buttonEdit1"
			Me.buttonEdit1.SelectionLength = 0
			Me.buttonEdit1.SelectionStart = 0
			Me.buttonEdit1.ShowTextBox = True
			Me.buttonEdit1.Size = New System.Drawing.Size(368, 22)
			Me.buttonEdit1.TabIndex = 0
			Me.buttonEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			' 
			' buttonEditChildButton1
			' 
			Me.buttonEditChildButton1.ButtonAlign = Syncfusion.Windows.Forms.Tools.ButtonAlignment.Right
			Me.buttonEditChildButton1.ButtonEditParent = Me.buttonEdit1
			Me.buttonEditChildButton1.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse
			Me.buttonEditChildButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.buttonEditChildButton1.Name = "buttonEditChildButton1"
			Me.buttonEditChildButton1.PreferredWidth = 16
			Me.buttonEditChildButton1.TabIndex = 1
'			Me.buttonEditChildButton1.Click += New System.EventHandler(Me.buttonEditChildButton1_Click);
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(400, 273)
			Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.buttonEdit1})
			Me.Text = "Syncfusion ButtonEdit Demo"
			Me.buttonEdit1.ResumeLayout(False)
			Me.ResumeLayout(False)
			'</samplecodeblock>
		End Sub
		#End Region

		#Region "buttonEdit1_ButtonClicked"
		Private Sub buttonEdit1_ButtonClicked(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs)
			Dim item As String = args.ClickedButton.Name
			Dim eventlogmessage As String = String.Format("Event: {0} Item: {1}" & Constants.vbCrLf, "ButtonClicked", item)
			textBox2.Text = textBox2.Text & eventlogmessage
		End Sub
		#End Region

		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

		End Sub

		Private Sub gradientLabel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gradientLabel1.Click

		End Sub

		Private Sub textBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles textBox2.TextChanged

		End Sub
	End Class
End Namespace
