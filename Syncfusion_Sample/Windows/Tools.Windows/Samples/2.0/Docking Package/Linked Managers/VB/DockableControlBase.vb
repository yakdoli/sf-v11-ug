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
'/ Implements a template to be used by the dockable controls.
'/ </summary>

Public Class DockableControlBase
    Inherits System.Windows.Forms.UserControl
#Region "Members declaration"
    '/ <summary> 
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing

    Protected controlLabel As String = String.Empty
    Protected controlIcon As Icon = Nothing

    Protected dockingMgr As DockingManager = Nothing
#End Region
#Region "Property declaration"
    Public Property CurrentDockingManager() As DockingManager
        Get
            Return Me.dockingMgr
        End Get
        Set(ByVal Value As DockingManager)
            Me.dockingMgr = Value
        End Set
    End Property

    Public ReadOnly Property DockLabel() As String
        Get
            Return Me.controlLabel
        End Get
    End Property

    Public ReadOnly Property DockIcon() As Icon
        Get
            Return Me.controlIcon
        End Get
    End Property
#End Region

#Region "Initialization"
    Public Sub New()
        ' This call is required by the Windows.Forms Form Designer.
        InitializeComponent()
    End Sub 'New


    '/ <summary> 
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (Me.dockingMgr Is Nothing) Then
                Me.dockingMgr = Nothing
            End If

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
        ' 
        ' DockableControlBase
        ' 
        Me.Name = "DockableControlBase"
        Me.Size = New System.Drawing.Size(448, 440)
    End Sub 'InitializeComponent 
#End Region
#End Region
End Class 'DockableControlBase