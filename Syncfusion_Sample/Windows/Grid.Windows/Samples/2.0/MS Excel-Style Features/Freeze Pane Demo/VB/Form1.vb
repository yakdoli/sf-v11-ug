Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms
Namespace ExcelLikeFreezePanes
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
    Public Class Form1 : Inherits MetroForm
        Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
        Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents button4 As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents button2 As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents button3 As Syncfusion.Windows.Forms.ButtonAdv
        Private components As System.ComponentModel.IContainer
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>

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
            Me.gridControl1.HorizontalThumbTrack = True
            Me.gridControl1.VerticalThumbTrack = True
            Me.gridControl1.HScrollPixel = True

            Me.gridControl1.ColCount = 100
            Me.gridControl1.RowCount = 1000

            Me.gridControl1.LeftColIndex = 2
            Me.gridControl1.TopRowIndex = 30

            Me.gridControl1.ExcelLikeCurrentCell = True
            Me.gridControl1.ExcelLikeSelectionFrame = True

            AddHandler gridControl1.PrepareViewStyleInfo, AddressOf gridControl1_PrepareViewStyleInfo

            Me.gridControl1.CurrentCell.MoveTo(35, 5)

            Dim rnd As Random = New Random()

            Dim c As Integer = 1
            Do While c <= Me.gridControl1.ColCount
                Dim r As Integer = 1
                Do While r <= Me.gridControl1.RowCount
                    Dim v As Integer = rnd.Next(100)
                    If v > 80 Then
                        Dim style As GridStyleInfo = New GridStyleInfo
                        style.CellValue = v
                        style.BackColor = Me.colors(v Mod colors.Length)

                        Me.gridControl1.SetCellInfo(r, c, style, Syncfusion.Styles.StyleModifyType.Copy, False, True)
                    End If
                    r += 1
                Loop
                c += 1
            Loop
            Me.gridControl1.GridVisualStyles = GridVisualStyles.Metro
            Me.gridControl1.ThemesEnabled = True
            Me.gridControl1.BorderStyle=BorderStyle.FixedSingle
			Me.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid
            Dim styl As GridStyleInfo = gridControl1.BaseStylesMap("Header").StyleInfo
            styl.Font.Facename = "Segoe UI"
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


        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                RemoveHandler gridControl1.PrepareViewStyleInfo, AddressOf gridControl1_PrepareViewStyleInfo

                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.button4 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.button2 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.button3 = New Syncfusion.Windows.Forms.ButtonAdv
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridControl1.Location = New System.Drawing.Point(12, 3)
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RowCount = 200
            Me.gridControl1.Size = New System.Drawing.Size(633, 366)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.Text = "gridControl1"
            '
            'button1
            '
            Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.ForeColor = System.Drawing.Color.White
            Me.button1.Location = New System.Drawing.Point(21, 36)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(148, 32)
            Me.button1.TabIndex = 1
            Me.button1.Text = "&Freeze Current Row/Col"
            Me.button1.UseVisualStyle = True
            Me.button1.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.button4)
            Me.GroupBox1.Controls.Add(Me.button1)
            Me.GroupBox1.Controls.Add(Me.button2)
            Me.GroupBox1.Controls.Add(Me.button3)
            Me.GroupBox1.Location = New System.Drawing.Point(657, 68)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(200, 228)
            Me.GroupBox1.TabIndex = 2
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Freeze Options"
            '
            'button4
            '
            Me.button4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.button4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button4.ForeColor = System.Drawing.Color.White
            Me.button4.Location = New System.Drawing.Point(21, 175)
            Me.button4.Name = "button4"
            Me.button4.Size = New System.Drawing.Size(148, 28)
            Me.button4.TabIndex = 7
            Me.button4.Text = "Reset All"
            Me.button4.UseVisualStyle = True
            Me.button4.UseVisualStyleBackColor = True
            '
            'button2
            '
            Me.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button2.ForeColor = System.Drawing.Color.White
            Me.button2.Location = New System.Drawing.Point(21, 83)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(148, 28)
            Me.button2.TabIndex = 5
            Me.button2.Text = "Freeze Row, Column"
            Me.button2.UseVisualStyle = True
            Me.button2.UseVisualStyleBackColor = True
            '
            'button3
            '
            Me.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.button3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button3.ForeColor = System.Drawing.Color.White
            Me.button3.Location = New System.Drawing.Point(21, 129)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(148, 28)
            Me.button3.TabIndex = 6
            Me.button3.Text = "Freeze Range"
            Me.button3.UseVisualStyle = True
            Me.button3.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
            Me.BackColor = System.Drawing.Color.White
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(869, 395)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.gridControl1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Freeze Pane Demo"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
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

        Private frozen As Boolean = False
        Private frozenTopRow As Integer = 0
        Private frozenLeftCol As Integer = 0

        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            frozen = Not frozen

            If frozen Then
                Dim row, col As Integer
                row = Me.gridControl1.CurrentCell.RowIndex
                col = Me.gridControl1.CurrentCell.ColIndex

                'Retrive the TopRowIndex & LeftColIndex of the current view
                frozenTopRow = Me.gridControl1.TopRowIndex
                frozenLeftCol = Me.gridControl1.LeftColIndex

                'Hide those rows and columns(except headers) which precede Top Row and Left Column
                Me.gridControl1.RowHeights.SetRange(Me.gridControl1.Rows.HeaderCount + 1, frozenTopRow - 1, 0)
                Me.gridControl1.ColWidths.SetRange(Me.gridControl1.Cols.HeaderCount + 1, frozenLeftCol - 1, 0)

                'Freeze the rows and columns with respect to current cell
                Me.gridControl1.Model.Rows.FrozenCount = row
                Me.gridControl1.Model.Cols.FrozenCount = col

                Me.gridControl1.Focus()

                Me.button1.Text = Me.button1.Text.Replace("Freeze", "Unfreeze")
            Else
                'Release the frozen & Hidden Rows and Columns
                Me.gridControl1.BeginUpdate()

                Me.gridControl1.Model.Rows.FrozenCount = Me.gridControl1.Rows.HeaderCount
                Me.gridControl1.Model.Cols.FrozenCount = Me.gridControl1.Cols.HeaderCount

                Me.gridControl1.RowHeights.ResetRange(Me.gridControl1.Rows.HeaderCount + 1, frozenTopRow - 1)
                Me.gridControl1.ColWidths.ResetRange(Me.gridControl1.Cols.HeaderCount + 1, frozenLeftCol - 1)

                Me.gridControl1.InternalSetTopRow(frozenTopRow)
                Me.gridControl1.InternalSetLeftCol(frozenLeftCol)

                Me.gridControl1.EndUpdate(False)
                Me.gridControl1.Refresh()
                Me.gridControl1.Focus()
                Me.button1.Text = Me.button1.Text.Replace("Unfreeze", "Freeze")

            End If
        End Sub

        Private colors As Color() = New Color() {Color.FromArgb(&H85, &HBF, &H75), Color.FromArgb(&HB4, &HE7, &HF2), Color.FromArgb(&HFF, &HBF, &H34), Color.FromArgb(&H82, &H2E, &H1B), Color.FromArgb(&H3A, &H86, &H7E)}

        Private Sub gridControl1_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As GridPrepareViewStyleInfoEventArgs)
            If e.RowIndex > 0 AndAlso e.ColIndex > 0 Then
                Dim c As Color = Color.FromArgb(192, 201, 219)

                If e.RowIndex = Me.gridControl1.Rows.FrozenCount Then
                    e.Style.Borders.Bottom = New GridBorder(GridBorderStyle.Solid, c, GridBorderWeight.Medium)
                End If

                If e.ColIndex = Me.gridControl1.Cols.FrozenCount Then
                    e.Style.Borders.Right = New GridBorder(GridBorderStyle.Solid, c, GridBorderWeight.Medium)
                End If
            End If
        End Sub

        Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
            Me.gridControl1.BeginUpdate()
            If Me.gridControl1.Selections.Count = 0 Then
                MessageBox.Show("Select rows/columns to freeze")
            Else
                'Freezes the selected columns (Moves them to the start of the grid and sets FrozenCount)
                Me.gridControl1.Cols.FreezeSelection()

                'Freezes the selected columns (Moves them to the start of the grid and sets FrozenCount)
                Me.gridControl1.Rows.FreezeSelection()
            End If
            Me.gridControl1.EndUpdate()
        End Sub

        Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
            Me.gridControl1.BeginUpdate()
            'Freeze the specified range of rows
            Me.gridControl1.Rows.FreezeRange(2, 5)
            Me.gridControl1.EndUpdate()
        End Sub

        Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
            'Reset the grid
            Me.gridControl1.BeginUpdate()
            Me.gridControl1.ColCount = 100
            Me.gridControl1.RowCount = 1000

            Me.gridControl1.Rows.FrozenCount = 0
            Me.gridControl1.Cols.FrozenCount = 0

            Me.gridControl1.Rows.HeaderCount = 0
            Me.gridControl1.Cols.HeaderCount = 0
            Me.gridControl1.EndUpdate()
        End Sub
    End Class
End Namespace
