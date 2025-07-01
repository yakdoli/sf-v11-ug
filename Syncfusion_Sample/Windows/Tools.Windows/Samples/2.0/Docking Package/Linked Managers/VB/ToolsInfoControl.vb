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
'/ Summary description for ToolsInfoControl.
'/ </summary>

Public Class ToolsInfoControl
    Inherits DockableControlBase
    Private textBox1 As System.Windows.Forms.TextBox
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
        Me.controlIcon = New Icon("..\..\Icons\sftools.ico")
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
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.BackColor = System.Drawing.Color.FromArgb(CType(220, Byte), CType(226, Byte), CType(240, Byte))
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBox1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ReadOnly = True
        Me.textBox1.Size = New System.Drawing.Size(456, 408)
        Me.textBox1.TabIndex = 5
        Me.textBox1.Text = "Essential Tools features the latest Windows user interface in one convenient pack" & _
        "age. Visual Studio.NET style Docking, Tabbed MDI, Swing like layout management, " & _
        "Office XP like customizable toolbars and menus, numerous controls and more in on" & _
        "e great package. "
        Me.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolsInfoControl
        '
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.textBox1})
        Me.Name = "ToolsInfoControl"
        Me.Size = New System.Drawing.Size(456, 408)
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region
End Class 'ToolsInfoControl