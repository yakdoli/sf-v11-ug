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
Imports System.Collections.Generic
Imports System.Text

Namespace MarketSimulation
	Friend Class TypeSystemC
		Public Shared Symbols As String() = { "MSFT", "ORCL", "GE", "GM", "CSCO", "A", "C", "D", "E", "F", "VOD", "IBM"}

		Friend Enum FidEnum
			' Order Agreements
			NONE = 0
			OC_ID = 3000
			OC_SYMBOL
			OC_BAG_NAME
			OC_SIDE
			OC_QUANTITY
			OC_VALUE
			OC_WORKING
			OC_REMAINING
			OC_PCT_EXECUTED
			OC_OPEN
			OC_BID
			OC_ASK
			OC_LAST
		End Enum

#If SyncfusionFramework2_0 Then
		Private Shared Dictionary([Of] FidEnum, String) fidNameMap = New Dictionary([Of] FidEnum, String)()
		Private Shared Dictionary([Of] FidEnum, Type) fidTypeMap = New Dictionary([Of] FidEnum, Type)()
#Else
		Private Shared fidNameMap As Hashtable = New Hashtable ()
		Private Shared fidTypeMap As Hashtable = New Hashtable ()
#End If
		Public Shared Function FidName(ByVal fid As FidEnum) As String
			Return CStr(fidNameMap(fid))
		End Function

		Public Shared Function FidType(ByVal fid As FidEnum) As Type
			Return CType(fidTypeMap(fid), Type)
		End Function

		Shared Sub New()

			' FID Names
			fidNameMap(FidEnum.NONE) = "Null"

			fidNameMap(FidEnum.OC_ID) = "ID"
			fidNameMap(FidEnum.OC_BAG_NAME) = "Bag"
			fidNameMap(FidEnum.OC_SYMBOL) = "Symbol"
			fidNameMap(FidEnum.OC_SIDE) = "Side"
			fidNameMap(FidEnum.OC_QUANTITY) = "Quantity"
			fidNameMap(FidEnum.OC_VALUE) = "$Value"
			fidNameMap(FidEnum.OC_WORKING) = "Working"
			fidNameMap(FidEnum.OC_REMAINING) = "Remaining"
			fidNameMap(FidEnum.OC_PCT_EXECUTED) = "Executed%"
			fidNameMap(FidEnum.OC_OPEN) = "Opn"
			fidNameMap(FidEnum.OC_BID) = "Bid"
			fidNameMap(FidEnum.OC_ASK) = "Ask"
			fidNameMap(FidEnum.OC_LAST) = "Last"


			' FID Types 
			fidTypeMap(FidEnum.NONE) = Nothing

			fidTypeMap(FidEnum.OC_ID) = GetType(Long)
			fidTypeMap(FidEnum.OC_SYMBOL) = GetType(String)
			fidTypeMap(FidEnum.OC_BAG_NAME) = GetType(String)
			fidTypeMap(FidEnum.OC_SIDE) = GetType(String)
			fidTypeMap(FidEnum.OC_QUANTITY) = GetType(Long)
			fidTypeMap(FidEnum.OC_VALUE) = GetType(Double)
			fidTypeMap(FidEnum.OC_WORKING) = GetType(Long)
			fidTypeMap(FidEnum.OC_REMAINING) = GetType(Long)
			fidTypeMap(FidEnum.OC_PCT_EXECUTED) = GetType(Double)
			fidTypeMap(FidEnum.OC_OPEN) = GetType(Decimal)
			fidTypeMap(FidEnum.OC_BID) = GetType(Decimal)
			fidTypeMap(FidEnum.OC_ASK) = GetType(Decimal)
			fidTypeMap(FidEnum.OC_LAST) = GetType(Decimal)
		End Sub
	End Class
End Namespace
