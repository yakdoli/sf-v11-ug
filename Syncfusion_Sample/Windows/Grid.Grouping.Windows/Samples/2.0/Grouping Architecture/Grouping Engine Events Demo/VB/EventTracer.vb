#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Syncfusion.Windows.Forms.Grid
Public Class EventTracer
    Public Sub New()
        dt = New System.Data.DataTable()
        dt.Columns.Add("Event")
        dt.Columns.Add("Description")
        t = New System.Windows.Forms.Timer()
        t.Interval = 10
        t.Enabled = True
        t.Start()
        AddHandler t.Tick, AddressOf t_Tick
        InitializeComponent()
        output.HScrollPixel = True
    End Sub
    Private t As System.Windows.Forms.Timer
    Private dt As System.Data.DataTable

    Private _enabled As Boolean = False
    Public Overloads Property Enabled() As Boolean
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
    Private Sub t_Tick(ByVal sender As Object, ByVal e As System.EventArgs)
        If dt.Rows.Count <> pcount Then
            pcount = dt.Rows.Count
            Me.output.RowCount = dt.Rows.Count
            Me.output.PopulateValues(GridRangeInfo.Cells(1, 1, dt.Rows.Count, dt.Columns.Count), dt)
            Me.output.ScrollCellInView(GridRangeInfo.Row(dt.Rows.Count))
            Me.output.CurrentCell.MoveTo(GridRangeInfo.Row(dt.Rows.Count))
            Me.output.Invalidate()
        End If
    End Sub

    Public Sub AppendOutput(ByVal name As String, ByVal e As System.EventArgs)
        If (Not Enabled) Then
            Return
        End If

        Dim s1 As String = ""
        Dim s2 As String = ""

        s1 = name
        s2 = e.ToString()

        If s1.Length > 0 AndAlso s2.Length > 0 Then
            If dt.Rows.Count < 1000 Then
                Dim dr As System.Data.DataRow = dt.NewRow()
                dr(0) = s1
                dr(1) = s2
                dt.Rows.Add(dr)
            ElseIf dt.Rows.Count = 1000 Then
                For i As Integer = 0 To 99
                    dt.Rows.RemoveAt(i)
                Next i
                Dim dr As System.Data.DataRow = dt.NewRow()
                dr(0) = s1
                dr(1) = s2
                dt.Rows.Add(dr)
            End If
        End If
    End Sub
End Class
