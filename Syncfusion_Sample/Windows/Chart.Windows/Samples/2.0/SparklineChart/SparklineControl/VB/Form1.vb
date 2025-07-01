#Region "Copyright Syncfusion Inc. 2001 - 2011"
' Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Syncfusion.Windows.Forms.Chart.SparkLine
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Windows.Forms.Tools

Public Class Form1
    Private intArray(,) As Double
    Private sparkline(,) As SparkLine = New SparkLine(13, 2) {}
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim host2 As ToolStripControlHost = New ToolStripControlHost(Me.panel2)
        Me.ToolStripEx4.Items.Add(host2)
        Dim host1 As ToolStripControlHost = New ToolStripControlHost(Me.panel1)
        Me.ToolStripEx4.Items.Add(host1)
        Me.gridControl1.Rows.DefaultSize = 30
        Me.gridControl1.Cols.DefaultSize = 95
        Me.gridControl1.ColWidths(10) = 160
        SparkLineSource()

    End Sub
#Region "InitializeSparkline"
    Private Sub SparkLineSource()
        Dim r As Random = New Random()

        Me.intArray = New Double(13, 8) {}

        For i As Integer = 0 To 13
            For j As Integer = 0 To 8
                Me.intArray(i, j) = r.Next(-50, 300)
            Next j
        Next i

        For i As Integer = 0 To 13
            For j As Integer = 0 To 8
                Me.gridControl1(i + 1, j + 1).CellValue = Me.intArray(i, j)
            Next j

        Next i

        For i As Integer = 0 To 13
            For j As Integer = 0 To 2
                sparkline(i, j) = New SparkLine()
            Next j
        Next i

        AddHandler gridControl1.PrepareViewStyleInfo, AddressOf gridControl1_PrepareViewStyleInfo
        Me.gridControl1.Refresh()
    End Sub
#End Region
    '#Region "Helper Method"
    Private Sub gridControl1_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs)
        Dim sourceItem() As Double = New Double(8) {}
        If e.ColIndex > 9 AndAlso e.RowIndex > 0 AndAlso e.RowIndex <= 14 Then
            For j As Integer = 0 To 8
                If Me.gridControl1(e.RowIndex, j + 1).CellValue.ToString() <> "" Then
                    sourceItem(j) = Convert.ToDouble(Me.gridControl1(e.RowIndex, j + 1).CellValue)
                End If
            Next j


            Me.sparkline(e.RowIndex - 1, e.ColIndex - 8).Source = sourceItem
            e.Style.CellType = "Control"

            e.Style.Control = Me.sparkline(e.RowIndex - 1, e.ColIndex - 8)
        End If
    End Sub
    Private Sub toolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripButton3.Click
        For i As Integer = 0 To 13
            For j As Integer = 0 To 2
                sparkline(i, j).Type = SparkLineType.WinLoss

            Next j
        Next i
        Me.gridControl1.Refresh()
    End Sub

    Private Sub toolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripButton2.Click
        For i As Integer = 0 To 13
            For j As Integer = 0 To 2
                sparkline(i, j).Type = SparkLineType.Column
                sparkline(i, j).Markers.ShowNegativePoint = False
                If toolStripCheckBox3.Checked Then
                    sparkline(i, j).Markers.ShowNegativePoint = True
                End If

            Next j
        Next i
        Me.gridControl1.Refresh()
    End Sub

    Private Sub toolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripButton1.Click
        For i As Integer = 0 To 13
            For j As Integer = 0 To 2
                sparkline(i, j).Type = SparkLineType.Line
                sparkline(i, j).Markers.ShowNegativePoint = False
                If toolStripCheckBox3.Checked Then
                    sparkline(i, j).Markers.ShowNegativePoint = True
                End If
            Next j
        Next i
        Me.gridControl1.Refresh()
    End Sub

    Private Sub toolStripCheckBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripCheckBox6.Click
        If toolStripCheckBox6.Checked Then
            For i As Integer = 0 To 13
                For j As Integer = 0 To 2
                    sparkline(i, j).Markers.ShowMarker = True
                Next j
            Next i
        Else
            For i As Integer = 0 To 13
                For j As Integer = 0 To 2
                    sparkline(i, j).Markers.ShowMarker = False
                Next j
            Next i
        End If
        Me.gridControl1.Refresh()
    End Sub

    Private Sub toolStripCheckBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripCheckBox5.Click
        If toolStripCheckBox5.Checked Then
            For i As Integer = 0 To 13
                For j As Integer = 0 To 2
                    sparkline(i, j).Markers.ShowEndPoint = True
                Next j
            Next i
        Else
            For i As Integer = 0 To 13
                For j As Integer = 0 To 2
                    sparkline(i, j).Markers.ShowEndPoint = False
                Next j
            Next i
        End If
        Me.gridControl1.Refresh()
    End Sub

    Private Sub toolStripCheckBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripCheckBox4.Click
        If toolStripCheckBox4.Checked Then
            For i As Integer = 0 To 13
                For j As Integer = 0 To 2
                    sparkline(i, j).Markers.ShowStartPoint = True
                Next j
            Next i
        Else
            For i As Integer = 0 To 13
                For j As Integer = 0 To 2
                    sparkline(i, j).Markers.ShowStartPoint = False
                Next j
            Next i
        End If
        Me.gridControl1.Refresh()
    End Sub

    Private Sub toolStripCheckBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripCheckBox3.Click
        If toolStripCheckBox3.Checked Then
            For i As Integer = 0 To 13
                For j As Integer = 0 To 2
                    sparkline(i, j).Markers.ShowNegativePoint = True
                Next j
            Next i
        Else
            For i As Integer = 0 To 13
                For j As Integer = 0 To 2
                    sparkline(i, j).Markers.ShowNegativePoint = False
                Next j
            Next i

        End If
        Me.gridControl1.Refresh()
    End Sub

    Private Sub toolStripCheckBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripCheckBox2.Click
        If toolStripCheckBox2.Checked Then
            For i As Integer = 0 To 13
                For j As Integer = 0 To 2
                    sparkline(i, j).Markers.ShowLowPoint = True
                Next j
            Next i
        Else
            For i As Integer = 0 To 13
                For j As Integer = 0 To 2
                    sparkline(i, j).Markers.ShowLowPoint = False
                Next j
            Next i
        End If
        Me.gridControl1.Refresh()
    End Sub

    Private Sub toolStripCheckBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripCheckBox1.Click
        If toolStripCheckBox1.Checked Then
            For i As Integer = 0 To 13
                For j As Integer = 0 To 2
                    sparkline(i, j).Markers.ShowHighPoint = True
                Next j
            Next i
        Else

            For i As Integer = 0 To 13
                For j As Integer = 0 To 2
                    sparkline(i, j).Markers.ShowHighPoint = False
                Next j
            Next i

        End If
        Me.gridControl1.Refresh()
    End Sub

    Private Sub toolStripGallery1_GalleryItemClicked(ByVal sender As System.Object, ByVal args As Syncfusion.Windows.Forms.Tools.ToolStripGalleryItemEventArgs) Handles toolStripGallery1.GalleryItemClicked
        Dim interior As Color = Color.Black
        Select Case args.GalleryItem.ImageIndex
            Case 0
                interior = Color.DarkBlue
            Case 1
                interior = Color.Maroon
            Case 2
                interior = Color.DarkGreen
            Case 3
                interior = Color.FromArgb(30, 75, 120)
            Case 4
                interior = Color.FromArgb(49, 134, 156)
            Case 5
                interior = Color.Brown
            Case 6
                interior = Color.FromArgb(57, 93, 140)
            Case 7
                interior = Color.FromArgb(148, 52, 49)
            Case 8
                interior = Color.Green
            Case 9
                interior = Color.FromArgb(113, 51, 154)
            Case 10
                interior = Color.FromArgb(77, 171, 200)
            Case 11
                interior = Color.FromArgb(245, 154, 64)
            Case 12
                interior = Color.FromArgb(90, 142, 206)
        End Select


        For i As Integer = 0 To 13
            For j As Integer = 0 To 2
                sparkline(i, j).LineStyle.LineColor = interior
                sparkline(i, j).ColumnStyle.ColumnColor = New Syncfusion.Drawing.BrushInfo(interior)
            Next j
        Next i
        Me.gridControl1.Refresh()
    End Sub

    Private Sub colorPickerUIAdv1_Picked(ByVal sender As System.Object, ByVal args As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs) Handles colorPickerUIAdv1.Picked
        For i As Integer = 0 To 13
            For j As Integer = 0 To 2
                sparkline(i, j).LineStyle.LineColor = args.Color
                sparkline(i, j).ColumnStyle.ColumnColor = New Syncfusion.Drawing.BrushInfo(args.Color)
            Next j
        Next i
        Me.gridControl1.Refresh()
        ' Ensures that the PopupControlContainer is closed after the selection of a color.
        Dim cc As ColorPickerUIAdv = TryCast(sender, ColorPickerUIAdv)
        Dim pcc As Syncfusion.Windows.Forms.PopupControlContainer = TryCast(cc.Parent, Syncfusion.Windows.Forms.PopupControlContainer)
        pcc.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done)
    End Sub

    Private Sub ColorPickerUIAdv2_Picked(ByVal sender As System.Object, ByVal args As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs) Handles ColorPickerUIAdv2.Picked
        For i As Integer = 0 To 13
            For j As Integer = 0 To 2
                sparkline(i, j).Markers.HighPointColor = New Syncfusion.Drawing.BrushInfo(args.Color)
            Next j
        Next i
        Me.gridControl1.Refresh()
        ' Ensures that the PopupControlContainer is closed after the selection of a color.
        Dim cc As ColorPickerUIAdv = TryCast(sender, ColorPickerUIAdv)
        Dim pcc As Syncfusion.Windows.Forms.PopupControlContainer = TryCast(cc.Parent, Syncfusion.Windows.Forms.PopupControlContainer)
        pcc.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done)
    End Sub

    Private Sub ColorPickerUIAdv3_Picked(ByVal sender As System.Object, ByVal args As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs) Handles ColorPickerUIAdv3.Picked
        For i As Integer = 0 To 13
            For j As Integer = 0 To 2
                sparkline(i, j).Markers.LowPointColor = New Syncfusion.Drawing.BrushInfo(args.Color)
            Next j
        Next i
        Me.gridControl1.Refresh()
        ' Ensures that the PopupControlContainer is closed after the selection of a color.
        Dim cc As ColorPickerUIAdv = TryCast(sender, ColorPickerUIAdv)
        Dim pcc As Syncfusion.Windows.Forms.PopupControlContainer = TryCast(cc.Parent, Syncfusion.Windows.Forms.PopupControlContainer)
        pcc.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done)
    End Sub

    Private Sub ColorPickerUIAdv4_Picked(ByVal sender As System.Object, ByVal args As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs) Handles ColorPickerUIAdv4.Picked
        For i As Integer = 0 To 13
            For j As Integer = 0 To 2
                sparkline(i, j).Markers.NegativePointColor = New Syncfusion.Drawing.BrushInfo(args.Color)
            Next j
        Next i
        Me.gridControl1.Refresh()
        ' Ensures that the PopupControlContainer is closed after the selection of a color.
        Dim cc As ColorPickerUIAdv = TryCast(sender, ColorPickerUIAdv)
        Dim pcc As Syncfusion.Windows.Forms.PopupControlContainer = TryCast(cc.Parent, Syncfusion.Windows.Forms.PopupControlContainer)
        pcc.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done)
    End Sub

    Private Sub ColorPickerUIAdv5_Picked(ByVal sender As System.Object, ByVal args As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs) Handles ColorPickerUIAdv5.Picked
        For i As Integer = 0 To 13
            For j As Integer = 0 To 2
                sparkline(i, j).Markers.StartPointColor = New Syncfusion.Drawing.BrushInfo(args.Color)
            Next j
        Next i
        Me.gridControl1.Refresh()
        ' Ensures that the PopupControlContainer is closed after the selection of a color.
        Dim cc As ColorPickerUIAdv = TryCast(sender, ColorPickerUIAdv)
        Dim pcc As Syncfusion.Windows.Forms.PopupControlContainer = TryCast(cc.Parent, Syncfusion.Windows.Forms.PopupControlContainer)
        pcc.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done)
    End Sub

    Private Sub ColorPickerUIAdv6_Picked(ByVal sender As System.Object, ByVal args As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs) Handles ColorPickerUIAdv6.Picked
        For i As Integer = 0 To 13
            For j As Integer = 0 To 2
                sparkline(i, j).Markers.EndPointColor = New Syncfusion.Drawing.BrushInfo(args.Color)
            Next j
        Next i
        Me.gridControl1.Refresh()
        ' Ensures that the PopupControlContainer is closed after the selection of a color.
        Dim cc As ColorPickerUIAdv = TryCast(sender, ColorPickerUIAdv)
        Dim pcc As Syncfusion.Windows.Forms.PopupControlContainer = TryCast(cc.Parent, Syncfusion.Windows.Forms.PopupControlContainer)
        pcc.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done)
    End Sub

    Private Sub ColorPickerUIAdv7_Picked(ByVal sender As System.Object, ByVal args As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs) Handles ColorPickerUIAdv7.Picked
        For i As Integer = 0 To 13
            For j As Integer = 0 To 2
                sparkline(i, j).Markers.MarkerColor = New Syncfusion.Drawing.BrushInfo(args.Color)
            Next j
        Next i
        Me.gridControl1.Refresh()
        ' Ensures that the PopupControlContainer is closed after the selection of a color.
        Dim cc As ColorPickerUIAdv = TryCast(sender, ColorPickerUIAdv)
        Dim pcc As Syncfusion.Windows.Forms.PopupControlContainer = TryCast(cc.Parent, Syncfusion.Windows.Forms.PopupControlContainer)
        pcc.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done)
    End Sub
End Class
