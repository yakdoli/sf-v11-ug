#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System.Collections.Generic

Namespace DataBinding
    ''' <summary>
    ''' Defines an abstract class for defining Reflection strategy.
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    Public MustInherit Class ReflectionStrategy(Of T)
       
        Public Sub New()
        End Sub

        ''' <summary>
        ''' Builds up the Reflection info that would be used for getting the Node attribute's information.
        ''' </summary>
        Public MustOverride Sub BuildUp(ByVal [assembly] As System.Reflection.Assembly)

        ''' <summary>
        ''' Clears up all the memory.
        ''' </summary>
        Public MustOverride Sub TearDown()

    End Class

End Namespace