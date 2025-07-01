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
Imports Syncfusion.Windows.Forms.Grid
Imports System

Public Delegate Sub QueryFormatGridEventHandler(ByVal sender As Object, ByVal e As QueryFormatGridEventArgs)

Public Class QueryFormatGridEventArgs
    Inherits EventArgs
    Private WithEvents _grid As GridControlBase
    Private _row As Integer
    Private _col As Integer
    'Fields
    'Constructors
    'Methods
    Public Sub New(ByVal row As Integer, ByVal col As Integer, ByVal grid As GridControlBase)
        MyBase.New()
        _row = row
        _col = col
        _grid = grid

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
    Public Property Grid() As GridControlBase
        Get

            Return _grid

        End Get
        Set(ByVal Value As GridControlBase)

            _grid = Value

        End Set
    End Property
End Class

