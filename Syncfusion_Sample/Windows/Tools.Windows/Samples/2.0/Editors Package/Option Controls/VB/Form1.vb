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
Namespace CheckBoxAdvDemo
	Public Class Form1
		Inherits Office2007Form
		#Region "Declarations"
		Private WithEvents checkBoxAdv1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private comboBox2 As System.Windows.Forms.ComboBox
		Private label5 As System.Windows.Forms.Label
		Private imageList1 As System.Windows.Forms.ImageList
		Private tabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
		Private tabPageAdv1 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabPageAdv2 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private label46 As Label
		Private label58 As Label
		Private label40 As Label
		Private WithEvents comboBox6 As ComboBox
		Private label44 As Label
		Private label8 As Label
		Private label12 As Label
		Private label2 As Label
		Private label3 As Label
		Private label4 As Label
		Private label6 As Label
		Private WithEvents radioButtonAdv5 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents radioButtonAdv8 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents radioButtonAdv7 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents comboBox1 As ComboBox
		Private label7 As Label
		Private WithEvents radioButtonAdv9 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents radioButtonAdv10 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private label9 As Label
		Private label10 As Label
		Private WithEvents radioButtonAdv11 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents comboBox4 As ComboBox
		Private label14 As Label
		Private label11 As Label
		Private label13 As Label
		Private label16 As Label
		Private label15 As Label
		Private WithEvents buttonEdit2 As Syncfusion.Windows.Forms.Tools.ButtonEdit
		Private buttonEditChildButton2 As Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
		Private textBoxExt2 As Syncfusion.Windows.Forms.Tools.TextBoxExt
		Private WithEvents buttonEdit1 As Syncfusion.Windows.Forms.Tools.ButtonEdit
		Private buttonEditChildButton1 As Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
		Private textBoxExt1 As Syncfusion.Windows.Forms.Tools.TextBoxExt
		Private radioButtonAdv12 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private label17 As Label
		Private label18 As Label
		Private WithEvents buttonEdit3 As Syncfusion.Windows.Forms.Tools.ButtonEdit
		Private buttonEditChildButton3 As Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
		Private WithEvents buttonEdit4 As Syncfusion.Windows.Forms.Tools.ButtonEdit
		Private buttonEditChildButton4 As Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
		Private WithEvents comboBox7 As ComboBox
		Private label19 As Label
		Private label20 As Label
		Private label21 As Label
		Private colorDialog1 As ColorDialog
		Private WithEvents comboBox8 As ComboBox
		Private WithEvents comboBox9 As ComboBox
		Private WithEvents comboBox10 As ComboBox
		Private label22 As Label
		Private label23 As Label
		Private label24 As Label
		Private label26 As Label
		Private label25 As Label
		Private WithEvents buttonEdit5 As Syncfusion.Windows.Forms.Tools.ButtonEdit
		Private buttonEditChildButton5 As Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
		Private comboBox5 As ComboBox
		Private label27 As Label
		Private label28 As Label
		Private label29 As Label
		Private label30 As Label
		Private comboBox11 As ComboBox
		Private radioButtonAdv13 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private label31 As Label
		Private label32 As Label
		Private buttonEdit6 As Syncfusion.Windows.Forms.Tools.ButtonEdit
		Private buttonEditChildButton6 As Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
		Private buttonEdit7 As Syncfusion.Windows.Forms.Tools.ButtonEdit
		Private buttonEditChildButton7 As Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
		Private comboBox12 As ComboBox
		Private label33 As Label
		Private label34 As Label
		Private label35 As Label
		Private radioButtonAdv14 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private radioButtonAdv15 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private comboBox13 As ComboBox
		Private label36 As Label
		Private label37 As Label
		Private radioButtonAdv16 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents comboBox14 As ComboBox
		Private label39 As Label
		Private WithEvents comboBox15 As ComboBox
		Private label38 As Label
		Private label41 As Label
		Private WithEvents buttonEdit8 As Syncfusion.Windows.Forms.Tools.ButtonEdit
		Private buttonEditChildButton8 As Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
		Private WithEvents buttonAdv1 As ButtonAdv
		Private WithEvents checkBox1 As CheckBox
		Private WithEvents checkBox3 As CheckBox
		Private WithEvents comboBox3 As ComboBox
		Private label42 As Label
		Private WithEvents checkBox5 As CheckBox
		Private WithEvents checkBox4 As CheckBox
		Private WithEvents checkBox6 As CheckBox
		Private WithEvents checkBox9 As CheckBox
		Private label43 As Label
		Private label45 As Label
		Private WithEvents comboBox17 As ComboBox
		Private label48 As Label
		Private label47 As Label
		Private WithEvents comboBox16 As ComboBox
		Private WithEvents comboBox18 As ComboBox
		Private label49 As Label
		Private label50 As Label
		Private WithEvents comboBox19 As ComboBox
		Private m_dt As DataTable
		Private WithEvents checkBox7 As CheckBox
		Private label1 As Label
		Private label51 As Label
		Private label54 As Label
		Private label55 As Label
		Private label52 As Label
		Private label53 As Label
		Private WithEvents checkBox8 As CheckBox
		Private label56 As Label
		Private toolTip1 As ToolTip
		Private panel1 As Panel
		Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private label57 As Label
		Private label77 As Label
		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private label59 As Label
		Private label60 As Label
        Private WithEvents checkBox2 As CheckBox
        Private WithEvents RadioButtonAdv1 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
        Private WithEvents RadioButtonAdv2 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private components As System.ComponentModel.IContainer
		#End Region

		#Region "Constructor And Dispose"
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
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
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
            Me.checkBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.label5 = New System.Windows.Forms.Label
            Me.tabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv
            Me.tabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label59 = New System.Windows.Forms.Label
            Me.label56 = New System.Windows.Forms.Label
            Me.checkBox7 = New System.Windows.Forms.CheckBox
            Me.label1 = New System.Windows.Forms.Label
            Me.label51 = New System.Windows.Forms.Label
            Me.comboBox18 = New System.Windows.Forms.ComboBox
            Me.label49 = New System.Windows.Forms.Label
            Me.label50 = New System.Windows.Forms.Label
            Me.comboBox19 = New System.Windows.Forms.ComboBox
            Me.checkBox6 = New System.Windows.Forms.CheckBox
            Me.checkBox5 = New System.Windows.Forms.CheckBox
            Me.checkBox4 = New System.Windows.Forms.CheckBox
            Me.checkBox3 = New System.Windows.Forms.CheckBox
            Me.comboBox14 = New System.Windows.Forms.ComboBox
            Me.label39 = New System.Windows.Forms.Label
            Me.label25 = New System.Windows.Forms.Label
            Me.buttonEdit5 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton5 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.comboBox8 = New System.Windows.Forms.ComboBox
            Me.label16 = New System.Windows.Forms.Label
            Me.label15 = New System.Windows.Forms.Label
            Me.buttonEdit2 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton2 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.buttonEdit1 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton1 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.comboBox4 = New System.Windows.Forms.ComboBox
            Me.label14 = New System.Windows.Forms.Label
            Me.label11 = New System.Windows.Forms.Label
            Me.label13 = New System.Windows.Forms.Label
            Me.radioButtonAdv8 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.radioButtonAdv7 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label7 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.radioButtonAdv5 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.label2 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label46 = New System.Windows.Forms.Label
            Me.label58 = New System.Windows.Forms.Label
            Me.label40 = New System.Windows.Forms.Label
            Me.comboBox6 = New System.Windows.Forms.ComboBox
            Me.label44 = New System.Windows.Forms.Label
            Me.label8 = New System.Windows.Forms.Label
            Me.label12 = New System.Windows.Forms.Label
            Me.tabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.label60 = New System.Windows.Forms.Label
            Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label57 = New System.Windows.Forms.Label
            Me.panel1 = New System.Windows.Forms.Panel
            Me.radioButtonAdv12 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.label77 = New System.Windows.Forms.Label
            Me.checkBox8 = New System.Windows.Forms.CheckBox
            Me.label54 = New System.Windows.Forms.Label
            Me.label55 = New System.Windows.Forms.Label
            Me.label52 = New System.Windows.Forms.Label
            Me.label53 = New System.Windows.Forms.Label
            Me.comboBox17 = New System.Windows.Forms.ComboBox
            Me.label48 = New System.Windows.Forms.Label
            Me.label47 = New System.Windows.Forms.Label
            Me.comboBox16 = New System.Windows.Forms.ComboBox
            Me.checkBox9 = New System.Windows.Forms.CheckBox
            Me.label43 = New System.Windows.Forms.Label
            Me.label45 = New System.Windows.Forms.Label
            Me.comboBox3 = New System.Windows.Forms.ComboBox
            Me.label42 = New System.Windows.Forms.Label
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.comboBox15 = New System.Windows.Forms.ComboBox
            Me.label38 = New System.Windows.Forms.Label
            Me.label41 = New System.Windows.Forms.Label
            Me.buttonEdit8 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton8 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.comboBox10 = New System.Windows.Forms.ComboBox
            Me.label22 = New System.Windows.Forms.Label
            Me.label23 = New System.Windows.Forms.Label
            Me.label24 = New System.Windows.Forms.Label
            Me.label26 = New System.Windows.Forms.Label
            Me.comboBox9 = New System.Windows.Forms.ComboBox
            Me.label17 = New System.Windows.Forms.Label
            Me.label18 = New System.Windows.Forms.Label
            Me.buttonEdit3 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton3 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.buttonEdit4 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton4 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.comboBox7 = New System.Windows.Forms.ComboBox
            Me.label19 = New System.Windows.Forms.Label
            Me.label20 = New System.Windows.Forms.Label
            Me.label21 = New System.Windows.Forms.Label
            Me.radioButtonAdv9 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.radioButtonAdv10 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.label9 = New System.Windows.Forms.Label
            Me.label10 = New System.Windows.Forms.Label
            Me.radioButtonAdv11 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.textBoxExt2 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.textBoxExt1 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.colorDialog1 = New System.Windows.Forms.ColorDialog
            Me.comboBox5 = New System.Windows.Forms.ComboBox
            Me.label27 = New System.Windows.Forms.Label
            Me.label28 = New System.Windows.Forms.Label
            Me.label29 = New System.Windows.Forms.Label
            Me.label30 = New System.Windows.Forms.Label
            Me.comboBox11 = New System.Windows.Forms.ComboBox
            Me.radioButtonAdv13 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.label31 = New System.Windows.Forms.Label
            Me.label32 = New System.Windows.Forms.Label
            Me.buttonEdit6 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton6 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.buttonEdit7 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton7 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.comboBox12 = New System.Windows.Forms.ComboBox
            Me.label33 = New System.Windows.Forms.Label
            Me.label34 = New System.Windows.Forms.Label
            Me.label35 = New System.Windows.Forms.Label
            Me.radioButtonAdv14 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.radioButtonAdv15 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.comboBox13 = New System.Windows.Forms.ComboBox
            Me.label36 = New System.Windows.Forms.Label
            Me.label37 = New System.Windows.Forms.Label
            Me.radioButtonAdv16 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.RadioButtonAdv1 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.RadioButtonAdv2 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControlAdv1.SuspendLayout()
            Me.tabPageAdv1.SuspendLayout()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            CType(Me.buttonEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit5.SuspendLayout()
            CType(Me.buttonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit2.SuspendLayout()
            CType(Me.buttonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit1.SuspendLayout()
            CType(Me.radioButtonAdv8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPageAdv2.SuspendLayout()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel2.SuspendLayout()
            Me.panel1.SuspendLayout()
            CType(Me.radioButtonAdv12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit8.SuspendLayout()
            CType(Me.buttonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit3.SuspendLayout()
            CType(Me.buttonEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit4.SuspendLayout()
            CType(Me.radioButtonAdv9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit6.SuspendLayout()
            CType(Me.buttonEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit7.SuspendLayout()
            CType(Me.radioButtonAdv14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv16, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadioButtonAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadioButtonAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'checkBoxAdv1
            '
            Me.checkBoxAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
            Me.checkBoxAdv1.BorderColor = System.Drawing.Color.Black
            Me.checkBoxAdv1.Checked = True
            Me.checkBoxAdv1.CheckedImage = CType(resources.GetObject("checkBoxAdv1.CheckedImage"), System.Drawing.Image)
            Me.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv1.GradientEnd = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.checkBoxAdv1.GradientStart = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.checkBoxAdv1.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv1.ImageCheckBoxSize = New System.Drawing.Size(30, 30)
            Me.checkBoxAdv1.IndeterminateImage = CType(resources.GetObject("checkBoxAdv1.IndeterminateImage"), System.Drawing.Image)
            Me.checkBoxAdv1.Location = New System.Drawing.Point(258, 60)
            Me.checkBoxAdv1.Name = "checkBoxAdv1"
            Me.checkBoxAdv1.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv1.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv1.Size = New System.Drawing.Size(129, 35)
            Me.checkBoxAdv1.StretchImage = False
            Me.checkBoxAdv1.TabIndex = 22
            Me.checkBoxAdv1.Text = "CheckBoxAdv"
            Me.checkBoxAdv1.ThemesEnabled = True
            Me.checkBoxAdv1.UncheckedImage = CType(resources.GetObject("checkBoxAdv1.UncheckedImage"), System.Drawing.Image)
            '
            'comboBox2
            '
            Me.comboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox2.Location = New System.Drawing.Point(495, 399)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(116, 21)
            Me.comboBox2.TabIndex = 23
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            '
            'label5
            '
            Me.label5.Location = New System.Drawing.Point(467, 322)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(169, 74)
            Me.label5.TabIndex = 0
            Me.label5.Text = "Select the bit value from the comboBox below to set state of the CheckBoxAdv whic" & _
                "h is bound  to a field (containing only 0,1 or -1) column in a data table."
            '
            'tabControlAdv1
            '
            Me.tabControlAdv1.ActiveTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv1)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv2)
            Me.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabControlAdv1.Location = New System.Drawing.Point(0, 0)
            Me.tabControlAdv1.Name = "tabControlAdv1"
            Me.tabControlAdv1.Size = New System.Drawing.Size(664, 488)
            Me.tabControlAdv1.TabGap = 10
            Me.tabControlAdv1.TabIndex = 34
            Me.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.tabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)
            '
            'tabPageAdv1
            '
            Me.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.tabPageAdv1.Controls.Add(Me.RadioButtonAdv1)
            Me.tabPageAdv1.Controls.Add(Me.gradientPanel1)
            Me.tabPageAdv1.Controls.Add(Me.label56)
            Me.tabPageAdv1.Controls.Add(Me.checkBox7)
            Me.tabPageAdv1.Controls.Add(Me.label1)
            Me.tabPageAdv1.Controls.Add(Me.label51)
            Me.tabPageAdv1.Controls.Add(Me.comboBox18)
            Me.tabPageAdv1.Controls.Add(Me.label49)
            Me.tabPageAdv1.Controls.Add(Me.label50)
            Me.tabPageAdv1.Controls.Add(Me.comboBox19)
            Me.tabPageAdv1.Controls.Add(Me.checkBox6)
            Me.tabPageAdv1.Controls.Add(Me.checkBox5)
            Me.tabPageAdv1.Controls.Add(Me.checkBox4)
            Me.tabPageAdv1.Controls.Add(Me.checkBox3)
            Me.tabPageAdv1.Controls.Add(Me.comboBox14)
            Me.tabPageAdv1.Controls.Add(Me.label39)
            Me.tabPageAdv1.Controls.Add(Me.label25)
            Me.tabPageAdv1.Controls.Add(Me.buttonEdit5)
            Me.tabPageAdv1.Controls.Add(Me.comboBox8)
            Me.tabPageAdv1.Controls.Add(Me.label16)
            Me.tabPageAdv1.Controls.Add(Me.label15)
            Me.tabPageAdv1.Controls.Add(Me.buttonEdit2)
            Me.tabPageAdv1.Controls.Add(Me.buttonEdit1)
            Me.tabPageAdv1.Controls.Add(Me.comboBox4)
            Me.tabPageAdv1.Controls.Add(Me.label14)
            Me.tabPageAdv1.Controls.Add(Me.label11)
            Me.tabPageAdv1.Controls.Add(Me.label13)
            Me.tabPageAdv1.Controls.Add(Me.radioButtonAdv8)
            Me.tabPageAdv1.Controls.Add(Me.radioButtonAdv7)
            Me.tabPageAdv1.Controls.Add(Me.comboBox1)
            Me.tabPageAdv1.Controls.Add(Me.label7)
            Me.tabPageAdv1.Controls.Add(Me.label4)
            Me.tabPageAdv1.Controls.Add(Me.label6)
            Me.tabPageAdv1.Controls.Add(Me.radioButtonAdv5)
            Me.tabPageAdv1.Controls.Add(Me.label2)
            Me.tabPageAdv1.Controls.Add(Me.label3)
            Me.tabPageAdv1.Controls.Add(Me.label46)
            Me.tabPageAdv1.Controls.Add(Me.label58)
            Me.tabPageAdv1.Controls.Add(Me.label40)
            Me.tabPageAdv1.Controls.Add(Me.comboBox6)
            Me.tabPageAdv1.Controls.Add(Me.label44)
            Me.tabPageAdv1.Controls.Add(Me.comboBox2)
            Me.tabPageAdv1.Controls.Add(Me.label8)
            Me.tabPageAdv1.Controls.Add(Me.label5)
            Me.tabPageAdv1.Controls.Add(Me.label12)
            Me.tabPageAdv1.Location = New System.Drawing.Point(1, 22)
            Me.tabPageAdv1.Name = "tabPageAdv1"
            Me.tabPageAdv1.Size = New System.Drawing.Size(661, 464)
            Me.tabPageAdv1.TabBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.tabPageAdv1.TabIndex = 1
            Me.tabPageAdv1.Text = "CheckBoxAdv"
            Me.tabPageAdv1.ThemesEnabled = False
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel1.Controls.Add(Me.label59)
            Me.gradientPanel1.Controls.Add(Me.checkBoxAdv1)
            Me.gradientPanel1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel1.Location = New System.Drawing.Point(25, 18)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(611, 113)
            Me.gradientPanel1.TabIndex = 151
            '
            'label59
            '
            Me.label59.BackColor = System.Drawing.Color.Transparent
            Me.label59.Dock = System.Windows.Forms.DockStyle.Top
            Me.label59.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label59.Image = CType(resources.GetObject("label59.Image"), System.Drawing.Image)
            Me.label59.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label59.Location = New System.Drawing.Point(0, 0)
            Me.label59.Name = "label59"
            Me.label59.Size = New System.Drawing.Size(609, 48)
            Me.label59.TabIndex = 1
            Me.label59.Text = resources.GetString("label59.Text")
            '
            'label56
            '
            Me.label56.Image = CType(resources.GetObject("label56.Image"), System.Drawing.Image)
            Me.label56.Location = New System.Drawing.Point(416, 256)
            Me.label56.Name = "label56"
            Me.label56.Size = New System.Drawing.Size(20, 20)
            Me.label56.TabIndex = 145
            Me.toolTip1.SetToolTip(Me.label56, "Enabled when BorderStyle is FixedSingle")
            '
            'checkBox7
            '
            Me.checkBox7.Location = New System.Drawing.Point(37, 404)
            Me.checkBox7.Name = "checkBox7"
            Me.checkBox7.Size = New System.Drawing.Size(112, 24)
            Me.checkBox7.TabIndex = 144
            Me.checkBox7.Text = "Themes Enabled"
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Image = CType(resources.GetObject("label1.Image"), System.Drawing.Image)
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label1.Location = New System.Drawing.Point(236, 288)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(89, 24)
            Me.label1.TabIndex = 143
            Me.label1.Text = "Alignment"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label51
            '
            Me.label51.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label51.Location = New System.Drawing.Point(258, 312)
            Me.label51.Name = "label51"
            Me.label51.Size = New System.Drawing.Size(160, 1)
            Me.label51.TabIndex = 142
            '
            'comboBox18
            '
            Me.comboBox18.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox18.ForeColor = System.Drawing.Color.Black
            Me.comboBox18.Location = New System.Drawing.Point(316, 375)
            Me.comboBox18.Name = "comboBox18"
            Me.comboBox18.Size = New System.Drawing.Size(99, 21)
            Me.comboBox18.TabIndex = 141
            '
            'label49
            '
            Me.label49.AutoSize = True
            Me.label49.Location = New System.Drawing.Point(254, 378)
            Me.label49.Name = "label49"
            Me.label49.Size = New System.Drawing.Size(54, 13)
            Me.label49.TabIndex = 140
            Me.label49.Text = "Text Align"
            '
            'label50
            '
            Me.label50.AutoSize = True
            Me.label50.Location = New System.Drawing.Point(254, 331)
            Me.label50.Name = "label50"
            Me.label50.Size = New System.Drawing.Size(60, 13)
            Me.label50.TabIndex = 139
            Me.label50.Text = "Glyph Align"
            '
            'comboBox19
            '
            Me.comboBox19.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox19.ForeColor = System.Drawing.Color.Black
            Me.comboBox19.Location = New System.Drawing.Point(316, 331)
            Me.comboBox19.Name = "comboBox19"
            Me.comboBox19.Size = New System.Drawing.Size(99, 21)
            Me.comboBox19.TabIndex = 138
            '
            'checkBox6
            '
            Me.checkBox6.Location = New System.Drawing.Point(37, 320)
            Me.checkBox6.Name = "checkBox6"
            Me.checkBox6.Size = New System.Drawing.Size(75, 24)
            Me.checkBox6.TabIndex = 128
            Me.checkBox6.Text = "ReadOnly"
            '
            'checkBox5
            '
            Me.checkBox5.Location = New System.Drawing.Point(37, 348)
            Me.checkBox5.Name = "checkBox5"
            Me.checkBox5.Size = New System.Drawing.Size(67, 24)
            Me.checkBox5.TabIndex = 127
            Me.checkBox5.Text = "TriState"
            '
            'checkBox4
            '
            Me.checkBox4.Location = New System.Drawing.Point(37, 376)
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(92, 24)
            Me.checkBox4.TabIndex = 126
            Me.checkBox4.Text = "ShowShadow"
            Me.checkBox4.UseVisualStyleBackColor = False
            '
            'checkBox3
            '
            Me.checkBox3.Location = New System.Drawing.Point(37, 432)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(112, 24)
            Me.checkBox3.TabIndex = 125
            Me.checkBox3.Text = "ImageCheckBox"
            '
            'comboBox14
            '
            Me.comboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox14.ForeColor = System.Drawing.Color.Black
            Me.comboBox14.Location = New System.Drawing.Point(314, 221)
            Me.comboBox14.Name = "comboBox14"
            Me.comboBox14.Size = New System.Drawing.Size(101, 21)
            Me.comboBox14.TabIndex = 106
            '
            'label39
            '
            Me.label39.AutoSize = True
            Me.label39.Location = New System.Drawing.Point(236, 231)
            Me.label39.Name = "label39"
            Me.label39.Size = New System.Drawing.Size(70, 13)
            Me.label39.TabIndex = 105
            Me.label39.Text = "Border Single"
            '
            'label25
            '
            Me.label25.AutoSize = True
            Me.label25.Location = New System.Drawing.Point(236, 262)
            Me.label25.Name = "label25"
            Me.label25.Size = New System.Drawing.Size(65, 13)
            Me.label25.TabIndex = 104
            Me.label25.Text = "Border Color"
            '
            'buttonEdit5
            '
            Me.buttonEdit5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit5.Buttons.Add(Me.buttonEditChildButton5)
            Me.buttonEdit5.Controls.Add(Me.buttonEditChildButton5)
            Me.buttonEdit5.Location = New System.Drawing.Point(316, 247)
            Me.buttonEdit5.Name = "buttonEdit5"
            Me.buttonEdit5.ShowTextBox = False
            Me.buttonEdit5.Size = New System.Drawing.Size(99, 26)
            Me.buttonEdit5.TabIndex = 103
            Me.buttonEdit5.UseVisualStyle = True
            '
            'buttonEditChildButton5
            '
            Me.buttonEditChildButton5.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton5.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton5.Image = Nothing
            Me.buttonEditChildButton5.Name = "buttonEditChildButton5"
            Me.buttonEditChildButton5.PreferredWidth = 18
            Me.buttonEditChildButton5.TabIndex = 1
            Me.buttonEditChildButton5.Text = "..."
            '
            'comboBox8
            '
            Me.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox8.ForeColor = System.Drawing.Color.Black
            Me.comboBox8.Items.AddRange(New Object() {"None", "FixedSingle", "Fixed3D"})
            Me.comboBox8.Location = New System.Drawing.Point(314, 169)
            Me.comboBox8.Name = "comboBox8"
            Me.comboBox8.Size = New System.Drawing.Size(101, 21)
            Me.comboBox8.TabIndex = 102
            '
            'label16
            '
            Me.label16.AutoSize = True
            Me.label16.Location = New System.Drawing.Point(448, 247)
            Me.label16.Margin = New System.Windows.Forms.Padding(0)
            Me.label16.Name = "label16"
            Me.label16.Size = New System.Drawing.Size(53, 26)
            Me.label16.TabIndex = 101
            Me.label16.Text = "Gradient " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "End Color"
            '
            'label15
            '
            Me.label15.AutoSize = True
            Me.label15.Location = New System.Drawing.Point(447, 208)
            Me.label15.Margin = New System.Windows.Forms.Padding(0)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(56, 26)
            Me.label15.TabIndex = 100
            Me.label15.Text = "Gradient " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Start Color"
            '
            'buttonEdit2
            '
            Me.buttonEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit2.Buttons.Add(Me.buttonEditChildButton2)
            Me.buttonEdit2.Controls.Add(Me.buttonEditChildButton2)
            Me.buttonEdit2.Location = New System.Drawing.Point(524, 246)
            Me.buttonEdit2.Name = "buttonEdit2"
            Me.buttonEdit2.ShowTextBox = False
            Me.buttonEdit2.Size = New System.Drawing.Size(103, 26)
            Me.buttonEdit2.TabIndex = 99
            Me.buttonEdit2.UseVisualStyle = True
            '
            'buttonEditChildButton2
            '
            Me.buttonEditChildButton2.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton2.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton2.Image = Nothing
            Me.buttonEditChildButton2.Name = "buttonEditChildButton2"
            Me.buttonEditChildButton2.PreferredWidth = 18
            Me.buttonEditChildButton2.TabIndex = 1
            Me.buttonEditChildButton2.Text = "..."
            '
            'buttonEdit1
            '
            Me.buttonEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit1.Buttons.Add(Me.buttonEditChildButton1)
            Me.buttonEdit1.Controls.Add(Me.buttonEditChildButton1)
            Me.buttonEdit1.Location = New System.Drawing.Point(524, 208)
            Me.buttonEdit1.Name = "buttonEdit1"
            Me.buttonEdit1.ShowTextBox = False
            Me.buttonEdit1.Size = New System.Drawing.Size(103, 26)
            Me.buttonEdit1.TabIndex = 98
            Me.buttonEdit1.UseVisualStyle = True
            '
            'buttonEditChildButton1
            '
            Me.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton1.Image = Nothing
            Me.buttonEditChildButton1.Name = "buttonEditChildButton1"
            Me.buttonEditChildButton1.PreferredWidth = 18
            Me.buttonEditChildButton1.TabIndex = 1
            Me.buttonEditChildButton1.Text = "..."
            '
            'comboBox4
            '
            Me.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox4.ForeColor = System.Drawing.Color.Black
            Me.comboBox4.Items.AddRange(New Object() {"Default", "HorizontalGradient", "VerticalGradient"})
            Me.comboBox4.Location = New System.Drawing.Point(521, 171)
            Me.comboBox4.Name = "comboBox4"
            Me.comboBox4.Size = New System.Drawing.Size(106, 21)
            Me.comboBox4.TabIndex = 97
            '
            'label14
            '
            Me.label14.AutoSize = True
            Me.label14.Location = New System.Drawing.Point(448, 169)
            Me.label14.Margin = New System.Windows.Forms.Padding(0)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(70, 26)
            Me.label14.TabIndex = 96
            Me.label14.Text = "BackGround " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Style"
            '
            'label11
            '
            Me.label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label11.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label11.Image = CType(resources.GetObject("label11.Image"), System.Drawing.Image)
            Me.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label11.Location = New System.Drawing.Point(448, 134)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(147, 24)
            Me.label11.TabIndex = 95
            Me.label11.Text = "Background Settings"
            Me.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label13
            '
            Me.label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label13.Location = New System.Drawing.Point(451, 158)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(160, 1)
            Me.label13.TabIndex = 94
            '
            'radioButtonAdv8
            '
            Me.radioButtonAdv8.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv8.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv8.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv8.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv8.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv8.Location = New System.Drawing.Point(34, 235)
            Me.radioButtonAdv8.Name = "radioButtonAdv8"
            Me.radioButtonAdv8.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv8.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv8.Size = New System.Drawing.Size(150, 21)
            Me.radioButtonAdv8.StretchImage = False
            Me.radioButtonAdv8.TabIndex = 93
            Me.radioButtonAdv8.Text = "Office2007 - Black"
            Me.radioButtonAdv8.ThemesEnabled = True
            '
            'radioButtonAdv7
            '
            Me.radioButtonAdv7.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv7.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv7.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv7.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv7.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv7.Location = New System.Drawing.Point(34, 213)
            Me.radioButtonAdv7.Name = "radioButtonAdv7"
            Me.radioButtonAdv7.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv7.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv7.Size = New System.Drawing.Size(150, 21)
            Me.radioButtonAdv7.StretchImage = False
            Me.radioButtonAdv7.TabIndex = 92
            Me.radioButtonAdv7.Text = "Office2007 - Silver"
            Me.radioButtonAdv7.ThemesEnabled = True
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox1.ForeColor = System.Drawing.Color.Black
            Me.comboBox1.Items.AddRange(New Object() {"Default", "Office2007"})
            Me.comboBox1.Location = New System.Drawing.Point(93, 162)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(91, 21)
            Me.comboBox1.TabIndex = 91
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(34, 165)
            Me.label7.Margin = New System.Windows.Forms.Padding(0)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(30, 13)
            Me.label7.TabIndex = 90
            Me.label7.Text = "Style"
            '
            'label4
            '
            Me.label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label4.Image = CType(resources.GetObject("label4.Image"), System.Drawing.Image)
            Me.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label4.Location = New System.Drawing.Point(34, 134)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(95, 24)
            Me.label4.TabIndex = 89
            Me.label4.Text = "Visual Styles"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label6
            '
            Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label6.Location = New System.Drawing.Point(34, 158)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(160, 1)
            Me.label6.TabIndex = 88
            '
            'radioButtonAdv5
            '
            Me.radioButtonAdv5.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv5.Checked = True
            Me.radioButtonAdv5.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv5.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv5.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv5.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv5.Location = New System.Drawing.Point(34, 192)
            Me.radioButtonAdv5.Name = "radioButtonAdv5"
            Me.radioButtonAdv5.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv5.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv5.Size = New System.Drawing.Size(150, 21)
            Me.radioButtonAdv5.StretchImage = False
            Me.radioButtonAdv5.TabIndex = 87
            Me.radioButtonAdv5.Text = "Office2007 - Blue"
            Me.radioButtonAdv5.ThemesEnabled = True
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Image = CType(resources.GetObject("label2.Image"), System.Drawing.Image)
            Me.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label2.Location = New System.Drawing.Point(34, 283)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(89, 24)
            Me.label2.TabIndex = 86
            Me.label2.Text = "Properties"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label3
            '
            Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label3.Location = New System.Drawing.Point(40, 312)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(160, 1)
            Me.label3.TabIndex = 85
            '
            'label46
            '
            Me.label46.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label46.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label46.Image = CType(resources.GetObject("label46.Image"), System.Drawing.Image)
            Me.label46.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label46.Location = New System.Drawing.Point(236, 134)
            Me.label46.Name = "label46"
            Me.label46.Size = New System.Drawing.Size(114, 24)
            Me.label46.TabIndex = 84
            Me.label46.Text = "Border Settings"
            Me.label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label58
            '
            Me.label58.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label58.Location = New System.Drawing.Point(247, 158)
            Me.label58.Name = "label58"
            Me.label58.Size = New System.Drawing.Size(160, 1)
            Me.label58.TabIndex = 83
            '
            'label40
            '
            Me.label40.AutoSize = True
            Me.label40.Location = New System.Drawing.Point(236, 169)
            Me.label40.Name = "label40"
            Me.label40.Size = New System.Drawing.Size(64, 13)
            Me.label40.TabIndex = 80
            Me.label40.Text = "Border Style"
            '
            'comboBox6
            '
            Me.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox6.ForeColor = System.Drawing.Color.Black
            Me.comboBox6.Location = New System.Drawing.Point(314, 195)
            Me.comboBox6.Name = "comboBox6"
            Me.comboBox6.Size = New System.Drawing.Size(101, 21)
            Me.comboBox6.TabIndex = 78
            '
            'label44
            '
            Me.label44.AutoSize = True
            Me.label44.Location = New System.Drawing.Point(236, 200)
            Me.label44.Margin = New System.Windows.Forms.Padding(0)
            Me.label44.Name = "label44"
            Me.label44.Size = New System.Drawing.Size(78, 13)
            Me.label44.TabIndex = 76
            Me.label44.Text = "Border3D Style"
            '
            'label8
            '
            Me.label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label8.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label8.Image = CType(resources.GetObject("label8.Image"), System.Drawing.Image)
            Me.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label8.Location = New System.Drawing.Point(467, 288)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(99, 24)
            Me.label8.TabIndex = 34
            Me.label8.Text = "Data Binding"
            Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label12
            '
            Me.label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label12.Location = New System.Drawing.Point(467, 312)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(160, 1)
            Me.label12.TabIndex = 33
            '
            'tabPageAdv2
            '
            Me.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.tabPageAdv2.Controls.Add(Me.RadioButtonAdv2)
            Me.tabPageAdv2.Controls.Add(Me.checkBox2)
            Me.tabPageAdv2.Controls.Add(Me.label60)
            Me.tabPageAdv2.Controls.Add(Me.gradientPanel2)
            Me.tabPageAdv2.Controls.Add(Me.label77)
            Me.tabPageAdv2.Controls.Add(Me.checkBox8)
            Me.tabPageAdv2.Controls.Add(Me.label54)
            Me.tabPageAdv2.Controls.Add(Me.label55)
            Me.tabPageAdv2.Controls.Add(Me.label52)
            Me.tabPageAdv2.Controls.Add(Me.label53)
            Me.tabPageAdv2.Controls.Add(Me.comboBox17)
            Me.tabPageAdv2.Controls.Add(Me.label48)
            Me.tabPageAdv2.Controls.Add(Me.label47)
            Me.tabPageAdv2.Controls.Add(Me.comboBox16)
            Me.tabPageAdv2.Controls.Add(Me.checkBox9)
            Me.tabPageAdv2.Controls.Add(Me.label43)
            Me.tabPageAdv2.Controls.Add(Me.label45)
            Me.tabPageAdv2.Controls.Add(Me.comboBox3)
            Me.tabPageAdv2.Controls.Add(Me.label42)
            Me.tabPageAdv2.Controls.Add(Me.checkBox1)
            Me.tabPageAdv2.Controls.Add(Me.buttonAdv1)
            Me.tabPageAdv2.Controls.Add(Me.comboBox15)
            Me.tabPageAdv2.Controls.Add(Me.label38)
            Me.tabPageAdv2.Controls.Add(Me.label41)
            Me.tabPageAdv2.Controls.Add(Me.buttonEdit8)
            Me.tabPageAdv2.Controls.Add(Me.comboBox10)
            Me.tabPageAdv2.Controls.Add(Me.label22)
            Me.tabPageAdv2.Controls.Add(Me.label23)
            Me.tabPageAdv2.Controls.Add(Me.label24)
            Me.tabPageAdv2.Controls.Add(Me.label26)
            Me.tabPageAdv2.Controls.Add(Me.comboBox9)
            Me.tabPageAdv2.Controls.Add(Me.label17)
            Me.tabPageAdv2.Controls.Add(Me.label18)
            Me.tabPageAdv2.Controls.Add(Me.buttonEdit3)
            Me.tabPageAdv2.Controls.Add(Me.buttonEdit4)
            Me.tabPageAdv2.Controls.Add(Me.comboBox7)
            Me.tabPageAdv2.Controls.Add(Me.label19)
            Me.tabPageAdv2.Controls.Add(Me.label20)
            Me.tabPageAdv2.Controls.Add(Me.label21)
            Me.tabPageAdv2.Controls.Add(Me.radioButtonAdv9)
            Me.tabPageAdv2.Controls.Add(Me.radioButtonAdv10)
            Me.tabPageAdv2.Controls.Add(Me.label9)
            Me.tabPageAdv2.Controls.Add(Me.label10)
            Me.tabPageAdv2.Controls.Add(Me.radioButtonAdv11)
            Me.tabPageAdv2.Location = New System.Drawing.Point(1, 22)
            Me.tabPageAdv2.Name = "tabPageAdv2"
            Me.tabPageAdv2.Size = New System.Drawing.Size(661, 464)
            Me.tabPageAdv2.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.tabPageAdv2.TabIndex = 1
            Me.tabPageAdv2.Text = "RadioButtonAdv"
            Me.tabPageAdv2.ThemesEnabled = False
            '
            'checkBox2
            '
            Me.checkBox2.Location = New System.Drawing.Point(42, 379)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(102, 24)
            Me.checkBox2.TabIndex = 153
            Me.checkBox2.Text = "Checked State"
            '
            'label60
            '
            Me.label60.Location = New System.Drawing.Point(452, 321)
            Me.label60.Name = "label60"
            Me.label60.Size = New System.Drawing.Size(169, 27)
            Me.label60.TabIndex = 152
            Me.label60.Text = "Set the RadioButton as checked through DataBase"
            '
            'gradientPanel2
            '
            Me.gradientPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel2.Controls.Add(Me.label57)
            Me.gradientPanel2.Controls.Add(Me.panel1)
            Me.gradientPanel2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel2.Location = New System.Drawing.Point(42, 16)
            Me.gradientPanel2.Name = "gradientPanel2"
            Me.gradientPanel2.Size = New System.Drawing.Size(592, 90)
            Me.gradientPanel2.TabIndex = 150
            '
            'label57
            '
            Me.label57.BackColor = System.Drawing.Color.Transparent
            Me.label57.Dock = System.Windows.Forms.DockStyle.Top
            Me.label57.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label57.Image = CType(resources.GetObject("label57.Image"), System.Drawing.Image)
            Me.label57.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label57.Location = New System.Drawing.Point(0, 0)
            Me.label57.Name = "label57"
            Me.label57.Size = New System.Drawing.Size(590, 51)
            Me.label57.TabIndex = 1
            Me.label57.Text = "RadioButtonAdv is an advanced RadioButton control that supports themes, gradient " & _
                "colors and shadow text. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It has provisions to set images when checked and unche" & _
                "cked. "
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.radioButtonAdv12)
            Me.panel1.Location = New System.Drawing.Point(198, 39)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(177, 46)
            Me.panel1.TabIndex = 151
            '
            'radioButtonAdv12
            '
            Me.radioButtonAdv12.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
            Me.radioButtonAdv12.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv12.CheckedImage = CType(resources.GetObject("radioButtonAdv12.CheckedImage"), System.Drawing.Image)
            Me.radioButtonAdv12.GradientEnd = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.radioButtonAdv12.GradientStart = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.radioButtonAdv12.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv12.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv12.Location = New System.Drawing.Point(30, 15)
            Me.radioButtonAdv12.Name = "radioButtonAdv12"
            Me.radioButtonAdv12.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv12.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv12.Size = New System.Drawing.Size(117, 17)
            Me.radioButtonAdv12.TabIndex = 110
            Me.radioButtonAdv12.Text = "RadioButtonAdv"
            Me.radioButtonAdv12.ThemesEnabled = True
            Me.radioButtonAdv12.UncheckedImage = CType(resources.GetObject("radioButtonAdv12.UncheckedImage"), System.Drawing.Image)
            '
            'label77
            '
            Me.label77.Image = CType(resources.GetObject("label77.Image"), System.Drawing.Image)
            Me.label77.Location = New System.Drawing.Point(404, 244)
            Me.label77.Name = "label77"
            Me.label77.Size = New System.Drawing.Size(20, 20)
            Me.label77.TabIndex = 149
            Me.toolTip1.SetToolTip(Me.label77, "Enabled when BorderStyle is FixedSingle")
            '
            'checkBox8
            '
            Me.checkBox8.Checked = True
            Me.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox8.Location = New System.Drawing.Point(42, 413)
            Me.checkBox8.Name = "checkBox8"
            Me.checkBox8.Size = New System.Drawing.Size(112, 24)
            Me.checkBox8.TabIndex = 148
            Me.checkBox8.Text = "Themes Enabled"
            '
            'label54
            '
            Me.label54.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label54.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label54.Image = CType(resources.GetObject("label54.Image"), System.Drawing.Image)
            Me.label54.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label54.Location = New System.Drawing.Point(452, 283)
            Me.label54.Name = "label54"
            Me.label54.Size = New System.Drawing.Size(99, 24)
            Me.label54.TabIndex = 147
            Me.label54.Text = "Data Binding"
            Me.label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label55
            '
            Me.label55.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label55.Location = New System.Drawing.Point(452, 307)
            Me.label55.Name = "label55"
            Me.label55.Size = New System.Drawing.Size(160, 1)
            Me.label55.TabIndex = 146
            '
            'label52
            '
            Me.label52.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label52.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label52.Image = CType(resources.GetObject("label52.Image"), System.Drawing.Image)
            Me.label52.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label52.Location = New System.Drawing.Point(234, 283)
            Me.label52.Name = "label52"
            Me.label52.Size = New System.Drawing.Size(89, 24)
            Me.label52.TabIndex = 145
            Me.label52.Text = "Alignment"
            Me.label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label53
            '
            Me.label53.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label53.Location = New System.Drawing.Point(240, 307)
            Me.label53.Name = "label53"
            Me.label53.Size = New System.Drawing.Size(160, 1)
            Me.label53.TabIndex = 144
            '
            'comboBox17
            '
            Me.comboBox17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox17.ForeColor = System.Drawing.Color.Black
            Me.comboBox17.Location = New System.Drawing.Point(315, 369)
            Me.comboBox17.Name = "comboBox17"
            Me.comboBox17.Size = New System.Drawing.Size(90, 21)
            Me.comboBox17.TabIndex = 137
            '
            'label48
            '
            Me.label48.AutoSize = True
            Me.label48.Location = New System.Drawing.Point(234, 372)
            Me.label48.Name = "label48"
            Me.label48.Size = New System.Drawing.Size(54, 13)
            Me.label48.TabIndex = 136
            Me.label48.Text = "Text Align"
            '
            'label47
            '
            Me.label47.AutoSize = True
            Me.label47.Location = New System.Drawing.Point(234, 327)
            Me.label47.Name = "label47"
            Me.label47.Size = New System.Drawing.Size(60, 13)
            Me.label47.TabIndex = 135
            Me.label47.Text = "Glyph Align"
            '
            'comboBox16
            '
            Me.comboBox16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox16.ForeColor = System.Drawing.Color.Black
            Me.comboBox16.Location = New System.Drawing.Point(315, 327)
            Me.comboBox16.Name = "comboBox16"
            Me.comboBox16.Size = New System.Drawing.Size(90, 21)
            Me.comboBox16.TabIndex = 134
            '
            'checkBox9
            '
            Me.checkBox9.Location = New System.Drawing.Point(42, 311)
            Me.checkBox9.Name = "checkBox9"
            Me.checkBox9.Size = New System.Drawing.Size(95, 24)
            Me.checkBox9.TabIndex = 133
            Me.checkBox9.Text = "ShowShadow"
            '
            'label43
            '
            Me.label43.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label43.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label43.Image = CType(resources.GetObject("label43.Image"), System.Drawing.Image)
            Me.label43.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label43.Location = New System.Drawing.Point(36, 283)
            Me.label43.Name = "label43"
            Me.label43.Size = New System.Drawing.Size(89, 24)
            Me.label43.TabIndex = 131
            Me.label43.Text = "Properties"
            Me.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label45
            '
            Me.label45.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label45.Location = New System.Drawing.Point(36, 307)
            Me.label45.Name = "label45"
            Me.label45.Size = New System.Drawing.Size(160, 1)
            Me.label45.TabIndex = 130
            '
            'comboBox3
            '
            Me.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox3.ForeColor = System.Drawing.Color.Black
            Me.comboBox3.Items.AddRange(New Object() {"Default", "Office2007"})
            Me.comboBox3.Location = New System.Drawing.Point(77, 155)
            Me.comboBox3.Name = "comboBox3"
            Me.comboBox3.Size = New System.Drawing.Size(87, 21)
            Me.comboBox3.TabIndex = 126
            '
            'label42
            '
            Me.label42.AutoSize = True
            Me.label42.Location = New System.Drawing.Point(39, 158)
            Me.label42.Margin = New System.Windows.Forms.Padding(0)
            Me.label42.Name = "label42"
            Me.label42.Size = New System.Drawing.Size(30, 13)
            Me.label42.TabIndex = 125
            Me.label42.Text = "Style"
            '
            'checkBox1
            '
            Me.checkBox1.Location = New System.Drawing.Point(42, 345)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(112, 24)
            Me.checkBox1.TabIndex = 124
            Me.checkBox1.Text = "ImageCheckBox"
            '
            'buttonAdv1
            '
            Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.WindowsXP
            Me.buttonAdv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.buttonAdv1.Location = New System.Drawing.Point(492, 369)
            Me.buttonAdv1.Name = "buttonAdv1"
            Me.buttonAdv1.Size = New System.Drawing.Size(88, 23)
            Me.buttonAdv1.TabIndex = 123
            Me.buttonAdv1.Text = "Checked"
            Me.buttonAdv1.UseVisualStyle = True
            '
            'comboBox15
            '
            Me.comboBox15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox15.ForeColor = System.Drawing.Color.Black
            Me.comboBox15.Location = New System.Drawing.Point(315, 213)
            Me.comboBox15.Name = "comboBox15"
            Me.comboBox15.Size = New System.Drawing.Size(87, 21)
            Me.comboBox15.TabIndex = 121
            '
            'label38
            '
            Me.label38.AutoSize = True
            Me.label38.Location = New System.Drawing.Point(234, 214)
            Me.label38.Name = "label38"
            Me.label38.Size = New System.Drawing.Size(70, 13)
            Me.label38.TabIndex = 120
            Me.label38.Text = "Border Single"
            '
            'label41
            '
            Me.label41.AutoSize = True
            Me.label41.Location = New System.Drawing.Point(234, 242)
            Me.label41.Name = "label41"
            Me.label41.Size = New System.Drawing.Size(65, 13)
            Me.label41.TabIndex = 119
            Me.label41.Text = "Border Color"
            '
            'buttonEdit8
            '
            Me.buttonEdit8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit8.Buttons.Add(Me.buttonEditChildButton8)
            Me.buttonEdit8.Controls.Add(Me.buttonEditChildButton8)
            Me.buttonEdit8.Location = New System.Drawing.Point(315, 242)
            Me.buttonEdit8.Name = "buttonEdit8"
            Me.buttonEdit8.ShowTextBox = False
            Me.buttonEdit8.Size = New System.Drawing.Size(87, 26)
            Me.buttonEdit8.TabIndex = 118
            Me.buttonEdit8.UseVisualStyle = True
            '
            'buttonEditChildButton8
            '
            Me.buttonEditChildButton8.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton8.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton8.Image = Nothing
            Me.buttonEditChildButton8.Name = "buttonEditChildButton8"
            Me.buttonEditChildButton8.PreferredWidth = 18
            Me.buttonEditChildButton8.TabIndex = 1
            Me.buttonEditChildButton8.Text = "..."
            '
            'comboBox10
            '
            Me.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox10.ForeColor = System.Drawing.Color.Black
            Me.comboBox10.Location = New System.Drawing.Point(315, 184)
            Me.comboBox10.Name = "comboBox10"
            Me.comboBox10.Size = New System.Drawing.Size(87, 21)
            Me.comboBox10.TabIndex = 117
            '
            'label22
            '
            Me.label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label22.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label22.Image = CType(resources.GetObject("label22.Image"), System.Drawing.Image)
            Me.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label22.Location = New System.Drawing.Point(234, 120)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(114, 24)
            Me.label22.TabIndex = 116
            Me.label22.Text = "Border Settings"
            Me.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label23
            '
            Me.label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label23.Location = New System.Drawing.Point(234, 144)
            Me.label23.Name = "label23"
            Me.label23.Size = New System.Drawing.Size(160, 1)
            Me.label23.TabIndex = 115
            '
            'label24
            '
            Me.label24.AutoSize = True
            Me.label24.Location = New System.Drawing.Point(234, 158)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(64, 13)
            Me.label24.TabIndex = 114
            Me.label24.Text = "Border Style"
            '
            'label26
            '
            Me.label26.AutoSize = True
            Me.label26.Location = New System.Drawing.Point(234, 186)
            Me.label26.Margin = New System.Windows.Forms.Padding(0)
            Me.label26.Name = "label26"
            Me.label26.Size = New System.Drawing.Size(78, 13)
            Me.label26.TabIndex = 112
            Me.label26.Text = "Border3D Style"
            '
            'comboBox9
            '
            Me.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox9.ForeColor = System.Drawing.Color.Black
            Me.comboBox9.Items.AddRange(New Object() {"None", "FixedSingle", "Fixed3D"})
            Me.comboBox9.Location = New System.Drawing.Point(315, 155)
            Me.comboBox9.Name = "comboBox9"
            Me.comboBox9.Size = New System.Drawing.Size(87, 21)
            Me.comboBox9.TabIndex = 111
            '
            'label17
            '
            Me.label17.AutoSize = True
            Me.label17.Location = New System.Drawing.Point(449, 249)
            Me.label17.Margin = New System.Windows.Forms.Padding(0)
            Me.label17.Name = "label17"
            Me.label17.Size = New System.Drawing.Size(53, 26)
            Me.label17.TabIndex = 109
            Me.label17.Text = "Gradient " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "End Color"
            '
            'label18
            '
            Me.label18.AutoSize = True
            Me.label18.Location = New System.Drawing.Point(449, 206)
            Me.label18.Margin = New System.Windows.Forms.Padding(0)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(56, 26)
            Me.label18.TabIndex = 108
            Me.label18.Text = "Gradient " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Start Color"
            '
            'buttonEdit3
            '
            Me.buttonEdit3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit3.Buttons.Add(Me.buttonEditChildButton3)
            Me.buttonEdit3.Controls.Add(Me.buttonEditChildButton3)
            Me.buttonEdit3.Location = New System.Drawing.Point(522, 242)
            Me.buttonEdit3.Name = "buttonEdit3"
            Me.buttonEdit3.ShowTextBox = False
            Me.buttonEdit3.Size = New System.Drawing.Size(99, 26)
            Me.buttonEdit3.TabIndex = 107
            Me.buttonEdit3.UseVisualStyle = True
            '
            'buttonEditChildButton3
            '
            Me.buttonEditChildButton3.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton3.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton3.Image = Nothing
            Me.buttonEditChildButton3.Name = "buttonEditChildButton3"
            Me.buttonEditChildButton3.PreferredWidth = 18
            Me.buttonEditChildButton3.TabIndex = 1
            Me.buttonEditChildButton3.Text = "..."
            '
            'buttonEdit4
            '
            Me.buttonEdit4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit4.Buttons.Add(Me.buttonEditChildButton4)
            Me.buttonEdit4.Controls.Add(Me.buttonEditChildButton4)
            Me.buttonEdit4.Location = New System.Drawing.Point(522, 201)
            Me.buttonEdit4.Name = "buttonEdit4"
            Me.buttonEdit4.ShowTextBox = False
            Me.buttonEdit4.Size = New System.Drawing.Size(99, 26)
            Me.buttonEdit4.TabIndex = 106
            Me.buttonEdit4.UseVisualStyle = True
            '
            'buttonEditChildButton4
            '
            Me.buttonEditChildButton4.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton4.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton4.Image = Nothing
            Me.buttonEditChildButton4.Name = "buttonEditChildButton4"
            Me.buttonEditChildButton4.PreferredWidth = 18
            Me.buttonEditChildButton4.TabIndex = 1
            Me.buttonEditChildButton4.Text = "..."
            '
            'comboBox7
            '
            Me.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox7.ForeColor = System.Drawing.Color.Black
            Me.comboBox7.Items.AddRange(New Object() {"Default", "HorizontalGradient", "VerticalGradient"})
            Me.comboBox7.Location = New System.Drawing.Point(522, 160)
            Me.comboBox7.Name = "comboBox7"
            Me.comboBox7.Size = New System.Drawing.Size(99, 21)
            Me.comboBox7.TabIndex = 105
            '
            'label19
            '
            Me.label19.AutoSize = True
            Me.label19.Location = New System.Drawing.Point(450, 163)
            Me.label19.Margin = New System.Windows.Forms.Padding(0)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(70, 26)
            Me.label19.TabIndex = 104
            Me.label19.Text = "BackGround " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Style"
            '
            'label20
            '
            Me.label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label20.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label20.Image = CType(resources.GetObject("label20.Image"), System.Drawing.Image)
            Me.label20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label20.Location = New System.Drawing.Point(450, 120)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(147, 24)
            Me.label20.TabIndex = 103
            Me.label20.Text = "Background Settings"
            Me.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label21
            '
            Me.label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label21.Location = New System.Drawing.Point(452, 144)
            Me.label21.Name = "label21"
            Me.label21.Size = New System.Drawing.Size(160, 1)
            Me.label21.TabIndex = 102
            '
            'radioButtonAdv9
            '
            Me.radioButtonAdv9.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv9.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv9.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv9.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv9.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv9.Location = New System.Drawing.Point(39, 234)
            Me.radioButtonAdv9.Name = "radioButtonAdv9"
            Me.radioButtonAdv9.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv9.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv9.Size = New System.Drawing.Size(125, 21)
            Me.radioButtonAdv9.StretchImage = False
            Me.radioButtonAdv9.TabIndex = 99
            Me.radioButtonAdv9.Text = "Office2007 - Black"
            Me.radioButtonAdv9.ThemesEnabled = True
            '
            'radioButtonAdv10
            '
            Me.radioButtonAdv10.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv10.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv10.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv10.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv10.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv10.Location = New System.Drawing.Point(39, 206)
            Me.radioButtonAdv10.Name = "radioButtonAdv10"
            Me.radioButtonAdv10.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv10.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv10.Size = New System.Drawing.Size(125, 21)
            Me.radioButtonAdv10.StretchImage = False
            Me.radioButtonAdv10.TabIndex = 98
            Me.radioButtonAdv10.Text = "Office2007 - Silver"
            Me.radioButtonAdv10.ThemesEnabled = True
            '
            'label9
            '
            Me.label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label9.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label9.Image = CType(resources.GetObject("label9.Image"), System.Drawing.Image)
            Me.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label9.Location = New System.Drawing.Point(36, 120)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(95, 24)
            Me.label9.TabIndex = 96
            Me.label9.Text = "Visual Styles"
            Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label10
            '
            Me.label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label10.Location = New System.Drawing.Point(36, 144)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(160, 1)
            Me.label10.TabIndex = 95
            '
            'radioButtonAdv11
            '
            Me.radioButtonAdv11.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv11.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv11.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv11.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv11.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv11.Location = New System.Drawing.Point(39, 178)
            Me.radioButtonAdv11.Name = "radioButtonAdv11"
            Me.radioButtonAdv11.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv11.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv11.Size = New System.Drawing.Size(113, 21)
            Me.radioButtonAdv11.StretchImage = False
            Me.radioButtonAdv11.TabIndex = 94
            Me.radioButtonAdv11.Text = "Office2007 - Blue"
            Me.radioButtonAdv11.ThemesEnabled = True
            '
            'textBoxExt2
            '
            Me.textBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBoxExt2.Location = New System.Drawing.Point(2, 4)
            Me.textBoxExt2.Name = "textBoxExt2"
            Me.textBoxExt2.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt2.Size = New System.Drawing.Size(49, 13)
            Me.textBoxExt2.TabIndex = 0
            '
            'textBoxExt1
            '
            Me.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBoxExt1.Location = New System.Drawing.Point(2, 4)
            Me.textBoxExt1.Name = "textBoxExt1"
            Me.textBoxExt1.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt1.Size = New System.Drawing.Size(42, 13)
            Me.textBoxExt1.TabIndex = 0
            '
            'comboBox5
            '
            Me.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox5.ForeColor = System.Drawing.Color.Black
            Me.comboBox5.Location = New System.Drawing.Point(132, 331)
            Me.comboBox5.Name = "comboBox5"
            Me.comboBox5.Size = New System.Drawing.Size(75, 21)
            Me.comboBox5.TabIndex = 117
            '
            'label27
            '
            Me.label27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label27.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label27.Image = CType(resources.GetObject("label27.Image"), System.Drawing.Image)
            Me.label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label27.Location = New System.Drawing.Point(30, 255)
            Me.label27.Name = "label27"
            Me.label27.Size = New System.Drawing.Size(114, 24)
            Me.label27.TabIndex = 116
            Me.label27.Text = "Border Settings"
            Me.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label28
            '
            Me.label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label28.Location = New System.Drawing.Point(30, 279)
            Me.label28.Name = "label28"
            Me.label28.Size = New System.Drawing.Size(150, 1)
            Me.label28.TabIndex = 115
            '
            'label29
            '
            Me.label29.AutoSize = True
            Me.label29.Location = New System.Drawing.Point(25, 293)
            Me.label29.Name = "label29"
            Me.label29.Size = New System.Drawing.Size(64, 13)
            Me.label29.TabIndex = 114
            Me.label29.Text = "Border Style"
            '
            'label30
            '
            Me.label30.AutoSize = True
            Me.label30.Location = New System.Drawing.Point(25, 331)
            Me.label30.Margin = New System.Windows.Forms.Padding(0)
            Me.label30.Name = "label30"
            Me.label30.Size = New System.Drawing.Size(78, 13)
            Me.label30.TabIndex = 112
            Me.label30.Text = "Border3D Style"
            '
            'comboBox11
            '
            Me.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox11.ForeColor = System.Drawing.Color.Black
            Me.comboBox11.Items.AddRange(New Object() {"None", "FixedSingle", "Fixed3D"})
            Me.comboBox11.Location = New System.Drawing.Point(139, 291)
            Me.comboBox11.Name = "comboBox11"
            Me.comboBox11.Size = New System.Drawing.Size(75, 21)
            Me.comboBox11.TabIndex = 111
            '
            'radioButtonAdv13
            '
            Me.radioButtonAdv13.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv13.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv13.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv13.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv13.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv13.Location = New System.Drawing.Point(215, 28)
            Me.radioButtonAdv13.Name = "radioButtonAdv13"
            Me.radioButtonAdv13.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv13.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv13.Size = New System.Drawing.Size(190, 34)
            Me.radioButtonAdv13.TabIndex = 110
            Me.radioButtonAdv13.Text = "radioButtonAdv12"
            Me.radioButtonAdv13.ThemesEnabled = False
            '
            'label31
            '
            Me.label31.AutoSize = True
            Me.label31.Location = New System.Drawing.Point(25, 217)
            Me.label31.Margin = New System.Windows.Forms.Padding(0)
            Me.label31.Name = "label31"
            Me.label31.Size = New System.Drawing.Size(96, 13)
            Me.label31.TabIndex = 109
            Me.label31.Text = "Gradient End Color"
            '
            'label32
            '
            Me.label32.AutoSize = True
            Me.label32.Location = New System.Drawing.Point(29, 190)
            Me.label32.Margin = New System.Windows.Forms.Padding(0)
            Me.label32.Name = "label32"
            Me.label32.Size = New System.Drawing.Size(99, 13)
            Me.label32.TabIndex = 108
            Me.label32.Text = "Gradient Start Color"
            '
            'buttonEdit6
            '
            Me.buttonEdit6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit6.Buttons.Add(Me.buttonEditChildButton6)
            Me.buttonEdit6.Controls.Add(Me.buttonEditChildButton6)
            Me.buttonEdit6.Controls.Add(Me.textBoxExt2)
            Me.buttonEdit6.Location = New System.Drawing.Point(156, 209)
            Me.buttonEdit6.Name = "buttonEdit6"
            Me.buttonEdit6.ShowTextBox = False
            Me.buttonEdit6.Size = New System.Drawing.Size(71, 21)
            Me.buttonEdit6.TabIndex = 107
            Me.buttonEdit6.TextBox = Me.textBoxExt2
            Me.buttonEdit6.UseVisualStyle = True
            '
            'buttonEditChildButton6
            '
            Me.buttonEditChildButton6.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton6.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton6.Image = Nothing
            Me.buttonEditChildButton6.Name = "buttonEditChildButton6"
            Me.buttonEditChildButton6.PreferredWidth = 18
            Me.buttonEditChildButton6.TabIndex = 1
            Me.buttonEditChildButton6.Text = "..."
            '
            'buttonEdit7
            '
            Me.buttonEdit7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit7.Buttons.Add(Me.buttonEditChildButton7)
            Me.buttonEdit7.Controls.Add(Me.buttonEditChildButton7)
            Me.buttonEdit7.Controls.Add(Me.textBoxExt1)
            Me.buttonEdit7.Location = New System.Drawing.Point(149, 182)
            Me.buttonEdit7.Name = "buttonEdit7"
            Me.buttonEdit7.ShowTextBox = False
            Me.buttonEdit7.Size = New System.Drawing.Size(64, 21)
            Me.buttonEdit7.TabIndex = 106
            Me.buttonEdit7.TextBox = Me.textBoxExt1
            Me.buttonEdit7.UseVisualStyle = True
            '
            'buttonEditChildButton7
            '
            Me.buttonEditChildButton7.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton7.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton7.Image = Nothing
            Me.buttonEditChildButton7.Name = "buttonEditChildButton7"
            Me.buttonEditChildButton7.PreferredWidth = 18
            Me.buttonEditChildButton7.TabIndex = 1
            Me.buttonEditChildButton7.Text = "..."
            '
            'comboBox12
            '
            Me.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox12.ForeColor = System.Drawing.Color.Black
            Me.comboBox12.Items.AddRange(New Object() {"Default", "HorizontalGradient", "VerticalGradient"})
            Me.comboBox12.Location = New System.Drawing.Point(125, 155)
            Me.comboBox12.Name = "comboBox12"
            Me.comboBox12.Size = New System.Drawing.Size(75, 21)
            Me.comboBox12.TabIndex = 105
            '
            'label33
            '
            Me.label33.AutoSize = True
            Me.label33.Location = New System.Drawing.Point(29, 163)
            Me.label33.Margin = New System.Windows.Forms.Padding(0)
            Me.label33.Name = "label33"
            Me.label33.Size = New System.Drawing.Size(93, 13)
            Me.label33.TabIndex = 104
            Me.label33.Text = "BackGround Style"
            '
            'label34
            '
            Me.label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label34.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label34.Image = CType(resources.GetObject("label34.Image"), System.Drawing.Image)
            Me.label34.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label34.Location = New System.Drawing.Point(25, 123)
            Me.label34.Name = "label34"
            Me.label34.Size = New System.Drawing.Size(147, 24)
            Me.label34.TabIndex = 103
            Me.label34.Text = "Background Settings"
            Me.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label35
            '
            Me.label35.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label35.Location = New System.Drawing.Point(29, 147)
            Me.label35.Name = "label35"
            Me.label35.Size = New System.Drawing.Size(150, 1)
            Me.label35.TabIndex = 102
            '
            'radioButtonAdv14
            '
            Me.radioButtonAdv14.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv14.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv14.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv14.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv14.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv14.Location = New System.Drawing.Point(274, 291)
            Me.radioButtonAdv14.Name = "radioButtonAdv14"
            Me.radioButtonAdv14.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv14.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv14.Size = New System.Drawing.Size(150, 21)
            Me.radioButtonAdv14.StretchImage = False
            Me.radioButtonAdv14.TabIndex = 99
            Me.radioButtonAdv14.Text = "Office2007 - Black"
            Me.radioButtonAdv14.ThemesEnabled = True
            '
            'radioButtonAdv15
            '
            Me.radioButtonAdv15.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv15.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv15.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv15.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv15.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv15.Location = New System.Drawing.Point(274, 253)
            Me.radioButtonAdv15.Name = "radioButtonAdv15"
            Me.radioButtonAdv15.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv15.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv15.Size = New System.Drawing.Size(150, 21)
            Me.radioButtonAdv15.StretchImage = False
            Me.radioButtonAdv15.TabIndex = 98
            Me.radioButtonAdv15.Text = "Office2007 - Silver"
            Me.radioButtonAdv15.ThemesEnabled = True
            '
            'comboBox13
            '
            Me.comboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox13.ForeColor = System.Drawing.Color.Black
            Me.comboBox13.Location = New System.Drawing.Point(315, 176)
            Me.comboBox13.Name = "comboBox13"
            Me.comboBox13.Size = New System.Drawing.Size(75, 21)
            Me.comboBox13.TabIndex = 97
            '
            'label36
            '
            Me.label36.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label36.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label36.Image = CType(resources.GetObject("label36.Image"), System.Drawing.Image)
            Me.label36.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label36.Location = New System.Drawing.Point(256, 99)
            Me.label36.Name = "label36"
            Me.label36.Size = New System.Drawing.Size(95, 24)
            Me.label36.TabIndex = 96
            Me.label36.Text = "Visual Styles"
            Me.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label37
            '
            Me.label37.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label37.Location = New System.Drawing.Point(256, 123)
            Me.label37.Name = "label37"
            Me.label37.Size = New System.Drawing.Size(150, 1)
            Me.label37.TabIndex = 95
            '
            'radioButtonAdv16
            '
            Me.radioButtonAdv16.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv16.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv16.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv16.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv16.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv16.Location = New System.Drawing.Point(274, 219)
            Me.radioButtonAdv16.Name = "radioButtonAdv16"
            Me.radioButtonAdv16.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv16.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv16.Size = New System.Drawing.Size(150, 21)
            Me.radioButtonAdv16.StretchImage = False
            Me.radioButtonAdv16.TabIndex = 94
            Me.radioButtonAdv16.Text = "Office2007 - Blue"
            Me.radioButtonAdv16.ThemesEnabled = True
            '
            'RadioButtonAdv1
            '
            Me.RadioButtonAdv1.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.RadioButtonAdv1.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.RadioButtonAdv1.GradientStart = System.Drawing.SystemColors.Control
            Me.RadioButtonAdv1.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.RadioButtonAdv1.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.RadioButtonAdv1.Location = New System.Drawing.Point(34, 255)
            Me.RadioButtonAdv1.Name = "RadioButtonAdv1"
            Me.RadioButtonAdv1.ShadowColor = System.Drawing.Color.Black
            Me.RadioButtonAdv1.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.RadioButtonAdv1.Size = New System.Drawing.Size(150, 21)
            Me.RadioButtonAdv1.StretchImage = False
            Me.RadioButtonAdv1.TabIndex = 152
            Me.RadioButtonAdv1.Text = "Office2007 - Managed"
            Me.RadioButtonAdv1.ThemesEnabled = True
            '
            'RadioButtonAdv2
            '
            Me.RadioButtonAdv2.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.RadioButtonAdv2.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.RadioButtonAdv2.GradientStart = System.Drawing.SystemColors.Control
            Me.RadioButtonAdv2.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.RadioButtonAdv2.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.RadioButtonAdv2.Location = New System.Drawing.Point(39, 261)
            Me.RadioButtonAdv2.Name = "RadioButtonAdv2"
            Me.RadioButtonAdv2.ShadowColor = System.Drawing.Color.Black
            Me.RadioButtonAdv2.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.RadioButtonAdv2.Size = New System.Drawing.Size(157, 21)
            Me.RadioButtonAdv2.StretchImage = False
            Me.RadioButtonAdv2.TabIndex = 154
            Me.RadioButtonAdv2.Text = "Office2007 - Managed"
            Me.RadioButtonAdv2.ThemesEnabled = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(219, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(664, 488)
            Me.Controls.Add(Me.tabControlAdv1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Option Controls"
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControlAdv1.ResumeLayout(False)
            Me.tabPageAdv1.ResumeLayout(False)
            Me.tabPageAdv1.PerformLayout()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            CType(Me.buttonEdit5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit5.ResumeLayout(False)
            Me.buttonEdit5.PerformLayout()
            CType(Me.buttonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit2.ResumeLayout(False)
            Me.buttonEdit2.PerformLayout()
            CType(Me.buttonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit1.ResumeLayout(False)
            Me.buttonEdit1.PerformLayout()
            CType(Me.radioButtonAdv8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPageAdv2.ResumeLayout(False)
            Me.tabPageAdv2.PerformLayout()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel2.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            CType(Me.radioButtonAdv12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonEdit8, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit8.ResumeLayout(False)
            Me.buttonEdit8.PerformLayout()
            CType(Me.buttonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit3.ResumeLayout(False)
            Me.buttonEdit3.PerformLayout()
            CType(Me.buttonEdit4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit4.ResumeLayout(False)
            Me.buttonEdit4.PerformLayout()
            CType(Me.radioButtonAdv9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonEdit6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit6.ResumeLayout(False)
            Me.buttonEdit6.PerformLayout()
            CType(Me.buttonEdit7, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit7.ResumeLayout(False)
            Me.buttonEdit7.PerformLayout()
            CType(Me.radioButtonAdv14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv15, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv16, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadioButtonAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadioButtonAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		#Region "Main"
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub
		#End Region

		#Region "Form Load"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
'			#Region "CheckBoxAdv DataBinding"
			Dim m_tbl As DataTable = New DataTable()
			m_tbl.Columns.Add("ID", GetType(Integer))
			m_tbl.Columns.Add("ValueStr", GetType(String))

			m_tbl.LoadDataRow(New Object() { 1, "Checked" }, True)
			m_tbl.LoadDataRow(New Object() { -1, "Indeterminate" }, True)
			m_tbl.LoadDataRow(New Object() { 0, "UnChecked" }, True)
			Me.checkBoxAdv1.DataBindings.Add("IntValue", m_tbl, "ID")
			Me.comboBox2.DataSource = m_tbl
			Me.comboBox2.DisplayMember = "ID"
'			#End Region

'			#Region "RadioButtonAdv DataBinding"
			m_dt = New DataTable()
			m_dt.Columns.Add("ID", GetType(Integer))
			m_dt.Columns.Add("ValueStr", GetType(String))
			m_dt.LoadDataRow(New Object() { 0, "N" }, False)
			m_dt.LoadDataRow(New Object() { 1, "Y" }, True)
			Me.radioButtonAdv12.DataBindings.Add("IntValue", m_dt, "ID")
'			#End Region



			'Populate Border3DStyles
			Dim str1 As String() = System.Enum.GetNames(GetType(Border3DStyle))
			comboBox6.Items.AddRange(str1)
			comboBox10.Items.AddRange(str1)

			'Populate BorderSingle
			Dim str2 As String() = System.Enum.GetNames(GetType(ButtonBorderStyle))
			comboBox14.Items.AddRange(str2)
			comboBox15.Items.AddRange(str2)

			'Populate Content Alignment
			Dim str3 As String() = System.Enum.GetNames(GetType(System.Drawing.ContentAlignment))
			comboBox16.Items.AddRange(str3)
			comboBox17.Items.AddRange(str3)
			comboBox19.Items.AddRange(str3)
			comboBox18.Items.AddRange(str3)


			Me.comboBox1.SelectedIndex= 0
			Me.comboBox3.SelectedIndex = 0
			Me.comboBox4.SelectedIndex = 0
			Me.comboBox6.SelectedIndex= 1
			 Me.comboBox7.SelectedIndex = 0
			 Me.comboBox8.SelectedIndex = 0
			 Me.comboBox9.SelectedIndex = 0
			 Me.comboBox10.SelectedIndex = 1
			 Me.comboBox14.SelectedIndex= 3
			 Me.comboBox15.SelectedIndex = 3
			Me.comboBox16.SelectedIndex = 3
			 Me.comboBox17.SelectedIndex = 3
			 Me.comboBox19.SelectedIndex= 3
			 Me.comboBox18.SelectedIndex=3
			 Me.buttonEdit1.TextBox.BackColor = Color.FromArgb(192, 192, 255)
			 Me.buttonEdit4.TextBox.BackColor = Color.FromArgb(192, 192, 255)

			 Me.buttonEdit2.TextBox.BackColor = Color.FromArgb(255, 224, 192)
			 Me.buttonEdit3.TextBox.BackColor = Color.FromArgb(255, 224, 192)

            Me.checkBoxAdv1.Size = New Size(129, 35)

            Me.ColorScheme = Office2007Theme.Blue
		End Sub
		#End Region

		#Region "CheckBoxAdv PRoperties"
		 #Region "TextShadow"

		 Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox4.CheckedChanged
			Me.checkBoxAdv1.TextShadow = Me.checkBox4.Checked
		 End Sub


		#End Region

		 #Region "ReadOnlyMode"
		Private Sub checkBox6_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox6.CheckedChanged
			Me.checkBoxAdv1.ReadOnlyMode = Me.checkBox6.Checked
		End Sub

		#End Region

		 #Region " ImageCheckBox"
		Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckedChanged
			Me.checkBoxAdv1.ImageCheckBox = Me.checkBox3.Checked
		End Sub

		#End Region

		 #Region "Tristate"
		Private Sub checkBox5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox5.CheckedChanged
			If Me.checkBox5.Checked Then
				Me.checkBoxAdv1.Tristate = True
				'Me.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Indeterminate
			Else
				Me.checkBoxAdv1.Tristate = False
				Me.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked
			End If

		End Sub
		#End Region

		 #Region "CheckState"
		Private Sub checkBoxAdv1_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBoxAdv1.CheckStateChanged
			If Me.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked Then
				Me.checkBoxAdv1.Text = "Checked"
			ElseIf Me.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Unchecked Then
				Me.checkBoxAdv1.Text = "Unchecked"

			ElseIf Me.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Indeterminate Then
				Me.checkBoxAdv1.Text = "Indeterminate"
			End If


		End Sub
		#End Region

		 #Region " BackGroundStyle"
		Private Sub comboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox4.SelectedIndexChanged
			Select Case comboBox4.Items(comboBox4.SelectedIndex).ToString()
				Case "Default"
					Me.checkBoxAdv1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.CheckBoxAdvBackStyle.Default
				Case "HorizontalGradient"
					Me.checkBoxAdv1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.CheckBoxAdvBackStyle.HorizontalGradient
				Case "VerticalGradient"
					Me.checkBoxAdv1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.CheckBoxAdvBackStyle.VerticalGradient
			End Select
		End Sub

		#End Region

		 #Region "Gradient Colors"
		Private Sub buttonEdit1_ButtonClicked(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs) Handles buttonEdit1.ButtonClicked
			If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				buttonEdit1.TextBox.BackColor = colorDialog1.Color
				Me.checkBoxAdv1.GradientStart = colorDialog1.Color
			End If
		End Sub

		Private Sub buttonEdit2_ButtonClicked(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs) Handles buttonEdit2.ButtonClicked
			If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				buttonEdit2.TextBox.BackColor = colorDialog1.Color
				Me.checkBoxAdv1.GradientEnd = colorDialog1.Color
			End If

		End Sub
		#End Region

		 #Region " BorderStyle"
		Private Sub comboBox8_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox8.SelectedIndexChanged
			Select Case comboBox8.Items(comboBox8.SelectedIndex).ToString()
				Case "None"
					Me.checkBoxAdv1.BorderStyle = BorderStyle.None
					Me.comboBox6.Enabled = False
					Me.buttonEdit5.Enabled = False
					Me.comboBox14.Enabled = False
				Case "FixedSingle"
					Me.checkBoxAdv1.BorderStyle = BorderStyle.FixedSingle
					Me.comboBox6.Enabled = False
					Me.buttonEdit5.Enabled = True
					Me.comboBox14.Enabled = True
				Case "Fixed3D"
					Me.checkBoxAdv1.BorderStyle = BorderStyle.Fixed3D
					Me.comboBox6.Enabled = True
					Me.buttonEdit5.Enabled = False
					Me.comboBox14.Enabled = False

			End Select
		End Sub
		#End Region

		 #Region "Border3DStyle"
		Private Sub comboBox6_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox6.SelectedIndexChanged
			Select Case comboBox6.Items(comboBox6.SelectedIndex).ToString()
				Case "RaisedOuter"
					Me.checkBoxAdv1.Border3DStyle = Border3DStyle.RaisedOuter
				Case "Adjust"
					Me.checkBoxAdv1.Border3DStyle = Border3DStyle.Adjust
				Case "Bump"
					Me.checkBoxAdv1.Border3DStyle = Border3DStyle.Bump
				Case "Etched"
					Me.checkBoxAdv1.Border3DStyle = Border3DStyle.Etched
				Case "Flat"
					Me.checkBoxAdv1.Border3DStyle = Border3DStyle.Flat
				Case "Raised"
					Me.checkBoxAdv1.Border3DStyle = Border3DStyle.Raised
				Case "RaisedInner"
					Me.checkBoxAdv1.Border3DStyle = Border3DStyle.RaisedInner
				Case "Sunken"
					Me.checkBoxAdv1.Border3DStyle = Border3DStyle.Sunken
				Case "SunkenInner"
					Me.checkBoxAdv1.Border3DStyle = Border3DStyle.SunkenInner
				Case "SunkenOuter"
					Me.checkBoxAdv1.Border3DStyle = Border3DStyle.SunkenOuter
			End Select
		End Sub
		#End Region

		 #Region "BorderColor"
		Private Sub buttonEdit5_ButtonClicked(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs) Handles buttonEdit5.ButtonClicked
			If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				buttonEdit5.TextBox.BackColor = colorDialog1.Color
				Me.checkBoxAdv1.BorderColor = colorDialog1.Color
			End If
		End Sub
		#End Region

		 #Region "BorderSingleStyle"

		Private Sub comboBox14_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox14.SelectedIndexChanged
			Select Case comboBox14.Items(comboBox14.SelectedIndex).ToString()
				Case "Dashed"
					Me.checkBoxAdv1.BorderSingle = ButtonBorderStyle.Dashed
				Case "Dotted"
					Me.checkBoxAdv1.BorderSingle = ButtonBorderStyle.Dotted
				Case "Inset"
					Me.checkBoxAdv1.BorderSingle = ButtonBorderStyle.Inset
				Case "None"
					Me.checkBoxAdv1.BorderSingle = ButtonBorderStyle.None
				Case "Outset"
					Me.checkBoxAdv1.BorderSingle = ButtonBorderStyle.Outset
				Case "Solid"
					Me.checkBoxAdv1.BorderSingle = ButtonBorderStyle.Solid
			End Select

		End Sub
		#End Region

		 #Region "VisualStyle"
		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
			If Me.comboBox1.SelectedIndex = 0 Then
				Me.checkBox7.Checked = True
				Me.radioButtonAdv5.Enabled = False
				Me.radioButtonAdv7.Enabled = False
                Me.radioButtonAdv8.Enabled = False
                Me.RadioButtonAdv1.Enabled = False
				Me.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Default
			Else
				Me.checkBox7.Checked = False
				Me.radioButtonAdv5.Enabled = True
				Me.radioButtonAdv7.Enabled = True
                Me.radioButtonAdv8.Enabled = True
                Me.RadioButtonAdv1.Enabled = True
				Me.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007
			End If
		End Sub

		Private Sub VisualStyle_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv8.CheckChanged, radioButtonAdv7.CheckChanged, radioButtonAdv5.CheckChanged
			If Me.radioButtonAdv5.Checked Then
				Me.checkBoxAdv1.Office2007ColorScheme = Office2007Theme.Blue
			End If
			If Me.radioButtonAdv7.Checked Then
				Me.checkBoxAdv1.Office2007ColorScheme = Office2007Theme.Silver
			End If
			If Me.radioButtonAdv8.Checked Then
				Me.checkBoxAdv1.Office2007ColorScheme = Office2007Theme.Black
            End If
            If Me.RadioButtonAdv1.Checked Then
                Me.checkBoxAdv1.Office2007ColorScheme = Office2007Theme.Managed
                Office2007Colors.ApplyManagedColors(Me, Color.DarkRed)
            End If


		End Sub
		#End Region

		 #Region "Glyph Align"
		Private Sub comboBox19_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox19.SelectedIndexChanged
			Select Case comboBox19.SelectedIndex
				Case 0
					Me.checkBoxAdv1.CheckAlign = ContentAlignment.TopLeft
				Case 1
					Me.checkBoxAdv1.CheckAlign = ContentAlignment.TopCenter
				Case 2
					Me.checkBoxAdv1.CheckAlign = ContentAlignment.TopRight
				Case 3
					Me.checkBoxAdv1.CheckAlign = ContentAlignment.MiddleLeft
				Case 4
					Me.checkBoxAdv1.CheckAlign = ContentAlignment.MiddleCenter
				Case 5
					Me.checkBoxAdv1.CheckAlign = ContentAlignment.MiddleRight
				Case 6
					Me.checkBoxAdv1.CheckAlign = ContentAlignment.BottomLeft
				Case 7
					Me.checkBoxAdv1.CheckAlign = ContentAlignment.BottomCenter
				Case 8
					Me.checkBoxAdv1.CheckAlign = ContentAlignment.BottomRight


			End Select


		End Sub
		#End Region

		 #Region "TextAlign"
		Private Sub comboBox18_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox18.SelectedIndexChanged
			Select Case comboBox18.SelectedIndex
				Case 0
					Me.checkBoxAdv1.TextContentAlignment = ContentAlignment.TopLeft
				Case 1
					Me.checkBoxAdv1.TextContentAlignment = ContentAlignment.TopCenter
				Case 2
					Me.checkBoxAdv1.TextContentAlignment = ContentAlignment.TopRight
				Case 3
					Me.checkBoxAdv1.TextContentAlignment = ContentAlignment.MiddleLeft
				Case 4
					Me.checkBoxAdv1.TextContentAlignment = ContentAlignment.MiddleCenter
				Case 5
					Me.checkBoxAdv1.TextContentAlignment = ContentAlignment.MiddleRight
				Case 6
					Me.checkBoxAdv1.TextContentAlignment = ContentAlignment.BottomLeft
				Case 7
					Me.checkBoxAdv1.TextContentAlignment = ContentAlignment.BottomCenter
				Case 8
					Me.checkBoxAdv1.TextContentAlignment = ContentAlignment.BottomRight


			End Select

		End Sub
		#End Region

		 #Region "ThemesEnabled"
		Private Sub checkBox7_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox7.CheckedChanged
			Me.checkBoxAdv1.ThemesEnabled = checkBox7.Checked
		End Sub
		#End Region



		#End Region

		#Region "RadioButtonAdv properties"

		#Region "ImageCheckBox"
		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
			Me.radioButtonAdv12.ImageCheckBox = Me.checkBox1.Checked
		End Sub
		#End Region

		#Region "BackGroundStyle"
		Private Sub comboBox7_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox7.SelectedIndexChanged
			Select Case comboBox7.Items(comboBox7.SelectedIndex).ToString()
				Case "Default"
					Me.radioButtonAdv12.BackgroundStyle = Syncfusion.Windows.Forms.Tools.CheckBoxAdvBackStyle.Default
				Case "HorizontalGradient"
					Me.radioButtonAdv12.BackgroundStyle = Syncfusion.Windows.Forms.Tools.CheckBoxAdvBackStyle.HorizontalGradient
				Case "VerticalGradient"
					Me.radioButtonAdv12.BackgroundStyle = Syncfusion.Windows.Forms.Tools.CheckBoxAdvBackStyle.VerticalGradient
			End Select
		End Sub
		#End Region

		#Region "Gradient Colors"
		Private Sub buttonEdit4_ButtonClicked(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs) Handles buttonEdit4.ButtonClicked
			If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				buttonEdit4.TextBox.BackColor = colorDialog1.Color
				Me.radioButtonAdv12.GradientStart = colorDialog1.Color
			End If
		End Sub

		Private Sub buttonEdit3_ButtonClicked(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs) Handles buttonEdit3.ButtonClicked
			If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				buttonEdit3.TextBox.BackColor = colorDialog1.Color
				Me.radioButtonAdv12.GradientEnd = colorDialog1.Color
			End If
		End Sub
		#End Region

		#Region "BorderStyle"

		Private Sub comboBox9_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox9.SelectedIndexChanged
			Select Case comboBox9.Items(comboBox9.SelectedIndex).ToString()
				Case "None"
					Me.radioButtonAdv12.BorderStyle = BorderStyle.None
					Me.comboBox10.Enabled = False
					Me.comboBox15.Enabled = False
					Me.buttonEdit8.Enabled = False
				Case "FixedSingle"
					Me.radioButtonAdv12.BorderStyle = BorderStyle.FixedSingle
					Me.comboBox10.Enabled = False
					Me.comboBox15.Enabled = True
					Me.buttonEdit8.Enabled = True
				Case "Fixed3D"
					Me.radioButtonAdv12.BorderStyle = BorderStyle.Fixed3D
					Me.comboBox10.Enabled = True
					Me.comboBox15.Enabled = False
					Me.buttonEdit8.Enabled = False
			End Select
		End Sub
		#End Region

		#Region "Border3DStyle"
		Private Sub comboBox10_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox10.SelectedIndexChanged
			Select Case comboBox10.Items(comboBox10.SelectedIndex).ToString()
				Case "RaisedOuter"
					Me.radioButtonAdv12.Border3DStyle = Border3DStyle.RaisedOuter
				Case "Adjust"
					Me.radioButtonAdv12.Border3DStyle = Border3DStyle.Adjust
				Case "Bump"
					Me.radioButtonAdv12.Border3DStyle = Border3DStyle.Bump
				Case "Etched"
					Me.radioButtonAdv12.Border3DStyle = Border3DStyle.Etched
				Case "Flat"
					Me.radioButtonAdv12.Border3DStyle = Border3DStyle.Flat
				Case "Raised"
					Me.radioButtonAdv12.Border3DStyle = Border3DStyle.Raised
				Case "RaisedInner"
					Me.radioButtonAdv12.Border3DStyle = Border3DStyle.RaisedInner
				Case "Sunken"
					Me.radioButtonAdv12.Border3DStyle = Border3DStyle.Sunken
				Case "SunkenInner"
					Me.radioButtonAdv12.Border3DStyle = Border3DStyle.SunkenInner
				Case "SunkenOuter"
					Me.radioButtonAdv12.Border3DStyle = Border3DStyle.SunkenOuter
			End Select
		End Sub
		#End Region

		#Region " BorderColor"
		Private Sub buttonEdit8_ButtonClicked(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs) Handles buttonEdit8.ButtonClicked
			If colorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				buttonEdit8.TextBox.BackColor = colorDialog1.Color
				Me.radioButtonAdv12.BorderColor = colorDialog1.Color
			End If

		End Sub
		#End Region

		#Region "BorderSingleStyle"

		Private Sub comboBox15_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox15.SelectedIndexChanged
            Select Case comboBox15.Items(comboBox15.SelectedIndex).ToString()
                Case "Dashed"
                    Me.radioButtonAdv12.BorderSingle = ButtonBorderStyle.Dashed
                Case "Dotted"
                    Me.radioButtonAdv12.BorderSingle = ButtonBorderStyle.Dotted
                Case "Inset"
                    Me.radioButtonAdv12.BorderSingle = ButtonBorderStyle.Inset
                Case "None"
                    Me.radioButtonAdv12.BorderSingle = ButtonBorderStyle.None
                Case "Outset"
                    Me.radioButtonAdv12.BorderSingle = ButtonBorderStyle.Outset
                Case "Solid"
                    Me.radioButtonAdv12.BorderSingle = ButtonBorderStyle.Solid
            End Select
		End Sub
		#End Region

		#Region "DataBinding"

		Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv1.Click
			Dim mgr As CurrencyManager = CType(BindingContext(m_dt), CurrencyManager)
			If mgr.Position < mgr.Count - 1 Then
				mgr.Position = mgr.Position + 1
			ElseIf mgr.Position > 0 Then
				mgr.Position = mgr.Position - 1
			End If
		End Sub
		#End Region

		#Region "VisualStyle"
		Private Sub comboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox3.SelectedIndexChanged
			If Me.comboBox3.SelectedIndex = 0 Then
				Me.checkBox8.Checked = True
				Me.radioButtonAdv11.Enabled = False
				Me.radioButtonAdv10.Enabled = False
                Me.radioButtonAdv9.Enabled = False
                Me.RadioButtonAdv2.Enabled = False
				Me.radioButtonAdv12.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Default
			Else
				Me.checkBox8.Checked = False
				Me.radioButtonAdv11.Enabled = True
				Me.radioButtonAdv10.Enabled = True
                Me.radioButtonAdv9.Enabled = True
                Me.RadioButtonAdv2.Enabled = True
				Me.radioButtonAdv12.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2007
			End If
		End Sub
		Private Sub radioButtonVisualStyle_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonAdv9.CheckChanged, radioButtonAdv10.CheckChanged, radioButtonAdv11.CheckChanged
			If Me.radioButtonAdv11.Checked Then
				Me.radioButtonAdv12.Office2007ColorScheme = Office2007Theme.Blue
			End If
			If Me.radioButtonAdv10.Checked Then
				Me.radioButtonAdv12.Office2007ColorScheme = Office2007Theme.Silver
			End If
			If Me.radioButtonAdv9.Checked Then
				Me.radioButtonAdv12.Office2007ColorScheme = Office2007Theme.Black
			End If
            If Me.RadioButtonAdv2.Checked Then
                Me.radioButtonAdv12.Office2007ColorScheme = Office2007Theme.Managed
                Office2007Colors.ApplyManagedColors(Me, Color.DarkRed)
            End If
		End Sub
		#End Region

		#Region "TextShadow"
		Private Sub checkBox9_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox9.CheckedChanged
			Me.radioButtonAdv12.TextShadow = Me.checkBox9.Checked
		End Sub
		#End Region

		#Region "Glyph Align"
		Private Sub comboBox16_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox16.SelectedIndexChanged
			Select Case comboBox16.SelectedIndex
				Case 0
					Me.radioButtonAdv12.CheckAlign = ContentAlignment.TopLeft
				Case 1
					Me.radioButtonAdv12.CheckAlign = ContentAlignment.TopCenter
				Case 2
					Me.radioButtonAdv12.CheckAlign = ContentAlignment.TopRight
				Case 3
					Me.radioButtonAdv12.CheckAlign = ContentAlignment.MiddleLeft
				Case 4
					Me.radioButtonAdv12.CheckAlign = ContentAlignment.MiddleCenter
				Case 5
					Me.radioButtonAdv12.CheckAlign = ContentAlignment.MiddleRight
				Case 6
					Me.radioButtonAdv12.CheckAlign = ContentAlignment.BottomLeft
				Case 7
					Me.radioButtonAdv12.CheckAlign = ContentAlignment.BottomCenter
				Case 8
					Me.radioButtonAdv12.CheckAlign = ContentAlignment.BottomRight


			End Select

		End Sub
		#End Region

		#Region "TextAlign"
		Private Sub comboBox17_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox17.SelectedIndexChanged
			Select Case comboBox17.SelectedIndex
				Case 0
					Me.radioButtonAdv12.TextContentAlignment = ContentAlignment.TopLeft
				Case 1
					Me.radioButtonAdv12.TextContentAlignment = ContentAlignment.TopCenter
				Case 2
					Me.radioButtonAdv12.TextContentAlignment = ContentAlignment.TopRight
				Case 3
					Me.radioButtonAdv12.TextContentAlignment = ContentAlignment.MiddleLeft
				Case 4
					Me.radioButtonAdv12.TextContentAlignment = ContentAlignment.MiddleCenter
				Case 5
					Me.radioButtonAdv12.TextContentAlignment = ContentAlignment.MiddleRight
				Case 6
					Me.radioButtonAdv12.TextContentAlignment = ContentAlignment.BottomLeft
				Case 7
					Me.radioButtonAdv12.TextContentAlignment = ContentAlignment.BottomCenter
				Case 8
					Me.radioButtonAdv12.TextContentAlignment = ContentAlignment.BottomRight


			End Select

		End Sub
		#End Region

		#Region "ThemesEnabled"
		Private Sub checkBox8_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox8.CheckedChanged
			Me.radioButtonAdv12.ThemesEnabled = checkBox8.Checked
		End Sub
		#End Region

		#Region "RadioButton State"
		Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
			Me.radioButtonAdv12.Checked = Me.checkBox2.Checked
		End Sub
		#End Region

		 #End Region


	End Class
End Namespace