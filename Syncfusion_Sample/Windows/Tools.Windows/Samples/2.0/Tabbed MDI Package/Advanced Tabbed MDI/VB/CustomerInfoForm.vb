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
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class CustomerInfoForm
    Inherits Form
    Private WithEvents label1 As Label
    Private components As Container
    'Fields
    'Constructors
    'Events
    'Methods
    Public Sub New(ByVal [text] As String)
        Me.New()
        Me.Text = [text]
        Me.label1.Text = (Me.label1.Text _
                    + (" for " + Me.Text))

    End Sub
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
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CustomerInfoForm))
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(112, 64)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(240, 80)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Customer Info"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CustomerInfoForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(237, Byte), CType(240, Byte), CType(247, Byte))
        Me.ClientSize = New System.Drawing.Size(424, 270)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.label1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CustomerInfoForm"
        Me.Text = "CustomerInfoForm"
        Me.ResumeLayout(False)

    End Sub
End Class

