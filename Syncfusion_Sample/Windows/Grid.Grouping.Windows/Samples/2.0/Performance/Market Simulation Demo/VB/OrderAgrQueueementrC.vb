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
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms

Namespace MarketSimulation
	Friend Class OrderAgreementQueuerC
		Inherits MetroForm
		Private quotesUpdateDelegate As QuoteManagerC.QuotesUpdatedDelegate

		' Added these to try and improve performance
		Private symbolColumn As FieldDescriptor
		Private openColumn As FieldDescriptor
		Private bidColumn As FieldDescriptor
		Private askColumn As FieldDescriptor
		Private lastColumn As FieldDescriptor
		Private panel1 As Panel
		Private grid As GridC

		Private symbolRecordMap As New RecordListDictionary()

		Public Sub New()
			InitializeComponent()
            grid.SetStyles()
			LoadData()
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
		End Sub

		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function


		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)

			BeginInvoke(New MethodInvoker(AddressOf subscribeQuotes))
		End Sub

		Private Sub subscribeQuotes()
			Application.DoEvents()
			AddHandler QuoteManagerC.Manager.QuotesUpdate, AddressOf Manager_QuotesUpdate
		End Sub

		Private Sub Manager_QuotesUpdate(ByVal quoteList() As QuoteC)
			' Quote updates come in on a separate thread, so call Control.Invoke()
			Try
				If Not IsDisposed Then
					Invoke(quotesUpdateDelegate, New Object() { quoteList })
				End If
			Catch e1 As Exception
			End Try
		End Sub

		Private Sub QuotesUpdate(ByVal quoteList() As QuoteC)
			If grid.IsDisposed Then
				Return
			End If

			For Each quote As QuoteC In quoteList
				If symbolRecordMap.ContainsKey(quote.Symbol) Then
					For Each record As Record In symbolRecordMap(quote.Symbol)
						Dim data As DataRow = CType(record.GetData(), DataRow)
						data.BeginEdit()
						data(openColumn.MappingName) = quote.Open
						data(bidColumn.MappingName) = quote.Bid
						data(askColumn.MappingName) = quote.Ask
						data(lastColumn.MappingName) = quote.Last
						data.EndEdit()
					Next record
				End If
			Next quote

			Me.grid.Update() ' calls PaintUpdateRecordFields.
		End Sub

		Protected Sub LoadData()
			' In this prototype, the orders will not change... but the market data will
            Dim records As OrderAgreementListC = New OrderAgreementListC()

            Dim i As Integer = 0
            Do While i < Program.NumberOfRows
                Dim orderAgreement As OrderAgreementC = OrderAgreementC.GenerateRandom()
                records.Add(orderAgreement)
                i += 1
            Loop

            Dim table As DataTable = GridC.CreateDataTable(records)

            grid.BindToCurrencyManager = False
            grid.AllowSwapDataViewWithDataTableList = True
            grid.DataSource = table

            symbolColumn = grid.TableDescriptor.Fields("Symbol")
            openColumn = grid.TableDescriptor.Fields("Opn")
            bidColumn = grid.TableDescriptor.Fields("Bid")
            askColumn = grid.TableDescriptor.Fields("Ask")
            lastColumn = grid.TableDescriptor.Fields("Last")

            ' Cache symbol -> records map for faster market data updates
            Dim count As Integer = grid.Table.Records.Count
            Dim n As Integer = 0
            Do While n < count
                Dim record As Record = grid.Table.Records(n)
                Dim symbol As String = CStr(record.GetValue(symbolColumn))
                If symbol Is Nothing Then
                    GoTo Continue1
                End If

                Dim recordList As RecordList
                If symbolRecordMap.ContainsKey(symbol) Then
                    recordList = symbolRecordMap(symbol)
                Else
                    recordList = New RecordList
                    symbolRecordMap.Add(symbol, recordList)
                End If
                recordList.Add(record)
                n += 1
Continue1:
            Loop
            Me.DropShadow = True
            grid.GridVisualStyles = GridVisualStyles.Metro
            quotesUpdateDelegate = New QuoteManagerC.QuotesUpdatedDelegate(AddressOf QuotesUpdate)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Protected Sub InitializeComponent()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.grid = New MarketSimulation.GridC()
			Me.panel1.SuspendLayout()
			CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.grid)
			Me.panel1.Location = New System.Drawing.Point(17, 12)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(813, 426)
			Me.panel1.TabIndex = 0
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			' 
			' grid
			' 
			Me.grid.BackColor = System.Drawing.SystemColors.Window
			Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
			Me.grid.Location = New System.Drawing.Point(0, 0)
			Me.grid.Name = "grid"
			Me.grid.Size = New System.Drawing.Size(813, 426)
			Me.grid.TabIndex = 1
			Me.grid.Text = "gridGroupingControl1"
			' 
			' OrderAgreementQueuerC
			' 
			Me.BackColor = Color.White
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(846, 455)
			Me.Controls.Add(Me.panel1)
			Me.DropShadow = True
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.Name = "OrderAgreementQueuerC"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Market Simulation Demo"
			Me.panel1.ResumeLayout(False)
			CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				RemoveHandler QuoteManagerC.Manager.QuotesUpdate, AddressOf Manager_QuotesUpdate
				QuoteManagerC.Manager.Dispose()
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#End Region
	End Class

	#If SyncfusionFramework2_0 Then
	Friend Class RecordList
		Inherits List(Of Record)
	End Class

	Friend Class RecordListDictionary
		Inherits Dictionary(Of String, RecordList)
	End Class
#Else
	Friend Class RecordList
		Inherits ArrayList
		Default Public Shadows Property Item(ByVal index As Integer) As Record
			Get
				Return CType(MyBase.Item(index), Record)
			End Get
			Set(ByVal value As Record)
				MyBase.Item(index) = value
			End Set
		End Property
	End Class

	Friend Class RecordListDictionary
		Inherits Hashtable
		Default Public Property Item(ByVal key As String) As RecordList
			Get
				Return CType(MyBase.Item(key), RecordList)
			End Get
			Set(ByVal value As RecordList)
				MyBase.Item(key) = value
			End Set
		End Property
	End Class
#End If
End Namespace