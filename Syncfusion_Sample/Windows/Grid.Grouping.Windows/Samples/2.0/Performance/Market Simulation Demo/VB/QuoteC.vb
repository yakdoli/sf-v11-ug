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
Imports System.Text

Namespace MarketSimulation
	Friend Class QuoteC
		Private Sub New()
		End Sub

'INSTANT VB NOTE: The parameter symbol was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
		Public Sub New(ByVal symbol_Renamed As String)
			Me.symbol_Renamed = symbol_Renamed
		End Sub

		Private symbol_Renamed As String
		Private bid_Renamed As Decimal
		Private ask_Renamed As Decimal
		Private last_Renamed As Decimal
		Private open_Renamed As Decimal

		Public ReadOnly Property Symbol() As String
			Get
				Return symbol_Renamed
			End Get
		End Property
		Public Property Bid() As Decimal
			Get
				Return bid_Renamed
			End Get
			Set
				bid_Renamed = Value
			End Set
		End Property
		Public Property Ask() As Decimal
			Get
				Return ask_Renamed
			End Get
			Set
				ask_Renamed = Value
			End Set
		End Property
		Public Property Last() As Decimal
			Get
				Return last_Renamed
			End Get
			Set
				last_Renamed = Value
			End Set
		End Property
		Public Property Open() As Decimal
			Get
				Return open_Renamed
			End Get
			Set
				open_Renamed = Value
			End Set
		End Property
	End Class
End Namespace
