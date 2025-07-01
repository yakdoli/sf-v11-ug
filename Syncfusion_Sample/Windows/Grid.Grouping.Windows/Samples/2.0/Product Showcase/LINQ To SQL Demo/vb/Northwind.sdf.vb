#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


Namespace LINQToSQLCE
	Partial Public Class Northwind

	End Class
	#Region "Schema Class"
	Public Class TerritoryRegion
		Private privateTerritoryID As String
		Public Property TerritoryID() As String
			Get
				Return privateTerritoryID
			End Get
			Set(ByVal value As String)
				privateTerritoryID = value
			End Set
		End Property
		Private privateTerritoryDescription As String
		Public Property TerritoryDescription() As String
			Get
				Return privateTerritoryDescription
			End Get
			Set(ByVal value As String)
				privateTerritoryDescription = value
			End Set
		End Property
		Private privateRegionID As Integer
		Public Property RegionID() As Integer
			Get
				Return privateRegionID
			End Get
			Set(ByVal value As Integer)
				privateRegionID = value
			End Set
		End Property
		Private privateRegionDescription As String
		Public Property RegionDescription() As String
			Get
				Return privateRegionDescription
			End Get
			Set(ByVal value As String)
				privateRegionDescription = value
			End Set
		End Property

	End Class

	Public Class EmployeeInfo
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privateTitle As String
		Public Property Title() As String
			Get
				Return privateTitle
			End Get
			Set(ByVal value As String)
				privateTitle = value
			End Set
		End Property
		Private privateAddress As String
		Public Property Address() As String
			Get
				Return privateAddress
			End Get
			Set(ByVal value As String)
				privateAddress = value
			End Set
		End Property
		Private privateTerritoryRegion As List(Of TerritoryRegion)
		Public Property TerritoryRegion() As List(Of TerritoryRegion)
			Get
				Return privateTerritoryRegion
			End Get
			Set(ByVal value As List(Of TerritoryRegion))
				privateTerritoryRegion = value
			End Set
		End Property
	End Class

	Public Class GroupedProduct
		Private privateCategoryID? As Integer
		Public Property CategoryID() As Integer?
			Get
				Return privateCategoryID
			End Get
			Set(ByVal value? As Integer)
				privateCategoryID = value
			End Set
		End Property
		Private privateProducts As List(Of Products)
		Public Property Products() As List(Of Products)
			Get
				Return privateProducts
			End Get
			Set(ByVal value As List(Of Products))
				privateProducts = value
			End Set
		End Property
	End Class
	#End Region
End Namespace
