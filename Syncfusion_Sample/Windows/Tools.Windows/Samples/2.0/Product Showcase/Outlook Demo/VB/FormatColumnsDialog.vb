Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping

Namespace OutlookDemo
	''' <summary>
	''' Summary description for FormatColumnsDialog.
	''' </summary>
	Public Class FormatColumnsDialog : Inherits System.Windows.Forms.Form
		Private label1 As System.Windows.Forms.Label
		Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton2 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton3 As System.Windows.Forms.RadioButton
		Private tabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
		Private tabPageAdv1 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabPageAdv2 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private xpTaskBar1 As Syncfusion.Windows.Forms.Tools.XPTaskBar
		Private xpTaskBarBox1 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
		Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private label6 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private colorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
		Private colorPickerButton2 As Syncfusion.Windows.Forms.ColorPickerButton
		Private tabPageAdv3 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private label3 As System.Windows.Forms.Label
		Private listBox1 As System.Windows.Forms.ListBox
		Private WithEvents button1 As System.Windows.Forms.Button
		Private button2 As System.Windows.Forms.Button
		Private groupingGrid As GridGroupingControl
		Private comboBox1 As System.Windows.Forms.ComboBox
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents btnNew As System.Windows.Forms.Button
		Private WithEvents btnDelete As System.Windows.Forms.Button
		Private descColl As GridColumnDescriptorCollection
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New(ByVal grid As GridGroupingControl)
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Me.groupingGrid=grid
			descColl = New GridColumnDescriptorCollection()
			Dim i As Integer = 1
'ORIGINAL LINE: for (int i = 1; i < Me.groupingGrid.TableDescriptor.VisibleColumns.Count; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i < Me.groupingGrid.TableDescriptor.VisibleColumns.Count
				Dim col As GridVisibleColumnDescriptor = Me.groupingGrid.TableDescriptor.VisibleColumns(i)
				If Not col Is Nothing Then
					Me.comboBox1.Items.Add(col.Name)
				End If
				i += 1
			Loop
			AddHandler listBox1.SelectedIndexChanged, AddressOf listBox1_SelectedIndexChanged
			AddHandler colorPickerButton1.ColorSelected, AddressOf colorPickerButton1_ColorSelected
			AddHandler colorPickerButton2.ColorSelected, AddressOf colorPickerButton2_ColorSelected

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
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
			Me.label1 = New System.Windows.Forms.Label()
			Me.radioButton1 = New System.Windows.Forms.RadioButton()
			Me.radioButton2 = New System.Windows.Forms.RadioButton()
			Me.radioButton3 = New System.Windows.Forms.RadioButton()
			Me.tabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
			Me.tabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.checkBox3 = New System.Windows.Forms.CheckBox()
			Me.checkBox2 = New System.Windows.Forms.CheckBox()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.tabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.colorPickerButton2 = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.label7 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.tabPageAdv3 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.xpTaskBar1 = New Syncfusion.Windows.Forms.Tools.XPTaskBar()
			Me.xpTaskBarBox1 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.listBox1 = New System.Windows.Forms.ListBox()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.btnDelete = New System.Windows.Forms.Button()
			Me.btnNew = New System.Windows.Forms.Button()
			CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tabControlAdv1.SuspendLayout()
			Me.tabPageAdv1.SuspendLayout()
			Me.groupBox1.SuspendLayout()
			Me.tabPageAdv2.SuspendLayout()
			Me.tabPageAdv3.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskBar1.SuspendLayout()
			Me.xpTaskBarBox1.SuspendLayout()
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel1.SuspendLayout()
			Me.groupBox3.SuspendLayout()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(8, 24)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(80, 24)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Select  Field:"
			' 
			' radioButton1
			' 
			Me.radioButton1.Checked = True
			Me.radioButton1.Location = New System.Drawing.Point(16, 16)
			Me.radioButton1.Name = "radioButton1"
			Me.radioButton1.Size = New System.Drawing.Size(48, 16)
			Me.radioButton1.TabIndex = 4
			Me.radioButton1.TabStop = True
			Me.radioButton1.Text = "Left"
'			Me.radioButton1.CheckedChanged += New System.EventHandler(Me.radioButton1_CheckedChanged);
			' 
			' radioButton2
			' 
			Me.radioButton2.Location = New System.Drawing.Point(80, 16)
			Me.radioButton2.Name = "radioButton2"
			Me.radioButton2.Size = New System.Drawing.Size(56, 16)
			Me.radioButton2.TabIndex = 5
			Me.radioButton2.Text = "Center"
'			Me.radioButton2.CheckedChanged += New System.EventHandler(Me.radioButton2_CheckedChanged);
			' 
			' radioButton3
			' 
			Me.radioButton3.Location = New System.Drawing.Point(152, 16)
			Me.radioButton3.Name = "radioButton3"
			Me.radioButton3.Size = New System.Drawing.Size(56, 16)
			Me.radioButton3.TabIndex = 6
			Me.radioButton3.Text = "Right"
'			Me.radioButton3.CheckedChanged += New System.EventHandler(Me.radioButton3_CheckedChanged);
			' 
			' tabControlAdv1
			' 
			Me.tabControlAdv1.ActiveTabFont = New System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold)
			Me.tabControlAdv1.BackColor = System.Drawing.Color.White
			Me.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.tabControlAdv1.Controls.Add(Me.tabPageAdv1)
			Me.tabControlAdv1.Controls.Add(Me.tabPageAdv2)
			Me.tabControlAdv1.Controls.Add(Me.tabPageAdv3)
			Me.tabControlAdv1.FocusOnTabClick = False
			Me.tabControlAdv1.Location = New System.Drawing.Point(0, 0)
			Me.tabControlAdv1.Name = "tabControlAdv1"
			Me.tabControlAdv1.Size = New System.Drawing.Size(256, 104)
			Me.tabControlAdv1.TabIndex = 8
			Me.tabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2003)
			' 
			' tabPageAdv1
			' 
			Me.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(215)))), (CInt((CByte(215)))), (CInt((CByte(229)))))
			Me.tabPageAdv1.Controls.Add(Me.groupBox1)
			Me.tabPageAdv1.Location = New System.Drawing.Point(1, 32)
			Me.tabPageAdv1.Name = "tabPageAdv1"
			Me.tabPageAdv1.Size = New System.Drawing.Size(254, 71)
			Me.tabPageAdv1.TabIndex = 1
			Me.tabPageAdv1.Text = "Font"
			Me.tabPageAdv1.ThemesEnabled = False
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.checkBox3)
			Me.groupBox1.Controls.Add(Me.checkBox2)
			Me.groupBox1.Controls.Add(Me.checkBox1)
			Me.groupBox1.Location = New System.Drawing.Point(8, 0)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(224, 48)
			Me.groupBox1.TabIndex = 3
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "Font Style"
			' 
			' checkBox3
			' 
			Me.checkBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox3.Location = New System.Drawing.Point(128, 16)
			Me.checkBox3.Name = "checkBox3"
			Me.checkBox3.Size = New System.Drawing.Size(72, 24)
			Me.checkBox3.TabIndex = 2
			Me.checkBox3.Text = "Underline"
'			Me.checkBox3.CheckedChanged += New System.EventHandler(Me.checkBox3_CheckedChanged);
			' 
			' checkBox2
			' 
			Me.checkBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox2.Location = New System.Drawing.Point(72, 16)
			Me.checkBox2.Name = "checkBox2"
			Me.checkBox2.Size = New System.Drawing.Size(56, 24)
			Me.checkBox2.TabIndex = 1
			Me.checkBox2.Text = "Italic"
'			Me.checkBox2.CheckedChanged += New System.EventHandler(Me.checkBox2_CheckedChanged);
			' 
			' checkBox1
			' 
			Me.checkBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBox1.Location = New System.Drawing.Point(8, 16)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(64, 24)
			Me.checkBox1.TabIndex = 0
			Me.checkBox1.Text = "Bold"
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged);
			' 
			' tabPageAdv2
			' 
			Me.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(215)))), (CInt((CByte(215)))), (CInt((CByte(229)))))
			Me.tabPageAdv2.Controls.Add(Me.colorPickerButton2)
			Me.tabPageAdv2.Controls.Add(Me.colorPickerButton1)
			Me.tabPageAdv2.Controls.Add(Me.label7)
			Me.tabPageAdv2.Controls.Add(Me.label6)
			Me.tabPageAdv2.Location = New System.Drawing.Point(1, 32)
			Me.tabPageAdv2.Name = "tabPageAdv2"
			Me.tabPageAdv2.Size = New System.Drawing.Size(254, 71)
			Me.tabPageAdv2.TabIndex = 1
			Me.tabPageAdv2.Text = "Color"
			Me.tabPageAdv2.ThemesEnabled = False
			' 
			' colorPickerButton2
			' 
			Me.colorPickerButton2.BackColor = System.Drawing.SystemColors.Control
			Me.colorPickerButton2.ColorUISize = New System.Drawing.Size(208, 230)
			Me.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.colorPickerButton2.Location = New System.Drawing.Point(96, 40)
			Me.colorPickerButton2.Name = "colorPickerButton2"
			Me.colorPickerButton2.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
			Me.colorPickerButton2.Size = New System.Drawing.Size(152, 24)
			Me.colorPickerButton2.TabIndex = 3
			Me.colorPickerButton2.Text = "None"
			' 
			' colorPickerButton1
			' 
			Me.colorPickerButton1.BackColor = System.Drawing.SystemColors.Control
			Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
			Me.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.colorPickerButton1.Location = New System.Drawing.Point(96, 8)
			Me.colorPickerButton1.Name = "colorPickerButton1"
			Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
			Me.colorPickerButton1.Size = New System.Drawing.Size(152, 24)
			Me.colorPickerButton1.TabIndex = 2
			Me.colorPickerButton1.Text = "None"
			' 
			' label7
			' 
			Me.label7.Location = New System.Drawing.Point(8, 40)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(72, 16)
			Me.label7.TabIndex = 1
			Me.label7.Text = "Background:"
			' 
			' label6
			' 
			Me.label6.Location = New System.Drawing.Point(8, 8)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(72, 23)
			Me.label6.TabIndex = 0
			Me.label6.Text = "Text:"
			' 
			' tabPageAdv3
			' 
			Me.tabPageAdv3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(215)))), (CInt((CByte(215)))), (CInt((CByte(229)))))
			Me.tabPageAdv3.Controls.Add(Me.groupBox2)
			Me.tabPageAdv3.Location = New System.Drawing.Point(1, 32)
			Me.tabPageAdv3.Name = "tabPageAdv3"
			Me.tabPageAdv3.Size = New System.Drawing.Size(254, 71)
			Me.tabPageAdv3.TabIndex = 2
			Me.tabPageAdv3.Text = "Alignment"
			Me.tabPageAdv3.ThemesEnabled = False
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.radioButton1)
			Me.groupBox2.Controls.Add(Me.radioButton2)
			Me.groupBox2.Controls.Add(Me.radioButton3)
			Me.groupBox2.Location = New System.Drawing.Point(8, 8)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(232, 48)
			Me.groupBox2.TabIndex = 0
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Align"
			' 
			' xpTaskBar1
			' 
			Me.xpTaskBar1.AutoPersistStates = True
			Me.xpTaskBar1.Controls.Add(Me.xpTaskBarBox1)
			Me.xpTaskBar1.Enabled = False
			Me.xpTaskBar1.Location = New System.Drawing.Point(8, 56)
			Me.xpTaskBar1.MinimumSize = New System.Drawing.Size(0, 0)
			Me.xpTaskBar1.Name = "xpTaskBar1"
			Me.xpTaskBar1.Size = New System.Drawing.Size(264, 136)
			Me.xpTaskBar1.TabIndex = 8
			' 
			' xpTaskBarBox1
			' 
			Me.xpTaskBarBox1.Controls.Add(Me.gradientPanel1)
			Me.xpTaskBarBox1.HeaderBackColor = System.Drawing.Color.Silver
			Me.xpTaskBarBox1.HeaderForeColor = System.Drawing.SystemColors.ControlText
			Me.xpTaskBarBox1.HeaderImageIndex = -1
			Me.xpTaskBarBox1.HitTaskBoxArea = False
			Me.xpTaskBarBox1.ItemBackColor = System.Drawing.Color.AliceBlue
			Me.xpTaskBarBox1.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskBarBox1.Name = "xpTaskBarBox1"
			Me.xpTaskBarBox1.PreferredChildPanelHeight = 110
			Me.xpTaskBarBox1.Size = New System.Drawing.Size(264, 140)
			Me.xpTaskBarBox1.TabIndex = 0
			Me.xpTaskBarBox1.Text = "Appearance"
			' 
			' gradientPanel1
			' 
			Me.gradientPanel1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(246)))), (CInt((CByte(246)))), (CInt((CByte(252)))))
			Me.gradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
			Me.gradientPanel1.BorderColor = System.Drawing.Color.Black
			Me.gradientPanel1.Controls.Add(Me.tabControlAdv1)
			Me.gradientPanel1.Location = New System.Drawing.Point(2, 28)
			Me.gradientPanel1.Name = "gradientPanel1"
			Me.gradientPanel1.Size = New System.Drawing.Size(260, 110)
			Me.gradientPanel1.TabIndex = 0
			' 
			' groupBox3
			' 
			Me.groupBox3.Controls.Add(Me.comboBox1)
			Me.groupBox3.Controls.Add(Me.label1)
			Me.groupBox3.Controls.Add(Me.xpTaskBar1)
			Me.groupBox3.Location = New System.Drawing.Point(144, 32)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(280, 200)
			Me.groupBox3.TabIndex = 1
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "Settings"
			' 
			' comboBox1
			' 
			Me.comboBox1.Location = New System.Drawing.Point(104, 24)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(152, 21)
			Me.comboBox1.TabIndex = 9
			Me.comboBox1.Text = "(none)"
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(8, 8)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(128, 24)
			Me.label3.TabIndex = 2
			Me.label3.Text = "Formats Created"
			' 
			' listBox1
			' 
			Me.listBox1.Location = New System.Drawing.Point(8, 32)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(128, 199)
			Me.listBox1.TabIndex = 3
			' 
			' button1
			' 
			Me.button1.BackColor = System.Drawing.SystemColors.Control
			Me.button1.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button1.Location = New System.Drawing.Point(272, 256)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75, 23)
			Me.button1.TabIndex = 4
			Me.button1.Text = "OK"
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' button2
			' 
			Me.button2.BackColor = System.Drawing.SystemColors.Control
			Me.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button2.Location = New System.Drawing.Point(360, 256)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(75, 23)
			Me.button2.TabIndex = 5
			Me.button2.Text = "Cancel"
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.btnDelete)
			Me.panel1.Controls.Add(Me.btnNew)
			Me.panel1.Controls.Add(Me.listBox1)
			Me.panel1.Controls.Add(Me.label3)
			Me.panel1.Controls.Add(Me.groupBox3)
			Me.panel1.Location = New System.Drawing.Point(8, 8)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(432, 240)
			Me.panel1.TabIndex = 6
			' 
			' btnDelete
			' 
			Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
			Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.btnDelete.Location = New System.Drawing.Point(224, 8)
			Me.btnDelete.Name = "btnDelete"
			Me.btnDelete.Size = New System.Drawing.Size(75, 23)
			Me.btnDelete.TabIndex = 5
			Me.btnDelete.Text = "Delete"
'			Me.btnDelete.Click += New System.EventHandler(Me.btnDelete_Click);
			' 
			' btnNew
			' 
			Me.btnNew.BackColor = System.Drawing.SystemColors.Control
			Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.btnNew.Location = New System.Drawing.Point(144, 8)
			Me.btnNew.Name = "btnNew"
			Me.btnNew.Size = New System.Drawing.Size(75, 23)
			Me.btnNew.TabIndex = 4
			Me.btnNew.Text = "New"
'			Me.btnNew.Click += New System.EventHandler(Me.btnNew_Click);
			' 
			' FormatColumnsDialog
			' 
			Me.AcceptButton = Me.button1
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(209)))), (CInt((CByte(209)))), (CInt((CByte(223)))))
			Me.CancelButton = Me.button2
			Me.ClientSize = New System.Drawing.Size(450, 288)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "FormatColumnsDialog"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Format Columns"
			CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tabControlAdv1.ResumeLayout(False)
			Me.tabPageAdv1.ResumeLayout(False)
			Me.groupBox1.ResumeLayout(False)
			Me.tabPageAdv2.ResumeLayout(False)
			Me.tabPageAdv3.ResumeLayout(False)
			Me.groupBox2.ResumeLayout(False)
			CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskBar1.ResumeLayout(False)
			Me.xpTaskBarBox1.ResumeLayout(False)
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel1.ResumeLayout(False)
			Me.groupBox3.ResumeLayout(False)
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub listBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Not Me.listBox1.SelectedItem Is Nothing Then
				Me.xpTaskBar1.Enabled=True
				For Each des As GridColumnDescriptor In descColl
					If des.Name.CompareTo(Me.listBox1.SelectedItem.ToString())=0 Then
						If Not des Is Nothing Then
							Me.checkBox1.Checked=des.Appearance.AnyRecordFieldCell.Font.Bold
							Me.checkBox2.Checked=des.Appearance.AnyRecordFieldCell.Font.Italic
							Me.checkBox3.Checked=des.Appearance.AnyRecordFieldCell.Font.Underline

							Me.colorPickerButton1.SelectedColor=des.Appearance.AnyRecordFieldCell.TextColor
							Me.colorPickerButton2.SelectedColor=des.Appearance.AnyRecordFieldCell.BackColor

							If des.Appearance.AnyRecordFieldCell.HorizontalAlignment=GridHorizontalAlignment.Left Then
								Me.radioButton1.Checked=True
							Else If des.Appearance.AnyRecordFieldCell.HorizontalAlignment=GridHorizontalAlignment.Center Then
								Me.radioButton2.Checked=True
							Else
								Me.radioButton3.Checked=True
							End If
						End If
					End If
				Next des
			Else
				Me.xpTaskBar1.Enabled=False
			End If
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			For Each des As GridColumnDescriptor In descColl
				If Not des Is Nothing Then
					Dim temp As GridColumnDescriptor=groupingGrid.TableDescriptor.Columns.FindByMappingName(des.Name)
					temp.Appearance.AnyRecordFieldCell=des.Appearance.AnyRecordFieldCell
				End If
			Next des
		End Sub


		Private Sub btnNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNew.Click
			If Me.comboBox1.SelectedItem Is Nothing Then
				MessageBox.Show("Select a field")
			Else
				Dim descName As String=Me.comboBox1.SelectedItem.ToString()
				Dim flag As Boolean=False
				For Each des As GridColumnDescriptor In descColl
					If des.Name.CompareTo(descName)=0 Then
						flag=True
						Exit For
					End If
				Next des
				If (Not flag) Then
					Dim desc1 As GridColumnDescriptor = New GridColumnDescriptor(descName)
					descColl.Add(desc1)
					Me.listBox1.Items.Add(desc1.Name)
				Else
					MessageBox.Show("Selected Field has already been added")
				End If
			End If
		End Sub

		Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
			If Not Me.listBox1.SelectedItem Is Nothing Then
				Dim temp As String=Me.listBox1.SelectedItem.ToString()
				For Each des As GridColumnDescriptor In descColl
					If des.Name.CompareTo(temp)=0 Then
						descColl.Remove(temp)
						Exit For
					End If
				Next des
				Me.listBox1.Items.Remove(temp)
			Else
				MessageBox.Show("Select a field")
			End If
		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
			If Not Me.listBox1.SelectedItem Is Nothing Then
				Dim temp As String=Me.listBox1.SelectedItem.ToString()
				Dim tDesc As GridColumnDescriptor=descColl(temp)
				If checkBox1.Checked Then
					tDesc.Appearance.AnyRecordFieldCell.Font.Bold=True
				Else
					tDesc.Appearance.AnyRecordFieldCell.Font.Bold=False
				End If
			End If
		End Sub

		Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
			If Not Me.listBox1.SelectedItem Is Nothing Then
				Dim temp As String=Me.listBox1.SelectedItem.ToString()
				Dim tDesc As GridColumnDescriptor=descColl(temp)
				If checkBox2.Checked Then
					tDesc.Appearance.AnyRecordFieldCell.Font.Italic=True
				Else
					tDesc.Appearance.AnyRecordFieldCell.Font.Italic=False
				End If
			End If
		End Sub

		Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
			If Not Me.listBox1.SelectedItem Is Nothing Then
				Dim temp As String=Me.listBox1.SelectedItem.ToString()
				Dim tDesc As GridColumnDescriptor=descColl(temp)
				If checkBox3.Checked Then
					tDesc.Appearance.AnyRecordFieldCell.Font.Underline=True
				Else
					tDesc.Appearance.AnyRecordFieldCell.Font.Underline=False
				End If
			End If
		End Sub

		Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton1.CheckedChanged
			If Not Me.listBox1.SelectedItem Is Nothing Then
				Dim temp As String=Me.listBox1.SelectedItem.ToString()
				Dim tDesc As GridColumnDescriptor=descColl(temp)
				If radioButton1.Checked Then
					tDesc.Appearance.AnyRecordFieldCell.HorizontalAlignment=GridHorizontalAlignment.Left
				End If
			End If
		End Sub

		Private Sub radioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton2.CheckedChanged
			If Not Me.listBox1.SelectedItem Is Nothing Then
				Dim temp As String=Me.listBox1.SelectedItem.ToString()
				Dim tDesc As GridColumnDescriptor=descColl(temp)
				If radioButton2.Checked Then
					tDesc.Appearance.AnyRecordFieldCell.HorizontalAlignment=GridHorizontalAlignment.Center
				End If
			End If
		End Sub

		Private Sub radioButton3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton3.CheckedChanged
			If Not Me.listBox1.SelectedItem Is Nothing Then
				Dim temp As String=Me.listBox1.SelectedItem.ToString()
				Dim tDesc As GridColumnDescriptor=descColl(temp)
				If radioButton3.Checked Then
					tDesc.Appearance.AnyRecordFieldCell.HorizontalAlignment=GridHorizontalAlignment.Right
				End If
			End If
		End Sub

		Private Sub colorPickerButton1_ColorSelected(ByVal sender As Object, ByVal e As EventArgs)
			Me.colorPickerButton1.SelectedAsText = True
			If Not Me.listBox1.SelectedItem Is Nothing Then
				Dim temp As String=Me.listBox1.SelectedItem.ToString()
				descColl(temp).Appearance.AnyRecordFieldCell.TextColor=Me.colorPickerButton1.SelectedColor
			End If
		End Sub

		Private Sub colorPickerButton2_ColorSelected(ByVal sender As Object, ByVal e As EventArgs)
			Me.colorPickerButton2.SelectedAsText = True
			If Not Me.listBox1.SelectedItem Is Nothing Then
				Dim temp As String=Me.listBox1.SelectedItem.ToString()
				descColl(temp).Appearance.AnyRecordFieldCell.TextColor=Me.colorPickerButton1.SelectedColor
			End If
		End Sub
	End Class
End Namespace
