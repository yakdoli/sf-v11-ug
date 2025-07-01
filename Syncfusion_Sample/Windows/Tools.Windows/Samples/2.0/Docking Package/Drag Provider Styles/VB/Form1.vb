Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms

Namespace DragProviderStyles
	Public Class Form1 : Inherits Office2007Form
        Private WithEvents tsDragStyles As Syncfusion.Windows.Forms.Tools.ToolStripEx
        Private tsbDefault As ToolStripButton
        Private tsbWhidbey As ToolStripButton
        Private tsbVs2005 As ToolStripButton
        Private tsbVs2008 As ToolStripButton
        Private syncProductsTree As Syncfusion.Windows.Forms.Tools.TreeViewAdv
        Private imageList1 As ImageList
        Private WithEvents dockingManager1 As Syncfusion.Windows.Forms.Tools.DockingManager
        Private pnlDescription As Panel
        Private label1 As Label
        Private chkListSWDevelopmt As CheckedListBox
        Private pictureBox1 As PictureBox
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        Public Sub New()
            InitializeComponent()

        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Form1())
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Not components Is Nothing) Then
                components.Dispose()
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim ccbsyncProductsTree As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
            Dim ccbpnlDescription As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
            Dim ccbchkListSWDevelopmt As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
            Dim ccbpictureBox1 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
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
            Me.dockingManager1 = New Syncfusion.Windows.Forms.Tools.DockingManager(Me.components)
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.syncProductsTree = New Syncfusion.Windows.Forms.Tools.TreeViewAdv
            Me.pnlDescription = New System.Windows.Forms.Panel
            Me.label1 = New System.Windows.Forms.Label
            Me.chkListSWDevelopmt = New System.Windows.Forms.CheckedListBox
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.tsDragStyles = New Syncfusion.Windows.Forms.Tools.ToolStripEx
            Me.tsbDefault = New System.Windows.Forms.ToolStripButton
            Me.tsbWhidbey = New System.Windows.Forms.ToolStripButton
            Me.tsbVs2005 = New System.Windows.Forms.ToolStripButton
            Me.tsbVs2008 = New System.Windows.Forms.ToolStripButton
            CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.syncProductsTree, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlDescription.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tsDragStyles.SuspendLayout()
            Me.SuspendLayout()
            '
            'dockingManager1
            '
            Me.dockingManager1.DockLayoutStream = CType(resources.GetObject("dockingManager1.DockLayoutStream"), System.IO.MemoryStream)
            Me.dockingManager1.DockTabFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.VS2008
            Me.dockingManager1.HostControl = Me
            Me.dockingManager1.ImageList = Me.imageList1
            Me.dockingManager1.Office2007MdiChildForm = True
            Me.dockingManager1.Office2007MdiColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue
            Me.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"))
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"))
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"))
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"))
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Restore, "RestoreButton"))
            Me.dockingManager1.SetDockLabel(Me.syncProductsTree, "Syncfusion Products")
            Me.dockingManager1.SetDockIcon(Me.syncProductsTree, 10)
            ccbsyncProductsTree.MergeWith(Me.dockingManager1.CaptionButtons, False)
            Me.dockingManager1.SetCustomCaptionButtons(Me.syncProductsTree, ccbsyncProductsTree)
            Me.dockingManager1.SetDockLabel(Me.pnlDescription, "Description")
            Me.dockingManager1.SetDockIcon(Me.pnlDescription, 9)
            ccbpnlDescription.MergeWith(Me.dockingManager1.CaptionButtons, False)
            Me.dockingManager1.SetCustomCaptionButtons(Me.pnlDescription, ccbpnlDescription)
            Me.dockingManager1.SetDockLabel(Me.chkListSWDevelopmt, "Software Development Cycle")
            ccbchkListSWDevelopmt.MergeWith(Me.dockingManager1.CaptionButtons, False)
            Me.dockingManager1.SetCustomCaptionButtons(Me.chkListSWDevelopmt, ccbchkListSWDevelopmt)
            Me.dockingManager1.SetDockLabel(Me.pictureBox1, "Organization Chart")
            ccbpictureBox1.MergeWith(Me.dockingManager1.CaptionButtons, False)
            Me.dockingManager1.SetCustomCaptionButtons(Me.pictureBox1, ccbpictureBox1)
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "icon_samplebrowser.png")
            Me.imageList1.Images.SetKeyName(1, "icon_tools.png")
            Me.imageList1.Images.SetKeyName(2, "icon_grid.png")
            Me.imageList1.Images.SetKeyName(3, "icon_chart.png")
            Me.imageList1.Images.SetKeyName(4, "icon_diagram.png")
            Me.imageList1.Images.SetKeyName(5, "icon_calculate.png")
            Me.imageList1.Images.SetKeyName(6, "icon_docio_opt2.png")
            Me.imageList1.Images.SetKeyName(7, "icon_pdf_opt2.png")
            Me.imageList1.Images.SetKeyName(8, "icon_xlsio_opt2.png")
            Me.imageList1.Images.SetKeyName(9, "MSACCESS_EXE_10_08.ico")
            Me.imageList1.Images.SetKeyName(10, "MSO_DLL_68_01.ico")
            '
            'syncProductsTree
            '
            TreeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = True
            TreeNodeAdvStyleInfo1.ThemesEnabled = True
            Me.syncProductsTree.BaseStylePairs.AddRange(New Syncfusion.Windows.Forms.Tools.StyleNamePair() {New Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", TreeNodeAdvStyleInfo1)})
            Me.dockingManager1.SetEnableDocking(Me.syncProductsTree, True)
            Me.syncProductsTree.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            '
            '
            Me.syncProductsTree.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.syncProductsTree.HelpTextControl.Location = New System.Drawing.Point(0, 0)
            Me.syncProductsTree.HelpTextControl.Name = "helpText"
            Me.syncProductsTree.HelpTextControl.Size = New System.Drawing.Size(49, 15)
            Me.syncProductsTree.HelpTextControl.TabIndex = 0
            Me.syncProductsTree.HelpTextControl.Text = "help text"
            Me.syncProductsTree.LeftImageList = Me.imageList1
            Me.syncProductsTree.Location = New System.Drawing.Point(3, 23)
            Me.syncProductsTree.Name = "syncProductsTree"
            TreeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv1.EnsureDefaultOptionedChild = True
            TreeNodeAdv1.Expanded = True
            TreeNodeAdv1.LeftImageIndices = New Integer() {0}
            TreeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv2.EnsureDefaultOptionedChild = True
            TreeNodeAdv2.LeftImageIndices = New Integer() {1}
            TreeNodeAdv2.Optioned = True
            TreeNodeAdv2.Text = "Essential Tools"
            TreeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv3.EnsureDefaultOptionedChild = True
            TreeNodeAdv3.LeftImageIndices = New Integer() {2}
            TreeNodeAdv3.Text = "Essential Grid"
            TreeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv4.EnsureDefaultOptionedChild = True
            TreeNodeAdv4.LeftImageIndices = New Integer() {3}
            TreeNodeAdv4.Text = "Essential Chart"
            TreeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv5.EnsureDefaultOptionedChild = True
            TreeNodeAdv5.LeftImageIndices = New Integer() {4}
            TreeNodeAdv5.Text = "Essential Diagram"
            TreeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv6.EnsureDefaultOptionedChild = True
            TreeNodeAdv6.Expanded = True
            TreeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv7.EnsureDefaultOptionedChild = True
            TreeNodeAdv7.Expanded = True
            TreeNodeAdv7.LeftImageIndices = New Integer() {5}
            TreeNodeAdv7.Optioned = True
            TreeNodeAdv7.Text = "Essential Calculate"
            TreeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv8.EnsureDefaultOptionedChild = True
            TreeNodeAdv8.Expanded = True
            TreeNodeAdv8.LeftImageIndices = New Integer() {6}
            TreeNodeAdv8.Text = "Essential DocIO"
            TreeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv9.EnsureDefaultOptionedChild = True
            TreeNodeAdv9.Expanded = True
            TreeNodeAdv9.LeftImageIndices = New Integer() {7}
            TreeNodeAdv9.Text = "Essential PDF"
            TreeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = True
            TreeNodeAdv10.EnsureDefaultOptionedChild = True
            TreeNodeAdv10.Expanded = True
            TreeNodeAdv10.LeftImageIndices = New Integer() {8}
            TreeNodeAdv10.Text = "Essential XlsIO"
            TreeNodeAdv6.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv7, TreeNodeAdv8, TreeNodeAdv9, TreeNodeAdv10})
            TreeNodeAdv6.Text = "Back Office Products"
            TreeNodeAdv1.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv2, TreeNodeAdv3, TreeNodeAdv4, TreeNodeAdv5, TreeNodeAdv6})
            TreeNodeAdv1.Text = "Essential Suite"
            Me.syncProductsTree.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {TreeNodeAdv1})
            Me.syncProductsTree.Office2007ScrollBars = True
            Me.syncProductsTree.Size = New System.Drawing.Size(159, 476)
            Me.syncProductsTree.TabIndex = 2
            Me.syncProductsTree.Text = "treeViewAdv1"
            Me.syncProductsTree.ThemesEnabled = True
            '
            '
            '
            Me.syncProductsTree.ToolTipControl.BackColor = System.Drawing.SystemColors.Info
            Me.syncProductsTree.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.syncProductsTree.ToolTipControl.Location = New System.Drawing.Point(0, 0)
            Me.syncProductsTree.ToolTipControl.Name = "toolTip"
            Me.syncProductsTree.ToolTipControl.Size = New System.Drawing.Size(41, 15)
            Me.syncProductsTree.ToolTipControl.TabIndex = 1
            Me.syncProductsTree.ToolTipControl.Text = "toolTip"
            '
            'pnlDescription
            '
            Me.pnlDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.pnlDescription.Controls.Add(Me.label1)
            Me.dockingManager1.SetEnableDocking(Me.pnlDescription, True)
            Me.pnlDescription.Location = New System.Drawing.Point(3, 3)
            Me.pnlDescription.Name = "pnlDescription"
            Me.pnlDescription.Size = New System.Drawing.Size(341, 109)
            Me.pnlDescription.TabIndex = 5
            '
            'label1
            '
            Me.label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.BackColor = System.Drawing.Color.Lavender
            Me.label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(7, 9)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(326, 91)
            Me.label1.TabIndex = 0
            Me.label1.Text = resources.GetString("label1.Text")
            '
            'chkListSWDevelopmt
            '
            Me.dockingManager1.SetEnableDocking(Me.chkListSWDevelopmt, True)
            Me.chkListSWDevelopmt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkListSWDevelopmt.FormattingEnabled = True
            Me.chkListSWDevelopmt.Items.AddRange(New Object() {"Data Collection Phase", "Analysis Phase", "Design Phase", "Implementation Phase", "Testing Phase", "Distribution Phase"})
            Me.chkListSWDevelopmt.Location = New System.Drawing.Point(3, 23)
            Me.chkListSWDevelopmt.Name = "chkListSWDevelopmt"
            Me.chkListSWDevelopmt.Size = New System.Drawing.Size(450, 180)
            Me.chkListSWDevelopmt.TabIndex = 7
            '
            'pictureBox1
            '
            Me.dockingManager1.SetEnableDocking(Me.pictureBox1, True)
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(3, 23)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(450, 180)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox1.TabIndex = 9
            Me.pictureBox1.TabStop = False
            '
            'tsDragStyles
            '
            Me.tsDragStyles.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tsDragStyles.ForeColor = System.Drawing.Color.MidnightBlue
            Me.tsDragStyles.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.tsDragStyles.Image = Nothing
            Me.tsDragStyles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbDefault, Me.tsbWhidbey, Me.tsbVs2005, Me.tsbVs2008})
            Me.tsDragStyles.Location = New System.Drawing.Point(0, 0)
            Me.tsDragStyles.Name = "tsDragStyles"
            Me.tsDragStyles.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue
            Me.tsDragStyles.ShowCaption = False
            Me.tsDragStyles.ShowLauncher = True
            Me.tsDragStyles.Size = New System.Drawing.Size(625, 25)
            Me.tsDragStyles.TabIndex = 1
            '
            'tsbDefault
            '
            Me.tsbDefault.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.tsbDefault.Image = CType(resources.GetObject("tsbDefault.Image"), System.Drawing.Image)
            Me.tsbDefault.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbDefault.Name = "tsbDefault"
            Me.tsbDefault.Size = New System.Drawing.Size(52, 22)
            Me.tsbDefault.Text = "Default"
            '
            'tsbWhidbey
            '
            Me.tsbWhidbey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.tsbWhidbey.Image = CType(resources.GetObject("tsbWhidbey.Image"), System.Drawing.Image)
            Me.tsbWhidbey.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbWhidbey.Name = "tsbWhidbey"
            Me.tsbWhidbey.Size = New System.Drawing.Size(60, 22)
            Me.tsbWhidbey.Text = "Whidbey"
            '
            'tsbVs2005
            '
            Me.tsbVs2005.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.tsbVs2005.Image = CType(resources.GetObject("tsbVs2005.Image"), System.Drawing.Image)
            Me.tsbVs2005.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbVs2005.Name = "tsbVs2005"
            Me.tsbVs2005.Size = New System.Drawing.Size(55, 22)
            Me.tsbVs2005.Text = "VS2005"
            '
            'tsbVs2008
            '
            Me.tsbVs2008.Checked = True
            Me.tsbVs2008.CheckState = System.Windows.Forms.CheckState.Checked
            Me.tsbVs2008.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.tsbVs2008.Image = CType(resources.GetObject("tsbVs2008.Image"), System.Drawing.Image)
            Me.tsbVs2008.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.tsbVs2008.Name = "tsbVs2008"
            Me.tsbVs2008.Size = New System.Drawing.Size(55, 22)
            Me.tsbVs2008.Text = "VS2008"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(625, 527)
            Me.Controls.Add(Me.tsDragStyles)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.IsMdiContainer = True
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Drag Provider Styles"
            CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.syncProductsTree, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlDescription.ResumeLayout(False)
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tsDragStyles.ResumeLayout(False)
            Me.tsDragStyles.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

#Region "Change Drag Provider Styles"
        Private Sub tsDragStyles_ItemClicked(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs) Handles tsDragStyles.ItemClicked
            Select Case e.ClickedItem.Text
                Case "Default"
                    dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.Standard
                Case "Whidbey"
                    dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.Whidbey
                Case "VS2005"
                    dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.VS2005
                Case "VS2008"
                    dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.VS2008
            End Select

            Dim button As ToolStripButton = CType(e.ClickedItem, ToolStripButton)
            button.Checked = True

            For i As Integer = 0 To tsDragStyles.Items.Count - 1
                If Not tsDragStyles.Items(i) Is e.ClickedItem Then
                    button = CType(tsDragStyles.Items(i), ToolStripButton)
                    button.Checked = False
                End If
            Next i

        End Sub
#End Region

#Region "Initialization Settings"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            chkListSWDevelopmt.SetItemChecked(0, True)
            chkListSWDevelopmt.SetItemChecked(2, True)
            chkListSWDevelopmt.SetItemChecked(3, True)

        End Sub

        Private Sub dockingManager1_NewDockStateEndLoad(ByVal sender As Object, ByVal e As EventArgs) Handles dockingManager1.NewDockStateEndLoad
            Me.dockingManager1.SetAsMDIChild(Me.pnlDescription, True)
        End Sub
#End Region

	End Class
End Namespace