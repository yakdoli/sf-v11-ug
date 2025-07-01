#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms

Namespace TraderGridTest

    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1 : Inherits MetroForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing
        Private m_timer As Timer
        Private m_set As ArrayList
        Private m_syncGrid As GridControl
        Private rand As System.Random
        Private m_numUpdatesPerTick As Integer = 20
        Private shouldInsert As Boolean = False

        Private toggleInsertRemove As Integer = 20 ' toggle between inserting and removing after n inserts/n removals.
        Private insertRemoveModulus As Integer = 2 ' frequency of insert / remove : every n timer ticks
        Private initialRowCount As Integer = 50

        ' Alter this integer to change the type of test


        Private drawDirectToDC As Boolean = True ' Draw text directly to graphics context instead of Invalidate / Update messages

        Private drawTextUsingGDI As Boolean = True ' Enable GDI drawing instead of GDI+

        Private disableAlphaBlendForHeaderCells As Boolean = True ' Don't use alphablending for header cells.

        Private disableDottedGridLines As Boolean = True ' Do not use dotted grid lines - use solid lines instead.

        Private disablePrepareViewStyleInfo As Boolean = True ' Disable PrepareViewStyleInfo events if not needed.

        Private useGDIExtTextOutInsteadOfDrawText As Boolean = True ' When text does not need to be clipped and wrapped use faster ExtTextOut routine.
        Private showNumberedRowHeaders As Boolean = False ' Show numbered row headers
        Private allowChangeTopRowWhenInsertBeforeView As Boolean = True ' Set this true if you want to increase/decrease the TopRowIndex when the grid is scrolled down
        ' and rows are inserted or removed before the first visible row
        Private insertRemoveCount As Integer = 1 ' use 1 if you want to check out inserting and removing rows

        Public Sub New()
            Me.SetStyle(ControlStyles.ResizeRedraw, True)

            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            rand = New Random(DateTime.Now.Second)

            ' Every 10 milliseconds 5 updates.
            m_syncGrid = New GridControl()
            
            AddHandler m_syncGrid.QueryCellInfo, AddressOf m_syncGrid_QueryCellInfo
            AddHandler m_syncGrid.SaveCellInfo, AddressOf m_syncGrid_SaveCellInfo
            AddHandler m_syncGrid.QueryRowCount, AddressOf m_syncGrid_QueryRowCount
            AddHandler m_syncGrid.QueryColCount, AddressOf m_syncGrid_QueryColCount
            m_syncGrid.SmoothControlResize = False

            m_syncGrid.BaseStylesMap("Standard").StyleInfo.Enabled = False
            m_syncGrid.BaseStylesMap("Standard").StyleInfo.CellType = "Static"
            m_syncGrid.AllowDragSelectedRows = False
            m_syncGrid.AllowSelection = GridSelectionFlags.None
            m_syncGrid.ResizeRowsBehavior = GridResizeCellsBehavior.None
            Dim style As GridStyleInfo = m_syncGrid.BaseStylesMap("Header").StyleInfo
            style.TextColor = Color.MidnightBlue
            style.Font.Facename = "Verdana"
            style.Borders.All = New GridBorder(GridBorderStyle.Solid, Color.LightGray, GridBorderWeight.Thin)
            m_set = New ArrayList()

            rand = New Random(DateTime.Now.Second)
            Dim i As Integer
            For i = 0 To initialRowCount - 1
                'INSTANT VB NOTE: The local variable next was renamed since it is a keyword in VB:
                Dim next_Renamed As Integer = rand.[Next](100)
                m_set.Add(New Object() {"Hello world", next_Renamed + 1, next_Renamed + 2, next_Renamed + 3, next_Renamed + 4, next_Renamed + 5, next_Renamed + 6, next_Renamed + 7, next_Renamed + 8, next_Renamed + 9, next_Renamed + 10, next_Renamed + 11, next_Renamed + 12, next_Renamed + 13, next_Renamed + 14, next_Renamed + 15, next_Renamed + 16, next_Renamed + 17, next_Renamed + 18, next_Renamed + 19, next_Renamed + 20})
            Next i
            Me.Controls.Add(m_syncGrid)

            m_timer = New Timer
            m_timer.Interval = 30
            AddHandler m_timer.Tick, AddressOf m_timer_Tick
            m_timer.Start()

            ' Don't use alphablending for header cells.
            If disableAlphaBlendForHeaderCells Then
                Me.m_syncGrid.BaseStylesMap("Column Header").StyleInfo.BackColor = SystemColors.Control
                Me.m_syncGrid.BaseStylesMap("Row Header").StyleInfo.BackColor = SystemColors.Control
                Me.m_syncGrid.BaseStylesMap("Header").StyleInfo.BackColor = SystemColors.Control
            End If

            ' Do not use dotted grid lines - use solid lines instead.
            If Me.disableDottedGridLines Then
                Me.m_syncGrid.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
                Me.m_syncGrid.Model.Properties.GridLineColor = SystemColors.ControlLight
            End If

            ' Disable PrepareViewStyleInfo events if not needed.
            Me.m_syncGrid.SupportsPrepareViewStyleInfo = Not disablePrepareViewStyleInfo

            ' Enable GDI drawing instead of GDI+
            If drawTextUsingGDI Then
                AddHandler Me.m_syncGrid.DrawCellDisplayText, AddressOf m_syncGrid_DrawCellDisplayText

                If useGDIExtTextOutInsteadOfDrawText Then
                    Me.m_syncGrid.BaseStylesMap("Standard").StyleInfo.WrapText = False
                    Me.m_syncGrid.BaseStylesMap("Standard").StyleInfo.Trimming = StringTrimming.None
                End If
            End If

            Me.m_syncGrid.VerticalThumbTrack = True
            Me.m_syncGrid.HorizontalThumbTrack = True

            Me.Size = New Size(640, 480)
			Me.m_syncGrid.Location = New Point(Me.Location.X + 10, Me.Location.Y + 10)
			Me.m_syncGrid.Size = New Size(Me.Size.Width - 30, 430)
			Me.m_syncGrid.BorderStyle = BorderStyle.FixedSingle
            Me.m_syncGrid.VScrollBehavior = GridScrollbarMode.Disabled
            Try
                Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
                Me.Icon = ico
            Catch ex As Exception

            End Try
            Me.m_syncGrid.ThemesEnabled = True
            Me.m_syncGrid.GridVisualStyles = GridVisualStyles.Metro
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


        Private Sub m_syncGrid_SaveCellInfo(ByVal sender As Object, ByVal e As GridSaveCellInfoEventArgs)
            ' Don't save changes.
            e.Handled = True
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
                If Not g Is Nothing Then
                    g.Dispose()
                End If
                g = Nothing
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.SuspendLayout()
            '
            'Form1
            '
            Me.DropShadow = True
            Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
            Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
            Me.BorderThickness = 2
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
            Me.MinimizeBox = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(292, 266)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Trader Grid Test Demo"
            Me.ResumeLayout(False)

        End Sub
#End Region



        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub

        Private g As Graphics = Nothing
        Private oldSize As Size = New Size()

        Private icount As Integer = 0
        Private timerCount As Integer = 0

        Private Sub m_timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            timerCount += 1
            Dim gCells As GridRangeInfo = GridRangeInfo.EmptyRange()

            If Not oldSize.Equals(m_syncGrid.ClientSize) Then
                ' Dispose graphics context if size was changed.
                If Not (g Is Nothing) Then
                    g.Dispose()
                End If
                g = Nothing
                oldSize = m_syncGrid.ClientSize
            End If

            If drawDirectToDC AndAlso g Is Nothing Then
                g = m_syncGrid.CreateGridGraphics()
            End If

            Try
                Dim i As Integer = 0
                'ORIGINAL LINE: for (int i = 0; i < m_numUpdatesPerTick; i += 1)
                'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
                Do While i < m_numUpdatesPerTick

                    Dim recNum As Integer = rand.Next(m_set.Count - 1)
                    Dim rowNum As Integer = recNum + 1
                    Dim col As Integer = rand.Next(18) + 1
                    Dim colNum As Integer = col + 1
                    Dim drow As Object() = CType(m_set(recNum), Object())
                    drow(col) = rand.Next(100) '
                    Dim g1 As GridRangeInfo = GridRangeInfo.Cell(rowNum, colNum)

                    gCells = GridRangeInfo.UnionRange(gCells, g1)

                    ' Clear our volatile cache
                    m_syncGrid.ResetVolatileData()

                    ' Handle case when values is change for current cell.
                    If g1.Equals(m_syncGrid.CurrentCell.RangeInfo) Then
                        m_syncGrid.CurrentCell.Model.ResetActiveText(rowNum, colNum)
                    Else

                        ' Draw direct to dc
                        If drawDirectToDC Then
                            Dim bounds As Rectangle = m_syncGrid.RangeInfoToRectangle(g1)
                            If (Not bounds.IsEmpty) Then
                                ' DrawClippedGrid method lets you simply draw the cells at the specified bounds directly to the graphics context.
                                m_syncGrid.DrawClippedGrid(g, bounds)
                            End If
                        End If
                    End If
                    i += 1
                Loop

                If (Not drawDirectToDC) Then
                    m_syncGrid.ResetVolatileData()
                    m_syncGrid.ViewLayout.Lock() ' Prevent subsequent calls to ViewLayout.Reset method from clearing the layout information. Method was added in 3.1.0.x
                    Dim bounds As Rectangle = m_syncGrid.RangeInfoToRectangle(gCells)
                    If (Not bounds.IsEmpty) Then
                        m_syncGrid.Invalidate(bounds)
                        m_syncGrid.Update()
                    End If
                    m_syncGrid.ViewLayout.Unlock()
                End If

                ' Insert or remove a row
                If insertRemoveCount = 0 Then
                    Return
                End If

                If toggleInsertRemove > 0 AndAlso (timerCount Mod insertRemoveModulus) = 0 Then
                    'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
                    'ORIGINAL LINE: icount = icount += 1 Mod (toggleInsertRemove*2);
                    icount = (icount + 1) Mod (toggleInsertRemove * 2)
                    shouldInsert = icount <= toggleInsertRemove

                    Console.WriteLine(m_syncGrid.RowCount)
                    If shouldInsert Then
                        Dim ri As Integer = 0
                        'ORIGINAL LINE: for (int ri = 0; ri < insertRemoveCount; ri += 1)
                        'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
                        Do While ri < insertRemoveCount
                            Dim recNum As Integer = rand.Next(m_set.Count - 1)
                            Dim rowNum As Integer = recNum + 1

                            ' Underlying data structure (this could be a datatable or whatever structure
                            ' you use behind a virtual grid).
                            ' 
                            ' In this case it is a ArrayList

                            'INSTANT VB NOTE: The local variable next was renamed since it is a keyword in VB:
                            Dim next_Renamed As Integer = rand.[Next](100)
                            Dim row As Object() = New Object() {"Hello world", next_Renamed + 1, next_Renamed + 2, next_Renamed + 3, next_Renamed + 4, next_Renamed + 5, next_Renamed + 6, next_Renamed + 7, next_Renamed + 8, next_Renamed + 9, next_Renamed + 10, next_Renamed + 11, next_Renamed + 12, next_Renamed + 13, next_Renamed + 14, next_Renamed + 15, next_Renamed + 16, next_Renamed + 17, next_Renamed + 18, next_Renamed + 19, next_Renamed + 20}
                            m_set.Insert(recNum, row)

                            ' Now that the change was done in the underlying datasource we need
                            ' to tell the grid to reflect those changes:

                            m_syncGrid.Model.ResetVolatileData()

                            ' Old way:
                            If (Not drawDirectToDC) Then
                                m_syncGrid.Rows.OnRangeInserting(New GridRangeInsertingEventArgs(rowNum, 1, Nothing))
                                m_syncGrid.Rows.OnRangeInserted(New GridRangeInsertedEventArgs(rowNum, 1, Nothing, True))
                                m_syncGrid.Update()
                            Else
                                ' Optimized way: Directly calling ScrollWindows, don't let ScrollWindow call Invalidate. 

                                If rowNum < m_syncGrid.TopRowIndex Then

                                    If (Not allowChangeTopRowWhenInsertBeforeView) OrElse (Not m_syncGrid.ViewLayout.HasPartialVisibleRows) Then ' checks whether the last row is shown and fully visible
                                        ' in this case we need to insert at top 
                                        rowNum = m_syncGrid.TopRowIndex
                                    Else
                                        ' If record is inserted before viewable area, simply increase
                                        ' the top row so that the viewable area stays the same. No
                                        ' drawing of the screen is needed.
                                        m_syncGrid.InternalSetTopRow(m_syncGrid.TopRowIndex + 1)

                                        m_syncGrid.UpdateScrollBars()
                                        rowNum = -1 ' mark it as handled.

                                        If showNumberedRowHeaders Then
                                            ' Repaint only row headers - they all change
                                            Dim rowHeaderBounds As Rectangle = m_syncGrid.RangeInfoToRectangle(GridRangeInfo.Col(0))
                                            m_syncGrid.DrawClippedGrid(g, rowHeaderBounds)
                                        End If

                                    End If
                                End If

                                If rowNum <> -1 Then
                                    Dim rg As GridRangeInfo = GridRangeInfo.Row(rowNum)
                                    Dim bounds As Rectangle = m_syncGrid.RangeInfoToRectangle(rg)

                                    If (Not bounds.IsEmpty) Then
                                        If showNumberedRowHeaders Then
                                            ' don't scroll row header area - leave it as is (only works if all rows have same height ...)
                                            bounds.X += m_syncGrid.ColWidths(0)

                                            If (Not m_syncGrid.ViewLayout.HasPartialVisibleRows) Then
                                                ' Repaint row headers below last row
                                                Dim rowHeaderBounds As Rectangle = m_syncGrid.RangeInfoToRectangle(GridRangeInfo.Cells(m_syncGrid.RowCount, 0, m_syncGrid.RowCount, 0))
                                                m_syncGrid.DrawClippedGrid(g, rowHeaderBounds)
                                            End If
                                        End If

                                        ' If rows can have different heights:
                                        ' m_syncGrid.ViewLayout.Reset();

                                        Dim scrollBounds As Rectangle = New Rectangle(bounds.Left, bounds.Top, bounds.Right, m_syncGrid.ClientRectangle.Bottom)
                                        m_syncGrid.ScrollWindow(0, bounds.Height, scrollBounds, scrollBounds, False) ' don't cause Invalidate being called.
                                        m_syncGrid.Model.ResetVolatileData()



                                        ' DrawClippedGrid method lets you simply draw the cells at the specified bounds directly to the graphics context.
                                        m_syncGrid.DrawClippedGrid(g, bounds)
                                    End If

                                    m_syncGrid.UpdateScrollBars()
                                End If
                            End If
                            ri += 1
                        Loop
                    Else
                        Dim ri As Integer = 0
                        'ORIGINAL LINE: for (int ri = 0; ri < insertRemoveCount; ri += 1)
                        'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
                        Do While ri < insertRemoveCount
                            Dim recNum As Integer = 5 'rand.Next(m_set.Count - 1);
                            Dim rowNum As Integer = recNum + 1

                            ' Underlying data structure (this could be a datatable or whatever structure
                            ' you use behind a virtual grid).
                            ' 
                            ' In this case it is a ArrayList

                            m_set.RemoveAt(recNum)

                            ' Now that the change was done in the underlying datasource we need
                            ' to tell the grid to reflect those changes:

                            ' Old way:
                            If (Not drawDirectToDC) Then
                                m_syncGrid.Rows.OnRangeRemoving(New GridRangeRemovingEventArgs(rowNum, rowNum + 1))
                                Dim iro As GridModelInsertRangeOptions = New GridModelInsertRangeOptions()
                                iro.RowColSizes = New Integer(m_syncGrid.Rows.DefaultSize - 1) {}
                                m_syncGrid.Rows.OnRangeRemoved(New GridRangeRemovedEventArgs(rowNum, rowNum + 1, iro, True))
                                m_syncGrid.Update()
                            Else
                                ' Optimized way: Directly calling ScrollWindows, don't let ScrollWindow call Invalidate. 

                                If rowNum < m_syncGrid.TopRowIndex Then
                                    If (Not allowChangeTopRowWhenInsertBeforeView) OrElse (Not m_syncGrid.ViewLayout.HasPartialVisibleRows) Then ' checks whether the last row is shown and fully visible
                                        ' in this case we need to insert at top 
                                        rowNum = m_syncGrid.TopRowIndex
                                    Else
                                        ' If record is inserted before viewable area, simply increase
                                        ' the top row so that the viewable area stays the same. No
                                        ' drawing of the screen is needed.
                                        m_syncGrid.InternalSetTopRow(m_syncGrid.TopRowIndex - 1)

                                        m_syncGrid.UpdateScrollBars()
                                        If showNumberedRowHeaders Then
                                            ' Repaint only row headers - they all change
                                            Dim rowHeaderBounds As Rectangle = m_syncGrid.RangeInfoToRectangle(GridRangeInfo.Col(0))
                                            m_syncGrid.DrawClippedGrid(g, rowHeaderBounds)
                                        End If
                                        rowNum = -1 ' mark it as handled.
                                    End If
                                End If

                                If rowNum <> -1 Then
                                    Dim rg As GridRangeInfo = GridRangeInfo.Row(rowNum)
                                    Dim bounds As Rectangle = m_syncGrid.RangeInfoToRectangle(rg)

                                    If (Not bounds.IsEmpty) Then
                                        If showNumberedRowHeaders Then
                                            ' don't scroll row header area - leave it as is (only works if all rows have same height ...)
                                            bounds.X += m_syncGrid.ColWidths(0)
                                        End If

                                        ' If rows can have different heights:
                                        ' m_syncGrid.ViewLayout.Reset();

                                        Dim scrollBounds As Rectangle = New Rectangle(bounds.Left, bounds.Top, bounds.Right, m_syncGrid.ClientRectangle.Bottom)
                                        Dim scrolledInViewBounds As Rectangle = m_syncGrid.ScrollWindow(0, -bounds.Height, scrollBounds, scrollBounds, False) ' don't cause Invalidate being called.
                                        m_syncGrid.Model.ResetVolatileData()


                                        If (Not m_syncGrid.ViewLayout.HasPartialVisibleRows) Then
                                            scrolledInViewBounds = New Rectangle(0, m_syncGrid.ViewLayout.Corner.Y, bounds.Right, bounds.Height)
                                        End If

                                        ' DrawClippedGrid method lets you simply draw the cells at the specified bounds directly to the graphics context.
                                        m_syncGrid.DrawClippedGrid(g, scrolledInViewBounds)
                                    End If

                                    m_syncGrid.UpdateScrollBars()
                                End If
                            End If

                            ri += 1
                        Loop
                    End If
                End If
            Finally

            End Try


        End Sub

        Private colors As Color() = New Color() {Color.FromArgb(&H85, &HBF, &H75), Color.FromArgb(&HDE, &H64, &H13), Color.FromArgb(&HB4, &HE7, &HF2), Color.FromArgb(&HFF, &HBF, &H34), Color.FromArgb(&H82, &H2E, &H1B), Color.FromArgb(&H3A, &H86, &H7E)}

        Private rnd As Random = New Random()

#Region "Syncfusion Virtual Grid Overriders"
        Private Sub m_syncGrid_QueryCellInfo(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)

            Try
                e.Handled = False

                ' Do we have a table yet? 			
                If m_set Is Nothing Then
                    Return
                End If

                ' We don't care about row headers
                If e.ColIndex = 0 Then
                    If (Not showNumberedRowHeaders) Then
                        e.Style.CellValue = " "
                    End If
                    Return
                End If

                ' Column headers
                If e.RowIndex = 0 Then

                    e.Handled = True

                    ' Actual rows
                ElseIf (e.ColIndex > 0) AndAlso (e.RowIndex > 0) Then
                    ' Retrieve the cell value
                    Dim row As Object() = CType(m_set(e.RowIndex - 1), Object())
                    e.Style.CellValue = row(e.ColIndex - 1)
                    e.Handled = True

                    If e.ColIndex > 1 Then
                        Dim v As Integer = (CInt(e.Style.CellValue)) Mod colors.Length
                        e.Style.BackColor = colors(v)
                    End If
                End If
            Catch e1 As Exception
            End Try


        End Sub

        Private Sub m_syncGrid_QueryRowCount(ByVal sender As Object, ByVal e As GridRowColCountEventArgs)
            If m_set Is Nothing Then
                e.Count = 0
                e.Handled = False
                Return
            End If

            e.Handled = True
            e.Count = m_set.Count
        End Sub

        Private Sub m_syncGrid_QueryColCount(ByVal sender As Object, ByVal e As GridRowColCountEventArgs)
            If m_set Is Nothing Then
                e.Count = 0
                e.Handled = False
                Return
            End If
            e.Handled = True
            e.Count = (CType(m_set(0), Object())).Length
        End Sub
#End Region

        Private Sub m_syncGrid_DrawCellDisplayText(ByVal sender As Object, ByVal e As GridDrawCellDisplayTextEventArgs)
            e.Cancel = GridGdiPaint.Instance.DrawText(e.Graphics, e.DisplayText, e.TextRectangle, e.Style)
        End Sub
    End Class
End Namespace
