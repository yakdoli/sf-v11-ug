Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms

Namespace AutoCompleteDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Office2007Form
		Private imageList1 As System.Windows.Forms.ImageList
		Private textBox3 As System.Windows.Forms.TextBox
		Private textBox2 As System.Windows.Forms.TextBox
		Public textBox1 As System.Windows.Forms.TextBox
		Private WithEvents autoComplete1 As Syncfusion.Windows.Forms.Tools.AutoComplete
		Private label3 As System.Windows.Forms.Label
		Private WithEvents comboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private imageList2 As System.Windows.Forms.ImageList
		Private WithEvents autoComplete2 As Syncfusion.Windows.Forms.Tools.AutoComplete
		Private websites1 As AutoCompleteDemo.Websites
		Friend label5 As System.Windows.Forms.Label
		Public textBox4 As System.Windows.Forms.TextBox
		Private comboBox1 As System.Windows.Forms.ComboBox
		Private textBox5 As System.Windows.Forms.TextBox
		Private imageList3 As System.Windows.Forms.ImageList
		Private autoCompleteDataColumnInfo1 As Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo
		Private autoCompleteDataColumnInfo2 As Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo
		Private autoCompleteDataColumnInfo3 As Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo
		Private WithEvents comboBoxAdv2 As ComboBoxAdv
		Private label6 As Label
		Private label2 As Label
		Private label10 As Label
		Friend label12 As Label
		Friend label11 As Label
		Private label1 As Label
		Private label4 As Label
		Private gradientPanel2 As GradientPanel
		Private label15 As Label
		Private gradientPanel1 As GradientPanel
		Private label40 As Label
		Private label14 As Label
		Private label13 As Label
		Private label7 As Label
		Private label24 As Label
		Private toolTip1 As ToolTip
		Friend label9 As Label
		Friend label8 As Label
		Private WithEvents textBox6 As TextBox
		Private autoLabel1 As AutoLabel
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.label3 = New System.Windows.Forms.Label
            Me.textBox3 = New System.Windows.Forms.TextBox
            Me.textBox2 = New System.Windows.Forms.TextBox
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.autoComplete1 = New Syncfusion.Windows.Forms.Tools.AutoComplete(Me.components)
            Me.textBox5 = New System.Windows.Forms.TextBox
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.textBox4 = New System.Windows.Forms.TextBox
            Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
            Me.comboBoxAdv2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.label5 = New System.Windows.Forms.Label
            Me.autoCompleteDataColumnInfo1 = New Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("URL", 100, True)
            Me.autoCompleteDataColumnInfo2 = New Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("Name", 100, True)
            Me.autoCompleteDataColumnInfo3 = New Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("ImageIndex", 100, True)
            Me.imageList3 = New System.Windows.Forms.ImageList(Me.components)
            Me.label10 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.label11 = New System.Windows.Forms.Label
            Me.label12 = New System.Windows.Forms.Label
            Me.label13 = New System.Windows.Forms.Label
            Me.label14 = New System.Windows.Forms.Label
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label40 = New System.Windows.Forms.Label
            Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label15 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label24 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.autoComplete2 = New Syncfusion.Windows.Forms.Tools.AutoComplete(Me.components)
            Me.websites1 = New AutoCompleteDemo.Websites
			Me.autoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel()			
			Me.textBox6 = New System.Windows.Forms.TextBox()			
            Me.label8 = New System.Windows.Forms.Label
            Me.label9 = New System.Windows.Forms.Label
            CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.autoComplete1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel2.SuspendLayout()
            CType(Me.autoComplete2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.websites1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            '
            'comboBoxAdv1
            '
            Me.comboBoxAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxAdv1.IgnoreThemeBackground = True
            Me.comboBoxAdv1.Items.AddRange(New Object() {"Disabled", "AutoSuggest", "AutoAppend", "Both"})
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Disabled"))
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "AutoSuggest"))
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "AutoAppend"))
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Both"))
            Me.comboBoxAdv1.Location = New System.Drawing.Point(158, 102)
            Me.comboBoxAdv1.Name = "comboBoxAdv1"
            Me.comboBoxAdv1.Size = New System.Drawing.Size(134, 21)
            Me.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.comboBoxAdv1.TabIndex = 10
            Me.comboBoxAdv1.Text = "Disabled"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label3.ForeColor = System.Drawing.Color.Black
            Me.label3.Location = New System.Drawing.Point(14, 103)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(127, 13)
            Me.label3.TabIndex = 9
            Me.label3.Text = "Set AutoComplete Mode:"
            '
            'textBox3
            '
            Me.autoComplete2.SetAutoComplete(Me.textBox3, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled)
            Me.autoComplete1.SetAutoComplete(Me.textBox3, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Both)
            Me.textBox3.Location = New System.Drawing.Point(432, 153)
            Me.textBox3.Name = "textBox3"
            Me.textBox3.Size = New System.Drawing.Size(185, 21)
            Me.textBox3.TabIndex = 8
            '
            'textBox2
            '
            Me.autoComplete1.SetAutoComplete(Me.textBox2, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Both)
            Me.autoComplete2.SetAutoComplete(Me.textBox2, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled)
            Me.textBox2.Location = New System.Drawing.Point(223, 153)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(185, 21)
            Me.textBox2.TabIndex = 7
            '
            'textBox1
            '
            Me.autoComplete1.SetAutoComplete(Me.textBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest)
            Me.autoComplete2.SetAutoComplete(Me.textBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled)
            Me.textBox1.BackColor = System.Drawing.Color.White
            Me.textBox1.Location = New System.Drawing.Point(14, 152)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(185, 21)
            Me.textBox1.TabIndex = 6
            '
            'autoComplete1
            '
            Me.autoComplete1.AccessibleDescription = Nothing
            Me.autoComplete1.AccessibleName = Nothing
            Me.autoComplete1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
            Me.autoComplete1.AdjustHeightToItemCount = True
            Me.autoComplete1.AutoAddItem = True
            Me.autoComplete1.AutoSerialize = True
            Me.autoComplete1.CategoryName = ""
            Me.autoComplete1.ParentForm = Me
            Me.autoComplete1.PreferredHeight = 200
            Me.autoComplete1.SelectedIndex = -1
            Me.autoComplete1.SelectedValue = ""
            Me.autoComplete1.ShowCloseButton = True
            Me.autoComplete1.ShowGripper = True
            '
            'textBox5
            '
            Me.autoComplete1.SetAutoComplete(Me.textBox5, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled)
            Me.autoComplete2.SetAutoComplete(Me.textBox5, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled)
            Me.textBox5.Location = New System.Drawing.Point(14, 426)
            Me.textBox5.Multiline = True
            Me.textBox5.Name = "textBox5"
            Me.textBox5.Size = New System.Drawing.Size(608, 110)
            Me.textBox5.TabIndex = 18
            '
            'comboBox1
            '
            Me.autoComplete1.SetAutoComplete(Me.comboBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled)
            Me.autoComplete2.SetAutoComplete(Me.comboBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggestExtended)
            Me.comboBox1.Location = New System.Drawing.Point(78, 326)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(544, 21)
            Me.comboBox1.TabIndex = 16
            '
            'textBox4
            '
            Me.autoComplete1.SetAutoComplete(Me.textBox4, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled)
            Me.autoComplete2.SetAutoComplete(Me.textBox4, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggestExtended)
            Me.textBox4.Location = New System.Drawing.Point(78, 353)
            Me.textBox4.Name = "textBox4"
            Me.textBox4.Size = New System.Drawing.Size(544, 21)
            Me.textBox4.TabIndex = 17
            '
            'imageList2
            '
            Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList2.Images.SetKeyName(0, "")
            Me.imageList2.Images.SetKeyName(1, "")
            Me.imageList2.Images.SetKeyName(2, "")
            Me.imageList2.Images.SetKeyName(3, "")
            '
            'comboBoxAdv2
            '
            Me.comboBoxAdv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxAdv2.IgnoreThemeBackground = True
            Me.comboBoxAdv2.Items.AddRange(New Object() {"MultiSuggest", "MultiSuggestExtended"})
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "MultiSuggest"))
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "MultiSuggestExtended"))
            Me.comboBoxAdv2.Location = New System.Drawing.Point(158, 299)
            Me.comboBoxAdv2.Name = "comboBoxAdv2"
            Me.comboBoxAdv2.Size = New System.Drawing.Size(134, 21)
            Me.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.comboBoxAdv2.TabIndex = 13
            Me.comboBoxAdv2.Text = "MultiSuggestExtended"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label5.ForeColor = System.Drawing.Color.Black
            Me.label5.Location = New System.Drawing.Point(14, 134)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(53, 13)
            Me.label5.TabIndex = 14
            Me.label5.Text = "TextBox1"
            '
            'autoCompleteDataColumnInfo1
            '
            Me.autoCompleteDataColumnInfo1.ColumnHeaderText = "URL"
            Me.autoCompleteDataColumnInfo1.ImageColumn = False
            Me.autoCompleteDataColumnInfo1.MatchingColumn = True
            Me.autoCompleteDataColumnInfo1.Visible = True
            '
            'autoCompleteDataColumnInfo2
            '
            Me.autoCompleteDataColumnInfo2.ColumnHeaderText = "Name"
            Me.autoCompleteDataColumnInfo2.ImageColumn = False
            Me.autoCompleteDataColumnInfo2.MatchingColumn = False
            Me.autoCompleteDataColumnInfo2.Visible = True
            '
            'autoCompleteDataColumnInfo3
            '
            Me.autoCompleteDataColumnInfo3.ColumnHeaderText = "ImageIndex"
            Me.autoCompleteDataColumnInfo3.ImageColumn = True
            Me.autoCompleteDataColumnInfo3.MatchingColumn = False
            Me.autoCompleteDataColumnInfo3.Visible = True
            '
            'imageList3
            '
            Me.imageList3.ImageStream = CType(resources.GetObject("imageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList3.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList3.Images.SetKeyName(0, "")
            Me.imageList3.Images.SetKeyName(1, "")
            Me.imageList3.Images.SetKeyName(2, "")
            Me.imageList3.Images.SetKeyName(3, "")
            '
            'label10
            '
            Me.label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label10.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label10.Image = CType(resources.GetObject("label10.Image"), System.Drawing.Image)
            Me.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label10.Location = New System.Drawing.Point(14, 7)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(159, 24)
            Me.label10.TabIndex = 13
            Me.label10.Text = "UnBounded DataSource"
            Me.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Image = CType(resources.GetObject("label2.Image"), System.Drawing.Image)
            Me.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label2.Location = New System.Drawing.Point(14, 200)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(144, 24)
            Me.label2.TabIndex = 20
            Me.label2.Text = "Bounded DataSource"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label6.ForeColor = System.Drawing.Color.Black
            Me.label6.Location = New System.Drawing.Point(14, 303)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(127, 13)
            Me.label6.TabIndex = 21
            Me.label6.Text = "Set AutoComplete Mode:"
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label11.ForeColor = System.Drawing.Color.Black
            Me.label11.Location = New System.Drawing.Point(223, 134)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(53, 13)
            Me.label11.TabIndex = 22
            Me.label11.Text = "TextBox2"
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label12.ForeColor = System.Drawing.Color.Black
            Me.label12.Location = New System.Drawing.Point(432, 134)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(53, 13)
            Me.label12.TabIndex = 23
            Me.label12.Text = "TextBox3"
            '
            'label13
            '
            Me.label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label13.Location = New System.Drawing.Point(168, 214)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(451, 2)
            Me.label13.TabIndex = 24
            '
            'label14
            '
            Me.label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label14.Location = New System.Drawing.Point(181, 21)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(438, 1)
            Me.label14.TabIndex = 25
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel1.Controls.Add(Me.label40)
            Me.gradientPanel1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel1.Location = New System.Drawing.Point(14, 34)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(609, 49)
            Me.gradientPanel1.TabIndex = 26
            '
            'label40
            '
            Me.label40.BackColor = System.Drawing.Color.Transparent
            Me.label40.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label40.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label40.Image = CType(resources.GetObject("label40.Image"), System.Drawing.Image)
            Me.label40.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label40.Location = New System.Drawing.Point(0, 0)
            Me.label40.Name = "label40"
            Me.label40.Size = New System.Drawing.Size(607, 47)
            Me.label40.TabIndex = 1
            Me.label40.Text = resources.GetString("label40.Text")
            '
            'gradientPanel2
            '
            Me.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel2.Controls.Add(Me.label15)
            Me.gradientPanel2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel2.Location = New System.Drawing.Point(14, 232)
            Me.gradientPanel2.Name = "gradientPanel2"
            Me.gradientPanel2.Size = New System.Drawing.Size(608, 49)
            Me.gradientPanel2.TabIndex = 27
            '
            'label15
            '
            Me.label15.BackColor = System.Drawing.Color.Transparent
            Me.label15.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label15.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label15.Image = CType(resources.GetObject("label15.Image"), System.Drawing.Image)
            Me.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label15.Location = New System.Drawing.Point(0, 0)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(606, 47)
            Me.label15.TabIndex = 1
            Me.label15.Text = "The DataSource for this AutoComplete control is set to an XML Datasource. Enter h" & _
                " to view the autocomplete. "
            '
            'label1
            '
            Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label1.Location = New System.Drawing.Point(106, 413)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(512, 1)
            Me.label1.TabIndex = 29
            '
            'label4
            '
            Me.label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label4.Image = CType(resources.GetObject("label4.Image"), System.Drawing.Image)
            Me.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label4.Location = New System.Drawing.Point(14, 399)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(85, 24)
            Me.label4.TabIndex = 28
            Me.label4.Text = "Event Log"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label24
            '
            Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
            Me.label24.Location = New System.Drawing.Point(308, 299)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 20)
            Me.label24.TabIndex = 30
            Me.toolTip1.SetToolTip(Me.label24, resources.GetString("label24.ToolTip"))
            '
            'label7
            '
            Me.label7.Image = CType(resources.GetObject("label7.Image"), System.Drawing.Image)
            Me.label7.Location = New System.Drawing.Point(308, 102)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(20, 20)
            Me.label7.TabIndex = 31
            Me.toolTip1.SetToolTip(Me.label7, resources.GetString("label7.ToolTip"))
            '
            'autoComplete2
            '
            Me.autoComplete2.AccessibleDescription = Nothing
            Me.autoComplete2.AccessibleName = Nothing
            Me.autoComplete2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
            Me.autoComplete2.AdjustHeightToItemCount = False
            Me.autoComplete2.AutoAddItem = False
            Me.autoComplete2.AutoSerialize = True
            Me.autoComplete2.CategoryName = ""
            Me.autoComplete2.Columns.Add(Me.autoCompleteDataColumnInfo1)
            Me.autoComplete2.Columns.Add(Me.autoCompleteDataColumnInfo2)
            Me.autoComplete2.Columns.Add(Me.autoCompleteDataColumnInfo3)
            Me.autoComplete2.DataSource = Me.websites1.Website
            Me.autoComplete2.ImageList = Me.imageList3
            Me.autoComplete2.ParentForm = Me
            Me.autoComplete2.PreferredHeight = 200
            Me.autoComplete2.SelectedIndex = -1
            Me.autoComplete2.SelectedValue = ""
            Me.autoComplete2.ShowCloseButton = True
            Me.autoComplete2.ShowColumnHeader = True
            Me.autoComplete2.ShowGripper = True
            '
            'websites1
            '
            Me.websites1.DataSetName = "Websites"
            Me.websites1.EnforceConstraints = False
            Me.websites1.Locale = New System.Globalization.CultureInfo("en-US")
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label8.ForeColor = System.Drawing.Color.Black
            Me.label8.Location = New System.Drawing.Point(14, 326)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(58, 13)
            Me.label8.TabIndex = 32
            Me.label8.Text = "ComboBox"
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label9.ForeColor = System.Drawing.Color.Black
            Me.label9.Location = New System.Drawing.Point(14, 356)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(47, 13)
            Me.label9.TabIndex = 33
            Me.label9.Text = "TextBox"
			' 
			' autoLabel1
			' 
			Me.autoLabel1.Location = New System.Drawing.Point(426, 103)
			Me.autoLabel1.Name = "autoLabel1"
			Me.autoLabel1.Size = New System.Drawing.Size(127, 13)
			Me.autoLabel1.TabIndex = 34
			Me.autoLabel1.Text = "Number Of Suggestions :"
			' 
			' textBox6
			' 
			Me.autoComplete1.SetAutoComplete(Me.textBox6, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled)
			Me.autoComplete2.SetAutoComplete(Me.textBox6, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled)
			Me.textBox6.Location = New System.Drawing.Point(553, 103)
			Me.textBox6.Name = "textBox6"
			Me.textBox6.Size = New System.Drawing.Size(65, 21)
			Me.textBox6.TabIndex = 35
'			Me.textBox6.TextChanged += New System.EventHandler(Me.textBox6_TextChanged)
			
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(641, 545)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.label8)
            Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.textBox6)
			Me.Controls.Add(Me.autoLabel1)
            Me.Controls.Add(Me.label24)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.gradientPanel2)
            Me.Controls.Add(Me.gradientPanel1)
            Me.Controls.Add(Me.label14)
            Me.Controls.Add(Me.label13)
            Me.Controls.Add(Me.label12)
            Me.Controls.Add(Me.label11)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.comboBoxAdv2)
            Me.Controls.Add(Me.textBox3)
            Me.Controls.Add(Me.comboBox1)
            Me.Controls.Add(Me.textBox4)
            Me.Controls.Add(Me.label10)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.textBox2)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.comboBoxAdv1)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.textBox5)
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Autocomplete Demo"
            CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.autoComplete1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel2.ResumeLayout(False)
            CType(Me.autoComplete2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.websites1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub comboBoxAdv1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxAdv1.SelectedIndexChanged
			SetAutoCompleteMode(Me.comboBoxAdv1.Text)
			AddLog("AutoCompleteMode set to " & Me.comboBoxAdv1.Text)
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Me.comboBoxAdv1.SelectedIndex = 3
			Me.comboBoxAdv2.SelectedIndex = 1

			Dim filename As String = System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\websites.xml"
			Me.websites1.ReadXml(filename)

			If Me.autoComplete2.TableData.Rows.Count <= 0 Then
				Me.autoComplete2.SetTableData()
			Else
				Me.autoComplete2.DataSource = Nothing
			End If

		End Sub



		Private Sub SetAutoCompleteMode(ByVal mode As String)
			If mode <>"" Then
				Select Case mode
					Case "Disabled"
						Me.autoComplete1.SetAutoComplete(Me.textBox1,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled)
						Me.autoComplete1.SetAutoComplete(Me.textBox2,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled)
						Me.autoComplete1.SetAutoComplete(Me.textBox3,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled)
					Case "AutoSuggest"
						Me.autoComplete1.SetAutoComplete(Me.textBox1,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest)
						Me.autoComplete1.SetAutoComplete(Me.textBox2,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest)
						Me.autoComplete1.SetAutoComplete(Me.textBox3,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest)
					Case "AutoAppend"
						Me.autoComplete1.SetAutoComplete(Me.textBox1,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoAppend)
						Me.autoComplete1.SetAutoComplete(Me.textBox2,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoAppend)
						Me.autoComplete1.SetAutoComplete(Me.textBox3,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoAppend)
					Case "Both"
						Me.autoComplete1.SetAutoComplete(Me.textBox1,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Both)
						Me.autoComplete1.SetAutoComplete(Me.textBox2,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Both)
						Me.autoComplete1.SetAutoComplete(Me.textBox3,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Both)

				End Select
			End If
		End Sub


		Private Sub AddLog(ByVal message As String)
			Me.textBox5.Text += message & Constants.vbCrLf
		End Sub

		Private Sub autoComplete_AutoCompleteItemBrowsed(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventArgs) Handles autoComplete1.AutoCompleteItemBrowsed, autoComplete2.AutoCompleteItemBrowsed
			Dim itemText As String = args.ItemArray(0).ToString()
			Dim eventlogmessage As String = String.Format("Event: {0} Item: {1}", "AutoCompleteItemBrowsed", itemText)
			AddLog(eventlogmessage)
		End Sub

		Private Sub autoComplete_AutoCompleteItemSelected(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventArgs) Handles autoComplete1.AutoCompleteItemSelected, autoComplete2.AutoCompleteItemSelected
			Dim itemText As String = args.ItemArray(0).ToString()
			Dim eventlogmessage As String = String.Format("Event: {0} Item: {1}", "AutoCompleteItemSelected", itemText)
			AddLog(eventlogmessage)
		End Sub

		Private Sub comboBoxAdv2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxAdv2.SelectedIndexChanged
			Select Case Me.comboBoxAdv2.Text
				Case "MultiSuggest"
					Me.autoComplete2.SetAutoComplete(Me.comboBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggest)
					Me.autoComplete2.SetAutoComplete(Me.textBox4, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggest)

				Case "MultiSuggestExtended"
					Me.autoComplete2.SetAutoComplete(Me.comboBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggestExtended)
					Me.autoComplete2.SetAutoComplete(Me.textBox4, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggestExtended)
			End Select
			AddLog("AutoCompleteMode set to " & Me.comboBoxAdv2.Text)
		End Sub

		Private Sub textBox6_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBox6.TextChanged
			Try
				Me.autoComplete2.MaxNumberofSuggestion = Convert.ToInt16(textBox6.Text)
				Me.autoComplete1.MaxNumberofSuggestion = Me.autoComplete2.MaxNumberofSuggestion
			Catch exception As Exception
			End Try
		End Sub




	End Class
End Namespace
