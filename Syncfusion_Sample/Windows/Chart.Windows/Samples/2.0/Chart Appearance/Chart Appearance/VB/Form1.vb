Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing

Namespace ChartAppearance
	Public Class Form1
		Inherits Office2007Form
		#Region "Private Members"

		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private imageList1 As System.Windows.Forms.ImageList
		Private components As System.ComponentModel.IContainer
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private filename As String = Nothing
		Private groupBox2 As GroupBox
		Private groupBox1 As GroupBox
		Private label3 As Label
		Private WithEvents comboBox3 As ComboBox
		Private label4 As Label
		Private WithEvents numericUpDown4 As NumericUpDown
		Private label17 As Label
		Private panel2 As Panel
		Private WithEvents colorPickerButton3 As ColorPickerButton
		Private textBox1 As TextBox
		Private label18 As Label
		Private panel3 As Panel
		Private textBox2 As TextBox
		Private WithEvents colorPickerButton2 As ColorPickerButton
		Private WithEvents numericUpDown5 As NumericUpDown
		Private label2 As Label
		Private label1 As Label
		Private WithEvents comboBox1 As ComboBox
		Private label10 As Label
		Private label11 As Label
		Private label23 As Label
		Private panel5 As Panel
		Private textBox4 As TextBox
		Private WithEvents colorPickerButton6 As ColorPickerButton
		Private panel4 As Panel
		Private textBox3 As TextBox
		Private WithEvents colorPickerButton5 As ColorPickerButton
		Private label34 As Label
		Private panel6 As Panel
		Private textBox5 As TextBox
		Private WithEvents colorPickerButton1 As ColorPickerButton
		Private panel7 As Panel
		Private textBox6 As TextBox
		Private WithEvents colorPickerButton7 As ColorPickerButton
		Private label35 As Label
		Private panel8 As Panel
		Private textBox7 As TextBox
		Private WithEvents colorPickerButton8 As ColorPickerButton
		Private panel9 As Panel
		Private textBox8 As TextBox
		Private WithEvents colorPickerButton9 As ColorPickerButton
		Private WithEvents button1 As Button
		Private WithEvents Btn_Clear As Button
		Private WithEvents comboBox8 As ComboBox
		Private label19 As Label
		Private label30 As Label
		Private WithEvents checkBox5 As CheckBox
		Private label31 As Label
		Private WithEvents comboBox9 As ComboBox
		Private WithEvents colorPickerButton4 As ColorPickerButton
		Private WithEvents comboBox6 As ComboBox
		Private label6 As Label
		Private label5 As Label
		Private WithEvents comboBox5 As ComboBox
		Private panel10 As Panel
		Private textBox9 As TextBox
		Private label20 As Label
		Private label15 As Label
		Private label22 As Label
		Private WithEvents numericUpDown3 As NumericUpDown
		Private label7 As Label
		Private WithEvents numericUpDown2 As NumericUpDown
		Private label8 As Label
		Private WithEvents numericUpDown1 As NumericUpDown
		Private WithEvents checkBox2 As CheckBox
		Private WithEvents checkBox3 As CheckBox
		Private label21 As Label
		Private WithEvents comboBox7 As ComboBox
		Private radioButton3 As RadioButton
		Private radioButton4 As RadioButton
		Private WithEvents checkBox1 As CheckBox
		Private label24 As Label
        Private label16 As Label
		Private label12 As Label
		Private label9 As Label
		Private label25 As Label
		Private label27 As Label
		Private label14 As Label
		Private label13 As Label
		Private label26 As Label
		Private label28 As Label
		Private radioButton1 As RadioButton
		Private label29 As Label
        Private toolTip1 As ToolTip
        Friend WithEvents Panel11 As System.Windows.Forms.Panel

		Private Font_Name As String

		#End Region

		#Region "Constructor, Main And Dispose"
		Public Sub New()
			InitializeComponent()

			InitializeControlSettings()
			InitializeChartData()
			FillControlPanel()

			Me.textBox8.BackColor = Color.FromArgb(191, 219, 254)
		End Sub

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		''' <summary>
		''' Form Load
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Me.colorPickerButton9.SelectedColor = System.Drawing.Color.FromArgb(191, 219, 254)
			Me.comboBox8.SelectedIndex = 5

			For i As Integer = 0 To 2
				Me.chartControl1.Series(i).Style.DisplayText = Me.checkBox1.Checked
				Me.chartControl1.Series(i).Style.TextOrientation = ChartTextOrientation.Up
            Next i
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
		End Sub

		#End Region

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.panel1 = New System.Windows.Forms.Panel
            Me.label29 = New System.Windows.Forms.Label
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.label28 = New System.Windows.Forms.Label
            Me.label27 = New System.Windows.Forms.Label
            Me.label14 = New System.Windows.Forms.Label
            Me.label13 = New System.Windows.Forms.Label
            Me.label26 = New System.Windows.Forms.Label
            Me.label16 = New System.Windows.Forms.Label
            Me.label12 = New System.Windows.Forms.Label
            Me.label9 = New System.Windows.Forms.Label
            Me.label25 = New System.Windows.Forms.Label
            Me.comboBox8 = New System.Windows.Forms.ComboBox
            Me.label24 = New System.Windows.Forms.Label
            Me.label11 = New System.Windows.Forms.Label
            Me.comboBox7 = New System.Windows.Forms.ComboBox
            Me.label22 = New System.Windows.Forms.Label
            Me.Btn_Clear = New System.Windows.Forms.Button
            Me.numericUpDown3 = New System.Windows.Forms.NumericUpDown
            Me.label30 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.button1 = New System.Windows.Forms.Button
            Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown
            Me.label21 = New System.Windows.Forms.Label
            Me.label8 = New System.Windows.Forms.Label
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.checkBox5 = New System.Windows.Forms.CheckBox
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.label19 = New System.Windows.Forms.Label
            Me.checkBox3 = New System.Windows.Forms.CheckBox
            Me.label35 = New System.Windows.Forms.Label
            Me.panel8 = New System.Windows.Forms.Panel
            Me.textBox7 = New System.Windows.Forms.TextBox
            Me.colorPickerButton8 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.label3 = New System.Windows.Forms.Label
            Me.comboBox3 = New System.Windows.Forms.ComboBox
            Me.label4 = New System.Windows.Forms.Label
            Me.numericUpDown4 = New System.Windows.Forms.NumericUpDown
            Me.label17 = New System.Windows.Forms.Label
            Me.panel2 = New System.Windows.Forms.Panel
            Me.colorPickerButton3 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.panel9 = New System.Windows.Forms.Panel
            Me.textBox8 = New System.Windows.Forms.TextBox
            Me.colorPickerButton9 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.radioButton3 = New System.Windows.Forms.RadioButton
            Me.label34 = New System.Windows.Forms.Label
            Me.panel6 = New System.Windows.Forms.Panel
            Me.textBox5 = New System.Windows.Forms.TextBox
            Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.radioButton4 = New System.Windows.Forms.RadioButton
            Me.panel7 = New System.Windows.Forms.Panel
            Me.textBox6 = New System.Windows.Forms.TextBox
            Me.colorPickerButton7 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.label10 = New System.Windows.Forms.Label
            Me.label23 = New System.Windows.Forms.Label
            Me.panel5 = New System.Windows.Forms.Panel
            Me.textBox4 = New System.Windows.Forms.TextBox
            Me.colorPickerButton6 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.panel4 = New System.Windows.Forms.Panel
            Me.textBox3 = New System.Windows.Forms.TextBox
            Me.colorPickerButton5 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label1 = New System.Windows.Forms.Label
            Me.label18 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.panel3 = New System.Windows.Forms.Panel
            Me.textBox2 = New System.Windows.Forms.TextBox
            Me.colorPickerButton2 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.numericUpDown5 = New System.Windows.Forms.NumericUpDown
            Me.panel10 = New System.Windows.Forms.Panel
            Me.textBox9 = New System.Windows.Forms.TextBox
            Me.colorPickerButton4 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.label31 = New System.Windows.Forms.Label
            Me.label15 = New System.Windows.Forms.Label
            Me.comboBox9 = New System.Windows.Forms.ComboBox
            Me.label20 = New System.Windows.Forms.Label
            Me.comboBox6 = New System.Windows.Forms.ComboBox
            Me.label6 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.comboBox5 = New System.Windows.Forms.ComboBox
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.Panel11 = New System.Windows.Forms.Panel
            Me.panel1.SuspendLayout()
            CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel8.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            CType(Me.numericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            Me.panel9.SuspendLayout()
            Me.panel6.SuspendLayout()
            Me.panel7.SuspendLayout()
            Me.panel5.SuspendLayout()
            Me.panel4.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.panel3.SuspendLayout()
            CType(Me.numericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel10.SuspendLayout()
            Me.Panel11.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.panel1.Controls.Add(Me.label27)
            Me.panel1.Controls.Add(Me.label14)
            Me.panel1.Controls.Add(Me.label13)
            Me.panel1.Controls.Add(Me.label12)
            Me.panel1.Controls.Add(Me.label9)
            Me.panel1.Controls.Add(Me.label25)
            Me.panel1.Controls.Add(Me.comboBox8)
            Me.panel1.Controls.Add(Me.label24)
            Me.panel1.Controls.Add(Me.label11)
            Me.panel1.Controls.Add(Me.label22)
            Me.panel1.Controls.Add(Me.Btn_Clear)
            Me.panel1.Controls.Add(Me.numericUpDown3)
            Me.panel1.Controls.Add(Me.label30)
            Me.panel1.Controls.Add(Me.label7)
            Me.panel1.Controls.Add(Me.button1)
            Me.panel1.Controls.Add(Me.numericUpDown2)
            Me.panel1.Controls.Add(Me.label8)
            Me.panel1.Controls.Add(Me.numericUpDown1)
            Me.panel1.Controls.Add(Me.checkBox5)
            Me.panel1.Controls.Add(Me.checkBox2)
            Me.panel1.Controls.Add(Me.label19)
            Me.panel1.Controls.Add(Me.checkBox3)
            Me.panel1.Controls.Add(Me.label35)
            Me.panel1.Controls.Add(Me.panel8)
            Me.panel1.Controls.Add(Me.groupBox1)
            Me.panel1.Controls.Add(Me.panel9)
            Me.panel1.Controls.Add(Me.label34)
            Me.panel1.Controls.Add(Me.panel6)
            Me.panel1.Controls.Add(Me.panel7)
            Me.panel1.Controls.Add(Me.label10)
            Me.panel1.Controls.Add(Me.label23)
            Me.panel1.Controls.Add(Me.panel5)
            Me.panel1.Controls.Add(Me.panel4)
            Me.panel1.Controls.Add(Me.groupBox2)
            Me.panel1.Controls.Add(Me.panel10)
            Me.panel1.Controls.Add(Me.label15)
            Me.panel1.Controls.Add(Me.label20)
            Me.panel1.Controls.Add(Me.comboBox6)
            Me.panel1.Controls.Add(Me.label6)
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Controls.Add(Me.comboBox5)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(484, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(370, 456)
            Me.panel1.TabIndex = 0
            '
            'label29
            '
            Me.label29.Image = CType(resources.GetObject("label29.Image"), System.Drawing.Image)
            Me.label29.Location = New System.Drawing.Point(393, 59)
            Me.label29.Name = "label29"
            Me.label29.Size = New System.Drawing.Size(20, 20)
            Me.label29.TabIndex = 68
            Me.toolTip1.SetToolTip(Me.label29, "Select Series and then select Symbol to apply in the chartcontrol")
            '
            'radioButton1
            '
            Me.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton1.Location = New System.Drawing.Point(365, 31)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(55, 18)
            Me.radioButton1.TabIndex = 67
            Me.radioButton1.Text = "Series 2"
            '
            'label28
            '
            Me.label28.AutoSize = True
            Me.label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.label28.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label28.Location = New System.Drawing.Point(250, 12)
            Me.label28.Name = "label28"
            Me.label28.Size = New System.Drawing.Size(70, 13)
            Me.label28.TabIndex = 66
            Me.label28.Text = "Select series:"
            '
            'label27
            '
            Me.label27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label27.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label27.Image = CType(resources.GetObject("label27.Image"), System.Drawing.Image)
            Me.label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label27.Location = New System.Drawing.Point(14, 340)
            Me.label27.Name = "label27"
            Me.label27.Size = New System.Drawing.Size(100, 24)
            Me.label27.TabIndex = 63
            Me.label27.Text = "Font settings"
            Me.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label14
            '
            Me.label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label14.Location = New System.Drawing.Point(18, 353)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(160, 1)
            Me.label14.TabIndex = 65
            '
            'label13
            '
            Me.label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label13.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label13.Image = CType(resources.GetObject("label13.Image"), System.Drawing.Image)
            Me.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label13.Location = New System.Drawing.Point(194, 340)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(69, 24)
            Me.label13.TabIndex = 64
            Me.label13.Text = "Shadow"
            Me.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label26
            '
            Me.label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label26.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label26.Image = CType(resources.GetObject("label26.Image"), System.Drawing.Image)
            Me.label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label26.Location = New System.Drawing.Point(31, 6)
            Me.label26.Name = "label26"
            Me.label26.Size = New System.Drawing.Size(113, 24)
            Me.label26.TabIndex = 62
            Me.label26.Text = "Series settings"
            Me.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label16
            '
            Me.label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label16.Location = New System.Drawing.Point(78, 19)
            Me.label16.Name = "label16"
            Me.label16.Size = New System.Drawing.Size(110, 1)
            Me.label16.TabIndex = 61
            '
            'label12
            '
            Me.label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label12.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label12.Image = CType(resources.GetObject("label12.Image"), System.Drawing.Image)
            Me.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label12.Location = New System.Drawing.Point(187, 159)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(76, 24)
            Me.label12.TabIndex = 60
            Me.label12.Text = "3D Mode"
            Me.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label9
            '
            Me.label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label9.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label9.Image = CType(resources.GetObject("label9.Image"), System.Drawing.Image)
            Me.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label9.Location = New System.Drawing.Point(4, 163)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(97, 24)
            Me.label9.TabIndex = 59
            Me.label9.Text = "      Background " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      Settings"
            Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label25
            '
            Me.label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label25.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label25.Image = CType(resources.GetObject("label25.Image"), System.Drawing.Image)
            Me.label25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label25.Location = New System.Drawing.Point(10, 5)
            Me.label25.Name = "label25"
            Me.label25.Size = New System.Drawing.Size(117, 24)
            Me.label25.TabIndex = 58
            Me.label25.Text = "Border Settings"
            Me.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'comboBox8
            '
            Me.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox8.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox8.Location = New System.Drawing.Point(90, 285)
            Me.comboBox8.Name = "comboBox8"
            Me.comboBox8.Size = New System.Drawing.Size(87, 21)
            Me.comboBox8.TabIndex = 35
            '
            'label24
            '
            Me.label24.ForeColor = System.Drawing.Color.Black
            Me.label24.Location = New System.Drawing.Point(14, 311)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(69, 29)
            Me.label24.TabIndex = 57
            Me.label24.Text = "Background Image"
            '
            'label11
            '
            Me.label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label11.Location = New System.Drawing.Point(14, 177)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(160, 1)
            Me.label11.TabIndex = 26
            '
            'comboBox7
            '
            Me.comboBox7.Cursor = System.Windows.Forms.Cursors.Hand
            Me.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox7.ForeColor = System.Drawing.Color.Black
            Me.comboBox7.Location = New System.Drawing.Point(325, 57)
            Me.comboBox7.Name = "comboBox7"
            Me.comboBox7.Size = New System.Drawing.Size(64, 21)
            Me.comboBox7.TabIndex = 56
            '
            'label22
            '
            Me.label22.AutoSize = True
            Me.label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.label22.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label22.ForeColor = System.Drawing.Color.Black
            Me.label22.Location = New System.Drawing.Point(197, 313)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(21, 13)
            Me.label22.TabIndex = 52
            Me.label22.Text = "Tilt"
            '
            'Btn_Clear
            '
            Me.Btn_Clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Btn_Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Btn_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Btn_Clear.ForeColor = System.Drawing.Color.MidnightBlue
            Me.Btn_Clear.Image = CType(resources.GetObject("Btn_Clear.Image"), System.Drawing.Image)
            Me.Btn_Clear.Location = New System.Drawing.Point(138, 316)
            Me.Btn_Clear.Name = "Btn_Clear"
            Me.Btn_Clear.Size = New System.Drawing.Size(22, 23)
            Me.Btn_Clear.TabIndex = 31
            Me.Btn_Clear.UseVisualStyleBackColor = True
            Me.Btn_Clear.Visible = False
            '
            'numericUpDown3
            '
            Me.numericUpDown3.Location = New System.Drawing.Point(291, 312)
            Me.numericUpDown3.Name = "numericUpDown3"
            Me.numericUpDown3.ReadOnly = True
            Me.numericUpDown3.Size = New System.Drawing.Size(49, 20)
            Me.numericUpDown3.TabIndex = 51
            Me.numericUpDown3.Value = New Decimal(New Integer() {30, 0, 0, 0})
            '
            'label30
            '
            Me.label30.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label30.Location = New System.Drawing.Point(199, 355)
            Me.label30.Name = "label30"
            Me.label30.Size = New System.Drawing.Size(160, 1)
            Me.label30.TabIndex = 35
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.label7.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label7.ForeColor = System.Drawing.Color.Black
            Me.label7.Location = New System.Drawing.Point(197, 285)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(78, 13)
            Me.label7.TabIndex = 50
            Me.label7.Text = "Series Spacing"
            '
            'button1
            '
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.button1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.button1.Location = New System.Drawing.Point(92, 316)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(22, 23)
            Me.button1.TabIndex = 28
            Me.button1.Text = "..."
            Me.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.button1.UseVisualStyleBackColor = True
            '
            'numericUpDown2
            '
            Me.numericUpDown2.Location = New System.Drawing.Point(291, 283)
            Me.numericUpDown2.Name = "numericUpDown2"
            Me.numericUpDown2.ReadOnly = True
            Me.numericUpDown2.Size = New System.Drawing.Size(49, 20)
            Me.numericUpDown2.TabIndex = 49
            '
            'label21
            '
            Me.label21.AutoSize = True
            Me.label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.label21.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label21.ForeColor = System.Drawing.Color.Black
            Me.label21.Location = New System.Drawing.Point(248, 60)
            Me.label21.Name = "label21"
            Me.label21.Size = New System.Drawing.Size(75, 13)
            Me.label21.TabIndex = 55
            Me.label21.Text = "Symbol Shape"
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.label8.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label8.ForeColor = System.Drawing.Color.Black
            Me.label8.Location = New System.Drawing.Point(197, 257)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(71, 13)
            Me.label8.TabIndex = 48
            Me.label8.Text = " Z Axis Depth"
            '
            'numericUpDown1
            '
            Me.numericUpDown1.Location = New System.Drawing.Point(291, 253)
            Me.numericUpDown1.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
            Me.numericUpDown1.Minimum = New Decimal(New Integer() {20, 0, 0, 0})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.ReadOnly = True
            Me.numericUpDown1.Size = New System.Drawing.Size(49, 20)
            Me.numericUpDown1.TabIndex = 47
            Me.numericUpDown1.Value = New Decimal(New Integer() {20, 0, 0, 0})
            '
            'checkBox5
            '
            Me.checkBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.checkBox5.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox5.ForeColor = System.Drawing.Color.Black
            Me.checkBox5.Location = New System.Drawing.Point(193, 367)
            Me.checkBox5.Name = "checkBox5"
            Me.checkBox5.Size = New System.Drawing.Size(136, 17)
            Me.checkBox5.TabIndex = 34
            Me.checkBox5.Text = "Show ChartArea Shadow"
            Me.checkBox5.UseVisualStyleBackColor = False
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox2.ForeColor = System.Drawing.Color.Black
            Me.checkBox2.Location = New System.Drawing.Point(197, 224)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(86, 18)
            Me.checkBox2.TabIndex = 46
            Me.checkBox2.Text = "Rotate Axis"
            Me.checkBox2.UseVisualStyleBackColor = False
            '
            'label19
            '
            Me.label19.AutoSize = True
            Me.label19.ForeColor = System.Drawing.Color.Black
            Me.label19.Location = New System.Drawing.Point(14, 287)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(73, 13)
            Me.label19.TabIndex = 36
            Me.label19.Text = "Gradient Style"
            '
            'checkBox3
            '
            Me.checkBox3.AutoSize = True
            Me.checkBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox3.ForeColor = System.Drawing.Color.Black
            Me.checkBox3.Location = New System.Drawing.Point(197, 191)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(76, 18)
            Me.checkBox3.TabIndex = 45
            Me.checkBox3.Text = "3D Mode"
            Me.checkBox3.UseVisualStyleBackColor = False
            '
            'label35
            '
            Me.label35.AutoSize = True
            Me.label35.ForeColor = System.Drawing.Color.Black
            Me.label35.Location = New System.Drawing.Point(14, 256)
            Me.label35.Name = "label35"
            Me.label35.Size = New System.Drawing.Size(67, 13)
            Me.label35.TabIndex = 34
            Me.label35.Text = "Chart Interior"
            '
            'panel8
            '
            Me.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel8.Controls.Add(Me.textBox7)
            Me.panel8.Controls.Add(Me.colorPickerButton8)
            Me.panel8.Location = New System.Drawing.Point(138, 254)
            Me.panel8.Name = "panel8"
            Me.panel8.Size = New System.Drawing.Size(41, 21)
            Me.panel8.TabIndex = 33
            '
            'textBox7
            '
            Me.textBox7.BackColor = System.Drawing.Color.White
            Me.textBox7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox7.Location = New System.Drawing.Point(0, 0)
            Me.textBox7.Name = "textBox7"
            Me.textBox7.ReadOnly = True
            Me.textBox7.Size = New System.Drawing.Size(22, 20)
            Me.textBox7.TabIndex = 11
            '
            'colorPickerButton8
            '
            Me.colorPickerButton8.BackColor = System.Drawing.Color.White
            Me.colorPickerButton8.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton8.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton8.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton8.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton8.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton8.Image = CType(resources.GetObject("colorPickerButton8.Image"), System.Drawing.Image)
            Me.colorPickerButton8.Location = New System.Drawing.Point(22, 0)
            Me.colorPickerButton8.Name = "colorPickerButton8"
            Me.colorPickerButton8.SelectedAsBackcolor = True
            Me.colorPickerButton8.SelectedColor = System.Drawing.Color.White
            Me.colorPickerButton8.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton8.Size = New System.Drawing.Size(17, 19)
            Me.colorPickerButton8.TabIndex = 15
            Me.colorPickerButton8.Text = "..."
            Me.colorPickerButton8.UseVisualStyleBackColor = False
            '
            'groupBox1
            '
            Me.groupBox1.BackColor = System.Drawing.Color.Transparent
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.comboBox3)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.numericUpDown4)
            Me.groupBox1.Controls.Add(Me.label17)
            Me.groupBox1.Controls.Add(Me.panel2)
            Me.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.groupBox1.Location = New System.Drawing.Point(7, 32)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(172, 119)
            Me.groupBox1.TabIndex = 23
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Chart Control"
            '
            'label3
            '
            Me.label3.ForeColor = System.Drawing.Color.Black
            Me.label3.Location = New System.Drawing.Point(4, 25)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(71, 15)
            Me.label3.TabIndex = 4
            Me.label3.Text = "Border Style"
            '
            'comboBox3
            '
            Me.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox3.Location = New System.Drawing.Point(89, 22)
            Me.comboBox3.Name = "comboBox3"
            Me.comboBox3.Size = New System.Drawing.Size(80, 21)
            Me.comboBox3.TabIndex = 6
            '
            'label4
            '
            Me.label4.ForeColor = System.Drawing.Color.Black
            Me.label4.Location = New System.Drawing.Point(3, 49)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(72, 20)
            Me.label4.TabIndex = 10
            Me.label4.Text = "Border Width"
            '
            'numericUpDown4
            '
            Me.numericUpDown4.Location = New System.Drawing.Point(91, 49)
            Me.numericUpDown4.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
            Me.numericUpDown4.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown4.Name = "numericUpDown4"
            Me.numericUpDown4.Size = New System.Drawing.Size(48, 20)
            Me.numericUpDown4.TabIndex = 11
            Me.numericUpDown4.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'label17
            '
            Me.label17.ForeColor = System.Drawing.Color.Black
            Me.label17.Location = New System.Drawing.Point(4, 75)
            Me.label17.Name = "label17"
            Me.label17.Size = New System.Drawing.Size(71, 20)
            Me.label17.TabIndex = 13
            Me.label17.Text = "Border Color"
            '
            'panel2
            '
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.Add(Me.colorPickerButton3)
            Me.panel2.Controls.Add(Me.textBox1)
            Me.panel2.Location = New System.Drawing.Point(92, 75)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(47, 21)
            Me.panel2.TabIndex = 14
            '
            'colorPickerButton3
            '
            Me.colorPickerButton3.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton3.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton3.Location = New System.Drawing.Point(28, 0)
            Me.colorPickerButton3.Name = "colorPickerButton3"
            Me.colorPickerButton3.SelectedAsBackcolor = True
            Me.colorPickerButton3.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton3.Size = New System.Drawing.Size(17, 19)
            Me.colorPickerButton3.TabIndex = 6
            Me.colorPickerButton3.Text = "..."
            Me.colorPickerButton3.UseVisualStyleBackColor = False
            '
            'textBox1
            '
            Me.textBox1.BackColor = System.Drawing.Color.Black
            Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox1.Location = New System.Drawing.Point(0, 0)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.ReadOnly = True
            Me.textBox1.Size = New System.Drawing.Size(45, 20)
            Me.textBox1.TabIndex = 11
            '
            'panel9
            '
            Me.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel9.Controls.Add(Me.textBox8)
            Me.panel9.Controls.Add(Me.colorPickerButton9)
            Me.panel9.Location = New System.Drawing.Point(90, 253)
            Me.panel9.Name = "panel9"
            Me.panel9.Size = New System.Drawing.Size(41, 21)
            Me.panel9.TabIndex = 32
            '
            'textBox8
            '
            Me.textBox8.BackColor = System.Drawing.Color.White
            Me.textBox8.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox8.Location = New System.Drawing.Point(0, 0)
            Me.textBox8.Name = "textBox8"
            Me.textBox8.ReadOnly = True
            Me.textBox8.Size = New System.Drawing.Size(22, 20)
            Me.textBox8.TabIndex = 11
            '
            'colorPickerButton9
            '
            Me.colorPickerButton9.BackColor = System.Drawing.Color.White
            Me.colorPickerButton9.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton9.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton9.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton9.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton9.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton9.Image = CType(resources.GetObject("colorPickerButton9.Image"), System.Drawing.Image)
            Me.colorPickerButton9.Location = New System.Drawing.Point(22, 0)
            Me.colorPickerButton9.Name = "colorPickerButton9"
            Me.colorPickerButton9.SelectedAsBackcolor = True
            Me.colorPickerButton9.SelectedColor = System.Drawing.Color.White
            Me.colorPickerButton9.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton9.Size = New System.Drawing.Size(17, 19)
            Me.colorPickerButton9.TabIndex = 14
            Me.colorPickerButton9.Text = "..."
            Me.colorPickerButton9.UseVisualStyleBackColor = False
            '
            'radioButton3
            '
            Me.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton3.Location = New System.Drawing.Point(307, 31)
            Me.radioButton3.Name = "radioButton3"
            Me.radioButton3.Size = New System.Drawing.Size(55, 18)
            Me.radioButton3.TabIndex = 54
            Me.radioButton3.Text = "Series 1"
            '
            'label34
            '
            Me.label34.AutoSize = True
            Me.label34.ForeColor = System.Drawing.Color.Black
            Me.label34.Location = New System.Drawing.Point(14, 227)
            Me.label34.Name = "label34"
            Me.label34.Size = New System.Drawing.Size(57, 13)
            Me.label34.TabIndex = 31
            Me.label34.Text = "Chart Area"
            '
            'panel6
            '
            Me.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel6.Controls.Add(Me.textBox5)
            Me.panel6.Controls.Add(Me.colorPickerButton1)
            Me.panel6.Location = New System.Drawing.Point(138, 224)
            Me.panel6.Name = "panel6"
            Me.panel6.Size = New System.Drawing.Size(41, 21)
            Me.panel6.TabIndex = 30
            '
            'textBox5
            '
            Me.textBox5.BackColor = System.Drawing.Color.White
            Me.textBox5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox5.Location = New System.Drawing.Point(0, 0)
            Me.textBox5.Name = "textBox5"
            Me.textBox5.ReadOnly = True
            Me.textBox5.Size = New System.Drawing.Size(22, 20)
            Me.textBox5.TabIndex = 11
            '
            'colorPickerButton1
            '
            Me.colorPickerButton1.BackColor = System.Drawing.Color.White
            Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton1.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton1.Image = CType(resources.GetObject("colorPickerButton1.Image"), System.Drawing.Image)
            Me.colorPickerButton1.Location = New System.Drawing.Point(22, 0)
            Me.colorPickerButton1.Name = "colorPickerButton1"
            Me.colorPickerButton1.SelectedAsBackcolor = True
            Me.colorPickerButton1.SelectedColor = System.Drawing.Color.White
            Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton1.Size = New System.Drawing.Size(17, 19)
            Me.colorPickerButton1.TabIndex = 15
            Me.colorPickerButton1.Text = "..."
            Me.colorPickerButton1.UseVisualStyleBackColor = False
            '
            'radioButton4
            '
            Me.radioButton4.Checked = True
            Me.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand
            Me.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton4.Location = New System.Drawing.Point(247, 31)
            Me.radioButton4.Name = "radioButton4"
            Me.radioButton4.Size = New System.Drawing.Size(58, 18)
            Me.radioButton4.TabIndex = 53
            Me.radioButton4.TabStop = True
            Me.radioButton4.Text = "Series 0"
            '
            'panel7
            '
            Me.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel7.Controls.Add(Me.textBox6)
            Me.panel7.Controls.Add(Me.colorPickerButton7)
            Me.panel7.Location = New System.Drawing.Point(90, 224)
            Me.panel7.Name = "panel7"
            Me.panel7.Size = New System.Drawing.Size(41, 21)
            Me.panel7.TabIndex = 29
            '
            'textBox6
            '
            Me.textBox6.BackColor = System.Drawing.Color.White
            Me.textBox6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox6.Location = New System.Drawing.Point(0, 0)
            Me.textBox6.Name = "textBox6"
            Me.textBox6.ReadOnly = True
            Me.textBox6.Size = New System.Drawing.Size(22, 20)
            Me.textBox6.TabIndex = 11
            '
            'colorPickerButton7
            '
            Me.colorPickerButton7.BackColor = System.Drawing.Color.White
            Me.colorPickerButton7.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton7.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton7.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton7.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton7.Image = CType(resources.GetObject("colorPickerButton7.Image"), System.Drawing.Image)
            Me.colorPickerButton7.Location = New System.Drawing.Point(22, 0)
            Me.colorPickerButton7.Name = "colorPickerButton7"
            Me.colorPickerButton7.SelectedAsBackcolor = True
            Me.colorPickerButton7.SelectedColor = System.Drawing.Color.White
            Me.colorPickerButton7.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton7.Size = New System.Drawing.Size(17, 19)
            Me.colorPickerButton7.TabIndex = 14
            Me.colorPickerButton7.Text = "..."
            Me.colorPickerButton7.UseVisualStyleBackColor = False
            '
            'label10
            '
            Me.label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label10.Location = New System.Drawing.Point(128, 21)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(225, 1)
            Me.label10.TabIndex = 7
            '
            'label23
            '
            Me.label23.AutoSize = True
            Me.label23.ForeColor = System.Drawing.Color.Black
            Me.label23.Location = New System.Drawing.Point(14, 198)
            Me.label23.Name = "label23"
            Me.label23.Size = New System.Drawing.Size(68, 13)
            Me.label23.TabIndex = 28
            Me.label23.Text = "Chart Control"
            '
            'panel5
            '
            Me.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel5.Controls.Add(Me.textBox4)
            Me.panel5.Controls.Add(Me.colorPickerButton6)
            Me.panel5.Location = New System.Drawing.Point(139, 196)
            Me.panel5.Name = "panel5"
            Me.panel5.Size = New System.Drawing.Size(41, 21)
            Me.panel5.TabIndex = 26
            '
            'textBox4
            '
            Me.textBox4.BackColor = System.Drawing.Color.White
            Me.textBox4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox4.Location = New System.Drawing.Point(0, 0)
            Me.textBox4.Name = "textBox4"
            Me.textBox4.ReadOnly = True
            Me.textBox4.Size = New System.Drawing.Size(22, 20)
            Me.textBox4.TabIndex = 11
            '
            'colorPickerButton6
            '
            Me.colorPickerButton6.BackColor = System.Drawing.Color.White
            Me.colorPickerButton6.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton6.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton6.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton6.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton6.Image = CType(resources.GetObject("colorPickerButton6.Image"), System.Drawing.Image)
            Me.colorPickerButton6.Location = New System.Drawing.Point(22, 0)
            Me.colorPickerButton6.Name = "colorPickerButton6"
            Me.colorPickerButton6.SelectedAsBackcolor = True
            Me.colorPickerButton6.SelectedColor = System.Drawing.Color.White
            Me.colorPickerButton6.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton6.Size = New System.Drawing.Size(17, 19)
            Me.colorPickerButton6.TabIndex = 15
            Me.colorPickerButton6.Text = "..."
            Me.colorPickerButton6.UseVisualStyleBackColor = False
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox1.Location = New System.Drawing.Point(27, 65)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(136, 18)
            Me.checkBox1.TabIndex = 52
            Me.checkBox1.Text = "Show Data Point Text"
            Me.checkBox1.UseVisualStyleBackColor = False
            '
            'panel4
            '
            Me.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel4.Controls.Add(Me.textBox3)
            Me.panel4.Controls.Add(Me.colorPickerButton5)
            Me.panel4.Location = New System.Drawing.Point(90, 195)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(41, 21)
            Me.panel4.TabIndex = 25
            '
            'textBox3
            '
            Me.textBox3.BackColor = System.Drawing.Color.White
            Me.textBox3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox3.Location = New System.Drawing.Point(0, 0)
            Me.textBox3.Name = "textBox3"
            Me.textBox3.ReadOnly = True
            Me.textBox3.Size = New System.Drawing.Size(22, 20)
            Me.textBox3.TabIndex = 11
            '
            'colorPickerButton5
            '
            Me.colorPickerButton5.BackColor = System.Drawing.Color.White
            Me.colorPickerButton5.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton5.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton5.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton5.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton5.Image = CType(resources.GetObject("colorPickerButton5.Image"), System.Drawing.Image)
            Me.colorPickerButton5.Location = New System.Drawing.Point(22, 0)
            Me.colorPickerButton5.Name = "colorPickerButton5"
            Me.colorPickerButton5.SelectedAsBackcolor = True
            Me.colorPickerButton5.SelectedColor = System.Drawing.Color.White
            Me.colorPickerButton5.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton5.Size = New System.Drawing.Size(17, 19)
            Me.colorPickerButton5.TabIndex = 14
            Me.colorPickerButton5.Text = "..."
            Me.colorPickerButton5.UseVisualStyleBackColor = False
            '
            'groupBox2
            '
            Me.groupBox2.BackColor = System.Drawing.Color.Transparent
            Me.groupBox2.Controls.Add(Me.comboBox1)
            Me.groupBox2.Controls.Add(Me.label1)
            Me.groupBox2.Controls.Add(Me.label18)
            Me.groupBox2.Controls.Add(Me.label2)
            Me.groupBox2.Controls.Add(Me.panel3)
            Me.groupBox2.Controls.Add(Me.numericUpDown5)
            Me.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.groupBox2.Location = New System.Drawing.Point(185, 33)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(172, 119)
            Me.groupBox2.TabIndex = 24
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Chart Series"
            '
            'comboBox1
            '
            Me.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox1.Location = New System.Drawing.Point(96, 19)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(68, 21)
            Me.comboBox1.TabIndex = 16
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label1.ForeColor = System.Drawing.Color.Black
            Me.label1.Location = New System.Drawing.Point(6, 22)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(89, 13)
            Me.label1.TabIndex = 15
            Me.label1.Text = "Border DashStyle"
            '
            'label18
            '
            Me.label18.AutoSize = True
            Me.label18.ForeColor = System.Drawing.Color.Black
            Me.label18.Location = New System.Drawing.Point(2, 78)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(65, 13)
            Me.label18.TabIndex = 22
            Me.label18.Text = "Border Color"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.ForeColor = System.Drawing.Color.Black
            Me.label2.Location = New System.Drawing.Point(3, 50)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(69, 13)
            Me.label2.TabIndex = 19
            Me.label2.Text = "Border Width"
            '
            'panel3
            '
            Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel3.Controls.Add(Me.textBox2)
            Me.panel3.Controls.Add(Me.colorPickerButton2)
            Me.panel3.Location = New System.Drawing.Point(96, 79)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(47, 21)
            Me.panel3.TabIndex = 21
            '
            'textBox2
            '
            Me.textBox2.BackColor = System.Drawing.Color.Black
            Me.textBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox2.Location = New System.Drawing.Point(0, 0)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.ReadOnly = True
            Me.textBox2.Size = New System.Drawing.Size(28, 20)
            Me.textBox2.TabIndex = 11
            '
            'colorPickerButton2
            '
            Me.colorPickerButton2.BackColor = System.Drawing.Color.Transparent
            Me.colorPickerButton2.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton2.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton2.Location = New System.Drawing.Point(28, 0)
            Me.colorPickerButton2.Name = "colorPickerButton2"
            Me.colorPickerButton2.SelectedAsBackcolor = True
            Me.colorPickerButton2.SelectedColor = System.Drawing.Color.Transparent
            Me.colorPickerButton2.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton2.Size = New System.Drawing.Size(17, 19)
            Me.colorPickerButton2.TabIndex = 5
            Me.colorPickerButton2.Text = "..."
            Me.colorPickerButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.colorPickerButton2.UseVisualStyleBackColor = False
            '
            'numericUpDown5
            '
            Me.numericUpDown5.Location = New System.Drawing.Point(96, 51)
            Me.numericUpDown5.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
            Me.numericUpDown5.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown5.Name = "numericUpDown5"
            Me.numericUpDown5.Size = New System.Drawing.Size(47, 20)
            Me.numericUpDown5.TabIndex = 20
            Me.numericUpDown5.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'panel10
            '
            Me.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel10.Controls.Add(Me.textBox9)
            Me.panel10.Controls.Add(Me.colorPickerButton4)
            Me.panel10.Location = New System.Drawing.Point(77, 425)
            Me.panel10.Name = "panel10"
            Me.panel10.Size = New System.Drawing.Size(47, 21)
            Me.panel10.TabIndex = 49
            '
            'textBox9
            '
            Me.textBox9.BackColor = System.Drawing.Color.Black
            Me.textBox9.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox9.Location = New System.Drawing.Point(0, 0)
            Me.textBox9.Name = "textBox9"
            Me.textBox9.ReadOnly = True
            Me.textBox9.Size = New System.Drawing.Size(25, 20)
            Me.textBox9.TabIndex = 11
            '
            'colorPickerButton4
            '
            Me.colorPickerButton4.BackColor = System.Drawing.Color.Transparent
            Me.colorPickerButton4.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton4.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton4.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton4.Location = New System.Drawing.Point(25, 0)
            Me.colorPickerButton4.Name = "colorPickerButton4"
            Me.colorPickerButton4.SelectedAsBackcolor = True
            Me.colorPickerButton4.SelectedColor = System.Drawing.Color.Transparent
            Me.colorPickerButton4.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors
            Me.colorPickerButton4.Size = New System.Drawing.Size(20, 19)
            Me.colorPickerButton4.TabIndex = 45
            Me.colorPickerButton4.Text = "..."
            Me.colorPickerButton4.UseVisualStyleBackColor = False
            '
            'label31
            '
            Me.label31.AutoSize = True
            Me.label31.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.label31.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label31.ForeColor = System.Drawing.Color.Black
            Me.label31.Location = New System.Drawing.Point(29, 39)
            Me.label31.Name = "label31"
            Me.label31.Size = New System.Drawing.Size(67, 13)
            Me.label31.TabIndex = 37
            Me.label31.Text = "Color Palette"
            '
            'label15
            '
            Me.label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label15.Location = New System.Drawing.Point(244, 169)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(110, 1)
            Me.label15.TabIndex = 51
            '
            'comboBox9
            '
            Me.comboBox9.Cursor = System.Windows.Forms.Cursors.Hand
            Me.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox9.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox9.Location = New System.Drawing.Point(98, 36)
            Me.comboBox9.Name = "comboBox9"
            Me.comboBox9.Size = New System.Drawing.Size(96, 21)
            Me.comboBox9.TabIndex = 36
            '
            'label20
            '
            Me.label20.AutoSize = True
            Me.label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.label20.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label20.Location = New System.Drawing.Point(14, 429)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(55, 13)
            Me.label20.TabIndex = 48
            Me.label20.Text = "Font Color"
            '
            'comboBox6
            '
            Me.comboBox6.Cursor = System.Windows.Forms.Cursors.Hand
            Me.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox6.Location = New System.Drawing.Point(77, 398)
            Me.comboBox6.Name = "comboBox6"
            Me.comboBox6.Size = New System.Drawing.Size(96, 21)
            Me.comboBox6.TabIndex = 43
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.label6.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label6.Location = New System.Drawing.Point(14, 400)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(51, 13)
            Me.label6.TabIndex = 44
            Me.label6.Text = "FontStyle"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.label5.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label5.Location = New System.Drawing.Point(14, 374)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(52, 13)
            Me.label5.TabIndex = 41
            Me.label5.Text = "FontFace"
            '
            'comboBox5
            '
            Me.comboBox5.Cursor = System.Windows.Forms.Cursors.Hand
            Me.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox5.Items.AddRange(New Object() {"Agency FB", "Arial", "Book Antiqua", "Bookman Old Style", "Bradley Hand ITC", "Courier New", "Curlz MT", "Estrangelo Edessa", "Felix Titling", "Gautami", "Gill Sans MT Ext Condensed Bold", "Impact", "Microsoft Sans Serif", "MS Outlook", "Pristina", "Raavi", "Symbol", "Tahoma", "Times New Roman"})
            Me.comboBox5.Location = New System.Drawing.Point(77, 371)
            Me.comboBox5.Name = "comboBox5"
            Me.comboBox5.Size = New System.Drawing.Size(97, 21)
            Me.comboBox5.TabIndex = 42
            '
            'chartControl1
            '
            Me.chartControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer)))
            '
            '
            '
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)))
            Me.chartControl1.Legend.Location = New System.Drawing.Point(338, 31)
            Me.chartControl1.Location = New System.Drawing.Point(17, 7)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.Size = New System.Drawing.Size(454, 347)
            Me.chartControl1.TabIndex = 0
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = ""
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            '
            'timer1
            '
            '
            'Panel11
            '
            Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.Panel11.Controls.Add(Me.label29)
            Me.Panel11.Controls.Add(Me.label21)
            Me.Panel11.Controls.Add(Me.radioButton1)
            Me.Panel11.Controls.Add(Me.comboBox9)
            Me.Panel11.Controls.Add(Me.label28)
            Me.Panel11.Controls.Add(Me.label31)
            Me.Panel11.Controls.Add(Me.checkBox1)
            Me.Panel11.Controls.Add(Me.radioButton4)
            Me.Panel11.Controls.Add(Me.radioButton3)
            Me.Panel11.Controls.Add(Me.label26)
            Me.Panel11.Controls.Add(Me.comboBox7)
            Me.Panel11.Controls.Add(Me.label16)
            Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel11.Location = New System.Drawing.Point(0, 361)
            Me.Panel11.Name = "Panel11"
            Me.Panel11.Size = New System.Drawing.Size(484, 95)
            Me.Panel11.TabIndex = 1
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(854, 456)
            Me.Controls.Add(Me.Panel11)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Appearance"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel8.ResumeLayout(False)
            Me.panel8.PerformLayout()
            Me.groupBox1.ResumeLayout(False)
            CType(Me.numericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.panel9.ResumeLayout(False)
            Me.panel9.PerformLayout()
            Me.panel6.ResumeLayout(False)
            Me.panel6.PerformLayout()
            Me.panel7.ResumeLayout(False)
            Me.panel7.PerformLayout()
            Me.panel5.ResumeLayout(False)
            Me.panel5.PerformLayout()
            Me.panel4.ResumeLayout(False)
            Me.panel4.PerformLayout()
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            CType(Me.numericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel10.ResumeLayout(False)
            Me.panel10.PerformLayout()
            Me.Panel11.ResumeLayout(False)
            Me.Panel11.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		#Region "Helper Methods"

		#Region "InitializeChartData"

		''' <summary>
		''' In this method chart data has been Initialized.
		''' </summary>
		Protected Sub InitializeChartData()
			' Top 5 olympic medal winners
            Dim series1 As ChartSeries = New ChartSeries("Gold")
			series1.Text = "Gold"
			series1.Type = ChartSeriesType.Column

            Dim series2 As ChartSeries = New ChartSeries("Silver")
			series2.Text = "Silver"
			series2.Type = ChartSeriesType.Column

            Dim series3 As ChartSeries = New ChartSeries("Bronze")
			series3.Text = "Bronze"
			series3.Type = ChartSeriesType.Column

			' USA
			series1.Points.Add(1, 35)
			series2.Points.Add(1, 39)
			series3.Points.Add(1, 29)

			' China
			series1.Points.Add(2, 32)
			series2.Points.Add(2, 17)
			series3.Points.Add(2, 14)

			' Russia
			series1.Points.Add(3, 27)
			series2.Points.Add(3, 27)
			series3.Points.Add(3, 28)

			' Australia
			series1.Points.Add(4, 17)
			series2.Points.Add(4, 16)
			series3.Points.Add(4, 16)

			' China
			series1.Points.Add(5, 16)
			series2.Points.Add(5, 9)
			series3.Points.Add(5, 12)

			series1.Style.Images = New ChartImageCollection(Me.imageList1.Images)
			series2.Style.Images = New ChartImageCollection(Me.imageList1.Images)
			series3.Style.Images = New ChartImageCollection(Me.imageList1.Images)

			Me.chartControl1.Series.Add(series1)
			Me.chartControl1.Series.Add(series2)
			Me.chartControl1.Series.Add(series3)

			For i As Integer = 0 To series1.Points.Count - 1
				series1.Styles(i).Text = String.Format("{0}", series1.Points(i).YValues(0))
			Next i

			For i As Integer = 0 To series2.Points.Count - 1
				series2.Styles(i).Text = String.Format("{0}", series2.Points(i).YValues(0))
			Next i

			For i As Integer = 0 To series3.Points.Count - 1
				series3.Styles(i).Text = String.Format("{0}", series3.Points(i).YValues(0))
			Next i
		End Sub

		#End Region

		#Region "InitializeControlSettings"
		''' <summary>
		''' Setting Chart control properties.
		''' </summary>
		Private Sub InitializeControlSettings()
			Me.chartControl1.Font = New System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))

			Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White)
			Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
			Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.White, System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(219))))), (CInt(Fix((CByte(254)))))))

			Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.DarkGray
			Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = Color.DarkGray

			Me.chartControl1.PrimaryXAxis.LineType.ForeColor = Color.DarkGray
			Me.chartControl1.PrimaryYAxis.LineType.ForeColor = Color.DarkGray

			Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.FromArgb(196, 222, 254))
			Me.chartControl1.Legend.Border.ForeColor = Color.DarkGray
			Me.chartControl1.LegendsPlacement = ChartPlacement.Outside
			Me.chartControl1.LegendAlignment = ChartAlignment.Center

			Me.checkBox2.Enabled = False
			Me.numericUpDown1.Enabled = False
			Me.numericUpDown2.Enabled = False
			Me.numericUpDown3.Enabled = False

			For Each series As ChartSeries In Me.chartControl1.Series
				If series Is Me.chartControl1.Series(0) Then
					series.Style.Images = New ChartImageCollection(Me.imageList1.Images)
					series.Style.Symbol.Shape = ChartSymbolShape.Image
					series.Style.Symbol.Size = New Size(16, 16)
					series.Style.ImageIndex = 0
				End If

				series.Style.Symbol.Color = Color.Yellow
				series.Style.DisplayShadow = False
				series.Style.PointWidth = 2

				series.Style.Font.Bold = True
			Next series
			Me.chartControl1.ColumnDrawMode = ChartColumnDrawMode.PlaneMode

			Me.chartControl1.LegendPosition = ChartDock.Top
			Me.chartControl1.PrimaryXAxis.LabelRotate = True

			Me.chartControl1.Spacing = 20
		End Sub
		#End Region

		#Region "FillControlPanel"

		''' <summary>
		''' Initializes the control values.
		''' </summary>
		Protected Sub FillControlPanel()
			For Each linetype As String In System.Enum.GetNames(GetType(System.Drawing.Drawing2D.DashStyle))
				Me.comboBox1.Items.Add(linetype)
			Next linetype
			For Each linetype1 As String In System.Enum.GetNames(GetType(BorderStyle))
				Me.comboBox3.Items.Add(linetype1)
			Next linetype1
			For Each fontstyle As String In System.Enum.GetNames(GetType(System.Drawing.FontStyle))
				Me.comboBox6.Items.Add(fontstyle)
			Next fontstyle
			For Each gradient As String In System.Enum.GetNames(GetType(Syncfusion.Drawing.GradientStyle))
				Me.comboBox8.Items.Add(gradient)
			Next gradient
			For Each palette As String In System.Enum.GetNames(GetType(Syncfusion.Windows.Forms.Chart.ChartColorPalette))
				Me.comboBox9.Items.Add(palette)
			Next palette
			For Each symbol As String In System.Enum.GetNames(GetType(Syncfusion.Windows.Forms.Chart.ChartSymbolShape))
				Me.comboBox7.Items.Add(symbol)
			Next symbol

			Me.comboBox7.SelectedIndex = 11
			Me.comboBox6.SelectedIndex = 0
			Me.comboBox5.SelectedIndex = 18
			Me.comboBox1.SelectedIndex = 0
			Me.comboBox3.SelectedIndex = 0
			Me.comboBox9.SelectedIndex = 12

			Me.colorPickerButton4.SelectedColor = Color.Black
			Me.numericUpDown2.Value = 10
			Me.timer1.Enabled = Me.checkBox2.Checked
		End Sub
		#End Region

		#End Region

		#Region "Appearance"

		#Region "Border Settings"

		#Region "Border Color"
		Private Sub colorPickerButton3_ColorSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorPickerButton3.ColorSelected
			Me.chartControl1.ChartArea.BorderColor = Me.colorPickerButton3.SelectedColor

            If Me.colorPickerButton3.SelectedColor = Color.Transparent Then
                Me.textBox1.BackColor = Color.Empty
            Else
                Me.textBox1.BackColor = Me.colorPickerButton3.SelectedColor
            End If

			Me.chartControl1.Redraw(True)
		End Sub

		#End Region

		#Region "Border Width"

		Private Sub numericUpDown4_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown4.ValueChanged
			Me.chartControl1.ChartArea.BorderWidth = Convert.ToInt32(Me.numericUpDown4.Value)
			Me.chartControl1.Redraw(True)
		End Sub

		Private Sub numericUpDown5_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown5.ValueChanged
            For i As Integer = 0 To 2
                If (i < Me.chartControl1.Series.Count) Then
                    Me.chartControl1.Series(i).Style.Border.Width = Convert.ToInt32(Me.numericUpDown5.Value)
                End If
            Next i
            Me.chartControl1.Redraw(True)
		End Sub

		#End Region

		#Region "Border Style"

		Private Sub ChartBorderStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox3.SelectedIndexChanged
			Me.chartControl1.ChartArea.BorderStyle = CType(System.Enum.Parse(GetType(BorderStyle), Me.comboBox3.SelectedItem.ToString(), True), BorderStyle)
			Me.chartControl1.Redraw(True)
		End Sub

		#End Region

		#Region "Series Border"

		Private Sub SeriesBorder_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
			For i As Integer = 0 To 2
				Me.chartControl1.Series(i).Style.Border.DashStyle = CType(System.Enum.Parse(GetType(DashStyle), Me.comboBox1.SelectedItem.ToString(), True), DashStyle)
			Next i
			Me.chartControl1.Redraw(True)
		End Sub

		Private Sub SeriesBorderColor_ColorSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorPickerButton2.ColorSelected
			For i As Integer = 0 To 2
				Me.chartControl1.Series(i).Style.Border.Color = Me.colorPickerButton2.SelectedColor
			Next i

            If Me.colorPickerButton2.SelectedColor = Color.Transparent Then
                Me.textBox2.BackColor = Color.Empty
            Else
                Me.textBox2.BackColor = Me.colorPickerButton2.SelectedColor
            End If

			Me.chartControl1.Redraw(True)
		End Sub

		#End Region

		#End Region

		#Region "Background Settings"

		#Region "BackImage"

		''' <summary>
		''' Setting Background image for the control.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub ChartControlBackGroundImage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			Dim sfd As SaveFileDialog = New SaveFileDialog()
			Dim ofd As OpenFileDialog = New OpenFileDialog()
            ofd.InitialDirectory = "...\..\..\..\..\..\..\..\..\Common\images\Chart"
			ofd.Filter = "BackGround files (*.jpg)|*.jpg|All files (*.*)|*.*"
			If System.Windows.Forms.DialogResult.OK = ofd.ShowDialog() Then
				filename = ofd.FileName
				Me.chartControl1.ChartAreaBackImage = New Bitmap(filename)
				Me.chartControl1.ChartInterior = New BrushInfo(Color.Transparent)
				Btn_Clear.Visible = True
			End If
		End Sub

		Private Sub Btn_Clear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Clear.Click
			Me.chartControl1.ChartAreaBackImage = Nothing
			Btn_Clear.Visible = False
			Me.ChartInterior_ColorChanged(Me.colorPickerButton8, EventArgs.Empty)
		End Sub

		#End Region

		#Region "Interior"

		Private Sub ChartControl_ColorChanged(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton6.ColorSelected, colorPickerButton5.ColorSelected
			Try
				Me.chartControl1.BackInterior = New BrushInfo(CType(System.Enum.Parse(GetType(GradientStyle), Me.comboBox8.SelectedItem.ToString(), True), GradientStyle), Me.colorPickerButton5.SelectedColor, Me.colorPickerButton6.SelectedColor)


                If Me.colorPickerButton5.SelectedColor = Color.Transparent Then
                    Me.textBox3.BackColor = Color.Empty
                Else
                    Me.textBox3.BackColor = Me.colorPickerButton5.SelectedColor
                End If
                If Me.colorPickerButton6.SelectedColor = Color.Transparent Then
                    Me.textBox4.BackColor = Color.Empty
                Else
                    Me.textBox4.BackColor = Me.colorPickerButton6.SelectedColor
                End If


			Catch ex As Exception
				MessageBox.Show(ex.ToString())
			End Try
		End Sub

		Private Sub ChartArea_ColorChanged(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton1.ColorSelected, colorPickerButton7.ColorSelected
			Try
				Me.chartControl1.ChartArea.BackInterior = New BrushInfo(CType(System.Enum.Parse(GetType(GradientStyle), Me.comboBox8.SelectedItem.ToString(), True), GradientStyle), Me.colorPickerButton7.SelectedColor, Me.colorPickerButton1.SelectedColor)


                If Me.colorPickerButton7.SelectedColor = Color.Transparent Then
                    Me.textBox6.BackColor = Color.Empty
                Else
                    Me.textBox6.BackColor = Me.colorPickerButton7.SelectedColor
                End If

                If Me.colorPickerButton1.SelectedColor = Color.Transparent Then
                    Me.textBox5.BackColor = Color.Empty
                Else
                    Me.textBox5.BackColor = Me.colorPickerButton1.SelectedColor
                End If

			Catch ex As Exception
				MessageBox.Show(ex.ToString())
			End Try
		End Sub

		Private Sub ChartInterior_ColorChanged(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton8.ColorSelected, colorPickerButton9.ColorSelected
			Try
				Me.chartControl1.ChartInterior = New BrushInfo(CType(System.Enum.Parse(GetType(GradientStyle), Me.comboBox8.SelectedItem.ToString(), True), GradientStyle), Me.colorPickerButton8.SelectedColor, Me.colorPickerButton9.SelectedColor)


                If Me.colorPickerButton8.SelectedColor = Color.Transparent Then
                    Me.textBox7.BackColor = Color.Empty
                Else
                    Me.textBox7.BackColor = Me.colorPickerButton8.SelectedColor
                End If

                If Me.colorPickerButton9.SelectedColor = Color.Transparent Then
                    Me.textBox8.BackColor = Color.Empty
                Else
                    Me.textBox8.BackColor = Me.colorPickerButton9.SelectedColor
                End If

			Catch ex As Exception
				Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.White, System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(219))))), (CInt(Fix((CByte(254)))))))
			End Try
		End Sub

		Private Sub comboBox8_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox8.SelectedIndexChanged
			Me.chartControl1.BackInterior = New BrushInfo(CType(System.Enum.Parse(GetType(GradientStyle), Me.comboBox8.SelectedItem.ToString(), True), GradientStyle), Me.colorPickerButton5.SelectedColor, Me.colorPickerButton6.SelectedColor)
			Me.chartControl1.ChartArea.BackInterior = New BrushInfo(CType(System.Enum.Parse(GetType(GradientStyle), Me.comboBox8.SelectedItem.ToString(), True), GradientStyle), Me.colorPickerButton7.SelectedColor, Me.colorPickerButton1.SelectedColor)
			Me.chartControl1.ChartInterior = New BrushInfo(CType(System.Enum.Parse(GetType(GradientStyle), Me.comboBox8.SelectedItem.ToString(), True), GradientStyle), Me.colorPickerButton8.SelectedColor, Me.colorPickerButton9.SelectedColor)
		End Sub

		#End Region

		#End Region

		#Region "Font Settings"

		''' <summary>
		''' Setting font style, font name.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>

		Private Sub Showtext_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
			SetFont()
			FontColor_ColorSelected(Me.colorPickerButton4, EventArgs.Empty)
			For i As Integer = 0 To 2
				Me.chartControl1.Series(i).Style.DisplayText = Me.checkBox1.Checked
				Me.chartControl1.Series(i).Style.TextOrientation = ChartTextOrientation.Up
			Next i
			Me.chartControl1.Redraw(True)
		End Sub

		Private Sub FontName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox5.SelectedIndexChanged
			Font_Name = Me.comboBox5.SelectedItem.ToString()
			SetFont()
			For i As Integer = 0 To 2
				Me.chartControl1.Series(i).Style.Font.Facename = Me.comboBox5.SelectedItem.ToString()
			Next i
		End Sub

		Private Sub FontStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox6.SelectedIndexChanged
			SetFont()
		End Sub

		Private Sub SetFont()
			' Changing Font for Chart Legend
			Dim item As ChartLegend = Me.chartControl1.Legend
			item.Font = New Font(Font_Name,10f, CType(System.Enum.Parse(GetType(FontStyle), Me.comboBox6.SelectedItem.ToString(), True), FontStyle))

			' Changing font for chart axis
			Dim axis As ChartAxis = Me.chartControl1.PrimaryXAxis
			axis.Font = New Font(Font_Name, 10f, CType(System.Enum.Parse(GetType(FontStyle), Me.comboBox6.SelectedItem.ToString(), True), FontStyle))
			axis = Me.chartControl1.PrimaryYAxis
			axis.Font = New Font(Font_Name, 10f, CType(System.Enum.Parse(GetType(FontStyle), Me.comboBox6.SelectedItem.ToString(), True), FontStyle))
			' Changing font for chart title
			Dim title As ChartTitle = Me.chartControl1.Title
			title.Font = New Font(Font_Name, 10f, CType(System.Enum.Parse(GetType(FontStyle), Me.comboBox6.SelectedItem.ToString(), True), FontStyle))

			If Me.chartControl1.Series.Count <> 0 Then
				For i As Integer = 0 To Me.chartControl1.Series.Count - 1
					Dim series As ChartSeries = Me.chartControl1.Series(i)
					If series IsNot Nothing Then
						series.Style.Font.Facename = Font_Name
						series.Style.Font.Size = 10f
						series.Style.Font.FontStyle = CType(System.Enum.Parse(GetType(FontStyle), Me.comboBox6.SelectedItem.ToString(), True), FontStyle)
					End If
				Next i
			End If
			Me.chartControl1.Redraw(True)
		End Sub

		Private Sub FontColor_ColorSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorPickerButton4.ColorSelected
			For i As Integer = 0 To 2
				Me.chartControl1.Series(i).Style.TextColor = Me.colorPickerButton4.SelectedColor
				' Changing Legend Color
				Me.chartControl1.Series(i).LegendItem.TextColor = Me.colorPickerButton4.SelectedColor
			Next i
			' Changing axis label color
			Me.chartControl1.PrimaryXAxis.ForeColor = Me.colorPickerButton4.SelectedColor
			Me.chartControl1.PrimaryYAxis.ForeColor = Me.colorPickerButton4.SelectedColor
			'  Changing Title Color
			Me.chartControl1.Title.ForeColor = Me.colorPickerButton4.SelectedColor

            If Me.colorPickerButton4.SelectedColor = Color.Transparent Then
                Me.textBox9.BackColor = Color.Empty
            Else
                Me.textBox9.BackColor = Me.colorPickerButton4.SelectedColor
            End If

			Me.chartControl1.Redraw(True)
		End Sub
		#End Region

		#Region "Shadow"
		''' <summary>
		''' Setting shadow for the chart area.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub ChartAreaShadow_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox5.CheckedChanged
			Me.chartControl1.ChartAreaShadow = Me.checkBox5.Checked
		End Sub
		#End Region

		#Region "ColorPalette"
		''' <summary>
		''' Change the color palette in the Chart Control.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub ColorPalette_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox9.SelectedIndexChanged
			
			If Me.comboBox9.SelectedItem.ToString() = "Custom" Then

                Me.chartControl1.Palette = ChartColorPalette.Custom
                Me.chartControl1.CustomPalette = New System.Drawing.Color() {Color.FromArgb(200, 247, 148, 29), Color.FromArgb(200, 140, 198, 62), Color.FromArgb(200, 163, 48, 45)}

			Else
				Me.chartControl1.Palette = CType(System.Enum.Parse(GetType(ChartColorPalette), Me.comboBox9.SelectedItem.ToString(), True), ChartColorPalette)
				Me.chartControl1.Series(0).Style.Interior = Nothing
				Me.chartControl1.Series(1).Style.Interior = Nothing
				Me.chartControl1.Series(2).Style.Interior = Nothing
			End If
		End Sub

		#End Region

		#Region "ChartFormatAxisLabel Event"
		''' <summary>
		''' Formatting Chart Axes Label
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>

		Private Sub chartControl1_ChartFormatAxisLabel(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventArgs) Handles chartControl1.ChartFormatAxisLabel
			If e.AxisOrientation = ChartOrientation.Horizontal Then
				If e.Value = 1 Then
					e.Label = "USA"
				ElseIf e.Value = 2 Then
					e.Label = "China"
				ElseIf e.Value = 3 Then
					e.Label = "Russia"
				ElseIf e.Value = 4 Then
					e.Label = "Australia"
				ElseIf e.Value = 5 Then
					e.Label = "Japan"
				Else
					e.Label = ""
				End If

				e.Handled = True
			End If
		End Sub

		#End Region

		#End Region

		#Region "Behavior"

		#Region "Rotation"
		''' <summary>
		''' Enable and Disable the rotation.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>

		Private Sub RotateAxis_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
			Me.chartControl1.Series3D = Me.checkBox3.Checked
			Me.chartControl1.ChartArea.Rotation = 30
			Me.chartControl1.ChartArea.Tilt = CSng(Me.numericUpDown3.Value)
			Me.timer1.Enabled = Me.checkBox2.Checked
		End Sub

		Private Sub numericUpDown3_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown3.ValueChanged
			Me.chartControl1.Tilt = CSng(Me.numericUpDown3.Value)
		End Sub

		Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckedChanged
			Me.chartControl1.Series3D = Me.checkBox3.Checked
			If Me.checkBox3.Checked Then
				Me.chartControl1.Series3D = True
				Me.checkBox2.Enabled = True
				Me.numericUpDown1.Enabled = True
				Me.numericUpDown2.Enabled = True
				Me.numericUpDown3.Enabled = True
			Else
				Me.chartControl1.Series3D = False
				Me.checkBox2.Enabled = False
				Me.numericUpDown1.Enabled = False
				Me.numericUpDown2.Enabled = False
				Me.numericUpDown3.Enabled = False
			End If
		End Sub

		#End Region

		#Region "Depth"
		''' <summary>
		''' Changing chart area depth in chart control.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>

		Private Sub Depth_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
			Me.chartControl1.ChartArea.Depth = CSng(Me.numericUpDown1.Value)
		End Sub

		#End Region

		#Region "Spacing"
		''' <summary>
		''' Changing spacing between the series in the chartcontrol.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub Spacing_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown2.ValueChanged
			Me.chartControl1.SpacingBetweenSeries = CSng(Me.numericUpDown2.Value)
		End Sub
		#End Region

		#Region "Timer"
		''' <summary>
		''' Enable and disable the timer to rotate the chartarea.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer1.Tick
			Try
				Me.chartControl1.ChartArea.Rotation += 5

				If Me.chartControl1.ChartArea.Rotation >= 90 Then
					Me.chartControl1.ChartArea.Rotation = 30
				End If
			Catch ex As Exception
				MessageBox.Show(ex.ToString())
			End Try
		End Sub
		#End Region

		#Region "Symbol"
		''' <summary>
		''' Set and change the symbol
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Protected Sub ChangeSymbol()
			If Me.radioButton4.Checked Then
				If Me.comboBox7.SelectedItem.ToString() = "Image" Then
					Me.chartControl1.Series(0).Style.Symbol.Shape = CType(System.Enum.Parse(GetType(ChartSymbolShape), Me.comboBox7.SelectedItem.ToString(), True), ChartSymbolShape)
					Me.chartControl1.Series(0).Style.Symbol.ImageIndex = 0
				Else
					Me.chartControl1.Series(0).Style.Symbol.Shape = CType(System.Enum.Parse(GetType(ChartSymbolShape), Me.comboBox7.SelectedItem.ToString(), True), ChartSymbolShape)
				End If
				Me.chartControl1.Series(0).Style.Symbol.Color = Color.Yellow
			ElseIf Me.radioButton3.Checked Then
				If Me.comboBox7.SelectedItem.ToString() = "Image" Then
					Me.chartControl1.Series(1).Style.Symbol.Shape = CType(System.Enum.Parse(GetType(ChartSymbolShape), Me.comboBox7.SelectedItem.ToString(), True), ChartSymbolShape)
					Me.chartControl1.Series(1).Style.Symbol.ImageIndex = 0
				Else
					Me.chartControl1.Series(1).Style.Symbol.Shape = CType(System.Enum.Parse(GetType(ChartSymbolShape), Me.comboBox7.SelectedItem.ToString(), True), ChartSymbolShape)
				End If
				Me.chartControl1.Series(1).Style.Symbol.Color = Color.Purple
			ElseIf Me.radioButton1.Checked Then
				If Me.comboBox7.SelectedItem.ToString() = "Image" Then
					Me.chartControl1.Series(2).Style.Symbol.Shape = CType(System.Enum.Parse(GetType(ChartSymbolShape), Me.comboBox7.SelectedItem.ToString(), True), ChartSymbolShape)
					Me.chartControl1.Series(2).Style.Symbol.ImageIndex = 0
				Else
					Me.chartControl1.Series(2).Style.Symbol.Shape = CType(System.Enum.Parse(GetType(ChartSymbolShape), Me.comboBox7.SelectedItem.ToString(), True), ChartSymbolShape)
				End If
				Me.chartControl1.Series(2).Style.Symbol.Color = Color.Purple
			End If
		End Sub

		Private Sub SymbolShape_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox7.SelectedIndexChanged
			ChangeSymbol()
			Me.chartControl1.Redraw(True)
		End Sub

		Private Sub radioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			ChangeSymbol()
			Me.chartControl1.Redraw(True)
		End Sub
		#End Region

		#End Region
	End Class
End Namespace