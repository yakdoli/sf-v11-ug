Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Calculate
Imports Syncfusion.XlsIO

Namespace XLFormulaCalc
	''' <summary>
	''' Summary description for SingleDataGrid.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private WithEvents dataGrid1 As System.Windows.Forms.DataGrid
		Private label3 As Label
		Private WithEvents button1 As Button
		Private WithEvents button2 As Button
		Private label4 As Label
		Private tabBarSplitterControl1 As Syncfusion.Windows.Forms.TabBarSplitterControl
		Private tabBarPage1 As Syncfusion.Windows.Forms.TabBarPage
		Private tabBarPage2 As Syncfusion.Windows.Forms.TabBarPage
        Private WithEvents dataGrid2 As System.Windows.Forms.DataGrid

        Dim eng As ExcelEngine
        Dim workBook As IWorkbook
        Dim calcEngine As CalcEngine
        Private WithEvents panel1 As System.Windows.Forms.Panel
        Private WithEvents pictureBox7 As System.Windows.Forms.PictureBox
        Private WithEvents pictureBox6 As System.Windows.Forms.PictureBox
        Private WithEvents pictureBox5 As System.Windows.Forms.PictureBox
        Private WithEvents pictureBox4 As System.Windows.Forms.PictureBox
        Private WithEvents pictureBox3 As System.Windows.Forms.PictureBox

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support.
			'
			InitializeComponent()
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MinimizeBox = False
            Me.MaximizeBox = False
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.dataGrid1.FlatMode = True
            AddHandler dataGrid1.Paint, AddressOf dataGrid1_Paint
            AddHandler dataGrid2.Paint, AddressOf dataGrid2_Paint
        End Sub

        Private Sub dataGrid2_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
            If Not dataGrid2.DataSource Is Nothing Then
                For i As Integer = 1 To 15
                    Dim rect As Rectangle = dataGrid2.GetCellBounds(i - 1, 0)
                    If i > 9 Then
                        rect.X = rect.X - 28
                    Else
                        rect.X = rect.X - 24
                    End If

                    e.Graphics.DrawString(i.ToString(), New Font("Verdana", 9.0F, FontStyle.Regular), Brushes.Black, rect)
                Next i
            End If
        End Sub

        Private Sub dataGrid1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
            If Not dataGrid1.DataSource Is Nothing Then
                For i As Integer = 1 To 15
                    Dim rect As Rectangle = dataGrid1.GetCellBounds(i - 1, 0)
                    If i > 9 Then
                        rect.X = rect.X - 28
                    Else
                        rect.X = rect.X - 24
                    End If

                    e.Graphics.DrawString(i.ToString(), New Font("Verdana", 9.0F, FontStyle.Regular), Brushes.Black, rect)
                Next i
            End If
        End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
            End If
           
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support; do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.label1 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.button1 = New System.Windows.Forms.Button
            Me.button2 = New System.Windows.Forms.Button
            Me.label4 = New System.Windows.Forms.Label
            Me.tabBarSplitterControl1 = New Syncfusion.Windows.Forms.TabBarSplitterControl
            Me.tabBarPage1 = New Syncfusion.Windows.Forms.TabBarPage
            Me.dataGrid1 = New System.Windows.Forms.DataGrid
            Me.tabBarPage2 = New Syncfusion.Windows.Forms.TabBarPage
            Me.dataGrid2 = New System.Windows.Forms.DataGrid
            Me.panel1 = New System.Windows.Forms.Panel
            Me.pictureBox7 = New System.Windows.Forms.PictureBox
            Me.pictureBox6 = New System.Windows.Forms.PictureBox
            Me.pictureBox5 = New System.Windows.Forms.PictureBox
            Me.pictureBox4 = New System.Windows.Forms.PictureBox
            Me.pictureBox3 = New System.Windows.Forms.PictureBox
            Me.tabBarSplitterControl1.SuspendLayout()
            Me.tabBarPage1.SuspendLayout()
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabBarPage2.SuspendLayout()
            CType(Me.dataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'label1
            '
            Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.label1.BackColor = System.Drawing.Color.White
            Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.label1.Location = New System.Drawing.Point(150, 596)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(238, 26)
            Me.label1.TabIndex = 3
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(12, 106)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(368, 22)
            Me.label2.TabIndex = 6
            Me.label2.Text = "Click on any formula cell to get the calculated result."
            '
            'label3
            '
            Me.label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(30, 604)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(116, 13)
            Me.label3.TabIndex = 9
            Me.label3.Text = "Computed Value:"
            '
            'button1
            '
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.Location = New System.Drawing.Point(15, 131)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(152, 23)
            Me.button1.TabIndex = 10
            Me.button1.Text = "Import Data From Excel"
            Me.button1.UseVisualStyleBackColor = True
            '
            'button2
            '
            Me.button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button2.Location = New System.Drawing.Point(187, 131)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(201, 23)
            Me.button2.TabIndex = 11
            Me.button2.Text = "Open sample workbook in Excel"
            Me.button2.UseVisualStyleBackColor = True
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(15, 166)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(243, 13)
            Me.label4.TabIndex = 12
            Me.label4.Text = "View of Imported Excel Worksheets:"
            '
            'tabBarSplitterControl1
            '
            Me.tabBarSplitterControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tabBarSplitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tabBarSplitterControl1.Controls.Add(Me.tabBarPage1)
            Me.tabBarSplitterControl1.Controls.Add(Me.tabBarPage2)
            Me.tabBarSplitterControl1.EnabledColor = System.Drawing.SystemColors.WindowText
            Me.tabBarSplitterControl1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabBarSplitterControl1.Location = New System.Drawing.Point(18, 200)
            Me.tabBarSplitterControl1.Name = "tabBarSplitterControl1"
            Me.tabBarSplitterControl1.Office2007ScrollBars = True
            Me.tabBarSplitterControl1.RelativeWidth = 24
            Me.tabBarSplitterControl1.Size = New System.Drawing.Size(567, 386)
            Me.tabBarSplitterControl1.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.None
            Me.tabBarSplitterControl1.Style = Syncfusion.Windows.Forms.TabBarSplitterStyle.Office2007
            Me.tabBarSplitterControl1.TabFolderDelta = 11
            Me.tabBarSplitterControl1.TabIndex = 13
            Me.tabBarSplitterControl1.Text = "tabBarSplitterControl1"
            Me.tabBarSplitterControl1.ThemesEnabled = True
            '
            'tabBarPage1
            '
            Me.tabBarPage1.Controls.Add(Me.dataGrid1)
            Me.tabBarPage1.Location = New System.Drawing.Point(0, 0)
            Me.tabBarPage1.Name = "tabBarPage1"
            Me.tabBarPage1.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.None
            Me.tabBarPage1.TabBackColor = System.Drawing.SystemColors.Control
            Me.tabBarPage1.Text = "Sheet1"
            Me.tabBarPage1.ThemesEnabled = True
            '
            'dataGrid1
            '
            Me.dataGrid1.AllowSorting = False
            Me.dataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dataGrid1.CaptionBackColor = System.Drawing.Color.SteelBlue
            Me.dataGrid1.DataMember = ""
            Me.dataGrid1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dataGrid1.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(229, Byte), Integer))
            Me.dataGrid1.HeaderBackColor = System.Drawing.Color.LightSteelBlue
            Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dataGrid1.Location = New System.Drawing.Point(0, 0)
            Me.dataGrid1.Name = "dataGrid1"
            Me.dataGrid1.ParentRowsBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.dataGrid1.PreferredRowHeight = 20
            Me.dataGrid1.ReadOnly = True
            Me.dataGrid1.SelectionBackColor = System.Drawing.Color.White
            Me.dataGrid1.SelectionForeColor = System.Drawing.Color.White
            Me.dataGrid1.Size = New System.Drawing.Size(14684, 8120)
            Me.dataGrid1.TabIndex = 8
            '
            'tabBarPage2
            '
            Me.tabBarPage2.Controls.Add(Me.dataGrid2)
            Me.tabBarPage2.Location = New System.Drawing.Point(0, 0)
            Me.tabBarPage2.Name = "tabBarPage2"
            Me.tabBarPage2.SplitBars = CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars)
            Me.tabBarPage2.TabBackColor = System.Drawing.SystemColors.Control
            Me.tabBarPage2.Text = "Sheet2"
            Me.tabBarPage2.ThemesEnabled = True
            '
            'dataGrid2
            '
            Me.dataGrid2.AllowSorting = False
            Me.dataGrid2.CaptionBackColor = System.Drawing.Color.SteelBlue
            Me.dataGrid2.DataMember = ""
            Me.dataGrid2.FlatMode = True
            Me.dataGrid2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dataGrid2.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(229, Byte), Integer))
            Me.dataGrid2.HeaderBackColor = System.Drawing.Color.LightSteelBlue
            Me.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dataGrid2.Location = New System.Drawing.Point(0, 0)
            Me.dataGrid2.Name = "dataGrid2"
            Me.dataGrid2.ParentRowsBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.dataGrid2.PreferredRowHeight = 20
            Me.dataGrid2.ReadOnly = True
            Me.dataGrid2.Size = New System.Drawing.Size(575, 338)
            Me.dataGrid2.TabIndex = 4
            '
            'panel1
            '
            Me.panel1.BackgroundImage = CType(resources.GetObject("panel1.BackgroundImage"), System.Drawing.Image)
            Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.panel1.Location = New System.Drawing.Point(230, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(382, 71)
            Me.panel1.TabIndex = 22
            '
            'pictureBox7
            '
            Me.pictureBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pictureBox7.BackColor = System.Drawing.Color.Transparent
            Me.pictureBox7.BackgroundImage = CType(resources.GetObject("pictureBox7.BackgroundImage"), System.Drawing.Image)
            Me.pictureBox7.Location = New System.Drawing.Point(185, 0)
            Me.pictureBox7.Name = "pictureBox7"
            Me.pictureBox7.Size = New System.Drawing.Size(329, 71)
            Me.pictureBox7.TabIndex = 27
            Me.pictureBox7.TabStop = False
            '
            'pictureBox6
            '
            Me.pictureBox6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pictureBox6.BackColor = System.Drawing.Color.Transparent
            Me.pictureBox6.BackgroundImage = CType(resources.GetObject("pictureBox6.BackgroundImage"), System.Drawing.Image)
            Me.pictureBox6.Location = New System.Drawing.Point(139, 0)
            Me.pictureBox6.Name = "pictureBox6"
            Me.pictureBox6.Size = New System.Drawing.Size(329, 71)
            Me.pictureBox6.TabIndex = 26
            Me.pictureBox6.TabStop = False
            '
            'pictureBox5
            '
            Me.pictureBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pictureBox5.BackColor = System.Drawing.Color.Transparent
            Me.pictureBox5.BackgroundImage = CType(resources.GetObject("pictureBox5.BackgroundImage"), System.Drawing.Image)
            Me.pictureBox5.Location = New System.Drawing.Point(93, 0)
            Me.pictureBox5.Name = "pictureBox5"
            Me.pictureBox5.Size = New System.Drawing.Size(329, 71)
            Me.pictureBox5.TabIndex = 25
            Me.pictureBox5.TabStop = False
            '
            'pictureBox4
            '
            Me.pictureBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pictureBox4.BackColor = System.Drawing.Color.Transparent
            Me.pictureBox4.BackgroundImage = CType(resources.GetObject("pictureBox4.BackgroundImage"), System.Drawing.Image)
            Me.pictureBox4.Location = New System.Drawing.Point(48, 0)
            Me.pictureBox4.Name = "pictureBox4"
            Me.pictureBox4.Size = New System.Drawing.Size(329, 71)
            Me.pictureBox4.TabIndex = 24
            Me.pictureBox4.TabStop = False
            '
            'pictureBox3
            '
            Me.pictureBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pictureBox3.BackColor = System.Drawing.Color.Transparent
            Me.pictureBox3.BackgroundImage = CType(resources.GetObject("pictureBox3.BackgroundImage"), System.Drawing.Image)
            Me.pictureBox3.Location = New System.Drawing.Point(-2, 0)
            Me.pictureBox3.Name = "pictureBox3"
            Me.pictureBox3.Size = New System.Drawing.Size(329, 71)
            Me.pictureBox3.TabIndex = 23
            Me.pictureBox3.TabStop = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(603, 631)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.pictureBox7)
            Me.Controls.Add(Me.pictureBox6)
            Me.Controls.Add(Me.pictureBox5)
            Me.Controls.Add(Me.pictureBox4)
            Me.Controls.Add(Me.pictureBox3)
            Me.Controls.Add(Me.tabBarSplitterControl1)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.Text = "Compute Specific Formula"
            Me.tabBarSplitterControl1.ResumeLayout(False)
            Me.tabBarPage1.ResumeLayout(False)
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabBarPage2.ResumeLayout(False)
            CType(Me.dataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub


		Private Sub dataGrid1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dataGrid1.MouseUp
			Dim pt As Point = New Point(e.X, e.Y)
			Dim hitInfo As DataGrid.HitTestInfo = Me.dataGrid1.HitTest(pt)
			If hitInfo.Type = DataGrid.HitTestType.Cell Then
				If Me.dataGrid1(hitInfo.Row, hitInfo.Column).ToString().StartsWith("=") Then
                    Me.label1.Text = calcEngine.ParseAndComputeFormula(Me.dataGrid1(hitInfo.Row, hitInfo.Column).ToString())
				Else
					Me.label1.Text = "Not a Formula Cell"
				End If
			End If
		End Sub


		Private Sub dataGrid2_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dataGrid2.MouseUp
			Dim pt As Point = New Point(e.X, e.Y)
			Dim hitInfo As DataGrid.HitTestInfo = Me.dataGrid2.HitTest(pt)
			If hitInfo.Type = DataGrid.HitTestType.Cell Then
				If Me.dataGrid2(hitInfo.Row, hitInfo.Column).ToString().StartsWith("=") Then
                    Me.label1.Text = calcEngine.ParseAndComputeFormula(Me.dataGrid2(hitInfo.Row, hitInfo.Column).ToString())
				Else
					Me.label1.Text = "Not a Formula Cell"
				End If
			End If
		End Sub



		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            eng = New ExcelEngine()
            workBook = eng.Excel.Workbooks.Open("..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\Input.xls")
			Dim sheet As IWorksheet = workBook.Worksheets(0)
			Dim sheet2 As IWorksheet = workBook.Worksheets(1)

            'Enable to calculate formulas in the sheet.
            sheet.EnableSheetCalculations()

            'Assign the sheet calcEngine.
            calcEngine = sheet.CalcEngine

			'Load the datagrids with the data from Xls file.
			Dim dt As DataTable = New DataTable("Input Data")
			dt = sheet.ExportDataTable(1, 1, 15, 5, ExcelExportDataTableOptions.None)
			Me.dataGrid1.DataSource = dt

			Dim dt2 As DataTable = New DataTable("Sheet2 Data")
			dt2 = sheet2.ExportDataTable(1, 1, 15, 8, ExcelExportDataTableOptions.None)
			Me.dataGrid2.DataSource = dt2

			Me.button1.Enabled = False

			Dim tabStyle As DataGridTableStyle = New DataGridTableStyle()
			tabStyle.MappingName = dt.TableName
			Me.dataGrid1.TableStyles.Add(tabStyle)

			Dim tabStyle2 As DataGridTableStyle = New DataGridTableStyle()
			tabStyle2.MappingName = dt2.TableName
			Me.dataGrid2.TableStyles.Add(tabStyle2)

			For i As Integer = 0 To 4
                Select Case i
                    Case 3
                        tabStyle.GridColumnStyles(i).Width = 180
                    Case 4
                        tabStyle.GridColumnStyles(i).Width = 210
                    Case Else
                        tabStyle.GridColumnStyles(i).Width = 60
                End Select
                tabStyle.GridColumnStyles(i).HeaderText = String.Format("{0}", CChar(ChrW(CInt(AscW("A"c)) + i)))
				tabStyle.GridColumnStyles(i).Alignment = HorizontalAlignment.Left
			Next i

			For j As Integer = 0 To 7
				tabStyle2.GridColumnStyles(j).Width = 70
                tabStyle2.GridColumnStyles(j).HeaderText = String.Format("{0}", CChar(ChrW(CInt(AscW("A"c)) + j)))
                tabStyle2.GridColumnStyles(j).Alignment = HorizontalAlignment.Left
			Next j

			tabStyle.HeaderBackColor = Color.LightSteelBlue
			tabStyle2.HeaderBackColor = Color.LightSteelBlue
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start("..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\Input.xls")
		End Sub

        Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            If Not eng Is Nothing Then
                workBook.Close()
                eng.Dispose()
            End If

        End Sub
    End Class
End Namespace
