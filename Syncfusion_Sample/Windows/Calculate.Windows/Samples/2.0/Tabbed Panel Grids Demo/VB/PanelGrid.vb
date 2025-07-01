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
Imports System.Globalization
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Calculate


'/ <summary>
'/ Summary description for PanelGrid.
'/ </summary>

Public Class PanelGrid
   Inherits Panel
   
   Public Sub New()
   End Sub 'New
   
   
   Private textBoxes() As TextBox
   Public colCount As Integer = 0
   Public rowCount As Integer = 0
   Private textBoxCount As Integer = 0
   Private leftOffSet As Integer
   Private topOffSet As Integer
   Private workBook As CalcWorkbook = Nothing
   Public sheet As CalcSheet = Nothing
   
   
   Public Sub InitGrid(workBook As CalcWorkbook, sheet As CalcSheet, rowCount As Integer, colCount As Integer, sz As Size, left As Panel, top As Panel, name As String)
      'set the textboxes that hold the data
      Me.textBoxCount = rowCount * colCount
        textBoxes = New TextBox(textBoxCount - 1) {}
      Me.rowCount = rowCount
      Me.colCount = colCount
      Me.leftOffSet = left.Width
      Me.topOffSet = top.Height
      Me.Size = sz
        Dim i As Integer

        While i < textBoxCount
            Dim tb As New TextBox
            tb.Multiline = True
            Dim row, col As Integer
            row = i Mod Me.colCount + 1
            col = Int(i / Me.colCount) + 1
            tb.Bounds = Me.GetRectangle(row, col)
            'Console.WriteLine("{0} ({2},{3}) {1}", i, tb.Bounds, row, col)
            tb.Visible = True
            Me.textBoxes(i) = tb
            AddHandler tb.Leave, AddressOf tb_Leave
            AddHandler tb.Enter, AddressOf tb_Enter
            AddHandler tb.TextChanged, AddressOf tb_TextChanged
            i += 1
        End While
        Me.Controls.AddRange(Me.textBoxes)

        'setup the labels on the rows and columns
        i = 0

        While i <= rowCount
            Dim lb As New Label
            Dim rect As Rectangle = Me.GetRectangle(1, i)
            rect.Offset(-leftOffSet, -top.Height)
            rect.Width = left.Width - 6
            lb.Bounds = rect
            lb.Text = i.ToString()
            lb.Font = New Font(lb.Font, FontStyle.Bold)
            lb.TextAlign = ContentAlignment.MiddleRight
            lb.Visible = True
            left.Controls.Add(lb)
            i += 1
        End While
        i = 0

        While i <= colCount
            Dim lb As New Label
            Dim rect As Rectangle = Me.GetRectangle(i, 1)
            rect.Offset(0, -top.Height)
            rect.Height = top.Height - 2
            lb.Bounds = rect
            lb.Text = RangeInfo.GetAlphaLabel(i).ToString()
            lb.Font = New Font(lb.Font, FontStyle.Bold)
            lb.TextAlign = ContentAlignment.BottomCenter
            lb.Visible = True
            top.Controls.Add(lb)
            i += 1
        End While

        Me.workBook = workBook
        If sheet Is Nothing Then
            'create a CalcSheet and add it to the workbook
            Me.sheet = New CalcSheet(rowCount, colCount)
            Me.sheet.Name = name
            Me.workBook.CalcSheetList.Add(Me.sheet) 'this line assigns sheet.Engine.
            If Me.workBook.Engine Is Nothing Then
                Me.workBook.Engine = Me.sheet.Engine
            End If
        Else
            Me.sheet = sheet
        End If

        Me.sheet.CalculationsSuspended = False
        Me.sheet.Engine.UseDependencies = True

        AddHandler Me.sheet.CalculatedValueChanged, AddressOf sheet_CalculatedValueChanged
    End Sub 'InitGrid 


    Private textBoxChanged As Boolean = False


    Private Sub tb_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        textBoxChanged = True
    End Sub 'tb_TextChanged


    Private Sub tb_Enter(ByVal sender As Object, ByVal e As EventArgs)
        'Console.WriteLine("enter_Enter {0}", DateTime.Now);
        Dim tb As TextBox = sender '
       
        If Not (tb Is Nothing) Then
            Dim row, col As Integer
            If GetRowCol(tb, row, col) > -1 Then
                Dim s As String = Me.sheet.Engine.GetFormulaRowCol(Me.sheet, row, col)
                If s.Length > 0 Then
                    tb.Text = s
                End If
            End If
        End If
        textBoxChanged = False
    End Sub 'tb_Enter
    '			Console.WriteLine("leave_Enter {0}", DateTime.Now);

    Private Sub tb_Leave(ByVal sender As Object, ByVal e As EventArgs)
        Dim tb As TextBox = sender '
        
        If Not (tb Is Nothing) Then
            Dim row, col As Integer
            If GetRowCol(tb, row, col) > -1 Then
                Dim o As Object = Me.sheet.GetValueRowCol(row, col)
                If textBoxChanged OrElse (Not (o Is Nothing) AndAlso o.ToString() <> tb.Text) Then
                    textBoxChanged = False
                    Me.sheet(row, col) = tb.Text
                    tb.Text = Me.sheet.GetValueRowCol(row, col).ToString()
                End If
            End If
        End If
    End Sub 'tb_Leave
    
    Private Sub sheet_CalculatedValueChanged(ByVal sender As Object, ByVal e As ValueChangedEventArgs)
        Dim tb As TextBox = Me.GetTextBox(e.RowIndex, e.ColIndex)
        tb.Text = e.Value
    End Sub 'sheet_CalculatedValueChanged


    Default Public Property Item(ByVal row As Integer, ByVal col As Integer) As String
        Get
            Return GetTextBox(row, col).Text
        End Get

        Set(ByVal Value As String)
            GetTextBox(row, col).Text = Value
        End Set
    End Property


    Public Function GetTextBox(ByVal row As Integer, ByVal col As Integer) As TextBox
        Return Me.textBoxes(((row - 1) * Me.colCount + col - 1))
    End Function 'GetTextBox


    Public Function GetActiveTextBoxRowCol(ByRef row As Integer, ByRef col As Integer) As TextBox
        Dim found As TextBox = Nothing
        col = -1
        row = -1
        Dim i As Integer

        While i < Me.textBoxCount
            If Me.textBoxes(i).Focused Then
                col = i Mod Me.colCount + 1
                row = Int(i / Me.colCount) + 1
                found = Me.textBoxes(i)
                Exit While
            End If
            i += 1
        End While
        Return found
    End Function 'GetActiveTextBoxRowCol

    Private Function GetRowCol(ByVal tb As TextBox, ByRef row As Integer, ByRef col As Integer) As Integer
        Dim found As Integer = -1
        col = -1
        row = -1
        Dim i As Integer

        While i < Me.textBoxCount
            If Me.textBoxes(i).Equals(tb) Then
                col = i Mod Me.colCount + 1
                row = Int(i / Me.colCount) + 1
                found = i
                Exit While
            End If
            i += 1
        End While
        Return found
    End Function 'GetRowCol


    Private Function GetRectangle(ByVal row As Integer, ByVal col As Integer) As Rectangle
        Dim dx As Integer = (Me.ClientSize.Width - Me.leftOffSet) / Me.colCount
        Dim dy As Integer = (Me.ClientSize.Height - Me.topOffSet) / Me.rowCount

        Return New Rectangle((row - 1) * dx + Me.leftOffSet, (col - 1) * dy + Me.topOffSet, dx, dy)
    End Function 'GetRectangle
End Class 'PanelGrid 
