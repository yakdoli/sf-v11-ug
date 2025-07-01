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
Imports System.Drawing.Drawing2D
Imports System.Resources
Imports System.Windows.Forms

Namespace CustomTabControls
    Public Class Form1
        Inherits Form
        Private WithEvents tabControlExt1 As TabControlAdv
        Private WithEvents tabPageExt1 As TabPageAdv
        Private WithEvents tabPageExt2 As TabPageAdv
        Private WithEvents tabPageExt3 As TabPageAdv
        Private WithEvents label1 As Label
        Private WithEvents comboBox1 As ComboBox
        Private WithEvents propertyGrid1 As PropertyGrid
        Private WithEvents imageList1 As ImageList
        Private WithEvents button1 As Button
        Private WithEvents button2 As Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
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

        End Sub
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)

            If disposing Then
                If (Not (components) Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)

        End Sub
        Friend WithEvents GradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.tabControlExt1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv
            Me.tabPageExt1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.button2 = New System.Windows.Forms.Button
            Me.button1 = New System.Windows.Forms.Button
            Me.tabPageExt2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.tabPageExt3 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.label1 = New System.Windows.Forms.Label
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
            Me.GradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.Panel1 = New System.Windows.Forms.Panel
            CType(Me.tabControlExt1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControlExt1.SuspendLayout()
            Me.tabPageExt1.SuspendLayout()
            CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GradientPanel1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'tabControlExt1
            '
            Me.tabControlExt1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tabControlExt1.BackColor = System.Drawing.Color.White
            Me.tabControlExt1.Controls.Add(Me.tabPageExt1)
            Me.tabControlExt1.Controls.Add(Me.tabPageExt2)
            Me.tabControlExt1.Controls.Add(Me.tabPageExt3)
            Me.tabControlExt1.FocusOnTabClick = False
            Me.tabControlExt1.ImageList = Me.imageList1
            Me.tabControlExt1.ItemSize = New System.Drawing.Size(80, 30)
            Me.tabControlExt1.Location = New System.Drawing.Point(15, 12)
            Me.tabControlExt1.Name = "tabControlExt1"
            Me.tabControlExt1.Size = New System.Drawing.Size(314, 177)
            Me.tabControlExt1.TabIndex = 0
            Me.tabControlExt1.TabPanelBackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(241, Byte), Integer))
            '
            'tabPageExt1
            '
            Me.tabPageExt1.Controls.Add(Me.button2)
            Me.tabPageExt1.Controls.Add(Me.button1)
            Me.tabPageExt1.ImageIndex = 0
            Me.tabPageExt1.Location = New System.Drawing.Point(1, 33)
            Me.tabPageExt1.Name = "tabPageExt1"
            Me.tabPageExt1.Size = New System.Drawing.Size(311, 142)
            Me.tabPageExt1.TabIndex = 1
            Me.tabPageExt1.ThemesEnabled = False
            '
            'button2
            '
            Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(241, Byte), Integer))
            Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button2.Location = New System.Drawing.Point(48, 80)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(168, 32)
            Me.button2.TabIndex = 1
            Me.button2.Text = "Show Custom Tab: Flat Look"
            Me.button2.UseVisualStyleBackColor = False
            '
            'button1
            '
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(241, Byte), Integer))
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button1.Location = New System.Drawing.Point(48, 24)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(168, 32)
            Me.button1.TabIndex = 0
            Me.button1.Text = "Show Custom Tab: Notched"
            Me.button1.UseVisualStyleBackColor = False
            '
            'tabPageExt2
            '
            Me.tabPageExt2.ImageIndex = 1
            Me.tabPageExt2.Location = New System.Drawing.Point(1, 33)
            Me.tabPageExt2.Name = "tabPageExt2"
            Me.tabPageExt2.Size = New System.Drawing.Size(311, 142)
            Me.tabPageExt2.TabIndex = 1
            Me.tabPageExt2.ThemesEnabled = False
            '
            'tabPageExt3
            '
            Me.tabPageExt3.ImageIndex = 2
            Me.tabPageExt3.Location = New System.Drawing.Point(1, 33)
            Me.tabPageExt3.Name = "tabPageExt3"
            Me.tabPageExt3.Size = New System.Drawing.Size(311, 142)
            Me.tabPageExt3.TabIndex = 2
            Me.tabPageExt3.ThemesEnabled = False
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
            Me.imageList1.Images.SetKeyName(2, "")
            Me.imageList1.Images.SetKeyName(3, "")
            Me.imageList1.Images.SetKeyName(4, "")
            Me.imageList1.Images.SetKeyName(5, "")
            '
            'label1
            '
            Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(241, Byte), Integer))
            Me.label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Location = New System.Drawing.Point(15, 8)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(288, 32)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Custom Tab Appearances via DrawItem handler:"
            '
            'comboBox1
            '
            Me.comboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.Items.AddRange(New Object() {"Yahoo Messenger Like", "MSN Like"})
            Me.comboBox1.Location = New System.Drawing.Point(15, 48)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(136, 21)
            Me.comboBox1.TabIndex = 2
            '
            'propertyGrid1
            '
            Me.propertyGrid1.BackColor = System.Drawing.Color.White
            Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.White
            Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right
            Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
            Me.propertyGrid1.Location = New System.Drawing.Point(336, 0)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.Size = New System.Drawing.Size(208, 302)
            Me.propertyGrid1.TabIndex = 3
            '
            'GradientPanel1
            '
            Me.GradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(241, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(241, Byte), Integer)))
            Me.GradientPanel1.BorderColor = System.Drawing.Color.Black
            Me.GradientPanel1.Controls.Add(Me.Panel1)
            Me.GradientPanel1.Controls.Add(Me.comboBox1)
            Me.GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GradientPanel1.Location = New System.Drawing.Point(0, 0)
            Me.GradientPanel1.Name = "GradientPanel1"
            Me.GradientPanel1.Size = New System.Drawing.Size(544, 302)
            Me.GradientPanel1.TabIndex = 4
            '
            'Panel1
            '
            Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Panel1.BackColor = System.Drawing.Color.Transparent
            Me.Panel1.Controls.Add(Me.tabControlExt1)
            Me.Panel1.Location = New System.Drawing.Point(-2, 84)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(337, 216)
            Me.Panel1.TabIndex = 5
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(544, 302)
            Me.Controls.Add(Me.propertyGrid1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.GradientPanel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.Text = "Custom Tab Controls"
            CType(Me.tabControlExt1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControlExt1.ResumeLayout(False)
            Me.tabPageExt1.ResumeLayout(False)
            CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GradientPanel1.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        <STAThread()> _
        Public Shared Sub Main()

            Application.Run(New Form1())

        End Sub
        ' In Yahoo Messenger(R) like look and feel, the active tab is the only tab
        ' that gets a border around it, the rest of the tabs are border less.
        ' This can be easily achieved by setting the TabStyle to
        ' "3D" (typeof(TabRenderer3D), handling the DrawItem event, delegating the
        ' background and interior drawing to the default drawing logic and delegating
        ' the border drawing logic to the default drawing logic only if the corresponding
        ' tab is active.
        Private Sub Tab_DrawItemYahooMessengerLike(ByVal sender As Object, ByVal drawItemInfo As DrawTabEventArgs)

            ' This will work only when the TabStyle is set to 3D (typeof(TabRenderer3D))
            ' Draw the default background and interior in all cases.
            drawItemInfo.DrawBackground()
            drawItemInfo.DrawInterior()
            ' The border should be drawn only when the item is selected or highlighted.
            If ((CType(drawItemInfo.State, Integer) _
                        And (CType(DrawItemState.Selected, Integer) Or CType(DrawItemState.HotLight, Integer))) _
                        > 0) Then
                ' Draw the borders
                drawItemInfo.DrawBorders()
            End If

        End Sub
        ' <samplecodeblock name="Custom Tab Drawing">
        ' The TabControlAdv.DrawItem event handler.
        Private Sub Tab_DrawItemMSNMessengerLike(ByVal sender As Object, ByVal drawItemInfo As DrawTabEventArgs)

            Dim rectTab As Rectangle
            rectTab = drawItemInfo.Bounds
            Dim g As Graphics
            g = drawItemInfo.Graphics
            g.SmoothingMode = SmoothingMode.AntiAlias
            ' Create a path for the border
            Dim gp As GraphicsPath
            gp = New GraphicsPath()
            gp.AddBezier((rectTab.Right - 1), (rectTab.Bottom + 6), (rectTab.Right - 1), (rectTab.Bottom + 2), rectTab.Left, (rectTab.Bottom - 3), rectTab.Left, (rectTab.Bottom - 7))
            gp.AddLine(rectTab.Left, (rectTab.Bottom - 4), rectTab.Left, (rectTab.Top + 5))
            Dim curvePoints1() As System.Drawing.Point
            curvePoints1 = New System.Drawing.Point() {New System.Drawing.Point(rectTab.Left, (rectTab.Top + 5)), New System.Drawing.Point((rectTab.Left + 2), (rectTab.Top + 2)), New System.Drawing.Point((rectTab.Left + 3), (rectTab.Top + 1)), New System.Drawing.Point((rectTab.Left + 5), rectTab.Top)}
            gp.AddCurve(curvePoints1)
            gp.AddBezier(curvePoints1(0), curvePoints1(1), curvePoints1(2), curvePoints1(3))
            gp.AddLine(curvePoints1(3), New System.Drawing.Point((rectTab.Right - 6), rectTab.Top))
            Dim curvePoints2() As System.Drawing.Point
            curvePoints2 = New System.Drawing.Point() {New System.Drawing.Point((rectTab.Right - 6), rectTab.Top), New System.Drawing.Point((rectTab.Right - 2), (rectTab.Top - 1)), New System.Drawing.Point((rectTab.Right - 2), (rectTab.Top - 3)), New System.Drawing.Point((rectTab.Right - 1), (rectTab.Top - 5))}
            gp.AddCurve(curvePoints2)
            If ((CType(drawItemInfo.State, Integer) And CType(DrawItemState.Selected, Integer)) _
                        > 0) Then
                g.FillPath(New SolidBrush(drawItemInfo.BackColor), gp)
                drawItemInfo.DrawInterior()
            Else
                ' Draw the Text and Image first
                drawItemInfo.DrawInterior()
                ' Then alpha blend active tab color over it
                g.FillPath(New SolidBrush(Color.FromArgb(128, Me.tabControlExt1.ActiveTabColor)), gp)
            End If

        End Sub
        ' </samplecodeblock>
        Private Sub tabControlExt1_DrawItem(ByVal sender As System.Object, ByVal drawItemInfo As Syncfusion.Windows.Forms.Tools.DrawTabEventArgs) Handles tabControlExt1.DrawItem

            drawItemInfo.DrawBackground()
            drawItemInfo.DrawInterior()
            Select Case Me.comboBox1.SelectedIndex
                Case 0
                    Me.Tab_DrawItemYahooMessengerLike(sender, drawItemInfo)
                    'End Section
                Case 1
                    Me.Tab_DrawItemMSNMessengerLike(sender, drawItemInfo)
                    'End Section
            End Select

        End Sub
        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged

            ' Yahoo-Messenger like
            Select Case Me.comboBox1.SelectedIndex
                Case 0
                    Me.tabControlExt1.TabStyle = GetType(TabRenderer3D)
                    Me.tabControlExt1.Alignment = TabAlignment.Bottom
                    'Resetting MSN like settings
                    Me.tabControlExt1.SizeMode = Syncfusion.Windows.Forms.Tools.TabSizeMode.Normal
                    Me.tabControlExt1.BackColor = Color.White
                    Me.tabControlExt1.ActiveTabColor = Me.tabControlExt1.BackColor
                    Me.tabControlExt1.TabPanelBackColor = Color.FromArgb(183, 212, 241)
                    Me.tabControlExt1.TabGap = 0
                    'End Section
                    ' MSN Messenger like
                Case 1
                    Me.tabControlExt1.TabStyle = GetType(TabRenderer3D)
                    Me.tabControlExt1.Alignment = TabAlignment.Left
                    Me.tabControlExt1.ItemSize = New System.Drawing.Size(50, 50)
                    Me.tabControlExt1.SizeMode = Syncfusion.Windows.Forms.Tools.TabSizeMode.Fixed
                    Me.tabControlExt1.ActiveTabColor = Color.White
                    Me.tabControlExt1.TabPanelBackColor = Color.FromArgb(183, 212, 241)
                    Me.tabControlExt1.TabGap = 10
                    'End Section
            End Select

        End Sub
        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Me.comboBox1.SelectedIndex = 1
            Me.comboBox1.SelectedIndex = 0
            Me.propertyGrid1.SelectedObject = Me.tabControlExt1

        End Sub
        Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click

            Dim form2 As Form2
            form2 = New Form2()
            form2.Visible = True

        End Sub
        Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click

            Dim form3 As Form3
            form3 = New Form3()
            form3.Visible = True

        End Sub

        Private Sub tabPageExt3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabPageExt3.Click

        End Sub
    End Class
End Namespace
