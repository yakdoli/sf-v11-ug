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

Imports DemoCommon
Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Resources
Imports System.Windows.Forms

Namespace LayoutManagers
    Public Class MainForm
        Inherits Form
        Private WithEvents mainMenu1 As MainMenu
        Private WithEvents menuItem1 As MenuItem
        Private WithEvents menuItem3 As MenuItem
        Private WithEvents mdiClient1 As MdiClient
        Private WithEvents gridBagLMMenu As MenuItem
        Private WithEvents cardLMMenu As MenuItem
        Private WithEvents gridLMMenu As MenuItem
        Private WithEvents nonControlItems As MenuItem
        Private WithEvents menuItem2 As MenuItem
        Private WithEvents menuItem4 As MenuItem
        Private components As Container
        Private WithEvents aboutForm As aboutForm
        'Fields
        'Constructors
        'Events
        'Methods
        Public Sub New()
            MyBase.New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '

        End Sub
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)

            If disposing Then
                If (Not (components) Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)

        End Sub
        Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
        Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
        Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
            Me.menuItem1 = New System.Windows.Forms.MenuItem()
            Me.menuItem3 = New System.Windows.Forms.MenuItem()
            Me.MenuItem5 = New System.Windows.Forms.MenuItem()
            Me.cardLMMenu = New System.Windows.Forms.MenuItem()
            Me.gridLMMenu = New System.Windows.Forms.MenuItem()
            Me.gridBagLMMenu = New System.Windows.Forms.MenuItem()
            Me.MenuItem6 = New System.Windows.Forms.MenuItem()
            Me.nonControlItems = New System.Windows.Forms.MenuItem()
            Me.mainMenu1 = New System.Windows.Forms.MainMenu()
            Me.menuItem2 = New System.Windows.Forms.MenuItem()
            Me.menuItem4 = New System.Windows.Forms.MenuItem()
            Me.mdiClient1 = New System.Windows.Forms.MdiClient()
            Me.SuspendLayout()
            '
            'menuItem1
            '
            Me.menuItem1.Index = 0
            Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem3, Me.MenuItem5, Me.cardLMMenu, Me.gridLMMenu, Me.gridBagLMMenu, Me.MenuItem6, Me.nonControlItems})
            Me.menuItem1.Text = "LayoutTypes"
            '
            'menuItem3
            '
            Me.menuItem3.Index = 0
            Me.menuItem3.Text = "New FlowLayout Form"
            '
            'MenuItem5
            '
            Me.MenuItem5.Index = 1
            Me.MenuItem5.Text = "New FlowLayout (with ChildConstraints) Form"
            '
            'cardLMMenu
            '
            Me.cardLMMenu.Index = 2
            Me.cardLMMenu.Text = "New CardLayout Form"
            '
            'gridLMMenu
            '
            Me.gridLMMenu.Index = 3
            Me.gridLMMenu.Text = "New GridLayout Form"
            '
            'gridBagLMMenu
            '
            Me.gridBagLMMenu.Index = 4
            Me.gridBagLMMenu.Text = "New GridBagLayout Form"
            '
            'MenuItem6
            '
            Me.MenuItem6.Index = 5
            Me.MenuItem6.Text = "New BorderLayout Form"
            '
            'nonControlItems
            '
            Me.nonControlItems.Index = 6
            Me.nonControlItems.Text = "New Layout Non-Control based classes Form"
            '
            'mainMenu1
            '
            Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem2})
            '
            'menuItem2
            '
            Me.menuItem2.Index = 1
            Me.menuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem4})
            Me.menuItem2.Text = "&Help"
            '
            'menuItem4
            '
            Me.menuItem4.Index = 0
            Me.menuItem4.Text = "&About Syncfusion"
            '
            'mdiClient1
            '
            Me.mdiClient1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mdiClient1.Name = "mdiClient1"
            Me.mdiClient1.TabIndex = 0
            '
            'MainForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(656, 425)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.mdiClient1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.IsMdiContainer = True
            Me.Menu = Me.mainMenu1
            Me.MinimumSize = New System.Drawing.Size(400, 375)
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Layout Managers "
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.ResumeLayout(False)

        End Sub
        <STAThread()> _
        Public Shared Sub Main()

            Application.Run(New MainForm())

        End Sub
        Private Sub FlowLayout_Clicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItem3.Click

            Dim form As FlowLayoutForm
            form = New FlowLayoutForm()
            form.MdiParent = Me
            form.Show()

        End Sub
        Private Sub FlowLayoutCC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
            Dim form As FlowLayoutCC
            form = New FlowLayoutCC()
            form.MdiParent = Me
            form.Show()

        End Sub
        Private Sub cardLMMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cardLMMenu.Click

            Dim form As CardLayoutForm
            form = New CardLayoutForm()
            form.MdiParent = Me
            form.Show()

        End Sub
        Private Sub gridLMMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridLMMenu.Click

            Dim form As GridLayoutForm
            form = New GridLayoutForm()
            form.MdiParent = Me
            form.Show()

        End Sub
        Private Sub gridBagLMMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridBagLMMenu.Click

            Dim form As GridBagLayoutForm
            form = New GridBagLayoutForm()
            '			Test form = new Test();
            form.MdiParent = Me
            form.Show()

        End Sub
        Private Sub nonControlItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nonControlItems.Click

            Dim form As NonControlBasedComponents
            form = New NonControlBasedComponents()
            form.MdiParent = Me
            form.Show()

        End Sub

        Private Sub BorderLayout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
            Dim form As BorderLayoutForm
            form = New BorderLayoutForm()
            form.MdiParent = Me
            form.Show()
        End Sub
        Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Dim ctrl As Control
            For Each ctrl In Me.Controls
                If TypeOf ctrl Is MdiClient Then
                    ctrl.BackColor = Color.FromArgb(223, 227, 239)
                End If
            Next ctrl
            Me.nonControlItems_Click(Me, EventArgs.Empty)
            Me.BorderLayout_Click(Me, EventArgs.Empty)
            Me.cardLMMenu_Click(Me, EventArgs.Empty)
            Me.gridLMMenu_Click(Me, EventArgs.Empty)
            Me.gridBagLMMenu_Click(Me, EventArgs.Empty)
            Me.FlowLayoutCC_Click(Me, EventArgs.Empty)
            Me.FlowLayout_Clicked(Me, EventArgs.Empty)
            Me.LayoutMdi(MdiLayout.TileVertical)
        End Sub
        Private Sub menuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItem4.Click

            aboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())

            aboutForm.ShowDialog()

        End Sub

        Private Sub AboutFormCloseBtnClicked(ByVal sender As Object, ByVal e As EventArgs)

            aboutForm.Close()

        End Sub
    End Class
End Namespace
