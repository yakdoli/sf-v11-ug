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
	Imports System.Drawing.Drawing2D
	Imports System.Collections
	Imports System.ComponentModel
	Imports System.Windows.Forms
	Imports System.Data
	Imports Syncfusion.Windows.Forms.Tools
	Imports Syncfusion.Windows.Forms
Namespace XPTaskBarSample

	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Office2007Form
		#Region "Declarations"

		Private WithEvents taskMenuBox1 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private xpTaskBar1 As Syncfusion.Windows.Forms.Tools.XPTaskBar
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private lbllabel6 As System.Windows.Forms.Label
		Private propertyGrid1 As System.Windows.Forms.PropertyGrid
		Private WithEvents taskMenuBox2 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private listView1 As System.Windows.Forms.ListView
		Private columnHeader1 As System.Windows.Forms.ColumnHeader
		Private columnHeader2 As System.Windows.Forms.ColumnHeader
		Private panel2 As System.Windows.Forms.Panel
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
		Private splitter1 As System.Windows.Forms.Splitter
		Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
		Private label4 As System.Windows.Forms.Label
		Private richTextBox1 As System.Windows.Forms.RichTextBox
		Private WithEvents checkBox4 As System.Windows.Forms.CheckBox
		Private WithEvents checkBox5 As System.Windows.Forms.CheckBox
		Private label8 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private WithEvents checkBox7 As System.Windows.Forms.CheckBox
		Private WithEvents checkBox8 As System.Windows.Forms.CheckBox
		Private components As System.ComponentModel.IContainer
		Private gradientPanel3 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private label10 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private tabPageAdv1 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabPageAdv2 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabPageAdv3 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabPageAdv4 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
		Private WithEvents buttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
		Private textBoxExt1 As Syncfusion.Windows.Forms.Tools.TextBoxExt
		Private comboBoxAdv2 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private WithEvents propertyComboBoxAdv As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private WithEvents headerDirectionComboBoxAdv As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private WithEvents headerTextAlignmentComboBox As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private WithEvents addNewXPTaskBarBoxButtonAdv As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents numericUpDown2 As Syncfusion.Windows.Forms.Tools.NumericUpDownExt
		Private WithEvents numericUpDown4 As Syncfusion.Windows.Forms.Tools.NumericUpDownExt
		Private WithEvents numericUpDown3 As Syncfusion.Windows.Forms.Tools.NumericUpDownExt
		Private WithEvents numericUpDown1 As Syncfusion.Windows.Forms.Tools.NumericUpDownExt
		Private searchButtonAdv As Syncfusion.Windows.Forms.ButtonAdv
		Private gradientPanel4 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private gradientPanel5 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private imageList1 As System.Windows.Forms.ImageList
		Private imageList2 As System.Windows.Forms.ImageList
		Private label11 As Label
		Private label3 As Label
		Private xpTaskBarBoxNew As XPTaskBarBox

		Private color1 As Color = Office2007Colors.Default.GroupBarItemColorLight
		Private color2 As Color = Office2007Colors.Default.GroupBarItemColorDark

		' On Mouse Hover
		Private color3 As Color = Office2007Colors.Default.GroupBarHighlightColorLight
		Private color4 As Color = Office2007Colors.Default.GroupBarHighlightColorDark

        Private color5 As Color = Office2007Colors.Default.GroupBarSelectedColorLight
        Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
        Private WithEvents label6 As System.Windows.Forms.Label
        Private WithEvents colorSchemeCombo As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Private WithEvents ButtonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
        Friend WithEvents FlowLayout1 As Syncfusion.Windows.Forms.Tools.FlowLayout
        Private color6 As Color = Office2007Colors.Default.GroupBarSelectedColorDark

#End Region

        Public Sub New()
            InitializeComponent()

            ' To collapse a box
            Me.taskMenuBox1.ExpandContent(True)
            Me.taskMenuBox2.ExpandContent(True)


        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.taskMenuBox1 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
            Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.taskMenuBox2 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
            Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
            Me.label1 = New System.Windows.Forms.Label()
            Me.textBoxExt1 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
            Me.label2 = New System.Windows.Forms.Label()
            Me.comboBoxAdv2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
            Me.searchButtonAdv = New Syncfusion.Windows.Forms.ButtonAdv()
            Me.xpTaskBar1 = New Syncfusion.Windows.Forms.Tools.XPTaskBar()
            Me.lbllabel6 = New System.Windows.Forms.Label()
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
            Me.tabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
            Me.tabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
            Me.gradientPanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
            Me.label11 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.gradientPanel5 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
            Me.label6 = New System.Windows.Forms.Label()
            Me.colorSchemeCombo = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
            Me.CheckBox6 = New System.Windows.Forms.CheckBox()
            Me.numericUpDown3 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt()
            Me.checkBox2 = New System.Windows.Forms.CheckBox()
            Me.checkBox3 = New System.Windows.Forms.CheckBox()
            Me.label10 = New System.Windows.Forms.Label()
            Me.numericUpDown1 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt()
            Me.label4 = New System.Windows.Forms.Label()
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.gradientPanel4 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
            Me.ButtonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv()
            Me.label8 = New System.Windows.Forms.Label()
            Me.label9 = New System.Windows.Forms.Label()
            Me.checkBox5 = New System.Windows.Forms.CheckBox()
            Me.numericUpDown2 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt()
            Me.numericUpDown4 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt()
            Me.label5 = New System.Windows.Forms.Label()
            Me.checkBox4 = New System.Windows.Forms.CheckBox()
            Me.checkBox8 = New System.Windows.Forms.CheckBox()
            Me.checkBox7 = New System.Windows.Forms.CheckBox()
            Me.headerDirectionComboBoxAdv = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
            Me.headerTextAlignmentComboBox = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
            Me.label7 = New System.Windows.Forms.Label()
            Me.addNewXPTaskBarBoxButtonAdv = New Syncfusion.Windows.Forms.ButtonAdv()
            Me.tabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
            Me.propertyComboBoxAdv = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
            Me.tabPageAdv3 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
            Me.listView1 = New System.Windows.Forms.ListView()
            Me.columnHeader1 = (CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader))
            Me.columnHeader2 = (CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader))
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv()
            Me.tabPageAdv4 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
            Me.splitter1 = New System.Windows.Forms.Splitter()
            Me.FlowLayout1 = New Syncfusion.Windows.Forms.Tools.FlowLayout(Me.components)
            Me.taskMenuBox2.SuspendLayout()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel2.SuspendLayout()
            CType(Me.textBoxExt1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xpTaskBar1.SuspendLayout()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControlAdv1.SuspendLayout()
            Me.tabPageAdv1.SuspendLayout()
            CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel3.SuspendLayout()
            CType(Me.gradientPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel5.SuspendLayout()
            CType(Me.colorSchemeCombo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel4.SuspendLayout()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.headerDirectionComboBoxAdv, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.headerTextAlignmentComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPageAdv2.SuspendLayout()
            CType(Me.propertyComboBoxAdv, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPageAdv3.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.tabPageAdv4.SuspendLayout()
            CType(Me.FlowLayout1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'taskMenuBox1
            '
            Me.taskMenuBox1.AllowDrop = True
            Me.taskMenuBox1.BackColor = System.Drawing.Color.Transparent
            Me.taskMenuBox1.DrawFocusRect = False
            Me.taskMenuBox1.Font = New System.Drawing.Font("Arial", 8.25F)
            Me.taskMenuBox1.HeaderBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(192))))))
            Me.taskMenuBox1.HeaderFont = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.taskMenuBox1.HeaderForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(68))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(143))))))
            Me.taskMenuBox1.HeaderImageIndex = 0
            Me.taskMenuBox1.HeaderImageList = Me.imageList2
            Me.taskMenuBox1.HitTaskBoxArea = False
            Me.taskMenuBox1.HotTrackColor = System.Drawing.Color.Empty
            Me.taskMenuBox1.ImageList = Me.imageList1
            Me.taskMenuBox1.ItemBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(225))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(247))))))
            Me.taskMenuBox1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() {New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Text, Image, Click Events and DragDrop items", System.Drawing.SystemColors.WindowText, 7, "1", "ItemClick,  DragDropItems", True, True, "Item1", New System.Drawing.Font("Arial", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Drawing Header and Item area with a custom brush.", System.Drawing.Color.Empty, 2, "2", "Header Image, Gradient Header Brush", True, True, "Item2", New System.Drawing.Font("Arial", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Disabled TaskbarItem", System.Drawing.Color.Empty, 6, "3", "Tooltip can also be provided for Disabled Items", True, False, "Item3", New System.Drawing.Font("Arial", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Header Text and Direction", System.Drawing.Color.Empty, 8, "4", "HeaderDirection and HeaderTextAlign", True, True, "Item4", New System.Drawing.Font("Arial", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("About Syncfusion", System.Drawing.Color.Empty, 4, "5", "Syncfusion", True, True, "Item5", New System.Drawing.Font("Arial", 8.25F), 0)})
            Me.taskMenuBox1.Location = New System.Drawing.Point(10, 10)
            Me.taskMenuBox1.Name = "taskMenuBox1"
            Me.taskMenuBox1.ShowToolTip = True
            Me.taskMenuBox1.Size = New System.Drawing.Size(188, 158)
            Me.taskMenuBox1.TabIndex = 0
            Me.taskMenuBox1.Text = "Features"
            '
            'imageList2
            '
            Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList2.Images.SetKeyName(0, "007.ico")
            Me.imageList2.Images.SetKeyName(1, "012.ico")
            Me.imageList2.Images.SetKeyName(2, "016.ico")
            '
            'imageList1
            '
            Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
            Me.imageList1.Images.SetKeyName(2, "bo813e1.gif")
            Me.imageList1.Images.SetKeyName(3, "flagred.gif")
            Me.imageList1.Images.SetKeyName(4, "barcha1.gif")
            Me.imageList1.Images.SetKeyName(5, "help2.gif")
            Me.imageList1.Images.SetKeyName(6, "option1.gif")
            Me.imageList1.Images.SetKeyName(7, "treevi1.gif")
            Me.imageList1.Images.SetKeyName(8, "artist.png")
            '
            'taskMenuBox2
            '
            Me.taskMenuBox2.BackColor = System.Drawing.Color.Transparent
            Me.taskMenuBox2.Controls.Add(Me.gradientPanel2)
            Me.taskMenuBox2.DrawFocusRect = False
            Me.taskMenuBox2.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.taskMenuBox2.ForeColor = System.Drawing.Color.Black
            Me.taskMenuBox2.HeaderBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(192))))))
            Me.taskMenuBox2.HeaderFont = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.taskMenuBox2.HeaderForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(68))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(143))))))
            Me.taskMenuBox2.HeaderImageIndex = 1
            Me.taskMenuBox2.HeaderImageList = Me.imageList2
            Me.taskMenuBox2.HitTaskBoxArea = False
            Me.taskMenuBox2.HotTrackColor = System.Drawing.Color.Empty
            Me.taskMenuBox2.ImageList = Me.imageList1
            Me.taskMenuBox2.ItemBackColor = System.Drawing.Color.Transparent
            Me.taskMenuBox2.Location = New System.Drawing.Point(10, 173)
            Me.taskMenuBox2.Name = "taskMenuBox2"
            Me.taskMenuBox2.PreferredChildPanelHeight = 125
            Me.taskMenuBox2.Size = New System.Drawing.Size(188, 155)
            Me.taskMenuBox2.TabIndex = 1
            Me.taskMenuBox2.Text = "Advanced Search"
            '
            'gradientPanel2
            '
            Me.gradientPanel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(199))))), (CInt(Fix((CByte(216))))), (CInt(Fix((CByte(237)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(199))))), (CInt(Fix((CByte(216))))), (CInt(Fix((CByte(237)))))))
            Me.gradientPanel2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(68))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(143))))))
            Me.gradientPanel2.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None
            Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.gradientPanel2.Controls.Add(Me.label1)
            Me.gradientPanel2.Controls.Add(Me.textBoxExt1)
            Me.gradientPanel2.Controls.Add(Me.label2)
            Me.gradientPanel2.Controls.Add(Me.comboBoxAdv2)
            Me.gradientPanel2.Controls.Add(Me.searchButtonAdv)
            Me.gradientPanel2.Location = New System.Drawing.Point(2, 28)
            Me.gradientPanel2.Name = "gradientPanel2"
            Me.gradientPanel2.Size = New System.Drawing.Size(184, 125)
            Me.gradientPanel2.TabIndex = 0
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.Color.Transparent
            Me.label1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.label1.Location = New System.Drawing.Point(20, 13)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(61, 14)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Keywords:"
            ' 
            ' textBoxExt1
            ' 
            Me.textBoxExt1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.textBoxExt1.Location = New System.Drawing.Point(86, 10)
            Me.textBoxExt1.Name = "textBoxExt1"
            Me.textBoxExt1.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt1.Size = New System.Drawing.Size(78, 20)
            Me.textBoxExt1.TabIndex = 5
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.BackColor = System.Drawing.Color.Transparent
            Me.label2.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.label2.Location = New System.Drawing.Point(20, 36)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(60, 14)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Category  :"
            ' 
            ' comboBoxAdv2
            ' 
            Me.comboBoxAdv2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(251))))))
            Me.comboBoxAdv2.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.comboBoxAdv2.Location = New System.Drawing.Point(85, 32)
            Me.comboBoxAdv2.Name = "comboBoxAdv2"
            Me.comboBoxAdv2.Size = New System.Drawing.Size(78, 22)
            Me.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.comboBoxAdv2.TabIndex = 6
            ' 
            ' searchButtonAdv
            ' 
            Me.searchButtonAdv.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.searchButtonAdv.Font = New System.Drawing.Font("Arial", 8.25F)
            Me.searchButtonAdv.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(21))))), (CInt(Fix((CByte(66))))), (CInt(Fix((CByte(139))))))
            Me.searchButtonAdv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.searchButtonAdv.Location = New System.Drawing.Point(52, 56)
            Me.searchButtonAdv.Name = "searchButtonAdv"
            Me.searchButtonAdv.Size = New System.Drawing.Size(80, 23)
            Me.searchButtonAdv.TabIndex = 7
            Me.searchButtonAdv.Text = "Search"
            Me.searchButtonAdv.UseVisualStyle = True
            ' 
            ' xpTaskBar1
            ' 
            Me.xpTaskBar1.AutoScroll = True
            Me.xpTaskBar1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(248))))))
            Me.xpTaskBar1.BorderColor = System.Drawing.Color.Black
            Me.xpTaskBar1.ColWidthOnHorizontalAlignment = 120
            Me.xpTaskBar1.Controls.Add(Me.taskMenuBox1)
            Me.xpTaskBar1.Controls.Add(Me.taskMenuBox2)
            Me.xpTaskBar1.Dock = System.Windows.Forms.DockStyle.Left
            Me.xpTaskBar1.Font = New System.Drawing.Font("Arial", 8.25F)
            Me.xpTaskBar1.HorizontalPadding = 5
            Me.xpTaskBar1.Location = New System.Drawing.Point(0, 0)
            Me.xpTaskBar1.MinimumSize = New System.Drawing.Size(0, 0)
            Me.xpTaskBar1.Name = "xpTaskBar1"
            Me.xpTaskBar1.Padding = New System.Windows.Forms.Padding(10, 10, 10, 0)
            Me.xpTaskBar1.Size = New System.Drawing.Size(208, 376)
            Me.xpTaskBar1.TabIndex = 1
            Me.xpTaskBar1.VerticalPadding = 5
            '
            'lbllabel6
            '
            Me.lbllabel6.Dock = System.Windows.Forms.DockStyle.Top
            Me.lbllabel6.Font = New System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.lbllabel6.Location = New System.Drawing.Point(0, 0)
            Me.lbllabel6.Name = "lbllabel6"
            Me.lbllabel6.Size = New System.Drawing.Size(176, 24)
            Me.lbllabel6.TabIndex = 11
            Me.lbllabel6.Text = "       XPTaskBar properties"
            '
            'propertyGrid1
            '
            Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(107))))), (CInt(Fix((CByte(114))))), (CInt(Fix((CByte(158))))))
            Me.propertyGrid1.CommandsForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(128))))))
            Me.propertyGrid1.Cursor = System.Windows.Forms.Cursors.HSplit
            Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyGrid1.HelpVisible = False
            Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
            Me.propertyGrid1.Location = New System.Drawing.Point(0, 19)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Alphabetical
            Me.propertyGrid1.Size = New System.Drawing.Size(439, 331)
            Me.propertyGrid1.TabIndex = 10
            Me.propertyGrid1.ToolbarVisible = False
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(182))))), (CInt(Fix((CByte(211))))), (CInt(Fix((CByte(241)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(219))))), (CInt(Fix((CByte(229))))), (CInt(Fix((CByte(241)))))))
            Me.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.gradientPanel1.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None
            Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.gradientPanel1.Controls.Add(Me.tabControlAdv1)
            Me.gradientPanel1.Controls.Add(Me.splitter1)
            Me.gradientPanel1.Controls.Add(Me.xpTaskBar1)
            Me.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gradientPanel1.Location = New System.Drawing.Point(0, 0)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(651, 376)
            Me.gradientPanel1.TabIndex = 13
            '
            'tabControlAdv1
            '
            Me.tabControlAdv1.ActiveTabFont = New System.Drawing.Font("Arial", 8.25F)
            Me.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv1)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv2)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv3)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv4)
            Me.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(141))))), (CInt(Fix((CByte(178))))), (CInt(Fix((CByte(227))))))
            Me.tabControlAdv1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.tabControlAdv1.ImageList = Me.imageList1
            Me.tabControlAdv1.Location = New System.Drawing.Point(210, 0)
            Me.tabControlAdv1.Name = "tabControlAdv1"
            Me.tabControlAdv1.Size = New System.Drawing.Size(441, 376)
            Me.tabControlAdv1.TabGap = 10
            Me.tabControlAdv1.TabIndex = 8
            Me.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(199))))), (CInt(Fix((CByte(216))))), (CInt(Fix((CByte(237))))))
            Me.tabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)
            Me.tabControlAdv1.VSLikeScrollButton = True
            '
            'tabPageAdv1
            '
            Me.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(237))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(253))))))
            Me.tabPageAdv1.Controls.Add(Me.gradientPanel3)
            Me.tabPageAdv1.Font = New System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.tabPageAdv1.Image = Nothing
            Me.tabPageAdv1.ImageIndex = 3
            Me.tabPageAdv1.ImageSize = New System.Drawing.Size(16, 16)
            Me.tabPageAdv1.Location = New System.Drawing.Point(1, 25)
            Me.tabPageAdv1.Name = "tabPageAdv1"
            Me.tabPageAdv1.ShowCloseButton = True
            Me.tabPageAdv1.Size = New System.Drawing.Size(439, 350)
            Me.tabPageAdv1.TabFont = New System.Drawing.Font("Arial", 8.25F)
            Me.tabPageAdv1.TabIndex = 1
            Me.tabPageAdv1.Text = "XPTaskBar Features"
            Me.tabPageAdv1.ThemesEnabled = False
            '
            'gradientPanel3
            '
            Me.gradientPanel3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(248))))))
            Me.gradientPanel3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(248)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(248)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(248))))))})
            Me.gradientPanel3.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(248))))))
            Me.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel3.Controls.Add(Me.label11)
            Me.gradientPanel3.Controls.Add(Me.label3)
            Me.gradientPanel3.Controls.Add(Me.gradientPanel5)
            Me.gradientPanel3.Controls.Add(Me.gradientPanel4)
            Me.gradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gradientPanel3.Location = New System.Drawing.Point(0, 0)
            Me.gradientPanel3.Name = "gradientPanel3"
            Me.gradientPanel3.Size = New System.Drawing.Size(439, 350)
            Me.gradientPanel3.TabIndex = 7
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.label11.Location = New System.Drawing.Point(20, 149)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(147, 14)
            Me.label11.TabIndex = 36
            Me.label11.Text = "XPTaskBarBox Properties"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.label3.Location = New System.Drawing.Point(24, 9)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(127, 14)
            Me.label3.TabIndex = 34
            Me.label3.Text = "XPTaskBar Properties"
            '
            'gradientPanel5
            '
            Me.gradientPanel5.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(222))))), (CInt(Fix((CByte(231))))), (CInt(Fix((CByte(246)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(222))))), (CInt(Fix((CByte(231))))), (CInt(Fix((CByte(246)))))))
            Me.gradientPanel5.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(219))))), (CInt(Fix((CByte(254))))))
            Me.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel5.Controls.Add(Me.label6)
            Me.gradientPanel5.Controls.Add(Me.colorSchemeCombo)
            Me.gradientPanel5.Controls.Add(Me.CheckBox6)
            Me.gradientPanel5.Controls.Add(Me.numericUpDown3)
            Me.gradientPanel5.Controls.Add(Me.checkBox2)
            Me.gradientPanel5.Controls.Add(Me.checkBox3)
            Me.gradientPanel5.Controls.Add(Me.label10)
            Me.gradientPanel5.Controls.Add(Me.numericUpDown1)
            Me.gradientPanel5.Controls.Add(Me.label4)
            Me.gradientPanel5.Controls.Add(Me.checkBox1)
            Me.gradientPanel5.Location = New System.Drawing.Point(23, 26)
            Me.gradientPanel5.Name = "gradientPanel5"
            Me.gradientPanel5.Size = New System.Drawing.Size(424, 111)
            Me.gradientPanel5.TabIndex = 33
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.label6.Location = New System.Drawing.Point(227, 85)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(69, 13)
            Me.label6.TabIndex = 27
            Me.label6.Text = "ColorScheme"
            '
            'colorSchemeCombo
            '
            Me.colorSchemeCombo.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(251))))))
            Me.colorSchemeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.colorSchemeCombo.Enabled = False
            Me.colorSchemeCombo.Items.AddRange(New Object() {"Blue", "Silver", "Black", "Managed"})
            Me.colorSchemeCombo.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.colorSchemeCombo, "Blue"))
            Me.colorSchemeCombo.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.colorSchemeCombo, "Silver"))
            Me.colorSchemeCombo.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.colorSchemeCombo, "Black"))
            Me.colorSchemeCombo.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.colorSchemeCombo, "Managed"))
            Me.colorSchemeCombo.Location = New System.Drawing.Point(307, 83)
            Me.colorSchemeCombo.Name = "colorSchemeCombo"
            Me.colorSchemeCombo.Size = New System.Drawing.Size(95, 23)
            Me.colorSchemeCombo.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.colorSchemeCombo.TabIndex = 26
            Me.colorSchemeCombo.Text = "Blue"
            '			Me.colorSchemeCombo.SelectedIndexChanged += New System.EventHandler(Me.colorSchemeCombo_SelectedIndexChanged)
            ' 
            ' checkBox6
            ' 
            Me.CheckBox6.AutoSize = True
            Me.CheckBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.CheckBox6.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.CheckBox6.Location = New System.Drawing.Point(24, 83)
            Me.CheckBox6.Name = "checkBox6"
            Me.CheckBox6.Size = New System.Drawing.Size(106, 17)
            Me.CheckBox6.TabIndex = 25
            Me.CheckBox6.Text = "Office2007 Style"
            Me.CheckBox6.UseVisualStyleBackColor = True
            '			Me.checkBox6.CheckedChanged += New System.EventHandler(Me.checkBox6_CheckedChanged)
            ' 
            ' numericUpDown3
            ' 
            Me.numericUpDown3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(251))))))
            Me.numericUpDown3.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.numericUpDown3.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(251))))))
            Me.numericUpDown3.BorderSides = System.Windows.Forms.Border3DSide.Left
            Me.numericUpDown3.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.numericUpDown3.Location = New System.Drawing.Point(359, 12)
            Me.numericUpDown3.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
            Me.numericUpDown3.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
            Me.numericUpDown3.Name = "numericUpDown3"
            Me.numericUpDown3.Size = New System.Drawing.Size(43, 23)
            Me.numericUpDown3.TabIndex = 23
            Me.numericUpDown3.ThemesEnabled = True
            Me.numericUpDown3.Value = New Decimal(New Integer() {150, 0, 0, 0})
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.BackColor = System.Drawing.Color.Transparent
            Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.checkBox2.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.checkBox2.Location = New System.Drawing.Point(24, 11)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(94, 17)
            Me.checkBox2.TabIndex = 2
            Me.checkBox2.Text = "Vertical Layout"
            Me.checkBox2.UseVisualStyleBackColor = False
            '
            'checkBox3
            '
            Me.checkBox3.AutoSize = True
            Me.checkBox3.BackColor = System.Drawing.Color.Transparent
            Me.checkBox3.Checked = True
            Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.checkBox3.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.checkBox3.Location = New System.Drawing.Point(24, 58)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(71, 17)
            Me.checkBox3.TabIndex = 4
            Me.checkBox3.Text = "AutoScroll"
            Me.checkBox3.UseVisualStyleBackColor = False
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.BackColor = System.Drawing.Color.Transparent
            Me.label10.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.label10.Location = New System.Drawing.Point(227, 54)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(71, 13)
            Me.label10.TabIndex = 7
            Me.label10.Text = "Dock Padding"
            '
            'numericUpDown1
            '
            Me.numericUpDown1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(251))))))
            Me.numericUpDown1.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
            Me.numericUpDown1.BorderColor = System.Drawing.Color.Transparent
            Me.numericUpDown1.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.numericUpDown1.Location = New System.Drawing.Point(359, 52)
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.Size = New System.Drawing.Size(44, 23)
            Me.numericUpDown1.TabIndex = 24
            Me.numericUpDown1.ThemesEnabled = True
            Me.numericUpDown1.Value = New Decimal(New Integer() {5, 0, 0, 0})
            '
            'label4
            '
            Me.label4.BackColor = System.Drawing.Color.Transparent
            Me.label4.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.label4.Location = New System.Drawing.Point(226, 12)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(108, 28)
            Me.label4.TabIndex = 6
            Me.label4.Text = "Column Width on Horizontal Alignment"
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.BackColor = System.Drawing.Color.Transparent
            Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.checkBox1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.checkBox1.Location = New System.Drawing.Point(24, 35)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(101, 17)
            Me.checkBox1.TabIndex = 0
            Me.checkBox1.Text = "Themes Enabled"
            Me.checkBox1.UseVisualStyleBackColor = False
            '
            'gradientPanel4
            '
            Me.gradientPanel4.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(222))))), (CInt(Fix((CByte(231))))), (CInt(Fix((CByte(246)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(222))))), (CInt(Fix((CByte(231))))), (CInt(Fix((CByte(246)))))))
            Me.gradientPanel4.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(219))))), (CInt(Fix((CByte(254))))))
            Me.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel4.Controls.Add(Me.ButtonAdv2)
            Me.gradientPanel4.Controls.Add(Me.label8)
            Me.gradientPanel4.Controls.Add(Me.label9)
            Me.gradientPanel4.Controls.Add(Me.checkBox5)
            Me.gradientPanel4.Controls.Add(Me.numericUpDown2)
            Me.gradientPanel4.Controls.Add(Me.numericUpDown4)
            Me.gradientPanel4.Controls.Add(Me.label5)
            Me.gradientPanel4.Controls.Add(Me.checkBox4)
            Me.gradientPanel4.Controls.Add(Me.checkBox8)
            Me.gradientPanel4.Controls.Add(Me.checkBox7)
            Me.gradientPanel4.Controls.Add(Me.headerDirectionComboBoxAdv)
            Me.gradientPanel4.Controls.Add(Me.headerTextAlignmentComboBox)
            Me.gradientPanel4.Controls.Add(Me.label7)
            Me.gradientPanel4.Controls.Add(Me.addNewXPTaskBarBoxButtonAdv)
            Me.gradientPanel4.Location = New System.Drawing.Point(23, 166)
            Me.gradientPanel4.Name = "gradientPanel4"
            Me.gradientPanel4.Size = New System.Drawing.Size(424, 176)
            Me.gradientPanel4.TabIndex = 32
            ' 
            ' buttonAdv2
            ' 
            Me.ButtonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.ButtonAdv2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(248))))))
            Me.ButtonAdv2.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.ButtonAdv2.ForeColor = System.Drawing.Color.Black
            Me.ButtonAdv2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.ButtonAdv2.Location = New System.Drawing.Point(58, 140)
            Me.ButtonAdv2.Name = "buttonAdv2"
            Me.ButtonAdv2.Size = New System.Drawing.Size(66, 23)
            Me.ButtonAdv2.TabIndex = 24
            Me.ButtonAdv2.Text = "Sort Items"
            Me.ButtonAdv2.UseVisualStyle = True
            ' 
            ' label8
            ' 
            Me.label8.AutoSize = True
            Me.label8.BackColor = System.Drawing.Color.Transparent
            Me.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.label8.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.label8.Location = New System.Drawing.Point(196, 9)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(87, 13)
            Me.label8.TabIndex = 7
            Me.label8.Text = "Header Direction"
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.BackColor = System.Drawing.Color.Transparent
            Me.label9.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.label9.Location = New System.Drawing.Point(172, 39)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(117, 13)
            Me.label9.TabIndex = 8
            Me.label9.Text = "Header Text Alignment"
            '
            'checkBox5
            '
            Me.checkBox5.AutoSize = True
            Me.checkBox5.BackColor = System.Drawing.Color.Transparent
            Me.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.checkBox5.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.checkBox5.Location = New System.Drawing.Point(23, 33)
            Me.checkBox5.Name = "checkBox5"
            Me.checkBox5.Size = New System.Drawing.Size(95, 17)
            Me.checkBox5.TabIndex = 5
            Me.checkBox5.Text = "Collapse Boxes"
            Me.checkBox5.UseVisualStyleBackColor = False
            '
            'numericUpDown2
            '
            Me.numericUpDown2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(251))))))
            Me.numericUpDown2.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
            Me.numericUpDown2.BorderColor = System.Drawing.Color.Transparent
            Me.numericUpDown2.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.numericUpDown2.Location = New System.Drawing.Point(308, 64)
            Me.numericUpDown2.Name = "numericUpDown2"
            Me.numericUpDown2.Size = New System.Drawing.Size(96, 23)
            Me.numericUpDown2.TabIndex = 21
            Me.numericUpDown2.ThemesEnabled = True
            Me.numericUpDown2.Value = New Decimal(New Integer() {5, 0, 0, 0})
            '
            'numericUpDown4
            '
            Me.numericUpDown4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(251))))))
            Me.numericUpDown4.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
            Me.numericUpDown4.BorderColor = System.Drawing.Color.Transparent
            Me.numericUpDown4.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.numericUpDown4.Location = New System.Drawing.Point(308, 95)
            Me.numericUpDown4.Name = "numericUpDown4"
            Me.numericUpDown4.Size = New System.Drawing.Size(96, 23)
            Me.numericUpDown4.TabIndex = 22
            Me.numericUpDown4.ThemesEnabled = True
            Me.numericUpDown4.Value = New Decimal(New Integer() {5, 0, 0, 0})
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.BackColor = System.Drawing.Color.Transparent
            Me.label5.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.label5.Location = New System.Drawing.Point(251, 70)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(31, 13)
            Me.label5.TabIndex = 14
            Me.label5.Text = "PadX"
            '
            'checkBox4
            '
            Me.checkBox4.AutoSize = True
            Me.checkBox4.BackColor = System.Drawing.Color.Transparent
            Me.checkBox4.Checked = True
            Me.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.checkBox4.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.checkBox4.Location = New System.Drawing.Point(24, 8)
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(100, 17)
            Me.checkBox4.TabIndex = 4
            Me.checkBox4.Text = "Allow Drag Drop"
            Me.checkBox4.UseVisualStyleBackColor = False
            '
            'checkBox8
            '
            Me.checkBox8.AutoSize = True
            Me.checkBox8.BackColor = System.Drawing.Color.Transparent
            Me.checkBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.checkBox8.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.checkBox8.Location = New System.Drawing.Point(23, 87)
            Me.checkBox8.Name = "checkBox8"
            Me.checkBox8.Size = New System.Drawing.Size(105, 17)
            Me.checkBox8.TabIndex = 12
            Me.checkBox8.Text = "Toggle by Button"
            Me.checkBox8.UseVisualStyleBackColor = False
            '
            'checkBox7
            '
            Me.checkBox7.AutoSize = True
            Me.checkBox7.BackColor = System.Drawing.Color.Transparent
            Me.checkBox7.Checked = True
            Me.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.checkBox7.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.checkBox7.Location = New System.Drawing.Point(23, 59)
            Me.checkBox7.Name = "checkBox7"
            Me.checkBox7.Size = New System.Drawing.Size(127, 17)
            Me.checkBox7.TabIndex = 11
            Me.checkBox7.Text = "Show Collapse Button"
            Me.checkBox7.UseVisualStyleBackColor = False
            '
            'headerDirectionComboBoxAdv
            '
            Me.headerDirectionComboBoxAdv.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(251))))))
            Me.headerDirectionComboBoxAdv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.headerDirectionComboBoxAdv.Items.AddRange(New Object() {"LeftToRight", "RightToLeft"})
            Me.headerDirectionComboBoxAdv.Location = New System.Drawing.Point(307, 4)
            Me.headerDirectionComboBoxAdv.Name = "headerDirectionComboBoxAdv"
            Me.headerDirectionComboBoxAdv.Size = New System.Drawing.Size(96, 23)
            Me.headerDirectionComboBoxAdv.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.headerDirectionComboBoxAdv.TabIndex = 19
            Me.headerDirectionComboBoxAdv.Text = "LeftToRight"
            '
            'headerTextAlignmentComboBox
            '
            Me.headerTextAlignmentComboBox.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(251))))))
            Me.headerTextAlignmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.headerTextAlignmentComboBox.Items.AddRange(New Object() {"Near", "Center", "Far"})
            Me.headerTextAlignmentComboBox.Location = New System.Drawing.Point(307, 34)
            Me.headerTextAlignmentComboBox.Name = "headerTextAlignmentComboBox"
            Me.headerTextAlignmentComboBox.Size = New System.Drawing.Size(96, 23)
            Me.headerTextAlignmentComboBox.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.headerTextAlignmentComboBox.TabIndex = 20
            Me.headerTextAlignmentComboBox.Text = "Near"
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.BackColor = System.Drawing.Color.Transparent
            Me.label7.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.label7.Location = New System.Drawing.Point(252, 96)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(31, 13)
            Me.label7.TabIndex = 16
            Me.label7.Text = "PadY"
            '
            'addNewXPTaskBarBoxButtonAdv
            '
            Me.addNewXPTaskBarBoxButtonAdv.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.addNewXPTaskBarBoxButtonAdv.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(248))))))
            Me.addNewXPTaskBarBoxButtonAdv.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.addNewXPTaskBarBoxButtonAdv.ForeColor = System.Drawing.Color.Black
            Me.addNewXPTaskBarBoxButtonAdv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.addNewXPTaskBarBoxButtonAdv.Location = New System.Drawing.Point(164, 140)
            Me.addNewXPTaskBarBoxButtonAdv.Name = "addNewXPTaskBarBoxButtonAdv"
            Me.addNewXPTaskBarBoxButtonAdv.Size = New System.Drawing.Size(192, 23)
            Me.addNewXPTaskBarBoxButtonAdv.TabIndex = 23
            Me.addNewXPTaskBarBoxButtonAdv.Text = "Add New XPTaskBar Box"
            Me.addNewXPTaskBarBoxButtonAdv.UseVisualStyle = True
            '
            'tabPageAdv2
            '
            Me.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(237))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(253))))))
            Me.tabPageAdv2.Controls.Add(Me.propertyGrid1)
            Me.tabPageAdv2.Controls.Add(Me.propertyComboBoxAdv)
            Me.tabPageAdv2.Font = New System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.tabPageAdv2.Image = Nothing
            Me.tabPageAdv2.ImageIndex = 0
            Me.tabPageAdv2.ImageSize = New System.Drawing.Size(16, 16)
            Me.tabPageAdv2.Location = New System.Drawing.Point(1, 25)
            Me.tabPageAdv2.Name = "tabPageAdv2"
            Me.tabPageAdv2.ShowCloseButton = True
            Me.tabPageAdv2.Size = New System.Drawing.Size(439, 350)
            Me.tabPageAdv2.TabIndex = 2
            Me.tabPageAdv2.Text = "Property Grid"
            Me.tabPageAdv2.ThemesEnabled = False
            '
            'propertyComboBoxAdv
            '
            Me.propertyComboBoxAdv.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(251))))))
            Me.propertyComboBoxAdv.Dock = System.Windows.Forms.DockStyle.Top
            Me.propertyComboBoxAdv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.propertyComboBoxAdv.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.propertyComboBoxAdv.Items.AddRange(New Object() {"XPTaskBar", "XPTaskBarBox1", "XPTaskBarBox2"})
            Me.propertyComboBoxAdv.Location = New System.Drawing.Point(0, 0)
            Me.propertyComboBoxAdv.Name = "propertyComboBoxAdv"
            Me.propertyComboBoxAdv.Size = New System.Drawing.Size(439, 19)
            Me.propertyComboBoxAdv.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.propertyComboBoxAdv.TabIndex = 13
            Me.propertyComboBoxAdv.Text = "XPTaskBar"
            '
            'tabPageAdv3
            '
            Me.tabPageAdv3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(237))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(253))))))
            Me.tabPageAdv3.Controls.Add(Me.listView1)
            Me.tabPageAdv3.Controls.Add(Me.panel2)
            Me.tabPageAdv3.Font = New System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.tabPageAdv3.Image = Nothing
            Me.tabPageAdv3.ImageIndex = 1
            Me.tabPageAdv3.ImageSize = New System.Drawing.Size(16, 16)
            Me.tabPageAdv3.Location = New System.Drawing.Point(1, 25)
            Me.tabPageAdv3.Name = "tabPageAdv3"
            Me.tabPageAdv3.ShowCloseButton = True
            Me.tabPageAdv3.Size = New System.Drawing.Size(439, 350)
            Me.tabPageAdv3.TabIndex = 3
            Me.tabPageAdv3.Text = "Event Log"
            Me.tabPageAdv3.ThemesEnabled = False
            '
            'listView1
            '
            Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2})
            Me.listView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listView1.GridLines = True
            Me.listView1.Location = New System.Drawing.Point(0, 0)
            Me.listView1.Name = "listView1"
            Me.listView1.Size = New System.Drawing.Size(439, 326)
            Me.listView1.TabIndex = 0
            Me.listView1.UseCompatibleStateImageBehavior = False
            Me.listView1.View = System.Windows.Forms.View.Details
            '
            'columnHeader1
            '
            Me.columnHeader1.Text = "Events"
            Me.columnHeader1.Width = 168
            '
            'columnHeader2
            '
            Me.columnHeader2.Text = "Object"
            Me.columnHeader2.Width = 298
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(219))))), (CInt(Fix((CByte(255))))))
            Me.panel2.Controls.Add(Me.buttonAdv1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel2.Location = New System.Drawing.Point(0, 326)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(439, 24)
            Me.panel2.TabIndex = 1
            '
            'buttonAdv1
            '
            Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(248))))))
            Me.buttonAdv1.Dock = System.Windows.Forms.DockStyle.Right
            Me.buttonAdv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.buttonAdv1.Location = New System.Drawing.Point(319, 0)
            Me.buttonAdv1.Name = "buttonAdv1"
            Me.buttonAdv1.Size = New System.Drawing.Size(120, 24)
            Me.buttonAdv1.TabIndex = 0
            Me.buttonAdv1.Text = "Clear Log"
            Me.buttonAdv1.UseVisualStyle = False
            '
            'tabPageAdv4
            '
            Me.tabPageAdv4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(237))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(253))))))
            Me.tabPageAdv4.Controls.Add(Me.richTextBox1)
            Me.tabPageAdv4.Font = New System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.tabPageAdv4.Image = Nothing
            Me.tabPageAdv4.ImageIndex = 5
            Me.tabPageAdv4.ImageSize = New System.Drawing.Size(16, 16)
            Me.tabPageAdv4.Location = New System.Drawing.Point(1, 25)
            Me.tabPageAdv4.Name = "tabPageAdv4"
            Me.tabPageAdv4.ShowCloseButton = True
            Me.tabPageAdv4.Size = New System.Drawing.Size(439, 350)
            Me.tabPageAdv4.TabIndex = 4
            Me.tabPageAdv4.Text = "About"
            Me.tabPageAdv4.ThemesEnabled = False
            '
            'richTextBox1
            '
            Me.richTextBox1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(248))))))
            Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richTextBox1.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.richTextBox1.ForeColor = System.Drawing.Color.Black
            Me.richTextBox1.Location = New System.Drawing.Point(0, 0)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.ReadOnly = True
            Me.richTextBox1.Size = New System.Drawing.Size(439, 350)
            Me.richTextBox1.TabIndex = 0
            Me.richTextBox1.Text = resources.GetString("richTextBox1.Text")
            '
            'splitter1
            '
            Me.splitter1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(248))))))
            Me.splitter1.Location = New System.Drawing.Point(208, 0)
            Me.splitter1.MinExtra = 5
            Me.splitter1.MinSize = 5
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(2, 376)
            Me.splitter1.TabIndex = 7
            Me.splitter1.TabStop = False
            ' 
            ' flowLayout1
            ' 
            Me.FlowLayout1.BottomMargin = 10
            Me.FlowLayout1.ContainerControl = Me.gradientPanel2
            Me.FlowLayout1.TopMargin = 10
            Me.FlowLayout1.VGap = 2
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(651, 376)
            Me.Controls.Add(Me.gradientPanel1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "TaskBar "
            Me.taskMenuBox2.ResumeLayout(False)
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel2.ResumeLayout(False)
            Me.gradientPanel2.PerformLayout()
            CType(Me.textBoxExt1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xpTaskBar1.ResumeLayout(False)
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControlAdv1.ResumeLayout(False)
            Me.tabPageAdv1.ResumeLayout(False)
            CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel3.ResumeLayout(False)
            Me.gradientPanel3.PerformLayout()
            CType(Me.gradientPanel5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel5.ResumeLayout(False)
            Me.gradientPanel5.PerformLayout()
            CType(Me.colorSchemeCombo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel4.ResumeLayout(False)
            Me.gradientPanel4.PerformLayout()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.headerDirectionComboBoxAdv, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.headerTextAlignmentComboBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPageAdv2.ResumeLayout(False)
            CType(Me.propertyComboBoxAdv, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPageAdv3.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            Me.tabPageAdv4.ResumeLayout(False)
            CType(Me.FlowLayout1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Public Shared Sub Main()
            Application.Run(New Form1())
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.propertyGrid1.SelectedObject = Me.xpTaskBar1

            'foreach(Control c in this.Controls)
            '{
            '    c.ForeColor = Color.FromArgb(21,66,139);
            '}

            headerTextAlignmentComboBox.SelectedIndex = 0
            headerDirectionComboBoxAdv.SelectedIndex = 0
            Me.ColorScheme = Office2007Theme.Blue
        End Sub

#Region "RadioButtonCheck Changed Events"

        '		int r=189,g=215,b=252;
        '		int r1=220,g1=235,b1=254;
        '		private void OnRadioButtonCheckChanged(object sender,EventArgs e)
        '		{
        '			if(sender == blueRadioButtonAdv)
        '			{
        '				r=189;g=215;b=252;
        '				r1=220;g1=235;b1=254;
        '				this.xpTaskBar1.BackColor = Color.FromArgb(r,g,b);
        '				SetBackGroundTheme();
        '				this.xpTaskBar1.Refresh();
        '				SetBackGroundTheme(Office2007Theme.Blue);
        '			}
        '			else if(sender == blackRadioButtonAdv)
        '			{
        '				r = 109;g=109;b=109;
        '				r1=61;g1=61;b1=61;
        '				this.xpTaskBar1.BackColor = Color.FromArgb(r,g,b);
        '				SetBackGroundTheme();
        '				this.xpTaskBar1.Refresh();
        '				SetBackGroundTheme(Office2007Theme.Black);
        '			}
        '			else if(sender == silverRadioButtonAdv)
        '			{
        '				r=212;g=214;b=219;
        '				r1=178;g1=183;b1=190;
        '				this.xpTaskBar1.BackColor = Color.FromArgb(r,g,b);
        '				SetBackGroundTheme();
        '				this.xpTaskBar1.Refresh();
        '				SetBackGroundTheme(Office2007Theme.Silver);
        '			}
        '		}

        '		private void SetBackGroundTheme()
        '		{
        '			this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(r1)), ((System.Byte)(g1)), ((System.Byte)(b1))), System.Drawing.Color.FromArgb(((System.Byte)(r)), ((System.Byte)(g)), ((System.Byte)(b))));
        '			this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(r1)), ((System.Byte)(g1)), ((System.Byte)(b1))), System.Drawing.Color.FromArgb(((System.Byte)(r)), ((System.Byte)(g)), ((System.Byte)(b))));
        '			this.gradientPanel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(r1)), ((System.Byte)(g1)), ((System.Byte)(b1))), System.Drawing.Color.FromArgb(((System.Byte)(r)), ((System.Byte)(g)), ((System.Byte)(b))));
        '			this.richTextBox1.BackColor = Color.FromArgb(r1,g1,b1);
        '		}
        '
        '		private void SetBackGroundTheme(Syncfusion.Windows.Forms.Office2007Theme theme)
        '		{
        '			switch(theme)
        '			{
        '				case Office2007Theme.Blue:
        '					this.addNewXPTaskBarBoxButtonAdv.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
        '					this.searchButtonAdv.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
        '					this.addNewXPTaskBarBoxButtonAdv.ForeColor = Color.FromArgb(21,66,139);
        '					this.searchButtonAdv.ForeColor = Color.FromArgb(21,66,139);
        '					foreach(Control c in this.Controls)
        '					{
        '						c.ForeColor = Color.FromArgb(21,66,139);
        '					}
        '					this.richTextBox1.ForeColor = Color.FromArgb(21,66,139);
        '					break;
        '				case Office2007Theme.Black:
        '					this.addNewXPTaskBarBoxButtonAdv.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
        '					this.searchButtonAdv.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
        '					this.addNewXPTaskBarBoxButtonAdv.ForeColor = Color.White;
        '					this.searchButtonAdv.ForeColor = Color.White;
        '					foreach(Control c in this.Controls)
        '					{
        '						c.ForeColor = Color.White;
        '					}
        '					this.richTextBox1.ForeColor = Color.White;
        '					break;
        '				case Office2007Theme.Silver:
        '					this.addNewXPTaskBarBoxButtonAdv.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
        '					this.searchButtonAdv.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
        '					this.addNewXPTaskBarBoxButtonAdv.ForeColor = Color.Black;
        '					this.searchButtonAdv.ForeColor = Color.Black;
        '					foreach(Control c in this.Controls)
        '					{
        '						c.ForeColor = Color.Black;
        '					}
        '					this.richTextBox1.ForeColor = Color.Black;
        '					break;
        '			}
        '			this.Refresh();
        '		}

#End Region

#Region "XPTaskBarBackgroundbrush"
        Private Sub OnTaskMenuProvideHeaderBackgroundBrush(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.ProvideBrushEventArgs) Handles taskMenuBox1.ProvideHeaderBackgroundBrush, taskMenuBox2.ProvideHeaderBackgroundBrush
            Dim xBox As XPTaskBarBox = TryCast(sender, XPTaskBarBox)

            Dim blend As Blend = New Blend()
            blend.Positions = New Single() {0.0F, 0.4F, 0.4F + 0.001F, 1.0F}
            blend.Factors = New Single() {0.0F, 0.5F, 1.0F, 0.5F}

            Dim lgb As LinearGradientBrush
            If (Not xBox.HeaderHit) Then
                lgb = New LinearGradientBrush(args.Bounds, color1, color2, LinearGradientMode.Vertical)
            Else
                lgb = New LinearGradientBrush(args.Bounds, color3, color4, LinearGradientMode.Vertical)
            End If

            ' if the box is collapsed.
            If xBox.Collapsed Then
                lgb = New LinearGradientBrush(args.Bounds, color5, color6, LinearGradientMode.Vertical)
            End If

            lgb.Blend = blend
            args.Brush = lgb
        End Sub

        ' To draw a border around taskbarbox
        Private Sub xpTaskMenu_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles taskMenuBox1.Paint
            Dim itemsRect As Rectangle = Me.taskMenuBox1.GetItemsRect()
            itemsRect.Width -= 1
            itemsRect.Height -= 1
            e.Graphics.DrawRectangle(New Pen(color2), itemsRect)
        End Sub

        Private Sub OnTaskMenuProvideItemsBackgroundBrush(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.ProvideBrushEventArgs) Handles taskMenuBox1.ProvideItemsBackgroundBrush, taskMenuBox2.ProvideItemsBackgroundBrush
            Dim blend As System.Drawing.Drawing2D.Blend = New System.Drawing.Drawing2D.Blend()
            blend.Factors = New Single() {0.0F, 0.25F, 0.5F, 1.0F}
            blend.Positions = New Single() {0.0F, 0.25F, 0.5F, 1.0F, 1.5F}
            ' Estimate the TaskBar header bounds

            Dim taskbarHeader As Rectangle = args.Bounds
            ' Create and initialize the LinearGradientBrush
            If taskbarHeader.Height > 0 Then
                Dim lgbrush As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(taskbarHeader, Color.FromArgb(227, 238, 255), Color.FromArgb(227, 238, 255), 75, True)
                lgbrush.Blend = blend
                args.Brush = lgbrush
            End If
        End Sub
#End Region 'Item Background brush

#Region "Item Click Event Handler"
        Private Sub xpTaskBarBox_ItemClick(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickArgs) Handles taskMenuBox1.ItemClick, taskMenuBox2.ItemClick
            Select Case TryCast(e.XPTaskBarItem.Tag, String)
                Case "1"
                    Dim listViewItem1 As ListViewItem = New ListViewItem(New String() {"ItemClick", "XPTaskBarItem: " & e.XPTaskBarItem.Text})
                    Me.listView1.Items.Add(listViewItem1)
                Case "2"
                    Dim listViewItem2 As ListViewItem = New ListViewItem(New String() {"ItemClick", "XPTaskBarItem: " & e.XPTaskBarItem.Text})
                    Me.listView1.Items.Add(listViewItem2)
                Case "3"
                    Dim listViewItem3 As ListViewItem = New ListViewItem(New String() {"ItemClick", "XPTaskBarItem: " & e.XPTaskBarItem.Text})
                    Me.listView1.Items.Add(listViewItem3)
                Case "4"
                    Dim listViewItem4 As ListViewItem = New ListViewItem(New String() {"ItemClick", "XPTaskBarItem: " & e.XPTaskBarItem.Text})
                    Me.listView1.Items.Add(listViewItem4)
                Case "5"
                    Dim listViewItem5 As ListViewItem = New ListViewItem(New String() {"ItemClick", "XPTaskBarItem: " & e.XPTaskBarItem.Text})
                    Me.listView1.Items.Add(listViewItem5)
                    Me.ShowAboutDialog()
            End Select
        End Sub
#End Region 'Item Click Event Hamdler

#Region "AboutForm_Logic"
        Private aboutForm As DemoCommon.AboutForm = Nothing
        Private Sub ShowAboutDialog()
            aboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
            aboutForm.ShowDialog()
        End Sub

        Private Sub AboutFormCloseBtnClicked(ByVal sender As Object, ByVal e As EventArgs)
            aboutForm.Close()
        End Sub
#End Region ' AboutForm_Logic

#Region "Properties and Events"
        Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.taskMenuBox1.ToggleByButton = Not Me.taskMenuBox1.ToggleByButton
        End Sub

        Private Sub cmbcomboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles propertyComboBoxAdv.SelectedIndexChanged
            If Me.propertyComboBoxAdv.SelectedIndex = 0 Then
                Me.propertyGrid1.SelectedObject = Me.xpTaskBar1
            ElseIf Me.propertyComboBoxAdv.SelectedIndex = 1 Then
                Me.propertyGrid1.SelectedObject = Me.taskMenuBox1
            ElseIf Me.propertyComboBoxAdv.SelectedIndex = 2 Then
                Me.propertyGrid1.SelectedObject = Me.taskMenuBox2
            End If
        End Sub

        Private Sub taskMenuBox1_BeforeAnimation(ByVal sender As Object, ByVal e As System.EventArgs) Handles taskMenuBox1.BeforeAnimation, taskMenuBox2.BeforeAnimation
            Dim box As XPTaskBarBox = TryCast(sender, XPTaskBarBox)
            Dim listViewItem As ListViewItem = New ListViewItem(New String() {"Before Animation", "XPTaskBarBox: " & box.Text})
            Me.listView1.Items.Add(listViewItem)
        End Sub

        Private Sub taskMenuBox1_AfterAnimation(ByVal sender As Object, ByVal e As System.EventArgs) Handles taskMenuBox1.AfterAnimation, taskMenuBox2.AfterAnimation
            Dim box As XPTaskBarBox = TryCast(sender, XPTaskBarBox)
            Dim listViewItem As ListViewItem = New ListViewItem(New String() {"After Animation", "XPTaskBarBox: " & box.Text})
            Me.listView1.Items.Add(listViewItem)
        End Sub

        Private Sub taskMenuBox1_CollapsedStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles taskMenuBox1.CollapsedStateChanged, taskMenuBox2.CollapsedStateChanged
            Dim box As XPTaskBarBox = TryCast(sender, XPTaskBarBox)
            Dim listViewItem As ListViewItem = New ListViewItem(New String() {"CollapsedStateChanged", "XPTaskBarBox: " & box.Text})
            Me.listView1.Items.Add(listViewItem)
        End Sub

        Private Sub taskMenuBox1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles taskMenuBox1.DragDrop
            Dim listViewItem As ListViewItem = New ListViewItem(New String() {"DragDrop"})
            Me.listView1.Items.Add(listViewItem)
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonAdv1.Click
            Me.listView1.Items.Clear()
        End Sub

        Private count As Integer = 1
        Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles addNewXPTaskBarBoxButtonAdv.Click
            xpTaskBarBoxNew = New XPTaskBarBox()
            xpTaskBarBoxNew.HeaderImageList = Me.imageList2
            xpTaskBarBoxNew.HeaderDirection = taskMenuBox1.HeaderDirection
            xpTaskBarBoxNew.HeaderBackColor = Color.FromArgb(199, 216, 237)
            xpTaskBarBoxNew.ItemBackColor = Color.FromArgb(228, 237, 248)
            xpTaskBarBoxNew.FocusOnClick = False
            xpTaskBarBoxNew.ImageList = Me.imageList1
            xpTaskBarBoxNew.HeaderImageIndex = 2
            xpTaskBarBoxNew.AllowDrop = True

            xpTaskBarBoxNew.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() {New XPTaskBarItem("New Item1", System.Drawing.Color.Empty, 1, 1, "", True, True, "XPTaskBarItem0"), New XPTaskBarItem("New Item2", System.Drawing.Color.Empty, 3, 2, "", True, True, "XPTaskBarItem1"), New XPTaskBarItem("New Item3", System.Drawing.Color.Empty, 6, 3, "", True, True, "XPTaskBarItem2"), New XPTaskBarItem("New Item4", System.Drawing.Color.Empty, 5, 4, "", True, True, "XPTaskBarItem3"), New XPTaskBarItem("New Item4", System.Drawing.Color.Empty, 4, 5, "", True, True, "XPTaskBarItem4")})
            xpTaskBarBoxNew.Location = New System.Drawing.Point(0, 0)
            xpTaskBarBoxNew.Name = "xpTaskBarBox1" & count.ToString()
            xpTaskBarBoxNew.Size = New Size(188, 180)
            xpTaskBarBoxNew.TabIndex = 0
            xpTaskBarBoxNew.Text = "New Box" & count.ToString()
            AddHandler xpTaskBarBoxNew.ProvideHeaderBackgroundBrush, AddressOf OnTaskMenuProvideHeaderBackgroundBrush
            AddHandler xpTaskBarBoxNew.ProvideItemsBackgroundBrush, AddressOf OnTaskMenuProvideItemsBackgroundBrush
            AddHandler xpTaskBarBoxNew.BeforeAnimation, AddressOf taskMenuBox1_BeforeAnimation
            AddHandler xpTaskBarBoxNew.AfterAnimation, AddressOf taskMenuBox1_AfterAnimation
            AddHandler xpTaskBarBoxNew.ItemClick, AddressOf xpTaskBarBoxNew_ItemClick
            AddHandler xpTaskBarBoxNew.CollapsedStateChanged, AddressOf taskMenuBox1_CollapsedStateChanged
            Me.xpTaskBar1.Controls.Add(xpTaskBarBoxNew)
            count += 1
        End Sub

        Private Sub xpTaskBarBoxNew_ItemClick(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickArgs)
            Select Case TryCast(e.XPTaskBarItem.Text, String)
                Case "New Item1"
                    Dim listViewItem1 As ListViewItem = New ListViewItem(New String() {"ItemClick", "XPTaskBarItem: " & e.XPTaskBarItem.Text})
                    Me.listView1.Items.Add(listViewItem1)
                Case "New Item2"
                    Dim listViewItem2 As ListViewItem = New ListViewItem(New String() {"ItemClick", "XPTaskBarItem: " & e.XPTaskBarItem.Text})
                    Me.listView1.Items.Add(listViewItem2)
                Case "New Item3"
                    Dim listViewItem3 As ListViewItem = New ListViewItem(New String() {"ItemClick", "XPTaskBarItem: " & e.XPTaskBarItem.Text})
                    Me.listView1.Items.Add(listViewItem3)
                Case "New Item4"
                    Dim listViewItem4 As ListViewItem = New ListViewItem(New String() {"ItemClick", "XPTaskBarItem: " & e.XPTaskBarItem.Text})
                    Me.listView1.Items.Add(listViewItem4)
                Case "New Item5"
                    Dim listViewItem5 As ListViewItem = New ListViewItem(New String() {"ItemClick", "XPTaskBarItem: " & e.XPTaskBarItem.Text})
                    Me.listView1.Items.Add(listViewItem5)
                    Me.ShowAboutDialog()
            End Select
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
            Me.xpTaskBar1.VerticalLayout = Not Me.xpTaskBar1.VerticalLayout
            Me.xpTaskBar1.ColWidthOnHorizontalAlignment = CInt(Fix(Me.numericUpDown3.Value))
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            Me.xpTaskBar1.ThemesEnabled = Not Me.xpTaskBar1.ThemesEnabled
        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
            Me.xpTaskBar1.AutoScroll = Me.checkBox3.Checked
        End Sub

        Private Sub numericUpDown3_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown3.ValueChanged
            Me.xpTaskBar1.ColWidthOnHorizontalAlignment = CInt(Fix(Me.numericUpDown3.Value))
        End Sub

        Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
            Me.xpTaskBar1.DockPadding.All = CInt(Fix(Me.numericUpDown1.Value))
        End Sub


        Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox4.CheckedChanged
            For Each ctrl As Control In Me.xpTaskBar1.Controls
                If TypeOf ctrl Is XPTaskBarBox Then
                    Dim taskBarBox As XPTaskBarBox = CType(ctrl, XPTaskBarBox)
                    taskBarBox.AllowDrop = Me.checkBox4.Checked
                End If
            Next ctrl
        End Sub

        Private Sub checkBox5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox5.CheckedChanged
            For Each ctrl As Control In Me.xpTaskBar1.Controls
                If TypeOf ctrl Is XPTaskBarBox Then
                    Dim taskBarBox As XPTaskBarBox = CType(ctrl, XPTaskBarBox)
                    If Me.checkBox5.Checked Then
                        taskBarBox.CollapseContent()
                    Else
                        taskBarBox.ExpandContent()
                    End If
                End If
            Next ctrl
        End Sub

        Private Sub checkBox7_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox7.CheckedChanged
            For Each ctrl As Control In Me.xpTaskBar1.Controls
                If TypeOf ctrl Is XPTaskBarBox Then
                    Dim taskBarBox As XPTaskBarBox = CType(ctrl, XPTaskBarBox)
                    taskBarBox.ShowCollapseButton = Me.checkBox7.Checked
                End If
            Next ctrl
        End Sub

        Private Sub checkBox8_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox8.CheckedChanged
            For Each ctrl As Control In Me.xpTaskBar1.Controls
                If TypeOf ctrl Is XPTaskBarBox Then
                    Dim taskBarBox As XPTaskBarBox = CType(ctrl, XPTaskBarBox)
                    taskBarBox.ToggleByButton = Me.checkBox8.Checked
                End If
            Next ctrl
        End Sub

        Private Sub comboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles headerDirectionComboBoxAdv.SelectedIndexChanged
            For Each ctrl As Control In Me.xpTaskBar1.Controls
                If TypeOf ctrl Is XPTaskBarBox Then
                    If Me.headerDirectionComboBoxAdv.SelectedIndex = 0 Then
                        Dim taskBarBox As XPTaskBarBox = CType(ctrl, XPTaskBarBox)
                        taskBarBox.HeaderDirection = Syncfusion.Windows.Forms.Tools.XPTaskBarBox.HeaderDirectionFormat.LeftToRight

                    ElseIf Me.headerDirectionComboBoxAdv.SelectedIndex = 1 Then
                        Dim taskBarBox As XPTaskBarBox = CType(ctrl, XPTaskBarBox)
                        taskBarBox.HeaderDirection = Syncfusion.Windows.Forms.Tools.XPTaskBarBox.HeaderDirectionFormat.RightToLeft
                    End If
                End If
            Next ctrl
        End Sub

        Private Sub comboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles headerTextAlignmentComboBox.SelectedIndexChanged
            For Each ctrl As Control In Me.xpTaskBar1.Controls
                If TypeOf ctrl Is XPTaskBarBox Then
                    Dim taskBarBox As XPTaskBarBox = CType(ctrl, XPTaskBarBox)
                    If Me.headerTextAlignmentComboBox.SelectedIndex = 0 Then
                        taskBarBox.HeaderTextAlign = StringAlignment.Near
                    ElseIf Me.headerTextAlignmentComboBox.SelectedIndex = 1 Then
                        taskBarBox.HeaderTextAlign = StringAlignment.Center
                    ElseIf Me.headerTextAlignmentComboBox.SelectedIndex = 2 Then
                        taskBarBox.HeaderTextAlign = StringAlignment.Far
                    End If
                End If
            Next ctrl

        End Sub

        Private Sub numericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown2.Click
            For Each ctrl As Control In Me.xpTaskBar1.Controls
                If TypeOf ctrl Is XPTaskBarBox Then
                    Dim taskBarBox As XPTaskBarBox = CType(ctrl, XPTaskBarBox)
                    taskBarBox.PADX = CInt(Fix(Me.numericUpDown2.Value))
                End If
            Next ctrl
        End Sub

        Private Sub numericUpDown4_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown4.Click
            For Each ctrl As Control In Me.xpTaskBar1.Controls
                If TypeOf ctrl Is XPTaskBarBox Then
                    Dim taskBarBox As XPTaskBarBox = CType(ctrl, XPTaskBarBox)
                    taskBarBox.PADY = CInt(Fix(Me.numericUpDown4.Value))
                End If
            Next ctrl
        End Sub

        Private Sub taskMenuBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.taskMenuBox1.HeaderImageIndex = 0
        End Sub
#End Region

        Private Sub CheckBox6_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
            If (CheckBox6.Checked) Then
                xpTaskBar1.Style = XPTaskBarStyle.Office2007
                colorSchemeCombo.Enabled = True
            Else
                xpTaskBar1.Style = XPTaskBarStyle.Default
                colorSchemeCombo.Enabled = False
            End If
        End Sub

        Private Sub colorSchemeCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorSchemeCombo.SelectedIndexChanged
            Select Case colorSchemeCombo.SelectedIndex
                Case 0
                    xpTaskBar1.Office2007ColorScheme = Office2007Theme.Blue
                Case 1
                    xpTaskBar1.Office2007ColorScheme = Office2007Theme.Silver
                Case 2
                    xpTaskBar1.Office2007ColorScheme = Office2007Theme.Black
                Case 3
                    xpTaskBar1.Office2007ColorScheme = Office2007Theme.Managed
                    Office2007Colors.ApplyManagedColors(Me, Color.GreenYellow)
            End Select
        End Sub

        Private Sub ButtonAdv2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdv2.Click
            Me.taskMenuBox1.Items.Sort()
        End Sub
    End Class
End Namespace
