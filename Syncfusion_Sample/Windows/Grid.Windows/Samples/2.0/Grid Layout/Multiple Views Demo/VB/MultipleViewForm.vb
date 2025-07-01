Imports Microsoft.VisualBasic
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
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Grid



''' <summary>
''' Summary description for Form1.
''' </summary>
Public Class MultipleViewForm
    Inherits Syncfusion.Windows.Forms.MetroForm
    Private gridControl1 As GridControl
    Private gridControl2 As GridControl
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.Container = Nothing

    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        gridControl1.Model.TextDataExchange.PasteTextFromBuffer("1" & Constants.vbTab & "Davolio	Nancy" & Constants.vbCrLf & "2" & Constants.vbTab & "Fuller	Andrew" & Constants.vbCrLf & "3" & Constants.vbTab & "Leverling	Janet" & Constants.vbCrLf & "4" & Constants.vbTab & "Peacock	Margaret" & Constants.vbCrLf & "5" & Constants.vbTab & "Buchanan	Steven" & Constants.vbCrLf & "6" & Constants.vbTab & "Suyama	Michael" & Constants.vbCrLf & "7" & Constants.vbTab & "King	Robert" & Constants.vbCrLf & "8" & Constants.vbTab & "Callahan	Laura" & Constants.vbCrLf & "9" & Constants.vbTab & "Dodsworth	Anne" & Constants.vbCrLf, GridRangeInfo.Cell(1, 1), Integer.MaxValue)

        Dim standard As GridStyleInfo = gridControl1.BaseStylesMap("Standard").StyleInfo
        'System.IO.Stream strm = null; 
        Dim imageList As New ImageList()

        Dim strm As System.IO.Stream = Nothing
        Dim iconName As String = "user.ico"
        strm = Me.GetType().Assembly.GetManifestResourceStream(iconName)
        Dim icon As New Icon(strm)
        imageList.Images.Add(icon.ToBitmap())

        iconName = "userH.ico"
        strm = Me.GetType().Assembly.GetManifestResourceStream(iconName)
        icon = New Icon(strm)
        imageList.Images.Add(icon.ToBitmap())

        iconName = "userJ.ico"
        strm = Me.GetType().Assembly.GetManifestResourceStream(iconName)
        icon = New Icon(strm)
        imageList.Images.Add(icon.ToBitmap())

        standard.ImageList = imageList

        Dim rowIndex As Integer = 1
        Dim colIndex As Integer = 2
        gridControl1(rowIndex, colIndex).ImageIndex = 1
        rowIndex += 1
        gridControl1(rowIndex, colIndex).ImageIndex = 2
        rowIndex += 1
        gridControl1(rowIndex, colIndex).ImageIndex = 0
        rowIndex += 1
        gridControl1(rowIndex, colIndex).ImageIndex = 1
        rowIndex += 1
        gridControl1(rowIndex, colIndex).ImageIndex = 1
        rowIndex += 1
        gridControl1(rowIndex, colIndex).ImageIndex = 2
        rowIndex += 1
        gridControl1(rowIndex, colIndex).ImageIndex = 2
        rowIndex += 1
        gridControl1(rowIndex, colIndex).ImageIndex = 0
        rowIndex += 1
        gridControl1(rowIndex, colIndex).ImageIndex = 1
        rowIndex += 1

        'gridControl1.Model.Options.DataObjectConsumerOptions = GridDataObjectConsumerOptions.Styles;
        gridControl1.DataObjectConsumerOptions = GridDataObjectConsumerOptions.All


        Dim style As GridStyleInfo

        style = New GridStyleInfo()
        style.Interior = New BrushInfo(Color.White)
        style.TextColor = Color.FromArgb(&H82, &H2E, &H1B)
        gridControl1.ChangeCells(GridRangeInfo.Cells(1, 1, 9, 3), style)

        style = New GridStyleInfo()
        style.HorizontalAlignment = GridHorizontalAlignment.Right
        style.CellValueType = GetType(Integer)
        style.Format = "000"
        gridControl1.ChangeCells(GridRangeInfo.Cells(1, 1, 9, 1), style)

        gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cells(1, 1, 9, 3))

        gridControl1.CommandStack.Enabled = True

        ' Make second grid controls share the same model.

        Try
            Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try
        Me.gridControl1.DefaultRowHeight = 18
        Me.gridControl1.DefaultColWidth = 70
        Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
        Me.gridControl1.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
        Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
        style = Me.gridControl1.BaseStylesMap("Header").StyleInfo
        style.TextColor = System.Drawing.Color.MidnightBlue
        style.Font.Facename = "Verdana"
        style = Me.gridControl1.BaseStylesMap("Standard").StyleInfo
        style.TextColor = System.Drawing.Color.MidnightBlue
        style.Font.Facename = "Verdana"
        gridControl2.Model = gridControl1.Model
        Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
    End Sub
#Region "Method"
    Private Function GetIconFile(ByVal bitmapName As String) As String
        For n As Integer = 0 To 9
            If System.IO.File.Exists(bitmapName) Then
                Return bitmapName
            End If

            bitmapName = "..\" & bitmapName
        Next n

        Return bitmapName
    End Function
    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
#End Region

#Region "Windows Form Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
        Me.gridControl2 = New Syncfusion.Windows.Forms.Grid.GridControl()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' gridControl1
        ' 
        Me.gridControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
        Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridControl1.ColCount = 55
        Me.gridControl1.HorizontalThumbTrack = True
        Me.gridControl1.Location = New System.Drawing.Point(12, 12)
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.RowCount = 100
        Me.gridControl1.Size = New System.Drawing.Size(280, 259)
        Me.gridControl1.SmartSizeBox = False
        Me.gridControl1.TabIndex = 0
        Me.gridControl1.Text = "gridControl1"
        Me.gridControl1.ThemesEnabled = True
        Me.gridControl1.VerticalThumbTrack = True
        ' 
        ' gridControl2
        ' 
        Me.gridControl2.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.gridControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridControl2.ColCount = 20
        Me.gridControl2.HorizontalThumbTrack = True
        Me.gridControl2.Location = New System.Drawing.Point(308, 10)
        Me.gridControl2.Name = "gridControl2"
        Me.gridControl2.RowCount = 100
        Me.gridControl2.Size = New System.Drawing.Size(260, 261)
        Me.gridControl2.SmartSizeBox = False
        Me.gridControl2.TabIndex = 0
        Me.gridControl2.Text = "gridControl1"
        Me.gridControl2.ThemesEnabled = True
        Me.gridControl2.VerticalThumbTrack = True
        ' 
        ' MultipleViewForm
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.ClientSize = New System.Drawing.Size(583, 289)
        Me.Controls.Add(Me.gridControl1)
        Me.Controls.Add(Me.gridControl2)
        Me.DropShadow = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.MinimizeBox = False
        Me.Name = "MultipleViewForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
        Me.Text = "Multiple View Demo"
        '			Me.Layout += New System.Windows.Forms.LayoutEventHandler(Me.MultipleViewForm_Layout)
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

#Region "Event Handler"
    Private Sub MultipleViewForm_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles MyBase.Layout
        Dim xOffSet As Integer = 14
        Dim yOffSet As Integer = 14
        Dim width As Integer = ClientRectangle.Width \ 2 - 3 * xOffSet \ 2 '2 * xOffSet + xOffSet / 2;
        Dim height As Integer = ClientRectangle.Height - 2 * yOffSet

        gridControl1.Location = New Point(xOffSet, yOffSet)
        gridControl1.Size = New Size(width, height)

        gridControl2.Location = New Point(width + 2 * xOffSet, yOffSet)
        gridControl2.Size = New Size(width, height)

    End Sub
#End Region
    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()> _
    Public Shared Sub Main()
#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
        Application.EnableVisualStyles()
#End If
        Application.Run(New MultipleViewForm())
    End Sub

End Class

