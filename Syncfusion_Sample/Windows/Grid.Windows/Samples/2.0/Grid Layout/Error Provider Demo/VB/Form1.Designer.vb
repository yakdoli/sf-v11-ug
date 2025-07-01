Imports Microsoft.VisualBasic
Imports System
Namespace ErrorProvider
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
            Me.components = New System.ComponentModel.Container
            Dim GridRangeStyle5 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.textBox2 = New System.Windows.Forms.TextBox
            Me.label2 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.chkSetError = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.chkValidate = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBox3 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBox2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBox1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.panel1 = New System.Windows.Forms.Panel
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.groupBox1.SuspendLayout()
            CType(Me.chkSetError, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkValidate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.textBox2)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Controls.Add(Me.chkSetError)
            Me.groupBox1.Controls.Add(Me.textBox1)
            Me.groupBox1.Controls.Add(Me.chkValidate)
            Me.groupBox1.Controls.Add(Me.checkBox3)
            Me.groupBox1.Controls.Add(Me.checkBox2)
            Me.groupBox1.Controls.Add(Me.checkBox1)
            Me.groupBox1.Location = New System.Drawing.Point(12, 184)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(607, 157)
            Me.groupBox1.TabIndex = 1
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Error Provider Settings"
            '
            'textBox2
            '
            Me.textBox2.Location = New System.Drawing.Point(150, 108)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(417, 23)
            Me.textBox2.TabIndex = 20
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(147, 134)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(212, 13)
            Me.label2.TabIndex = 19
            Me.label2.Text = "(The error Messagebox will display this text)"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(147, 84)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(212, 13)
            Me.label1.TabIndex = 18
            Me.label1.Text = "(The error Messagebox will display this text)"
            '
            'chkSetError
            '
            Me.chkSetError.DrawFocusRectangle = False
            Me.chkSetError.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkSetError.Location = New System.Drawing.Point(7, 108)
            Me.chkSetError.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.chkSetError.Name = "chkSetError"
            Me.chkSetError.Size = New System.Drawing.Size(136, 23)
            Me.chkSetError.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.chkSetError.TabIndex = 17
            Me.chkSetError.Text = "Set Custom Error"
            Me.chkSetError.ThemesEnabled = False
            Me.toolTip1.SetToolTip(Me.chkSetError, "This will trigger the CurrentCellValidating event to customize the error")
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(150, 58)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(417, 23)
            Me.textBox1.TabIndex = 16
            '
            'chkValidate
            '
            Me.chkValidate.DrawFocusRectangle = False
            Me.chkValidate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkValidate.Location = New System.Drawing.Point(7, 60)
            Me.chkValidate.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.chkValidate.Name = "chkValidate"
            Me.chkValidate.Size = New System.Drawing.Size(136, 21)
            Me.chkValidate.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.chkValidate.TabIndex = 15
            Me.chkValidate.Text = "Validation Text"
            Me.chkValidate.ThemesEnabled = False
            '
            'checkBox3
            '
            Me.checkBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox3.Location = New System.Drawing.Point(202, 24)
            Me.checkBox3.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(166, 20)
            Me.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox3.TabIndex = 14
            Me.checkBox3.Text = "Show Error MessageBox"
            Me.checkBox3.ThemesEnabled = False
            '
            'checkBox2
            '
            Me.checkBox2.DrawFocusRectangle = False
            Me.checkBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox2.Location = New System.Drawing.Point(392, 24)
            Me.checkBox2.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(181, 20)
            Me.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox2.TabIndex = 13
            Me.checkBox2.Text = "Show Currentcell Error Icon"
            Me.checkBox2.ThemesEnabled = False
            '
            'checkBox1
            '
            Me.checkBox1.DrawFocusRectangle = False
            Me.checkBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox1.Location = New System.Drawing.Point(7, 24)
            Me.checkBox1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(163, 20)
            Me.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox1.TabIndex = 12
            Me.checkBox1.Text = "Show Header Error Icon"
            Me.checkBox1.ThemesEnabled = False
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.gridControl1)
            Me.panel1.Location = New System.Drawing.Point(12, 7)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(607, 166)
            Me.panel1.TabIndex = 2
            '
            'gridControl1
            '
            Me.gridControl1.ColCount = 3
            Me.gridControl1.DefaultColWidth = 190
            Me.gridControl1.DefaultRowHeight = 20
            Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridControl1.Location = New System.Drawing.Point(0, 1)
            Me.gridControl1.MetroScrollBars = True
            Me.gridControl1.Name = "gridControl1"
            GridRangeStyle5.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle5.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle5.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle5.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle5.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle5.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridControl1.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() {GridRangeStyle5})
            Me.gridControl1.RowCount = 6
            Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridControl1.Size = New System.Drawing.Size(604, 162)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.TabIndex = 1
            Me.gridControl1.Text = "gridControl1"
            Me.gridControl1.UseRightToLeftCompatibleTextBox = True
			Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(631, 348)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.groupBox1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
            Me.Text = "Error Provider Demo"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.chkSetError, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkValidate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private groupBox1 As System.Windows.Forms.GroupBox
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private WithEvents chkSetError As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents textBox1 As System.Windows.Forms.TextBox
		Private WithEvents chkValidate As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBox3 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBox2 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBox1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private textBox2 As System.Windows.Forms.TextBox
		Private toolTip1 As System.Windows.Forms.ToolTip
		Private panel1 As System.Windows.Forms.Panel
		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
	End Class
End Namespace

