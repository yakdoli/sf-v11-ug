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

#Region "Class Form1 Description1"
    
    Public Class Form1 : Inherits System.Windows.Forms.Form

#Region "Variable Declaration"
        Private WithEvents treeViewAdv1 As Syncfusion.Windows.Forms.Tools.TreeViewAdv
        Private imageList1 As System.Windows.Forms.ImageList
        Private components As System.ComponentModel.IContainer
#End Region

#Region "Form Constructor Initialization and Disposing"

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Me.treeViewAdv1.StateImageList = Me.imageList1
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
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
            Me.treeViewAdv1 = New Syncfusion.Windows.Forms.Tools.TreeViewAdv()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'treeViewAdv1
            '
            Me.treeViewAdv1.ActiveNode = Nothing
            Me.treeViewAdv1.AddSeparatorAtEnd = True
            Me.treeViewAdv1.AllowDrop = True
            Me.treeViewAdv1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, System.Drawing.Color.FromArgb(CType(237, Byte), CType(240, Byte), CType(246, Byte)), System.Drawing.SystemColors.HotTrack)
            TreeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = True
            TreeNodeAdvStyleInfo1.ThemesEnabled = True
            Me.treeViewAdv1.BaseStylePairs.AddRange(New Syncfusion.Windows.Forms.Tools.StyleNamePair() {New Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", TreeNodeAdvStyleInfo1)})
            Me.treeViewAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Bump
            Me.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeViewAdv1.Font = New System.Drawing.Font("Tahoma", 8.0!)
            Me.treeViewAdv1.ForeColor = System.Drawing.SystemColors.ControlText
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
            Me.treeViewAdv1.HotTracking = True
            Me.treeViewAdv1.IgnoreThemeBackground = True
            Me.treeViewAdv1.LineColor = System.Drawing.Color.Transparent
            Me.treeViewAdv1.LoadOnDemand = True
            Me.treeViewAdv1.Name = "treeViewAdv1"
            TreeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv1.EnsureDefaultOptionedChild = True
            TreeNodeAdv1.Height = 16
            TreeNodeAdv1.InteractiveCheckBox = True
            TreeNodeAdv1.ShowPlusOnExpand = False
            TreeNodeAdv1.Text = "c:"
            Me.treeViewAdv1.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv1})
            Me.treeViewAdv1.OwnerDrawNodes = True
            Me.treeViewAdv1.OwnerDrawNodesBackground = True
            Me.treeViewAdv1.PathSeparator = "/"
            Me.treeViewAdv1.Size = New System.Drawing.Size(306, 526)
            Me.treeViewAdv1.TabIndex = 1
            Me.treeViewAdv1.ThemesEnabled = True
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
            Me.treeViewAdv1.TransparentControls = True
            '
            'imageList1
            '
            Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
            Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
            Me.imageList1.TransparentColor = System.Drawing.Color.White
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.AutoScroll = True
            Me.ClientSize = New System.Drawing.Size(306, 526)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.treeViewAdv1})
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = " Owner Draw"
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


#Region "NODE_FILL"

        'This Event will be fired  before a node is expanded
        Private Sub treeViewAdv2_BeforeExpand(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.TreeViewAdvCancelableNodeEventArgs) Handles treeViewAdv1.BeforeExpand
            Try


                'Checking Whether the Node has been expanded atleast once
                If e.Node.ExpandedOnce Then
                    Return
                End If
                'Get the Path of the node
                Dim path As String = e.Node.GetPath("\")

                'Get an Array of Directories from the current directory
                Dim dirs As ArrayList = New ArrayList(Directory.GetDirectories(path))

                'Add the Directories as a node in TreeViewAdv
                Dim i As Integer = 0
                'ORIGINAL LINE: for(int i=0;i<dirs.Count;i += 1)
                'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
                Do While i < dirs.Count
                    Dim dir As String = CStr(dirs(i))
                    Dim lastIndex As Integer = dir.LastIndexOf("\") + 1
                    '				if(lastIndex <=0) lastIndex = dir.LastIndexOf(":")+1;
                    '				if(lastIndex>0)
                    Dim node As TreeNodeAdv = New TreeNodeAdv(dir.Substring(lastIndex))
                    e.Node.Nodes.Add(node)
                    i += 1
                Loop
            Catch ex As Exception
            End Try
        End Sub
#End Region   ' NODE_FILL


#Region "OWNER_DRAWING"
        ' Draw the background of the whole node here:
        Private Sub treeViewAdv1_NodeBackgroundPaint(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.TreeNodeAdvPaintBackgroundEventArgs) Handles treeViewAdv1.NodeBackgroundPaint
            If e.Selected Then
                ' Draw the beige background.
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(218, 229, 254)), e.Bounds)
            End If
        End Sub

        Private Sub treeViewAdv1_BeforeNodePaint(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.TreeNodeAdvPaintEventArgs) Handles treeViewAdv1.BeforeNodePaint
            If e.Selected Then
                ' Paint a custom background around the text area:
                e.Graphics.FillRectangle(New SolidBrush(Color.White), e.Node.TextBounds)
                e.ForeColor = SystemColors.WindowText
            ElseIf e.HotTracked Then
                If Me.treeViewAdv1.RightToLeft = RightToLeft.No Then
                    ' Draw the text myself and prevent default text drawing:
                    Dim node As TreeNodeAdv = e.Node
                    Dim foreBrush As Brush = New SolidBrush(e.ForeColor)

                    e.Graphics.DrawString(e.Node.Text, Me.GetHotFont(node), foreBrush, node.TextBounds.X, node.Bounds.Y + (node.Height - node.TextBounds.Height) / 2)

                    e.HandledText = True
                End If
            End If
        End Sub

        Private Function GetHotFont(ByVal node As TreeNodeAdv) As Font
            Dim dFont As Font = node.Font
            Return Syncfusion.Drawing.FontUtil.CreateFont(dFont, dFont.Style Or FontStyle.Bold Or FontStyle.Underline)
        End Function
        'This Event will be Fired after a node is being painted when the OwnerDrawNodes property is set to true
        Private Sub treeViewAdv1_AfterNodePaint(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.TreeNodeAdvPaintEventArgs) Handles treeViewAdv1.AfterNodePaint
            'Checking whether Node is selected or not
            If e.Selected Then
                'Draw the owner Draw text at the RightHand Side of the Selected node
                If Me.treeViewAdv1.RightToLeft = RightToLeft.No Then
                    Dim node As TreeNodeAdv = e.Node
                    Dim foreBrush As Brush = New SolidBrush(e.ForeColor)
                    e.Graphics.DrawString("""Owner Drawn Text""", node.Font, foreBrush, node.TextBounds.Right + 2, node.Bounds.Y + (node.Height - node.TextBounds.Height) / 2)
                End If
            End If
        End Sub
#End Region   ' OWNER_DRAWING
#End Region

#Region "Form Event Handler"

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If Me.treeViewAdv1.RightToLeft = RightToLeft.Yes Then
                MessageBox.Show("Owner drawing is done only when the control's RightToLeft is set to No.")
            End If
        End Sub
#End Region
    End Class
#End Region

End Namespace

