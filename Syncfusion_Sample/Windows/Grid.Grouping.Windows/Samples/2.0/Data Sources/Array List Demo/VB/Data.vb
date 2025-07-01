#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System

Namespace NestedTables
	''' <summary>
	''' Summary description for Data.
	''' </summary>
	Public Class Data
		Public Sub New()
			Me.New("", "", "", "")
		End Sub

		Public Sub New(ByVal cat_Id As String, ByVal cat_Name As String, ByVal desc As String, ByVal other As String)
			Me.cat_Id = cat_Id
			Me.cat_Name = cat_Name
			Me.desc = desc
			Me.other = other
		End Sub
		Private cat_Name As String
		Public Property CategoryName() As String
			Get
				Return Me.cat_Name
			End Get
			Set
				Me.cat_Name = Value
			End Set
		End Property
		Private desc As String
		Public Property Description() As String
			Get
				Return Me.desc
			End Get
			Set
				Me.desc = Value
			End Set
		End Property
		Private cat_Id As String
		Public Property CategoryID() As String
			Get
				Return Me.cat_Id
			End Get
			Set
				Me.cat_Id = Value
			End Set
		End Property
		Private other As String
		Public Property OtherInfo() As String
			Get
				Return Me.other
			End Get
			Set
				Me.other = Value
			End Set
		End Property
	End Class
End Namespace
