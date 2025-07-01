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

Namespace LayoutManagers
    Public Class NonControlBasedComponents
        Inherits Form
        Private components As IContainer
        Private WithEvents myRect1 As MyRectangle
        Private WithEvents myRect2 As MyRectangle
        Private WithEvents gridBagLayout1 As GridBagLayout
        Private WithEvents panel1 As MyPanel
        Private WithEvents myRect3 As MyRectangle
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
        Friend WithEvents GradientLabel1 As Syncfusion.Windows.Forms.Tools.GradientLabel
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(NonControlBasedComponents))
            Me.gridBagLayout1 = New Syncfusion.Windows.Forms.Tools.GridBagLayout(Me.components)
            Me.panel1 = New layoutmanagerclient.LayoutManagers.MyPanel()
            Me.GradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
            CType(Me.gridBagLayout1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridBagLayout1
            '
            Me.gridBagLayout1.ContainerControl = Me.panel1
            '
            'panel1
            '
            Me.panel1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Location = New System.Drawing.Point(8, 48)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(520, 228)
            Me.panel1.TabIndex = 0
            '
            'GradientLabel1
            '
            Me.GradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(237, Byte), CType(240, Byte), CType(247, Byte)), System.Drawing.Color.FromArgb(CType(182, Byte), CType(211, Byte), CType(241, Byte)))
            Me.GradientLabel1.BorderSides = (((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) _
                        Or System.Windows.Forms.Border3DSide.Right) _
                        Or System.Windows.Forms.Border3DSide.Bottom)
            Me.GradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.GradientLabel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GradientLabel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GradientLabel1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.GradientLabel1.Name = "GradientLabel1"
            Me.GradientLabel1.Size = New System.Drawing.Size(536, 40)
            Me.GradientLabel1.TabIndex = 2
            Me.GradientLabel1.Text = "3 Non-Control, LayoutItemBase derived objects being laid out:"
            Me.GradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'NonControlBasedComponents
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(105, Byte), CType(112, Byte), CType(156, Byte))
            Me.ClientSize = New System.Drawing.Size(536, 285)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GradientLabel1, Me.panel1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "NonControlBasedComponents"
            Me.Text = "Laying out Non-Control derived components"
            CType(Me.gridBagLayout1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        ' <samplecodeblock name="Initializing LayoutItemBase derived class">
        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Me.SuspendLayout()
            ' Current layout manager (Update every time you change the manager)
            ' Layout Component 1
            Me.myRect1 = New MyRectangle(Me.gridBagLayout1.ContainerControl, Color.FromArgb(133, 191, 117), "Paint Area 1")
            Me.myRect1.Bounds = New Rectangle(10, 10, 80, 20)
            Me.myRect1.Visible = True
            ' Layout Component 2
            Me.myRect2 = New MyRectangle(Me.gridBagLayout1.ContainerControl, Color.FromArgb(222, 100, 19), "Paint Area 2")
            Me.myRect2.Bounds = New Rectangle(10, 40, 80, 20)
            Me.myRect2.Visible = True
            ' Layout Component 3
            Me.myRect3 = New MyRectangle(Me.gridBagLayout1.ContainerControl, Color.FromArgb(196, 214, 233), "Paint Area 3")
            Me.myRect3.Bounds = New Rectangle(10, 70, 80, 20)
            Me.myRect3.Visible = True
            ' Sample GridBagConstraints
            Dim gbc1 As GridBagConstraints
            gbc1 = New GridBagConstraints()
            Dim gbc2 As GridBagConstraints
            gbc2 = New GridBagConstraints()
            Dim gbc3 As GridBagConstraints
            gbc3 = New GridBagConstraints()
            gbc1.Fill = FillType.Both
            gbc1.WeightX = 0.2
            gbc1.WeightY = 0.5
            gbc1.GridPosX = 0
            gbc1.GridPosY = 0
            gbc2.Fill = FillType.Both
            gbc2.WeightX = 0.2
            gbc2.WeightY = 0.5
            gbc2.GridPosX = 1
            gbc2.GridPosY = 0
            gbc3.Fill = FillType.Both
            gbc3.WeightX = 0.4
            gbc3.WeightY = 0.5
            gbc3.GridPosX = 0
            gbc3.GridPosY = 1
            gbc3.CellSpanX = 2
            ' Add all the components that are to participate in Layout Management
            ' For GridBagLayouts pass gbcs for GridBagLayouts
            Me.gridBagLayout1.SetConstraints(Me.myRect1.ToControl, gbc1)
            Me.gridBagLayout1.SetConstraints(Me.myRect2.ToControl, gbc2)
            Me.gridBagLayout1.SetConstraints(Me.myRect3.ToControl, gbc3)
            Me.ResumeLayout(True)

        End Sub
        '</samplecodeblock>

        Private Sub Panel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panel1.Paint

            If (Me.myRect1.Bounds.IntersectsWith(e.ClipRectangle) AndAlso Me.myRect1.Visible) Then
                myRect1.OnPaint(e)
            End If
            If (Me.myRect2.Bounds.IntersectsWith(e.ClipRectangle) AndAlso Me.myRect2.Visible) Then
                myRect2.OnPaint(e)
            End If
            If (Me.myRect3.Bounds.IntersectsWith(e.ClipRectangle) AndAlso Me.myRect3.Visible) Then
                myRect3.OnPaint(e)
            End If

        End Sub
    End Class

    Public Class MyPanel
        Inherits Panel

        Public Sub New()
            MyBase.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        End Sub
    End Class
End Namespace
