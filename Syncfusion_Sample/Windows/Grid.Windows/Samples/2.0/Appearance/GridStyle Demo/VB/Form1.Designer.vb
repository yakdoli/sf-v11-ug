Imports Microsoft.VisualBasic
Imports System
Namespace GridStyle_2005
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
			Dim gridRangeStyle21 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle22 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle23 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle24 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle25 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle26 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle27 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle28 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle29 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle30 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.gridControl2 = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.BaseStyleColor = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.BaseStyleCheck = New System.Windows.Forms.CheckBox()
			Me.Cell32Color = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.Cell32Check = New System.Windows.Forms.CheckBox()
			Me.Column2Color = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.Column2Check = New System.Windows.Forms.CheckBox()
			Me.Row3Color = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.Row3Check = New System.Windows.Forms.CheckBox()
			Me.TableColor = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.TableCheck = New System.Windows.Forms.CheckBox()
			Me.StandardColor = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.StandardCheck = New System.Windows.Forms.CheckBox()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.ColCount = 7
			Me.gridControl1.DefaultRowHeight = 20
			Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridControl1.Location = New System.Drawing.Point(10, 111)
			Me.gridControl1.MetroScrollBars = True
			Me.gridControl1.Name = "gridControl1"
			gridRangeStyle21.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle21.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle21.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle21.StyleInfo.Font.Bold = False
			gridRangeStyle21.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle21.StyleInfo.Font.Italic = False
			gridRangeStyle21.StyleInfo.Font.Size = 8.25F
			gridRangeStyle21.StyleInfo.Font.Strikeout = False
			gridRangeStyle21.StyleInfo.Font.Underline = False
			gridRangeStyle21.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle21.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridRangeStyle21.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			gridRangeStyle22.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle22.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle22.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle22.StyleInfo.Font.Bold = False
			gridRangeStyle22.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle22.StyleInfo.Font.Italic = False
			gridRangeStyle22.StyleInfo.Font.Size = 8.25F
			gridRangeStyle22.StyleInfo.Font.Strikeout = False
			gridRangeStyle22.StyleInfo.Font.Underline = False
			gridRangeStyle22.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle22.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridRangeStyle22.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			gridRangeStyle23.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle23.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle23.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle23.StyleInfo.Font.Bold = False
			gridRangeStyle23.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle23.StyleInfo.Font.Italic = False
			gridRangeStyle23.StyleInfo.Font.Size = 8.25F
			gridRangeStyle23.StyleInfo.Font.Strikeout = False
			gridRangeStyle23.StyleInfo.Font.Underline = False
			gridRangeStyle23.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle23.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridRangeStyle23.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			gridRangeStyle24.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle24.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle24.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle24.StyleInfo.Font.Bold = False
			gridRangeStyle24.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle24.StyleInfo.Font.Italic = False
			gridRangeStyle24.StyleInfo.Font.Size = 8.25F
			gridRangeStyle24.StyleInfo.Font.Strikeout = False
			gridRangeStyle24.StyleInfo.Font.Underline = False
			gridRangeStyle24.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle24.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridRangeStyle24.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			gridRangeStyle25.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle25.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle25.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle25.StyleInfo.Font.Bold = False
			gridRangeStyle25.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle25.StyleInfo.Font.Italic = False
			gridRangeStyle25.StyleInfo.Font.Size = 8.25F
			gridRangeStyle25.StyleInfo.Font.Strikeout = False
			gridRangeStyle25.StyleInfo.Font.Underline = False
			gridRangeStyle25.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle25.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridRangeStyle25.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			gridRangeStyle26.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle26.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle26.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle26.StyleInfo.Font.Bold = False
			gridRangeStyle26.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle26.StyleInfo.Font.Italic = False
			gridRangeStyle26.StyleInfo.Font.Size = 8.25F
			gridRangeStyle26.StyleInfo.Font.Strikeout = False
			gridRangeStyle26.StyleInfo.Font.Underline = False
			gridRangeStyle26.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle26.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridRangeStyle26.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			gridRangeStyle27.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle27.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle27.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle27.StyleInfo.Font.Bold = False
			gridRangeStyle27.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle27.StyleInfo.Font.Italic = False
			gridRangeStyle27.StyleInfo.Font.Size = 8.25F
			gridRangeStyle27.StyleInfo.Font.Strikeout = False
			gridRangeStyle27.StyleInfo.Font.Underline = False
			gridRangeStyle27.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle27.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridRangeStyle27.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			gridRangeStyle28.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle28.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle28.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle28.StyleInfo.Font.Bold = False
			gridRangeStyle28.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle28.StyleInfo.Font.Italic = False
			gridRangeStyle28.StyleInfo.Font.Size = 8.25F
			gridRangeStyle28.StyleInfo.Font.Strikeout = False
			gridRangeStyle28.StyleInfo.Font.Underline = False
			gridRangeStyle28.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle28.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridRangeStyle28.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			gridRangeStyle29.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle29.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle29.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle29.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle29.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridRangeStyle29.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			Me.gridControl1.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() { gridRangeStyle21, gridRangeStyle22, gridRangeStyle23, gridRangeStyle24, gridRangeStyle25, gridRangeStyle26, gridRangeStyle27, gridRangeStyle28, gridRangeStyle29})
			Me.gridControl1.RowCount = 20
			Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
			Me.gridControl1.Size = New System.Drawing.Size(490, 443)
			Me.gridControl1.SmartSizeBox = False
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.Text = "gridControl1"
			Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.UseRightToLeftCompatibleTextBox = True
			Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			' 
			' gridControl2
			' 
			Me.gridControl2.ColCount = 4
			Me.gridControl2.DefaultRowHeight = 20
			Me.gridControl2.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.gridControl2.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.gridControl2.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridControl2.Location = New System.Drawing.Point(15, 112)
			Me.gridControl2.MetroScrollBars = True
			Me.gridControl2.Name = "gridControl2"
			gridRangeStyle30.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle30.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle30.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle30.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle30.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridRangeStyle30.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			Me.gridControl2.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() { gridRangeStyle30})
			Me.gridControl2.RowCount = 9
			Me.gridControl2.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
			Me.gridControl2.Size = New System.Drawing.Size(313, 209)
			Me.gridControl2.SmartSizeBox = False
			Me.gridControl2.TabIndex = 1
			Me.gridControl2.Text = "gridControl2"
			Me.gridControl2.ThemesEnabled = True
			Me.gridControl2.UseRightToLeftCompatibleTextBox = True
			Me.gridControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Controls.Add(Me.BaseStyleColor)
			Me.groupBox1.Controls.Add(Me.BaseStyleCheck)
			Me.groupBox1.Controls.Add(Me.Cell32Color)
			Me.groupBox1.Controls.Add(Me.Cell32Check)
			Me.groupBox1.Controls.Add(Me.Column2Color)
			Me.groupBox1.Controls.Add(Me.Column2Check)
			Me.groupBox1.Controls.Add(Me.Row3Color)
			Me.groupBox1.Controls.Add(Me.Row3Check)
			Me.groupBox1.Controls.Add(Me.TableColor)
			Me.groupBox1.Controls.Add(Me.TableCheck)
			Me.groupBox1.Controls.Add(Me.StandardColor)
			Me.groupBox1.Controls.Add(Me.StandardCheck)
			Me.groupBox1.Controls.Add(Me.gridControl2)
			Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox1.ForeColor = System.Drawing.Color.DimGray
			Me.groupBox1.Location = New System.Drawing.Point(540, 14)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(334, 564)
			Me.groupBox1.TabIndex = 2
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Styles via StyleObjects"
			' 
			' BaseStyleColor
			' 
			Me.BaseStyleColor.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(180))))), (CInt(Fix((CByte(231))))), (CInt(Fix((CByte(242))))))
			Me.BaseStyleColor.ColorUISize = New System.Drawing.Size(208, 230)
			Me.BaseStyleColor.Location = New System.Drawing.Point(57, 382)
			Me.BaseStyleColor.Name = "BaseStyleColor"
			Me.BaseStyleColor.SelectedColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(180))))), (CInt(Fix((CByte(231))))), (CInt(Fix((CByte(242))))))
			Me.BaseStyleColor.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors
			Me.BaseStyleColor.Size = New System.Drawing.Size(75, 23)
			Me.BaseStyleColor.TabIndex = 25
			Me.BaseStyleColor.UseVisualStyleBackColor = False
			' 
			' BaseStyleCheck
			' 
			Me.BaseStyleCheck.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.BaseStyleCheck.Location = New System.Drawing.Point(151, 383)
			Me.BaseStyleCheck.Name = "BaseStyleCheck"
			Me.BaseStyleCheck.Size = New System.Drawing.Size(135, 24)
			Me.BaseStyleCheck.TabIndex = 24
			Me.BaseStyleCheck.Text = "GridBaseStyle"
'			Me.BaseStyleCheck.CheckedChanged += New System.EventHandler(Me.ApplySettings)
			' 
			' Cell32Color
			' 
			Me.Cell32Color.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(42))))), (CInt(Fix((CByte(67))))), (CInt(Fix((CByte(142))))))
			Me.Cell32Color.ColorUISize = New System.Drawing.Size(208, 230)
			Me.Cell32Color.Location = New System.Drawing.Point(57, 526)
			Me.Cell32Color.Name = "Cell32Color"
			Me.Cell32Color.SelectedColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(42))))), (CInt(Fix((CByte(67))))), (CInt(Fix((CByte(142))))))
			Me.Cell32Color.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors
			Me.Cell32Color.Size = New System.Drawing.Size(75, 23)
			Me.Cell32Color.TabIndex = 23
			Me.Cell32Color.UseVisualStyleBackColor = False
			' 
			' Cell32Check
			' 
			Me.Cell32Check.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.Cell32Check.Location = New System.Drawing.Point(151, 528)
			Me.Cell32Check.Name = "Cell32Check"
			Me.Cell32Check.Size = New System.Drawing.Size(135, 24)
			Me.Cell32Check.TabIndex = 22
			Me.Cell32Check.Text = "Cell 3,2 GridStyleInfo"
'			Me.Cell32Check.CheckedChanged += New System.EventHandler(Me.ApplySettings)
			' 
			' Column2Color
			' 
			Me.Column2Color.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(133))))), (CInt(Fix((CByte(191))))), (CInt(Fix((CByte(117))))))
			Me.Column2Color.ColorUISize = New System.Drawing.Size(208, 230)
			Me.Column2Color.Location = New System.Drawing.Point(57, 455)
			Me.Column2Color.Name = "Column2Color"
			Me.Column2Color.SelectedColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(133))))), (CInt(Fix((CByte(191))))), (CInt(Fix((CByte(117))))))
			Me.Column2Color.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors
			Me.Column2Color.Size = New System.Drawing.Size(75, 23)
			Me.Column2Color.TabIndex = 21
			Me.Column2Color.UseVisualStyleBackColor = False
			' 
			' Column2Check
			' 
			Me.Column2Check.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.Column2Check.Location = New System.Drawing.Point(151, 457)
			Me.Column2Check.Name = "Column2Check"
			Me.Column2Check.Size = New System.Drawing.Size(143, 24)
			Me.Column2Check.TabIndex = 20
			Me.Column2Check.Text = "Column2 GridStyleInfo"
'			Me.Column2Check.CheckedChanged += New System.EventHandler(Me.ApplySettings)
			' 
			' Row3Color
			' 
			Me.Row3Color.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(222))))), (CInt(Fix((CByte(100))))), (CInt(Fix((CByte(19))))))
			Me.Row3Color.ColorUISize = New System.Drawing.Size(208, 230)
			Me.Row3Color.Location = New System.Drawing.Point(57, 491)
			Me.Row3Color.Name = "Row3Color"
			Me.Row3Color.SelectedColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(222))))), (CInt(Fix((CByte(100))))), (CInt(Fix((CByte(19))))))
			Me.Row3Color.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors
			Me.Row3Color.Size = New System.Drawing.Size(75, 23)
			Me.Row3Color.TabIndex = 19
			Me.Row3Color.UseVisualStyleBackColor = False
			' 
			' Row3Check
			' 
			Me.Row3Check.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.Row3Check.Location = New System.Drawing.Point(151, 493)
			Me.Row3Check.Name = "Row3Check"
			Me.Row3Check.Size = New System.Drawing.Size(135, 24)
			Me.Row3Check.TabIndex = 18
			Me.Row3Check.Text = "Row3 GridStyleInfo"
'			Me.Row3Check.CheckedChanged += New System.EventHandler(Me.ApplySettings)
			' 
			' TableColor
			' 
			Me.TableColor.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(196))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(233))))))
			Me.TableColor.ColorUISize = New System.Drawing.Size(208, 230)
			Me.TableColor.Location = New System.Drawing.Point(57, 418)
			Me.TableColor.Name = "TableColor"
			Me.TableColor.SelectedColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(196))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(233))))))
			Me.TableColor.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors
			Me.TableColor.Size = New System.Drawing.Size(75, 23)
			Me.TableColor.TabIndex = 17
			Me.TableColor.UseVisualStyleBackColor = False
			' 
			' TableCheck
			' 
			Me.TableCheck.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.TableCheck.Location = New System.Drawing.Point(151, 420)
			Me.TableCheck.Name = "TableCheck"
			Me.TableCheck.Size = New System.Drawing.Size(135, 24)
			Me.TableCheck.TabIndex = 16
			Me.TableCheck.Text = "Table GridStyleInfo"
'			Me.TableCheck.CheckedChanged += New System.EventHandler(Me.ApplySettings)
			' 
			' StandardColor
			' 
			Me.StandardColor.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(191))))), (CInt(Fix((CByte(242))))))
			Me.StandardColor.ColorUISize = New System.Drawing.Size(208, 230)
			Me.StandardColor.Location = New System.Drawing.Point(57, 348)
			Me.StandardColor.Name = "StandardColor"
			Me.StandardColor.SelectedColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(128))))), (CInt(Fix((CByte(191))))), (CInt(Fix((CByte(242))))))
			Me.StandardColor.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors
			Me.StandardColor.Size = New System.Drawing.Size(75, 23)
			Me.StandardColor.TabIndex = 15
			Me.StandardColor.UseVisualStyleBackColor = False
			' 
			' StandardCheck
			' 
			Me.StandardCheck.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.StandardCheck.Location = New System.Drawing.Point(151, 349)
			Me.StandardCheck.Name = "StandardCheck"
			Me.StandardCheck.Size = New System.Drawing.Size(152, 24)
			Me.StandardCheck.TabIndex = 14
			Me.StandardCheck.Text = "Standard GridStyleInfo"
'			Me.StandardCheck.CheckedChanged += New System.EventHandler(Me.ApplySettings)
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.label2)
			Me.groupBox2.Controls.Add(Me.gridControl1)
			Me.groupBox2.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox2.ForeColor = System.Drawing.Color.DimGray
			Me.groupBox2.Location = New System.Drawing.Point(12, 14)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(511, 567)
			Me.groupBox2.TabIndex = 3
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "CellStyles "
			' 
			' label1
			' 
			Me.label1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.ForeColor = System.Drawing.Color.DimGray
			Me.label1.Location = New System.Drawing.Point(14, 34)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(314, 74)
			Me.label1.TabIndex = 26
			Me.label1.Text = resources.GetString("label1.Text")
			' 
			' label2
			' 
			Me.label2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.ForeColor = System.Drawing.Color.DimGray
			Me.label2.Location = New System.Drawing.Point(10, 34)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(493, 74)
			Me.label2.TabIndex = 27
			Me.label2.Text = resources.GetString("label2.Text")
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(891, 595)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.groupBox2)
			Me.DropShadow = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.Text = "Grid Style Demo"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private gridControl2 As Syncfusion.Windows.Forms.Grid.GridControl
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private BaseStyleColor As Syncfusion.Windows.Forms.ColorPickerButton
		Private WithEvents BaseStyleCheck As System.Windows.Forms.CheckBox
		Private Cell32Color As Syncfusion.Windows.Forms.ColorPickerButton
		Private WithEvents Cell32Check As System.Windows.Forms.CheckBox
		Private Column2Color As Syncfusion.Windows.Forms.ColorPickerButton
		Private WithEvents Column2Check As System.Windows.Forms.CheckBox
		Private Row3Color As Syncfusion.Windows.Forms.ColorPickerButton
		Private WithEvents Row3Check As System.Windows.Forms.CheckBox
		Private TableColor As Syncfusion.Windows.Forms.ColorPickerButton
		Private WithEvents TableCheck As System.Windows.Forms.CheckBox
		Private StandardColor As Syncfusion.Windows.Forms.ColorPickerButton
		Private WithEvents StandardCheck As System.Windows.Forms.CheckBox
		Private gridBaseStyle1 As Syncfusion.Windows.Forms.Grid.GridBaseStyle
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
	End Class
End Namespace

