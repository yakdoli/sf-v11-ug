#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Namespace FindReplace
	Partial Public Class GridFindReplaceDialog
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GridFindReplaceDialog))
            Me.panel1 = New System.Windows.Forms.Panel
            Me.ReplaceAllBtn = New Syncfusion.Windows.Forms.ButtonAdv
            Me.txtReplace = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.replaceLabel = New System.Windows.Forms.Label
            Me.comboBox1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.cmbOptions = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.matchAllChkbox = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBox1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.searchupChkbox = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.ReplaceBtn = New Syncfusion.Windows.Forms.ButtonAdv
            Me.matchChkbox = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.cancelbtn = New Syncfusion.Windows.Forms.ButtonAdv
            Me.findallBtn = New Syncfusion.Windows.Forms.ButtonAdv
            Me.findnextBtn = New Syncfusion.Windows.Forms.ButtonAdv
            Me.txtSearch = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.findLabel = New System.Windows.Forms.Label
            Me.panel1.SuspendLayout()
            CType(Me.txtReplace, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmbOptions, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.matchAllChkbox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.searchupChkbox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.matchChkbox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtSearch, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.ReplaceAllBtn)
            Me.panel1.Controls.Add(Me.txtReplace)
            Me.panel1.Controls.Add(Me.replaceLabel)
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Controls.Add(Me.cmbOptions)
            Me.panel1.Controls.Add(Me.matchAllChkbox)
            Me.panel1.Controls.Add(Me.checkBox1)
            Me.panel1.Controls.Add(Me.searchupChkbox)
            Me.panel1.Controls.Add(Me.ReplaceBtn)
            Me.panel1.Controls.Add(Me.matchChkbox)
            Me.panel1.Controls.Add(Me.cancelbtn)
            Me.panel1.Controls.Add(Me.findallBtn)
            Me.panel1.Controls.Add(Me.findnextBtn)
            Me.panel1.Controls.Add(Me.txtSearch)
            Me.panel1.Controls.Add(Me.findLabel)
            Me.panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.panel1.Location = New System.Drawing.Point(12, 12)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(462, 167)
            Me.panel1.TabIndex = 0
            '
            'ReplaceAllBtn
            '
            Me.ReplaceAllBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.ReplaceAllBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ReplaceAllBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
            Me.ReplaceAllBtn.ForeColor = System.Drawing.Color.White
            Me.ReplaceAllBtn.Location = New System.Drawing.Point(361, 63)
            Me.ReplaceAllBtn.Name = "ReplaceAllBtn"
            Me.ReplaceAllBtn.Size = New System.Drawing.Size(75, 23)
            Me.ReplaceAllBtn.TabIndex = 12
            Me.ReplaceAllBtn.Text = "ReplaceAll"
            Me.ReplaceAllBtn.UseVisualStyle = True
            Me.ReplaceAllBtn.UseVisualStyleBackColor = True
            '
            'txtReplace
            '
            Me.txtReplace.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtReplace.Location = New System.Drawing.Point(108, 60)
            Me.txtReplace.Name = "txtReplace"
            Me.txtReplace.Size = New System.Drawing.Size(142, 20)
            Me.txtReplace.TabIndex = 11
            '
            'replaceLabel
            '
            Me.replaceLabel.AutoSize = True
            Me.replaceLabel.ForeColor = System.Drawing.Color.DimGray
            Me.replaceLabel.Location = New System.Drawing.Point(24, 63)
            Me.replaceLabel.Name = "replaceLabel"
            Me.replaceLabel.Size = New System.Drawing.Size(75, 13)
            Me.replaceLabel.TabIndex = 10
            Me.replaceLabel.Text = "Replace with :"
            '
            'comboBox1
            '
            Me.comboBox1.BackColor = System.Drawing.Color.White
            Me.comboBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            Me.comboBox1.Items.AddRange(New Object() {"ColumnOnly", "WholeTable"})
            Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "ColumnOnly"))
            Me.comboBox1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBox1, "WholeTable"))
            Me.comboBox1.Location = New System.Drawing.Point(153, 135)
            Me.comboBox1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(111, 21)
            Me.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
            Me.comboBox1.TabIndex = 3
            '
            'cmbOptions
            '
            Me.cmbOptions.Items.AddRange(New Object() {"ColumnOnly", "WholeTable"})
            Me.cmbOptions.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.cmbOptions, "ColumnOnly"))
            Me.cmbOptions.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.cmbOptions, "WholeTable"))
            Me.cmbOptions.Location = New System.Drawing.Point(153, 135)
            Me.cmbOptions.MetroColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
            Me.cmbOptions.Name = "cmbOptions"
            Me.cmbOptions.Size = New System.Drawing.Size(111, 21)
            Me.cmbOptions.TabIndex = 3
            '
            'matchAllChkbox
            '
            Me.matchAllChkbox.DrawFocusRectangle = False
            Me.matchAllChkbox.ForeColor = System.Drawing.Color.DimGray
            Me.matchAllChkbox.Location = New System.Drawing.Point(27, 139)
            Me.matchAllChkbox.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(218, Byte), Integer))
            Me.matchAllChkbox.Name = "matchAllChkbox"
            Me.matchAllChkbox.Size = New System.Drawing.Size(104, 17)
            Me.matchAllChkbox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.matchAllChkbox.TabIndex = 1
            Me.matchAllChkbox.Text = "MatchWholeCell"
            Me.matchAllChkbox.ThemesEnabled = False
            '
            'checkBox1
            '
            Me.checkBox1.DrawFocusRectangle = False
            Me.checkBox1.ForeColor = System.Drawing.Color.DimGray
            Me.checkBox1.Location = New System.Drawing.Point(153, 108)
            Me.checkBox1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(218, Byte), Integer))
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(77, 17)
            Me.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBox1.TabIndex = 2
            Me.checkBox1.Text = "Search Up"
            Me.checkBox1.ThemesEnabled = False
            '
            'searchupChkbox
            '
            Me.searchupChkbox.Location = New System.Drawing.Point(153, 108)
            Me.searchupChkbox.MetroColor = System.Drawing.Color.Empty
            Me.searchupChkbox.Name = "searchupChkbox"
            Me.searchupChkbox.Size = New System.Drawing.Size(77, 17)
            Me.searchupChkbox.TabIndex = 2
            Me.searchupChkbox.Text = "Search Up"
            Me.searchupChkbox.ThemesEnabled = False
            '
            'ReplaceBtn
            '
            Me.ReplaceBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.ReplaceBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ReplaceBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
            Me.ReplaceBtn.ForeColor = System.Drawing.Color.White
            Me.ReplaceBtn.Location = New System.Drawing.Point(361, 26)
            Me.ReplaceBtn.Name = "ReplaceBtn"
            Me.ReplaceBtn.Size = New System.Drawing.Size(75, 23)
            Me.ReplaceBtn.TabIndex = 9
            Me.ReplaceBtn.Text = "Replace"
            Me.ReplaceBtn.UseVisualStyle = True
            Me.ReplaceBtn.UseVisualStyleBackColor = True
            '
            'matchChkbox
            '
            Me.matchChkbox.DrawFocusRectangle = False
            Me.matchChkbox.ForeColor = System.Drawing.Color.DimGray
            Me.matchChkbox.Location = New System.Drawing.Point(27, 108)
            Me.matchChkbox.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(218, Byte), Integer))
            Me.matchChkbox.Name = "matchChkbox"
            Me.matchChkbox.Size = New System.Drawing.Size(83, 17)
            Me.matchChkbox.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.matchChkbox.TabIndex = 0
            Me.matchChkbox.Text = "Match Case"
            Me.matchChkbox.ThemesEnabled = False
            '
            'cancelbtn
            '
            Me.cancelbtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.cancelbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cancelbtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
            Me.cancelbtn.ForeColor = System.Drawing.Color.White
            Me.cancelbtn.Location = New System.Drawing.Point(316, 108)
            Me.cancelbtn.Name = "cancelbtn"
            Me.cancelbtn.Size = New System.Drawing.Size(75, 23)
            Me.cancelbtn.TabIndex = 7
            Me.cancelbtn.Text = "Cancel"
            Me.cancelbtn.UseVisualStyle = True
            Me.cancelbtn.UseVisualStyleBackColor = True
            '
            'findallBtn
            '
            Me.findallBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.findallBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.findallBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
            Me.findallBtn.ForeColor = System.Drawing.Color.White
            Me.findallBtn.Location = New System.Drawing.Point(269, 63)
            Me.findallBtn.Name = "findallBtn"
            Me.findallBtn.Size = New System.Drawing.Size(75, 23)
            Me.findallBtn.TabIndex = 6
            Me.findallBtn.Text = "Find All"
            Me.findallBtn.UseVisualStyle = True
            Me.findallBtn.UseVisualStyleBackColor = True
            '
            'findnextBtn
            '
            Me.findnextBtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.findnextBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.findnextBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
            Me.findnextBtn.ForeColor = System.Drawing.Color.White
            Me.findnextBtn.Location = New System.Drawing.Point(269, 26)
            Me.findnextBtn.Name = "findnextBtn"
            Me.findnextBtn.Size = New System.Drawing.Size(75, 23)
            Me.findnextBtn.TabIndex = 5
            Me.findnextBtn.Text = "Find Next"
            Me.findnextBtn.UseVisualStyle = True
            Me.findnextBtn.UseVisualStyleBackColor = True
            '
            'txtSearch
            '
            Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtSearch.Location = New System.Drawing.Point(108, 26)
            Me.txtSearch.Name = "txtSearch"
            Me.txtSearch.Size = New System.Drawing.Size(142, 20)
            Me.txtSearch.TabIndex = 1
            '
            'findLabel
            '
            Me.findLabel.AutoSize = True
            Me.findLabel.ForeColor = System.Drawing.Color.DimGray
            Me.findLabel.Location = New System.Drawing.Point(24, 29)
            Me.findLabel.Name = "findLabel"
            Me.findLabel.Size = New System.Drawing.Size(59, 13)
            Me.findLabel.TabIndex = 0
            Me.findLabel.Text = "Find what :"
            '
            'GridFindReplaceDialog
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(485, 193)
            Me.Controls.Add(Me.panel1)
            Me.DropShadow = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "GridFindReplaceDialog"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "GridFindReplaceDialog"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.txtReplace, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmbOptions, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.matchAllChkbox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.searchupChkbox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.matchChkbox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtSearch, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private panel1 As System.Windows.Forms.Panel
        Private txtSearch As Syncfusion.Windows.Forms.Tools.TextBoxExt
		Private findLabel As System.Windows.Forms.Label
        Private matchAllChkbox As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private matchChkbox As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private searchupChkbox As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents findnextBtn As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents findallBtn As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents cancelbtn As Syncfusion.Windows.Forms.ButtonAdv
        Private cmbOptions As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private WithEvents ReplaceBtn As Syncfusion.Windows.Forms.ButtonAdv
        Private txtReplace As Syncfusion.Windows.Forms.Tools.TextBoxExt
		Private replaceLabel As System.Windows.Forms.Label
		Private WithEvents ReplaceAllBtn As Syncfusion.Windows.Forms.ButtonAdv
        Private comboBox1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Private checkBox1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
	End Class
End Namespace