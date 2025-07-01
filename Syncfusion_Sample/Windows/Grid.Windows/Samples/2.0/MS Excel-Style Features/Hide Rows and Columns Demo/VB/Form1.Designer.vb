Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Namespace HideRowCols
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
            If disposing AndAlso (Not components Is Nothing) Then
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
            Me.components = New System.ComponentModel.Container
            Dim GridRangeStyle1 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle2 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle3 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle4 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle5 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle6 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle7 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle8 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.btnHide = New Syncfusion.Windows.Forms.ButtonAdv
            Me.label1 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.gridRecordNavigationControl1 = New Syncfusion.Windows.Forms.Grid.GridRecordNavigationControl
            Me.upDownRow = New System.Windows.Forms.NumericUpDown
            Me.upDownCol = New System.Windows.Forms.NumericUpDown
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.label4 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gridRecordNavigationControl1.SuspendLayout()
            CType(Me.upDownRow, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.upDownCol, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gridControl1
            '
            Me.gridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
            Me.gridControl1.DefaultRowHeight = 20
            Me.gridControl1.FillSplitterPane = True
            Me.gridControl1.Font = New System.Drawing.Font("Verdana", 8.25!)
            Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MetroScrollBars = True
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
            Me.gridControl1.Properties.MarkColHeader = False
            Me.gridControl1.Properties.MarkRowHeader = False
            GridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle1.StyleInfo.Font.Bold = False
            GridRangeStyle1.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle1.StyleInfo.Font.Italic = False
            GridRangeStyle1.StyleInfo.Font.Size = 8.25!
            GridRangeStyle1.StyleInfo.Font.Strikeout = False
            GridRangeStyle1.StyleInfo.Font.Underline = False
            GridRangeStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle1.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle2.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle2.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle2.StyleInfo.Font.Bold = False
            GridRangeStyle2.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle2.StyleInfo.Font.Italic = False
            GridRangeStyle2.StyleInfo.Font.Size = 8.25!
            GridRangeStyle2.StyleInfo.Font.Strikeout = False
            GridRangeStyle2.StyleInfo.Font.Underline = False
            GridRangeStyle2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle2.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle2.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle3.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle3.StyleInfo.Font.Bold = False
            GridRangeStyle3.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle3.StyleInfo.Font.Italic = False
            GridRangeStyle3.StyleInfo.Font.Size = 8.25!
            GridRangeStyle3.StyleInfo.Font.Strikeout = False
            GridRangeStyle3.StyleInfo.Font.Underline = False
            GridRangeStyle3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle4.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle4.StyleInfo.Font.Bold = False
            GridRangeStyle4.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle4.StyleInfo.Font.Italic = False
            GridRangeStyle4.StyleInfo.Font.Size = 8.25!
            GridRangeStyle4.StyleInfo.Font.Strikeout = False
            GridRangeStyle4.StyleInfo.Font.Underline = False
            GridRangeStyle4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle5.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle5.StyleInfo.Font.Bold = False
            GridRangeStyle5.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle5.StyleInfo.Font.Italic = False
            GridRangeStyle5.StyleInfo.Font.Size = 8.25!
            GridRangeStyle5.StyleInfo.Font.Strikeout = False
            GridRangeStyle5.StyleInfo.Font.Underline = False
            GridRangeStyle5.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle6.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle6.StyleInfo.Font.Bold = False
            GridRangeStyle6.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle6.StyleInfo.Font.Italic = False
            GridRangeStyle6.StyleInfo.Font.Size = 8.25!
            GridRangeStyle6.StyleInfo.Font.Strikeout = False
            GridRangeStyle6.StyleInfo.Font.Underline = False
            GridRangeStyle6.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle7.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle7.StyleInfo.Font.Bold = False
            GridRangeStyle7.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle7.StyleInfo.Font.Italic = False
            GridRangeStyle7.StyleInfo.Font.Size = 8.25!
            GridRangeStyle7.StyleInfo.Font.Strikeout = False
            GridRangeStyle7.StyleInfo.Font.Underline = False
            GridRangeStyle7.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle8.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle8.StyleInfo.Font.Bold = False
            GridRangeStyle8.StyleInfo.Font.Facename = "Verdana"
            GridRangeStyle8.StyleInfo.Font.Italic = False
            GridRangeStyle8.StyleInfo.Font.Size = 8.25!
            GridRangeStyle8.StyleInfo.Font.Strikeout = False
            GridRangeStyle8.StyleInfo.Font.Underline = False
            GridRangeStyle8.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            Me.gridControl1.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() {GridRangeStyle1, GridRangeStyle2, GridRangeStyle3, GridRangeStyle4, GridRangeStyle5, GridRangeStyle6, GridRangeStyle7, GridRangeStyle8})
            Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridControl1.Size = New System.Drawing.Size(665, 340)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.Text = "gridControl1"
            Me.gridControl1.ThemesEnabled = True
            Me.gridControl1.BorderStyle=BorderStyle.FixedSingle
			'
            'btnHide
            '
            Me.btnHide.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnHide.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.btnHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnHide.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnHide.ForeColor = System.Drawing.Color.White
            Me.btnHide.Location = New System.Drawing.Point(64, 110)
            Me.btnHide.Name = "btnHide"
            Me.btnHide.Size = New System.Drawing.Size(116, 50)
            Me.btnHide.TabIndex = 1
            Me.btnHide.Text = "Hide Rows and Columns"
            Me.btnHide.UseVisualStyle = True
            Me.btnHide.UseVisualStyleBackColor = True
            '
            'label1
            '
            Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.label1.BackColor = System.Drawing.Color.White
            Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(715, 61)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(202, 79)
            Me.label1.TabIndex = 2
            Me.label1.Text = "Output"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label2
            '
            Me.label2.BackColor = System.Drawing.Color.White
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.Black
            Me.label2.Location = New System.Drawing.Point(12, 0)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(689, 27)
            Me.label2.TabIndex = 3
            Me.label2.Text = "A Sample to Hide/Show Thousands of Rows and Columns"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'gridRecordNavigationControl1
            '
            Me.gridRecordNavigationControl1.AllowAddNew = False
            Me.gridRecordNavigationControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridRecordNavigationControl1.ButtonLook = Syncfusion.Windows.Forms.ButtonLook.Normal
            Me.gridRecordNavigationControl1.Controls.Add(Me.gridControl1)
            Me.gridRecordNavigationControl1.DisabledArrowColor = System.Drawing.SystemColors.GrayText
            Me.gridRecordNavigationControl1.EnabledArrowColor = System.Drawing.SystemColors.WindowText
            Me.gridRecordNavigationControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
            Me.gridRecordNavigationControl1.Location = New System.Drawing.Point(15, 39)
            Me.gridRecordNavigationControl1.MaxRecord = 10
            Me.gridRecordNavigationControl1.MinRecord = 1
            Me.gridRecordNavigationControl1.Name = "gridRecordNavigationControl1"
            Me.gridRecordNavigationControl1.NavigationBarBackColor = System.Drawing.SystemColors.Window
            Me.gridRecordNavigationControl1.ShowToolTips = True
            Me.gridRecordNavigationControl1.Size = New System.Drawing.Size(686, 361)
            Me.gridRecordNavigationControl1.SplitBars = CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars)
            Me.gridRecordNavigationControl1.TabIndex = 4
            Me.gridRecordNavigationControl1.Text = "gridRecordNavigationControl1"
            Me.gridRecordNavigationControl1.ThemesEnabled = True
            '
            'upDownRow
            '
            Me.upDownRow.Location = New System.Drawing.Point(68, 37)
            Me.upDownRow.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
            Me.upDownRow.Name = "upDownRow"
            Me.upDownRow.Size = New System.Drawing.Size(79, 21)
            Me.upDownRow.TabIndex = 2
            '
            'upDownCol
            '
            Me.upDownCol.Location = New System.Drawing.Point(68, 72)
            Me.upDownCol.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
            Me.upDownCol.Name = "upDownCol"
            Me.upDownCol.Size = New System.Drawing.Size(79, 21)
            Me.upDownCol.TabIndex = 3
            '
            'groupBox1
            '
            Me.groupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.btnHide)
            Me.groupBox1.Controls.Add(Me.upDownCol)
            Me.groupBox1.Controls.Add(Me.upDownRow)
            Me.groupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(718, 163)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(199, 176)
            Me.groupBox1.TabIndex = 5
            Me.groupBox1.TabStop = False
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(11, 80)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(47, 13)
            Me.label4.TabIndex = 5
            Me.label4.Text = "Columns"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(11, 45)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(33, 13)
            Me.label3.TabIndex = 4
            Me.label3.Text = "Rows"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(929, 412)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.gridRecordNavigationControl1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Hide Rows and Columns Demo"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gridRecordNavigationControl1.ResumeLayout(False)
            CType(Me.upDownRow, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.upDownCol, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
        Private WithEvents btnHide As Syncfusion.Windows.Forms.ButtonAdv
        Private label1 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private gridRecordNavigationControl1 As Syncfusion.Windows.Forms.Grid.GridRecordNavigationControl
        Private upDownRow As System.Windows.Forms.NumericUpDown
        Private WithEvents upDownCol As System.Windows.Forms.NumericUpDown
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private label4 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
    End Class
End Namespace

