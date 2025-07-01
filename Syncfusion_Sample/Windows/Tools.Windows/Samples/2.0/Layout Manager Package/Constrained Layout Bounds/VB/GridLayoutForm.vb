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

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms


'/ <summary>
'/ Summary description for GridLayoutForm.
'/ </summary>

Public Class GridLayoutForm
   Inherits System.Windows.Forms.Form
   Private panel1 As System.Windows.Forms.Panel
   Private propertyGrid1 As System.Windows.Forms.PropertyGrid
   Private gridLayout1 As Syncfusion.Windows.Forms.Tools.GridLayout
    Private outerPanel As System.Windows.Forms.Panel
    Private textBox1 As System.Windows.Forms.TextBox
   Private WithEvents innerPanel As Panel
   Private one As System.Windows.Forms.Button
   Private button6 As System.Windows.Forms.Button
   Private button7 As System.Windows.Forms.Button
   Private button8 As System.Windows.Forms.Button
   Private button9 As System.Windows.Forms.Button
   Private button10 As System.Windows.Forms.Button
   Private button11 As System.Windows.Forms.Button
   Private button12 As System.Windows.Forms.Button
   Private button13 As System.Windows.Forms.Button
   Private button14 As System.Windows.Forms.Button
   Private button15 As System.Windows.Forms.Button
   Private button16 As System.Windows.Forms.Button
   Private button17 As System.Windows.Forms.Button
   Private button18 As System.Windows.Forms.Button
   Private button19 As System.Windows.Forms.Button
   Private button20 As System.Windows.Forms.Button
   Private button1 As System.Windows.Forms.Button
   Private button2 As System.Windows.Forms.Button
   Private button3 As System.Windows.Forms.Button
   Private button4 As System.Windows.Forms.Button
   Private components As System.ComponentModel.IContainer
   
   
   Public Sub New()
      '
      ' Required for Windows Form Designer support
      '
        InitializeComponent()
        Me.Label2.Text = "Panel: Width = " + Me.innerPanel.Width.ToString() + "," + " Height = " + Me.innerPanel.Height.ToString()
   End Sub 'New
    
   '
   ' TODO: Add any constructor code after InitializeComponent call
   '
   
   '/ <summary>
   '/ Clean up any resources being used.
   '/ </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Friend WithEvents GradientLabel1 As Syncfusion.Windows.Forms.Tools.GradientLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(GridLayoutForm))
        Me.panel1 = New System.Windows.Forms.Panel()
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
        Me.GradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.GradientLabel1, Me.outerPanel})
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(440, 382)
        Me.panel1.TabIndex = 0
        '
        'outerPanel
        '
        Me.outerPanel.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.outerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.outerPanel.Controls.AddRange(New System.Windows.Forms.Control() {Me.innerPanel, Me.textBox1})
        Me.outerPanel.Location = New System.Drawing.Point(40, 120)
        Me.outerPanel.Name = "outerPanel"
        Me.outerPanel.Size = New System.Drawing.Size(354, 250)
        Me.outerPanel.TabIndex = 1
        '
        'innerPanel
        '
        Me.innerPanel.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.innerPanel.AutoScroll = True
        Me.innerPanel.Controls.AddRange(New System.Windows.Forms.Control() {Me.one, Me.button20, Me.button19, Me.button18, Me.button17, Me.button16, Me.button15, Me.button14, Me.button13, Me.button12, Me.button11, Me.button10, Me.button9, Me.button8, Me.button7, Me.button6, Me.button1, Me.button4, Me.button3, Me.button2})
        Me.innerPanel.Location = New System.Drawing.Point(2, 24)
        Me.innerPanel.Name = "innerPanel"
        Me.innerPanel.Size = New System.Drawing.Size(346, 226)
        Me.innerPanel.TabIndex = 1
        '
        'one
        '
        Me.one.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.one.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.one.Location = New System.Drawing.Point(5, 5)
        Me.gridLayout1.SetMinimumSize(Me.one, New System.Drawing.Size(33, 33))
        Me.one.Name = "one"
        Me.gridLayout1.SetParticipateInLayout(Me.one, True)
        Me.gridLayout1.SetPreferredSize(Me.one, New System.Drawing.Size(43, 33))
        Me.one.Size = New System.Drawing.Size(81, 40)
        Me.one.TabIndex = 0
        Me.one.Text = "1"
        '
        'button20
        '
        Me.button20.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button20.Location = New System.Drawing.Point(90, 5)
        Me.gridLayout1.SetMinimumSize(Me.button20, New System.Drawing.Size(43, 33))
        Me.button20.Name = "button20"
        Me.gridLayout1.SetParticipateInLayout(Me.button20, True)
        Me.gridLayout1.SetPreferredSize(Me.button20, New System.Drawing.Size(43, 33))
        Me.button20.Size = New System.Drawing.Size(81, 40)
        Me.button20.TabIndex = 2
        Me.button20.Text = "2"
        '
        'button19
        '
        Me.button19.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button19.Location = New System.Drawing.Point(175, 5)
        Me.button19.Name = "button19"
        Me.gridLayout1.SetParticipateInLayout(Me.button19, True)
        Me.gridLayout1.SetPreferredSize(Me.button19, New System.Drawing.Size(43, 33))
        Me.button19.Size = New System.Drawing.Size(81, 40)
        Me.button19.TabIndex = 3
        Me.button19.Text = "3"
        '
        'button18
        '
        Me.button18.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.button18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button18.Location = New System.Drawing.Point(260, 5)
        Me.button18.Name = "button18"
        Me.gridLayout1.SetParticipateInLayout(Me.button18, True)
        Me.gridLayout1.SetPreferredSize(Me.button18, New System.Drawing.Size(43, 33))
        Me.button18.Size = New System.Drawing.Size(81, 40)
        Me.button18.TabIndex = 12
        Me.button18.Text = "="
        '
        'button17
        '
        Me.button17.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button17.Location = New System.Drawing.Point(5, 49)
        Me.button17.Name = "button17"
        Me.gridLayout1.SetParticipateInLayout(Me.button17, True)
        Me.gridLayout1.SetPreferredSize(Me.button17, New System.Drawing.Size(43, 33))
        Me.button17.Size = New System.Drawing.Size(81, 40)
        Me.button17.TabIndex = 4
        Me.button17.Text = "4"
        '
        'button16
        '
        Me.button16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button16.Location = New System.Drawing.Point(90, 49)
        Me.button16.Name = "button16"
        Me.gridLayout1.SetParticipateInLayout(Me.button16, True)
        Me.gridLayout1.SetPreferredSize(Me.button16, New System.Drawing.Size(43, 33))
        Me.button16.Size = New System.Drawing.Size(81, 40)
        Me.button16.TabIndex = 5
        Me.button16.Text = "5"
        '
        'button15
        '
        Me.button15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button15.Location = New System.Drawing.Point(175, 49)
        Me.gridLayout1.SetMinimumSize(Me.button15, New System.Drawing.Size(43, 33))
        Me.button15.Name = "button15"
        Me.gridLayout1.SetParticipateInLayout(Me.button15, True)
        Me.gridLayout1.SetPreferredSize(Me.button15, New System.Drawing.Size(43, 33))
        Me.button15.Size = New System.Drawing.Size(81, 40)
        Me.button15.TabIndex = 6
        Me.button15.Text = "6"
        '
        'button14
        '
        Me.button14.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button14.Location = New System.Drawing.Point(260, 49)
        Me.button14.Name = "button14"
        Me.gridLayout1.SetParticipateInLayout(Me.button14, True)
        Me.button14.Size = New System.Drawing.Size(81, 40)
        Me.button14.TabIndex = 13
        Me.button14.Text = "+"
        '
        'button13
        '
        Me.button13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button13.Location = New System.Drawing.Point(5, 93)
        Me.button13.Name = "button13"
        Me.gridLayout1.SetParticipateInLayout(Me.button13, True)
        Me.gridLayout1.SetPreferredSize(Me.button13, New System.Drawing.Size(43, 33))
        Me.button13.Size = New System.Drawing.Size(81, 40)
        Me.button13.TabIndex = 7
        Me.button13.Text = "7"
        '
        'button12
        '
        Me.button12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button12.Location = New System.Drawing.Point(90, 93)
        Me.button12.Name = "button12"
        Me.gridLayout1.SetParticipateInLayout(Me.button12, True)
        Me.gridLayout1.SetPreferredSize(Me.button12, New System.Drawing.Size(43, 33))
        Me.button12.Size = New System.Drawing.Size(81, 40)
        Me.button12.TabIndex = 8
        Me.button12.Text = "8"
        '
        'button11
        '
        Me.button11.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button11.Location = New System.Drawing.Point(175, 93)
        Me.button11.Name = "button11"
        Me.gridLayout1.SetParticipateInLayout(Me.button11, True)
        Me.gridLayout1.SetPreferredSize(Me.button11, New System.Drawing.Size(43, 33))
        Me.button11.Size = New System.Drawing.Size(81, 40)
        Me.button11.TabIndex = 9
        Me.button11.Text = "9"
        '
        'button10
        '
        Me.button10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button10.Location = New System.Drawing.Point(260, 93)
        Me.button10.Name = "button10"
        Me.gridLayout1.SetParticipateInLayout(Me.button10, True)
        Me.button10.Size = New System.Drawing.Size(81, 40)
        Me.button10.TabIndex = 14
        Me.button10.Text = "-"
        '
        'button9
        '
        Me.button9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button9.Location = New System.Drawing.Point(5, 137)
        Me.button9.Name = "button9"
        Me.gridLayout1.SetParticipateInLayout(Me.button9, True)
        Me.gridLayout1.SetPreferredSize(Me.button9, New System.Drawing.Size(43, 33))
        Me.button9.Size = New System.Drawing.Size(81, 40)
        Me.button9.TabIndex = 10
        Me.button9.Text = "0"
        '
        'button8
        '
        Me.button8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button8.Location = New System.Drawing.Point(90, 137)
        Me.button8.Name = "button8"
        Me.gridLayout1.SetParticipateInLayout(Me.button8, True)
        Me.gridLayout1.SetPreferredSize(Me.button8, New System.Drawing.Size(43, 33))
        Me.button8.Size = New System.Drawing.Size(81, 40)
        Me.button8.TabIndex = 11
        Me.button8.Text = "."
        '
        'button7
        '
        Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button7.Location = New System.Drawing.Point(175, 137)
        Me.button7.Name = "button7"
        Me.gridLayout1.SetParticipateInLayout(Me.button7, True)
        Me.button7.Size = New System.Drawing.Size(81, 40)
        Me.button7.TabIndex = 16
        Me.button7.Text = "C"
        '
        'button6
        '
        Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button6.Location = New System.Drawing.Point(260, 137)
        Me.button6.Name = "button6"
        Me.gridLayout1.SetParticipateInLayout(Me.button6, True)
        Me.gridLayout1.SetPreferredSize(Me.button6, New System.Drawing.Size(43, 33))
        Me.button6.Size = New System.Drawing.Size(81, 40)
        Me.button6.TabIndex = 15
        Me.button6.Text = "*"
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button1.Location = New System.Drawing.Point(5, 181)
        Me.button1.Name = "button1"
        Me.gridLayout1.SetParticipateInLayout(Me.button1, True)
        Me.gridLayout1.SetPreferredSize(Me.button1, New System.Drawing.Size(43, 33))
        Me.button1.Size = New System.Drawing.Size(81, 40)
        Me.button1.TabIndex = 17
        Me.button1.Text = "MR"
        '
        'button4
        '
        Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button4.Location = New System.Drawing.Point(90, 181)
        Me.button4.Name = "button4"
        Me.gridLayout1.SetParticipateInLayout(Me.button4, True)
        Me.gridLayout1.SetPreferredSize(Me.button4, New System.Drawing.Size(43, 33))
        Me.button4.Size = New System.Drawing.Size(81, 40)
        Me.button4.TabIndex = 18
        Me.button4.Text = "MC"
        '
        'button3
        '
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button3.Location = New System.Drawing.Point(175, 181)
        Me.button3.Name = "button3"
        Me.gridLayout1.SetParticipateInLayout(Me.button3, True)
        Me.button3.Size = New System.Drawing.Size(81, 40)
        Me.button3.TabIndex = 19
        Me.button3.Text = "M+"
        '
        'button2
        '
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.button2.Location = New System.Drawing.Point(260, 181)
        Me.button2.Name = "button2"
        Me.gridLayout1.SetParticipateInLayout(Me.button2, True)
        Me.button2.Size = New System.Drawing.Size(81, 40)
        Me.button2.TabIndex = 20
        Me.button2.Text = "/"
        '
        'textBox1
        '
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(352, 20)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = ""
        '
        'propertyGrid1
        '
        Me.propertyGrid1.CommandsVisibleIfAvailable = True
        Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right
        Me.propertyGrid1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.propertyGrid1.LargeButtons = False
        Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
        Me.propertyGrid1.Location = New System.Drawing.Point(440, 0)
        Me.propertyGrid1.Name = "propertyGrid1"
        Me.propertyGrid1.Size = New System.Drawing.Size(232, 382)
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
        'GradientLabel1
        '
        Me.GradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(182, Byte), CType(211, Byte), CType(241, Byte)), System.Drawing.Color.FromArgb(CType(219, Byte), CType(229, Byte), CType(241, Byte)))
        Me.GradientLabel1.BorderSides = (((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) _
                    Or System.Windows.Forms.Border3DSide.Right) _
                    Or System.Windows.Forms.Border3DSide.Bottom)
        Me.GradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.GradientLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientLabel1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradientLabel1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GradientLabel1.Name = "GradientLabel1"
        Me.GradientLabel1.Size = New System.Drawing.Size(440, 48)
        Me.GradientLabel1.TabIndex = 3
        Me.GradientLabel1.Text = "GridLayout - The layout bounds for the Panel below is restricted to 300 X 200"
        Me.GradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(440, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridLayoutForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(672, 382)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.propertyGrid1, Me.panel1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GridLayoutForm"
        Me.Text = "Constrained Layout Bounds"
        Me.panel1.ResumeLayout(False)
        Me.outerPanel.ResumeLayout(False)
        Me.innerPanel.ResumeLayout(False)
        CType(Me.gridLayout1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.Run(New GridLayoutForm())
    End Sub 'Main


    Private Sub GridLayoutForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.propertyGrid1.SelectedObject = Me.gridLayout1
    End Sub 'GridLayoutForm_Load

    ' Here we will restrict the layout bounds of a container control to a min width/height.
    ' This makes sense for ContainerControls with AutoScroll turned on.
    ' Make sure to set DockPadding values to 0.
    Private minLayoutWidth As Integer = 300
    Private minLayoutHeight As Integer = 200

    ' Listen to the container control's Resize event.
    Private Sub innerPanel_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles innerPanel.Resize
        ' By default the layout bounds are the container's ClientRectangle,
        ' but here we will restrict it to be a minimum size (via the CustomLayoutBounds property)
        Dim containerLayoutBounds As Rectangle = Me.innerPanel.ClientRectangle
        If Not Me.innerPanel.DisplayRectangle.Equals(containerLayoutBounds) Then
            ' This means that there is a scrollbar, so start laying out
            ' at the displayrect's left/top
            containerLayoutBounds.X = Me.innerPanel.DisplayRectangle.X
            containerLayoutBounds.Y = Me.innerPanel.DisplayRectangle.Y
        End If
        ' If the client rect is not big enough then use the minwidth/minheight
        If Me.innerPanel.ClientRectangle.Width < minLayoutWidth Then
            containerLayoutBounds.Width = minLayoutWidth
        End If
        If Me.innerPanel.ClientRectangle.Height < minLayoutHeight Then
            containerLayoutBounds.Height = minLayoutHeight
        End If

        If Not Me.innerPanel.ClientRectangle.Equals(containerLayoutBounds) Then
            ' If we have a custom layout bounds use it.
            Me.gridLayout1.CustomLayoutBounds = containerLayoutBounds
        Else
            ' Or else make the layout manager use the client rect.
            Me.gridLayout1.CustomLayoutBounds = Rectangle.Empty
        End If
    End Sub 'innerPanel_Resize

    Private Sub GridLayoutForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.Label2.Text = "Panel: Width = " + Me.innerPanel.Width.ToString() + "," + " Height = " + Me.innerPanel.Height.ToString()
    End Sub
End Class 'GridLayoutForm