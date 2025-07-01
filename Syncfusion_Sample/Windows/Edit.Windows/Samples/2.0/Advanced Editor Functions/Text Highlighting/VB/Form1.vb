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
Imports System.IO
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing.Drawing2D
Imports Syncfusion.Windows.Forms.Edit.Interfaces


'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits System.Windows.Forms.Form
    Private panel1 As System.Windows.Forms.Panel
    Private comboBox1 As System.Windows.Forms.ComboBox
    Private label1 As System.Windows.Forms.Label
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private radioButton3 As System.Windows.Forms.RadioButton
    Private radioButton2 As System.Windows.Forms.RadioButton
    Private radioButton1 As System.Windows.Forms.RadioButton
    Private groupBox2 As System.Windows.Forms.GroupBox
    Private radioButton4 As System.Windows.Forms.RadioButton
    Private radioButton5 As System.Windows.Forms.RadioButton
    Private radioButton6 As System.Windows.Forms.RadioButton
    Private radioButton7 As System.Windows.Forms.RadioButton
    Private radioButton8 As System.Windows.Forms.RadioButton
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private mainMenu1 As System.Windows.Forms.MainMenu
    Private menuItem1 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
    Private menuItem4 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
    Private menuItem7 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem8 As System.Windows.Forms.MenuItem
    Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
    Private WithEvents menuItem9 As System.Windows.Forms.MenuItem
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    Private filePath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\Form1.vb"
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        
        Me.editControl1.LoadFile(filePath)
        
        Me.radioButton1.BackColor = ColorTranslator.FromHtml("#85BF75")
        Me.radioButton2.BackColor = ColorTranslator.FromHtml("#B4E7F2")
        Me.radioButton3.BackColor = ColorTranslator.FromHtml("#FFBF34")
    End Sub 'New
    
    
    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As New System.Resources.ResourceManager(GetType(Form1))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.radioButton8 = New System.Windows.Forms.RadioButton()
        Me.radioButton4 = New System.Windows.Forms.RadioButton()
        Me.radioButton5 = New System.Windows.Forms.RadioButton()
        Me.radioButton6 = New System.Windows.Forms.RadioButton()
        Me.label1 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioButton3 = New System.Windows.Forms.RadioButton()
        Me.radioButton2 = New System.Windows.Forms.RadioButton()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.radioButton7 = New System.Windows.Forms.RadioButton()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu()
        Me.menuItem1 = New System.Windows.Forms.MenuItem()
        Me.menuItem2 = New System.Windows.Forms.MenuItem()
        Me.menuItem3 = New System.Windows.Forms.MenuItem()
        Me.menuItem4 = New System.Windows.Forms.MenuItem()
        Me.menuItem5 = New System.Windows.Forms.MenuItem()
        Me.menuItem6 = New System.Windows.Forms.MenuItem()
        Me.menuItem7 = New System.Windows.Forms.MenuItem()
        Me.menuItem8 = New System.Windows.Forms.MenuItem()
        Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
        Me.menuItem9 = New System.Windows.Forms.MenuItem()
        Me.panel1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.Color.Beige
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.button2, Me.button1, Me.groupBox2, Me.label1, Me.comboBox1, Me.groupBox1})
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(168, 445)
        Me.panel1.TabIndex = 1
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button2.Location = New System.Drawing.Point(16, 400)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(136, 23)
        Me.button2.TabIndex = 6
        Me.button2.Text = "Highlight Selection"
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.Location = New System.Drawing.Point(16, 360)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(136, 23)
        Me.button1.TabIndex = 4
        Me.button1.Text = "Highlight Line"
        ' 
        ' groupBox2
        ' 
        Me.groupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.radioButton8, Me.radioButton4, Me.radioButton5, Me.radioButton6})
        Me.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.groupBox2.Location = New System.Drawing.Point(16, 216)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(136, 128)
        Me.groupBox2.TabIndex = 3
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Border"
        ' 
        ' radioButton8
        ' 
        Me.radioButton8.Checked = True
        Me.radioButton8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.radioButton8.Location = New System.Drawing.Point(16, 96)
        Me.radioButton8.Name = "radioButton8"
        Me.radioButton8.TabIndex = 5
        Me.radioButton8.TabStop = True
        Me.radioButton8.Text = "None"
        ' 
        ' radioButton4
        ' 
        Me.radioButton4.BackColor = System.Drawing.Color.Chartreuse
        Me.radioButton4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.radioButton4.Location = New System.Drawing.Point(16, 72)
        Me.radioButton4.Name = "radioButton4"
        Me.radioButton4.TabIndex = 2
        Me.radioButton4.Text = "Chartreuse"
        ' 
        ' radioButton5
        ' 
        Me.radioButton5.BackColor = System.Drawing.Color.Crimson
        Me.radioButton5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.radioButton5.Location = New System.Drawing.Point(16, 48)
        Me.radioButton5.Name = "radioButton5"
        Me.radioButton5.TabIndex = 1
        Me.radioButton5.Text = "Crimson"
        ' 
        ' radioButton6
        ' 
        Me.radioButton6.BackColor = System.Drawing.Color.Magenta
        Me.radioButton6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.radioButton6.Location = New System.Drawing.Point(16, 24)
        Me.radioButton6.Name = "radioButton6"
        Me.radioButton6.TabIndex = 0
        Me.radioButton6.Text = "Magenta"
        ' 
        ' label1
        ' 
        Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.label1.Location = New System.Drawing.Point(16, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(100, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "HatchStyle:"
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Location = New System.Drawing.Point(10, 24)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(155, 21)
        Me.comboBox1.TabIndex = 1
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.radioButton3, Me.radioButton2, Me.radioButton1, Me.radioButton7})
        Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.groupBox1.Location = New System.Drawing.Point(16, 72)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(136, 128)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Background"
        ' 
        ' radioButton3
        ' 
        Me.radioButton3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.radioButton3.Location = New System.Drawing.Point(16, 72)
        Me.radioButton3.Name = "radioButton3"
        Me.radioButton3.TabIndex = 2
        Me.radioButton3.Text = "Orange"
        ' 
        ' radioButton2
        ' 
        Me.radioButton2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.radioButton2.Location = New System.Drawing.Point(16, 48)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.TabIndex = 1
        Me.radioButton2.Text = "Dull Aqua"
        ' 
        ' radioButton1
        ' 
        Me.radioButton1.Checked = True
        Me.radioButton1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.radioButton1.Location = New System.Drawing.Point(16, 24)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.TabIndex = 0
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "Light Olive"
        ' 
        ' radioButton7
        ' 
        Me.radioButton7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.radioButton7.Location = New System.Drawing.Point(16, 96)
        Me.radioButton7.Name = "radioButton7"
        Me.radioButton7.TabIndex = 4
        Me.radioButton7.Text = "None"
        ' 
        ' mainMenu1
        ' 
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1})
        ' 
        ' menuItem1
        ' 
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem8, Me.menuItem9})
        Me.menuItem1.Text = "File"
        ' 
        ' menuItem2
        ' 
        Me.menuItem2.Index = 0
        Me.menuItem2.Text = "New"
        ' 
        ' menuItem3
        ' 
        Me.menuItem3.Index = 1
        Me.menuItem3.Text = "Open"
        ' 
        ' menuItem4
        ' 
        Me.menuItem4.Index = 2
        Me.menuItem4.Text = "-"
        ' 
        ' menuItem5
        ' 
        Me.menuItem5.Index = 3
        Me.menuItem5.Text = "Save"
        ' 
        ' menuItem6
        ' 
        Me.menuItem6.Index = 4
        Me.menuItem6.Text = "SaveAs"
        ' 
        ' menuItem7
        ' 
        Me.menuItem7.Index = 5
        Me.menuItem7.Text = "-"
        ' 
        ' menuItem8
        ' 
        Me.menuItem8.Index = 6
        Me.menuItem8.Text = "Close"
        ' 
        ' editControl1
        ' 
        Me.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart
        Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editControl1.IndentBlockHighlightingColor = System.Drawing.Color.Gray
        Me.editControl1.Location = New System.Drawing.Point(168, 0)
        Me.editControl1.Name = "editControl1"
		Me.editControl1.SaveOnClose = False
        Me.editControl1.ShowHorizontalSplitters = False
        Me.editControl1.ShowIndicatorMargin = False
        Me.editControl1.ShowSelectionMargin = False
        Me.editControl1.ShowVerticalSplitters = False
        Me.editControl1.Size = New System.Drawing.Size(374, 445)
        Me.editControl1.StatusBarSettings.CoordsPanel.Width = 148
        Me.editControl1.StatusBarSettings.EncodingPanel.MinWidth = 0
        Me.editControl1.StatusBarSettings.EncodingPanel.Width = 165
        Me.editControl1.StatusBarSettings.InsertPanel.Width = 33
        Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
        Me.editControl1.StatusBarSettings.StatusPanel.Width = 70
        Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.editControl1.StatusBarSettings.TextPanel.Width = 96
        Me.editControl1.TabIndex = 3
        Me.editControl1.Text = ""
        Me.editControl1.TransferFocusOnTab = True
        ' 
        ' menuItem9
        ' 
        Me.menuItem9.Index = 7
        Me.menuItem9.Text = "Exit"
        ' 
        ' Form1
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(542, 445)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.editControl1, Me.panel1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Text Highlighting"
        Me.panel1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
    #End Region
    
    
    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()>  _
    Shared Sub Main()
Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub 'Main
    
    
    Private Function RegisterFormat() As IBackgroundFormat
        Dim background As Color = Color.Empty
        Dim foreground As Color = Color.Empty
        
        If radioButton1.Checked Then
            background = radioButton1.BackColor
        ElseIf radioButton2.Checked Then
            background = radioButton2.BackColor
        ElseIf radioButton3.Checked Then
            background = radioButton3.BackColor
        End If 
        If radioButton6.Checked Then
            foreground = radioButton6.BackColor
        ElseIf radioButton5.Checked Then
            foreground = radioButton5.BackColor
        ElseIf radioButton4.Checked Then
            foreground = radioButton4.BackColor
        End If 
        Dim bUseHatchFille As Boolean = comboBox1.SelectedIndex > 0
        Dim style As HatchStyle
        If bUseHatchFille = True Then
            style = CType([Enum].Parse(GetType(HatchStyle), comboBox1.SelectedItem.ToString()), HatchStyle)
        Else
            style = HatchStyle.Min
        End If
        Dim format As IBackgroundFormat = editControl1.RegisterBackColorFormat(background, foreground, style, bUseHatchFille)
        Return format
    End Function 'RegisterFormat
    
    
    Private Sub button1_Click(sender As Object, e As System.EventArgs) Handles button1.Click
        Dim temp As IDynamicFormat() = editControl1.GetLineBackColorFormats(editControl1.CurrentLine)
        
        Dim format As IBackgroundFormat = RegisterFormat()
        editControl1.SetLineBackColor(editControl1.CurrentLine, True, format)
        
        Me.editControl1.ResetSelection()
    End Sub 'button1_Click
    
    
    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        comboBox1.Items.Clear()
        
        comboBox1.Items.Add("Solid")
        
        Dim name As String
        For Each name In  [Enum].GetNames(GetType(HatchStyle))
            comboBox1.Items.Add(name)
        Next name 
        comboBox1.SelectedText = "Percent05"
        comboBox1.SelectedIndex = 0
        
        editControl1.Text += vbLf
        editControl1.CurrentLine = 1
    End Sub 'Form1_Load
    
    
    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        If Not editControl1.Selection Is Nothing Then
            Dim format As IBackgroundFormat = RegisterFormat()
            editControl1.SetSelectionBackColor(format)

            Me.editControl1.ResetSelection()
        Else
            MessageBox.Show("Please select some text")
        End If
    End Sub 'button2_Click
    
    
    Private Sub MainMenuClick(sender As Object, e As System.EventArgs) Handles menuItem2.Click, menuItem3.Click, menuItem5.Click, menuItem6.Click, menuItem8.Click, menuItem9.Click
        Dim mi As MenuItem = sender 
        
        Select Case mi.Text
            Case "New"
                Me.editControl1.NewFile()
            Case "Open"
                Me.editControl1.LoadFile()
            Case "Save"
                Me.editControl1.Save()
            Case "SaveAs"
                Me.editControl1.SaveAs()
            Case "Close"
                Me.editControl1.Close()
            Case "Exit"
                Me.Close()
        End Select
    End Sub 'MainMenuClick
End Class 'Form1