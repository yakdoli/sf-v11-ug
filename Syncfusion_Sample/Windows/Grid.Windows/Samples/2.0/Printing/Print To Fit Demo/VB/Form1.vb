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
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Namespace PrintAsBitmap
    Public Class Form1
        Inherits MetroForm
        Private WithEvents gridControl1 As GridControl
        Private WithEvents pictureBox1 As PictureBox
        Private WithEvents groupBox1 As GroupBox
        Private WithEvents label1 As Label
        Private WithEvents label2 As Label
        Private WithEvents numericUpDown1 As NumericUpDown
        Private WithEvents numericUpDown2 As NumericUpDown
        Private components As System.ComponentModel.IContainer
        Friend WithEvents ButtonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
        Friend WithEvents ButtonAdv4 As Syncfusion.Windows.Forms.ButtonAdv
        Friend WithEvents ButtonAdv3 As Syncfusion.Windows.Forms.ButtonAdv
        Friend WithEvents ButtonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Private panel1 As System.Windows.Forms.Panel
        'Fields
        'Constructors
        'Events
        'Methods
        Public Sub New()
            MyBase.New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
			 Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
			
            Me.gridControl1.GridVisualStyles = GridVisualStyles.Metro
            Me.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid
            Me.gridControl1.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
            Dim style As GridStyleInfo = gridControl1.BaseStylesMap("Header").StyleInfo
            style.TextColor = Color.MidnightBlue
            style.Font.Facename = "Segoe UI"
            Me.BackColor = Color.White
            Me.StartPosition = FormStartPosition.CenterScreen
            '
            ' TODO: Add any constructor code after InitializeComponent call
            ''

        End Sub
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)

            If disposing Then
                If (Not (components) Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)

        End Sub
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim GridCellInfo1 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.label2 = New System.Windows.Forms.Label
            Me.ButtonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.label1 = New System.Windows.Forms.Label
            Me.panel1 = New System.Windows.Forms.Panel
            Me.GroupBox2 = New System.Windows.Forms.GroupBox
            Me.ButtonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.ButtonAdv4 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.ButtonAdv3 = New Syncfusion.Windows.Forms.ButtonAdv
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.AllowDrop = True
            Me.gridControl1.ColCount = 7
            Me.gridControl1.DefaultColWidth = 70
            Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
            Me.gridControl1.DefaultRowHeight = 20
            Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            GridCellInfo1.Col = -1
            GridCellInfo1.Row = -1
            GridCellInfo1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridCellInfo1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridCellInfo1.StyleInfo.Font.Facename = "Segoe UI"
            GridCellInfo1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridCellInfo1.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridControl1.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() {GridCellInfo1})
            Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridControl1.Location = New System.Drawing.Point(12, 0)
            Me.gridControl1.MetroScrollBars = True
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RowCount = 16
            Me.gridControl1.Size = New System.Drawing.Size(554, 408)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.Text = "gridControl1"
            Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.BorderStyle=BorderStyle.FixedSingle
            '
            'pictureBox1
            '
            Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pictureBox1.Location = New System.Drawing.Point(752, 100)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(269, 207)
            Me.pictureBox1.TabIndex = 1
            Me.pictureBox1.TabStop = False
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.numericUpDown2)
            Me.groupBox1.Controls.Add(Me.numericUpDown1)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.ButtonAdv1)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(581, 26)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(154, 177)
            Me.groupBox1.TabIndex = 5
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Change Content"
            '
            'numericUpDown2
            '
            Me.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numericUpDown2.Location = New System.Drawing.Point(58, 89)
            Me.numericUpDown2.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
            Me.numericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown2.Name = "numericUpDown2"
            Me.numericUpDown2.Size = New System.Drawing.Size(57, 22)
            Me.numericUpDown2.TabIndex = 3
            Me.numericUpDown2.Value = New Decimal(New Integer() {10, 0, 0, 0})
            '
            'numericUpDown1
            '
            Me.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numericUpDown1.Location = New System.Drawing.Point(58, 39)
            Me.numericUpDown1.Maximum = New Decimal(New Integer() {80, 0, 0, 0})
            Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.Size = New System.Drawing.Size(57, 22)
            Me.numericUpDown1.TabIndex = 2
            Me.numericUpDown1.Value = New Decimal(New Integer() {30, 0, 0, 0})
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(10, 89)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(38, 28)
            Me.label2.TabIndex = 1
            Me.label2.Text = "Cols:"
            '
            'ButtonAdv1
            '
            Me.ButtonAdv1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ButtonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.ButtonAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ButtonAdv1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonAdv1.ForeColor = System.Drawing.Color.White
            Me.ButtonAdv1.Location = New System.Drawing.Point(13, 133)
            Me.ButtonAdv1.Name = "ButtonAdv1"
            Me.ButtonAdv1.Size = New System.Drawing.Size(126, 23)
            Me.ButtonAdv1.TabIndex = 6
            Me.ButtonAdv1.Text = "Apply"
            Me.ButtonAdv1.UseVisualStyle = True
            Me.ButtonAdv1.UseVisualStyleBackColor = True
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(10, 36)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(48, 28)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Rows:"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.GroupBox2)
            Me.panel1.Controls.Add(Me.groupBox1)
            Me.panel1.Controls.Add(Me.gridControl1)
            Me.panel1.Controls.Add(Me.pictureBox1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1043, 432)
            Me.panel1.TabIndex = 6
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.ButtonAdv2)
            Me.GroupBox2.Controls.Add(Me.ButtonAdv4)
            Me.GroupBox2.Controls.Add(Me.ButtonAdv3)
            Me.GroupBox2.Location = New System.Drawing.Point(581, 225)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(154, 167)
            Me.GroupBox2.TabIndex = 10
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Printing Options"
            '
            'ButtonAdv2
            '
            Me.ButtonAdv2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ButtonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.ButtonAdv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ButtonAdv2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonAdv2.ForeColor = System.Drawing.Color.White
            Me.ButtonAdv2.Location = New System.Drawing.Point(13, 39)
            Me.ButtonAdv2.Name = "ButtonAdv2"
            Me.ButtonAdv2.Size = New System.Drawing.Size(126, 23)
            Me.ButtonAdv2.TabIndex = 7
            Me.ButtonAdv2.Text = "Show Bitmap"
            Me.ButtonAdv2.UseVisualStyle = True
            Me.ButtonAdv2.UseVisualStyleBackColor = True
            '
            'ButtonAdv4
            '
            Me.ButtonAdv4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ButtonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.ButtonAdv4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ButtonAdv4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonAdv4.ForeColor = System.Drawing.Color.White
            Me.ButtonAdv4.Location = New System.Drawing.Point(13, 115)
            Me.ButtonAdv4.Name = "ButtonAdv4"
            Me.ButtonAdv4.Size = New System.Drawing.Size(126, 23)
            Me.ButtonAdv4.TabIndex = 9
            Me.ButtonAdv4.Text = "PrintToFit"
            Me.ButtonAdv4.UseVisualStyle = True
            Me.ButtonAdv4.UseVisualStyleBackColor = True
            '
            'ButtonAdv3
            '
            Me.ButtonAdv3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ButtonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.ButtonAdv3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ButtonAdv3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButtonAdv3.ForeColor = System.Drawing.Color.White
            Me.ButtonAdv3.Location = New System.Drawing.Point(13, 77)
            Me.ButtonAdv3.Name = "ButtonAdv3"
            Me.ButtonAdv3.Size = New System.Drawing.Size(126, 23)
            Me.ButtonAdv3.TabIndex = 8
            Me.ButtonAdv3.Text = "PrintPreviewToFit"
            Me.ButtonAdv3.UseVisualStyle = True
            Me.ButtonAdv3.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
            Me.BackColor = System.Drawing.Color.White
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
			Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1043, 432)
            Me.Controls.Add(Me.panel1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Print To Fit Demo"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        <STAThread()> _
        Public Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
            Application.EnableVisualStyles()
#End If
            Application.Run(New Form1())
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            PopulateGridWithInts(30, 10)
            Me.gridControl1.DefaultRowHeight = 18
            Me.gridControl1.DefaultColWidth = 70
            Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.Silver
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


        Private Sub PopulateGridWithInts(ByVal rowCount As Integer, ByVal colCount As Integer)

            Me.gridControl1.ResetVolatileData()
            Me.gridControl1.ViewLayout.Reset()
            Me.gridControl1.RowCount = rowCount
            Me.gridControl1.ColCount = colCount
            Me.gridControl1.BeginUpdate()
            Dim r As Random
            r = New Random()
            Dim i As Integer
            i = 1

            Do While (i <= Me.gridControl1.RowCount)
                Dim j As Integer
                j = 1

                Do While (j <= Me.gridControl1.ColCount)
                    Me.gridControl1(i, j).CellValue = r.Next(1000)
                    j = (j + 1)

                Loop
                i = (i + 1)

            Loop
            Me.gridControl1.EndUpdate()
            Me.gridControl1.Refresh()
            Me.gridControl1.UpdateScrollBars()

        End Sub
        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)

            'draw a fullsize bitmap of the grid...
            Dim gridHeight As Integer
            gridHeight = Me.gridControl1.RowHeights.GetTotal(0, Me.gridControl1.RowCount)
            Dim gridWidth As Integer
            gridWidth = Me.gridControl1.ColWidths.GetTotal(0, Me.gridControl1.ColCount)
            Dim gridBM As Bitmap
            gridBM = New Bitmap(gridWidth, gridHeight)
            Dim g As Graphics
            g = Graphics.FromImage(gridBM)
            Me.gridControl1.GridBounds = New Rectangle(0, 0, gridWidth, gridHeight)
            Me.gridControl1.DrawGrid(g)
            Me.gridControl1.ResetGridBounds()
            g.Dispose()
            'create a bitmap the the proper target size
            Dim picBM As Bitmap
            picBM = New Bitmap(Me.pictureBox1.Size.Width, Me.pictureBox1.Size.Height)
            'draw grid bitmap into the new bitmap...
            Dim gu As System.Drawing.GraphicsUnit
            gu = System.Drawing.GraphicsUnit.Point
            g = Graphics.FromImage(picBM)
            Dim srcRect As RectangleF
            srcRect = gridBM.GetBounds(gu)
            Dim destRect As Rectangle
            destRect = New Rectangle(0, 0, picBM.Width, picBM.Height)

            Dim dest As RectangleF = New RectangleF(destRect.X, destRect.Y, destRect.Width, destRect.Height)
            g.DrawImage(gridBM, dest, srcRect, gu)

            g.Dispose()
            'show the new bitmap
            Me.pictureBox1.Image = picBM

        End Sub
        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)

            If (Not (Me.gridControl1) Is Nothing) Then
                Try
                    'uses the default printer
                    Dim pd As GridPrintToFitDocument
                    pd = New GridPrintToFitDocument(Me.gridControl1, True)
                    Dim dlg As PrintPreviewDialog
                    dlg = New PrintPreviewDialog()
                    dlg.Document = pd
                    dlg.ShowDialog()
                Catch ex As Exception
                    MessageBox.Show(("An error occurred attempting to preview the grid - " + ex.Message))
                End Try
            End If

        End Sub
        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs)

            If (Not (Me.gridControl1) Is Nothing) Then
                Try
                    Dim pd As GridPrintToFitDocument
                    pd = New GridPrintToFitDocument(Me.gridControl1, True)
                    Dim dlg As PrintDialog
                    dlg = New PrintDialog()
                    dlg.Document = pd
                    If (dlg.ShowDialog = System.Windows.Forms.DialogResult.OK) Then
                        pd.Print()
                    End If
                Catch ex As Exception
                    MessageBox.Show(("An error occurred attempting to print the grid - " + ex.Message))
                End Try
            End If

        End Sub
        Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs)

            PopulateGridWithInts(CType(Me.numericUpDown1.Value, Integer), CType(Me.numericUpDown2.Value, Integer))

        End Sub


        Private Sub ButtonAdv1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdv1.Click

            PopulateGridWithInts(CType(Me.numericUpDown1.Value, Integer), CType(Me.numericUpDown2.Value, Integer))

        End Sub

        Private Sub ButtonAdv2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdv2.Click

            'draw a fullsize bitmap of the grid...
            Dim gridHeight As Integer
            gridHeight = Me.gridControl1.RowHeights.GetTotal(0, Me.gridControl1.RowCount)
            Dim gridWidth As Integer
            gridWidth = Me.gridControl1.ColWidths.GetTotal(0, Me.gridControl1.ColCount)
            Dim gridBM As Bitmap
            gridBM = New Bitmap(gridWidth, gridHeight)
            Dim g As Graphics
            g = Graphics.FromImage(gridBM)
            Me.gridControl1.GridBounds = New Rectangle(0, 0, gridWidth, gridHeight)
            Me.gridControl1.DrawGrid(g)
            Me.gridControl1.ResetGridBounds()
            g.Dispose()
            'create a bitmap the the proper target size
            Dim picBM As Bitmap
            picBM = New Bitmap(Me.pictureBox1.Size.Width, Me.pictureBox1.Size.Height)
            'draw grid bitmap into the new bitmap...
            Dim gu As System.Drawing.GraphicsUnit
            gu = System.Drawing.GraphicsUnit.Point
            g = Graphics.FromImage(picBM)
            Dim srcRect As RectangleF
            srcRect = gridBM.GetBounds(gu)
            Dim destRect As Rectangle
            destRect = New Rectangle(0, 0, picBM.Width, picBM.Height)

            Dim dest As RectangleF = New RectangleF(destRect.X, destRect.Y, destRect.Width, destRect.Height)
            g.DrawImage(gridBM, dest, srcRect, gu)

            g.Dispose()
            'show the new bitmap
            Me.pictureBox1.Image = picBM
        End Sub

        Private Sub ButtonAdv3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdv3.Click

            If (Not (Me.gridControl1) Is Nothing) Then
                Try
                    'uses the default printer
                    Dim pd As GridPrintToFitDocument
                    pd = New GridPrintToFitDocument(Me.gridControl1, True)
                    Dim dlg As PrintPreviewDialog
                    dlg = New PrintPreviewDialog()
                    dlg.Document = pd
                    dlg.ShowDialog()
                Catch ex As Exception
                    MessageBox.Show(("An error occurred attempting to preview the grid - " + ex.Message))
                End Try
            End If

        End Sub

        Private Sub ButtonAdv4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdv4.Click

            If (Not (Me.gridControl1) Is Nothing) Then
                Try
                    Dim pd As GridPrintToFitDocument
                    pd = New GridPrintToFitDocument(Me.gridControl1, True)
                    Dim dlg As PrintDialog
                    dlg = New PrintDialog()
                    dlg.Document = pd
                    If (dlg.ShowDialog = System.Windows.Forms.DialogResult.OK) Then
                        pd.Print()
                    End If
                Catch ex As Exception
                    MessageBox.Show(("An error occurred attempting to print the grid - " + ex.Message))
                End Try
            End If
        End Sub

        Private Sub pictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureBox1.Click

        End Sub
    End Class
End Namespace
