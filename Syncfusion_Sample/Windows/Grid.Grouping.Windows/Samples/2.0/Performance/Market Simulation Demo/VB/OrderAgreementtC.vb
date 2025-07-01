#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Collections
Imports System.Text

Imports Fids = MarketSimulation.TypeSystemC.FidEnum

Namespace MarketSimulation
#If SyncfusionFramework2_0 Then
	Class OrderAgreementC : Inherits Dictionary([Of] TypeSystemC.FidEnum , [Of] Object)
#Else
	Class OrderAgreementC : Inherits System.Collections.Hashtable
#End If

        Public Sub New()
            Me.Add(Fids.OC_ID, Nothing)
            Me.Add(Fids.OC_SYMBOL, Nothing)
            Me.Add(Fids.OC_BAG_NAME, Nothing)
            Me.Add(Fids.OC_SIDE, Nothing)
            Me.Add(Fids.OC_QUANTITY, Nothing)
            Me.Add(Fids.OC_VALUE, Nothing)
            Me.Add(Fids.OC_WORKING, Nothing)
            Me.Add(Fids.OC_PCT_EXECUTED, Nothing)
            Me.Add(Fids.OC_REMAINING, Nothing)
            Me.Add(Fids.OC_OPEN, Nothing)
            Me.Add(Fids.OC_BID, Nothing)
            Me.Add(Fids.OC_ASK, Nothing)
            Me.Add(Fids.OC_LAST, Nothing)
        End Sub

        Public Sub New(ByVal iD As Long, ByVal symbol As String, ByVal bagName As String, ByVal side As String, ByVal quantity As Long, ByVal value As Double, ByVal working As Long, ByVal remaining As Long, ByVal executed As Double, ByVal open As Decimal, ByVal bid As Decimal, ByVal ask As Decimal, ByVal last As Decimal)
            Me.Add(Fids.OC_ID, iD)
            Me.Add(Fids.OC_SYMBOL, symbol)
            Me.Add(Fids.OC_BAG_NAME, bagName)
            Me.Add(Fids.OC_SIDE, side)
            Me.Add(Fids.OC_QUANTITY, quantity)
            Me.Add(Fids.OC_VALUE, value)
            Me.Add(Fids.OC_WORKING, working)
            Me.Add(Fids.OC_PCT_EXECUTED, executed)
            Me.Add(Fids.OC_REMAINING, remaining)
            Me.Add(Fids.OC_OPEN, open)
            Me.Add(Fids.OC_BID, bid)
            Me.Add(Fids.OC_ASK, ask)
            Me.Add(Fids.OC_LAST, last)
        End Sub

        Private Shared nextId As Integer = 1
        Private Shared rand As System.Random = New System.Random

        Public Shared Function GenerateRandom() As OrderAgreementC
            Dim index As Integer
            Do
                index = CInt(rand.NextDouble() * TypeSystemC.Symbols.Length)
            Loop Until (index >= 0 And index <= 11)

            Dim symbol As String = TypeSystemC.Symbols(index)
            Dim bag_name As String = "Bag " & CChar("A" + CStr(rand.NextDouble() * 4))
            Dim side As String = IIf((rand.NextDouble() > 0.5), "B", "S")
            Dim quantity As Long = CInt(rand.NextDouble() * 10 + 1) * 100
            Dim value As Double = CDbl(CInt(rand.NextDouble() * 1000000))
            Dim working As Long = CInt(rand.NextDouble() * quantity)
            Dim remaining As Long = quantity - working
            Dim executed As Double = CDbl(CInt(CDbl(working) / quantity * 1000.0)) / 10.0

            nextId += 1
            Return New OrderAgreementC(nextId, symbol, bag_name, side, quantity, value, working, remaining, executed, New Decimal(0.0), New Decimal(0.0), New Decimal(0.0), New Decimal(0.0))
        End Function
    End Class
End Namespace
