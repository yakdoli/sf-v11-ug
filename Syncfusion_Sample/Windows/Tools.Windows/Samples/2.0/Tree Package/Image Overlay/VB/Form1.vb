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


#Region "Class Form1 Description"

Public Class Form1 : Inherits System.Windows.Forms.Form

#Region "Variable Declaration"
    Private WithEvents treeViewAdv1 As Syncfusion.Windows.Forms.Tools.TreeViewAdv
    Private imageList1 As System.Windows.Forms.ImageList
    Private imageList2 As System.Windows.Forms.ImageList
    Private components As System.ComponentModel.IContainer
#End Region

#Region "Form1 Constructor Initialization and Disposing"
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
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNodeAdvStyleInfo1 As Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo()
        Dim TreeNodeAdv1 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv2 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv3 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv4 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv5 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv6 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv7 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv8 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv9 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv10 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv11 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv12 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv13 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv14 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv15 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv16 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv17 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim TreeNodeAdv18 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.treeViewAdv1 = New Syncfusion.Windows.Forms.Tools.TreeViewAdv()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'treeViewAdv1
        '
        Me.treeViewAdv1.ActiveNode = Nothing
        Me.treeViewAdv1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(58, Byte), CType(134, Byte), CType(126, Byte)))
        TreeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = True
        Me.treeViewAdv1.BaseStylePairs.AddRange(New Syncfusion.Windows.Forms.Tools.StyleNamePair() {New Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", TreeNodeAdvStyleInfo1)})
        Me.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeViewAdv1.ForeColor = System.Drawing.SystemColors.ControlLight
        '
        'treeViewAdv1.HelpTextControl
        '
        Me.treeViewAdv1.HelpTextControl.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
        Me.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.treeViewAdv1.HelpTextControl.Location = New System.Drawing.Point(732, 0)
        Me.treeViewAdv1.HelpTextControl.Name = "helpText"
        Me.treeViewAdv1.HelpTextControl.Size = New System.Drawing.Size(50, 17)
        Me.treeViewAdv1.HelpTextControl.TabIndex = 0
        Me.treeViewAdv1.HelpTextControl.Text = "help text"
        Me.treeViewAdv1.LeftImageList = Me.imageList1
        Me.treeViewAdv1.Name = "treeViewAdv1"
        TreeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv1.EnsureDefaultOptionedChild = True
        TreeNodeAdv1.Expanded = True
        TreeNodeAdv1.LeftImageIndices = New Integer() {1}
        TreeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv2.EnsureDefaultOptionedChild = True
        TreeNodeAdv2.Expanded = True
        TreeNodeAdv2.LeftImageIndices = New Integer() {1}
        TreeNodeAdv2.Optioned = True
        TreeNodeAdv2.ShowPlusOnExpand = False
        TreeNodeAdv2.Text = "India"
        TreeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv3.EnsureDefaultOptionedChild = True
        TreeNodeAdv3.LeftImageIndices = New Integer() {2}
        TreeNodeAdv3.ShowPlusOnExpand = False
        TreeNodeAdv3.Text = "China"
        TreeNodeAdv1.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv2, TreeNodeAdv3})
        TreeNodeAdv1.ShowPlusOnExpand = False
        TreeNodeAdv1.Text = "Asia"
        TreeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv4.EnsureDefaultOptionedChild = True
        TreeNodeAdv4.Expanded = True
        TreeNodeAdv4.LeftImageIndices = New Integer() {7}
        TreeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv5.EnsureDefaultOptionedChild = True
        TreeNodeAdv5.Expanded = True
        TreeNodeAdv5.LeftImageIndices = New Integer() {3}
        TreeNodeAdv5.Optioned = True
        TreeNodeAdv5.ShowPlusOnExpand = False
        TreeNodeAdv5.Text = "Britain"
        TreeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv6.EnsureDefaultOptionedChild = True
        TreeNodeAdv6.LeftImageIndices = New Integer() {4}
        TreeNodeAdv6.ShowPlusOnExpand = False
        TreeNodeAdv6.Text = "France"
        TreeNodeAdv4.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv5, TreeNodeAdv6})
        TreeNodeAdv4.ShowPlusOnExpand = False
        TreeNodeAdv4.Text = "Europe"
        TreeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv7.EnsureDefaultOptionedChild = True
        TreeNodeAdv7.Expanded = True
        TreeNodeAdv7.LeftImageIndices = New Integer() {6}
        TreeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv8.EnsureDefaultOptionedChild = True
        TreeNodeAdv8.Expanded = True
        TreeNodeAdv8.LeftImageIndices = New Integer() {5}
        TreeNodeAdv8.Optioned = True
        TreeNodeAdv8.ShowPlusOnExpand = False
        TreeNodeAdv8.Text = "United States"
        TreeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv9.EnsureDefaultOptionedChild = True
        TreeNodeAdv9.LeftImageIndices = New Integer() {6}
        TreeNodeAdv9.ShowPlusOnExpand = False
        TreeNodeAdv9.Text = "Canada"
        TreeNodeAdv7.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv8, TreeNodeAdv9})
        TreeNodeAdv7.ShowPlusOnExpand = False
        TreeNodeAdv7.Text = "North America"
        TreeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv10.EnsureDefaultOptionedChild = True
        TreeNodeAdv10.Expanded = True
        TreeNodeAdv10.LeftImageIndices = New Integer() {9}
        TreeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv11.EnsureDefaultOptionedChild = True
        TreeNodeAdv11.LeftImageIndices = New Integer() {10}
        TreeNodeAdv11.Optioned = True
        TreeNodeAdv11.RightImageIndices = New Integer() {0}
        TreeNodeAdv11.ShowPlusOnExpand = False
        TreeNodeAdv11.Text = "Australia"
        TreeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv12.EnsureDefaultOptionedChild = True
        TreeNodeAdv12.LeftImageIndices = New Integer() {11}
        TreeNodeAdv12.RightImageIndices = New Integer() {1}
        TreeNodeAdv12.ShowPlusOnExpand = False
        TreeNodeAdv12.Text = "New Zealand"
        TreeNodeAdv10.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv11, TreeNodeAdv12})
        TreeNodeAdv10.RightImageIndices = New Integer() {0}
        TreeNodeAdv10.ShowPlusOnExpand = False
        TreeNodeAdv10.Text = "Australia"
        TreeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv13.EnsureDefaultOptionedChild = True
        TreeNodeAdv13.Expanded = True
        TreeNodeAdv13.LeftImageIndices = New Integer() {12}
        TreeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv14.EnsureDefaultOptionedChild = True
        TreeNodeAdv14.LeftImageIndices = New Integer() {13}
        TreeNodeAdv14.Optioned = True
        TreeNodeAdv14.RightImageIndices = New Integer() {2}
        TreeNodeAdv14.ShowPlusOnExpand = False
        TreeNodeAdv14.Text = "Brazil"
        TreeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv15.EnsureDefaultOptionedChild = True
        TreeNodeAdv15.LeftImageIndices = New Integer() {14}
        TreeNodeAdv15.RightImageIndices = New Integer() {3}
        TreeNodeAdv15.ShowPlusOnExpand = False
        TreeNodeAdv15.Text = "Argentina"
        TreeNodeAdv13.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv14, TreeNodeAdv15})
        TreeNodeAdv13.RightImageIndices = New Integer() {6}
        TreeNodeAdv13.ShowPlusOnExpand = False
        TreeNodeAdv13.Text = "South America"
        TreeNodeAdv16.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv16.EnsureDefaultOptionedChild = True
        TreeNodeAdv16.Expanded = True
        TreeNodeAdv16.LeftImageIndices = New Integer() {15}
        TreeNodeAdv17.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv17.EnsureDefaultOptionedChild = True
        TreeNodeAdv17.LeftImageIndices = New Integer() {16}
        TreeNodeAdv17.Optioned = True
        TreeNodeAdv17.RightImageIndices = New Integer() {4}
        TreeNodeAdv17.ShowPlusOnExpand = False
        TreeNodeAdv17.Text = "South Africa"
        TreeNodeAdv18.ChildStyle.EnsureDefaultOptionedChild = True
        TreeNodeAdv18.EnsureDefaultOptionedChild = True
        TreeNodeAdv18.LeftImageIndices = New Integer() {17}
        TreeNodeAdv18.RightImageIndices = New Integer() {5}
        TreeNodeAdv18.ShowPlusOnExpand = False
        TreeNodeAdv18.Text = "Zimbabwe"
        TreeNodeAdv16.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv17, TreeNodeAdv18})
        TreeNodeAdv16.RightImageIndices = New Integer() {7}
        TreeNodeAdv16.ShowPlusOnExpand = False
        TreeNodeAdv16.Text = "Africa"
        Me.treeViewAdv1.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv1, TreeNodeAdv4, TreeNodeAdv7, TreeNodeAdv10, TreeNodeAdv13, TreeNodeAdv16})
        Me.treeViewAdv1.OwnerDrawNodes = True
        Me.treeViewAdv1.RightImageList = Me.imageList2
        Me.treeViewAdv1.ShowLines = False
        Me.treeViewAdv1.Size = New System.Drawing.Size(216, 333)
        Me.treeViewAdv1.TabIndex = 0
        Me.treeViewAdv1.Text = "treeViewAdv1"
        '
        'treeViewAdv1.ToolTipControl
        '
        Me.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info
        Me.treeViewAdv1.ToolTipControl.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
        Me.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.treeViewAdv1.ToolTipControl.Location = New System.Drawing.Point(642, 0)
        Me.treeViewAdv1.ToolTipControl.Name = "toolTip"
        Me.treeViewAdv1.ToolTipControl.Size = New System.Drawing.Size(41, 17)
        Me.treeViewAdv1.ToolTipControl.TabIndex = 1
        Me.treeViewAdv1.ToolTipControl.Text = "toolTip"
        '
        'imageList1
        '
        Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'imageList2
        '
        Me.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(216, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.treeViewAdv1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Image Overlay"
        CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).EndInit()
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

    'This Event will be Fired after a node is being painted when the OwnerDrawNodes property is set to true.
    Private Sub treeViewAdv1_AfterNodePaint(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.TreeNodeAdvPaintEventArgs) Handles treeViewAdv1.AfterNodePaint
        'Getting the  Mouse Current Position
        Dim pt As Point = Me.treeViewAdv1.PointToClient(New Point(MousePosition.X, MousePosition.Y))

        'Get the Node at the specified Location
        Dim node As TreeNodeAdv = Me.treeViewAdv1.GetNodeAtPoint(pt)

        'Get the selected node of the TreeViewAdv1 Control
        node = Me.treeViewAdv1.SelectedNode

        'Checking whether the Selected Node is not equal to Null
        If Not node Is Nothing Then

            ' Update the icon for the selected node
            If node.Text = "Asia" OrElse node.Text = "India" OrElse node.Text = "China" OrElse node.Text = "Europe" OrElse node.Text = "Britain" OrElse node.Text = "France" OrElse node.Text = "North America" OrElse node.Text = "United States" OrElse node.Text = "Canada" Then

                'Get the Location to paint the new image
                pt = New Point(node.LeftImagesX, node.TextAndImageBounds.Y)

                'Paint the new image at the specified location
                e.Graphics.DrawImage(imageList1.Images(0), pt)

            Else
                'Get the Location to paint the new image
                pt = New Point(node.RightImagesX, node.TextAndImageBounds.Y)

                'Paint the new image at the specified location
                e.Graphics.DrawImage(imageList2.Images(8), pt)
            End If

        End If
    End Sub

    'This event wiil be fired  before a node has collapsed.
    Private Sub treeViewAdv1_BeforeCollapse(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.TreeViewAdvCancelableNodeEventArgs) Handles treeViewAdv1.BeforeCollapse
        'Checking Whether the Selected node doesn't have a children
        If (Not Me.treeViewAdv1.SelectedNode.HasChildren) Then
            'Set the Selected Node of the  TreeviewAdv1
            Me.treeViewAdv1.SelectedNode = Me.treeViewAdv1.SelectedNode.Parent
        End If

    End Sub

#End Region

End Class
#End Region

