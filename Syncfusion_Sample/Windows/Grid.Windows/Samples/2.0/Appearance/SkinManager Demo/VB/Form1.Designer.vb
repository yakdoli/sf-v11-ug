Imports Microsoft.VisualBasic
Imports System
Imports Syncfusion.Windows.Forms.Tools
Namespace SkinManagerDemo_2008
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
            Dim GridRangeStyle1 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle2 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle3 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle4 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle5 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle6 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle7 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Me.comboBox2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.comboBox1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.label2 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.grid = New System.Windows.Forms.GroupBox
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.gridListControl1 = New Syncfusion.Windows.Forms.Grid.GridListControl
            Me.gridList = New System.Windows.Forms.GroupBox
            Me.parent_Renamed = New System.Windows.Forms.GroupBox
            Me.styles = New System.Windows.Forms.GroupBox
            Me.label3 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            CType(Me.comboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grid.SuspendLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gridList.SuspendLayout()
            Me.parent_Renamed.SuspendLayout()
            Me.styles.SuspendLayout()
            Me.SuspendLayout()
            '
            'comboBox2
            '
            Me.comboBox2.BackColor = System.Drawing.Color.White
            Me.comboBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboBox2.Items.AddRange(New Object() {"Office2007Blue", "Office2007Black", "Office2007Silver", "Office2010Blue", "Office2010Black", "Office2010Silver"})
            Me.comboBox2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox2, "Office2007Blue"))
            Me.comboBox2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox2, "Office2007Black"))
            Me.comboBox2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox2, "Office2007Silver"))
            Me.comboBox2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox2, "Office2010Blue"))
            Me.comboBox2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox2, "Office2010Black"))
            Me.comboBox2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox2, "Office2010Silver"))
            Me.comboBox2.Location = New System.Drawing.Point(119, 75)
            Me.comboBox2.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(159, 23)
            Me.comboBox2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
            Me.comboBox2.TabIndex = 3
            '
            'comboBox1
            '
            Me.comboBox1.BackColor = System.Drawing.Color.White
            Me.comboBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboBox1.Items.AddRange(New Object() {"Parent Container", "GridControl", "GridListControl"})
            Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "Parent Container"))
            Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "GridControl"))
            Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "GridListControl"))
            Me.comboBox1.Location = New System.Drawing.Point(119, 37)
            Me.comboBox1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(159, 23)
            Me.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
            Me.comboBox1.TabIndex = 2
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(17, 80)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(78, 15)
            Me.label2.TabIndex = 1
            Me.label2.Text = "Visual Theme"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(14, 39)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(84, 15)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Parent Control"
            '
            'grid
            '
            Me.grid.Controls.Add(Me.gridControl1)
            Me.grid.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grid.Location = New System.Drawing.Point(20, 24)
            Me.grid.Name = "grid"
            Me.grid.Size = New System.Drawing.Size(628, 304)
            Me.grid.TabIndex = 5
            Me.grid.TabStop = False
            Me.grid.Text = "GridControl"
            '
            'gridControl1
            '
            Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gridControl1.ColCount = 15
            Me.gridControl1.DefaultColWidth = 90
            Me.gridControl1.DefaultRowHeight = 20
            Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridControl1.Location = New System.Drawing.Point(17, 30)
            Me.gridControl1.MetroScrollBars = True
            Me.gridControl1.Name = "gridControl1"
            GridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle1.StyleInfo.Font.Bold = False
            GridRangeStyle1.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle1.StyleInfo.Font.Italic = False
            GridRangeStyle1.StyleInfo.Font.Size = 8.25!
            GridRangeStyle1.StyleInfo.Font.Strikeout = False
            GridRangeStyle1.StyleInfo.Font.Underline = False
            GridRangeStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle2.StyleInfo.Font.Bold = False
            GridRangeStyle2.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle2.StyleInfo.Font.Italic = False
            GridRangeStyle2.StyleInfo.Font.Size = 8.25!
            GridRangeStyle2.StyleInfo.Font.Strikeout = False
            GridRangeStyle2.StyleInfo.Font.Underline = False
            GridRangeStyle2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle3.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle3.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle3.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle3.StyleInfo.Font.Bold = False
            GridRangeStyle3.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle3.StyleInfo.Font.Italic = False
            GridRangeStyle3.StyleInfo.Font.Size = 8.25!
            GridRangeStyle3.StyleInfo.Font.Strikeout = False
            GridRangeStyle3.StyleInfo.Font.Underline = False
            GridRangeStyle3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle3.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle4.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle4.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle4.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle4.StyleInfo.Font.Bold = False
            GridRangeStyle4.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle4.StyleInfo.Font.Italic = False
            GridRangeStyle4.StyleInfo.Font.Size = 8.25!
            GridRangeStyle4.StyleInfo.Font.Strikeout = False
            GridRangeStyle4.StyleInfo.Font.Underline = False
            GridRangeStyle4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle4.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle4.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle5.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle5.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle5.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle5.StyleInfo.Font.Bold = False
            GridRangeStyle5.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle5.StyleInfo.Font.Italic = False
            GridRangeStyle5.StyleInfo.Font.Size = 8.25!
            GridRangeStyle5.StyleInfo.Font.Strikeout = False
            GridRangeStyle5.StyleInfo.Font.Underline = False
            GridRangeStyle5.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle5.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle5.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle6.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle6.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle6.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle6.StyleInfo.Font.Bold = False
            GridRangeStyle6.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle6.StyleInfo.Font.Italic = False
            GridRangeStyle6.StyleInfo.Font.Size = 8.25!
            GridRangeStyle6.StyleInfo.Font.Strikeout = False
            GridRangeStyle6.StyleInfo.Font.Underline = False
            GridRangeStyle6.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle6.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle6.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle7.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle7.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle7.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle7.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle7.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle7.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridControl1.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() {GridRangeStyle1, GridRangeStyle2, GridRangeStyle3, GridRangeStyle4, GridRangeStyle5, GridRangeStyle6, GridRangeStyle7})
            Me.gridControl1.RowCount = 20
            Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridControl1.Size = New System.Drawing.Size(595, 251)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.Text = "gridControl1"
            Me.gridControl1.ThemesEnabled = True
            Me.gridControl1.UseRightToLeftCompatibleTextBox = True
            '
            'gridListControl1
            '
            Me.gridListControl1.BackColor = System.Drawing.SystemColors.Control
            Me.gridListControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gridListControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridListControl1.ItemHeight = 20
            Me.gridListControl1.Location = New System.Drawing.Point(17, 22)
            Me.gridListControl1.MultiColumn = False
            Me.gridListControl1.Name = "gridListControl1"
            Me.gridListControl1.Properties.BackgroundColor = System.Drawing.SystemColors.Window
            Me.gridListControl1.Properties.MarkColHeader = False
            Me.gridListControl1.Properties.MarkRowHeader = False
            Me.gridListControl1.SelectedIndex = -1
            Me.gridListControl1.Size = New System.Drawing.Size(595, 105)
            Me.gridListControl1.TabIndex = 1
            Me.gridListControl1.ThemesEnabled = True
            Me.gridListControl1.TopIndex = 0
            '
            'gridList
            '
            Me.gridList.Controls.Add(Me.gridListControl1)
            Me.gridList.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gridList.Location = New System.Drawing.Point(20, 351)
            Me.gridList.Name = "gridList"
            Me.gridList.Size = New System.Drawing.Size(628, 138)
            Me.gridList.TabIndex = 6
            Me.gridList.TabStop = False
            Me.gridList.Text = "GridListControl"
            '
            'parent_Renamed
            '
            Me.parent_Renamed.Controls.Add(Me.grid)
            Me.parent_Renamed.Controls.Add(Me.gridList)
            Me.parent_Renamed.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parent_Renamed.ForeColor = System.Drawing.Color.Black
            Me.parent_Renamed.Location = New System.Drawing.Point(12, 12)
            Me.parent_Renamed.Name = "parent_Renamed"
            Me.parent_Renamed.Size = New System.Drawing.Size(661, 498)
            Me.parent_Renamed.TabIndex = 7
            Me.parent_Renamed.TabStop = False
            Me.parent_Renamed.Text = "Parent Container"
            '
            'styles
            '
            Me.styles.BackColor = System.Drawing.Color.White
            Me.styles.Controls.Add(Me.comboBox2)
            Me.styles.Controls.Add(Me.comboBox1)
            Me.styles.Controls.Add(Me.label2)
            Me.styles.Controls.Add(Me.label1)
            Me.styles.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.styles.Location = New System.Drawing.Point(700, 36)
            Me.styles.Name = "styles"
            Me.styles.Size = New System.Drawing.Size(295, 133)
            Me.styles.TabIndex = 4
            Me.styles.TabStop = False
            Me.styles.Text = "Apply Styles Here"
            '
            'label3
            '
            Me.label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(697, 207)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(298, 29)
            Me.label3.TabIndex = 8
            Me.label3.Text = "This sample demonstrates the implementation of SkinManager in GridControl and Gri" & _
                "dListControl."
            '
            'label4
            '
            Me.label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(697, 251)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(281, 30)
            Me.label4.TabIndex = 9
            Me.label4.Text = "You can apply themes to a collection of controls within a container just with a s" & _
                "ingle component call."
            '
            'label5
            '
            Me.label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.Location = New System.Drawing.Point(697, 294)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(310, 36)
            Me.label5.TabIndex = 10
            Me.label5.Text = "Below is the code used to set themes to all controls within the GroupBox 'ParentC" & _
                "ontainer'"
            '
            'label6
            '
            Me.label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.ForeColor = System.Drawing.Color.DarkOrange
            Me.label6.Location = New System.Drawing.Point(708, 343)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(287, 23)
            Me.label6.TabIndex = 11
            Me.label6.Text = "SkinManager.SetVisualStyle(this, ""Office2010Blue"");"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1000, 523)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.styles)
            Me.Controls.Add(Me.parent_Renamed)
            Me.DropShadow = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SkinManager Demo"
            CType(Me.comboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grid.ResumeLayout(False)
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridListControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gridList.ResumeLayout(False)
            Me.parent_Renamed.ResumeLayout(False)
            Me.styles.ResumeLayout(False)
            Me.styles.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private WithEvents comboBox2 As ComboBoxAdv
		Private WithEvents comboBox1 As ComboBoxAdv
		Private grid As System.Windows.Forms.GroupBox
		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private gridListControl1 As Syncfusion.Windows.Forms.Grid.GridListControl
		Private gridList As System.Windows.Forms.GroupBox
'INSTANT VB NOTE: The variable parent was renamed since Visual Basic does not allow class members with the same name:
		Private parent_Renamed As System.Windows.Forms.GroupBox
		Private styles As System.Windows.Forms.GroupBox
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label


	End Class
End Namespace