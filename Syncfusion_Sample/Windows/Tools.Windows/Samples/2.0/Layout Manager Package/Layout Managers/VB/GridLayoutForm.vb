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
    Public Class GridLayoutForm
        Inherits Form
        Private WithEvents panel1 As Panel
        Private WithEvents propertyGrid1 As PropertyGrid
        Private WithEvents gridLayout1 As GridLayout
        Private WithEvents outerPanel As Panel
        Private WithEvents textBox1 As TextBox
        Private WithEvents innerPanel As Panel
        Private WithEvents one As Button
        Private WithEvents button6 As Button
        Private WithEvents button7 As Button
        Private WithEvents button8 As Button
        Private WithEvents button9 As Button
        Private WithEvents button10 As Button
        Private WithEvents button11 As Button
        Private WithEvents button12 As Button
        Private WithEvents button13 As Button
        Private WithEvents button14 As Button
        Private WithEvents button15 As Button
        Private WithEvents button16 As Button
        Private WithEvents button17 As Button
        Private WithEvents button18 As Button
        Private WithEvents button19 As Button
        Private WithEvents button20 As Button
        Private WithEvents button1 As Button
        Private WithEvents button2 As Button
        Private WithEvents button3 As Button
        Private WithEvents button4 As Button
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
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(GridLayoutForm))
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.GradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
            Me.outerPanel = New System.Windows.Forms.Panel()
            Me.innerPanel = New System.Windows.Forms.Panel()
            Me.one = New System.Windows.Forms.Button()
            Me.button20 = New System.Windows.Forms.Button()
            Me.button19 = New System.Windows.Forms.Button()
            Me.button18 = New System.Windows.Forms.Button()
            Me.button17 = New System.Windows.Forms.Button()
            Me.button16 = New System.Windows.Forms.Button()
            Me.button15 = New System.Windows.Forms.Button()
            Me.button14 = New System.Windows.Forms.Button()
            Me.button13 = New System.Windows.Forms.Button()
            Me.button12 = New System.Windows.Forms.Button()
            Me.button11 = New System.Windows.Forms.Button()
            Me.button10 = New System.Windows.Forms.Button()
            Me.button9 = New System.Windows.Forms.Button()
            Me.button8 = New System.Windows.Forms.Button()
            Me.button7 = New System.Windows.Forms.Button()
            Me.button6 = New System.Windows.Forms.Button()
            Me.button1 = New System.Windows.Forms.Button()
            Me.button4 = New System.Windows.Forms.Button()
            Me.button3 = New System.Windows.Forms.Button()
            Me.button2 = New System.Windows.Forms.Button()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
            Me.gridLayout1 = New Syncfusion.Windows.Forms.Tools.GridLayout(Me.components)
            Me.panel1.SuspendLayout()
            Me.outerPanel.SuspendLayout()
            Me.innerPanel.SuspendLayout()
            CType(Me.gridLayout1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.GradientLabel1, Me.outerPanel})
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(360, 325)
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
            Me.GradientLabel1.Size = New System.Drawing.Size(360, 48)
            Me.GradientLabel1.TabIndex = 2
            Me.GradientLabel1.Text = "A Quick and Dirty Calculator using GridLayout"
            Me.GradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'outerPanel
            '
            Me.outerPanel.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.outerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.outerPanel.Controls.AddRange(New System.Windows.Forms.Control() {Me.innerPanel, Me.textBox1})
            Me.outerPanel.Location = New System.Drawing.Point(40, 72)
            Me.outerPanel.Name = "outerPanel"
            Me.outerPanel.Size = New System.Drawing.Size(274, 210)
            Me.outerPanel.TabIndex = 1
            '
            'innerPanel
            '
            Me.innerPanel.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.innerPanel.Controls.AddRange(New System.Windows.Forms.Control() {Me.one, Me.button20, Me.button19, Me.button18, Me.button17, Me.button16, Me.button15, Me.button14, Me.button13, Me.button12, Me.button11, Me.button10, Me.button9, Me.button8, Me.button7, Me.button6, Me.button1, Me.button4, Me.button3, Me.button2})
            Me.innerPanel.DockPadding.All = 10
            Me.innerPanel.Location = New System.Drawing.Point(2, 24)
            Me.innerPanel.Name = "innerPanel"
            Me.innerPanel.Size = New System.Drawing.Size(266, 186)
            Me.innerPanel.TabIndex = 1
            '
            'one
            '
            Me.one.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.one.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.one.ForeColor = System.Drawing.Color.Black
            Me.one.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.one.Location = New System.Drawing.Point(5, 5)
            Me.gridLayout1.SetMinimumSize(Me.one, New System.Drawing.Size(33, 33))
            Me.one.Name = "one"
            Me.gridLayout1.SetParticipateInLayout(Me.one, True)
            Me.gridLayout1.SetPreferredSize(Me.one, New System.Drawing.Size(43, 33))
            Me.one.Size = New System.Drawing.Size(61, 32)
            Me.one.TabIndex = 0
            Me.one.Text = "1"
            '
            'button20
            '
            Me.button20.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button20.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button20.ForeColor = System.Drawing.Color.Black
            Me.button20.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button20.Location = New System.Drawing.Point(70, 5)
            Me.gridLayout1.SetMinimumSize(Me.button20, New System.Drawing.Size(43, 33))
            Me.button20.Name = "button20"
            Me.gridLayout1.SetParticipateInLayout(Me.button20, True)
            Me.gridLayout1.SetPreferredSize(Me.button20, New System.Drawing.Size(43, 33))
            Me.button20.Size = New System.Drawing.Size(61, 32)
            Me.button20.TabIndex = 2
            Me.button20.Text = "2"
            '
            'button19
            '
            Me.button19.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button19.ForeColor = System.Drawing.Color.Black
            Me.button19.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button19.Location = New System.Drawing.Point(135, 5)
            Me.button19.Name = "button19"
            Me.gridLayout1.SetParticipateInLayout(Me.button19, True)
            Me.gridLayout1.SetPreferredSize(Me.button19, New System.Drawing.Size(43, 33))
            Me.button19.Size = New System.Drawing.Size(61, 32)
            Me.button19.TabIndex = 3
            Me.button19.Text = "3"
            '
            'button18
            '
            Me.button18.BackColor = System.Drawing.Color.Brown
            Me.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button18.ForeColor = System.Drawing.Color.White
            Me.button18.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button18.Location = New System.Drawing.Point(200, 5)
            Me.button18.Name = "button18"
            Me.gridLayout1.SetParticipateInLayout(Me.button18, True)
            Me.gridLayout1.SetPreferredSize(Me.button18, New System.Drawing.Size(43, 33))
            Me.button18.Size = New System.Drawing.Size(61, 32)
            Me.button18.TabIndex = 12
            Me.button18.Text = "="
            '
            'button17
            '
            Me.button17.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button17.ForeColor = System.Drawing.Color.Black
            Me.button17.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button17.Location = New System.Drawing.Point(5, 41)
            Me.button17.Name = "button17"
            Me.gridLayout1.SetParticipateInLayout(Me.button17, True)
            Me.gridLayout1.SetPreferredSize(Me.button17, New System.Drawing.Size(43, 33))
            Me.button17.Size = New System.Drawing.Size(61, 32)
            Me.button17.TabIndex = 4
            Me.button17.Text = "4"
            '
            'button16
            '
            Me.button16.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button16.ForeColor = System.Drawing.Color.Black
            Me.button16.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button16.Location = New System.Drawing.Point(70, 41)
            Me.button16.Name = "button16"
            Me.gridLayout1.SetParticipateInLayout(Me.button16, True)
            Me.gridLayout1.SetPreferredSize(Me.button16, New System.Drawing.Size(43, 33))
            Me.button16.Size = New System.Drawing.Size(61, 32)
            Me.button16.TabIndex = 5
            Me.button16.Text = "5"
            '
            'button15
            '
            Me.button15.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button15.ForeColor = System.Drawing.Color.Black
            Me.button15.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button15.Location = New System.Drawing.Point(135, 41)
            Me.gridLayout1.SetMinimumSize(Me.button15, New System.Drawing.Size(43, 33))
            Me.button15.Name = "button15"
            Me.gridLayout1.SetParticipateInLayout(Me.button15, True)
            Me.gridLayout1.SetPreferredSize(Me.button15, New System.Drawing.Size(43, 33))
            Me.button15.Size = New System.Drawing.Size(61, 32)
            Me.button15.TabIndex = 6
            Me.button15.Text = "6"
            '
            'button14
            '
            Me.button14.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button14.ForeColor = System.Drawing.Color.Black
            Me.button14.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button14.Location = New System.Drawing.Point(200, 41)
            Me.button14.Name = "button14"
            Me.gridLayout1.SetParticipateInLayout(Me.button14, True)
            Me.button14.Size = New System.Drawing.Size(61, 32)
            Me.button14.TabIndex = 13
            Me.button14.Text = "+"
            '
            'button13
            '
            Me.button13.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button13.ForeColor = System.Drawing.Color.Black
            Me.button13.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button13.Location = New System.Drawing.Point(5, 77)
            Me.button13.Name = "button13"
            Me.gridLayout1.SetParticipateInLayout(Me.button13, True)
            Me.gridLayout1.SetPreferredSize(Me.button13, New System.Drawing.Size(43, 33))
            Me.button13.Size = New System.Drawing.Size(61, 32)
            Me.button13.TabIndex = 7
            Me.button13.Text = "7"
            '
            'button12
            '
            Me.button12.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button12.ForeColor = System.Drawing.Color.Black
            Me.button12.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button12.Location = New System.Drawing.Point(70, 77)
            Me.button12.Name = "button12"
            Me.gridLayout1.SetParticipateInLayout(Me.button12, True)
            Me.gridLayout1.SetPreferredSize(Me.button12, New System.Drawing.Size(43, 33))
            Me.button12.Size = New System.Drawing.Size(61, 32)
            Me.button12.TabIndex = 8
            Me.button12.Text = "8"
            '
            'button11
            '
            Me.button11.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button11.ForeColor = System.Drawing.Color.Black
            Me.button11.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button11.Location = New System.Drawing.Point(135, 77)
            Me.button11.Name = "button11"
            Me.gridLayout1.SetParticipateInLayout(Me.button11, True)
            Me.gridLayout1.SetPreferredSize(Me.button11, New System.Drawing.Size(43, 33))
            Me.button11.Size = New System.Drawing.Size(61, 32)
            Me.button11.TabIndex = 9
            Me.button11.Text = "9"
            '
            'button10
            '
            Me.button10.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button10.ForeColor = System.Drawing.Color.Black
            Me.button10.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button10.Location = New System.Drawing.Point(200, 77)
            Me.button10.Name = "button10"
            Me.gridLayout1.SetParticipateInLayout(Me.button10, True)
            Me.button10.Size = New System.Drawing.Size(61, 32)
            Me.button10.TabIndex = 14
            Me.button10.Text = "-"
            '
            'button9
            '
            Me.button9.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button9.ForeColor = System.Drawing.Color.Black
            Me.button9.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button9.Location = New System.Drawing.Point(5, 113)
            Me.button9.Name = "button9"
            Me.gridLayout1.SetParticipateInLayout(Me.button9, True)
            Me.gridLayout1.SetPreferredSize(Me.button9, New System.Drawing.Size(43, 33))
            Me.button9.Size = New System.Drawing.Size(61, 32)
            Me.button9.TabIndex = 10
            Me.button9.Text = "0"
            '
            'button8
            '
            Me.button8.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button8.ForeColor = System.Drawing.Color.Black
            Me.button8.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button8.Location = New System.Drawing.Point(70, 113)
            Me.button8.Name = "button8"
            Me.gridLayout1.SetParticipateInLayout(Me.button8, True)
            Me.gridLayout1.SetPreferredSize(Me.button8, New System.Drawing.Size(43, 33))
            Me.button8.Size = New System.Drawing.Size(61, 32)
            Me.button8.TabIndex = 11
            Me.button8.Text = "."
            '
            'button7
            '
            Me.button7.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button7.ForeColor = System.Drawing.Color.Black
            Me.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button7.Location = New System.Drawing.Point(135, 113)
            Me.button7.Name = "button7"
            Me.gridLayout1.SetParticipateInLayout(Me.button7, True)
            Me.button7.Size = New System.Drawing.Size(61, 32)
            Me.button7.TabIndex = 16
            Me.button7.Text = "C"
            '
            'button6
            '
            Me.button6.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button6.ForeColor = System.Drawing.Color.Black
            Me.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button6.Location = New System.Drawing.Point(200, 113)
            Me.button6.Name = "button6"
            Me.gridLayout1.SetParticipateInLayout(Me.button6, True)
            Me.gridLayout1.SetPreferredSize(Me.button6, New System.Drawing.Size(43, 33))
            Me.button6.Size = New System.Drawing.Size(61, 32)
            Me.button6.TabIndex = 15
            Me.button6.Text = "*"
            '
            'button1
            '
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.ForeColor = System.Drawing.Color.Brown
            Me.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button1.Location = New System.Drawing.Point(5, 149)
            Me.button1.Name = "button1"
            Me.gridLayout1.SetParticipateInLayout(Me.button1, True)
            Me.gridLayout1.SetPreferredSize(Me.button1, New System.Drawing.Size(43, 33))
            Me.button1.Size = New System.Drawing.Size(61, 32)
            Me.button1.TabIndex = 17
            Me.button1.Text = "MR"
            '
            'button4
            '
            Me.button4.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
            Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button4.ForeColor = System.Drawing.Color.Brown
            Me.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button4.Location = New System.Drawing.Point(70, 149)
            Me.button4.Name = "button4"
            Me.gridLayout1.SetParticipateInLayout(Me.button4, True)
            Me.gridLayout1.SetPreferredSize(Me.button4, New System.Drawing.Size(43, 33))
            Me.button4.Size = New System.Drawing.Size(61, 32)
            Me.button4.TabIndex = 18
            Me.button4.Text = "MC"
            '
            'button3
            '
            Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
            Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button3.ForeColor = System.Drawing.Color.Brown
            Me.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button3.Location = New System.Drawing.Point(135, 149)
            Me.button3.Name = "button3"
            Me.gridLayout1.SetParticipateInLayout(Me.button3, True)
            Me.button3.Size = New System.Drawing.Size(61, 32)
            Me.button3.TabIndex = 19
            Me.button3.Text = "M+"
            '
            'button2
            '
            Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
            Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button2.ForeColor = System.Drawing.Color.Black
            Me.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.button2.Location = New System.Drawing.Point(200, 149)
            Me.button2.Name = "button2"
            Me.gridLayout1.SetParticipateInLayout(Me.button2, True)
            Me.button2.Size = New System.Drawing.Size(61, 32)
            Me.button2.TabIndex = 20
            Me.button2.Text = "/"
            '
            'textBox1
            '
            Me.textBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(272, 20)
            Me.textBox1.TabIndex = 0
            Me.textBox1.Text = ""
            '
            'propertyGrid1
            '
            Me.propertyGrid1.CommandsVisibleIfAvailable = True
            Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right
            Me.propertyGrid1.LargeButtons = False
            Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
            Me.propertyGrid1.Location = New System.Drawing.Point(360, 0)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.Size = New System.Drawing.Size(232, 325)
            Me.propertyGrid1.TabIndex = 1
            Me.propertyGrid1.Text = "propertyGrid1"
            Me.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window
            Me.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText
            '
            'gridLayout1
            '
            Me.gridLayout1.BottomMargin = 4
            Me.gridLayout1.Columns = 3
            Me.gridLayout1.ContainerControl = Me.innerPanel
            Me.gridLayout1.HGap = 4
            Me.gridLayout1.HorzFarMargin = 4
            Me.gridLayout1.HorzNearMargin = 4
            Me.gridLayout1.Rows = 5
            Me.gridLayout1.TopMargin = 4
            Me.gridLayout1.VGap = 4
            '
            'GridLayoutForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(592, 325)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.propertyGrid1, Me.panel1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "GridLayoutForm"
            Me.Text = "GridLayout"
            Me.panel1.ResumeLayout(False)
            Me.outerPanel.ResumeLayout(False)
            Me.innerPanel.ResumeLayout(False)
            CType(Me.gridLayout1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private Sub GridLayoutForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Me.propertyGrid1.SelectedObject = Me.gridLayout1
            ' Sample Code Block to illustrate initialization without designer.
            ' Repeats whatever the deisgner already did in InitializeComponent.
            '
            ' <samplecodeblock name="Initializing GridLayout">
            If (False) Then
                ' Binding a Control to the GridLayout manager programaitcally
                Me.gridLayout1 = New Syncfusion.Windows.Forms.Tools.GridLayout()
                ' Set the target control; all the child controls of this target control are
                ' automatically registered as children with the manager.
                Me.gridLayout1.ContainerControl = Me.innerPanel
                ' Set some properties on the flowLayout manager:
                Me.gridLayout1.Columns = 4
                Me.gridLayout1.Rows = 5
                Me.gridLayout1.HGap = 4
                Me.gridLayout1.VGap = 4
                ' You can ignore one or more child Control from being laid out, like this:
                ' This will have the same effect as calling RemoveLayoutComponent.
                'this.gridLayout1.SetParticipateInLayout(this.button1, false);
                ' You can prevent automatic layout during the layout event:
                ' If you decide to do so, make sure to call gridLayout1.LayoutContainer manually.
                ' this.gridLayout1.AutoLayout = false;</code></coderef>
            End If
            ' </samplecodeblock>
            '

        End Sub
    End Class
End Namespace
