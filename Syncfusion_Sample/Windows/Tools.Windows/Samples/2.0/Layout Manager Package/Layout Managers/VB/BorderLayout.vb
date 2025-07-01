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
Imports System.Data

Imports Syncfusion.Windows.Forms.Tools


'/ <summary>
'/ Summary description for BorderLayoutForm.
'/ </summary>

Public Class BorderLayoutForm
   Inherits System.Windows.Forms.Form
   Private btnNorth As System.Windows.Forms.Button
   Private btnWest As System.Windows.Forms.Button
   Private btnEast As System.Windows.Forms.Button
   Private btnCenter As System.Windows.Forms.Button
   Private btnSouth As System.Windows.Forms.Button
   Private components As System.ComponentModel.IContainer
   Private borderLayout1 As Syncfusion.Windows.Forms.Tools.BorderLayout
   
   
   Public Sub New()
      '
      ' Required for Windows Form Designer support
      '
      InitializeComponent()
   End Sub 'New
   
   
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
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(BorderLayoutForm))
        Me.btnNorth = New System.Windows.Forms.Button()
        Me.btnWest = New System.Windows.Forms.Button()
        Me.btnEast = New System.Windows.Forms.Button()
        Me.btnCenter = New System.Windows.Forms.Button()
        Me.borderLayout1 = New Syncfusion.Windows.Forms.Tools.BorderLayout(Me.components)
        Me.btnSouth = New System.Windows.Forms.Button()
        CType(Me.borderLayout1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNorth
        '
        Me.btnNorth.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
        Me.btnNorth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNorth.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNorth.ForeColor = System.Drawing.Color.Black
        Me.btnNorth.Location = New System.Drawing.Point(20, 20)
        Me.btnNorth.Name = "btnNorth"
        Me.borderLayout1.SetPosition(Me.btnNorth, Syncfusion.Windows.Forms.Tools.BorderPosition.North)
        Me.borderLayout1.SetPreferredSize(Me.btnNorth, New System.Drawing.Size(152, 24))
        Me.btnNorth.Size = New System.Drawing.Size(432, 24)
        Me.btnNorth.TabIndex = 0
        Me.btnNorth.Text = "North"
        '
        'btnWest
        '
        Me.btnWest.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
        Me.btnWest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWest.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWest.ForeColor = System.Drawing.Color.Black
        Me.btnWest.Location = New System.Drawing.Point(20, 64)
        Me.btnWest.Name = "btnWest"
        Me.borderLayout1.SetPosition(Me.btnWest, Syncfusion.Windows.Forms.Tools.BorderPosition.West)
        Me.borderLayout1.SetPreferredSize(Me.btnWest, New System.Drawing.Size(108, 124))
        Me.btnWest.Size = New System.Drawing.Size(108, 134)
        Me.btnWest.TabIndex = 2
        Me.btnWest.Text = "West"
        '
        'btnEast
        '
        Me.btnEast.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
        Me.btnEast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEast.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEast.ForeColor = System.Drawing.Color.Black
        Me.btnEast.Location = New System.Drawing.Point(344, 64)
        Me.btnEast.Name = "btnEast"
        Me.borderLayout1.SetPosition(Me.btnEast, Syncfusion.Windows.Forms.Tools.BorderPosition.East)
        Me.borderLayout1.SetPreferredSize(Me.btnEast, New System.Drawing.Size(108, 164))
        Me.btnEast.Size = New System.Drawing.Size(108, 134)
        Me.btnEast.TabIndex = 3
        Me.btnEast.Text = "East"
        '
        'btnCenter
        '
        Me.btnCenter.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
        Me.btnCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCenter.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCenter.ForeColor = System.Drawing.Color.Black
        Me.btnCenter.Location = New System.Drawing.Point(148, 64)
        Me.btnCenter.Name = "btnCenter"
        Me.borderLayout1.SetPosition(Me.btnCenter, Syncfusion.Windows.Forms.Tools.BorderPosition.Center)
        Me.borderLayout1.SetPreferredSize(Me.btnCenter, New System.Drawing.Size(128, 72))
        Me.btnCenter.Size = New System.Drawing.Size(176, 134)
        Me.btnCenter.TabIndex = 4
        Me.btnCenter.Text = "Center"
        '
        'borderLayout1
        '
        Me.borderLayout1.BottomMargin = 20
        Me.borderLayout1.ContainerControl = Me
        Me.borderLayout1.HGap = 20
        Me.borderLayout1.HorzFarMargin = 20
        Me.borderLayout1.HorzNearMargin = 20
        Me.borderLayout1.TopMargin = 20
        Me.borderLayout1.VGap = 20
        '
        'btnSouth
        '
        Me.btnSouth.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
        Me.btnSouth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSouth.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSouth.ForeColor = System.Drawing.Color.Black
        Me.btnSouth.Location = New System.Drawing.Point(20, 218)
        Me.btnSouth.Name = "btnSouth"
        Me.borderLayout1.SetPosition(Me.btnSouth, Syncfusion.Windows.Forms.Tools.BorderPosition.South)
        Me.borderLayout1.SetPreferredSize(Me.btnSouth, New System.Drawing.Size(86, 24))
        Me.btnSouth.Size = New System.Drawing.Size(432, 24)
        Me.btnSouth.TabIndex = 5
        Me.btnSouth.Text = "South"
        '
        'BorderLayoutForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(472, 262)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnSouth, Me.btnCenter, Me.btnEast, Me.btnWest, Me.btnNorth})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BorderLayoutForm"
        Me.Text = "Border Layout"
        CType(Me.borderLayout1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    Private Sub BorderLayoutForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Sample Code Block to illustrate initialization without designer.
        ' Repeats whatever the deisgner already did in InitializeComponent.
        If False Then
            ' <samplecodeblock name="Initializing BorderLayout">
            Me.borderLayout1 = New BorderLayout()

            Me.borderLayout1.ContainerControl = Me

            ' Set the border-position of the button.
            Me.borderLayout1.SetPosition(Me.btnNorth, BorderPosition.North)
            Me.borderLayout1.SetPosition(Me.btnSouth, BorderPosition.South)
            Me.borderLayout1.SetPosition(Me.btnCenter, BorderPosition.Center)
            Me.borderLayout1.SetPosition(Me.btnEast, BorderPosition.East)
            Me.borderLayout1.SetPosition(Me.btnWest, BorderPosition.West)

            '</samplecodeblock>
        End If
    End Sub 'BorderLayoutForm_Load
End Class 'BorderLayoutForm