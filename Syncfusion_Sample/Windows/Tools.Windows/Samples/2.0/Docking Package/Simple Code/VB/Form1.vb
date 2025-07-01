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
Imports Syncfusion.Windows.Forms.Tools
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Resources
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms

Namespace SimpleCode
    Public Class Form1
        Inherits Office2007Form
#Region "Member variables"
        Private WithEvents listBox1 As ListBox
        Private WithEvents listBox2 As ListBox
        Private WithEvents checkedListBox1 As CheckedListBox
        Private WithEvents dockingManager As DockingManager
        Friend WithEvents treeView1 As System.Windows.Forms.TreeView
        Friend WithEvents ilDocking As System.Windows.Forms.ImageList
        Friend WithEvents pgDocking As PropertyGrid
        Private components As IContainer
#End Region
#Region "Initialization"
        Public Sub New()
            MyBase.New()
            '
            ' Required for Windows Form Designer support
            '
     
            InitializeComponent()

            ' The InitalizeDockingWindows method programmatically initializes the DockingManager 
            ' and the various dockable controls.
            InitializeDockingWindows()
            Me.dockingManager.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007

        End Sub
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)

            If disposing Then
                If (Not (components) Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)

        End Sub


        <STAThread()> _
       Public Shared Sub Main()

            Application.Run(New Form1())

        End Sub
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Grid")
            Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tools")
            Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Chart")
            Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Diagram")
            Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Calculate")
            Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Grouping")
            Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DocIO")
            Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PDF")
            Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("XlsIO")
            Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Barcode")
            Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Asp.Net", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10})
            Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Grid")
            Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tools")
            Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Chart")
            Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Diagram")
            Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Edit")
            Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Calculate")
            Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Grouping")
            Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DocIO")
            Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PDF")
            Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("XlsIO")
            Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HTMLUI")
            Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Barcode")
            Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Windows Forms", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16, TreeNode17, TreeNode18, TreeNode19, TreeNode20, TreeNode21, TreeNode22, TreeNode23})
            Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Products", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode24})
            Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Knowledge Base")
            Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Evaluation Center")
            Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DirectTrac")
            Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Forums")
            Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Feature Requests")
            Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Open Issues")
            Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Windows Forms FAQs")
            Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ASP.NET FAQs")
            Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Support", New System.Windows.Forms.TreeNode() {TreeNode26, TreeNode27, TreeNode28, TreeNode29, TreeNode30, TreeNode31, TreeNode32, TreeNode33})
            Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Syncfusion", New System.Windows.Forms.TreeNode() {TreeNode25, TreeNode34})
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.listBox1 = New System.Windows.Forms.ListBox
            Me.listBox2 = New System.Windows.Forms.ListBox
            Me.checkedListBox1 = New System.Windows.Forms.CheckedListBox
            Me.treeView1 = New System.Windows.Forms.TreeView
            Me.pgDocking = New System.Windows.Forms.PropertyGrid
            Me.ilDocking = New System.Windows.Forms.ImageList(Me.components)
            Me.SuspendLayout()
            '
            'listBox1
            '
            Me.listBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.listBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
            Me.listBox1.ItemHeight = 15
            Me.listBox1.Items.AddRange(New Object() {"Grid", "Tools", "Chart", "Diagram", "Calculate", "Grouping", "DocIO", "PDF", "XlsIO", "Barcode"})
            Me.listBox1.Location = New System.Drawing.Point(24, 29)
            Me.listBox1.Name = "listBox1"
            Me.listBox1.Size = New System.Drawing.Size(96, 124)
            Me.listBox1.TabIndex = 0
            '
            'listBox2
            '
            Me.listBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.listBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
            Me.listBox2.ItemHeight = 15
            Me.listBox2.Items.AddRange(New Object() {"Grid", "Tools", "Chart", "Diagram", "Edit", "Calculate", "Grouping", "DocIO", "PDF", "XlsIO", "HTMLUI", "Barcode"})
            Me.listBox2.Location = New System.Drawing.Point(104, 186)
            Me.listBox2.Name = "listBox2"
            Me.listBox2.Size = New System.Drawing.Size(136, 109)
            Me.listBox2.TabIndex = 1
            '
            'checkedListBox1
            '
            Me.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.checkedListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
            Me.checkedListBox1.Items.AddRange(New Object() {"Knowledge Base", "Evaluation Center", "Direct-Trac", "Forums", "Feature Requests", "Open Issues", "Windows FAQs", "ASP.NET FAQs"})
            Me.checkedListBox1.Location = New System.Drawing.Point(267, 47)
            Me.checkedListBox1.Name = "checkedListBox1"
            Me.checkedListBox1.Size = New System.Drawing.Size(112, 228)
            Me.checkedListBox1.TabIndex = 2
            '
            'treeView1
            '
            Me.treeView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(225, Byte), Integer))
            Me.treeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
            Me.treeView1.Location = New System.Drawing.Point(400, 64)
            Me.treeView1.Name = "treeView1"
            TreeNode1.Name = ""
            TreeNode1.Text = "Grid"
            TreeNode2.Name = ""
            TreeNode2.Text = "Tools"
            TreeNode3.Name = ""
            TreeNode3.Text = "Chart"
            TreeNode4.Name = ""
            TreeNode4.Text = "Diagram"
            TreeNode5.Name = ""
            TreeNode5.Text = "Calculate"
            TreeNode6.Name = ""
            TreeNode6.Text = "Grouping"
            TreeNode7.Name = ""
            TreeNode7.Text = "DocIO"
            TreeNode8.Name = ""
            TreeNode8.Text = "PDF"
            TreeNode9.Name = ""
            TreeNode9.Text = "XlsIO"
            TreeNode10.Name = ""
            TreeNode10.Text = "Barcode"
            TreeNode11.Name = ""
            TreeNode11.Text = "Asp.Net"
            TreeNode12.Name = ""
            TreeNode12.Text = "Grid"
            TreeNode13.Name = ""
            TreeNode13.Text = "Tools"
            TreeNode14.Name = ""
            TreeNode14.Text = "Chart"
            TreeNode15.Name = ""
            TreeNode15.Text = "Diagram"
            TreeNode16.Name = ""
            TreeNode16.Text = "Edit"
            TreeNode17.Name = ""
            TreeNode17.Text = "Calculate"
            TreeNode18.Name = ""
            TreeNode18.Text = "Grouping"
            TreeNode19.Name = ""
            TreeNode19.Text = "DocIO"
            TreeNode20.Name = ""
            TreeNode20.Text = "PDF"
            TreeNode21.Name = ""
            TreeNode21.Text = "XlsIO"
            TreeNode22.Name = ""
            TreeNode22.Text = "HTMLUI"
            TreeNode23.Name = ""
            TreeNode23.Text = "Barcode"
            TreeNode24.Name = ""
            TreeNode24.Text = "Windows Forms"
            TreeNode25.Name = ""
            TreeNode25.Text = "Products"
            TreeNode26.Name = ""
            TreeNode26.Text = "Knowledgebase"
            TreeNode27.Name = ""
            TreeNode27.Text = "Evaluation Center"
            TreeNode28.Name = ""
            TreeNode28.Text = "Direct-Trac"
            TreeNode29.Name = ""
            TreeNode29.Text = "Forums"
            TreeNode30.Name = ""
            TreeNode30.Text = "Feature Requests"
            TreeNode31.Name = ""
            TreeNode31.Text = "Open Issues"
            TreeNode32.Name = ""
            TreeNode32.Text = "Windows Forms FAQ"
            TreeNode33.Name = ""
            TreeNode33.Text = "ASP.NET FAQ"
            TreeNode34.Name = ""
            TreeNode34.Text = "Support"
            TreeNode35.Name = ""
            TreeNode35.Text = "Syncfusion"
            Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode35})
            Me.treeView1.Size = New System.Drawing.Size(160, 215)
            Me.treeView1.TabIndex = 4
            '
            'pgDocking
            '
            Me.pgDocking.CommandsBackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(246, Byte), Integer))
            Me.pgDocking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
            Me.pgDocking.HelpBackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.pgDocking.LineColor = System.Drawing.SystemColors.ScrollBar
            Me.pgDocking.Location = New System.Drawing.Point(120, 36)
            Me.pgDocking.Name = "pgDocking"
            Me.pgDocking.Size = New System.Drawing.Size(130, 116)
            Me.pgDocking.TabIndex = 0
            Me.pgDocking.ViewBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
            '
            'ilDocking
            '
            Me.ilDocking.ImageStream = CType(resources.GetObject("ilDocking.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ilDocking.TransparentColor = System.Drawing.Color.Transparent
            Me.ilDocking.Images.SetKeyName(0, "")
            Me.ilDocking.Images.SetKeyName(1, "")
            Me.ilDocking.Images.SetKeyName(2, "")
            Me.ilDocking.Images.SetKeyName(3, "")
            Me.ilDocking.Images.SetKeyName(4, "")
            Me.ilDocking.Images.SetKeyName(5, "")
            Me.ilDocking.Images.SetKeyName(6, "")
            Me.ilDocking.Images.SetKeyName(7, "")
            Me.ilDocking.Images.SetKeyName(8, "")
            Me.ilDocking.Images.SetKeyName(9, "")
            Me.ilDocking.Images.SetKeyName(10, "")
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(246, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(576, 446)
            Me.Controls.Add(Me.pgDocking)
            Me.Controls.Add(Me.treeView1)
            Me.Controls.Add(Me.checkedListBox1)
            Me.Controls.Add(Me.listBox2)
            Me.Controls.Add(Me.listBox1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Simple Code"
            Me.ResumeLayout(False)

        End Sub
#End Region
#Region "Initialization-DockingManager"
        ' <samplecodeblock name="DockingWindows">
        Private Sub InitializeDockingWindows()

            ' Create the DockingManager instance and set this form as the host form.
            Me.dockingManager = New Syncfusion.Windows.Forms.Tools.DockingManager(Me.components)
            Me.dockingManager.BeginInit()
            Me.dockingManager.HostForm = Me
            Me.dockingManager.ThemesEnabled = True


            ' Disable state persistence
            Me.dockingManager.PersistState = False
            ' Enable display of the default context menus
            Me.dockingManager.EnableContextMenu = True
            ' Set the imagelist that will provide the icons for the docking windows.
            Me.dockingManager.ImageList = Me.ilDocking
            Me.dockingManager.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007

            ' Dock listbox1 to the left border of the form and with an initial 
            ' width of 175 units.
            ' NOTE - Calling DockControl() on a control for the first time, 
            ' will initialize it as a docking window. This is the equivalent of 
            ' the DockingManager.SetEnableDocking() call.
            Me.dockingManager.DockControl(Me.listBox1, Me, Syncfusion.Windows.Forms.Tools.DockingStyle.Left, 175)
            ' Set the text to be displayed in the dockingwindow caption
            Me.dockingManager.SetDockLabel(Me.listBox1, "Syncfusion ASP.NET products")
            ' The image index used for this control
            Me.dockingManager.SetDockIcon(Me.listBox1, 5)

            ' Now dock listbox2 as a tab onto listbox1
            Me.dockingManager.DockControl(Me.listBox2, Me.listBox1, Syncfusion.Windows.Forms.Tools.DockingStyle.Tabbed, 175)
            Me.dockingManager.SetDockLabel(Me.listBox2, "Syncfsuion Windows forms products")
            Me.dockingManager.SetDockIcon(Me.listBox2, 4)

            'Now dock propertygrid at top of listbox1
            Me.pgDocking.SelectedObject = Me.dockingManager
            Me.dockingManager.DockControl(Me.pgDocking, Me, DockingStyle.Right, 175)
            Me.dockingManager.SetDockLabel(Me.pgDocking, "Docking Manager")
            Me.dockingManager.SetDockIcon(Me.pgDocking, 10)

            ' Dock the treeView to the right border of the form with a width of 150.
            Me.dockingManager.DockControl(Me.treeView1, Me, Syncfusion.Windows.Forms.Tools.DockingStyle.Right, 150)
            ' Set treeView1 to start off in the AutoHide position.
            Me.dockingManager.SetAutoHideMode(Me.treeView1, True)
            Me.dockingManager.SetDockLabel(Me.treeView1, "Syncfusion at a glance")
            Me.dockingManager.SetDockIcon(Me.treeView1, 9)

            ' Set checkedListBox1 to be initially in a floating position.
            Dim rcfrm As Rectangle
            rcfrm = Me.Bounds
            Me.dockingManager.FloatControl(Me.checkedListBox1, New Rectangle((rcfrm.Right + 25), (rcfrm.Bottom - 250), 175, 300))
            Me.dockingManager.SetDockLabel(Me.checkedListBox1, "Syncfusion support")
            Me.dockingManager.SetDockIcon(Me.checkedListBox1, 8)
            Me.dockingManager.EndInit()

        End Sub
        '</samplecodeblock>
#End Region
    End Class
End Namespace
