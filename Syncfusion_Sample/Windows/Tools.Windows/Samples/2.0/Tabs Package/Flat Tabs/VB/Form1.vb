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
Imports Syncfusion.Reflection
Imports Syncfusion.Windows.Forms.Tools
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Resources
Imports System.Windows.Forms


Public Class Form1
    Inherits Form
    Private WithEvents flatTab1 As FlatTab
    Private WithEvents tabPageAdv1 As TabPageAdv
    Private WithEvents tabPageAdv2 As TabPageAdv
    Private WithEvents tabPageAdv3 As TabPageAdv
    Private WithEvents xpTaskBar1 As CustomXPTaskBar
    Private WithEvents xpTaskBarBox1 As XPTaskBarBox
    Private WithEvents panel1 As Panel
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents button1 As Button
    Private WithEvents designTimeTabTypeLoader As TypeLoader
    Private WithEvents label1 As Label
    Private WithEvents label2 As Label
    Private WithEvents label3 As Label
    Private components As IContainer
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
        Me.BackColor = System.Drawing.Color.Empty

    End Sub
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)

        If disposing Then
            If (Not (components) Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)

    End Sub
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.flatTab1 = New FlatTabs.FlatTab()
        Me.tabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tabPageAdv3 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.label3 = New System.Windows.Forms.Label()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.xpTaskBar1 = New FlatTabs.CustomXPTaskBar()
        Me.xpTaskBarBox1 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.button1 = New System.Windows.Forms.Button()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.designTimeTabTypeLoader = New Syncfusion.Reflection.TypeLoader(Me.components)
        CType(Me.flatTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flatTab1.SuspendLayout()
        Me.tabPageAdv2.SuspendLayout()
        Me.tabPageAdv1.SuspendLayout()
        Me.tabPageAdv3.SuspendLayout()
        CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xpTaskBar1.SuspendLayout()
        Me.xpTaskBarBox1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'flatTab1
        '
        Me.flatTab1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.flatTab1.BackColor = System.Drawing.Color.White
        Me.flatTab1.Controls.AddRange(New System.Windows.Forms.Control() {Me.tabPageAdv2, Me.tabPageAdv1, Me.tabPageAdv3})
        Me.flatTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flatTab1.FocusOnTabClick = False
        Me.flatTab1.ImageAlignmentR = Syncfusion.Windows.Forms.Tools.RelativeImageAlignment.AboveText
        Me.flatTab1.ImageList = Me.ImageList2
        Me.flatTab1.ItemSize = New System.Drawing.Size(120, 120)
        Me.flatTab1.Name = "flatTab1"
        Me.flatTab1.RotateTextWhenVertical = True
        Me.flatTab1.Size = New System.Drawing.Size(448, 318)
        Me.flatTab1.TabGap = 3
        Me.flatTab1.TabIndex = 0
        Me.flatTab1.TabStop = False
        Me.flatTab1.TabStyle = GetType(FlatTabs.FlatTabRenderer)
        '
        'tabPageAdv2
        '
        Me.tabPageAdv2.BackColor = System.Drawing.Color.White
        Me.tabPageAdv2.Controls.AddRange(New System.Windows.Forms.Control() {Me.label1})
        Me.tabPageAdv2.ImageIndex = 0
        Me.tabPageAdv2.Location = New System.Drawing.Point(120, 1)
        Me.tabPageAdv2.Name = "tabPageAdv2"
        Me.tabPageAdv2.Size = New System.Drawing.Size(326, 315)
        Me.tabPageAdv2.TabIndex = 1
        Me.tabPageAdv2.Text = "Accounts"
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.SystemColors.Control
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label1.Location = New System.Drawing.Point(72, 64)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(152, 40)
        Me.label1.TabIndex = 0
        Me.label1.Text = "TabPage1"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabPageAdv1
        '
        Me.tabPageAdv1.BackColor = System.Drawing.Color.White
        Me.tabPageAdv1.Controls.AddRange(New System.Windows.Forms.Control() {Me.label2})
        Me.tabPageAdv1.ImageIndex = 2
        Me.tabPageAdv1.Location = New System.Drawing.Point(120, 1)
        Me.tabPageAdv1.Name = "tabPageAdv1"
        Me.tabPageAdv1.Size = New System.Drawing.Size(326, 315)
        Me.tabPageAdv1.TabIndex = 0
        Me.tabPageAdv1.Text = "Cases"
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.SystemColors.Control
        Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label2.Location = New System.Drawing.Point(72, 64)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(152, 40)
        Me.label2.TabIndex = 1
        Me.label2.Text = "TabPage2"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabPageAdv3
        '
        Me.tabPageAdv3.BackColor = System.Drawing.Color.White
        Me.tabPageAdv3.Controls.AddRange(New System.Windows.Forms.Control() {Me.label3})
        Me.tabPageAdv3.ImageIndex = 1
        Me.tabPageAdv3.Location = New System.Drawing.Point(120, 1)
        Me.tabPageAdv3.Name = "tabPageAdv3"
        Me.tabPageAdv3.Size = New System.Drawing.Size(326, 315)
        Me.tabPageAdv3.TabIndex = 2
        Me.tabPageAdv3.Text = "Contacts"
        '
        'label3
        '
        Me.label3.BackColor = System.Drawing.SystemColors.Control
        Me.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label3.Location = New System.Drawing.Point(72, 64)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(152, 40)
        Me.label3.TabIndex = 1
        Me.label3.Text = "TabPage3"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'xpTaskBar1
        '
        Me.xpTaskBar1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.xpTaskBar1.AutoPersistStates = True
        Me.xpTaskBar1.AutoScroll = True
        Me.xpTaskBar1.BackColor = System.Drawing.Color.Transparent
        Me.xpTaskBar1.Controls.AddRange(New System.Windows.Forms.Control() {Me.xpTaskBarBox1})
        Me.xpTaskBar1.DockPadding.All = 5
        Me.xpTaskBar1.Location = New System.Drawing.Point(0, 185)
        Me.xpTaskBar1.Name = "xpTaskBar1"
        Me.xpTaskBar1.Size = New System.Drawing.Size(120, 128)
        Me.xpTaskBar1.TabIndex = 1
        Me.xpTaskBar1.ThemesEnabled = True
        '
        'xpTaskBarBox1
        '
        Me.xpTaskBarBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel1})
        Me.xpTaskBarBox1.HeaderBackColor = System.Drawing.SystemColors.Desktop
        Me.xpTaskBarBox1.HeaderImageIndex = 3
        Me.xpTaskBarBox1.HeaderImageList = Me.ImageList2
        Me.xpTaskBarBox1.ItemBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.xpTaskBarBox1.Location = New System.Drawing.Point(5, 5)
        Me.xpTaskBarBox1.Name = "xpTaskBarBox1"
        Me.xpTaskBarBox1.PreferredChildPanelHeight = 60
        Me.xpTaskBarBox1.Size = New System.Drawing.Size(110, 106)
        Me.xpTaskBarBox1.TabIndex = 0
        Me.xpTaskBarBox1.Text = "Search"
        '
        'panel1
        '
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.button1, Me.comboBox1})
        Me.panel1.Location = New System.Drawing.Point(2, 44)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(106, 60)
        Me.panel1.TabIndex = 0
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.Location = New System.Drawing.Point(32, 32)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(40, 24)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Go"
        '
        'comboBox1
        '
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Items.AddRange(New Object() {"Search1", "Search2", "Search3"})
        Me.comboBox1.Location = New System.Drawing.Point(8, 8)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(90, 21)
        Me.comboBox1.TabIndex = 0
        '
        'designTimeTabTypeLoader
        '
        Me.designTimeTabTypeLoader.TypesToLoadList.Add(New Syncfusion.Reflection.TypeName("FlatTabs.FlatTabRenderer"))
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 318)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.xpTaskBar1, Me.flatTab1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Flat Tabs"
        CType(Me.flatTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flatTab1.ResumeLayout(False)
        Me.tabPageAdv2.ResumeLayout(False)
        Me.tabPageAdv1.ResumeLayout(False)
        Me.tabPageAdv3.ResumeLayout(False)
        CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xpTaskBar1.ResumeLayout(False)
        Me.xpTaskBarBox1.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    <STAThread()> _
    Public Shared Sub Main()

        Application.Run(New Form1)

    End Sub
    Private Sub Form1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        If Me.ClientSize.Height <= 0 Or Me.ClientSize.Width <= 0 Then
            Return
        End If
        Dim lgb As LinearGradientBrush
        lgb = New LinearGradientBrush(Me.ClientRectangle, SystemColors.Control, SystemColors.ControlDark, LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(lgb, Me.ClientRectangle)

    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click

    End Sub
End Class

