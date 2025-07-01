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

Imports Microsoft.VisualBasic
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Resources
Imports System.Windows.Forms

Namespace ExcelMarker
    Public Class ExcelMarkerForm
        Inherits MetroForm
        Private gridControl1 As GridControl
        Private excelMarker As ExcelMarkerMouseController = Nothing
        Private mouseDownRow As Integer = -1
        Private mouseDownCol As Integer = -1
        Private oldSelections As System.Collections.Queue = Nothing
        Private alphaBlendValue As Integer = 65
        Private rowBase As Integer = 0
        Private colBase As Integer = 0


        '/ <summary>
        '/ Required designer variable.
        '/ </summary>
        Private components As System.ComponentModel.Container = Nothing


        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()         
			
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

            Me.gridControl1.ControllerOptions = GridControllerOptions.All And Not GridControllerOptions.OleDataSource

            gridControl1.CommandStack.Enabled = False
            gridControl1.ThemesEnabled = True
			Me.gridControl1.BorderStyle=BorderStyle.FixedSingle
            Me.excelMarker = New ExcelMarkerMouseController(gridControl1)
            gridControl1.MouseControllerDispatcher.Add(excelMarker)

            Me.SuspendLayout()

            Dim thickBorder As New GridBorder(GridBorderStyle.Solid, Color.Gray, GridBorderWeight.Medium)

            Dim rowIndex As Integer = rowBase + 1
            Dim colIndex As Integer = colBase + 1

            gridControl1.TableStyle.CheckBoxOptions = New GridCheckBoxCellInfo("True", "False", "", False)

            gridControl1(rowIndex, colIndex).CellType = "CheckBox"
            gridControl1(rowIndex, colIndex).TriState = False
            gridControl1(rowIndex, colIndex).Text = "True"
            gridControl1(rowIndex, colIndex).VerticalAlignment = GridVerticalAlignment.Middle
            gridControl1(rowIndex, colIndex).Description = " ExcelLikeCurrentCell"

            rowIndex += 1
            gridControl1(rowIndex, colIndex).CellType = "CheckBox"
            gridControl1(rowIndex, colIndex).TriState = False
            gridControl1(rowIndex, colIndex).Text = "True"
            gridControl1(rowIndex, colIndex).VerticalAlignment = GridVerticalAlignment.Middle
            gridControl1(rowIndex, colIndex).Description = " ExcelLikeSelectionFrame"

            rowIndex += 1
            gridControl1(rowIndex, colIndex).CellType = "CheckBox"
            gridControl1(rowIndex, colIndex).TriState = False
            gridControl1(rowIndex, colIndex).Text = "True"
            gridControl1(rowIndex, colIndex).VerticalAlignment = GridVerticalAlignment.Middle
            gridControl1(rowIndex, colIndex).Description = " ExcelMarker"

            rowIndex += 1

            rowIndex += 1
            gridControl1(rowIndex, colIndex).Borders.Top = thickBorder
            gridControl1(rowIndex, colIndex).Borders.Left = thickBorder
            gridControl1(rowIndex, colIndex).Borders.Right = thickBorder
            gridControl1(rowIndex, colIndex).Text = "Selection Color"
            gridControl1(rowIndex, colIndex).HorizontalAlignment = GridHorizontalAlignment.Center
            gridControl1(rowIndex, colIndex).VerticalAlignment = GridVerticalAlignment.Bottom
            gridControl1(rowIndex, colIndex).Font.Size = 8
            gridControl1(rowIndex, colIndex).TextColor = Color.Gray
            gridControl1(rowIndex, colIndex).Enabled = False

            rowIndex += 1
            gridControl1(rowIndex, colIndex).Borders.Left = thickBorder
            gridControl1(rowIndex, colIndex).Borders.Right = thickBorder
            gridControl1(rowIndex, colIndex).CellValue = Color.FromName("Highlight") 'Color.FromArgb( 255, 187, 111 );
            gridControl1(rowIndex, colIndex).CellType = "ColorEdit"
            gridControl1(rowIndex, colIndex).TextColor = Color.White
            gridControl1(rowIndex, colIndex).CellValueType = GetType(Color)
            gridControl1(rowIndex, colIndex).HorizontalAlignment = GridHorizontalAlignment.Center
            gridControl1(rowIndex, colIndex).Font.Size = 8

            rowIndex += 1
            gridControl1(rowIndex, colIndex).Borders.Left = thickBorder
            gridControl1(rowIndex, colIndex).Borders.Right = thickBorder
            rowIndex += 1
            gridControl1(rowIndex, colIndex).Borders.Left = thickBorder
            gridControl1(rowIndex, colIndex).Borders.Right = thickBorder
            gridControl1(rowIndex, colIndex).Text = "Alpha Blend Value (0-255)"
            gridControl1(rowIndex, colIndex).HorizontalAlignment = GridHorizontalAlignment.Center
            gridControl1(rowIndex, colIndex).VerticalAlignment = GridVerticalAlignment.Bottom
            gridControl1(rowIndex, colIndex).Font.Size = 8
            gridControl1(rowIndex, colIndex).TextColor = Color.Gray
            gridControl1(rowIndex, colIndex).Enabled = False

            rowIndex += 1
            gridControl1(rowIndex, colIndex).Borders.Left = thickBorder
            gridControl1(rowIndex, colIndex).Borders.Right = thickBorder
            gridControl1(rowIndex, colIndex).CellType = "NumericUpDown"
            gridControl1(rowIndex, colIndex).CellValue = alphaBlendValue
            gridControl1(rowIndex, colIndex).CellValueType = GetType(Integer)
            gridControl1(rowIndex, colIndex).NumericUpDown = New GridNumericUpDownCellInfo(0, 255, 0, 1, True)
            gridControl1(rowIndex, colIndex).HorizontalAlignment = GridHorizontalAlignment.Center
            gridControl1(rowIndex, colIndex).Font.Size = 8

            rowIndex += 1
            gridControl1(rowIndex, colIndex).Borders.Left = thickBorder
            gridControl1(rowIndex, colIndex).Borders.Right = thickBorder

            rowIndex += 1
            gridControl1(rowIndex, colIndex).Borders.Bottom = thickBorder
            gridControl1(rowIndex, colIndex).Borders.Left = thickBorder
            gridControl1(rowIndex, colIndex).Borders.Right = thickBorder

            gridControl1(rowIndex, colIndex).CellType = "PushButton"
            gridControl1(rowIndex, colIndex).Description = "Apply"

            gridControl1.Rows.DefaultSize += 1

            gridControl1.DefaultColWidth = 70
            gridControl1.ColWidths.SetSize(colIndex, 230)

            'add a custom cell control that draws a mitmap
            gridControl1.CellModels.Add("ImageCell", New ImageCellModel(gridControl1.Model))

            'read a bitmap from resources
            'Dim strm As System.IO.Stream = Nothing
            'strm = Me.GetType().Assembly.GetManifestResourceStream("grid.gif")
            'Dim bm As New Bitmap(strm)
            Dim bm As Bitmap = GetImage("Common\Images\Grid\SelectionMarker\grid.gif")

            'set up covered cell to show the bitmap
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(1, 2, 5, 9))
            gridControl1(1, 2).Tag = bm 'Tag used to hold the bitmap
            gridControl1(1, 2).CellType = "ImageCell"

            'set some grid properties
            gridControl1.FloatCellsMode = GridFloatCellsMode.BeforeDisplayCalculation
            gridControl1.AlphaBlendSelectionColor = Color.FromArgb(alphaBlendValue, Color.FromName("Highlight"))
            gridControl1.BorderStyle = BorderStyle.None


            Me.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(7, 3, 10, 6))
            Me.gridControl1(7, 3).Borders.All = New GridBorder(GridBorderStyle.Solid, Color.Orange, GridBorderWeight.Thick)
            Me.gridControl1(7, 3).Text = "Make some selections and then change the Excel-Like properties and selection color properties listed to the left."
            Me.gridControl1(7, 3).Font.Size = 9
            Me.gridControl1(7, 3).Font.Bold = False
            Me.gridControl1(7, 3).Font.Facename = "Segoe UI"
            Me.gridControl1(7, 3).TextColor = Color.Orange
            Me.gridControl1(7, 3).Enabled = False
            Me.gridControl1(7, 3).VerticalAlignment = GridVerticalAlignment.Middle
            Me.gridControl1(7, 3).HorizontalAlignment = GridHorizontalAlignment.Left


            gridControl1.CommandStack.Enabled = True
            gridControl1.CommandStack.UndoStack.Clear()

            gridControl1.Selections.Add(GridRangeInfo.Cells(12, 3, 14, 7))
            gridControl1.CurrentCell.MoveTo(12, 3)


            oldSelections = New Queue()
            oldSelections.Enqueue(GridRangeInfo.Cells(12, 3, 14, 7))

            AddHandler Me.gridControl1.MouseDown, New MouseEventHandler(AddressOf gridControl1_MouseDown)

            AddHandler Me.gridControl1.MouseUp, New MouseEventHandler(AddressOf gridControl1_MouseUp)
            AddHandler Me.gridControl1.SelectionChanging, New Syncfusion.Windows.Forms.Grid.GridSelectionChangingEventHandler(AddressOf gridControl1_SelectionChanging)
            Me.gridControl1.GridVisualStyles = GridVisualStyles.Metro
            Me.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid
            gridControl1.BackColor = Color.White
            Dim style As GridStyleInfo = gridControl1.BaseStylesMap("Header").StyleInfo
            style.Font.Facename = "Segoe UI"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.ResumeLayout()
        End Sub 'New
		
			Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

		
        Private Function GetImage(ByVal bitmapName As String) As Bitmap
            Dim bitmap As Bitmap = Nothing

            For n As Integer = 0 To 9
                If System.IO.File.Exists(bitmapName) Then
                    bitmap = New Bitmap(bitmapName)
                End If

                bitmapName = "..\" & bitmapName
            Next n

            Return bitmap
        End Function

        '/ <summary>
        '/ Clean up any resources being used.
        '/ </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub 'Dispose



        Private Sub InitializeComponent()
            Dim GridCellInfo1 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(245, Byte), Integer))
            Me.gridControl1.ColCount = 23
            Me.gridControl1.DefaultColWidth = 66
            Me.gridControl1.ExcelLikeCurrentCell = True
            Me.gridControl1.ExcelLikeSelectionFrame = True
            Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
            GridCellInfo1.Col = -1
            GridCellInfo1.Row = -1
            GridCellInfo1.StyleInfo.Font.Bold = True
            GridCellInfo1.StyleInfo.Font.Facename = "Segoe UI"
            GridCellInfo1.StyleInfo.Font.Italic = False
            GridCellInfo1.StyleInfo.Font.Size = 9.75!
            GridCellInfo1.StyleInfo.Font.Strikeout = False
            GridCellInfo1.StyleInfo.Font.Underline = False
            GridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            Me.gridControl1.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() {GridCellInfo1})
            Me.gridControl1.Location = New System.Drawing.Point(12, 4)
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RowCount = 65
            Me.gridControl1.Size = New System.Drawing.Size(752, 375)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.Text = "gridControl1"
            '
            'ExcelMarkerForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
            Me.BackColor = System.Drawing.Color.White
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(776, 391)
            Me.Controls.Add(Me.gridControl1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "ExcelMarkerForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Selection Marker Demo"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub 'InitializeComponent

        <STAThread()> _
          Public Shared Sub Main()

            Application.Run(New ExcelMarkerForm())

        End Sub



        'save selections for use in mouseup
        Private Sub gridControl1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

            gridControl1.PointToRowCol(New Point(e.X, e.Y), Me.mouseDownRow, Me.mouseDownCol)
            If mouseDownCol = colBase And gridControl1.CurrentCell.ColIndex <> colBase Then
                'save the old selections so we can reset them later
                oldSelections = New Queue()
                Dim r As GridRangeInfo
                For Each r In gridControl1.Selections.Ranges
                    oldSelections.Enqueue(r)
                Next r
            End If
        End Sub 'gridControl1_MouseDown



        'handle resetting selections after mouseclick in column 1
        Private Sub gridControl1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

            Dim rowIndex, colIndex As Integer
            gridControl1.PointToRowCol(New Point(e.X, e.Y), rowIndex, colIndex)

            If rowIndex <> mouseDownRow Or colIndex <> mouseDownCol Then
                'save the old selections so we can reset them later
                oldSelections = New Queue()
                Dim r As GridRangeInfo
                For Each r In gridControl1.Selections.Ranges
                    oldSelections.Enqueue(r)
                Next r
            End If
            If rowIndex = mouseDownRow And colIndex = mouseDownCol And (gridControl1(rowIndex, colIndex).CellType = "CheckBox" Or gridControl1(rowIndex, colIndex).CellType = "PushButton") Then
                gridControl1.BeginUpdate()

                Select Case rowIndex - rowBase
                    Case 1 'ExcelCurrentCell
                        gridControl1.ExcelLikeCurrentCell = gridControl1(rowBase + 1, colBase + 1).Text = "True"
                    Case 2 'ExcelSelectionFrame
                        gridControl1.ExcelLikeSelectionFrame = gridControl1(rowBase + 2, colBase + 1).Text = "True"
                    Case 3 'ExcelMarker
                        If gridControl1(rowBase + 3, colBase + 1).Text = "True" And excelMarker Is Nothing Then
                            Me.excelMarker = New ExcelMarkerMouseController(gridControl1)
                            gridControl1.MouseControllerDispatcher.Add(excelMarker)
                        Else
                            If gridControl1(rowBase + 3, colBase + 1).Text = "False" And Not (excelMarker Is Nothing) Then
                                gridControl1.MouseControllerDispatcher.Remove(excelMarker)
                                excelMarker = Nothing
                            End If
                        End If
                    Case 11 'apply
                        Dim o As Object = gridControl1(rowBase + 9, colBase + 1).CellValue
                        If TypeOf o Is String Then
                            alphaBlendValue = Integer.Parse(CStr(o))
                        Else
                            If TypeOf o Is Integer Then
                                alphaBlendValue = CInt(o)
                            End If
                        End If
                        o = gridControl1(rowBase + 6, colBase + 1).CellValue
                        If TypeOf o Is String Then
                            gridControl1.AlphaBlendSelectionColor = Color.FromArgb(alphaBlendValue, CType(TypeDescriptor.GetConverter(GetType(Color)).ConvertFromString(CStr(o)), Color))
                        Else
                            If TypeOf o Is Color Then
                                gridControl1.AlphaBlendSelectionColor = Color.FromArgb(alphaBlendValue, CType(o, Color))
                            End If
                        End If
                End Select


                'reset the old selections
                'While oldSelections.Count <> 0
                 '   Dim r1 As GridRangeInfo = CType(oldSelections.Dequeue(), GridRangeInfo)
                 '   If Not gridControl1.Selections.Ranges.Contains(r1) Then
                '        gridControl1.Selections.Add(r1)
                 '   End If
               ' End While
                'save the selections for later use if needed
                Dim r As GridRangeInfo
                For Each r In gridControl1.Selections.Ranges
                    oldSelections.Enqueue(r)
                Next r
                gridControl1.EndUpdate()
            End If
            mouseDownRow = -1
            mouseDownCol = -1
        End Sub 'gridControl1_MouseUp



        'avoid selecting column 1
        Private Sub gridControl1_SelectionChanging(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridSelectionChangingEventArgs)
            'avoid selecting column 1...
            If e.Range.Left = 1 Then
                e.Cancel = True
            End If
        End Sub 'gridControl1_SelectionChanging 

        
        Private Sub ExcelMarkerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        End Sub
    End Class 'ExcelMarkerForm
End Namespace
