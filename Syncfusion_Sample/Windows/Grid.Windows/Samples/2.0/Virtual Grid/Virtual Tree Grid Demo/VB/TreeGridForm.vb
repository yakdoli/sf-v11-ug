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
Imports Syncfusion.ComponentModel
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Resources
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Windows.Forms

Namespace CustomGridCell
    Public Class TreeGridForm
        Inherits MetroForm
        Private WithEvents gridControl1 As GridControl
        Private WithEvents imageList1 As ImageList
        Private components As IContainer
        Private WithEvents button1 As ButtonAdv
        Private WithEvents button2 As ButtonAdv
        Private WithEvents button3 As ButtonAdv
        Private WithEvents label1 As Label
        Private WithEvents button4 As ButtonAdv
        Private WithEvents button5 As ButtonAdv
        Public Shared NoChildBMP As Integer
        Public Shared OpenedBMP As Integer
        Public Shared ClosedBMP As Integer
        Public Shared externalData As CollapsibleDataSource
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Private panel1 As System.Windows.Forms.Panel

        Public Sub New()
            MyBase.New()
            NoChildBMP = 2
            OpenedBMP = 0
            ClosedBMP = 1
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            gridControl1.ControllerOptions = (GridControllerOptions.All And Not (GridControllerOptions.OleDataSource))

        End Sub
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
            Me.components = New System.ComponentModel.Container
            Dim GridBaseStyle1 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle2 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle3 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle4 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridCellInfo1 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.button2 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.button3 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.label1 = New System.Windows.Forms.Label
            Me.button4 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.button5 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.panel1 = New System.Windows.Forms.Panel
            Me.GroupBox2 = New System.Windows.Forms.GroupBox
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridControl1.BackColor = System.Drawing.Color.White
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
            Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gridControl1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)})
            Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
            Me.gridControl1.DefaultRowHeight = 20
            Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.5!)
            Me.gridControl1.ForeColor = System.Drawing.Color.MidnightBlue
            GridCellInfo1.Col = -1
            GridCellInfo1.Row = -1
            GridCellInfo1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridCellInfo1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridCellInfo1.StyleInfo.Font.Bold = False
            GridCellInfo1.StyleInfo.Font.Facename = "Segoe UI"
            GridCellInfo1.StyleInfo.Font.Italic = False
            GridCellInfo1.StyleInfo.Font.Size = 8.5!
            GridCellInfo1.StyleInfo.Font.Strikeout = False
            GridCellInfo1.StyleInfo.Font.Underline = False
            GridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridCellInfo1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridCellInfo1.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridControl1.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() {GridCellInfo1})
            Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridControl1.HorizontalThumbTrack = True
            Me.gridControl1.Location = New System.Drawing.Point(25, 35)
            Me.gridControl1.MetroScrollBars = True
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
            Me.gridControl1.Properties.MarkColHeader = False
            Me.gridControl1.Properties.MarkRowHeader = False
            Me.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.gridControl1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
            Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode
            Me.gridControl1.Size = New System.Drawing.Size(498, 341)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ThemesEnabled = True
            Me.gridControl1.VerticalThumbTrack = True
            '
            'imageList1
            '
            Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
            Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            '
            'button1
            '
            Me.button1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.ForeColor = System.Drawing.Color.White
            Me.button1.Location = New System.Drawing.Point(21, 33)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(112, 26)
            Me.button1.TabIndex = 1
            Me.button1.Text = "Load DataSource"
            Me.button1.UseVisualStyle = True
            Me.button1.UseVisualStyleBackColor = True
            '
            'button2
            '
            Me.button2.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button2.ForeColor = System.Drawing.Color.White
            Me.button2.Location = New System.Drawing.Point(21, 75)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(112, 26)
            Me.button2.TabIndex = 2
            Me.button2.Text = "Save DataSource"
            Me.button2.UseVisualStyle = True
            Me.button2.UseVisualStyleBackColor = True
            '
            'button3
            '
            Me.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button3.ForeColor = System.Drawing.Color.White
            Me.button3.Location = New System.Drawing.Point(21, 119)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(112, 26)
            Me.button3.TabIndex = 3
            Me.button3.Text = "Reset"
            Me.button3.UseVisualStyle = True
            Me.button3.UseVisualStyleBackColor = True
            '
            'label1
            '
            Me.label1.BackColor = System.Drawing.Color.White
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Location = New System.Drawing.Point(22, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(501, 32)
            Me.label1.TabIndex = 4
            Me.label1.Text = "Right-Click node in Column A for Positive/Negative indent"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'button4
            '
            Me.button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button4.ForeColor = System.Drawing.Color.White
            Me.button4.Location = New System.Drawing.Point(21, 35)
            Me.button4.Name = "button4"
            Me.button4.Size = New System.Drawing.Size(112, 25)
            Me.button4.TabIndex = 5
            Me.button4.Text = "Expand All"
            Me.button4.UseVisualStyle = True
            Me.button4.UseVisualStyleBackColor = True
            '
            'button5
            '
            Me.button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button5.ForeColor = System.Drawing.Color.White
            Me.button5.Location = New System.Drawing.Point(21, 75)
            Me.button5.Name = "button5"
            Me.button5.Size = New System.Drawing.Size(112, 26)
            Me.button5.TabIndex = 6
            Me.button5.Text = "Close All"
            Me.button5.UseVisualStyle = True
            Me.button5.UseVisualStyleBackColor = True
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.GroupBox2)
            Me.panel1.Controls.Add(Me.GroupBox1)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.gridControl1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(724, 396)
            Me.panel1.TabIndex = 7
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.button5)
            Me.GroupBox2.Controls.Add(Me.button4)
            Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.GroupBox2.Location = New System.Drawing.Point(548, 238)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(150, 135)
            Me.GroupBox2.TabIndex = 9
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Expand Options"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.button3)
            Me.GroupBox1.Controls.Add(Me.button2)
            Me.GroupBox1.Controls.Add(Me.button1)
            Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(548, 44)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(150, 176)
            Me.GroupBox1.TabIndex = 8
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Data Source"
            '
            'TreeGridForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
            Me.BackColor = System.Drawing.Color.White
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
			Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(724, 396)
            Me.Controls.Add(Me.panel1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "TreeGridForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Virtual Tree Grid Demo"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub 'InitializeComponent 
#End Region


        <STAThread()> _
        Public Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
            Application.EnableVisualStyles()
#End If
            Application.Run(New TreeGridForm())

        End Sub
        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            ' load the bitmaps
            Me.imageList1.ImageSize = New Size(20, 17)
            Dim bm As Bitmap

            bm = New Bitmap([GetType].Module.Assembly.GetManifestResourceStream("minus.bmp"))
            Me.imageList1.Images.Add(bm, Color.White)
            bm = New Bitmap([GetType].Module.Assembly.GetManifestResourceStream("plus.bmp"))
            Me.imageList1.Images.Add(bm, Color.White)
            bm = New Bitmap([GetType].Module.Assembly.GetManifestResourceStream("nochild.bmp"))
            Me.imageList1.Images.Add(bm, Color.White)

            'add a custom cell control
            gridControl1.CellModels.Add("TreeCell", New TreeCellModel(gridControl1.Model))
            'make the imagelist available thru the tablestyle
            gridControl1.TableStyle.ImageList = Me.imageList1
            'create a sample data for a virtual grid
            externalData = New CollapsibleDataSource(100)
            externalData.InitData()
            'initializes an external datasource
            externalData.CollapseData()

            'hook up the events needed for virtual grid
            gridControl1.ResetVolatileData()

            AddHandler gridControl1.QueryCellInfo, New GridQueryCellInfoEventHandler(AddressOf GridQueryCellInfo)
            AddHandler gridControl1.QueryRowCount, New GridRowColCountEventHandler(AddressOf GridQueryRowCount)
            AddHandler gridControl1.QueryColCount, New GridRowColCountEventHandler(AddressOf GridQueryColCount)
            AddHandler gridControl1.QueryColWidth, New GridRowColSizeEventHandler(AddressOf GridQueryColWidth)

            'handle saving data back to the data source...
            AddHandler gridControl1.SaveCellInfo, New GridSaveCellInfoEventHandler(AddressOf GridSaveCellInfo)

            'Load some sample data
            Me.ReadData(FindFullPath("datasample.cds"))

            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
            Me.gridControl1.DefaultRowHeight = 18
            Me.gridControl1.DefaultColWidth = 70

            Me.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid
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


        Function FindFullPath(ByVal cdsFileName As String) As String
            ' Check both in parent folder and Parent\Data folders.
            Dim cdsDataFileName As String = "Data\" + cdsFileName
            Dim n As Integer
            For n = 0 To 11
                If System.IO.File.Exists(cdsFileName) Then
                    Return Path.GetFullPath(cdsFileName)
                End If
                If System.IO.File.Exists(cdsDataFileName) Then
                    Return Path.GetFullPath(cdsDataFileName)
                End If
                cdsFileName = "..\" + cdsFileName
                cdsDataFileName = "..\" + cdsDataFileName
            Next n

            Return ""
        End Function 'FindFullPath

        Private Sub GridSaveCellInfo(ByVal sender As Object, ByVal e As GridSaveCellInfoEventArgs)

            'refresh this row so change is displayed
            Try
                'move the changes back to the external data object
                If ((e.ColIndex = 1) _
                            AndAlso (e.RowIndex > 0)) Then

                    externalData((e.RowIndex - 1)).ExpandState = CType(e.Style.ImageIndex, Integer)
                    externalData((e.RowIndex - 1)).IndentLevel = CType(e.Style.Tag, Integer)
                End If
                If ((e.ColIndex > 0) _
                            AndAlso (e.RowIndex > 0)) Then
                    externalData((e.RowIndex - 1)).Items((e.ColIndex - 1)) = CType(e.Style.CellValue, String)
                End If
            Catch ex As System.Exception
            End Try
            If Not (externalData.Locked) Then
                externalData.CollapseData()
                Me.gridControl1.Refresh()
            End If
            e.Handled = True

        End Sub
        Private Sub GridQueryColWidth(ByVal sender As Object, ByVal e As GridRowColSizeEventArgs)

            If (e.Index = 1) Then
                e.Size = 200
            Else
                If (e.Index > 0) Then
                    e.Size = 100
                Else
                    e.Size = 0
                End If
            End If
            'hide the header // 30;
            e.Handled = True

        End Sub
        Private Sub GridQueryRowCount(ByVal sender As Object, ByVal e As GridRowColCountEventArgs)

            e.Count = externalData.RowCount
            e.Handled = True

        End Sub
        Private Sub GridQueryColCount(ByVal sender As Object, ByVal e As GridRowColCountEventArgs)

            e.Count = externalData.ColCount
            e.Handled = True

        End Sub
        Private Sub GridQueryCellInfo(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)

            If ((e.RowIndex > 0) _
                        AndAlso (e.ColIndex > 0)) Then
                e.Style.CellValue = externalData((e.RowIndex - 1)).Items((e.ColIndex - 1))
                If (e.ColIndex = 1) Then
                    e.Style.CellType = "TreeCell"
                    e.Style.Tag = externalData((e.RowIndex - 1)).IndentLevel
                    e.Style.ImageIndex = CType(externalData((e.RowIndex - 1)).ExpandState, Integer)
                End If
                e.Handled = True
            End If

        End Sub
        Private Sub ReadData(ByVal filename As String)

            Try
                Dim formatter As IFormatter
                formatter = New BinaryFormatter
                Dim stream As Stream
                stream = New FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read)
                externalData = CType(formatter.Deserialize(stream), CollapsibleDataSource)
                stream.Close()
                Me.gridControl1.ResetVolatileData()
                TreeGridForm.externalData.CollapseData()
                Me.gridControl1.Refresh()

            Catch
                'empty
            End Try
        End Sub
        Private Sub button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
            Dim openFileDialog1 As OpenFileDialog
            openFileDialog1 = New OpenFileDialog
            openFileDialog1.Filter = "Collapsible Data Files|*.cds"
            openFileDialog1.FilterIndex = 1
            openFileDialog1.InitialDirectory = Application.ExecutablePath
            If (openFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
                ReadData(openFileDialog1.FileName)
            End If
        End Sub

        Private Sub button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
            ' Create a SaveFileDialog 
            Dim saveFile1 As SaveFileDialog
            saveFile1 = New SaveFileDialog
            saveFile1.DefaultExt = "*.cds"
            saveFile1.Filter = "Collapsible Data Files|*.cds"
            saveFile1.InitialDirectory = Application.ExecutablePath
            ' get a file name from the user
            If (saveFile1.ShowDialog = Windows.Forms.DialogResult.OK) Then
                Dim formatter As IFormatter
                formatter = New BinaryFormatter
                Dim stream As Stream
                stream = New FileStream(saveFile1.FileName, FileMode.Create, FileAccess.Write, FileShare.None)
                formatter.Serialize(stream, externalData)
                stream.Close()
            End If
        End Sub

        Private Sub button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
            gridControl1.ResetVolatileData()
            externalData.ExpandAll()
            externalData.CollapseData()
            gridControl1.UpdateScrollBars()
            Me.gridControl1.Invalidate()
        End Sub

        Private Sub button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button5.Click
            gridControl1.ResetVolatileData()
            externalData.CloseAll()
            externalData.CollapseData()
            gridControl1.CurrentCell.MoveTo(1, 1)
            gridControl1.UpdateScrollBars()
            Me.gridControl1.Invalidate()
        End Sub

        Private Sub button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
            gridControl1.ResetVolatileData()
            externalData.InitData()
            externalData.CollapseData()
            Me.gridControl1.Refresh()
        End Sub
    End Class
End Namespace
