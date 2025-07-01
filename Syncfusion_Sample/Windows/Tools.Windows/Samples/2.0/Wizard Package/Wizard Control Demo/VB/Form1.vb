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
Imports System.Data
Imports System.ComponentModel.Design
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms


'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits Syncfusion.Windows.Forms.Office2007Form
   Private panel1 As System.Windows.Forms.Panel
   Private pictureBox1 As System.Windows.Forms.PictureBox
   Private label1 As System.Windows.Forms.Label
   Private label2 As System.Windows.Forms.Label
   Private wizardControlPage2 As Syncfusion.Windows.Forms.Tools.WizardControlPage
   Private WithEvents wizardControl1 As Syncfusion.Windows.Forms.Tools.WizardControl
   Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
   Private wizardContainer1 As Syncfusion.Windows.Forms.Tools.WizardContainer
   Private label3 As System.Windows.Forms.Label
   Private label4 As System.Windows.Forms.Label
    Private WithEvents wizardControlPage1 As Syncfusion.Windows.Forms.Tools.WizardControlPage
   Private pictureBox3 As System.Windows.Forms.PictureBox
   Private pictureBox4 As System.Windows.Forms.PictureBox
   Private WithEvents wizardControlPage3 As Syncfusion.Windows.Forms.Tools.WizardControlPage
   Private label5 As System.Windows.Forms.Label
   Private imageList1 As System.Windows.Forms.ImageList
   Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
   Private label6 As System.Windows.Forms.Label
   Private label7 As System.Windows.Forms.Label
   Private linkLabel1 As System.Windows.Forms.LinkLabel
   Private label8 As System.Windows.Forms.Label
   Private label9 As System.Windows.Forms.Label
   Private label10 As System.Windows.Forms.Label
   Private textBox1 As System.Windows.Forms.TextBox
   Private label11 As System.Windows.Forms.Label
   Private textBox2 As System.Windows.Forms.TextBox
   Private label12 As System.Windows.Forms.Label
   Private numericUpDown1 As System.Windows.Forms.NumericUpDown
   Private label13 As System.Windows.Forms.Label
   Private textBox3 As System.Windows.Forms.TextBox
   Private radioButton1 As System.Windows.Forms.RadioButton
    Private radioButton2 As System.Windows.Forms.RadioButton

   Private WithEvents wizardControlPage4 As Syncfusion.Windows.Forms.Tools.WizardControlPage
   Private WithEvents wizardControlPage5 As Syncfusion.Windows.Forms.Tools.WizardControlPage
    Private progressBarEx1 As Syncfusion.Windows.Forms.Tools.ProgressBarAdv
   Private label14 As System.Windows.Forms.Label
   Private label15 As System.Windows.Forms.Label
   Private WithEvents timer1 As System.Windows.Forms.Timer
   Private WithEvents wizardControlPage6 As Syncfusion.Windows.Forms.Tools.WizardControlPage
   Private label16 As System.Windows.Forms.Label
   Private label17 As System.Windows.Forms.Label
   Private label18 As System.Windows.Forms.Label
    Private dateTimePickerExt1 As Syncfusion.Windows.Forms.Tools.DateTimePickerAdv
   Private label19 As System.Windows.Forms.Label
   Private textBox4 As System.Windows.Forms.TextBox
   Private label20 As System.Windows.Forms.Label
   Private textBox5 As System.Windows.Forms.TextBox
    Private components As System.ComponentModel.IContainer
    Private WithEvents _cancelButton As System.Windows.Forms.Button
   
   
   Public Sub New()
      '
      ' Required for Windows Form Designer support
      '
        InitializeComponent()

        Me._cancelButton = Me.wizardControl1.CancelButton

   End Sub 'New
    
   
   '/ <summary>
   '/ Clean up any resources being used.
   '/ </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panel1 = New System.Windows.Forms.Panel
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.wizardControlPage2 = New Syncfusion.Windows.Forms.Tools.WizardControlPage(Me.components)
        Me.wizardControl1 = New Syncfusion.Windows.Forms.Tools.WizardControl
        Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.label3 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.wizardContainer1 = New Syncfusion.Windows.Forms.Tools.WizardContainer
        Me.wizardControlPage1 = New Syncfusion.Windows.Forms.Tools.WizardControlPage(Me.components)
        Me.label8 = New System.Windows.Forms.Label
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel
        Me.label7 = New System.Windows.Forms.Label
        Me.label6 = New System.Windows.Forms.Label
        Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
        Me.pictureBox3 = New System.Windows.Forms.PictureBox
        Me.label5 = New System.Windows.Forms.Label
        Me.pictureBox4 = New System.Windows.Forms.PictureBox
        Me.wizardControlPage3 = New Syncfusion.Windows.Forms.Tools.WizardControlPage(Me.components)
        Me.radioButton2 = New System.Windows.Forms.RadioButton
        Me.radioButton1 = New System.Windows.Forms.RadioButton
        Me.textBox3 = New System.Windows.Forms.TextBox
        Me.label13 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.label12 = New System.Windows.Forms.Label
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.label11 = New System.Windows.Forms.Label
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.label10 = New System.Windows.Forms.Label
        Me.label9 = New System.Windows.Forms.Label
        Me.wizardControlPage4 = New Syncfusion.Windows.Forms.Tools.WizardControlPage(Me.components)
        Me.label15 = New System.Windows.Forms.Label
        Me.label14 = New System.Windows.Forms.Label
        Me.progressBarEx1 = New Syncfusion.Windows.Forms.Tools.ProgressBarAdv
        Me.wizardControlPage6 = New Syncfusion.Windows.Forms.Tools.WizardControlPage(Me.components)
        Me.label17 = New System.Windows.Forms.Label
        Me.label16 = New System.Windows.Forms.Label
        Me.wizardControlPage5 = New Syncfusion.Windows.Forms.Tools.WizardControlPage(Me.components)
        Me.textBox5 = New System.Windows.Forms.TextBox
        Me.label20 = New System.Windows.Forms.Label
        Me.textBox4 = New System.Windows.Forms.TextBox
        Me.label19 = New System.Windows.Forms.Label
        Me.dateTimePickerExt1 = New Syncfusion.Windows.Forms.Tools.DateTimePickerAdv
        Me.label18 = New System.Windows.Forms.Label
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wizardControlPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wizardControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wizardControl1.GridBagLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.wizardControl1.SuspendLayout()
        CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gradientPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.wizardContainer1.SuspendLayout()
        CType(Me.wizardControlPage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.wizardControlPage1.SuspendLayout()
        CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gradientPanel2.SuspendLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wizardControlPage3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.wizardControlPage3.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wizardControlPage4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.wizardControlPage4.SuspendLayout()
        CType(Me.progressBarEx1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wizardControlPage6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.wizardControlPage6.SuspendLayout()
        CType(Me.wizardControlPage5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.wizardControlPage5.SuspendLayout()
        CType(Me.dateTimePickerExt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateTimePickerExt1.Calendar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(736, 70)
        Me.panel1.TabIndex = 12
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox1.Location = New System.Drawing.Point(665, 4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(61, 61)
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label1.Location = New System.Drawing.Point(10, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(61, 15)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Page Title"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(20, 30)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(217, 15)
        Me.label2.TabIndex = 2
        Me.label2.Text = "This is the description of the Wizard Page"
        '
        'wizardControlPage2
        '
        Me.wizardControlPage2.BorderColor = System.Drawing.Color.Black
        Me.wizardControlPage2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.wizardControlPage2.Description = "This is the description of the Wizard Page"
        Me.wizardControlPage2.FullPage = False
        Me.wizardControlPage2.LayoutName = "Card1"
        Me.wizardControlPage2.Location = New System.Drawing.Point(0, 0)
        Me.wizardControlPage2.Name = "wizardControlPage2"
        Me.wizardControlPage2.NextPage = Nothing
        Me.wizardControlPage2.PreviousPage = Nothing
        Me.wizardControlPage2.Size = New System.Drawing.Size(584, 335)
        Me.wizardControlPage2.TabIndex = 0
        Me.wizardControlPage2.Title = "Page Title"
        '
        'wizardControl1
        '
        '
        '
        '
        Me.wizardControl1.BackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wizardControl1.BackButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
        Me.wizardControl1.BackButton.Enabled = False
        Me.wizardControl1.BackButton.Location = New System.Drawing.Point(392, 362)
        Me.wizardControl1.BackButton.Name = "backButton"
        Me.wizardControl1.BackButton.Text = "<< Back"
        Me.wizardControl1.BackButton.Visible = False
        Me.wizardControl1.BackColor = System.Drawing.Color.White
        Me.wizardControl1.Banner = Nothing
        Me.wizardControl1.BannerPanel = Me.gradientPanel1
        '
        '
        '
        Me.wizardControl1.CancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wizardControl1.CancelButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
        Me.wizardControl1.CancelButton.Location = New System.Drawing.Point(392, 362)
        Me.wizardControl1.CancelButton.Name = "cancelButton"
        Me.wizardControl1.CancelButton.Text = "Cancel"
        Me.wizardControl1.CancelButton.Visible = False
        Me.wizardControl1.Controls.Add(Me.wizardContainer1)
        Me.wizardControl1.Controls.Add(Me.gradientPanel1)
        Me.wizardControl1.Description = Me.label4
        Me.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.wizardControl1.FinishButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wizardControl1.FinishButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
        Me.wizardControl1.FinishButton.Location = New System.Drawing.Point(472, 362)
        Me.wizardControl1.FinishButton.Name = "finishButton"
        Me.wizardControl1.FinishButton.Text = "Finish"
        '
        '
        '
        Me.wizardControl1.GridBagLayout.ContainerControl = Me.wizardControl1
        '
        '
        '
        Me.wizardControl1.HelpButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
        Me.wizardControl1.HelpButton.Enabled = False
        Me.wizardControl1.HelpButton.Location = New System.Drawing.Point(472, 362)
        Me.wizardControl1.HelpButton.Name = "helpButton"
        Me.wizardControl1.HelpButton.Text = "Help"
        Me.wizardControl1.HelpButton.Visible = False
        Me.wizardControl1.Location = New System.Drawing.Point(0, 0)
        Me.wizardControl1.Name = "wizardControl1"
        '
        '
        '
        Me.wizardControl1.NextButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wizardControl1.NextButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
        Me.wizardControl1.NextButton.Enabled = False
        Me.wizardControl1.NextButton.Location = New System.Drawing.Point(392, 362)
        Me.wizardControl1.NextButton.Name = "nextButton"
        Me.wizardControl1.NextButton.Text = "Next >>"
        Me.wizardControl1.NextButton.Visible = False
        Me.wizardControl1.SelectedWizardPage = Me.wizardControlPage1
        Me.wizardControl1.Size = New System.Drawing.Size(552, 390)
        Me.wizardControl1.TabIndex = 0
        Me.wizardControl1.Title = Me.label3
        Me.wizardControl1.WizardPageContainer = Me.wizardContainer1
        Me.wizardControl1.WizardPages = New Syncfusion.Windows.Forms.Tools.WizardControlPage() {Me.wizardControlPage1, Me.wizardControlPage3, Me.wizardControlPage4, Me.wizardControlPage5, Me.wizardControlPage6}
        '
        'gradientPanel1
        '
        Me.gradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(220, Byte), Integer)))
        Me.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.gradientPanel1.BorderColor = System.Drawing.Color.Black
        Me.gradientPanel1.BorderSides = System.Windows.Forms.Border3DSide.Bottom
        Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gradientPanel1.Controls.Add(Me.PictureBox2)
        Me.gradientPanel1.Controls.Add(Me.label3)
        Me.gradientPanel1.Controls.Add(Me.label4)
        Me.gradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.gradientPanel1.Name = "gradientPanel1"
        Me.gradientPanel1.Size = New System.Drawing.Size(552, 70)
        Me.gradientPanel1.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(488, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'label3
        '
        Me.label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.label3.Location = New System.Drawing.Point(10, 10)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(200, 15)
        Me.label3.TabIndex = 1
        Me.label3.Text = "This is the title of the Wizard Page."
        '
        'label4
        '
        Me.label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.label4.Location = New System.Drawing.Point(20, 30)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(210, 15)
        Me.label4.TabIndex = 2
        Me.label4.Text = "This is the description of the Wizard Page."
        '
        'wizardContainer1
        '
        Me.wizardContainer1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.wizardContainer1.Controls.Add(Me.wizardControlPage1)
        Me.wizardContainer1.Controls.Add(Me.wizardControlPage3)
        Me.wizardContainer1.Controls.Add(Me.wizardControlPage4)
        Me.wizardContainer1.Controls.Add(Me.wizardControlPage5)
        Me.wizardContainer1.Controls.Add(Me.wizardControlPage6)
        Me.wizardContainer1.Location = New System.Drawing.Point(0, 70)
        Me.wizardContainer1.Name = "wizardContainer1"
        Me.wizardContainer1.Size = New System.Drawing.Size(552, 279)
        Me.wizardContainer1.TabIndex = 1
        '
        'wizardControlPage1
        '
        Me.wizardControlPage1.BackColor = System.Drawing.Color.Transparent
        Me.wizardControlPage1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(171, Byte), Integer)))
        Me.wizardControlPage1.BackVisible = False
        Me.wizardControlPage1.BorderColor = System.Drawing.Color.Black
        Me.wizardControlPage1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.wizardControlPage1.Controls.Add(Me.label8)
        Me.wizardControlPage1.Controls.Add(Me.linkLabel1)
        Me.wizardControlPage1.Controls.Add(Me.label7)
        Me.wizardControlPage1.Controls.Add(Me.label6)
        Me.wizardControlPage1.Controls.Add(Me.gradientPanel2)
        Me.wizardControlPage1.Controls.Add(Me.label5)
        Me.wizardControlPage1.Controls.Add(Me.pictureBox4)
        Me.wizardControlPage1.Description = "This is the description of the Wizard Page"
        Me.wizardControlPage1.ForeColor = System.Drawing.Color.White
        Me.wizardControlPage1.FullPage = True
        Me.wizardControlPage1.LayoutName = "Card1"
        Me.wizardControlPage1.Location = New System.Drawing.Point(0, 0)
        Me.wizardControlPage1.Name = "wizardControlPage1"
        Me.wizardControlPage1.NextPage = Nothing
        Me.wizardControlPage1.PreviousPage = Nothing
        Me.wizardControlPage1.Size = New System.Drawing.Size(552, 279)
        Me.wizardControlPage1.TabIndex = 0
        Me.wizardControlPage1.Title = "Page Title"
        '
        'label8
        '
        Me.label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label8.BackColor = System.Drawing.Color.Transparent
        Me.label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.White
        Me.label8.Location = New System.Drawing.Point(200, 224)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(352, 16)
        Me.label8.TabIndex = 6
        Me.label8.Text = "Wizard Control is available as part of Essential Tools."
        '
        'linkLabel1
        '
        Me.linkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.linkLabel1.DisabledLinkColor = System.Drawing.Color.Tomato
        Me.linkLabel1.LinkColor = System.Drawing.Color.Red
        Me.linkLabel1.Location = New System.Drawing.Point(272, 248)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(144, 23)
        Me.linkLabel1.TabIndex = 5
        Me.linkLabel1.TabStop = True
        Me.linkLabel1.Text = "http://www.syncfusion.com"
        '
        'label7
        '
        Me.label7.BackColor = System.Drawing.Color.Transparent
        Me.label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.White
        Me.label7.Location = New System.Drawing.Point(208, 312)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(208, 23)
        Me.label7.TabIndex = 4
        Me.label7.Text = "To continue, click Next"
        '
        'label6
        '
        Me.label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(200, 96)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(352, 56)
        Me.label6.TabIndex = 3
        Me.label6.Text = "The Wizard control allows developers to make wizard applications quickly offering" & _
            " easy control over pages and wizard buttons"
        '
        'gradientPanel2
        '
        Me.gradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.gradientPanel2.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.gradientPanel2.BorderColor = System.Drawing.Color.Black
        Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gradientPanel2.Controls.Add(Me.pictureBox3)
        Me.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.gradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.gradientPanel2.Name = "gradientPanel2"
        Me.gradientPanel2.Size = New System.Drawing.Size(184, 279)
        Me.gradientPanel2.TabIndex = 2
        '
        'pictureBox3
        '
        Me.pictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(184, 279)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox3.TabIndex = 0
        Me.pictureBox3.TabStop = False
        '
        'label5
        '
        Me.label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label5.BackColor = System.Drawing.Color.Transparent
        Me.label5.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.LightSalmon
        Me.label5.Location = New System.Drawing.Point(200, 16)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(344, 64)
        Me.label5.TabIndex = 1
        Me.label5.Text = "Welcome to the Wizard demo application"
        '
        'pictureBox4
        '
        Me.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox4.Image = CType(resources.GetObject("pictureBox4.Image"), System.Drawing.Image)
        Me.pictureBox4.Location = New System.Drawing.Point(472, 288)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(56, 48)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox4.TabIndex = 1
        Me.pictureBox4.TabStop = False
        '
        'wizardControlPage3
        '
        Me.wizardControlPage3.BackEnabled = False
        Me.wizardControlPage3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(171, Byte), Integer)))
        Me.wizardControlPage3.BorderColor = System.Drawing.Color.Black
        Me.wizardControlPage3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.wizardControlPage3.Controls.Add(Me.radioButton2)
        Me.wizardControlPage3.Controls.Add(Me.radioButton1)
        Me.wizardControlPage3.Controls.Add(Me.textBox3)
        Me.wizardControlPage3.Controls.Add(Me.label13)
        Me.wizardControlPage3.Controls.Add(Me.numericUpDown1)
        Me.wizardControlPage3.Controls.Add(Me.label12)
        Me.wizardControlPage3.Controls.Add(Me.textBox2)
        Me.wizardControlPage3.Controls.Add(Me.label11)
        Me.wizardControlPage3.Controls.Add(Me.textBox1)
        Me.wizardControlPage3.Controls.Add(Me.label10)
        Me.wizardControlPage3.Controls.Add(Me.label9)
        Me.wizardControlPage3.Description = "This page shows the easy way of collecting informations from the user."
        Me.wizardControlPage3.FullPage = False
        Me.wizardControlPage3.LayoutName = "Card2"
        Me.wizardControlPage3.Location = New System.Drawing.Point(0, 0)
        Me.wizardControlPage3.Name = "wizardControlPage3"
        Me.wizardControlPage3.NextPage = Me.wizardControlPage4
        Me.wizardControlPage3.PreviousPage = Nothing
        Me.wizardControlPage3.Size = New System.Drawing.Size(552, 279)
        Me.wizardControlPage3.TabIndex = 1
        Me.wizardControlPage3.Title = "Wizard Page 1"
        '
        'radioButton2
        '
        Me.radioButton2.BackColor = System.Drawing.Color.Transparent
        Me.radioButton2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioButton2.ForeColor = System.Drawing.Color.White
        Me.radioButton2.Location = New System.Drawing.Point(104, 256)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(184, 24)
        Me.radioButton2.TabIndex = 10
        Me.radioButton2.Text = "Choose second execution path"
        Me.radioButton2.UseVisualStyleBackColor = False
        '
        'radioButton1
        '
        Me.radioButton1.BackColor = System.Drawing.Color.Transparent
        Me.radioButton1.Checked = True
        Me.radioButton1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioButton1.ForeColor = System.Drawing.Color.White
        Me.radioButton1.Location = New System.Drawing.Point(104, 232)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(208, 24)
        Me.radioButton1.TabIndex = 9
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "Choose the first execution path"
        Me.radioButton1.UseVisualStyleBackColor = False
        '
        'textBox3
        '
        Me.textBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.textBox3.Location = New System.Drawing.Point(104, 136)
        Me.textBox3.Multiline = True
        Me.textBox3.Name = "textBox3"
        Me.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBox3.Size = New System.Drawing.Size(344, 88)
        Me.textBox3.TabIndex = 8
        Me.textBox3.Text = "Enter biographical data."
        '
        'label13
        '
        Me.label13.BackColor = System.Drawing.Color.Transparent
        Me.label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.ForeColor = System.Drawing.Color.White
        Me.label13.Location = New System.Drawing.Point(24, 136)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(64, 23)
        Me.label13.TabIndex = 7
        Me.label13.Text = "Biography:"
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numericUpDown1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.numericUpDown1.Location = New System.Drawing.Point(104, 104)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(48, 20)
        Me.numericUpDown1.TabIndex = 6
        Me.numericUpDown1.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'label12
        '
        Me.label12.BackColor = System.Drawing.Color.Transparent
        Me.label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.ForeColor = System.Drawing.Color.White
        Me.label12.Location = New System.Drawing.Point(24, 104)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(32, 23)
        Me.label12.TabIndex = 5
        Me.label12.Text = "Age:"
        '
        'textBox2
        '
        Me.textBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.textBox2.Location = New System.Drawing.Point(104, 72)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(68, 20)
        Me.textBox2.TabIndex = 4
        Me.textBox2.Text = "Doe"
        '
        'label11
        '
        Me.label11.BackColor = System.Drawing.Color.Transparent
        Me.label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.ForeColor = System.Drawing.Color.White
        Me.label11.Location = New System.Drawing.Point(24, 72)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(72, 23)
        Me.label11.TabIndex = 3
        Me.label11.Text = "Last Name :"
        '
        'textBox1
        '
        Me.textBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.textBox1.Location = New System.Drawing.Point(104, 40)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(68, 20)
        Me.textBox1.TabIndex = 2
        Me.textBox1.Text = "John"
        '
        'label10
        '
        Me.label10.BackColor = System.Drawing.Color.Transparent
        Me.label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.Color.White
        Me.label10.Location = New System.Drawing.Point(24, 40)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(64, 23)
        Me.label10.TabIndex = 1
        Me.label10.Text = "First Name:"
        '
        'label9
        '
        Me.label9.BackColor = System.Drawing.Color.Transparent
        Me.label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.White
        Me.label9.Location = New System.Drawing.Point(24, 16)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(176, 23)
        Me.label9.TabIndex = 0
        Me.label9.Text = "Please fill out the fields below:"
        '
        'wizardControlPage4
        '
        Me.wizardControlPage4.BackEnabled = False
        Me.wizardControlPage4.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(171, Byte), Integer)))
        Me.wizardControlPage4.BackVisible = False
        Me.wizardControlPage4.BorderColor = System.Drawing.Color.Black
        Me.wizardControlPage4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.wizardControlPage4.Controls.Add(Me.label15)
        Me.wizardControlPage4.Controls.Add(Me.label14)
        Me.wizardControlPage4.Controls.Add(Me.progressBarEx1)
        Me.wizardControlPage4.Description = "This is the first execution path"
        Me.wizardControlPage4.FullPage = False
        Me.wizardControlPage4.HelpEnabled = False
        Me.wizardControlPage4.HelpVisible = False
        Me.wizardControlPage4.LayoutName = "Card3"
        Me.wizardControlPage4.Location = New System.Drawing.Point(0, 0)
        Me.wizardControlPage4.Name = "wizardControlPage4"
        Me.wizardControlPage4.NextPage = Me.wizardControlPage6
        Me.wizardControlPage4.PreviousPage = Me.wizardControlPage3
        Me.wizardControlPage4.Size = New System.Drawing.Size(552, 279)
        Me.wizardControlPage4.TabIndex = 2
        Me.wizardControlPage4.Title = "First execution path"
        '
        'label15
        '
        Me.label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label15.BackColor = System.Drawing.Color.Transparent
        Me.label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.ForeColor = System.Drawing.Color.White
        Me.label15.Location = New System.Drawing.Point(80, 248)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(352, 16)
        Me.label15.TabIndex = 2
        Me.label15.Text = "The next button will get enabled after the progressbar reaches 100%"
        '
        'label14
        '
        Me.label14.BackColor = System.Drawing.Color.Transparent
        Me.label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.ForeColor = System.Drawing.Color.White
        Me.label14.Location = New System.Drawing.Point(80, 104)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(184, 16)
        Me.label14.TabIndex = 1
        Me.label14.Text = "Processing information"
        '
        'progressBarEx1
        '
        Me.progressBarEx1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progressBarEx1.BackGradientEndColor = System.Drawing.Color.White
        Me.progressBarEx1.BackGradientStartColor = System.Drawing.Color.LightGray
        Me.progressBarEx1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Tube
        Me.progressBarEx1.BackMultipleColors = New System.Drawing.Color() {System.Drawing.Color.Empty}
        Me.progressBarEx1.BackSegments = False
        Me.progressBarEx1.BackTubeEndColor = System.Drawing.Color.White
        Me.progressBarEx1.BackTubeStartColor = System.Drawing.Color.LightGray
        Me.progressBarEx1.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.progressBarEx1.BorderColor = System.Drawing.Color.Black
        Me.progressBarEx1.CustomWaitingRender = False
        Me.progressBarEx1.FontColor = System.Drawing.Color.White
        Me.progressBarEx1.ForegroundImage = Nothing
        Me.progressBarEx1.GradientEndColor = System.Drawing.Color.Lime
        Me.progressBarEx1.GradientStartColor = System.Drawing.Color.Red
        Me.progressBarEx1.Location = New System.Drawing.Point(80, 120)
        Me.progressBarEx1.MultipleColors = New System.Drawing.Color() {System.Drawing.Color.Empty}
        Me.progressBarEx1.Name = "progressBarEx1"
        Me.progressBarEx1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.System
        Me.progressBarEx1.SegmentWidth = 12
        Me.progressBarEx1.Size = New System.Drawing.Size(368, 23)
        Me.progressBarEx1.TabIndex = 0
        Me.progressBarEx1.Text = "progressBarEx1"
        Me.progressBarEx1.ThemesEnabled = True
        Me.progressBarEx1.TubeEndColor = System.Drawing.Color.Black
        Me.progressBarEx1.TubeStartColor = System.Drawing.Color.Red
        Me.progressBarEx1.WaitingGradientWidth = 400
        '
        'wizardControlPage6
        '
        Me.wizardControlPage6.BackEnabled = False
        Me.wizardControlPage6.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(171, Byte), Integer)))
        Me.wizardControlPage6.BackVisible = False
        Me.wizardControlPage6.BorderColor = System.Drawing.Color.Black
        Me.wizardControlPage6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.wizardControlPage6.CancelOverFinish = False
        Me.wizardControlPage6.CancelVisible = False
        Me.wizardControlPage6.Controls.Add(Me.label17)
        Me.wizardControlPage6.Controls.Add(Me.label16)
        Me.wizardControlPage6.Description = "This is the description of the Wizard's final page"
        Me.wizardControlPage6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wizardControlPage6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.wizardControlPage6.FullPage = False
        Me.wizardControlPage6.HelpEnabled = False
        Me.wizardControlPage6.HelpVisible = False
        Me.wizardControlPage6.LayoutName = "Card5"
        Me.wizardControlPage6.Location = New System.Drawing.Point(0, 0)
        Me.wizardControlPage6.Name = "wizardControlPage6"
        Me.wizardControlPage6.NextEnabled = False
        Me.wizardControlPage6.NextPage = Nothing
        Me.wizardControlPage6.NextVisible = False
        Me.wizardControlPage6.PreviousPage = Me.wizardControlPage4
        Me.wizardControlPage6.Size = New System.Drawing.Size(552, 279)
        Me.wizardControlPage6.TabIndex = 4
        Me.wizardControlPage6.Title = "Finish Page "
        '
        'label17
        '
        Me.label17.BackColor = System.Drawing.Color.Transparent
        Me.label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label17.ForeColor = System.Drawing.Color.White
        Me.label17.Location = New System.Drawing.Point(56, 256)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(168, 23)
        Me.label17.TabIndex = 1
        Me.label17.Text = "Click finish to close the wizard."
        '
        'label16
        '
        Me.label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label16.BackColor = System.Drawing.Color.Transparent
        Me.label16.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label16.ForeColor = System.Drawing.Color.White
        Me.label16.Location = New System.Drawing.Point(48, 72)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(392, 48)
        Me.label16.TabIndex = 0
        Me.label16.Text = "Congratulations, you have successfully run our test wizard."
        '
        'wizardControlPage5
        '
        Me.wizardControlPage5.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(171, Byte), Integer)))
        Me.wizardControlPage5.BorderColor = System.Drawing.Color.Black
        Me.wizardControlPage5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.wizardControlPage5.CancelEnabled = False
        Me.wizardControlPage5.CancelVisible = False
        Me.wizardControlPage5.Controls.Add(Me.textBox5)
        Me.wizardControlPage5.Controls.Add(Me.label20)
        Me.wizardControlPage5.Controls.Add(Me.textBox4)
        Me.wizardControlPage5.Controls.Add(Me.label19)
        Me.wizardControlPage5.Controls.Add(Me.dateTimePickerExt1)
        Me.wizardControlPage5.Controls.Add(Me.label18)
        Me.wizardControlPage5.Description = "This is the second execution path"
        Me.wizardControlPage5.FullPage = False
        Me.wizardControlPage5.LayoutName = "Card4"
        Me.wizardControlPage5.Location = New System.Drawing.Point(0, 0)
        Me.wizardControlPage5.Name = "wizardControlPage5"
        Me.wizardControlPage5.NextPage = Nothing
        Me.wizardControlPage5.PreviousPage = Nothing
        Me.wizardControlPage5.Size = New System.Drawing.Size(552, 279)
        Me.wizardControlPage5.TabIndex = 3
        Me.wizardControlPage5.Title = "Second execution path"
        '
        'textBox5
        '
        Me.textBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBox5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.textBox5.Location = New System.Drawing.Point(120, 88)
        Me.textBox5.Multiline = True
        Me.textBox5.Name = "textBox5"
        Me.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBox5.Size = New System.Drawing.Size(200, 168)
        Me.textBox5.TabIndex = 5
        '
        'label20
        '
        Me.label20.BackColor = System.Drawing.Color.Transparent
        Me.label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label20.ForeColor = System.Drawing.Color.White
        Me.label20.Location = New System.Drawing.Point(8, 88)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(100, 23)
        Me.label20.TabIndex = 4
        Me.label20.Text = "Studies and merits"
        '
        'textBox4
        '
        Me.textBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.textBox4.Location = New System.Drawing.Point(120, 56)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(200, 20)
        Me.textBox4.TabIndex = 3
        Me.textBox4.Text = "New York"
        '
        'label19
        '
        Me.label19.BackColor = System.Drawing.Color.Transparent
        Me.label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label19.ForeColor = System.Drawing.Color.White
        Me.label19.Location = New System.Drawing.Point(56, 56)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(48, 16)
        Me.label19.TabIndex = 2
        Me.label19.Text = "Location"
        '
        'dateTimePickerExt1
        '
        Me.dateTimePickerExt1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateTimePickerExt1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer)))
        Me.dateTimePickerExt1.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched
        '
        '
        '
        Me.dateTimePickerExt1.Calendar.AllowMultipleSelection = False
        Me.dateTimePickerExt1.Calendar.BottomHeight = 18
        Me.dateTimePickerExt1.Calendar.Culture = New System.Globalization.CultureInfo("en-US")
        Me.dateTimePickerExt1.Calendar.DaysFont = New System.Drawing.Font("Verdana", 8.0!)
        Me.dateTimePickerExt1.Calendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dateTimePickerExt1.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimePickerExt1.Calendar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dateTimePickerExt1.Calendar.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimePickerExt1.Calendar.Location = New System.Drawing.Point(0, 0)
        Me.dateTimePickerExt1.Calendar.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 999)
        Me.dateTimePickerExt1.Calendar.MinValue = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dateTimePickerExt1.Calendar.Name = "monthCalendar"
        Me.dateTimePickerExt1.Calendar.SelectedDates = New Date(-1) {}
        Me.dateTimePickerExt1.Calendar.Size = New System.Drawing.Size(260, 174)
        Me.dateTimePickerExt1.Calendar.SizeToFit = True
        Me.dateTimePickerExt1.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.[Default]
        Me.dateTimePickerExt1.Calendar.TabIndex = 0
        Me.dateTimePickerExt1.Calendar.WeekFont = New System.Drawing.Font("Verdana", 8.0!)
        Me.dateTimePickerExt1.Calendar.WeekInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.PeachPuff, System.Drawing.Color.AntiqueWhite)
        '
        '
        '
        Me.dateTimePickerExt1.Calendar.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Classic
        Me.dateTimePickerExt1.Calendar.NoneButton.Location = New System.Drawing.Point(188, 0)
        Me.dateTimePickerExt1.Calendar.NoneButton.Size = New System.Drawing.Size(72, 18)
        Me.dateTimePickerExt1.Calendar.NoneButton.Text = "None"
        '
        '
        '
        Me.dateTimePickerExt1.Calendar.TodayButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateTimePickerExt1.Calendar.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Classic
        Me.dateTimePickerExt1.Calendar.TodayButton.Dock = System.Windows.Forms.DockStyle.None
        Me.dateTimePickerExt1.Calendar.TodayButton.Location = New System.Drawing.Point(0, 0)
        Me.dateTimePickerExt1.Calendar.TodayButton.Size = New System.Drawing.Size(90, 18)
        Me.dateTimePickerExt1.Calendar.TodayButton.Text = "Today"
        Me.dateTimePickerExt1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimePickerExt1.CalendarForeColor = System.Drawing.SystemColors.ControlText
        Me.dateTimePickerExt1.Culture = New System.Globalization.CultureInfo("en-US")
        Me.dateTimePickerExt1.DropDownImage = Nothing
        Me.dateTimePickerExt1.FlatDropButton = True
        Me.dateTimePickerExt1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimePickerExt1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.dateTimePickerExt1.Location = New System.Drawing.Point(120, 28)
        Me.dateTimePickerExt1.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 999)
        Me.dateTimePickerExt1.MinValue = New Date(CType(0, Long))
        Me.dateTimePickerExt1.Name = "dateTimePickerExt1"
        Me.dateTimePickerExt1.ShowCheckBox = False
        Me.dateTimePickerExt1.Size = New System.Drawing.Size(200, 20)
        Me.dateTimePickerExt1.TabIndex = 1
        Me.dateTimePickerExt1.Value = New Date(2005, 11, 24, 15, 45, 30, 703)
        '
        'label18
        '
        Me.label18.BackColor = System.Drawing.Color.Transparent
        Me.label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label18.ForeColor = System.Drawing.Color.White
        Me.label18.Location = New System.Drawing.Point(56, 32)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(56, 16)
        Me.label18.TabIndex = 0
        Me.label18.Text = "Birth date"
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.White
        Me.imageList1.Images.SetKeyName(0, "")
        '
        'timer1
        '
        Me.timer1.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(552, 390)
        Me.Controls.Add(Me.wizardControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wizard COntrol Demo "
        Me.panel1.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wizardControlPage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wizardControl1.GridBagLayout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wizardControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.wizardControl1.ResumeLayout(False)
        CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gradientPanel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.wizardContainer1.ResumeLayout(False)
        CType(Me.wizardControlPage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.wizardControlPage1.ResumeLayout(False)
        CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gradientPanel2.ResumeLayout(False)
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wizardControlPage3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.wizardControlPage3.ResumeLayout(False)
        Me.wizardControlPage3.PerformLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wizardControlPage4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.wizardControlPage4.ResumeLayout(False)
        CType(Me.progressBarEx1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wizardControlPage6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.wizardControlPage6.ResumeLayout(False)
        CType(Me.wizardControlPage5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.wizardControlPage5.ResumeLayout(False)
        Me.wizardControlPage5.PerformLayout()
        CType(Me.dateTimePickerExt1.Calendar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateTimePickerExt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>

    <STAThread()> _
    Shared Sub Main()
        Application.Run(New Form1())
    End Sub 'Main

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.wizardControl1.GridBagLayout.GetConstraintsRef(Me.wizardControl1.BackButton).Insets = New Insets(0, 0, 5, 0)
        Me.wizardControl1.GridBagLayout.GetConstraintsRef(Me.wizardControl1.CancelButton).Insets = New Insets(5, 0, 5, 0)
        Me.wizardControl1.GridBagLayout.GetConstraintsRef(Me.wizardControl1.FinishButton).Insets = New Insets(0, 5, 0, 5)

        Dim ctrl As Control
        For Each ctrl In Me.wizardControl1.Controls
            If TypeOf ctrl Is ButtonAdv Then
                Dim btn As ButtonAdv = CType(ctrl, ButtonAdv)
                btn.FlatStyle = FlatStyle.Standard
                btn.UseVisualStyle = True
                btn.Appearance = ButtonAppearance.Office2007
                btn.KeepFocusRectangle = False
            End If
        Next
    End Sub

    Private Sub wizardControlPage3_NextClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wizardControlPage3.NextClick
        Dim [text] As String = " First "
        If Me.radioButton2.Checked Then
            [text] = " Second "
        End If
        MessageBoxAdv.Show(Me, "Hello " + Me.textBox1.Text + " " + Me.textBox2.Text + "! You have chosen the" + [text] + "execution path", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If Me.radioButton2.Checked Then
            Me.wizardControlPage3.NextPage = wizardControlPage5
        Else
            wizardControlPage3.NextPage = wizardControlPage4
        End If
    End Sub 'wizardControlPage3_NextClick

    Private Sub wizardControl1_CancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _cancelButton.Click
        Me.progressBarEx1.Value = Me.progressBarEx1.Value
        Me.timer1.Stop()
        If MessageBoxAdv.Show(Me, "Are you sure you want to cancel the wizard?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Close()
        Else
            Me.timer1.Start()
        End If
    End Sub 'wizardControl1_CancelButton_Click

    Private Sub wizardControlPage4_PageLoad(ByVal sender As Object, ByVal e As System.EventArgs) Handles wizardControlPage4.PageLoad
        Me.wizardControlPage4.NextEnabled = False
        Me.progressBarEx1.Value = 0
        Me.timer1.Enabled = True
    End Sub 'wizardControlPage4_PageLoad

    Private Sub wizardControlPage1_PageLoad(ByVal sender As Object, ByVal e As System.EventArgs) Handles wizardControlPage1.PageLoad
        Me.wizardControl1.NextButton.TabIndex = 0
    End Sub 'wizardControlPage1 PageLoad

    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer1.Tick
        progressBarEx1.Value += 1
        If progressBarEx1.Value = 100 Then
            Me.wizardControlPage4.NextEnabled = True
            Me.timer1.Enabled = False
        End If
    End Sub 'timer1_Tick

    Private Sub wizardControlPage6_FinishClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wizardControlPage6.FinishClick
        Close()
    End Sub 'wizardControlPage6_FinishClick

    Private Sub wizardControlPage4_BackClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles wizardControlPage4.BackClick
        Me.timer1.Stop()
    End Sub

End Class 'Form1 