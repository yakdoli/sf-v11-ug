#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

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
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.textBox2 = New System.Windows.Forms.TextBox
            Me.label2 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.chkSetError = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.textBox1 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.checkBox4 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBox3 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBox2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBox1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.GridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            Me.groupBox1.SuspendLayout()
            CType(Me.chkSetError, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.textBox2)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Controls.Add(Me.chkSetError)
            Me.groupBox1.Controls.Add(Me.textBox1)
            Me.groupBox1.Controls.Add(Me.checkBox4)
            Me.groupBox1.Controls.Add(Me.checkBox3)
            Me.groupBox1.Controls.Add(Me.checkBox2)
            Me.groupBox1.Controls.Add(Me.checkBox1)
            Me.groupBox1.ForeColor = System.Drawing.Color.Gray
            Me.groupBox1.Location = New System.Drawing.Point(328, 6)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(235, 287)
            Me.groupBox1.TabIndex = 1
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Error Provider Settings"
            '
            'textBox2
            '
            Me.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.textBox2.Location = New System.Drawing.Point(27, 211)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(177, 22)
            Me.textBox2.TabIndex = 20
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(23, 234)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(210, 13)
            Me.label2.TabIndex = 19
            Me.label2.Text = "(The error Messagebox will display this text)"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(23, 166)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(210, 13)
            Me.label1.TabIndex = 18
            Me.label1.Text = "(The error Messagebox will display this text)"
            '
            'chkSetError
            '
            Me.chkSetError.DrawFocusRectangle = False
            Me.chkSetError.Location = New System.Drawing.Point(6, 190)
            Me.chkSetError.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.chkSetError.Name = "chkSetError"
            Me.chkSetError.Size = New System.Drawing.Size(120, 17)
            Me.chkSetError.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.chkSetError.TabIndex = 17
            Me.chkSetError.Text = "Set Custom Error"
            Me.chkSetError.ThemesEnabled = False
            Me.toolTip1.SetToolTip(Me.chkSetError, "This will trigger the CurrentCellValidating event to customize the error")
            '
            'textBox1
            '
            Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.textBox1.Location = New System.Drawing.Point(27, 144)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(177, 22)
            Me.textBox1.TabIndex = 16
            '
            'checkBox4
            '
            Me.checkBox4.DrawFocusRectangle = False
            Me.checkBox4.Location = New System.Drawing.Point(6, 122)
            Me.checkBox4.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(99, 17)
            Me.checkBox4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox4.TabIndex = 15
            Me.checkBox4.Text = "Validation Text"
            Me.checkBox4.ThemesEnabled = False
            '
            'checkBox3
            '
            Me.checkBox3.DrawFocusRectangle = False
            Me.checkBox3.Location = New System.Drawing.Point(6, 48)
            Me.checkBox3.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(171, 29)
            Me.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox3.TabIndex = 14
            Me.checkBox3.Text = "Show Error MessageBox"
            Me.checkBox3.ThemesEnabled = False
            '
            'checkBox2
            '
            Me.checkBox2.DrawFocusRectangle = False
            Me.checkBox2.Location = New System.Drawing.Point(6, 86)
            Me.checkBox2.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(164, 17)
            Me.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox2.TabIndex = 13
            Me.checkBox2.Text = "Show Currentcell Error Icon"
            Me.checkBox2.ThemesEnabled = False
            '
            'checkBox1
            '
            Me.checkBox1.DrawFocusRectangle = False
            Me.checkBox1.Location = New System.Drawing.Point(6, 21)
            Me.checkBox1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(145, 17)
            Me.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox1.TabIndex = 12
            Me.checkBox1.Text = "Show Header Error Icon"
            Me.checkBox1.ThemesEnabled = False
            '
            'GridGroupingControl1
            '
            Me.GridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
            Me.GridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.GridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.GridGroupingControl1.Location = New System.Drawing.Point(10, 6)
            Me.GridGroupingControl1.Name = "GridGroupingControl1"
            Me.GridGroupingControl1.Size = New System.Drawing.Size(302, 287)
            Me.GridGroupingControl1.TabIndex = 2
            Me.GridGroupingControl1.TableDescriptor.AllowNew = False
            Me.GridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
            Me.GridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.GridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.GridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.GridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)))
            Me.GridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.GridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.GridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.GridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.GridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.GridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)))
            Me.GridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
            Me.GridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
            Me.GridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
            Me.GridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
            Me.GridGroupingControl1.Text = "GridDataBoundGrid1"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(575, 303)
            Me.Controls.Add(Me.GridGroupingControl1)
            Me.Controls.Add(Me.groupBox1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.Text = "ErrorProvider"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.chkSetError, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private groupBox1 As System.Windows.Forms.GroupBox
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private WithEvents chkSetError As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents textBox1 As Syncfusion.Windows.Forms.Tools.TextBoxExt
		Private WithEvents checkBox4 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBox3 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBox2 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBox1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private textBox2 As System.Windows.Forms.TextBox
		Private toolTip1 As System.Windows.Forms.ToolTip
		Private GridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
	End Class
End Namespace

