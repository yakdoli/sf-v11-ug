Imports Microsoft.VisualBasic
Imports System
#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Namespace CardViewDemo
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
			Me.gridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.checkBox4 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.checkBox3 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.checkBox2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.checkBox1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.comboBoxAdv2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.ComboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.checkBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ComboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridDataBoundGrid1
			' 
			Me.gridDataBoundGrid1.AllowDragSelectedCols = True
			Me.gridDataBoundGrid1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridDataBoundGrid1.BackColor = System.Drawing.Color.White
			Me.gridDataBoundGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gridDataBoundGrid1.ForeColor = System.Drawing.SystemColors.ControlText
			Me.gridDataBoundGrid1.Location = New System.Drawing.Point(12, 19)
			Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
			Me.gridDataBoundGrid1.OptimizeInsertRemoveCells = True
			Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
			Me.gridDataBoundGrid1.Size = New System.Drawing.Size(698, 362)
			Me.gridDataBoundGrid1.SmartSizeBox = False
			Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
			Me.gridDataBoundGrid1.TabIndex = 0
			Me.gridDataBoundGrid1.Text = "gridDataBoundGrid1"
			Me.gridDataBoundGrid1.ThemesEnabled = True
			Me.gridDataBoundGrid1.UseListChangedEvent = True
			Me.gridDataBoundGrid1.UseRightToLeftCompatibleTextBox = True
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.checkBox4)
			Me.panel1.Controls.Add(Me.checkBox3)
			Me.panel1.Controls.Add(Me.checkBox2)
			Me.panel1.Controls.Add(Me.checkBox1)
			Me.panel1.Controls.Add(Me.groupBox1)
			Me.panel1.Location = New System.Drawing.Point(716, 19)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(174, 362)
			Me.panel1.TabIndex = 2
			' 
			' checkBox4
			' 
            Me.checkBox4.Checked = True
			Me.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox4.DrawFocusRectangle = False
			Me.checkBox4.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox4.Location = New System.Drawing.Point(15, 121)
			Me.checkBox4.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.checkBox4.Name = "checkBox4"
			Me.checkBox4.Size = New System.Drawing.Size(141, 21)
			Me.checkBox4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBox4.TabIndex = 4
			Me.checkBox4.Text = "BrowseOnly"
            Me.checkBox4.ThemesEnabled = False
            ' 
			' checkBox3
			' 
            Me.checkBox3.Checked = False
            Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Unchecked
			Me.checkBox3.DrawFocusRectangle = False
			Me.checkBox3.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox3.Location = New System.Drawing.Point(15, 85)
			Me.checkBox3.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.checkBox3.Name = "checkBox3"
			Me.checkBox3.Size = New System.Drawing.Size(141, 18)
			Me.checkBox3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBox3.TabIndex = 3
			Me.checkBox3.Text = "ApplyRoundedCorner"
            Me.checkBox3.ThemesEnabled = False
            ' 
			' checkBox2
			' 
			Me.checkBox2.Checked = True
			Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox2.DrawFocusRectangle = False
			Me.checkBox2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox2.Location = New System.Drawing.Point(15, 50)
			Me.checkBox2.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.checkBox2.Name = "checkBox2"
			Me.checkBox2.Size = New System.Drawing.Size(141, 17)
			Me.checkBox2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBox2.TabIndex = 2
			Me.checkBox2.Text = "ShowCaption"
            Me.checkBox2.ThemesEnabled = False
            ' 
			' checkBox1
			' 
			Me.checkBox1.Checked = True
			Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox1.DrawFocusRectangle = False
			Me.checkBox1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox1.Location = New System.Drawing.Point(15, 12)
			Me.checkBox1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(141, 18)
			Me.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.checkBox1.TabIndex = 1
			Me.checkBox1.Text = "ShowCardCellBorders"
            Me.checkBox1.ThemesEnabled = False
            ' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Controls.Add(Me.comboBoxAdv2)
			Me.groupBox1.Controls.Add(Me.ComboBoxAdv1)
			Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox1.Location = New System.Drawing.Point(5, 159)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(165, 135)
			Me.groupBox1.TabIndex = 0
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Style"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Location = New System.Drawing.Point(10, 71)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(55, 13)
			Me.label2.TabIndex = 3
			Me.label2.Text = "CardStyle"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(10, 20)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(65, 13)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Visual Style"
			' 
			' comboBoxAdv2
			' 
			Me.comboBoxAdv2.BackColor = System.Drawing.Color.White
			Me.comboBoxAdv2.Items.AddRange(New Object() { "StandardLabels", "MergedLabels"})
			Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "StandardLabels"))
			Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "MergedLabels"))
			Me.comboBoxAdv2.Location = New System.Drawing.Point(30, 95)
			Me.comboBoxAdv2.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.comboBoxAdv2.Name = "comboBoxAdv2"
			Me.comboBoxAdv2.Size = New System.Drawing.Size(121, 23)
			Me.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
			Me.comboBoxAdv2.TabIndex = 1
            ' 
			' ComboBoxAdv1
			' 
			Me.ComboBoxAdv1.BackColor = System.Drawing.Color.White
			Me.ComboBoxAdv1.Items.AddRange(New Object() { "Office2010Blue", "Office2010Black", "Office2010Silver", "Office2007Blue", "Office2007Black", "Office2007Silver", "Metro", "System", "None"})
			Me.ComboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.ComboBoxAdv1, "Office2010Blue"))
			Me.ComboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.ComboBoxAdv1, "Office2010Black"))
			Me.ComboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.ComboBoxAdv1, "Office2010Silver"))
			Me.ComboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.ComboBoxAdv1, "Office2007Blue"))
			Me.ComboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.ComboBoxAdv1, "Office2007Black"))
			Me.ComboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.ComboBoxAdv1, "Office2007Silver"))
			Me.ComboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.ComboBoxAdv1, "Metro"))
			Me.ComboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.ComboBoxAdv1, "System"))
			Me.ComboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.ComboBoxAdv1, "None"))
			Me.ComboBoxAdv1.Location = New System.Drawing.Point(30, 42)
			Me.ComboBoxAdv1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.ComboBoxAdv1.Name = "ComboBoxAdv1"
			Me.ComboBoxAdv1.Size = New System.Drawing.Size(121, 23)
			Me.ComboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
			Me.ComboBoxAdv1.TabIndex = 0
            ' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.ClientSize = New System.Drawing.Size(902, 393)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.gridDataBoundGrid1)
			Me.DropShadow = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.Text = "Card View Demo"
			CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			CType(Me.checkBox4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ComboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents checkBox4 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBox3 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBox2 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBox1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private WithEvents ComboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private WithEvents comboBoxAdv2 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
	End Class
End Namespace

