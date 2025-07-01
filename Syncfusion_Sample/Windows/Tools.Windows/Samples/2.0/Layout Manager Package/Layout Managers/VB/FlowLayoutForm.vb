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
    Public Class FlowLayoutForm
        Inherits Form
        Private WithEvents panel1 As Panel
        Private WithEvents propertyGrid1 As PropertyGrid
        Private WithEvents label1 As Label
        Private WithEvents label2 As Label
        Private WithEvents label3 As Label
        Private WithEvents label4 As Label
        Private WithEvents label5 As Label
        Private WithEvents label6 As Label
        Private WithEvents label7 As Label
        Private WithEvents label8 As Label
        Private WithEvents label9 As Label
        Private WithEvents label10 As Label
        Private WithEvents flowLayout1 As FlowLayout
        Private WithEvents label13 As Label
        Private WithEvents label14 As Label
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
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FlowLayoutForm))
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label10 = New System.Windows.Forms.Label()
            Me.label9 = New System.Windows.Forms.Label()
            Me.label8 = New System.Windows.Forms.Label()
            Me.label7 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.label5 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label13 = New System.Windows.Forms.Label()
            Me.label14 = New System.Windows.Forms.Label()
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
            Me.flowLayout1 = New Syncfusion.Windows.Forms.Tools.FlowLayout(Me.components)
            Me.GradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
            Me.panel1.SuspendLayout()
            CType(Me.flowLayout1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.label1, Me.label10, Me.label9, Me.label8, Me.label7, Me.label6, Me.label5, Me.label4, Me.label3, Me.label2, Me.label13, Me.label14})
            Me.panel1.Location = New System.Drawing.Point(8, 50)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(352, 272)
            Me.panel1.TabIndex = 0
            '
            'label1
            '
            Me.label1.Image = CType(resources.GetObject("label1.Image"), System.Drawing.Bitmap)
            Me.label1.Location = New System.Drawing.Point(20, 4)
            Me.flowLayout1.SetMinimumSize(Me.label1, New System.Drawing.Size(64, 56))
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(40, 40)
            Me.label1.TabIndex = 4
            '
            'label10
            '
            Me.label10.Image = CType(resources.GetObject("label10.Image"), System.Drawing.Bitmap)
            Me.label10.Location = New System.Drawing.Point(65, 4)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(40, 40)
            Me.label10.TabIndex = 13
            '
            'label9
            '
            Me.label9.Image = CType(resources.GetObject("label9.Image"), System.Drawing.Bitmap)
            Me.label9.Location = New System.Drawing.Point(110, 4)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(40, 40)
            Me.label9.TabIndex = 12
            '
            'label8
            '
            Me.label8.Image = CType(resources.GetObject("label8.Image"), System.Drawing.Bitmap)
            Me.label8.Location = New System.Drawing.Point(155, 4)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(40, 40)
            Me.label8.TabIndex = 11
            '
            'label7
            '
            Me.label7.Image = CType(resources.GetObject("label7.Image"), System.Drawing.Bitmap)
            Me.label7.Location = New System.Drawing.Point(200, 4)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(40, 40)
            Me.label7.TabIndex = 10
            '
            'label6
            '
            Me.label6.Image = CType(resources.GetObject("label6.Image"), System.Drawing.Bitmap)
            Me.label6.Location = New System.Drawing.Point(245, 4)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(40, 40)
            Me.label6.TabIndex = 9
            '
            'label5
            '
            Me.label5.Image = CType(resources.GetObject("label5.Image"), System.Drawing.Bitmap)
            Me.label5.Location = New System.Drawing.Point(290, 4)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(40, 40)
            Me.label5.TabIndex = 8
            '
            'label4
            '
            Me.label4.Image = CType(resources.GetObject("label4.Image"), System.Drawing.Bitmap)
            Me.label4.Location = New System.Drawing.Point(15, 49)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(60, 60)
            Me.label4.TabIndex = 7
            '
            'label3
            '
            Me.label3.Image = CType(resources.GetObject("label3.Image"), System.Drawing.Bitmap)
            Me.label3.Location = New System.Drawing.Point(80, 49)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(60, 60)
            Me.label3.TabIndex = 6
            '
            'label2
            '
            Me.label2.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.label2.Image = CType(resources.GetObject("label2.Image"), System.Drawing.Bitmap)
            Me.label2.Location = New System.Drawing.Point(145, 49)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(60, 60)
            Me.label2.TabIndex = 5
            '
            'label13
            '
            Me.label13.Image = CType(resources.GetObject("label13.Image"), System.Drawing.Bitmap)
            Me.label13.Location = New System.Drawing.Point(210, 49)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(60, 60)
            Me.label13.TabIndex = 14
            '
            'label14
            '
            Me.label14.Image = CType(resources.GetObject("label14.Image"), System.Drawing.Bitmap)
            Me.label14.Location = New System.Drawing.Point(275, 49)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(60, 60)
            Me.label14.TabIndex = 15
            '
            'propertyGrid1
            '
            Me.propertyGrid1.BackColor = System.Drawing.SystemColors.Control
            Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.WhiteSmoke
            Me.propertyGrid1.CommandsVisibleIfAvailable = True
            Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right
            Me.propertyGrid1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.propertyGrid1.LargeButtons = False
            Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
            Me.propertyGrid1.Location = New System.Drawing.Point(368, 0)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.Size = New System.Drawing.Size(208, 333)
            Me.propertyGrid1.TabIndex = 1
            Me.propertyGrid1.Text = "propertyGrid1"
            Me.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window
            Me.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText
            '
            'flowLayout1
            '
            Me.flowLayout1.BottomMargin = 4
            Me.flowLayout1.ContainerControl = Me.panel1
            Me.flowLayout1.HorzFarMargin = 4
            Me.flowLayout1.HorzNearMargin = 4
            Me.flowLayout1.TopMargin = 4
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
            Me.GradientLabel1.Size = New System.Drawing.Size(368, 40)
            Me.GradientLabel1.TabIndex = 2
            Me.GradientLabel1.Text = "Images arranged using FlowLayout"
            Me.GradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'FlowLayoutForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(105, Byte), CType(112, Byte), CType(156, Byte))
            Me.ClientSize = New System.Drawing.Size(576, 333)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GradientLabel1, Me.propertyGrid1, Me.panel1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "FlowLayoutForm"
            Me.Text = "FlowLayout"
            Me.panel1.ResumeLayout(False)
            CType(Me.flowLayout1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private Sub FlowLayoutForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Me.propertyGrid1.SelectedObject = Me.flowLayout1
            ' Sample Code Block to illustrate initialization without designer.
            ' Repeats whatever the deisgner already did in InitializeComponent.
            '
            If (False) Then
                '// <samplecodeblock name="Initializing FlowLayout">
                '' Binding a Control to the FlowLayout manager programaitcally
                'Me.flowLayout1 = New FlowLayout()

                '' Set the target control; all the child controls of this target control are
                '' automatically registered as children with the manager.
                'Me.flowLayout1.ContainerControl = Me.panel1

                '' Set some properties on the flowLayout manager:
                'Me.flowLayout1.HGap = 20
                'Me.flowLayout1.Alignment = FlowAlignment.Near

                '' You can ignore one or more child Control from being laid out, like this:
                '' This will have the same effect as calling RemoveLayoutComponent.
                'Me.flowLayout1.GetConstraintsRef(Me.label10).Active = False

                ' You can prevent automatic layout during the layout event:
                ' If you decide to do so, make sure to call flowLayout.LayoutContainer manually.
                ' this.flowLayout1.AutoLayout = false;</code></coderef>
                '// </samplecodeblock>
            End If
        End Sub
    End Class
End Namespace
