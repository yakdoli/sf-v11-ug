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
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms


'/ <summary>
'/ Summary description for GridLogoControl.
'/ </summary>

Public Class GridLogoControl
    Inherits DockableControlBase
    Private pictureBox1 As System.Windows.Forms.PictureBox
    '/ <summary> 
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    
    
    Public Sub New(label As String)
        ' This call is required by the Windows.Forms Form Designer.
        InitializeComponent()
        
        ' Initialize the docking window label and icon properties
        Me.Name = label
        Me.controlLabel = label
        Me.controlIcon = New Icon("..\..\Icons\sfgrid.ico")
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

#Region "Component Designer generated code"

    '/ <summary> 
    '/ Required method for Designer support - do not modify 
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(GridLogoControl))
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Bitmap)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(512, 408)
        Me.pictureBox1.TabIndex = 3
        Me.pictureBox1.TabStop = False
        '
        'GridLogoControl
        '
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.pictureBox1})
        Me.Name = "GridLogoControl"
        Me.Size = New System.Drawing.Size(512, 408)
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region
End Class 'GridLogoControl