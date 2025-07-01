Imports Microsoft.VisualBasic
Imports System
Namespace FindReplaceDemo_2005
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
			Me.grpBoxFindReplace = New System.Windows.Forms.GroupBox()
			Me.btnReset = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.cmbBoxReplace = New System.Windows.Forms.ComboBox()
			Me.cmbBoxSearch = New System.Windows.Forms.ComboBox()
			Me.cmbBoxOptions = New System.Windows.Forms.ComboBox()
			Me.btnFindAll = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.chkBoxSearchUp = New System.Windows.Forms.CheckBox()
			Me.chkBoxMatchWholeCell = New System.Windows.Forms.CheckBox()
			Me.chkBoxMatchCase = New System.Windows.Forms.CheckBox()
			Me.btnReplaceAll = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.btnReplace = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.lblReplaceWith = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.btnFindNext = New Syncfusion.Windows.Forms.ButtonAdv()
			CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.grpBoxFindReplace.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridDataBoundGrid1
			' 
			Me.gridDataBoundGrid1.AllowDragSelectedCols = True
			Me.gridDataBoundGrid1.GridLineColor = System.Drawing.SystemColors.GrayText
			Me.gridDataBoundGrid1.Location = New System.Drawing.Point(0, 0)
			Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
			Me.gridDataBoundGrid1.OptimizeInsertRemoveCells = True
			Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
			Me.gridDataBoundGrid1.Size = New System.Drawing.Size(671, 331)
			Me.gridDataBoundGrid1.SmartSizeBox = False
			Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
			Me.gridDataBoundGrid1.TabIndex = 0
			Me.gridDataBoundGrid1.Text = "gridDataBoundGrid1"
			Me.gridDataBoundGrid1.ThemesEnabled = True
			Me.gridDataBoundGrid1.UseListChangedEvent = True
			Me.gridDataBoundGrid1.UseRightToLeftCompatibleTextBox = True
			' 
			' grpBoxFindReplace
			' 
			Me.grpBoxFindReplace.AutoSize = True
			Me.grpBoxFindReplace.BackColor = System.Drawing.Color.LightBlue
			Me.grpBoxFindReplace.Controls.Add(Me.btnReset)
			Me.grpBoxFindReplace.Controls.Add(Me.cmbBoxReplace)
			Me.grpBoxFindReplace.Controls.Add(Me.cmbBoxSearch)
			Me.grpBoxFindReplace.Controls.Add(Me.cmbBoxOptions)
			Me.grpBoxFindReplace.Controls.Add(Me.btnFindAll)
			Me.grpBoxFindReplace.Controls.Add(Me.chkBoxSearchUp)
			Me.grpBoxFindReplace.Controls.Add(Me.chkBoxMatchWholeCell)
			Me.grpBoxFindReplace.Controls.Add(Me.chkBoxMatchCase)
			Me.grpBoxFindReplace.Controls.Add(Me.btnReplaceAll)
			Me.grpBoxFindReplace.Controls.Add(Me.btnReplace)
			Me.grpBoxFindReplace.Controls.Add(Me.lblReplaceWith)
			Me.grpBoxFindReplace.Controls.Add(Me.label5)
			Me.grpBoxFindReplace.Controls.Add(Me.btnFindNext)
			Me.grpBoxFindReplace.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.grpBoxFindReplace.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.grpBoxFindReplace.Location = New System.Drawing.Point(6, 337)
			Me.grpBoxFindReplace.Name = "grpBoxFindReplace"
			Me.grpBoxFindReplace.Size = New System.Drawing.Size(662, 94)
			Me.grpBoxFindReplace.TabIndex = 4
			Me.grpBoxFindReplace.TabStop = False
			' 
			' btnReset
			' 
			Me.btnReset.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.btnReset.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.btnReset.Location = New System.Drawing.Point(606, 20)
			Me.btnReset.Name = "btnReset"
			Me.btnReset.Size = New System.Drawing.Size(50, 54)
			Me.btnReset.TabIndex = 14
			Me.btnReset.Text = "Reset"
			Me.btnReset.UseVisualStyle = True
			Me.btnReset.UseVisualStyleBackColor = True
'			Me.btnReset.Click += New System.EventHandler(Me.btnReset_Click)
			' 
			' cmbBoxReplace
			' 
			Me.cmbBoxReplace.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.cmbBoxReplace.FormattingEnabled = True
			Me.cmbBoxReplace.Location = New System.Drawing.Point(85, 49)
			Me.cmbBoxReplace.Name = "cmbBoxReplace"
			Me.cmbBoxReplace.Size = New System.Drawing.Size(123, 22)
			Me.cmbBoxReplace.TabIndex = 13
			' 
			' cmbBoxSearch
			' 
			Me.cmbBoxSearch.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.cmbBoxSearch.FormattingEnabled = True
			Me.cmbBoxSearch.Location = New System.Drawing.Point(85, 21)
			Me.cmbBoxSearch.Name = "cmbBoxSearch"
			Me.cmbBoxSearch.Size = New System.Drawing.Size(123, 22)
			Me.cmbBoxSearch.TabIndex = 12
			' 
			' cmbBoxOptions
			' 
			Me.cmbBoxOptions.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.cmbBoxOptions.FormattingEnabled = True
			Me.cmbBoxOptions.Items.AddRange(New Object() { "ColumnOnly", "SelectionOnly", "WholeTable"})
			Me.cmbBoxOptions.Location = New System.Drawing.Point(294, 52)
			Me.cmbBoxOptions.Name = "cmbBoxOptions"
			Me.cmbBoxOptions.Size = New System.Drawing.Size(123, 22)
			Me.cmbBoxOptions.TabIndex = 11
			' 
			' btnFindAll
			' 
			Me.btnFindAll.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.btnFindAll.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.btnFindAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.btnFindAll.Location = New System.Drawing.Point(521, 20)
			Me.btnFindAll.Name = "btnFindAll"
			Me.btnFindAll.Size = New System.Drawing.Size(81, 23)
			Me.btnFindAll.TabIndex = 10
			Me.btnFindAll.Text = "Find All"
			Me.btnFindAll.UseVisualStyle = True
			Me.btnFindAll.UseVisualStyleBackColor = True
'			Me.btnFindAll.Click += New System.EventHandler(Me.btnFindAll_Click)
			' 
			' chkBoxSearchUp
			' 
			Me.chkBoxSearchUp.AutoSize = True
			Me.chkBoxSearchUp.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.chkBoxSearchUp.Location = New System.Drawing.Point(221, 54)
			Me.chkBoxSearchUp.Name = "chkBoxSearchUp"
			Me.chkBoxSearchUp.Size = New System.Drawing.Size(87, 19)
			Me.chkBoxSearchUp.TabIndex = 9
			Me.chkBoxSearchUp.Text = "Search Up"
			Me.chkBoxSearchUp.UseVisualStyleBackColor = True
			' 
			' chkBoxMatchWholeCell
			' 
			Me.chkBoxMatchWholeCell.AutoSize = True
			Me.chkBoxMatchWholeCell.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.chkBoxMatchWholeCell.Location = New System.Drawing.Point(310, 20)
			Me.chkBoxMatchWholeCell.Name = "chkBoxMatchWholeCell"
			Me.chkBoxMatchWholeCell.Size = New System.Drawing.Size(126, 19)
			Me.chkBoxMatchWholeCell.TabIndex = 8
			Me.chkBoxMatchWholeCell.Text = "Match Whole Cell"
			Me.chkBoxMatchWholeCell.UseVisualStyleBackColor = True
			' 
			' chkBoxMatchCase
			' 
			Me.chkBoxMatchCase.AutoSize = True
			Me.chkBoxMatchCase.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.chkBoxMatchCase.Location = New System.Drawing.Point(221, 20)
			Me.chkBoxMatchCase.Name = "chkBoxMatchCase"
			Me.chkBoxMatchCase.Size = New System.Drawing.Size(96, 19)
			Me.chkBoxMatchCase.TabIndex = 7
			Me.chkBoxMatchCase.Text = "Match Case"
			Me.chkBoxMatchCase.UseVisualStyleBackColor = True
			' 
			' btnReplaceAll
			' 
			Me.btnReplaceAll.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.btnReplaceAll.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.btnReplaceAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.btnReplaceAll.Location = New System.Drawing.Point(521, 52)
			Me.btnReplaceAll.Name = "btnReplaceAll"
			Me.btnReplaceAll.Size = New System.Drawing.Size(81, 23)
			Me.btnReplaceAll.TabIndex = 6
			Me.btnReplaceAll.Text = "Replace All"
			Me.btnReplaceAll.UseVisualStyle = True
			Me.btnReplaceAll.UseVisualStyleBackColor = True
'			Me.btnReplaceAll.Click += New System.EventHandler(Me.btnReplaceAll_Click)
			' 
			' btnReplace
			' 
			Me.btnReplace.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.btnReplace.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.btnReplace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.btnReplace.Location = New System.Drawing.Point(437, 52)
			Me.btnReplace.Name = "btnReplace"
			Me.btnReplace.Size = New System.Drawing.Size(74, 23)
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
			Me.lblReplaceWith.Location = New System.Drawing.Point(8, 52)
			Me.lblReplaceWith.Name = "lblReplaceWith"
			Me.lblReplaceWith.Size = New System.Drawing.Size(77, 14)
			Me.lblReplaceWith.TabIndex = 3
			Me.lblReplaceWith.Text = "Replace With"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(8, 21)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(66, 14)
			Me.label5.TabIndex = 2
			Me.label5.Text = "Search For"
			' 
			' btnFindNext
			' 
			Me.btnFindNext.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.btnFindNext.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
			Me.btnFindNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.btnFindNext.Location = New System.Drawing.Point(437, 20)
			Me.btnFindNext.Name = "btnFindNext"
			Me.btnFindNext.Size = New System.Drawing.Size(74, 23)
			Me.btnFindNext.TabIndex = 1
			Me.btnFindNext.Text = "Find Next"
			Me.btnFindNext.UseVisualStyle = True
			Me.btnFindNext.UseVisualStyleBackColor = True
'			Me.btnFindNext.Click += New System.EventHandler(Me.btnFindNext_Click)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(670, 443)
			Me.Controls.Add(Me.grpBoxFindReplace)
			Me.Controls.Add(Me.gridDataBoundGrid1)
			Me.Name = "Form1"
			Me.Text = "Find and Replace Demo"
			CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.grpBoxFindReplace.ResumeLayout(False)
			Me.grpBoxFindReplace.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private gridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
		Private grpBoxFindReplace As System.Windows.Forms.GroupBox
		Private cmbBoxReplace As System.Windows.Forms.ComboBox
		Private cmbBoxSearch As System.Windows.Forms.ComboBox
		Private cmbBoxOptions As System.Windows.Forms.ComboBox
		Private WithEvents btnFindAll As Syncfusion.Windows.Forms.ButtonAdv
		Private chkBoxSearchUp As System.Windows.Forms.CheckBox
		Private chkBoxMatchWholeCell As System.Windows.Forms.CheckBox
		Private chkBoxMatchCase As System.Windows.Forms.CheckBox
		Private WithEvents btnReplaceAll As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents btnReplace As Syncfusion.Windows.Forms.ButtonAdv
		Private lblReplaceWith As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private WithEvents btnFindNext As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents btnReset As Syncfusion.Windows.Forms.ButtonAdv
	End Class
End Namespace

