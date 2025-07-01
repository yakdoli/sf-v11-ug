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
Imports Syncfusion.Windows.Forms.Tools


Namespace WizardControlTest
    '/ <summary>
    '/ Summary description for Form1.
    '/ </summary>
    
    Public Class Form1
        Inherits System.Windows.Forms.Form
        Private WithEvents wizardControl1 As Syncfusion.Windows.Forms.Tools.WizardControl
        Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
        Private wizardContainer1 As Syncfusion.Windows.Forms.Tools.WizardContainer
        Private pictureBox1 As System.Windows.Forms.PictureBox
        Private label1 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private textBox1 As System.Windows.Forms.TextBox
        Private textBox2 As System.Windows.Forms.TextBox
        Private label4 As System.Windows.Forms.Label
        Private textBox3 As System.Windows.Forms.TextBox
        Private label5 As System.Windows.Forms.Label
        Private progressBar1 As System.Windows.Forms.ProgressBar
        Private label6 As System.Windows.Forms.Label
        Private radioButton1 As System.Windows.Forms.RadioButton
        Private radioButton2 As System.Windows.Forms.RadioButton
        Private WithEvents timer1 As System.Windows.Forms.Timer
        Private frontPage As Syncfusion.Windows.Forms.Tools.WizardControlPage
        Private WithEvents provideInfoPage As Syncfusion.Windows.Forms.Tools.WizardControlPage
        Private WithEvents uploadPage As Syncfusion.Windows.Forms.Tools.WizardControlPage
        Private label8 As System.Windows.Forms.Label
        Private numericUpDown1 As System.Windows.Forms.NumericUpDown
        Private label9 As System.Windows.Forms.Label
        Private label10 As System.Windows.Forms.Label
        Private uploadLaterPage As Syncfusion.Windows.Forms.Tools.WizardControlPage
        Private finishPage As Syncfusion.Windows.Forms.Tools.WizardControlPage
        Private components As System.ComponentModel.IContainer
        
        
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            Me.wizardControl1.GridBagLayout.GetConstraintsRef(Me.wizardControl1.NextButton).Insets = New Insets(5, 0, 0, 0)
            Me.wizardControl1.GridBagLayout.GetConstraintsRef(Me.wizardControl1.FinishButton).Insets = New Insets(5, 0, 5, 0)
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
        Friend WithEvents label11 As System.Windows.Forms.Label
        Friend WithEvents label7 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents label13 As System.Windows.Forms.Label
        Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
            Me.wizardControl1 = New Syncfusion.Windows.Forms.Tools.WizardControl()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.wizardContainer1 = New Syncfusion.Windows.Forms.Tools.WizardContainer()
            Me.frontPage = New Syncfusion.Windows.Forms.Tools.WizardControlPage(Me.components)
            Me.Label12 = New System.Windows.Forms.Label()
            Me.label11 = New System.Windows.Forms.Label()
            Me.label7 = New System.Windows.Forms.Label()
            Me.provideInfoPage = New Syncfusion.Windows.Forms.Tools.WizardControlPage(Me.components)
            Me.radioButton2 = New System.Windows.Forms.RadioButton()
            Me.radioButton1 = New System.Windows.Forms.RadioButton()
            Me.textBox3 = New System.Windows.Forms.TextBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.textBox2 = New System.Windows.Forms.TextBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.uploadPage = New Syncfusion.Windows.Forms.Tools.WizardControlPage(Me.components)
            Me.label6 = New System.Windows.Forms.Label()
            Me.progressBar1 = New System.Windows.Forms.ProgressBar()
            Me.finishPage = New Syncfusion.Windows.Forms.Tools.WizardControlPage(Me.components)
            Me.label10 = New System.Windows.Forms.Label()
            Me.uploadLaterPage = New Syncfusion.Windows.Forms.Tools.WizardControlPage(Me.components)
            Me.label9 = New System.Windows.Forms.Label()
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
            Me.label8 = New System.Windows.Forms.Label()
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.label13 = New System.Windows.Forms.Label()
            Me.PictureBox2 = New System.Windows.Forms.PictureBox()
            CType(Me.wizardControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.wizardControl1.GridBagLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.wizardControl1.SuspendLayout()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            Me.wizardContainer1.SuspendLayout()
            CType(Me.frontPage, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.frontPage.SuspendLayout()
            CType(Me.provideInfoPage, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.provideInfoPage.SuspendLayout()
            CType(Me.uploadPage, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.uploadPage.SuspendLayout()
            CType(Me.finishPage, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.finishPage.SuspendLayout()
            CType(Me.uploadLaterPage, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.uploadLaterPage.SuspendLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'wizardControl1
            '
            '
            'wizardControl1.BackButton
            '
            Me.wizardControl1.BackButton.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
            Me.wizardControl1.BackButton.Enabled = False
            Me.wizardControl1.BackButton.Location = New System.Drawing.Point(197, 386)
            Me.wizardControl1.BackButton.Name = "backButton"
            Me.wizardControl1.BackButton.Text = "<< Back"
            Me.wizardControl1.BackButton.Visible = False
            Me.wizardControl1.Banner = Me.pictureBox1
            Me.wizardControl1.BannerPanel = Me.gradientPanel1
            '
            'wizardControl1.CancelButton
            '
            Me.wizardControl1.CancelButton.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
            Me.wizardControl1.CancelButton.Location = New System.Drawing.Point(432, 386)
            Me.wizardControl1.CancelButton.Name = "cancelButton"
            Me.wizardControl1.CancelButton.Text = "Cancel"
            Me.wizardControl1.CancelButton.Visible = False
            Me.wizardControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.wizardContainer1, Me.wizardControl1.HelpButton, Me.wizardControl1.CancelButton, Me.wizardControl1.FinishButton, Me.wizardControl1.BackButton, Me.wizardControl1.NextButton, Me.gradientPanel1})
            Me.wizardControl1.Description = Me.label2
            Me.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill
            '
            'wizardControl1.FinishButton
            '
            Me.wizardControl1.FinishButton.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
            Me.wizardControl1.FinishButton.Location = New System.Drawing.Point(432, 386)
            Me.wizardControl1.FinishButton.Name = "finishButton"
            Me.wizardControl1.FinishButton.Text = "Finish"
            '
            'wizardControl1.GridBagLayout
            '
            Me.wizardControl1.GridBagLayout.ContainerControl = Me.wizardControl1
            '
            'wizardControl1.HelpButton
            '
            Me.wizardControl1.HelpButton.Enabled = False
            Me.wizardControl1.HelpButton.Location = New System.Drawing.Point(432, 386)
            Me.wizardControl1.HelpButton.Name = "helpButton"
            Me.wizardControl1.HelpButton.Text = "Help"
            Me.wizardControl1.HelpButton.Visible = False
            Me.wizardControl1.Name = "wizardControl1"
            '
            'wizardControl1.NextButton
            '
            Me.wizardControl1.NextButton.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
            Me.wizardControl1.NextButton.Enabled = False
            Me.wizardControl1.NextButton.Location = New System.Drawing.Point(352, 386)
            Me.wizardControl1.NextButton.Name = "nextButton"
            Me.wizardControl1.NextButton.Text = "Next >>"
            Me.wizardControl1.SelectedWizardPage = Me.finishPage
            Me.wizardControl1.Size = New System.Drawing.Size(512, 414)
            Me.wizardControl1.TabIndex = 0
            Me.wizardControl1.Title = Me.label1
            Me.wizardControl1.WizardPageContainer = Me.wizardContainer1
            Me.wizardControl1.WizardPages = New Syncfusion.Windows.Forms.Tools.WizardControlPage() {Me.frontPage, Me.provideInfoPage, Me.uploadPage, Me.uploadLaterPage, Me.finishPage}
            '
            'pictureBox1
            '
            Me.pictureBox1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Bitmap)
            Me.pictureBox1.Location = New System.Drawing.Point(438, 4)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(64, 61)
            Me.pictureBox1.TabIndex = 0
            Me.pictureBox1.TabStop = False
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BackColor = System.Drawing.Color.White
            Me.gradientPanel1.BorderColor = System.Drawing.Color.Black
            Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.gradientPanel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.pictureBox1, Me.label1, Me.label2})
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(512, 70)
            Me.gradientPanel1.TabIndex = 11
            '
            'label1
            '
            Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(10, 10)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(80, 15)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Page 3 of 3"
            '
            'label2
            '
            Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.label2.Location = New System.Drawing.Point(20, 30)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(123, 13)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Registration Completed"
            '
            'wizardContainer1
            '
            Me.wizardContainer1.BackColor = System.Drawing.SystemColors.ActiveBorder
            Me.wizardContainer1.Controls.AddRange(New System.Windows.Forms.Control() {Me.frontPage, Me.provideInfoPage, Me.uploadPage, Me.uploadLaterPage, Me.finishPage})
            Me.wizardContainer1.Location = New System.Drawing.Point(0, 70)
            Me.wizardContainer1.Name = "wizardContainer1"
            Me.wizardContainer1.Size = New System.Drawing.Size(512, 303)
            Me.wizardContainer1.TabIndex = 1
            '
            'frontPage
            '
            Me.frontPage.BackColor = System.Drawing.Color.White
            Me.frontPage.BackVisible = False
            Me.frontPage.BorderColor = System.Drawing.Color.Black
            Me.frontPage.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.frontPage.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label12, Me.PictureBox2, Me.label13, Me.label11, Me.label7})
            Me.frontPage.Description = "This is the description of the Wizard Page"
            Me.frontPage.FullPage = True
            Me.frontPage.LayoutName = "Card1"
            Me.frontPage.Name = "frontPage"
            Me.frontPage.NextPage = Me.provideInfoPage
            Me.frontPage.PreviousPage = Nothing
            Me.frontPage.Size = New System.Drawing.Size(512, 303)
            Me.frontPage.TabIndex = 0
            Me.frontPage.Title = "Page Title"
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.Navy
            Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Bitmap)
            Me.Label12.Location = New System.Drawing.Point(56, 64)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(56, 48)
            Me.Label12.TabIndex = 4
            '
            'label11
            '
            Me.label11.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label11.ForeColor = System.Drawing.Color.FromArgb(CType(242, Byte), CType(151, Byte), CType(50, Byte))
            Me.label11.Location = New System.Drawing.Point(184, 16)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(296, 72)
            Me.label11.TabIndex = 3
            Me.label11.Text = "Welcome to the registration wizard"
            '
            'label7
            '
            Me.label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.ForeColor = System.Drawing.Color.Navy
            Me.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label7.Location = New System.Drawing.Point(184, 160)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(272, 56)
            Me.label7.TabIndex = 2
            Me.label7.Text = "This wizard will run you through the registration procedure."
            Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'provideInfoPage
            '
            Me.provideInfoPage.BackColor = System.Drawing.Color.Transparent
            Me.provideInfoPage.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Window)
            Me.provideInfoPage.BackVisible = False
            Me.provideInfoPage.BorderColor = System.Drawing.Color.Black
            Me.provideInfoPage.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.provideInfoPage.Controls.AddRange(New System.Windows.Forms.Control() {Me.radioButton2, Me.radioButton1, Me.textBox3, Me.label5, Me.textBox2, Me.label4, Me.textBox1, Me.label3})
            Me.provideInfoPage.Description = "Provide personal information:"
            Me.provideInfoPage.FullPage = False
            Me.provideInfoPage.LayoutName = "Card2"
            Me.provideInfoPage.Name = "provideInfoPage"
            Me.provideInfoPage.NextPage = Me.uploadLaterPage
            Me.provideInfoPage.PreviousPage = Me.frontPage
            Me.provideInfoPage.Size = New System.Drawing.Size(512, 303)
            Me.provideInfoPage.TabIndex = 1
            Me.provideInfoPage.Title = "Page 1 of 3"
            '
            'radioButton2
            '
            Me.radioButton2.BackColor = System.Drawing.Color.Transparent
            Me.radioButton2.Location = New System.Drawing.Point(184, 232)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.TabIndex = 5
            Me.radioButton2.Text = "Upload Later"
            '
            'radioButton1
            '
            Me.radioButton1.BackColor = System.Drawing.Color.Transparent
            Me.radioButton1.Checked = True
            Me.radioButton1.Location = New System.Drawing.Point(184, 200)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(160, 24)
            Me.radioButton1.TabIndex = 4
            Me.radioButton1.TabStop = True
            Me.radioButton1.Text = "Upload registration Info."
            '
            'textBox3
            '
            Me.textBox3.Location = New System.Drawing.Point(184, 80)
            Me.textBox3.Name = "textBox3"
            Me.textBox3.Size = New System.Drawing.Size(168, 20)
            Me.textBox3.TabIndex = 2
            Me.textBox3.Text = ""
            '
            'label5
            '
            Me.label5.BackColor = System.Drawing.Color.Transparent
            Me.label5.Location = New System.Drawing.Point(56, 80)
            Me.label5.Name = "label5"
            Me.label5.TabIndex = 4
            Me.label5.Text = "Address"
            '
            'textBox2
            '
            Me.textBox2.Location = New System.Drawing.Point(184, 120)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(168, 20)
            Me.textBox2.TabIndex = 3
            Me.textBox2.Text = ""
            '
            'label4
            '
            Me.label4.BackColor = System.Drawing.Color.Transparent
            Me.label4.Location = New System.Drawing.Point(56, 120)
            Me.label4.Name = "label4"
            Me.label4.TabIndex = 2
            Me.label4.Text = "Telephone"
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(184, 40)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(168, 20)
            Me.textBox1.TabIndex = 1
            Me.textBox1.Text = ""
            '
            'label3
            '
            Me.label3.BackColor = System.Drawing.Color.Transparent
            Me.label3.Location = New System.Drawing.Point(56, 40)
            Me.label3.Name = "label3"
            Me.label3.TabIndex = 0
            Me.label3.Text = "Name"
            '
            'uploadPage
            '
            Me.uploadPage.BackEnabled = False
            Me.uploadPage.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Window)
            Me.uploadPage.BackVisible = False
            Me.uploadPage.BorderColor = System.Drawing.Color.Black
            Me.uploadPage.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.uploadPage.Controls.AddRange(New System.Windows.Forms.Control() {Me.label6, Me.progressBar1})
            Me.uploadPage.Description = "This page shows the progress of operation:"
            Me.uploadPage.FullPage = False
            Me.uploadPage.HelpEnabled = False
            Me.uploadPage.HelpVisible = False
            Me.uploadPage.LayoutName = "Card3"
            Me.uploadPage.Name = "uploadPage"
            Me.uploadPage.NextPage = Me.finishPage
            Me.uploadPage.PreviousPage = Me.provideInfoPage
            Me.uploadPage.Size = New System.Drawing.Size(512, 303)
            Me.uploadPage.TabIndex = 2
            Me.uploadPage.Title = "Page 2 of 3"
            '
            'label6
            '
            Me.label6.BackColor = System.Drawing.Color.Transparent
            Me.label6.Location = New System.Drawing.Point(88, 88)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(192, 23)
            Me.label6.TabIndex = 1
            Me.label6.Text = "Registration Upload Progress Info:"
            '
            'progressBar1
            '
            Me.progressBar1.Location = New System.Drawing.Point(88, 120)
            Me.progressBar1.Name = "progressBar1"
            Me.progressBar1.Size = New System.Drawing.Size(312, 23)
            Me.progressBar1.TabIndex = 0
            '
            'finishPage
            '
            Me.finishPage.BackEnabled = False
            Me.finishPage.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Window)
            Me.finishPage.BackVisible = False
            Me.finishPage.BorderColor = System.Drawing.Color.Black
            Me.finishPage.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.finishPage.CancelOverFinish = False
            Me.finishPage.CancelVisible = False
            Me.finishPage.Controls.AddRange(New System.Windows.Forms.Control() {Me.label10})
            Me.finishPage.Description = "Registration Completed"
            Me.finishPage.FullPage = False
            Me.finishPage.HelpEnabled = False
            Me.finishPage.HelpVisible = False
            Me.finishPage.LayoutName = "Card5"
            Me.finishPage.Name = "finishPage"
            Me.finishPage.NextEnabled = False
            Me.finishPage.NextPage = Nothing
            Me.finishPage.PreviousPage = Me.uploadLaterPage
            Me.finishPage.Size = New System.Drawing.Size(512, 303)
            Me.finishPage.TabIndex = 4
            Me.finishPage.Title = "Page 3 of 3"
            '
            'label10
            '
            Me.label10.BackColor = System.Drawing.Color.Transparent
            Me.label10.Location = New System.Drawing.Point(16, 264)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(320, 23)
            Me.label10.TabIndex = 0
            Me.label10.Text = "Congrats! You have now successfully completed registration."
            '
            'uploadLaterPage
            '
            Me.uploadLaterPage.BackEnabled = False
            Me.uploadLaterPage.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Window)
            Me.uploadLaterPage.BackVisible = False
            Me.uploadLaterPage.BorderColor = System.Drawing.Color.Black
            Me.uploadLaterPage.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.uploadLaterPage.Controls.AddRange(New System.Windows.Forms.Control() {Me.label9, Me.numericUpDown1, Me.label8})
            Me.uploadLaterPage.Description = "Delayed Registration Procedure:"
            Me.uploadLaterPage.FullPage = False
            Me.uploadLaterPage.HelpEnabled = False
            Me.uploadLaterPage.HelpVisible = False
            Me.uploadLaterPage.LayoutName = "Card4"
            Me.uploadLaterPage.Name = "uploadLaterPage"
            Me.uploadLaterPage.NextPage = Me.finishPage
            Me.uploadLaterPage.PreviousPage = Me.provideInfoPage
            Me.uploadLaterPage.Size = New System.Drawing.Size(512, 303)
            Me.uploadLaterPage.TabIndex = 3
            Me.uploadLaterPage.Title = "Page 2 of 3"
            '
            'label9
            '
            Me.label9.BackColor = System.Drawing.Color.Transparent
            Me.label9.Location = New System.Drawing.Point(200, 56)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(32, 23)
            Me.label9.TabIndex = 2
            Me.label9.Text = "days."
            '
            'numericUpDown1
            '
            Me.numericUpDown1.Location = New System.Drawing.Point(144, 56)
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.Size = New System.Drawing.Size(48, 20)
            Me.numericUpDown1.TabIndex = 1
            '
            'label8
            '
            Me.label8.BackColor = System.Drawing.Color.Transparent
            Me.label8.Location = New System.Drawing.Point(64, 56)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(72, 23)
            Me.label8.TabIndex = 0
            Me.label8.Text = "Register after "
            '
            'timer1
            '
            '
            'label13
            '
            Me.label13.ForeColor = System.Drawing.Color.Navy
            Me.label13.Location = New System.Drawing.Point(192, 328)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(136, 24)
            Me.label13.TabIndex = 5
            Me.label13.Text = "Click Next to proceed"
            '
            'PictureBox2
            '
            Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Bitmap)
            Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(160, 303)
            Me.PictureBox2.TabIndex = 6
            Me.PictureBox2.TabStop = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(512, 414)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.wizardControl1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.Text = "Wizard Control Tutorial"
            CType(Me.wizardControl1.GridBagLayout, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.wizardControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.wizardControl1.ResumeLayout(False)
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            Me.wizardContainer1.ResumeLayout(False)
            CType(Me.frontPage, System.ComponentModel.ISupportInitialize).EndInit()
            Me.frontPage.ResumeLayout(False)
            CType(Me.provideInfoPage, System.ComponentModel.ISupportInitialize).EndInit()
            Me.provideInfoPage.ResumeLayout(False)
            CType(Me.uploadPage, System.ComponentModel.ISupportInitialize).EndInit()
            Me.uploadPage.ResumeLayout(False)
            CType(Me.finishPage, System.ComponentModel.ISupportInitialize).EndInit()
            Me.finishPage.ResumeLayout(False)
            CType(Me.uploadLaterPage, System.ComponentModel.ISupportInitialize).EndInit()
            Me.uploadLaterPage.ResumeLayout(False)
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
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

#Region "WIZARD_CONTROL_EVENTS"


        Private Sub wizardControl1_Finish(ByVal sender As Object, ByVal e As System.EventArgs) Handles wizardControl1.Finish
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End Sub 'wizardControl1_Finish


        Private Sub wizardControl1_Cancel(ByVal sender As Object, ByVal e As System.EventArgs) Handles wizardControl1.Cancel
            Me.progressBar1.Value = Me.progressBar1.Value
            Me.timer1.Stop()
            If MessageBox.Show("Are you sure you want to cancel the wizard?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Close()
            Else
                Me.timer1.Start()
                If Me.progressBar1.Value = 100 Then
                    Me.timer1.Stop()
                End If
            End If

            

        End Sub 'wizardControl1_Cancel


        Private Sub wizardControl1_Help(ByVal sender As Object, ByVal e As System.EventArgs) Handles wizardControl1.Help
            MessageBox.Show("Help not implemented")
        End Sub 'wizardControl1_Help

#End Region

#Region "PROVIDE_INFO_PAGE_EVENTS"
        '
        'ToDo: Error processing original source shown below
        '
        '  #region PROVIDE_INFO_PAGE_EVENTS
        '---^--- Syntax error: 'identifier' expected
        Private Sub provideInfoPage_ValidatePage(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles provideInfoPage.ValidatePage
            If Me.radioButton1.Checked Then
                If Me.textBox1.Text.Trim() = String.Empty Then
                    MessageBox.Show("Name cannot be empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    e.Cancel = True
                    Me.textBox1.Focus()
                End If
            End If
        End Sub 'provideInfoPage_ValidatePage


        Private Sub provideInfoPage_NextClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles provideInfoPage.NextClick
            ' Set up the execution path based on user preference:
            If Me.radioButton1.Checked Then
                Me.provideInfoPage.NextPage = Me.uploadPage
                Me.finishPage.PreviousPage = Me.uploadPage
            Else
                Me.provideInfoPage.NextPage = Me.uploadLaterPage
                Me.finishPage.PreviousPage = Me.uploadLaterPage
            End If
        End Sub 'provideInfoPage_NextClick
#End Region

#Region "UPLOAD_PAGE_EVENTS"

        Private Sub uploadPage_PageLoad(ByVal sender As Object, ByVal e As System.EventArgs) Handles uploadPage.PageLoad
            ' Start a timer to simulate registration info upload:
            Me.progressBar1.Value = 0
            Me.timer1.Enabled = True

            ' To prevent the user from clicking the next button until the upload is done, disable the next button:
            Me.uploadPage.NextEnabled = False
        End Sub 'uploadPage_PageLoad


        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer1.Tick
            Me.progressBar1.Value += 5
            If Me.progressBar1.Value = 100 Then
                Me.timer1.Enabled = False
                Me.uploadPage.NextEnabled = True
            End If
        End Sub 'timer1_Tick
#End Region

        Private Sub uploadPage_BackClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles uploadPage.BackClick
            Me.textBox1.Text = ""
        End Sub

        Private Sub wizardControl1_Next(ByVal sender As Object, ByVal e As System.EventArgs) Handles wizardControl1.Next
            If Me.wizardControl1.SelectedPage Is Me.provideInfoPage Then
                Me.textBox1.Focus()
            End If
        End Sub

        Private Sub wizardControl1_Back(ByVal sender As Object, ByVal e As System.EventArgs) Handles wizardControl1.Back
            If Me.wizardControl1.SelectedPage Is Me.provideInfoPage Then
                Me.textBox1.Focus()
            End If
        End Sub
    End Class 'Form1
End Namespace 'WizardControlTest