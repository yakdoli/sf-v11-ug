Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid

Namespace ComboboxCells
	Partial Public Class EventTracer
		Inherits UserControl
		Public eventtype As String = ""
		Public gridCheck As String= ""
		Public mouseCheck As String = ""
		Public cellCheck As String = ""
		Public Sub New()
			dt = New DataTable()
			dt.Columns.Add("Event")
			dt.Columns.Add("Description")
			t = New Timer()
			t.Interval = 10
			t.Enabled = True
			t.Start()
			AddHandler t.Tick, AddressOf t_Tick
			InitializeComponent()
			output.HScrollPixel = True
		End Sub
		Private t As Timer
		Private dt As DataTable

		Private _enabled As Boolean = False
		Public Shadows Property Enabled() As Boolean
			Get
				Return _enabled
			End Get
			Set(ByVal value As Boolean)
				_enabled = value
			End Set
		End Property
		Private pcount As Integer = 0
		Public Sub clear()
			Me.output.RowCount = 0
			Me.dt.Rows.Clear()
		End Sub
		Private Sub t_Tick(ByVal sender As Object, ByVal e As EventArgs)
			If dt.Rows.Count<> pcount Then
				pcount = dt.Rows.Count
				Me.output.RowCount = dt.Rows.Count
				Me.output.PopulateValues(GridRangeInfo.Cells(1, 1, dt.Rows.Count, dt.Columns.Count), dt)
				Me.output.ScrollCellInView(GridRangeInfo.Row(dt.Rows.Count))
				Me.output.CurrentCell.MoveTo(GridRangeInfo.Row(dt.Rows.Count))
				Me.output.Invalidate()
				AddHandler output.CurrentCellActivating, AddressOf output_CurrentCellActivating
			End If
		End Sub

		Private Sub output_CurrentCellActivating(ByVal sender As Object, ByVal e As GridCurrentCellActivatingEventArgs)
			e.Cancel = True
		End Sub

		Public Sub AppendOutput(ByVal name As String, ByVal e As EventArgs)
			If gridCheck <> "" OrElse cellCheck<>"" OrElse mouseCheck<>"" Then
				If eventtype.Trim().Equals(gridCheck) OrElse eventtype.Trim().Equals(mouseCheck) OrElse eventtype.Trim().Equals(cellCheck) Then
					'Console.WriteLine(eventtype.ToString() + " : " + check.ToString());

					Dim s1 As String = ""
					Dim s2 As String = ""

					s1 = name
					s2 = e.ToString()

					If s1.Length > 0 AndAlso s2.Length > 0 Then
						If dt.Rows.Count < 1000 Then
							Dim dr As DataRow = dt.NewRow()
							dr(0) = s1
							dr(1) = s2
							dt.Rows.Add(dr)
						ElseIf dt.Rows.Count = 1000 Then
							For i As Integer = 0 To 99
								dt.Rows.RemoveAt(i)
							Next i
							Dim dr As DataRow = dt.NewRow()
							dr(0) = s1
							dr(1) = s2
							dt.Rows.Add(dr)
						End If
					End If
				End If
			End If
		End Sub
	End Class
End Namespace