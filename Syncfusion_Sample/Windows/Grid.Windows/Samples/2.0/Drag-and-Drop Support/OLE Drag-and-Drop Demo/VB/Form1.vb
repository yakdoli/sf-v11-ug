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
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Resources
Imports System.Windows.Forms

Namespace OleDragDrop
    Public Class Form1
        Inherits MetroForm
        Private WithEvents gridControl1 As GridControl
        Private WithEvents gridControl2 As GridControl
        Private WithEvents richTextBox1 As OleDragDrop.DNDRichTextBox
        Private components As Container
        Private panel1 As System.Windows.Forms.Panel

        Public Sub New()
            MyBase.New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
            gridControl1.Model.TextDataExchange.PasteTextFromBuffer((((((((("1" & Microsoft.VisualBasic.ChrW(9) & "Davolio" & Microsoft.VisualBasic.ChrW(9) & "Nancy" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) + "2" & Microsoft.VisualBasic.ChrW(9) & "Fuller" & Microsoft.VisualBasic.ChrW(9) & "Andrew" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)) _
                            + "3" & Microsoft.VisualBasic.ChrW(9) & "Leverling" & Microsoft.VisualBasic.ChrW(9) & "Janet" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)) _
                            + "4" & Microsoft.VisualBasic.ChrW(9) & "Peacock" & Microsoft.VisualBasic.ChrW(9) & "Margaret" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)) _
                            + "5" & Microsoft.VisualBasic.ChrW(9) & "Buchanan" & Microsoft.VisualBasic.ChrW(9) & "Steven" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)) _
                            + "6" & Microsoft.VisualBasic.ChrW(9) & "Suyama" & Microsoft.VisualBasic.ChrW(9) & "Michael" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)) _
                            + "7" & Microsoft.VisualBasic.ChrW(9) & "King" & Microsoft.VisualBasic.ChrW(9) & "Robert" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)) _
                            + "8" & Microsoft.VisualBasic.ChrW(9) & "Callahan" & Microsoft.VisualBasic.ChrW(9) & "Laura" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)) _
                            + "9" & Microsoft.VisualBasic.ChrW(9) & "Dodsworth" & Microsoft.VisualBasic.ChrW(9) & "Anne" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)), GridRangeInfo.Cell(1, 1), System.Int32.MaxValue)
            Dim style As GridStyleInfo
            style = New GridStyleInfo()


            style.Interior = New BrushInfo(Color.FromArgb(&HED, &HF0, &HF7))
            style.TextColor = Color.FromArgb(238, 122, 3) 'Color.Orange;
            gridControl1.ChangeCells(GridRangeInfo.Cells(1, 1, 9, 3), style)
            style = New GridStyleInfo()
            style.HorizontalAlignment = GridHorizontalAlignment.Right
            style.CellValueType = GetType(System.Int32)
            style.Format = "000"
            gridControl1.ChangeCells(GridRangeInfo.Cells(1, 1, 9, 1), style)
            gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cells(1, 1, 9, 3), GridResizeToFitOptions.NoShrinkSize)
            gridControl1.CommandStack.Enabled = True
            gridControl2.CommandStack.Enabled = True

            gridControl1.AllowDrop = True
            gridControl2.AllowDrop = True

            gridControl1.ShowMessageBoxOnDrop = False
            gridControl2.ShowMessageBoxOnDrop = False
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
            richTextBox1.Text = (((((((((("Drag content using OLE Drag-and-Drop between grids, any other application or use Co" & _
    "py Paste " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) + "Sample Data:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)) _
                        + "1" & Microsoft.VisualBasic.ChrW(9) & "Davolio" & Microsoft.VisualBasic.ChrW(9) & "Nancy" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)) _
                        + "2" & Microsoft.VisualBasic.ChrW(9) & "Fuller" & Microsoft.VisualBasic.ChrW(9) & "Andrew" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)) _
                        + "3" & Microsoft.VisualBasic.ChrW(9) & "Leverling" & Microsoft.VisualBasic.ChrW(9) & "Janet" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)) _
                        + "4" & Microsoft.VisualBasic.ChrW(9) & "Peacock" & Microsoft.VisualBasic.ChrW(9) & "Margaret" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)) _
                        + "5" & Microsoft.VisualBasic.ChrW(9) & "Buchanan" & Microsoft.VisualBasic.ChrW(9) & "Steven" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)) _
                        + "6" & Microsoft.VisualBasic.ChrW(9) & "Suyama" & Microsoft.VisualBasic.ChrW(9) & "Michael" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)) _
                        + "7" & Microsoft.VisualBasic.ChrW(9) & "King" & Microsoft.VisualBasic.ChrW(9) & "Robert" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)) _
                        + "8" & Microsoft.VisualBasic.ChrW(9) & "Callahan" & Microsoft.VisualBasic.ChrW(9) & "Laura" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)) _
                        + "9" & Microsoft.VisualBasic.ChrW(9) & "Dodsworth" & Microsoft.VisualBasic.ChrW(9) & "Anne" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10))

            Me.gridControl1.DefaultRowHeight = 18
            Me.gridControl1.DefaultColWidth = 70
            Me.gridControl1.GridVisualStyles = GridVisualStyles.Metro
            Me.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid
            Me.gridControl1.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
            style = gridControl1.BaseStylesMap("Header").StyleInfo
            style.TextColor = Color.MidnightBlue
            style.Font.Facename = "Segoe UI"
            Me.BackColor = Color.White
            Me.StartPosition = FormStartPosition.CenterScreen

            Me.gridControl2.DefaultRowHeight = 18
            Me.gridControl2.DefaultColWidth = 70
            Me.gridControl2.GridVisualStyles = GridVisualStyles.Metro
            Me.gridControl2.DefaultGridBorderStyle = GridBorderStyle.Solid
            Me.gridControl2.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
            style = gridControl2.BaseStylesMap("Header").StyleInfo
            style.TextColor = Color.MidnightBlue
            style.Font.Facename = "Segoe UI"
            Me.BackColor = Color.White
            Me.StartPosition = FormStartPosition.CenterScreen



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

		
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)

            If disposing Then
                If (Not (components) Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)

        End Sub

#Region "Windows Form Designer generated code"

        '/ <summary>
        '/ Required method for Designer support - do not modify
        '/ the contents of this method with the code editor.
        '/ </summary>
        Private Sub InitializeComponent()
            Dim GridBaseStyle1 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle2 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle3 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle4 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle5 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle6 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle7 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle8 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.gridControl2 = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.panel1 = New System.Windows.Forms.Panel
            Me.richTextBox1 = New OleDragDrop.DNDRichTextBox
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            GridBaseStyle1.Name = "Row Header"
            GridBaseStyle1.StyleInfo.BaseStyle = "Header"
            GridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
            GridBaseStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle2.Name = "Column Header"
            GridBaseStyle2.StyleInfo.BaseStyle = "Header"
            GridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            GridBaseStyle3.Name = "Standard"
            GridBaseStyle3.StyleInfo.Font.Facename = "Tahoma"
            GridBaseStyle3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            GridBaseStyle4.Name = "Header"
            GridBaseStyle4.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle4.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle4.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle4.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle4.StyleInfo.CellType = "Header"
            GridBaseStyle4.StyleInfo.Font.Bold = True
            GridBaseStyle4.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle4.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            Me.gridControl1.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle1, GridBaseStyle2, GridBaseStyle3, GridBaseStyle4})
            Me.gridControl1.ColCount = 55
            Me.gridControl1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)})
            Me.gridControl1.HorizontalThumbTrack = True
            Me.gridControl1.Location = New System.Drawing.Point(22, 12)
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RowCount = 100
            Me.gridControl1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 25)})
            Me.gridControl1.Size = New System.Drawing.Size(297, 295)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.Text = "gridControl1"
            Me.gridControl1.ThemesEnabled = True
            Me.gridControl1.VerticalThumbTrack = True
			Me.gridControl1.BorderStyle=BorderStyle.FixedSingle
            '
            'gridControl2
            '
            GridBaseStyle5.Name = "Row Header"
            GridBaseStyle5.StyleInfo.BaseStyle = "Header"
            GridBaseStyle5.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
            GridBaseStyle5.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle6.Name = "Column Header"
            GridBaseStyle6.StyleInfo.BaseStyle = "Header"
            GridBaseStyle6.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            GridBaseStyle7.Name = "Standard"
            GridBaseStyle7.StyleInfo.Font.Facename = "Tahoma"
            GridBaseStyle7.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            GridBaseStyle8.Name = "Header"
            GridBaseStyle8.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle8.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle8.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle8.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle8.StyleInfo.CellType = "Header"
            GridBaseStyle8.StyleInfo.Font.Bold = True
            GridBaseStyle8.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle8.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            Me.gridControl2.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle5, GridBaseStyle6, GridBaseStyle7, GridBaseStyle8})
            Me.gridControl2.ColCount = 55
            Me.gridControl2.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)})
            Me.gridControl2.HorizontalThumbTrack = True
            Me.gridControl2.Location = New System.Drawing.Point(337, 12)
            Me.gridControl2.Name = "gridControl2"
            Me.gridControl2.RowCount = 100
            Me.gridControl2.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 25)})
            Me.gridControl2.Size = New System.Drawing.Size(307, 295)
            Me.gridControl2.SmartSizeBox = False
            Me.gridControl2.TabIndex = 0
            Me.gridControl2.Text = "gridControl1"
            Me.gridControl2.ThemesEnabled = True
            Me.gridControl2.VerticalThumbTrack = True
			Me.gridControl2.BorderStyle=BorderStyle.FixedSingle
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.richTextBox1)
            Me.panel1.Controls.Add(Me.gridControl2)
            Me.panel1.Controls.Add(Me.gridControl1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(662, 469)
            Me.panel1.TabIndex = 2
            '
            'richTextBox1
            '
            Me.richTextBox1.AcceptsTab = True
            Me.richTextBox1.AllowDrop = True
            Me.richTextBox1.AutoWordSelection = True
            Me.richTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.richTextBox1.Location = New System.Drawing.Point(22, 322)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.ShowSelectionMargin = True
            Me.richTextBox1.Size = New System.Drawing.Size(622, 132)
            Me.richTextBox1.TabIndex = 1
            Me.richTextBox1.Text = ""
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
            Me.BackColor = System.Drawing.Color.White
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
			Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(662, 469)
            Me.Controls.Add(Me.panel1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
            Me.Text = "OLE Drag-and-Drop Demo"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub 'InitializeComponent 
#End Region

        <STAThread()> _
        Public Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
Application.EnableVisualStyles
#End If
            Application.Run(New Form1())
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            AddHandler gridControl1.DragOver, New System.Windows.Forms.DragEventHandler(AddressOf gridControl1_DragOver)
            AddHandler gridControl2.DragOver, New System.Windows.Forms.DragEventHandler(AddressOf gridControl2_DragOver)
        End Sub
        Private Sub gridControl1_DragOver(ByVal sender As Object, ByVal e As DragEventArgs)
            e.Effect = DragDropEffects.Copy
        End Sub
        Private Sub gridControl2_DragOver(ByVal sender As Object, ByVal e As DragEventArgs)
            e.Effect = DragDropEffects.Copy
        End Sub
    End Class
End Namespace
