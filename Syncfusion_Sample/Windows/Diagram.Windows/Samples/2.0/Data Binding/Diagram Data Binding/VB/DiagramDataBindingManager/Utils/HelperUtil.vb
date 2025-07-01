'INSTANT VB NOTE: This code snippet uses implicit typing. You will need to set 'Option Infer On' in the VB file or set 'Option Infer' at the project level:

#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System.Collections.Generic
#If Syncfusion3_5 Then
Imports System.Linq
#End If

Namespace DataBinding
    ''' <summary>
    ''' Defines a predicate delegate to be used for searching.
    ''' </summary>
    ''' <typeparam name="TType"></typeparam>
    ''' <typeparam name="PType"></typeparam>
    ''' <param name="item"></param>
    ''' <returns></returns>
    Public Delegate Function SearchPredicate(Of TType, PType)(ByVal item As TType) As PType

    ''' <summary>
    ''' Defines a utility of functions that is thoroughly reused for searching, indexing and many other future implementations.
    ''' </summary>
    Public Class HelperUtil

        ''' <summary>
        ''' Searches the specified collection.
        ''' TType - the type of object passed on to SearchPredicate
        ''' PType - the type of object that the SearchPredicate would return
        ''' </summary>
        ''' <param name="collection">The collection.</param>
        ''' <param name="itemToSearch">The item to search.</param>
        ''' <param name="searchValue">The search value.</param>
        Public Shared Function Search(Of TType, PType)(ByVal collection As List(Of TType), ByVal itemToSearch As PType, ByVal searchValue As SearchPredicate(Of TType, PType)) As TType
            For i As Integer = 0 To collection.Count - 1
                If itemToSearch.ToString() = searchValue(collection(i)).ToString() Then
                    Return collection(i)
                End If
            Next i
        End Function
    End Class
End Namespace