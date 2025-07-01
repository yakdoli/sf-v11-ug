#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel

Namespace CollectionBase
	''' <summary>
	''' Summary description for DataCollection.
	''' </summary>
	Public Class DataCollection : Inherits System.Collections.CollectionBase
		Public Sub New()
		End Sub

		Public Sub Add(ByVal info As Data)
			Me.List.Add(info)
		End Sub
		Public Sub Remove(ByVal info As Data)
			Me.List.Remove(info)
		End Sub
		Public ReadOnly Default Property Item(ByVal index As Integer) As Data
			Get
				Return CType(MyBase.List(index), Data)
			End Get
		End Property

	End Class
End Namespace




