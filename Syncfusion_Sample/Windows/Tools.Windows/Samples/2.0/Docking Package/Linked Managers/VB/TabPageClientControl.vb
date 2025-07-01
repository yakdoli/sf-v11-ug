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

Imports Syncfusion.Windows.Forms.Tools


'/ <summary>
'/ Summary description for TabPageClientControl.
'/ </summary>

Public Class TabPageClientControl
    Inherits System.Windows.Forms.UserControl
#Region "Members declaration"
    Private dockingManager1 As Syncfusion.Windows.Forms.Tools.DockingManager
    Private components As System.ComponentModel.IContainer
#End Region
#Region "Property declaration"
    Public ReadOnly Property DockingManager() As DockingManager
        Get
            Return Me.dockingManager1
        End Get
    End Property
#End Region
#Region "Initialization"
    Public Sub New()
        ' This call is required by the Windows.Forms Form Designer.
        InitializeComponent()

        ' Set the DockingManager's HostActivatedVisibility to FALSE so that docking windows are not 
        ' hidden when the parent TabPage is deactivated
        Me.dockingManager1.HostActivatedVisibility = False

        ' Setting the DockingManager's ControlScopeImages property specifies that the control Icons 
        ' will be provided by the dockable controls themselves and can be dereferenced prior to 
        ' disposing off the control
        Me.dockingManager1.ControlScopeImages = True

        ' AutoHide tabs are always displayed on the left side of the form. 
        Me.dockingManager1.RestrictDockFillAutoHideBorder(DockingStyle.Left)
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As New System.Resources.ResourceManager(GetType(TabPageClientControl))
        Me.dockingManager1 = New Syncfusion.Windows.Forms.Tools.DockingManager(Me.components)
        CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        ' 
        ' dockingManager1
        ' 
        Me.dockingManager1.DockLayoutStream = CType(resources.GetObject("dockingManager1.DockLayoutStream"), System.IO.MemoryStream)
        Me.dockingManager1.DockToFill = True
        Me.dockingManager1.HostControl = Me
        ' 
        ' TabPageClientControl
        ' 
        Me.Name = "TabPageClientControl"
        Me.Size = New System.Drawing.Size(488, 376)
        CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).EndInit()
    End Sub 'InitializeComponent 
#End Region
#End Region
End Class 'TabPageClientControl