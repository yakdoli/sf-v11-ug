Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Namespace GridFindReplace
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim gridRangeStyle1 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle2 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle3 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle4 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle5 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle6 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle7 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle8 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle9 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle10 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle11 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.cmbReplace = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.cmbSearch = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.cmbOptions = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.btnFindAll = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.chkSearchUp = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.chkMatchWholeCell = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.chkMatchCase = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.btnReplaceAll = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.btnReplace = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.lblReplaceWith = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.btnFindNext = New Syncfusion.Windows.Forms.ButtonAdv()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			Me.groupBox1.SuspendLayout()
			CType(Me.cmbReplace, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbSearch, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbOptions, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkSearchUp, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkMatchWholeCell, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkMatchCase, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
			Me.gridControl1.DefaultRowHeight = 20
			Me.gridControl1.Font = New System.Drawing.Font("Verdana", 8.25F)
			Me.gridControl1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridControl1.Location = New System.Drawing.Point(12, 5)
			Me.gridControl1.MetroScrollBars = True
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Properties.BackgroundColor = System.Drawing.SystemColors.Window
			Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(255))))))
			Me.gridControl1.Properties.MarkColHeader = False
			Me.gridControl1.Properties.MarkRowHeader = False
			gridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle1.StyleInfo.Font.Bold = False
			gridRangeStyle1.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle1.StyleInfo.Font.Italic = False
			gridRangeStyle1.StyleInfo.Font.Size = 8.25F
			gridRangeStyle1.StyleInfo.Font.Strikeout = False
			gridRangeStyle1.StyleInfo.Font.Underline = False
			gridRangeStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridRangeStyle1.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			gridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle2.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle2.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle2.StyleInfo.Font.Bold = False
			gridRangeStyle2.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle2.StyleInfo.Font.Italic = False
			gridRangeStyle2.StyleInfo.Font.Size = 8.25F
			gridRangeStyle2.StyleInfo.Font.Strikeout = False
			gridRangeStyle2.StyleInfo.Font.Underline = False
			gridRangeStyle2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle2.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridRangeStyle2.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			gridRangeStyle3.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle3.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle3.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle3.StyleInfo.Font.Bold = False
			gridRangeStyle3.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle3.StyleInfo.Font.Italic = False
			gridRangeStyle3.StyleInfo.Font.Size = 8.25F
			gridRangeStyle3.StyleInfo.Font.Strikeout = False
			gridRangeStyle3.StyleInfo.Font.Underline = False
			gridRangeStyle3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridRangeStyle3.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			gridRangeStyle4.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle4.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle4.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle4.StyleInfo.Font.Bold = False
			gridRangeStyle4.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle4.StyleInfo.Font.Italic = False
			gridRangeStyle4.StyleInfo.Font.Size = 8.25F
			gridRangeStyle4.StyleInfo.Font.Strikeout = False
			gridRangeStyle4.StyleInfo.Font.Underline = False
			gridRangeStyle4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle4.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridRangeStyle4.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			gridRangeStyle5.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle5.StyleInfo.Font.Bold = False
			gridRangeStyle5.StyleInfo.Font.Facename = "Verdana"
			gridRangeStyle5.StyleInfo.Font.Italic = False
			gridRangeStyle5.StyleInfo.Font.Size = 8.25F
			gridRangeStyle5.StyleInfo.Font.Strikeout = False
			gridRangeStyle5.StyleInfo.Font.Underline = False
			gridRangeStyle5.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle6.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle6.StyleInfo.Font.Bold = False
			gridRangeStyle6.StyleInfo.Font.Facename = "Verdana"
			gridRangeStyle6.StyleInfo.Font.Italic = False
			gridRangeStyle6.StyleInfo.Font.Size = 8.25F
			gridRangeStyle6.StyleInfo.Font.Strikeout = False
			gridRangeStyle6.StyleInfo.Font.Underline = False
			gridRangeStyle6.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle7.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle7.StyleInfo.Font.Bold = False
			gridRangeStyle7.StyleInfo.Font.Facename = "Verdana"
			gridRangeStyle7.StyleInfo.Font.Italic = False
			gridRangeStyle7.StyleInfo.Font.Size = 8.25F
			gridRangeStyle7.StyleInfo.Font.Strikeout = False
			gridRangeStyle7.StyleInfo.Font.Underline = False
			gridRangeStyle7.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle8.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle8.StyleInfo.Font.Bold = False
			gridRangeStyle8.StyleInfo.Font.Facename = "Verdana"
			gridRangeStyle8.StyleInfo.Font.Italic = False
			gridRangeStyle8.StyleInfo.Font.Size = 8.25F
			gridRangeStyle8.StyleInfo.Font.Strikeout = False
			gridRangeStyle8.StyleInfo.Font.Underline = False
			gridRangeStyle8.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle9.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle9.StyleInfo.Font.Bold = False
			gridRangeStyle9.StyleInfo.Font.Facename = "Verdana"
			gridRangeStyle9.StyleInfo.Font.Italic = False
			gridRangeStyle9.StyleInfo.Font.Size = 8.25F
			gridRangeStyle9.StyleInfo.Font.Strikeout = False
			gridRangeStyle9.StyleInfo.Font.Underline = False
			gridRangeStyle9.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle10.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle10.StyleInfo.Font.Bold = False
			gridRangeStyle10.StyleInfo.Font.Facename = "Verdana"
			gridRangeStyle10.StyleInfo.Font.Italic = False
			gridRangeStyle10.StyleInfo.Font.Size = 8.25F
			gridRangeStyle10.StyleInfo.Font.Strikeout = False
			gridRangeStyle10.StyleInfo.Font.Underline = False
			gridRangeStyle10.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle11.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle11.StyleInfo.Font.Bold = False
			gridRangeStyle11.StyleInfo.Font.Facename = "Verdana"
			gridRangeStyle11.StyleInfo.Font.Italic = False
			gridRangeStyle11.StyleInfo.Font.Size = 8.25F
			gridRangeStyle11.StyleInfo.Font.Strikeout = False
			gridRangeStyle11.StyleInfo.Font.Underline = False
			gridRangeStyle11.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			Me.gridControl1.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() { gridRangeStyle1, gridRangeStyle2, gridRangeStyle3, gridRangeStyle4, gridRangeStyle5, gridRangeStyle6, gridRangeStyle7, gridRangeStyle8, gridRangeStyle9, gridRangeStyle10, gridRangeStyle11})
			Me.gridControl1.RowCount = 25
			Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
			Me.gridControl1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.AlwaysVisible
			Me.gridControl1.Size = New System.Drawing.Size(675, 318)
			Me.gridControl1.SmartSizeBox = False
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.Text = "gridControl1"
			Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.BorderStyle=BorderStyle.FixedSingle
			Me.gridControl1.UseRightToLeftCompatibleTextBox = True
			' 
			' splitContainer1
			' 
			Me.splitContainer1.BackColor = System.Drawing.Color.White
			Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
			Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainer1.Name = "splitContainer1"
			Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
			' 
			' splitContainer1.Panel1
			' 
			Me.splitContainer1.Panel1.BackColor = System.Drawing.Color.White
			Me.splitContainer1.Panel1.Controls.Add(Me.groupBox1)
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.gridControl1)
			Me.splitContainer1.Size = New System.Drawing.Size(707, 471)
			Me.splitContainer1.SplitterDistance = 137
			Me.splitContainer1.TabIndex = 1
			' 
			' groupBox1
			' 
			Me.groupBox1.AutoSize = True
			Me.groupBox1.BackColor = System.Drawing.Color.White
			Me.groupBox1.Controls.Add(Me.cmbReplace)
			Me.groupBox1.Controls.Add(Me.cmbSearch)
			Me.groupBox1.Controls.Add(Me.cmbOptions)
			Me.groupBox1.Controls.Add(Me.btnFindAll)
			Me.groupBox1.Controls.Add(Me.chkSearchUp)
			Me.groupBox1.Controls.Add(Me.chkMatchWholeCell)
			Me.groupBox1.Controls.Add(Me.chkMatchCase)
			Me.groupBox1.Controls.Add(Me.btnReplaceAll)
			Me.groupBox1.Controls.Add(Me.btnReplace)
			Me.groupBox1.Controls.Add(Me.lblReplaceWith)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Controls.Add(Me.btnFindNext)
			Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.groupBox1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox1.Location = New System.Drawing.Point(11, 6)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(675, 129)
			Me.groupBox1.TabIndex = 0
			Me.groupBox1.TabStop = False
			' 
			' cmbReplace
			' 
			Me.cmbReplace.BackColor = System.Drawing.Color.White
			Me.cmbReplace.Location = New System.Drawing.Point(90, 47)
			Me.cmbReplace.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.cmbReplace.Name = "cmbReplace"
			Me.cmbReplace.Size = New System.Drawing.Size(229, 22)
			Me.cmbReplace.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
			Me.cmbReplace.TabIndex = 13
			' 
			' cmbSearch
			' 
			Me.cmbSearch.BackColor = System.Drawing.Color.White
			Me.cmbSearch.Location = New System.Drawing.Point(90, 19)
			Me.cmbSearch.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.cmbSearch.Name = "cmbSearch"
			Me.cmbSearch.Size = New System.Drawing.Size(229, 22)
			Me.cmbSearch.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
			Me.cmbSearch.TabIndex = 12
'			Me.cmbSearch.TextChanged+= New System.EventHandler(cmbSearch_TextChanged)
			' 
			' cmbOptions
			' 
			Me.cmbOptions.BackColor = System.Drawing.Color.White
			Me.cmbOptions.Items.AddRange(New Object() { "ColumnOnly", "SelectionOnly", "WholeTable"})
			Me.cmbOptions.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.cmbOptions, "ColumnOnly"))
			Me.cmbOptions.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.cmbOptions, "SelectionOnly"))
			Me.cmbOptions.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.cmbOptions, "WholeTable"))
			Me.cmbOptions.Location = New System.Drawing.Point(325, 88)
			Me.cmbOptions.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.cmbOptions.Name = "cmbOptions"
			Me.cmbOptions.Size = New System.Drawing.Size(121, 22)
			Me.cmbOptions.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
			Me.cmbOptions.TabIndex = 11
			' 
			' btnFindAll
			' 
			Me.btnFindAll.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.btnFindAll.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.btnFindAll.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.btnFindAll.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.btnFindAll.ForeColor = System.Drawing.Color.White
			Me.btnFindAll.Location = New System.Drawing.Point(459, 18)
			Me.btnFindAll.Name = "btnFindAll"
			Me.btnFindAll.Size = New System.Drawing.Size(109, 23)
			Me.btnFindAll.TabIndex = 10
			Me.btnFindAll.Text = "Find All"
			Me.btnFindAll.UseVisualStyle = True
			Me.btnFindAll.UseVisualStyleBackColor = True
'			Me.btnFindAll.Click += New System.EventHandler(Me.btnFindAll_Click)
			' 
			' chkSearchUp
			' 
			Me.chkSearchUp.DrawFocusRectangle = False
			Me.chkSearchUp.Location = New System.Drawing.Point(238, 90)
			Me.chkSearchUp.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.chkSearchUp.Name = "chkSearchUp"
			Me.chkSearchUp.Size = New System.Drawing.Size(87, 19)
			Me.chkSearchUp.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.chkSearchUp.TabIndex = 9
			Me.chkSearchUp.Text = "Search Up"
			Me.chkSearchUp.ThemesEnabled = False
			' 
			' chkMatchWholeCell
			' 
			Me.chkMatchWholeCell.DrawFocusRectangle = False
			Me.chkMatchWholeCell.Location = New System.Drawing.Point(105, 90)
			Me.chkMatchWholeCell.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.chkMatchWholeCell.Name = "chkMatchWholeCell"
			Me.chkMatchWholeCell.Size = New System.Drawing.Size(126, 19)
			Me.chkMatchWholeCell.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.chkMatchWholeCell.TabIndex = 8
			Me.chkMatchWholeCell.Text = "Match Whole Cell"
			Me.chkMatchWholeCell.ThemesEnabled = False
			' 
			' chkMatchCase
			' 
			Me.chkMatchCase.DrawFocusRectangle = False
			Me.chkMatchCase.Location = New System.Drawing.Point(9, 90)
			Me.chkMatchCase.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.chkMatchCase.Name = "chkMatchCase"
			Me.chkMatchCase.Size = New System.Drawing.Size(96, 19)
			Me.chkMatchCase.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.chkMatchCase.TabIndex = 7
			Me.chkMatchCase.Text = "Match Case"
			Me.chkMatchCase.ThemesEnabled = False
			' 
			' btnReplaceAll
			' 
			Me.btnReplaceAll.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.btnReplaceAll.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.btnReplaceAll.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.btnReplaceAll.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.btnReplaceAll.ForeColor = System.Drawing.Color.White
			Me.btnReplaceAll.Location = New System.Drawing.Point(462, 50)
			Me.btnReplaceAll.Name = "btnReplaceAll"
			Me.btnReplaceAll.Size = New System.Drawing.Size(106, 23)
			Me.btnReplaceAll.TabIndex = 6
			Me.btnReplaceAll.Text = "Replace All"
			Me.btnReplaceAll.UseVisualStyle = True
			Me.btnReplaceAll.UseVisualStyleBackColor = True
'			Me.btnReplaceAll.Click += New System.EventHandler(Me.btnReplaceAll_Click)
			' 
			' btnReplace
			' 
			Me.btnReplace.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.btnReplace.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.btnReplace.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.btnReplace.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.btnReplace.ForeColor = System.Drawing.Color.White
			Me.btnReplace.Location = New System.Drawing.Point(334, 50)
			Me.btnReplace.Name = "btnReplace"
			Me.btnReplace.Size = New System.Drawing.Size(106, 23)
			Me.btnReplace.TabIndex = 5
			Me.btnReplace.Text = "Replace"
			Me.btnReplace.UseVisualStyle = True
			Me.btnReplace.UseVisualStyleBackColor = True
'			Me.btnReplace.Click += New System.EventHandler(Me.btnReplace_Click)
			' 
			' lblReplaceWith
			' 
			Me.lblReplaceWith.AutoSize = True
			Me.lblReplaceWith.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.lblReplaceWith.Location = New System.Drawing.Point(6, 50)
			Me.lblReplaceWith.Name = "lblReplaceWith"
			Me.lblReplaceWith.Size = New System.Drawing.Size(77, 14)
			Me.lblReplaceWith.TabIndex = 3
			Me.lblReplaceWith.Text = "Replace With"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(6, 19)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(66, 14)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Search For"
			' 
			' btnFindNext
			' 
			Me.btnFindNext.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.btnFindNext.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.btnFindNext.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.btnFindNext.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.btnFindNext.ForeColor = System.Drawing.Color.White
			Me.btnFindNext.Location = New System.Drawing.Point(334, 18)
			Me.btnFindNext.Name = "btnFindNext"
			Me.btnFindNext.Size = New System.Drawing.Size(106, 23)
			Me.btnFindNext.TabIndex = 1
			Me.btnFindNext.Text = "Find Next"
			Me.btnFindNext.UseVisualStyle = True
			Me.btnFindNext.UseVisualStyleBackColor = True
'			Me.btnFindNext.Click += New System.EventHandler(Me.btnFindNext_Click)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.White
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(707, 471)
			Me.Controls.Add(Me.splitContainer1)
			Me.DropShadow = True
			Me.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Find-Replace Demo"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainer1.Panel1.ResumeLayout(False)
			Me.splitContainer1.Panel1.PerformLayout()
			Me.splitContainer1.Panel2.ResumeLayout(False)
			Me.splitContainer1.ResumeLayout(False)
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			CType(Me.cmbReplace, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbSearch, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbOptions, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkSearchUp, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkMatchWholeCell, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkMatchCase, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private splitContainer1 As System.Windows.Forms.SplitContainer
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private WithEvents btnFindNext As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents btnReplace As Syncfusion.Windows.Forms.ButtonAdv
		Private lblReplaceWith As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private WithEvents btnReplaceAll As Syncfusion.Windows.Forms.ButtonAdv
		Private chkSearchUp As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private chkMatchWholeCell As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private chkMatchCase As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private cmbOptions As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private WithEvents btnFindAll As Syncfusion.Windows.Forms.ButtonAdv
		Private cmbReplace As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private WithEvents cmbSearch As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
	End Class
End Namespace

