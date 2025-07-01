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
Imports System.Runtime.Serialization


Public Class GridDropDownImageCellModel
    Inherits GridDropDownCellModel
    'Constructors
    'Events
    'Methods
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New(info, context)

    End Sub
    Public Sub New(ByVal pGrid As GridModel)
        MyBase.New(pGrid)

    End Sub
    Public Overloads Overrides Function CreateRenderer(ByVal control As GridControlBase) As GridCellRendererBase

        Return New GridDropDownImageCellRenderer(control, Me)

    End Function
End Class

