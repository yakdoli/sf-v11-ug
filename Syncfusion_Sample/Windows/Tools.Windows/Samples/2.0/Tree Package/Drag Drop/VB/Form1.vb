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
Imports System.Diagnostics

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Namespace TreeViewAdvDragDrop
	#Region "Class Form1 Description"

	Public Class Form1
		Inherits Office2007Form

		#Region "Variable Declaration"
		Private WithEvents treeViewAdv1 As Syncfusion.Windows.Forms.Tools.TreeViewAdv
		' Use the tracker only when you want to support dropping adjacent (above or below) to a node.
		' Otherwise simply listen to the DragOver and DragDrop events and provide/use the DropEffect.
		' When used this tracker will draw indicators above or below a node while dragging an item
		' over the node. The tracker need to be updated as shown below in the DragXXX events.
		Private treeViewDragHighlightTracker As TreeViewAdvDragHighlightTracker = Nothing
		Private panel1 As Panel
		Private label20 As Label
		Private label19 As Label
        Private WithEvents HighLighterColor As ButtonEdit
        Private buttonEditChildButton1 As ButtonEditChildButton
        Private label1 As Label
        Private colorDialog1 As ColorDialog
        Private components As IContainer
        Private label4 As Label
        Private label3 As Label
        Private scrollersFrame1 As ScrollersFrame
        Friend WithEvents CheckBoxAdv1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private WithEvents listView1 As System.Windows.Forms.ListView
        Private WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
        Private listViewItem1 As System.Windows.Forms.ListViewItem
#End Region

#Region "Form Constructor Initialization and Disposing"

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Me.treeViewAdv1.AutoScrolling = ScrollBars.Both

            '
            ' TODO: Add any constructor code after InitializeComponent call
            '


            '			#Region "Delegate Declaration"
            Me.treeViewDragHighlightTracker = New TreeViewAdvDragHighlightTracker(Me.treeViewAdv1)
            ' This event will let you disable certain drop-positions for certain nodes while dragging.
            AddHandler treeViewDragHighlightTracker.QueryAllowedPositionsForNode, AddressOf TreeDragDrop_QueryAllowedPositionsForNode
            AddHandler treeViewDragHighlightTracker.QueryDragInsertInfo, AddressOf treeViewDragHighlightTracker_QueryDragInsertInfo

            '			#End Region
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not treeViewDragHighlightTracker Is Nothing Then
                    RemoveHandler treeViewDragHighlightTracker.QueryAllowedPositionsForNode, AddressOf TreeDragDrop_QueryAllowedPositionsForNode
                    Me.treeViewDragHighlightTracker = Nothing
                End If
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub
#End Region

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
            Dim TreeNodeAdv20 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv21 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv22 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv23 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv24 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv25 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv26 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv27 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv28 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim TreeNodeAdv29 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.treeViewAdv1 = New Syncfusion.Windows.Forms.Tools.TreeViewAdv
            Me.panel1 = New System.Windows.Forms.Panel
            Me.label4 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.HighLighterColor = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton1 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.label1 = New System.Windows.Forms.Label
            Me.label20 = New System.Windows.Forms.Label
            Me.label19 = New System.Windows.Forms.Label
            Me.colorDialog1 = New System.Windows.Forms.ColorDialog
            Me.scrollersFrame1 = New Syncfusion.Windows.Forms.ScrollersFrame(Me.components)
            Me.CheckBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.listView1 = New System.Windows.Forms.ListView
            Me.columnHeader1 = New System.Windows.Forms.ColumnHeader
            CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.HighLighterColor, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.HighLighterColor.SuspendLayout()
            CType(Me.CheckBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'treeViewAdv1
            '
            Me.treeViewAdv1.AllowDrop = True
            Me.treeViewAdv1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.Silver, System.Drawing.Color.Navy)
            TreeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = True
            Me.treeViewAdv1.BaseStylePairs.AddRange(New Syncfusion.Windows.Forms.Tools.StyleNamePair() {New Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", TreeNodeAdvStyleInfo1)})
            Me.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Left
            Me.treeViewAdv1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.treeViewAdv1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            '
            '
            Me.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.treeViewAdv1.HelpTextControl.Location = New System.Drawing.Point(732, 0)
            Me.treeViewAdv1.HelpTextControl.Name = "helpText"
            Me.treeViewAdv1.HelpTextControl.Size = New System.Drawing.Size(50, 17)
            Me.treeViewAdv1.HelpTextControl.TabIndex = 0
            Me.treeViewAdv1.HelpTextControl.Text = "help text"
            Me.treeViewAdv1.Indent = 20
            Me.treeViewAdv1.LineColor = System.Drawing.Color.White
            Me.treeViewAdv1.Location = New System.Drawing.Point(0, 0)
            Me.treeViewAdv1.Name = "treeViewAdv1"
            TreeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv1.EnsureDefaultOptionedChild = True
            TreeNodeAdv1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            TreeNodeAdv1.Tag = "Continent"
            TreeNodeAdv1.Text = "North America"
            TreeNodeAdv1.TextColor = System.Drawing.Color.White
            TreeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv2.EnsureDefaultOptionedChild = True
            TreeNodeAdv2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            TreeNodeAdv2.Tag = "Continent"
            TreeNodeAdv2.Text = "South America"
            TreeNodeAdv2.TextColor = System.Drawing.Color.White
            TreeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv3.EnsureDefaultOptionedChild = True
            TreeNodeAdv3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            TreeNodeAdv3.Tag = "Continent"
            TreeNodeAdv3.Text = "Antarctica"
            TreeNodeAdv3.TextColor = System.Drawing.Color.White
            TreeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv4.EnsureDefaultOptionedChild = True
            TreeNodeAdv4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            TreeNodeAdv4.Tag = "Continent"
            TreeNodeAdv4.Text = "Europe"
            TreeNodeAdv4.TextColor = System.Drawing.Color.White
            TreeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv5.EnsureDefaultOptionedChild = True
            TreeNodeAdv5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            TreeNodeAdv5.Tag = "Continent"
            TreeNodeAdv5.Text = "Asia"
            TreeNodeAdv5.TextColor = System.Drawing.Color.White
            TreeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv6.EnsureDefaultOptionedChild = True
            TreeNodeAdv6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            TreeNodeAdv6.Tag = "Continent"
            TreeNodeAdv6.Text = "Africa"
            TreeNodeAdv6.TextColor = System.Drawing.Color.White
            TreeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv7.EnsureDefaultOptionedChild = True
            TreeNodeAdv7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            TreeNodeAdv7.Tag = "Continent"
            TreeNodeAdv7.Text = "Australia"
            TreeNodeAdv7.TextColor = System.Drawing.Color.White
            TreeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv8.EnsureDefaultOptionedChild = True
            TreeNodeAdv8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            TreeNodeAdv8.Text = "Australia"
            TreeNodeAdv8.TextColor = System.Drawing.Color.LightSkyBlue
            TreeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv9.EnsureDefaultOptionedChild = True
            TreeNodeAdv9.Text = "Austria"
            TreeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv10.EnsureDefaultOptionedChild = True
            TreeNodeAdv10.Text = "Belgium"
            TreeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv11.EnsureDefaultOptionedChild = True
            TreeNodeAdv11.Text = "Brazil"
            TreeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv12.EnsureDefaultOptionedChild = True
            TreeNodeAdv12.Text = "Canada"
            TreeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv13.EnsureDefaultOptionedChild = True
            TreeNodeAdv13.Text = "Denmark"
            TreeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv14.EnsureDefaultOptionedChild = True
            TreeNodeAdv14.Text = "Finland"
            TreeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv15.EnsureDefaultOptionedChild = True
            TreeNodeAdv15.Text = "France"
            TreeNodeAdv16.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv16.EnsureDefaultOptionedChild = True
            TreeNodeAdv16.Text = "Germany"
            TreeNodeAdv17.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv17.EnsureDefaultOptionedChild = True
            TreeNodeAdv17.Text = "Ireland"
            TreeNodeAdv18.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv18.EnsureDefaultOptionedChild = True
            TreeNodeAdv18.Text = "Italy"
            TreeNodeAdv19.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv19.EnsureDefaultOptionedChild = True
            TreeNodeAdv19.Text = "Japan"
            TreeNodeAdv20.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv20.EnsureDefaultOptionedChild = True
            TreeNodeAdv20.Text = "Mexico"
            TreeNodeAdv21.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv21.EnsureDefaultOptionedChild = True
            TreeNodeAdv21.Text = "Netherlands"
            TreeNodeAdv22.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv22.EnsureDefaultOptionedChild = True
            TreeNodeAdv22.Text = "Norway"
            TreeNodeAdv23.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv23.EnsureDefaultOptionedChild = True
            TreeNodeAdv23.Text = "New Zealand"
            TreeNodeAdv24.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv24.EnsureDefaultOptionedChild = True
            TreeNodeAdv24.Text = "Portugal"
            TreeNodeAdv25.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv25.EnsureDefaultOptionedChild = True
            TreeNodeAdv25.Text = "Russia"
            TreeNodeAdv26.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv26.EnsureDefaultOptionedChild = True
            TreeNodeAdv26.Text = "Spain"
            TreeNodeAdv27.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv27.EnsureDefaultOptionedChild = True
            TreeNodeAdv27.Text = "Sweden"
            TreeNodeAdv28.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv28.EnsureDefaultOptionedChild = True
            TreeNodeAdv28.Text = "United Kingdom"
            TreeNodeAdv29.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv29.EnsureDefaultOptionedChild = True
            TreeNodeAdv29.Text = "United States"
            Me.treeViewAdv1.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv1, TreeNodeAdv2, TreeNodeAdv3, TreeNodeAdv4, TreeNodeAdv5, TreeNodeAdv6, TreeNodeAdv7, TreeNodeAdv8, TreeNodeAdv9, TreeNodeAdv10, TreeNodeAdv11, TreeNodeAdv12, TreeNodeAdv13, TreeNodeAdv14, TreeNodeAdv15, TreeNodeAdv16, TreeNodeAdv17, TreeNodeAdv18, TreeNodeAdv19, TreeNodeAdv20, TreeNodeAdv21, TreeNodeAdv22, TreeNodeAdv23, TreeNodeAdv24, TreeNodeAdv25, TreeNodeAdv26, TreeNodeAdv27, TreeNodeAdv28, TreeNodeAdv29})
            Me.treeViewAdv1.PathSeparator = "/"
            Me.treeViewAdv1.Size = New System.Drawing.Size(224, 434)
            Me.treeViewAdv1.TabIndex = 0
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
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.listView1)
            Me.panel1.Controls.Add(Me.CheckBoxAdv1)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.HighLighterColor)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.label20)
            Me.panel1.Controls.Add(Me.label19)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(224, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(228, 434)
            Me.panel1.TabIndex = 1
            '
            'label4
            '
            Me.label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label4.Location = New System.Drawing.Point(10, 176)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(185, 1)
            Me.label4.TabIndex = 44
            '
            'label3
            '
            Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label3.Image = CType(resources.GetObject("label3.Image"), System.Drawing.Image)
            Me.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label3.Location = New System.Drawing.Point(5, 153)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(190, 23)
            Me.label3.TabIndex = 43
            Me.label3.Text = "       Drag And Drop Events"
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'HighLighterColor
            '
            Me.HighLighterColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.HighLighterColor.Buttons.Add(Me.buttonEditChildButton1)
            Me.HighLighterColor.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.HighLighterColor.Controls.Add(Me.buttonEditChildButton1)
            Me.HighLighterColor.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.HighLighterColor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.HighLighterColor.Location = New System.Drawing.Point(114, 65)
            Me.HighLighterColor.Name = "HighLighterColor"
            Me.HighLighterColor.Size = New System.Drawing.Size(102, 26)
            Me.HighLighterColor.TabIndex = 39
            '
            'buttonEditChildButton1
            '
            Me.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.buttonEditChildButton1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonEditChildButton1.Image = Nothing
            Me.buttonEditChildButton1.Name = "buttonEditChildButton1"
            Me.buttonEditChildButton1.PreferredWidth = 20
            Me.buttonEditChildButton1.TabIndex = 1
            Me.buttonEditChildButton1.Text = "..."
            Me.buttonEditChildButton1.UseVisualStyleBackColor = True
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label1.Location = New System.Drawing.Point(5, 65)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(105, 14)
            Me.label1.TabIndex = 38
            Me.label1.Text = "DragHighlighterColor"
            '
            'label20
            '
            Me.label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label20.Location = New System.Drawing.Point(10, 31)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(185, 1)
            Me.label20.TabIndex = 25
            '
            'label19
            '
            Me.label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label19.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label19.Image = CType(resources.GetObject("label19.Image"), System.Drawing.Image)
            Me.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label19.Location = New System.Drawing.Point(10, 8)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(203, 23)
            Me.label19.TabIndex = 24
            Me.label19.Text = "       Drag And Drop Features  "
            Me.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'scrollersFrame1
            '
            Me.scrollersFrame1.EnableDelayedScrollBarUpdate = True
            Me.scrollersFrame1.HorizontalSmallChange = 7
            Me.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.[Auto]
            Me.scrollersFrame1.VerticallSmallChange = 13
            Me.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2007
            '
            'CheckBoxAdv1
            '
            Me.CheckBoxAdv1.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.CheckBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBoxAdv1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CheckBoxAdv1.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.CheckBoxAdv1.GradientStart = System.Drawing.SystemColors.Control
            Me.CheckBoxAdv1.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.CheckBoxAdv1.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.CheckBoxAdv1.Location = New System.Drawing.Point(13, 107)
            Me.CheckBoxAdv1.Name = "CheckBoxAdv1"
            Me.CheckBoxAdv1.ShadowColor = System.Drawing.Color.Black
            Me.CheckBoxAdv1.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.CheckBoxAdv1.Size = New System.Drawing.Size(182, 25)
            Me.CheckBoxAdv1.TabIndex = 45
            Me.CheckBoxAdv1.Text = "ShowDragNodeCue"
            Me.CheckBoxAdv1.ThemesEnabled = True
            '
            'listView1
            '
            Me.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1})
            Me.listView1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.listView1.FullRowSelect = True
            Me.listView1.GridLines = True
            Me.listView1.Location = New System.Drawing.Point(0, 193)
            Me.listView1.MultiSelect = False
            Me.listView1.Name = "listView1"
            Me.listView1.Size = New System.Drawing.Size(226, 239)
            Me.listView1.TabIndex = 46
            Me.listView1.UseCompatibleStateImageBehavior = False
            Me.listView1.View = System.Windows.Forms.View.Details
            '
            'columnHeader1
            '
            Me.columnHeader1.Text = "Events"
            Me.columnHeader1.Width = 201
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(452, 434)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.treeViewAdv1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimumSize = New System.Drawing.Size(50, 300)
            Me.Name = "Form1"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Drag Drop"
            CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.HighLighterColor, System.ComponentModel.ISupportInitialize).EndInit()
            Me.HighLighterColor.ResumeLayout(False)
            Me.HighLighterColor.PerformLayout()
            CType(Me.CheckBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Main Function Definition"
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub
#End Region

#Region "DRAG_DROP_UTILS"
        Private Function IsContinentNode(ByVal node As TreeNodeAdv) As Boolean
            If node.Tag Is Nothing OrElse ("Continent").CompareTo(node.Tag.ToString()) <> 0 Then
                Return False
            Else
                Return True
            End If
        End Function
#End Region ' DRAG_DROP_UTILS

#Region "SOURCE_DRAGDROP_LOGIC"

        Private Sub treeViewAdv_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles treeViewAdv1.ItemDrag
            Dim treeViewAdv As TreeViewAdv = TryCast(sender, TreeViewAdv)

            ' The TreeViewAdv always provides an array of selected nodes.
            Dim nodes As TreeNodeAdv() = TryCast(e.Item, TreeNodeAdv())

            ' Let us get only the first selected node.
            Dim node As TreeNodeAdv = nodes(0)

            ' Drag only "country" nodes (non-continent nodes)
            If (Not IsContinentNode(node)) Then
                ' Only allow move
                Dim result As DragDropEffects = treeViewAdv.DoDragDrop(node, DragDropEffects.Move)
            End If
            listViewItem1 = New System.Windows.Forms.ListViewItem(New String() {"ItemDrag", e.Item.ToString()})
            Me.ListView1.Items.Add(listViewItem1)

        End Sub

        Private Sub treeViewAdv_QueryContinueDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.QueryContinueDragEventArgs) Handles treeViewAdv1.QueryContinueDrag
            ' Cancel draggin when Escape was pressed.
            If e.EscapePressed Then
                e.Action = DragAction.Cancel
            End If

        End Sub
#End Region ' SOURCE_DRAGDROP_LOGIC

#Region "DEST_DRAGDROP_LOGIC"

        ' Helps keep track of the node that is being dragged.
        Private currentSourceNode As TreeNodeAdv

        Private Sub treeViewAdv_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles treeViewAdv1.DragOver
            ' Determine drag effects
            Dim droppable As Boolean = True
            Dim destinationNode As TreeNodeAdv = Nothing
            Dim treeView As TreeViewAdv = TryCast(sender, TreeViewAdv)
            Dim ptInTree As Point = treeView.PointToClient(New Point(e.X, e.Y))
            Me.currentSourceNode = Nothing

            ' Looking for a single tree node.
            If e.Data.GetDataPresent(GetType(TreeNodeAdv)) Then
                ' Get the destination and source node.
                destinationNode = treeView.GetNodeAtPoint(ptInTree)
                Dim sourceNode As TreeNodeAdv = CType(e.Data.GetData(GetType(TreeNodeAdv)), TreeNodeAdv)
                ' Cache this for use later in the TreeDragDrop_QueryAllowedPositionsForNode event handler.
                Me.currentSourceNode = sourceNode
                droppable = Me.CanDrop(sourceNode, destinationNode)
            Else
                droppable = False
            End If

            If droppable Then
                ' If Moving is allowed:
                e.Effect = DragDropEffects.Move
            Else
                e.Effect = DragDropEffects.None
            End If

            ' Let the highlight tracker keep track of the current highlight node.
            Me.treeViewDragHighlightTracker.SetHighlightNode(destinationNode, ptInTree)
            listViewItem1 = New System.Windows.Forms.ListViewItem(New String() {"DragOver", e.ToString()})
            Me.ListView1.Items.Add(listViewItem1)


        End Sub
        Private Function CanDrop(ByVal sourceNode As TreeNodeAdv, ByVal destinationNode As TreeNodeAdv) As Boolean
            ' Cannot drop into empty area
            ' Cannot drop over the source's parent
            ' Or over itself
            If Not sourceNode.TreeView Is Me.treeViewAdv1 OrElse destinationNode Is Nothing OrElse destinationNode Is sourceNode.Parent OrElse destinationNode Is sourceNode Then
                Return False
            Else
                Return True
            End If
        End Function
        Private Sub treeViewAdv_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles treeViewAdv1.DragLeave
            ' Let the highlight tracker keep track of the current highlight node.
            Me.treeViewDragHighlightTracker.ClearHighlightNode()
            listViewItem1 = New System.Windows.Forms.ListViewItem(New String() {"DragLeave", e.ToString()})
            Me.ListView1.Items.Add(listViewItem1)

        End Sub

        Private Sub treeViewAdv_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles treeViewAdv1.DragDrop
            Dim treeView As TreeViewAdv = TryCast(sender, TreeViewAdv)

            ' Get the destination and source node.

            Dim sourceNode As TreeNodeAdv = CType(e.Data.GetData(GetType(TreeNodeAdv)), TreeNodeAdv)

            Dim destinationNode As TreeNodeAdv = Me.treeViewDragHighlightTracker.HighlightNode
            Dim dropPosition As TreeViewDropPositions = Me.treeViewDragHighlightTracker.DropPosition
            ' Clear the highlight info in the tracker.
            Me.treeViewDragHighlightTracker.ClearHighlightNode()

            Me.currentSourceNode = Nothing

            ' Move the source node based on the tracked info.
            If Not destinationNode Is Nothing Then
                Select Case dropPosition
                    Case TreeViewDropPositions.AboveNode
                        sourceNode.Move(destinationNode, NodePositions.Previous)
                    Case TreeViewDropPositions.BelowNode
                        sourceNode.Move(destinationNode, NodePositions.Next)
                    Case TreeViewDropPositions.OnNode
                        sourceNode.Move(destinationNode.Nodes)
                        destinationNode.Expand()
                End Select
            End If

            treeView.SelectedNode = sourceNode
            listViewItem1 = New System.Windows.Forms.ListViewItem(New String() {"DragDrop", e.ToString()})
            Me.ListView1.Items.Add(listViewItem1)


        End Sub

#End Region ' DEST_DRAGDROP_LOGIC

#Region "Delegate Defintion"

        Private Sub treeViewDragHighlightTracker_QueryDragInsertInfo(ByVal sender As Object, ByVal args As QueryDragInsertInfoEventArgs)
            args.DragInsertColor = highlighter
        End Sub

        ' Specifiy the allowed drop positions for the specified highlight node.
        Private Sub TreeDragDrop_QueryAllowedPositionsForNode(ByVal sender As Object, ByVal e As QueryAllowedPositionsEventArgs)
            If (Not Me.IsContinentNode(e.HighlightNode)) Then
                ' If this a country node, only allow drop above or below it.

                If Not e.HighlightNode Is Me.currentSourceNode Then
                    e.AllowedPositions = TreeViewDropPositions.AboveNode Or TreeViewDropPositions.BelowNode
                Else
                    ' Cannot drop beside itself
                    e.AllowedPositions = TreeViewDropPositions.None
                End If

                Me.treeViewDragHighlightTracker.EdgeSensitivityOnTop = CInt(e.HighlightNode.Bounds.Height / 2)

                e.ShowSelectionHighlight = False
            Else
                ' If this is a continent node allow all drop positions (default behavior).
                Me.treeViewDragHighlightTracker.EdgeSensitivityOnTop = CInt(e.HighlightNode.Bounds.Height / 4)

                ' Only if the source node is droppable
                ' and droppable ON the node (not beside it)
                e.ShowSelectionHighlight = Me.CanDrop(Me.currentSourceNode, e.HighlightNode) AndAlso e.NewDropPosition = TreeViewDropPositions.OnNode
            End If

        End Sub
#End Region

#Region "HighLighterColor"
        Private highlighter As Color = Color.Red
        Private Sub HighLighterColor_ButtonClicked(ByVal sender As Object, ByVal args As ButtonClickedEventArgs) Handles HighLighterColor.ButtonClicked
            colorDialog1.ShowDialog()
            highlighter = colorDialog1.Color
            Me.HighLighterColor.BackColor = colorDialog1.Color
        End Sub
#End Region

#Region "ShowDragNodeCue"
        Private Sub CheckBoxAdv1_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxAdv1.CheckStateChanged
            Me.treeViewAdv1.ShowDragNodeCue = Me.CheckBoxAdv1.Checked
        End Sub

#End Region

        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.treeViewAdv1.Office2007ScrollBars = True
            Me.scrollersFrame1.AttachedTo = Me.ListView1
            Me.HighLighterColor.TextBox.BackColor = Color.Red
        End Sub

       
    End Class
#End Region
End Namespace
