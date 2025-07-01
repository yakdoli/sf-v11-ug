Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Namespace PrintPageLayout
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
			Dim gridRangeStyle5 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle6 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.colorPickerButton2 = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DefaultRowHeight = 20
			Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridControl1.Location = New System.Drawing.Point(21, 0)
			Me.gridControl1.MetroScrollBars = True
			Me.gridControl1.Name = "gridControl1"
			gridRangeStyle5.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle5.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle5.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle5.StyleInfo.Font.Bold = False
			gridRangeStyle5.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle5.StyleInfo.Font.Italic = False
			gridRangeStyle5.StyleInfo.Font.Size = 8.25F
			gridRangeStyle5.StyleInfo.Font.Strikeout = False
			gridRangeStyle5.StyleInfo.Font.Underline = False
			gridRangeStyle5.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle5.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridRangeStyle5.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			gridRangeStyle6.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle6.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle6.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle6.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle6.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridRangeStyle6.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			Me.gridControl1.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() { gridRangeStyle5, gridRangeStyle6})
			Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
			Me.gridControl1.Size = New System.Drawing.Size(731, 373)
			Me.gridControl1.SmartSizeBox = False
			Me.gridControl1.SmoothControlResize = False
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.Text = "gridControl1"
			Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.BorderStyle=BorderStyle.FixedSingle
			Me.gridControl1.UseRightToLeftCompatibleTextBox = True
			' 
			' checkBox1
			' 
			Me.checkBox1.AutoSize = True
			Me.checkBox1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox1.Location = New System.Drawing.Point(33, 42)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(123, 19)
			Me.checkBox1.TabIndex = 1
			Me.checkBox1.Text = "Show Page Layout"
			Me.checkBox1.UseVisualStyleBackColor = True
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged)
			' 
			' button1
			' 
			Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.button1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.button1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button1.ForeColor = System.Drawing.Color.White
			Me.button1.Location = New System.Drawing.Point(824, 304)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(143, 30)
			Me.button1.TabIndex = 2
			Me.button1.Text = "PrintPreview"
			Me.button1.UseVisualStyle = True
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.gridControl1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(780, 391)
			Me.panel1.TabIndex = 3
			' 
			' colorPickerButton1
			' 
			Me.colorPickerButton1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.colorPickerButton1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.colorPickerButton1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
			Me.colorPickerButton1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.colorPickerButton1.ForeColor = System.Drawing.Color.White
			Me.colorPickerButton1.Location = New System.Drawing.Point(24, 87)
			Me.colorPickerButton1.Name = "colorPickerButton1"
			Me.colorPickerButton1.Size = New System.Drawing.Size(143, 27)
			Me.colorPickerButton1.TabIndex = 4
			Me.colorPickerButton1.Text = "Layout Line Color"
			Me.colorPickerButton1.UseVisualStyle = True
			Me.colorPickerButton1.UseVisualStyleBackColor = True
			' 
			' colorPickerButton2
			' 
			Me.colorPickerButton2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.colorPickerButton2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.colorPickerButton2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.colorPickerButton2.ColorUISize = New System.Drawing.Size(208, 230)
			Me.colorPickerButton2.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.colorPickerButton2.ForeColor = System.Drawing.Color.White
			Me.colorPickerButton2.Location = New System.Drawing.Point(24, 134)
			Me.colorPickerButton2.Name = "colorPickerButton2"
			Me.colorPickerButton2.Size = New System.Drawing.Size(143, 27)
			Me.colorPickerButton2.TabIndex = 5
			Me.colorPickerButton2.Text = "Layout Text Color"
			Me.colorPickerButton2.UseVisualStyle = True
			Me.colorPickerButton2.UseVisualStyleBackColor = True
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.colorPickerButton2)
			Me.groupBox1.Controls.Add(Me.colorPickerButton1)
			Me.groupBox1.Controls.Add(Me.checkBox1)
			Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox1.Location = New System.Drawing.Point(800, 71)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(186, 201)
			Me.groupBox1.TabIndex = 6
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Page Layout Options"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.White
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(1028, 391)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.button1)
			Me.DropShadow = True
			Me.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.Text = "Print Page Layout"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
		Private panel1 As System.Windows.Forms.Panel
		Private colorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
		Private colorPickerButton2 As Syncfusion.Windows.Forms.ColorPickerButton
		Private groupBox1 As System.Windows.Forms.GroupBox
	End Class
End Namespace

