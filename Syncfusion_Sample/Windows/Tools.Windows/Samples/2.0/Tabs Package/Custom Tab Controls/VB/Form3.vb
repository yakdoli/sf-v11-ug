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
Imports Syncfusion.Reflection
Imports Syncfusion.Windows.Forms.Tools
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace CustomTabControls
    Public Class Form3
        Inherits Form
        Private WithEvents tabControlExt1 As DemoTabControl
        Private WithEvents tabPageExt1 As TabPageAdv
        Private WithEvents tabPageExt2 As TabPageAdv
        Private WithEvents tabPageExt3 As TabPageAdv
        Private WithEvents designTimeTabTypeLoader As TypeLoader
        Private WithEvents label1 As Label
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
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form3))
            Me.tabControlExt1 = New CustomTabControls.DemoTabControl()
            Me.tabPageExt1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
            Me.tabPageExt2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
            Me.tabPageExt3 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
            Me.designTimeTabTypeLoader = New Syncfusion.Reflection.TypeLoader(Me.components)
            Me.label1 = New System.Windows.Forms.Label()
            CType(Me.tabControlExt1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControlExt1.SuspendLayout()
            Me.SuspendLayout()
            '
            'tabControlExt1
            '
            Me.tabControlExt1.ActiveTabColor = System.Drawing.Color.FromArgb(CType(218, Byte), CType(229, Byte), CType(245, Byte))
            Me.tabControlExt1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.tabControlExt1.BackColor = System.Drawing.Color.FromArgb(CType(237, Byte), CType(240, Byte), CType(246, Byte))
            Me.tabControlExt1.Controls.AddRange(New System.Windows.Forms.Control() {Me.tabPageExt1, Me.tabPageExt2, Me.tabPageExt3})
            Me.tabControlExt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabControlExt1.InactiveTabColor = System.Drawing.Color.FromArgb(CType(132, Byte), CType(161, Byte), CType(195, Byte))
            Me.tabControlExt1.Location = New System.Drawing.Point(16, 64)
            Me.tabControlExt1.Name = "tabControlExt1"
            Me.tabControlExt1.Size = New System.Drawing.Size(264, 152)
            Me.tabControlExt1.TabIndex = 0
            Me.tabControlExt1.TabPanelBackColor = System.Drawing.Color.White
            Me.tabControlExt1.TabStyle = GetType(CustomTabControls.DemoTabsRenderer)
            '
            'tabPageExt1
            '
            Me.tabPageExt1.Location = New System.Drawing.Point(1, 34)
            Me.tabPageExt1.Name = "tabPageExt1"
            Me.tabPageExt1.Size = New System.Drawing.Size(261, 116)
            Me.tabPageExt1.TabIndex = 0
            Me.tabPageExt1.Text = "C#"
            '
            'tabPageExt2
            '
            Me.tabPageExt2.Location = New System.Drawing.Point(1, 29)
            Me.tabPageExt2.Name = "tabPageExt2"
            Me.tabPageExt2.Size = New System.Drawing.Size(261, 121)
            Me.tabPageExt2.TabIndex = 1
            Me.tabPageExt2.Text = "VB"
            '
            'tabPageExt3
            '
            Me.tabPageExt3.Location = New System.Drawing.Point(1, 29)
            Me.tabPageExt3.Name = "tabPageExt3"
            Me.tabPageExt3.Size = New System.Drawing.Size(261, 121)
            Me.tabPageExt3.TabIndex = 2
            Me.tabPageExt3.Text = "Description"
            '
            'designTimeTabTypeLoader
            '
            Me.designTimeTabTypeLoader.TypesToLoadList.Add(New Syncfusion.Reflection.TypeName("CustomTabControls.DemoTabsRenderer"))
            '
            'label1
            '
            Me.label1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.label1.Location = New System.Drawing.Point(16, 8)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(264, 40)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Custom rendererd Flat Look Tabs"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Form3
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(296, 237)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.label1, Me.tabControlExt1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form3"
            Me.Text = "Custom Tabs: Flat Look"
            CType(Me.tabControlExt1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControlExt1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
    End Class
End Namespace
