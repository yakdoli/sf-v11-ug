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


Public Class GridImageCellModel
    Inherits GridStaticCellModel
    Private _cellDrawOption As GridImageCellDrawOption
    Private _pictureBufferOffset As Integer
    'Fields
    'Constructors
    'Events
    'Methods
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New(info, context)

    End Sub
    Public Sub New(ByVal grid As GridModel)
        MyBase.New(grid)
        _cellDrawOption = GridImageCellDrawOption.FitToCell
        _pictureBufferOffset = 78

    End Sub
    Public Property CellDrawOption() As GridImageCellDrawOption
        Get

            Return _cellDrawOption

        End Get
        Set(ByVal Value As GridImageCellDrawOption)

            _cellDrawOption = Value

        End Set
    End Property
    Public Property PictureBufferOffset() As Integer
        Get

            Return _pictureBufferOffset

        End Get
        Set(ByVal Value As Integer)

            _pictureBufferOffset = Value

        End Set
    End Property
    Public Overloads Overrides Function CreateRenderer(ByVal control As GridControlBase) As GridCellRendererBase

        Return New GridImageCellRenderer(control, Me)

    End Function
End Class

