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
Namespace SplitContainerAdv
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Office2007Form
		Private WithEvents splitContainerAdv1 As Syncfusion.Windows.Forms.Tools.SplitContainerAdv
		Private WithEvents checkBox1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBox2 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBox3 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
		Private WithEvents numericUpDown2 As System.Windows.Forms.NumericUpDown
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
        Private splitContainerAdv2 As Syncfusion.Windows.Forms.Tools.SplitContainerAdv
        Private label4 As Label
        Private WithEvents comboBox2 As ComboBox
        Private treeViewAdv1 As Syncfusion.Windows.Forms.Tools.TreeViewAdv
        Private gradientLabel1 As Syncfusion.Windows.Forms.Tools.GradientLabel
        Private panel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
        Private WithEvents radioButtonAdv1 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
        Private groupBox1 As GroupBox
        Private radioButtonAdv2 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
        Private label7 As Label
        Private label6 As Label
        Private label21 As Label
        Private toolTip1 As ToolTip
        Private components As IContainer

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()


            Me.comboBox2.SelectedIndex = 0

            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
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
            Me.components = New System.ComponentModel.Container
            Dim TreeNodeAdvStyleInfo1 As Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo
            Dim TreeNodeAdv1 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv2 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv3 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv4 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv5 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv6 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv7 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv8 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv9 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv10 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv11 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv12 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv13 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv14 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv15 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv16 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv17 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv18 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv19 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.splitContainerAdv1 = New Syncfusion.Windows.Forms.Tools.SplitContainerAdv
            Me.treeViewAdv1 = New Syncfusion.Windows.Forms.Tools.TreeViewAdv
            Me.splitContainerAdv2 = New Syncfusion.Windows.Forms.Tools.SplitContainerAdv
            Me.panel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label21 = New System.Windows.Forms.Label
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.radioButtonAdv2 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.radioButtonAdv1 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.label7 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.checkBox1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.checkBox3 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBox2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.label1 = New System.Windows.Forms.Label
            Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown
            Me.label2 = New System.Windows.Forms.Label
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.gradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            CType(Me.splitContainerAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerAdv1.Panel1.SuspendLayout()
            Me.splitContainerAdv1.Panel2.SuspendLayout()
            Me.splitContainerAdv1.SuspendLayout()
            CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerAdv2.Panel1.SuspendLayout()
            Me.splitContainerAdv2.Panel2.SuspendLayout()
            Me.splitContainerAdv2.SuspendLayout()
            CType(Me.panel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            CType(Me.radioButtonAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'splitContainerAdv1
            '
            Me.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerAdv1.FixedPanel = Syncfusion.Windows.Forms.Tools.Enums.FixedPanel.Panel1
            Me.splitContainerAdv1.GripDark = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Salmon)
            Me.splitContainerAdv1.GripLight = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Yellow)
            Me.splitContainerAdv1.HotGripDark = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Info, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer)))
            Me.splitContainerAdv1.HotGripLight = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.PatternStyle.Percent20, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Red)
            Me.splitContainerAdv1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerAdv1.Name = "splitContainerAdv1"
            '
            'splitContainerAdv1.Panel1
            '
            Me.splitContainerAdv1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.splitContainerAdv1.Panel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(252, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer)))
            Me.splitContainerAdv1.Panel1.Controls.Add(Me.treeViewAdv1)
            '
            'splitContainerAdv1.Panel2
            '
            Me.splitContainerAdv1.Panel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(252, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer)))
            Me.splitContainerAdv1.Panel2.Controls.Add(Me.splitContainerAdv2)
            Me.splitContainerAdv1.PanelToBeCollapsed = Syncfusion.Windows.Forms.Tools.Enums.CollapsedPanel.Panel1
            Me.splitContainerAdv1.Size = New System.Drawing.Size(713, 461)
            Me.splitContainerAdv1.SplitterDistance = 191
            Me.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Blue
            Me.splitContainerAdv1.TabIndex = 0
            Me.splitContainerAdv1.Text = "splitContainerAdv1"
            Me.splitContainerAdv1.ThemesEnabled = True
            '
            'treeViewAdv1
            '
            Me.treeViewAdv1.AllowDrop = True
            Me.treeViewAdv1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(241, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(241, Byte), Integer)))
            TreeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = True
            Me.treeViewAdv1.BaseStylePairs.AddRange(New Syncfusion.Windows.Forms.Tools.StyleNamePair() {New Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", TreeNodeAdvStyleInfo1)})
            Me.treeViewAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Fill
            '
            '
            '
            Me.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.treeViewAdv1.HelpTextControl.Location = New System.Drawing.Point(732, 0)
            Me.treeViewAdv1.HelpTextControl.Name = "helpText"
            Me.treeViewAdv1.HelpTextControl.Size = New System.Drawing.Size(50, 17)
            Me.treeViewAdv1.HelpTextControl.TabIndex = 0
            Me.treeViewAdv1.HelpTextControl.Text = "help text"
            Me.treeViewAdv1.Location = New System.Drawing.Point(0, 0)
            Me.treeViewAdv1.Name = "treeViewAdv1"
            Me.treeViewAdv1.NoChildrenImgIndex = -1
            TreeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv1.EnsureDefaultOptionedChild = True
            TreeNodeAdv1.Expanded = True
            TreeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv2.EnsureDefaultOptionedChild = True
            TreeNodeAdv2.Optioned = True
            TreeNodeAdv2.ShowOptionButton = True
            TreeNodeAdv2.Text = "Single"
            TreeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv3.EnsureDefaultOptionedChild = True
            TreeNodeAdv3.ShowOptionButton = True
            TreeNodeAdv3.Text = "Married"
            TreeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv4.EnsureDefaultOptionedChild = True
            TreeNodeAdv4.ShowOptionButton = True
            TreeNodeAdv4.Text = "Married with children"
            TreeNodeAdv1.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv2, TreeNodeAdv3, TreeNodeAdv4})
            TreeNodeAdv1.Text = "Marital Status"
            TreeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv5.EnsureDefaultOptionedChild = True
            TreeNodeAdv5.Expanded = True
            TreeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv6.EnsureDefaultOptionedChild = True
            TreeNodeAdv6.Optioned = True
            TreeNodeAdv6.Text = "Hepatitis B"
            TreeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv7.EnsureDefaultOptionedChild = True
            TreeNodeAdv7.Text = "Tetanus"
            TreeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv8.EnsureDefaultOptionedChild = True
            TreeNodeAdv8.Text = "Polio"
            TreeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv9.EnsureDefaultOptionedChild = True
            TreeNodeAdv9.Text = "Measles"
            TreeNodeAdv5.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv6, TreeNodeAdv7, TreeNodeAdv8, TreeNodeAdv9})
            TreeNodeAdv5.Text = "Baby Vaccines"
            TreeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv10.EnsureDefaultOptionedChild = True
            TreeNodeAdv10.Expanded = True
            TreeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv11.EnsureDefaultOptionedChild = True
            TreeNodeAdv11.Optioned = True
            TreeNodeAdv11.Text = "Canada"
            TreeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv12.EnsureDefaultOptionedChild = True
            TreeNodeAdv12.Text = "France"
            TreeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv13.EnsureDefaultOptionedChild = True
            TreeNodeAdv13.Text = "Germany"
            TreeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv14.EnsureDefaultOptionedChild = True
            TreeNodeAdv14.Text = "UK"
            TreeNodeAdv10.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv11, TreeNodeAdv12, TreeNodeAdv13, TreeNodeAdv14})
            TreeNodeAdv10.Text = "Node9"
            TreeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv15.EnsureDefaultOptionedChild = True
            TreeNodeAdv15.Expanded = True
            TreeNodeAdv16.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv16.EnsureDefaultOptionedChild = True
            TreeNodeAdv16.Optioned = True
            TreeNodeAdv16.Text = "Finding Nemo"
            TreeNodeAdv17.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv17.EnsureDefaultOptionedChild = True
            TreeNodeAdv17.Text = "Lord of the Rings"
            TreeNodeAdv18.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv18.EnsureDefaultOptionedChild = True
            TreeNodeAdv18.Text = "Matrix Reloaded"
            TreeNodeAdv19.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv19.EnsureDefaultOptionedChild = True
            TreeNodeAdv19.Text = "T3"
            TreeNodeAdv15.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv16, TreeNodeAdv17, TreeNodeAdv18, TreeNodeAdv19})
            TreeNodeAdv15.Text = "Top 2003 Movies"
            Me.treeViewAdv1.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv1, TreeNodeAdv5, TreeNodeAdv10, TreeNodeAdv15})
            Me.treeViewAdv1.PathSeparator = "/"
            Me.treeViewAdv1.Size = New System.Drawing.Size(191, 461)
            Me.treeViewAdv1.TabIndex = 1
            Me.treeViewAdv1.Text = "treeViewAdv1"
            '
            '
            '
            Me.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info
            Me.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.treeViewAdv1.ToolTipControl.Location = New System.Drawing.Point(642, 0)
            Me.treeViewAdv1.ToolTipControl.Name = "toolTip"
            Me.treeViewAdv1.ToolTipControl.Size = New System.Drawing.Size(41, 17)
            Me.treeViewAdv1.ToolTipControl.TabIndex = 1
            Me.treeViewAdv1.ToolTipControl.Text = "toolTip"
            '
            'splitContainerAdv2
            '
            Me.splitContainerAdv2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer)))
            Me.splitContainerAdv2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerAdv2.ExpandFill = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Blue)
            Me.splitContainerAdv2.FixedPanel = Syncfusion.Windows.Forms.Tools.Enums.FixedPanel.Panel1
            Me.splitContainerAdv2.HotBackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer)))
            Me.splitContainerAdv2.HotExpandFill = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Blue)
            Me.splitContainerAdv2.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerAdv2.Name = "splitContainerAdv2"
            Me.splitContainerAdv2.Orientation = System.Windows.Forms.Orientation.Vertical
            '
            'splitContainerAdv2.Panel1
            '
            Me.splitContainerAdv2.Panel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(252, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer)))
            Me.splitContainerAdv2.Panel1.Controls.Add(Me.panel2)
            '
            'splitContainerAdv2.Panel2
            '
            Me.splitContainerAdv2.Panel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(252, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer)))
            Me.splitContainerAdv2.Panel2.Controls.Add(Me.gradientLabel1)
            Me.splitContainerAdv2.PanelToBeCollapsed = Syncfusion.Windows.Forms.Tools.Enums.CollapsedPanel.Panel1
            Me.splitContainerAdv2.Size = New System.Drawing.Size(515, 461)
            Me.splitContainerAdv2.SplitterDistance = 273
            Me.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Blue
            Me.splitContainerAdv2.TabIndex = 0
            Me.splitContainerAdv2.Text = "splitContainerAdv2"
            Me.splitContainerAdv2.ThemesEnabled = True
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.Transparent
            Me.panel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(252, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer)))
            Me.panel2.BorderColor = System.Drawing.Color.Black
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.panel2.Controls.Add(Me.label21)
            Me.panel2.Controls.Add(Me.groupBox1)
            Me.panel2.Controls.Add(Me.label7)
            Me.panel2.Controls.Add(Me.label6)
            Me.panel2.Controls.Add(Me.label4)
            Me.panel2.Controls.Add(Me.checkBox1)
            Me.panel2.Controls.Add(Me.comboBox2)
            Me.panel2.Controls.Add(Me.checkBox3)
            Me.panel2.Controls.Add(Me.checkBox2)
            Me.panel2.Controls.Add(Me.label1)
            Me.panel2.Controls.Add(Me.numericUpDown2)
            Me.panel2.Controls.Add(Me.label2)
            Me.panel2.Controls.Add(Me.numericUpDown1)
            Me.panel2.Location = New System.Drawing.Point(53, 26)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(408, 206)
            Me.panel2.TabIndex = 18
            '
            'label21
            '
            Me.label21.Image = CType(resources.GetObject("label21.Image"), System.Drawing.Image)
            Me.label21.Location = New System.Drawing.Point(104, 165)
            Me.label21.Name = "label21"
            Me.label21.Size = New System.Drawing.Size(20, 20)
            Me.label21.TabIndex = 25
            Me.toolTip1.SetToolTip(Me.label21, "Set to true, disallows user from dragging the splitter. However toggling the pane" & _
                    "l is possible.")
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.radioButtonAdv2)
            Me.groupBox1.Controls.Add(Me.radioButtonAdv1)
            Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.groupBox1.Location = New System.Drawing.Point(198, 109)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(191, 76)
            Me.groupBox1.TabIndex = 19
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Toggle Panel On"
            '
            'radioButtonAdv2
            '
            Me.radioButtonAdv2.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv2.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv2.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv2.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv2.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv2.Location = New System.Drawing.Point(6, 43)
            Me.radioButtonAdv2.Name = "radioButtonAdv2"
            Me.radioButtonAdv2.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv2.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv2.Size = New System.Drawing.Size(100, 27)
            Me.radioButtonAdv2.TabIndex = 7
            Me.radioButtonAdv2.Text = "Double Click"
            Me.radioButtonAdv2.ThemesEnabled = True
            '
            'radioButtonAdv1
            '
            Me.radioButtonAdv1.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv1.Checked = True
            Me.radioButtonAdv1.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv1.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv1.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv1.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv1.Location = New System.Drawing.Point(6, 16)
            Me.radioButtonAdv1.Name = "radioButtonAdv1"
            Me.radioButtonAdv1.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv1.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv1.Size = New System.Drawing.Size(100, 27)
            Me.radioButtonAdv1.TabIndex = 6
            Me.radioButtonAdv1.Text = "Click"
            Me.radioButtonAdv1.ThemesEnabled = True
            '
            'label7
            '
            Me.label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label7.Location = New System.Drawing.Point(6, 32)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(375, 1)
            Me.label7.TabIndex = 17
            '
            'label6
            '
            Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label6.Image = CType(resources.GetObject("label6.Image"), System.Drawing.Image)
            Me.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label6.Location = New System.Drawing.Point(6, 0)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(92, 32)
            Me.label6.TabIndex = 18
            Me.label6.Text = "Properties"
            Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.BackColor = System.Drawing.Color.Transparent
            Me.label4.Location = New System.Drawing.Point(6, 45)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(30, 13)
            Me.label4.TabIndex = 16
            Me.label4.Text = "Style"
            '
            'checkBox1
            '
            Me.checkBox1.AutoHeight = True
            Me.checkBox1.BackColor = System.Drawing.Color.Transparent
            Me.checkBox1.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBox1.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBox1.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBox1.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBox1.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBox1.Location = New System.Drawing.Point(3, 165)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.ShadowColor = System.Drawing.Color.Black
            Me.checkBox1.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBox1.Size = New System.Drawing.Size(104, 17)
            Me.checkBox1.TabIndex = 3
            Me.checkBox1.Text = "IsSplitter Fixed"
            Me.checkBox1.ThemesEnabled = True
            '
            'comboBox2
            '
            Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox2.Items.AddRange(New Object() {"None"})
            Me.comboBox2.Location = New System.Drawing.Point(62, 46)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(104, 21)
            Me.comboBox2.TabIndex = 15
            '
            'checkBox3
            '
            Me.checkBox3.AutoHeight = True
            Me.checkBox3.BackColor = System.Drawing.Color.Transparent
            Me.checkBox3.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBox3.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBox3.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBox3.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBox3.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBox3.Location = New System.Drawing.Point(3, 125)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.ShadowColor = System.Drawing.Color.Black
            Me.checkBox3.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBox3.Size = New System.Drawing.Size(183, 17)
            Me.checkBox3.TabIndex = 5
            Me.checkBox3.Text = "Panel2 Collapsed"
            Me.checkBox3.ThemesEnabled = True
            '
            'checkBox2
            '
            Me.checkBox2.AutoHeight = True
            Me.checkBox2.BackColor = System.Drawing.Color.Transparent
            Me.checkBox2.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBox2.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBox2.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBox2.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBox2.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBox2.Location = New System.Drawing.Point(3, 86)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.ShadowColor = System.Drawing.Color.Black
            Me.checkBox2.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBox2.Size = New System.Drawing.Size(195, 17)
            Me.checkBox2.TabIndex = 4
            Me.checkBox2.Text = "Panel1 Collapsed"
            Me.checkBox2.ThemesEnabled = True
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.Color.Transparent
            Me.label1.Location = New System.Drawing.Point(198, 45)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(84, 13)
            Me.label1.TabIndex = 8
            Me.label1.Text = "Splitter Distance"
            '
            'numericUpDown2
            '
            Me.numericUpDown2.Location = New System.Drawing.Point(288, 72)
            Me.numericUpDown2.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
            Me.numericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown2.Name = "numericUpDown2"
            Me.numericUpDown2.Size = New System.Drawing.Size(104, 20)
            Me.numericUpDown2.TabIndex = 7
            Me.numericUpDown2.Value = New Decimal(New Integer() {7, 0, 0, 0})
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.BackColor = System.Drawing.Color.Transparent
            Me.label2.Location = New System.Drawing.Point(198, 79)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(70, 13)
            Me.label2.TabIndex = 9
            Me.label2.Text = "Splitter Width"
            '
            'numericUpDown1
            '
            Me.numericUpDown1.Location = New System.Drawing.Point(288, 46)
            Me.numericUpDown1.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.Size = New System.Drawing.Size(104, 20)
            Me.numericUpDown1.TabIndex = 6
            Me.numericUpDown1.Value = New Decimal(New Integer() {191, 0, 0, 0})
            '
            'gradientLabel1
            '
            Me.gradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo
            Me.gradientLabel1.BorderSides = CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) _
                        Or System.Windows.Forms.Border3DSide.Right) _
                        Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide)
            Me.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.gradientLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.gradientLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientLabel1.Location = New System.Drawing.Point(42, 36)
            Me.gradientLabel1.Name = "gradientLabel1"
            Me.gradientLabel1.Size = New System.Drawing.Size(428, 108)
            Me.gradientLabel1.TabIndex = 0
            Me.gradientLabel1.Text = resources.GetString("gradientLabel1.Text")
            Me.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(713, 461)
            Me.Controls.Add(Me.splitContainerAdv1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Split ContainerAdv"
            Me.splitContainerAdv1.Panel1.ResumeLayout(False)
            Me.splitContainerAdv1.Panel2.ResumeLayout(False)
            CType(Me.splitContainerAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerAdv1.ResumeLayout(False)
            CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerAdv2.Panel1.ResumeLayout(False)
            Me.splitContainerAdv2.Panel2.ResumeLayout(False)
            CType(Me.splitContainerAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerAdv2.ResumeLayout(False)
            CType(Me.panel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.groupBox1.ResumeLayout(False)
            CType(Me.radioButtonAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.comboBox2.DataSource = System.Enum.GetValues(GetType(Syncfusion.Windows.Forms.Tools.Enums.Style))
            Me.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Blue
            Me.comboBox2.SelectedIndex = 2
        End Sub


       

        Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
            Me.splitContainerAdv1.SplitterDistance = CInt(Fix(Me.numericUpDown1.Value))
        End Sub

        Private Sub splitContainerAdv1_SplitterMoving(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.Events.SplitterMoveEventArgs) Handles splitContainerAdv1.SplitterMoving
            Me.numericUpDown1.Value = Me.splitContainerAdv1.SplitterDistance
        End Sub

        Private Sub numericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown2.ValueChanged
            Me.splitContainerAdv1.SplitterWidth = CInt(Fix(Me.numericUpDown2.Value))
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckStateChanged
            If Me.checkBox2.Checked Then
                Me.splitContainerAdv1.Panel1Collapsed = True
                Me.checkBox3.Checked = False
            Else
                Me.splitContainerAdv1.Panel1Collapsed = False
            End If


        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckStateChanged
            If Me.checkBox3.Checked Then
                Me.splitContainerAdv2.Panel2Collapsed = True
                Me.checkBox2.Checked = False
            Else
                Me.splitContainerAdv2.Panel2Collapsed = False
            End If


        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckStateChanged
            If Me.checkBox1.Checked Then
                Me.splitContainerAdv1.IsSplitterFixed = True
                Me.splitContainerAdv2.IsSplitterFixed = True
            Else
                Me.splitContainerAdv1.IsSplitterFixed = False
                Me.splitContainerAdv2.IsSplitterFixed = False
            End If
        End Sub

        Private Sub comboBox2_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox2.SelectedValueChanged
            If Not Me.comboBox2.SelectedValue Is Nothing Then
                Dim v As Syncfusion.Windows.Forms.Tools.Enums.Style = CType(Me.comboBox2.SelectedValue, Syncfusion.Windows.Forms.Tools.Enums.Style)
                Me.splitContainerAdv2.Style = v
                Me.splitContainerAdv1.Style = v
                SetTheme(v)
            End If
        End Sub

        Private Sub SetTheme(ByVal style As Syncfusion.Windows.Forms.Tools.Enums.Style)
            Select Case style
                Case Syncfusion.Windows.Forms.Tools.Enums.Style.None
                    Me.panel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
                    Me.panel2.BackColor = Color.Transparent
                    Me.treeViewAdv1.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
                    Me.treeViewAdv1.BackColor = Color.Transparent
                    Me.ColorScheme = Office2007Theme.Blue
                Case Syncfusion.Windows.Forms.Tools.Enums.Style.Default
                    SetBackGroundColorToPanels(134, 134, 134, 134, 134, 134)
                    Me.ColorScheme = Office2007Theme.Black
                Case Syncfusion.Windows.Forms.Tools.Enums.Style.Mozilla
                    SetBackGroundColorToPanels(134, 134, 134, 134, 134, 134)
                    Me.ColorScheme = Office2007Theme.Black
                Case Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Black
                    SetBackGroundColorToPanels(90, 90, 90, 134, 134, 134)
                    Me.ColorScheme = Office2007Theme.Black
                Case Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Blue
                    SetBackGroundColorToPanels(186, 213, 252, 228, 240, 255)
                    Me.ColorScheme = Office2007Theme.Blue
                Case Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Silver
                    SetBackGroundColorToPanels(192, 196, 205, 221, 225, 229)
                    Me.ColorScheme = Office2007Theme.Silver
                Case Syncfusion.Windows.Forms.Tools.Enums.Style.Office2003
                    SetBackGroundColorToPanels(181, 196, 235, 197, 213, 233)
                    Me.ColorScheme = Office2007Theme.Blue
                Case Syncfusion.Windows.Forms.Tools.Enums.Style.OfficeXP
                    SetBackGroundColorToPanels(181, 196, 235, 197, 213, 233)
                    Me.ColorScheme = Office2007Theme.Blue
                Case Syncfusion.Windows.Forms.Tools.Enums.Style.VS2005
                    SetBackGroundColorToPanels(134, 134, 134, 134, 134, 134)
                    Me.ColorScheme = Office2007Theme.Black
            End Select
        End Sub

        Private Sub SetBackGroundColorToPanels(ByVal r1 As Integer, ByVal g1 As Integer, ByVal b1 As Integer, ByVal r As Integer, ByVal g As Integer, ByVal b As Integer)
            Me.treeViewAdv1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(r1))))), (CInt(Fix((CByte(g1))))), (CInt(Fix((CByte(b1)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(r))))), (CInt(Fix((CByte(g))))), (CInt(Fix((CByte(b)))))))
            Me.panel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(r1))))), (CInt(Fix((CByte(g1))))), (CInt(Fix((CByte(b1)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(r))))), (CInt(Fix((CByte(g))))), (CInt(Fix((CByte(b)))))))
        End Sub



        Private Sub radioButtonAdv1_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv1.CheckChanged
            If Me.radioButtonAdv1.Checked Then
                Me.splitContainerAdv1.TogglePanelOn = Syncfusion.Windows.Forms.Tools.Enums.TogglePanelOn.Click
                Me.splitContainerAdv2.TogglePanelOn = Syncfusion.Windows.Forms.Tools.Enums.TogglePanelOn.Click
            Else
                Me.splitContainerAdv1.TogglePanelOn = Syncfusion.Windows.Forms.Tools.Enums.TogglePanelOn.DoubleClick
                Me.splitContainerAdv2.TogglePanelOn = Syncfusion.Windows.Forms.Tools.Enums.TogglePanelOn.DoubleClick
            End If
        End Sub

	End Class
End Namespace
