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

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms


'/ <summary>
'/ Summary description for FlowLayoutCC.
'/ </summary>

Public Class FlowLayoutCC
    Inherits System.Windows.Forms.Form
    Private panel1 As System.Windows.Forms.Panel
    Private textBox2 As System.Windows.Forms.TextBox
    Public textBox4 As System.Windows.Forms.TextBox
    Public autoLabel4 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Private panel2 As System.Windows.Forms.Panel
    Private textBox5 As System.Windows.Forms.TextBox
    Private textBox6 As System.Windows.Forms.TextBox
    Private textBox7 As System.Windows.Forms.TextBox
    Private textBox8 As System.Windows.Forms.TextBox
    Private flowLayout3 As Syncfusion.Windows.Forms.Tools.FlowLayout
    Private autoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Private autoLabel2 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Private autoLabel5 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Private autoLabel6 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Private flowLayout1 As Syncfusion.Windows.Forms.Tools.FlowLayout
    Private textBox1 As System.Windows.Forms.TextBox
    Private autoLabel7 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Private panel3 As System.Windows.Forms.Panel
    Private flowLayout4 As Syncfusion.Windows.Forms.Tools.FlowLayout
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private groupBox2 As System.Windows.Forms.GroupBox
    Private radioButton1 As System.Windows.Forms.RadioButton
    Private radioButton2 As System.Windows.Forms.RadioButton
    Private radioButton3 As System.Windows.Forms.RadioButton
    Private radioButton4 As System.Windows.Forms.RadioButton
    Private flowLayout5 As Syncfusion.Windows.Forms.Tools.FlowLayout
    Private button1 As System.Windows.Forms.Button
    Private button2 As System.Windows.Forms.Button
    Private button3 As System.Windows.Forms.Button
    Private button4 As System.Windows.Forms.Button
    Private panel4 As System.Windows.Forms.Panel
    Private flowLayout6 As Syncfusion.Windows.Forms.Tools.FlowLayout
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private checkBox2 As System.Windows.Forms.CheckBox
    Private checkBox3 As System.Windows.Forms.CheckBox
    Private flowLayout7 As Syncfusion.Windows.Forms.Tools.FlowLayout
    Private textBox9 As System.Windows.Forms.TextBox
    Private textBox10 As System.Windows.Forms.TextBox
    Private textBox11 As System.Windows.Forms.TextBox
    Private textBox12 As System.Windows.Forms.TextBox
    Private textBox13 As System.Windows.Forms.TextBox
    Private textBox14 As System.Windows.Forms.TextBox
    Private autoLabel8 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Private autoLabel9 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Private autoLabel10 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Private autoLabel11 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Private autoLabel12 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Private textBox15 As System.Windows.Forms.TextBox
    Private autoLabel13 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Private comboBox1 As System.Windows.Forms.ComboBox
    Private autoLabel14 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Private textBox3 As System.Windows.Forms.TextBox
    Private autoLabel3 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Private components As System.ComponentModel.IContainer
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
    End Sub 'New
     
    '
    ' TODO: Add any constructor code after InitializeComponent call
    '
    
    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FlowLayoutCC))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.autoLabel3 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.autoLabel14 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.autoLabel13 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.textBox15 = New System.Windows.Forms.TextBox()
        Me.autoLabel12 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.autoLabel7 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.autoLabel4 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.autoLabel6 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.textBox7 = New System.Windows.Forms.TextBox()
        Me.autoLabel5 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.textBox8 = New System.Windows.Forms.TextBox()
        Me.autoLabel2 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.textBox6 = New System.Windows.Forms.TextBox()
        Me.autoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.flowLayout3 = New Syncfusion.Windows.Forms.Tools.FlowLayout(Me.components)
        Me.flowLayout1 = New Syncfusion.Windows.Forms.Tools.FlowLayout(Me.components)
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioButton4 = New System.Windows.Forms.RadioButton()
        Me.radioButton3 = New System.Windows.Forms.RadioButton()
        Me.radioButton2 = New System.Windows.Forms.RadioButton()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.autoLabel11 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.textBox13 = New System.Windows.Forms.TextBox()
        Me.autoLabel10 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.textBox12 = New System.Windows.Forms.TextBox()
        Me.autoLabel9 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.textBox11 = New System.Windows.Forms.TextBox()
        Me.autoLabel8 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.textBox14 = New System.Windows.Forms.TextBox()
        Me.checkBox3 = New System.Windows.Forms.CheckBox()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.textBox9 = New System.Windows.Forms.TextBox()
        Me.textBox10 = New System.Windows.Forms.TextBox()
        Me.flowLayout4 = New Syncfusion.Windows.Forms.Tools.FlowLayout(Me.components)
        Me.flowLayout5 = New Syncfusion.Windows.Forms.Tools.FlowLayout(Me.components)
        Me.button1 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.flowLayout6 = New Syncfusion.Windows.Forms.Tools.FlowLayout(Me.components)
        Me.flowLayout7 = New Syncfusion.Windows.Forms.Tools.FlowLayout(Me.components)
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.flowLayout3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flowLayout1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel3.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.flowLayout4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flowLayout5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel4.SuspendLayout()
        CType(Me.flowLayout6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flowLayout7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.textBox1, Me.autoLabel3, Me.textBox3, Me.autoLabel14, Me.autoLabel13, Me.autoLabel12, Me.autoLabel7, Me.textBox2, Me.autoLabel4, Me.textBox4, Me.comboBox1, Me.textBox15})
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(456, 54)
        Me.panel1.TabIndex = 0
        '
        'textBox1
        '
        Me.flowLayout1.SetConstraints(Me.textBox1, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Center, False, False, False))
        Me.textBox1.Location = New System.Drawing.Point(71, 4)
        Me.flowLayout1.SetMinimumSize(Me.textBox1, New System.Drawing.Size(100, 20))
        Me.textBox1.Name = "textBox1"
        Me.flowLayout1.SetPreferredSize(Me.textBox1, New System.Drawing.Size(100, 20))
        Me.textBox1.Size = New System.Drawing.Size(124, 20)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = "HAlign Justify; "
        '
        'autoLabel3
        '
        Me.autoLabel3.DX = -24
        Me.autoLabel3.DY = 2
        Me.autoLabel3.LabeledControl = Me.textBox3
        Me.autoLabel3.Location = New System.Drawing.Point(200, 6)
        Me.autoLabel3.Name = "autoLabel3"
        Me.autoLabel3.Size = New System.Drawing.Size(20, 16)
        Me.autoLabel3.TabIndex = 1
        Me.autoLabel3.Text = "&MI:"
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(224, 4)
        Me.flowLayout1.SetMinimumSize(Me.textBox3, New System.Drawing.Size(32, 20))
        Me.textBox3.Name = "textBox3"
        Me.flowLayout1.SetPreferredSize(Me.textBox3, New System.Drawing.Size(32, 20))
        Me.textBox3.Size = New System.Drawing.Size(32, 20)
        Me.textBox3.TabIndex = 1
        Me.textBox3.Text = "HAlign Left"
        '
        'autoLabel14
        '
        Me.autoLabel14.DX = -35
        Me.autoLabel14.DY = 3
        Me.autoLabel14.LabeledControl = Me.comboBox1
        Me.autoLabel14.Location = New System.Drawing.Point(260, 32)
        Me.autoLabel14.Name = "autoLabel14"
        Me.autoLabel14.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom
        Me.autoLabel14.Size = New System.Drawing.Size(31, 16)
        Me.autoLabel14.TabIndex = 4
        Me.autoLabel14.Text = "State"
        '
        'comboBox1
        '
        Me.comboBox1.Location = New System.Drawing.Point(295, 29)
        Me.flowLayout1.SetMinimumSize(Me.comboBox1, New System.Drawing.Size(64, 21))
        Me.comboBox1.Name = "comboBox1"
        Me.flowLayout1.SetPreferredSize(Me.comboBox1, New System.Drawing.Size(64, 21))
        Me.comboBox1.Size = New System.Drawing.Size(64, 21)
        Me.comboBox1.TabIndex = 4
        Me.comboBox1.Text = "HAlign Left"
        '
        'autoLabel13
        '
        Me.autoLabel13.DX = -24
        Me.autoLabel13.DY = 3
        Me.autoLabel13.LabeledControl = Me.textBox15
        Me.autoLabel13.Location = New System.Drawing.Point(364, 32)
        Me.autoLabel13.Name = "autoLabel13"
        Me.autoLabel13.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom
        Me.autoLabel13.Size = New System.Drawing.Size(20, 16)
        Me.autoLabel13.TabIndex = 5
        Me.autoLabel13.Text = "Zip"
        '
        'textBox15
        '
        Me.textBox15.Location = New System.Drawing.Point(388, 29)
        Me.flowLayout1.SetMinimumSize(Me.textBox15, New System.Drawing.Size(64, 20))
        Me.textBox15.Name = "textBox15"
        Me.flowLayout1.SetPreferredSize(Me.textBox15, New System.Drawing.Size(64, 20))
        Me.textBox15.Size = New System.Drawing.Size(64, 20)
        Me.textBox15.TabIndex = 5
        Me.textBox15.Text = "HAlign Left "
        '
        'autoLabel12
        '
        Me.autoLabel12.DX = -66
        Me.autoLabel12.DY = 2
        Me.autoLabel12.LabeledControl = Me.textBox2
        Me.autoLabel12.Location = New System.Drawing.Point(261, 6)
        Me.autoLabel12.Name = "autoLabel12"
        Me.autoLabel12.Size = New System.Drawing.Size(62, 16)
        Me.autoLabel12.TabIndex = 2
        Me.autoLabel12.Text = "Last Name:"
        '
        'textBox2
        '
        Me.flowLayout1.SetConstraints(Me.textBox2, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Center, False, False, False))
        Me.textBox2.Location = New System.Drawing.Point(327, 4)
        Me.flowLayout1.SetMinimumSize(Me.textBox2, New System.Drawing.Size(100, 20))
        Me.textBox2.Name = "textBox2"
        Me.flowLayout1.SetPreferredSize(Me.textBox2, New System.Drawing.Size(100, 20))
        Me.textBox2.Size = New System.Drawing.Size(124, 20)
        Me.textBox2.TabIndex = 2
        Me.textBox2.Text = "HAlign Justify; "
        '
        'autoLabel7
        '
        Me.autoLabel7.DX = -67
        Me.autoLabel7.DY = 2
        Me.autoLabel7.LabeledControl = Me.textBox1
        Me.autoLabel7.Location = New System.Drawing.Point(4, 6)
        Me.autoLabel7.Name = "autoLabel7"
        Me.autoLabel7.Size = New System.Drawing.Size(63, 16)
        Me.autoLabel7.TabIndex = 0
        Me.autoLabel7.Text = "First Name:"
        '
        'autoLabel4
        '
        Me.autoLabel4.DX = -65
        Me.autoLabel4.DY = 2
        Me.autoLabel4.LabeledControl = Me.textBox4
        Me.autoLabel4.Location = New System.Drawing.Point(4, 31)
        Me.autoLabel4.Name = "autoLabel4"
        Me.autoLabel4.Size = New System.Drawing.Size(61, 16)
        Me.autoLabel4.TabIndex = 3
        Me.autoLabel4.Text = "Address    :"
        '
        'textBox4
        '
        Me.flowLayout1.SetConstraints(Me.textBox4, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Center, True, False, False))
        Me.textBox4.Location = New System.Drawing.Point(69, 29)
        Me.flowLayout1.SetMinimumSize(Me.textBox4, New System.Drawing.Size(100, 20))
        Me.textBox4.Name = "textBox4"
        Me.flowLayout1.SetPreferredSize(Me.textBox4, New System.Drawing.Size(100, 20))
        Me.textBox4.Size = New System.Drawing.Size(186, 20)
        Me.textBox4.TabIndex = 3
        Me.textBox4.Text = "HAlign Justify; NewLine True; "
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
        Me.panel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.autoLabel6, Me.autoLabel5, Me.autoLabel2, Me.autoLabel1, Me.textBox8, Me.textBox6, Me.textBox5, Me.textBox7})
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 54)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(456, 53)
        Me.panel2.TabIndex = 1
        '
        'autoLabel6
        '
        Me.autoLabel6.DX = -36
        Me.autoLabel6.DY = 2
        Me.autoLabel6.LabeledControl = Me.textBox7
        Me.autoLabel6.Location = New System.Drawing.Point(4, 31)
        Me.autoLabel6.Name = "autoLabel6"
        Me.autoLabel6.Size = New System.Drawing.Size(32, 16)
        Me.autoLabel6.TabIndex = 11
        Me.autoLabel6.Text = "Label"
        '
        'textBox7
        '
        Me.textBox7.Location = New System.Drawing.Point(40, 29)
        Me.flowLayout3.SetMinimumSize(Me.textBox7, New System.Drawing.Size(100, 20))
        Me.textBox7.Multiline = True
        Me.textBox7.Name = "textBox7"
        Me.flowLayout3.SetPreferredSize(Me.textBox7, New System.Drawing.Size(100, 20))
        Me.textBox7.TabIndex = 4
        Me.textBox7.Text = "Left"
        '
        'autoLabel5
        '
        Me.autoLabel5.DX = -36
        Me.autoLabel5.DY = 2
        Me.autoLabel5.LabeledControl = Me.textBox8
        Me.autoLabel5.Location = New System.Drawing.Point(4, 6)
        Me.autoLabel5.Name = "autoLabel5"
        Me.autoLabel5.Size = New System.Drawing.Size(32, 16)
        Me.autoLabel5.TabIndex = 10
        Me.autoLabel5.Text = "Label"
        '
        'textBox8
        '
        Me.textBox8.Location = New System.Drawing.Point(40, 4)
        Me.flowLayout3.SetMinimumSize(Me.textBox8, New System.Drawing.Size(100, 20))
        Me.textBox8.Multiline = True
        Me.textBox8.Name = "textBox8"
        Me.flowLayout3.SetPreferredSize(Me.textBox8, New System.Drawing.Size(100, 20))
        Me.textBox8.TabIndex = 1
        Me.textBox8.Text = "Left"
        '
        'autoLabel2
        '
        Me.autoLabel2.DX = -36
        Me.autoLabel2.DY = 2
        Me.autoLabel2.LabeledControl = Me.textBox6
        Me.autoLabel2.Location = New System.Drawing.Point(145, 6)
        Me.autoLabel2.Name = "autoLabel2"
        Me.autoLabel2.Size = New System.Drawing.Size(32, 16)
        Me.autoLabel2.TabIndex = 9
        Me.autoLabel2.Text = "Label"
        '
        'textBox6
        '
        Me.flowLayout3.SetConstraints(Me.textBox6, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Center, False, False, False))
        Me.textBox6.Location = New System.Drawing.Point(181, 4)
        Me.flowLayout3.SetMinimumSize(Me.textBox6, New System.Drawing.Size(82, 20))
        Me.textBox6.Name = "textBox6"
        Me.flowLayout3.SetPreferredSize(Me.textBox6, New System.Drawing.Size(82, 20))
        Me.textBox6.Size = New System.Drawing.Size(130, 20)
        Me.textBox6.TabIndex = 2
        Me.textBox6.Text = "Justify"
        '
        'autoLabel1
        '
        Me.autoLabel1.DX = -36
        Me.autoLabel1.DY = 2
        Me.autoLabel1.LabeledControl = Me.textBox5
        Me.autoLabel1.Location = New System.Drawing.Point(316, 6)
        Me.autoLabel1.Name = "autoLabel1"
        Me.autoLabel1.Size = New System.Drawing.Size(32, 16)
        Me.autoLabel1.TabIndex = 8
        Me.autoLabel1.Text = "Label"
        '
        'textBox5
        '
        Me.flowLayout3.SetConstraints(Me.textBox5, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Right, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Center, False, False, False))
        Me.textBox5.Location = New System.Drawing.Point(352, 4)
        Me.flowLayout3.SetMinimumSize(Me.textBox5, New System.Drawing.Size(100, 20))
        Me.textBox5.Name = "textBox5"
        Me.flowLayout3.SetPreferredSize(Me.textBox5, New System.Drawing.Size(100, 20))
        Me.textBox5.TabIndex = 3
        Me.textBox5.Text = "Right"
        '
        'flowLayout3
        '
        Me.flowLayout3.Alignment = Syncfusion.Windows.Forms.Tools.FlowAlignment.ChildConstraints
        Me.flowLayout3.AutoHeight = True
        Me.flowLayout3.BottomMargin = 4
        Me.flowLayout3.ContainerControl = Me.panel2
        Me.flowLayout3.HorzFarMargin = 4
        Me.flowLayout3.HorzNearMargin = 4
        Me.flowLayout3.TopMargin = 4
        '
        'flowLayout1
        '
        Me.flowLayout1.Alignment = Syncfusion.Windows.Forms.Tools.FlowAlignment.ChildConstraints
        Me.flowLayout1.AutoHeight = True
        Me.flowLayout1.BottomMargin = 4
        Me.flowLayout1.ContainerControl = Me.panel1
        Me.flowLayout1.HorzFarMargin = 4
        Me.flowLayout1.HorzNearMargin = 4
        Me.flowLayout1.TopMargin = 4
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(205, Byte), CType(212, Byte), CType(231, Byte))
        Me.panel3.Controls.AddRange(New System.Windows.Forms.Control() {Me.groupBox1, Me.groupBox2})
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(0, 107)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(456, 210)
        Me.panel3.TabIndex = 2
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.FromArgb(CType(205, Byte), CType(212, Byte), CType(231, Byte))
        Me.flowLayout4.SetConstraints(Me.groupBox1, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Justify, False, False, True))
        Me.groupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.radioButton4, Me.radioButton3, Me.radioButton2, Me.radioButton1})
        Me.groupBox1.Location = New System.Drawing.Point(4, 4)
        Me.flowLayout4.SetMinimumSize(Me.groupBox1, New System.Drawing.Size(150, 100))
        Me.groupBox1.Name = "groupBox1"
        Me.flowLayout4.SetPreferredSize(Me.groupBox1, New System.Drawing.Size(150, 100))
        Me.groupBox1.Size = New System.Drawing.Size(168, 202)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Vertical Flow"
        '
        'radioButton4
        '
        Me.radioButton4.BackColor = System.Drawing.Color.FromArgb(CType(205, Byte), CType(212, Byte), CType(231, Byte))
        Me.flowLayout5.SetConstraints(Me.radioButton4, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, False, True, False))
        Me.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.radioButton4.Location = New System.Drawing.Point(4, 14)
        Me.flowLayout5.SetMinimumSize(Me.radioButton4, New System.Drawing.Size(104, 30))
        Me.radioButton4.Name = "radioButton4"
        Me.flowLayout5.SetPreferredSize(Me.radioButton4, New System.Drawing.Size(104, 30))
        Me.radioButton4.Size = New System.Drawing.Size(156, 30)
        Me.radioButton4.TabIndex = 0
        Me.radioButton4.Text = "radioButton4"
        '
        'radioButton3
        '
        Me.radioButton3.BackColor = System.Drawing.Color.FromArgb(CType(205, Byte), CType(212, Byte), CType(231, Byte))
        Me.flowLayout5.SetConstraints(Me.radioButton3, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, False, True, False))
        Me.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.radioButton3.Location = New System.Drawing.Point(4, 49)
        Me.flowLayout5.SetMinimumSize(Me.radioButton3, New System.Drawing.Size(104, 30))
        Me.radioButton3.Name = "radioButton3"
        Me.flowLayout5.SetPreferredSize(Me.radioButton3, New System.Drawing.Size(104, 30))
        Me.radioButton3.Size = New System.Drawing.Size(156, 30)
        Me.radioButton3.TabIndex = 1
        Me.radioButton3.Text = "radioButton3"
        '
        'radioButton2
        '
        Me.radioButton2.BackColor = System.Drawing.Color.FromArgb(CType(205, Byte), CType(212, Byte), CType(231, Byte))
        Me.flowLayout5.SetConstraints(Me.radioButton2, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, False, True, False))
        Me.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.radioButton2.Location = New System.Drawing.Point(4, 84)
        Me.flowLayout5.SetMinimumSize(Me.radioButton2, New System.Drawing.Size(104, 30))
        Me.radioButton2.Name = "radioButton2"
        Me.flowLayout5.SetPreferredSize(Me.radioButton2, New System.Drawing.Size(104, 30))
        Me.radioButton2.Size = New System.Drawing.Size(156, 30)
        Me.radioButton2.TabIndex = 2
        Me.radioButton2.Text = "radioButton2"
        '
        'radioButton1
        '
        Me.radioButton1.BackColor = System.Drawing.Color.FromArgb(CType(205, Byte), CType(212, Byte), CType(231, Byte))
        Me.flowLayout5.SetConstraints(Me.radioButton1, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, False, True, False))
        Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.radioButton1.Location = New System.Drawing.Point(4, 119)
        Me.flowLayout5.SetMinimumSize(Me.radioButton1, New System.Drawing.Size(104, 30))
        Me.radioButton1.Name = "radioButton1"
        Me.flowLayout5.SetPreferredSize(Me.radioButton1, New System.Drawing.Size(104, 30))
        Me.radioButton1.Size = New System.Drawing.Size(156, 30)
        Me.radioButton1.TabIndex = 3
        Me.radioButton1.Text = "radioButton1"
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.FromArgb(CType(205, Byte), CType(212, Byte), CType(231, Byte))
        Me.flowLayout4.SetConstraints(Me.groupBox2, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Justify, False, False, True))
        Me.groupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.autoLabel11, Me.autoLabel10, Me.autoLabel9, Me.autoLabel8, Me.checkBox3, Me.checkBox2, Me.checkBox1, Me.textBox9, Me.textBox10, Me.textBox11, Me.textBox12, Me.textBox13, Me.textBox14})
        Me.groupBox2.Location = New System.Drawing.Point(177, 4)
        Me.flowLayout4.SetMinimumSize(Me.groupBox2, New System.Drawing.Size(256, 180))
        Me.groupBox2.Name = "groupBox2"
        Me.flowLayout4.SetPreferredSize(Me.groupBox2, New System.Drawing.Size(256, 180))
        Me.groupBox2.Size = New System.Drawing.Size(274, 202)
        Me.groupBox2.TabIndex = 3
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Vertical Flow"
        '
        'autoLabel11
        '
        Me.autoLabel11.DX = -64
        Me.autoLabel11.DY = 2
        Me.autoLabel11.LabeledControl = Me.textBox13
        Me.autoLabel11.Location = New System.Drawing.Point(137, 41)
        Me.autoLabel11.Name = "autoLabel11"
        Me.autoLabel11.Size = New System.Drawing.Size(60, 16)
        Me.autoLabel11.TabIndex = 12
        Me.autoLabel11.Text = "autoLabel3"
        '
        'textBox13
        '
        Me.flowLayout7.SetConstraints(Me.textBox13, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, False, True, False))
        Me.textBox13.Location = New System.Drawing.Point(201, 39)
        Me.flowLayout7.SetMinimumSize(Me.textBox13, New System.Drawing.Size(66, 20))
        Me.textBox13.Name = "textBox13"
        Me.flowLayout7.SetPreferredSize(Me.textBox13, New System.Drawing.Size(66, 20))
        Me.textBox13.Size = New System.Drawing.Size(62, 20)
        Me.textBox13.TabIndex = 7
        Me.textBox13.Text = "textBox13"
        '
        'autoLabel10
        '
        Me.autoLabel10.DX = -64
        Me.autoLabel10.DY = 2
        Me.autoLabel10.LabeledControl = Me.textBox12
        Me.autoLabel10.Location = New System.Drawing.Point(137, 16)
        Me.autoLabel10.Name = "autoLabel10"
        Me.autoLabel10.Size = New System.Drawing.Size(60, 16)
        Me.autoLabel10.TabIndex = 11
        Me.autoLabel10.Text = "autoLabel2"
        '
        'textBox12
        '
        Me.flowLayout7.SetConstraints(Me.textBox12, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, False, True, False))
        Me.textBox12.Location = New System.Drawing.Point(201, 14)
        Me.flowLayout7.SetMinimumSize(Me.textBox12, New System.Drawing.Size(66, 20))
        Me.textBox12.Name = "textBox12"
        Me.flowLayout7.SetPreferredSize(Me.textBox12, New System.Drawing.Size(66, 20))
        Me.textBox12.Size = New System.Drawing.Size(62, 20)
        Me.textBox12.TabIndex = 6
        Me.textBox12.Text = "textBox12"
        '
        'autoLabel9
        '
        Me.autoLabel9.DX = -64
        Me.autoLabel9.DY = 2
        Me.autoLabel9.LabeledControl = Me.textBox11
        Me.autoLabel9.Location = New System.Drawing.Point(4, 153)
        Me.autoLabel9.Name = "autoLabel9"
        Me.autoLabel9.Size = New System.Drawing.Size(60, 16)
        Me.autoLabel9.TabIndex = 10
        Me.autoLabel9.Text = "autoLabel1"
        '
        'textBox11
        '
        Me.flowLayout7.SetConstraints(Me.textBox11, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, False, True, False))
        Me.textBox11.Location = New System.Drawing.Point(68, 151)
        Me.flowLayout7.SetMinimumSize(Me.textBox11, New System.Drawing.Size(66, 20))
        Me.textBox11.Name = "textBox11"
        Me.flowLayout7.SetPreferredSize(Me.textBox11, New System.Drawing.Size(66, 20))
        Me.textBox11.Size = New System.Drawing.Size(64, 20)
        Me.textBox11.TabIndex = 5
        Me.textBox11.Text = "textBox11"
        '
        'autoLabel8
        '
        Me.autoLabel8.DX = -64
        Me.autoLabel8.DY = 2
        Me.autoLabel8.LabeledControl = Me.textBox14
        Me.autoLabel8.Location = New System.Drawing.Point(137, 66)
        Me.autoLabel8.Name = "autoLabel8"
        Me.autoLabel8.Size = New System.Drawing.Size(60, 16)
        Me.autoLabel8.TabIndex = 9
        Me.autoLabel8.Text = "autoLabel4"
        '
        'textBox14
        '
        Me.flowLayout7.SetConstraints(Me.textBox14, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, False, True, False))
        Me.textBox14.Location = New System.Drawing.Point(201, 64)
        Me.flowLayout7.SetMinimumSize(Me.textBox14, New System.Drawing.Size(66, 20))
        Me.textBox14.Name = "textBox14"
        Me.flowLayout7.SetPreferredSize(Me.textBox14, New System.Drawing.Size(66, 20))
        Me.textBox14.Size = New System.Drawing.Size(62, 20)
        Me.textBox14.TabIndex = 8
        Me.textBox14.Text = "textBox14"
        '
        'checkBox3
        '
        Me.flowLayout7.SetConstraints(Me.checkBox3, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, False, True, False))
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.checkBox3.Location = New System.Drawing.Point(4, 14)
        Me.flowLayout7.SetMinimumSize(Me.checkBox3, New System.Drawing.Size(104, 24))
        Me.checkBox3.Name = "checkBox3"
        Me.flowLayout7.SetPreferredSize(Me.checkBox3, New System.Drawing.Size(104, 24))
        Me.checkBox3.Size = New System.Drawing.Size(128, 24)
        Me.checkBox3.TabIndex = 0
        Me.checkBox3.Text = "checkBox3"
        '
        'checkBox2
        '
        Me.flowLayout7.SetConstraints(Me.checkBox2, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, False, True, False))
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.checkBox2.Location = New System.Drawing.Point(4, 43)
        Me.flowLayout7.SetMinimumSize(Me.checkBox2, New System.Drawing.Size(104, 24))
        Me.checkBox2.Name = "checkBox2"
        Me.flowLayout7.SetPreferredSize(Me.checkBox2, New System.Drawing.Size(104, 24))
        Me.checkBox2.Size = New System.Drawing.Size(128, 24)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "checkBox2"
        '
        'checkBox1
        '
        Me.flowLayout7.SetConstraints(Me.checkBox1, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, False, True, False))
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.checkBox1.Location = New System.Drawing.Point(4, 72)
        Me.flowLayout7.SetMinimumSize(Me.checkBox1, New System.Drawing.Size(104, 24))
        Me.checkBox1.Name = "checkBox1"
        Me.flowLayout7.SetPreferredSize(Me.checkBox1, New System.Drawing.Size(104, 24))
        Me.checkBox1.Size = New System.Drawing.Size(128, 24)
        Me.checkBox1.TabIndex = 2
        Me.checkBox1.Text = "checkBox1"
        '
        'textBox9
        '
        Me.flowLayout7.SetConstraints(Me.textBox9, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, False, True, False))
        Me.textBox9.Location = New System.Drawing.Point(4, 101)
        Me.flowLayout7.SetMinimumSize(Me.textBox9, New System.Drawing.Size(100, 20))
        Me.textBox9.Name = "textBox9"
        Me.flowLayout7.SetPreferredSize(Me.textBox9, New System.Drawing.Size(100, 20))
        Me.textBox9.Size = New System.Drawing.Size(128, 20)
        Me.textBox9.TabIndex = 3
        Me.textBox9.Text = "textBox9"
        '
        'textBox10
        '
        Me.flowLayout7.SetConstraints(Me.textBox10, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, False, True, False))
        Me.textBox10.Location = New System.Drawing.Point(4, 126)
        Me.flowLayout7.SetMinimumSize(Me.textBox10, New System.Drawing.Size(133, 20))
        Me.textBox10.Name = "textBox10"
        Me.flowLayout7.SetPreferredSize(Me.textBox10, New System.Drawing.Size(133, 20))
        Me.textBox10.Size = New System.Drawing.Size(128, 20)
        Me.textBox10.TabIndex = 4
        Me.textBox10.Text = "textBox10"
        '
        'flowLayout4
        '
        Me.flowLayout4.Alignment = Syncfusion.Windows.Forms.Tools.FlowAlignment.ChildConstraints
        Me.flowLayout4.BottomMargin = 4
        Me.flowLayout4.ContainerControl = Me.panel3
        Me.flowLayout4.HorzFarMargin = 4
        Me.flowLayout4.HorzNearMargin = 4
        Me.flowLayout4.TopMargin = 4
        '
        'flowLayout5
        '
        Me.flowLayout5.Alignment = Syncfusion.Windows.Forms.Tools.FlowAlignment.ChildConstraints
        Me.flowLayout5.BottomMargin = 4
        Me.flowLayout5.ContainerControl = Me.groupBox1
        Me.flowLayout5.HorzFarMargin = 8
        Me.flowLayout5.HorzNearMargin = 4
        Me.flowLayout5.LayoutMode = Syncfusion.Windows.Forms.Tools.FlowLayoutMode.Vertical
        Me.flowLayout5.TopMargin = 14
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(105, Byte), CType(112, Byte), CType(156, Byte))
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.ForeColor = System.Drawing.Color.White
        Me.button1.Location = New System.Drawing.Point(4, 4)
        Me.flowLayout6.SetMinimumSize(Me.button1, New System.Drawing.Size(75, 23))
        Me.button1.Name = "button1"
        Me.flowLayout6.SetPreferredSize(Me.button1, New System.Drawing.Size(75, 23))
        Me.button1.TabIndex = 0
        Me.button1.Text = "Left"
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(105, Byte), CType(112, Byte), CType(156, Byte))
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.ForeColor = System.Drawing.Color.White
        Me.button2.Location = New System.Drawing.Point(84, 4)
        Me.flowLayout6.SetMinimumSize(Me.button2, New System.Drawing.Size(75, 23))
        Me.button2.Name = "button2"
        Me.flowLayout6.SetPreferredSize(Me.button2, New System.Drawing.Size(75, 23))
        Me.button2.TabIndex = 1
        Me.button2.Text = "Left"
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(105, Byte), CType(112, Byte), CType(156, Byte))
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.ForeColor = System.Drawing.Color.White
        Me.button3.Location = New System.Drawing.Point(164, 4)
        Me.flowLayout6.SetMinimumSize(Me.button3, New System.Drawing.Size(75, 23))
        Me.button3.Name = "button3"
        Me.flowLayout6.SetPreferredSize(Me.button3, New System.Drawing.Size(75, 23))
        Me.button3.TabIndex = 2
        Me.button3.Text = "Left"
        '
        'button4
        '
        Me.button4.BackColor = System.Drawing.Color.FromArgb(CType(105, Byte), CType(112, Byte), CType(156, Byte))
        Me.flowLayout6.SetConstraints(Me.button4, New Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(True, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Right, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Center, False, False, False))
        Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button4.ForeColor = System.Drawing.Color.White
        Me.button4.Location = New System.Drawing.Point(377, 4)
        Me.flowLayout6.SetMinimumSize(Me.button4, New System.Drawing.Size(75, 23))
        Me.button4.Name = "button4"
        Me.flowLayout6.SetPreferredSize(Me.button4, New System.Drawing.Size(75, 23))
        Me.button4.TabIndex = 3
        Me.button4.Text = "Right"
        '
        'panel4
        '
        Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(227, Byte), CType(239, Byte))
        Me.panel4.Controls.AddRange(New System.Windows.Forms.Control() {Me.button1, Me.button2, Me.button3, Me.button4})
        Me.panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel4.Location = New System.Drawing.Point(0, 317)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(456, 32)
        Me.panel4.TabIndex = 4
        '
        'flowLayout6
        '
        Me.flowLayout6.Alignment = Syncfusion.Windows.Forms.Tools.FlowAlignment.ChildConstraints
        Me.flowLayout6.BottomMargin = 4
        Me.flowLayout6.ContainerControl = Me.panel4
        Me.flowLayout6.HorzFarMargin = 4
        Me.flowLayout6.HorzNearMargin = 4
        Me.flowLayout6.TopMargin = 4
        '
        'flowLayout7
        '
        Me.flowLayout7.Alignment = Syncfusion.Windows.Forms.Tools.FlowAlignment.ChildConstraints
        Me.flowLayout7.BottomMargin = 10
        Me.flowLayout7.ContainerControl = Me.groupBox2
        Me.flowLayout7.HorzFarMargin = 12
        Me.flowLayout7.HorzNearMargin = 4
        Me.flowLayout7.LayoutMode = Syncfusion.Windows.Forms.Tools.FlowLayoutMode.Vertical
        Me.flowLayout7.TopMargin = 14
        '
        'FlowLayoutCC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(456, 349)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel3, Me.panel2, Me.panel1, Me.panel4})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FlowLayoutCC"
        Me.Text = "FlowLayout (with ChildConstraints)"
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        CType(Me.flowLayout3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flowLayout1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel3.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        CType(Me.flowLayout4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flowLayout5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel4.ResumeLayout(False)
        CType(Me.flowLayout6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flowLayout7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region
End Class 'FlowLayoutCC