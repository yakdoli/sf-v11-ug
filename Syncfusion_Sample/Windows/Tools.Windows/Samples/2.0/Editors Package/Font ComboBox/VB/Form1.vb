#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region


Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms

Namespace FontComboBoxDemo
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private label1 As System.Windows.Forms.Label
		Private imageList1 As System.Windows.Forms.ImageList
		Private groupBox3 As System.Windows.Forms.Panel
		Private WithEvents radioButton2 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
		Private label3 As System.Windows.Forms.Label
		Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
		Private WithEvents chkAutocomp As System.Windows.Forms.CheckBox
		Private WithEvents fontComboBox2 As Syncfusion.Windows.Forms.Tools.FontComboBox
		Private imageList2 As System.Windows.Forms.ImageList
		Private textBoxExt1 As Syncfusion.Windows.Forms.Tools.TextBoxExt
		Private groupBox1 As System.Windows.Forms.Panel
		Private WithEvents fontComboBox1 As Syncfusion.Windows.Forms.Tools.FontComboBox
		Private label2 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private groupBox2 As System.Windows.Forms.Panel
		Private label5 As System.Windows.Forms.Label
		Private bannerTextProvider1 As Syncfusion.Windows.Forms.BannerTextProvider
		Private WithEvents bannerClrEdit As Syncfusion.Windows.Forms.Tools.ButtonEdit
		Private buttonEditChildButton1 As Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
		Private textBoxExt2 As Syncfusion.Windows.Forms.Tools.TextBoxExt
		Private WithEvents btnSetBanner As Button
		Private cmbMode As ComboBox
		Private txtBanner As TextBox
		Private label9 As Label
		Private label8 As Label
		Private label7 As Label
		Private label6 As Label
		Private colorDialog1 As ColorDialog
		Private label10 As Label
		Private toolTip1 As ToolTip
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			InitializeComponent()
			cmbMode.SelectedIndex = 1
			AddHandler Application.Idle, AddressOf Application_Idle
		End Sub

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.label1 = New System.Windows.Forms.Label
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.groupBox3 = New System.Windows.Forms.Panel
            Me.label10 = New System.Windows.Forms.Label
            Me.bannerClrEdit = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton1 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.textBoxExt2 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.btnSetBanner = New System.Windows.Forms.Button
            Me.cmbMode = New System.Windows.Forms.ComboBox
            Me.txtBanner = New System.Windows.Forms.TextBox
            Me.label9 = New System.Windows.Forms.Label
            Me.label8 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.radioButton2 = New System.Windows.Forms.RadioButton
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.label3 = New System.Windows.Forms.Label
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.chkAutocomp = New System.Windows.Forms.CheckBox
            Me.fontComboBox2 = New Syncfusion.Windows.Forms.Tools.FontComboBox
            Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
            Me.textBoxExt1 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.groupBox1 = New System.Windows.Forms.Panel
            Me.label4 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.fontComboBox1 = New Syncfusion.Windows.Forms.Tools.FontComboBox
            Me.groupBox2 = New System.Windows.Forms.Panel
            Me.bannerTextProvider1 = New Syncfusion.Windows.Forms.BannerTextProvider(Me.components)
            Me.colorDialog1 = New System.Windows.Forms.ColorDialog
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.groupBox3.SuspendLayout()
            CType(Me.bannerClrEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.bannerClrEdit.SuspendLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight
            Me.label1.ImageIndex = 0
            Me.label1.ImageList = Me.imageList1
            Me.label1.Location = New System.Drawing.Point(24, 8)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(528, 65)
            Me.label1.TabIndex = 4
            Me.label1.Text = resources.GetString("label1.Text")
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            '
            'groupBox3
            '
            Me.groupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.groupBox3.Controls.Add(Me.label10)
            Me.groupBox3.Controls.Add(Me.bannerClrEdit)
            Me.groupBox3.Controls.Add(Me.btnSetBanner)
            Me.groupBox3.Controls.Add(Me.cmbMode)
            Me.groupBox3.Controls.Add(Me.txtBanner)
            Me.groupBox3.Controls.Add(Me.label9)
            Me.groupBox3.Controls.Add(Me.label8)
            Me.groupBox3.Controls.Add(Me.label7)
            Me.groupBox3.Controls.Add(Me.label6)
            Me.groupBox3.Controls.Add(Me.label5)
            Me.groupBox3.Controls.Add(Me.radioButton2)
            Me.groupBox3.Controls.Add(Me.radioButton1)
            Me.groupBox3.Controls.Add(Me.label3)
            Me.groupBox3.Controls.Add(Me.numericUpDown1)
            Me.groupBox3.Controls.Add(Me.chkAutocomp)
            Me.groupBox3.Controls.Add(Me.fontComboBox2)
            Me.groupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox3.ForeColor = System.Drawing.Color.Black
            Me.groupBox3.Location = New System.Drawing.Point(12, 104)
            Me.groupBox3.Name = "groupBox3"
            Me.groupBox3.Size = New System.Drawing.Size(265, 285)
            Me.groupBox3.TabIndex = 10
            '
            'label10
            '
            Me.label10.Image = CType(resources.GetObject("label10.Image"), System.Drawing.Image)
            Me.label10.Location = New System.Drawing.Point(129, 187)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(29, 26)
            Me.label10.TabIndex = 2
            Me.toolTip1.SetToolTip(Me.label10, "Banner Text is used to provide" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cue banner help text for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FontComboBox control.")
            '
            'bannerClrEdit
            '
            Me.bannerClrEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.bannerClrEdit.Buttons.Add(Me.buttonEditChildButton1)
            Me.bannerClrEdit.Controls.Add(Me.buttonEditChildButton1)
            Me.bannerClrEdit.Controls.Add(Me.textBoxExt2)
            Me.bannerClrEdit.Location = New System.Drawing.Point(44, 250)
            Me.bannerClrEdit.Name = "bannerClrEdit"
            Me.bannerClrEdit.Size = New System.Drawing.Size(86, 22)
            Me.bannerClrEdit.TabIndex = 14
            Me.bannerClrEdit.TextBox = Me.textBoxExt2
            Me.bannerClrEdit.UseVisualStyle = True
            '
            'buttonEditChildButton1
            '
            Me.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonEditChildButton1.Image = Nothing
            Me.buttonEditChildButton1.Name = "buttonEditChildButton1"
            Me.buttonEditChildButton1.PreferredWidth = 20
            Me.buttonEditChildButton1.TabIndex = 1
            Me.buttonEditChildButton1.Text = "..."
            '
            'textBoxExt2
            '
            Me.textBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBoxExt2.Location = New System.Drawing.Point(2, 4)
            Me.textBoxExt2.Name = "textBoxExt2"
            Me.textBoxExt2.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt2.Size = New System.Drawing.Size(62, 14)
            Me.textBoxExt2.TabIndex = 0
            '
            'btnSetBanner
            '
            Me.btnSetBanner.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnSetBanner.Location = New System.Drawing.Point(144, 250)
            Me.btnSetBanner.Name = "btnSetBanner"
            Me.btnSetBanner.Size = New System.Drawing.Size(103, 23)
            Me.btnSetBanner.TabIndex = 13
            Me.btnSetBanner.Text = "Set Banner Text"
            Me.btnSetBanner.UseVisualStyleBackColor = True
            '
            'cmbMode
            '
            Me.cmbMode.FormattingEnabled = True
            Me.cmbMode.Items.AddRange(New Object() {"EditMode", "FocusMode"})
            Me.cmbMode.Location = New System.Drawing.Point(171, 215)
            Me.cmbMode.Name = "cmbMode"
            Me.cmbMode.Size = New System.Drawing.Size(91, 21)
            Me.cmbMode.TabIndex = 12
            '
            'txtBanner
            '
            Me.txtBanner.Location = New System.Drawing.Point(44, 215)
            Me.txtBanner.Name = "txtBanner"
            Me.txtBanner.Size = New System.Drawing.Size(86, 21)
            Me.txtBanner.TabIndex = 11
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Location = New System.Drawing.Point(8, 250)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(32, 13)
            Me.label9.TabIndex = 10
            Me.label9.Text = "Color"
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Location = New System.Drawing.Point(136, 218)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(33, 13)
            Me.label8.TabIndex = 9
            Me.label8.Text = "Mode"
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(8, 218)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(29, 13)
            Me.label7.TabIndex = 8
            Me.label7.Text = "Text"
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.ForeColor = System.Drawing.Color.Brown
            Me.label6.Location = New System.Drawing.Point(7, 192)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(123, 13)
            Me.label6.TabIndex = 7
            Me.label6.Text = "BannerText Settings"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.Color.Brown
            Me.label5.Location = New System.Drawing.Point(7, 10)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(144, 13)
            Me.label5.TabIndex = 6
            Me.label5.Text = "Another FontComboBox "
            '
            'radioButton2
            '
            Me.radioButton2.Location = New System.Drawing.Point(128, 109)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(96, 16)
            Me.radioButton2.TabIndex = 5
            Me.radioButton2.Text = "DropDownList"
            '
            'radioButton1
            '
            Me.radioButton1.Checked = True
            Me.radioButton1.Location = New System.Drawing.Point(24, 109)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(76, 16)
            Me.radioButton1.TabIndex = 4
            Me.radioButton1.TabStop = True
            Me.radioButton1.Text = "DropDown"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(24, 80)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(113, 13)
            Me.label3.TabIndex = 3
            Me.label3.Text = "No. of Items to Show:"
            '
            'numericUpDown1
            '
            Me.numericUpDown1.Location = New System.Drawing.Point(144, 75)
            Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.ReadOnly = True
            Me.numericUpDown1.Size = New System.Drawing.Size(56, 21)
            Me.numericUpDown1.TabIndex = 2
            Me.numericUpDown1.Value = New Decimal(New Integer() {20, 0, 0, 0})
            '
            'chkAutocomp
            '
            Me.chkAutocomp.Checked = True
            Me.chkAutocomp.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkAutocomp.Location = New System.Drawing.Point(51, 140)
            Me.chkAutocomp.Name = "chkAutocomp"
            Me.chkAutocomp.Size = New System.Drawing.Size(128, 24)
            Me.chkAutocomp.TabIndex = 1
            Me.chkAutocomp.Text = "Use Auto Complete"
            '
            'fontComboBox2
            '
            Me.bannerTextProvider1.SetBannerText(Me.fontComboBox2, New Syncfusion.Windows.Forms.BannerTextInfo("[Select]", True, Nothing, System.Drawing.SystemColors.ControlDark, Syncfusion.Windows.Forms.BannerTextMode.FocusMode))
            Me.fontComboBox2.Location = New System.Drawing.Point(4, 32)
            Me.fontComboBox2.MaxDropDownItems = 25
            Me.fontComboBox2.Name = "fontComboBox2"
            Me.fontComboBox2.Size = New System.Drawing.Size(248, 22)
            Me.fontComboBox2.Sorted = True
            Me.fontComboBox2.TabIndex = 0
            Me.fontComboBox2.UseAutoComplete = True
            '
            'imageList2
            '
            Me.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
            Me.imageList2.ImageSize = New System.Drawing.Size(16, 16)
            Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
            '
            'textBoxExt1
            '
            Me.textBoxExt1.BackColor = System.Drawing.Color.Gainsboro
            Me.textBoxExt1.Location = New System.Drawing.Point(24, 152)
            Me.textBoxExt1.Name = "textBoxExt1"
            Me.textBoxExt1.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt1.Size = New System.Drawing.Size(204, 21)
            Me.textBoxExt1.TabIndex = 3
            '
            'groupBox1
            '
            Me.groupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.fontComboBox1)
            Me.groupBox1.Controls.Add(Me.textBoxExt1)
            Me.groupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.ForeColor = System.Drawing.Color.Black
            Me.groupBox1.Location = New System.Drawing.Point(300, 104)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(272, 285)
            Me.groupBox1.TabIndex = 7
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.BackColor = System.Drawing.Color.Transparent
            Me.label4.Location = New System.Drawing.Point(24, 128)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(137, 13)
            Me.label4.TabIndex = 2
            Me.label4.Text = "Name of The Selected Font"
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.Brown
            Me.label2.Location = New System.Drawing.Point(14, 16)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(245, 32)
            Me.label2.TabIndex = 1
            Me.label2.Text = "FontComboBox with all installed System Fonts"
            '
            'fontComboBox1
            '
            Me.fontComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.fontComboBox1.Location = New System.Drawing.Point(16, 80)
            Me.fontComboBox1.Name = "fontComboBox1"
            Me.fontComboBox1.Size = New System.Drawing.Size(248, 22)
            Me.fontComboBox1.TabIndex = 0
            '
            'groupBox2
            '
            Me.groupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(225, Byte), Integer))
            Me.groupBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.groupBox2.Controls.Add(Me.label1)
            Me.groupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox2.Location = New System.Drawing.Point(8, 8)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(568, 80)
            Me.groupBox2.TabIndex = 11
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(584, 401)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.groupBox3)
            Me.Controls.Add(Me.groupBox1)
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Font ComboBox"
            Me.groupBox3.ResumeLayout(False)
            Me.groupBox3.PerformLayout()
            CType(Me.bannerClrEdit, System.ComponentModel.ISupportInitialize).EndInit()
            Me.bannerClrEdit.ResumeLayout(False)
            Me.bannerClrEdit.PerformLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.groupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
		#End Region

		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		#Region "SelectedIndexChanged"
		Private Sub fontComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fontComboBox1.SelectedIndexChanged
			Me.textBoxExt1.Text = Me.fontComboBox1.SelectedItem.ToString ()
			Me.label2.Font = New Font(Me.fontComboBox1.SelectedItem.ToString (),11,FontStyle.Regular)
			Me.fontComboBox2.SelectedItem = Me.fontComboBox1.SelectedItem
		End Sub

		Private Sub fontComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fontComboBox2.SelectedIndexChanged
			Me.textBoxExt1.Text = Me.fontComboBox2.SelectedItem.ToString ()
			Me.label2.Font = New Font(Me.fontComboBox2.SelectedItem.ToString (),11,FontStyle.Regular)
			Me.fontComboBox1.SelectedItem = Me.fontComboBox2.SelectedItem
		End Sub
		#End Region

		Private Sub chkAutocomp_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAutocomp.CheckedChanged
			Me.fontComboBox2.UseAutoComplete = chkAutocomp.Checked
		End Sub

		Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
			Me.fontComboBox2.MaxDropDownItems = CInt(numericUpDown1.Value)
		End Sub

		Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton1.CheckedChanged
			Me.fontComboBox2.DropDownStyle = ComboBoxStyle.DropDown
			Me.bannerTextProvider1.GetBannerText(Me.fontComboBox2).Visible = True
		End Sub

		Private Sub radioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton2.CheckedChanged
			Me.fontComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
			Me.bannerTextProvider1.GetBannerText(Me.fontComboBox2).Visible = False
		End Sub

		Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
			If txtBanner.Text = "" Then
				btnSetBanner.Enabled = False
			Else
				btnSetBanner.Enabled = True
			End If
		End Sub

		Private Sub bannerClrEdit_ButtonClicked(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs) Handles bannerClrEdit.ButtonClicked
            If colorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                bannerClrEdit.TextBox.BackColor = colorDialog1.Color
            End If
		End Sub

		Private Sub btnSetBanner_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSetBanner.Click
			Dim mode As BannerTextMode = CType(System.Enum.Parse(GetType(BannerTextMode), cmbMode.SelectedItem.ToString()), BannerTextMode)
			Dim binfo As BannerTextInfo = Me.bannerTextProvider1.GetBannerText(Me.fontComboBox2)
			binfo.Text = txtBanner.Text
			binfo.Mode = mode
			binfo.Color = bannerClrEdit.TextBox.BackColor
			Me.fontComboBox2.Refresh()
		End Sub
	End Class
End Namespace
