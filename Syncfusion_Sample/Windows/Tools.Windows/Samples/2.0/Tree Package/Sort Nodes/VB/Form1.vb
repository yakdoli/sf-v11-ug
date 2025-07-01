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
Imports System.IO
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Drawing

Namespace TreeViewAdvDemo
#Region "Class Form1 Description"
    Public Class Form1 : Inherits System.Windows.Forms.Form

#Region "Variable Declaration"
        Private WithEvents treeViewAdv2 As Syncfusion.Windows.Forms.Tools.TreeViewAdv
        Private imageList1 As System.Windows.Forms.ImageList
        Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
        Private comboBox2 As System.Windows.Forms.ComboBox
        Private label2 As System.Windows.Forms.Label
        Private label1 As System.Windows.Forms.Label
        Private comboBox1 As System.Windows.Forms.ComboBox
        Private WithEvents button1 As System.Windows.Forms.Button
        Private components As System.ComponentModel.IContainer
#End Region

#Region "Form Constructor Initialization and Disposing"

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
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
#End Region

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim TreeNodeAdvStyleInfo1 As Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo()
            Dim TreeNodeAdv1 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
            Me.treeViewAdv2 = New Syncfusion.Windows.Forms.Tools.TreeViewAdv()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
            Me.comboBox2 = New System.Windows.Forms.ComboBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.comboBox1 = New System.Windows.Forms.ComboBox()
            Me.button1 = New System.Windows.Forms.Button()
            Me.Splitter1 = New System.Windows.Forms.Splitter()
            CType(Me.treeViewAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'treeViewAdv2
            '
            Me.treeViewAdv2.ActiveNode = Nothing
            Me.treeViewAdv2.AddSeparatorAtEnd = True
            Me.treeViewAdv2.AllowDrop = True
            Me.treeViewAdv2.BackColor = System.Drawing.Color.White
            Me.treeViewAdv2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, System.Drawing.Color.FromArgb(CType(237, Byte), CType(240, Byte), CType(246, Byte)), System.Drawing.Color.FromArgb(CType(196, Byte), CType(214, Byte), CType(233, Byte)))
            TreeNodeAdvStyleInfo1.CheckColor = System.Drawing.SystemColors.ControlText
            TreeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = True
            TreeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.SystemColors.ControlDark
            TreeNodeAdvStyleInfo1.ShowCheckBox = True
            TreeNodeAdvStyleInfo1.ShowOptionButton = True
            TreeNodeAdvStyleInfo1.ThemesEnabled = True
            Me.treeViewAdv2.BaseStylePairs.AddRange(New Syncfusion.Windows.Forms.Tools.StyleNamePair() {New Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", TreeNodeAdvStyleInfo1)})
            Me.treeViewAdv2.Border3DStyle = System.Windows.Forms.Border3DStyle.Bump
            Me.treeViewAdv2.Dock = System.Windows.Forms.DockStyle.Left
            Me.treeViewAdv2.Font = New System.Drawing.Font("Verdana", 8.0!)
            '
            'treeViewAdv2.HelpTextControl
            '
            Me.treeViewAdv2.HelpTextControl.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
            Me.treeViewAdv2.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.treeViewAdv2.HelpTextControl.Location = New System.Drawing.Point(732, 0)
            Me.treeViewAdv2.HelpTextControl.Name = "helpText"
            Me.treeViewAdv2.HelpTextControl.Size = New System.Drawing.Size(50, 17)
            Me.treeViewAdv2.HelpTextControl.TabIndex = 0
            Me.treeViewAdv2.HelpTextControl.Text = "help text"
            Me.treeViewAdv2.IgnoreThemeBackground = True
            Me.treeViewAdv2.Indent = 20
            Me.treeViewAdv2.LineColor = System.Drawing.Color.Transparent
            Me.treeViewAdv2.LoadOnDemand = True
            Me.treeViewAdv2.Name = "treeViewAdv2"
            TreeNodeAdv1.ChildStyle.CheckColor = System.Drawing.SystemColors.ControlText
            TreeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv1.ChildStyle.IntermediateCheckColor = System.Drawing.SystemColors.ControlDark
            TreeNodeAdv1.EnsureDefaultOptionedChild = True
            TreeNodeAdv1.ShowPlusOnExpand = False
            TreeNodeAdv1.Text = "c:"
            Me.treeViewAdv2.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv1})
            Me.treeViewAdv2.OwnerDrawNodes = True
            Me.treeViewAdv2.PathSeparator = "/"
            Me.treeViewAdv2.ShowCheckBoxes = True
            Me.treeViewAdv2.ShowOptionButtons = True
            Me.treeViewAdv2.Size = New System.Drawing.Size(208, 526)
            Me.treeViewAdv2.StateImageList = Me.imageList1
            Me.treeViewAdv2.TabIndex = 2
            Me.treeViewAdv2.ThemesEnabled = True
            '
            'treeViewAdv2.ToolTipControl
            '
            Me.treeViewAdv2.ToolTipControl.BackColor = System.Drawing.SystemColors.Info
            Me.treeViewAdv2.ToolTipControl.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
            Me.treeViewAdv2.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.treeViewAdv2.ToolTipControl.Location = New System.Drawing.Point(642, 0)
            Me.treeViewAdv2.ToolTipControl.Name = "toolTip"
            Me.treeViewAdv2.ToolTipControl.Size = New System.Drawing.Size(41, 17)
            Me.treeViewAdv2.ToolTipControl.TabIndex = 1
            Me.treeViewAdv2.ToolTipControl.Text = "toolTip"
            '
            'imageList1
            '
            Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
            Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
            Me.imageList1.TransparentColor = System.Drawing.Color.White
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, System.Drawing.Color.FromArgb(CType(237, Byte), CType(240, Byte), CType(246, Byte)), System.Drawing.Color.FromArgb(CType(196, Byte), CType(214, Byte), CType(233, Byte)))
            Me.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched
            Me.gradientPanel1.BorderColor = System.Drawing.Color.Black
            Me.gradientPanel1.BorderSides = System.Windows.Forms.Border3DSide.Left
            Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.gradientPanel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.comboBox2, Me.label2, Me.label1, Me.comboBox1, Me.button1})
            Me.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gradientPanel1.Location = New System.Drawing.Point(208, 0)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(242, 526)
            Me.gradientPanel1.TabIndex = 3
            '
            'comboBox2
            '
            Me.comboBox2.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(187, Byte), CType(111, Byte))
            Me.comboBox2.Items.AddRange(New Object() {"Text", "CheckBox", "Tag"})
            Me.comboBox2.Location = New System.Drawing.Point(8, 136)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(216, 21)
            Me.comboBox2.TabIndex = 12
            Me.comboBox2.Text = "Text"
            '
            'label2
            '
            Me.label2.BackColor = System.Drawing.Color.Transparent
            Me.label2.Location = New System.Drawing.Point(8, 112)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(100, 16)
            Me.label2.TabIndex = 11
            Me.label2.Text = "Sort Type"
            '
            'label1
            '
            Me.label1.BackColor = System.Drawing.Color.Transparent
            Me.label1.Location = New System.Drawing.Point(8, 56)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(100, 16)
            Me.label1.TabIndex = 10
            Me.label1.Text = "Sort Order"
            '
            'comboBox1
            '
            Me.comboBox1.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(187, Byte), CType(111, Byte))
            Me.comboBox1.Items.AddRange(New Object() {"None", "Ascending", "Descending"})
            Me.comboBox1.Location = New System.Drawing.Point(8, 80)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(216, 21)
            Me.comboBox1.TabIndex = 9
            Me.comboBox1.Text = "None"
            '
            'button1
            '
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button1.Location = New System.Drawing.Point(48, 16)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(136, 23)
            Me.button1.TabIndex = 8
            Me.button1.Text = "Sort selected node"
            '
            'Splitter1
            '
            Me.Splitter1.Location = New System.Drawing.Point(208, 0)
            Me.Splitter1.Name = "Splitter1"
            Me.Splitter1.Size = New System.Drawing.Size(6, 526)
            Me.Splitter1.TabIndex = 4
            Me.Splitter1.TabStop = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.AutoScroll = True
            Me.ClientSize = New System.Drawing.Size(450, 526)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Splitter1, Me.gradientPanel1, Me.treeViewAdv2})
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Sort Nodes"
            CType(Me.treeViewAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
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

#Region "TreeViewAdv Event Handler"

#Region "Load the child nodes "

        'This Event will be fired  before a node is expanded
        Private Sub treeViewAdv2_BeforeExpand_1(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.TreeViewAdvCancelableNodeEventArgs) Handles treeViewAdv2.BeforeExpand

            Try

                'Checking Whether the Node has been  expanded atleast once
                If e.Node.ExpandedOnce Then
                    Return
                End If

                'Get the Path of the node and AddSeparatorAtEnd Property set to true
                Dim path As String = e.Node.GetPath("\")

                'Get an Array of Directories from the current directory path
                Dim dirs As ArrayList = New ArrayList(Directory.GetDirectories(path))

                'Add the Directories as a node in TreeViewAdv
                Dim i As Integer = 0
                'ORIGINAL LINE: for(int i=0;i<dirs.Count;i += 1)
                'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
                Do While i < dirs.Count
                    Dim dir As String = CStr(dirs(i))
                    Dim lastIndex As Integer = dir.LastIndexOf("\") + 1
                    Dim node As TreeNodeAdv = New TreeNodeAdv(dir.Substring(lastIndex))
                    ' Make the node's Tag same as Text for demo purposes.
                    node.Tag = node.Text
                    e.Node.Nodes.Add(node)
                    i += 1
                Loop

            Catch ex As Exception
            End Try
        End Sub

#End Region

        Private br As BrushInfo = New BrushInfo(GradientStyle.PathEllipse, Color.Beige, Color.Beige)

        'This Event will be Fired before a node is being painted when the OwnerDrawNodes property is set to true. 
        Private Sub treeViewAdv2_NodePaint(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.TreeNodeAdvPaintEventArgs) Handles treeViewAdv2.BeforeNodePaint

            'Draw the BackGround color for the Selected node
            If e.Selected Then
                BrushPaint.FillRectangle(e.Graphics, e.Bounds, br)
                e.ForeColor = SystemColors.WindowText
            End If
        End Sub

#End Region

#Region "Button Event Handler"
        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click

            'Checking the Selected Nodes is null
            If Me.treeViewAdv2.SelectedNode Is Nothing Then
                Return
            End If

            If treeViewAdv2.SelectedNode.Expanded = False OrElse (Not treeViewAdv2.SelectedNode.HasChildren) Then
                'Display the Message Box when the Node has no children
                MessageBox.Show("The selected node isn`t expanded or hasn`t got child nodes to sort")
            End If

            Select Case Me.comboBox1.SelectedIndex
                Case 0
                    treeViewAdv2.SelectedNode.SortOrder = SortOrder.None
                Case 1
                    'Sorting the Nodes  in Ascending order
                    treeViewAdv2.SelectedNode.SortOrder = SortOrder.Ascending
                Case 2
                    'Sorting the Nodes in Descending order
                    treeViewAdv2.SelectedNode.SortOrder = SortOrder.Descending
            End Select

            Select Case Me.comboBox2.SelectedIndex
                Case 0
                    'Sort the node based on the node Text
                    treeViewAdv2.SelectedNode.SortType = TreeNodeAdvSortType.Text
                Case 1
                    'Sort the node based on the value of the CheckBox
                    treeViewAdv2.SelectedNode.SortType = TreeNodeAdvSortType.CheckBox
                Case 2
                    'Sort the nodes based on the node Tag
                    treeViewAdv2.SelectedNode.SortType = TreeNodeAdvSortType.Tag
            End Select

            treeViewAdv2.SelectedNode.Sort()
        End Sub
#End Region

    End Class
#End Region
End Namespace
