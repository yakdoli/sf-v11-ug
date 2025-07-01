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
Imports System.Windows.Forms

Namespace AdvancedFlowLayout
    Public Class Form1
        Inherits Form
        Private WithEvents panel1 As Panel
        Private WithEvents splitter1 As Splitter
        Private WithEvents flowLayout1 As FlowLayout
        Private WithEvents button1 As Button
        Private WithEvents button2 As Button
        Private WithEvents button3 As Button
        Private WithEvents button4 As Button
        Private WithEvents button5 As Button
        Private WithEvents button6 As Button
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
        Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.button6 = New System.Windows.Forms.Button()
            Me.button5 = New System.Windows.Forms.Button()
            Me.button4 = New System.Windows.Forms.Button()
            Me.button3 = New System.Windows.Forms.Button()
            Me.button2 = New System.Windows.Forms.Button()
            Me.button1 = New System.Windows.Forms.Button()
            Me.splitter1 = New System.Windows.Forms.Splitter()
            Me.flowLayout1 = New Syncfusion.Windows.Forms.Tools.FlowLayout(Me.components)
            Me.GradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
            Me.TrackBar1 = New System.Windows.Forms.TrackBar()
            Me.panel1.SuspendLayout()
            CType(Me.flowLayout1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.AutoScroll = True
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.button6, Me.button5, Me.button4, Me.button3, Me.button2, Me.button1})
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(112, 278)
            Me.panel1.TabIndex = 0
            '
            'button6
            '
            Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button6.Location = New System.Drawing.Point(19, 5)
            Me.button6.Name = "button6"
            Me.button6.Size = New System.Drawing.Size(72, 64)
            Me.button6.TabIndex = 0
            Me.button6.Text = "button6"
            '
            'button5
            '
            Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button5.Location = New System.Drawing.Point(19, 74)
            Me.button5.Name = "button5"
            Me.button5.Size = New System.Drawing.Size(72, 64)
            Me.button5.TabIndex = 4
            Me.button5.Text = "button5"
            '
            'button4
            '
            Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button4.Location = New System.Drawing.Point(19, 143)
            Me.button4.Name = "button4"
            Me.button4.Size = New System.Drawing.Size(72, 64)
            Me.button4.TabIndex = 3
            Me.button4.Text = "button4"
            '
            'button3
            '
            Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button3.Location = New System.Drawing.Point(19, 212)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(72, 64)
            Me.button3.TabIndex = 2
            Me.button3.Text = "button3"
            '
            'button2
            '
            Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button2.Location = New System.Drawing.Point(19, 281)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(72, 64)
            Me.button2.TabIndex = 1
            Me.button2.Text = "button2"
            '
            'button1
            '
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button1.Location = New System.Drawing.Point(19, 350)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(72, 64)
            Me.button1.TabIndex = 0
            Me.button1.Text = "button1"
            '
            'splitter1
            '
            Me.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.splitter1.Location = New System.Drawing.Point(112, 0)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(5, 278)
            Me.splitter1.TabIndex = 1
            Me.splitter1.TabStop = False
            '
            'flowLayout1
            '
            Me.flowLayout1.Alignment = Syncfusion.Windows.Forms.Tools.FlowAlignment.Near
            Me.flowLayout1.AutoLayout = False
            Me.flowLayout1.ContainerControl = Me.panel1
            Me.flowLayout1.LayoutMode = Syncfusion.Windows.Forms.Tools.FlowLayoutMode.Vertical
            '
            'GradientLabel1
            '
            Me.GradientLabel1.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
            Me.GradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(237, Byte), CType(240, Byte), CType(247, Byte)), System.Drawing.Color.FromArgb(CType(223, Byte), CType(242, Byte), CType(255, Byte)))
            Me.GradientLabel1.BorderSides = System.Windows.Forms.Border3DSide.All
            Me.GradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.GradientLabel1.Location = New System.Drawing.Point(240, 8)
            Me.GradientLabel1.Name = "GradientLabel1"
            Me.GradientLabel1.Size = New System.Drawing.Size(136, 128)
            Me.GradientLabel1.TabIndex = 3
            Me.GradientLabel1.Text = "Buttons in the Panel to the left are laid out vertically by the FlowLayout manage" & _
            "r in one are more columns, the number of columns being restricted based on the a" & _
            "vailable width. Use the Splitter or the TrackBar to resize the panel's width."
            Me.GradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'TrackBar1
            '
            Me.TrackBar1.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
            Me.TrackBar1.Location = New System.Drawing.Point(240, 152)
            Me.TrackBar1.Maximum = 100
            Me.TrackBar1.Name = "TrackBar1"
            Me.TrackBar1.Size = New System.Drawing.Size(128, 45)
            Me.TrackBar1.TabIndex = 4
            Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(384, 278)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TrackBar1, Me.GradientLabel1, Me.splitter1, Me.panel1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.Text = "Advanced FlowLayout"
            Me.panel1.ResumeLayout(False)
            CType(Me.flowLayout1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        <STAThread()> _
        Public Shared Sub Main()

            Application.Run(New Form1())

        End Sub
        Private Sub panel1_Layout(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles panel1.Layout

            ' Provide custom layout bounds.
            Dim custBounds As Rectangle
            custBounds = Me.panel1.DisplayRectangle
            custBounds.Y = Me.panel1.DisplayRectangle.Y
            custBounds.Height = Me.DetermineLayoutHeight
            Me.flowLayout1.CustomLayoutBounds = custBounds
            ' And trigger a layout.
            Me.flowLayout1.LayoutContainer()

        End Sub
        Private Function DetermineLayoutHeight() As Integer
            ' Assuming all child controls have the same width and height. 

            ' Row heights. 
            Dim rowHeight As Integer = Me.flowLayout1.VGap + Me.button1.Height

            ' Determine the width of the columns. 
            Dim columnWidth As Integer = Me.flowLayout1.HGap + Me.button1.Width

            ' Determine the no. of columns. 
            ' Assume Vertical Scroll bar will always be visible 
            Dim possibleColumnsD As Double = (Me.panel1.Width - SystemInformation.VerticalScrollBarWidth) / columnWidth
            Dim possibleColumns As Integer = Math.Floor(possibleColumnsD)

            ' Layout height is the total height / no. of columns. 
            Dim totalHeight As Integer = rowHeight * Me.panel1.Controls.Count

            If possibleColumns > 0 Then
                Dim layoutHeight As Integer = totalHeight / possibleColumns
                Dim rows As Double = Math.Ceiling(CType(layoutHeight, Double) / CType(rowHeight, Double))
                Return rowHeight * rows
            Else
                Return totalHeight
            End If
        End Function

        Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
            Me.panel1.Width = Me.TrackBar1.Value + 380
            If (Me.TrackBar1.Value = 0) Then
                Me.panel1.Width = 112
            End If
        End Sub

        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.Size = New Size(648, 368)
        End Sub
    End Class
End Namespace
