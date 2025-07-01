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
Imports System.Runtime.Serialization


Public Class DBDropDownGridCellModel
    Inherits GridDropDownGridCellModel
    Private WithEvents _embbeddedGrid As GridDataBoundGrid
    Private _dataSource As Object
    'Fields
    'Constructors
    'Events
    'Methods
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New(info, context)

    End Sub
    Public Sub New(ByVal grid As GridModel)
        MyBase.New(grid)

    End Sub
    Public Property DataSource() As Object
        Get

            Return _dataSource

        End Get
        Set(ByVal Value As Object)

            _dataSource = Value

        End Set
    End Property
    Public Property EmbeddedGrid() As GridDataBoundGrid
        Get

            If (_embbeddedGrid Is Nothing) Then
                _embbeddedGrid = New GridDataBoundGrid()
            End If
            Return _embbeddedGrid

        End Get
        Set(ByVal Value As GridDataBoundGrid)

            _embbeddedGrid = Value

        End Set
    End Property
    Public Event QueryFilterString As QueryFilterStringEventHandler
    Public Event QueryFormatGrid As QueryFormatGridEventHandler
    Public Overridable Sub OnQueryFormatGrid(ByVal e As QueryFormatGridEventArgs)

        RaiseEvent QueryFormatGrid(Me, e)

    End Sub
    Public Overridable Sub OnQueryFilterString(ByVal e As QueryFilterStringEventArgs)

        RaiseEvent QueryFilterString(Me, e)

    End Sub
    Public Overloads Overrides Function CreateRenderer(ByVal control As GridControlBase) As GridCellRendererBase

        Return New DropDownGridCellRenderer(control, Me)

    End Function
End Class

