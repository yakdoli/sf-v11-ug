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
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid.Grouping

Namespace MarketSimulation
	Friend Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		''' 

		Public Shared NumberOfRows As Integer = 100 ' How many orders in grid.
		Public Shared TimerUpdate As Integer = 200 ' How often market data gets updated

		<STAThread> _
		Shared Sub Main()
#If SyncfusionFramework2_0 Then
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
#End If
			Dim form As OrderAgreementQueuerC = New OrderAgreementQueuerC()
			AddHandler form.Load, AddressOf form_Load

			Application.Run(form)
		End Sub

		Private Shared Sub form_Load(ByVal sender As Object, ByVal e As EventArgs)
			QuoteManagerC.Manager.Subscribe(TypeSystemC.Symbols)

		End Sub
	End Class
End Namespace