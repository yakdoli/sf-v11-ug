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
Imports Syncfusion.Drawing

'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits MetroForm

    Private gridControl1 As OneTimeOnlyQueryCellInfoGrid
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
            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\.ico"))
            Me.Icon = ico
        Catch ex As Exception
        End Try


        'turn off D&D support
        gridControl1.ControllerOptions = GridControllerOptions.All And Not GridControllerOptions.OleDataSource

        gridControl1.ResetVolatileData()
        AddHandler gridControl1.QueryCellInfo, AddressOf GridQueryCellInfo
        AddHandler gridControl1.QueryRowCount, AddressOf GridQueryRowCount
        'gridControl1.QueryCoveredRange += new GridQueryCellRangeEventHandler(GridQueryCoveredRange);
        AddHandler gridControl1.QueryRowHeight, AddressOf GridQueryRowHeight

        gridControl1.ColWidths(0) += 10
        Me.gridControl1.GridVisualStyles = GridVisualStyles.Metro
        Me.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid
        Me.gridControl1.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
        Dim style As GridStyleInfo = gridControl1.BaseStylesMap("Header").StyleInfo
        style.TextColor = Color.MidnightBlue
        style.Font.Facename = "Verdana"
        Me.BackColor = Color.White
        Me.StartPosition = FormStartPosition.CenterScreen
       
    End Sub 'New
	

#Region "Event Handlers"
    '
    ' TODO: Add any constructor code after InitializeComponent call
    '

    Sub GridQueryRowCount(ByVal sender As Object, ByVal e As GridRowColCountEventArgs)
        e.Count = 10000
        e.Handled = True
    End Sub 'GridQueryRowCount


    Sub GridQueryCellInfo(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
        If e.RowIndex > 0 Then
            If e.ColIndex > 0 Then
                If e.ColIndex <> 2 Then
                    e.Style.CellValue = e.RowIndex.ToString() + "/" + e.ColIndex.ToString()
                End If
                If e.RowIndex Mod 2 = 0 Then
                    e.Style.Interior = New BrushInfo(Color.FromArgb(&HED, &HF0, &HF7))
                    e.Style.VerticalAlignment = GridVerticalAlignment.Bottom
                End If
                If e.ColIndex = 2 Then
                    If e.RowIndex Mod 2 = 0 Then
                        e.Style.CellType = "PushButton"
                    Else
                        e.Style.CellType = "CheckBox"
                    End If
                    e.Style.Description = "Click"
                Else
                    e.Style.CellType = "Static"
                End If
                If e.RowIndex Mod 4 = 0 Then
                    e.Style.Borders.Bottom = New GridBorder(GridBorderStyle.Solid, Color.Orange, GridBorderWeight.Medium)
                End If
            End If
            e.Handled = True
            ' Console.WriteLine("QueryCellInfo: " + e.ToString())
        End If
    End Sub 'GridQueryCellInfo



    Sub GridQueryRowHeight(ByVal sender As Object, ByVal e As GridRowColSizeEventArgs)
        If e.Index Mod 2 = 0 Then
            e.Size = 25
            e.Handled = True
        End If
    End Sub 'GridQueryRowHeight


    Sub GridQueryCoveredRange(ByVal sender As Object, ByVal e As GridQueryCoveredRangeEventArgs)
        If e.RowIndex Mod 2 = 1 AndAlso e.ColIndex >= 1 AndAlso e.ColIndex <= 3 Then
            e.Range = GridRangeInfo.Cells(e.RowIndex, 1, e.ColIndex, 3)
            e.Handled = True
        End If
    End Sub 'GridQueryCoveredRange

#End Region


#Region "Form Handlers"

    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            RemoveHandler gridControl1.QueryCellInfo, AddressOf GridQueryCellInfo
            RemoveHandler gridControl1.QueryRowCount, AddressOf GridQueryRowCount
            RemoveHandler gridControl1.QueryCoveredRange, AddressOf GridQueryCoveredRange
            RemoveHandler gridControl1.QueryRowHeight, AddressOf GridQueryRowHeight

            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose

    Private Function GetIconFile(ByVal bitmapName As String) As String
        For n As Integer = 0 To 9
            If System.IO.File.Exists(bitmapName) Then
                Return bitmapName
            End If

            bitmapName = "..\" & bitmapName
        Next n

        Return bitmapName
    End Function

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim GridCellInfo1 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo2 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo3 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo4 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo5 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo6 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo7 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo8 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo9 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo10 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo11 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo12 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo13 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo14 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo15 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo16 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo17 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo18 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo19 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo20 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo21 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo22 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo23 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo24 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo25 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo26 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo27 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo28 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo29 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo30 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo31 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo32 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo33 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo34 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo35 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo36 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo37 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo38 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo39 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo40 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo41 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo42 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo43 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo44 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo45 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo46 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo47 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo48 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo49 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo50 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo51 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo52 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo53 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo54 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo55 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo56 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo57 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo58 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo59 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo60 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo61 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo62 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo63 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo64 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo65 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo66 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo67 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo68 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo69 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo70 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo71 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo72 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo73 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo74 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo75 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo76 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo77 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo78 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo79 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo80 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo81 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo82 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo83 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo84 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo85 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo86 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo87 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo88 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo89 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo90 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo91 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo92 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo93 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo94 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo95 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo96 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo97 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo98 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo99 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo100 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo101 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo102 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo103 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo104 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo105 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo106 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo107 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo108 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo109 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo110 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo111 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo112 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo113 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo114 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo115 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo116 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo117 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo118 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo119 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo120 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo121 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo122 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo123 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo124 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo125 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo126 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo127 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo128 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo129 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo130 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo131 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo132 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo133 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo134 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo135 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo136 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo137 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo138 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo139 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo140 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo141 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo142 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo143 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo144 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo145 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo146 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo147 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo148 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo149 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo150 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo151 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo152 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo153 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo154 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo155 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo156 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo157 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo158 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo159 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo160 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo161 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo162 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo163 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo164 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo165 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo166 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo167 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo168 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo169 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo170 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo171 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo172 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo173 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo174 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo175 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo176 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo177 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo178 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo179 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo180 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo181 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo182 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo183 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo184 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo185 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo186 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo187 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Dim GridCellInfo188 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo()
        Me.gridControl1 = New OneTimeOnlyQueryCellInfo.OneTimeOnlyQueryCellInfoGrid()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridControl1
        '
        Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridControl1.ColCount = 55
        Me.gridControl1.DefaultRowHeight = 20
        Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        GridCellInfo1.Col = -1
        GridCellInfo1.Row = -1
        GridCellInfo1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        GridCellInfo1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        GridCellInfo1.StyleInfo.Font.Facename = "Segoe UI"
        GridCellInfo1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
        GridCellInfo1.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        GridCellInfo2.Col = 1
        GridCellInfo2.Row = -1
        GridCellInfo3.Col = 2
        GridCellInfo3.Row = -1
        GridCellInfo4.Col = 3
        GridCellInfo4.Row = -1
        GridCellInfo5.Col = 4
        GridCellInfo5.Row = -1
        GridCellInfo6.Col = 5
        GridCellInfo6.Row = -1
        GridCellInfo7.Col = 6
        GridCellInfo7.Row = -1
        GridCellInfo8.Col = 7
        GridCellInfo8.Row = -1
        GridCellInfo9.Col = 8
        GridCellInfo9.Row = -1
        GridCellInfo10.Col = 0
        GridCellInfo10.Row = 0
        GridCellInfo11.Col = 1
        GridCellInfo11.Row = 0
        GridCellInfo12.Col = 2
        GridCellInfo12.Row = 0
        GridCellInfo13.Col = 3
        GridCellInfo13.Row = 0
        GridCellInfo14.Col = 4
        GridCellInfo14.Row = 0
        GridCellInfo15.Col = 5
        GridCellInfo15.Row = 0
        GridCellInfo16.Col = 6
        GridCellInfo16.Row = 0
        GridCellInfo17.Col = 7
        GridCellInfo17.Row = 0
        GridCellInfo18.Col = 8
        GridCellInfo18.Row = 0
        GridCellInfo19.Col = -1
        GridCellInfo19.Row = 1
        GridCellInfo20.Col = 0
        GridCellInfo20.Row = 1
        GridCellInfo21.Col = 1
        GridCellInfo21.Row = 1
        GridCellInfo22.Col = 2
        GridCellInfo22.Row = 1
        GridCellInfo23.Col = 3
        GridCellInfo23.Row = 1
        GridCellInfo24.Col = 4
        GridCellInfo24.Row = 1
        GridCellInfo25.Col = 5
        GridCellInfo25.Row = 1
        GridCellInfo26.Col = 6
        GridCellInfo26.Row = 1
        GridCellInfo27.Col = 7
        GridCellInfo27.Row = 1
        GridCellInfo28.Col = 8
        GridCellInfo28.Row = 1
        GridCellInfo29.Col = -1
        GridCellInfo29.Row = 2
        GridCellInfo30.Col = 0
        GridCellInfo30.Row = 2
        GridCellInfo31.Col = 1
        GridCellInfo31.Row = 2
        GridCellInfo32.Col = 2
        GridCellInfo32.Row = 2
        GridCellInfo33.Col = 3
        GridCellInfo33.Row = 2
        GridCellInfo34.Col = 4
        GridCellInfo34.Row = 2
        GridCellInfo35.Col = 5
        GridCellInfo35.Row = 2
        GridCellInfo36.Col = 6
        GridCellInfo36.Row = 2
        GridCellInfo37.Col = 7
        GridCellInfo37.Row = 2
        GridCellInfo38.Col = 8
        GridCellInfo38.Row = 2
        GridCellInfo39.Col = -1
        GridCellInfo39.Row = 3
        GridCellInfo40.Col = 0
        GridCellInfo40.Row = 3
        GridCellInfo41.Col = 1
        GridCellInfo41.Row = 3
        GridCellInfo42.Col = 2
        GridCellInfo42.Row = 3
        GridCellInfo43.Col = 3
        GridCellInfo43.Row = 3
        GridCellInfo44.Col = 4
        GridCellInfo44.Row = 3
        GridCellInfo45.Col = 5
        GridCellInfo45.Row = 3
        GridCellInfo46.Col = 6
        GridCellInfo46.Row = 3
        GridCellInfo47.Col = 7
        GridCellInfo47.Row = 3
        GridCellInfo48.Col = 8
        GridCellInfo48.Row = 3
        GridCellInfo49.Col = -1
        GridCellInfo49.Row = 4
        GridCellInfo50.Col = 0
        GridCellInfo50.Row = 4
        GridCellInfo51.Col = 1
        GridCellInfo51.Row = 4
        GridCellInfo52.Col = 2
        GridCellInfo52.Row = 4
        GridCellInfo53.Col = 3
        GridCellInfo53.Row = 4
        GridCellInfo54.Col = 4
        GridCellInfo54.Row = 4
        GridCellInfo55.Col = 5
        GridCellInfo55.Row = 4
        GridCellInfo56.Col = 6
        GridCellInfo56.Row = 4
        GridCellInfo57.Col = 7
        GridCellInfo57.Row = 4
        GridCellInfo58.Col = 8
        GridCellInfo58.Row = 4
        GridCellInfo59.Col = -1
        GridCellInfo59.Row = 5
        GridCellInfo60.Col = 0
        GridCellInfo60.Row = 5
        GridCellInfo61.Col = 1
        GridCellInfo61.Row = 5
        GridCellInfo62.Col = 2
        GridCellInfo62.Row = 5
        GridCellInfo63.Col = 3
        GridCellInfo63.Row = 5
        GridCellInfo64.Col = 4
        GridCellInfo64.Row = 5
        GridCellInfo65.Col = 5
        GridCellInfo65.Row = 5
        GridCellInfo66.Col = 6
        GridCellInfo66.Row = 5
        GridCellInfo67.Col = 7
        GridCellInfo67.Row = 5
        GridCellInfo68.Col = 8
        GridCellInfo68.Row = 5
        GridCellInfo69.Col = -1
        GridCellInfo69.Row = 6
        GridCellInfo70.Col = 0
        GridCellInfo70.Row = 6
        GridCellInfo71.Col = 1
        GridCellInfo71.Row = 6
        GridCellInfo72.Col = 2
        GridCellInfo72.Row = 6
        GridCellInfo73.Col = 3
        GridCellInfo73.Row = 6
        GridCellInfo74.Col = 4
        GridCellInfo74.Row = 6
        GridCellInfo75.Col = 5
        GridCellInfo75.Row = 6
        GridCellInfo76.Col = 6
        GridCellInfo76.Row = 6
        GridCellInfo77.Col = 7
        GridCellInfo77.Row = 6
        GridCellInfo78.Col = 8
        GridCellInfo78.Row = 6
        GridCellInfo79.Col = -1
        GridCellInfo79.Row = 7
        GridCellInfo80.Col = 0
        GridCellInfo80.Row = 7
        GridCellInfo81.Col = 1
        GridCellInfo81.Row = 7
        GridCellInfo82.Col = 2
        GridCellInfo82.Row = 7
        GridCellInfo83.Col = 3
        GridCellInfo83.Row = 7
        GridCellInfo84.Col = 4
        GridCellInfo84.Row = 7
        GridCellInfo85.Col = 5
        GridCellInfo85.Row = 7
        GridCellInfo86.Col = 6
        GridCellInfo86.Row = 7
        GridCellInfo87.Col = 7
        GridCellInfo87.Row = 7
        GridCellInfo88.Col = 8
        GridCellInfo88.Row = 7
        GridCellInfo89.Col = -1
        GridCellInfo89.Row = 8
        GridCellInfo90.Col = 0
        GridCellInfo90.Row = 8
        GridCellInfo91.Col = 1
        GridCellInfo91.Row = 8
        GridCellInfo92.Col = 2
        GridCellInfo92.Row = 8
        GridCellInfo93.Col = 3
        GridCellInfo93.Row = 8
        GridCellInfo94.Col = 4
        GridCellInfo94.Row = 8
        GridCellInfo95.Col = 5
        GridCellInfo95.Row = 8
        GridCellInfo96.Col = 6
        GridCellInfo96.Row = 8
        GridCellInfo97.Col = 7
        GridCellInfo97.Row = 8
        GridCellInfo98.Col = 8
        GridCellInfo98.Row = 8
        GridCellInfo99.Col = -1
        GridCellInfo99.Row = 9
        GridCellInfo100.Col = 0
        GridCellInfo100.Row = 9
        GridCellInfo101.Col = 1
        GridCellInfo101.Row = 9
        GridCellInfo102.Col = 2
        GridCellInfo102.Row = 9
        GridCellInfo103.Col = 3
        GridCellInfo103.Row = 9
        GridCellInfo104.Col = 4
        GridCellInfo104.Row = 9
        GridCellInfo105.Col = 5
        GridCellInfo105.Row = 9
        GridCellInfo106.Col = 6
        GridCellInfo106.Row = 9
        GridCellInfo107.Col = 7
        GridCellInfo107.Row = 9
        GridCellInfo108.Col = 8
        GridCellInfo108.Row = 9
        GridCellInfo109.Col = -1
        GridCellInfo109.Row = 10
        GridCellInfo110.Col = 0
        GridCellInfo110.Row = 10
        GridCellInfo111.Col = 1
        GridCellInfo111.Row = 10
        GridCellInfo112.Col = 2
        GridCellInfo112.Row = 10
        GridCellInfo113.Col = 3
        GridCellInfo113.Row = 10
        GridCellInfo114.Col = 4
        GridCellInfo114.Row = 10
        GridCellInfo115.Col = 5
        GridCellInfo115.Row = 10
        GridCellInfo116.Col = 6
        GridCellInfo116.Row = 10
        GridCellInfo117.Col = 7
        GridCellInfo117.Row = 10
        GridCellInfo118.Col = 8
        GridCellInfo118.Row = 10
        GridCellInfo119.Col = -1
        GridCellInfo119.Row = 11
        GridCellInfo120.Col = 0
        GridCellInfo120.Row = 11
        GridCellInfo121.Col = 1
        GridCellInfo121.Row = 11
        GridCellInfo122.Col = 2
        GridCellInfo122.Row = 11
        GridCellInfo123.Col = 3
        GridCellInfo123.Row = 11
        GridCellInfo124.Col = 4
        GridCellInfo124.Row = 11
        GridCellInfo125.Col = 5
        GridCellInfo125.Row = 11
        GridCellInfo126.Col = 6
        GridCellInfo126.Row = 11
        GridCellInfo127.Col = 7
        GridCellInfo127.Row = 11
        GridCellInfo128.Col = 8
        GridCellInfo128.Row = 11
        GridCellInfo129.Col = -1
        GridCellInfo129.Row = 12
        GridCellInfo130.Col = 0
        GridCellInfo130.Row = 12
        GridCellInfo131.Col = 1
        GridCellInfo131.Row = 12
        GridCellInfo132.Col = 2
        GridCellInfo132.Row = 12
        GridCellInfo133.Col = 3
        GridCellInfo133.Row = 12
        GridCellInfo134.Col = 4
        GridCellInfo134.Row = 12
        GridCellInfo135.Col = 5
        GridCellInfo135.Row = 12
        GridCellInfo136.Col = 6
        GridCellInfo136.Row = 12
        GridCellInfo137.Col = 7
        GridCellInfo137.Row = 12
        GridCellInfo138.Col = 8
        GridCellInfo138.Row = 12
        GridCellInfo139.Col = -1
        GridCellInfo139.Row = 13
        GridCellInfo140.Col = 0
        GridCellInfo140.Row = 13
        GridCellInfo141.Col = 1
        GridCellInfo141.Row = 13
        GridCellInfo142.Col = 2
        GridCellInfo142.Row = 13
        GridCellInfo143.Col = 3
        GridCellInfo143.Row = 13
        GridCellInfo144.Col = 4
        GridCellInfo144.Row = 13
        GridCellInfo145.Col = 5
        GridCellInfo145.Row = 13
        GridCellInfo146.Col = 6
        GridCellInfo146.Row = 13
        GridCellInfo147.Col = 7
        GridCellInfo147.Row = 13
        GridCellInfo148.Col = 8
        GridCellInfo148.Row = 13
        GridCellInfo149.Col = -1
        GridCellInfo149.Row = 14
        GridCellInfo150.Col = 0
        GridCellInfo150.Row = 14
        GridCellInfo151.Col = 1
        GridCellInfo151.Row = 14
        GridCellInfo152.Col = 2
        GridCellInfo152.Row = 14
        GridCellInfo153.Col = 3
        GridCellInfo153.Row = 14
        GridCellInfo154.Col = 4
        GridCellInfo154.Row = 14
        GridCellInfo155.Col = 5
        GridCellInfo155.Row = 14
        GridCellInfo156.Col = 6
        GridCellInfo156.Row = 14
        GridCellInfo157.Col = 7
        GridCellInfo157.Row = 14
        GridCellInfo158.Col = 8
        GridCellInfo158.Row = 14
        GridCellInfo159.Col = -1
        GridCellInfo159.Row = 15
        GridCellInfo160.Col = 0
        GridCellInfo160.Row = 15
        GridCellInfo161.Col = 1
        GridCellInfo161.Row = 15
        GridCellInfo162.Col = 2
        GridCellInfo162.Row = 15
        GridCellInfo163.Col = 3
        GridCellInfo163.Row = 15
        GridCellInfo164.Col = 4
        GridCellInfo164.Row = 15
        GridCellInfo165.Col = 5
        GridCellInfo165.Row = 15
        GridCellInfo166.Col = 6
        GridCellInfo166.Row = 15
        GridCellInfo167.Col = 7
        GridCellInfo167.Row = 15
        GridCellInfo168.Col = 8
        GridCellInfo168.Row = 15
        GridCellInfo169.Col = -1
        GridCellInfo169.Row = 16
        GridCellInfo170.Col = 0
        GridCellInfo170.Row = 16
        GridCellInfo171.Col = 1
        GridCellInfo171.Row = 16
        GridCellInfo172.Col = 2
        GridCellInfo172.Row = 16
        GridCellInfo173.Col = 3
        GridCellInfo173.Row = 16
        GridCellInfo174.Col = 4
        GridCellInfo174.Row = 16
        GridCellInfo175.Col = 5
        GridCellInfo175.Row = 16
        GridCellInfo176.Col = 6
        GridCellInfo176.Row = 16
        GridCellInfo177.Col = 7
        GridCellInfo177.Row = 16
        GridCellInfo178.Col = 8
        GridCellInfo178.Row = 16
        GridCellInfo179.Col = -1
        GridCellInfo179.Row = 17
        GridCellInfo180.Col = 0
        GridCellInfo180.Row = 17
        GridCellInfo181.Col = 1
        GridCellInfo181.Row = 17
        GridCellInfo182.Col = 2
        GridCellInfo182.Row = 17
        GridCellInfo183.Col = 3
        GridCellInfo183.Row = 17
        GridCellInfo184.Col = 4
        GridCellInfo184.Row = 17
        GridCellInfo185.Col = 5
        GridCellInfo185.Row = 17
        GridCellInfo186.Col = 6
        GridCellInfo186.Row = 17
        GridCellInfo187.Col = 7
        GridCellInfo187.Row = 17
        GridCellInfo188.Col = 8
        GridCellInfo188.Row = 17
        Me.gridControl1.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() {GridCellInfo1, GridCellInfo2, GridCellInfo3, GridCellInfo4, GridCellInfo5, GridCellInfo6, GridCellInfo7, GridCellInfo8, GridCellInfo9, GridCellInfo10, GridCellInfo11, GridCellInfo12, GridCellInfo13, GridCellInfo14, GridCellInfo15, GridCellInfo16, GridCellInfo17, GridCellInfo18, GridCellInfo19, GridCellInfo20, GridCellInfo21, GridCellInfo22, GridCellInfo23, GridCellInfo24, GridCellInfo25, GridCellInfo26, GridCellInfo27, GridCellInfo28, GridCellInfo29, GridCellInfo30, GridCellInfo31, GridCellInfo32, GridCellInfo33, GridCellInfo34, GridCellInfo35, GridCellInfo36, GridCellInfo37, GridCellInfo38, GridCellInfo39, GridCellInfo40, GridCellInfo41, GridCellInfo42, GridCellInfo43, GridCellInfo44, GridCellInfo45, GridCellInfo46, GridCellInfo47, GridCellInfo48, GridCellInfo49, GridCellInfo50, GridCellInfo51, GridCellInfo52, GridCellInfo53, GridCellInfo54, GridCellInfo55, GridCellInfo56, GridCellInfo57, GridCellInfo58, GridCellInfo59, GridCellInfo60, GridCellInfo61, GridCellInfo62, GridCellInfo63, GridCellInfo64, GridCellInfo65, GridCellInfo66, GridCellInfo67, GridCellInfo68, GridCellInfo69, GridCellInfo70, GridCellInfo71, GridCellInfo72, GridCellInfo73, GridCellInfo74, GridCellInfo75, GridCellInfo76, GridCellInfo77, GridCellInfo78, GridCellInfo79, GridCellInfo80, GridCellInfo81, GridCellInfo82, GridCellInfo83, GridCellInfo84, GridCellInfo85, GridCellInfo86, GridCellInfo87, GridCellInfo88, GridCellInfo89, GridCellInfo90, GridCellInfo91, GridCellInfo92, GridCellInfo93, GridCellInfo94, GridCellInfo95, GridCellInfo96, GridCellInfo97, GridCellInfo98, GridCellInfo99, GridCellInfo100, GridCellInfo101, GridCellInfo102, GridCellInfo103, GridCellInfo104, GridCellInfo105, GridCellInfo106, GridCellInfo107, GridCellInfo108, GridCellInfo109, GridCellInfo110, GridCellInfo111, GridCellInfo112, GridCellInfo113, GridCellInfo114, GridCellInfo115, GridCellInfo116, GridCellInfo117, GridCellInfo118, GridCellInfo119, GridCellInfo120, GridCellInfo121, GridCellInfo122, GridCellInfo123, GridCellInfo124, GridCellInfo125, GridCellInfo126, GridCellInfo127, GridCellInfo128, GridCellInfo129, GridCellInfo130, GridCellInfo131, GridCellInfo132, GridCellInfo133, GridCellInfo134, GridCellInfo135, GridCellInfo136, GridCellInfo137, GridCellInfo138, GridCellInfo139, GridCellInfo140, GridCellInfo141, GridCellInfo142, GridCellInfo143, GridCellInfo144, GridCellInfo145, GridCellInfo146, GridCellInfo147, GridCellInfo148, GridCellInfo149, GridCellInfo150, GridCellInfo151, GridCellInfo152, GridCellInfo153, GridCellInfo154, GridCellInfo155, GridCellInfo156, GridCellInfo157, GridCellInfo158, GridCellInfo159, GridCellInfo160, GridCellInfo161, GridCellInfo162, GridCellInfo163, GridCellInfo164, GridCellInfo165, GridCellInfo166, GridCellInfo167, GridCellInfo168, GridCellInfo169, GridCellInfo170, GridCellInfo171, GridCellInfo172, GridCellInfo173, GridCellInfo174, GridCellInfo175, GridCellInfo176, GridCellInfo177, GridCellInfo178, GridCellInfo179, GridCellInfo180, GridCellInfo181, GridCellInfo182, GridCellInfo183, GridCellInfo184, GridCellInfo185, GridCellInfo186, GridCellInfo187, GridCellInfo188})
        Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridControl1.HorizontalThumbTrack = True
        Me.gridControl1.Location = New System.Drawing.Point(12, 12)
        Me.gridControl1.MetroScrollBars = True
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.RowCount = 100
        Me.gridControl1.Size = New System.Drawing.Size(678, 326)
        Me.gridControl1.SmartSizeBox = False
        Me.gridControl1.TabIndex = 1
        Me.gridControl1.Text = "gridControl1"
        Me.gridControl1.ThemesEnabled = True
        Me.gridControl1.VerticalThumbTrack = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(702, 350)
        Me.Controls.Add(Me.gridControl1)
        Me.DropShadow = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QueryCellInfo Optimization Demo"
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Public Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
        Application.EnableVisualStyles()
#End If
        Application.Run(New Form1())
    End Sub 'Main
#End Region

End Class 'Form1
