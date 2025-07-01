Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Windows.Forms.Tools

Namespace ColorUIDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private label1 As System.Windows.Forms.Label
		Private imageList1 As System.Windows.Forms.ImageList
		Private textBox1 As System.Windows.Forms.TextBox
		Private tabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
		Private tabPageAdv1 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabPageAdv2 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabPageAdv3 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private WithEvents colorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
		Private WithEvents colorUIControl1 As Syncfusion.Windows.Forms.ColorUIControl
		Private panel1 As System.Windows.Forms.Panel
		Private label2 As System.Windows.Forms.Label
		Private panel2 As System.Windows.Forms.Panel
		Private label3 As System.Windows.Forms.Label
        Private label4 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private WithEvents txtCustomTabName As System.Windows.Forms.TextBox
		Private WithEvents chkSelectedAsBackColor As System.Windows.Forms.CheckBox
		Private WithEvents chkSelectedAsText As System.Windows.Forms.CheckBox
		Private WithEvents cmbSelectedColorGroup As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private WithEvents txtStandardTabName As System.Windows.Forms.TextBox
		Private WithEvents txtSystemTabName As System.Windows.Forms.TextBox
		Private label10 As System.Windows.Forms.Label
		Private label11 As System.Windows.Forms.Label
		Private label12 As System.Windows.Forms.Label
		Private label13 As System.Windows.Forms.Label
		Private label14 As System.Windows.Forms.Label
		Private WithEvents txtUsersTabName1 As System.Windows.Forms.TextBox
		Private WithEvents txtSystemTabName1 As System.Windows.Forms.TextBox
		Private WithEvents txtStandardTabName1 As System.Windows.Forms.TextBox
		Private WithEvents txtCustomTabName1 As System.Windows.Forms.TextBox
		Private WithEvents cmbSelectedColorGroup1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private WithEvents chkUserColorsStretchOnResize As System.Windows.Forms.CheckBox
		Private label5 As System.Windows.Forms.Label
		Private label15 As System.Windows.Forms.Label
		Private label16 As System.Windows.Forms.Label
		Private WithEvents cmbOffice2007Theme As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private WithEvents chkUseOffice2007Theme As System.Windows.Forms.CheckBox
		Private WithEvents btnShowColorGroups As Syncfusion.Windows.Forms.ButtonAdv
		Private label17 As System.Windows.Forms.Label
		Private label18 As System.Windows.Forms.Label
		Private label19 As System.Windows.Forms.Label
		Private WithEvents numericUpDownExt1 As Syncfusion.Windows.Forms.Tools.NumericUpDownExt
		Private WithEvents numericUpDownExt2 As Syncfusion.Windows.Forms.Tools.NumericUpDownExt
		Private WithEvents numericUpDownExt3 As Syncfusion.Windows.Forms.Tools.NumericUpDownExt
        Private WithEvents colorPickerUIAdv1 As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Private components As System.ComponentModel.IContainer

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            '
            ' TODO: Add any constructor code after InitializeComponent call
            ''
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Me.colorPickerUIAdv1 = New Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv
            Me.label1 = New System.Windows.Forms.Label
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.tabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv
            Me.tabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.txtSystemTabName = New System.Windows.Forms.TextBox
            Me.txtStandardTabName = New System.Windows.Forms.TextBox
            Me.txtCustomTabName = New System.Windows.Forms.TextBox
            Me.cmbSelectedColorGroup = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.label9 = New System.Windows.Forms.Label
            Me.chkSelectedAsText = New System.Windows.Forms.CheckBox
            Me.chkSelectedAsBackColor = New System.Windows.Forms.CheckBox
            Me.label8 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.label17 = New System.Windows.Forms.Label
            Me.tabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.label18 = New System.Windows.Forms.Label
            Me.panel2 = New System.Windows.Forms.Panel
            Me.chkUserColorsStretchOnResize = New System.Windows.Forms.CheckBox
            Me.txtUsersTabName1 = New System.Windows.Forms.TextBox
            Me.label14 = New System.Windows.Forms.Label
            Me.txtSystemTabName1 = New System.Windows.Forms.TextBox
            Me.txtStandardTabName1 = New System.Windows.Forms.TextBox
            Me.txtCustomTabName1 = New System.Windows.Forms.TextBox
            Me.cmbSelectedColorGroup1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.label10 = New System.Windows.Forms.Label
            Me.label11 = New System.Windows.Forms.Label
            Me.label12 = New System.Windows.Forms.Label
            Me.label13 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.colorUIControl1 = New Syncfusion.Windows.Forms.ColorUIControl
            Me.tabPageAdv3 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.panel1 = New System.Windows.Forms.Panel
            Me.numericUpDownExt3 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt
            Me.numericUpDownExt2 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt
            Me.numericUpDownExt1 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt
            Me.label19 = New System.Windows.Forms.Label
            Me.btnShowColorGroups = New Syncfusion.Windows.Forms.ButtonAdv
            Me.cmbOffice2007Theme = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.chkUseOffice2007Theme = New System.Windows.Forms.CheckBox
            Me.label16 = New System.Windows.Forms.Label
            Me.label15 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.Label20 = New System.Windows.Forms.Label
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControlAdv1.SuspendLayout()
            Me.tabPageAdv1.SuspendLayout()
            CType(Me.cmbSelectedColorGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPageAdv2.SuspendLayout()
            Me.panel2.SuspendLayout()
            CType(Me.cmbSelectedColorGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPageAdv3.SuspendLayout()
            Me.panel1.SuspendLayout()
            CType(Me.numericUpDownExt3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDownExt2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDownExt1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cmbOffice2007Theme, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'colorPickerUIAdv1.RecentGroup
            '
            Me.colorPickerUIAdv1.RecentGroup.Name = "RecentColors"
            Me.colorPickerUIAdv1.RecentGroup.Visible = False
            '
            'colorPickerUIAdv1.StandardGroup
            '
            Me.colorPickerUIAdv1.StandardGroup.Name = "StandardColors"
            '
            'colorPickerUIAdv1.ThemeGroup
            '
            Me.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = True
            Me.colorPickerUIAdv1.ThemeGroup.Name = "ThemeColors"
            '
            'colorPickerUIAdv1
            '
            Me.colorPickerUIAdv1.ColorItemSize = New System.Drawing.Size(13, 13)
            Me.colorPickerUIAdv1.Location = New System.Drawing.Point(74, 49)
            Me.colorPickerUIAdv1.MinimumSize = New System.Drawing.Size(136, 149)
            Me.colorPickerUIAdv1.Name = "colorPickerUIAdv1"
            Me.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.Empty
            Me.colorPickerUIAdv1.Size = New System.Drawing.Size(172, 195)
            Me.colorPickerUIAdv1.TabIndex = 4
            Me.colorPickerUIAdv1.Text = "colorPickerUIAdv1"
            '
            'label1
            '
            Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(225, Byte), Integer))
            Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.Maroon
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight
            Me.label1.ImageIndex = 0
            Me.label1.ImageList = Me.imageList1
            Me.label1.Location = New System.Drawing.Point(120, 13)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(376, 80)
            Me.label1.TabIndex = 0
            Me.label1.Text = resources.GetString("label1.Text")
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            '
            'textBox1
            '
            Me.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.textBox1.Location = New System.Drawing.Point(0, 438)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(664, 160)
            Me.textBox1.TabIndex = 2
            '
            'tabControlAdv1
            '
            Me.tabControlAdv1.ActiveTabFont = New System.Drawing.Font("Tahoma", 8.25!)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv1)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv2)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv3)
            Me.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.tabControlAdv1.Location = New System.Drawing.Point(0, 110)
            Me.tabControlAdv1.Name = "tabControlAdv1"
            Me.tabControlAdv1.Size = New System.Drawing.Size(664, 328)
            Me.tabControlAdv1.TabGap = 10
            Me.tabControlAdv1.TabIndex = 3
            Me.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.tabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)
            '
            'tabPageAdv1
            '
            Me.tabPageAdv1.BackColor = System.Drawing.Color.AliceBlue
            Me.tabPageAdv1.Controls.Add(Me.Label20)
            Me.tabPageAdv1.Controls.Add(Me.chkSelectedAsText)
            Me.tabPageAdv1.Controls.Add(Me.txtSystemTabName)
            Me.tabPageAdv1.Controls.Add(Me.chkSelectedAsBackColor)
            Me.tabPageAdv1.Controls.Add(Me.label4)
            Me.tabPageAdv1.Controls.Add(Me.txtStandardTabName)
            Me.tabPageAdv1.Controls.Add(Me.colorPickerButton1)
            Me.tabPageAdv1.Controls.Add(Me.txtCustomTabName)
            Me.tabPageAdv1.Controls.Add(Me.label17)
            Me.tabPageAdv1.Controls.Add(Me.cmbSelectedColorGroup)
            Me.tabPageAdv1.Controls.Add(Me.label6)
            Me.tabPageAdv1.Controls.Add(Me.label9)
            Me.tabPageAdv1.Controls.Add(Me.label7)
            Me.tabPageAdv1.Controls.Add(Me.label8)
            Me.tabPageAdv1.Image = Nothing
            Me.tabPageAdv1.ImageSize = New System.Drawing.Size(16, 16)
            Me.tabPageAdv1.Location = New System.Drawing.Point(1, 22)
            Me.tabPageAdv1.Name = "tabPageAdv1"
            Me.tabPageAdv1.ShowCloseButton = True
            Me.tabPageAdv1.Size = New System.Drawing.Size(661, 304)
            Me.tabPageAdv1.TabIndex = 1
            Me.tabPageAdv1.Text = "Color Picker Button"
            Me.tabPageAdv1.ThemesEnabled = False
            '
            'txtSystemTabName
            '
            Me.txtSystemTabName.Location = New System.Drawing.Point(190, 201)
            Me.txtSystemTabName.Name = "txtSystemTabName"
            Me.txtSystemTabName.Size = New System.Drawing.Size(120, 21)
            Me.txtSystemTabName.TabIndex = 12
            Me.txtSystemTabName.Text = "System"
            '
            'txtStandardTabName
            '
            Me.txtStandardTabName.Location = New System.Drawing.Point(190, 169)
            Me.txtStandardTabName.Name = "txtStandardTabName"
            Me.txtStandardTabName.Size = New System.Drawing.Size(120, 21)
            Me.txtStandardTabName.TabIndex = 11
            Me.txtStandardTabName.Text = "Web"
            '
            'txtCustomTabName
            '
            Me.txtCustomTabName.Location = New System.Drawing.Point(191, 137)
            Me.txtCustomTabName.Name = "txtCustomTabName"
            Me.txtCustomTabName.Size = New System.Drawing.Size(120, 21)
            Me.txtCustomTabName.TabIndex = 10
            Me.txtCustomTabName.Text = "Palette"
            '
            'cmbSelectedColorGroup
            '
            Me.cmbSelectedColorGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.cmbSelectedColorGroup.Items.AddRange(New Object() {"None", "CustomColors", "StandardColors", "SystemColors", "UserColors"})
            Me.cmbSelectedColorGroup.Location = New System.Drawing.Point(190, 233)
            Me.cmbSelectedColorGroup.Name = "cmbSelectedColorGroup"
            Me.cmbSelectedColorGroup.Size = New System.Drawing.Size(121, 21)
            Me.cmbSelectedColorGroup.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.cmbSelectedColorGroup.TabIndex = 9
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Location = New System.Drawing.Point(62, 233)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(105, 13)
            Me.label9.TabIndex = 8
            Me.label9.Text = "Selected ColorGroup"
            '
            'chkSelectedAsText
            '
            Me.chkSelectedAsText.Location = New System.Drawing.Point(415, 230)
            Me.chkSelectedAsText.Name = "chkSelectedAsText"
            Me.chkSelectedAsText.Size = New System.Drawing.Size(104, 24)
            Me.chkSelectedAsText.TabIndex = 7
            Me.chkSelectedAsText.Text = "SelectedAsText"
            '
            'chkSelectedAsBackColor
            '
            Me.chkSelectedAsBackColor.Checked = True
            Me.chkSelectedAsBackColor.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkSelectedAsBackColor.Location = New System.Drawing.Point(415, 190)
            Me.chkSelectedAsBackColor.Name = "chkSelectedAsBackColor"
            Me.chkSelectedAsBackColor.Size = New System.Drawing.Size(128, 24)
            Me.chkSelectedAsBackColor.TabIndex = 6
            Me.chkSelectedAsBackColor.Text = "SelectedAsBackColor"
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Location = New System.Drawing.Point(78, 201)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(90, 13)
            Me.label8.TabIndex = 5
            Me.label8.Text = "System TabName"
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(70, 169)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(99, 13)
            Me.label7.TabIndex = 4
            Me.label7.Text = "Standard TabName"
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(77, 137)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(91, 13)
            Me.label6.TabIndex = 3
            Me.label6.Text = "Custom TabName"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.Color.Maroon
            Me.label4.Location = New System.Drawing.Point(70, 71)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(119, 13)
            Me.label4.TabIndex = 0
            Me.label4.Text = "Essential Properties"
            '
            'colorPickerButton1
            '
            Me.colorPickerButton1.ColorGroups = CType((((Syncfusion.Windows.Forms.ColorUIGroups.CustomColors Or Syncfusion.Windows.Forms.ColorUIGroups.StandardColors) _
                        Or Syncfusion.Windows.Forms.ColorUIGroups.SystemColors) _
                        Or Syncfusion.Windows.Forms.ColorUIGroups.UserColors), Syncfusion.Windows.Forms.ColorUIGroups)
            Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.colorPickerButton1.Location = New System.Drawing.Point(271, 19)
            Me.colorPickerButton1.Name = "colorPickerButton1"
            Me.colorPickerButton1.SelectedAsBackcolor = True
            Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors
            Me.colorPickerButton1.Size = New System.Drawing.Size(128, 23)
            Me.colorPickerButton1.TabIndex = 0
            Me.colorPickerButton1.Text = "Color PickerButton"
            '
            'label17
            '
            Me.label17.AutoSize = True
            Me.label17.BackColor = System.Drawing.Color.Transparent
            Me.label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label17.ForeColor = System.Drawing.Color.Maroon
            Me.label17.Location = New System.Drawing.Point(70, 101)
            Me.label17.Name = "label17"
            Me.label17.Size = New System.Drawing.Size(168, 13)
            Me.label17.TabIndex = 3
            Me.label17.Text = "Press Enter to Change TabNames"
            '
            'tabPageAdv2
            '
            Me.tabPageAdv2.Controls.Add(Me.label18)
            Me.tabPageAdv2.Controls.Add(Me.panel2)
            Me.tabPageAdv2.Controls.Add(Me.colorUIControl1)
            Me.tabPageAdv2.Image = Nothing
            Me.tabPageAdv2.ImageSize = New System.Drawing.Size(16, 16)
            Me.tabPageAdv2.Location = New System.Drawing.Point(1, 22)
            Me.tabPageAdv2.Name = "tabPageAdv2"
            Me.tabPageAdv2.ShowCloseButton = True
            Me.tabPageAdv2.Size = New System.Drawing.Size(661, 304)
            Me.tabPageAdv2.TabIndex = 1
            Me.tabPageAdv2.Text = "ColorUI Control"
            Me.tabPageAdv2.ThemesEnabled = False
            '
            'label18
            '
            Me.label18.AutoSize = True
            Me.label18.BackColor = System.Drawing.Color.Transparent
            Me.label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label18.ForeColor = System.Drawing.Color.Maroon
            Me.label18.Location = New System.Drawing.Point(472, 16)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(168, 13)
            Me.label18.TabIndex = 4
            Me.label18.Text = "Press Enter to Change TabNames"
            '
            'panel2
            '
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.Add(Me.chkUserColorsStretchOnResize)
            Me.panel2.Controls.Add(Me.txtUsersTabName1)
            Me.panel2.Controls.Add(Me.label14)
            Me.panel2.Controls.Add(Me.txtSystemTabName1)
            Me.panel2.Controls.Add(Me.txtStandardTabName1)
            Me.panel2.Controls.Add(Me.txtCustomTabName1)
            Me.panel2.Controls.Add(Me.cmbSelectedColorGroup1)
            Me.panel2.Controls.Add(Me.label10)
            Me.panel2.Controls.Add(Me.label11)
            Me.panel2.Controls.Add(Me.label12)
            Me.panel2.Controls.Add(Me.label13)
            Me.panel2.Controls.Add(Me.label3)
            Me.panel2.Location = New System.Drawing.Point(320, 40)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(328, 240)
            Me.panel2.TabIndex = 2
            '
            'chkUserColorsStretchOnResize
            '
            Me.chkUserColorsStretchOnResize.Location = New System.Drawing.Point(80, 208)
            Me.chkUserColorsStretchOnResize.Name = "chkUserColorsStretchOnResize"
            Me.chkUserColorsStretchOnResize.Size = New System.Drawing.Size(168, 24)
            Me.chkUserColorsStretchOnResize.TabIndex = 23
            Me.chkUserColorsStretchOnResize.Text = "UsersColorStretchOnResize"
            '
            'txtUsersTabName1
            '
            Me.txtUsersTabName1.Location = New System.Drawing.Point(168, 144)
            Me.txtUsersTabName1.Name = "txtUsersTabName1"
            Me.txtUsersTabName1.Size = New System.Drawing.Size(120, 21)
            Me.txtUsersTabName1.TabIndex = 22
            Me.txtUsersTabName1.Text = "User Colors"
            '
            'label14
            '
            Me.label14.AutoSize = True
            Me.label14.Location = New System.Drawing.Point(64, 144)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(82, 13)
            Me.label14.TabIndex = 21
            Me.label14.Text = "Users TabName"
            '
            'txtSystemTabName1
            '
            Me.txtSystemTabName1.Location = New System.Drawing.Point(168, 112)
            Me.txtSystemTabName1.Name = "txtSystemTabName1"
            Me.txtSystemTabName1.Size = New System.Drawing.Size(120, 21)
            Me.txtSystemTabName1.TabIndex = 20
            Me.txtSystemTabName1.Text = "System"
            '
            'txtStandardTabName1
            '
            Me.txtStandardTabName1.Location = New System.Drawing.Point(168, 80)
            Me.txtStandardTabName1.Name = "txtStandardTabName1"
            Me.txtStandardTabName1.Size = New System.Drawing.Size(120, 21)
            Me.txtStandardTabName1.TabIndex = 19
            Me.txtStandardTabName1.Text = "Web"
            '
            'txtCustomTabName1
            '
            Me.txtCustomTabName1.Location = New System.Drawing.Point(168, 48)
            Me.txtCustomTabName1.Name = "txtCustomTabName1"
            Me.txtCustomTabName1.Size = New System.Drawing.Size(120, 21)
            Me.txtCustomTabName1.TabIndex = 18
            Me.txtCustomTabName1.Text = "Palette"
            '
            'cmbSelectedColorGroup1
            '
            Me.cmbSelectedColorGroup1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.cmbSelectedColorGroup1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbSelectedColorGroup1.Items.AddRange(New Object() {"None", "CustomColors", "StandardColors", "SystemColors", "UserColors"})
            Me.cmbSelectedColorGroup1.Location = New System.Drawing.Point(168, 176)
            Me.cmbSelectedColorGroup1.Name = "cmbSelectedColorGroup1"
            Me.cmbSelectedColorGroup1.Size = New System.Drawing.Size(121, 21)
            Me.cmbSelectedColorGroup1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.cmbSelectedColorGroup1.TabIndex = 17
            Me.cmbSelectedColorGroup1.Text = "None"
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Location = New System.Drawing.Point(40, 176)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(105, 13)
            Me.label10.TabIndex = 16
            Me.label10.Text = "Selected ColorGroup"
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Location = New System.Drawing.Point(56, 112)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(90, 13)
            Me.label11.TabIndex = 15
            Me.label11.Text = "System TabName"
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.Location = New System.Drawing.Point(48, 80)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(99, 13)
            Me.label12.TabIndex = 14
            Me.label12.Text = "Standard TabName"
            '
            'label13
            '
            Me.label13.AutoSize = True
            Me.label13.Location = New System.Drawing.Point(56, 48)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(91, 13)
            Me.label13.TabIndex = 13
            Me.label13.Text = "Custom TabName"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.Maroon
            Me.label3.Location = New System.Drawing.Point(8, 16)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(119, 13)
            Me.label3.TabIndex = 0
            Me.label3.Text = "Essential Properties"
            '
            'colorUIControl1
            '
            Me.colorUIControl1.ColorGroups = CType((((Syncfusion.Windows.Forms.ColorUIGroups.CustomColors Or Syncfusion.Windows.Forms.ColorUIGroups.StandardColors) _
                        Or Syncfusion.Windows.Forms.ColorUIGroups.SystemColors) _
                        Or Syncfusion.Windows.Forms.ColorUIGroups.UserColors), Syncfusion.Windows.Forms.ColorUIGroups)
            Me.colorUIControl1.Location = New System.Drawing.Point(56, 40)
            Me.colorUIControl1.Name = "colorUIControl1"
            Me.colorUIControl1.SelectedColor = System.Drawing.SystemColors.ControlDarkDark
            Me.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors
            Me.colorUIControl1.Size = New System.Drawing.Size(200, 200)
            Me.colorUIControl1.TabIndex = 0
            Me.colorUIControl1.Text = "colorUIControl1"
            '
            'tabPageAdv3
            '
            Me.tabPageAdv3.Controls.Add(Me.colorPickerUIAdv1)
            Me.tabPageAdv3.Controls.Add(Me.panel1)
            Me.tabPageAdv3.Image = Nothing
            Me.tabPageAdv3.ImageSize = New System.Drawing.Size(16, 16)
            Me.tabPageAdv3.Location = New System.Drawing.Point(1, 22)
            Me.tabPageAdv3.Name = "tabPageAdv3"
            Me.tabPageAdv3.ShowCloseButton = True
            Me.tabPageAdv3.Size = New System.Drawing.Size(661, 304)
            Me.tabPageAdv3.TabFont = New System.Drawing.Font("Tahoma", 8.25!)
            Me.tabPageAdv3.TabIndex = 2
            Me.tabPageAdv3.Text = "ColorPickerUIAdv"
            Me.tabPageAdv3.ThemesEnabled = False
            '
            'panel1
            '
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.numericUpDownExt3)
            Me.panel1.Controls.Add(Me.numericUpDownExt2)
            Me.panel1.Controls.Add(Me.numericUpDownExt1)
            Me.panel1.Controls.Add(Me.label19)
            Me.panel1.Controls.Add(Me.btnShowColorGroups)
            Me.panel1.Controls.Add(Me.cmbOffice2007Theme)
            Me.panel1.Controls.Add(Me.chkUseOffice2007Theme)
            Me.panel1.Controls.Add(Me.label16)
            Me.panel1.Controls.Add(Me.label15)
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Location = New System.Drawing.Point(330, 5)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(320, 281)
            Me.panel1.TabIndex = 1
            '
            'numericUpDownExt3
            '
            Me.numericUpDownExt3.Location = New System.Drawing.Point(174, 192)
            Me.numericUpDownExt3.Name = "numericUpDownExt3"
            Me.numericUpDownExt3.Size = New System.Drawing.Size(96, 21)
            Me.numericUpDownExt3.TabIndex = 12
            Me.numericUpDownExt3.ThemesEnabled = True
            Me.numericUpDownExt3.Value = New Decimal(New Integer() {23, 0, 0, 0})
            '
            'numericUpDownExt2
            '
            Me.numericUpDownExt2.Location = New System.Drawing.Point(175, 128)
            Me.numericUpDownExt2.Name = "numericUpDownExt2"
            Me.numericUpDownExt2.Size = New System.Drawing.Size(96, 21)
            Me.numericUpDownExt2.TabIndex = 11
            Me.numericUpDownExt2.ThemesEnabled = True
            '
            'numericUpDownExt1
            '
            Me.numericUpDownExt1.Location = New System.Drawing.Point(176, 92)
            Me.numericUpDownExt1.Name = "numericUpDownExt1"
            Me.numericUpDownExt1.Size = New System.Drawing.Size(96, 21)
            Me.numericUpDownExt1.TabIndex = 10
            Me.numericUpDownExt1.ThemesEnabled = True
            Me.numericUpDownExt1.Value = New Decimal(New Integer() {4, 0, 0, 0})
            '
            'label19
            '
            Me.label19.AutoSize = True
            Me.label19.Location = New System.Drawing.Point(88, 192)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(73, 13)
            Me.label19.TabIndex = 9
            Me.label19.Text = "Button Height"
            '
            'btnShowColorGroups
            '
            Me.btnShowColorGroups.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.btnShowColorGroups.Location = New System.Drawing.Point(107, 56)
            Me.btnShowColorGroups.Name = "btnShowColorGroups"
            Me.btnShowColorGroups.Size = New System.Drawing.Size(120, 23)
            Me.btnShowColorGroups.TabIndex = 8
            Me.btnShowColorGroups.Text = "Show ColorGroups"
            Me.btnShowColorGroups.UseVisualStyle = True
            '
            'cmbOffice2007Theme
            '
            Me.cmbOffice2007Theme.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.cmbOffice2007Theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbOffice2007Theme.Items.AddRange(New Object() {"Blue", "Black", "Silver"})
            Me.cmbOffice2007Theme.Location = New System.Drawing.Point(174, 160)
            Me.cmbOffice2007Theme.Name = "cmbOffice2007Theme"
            Me.cmbOffice2007Theme.Size = New System.Drawing.Size(98, 21)
            Me.cmbOffice2007Theme.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.cmbOffice2007Theme.TabIndex = 7
            Me.cmbOffice2007Theme.Text = "Blue"
            '
            'chkUseOffice2007Theme
            '
            Me.chkUseOffice2007Theme.Checked = True
            Me.chkUseOffice2007Theme.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkUseOffice2007Theme.Location = New System.Drawing.Point(104, 224)
            Me.chkUseOffice2007Theme.Name = "chkUseOffice2007Theme"
            Me.chkUseOffice2007Theme.Size = New System.Drawing.Size(136, 24)
            Me.chkUseOffice2007Theme.TabIndex = 4
            Me.chkUseOffice2007Theme.Text = "UseOffice2007Theme"
            '
            'label16
            '
            Me.label16.AutoSize = True
            Me.label16.Location = New System.Drawing.Point(69, 160)
            Me.label16.Name = "label16"
            Me.label16.Size = New System.Drawing.Size(92, 13)
            Me.label16.TabIndex = 3
            Me.label16.Text = "Office2007Theme"
            '
            'label15
            '
            Me.label15.AutoSize = True
            Me.label15.Location = New System.Drawing.Point(80, 128)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(82, 13)
            Me.label15.TabIndex = 2
            Me.label15.Text = "Vertical Spacing"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(67, 96)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(95, 13)
            Me.label5.TabIndex = 1
            Me.label5.Text = "Horizontal Spacing"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.Maroon
            Me.label2.Location = New System.Drawing.Point(8, 8)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(119, 13)
            Me.label2.TabIndex = 0
            Me.label2.Text = "Essential Properties"
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.ForeColor = System.Drawing.Color.Maroon
            Me.Label20.Location = New System.Drawing.Point(41, 24)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(199, 13)
            Me.Label20.TabIndex = 13
            Me.Label20.Text = "Click the button to show the color picker"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(664, 598)
            Me.Controls.Add(Me.tabControlAdv1)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.label1)
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Color UI Controls"
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControlAdv1.ResumeLayout(False)
            Me.tabPageAdv1.ResumeLayout(False)
            Me.tabPageAdv1.PerformLayout()
            CType(Me.cmbSelectedColorGroup, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPageAdv2.ResumeLayout(False)
            Me.tabPageAdv2.PerformLayout()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            CType(Me.cmbSelectedColorGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPageAdv3.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.numericUpDownExt3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDownExt2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDownExt1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cmbOffice2007Theme, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub

#Region "FormLoad"

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.cmbSelectedColorGroup.SelectedIndex = 0
            Me.cmbOffice2007Theme.SelectedIndex = 0
            Me.cmbSelectedColorGroup1.SelectedIndex = 0
        End Sub

#End Region

#Region "EventLog"

        Private Sub Addlog(ByVal logText As String)
            Me.textBox1.Text += logText & Constants.vbCrLf
        End Sub
#End Region

#Region "ColorPickerButton Properties"

        Private Sub txtCustomTabName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustomTabName.KeyDown
            If e.KeyCode = Keys.Enter Then
                Me.colorPickerButton1.CustomTabName = Me.txtCustomTabName.Text
                Addlog("ColorPickerButton CustomTabName Changed to " & Me.txtCustomTabName.Text)
            End If
        End Sub

        Private Sub txtStandardTabName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStandardTabName.KeyDown
            If e.KeyCode = Keys.Enter Then
                Me.colorPickerButton1.StandardTabName = Me.txtStandardTabName.Text
                Addlog("ColorPickerButton StandardTabName Changed to " & Me.txtStandardTabName.Text)
            End If
        End Sub

        Private Sub txtSystemTabName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSystemTabName.KeyDown
            If e.KeyCode = Keys.Enter Then
                Me.colorPickerButton1.SystemTabName = Me.txtSystemTabName.Text
                Addlog("ColorPickerButton SystemTabName Changed to " & Me.txtSystemTabName.Text)
            End If
        End Sub

        Private Sub cmbSelectedColorGroup_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSelectedColorGroup.SelectedIndexChanged
            Me.colorPickerButton1.SelectedColor = Color.Empty
            Select Case Me.cmbSelectedColorGroup.Text
                Case "None"
                    Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
                Case "CustomColors"
                    Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors
                Case "StandardColors"
                    Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors
                Case "SystemColors"
                    Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.SystemColors
                Case "UserColors"
                    Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.UserColors
            End Select
            Me.colorPickerButton1.SelectedColor = Color.Empty
            Addlog("ColorPickerButton's SelectedColorGroup changed to " & Me.cmbSelectedColorGroup.Text)
        End Sub

        Private Sub chkSelectedAsBackColor_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSelectedAsBackColor.CheckedChanged
            Me.colorPickerButton1.SelectedAsBackcolor = Me.chkSelectedAsBackColor.Checked
            Addlog("ColorPickerButton's SelectedAsBackcolor set to " & Me.chkSelectedAsBackColor.Checked.ToString())
        End Sub

        Private Sub chkSelectedAsText_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSelectedAsText.CheckedChanged
            Me.colorPickerButton1.SelectedAsText = Me.chkSelectedAsText.Checked
            Addlog("ColorPickerButton's SelectedAsText set to " & Me.chkSelectedAsText.Checked.ToString())
        End Sub

        Private Sub colorPickerButton1_ColorSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorPickerButton1.ColorSelected
            Me.tabPageAdv1.BackColor = Me.colorPickerButton1.SelectedColor
            Addlog("ColorPickerButton is setting TabPage BackColor to " & Me.colorPickerButton1.SelectedColor.ToString())
        End Sub

#End Region

#Region "ColorUIControl Properties"

        Private Sub colorUIControl1_ColorSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorUIControl1.ColorSelected
            Me.tabPageAdv2.BackColor = Me.colorUIControl1.SelectedColor
            Addlog("ColorUIControl is Setting TabPage BackColor to " & Me.colorUIControl1.SelectedColor.ToString())
        End Sub

        Private Sub cmbSelectedColorGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSelectedColorGroup1.SelectedIndexChanged
            Select Case Me.cmbSelectedColorGroup1.Text
                Case "None"
                    Me.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
                Case "CustomColors"
                    Me.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors
                Case "StandardColors"
                    Me.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors
                Case "SystemColors"
                    Me.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.SystemColors
                Case "UserColors"
                    Me.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.UserColors
            End Select
            Addlog("ColorUIControl's SelectedColorGroup changed to " & Me.cmbSelectedColorGroup1.Text)
        End Sub

        Private Sub txtCustomTabName1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustomTabName1.KeyDown
            If e.KeyCode = Keys.Enter Then
                Me.colorUIControl1.CustomTabName = Me.txtCustomTabName1.Text
                Addlog("ColorUIControl's CustomTabName changed to " & Me.txtCustomTabName1.Text)
            End If
        End Sub

        Private Sub txtStandardTabName1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStandardTabName1.KeyDown
            If e.KeyCode = Keys.Enter Then
                Me.colorUIControl1.StandardTabName = Me.txtStandardTabName1.Text
                Addlog("ColorUIControl's StandardTabName changed to " & Me.txtStandardTabName.Text)
            End If
        End Sub

        Private Sub txtSystemTabName1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSystemTabName1.KeyDown
            If e.KeyCode = Keys.Enter Then
                Me.colorUIControl1.SystemTabName = Me.txtSystemTabName1.Text
                Addlog("ColorUIControl's SystemTabName changed to " & Me.txtSystemTabName1.Text)
            End If
        End Sub

        Private Sub txtUsersTabName1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsersTabName1.KeyDown
            If e.KeyCode = Keys.Enter Then
                Me.colorUIControl1.UserTabName = Me.txtUsersTabName1.Text
                Addlog("ColorUIControl's UserTabName changed to " & Me.txtUsersTabName1.Text)
            End If
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkUserColorsStretchOnResize.CheckedChanged
            Me.colorUIControl1.CustomColorsStretchOnResize = Me.chkUserColorsStretchOnResize.Checked
            Me.colorUIControl1.UserColorsStretchOnResize = Me.chkUserColorsStretchOnResize.Checked
        End Sub

#End Region

#Region "ColorPickerUIAdv properties"


        Private Sub cmbOffice2007Theme_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOffice2007Theme.SelectedIndexChanged
            Select Case Me.cmbOffice2007Theme.Text
                Case "Blue"
                    Me.colorPickerUIAdv1.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Blue
                Case "Black"
                    Me.colorPickerUIAdv1.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Black
                Case "Silver"
                    Me.colorPickerUIAdv1.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Silver
            End Select
            Addlog("ColorPickerUIAdv's Office2007Theme set to " & Me.colorPickerUIAdv1.Office2007Theme.ToString())
        End Sub

        Private Sub chkUseOffice2007Theme_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkUseOffice2007Theme.CheckedChanged
            Me.colorPickerUIAdv1.UseOffice2007Style = Me.chkUseOffice2007Theme.Checked
            Addlog("ColorPickerUIAdv's UseOffice2007Style is set to " & Me.chkUseOffice2007Theme.Checked.ToString())

        End Sub

        Private Sub btnShowColorGroups_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShowColorGroups.Click
            Dim oTemp As ColorGroup = New ColorGroup(Me.colorPickerUIAdv1)
            oTemp.ShowDialog()
            Me.Refresh()
        End Sub


        Private Sub numericUpDownExt1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDownExt1.ValueChanged
            Me.colorPickerUIAdv1.HorizontalItemsSpacing = CInt(Me.numericUpDownExt1.Value)
            Addlog("ColorPickerUIAdv's HorizontalItemsSpacing set to " & Me.numericUpDownExt1.Value.ToString())
        End Sub

        Private Sub numericUpDownExt2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDownExt2.ValueChanged
            Me.colorPickerUIAdv1.VerticalItemsSpacing = CInt(Me.numericUpDownExt2.Value)
            Addlog("ColorPickerUIAdv's VerticalItemsSpacing set to " & Me.numericUpDownExt2.Value.ToString())
        End Sub

        Private Sub numericUpDownExt3_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDownExt3.ValueChanged
            Me.colorPickerUIAdv1.ButtonsHeight = CInt(Me.numericUpDownExt3.Value)
            Addlog("ColorPickerUIAdv's ButtonsHeight set to " & Me.numericUpDownExt3.Value.ToString())
        End Sub

        Private Sub colorPickerUIAdv1_Picked(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs) Handles colorPickerUIAdv1.Picked
            Me.tabPageAdv3.BackColor = Me.colorPickerUIAdv1.SelectedItem.Color
            Addlog("ColorPickerUIAdv is Setting TabPage BackColor to " & Me.colorPickerUIAdv1.SelectedItem.Color.ToString())
        End Sub

#End Region

        Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click

        End Sub
    End Class
End Namespace
