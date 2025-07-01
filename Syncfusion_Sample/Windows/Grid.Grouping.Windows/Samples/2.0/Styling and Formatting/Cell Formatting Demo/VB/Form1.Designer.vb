#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Namespace FormatCellDialog_2005
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
            Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
            Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.formatCellsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.label1 = New System.Windows.Forms.Label()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.comboBoxAdv2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
            Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.contextMenuStrip1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
            Me.gridGroupingControl1.ContextMenuStrip = Me.contextMenuStrip1
            Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridGroupingControl1.Location = New System.Drawing.Point(12, 12)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.Size = New System.Drawing.Size(376, 403)
            Me.gridGroupingControl1.TabIndex = 0
            Me.gridGroupingControl1.TableDescriptor.AllowNew = False
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)))
            Me.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
            Me.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
            Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
            Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
            Me.gridGroupingControl1.Text = "gridGroupingControl1"
            Me.gridGroupingControl1.VersionInfo = "10.102.0.36"
            '
            'contextMenuStrip1
            '
            Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.formatCellsToolStripMenuItem})
            Me.contextMenuStrip1.Name = "contextMenuStrip1"
            Me.contextMenuStrip1.Size = New System.Drawing.Size(141, 26)
            '
            'formatCellsToolStripMenuItem
            '
            Me.formatCellsToolStripMenuItem.Name = "formatCellsToolStripMenuItem"
            Me.formatCellsToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
            Me.formatCellsToolStripMenuItem.Text = "Format Cells"
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.DimGray
            Me.panel1.ForeColor = System.Drawing.Color.DimGray
            Me.panel1.Location = New System.Drawing.Point(397, 30)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(1, 377)
            Me.panel1.TabIndex = 22
            '
            'propertyGrid1
            '
            Me.propertyGrid1.BackColor = System.Drawing.Color.White
            Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.White
            Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
            Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
            Me.propertyGrid1.LineColor = System.Drawing.Color.White
            Me.propertyGrid1.Location = New System.Drawing.Point(404, 125)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
            Me.propertyGrid1.Size = New System.Drawing.Size(203, 290)
            Me.propertyGrid1.TabIndex = 21
            '
            'panel2
            '
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.Add(Me.label1)
            Me.panel2.Location = New System.Drawing.Point(12, 421)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(595, 46)
            Me.panel2.TabIndex = 23
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.ForeColor = System.Drawing.Color.DimGray
            Me.label1.Location = New System.Drawing.Point(117, 16)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(324, 13)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Click on a cell and right click to open FormatCellDialogue Box"
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.comboBoxAdv2)
            Me.groupBox1.Controls.Add(Me.comboBoxAdv1)
            Me.groupBox1.Location = New System.Drawing.Point(405, 13)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(200, 106)
            Me.groupBox1.TabIndex = 24
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Current Cell Navigation"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(3, 65)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(102, 13)
            Me.label3.TabIndex = 3
            Me.label3.Text = "WrapCell Behavior"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(3, 29)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(99, 13)
            Me.label2.TabIndex = 2
            Me.label2.Text = "EnterKey Behavior"
            '
            'comboBoxAdv2
            '
            Me.comboBoxAdv2.BackColor = System.Drawing.Color.White
            Me.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxAdv2.Location = New System.Drawing.Point(111, 57)
            Me.comboBoxAdv2.MetroColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
            Me.comboBoxAdv2.Name = "comboBoxAdv2"
            Me.comboBoxAdv2.Size = New System.Drawing.Size(83, 21)
            Me.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
            Me.comboBoxAdv2.TabIndex = 1
            '
            'comboBoxAdv1
            '
            Me.comboBoxAdv1.BackColor = System.Drawing.Color.White
            Me.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxAdv1.Location = New System.Drawing.Point(111, 21)
            Me.comboBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
            Me.comboBoxAdv1.Name = "comboBoxAdv1"
            Me.comboBoxAdv1.Size = New System.Drawing.Size(83, 21)
            Me.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
            Me.comboBoxAdv1.TabIndex = 0
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(618, 482)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.propertyGrid1)
            Me.Controls.Add(Me.gridGroupingControl1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.Text = "Cell Formatting Demo"
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.contextMenuStrip1.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
        Private contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
        Private WithEvents formatCellsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private panel1 As System.Windows.Forms.Panel
        Private propertyGrid1 As System.Windows.Forms.PropertyGrid
        Private panel2 As System.Windows.Forms.Panel
        Private label1 As System.Windows.Forms.Label
        Private resources As System.ComponentModel.ComponentResourceManager
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private label3 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private comboBoxAdv2 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Private comboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    End Class
End Namespace

