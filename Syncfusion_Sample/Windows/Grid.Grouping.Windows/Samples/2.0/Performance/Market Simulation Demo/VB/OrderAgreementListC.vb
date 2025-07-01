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
#If SyncfusionFramework2_0 Then
	Friend Class OrderAgreementListC : Inherits List([Of] OrderAgreementC)
	End Class
#Else
	Friend Class OrderAgreementListC : Inherits ArrayList
		Public Shadows Default Property Item(ByVal index As Integer) As OrderAgreementC
			Get
				Return CType(MyBase.Item(index), OrderAgreementC)
			End Get
			Set
				MyBase.Item(index) = Value
			End Set
		End Property
	End Class
#End If
End Namespace
