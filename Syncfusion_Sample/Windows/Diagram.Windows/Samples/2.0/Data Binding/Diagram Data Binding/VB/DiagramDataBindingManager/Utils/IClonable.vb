#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Collections.Generic

Namespace DataBinding
    ''' <summary>
    ''' Defines a Generic implementation for ICloneable interface.
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    Friend Interface ICloneable(Of T)
        Function Clone() As T
    End Interface
End Namespace