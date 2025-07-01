#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports Microsoft.VisualBasic
Imports System

Public Delegate Sub QueryFilterStringEventHandler(ByVal sender As Object, ByVal e As QueryFilterStringEventArgs)

Public Class QueryFilterStringEventArgs
    Inherits EventArgs
    Private _filter As String
    Private _row As Integer
    Private _col As Integer
    'Fields
    'Constructors
    'Methods
    Public Sub New(ByVal row As Integer, ByVal col As Integer)
        MyBase.New()
        _row = row
        _col = col

    End Sub
    Public ReadOnly Property Row() As Integer
        Get

            Return _row

        End Get
    End Property
    Public ReadOnly Property Column() As Integer
        Get

            Return _col

        End Get
    End Property
    Public Property FilterString() As String
        Get

            Return _filter

        End Get
        Set(ByVal Value As String)

            _filter = Value

        End Set
    End Property
End Class

