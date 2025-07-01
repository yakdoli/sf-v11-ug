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
Imports Syncfusion.Windows.Forms

Namespace ComboDropDownDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits Office2007Form
		Private WithEvents comboDropDown1 As Syncfusion.Windows.Forms.Tools.ComboDropDown
		Private WithEvents treeView1 As System.Windows.Forms.TreeView
		Private WithEvents gridListControl1 As Syncfusion.Windows.Forms.Grid.GridListControl
		Private comboDropDown2 As Syncfusion.Windows.Forms.Tools.ComboDropDown
		Private imageList1 As System.Windows.Forms.ImageList
		Private label1 As System.Windows.Forms.Label
		Private WithEvents comboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private autoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
		Private label20 As Label
		Private label19 As Label
		Private label2 As Label
		Private label3 As Label
		Private autoLabel2 As Syncfusion.Windows.Forms.Tools.AutoLabel
		Private WithEvents comboBoxAdv2 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private label4 As Label
		Private label5 As Label
		Private bannerTextProvider1 As BannerTextProvider
		Private label6 As Label
		Private label7 As Label
		Private WithEvents bannerClrEdit As Syncfusion.Windows.Forms.Tools.ButtonEdit
		Private buttonEditChildButton1 As Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
		Private textBoxExt1 As Syncfusion.Windows.Forms.Tools.TextBoxExt
		Private label8 As Label
		Private label9 As Label
		Private label10 As Label
		Private rdoEdit As RadioButton
		Private rdoFocus As RadioButton
		Private txtBanner As TextBox
		Private WithEvents btnSetBanner As Button
		Private colorDialog1 As ColorDialog
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
			Me.treeView1.ExpandAll()


            'GridList
			Dim USStates As ArrayList = New ArrayList()
			USStates.Add(New USState("Alaska", "AK", 1))
			USStates.Add(New USState("Arizona", "AZ", 2))
			USStates.Add(New USState("Arkansas", "AK", 3))
			USStates.Add(New USState("California", "CA", 4))
			USStates.Add(New USState("Colorado", "CO", 5))
			USStates.Add(New USState("Connecticut", "CT", 6))
			USStates.Add(New USState("Delaware", "DE", 3))
			USStates.Add(New USState("Florida", "FL", 4))
			USStates.Add(New USState("Georgia", "GA", 1))
			USStates.Add(New USState("Hawaii", "HI", 0))
			USStates.Add(New USState("Idaho", "ID", 3))
			USStates.Add(New USState("Illinois", "IL", 2))
			USStates.Add(New USState("Indiana", "IN", 6))
			USStates.Add(New USState("Iowa", "IA", 5))
			USStates.Add(New USState("Kansas", "KA", 5))
			USStates.Add(New USState("Kentucky", "KY", 4))
			USStates.Add(New USState("Louisiana", "LA", 3))
			USStates.Add(New USState("Maine", "ME", 0))
			USStates.Add(New USState("Maryland", "MD", 0))
			USStates.Add(New USState("Massachusetts", "MA", 2))
			USStates.Add(New USState("Michigan", "MI", 1))
			USStates.Add(New USState("Minnesota", "MN", 6))
			USStates.Add(New USState("Mississippi", "MS", 5))
			USStates.Add(New USState("Missouri", "MO", 2))
			USStates.Add(New USState("Montana", "MT", 1))
			USStates.Add(New USState("Nebraska", "NE", 4))
			USStates.Add(New USState("Nevada", "NV", 0))
			USStates.Add(New USState("New Hampshire", "NH", 3))
			USStates.Add(New USState("New Jersey", "NJ", 3))
			USStates.Add(New USState("New Mexico", "NM", 2))
			USStates.Add(New USState("New York", "NY", 5))
			USStates.Add(New USState("North Carolina", "NC", 4))
			USStates.Add(New USState("North Dakota", "ND", 4))
			USStates.Add(New USState("Ohio", "OH", 1))
			USStates.Add(New USState("Oklahoma", "OK", 2))
			USStates.Add(New USState("Oregon", "OR", 5))
			USStates.Add(New USState("Pennsylvania", "PA", 0))
			USStates.Add(New USState("Rhode Island", "RI", 6))
			USStates.Add(New USState("South Carolina", "SC", 5))
			USStates.Add(New USState("South Dakota", "SD", 4))
			USStates.Add(New USState("Tennessee", "TN", 3))
			USStates.Add(New USState("Texas", "TX", 2))
			USStates.Add(New USState("Utah", "UT", 0))
			USStates.Add(New USState("Vermont", "VT", 1))
			USStates.Add(New USState("Virginia", "VA", 0))
			USStates.Add(New USState("Washington", "WA", 2))
			USStates.Add(New USState("West Virginia", "WV", 0))
			USStates.Add(New USState("Wisconsin", "WI", 3))
			USStates.Add(New USState("Wyoming", "WY", 5))


			Dim imageList2 As ImageList = New ImageList()
			imageList2.ImageSize = New Size(15, 15)
			imageList2.Images.Add(New Bitmap("..\\..\ImageList\add2.png"))
			imageList2.Images.Add(New Bitmap("..\\..\ImageList\bug_green.png"))
			imageList2.Images.Add(New Bitmap("..\\..\ImageList\star_blue.png"))
			imageList2.Images.Add(New Bitmap("..\\..\ImageList\navigate_check.png"))
			imageList2.Images.Add(New Bitmap("..\\..\ImageList\jar_bean_delete.png"))
			imageList2.Images.Add(New Bitmap("..\\..\ImageList\console.png"))
			imageList2.Images.Add(New Bitmap("..\\..\ImageList\delete2.png"))
			imageList2.Images.Add(New Bitmap("..\\..\ImageList\layout_horizontal.png"))

			Me.gridListControl1.ImageList = imageList2


			Me.gridListControl1.BeginUpdate()
			Me.gridListControl1.DataSource = USStates
			Me.gridListControl1.DisplayMember = "LongName"
			Me.gridListControl1.ValueMember = "ShortName"
			Me.gridListControl1.MultiColumn = True
			Me.gridListControl1.ShowColumnHeader = True
			Me.gridListControl1.SelectionMode = SelectionMode.One
			Me.gridListControl1.ThemesEnabled = True
			Me.gridListControl1.Grid.VerticalThumbTrack = True



			Me.gridListControl1.FillLastColumn = True
			Me.gridListControl1.EndUpdate()

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
            Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node1")
            Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node0", New System.Windows.Forms.TreeNode() {TreeNode1})
            Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node10")
            Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node3")
            Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node2", New System.Windows.Forms.TreeNode() {TreeNode4})
            Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node5")
            Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node4", New System.Windows.Forms.TreeNode() {TreeNode6})
            Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node7")
            Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node6", New System.Windows.Forms.TreeNode() {TreeNode8})
            Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node9")
            Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node8", New System.Windows.Forms.TreeNode() {TreeNode10})
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.comboDropDown1 = New Syncfusion.Windows.Forms.Tools.ComboDropDown
            Me.treeView1 = New System.Windows.Forms.TreeView
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.comboDropDown2 = New Syncfusion.Windows.Forms.Tools.ComboDropDown
            Me.gridListControl1 = New Syncfusion.Windows.Forms.Grid.GridListControl
            Me.autoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.label1 = New System.Windows.Forms.Label
            Me.label20 = New System.Windows.Forms.Label
            Me.label19 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.autoLabel2 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.comboBoxAdv2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.label4 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.bannerTextProvider1 = New Syncfusion.Windows.Forms.BannerTextProvider(Me.components)
            Me.label6 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.bannerClrEdit = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton1 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.textBoxExt1 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.label8 = New System.Windows.Forms.Label
            Me.label9 = New System.Windows.Forms.Label
            Me.label10 = New System.Windows.Forms.Label
            Me.rdoEdit = New System.Windows.Forms.RadioButton
            Me.rdoFocus = New System.Windows.Forms.RadioButton
            Me.txtBanner = New System.Windows.Forms.TextBox
            Me.btnSetBanner = New System.Windows.Forms.Button
            Me.colorDialog1 = New System.Windows.Forms.ColorDialog
            CType(Me.comboDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboDropDown2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bannerClrEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.bannerClrEdit.SuspendLayout()
            Me.SuspendLayout()
            '
            'comboDropDown1
            '
            Me.comboDropDown1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.bannerTextProvider1.SetBannerText(Me.comboDropDown1, New Syncfusion.Windows.Forms.BannerTextInfo("[Select]", True, Nothing, System.Drawing.SystemColors.ControlDark, Syncfusion.Windows.Forms.BannerTextMode.FocusMode))
            Me.comboDropDown1.IgnoreThemeBackground = True
            Me.comboDropDown1.Location = New System.Drawing.Point(24, 126)
            Me.comboDropDown1.Name = "comboDropDown1"
            Me.comboDropDown1.PopupControl = Me.treeView1
            Me.comboDropDown1.Size = New System.Drawing.Size(175, 21)
            Me.comboDropDown1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.comboDropDown1.SuppressDropDownEvent = False
            Me.comboDropDown1.TabIndex = 0
            '
            'treeView1
            '
            Me.treeView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.treeView1.HideSelection = False
            Me.treeView1.HotTracking = True
            Me.treeView1.ImageIndex = 3
            Me.treeView1.ImageList = Me.imageList1
            Me.treeView1.ItemHeight = 34
            Me.treeView1.LabelEdit = True
            Me.treeView1.Location = New System.Drawing.Point(451, 58)
            Me.treeView1.Name = "treeView1"
            TreeNode1.Name = ""
            TreeNode1.Text = "Node1"
            TreeNode2.Name = ""
            TreeNode2.Text = "Node0"
            TreeNode3.Name = ""
            TreeNode3.Text = "Node10"
            TreeNode4.Name = ""
            TreeNode4.Text = "Node3"
            TreeNode5.Name = ""
            TreeNode5.Text = "Node2"
            TreeNode6.Name = ""
            TreeNode6.Text = "Node5"
            TreeNode7.Name = ""
            TreeNode7.Text = "Node4"
            TreeNode8.Name = ""
            TreeNode8.Text = "Node7"
            TreeNode9.Name = ""
            TreeNode9.Text = "Node6"
            TreeNode10.Name = ""
            TreeNode10.Text = "Node9"
            TreeNode11.Name = ""
            TreeNode11.Text = "Node8"
            Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3, TreeNode5, TreeNode7, TreeNode9, TreeNode11})
            Me.treeView1.SelectedImageIndex = 0
            Me.treeView1.Size = New System.Drawing.Size(174, 166)
            Me.treeView1.Sorted = True
            Me.treeView1.TabIndex = 1
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
            Me.imageList1.Images.SetKeyName(2, "")
            Me.imageList1.Images.SetKeyName(3, "")
            '
            'comboDropDown2
            '
            Me.comboDropDown2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.bannerTextProvider1.SetBannerText(Me.comboDropDown2, New Syncfusion.Windows.Forms.BannerTextInfo("[Select]", True, Nothing, System.Drawing.SystemColors.ControlDark, Syncfusion.Windows.Forms.BannerTextMode.FocusMode))
            Me.comboDropDown2.IgnoreThemeBackground = True
            Me.comboDropDown2.Location = New System.Drawing.Point(233, 126)
            Me.comboDropDown2.Name = "comboDropDown2"
            Me.comboDropDown2.PopupControl = Me.gridListControl1
            Me.comboDropDown2.Size = New System.Drawing.Size(175, 21)
            Me.comboDropDown2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.comboDropDown2.SuppressDropDownEvent = False
            Me.comboDropDown2.TabIndex = 4
            '
            'gridListControl1
            '
            Me.gridListControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.gridListControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.gridListControl1.DisplayMember = "LongName"
            Me.gridListControl1.FillLastColumn = True
            Me.gridListControl1.ItemHeight = 17
            Me.gridListControl1.Location = New System.Drawing.Point(451, 187)
            Me.gridListControl1.MultiColumn = True
            Me.gridListControl1.Name = "gridListControl1"
            Me.gridListControl1.Properties.BackgroundColor = System.Drawing.SystemColors.Window
            Me.gridListControl1.SelectedIndex = -1
            Me.gridListControl1.Size = New System.Drawing.Size(175, 176)
            Me.gridListControl1.TabIndex = 2
            Me.gridListControl1.ThemesEnabled = True
            Me.gridListControl1.TopIndex = 0
            Me.gridListControl1.ValueMember = "ShortName"
            '
            'autoLabel1
            '
            Me.autoLabel1.DX = 0
            Me.autoLabel1.DY = 0
            Me.autoLabel1.Location = New System.Drawing.Point(24, 225)
            Me.autoLabel1.Name = "autoLabel1"
            Me.autoLabel1.Size = New System.Drawing.Size(35, 13)
            Me.autoLabel1.TabIndex = 4
            Me.autoLabel1.Text = "Styles"
            '
            'comboBoxAdv1
            '
            Me.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxAdv1.IgnoreThemeBackground = True
            Me.comboBoxAdv1.Items.AddRange(New Object() {"Default", "OfficeXP", "Office2003", "VS2005", "Office2007"})
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Default"))
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "OfficeXP"))
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Office2003"))
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "VS2005"))
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Office2007"))
            Me.comboBoxAdv1.Location = New System.Drawing.Point(100, 225)
            Me.comboBoxAdv1.Name = "comboBoxAdv1"
            Me.comboBoxAdv1.Size = New System.Drawing.Size(101, 21)
            Me.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.comboBoxAdv1.SuppressDropDownEvent = False
            Me.comboBoxAdv1.TabIndex = 3
            Me.comboBoxAdv1.Text = "Office2007"
            '
            'label1
            '
            Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label1.ImageIndex = 2
            Me.label1.ImageList = Me.imageList1
            Me.label1.Location = New System.Drawing.Point(12, 9)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(453, 62)
            Me.label1.TabIndex = 2
            Me.label1.Text = resources.GetString("label1.Text")
            '
            'label20
            '
            Me.label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label20.Location = New System.Drawing.Point(21, 108)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(180, 1)
            Me.label20.TabIndex = 24
            '
            'label19
            '
            Me.label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label19.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label19.Image = CType(resources.GetObject("label19.Image"), System.Drawing.Image)
            Me.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label19.Location = New System.Drawing.Point(21, 85)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(114, 23)
            Me.label19.TabIndex = 25
            Me.label19.Text = "With TreeView"
            Me.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label2
            '
            Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label2.Location = New System.Drawing.Point(230, 108)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(180, 1)
            Me.label2.TabIndex = 26
            '
            'label3
            '
            Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label3.Image = CType(resources.GetObject("label3.Image"), System.Drawing.Image)
            Me.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label3.Location = New System.Drawing.Point(230, 85)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(143, 23)
            Me.label3.TabIndex = 27
            Me.label3.Text = "With GridListControl"
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'autoLabel2
            '
            Me.autoLabel2.DX = 0
            Me.autoLabel2.DY = 0
            Me.autoLabel2.Location = New System.Drawing.Point(24, 259)
            Me.autoLabel2.Name = "autoLabel2"
            Me.autoLabel2.Size = New System.Drawing.Size(70, 13)
            Me.autoLabel2.TabIndex = 29
            Me.autoLabel2.Text = "ColorScheme"
            '
            'comboBoxAdv2
            '
            Me.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxAdv2.IgnoreThemeBackground = True
            Me.comboBoxAdv2.Items.AddRange(New Object() {"Blue", "Silver", "Black"})
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "Blue"))
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "Silver"))
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "Black"))
            Me.comboBoxAdv2.Location = New System.Drawing.Point(100, 259)
            Me.comboBoxAdv2.Name = "comboBoxAdv2"
            Me.comboBoxAdv2.Size = New System.Drawing.Size(101, 21)
            Me.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.comboBoxAdv2.SuppressDropDownEvent = False
            Me.comboBoxAdv2.TabIndex = 28
            Me.comboBoxAdv2.Text = "Blue"
            '
            'label4
            '
            Me.label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label4.Location = New System.Drawing.Point(21, 207)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(180, 1)
            Me.label4.TabIndex = 30
            '
            'label5
            '
            Me.label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label5.Image = CType(resources.GetObject("label5.Image"), System.Drawing.Image)
            Me.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label5.Location = New System.Drawing.Point(21, 184)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(103, 23)
            Me.label5.TabIndex = 31
            Me.label5.Text = "Visual Styles"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label6
            '
            Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label6.Location = New System.Drawing.Point(230, 208)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(180, 1)
            Me.label6.TabIndex = 32
            '
            'label7
            '
            Me.label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label7.Image = CType(resources.GetObject("label7.Image"), System.Drawing.Image)
            Me.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label7.Location = New System.Drawing.Point(230, 185)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(148, 23)
            Me.label7.TabIndex = 33
            Me.label7.Text = "BannerText Settings"
            Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'bannerClrEdit
            '
            Me.bannerClrEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.bannerClrEdit.Buttons.Add(Me.buttonEditChildButton1)
            Me.bannerClrEdit.Controls.Add(Me.buttonEditChildButton1)
            Me.bannerClrEdit.Controls.Add(Me.textBoxExt1)
            Me.bannerClrEdit.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.bannerClrEdit.Location = New System.Drawing.Point(291, 292)
            Me.bannerClrEdit.Name = "bannerClrEdit"
            Me.bannerClrEdit.Size = New System.Drawing.Size(121, 21)
            Me.bannerClrEdit.TabIndex = 34
            Me.bannerClrEdit.TextBox = Me.textBoxExt1
            '
            'buttonEditChildButton1
            '
            Me.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.buttonEditChildButton1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonEditChildButton1.Image = Nothing
            Me.buttonEditChildButton1.Name = "buttonEditChildButton1"
            Me.buttonEditChildButton1.PreferredWidth = 20
            Me.buttonEditChildButton1.TabIndex = 1
            Me.buttonEditChildButton1.Text = "..."
            '
            'textBoxExt1
            '
            Me.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBoxExt1.Location = New System.Drawing.Point(3, 4)
            Me.textBoxExt1.Name = "textBoxExt1"
            Me.textBoxExt1.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt1.Size = New System.Drawing.Size(95, 13)
            Me.textBoxExt1.TabIndex = 0
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Location = New System.Drawing.Point(230, 218)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(28, 13)
            Me.label8.TabIndex = 2
            Me.label8.Text = "Text"
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Location = New System.Drawing.Point(230, 250)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(34, 13)
            Me.label9.TabIndex = 3
            Me.label9.Text = "Mode"
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Location = New System.Drawing.Point(230, 292)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(31, 13)
            Me.label10.TabIndex = 4
            Me.label10.Text = "Color"
            '
            'rdoEdit
            '
            Me.rdoEdit.AutoSize = True
            Me.rdoEdit.Location = New System.Drawing.Point(291, 246)
            Me.rdoEdit.Name = "rdoEdit"
            Me.rdoEdit.Size = New System.Drawing.Size(73, 17)
            Me.rdoEdit.TabIndex = 35
            Me.rdoEdit.Text = "Edit Mode"
            Me.rdoEdit.UseVisualStyleBackColor = True
            '
            'rdoFocus
            '
            Me.rdoFocus.AutoSize = True
            Me.rdoFocus.Checked = True
            Me.rdoFocus.Location = New System.Drawing.Point(291, 269)
            Me.rdoFocus.Name = "rdoFocus"
            Me.rdoFocus.Size = New System.Drawing.Size(84, 17)
            Me.rdoFocus.TabIndex = 36
            Me.rdoFocus.TabStop = True
            Me.rdoFocus.Text = "Focus Mode"
            Me.rdoFocus.UseVisualStyleBackColor = True
            '
            'txtBanner
            '
            Me.txtBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtBanner.Location = New System.Drawing.Point(291, 216)
            Me.txtBanner.Name = "txtBanner"
            Me.txtBanner.Size = New System.Drawing.Size(120, 20)
            Me.txtBanner.TabIndex = 37
            '
            'btnSetBanner
            '
            Me.btnSetBanner.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnSetBanner.Location = New System.Drawing.Point(258, 325)
            Me.btnSetBanner.Name = "btnSetBanner"
            Me.btnSetBanner.Size = New System.Drawing.Size(131, 23)
            Me.btnSetBanner.TabIndex = 38
            Me.btnSetBanner.Text = "Set Banner Text"
            Me.btnSetBanner.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(477, 367)
            Me.Controls.Add(Me.gridListControl1)
            Me.Controls.Add(Me.treeView1)
            Me.Controls.Add(Me.btnSetBanner)
            Me.Controls.Add(Me.txtBanner)
            Me.Controls.Add(Me.rdoFocus)
            Me.Controls.Add(Me.rdoEdit)
            Me.Controls.Add(Me.label8)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.label10)
            Me.Controls.Add(Me.bannerClrEdit)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.autoLabel2)
            Me.Controls.Add(Me.comboBoxAdv2)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.autoLabel1)
            Me.Controls.Add(Me.comboDropDown2)
            Me.Controls.Add(Me.comboBoxAdv1)
            Me.Controls.Add(Me.comboDropDown1)
            Me.Controls.Add(Me.label20)
            Me.Controls.Add(Me.label19)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Combo DropDown"
            CType(Me.comboDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboDropDown2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridListControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bannerClrEdit, System.ComponentModel.ISupportInitialize).EndInit()
            Me.bannerClrEdit.ResumeLayout(False)
            Me.bannerClrEdit.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub
		#Region "DoubleClick"
		Private Sub treeView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles treeView1.DoubleClick
			If Not Me.treeView1.SelectedNode Is Nothing Then
				' Set the combo's text to be the TreeNode's Text.
				Me.comboDropDown1.Text = Me.treeView1.SelectedNode.Text
			Else
				Me.comboDropDown1.Text = String.Empty
			End If

			' Close the dropdown.
			Me.comboDropDown1.PopupContainer.HidePopup(PopupCloseType.Done)
		End Sub
		#End Region
		#Region "AfterDropDownPopup"
		Private Sub AfterDropDownPopup(ByVal sender As Object, ByVal e As EventArgs)
			' Uncomment this line, if you want the tree to take focus on droddown.
			' this.treeView1.Focus();
		End Sub
		#End Region
		#Region "DropDown"
		Private Sub comboDropDown1_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboDropDown1.DropDown
			' Before the dropdown is shown, select a TreeNode based on the text in the combo.
			If Me.comboDropDown1.Text <> String.Empty Then
				Dim matchedNode As TreeNode = Me.FindNode(Me.treeView1.Nodes, Me.comboDropDown1.Text)
				Me.treeView1.SelectedNode = matchedNode
			End If
		End Sub
		#End Region
		#Region "TreeNode"
		' Recursively traverse through all the nodes looking for a node with the specified text.
		Private Function FindNode(ByVal nodes As TreeNodeCollection, ByVal text As String) As TreeNode
			For Each child As TreeNode In nodes
				If child.Text = text Then
					Return child
				End If
			Next child

			For Each child As TreeNode In nodes
				Dim matched As TreeNode = Me.FindNode(child.Nodes, text)
				If Not matched Is Nothing Then
					Return matched
				End If
			Next child

			Return Nothing
		End Function
		#End Region
		#Region "SelectedValueChanged"
		Private Sub gridListControl1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridListControl1.SelectedValueChanged
			If Me.gridListControl1.SelectedIndex <> -1 Then
				Me.comboDropDown2.TextBox.Text = Me.gridListControl1.SelectedValue.ToString()

			End If

		End Sub
		#End Region

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Listen to the Popup event
			AddHandler comboDropDown1.PopupContainer.Popup, AddressOf AfterDropDownPopup
			AddHandler Application.Idle, AddressOf Application_Idle
		End Sub

		#Region "BannerText Settings"
		Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
			If txtBanner.Text = "" Then
				btnSetBanner.Enabled = False
			Else
				btnSetBanner.Enabled = True
			End If
		End Sub

		Private Sub bannerClrEdit_ButtonClicked(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs) Handles bannerClrEdit.ButtonClicked
            If colorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.bannerClrEdit.TextBox.BackColor = colorDialog1.Color
            End If
		End Sub

		Private Sub btnSetBanner_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSetBanner.Click
			Dim mode As BannerTextMode
			If rdoEdit.Checked Then
				mode = BannerTextMode.EditMode
			Else
				mode = BannerTextMode.FocusMode
			End If
			Dim binfo As BannerTextInfo = Me.bannerTextProvider1.GetBannerText(Me.comboDropDown1)
			binfo.Text = txtBanner.Text
			binfo.Mode = mode
			binfo.Color = bannerClrEdit.TextBox.BackColor
			Dim binfo2 As BannerTextInfo = Me.bannerTextProvider1.GetBannerText(Me.comboDropDown2)
			binfo2.Text = txtBanner.Text
			binfo2.Mode = mode
			binfo2.Color = bannerClrEdit.TextBox.BackColor
			Me.comboDropDown1.Refresh()
			Me.comboDropDown2.Refresh()

		End Sub
		#End Region

		#Region "Styles"

		Private Sub comboBoxAdv1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxAdv1.SelectedIndexChanged
			Select Case Me.comboBoxAdv1.SelectedItem.ToString()
				Case "Default"
						Me.comboDropDown1.Style = VisualStyle.Default
						 Me.comboDropDown2.Style = VisualStyle.Default
						 Me.comboBoxAdv2.Enabled = False
						Exit Select
				Case "OfficeXP"
						Me.comboDropDown1.Style = VisualStyle.OfficeXP
						Me.comboDropDown2.Style = VisualStyle.OfficeXP
						Me.comboBoxAdv2.Enabled = False
						Exit Select
				Case "Office2003"
						Me.comboDropDown1.Style = VisualStyle.Office2003
						Me.comboDropDown2.Style = VisualStyle.Office2003
						Me.comboBoxAdv2.Enabled = False
						Exit Select
				Case "VS2005"
						Me.comboDropDown1.Style = VisualStyle.VS2005
						Me.comboDropDown2.Style = VisualStyle.VS2005
						Me.comboBoxAdv2.Enabled = False
						Exit Select
				Case "Office2007"
						Me.comboDropDown1.Style = VisualStyle.Office2007
						Me.comboDropDown2.Style = VisualStyle.Office2007
						Me.comboBoxAdv2.Enabled = True

						Exit Select

			End Select
		End Sub
#End Region

		#Region "Color Schemes"

		Private Sub comboBoxAdv2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxAdv2.SelectedIndexChanged
			Select Case Me.comboBoxAdv2.SelectedItem.ToString()
				Case "Blue"
						Me.comboDropDown1.Office2007ColorTheme = Office2007Theme.Blue
						Me.comboDropDown2.Office2007ColorTheme = Office2007Theme.Blue
						  Exit Select
				Case "Silver"
						Me.comboDropDown1.Office2007ColorTheme = Office2007Theme.Silver
						Me.comboDropDown2.Office2007ColorTheme = Office2007Theme.Silver
						Exit Select
				Case "Black"
						Me.comboDropDown1.Office2007ColorTheme = Office2007Theme.Black
						Me.comboDropDown2.Office2007ColorTheme = Office2007Theme.Black
						Exit Select
			End Select

		End Sub
		#End Region
	End Class

	#Region "ArrayList"
	Public Class USState
		Private myShortName As String
		Private myLongName As String
		Private imgIndex As Integer

'INSTANT VB NOTE: The parameter imageIndex was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
		Public Sub New(ByVal strLongName As String, ByVal strShortName As String, ByVal imageIndex_Renamed As Integer)
			Me.myShortName = strShortName
			Me.myLongName = strLongName
			Me.imgIndex = imageIndex_Renamed
		End Sub

		Public ReadOnly Property ShortName() As String
			Get
				Return myShortName
			End Get
		End Property

		Public ReadOnly Property LongName() As String

			Get
				Return myLongName
			End Get
		End Property

		Public Property ImageIndex() As Integer
			Get
				Return imgIndex
			End Get
			Set
				imgIndex = Value
			End Set
		End Property


		Public Overrides Function ToString() As String
			Return Me.ShortName & " - " & Me.LongName
		End Function
	End Class
	#End Region
End Namespace
