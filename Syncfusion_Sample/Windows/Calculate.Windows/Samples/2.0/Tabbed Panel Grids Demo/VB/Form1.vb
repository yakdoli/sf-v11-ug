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
Imports Syncfusion.Calculate


Public Class Form1
   Inherits System.Windows.Forms.Form
   Private tabControl1 As System.Windows.Forms.TabControl
   Private label1 As System.Windows.Forms.Label
   Private textBox1 As System.Windows.Forms.TextBox
   Private textBox2 As System.Windows.Forms.TextBox
   Private label2 As System.Windows.Forms.Label
   
   Private workBook As Syncfusion.Calculate.CalcWorkbook
   Private mainMenu1 As System.Windows.Forms.MainMenu
   Private menuItem1 As System.Windows.Forms.MenuItem
   Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
   Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
   Private WithEvents menuItem4 As System.Windows.Forms.MenuItem
   Private menuItem5 As System.Windows.Forms.MenuItem
   Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
   Private WithEvents menuItem7 As System.Windows.Forms.MenuItem
   Private WithEvents menuItem8 As System.Windows.Forms.MenuItem
   Private WithEvents menuItem9 As System.Windows.Forms.MenuItem
   Private WithEvents menuItem10 As System.Windows.Forms.MenuItem
   Private WithEvents menuItem11 As System.Windows.Forms.MenuItem
   Private menuItem12 As System.Windows.Forms.MenuItem
   Private menuItem13 As System.Windows.Forms.MenuItem
    Private menuItem14 As System.Windows.Forms.MenuItem
    Private components As System.ComponentModel.IContainer



   
   Public Sub New()
        'Application.EnableVisualStyles()

      InitializeComponent()

        Try
            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(FindFile("Icon", "sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try

        'create an empty work book
        Me.workBook = New Syncfusion.Calculate.CalcWorkbook(Nothing, Nothing)

        'hook up a hidden acceptbutton to catch enter keys
        Dim but As New Button()
        Me.Controls.Add(but)
        AddHandler but.Click, AddressOf EnterKeyPressed
        but.Size = New Size(1, 1)
        Me.AcceptButton = but

        'load a sample SSS file
        Dim fileName As String = "..\\..\\sample.sss"
        Dim fi As New System.IO.FileInfo(fileName)
        If fi.Exists Then
            LoadFile(fileName)
        End If

    End Sub 'New

    ' utility to locate a sibling file
    Public Shared Function FindFile(ByVal dataDirName As String, ByVal fileName As String) As String
        dataDirName = dataDirName.TrimEnd("\"c, "/"c)
        ' Check both in parent folder and Parent\Data folders.
        Dim dataFileName As String = dataDirName + "\" + fileName
        Dim n As Integer
        For n = 0 To 9
            If System.IO.File.Exists(fileName) Then
                Return fileName
            End If
            If System.IO.File.Exists(dataFileName) Then
                Return dataFileName
            End If
            fileName = "..\" + fileName
            dataFileName = "..\" + dataFileName
        Next n '

        Return ""
    End Function 'FindFile
   
    <STAThread()> _
     Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
Application.EnableVisualStyles
#End If
        Application.Run(New Form1())
    End Sub 'Main



    ' Clean up any resources being used.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.tabControl1 = New System.Windows.Forms.TabControl
        Me.label1 = New System.Windows.Forms.Label
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.menuItem1 = New System.Windows.Forms.MenuItem
        Me.menuItem2 = New System.Windows.Forms.MenuItem
        Me.menuItem3 = New System.Windows.Forms.MenuItem
        Me.menuItem14 = New System.Windows.Forms.MenuItem
        Me.menuItem4 = New System.Windows.Forms.MenuItem
        Me.menuItem5 = New System.Windows.Forms.MenuItem
        Me.menuItem6 = New System.Windows.Forms.MenuItem
        Me.menuItem7 = New System.Windows.Forms.MenuItem
        Me.menuItem12 = New System.Windows.Forms.MenuItem
        Me.menuItem8 = New System.Windows.Forms.MenuItem
        Me.menuItem10 = New System.Windows.Forms.MenuItem
        Me.menuItem9 = New System.Windows.Forms.MenuItem
        Me.menuItem13 = New System.Windows.Forms.MenuItem
        Me.menuItem11 = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControl1.Location = New System.Drawing.Point(24, 40)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(456, 392)
        Me.tabControl1.TabIndex = 0
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(32, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(32, 23)
        Me.label1.TabIndex = 3
        Me.label1.Text = "rows"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(72, 8)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(24, 20)
        Me.textBox1.TabIndex = 4
        Me.textBox1.Text = "5"
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(184, 8)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(24, 20)
        Me.textBox2.TabIndex = 6
        Me.textBox2.Text = "5"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(128, 8)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(48, 23)
        Me.label2.TabIndex = 5
        Me.label2.Text = "columns"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem5})
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3, Me.menuItem14, Me.menuItem4})
        Me.menuItem1.Text = "File"
        '
        'menuItem2
        '
        Me.menuItem2.Index = 0
        Me.menuItem2.Text = "Load SSS"
        '
        'menuItem3
        '
        Me.menuItem3.Index = 1
        Me.menuItem3.Text = "Save SSS"
        '
        'menuItem14
        '
        Me.menuItem14.Index = 2
        Me.menuItem14.Text = "-"
        '
        'menuItem4
        '
        Me.menuItem4.Index = 3
        Me.menuItem4.Text = "Exit"
        '
        'menuItem5
        '
        Me.menuItem5.Index = 1
        Me.menuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem6, Me.menuItem7, Me.menuItem12, Me.menuItem8, Me.menuItem10, Me.menuItem9, Me.menuItem13, Me.menuItem11})
        Me.menuItem5.Text = "Sheets"
        '
        'menuItem6
        '
        Me.menuItem6.Index = 0
        Me.menuItem6.Text = "Add Sheet"
        '
        'menuItem7
        '
        Me.menuItem7.Index = 1
        Me.menuItem7.Text = "Remove Sheet"
        '
        'menuItem12
        '
        Me.menuItem12.Index = 2
        Me.menuItem12.Text = "-"
        '
        'menuItem8
        '
        Me.menuItem8.Index = 3
        Me.menuItem8.Text = "Random Data"
        '
        'menuItem10
        '
        Me.menuItem10.Index = 4
        Me.menuItem10.Text = "Sum Edges"
        '
        'menuItem9
        '
        Me.menuItem9.Index = 5
        Me.menuItem9.Text = "Chain Formulas"
        '
        'menuItem13
        '
        Me.menuItem13.Index = 6
        Me.menuItem13.Text = "-"
        '
        'menuItem11
        '
        Me.menuItem11.Index = 7
        Me.menuItem11.Text = "Move Tabs"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 462)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.tabControl1)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "Tabbed Panel Grids Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub 'InitializeComponent 
#End Region




#Region "Add Tab"
    Private tabPageNumber As Integer = 0

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem6.Click
        'insert tab
        'restrict because of all the textboxes
        Dim nRows As Integer = Math.Min(20, Integer.Parse(Me.textBox1.Text))
        Dim nCols As Integer = Math.Min(10, Integer.Parse(Me.textBox2.Text))

        CreateTabPage(nRows, nCols, Nothing)
    End Sub 'button1_Click


    Private Function CreateTabPage(ByVal nRows As Integer, ByVal nCols As Integer, ByVal sheet As CalcSheet) As PanelGrid
        'create a tabpage that holds an array of textboxes to 
        'to display the CalcSheet
        Dim count As Integer = tabPageNumber
        tabPageNumber += 1
        Dim name As String = String.Format("sheet{0}", count)
        Dim tp As New TabPage(name)
        tp.Dock = DockStyle.Fill
        Me.tabControl1.TabPages.Add(tp)

        'add left and top panels
        Dim left As New Panel()
        left.Width = 30
        left.Dock = DockStyle.Left
        tp.Controls.Add(left)
        Dim top As New Panel()
        top.Height = 20
        top.Dock = DockStyle.Top
        tp.Controls.Add(top)

        'initialize the grid
        Dim pg As New PanelGrid()
        pg.Dock = DockStyle.Fill
        pg.InitGrid(Me.workBook, sheet, nRows, nCols, tp.ClientSize, left, top, name)

        'and add the grid to the tabpage
        tp.Controls.Add(pg)

        Me.tabControl1.SelectedTab = tp

        Return pg
    End Function 'CreateTabPage
#End Region

#Region "remove tab"

    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem7.Click
        'remove tab
        Dim tp As TabPage = Me.tabControl1.SelectedTab
        Dim sheet As CalcSheet = Me.workBook.CalcSheetList(tp.Text)
        Me.workBook.CalcSheetList.Remove(sheet)
        Me.tabControl1.TabPages.Remove(tp)
    End Sub 'button2_Click
#End Region

#Region "Move Tabs"

    Private Sub menuItem11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem11.Click
        'Move Tabs
        If Me.tabControl1.TabPages.Count > 1 Then
            Dim selected As TabPage = Me.tabControl1.SelectedTab
            Dim tp As TabPage = Me.tabControl1.TabPages((Me.tabControl1.TabPages.Count - 1))
            Dim i As Integer = Me.tabControl1.TabPages.Count - 1

            While i > 0
                Me.tabControl1.TabPages(i) = Me.tabControl1.TabPages((i - 1))
                i -= 1
            End While
            Me.tabControl1.TabPages(0) = tp
            Me.tabControl1.SelectedTab = selected
        End If
    End Sub 'menuItem11_Click
#End Region

#Region "load a SSS file from disk"


    Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click
        'load SSS
        Dim dlg As New OpenFileDialog()

        dlg.InitialDirectory = "..\\..\\"
        dlg.Filter = "SSS files (*.sss)|*.sss|All files (*.*)|*.*"
        dlg.FilterIndex = 1

        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If Not (Me.workBook Is Nothing) AndAlso Me.workBook.CalcSheetList.Count > 0 Then

                Dim sheets As CalcSheet() = Me.workBook.CalcSheetList.ToArray()

                Dim sheet As CalcSheet
                For Each sheet In sheets
                    'this.workBook.CalcSheetList.Remove(sheet);
                    CalcEngine.UnregisterGridAsSheet(sheet.Name, sheet)

                    Me.workBook.CalcSheetList.Remove(sheet)
                    Me.tabControl1.TabPages.RemoveAt(0) 'removing the first one all the time
                Next sheet
            End If
            LoadFile(dlg.FileName)
        End If
    End Sub 'menuItem2_Click


    Private Sub LoadFile(ByVal fileName As String)
        CalcEngine.ResetSheetFamilyID()
        tabPageNumber = 0

        'instantiate a workbook
        Me.workBook = CalcWorkbook.ReadSSS(fileName)
        tabPageNumber = 0
        'make the tabs reflect the new workbook
        CreateGridsForWorkbook()
    End Sub 'LoadFile

    'create a set of tabpages/PanelGrids based on the current workBook.
    Private Sub CreateGridsForWorkbook()
        Me.tabControl1.TabPages.Clear()
        Dim sheet As CalcSheet
        For Each sheet In Me.workBook.CalcSheetList
            Dim pg As PanelGrid = CreateTabPage(sheet.RowCount, sheet.ColCount, sheet)
            Dim row As Integer = 1

            While row <= sheet.RowCount
                Dim col As Integer = 1

                While col <= sheet.ColCount
                    Dim tb As TextBox = pg.GetTextBox(row, col)
                    tb.Text = sheet.GetValueRowCol(row, col).ToString()
                    col += 1
                End While
                row += 1
            End While
        Next sheet
        Me.workBook.CalculateAll()
    End Sub 'CreateGridsForWorkbook

#End Region

#Region "save an SSS file to disk"


    Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem3.Click
        'save SSS
        Dim dlg As New SaveFileDialog()

        dlg.Filter = "SSS files (*.sss)|*.sss|All files (*.*)|*.*"
        dlg.FilterIndex = 1
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.workBook.WriteSSS(dlg.FileName)
        End If
    End Sub 'menuItem3_Click 

#End Region

#Region "autogenerated data and formulas"


    Private Sub menuItem8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem8.Click
        'random data
        Dim tp As TabPage = Me.tabControl1.SelectedTab
        Dim pg As PanelGrid = GetPanelGrid(tp)

        Dim r As New Random()

        'misses the last row and last col
        Dim row As Integer = 1

        While row < pg.rowCount
            Dim col As Integer = 1

            While col < pg.colCount
                pg.sheet(row, col) = (r.Next(1000) / 10.0).ToString()
                col += 1
            End While
            row += 1
        End While

        Me.workBook.CalculateAll()
    End Sub 'menuItem8_Click


    Private Sub menuItem9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem9.Click
        'chain formulas
        Dim tp As TabPage = Me.tabControl1.SelectedTab
        Dim pg As PanelGrid = GetPanelGrid(tp)

        Me.workBook.ClearFormulas(pg.sheet)

        Dim r As New Random()


        Dim col As Integer = 1

        While col <= pg.colCount
            Dim col1 As String = RangeInfo.GetAlphaLabel(col)
            Dim row As Integer = 1

            While row <= pg.rowCount
                If row = 1 Then
                    If col = 1 Then
                        pg.sheet(row, col) = "100"
                    Else
                        pg.sheet(row, col) = String.Format("={0}{1} + 1", RangeInfo.GetAlphaLabel((col - 1)), pg.rowCount)
                    End If
                Else
                    pg.sheet(row, col) = String.Format("={0}{1} + 1", col1, row - 1)
                End If
                row += 1
            End While
            col += 1
        End While

        Me.workBook.CalculateAll()
    End Sub 'menuItem9_Click

    Private Sub menuItem10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem10.Click
        'sum edges
        Dim tp As TabPage = Me.tabControl1.SelectedTab
        Dim pg As PanelGrid = GetPanelGrid(tp)

        pg.GetTextBox(1, 1).Focus() 'make sure focu is not on an edge
        Me.workBook.ClearFormulas(pg.sheet)
        Dim row As Integer = pg.rowCount
        Dim col As Integer

        col = 1
        While col <= pg.colCount
            pg.sheet(row, col) = String.Format("=Sum({0}1:{0}{1})", RangeInfo.GetAlphaLabel(col), row - 1)
            col += 1
        End While

        Dim col1 As String = RangeInfo.GetAlphaLabel((pg.colCount - 1))

        row = 1
        While row <= pg.rowCount - 1
            pg.sheet(row, pg.colCount) = String.Format("=Sum(A{1}:{0}{1})", col1, row)
            row += 1
        End While

        Me.workBook.CalculateAll()
    End Sub 'menuItem10_Click
#End Region

#Region "lookup utility"


    Private Function GetPanelGrid(ByVal tp As TabPage) As PanelGrid
        Dim grid As PanelGrid = Nothing
        Dim c As Control
        For Each c In tp.Controls
            If TypeOf c Is PanelGrid Then
                grid = c
                Exit For
            End If
        Next c
        Return grid
    End Function 'GetPanelGrid

#End Region

#Region "handle enter key"


    Private Sub EnterKeyPressed(ByVal sender As Object, ByVal e As EventArgs)
        Dim tp As TabPage = Me.tabControl1.SelectedTab
        Dim pg As PanelGrid = GetPanelGrid(tp)
        Dim row, col As Integer
        Dim tb As TextBox = pg.GetActiveTextBoxRowCol(row, col)
        If Not (tb Is Nothing) Then
            If row < pg.rowCount Then
                tb = pg.GetTextBox(row + 1, col)
            ElseIf col < pg.colCount Then
                tb = pg.GetTextBox(1, col + 1)
            End If

            tb.Focus()
        End If
    End Sub 'EnterKeyPressed 

#End Region


    Private Sub menuItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem4.Click
        Me.Close()
    End Sub 'menuItem4_Click




End Class 'Form1