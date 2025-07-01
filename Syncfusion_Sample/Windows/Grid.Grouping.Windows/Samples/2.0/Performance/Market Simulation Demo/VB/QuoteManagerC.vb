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
Imports System.Timers

Namespace MarketSimulation
#If SyncfusionFramework2_0 Then
	Friend Class QuoteCDictionoary : Inherits Dictionary([Of] String : Implements QuoteC)
	End Class
	Friend Class QuoteCList : Inherits List([Of] QuoteC)
	End Class
#Else
	Friend Class QuoteCDictionoary : Inherits Hashtable
        Default Public Overloads Property Item(ByVal key As String) As QuoteC
            Get
                Return CType(MyBase.Item(key), QuoteC)
            End Get
            Set(ByVal Value As QuoteC)
                MyBase.Item(key) = Value
            End Set
        End Property
    End Class

	Friend Class QuoteCList : Inherits ArrayList
		Public Shadows Default Property Item(ByVal index As Integer) As QuoteC
			Get
				Return CType(MyBase.Item(index), QuoteC)
			End Get
			Set
				MyBase.Item(index) = Value
			End Set
		End Property
	End Class
#End If

	Friend Class QuoteManagerC : Implements IDisposable
		Private throttleTimer As Timer
		Private quotesMap As QuoteCDictionoary = New QuoteCDictionoary()
		Private changedQuotes As QuoteCList = New QuoteCList()
		Public Delegate Sub QuotesUpdatedDelegate(ByVal quoteList As QuoteC())
		Public Event QuotesUpdate As QuotesUpdatedDelegate

		Private Shared manager_Renamed As QuoteManagerC = New QuoteManagerC()
		Public Shared ReadOnly Property Manager() As QuoteManagerC
			Get
				Return manager_Renamed
			End Get
		End Property

		Public Sub New()
			throttleTimer = New Timer(Program.TimerUpdate)
			AddHandler throttleTimer.Elapsed, AddressOf throttleTimer_Elapsed
			throttleTimer.Start()
		End Sub

		' Market data simulator
		Private Shared gotFirstQuote As Boolean = False
		Private rand As Random = New Random()
		Private Sub throttleTimer_Elapsed(ByVal sender As Object, ByVal e As ElapsedEventArgs)
			Dim changedQuoteArray As QuoteC() = Nothing

			Dim update As Boolean = False

			Dim ticks As Integer = Environment.TickCount

            'Temporary market data simulator
            Dim list As QuoteCList = New QuoteCList
            Dim symbol As String
            For Each symbol In TypeSystemC.Symbols
                Dim quote As QuoteC = quotesMap(symbol)

                If gotFirstQuote Then
                    If rand.NextDouble() > 0.9 Then
                        update = True
                        If rand.NextDouble() > 0.5 Then
                            quote.Ask += 0.01
                        Else
                            quote.Ask -= 0.01
                        End If

                        If rand.NextDouble() > 0.5 Then
                            quote.Bid = quote.Ask - New Decimal(0.05)
                        Else
                            quote.Bid = quote.Ask - New Decimal(0.1)
                        End If

                        If rand.NextDouble() > 0.5 Then
                            If rand.NextDouble() > 0.5 Then
                                quote.Last = quote.Bid
                            Else
                                quote.Last = quote.Ask
                            End If
                        End If

                        list.Add(quote)
                    End If
                Else
                    list.Add(quote)
                End If
            Next symbol

            If (Not gotFirstQuote) AndAlso Not QuotesUpdateEvent Is Nothing Then
                gotFirstQuote = True
                update = True
            End If
            changedQuoteArray = New QuoteC(list.Count - 1) {}
            list.CopyTo(changedQuoteArray, 0)

            If update AndAlso Not QuotesUpdateEvent Is Nothing Then
                RaiseEvent QuotesUpdate(changedQuoteArray)
            End If

            count += 1
            tickCounter += Environment.TickCount - ticks

            If count > 10 Then
                If tickCounter / count > throttleTimer.Interval Then
                    ' if painting is too slow avoid locking up computer with backlog of timer events
                    throttleTimer.Interval = tickCounter / count + 10
                    Console.WriteLine("Changed interval to {0}", throttleTimer.Interval)
                End If
                count = 0
                tickCounter = 0
            End If
		End Sub

		Private tickCounter As Integer
		Private count As Integer

        Public Sub Subscribe(ByVal symbols As String())
            Dim symbol As String
            For Each symbol In symbols
                Subscribe(symbol)
            Next symbol
        End Sub

        Private Sub Subscribe(ByVal symbol As String)
            If quotesMap.ContainsKey(symbol) Then
                Return
            End If

            quotesMap(symbol) = New QuoteC(symbol)

            ' Market data simluator.... put some random price info in
            Dim quote As QuoteC = quotesMap(symbol)

            Dim quoteTimesHundred As Integer = CInt(2000 + (rand.NextDouble() * 8000))
            quote.Ask = New Decimal(quoteTimesHundred) / New Decimal(100.0)
            quote.Bid = quote.Ask - New Decimal(0.05)
            quote.Last = quote.Ask
            quote.Open = quote.Ask
        End Sub

#Region "IDisposable Members"

        Public Sub Dispose() Implements IDisposable.Dispose
            Me.throttleTimer.Dispose()
        End Sub

#End Region
    End Class
End Namespace
